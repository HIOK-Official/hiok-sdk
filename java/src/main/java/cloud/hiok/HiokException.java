package cloud.hiok;

import com.fasterxml.jackson.databind.JsonNode;
import java.nio.charset.StandardCharsets;

/** An API request returned an error. {@link #status()} is the HTTP status and {@link #body()} the API's reply. */
public final class HiokException extends RuntimeException {
    private final int status;
    private final transient JsonNode body;

    public HiokException(String message, int status, JsonNode body) {
        super(message);
        this.status = status;
        this.body = body;
    }

    public int status() { return status; }
    public JsonNode body() { return body; }

    static HiokException from(String method, String path, int status, byte[] content) {
        String text = content == null ? "" : new String(content, StandardCharsets.UTF_8);
        JsonNode body = null;
        String message = text;
        try {
            body = text.isEmpty() ? null : HiokClient.JSON.readTree(text);
            if (body != null && body.hasNonNull("message")) message = body.get("message").asText();
            else if (body != null && body.hasNonNull("Message")) message = body.get("Message").asText();
        } catch (Exception ignored) {
            // not JSON
        }
        return new HiokException(method + " " + path + " returned " + status + ": " + message, status, body);
    }
}
