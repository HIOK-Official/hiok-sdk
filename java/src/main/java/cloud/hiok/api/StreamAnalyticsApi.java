// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package cloud.hiok.api;

import cloud.hiok.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** StreamAnalytics operations. */
public final class StreamAnalyticsApi {
    private final HiokClient c;
    public StreamAnalyticsApi(HiokClient client) { this.c = client; }

    /** Add input. [POST /api/StreamAnalytics/{id}/inputs] */
    public JsonNode addInput(String id, Object body) {
        return c.send("POST", "/api/StreamAnalytics/" + HiokClient.segment(id) + "/inputs", body, null);
    }

    /** Add output. [POST /api/StreamAnalytics/{id}/outputs] */
    public JsonNode addOutput(String id, Object body) {
        return c.send("POST", "/api/StreamAnalytics/" + HiokClient.segment(id) + "/outputs", body, null);
    }

    /** Apply transform. [POST /api/StreamAnalytics/{id}/transform/apply] */
    public JsonNode applyTransform(String id) {
        return c.send("POST", "/api/StreamAnalytics/" + HiokClient.segment(id) + "/transform/apply", null, null);
    }

    /** Bindings. [GET /api/StreamAnalytics/bindings] */
    public JsonNode bindings(Object connector) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("connector", connector);
        return c.send("GET", "/api/StreamAnalytics/bindings", null, query_);
    }
    public JsonNode bindings() {
        return bindings(null);
    }

    /** Catalog. [GET /api/StreamAnalytics/catalog] */
    public JsonNode catalog() {
        return c.send("GET", "/api/StreamAnalytics/catalog", null, null);
    }

    /** Connection. [GET /api/StreamAnalytics/{id}/connection] */
    public JsonNode connection(String id) {
        return c.send("GET", "/api/StreamAnalytics/" + HiokClient.segment(id) + "/connection", null, null);
    }

    /** Create. [POST /api/StreamAnalytics] */
    public JsonNode create(Object body) {
        return c.send("POST", "/api/StreamAnalytics", body, null);
    }

    /** Delete. [DELETE /api/StreamAnalytics/{id}] */
    public JsonNode delete(String id) {
        return c.send("DELETE", "/api/StreamAnalytics/" + HiokClient.segment(id), null, null);
    }

    /** Delete input. [DELETE /api/StreamAnalytics/{id}/inputs/{inputId}] */
    public JsonNode deleteInput(String id, String inputId) {
        return c.send("DELETE", "/api/StreamAnalytics/" + HiokClient.segment(id) + "/inputs/" + HiokClient.segment(inputId), null, null);
    }

    /** Delete output. [DELETE /api/StreamAnalytics/{id}/outputs/{outputId}] */
    public JsonNode deleteOutput(String id, String outputId) {
        return c.send("DELETE", "/api/StreamAnalytics/" + HiokClient.segment(id) + "/outputs/" + HiokClient.segment(outputId), null, null);
    }

    /** Get. [GET /api/StreamAnalytics/{id}] */
    public JsonNode get(String id) {
        return c.send("GET", "/api/StreamAnalytics/" + HiokClient.segment(id), null, null);
    }

    /** Inputs. [GET /api/StreamAnalytics/{id}/inputs] */
    public JsonNode inputs(String id) {
        return c.send("GET", "/api/StreamAnalytics/" + HiokClient.segment(id) + "/inputs", null, null);
    }

    /** List. [GET /api/StreamAnalytics] */
    public JsonNode list() {
        return c.send("GET", "/api/StreamAnalytics", null, null);
    }

    /** Logs. [GET /api/StreamAnalytics/{id}/logs] */
    public JsonNode logs(String id, Object role, Object tail) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("role", role);
        query_.put("tail", tail);
        return c.send("GET", "/api/StreamAnalytics/" + HiokClient.segment(id) + "/logs", null, query_);
    }
    public JsonNode logs(String id) {
        return logs(id, null, null);
    }

    /** Metrics. [GET /api/StreamAnalytics/{id}/metrics] */
    public JsonNode metrics(String id) {
        return c.send("GET", "/api/StreamAnalytics/" + HiokClient.segment(id) + "/metrics", null, null);
    }

    /** Outputs. [GET /api/StreamAnalytics/{id}/outputs] */
    public JsonNode outputs(String id) {
        return c.send("GET", "/api/StreamAnalytics/" + HiokClient.segment(id) + "/outputs", null, null);
    }

    /** Query. [POST /api/StreamAnalytics/{id}/query] */
    public JsonNode query(String id, Object body) {
        return c.send("POST", "/api/StreamAnalytics/" + HiokClient.segment(id) + "/query", body, null);
    }

    /** Query history. [GET /api/StreamAnalytics/{id}/query/history] */
    public JsonNode queryHistory(String id, Object take) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("take", take);
        return c.send("GET", "/api/StreamAnalytics/" + HiokClient.segment(id) + "/query/history", null, query_);
    }
    public JsonNode queryHistory(String id) {
        return queryHistory(id, null);
    }

    /** Start. [POST /api/StreamAnalytics/{id}/start] */
    public JsonNode start(String id) {
        return c.send("POST", "/api/StreamAnalytics/" + HiokClient.segment(id) + "/start", null, null);
    }

    /** Status. [GET /api/StreamAnalytics/{id}/status] */
    public JsonNode status(String id) {
        return c.send("GET", "/api/StreamAnalytics/" + HiokClient.segment(id) + "/status", null, null);
    }

    /** Stop. [POST /api/StreamAnalytics/{id}/stop] */
    public JsonNode stop(String id) {
        return c.send("POST", "/api/StreamAnalytics/" + HiokClient.segment(id) + "/stop", null, null);
    }

    /** Transform. [GET /api/StreamAnalytics/{id}/transform] */
    public JsonNode transform(String id) {
        return c.send("GET", "/api/StreamAnalytics/" + HiokClient.segment(id) + "/transform", null, null);
    }

    /** Update. [PATCH /api/StreamAnalytics/{id}] */
    public JsonNode update(String id, Object body) {
        return c.send("PATCH", "/api/StreamAnalytics/" + HiokClient.segment(id), body, null);
    }
}
