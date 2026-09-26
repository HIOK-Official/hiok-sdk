// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package com.hiokcloud.api;

import com.hiokcloud.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** Search operations. */
public final class SearchApi {
    private final HiokClient c;
    public SearchApi(HiokClient client) { this.c = client; }

    /** Search. [GET /api/search] */
    public JsonNode search(Object q, Object type, Object region, Object status, Object limit) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("q", q);
        query_.put("type", type);
        query_.put("region", region);
        query_.put("status", status);
        query_.put("limit", limit);
        return c.send("GET", "/api/search", null, query_);
    }
    public JsonNode search() {
        return search(null, null, null, null, null);
    }
}
