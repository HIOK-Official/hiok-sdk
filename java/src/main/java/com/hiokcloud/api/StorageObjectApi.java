// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package com.hiokcloud.api;

import com.hiokcloud.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** StorageObject operations. */
public final class StorageObjectApi {
    private final HiokClient c;
    public StorageObjectApi(HiokClient client) { this.c = client; }

    /** Commit block list. [POST /api/storageaccount/{accountId}/containers/{container}/blocks/commit] */
    public JsonNode commitBlockList(String accountId, String container, Object body) {
        return c.send("POST", "/api/storageaccount/" + HiokClient.segment(accountId) + "/containers/" + HiokClient.segment(container) + "/blocks/commit", body, null);
    }

    /** Create container. [POST /api/storageaccount/{accountId}/containers] */
    public JsonNode createContainer(String accountId, Object body) {
        return c.send("POST", "/api/storageaccount/" + HiokClient.segment(accountId) + "/containers", body, null);
    }

    /** Create directory. [POST /api/storageaccount/{accountId}/containers/{container}/directories] */
    public JsonNode createDirectory(String accountId, String container, Object body) {
        return c.send("POST", "/api/storageaccount/" + HiokClient.segment(accountId) + "/containers/" + HiokClient.segment(container) + "/directories", body, null);
    }

    /** Create file share. [POST /api/storageaccount/{accountId}/fileshares] */
    public JsonNode createFileShare(String accountId, Object body) {
        return c.send("POST", "/api/storageaccount/" + HiokClient.segment(accountId) + "/fileshares", body, null);
    }

    /** Delete container. [DELETE /api/storageaccount/{accountId}/containers/{name}] */
    public JsonNode deleteContainer(String accountId, String name, Object force) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("force", force);
        return c.send("DELETE", "/api/storageaccount/" + HiokClient.segment(accountId) + "/containers/" + HiokClient.segment(name), null, query_);
    }
    public JsonNode deleteContainer(String accountId, String name) {
        return deleteContainer(accountId, name, null);
    }

    /** Delete file share. [DELETE /api/storageaccount/{accountId}/fileshares/{name}] */
    public JsonNode deleteFileShare(String accountId, String name, Object force) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("force", force);
        return c.send("DELETE", "/api/storageaccount/" + HiokClient.segment(accountId) + "/fileshares/" + HiokClient.segment(name), null, query_);
    }
    public JsonNode deleteFileShare(String accountId, String name) {
        return deleteFileShare(accountId, name, null);
    }

    /** Delete object. [DELETE /api/storageaccount/{accountId}/containers/{container}/objects/{key}] */
    public JsonNode deleteObject(String accountId, String container, String key) {
        return c.send("DELETE", "/api/storageaccount/" + HiokClient.segment(accountId) + "/containers/" + HiokClient.segment(container) + "/objects/" + HiokClient.segment(key, true), null, null);
    }

    /** Get block list. [GET /api/storageaccount/{accountId}/containers/{container}/blocks] */
    public JsonNode getBlockList(String accountId, String container, Object blobName) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("blobName", blobName);
        return c.send("GET", "/api/storageaccount/" + HiokClient.segment(accountId) + "/containers/" + HiokClient.segment(container) + "/blocks", null, query_);
    }
    public JsonNode getBlockList(String accountId, String container) {
        return getBlockList(accountId, container, null);
    }

    /** Get container. [GET /api/storageaccount/{accountId}/containers/{name}] */
    public JsonNode getContainer(String accountId, String name) {
        return c.send("GET", "/api/storageaccount/" + HiokClient.segment(accountId) + "/containers/" + HiokClient.segment(name), null, null);
    }

    /** Get object. [GET /api/storageaccount/{accountId}/containers/{container}/objects/{key}] */
    public JsonNode getObject(String accountId, String container, String key) {
        return c.send("GET", "/api/storageaccount/" + HiokClient.segment(accountId) + "/containers/" + HiokClient.segment(container) + "/objects/" + HiokClient.segment(key, true), null, null);
    }

    /** Get object content. [GET /api/storageaccount/{accountId}/containers/{container}/content/{key}] */
    public JsonNode getObjectContent(String accountId, String container, String key) {
        return c.send("GET", "/api/storageaccount/" + HiokClient.segment(accountId) + "/containers/" + HiokClient.segment(container) + "/content/" + HiokClient.segment(key, true), null, null);
    }

    /** Get replication status. [GET /api/storageaccount/{accountId}/replication-status] */
    public JsonNode getReplicationStatus(String accountId) {
        return c.send("GET", "/api/storageaccount/" + HiokClient.segment(accountId) + "/replication-status", null, null);
    }

    /** List containers. [GET /api/storageaccount/{accountId}/containers] */
    public JsonNode listContainers(String accountId, Object kind) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("kind", kind);
        return c.send("GET", "/api/storageaccount/" + HiokClient.segment(accountId) + "/containers", null, query_);
    }
    public JsonNode listContainers(String accountId) {
        return listContainers(accountId, null);
    }

    /** List file shares. [GET /api/storageaccount/{accountId}/fileshares] */
    public JsonNode listFileShares(String accountId) {
        return c.send("GET", "/api/storageaccount/" + HiokClient.segment(accountId) + "/fileshares", null, null);
    }

    /** List objects. [GET /api/storageaccount/{accountId}/containers/{container}/objects] */
    public JsonNode listObjects(String accountId, String container, Object prefix, Object path, Object limit) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("prefix", prefix);
        query_.put("path", path);
        query_.put("limit", limit);
        return c.send("GET", "/api/storageaccount/" + HiokClient.segment(accountId) + "/containers/" + HiokClient.segment(container) + "/objects", null, query_);
    }
    public JsonNode listObjects(String accountId, String container) {
        return listObjects(accountId, container, null, null, null);
    }

    /** Put object. [PUT /api/storageaccount/{accountId}/containers/{container}/objects] */
    public JsonNode putObject(String accountId, String container, Object body) {
        return c.send("PUT", "/api/storageaccount/" + HiokClient.segment(accountId) + "/containers/" + HiokClient.segment(container) + "/objects", body, null);
    }

    /** Reconcile. [POST /api/storageaccount/{accountId}/replication-status/reconcile] */
    public JsonNode reconcile(String accountId) {
        return c.send("POST", "/api/storageaccount/" + HiokClient.segment(accountId) + "/replication-status/reconcile", null, null);
    }

    /** Rename path. [POST /api/storageaccount/{accountId}/containers/{container}/rename] */
    public JsonNode renamePath(String accountId, String container, Object body) {
        return c.send("POST", "/api/storageaccount/" + HiokClient.segment(accountId) + "/containers/" + HiokClient.segment(container) + "/rename", body, null);
    }

    /** Set access control. [PUT /api/storageaccount/{accountId}/containers/{container}/access-control] */
    public JsonNode setAccessControl(String accountId, String container, Object body) {
        return c.send("PUT", "/api/storageaccount/" + HiokClient.segment(accountId) + "/containers/" + HiokClient.segment(container) + "/access-control", body, null);
    }

    /** Stage block. [PUT /api/storageaccount/{accountId}/containers/{container}/blocks] */
    public JsonNode stageBlock(String accountId, String container, Object body) {
        return c.send("PUT", "/api/storageaccount/" + HiokClient.segment(accountId) + "/containers/" + HiokClient.segment(container) + "/blocks", body, null);
    }

    /** Update container. [PUT /api/storageaccount/{accountId}/containers/{name}] */
    public JsonNode updateContainer(String accountId, String name, Object body) {
        return c.send("PUT", "/api/storageaccount/" + HiokClient.segment(accountId) + "/containers/" + HiokClient.segment(name), body, null);
    }
}
