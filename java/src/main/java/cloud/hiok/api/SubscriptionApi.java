// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package cloud.hiok.api;

import cloud.hiok.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** Subscription operations. */
public final class SubscriptionApi {
    private final HiokClient c;
    public SubscriptionApi(HiokClient client) { this.c = client; }

    /** Active subscriptions. [GET /api/Subscription/activesubscriptions] */
    public JsonNode activeSubscriptions() {
        return c.send("GET", "/api/Subscription/activesubscriptions", null, null);
    }

    /** Add subscriptionto user. [POST /api/Subscription/addsubscriptiontouser] */
    public JsonNode addSubscriptiontoUser(Object body) {
        return c.send("POST", "/api/Subscription/addsubscriptiontouser", body, null);
    }

    /** Create subscription. [POST /api/Subscription/createsubscriptions] */
    public JsonNode createSubscription(Object body) {
        return c.send("POST", "/api/Subscription/createsubscriptions", body, null);
    }

    /** Create user subscription. [POST /api/Subscription/createsubscription] */
    public JsonNode createUserSubscription(Object body) {
        return c.send("POST", "/api/Subscription/createsubscription", body, null);
    }

    /** Delete subscription by id. [DELETE /api/Subscription/removesubscription/{id}] */
    public JsonNode deleteSubscriptionById(String id) {
        return c.send("DELETE", "/api/Subscription/removesubscription/" + HiokClient.segment(id), null, null);
    }

    /** My subscriptions. [GET /api/Subscription/mysubscriptions] */
    public JsonNode mySubscriptions() {
        return c.send("GET", "/api/Subscription/mysubscriptions", null, null);
    }

    /** Subscriptions. [GET /api/Subscription/subscriptions] */
    public JsonNode subscriptions() {
        return c.send("GET", "/api/Subscription/subscriptions", null, null);
    }
}
