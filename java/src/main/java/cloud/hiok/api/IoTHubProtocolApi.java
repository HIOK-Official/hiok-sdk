// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package cloud.hiok.api;

import cloud.hiok.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** IoTHubProtocol operations. */
public final class IoTHubProtocolApi {
    private final HiokClient c;
    public IoTHubProtocolApi(HiokClient client) { this.c = client; }

    /** Algorithms. [GET /api/iothub/algorithms] */
    public JsonNode algorithms() {
        return c.send("GET", "/api/iothub/algorithms", null, null);
    }

    /** Ca certificate. [GET /api/iothub/{hubId}/ca] */
    public JsonNode caCertificate(String hubId) {
        return c.send("GET", "/api/iothub/" + HiokClient.segment(hubId) + "/ca", null, null);
    }

    /** Certificates. [GET /api/iothub/{hubId}/certificates] */
    public JsonNode certificates(String hubId) {
        return c.send("GET", "/api/iothub/" + HiokClient.segment(hubId) + "/certificates", null, null);
    }

    /** Connections. [GET /api/iothub/{hubId}/connections] */
    public JsonNode connections(String hubId) {
        return c.send("GET", "/api/iothub/" + HiokClient.segment(hubId) + "/connections", null, null);
    }

    /** Issue certificate. [POST /api/iothub/{hubId}/devices/{deviceId}/certificate] */
    public JsonNode issueCertificate(String hubId, String deviceId, Object body) {
        return c.send("POST", "/api/iothub/" + HiokClient.segment(hubId) + "/devices/" + HiokClient.segment(deviceId) + "/certificate", body, null);
    }

    /** Pq sessions. [GET /api/iothub/{hubId}/pq-sessions] */
    public JsonNode pqSessions(String hubId) {
        return c.send("GET", "/api/iothub/" + HiokClient.segment(hubId) + "/pq-sessions", null, null);
    }

    /** Protocols. [GET /api/iothub/protocols] */
    public JsonNode protocols() {
        return c.send("GET", "/api/iothub/protocols", null, null);
    }

    /** Provision. [POST /api/iothub/{hubId}/provision] */
    public JsonNode provision(String hubId, Object body) {
        return c.send("POST", "/api/iothub/" + HiokClient.segment(hubId) + "/provision", body, null);
    }
}
