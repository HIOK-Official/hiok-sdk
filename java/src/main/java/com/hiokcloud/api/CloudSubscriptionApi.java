// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package com.hiokcloud.api;

import com.hiokcloud.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** CloudSubscription operations. */
public final class CloudSubscriptionApi {
    private final HiokClient c;
    public CloudSubscriptionApi(HiokClient client) { this.c = client; }

    /** Add payment. [POST /api/cloudsubscription/payment-methods] */
    public JsonNode addPayment(Object body) {
        return c.send("POST", "/api/cloudsubscription/payment-methods", body, null);
    }

    /** Create. [POST /api/cloudsubscription] */
    public JsonNode create(Object body) {
        return c.send("POST", "/api/cloudsubscription", body, null);
    }

    /** Delete. [DELETE /api/cloudsubscription/{id}] */
    public JsonNode delete(String id) {
        return c.send("DELETE", "/api/cloudsubscription/" + HiokClient.segment(id), null, null);
    }

    /** List. [GET /api/cloudsubscription] */
    public JsonNode list() {
        return c.send("GET", "/api/cloudsubscription", null, null);
    }

    /** Payment methods. [GET /api/cloudsubscription/payment-methods] */
    public JsonNode paymentMethods() {
        return c.send("GET", "/api/cloudsubscription/payment-methods", null, null);
    }
}
