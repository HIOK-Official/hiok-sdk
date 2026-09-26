// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package com.hiokcloud.api;

import com.hiokcloud.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** ContainerJobs operations. */
public final class ContainerJobsApi {
    private final HiokClient c;
    public ContainerJobsApi(HiokClient client) { this.c = client; }

    /** Cancel. [POST /api/container-jobs/{id}/runs/{runId}/cancel] */
    public JsonNode cancel(String id, String runId) {
        return c.send("POST", "/api/container-jobs/" + HiokClient.segment(id) + "/runs/" + HiokClient.segment(runId) + "/cancel", null, null);
    }

    /** Create. [POST /api/container-jobs] */
    public JsonNode create(Object body) {
        return c.send("POST", "/api/container-jobs", body, null);
    }

    /** Delete. [DELETE /api/container-jobs/{id}] */
    public JsonNode delete(String id) {
        return c.send("DELETE", "/api/container-jobs/" + HiokClient.segment(id), null, null);
    }

    /** Get. [GET /api/container-jobs/{id}] */
    public JsonNode get(String id) {
        return c.send("GET", "/api/container-jobs/" + HiokClient.segment(id), null, null);
    }

    /** Get run. [GET /api/container-jobs/{id}/runs/{runId}] */
    public JsonNode getRun(String id, String runId) {
        return c.send("GET", "/api/container-jobs/" + HiokClient.segment(id) + "/runs/" + HiokClient.segment(runId), null, null);
    }

    /** List. [GET /api/container-jobs] */
    public JsonNode list() {
        return c.send("GET", "/api/container-jobs", null, null);
    }

    /** Preview. [GET /api/container-jobs/schedule-preview] */
    public JsonNode preview(Object cron, Object timeZone, Object count) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("cron", cron);
        query_.put("timeZone", timeZone);
        query_.put("count", count);
        return c.send("GET", "/api/container-jobs/schedule-preview", null, query_);
    }
    public JsonNode preview() {
        return preview(null, null, null);
    }

    /** Run. [POST /api/container-jobs/{id}/run] */
    public JsonNode run(String id) {
        return c.send("POST", "/api/container-jobs/" + HiokClient.segment(id) + "/run", null, null);
    }

    /** Runs. [GET /api/container-jobs/{id}/runs] */
    public JsonNode runs(String id, Object take) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("take", take);
        return c.send("GET", "/api/container-jobs/" + HiokClient.segment(id) + "/runs", null, query_);
    }
    public JsonNode runs(String id) {
        return runs(id, null);
    }

    /** Update. [PUT /api/container-jobs/{id}] */
    public JsonNode update(String id, Object body) {
        return c.send("PUT", "/api/container-jobs/" + HiokClient.segment(id), body, null);
    }
}
