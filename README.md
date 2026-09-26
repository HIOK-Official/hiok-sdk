# HIOK Cloud SDKs

Official source SDKs for HIOK Cloud.

- [TypeScript](typescript/) — browser or Node.js
- [Python](python/) — Python 3.10+
- [Go](go/) — Go 1.23+
- [.NET](dotnet/) — .NET 10+

All SDKs use the same REST API and support either a bearer token or email/password sign-in. Tokens and passwords must come from environment variables or a secret manager, never source control.

## API endpoint

Production: `https://hiokcloud.com`

For a private deployment, pass its base URL to the client constructor.

## Coverage

Every SDK carries **every API operation** — 837 operations in 89 groups — generated
from the API's own OpenAPI document by [`generator/generate.py`](generator/generate.py),
plus a hand-written core (authentication, retries through deploys, errors) and a
storage transfer helper for files of any size.

| Language | Package | Operations | Storage transfer |
|---|---|---|---|
| Python 3.10+ | `hiok-cloud` | `client.api.<group>.<operation>()` | `client.storage.upload_file()` / `download_file()` / `upload_stream()` / `iter_download()` |
| .NET 10 | `Hiok.Cloud` | `client.Api.<Group>.<Operation>Async()` | `client.Storage.UploadFileAsync()` / `DownloadFileAsync()` / `UploadStreamAsync()` |
| Java 17+ | `cloud.hiok:hiok-sdk` | `client.api().<group>().<operation>()` | `client.storage().uploadFile()` / `downloadFile()` / `uploadStream()` |
| TypeScript / Node 20+ | `@hiok/cloud` | `client.api.<group>.<operation>()` | `client.storage.uploadFile()` / `downloadFile()` / `upload()` / `download()` |
| Go 1.23+ | `github.com/HIOK-Official/hiok-sdk/go` | `client.API().<Group>.<Operation>(ctx)` | `client.Storage().UploadFile()` / `DownloadFile()` / `UploadStream()` |

`operations.json` lists every operation with its HTTP route and the call in each
language. Regenerate after any API change:

```bash
python3 generator/generate.py                                  # from a running API
python3 generator/generate.py --spec swagger.json              # from a saved document
```

## Authentication

- **Bearer token**: `HIOK_TOKEN` or the `token` option; or sign in with email and password.
- **Storage access key**: `HIOK_STORAGE_KEY` or the `storageKey` option. It opens only its own
  storage account's containers, file shares, queues and tables (a read key only reads) —
  the right credential for an application or a batch job that moves files.

GET requests are retried on 429/502/503/504 with backoff; writes are never repeated.

## Examples and tests

- [`examples/python/backblaze_sync.py`](examples/python/backblaze_sync.py) — copy between Backblaze B2 and a HIOK storage account in either direction, streaming, sha1/sha256-verified, resumable.
- [`tests/`](tests/) — live tests for all five SDKs and the Backblaze flow.
