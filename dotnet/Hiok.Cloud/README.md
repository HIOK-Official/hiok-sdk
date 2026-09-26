# Hiok.Cloud — HIOK Cloud SDK for .NET

Every HIOK Cloud API operation (837 of them) plus a storage helper that moves files of any size.
Targets .NET 8 and .NET 10.

```bash
dotnet add package Hiok.Cloud
```

```csharp
using Hiok.Cloud;

var client = new HiokClient("https://test.hiokcloud.com", Environment.GetEnvironmentVariable("HIOK_TOKEN"));

await client.Storage.UploadFileAsync(accountId, "backups", "2026/db.dump", "/var/backups/db.dump");
await client.Storage.DownloadFileAsync(accountId, "backups", "2026/db.dump", "/tmp/db.dump");
```

Every operation is on `client.Api.<Group>.<Operation>Async()`. Uploads go in parallel 3 MB
blocks, downloads in ranges, and both are sha256-verified.

Documentation: https://test.hiokcloud.com/docs · Source: https://github.com/HIOK-Official/hiok-sdk
