#!/usr/bin/env bash
# Publish the packages build-packages.sh made to the Azure Artifacts feed "HiokCloud"
# (organization Hiok): NuGet, npm, PyPI and Maven. Needs AZURE_ARTIFACTS_PAT, a PAT
# with Packaging (Read & write). Versions already on the feed are refused by the
# feed, so bump the version before publishing again.
set -euo pipefail
: "${AZURE_ARTIFACTS_PAT:?set AZURE_ARTIFACTS_PAT}"
HERE="$(cd "$(dirname "$0")" && pwd)"
PKG="$HERE/../HIOK-Common-Backend/Hiok.Api/Cli/sdk"
FEED=https://pkgs.dev.azure.com/Hiok/_packaging/HiokCloud
V=$(sed -n 's/^V=//p' "$HERE/build-packages.sh")
export PATH="$HOME/.dotnet:$HOME/.node/bin:$PATH"
T=$(mktemp -d); chmod 700 "$T"; trap 'rm -rf "$T"' EXIT

echo "nuget";  printf '<?xml version="1.0"?><configuration><packageSources><add key="HiokCloud" value="%s/nuget/v3/index.json"/></packageSources></configuration>' "$FEED" > "$T/NuGet.Config"
NuGetPackageSourceCredentials_HiokCloud="Username=Hiok;Password=$AZURE_ARTIFACTS_PAT" \
  dotnet nuget push "$PKG/Hiok.Cloud.$V.nupkg" --source HiokCloud --api-key az --skip-duplicate --configfile "$T/NuGet.Config"

echo "npm";    R=//pkgs.dev.azure.com/Hiok/_packaging/HiokCloud/npm/registry/
printf 'registry=https:%s\n%s:username=Hiok\n%s:_password=%s\n%s:email=npm@hiokcloud.com\n' "$R" "$R" "$R" "$(printf '%s' "$AZURE_ARTIFACTS_PAT" | base64 -w0)" "$R" > "$T/npmrc"
npm publish "$PKG/hiok-cloud-$V.tgz" --userconfig "$T/npmrc"

echo "pypi";   python3 -m venv "$T/venv" && "$T/venv/bin/pip" -q install twine
TWINE_USERNAME=Hiok TWINE_PASSWORD="$AZURE_ARTIFACTS_PAT" "$T/venv/bin/twine" upload --non-interactive \
  --repository-url "$FEED/pypi/upload/" "$PKG/hiok_cloud-$V-py3-none-any.whl"

echo "maven";  printf '<settings><servers><server><id>HiokCloud</id><username>Hiok</username><password>%s</password></server></servers></settings>' "$AZURE_ARTIFACTS_PAT" > "$T/settings.xml"
cp "$PKG/hiok-sdk-$V.jar" "$PKG/hiok-sdk-$V.pom" "$T/"
docker run --rm -v "$T":/w -v hiok-m2:/root/.m2 -w /w maven:3.9-eclipse-temurin-21 mvn -q -B -s /w/settings.xml \
  deploy:deploy-file -Dfile="/w/hiok-sdk-$V.jar" -DpomFile="/w/hiok-sdk-$V.pom" -DrepositoryId=HiokCloud -Durl="$FEED/maven/v1"
echo "published $V to $FEED"
