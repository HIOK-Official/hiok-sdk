// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package com.hiokcloud.api;

import com.hiokcloud.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** Admin operations. */
public final class AdminApi {
    private final HiokClient c;
    public AdminApi(HiokClient client) { this.c = client; }

    /** Grant. [POST /api/Admin/access] */
    public JsonNode grant(Object body) {
        return c.send("POST", "/api/Admin/access", body, null);
    }

    /** List grants. [GET /api/Admin/access] */
    public JsonNode listGrants() {
        return c.send("GET", "/api/Admin/access", null, null);
    }

    /** Me. [GET /api/Admin/me] */
    public JsonNode me() {
        return c.send("GET", "/api/Admin/me", null, null);
    }

    /** Revoke. [DELETE /api/Admin/access/{id}] */
    public JsonNode revoke(String id) {
        return c.send("DELETE", "/api/Admin/access/" + HiokClient.segment(id), null, null);
    }
}
