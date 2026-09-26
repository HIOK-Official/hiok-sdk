// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package com.hiokcloud.api;

import com.hiokcloud.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** HiokCloudHierarchy operations. */
public final class HiokCloudHierarchyApi {
    private final HiokClient c;
    public HiokCloudHierarchyApi(HiokClient client) { this.c = client; }

    /** Create hiok cloud hierarchy. [POST /api/HiokCloudHierarchy] */
    public JsonNode createHiokCloudHierarchy(Object body) {
        return c.send("POST", "/api/HiokCloudHierarchy", body, null);
    }

    /** Delete hiok cloud hierarchy. [DELETE /api/HiokCloudHierarchy/deletehierarchy/{id}] */
    public JsonNode deleteHiokCloudHierarchy(String id) {
        return c.send("DELETE", "/api/HiokCloudHierarchy/deletehierarchy/" + HiokClient.segment(id), null, null);
    }

    /** Delete hiok cloud hierarchy node. [DELETE /api/HiokCloudHierarchy/deletehierarchynode] */
    public JsonNode deleteHiokCloudHierarchyNode(Object body) {
        return c.send("DELETE", "/api/HiokCloudHierarchy/deletehierarchynode", body, null);
    }

    /** Edit hiok cloud hierarchy. [PUT /api/HiokCloudHierarchy/edithierarchy] */
    public JsonNode editHiokCloudHierarchy(Object body) {
        return c.send("PUT", "/api/HiokCloudHierarchy/edithierarchy", body, null);
    }

    /** Get all hierarchy. [GET /api/HiokCloudHierarchy/hierarchies] */
    public JsonNode getAllHierarchy() {
        return c.send("GET", "/api/HiokCloudHierarchy/hierarchies", null, null);
    }

    /** Get hierarchy. [GET /api/HiokCloudHierarchy/hierarchy/{id}] */
    public JsonNode getHierarchy(String id) {
        return c.send("GET", "/api/HiokCloudHierarchy/hierarchy/" + HiokClient.segment(id), null, null);
    }
}
