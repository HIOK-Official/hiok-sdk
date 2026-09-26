// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package com.hiokcloud.api;

import com.hiokcloud.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** Infrastructure operations. */
public final class InfrastructureApi {
    private final HiokClient c;
    public InfrastructureApi(HiokClient client) { this.c = client; }

    /** Allocate ip. [POST /api/Infrastructure/ip-allocations] */
    public JsonNode allocateIp(Object body) {
        return c.send("POST", "/api/Infrastructure/ip-allocations", body, null);
    }

    /** Get reverse. [GET /api/Infrastructure/regions/{region}/reverse/{ip}] */
    public JsonNode getReverse(String region, String ip) {
        return c.send("GET", "/api/Infrastructure/regions/" + HiokClient.segment(region) + "/reverse/" + HiokClient.segment(ip), null, null);
    }

    /** Ip allocations. [GET /api/Infrastructure/ip-allocations] */
    public JsonNode ipAllocations(Object region, Object includeReleased) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("region", region);
        query_.put("includeReleased", includeReleased);
        return c.send("GET", "/api/Infrastructure/ip-allocations", null, query_);
    }
    public JsonNode ipAllocations() {
        return ipAllocations(null, null);
    }

    /** Ip block. [GET /api/Infrastructure/regions/{region}/ips/{block}] */
    public JsonNode ipBlock(String region, String block) {
        return c.send("GET", "/api/Infrastructure/regions/" + HiokClient.segment(region) + "/ips/" + HiokClient.segment(block), null, null);
    }

    /** Ip pools. [GET /api/Infrastructure/ip-pools] */
    public JsonNode ipPools(Object region) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("region", region);
        return c.send("GET", "/api/Infrastructure/ip-pools", null, query_);
    }
    public JsonNode ipPools() {
        return ipPools(null);
    }

    /** Ips. [GET /api/Infrastructure/regions/{region}/ips] */
    public JsonNode ips(String region) {
        return c.send("GET", "/api/Infrastructure/regions/" + HiokClient.segment(region) + "/ips", null, null);
    }

    /** Ips for resource. [GET /api/Infrastructure/ip-allocations/resource/{resourceKind}/{resourceId}] */
    public JsonNode ipsForResource(String resourceKind, String resourceId) {
        return c.send("GET", "/api/Infrastructure/ip-allocations/resource/" + HiokClient.segment(resourceKind) + "/" + HiokClient.segment(resourceId), null, null);
    }

    /** Reconcile ips. [POST /api/Infrastructure/ip-allocations/reconcile] */
    public JsonNode reconcileIps(Object region) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("region", region);
        return c.send("POST", "/api/Infrastructure/ip-allocations/reconcile", null, query_);
    }
    public JsonNode reconcileIps() {
        return reconcileIps(null);
    }

    /** Regions. [GET /api/Infrastructure/regions] */
    public JsonNode regions() {
        return c.send("GET", "/api/Infrastructure/regions", null, null);
    }

    /** Release ip. [DELETE /api/Infrastructure/ip-allocations/{id}] */
    public JsonNode releaseIp(String id, Object targetContainer) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("targetContainer", targetContainer);
        return c.send("DELETE", "/api/Infrastructure/ip-allocations/" + HiokClient.segment(id), null, query_);
    }
    public JsonNode releaseIp(String id) {
        return releaseIp(id, null);
    }

    /** Reverses. [GET /api/Infrastructure/regions/{region}/ips/{block}/reverse] */
    public JsonNode reverses(String region, String block) {
        return c.send("GET", "/api/Infrastructure/regions/" + HiokClient.segment(region) + "/ips/" + HiokClient.segment(block) + "/reverse", null, null);
    }

    /** Server. [GET /api/Infrastructure/regions/{region}/servers/{name}] */
    public JsonNode server(String region, String name) {
        return c.send("GET", "/api/Infrastructure/regions/" + HiokClient.segment(region) + "/servers/" + HiokClient.segment(name), null, null);
    }

    /** Servers. [GET /api/Infrastructure/regions/{region}/servers] */
    public JsonNode servers(String region) {
        return c.send("GET", "/api/Infrastructure/regions/" + HiokClient.segment(region) + "/servers", null, null);
    }

    /** Set reverse. [POST /api/Infrastructure/regions/{region}/reverse] */
    public JsonNode setReverse(String region, Object body) {
        return c.send("POST", "/api/Infrastructure/regions/" + HiokClient.segment(region) + "/reverse", body, null);
    }
}
