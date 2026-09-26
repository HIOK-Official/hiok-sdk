// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package com.hiokcloud.api;

import com.hiokcloud.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** Storage operations. */
public final class StorageApi {
    private final HiokClient c;
    public StorageApi(HiokClient client) { this.c = client; }

    /** Bucket filesand directories. [POST /api/Storage/bucketfilesanddirectories] */
    public JsonNode bucketFilesandDirectories(Object directory, Object type) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("directory", directory);
        query_.put("type", type);
        return c.send("POST", "/api/Storage/bucketfilesanddirectories", null, query_);
    }
    public JsonNode bucketFilesandDirectories() {
        return bucketFilesandDirectories(null, null);
    }

    /** Create file. [POST /api/Storage/createfile] */
    public JsonNode createFile(Object path, Object filename) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("path", path);
        query_.put("filename", filename);
        return c.send("POST", "/api/Storage/createfile", null, query_);
    }
    public JsonNode createFile() {
        return createFile(null, null);
    }

    /** Create folder. [POST /api/Storage/createfolder] */
    public JsonNode createFolder(Object path, Object foldername) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("path", path);
        query_.put("foldername", foldername);
        return c.send("POST", "/api/Storage/createfolder", null, query_);
    }
    public JsonNode createFolder() {
        return createFolder(null, null);
    }

    /** Delete file. [POST /api/Storage/deletefile] */
    public JsonNode deleteFile(Object path) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("path", path);
        return c.send("POST", "/api/Storage/deletefile", null, query_);
    }
    public JsonNode deleteFile() {
        return deleteFile(null);
    }

    /** Delete folder. [POST /api/Storage/deletefolder] */
    public JsonNode deleteFolder(Object path) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("path", path);
        return c.send("POST", "/api/Storage/deletefolder", null, query_);
    }
    public JsonNode deleteFolder() {
        return deleteFolder(null);
    }

    /** File copy to. [POST /api/Storage/filecopyto] */
    public JsonNode fileCopyTo(Object sourcePath, Object destinationPath) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("sourcePath", sourcePath);
        query_.put("destinationPath", destinationPath);
        return c.send("POST", "/api/Storage/filecopyto", null, query_);
    }
    public JsonNode fileCopyTo() {
        return fileCopyTo(null, null);
    }

    /** File move to. [POST /api/Storage/filemoveto] */
    public JsonNode fileMoveTo(Object sourcePath, Object destinationPath) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("sourcePath", sourcePath);
        query_.put("destinationPath", destinationPath);
        return c.send("POST", "/api/Storage/filemoveto", null, query_);
    }
    public JsonNode fileMoveTo() {
        return fileMoveTo(null, null);
    }

    /** Folder copy to. [POST /api/Storage/foldercopyto] */
    public JsonNode folderCopyTo(Object sourcePath, Object destinationPath) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("sourcePath", sourcePath);
        query_.put("destinationPath", destinationPath);
        return c.send("POST", "/api/Storage/foldercopyto", null, query_);
    }
    public JsonNode folderCopyTo() {
        return folderCopyTo(null, null);
    }

    /** Folder move to. [POST /api/Storage/foldermoveto] */
    public JsonNode folderMoveTo(Object sourcePath, Object destinationPath) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("sourcePath", sourcePath);
        query_.put("destinationPath", destinationPath);
        return c.send("POST", "/api/Storage/foldermoveto", null, query_);
    }
    public JsonNode folderMoveTo() {
        return folderMoveTo(null, null);
    }

    /** Get all directories. [POST /api/Storage/listdirectories] */
    public JsonNode getAllDirectories(Object directory) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("directory", directory);
        return c.send("POST", "/api/Storage/listdirectories", null, query_);
    }
    public JsonNode getAllDirectories() {
        return getAllDirectories(null);
    }

    /** Get all directories and files. [POST /api/Storage/directoriesandfiles] */
    public JsonNode getAllDirectoriesAndFiles(Object directory, Object type) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("directory", directory);
        query_.put("type", type);
        return c.send("POST", "/api/Storage/directoriesandfiles", null, query_);
    }
    public JsonNode getAllDirectoriesAndFiles() {
        return getAllDirectoriesAndFiles(null, null);
    }

    /** Get all files. [POST /api/Storage/listfiles] */
    public JsonNode getAllFiles(Object directory, Object type) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("directory", directory);
        query_.put("type", type);
        return c.send("POST", "/api/Storage/listfiles", null, query_);
    }
    public JsonNode getAllFiles() {
        return getAllFiles(null, null);
    }

    /** Get all filesand directories. [POST /api/Storage/listfilesanddirectories] */
    public JsonNode getAllFilesandDirectories(Object directory, Object type) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("directory", directory);
        query_.put("type", type);
        return c.send("POST", "/api/Storage/listfilesanddirectories", null, query_);
    }
    public JsonNode getAllFilesandDirectories() {
        return getAllFilesandDirectories(null, null);
    }

    /** Get root dir. [GET /api/Storage/rootdir] */
    public JsonNode getRootDir() {
        return c.send("GET", "/api/Storage/rootdir", null, null);
    }

    /** Rename file. [POST /api/Storage/renamefile] */
    public JsonNode renameFile(Object path, Object rename) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("path", path);
        query_.put("rename", rename);
        return c.send("POST", "/api/Storage/renamefile", null, query_);
    }
    public JsonNode renameFile() {
        return renameFile(null, null);
    }

    /** Rename folder. [POST /api/Storage/renamefolder] */
    public JsonNode renameFolder(Object directory, Object rename) {
        Map<String, Object> query_ = new LinkedHashMap<>();
        query_.put("directory", directory);
        query_.put("rename", rename);
        return c.send("POST", "/api/Storage/renamefolder", null, query_);
    }
    public JsonNode renameFolder() {
        return renameFolder(null, null);
    }
}
