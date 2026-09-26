// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package com.hiokcloud.api;

import com.hiokcloud.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** Hybrid operations. */
public final class HybridApi {
    private final HiokClient c;
    public HybridApi(HiokClient client) { this.c = client; }

    /** Agent install. [GET /api/hybrid/agent-install] */
    public JsonNode agentInstall() {
        return c.send("GET", "/api/hybrid/agent-install", null, null);
    }

    /** Delete. [DELETE /api/hybrid/resources/{id}] */
    public JsonNode delete(String id) {
        return c.send("DELETE", "/api/hybrid/resources/" + HiokClient.segment(id), null, null);
    }

    /** Heartbeat. [POST /api/hybrid/heartbeat] */
    public JsonNode heartbeat(Object body) {
        return c.send("POST", "/api/hybrid/heartbeat", body, null);
    }

    /** List. [GET /api/hybrid/resources] */
    public JsonNode list() {
        return c.send("GET", "/api/hybrid/resources", null, null);
    }

    /** List services. [GET /api/hybrid/resources/{id}/services] */
    public JsonNode listServices(String id) {
        return c.send("GET", "/api/hybrid/resources/" + HiokClient.segment(id) + "/services", null, null);
    }

    /** Metrics. [GET /api/hybrid/resources/{id}/metrics] */
    public JsonNode metrics(String id) {
        return c.send("GET", "/api/hybrid/resources/" + HiokClient.segment(id) + "/metrics", null, null);
    }

    /** Provision edge. [POST /api/hybrid/resources/{id}/edge] */
    public JsonNode provisionEdge(String id) {
        return c.send("POST", "/api/hybrid/resources/" + HiokClient.segment(id) + "/edge", null, null);
    }

    /** Publish service. [POST /api/hybrid/resources/{id}/services] */
    public JsonNode publishService(String id, Object body) {
        return c.send("POST", "/api/hybrid/resources/" + HiokClient.segment(id) + "/services", body, null);
    }

    /** Register. [POST /api/hybrid/resources] */
    public JsonNode register(Object body) {
        return c.send("POST", "/api/hybrid/resources", body, null);
    }

    /** Unpublish service. [DELETE /api/hybrid/resources/{id}/services/{serviceId}] */
    public JsonNode unpublishService(String id, String serviceId) {
        return c.send("DELETE", "/api/hybrid/resources/" + HiokClient.segment(id) + "/services/" + HiokClient.segment(serviceId), null, null);
    }
}
