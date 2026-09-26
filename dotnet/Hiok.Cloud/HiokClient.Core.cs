#nullable enable
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace Hiok.Cloud;

public sealed partial class HiokClient
{
    private HiokApi? _api;
    private StorageTransfer? _storage;

    /// <summary>Every API operation, grouped as the API groups them: <c>client.Api.KeyVault.ListAsync()</c>.</summary>
    public HiokApi Api => _api ??= new HiokApi(this);

    /// <summary>Large-file upload and download for storage accounts.</summary>
    public StorageTransfer Storage => _storage ??= new StorageTransfer(this);

    /// <summary>
    /// A storage account access key. Used when no bearer token is set; it opens only
    /// that account's containers, file shares, queues and tables.
    /// </summary>
    public string? StorageKey { get; set; }

    /// <summary>Attempts for a safe request (GET/HEAD) that meets 429, 502, 503 or 504.</summary>
    public int Retries { get; set; } = 4;

    /// <summary>
    /// A client configured from HIOK_ENDPOINT, HIOK_TOKEN and HIOK_STORAGE_KEY.
    /// </summary>
    public static HiokClient FromEnvironment() =>
        new(Environment.GetEnvironmentVariable("HIOK_ENDPOINT") ?? "https://hiokcloud.com",
            Environment.GetEnvironmentVariable("HIOK_TOKEN"))
        { StorageKey = Environment.GetEnvironmentVariable("HIOK_STORAGE_KEY") };

    /// <summary>Encodes one path parameter; a key keeps its slashes ("dir/file.txt").</summary>
    public static string Segment(string value, bool slashed = false) =>
        slashed
            ? string.Join('/', (value ?? string.Empty).Split('/').Select(Uri.EscapeDataString))
            : Uri.EscapeDataString(value ?? string.Empty);

    internal static string Query(IDictionary<string, object?>? query)
    {
        if (query == null) return string.Empty;
        var parts = new List<string>();
        foreach (var (key, value) in query)
        {
            if (value == null) continue;
            IEnumerable<object?> values = value is System.Collections.IEnumerable list && value is not string
                ? list.Cast<object?>()
                : new[] { value };
            foreach (var v in values)
            {
                if (v == null) continue;
                var text = v switch
                {
                    bool b => b ? "true" : "false",
                    DateTimeOffset d => d.ToString("o"),
                    DateTime d => d.ToString("o"),
                    IFormattable f => f.ToString(null, System.Globalization.CultureInfo.InvariantCulture),
                    _ => v.ToString() ?? string.Empty,
                };
                parts.Add(Uri.EscapeDataString(key) + "=" + Uri.EscapeDataString(text));
            }
        }
        return parts.Count == 0 ? string.Empty : "?" + string.Join('&', parts);
    }

    private void Authorize(HttpRequestMessage request)
    {
        if (!string.IsNullOrWhiteSpace(_token))
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", _token);
        else if (!string.IsNullOrWhiteSpace(StorageKey))
            request.Headers.TryAddWithoutValidation("x-hiok-storage-key", StorageKey);
        else
            throw new HiokException("No credentials: set a token, a StorageKey, or call LoginAsync first");
    }

    /// <summary>
    /// Sends one request and parses the JSON answer (null when there is none). Used by
    /// every generated operation; call it directly for anything not covered.
    /// </summary>
    public async Task<JsonNode?> InvokeAsync(HttpMethod method, string path, object? body, IDictionary<string, object?>? query, CancellationToken ct = default)
    {
        var bytes = await InvokeRawAsync(method, path, body, query, null, ct);
        if (bytes.Length == 0) return null;
        try { return JsonNode.Parse(bytes); }
        catch (JsonException) { return JsonValue.Create(Encoding.UTF8.GetString(bytes)); }
    }

    /// <summary>Sends one request and returns the raw response body.</summary>
    public async Task<byte[]> InvokeRawAsync(HttpMethod method, string path, object? body, IDictionary<string, object?>? query,
        IDictionary<string, string>? headers, CancellationToken ct = default)
    {
        var safe = method == HttpMethod.Get || method == HttpMethod.Head || method == HttpMethod.Options;
        var attempts = safe ? Retries + 1 : 1;
        for (var attempt = 0; ; attempt++)
        {
            using var request = new HttpRequestMessage(method, path.TrimStart('/') + Query(query));
            Authorize(request);
            if (headers != null)
                foreach (var (k, v) in headers) request.Headers.TryAddWithoutValidation(k, v);
            if (body is byte[] raw) request.Content = new ByteArrayContent(raw);
            else if (body != null) request.Content = new StringContent(JsonSerializer.Serialize(body, JsonOptions), Encoding.UTF8, "application/json");

            HttpResponseMessage response;
            try
            {
                response = await _http.SendAsync(request, ct);
            }
            catch (HttpRequestException) when (attempt + 1 < attempts)
            {
                await Task.Delay(Backoff(attempt), ct);
                continue;
            }
            using (response)
            {
                var content = await response.Content.ReadAsByteArrayAsync(ct);
                if (response.IsSuccessStatusCode) return content;
                var code = (int)response.StatusCode;
                if ((code == 429 || code == 502 || code == 503 || code == 504) && attempt + 1 < attempts)
                {
                    await Task.Delay(Backoff(attempt), ct);
                    continue;
                }
                throw HiokException.From(method, path, response.StatusCode, content);
            }
        }
    }

    /// <summary>Sends multipart/form-data: fields and files.</summary>
    public async Task<JsonNode?> InvokeMultipartAsync(HttpMethod method, string path, IDictionary<string, string>? form,
        IDictionary<string, (string FileName, byte[] Content)>? files, IDictionary<string, object?>? query, CancellationToken ct = default)
    {
        using var request = new HttpRequestMessage(method, path.TrimStart('/') + Query(query));
        Authorize(request);
        var multipart = new MultipartFormDataContent();
        foreach (var (k, v) in form ?? new Dictionary<string, string>()) multipart.Add(new StringContent(v), k);
        foreach (var (k, v) in files ?? new Dictionary<string, (string, byte[])>()) multipart.Add(new ByteArrayContent(v.Content), k, v.FileName);
        request.Content = multipart;
        using var response = await _http.SendAsync(request, ct);
        var content = await response.Content.ReadAsByteArrayAsync(ct);
        if (!response.IsSuccessStatusCode) throw HiokException.From(method, path, response.StatusCode, content);
        return content.Length == 0 ? null : JsonNode.Parse(content);
    }

    private static TimeSpan Backoff(int attempt) => TimeSpan.FromSeconds(Math.Min(16, Math.Pow(2, attempt)));

    internal static readonly JsonSerializerOptions JsonOptions = new(JsonSerializerDefaults.Web)
    {
        DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
    };
}

public sealed partial class HiokException
{
    /// <summary>The API's parsed response, when it sent one.</summary>
    public JsonNode? Body { get; private init; }

    internal static HiokException From(HttpMethod method, string path, HttpStatusCode status, byte[] content)
    {
        JsonNode? body = null;
        var message = Encoding.UTF8.GetString(content);
        try
        {
            body = content.Length == 0 ? null : JsonNode.Parse(content);
            message = body?["message"]?.GetValue<string>() ?? body?["Message"]?.GetValue<string>() ?? message;
        }
        catch (Exception) { }
        return new HiokException($"{method} {path} returned {(int)status}: {message}", status) { Body = body };
    }
}
