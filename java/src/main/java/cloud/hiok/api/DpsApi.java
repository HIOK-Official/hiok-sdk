// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package cloud.hiok.api;

import cloud.hiok.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** Dps operations. */
public final class DpsApi {
    private final HiokClient c;
    public DpsApi(HiokClient client) { this.c = client; }

    /** Create. [POST /api/dps/enrollments] */
    public JsonNode create(Object body) {
        return c.send("POST", "/api/dps/enrollments", body, null);
    }

    /** Delete. [DELETE /api/dps/enrollments/{id}] */
    public JsonNode delete(String id) {
        return c.send("DELETE", "/api/dps/enrollments/" + HiokClient.segment(id), null, null);
    }

    /** List. [GET /api/dps/enrollments] */
    public JsonNode list() {
        return c.send("GET", "/api/dps/enrollments", null, null);
    }

    /** Register. [POST /api/dps/register] */
    public JsonNode register(Object body) {
        return c.send("POST", "/api/dps/register", body, null);
    }

    /** Registrations. [GET /api/dps/enrollments/{id}/registrations] */
    public JsonNode registrations(String id) {
        return c.send("GET", "/api/dps/enrollments/" + HiokClient.segment(id) + "/registrations", null, null);
    }
}
