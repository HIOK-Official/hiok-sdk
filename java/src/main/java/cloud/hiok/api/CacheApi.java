// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package cloud.hiok.api;

import cloud.hiok.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** Cache operations. */
public final class CacheApi {
    private final HiokClient c;
    public CacheApi(HiokClient client) { this.c = client; }

    /** Add region. [POST /api/Cache/{id}/regions] */
    public JsonNode addRegion(String id, Object body) {
        return c.send("POST", "/api/Cache/" + HiokClient.segment(id) + "/regions", body, null);
    }

    /** Command. [POST /api/Cache/{id}/command] */
    public JsonNode command(String id, Object body) {
        return c.send("POST", "/api/Cache/" + HiokClient.segment(id) + "/command", body, null);
    }

    /** Create. [POST /api/Cache] */
    public JsonNode create(Object body) {
        return c.send("POST", "/api/Cache", body, null);
    }

    /** Delete. [DELETE /api/Cache/{id}] */
    public JsonNode delete(String id) {
        return c.send("DELETE", "/api/Cache/" + HiokClient.segment(id), null, null);
    }

    /** Get. [GET /api/Cache/{id}] */
    public JsonNode get(String id) {
        return c.send("GET", "/api/Cache/" + HiokClient.segment(id), null, null);
    }

    /** Keys. [GET /api/Cache/{id}/keys] */
    public JsonNode keys(String id) {
        return c.send("GET", "/api/Cache/" + HiokClient.segment(id) + "/keys", null, null);
    }

    /** List. [GET /api/Cache] */
    public JsonNode list() {
        return c.send("GET", "/api/Cache", null, null);
    }

    /** Logs. [GET /api/Cache/{id}/logs] */
    public JsonNode logs(String id, Object region, Object tail) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("region", region);
        query_.put("tail", tail);
        return c.send("GET", "/api/Cache/" + HiokClient.segment(id) + "/logs", null, query_);
    }
    public JsonNode logs(String id) {
        return logs(id, null, null);
    }

    /** Metrics. [GET /api/Cache/{id}/metrics] */
    public JsonNode metrics(String id, Object hours, Object region) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("hours", hours);
        query_.put("region", region);
        return c.send("GET", "/api/Cache/" + HiokClient.segment(id) + "/metrics", null, query_);
    }
    public JsonNode metrics(String id) {
        return metrics(id, null, null);
    }

    /** Remove region. [DELETE /api/Cache/{id}/regions/{region}] */
    public JsonNode removeRegion(String id, String region) {
        return c.send("DELETE", "/api/Cache/" + HiokClient.segment(id) + "/regions/" + HiokClient.segment(region), null, null);
    }

    /** Rotate. [POST /api/Cache/{id}/keys/rotate] */
    public JsonNode rotate(String id) {
        return c.send("POST", "/api/Cache/" + HiokClient.segment(id) + "/keys/rotate", null, null);
    }

    /** Stats. [GET /api/Cache/{id}/stats] */
    public JsonNode stats(String id, Object region) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("region", region);
        return c.send("GET", "/api/Cache/" + HiokClient.segment(id) + "/stats", null, query_);
    }
    public JsonNode stats(String id) {
        return stats(id, null);
    }
}
