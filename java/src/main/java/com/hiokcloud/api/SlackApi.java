// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package com.hiokcloud.api;

import com.hiokcloud.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** Slack operations. */
public final class SlackApi {
    private final HiokClient c;
    public SlackApi(HiokClient client) { this.c = client; }

    /** Command. [POST /api/integrations/slack/command] */
    public JsonNode command() {
        return c.send("POST", "/api/integrations/slack/command", null, null);
    }

    /** Config info. [GET /api/integrations/slack/config] */
    public JsonNode configInfo() {
        return c.send("GET", "/api/integrations/slack/config", null, null);
    }

    /** Install. [GET /api/integrations/slack/install] */
    public JsonNode install() {
        return c.send("GET", "/api/integrations/slack/install", null, null);
    }

    /** Link. [POST /api/integrations/slack/link] */
    public JsonNode link(Object body) {
        return c.send("POST", "/api/integrations/slack/link", body, null);
    }

    /** OAuth. [GET /api/integrations/slack/oauth] */
    public JsonNode oAuth(Object code, Object state, Object error) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("code", code);
        query_.put("state", state);
        query_.put("error", error);
        return c.send("GET", "/api/integrations/slack/oauth", null, query_);
    }
    public JsonNode oAuth() {
        return oAuth(null, null, null);
    }
}
