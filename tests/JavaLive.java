import cloud.hiok.*;
import com.fasterxml.jackson.databind.JsonNode;
import java.io.*; import java.nio.file.*; import java.security.*; import java.util.*;
public class JavaLive {
  public static void main(String[] a) throws Exception {
    HiokClient c = HiokClient.builder().endpoint(System.getenv().getOrDefault("HIOK_ENDPOINT", "https://test.hiokcloud.com")).token(System.getenv("HIOK_TOKEN")).build();
    System.out.println("key vaults: " + c.api().keyVault().list().size());
    String acct = null;
    for (JsonNode x : c.api().storageAccount().getStorageAccounts().path("data")) if (x.path("name").asText().equals(System.getenv("HIOK_TEST_STORAGE_ACCOUNT"))) acct = x.path("id").asText();
    c.storage().ensureContainer(acct, "sdk-test-java", "blob");
    byte[] data = new byte[20 * 1024 * 1024 + 11]; new SecureRandom().nextBytes(data);
    long t = System.nanoTime(); c.storage().uploadStream(acct, "sdk-test-java", "big/20mb.bin", new ByteArrayInputStream(data), null);
    double up = (System.nanoTime() - t) / 1e9; t = System.nanoTime();
    c.storage().downloadFile(acct, "sdk-test-java", "big/20mb.bin", Path.of("/tmp/hiok-sdk-test.bin"));
    MessageDigest s1 = MessageDigest.getInstance("SHA-256"), s2 = MessageDigest.getInstance("SHA-256");
    System.out.printf("20MB upload %.1fs download %.1fs identical: %s%n", up, (System.nanoTime() - t) / 1e9, Arrays.equals(s1.digest(data), s2.digest(Files.readAllBytes(Path.of("/tmp/hiok-sdk-test.bin")))));
    c.storage().uploadStream(acct, "sdk-test-java", "small.txt", new ByteArrayInputStream("hello from java".getBytes()), "text/plain");
    String key = c.api().storageAccount().getAccessKeys(acct).path("data").path("key1").asText();
    HiokClient k = HiokClient.builder().endpoint(System.getenv().getOrDefault("HIOK_ENDPOINT", "https://test.hiokcloud.com")).storageKey(key).build();
    ByteArrayOutputStream bo = new ByteArrayOutputStream(); k.storage().downloadStream(acct, "sdk-test-java", "small.txt", bo);
    System.out.println("storage key read: " + bo);
    try { k.api().keyVault().list(); System.out.println("BAD"); } catch (HiokException e) { System.out.println("storage key refused elsewhere: " + e.status()); }
    for (JsonNode o : c.storage().list(acct, "sdk-test-java", null)) c.storage().delete(acct, "sdk-test-java", o.path("key").asText());
    System.out.println("after delete: " + c.storage().list(acct, "sdk-test-java", null).size());
    c.api().storageObject().deleteContainer(acct, "sdk-test-java", true);
  }
}
