// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package cloud.hiok.api;

import cloud.hiok.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** K9sConsole operations. */
public final class K9sConsoleApi {
    private final HiokClient c;
    public K9sConsoleApi(HiokClient client) { this.c = client; }

    /** Console. [GET /api/kubernetes/clusters/{id}/console] */
    public JsonNode console(String id) {
        return c.send("GET", "/api/kubernetes/clusters/" + HiokClient.segment(id) + "/console", null, null);
    }

    /** Status. [GET /api/kubernetes/clusters/{id}/console/status] */
    public JsonNode status(String id) {
        return c.send("GET", "/api/kubernetes/clusters/" + HiokClient.segment(id) + "/console/status", null, null);
    }
}
