// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package com.hiokcloud.api;

import com.hiokcloud.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** MailAdmin operations. */
public final class MailAdminApi {
    private final HiokClient c;
    public MailAdminApi(HiokClient client) { this.c = client; }

    /** Accounts. [GET /api/mail/admin/accounts] */
    public JsonNode accounts() {
        return c.send("GET", "/api/mail/admin/accounts", null, null);
    }

    /** Create. [POST /api/mail/admin/accounts] */
    public JsonNode create(Object body) {
        return c.send("POST", "/api/mail/admin/accounts", body, null);
    }

    /** Delete. [DELETE /api/mail/admin/accounts/{id}] */
    public JsonNode delete(String id) {
        return c.send("DELETE", "/api/mail/admin/accounts/" + HiokClient.segment(id), null, null);
    }

    /** Domains. [GET /api/mail/admin/domains] */
    public JsonNode domains() {
        return c.send("GET", "/api/mail/admin/domains", null, null);
    }

    /** Grant. [POST /api/mail/admin/accounts/{id}/access] */
    public JsonNode grant(String id, Object body) {
        return c.send("POST", "/api/mail/admin/accounts/" + HiokClient.segment(id) + "/access", body, null);
    }

    /** Revoke. [DELETE /api/mail/admin/accounts/{id}/access/{emailId}] */
    public JsonNode revoke(String id, String emailId) {
        return c.send("DELETE", "/api/mail/admin/accounts/" + HiokClient.segment(id) + "/access/" + HiokClient.segment(emailId), null, null);
    }

    /** Set password. [POST /api/mail/admin/accounts/{id}/password] */
    public JsonNode setPassword(String id, Object body) {
        return c.send("POST", "/api/mail/admin/accounts/" + HiokClient.segment(id) + "/password", body, null);
    }

    /** Update. [PATCH /api/mail/admin/accounts/{id}] */
    public JsonNode update(String id, Object body) {
        return c.send("PATCH", "/api/mail/admin/accounts/" + HiokClient.segment(id), body, null);
    }
}
