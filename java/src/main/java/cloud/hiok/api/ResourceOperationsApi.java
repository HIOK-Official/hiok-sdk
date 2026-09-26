// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package cloud.hiok.api;

import cloud.hiok.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** ResourceOperations operations. */
public final class ResourceOperationsApi {
    private final HiokClient c;
    public ResourceOperationsApi(HiokClient client) { this.c = client; }

    /** Alerts. [GET /api/resource-ops/{resourceType}/{resourceId}/alerts] */
    public JsonNode alerts(String resourceType, String resourceId) {
        return c.send("GET", "/api/resource-ops/" + HiokClient.segment(resourceType) + "/" + HiokClient.segment(resourceId) + "/alerts", null, null);
    }

    /** Close support. [POST /api/resource-ops/support/{id}/close] */
    public JsonNode closeSupport(String id, Object body) {
        return c.send("POST", "/api/resource-ops/support/" + HiokClient.segment(id) + "/close", body, null);
    }

    /** Delete alert. [DELETE /api/resource-ops/{resourceType}/{resourceId}/alerts/{id}] */
    public JsonNode deleteAlert(String resourceType, String resourceId, String id) {
        return c.send("DELETE", "/api/resource-ops/" + HiokClient.segment(resourceType) + "/" + HiokClient.segment(resourceId) + "/alerts/" + HiokClient.segment(id), null, null);
    }

    /** Delete diagnostic. [DELETE /api/resource-ops/{resourceType}/{resourceId}/diagnostics/{id}] */
    public JsonNode deleteDiagnostic(String resourceType, String resourceId, String id) {
        return c.send("DELETE", "/api/resource-ops/" + HiokClient.segment(resourceType) + "/" + HiokClient.segment(resourceId) + "/diagnostics/" + HiokClient.segment(id), null, null);
    }

    /** Delete task. [DELETE /api/resource-ops/{resourceType}/{resourceId}/tasks/{id}] */
    public JsonNode deleteTask(String resourceType, String resourceId, String id) {
        return c.send("DELETE", "/api/resource-ops/" + HiokClient.segment(resourceType) + "/" + HiokClient.segment(resourceId) + "/tasks/" + HiokClient.segment(id), null, null);
    }

    /** Diagnostics. [GET /api/resource-ops/{resourceType}/{resourceId}/diagnostics] */
    public JsonNode diagnostics(String resourceType, String resourceId) {
        return c.send("GET", "/api/resource-ops/" + HiokClient.segment(resourceType) + "/" + HiokClient.segment(resourceId) + "/diagnostics", null, null);
    }

    /** Health. [GET /api/resource-ops/{resourceType}/{resourceId}/health] */
    public JsonNode health(String resourceType, String resourceId) {
        return c.send("GET", "/api/resource-ops/" + HiokClient.segment(resourceType) + "/" + HiokClient.segment(resourceId) + "/health", null, null);
    }

    /** Logs. [GET /api/resource-ops/{resourceType}/{resourceId}/logs] */
    public JsonNode logs(String resourceType, String resourceId, Object tail) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("tail", tail);
        return c.send("GET", "/api/resource-ops/" + HiokClient.segment(resourceType) + "/" + HiokClient.segment(resourceId) + "/logs", null, query_);
    }
    public JsonNode logs(String resourceType, String resourceId) {
        return logs(resourceType, resourceId, null);
    }

    /** Raise support. [POST /api/resource-ops/{resourceType}/{resourceId}/support] */
    public JsonNode raiseSupport(String resourceType, String resourceId, Object body) {
        return c.send("POST", "/api/resource-ops/" + HiokClient.segment(resourceType) + "/" + HiokClient.segment(resourceId) + "/support", body, null);
    }

    /** Save alert. [POST /api/resource-ops/{resourceType}/{resourceId}/alerts] */
    public JsonNode saveAlert(String resourceType, String resourceId, Object body) {
        return c.send("POST", "/api/resource-ops/" + HiokClient.segment(resourceType) + "/" + HiokClient.segment(resourceId) + "/alerts", body, null);
    }

    /** Save diagnostic. [POST /api/resource-ops/{resourceType}/{resourceId}/diagnostics] */
    public JsonNode saveDiagnostic(String resourceType, String resourceId, Object body) {
        return c.send("POST", "/api/resource-ops/" + HiokClient.segment(resourceType) + "/" + HiokClient.segment(resourceId) + "/diagnostics", body, null);
    }

    /** Save task. [POST /api/resource-ops/{resourceType}/{resourceId}/tasks] */
    public JsonNode saveTask(String resourceType, String resourceId, Object body) {
        return c.send("POST", "/api/resource-ops/" + HiokClient.segment(resourceType) + "/" + HiokClient.segment(resourceId) + "/tasks", body, null);
    }

    /** State. [GET /api/resource-ops/{resourceType}/{resourceId}/state] */
    public JsonNode state(String resourceType, String resourceId, Object name) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("name", name);
        return c.send("GET", "/api/resource-ops/" + HiokClient.segment(resourceType) + "/" + HiokClient.segment(resourceId) + "/state", null, query_);
    }
    public JsonNode state(String resourceType, String resourceId) {
        return state(resourceType, resourceId, null);
    }

    /** Support. [GET /api/resource-ops/{resourceType}/{resourceId}/support] */
    public JsonNode support(String resourceType, String resourceId) {
        return c.send("GET", "/api/resource-ops/" + HiokClient.segment(resourceType) + "/" + HiokClient.segment(resourceId) + "/support", null, null);
    }

    /** Tasks. [GET /api/resource-ops/{resourceType}/{resourceId}/tasks] */
    public JsonNode tasks(String resourceType, String resourceId) {
        return c.send("GET", "/api/resource-ops/" + HiokClient.segment(resourceType) + "/" + HiokClient.segment(resourceId) + "/tasks", null, null);
    }

    /** Template. [GET /api/resource-ops/{resourceType}/{resourceId}/template] */
    public JsonNode template(String resourceType, String resourceId) {
        return c.send("GET", "/api/resource-ops/" + HiokClient.segment(resourceType) + "/" + HiokClient.segment(resourceId) + "/template", null, null);
    }

    /** Update alert. [PUT /api/resource-ops/{resourceType}/{resourceId}/alerts/{id}] */
    public JsonNode updateAlert(String resourceType, String resourceId, String id, Object body) {
        return c.send("PUT", "/api/resource-ops/" + HiokClient.segment(resourceType) + "/" + HiokClient.segment(resourceId) + "/alerts/" + HiokClient.segment(id), body, null);
    }

    /** Update task. [PUT /api/resource-ops/{resourceType}/{resourceId}/tasks/{id}] */
    public JsonNode updateTask(String resourceType, String resourceId, String id, Object body) {
        return c.send("PUT", "/api/resource-ops/" + HiokClient.segment(resourceType) + "/" + HiokClient.segment(resourceId) + "/tasks/" + HiokClient.segment(id), body, null);
    }
}
