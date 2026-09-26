// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package cloud.hiok.api;

import cloud.hiok.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** StorageData operations. */
public final class StorageDataApi {
    private final HiokClient c;
    public StorageDataApi(HiokClient client) { this.c = client; }

    /** Clear queue. [DELETE /api/storageaccount/{accountId}/queues/{queueName}/messages] */
    public JsonNode clearQueue(String accountId, String queueName) {
        return c.send("DELETE", "/api/storageaccount/" + HiokClient.segment(accountId) + "/queues/" + HiokClient.segment(queueName) + "/messages", null, null);
    }

    /** Delete entity. [DELETE /api/storageaccount/{accountId}/tables/{tableName}/entities/{partitionKey}/{rowKey}] */
    public JsonNode deleteEntity(String accountId, String tableName, String partitionKey, String rowKey, Object ifMatch) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("ifMatch", ifMatch);
        return c.send("DELETE", "/api/storageaccount/" + HiokClient.segment(accountId) + "/tables/" + HiokClient.segment(tableName) + "/entities/" + HiokClient.segment(partitionKey) + "/" + HiokClient.segment(rowKey), null, query_);
    }
    public JsonNode deleteEntity(String accountId, String tableName, String partitionKey, String rowKey) {
        return deleteEntity(accountId, tableName, partitionKey, rowKey, null);
    }

    /** Delete message. [DELETE /api/storageaccount/{accountId}/queues/{queueName}/messages/{messageId}] */
    public JsonNode deleteMessage(String accountId, String queueName, String messageId, Object popReceipt) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("popReceipt", popReceipt);
        return c.send("DELETE", "/api/storageaccount/" + HiokClient.segment(accountId) + "/queues/" + HiokClient.segment(queueName) + "/messages/" + HiokClient.segment(messageId), null, query_);
    }
    public JsonNode deleteMessage(String accountId, String queueName, String messageId) {
        return deleteMessage(accountId, queueName, messageId, null);
    }

    /** Get entity. [GET /api/storageaccount/{accountId}/tables/{tableName}/entities/{partitionKey}/{rowKey}] */
    public JsonNode getEntity(String accountId, String tableName, String partitionKey, String rowKey) {
        return c.send("GET", "/api/storageaccount/" + HiokClient.segment(accountId) + "/tables/" + HiokClient.segment(tableName) + "/entities/" + HiokClient.segment(partitionKey) + "/" + HiokClient.segment(rowKey), null, null);
    }

    /** Insert entity. [POST /api/storageaccount/{accountId}/tables/{tableName}/entities] */
    public JsonNode insertEntity(String accountId, String tableName, Object body) {
        return c.send("POST", "/api/storageaccount/" + HiokClient.segment(accountId) + "/tables/" + HiokClient.segment(tableName) + "/entities", body, null);
    }

    /** Peek messages. [GET /api/storageaccount/{accountId}/queues/{queueName}/messages] */
    public JsonNode peekMessages(String accountId, String queueName, Object max) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("max", max);
        return c.send("GET", "/api/storageaccount/" + HiokClient.segment(accountId) + "/queues/" + HiokClient.segment(queueName) + "/messages", null, query_);
    }
    public JsonNode peekMessages(String accountId, String queueName) {
        return peekMessages(accountId, queueName, null);
    }

    /** Query entities. [GET /api/storageaccount/{accountId}/tables/{tableName}/entities] */
    public JsonNode queryEntities(String accountId, String tableName, Object partitionKey, Object propertyName, Object propertyValue, Object take, Object continuationRowKey) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("partitionKey", partitionKey);
        query_.put("propertyName", propertyName);
        query_.put("propertyValue", propertyValue);
        query_.put("take", take);
        query_.put("continuationRowKey", continuationRowKey);
        return c.send("GET", "/api/storageaccount/" + HiokClient.segment(accountId) + "/tables/" + HiokClient.segment(tableName) + "/entities", null, query_);
    }
    public JsonNode queryEntities(String accountId, String tableName) {
        return queryEntities(accountId, tableName, null, null, null, null, null);
    }

    /** Queue stats. [GET /api/storageaccount/{accountId}/queues/{queueName}/stats] */
    public JsonNode queueStats(String accountId, String queueName) {
        return c.send("GET", "/api/storageaccount/" + HiokClient.segment(accountId) + "/queues/" + HiokClient.segment(queueName) + "/stats", null, null);
    }

    /** Receive messages. [POST /api/storageaccount/{accountId}/queues/{queueName}/messages/receive] */
    public JsonNode receiveMessages(String accountId, String queueName, Object body) {
        return c.send("POST", "/api/storageaccount/" + HiokClient.segment(accountId) + "/queues/" + HiokClient.segment(queueName) + "/messages/receive", body, null);
    }

    /** Send message. [POST /api/storageaccount/{accountId}/queues/{queueName}/messages] */
    public JsonNode sendMessage(String accountId, String queueName, Object body) {
        return c.send("POST", "/api/storageaccount/" + HiokClient.segment(accountId) + "/queues/" + HiokClient.segment(queueName) + "/messages", body, null);
    }

    /** Update visibility. [POST /api/storageaccount/{accountId}/queues/{queueName}/messages/{messageId}/visibility] */
    public JsonNode updateVisibility(String accountId, String queueName, String messageId, Object popReceipt, Object visibilityTimeoutSeconds) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("popReceipt", popReceipt);
        query_.put("visibilityTimeoutSeconds", visibilityTimeoutSeconds);
        return c.send("POST", "/api/storageaccount/" + HiokClient.segment(accountId) + "/queues/" + HiokClient.segment(queueName) + "/messages/" + HiokClient.segment(messageId) + "/visibility", null, query_);
    }
    public JsonNode updateVisibility(String accountId, String queueName, String messageId) {
        return updateVisibility(accountId, queueName, messageId, null, null);
    }

    /** Upsert entity. [PUT /api/storageaccount/{accountId}/tables/{tableName}/entities] */
    public JsonNode upsertEntity(String accountId, String tableName, Object body) {
        return c.send("PUT", "/api/storageaccount/" + HiokClient.segment(accountId) + "/tables/" + HiokClient.segment(tableName) + "/entities", body, null);
    }
}
