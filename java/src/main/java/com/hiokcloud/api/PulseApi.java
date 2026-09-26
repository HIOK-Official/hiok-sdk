// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package com.hiokcloud.api;

import com.hiokcloud.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** Pulse operations. */
public final class PulseApi {
    private final HiokClient c;
    public PulseApi(HiokClient client) { this.c = client; }

    /** Create consumer group. [POST /api/Pulse/namespaces/{id}/streams/{stream}/consumer-groups] */
    public JsonNode createConsumerGroup(String id, String stream, Object body) {
        return c.send("POST", "/api/Pulse/namespaces/" + HiokClient.segment(id) + "/streams/" + HiokClient.segment(stream) + "/consumer-groups", body, null);
    }

    /** Create event subscription. [POST /api/Pulse/namespaces/{id}/streams/{stream}/subscriptions] */
    public JsonNode createEventSubscription(String id, String stream, Object body) {
        return c.send("POST", "/api/Pulse/namespaces/" + HiokClient.segment(id) + "/streams/" + HiokClient.segment(stream) + "/subscriptions", body, null);
    }

    /** Create namespace. [POST /api/Pulse/namespaces] */
    public JsonNode createNamespace(Object body) {
        return c.send("POST", "/api/Pulse/namespaces", body, null);
    }

    /** Create stream. [POST /api/Pulse/namespaces/{id}/streams] */
    public JsonNode createStream(String id, Object body) {
        return c.send("POST", "/api/Pulse/namespaces/" + HiokClient.segment(id) + "/streams", body, null);
    }

    /** Delete consumer group. [DELETE /api/Pulse/namespaces/{id}/streams/{stream}/consumer-groups/{name}] */
    public JsonNode deleteConsumerGroup(String id, String stream, String name) {
        return c.send("DELETE", "/api/Pulse/namespaces/" + HiokClient.segment(id) + "/streams/" + HiokClient.segment(stream) + "/consumer-groups/" + HiokClient.segment(name), null, null);
    }

    /** Delete event subscription. [DELETE /api/Pulse/namespaces/{id}/streams/{stream}/subscriptions/{name}] */
    public JsonNode deleteEventSubscription(String id, String stream, String name) {
        return c.send("DELETE", "/api/Pulse/namespaces/" + HiokClient.segment(id) + "/streams/" + HiokClient.segment(stream) + "/subscriptions/" + HiokClient.segment(name), null, null);
    }

    /** Delete namespace. [DELETE /api/Pulse/namespaces/{id}] */
    public JsonNode deleteNamespace(String id) {
        return c.send("DELETE", "/api/Pulse/namespaces/" + HiokClient.segment(id), null, null);
    }

    /** Delete stream. [DELETE /api/Pulse/namespaces/{id}/streams/{name}] */
    public JsonNode deleteStream(String id, String name) {
        return c.send("DELETE", "/api/Pulse/namespaces/" + HiokClient.segment(id) + "/streams/" + HiokClient.segment(name), null, null);
    }

    /** List consumer groups. [GET /api/Pulse/namespaces/{id}/streams/{stream}/consumer-groups] */
    public JsonNode listConsumerGroups(String id, String stream) {
        return c.send("GET", "/api/Pulse/namespaces/" + HiokClient.segment(id) + "/streams/" + HiokClient.segment(stream) + "/consumer-groups", null, null);
    }

    /** List deliveries. [GET /api/Pulse/namespaces/{id}/streams/{stream}/subscriptions/{name}/deliveries] */
    public JsonNode listDeliveries(String id, String stream, String name, Object limit) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("limit", limit);
        return c.send("GET", "/api/Pulse/namespaces/" + HiokClient.segment(id) + "/streams/" + HiokClient.segment(stream) + "/subscriptions/" + HiokClient.segment(name) + "/deliveries", null, query_);
    }
    public JsonNode listDeliveries(String id, String stream, String name) {
        return listDeliveries(id, stream, name, null);
    }

    /** List event subscriptions. [GET /api/Pulse/namespaces/{id}/streams/{stream}/subscriptions] */
    public JsonNode listEventSubscriptions(String id, String stream) {
        return c.send("GET", "/api/Pulse/namespaces/" + HiokClient.segment(id) + "/streams/" + HiokClient.segment(stream) + "/subscriptions", null, null);
    }

    /** List namespaces. [GET /api/Pulse/namespaces] */
    public JsonNode listNamespaces() {
        return c.send("GET", "/api/Pulse/namespaces", null, null);
    }

    /** List streams. [GET /api/Pulse/namespaces/{id}/streams] */
    public JsonNode listStreams(String id) {
        return c.send("GET", "/api/Pulse/namespaces/" + HiokClient.segment(id) + "/streams", null, null);
    }

    /** Publish. [POST /api/Pulse/namespaces/{id}/streams/{stream}/events] */
    public JsonNode publish(String id, String stream, Object body) {
        return c.send("POST", "/api/Pulse/namespaces/" + HiokClient.segment(id) + "/streams/" + HiokClient.segment(stream) + "/events", body, null);
    }

    /** Read. [POST /api/Pulse/namespaces/{id}/streams/{stream}/events/read] */
    public JsonNode read(String id, String stream, Object consumerGroup, Object maxEvents) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("consumerGroup", consumerGroup);
        query_.put("maxEvents", maxEvents);
        return c.send("POST", "/api/Pulse/namespaces/" + HiokClient.segment(id) + "/streams/" + HiokClient.segment(stream) + "/events/read", null, query_);
    }
    public JsonNode read(String id, String stream) {
        return read(id, stream, null, null);
    }
}
