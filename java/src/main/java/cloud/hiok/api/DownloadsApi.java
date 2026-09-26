// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package cloud.hiok.api;

import cloud.hiok.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** Downloads operations. */
public final class DownloadsApi {
    private final HiokClient c;
    public DownloadsApi(HiokClient client) { this.c = client; }

    /** Cli. [GET /api/downloads/hiok] */
    public JsonNode cli() {
        return c.send("GET", "/api/downloads/hiok", null, null);
    }

    /** Install. [GET /api/downloads/install.sh] */
    public JsonNode install() {
        return c.send("GET", "/api/downloads/install.sh", null, null);
    }

    /** Install ps1. [GET /api/downloads/install.ps1] */
    public JsonNode installPs1() {
        return c.send("GET", "/api/downloads/install.ps1", null, null);
    }

    /** Manifest. [GET /api/downloads/manifest] */
    public JsonNode manifest() {
        return c.send("GET", "/api/downloads/manifest", null, null);
    }

    /** Sdk. [GET /api/downloads/sdk.tar.gz] */
    public JsonNode sdk() {
        return c.send("GET", "/api/downloads/sdk.tar.gz", null, null);
    }
}
