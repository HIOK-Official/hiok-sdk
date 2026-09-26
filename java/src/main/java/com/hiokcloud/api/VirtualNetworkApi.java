// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package com.hiokcloud.api;

import com.hiokcloud.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** VirtualNetwork operations. */
public final class VirtualNetworkApi {
    private final HiokClient c;
    public VirtualNetworkApi(HiokClient client) { this.c = client; }

    /** Create vnet. [POST /api/VirtualNetwork/create-vnet] */
    public JsonNode createVNet(Object body) {
        return c.send("POST", "/api/VirtualNetwork/create-vnet", body, null);
    }

    /** Create vnet peering. [POST /api/VirtualNetwork/{vnetId}/peerings] */
    public JsonNode createVnetPeering(String vnetId, Object body) {
        return c.send("POST", "/api/VirtualNetwork/" + HiokClient.segment(vnetId) + "/peerings", body, null);
    }

    /** Delete vnet peering. [DELETE /api/VirtualNetwork/{vnetId}/peerings/{peeringId}] */
    public JsonNode deleteVnetPeering(String vnetId, String peeringId) {
        return c.send("DELETE", "/api/VirtualNetwork/" + HiokClient.segment(vnetId) + "/peerings/" + HiokClient.segment(peeringId), null, null);
    }

    /** Delete vnet subnet. [DELETE /api/VirtualNetwork/{vnetId}/subnets/{subnetId}] */
    public JsonNode deleteVnetSubnet(String vnetId, String subnetId) {
        return c.send("DELETE", "/api/VirtualNetwork/" + HiokClient.segment(vnetId) + "/subnets/" + HiokClient.segment(subnetId), null, null);
    }

    /** Destroy vnet. [DELETE /api/VirtualNetwork/delete-vnet] */
    public JsonNode destroyVNet(Object body) {
        return c.send("DELETE", "/api/VirtualNetwork/delete-vnet", body, null);
    }

    /** List all peerings. [GET /api/VirtualNetwork/peerings] */
    public JsonNode listAllPeerings() {
        return c.send("GET", "/api/VirtualNetwork/peerings", null, null);
    }

    /** List all subnets. [GET /api/VirtualNetwork/subnets] */
    public JsonNode listAllSubnets() {
        return c.send("GET", "/api/VirtualNetwork/subnets", null, null);
    }

    /** List vms info. [GET /api/VirtualNetwork/list-vnets] */
    public JsonNode listVMsInfo() {
        return c.send("GET", "/api/VirtualNetwork/list-vnets", null, null);
    }

    /** List vnet address spaces. [GET /api/VirtualNetwork/{vnetId}/address-spaces] */
    public JsonNode listVnetAddressSpaces(String vnetId) {
        return c.send("GET", "/api/VirtualNetwork/" + HiokClient.segment(vnetId) + "/address-spaces", null, null);
    }

    /** List vnet peerings. [GET /api/VirtualNetwork/{vnetId}/peerings] */
    public JsonNode listVnetPeerings(String vnetId) {
        return c.send("GET", "/api/VirtualNetwork/" + HiokClient.segment(vnetId) + "/peerings", null, null);
    }

    /** List vnet subnets. [GET /api/VirtualNetwork/{vnetId}/subnets] */
    public JsonNode listVnetSubnets(String vnetId) {
        return c.send("GET", "/api/VirtualNetwork/" + HiokClient.segment(vnetId) + "/subnets", null, null);
    }

    /** Save vnet address space. [PUT /api/VirtualNetwork/{vnetId}/address-spaces] */
    public JsonNode saveVnetAddressSpace(String vnetId, Object body) {
        return c.send("PUT", "/api/VirtualNetwork/" + HiokClient.segment(vnetId) + "/address-spaces", body, null);
    }

    /** Save vnet subnet. [PUT /api/VirtualNetwork/{vnetId}/subnets] */
    public JsonNode saveVnetSubnet(String vnetId, Object body) {
        return c.send("PUT", "/api/VirtualNetwork/" + HiokClient.segment(vnetId) + "/subnets", body, null);
    }
}
