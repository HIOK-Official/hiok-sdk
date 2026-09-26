# Live SDK tests

Each test runs against a real HIOK deployment: it lists Key Vaults through the
generated layer, uploads 20 MB to a storage account in blocks and downloads it back
(byte-identical), checks that a storage access key reads its own account and is
refused everywhere else, and deletes everything it created.

```bash
export HIOK_ENDPOINT=https://test.hiokcloud.com
export HIOK_TOKEN=...                        # a bearer token
export HIOK_TEST_STORAGE_ACCOUNT=my-account  # name of a storage account the token owns

python3 tests/python_live.py
pip install b2sdk && python3 tests/backblaze_e2e.py     # Backblaze <-> HIOK, against b2sdk's simulator
(cd typescript && npm ci && npm run build) && node tests/typescript_live.mjs
```

.NET, Java and Go: copy `DotnetLive.cs.txt` into a console project referencing
`dotnet/Hiok.Cloud` as `Program.cs`; run `JavaLive.java` with the SDK jar and its
dependencies on the classpath (`java -cp target/hiok-sdk-0.2.0.jar:$(mvn -q dependency:build-classpath -Dmdep.outputFile=/dev/stdout) tests/JavaLive.java`);
copy `go_live.go.txt` to `main.go` in a module that requires this SDK.
