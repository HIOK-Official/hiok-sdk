// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package cloud.hiok.api;

import cloud.hiok.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** DockerImages operations. */
public final class DockerImagesApi {
    private final HiokClient c;
    public DockerImagesApi(HiokClient client) { this.c = client; }

    /** Get image history. [POST /api/DockerImages/imagehistory] */
    public JsonNode getImageHistory(Object body, Object regions) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("regions", regions);
        return c.send("POST", "/api/DockerImages/imagehistory", body, query_);
    }
    public JsonNode getImageHistory(Object body) {
        return getImageHistory(body, null);
    }

    /** Get image informations. [POST /api/DockerImages/inspectimage] */
    public JsonNode getImageInformations(Object body, Object regions) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("regions", regions);
        return c.send("POST", "/api/DockerImages/inspectimage", body, query_);
    }
    public JsonNode getImageInformations(Object body) {
        return getImageInformations(body, null);
    }

    /** List all docker images. [POST /api/DockerImages/listallimages] */
    public JsonNode listAllDockerImages(Object body, Object regions) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("regions", regions);
        return c.send("POST", "/api/DockerImages/listallimages", body, query_);
    }
    public JsonNode listAllDockerImages(Object body) {
        return listAllDockerImages(body, null);
    }

    /** List all docker public images. [POST /api/DockerImages/listallpublicimages] */
    public JsonNode listAllDockerPublicImages(Object body, Object isOfficialImage) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("isOfficialImage", isOfficialImage);
        return c.send("POST", "/api/DockerImages/listallpublicimages", body, query_);
    }
    public JsonNode listAllDockerPublicImages(Object body) {
        return listAllDockerPublicImages(body, null);
    }

    /** Search docker image. [POST /api/DockerImages/searchimage] */
    public JsonNode searchDockerImage(Object body, Object regions) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("regions", regions);
        return c.send("POST", "/api/DockerImages/searchimage", body, query_);
    }
    public JsonNode searchDockerImage(Object body) {
        return searchDockerImage(body, null);
    }
}
