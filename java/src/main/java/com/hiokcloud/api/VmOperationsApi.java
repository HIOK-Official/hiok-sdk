// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package com.hiokcloud.api;

import com.hiokcloud.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** VmOperations operations. */
public final class VmOperationsApi {
    private final HiokClient c;
    public VmOperationsApi(HiokClient client) { this.c = client; }

    /** Attach nic. [POST /api/VirtualMachine/{vmName}/nics] */
    public JsonNode attachNic(String vmName, Object body) {
        return c.send("POST", "/api/VirtualMachine/" + HiokClient.segment(vmName) + "/nics", body, null);
    }

    /** Attach public ip. [POST /api/VirtualMachine/{vmName}/public-ips] */
    public JsonNode attachPublicIp(String vmName, Object body) {
        return c.send("POST", "/api/VirtualMachine/" + HiokClient.segment(vmName) + "/public-ips", body, null);
    }

    /** Connect. [GET /api/VirtualMachine/{vmName}/connect] */
    public JsonNode connect(String vmName) {
        return c.send("GET", "/api/VirtualMachine/" + HiokClient.segment(vmName) + "/connect", null, null);
    }

    /** Create snapshot. [POST /api/VirtualMachine/{vmName}/snapshots] */
    public JsonNode createSnapshot(String vmName, Object body) {
        return c.send("POST", "/api/VirtualMachine/" + HiokClient.segment(vmName) + "/snapshots", body, null);
    }

    /** Delete snapshot. [DELETE /api/VirtualMachine/{vmName}/snapshots/{snapshotName}] */
    public JsonNode deleteSnapshot(String vmName, String snapshotName) {
        return c.send("DELETE", "/api/VirtualMachine/" + HiokClient.segment(vmName) + "/snapshots/" + HiokClient.segment(snapshotName), null, null);
    }

    /** Detach nic. [DELETE /api/VirtualMachine/{vmName}/nics/{mac}] */
    public JsonNode detachNic(String vmName, String mac) {
        return c.send("DELETE", "/api/VirtualMachine/" + HiokClient.segment(vmName) + "/nics/" + HiokClient.segment(mac), null, null);
    }

    /** Detach public ip. [DELETE /api/VirtualMachine/{vmName}/public-ips/{allocationId}] */
    public JsonNode detachPublicIp(String vmName, String allocationId) {
        return c.send("DELETE", "/api/VirtualMachine/" + HiokClient.segment(vmName) + "/public-ips/" + HiokClient.segment(allocationId), null, null);
    }

    /** List nics. [GET /api/VirtualMachine/{vmName}/nics] */
    public JsonNode listNics(String vmName) {
        return c.send("GET", "/api/VirtualMachine/" + HiokClient.segment(vmName) + "/nics", null, null);
    }

    /** List public ips. [GET /api/VirtualMachine/{vmName}/public-ips] */
    public JsonNode listPublicIps(String vmName) {
        return c.send("GET", "/api/VirtualMachine/" + HiokClient.segment(vmName) + "/public-ips", null, null);
    }

    /** List snapshots. [GET /api/VirtualMachine/{vmName}/snapshots] */
    public JsonNode listSnapshots(String vmName) {
        return c.send("GET", "/api/VirtualMachine/" + HiokClient.segment(vmName) + "/snapshots", null, null);
    }

    /** Rdp file. [GET /api/VirtualMachine/{vmName}/rdp-file] */
    public JsonNode rdpFile(String vmName) {
        return c.send("GET", "/api/VirtualMachine/" + HiokClient.segment(vmName) + "/rdp-file", null, null);
    }

    /** Restore snapshot. [POST /api/VirtualMachine/{vmName}/snapshots/{snapshotName}/restore] */
    public JsonNode restoreSnapshot(String vmName, String snapshotName) {
        return c.send("POST", "/api/VirtualMachine/" + HiokClient.segment(vmName) + "/snapshots/" + HiokClient.segment(snapshotName) + "/restore", null, null);
    }

    /** Ssh key. [GET /api/VirtualMachine/{vmName}/ssh-key] */
    public JsonNode sshKey(String vmName) {
        return c.send("GET", "/api/VirtualMachine/" + HiokClient.segment(vmName) + "/ssh-key", null, null);
    }
}
