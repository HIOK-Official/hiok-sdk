// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package cloud.hiok.api;

import cloud.hiok.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** OAuth operations. */
public final class OAuthApi {
    private final HiokClient c;
    public OAuthApi(HiokClient client) { this.c = client; }

    /** Get token. [POST /api/OAuth/token] */
    public JsonNode getToken(Object body, Object handoff) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("handoff", handoff);
        return c.send("POST", "/api/OAuth/token", body, query_);
    }
    public JsonNode getToken(Object body) {
        return getToken(body, null);
    }

    /** Redeem handoff. [POST /api/OAuth/handoff/redeem] */
    public JsonNode redeemHandoff(Object body) {
        return c.send("POST", "/api/OAuth/handoff/redeem", body, null);
    }
}
