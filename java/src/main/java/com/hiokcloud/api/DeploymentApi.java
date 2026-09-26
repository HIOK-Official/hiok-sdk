// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package com.hiokcloud.api;

import com.hiokcloud.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** Deployment operations. */
public final class DeploymentApi {
    private final HiokClient c;
    public DeploymentApi(HiokClient client) { this.c = client; }

    /** Delete deployment. [DELETE /api/Deployment/deployments/{id}] */
    public JsonNode deleteDeployment(String id) {
        return c.send("DELETE", "/api/Deployment/deployments/" + HiokClient.segment(id), null, null);
    }

    /** Deployment. [GET /api/Deployment/deployments/{id}] */
    public JsonNode deployment(String id) {
        return c.send("GET", "/api/Deployment/deployments/" + HiokClient.segment(id), null, null);
    }

    /** Deployments. [GET /api/Deployment/deployments] */
    public JsonNode deployments(Object status, Object limit) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("status", status);
        query_.put("limit", limit);
        return c.send("GET", "/api/Deployment/deployments", null, query_);
    }
    public JsonNode deployments() {
        return deployments(null, null);
    }

    /** Redeploy. [POST /api/Deployment/deployments/{id}/redeploy] */
    public JsonNode redeploy(String id) {
        return c.send("POST", "/api/Deployment/deployments/" + HiokClient.segment(id) + "/redeploy", null, null);
    }

    /** Status. [GET /api/Deployment/status] */
    public JsonNode status(Object limit) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("limit", limit);
        return c.send("GET", "/api/Deployment/status", null, query_);
    }
    public JsonNode status() {
        return status(null);
    }
}
