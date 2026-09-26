// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package com.hiokcloud.api;

import com.hiokcloud.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** IoTHub operations. */
public final class IoTHubApi {
    private final HiokClient c;
    public IoTHubApi(HiokClient client) { this.c = client; }

    /** Get io thubs. [GET /api/IoTHub/iothubs] */
    public JsonNode getIoTHubs() {
        return c.send("GET", "/api/IoTHub/iothubs", null, null);
    }
}
