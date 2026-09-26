// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package com.hiokcloud.api;

import com.hiokcloud.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** Pricing operations. */
public final class PricingApi {
    private final HiokClient c;
    public PricingApi(HiokClient client) { this.c = client; }

    /** List. [GET /api/Pricing] */
    public JsonNode list() {
        return c.send("GET", "/api/Pricing", null, null);
    }

    /** Rate card. [GET /api/Pricing/ratecard] */
    public JsonNode rateCard() {
        return c.send("GET", "/api/Pricing/ratecard", null, null);
    }

    /** Update. [PUT /api/Pricing] */
    public JsonNode update(Object body) {
        return c.send("PUT", "/api/Pricing", body, null);
    }
}
