// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package cloud.hiok.api;

import cloud.hiok.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** Yugabyte operations. */
public final class YugabyteApi {
    private final HiokClient c;
    public YugabyteApi(HiokClient client) { this.c = client; }

    /** Attach. [POST /api/Yugabyte/{id}/vnet/attach] */
    public JsonNode attach(String id) {
        return c.send("POST", "/api/Yugabyte/" + HiokClient.segment(id) + "/vnet/attach", null, null);
    }

    /** Columns. [GET /api/Yugabyte/{id}/tables/{schema}/{table}/columns] */
    public JsonNode columns(String id, String schema, String table) {
        return c.send("GET", "/api/Yugabyte/" + HiokClient.segment(id) + "/tables/" + HiokClient.segment(schema) + "/" + HiokClient.segment(table) + "/columns", null, null);
    }

    /** Connection. [GET /api/Yugabyte/{id}/connection] */
    public JsonNode connection(String id) {
        return c.send("GET", "/api/Yugabyte/" + HiokClient.segment(id) + "/connection", null, null);
    }

    /** Create. [POST /api/Yugabyte] */
    public JsonNode create(Object body) {
        return c.send("POST", "/api/Yugabyte", body, null);
    }

    /** Delete. [DELETE /api/Yugabyte/{id}] */
    public JsonNode delete(String id) {
        return c.send("DELETE", "/api/Yugabyte/" + HiokClient.segment(id), null, null);
    }

    /** Detach. [POST /api/Yugabyte/{id}/vnet/detach] */
    public JsonNode detach(String id) {
        return c.send("POST", "/api/Yugabyte/" + HiokClient.segment(id) + "/vnet/detach", null, null);
    }

    /** Get. [GET /api/Yugabyte/{id}] */
    public JsonNode get(String id) {
        return c.send("GET", "/api/Yugabyte/" + HiokClient.segment(id), null, null);
    }

    /** List. [GET /api/Yugabyte] */
    public JsonNode list() {
        return c.send("GET", "/api/Yugabyte", null, null);
    }

    /** Query. [POST /api/Yugabyte/{id}/query] */
    public JsonNode query(String id, Object body) {
        return c.send("POST", "/api/Yugabyte/" + HiokClient.segment(id) + "/query", body, null);
    }

    /** Start. [POST /api/Yugabyte/{id}/start] */
    public JsonNode start(String id) {
        return c.send("POST", "/api/Yugabyte/" + HiokClient.segment(id) + "/start", null, null);
    }

    /** Stop. [POST /api/Yugabyte/{id}/stop] */
    public JsonNode stop(String id) {
        return c.send("POST", "/api/Yugabyte/" + HiokClient.segment(id) + "/stop", null, null);
    }

    /** Tables. [GET /api/Yugabyte/{id}/tables] */
    public JsonNode tables(String id) {
        return c.send("GET", "/api/Yugabyte/" + HiokClient.segment(id) + "/tables", null, null);
    }
}
