// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package com.hiokcloud.api;

import com.hiokcloud.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** StreamPipeline operations. */
public final class StreamPipelineApi {
    private final HiokClient c;
    public StreamPipelineApi(HiokClient client) { this.c = client; }

    /** Create. [POST /api/StreamAnalytics/{jobId}/pipelines] */
    public JsonNode create(String jobId, Object body) {
        return c.send("POST", "/api/StreamAnalytics/" + HiokClient.segment(jobId) + "/pipelines", body, null);
    }

    /** Delete. [DELETE /api/StreamAnalytics/{jobId}/pipelines/{pipelineId}] */
    public JsonNode delete(String jobId, String pipelineId) {
        return c.send("DELETE", "/api/StreamAnalytics/" + HiokClient.segment(jobId) + "/pipelines/" + HiokClient.segment(pipelineId), null, null);
    }

    /** Get. [GET /api/StreamAnalytics/{jobId}/pipelines/{pipelineId}] */
    public JsonNode get(String jobId, String pipelineId) {
        return c.send("GET", "/api/StreamAnalytics/" + HiokClient.segment(jobId) + "/pipelines/" + HiokClient.segment(pipelineId), null, null);
    }

    /** Get run. [GET /api/StreamAnalytics/{jobId}/pipelines/runs/{runId}] */
    public JsonNode getRun(String jobId, String runId) {
        return c.send("GET", "/api/StreamAnalytics/" + HiokClient.segment(jobId) + "/pipelines/runs/" + HiokClient.segment(runId), null, null);
    }

    /** List. [GET /api/StreamAnalytics/{jobId}/pipelines] */
    public JsonNode list(String jobId) {
        return c.send("GET", "/api/StreamAnalytics/" + HiokClient.segment(jobId) + "/pipelines", null, null);
    }

    /** Preview schedule. [GET /api/StreamAnalytics/schedule-preview] */
    public JsonNode previewSchedule(Object cron, Object timeZone, Object count) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("cron", cron);
        query_.put("timeZone", timeZone);
        query_.put("count", count);
        return c.send("GET", "/api/StreamAnalytics/schedule-preview", null, query_);
    }
    public JsonNode previewSchedule() {
        return previewSchedule(null, null, null);
    }

    /** Run. [POST /api/StreamAnalytics/{jobId}/pipelines/{pipelineId}/run] */
    public JsonNode run(String jobId, String pipelineId) {
        return c.send("POST", "/api/StreamAnalytics/" + HiokClient.segment(jobId) + "/pipelines/" + HiokClient.segment(pipelineId) + "/run", null, null);
    }

    /** Runs. [GET /api/StreamAnalytics/{jobId}/pipelines/{pipelineId}/runs] */
    public JsonNode runs(String jobId, String pipelineId, Object limit) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("limit", limit);
        return c.send("GET", "/api/StreamAnalytics/" + HiokClient.segment(jobId) + "/pipelines/" + HiokClient.segment(pipelineId) + "/runs", null, query_);
    }
    public JsonNode runs(String jobId, String pipelineId) {
        return runs(jobId, pipelineId, null);
    }

    /** Update. [PUT /api/StreamAnalytics/{jobId}/pipelines/{pipelineId}] */
    public JsonNode update(String jobId, String pipelineId, Object body) {
        return c.send("PUT", "/api/StreamAnalytics/" + HiokClient.segment(jobId) + "/pipelines/" + HiokClient.segment(pipelineId), body, null);
    }
}
