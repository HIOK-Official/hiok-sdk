// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package cloud.hiok.api;

import cloud.hiok.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** VmNetwork operations. */
public final class VmNetworkApi {
    private final HiokClient c;
    public VmNetworkApi(HiokClient client) { this.c = client; }

    /** Create. [POST /api/VirtualMachine/{vmName}/network-rules] */
    public JsonNode create(String vmName, Object body) {
        return c.send("POST", "/api/VirtualMachine/" + HiokClient.segment(vmName) + "/network-rules", body, null);
    }

    /** Delete. [DELETE /api/VirtualMachine/network-rules/{id}] */
    public JsonNode delete(String id) {
        return c.send("DELETE", "/api/VirtualMachine/network-rules/" + HiokClient.segment(id), null, null);
    }

    /** List. [GET /api/VirtualMachine/{vmName}/network-rules] */
    public JsonNode list(String vmName, Object type, Object direction) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("type", type);
        query_.put("direction", direction);
        return c.send("GET", "/api/VirtualMachine/" + HiokClient.segment(vmName) + "/network-rules", null, query_);
    }
    public JsonNode list(String vmName) {
        return list(vmName, null, null);
    }

    /** Network info. [GET /api/VirtualMachine/{vmName}/network-info] */
    public JsonNode networkInfo(String vmName) {
        return c.send("GET", "/api/VirtualMachine/" + HiokClient.segment(vmName) + "/network-info", null, null);
    }

    /** Sync. [POST /api/VirtualMachine/{vmName}/network-rules/sync] */
    public JsonNode sync(String vmName) {
        return c.send("POST", "/api/VirtualMachine/" + HiokClient.segment(vmName) + "/network-rules/sync", null, null);
    }

    /** Update. [PUT /api/VirtualMachine/network-rules/{id}] */
    public JsonNode update(String id, Object body) {
        return c.send("PUT", "/api/VirtualMachine/network-rules/" + HiokClient.segment(id), body, null);
    }
}
