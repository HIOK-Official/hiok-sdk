package cloud.hiok;

import com.fasterxml.jackson.databind.JsonNode;
import java.io.IOException;
import java.io.InputStream;
import java.io.OutputStream;
import java.io.UncheckedIOException;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.StandardCopyOption;
import java.security.MessageDigest;
import java.util.ArrayList;
import java.util.Base64;
import java.util.HexFormat;
import java.util.LinkedHashMap;
import java.util.List;
import java.util.Map;
import java.util.UUID;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;
import java.util.concurrent.Future;
import java.util.concurrent.Semaphore;
import java.util.function.LongConsumer;

/**
 * Moving files in and out of storage accounts.
 *
 * <pre>{@code
 * client.storage().uploadFile(accountId, "backups", "2026/db.dump", Path.of("/var/backups/db.dump"));
 * client.storage().downloadFile(accountId, "backups", "2026/db.dump", Path.of("/tmp/db.dump"));
 * client.storage().uploadStream(accountId, "backups", "big.bin", anyInputStream, null);
 * }</pre>
 *
 * A write reaches the region in one message, which caps it at 3 MB, so larger content
 * is staged as 3 MB blocks (several at once) and committed as one object; reads are
 * ranged the same way, so memory stays flat.
 */
public final class StorageTransfer {
    public static final int BLOCK_SIZE = 3 * 1024 * 1024;
    private final HiokClient c;

    StorageTransfer(HiokClient client) { this.c = client; }

    private static String content(String accountId, String container, String key) {
        return "/api/storageaccount/" + HiokClient.segment(accountId) + "/containers/"
                + HiokClient.segment(container) + "/content/" + HiokClient.segment(key, true);
    }

    public JsonNode ensureContainer(String accountId, String name, String kind) {
        try {
            return c.api().storageObject().getContainer(accountId, name).path("data");
        } catch (HiokException e) {
            if (e.status() != 404) throw e;
        }
        return c.api().storageObject().createContainer(accountId, Map.of("name", name, "kind", kind)).path("data");
    }

    public JsonNode list(String accountId, String container, String prefix) {
        return c.api().storageObject().listObjects(accountId, container, prefix, null, 5000).path("data");
    }

    public JsonNode stat(String accountId, String container, String key) {
        return c.api().storageObject().getObject(accountId, container, key).path("data");
    }

    public void delete(String accountId, String container, String key) {
        c.api().storageObject().deleteObject(accountId, container, key);
    }

    public JsonNode uploadFile(String accountId, String container, String key, Path file) {
        try (InputStream in = Files.newInputStream(file)) {
            return uploadStream(accountId, container, key, in, null);
        } catch (IOException e) {
            throw new UncheckedIOException(e);
        }
    }

    public JsonNode uploadStream(String accountId, String container, String key, InputStream source, String contentType) {
        return uploadStream(accountId, container, key, source, contentType, 4, null);
    }

    /** Uploads from any input stream, of known or unknown length. */
    public JsonNode uploadStream(String accountId, String container, String key, InputStream source,
                                 String contentType, int parallelism, LongConsumer progress) {
        byte[] first = readBlock(source);
        if (first.length < BLOCK_SIZE) {
            Map<String, Object> body = new LinkedHashMap<>();
            body.put("key", key);
            body.put("content", Base64.getEncoder().encodeToString(first));
            body.put("isBase64", true);
            body.put("contentType", contentType);
            JsonNode r = c.api().storageObject().putObject(accountId, container, body);
            if (progress != null) progress.accept(first.length);
            return r.path("data");
        }

        String upload = UUID.randomUUID().toString().replace("-", "").substring(0, 12);
        List<String> ids = new ArrayList<>();
        List<Future<?>> running = new ArrayList<>();
        Semaphore gate = new Semaphore(Math.max(1, parallelism));
        ExecutorService pool = Executors.newFixedThreadPool(Math.max(1, parallelism));
        long[] done = {0};
        try {
            byte[] block = first;
            while (block.length > 0) {
                String id = String.format("sdk-%s-%06d", upload, ids.size());
                ids.add(id);
                gate.acquire();
                byte[] payload = block;
                running.add(pool.submit(() -> {
                    try {
                        c.api().storageObject().stageBlock(accountId, container, Map.of(
                                "blobName", key, "blockId", id,
                                "content", Base64.getEncoder().encodeToString(payload), "isBase64", true));
                        synchronized (done) {
                            done[0] += payload.length;
                            if (progress != null) progress.accept(done[0]);
                        }
                    } finally {
                        gate.release();
                    }
                }));
                block = readBlock(source);
            }
            for (Future<?> f : running) f.get();
        } catch (InterruptedException e) {
            Thread.currentThread().interrupt();
            throw new HiokException("Interrupted", 0, null);
        } catch (java.util.concurrent.ExecutionException e) {
            if (e.getCause() instanceof RuntimeException r) throw r;
            throw new HiokException(e.getMessage(), 0, null);
        } finally {
            pool.shutdown();
        }

        Map<String, Object> commit = new LinkedHashMap<>();
        commit.put("blobName", key);
        commit.put("blockIds", ids);
        commit.put("contentType", contentType);
        commit.put("discardStagedBlocks", true);
        return c.api().storageObject().commitBlockList(accountId, container, commit).path("data");
    }

    /** Writes the object to a stream, fetched in 3 MB ranges. */
    public long downloadStream(String accountId, String container, String key, OutputStream destination) {
        long size = stat(accountId, container, key).path("sizeBytes").asLong(0);
        long done = 0;
        try {
            while (done < size) {
                long end = Math.min(done + BLOCK_SIZE, size) - 1;
                byte[] chunk = c.sendRaw("GET", content(accountId, container, key), null, null,
                        Map.of("Range", "bytes=" + done + "-" + end));
                if (chunk.length == 0) break;
                destination.write(chunk);
                done += chunk.length;
            }
        } catch (IOException e) {
            throw new UncheckedIOException(e);
        }
        return done;
    }

    /** Downloads to a file through a temporary name, checking the stored sha256 when there is one. */
    public long downloadFile(String accountId, String container, String key, Path file) {
        try {
            Path parent = file.toAbsolutePath().getParent();
            if (parent != null) Files.createDirectories(parent);
            Path partial = file.resolveSibling(file.getFileName() + ".partial");
            long written;
            try (OutputStream out = Files.newOutputStream(partial)) {
                written = downloadStream(accountId, container, key, out);
            }
            String expected = stat(accountId, container, key).path("contentHash").asText("");
            if (expected.length() == 64) {
                MessageDigest sha = MessageDigest.getInstance("SHA-256");
                try (InputStream in = Files.newInputStream(partial)) {
                    byte[] buf = new byte[1 << 16];
                    for (int n; (n = in.read(buf)) > 0; ) sha.update(buf, 0, n);
                }
                if (!HexFormat.of().formatHex(sha.digest()).equalsIgnoreCase(expected)) {
                    Files.deleteIfExists(partial);
                    throw new HiokException(key + ": downloaded content does not match the stored sha256", 0, null);
                }
            }
            Files.move(partial, file, StandardCopyOption.REPLACE_EXISTING);
            return written;
        } catch (IOException e) {
            throw new UncheckedIOException(e);
        } catch (java.security.NoSuchAlgorithmException e) {
            throw new IllegalStateException(e);
        }
    }

    private static byte[] readBlock(InputStream in) {
        try {
            return in.readNBytes(BLOCK_SIZE);
        } catch (IOException e) {
            throw new UncheckedIOException(e);
        }
    }
}
