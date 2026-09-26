// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package com.hiokcloud.api;

import com.hiokcloud.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** CloudShell operations. */
public final class CloudShellApi {
    private final HiokClient c;
    public CloudShellApi(HiokClient client) { this.c = client; }

    /** End. [DELETE /api/cloudshell/session] */
    public JsonNode end() {
        return c.send("DELETE", "/api/cloudshell/session", null, null);
    }

    /** Session. [GET /api/cloudshell/session] */
    public JsonNode session() {
        return c.send("GET", "/api/cloudshell/session", null, null);
    }

    /** Status. [GET /api/cloudshell/status] */
    public JsonNode status() {
        return c.send("GET", "/api/cloudshell/status", null, null);
    }
}
