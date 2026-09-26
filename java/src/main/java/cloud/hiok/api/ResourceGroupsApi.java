// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package cloud.hiok.api;

import cloud.hiok.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** ResourceGroups operations. */
public final class ResourceGroupsApi {
    private final HiokClient c;
    public ResourceGroupsApi(HiokClient client) { this.c = client; }

    /** Create resource group. [POST /api/resourcegroups] */
    public JsonNode createResourceGroup(Object body) {
        return c.send("POST", "/api/resourcegroups", body, null);
    }

    /** Delete resource group. [DELETE /api/resourcegroups/{id}] */
    public JsonNode deleteResourceGroup(String id) {
        return c.send("DELETE", "/api/resourcegroups/" + HiokClient.segment(id), null, null);
    }

    /** List resource groups. [GET /api/resourcegroups] */
    public JsonNode listResourceGroups() {
        return c.send("GET", "/api/resourcegroups", null, null);
    }
}
