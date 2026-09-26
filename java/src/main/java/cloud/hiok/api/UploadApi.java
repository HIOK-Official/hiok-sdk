// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package cloud.hiok.api;

import cloud.hiok.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** Upload operations. */
public final class UploadApi {
    private final HiokClient c;
    public UploadApi(HiokClient client) { this.c = client; }

    /** Finalize upload. [POST /api/Upload/finalizeupload] */
    public JsonNode finalizeUpload(Object body) {
        return c.send("POST", "/api/Upload/finalizeupload", body, null);
    }

    /** Initiate upload. [POST /api/Upload/initiateupload] */
    public JsonNode initiateUpload(Map<String, String> form, Map<String, HiokClient.FilePart> files, Object uploadDirPath, Object folderDirPath) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("uploadDirPath", uploadDirPath);
        query_.put("folderDirPath", folderDirPath);
        return c.sendMultipart("POST", "/api/Upload/initiateupload", form, files, query_);
    }
    public JsonNode initiateUpload(Map<String, String> form, Map<String, HiokClient.FilePart> files) {
        return initiateUpload(form, files, null, null);
    }

    /** Upload chunk. [POST /api/Upload/uploadchunk] */
    public JsonNode uploadChunk(Map<String, String> form, Map<String, HiokClient.FilePart> files, Object directoryName, Object chunkindex, Object uploadDirPath, Object folderDirPath) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("directoryName", directoryName);
        query_.put("chunkindex", chunkindex);
        query_.put("uploadDirPath", uploadDirPath);
        query_.put("folderDirPath", folderDirPath);
        return c.sendMultipart("POST", "/api/Upload/uploadchunk", form, files, query_);
    }
    public JsonNode uploadChunk(Map<String, String> form, Map<String, HiokClient.FilePart> files) {
        return uploadChunk(form, files, null, null, null, null);
    }
}
