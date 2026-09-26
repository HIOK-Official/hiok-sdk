// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package com.hiokcloud.api;

import com.hiokcloud.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** Notification operations. */
public final class NotificationApi {
    private final HiokClient c;
    public NotificationApi(HiokClient client) { this.c = client; }

    /** Get notification. [GET /api/Notification/notification] */
    public JsonNode getNotification() {
        return c.send("GET", "/api/Notification/notification", null, null);
    }
}
