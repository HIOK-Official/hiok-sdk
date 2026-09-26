// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package cloud.hiok.api;

import cloud.hiok.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** Widget operations. */
public final class WidgetApi {
    private final HiokClient c;
    public WidgetApi(HiokClient client) { this.c = client; }

    /** Add widget to panel. [POST /api/Widget/addwidgettopanel] */
    public JsonNode addWidgetToPanel(Object body) {
        return c.send("POST", "/api/Widget/addwidgettopanel", body, null);
    }

    /** Clone widget. [POST /api/Widget/clonewidget] */
    public JsonNode cloneWidget(Object body) {
        return c.send("POST", "/api/Widget/clonewidget", body, null);
    }

    /** Create default widgets. [POST /api/Widget/createdefaultwidgets] */
    public JsonNode createDefaultWidgets(Object body) {
        return c.send("POST", "/api/Widget/createdefaultwidgets", body, null);
    }

    /** Create widget template. [POST /api/Widget/createwidgettemplate] */
    public JsonNode createWidgetTemplate(Object body) {
        return c.send("POST", "/api/Widget/createwidgettemplate", body, null);
    }

    /** Create widgets template. [POST /api/Widget/createwidgetstemplate] */
    public JsonNode createWidgetsTemplate(Object body) {
        return c.send("POST", "/api/Widget/createwidgetstemplate", body, null);
    }

    /** Default widgets. [GET /api/Widget/defaultwidgets] */
    public JsonNode defaultWidgets() {
        return c.send("GET", "/api/Widget/defaultwidgets", null, null);
    }

    /** Delete widget from panel. [DELETE /api/Widget/deletepanelwidget] */
    public JsonNode deleteWidgetFromPanel(Object body) {
        return c.send("DELETE", "/api/Widget/deletepanelwidget", body, null);
    }

    /** Delete widget template. [DELETE /api/Widget/deletewidgettemplate/{id}] */
    public JsonNode deleteWidgetTemplate(String id) {
        return c.send("DELETE", "/api/Widget/deletewidgettemplate/" + HiokClient.segment(id), null, null);
    }

    /** Get widget settings. [POST /api/Widget/getwidgetsettings] */
    public JsonNode getWidgetSettings(Object body) {
        return c.send("POST", "/api/Widget/getwidgetsettings", body, null);
    }

    /** Update widget position. [POST /api/Widget/updatewidgetposition] */
    public JsonNode updateWidgetPosition(Object body) {
        return c.send("POST", "/api/Widget/updatewidgetposition", body, null);
    }

    /** Update widget settings. [POST /api/Widget/updatewidgetsettings] */
    public JsonNode updateWidgetSettings(Object body) {
        return c.send("POST", "/api/Widget/updatewidgetsettings", body, null);
    }

    /** Update widget template. [PUT /api/Widget/updatewidgettemplate/{id}] */
    public JsonNode updateWidgetTemplate(String id, Object body) {
        return c.send("PUT", "/api/Widget/updatewidgettemplate/" + HiokClient.segment(id), body, null);
    }

    /** Widget details. [POST /api/Widget/widgetdetails] */
    public JsonNode widgetDetails(Object body) {
        return c.send("POST", "/api/Widget/widgetdetails", body, null);
    }

    /** Widget library. [GET /api/Widget/widgetlibrary] */
    public JsonNode widgetLibrary() {
        return c.send("GET", "/api/Widget/widgetlibrary", null, null);
    }

    /** Widget options. [POST /api/Widget/widgetoptions] */
    public JsonNode widgetOptions(Object body) {
        return c.send("POST", "/api/Widget/widgetoptions", body, null);
    }

    /** Widgets. [POST /api/Widget/widgets] */
    public JsonNode widgets(Object body) {
        return c.send("POST", "/api/Widget/widgets", body, null);
    }
}
