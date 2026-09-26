// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package com.hiokcloud.api;

import com.hiokcloud.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** Kubernetes operations. */
public final class KubernetesApi {
    private final HiokClient c;
    public KubernetesApi(HiokClient client) { this.c = client; }

    /** Add pool. [POST /api/kubernetes/clusters/{id}/node-pools] */
    public JsonNode addPool(String id, Object body) {
        return c.send("POST", "/api/kubernetes/clusters/" + HiokClient.segment(id) + "/node-pools", body, null);
    }

    /** Cordon. [POST /api/kubernetes/clusters/{id}/nodes/{name}/cordon] */
    public JsonNode cordon(String id, String name, Object undo) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("undo", undo);
        return c.send("POST", "/api/kubernetes/clusters/" + HiokClient.segment(id) + "/nodes/" + HiokClient.segment(name) + "/cordon", null, query_);
    }
    public JsonNode cordon(String id, String name) {
        return cordon(id, name, null);
    }

    /** Create. [POST /api/kubernetes/clusters] */
    public JsonNode create(Object body) {
        return c.send("POST", "/api/kubernetes/clusters", body, null);
    }

    /** Delete. [DELETE /api/kubernetes/clusters/{id}] */
    public JsonNode delete(String id) {
        return c.send("DELETE", "/api/kubernetes/clusters/" + HiokClient.segment(id), null, null);
    }

    /** Delete pod. [DELETE /api/kubernetes/clusters/{id}/pods/{ns}/{name}] */
    public JsonNode deletePod(String id, String ns, String name) {
        return c.send("DELETE", "/api/kubernetes/clusters/" + HiokClient.segment(id) + "/pods/" + HiokClient.segment(ns) + "/" + HiokClient.segment(name), null, null);
    }

    /** Get. [GET /api/kubernetes/clusters/{id}] */
    public JsonNode get(String id) {
        return c.send("GET", "/api/kubernetes/clusters/" + HiokClient.segment(id), null, null);
    }

    /** Kubeconfig. [GET /api/kubernetes/clusters/{id}/kubeconfig] */
    public JsonNode kubeconfig(String id, Object external) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("external", external);
        return c.send("GET", "/api/kubernetes/clusters/" + HiokClient.segment(id) + "/kubeconfig", null, query_);
    }
    public JsonNode kubeconfig(String id) {
        return kubeconfig(id, null);
    }

    /** Kubectl. [POST /api/kubernetes/clusters/{id}/kubectl] */
    public JsonNode kubectl(String id, Object body) {
        return c.send("POST", "/api/kubernetes/clusters/" + HiokClient.segment(id) + "/kubectl", body, null);
    }

    /** List. [GET /api/kubernetes/clusters] */
    public JsonNode list() {
        return c.send("GET", "/api/kubernetes/clusters", null, null);
    }

    /** Remove pool. [DELETE /api/kubernetes/clusters/{id}/node-pools/{poolId}] */
    public JsonNode removePool(String id, String poolId) {
        return c.send("DELETE", "/api/kubernetes/clusters/" + HiokClient.segment(id) + "/node-pools/" + HiokClient.segment(poolId), null, null);
    }

    /** Resources. [GET /api/kubernetes/clusters/{id}/resources/{kind}] */
    public JsonNode resources(String id, String kind, Object ns) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("ns", ns);
        return c.send("GET", "/api/kubernetes/clusters/" + HiokClient.segment(id) + "/resources/" + HiokClient.segment(kind), null, query_);
    }
    public JsonNode resources(String id, String kind) {
        return resources(id, kind, null);
    }

    /** Restart workload. [POST /api/kubernetes/clusters/{id}/workloads/{kind}/{ns}/{name}/restart] */
    public JsonNode restartWorkload(String id, String kind, String ns, String name) {
        return c.send("POST", "/api/kubernetes/clusters/" + HiokClient.segment(id) + "/workloads/" + HiokClient.segment(kind) + "/" + HiokClient.segment(ns) + "/" + HiokClient.segment(name) + "/restart", null, null);
    }

    /** Scale. [POST /api/kubernetes/clusters/{id}/workloads/{kind}/{ns}/{name}/scale] */
    public JsonNode scale(String id, String kind, String ns, String name, Object body) {
        return c.send("POST", "/api/kubernetes/clusters/" + HiokClient.segment(id) + "/workloads/" + HiokClient.segment(kind) + "/" + HiokClient.segment(ns) + "/" + HiokClient.segment(name) + "/scale", body, null);
    }
}
