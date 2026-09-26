// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package cloud.hiok.api;

import cloud.hiok.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** ApiManagement operations. */
public final class ApiManagementApi {
    private final HiokClient c;
    public ApiManagementApi(HiokClient client) { this.c = client; }

    /** Analytics. [GET /api/apim/apis/{apiId}/analytics] */
    public JsonNode analytics(String apiId, Object hours) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("hours", hours);
        return c.send("GET", "/api/apim/apis/" + HiokClient.segment(apiId) + "/analytics", null, query_);
    }
    public JsonNode analytics(String apiId) {
        return analytics(apiId, null);
    }

    /** Create api. [POST /api/apim/apis] */
    public JsonNode createApi(Object body) {
        return c.send("POST", "/api/apim/apis", body, null);
    }

    /** Create operation. [POST /api/apim/apis/{apiId}/operations] */
    public JsonNode createOperation(String apiId, Object body) {
        return c.send("POST", "/api/apim/apis/" + HiokClient.segment(apiId) + "/operations", body, null);
    }

    /** Create policy. [POST /api/apim/apis/{apiId}/policies] */
    public JsonNode createPolicy(String apiId, Object body) {
        return c.send("POST", "/api/apim/apis/" + HiokClient.segment(apiId) + "/policies", body, null);
    }

    /** Create product. [POST /api/apim/products] */
    public JsonNode createProduct(Object body) {
        return c.send("POST", "/api/apim/products", body, null);
    }

    /** Create sub. [POST /api/apim/subscriptions] */
    public JsonNode createSub(Object body) {
        return c.send("POST", "/api/apim/subscriptions", body, null);
    }

    /** Delete api. [DELETE /api/apim/apis/{id}] */
    public JsonNode deleteApi(String id) {
        return c.send("DELETE", "/api/apim/apis/" + HiokClient.segment(id), null, null);
    }

    /** Delete operation. [DELETE /api/apim/operations/{id}] */
    public JsonNode deleteOperation(String id) {
        return c.send("DELETE", "/api/apim/operations/" + HiokClient.segment(id), null, null);
    }

    /** Delete policy. [DELETE /api/apim/policies/{id}] */
    public JsonNode deletePolicy(String id) {
        return c.send("DELETE", "/api/apim/policies/" + HiokClient.segment(id), null, null);
    }

    /** Gateway. [GET /api/apim/gateway/{apiPath}/{rest}] */
    public JsonNode gateway(String apiPath, String rest) {
        return c.send("GET", "/api/apim/gateway/" + HiokClient.segment(apiPath) + "/" + HiokClient.segment(rest), null, null);
    }

    /** Gateway delete. [DELETE /api/apim/gateway/{apiPath}/{rest}] */
    public JsonNode gatewayDelete(String apiPath, String rest) {
        return c.send("DELETE", "/api/apim/gateway/" + HiokClient.segment(apiPath) + "/" + HiokClient.segment(rest), null, null);
    }

    /** Gateway post. [POST /api/apim/gateway/{apiPath}/{rest}] */
    public JsonNode gatewayPost(String apiPath, String rest) {
        return c.send("POST", "/api/apim/gateway/" + HiokClient.segment(apiPath) + "/" + HiokClient.segment(rest), null, null);
    }

    /** Gateway put. [PUT /api/apim/gateway/{apiPath}/{rest}] */
    public JsonNode gatewayPut(String apiPath, String rest) {
        return c.send("PUT", "/api/apim/gateway/" + HiokClient.segment(apiPath) + "/" + HiokClient.segment(rest), null, null);
    }

    /** List apis. [GET /api/apim/apis] */
    public JsonNode listApis() {
        return c.send("GET", "/api/apim/apis", null, null);
    }

    /** List operations. [GET /api/apim/apis/{apiId}/operations] */
    public JsonNode listOperations(String apiId) {
        return c.send("GET", "/api/apim/apis/" + HiokClient.segment(apiId) + "/operations", null, null);
    }

    /** List policies. [GET /api/apim/apis/{apiId}/policies] */
    public JsonNode listPolicies(String apiId) {
        return c.send("GET", "/api/apim/apis/" + HiokClient.segment(apiId) + "/policies", null, null);
    }

    /** List products. [GET /api/apim/products] */
    public JsonNode listProducts() {
        return c.send("GET", "/api/apim/products", null, null);
    }

    /** List subs. [GET /api/apim/subscriptions] */
    public JsonNode listSubs() {
        return c.send("GET", "/api/apim/subscriptions", null, null);
    }

    /** Regen sub key. [POST /api/apim/subscriptions/{id}/regenerate-key] */
    public JsonNode regenSubKey(String id, Object which) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("which", which);
        return c.send("POST", "/api/apim/subscriptions/" + HiokClient.segment(id) + "/regenerate-key", null, query_);
    }
    public JsonNode regenSubKey(String id) {
        return regenSubKey(id, null);
    }

    /** Update operation. [PUT /api/apim/operations/{id}] */
    public JsonNode updateOperation(String id, Object body) {
        return c.send("PUT", "/api/apim/operations/" + HiokClient.segment(id), body, null);
    }
}
