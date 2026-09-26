// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package cloud.hiok.api;

import cloud.hiok.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** AdminInfrastructure operations. */
public final class AdminInfrastructureApi {
    private final HiokClient c;
    public AdminInfrastructureApi(HiokClient client) { this.c = client; }

    /** Bridges. [GET /api/admin/infrastructure/bridges] */
    public JsonNode bridges(Object region) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("region", region);
        return c.send("GET", "/api/admin/infrastructure/bridges", null, query_);
    }
    public JsonNode bridges() {
        return bridges(null);
    }

    /** Containers. [GET /api/admin/infrastructure/containers] */
    public JsonNode containers(Object region) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("region", region);
        return c.send("GET", "/api/admin/infrastructure/containers", null, query_);
    }
    public JsonNode containers() {
        return containers(null);
    }

    /** Delete bridge. [DELETE /api/admin/infrastructure/bridges/{name}] */
    public JsonNode deleteBridge(String name, Object region) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("region", region);
        return c.send("DELETE", "/api/admin/infrastructure/bridges/" + HiokClient.segment(name), null, query_);
    }
    public JsonNode deleteBridge(String name) {
        return deleteBridge(name, null);
    }

    /** Delete container. [DELETE /api/admin/infrastructure/containers/{id}] */
    public JsonNode deleteContainer(String id, Object region) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("region", region);
        return c.send("DELETE", "/api/admin/infrastructure/containers/" + HiokClient.segment(id), null, query_);
    }
    public JsonNode deleteContainer(String id) {
        return deleteContainer(id, null);
    }

    /** Delete image. [DELETE /api/admin/infrastructure/images/{id}] */
    public JsonNode deleteImage(String id, Object region) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("region", region);
        return c.send("DELETE", "/api/admin/infrastructure/images/" + HiokClient.segment(id), null, query_);
    }
    public JsonNode deleteImage(String id) {
        return deleteImage(id, null);
    }

    /** Delete network. [DELETE /api/admin/infrastructure/networks/{id}] */
    public JsonNode deleteNetwork(String id, Object region) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("region", region);
        return c.send("DELETE", "/api/admin/infrastructure/networks/" + HiokClient.segment(id), null, query_);
    }
    public JsonNode deleteNetwork(String id) {
        return deleteNetwork(id, null);
    }

    /** Delete vm. [DELETE /api/admin/infrastructure/vms/{name}] */
    public JsonNode deleteVm(String name, Object region) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("region", region);
        return c.send("DELETE", "/api/admin/infrastructure/vms/" + HiokClient.segment(name), null, query_);
    }
    public JsonNode deleteVm(String name) {
        return deleteVm(name, null);
    }

    /** Delete volume. [DELETE /api/admin/infrastructure/volumes/{name}] */
    public JsonNode deleteVolume(String name, Object region) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("region", region);
        return c.send("DELETE", "/api/admin/infrastructure/volumes/" + HiokClient.segment(name), null, query_);
    }
    public JsonNode deleteVolume(String name) {
        return deleteVolume(name, null);
    }

    /** Dns janitor. [POST /api/admin/infrastructure/dns-janitor] */
    public JsonNode dnsJanitor(Object dryRun) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("dryRun", dryRun);
        return c.send("POST", "/api/admin/infrastructure/dns-janitor", null, query_);
    }
    public JsonNode dnsJanitor() {
        return dnsJanitor(null);
    }

    /** Firewall. [GET /api/admin/infrastructure/firewall] */
    public JsonNode firewall(Object region, Object chain) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("region", region);
        query_.put("chain", chain);
        return c.send("GET", "/api/admin/infrastructure/firewall", null, query_);
    }
    public JsonNode firewall() {
        return firewall(null, null);
    }

    /** Flows. [GET /api/admin/infrastructure/flows] */
    public JsonNode flows(Object region, Object bridge) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("region", region);
        query_.put("bridge", bridge);
        return c.send("GET", "/api/admin/infrastructure/flows", null, query_);
    }
    public JsonNode flows() {
        return flows(null, null);
    }

    /** Images. [GET /api/admin/infrastructure/images] */
    public JsonNode images(Object region) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("region", region);
        return c.send("GET", "/api/admin/infrastructure/images", null, query_);
    }
    public JsonNode images() {
        return images(null);
    }

    /** Metrics. [GET /api/admin/infrastructure/metrics] */
    public JsonNode metrics(Object region) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("region", region);
        return c.send("GET", "/api/admin/infrastructure/metrics", null, query_);
    }
    public JsonNode metrics() {
        return metrics(null);
    }

    /** Networks. [GET /api/admin/infrastructure/networks] */
    public JsonNode networks(Object region) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("region", region);
        return c.send("GET", "/api/admin/infrastructure/networks", null, query_);
    }
    public JsonNode networks() {
        return networks(null);
    }

    /** Virtual machines. [GET /api/admin/infrastructure/vms] */
    public JsonNode virtualMachines(Object region) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("region", region);
        return c.send("GET", "/api/admin/infrastructure/vms", null, query_);
    }
    public JsonNode virtualMachines() {
        return virtualMachines(null);
    }

    /** Volumes. [GET /api/admin/infrastructure/volumes] */
    public JsonNode volumes(Object region) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("region", region);
        return c.send("GET", "/api/admin/infrastructure/volumes", null, query_);
    }
    public JsonNode volumes() {
        return volumes(null);
    }
}
