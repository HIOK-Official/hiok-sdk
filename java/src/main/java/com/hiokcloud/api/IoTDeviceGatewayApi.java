// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package com.hiokcloud.api;

import com.hiokcloud.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** IoTDeviceGateway operations. */
public final class IoTDeviceGatewayApi {
    private final HiokClient c;
    public IoTDeviceGatewayApi(HiokClient client) { this.c = client; }

    /** Get twin. [GET /api/iot/devices/{deviceId}/twin] */
    public JsonNode getTwin(String deviceId) {
        return c.send("GET", "/api/iot/devices/" + HiokClient.segment(deviceId) + "/twin", null, null);
    }

    /** Patch reported. [PATCH /api/iot/devices/{deviceId}/twin/reported] */
    public JsonNode patchReported(String deviceId, Object body) {
        return c.send("PATCH", "/api/iot/devices/" + HiokClient.segment(deviceId) + "/twin/reported", body, null);
    }

    /** Pq complete. [POST /api/iot/devices/{deviceId}/pq/complete] */
    public JsonNode pqComplete(String deviceId, Object body) {
        return c.send("POST", "/api/iot/devices/" + HiokClient.segment(deviceId) + "/pq/complete", body, null);
    }

    /** Pq handshake. [POST /api/iot/devices/{deviceId}/pq/handshake] */
    public JsonNode pqHandshake(String deviceId, Object body) {
        return c.send("POST", "/api/iot/devices/" + HiokClient.segment(deviceId) + "/pq/handshake", body, null);
    }

    /** Receive commands. [GET /api/iot/devices/{deviceId}/messages/devicebound] */
    public JsonNode receiveCommands(String deviceId) {
        return c.send("GET", "/api/iot/devices/" + HiokClient.segment(deviceId) + "/messages/devicebound", null, null);
    }

    /** Send telemetry. [POST /api/iot/devices/{deviceId}/messages/events] */
    public JsonNode sendTelemetry(String deviceId, Object body) {
        return c.send("POST", "/api/iot/devices/" + HiokClient.segment(deviceId) + "/messages/events", body, null);
    }

    /** Stream. [GET /api/iot/devices/{deviceId}/stream] */
    public JsonNode stream(String deviceId) {
        return c.send("GET", "/api/iot/devices/" + HiokClient.segment(deviceId) + "/stream", null, null);
    }
}
