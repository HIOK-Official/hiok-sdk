// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package com.hiokcloud.api;

import com.hiokcloud.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** Bastion operations. */
public final class BastionApi {
    private final HiokClient c;
    public BastionApi(HiokClient client) { this.c = client; }

    /** Create. [POST /api/Bastion] */
    public JsonNode create(Object body) {
        return c.send("POST", "/api/Bastion", body, null);
    }

    /** Delete. [DELETE /api/Bastion/{id}] */
    public JsonNode delete(String id) {
        return c.send("DELETE", "/api/Bastion/" + HiokClient.segment(id), null, null);
    }

    /** End session. [DELETE /api/Bastion/{id}/sessions/{sessionId}] */
    public JsonNode endSession(String id, String sessionId) {
        return c.send("DELETE", "/api/Bastion/" + HiokClient.segment(id) + "/sessions/" + HiokClient.segment(sessionId), null, null);
    }

    /** Get. [GET /api/Bastion/{id}] */
    public JsonNode get(String id) {
        return c.send("GET", "/api/Bastion/" + HiokClient.segment(id), null, null);
    }

    /** List. [GET /api/Bastion] */
    public JsonNode list() {
        return c.send("GET", "/api/Bastion", null, null);
    }

    /** List sessions. [GET /api/Bastion/{id}/sessions] */
    public JsonNode listSessions(String id, Object limit) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("limit", limit);
        return c.send("GET", "/api/Bastion/" + HiokClient.segment(id) + "/sessions", null, query_);
    }
    public JsonNode listSessions(String id) {
        return listSessions(id, null);
    }

    /** Refresh. [POST /api/Bastion/{id}/refresh] */
    public JsonNode refresh(String id) {
        return c.send("POST", "/api/Bastion/" + HiokClient.segment(id) + "/refresh", null, null);
    }

    /** Start session. [POST /api/Bastion/{id}/sessions] */
    public JsonNode startSession(String id, Object body) {
        return c.send("POST", "/api/Bastion/" + HiokClient.segment(id) + "/sessions", body, null);
    }
}
