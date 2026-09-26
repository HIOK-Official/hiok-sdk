// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package cloud.hiok.api;

import cloud.hiok.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** IoTHubDevice operations. */
public final class IoTHubDeviceApi {
    private final HiokClient c;
    public IoTHubDeviceApi(HiokClient client) { this.c = client; }

    /** Get io thub devices. [GET /api/IoTHubDevice/iothub/devices] */
    public JsonNode getIoTHubDevices() {
        return c.send("GET", "/api/IoTHubDevice/iothub/devices", null, null);
    }

    /** Get io thub devices get. [GET /api/IoTHubDevice/iothub/{iotHubId}/devices] */
    public JsonNode getIoTHubDevicesGet(String iotHubId) {
        return c.send("GET", "/api/IoTHubDevice/iothub/" + HiokClient.segment(iotHubId) + "/devices", null, null);
    }
}
