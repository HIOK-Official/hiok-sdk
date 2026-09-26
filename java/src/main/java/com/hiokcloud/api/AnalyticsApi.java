// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package com.hiokcloud.api;

import com.hiokcloud.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** Analytics operations. */
public final class AnalyticsApi {
    private final HiokClient c;
    public AnalyticsApi(HiokClient client) { this.c = client; }

    /** Attach vnet. [POST /api/Analytics/{id}/vnet/attach] */
    public JsonNode attachVNet(String id) {
        return c.send("POST", "/api/Analytics/" + HiokClient.segment(id) + "/vnet/attach", null, null);
    }

    /** Columns. [GET /api/Analytics/{id}/tables/{database}/{table}/columns] */
    public JsonNode columns(String id, String database, String table) {
        return c.send("GET", "/api/Analytics/" + HiokClient.segment(id) + "/tables/" + HiokClient.segment(database) + "/" + HiokClient.segment(table) + "/columns", null, null);
    }

    /** Connection. [GET /api/Analytics/{id}/connection] */
    public JsonNode connection(String id) {
        return c.send("GET", "/api/Analytics/" + HiokClient.segment(id) + "/connection", null, null);
    }

    /** Create. [POST /api/Analytics] */
    public JsonNode create(Object body) {
        return c.send("POST", "/api/Analytics", body, null);
    }

    /** Delete. [DELETE /api/Analytics/{id}] */
    public JsonNode delete(String id) {
        return c.send("DELETE", "/api/Analytics/" + HiokClient.segment(id), null, null);
    }

    /** Detach vnet. [POST /api/Analytics/{id}/vnet/detach] */
    public JsonNode detachVNet(String id) {
        return c.send("POST", "/api/Analytics/" + HiokClient.segment(id) + "/vnet/detach", null, null);
    }

    /** Get. [GET /api/Analytics/{id}] */
    public JsonNode get(String id) {
        return c.send("GET", "/api/Analytics/" + HiokClient.segment(id), null, null);
    }

    /** List. [GET /api/Analytics] */
    public JsonNode list() {
        return c.send("GET", "/api/Analytics", null, null);
    }

    /** Query. [POST /api/Analytics/{id}/query] */
    public JsonNode query(String id, Object body) {
        return c.send("POST", "/api/Analytics/" + HiokClient.segment(id) + "/query", body, null);
    }

    /** Start. [POST /api/Analytics/{id}/start] */
    public JsonNode start(String id) {
        return c.send("POST", "/api/Analytics/" + HiokClient.segment(id) + "/start", null, null);
    }

    /** Stop. [POST /api/Analytics/{id}/stop] */
    public JsonNode stop(String id) {
        return c.send("POST", "/api/Analytics/" + HiokClient.segment(id) + "/stop", null, null);
    }

    /** Tables. [GET /api/Analytics/{id}/tables] */
    public JsonNode tables(String id) {
        return c.send("GET", "/api/Analytics/" + HiokClient.segment(id) + "/tables", null, null);
    }
}
