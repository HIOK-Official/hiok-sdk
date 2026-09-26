// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package cloud.hiok.api;

import cloud.hiok.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** ResourceGovernance operations. */
public final class ResourceGovernanceApi {
    private final HiokClient c;
    public ResourceGovernanceApi(HiokClient client) { this.c = client; }

    /** Create lock. [POST /api/resource-governance/{resourceType}/{resourceId}/locks] */
    public JsonNode createLock(String resourceType, String resourceId, Object body) {
        return c.send("POST", "/api/resource-governance/" + HiokClient.segment(resourceType) + "/" + HiokClient.segment(resourceId) + "/locks", body, null);
    }

    /** Delete lock. [DELETE /api/resource-governance/{resourceType}/{resourceId}/locks/{lockId}] */
    public JsonNode deleteLock(String resourceType, String resourceId, String lockId) {
        return c.send("DELETE", "/api/resource-governance/" + HiokClient.segment(resourceType) + "/" + HiokClient.segment(resourceId) + "/locks/" + HiokClient.segment(lockId), null, null);
    }

    /** Estate. [GET /api/resource-governance/estate] */
    public JsonNode estate() {
        return c.send("GET", "/api/resource-governance/estate", null, null);
    }

    /** Get activity log. [GET /api/resource-governance/{resourceType}/{resourceId}/activity-log] */
    public JsonNode getActivityLog(String resourceType, String resourceId, Object limit) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("limit", limit);
        return c.send("GET", "/api/resource-governance/" + HiokClient.segment(resourceType) + "/" + HiokClient.segment(resourceId) + "/activity-log", null, query_);
    }
    public JsonNode getActivityLog(String resourceType, String resourceId) {
        return getActivityLog(resourceType, resourceId, null);
    }

    /** Get properties. [GET /api/resource-governance/{resourceType}/{resourceId}/properties] */
    public JsonNode getProperties(String resourceType, String resourceId) {
        return c.send("GET", "/api/resource-governance/" + HiokClient.segment(resourceType) + "/" + HiokClient.segment(resourceId) + "/properties", null, null);
    }

    /** Get tenant activity. [GET /api/resource-governance/activity] */
    public JsonNode getTenantActivity(Object mine, Object resourceType, Object status, Object hours, Object limit) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("mine", mine);
        query_.put("resourceType", resourceType);
        query_.put("status", status);
        query_.put("hours", hours);
        query_.put("limit", limit);
        return c.send("GET", "/api/resource-governance/activity", null, query_);
    }
    public JsonNode getTenantActivity() {
        return getTenantActivity(null, null, null, null, null);
    }

    /** List locks. [GET /api/resource-governance/{resourceType}/{resourceId}/locks] */
    public JsonNode listLocks(String resourceType, String resourceId, Object includeInherited) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("includeInherited", includeInherited);
        return c.send("GET", "/api/resource-governance/" + HiokClient.segment(resourceType) + "/" + HiokClient.segment(resourceId) + "/locks", null, query_);
    }
    public JsonNode listLocks(String resourceType, String resourceId) {
        return listLocks(resourceType, resourceId, null);
    }

    /** Scopes. [GET /api/resource-governance/scopes] */
    public JsonNode scopes(Object ids) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("ids", ids);
        return c.send("GET", "/api/resource-governance/scopes", null, query_);
    }
    public JsonNode scopes() {
        return scopes(null);
    }

    /** Update tags. [PUT /api/resource-governance/{resourceType}/{resourceId}/tags] */
    public JsonNode updateTags(String resourceType, String resourceId, Object body) {
        return c.send("PUT", "/api/resource-governance/" + HiokClient.segment(resourceType) + "/" + HiokClient.segment(resourceId) + "/tags", body, null);
    }
}
