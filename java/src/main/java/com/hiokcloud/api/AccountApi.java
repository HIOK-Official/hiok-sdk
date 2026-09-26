// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package com.hiokcloud.api;

import com.hiokcloud.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** Account operations. */
public final class AccountApi {
    private final HiokClient c;
    public AccountApi(HiokClient client) { this.c = client; }

    /** Api keys. [GET /api/account/api-keys] */
    public JsonNode apiKeys() {
        return c.send("GET", "/api/account/api-keys", null, null);
    }

    /** Change password. [POST /api/account/password] */
    public JsonNode changePassword(Object body) {
        return c.send("POST", "/api/account/password", body, null);
    }

    /** Create api key. [POST /api/account/api-keys] */
    public JsonNode createApiKey(Object body) {
        return c.send("POST", "/api/account/api-keys", body, null);
    }

    /** Delete account. [POST /api/account/delete] */
    public JsonNode deleteAccount(Object body) {
        return c.send("POST", "/api/account/delete", body, null);
    }

    /** Delete tenant. [POST /api/account/tenants/delete] */
    public JsonNode deleteTenant(Object body) {
        return c.send("POST", "/api/account/tenants/delete", body, null);
    }

    /** Deletion plan. [GET /api/account/deletion] */
    public JsonNode deletionPlan() {
        return c.send("GET", "/api/account/deletion", null, null);
    }

    /** Deletion status. [GET /api/account/delete/status] */
    public JsonNode deletionStatus() {
        return c.send("GET", "/api/account/delete/status", null, null);
    }

    /** Export. [GET /api/account/export] */
    public JsonNode export(Object format) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("format", format);
        return c.send("GET", "/api/account/export", null, query_);
    }
    public JsonNode export() {
        return export(null);
    }

    /** Get preferences. [GET /api/account/preferences] */
    public JsonNode getPreferences() {
        return c.send("GET", "/api/account/preferences", null, null);
    }

    /** Revoke api key. [DELETE /api/account/api-keys/{id}] */
    public JsonNode revokeApiKey(String id) {
        return c.send("DELETE", "/api/account/api-keys/" + HiokClient.segment(id), null, null);
    }

    /** Save preferences. [PUT /api/account/preferences] */
    public JsonNode savePreferences(Object body) {
        return c.send("PUT", "/api/account/preferences", body, null);
    }

    /** Tenant deletion plan. [GET /api/account/tenants/deletion] */
    public JsonNode tenantDeletionPlan(Object account) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("account", account);
        return c.send("GET", "/api/account/tenants/deletion", null, query_);
    }
    public JsonNode tenantDeletionPlan() {
        return tenantDeletionPlan(null);
    }

    /** Tenant deletion status. [GET /api/account/tenants/delete/status] */
    public JsonNode tenantDeletionStatus(Object account) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("account", account);
        return c.send("GET", "/api/account/tenants/delete/status", null, query_);
    }
    public JsonNode tenantDeletionStatus() {
        return tenantDeletionStatus(null);
    }
}
