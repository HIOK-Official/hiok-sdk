// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package cloud.hiok.api;

import cloud.hiok.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** Marketplace operations. */
public final class MarketplaceApi {
    private final HiokClient c;
    public MarketplaceApi(HiokClient client) { this.c = client; }

    /** Categories. [GET /api/Marketplace/categories] */
    public JsonNode categories() {
        return c.send("GET", "/api/Marketplace/categories", null, null);
    }

    /** Connections. [GET /api/Marketplace/connections] */
    public JsonNode connections() {
        return c.send("GET", "/api/Marketplace/connections", null, null);
    }

    /** Delete deployment. [DELETE /api/Marketplace/deployments/{id}] */
    public JsonNode deleteDeployment(String id) {
        return c.send("DELETE", "/api/Marketplace/deployments/" + HiokClient.segment(id), null, null);
    }

    /** Deploy. [POST /api/Marketplace/deploy] */
    public JsonNode deploy(Object body) {
        return c.send("POST", "/api/Marketplace/deploy", body, null);
    }

    /** Deployments. [GET /api/Marketplace/deployments] */
    public JsonNode deployments() {
        return c.send("GET", "/api/Marketplace/deployments", null, null);
    }

    /** Offer. [GET /api/Marketplace/offers/{slug}] */
    public JsonNode offer(String slug) {
        return c.send("GET", "/api/Marketplace/offers/" + HiokClient.segment(slug), null, null);
    }

    /** Offers. [GET /api/Marketplace/offers] */
    public JsonNode offers(Object search, Object category, Object source, Object delivery, Object featured, Object take) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("search", search);
        query_.put("category", category);
        query_.put("source", source);
        query_.put("delivery", delivery);
        query_.put("featured", featured);
        query_.put("take", take);
        return c.send("GET", "/api/Marketplace/offers", null, query_);
    }
    public JsonNode offers() {
        return offers(null, null, null, null, null, null);
    }

    /** Publish. [POST /api/Marketplace/offers] */
    public JsonNode publish(Object body) {
        return c.send("POST", "/api/Marketplace/offers", body, null);
    }

    /** Save connection. [POST /api/Marketplace/connections] */
    public JsonNode saveConnection(Object body) {
        return c.send("POST", "/api/Marketplace/connections", body, null);
    }

    /** Sync. [POST /api/Marketplace/connections/{id}/sync] */
    public JsonNode sync(String id) {
        return c.send("POST", "/api/Marketplace/connections/" + HiokClient.segment(id) + "/sync", null, null);
    }

    /** Unpublish. [DELETE /api/Marketplace/offers/{id}] */
    public JsonNode unpublish(String id) {
        return c.send("DELETE", "/api/Marketplace/offers/" + HiokClient.segment(id), null, null);
    }
}
