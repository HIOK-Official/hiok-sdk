// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package com.hiokcloud.api;

import com.hiokcloud.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** AccessControl operations. */
public final class AccessControlApi {
    private final HiokClient c;
    public AccessControlApi(HiokClient client) { this.c = client; }

    /** Add role assignment. [POST /api/access-control/{resourceType}/{resourceId}/role-assignments] */
    public JsonNode addRoleAssignment(String resourceType, String resourceId, Object body) {
        return c.send("POST", "/api/access-control/" + HiokClient.segment(resourceType) + "/" + HiokClient.segment(resourceId) + "/role-assignments", body, null);
    }

    /** Check access. [GET /api/access-control/{resourceType}/{resourceId}/check-access] */
    public JsonNode checkAccess(String resourceType, String resourceId, Object principalEmail) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("principalEmail", principalEmail);
        return c.send("GET", "/api/access-control/" + HiokClient.segment(resourceType) + "/" + HiokClient.segment(resourceId) + "/check-access", null, query_);
    }
    public JsonNode checkAccess(String resourceType, String resourceId) {
        return checkAccess(resourceType, resourceId, null);
    }

    /** List all assignments. [GET /api/access-control/assignments] */
    public JsonNode listAllAssignments(Object principalEmail, Object roleId) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("principalEmail", principalEmail);
        query_.put("roleId", roleId);
        return c.send("GET", "/api/access-control/assignments", null, query_);
    }
    public JsonNode listAllAssignments() {
        return listAllAssignments(null, null);
    }

    /** List principals. [GET /api/access-control/principals] */
    public JsonNode listPrincipals(Object q) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("q", q);
        return c.send("GET", "/api/access-control/principals", null, query_);
    }
    public JsonNode listPrincipals() {
        return listPrincipals(null);
    }

    /** List role assignments. [GET /api/access-control/{resourceType}/{resourceId}/role-assignments] */
    public JsonNode listRoleAssignments(String resourceType, String resourceId, Object includeInherited) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("includeInherited", includeInherited);
        return c.send("GET", "/api/access-control/" + HiokClient.segment(resourceType) + "/" + HiokClient.segment(resourceId) + "/role-assignments", null, query_);
    }
    public JsonNode listRoleAssignments(String resourceType, String resourceId) {
        return listRoleAssignments(resourceType, resourceId, null);
    }

    /** List roles. [GET /api/access-control/roles] */
    public JsonNode listRoles(Object category) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("category", category);
        return c.send("GET", "/api/access-control/roles", null, query_);
    }
    public JsonNode listRoles() {
        return listRoles(null);
    }

    /** Register scope. [PUT /api/access-control/{resourceType}/{resourceId}/scope] */
    public JsonNode registerScope(String resourceType, String resourceId, Object body) {
        return c.send("PUT", "/api/access-control/" + HiokClient.segment(resourceType) + "/" + HiokClient.segment(resourceId) + "/scope", body, null);
    }

    /** Remove assignment. [DELETE /api/access-control/assignments/{assignmentId}] */
    public JsonNode removeAssignment(String assignmentId) {
        return c.send("DELETE", "/api/access-control/assignments/" + HiokClient.segment(assignmentId), null, null);
    }

    /** Remove role assignment. [DELETE /api/access-control/{resourceType}/{resourceId}/role-assignments/{assignmentId}] */
    public JsonNode removeRoleAssignment(String resourceType, String resourceId, String assignmentId) {
        return c.send("DELETE", "/api/access-control/" + HiokClient.segment(resourceType) + "/" + HiokClient.segment(resourceId) + "/role-assignments/" + HiokClient.segment(assignmentId), null, null);
    }

    /** Scope chain. [GET /api/access-control/{resourceType}/{resourceId}/scope-chain] */
    public JsonNode scopeChain(String resourceType, String resourceId) {
        return c.send("GET", "/api/access-control/" + HiokClient.segment(resourceType) + "/" + HiokClient.segment(resourceId) + "/scope-chain", null, null);
    }
}
