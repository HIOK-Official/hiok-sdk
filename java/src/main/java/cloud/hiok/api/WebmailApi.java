// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package cloud.hiok.api;

import cloud.hiok.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** Webmail operations. */
public final class WebmailApi {
    private final HiokClient c;
    public WebmailApi(HiokClient client) { this.c = client; }

    /** Assist. [POST /api/mail/assist] */
    public JsonNode assist(Object body, Object accountId) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("accountId", accountId);
        return c.send("POST", "/api/mail/assist", body, query_);
    }
    public JsonNode assist(Object body) {
        return assist(body, null);
    }

    /** Attachment. [GET /api/mail/messages/{id}/attachments/{attachmentId}] */
    public JsonNode attachment(String id, String attachmentId, Object accountId) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("accountId", accountId);
        return c.send("GET", "/api/mail/messages/" + HiokClient.segment(id) + "/attachments/" + HiokClient.segment(attachmentId), null, query_);
    }
    public JsonNode attachment(String id, String attachmentId) {
        return attachment(id, attachmentId, null);
    }

    /** Change password. [POST /api/mail/password] */
    public JsonNode changePassword(Object body) {
        return c.send("POST", "/api/mail/password", body, null);
    }

    /** Contacts. [GET /api/mail/contacts] */
    public JsonNode contacts(Object accountId, Object q) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("accountId", accountId);
        query_.put("q", q);
        return c.send("GET", "/api/mail/contacts", null, query_);
    }
    public JsonNode contacts() {
        return contacts(null, null);
    }

    /** Create filter. [POST /api/mail/filters] */
    public JsonNode createFilter(Object body, Object accountId) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("accountId", accountId);
        return c.send("POST", "/api/mail/filters", body, query_);
    }
    public JsonNode createFilter(Object body) {
        return createFilter(body, null);
    }

    /** Create folder. [POST /api/mail/folders] */
    public JsonNode createFolder(Object body, Object accountId) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("accountId", accountId);
        return c.send("POST", "/api/mail/folders", body, query_);
    }
    public JsonNode createFolder(Object body) {
        return createFolder(body, null);
    }

    /** Create label. [POST /api/mail/labels] */
    public JsonNode createLabel(Object body, Object accountId) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("accountId", accountId);
        return c.send("POST", "/api/mail/labels", body, query_);
    }
    public JsonNode createLabel(Object body) {
        return createLabel(body, null);
    }

    /** Delete. [POST /api/mail/messages/delete] */
    public JsonNode delete(Object body, Object accountId) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("accountId", accountId);
        return c.send("POST", "/api/mail/messages/delete", body, query_);
    }
    public JsonNode delete(Object body) {
        return delete(body, null);
    }

    /** Delete filter. [DELETE /api/mail/filters/{id}] */
    public JsonNode deleteFilter(String id, Object accountId) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("accountId", accountId);
        return c.send("DELETE", "/api/mail/filters/" + HiokClient.segment(id), null, query_);
    }
    public JsonNode deleteFilter(String id) {
        return deleteFilter(id, null);
    }

    /** Drop upload. [DELETE /api/mail/attachments/{id}] */
    public JsonNode dropUpload(String id, Object accountId) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("accountId", accountId);
        return c.send("DELETE", "/api/mail/attachments/" + HiokClient.segment(id), null, query_);
    }
    public JsonNode dropUpload(String id) {
        return dropUpload(id, null);
    }

    /** Filters. [GET /api/mail/filters] */
    public JsonNode filters(Object accountId) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("accountId", accountId);
        return c.send("GET", "/api/mail/filters", null, query_);
    }
    public JsonNode filters() {
        return filters(null);
    }

    /** Flag. [POST /api/mail/messages/flag] */
    public JsonNode flag(Object body, Object accountId) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("accountId", accountId);
        return c.send("POST", "/api/mail/messages/flag", body, query_);
    }
    public JsonNode flag(Object body) {
        return flag(body, null);
    }

    /** Folders. [GET /api/mail/folders] */
    public JsonNode folders(Object accountId) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("accountId", accountId);
        return c.send("GET", "/api/mail/folders", null, query_);
    }
    public JsonNode folders() {
        return folders(null);
    }

    /** Me. [GET /api/mail/me] */
    public JsonNode me() {
        return c.send("GET", "/api/mail/me", null, null);
    }

    /** Message. [GET /api/mail/messages/{id}] */
    public JsonNode message(String id, Object accountId, Object markRead) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("accountId", accountId);
        query_.put("markRead", markRead);
        return c.send("GET", "/api/mail/messages/" + HiokClient.segment(id), null, query_);
    }
    public JsonNode message(String id) {
        return message(id, null, null);
    }

    /** Messages. [GET /api/mail/messages] */
    public JsonNode messages(Object accountId, Object folderId, Object q, Object unread, Object starred, Object page, Object pageSize) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("accountId", accountId);
        query_.put("folderId", folderId);
        query_.put("q", q);
        query_.put("unread", unread);
        query_.put("starred", starred);
        query_.put("page", page);
        query_.put("pageSize", pageSize);
        return c.send("GET", "/api/mail/messages", null, query_);
    }
    public JsonNode messages() {
        return messages(null, null, null, null, null, null, null);
    }

    /** Mine. [GET /api/mail/mine] */
    public JsonNode mine() {
        return c.send("GET", "/api/mail/mine", null, null);
    }

    /** Move. [POST /api/mail/messages/move] */
    public JsonNode move(Object body, Object accountId) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("accountId", accountId);
        return c.send("POST", "/api/mail/messages/move", body, query_);
    }
    public JsonNode move(Object body) {
        return move(body, null);
    }

    /** Quote. [GET /api/mail/messages/{id}/quote] */
    public JsonNode quote(String id, Object accountId, Object forward) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("accountId", accountId);
        query_.put("forward", forward);
        return c.send("GET", "/api/mail/messages/" + HiokClient.segment(id) + "/quote", null, query_);
    }
    public JsonNode quote(String id) {
        return quote(id, null, null);
    }

    /** Save draft. [POST /api/mail/draft] */
    public JsonNode saveDraft(Object body, Object accountId) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("accountId", accountId);
        return c.send("POST", "/api/mail/draft", body, query_);
    }
    public JsonNode saveDraft(Object body) {
        return saveDraft(body, null);
    }

    /** Schedule. [POST /api/mail/schedule] */
    public JsonNode schedule(Object body, Object accountId) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("accountId", accountId);
        return c.send("POST", "/api/mail/schedule", body, query_);
    }
    public JsonNode schedule(Object body) {
        return schedule(body, null);
    }

    /** Send. [POST /api/mail/send] */
    public JsonNode send(Object body, Object accountId) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("accountId", accountId);
        return c.send("POST", "/api/mail/send", body, query_);
    }
    public JsonNode send(Object body) {
        return send(body, null);
    }

    /** Settings. [PATCH /api/mail/settings] */
    public JsonNode settings(Object body, Object accountId) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("accountId", accountId);
        return c.send("PATCH", "/api/mail/settings", body, query_);
    }
    public JsonNode settings(Object body) {
        return settings(body, null);
    }

    /** Sign in. [POST /api/mail/signin] */
    public JsonNode signIn(Object body) {
        return c.send("POST", "/api/mail/signin", body, null);
    }

    /** Sign out. [POST /api/mail/signout] */
    public JsonNode signOut() {
        return c.send("POST", "/api/mail/signout", null, null);
    }

    /** Unschedule. [POST /api/mail/schedule/{id}/cancel] */
    public JsonNode unschedule(String id, Object accountId) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("accountId", accountId);
        return c.send("POST", "/api/mail/schedule/" + HiokClient.segment(id) + "/cancel", null, query_);
    }
    public JsonNode unschedule(String id) {
        return unschedule(id, null);
    }

    /** Upload. [POST /api/mail/attachments] */
    public JsonNode upload(Map<String, String> form, Map<String, HiokClient.FilePart> files, Object accountId) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("accountId", accountId);
        return c.sendMultipart("POST", "/api/mail/attachments", form, files, query_);
    }
    public JsonNode upload(Map<String, String> form, Map<String, HiokClient.FilePart> files) {
        return upload(form, files, null);
    }
}
