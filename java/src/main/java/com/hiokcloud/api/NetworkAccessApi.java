// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package com.hiokcloud.api;

import com.hiokcloud.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** NetworkAccess operations. */
public final class NetworkAccessApi {
    private final HiokClient c;
    public NetworkAccessApi(HiokClient client) { this.c = client; }

    /** Create endpoint. [POST /api/network-access/{resourceType}/{resourceId}/private-endpoints] */
    public JsonNode createEndpoint(String resourceType, String resourceId, Object body) {
        return c.send("POST", "/api/network-access/" + HiokClient.segment(resourceType) + "/" + HiokClient.segment(resourceId) + "/private-endpoints", body, null);
    }

    /** Delete endpoint. [DELETE /api/network-access/{resourceType}/{resourceId}/private-endpoints/{id}] */
    public JsonNode deleteEndpoint(String resourceType, String resourceId, String id) {
        return c.send("DELETE", "/api/network-access/" + HiokClient.segment(resourceType) + "/" + HiokClient.segment(resourceId) + "/private-endpoints/" + HiokClient.segment(id), null, null);
    }

    /** Get. [GET /api/network-access/{resourceType}/{resourceId}] */
    public JsonNode get(String resourceType, String resourceId) {
        return c.send("GET", "/api/network-access/" + HiokClient.segment(resourceType) + "/" + HiokClient.segment(resourceId), null, null);
    }

    /** List endpoints. [GET /api/network-access/{resourceType}/{resourceId}/private-endpoints] */
    public JsonNode listEndpoints(String resourceType, String resourceId) {
        return c.send("GET", "/api/network-access/" + HiokClient.segment(resourceType) + "/" + HiokClient.segment(resourceId) + "/private-endpoints", null, null);
    }

    /** Set. [PUT /api/network-access/{resourceType}/{resourceId}] */
    public JsonNode set(String resourceType, String resourceId, Object body) {
        return c.send("PUT", "/api/network-access/" + HiokClient.segment(resourceType) + "/" + HiokClient.segment(resourceId), body, null);
    }

    /** Source presets. [GET /api/network-access/source-presets] */
    public JsonNode sourcePresets(Object resourceType, Object resourceId) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("resourceType", resourceType);
        query_.put("resourceId", resourceId);
        return c.send("GET", "/api/network-access/source-presets", null, query_);
    }
    public JsonNode sourcePresets() {
        return sourcePresets(null, null);
    }
}
