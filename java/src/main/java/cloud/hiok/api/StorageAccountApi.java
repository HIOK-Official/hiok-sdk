// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package cloud.hiok.api;

import cloud.hiok.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** StorageAccount operations. */
public final class StorageAccountApi {
    private final HiokClient c;
    public StorageAccountApi(HiokClient client) { this.c = client; }

    /** Acquire lock. [POST /api/StorageAccount/items/{itemId}/lock] */
    public JsonNode acquireLock(String itemId, Object body) {
        return c.send("POST", "/api/StorageAccount/items/" + HiokClient.segment(itemId) + "/lock", body, null);
    }

    /** Add lifecycle rule. [POST /api/StorageAccount/{id}/lifecycle] */
    public JsonNode addLifecycleRule(String id, Object body) {
        return c.send("POST", "/api/StorageAccount/" + HiokClient.segment(id) + "/lifecycle", body, null);
    }

    /** Add role assignment. [POST /api/StorageAccount/{id}/iam] */
    public JsonNode addRoleAssignment(String id, Object body) {
        return c.send("POST", "/api/StorageAccount/" + HiokClient.segment(id) + "/iam", body, null);
    }

    /** Break lock. [POST /api/StorageAccount/items/{itemId}/lock/break] */
    public JsonNode breakLock(String itemId) {
        return c.send("POST", "/api/StorageAccount/items/" + HiokClient.segment(itemId) + "/lock/break", null, null);
    }

    /** Cancel operation. [POST /api/StorageAccount/operations/{operationId}/cancel] */
    public JsonNode cancelOperation(String operationId) {
        return c.send("POST", "/api/StorageAccount/operations/" + HiokClient.segment(operationId) + "/cancel", null, null);
    }

    /** Copy item. [POST /api/StorageAccount/items/copy] */
    public JsonNode copyItem(Object body) {
        return c.send("POST", "/api/StorageAccount/items/copy", body, null);
    }

    /** Create backup. [POST /api/StorageAccount/{id}/backups] */
    public JsonNode createBackup(String id, Object body) {
        return c.send("POST", "/api/StorageAccount/" + HiokClient.segment(id) + "/backups", body, null);
    }

    /** Create folder. [POST /api/StorageAccount/folders] */
    public JsonNode createFolder(Object body) {
        return c.send("POST", "/api/StorageAccount/folders", body, null);
    }

    /** Create queue. [POST /api/StorageAccount/{id}/queues] */
    public JsonNode createQueue(String id, Object body) {
        return c.send("POST", "/api/StorageAccount/" + HiokClient.segment(id) + "/queues", body, null);
    }

    /** Create storage account. [POST /api/StorageAccount] */
    public JsonNode createStorageAccount(Object body) {
        return c.send("POST", "/api/StorageAccount", body, null);
    }

    /** Create table. [POST /api/StorageAccount/{id}/tables] */
    public JsonNode createTable(String id, Object body) {
        return c.send("POST", "/api/StorageAccount/" + HiokClient.segment(id) + "/tables", body, null);
    }

    /** Create zip. [POST /api/StorageAccount/zip] */
    public JsonNode createZip(Object body) {
        return c.send("POST", "/api/StorageAccount/zip", body, null);
    }

    /** Delete backup. [DELETE /api/StorageAccount/{id}/backups/{backupId}] */
    public JsonNode deleteBackup(String id, String backupId) {
        return c.send("DELETE", "/api/StorageAccount/" + HiokClient.segment(id) + "/backups/" + HiokClient.segment(backupId), null, null);
    }

    /** Delete items. [POST /api/StorageAccount/items/delete] */
    public JsonNode deleteItems(Object body) {
        return c.send("POST", "/api/StorageAccount/items/delete", body, null);
    }

    /** Delete lifecycle rule. [DELETE /api/StorageAccount/{id}/lifecycle/{ruleId}] */
    public JsonNode deleteLifecycleRule(String id, String ruleId) {
        return c.send("DELETE", "/api/StorageAccount/" + HiokClient.segment(id) + "/lifecycle/" + HiokClient.segment(ruleId), null, null);
    }

    /** Delete queue. [DELETE /api/StorageAccount/{id}/queues/{queueName}] */
    public JsonNode deleteQueue(String id, String queueName) {
        return c.send("DELETE", "/api/StorageAccount/" + HiokClient.segment(id) + "/queues/" + HiokClient.segment(queueName), null, null);
    }

    /** Delete storage account. [DELETE /api/StorageAccount/{id}] */
    public JsonNode deleteStorageAccount(String id) {
        return c.send("DELETE", "/api/StorageAccount/" + HiokClient.segment(id), null, null);
    }

    /** Delete table. [DELETE /api/StorageAccount/{id}/tables/{tableName}] */
    public JsonNode deleteTable(String id, String tableName) {
        return c.send("DELETE", "/api/StorageAccount/" + HiokClient.segment(id) + "/tables/" + HiokClient.segment(tableName), null, null);
    }

    /** Download item content. [GET /api/StorageAccount/items/{itemId}/content] */
    public JsonNode downloadItemContent(String itemId, Object region) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("region", region);
        return c.send("GET", "/api/StorageAccount/items/" + HiokClient.segment(itemId) + "/content", null, query_);
    }
    public JsonNode downloadItemContent(String itemId) {
        return downloadItemContent(itemId, null);
    }

    /** Download zip. [POST /api/StorageAccount/zip/download] */
    public JsonNode downloadZip(Object body) {
        return c.send("POST", "/api/StorageAccount/zip/download", body, null);
    }

    /** Export activity log. [GET /api/StorageAccount/{id}/activity/export] */
    public JsonNode exportActivityLog(String id, Object format) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("format", format);
        return c.send("GET", "/api/StorageAccount/" + HiokClient.segment(id) + "/activity/export", null, query_);
    }
    public JsonNode exportActivityLog(String id) {
        return exportActivityLog(id, null);
    }

    /** Extract archive. [POST /api/StorageAccount/{id}/items/{itemId}/extract] */
    public JsonNode extractArchive(String id, String itemId, Object body) {
        return c.send("POST", "/api/StorageAccount/" + HiokClient.segment(id) + "/items/" + HiokClient.segment(itemId) + "/extract", body, null);
    }

    /** Finalize upload. [POST /api/StorageAccount/upload/{operationId}/finalize] */
    public JsonNode finalizeUpload(String operationId) {
        return c.send("POST", "/api/StorageAccount/upload/" + HiokClient.segment(operationId) + "/finalize", null, null);
    }

    /** Generate share link. [POST /api/StorageAccount/items/{itemId}/sharelink] */
    public JsonNode generateShareLink(String itemId, Object body) {
        return c.send("POST", "/api/StorageAccount/items/" + HiokClient.segment(itemId) + "/sharelink", body, null);
    }

    /** Get access keys. [GET /api/StorageAccount/{id}/keys] */
    public JsonNode getAccessKeys(String id) {
        return c.send("GET", "/api/StorageAccount/" + HiokClient.segment(id) + "/keys", null, null);
    }

    /** Get active operations. [GET /api/StorageAccount/{id}/operations] */
    public JsonNode getActiveOperations(String id) {
        return c.send("GET", "/api/StorageAccount/" + HiokClient.segment(id) + "/operations", null, null);
    }

    /** Get activity log. [GET /api/StorageAccount/{id}/activity] */
    public JsonNode getActivityLog(String id, Object limit) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("limit", limit);
        return c.send("GET", "/api/StorageAccount/" + HiokClient.segment(id) + "/activity", null, query_);
    }
    public JsonNode getActivityLog(String id) {
        return getActivityLog(id, null);
    }

    /** Get available regions. [GET /api/StorageAccount/regions] */
    public JsonNode getAvailableRegions() {
        return c.send("GET", "/api/StorageAccount/regions", null, null);
    }

    /** Get backups. [GET /api/StorageAccount/{id}/backups] */
    public JsonNode getBackups(String id) {
        return c.send("GET", "/api/StorageAccount/" + HiokClient.segment(id) + "/backups", null, null);
    }

    /** Get default storage account. [GET /api/StorageAccount/default] */
    public JsonNode getDefaultStorageAccount() {
        return c.send("GET", "/api/StorageAccount/default", null, null);
    }

    /** Get file preview. [GET /api/StorageAccount/items/{itemId}/preview] */
    public JsonNode getFilePreview(String itemId) {
        return c.send("GET", "/api/StorageAccount/items/" + HiokClient.segment(itemId) + "/preview", null, null);
    }

    /** Get item. [GET /api/StorageAccount/items/{itemId}] */
    public JsonNode getItem(String itemId) {
        return c.send("GET", "/api/StorageAccount/items/" + HiokClient.segment(itemId), null, null);
    }

    /** Get item activity log. [GET /api/StorageAccount/items/{itemId}/activity] */
    public JsonNode getItemActivityLog(String itemId, Object limit) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("limit", limit);
        return c.send("GET", "/api/StorageAccount/items/" + HiokClient.segment(itemId) + "/activity", null, query_);
    }
    public JsonNode getItemActivityLog(String itemId) {
        return getItemActivityLog(itemId, null);
    }

    /** Get item metadata. [GET /api/StorageAccount/items/{itemId}/metadata] */
    public JsonNode getItemMetadata(String itemId) {
        return c.send("GET", "/api/StorageAccount/items/" + HiokClient.segment(itemId) + "/metadata", null, null);
    }

    /** Get item shares. [GET /api/StorageAccount/items/{itemId}/shares] */
    public JsonNode getItemShares(String itemId) {
        return c.send("GET", "/api/StorageAccount/items/" + HiokClient.segment(itemId) + "/shares", null, null);
    }

    /** Get lifecycle rules. [GET /api/StorageAccount/{id}/lifecycle] */
    public JsonNode getLifecycleRules(String id) {
        return c.send("GET", "/api/StorageAccount/" + HiokClient.segment(id) + "/lifecycle", null, null);
    }

    /** Get networking. [GET /api/StorageAccount/{id}/networking] */
    public JsonNode getNetworking(String id) {
        return c.send("GET", "/api/StorageAccount/" + HiokClient.segment(id) + "/networking", null, null);
    }

    /** Get operation status. [GET /api/StorageAccount/operations/{operationId}] */
    public JsonNode getOperationStatus(String operationId) {
        return c.send("GET", "/api/StorageAccount/operations/" + HiokClient.segment(operationId), null, null);
    }

    /** Get replication status. [GET /api/StorageAccount/{id}/replication] */
    public JsonNode getReplicationStatus(String id) {
        return c.send("GET", "/api/StorageAccount/" + HiokClient.segment(id) + "/replication", null, null);
    }

    /** Get role assignments. [GET /api/StorageAccount/{id}/iam] */
    public JsonNode getRoleAssignments(String id) {
        return c.send("GET", "/api/StorageAccount/" + HiokClient.segment(id) + "/iam", null, null);
    }

    /** Get role definitions. [GET /api/StorageAccount/role-definitions] */
    public JsonNode getRoleDefinitions() {
        return c.send("GET", "/api/StorageAccount/role-definitions", null, null);
    }

    /** Get storage account. [GET /api/StorageAccount/{id}] */
    public JsonNode getStorageAccount(String id) {
        return c.send("GET", "/api/StorageAccount/" + HiokClient.segment(id), null, null);
    }

    /** Get storage accounts. [GET /api/StorageAccount] */
    public JsonNode getStorageAccounts() {
        return c.send("GET", "/api/StorageAccount", null, null);
    }

    /** Get storage stats. [GET /api/StorageAccount/stats] */
    public JsonNode getStorageStats() {
        return c.send("GET", "/api/StorageAccount/stats", null, null);
    }

    /** Get version history. [GET /api/StorageAccount/items/{itemId}/versions] */
    public JsonNode getVersionHistory(String itemId) {
        return c.send("GET", "/api/StorageAccount/items/" + HiokClient.segment(itemId) + "/versions", null, null);
    }

    /** Initiate download. [POST /api/StorageAccount/download] */
    public JsonNode initiateDownload(Object body) {
        return c.send("POST", "/api/StorageAccount/download", body, null);
    }

    /** Initiate upload. [POST /api/StorageAccount/upload] */
    public JsonNode initiateUpload(Object body) {
        return c.send("POST", "/api/StorageAccount/upload", body, null);
    }

    /** List items. [GET /api/StorageAccount/{id}/items] */
    public JsonNode listItems(String id, Object path, Object parentId, Object storageNamespace) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("path", path);
        query_.put("parentId", parentId);
        query_.put("storageNamespace", storageNamespace);
        return c.send("GET", "/api/StorageAccount/" + HiokClient.segment(id) + "/items", null, query_);
    }
    public JsonNode listItems(String id) {
        return listItems(id, null, null, null);
    }

    /** List queues. [GET /api/StorageAccount/{id}/queues] */
    public JsonNode listQueues(String id) {
        return c.send("GET", "/api/StorageAccount/" + HiokClient.segment(id) + "/queues", null, null);
    }

    /** List tables. [GET /api/StorageAccount/{id}/tables] */
    public JsonNode listTables(String id) {
        return c.send("GET", "/api/StorageAccount/" + HiokClient.segment(id) + "/tables", null, null);
    }

    /** Move item. [PUT /api/StorageAccount/items/move] */
    public JsonNode moveItem(Object body) {
        return c.send("PUT", "/api/StorageAccount/items/move", body, null);
    }

    /** Regenerate access key. [POST /api/StorageAccount/{id}/keys/{keyNumber}/regenerate] */
    public JsonNode regenerateAccessKey(String id, String keyNumber, Object body) {
        return c.send("POST", "/api/StorageAccount/" + HiokClient.segment(id) + "/keys/" + HiokClient.segment(keyNumber) + "/regenerate", body, null);
    }

    /** Release lock. [DELETE /api/StorageAccount/items/{itemId}/lock] */
    public JsonNode releaseLock(String itemId) {
        return c.send("DELETE", "/api/StorageAccount/items/" + HiokClient.segment(itemId) + "/lock", null, null);
    }

    /** Remove role assignment. [DELETE /api/StorageAccount/{id}/iam/{assignmentId}] */
    public JsonNode removeRoleAssignment(String id, String assignmentId, Object principalEmail, Object role) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("principalEmail", principalEmail);
        query_.put("role", role);
        return c.send("DELETE", "/api/StorageAccount/" + HiokClient.segment(id) + "/iam/" + HiokClient.segment(assignmentId), null, query_);
    }
    public JsonNode removeRoleAssignment(String id, String assignmentId) {
        return removeRoleAssignment(id, assignmentId, null, null);
    }

    /** Remove share. [DELETE /api/StorageAccount/shares/{shareId}] */
    public JsonNode removeShare(String shareId) {
        return c.send("DELETE", "/api/StorageAccount/shares/" + HiokClient.segment(shareId), null, null);
    }

    /** Rename item. [PUT /api/StorageAccount/items/rename] */
    public JsonNode renameItem(Object body) {
        return c.send("PUT", "/api/StorageAccount/items/rename", body, null);
    }

    /** Restore backup. [POST /api/StorageAccount/{id}/backups/{backupId}/restore] */
    public JsonNode restoreBackup(String id, String backupId) {
        return c.send("POST", "/api/StorageAccount/" + HiokClient.segment(id) + "/backups/" + HiokClient.segment(backupId) + "/restore", null, null);
    }

    /** Restore version. [POST /api/StorageAccount/items/versions/restore] */
    public JsonNode restoreVersion(Object body) {
        return c.send("POST", "/api/StorageAccount/items/versions/restore", body, null);
    }

    /** Run lifecycle rules. [POST /api/StorageAccount/{id}/lifecycle/run] */
    public JsonNode runLifecycleRules(String id) {
        return c.send("POST", "/api/StorageAccount/" + HiokClient.segment(id) + "/lifecycle/run", null, null);
    }

    /** Save item content. [PUT /api/StorageAccount/items/{itemId}/content] */
    public JsonNode saveItemContent(String itemId, Object body) {
        return c.send("PUT", "/api/StorageAccount/items/" + HiokClient.segment(itemId) + "/content", body, null);
    }

    /** Search items. [GET /api/StorageAccount/{id}/items/search] */
    public JsonNode searchItems(String id, Object q) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("q", q);
        return c.send("GET", "/api/StorageAccount/" + HiokClient.segment(id) + "/items/search", null, query_);
    }
    public JsonNode searchItems(String id) {
        return searchItems(id, null);
    }

    /** Set default storage account. [PUT /api/StorageAccount/{id}/default] */
    public JsonNode setDefaultStorageAccount(String id) {
        return c.send("PUT", "/api/StorageAccount/" + HiokClient.segment(id) + "/default", null, null);
    }

    /** Share item. [POST /api/StorageAccount/items/share] */
    public JsonNode shareItem(Object body) {
        return c.send("POST", "/api/StorageAccount/items/share", body, null);
    }

    /** Update networking. [PUT /api/StorageAccount/{id}/networking] */
    public JsonNode updateNetworking(String id, Object body) {
        return c.send("PUT", "/api/StorageAccount/" + HiokClient.segment(id) + "/networking", body, null);
    }

    /** Update storage account. [PUT /api/StorageAccount/{id}] */
    public JsonNode updateStorageAccount(String id, Object body) {
        return c.send("PUT", "/api/StorageAccount/" + HiokClient.segment(id), body, null);
    }

    /** Upload chunk. [POST /api/StorageAccount/upload/{operationId}/chunk] */
    public JsonNode uploadChunk(String operationId, Map<String, String> form, Map<String, HiokClient.FilePart> files) {
        return c.sendMultipart("POST", "/api/StorageAccount/upload/" + HiokClient.segment(operationId) + "/chunk", form, files, null);
    }
}
