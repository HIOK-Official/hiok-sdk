// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package com.hiokcloud.api;

import com.hiokcloud.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** Oidc operations. */
public final class OidcApi {
    private final HiokClient c;
    public OidcApi(HiokClient client) { this.c = client; }

    /** Approve. [POST /api/hiok-id/oidc/authorize] */
    public JsonNode approve(Object body) {
        return c.send("POST", "/api/hiok-id/oidc/authorize", body, null);
    }

    /** Authorize. [GET /api/hiok-id/oidc/authorize] */
    public JsonNode authorize(Object clientId, Object redirectUri, Object responseType) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("client_id", clientId);
        query_.put("redirect_uri", redirectUri);
        query_.put("response_type", responseType);
        return c.send("GET", "/api/hiok-id/oidc/authorize", null, query_);
    }
    public JsonNode authorize() {
        return authorize(null, null, null);
    }

    /** Authorize info. [GET /api/hiok-id/oidc/authorize/info] */
    public JsonNode authorizeInfo(Object clientId, Object redirectUri) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("client_id", clientId);
        query_.put("redirect_uri", redirectUri);
        return c.send("GET", "/api/hiok-id/oidc/authorize/info", null, query_);
    }
    public JsonNode authorizeInfo() {
        return authorizeInfo(null, null);
    }

    /** Discovery. [GET /api/hiok-id/oidc/.well-known/openid-configuration] */
    public JsonNode discovery() {
        return c.send("GET", "/api/hiok-id/oidc/.well-known/openid-configuration", null, null);
    }

    /** Jwks. [GET /api/hiok-id/oidc/jwks] */
    public JsonNode jwks() {
        return c.send("GET", "/api/hiok-id/oidc/jwks", null, null);
    }

    /** Token. [POST /api/hiok-id/oidc/token] */
    public JsonNode token(Object body) {
        return c.send("POST", "/api/hiok-id/oidc/token", body, null);
    }

    /** User info. [GET /api/hiok-id/oidc/userinfo] */
    public JsonNode userInfo() {
        return c.send("GET", "/api/hiok-id/oidc/userinfo", null, null);
    }
}
