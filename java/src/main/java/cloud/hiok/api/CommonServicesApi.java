// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package cloud.hiok.api;

import cloud.hiok.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** CommonServices operations. */
public final class CommonServicesApi {
    private final HiokClient c;
    public CommonServicesApi(HiokClient client) { this.c = client; }

    /** Get random string. [GET /api/CommonServices/randomstring] */
    public JsonNode getRandomString(Object length) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("length", length);
        return c.send("GET", "/api/CommonServices/randomstring", null, query_);
    }
    public JsonNode getRandomString() {
        return getRandomString(null);
    }
}
