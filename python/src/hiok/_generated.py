"""Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py."""
from __future__ import annotations

from typing import Any, TYPE_CHECKING

if TYPE_CHECKING:
    from .client import HiokClient


class AccessControlApi:
    """AccessControl operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def add_role_assignment(self, resource_type: str, resource_id: str, body: Any = None) -> Any:
        """Add role assignment.  [POST /api/access-control/{resourceType}/{resourceId}/role-assignments]"""
        return self._c.request("POST", "/api/access-control/" + self._c._seg(resource_type) + "/" + self._c._seg(resource_id) + "/role-assignments", body, query=None)

    def check_access(self, resource_type: str, resource_id: str, *, principal_email: Any = None) -> Any:
        """Check access.  [GET /api/access-control/{resourceType}/{resourceId}/check-access]"""
        return self._c.request("GET", "/api/access-control/" + self._c._seg(resource_type) + "/" + self._c._seg(resource_id) + "/check-access", None, query={"principalEmail": principal_email})

    def list_all_assignments(self, *, principal_email: Any = None, role_id: Any = None) -> Any:
        """List all assignments.  [GET /api/access-control/assignments]"""
        return self._c.request("GET", "/api/access-control/assignments", None, query={"principalEmail": principal_email, "roleId": role_id})

    def list_principals(self, *, q: Any = None) -> Any:
        """List principals.  [GET /api/access-control/principals]"""
        return self._c.request("GET", "/api/access-control/principals", None, query={"q": q})

    def list_role_assignments(self, resource_type: str, resource_id: str, *, include_inherited: Any = None) -> Any:
        """List role assignments.  [GET /api/access-control/{resourceType}/{resourceId}/role-assignments]"""
        return self._c.request("GET", "/api/access-control/" + self._c._seg(resource_type) + "/" + self._c._seg(resource_id) + "/role-assignments", None, query={"includeInherited": include_inherited})

    def list_roles(self, *, category: Any = None) -> Any:
        """List roles.  [GET /api/access-control/roles]"""
        return self._c.request("GET", "/api/access-control/roles", None, query={"category": category})

    def register_scope(self, resource_type: str, resource_id: str, body: Any = None) -> Any:
        """Register scope.  [PUT /api/access-control/{resourceType}/{resourceId}/scope]"""
        return self._c.request("PUT", "/api/access-control/" + self._c._seg(resource_type) + "/" + self._c._seg(resource_id) + "/scope", body, query=None)

    def remove_assignment(self, assignment_id: str) -> Any:
        """Remove assignment.  [DELETE /api/access-control/assignments/{assignmentId}]"""
        return self._c.request("DELETE", "/api/access-control/assignments/" + self._c._seg(assignment_id), None, query=None)

    def remove_role_assignment(self, resource_type: str, resource_id: str, assignment_id: str) -> Any:
        """Remove role assignment.  [DELETE /api/access-control/{resourceType}/{resourceId}/role-assignments/{assignmentId}]"""
        return self._c.request("DELETE", "/api/access-control/" + self._c._seg(resource_type) + "/" + self._c._seg(resource_id) + "/role-assignments/" + self._c._seg(assignment_id), None, query=None)

    def scope_chain(self, resource_type: str, resource_id: str) -> Any:
        """Scope chain.  [GET /api/access-control/{resourceType}/{resourceId}/scope-chain]"""
        return self._c.request("GET", "/api/access-control/" + self._c._seg(resource_type) + "/" + self._c._seg(resource_id) + "/scope-chain", None, query=None)

class AccountApi:
    """Account operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def api_keys(self) -> Any:
        """Api keys.  [GET /api/account/api-keys]"""
        return self._c.request("GET", "/api/account/api-keys", None, query=None)

    def change_password(self, body: Any = None) -> Any:
        """Change password.  [POST /api/account/password]"""
        return self._c.request("POST", "/api/account/password", body, query=None)

    def create_api_key(self, body: Any = None) -> Any:
        """Create api key.  [POST /api/account/api-keys]"""
        return self._c.request("POST", "/api/account/api-keys", body, query=None)

    def delete_account(self, body: Any = None) -> Any:
        """Delete account.  [POST /api/account/delete]"""
        return self._c.request("POST", "/api/account/delete", body, query=None)

    def delete_tenant(self, body: Any = None) -> Any:
        """Delete tenant.  [POST /api/account/tenants/delete]"""
        return self._c.request("POST", "/api/account/tenants/delete", body, query=None)

    def deletion_plan(self) -> Any:
        """Deletion plan.  [GET /api/account/deletion]"""
        return self._c.request("GET", "/api/account/deletion", None, query=None)

    def deletion_status(self) -> Any:
        """Deletion status.  [GET /api/account/delete/status]"""
        return self._c.request("GET", "/api/account/delete/status", None, query=None)

    def export(self, *, format_: Any = None) -> Any:
        """Export.  [GET /api/account/export]"""
        return self._c.request("GET", "/api/account/export", None, query={"format": format_})

    def get_preferences(self) -> Any:
        """Get preferences.  [GET /api/account/preferences]"""
        return self._c.request("GET", "/api/account/preferences", None, query=None)

    def revoke_api_key(self, id_: str) -> Any:
        """Revoke api key.  [DELETE /api/account/api-keys/{id}]"""
        return self._c.request("DELETE", "/api/account/api-keys/" + self._c._seg(id_), None, query=None)

    def save_preferences(self, body: Any = None) -> Any:
        """Save preferences.  [PUT /api/account/preferences]"""
        return self._c.request("PUT", "/api/account/preferences", body, query=None)

    def tenant_deletion_plan(self, *, account: Any = None) -> Any:
        """Tenant deletion plan.  [GET /api/account/tenants/deletion]"""
        return self._c.request("GET", "/api/account/tenants/deletion", None, query={"account": account})

    def tenant_deletion_status(self, *, account: Any = None) -> Any:
        """Tenant deletion status.  [GET /api/account/tenants/delete/status]"""
        return self._c.request("GET", "/api/account/tenants/delete/status", None, query={"account": account})

class AdminApi:
    """Admin operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def grant(self, body: Any = None) -> Any:
        """Grant.  [POST /api/Admin/access]"""
        return self._c.request("POST", "/api/Admin/access", body, query=None)

    def list_grants(self) -> Any:
        """List grants.  [GET /api/Admin/access]"""
        return self._c.request("GET", "/api/Admin/access", None, query=None)

    def me(self) -> Any:
        """Me.  [GET /api/Admin/me]"""
        return self._c.request("GET", "/api/Admin/me", None, query=None)

    def revoke(self, id_: str) -> Any:
        """Revoke.  [DELETE /api/Admin/access/{id}]"""
        return self._c.request("DELETE", "/api/Admin/access/" + self._c._seg(id_), None, query=None)

class AdminDataApi:
    """AdminData operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def resources(self, *, search: Any = None, type_: Any = None) -> Any:
        """Resources.  [GET /api/admin/resources]"""
        return self._c.request("GET", "/api/admin/resources", None, query={"search": search, "type": type_})

    def subscriptions(self, *, search: Any = None) -> Any:
        """Subscriptions.  [GET /api/admin/subscriptions]"""
        return self._c.request("GET", "/api/admin/subscriptions", None, query={"search": search})

    def table_rows(self, table: str, *, search: Any = None, limit: Any = None) -> Any:
        """Table rows.  [GET /api/admin/database/{table}]"""
        return self._c.request("GET", "/api/admin/database/" + self._c._seg(table), None, query={"search": search, "limit": limit})

    def tables(self) -> Any:
        """Tables.  [GET /api/admin/database/tables]"""
        return self._c.request("GET", "/api/admin/database/tables", None, query=None)

class AdminDnsApi:
    """AdminDns operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def delete(self, id_: str) -> Any:
        """Delete.  [DELETE /api/admin/dns/records/{id}]"""
        return self._c.request("DELETE", "/api/admin/dns/records/" + self._c._seg(id_), None, query=None)

    def mail_health(self) -> Any:
        """Mail health.  [GET /api/admin/dns/mail-health]"""
        return self._c.request("GET", "/api/admin/dns/mail-health", None, query=None)

    def records(self, *, q: Any = None) -> Any:
        """Records.  [GET /api/admin/dns/records]"""
        return self._c.request("GET", "/api/admin/dns/records", None, query={"q": q})

    def upsert(self, body: Any = None) -> Any:
        """Upsert.  [POST /api/admin/dns/records]"""
        return self._c.request("POST", "/api/admin/dns/records", body, query=None)

class AdminInfrastructureApi:
    """AdminInfrastructure operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def bridges(self, *, region: Any = None) -> Any:
        """Bridges.  [GET /api/admin/infrastructure/bridges]"""
        return self._c.request("GET", "/api/admin/infrastructure/bridges", None, query={"region": region})

    def containers(self, *, region: Any = None) -> Any:
        """Containers.  [GET /api/admin/infrastructure/containers]"""
        return self._c.request("GET", "/api/admin/infrastructure/containers", None, query={"region": region})

    def delete_bridge(self, name: str, *, region: Any = None) -> Any:
        """Delete bridge.  [DELETE /api/admin/infrastructure/bridges/{name}]"""
        return self._c.request("DELETE", "/api/admin/infrastructure/bridges/" + self._c._seg(name), None, query={"region": region})

    def delete_container(self, id_: str, *, region: Any = None) -> Any:
        """Delete container.  [DELETE /api/admin/infrastructure/containers/{id}]"""
        return self._c.request("DELETE", "/api/admin/infrastructure/containers/" + self._c._seg(id_), None, query={"region": region})

    def delete_image(self, id_: str, *, region: Any = None) -> Any:
        """Delete image.  [DELETE /api/admin/infrastructure/images/{id}]"""
        return self._c.request("DELETE", "/api/admin/infrastructure/images/" + self._c._seg(id_), None, query={"region": region})

    def delete_network(self, id_: str, *, region: Any = None) -> Any:
        """Delete network.  [DELETE /api/admin/infrastructure/networks/{id}]"""
        return self._c.request("DELETE", "/api/admin/infrastructure/networks/" + self._c._seg(id_), None, query={"region": region})

    def delete_vm(self, name: str, *, region: Any = None) -> Any:
        """Delete vm.  [DELETE /api/admin/infrastructure/vms/{name}]"""
        return self._c.request("DELETE", "/api/admin/infrastructure/vms/" + self._c._seg(name), None, query={"region": region})

    def delete_volume(self, name: str, *, region: Any = None) -> Any:
        """Delete volume.  [DELETE /api/admin/infrastructure/volumes/{name}]"""
        return self._c.request("DELETE", "/api/admin/infrastructure/volumes/" + self._c._seg(name), None, query={"region": region})

    def dns_janitor(self, *, dry_run: Any = None) -> Any:
        """Dns janitor.  [POST /api/admin/infrastructure/dns-janitor]"""
        return self._c.request("POST", "/api/admin/infrastructure/dns-janitor", None, query={"dryRun": dry_run})

    def firewall(self, *, region: Any = None, chain: Any = None) -> Any:
        """Firewall.  [GET /api/admin/infrastructure/firewall]"""
        return self._c.request("GET", "/api/admin/infrastructure/firewall", None, query={"region": region, "chain": chain})

    def flows(self, *, region: Any = None, bridge: Any = None) -> Any:
        """Flows.  [GET /api/admin/infrastructure/flows]"""
        return self._c.request("GET", "/api/admin/infrastructure/flows", None, query={"region": region, "bridge": bridge})

    def images(self, *, region: Any = None) -> Any:
        """Images.  [GET /api/admin/infrastructure/images]"""
        return self._c.request("GET", "/api/admin/infrastructure/images", None, query={"region": region})

    def metrics(self, *, region: Any = None) -> Any:
        """Metrics.  [GET /api/admin/infrastructure/metrics]"""
        return self._c.request("GET", "/api/admin/infrastructure/metrics", None, query={"region": region})

    def networks(self, *, region: Any = None) -> Any:
        """Networks.  [GET /api/admin/infrastructure/networks]"""
        return self._c.request("GET", "/api/admin/infrastructure/networks", None, query={"region": region})

    def virtual_machines(self, *, region: Any = None) -> Any:
        """Virtual machines.  [GET /api/admin/infrastructure/vms]"""
        return self._c.request("GET", "/api/admin/infrastructure/vms", None, query={"region": region})

    def volumes(self, *, region: Any = None) -> Any:
        """Volumes.  [GET /api/admin/infrastructure/volumes]"""
        return self._c.request("GET", "/api/admin/infrastructure/volumes", None, query={"region": region})

class AdvisorApi:
    """Advisor operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def create_tasks(self, body: Any = None) -> Any:
        """Create tasks.  [POST /api/advisor/tasks]"""
        return self._c.request("POST", "/api/advisor/tasks", body, query=None)

    def delete_task(self, id_: str) -> Any:
        """Delete task.  [DELETE /api/advisor/tasks/{id}]"""
        return self._c.request("DELETE", "/api/advisor/tasks/" + self._c._seg(id_), None, query=None)

    def report(self, *, subscription_id: Any = None) -> Any:
        """Report.  [GET /api/advisor/report]"""
        return self._c.request("GET", "/api/advisor/report", None, query={"subscriptionId": subscription_id})

    def restore(self, id_: str) -> Any:
        """Restore.  [DELETE /api/advisor/suppressions/{id}]"""
        return self._c.request("DELETE", "/api/advisor/suppressions/" + self._c._seg(id_), None, query=None)

    def suppress(self, body: Any = None) -> Any:
        """Suppress.  [POST /api/advisor/suppressions]"""
        return self._c.request("POST", "/api/advisor/suppressions", body, query=None)

    def tasks(self) -> Any:
        """Tasks.  [GET /api/advisor/tasks]"""
        return self._c.request("GET", "/api/advisor/tasks", None, query=None)

    def update_task(self, id_: str, body: Any = None) -> Any:
        """Update task.  [PATCH /api/advisor/tasks/{id}]"""
        return self._c.request("PATCH", "/api/advisor/tasks/" + self._c._seg(id_), body, query=None)

class AnalyticsApi:
    """Analytics operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def attach_v_net(self, id_: str) -> Any:
        """Attach vnet.  [POST /api/Analytics/{id}/vnet/attach]"""
        return self._c.request("POST", "/api/Analytics/" + self._c._seg(id_) + "/vnet/attach", None, query=None)

    def columns(self, id_: str, database: str, table: str) -> Any:
        """Columns.  [GET /api/Analytics/{id}/tables/{database}/{table}/columns]"""
        return self._c.request("GET", "/api/Analytics/" + self._c._seg(id_) + "/tables/" + self._c._seg(database) + "/" + self._c._seg(table) + "/columns", None, query=None)

    def connection(self, id_: str) -> Any:
        """Connection.  [GET /api/Analytics/{id}/connection]"""
        return self._c.request("GET", "/api/Analytics/" + self._c._seg(id_) + "/connection", None, query=None)

    def create(self, body: Any = None) -> Any:
        """Create.  [POST /api/Analytics]"""
        return self._c.request("POST", "/api/Analytics", body, query=None)

    def delete(self, id_: str) -> Any:
        """Delete.  [DELETE /api/Analytics/{id}]"""
        return self._c.request("DELETE", "/api/Analytics/" + self._c._seg(id_), None, query=None)

    def detach_v_net(self, id_: str) -> Any:
        """Detach vnet.  [POST /api/Analytics/{id}/vnet/detach]"""
        return self._c.request("POST", "/api/Analytics/" + self._c._seg(id_) + "/vnet/detach", None, query=None)

    def get(self, id_: str) -> Any:
        """Get.  [GET /api/Analytics/{id}]"""
        return self._c.request("GET", "/api/Analytics/" + self._c._seg(id_), None, query=None)

    def list(self) -> Any:
        """List.  [GET /api/Analytics]"""
        return self._c.request("GET", "/api/Analytics", None, query=None)

    def query(self, id_: str, body: Any = None) -> Any:
        """Query.  [POST /api/Analytics/{id}/query]"""
        return self._c.request("POST", "/api/Analytics/" + self._c._seg(id_) + "/query", body, query=None)

    def start(self, id_: str) -> Any:
        """Start.  [POST /api/Analytics/{id}/start]"""
        return self._c.request("POST", "/api/Analytics/" + self._c._seg(id_) + "/start", None, query=None)

    def stop(self, id_: str) -> Any:
        """Stop.  [POST /api/Analytics/{id}/stop]"""
        return self._c.request("POST", "/api/Analytics/" + self._c._seg(id_) + "/stop", None, query=None)

    def tables(self, id_: str) -> Any:
        """Tables.  [GET /api/Analytics/{id}/tables]"""
        return self._c.request("GET", "/api/Analytics/" + self._c._seg(id_) + "/tables", None, query=None)

class ApiManagementApi:
    """ApiManagement operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def analytics(self, api_id: str, *, hours: Any = None) -> Any:
        """Analytics.  [GET /api/apim/apis/{apiId}/analytics]"""
        return self._c.request("GET", "/api/apim/apis/" + self._c._seg(api_id) + "/analytics", None, query={"hours": hours})

    def create_api(self, body: Any = None) -> Any:
        """Create api.  [POST /api/apim/apis]"""
        return self._c.request("POST", "/api/apim/apis", body, query=None)

    def create_operation(self, api_id: str, body: Any = None) -> Any:
        """Create operation.  [POST /api/apim/apis/{apiId}/operations]"""
        return self._c.request("POST", "/api/apim/apis/" + self._c._seg(api_id) + "/operations", body, query=None)

    def create_policy(self, api_id: str, body: Any = None) -> Any:
        """Create policy.  [POST /api/apim/apis/{apiId}/policies]"""
        return self._c.request("POST", "/api/apim/apis/" + self._c._seg(api_id) + "/policies", body, query=None)

    def create_product(self, body: Any = None) -> Any:
        """Create product.  [POST /api/apim/products]"""
        return self._c.request("POST", "/api/apim/products", body, query=None)

    def create_sub(self, body: Any = None) -> Any:
        """Create sub.  [POST /api/apim/subscriptions]"""
        return self._c.request("POST", "/api/apim/subscriptions", body, query=None)

    def delete_api(self, id_: str) -> Any:
        """Delete api.  [DELETE /api/apim/apis/{id}]"""
        return self._c.request("DELETE", "/api/apim/apis/" + self._c._seg(id_), None, query=None)

    def delete_operation(self, id_: str) -> Any:
        """Delete operation.  [DELETE /api/apim/operations/{id}]"""
        return self._c.request("DELETE", "/api/apim/operations/" + self._c._seg(id_), None, query=None)

    def delete_policy(self, id_: str) -> Any:
        """Delete policy.  [DELETE /api/apim/policies/{id}]"""
        return self._c.request("DELETE", "/api/apim/policies/" + self._c._seg(id_), None, query=None)

    def delete_product(self, id_: str) -> Any:
        """Delete product.  [DELETE /api/apim/products/{id}]"""
        return self._c.request("DELETE", "/api/apim/products/" + self._c._seg(id_), None, query=None)

    def delete_sub(self, id_: str) -> Any:
        """Delete sub.  [DELETE /api/apim/subscriptions/{id}]"""
        return self._c.request("DELETE", "/api/apim/subscriptions/" + self._c._seg(id_), None, query=None)

    def gateway(self, api_path: str, rest: str) -> Any:
        """Gateway.  [GET /api/apim/gateway/{apiPath}/{rest}]"""
        return self._c.request("GET", "/api/apim/gateway/" + self._c._seg(api_path) + "/" + self._c._seg(rest), None, query=None)

    def gateway_delete(self, api_path: str, rest: str) -> Any:
        """Gateway delete.  [DELETE /api/apim/gateway/{apiPath}/{rest}]"""
        return self._c.request("DELETE", "/api/apim/gateway/" + self._c._seg(api_path) + "/" + self._c._seg(rest), None, query=None)

    def gateway_post(self, api_path: str, rest: str) -> Any:
        """Gateway post.  [POST /api/apim/gateway/{apiPath}/{rest}]"""
        return self._c.request("POST", "/api/apim/gateway/" + self._c._seg(api_path) + "/" + self._c._seg(rest), None, query=None)

    def gateway_put(self, api_path: str, rest: str) -> Any:
        """Gateway put.  [PUT /api/apim/gateway/{apiPath}/{rest}]"""
        return self._c.request("PUT", "/api/apim/gateway/" + self._c._seg(api_path) + "/" + self._c._seg(rest), None, query=None)

    def list_apis(self) -> Any:
        """List apis.  [GET /api/apim/apis]"""
        return self._c.request("GET", "/api/apim/apis", None, query=None)

    def list_operations(self, api_id: str) -> Any:
        """List operations.  [GET /api/apim/apis/{apiId}/operations]"""
        return self._c.request("GET", "/api/apim/apis/" + self._c._seg(api_id) + "/operations", None, query=None)

    def list_policies(self, api_id: str) -> Any:
        """List policies.  [GET /api/apim/apis/{apiId}/policies]"""
        return self._c.request("GET", "/api/apim/apis/" + self._c._seg(api_id) + "/policies", None, query=None)

    def list_products(self) -> Any:
        """List products.  [GET /api/apim/products]"""
        return self._c.request("GET", "/api/apim/products", None, query=None)

    def list_subs(self) -> Any:
        """List subs.  [GET /api/apim/subscriptions]"""
        return self._c.request("GET", "/api/apim/subscriptions", None, query=None)

    def regen_sub_key(self, id_: str, *, which: Any = None) -> Any:
        """Regen sub key.  [POST /api/apim/subscriptions/{id}/regenerate-key]"""
        return self._c.request("POST", "/api/apim/subscriptions/" + self._c._seg(id_) + "/regenerate-key", None, query={"which": which})

    def update_operation(self, id_: str, body: Any = None) -> Any:
        """Update operation.  [PUT /api/apim/operations/{id}]"""
        return self._c.request("PUT", "/api/apim/operations/" + self._c._seg(id_), body, query=None)

class AssistantApi:
    """Assistant operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def act(self, body: Any = None) -> Any:
        """Act.  [POST /api/assistant/act]"""
        return self._c.request("POST", "/api/assistant/act", body, query=None)

    def ask(self, body: Any = None) -> Any:
        """Ask.  [POST /api/assistant/ask]"""
        return self._c.request("POST", "/api/assistant/ask", body, query=None)

    def findings(self) -> Any:
        """Findings.  [GET /api/assistant/findings]"""
        return self._c.request("GET", "/api/assistant/findings", None, query=None)

    def stream(self) -> Any:
        """Stream.  [POST /api/assistant/stream]"""
        return self._c.request("POST", "/api/assistant/stream", None, query=None)

class BastionApi:
    """Bastion operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def create(self, body: Any = None) -> Any:
        """Create.  [POST /api/Bastion]"""
        return self._c.request("POST", "/api/Bastion", body, query=None)

    def delete(self, id_: str) -> Any:
        """Delete.  [DELETE /api/Bastion/{id}]"""
        return self._c.request("DELETE", "/api/Bastion/" + self._c._seg(id_), None, query=None)

    def end_session(self, id_: str, session_id: str) -> Any:
        """End session.  [DELETE /api/Bastion/{id}/sessions/{sessionId}]"""
        return self._c.request("DELETE", "/api/Bastion/" + self._c._seg(id_) + "/sessions/" + self._c._seg(session_id), None, query=None)

    def get(self, id_: str) -> Any:
        """Get.  [GET /api/Bastion/{id}]"""
        return self._c.request("GET", "/api/Bastion/" + self._c._seg(id_), None, query=None)

    def list(self) -> Any:
        """List.  [GET /api/Bastion]"""
        return self._c.request("GET", "/api/Bastion", None, query=None)

    def list_sessions(self, id_: str, *, limit: Any = None) -> Any:
        """List sessions.  [GET /api/Bastion/{id}/sessions]"""
        return self._c.request("GET", "/api/Bastion/" + self._c._seg(id_) + "/sessions", None, query={"limit": limit})

    def refresh(self, id_: str) -> Any:
        """Refresh.  [POST /api/Bastion/{id}/refresh]"""
        return self._c.request("POST", "/api/Bastion/" + self._c._seg(id_) + "/refresh", None, query=None)

    def start_session(self, id_: str, body: Any = None) -> Any:
        """Start session.  [POST /api/Bastion/{id}/sessions]"""
        return self._c.request("POST", "/api/Bastion/" + self._c._seg(id_) + "/sessions", body, query=None)

class BillingWebhookApi:
    """BillingWebhook operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def receive(self, provider: str) -> Any:
        """Receive.  [POST /api/billing/webhook/{provider}]"""
        return self._c.request("POST", "/api/billing/webhook/" + self._c._seg(provider), None, query=None)

class CacheApi:
    """Cache operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def add_region(self, id_: str, body: Any = None) -> Any:
        """Add region.  [POST /api/Cache/{id}/regions]"""
        return self._c.request("POST", "/api/Cache/" + self._c._seg(id_) + "/regions", body, query=None)

    def command(self, id_: str, body: Any = None) -> Any:
        """Command.  [POST /api/Cache/{id}/command]"""
        return self._c.request("POST", "/api/Cache/" + self._c._seg(id_) + "/command", body, query=None)

    def create(self, body: Any = None) -> Any:
        """Create.  [POST /api/Cache]"""
        return self._c.request("POST", "/api/Cache", body, query=None)

    def delete(self, id_: str) -> Any:
        """Delete.  [DELETE /api/Cache/{id}]"""
        return self._c.request("DELETE", "/api/Cache/" + self._c._seg(id_), None, query=None)

    def get(self, id_: str) -> Any:
        """Get.  [GET /api/Cache/{id}]"""
        return self._c.request("GET", "/api/Cache/" + self._c._seg(id_), None, query=None)

    def keys(self, id_: str) -> Any:
        """Keys.  [GET /api/Cache/{id}/keys]"""
        return self._c.request("GET", "/api/Cache/" + self._c._seg(id_) + "/keys", None, query=None)

    def list(self) -> Any:
        """List.  [GET /api/Cache]"""
        return self._c.request("GET", "/api/Cache", None, query=None)

    def logs(self, id_: str, *, region: Any = None, tail: Any = None) -> Any:
        """Logs.  [GET /api/Cache/{id}/logs]"""
        return self._c.request("GET", "/api/Cache/" + self._c._seg(id_) + "/logs", None, query={"region": region, "tail": tail})

    def metrics(self, id_: str, *, hours: Any = None, region: Any = None) -> Any:
        """Metrics.  [GET /api/Cache/{id}/metrics]"""
        return self._c.request("GET", "/api/Cache/" + self._c._seg(id_) + "/metrics", None, query={"hours": hours, "region": region})

    def remove_region(self, id_: str, region: str) -> Any:
        """Remove region.  [DELETE /api/Cache/{id}/regions/{region}]"""
        return self._c.request("DELETE", "/api/Cache/" + self._c._seg(id_) + "/regions/" + self._c._seg(region), None, query=None)

    def rotate(self, id_: str) -> Any:
        """Rotate.  [POST /api/Cache/{id}/keys/rotate]"""
        return self._c.request("POST", "/api/Cache/" + self._c._seg(id_) + "/keys/rotate", None, query=None)

    def stats(self, id_: str, *, region: Any = None) -> Any:
        """Stats.  [GET /api/Cache/{id}/stats]"""
        return self._c.request("GET", "/api/Cache/" + self._c._seg(id_) + "/stats", None, query={"region": region})

class CardsApi:
    """Cards operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def complete(self, body: Any = None) -> Any:
        """Complete.  [POST /api/billing/cards/complete]"""
        return self._c.request("POST", "/api/billing/cards/complete", body, query=None)

    def list(self) -> Any:
        """List.  [GET /api/billing/cards]"""
        return self._c.request("GET", "/api/billing/cards", None, query=None)

    def providers(self) -> Any:
        """Providers.  [GET /api/billing/cards/providers]"""
        return self._c.request("GET", "/api/billing/cards/providers", None, query=None)

    def remove(self, id_: str) -> Any:
        """Remove.  [DELETE /api/billing/cards/{id}]"""
        return self._c.request("DELETE", "/api/billing/cards/" + self._c._seg(id_), None, query=None)

    def setup(self, body: Any = None) -> Any:
        """Setup.  [POST /api/billing/cards/setup]"""
        return self._c.request("POST", "/api/billing/cards/setup", body, query=None)

class CloudShellApi:
    """CloudShell operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def end(self) -> Any:
        """End.  [DELETE /api/cloudshell/session]"""
        return self._c.request("DELETE", "/api/cloudshell/session", None, query=None)

    def session(self) -> Any:
        """Session.  [GET /api/cloudshell/session]"""
        return self._c.request("GET", "/api/cloudshell/session", None, query=None)

    def status(self) -> Any:
        """Status.  [GET /api/cloudshell/status]"""
        return self._c.request("GET", "/api/cloudshell/status", None, query=None)

class CloudSubscriptionApi:
    """CloudSubscription operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def add_payment(self, body: Any = None) -> Any:
        """Add payment.  [POST /api/cloudsubscription/payment-methods]"""
        return self._c.request("POST", "/api/cloudsubscription/payment-methods", body, query=None)

    def create(self, body: Any = None) -> Any:
        """Create.  [POST /api/cloudsubscription]"""
        return self._c.request("POST", "/api/cloudsubscription", body, query=None)

    def delete(self, id_: str) -> Any:
        """Delete.  [DELETE /api/cloudsubscription/{id}]"""
        return self._c.request("DELETE", "/api/cloudsubscription/" + self._c._seg(id_), None, query=None)

    def list(self) -> Any:
        """List.  [GET /api/cloudsubscription]"""
        return self._c.request("GET", "/api/cloudsubscription", None, query=None)

    def payment_methods(self) -> Any:
        """Payment methods.  [GET /api/cloudsubscription/payment-methods]"""
        return self._c.request("GET", "/api/cloudsubscription/payment-methods", None, query=None)

class CommonServicesApi:
    """CommonServices operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def get_random_string(self, *, length: Any = None) -> Any:
        """Get random string.  [GET /api/CommonServices/randomstring]"""
        return self._c.request("GET", "/api/CommonServices/randomstring", None, query={"length": length})

class CommunicationApi:
    """Communication operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def add_domain(self, id_: str, body: Any = None) -> Any:
        """Add domain.  [POST /api/Communication/services/{id}/domains]"""
        return self._c.request("POST", "/api/Communication/services/" + self._c._seg(id_) + "/domains", body, query=None)

    def add_sender(self, id_: str, domain_id: str, body: Any = None) -> Any:
        """Add sender.  [POST /api/Communication/services/{id}/domains/{domainId}/senders]"""
        return self._c.request("POST", "/api/Communication/services/" + self._c._seg(id_) + "/domains/" + self._c._seg(domain_id) + "/senders", body, query=None)

    def create_connector(self, id_: str, body: Any = None) -> Any:
        """Create connector.  [POST /api/Communication/services/{id}/connectors]"""
        return self._c.request("POST", "/api/Communication/services/" + self._c._seg(id_) + "/connectors", body, query=None)

    def create_service(self, body: Any = None) -> Any:
        """Create service.  [POST /api/Communication/services]"""
        return self._c.request("POST", "/api/Communication/services", body, query=None)

    def delete_connector(self, id_: str, connector_id: str) -> Any:
        """Delete connector.  [DELETE /api/Communication/services/{id}/connectors/{connectorId}]"""
        return self._c.request("DELETE", "/api/Communication/services/" + self._c._seg(id_) + "/connectors/" + self._c._seg(connector_id), None, query=None)

    def delete_domain(self, id_: str, domain_id: str) -> Any:
        """Delete domain.  [DELETE /api/Communication/services/{id}/domains/{domainId}]"""
        return self._c.request("DELETE", "/api/Communication/services/" + self._c._seg(id_) + "/domains/" + self._c._seg(domain_id), None, query=None)

    def delete_message(self, id_: str, message_id: str) -> Any:
        """Delete message.  [DELETE /api/Communication/services/{id}/emails/{messageId}]"""
        return self._c.request("DELETE", "/api/Communication/services/" + self._c._seg(id_) + "/emails/" + self._c._seg(message_id), None, query=None)

    def delete_sender(self, id_: str, domain_id: str, sender_id: str) -> Any:
        """Delete sender.  [DELETE /api/Communication/services/{id}/domains/{domainId}/senders/{senderId}]"""
        return self._c.request("DELETE", "/api/Communication/services/" + self._c._seg(id_) + "/domains/" + self._c._seg(domain_id) + "/senders/" + self._c._seg(sender_id), None, query=None)

    def delete_service(self, id_: str) -> Any:
        """Delete service.  [DELETE /api/Communication/services/{id}]"""
        return self._c.request("DELETE", "/api/Communication/services/" + self._c._seg(id_), None, query=None)

    def get_message(self, id_: str, message_id: str) -> Any:
        """Get message.  [GET /api/Communication/services/{id}/emails/{messageId}]"""
        return self._c.request("GET", "/api/Communication/services/" + self._c._seg(id_) + "/emails/" + self._c._seg(message_id), None, query=None)

    def get_service(self, id_: str) -> Any:
        """Get service.  [GET /api/Communication/services/{id}]"""
        return self._c.request("GET", "/api/Communication/services/" + self._c._seg(id_), None, query=None)

    def list_connectors(self, id_: str) -> Any:
        """List connectors.  [GET /api/Communication/services/{id}/connectors]"""
        return self._c.request("GET", "/api/Communication/services/" + self._c._seg(id_) + "/connectors", None, query=None)

    def list_domains(self, id_: str) -> Any:
        """List domains.  [GET /api/Communication/services/{id}/domains]"""
        return self._c.request("GET", "/api/Communication/services/" + self._c._seg(id_) + "/domains", None, query=None)

    def list_messages(self, id_: str, *, limit: Any = None) -> Any:
        """List messages.  [GET /api/Communication/services/{id}/emails]"""
        return self._c.request("GET", "/api/Communication/services/" + self._c._seg(id_) + "/emails", None, query={"limit": limit})

    def list_services(self) -> Any:
        """List services.  [GET /api/Communication/services]"""
        return self._c.request("GET", "/api/Communication/services", None, query=None)

    def send_email(self, id_: str, body: Any = None) -> Any:
        """Send email.  [POST /api/Communication/services/{id}/emails]"""
        return self._c.request("POST", "/api/Communication/services/" + self._c._seg(id_) + "/emails", body, query=None)

    def verify_domain(self, id_: str, domain_id: str) -> Any:
        """Verify domain.  [POST /api/Communication/services/{id}/domains/{domainId}/verify]"""
        return self._c.request("POST", "/api/Communication/services/" + self._c._seg(id_) + "/domains/" + self._c._seg(domain_id) + "/verify", None, query=None)

class ContainerAppApi:
    """ContainerApp operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def create_app(self, body: Any = None) -> Any:
        """Create app.  [POST /api/ContainerApp]"""
        return self._c.request("POST", "/api/ContainerApp", body, query=None)

    def create_environment(self, body: Any = None) -> Any:
        """Create environment.  [POST /api/ContainerApp/environments]"""
        return self._c.request("POST", "/api/ContainerApp/environments", body, query=None)

    def create_revision(self, id_: str, body: Any = None) -> Any:
        """Create revision.  [POST /api/ContainerApp/{id}/revisions]"""
        return self._c.request("POST", "/api/ContainerApp/" + self._c._seg(id_) + "/revisions", body, query=None)

    def delete_app(self, id_: str) -> Any:
        """Delete app.  [DELETE /api/ContainerApp/{id}]"""
        return self._c.request("DELETE", "/api/ContainerApp/" + self._c._seg(id_), None, query=None)

    def delete_environment(self, id_: str) -> Any:
        """Delete environment.  [DELETE /api/ContainerApp/environments/{id}]"""
        return self._c.request("DELETE", "/api/ContainerApp/environments/" + self._c._seg(id_), None, query=None)

    def environment_contents(self, id_: str) -> Any:
        """Environment contents.  [GET /api/ContainerApp/environments/{id}/contents]"""
        return self._c.request("GET", "/api/ContainerApp/environments/" + self._c._seg(id_) + "/contents", None, query=None)

    def exec(self, id_: str, body: Any = None) -> Any:
        """Exec.  [POST /api/ContainerApp/{id}/exec]"""
        return self._c.request("POST", "/api/ContainerApp/" + self._c._seg(id_) + "/exec", body, query=None)

    def get_app(self, id_: str) -> Any:
        """Get app.  [GET /api/ContainerApp/{id}]"""
        return self._c.request("GET", "/api/ContainerApp/" + self._c._seg(id_), None, query=None)

    def get_replicas(self, id_: str) -> Any:
        """Get replicas.  [GET /api/ContainerApp/{id}/replicas]"""
        return self._c.request("GET", "/api/ContainerApp/" + self._c._seg(id_) + "/replicas", None, query=None)

    def list_apps(self) -> Any:
        """List apps.  [GET /api/ContainerApp]"""
        return self._c.request("GET", "/api/ContainerApp", None, query=None)

    def list_environments(self) -> Any:
        """List environments.  [GET /api/ContainerApp/environments]"""
        return self._c.request("GET", "/api/ContainerApp/environments", None, query=None)

    def list_revisions(self, id_: str) -> Any:
        """List revisions.  [GET /api/ContainerApp/{id}/revisions]"""
        return self._c.request("GET", "/api/ContainerApp/" + self._c._seg(id_) + "/revisions", None, query=None)

    def rollback(self, id_: str, revision_name: str) -> Any:
        """Rollback.  [POST /api/ContainerApp/{id}/revisions/{revisionName}/rollback]"""
        return self._c.request("POST", "/api/ContainerApp/" + self._c._seg(id_) + "/revisions/" + self._c._seg(revision_name) + "/rollback", None, query=None)

    def scale(self, id_: str, body: Any = None) -> Any:
        """Scale.  [POST /api/ContainerApp/{id}/scale]"""
        return self._c.request("POST", "/api/ContainerApp/" + self._c._seg(id_) + "/scale", body, query=None)

    def set_traffic(self, id_: str, body: Any = None) -> Any:
        """Set traffic.  [POST /api/ContainerApp/{id}/revisions/traffic]"""
        return self._c.request("POST", "/api/ContainerApp/" + self._c._seg(id_) + "/revisions/traffic", body, query=None)

class ContainerJobsApi:
    """ContainerJobs operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def cancel(self, id_: str, run_id: str) -> Any:
        """Cancel.  [POST /api/container-jobs/{id}/runs/{runId}/cancel]"""
        return self._c.request("POST", "/api/container-jobs/" + self._c._seg(id_) + "/runs/" + self._c._seg(run_id) + "/cancel", None, query=None)

    def create(self, body: Any = None) -> Any:
        """Create.  [POST /api/container-jobs]"""
        return self._c.request("POST", "/api/container-jobs", body, query=None)

    def delete(self, id_: str) -> Any:
        """Delete.  [DELETE /api/container-jobs/{id}]"""
        return self._c.request("DELETE", "/api/container-jobs/" + self._c._seg(id_), None, query=None)

    def get(self, id_: str) -> Any:
        """Get.  [GET /api/container-jobs/{id}]"""
        return self._c.request("GET", "/api/container-jobs/" + self._c._seg(id_), None, query=None)

    def get_run(self, id_: str, run_id: str) -> Any:
        """Get run.  [GET /api/container-jobs/{id}/runs/{runId}]"""
        return self._c.request("GET", "/api/container-jobs/" + self._c._seg(id_) + "/runs/" + self._c._seg(run_id), None, query=None)

    def list(self) -> Any:
        """List.  [GET /api/container-jobs]"""
        return self._c.request("GET", "/api/container-jobs", None, query=None)

    def preview(self, *, cron: Any = None, time_zone: Any = None, count: Any = None) -> Any:
        """Preview.  [GET /api/container-jobs/schedule-preview]"""
        return self._c.request("GET", "/api/container-jobs/schedule-preview", None, query={"cron": cron, "timeZone": time_zone, "count": count})

    def run(self, id_: str) -> Any:
        """Run.  [POST /api/container-jobs/{id}/run]"""
        return self._c.request("POST", "/api/container-jobs/" + self._c._seg(id_) + "/run", None, query=None)

    def runs(self, id_: str, *, take: Any = None) -> Any:
        """Runs.  [GET /api/container-jobs/{id}/runs]"""
        return self._c.request("GET", "/api/container-jobs/" + self._c._seg(id_) + "/runs", None, query={"take": take})

    def update(self, id_: str, body: Any = None) -> Any:
        """Update.  [PUT /api/container-jobs/{id}]"""
        return self._c.request("PUT", "/api/container-jobs/" + self._c._seg(id_), body, query=None)

class ContainerRegistryApi:
    """ContainerRegistry operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def create(self, body: Any = None) -> Any:
        """Create.  [POST /api/container-registry]"""
        return self._c.request("POST", "/api/container-registry", body, query=None)

    def create_repository(self, id_: str, body: Any = None) -> Any:
        """Create repository.  [POST /api/container-registry/{id}/repositories]"""
        return self._c.request("POST", "/api/container-registry/" + self._c._seg(id_) + "/repositories", body, query=None)

    def credentials(self, id_: str) -> Any:
        """Credentials.  [GET /api/container-registry/{id}/credentials]"""
        return self._c.request("GET", "/api/container-registry/" + self._c._seg(id_) + "/credentials", None, query=None)

    def delete(self, id_: str) -> Any:
        """Delete.  [DELETE /api/container-registry/{id}]"""
        return self._c.request("DELETE", "/api/container-registry/" + self._c._seg(id_), None, query=None)

    def delete_repository(self, id_: str, repository_name: str) -> Any:
        """Delete repository.  [DELETE /api/container-registry/{id}/repositories/{repositoryName}]"""
        return self._c.request("DELETE", "/api/container-registry/" + self._c._seg(id_) + "/repositories/" + self._c._seg(repository_name, True), None, query=None)

    def delete_tag(self, id_: str, *, repository: Any = None, tag: Any = None) -> Any:
        """Delete tag.  [DELETE /api/container-registry/{id}/tags]"""
        return self._c.request("DELETE", "/api/container-registry/" + self._c._seg(id_) + "/tags", None, query={"repository": repository, "tag": tag})

    def get(self, id_: str) -> Any:
        """Get.  [GET /api/container-registry/{id}]"""
        return self._c.request("GET", "/api/container-registry/" + self._c._seg(id_), None, query=None)

    def list(self) -> Any:
        """List.  [GET /api/container-registry]"""
        return self._c.request("GET", "/api/container-registry", None, query=None)

    def repositories(self, id_: str) -> Any:
        """Repositories.  [GET /api/container-registry/{id}/repositories]"""
        return self._c.request("GET", "/api/container-registry/" + self._c._seg(id_) + "/repositories", None, query=None)

    def rotate(self, id_: str) -> Any:
        """Rotate.  [POST /api/container-registry/{id}/credentials/rotate]"""
        return self._c.request("POST", "/api/container-registry/" + self._c._seg(id_) + "/credentials/rotate", None, query=None)

    def tags(self, id_: str, *, repository: Any = None) -> Any:
        """Tags.  [GET /api/container-registry/{id}/tags]"""
        return self._c.request("GET", "/api/container-registry/" + self._c._seg(id_) + "/tags", None, query={"repository": repository})

class ContainersApi:
    """Containers operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def build_image(self, body: Any = None) -> Any:
        """Build image.  [POST /api/Containers/images/build]"""
        return self._c.request("POST", "/api/Containers/images/build", body, query=None)

    def create_container(self, body: Any = None) -> Any:
        """Create container.  [POST /api/Containers/createcontainer]"""
        return self._c.request("POST", "/api/Containers/createcontainer", body, query=None)

    def create_swarm_service(self, body: Any = None) -> Any:
        """Create swarm service.  [POST /api/Containers/swarm/services]"""
        return self._c.request("POST", "/api/Containers/swarm/services", body, query=None)

    def delete_container(self, body: Any = None) -> Any:
        """Delete container.  [POST /api/Containers/deletecontainer]"""
        return self._c.request("POST", "/api/Containers/deletecontainer", body, query=None)

    def exec(self, container_name: str, body: Any = None) -> Any:
        """Exec.  [POST /api/Containers/{containerName}/exec]"""
        return self._c.request("POST", "/api/Containers/" + self._c._seg(container_name) + "/exec", body, query=None)

    def give_public_address(self, name: str, *, region: Any = None) -> Any:
        """Give public address.  [POST /api/Containers/{name}/public-ip]"""
        return self._c.request("POST", "/api/Containers/" + self._c._seg(name) + "/public-ip", None, query={"region": region})

    def inspect(self, container_name: str) -> Any:
        """Inspect.  [GET /api/Containers/{containerName}/inspect]"""
        return self._c.request("GET", "/api/Containers/" + self._c._seg(container_name) + "/inspect", None, query=None)

    def list_all_containers(self, body: Any = None) -> Any:
        """List all containers.  [POST /api/Containers/listallcontainers]"""
        return self._c.request("POST", "/api/Containers/listallcontainers", body, query=None)

    def logs(self, container_name: str, *, tail: Any = None) -> Any:
        """Logs.  [GET /api/Containers/{containerName}/logs]"""
        return self._c.request("GET", "/api/Containers/" + self._c._seg(container_name) + "/logs", None, query={"tail": tail})

    def release_public_address(self, name: str, *, region: Any = None) -> Any:
        """Release public address.  [DELETE /api/Containers/{name}/public-ip]"""
        return self._c.request("DELETE", "/api/Containers/" + self._c._seg(name) + "/public-ip", None, query={"region": region})

    def remove_swarm_service(self, name: str, *, region: Any = None) -> Any:
        """Remove swarm service.  [DELETE /api/Containers/swarm/services/{name}]"""
        return self._c.request("DELETE", "/api/Containers/swarm/services/" + self._c._seg(name), None, query={"region": region})

    def rename_container(self, body: Any = None) -> Any:
        """Rename container.  [POST /api/Containers/renamecontainer]"""
        return self._c.request("POST", "/api/Containers/renamecontainer", body, query=None)

    def restart_container(self, body: Any = None) -> Any:
        """Restart container.  [POST /api/Containers/restartcontainer]"""
        return self._c.request("POST", "/api/Containers/restartcontainer", body, query=None)

    def scale_swarm_service(self, name: str, *, replicas: Any = None, region: Any = None) -> Any:
        """Scale swarm service.  [POST /api/Containers/swarm/services/{name}/scale]"""
        return self._c.request("POST", "/api/Containers/swarm/services/" + self._c._seg(name) + "/scale", None, query={"replicas": replicas, "region": region})

    def stack_down(self, body: Any = None) -> Any:
        """Stack down.  [POST /api/Containers/stacks/down]"""
        return self._c.request("POST", "/api/Containers/stacks/down", body, query=None)

    def stack_file(self, project: str, *, region: Any = None) -> Any:
        """Stack file.  [GET /api/Containers/stacks/{project}]"""
        return self._c.request("GET", "/api/Containers/stacks/" + self._c._seg(project), None, query={"region": region})

    def stack_up(self, body: Any = None) -> Any:
        """Stack up.  [POST /api/Containers/stacks/up]"""
        return self._c.request("POST", "/api/Containers/stacks/up", body, query=None)

    def start_container(self, body: Any = None) -> Any:
        """Start container.  [POST /api/Containers/startcontainer]"""
        return self._c.request("POST", "/api/Containers/startcontainer", body, query=None)

    def stats(self, container_name: str) -> Any:
        """Stats.  [GET /api/Containers/{containerName}/stats]"""
        return self._c.request("GET", "/api/Containers/" + self._c._seg(container_name) + "/stats", None, query=None)

    def stop_container(self, body: Any = None) -> Any:
        """Stop container.  [POST /api/Containers/stopcontainer]"""
        return self._c.request("POST", "/api/Containers/stopcontainer", body, query=None)

    def swarm_init(self, *, region: Any = None) -> Any:
        """Swarm init.  [POST /api/Containers/swarm/init]"""
        return self._c.request("POST", "/api/Containers/swarm/init", None, query={"region": region})

    def swarm_leave(self, *, region: Any = None) -> Any:
        """Swarm leave.  [POST /api/Containers/swarm/leave]"""
        return self._c.request("POST", "/api/Containers/swarm/leave", None, query={"region": region})

    def swarm_nodes(self, *, region: Any = None) -> Any:
        """Swarm nodes.  [GET /api/Containers/swarm/nodes]"""
        return self._c.request("GET", "/api/Containers/swarm/nodes", None, query={"region": region})

    def swarm_services(self, *, region: Any = None) -> Any:
        """Swarm services.  [GET /api/Containers/swarm/services]"""
        return self._c.request("GET", "/api/Containers/swarm/services", None, query={"region": region})

    def swarm_status(self, *, region: Any = None) -> Any:
        """Swarm status.  [GET /api/Containers/swarm]"""
        return self._c.request("GET", "/api/Containers/swarm", None, query={"region": region})

    def update_container(self, body: Any = None) -> Any:
        """Update container.  [POST /api/Containers/updatecontainer]"""
        return self._c.request("POST", "/api/Containers/updatecontainer", body, query=None)

    def volumes(self, *, region: Any = None) -> Any:
        """Volumes.  [GET /api/Containers/volumes]"""
        return self._c.request("GET", "/api/Containers/volumes", None, query={"region": region})

class CostTrackingApi:
    """CostTracking operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def create_cost_alert(self, body: Any = None) -> Any:
        """Create cost alert.  [POST /api/CostTracking/alerts]"""
        return self._c.request("POST", "/api/CostTracking/alerts", body, query=None)

    def delete_cost_alert(self, alert_id: str) -> Any:
        """Delete cost alert.  [DELETE /api/CostTracking/alerts/{alertId}]"""
        return self._c.request("DELETE", "/api/CostTracking/alerts/" + self._c._seg(alert_id), None, query=None)

    def estimate_cost(self, body: Any = None) -> Any:
        """Estimate cost.  [POST /api/CostTracking/pricing/estimate]"""
        return self._c.request("POST", "/api/CostTracking/pricing/estimate", body, query=None)

    def get_all_storage_account_costs(self, *, period: Any = None) -> Any:
        """Get all storage account costs.  [GET /api/CostTracking/storage-accounts]"""
        return self._c.request("GET", "/api/CostTracking/storage-accounts", None, query={"period": period})

    def get_billing_periods(self, *, limit: Any = None) -> Any:
        """Get billing periods.  [GET /api/CostTracking/billing/history]"""
        return self._c.request("GET", "/api/CostTracking/billing/history", None, query={"limit": limit})

    def get_cost_alerts(self, *, scope_type: Any = None, scope_id: Any = None) -> Any:
        """Get cost alerts.  [GET /api/CostTracking/alerts]"""
        return self._c.request("GET", "/api/CostTracking/alerts", None, query={"scopeType": scope_type, "scopeId": scope_id})

    def get_current_billing_period(self) -> Any:
        """Get current billing period.  [GET /api/CostTracking/billing/current]"""
        return self._c.request("GET", "/api/CostTracking/billing/current", None, query=None)

    def get_pricing_tiers(self, *, tier: Any = None, redundancy: Any = None, region: Any = None) -> Any:
        """Get pricing tiers.  [GET /api/CostTracking/pricing]"""
        return self._c.request("GET", "/api/CostTracking/pricing", None, query={"tier": tier, "redundancy": redundancy, "region": region})

    def get_resource_group_cost(self, resource_group_id: str, *, period: Any = None) -> Any:
        """Get resource group cost.  [GET /api/CostTracking/resource-group/{resourceGroupId}]"""
        return self._c.request("GET", "/api/CostTracking/resource-group/" + self._c._seg(resource_group_id), None, query={"period": period})

    def get_storage_account_cost(self, storage_account_id: str, *, period: Any = None) -> Any:
        """Get storage account cost.  [GET /api/CostTracking/storage-account/{storageAccountId}]"""
        return self._c.request("GET", "/api/CostTracking/storage-account/" + self._c._seg(storage_account_id), None, query={"period": period})

    def get_subscription_cost(self, subscription_id: str, *, period: Any = None) -> Any:
        """Get subscription cost.  [GET /api/CostTracking/subscription/{subscriptionId}]"""
        return self._c.request("GET", "/api/CostTracking/subscription/" + self._c._seg(subscription_id), None, query={"period": period})

    def overview(self, *, region: Any = None, subscription_id: Any = None, from_: Any = None, to: Any = None, resource_name: Any = None) -> Any:
        """Overview.  [GET /api/CostTracking/overview]"""
        return self._c.request("GET", "/api/CostTracking/overview", None, query={"region": region, "subscriptionId": subscription_id, "from": from_, "to": to, "resourceName": resource_name})

    def record_cost_event(self, body: Any = None) -> Any:
        """Record cost event.  [POST /api/CostTracking/events]"""
        return self._c.request("POST", "/api/CostTracking/events", body, query=None)

    def trigger_daily_calculation(self) -> Any:
        """Trigger daily calculation.  [POST /api/CostTracking/daily-calculation]"""
        return self._c.request("POST", "/api/CostTracking/daily-calculation", None, query=None)

class CreateResourceApi:
    """CreateResource operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def create_resource(self, body: Any = None) -> Any:
        """Create resource.  [POST /api/CreateResource/createresource]"""
        return self._c.request("POST", "/api/CreateResource/createresource", body, query=None)

    def validate_resource(self, body: Any = None) -> Any:
        """Validate resource.  [POST /api/CreateResource/validateresource]"""
        return self._c.request("POST", "/api/CreateResource/validateresource", body, query=None)

class DeploymentApi:
    """Deployment operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def delete_deployment(self, id_: str) -> Any:
        """Delete deployment.  [DELETE /api/Deployment/deployments/{id}]"""
        return self._c.request("DELETE", "/api/Deployment/deployments/" + self._c._seg(id_), None, query=None)

    def deployment(self, id_: str) -> Any:
        """Deployment.  [GET /api/Deployment/deployments/{id}]"""
        return self._c.request("GET", "/api/Deployment/deployments/" + self._c._seg(id_), None, query=None)

    def deployments(self, *, status: Any = None, limit: Any = None) -> Any:
        """Deployments.  [GET /api/Deployment/deployments]"""
        return self._c.request("GET", "/api/Deployment/deployments", None, query={"status": status, "limit": limit})

    def redeploy(self, id_: str) -> Any:
        """Redeploy.  [POST /api/Deployment/deployments/{id}/redeploy]"""
        return self._c.request("POST", "/api/Deployment/deployments/" + self._c._seg(id_) + "/redeploy", None, query=None)

    def status(self, *, limit: Any = None) -> Any:
        """Status.  [GET /api/Deployment/status]"""
        return self._c.request("GET", "/api/Deployment/status", None, query={"limit": limit})

class DockerImagesApi:
    """DockerImages operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def get_image_history(self, body: Any = None, *, regions: Any = None) -> Any:
        """Get image history.  [POST /api/DockerImages/imagehistory]"""
        return self._c.request("POST", "/api/DockerImages/imagehistory", body, query={"regions": regions})

    def get_image_informations(self, body: Any = None, *, regions: Any = None) -> Any:
        """Get image informations.  [POST /api/DockerImages/inspectimage]"""
        return self._c.request("POST", "/api/DockerImages/inspectimage", body, query={"regions": regions})

    def list_all_docker_images(self, body: Any = None, *, regions: Any = None) -> Any:
        """List all docker images.  [POST /api/DockerImages/listallimages]"""
        return self._c.request("POST", "/api/DockerImages/listallimages", body, query={"regions": regions})

    def list_all_docker_public_images(self, body: Any = None, *, is_official_image: Any = None) -> Any:
        """List all docker public images.  [POST /api/DockerImages/listallpublicimages]"""
        return self._c.request("POST", "/api/DockerImages/listallpublicimages", body, query={"isOfficialImage": is_official_image})

    def search_docker_image(self, body: Any = None, *, regions: Any = None) -> Any:
        """Search docker image.  [POST /api/DockerImages/searchimage]"""
        return self._c.request("POST", "/api/DockerImages/searchimage", body, query={"regions": regions})

class DownloadsApi:
    """Downloads operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def cli(self) -> Any:
        """Cli.  [GET /api/downloads/hiok]"""
        return self._c.request("GET", "/api/downloads/hiok", None, query=None)

    def install(self) -> Any:
        """Install.  [GET /api/downloads/install.sh]"""
        return self._c.request("GET", "/api/downloads/install.sh", None, query=None)

    def install_ps1(self) -> Any:
        """Install ps1.  [GET /api/downloads/install.ps1]"""
        return self._c.request("GET", "/api/downloads/install.ps1", None, query=None)

    def manifest(self) -> Any:
        """Manifest.  [GET /api/downloads/manifest]"""
        return self._c.request("GET", "/api/downloads/manifest", None, query=None)

    def sdk(self) -> Any:
        """Sdk.  [GET /api/downloads/sdk.tar.gz]"""
        return self._c.request("GET", "/api/downloads/sdk.tar.gz", None, query=None)

    def sdk_package(self, file: str) -> Any:
        """Sdk package.  [GET /api/downloads/sdk/{file}]"""
        return self._c.request("GET", "/api/downloads/sdk/" + self._c._seg(file), None, query=None)

    def sdk_package_list(self) -> Any:
        """Sdk package list.  [GET /api/downloads/sdk]"""
        return self._c.request("GET", "/api/downloads/sdk", None, query=None)

class DpsApi:
    """Dps operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def create(self, body: Any = None) -> Any:
        """Create.  [POST /api/dps/enrollments]"""
        return self._c.request("POST", "/api/dps/enrollments", body, query=None)

    def delete(self, id_: str) -> Any:
        """Delete.  [DELETE /api/dps/enrollments/{id}]"""
        return self._c.request("DELETE", "/api/dps/enrollments/" + self._c._seg(id_), None, query=None)

    def list(self) -> Any:
        """List.  [GET /api/dps/enrollments]"""
        return self._c.request("GET", "/api/dps/enrollments", None, query=None)

    def register(self, body: Any = None) -> Any:
        """Register.  [POST /api/dps/register]"""
        return self._c.request("POST", "/api/dps/register", body, query=None)

    def registrations(self, id_: str) -> Any:
        """Registrations.  [GET /api/dps/enrollments/{id}/registrations]"""
        return self._c.request("GET", "/api/dps/enrollments/" + self._c._seg(id_) + "/registrations", None, query=None)

class FxApi:
    """Fx operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def convert(self, *, usd: Any = None, currency: Any = None) -> Any:
        """Convert.  [GET /api/Fx/convert]"""
        return self._c.request("GET", "/api/Fx/convert", None, query={"usd": usd, "currency": currency})

    def rates(self) -> Any:
        """Rates.  [GET /api/Fx/rates]"""
        return self._c.request("GET", "/api/Fx/rates", None, query=None)

class GroupsApi:
    """Groups operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def create_groups(self, body: Any = None) -> Any:
        """Create groups.  [POST /api/Groups/creategroups]"""
        return self._c.request("POST", "/api/Groups/creategroups", body, query=None)

    def delete_groups(self, *, id_: Any = None) -> Any:
        """Delete groups.  [DELETE /api/Groups/deletegroups]"""
        return self._c.request("DELETE", "/api/Groups/deletegroups", None, query={"id": id_})

    def edit_groups(self, body: Any = None) -> Any:
        """Edit groups.  [PUT /api/Groups/editgroups]"""
        return self._c.request("PUT", "/api/Groups/editgroups", body, query=None)

    def get_groups(self) -> Any:
        """Get groups.  [GET /api/Groups/groups]"""
        return self._c.request("GET", "/api/Groups/groups", None, query=None)

class HierarchyViewApi:
    """HierarchyView operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def context(self, resource_group_id: str) -> Any:
        """Context.  [GET /api/hierarchyview/context/{resourceGroupId}]"""
        return self._c.request("GET", "/api/hierarchyview/context/" + self._c._seg(resource_group_id), None, query=None)

    def full(self) -> Any:
        """Full.  [GET /api/hierarchyview/full]"""
        return self._c.request("GET", "/api/hierarchyview/full", None, query=None)

class HiokCloudGroupsApi:
    """HiokCloudGroups operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def create_hiok_cloud_access_group(self, body: Any = None) -> Any:
        """Create hiok cloud access group.  [POST /api/HiokCloudGroups/createaccessgroup]"""
        return self._c.request("POST", "/api/HiokCloudGroups/createaccessgroup", body, query=None)

    def create_management_group(self, body: Any = None) -> Any:
        """Create management group.  [POST /api/HiokCloudGroups/createmanagementgroup]"""
        return self._c.request("POST", "/api/HiokCloudGroups/createmanagementgroup", body, query=None)

    def create_resource_group(self, body: Any = None) -> Any:
        """Create resource group.  [POST /api/HiokCloudGroups/createresourcegroup]"""
        return self._c.request("POST", "/api/HiokCloudGroups/createresourcegroup", body, query=None)

    def delete_hiok_cloud_access_group(self, body: Any = None) -> Any:
        """Delete hiok cloud access group.  [DELETE /api/HiokCloudGroups/deleteaccessgroup]"""
        return self._c.request("DELETE", "/api/HiokCloudGroups/deleteaccessgroup", body, query=None)

    def edit_hiok_cloud_access_group(self, body: Any = None) -> Any:
        """Edit hiok cloud access group.  [PUT /api/HiokCloudGroups/editaccessgroup]"""
        return self._c.request("PUT", "/api/HiokCloudGroups/editaccessgroup", body, query=None)

    def get_all_hiok_cloud_access_group(self) -> Any:
        """Get all hiok cloud access group.  [GET /api/HiokCloudGroups/allaccessgroups]"""
        return self._c.request("GET", "/api/HiokCloudGroups/allaccessgroups", None, query=None)

    def get_hiok_cloud_access_group(self) -> Any:
        """Get hiok cloud access group.  [GET /api/HiokCloudGroups/accessgroups]"""
        return self._c.request("GET", "/api/HiokCloudGroups/accessgroups", None, query=None)

    def get_hiok_cloud_specific_access_group(self, *, type_: Any = None) -> Any:
        """Get hiok cloud specific access group.  [GET /api/HiokCloudGroups/specificaccessgroups]"""
        return self._c.request("GET", "/api/HiokCloudGroups/specificaccessgroups", None, query={"type": type_})

class HiokCloudHierarchyApi:
    """HiokCloudHierarchy operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def create_hiok_cloud_hierarchy(self, body: Any = None) -> Any:
        """Create hiok cloud hierarchy.  [POST /api/HiokCloudHierarchy]"""
        return self._c.request("POST", "/api/HiokCloudHierarchy", body, query=None)

    def delete_hiok_cloud_hierarchy(self, id_: str) -> Any:
        """Delete hiok cloud hierarchy.  [DELETE /api/HiokCloudHierarchy/deletehierarchy/{id}]"""
        return self._c.request("DELETE", "/api/HiokCloudHierarchy/deletehierarchy/" + self._c._seg(id_), None, query=None)

    def delete_hiok_cloud_hierarchy_node(self, body: Any = None) -> Any:
        """Delete hiok cloud hierarchy node.  [DELETE /api/HiokCloudHierarchy/deletehierarchynode]"""
        return self._c.request("DELETE", "/api/HiokCloudHierarchy/deletehierarchynode", body, query=None)

    def edit_hiok_cloud_hierarchy(self, body: Any = None) -> Any:
        """Edit hiok cloud hierarchy.  [PUT /api/HiokCloudHierarchy/edithierarchy]"""
        return self._c.request("PUT", "/api/HiokCloudHierarchy/edithierarchy", body, query=None)

    def get_all_hierarchy(self) -> Any:
        """Get all hierarchy.  [GET /api/HiokCloudHierarchy/hierarchies]"""
        return self._c.request("GET", "/api/HiokCloudHierarchy/hierarchies", None, query=None)

    def get_hierarchy(self, id_: str) -> Any:
        """Get hierarchy.  [GET /api/HiokCloudHierarchy/hierarchy/{id}]"""
        return self._c.request("GET", "/api/HiokCloudHierarchy/hierarchy/" + self._c._seg(id_), None, query=None)

class HiokIdApi:
    """HiokId operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def accept(self, id_: str) -> Any:
        """Accept.  [POST /api/hiok-id/invitations/{id}/accept]"""
        return self._c.request("POST", "/api/hiok-id/invitations/" + self._c._seg(id_) + "/accept", None, query=None)

    def add_app_credential(self, id_: str, body: Any = None) -> Any:
        """Add app credential.  [POST /api/hiok-id/apps/{id}/credentials]"""
        return self._c.request("POST", "/api/hiok-id/apps/" + self._c._seg(id_) + "/credentials", body, query=None)

    def add_group_member(self, id_: str, body: Any = None) -> Any:
        """Add group member.  [POST /api/hiok-id/groups/{id}/members]"""
        return self._c.request("POST", "/api/hiok-id/groups/" + self._c._seg(id_) + "/members", body, query=None)

    def add_sp_credential(self, id_: str, body: Any = None) -> Any:
        """Add sp credential.  [POST /api/hiok-id/service-principals/{id}/credentials]"""
        return self._c.request("POST", "/api/hiok-id/service-principals/" + self._c._seg(id_) + "/credentials", body, query=None)

    def apps(self) -> Any:
        """Apps.  [GET /api/hiok-id/apps]"""
        return self._c.request("GET", "/api/hiok-id/apps", None, query=None)

    def create_app(self, body: Any = None) -> Any:
        """Create app.  [POST /api/hiok-id/apps]"""
        return self._c.request("POST", "/api/hiok-id/apps", body, query=None)

    def create_group(self, body: Any = None) -> Any:
        """Create group.  [POST /api/hiok-id/groups]"""
        return self._c.request("POST", "/api/hiok-id/groups", body, query=None)

    def create_service_principal(self, body: Any = None) -> Any:
        """Create service principal.  [POST /api/hiok-id/service-principals]"""
        return self._c.request("POST", "/api/hiok-id/service-principals", body, query=None)

    def create_tenant(self, body: Any = None) -> Any:
        """Create tenant.  [POST /api/hiok-id/tenants]"""
        return self._c.request("POST", "/api/hiok-id/tenants", body, query=None)

    def decline(self, id_: str) -> Any:
        """Decline.  [POST /api/hiok-id/invitations/{id}/decline]"""
        return self._c.request("POST", "/api/hiok-id/invitations/" + self._c._seg(id_) + "/decline", None, query=None)

    def delete_app(self, id_: str) -> Any:
        """Delete app.  [DELETE /api/hiok-id/apps/{id}]"""
        return self._c.request("DELETE", "/api/hiok-id/apps/" + self._c._seg(id_), None, query=None)

    def delete_group(self, id_: str) -> Any:
        """Delete group.  [DELETE /api/hiok-id/groups/{id}]"""
        return self._c.request("DELETE", "/api/hiok-id/groups/" + self._c._seg(id_), None, query=None)

    def delete_service_principal(self, id_: str) -> Any:
        """Delete service principal.  [DELETE /api/hiok-id/service-principals/{id}]"""
        return self._c.request("DELETE", "/api/hiok-id/service-principals/" + self._c._seg(id_), None, query=None)

    def directories(self) -> Any:
        """Directories.  [GET /api/hiok-id/directories]"""
        return self._c.request("GET", "/api/hiok-id/directories", None, query=None)

    def enter(self, body: Any = None) -> Any:
        """Enter.  [POST /api/hiok-id/directories/enter]"""
        return self._c.request("POST", "/api/hiok-id/directories/enter", body, query=None)

    def groups(self) -> Any:
        """Groups.  [GET /api/hiok-id/groups]"""
        return self._c.request("GET", "/api/hiok-id/groups", None, query=None)

    def invite(self, body: Any = None) -> Any:
        """Invite.  [POST /api/hiok-id/users]"""
        return self._c.request("POST", "/api/hiok-id/users", body, query=None)

    def leave(self, body: Any = None) -> Any:
        """Leave.  [POST /api/hiok-id/directories/leave]"""
        return self._c.request("POST", "/api/hiok-id/directories/leave", body, query=None)

    def me(self) -> Any:
        """Me.  [GET /api/hiok-id/me]"""
        return self._c.request("GET", "/api/hiok-id/me", None, query=None)

    def overview(self) -> Any:
        """Overview.  [GET /api/hiok-id/overview]"""
        return self._c.request("GET", "/api/hiok-id/overview", None, query=None)

    def remove_app_credential(self, id_: str, credential_id: str) -> Any:
        """Remove app credential.  [DELETE /api/hiok-id/apps/{id}/credentials/{credentialId}]"""
        return self._c.request("DELETE", "/api/hiok-id/apps/" + self._c._seg(id_) + "/credentials/" + self._c._seg(credential_id), None, query=None)

    def remove_group_member(self, id_: str, kind: str, reference: str) -> Any:
        """Remove group member.  [DELETE /api/hiok-id/groups/{id}/members/{kind}/{reference}]"""
        return self._c.request("DELETE", "/api/hiok-id/groups/" + self._c._seg(id_) + "/members/" + self._c._seg(kind) + "/" + self._c._seg(reference), None, query=None)

    def remove_member(self, id_: str) -> Any:
        """Remove member.  [DELETE /api/hiok-id/users/{id}]"""
        return self._c.request("DELETE", "/api/hiok-id/users/" + self._c._seg(id_), None, query=None)

    def remove_sp_credential(self, id_: str, credential_id: str) -> Any:
        """Remove sp credential.  [DELETE /api/hiok-id/service-principals/{id}/credentials/{credentialId}]"""
        return self._c.request("DELETE", "/api/hiok-id/service-principals/" + self._c._seg(id_) + "/credentials/" + self._c._seg(credential_id), None, query=None)

    def rename_directory(self, body: Any = None) -> Any:
        """Rename directory.  [PUT /api/hiok-id/directory]"""
        return self._c.request("PUT", "/api/hiok-id/directory", body, query=None)

    def resend(self, id_: str) -> Any:
        """Resend.  [POST /api/hiok-id/users/{id}/resend]"""
        return self._c.request("POST", "/api/hiok-id/users/" + self._c._seg(id_) + "/resend", None, query=None)

    def service_principals(self) -> Any:
        """Service principals.  [GET /api/hiok-id/service-principals]"""
        return self._c.request("GET", "/api/hiok-id/service-principals", None, query=None)

    def sign_ins(self, *, take: Any = None, outcome: Any = None) -> Any:
        """Sign ins.  [GET /api/hiok-id/sign-ins]"""
        return self._c.request("GET", "/api/hiok-id/sign-ins", None, query={"take": take, "outcome": outcome})

    def update_app(self, id_: str, body: Any = None) -> Any:
        """Update app.  [PUT /api/hiok-id/apps/{id}]"""
        return self._c.request("PUT", "/api/hiok-id/apps/" + self._c._seg(id_), body, query=None)

    def update_group(self, id_: str, body: Any = None) -> Any:
        """Update group.  [PUT /api/hiok-id/groups/{id}]"""
        return self._c.request("PUT", "/api/hiok-id/groups/" + self._c._seg(id_), body, query=None)

    def update_member(self, id_: str, body: Any = None) -> Any:
        """Update member.  [PUT /api/hiok-id/users/{id}]"""
        return self._c.request("PUT", "/api/hiok-id/users/" + self._c._seg(id_), body, query=None)

    def update_service_principal(self, id_: str, body: Any = None) -> Any:
        """Update service principal.  [PUT /api/hiok-id/service-principals/{id}]"""
        return self._c.request("PUT", "/api/hiok-id/service-principals/" + self._c._seg(id_), body, query=None)

    def users(self) -> Any:
        """Users.  [GET /api/hiok-id/users]"""
        return self._c.request("GET", "/api/hiok-id/users", None, query=None)

class HiokUsersApi:
    """HiokUsers operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def delete_user_by_id(self, email_id: str) -> Any:
        """Delete user by id.  [DELETE /api/HiokUsers/removehiokuser/{emailId}]"""
        return self._c.request("DELETE", "/api/HiokUsers/removehiokuser/" + self._c._seg(email_id), None, query=None)

    def forgot_password(self, body: Any = None) -> Any:
        """Forgot password.  [POST /api/HiokUsers/forgotpassword]"""
        return self._c.request("POST", "/api/HiokUsers/forgotpassword", body, query=None)

    def hiok_user_by_id(self, email_id: str) -> Any:
        """Hiok user by id.  [GET /api/HiokUsers/hiokusersbyid/{emailId}]"""
        return self._c.request("GET", "/api/HiokUsers/hiokusersbyid/" + self._c._seg(email_id), None, query=None)

    def hiok_users(self) -> Any:
        """Hiok users.  [GET /api/HiokUsers/hiokusers]"""
        return self._c.request("GET", "/api/HiokUsers/hiokusers", None, query=None)

    def register_hiok_user(self, body: Any = None) -> Any:
        """Register hiok user.  [POST /api/HiokUsers/registerhiokuser]"""
        return self._c.request("POST", "/api/HiokUsers/registerhiokuser", body, query=None)

    def resend_verification(self, body: Any = None) -> Any:
        """Resend verification.  [POST /api/HiokUsers/resendverification]"""
        return self._c.request("POST", "/api/HiokUsers/resendverification", body, query=None)

    def reset_password(self, body: Any = None) -> Any:
        """Reset password.  [POST /api/HiokUsers/resetpassword]"""
        return self._c.request("POST", "/api/HiokUsers/resetpassword", body, query=None)

    def update_user_by_id(self, email_id: str, body: Any = None) -> Any:
        """Update user by id.  [PUT /api/HiokUsers/hiokuserupdate/{emailId}]"""
        return self._c.request("PUT", "/api/HiokUsers/hiokuserupdate/" + self._c._seg(email_id), body, query=None)

    def verify_email(self, body: Any = None) -> Any:
        """Verify email.  [POST /api/HiokUsers/verifyemail]"""
        return self._c.request("POST", "/api/HiokUsers/verifyemail", body, query=None)

class HybridApi:
    """Hybrid operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def agent_install(self) -> Any:
        """Agent install.  [GET /api/hybrid/agent-install]"""
        return self._c.request("GET", "/api/hybrid/agent-install", None, query=None)

    def delete(self, id_: str) -> Any:
        """Delete.  [DELETE /api/hybrid/resources/{id}]"""
        return self._c.request("DELETE", "/api/hybrid/resources/" + self._c._seg(id_), None, query=None)

    def heartbeat(self, body: Any = None) -> Any:
        """Heartbeat.  [POST /api/hybrid/heartbeat]"""
        return self._c.request("POST", "/api/hybrid/heartbeat", body, query=None)

    def list(self) -> Any:
        """List.  [GET /api/hybrid/resources]"""
        return self._c.request("GET", "/api/hybrid/resources", None, query=None)

    def list_services(self, id_: str) -> Any:
        """List services.  [GET /api/hybrid/resources/{id}/services]"""
        return self._c.request("GET", "/api/hybrid/resources/" + self._c._seg(id_) + "/services", None, query=None)

    def metrics(self, id_: str) -> Any:
        """Metrics.  [GET /api/hybrid/resources/{id}/metrics]"""
        return self._c.request("GET", "/api/hybrid/resources/" + self._c._seg(id_) + "/metrics", None, query=None)

    def provision_edge(self, id_: str) -> Any:
        """Provision edge.  [POST /api/hybrid/resources/{id}/edge]"""
        return self._c.request("POST", "/api/hybrid/resources/" + self._c._seg(id_) + "/edge", None, query=None)

    def publish_service(self, id_: str, body: Any = None) -> Any:
        """Publish service.  [POST /api/hybrid/resources/{id}/services]"""
        return self._c.request("POST", "/api/hybrid/resources/" + self._c._seg(id_) + "/services", body, query=None)

    def register(self, body: Any = None) -> Any:
        """Register.  [POST /api/hybrid/resources]"""
        return self._c.request("POST", "/api/hybrid/resources", body, query=None)

    def unpublish_service(self, id_: str, service_id: str) -> Any:
        """Unpublish service.  [DELETE /api/hybrid/resources/{id}/services/{serviceId}]"""
        return self._c.request("DELETE", "/api/hybrid/resources/" + self._c._seg(id_) + "/services/" + self._c._seg(service_id), None, query=None)

class IdentityApi:
    """Identity operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def create(self, body: Any = None) -> Any:
        """Create.  [POST /api/identity]"""
        return self._c.request("POST", "/api/identity", body, query=None)

    def delete(self, id_: str) -> Any:
        """Delete.  [DELETE /api/identity/{id}]"""
        return self._c.request("DELETE", "/api/identity/" + self._c._seg(id_), None, query=None)

    def for_resource(self, resource_id: str, *, resource_type: Any = None, name: Any = None) -> Any:
        """For resource.  [GET /api/identity/for-resource/{resourceId}]"""
        return self._c.request("GET", "/api/identity/for-resource/" + self._c._seg(resource_id), None, query={"resourceType": resource_type, "name": name})

    def list(self, *, kind: Any = None) -> Any:
        """List.  [GET /api/identity]"""
        return self._c.request("GET", "/api/identity", None, query={"kind": kind})

    def regenerate(self, id_: str) -> Any:
        """Regenerate.  [POST /api/identity/{id}/regenerate-secret]"""
        return self._c.request("POST", "/api/identity/" + self._c._seg(id_) + "/regenerate-secret", None, query=None)

class InfrastructureApi:
    """Infrastructure operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def allocate_ip(self, body: Any = None) -> Any:
        """Allocate ip.  [POST /api/Infrastructure/ip-allocations]"""
        return self._c.request("POST", "/api/Infrastructure/ip-allocations", body, query=None)

    def get_reverse(self, region: str, ip: str) -> Any:
        """Get reverse.  [GET /api/Infrastructure/regions/{region}/reverse/{ip}]"""
        return self._c.request("GET", "/api/Infrastructure/regions/" + self._c._seg(region) + "/reverse/" + self._c._seg(ip), None, query=None)

    def ip_allocations(self, *, region: Any = None, include_released: Any = None) -> Any:
        """Ip allocations.  [GET /api/Infrastructure/ip-allocations]"""
        return self._c.request("GET", "/api/Infrastructure/ip-allocations", None, query={"region": region, "includeReleased": include_released})

    def ip_block(self, region: str, block: str) -> Any:
        """Ip block.  [GET /api/Infrastructure/regions/{region}/ips/{block}]"""
        return self._c.request("GET", "/api/Infrastructure/regions/" + self._c._seg(region) + "/ips/" + self._c._seg(block), None, query=None)

    def ip_pools(self, *, region: Any = None) -> Any:
        """Ip pools.  [GET /api/Infrastructure/ip-pools]"""
        return self._c.request("GET", "/api/Infrastructure/ip-pools", None, query={"region": region})

    def ips(self, region: str) -> Any:
        """Ips.  [GET /api/Infrastructure/regions/{region}/ips]"""
        return self._c.request("GET", "/api/Infrastructure/regions/" + self._c._seg(region) + "/ips", None, query=None)

    def ips_for_resource(self, resource_kind: str, resource_id: str) -> Any:
        """Ips for resource.  [GET /api/Infrastructure/ip-allocations/resource/{resourceKind}/{resourceId}]"""
        return self._c.request("GET", "/api/Infrastructure/ip-allocations/resource/" + self._c._seg(resource_kind) + "/" + self._c._seg(resource_id), None, query=None)

    def reconcile_ips(self, *, region: Any = None) -> Any:
        """Reconcile ips.  [POST /api/Infrastructure/ip-allocations/reconcile]"""
        return self._c.request("POST", "/api/Infrastructure/ip-allocations/reconcile", None, query={"region": region})

    def regions(self) -> Any:
        """Regions.  [GET /api/Infrastructure/regions]"""
        return self._c.request("GET", "/api/Infrastructure/regions", None, query=None)

    def release_ip(self, id_: str, *, target_container: Any = None) -> Any:
        """Release ip.  [DELETE /api/Infrastructure/ip-allocations/{id}]"""
        return self._c.request("DELETE", "/api/Infrastructure/ip-allocations/" + self._c._seg(id_), None, query={"targetContainer": target_container})

    def reverses(self, region: str, block: str) -> Any:
        """Reverses.  [GET /api/Infrastructure/regions/{region}/ips/{block}/reverse]"""
        return self._c.request("GET", "/api/Infrastructure/regions/" + self._c._seg(region) + "/ips/" + self._c._seg(block) + "/reverse", None, query=None)

    def server(self, region: str, name: str) -> Any:
        """Server.  [GET /api/Infrastructure/regions/{region}/servers/{name}]"""
        return self._c.request("GET", "/api/Infrastructure/regions/" + self._c._seg(region) + "/servers/" + self._c._seg(name), None, query=None)

    def servers(self, region: str) -> Any:
        """Servers.  [GET /api/Infrastructure/regions/{region}/servers]"""
        return self._c.request("GET", "/api/Infrastructure/regions/" + self._c._seg(region) + "/servers", None, query=None)

    def set_reverse(self, region: str, body: Any = None) -> Any:
        """Set reverse.  [POST /api/Infrastructure/regions/{region}/reverse]"""
        return self._c.request("POST", "/api/Infrastructure/regions/" + self._c._seg(region) + "/reverse", body, query=None)

class IntegrationsApi:
    """Integrations operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def create(self, body: Any = None) -> Any:
        """Create.  [POST /api/integrations]"""
        return self._c.request("POST", "/api/integrations", body, query=None)

    def delete(self, id_: str) -> Any:
        """Delete.  [DELETE /api/integrations/{id}]"""
        return self._c.request("DELETE", "/api/integrations/" + self._c._seg(id_), None, query=None)

    def get(self, id_: str) -> Any:
        """Get.  [GET /api/integrations/{id}]"""
        return self._c.request("GET", "/api/integrations/" + self._c._seg(id_), None, query=None)

    def list(self) -> Any:
        """List.  [GET /api/integrations]"""
        return self._c.request("GET", "/api/integrations", None, query=None)

    def test(self, id_: str) -> Any:
        """Test.  [POST /api/integrations/{id}/test]"""
        return self._c.request("POST", "/api/integrations/" + self._c._seg(id_) + "/test", None, query=None)

    def update(self, id_: str, body: Any = None) -> Any:
        """Update.  [PUT /api/integrations/{id}]"""
        return self._c.request("PUT", "/api/integrations/" + self._c._seg(id_), body, query=None)

class IoTDeviceGatewayApi:
    """IoTDeviceGateway operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def get_twin(self, device_id: str) -> Any:
        """Get twin.  [GET /api/iot/devices/{deviceId}/twin]"""
        return self._c.request("GET", "/api/iot/devices/" + self._c._seg(device_id) + "/twin", None, query=None)

    def patch_reported(self, device_id: str, body: Any = None) -> Any:
        """Patch reported.  [PATCH /api/iot/devices/{deviceId}/twin/reported]"""
        return self._c.request("PATCH", "/api/iot/devices/" + self._c._seg(device_id) + "/twin/reported", body, query=None)

    def pq_complete(self, device_id: str, body: Any = None) -> Any:
        """Pq complete.  [POST /api/iot/devices/{deviceId}/pq/complete]"""
        return self._c.request("POST", "/api/iot/devices/" + self._c._seg(device_id) + "/pq/complete", body, query=None)

    def pq_handshake(self, device_id: str, body: Any = None) -> Any:
        """Pq handshake.  [POST /api/iot/devices/{deviceId}/pq/handshake]"""
        return self._c.request("POST", "/api/iot/devices/" + self._c._seg(device_id) + "/pq/handshake", body, query=None)

    def receive_commands(self, device_id: str) -> Any:
        """Receive commands.  [GET /api/iot/devices/{deviceId}/messages/devicebound]"""
        return self._c.request("GET", "/api/iot/devices/" + self._c._seg(device_id) + "/messages/devicebound", None, query=None)

    def send_telemetry(self, device_id: str, body: Any = None) -> Any:
        """Send telemetry.  [POST /api/iot/devices/{deviceId}/messages/events]"""
        return self._c.request("POST", "/api/iot/devices/" + self._c._seg(device_id) + "/messages/events", body, query=None)

    def stream(self, device_id: str) -> Any:
        """Stream.  [GET /api/iot/devices/{deviceId}/stream]"""
        return self._c.request("GET", "/api/iot/devices/" + self._c._seg(device_id) + "/stream", None, query=None)

class IoTHubApi:
    """IoTHub operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def get_io_t_hubs(self) -> Any:
        """Get io thubs.  [GET /api/IoTHub/iothubs]"""
        return self._c.request("GET", "/api/IoTHub/iothubs", None, query=None)

class IoTHubDeviceApi:
    """IoTHubDevice operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def get_io_t_hub_devices(self) -> Any:
        """Get io thub devices.  [GET /api/IoTHubDevice/iothub/devices]"""
        return self._c.request("GET", "/api/IoTHubDevice/iothub/devices", None, query=None)

    def get_io_t_hub_devices_get(self, iot_hub_id: str) -> Any:
        """Get io thub devices get.  [GET /api/IoTHubDevice/iothub/{iotHubId}/devices]"""
        return self._c.request("GET", "/api/IoTHubDevice/iothub/" + self._c._seg(iot_hub_id) + "/devices", None, query=None)

class IoTHubDiagnosticsApi:
    """IoTHubDiagnostics operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def create_setting(self, hub_id: str, body: Any = None) -> Any:
        """Create setting.  [POST /api/iothub/{hubId}/diagnostic-settings]"""
        return self._c.request("POST", "/api/iothub/" + self._c._seg(hub_id) + "/diagnostic-settings", body, query=None)

    def delete_setting(self, hub_id: str, id_: str) -> Any:
        """Delete setting.  [DELETE /api/iothub/{hubId}/diagnostic-settings/{id}]"""
        return self._c.request("DELETE", "/api/iothub/" + self._c._seg(hub_id) + "/diagnostic-settings/" + self._c._seg(id_), None, query=None)

    def destinations(self) -> Any:
        """Destinations.  [GET /api/iothub/diagnostic-destinations]"""
        return self._c.request("GET", "/api/iothub/diagnostic-destinations", None, query=None)

    def list_settings(self, hub_id: str) -> Any:
        """List settings.  [GET /api/iothub/{hubId}/diagnostic-settings]"""
        return self._c.request("GET", "/api/iothub/" + self._c._seg(hub_id) + "/diagnostic-settings", None, query=None)

    def log_categories(self) -> Any:
        """Log categories.  [GET /api/iothub/log-categories]"""
        return self._c.request("GET", "/api/iothub/log-categories", None, query=None)

    def logs(self, hub_id: str, *, category: Any = None, device_id: Any = None, limit: Any = None) -> Any:
        """Logs.  [GET /api/iothub/{hubId}/logs]"""
        return self._c.request("GET", "/api/iothub/" + self._c._seg(hub_id) + "/logs", None, query={"category": category, "deviceId": device_id, "limit": limit})

    def metric_definitions(self) -> Any:
        """Metric definitions.  [GET /api/iothub/metric-definitions]"""
        return self._c.request("GET", "/api/iothub/metric-definitions", None, query=None)

    def metrics(self, hub_id: str, *, hours: Any = None, protocol: Any = None) -> Any:
        """Metrics.  [GET /api/iothub/{hubId}/metrics]"""
        return self._c.request("GET", "/api/iothub/" + self._c._seg(hub_id) + "/metrics", None, query={"hours": hours, "protocol": protocol})

class IoTHubManagementApi:
    """IoTHubManagement operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def connection_string(self, hub_id: str, device_id: str) -> Any:
        """Connection string.  [GET /api/iothub/{hubId}/devices/{deviceId}/connection-string]"""
        return self._c.request("GET", "/api/iothub/" + self._c._seg(hub_id) + "/devices/" + self._c._seg(device_id) + "/connection-string", None, query=None)

    def create_device(self, hub_id: str, body: Any = None) -> Any:
        """Create device.  [POST /api/iothub/{hubId}/devices]"""
        return self._c.request("POST", "/api/iothub/" + self._c._seg(hub_id) + "/devices", body, query=None)

    def delete_device(self, hub_id: str, device_id: str) -> Any:
        """Delete device.  [DELETE /api/iothub/{hubId}/devices/{deviceId}]"""
        return self._c.request("DELETE", "/api/iothub/" + self._c._seg(hub_id) + "/devices/" + self._c._seg(device_id), None, query=None)

    def delete_hub(self, hub_id: str) -> Any:
        """Delete hub.  [DELETE /api/iothub/{hubId}]"""
        return self._c.request("DELETE", "/api/iothub/" + self._c._seg(hub_id), None, query=None)

    def get_twin(self, hub_id: str, device_id: str) -> Any:
        """Get twin.  [GET /api/iothub/{hubId}/devices/{deviceId}/twin]"""
        return self._c.request("GET", "/api/iothub/" + self._c._seg(hub_id) + "/devices/" + self._c._seg(device_id) + "/twin", None, query=None)

    def messages(self, hub_id: str, device_id: str, *, direction: Any = None) -> Any:
        """Messages.  [GET /api/iothub/{hubId}/devices/{deviceId}/messages]"""
        return self._c.request("GET", "/api/iothub/" + self._c._seg(hub_id) + "/devices/" + self._c._seg(device_id) + "/messages", None, query={"direction": direction})

    def monitoring(self, hub_id: str) -> Any:
        """Monitoring.  [GET /api/iothub/{hubId}/monitoring]"""
        return self._c.request("GET", "/api/iothub/" + self._c._seg(hub_id) + "/monitoring", None, query=None)

    def receive_c2_d(self, hub_id: str, device_id: str) -> Any:
        """Receive c2 d.  [POST /api/iothub/{hubId}/devices/{deviceId}/c2d/receive]"""
        return self._c.request("POST", "/api/iothub/" + self._c._seg(hub_id) + "/devices/" + self._c._seg(device_id) + "/c2d/receive", None, query=None)

    def regenerate_key(self, hub_id: str, device_id: str) -> Any:
        """Regenerate key.  [POST /api/iothub/{hubId}/devices/{deviceId}/regenerate-key]"""
        return self._c.request("POST", "/api/iothub/" + self._c._seg(hub_id) + "/devices/" + self._c._seg(device_id) + "/regenerate-key", None, query=None)

    def send_c2_d(self, hub_id: str, device_id: str, body: Any = None) -> Any:
        """Send c2 d.  [POST /api/iothub/{hubId}/devices/{deviceId}/c2d]"""
        return self._c.request("POST", "/api/iothub/" + self._c._seg(hub_id) + "/devices/" + self._c._seg(device_id) + "/c2d", body, query=None)

    def send_telemetry(self, hub_id: str, device_id: str, body: Any = None) -> Any:
        """Send telemetry.  [POST /api/iothub/{hubId}/devices/{deviceId}/telemetry]"""
        return self._c.request("POST", "/api/iothub/" + self._c._seg(hub_id) + "/devices/" + self._c._seg(device_id) + "/telemetry", body, query=None)

    def update_twin(self, hub_id: str, device_id: str, body: Any = None) -> Any:
        """Update twin.  [PATCH /api/iothub/{hubId}/devices/{deviceId}/twin]"""
        return self._c.request("PATCH", "/api/iothub/" + self._c._seg(hub_id) + "/devices/" + self._c._seg(device_id) + "/twin", body, query=None)

class IoTHubProtocolApi:
    """IoTHubProtocol operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def algorithms(self) -> Any:
        """Algorithms.  [GET /api/iothub/algorithms]"""
        return self._c.request("GET", "/api/iothub/algorithms", None, query=None)

    def ca_certificate(self, hub_id: str) -> Any:
        """Ca certificate.  [GET /api/iothub/{hubId}/ca]"""
        return self._c.request("GET", "/api/iothub/" + self._c._seg(hub_id) + "/ca", None, query=None)

    def certificates(self, hub_id: str) -> Any:
        """Certificates.  [GET /api/iothub/{hubId}/certificates]"""
        return self._c.request("GET", "/api/iothub/" + self._c._seg(hub_id) + "/certificates", None, query=None)

    def connections(self, hub_id: str) -> Any:
        """Connections.  [GET /api/iothub/{hubId}/connections]"""
        return self._c.request("GET", "/api/iothub/" + self._c._seg(hub_id) + "/connections", None, query=None)

    def issue_certificate(self, hub_id: str, device_id: str, body: Any = None) -> Any:
        """Issue certificate.  [POST /api/iothub/{hubId}/devices/{deviceId}/certificate]"""
        return self._c.request("POST", "/api/iothub/" + self._c._seg(hub_id) + "/devices/" + self._c._seg(device_id) + "/certificate", body, query=None)

    def pq_sessions(self, hub_id: str) -> Any:
        """Pq sessions.  [GET /api/iothub/{hubId}/pq-sessions]"""
        return self._c.request("GET", "/api/iothub/" + self._c._seg(hub_id) + "/pq-sessions", None, query=None)

    def protocols(self) -> Any:
        """Protocols.  [GET /api/iothub/protocols]"""
        return self._c.request("GET", "/api/iothub/protocols", None, query=None)

    def provision(self, hub_id: str, body: Any = None) -> Any:
        """Provision.  [POST /api/iothub/{hubId}/provision]"""
        return self._c.request("POST", "/api/iothub/" + self._c._seg(hub_id) + "/provision", body, query=None)

class K9sConsoleApi:
    """K9sConsole operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def console(self, id_: str) -> Any:
        """Console.  [GET /api/kubernetes/clusters/{id}/console]"""
        return self._c.request("GET", "/api/kubernetes/clusters/" + self._c._seg(id_) + "/console", None, query=None)

    def status(self, id_: str) -> Any:
        """Status.  [GET /api/kubernetes/clusters/{id}/console/status]"""
        return self._c.request("GET", "/api/kubernetes/clusters/" + self._c._seg(id_) + "/console/status", None, query=None)

class KeyVaultApi:
    """KeyVault operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def create(self, body: Any = None) -> Any:
        """Create.  [POST /api/KeyVault]"""
        return self._c.request("POST", "/api/KeyVault", body, query=None)

    def create_certificate(self, id_: str, body: Any = None) -> Any:
        """Create certificate.  [POST /api/KeyVault/{id}/certificates]"""
        return self._c.request("POST", "/api/KeyVault/" + self._c._seg(id_) + "/certificates", body, query=None)

    def delete(self, id_: str) -> Any:
        """Delete.  [DELETE /api/KeyVault/{id}]"""
        return self._c.request("DELETE", "/api/KeyVault/" + self._c._seg(id_), None, query=None)

    def delete_item(self, id_: str, name: str) -> Any:
        """Delete item.  [DELETE /api/KeyVault/{id}/items/{name}]"""
        return self._c.request("DELETE", "/api/KeyVault/" + self._c._seg(id_) + "/items/" + self._c._seg(name), None, query=None)

    def download_csr(self, id_: str, name: str) -> Any:
        """Download csr.  [GET /api/KeyVault/{id}/certificates/{name}/csr]"""
        return self._c.request("GET", "/api/KeyVault/" + self._c._seg(id_) + "/certificates/" + self._c._seg(name) + "/csr", None, query=None)

    def export_certificate(self, id_: str, name: str, body: Any = None) -> Any:
        """Export certificate.  [POST /api/KeyVault/{id}/certificates/{name}/export]"""
        return self._c.request("POST", "/api/KeyVault/" + self._c._seg(id_) + "/certificates/" + self._c._seg(name) + "/export", body, query=None)

    def get(self, id_: str) -> Any:
        """Get.  [GET /api/KeyVault/{id}]"""
        return self._c.request("GET", "/api/KeyVault/" + self._c._seg(id_), None, query=None)

    def get_item(self, id_: str, name: str, *, version: Any = None) -> Any:
        """Get item.  [GET /api/KeyVault/{id}/items/{name}]"""
        return self._c.request("GET", "/api/KeyVault/" + self._c._seg(id_) + "/items/" + self._c._seg(name), None, query={"version": version})

    def list(self) -> Any:
        """List.  [GET /api/KeyVault]"""
        return self._c.request("GET", "/api/KeyVault", None, query=None)

    def list_deleted(self) -> Any:
        """List deleted.  [GET /api/KeyVault/deleted]"""
        return self._c.request("GET", "/api/KeyVault/deleted", None, query=None)

    def list_items(self, id_: str, *, item_type: Any = None, include_deleted: Any = None) -> Any:
        """List items.  [GET /api/KeyVault/{id}/items]"""
        return self._c.request("GET", "/api/KeyVault/" + self._c._seg(id_) + "/items", None, query={"itemType": item_type, "includeDeleted": include_deleted})

    def list_versions(self, id_: str, name: str) -> Any:
        """List versions.  [GET /api/KeyVault/{id}/items/{name}/versions]"""
        return self._c.request("GET", "/api/KeyVault/" + self._c._seg(id_) + "/items/" + self._c._seg(name) + "/versions", None, query=None)

    def merge_certificate(self, id_: str, name: str, body: Any = None) -> Any:
        """Merge certificate.  [POST /api/KeyVault/{id}/certificates/{name}/merge]"""
        return self._c.request("POST", "/api/KeyVault/" + self._c._seg(id_) + "/certificates/" + self._c._seg(name) + "/merge", body, query=None)

    def purge(self, id_: str) -> Any:
        """Purge.  [DELETE /api/KeyVault/{id}/purge]"""
        return self._c.request("DELETE", "/api/KeyVault/" + self._c._seg(id_) + "/purge", None, query=None)

    def recover(self, id_: str) -> Any:
        """Recover.  [POST /api/KeyVault/{id}/recover]"""
        return self._c.request("POST", "/api/KeyVault/" + self._c._seg(id_) + "/recover", None, query=None)

    def recover_item(self, id_: str, name: str) -> Any:
        """Recover item.  [POST /api/KeyVault/{id}/items/{name}/recover]"""
        return self._c.request("POST", "/api/KeyVault/" + self._c._seg(id_) + "/items/" + self._c._seg(name) + "/recover", None, query=None)

    def set_item(self, id_: str, body: Any = None) -> Any:
        """Set item.  [POST /api/KeyVault/{id}/items]"""
        return self._c.request("POST", "/api/KeyVault/" + self._c._seg(id_) + "/items", body, query=None)

    def update(self, id_: str, body: Any = None) -> Any:
        """Update.  [PUT /api/KeyVault/{id}]"""
        return self._c.request("PUT", "/api/KeyVault/" + self._c._seg(id_), body, query=None)

    def update_item(self, id_: str, name: str, body: Any = None, *, version: Any = None) -> Any:
        """Update item.  [PUT /api/KeyVault/{id}/items/{name}]"""
        return self._c.request("PUT", "/api/KeyVault/" + self._c._seg(id_) + "/items/" + self._c._seg(name), body, query={"version": version})

class KubernetesApi:
    """Kubernetes operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def add_pool(self, id_: str, body: Any = None) -> Any:
        """Add pool.  [POST /api/kubernetes/clusters/{id}/node-pools]"""
        return self._c.request("POST", "/api/kubernetes/clusters/" + self._c._seg(id_) + "/node-pools", body, query=None)

    def cordon(self, id_: str, name: str, *, undo: Any = None) -> Any:
        """Cordon.  [POST /api/kubernetes/clusters/{id}/nodes/{name}/cordon]"""
        return self._c.request("POST", "/api/kubernetes/clusters/" + self._c._seg(id_) + "/nodes/" + self._c._seg(name) + "/cordon", None, query={"undo": undo})

    def create(self, body: Any = None) -> Any:
        """Create.  [POST /api/kubernetes/clusters]"""
        return self._c.request("POST", "/api/kubernetes/clusters", body, query=None)

    def delete(self, id_: str) -> Any:
        """Delete.  [DELETE /api/kubernetes/clusters/{id}]"""
        return self._c.request("DELETE", "/api/kubernetes/clusters/" + self._c._seg(id_), None, query=None)

    def delete_pod(self, id_: str, ns: str, name: str) -> Any:
        """Delete pod.  [DELETE /api/kubernetes/clusters/{id}/pods/{ns}/{name}]"""
        return self._c.request("DELETE", "/api/kubernetes/clusters/" + self._c._seg(id_) + "/pods/" + self._c._seg(ns) + "/" + self._c._seg(name), None, query=None)

    def get(self, id_: str) -> Any:
        """Get.  [GET /api/kubernetes/clusters/{id}]"""
        return self._c.request("GET", "/api/kubernetes/clusters/" + self._c._seg(id_), None, query=None)

    def kubeconfig(self, id_: str, *, external: Any = None) -> Any:
        """Kubeconfig.  [GET /api/kubernetes/clusters/{id}/kubeconfig]"""
        return self._c.request("GET", "/api/kubernetes/clusters/" + self._c._seg(id_) + "/kubeconfig", None, query={"external": external})

    def kubectl(self, id_: str, body: Any = None) -> Any:
        """Kubectl.  [POST /api/kubernetes/clusters/{id}/kubectl]"""
        return self._c.request("POST", "/api/kubernetes/clusters/" + self._c._seg(id_) + "/kubectl", body, query=None)

    def list(self) -> Any:
        """List.  [GET /api/kubernetes/clusters]"""
        return self._c.request("GET", "/api/kubernetes/clusters", None, query=None)

    def remove_pool(self, id_: str, pool_id: str) -> Any:
        """Remove pool.  [DELETE /api/kubernetes/clusters/{id}/node-pools/{poolId}]"""
        return self._c.request("DELETE", "/api/kubernetes/clusters/" + self._c._seg(id_) + "/node-pools/" + self._c._seg(pool_id), None, query=None)

    def resources(self, id_: str, kind: str, *, ns: Any = None) -> Any:
        """Resources.  [GET /api/kubernetes/clusters/{id}/resources/{kind}]"""
        return self._c.request("GET", "/api/kubernetes/clusters/" + self._c._seg(id_) + "/resources/" + self._c._seg(kind), None, query={"ns": ns})

    def restart_workload(self, id_: str, kind: str, ns: str, name: str) -> Any:
        """Restart workload.  [POST /api/kubernetes/clusters/{id}/workloads/{kind}/{ns}/{name}/restart]"""
        return self._c.request("POST", "/api/kubernetes/clusters/" + self._c._seg(id_) + "/workloads/" + self._c._seg(kind) + "/" + self._c._seg(ns) + "/" + self._c._seg(name) + "/restart", None, query=None)

    def scale(self, id_: str, kind: str, ns: str, name: str, body: Any = None) -> Any:
        """Scale.  [POST /api/kubernetes/clusters/{id}/workloads/{kind}/{ns}/{name}/scale]"""
        return self._c.request("POST", "/api/kubernetes/clusters/" + self._c._seg(id_) + "/workloads/" + self._c._seg(kind) + "/" + self._c._seg(ns) + "/" + self._c._seg(name) + "/scale", body, query=None)

class MailAdminApi:
    """MailAdmin operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def accounts(self) -> Any:
        """Accounts.  [GET /api/mail/admin/accounts]"""
        return self._c.request("GET", "/api/mail/admin/accounts", None, query=None)

    def create(self, body: Any = None) -> Any:
        """Create.  [POST /api/mail/admin/accounts]"""
        return self._c.request("POST", "/api/mail/admin/accounts", body, query=None)

    def delete(self, id_: str) -> Any:
        """Delete.  [DELETE /api/mail/admin/accounts/{id}]"""
        return self._c.request("DELETE", "/api/mail/admin/accounts/" + self._c._seg(id_), None, query=None)

    def domains(self) -> Any:
        """Domains.  [GET /api/mail/admin/domains]"""
        return self._c.request("GET", "/api/mail/admin/domains", None, query=None)

    def grant(self, id_: str, body: Any = None) -> Any:
        """Grant.  [POST /api/mail/admin/accounts/{id}/access]"""
        return self._c.request("POST", "/api/mail/admin/accounts/" + self._c._seg(id_) + "/access", body, query=None)

    def revoke(self, id_: str, email_id: str) -> Any:
        """Revoke.  [DELETE /api/mail/admin/accounts/{id}/access/{emailId}]"""
        return self._c.request("DELETE", "/api/mail/admin/accounts/" + self._c._seg(id_) + "/access/" + self._c._seg(email_id), None, query=None)

    def set_password(self, id_: str, body: Any = None) -> Any:
        """Set password.  [POST /api/mail/admin/accounts/{id}/password]"""
        return self._c.request("POST", "/api/mail/admin/accounts/" + self._c._seg(id_) + "/password", body, query=None)

    def update(self, id_: str, body: Any = None) -> Any:
        """Update.  [PATCH /api/mail/admin/accounts/{id}]"""
        return self._c.request("PATCH", "/api/mail/admin/accounts/" + self._c._seg(id_), body, query=None)

class MarketplaceApi:
    """Marketplace operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def categories(self) -> Any:
        """Categories.  [GET /api/Marketplace/categories]"""
        return self._c.request("GET", "/api/Marketplace/categories", None, query=None)

    def connections(self) -> Any:
        """Connections.  [GET /api/Marketplace/connections]"""
        return self._c.request("GET", "/api/Marketplace/connections", None, query=None)

    def delete_deployment(self, id_: str) -> Any:
        """Delete deployment.  [DELETE /api/Marketplace/deployments/{id}]"""
        return self._c.request("DELETE", "/api/Marketplace/deployments/" + self._c._seg(id_), None, query=None)

    def deploy(self, body: Any = None) -> Any:
        """Deploy.  [POST /api/Marketplace/deploy]"""
        return self._c.request("POST", "/api/Marketplace/deploy", body, query=None)

    def deployments(self) -> Any:
        """Deployments.  [GET /api/Marketplace/deployments]"""
        return self._c.request("GET", "/api/Marketplace/deployments", None, query=None)

    def offer(self, slug: str) -> Any:
        """Offer.  [GET /api/Marketplace/offers/{slug}]"""
        return self._c.request("GET", "/api/Marketplace/offers/" + self._c._seg(slug), None, query=None)

    def offers(self, *, search: Any = None, category: Any = None, source: Any = None, delivery: Any = None, featured: Any = None, take: Any = None) -> Any:
        """Offers.  [GET /api/Marketplace/offers]"""
        return self._c.request("GET", "/api/Marketplace/offers", None, query={"search": search, "category": category, "source": source, "delivery": delivery, "featured": featured, "take": take})

    def publish(self, body: Any = None) -> Any:
        """Publish.  [POST /api/Marketplace/offers]"""
        return self._c.request("POST", "/api/Marketplace/offers", body, query=None)

    def save_connection(self, body: Any = None) -> Any:
        """Save connection.  [POST /api/Marketplace/connections]"""
        return self._c.request("POST", "/api/Marketplace/connections", body, query=None)

    def sync(self, id_: str) -> Any:
        """Sync.  [POST /api/Marketplace/connections/{id}/sync]"""
        return self._c.request("POST", "/api/Marketplace/connections/" + self._c._seg(id_) + "/sync", None, query=None)

    def unpublish(self, id_: str) -> Any:
        """Unpublish.  [DELETE /api/Marketplace/offers/{id}]"""
        return self._c.request("DELETE", "/api/Marketplace/offers/" + self._c._seg(id_), None, query=None)

class MetricsApi:
    """Metrics operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def get(self, resource_id: str) -> Any:
        """Get.  [GET /api/metrics/{resourceId}]"""
        return self._c.request("GET", "/api/metrics/" + self._c._seg(resource_id), None, query=None)

    def get_file_operation_metrics(self, storage_account_id: str, *, limit: Any = None, region: Any = None) -> Any:
        """Get file operation metrics.  [GET /api/Metrics/storage/{storageAccountId}/operations]"""
        return self._c.request("GET", "/api/Metrics/storage/" + self._c._seg(storage_account_id) + "/operations", None, query={"limit": limit, "region": region})

    def get_quick_stats(self, storage_account_id: str, *, region: Any = None) -> Any:
        """Get quick stats.  [GET /api/Metrics/storage/{storageAccountId}/stats]"""
        return self._c.request("GET", "/api/Metrics/storage/" + self._c._seg(storage_account_id) + "/stats", None, query={"region": region})

    def get_request_metrics(self, storage_account_id: str, *, range_: Any = None, region: Any = None) -> Any:
        """Get request metrics.  [GET /api/Metrics/storage/{storageAccountId}/requests]"""
        return self._c.request("GET", "/api/Metrics/storage/" + self._c._seg(storage_account_id) + "/requests", None, query={"range": range_, "region": region})

    def get_storage_metrics(self, storage_account_id: str, *, range_: Any = None, region: Any = None) -> Any:
        """Get storage metrics.  [GET /api/Metrics/storage/{storageAccountId}]"""
        return self._c.request("GET", "/api/Metrics/storage/" + self._c._seg(storage_account_id), None, query={"range": range_, "region": region})

    def ingest_storage_metric(self, body: Any = None) -> Any:
        """Ingest storage metric.  [POST /api/Metrics/ingest/storage]"""
        return self._c.request("POST", "/api/Metrics/ingest/storage", body, query=None)

class MongoApi:
    """Mongo operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def collections(self, id_: str, database: str) -> Any:
        """Collections.  [GET /api/Mongo/{id}/databases/{database}/collections]"""
        return self._c.request("GET", "/api/Mongo/" + self._c._seg(id_) + "/databases/" + self._c._seg(database) + "/collections", None, query=None)

    def connection(self, id_: str) -> Any:
        """Connection.  [GET /api/Mongo/{id}/connection]"""
        return self._c.request("GET", "/api/Mongo/" + self._c._seg(id_) + "/connection", None, query=None)

    def create(self, body: Any = None) -> Any:
        """Create.  [POST /api/Mongo]"""
        return self._c.request("POST", "/api/Mongo", body, query=None)

    def databases(self, id_: str) -> Any:
        """Databases.  [GET /api/Mongo/{id}/databases]"""
        return self._c.request("GET", "/api/Mongo/" + self._c._seg(id_) + "/databases", None, query=None)

    def delete(self, id_: str) -> Any:
        """Delete.  [DELETE /api/Mongo/{id}]"""
        return self._c.request("DELETE", "/api/Mongo/" + self._c._seg(id_), None, query=None)

    def get(self, id_: str) -> Any:
        """Get.  [GET /api/Mongo/{id}]"""
        return self._c.request("GET", "/api/Mongo/" + self._c._seg(id_), None, query=None)

    def list(self) -> Any:
        """List.  [GET /api/Mongo]"""
        return self._c.request("GET", "/api/Mongo", None, query=None)

    def replica_status(self, id_: str) -> Any:
        """Replica status.  [GET /api/Mongo/{id}/replica-status]"""
        return self._c.request("GET", "/api/Mongo/" + self._c._seg(id_) + "/replica-status", None, query=None)

    def run_command(self, id_: str, body: Any = None) -> Any:
        """Run command.  [POST /api/Mongo/{id}/command]"""
        return self._c.request("POST", "/api/Mongo/" + self._c._seg(id_) + "/command", body, query=None)

    def set_consistency(self, id_: str, body: Any = None) -> Any:
        """Set consistency.  [PUT /api/Mongo/{id}/consistency]"""
        return self._c.request("PUT", "/api/Mongo/" + self._c._seg(id_) + "/consistency", body, query=None)

    def start(self, id_: str) -> Any:
        """Start.  [POST /api/Mongo/{id}/start]"""
        return self._c.request("POST", "/api/Mongo/" + self._c._seg(id_) + "/start", None, query=None)

    def stop(self, id_: str) -> Any:
        """Stop.  [POST /api/Mongo/{id}/stop]"""
        return self._c.request("POST", "/api/Mongo/" + self._c._seg(id_) + "/stop", None, query=None)

class MySqlDatabaseApi:
    """MySqlDatabase operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def columns(self, id_: str, schema: str, table: str, *, database: Any = None) -> Any:
        """Columns.  [GET /api/MySqlDatabase/{id}/objects/{schema}/{table}/columns]"""
        return self._c.request("GET", "/api/MySqlDatabase/" + self._c._seg(id_) + "/objects/" + self._c._seg(schema) + "/" + self._c._seg(table) + "/columns", None, query={"database": database})

    def connection(self, id_: str) -> Any:
        """Connection.  [GET /api/MySqlDatabase/{id}/connection]"""
        return self._c.request("GET", "/api/MySqlDatabase/" + self._c._seg(id_) + "/connection", None, query=None)

    def create(self, body: Any = None) -> Any:
        """Create.  [POST /api/MySqlDatabase]"""
        return self._c.request("POST", "/api/MySqlDatabase", body, query=None)

    def databases(self, id_: str) -> Any:
        """Databases.  [GET /api/MySqlDatabase/{id}/databases]"""
        return self._c.request("GET", "/api/MySqlDatabase/" + self._c._seg(id_) + "/databases", None, query=None)

    def delete(self, id_: str) -> Any:
        """Delete.  [DELETE /api/MySqlDatabase/{id}]"""
        return self._c.request("DELETE", "/api/MySqlDatabase/" + self._c._seg(id_), None, query=None)

    def get(self, id_: str) -> Any:
        """Get.  [GET /api/MySqlDatabase/{id}]"""
        return self._c.request("GET", "/api/MySqlDatabase/" + self._c._seg(id_), None, query=None)

    def list(self) -> Any:
        """List.  [GET /api/MySqlDatabase]"""
        return self._c.request("GET", "/api/MySqlDatabase", None, query=None)

    def objects(self, id_: str, *, database: Any = None) -> Any:
        """Objects.  [GET /api/MySqlDatabase/{id}/objects]"""
        return self._c.request("GET", "/api/MySqlDatabase/" + self._c._seg(id_) + "/objects", None, query={"database": database})

    def query(self, id_: str, body: Any = None) -> Any:
        """Query.  [POST /api/MySqlDatabase/{id}/query]"""
        return self._c.request("POST", "/api/MySqlDatabase/" + self._c._seg(id_) + "/query", body, query=None)

    def reset_password(self, id_: str, body: Any = None) -> Any:
        """Reset password.  [POST /api/MySqlDatabase/{id}/reset-password]"""
        return self._c.request("POST", "/api/MySqlDatabase/" + self._c._seg(id_) + "/reset-password", body, query=None)

class NetworkAccessApi:
    """NetworkAccess operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def create_endpoint(self, resource_type: str, resource_id: str, body: Any = None) -> Any:
        """Create endpoint.  [POST /api/network-access/{resourceType}/{resourceId}/private-endpoints]"""
        return self._c.request("POST", "/api/network-access/" + self._c._seg(resource_type) + "/" + self._c._seg(resource_id) + "/private-endpoints", body, query=None)

    def delete_endpoint(self, resource_type: str, resource_id: str, id_: str) -> Any:
        """Delete endpoint.  [DELETE /api/network-access/{resourceType}/{resourceId}/private-endpoints/{id}]"""
        return self._c.request("DELETE", "/api/network-access/" + self._c._seg(resource_type) + "/" + self._c._seg(resource_id) + "/private-endpoints/" + self._c._seg(id_), None, query=None)

    def get(self, resource_type: str, resource_id: str) -> Any:
        """Get.  [GET /api/network-access/{resourceType}/{resourceId}]"""
        return self._c.request("GET", "/api/network-access/" + self._c._seg(resource_type) + "/" + self._c._seg(resource_id), None, query=None)

    def list_endpoints(self, resource_type: str, resource_id: str) -> Any:
        """List endpoints.  [GET /api/network-access/{resourceType}/{resourceId}/private-endpoints]"""
        return self._c.request("GET", "/api/network-access/" + self._c._seg(resource_type) + "/" + self._c._seg(resource_id) + "/private-endpoints", None, query=None)

    def set(self, resource_type: str, resource_id: str, body: Any = None) -> Any:
        """Set.  [PUT /api/network-access/{resourceType}/{resourceId}]"""
        return self._c.request("PUT", "/api/network-access/" + self._c._seg(resource_type) + "/" + self._c._seg(resource_id), body, query=None)

    def source_presets(self, *, resource_type: Any = None, resource_id: Any = None) -> Any:
        """Source presets.  [GET /api/network-access/source-presets]"""
        return self._c.request("GET", "/api/network-access/source-presets", None, query={"resourceType": resource_type, "resourceId": resource_id})

class NotificationApi:
    """Notification operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def get_notification(self) -> Any:
        """Get notification.  [GET /api/Notification/notification]"""
        return self._c.request("GET", "/api/Notification/notification", None, query=None)

class OAuthApi:
    """OAuth operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def get_client_token(self, body: Any = None) -> Any:
        """Get client token.  [POST /api/OAuth/token/client]"""
        return self._c.request("POST", "/api/OAuth/token/client", body, query=None)

    def get_token(self, body: Any = None, *, handoff: Any = None) -> Any:
        """Get token.  [POST /api/OAuth/token]"""
        return self._c.request("POST", "/api/OAuth/token", body, query={"handoff": handoff})

    def redeem_handoff(self, body: Any = None) -> Any:
        """Redeem handoff.  [POST /api/OAuth/handoff/redeem]"""
        return self._c.request("POST", "/api/OAuth/handoff/redeem", body, query=None)

class OVSApi:
    """OVS operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def add_port(self, bridge_id: str, body: Any = None) -> Any:
        """Add port.  [POST /api/OVS/bridges/{bridgeId}/ports]"""
        return self._c.request("POST", "/api/OVS/bridges/" + self._c._seg(bridge_id) + "/ports", body, query=None)

    def create_bridge(self, body: Any = None) -> Any:
        """Create bridge.  [POST /api/OVS/bridges]"""
        return self._c.request("POST", "/api/OVS/bridges", body, query=None)

    def delete_bridge(self, bridge_id: str) -> Any:
        """Delete bridge.  [DELETE /api/OVS/bridges/{bridgeId}]"""
        return self._c.request("DELETE", "/api/OVS/bridges/" + self._c._seg(bridge_id), None, query=None)

    def delete_port(self, bridge_id: str, port_name: str) -> Any:
        """Delete port.  [DELETE /api/OVS/bridges/{bridgeId}/ports/{portName}]"""
        return self._c.request("DELETE", "/api/OVS/bridges/" + self._c._seg(bridge_id) + "/ports/" + self._c._seg(port_name), None, query=None)

    def get_bridge(self, bridge_id: str) -> Any:
        """Get bridge.  [GET /api/OVS/bridges/{bridgeId}]"""
        return self._c.request("GET", "/api/OVS/bridges/" + self._c._seg(bridge_id), None, query=None)

    def list_bridges(self) -> Any:
        """List bridges.  [GET /api/OVS/bridges]"""
        return self._c.request("GET", "/api/OVS/bridges", None, query=None)

class OidcApi:
    """Oidc operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def approve(self, body: Any = None) -> Any:
        """Approve.  [POST /api/hiok-id/oidc/authorize]"""
        return self._c.request("POST", "/api/hiok-id/oidc/authorize", body, query=None)

    def authorize(self, *, client_id: Any = None, redirect_uri: Any = None, response_type: Any = None) -> Any:
        """Authorize.  [GET /api/hiok-id/oidc/authorize]"""
        return self._c.request("GET", "/api/hiok-id/oidc/authorize", None, query={"client_id": client_id, "redirect_uri": redirect_uri, "response_type": response_type})

    def authorize_info(self, *, client_id: Any = None, redirect_uri: Any = None) -> Any:
        """Authorize info.  [GET /api/hiok-id/oidc/authorize/info]"""
        return self._c.request("GET", "/api/hiok-id/oidc/authorize/info", None, query={"client_id": client_id, "redirect_uri": redirect_uri})

    def discovery(self) -> Any:
        """Discovery.  [GET /api/hiok-id/oidc/.well-known/openid-configuration]"""
        return self._c.request("GET", "/api/hiok-id/oidc/.well-known/openid-configuration", None, query=None)

    def jwks(self) -> Any:
        """Jwks.  [GET /api/hiok-id/oidc/jwks]"""
        return self._c.request("GET", "/api/hiok-id/oidc/jwks", None, query=None)

    def token(self, body: Any = None) -> Any:
        """Token.  [POST /api/hiok-id/oidc/token]"""
        return self._c.request("POST", "/api/hiok-id/oidc/token", body, query=None)

    def user_info(self) -> Any:
        """User info.  [GET /api/hiok-id/oidc/userinfo]"""
        return self._c.request("GET", "/api/hiok-id/oidc/userinfo", None, query=None)

class PanelApi:
    """Panel operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def create_panel(self, body: Any = None) -> Any:
        """Create panel.  [POST /api/Panel/createpanel]"""
        return self._c.request("POST", "/api/Panel/createpanel", body, query=None)

    def delete_panel(self, id_: str) -> Any:
        """Delete panel.  [DELETE /api/Panel/deletepanel/{id}]"""
        return self._c.request("DELETE", "/api/Panel/deletepanel/" + self._c._seg(id_), None, query=None)

    def get_panels(self) -> Any:
        """Get panels.  [GET /api/Panel/panels]"""
        return self._c.request("GET", "/api/Panel/panels", None, query=None)

    def panel_by_id(self, id_: str) -> Any:
        """Panel by id.  [GET /api/Panel/panel/{id}]"""
        return self._c.request("GET", "/api/Panel/panel/" + self._c._seg(id_), None, query=None)

    def update_panel(self, id_: str, body: Any = None) -> Any:
        """Update panel.  [PUT /api/Panel/updatepanel/{id}]"""
        return self._c.request("PUT", "/api/Panel/updatepanel/" + self._c._seg(id_), body, query=None)

class PostgresDatabaseApi:
    """PostgresDatabase operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def columns(self, id_: str, schema: str, table: str, *, database: Any = None) -> Any:
        """Columns.  [GET /api/PostgresDatabase/{id}/objects/{schema}/{table}/columns]"""
        return self._c.request("GET", "/api/PostgresDatabase/" + self._c._seg(id_) + "/objects/" + self._c._seg(schema) + "/" + self._c._seg(table) + "/columns", None, query={"database": database})

    def connection(self, id_: str) -> Any:
        """Connection.  [GET /api/PostgresDatabase/{id}/connection]"""
        return self._c.request("GET", "/api/PostgresDatabase/" + self._c._seg(id_) + "/connection", None, query=None)

    def create(self, body: Any = None) -> Any:
        """Create.  [POST /api/PostgresDatabase]"""
        return self._c.request("POST", "/api/PostgresDatabase", body, query=None)

    def databases(self, id_: str) -> Any:
        """Databases.  [GET /api/PostgresDatabase/{id}/databases]"""
        return self._c.request("GET", "/api/PostgresDatabase/" + self._c._seg(id_) + "/databases", None, query=None)

    def delete(self, id_: str) -> Any:
        """Delete.  [DELETE /api/PostgresDatabase/{id}]"""
        return self._c.request("DELETE", "/api/PostgresDatabase/" + self._c._seg(id_), None, query=None)

    def get(self, id_: str) -> Any:
        """Get.  [GET /api/PostgresDatabase/{id}]"""
        return self._c.request("GET", "/api/PostgresDatabase/" + self._c._seg(id_), None, query=None)

    def list(self) -> Any:
        """List.  [GET /api/PostgresDatabase]"""
        return self._c.request("GET", "/api/PostgresDatabase", None, query=None)

    def objects(self, id_: str, *, database: Any = None) -> Any:
        """Objects.  [GET /api/PostgresDatabase/{id}/objects]"""
        return self._c.request("GET", "/api/PostgresDatabase/" + self._c._seg(id_) + "/objects", None, query={"database": database})

    def query(self, id_: str, body: Any = None) -> Any:
        """Query.  [POST /api/PostgresDatabase/{id}/query]"""
        return self._c.request("POST", "/api/PostgresDatabase/" + self._c._seg(id_) + "/query", body, query=None)

    def reset_password(self, id_: str, body: Any = None) -> Any:
        """Reset password.  [POST /api/PostgresDatabase/{id}/reset-password]"""
        return self._c.request("POST", "/api/PostgresDatabase/" + self._c._seg(id_) + "/reset-password", body, query=None)

class PricingApi:
    """Pricing operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def list(self) -> Any:
        """List.  [GET /api/Pricing]"""
        return self._c.request("GET", "/api/Pricing", None, query=None)

    def rate_card(self) -> Any:
        """Rate card.  [GET /api/Pricing/ratecard]"""
        return self._c.request("GET", "/api/Pricing/ratecard", None, query=None)

    def update(self, body: Any = None) -> Any:
        """Update.  [PUT /api/Pricing]"""
        return self._c.request("PUT", "/api/Pricing", body, query=None)

class ProfileApi:
    """Profile operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def api_keys(self) -> Any:
        """Api keys.  [GET /api/profile/api-keys]"""
        return self._c.request("GET", "/api/profile/api-keys", None, query=None)

    def get(self) -> Any:
        """Get.  [GET /api/profile]"""
        return self._c.request("GET", "/api/profile", None, query=None)

    def roll_key(self, which: str) -> Any:
        """Roll key.  [POST /api/profile/api-keys/{which}/roll]"""
        return self._c.request("POST", "/api/profile/api-keys/" + self._c._seg(which) + "/roll", None, query=None)

    def update(self, body: Any = None) -> Any:
        """Update.  [PUT /api/profile]"""
        return self._c.request("PUT", "/api/profile", body, query=None)

class PulseApi:
    """Pulse operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def create_consumer_group(self, id_: str, stream: str, body: Any = None) -> Any:
        """Create consumer group.  [POST /api/Pulse/namespaces/{id}/streams/{stream}/consumer-groups]"""
        return self._c.request("POST", "/api/Pulse/namespaces/" + self._c._seg(id_) + "/streams/" + self._c._seg(stream) + "/consumer-groups", body, query=None)

    def create_event_subscription(self, id_: str, stream: str, body: Any = None) -> Any:
        """Create event subscription.  [POST /api/Pulse/namespaces/{id}/streams/{stream}/subscriptions]"""
        return self._c.request("POST", "/api/Pulse/namespaces/" + self._c._seg(id_) + "/streams/" + self._c._seg(stream) + "/subscriptions", body, query=None)

    def create_namespace(self, body: Any = None) -> Any:
        """Create namespace.  [POST /api/Pulse/namespaces]"""
        return self._c.request("POST", "/api/Pulse/namespaces", body, query=None)

    def create_stream(self, id_: str, body: Any = None) -> Any:
        """Create stream.  [POST /api/Pulse/namespaces/{id}/streams]"""
        return self._c.request("POST", "/api/Pulse/namespaces/" + self._c._seg(id_) + "/streams", body, query=None)

    def delete_consumer_group(self, id_: str, stream: str, name: str) -> Any:
        """Delete consumer group.  [DELETE /api/Pulse/namespaces/{id}/streams/{stream}/consumer-groups/{name}]"""
        return self._c.request("DELETE", "/api/Pulse/namespaces/" + self._c._seg(id_) + "/streams/" + self._c._seg(stream) + "/consumer-groups/" + self._c._seg(name), None, query=None)

    def delete_event_subscription(self, id_: str, stream: str, name: str) -> Any:
        """Delete event subscription.  [DELETE /api/Pulse/namespaces/{id}/streams/{stream}/subscriptions/{name}]"""
        return self._c.request("DELETE", "/api/Pulse/namespaces/" + self._c._seg(id_) + "/streams/" + self._c._seg(stream) + "/subscriptions/" + self._c._seg(name), None, query=None)

    def delete_namespace(self, id_: str) -> Any:
        """Delete namespace.  [DELETE /api/Pulse/namespaces/{id}]"""
        return self._c.request("DELETE", "/api/Pulse/namespaces/" + self._c._seg(id_), None, query=None)

    def delete_stream(self, id_: str, name: str) -> Any:
        """Delete stream.  [DELETE /api/Pulse/namespaces/{id}/streams/{name}]"""
        return self._c.request("DELETE", "/api/Pulse/namespaces/" + self._c._seg(id_) + "/streams/" + self._c._seg(name), None, query=None)

    def list_consumer_groups(self, id_: str, stream: str) -> Any:
        """List consumer groups.  [GET /api/Pulse/namespaces/{id}/streams/{stream}/consumer-groups]"""
        return self._c.request("GET", "/api/Pulse/namespaces/" + self._c._seg(id_) + "/streams/" + self._c._seg(stream) + "/consumer-groups", None, query=None)

    def list_deliveries(self, id_: str, stream: str, name: str, *, limit: Any = None) -> Any:
        """List deliveries.  [GET /api/Pulse/namespaces/{id}/streams/{stream}/subscriptions/{name}/deliveries]"""
        return self._c.request("GET", "/api/Pulse/namespaces/" + self._c._seg(id_) + "/streams/" + self._c._seg(stream) + "/subscriptions/" + self._c._seg(name) + "/deliveries", None, query={"limit": limit})

    def list_event_subscriptions(self, id_: str, stream: str) -> Any:
        """List event subscriptions.  [GET /api/Pulse/namespaces/{id}/streams/{stream}/subscriptions]"""
        return self._c.request("GET", "/api/Pulse/namespaces/" + self._c._seg(id_) + "/streams/" + self._c._seg(stream) + "/subscriptions", None, query=None)

    def list_namespaces(self) -> Any:
        """List namespaces.  [GET /api/Pulse/namespaces]"""
        return self._c.request("GET", "/api/Pulse/namespaces", None, query=None)

    def list_streams(self, id_: str) -> Any:
        """List streams.  [GET /api/Pulse/namespaces/{id}/streams]"""
        return self._c.request("GET", "/api/Pulse/namespaces/" + self._c._seg(id_) + "/streams", None, query=None)

    def publish(self, id_: str, stream: str, body: Any = None) -> Any:
        """Publish.  [POST /api/Pulse/namespaces/{id}/streams/{stream}/events]"""
        return self._c.request("POST", "/api/Pulse/namespaces/" + self._c._seg(id_) + "/streams/" + self._c._seg(stream) + "/events", body, query=None)

    def read(self, id_: str, stream: str, *, consumer_group: Any = None, max_events: Any = None) -> Any:
        """Read.  [POST /api/Pulse/namespaces/{id}/streams/{stream}/events/read]"""
        return self._c.request("POST", "/api/Pulse/namespaces/" + self._c._seg(id_) + "/streams/" + self._c._seg(stream) + "/events/read", None, query={"consumerGroup": consumer_group, "maxEvents": max_events})

class RecentResourcesApi:
    """RecentResources operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def clear(self, *, id_: Any = None) -> Any:
        """Clear.  [DELETE /api/recent-resources]"""
        return self._c.request("DELETE", "/api/recent-resources", None, query={"id": id_})

    def list(self) -> Any:
        """List.  [GET /api/recent-resources]"""
        return self._c.request("GET", "/api/recent-resources", None, query=None)

    def record(self, body: Any = None) -> Any:
        """Record.  [POST /api/recent-resources]"""
        return self._c.request("POST", "/api/recent-resources", body, query=None)

    def toggle_favourite(self, body: Any = None) -> Any:
        """Toggle favourite.  [POST /api/recent-resources/favourite]"""
        return self._c.request("POST", "/api/recent-resources/favourite", body, query=None)

class ResourceGovernanceApi:
    """ResourceGovernance operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def create_lock(self, resource_type: str, resource_id: str, body: Any = None) -> Any:
        """Create lock.  [POST /api/resource-governance/{resourceType}/{resourceId}/locks]"""
        return self._c.request("POST", "/api/resource-governance/" + self._c._seg(resource_type) + "/" + self._c._seg(resource_id) + "/locks", body, query=None)

    def delete_lock(self, resource_type: str, resource_id: str, lock_id: str) -> Any:
        """Delete lock.  [DELETE /api/resource-governance/{resourceType}/{resourceId}/locks/{lockId}]"""
        return self._c.request("DELETE", "/api/resource-governance/" + self._c._seg(resource_type) + "/" + self._c._seg(resource_id) + "/locks/" + self._c._seg(lock_id), None, query=None)

    def estate(self) -> Any:
        """Estate.  [GET /api/resource-governance/estate]"""
        return self._c.request("GET", "/api/resource-governance/estate", None, query=None)

    def get_activity_log(self, resource_type: str, resource_id: str, *, limit: Any = None) -> Any:
        """Get activity log.  [GET /api/resource-governance/{resourceType}/{resourceId}/activity-log]"""
        return self._c.request("GET", "/api/resource-governance/" + self._c._seg(resource_type) + "/" + self._c._seg(resource_id) + "/activity-log", None, query={"limit": limit})

    def get_properties(self, resource_type: str, resource_id: str) -> Any:
        """Get properties.  [GET /api/resource-governance/{resourceType}/{resourceId}/properties]"""
        return self._c.request("GET", "/api/resource-governance/" + self._c._seg(resource_type) + "/" + self._c._seg(resource_id) + "/properties", None, query=None)

    def get_tenant_activity(self, *, mine: Any = None, resource_type: Any = None, status: Any = None, hours: Any = None, limit: Any = None) -> Any:
        """Get tenant activity.  [GET /api/resource-governance/activity]"""
        return self._c.request("GET", "/api/resource-governance/activity", None, query={"mine": mine, "resourceType": resource_type, "status": status, "hours": hours, "limit": limit})

    def list_locks(self, resource_type: str, resource_id: str, *, include_inherited: Any = None) -> Any:
        """List locks.  [GET /api/resource-governance/{resourceType}/{resourceId}/locks]"""
        return self._c.request("GET", "/api/resource-governance/" + self._c._seg(resource_type) + "/" + self._c._seg(resource_id) + "/locks", None, query={"includeInherited": include_inherited})

    def scopes(self, *, ids: Any = None) -> Any:
        """Scopes.  [GET /api/resource-governance/scopes]"""
        return self._c.request("GET", "/api/resource-governance/scopes", None, query={"ids": ids})

    def update_tags(self, resource_type: str, resource_id: str, body: Any = None) -> Any:
        """Update tags.  [PUT /api/resource-governance/{resourceType}/{resourceId}/tags]"""
        return self._c.request("PUT", "/api/resource-governance/" + self._c._seg(resource_type) + "/" + self._c._seg(resource_id) + "/tags", body, query=None)

class ResourceGroupsApi:
    """ResourceGroups operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def create_resource_group(self, body: Any = None) -> Any:
        """Create resource group.  [POST /api/resourcegroups]"""
        return self._c.request("POST", "/api/resourcegroups", body, query=None)

    def delete_resource_group(self, id_: str) -> Any:
        """Delete resource group.  [DELETE /api/resourcegroups/{id}]"""
        return self._c.request("DELETE", "/api/resourcegroups/" + self._c._seg(id_), None, query=None)

    def list_resource_groups(self) -> Any:
        """List resource groups.  [GET /api/resourcegroups]"""
        return self._c.request("GET", "/api/resourcegroups", None, query=None)

class ResourceMetricsApi:
    """ResourceMetrics operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def api(self, *, from_: Any = None, to: Any = None, route: Any = None) -> Any:
        """Api.  [GET /api/resource-metrics/api]"""
        return self._c.request("GET", "/api/resource-metrics/api", None, query={"from": from_, "to": to, "route": route})

    def catalogue(self) -> Any:
        """Catalogue.  [GET /api/resource-metrics/catalogue]"""
        return self._c.request("GET", "/api/resource-metrics/catalogue", None, query=None)

    def collect(self, *, region: Any = None) -> Any:
        """Collect.  [POST /api/resource-metrics/collect]"""
        return self._c.request("POST", "/api/resource-metrics/collect", None, query={"region": region})

    def cost(self, resource_kind: str, resource_name: str, *, from_: Any = None, to: Any = None, region: Any = None) -> Any:
        """Cost.  [GET /api/resource-metrics/cost/{resourceKind}/{resourceName}]"""
        return self._c.request("GET", "/api/resource-metrics/cost/" + self._c._seg(resource_kind) + "/" + self._c._seg(resource_name), None, query={"from": from_, "to": to, "region": region})

    def cost_totals(self, *, region: Any = None, from_: Any = None, to: Any = None) -> Any:
        """Cost totals.  [GET /api/resource-metrics/cost-totals]"""
        return self._c.request("GET", "/api/resource-metrics/cost-totals", None, query={"region": region, "from": from_, "to": to})

    def reporting(self, *, region: Any = None, resource_kind: Any = None) -> Any:
        """Reporting.  [GET /api/resource-metrics/reporting]"""
        return self._c.request("GET", "/api/resource-metrics/reporting", None, query={"region": region, "resourceKind": resource_kind})

    def series(self, resource_kind: str, resource_name: str, *, from_: Any = None, to: Any = None, granularity: Any = None, metrics: Any = None, region: Any = None) -> Any:
        """Series.  [GET /api/resource-metrics/{resourceKind}/{resourceName}]"""
        return self._c.request("GET", "/api/resource-metrics/" + self._c._seg(resource_kind) + "/" + self._c._seg(resource_name), None, query={"from": from_, "to": to, "granularity": granularity, "metrics": metrics, "region": region})

class ResourceOperationsApi:
    """ResourceOperations operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def alerts(self, resource_type: str, resource_id: str) -> Any:
        """Alerts.  [GET /api/resource-ops/{resourceType}/{resourceId}/alerts]"""
        return self._c.request("GET", "/api/resource-ops/" + self._c._seg(resource_type) + "/" + self._c._seg(resource_id) + "/alerts", None, query=None)

    def close_support(self, id_: str, body: Any = None) -> Any:
        """Close support.  [POST /api/resource-ops/support/{id}/close]"""
        return self._c.request("POST", "/api/resource-ops/support/" + self._c._seg(id_) + "/close", body, query=None)

    def delete_alert(self, resource_type: str, resource_id: str, id_: str) -> Any:
        """Delete alert.  [DELETE /api/resource-ops/{resourceType}/{resourceId}/alerts/{id}]"""
        return self._c.request("DELETE", "/api/resource-ops/" + self._c._seg(resource_type) + "/" + self._c._seg(resource_id) + "/alerts/" + self._c._seg(id_), None, query=None)

    def delete_diagnostic(self, resource_type: str, resource_id: str, id_: str) -> Any:
        """Delete diagnostic.  [DELETE /api/resource-ops/{resourceType}/{resourceId}/diagnostics/{id}]"""
        return self._c.request("DELETE", "/api/resource-ops/" + self._c._seg(resource_type) + "/" + self._c._seg(resource_id) + "/diagnostics/" + self._c._seg(id_), None, query=None)

    def delete_task(self, resource_type: str, resource_id: str, id_: str) -> Any:
        """Delete task.  [DELETE /api/resource-ops/{resourceType}/{resourceId}/tasks/{id}]"""
        return self._c.request("DELETE", "/api/resource-ops/" + self._c._seg(resource_type) + "/" + self._c._seg(resource_id) + "/tasks/" + self._c._seg(id_), None, query=None)

    def diagnostics(self, resource_type: str, resource_id: str) -> Any:
        """Diagnostics.  [GET /api/resource-ops/{resourceType}/{resourceId}/diagnostics]"""
        return self._c.request("GET", "/api/resource-ops/" + self._c._seg(resource_type) + "/" + self._c._seg(resource_id) + "/diagnostics", None, query=None)

    def health(self, resource_type: str, resource_id: str) -> Any:
        """Health.  [GET /api/resource-ops/{resourceType}/{resourceId}/health]"""
        return self._c.request("GET", "/api/resource-ops/" + self._c._seg(resource_type) + "/" + self._c._seg(resource_id) + "/health", None, query=None)

    def logs(self, resource_type: str, resource_id: str, *, tail: Any = None) -> Any:
        """Logs.  [GET /api/resource-ops/{resourceType}/{resourceId}/logs]"""
        return self._c.request("GET", "/api/resource-ops/" + self._c._seg(resource_type) + "/" + self._c._seg(resource_id) + "/logs", None, query={"tail": tail})

    def raise_support(self, resource_type: str, resource_id: str, body: Any = None) -> Any:
        """Raise support.  [POST /api/resource-ops/{resourceType}/{resourceId}/support]"""
        return self._c.request("POST", "/api/resource-ops/" + self._c._seg(resource_type) + "/" + self._c._seg(resource_id) + "/support", body, query=None)

    def save_alert(self, resource_type: str, resource_id: str, body: Any = None) -> Any:
        """Save alert.  [POST /api/resource-ops/{resourceType}/{resourceId}/alerts]"""
        return self._c.request("POST", "/api/resource-ops/" + self._c._seg(resource_type) + "/" + self._c._seg(resource_id) + "/alerts", body, query=None)

    def save_diagnostic(self, resource_type: str, resource_id: str, body: Any = None) -> Any:
        """Save diagnostic.  [POST /api/resource-ops/{resourceType}/{resourceId}/diagnostics]"""
        return self._c.request("POST", "/api/resource-ops/" + self._c._seg(resource_type) + "/" + self._c._seg(resource_id) + "/diagnostics", body, query=None)

    def save_task(self, resource_type: str, resource_id: str, body: Any = None) -> Any:
        """Save task.  [POST /api/resource-ops/{resourceType}/{resourceId}/tasks]"""
        return self._c.request("POST", "/api/resource-ops/" + self._c._seg(resource_type) + "/" + self._c._seg(resource_id) + "/tasks", body, query=None)

    def state(self, resource_type: str, resource_id: str, *, name: Any = None) -> Any:
        """State.  [GET /api/resource-ops/{resourceType}/{resourceId}/state]"""
        return self._c.request("GET", "/api/resource-ops/" + self._c._seg(resource_type) + "/" + self._c._seg(resource_id) + "/state", None, query={"name": name})

    def support(self, resource_type: str, resource_id: str) -> Any:
        """Support.  [GET /api/resource-ops/{resourceType}/{resourceId}/support]"""
        return self._c.request("GET", "/api/resource-ops/" + self._c._seg(resource_type) + "/" + self._c._seg(resource_id) + "/support", None, query=None)

    def tasks(self, resource_type: str, resource_id: str) -> Any:
        """Tasks.  [GET /api/resource-ops/{resourceType}/{resourceId}/tasks]"""
        return self._c.request("GET", "/api/resource-ops/" + self._c._seg(resource_type) + "/" + self._c._seg(resource_id) + "/tasks", None, query=None)

    def template(self, resource_type: str, resource_id: str) -> Any:
        """Template.  [GET /api/resource-ops/{resourceType}/{resourceId}/template]"""
        return self._c.request("GET", "/api/resource-ops/" + self._c._seg(resource_type) + "/" + self._c._seg(resource_id) + "/template", None, query=None)

    def update_alert(self, resource_type: str, resource_id: str, id_: str, body: Any = None) -> Any:
        """Update alert.  [PUT /api/resource-ops/{resourceType}/{resourceId}/alerts/{id}]"""
        return self._c.request("PUT", "/api/resource-ops/" + self._c._seg(resource_type) + "/" + self._c._seg(resource_id) + "/alerts/" + self._c._seg(id_), body, query=None)

    def update_task(self, resource_type: str, resource_id: str, id_: str, body: Any = None) -> Any:
        """Update task.  [PUT /api/resource-ops/{resourceType}/{resourceId}/tasks/{id}]"""
        return self._c.request("PUT", "/api/resource-ops/" + self._c._seg(resource_type) + "/" + self._c._seg(resource_id) + "/tasks/" + self._c._seg(id_), body, query=None)

class SandboxApi:
    """Sandbox operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def create(self, body: Any = None) -> Any:
        """Create.  [POST /api/Sandbox]"""
        return self._c.request("POST", "/api/Sandbox", body, query=None)

    def create_and_download(self, body: Any = None) -> Any:
        """Create and download.  [POST /api/Sandbox/download]"""
        return self._c.request("POST", "/api/Sandbox/download", body, query=None)

    def reap(self) -> Any:
        """Reap.  [POST /api/Sandbox/reap]"""
        return self._c.request("POST", "/api/Sandbox/reap", None, query=None)

    def regions(self) -> Any:
        """Regions.  [GET /api/Sandbox/regions]"""
        return self._c.request("GET", "/api/Sandbox/regions", None, query=None)

class SearchApi:
    """Search operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def search(self, *, q: Any = None, type_: Any = None, region: Any = None, status: Any = None, limit: Any = None) -> Any:
        """Search.  [GET /api/search]"""
        return self._c.request("GET", "/api/search", None, query={"q": q, "type": type_, "region": region, "status": status, "limit": limit})

class ServiceBusApi:
    """ServiceBus operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def create_namespace(self, body: Any = None) -> Any:
        """Create namespace.  [POST /api/ServiceBus/namespaces]"""
        return self._c.request("POST", "/api/ServiceBus/namespaces", body, query=None)

    def create_queue(self, id_: str, body: Any = None) -> Any:
        """Create queue.  [POST /api/ServiceBus/namespaces/{id}/queues]"""
        return self._c.request("POST", "/api/ServiceBus/namespaces/" + self._c._seg(id_) + "/queues", body, query=None)

    def create_rule(self, id_: str, topic_name: str, subscription_name: str, body: Any = None) -> Any:
        """Create rule.  [POST /api/ServiceBus/namespaces/{id}/topics/{topicName}/subscriptions/{subscriptionName}/rules]"""
        return self._c.request("POST", "/api/ServiceBus/namespaces/" + self._c._seg(id_) + "/topics/" + self._c._seg(topic_name) + "/subscriptions/" + self._c._seg(subscription_name) + "/rules", body, query=None)

    def create_subscription(self, id_: str, topic_name: str, body: Any = None) -> Any:
        """Create subscription.  [POST /api/ServiceBus/namespaces/{id}/topics/{topicName}/subscriptions]"""
        return self._c.request("POST", "/api/ServiceBus/namespaces/" + self._c._seg(id_) + "/topics/" + self._c._seg(topic_name) + "/subscriptions", body, query=None)

    def create_topic(self, id_: str, body: Any = None) -> Any:
        """Create topic.  [POST /api/ServiceBus/namespaces/{id}/topics]"""
        return self._c.request("POST", "/api/ServiceBus/namespaces/" + self._c._seg(id_) + "/topics", body, query=None)

    def delete_namespace(self, id_: str) -> Any:
        """Delete namespace.  [DELETE /api/ServiceBus/namespaces/{id}]"""
        return self._c.request("DELETE", "/api/ServiceBus/namespaces/" + self._c._seg(id_), None, query=None)

    def delete_queue(self, id_: str, name: str) -> Any:
        """Delete queue.  [DELETE /api/ServiceBus/namespaces/{id}/queues/{name}]"""
        return self._c.request("DELETE", "/api/ServiceBus/namespaces/" + self._c._seg(id_) + "/queues/" + self._c._seg(name), None, query=None)

    def delete_rule(self, id_: str, topic_name: str, subscription_name: str, rule_name: str) -> Any:
        """Delete rule.  [DELETE /api/ServiceBus/namespaces/{id}/topics/{topicName}/subscriptions/{subscriptionName}/rules/{ruleName}]"""
        return self._c.request("DELETE", "/api/ServiceBus/namespaces/" + self._c._seg(id_) + "/topics/" + self._c._seg(topic_name) + "/subscriptions/" + self._c._seg(subscription_name) + "/rules/" + self._c._seg(rule_name), None, query=None)

    def delete_subscription(self, id_: str, topic_name: str, subscription_name: str) -> Any:
        """Delete subscription.  [DELETE /api/ServiceBus/namespaces/{id}/topics/{topicName}/subscriptions/{subscriptionName}]"""
        return self._c.request("DELETE", "/api/ServiceBus/namespaces/" + self._c._seg(id_) + "/topics/" + self._c._seg(topic_name) + "/subscriptions/" + self._c._seg(subscription_name), None, query=None)

    def delete_topic(self, id_: str, name: str) -> Any:
        """Delete topic.  [DELETE /api/ServiceBus/namespaces/{id}/topics/{name}]"""
        return self._c.request("DELETE", "/api/ServiceBus/namespaces/" + self._c._seg(id_) + "/topics/" + self._c._seg(name), None, query=None)

    def get_keys(self, id_: str) -> Any:
        """Get keys.  [GET /api/ServiceBus/namespaces/{id}/keys]"""
        return self._c.request("GET", "/api/ServiceBus/namespaces/" + self._c._seg(id_) + "/keys", None, query=None)

    def get_namespace(self, id_: str) -> Any:
        """Get namespace.  [GET /api/ServiceBus/namespaces/{id}]"""
        return self._c.request("GET", "/api/ServiceBus/namespaces/" + self._c._seg(id_), None, query=None)

    def get_queue(self, id_: str, name: str) -> Any:
        """Get queue.  [GET /api/ServiceBus/namespaces/{id}/queues/{name}]"""
        return self._c.request("GET", "/api/ServiceBus/namespaces/" + self._c._seg(id_) + "/queues/" + self._c._seg(name), None, query=None)

    def list_namespaces(self, *, product: Any = None) -> Any:
        """List namespaces.  [GET /api/ServiceBus/namespaces]"""
        return self._c.request("GET", "/api/ServiceBus/namespaces", None, query={"product": product})

    def list_queues(self, id_: str) -> Any:
        """List queues.  [GET /api/ServiceBus/namespaces/{id}/queues]"""
        return self._c.request("GET", "/api/ServiceBus/namespaces/" + self._c._seg(id_) + "/queues", None, query=None)

    def list_rules(self, id_: str, topic_name: str, subscription_name: str) -> Any:
        """List rules.  [GET /api/ServiceBus/namespaces/{id}/topics/{topicName}/subscriptions/{subscriptionName}/rules]"""
        return self._c.request("GET", "/api/ServiceBus/namespaces/" + self._c._seg(id_) + "/topics/" + self._c._seg(topic_name) + "/subscriptions/" + self._c._seg(subscription_name) + "/rules", None, query=None)

    def list_subscriptions(self, id_: str, topic_name: str) -> Any:
        """List subscriptions.  [GET /api/ServiceBus/namespaces/{id}/topics/{topicName}/subscriptions]"""
        return self._c.request("GET", "/api/ServiceBus/namespaces/" + self._c._seg(id_) + "/topics/" + self._c._seg(topic_name) + "/subscriptions", None, query=None)

    def list_topics(self, id_: str) -> Any:
        """List topics.  [GET /api/ServiceBus/namespaces/{id}/topics]"""
        return self._c.request("GET", "/api/ServiceBus/namespaces/" + self._c._seg(id_) + "/topics", None, query=None)

    def peek(self, id_: str, entity: str, *, subscription: Any = None, max_messages: Any = None) -> Any:
        """Peek.  [POST /api/ServiceBus/namespaces/{id}/entities/{entity}/messages/peek]"""
        return self._c.request("POST", "/api/ServiceBus/namespaces/" + self._c._seg(id_) + "/entities/" + self._c._seg(entity) + "/messages/peek", None, query={"subscription": subscription, "maxMessages": max_messages})

    def receive(self, id_: str, entity: str, body: Any = None, *, subscription: Any = None) -> Any:
        """Receive.  [POST /api/ServiceBus/namespaces/{id}/entities/{entity}/messages/receive]"""
        return self._c.request("POST", "/api/ServiceBus/namespaces/" + self._c._seg(id_) + "/entities/" + self._c._seg(entity) + "/messages/receive", body, query={"subscription": subscription})

    def receive_dead_letter(self, id_: str, entity: str, *, subscription: Any = None, max_messages: Any = None) -> Any:
        """Receive dead letter.  [POST /api/ServiceBus/namespaces/{id}/entities/{entity}/deadletter/receive]"""
        return self._c.request("POST", "/api/ServiceBus/namespaces/" + self._c._seg(id_) + "/entities/" + self._c._seg(entity) + "/deadletter/receive", None, query={"subscription": subscription, "maxMessages": max_messages})

    def regenerate_key(self, id_: str, key_name: str, *, primary: Any = None) -> Any:
        """Regenerate key.  [POST /api/ServiceBus/namespaces/{id}/keys/{keyName}/regenerate]"""
        return self._c.request("POST", "/api/ServiceBus/namespaces/" + self._c._seg(id_) + "/keys/" + self._c._seg(key_name) + "/regenerate", None, query={"primary": primary})

    def runtime(self, id_: str, entity: str, *, subscription: Any = None) -> Any:
        """Runtime.  [GET /api/ServiceBus/namespaces/{id}/entities/{entity}/runtime]"""
        return self._c.request("GET", "/api/ServiceBus/namespaces/" + self._c._seg(id_) + "/entities/" + self._c._seg(entity) + "/runtime", None, query={"subscription": subscription})

    def send(self, id_: str, entity: str, body: Any = None) -> Any:
        """Send.  [POST /api/ServiceBus/namespaces/{id}/entities/{entity}/messages]"""
        return self._c.request("POST", "/api/ServiceBus/namespaces/" + self._c._seg(id_) + "/entities/" + self._c._seg(entity) + "/messages", body, query=None)

    def settle(self, id_: str, entity: str, body: Any = None, *, subscription: Any = None) -> Any:
        """Settle.  [POST /api/ServiceBus/namespaces/{id}/entities/{entity}/messages/settle]"""
        return self._c.request("POST", "/api/ServiceBus/namespaces/" + self._c._seg(id_) + "/entities/" + self._c._seg(entity) + "/messages/settle", body, query={"subscription": subscription})

    def update_queue(self, id_: str, name: str, body: Any = None) -> Any:
        """Update queue.  [PUT /api/ServiceBus/namespaces/{id}/queues/{name}]"""
        return self._c.request("PUT", "/api/ServiceBus/namespaces/" + self._c._seg(id_) + "/queues/" + self._c._seg(name), body, query=None)

class SlackApi:
    """Slack operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def command(self) -> Any:
        """Command.  [POST /api/integrations/slack/command]"""
        return self._c.request("POST", "/api/integrations/slack/command", None, query=None)

    def config_info(self) -> Any:
        """Config info.  [GET /api/integrations/slack/config]"""
        return self._c.request("GET", "/api/integrations/slack/config", None, query=None)

    def install(self) -> Any:
        """Install.  [GET /api/integrations/slack/install]"""
        return self._c.request("GET", "/api/integrations/slack/install", None, query=None)

    def link(self, body: Any = None) -> Any:
        """Link.  [POST /api/integrations/slack/link]"""
        return self._c.request("POST", "/api/integrations/slack/link", body, query=None)

    def o_auth(self, *, code: Any = None, state: Any = None, error: Any = None) -> Any:
        """OAuth.  [GET /api/integrations/slack/oauth]"""
        return self._c.request("GET", "/api/integrations/slack/oauth", None, query={"code": code, "state": state, "error": error})

class SqlServerDatabaseApi:
    """SqlServerDatabase operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def columns(self, id_: str, schema: str, table: str, *, database: Any = None) -> Any:
        """Columns.  [GET /api/SqlServerDatabase/{id}/objects/{schema}/{table}/columns]"""
        return self._c.request("GET", "/api/SqlServerDatabase/" + self._c._seg(id_) + "/objects/" + self._c._seg(schema) + "/" + self._c._seg(table) + "/columns", None, query={"database": database})

    def connection(self, id_: str) -> Any:
        """Connection.  [GET /api/SqlServerDatabase/{id}/connection]"""
        return self._c.request("GET", "/api/SqlServerDatabase/" + self._c._seg(id_) + "/connection", None, query=None)

    def create(self, body: Any = None) -> Any:
        """Create.  [POST /api/SqlServerDatabase]"""
        return self._c.request("POST", "/api/SqlServerDatabase", body, query=None)

    def databases(self, id_: str) -> Any:
        """Databases.  [GET /api/SqlServerDatabase/{id}/databases]"""
        return self._c.request("GET", "/api/SqlServerDatabase/" + self._c._seg(id_) + "/databases", None, query=None)

    def delete(self, id_: str) -> Any:
        """Delete.  [DELETE /api/SqlServerDatabase/{id}]"""
        return self._c.request("DELETE", "/api/SqlServerDatabase/" + self._c._seg(id_), None, query=None)

    def get(self, id_: str) -> Any:
        """Get.  [GET /api/SqlServerDatabase/{id}]"""
        return self._c.request("GET", "/api/SqlServerDatabase/" + self._c._seg(id_), None, query=None)

    def list(self) -> Any:
        """List.  [GET /api/SqlServerDatabase]"""
        return self._c.request("GET", "/api/SqlServerDatabase", None, query=None)

    def objects(self, id_: str, *, database: Any = None) -> Any:
        """Objects.  [GET /api/SqlServerDatabase/{id}/objects]"""
        return self._c.request("GET", "/api/SqlServerDatabase/" + self._c._seg(id_) + "/objects", None, query={"database": database})

    def query(self, id_: str, body: Any = None) -> Any:
        """Query.  [POST /api/SqlServerDatabase/{id}/query]"""
        return self._c.request("POST", "/api/SqlServerDatabase/" + self._c._seg(id_) + "/query", body, query=None)

    def reset_password(self, id_: str, body: Any = None) -> Any:
        """Reset password.  [POST /api/SqlServerDatabase/{id}/reset-password]"""
        return self._c.request("POST", "/api/SqlServerDatabase/" + self._c._seg(id_) + "/reset-password", body, query=None)

class StorageApi:
    """Storage operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def bucket_filesand_directories(self, *, directory: Any = None, type_: Any = None) -> Any:
        """Bucket filesand directories.  [POST /api/Storage/bucketfilesanddirectories]"""
        return self._c.request("POST", "/api/Storage/bucketfilesanddirectories", None, query={"directory": directory, "type": type_})

    def create_file(self, *, path: Any = None, filename: Any = None) -> Any:
        """Create file.  [POST /api/Storage/createfile]"""
        return self._c.request("POST", "/api/Storage/createfile", None, query={"path": path, "filename": filename})

    def create_folder(self, *, path: Any = None, foldername: Any = None) -> Any:
        """Create folder.  [POST /api/Storage/createfolder]"""
        return self._c.request("POST", "/api/Storage/createfolder", None, query={"path": path, "foldername": foldername})

    def delete_file(self, *, path: Any = None) -> Any:
        """Delete file.  [POST /api/Storage/deletefile]"""
        return self._c.request("POST", "/api/Storage/deletefile", None, query={"path": path})

    def delete_folder(self, *, path: Any = None) -> Any:
        """Delete folder.  [POST /api/Storage/deletefolder]"""
        return self._c.request("POST", "/api/Storage/deletefolder", None, query={"path": path})

    def file_copy_to(self, *, source_path: Any = None, destination_path: Any = None) -> Any:
        """File copy to.  [POST /api/Storage/filecopyto]"""
        return self._c.request("POST", "/api/Storage/filecopyto", None, query={"sourcePath": source_path, "destinationPath": destination_path})

    def file_move_to(self, *, source_path: Any = None, destination_path: Any = None) -> Any:
        """File move to.  [POST /api/Storage/filemoveto]"""
        return self._c.request("POST", "/api/Storage/filemoveto", None, query={"sourcePath": source_path, "destinationPath": destination_path})

    def folder_copy_to(self, *, source_path: Any = None, destination_path: Any = None) -> Any:
        """Folder copy to.  [POST /api/Storage/foldercopyto]"""
        return self._c.request("POST", "/api/Storage/foldercopyto", None, query={"sourcePath": source_path, "destinationPath": destination_path})

    def folder_move_to(self, *, source_path: Any = None, destination_path: Any = None) -> Any:
        """Folder move to.  [POST /api/Storage/foldermoveto]"""
        return self._c.request("POST", "/api/Storage/foldermoveto", None, query={"sourcePath": source_path, "destinationPath": destination_path})

    def get_all_directories(self, *, directory: Any = None) -> Any:
        """Get all directories.  [POST /api/Storage/listdirectories]"""
        return self._c.request("POST", "/api/Storage/listdirectories", None, query={"directory": directory})

    def get_all_directories_and_files(self, *, directory: Any = None, type_: Any = None) -> Any:
        """Get all directories and files.  [POST /api/Storage/directoriesandfiles]"""
        return self._c.request("POST", "/api/Storage/directoriesandfiles", None, query={"directory": directory, "type": type_})

    def get_all_files(self, *, directory: Any = None, type_: Any = None) -> Any:
        """Get all files.  [POST /api/Storage/listfiles]"""
        return self._c.request("POST", "/api/Storage/listfiles", None, query={"directory": directory, "type": type_})

    def get_all_filesand_directories(self, *, directory: Any = None, type_: Any = None) -> Any:
        """Get all filesand directories.  [POST /api/Storage/listfilesanddirectories]"""
        return self._c.request("POST", "/api/Storage/listfilesanddirectories", None, query={"directory": directory, "type": type_})

    def get_root_dir(self) -> Any:
        """Get root dir.  [GET /api/Storage/rootdir]"""
        return self._c.request("GET", "/api/Storage/rootdir", None, query=None)

    def rename_file(self, *, path: Any = None, rename: Any = None) -> Any:
        """Rename file.  [POST /api/Storage/renamefile]"""
        return self._c.request("POST", "/api/Storage/renamefile", None, query={"path": path, "rename": rename})

    def rename_folder(self, *, directory: Any = None, rename: Any = None) -> Any:
        """Rename folder.  [POST /api/Storage/renamefolder]"""
        return self._c.request("POST", "/api/Storage/renamefolder", None, query={"directory": directory, "rename": rename})

class StorageAccountApi:
    """StorageAccount operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def acquire_lock(self, item_id: str, body: Any = None) -> Any:
        """Acquire lock.  [POST /api/StorageAccount/items/{itemId}/lock]"""
        return self._c.request("POST", "/api/StorageAccount/items/" + self._c._seg(item_id) + "/lock", body, query=None)

    def add_lifecycle_rule(self, id_: str, body: Any = None) -> Any:
        """Add lifecycle rule.  [POST /api/StorageAccount/{id}/lifecycle]"""
        return self._c.request("POST", "/api/StorageAccount/" + self._c._seg(id_) + "/lifecycle", body, query=None)

    def add_role_assignment(self, id_: str, body: Any = None) -> Any:
        """Add role assignment.  [POST /api/StorageAccount/{id}/iam]"""
        return self._c.request("POST", "/api/StorageAccount/" + self._c._seg(id_) + "/iam", body, query=None)

    def break_lock(self, item_id: str) -> Any:
        """Break lock.  [POST /api/StorageAccount/items/{itemId}/lock/break]"""
        return self._c.request("POST", "/api/StorageAccount/items/" + self._c._seg(item_id) + "/lock/break", None, query=None)

    def cancel_operation(self, operation_id: str) -> Any:
        """Cancel operation.  [POST /api/StorageAccount/operations/{operationId}/cancel]"""
        return self._c.request("POST", "/api/StorageAccount/operations/" + self._c._seg(operation_id) + "/cancel", None, query=None)

    def copy_item(self, body: Any = None) -> Any:
        """Copy item.  [POST /api/StorageAccount/items/copy]"""
        return self._c.request("POST", "/api/StorageAccount/items/copy", body, query=None)

    def create_backup(self, id_: str, body: Any = None) -> Any:
        """Create backup.  [POST /api/StorageAccount/{id}/backups]"""
        return self._c.request("POST", "/api/StorageAccount/" + self._c._seg(id_) + "/backups", body, query=None)

    def create_folder(self, body: Any = None) -> Any:
        """Create folder.  [POST /api/StorageAccount/folders]"""
        return self._c.request("POST", "/api/StorageAccount/folders", body, query=None)

    def create_queue(self, id_: str, body: Any = None) -> Any:
        """Create queue.  [POST /api/StorageAccount/{id}/queues]"""
        return self._c.request("POST", "/api/StorageAccount/" + self._c._seg(id_) + "/queues", body, query=None)

    def create_storage_account(self, body: Any = None) -> Any:
        """Create storage account.  [POST /api/StorageAccount]"""
        return self._c.request("POST", "/api/StorageAccount", body, query=None)

    def create_table(self, id_: str, body: Any = None) -> Any:
        """Create table.  [POST /api/StorageAccount/{id}/tables]"""
        return self._c.request("POST", "/api/StorageAccount/" + self._c._seg(id_) + "/tables", body, query=None)

    def create_zip(self, body: Any = None) -> Any:
        """Create zip.  [POST /api/StorageAccount/zip]"""
        return self._c.request("POST", "/api/StorageAccount/zip", body, query=None)

    def delete_backup(self, id_: str, backup_id: str) -> Any:
        """Delete backup.  [DELETE /api/StorageAccount/{id}/backups/{backupId}]"""
        return self._c.request("DELETE", "/api/StorageAccount/" + self._c._seg(id_) + "/backups/" + self._c._seg(backup_id), None, query=None)

    def delete_items(self, body: Any = None) -> Any:
        """Delete items.  [POST /api/StorageAccount/items/delete]"""
        return self._c.request("POST", "/api/StorageAccount/items/delete", body, query=None)

    def delete_lifecycle_rule(self, id_: str, rule_id: str) -> Any:
        """Delete lifecycle rule.  [DELETE /api/StorageAccount/{id}/lifecycle/{ruleId}]"""
        return self._c.request("DELETE", "/api/StorageAccount/" + self._c._seg(id_) + "/lifecycle/" + self._c._seg(rule_id), None, query=None)

    def delete_queue(self, id_: str, queue_name: str) -> Any:
        """Delete queue.  [DELETE /api/StorageAccount/{id}/queues/{queueName}]"""
        return self._c.request("DELETE", "/api/StorageAccount/" + self._c._seg(id_) + "/queues/" + self._c._seg(queue_name), None, query=None)

    def delete_storage_account(self, id_: str) -> Any:
        """Delete storage account.  [DELETE /api/StorageAccount/{id}]"""
        return self._c.request("DELETE", "/api/StorageAccount/" + self._c._seg(id_), None, query=None)

    def delete_table(self, id_: str, table_name: str) -> Any:
        """Delete table.  [DELETE /api/StorageAccount/{id}/tables/{tableName}]"""
        return self._c.request("DELETE", "/api/StorageAccount/" + self._c._seg(id_) + "/tables/" + self._c._seg(table_name), None, query=None)

    def download_item_content(self, item_id: str, *, region: Any = None) -> Any:
        """Download item content.  [GET /api/StorageAccount/items/{itemId}/content]"""
        return self._c.request("GET", "/api/StorageAccount/items/" + self._c._seg(item_id) + "/content", None, query={"region": region})

    def download_zip(self, body: Any = None) -> Any:
        """Download zip.  [POST /api/StorageAccount/zip/download]"""
        return self._c.request("POST", "/api/StorageAccount/zip/download", body, query=None)

    def export_activity_log(self, id_: str, *, format_: Any = None) -> Any:
        """Export activity log.  [GET /api/StorageAccount/{id}/activity/export]"""
        return self._c.request("GET", "/api/StorageAccount/" + self._c._seg(id_) + "/activity/export", None, query={"format": format_})

    def extract_archive(self, id_: str, item_id: str, body: Any = None) -> Any:
        """Extract archive.  [POST /api/StorageAccount/{id}/items/{itemId}/extract]"""
        return self._c.request("POST", "/api/StorageAccount/" + self._c._seg(id_) + "/items/" + self._c._seg(item_id) + "/extract", body, query=None)

    def finalize_upload(self, operation_id: str) -> Any:
        """Finalize upload.  [POST /api/StorageAccount/upload/{operationId}/finalize]"""
        return self._c.request("POST", "/api/StorageAccount/upload/" + self._c._seg(operation_id) + "/finalize", None, query=None)

    def generate_share_link(self, item_id: str, body: Any = None) -> Any:
        """Generate share link.  [POST /api/StorageAccount/items/{itemId}/sharelink]"""
        return self._c.request("POST", "/api/StorageAccount/items/" + self._c._seg(item_id) + "/sharelink", body, query=None)

    def get_access_keys(self, id_: str) -> Any:
        """Get access keys.  [GET /api/StorageAccount/{id}/keys]"""
        return self._c.request("GET", "/api/StorageAccount/" + self._c._seg(id_) + "/keys", None, query=None)

    def get_active_operations(self, id_: str) -> Any:
        """Get active operations.  [GET /api/StorageAccount/{id}/operations]"""
        return self._c.request("GET", "/api/StorageAccount/" + self._c._seg(id_) + "/operations", None, query=None)

    def get_activity_log(self, id_: str, *, limit: Any = None) -> Any:
        """Get activity log.  [GET /api/StorageAccount/{id}/activity]"""
        return self._c.request("GET", "/api/StorageAccount/" + self._c._seg(id_) + "/activity", None, query={"limit": limit})

    def get_available_regions(self) -> Any:
        """Get available regions.  [GET /api/StorageAccount/regions]"""
        return self._c.request("GET", "/api/StorageAccount/regions", None, query=None)

    def get_backups(self, id_: str) -> Any:
        """Get backups.  [GET /api/StorageAccount/{id}/backups]"""
        return self._c.request("GET", "/api/StorageAccount/" + self._c._seg(id_) + "/backups", None, query=None)

    def get_default_storage_account(self) -> Any:
        """Get default storage account.  [GET /api/StorageAccount/default]"""
        return self._c.request("GET", "/api/StorageAccount/default", None, query=None)

    def get_file_preview(self, item_id: str) -> Any:
        """Get file preview.  [GET /api/StorageAccount/items/{itemId}/preview]"""
        return self._c.request("GET", "/api/StorageAccount/items/" + self._c._seg(item_id) + "/preview", None, query=None)

    def get_item(self, item_id: str) -> Any:
        """Get item.  [GET /api/StorageAccount/items/{itemId}]"""
        return self._c.request("GET", "/api/StorageAccount/items/" + self._c._seg(item_id), None, query=None)

    def get_item_activity_log(self, item_id: str, *, limit: Any = None) -> Any:
        """Get item activity log.  [GET /api/StorageAccount/items/{itemId}/activity]"""
        return self._c.request("GET", "/api/StorageAccount/items/" + self._c._seg(item_id) + "/activity", None, query={"limit": limit})

    def get_item_metadata(self, item_id: str) -> Any:
        """Get item metadata.  [GET /api/StorageAccount/items/{itemId}/metadata]"""
        return self._c.request("GET", "/api/StorageAccount/items/" + self._c._seg(item_id) + "/metadata", None, query=None)

    def get_item_shares(self, item_id: str) -> Any:
        """Get item shares.  [GET /api/StorageAccount/items/{itemId}/shares]"""
        return self._c.request("GET", "/api/StorageAccount/items/" + self._c._seg(item_id) + "/shares", None, query=None)

    def get_lifecycle_rules(self, id_: str) -> Any:
        """Get lifecycle rules.  [GET /api/StorageAccount/{id}/lifecycle]"""
        return self._c.request("GET", "/api/StorageAccount/" + self._c._seg(id_) + "/lifecycle", None, query=None)

    def get_networking(self, id_: str) -> Any:
        """Get networking.  [GET /api/StorageAccount/{id}/networking]"""
        return self._c.request("GET", "/api/StorageAccount/" + self._c._seg(id_) + "/networking", None, query=None)

    def get_operation_status(self, operation_id: str) -> Any:
        """Get operation status.  [GET /api/StorageAccount/operations/{operationId}]"""
        return self._c.request("GET", "/api/StorageAccount/operations/" + self._c._seg(operation_id), None, query=None)

    def get_replication_status(self, id_: str) -> Any:
        """Get replication status.  [GET /api/StorageAccount/{id}/replication]"""
        return self._c.request("GET", "/api/StorageAccount/" + self._c._seg(id_) + "/replication", None, query=None)

    def get_role_assignments(self, id_: str) -> Any:
        """Get role assignments.  [GET /api/StorageAccount/{id}/iam]"""
        return self._c.request("GET", "/api/StorageAccount/" + self._c._seg(id_) + "/iam", None, query=None)

    def get_role_definitions(self) -> Any:
        """Get role definitions.  [GET /api/StorageAccount/role-definitions]"""
        return self._c.request("GET", "/api/StorageAccount/role-definitions", None, query=None)

    def get_storage_account(self, id_: str) -> Any:
        """Get storage account.  [GET /api/StorageAccount/{id}]"""
        return self._c.request("GET", "/api/StorageAccount/" + self._c._seg(id_), None, query=None)

    def get_storage_accounts(self) -> Any:
        """Get storage accounts.  [GET /api/StorageAccount]"""
        return self._c.request("GET", "/api/StorageAccount", None, query=None)

    def get_storage_stats(self) -> Any:
        """Get storage stats.  [GET /api/StorageAccount/stats]"""
        return self._c.request("GET", "/api/StorageAccount/stats", None, query=None)

    def get_version_history(self, item_id: str) -> Any:
        """Get version history.  [GET /api/StorageAccount/items/{itemId}/versions]"""
        return self._c.request("GET", "/api/StorageAccount/items/" + self._c._seg(item_id) + "/versions", None, query=None)

    def initiate_download(self, body: Any = None) -> Any:
        """Initiate download.  [POST /api/StorageAccount/download]"""
        return self._c.request("POST", "/api/StorageAccount/download", body, query=None)

    def initiate_upload(self, body: Any = None) -> Any:
        """Initiate upload.  [POST /api/StorageAccount/upload]"""
        return self._c.request("POST", "/api/StorageAccount/upload", body, query=None)

    def list_items(self, id_: str, *, path: Any = None, parent_id: Any = None, storage_namespace: Any = None) -> Any:
        """List items.  [GET /api/StorageAccount/{id}/items]"""
        return self._c.request("GET", "/api/StorageAccount/" + self._c._seg(id_) + "/items", None, query={"path": path, "parentId": parent_id, "storageNamespace": storage_namespace})

    def list_queues(self, id_: str) -> Any:
        """List queues.  [GET /api/StorageAccount/{id}/queues]"""
        return self._c.request("GET", "/api/StorageAccount/" + self._c._seg(id_) + "/queues", None, query=None)

    def list_tables(self, id_: str) -> Any:
        """List tables.  [GET /api/StorageAccount/{id}/tables]"""
        return self._c.request("GET", "/api/StorageAccount/" + self._c._seg(id_) + "/tables", None, query=None)

    def move_item(self, body: Any = None) -> Any:
        """Move item.  [PUT /api/StorageAccount/items/move]"""
        return self._c.request("PUT", "/api/StorageAccount/items/move", body, query=None)

    def regenerate_access_key(self, id_: str, key_number: str, body: Any = None) -> Any:
        """Regenerate access key.  [POST /api/StorageAccount/{id}/keys/{keyNumber}/regenerate]"""
        return self._c.request("POST", "/api/StorageAccount/" + self._c._seg(id_) + "/keys/" + self._c._seg(key_number) + "/regenerate", body, query=None)

    def release_lock(self, item_id: str) -> Any:
        """Release lock.  [DELETE /api/StorageAccount/items/{itemId}/lock]"""
        return self._c.request("DELETE", "/api/StorageAccount/items/" + self._c._seg(item_id) + "/lock", None, query=None)

    def remove_role_assignment(self, id_: str, assignment_id: str, *, principal_email: Any = None, role: Any = None) -> Any:
        """Remove role assignment.  [DELETE /api/StorageAccount/{id}/iam/{assignmentId}]"""
        return self._c.request("DELETE", "/api/StorageAccount/" + self._c._seg(id_) + "/iam/" + self._c._seg(assignment_id), None, query={"principalEmail": principal_email, "role": role})

    def remove_share(self, share_id: str) -> Any:
        """Remove share.  [DELETE /api/StorageAccount/shares/{shareId}]"""
        return self._c.request("DELETE", "/api/StorageAccount/shares/" + self._c._seg(share_id), None, query=None)

    def rename_item(self, body: Any = None) -> Any:
        """Rename item.  [PUT /api/StorageAccount/items/rename]"""
        return self._c.request("PUT", "/api/StorageAccount/items/rename", body, query=None)

    def restore_backup(self, id_: str, backup_id: str) -> Any:
        """Restore backup.  [POST /api/StorageAccount/{id}/backups/{backupId}/restore]"""
        return self._c.request("POST", "/api/StorageAccount/" + self._c._seg(id_) + "/backups/" + self._c._seg(backup_id) + "/restore", None, query=None)

    def restore_version(self, body: Any = None) -> Any:
        """Restore version.  [POST /api/StorageAccount/items/versions/restore]"""
        return self._c.request("POST", "/api/StorageAccount/items/versions/restore", body, query=None)

    def run_lifecycle_rules(self, id_: str) -> Any:
        """Run lifecycle rules.  [POST /api/StorageAccount/{id}/lifecycle/run]"""
        return self._c.request("POST", "/api/StorageAccount/" + self._c._seg(id_) + "/lifecycle/run", None, query=None)

    def save_item_content(self, item_id: str, body: Any = None) -> Any:
        """Save item content.  [PUT /api/StorageAccount/items/{itemId}/content]"""
        return self._c.request("PUT", "/api/StorageAccount/items/" + self._c._seg(item_id) + "/content", body, query=None)

    def search_items(self, id_: str, *, q: Any = None) -> Any:
        """Search items.  [GET /api/StorageAccount/{id}/items/search]"""
        return self._c.request("GET", "/api/StorageAccount/" + self._c._seg(id_) + "/items/search", None, query={"q": q})

    def set_default_storage_account(self, id_: str) -> Any:
        """Set default storage account.  [PUT /api/StorageAccount/{id}/default]"""
        return self._c.request("PUT", "/api/StorageAccount/" + self._c._seg(id_) + "/default", None, query=None)

    def share_item(self, body: Any = None) -> Any:
        """Share item.  [POST /api/StorageAccount/items/share]"""
        return self._c.request("POST", "/api/StorageAccount/items/share", body, query=None)

    def update_networking(self, id_: str, body: Any = None) -> Any:
        """Update networking.  [PUT /api/StorageAccount/{id}/networking]"""
        return self._c.request("PUT", "/api/StorageAccount/" + self._c._seg(id_) + "/networking", body, query=None)

    def update_storage_account(self, id_: str, body: Any = None) -> Any:
        """Update storage account.  [PUT /api/StorageAccount/{id}]"""
        return self._c.request("PUT", "/api/StorageAccount/" + self._c._seg(id_), body, query=None)

    def upload_chunk(self, operation_id: str, form: dict[str, Any] | None = None, files: dict[str, tuple[str, bytes]] | None = None) -> Any:
        """Upload chunk.  [POST /api/StorageAccount/upload/{operationId}/chunk]"""
        return self._c.request_multipart("POST", "/api/StorageAccount/upload/" + self._c._seg(operation_id) + "/chunk", form or {}, files or {}, query=None)

class StorageDataApi:
    """StorageData operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def clear_queue(self, account_id: str, queue_name: str) -> Any:
        """Clear queue.  [DELETE /api/storageaccount/{accountId}/queues/{queueName}/messages]"""
        return self._c.request("DELETE", "/api/storageaccount/" + self._c._seg(account_id) + "/queues/" + self._c._seg(queue_name) + "/messages", None, query=None)

    def delete_entity(self, account_id: str, table_name: str, partition_key: str, row_key: str, *, if_match: Any = None) -> Any:
        """Delete entity.  [DELETE /api/storageaccount/{accountId}/tables/{tableName}/entities/{partitionKey}/{rowKey}]"""
        return self._c.request("DELETE", "/api/storageaccount/" + self._c._seg(account_id) + "/tables/" + self._c._seg(table_name) + "/entities/" + self._c._seg(partition_key) + "/" + self._c._seg(row_key), None, query={"ifMatch": if_match})

    def delete_message(self, account_id: str, queue_name: str, message_id: str, *, pop_receipt: Any = None) -> Any:
        """Delete message.  [DELETE /api/storageaccount/{accountId}/queues/{queueName}/messages/{messageId}]"""
        return self._c.request("DELETE", "/api/storageaccount/" + self._c._seg(account_id) + "/queues/" + self._c._seg(queue_name) + "/messages/" + self._c._seg(message_id), None, query={"popReceipt": pop_receipt})

    def get_entity(self, account_id: str, table_name: str, partition_key: str, row_key: str) -> Any:
        """Get entity.  [GET /api/storageaccount/{accountId}/tables/{tableName}/entities/{partitionKey}/{rowKey}]"""
        return self._c.request("GET", "/api/storageaccount/" + self._c._seg(account_id) + "/tables/" + self._c._seg(table_name) + "/entities/" + self._c._seg(partition_key) + "/" + self._c._seg(row_key), None, query=None)

    def insert_entity(self, account_id: str, table_name: str, body: Any = None) -> Any:
        """Insert entity.  [POST /api/storageaccount/{accountId}/tables/{tableName}/entities]"""
        return self._c.request("POST", "/api/storageaccount/" + self._c._seg(account_id) + "/tables/" + self._c._seg(table_name) + "/entities", body, query=None)

    def peek_messages(self, account_id: str, queue_name: str, *, max: Any = None) -> Any:
        """Peek messages.  [GET /api/storageaccount/{accountId}/queues/{queueName}/messages]"""
        return self._c.request("GET", "/api/storageaccount/" + self._c._seg(account_id) + "/queues/" + self._c._seg(queue_name) + "/messages", None, query={"max": max})

    def query_entities(self, account_id: str, table_name: str, *, partition_key: Any = None, property_name: Any = None, property_value: Any = None, take: Any = None, continuation_row_key: Any = None) -> Any:
        """Query entities.  [GET /api/storageaccount/{accountId}/tables/{tableName}/entities]"""
        return self._c.request("GET", "/api/storageaccount/" + self._c._seg(account_id) + "/tables/" + self._c._seg(table_name) + "/entities", None, query={"partitionKey": partition_key, "propertyName": property_name, "propertyValue": property_value, "take": take, "continuationRowKey": continuation_row_key})

    def queue_stats(self, account_id: str, queue_name: str) -> Any:
        """Queue stats.  [GET /api/storageaccount/{accountId}/queues/{queueName}/stats]"""
        return self._c.request("GET", "/api/storageaccount/" + self._c._seg(account_id) + "/queues/" + self._c._seg(queue_name) + "/stats", None, query=None)

    def receive_messages(self, account_id: str, queue_name: str, body: Any = None) -> Any:
        """Receive messages.  [POST /api/storageaccount/{accountId}/queues/{queueName}/messages/receive]"""
        return self._c.request("POST", "/api/storageaccount/" + self._c._seg(account_id) + "/queues/" + self._c._seg(queue_name) + "/messages/receive", body, query=None)

    def send_message(self, account_id: str, queue_name: str, body: Any = None) -> Any:
        """Send message.  [POST /api/storageaccount/{accountId}/queues/{queueName}/messages]"""
        return self._c.request("POST", "/api/storageaccount/" + self._c._seg(account_id) + "/queues/" + self._c._seg(queue_name) + "/messages", body, query=None)

    def update_visibility(self, account_id: str, queue_name: str, message_id: str, *, pop_receipt: Any = None, visibility_timeout_seconds: Any = None) -> Any:
        """Update visibility.  [POST /api/storageaccount/{accountId}/queues/{queueName}/messages/{messageId}/visibility]"""
        return self._c.request("POST", "/api/storageaccount/" + self._c._seg(account_id) + "/queues/" + self._c._seg(queue_name) + "/messages/" + self._c._seg(message_id) + "/visibility", None, query={"popReceipt": pop_receipt, "visibilityTimeoutSeconds": visibility_timeout_seconds})

    def upsert_entity(self, account_id: str, table_name: str, body: Any = None) -> Any:
        """Upsert entity.  [PUT /api/storageaccount/{accountId}/tables/{tableName}/entities]"""
        return self._c.request("PUT", "/api/storageaccount/" + self._c._seg(account_id) + "/tables/" + self._c._seg(table_name) + "/entities", body, query=None)

class StorageObjectApi:
    """StorageObject operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def commit_block_list(self, account_id: str, container: str, body: Any = None) -> Any:
        """Commit block list.  [POST /api/storageaccount/{accountId}/containers/{container}/blocks/commit]"""
        return self._c.request("POST", "/api/storageaccount/" + self._c._seg(account_id) + "/containers/" + self._c._seg(container) + "/blocks/commit", body, query=None)

    def create_container(self, account_id: str, body: Any = None) -> Any:
        """Create container.  [POST /api/storageaccount/{accountId}/containers]"""
        return self._c.request("POST", "/api/storageaccount/" + self._c._seg(account_id) + "/containers", body, query=None)

    def create_directory(self, account_id: str, container: str, body: Any = None) -> Any:
        """Create directory.  [POST /api/storageaccount/{accountId}/containers/{container}/directories]"""
        return self._c.request("POST", "/api/storageaccount/" + self._c._seg(account_id) + "/containers/" + self._c._seg(container) + "/directories", body, query=None)

    def create_file_share(self, account_id: str, body: Any = None) -> Any:
        """Create file share.  [POST /api/storageaccount/{accountId}/fileshares]"""
        return self._c.request("POST", "/api/storageaccount/" + self._c._seg(account_id) + "/fileshares", body, query=None)

    def delete_container(self, account_id: str, name: str, *, force: Any = None) -> Any:
        """Delete container.  [DELETE /api/storageaccount/{accountId}/containers/{name}]"""
        return self._c.request("DELETE", "/api/storageaccount/" + self._c._seg(account_id) + "/containers/" + self._c._seg(name), None, query={"force": force})

    def delete_file_share(self, account_id: str, name: str, *, force: Any = None) -> Any:
        """Delete file share.  [DELETE /api/storageaccount/{accountId}/fileshares/{name}]"""
        return self._c.request("DELETE", "/api/storageaccount/" + self._c._seg(account_id) + "/fileshares/" + self._c._seg(name), None, query={"force": force})

    def delete_object(self, account_id: str, container: str, key: str) -> Any:
        """Delete object.  [DELETE /api/storageaccount/{accountId}/containers/{container}/objects/{key}]"""
        return self._c.request("DELETE", "/api/storageaccount/" + self._c._seg(account_id) + "/containers/" + self._c._seg(container) + "/objects/" + self._c._seg(key, True), None, query=None)

    def get_block_list(self, account_id: str, container: str, *, blob_name: Any = None) -> Any:
        """Get block list.  [GET /api/storageaccount/{accountId}/containers/{container}/blocks]"""
        return self._c.request("GET", "/api/storageaccount/" + self._c._seg(account_id) + "/containers/" + self._c._seg(container) + "/blocks", None, query={"blobName": blob_name})

    def get_container(self, account_id: str, name: str) -> Any:
        """Get container.  [GET /api/storageaccount/{accountId}/containers/{name}]"""
        return self._c.request("GET", "/api/storageaccount/" + self._c._seg(account_id) + "/containers/" + self._c._seg(name), None, query=None)

    def get_object(self, account_id: str, container: str, key: str) -> Any:
        """Get object.  [GET /api/storageaccount/{accountId}/containers/{container}/objects/{key}]"""
        return self._c.request("GET", "/api/storageaccount/" + self._c._seg(account_id) + "/containers/" + self._c._seg(container) + "/objects/" + self._c._seg(key, True), None, query=None)

    def get_object_content(self, account_id: str, container: str, key: str) -> Any:
        """Get object content.  [GET /api/storageaccount/{accountId}/containers/{container}/content/{key}]"""
        return self._c.request("GET", "/api/storageaccount/" + self._c._seg(account_id) + "/containers/" + self._c._seg(container) + "/content/" + self._c._seg(key, True), None, query=None)

    def get_replication_status(self, account_id: str) -> Any:
        """Get replication status.  [GET /api/storageaccount/{accountId}/replication-status]"""
        return self._c.request("GET", "/api/storageaccount/" + self._c._seg(account_id) + "/replication-status", None, query=None)

    def list_containers(self, account_id: str, *, kind: Any = None) -> Any:
        """List containers.  [GET /api/storageaccount/{accountId}/containers]"""
        return self._c.request("GET", "/api/storageaccount/" + self._c._seg(account_id) + "/containers", None, query={"kind": kind})

    def list_file_shares(self, account_id: str) -> Any:
        """List file shares.  [GET /api/storageaccount/{accountId}/fileshares]"""
        return self._c.request("GET", "/api/storageaccount/" + self._c._seg(account_id) + "/fileshares", None, query=None)

    def list_objects(self, account_id: str, container: str, *, prefix: Any = None, path: Any = None, limit: Any = None) -> Any:
        """List objects.  [GET /api/storageaccount/{accountId}/containers/{container}/objects]"""
        return self._c.request("GET", "/api/storageaccount/" + self._c._seg(account_id) + "/containers/" + self._c._seg(container) + "/objects", None, query={"prefix": prefix, "path": path, "limit": limit})

    def put_object(self, account_id: str, container: str, body: Any = None) -> Any:
        """Put object.  [PUT /api/storageaccount/{accountId}/containers/{container}/objects]"""
        return self._c.request("PUT", "/api/storageaccount/" + self._c._seg(account_id) + "/containers/" + self._c._seg(container) + "/objects", body, query=None)

    def reconcile(self, account_id: str) -> Any:
        """Reconcile.  [POST /api/storageaccount/{accountId}/replication-status/reconcile]"""
        return self._c.request("POST", "/api/storageaccount/" + self._c._seg(account_id) + "/replication-status/reconcile", None, query=None)

    def rename_path(self, account_id: str, container: str, body: Any = None) -> Any:
        """Rename path.  [POST /api/storageaccount/{accountId}/containers/{container}/rename]"""
        return self._c.request("POST", "/api/storageaccount/" + self._c._seg(account_id) + "/containers/" + self._c._seg(container) + "/rename", body, query=None)

    def set_access_control(self, account_id: str, container: str, body: Any = None) -> Any:
        """Set access control.  [PUT /api/storageaccount/{accountId}/containers/{container}/access-control]"""
        return self._c.request("PUT", "/api/storageaccount/" + self._c._seg(account_id) + "/containers/" + self._c._seg(container) + "/access-control", body, query=None)

    def stage_block(self, account_id: str, container: str, body: Any = None) -> Any:
        """Stage block.  [PUT /api/storageaccount/{accountId}/containers/{container}/blocks]"""
        return self._c.request("PUT", "/api/storageaccount/" + self._c._seg(account_id) + "/containers/" + self._c._seg(container) + "/blocks", body, query=None)

    def update_container(self, account_id: str, name: str, body: Any = None) -> Any:
        """Update container.  [PUT /api/storageaccount/{accountId}/containers/{name}]"""
        return self._c.request("PUT", "/api/storageaccount/" + self._c._seg(account_id) + "/containers/" + self._c._seg(name), body, query=None)

class StreamAnalyticsApi:
    """StreamAnalytics operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def add_input(self, id_: str, body: Any = None) -> Any:
        """Add input.  [POST /api/StreamAnalytics/{id}/inputs]"""
        return self._c.request("POST", "/api/StreamAnalytics/" + self._c._seg(id_) + "/inputs", body, query=None)

    def add_output(self, id_: str, body: Any = None) -> Any:
        """Add output.  [POST /api/StreamAnalytics/{id}/outputs]"""
        return self._c.request("POST", "/api/StreamAnalytics/" + self._c._seg(id_) + "/outputs", body, query=None)

    def apply_transform(self, id_: str) -> Any:
        """Apply transform.  [POST /api/StreamAnalytics/{id}/transform/apply]"""
        return self._c.request("POST", "/api/StreamAnalytics/" + self._c._seg(id_) + "/transform/apply", None, query=None)

    def bindings(self, *, connector: Any = None) -> Any:
        """Bindings.  [GET /api/StreamAnalytics/bindings]"""
        return self._c.request("GET", "/api/StreamAnalytics/bindings", None, query={"connector": connector})

    def catalog(self) -> Any:
        """Catalog.  [GET /api/StreamAnalytics/catalog]"""
        return self._c.request("GET", "/api/StreamAnalytics/catalog", None, query=None)

    def connection(self, id_: str) -> Any:
        """Connection.  [GET /api/StreamAnalytics/{id}/connection]"""
        return self._c.request("GET", "/api/StreamAnalytics/" + self._c._seg(id_) + "/connection", None, query=None)

    def create(self, body: Any = None) -> Any:
        """Create.  [POST /api/StreamAnalytics]"""
        return self._c.request("POST", "/api/StreamAnalytics", body, query=None)

    def delete(self, id_: str) -> Any:
        """Delete.  [DELETE /api/StreamAnalytics/{id}]"""
        return self._c.request("DELETE", "/api/StreamAnalytics/" + self._c._seg(id_), None, query=None)

    def delete_input(self, id_: str, input_id: str) -> Any:
        """Delete input.  [DELETE /api/StreamAnalytics/{id}/inputs/{inputId}]"""
        return self._c.request("DELETE", "/api/StreamAnalytics/" + self._c._seg(id_) + "/inputs/" + self._c._seg(input_id), None, query=None)

    def delete_output(self, id_: str, output_id: str) -> Any:
        """Delete output.  [DELETE /api/StreamAnalytics/{id}/outputs/{outputId}]"""
        return self._c.request("DELETE", "/api/StreamAnalytics/" + self._c._seg(id_) + "/outputs/" + self._c._seg(output_id), None, query=None)

    def get(self, id_: str) -> Any:
        """Get.  [GET /api/StreamAnalytics/{id}]"""
        return self._c.request("GET", "/api/StreamAnalytics/" + self._c._seg(id_), None, query=None)

    def inputs(self, id_: str) -> Any:
        """Inputs.  [GET /api/StreamAnalytics/{id}/inputs]"""
        return self._c.request("GET", "/api/StreamAnalytics/" + self._c._seg(id_) + "/inputs", None, query=None)

    def list(self) -> Any:
        """List.  [GET /api/StreamAnalytics]"""
        return self._c.request("GET", "/api/StreamAnalytics", None, query=None)

    def logs(self, id_: str, *, role: Any = None, tail: Any = None) -> Any:
        """Logs.  [GET /api/StreamAnalytics/{id}/logs]"""
        return self._c.request("GET", "/api/StreamAnalytics/" + self._c._seg(id_) + "/logs", None, query={"role": role, "tail": tail})

    def metrics(self, id_: str) -> Any:
        """Metrics.  [GET /api/StreamAnalytics/{id}/metrics]"""
        return self._c.request("GET", "/api/StreamAnalytics/" + self._c._seg(id_) + "/metrics", None, query=None)

    def outputs(self, id_: str) -> Any:
        """Outputs.  [GET /api/StreamAnalytics/{id}/outputs]"""
        return self._c.request("GET", "/api/StreamAnalytics/" + self._c._seg(id_) + "/outputs", None, query=None)

    def query(self, id_: str, body: Any = None) -> Any:
        """Query.  [POST /api/StreamAnalytics/{id}/query]"""
        return self._c.request("POST", "/api/StreamAnalytics/" + self._c._seg(id_) + "/query", body, query=None)

    def query_history(self, id_: str, *, take: Any = None) -> Any:
        """Query history.  [GET /api/StreamAnalytics/{id}/query/history]"""
        return self._c.request("GET", "/api/StreamAnalytics/" + self._c._seg(id_) + "/query/history", None, query={"take": take})

    def start(self, id_: str) -> Any:
        """Start.  [POST /api/StreamAnalytics/{id}/start]"""
        return self._c.request("POST", "/api/StreamAnalytics/" + self._c._seg(id_) + "/start", None, query=None)

    def status(self, id_: str) -> Any:
        """Status.  [GET /api/StreamAnalytics/{id}/status]"""
        return self._c.request("GET", "/api/StreamAnalytics/" + self._c._seg(id_) + "/status", None, query=None)

    def stop(self, id_: str) -> Any:
        """Stop.  [POST /api/StreamAnalytics/{id}/stop]"""
        return self._c.request("POST", "/api/StreamAnalytics/" + self._c._seg(id_) + "/stop", None, query=None)

    def transform(self, id_: str) -> Any:
        """Transform.  [GET /api/StreamAnalytics/{id}/transform]"""
        return self._c.request("GET", "/api/StreamAnalytics/" + self._c._seg(id_) + "/transform", None, query=None)

    def update(self, id_: str, body: Any = None) -> Any:
        """Update.  [PATCH /api/StreamAnalytics/{id}]"""
        return self._c.request("PATCH", "/api/StreamAnalytics/" + self._c._seg(id_), body, query=None)

class StreamPipelineApi:
    """StreamPipeline operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def create(self, job_id: str, body: Any = None) -> Any:
        """Create.  [POST /api/StreamAnalytics/{jobId}/pipelines]"""
        return self._c.request("POST", "/api/StreamAnalytics/" + self._c._seg(job_id) + "/pipelines", body, query=None)

    def delete(self, job_id: str, pipeline_id: str) -> Any:
        """Delete.  [DELETE /api/StreamAnalytics/{jobId}/pipelines/{pipelineId}]"""
        return self._c.request("DELETE", "/api/StreamAnalytics/" + self._c._seg(job_id) + "/pipelines/" + self._c._seg(pipeline_id), None, query=None)

    def get(self, job_id: str, pipeline_id: str) -> Any:
        """Get.  [GET /api/StreamAnalytics/{jobId}/pipelines/{pipelineId}]"""
        return self._c.request("GET", "/api/StreamAnalytics/" + self._c._seg(job_id) + "/pipelines/" + self._c._seg(pipeline_id), None, query=None)

    def get_run(self, job_id: str, run_id: str) -> Any:
        """Get run.  [GET /api/StreamAnalytics/{jobId}/pipelines/runs/{runId}]"""
        return self._c.request("GET", "/api/StreamAnalytics/" + self._c._seg(job_id) + "/pipelines/runs/" + self._c._seg(run_id), None, query=None)

    def list(self, job_id: str) -> Any:
        """List.  [GET /api/StreamAnalytics/{jobId}/pipelines]"""
        return self._c.request("GET", "/api/StreamAnalytics/" + self._c._seg(job_id) + "/pipelines", None, query=None)

    def preview_schedule(self, *, cron: Any = None, time_zone: Any = None, count: Any = None) -> Any:
        """Preview schedule.  [GET /api/StreamAnalytics/schedule-preview]"""
        return self._c.request("GET", "/api/StreamAnalytics/schedule-preview", None, query={"cron": cron, "timeZone": time_zone, "count": count})

    def run(self, job_id: str, pipeline_id: str) -> Any:
        """Run.  [POST /api/StreamAnalytics/{jobId}/pipelines/{pipelineId}/run]"""
        return self._c.request("POST", "/api/StreamAnalytics/" + self._c._seg(job_id) + "/pipelines/" + self._c._seg(pipeline_id) + "/run", None, query=None)

    def runs(self, job_id: str, pipeline_id: str, *, limit: Any = None) -> Any:
        """Runs.  [GET /api/StreamAnalytics/{jobId}/pipelines/{pipelineId}/runs]"""
        return self._c.request("GET", "/api/StreamAnalytics/" + self._c._seg(job_id) + "/pipelines/" + self._c._seg(pipeline_id) + "/runs", None, query={"limit": limit})

    def update(self, job_id: str, pipeline_id: str, body: Any = None) -> Any:
        """Update.  [PUT /api/StreamAnalytics/{jobId}/pipelines/{pipelineId}]"""
        return self._c.request("PUT", "/api/StreamAnalytics/" + self._c._seg(job_id) + "/pipelines/" + self._c._seg(pipeline_id), body, query=None)

class StreamingApi:
    """Streaming operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def add_destination(self, id_: str, body: Any = None) -> Any:
        """Add destination.  [POST /api/streaming/{id}/destinations]"""
        return self._c.request("POST", "/api/streaming/" + self._c._seg(id_) + "/destinations", body, query=None)

    def create(self, body: Any = None) -> Any:
        """Create.  [POST /api/streaming]"""
        return self._c.request("POST", "/api/streaming", body, query=None)

    def delete(self, id_: str) -> Any:
        """Delete.  [DELETE /api/streaming/{id}]"""
        return self._c.request("DELETE", "/api/streaming/" + self._c._seg(id_), None, query=None)

    def delete_destination(self, destination_id: str) -> Any:
        """Delete destination.  [DELETE /api/streaming/destinations/{destinationId}]"""
        return self._c.request("DELETE", "/api/streaming/destinations/" + self._c._seg(destination_id), None, query=None)

    def destinations(self, id_: str, *, refresh: Any = None) -> Any:
        """Destinations.  [GET /api/streaming/{id}/destinations]"""
        return self._c.request("GET", "/api/streaming/" + self._c._seg(id_) + "/destinations", None, query={"refresh": refresh})

    def get(self, id_: str) -> Any:
        """Get.  [GET /api/streaming/{id}]"""
        return self._c.request("GET", "/api/streaming/" + self._c._seg(id_), None, query=None)

    def list(self) -> Any:
        """List.  [GET /api/streaming]"""
        return self._c.request("GET", "/api/streaming", None, query=None)

    def platforms(self) -> Any:
        """Platforms.  [GET /api/streaming/platforms]"""
        return self._c.request("GET", "/api/streaming/platforms", None, query=None)

    def sync_destinations(self, id_: str) -> Any:
        """Sync destinations.  [POST /api/streaming/{id}/destinations/sync]"""
        return self._c.request("POST", "/api/streaming/" + self._c._seg(id_) + "/destinations/sync", None, query=None)

    def update_destination(self, destination_id: str, body: Any = None) -> Any:
        """Update destination.  [PUT /api/streaming/destinations/{destinationId}]"""
        return self._c.request("PUT", "/api/streaming/destinations/" + self._c._seg(destination_id), body, query=None)

class SubscriptionApi:
    """Subscription operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def active_subscriptions(self) -> Any:
        """Active subscriptions.  [GET /api/Subscription/activesubscriptions]"""
        return self._c.request("GET", "/api/Subscription/activesubscriptions", None, query=None)

    def add_subscriptionto_user(self, body: Any = None) -> Any:
        """Add subscriptionto user.  [POST /api/Subscription/addsubscriptiontouser]"""
        return self._c.request("POST", "/api/Subscription/addsubscriptiontouser", body, query=None)

    def create_subscription(self, body: Any = None) -> Any:
        """Create subscription.  [POST /api/Subscription/createsubscriptions]"""
        return self._c.request("POST", "/api/Subscription/createsubscriptions", body, query=None)

    def create_user_subscription(self, body: Any = None) -> Any:
        """Create user subscription.  [POST /api/Subscription/createsubscription]"""
        return self._c.request("POST", "/api/Subscription/createsubscription", body, query=None)

    def delete_subscription_by_id(self, id_: str) -> Any:
        """Delete subscription by id.  [DELETE /api/Subscription/removesubscription/{id}]"""
        return self._c.request("DELETE", "/api/Subscription/removesubscription/" + self._c._seg(id_), None, query=None)

    def my_subscriptions(self) -> Any:
        """My subscriptions.  [GET /api/Subscription/mysubscriptions]"""
        return self._c.request("GET", "/api/Subscription/mysubscriptions", None, query=None)

    def subscriptions(self) -> Any:
        """Subscriptions.  [GET /api/Subscription/subscriptions]"""
        return self._c.request("GET", "/api/Subscription/subscriptions", None, query=None)

class SupportApi:
    """Support operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def close(self, id_: str, body: Any = None) -> Any:
        """Close.  [POST /api/support/tickets/{id}/close]"""
        return self._c.request("POST", "/api/support/tickets/" + self._c._seg(id_) + "/close", body, query=None)

    def mine(self) -> Any:
        """Mine.  [GET /api/support/tickets]"""
        return self._c.request("GET", "/api/support/tickets", None, query=None)

    def raise_(self, body: Any = None) -> Any:
        """Raise.  [POST /api/support/tickets]"""
        return self._c.request("POST", "/api/support/tickets", body, query=None)

class SupportQueueApi:
    """SupportQueue operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def queue(self, *, status: Any = None) -> Any:
        """Queue.  [GET /api/admin/support]"""
        return self._c.request("GET", "/api/admin/support", None, query={"status": status})

    def update(self, id_: str, body: Any = None) -> Any:
        """Update.  [PUT /api/admin/support/{id}]"""
        return self._c.request("PUT", "/api/admin/support/" + self._c._seg(id_), body, query=None)

class UploadApi:
    """Upload operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def finalize_upload(self, body: Any = None) -> Any:
        """Finalize upload.  [POST /api/Upload/finalizeupload]"""
        return self._c.request("POST", "/api/Upload/finalizeupload", body, query=None)

    def initiate_upload(self, form: dict[str, Any] | None = None, files: dict[str, tuple[str, bytes]] | None = None, *, upload_dir_path: Any = None, folder_dir_path: Any = None) -> Any:
        """Initiate upload.  [POST /api/Upload/initiateupload]"""
        return self._c.request_multipart("POST", "/api/Upload/initiateupload", form or {}, files or {}, query={"uploadDirPath": upload_dir_path, "folderDirPath": folder_dir_path})

    def upload_chunk(self, form: dict[str, Any] | None = None, files: dict[str, tuple[str, bytes]] | None = None, *, directory_name: Any = None, chunkindex: Any = None, upload_dir_path: Any = None, folder_dir_path: Any = None) -> Any:
        """Upload chunk.  [POST /api/Upload/uploadchunk]"""
        return self._c.request_multipart("POST", "/api/Upload/uploadchunk", form or {}, files or {}, query={"directoryName": directory_name, "chunkindex": chunkindex, "uploadDirPath": upload_dir_path, "folderDirPath": folder_dir_path})

class VPNGatewayApi:
    """VPNGateway operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def create_p2_s_client(self, body: Any = None, *, region: Any = None) -> Any:
        """Create p2 sclient.  [POST /api/VPNGateway/clients/p2s]"""
        return self._c.request("POST", "/api/VPNGateway/clients/p2s", body, query={"region": region})

    def create_s2_s_connection(self, body: Any = None, *, region: Any = None) -> Any:
        """Create s2 sconnection.  [POST /api/VPNGateway/connections/s2s]"""
        return self._c.request("POST", "/api/VPNGateway/connections/s2s", body, query={"region": region})

    def create_vpn_gateway(self, body: Any = None) -> Any:
        """Create vpngateway.  [POST /api/VPNGateway/create]"""
        return self._c.request("POST", "/api/VPNGateway/create", body, query=None)

    def delete_s2_s_connection(self, connection_id: str, *, region: Any = None) -> Any:
        """Delete s2 sconnection.  [DELETE /api/VPNGateway/connections/s2s/{connectionId}]"""
        return self._c.request("DELETE", "/api/VPNGateway/connections/s2s/" + self._c._seg(connection_id), None, query={"region": region})

    def delete_vpn_gateway(self, gateway_id: str, *, gateway_name: Any = None, region: Any = None) -> Any:
        """Delete vpngateway.  [DELETE /api/VPNGateway/{gatewayId}]"""
        return self._c.request("DELETE", "/api/VPNGateway/" + self._c._seg(gateway_id), None, query={"gatewayName": gateway_name, "region": region})

    def download_client_config(self, client_id: str, *, region: Any = None) -> Any:
        """Download client config.  [GET /api/VPNGateway/clients/p2s/{clientId}/config]"""
        return self._c.request("GET", "/api/VPNGateway/clients/p2s/" + self._c._seg(client_id) + "/config", None, query={"region": region})

    def get_connected_clients(self, gateway_id: str, *, region: Any = None) -> Any:
        """Get connected clients.  [GET /api/VPNGateway/{gatewayId}/clients/p2s/connected]"""
        return self._c.request("GET", "/api/VPNGateway/" + self._c._seg(gateway_id) + "/clients/p2s/connected", None, query={"region": region})

    def get_s2_s_connection_status(self, connection_id: str, *, region: Any = None) -> Any:
        """Get s2 sconnection status.  [GET /api/VPNGateway/connections/s2s/{connectionId}/status]"""
        return self._c.request("GET", "/api/VPNGateway/connections/s2s/" + self._c._seg(connection_id) + "/status", None, query={"region": region})

    def get_vpn_gateway(self, gateway_id: str) -> Any:
        """Get vpngateway.  [GET /api/VPNGateway/{gatewayId}]"""
        return self._c.request("GET", "/api/VPNGateway/" + self._c._seg(gateway_id), None, query=None)

    def get_vpn_gateway_status(self, gateway_id: str, *, region: Any = None) -> Any:
        """Get vpngateway status.  [GET /api/VPNGateway/{gatewayId}/status]"""
        return self._c.request("GET", "/api/VPNGateway/" + self._c._seg(gateway_id) + "/status", None, query={"region": region})

    def list_p2_s_clients(self, gateway_id: str) -> Any:
        """List p2 sclients.  [GET /api/VPNGateway/{gatewayId}/clients/p2s]"""
        return self._c.request("GET", "/api/VPNGateway/" + self._c._seg(gateway_id) + "/clients/p2s", None, query=None)

    def list_s2_s_connections(self, gateway_id: str) -> Any:
        """List s2 sconnections.  [GET /api/VPNGateway/{gatewayId}/connections/s2s]"""
        return self._c.request("GET", "/api/VPNGateway/" + self._c._seg(gateway_id) + "/connections/s2s", None, query=None)

    def list_vpn_gateways(self, *, vnet_id: Any = None) -> Any:
        """List vpngateways.  [GET /api/VPNGateway/list]"""
        return self._c.request("GET", "/api/VPNGateway/list", None, query={"vnetId": vnet_id})

    def revoke_p2_s_client(self, client_id: str, *, region: Any = None) -> Any:
        """Revoke p2 sclient.  [DELETE /api/VPNGateway/clients/p2s/{clientId}]"""
        return self._c.request("DELETE", "/api/VPNGateway/clients/p2s/" + self._c._seg(client_id), None, query={"region": region})

class VXLANApi:
    """VXLAN operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def add_vtep(self, tunnel_id: str, body: Any = None) -> Any:
        """Add vtep.  [POST /api/VXLAN/tunnels/{tunnelId}/vteps]"""
        return self._c.request("POST", "/api/VXLAN/tunnels/" + self._c._seg(tunnel_id) + "/vteps", body, query=None)

    def create_tunnel(self, body: Any = None) -> Any:
        """Create tunnel.  [POST /api/VXLAN/tunnels]"""
        return self._c.request("POST", "/api/VXLAN/tunnels", body, query=None)

    def delete_tunnel(self, tunnel_id: str) -> Any:
        """Delete tunnel.  [DELETE /api/VXLAN/tunnels/{tunnelId}]"""
        return self._c.request("DELETE", "/api/VXLAN/tunnels/" + self._c._seg(tunnel_id), None, query=None)

    def get_tunnel(self, tunnel_id: str) -> Any:
        """Get tunnel.  [GET /api/VXLAN/tunnels/{tunnelId}]"""
        return self._c.request("GET", "/api/VXLAN/tunnels/" + self._c._seg(tunnel_id), None, query=None)

    def list_tunnels(self) -> Any:
        """List tunnels.  [GET /api/VXLAN/tunnels]"""
        return self._c.request("GET", "/api/VXLAN/tunnels", None, query=None)

    def remove_vtep(self, tunnel_id: str, vtep_ip: str) -> Any:
        """Remove vtep.  [DELETE /api/VXLAN/tunnels/{tunnelId}/vteps/{vtepIp}]"""
        return self._c.request("DELETE", "/api/VXLAN/tunnels/" + self._c._seg(tunnel_id) + "/vteps/" + self._c._seg(vtep_ip), None, query=None)

class VirtualMachineApi:
    """VirtualMachine operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def create_vm(self, body: Any = None) -> Any:
        """Create vm.  [POST /api/VirtualMachine/create-vm]"""
        return self._c.request("POST", "/api/VirtualMachine/create-vm", body, query=None)

    def destroy_vm(self, body: Any = None) -> Any:
        """Destroy vm.  [DELETE /api/VirtualMachine/destroy-vm]"""
        return self._c.request("DELETE", "/api/VirtualMachine/destroy-vm", body, query=None)

    def get_ssh_private_key(self, id_: str) -> Any:
        """Get ssh private key.  [GET /api/VirtualMachine/{id}/sshkey]"""
        return self._c.request("GET", "/api/VirtualMachine/" + self._c._seg(id_) + "/sshkey", None, query=None)

    def get_vm_info(self, *, vm_name: Any = None, regions: Any = None) -> Any:
        """Get vminfo.  [GET /api/VirtualMachine/vm-info]"""
        return self._c.request("GET", "/api/VirtualMachine/vm-info", None, query={"vmName": vm_name, "regions": regions})

    def list_local_vm_images(self, *, regions: Any = None) -> Any:
        """List local vmimages.  [GET /api/VirtualMachine/list-local-vm-images]"""
        return self._c.request("GET", "/api/VirtualMachine/list-local-vm-images", None, query={"regions": regions})

    def list_running_vms(self, *, regions: Any = None) -> Any:
        """List running vms.  [GET /api/VirtualMachine/list-running-vms]"""
        return self._c.request("GET", "/api/VirtualMachine/list-running-vms", None, query={"regions": regions})

    def list_vms(self, *, regions: Any = None) -> Any:
        """List vms.  [GET /api/VirtualMachine/list-vms]"""
        return self._c.request("GET", "/api/VirtualMachine/list-vms", None, query={"regions": regions})

    def list_vms_info(self, *, regions: Any = None) -> Any:
        """List vms info.  [GET /api/VirtualMachine/list-vms-info]"""
        return self._c.request("GET", "/api/VirtualMachine/list-vms-info", None, query={"regions": regions})

    def reset_password(self, body: Any = None) -> Any:
        """Reset password.  [POST /api/VirtualMachine/reset-password]"""
        return self._c.request("POST", "/api/VirtualMachine/reset-password", body, query=None)

    def start_vm(self, body: Any = None) -> Any:
        """Start vm.  [POST /api/VirtualMachine/start-vm]"""
        return self._c.request("POST", "/api/VirtualMachine/start-vm", body, query=None)

    def stop_vm(self, body: Any = None) -> Any:
        """Stop vm.  [POST /api/VirtualMachine/stop-vm]"""
        return self._c.request("POST", "/api/VirtualMachine/stop-vm", body, query=None)

class VirtualNetworkApi:
    """VirtualNetwork operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def create_v_net(self, body: Any = None) -> Any:
        """Create vnet.  [POST /api/VirtualNetwork/create-vnet]"""
        return self._c.request("POST", "/api/VirtualNetwork/create-vnet", body, query=None)

    def create_vnet_peering(self, vnet_id: str, body: Any = None) -> Any:
        """Create vnet peering.  [POST /api/VirtualNetwork/{vnetId}/peerings]"""
        return self._c.request("POST", "/api/VirtualNetwork/" + self._c._seg(vnet_id) + "/peerings", body, query=None)

    def delete_vnet_peering(self, vnet_id: str, peering_id: str) -> Any:
        """Delete vnet peering.  [DELETE /api/VirtualNetwork/{vnetId}/peerings/{peeringId}]"""
        return self._c.request("DELETE", "/api/VirtualNetwork/" + self._c._seg(vnet_id) + "/peerings/" + self._c._seg(peering_id), None, query=None)

    def delete_vnet_subnet(self, vnet_id: str, subnet_id: str) -> Any:
        """Delete vnet subnet.  [DELETE /api/VirtualNetwork/{vnetId}/subnets/{subnetId}]"""
        return self._c.request("DELETE", "/api/VirtualNetwork/" + self._c._seg(vnet_id) + "/subnets/" + self._c._seg(subnet_id), None, query=None)

    def destroy_v_net(self, body: Any = None) -> Any:
        """Destroy vnet.  [DELETE /api/VirtualNetwork/delete-vnet]"""
        return self._c.request("DELETE", "/api/VirtualNetwork/delete-vnet", body, query=None)

    def list_all_peerings(self) -> Any:
        """List all peerings.  [GET /api/VirtualNetwork/peerings]"""
        return self._c.request("GET", "/api/VirtualNetwork/peerings", None, query=None)

    def list_all_subnets(self) -> Any:
        """List all subnets.  [GET /api/VirtualNetwork/subnets]"""
        return self._c.request("GET", "/api/VirtualNetwork/subnets", None, query=None)

    def list_vms_info(self) -> Any:
        """List vms info.  [GET /api/VirtualNetwork/list-vnets]"""
        return self._c.request("GET", "/api/VirtualNetwork/list-vnets", None, query=None)

    def list_vnet_address_spaces(self, vnet_id: str) -> Any:
        """List vnet address spaces.  [GET /api/VirtualNetwork/{vnetId}/address-spaces]"""
        return self._c.request("GET", "/api/VirtualNetwork/" + self._c._seg(vnet_id) + "/address-spaces", None, query=None)

    def list_vnet_peerings(self, vnet_id: str) -> Any:
        """List vnet peerings.  [GET /api/VirtualNetwork/{vnetId}/peerings]"""
        return self._c.request("GET", "/api/VirtualNetwork/" + self._c._seg(vnet_id) + "/peerings", None, query=None)

    def list_vnet_subnets(self, vnet_id: str) -> Any:
        """List vnet subnets.  [GET /api/VirtualNetwork/{vnetId}/subnets]"""
        return self._c.request("GET", "/api/VirtualNetwork/" + self._c._seg(vnet_id) + "/subnets", None, query=None)

    def save_vnet_address_space(self, vnet_id: str, body: Any = None) -> Any:
        """Save vnet address space.  [PUT /api/VirtualNetwork/{vnetId}/address-spaces]"""
        return self._c.request("PUT", "/api/VirtualNetwork/" + self._c._seg(vnet_id) + "/address-spaces", body, query=None)

    def save_vnet_subnet(self, vnet_id: str, body: Any = None) -> Any:
        """Save vnet subnet.  [PUT /api/VirtualNetwork/{vnetId}/subnets]"""
        return self._c.request("PUT", "/api/VirtualNetwork/" + self._c._seg(vnet_id) + "/subnets", body, query=None)

class VmConsoleApi:
    """VmConsole operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def console(self, id_: str) -> Any:
        """Console.  [GET /api/VirtualMachine/{id}/console]"""
        return self._c.request("GET", "/api/VirtualMachine/" + self._c._seg(id_) + "/console", None, query=None)

    def console_ticket(self, id_: str) -> Any:
        """Console ticket.  [GET /api/VirtualMachine/{id}/console-ticket]"""
        return self._c.request("GET", "/api/VirtualMachine/" + self._c._seg(id_) + "/console-ticket", None, query=None)

class VmNetworkApi:
    """VmNetwork operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def create(self, vm_name: str, body: Any = None) -> Any:
        """Create.  [POST /api/VirtualMachine/{vmName}/network-rules]"""
        return self._c.request("POST", "/api/VirtualMachine/" + self._c._seg(vm_name) + "/network-rules", body, query=None)

    def delete(self, id_: str) -> Any:
        """Delete.  [DELETE /api/VirtualMachine/network-rules/{id}]"""
        return self._c.request("DELETE", "/api/VirtualMachine/network-rules/" + self._c._seg(id_), None, query=None)

    def list(self, vm_name: str, *, type_: Any = None, direction: Any = None) -> Any:
        """List.  [GET /api/VirtualMachine/{vmName}/network-rules]"""
        return self._c.request("GET", "/api/VirtualMachine/" + self._c._seg(vm_name) + "/network-rules", None, query={"type": type_, "direction": direction})

    def network_info(self, vm_name: str) -> Any:
        """Network info.  [GET /api/VirtualMachine/{vmName}/network-info]"""
        return self._c.request("GET", "/api/VirtualMachine/" + self._c._seg(vm_name) + "/network-info", None, query=None)

    def sync(self, vm_name: str) -> Any:
        """Sync.  [POST /api/VirtualMachine/{vmName}/network-rules/sync]"""
        return self._c.request("POST", "/api/VirtualMachine/" + self._c._seg(vm_name) + "/network-rules/sync", None, query=None)

    def update(self, id_: str, body: Any = None) -> Any:
        """Update.  [PUT /api/VirtualMachine/network-rules/{id}]"""
        return self._c.request("PUT", "/api/VirtualMachine/network-rules/" + self._c._seg(id_), body, query=None)

class VmOperationsApi:
    """VmOperations operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def attach_nic(self, vm_name: str, body: Any = None) -> Any:
        """Attach nic.  [POST /api/VirtualMachine/{vmName}/nics]"""
        return self._c.request("POST", "/api/VirtualMachine/" + self._c._seg(vm_name) + "/nics", body, query=None)

    def attach_public_ip(self, vm_name: str, body: Any = None) -> Any:
        """Attach public ip.  [POST /api/VirtualMachine/{vmName}/public-ips]"""
        return self._c.request("POST", "/api/VirtualMachine/" + self._c._seg(vm_name) + "/public-ips", body, query=None)

    def connect(self, vm_name: str) -> Any:
        """Connect.  [GET /api/VirtualMachine/{vmName}/connect]"""
        return self._c.request("GET", "/api/VirtualMachine/" + self._c._seg(vm_name) + "/connect", None, query=None)

    def create_snapshot(self, vm_name: str, body: Any = None) -> Any:
        """Create snapshot.  [POST /api/VirtualMachine/{vmName}/snapshots]"""
        return self._c.request("POST", "/api/VirtualMachine/" + self._c._seg(vm_name) + "/snapshots", body, query=None)

    def delete_snapshot(self, vm_name: str, snapshot_name: str) -> Any:
        """Delete snapshot.  [DELETE /api/VirtualMachine/{vmName}/snapshots/{snapshotName}]"""
        return self._c.request("DELETE", "/api/VirtualMachine/" + self._c._seg(vm_name) + "/snapshots/" + self._c._seg(snapshot_name), None, query=None)

    def detach_nic(self, vm_name: str, mac: str) -> Any:
        """Detach nic.  [DELETE /api/VirtualMachine/{vmName}/nics/{mac}]"""
        return self._c.request("DELETE", "/api/VirtualMachine/" + self._c._seg(vm_name) + "/nics/" + self._c._seg(mac), None, query=None)

    def detach_public_ip(self, vm_name: str, allocation_id: str) -> Any:
        """Detach public ip.  [DELETE /api/VirtualMachine/{vmName}/public-ips/{allocationId}]"""
        return self._c.request("DELETE", "/api/VirtualMachine/" + self._c._seg(vm_name) + "/public-ips/" + self._c._seg(allocation_id), None, query=None)

    def list_nics(self, vm_name: str) -> Any:
        """List nics.  [GET /api/VirtualMachine/{vmName}/nics]"""
        return self._c.request("GET", "/api/VirtualMachine/" + self._c._seg(vm_name) + "/nics", None, query=None)

    def list_public_ips(self, vm_name: str) -> Any:
        """List public ips.  [GET /api/VirtualMachine/{vmName}/public-ips]"""
        return self._c.request("GET", "/api/VirtualMachine/" + self._c._seg(vm_name) + "/public-ips", None, query=None)

    def list_snapshots(self, vm_name: str) -> Any:
        """List snapshots.  [GET /api/VirtualMachine/{vmName}/snapshots]"""
        return self._c.request("GET", "/api/VirtualMachine/" + self._c._seg(vm_name) + "/snapshots", None, query=None)

    def rdp_file(self, vm_name: str) -> Any:
        """Rdp file.  [GET /api/VirtualMachine/{vmName}/rdp-file]"""
        return self._c.request("GET", "/api/VirtualMachine/" + self._c._seg(vm_name) + "/rdp-file", None, query=None)

    def restore_snapshot(self, vm_name: str, snapshot_name: str) -> Any:
        """Restore snapshot.  [POST /api/VirtualMachine/{vmName}/snapshots/{snapshotName}/restore]"""
        return self._c.request("POST", "/api/VirtualMachine/" + self._c._seg(vm_name) + "/snapshots/" + self._c._seg(snapshot_name) + "/restore", None, query=None)

    def ssh_key(self, vm_name: str) -> Any:
        """Ssh key.  [GET /api/VirtualMachine/{vmName}/ssh-key]"""
        return self._c.request("GET", "/api/VirtualMachine/" + self._c._seg(vm_name) + "/ssh-key", None, query=None)

class WebmailApi:
    """Webmail operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def assist(self, body: Any = None, *, account_id: Any = None) -> Any:
        """Assist.  [POST /api/mail/assist]"""
        return self._c.request("POST", "/api/mail/assist", body, query={"accountId": account_id})

    def attachment(self, id_: str, attachment_id: str, *, account_id: Any = None) -> Any:
        """Attachment.  [GET /api/mail/messages/{id}/attachments/{attachmentId}]"""
        return self._c.request("GET", "/api/mail/messages/" + self._c._seg(id_) + "/attachments/" + self._c._seg(attachment_id), None, query={"accountId": account_id})

    def change_password(self, body: Any = None) -> Any:
        """Change password.  [POST /api/mail/password]"""
        return self._c.request("POST", "/api/mail/password", body, query=None)

    def contacts(self, *, account_id: Any = None, q: Any = None) -> Any:
        """Contacts.  [GET /api/mail/contacts]"""
        return self._c.request("GET", "/api/mail/contacts", None, query={"accountId": account_id, "q": q})

    def create_filter(self, body: Any = None, *, account_id: Any = None) -> Any:
        """Create filter.  [POST /api/mail/filters]"""
        return self._c.request("POST", "/api/mail/filters", body, query={"accountId": account_id})

    def create_folder(self, body: Any = None, *, account_id: Any = None) -> Any:
        """Create folder.  [POST /api/mail/folders]"""
        return self._c.request("POST", "/api/mail/folders", body, query={"accountId": account_id})

    def create_label(self, body: Any = None, *, account_id: Any = None) -> Any:
        """Create label.  [POST /api/mail/labels]"""
        return self._c.request("POST", "/api/mail/labels", body, query={"accountId": account_id})

    def delete(self, body: Any = None, *, account_id: Any = None) -> Any:
        """Delete.  [POST /api/mail/messages/delete]"""
        return self._c.request("POST", "/api/mail/messages/delete", body, query={"accountId": account_id})

    def delete_filter(self, id_: str, *, account_id: Any = None) -> Any:
        """Delete filter.  [DELETE /api/mail/filters/{id}]"""
        return self._c.request("DELETE", "/api/mail/filters/" + self._c._seg(id_), None, query={"accountId": account_id})

    def drop_upload(self, id_: str, *, account_id: Any = None) -> Any:
        """Drop upload.  [DELETE /api/mail/attachments/{id}]"""
        return self._c.request("DELETE", "/api/mail/attachments/" + self._c._seg(id_), None, query={"accountId": account_id})

    def filters(self, *, account_id: Any = None) -> Any:
        """Filters.  [GET /api/mail/filters]"""
        return self._c.request("GET", "/api/mail/filters", None, query={"accountId": account_id})

    def flag(self, body: Any = None, *, account_id: Any = None) -> Any:
        """Flag.  [POST /api/mail/messages/flag]"""
        return self._c.request("POST", "/api/mail/messages/flag", body, query={"accountId": account_id})

    def folders(self, *, account_id: Any = None) -> Any:
        """Folders.  [GET /api/mail/folders]"""
        return self._c.request("GET", "/api/mail/folders", None, query={"accountId": account_id})

    def me(self) -> Any:
        """Me.  [GET /api/mail/me]"""
        return self._c.request("GET", "/api/mail/me", None, query=None)

    def message(self, id_: str, *, account_id: Any = None, mark_read: Any = None) -> Any:
        """Message.  [GET /api/mail/messages/{id}]"""
        return self._c.request("GET", "/api/mail/messages/" + self._c._seg(id_), None, query={"accountId": account_id, "markRead": mark_read})

    def messages(self, *, account_id: Any = None, folder_id: Any = None, q: Any = None, unread: Any = None, starred: Any = None, page: Any = None, page_size: Any = None) -> Any:
        """Messages.  [GET /api/mail/messages]"""
        return self._c.request("GET", "/api/mail/messages", None, query={"accountId": account_id, "folderId": folder_id, "q": q, "unread": unread, "starred": starred, "page": page, "pageSize": page_size})

    def mine(self) -> Any:
        """Mine.  [GET /api/mail/mine]"""
        return self._c.request("GET", "/api/mail/mine", None, query=None)

    def move(self, body: Any = None, *, account_id: Any = None) -> Any:
        """Move.  [POST /api/mail/messages/move]"""
        return self._c.request("POST", "/api/mail/messages/move", body, query={"accountId": account_id})

    def quote(self, id_: str, *, account_id: Any = None, forward: Any = None) -> Any:
        """Quote.  [GET /api/mail/messages/{id}/quote]"""
        return self._c.request("GET", "/api/mail/messages/" + self._c._seg(id_) + "/quote", None, query={"accountId": account_id, "forward": forward})

    def save_draft(self, body: Any = None, *, account_id: Any = None) -> Any:
        """Save draft.  [POST /api/mail/draft]"""
        return self._c.request("POST", "/api/mail/draft", body, query={"accountId": account_id})

    def schedule(self, body: Any = None, *, account_id: Any = None) -> Any:
        """Schedule.  [POST /api/mail/schedule]"""
        return self._c.request("POST", "/api/mail/schedule", body, query={"accountId": account_id})

    def send(self, body: Any = None, *, account_id: Any = None) -> Any:
        """Send.  [POST /api/mail/send]"""
        return self._c.request("POST", "/api/mail/send", body, query={"accountId": account_id})

    def settings(self, body: Any = None, *, account_id: Any = None) -> Any:
        """Settings.  [PATCH /api/mail/settings]"""
        return self._c.request("PATCH", "/api/mail/settings", body, query={"accountId": account_id})

    def sign_in(self, body: Any = None) -> Any:
        """Sign in.  [POST /api/mail/signin]"""
        return self._c.request("POST", "/api/mail/signin", body, query=None)

    def sign_out(self) -> Any:
        """Sign out.  [POST /api/mail/signout]"""
        return self._c.request("POST", "/api/mail/signout", None, query=None)

    def unschedule(self, id_: str, *, account_id: Any = None) -> Any:
        """Unschedule.  [POST /api/mail/schedule/{id}/cancel]"""
        return self._c.request("POST", "/api/mail/schedule/" + self._c._seg(id_) + "/cancel", None, query={"accountId": account_id})

    def upload(self, form: dict[str, Any] | None = None, files: dict[str, tuple[str, bytes]] | None = None, *, account_id: Any = None) -> Any:
        """Upload.  [POST /api/mail/attachments]"""
        return self._c.request_multipart("POST", "/api/mail/attachments", form or {}, files or {}, query={"accountId": account_id})

class WidgetApi:
    """Widget operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def add_widget_to_panel(self, body: Any = None) -> Any:
        """Add widget to panel.  [POST /api/Widget/addwidgettopanel]"""
        return self._c.request("POST", "/api/Widget/addwidgettopanel", body, query=None)

    def clone_widget(self, body: Any = None) -> Any:
        """Clone widget.  [POST /api/Widget/clonewidget]"""
        return self._c.request("POST", "/api/Widget/clonewidget", body, query=None)

    def create_default_widgets(self, body: Any = None) -> Any:
        """Create default widgets.  [POST /api/Widget/createdefaultwidgets]"""
        return self._c.request("POST", "/api/Widget/createdefaultwidgets", body, query=None)

    def create_widget_template(self, body: Any = None) -> Any:
        """Create widget template.  [POST /api/Widget/createwidgettemplate]"""
        return self._c.request("POST", "/api/Widget/createwidgettemplate", body, query=None)

    def create_widgets_template(self, body: Any = None) -> Any:
        """Create widgets template.  [POST /api/Widget/createwidgetstemplate]"""
        return self._c.request("POST", "/api/Widget/createwidgetstemplate", body, query=None)

    def default_widgets(self) -> Any:
        """Default widgets.  [GET /api/Widget/defaultwidgets]"""
        return self._c.request("GET", "/api/Widget/defaultwidgets", None, query=None)

    def delete_widget_from_panel(self, body: Any = None) -> Any:
        """Delete widget from panel.  [DELETE /api/Widget/deletepanelwidget]"""
        return self._c.request("DELETE", "/api/Widget/deletepanelwidget", body, query=None)

    def delete_widget_template(self, id_: str) -> Any:
        """Delete widget template.  [DELETE /api/Widget/deletewidgettemplate/{id}]"""
        return self._c.request("DELETE", "/api/Widget/deletewidgettemplate/" + self._c._seg(id_), None, query=None)

    def get_widget_settings(self, body: Any = None) -> Any:
        """Get widget settings.  [POST /api/Widget/getwidgetsettings]"""
        return self._c.request("POST", "/api/Widget/getwidgetsettings", body, query=None)

    def update_widget_position(self, body: Any = None) -> Any:
        """Update widget position.  [POST /api/Widget/updatewidgetposition]"""
        return self._c.request("POST", "/api/Widget/updatewidgetposition", body, query=None)

    def update_widget_settings(self, body: Any = None) -> Any:
        """Update widget settings.  [POST /api/Widget/updatewidgetsettings]"""
        return self._c.request("POST", "/api/Widget/updatewidgetsettings", body, query=None)

    def update_widget_template(self, id_: str, body: Any = None) -> Any:
        """Update widget template.  [PUT /api/Widget/updatewidgettemplate/{id}]"""
        return self._c.request("PUT", "/api/Widget/updatewidgettemplate/" + self._c._seg(id_), body, query=None)

    def widget_details(self, body: Any = None) -> Any:
        """Widget details.  [POST /api/Widget/widgetdetails]"""
        return self._c.request("POST", "/api/Widget/widgetdetails", body, query=None)

    def widget_library(self) -> Any:
        """Widget library.  [GET /api/Widget/widgetlibrary]"""
        return self._c.request("GET", "/api/Widget/widgetlibrary", None, query=None)

    def widget_options(self, body: Any = None) -> Any:
        """Widget options.  [POST /api/Widget/widgetoptions]"""
        return self._c.request("POST", "/api/Widget/widgetoptions", body, query=None)

    def widgets(self, body: Any = None) -> Any:
        """Widgets.  [POST /api/Widget/widgets]"""
        return self._c.request("POST", "/api/Widget/widgets", body, query=None)

class YugabyteApi:
    """Yugabyte operations."""

    def __init__(self, client: "HiokClient"):
        self._c = client

    def attach(self, id_: str) -> Any:
        """Attach.  [POST /api/Yugabyte/{id}/vnet/attach]"""
        return self._c.request("POST", "/api/Yugabyte/" + self._c._seg(id_) + "/vnet/attach", None, query=None)

    def columns(self, id_: str, schema: str, table: str) -> Any:
        """Columns.  [GET /api/Yugabyte/{id}/tables/{schema}/{table}/columns]"""
        return self._c.request("GET", "/api/Yugabyte/" + self._c._seg(id_) + "/tables/" + self._c._seg(schema) + "/" + self._c._seg(table) + "/columns", None, query=None)

    def connection(self, id_: str) -> Any:
        """Connection.  [GET /api/Yugabyte/{id}/connection]"""
        return self._c.request("GET", "/api/Yugabyte/" + self._c._seg(id_) + "/connection", None, query=None)

    def create(self, body: Any = None) -> Any:
        """Create.  [POST /api/Yugabyte]"""
        return self._c.request("POST", "/api/Yugabyte", body, query=None)

    def delete(self, id_: str) -> Any:
        """Delete.  [DELETE /api/Yugabyte/{id}]"""
        return self._c.request("DELETE", "/api/Yugabyte/" + self._c._seg(id_), None, query=None)

    def detach(self, id_: str) -> Any:
        """Detach.  [POST /api/Yugabyte/{id}/vnet/detach]"""
        return self._c.request("POST", "/api/Yugabyte/" + self._c._seg(id_) + "/vnet/detach", None, query=None)

    def get(self, id_: str) -> Any:
        """Get.  [GET /api/Yugabyte/{id}]"""
        return self._c.request("GET", "/api/Yugabyte/" + self._c._seg(id_), None, query=None)

    def list(self) -> Any:
        """List.  [GET /api/Yugabyte]"""
        return self._c.request("GET", "/api/Yugabyte", None, query=None)

    def query(self, id_: str, body: Any = None) -> Any:
        """Query.  [POST /api/Yugabyte/{id}/query]"""
        return self._c.request("POST", "/api/Yugabyte/" + self._c._seg(id_) + "/query", body, query=None)

    def start(self, id_: str) -> Any:
        """Start.  [POST /api/Yugabyte/{id}/start]"""
        return self._c.request("POST", "/api/Yugabyte/" + self._c._seg(id_) + "/start", None, query=None)

    def stop(self, id_: str) -> Any:
        """Stop.  [POST /api/Yugabyte/{id}/stop]"""
        return self._c.request("POST", "/api/Yugabyte/" + self._c._seg(id_) + "/stop", None, query=None)

    def tables(self, id_: str) -> Any:
        """Tables.  [GET /api/Yugabyte/{id}/tables]"""
        return self._c.request("GET", "/api/Yugabyte/" + self._c._seg(id_) + "/tables", None, query=None)


class Api:
    """Every API operation, grouped as the API groups them: client.api.<group>.<operation>()."""

    def __init__(self, client: "HiokClient"):
        self.access_control = AccessControlApi(client)
        self.account = AccountApi(client)
        self.admin = AdminApi(client)
        self.admin_data = AdminDataApi(client)
        self.admin_dns = AdminDnsApi(client)
        self.admin_infrastructure = AdminInfrastructureApi(client)
        self.advisor = AdvisorApi(client)
        self.analytics = AnalyticsApi(client)
        self.api_management = ApiManagementApi(client)
        self.assistant = AssistantApi(client)
        self.bastion = BastionApi(client)
        self.billing_webhook = BillingWebhookApi(client)
        self.cache = CacheApi(client)
        self.cards = CardsApi(client)
        self.cloud_shell = CloudShellApi(client)
        self.cloud_subscription = CloudSubscriptionApi(client)
        self.common_services = CommonServicesApi(client)
        self.communication = CommunicationApi(client)
        self.container_app = ContainerAppApi(client)
        self.container_jobs = ContainerJobsApi(client)
        self.container_registry = ContainerRegistryApi(client)
        self.containers = ContainersApi(client)
        self.cost_tracking = CostTrackingApi(client)
        self.create_resource = CreateResourceApi(client)
        self.deployment = DeploymentApi(client)
        self.docker_images = DockerImagesApi(client)
        self.downloads = DownloadsApi(client)
        self.dps = DpsApi(client)
        self.fx = FxApi(client)
        self.groups = GroupsApi(client)
        self.hierarchy_view = HierarchyViewApi(client)
        self.hiok_cloud_groups = HiokCloudGroupsApi(client)
        self.hiok_cloud_hierarchy = HiokCloudHierarchyApi(client)
        self.hiok_id = HiokIdApi(client)
        self.hiok_users = HiokUsersApi(client)
        self.hybrid = HybridApi(client)
        self.identity = IdentityApi(client)
        self.infrastructure = InfrastructureApi(client)
        self.integrations = IntegrationsApi(client)
        self.io_t_device_gateway = IoTDeviceGatewayApi(client)
        self.io_t_hub = IoTHubApi(client)
        self.io_t_hub_device = IoTHubDeviceApi(client)
        self.io_t_hub_diagnostics = IoTHubDiagnosticsApi(client)
        self.io_t_hub_management = IoTHubManagementApi(client)
        self.io_t_hub_protocol = IoTHubProtocolApi(client)
        self.k9s_console = K9sConsoleApi(client)
        self.key_vault = KeyVaultApi(client)
        self.kubernetes = KubernetesApi(client)
        self.mail_admin = MailAdminApi(client)
        self.marketplace = MarketplaceApi(client)
        self.metrics = MetricsApi(client)
        self.mongo = MongoApi(client)
        self.my_sql_database = MySqlDatabaseApi(client)
        self.network_access = NetworkAccessApi(client)
        self.notification = NotificationApi(client)
        self.o_auth = OAuthApi(client)
        self.ovs = OVSApi(client)
        self.oidc = OidcApi(client)
        self.panel = PanelApi(client)
        self.postgres_database = PostgresDatabaseApi(client)
        self.pricing = PricingApi(client)
        self.profile = ProfileApi(client)
        self.pulse = PulseApi(client)
        self.recent_resources = RecentResourcesApi(client)
        self.resource_governance = ResourceGovernanceApi(client)
        self.resource_groups = ResourceGroupsApi(client)
        self.resource_metrics = ResourceMetricsApi(client)
        self.resource_operations = ResourceOperationsApi(client)
        self.sandbox = SandboxApi(client)
        self.search = SearchApi(client)
        self.service_bus = ServiceBusApi(client)
        self.slack = SlackApi(client)
        self.sql_server_database = SqlServerDatabaseApi(client)
        self.storage = StorageApi(client)
        self.storage_account = StorageAccountApi(client)
        self.storage_data = StorageDataApi(client)
        self.storage_object = StorageObjectApi(client)
        self.stream_analytics = StreamAnalyticsApi(client)
        self.stream_pipeline = StreamPipelineApi(client)
        self.streaming = StreamingApi(client)
        self.subscription = SubscriptionApi(client)
        self.support = SupportApi(client)
        self.support_queue = SupportQueueApi(client)
        self.upload = UploadApi(client)
        self.vpn_gateway = VPNGatewayApi(client)
        self.vxlan = VXLANApi(client)
        self.virtual_machine = VirtualMachineApi(client)
        self.virtual_network = VirtualNetworkApi(client)
        self.vm_console = VmConsoleApi(client)
        self.vm_network = VmNetworkApi(client)
        self.vm_operations = VmOperationsApi(client)
        self.webmail = WebmailApi(client)
        self.widget = WidgetApi(client)
        self.yugabyte = YugabyteApi(client)
