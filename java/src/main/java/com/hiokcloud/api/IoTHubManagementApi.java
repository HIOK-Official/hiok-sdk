// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package com.hiokcloud.api;

import com.hiokcloud.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** IoTHubManagement operations. */
public final class IoTHubManagementApi {
    private final HiokClient c;
    public IoTHubManagementApi(HiokClient client) { this.c = client; }

    /** Connection string. [GET /api/iothub/{hubId}/devices/{deviceId}/connection-string] */
    public JsonNode connectionString(String hubId, String deviceId) {
        return c.send("GET", "/api/iothub/" + HiokClient.segment(hubId) + "/devices/" + HiokClient.segment(deviceId) + "/connection-string", null, null);
    }

    /** Create device. [POST /api/iothub/{hubId}/devices] */
    public JsonNode createDevice(String hubId, Object body) {
        return c.send("POST", "/api/iothub/" + HiokClient.segment(hubId) + "/devices", body, null);
    }

    /** Delete device. [DELETE /api/iothub/{hubId}/devices/{deviceId}] */
    public JsonNode deleteDevice(String hubId, String deviceId) {
        return c.send("DELETE", "/api/iothub/" + HiokClient.segment(hubId) + "/devices/" + HiokClient.segment(deviceId), null, null);
    }

    /** Delete hub. [DELETE /api/iothub/{hubId}] */
    public JsonNode deleteHub(String hubId) {
        return c.send("DELETE", "/api/iothub/" + HiokClient.segment(hubId), null, null);
    }

    /** Get twin. [GET /api/iothub/{hubId}/devices/{deviceId}/twin] */
    public JsonNode getTwin(String hubId, String deviceId) {
        return c.send("GET", "/api/iothub/" + HiokClient.segment(hubId) + "/devices/" + HiokClient.segment(deviceId) + "/twin", null, null);
    }

    /** Messages. [GET /api/iothub/{hubId}/devices/{deviceId}/messages] */
    public JsonNode messages(String hubId, String deviceId, Object direction) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("direction", direction);
        return c.send("GET", "/api/iothub/" + HiokClient.segment(hubId) + "/devices/" + HiokClient.segment(deviceId) + "/messages", null, query_);
    }
    public JsonNode messages(String hubId, String deviceId) {
        return messages(hubId, deviceId, null);
    }

    /** Monitoring. [GET /api/iothub/{hubId}/monitoring] */
    public JsonNode monitoring(String hubId) {
        return c.send("GET", "/api/iothub/" + HiokClient.segment(hubId) + "/monitoring", null, null);
    }

    /** Receive c2 d. [POST /api/iothub/{hubId}/devices/{deviceId}/c2d/receive] */
    public JsonNode receiveC2D(String hubId, String deviceId) {
        return c.send("POST", "/api/iothub/" + HiokClient.segment(hubId) + "/devices/" + HiokClient.segment(deviceId) + "/c2d/receive", null, null);
    }

    /** Regenerate key. [POST /api/iothub/{hubId}/devices/{deviceId}/regenerate-key] */
    public JsonNode regenerateKey(String hubId, String deviceId) {
        return c.send("POST", "/api/iothub/" + HiokClient.segment(hubId) + "/devices/" + HiokClient.segment(deviceId) + "/regenerate-key", null, null);
    }

    /** Send c2 d. [POST /api/iothub/{hubId}/devices/{deviceId}/c2d] */
    public JsonNode sendC2D(String hubId, String deviceId, Object body) {
        return c.send("POST", "/api/iothub/" + HiokClient.segment(hubId) + "/devices/" + HiokClient.segment(deviceId) + "/c2d", body, null);
    }

    /** Send telemetry. [POST /api/iothub/{hubId}/devices/{deviceId}/telemetry] */
    public JsonNode sendTelemetry(String hubId, String deviceId, Object body) {
        return c.send("POST", "/api/iothub/" + HiokClient.segment(hubId) + "/devices/" + HiokClient.segment(deviceId) + "/telemetry", body, null);
    }

    /** Update twin. [PATCH /api/iothub/{hubId}/devices/{deviceId}/twin] */
    public JsonNode updateTwin(String hubId, String deviceId, Object body) {
        return c.send("PATCH", "/api/iothub/" + HiokClient.segment(hubId) + "/devices/" + HiokClient.segment(deviceId) + "/twin", body, null);
    }
}
