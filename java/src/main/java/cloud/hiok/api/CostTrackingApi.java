// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package cloud.hiok.api;

import cloud.hiok.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** CostTracking operations. */
public final class CostTrackingApi {
    private final HiokClient c;
    public CostTrackingApi(HiokClient client) { this.c = client; }

    /** Create cost alert. [POST /api/CostTracking/alerts] */
    public JsonNode createCostAlert(Object body) {
        return c.send("POST", "/api/CostTracking/alerts", body, null);
    }

    /** Delete cost alert. [DELETE /api/CostTracking/alerts/{alertId}] */
    public JsonNode deleteCostAlert(String alertId) {
        return c.send("DELETE", "/api/CostTracking/alerts/" + HiokClient.segment(alertId), null, null);
    }

    /** Estimate cost. [POST /api/CostTracking/pricing/estimate] */
    public JsonNode estimateCost(Object body) {
        return c.send("POST", "/api/CostTracking/pricing/estimate", body, null);
    }

    /** Get all storage account costs. [GET /api/CostTracking/storage-accounts] */
    public JsonNode getAllStorageAccountCosts(Object period) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("period", period);
        return c.send("GET", "/api/CostTracking/storage-accounts", null, query_);
    }
    public JsonNode getAllStorageAccountCosts() {
        return getAllStorageAccountCosts(null);
    }

    /** Get billing periods. [GET /api/CostTracking/billing/history] */
    public JsonNode getBillingPeriods(Object limit) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("limit", limit);
        return c.send("GET", "/api/CostTracking/billing/history", null, query_);
    }
    public JsonNode getBillingPeriods() {
        return getBillingPeriods(null);
    }

    /** Get cost alerts. [GET /api/CostTracking/alerts] */
    public JsonNode getCostAlerts(Object scopeType, Object scopeId) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("scopeType", scopeType);
        query_.put("scopeId", scopeId);
        return c.send("GET", "/api/CostTracking/alerts", null, query_);
    }
    public JsonNode getCostAlerts() {
        return getCostAlerts(null, null);
    }

    /** Get current billing period. [GET /api/CostTracking/billing/current] */
    public JsonNode getCurrentBillingPeriod() {
        return c.send("GET", "/api/CostTracking/billing/current", null, null);
    }

    /** Get pricing tiers. [GET /api/CostTracking/pricing] */
    public JsonNode getPricingTiers(Object tier, Object redundancy, Object region) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("tier", tier);
        query_.put("redundancy", redundancy);
        query_.put("region", region);
        return c.send("GET", "/api/CostTracking/pricing", null, query_);
    }
    public JsonNode getPricingTiers() {
        return getPricingTiers(null, null, null);
    }

    /** Get resource group cost. [GET /api/CostTracking/resource-group/{resourceGroupId}] */
    public JsonNode getResourceGroupCost(String resourceGroupId, Object period) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("period", period);
        return c.send("GET", "/api/CostTracking/resource-group/" + HiokClient.segment(resourceGroupId), null, query_);
    }
    public JsonNode getResourceGroupCost(String resourceGroupId) {
        return getResourceGroupCost(resourceGroupId, null);
    }

    /** Get storage account cost. [GET /api/CostTracking/storage-account/{storageAccountId}] */
    public JsonNode getStorageAccountCost(String storageAccountId, Object period) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("period", period);
        return c.send("GET", "/api/CostTracking/storage-account/" + HiokClient.segment(storageAccountId), null, query_);
    }
    public JsonNode getStorageAccountCost(String storageAccountId) {
        return getStorageAccountCost(storageAccountId, null);
    }

    /** Get subscription cost. [GET /api/CostTracking/subscription/{subscriptionId}] */
    public JsonNode getSubscriptionCost(String subscriptionId, Object period) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("period", period);
        return c.send("GET", "/api/CostTracking/subscription/" + HiokClient.segment(subscriptionId), null, query_);
    }
    public JsonNode getSubscriptionCost(String subscriptionId) {
        return getSubscriptionCost(subscriptionId, null);
    }

    /** Overview. [GET /api/CostTracking/overview] */
    public JsonNode overview(Object region, Object subscriptionId, Object from, Object to, Object resourceName) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("region", region);
        query_.put("subscriptionId", subscriptionId);
        query_.put("from", from);
        query_.put("to", to);
        query_.put("resourceName", resourceName);
        return c.send("GET", "/api/CostTracking/overview", null, query_);
    }
    public JsonNode overview() {
        return overview(null, null, null, null, null);
    }

    /** Record cost event. [POST /api/CostTracking/events] */
    public JsonNode recordCostEvent(Object body) {
        return c.send("POST", "/api/CostTracking/events", body, null);
    }

    /** Trigger daily calculation. [POST /api/CostTracking/daily-calculation] */
    public JsonNode triggerDailyCalculation() {
        return c.send("POST", "/api/CostTracking/daily-calculation", null, null);
    }
}
