// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package com.hiokcloud.api;

import com.hiokcloud.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** RecentResources operations. */
public final class RecentResourcesApi {
    private final HiokClient c;
    public RecentResourcesApi(HiokClient client) { this.c = client; }

    /** Clear. [DELETE /api/recent-resources] */
    public JsonNode clear(Object id) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("id", id);
        return c.send("DELETE", "/api/recent-resources", null, query_);
    }
    public JsonNode clear() {
        return clear(null);
    }

    /** List. [GET /api/recent-resources] */
    public JsonNode list() {
        return c.send("GET", "/api/recent-resources", null, null);
    }

    /** Record. [POST /api/recent-resources] */
    public JsonNode record_(Object body) {
        return c.send("POST", "/api/recent-resources", body, null);
    }

    /** Toggle favourite. [POST /api/recent-resources/favourite] */
    public JsonNode toggleFavourite(Object body) {
        return c.send("POST", "/api/recent-resources/favourite", body, null);
    }
}
