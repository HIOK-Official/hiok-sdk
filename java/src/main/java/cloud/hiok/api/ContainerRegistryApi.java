// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package cloud.hiok.api;

import cloud.hiok.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** ContainerRegistry operations. */
public final class ContainerRegistryApi {
    private final HiokClient c;
    public ContainerRegistryApi(HiokClient client) { this.c = client; }

    /** Create. [POST /api/container-registry] */
    public JsonNode create(Object body) {
        return c.send("POST", "/api/container-registry", body, null);
    }

    /** Create repository. [POST /api/container-registry/{id}/repositories] */
    public JsonNode createRepository(String id, Object body) {
        return c.send("POST", "/api/container-registry/" + HiokClient.segment(id) + "/repositories", body, null);
    }

    /** Credentials. [GET /api/container-registry/{id}/credentials] */
    public JsonNode credentials(String id) {
        return c.send("GET", "/api/container-registry/" + HiokClient.segment(id) + "/credentials", null, null);
    }

    /** Delete. [DELETE /api/container-registry/{id}] */
    public JsonNode delete(String id) {
        return c.send("DELETE", "/api/container-registry/" + HiokClient.segment(id), null, null);
    }

    /** Delete repository. [DELETE /api/container-registry/{id}/repositories/{repositoryName}] */
    public JsonNode deleteRepository(String id, String repositoryName) {
        return c.send("DELETE", "/api/container-registry/" + HiokClient.segment(id) + "/repositories/" + HiokClient.segment(repositoryName, true), null, null);
    }

    /** Delete tag. [DELETE /api/container-registry/{id}/tags] */
    public JsonNode deleteTag(String id, Object repository, Object tag) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("repository", repository);
        query_.put("tag", tag);
        return c.send("DELETE", "/api/container-registry/" + HiokClient.segment(id) + "/tags", null, query_);
    }
    public JsonNode deleteTag(String id) {
        return deleteTag(id, null, null);
    }

    /** Get. [GET /api/container-registry/{id}] */
    public JsonNode get(String id) {
        return c.send("GET", "/api/container-registry/" + HiokClient.segment(id), null, null);
    }

    /** List. [GET /api/container-registry] */
    public JsonNode list() {
        return c.send("GET", "/api/container-registry", null, null);
    }

    /** Repositories. [GET /api/container-registry/{id}/repositories] */
    public JsonNode repositories(String id) {
        return c.send("GET", "/api/container-registry/" + HiokClient.segment(id) + "/repositories", null, null);
    }

    /** Rotate. [POST /api/container-registry/{id}/credentials/rotate] */
    public JsonNode rotate(String id) {
        return c.send("POST", "/api/container-registry/" + HiokClient.segment(id) + "/credentials/rotate", null, null);
    }

    /** Tags. [GET /api/container-registry/{id}/tags] */
    public JsonNode tags(String id, Object repository) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("repository", repository);
        return c.send("GET", "/api/container-registry/" + HiokClient.segment(id) + "/tags", null, query_);
    }
    public JsonNode tags(String id) {
        return tags(id, null);
    }
}
