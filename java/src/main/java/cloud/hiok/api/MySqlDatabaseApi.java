// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package cloud.hiok.api;

import cloud.hiok.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** MySqlDatabase operations. */
public final class MySqlDatabaseApi {
    private final HiokClient c;
    public MySqlDatabaseApi(HiokClient client) { this.c = client; }

    /** Columns. [GET /api/MySqlDatabase/{id}/objects/{schema}/{table}/columns] */
    public JsonNode columns(String id, String schema, String table, Object database) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("database", database);
        return c.send("GET", "/api/MySqlDatabase/" + HiokClient.segment(id) + "/objects/" + HiokClient.segment(schema) + "/" + HiokClient.segment(table) + "/columns", null, query_);
    }
    public JsonNode columns(String id, String schema, String table) {
        return columns(id, schema, table, null);
    }

    /** Connection. [GET /api/MySqlDatabase/{id}/connection] */
    public JsonNode connection(String id) {
        return c.send("GET", "/api/MySqlDatabase/" + HiokClient.segment(id) + "/connection", null, null);
    }

    /** Create. [POST /api/MySqlDatabase] */
    public JsonNode create(Object body) {
        return c.send("POST", "/api/MySqlDatabase", body, null);
    }

    /** Databases. [GET /api/MySqlDatabase/{id}/databases] */
    public JsonNode databases(String id) {
        return c.send("GET", "/api/MySqlDatabase/" + HiokClient.segment(id) + "/databases", null, null);
    }

    /** Delete. [DELETE /api/MySqlDatabase/{id}] */
    public JsonNode delete(String id) {
        return c.send("DELETE", "/api/MySqlDatabase/" + HiokClient.segment(id), null, null);
    }

    /** Get. [GET /api/MySqlDatabase/{id}] */
    public JsonNode get(String id) {
        return c.send("GET", "/api/MySqlDatabase/" + HiokClient.segment(id), null, null);
    }

    /** List. [GET /api/MySqlDatabase] */
    public JsonNode list() {
        return c.send("GET", "/api/MySqlDatabase", null, null);
    }

    /** Objects. [GET /api/MySqlDatabase/{id}/objects] */
    public JsonNode objects(String id, Object database) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("database", database);
        return c.send("GET", "/api/MySqlDatabase/" + HiokClient.segment(id) + "/objects", null, query_);
    }
    public JsonNode objects(String id) {
        return objects(id, null);
    }

    /** Query. [POST /api/MySqlDatabase/{id}/query] */
    public JsonNode query(String id, Object body) {
        return c.send("POST", "/api/MySqlDatabase/" + HiokClient.segment(id) + "/query", body, null);
    }

    /** Reset password. [POST /api/MySqlDatabase/{id}/reset-password] */
    public JsonNode resetPassword(String id, Object body) {
        return c.send("POST", "/api/MySqlDatabase/" + HiokClient.segment(id) + "/reset-password", body, null);
    }
}
