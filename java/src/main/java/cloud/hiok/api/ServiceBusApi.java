// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package cloud.hiok.api;

import cloud.hiok.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** ServiceBus operations. */
public final class ServiceBusApi {
    private final HiokClient c;
    public ServiceBusApi(HiokClient client) { this.c = client; }

    /** Create namespace. [POST /api/ServiceBus/namespaces] */
    public JsonNode createNamespace(Object body) {
        return c.send("POST", "/api/ServiceBus/namespaces", body, null);
    }

    /** Create queue. [POST /api/ServiceBus/namespaces/{id}/queues] */
    public JsonNode createQueue(String id, Object body) {
        return c.send("POST", "/api/ServiceBus/namespaces/" + HiokClient.segment(id) + "/queues", body, null);
    }

    /** Create rule. [POST /api/ServiceBus/namespaces/{id}/topics/{topicName}/subscriptions/{subscriptionName}/rules] */
    public JsonNode createRule(String id, String topicName, String subscriptionName, Object body) {
        return c.send("POST", "/api/ServiceBus/namespaces/" + HiokClient.segment(id) + "/topics/" + HiokClient.segment(topicName) + "/subscriptions/" + HiokClient.segment(subscriptionName) + "/rules", body, null);
    }

    /** Create subscription. [POST /api/ServiceBus/namespaces/{id}/topics/{topicName}/subscriptions] */
    public JsonNode createSubscription(String id, String topicName, Object body) {
        return c.send("POST", "/api/ServiceBus/namespaces/" + HiokClient.segment(id) + "/topics/" + HiokClient.segment(topicName) + "/subscriptions", body, null);
    }

    /** Create topic. [POST /api/ServiceBus/namespaces/{id}/topics] */
    public JsonNode createTopic(String id, Object body) {
        return c.send("POST", "/api/ServiceBus/namespaces/" + HiokClient.segment(id) + "/topics", body, null);
    }

    /** Delete namespace. [DELETE /api/ServiceBus/namespaces/{id}] */
    public JsonNode deleteNamespace(String id) {
        return c.send("DELETE", "/api/ServiceBus/namespaces/" + HiokClient.segment(id), null, null);
    }

    /** Delete queue. [DELETE /api/ServiceBus/namespaces/{id}/queues/{name}] */
    public JsonNode deleteQueue(String id, String name) {
        return c.send("DELETE", "/api/ServiceBus/namespaces/" + HiokClient.segment(id) + "/queues/" + HiokClient.segment(name), null, null);
    }

    /** Delete rule. [DELETE /api/ServiceBus/namespaces/{id}/topics/{topicName}/subscriptions/{subscriptionName}/rules/{ruleName}] */
    public JsonNode deleteRule(String id, String topicName, String subscriptionName, String ruleName) {
        return c.send("DELETE", "/api/ServiceBus/namespaces/" + HiokClient.segment(id) + "/topics/" + HiokClient.segment(topicName) + "/subscriptions/" + HiokClient.segment(subscriptionName) + "/rules/" + HiokClient.segment(ruleName), null, null);
    }

    /** Delete subscription. [DELETE /api/ServiceBus/namespaces/{id}/topics/{topicName}/subscriptions/{subscriptionName}] */
    public JsonNode deleteSubscription(String id, String topicName, String subscriptionName) {
        return c.send("DELETE", "/api/ServiceBus/namespaces/" + HiokClient.segment(id) + "/topics/" + HiokClient.segment(topicName) + "/subscriptions/" + HiokClient.segment(subscriptionName), null, null);
    }

    /** Delete topic. [DELETE /api/ServiceBus/namespaces/{id}/topics/{name}] */
    public JsonNode deleteTopic(String id, String name) {
        return c.send("DELETE", "/api/ServiceBus/namespaces/" + HiokClient.segment(id) + "/topics/" + HiokClient.segment(name), null, null);
    }

    /** Get keys. [GET /api/ServiceBus/namespaces/{id}/keys] */
    public JsonNode getKeys(String id) {
        return c.send("GET", "/api/ServiceBus/namespaces/" + HiokClient.segment(id) + "/keys", null, null);
    }

    /** Get namespace. [GET /api/ServiceBus/namespaces/{id}] */
    public JsonNode getNamespace(String id) {
        return c.send("GET", "/api/ServiceBus/namespaces/" + HiokClient.segment(id), null, null);
    }

    /** Get queue. [GET /api/ServiceBus/namespaces/{id}/queues/{name}] */
    public JsonNode getQueue(String id, String name) {
        return c.send("GET", "/api/ServiceBus/namespaces/" + HiokClient.segment(id) + "/queues/" + HiokClient.segment(name), null, null);
    }

    /** List namespaces. [GET /api/ServiceBus/namespaces] */
    public JsonNode listNamespaces(Object product) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("product", product);
        return c.send("GET", "/api/ServiceBus/namespaces", null, query_);
    }
    public JsonNode listNamespaces() {
        return listNamespaces(null);
    }

    /** List queues. [GET /api/ServiceBus/namespaces/{id}/queues] */
    public JsonNode listQueues(String id) {
        return c.send("GET", "/api/ServiceBus/namespaces/" + HiokClient.segment(id) + "/queues", null, null);
    }

    /** List rules. [GET /api/ServiceBus/namespaces/{id}/topics/{topicName}/subscriptions/{subscriptionName}/rules] */
    public JsonNode listRules(String id, String topicName, String subscriptionName) {
        return c.send("GET", "/api/ServiceBus/namespaces/" + HiokClient.segment(id) + "/topics/" + HiokClient.segment(topicName) + "/subscriptions/" + HiokClient.segment(subscriptionName) + "/rules", null, null);
    }

    /** List subscriptions. [GET /api/ServiceBus/namespaces/{id}/topics/{topicName}/subscriptions] */
    public JsonNode listSubscriptions(String id, String topicName) {
        return c.send("GET", "/api/ServiceBus/namespaces/" + HiokClient.segment(id) + "/topics/" + HiokClient.segment(topicName) + "/subscriptions", null, null);
    }

    /** List topics. [GET /api/ServiceBus/namespaces/{id}/topics] */
    public JsonNode listTopics(String id) {
        return c.send("GET", "/api/ServiceBus/namespaces/" + HiokClient.segment(id) + "/topics", null, null);
    }

    /** Peek. [POST /api/ServiceBus/namespaces/{id}/entities/{entity}/messages/peek] */
    public JsonNode peek(String id, String entity, Object subscription, Object maxMessages) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("subscription", subscription);
        query_.put("maxMessages", maxMessages);
        return c.send("POST", "/api/ServiceBus/namespaces/" + HiokClient.segment(id) + "/entities/" + HiokClient.segment(entity) + "/messages/peek", null, query_);
    }
    public JsonNode peek(String id, String entity) {
        return peek(id, entity, null, null);
    }

    /** Receive. [POST /api/ServiceBus/namespaces/{id}/entities/{entity}/messages/receive] */
    public JsonNode receive(String id, String entity, Object body, Object subscription) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("subscription", subscription);
        return c.send("POST", "/api/ServiceBus/namespaces/" + HiokClient.segment(id) + "/entities/" + HiokClient.segment(entity) + "/messages/receive", body, query_);
    }
    public JsonNode receive(String id, String entity, Object body) {
        return receive(id, entity, body, null);
    }

    /** Receive dead letter. [POST /api/ServiceBus/namespaces/{id}/entities/{entity}/deadletter/receive] */
    public JsonNode receiveDeadLetter(String id, String entity, Object subscription, Object maxMessages) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("subscription", subscription);
        query_.put("maxMessages", maxMessages);
        return c.send("POST", "/api/ServiceBus/namespaces/" + HiokClient.segment(id) + "/entities/" + HiokClient.segment(entity) + "/deadletter/receive", null, query_);
    }
    public JsonNode receiveDeadLetter(String id, String entity) {
        return receiveDeadLetter(id, entity, null, null);
    }

    /** Regenerate key. [POST /api/ServiceBus/namespaces/{id}/keys/{keyName}/regenerate] */
    public JsonNode regenerateKey(String id, String keyName, Object primary) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("primary", primary);
        return c.send("POST", "/api/ServiceBus/namespaces/" + HiokClient.segment(id) + "/keys/" + HiokClient.segment(keyName) + "/regenerate", null, query_);
    }
    public JsonNode regenerateKey(String id, String keyName) {
        return regenerateKey(id, keyName, null);
    }

    /** Runtime. [GET /api/ServiceBus/namespaces/{id}/entities/{entity}/runtime] */
    public JsonNode runtime(String id, String entity, Object subscription) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("subscription", subscription);
        return c.send("GET", "/api/ServiceBus/namespaces/" + HiokClient.segment(id) + "/entities/" + HiokClient.segment(entity) + "/runtime", null, query_);
    }
    public JsonNode runtime(String id, String entity) {
        return runtime(id, entity, null);
    }

    /** Send. [POST /api/ServiceBus/namespaces/{id}/entities/{entity}/messages] */
    public JsonNode send(String id, String entity, Object body) {
        return c.send("POST", "/api/ServiceBus/namespaces/" + HiokClient.segment(id) + "/entities/" + HiokClient.segment(entity) + "/messages", body, null);
    }

    /** Settle. [POST /api/ServiceBus/namespaces/{id}/entities/{entity}/messages/settle] */
    public JsonNode settle(String id, String entity, Object body, Object subscription) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("subscription", subscription);
        return c.send("POST", "/api/ServiceBus/namespaces/" + HiokClient.segment(id) + "/entities/" + HiokClient.segment(entity) + "/messages/settle", body, query_);
    }
    public JsonNode settle(String id, String entity, Object body) {
        return settle(id, entity, body, null);
    }

    /** Update queue. [PUT /api/ServiceBus/namespaces/{id}/queues/{name}] */
    public JsonNode updateQueue(String id, String name, Object body) {
        return c.send("PUT", "/api/ServiceBus/namespaces/" + HiokClient.segment(id) + "/queues/" + HiokClient.segment(name), body, null);
    }
}
