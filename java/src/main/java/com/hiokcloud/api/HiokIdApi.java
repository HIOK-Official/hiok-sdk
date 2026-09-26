// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package com.hiokcloud.api;

import com.hiokcloud.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** HiokId operations. */
public final class HiokIdApi {
    private final HiokClient c;
    public HiokIdApi(HiokClient client) { this.c = client; }

    /** Accept. [POST /api/hiok-id/invitations/{id}/accept] */
    public JsonNode accept(String id) {
        return c.send("POST", "/api/hiok-id/invitations/" + HiokClient.segment(id) + "/accept", null, null);
    }

    /** Add app credential. [POST /api/hiok-id/apps/{id}/credentials] */
    public JsonNode addAppCredential(String id, Object body) {
        return c.send("POST", "/api/hiok-id/apps/" + HiokClient.segment(id) + "/credentials", body, null);
    }

    /** Add group member. [POST /api/hiok-id/groups/{id}/members] */
    public JsonNode addGroupMember(String id, Object body) {
        return c.send("POST", "/api/hiok-id/groups/" + HiokClient.segment(id) + "/members", body, null);
    }

    /** Add sp credential. [POST /api/hiok-id/service-principals/{id}/credentials] */
    public JsonNode addSpCredential(String id, Object body) {
        return c.send("POST", "/api/hiok-id/service-principals/" + HiokClient.segment(id) + "/credentials", body, null);
    }

    /** Apps. [GET /api/hiok-id/apps] */
    public JsonNode apps() {
        return c.send("GET", "/api/hiok-id/apps", null, null);
    }

    /** Create app. [POST /api/hiok-id/apps] */
    public JsonNode createApp(Object body) {
        return c.send("POST", "/api/hiok-id/apps", body, null);
    }

    /** Create group. [POST /api/hiok-id/groups] */
    public JsonNode createGroup(Object body) {
        return c.send("POST", "/api/hiok-id/groups", body, null);
    }

    /** Create service principal. [POST /api/hiok-id/service-principals] */
    public JsonNode createServicePrincipal(Object body) {
        return c.send("POST", "/api/hiok-id/service-principals", body, null);
    }

    /** Create tenant. [POST /api/hiok-id/tenants] */
    public JsonNode createTenant(Object body) {
        return c.send("POST", "/api/hiok-id/tenants", body, null);
    }

    /** Decline. [POST /api/hiok-id/invitations/{id}/decline] */
    public JsonNode decline(String id) {
        return c.send("POST", "/api/hiok-id/invitations/" + HiokClient.segment(id) + "/decline", null, null);
    }

    /** Delete app. [DELETE /api/hiok-id/apps/{id}] */
    public JsonNode deleteApp(String id) {
        return c.send("DELETE", "/api/hiok-id/apps/" + HiokClient.segment(id), null, null);
    }

    /** Delete group. [DELETE /api/hiok-id/groups/{id}] */
    public JsonNode deleteGroup(String id) {
        return c.send("DELETE", "/api/hiok-id/groups/" + HiokClient.segment(id), null, null);
    }

    /** Delete service principal. [DELETE /api/hiok-id/service-principals/{id}] */
    public JsonNode deleteServicePrincipal(String id) {
        return c.send("DELETE", "/api/hiok-id/service-principals/" + HiokClient.segment(id), null, null);
    }

    /** Directories. [GET /api/hiok-id/directories] */
    public JsonNode directories() {
        return c.send("GET", "/api/hiok-id/directories", null, null);
    }

    /** Enter. [POST /api/hiok-id/directories/enter] */
    public JsonNode enter(Object body) {
        return c.send("POST", "/api/hiok-id/directories/enter", body, null);
    }

    /** Groups. [GET /api/hiok-id/groups] */
    public JsonNode groups() {
        return c.send("GET", "/api/hiok-id/groups", null, null);
    }

    /** Invite. [POST /api/hiok-id/users] */
    public JsonNode invite(Object body) {
        return c.send("POST", "/api/hiok-id/users", body, null);
    }

    /** Leave. [POST /api/hiok-id/directories/leave] */
    public JsonNode leave(Object body) {
        return c.send("POST", "/api/hiok-id/directories/leave", body, null);
    }

    /** Me. [GET /api/hiok-id/me] */
    public JsonNode me() {
        return c.send("GET", "/api/hiok-id/me", null, null);
    }

    /** Overview. [GET /api/hiok-id/overview] */
    public JsonNode overview() {
        return c.send("GET", "/api/hiok-id/overview", null, null);
    }

    /** Remove app credential. [DELETE /api/hiok-id/apps/{id}/credentials/{credentialId}] */
    public JsonNode removeAppCredential(String id, String credentialId) {
        return c.send("DELETE", "/api/hiok-id/apps/" + HiokClient.segment(id) + "/credentials/" + HiokClient.segment(credentialId), null, null);
    }

    /** Remove group member. [DELETE /api/hiok-id/groups/{id}/members/{kind}/{reference}] */
    public JsonNode removeGroupMember(String id, String kind, String reference) {
        return c.send("DELETE", "/api/hiok-id/groups/" + HiokClient.segment(id) + "/members/" + HiokClient.segment(kind) + "/" + HiokClient.segment(reference), null, null);
    }

    /** Remove member. [DELETE /api/hiok-id/users/{id}] */
    public JsonNode removeMember(String id) {
        return c.send("DELETE", "/api/hiok-id/users/" + HiokClient.segment(id), null, null);
    }

    /** Remove sp credential. [DELETE /api/hiok-id/service-principals/{id}/credentials/{credentialId}] */
    public JsonNode removeSpCredential(String id, String credentialId) {
        return c.send("DELETE", "/api/hiok-id/service-principals/" + HiokClient.segment(id) + "/credentials/" + HiokClient.segment(credentialId), null, null);
    }

    /** Rename directory. [PUT /api/hiok-id/directory] */
    public JsonNode renameDirectory(Object body) {
        return c.send("PUT", "/api/hiok-id/directory", body, null);
    }

    /** Resend. [POST /api/hiok-id/users/{id}/resend] */
    public JsonNode resend(String id) {
        return c.send("POST", "/api/hiok-id/users/" + HiokClient.segment(id) + "/resend", null, null);
    }

    /** Service principals. [GET /api/hiok-id/service-principals] */
    public JsonNode servicePrincipals() {
        return c.send("GET", "/api/hiok-id/service-principals", null, null);
    }

    /** Sign ins. [GET /api/hiok-id/sign-ins] */
    public JsonNode signIns(Object take, Object outcome) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("take", take);
        query_.put("outcome", outcome);
        return c.send("GET", "/api/hiok-id/sign-ins", null, query_);
    }
    public JsonNode signIns() {
        return signIns(null, null);
    }

    /** Update app. [PUT /api/hiok-id/apps/{id}] */
    public JsonNode updateApp(String id, Object body) {
        return c.send("PUT", "/api/hiok-id/apps/" + HiokClient.segment(id), body, null);
    }

    /** Update group. [PUT /api/hiok-id/groups/{id}] */
    public JsonNode updateGroup(String id, Object body) {
        return c.send("PUT", "/api/hiok-id/groups/" + HiokClient.segment(id), body, null);
    }

    /** Update member. [PUT /api/hiok-id/users/{id}] */
    public JsonNode updateMember(String id, Object body) {
        return c.send("PUT", "/api/hiok-id/users/" + HiokClient.segment(id), body, null);
    }

    /** Update service principal. [PUT /api/hiok-id/service-principals/{id}] */
    public JsonNode updateServicePrincipal(String id, Object body) {
        return c.send("PUT", "/api/hiok-id/service-principals/" + HiokClient.segment(id), body, null);
    }

    /** Users. [GET /api/hiok-id/users] */
    public JsonNode users() {
        return c.send("GET", "/api/hiok-id/users", null, null);
    }
}
