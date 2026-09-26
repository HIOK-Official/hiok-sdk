// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package com.hiokcloud.api;

import com.hiokcloud.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** Panel operations. */
public final class PanelApi {
    private final HiokClient c;
    public PanelApi(HiokClient client) { this.c = client; }

    /** Create panel. [POST /api/Panel/createpanel] */
    public JsonNode createPanel(Object body) {
        return c.send("POST", "/api/Panel/createpanel", body, null);
    }

    /** Delete panel. [DELETE /api/Panel/deletepanel/{id}] */
    public JsonNode deletePanel(String id) {
        return c.send("DELETE", "/api/Panel/deletepanel/" + HiokClient.segment(id), null, null);
    }

    /** Get panels. [GET /api/Panel/panels] */
    public JsonNode getPanels() {
        return c.send("GET", "/api/Panel/panels", null, null);
    }

    /** Panel by id. [GET /api/Panel/panel/{id}] */
    public JsonNode panelById(String id) {
        return c.send("GET", "/api/Panel/panel/" + HiokClient.segment(id), null, null);
    }

    /** Update panel. [PUT /api/Panel/updatepanel/{id}] */
    public JsonNode updatePanel(String id, Object body) {
        return c.send("PUT", "/api/Panel/updatepanel/" + HiokClient.segment(id), body, null);
    }
}
