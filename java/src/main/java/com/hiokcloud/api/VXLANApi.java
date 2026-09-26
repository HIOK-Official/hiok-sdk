// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package com.hiokcloud.api;

import com.hiokcloud.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** VXLAN operations. */
public final class VXLANApi {
    private final HiokClient c;
    public VXLANApi(HiokClient client) { this.c = client; }

    /** Add vtep. [POST /api/VXLAN/tunnels/{tunnelId}/vteps] */
    public JsonNode addVtep(String tunnelId, Object body) {
        return c.send("POST", "/api/VXLAN/tunnels/" + HiokClient.segment(tunnelId) + "/vteps", body, null);
    }

    /** Create tunnel. [POST /api/VXLAN/tunnels] */
    public JsonNode createTunnel(Object body) {
        return c.send("POST", "/api/VXLAN/tunnels", body, null);
    }

    /** Delete tunnel. [DELETE /api/VXLAN/tunnels/{tunnelId}] */
    public JsonNode deleteTunnel(String tunnelId) {
        return c.send("DELETE", "/api/VXLAN/tunnels/" + HiokClient.segment(tunnelId), null, null);
    }

    /** Get tunnel. [GET /api/VXLAN/tunnels/{tunnelId}] */
    public JsonNode getTunnel(String tunnelId) {
        return c.send("GET", "/api/VXLAN/tunnels/" + HiokClient.segment(tunnelId), null, null);
    }

    /** List tunnels. [GET /api/VXLAN/tunnels] */
    public JsonNode listTunnels() {
        return c.send("GET", "/api/VXLAN/tunnels", null, null);
    }

    /** Remove vtep. [DELETE /api/VXLAN/tunnels/{tunnelId}/vteps/{vtepIp}] */
    public JsonNode removeVtep(String tunnelId, String vtepIp) {
        return c.send("DELETE", "/api/VXLAN/tunnels/" + HiokClient.segment(tunnelId) + "/vteps/" + HiokClient.segment(vtepIp), null, null);
    }
}
