package com.hiokcloud;

import com.hiokcloud.api.Api;
import com.fasterxml.jackson.databind.JsonNode;
import com.fasterxml.jackson.databind.ObjectMapper;
import com.fasterxml.jackson.databind.SerializationFeature;
import com.fasterxml.jackson.annotation.JsonInclude;
import java.io.ByteArrayOutputStream;
import java.io.IOException;
import java.net.URI;
import java.net.URLEncoder;
import java.net.http.HttpClient;
import java.net.http.HttpRequest;
import java.net.http.HttpResponse;
import java.nio.charset.StandardCharsets;
import java.time.Duration;
import java.util.ArrayList;
import java.util.Collection;
import java.util.List;
import java.util.Map;
import java.util.Set;
import java.util.UUID;

/**
 * HIOK Cloud client.
 *
 * <pre>{@code
 * HiokClient client = HiokClient.builder()
 *     .endpoint("https://hiokcloud.com")
 *     .token(System.getenv("HIOK_TOKEN"))
 *     .build();
 * JsonNode vaults = client.api().keyVault().list();          // every API operation, by group
 * client.storage().uploadFile(accountId, "backups", "db.dump", Path.of("db.dump"));
 * }</pre>
 *
 * Authentication is a bearer token (or {@link #login}) or, for one storage account's
 * data only, a storage access key.
 */
public final class HiokClient {
    public static final ObjectMapper JSON = new ObjectMapper()
            .setSerializationInclusion(JsonInclude.Include.NON_NULL)
            .disable(SerializationFeature.FAIL_ON_EMPTY_BEANS);

    private static final Set<Integer> RETRY = Set.of(429, 502, 503, 504);

    private final String endpoint;
    private final HttpClient http;
    private final int retries;
    private volatile String token;
    private volatile String storageKey;
    private volatile String clientId;
    private volatile String clientSecret;
    private volatile long spExpires;
    private final Api api;
    private final StorageTransfer storage;

    private HiokClient(Builder b) {
        this.endpoint = b.endpoint.replaceAll("/+$", "");
        this.token = b.token;
        this.storageKey = b.storageKey;
        this.clientId = b.clientId;
        this.clientSecret = b.clientSecret;
        this.retries = b.retries;
        this.http = HttpClient.newBuilder()
                .connectTimeout(Duration.ofSeconds(30))
                .followRedirects(HttpClient.Redirect.NORMAL)
                .build();
        this.api = new Api(this);
        this.storage = new StorageTransfer(this);
    }

    public static Builder builder() { return new Builder(); }

    /**
     * A client configured from HIOK_ENDPOINT, HIOK_TOKEN, HIOK_STORAGE_KEY, and
     * HIOK_CLIENT_ID + HIOK_CLIENT_SECRET (a service principal, for CI/CD).
     */
    public static HiokClient fromEnvironment() {
        String token = System.getenv("HIOK_TOKEN");
        boolean noToken = token == null || token.isBlank();
        return builder()
                .endpoint(System.getenv().getOrDefault("HIOK_ENDPOINT", "https://hiokcloud.com"))
                .token(token)
                .storageKey(System.getenv("HIOK_STORAGE_KEY"))
                .servicePrincipal(noToken ? System.getenv("HIOK_CLIENT_ID") : null,
                                  noToken ? System.getenv("HIOK_CLIENT_SECRET") : null)
                .build();
    }

    /** Every API operation, grouped as the API groups them. */
    public Api api() { return api; }

    /** Large-file upload and download for storage accounts. */
    public StorageTransfer storage() { return storage; }

    public String endpoint() { return endpoint; }

    /** Sign in with email and password; the token is kept for later calls. */
    public HiokClient login(String email, String password) {
        JsonNode reply = sendInternal("POST", "/api/OAuth/token", Map.of("email", email, "password", password), null, false);
        String t = reply == null ? null : reply.path("data").path("token").asText(null);
        if (t == null || t.isEmpty()) throw new HiokException("Sign-in failed", 0, reply);
        this.token = t;
        return this;
    }

    /**
     * Sign in as a service principal (Identity → Service principals). The token lasts an
     * hour; a client built with {@link Builder#servicePrincipal} renews it by itself.
     */
    public synchronized HiokClient loginServicePrincipal(String clientId, String clientSecret) {
        JsonNode reply = sendInternal("POST", "/api/OAuth/token/client",
                Map.of("clientId", clientId, "clientSecret", clientSecret), null, false);
        String t = reply == null ? null : reply.path("data").path("token").asText(null);
        if (t == null || t.isEmpty()) throw new HiokException("Service principal sign-in failed", 0, reply);
        this.clientId = clientId;
        this.clientSecret = clientSecret;
        this.token = t;
        this.spExpires = System.currentTimeMillis() + 55L * 60 * 1000;
        return this;
    }

    private synchronized void ensureToken() {
        if (clientId == null || clientId.isBlank() || clientSecret == null || clientSecret.isBlank()) return;
        if (token != null && !token.isBlank() && (spExpires == 0 || System.currentTimeMillis() < spExpires)) return;
        loginServicePrincipal(clientId, clientSecret);
    }

    public void setToken(String token) { this.token = token; }
    public void setStorageKey(String key) { this.storageKey = key; }

    // ── transport ───────────────────────────────────────────────────────────

    /** Encodes one path parameter; a key keeps its slashes ("dir/file.txt"). */
    public static String segment(String value) { return segment(value, false); }

    public static String segment(String value, boolean slashed) {
        String v = value == null ? "" : value;
        if (!slashed) return enc(v);
        String[] parts = v.split("/", -1);
        List<String> out = new ArrayList<>();
        for (String p : parts) out.add(enc(p));
        return String.join("/", out);
    }

    private static String enc(String s) {
        return URLEncoder.encode(s, StandardCharsets.UTF_8).replace("+", "%20");
    }

    static String query(Map<String, Object> query) {
        if (query == null) return "";
        List<String> parts = new ArrayList<>();
        for (Map.Entry<String, Object> e : query.entrySet()) {
            Object v = e.getValue();
            if (v == null) continue;
            Collection<?> values = v instanceof Collection<?> c ? c : List.of(v);
            for (Object item : values) {
                if (item != null) parts.add(enc(e.getKey()) + "=" + enc(String.valueOf(item)));
            }
        }
        return parts.isEmpty() ? "" : "?" + String.join("&", parts);
    }

    /** Sends one JSON request and parses the JSON answer (null when there is none). */
    public JsonNode send(String method, String path, Object body, Map<String, Object> query) {
        return sendInternal(method, path, body, query, true);
    }

    private JsonNode sendInternal(String method, String path, Object body, Map<String, Object> query, boolean auth) {
        byte[] bytes = sendRaw(method, path, body, query, Map.of(), auth);
        if (bytes.length == 0) return null;
        try {
            return JSON.readTree(bytes);
        } catch (IOException e) {
            return JSON.getNodeFactory().textNode(new String(bytes, StandardCharsets.UTF_8));
        }
    }

    /** Sends one request and returns the raw response body. */
    public byte[] sendRaw(String method, String path, Object body, Map<String, Object> query, Map<String, String> headers) {
        return sendRaw(method, path, body, query, headers, true);
    }

    private byte[] sendRaw(String method, String path, Object body, Map<String, Object> query,
                           Map<String, String> headers, boolean auth) {
        boolean safe = method.equals("GET") || method.equals("HEAD") || method.equals("OPTIONS");
        int attempts = safe ? retries + 1 : 1;
        byte[] payload;
        try {
            payload = body == null ? null : body instanceof byte[] b ? b : JSON.writeValueAsBytes(body);
        } catch (IOException e) {
            throw new HiokException("Could not encode the request body: " + e.getMessage(), 0, null);
        }
        for (int attempt = 0; ; attempt++) {
            HttpRequest.Builder req = HttpRequest.newBuilder(URI.create(endpoint + path + query(query)))
                    .timeout(Duration.ofMinutes(10))
                    .header("Accept", "application/json")
                    .header("User-Agent", "hiok-java-sdk/0.3");
            if (auth) authorize(req);
            if (headers != null) headers.forEach(req::header);
            if (payload != null && !(body instanceof byte[])) req.header("Content-Type", "application/json");
            req.method(method, payload == null ? HttpRequest.BodyPublishers.noBody() : HttpRequest.BodyPublishers.ofByteArray(payload));
            try {
                HttpResponse<byte[]> res = http.send(req.build(), HttpResponse.BodyHandlers.ofByteArray());
                int code = res.statusCode();
                if (code < 300) return res.body() == null ? new byte[0] : res.body();
                if (RETRY.contains(code) && attempt + 1 < attempts) { backoff(attempt); continue; }
                throw HiokException.from(method, path, code, res.body());
            } catch (IOException e) {
                if (attempt + 1 < attempts) { backoff(attempt); continue; }
                throw new HiokException(method + " " + path + " failed: " + e.getMessage(), 0, null);
            } catch (InterruptedException e) {
                Thread.currentThread().interrupt();
                throw new HiokException("Interrupted", 0, null);
            }
        }
    }

    /** A file for a multipart request. */
    public record FilePart(String fileName, byte[] content) {}

    /** Sends multipart/form-data: fields and files. */
    public JsonNode sendMultipart(String method, String path, Map<String, String> form, Map<String, FilePart> files,
                                  Map<String, Object> query) {
        String boundary = "----hiok" + UUID.randomUUID().toString().replace("-", "");
        ByteArrayOutputStream out = new ByteArrayOutputStream();
        try {
            if (form != null) for (Map.Entry<String, String> e : form.entrySet()) {
                out.write(("--" + boundary + "\r\nContent-Disposition: form-data; name=\"" + e.getKey() + "\"\r\n\r\n"
                        + e.getValue() + "\r\n").getBytes(StandardCharsets.UTF_8));
            }
            if (files != null) for (Map.Entry<String, FilePart> e : files.entrySet()) {
                out.write(("--" + boundary + "\r\nContent-Disposition: form-data; name=\"" + e.getKey() + "\"; filename=\""
                        + e.getValue().fileName() + "\"\r\nContent-Type: application/octet-stream\r\n\r\n").getBytes(StandardCharsets.UTF_8));
                out.write(e.getValue().content());
                out.write("\r\n".getBytes(StandardCharsets.UTF_8));
            }
            out.write(("--" + boundary + "--\r\n").getBytes(StandardCharsets.UTF_8));
        } catch (IOException e) {
            throw new HiokException(e.getMessage(), 0, null);
        }
        byte[] bytes = sendRaw(method, path, out.toByteArray(), query,
                Map.of("Content-Type", "multipart/form-data; boundary=" + boundary), true);
        try {
            return bytes.length == 0 ? null : JSON.readTree(bytes);
        } catch (IOException e) {
            return JSON.getNodeFactory().textNode(new String(bytes, StandardCharsets.UTF_8));
        }
    }

    private void authorize(HttpRequest.Builder req) {
        ensureToken();
        if (token != null && !token.isBlank()) req.header("Authorization", "Bearer " + token);
        else if (storageKey != null && !storageKey.isBlank()) req.header("x-hiok-storage-key", storageKey);
        else throw new HiokException("No credentials: set a token, a storage key, or call login() first", 0, null);
    }

    private static void backoff(int attempt) {
        try {
            Thread.sleep((long) Math.min(16000, 1000 * Math.pow(2, attempt)));
        } catch (InterruptedException e) {
            Thread.currentThread().interrupt();
        }
    }

    public static final class Builder {
        private String endpoint = "https://hiokcloud.com";
        private String token;
        private String storageKey;
        private String clientId;
        private String clientSecret;
        private int retries = 4;

        public Builder endpoint(String v) { if (v != null) endpoint = v; return this; }
        public Builder token(String v) { token = v; return this; }
        /** A storage account access key: that account's data only. */
        public Builder storageKey(String v) { storageKey = v; return this; }
        /** A service principal (CI/CD): signed in on first use, token renewed before it lapses. */
        public Builder servicePrincipal(String id, String secret) { clientId = id; clientSecret = secret; return this; }
        /** Attempts for a safe request that meets 429/502/503/504. */
        public Builder retries(int v) { retries = v; return this; }
        public HiokClient build() { return new HiokClient(this); }
    }
}
