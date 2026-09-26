// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package com.hiokcloud.api;

import com.hiokcloud.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** Support operations. */
public final class SupportApi {
    private final HiokClient c;
    public SupportApi(HiokClient client) { this.c = client; }

    /** Close. [POST /api/support/tickets/{id}/close] */
    public JsonNode close(String id, Object body) {
        return c.send("POST", "/api/support/tickets/" + HiokClient.segment(id) + "/close", body, null);
    }

    /** Mine. [GET /api/support/tickets] */
    public JsonNode mine() {
        return c.send("GET", "/api/support/tickets", null, null);
    }

    /** Raise. [POST /api/support/tickets] */
    public JsonNode raise(Object body) {
        return c.send("POST", "/api/support/tickets", body, null);
    }
}
