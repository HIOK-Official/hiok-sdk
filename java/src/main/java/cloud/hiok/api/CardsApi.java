// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package cloud.hiok.api;

import cloud.hiok.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** Cards operations. */
public final class CardsApi {
    private final HiokClient c;
    public CardsApi(HiokClient client) { this.c = client; }

    /** Complete. [POST /api/billing/cards/complete] */
    public JsonNode complete(Object body) {
        return c.send("POST", "/api/billing/cards/complete", body, null);
    }

    /** List. [GET /api/billing/cards] */
    public JsonNode list() {
        return c.send("GET", "/api/billing/cards", null, null);
    }

    /** Providers. [GET /api/billing/cards/providers] */
    public JsonNode providers() {
        return c.send("GET", "/api/billing/cards/providers", null, null);
    }

    /** Remove. [DELETE /api/billing/cards/{id}] */
    public JsonNode remove(String id) {
        return c.send("DELETE", "/api/billing/cards/" + HiokClient.segment(id), null, null);
    }

    /** Setup. [POST /api/billing/cards/setup] */
    public JsonNode setup(Object body) {
        return c.send("POST", "/api/billing/cards/setup", body, null);
    }
}
