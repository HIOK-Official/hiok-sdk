// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package cloud.hiok.api;

import cloud.hiok.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** AdminDns operations. */
public final class AdminDnsApi {
    private final HiokClient c;
    public AdminDnsApi(HiokClient client) { this.c = client; }

    /** Delete. [DELETE /api/admin/dns/records/{id}] */
    public JsonNode delete(String id) {
        return c.send("DELETE", "/api/admin/dns/records/" + HiokClient.segment(id), null, null);
    }

    /** Mail health. [GET /api/admin/dns/mail-health] */
    public JsonNode mailHealth() {
        return c.send("GET", "/api/admin/dns/mail-health", null, null);
    }

    /** Records. [GET /api/admin/dns/records] */
    public JsonNode records(Object q) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("q", q);
        return c.send("GET", "/api/admin/dns/records", null, query_);
    }
    public JsonNode records() {
        return records(null);
    }

    /** Upsert. [POST /api/admin/dns/records] */
    public JsonNode upsert(Object body) {
        return c.send("POST", "/api/admin/dns/records", body, null);
    }
}
