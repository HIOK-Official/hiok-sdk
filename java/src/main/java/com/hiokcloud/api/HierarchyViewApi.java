// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package com.hiokcloud.api;

import com.hiokcloud.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** HierarchyView operations. */
public final class HierarchyViewApi {
    private final HiokClient c;
    public HierarchyViewApi(HiokClient client) { this.c = client; }

    /** Context. [GET /api/hierarchyview/context/{resourceGroupId}] */
    public JsonNode context(String resourceGroupId) {
        return c.send("GET", "/api/hierarchyview/context/" + HiokClient.segment(resourceGroupId), null, null);
    }

    /** Full. [GET /api/hierarchyview/full] */
    public JsonNode full() {
        return c.send("GET", "/api/hierarchyview/full", null, null);
    }
}
