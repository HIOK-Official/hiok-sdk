// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package com.hiokcloud.api;

import com.hiokcloud.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** SupportQueue operations. */
public final class SupportQueueApi {
    private final HiokClient c;
    public SupportQueueApi(HiokClient client) { this.c = client; }

    /** Queue. [GET /api/admin/support] */
    public JsonNode queue(Object status) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("status", status);
        return c.send("GET", "/api/admin/support", null, query_);
    }
    public JsonNode queue() {
        return queue(null);
    }

    /** Update. [PUT /api/admin/support/{id}] */
    public JsonNode update(String id, Object body) {
        return c.send("PUT", "/api/admin/support/" + HiokClient.segment(id), body, null);
    }
}
