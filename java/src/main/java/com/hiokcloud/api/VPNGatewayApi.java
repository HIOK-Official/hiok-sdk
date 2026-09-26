// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package com.hiokcloud.api;

import com.hiokcloud.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** VPNGateway operations. */
public final class VPNGatewayApi {
    private final HiokClient c;
    public VPNGatewayApi(HiokClient client) { this.c = client; }

    /** Create p2 sclient. [POST /api/VPNGateway/clients/p2s] */
    public JsonNode createP2SClient(Object body, Object region) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("region", region);
        return c.send("POST", "/api/VPNGateway/clients/p2s", body, query_);
    }
    public JsonNode createP2SClient(Object body) {
        return createP2SClient(body, null);
    }

    /** Create s2 sconnection. [POST /api/VPNGateway/connections/s2s] */
    public JsonNode createS2SConnection(Object body, Object region) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("region", region);
        return c.send("POST", "/api/VPNGateway/connections/s2s", body, query_);
    }
    public JsonNode createS2SConnection(Object body) {
        return createS2SConnection(body, null);
    }

    /** Create vpngateway. [POST /api/VPNGateway/create] */
    public JsonNode createVPNGateway(Object body) {
        return c.send("POST", "/api/VPNGateway/create", body, null);
    }

    /** Delete s2 sconnection. [DELETE /api/VPNGateway/connections/s2s/{connectionId}] */
    public JsonNode deleteS2SConnection(String connectionId, Object region) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("region", region);
        return c.send("DELETE", "/api/VPNGateway/connections/s2s/" + HiokClient.segment(connectionId), null, query_);
    }
    public JsonNode deleteS2SConnection(String connectionId) {
        return deleteS2SConnection(connectionId, null);
    }

    /** Delete vpngateway. [DELETE /api/VPNGateway/{gatewayId}] */
    public JsonNode deleteVPNGateway(String gatewayId, Object gatewayName, Object region) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("gatewayName", gatewayName);
        query_.put("region", region);
        return c.send("DELETE", "/api/VPNGateway/" + HiokClient.segment(gatewayId), null, query_);
    }
    public JsonNode deleteVPNGateway(String gatewayId) {
        return deleteVPNGateway(gatewayId, null, null);
    }

    /** Download client config. [GET /api/VPNGateway/clients/p2s/{clientId}/config] */
    public JsonNode downloadClientConfig(String clientId, Object region) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("region", region);
        return c.send("GET", "/api/VPNGateway/clients/p2s/" + HiokClient.segment(clientId) + "/config", null, query_);
    }
    public JsonNode downloadClientConfig(String clientId) {
        return downloadClientConfig(clientId, null);
    }

    /** Get connected clients. [GET /api/VPNGateway/{gatewayId}/clients/p2s/connected] */
    public JsonNode getConnectedClients(String gatewayId, Object region) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("region", region);
        return c.send("GET", "/api/VPNGateway/" + HiokClient.segment(gatewayId) + "/clients/p2s/connected", null, query_);
    }
    public JsonNode getConnectedClients(String gatewayId) {
        return getConnectedClients(gatewayId, null);
    }

    /** Get s2 sconnection status. [GET /api/VPNGateway/connections/s2s/{connectionId}/status] */
    public JsonNode getS2SConnectionStatus(String connectionId, Object region) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("region", region);
        return c.send("GET", "/api/VPNGateway/connections/s2s/" + HiokClient.segment(connectionId) + "/status", null, query_);
    }
    public JsonNode getS2SConnectionStatus(String connectionId) {
        return getS2SConnectionStatus(connectionId, null);
    }

    /** Get vpngateway. [GET /api/VPNGateway/{gatewayId}] */
    public JsonNode getVPNGateway(String gatewayId) {
        return c.send("GET", "/api/VPNGateway/" + HiokClient.segment(gatewayId), null, null);
    }

    /** Get vpngateway status. [GET /api/VPNGateway/{gatewayId}/status] */
    public JsonNode getVPNGatewayStatus(String gatewayId, Object region) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("region", region);
        return c.send("GET", "/api/VPNGateway/" + HiokClient.segment(gatewayId) + "/status", null, query_);
    }
    public JsonNode getVPNGatewayStatus(String gatewayId) {
        return getVPNGatewayStatus(gatewayId, null);
    }

    /** List p2 sclients. [GET /api/VPNGateway/{gatewayId}/clients/p2s] */
    public JsonNode listP2SClients(String gatewayId) {
        return c.send("GET", "/api/VPNGateway/" + HiokClient.segment(gatewayId) + "/clients/p2s", null, null);
    }

    /** List s2 sconnections. [GET /api/VPNGateway/{gatewayId}/connections/s2s] */
    public JsonNode listS2SConnections(String gatewayId) {
        return c.send("GET", "/api/VPNGateway/" + HiokClient.segment(gatewayId) + "/connections/s2s", null, null);
    }

    /** List vpngateways. [GET /api/VPNGateway/list] */
    public JsonNode listVPNGateways(Object vnetId) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("vnetId", vnetId);
        return c.send("GET", "/api/VPNGateway/list", null, query_);
    }
    public JsonNode listVPNGateways() {
        return listVPNGateways(null);
    }

    /** Revoke p2 sclient. [DELETE /api/VPNGateway/clients/p2s/{clientId}] */
    public JsonNode revokeP2SClient(String clientId, Object region) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("region", region);
        return c.send("DELETE", "/api/VPNGateway/clients/p2s/" + HiokClient.segment(clientId), null, query_);
    }
    public JsonNode revokeP2SClient(String clientId) {
        return revokeP2SClient(clientId, null);
    }
}
