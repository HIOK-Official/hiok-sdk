// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package cloud.hiok.api;

import cloud.hiok.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** VmConsole operations. */
public final class VmConsoleApi {
    private final HiokClient c;
    public VmConsoleApi(HiokClient client) { this.c = client; }

    /** Console. [GET /api/VirtualMachine/{id}/console] */
    public JsonNode console(String id) {
        return c.send("GET", "/api/VirtualMachine/" + HiokClient.segment(id) + "/console", null, null);
    }

    /** Console ticket. [GET /api/VirtualMachine/{id}/console-ticket] */
    public JsonNode consoleTicket(String id) {
        return c.send("GET", "/api/VirtualMachine/" + HiokClient.segment(id) + "/console-ticket", null, null);
    }
}
