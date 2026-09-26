// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package cloud.hiok.api;

import cloud.hiok.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** Profile operations. */
public final class ProfileApi {
    private final HiokClient c;
    public ProfileApi(HiokClient client) { this.c = client; }

    /** Api keys. [GET /api/profile/api-keys] */
    public JsonNode apiKeys() {
        return c.send("GET", "/api/profile/api-keys", null, null);
    }

    /** Get. [GET /api/profile] */
    public JsonNode get() {
        return c.send("GET", "/api/profile", null, null);
    }

    /** Roll key. [POST /api/profile/api-keys/{which}/roll] */
    public JsonNode rollKey(String which) {
        return c.send("POST", "/api/profile/api-keys/" + HiokClient.segment(which) + "/roll", null, null);
    }

    /** Update. [PUT /api/profile] */
    public JsonNode update(Object body) {
        return c.send("PUT", "/api/profile", body, null);
    }
}
