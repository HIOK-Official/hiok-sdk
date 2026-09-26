// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package com.hiokcloud.api;

import com.hiokcloud.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** OVS operations. */
public final class OVSApi {
    private final HiokClient c;
    public OVSApi(HiokClient client) { this.c = client; }

    /** Add port. [POST /api/OVS/bridges/{bridgeId}/ports] */
    public JsonNode addPort(String bridgeId, Object body) {
        return c.send("POST", "/api/OVS/bridges/" + HiokClient.segment(bridgeId) + "/ports", body, null);
    }

    /** Create bridge. [POST /api/OVS/bridges] */
    public JsonNode createBridge(Object body) {
        return c.send("POST", "/api/OVS/bridges", body, null);
    }

    /** Delete bridge. [DELETE /api/OVS/bridges/{bridgeId}] */
    public JsonNode deleteBridge(String bridgeId) {
        return c.send("DELETE", "/api/OVS/bridges/" + HiokClient.segment(bridgeId), null, null);
    }

    /** Delete port. [DELETE /api/OVS/bridges/{bridgeId}/ports/{portName}] */
    public JsonNode deletePort(String bridgeId, String portName) {
        return c.send("DELETE", "/api/OVS/bridges/" + HiokClient.segment(bridgeId) + "/ports/" + HiokClient.segment(portName), null, null);
    }

    /** Get bridge. [GET /api/OVS/bridges/{bridgeId}] */
    public JsonNode getBridge(String bridgeId) {
        return c.send("GET", "/api/OVS/bridges/" + HiokClient.segment(bridgeId), null, null);
    }

    /** List bridges. [GET /api/OVS/bridges] */
    public JsonNode listBridges() {
        return c.send("GET", "/api/OVS/bridges", null, null);
    }
}
