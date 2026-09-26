"""Dependency-free HIOK Cloud REST client.

    from hiok import HiokClient
    client = HiokClient("https://hiokcloud.com", token=os.environ["HIOK_TOKEN"])
    client.api.key_vault.list()                         # every API operation, by group
    client.storage.upload_file(account_id, "data", "backups/db.dump", "db.dump")

Authentication is a bearer token (``token=`` or ``login()``) or, for one storage
account's data only, a storage access key (``storage_key=``).
"""
from __future__ import annotations

import json
import os
import time
import urllib.error
import urllib.parse
import urllib.request
import uuid
from typing import Any

from ._generated import Api


class HiokError(RuntimeError):
    """An API request returned an error response.

    ``status`` is the HTTP status, ``message`` the API's explanation and ``body``
    the parsed response (or raw text when it was not JSON).
    """

    def __init__(self, message: str, status: int = 0, body: Any = None):
        super().__init__(message)
        self.status = status
        self.message = message
        self.body = body


# Retried with a growing pause: the API answers 502/503/504 for the seconds it is
# being replaced, and 429 when a caller is asked to slow down.
_RETRY_STATUS = {429, 502, 503, 504}
_SAFE_METHODS = {"GET", "HEAD", "OPTIONS", "PROPFIND"}


class HiokClient:
    def __init__(self, endpoint: str | None = None, token: str | None = None, *,
                 storage_key: str | None = None, client_id: str | None = None, client_secret: str | None = None,
                 timeout: float = 300, retries: int = 4):
        """
        endpoint       base URL, e.g. https://hiokcloud.com (default: $HIOK_ENDPOINT or https://hiokcloud.com)
        token          bearer token (default: $HIOK_TOKEN)
        storage_key    a storage account access key, for that account's data only (default: $HIOK_STORAGE_KEY)
        client_id,
        client_secret  a service principal, for CI/CD (default: $HIOK_CLIENT_ID / $HIOK_CLIENT_SECRET);
                       signed in on first use and renewed before its one-hour token lapses
        """
        self.endpoint = (endpoint or os.environ.get("HIOK_ENDPOINT") or "https://hiokcloud.com").rstrip("/")
        self.token = token or os.environ.get("HIOK_TOKEN")
        self.storage_key = storage_key or os.environ.get("HIOK_STORAGE_KEY")
        self.client_id = client_id or (None if token else os.environ.get("HIOK_CLIENT_ID"))
        self.client_secret = client_secret or (None if token else os.environ.get("HIOK_CLIENT_SECRET"))
        self._sp_expires = 0.0
        self.timeout = timeout
        self.retries = retries
        self.api = Api(self)
        from .storage import StorageTransfer
        self.storage = StorageTransfer(self)

    def login(self, email: str, password: str) -> "HiokClient":
        payload = self.request("POST", "/api/OAuth/token", {"email": email, "password": password}, auth=False)
        token = (payload or {}).get("data", {}).get("token")
        if not token:
            raise HiokError((payload or {}).get("message", "Sign-in failed"))
        self.token = token
        return self

    def login_service_principal(self, client_id: str, client_secret: str) -> "HiokClient":
        """Sign in as a service principal (Identity → Service principals). The token lasts an
        hour; a client built with client_id/client_secret renews it by itself."""
        payload = self.request("POST", "/api/OAuth/token/client",
                               {"clientId": client_id, "clientSecret": client_secret}, auth=False)
        token = (payload or {}).get("data", {}).get("token")
        if not token:
            raise HiokError((payload or {}).get("message", "Service principal sign-in failed"))
        self.client_id, self.client_secret = client_id, client_secret
        self.token = token
        self._sp_expires = time.time() + 55 * 60
        return self

    def _ensure_token(self) -> None:
        if not (self.client_id and self.client_secret):
            return
        if self.token and (self._sp_expires == 0 or time.time() < self._sp_expires):
            return
        self.login_service_principal(self.client_id, self.client_secret)

    # ── transport ──────────────────────────────────────────────────────────

    @staticmethod
    def _seg(value: Any, slashed: bool = False) -> str:
        """Encode one path parameter; a key keeps its slashes ("dir/file.txt")."""
        return urllib.parse.quote(str(value), safe="/" if slashed else "")

    @staticmethod
    def _query(query: dict[str, Any] | None) -> str:
        if not query:
            return ""
        pairs: list[tuple[str, str]] = []
        for key, value in query.items():
            if value is None:
                continue
            values = value if isinstance(value, (list, tuple)) else [value]
            for v in values:
                pairs.append((key, "true" if v is True else "false" if v is False else str(v)))
        return ("?" + urllib.parse.urlencode(pairs)) if pairs else ""

    def _headers(self, auth: bool, extra: dict[str, str] | None) -> dict[str, str]:
        headers = {"Accept": "application/json", "User-Agent": "hiok-python-sdk/0.4"}
        if auth:
            self._ensure_token()
            if self.token:
                headers["Authorization"] = f"Bearer {self.token}"
            elif self.storage_key:
                headers["x-hiok-storage-key"] = self.storage_key
            else:
                raise HiokError("No credentials: pass token=, storage_key=, or call login() first")
        headers.update(extra or {})
        return headers

    def request(self, method: str, path: str, body: Any = None, *, query: dict[str, Any] | None = None,
                auth: bool = True, headers: dict[str, str] | None = None, raw: bool = False) -> Any:
        """Send one request. JSON responses are parsed; anything else is returned as bytes.

        ``body`` is JSON-encoded unless it is already bytes. ``raw=True`` returns the
        bytes whatever the content type.
        """
        data: bytes | None
        hdrs = self._headers(auth, headers)
        if body is None:
            data = None
        elif isinstance(body, (bytes, bytearray)):
            data = bytes(body)
        else:
            data = json.dumps(body).encode()
            hdrs.setdefault("Content-Type", "application/json")
        return self._send(method, path + self._query(query), data, hdrs, raw)

    def request_multipart(self, method: str, path: str, form: dict[str, Any], files: dict[str, tuple[str, bytes]],
                          *, query: dict[str, Any] | None = None) -> Any:
        """Send multipart/form-data: form fields and files as {field: (filename, bytes)}."""
        boundary = "----hiok" + uuid.uuid4().hex
        parts: list[bytes] = []
        for name, value in (form or {}).items():
            parts.append(f'--{boundary}\r\nContent-Disposition: form-data; name="{name}"\r\n\r\n{value}\r\n'.encode())
        for name, (filename, content) in (files or {}).items():
            parts.append(f'--{boundary}\r\nContent-Disposition: form-data; name="{name}"; filename="{filename}"\r\n'
                         f'Content-Type: application/octet-stream\r\n\r\n'.encode() + content + b"\r\n")
        parts.append(f"--{boundary}--\r\n".encode())
        hdrs = self._headers(True, {"Content-Type": f"multipart/form-data; boundary={boundary}"})
        return self._send(method, path + self._query(query), b"".join(parts), hdrs, False)

    def _send(self, method: str, target: str, data: bytes | None, headers: dict[str, str], raw: bool) -> Any:
        attempts = self.retries + 1 if method.upper() in _SAFE_METHODS else 1
        for attempt in range(attempts):
            req = urllib.request.Request(self.endpoint + target, data=data, headers=headers, method=method)
            try:
                with urllib.request.urlopen(req, timeout=self.timeout) as response:
                    content = response.read()
                    kind = response.headers.get("Content-Type", "")
                    if raw or (content and "json" not in kind):
                        return content
                    return json.loads(content) if content else None
            except urllib.error.HTTPError as exc:
                if exc.code in _RETRY_STATUS and attempt + 1 < attempts:
                    time.sleep(min(2 ** attempt, 16))
                    continue
                text = exc.read().decode(errors="replace")
                try:
                    parsed: Any = json.loads(text)
                except ValueError:
                    parsed = text
                message = (parsed.get("message") or parsed.get("Message") or text) if isinstance(parsed, dict) else text
                raise HiokError(f"{method} {target.split('?')[0]} returned {exc.code}: {message}", exc.code, parsed) from exc
            except urllib.error.URLError as exc:
                if attempt + 1 < attempts:
                    time.sleep(min(2 ** attempt, 16))
                    continue
                raise HiokError(f"{method} {target.split('?')[0]} failed: {exc.reason}") from exc
        raise HiokError(f"{method} {target} failed")

    def regions(self) -> list[dict[str, Any]]:
        return self.request("GET", "/api/storageaccount/regions", auth=False).get("data", [])

    def virtual_machines(self) -> list[dict[str, Any]]:
        return self.request("GET", "/api/VirtualMachine/list-vms-info").get("data", [])

    def create_virtual_machine(self, name: str, region: str = "canada", image: str = "ubuntu-24.04", vcpus: int = 1, ram_gb: float = 1) -> Any:
        return self.request("POST", "/api/VirtualMachine/create-vm", {
            "vmName": name, "regions": [region], "sourceFilePath": image,
            "vcpuCount": vcpus, "ramSize": ram_gb,
        })

    def search(self, query: str) -> dict[str, Any]:
        return self.request("GET", "/api/search?q=" + urllib.parse.quote(query)).get("data", {})

    def hierarchy(self) -> dict[str, Any]:
        return self.request("GET", "/api/hierarchyview/full").get("data", {})

    # ── Service Bus ─────────────────────────────────────────────────────

    def servicebus_namespaces(self) -> list[dict[str, Any]]:
        """Namespaces holding your queues and topics."""
        return self.request("GET", "/api/ServiceBus/namespaces")["data"]

    def create_servicebus_namespace(self, name: str, region: str = "canada", sku: str = "standard") -> Any:
        return self.request("POST", "/api/ServiceBus/namespaces",
                            {"name": name, "product": "servicebus", "primaryRegion": region, "sku": sku})

    def create_queue(self, namespace_id: str, name: str, *, max_delivery_count: int = 10,
                     requires_session: bool = False, dead_lettering: bool = True) -> Any:
        return self.request("POST", f"/api/ServiceBus/namespaces/{namespace_id}/queues", {
            "name": name, "maxDeliveryCount": max_delivery_count,
            "requiresSession": requires_session, "deadLetteringEnabled": dead_lettering,
        })

    def send_message(self, namespace_id: str, entity: str, body: str, *, subject: str | None = None,
                     session_id: str | None = None, scheduled_enqueue_time: str | None = None) -> Any:
        """Send one message. scheduled_enqueue_time holds it until that instant."""
        payload: dict[str, Any] = {"body": body}
        if subject:
            payload["subject"] = subject
        if session_id:
            payload["sessionId"] = session_id
        if scheduled_enqueue_time:
            payload["scheduledEnqueueTime"] = scheduled_enqueue_time
        return self.request("POST", f"/api/ServiceBus/namespaces/{namespace_id}/entities/{entity}/messages", payload)

    def receive_messages(self, namespace_id: str, entity: str, *, subscription: str | None = None,
                         max_messages: int = 1, mode: str = "peek_lock") -> list[dict[str, Any]]:
        """Receive messages. In peek_lock they stay locked until you settle them."""
        q = f"?subscription={subscription}" if subscription else ""
        return self.request("POST", f"/api/ServiceBus/namespaces/{namespace_id}/entities/{entity}/messages/receive{q}",
                            {"maxMessages": max_messages, "receiveMode": mode})["data"]

    def settle_messages(self, namespace_id: str, entity: str, lock_tokens: list[str],
                        disposition: str = "complete", *, subscription: str | None = None,
                        reason: str | None = None) -> Any:
        """Settle a delivery: complete, abandon, deadletter or defer."""
        q = f"?subscription={subscription}" if subscription else ""
        return self.request("POST", f"/api/ServiceBus/namespaces/{namespace_id}/entities/{entity}/messages/settle{q}",
                            {"lockTokens": lock_tokens, "disposition": disposition, "deadLetterReason": reason})

    def dead_letter_messages(self, namespace_id: str, entity: str, *, subscription: str | None = None,
                             max_messages: int = 10) -> list[dict[str, Any]]:
        q = f"&subscription={subscription}" if subscription else ""
        return self.request("POST",
                            f"/api/ServiceBus/namespaces/{namespace_id}/entities/{entity}/deadletter/receive?maxMessages={max_messages}{q}")["data"]

    # ── Event Mesh ──────────────────────────────────────────────────────

    def event_streams(self, namespace_id: str) -> list[dict[str, Any]]:
        return self.request("GET", f"/api/Pulse/namespaces/{namespace_id}/streams")["data"]

    def create_event_stream(self, namespace_id: str, name: str, *, partitions: int = 4,
                            retention_hours: int = 168) -> Any:
        return self.request("POST", f"/api/Pulse/namespaces/{namespace_id}/streams",
                            {"name": name, "partitionCount": partitions, "retentionHours": retention_hours})

    def publish_events(self, namespace_id: str, stream: str, events: list[dict[str, Any]]) -> Any:
        """Publish events. Each is {type, subject, data}."""
        return self.request("POST", f"/api/Pulse/namespaces/{namespace_id}/streams/{stream}/events",
                            {"events": events})

    def read_events(self, namespace_id: str, stream: str, consumer_group: str, max_events: int = 10) -> list[dict[str, Any]]:
        """Read through a consumer group, advancing its own cursor."""
        return self.request("POST",
                            f"/api/Pulse/namespaces/{namespace_id}/streams/{stream}/events/read"
                            f"?consumerGroup={consumer_group}&maxEvents={max_events}")["data"]["events"]

    def create_event_subscription(self, namespace_id: str, stream: str, name: str, webhook_url: str, *,
                                  event_types: list[str] | None = None,
                                  advanced_filters: list[dict[str, Any]] | None = None) -> Any:
        """Route matching events to a webhook, with retry and dead-lettering."""
        payload: dict[str, Any] = {
            "name": name, "handlerType": "webhook",
            "handlerConfig": {"url": webhook_url}, "eventFormat": "cloudevents",
        }
        if event_types:
            payload["includedEventTypes"] = event_types
        if advanced_filters:
            payload["advancedFilters"] = advanced_filters
        return self.request("POST", f"/api/Pulse/namespaces/{namespace_id}/streams/{stream}/subscriptions", payload)

    # ── Communication ───────────────────────────────────────────────────

    def communication_services(self) -> list[dict[str, Any]]:
        return self.request("GET", "/api/Communication/services")["data"]

    def send_email(self, service_id: str, to: list[str], subject: str, *,
                   text: str | None = None, html: str | None = None,
                   sender: str | None = None) -> Any:
        """Send mail. Omit sender to use the domain's default."""
        return self.request("POST", f"/api/Communication/services/{service_id}/emails", {
            "to": to, "subject": subject, "textBody": text, "htmlBody": html, "from": sender,
        })

    # ── Bastion ─────────────────────────────────────────────────────────

    def bastions(self) -> list[dict[str, Any]]:
        return self.request("GET", "/api/Bastion")["data"]

    def start_bastion_session(self, bastion_id: str, *, target_vm_id: str | None = None,
                              target_address: str | None = None, protocol: str = "rdp",
                              username: str | None = None, password: str | None = None,
                              ttl_minutes: int = 60) -> dict[str, Any]:
        """Open a browser session. Returns the portal URL and a short-lived signed token."""
        payload: dict[str, Any] = {"protocol": protocol, "ttlMinutes": ttl_minutes}
        if target_vm_id:
            payload["targetVmId"] = target_vm_id
        else:
            payload["targetAddress"] = target_address
        if username:
            payload["username"] = username
        if password:
            payload["password"] = password
        return self.request("POST", f"/api/Bastion/{bastion_id}/sessions", payload)["data"]

    # ── Analytics (managed ClickHouse) ──────────────────────────────────

    def analytics_clusters(self) -> list[dict[str, Any]]:
        return self.request("GET", "/api/Analytics")["data"]

    def create_analytics_cluster(self, name: str, *, region: str | None = None,
                                 sku: str = "small", storage_gb: int = 100,
                                 database: str = "default", admin_username: str = "hiokadmin",
                                 engine_version: str = "24.8-alpine",
                                 vnet_name: str | None = None,
                                 vnet_address: str | None = None) -> dict[str, Any]:
        """Provision a cluster. `sku` is dev, small, medium or large.

        Pass vnet_name and vnet_address (CIDR) to give the cluster an interface on a
        virtual network, so machines there reach it privately.
        """
        payload: dict[str, Any] = {
            "clusterName": name, "sku": sku, "storageGb": storage_gb,
            "databaseName": database, "adminUsername": admin_username,
            "engineVersion": engine_version,
        }
        if region:
            payload["region"] = region
        if vnet_name:
            payload["vnetName"] = vnet_name
            payload["vnetAddress"] = vnet_address
        return self.request("POST", "/api/Analytics", payload)["data"]

    def delete_analytics_cluster(self, cluster_id: str) -> Any:
        return self.request("DELETE", f"/api/Analytics/{cluster_id}")

    def start_analytics_cluster(self, cluster_id: str) -> dict[str, Any]:
        return self.request("POST", f"/api/Analytics/{cluster_id}/start", {})["data"]

    def stop_analytics_cluster(self, cluster_id: str) -> dict[str, Any]:
        return self.request("POST", f"/api/Analytics/{cluster_id}/stop", {})["data"]

    def analytics_connection(self, cluster_id: str) -> dict[str, Any]:
        """Connection details including the password."""
        return self.request("GET", f"/api/Analytics/{cluster_id}/connection")["data"]

    def analytics_tables(self, cluster_id: str) -> list[dict[str, Any]]:
        return self.request("GET", f"/api/Analytics/{cluster_id}/tables")["data"]

    def analytics_query(self, cluster_id: str, sql: str, *, max_rows: int = 1000) -> dict[str, Any]:
        """Run SQL. Returns columns, rows, timing and bytes read.

        Check `isSuccess`: a statement that fails returns the engine's diagnostic in
        `error` rather than raising.
        """
        return self.request("POST", f"/api/Analytics/{cluster_id}/query",
                            {"sql": sql, "maxRows": max_rows})["data"]

    def set_analytics_vnet(self, cluster_id: str, attach: bool) -> dict[str, Any]:
        action = "attach" if attach else "detach"
        return self.request("POST", f"/api/Analytics/{cluster_id}/vnet/{action}", {})["data"]

    # ── Live streaming ──────────────────────────────────────────────────

    def streaming_endpoints(self) -> list[dict[str, Any]]:
        """Each item carries the endpoint plus its ingest and playback URLs."""
        return self.request("GET", "/api/streaming")["data"]

    def create_streaming_endpoint(self, name: str, *, region: str | None = None,
                                  kind: str = "camera") -> dict[str, Any]:
        """Create an endpoint. `kind` is camera, video or content."""
        payload: dict[str, Any] = {"name": name, "kind": kind}
        if region:
            payload["region"] = region
        return self.request("POST", "/api/streaming", payload)["data"]

    def delete_streaming_endpoint(self, endpoint_id: str) -> Any:
        return self.request("DELETE", f"/api/streaming/{endpoint_id}")

    # ── Public IP addresses ─────────────────────────────────────────────
    #
    # A region routes a whole IPv6 prefix, so every VM and container can hold a real
    # public address from it. IPv4 is a single provider address that IS the host, so
    # that pool is marked not assignable and the API says so rather than returning
    # nothing.
    #
    # These routes need the "infrastructure" backoffice grant: they hand out provider
    # address space, not ordinary tenant resources.

    def ip_pools(self, region: str | None = None) -> list[dict[str, Any]]:
        """Address ranges the platform can hand out.

        A range with ``assignable`` false carries the reason in ``notes``.
        """
        query = f"?region={urllib.parse.quote(region)}" if region else ""
        return self.request("GET", f"/api/Infrastructure/ip-pools{query}").get("data", [])

    def ip_allocations(self, region: str | None = None, *,
                       include_released: bool = False) -> list[dict[str, Any]]:
        """Addresses currently held.

        Released addresses are kept for the record and only returned on request.
        """
        params: dict[str, str] = {}
        if region:
            params["region"] = region
        if include_released:
            params["includeReleased"] = "true"
        query = f"?{urllib.parse.urlencode(params)}" if params else ""
        return self.request("GET", f"/api/Infrastructure/ip-allocations{query}").get("data", [])

    def allocate_ip(self, *, region: str = "canada", family: int = 6,
                    resource_kind: str = "manual", resource_id: str | None = None,
                    resource_name: str | None = None, target_container: str | None = None,
                    target_kind: str = "container", hostname: str | None = None,
                    set_reverse_dns: bool = True) -> dict[str, Any]:
        """Take the next free address and configure the host to carry it.

        ``target_container`` is the name the HOST knows the guest by — the Docker
        container name, or the libvirt domain, which for a VM is ``<guid>#<name>``.
        Leave it out to reserve an address without configuring anything.

        ``hostname`` publishes DNS; a bare label lands in the managed zone. Reverse DNS
        is published too unless ``set_reverse_dns`` is false — the provider
        forward-confirms, so the forward record has to exist first, which is why the
        API publishes it first.
        """
        payload: dict[str, Any] = {
            "region": region,
            "family": family,
            "resourceKind": resource_kind,
            "targetKind": target_kind,
            "setReverseDns": set_reverse_dns,
        }
        if resource_id:
            payload["resourceId"] = resource_id
        if resource_name:
            payload["resourceName"] = resource_name
        if target_container:
            payload["targetContainer"] = target_container
        if hostname:
            payload["hostname"] = hostname
        return self.request("POST", "/api/Infrastructure/ip-allocations", payload)["data"]

    def release_ip(self, allocation_id: str, target_container: str | None = None) -> Any:
        """Give an address back and remove the host configuration carrying it.

        Omit ``target_container`` to use the target recorded when it was allocated.
        """
        query = f"?targetContainer={urllib.parse.quote(target_container)}" if target_container else ""
        return self.request("DELETE", f"/api/Infrastructure/ip-allocations/{allocation_id}{query}")

    def reconcile_ips(self, region: str | None = None) -> list[dict[str, Any]]:
        """Re-apply every live allocation on the hosts that carry them.

        Host routes and NDP proxy entries do not survive a reboot, so something has to
        put them back. The platform does this on a timer; call this when you already
        know a host has just come back and do not want to wait for the next pass.
        """
        query = f"?region={urllib.parse.quote(region)}" if region else ""
        return self.request("POST", f"/api/Infrastructure/ip-allocations/reconcile{query}", {}).get("data", [])

    # ── Key Vault ───────────────────────────────────────────────────────────

    def key_vaults(self) -> list[dict[str, Any]]:
        """Vaults you own. Soft-deleted ones are listed by ``deleted_key_vaults``."""
        return self.request("GET", "/api/KeyVault") or []

    def deleted_key_vaults(self) -> list[dict[str, Any]]:
        """The recovery bin: vaults still inside their retention window."""
        return self.request("GET", "/api/KeyVault/deleted") or []

    def create_key_vault(self, name: str, *, primary_region: str = "canada",
                         regions: list[str] | None = None, vnet_id: str | None = None,
                         vnet_name: str | None = None, allowed_cidrs: list[str] | None = None,
                         soft_delete_retention_days: int = 90,
                         purge_protection: bool = False) -> dict[str, Any]:
        """Create a vault.

        Leave ``vnet_id`` unset for a vault reachable wherever the caller can
        authenticate; set it to additionally require the request to arrive from that
        network. Both are the same plan, so you can change your mind later.

        ``purge_protection`` can be switched on later but never off — that is what
        stops someone who reaches the vault from disabling it and purging.
        """
        body: dict[str, Any] = {
            "name": name,
            "primaryRegion": primary_region,
            "softDeleteRetentionDays": soft_delete_retention_days,
            "purgeProtection": purge_protection,
        }
        if regions:
            body["regions"] = regions
        if vnet_id:
            body["vnetId"] = vnet_id
        if vnet_name:
            body["vnetName"] = vnet_name
        if allowed_cidrs:
            body["allowedCidrs"] = allowed_cidrs
        return self.request("POST", "/api/KeyVault", body)

    def delete_key_vault(self, vault_id: str) -> None:
        """Soft delete. Contents stay recoverable until the retention window ends."""
        self.request("DELETE", f"/api/KeyVault/{vault_id}")

    def recover_key_vault(self, vault_id: str) -> dict[str, Any]:
        return self.request("POST", f"/api/KeyVault/{vault_id}/recover", {})

    def purge_key_vault(self, vault_id: str) -> None:
        """Destroy a soft-deleted vault and everything in it. Cannot be undone, and is
        refused while purge protection holds."""
        self.request("DELETE", f"/api/KeyVault/{vault_id}/purge")

    def key_vault_items(self, vault_id: str, *, item_type: str | None = None,
                        include_deleted: bool = False) -> list[dict[str, Any]]:
        """Item metadata. Values are never included — use ``get_secret``."""
        query = []
        if item_type:
            query.append(f"itemType={urllib.parse.quote(item_type)}")
        if include_deleted:
            query.append("includeDeleted=true")
        suffix = ("?" + "&".join(query)) if query else ""
        return self.request("GET", f"/api/KeyVault/{vault_id}/items{suffix}") or []

    def set_secret(self, vault_id: str, name: str, value: str | None = None, *,
                   item_type: str = "secret", content_type: str | None = None,
                   expires_on: str | None = None, not_before: str | None = None,
                   tags: dict[str, str] | None = None, generate: bool = False,
                   size: int | None = None) -> dict[str, Any]:
        """Write an item.

        A name that already exists gets a new **version** rather than an overwrite, so
        the previous value stays retrievable and a bad rotation can be rolled back.
        """
        body: dict[str, Any] = {"name": name, "itemType": item_type, "generate": generate}
        if generate:
            if size:
                body["size"] = size
        else:
            body["value"] = value
        for key, val in (("contentType", content_type), ("expiresOn", expires_on),
                         ("notBefore", not_before)):
            if val:
                body[key] = val
        if tags:
            body["tags"] = tags
        return self.request("POST", f"/api/KeyVault/{vault_id}/items", body)

    def get_secret(self, vault_id: str, name: str, version: str | None = None) -> dict[str, Any]:
        """Read one item's value.

        This is the only call that discloses a value, which is why it is separate from
        listing. A disabled, expired or not-yet-valid item returns no value at all.
        """
        suffix = f"?version={urllib.parse.quote(version)}" if version else ""
        return self.request("GET", f"/api/KeyVault/{vault_id}/items/{urllib.parse.quote(name)}{suffix}")

    def secret_versions(self, vault_id: str, name: str) -> list[dict[str, Any]]:
        return self.request("GET", f"/api/KeyVault/{vault_id}/items/{urllib.parse.quote(name)}/versions") or []

    def delete_secret(self, vault_id: str, name: str) -> None:
        """Soft-delete every version, so a deleted secret cannot be read by asking for
        an older one."""
        self.request("DELETE", f"/api/KeyVault/{vault_id}/items/{urllib.parse.quote(name)}")

    def recover_secret(self, vault_id: str, name: str) -> dict[str, Any]:
        return self.request("POST", f"/api/KeyVault/{vault_id}/items/{urllib.parse.quote(name)}/recover", {})

    # ── Certificates ────────────────────────────────────────────────────────

    def create_certificate(self, vault_id: str, name: str, *, action: str = "self-signed",
                           subject: str | None = None,
                           subject_alternative_names: list[str] | None = None,
                           key_size: int = 2048, validity_days: int | None = None,
                           content: str | None = None, password: str | None = None,
                           tags: dict[str, str] | None = None) -> dict[str, Any]:
        """Create a certificate.

        ``action`` is one of:

        ``self-signed``
            Generate a key pair and sign it. Nothing vouches for the result.
        ``csr``
            Generate a key pair and return a signing request. The private key never
            leaves the vault, so the authority signs something it cannot impersonate.
            The item stays pending — and unusable — until ``merge_certificate``.
        ``import``
            Store existing material: PEM, or base64 PKCS#12 with ``password``.

        ``subject`` accepts a distinguished name, or a bare host name taken as the
        common name.
        """
        body: dict[str, Any] = {"name": name, "action": action}
        if action == "import":
            body["content"] = content
            if password:
                body["password"] = password
        else:
            body["subject"] = subject
            body["keySize"] = key_size
            if subject_alternative_names:
                body["subjectAlternativeNames"] = subject_alternative_names
            if action == "self-signed" and validity_days:
                body["validityDays"] = validity_days
        if tags:
            body["tags"] = tags
        return self.request("POST", f"/api/KeyVault/{vault_id}/certificates", body)

    def merge_certificate(self, vault_id: str, name: str, signed_certificate: str) -> dict[str, Any]:
        """Pair an authority-signed certificate with the key held for its request.

        A certificate issued for a different key is refused: the pair would be unable
        to complete a handshake, and that would only surface in production.
        """
        return self.request("POST", f"/api/KeyVault/{vault_id}/certificates/{urllib.parse.quote(name)}/merge",
                            {"signedCertificate": signed_certificate})

    def export_certificate(self, vault_id: str, name: str, *, fmt: str = "pem",
                           password: str | None = None,
                           include_private_key: bool = False) -> dict[str, Any]:
        """Export as PEM text, or as base64 PKCS#12.

        A PKCS#12 always carries the private key, so give it a password: anyone holding
        the file holds the identity.
        """
        body: dict[str, Any] = {"format": fmt, "includePrivateKey": include_private_key}
        if password:
            body["password"] = password
        return self.request("POST", f"/api/KeyVault/{vault_id}/certificates/{urllib.parse.quote(name)}/export", body)

    # ── MongoDB ─────────────────────────────────────────────────────────────

    def mongo_clusters(self) -> list[dict[str, Any]]:
        return self.request("GET", "/api/Mongo") or []

    def create_mongo_cluster(self, cluster_name: str, *, regions: list[str] | None = None,
                             consistency: str = "strong", max_staleness_seconds: int | None = None,
                             engine_version: str = "7.0", sku: str = "small",
                             storage_gb: int = 20, database_name: str | None = None,
                             vnet_name: str | None = None) -> dict[str, Any]:
        """Create a cluster. One region gives a single node; several give a replica set.

        ``consistency`` is ``strong``, ``session``, ``bounded`` or ``eventual``. It is
        not a label: it sets the read concern, write concern and read preference in the
        connection string, so it governs your driver. The last two read from secondary
        members and are refused on a single-region cluster.
        """
        regions = regions or ["canada"]
        body: dict[str, Any] = {
            "clusterName": cluster_name, "regions": regions, "region": regions[0],
            "consistency": consistency, "engineVersion": engine_version,
            "sku": sku, "storageGb": storage_gb,
        }
        if max_staleness_seconds:
            body["maxStalenessSeconds"] = max_staleness_seconds
        if database_name:
            body["databaseName"] = database_name
        if vnet_name:
            body["vNetName"] = vnet_name
        return self.request("POST", "/api/Mongo", body)

    def delete_mongo_cluster(self, cluster_id: str) -> None:
        self.request("DELETE", f"/api/Mongo/{cluster_id}")

    def mongo_connection(self, cluster_id: str) -> dict[str, Any]:
        """Connection string, with the cluster's consistency encoded into it."""
        return self.request("GET", f"/api/Mongo/{cluster_id}/connection")

    def mongo_command(self, cluster_id: str, command: str, database: str | None = None) -> dict[str, Any]:
        """Run a database command such as ``{"find": "orders", "limit": 10}``.

        This is the command protocol, not mongosh shell syntax.
        """
        return self.request("POST", f"/api/Mongo/{cluster_id}/command",
                            {"command": command, "database": database})

    def mongo_databases(self, cluster_id: str) -> list[dict[str, Any]]:
        return self.request("GET", f"/api/Mongo/{cluster_id}/databases") or []

    def mongo_collections(self, cluster_id: str, database: str) -> list[dict[str, Any]]:
        return self.request("GET", f"/api/Mongo/{cluster_id}/databases/{urllib.parse.quote(database)}/collections") or []

    def mongo_replica_status(self, cluster_id: str) -> list[dict[str, Any]]:
        """Live membership, so you see the member MongoDB actually elected primary."""
        return self.request("GET", f"/api/Mongo/{cluster_id}/replica-status") or []

    def set_mongo_consistency(self, cluster_id: str, consistency: str,
                              max_staleness_seconds: int | None = None) -> dict[str, Any]:
        body: dict[str, Any] = {"consistency": consistency}
        if max_staleness_seconds:
            body["maxStalenessSeconds"] = max_staleness_seconds
        return self.request("PUT", f"/api/Mongo/{cluster_id}/consistency", body)

    # ── YugabyteDB ──────────────────────────────────────────────────────────

    def yugabyte_clusters(self) -> list[dict[str, Any]]:
        return (self.request("GET", "/api/Yugabyte") or {}).get("data") or []

    def create_yugabyte_cluster(self, cluster_name: str, *, regions: list[str] | None = None,
                                sku: str = "small", engine_version: str | None = None,
                                database_name: str | None = None,
                                storage_gb: int = 20) -> dict[str, Any]:
        """Create a cluster. One node per region; replication factor follows the count
        and is kept odd, because a majority is what survives losing a node."""
        regions = regions or ["canada"]
        body: dict[str, Any] = {
            "clusterName": cluster_name, "regions": regions, "region": regions[0],
            "sku": sku, "storageGb": storage_gb,
        }
        if engine_version:
            body["engineVersion"] = engine_version
        if database_name:
            body["databaseName"] = database_name
        return (self.request("POST", "/api/Yugabyte", body) or {}).get("data")

    def delete_yugabyte_cluster(self, cluster_id: str) -> None:
        self.request("DELETE", f"/api/Yugabyte/{cluster_id}")

    def yugabyte_connection(self, cluster_id: str) -> dict[str, Any]:
        return (self.request("GET", f"/api/Yugabyte/{cluster_id}/connection") or {}).get("data")

    def yugabyte_query(self, cluster_id: str, sql: str, max_rows: int = 1000) -> dict[str, Any]:
        """Run SQL. Yugabyte speaks the PostgreSQL wire protocol, so any Postgres driver
        works too; this is for callers that would rather not open a socket."""
        return (self.request("POST", f"/api/Yugabyte/{cluster_id}/query",
                             {"sql": sql, "maxRows": max_rows}) or {}).get("data")

    def yugabyte_tables(self, cluster_id: str) -> list[dict[str, Any]]:
        return (self.request("GET", f"/api/Yugabyte/{cluster_id}/tables") or {}).get("data") or []

    # ── VPN Gateway ─────────────────────────────────────────────────────────

    def vpn_gateways(self) -> list[dict[str, Any]]:
        return (self.request("GET", "/api/VPNGateway/list") or {}).get("data") or []

    def create_vpn_gateway(self, name: str, *, region: str = "canada", gateway_type: int = 1,
                           vnet_id: str | None = None, vnet_name: str | None = None,
                           address_pool: str | None = None, protocol: str | None = None,
                           port: int | None = None, dns_servers: list[str] | None = None,
                           split_tunneling: bool = True) -> dict[str, Any]:
        """Create a gateway. ``gateway_type`` 0 is Site-to-Site (WireGuard), 1 is
        Point-to-Site (OpenVPN)."""
        body: dict[str, Any] = {
            "name": name, "region": region, "gatewayType": gateway_type,
            "splitTunneling": split_tunneling,
        }
        for key, val in (("vNetId", vnet_id), ("vNetName", vnet_name),
                         ("addressPool", address_pool), ("protocol", protocol)):
            if val:
                body[key] = val
        if port:
            body["port"] = port
        if dns_servers:
            body["dnsServers"] = dns_servers
        return (self.request("POST", "/api/VPNGateway/create", body) or {}).get("data")

    def delete_vpn_gateway(self, gateway_id: str, gateway_name: str, region: str | None = None) -> None:
        path = f"/api/VPNGateway/{gateway_id}?gatewayName={urllib.parse.quote(gateway_name)}"
        if region:
            path += f"&region={urllib.parse.quote(region)}"
        self.request("DELETE", path)

    def create_vpn_client(self, gateway_id: str, name: str, *, email: str | None = None,
                          region: str | None = None) -> dict[str, Any]:
        """Issue a Point-to-Site client certificate. Fetch the profile itself with
        ``vpn_client_config``."""
        path = "/api/VPNGateway/clients/p2s"
        if region:
            path += f"?region={urllib.parse.quote(region)}"
        body: dict[str, Any] = {"name": name, "gatewayId": gateway_id}
        if email:
            body["emailId"] = email
        return self.request("POST", path, body)

    def vpn_clients(self, gateway_id: str) -> list[dict[str, Any]]:
        return (self.request("GET", f"/api/VPNGateway/{gateway_id}/clients/p2s") or {}).get("data") or []

    def revoke_vpn_client(self, client_id: str, region: str | None = None) -> None:
        """Withdraw a client certificate. The record stays visible as revoked and its
        name stays taken, so the same identity cannot be reissued."""
        path = f"/api/VPNGateway/clients/p2s/{client_id}"
        if region:
            path += f"?region={urllib.parse.quote(region)}"
        self.request("DELETE", path)

    def billing(self) -> dict[str, Any]:
        return self.request("GET", "/api/cloudsubscription")
