// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package cloud.hiok.api;

import cloud.hiok.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** VirtualMachine operations. */
public final class VirtualMachineApi {
    private final HiokClient c;
    public VirtualMachineApi(HiokClient client) { this.c = client; }

    /** Create vm. [POST /api/VirtualMachine/create-vm] */
    public JsonNode createVM(Object body) {
        return c.send("POST", "/api/VirtualMachine/create-vm", body, null);
    }

    /** Destroy vm. [DELETE /api/VirtualMachine/destroy-vm] */
    public JsonNode destroyVM(Object body) {
        return c.send("DELETE", "/api/VirtualMachine/destroy-vm", body, null);
    }

    /** Get ssh private key. [GET /api/VirtualMachine/{id}/sshkey] */
    public JsonNode getSshPrivateKey(String id) {
        return c.send("GET", "/api/VirtualMachine/" + HiokClient.segment(id) + "/sshkey", null, null);
    }

    /** Get vminfo. [GET /api/VirtualMachine/vm-info] */
    public JsonNode getVMInfo(Object vmName, Object regions) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("vmName", vmName);
        query_.put("regions", regions);
        return c.send("GET", "/api/VirtualMachine/vm-info", null, query_);
    }
    public JsonNode getVMInfo() {
        return getVMInfo(null, null);
    }

    /** List local vmimages. [GET /api/VirtualMachine/list-local-vm-images] */
    public JsonNode listLocalVMImages(Object regions) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("regions", regions);
        return c.send("GET", "/api/VirtualMachine/list-local-vm-images", null, query_);
    }
    public JsonNode listLocalVMImages() {
        return listLocalVMImages(null);
    }

    /** List running vms. [GET /api/VirtualMachine/list-running-vms] */
    public JsonNode listRunningVMs(Object regions) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("regions", regions);
        return c.send("GET", "/api/VirtualMachine/list-running-vms", null, query_);
    }
    public JsonNode listRunningVMs() {
        return listRunningVMs(null);
    }

    /** List vms. [GET /api/VirtualMachine/list-vms] */
    public JsonNode listVMs(Object regions) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("regions", regions);
        return c.send("GET", "/api/VirtualMachine/list-vms", null, query_);
    }
    public JsonNode listVMs() {
        return listVMs(null);
    }

    /** List vms info. [GET /api/VirtualMachine/list-vms-info] */
    public JsonNode listVMsInfo(Object regions) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("regions", regions);
        return c.send("GET", "/api/VirtualMachine/list-vms-info", null, query_);
    }
    public JsonNode listVMsInfo() {
        return listVMsInfo(null);
    }

    /** Reset password. [POST /api/VirtualMachine/reset-password] */
    public JsonNode resetPassword(Object body) {
        return c.send("POST", "/api/VirtualMachine/reset-password", body, null);
    }

    /** Start vm. [POST /api/VirtualMachine/start-vm] */
    public JsonNode startVM(Object body) {
        return c.send("POST", "/api/VirtualMachine/start-vm", body, null);
    }

    /** Stop vm. [POST /api/VirtualMachine/stop-vm] */
    public JsonNode stopVM(Object body) {
        return c.send("POST", "/api/VirtualMachine/stop-vm", body, null);
    }
}
