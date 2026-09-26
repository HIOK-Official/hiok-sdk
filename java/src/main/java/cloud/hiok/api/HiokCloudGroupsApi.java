// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package cloud.hiok.api;

import cloud.hiok.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** HiokCloudGroups operations. */
public final class HiokCloudGroupsApi {
    private final HiokClient c;
    public HiokCloudGroupsApi(HiokClient client) { this.c = client; }

    /** Create hiok cloud access group. [POST /api/HiokCloudGroups/createaccessgroup] */
    public JsonNode createHiokCloudAccessGroup(Object body) {
        return c.send("POST", "/api/HiokCloudGroups/createaccessgroup", body, null);
    }

    /** Create management group. [POST /api/HiokCloudGroups/createmanagementgroup] */
    public JsonNode createManagementGroup(Object body) {
        return c.send("POST", "/api/HiokCloudGroups/createmanagementgroup", body, null);
    }

    /** Create resource group. [POST /api/HiokCloudGroups/createresourcegroup] */
    public JsonNode createResourceGroup(Object body) {
        return c.send("POST", "/api/HiokCloudGroups/createresourcegroup", body, null);
    }

    /** Delete hiok cloud access group. [DELETE /api/HiokCloudGroups/deleteaccessgroup] */
    public JsonNode deleteHiokCloudAccessGroup(Object body) {
        return c.send("DELETE", "/api/HiokCloudGroups/deleteaccessgroup", body, null);
    }

    /** Edit hiok cloud access group. [PUT /api/HiokCloudGroups/editaccessgroup] */
    public JsonNode editHiokCloudAccessGroup(Object body) {
        return c.send("PUT", "/api/HiokCloudGroups/editaccessgroup", body, null);
    }

    /** Get all hiok cloud access group. [GET /api/HiokCloudGroups/allaccessgroups] */
    public JsonNode getAllHiokCloudAccessGroup() {
        return c.send("GET", "/api/HiokCloudGroups/allaccessgroups", null, null);
    }

    /** Get hiok cloud access group. [GET /api/HiokCloudGroups/accessgroups] */
    public JsonNode getHiokCloudAccessGroup() {
        return c.send("GET", "/api/HiokCloudGroups/accessgroups", null, null);
    }

    /** Get hiok cloud specific access group. [GET /api/HiokCloudGroups/specificaccessgroups] */
    public JsonNode getHiokCloudSpecificAccessGroup(Object type) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("type", type);
        return c.send("GET", "/api/HiokCloudGroups/specificaccessgroups", null, query_);
    }
    public JsonNode getHiokCloudSpecificAccessGroup() {
        return getHiokCloudSpecificAccessGroup(null);
    }
}
