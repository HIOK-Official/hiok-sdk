// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package cloud.hiok.api;

import cloud.hiok.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** Advisor operations. */
public final class AdvisorApi {
    private final HiokClient c;
    public AdvisorApi(HiokClient client) { this.c = client; }

    /** Create tasks. [POST /api/advisor/tasks] */
    public JsonNode createTasks(Object body) {
        return c.send("POST", "/api/advisor/tasks", body, null);
    }

    /** Delete task. [DELETE /api/advisor/tasks/{id}] */
    public JsonNode deleteTask(String id) {
        return c.send("DELETE", "/api/advisor/tasks/" + HiokClient.segment(id), null, null);
    }

    /** Report. [GET /api/advisor/report] */
    public JsonNode report(Object subscriptionId) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("subscriptionId", subscriptionId);
        return c.send("GET", "/api/advisor/report", null, query_);
    }
    public JsonNode report() {
        return report(null);
    }

    /** Restore. [DELETE /api/advisor/suppressions/{id}] */
    public JsonNode restore(String id) {
        return c.send("DELETE", "/api/advisor/suppressions/" + HiokClient.segment(id), null, null);
    }

    /** Suppress. [POST /api/advisor/suppressions] */
    public JsonNode suppress(Object body) {
        return c.send("POST", "/api/advisor/suppressions", body, null);
    }

    /** Tasks. [GET /api/advisor/tasks] */
    public JsonNode tasks() {
        return c.send("GET", "/api/advisor/tasks", null, null);
    }

    /** Update task. [PATCH /api/advisor/tasks/{id}] */
    public JsonNode updateTask(String id, Object body) {
        return c.send("PATCH", "/api/advisor/tasks/" + HiokClient.segment(id), body, null);
    }
}
