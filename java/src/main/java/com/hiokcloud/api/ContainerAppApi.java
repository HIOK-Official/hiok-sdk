// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package com.hiokcloud.api;

import com.hiokcloud.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** ContainerApp operations. */
public final class ContainerAppApi {
    private final HiokClient c;
    public ContainerAppApi(HiokClient client) { this.c = client; }

    /** Create app. [POST /api/ContainerApp] */
    public JsonNode createApp(Object body) {
        return c.send("POST", "/api/ContainerApp", body, null);
    }

    /** Create environment. [POST /api/ContainerApp/environments] */
    public JsonNode createEnvironment(Object body) {
        return c.send("POST", "/api/ContainerApp/environments", body, null);
    }

    /** Create revision. [POST /api/ContainerApp/{id}/revisions] */
    public JsonNode createRevision(String id, Object body) {
        return c.send("POST", "/api/ContainerApp/" + HiokClient.segment(id) + "/revisions", body, null);
    }

    /** Delete app. [DELETE /api/ContainerApp/{id}] */
    public JsonNode deleteApp(String id) {
        return c.send("DELETE", "/api/ContainerApp/" + HiokClient.segment(id), null, null);
    }

    /** Delete environment. [DELETE /api/ContainerApp/environments/{id}] */
    public JsonNode deleteEnvironment(String id) {
        return c.send("DELETE", "/api/ContainerApp/environments/" + HiokClient.segment(id), null, null);
    }

    /** Environment contents. [GET /api/ContainerApp/environments/{id}/contents] */
    public JsonNode environmentContents(String id) {
        return c.send("GET", "/api/ContainerApp/environments/" + HiokClient.segment(id) + "/contents", null, null);
    }

    /** Exec. [POST /api/ContainerApp/{id}/exec] */
    public JsonNode exec(String id, Object body) {
        return c.send("POST", "/api/ContainerApp/" + HiokClient.segment(id) + "/exec", body, null);
    }

    /** Get app. [GET /api/ContainerApp/{id}] */
    public JsonNode getApp(String id) {
        return c.send("GET", "/api/ContainerApp/" + HiokClient.segment(id), null, null);
    }

    /** Get replicas. [GET /api/ContainerApp/{id}/replicas] */
    public JsonNode getReplicas(String id) {
        return c.send("GET", "/api/ContainerApp/" + HiokClient.segment(id) + "/replicas", null, null);
    }

    /** List apps. [GET /api/ContainerApp] */
    public JsonNode listApps() {
        return c.send("GET", "/api/ContainerApp", null, null);
    }

    /** List environments. [GET /api/ContainerApp/environments] */
    public JsonNode listEnvironments() {
        return c.send("GET", "/api/ContainerApp/environments", null, null);
    }

    /** List revisions. [GET /api/ContainerApp/{id}/revisions] */
    public JsonNode listRevisions(String id) {
        return c.send("GET", "/api/ContainerApp/" + HiokClient.segment(id) + "/revisions", null, null);
    }

    /** Rollback. [POST /api/ContainerApp/{id}/revisions/{revisionName}/rollback] */
    public JsonNode rollback(String id, String revisionName) {
        return c.send("POST", "/api/ContainerApp/" + HiokClient.segment(id) + "/revisions/" + HiokClient.segment(revisionName) + "/rollback", null, null);
    }

    /** Scale. [POST /api/ContainerApp/{id}/scale] */
    public JsonNode scale(String id, Object body) {
        return c.send("POST", "/api/ContainerApp/" + HiokClient.segment(id) + "/scale", body, null);
    }

    /** Set traffic. [POST /api/ContainerApp/{id}/revisions/traffic] */
    public JsonNode setTraffic(String id, Object body) {
        return c.send("POST", "/api/ContainerApp/" + HiokClient.segment(id) + "/revisions/traffic", body, null);
    }
}
