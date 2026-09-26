// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package cloud.hiok.api;

import cloud.hiok.HiokClient;
import com.fasterxml.jackson.databind.JsonNode;
import java.util.LinkedHashMap;
import java.util.Map;

/** HiokUsers operations. */
public final class HiokUsersApi {
    private final HiokClient c;
    public HiokUsersApi(HiokClient client) { this.c = client; }

    /** Delete user by id. [DELETE /api/HiokUsers/removehiokuser/{emailId}] */
    public JsonNode deleteUserById(String emailId) {
        return c.send("DELETE", "/api/HiokUsers/removehiokuser/" + HiokClient.segment(emailId), null, null);
    }

    /** Forgot password. [POST /api/HiokUsers/forgotpassword] */
    public JsonNode forgotPassword(Object body) {
        return c.send("POST", "/api/HiokUsers/forgotpassword", body, null);
    }

    /** Hiok user by id. [GET /api/HiokUsers/hiokusersbyid/{emailId}] */
    public JsonNode hiokUserById(String emailId) {
        return c.send("GET", "/api/HiokUsers/hiokusersbyid/" + HiokClient.segment(emailId), null, null);
    }

    /** Hiok users. [GET /api/HiokUsers/hiokusers] */
    public JsonNode hiokUsers() {
        return c.send("GET", "/api/HiokUsers/hiokusers", null, null);
    }

    /** Register hiok user. [POST /api/HiokUsers/registerhiokuser] */
    public JsonNode registerHiokUser(Object body) {
        return c.send("POST", "/api/HiokUsers/registerhiokuser", body, null);
    }

    /** Resend verification. [POST /api/HiokUsers/resendverification] */
    public JsonNode resendVerification(Object body) {
        return c.send("POST", "/api/HiokUsers/resendverification", body, null);
    }

    /** Reset password. [POST /api/HiokUsers/resetpassword] */
    public JsonNode resetPassword(Object body) {
        return c.send("POST", "/api/HiokUsers/resetpassword", body, null);
    }

    /** Update user by id. [PUT /api/HiokUsers/hiokuserupdate/{emailId}] */
    public JsonNode updateUserById(String emailId, Object body) {
        return c.send("PUT", "/api/HiokUsers/hiokuserupdate/" + HiokClient.segment(emailId), body, null);
    }

    /** Verify email. [POST /api/HiokUsers/verifyemail] */
    public JsonNode verifyEmail(Object body) {
        return c.send("POST", "/api/HiokUsers/verifyemail", body, null);
    }
}
