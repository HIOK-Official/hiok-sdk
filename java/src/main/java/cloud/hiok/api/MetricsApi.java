// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package cloud.hiok.api;

import cloud.hiok.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** Metrics operations. */
public final class MetricsApi {
    private final HiokClient c;
    public MetricsApi(HiokClient client) { this.c = client; }

    /** Get. [GET /api/metrics/{resourceId}] */
    public JsonNode get(String resourceId) {
        return c.send("GET", "/api/metrics/" + HiokClient.segment(resourceId), null, null);
    }

    /** Get file operation metrics. [GET /api/Metrics/storage/{storageAccountId}/operations] */
    public JsonNode getFileOperationMetrics(String storageAccountId, Object limit, Object region) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("limit", limit);
        query_.put("region", region);
        return c.send("GET", "/api/Metrics/storage/" + HiokClient.segment(storageAccountId) + "/operations", null, query_);
    }
    public JsonNode getFileOperationMetrics(String storageAccountId) {
        return getFileOperationMetrics(storageAccountId, null, null);
    }

    /** Get quick stats. [GET /api/Metrics/storage/{storageAccountId}/stats] */
    public JsonNode getQuickStats(String storageAccountId, Object region) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("region", region);
        return c.send("GET", "/api/Metrics/storage/" + HiokClient.segment(storageAccountId) + "/stats", null, query_);
    }
    public JsonNode getQuickStats(String storageAccountId) {
        return getQuickStats(storageAccountId, null);
    }

    /** Get request metrics. [GET /api/Metrics/storage/{storageAccountId}/requests] */
    public JsonNode getRequestMetrics(String storageAccountId, Object range, Object region) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("range", range);
        query_.put("region", region);
        return c.send("GET", "/api/Metrics/storage/" + HiokClient.segment(storageAccountId) + "/requests", null, query_);
    }
    public JsonNode getRequestMetrics(String storageAccountId) {
        return getRequestMetrics(storageAccountId, null, null);
    }

    /** Get storage metrics. [GET /api/Metrics/storage/{storageAccountId}] */
    public JsonNode getStorageMetrics(String storageAccountId, Object range, Object region) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("range", range);
        query_.put("region", region);
        return c.send("GET", "/api/Metrics/storage/" + HiokClient.segment(storageAccountId), null, query_);
    }
    public JsonNode getStorageMetrics(String storageAccountId) {
        return getStorageMetrics(storageAccountId, null, null);
    }

    /** Ingest storage metric. [POST /api/Metrics/ingest/storage] */
    public JsonNode ingestStorageMetric(Object body) {
        return c.send("POST", "/api/Metrics/ingest/storage", body, null);
    }
}
