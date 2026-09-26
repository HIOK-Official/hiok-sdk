// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package com.hiokcloud.api;

import com.hiokcloud.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** Mongo operations. */
public final class MongoApi {
    private final HiokClient c;
    public MongoApi(HiokClient client) { this.c = client; }

    /** Collections. [GET /api/Mongo/{id}/databases/{database}/collections] */
    public JsonNode collections(String id, String database) {
        return c.send("GET", "/api/Mongo/" + HiokClient.segment(id) + "/databases/" + HiokClient.segment(database) + "/collections", null, null);
    }

    /** Connection. [GET /api/Mongo/{id}/connection] */
    public JsonNode connection(String id) {
        return c.send("GET", "/api/Mongo/" + HiokClient.segment(id) + "/connection", null, null);
    }

    /** Create. [POST /api/Mongo] */
    public JsonNode create(Object body) {
        return c.send("POST", "/api/Mongo", body, null);
    }

    /** Databases. [GET /api/Mongo/{id}/databases] */
    public JsonNode databases(String id) {
        return c.send("GET", "/api/Mongo/" + HiokClient.segment(id) + "/databases", null, null);
    }

    /** Delete. [DELETE /api/Mongo/{id}] */
    public JsonNode delete(String id) {
        return c.send("DELETE", "/api/Mongo/" + HiokClient.segment(id), null, null);
    }

    /** Get. [GET /api/Mongo/{id}] */
    public JsonNode get(String id) {
        return c.send("GET", "/api/Mongo/" + HiokClient.segment(id), null, null);
    }

    /** List. [GET /api/Mongo] */
    public JsonNode list() {
        return c.send("GET", "/api/Mongo", null, null);
    }

    /** Replica status. [GET /api/Mongo/{id}/replica-status] */
    public JsonNode replicaStatus(String id) {
        return c.send("GET", "/api/Mongo/" + HiokClient.segment(id) + "/replica-status", null, null);
    }

    /** Run command. [POST /api/Mongo/{id}/command] */
    public JsonNode runCommand(String id, Object body) {
        return c.send("POST", "/api/Mongo/" + HiokClient.segment(id) + "/command", body, null);
    }

    /** Set consistency. [PUT /api/Mongo/{id}/consistency] */
    public JsonNode setConsistency(String id, Object body) {
        return c.send("PUT", "/api/Mongo/" + HiokClient.segment(id) + "/consistency", body, null);
    }

    /** Start. [POST /api/Mongo/{id}/start] */
    public JsonNode start(String id) {
        return c.send("POST", "/api/Mongo/" + HiokClient.segment(id) + "/start", null, null);
    }

    /** Stop. [POST /api/Mongo/{id}/stop] */
    public JsonNode stop(String id) {
        return c.send("POST", "/api/Mongo/" + HiokClient.segment(id) + "/stop", null, null);
    }
}
