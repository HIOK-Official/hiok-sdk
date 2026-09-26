// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package com.hiokcloud.api;

import com.hiokcloud.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** Integrations operations. */
public final class IntegrationsApi {
    private final HiokClient c;
    public IntegrationsApi(HiokClient client) { this.c = client; }

    /** Create. [POST /api/integrations] */
    public JsonNode create(Object body) {
        return c.send("POST", "/api/integrations", body, null);
    }

    /** Delete. [DELETE /api/integrations/{id}] */
    public JsonNode delete(String id) {
        return c.send("DELETE", "/api/integrations/" + HiokClient.segment(id), null, null);
    }

    /** Get. [GET /api/integrations/{id}] */
    public JsonNode get(String id) {
        return c.send("GET", "/api/integrations/" + HiokClient.segment(id), null, null);
    }

    /** List. [GET /api/integrations] */
    public JsonNode list() {
        return c.send("GET", "/api/integrations", null, null);
    }

    /** Test. [POST /api/integrations/{id}/test] */
    public JsonNode test(String id) {
        return c.send("POST", "/api/integrations/" + HiokClient.segment(id) + "/test", null, null);
    }

    /** Update. [PUT /api/integrations/{id}] */
    public JsonNode update(String id, Object body) {
        return c.send("PUT", "/api/integrations/" + HiokClient.segment(id), body, null);
    }
}
