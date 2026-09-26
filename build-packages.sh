#!/usr/bin/env bash
# Build every SDK's installable package and place them where the API embeds and
# serves them (GET /api/downloads/sdk/<file>). Run after generator/generate.py.
#
#   Python      hiok_cloud-<v>-py3-none-any.whl
#   .NET        Hiok.Cloud.<v>.nupkg
#   Java        hiok-sdk-<v>.jar + hiok-sdk-<v>.pom
#   TypeScript  hiok-cloud-<v>.tgz
#   Go          hiok-sdk-go-<v>.tar.gz
set -euo pipefail
HERE="$(cd "$(dirname "$0")" && pwd)"
OUT="$HERE/../HIOK-Common-Backend/Hiok.Api/Cli/sdk"
V=0.3.0
rm -rf "$OUT" && mkdir -p "$OUT"
export PATH="$HOME/.go/bin:$HOME/.node/bin:$HOME/.dotnet:$PATH"

echo "python";  (cd "$HERE/python" && rm -rf build dist && python3 -m pip wheel -q --no-deps -w "$OUT" . && rm -rf build src/*.egg-info)
echo ".net";    (cd "$HERE/dotnet/Hiok.Cloud" && dotnet pack -c Release -o "$OUT" -v q -p:Version=$V >/dev/null)
echo "java";    docker run --rm -v "$HERE/java":/src -v hiok-m2:/root/.m2 -w /src maven:3.9-eclipse-temurin-21 \
                  sh -c "mvn -q -B package -DskipTests && cp target/hiok-sdk-$V.jar /src/hiok-sdk-$V.jar && cp pom.xml /src/hiok-sdk-$V.pom && rm -rf target && chown '"$(id -u):$(id -g)"' /src/hiok-sdk-$V.jar /src/hiok-sdk-$V.pom"
                mv "$HERE/java/hiok-sdk-$V.jar" "$HERE/java/hiok-sdk-$V.pom" "$OUT/"
echo "typescript"; (cd "$HERE/typescript" && npm ci --silent && npm run -s build && npm pack --silent --pack-destination "$OUT" >/dev/null)
echo "go";      (cd "$HERE" && tar czf "$OUT/hiok-sdk-go-$V.tar.gz" --transform "s,^go,hiok-sdk-go," go)
cp "$HERE/operations.json" "$OUT/operations.json"
cp "$HERE/examples/python/backblaze_sync.py" "$OUT/backblaze_sync.py"
ls -la "$OUT"
