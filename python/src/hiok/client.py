"""Dependency-free HIOK Cloud REST client."""
from __future__ import annotations

import json
import urllib.error
import urllib.parse
import urllib.request
from typing import Any


class HiokError(RuntimeError):
    """An API request returned an error response."""


class HiokClient:
    def __init__(self, endpoint: str = "https://hiokcloud.com", token: str | None = None):
        self.endpoint = endpoint.rstrip("/")
        self.token = token

    def login(self, email: str, password: str) -> "HiokClient":
        payload = self.request("POST", "/api/OAuth/token", {"email": email, "password": password}, auth=False)
        token = payload.get("data", {}).get("token")
        if not token:
            raise HiokError(payload.get("message", "Sign-in failed"))
        self.token = token
        return self

    def request(self, method: str, path: str, body: Any = None, *, auth: bool = True) -> Any:
        data = None if body is None else json.dumps(body).encode()
        headers = {"Accept": "application/json"}
        if body is not None:
            headers["Content-Type"] = "application/json"
        if auth:
            if not self.token:
                raise HiokError("No token configured; call login() first")
            headers["Authorization"] = f"Bearer {self.token}"
        req = urllib.request.Request(self.endpoint + path, data=data, headers=headers, method=method)
        try:
            with urllib.request.urlopen(req, timeout=300) as response:
                raw = response.read()
                return json.loads(raw) if raw else None
        except urllib.error.HTTPError as exc:
            raw = exc.read().decode(errors="replace")
            raise HiokError(f"{method} {path} returned {exc.code}: {raw}") from exc

    def regions(self) -> list[dict[str, Any]]:
        return self.request("GET", "/api/storageaccount/regions", auth=False).get("data", [])

    def virtual_machines(self) -> list[dict[str, Any]]:
        return self.request("GET", "/api/VirtualMachine/list-vms-info").get("data", [])

    def create_virtual_machine(self, name: str, region: str = "south-india", image: str = "ubuntu-24.04", vcpus: int = 1, ram_gb: float = 1) -> Any:
        return self.request("POST", "/api/VirtualMachine/create-vm", {
            "vmName": name, "regions": [region], "sourceFilePath": image,
            "vcpuCount": vcpus, "ramSize": ram_gb,
        })

    def search(self, query: str) -> dict[str, Any]:
        return self.request("GET", "/api/search?q=" + urllib.parse.quote(query)).get("data", {})

    def hierarchy(self) -> dict[str, Any]:
        return self.request("GET", "/api/hierarchyview/full").get("data", {})

    def billing(self) -> dict[str, Any]:
        return self.request("GET", "/api/cloudsubscription")
