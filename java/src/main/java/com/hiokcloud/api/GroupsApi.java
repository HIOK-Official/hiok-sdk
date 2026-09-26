// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package com.hiokcloud.api;

import com.hiokcloud.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** Groups operations. */
public final class GroupsApi {
    private final HiokClient c;
    public GroupsApi(HiokClient client) { this.c = client; }

    /** Create groups. [POST /api/Groups/creategroups] */
    public JsonNode createGroups(Object body) {
        return c.send("POST", "/api/Groups/creategroups", body, null);
    }

    /** Delete groups. [DELETE /api/Groups/deletegroups] */
    public JsonNode deleteGroups(Object id) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("id", id);
        return c.send("DELETE", "/api/Groups/deletegroups", null, query_);
    }
    public JsonNode deleteGroups() {
        return deleteGroups(null);
    }

    /** Edit groups. [PUT /api/Groups/editgroups] */
    public JsonNode editGroups(Object body) {
        return c.send("PUT", "/api/Groups/editgroups", body, null);
    }

    /** Get groups. [GET /api/Groups/groups] */
    public JsonNode getGroups() {
        return c.send("GET", "/api/Groups/groups", null, null);
    }
}
