// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package cloud.hiok.api;

import cloud.hiok.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** IoTHubDiagnostics operations. */
public final class IoTHubDiagnosticsApi {
    private final HiokClient c;
    public IoTHubDiagnosticsApi(HiokClient client) { this.c = client; }

    /** Create setting. [POST /api/iothub/{hubId}/diagnostic-settings] */
    public JsonNode createSetting(String hubId, Object body) {
        return c.send("POST", "/api/iothub/" + HiokClient.segment(hubId) + "/diagnostic-settings", body, null);
    }

    /** Delete setting. [DELETE /api/iothub/{hubId}/diagnostic-settings/{id}] */
    public JsonNode deleteSetting(String hubId, String id) {
        return c.send("DELETE", "/api/iothub/" + HiokClient.segment(hubId) + "/diagnostic-settings/" + HiokClient.segment(id), null, null);
    }

    /** Destinations. [GET /api/iothub/diagnostic-destinations] */
    public JsonNode destinations() {
        return c.send("GET", "/api/iothub/diagnostic-destinations", null, null);
    }

    /** List settings. [GET /api/iothub/{hubId}/diagnostic-settings] */
    public JsonNode listSettings(String hubId) {
        return c.send("GET", "/api/iothub/" + HiokClient.segment(hubId) + "/diagnostic-settings", null, null);
    }

    /** Log categories. [GET /api/iothub/log-categories] */
    public JsonNode logCategories() {
        return c.send("GET", "/api/iothub/log-categories", null, null);
    }

    /** Logs. [GET /api/iothub/{hubId}/logs] */
    public JsonNode logs(String hubId, Object category, Object deviceId, Object limit) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("category", category);
        query_.put("deviceId", deviceId);
        query_.put("limit", limit);
        return c.send("GET", "/api/iothub/" + HiokClient.segment(hubId) + "/logs", null, query_);
    }
    public JsonNode logs(String hubId) {
        return logs(hubId, null, null, null);
    }

    /** Metric definitions. [GET /api/iothub/metric-definitions] */
    public JsonNode metricDefinitions() {
        return c.send("GET", "/api/iothub/metric-definitions", null, null);
    }

    /** Metrics. [GET /api/iothub/{hubId}/metrics] */
    public JsonNode metrics(String hubId, Object hours, Object protocol) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("hours", hours);
        query_.put("protocol", protocol);
        return c.send("GET", "/api/iothub/" + HiokClient.segment(hubId) + "/metrics", null, query_);
    }
    public JsonNode metrics(String hubId) {
        return metrics(hubId, null, null);
    }
}
