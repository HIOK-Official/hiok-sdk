// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package com.hiokcloud.api;

import com.hiokcloud.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** ResourceMetrics operations. */
public final class ResourceMetricsApi {
    private final HiokClient c;
    public ResourceMetricsApi(HiokClient client) { this.c = client; }

    /** Api. [GET /api/resource-metrics/api] */
    public JsonNode api(Object from, Object to, Object route) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("from", from);
        query_.put("to", to);
        query_.put("route", route);
        return c.send("GET", "/api/resource-metrics/api", null, query_);
    }
    public JsonNode api() {
        return api(null, null, null);
    }

    /** Catalogue. [GET /api/resource-metrics/catalogue] */
    public JsonNode catalogue() {
        return c.send("GET", "/api/resource-metrics/catalogue", null, null);
    }

    /** Collect. [POST /api/resource-metrics/collect] */
    public JsonNode collect(Object region) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("region", region);
        return c.send("POST", "/api/resource-metrics/collect", null, query_);
    }
    public JsonNode collect() {
        return collect(null);
    }

    /** Cost. [GET /api/resource-metrics/cost/{resourceKind}/{resourceName}] */
    public JsonNode cost(String resourceKind, String resourceName, Object from, Object to, Object region) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("from", from);
        query_.put("to", to);
        query_.put("region", region);
        return c.send("GET", "/api/resource-metrics/cost/" + HiokClient.segment(resourceKind) + "/" + HiokClient.segment(resourceName), null, query_);
    }
    public JsonNode cost(String resourceKind, String resourceName) {
        return cost(resourceKind, resourceName, null, null, null);
    }

    /** Cost totals. [GET /api/resource-metrics/cost-totals] */
    public JsonNode costTotals(Object region, Object from, Object to) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("region", region);
        query_.put("from", from);
        query_.put("to", to);
        return c.send("GET", "/api/resource-metrics/cost-totals", null, query_);
    }
    public JsonNode costTotals() {
        return costTotals(null, null, null);
    }

    /** Reporting. [GET /api/resource-metrics/reporting] */
    public JsonNode reporting(Object region, Object resourceKind) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("region", region);
        query_.put("resourceKind", resourceKind);
        return c.send("GET", "/api/resource-metrics/reporting", null, query_);
    }
    public JsonNode reporting() {
        return reporting(null, null);
    }

    /** Series. [GET /api/resource-metrics/{resourceKind}/{resourceName}] */
    public JsonNode series(String resourceKind, String resourceName, Object from, Object to, Object granularity, Object metrics, Object region) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("from", from);
        query_.put("to", to);
        query_.put("granularity", granularity);
        query_.put("metrics", metrics);
        query_.put("region", region);
        return c.send("GET", "/api/resource-metrics/" + HiokClient.segment(resourceKind) + "/" + HiokClient.segment(resourceName), null, query_);
    }
    public JsonNode series(String resourceKind, String resourceName) {
        return series(resourceKind, resourceName, null, null, null, null, null);
    }
}
