#nullable enable
using System.Security.Cryptography;
using System.Text.Json.Nodes;

namespace Hiok.Cloud;

/// <summary>
/// Moving files in and out of storage accounts.
///
/// <code>
/// await client.Storage.UploadFileAsync(accountId, "backups", "2026/db.dump", "/var/backups/db.dump");
/// await client.Storage.DownloadFileAsync(accountId, "backups", "2026/db.dump", "/tmp/db.dump");
/// await client.Storage.UploadStreamAsync(accountId, "backups", "big.bin", anyReadableStream);
/// </code>
///
/// A write reaches the region in one message, which caps it at 3 MB, so larger
/// content is staged as 3 MB blocks (several at once) and committed as one object;
/// reads of a large object are ranged the same way, so memory stays flat.
/// </summary>
public sealed class StorageTransfer
{
    public const int BlockSize = 3 * 1024 * 1024;
    private readonly HiokClient _c;

    internal StorageTransfer(HiokClient client) => _c = client;

    private static string Content(string accountId, string container, string key) =>
        $"/api/storageaccount/{HiokClient.Segment(accountId)}/containers/{HiokClient.Segment(container)}/content/{HiokClient.Segment(key, true)}";

    public async Task<JsonNode?> EnsureContainerAsync(string accountId, string name, string kind = "blob", CancellationToken ct = default)
    {
        try { return (await _c.Api.StorageObject.GetContainerAsync(accountId, name, ct))?["data"]; }
        catch (HiokException e) when (e.StatusCode == System.Net.HttpStatusCode.NotFound) { }
        return (await _c.Api.StorageObject.CreateContainerAsync(accountId, new { name, kind }, ct))?["data"];
    }

    public async Task<JsonArray> ListAsync(string accountId, string container, string? prefix = null, string? path = null, CancellationToken ct = default) =>
        (await _c.Api.StorageObject.ListObjectsAsync(accountId, container, prefix: prefix, path: path, limit: 5000, ct: ct))?["data"]?.AsArray() ?? new JsonArray();

    public async Task<JsonNode?> StatAsync(string accountId, string container, string key, CancellationToken ct = default) =>
        (await _c.Api.StorageObject.GetObjectAsync(accountId, container, key, ct))?["data"];

    public Task DeleteAsync(string accountId, string container, string key, CancellationToken ct = default) =>
        _c.Api.StorageObject.DeleteObjectAsync(accountId, container, key, ct);

    public async Task<JsonNode?> UploadFileAsync(string accountId, string container, string key, string localPath,
        string? contentType = null, IProgress<long>? progress = null, CancellationToken ct = default)
    {
        await using var file = File.OpenRead(localPath);
        return await UploadStreamAsync(accountId, container, key, file, contentType, progress: progress, ct: ct);
    }

    /// <summary>Uploads from any readable stream, of known or unknown length.</summary>
    public async Task<JsonNode?> UploadStreamAsync(string accountId, string container, string key, Stream source,
        string? contentType = null, int parallelism = 4, IProgress<long>? progress = null, CancellationToken ct = default)
    {
        var first = await ReadBlockAsync(source, ct);
        if (first.Length < BlockSize)
        {
            var single = await _c.Api.StorageObject.PutObjectAsync(accountId, container,
                new { key, content = Convert.ToBase64String(first), isBase64 = true, contentType }, ct);
            progress?.Report(first.Length);
            return single?["data"];
        }

        var upload = Guid.NewGuid().ToString("N")[..12];
        var ids = new List<string>();
        var running = new List<Task>();
        using var gate = new SemaphoreSlim(Math.Max(1, parallelism));
        long done = 0;
        var block = first;
        while (block.Length > 0)
        {
            var id = $"sdk-{upload}-{ids.Count:D6}";
            ids.Add(id);
            await gate.WaitAsync(ct);
            var content = block;
            running.Add(Task.Run(async () =>
            {
                try
                {
                    await _c.Api.StorageObject.StageBlockAsync(accountId, container,
                        new { blobName = key, blockId = id, content = Convert.ToBase64String(content), isBase64 = true }, ct);
                    progress?.Report(Interlocked.Add(ref done, content.Length));
                }
                finally { gate.Release(); }
            }, ct));
            block = await ReadBlockAsync(source, ct);
        }
        await Task.WhenAll(running);

        var committed = await _c.Api.StorageObject.CommitBlockListAsync(accountId, container,
            new { blobName = key, blockIds = ids, contentType, discardStagedBlocks = true }, ct);
        return committed?["data"];
    }

    /// <summary>Writes the object to a stream, fetched in 3 MB ranges.</summary>
    public async Task<long> DownloadStreamAsync(string accountId, string container, string key, Stream destination,
        IProgress<long>? progress = null, CancellationToken ct = default)
    {
        var size = (await StatAsync(accountId, container, key, ct))?["sizeBytes"]?.GetValue<long>() ?? 0;
        long done = 0;
        while (done < size)
        {
            var end = Math.Min(done + BlockSize, size) - 1;
            var chunk = await _c.InvokeRawAsync(HttpMethod.Get, Content(accountId, container, key), null, null,
                new Dictionary<string, string> { ["Range"] = $"bytes={done}-{end}" }, ct);
            if (chunk.Length == 0) break;
            await destination.WriteAsync(chunk, ct);
            done += chunk.Length;
            progress?.Report(done);
        }
        return done;
    }

    /// <summary>
    /// Downloads to a file (through a temporary name), checking the sha256 stored with
    /// the object when it has one.
    /// </summary>
    public async Task<long> DownloadFileAsync(string accountId, string container, string key, string localPath,
        IProgress<long>? progress = null, CancellationToken ct = default)
    {
        Directory.CreateDirectory(Path.GetDirectoryName(Path.GetFullPath(localPath))!);
        var partial = localPath + ".partial";
        long written;
        await using (var file = File.Create(partial))
            written = await DownloadStreamAsync(accountId, container, key, file, progress, ct);

        var expected = (await StatAsync(accountId, container, key, ct))?["contentHash"]?.GetValue<string>();
        if (expected is { Length: 64 })
        {
            await using var check = File.OpenRead(partial);
            var actual = Convert.ToHexString(await SHA256.HashDataAsync(check, ct)).ToLowerInvariant();
            if (!string.Equals(actual, expected, StringComparison.OrdinalIgnoreCase))
            {
                File.Delete(partial);
                throw new HiokException($"{key}: downloaded content does not match the stored sha256");
            }
        }
        File.Move(partial, localPath, overwrite: true);
        return written;
    }

    private static async Task<byte[]> ReadBlockAsync(Stream source, CancellationToken ct)
    {
        var buffer = new byte[BlockSize];
        var total = 0;
        while (total < BlockSize)
        {
            var n = await source.ReadAsync(buffer.AsMemory(total), ct);
            if (n == 0) break;
            total += n;
        }
        return total == BlockSize ? buffer : buffer[..total];
    }
}
