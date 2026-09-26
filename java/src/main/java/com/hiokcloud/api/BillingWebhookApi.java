// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package com.hiokcloud.api;

import com.hiokcloud.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** BillingWebhook operations. */
public final class BillingWebhookApi {
    private final HiokClient c;
    public BillingWebhookApi(HiokClient client) { this.c = client; }

    /** Receive. [POST /api/billing/webhook/{provider}] */
    public JsonNode receive(String provider) {
        return c.send("POST", "/api/billing/webhook/" + HiokClient.segment(provider), null, null);
    }
}
