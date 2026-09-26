// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package com.hiokcloud.api;

import com.hiokcloud.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** Containers operations. */
public final class ContainersApi {
    private final HiokClient c;
    public ContainersApi(HiokClient client) { this.c = client; }

    /** Build image. [POST /api/Containers/images/build] */
    public JsonNode buildImage(Object body) {
        return c.send("POST", "/api/Containers/images/build", body, null);
    }

    /** Create container. [POST /api/Containers/createcontainer] */
    public JsonNode createContainer(Object body) {
        return c.send("POST", "/api/Containers/createcontainer", body, null);
    }

    /** Create swarm service. [POST /api/Containers/swarm/services] */
    public JsonNode createSwarmService(Object body) {
        return c.send("POST", "/api/Containers/swarm/services", body, null);
    }

    /** Delete container. [POST /api/Containers/deletecontainer] */
    public JsonNode deleteContainer(Object body) {
        return c.send("POST", "/api/Containers/deletecontainer", body, null);
    }

    /** Exec. [POST /api/Containers/{containerName}/exec] */
    public JsonNode exec(String containerName, Object body) {
        return c.send("POST", "/api/Containers/" + HiokClient.segment(containerName) + "/exec", body, null);
    }

    /** Give public address. [POST /api/Containers/{name}/public-ip] */
    public JsonNode givePublicAddress(String name, Object region) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("region", region);
        return c.send("POST", "/api/Containers/" + HiokClient.segment(name) + "/public-ip", null, query_);
    }
    public JsonNode givePublicAddress(String name) {
        return givePublicAddress(name, null);
    }

    /** Inspect. [GET /api/Containers/{containerName}/inspect] */
    public JsonNode inspect(String containerName) {
        return c.send("GET", "/api/Containers/" + HiokClient.segment(containerName) + "/inspect", null, null);
    }

    /** List all containers. [POST /api/Containers/listallcontainers] */
    public JsonNode listAllContainers(Object body) {
        return c.send("POST", "/api/Containers/listallcontainers", body, null);
    }

    /** Logs. [GET /api/Containers/{containerName}/logs] */
    public JsonNode logs(String containerName, Object tail) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("tail", tail);
        return c.send("GET", "/api/Containers/" + HiokClient.segment(containerName) + "/logs", null, query_);
    }
    public JsonNode logs(String containerName) {
        return logs(containerName, null);
    }

    /** Release public address. [DELETE /api/Containers/{name}/public-ip] */
    public JsonNode releasePublicAddress(String name, Object region) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("region", region);
        return c.send("DELETE", "/api/Containers/" + HiokClient.segment(name) + "/public-ip", null, query_);
    }
    public JsonNode releasePublicAddress(String name) {
        return releasePublicAddress(name, null);
    }

    /** Remove swarm service. [DELETE /api/Containers/swarm/services/{name}] */
    public JsonNode removeSwarmService(String name, Object region) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("region", region);
        return c.send("DELETE", "/api/Containers/swarm/services/" + HiokClient.segment(name), null, query_);
    }
    public JsonNode removeSwarmService(String name) {
        return removeSwarmService(name, null);
    }

    /** Rename container. [POST /api/Containers/renamecontainer] */
    public JsonNode renameContainer(Object body) {
        return c.send("POST", "/api/Containers/renamecontainer", body, null);
    }

    /** Restart container. [POST /api/Containers/restartcontainer] */
    public JsonNode restartContainer(Object body) {
        return c.send("POST", "/api/Containers/restartcontainer", body, null);
    }

    /** Scale swarm service. [POST /api/Containers/swarm/services/{name}/scale] */
    public JsonNode scaleSwarmService(String name, Object replicas, Object region) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("replicas", replicas);
        query_.put("region", region);
        return c.send("POST", "/api/Containers/swarm/services/" + HiokClient.segment(name) + "/scale", null, query_);
    }
    public JsonNode scaleSwarmService(String name) {
        return scaleSwarmService(name, null, null);
    }

    /** Stack down. [POST /api/Containers/stacks/down] */
    public JsonNode stackDown(Object body) {
        return c.send("POST", "/api/Containers/stacks/down", body, null);
    }

    /** Stack file. [GET /api/Containers/stacks/{project}] */
    public JsonNode stackFile(String project, Object region) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("region", region);
        return c.send("GET", "/api/Containers/stacks/" + HiokClient.segment(project), null, query_);
    }
    public JsonNode stackFile(String project) {
        return stackFile(project, null);
    }

    /** Stack up. [POST /api/Containers/stacks/up] */
    public JsonNode stackUp(Object body) {
        return c.send("POST", "/api/Containers/stacks/up", body, null);
    }

    /** Start container. [POST /api/Containers/startcontainer] */
    public JsonNode startContainer(Object body) {
        return c.send("POST", "/api/Containers/startcontainer", body, null);
    }

    /** Stats. [GET /api/Containers/{containerName}/stats] */
    public JsonNode stats(String containerName) {
        return c.send("GET", "/api/Containers/" + HiokClient.segment(containerName) + "/stats", null, null);
    }

    /** Stop container. [POST /api/Containers/stopcontainer] */
    public JsonNode stopContainer(Object body) {
        return c.send("POST", "/api/Containers/stopcontainer", body, null);
    }

    /** Swarm init. [POST /api/Containers/swarm/init] */
    public JsonNode swarmInit(Object region) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("region", region);
        return c.send("POST", "/api/Containers/swarm/init", null, query_);
    }
    public JsonNode swarmInit() {
        return swarmInit(null);
    }

    /** Swarm leave. [POST /api/Containers/swarm/leave] */
    public JsonNode swarmLeave(Object region) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("region", region);
        return c.send("POST", "/api/Containers/swarm/leave", null, query_);
    }
    public JsonNode swarmLeave() {
        return swarmLeave(null);
    }

    /** Swarm nodes. [GET /api/Containers/swarm/nodes] */
    public JsonNode swarmNodes(Object region) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("region", region);
        return c.send("GET", "/api/Containers/swarm/nodes", null, query_);
    }
    public JsonNode swarmNodes() {
        return swarmNodes(null);
    }

    /** Swarm services. [GET /api/Containers/swarm/services] */
    public JsonNode swarmServices(Object region) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("region", region);
        return c.send("GET", "/api/Containers/swarm/services", null, query_);
    }
    public JsonNode swarmServices() {
        return swarmServices(null);
    }

    /** Swarm status. [GET /api/Containers/swarm] */
    public JsonNode swarmStatus(Object region) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("region", region);
        return c.send("GET", "/api/Containers/swarm", null, query_);
    }
    public JsonNode swarmStatus() {
        return swarmStatus(null);
    }

    /** Update container. [POST /api/Containers/updatecontainer] */
    public JsonNode updateContainer(Object body) {
        return c.send("POST", "/api/Containers/updatecontainer", body, null);
    }

    /** Volumes. [GET /api/Containers/volumes] */
    public JsonNode volumes(Object region) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("region", region);
        return c.send("GET", "/api/Containers/volumes", null, query_);
    }
    public JsonNode volumes() {
        return volumes(null);
    }
}
