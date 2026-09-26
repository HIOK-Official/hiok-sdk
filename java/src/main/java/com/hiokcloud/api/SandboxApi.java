// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package com.hiokcloud.api;

import com.hiokcloud.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** Sandbox operations. */
public final class SandboxApi {
    private final HiokClient c;
    public SandboxApi(HiokClient client) { this.c = client; }

    /** Create. [POST /api/Sandbox] */
    public JsonNode create(Object body) {
        return c.send("POST", "/api/Sandbox", body, null);
    }

    /** Create and download. [POST /api/Sandbox/download] */
    public JsonNode createAndDownload(Object body) {
        return c.send("POST", "/api/Sandbox/download", body, null);
    }

    /** Reap. [POST /api/Sandbox/reap] */
    public JsonNode reap() {
        return c.send("POST", "/api/Sandbox/reap", null, null);
    }

    /** Regions. [GET /api/Sandbox/regions] */
    public JsonNode regions() {
        return c.send("GET", "/api/Sandbox/regions", null, null);
    }
}
