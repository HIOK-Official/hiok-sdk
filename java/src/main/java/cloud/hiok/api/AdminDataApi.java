// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package cloud.hiok.api;

import cloud.hiok.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** AdminData operations. */
public final class AdminDataApi {
    private final HiokClient c;
    public AdminDataApi(HiokClient client) { this.c = client; }

    /** Resources. [GET /api/admin/resources] */
    public JsonNode resources(Object search, Object type) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("search", search);
        query_.put("type", type);
        return c.send("GET", "/api/admin/resources", null, query_);
    }
    public JsonNode resources() {
        return resources(null, null);
    }

    /** Subscriptions. [GET /api/admin/subscriptions] */
    public JsonNode subscriptions(Object search) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("search", search);
        return c.send("GET", "/api/admin/subscriptions", null, query_);
    }
    public JsonNode subscriptions() {
        return subscriptions(null);
    }

    /** Table rows. [GET /api/admin/database/{table}] */
    public JsonNode tableRows(String table, Object search, Object limit) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("search", search);
        query_.put("limit", limit);
        return c.send("GET", "/api/admin/database/" + HiokClient.segment(table), null, query_);
    }
    public JsonNode tableRows(String table) {
        return tableRows(table, null, null);
    }

    /** Tables. [GET /api/admin/database/tables] */
    public JsonNode tables() {
        return c.send("GET", "/api/admin/database/tables", null, null);
    }
}
