// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package cloud.hiok.api;

import cloud.hiok.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** Assistant operations. */
public final class AssistantApi {
    private final HiokClient c;
    public AssistantApi(HiokClient client) { this.c = client; }

    /** Act. [POST /api/assistant/act] */
    public JsonNode act(Object body) {
        return c.send("POST", "/api/assistant/act", body, null);
    }

    /** Ask. [POST /api/assistant/ask] */
    public JsonNode ask(Object body) {
        return c.send("POST", "/api/assistant/ask", body, null);
    }

    /** Findings. [GET /api/assistant/findings] */
    public JsonNode findings() {
        return c.send("GET", "/api/assistant/findings", null, null);
    }

    /** Stream. [POST /api/assistant/stream] */
    public JsonNode stream() {
        return c.send("POST", "/api/assistant/stream", null, null);
    }
}
