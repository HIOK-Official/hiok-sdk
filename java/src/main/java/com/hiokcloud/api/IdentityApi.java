// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package com.hiokcloud.api;

import com.hiokcloud.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** Identity operations. */
public final class IdentityApi {
    private final HiokClient c;
    public IdentityApi(HiokClient client) { this.c = client; }

    /** Create. [POST /api/identity] */
    public JsonNode create(Object body) {
        return c.send("POST", "/api/identity", body, null);
    }

    /** Delete. [DELETE /api/identity/{id}] */
    public JsonNode delete(String id) {
        return c.send("DELETE", "/api/identity/" + HiokClient.segment(id), null, null);
    }

    /** For resource. [GET /api/identity/for-resource/{resourceId}] */
    public JsonNode forResource(String resourceId, Object resourceType, Object name) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("resourceType", resourceType);
        query_.put("name", name);
        return c.send("GET", "/api/identity/for-resource/" + HiokClient.segment(resourceId), null, query_);
    }
    public JsonNode forResource(String resourceId) {
        return forResource(resourceId, null, null);
    }

    /** List. [GET /api/identity] */
    public JsonNode list(Object kind) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("kind", kind);
        return c.send("GET", "/api/identity", null, query_);
    }
    public JsonNode list() {
        return list(null);
    }

    /** Regenerate. [POST /api/identity/{id}/regenerate-secret] */
    public JsonNode regenerate(String id) {
        return c.send("POST", "/api/identity/" + HiokClient.segment(id) + "/regenerate-secret", null, null);
    }
}
