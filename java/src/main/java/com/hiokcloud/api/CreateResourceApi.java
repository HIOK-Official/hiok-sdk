// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package com.hiokcloud.api;

import com.hiokcloud.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** CreateResource operations. */
public final class CreateResourceApi {
    private final HiokClient c;
    public CreateResourceApi(HiokClient client) { this.c = client; }

    /** Create resource. [POST /api/CreateResource/createresource] */
    public JsonNode createResource(Object body) {
        return c.send("POST", "/api/CreateResource/createresource", body, null);
    }

    /** Validate resource. [POST /api/CreateResource/validateresource] */
    public JsonNode validateResource(Object body) {
        return c.send("POST", "/api/CreateResource/validateresource", body, null);
    }
}
