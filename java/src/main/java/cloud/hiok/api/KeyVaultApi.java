// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package cloud.hiok.api;

import cloud.hiok.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** KeyVault operations. */
public final class KeyVaultApi {
    private final HiokClient c;
    public KeyVaultApi(HiokClient client) { this.c = client; }

    /** Create. [POST /api/KeyVault] */
    public JsonNode create(Object body) {
        return c.send("POST", "/api/KeyVault", body, null);
    }

    /** Create certificate. [POST /api/KeyVault/{id}/certificates] */
    public JsonNode createCertificate(String id, Object body) {
        return c.send("POST", "/api/KeyVault/" + HiokClient.segment(id) + "/certificates", body, null);
    }

    /** Delete. [DELETE /api/KeyVault/{id}] */
    public JsonNode delete(String id) {
        return c.send("DELETE", "/api/KeyVault/" + HiokClient.segment(id), null, null);
    }

    /** Delete item. [DELETE /api/KeyVault/{id}/items/{name}] */
    public JsonNode deleteItem(String id, String name) {
        return c.send("DELETE", "/api/KeyVault/" + HiokClient.segment(id) + "/items/" + HiokClient.segment(name), null, null);
    }

    /** Download csr. [GET /api/KeyVault/{id}/certificates/{name}/csr] */
    public JsonNode downloadCsr(String id, String name) {
        return c.send("GET", "/api/KeyVault/" + HiokClient.segment(id) + "/certificates/" + HiokClient.segment(name) + "/csr", null, null);
    }

    /** Export certificate. [POST /api/KeyVault/{id}/certificates/{name}/export] */
    public JsonNode exportCertificate(String id, String name, Object body) {
        return c.send("POST", "/api/KeyVault/" + HiokClient.segment(id) + "/certificates/" + HiokClient.segment(name) + "/export", body, null);
    }

    /** Get. [GET /api/KeyVault/{id}] */
    public JsonNode get(String id) {
        return c.send("GET", "/api/KeyVault/" + HiokClient.segment(id), null, null);
    }

    /** Get item. [GET /api/KeyVault/{id}/items/{name}] */
    public JsonNode getItem(String id, String name, Object version) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("version", version);
        return c.send("GET", "/api/KeyVault/" + HiokClient.segment(id) + "/items/" + HiokClient.segment(name), null, query_);
    }
    public JsonNode getItem(String id, String name) {
        return getItem(id, name, null);
    }

    /** List. [GET /api/KeyVault] */
    public JsonNode list() {
        return c.send("GET", "/api/KeyVault", null, null);
    }

    /** List deleted. [GET /api/KeyVault/deleted] */
    public JsonNode listDeleted() {
        return c.send("GET", "/api/KeyVault/deleted", null, null);
    }

    /** List items. [GET /api/KeyVault/{id}/items] */
    public JsonNode listItems(String id, Object itemType, Object includeDeleted) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("itemType", itemType);
        query_.put("includeDeleted", includeDeleted);
        return c.send("GET", "/api/KeyVault/" + HiokClient.segment(id) + "/items", null, query_);
    }
    public JsonNode listItems(String id) {
        return listItems(id, null, null);
    }

    /** List versions. [GET /api/KeyVault/{id}/items/{name}/versions] */
    public JsonNode listVersions(String id, String name) {
        return c.send("GET", "/api/KeyVault/" + HiokClient.segment(id) + "/items/" + HiokClient.segment(name) + "/versions", null, null);
    }

    /** Merge certificate. [POST /api/KeyVault/{id}/certificates/{name}/merge] */
    public JsonNode mergeCertificate(String id, String name, Object body) {
        return c.send("POST", "/api/KeyVault/" + HiokClient.segment(id) + "/certificates/" + HiokClient.segment(name) + "/merge", body, null);
    }

    /** Purge. [DELETE /api/KeyVault/{id}/purge] */
    public JsonNode purge(String id) {
        return c.send("DELETE", "/api/KeyVault/" + HiokClient.segment(id) + "/purge", null, null);
    }

    /** Recover. [POST /api/KeyVault/{id}/recover] */
    public JsonNode recover(String id) {
        return c.send("POST", "/api/KeyVault/" + HiokClient.segment(id) + "/recover", null, null);
    }

    /** Recover item. [POST /api/KeyVault/{id}/items/{name}/recover] */
    public JsonNode recoverItem(String id, String name) {
        return c.send("POST", "/api/KeyVault/" + HiokClient.segment(id) + "/items/" + HiokClient.segment(name) + "/recover", null, null);
    }

    /** Set item. [POST /api/KeyVault/{id}/items] */
    public JsonNode setItem(String id, Object body) {
        return c.send("POST", "/api/KeyVault/" + HiokClient.segment(id) + "/items", body, null);
    }

    /** Update. [PUT /api/KeyVault/{id}] */
    public JsonNode update(String id, Object body) {
        return c.send("PUT", "/api/KeyVault/" + HiokClient.segment(id), body, null);
    }

    /** Update item. [PUT /api/KeyVault/{id}/items/{name}] */
    public JsonNode updateItem(String id, String name, Object body, Object version) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("version", version);
        return c.send("PUT", "/api/KeyVault/" + HiokClient.segment(id) + "/items/" + HiokClient.segment(name), body, query_);
    }
    public JsonNode updateItem(String id, String name, Object body) {
        return updateItem(id, name, body, null);
    }
}
