// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package com.hiokcloud.api;

import com.hiokcloud.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** Streaming operations. */
public final class StreamingApi {
    private final HiokClient c;
    public StreamingApi(HiokClient client) { this.c = client; }

    /** Add destination. [POST /api/streaming/{id}/destinations] */
    public JsonNode addDestination(String id, Object body) {
        return c.send("POST", "/api/streaming/" + HiokClient.segment(id) + "/destinations", body, null);
    }

    /** Create. [POST /api/streaming] */
    public JsonNode create(Object body) {
        return c.send("POST", "/api/streaming", body, null);
    }

    /** Delete. [DELETE /api/streaming/{id}] */
    public JsonNode delete(String id) {
        return c.send("DELETE", "/api/streaming/" + HiokClient.segment(id), null, null);
    }

    /** Delete destination. [DELETE /api/streaming/destinations/{destinationId}] */
    public JsonNode deleteDestination(String destinationId) {
        return c.send("DELETE", "/api/streaming/destinations/" + HiokClient.segment(destinationId), null, null);
    }

    /** Destinations. [GET /api/streaming/{id}/destinations] */
    public JsonNode destinations(String id, Object refresh) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("refresh", refresh);
        return c.send("GET", "/api/streaming/" + HiokClient.segment(id) + "/destinations", null, query_);
    }
    public JsonNode destinations(String id) {
        return destinations(id, null);
    }

    /** Get. [GET /api/streaming/{id}] */
    public JsonNode get(String id) {
        return c.send("GET", "/api/streaming/" + HiokClient.segment(id), null, null);
    }

    /** List. [GET /api/streaming] */
    public JsonNode list() {
        return c.send("GET", "/api/streaming", null, null);
    }

    /** Platforms. [GET /api/streaming/platforms] */
    public JsonNode platforms() {
        return c.send("GET", "/api/streaming/platforms", null, null);
    }

    /** Sync destinations. [POST /api/streaming/{id}/destinations/sync] */
    public JsonNode syncDestinations(String id) {
        return c.send("POST", "/api/streaming/" + HiokClient.segment(id) + "/destinations/sync", null, null);
    }

    /** Update destination. [PUT /api/streaming/destinations/{destinationId}] */
    public JsonNode updateDestination(String destinationId, Object body) {
        return c.send("PUT", "/api/streaming/destinations/" + HiokClient.segment(destinationId), body, null);
    }
}
