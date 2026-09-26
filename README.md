# HIOK Cloud SDKs

Official source SDKs for HIOK Cloud.

| Language | Install |
|---|---|
| Python 3.10+ | `pip install hiok-cloud` |
| .NET 8 / 10 | `dotnet add package Hiok.Cloud` |
| Java 17+ | Maven `com.hiokcloud:hiok-sdk` |
| TypeScript / Node 20+ | `npm install @hiok/cloud` |
| Go 1.23+ | `go get github.com/HIOK-Official/hiok-sdk/go` |

All SDKs use the same REST API and support either a bearer token or email/password sign-in. Tokens and passwords must come from environment variables or a secret manager, never source control.

## API endpoint

Production: `https://hiokcloud.com`

For a private deployment, pass its base URL to the client constructor.

## Coverage

Every SDK carries **every API operation** — 906 operations in 94 groups — generated
from the API's own OpenAPI document by [`generator/generate.py`](generator/generate.py),
plus a hand-written core (authentication, retries through deploys, errors) and a
storage transfer helper for files of any size.

| Language | Package | Operations | Storage transfer |
|---|---|---|---|
| Python 3.10+ | `hiok-cloud` | `client.api.<group>.<operation>()` | `client.storage.upload_file()` / `download_file()` / `upload_stream()` / `iter_download()` |
| .NET 8 / 10 | `Hiok.Cloud` | `client.Api.<Group>.<Operation>Async()` | `client.Storage.UploadFileAsync()` / `DownloadFileAsync()` / `UploadStreamAsync()` |
| Java 17+ | `com.hiokcloud:hiok-sdk` | `client.api().<group>().<operation>()` | `client.storage().uploadFile()` / `downloadFile()` / `uploadStream()` |
| TypeScript / Node 20+ | `@hiok/cloud` | `client.api.<group>.<operation>()` | `client.storage.uploadFile()` / `downloadFile()` / `upload()` / `download()` |
| Go 1.23+ | `github.com/HIOK-Official/hiok-sdk/go` | `client.API().<Group>.<Operation>(ctx)` | `client.Storage().UploadFile()` / `DownloadFile()` / `UploadStream()` |

`operations.json` lists every operation with its HTTP route and the call in each
language. Regenerate after any API change:

```bash
python3 generator/generate.py                                  # from a running API
python3 generator/generate.py --spec swagger.json              # from a saved document
```

## Azure Artifacts feed (HIOK organization)

Members of the Hiok Azure DevOps organization can install every SDK from the
`HiokCloud` feed (sign in with a PAT with Packaging → Read):

```bash
pip install hiok-cloud --index-url https://pkgs.dev.azure.com/Hiok/_packaging/HiokCloud/pypi/simple/
npm install @hiok/cloud --registry https://pkgs.dev.azure.com/Hiok/_packaging/HiokCloud/npm/registry/
dotnet add package Hiok.Cloud --source https://pkgs.dev.azure.com/Hiok/_packaging/HiokCloud/nuget/v3/index.json
# Maven: repository https://pkgs.dev.azure.com/Hiok/_packaging/HiokCloud/maven/v1, com.hiokcloud:hiok-sdk
```

Publish a release there with `AZURE_ARTIFACTS_PAT=... ./publish-azure-feed.sh` after `./build-packages.sh`.

## Authentication

- **Bearer token**: `HIOK_TOKEN` or the `token` option; or sign in with email and password.
- **Storage access key**: `HIOK_STORAGE_KEY` or the `storageKey` option. It opens only its own
  storage account's containers, file shares, queues and tables (a read key only reads) —
  the right credential for an application or a batch job that moves files.

GET requests are retried on 429/502/503/504 with backoff; writes are never repeated.

## Examples and tests

- [`examples/python/backblaze_sync.py`](examples/python/backblaze_sync.py) — copy between Backblaze B2 and a HIOK storage account in either direction, streaming, sha1/sha256-verified, resumable.
- [`tests/`](tests/) — live tests for all five SDKs and the Backblaze flow.
