// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package cloud.hiok.api;

import cloud.hiok.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** Communication operations. */
public final class CommunicationApi {
    private final HiokClient c;
    public CommunicationApi(HiokClient client) { this.c = client; }

    /** Add domain. [POST /api/Communication/services/{id}/domains] */
    public JsonNode addDomain(String id, Object body) {
        return c.send("POST", "/api/Communication/services/" + HiokClient.segment(id) + "/domains", body, null);
    }

    /** Add sender. [POST /api/Communication/services/{id}/domains/{domainId}/senders] */
    public JsonNode addSender(String id, String domainId, Object body) {
        return c.send("POST", "/api/Communication/services/" + HiokClient.segment(id) + "/domains/" + HiokClient.segment(domainId) + "/senders", body, null);
    }

    /** Create connector. [POST /api/Communication/services/{id}/connectors] */
    public JsonNode createConnector(String id, Object body) {
        return c.send("POST", "/api/Communication/services/" + HiokClient.segment(id) + "/connectors", body, null);
    }

    /** Create service. [POST /api/Communication/services] */
    public JsonNode createService(Object body) {
        return c.send("POST", "/api/Communication/services", body, null);
    }

    /** Delete connector. [DELETE /api/Communication/services/{id}/connectors/{connectorId}] */
    public JsonNode deleteConnector(String id, String connectorId) {
        return c.send("DELETE", "/api/Communication/services/" + HiokClient.segment(id) + "/connectors/" + HiokClient.segment(connectorId), null, null);
    }

    /** Delete domain. [DELETE /api/Communication/services/{id}/domains/{domainId}] */
    public JsonNode deleteDomain(String id, String domainId) {
        return c.send("DELETE", "/api/Communication/services/" + HiokClient.segment(id) + "/domains/" + HiokClient.segment(domainId), null, null);
    }

    /** Delete message. [DELETE /api/Communication/services/{id}/emails/{messageId}] */
    public JsonNode deleteMessage(String id, String messageId) {
        return c.send("DELETE", "/api/Communication/services/" + HiokClient.segment(id) + "/emails/" + HiokClient.segment(messageId), null, null);
    }

    /** Delete sender. [DELETE /api/Communication/services/{id}/domains/{domainId}/senders/{senderId}] */
    public JsonNode deleteSender(String id, String domainId, String senderId) {
        return c.send("DELETE", "/api/Communication/services/" + HiokClient.segment(id) + "/domains/" + HiokClient.segment(domainId) + "/senders/" + HiokClient.segment(senderId), null, null);
    }

    /** Delete service. [DELETE /api/Communication/services/{id}] */
    public JsonNode deleteService(String id) {
        return c.send("DELETE", "/api/Communication/services/" + HiokClient.segment(id), null, null);
    }

    /** Get message. [GET /api/Communication/services/{id}/emails/{messageId}] */
    public JsonNode getMessage(String id, String messageId) {
        return c.send("GET", "/api/Communication/services/" + HiokClient.segment(id) + "/emails/" + HiokClient.segment(messageId), null, null);
    }

    /** Get service. [GET /api/Communication/services/{id}] */
    public JsonNode getService(String id) {
        return c.send("GET", "/api/Communication/services/" + HiokClient.segment(id), null, null);
    }

    /** List connectors. [GET /api/Communication/services/{id}/connectors] */
    public JsonNode listConnectors(String id) {
        return c.send("GET", "/api/Communication/services/" + HiokClient.segment(id) + "/connectors", null, null);
    }

    /** List domains. [GET /api/Communication/services/{id}/domains] */
    public JsonNode listDomains(String id) {
        return c.send("GET", "/api/Communication/services/" + HiokClient.segment(id) + "/domains", null, null);
    }

    /** List messages. [GET /api/Communication/services/{id}/emails] */
    public JsonNode listMessages(String id, Object limit) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("limit", limit);
        return c.send("GET", "/api/Communication/services/" + HiokClient.segment(id) + "/emails", null, query_);
    }
    public JsonNode listMessages(String id) {
        return listMessages(id, null);
    }

    /** List services. [GET /api/Communication/services] */
    public JsonNode listServices() {
        return c.send("GET", "/api/Communication/services", null, null);
    }

    /** Send email. [POST /api/Communication/services/{id}/emails] */
    public JsonNode sendEmail(String id, Object body) {
        return c.send("POST", "/api/Communication/services/" + HiokClient.segment(id) + "/emails", body, null);
    }

    /** Verify domain. [POST /api/Communication/services/{id}/domains/{domainId}/verify] */
    public JsonNode verifyDomain(String id, String domainId) {
        return c.send("POST", "/api/Communication/services/" + HiokClient.segment(id) + "/domains/" + HiokClient.segment(domainId) + "/verify", null, null);
    }
}
