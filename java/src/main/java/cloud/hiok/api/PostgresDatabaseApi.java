// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package cloud.hiok.api;

import cloud.hiok.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** PostgresDatabase operations. */
public final class PostgresDatabaseApi {
    private final HiokClient c;
    public PostgresDatabaseApi(HiokClient client) { this.c = client; }

    /** Columns. [GET /api/PostgresDatabase/{id}/objects/{schema}/{table}/columns] */
    public JsonNode columns(String id, String schema, String table, Object database) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("database", database);
        return c.send("GET", "/api/PostgresDatabase/" + HiokClient.segment(id) + "/objects/" + HiokClient.segment(schema) + "/" + HiokClient.segment(table) + "/columns", null, query_);
    }
    public JsonNode columns(String id, String schema, String table) {
        return columns(id, schema, table, null);
    }

    /** Connection. [GET /api/PostgresDatabase/{id}/connection] */
    public JsonNode connection(String id) {
        return c.send("GET", "/api/PostgresDatabase/" + HiokClient.segment(id) + "/connection", null, null);
    }

    /** Create. [POST /api/PostgresDatabase] */
    public JsonNode create(Object body) {
        return c.send("POST", "/api/PostgresDatabase", body, null);
    }

    /** Databases. [GET /api/PostgresDatabase/{id}/databases] */
    public JsonNode databases(String id) {
        return c.send("GET", "/api/PostgresDatabase/" + HiokClient.segment(id) + "/databases", null, null);
    }

    /** Delete. [DELETE /api/PostgresDatabase/{id}] */
    public JsonNode delete(String id) {
        return c.send("DELETE", "/api/PostgresDatabase/" + HiokClient.segment(id), null, null);
    }

    /** Get. [GET /api/PostgresDatabase/{id}] */
    public JsonNode get(String id) {
        return c.send("GET", "/api/PostgresDatabase/" + HiokClient.segment(id), null, null);
    }

    /** List. [GET /api/PostgresDatabase] */
    public JsonNode list() {
        return c.send("GET", "/api/PostgresDatabase", null, null);
    }

    /** Objects. [GET /api/PostgresDatabase/{id}/objects] */
    public JsonNode objects(String id, Object database) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("database", database);
        return c.send("GET", "/api/PostgresDatabase/" + HiokClient.segment(id) + "/objects", null, query_);
    }
    public JsonNode objects(String id) {
        return objects(id, null);
    }

    /** Query. [POST /api/PostgresDatabase/{id}/query] */
    public JsonNode query(String id, Object body) {
        return c.send("POST", "/api/PostgresDatabase/" + HiokClient.segment(id) + "/query", body, null);
    }

    /** Reset password. [POST /api/PostgresDatabase/{id}/reset-password] */
    public JsonNode resetPassword(String id, Object body) {
        return c.send("POST", "/api/PostgresDatabase/" + HiokClient.segment(id) + "/reset-password", body, null);
    }
}
