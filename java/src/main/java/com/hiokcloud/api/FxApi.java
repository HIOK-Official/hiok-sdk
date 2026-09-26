// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package com.hiokcloud.api;

import com.hiokcloud.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** Fx operations. */
public final class FxApi {
    private final HiokClient c;
    public FxApi(HiokClient client) { this.c = client; }

    /** Convert. [GET /api/Fx/convert] */
    public JsonNode convert(Object usd, Object currency) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("usd", usd);
        query_.put("currency", currency);
        return c.send("GET", "/api/Fx/convert", null, query_);
    }
    public JsonNode convert() {
        return convert(null, null);
    }

    /** Rates. [GET /api/Fx/rates] */
    public JsonNode rates() {
        return c.send("GET", "/api/Fx/rates", null, null);
    }
}
