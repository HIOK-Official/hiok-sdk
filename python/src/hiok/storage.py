"""Moving files in and out of HIOK storage accounts.

    client.storage.upload_file(account_id, "backups", "2026/db.dump", "/var/backups/db.dump")
    client.storage.download_file(account_id, "backups", "2026/db.dump", "/tmp/db.dump")

    # Stream from anywhere (another cloud, an HTTP response) without a temporary file:
    client.storage.upload_stream(account_id, "backups", "big.bin", response_stream)
    for chunk in client.storage.iter_download(account_id, "backups", "big.bin"):
        destination.write(chunk)

A write reaches the region in one message, which caps it at 3 MB, so anything
larger is sent as 3 MB blocks (in parallel) and committed as one object. Reads
of a large object are ranged in the same size, so memory use stays flat.
"""
from __future__ import annotations

import base64
import concurrent.futures
import hashlib
import io
import os
import uuid
from typing import TYPE_CHECKING, Any, BinaryIO, Callable, Iterator

if TYPE_CHECKING:
    from .client import HiokClient

BLOCK = 3 * 1024 * 1024
Progress = Callable[[int, int | None], None]   # (bytes done, total or None)


class StorageTransfer:
    def __init__(self, client: "HiokClient"):
        self._c = client

    # ── containers and listings ────────────────────────────────────────────

    def ensure_container(self, account_id: str, name: str, kind: str = "blob") -> dict[str, Any]:
        """The container, created if it does not exist. kind: blob, block, fileshare, filesystem."""
        from .client import HiokError
        try:
            return self._c.api.storage_object.get_container(account_id, name)["data"]
        except HiokError as exc:
            if exc.status != 404:
                raise
        return self._c.api.storage_object.create_container(account_id, {"name": name, "kind": kind})["data"]

    def list(self, account_id: str, container: str, prefix: str | None = None,
             path: str | None = None, limit: int = 5000) -> list[dict[str, Any]]:
        """Objects in a container: by key prefix, or one directory level with path=."""
        return self._c.api.storage_object.list_objects(
            account_id, container, prefix=prefix, path=path, limit=limit)["data"] or []

    def delete(self, account_id: str, container: str, key: str) -> None:
        self._c.api.storage_object.delete_object(account_id, container, key)

    def stat(self, account_id: str, container: str, key: str) -> dict[str, Any]:
        return self._c.api.storage_object.get_object(account_id, container, key)["data"]

    # ── upload ─────────────────────────────────────────────────────────────

    def upload_bytes(self, account_id: str, container: str, key: str, data: bytes,
                     content_type: str | None = None) -> dict[str, Any]:
        return self.upload_stream(account_id, container, key, io.BytesIO(data), content_type, size=len(data))

    def upload_file(self, account_id: str, container: str, key: str, source: str | os.PathLike | BinaryIO,
                    content_type: str | None = None, *, workers: int = 4,
                    progress: Progress | None = None) -> dict[str, Any]:
        """Upload a local file (path or open binary file). Returns the stored object."""
        if isinstance(source, (str, os.PathLike)):
            with open(source, "rb") as fh:
                return self.upload_stream(account_id, container, key, fh, content_type,
                                          size=os.fstat(fh.fileno()).st_size, workers=workers, progress=progress)
        return self.upload_stream(account_id, container, key, source, content_type, workers=workers, progress=progress)

    def upload_stream(self, account_id: str, container: str, key: str, stream: BinaryIO,
                      content_type: str | None = None, *, size: int | None = None, workers: int = 4,
                      progress: Progress | None = None) -> dict[str, Any]:
        """Upload from any readable binary stream, of known or unknown length."""
        first = _read_full(stream, BLOCK)
        if len(first) < BLOCK:
            result = self._c.api.storage_object.put_object(account_id, container, {
                "key": key, "content": base64.b64encode(first).decode(), "isBase64": True,
                "contentType": content_type,
            })
            if progress:
                progress(len(first), len(first))
            return result["data"]

        upload = uuid.uuid4().hex[:12]
        ids: list[str] = []
        done = 0

        def stage(index: int, chunk: bytes) -> int:
            block_id = f"sdk-{upload}-{index:06d}"
            self._c.api.storage_object.stage_block(account_id, container, {
                "blobName": key, "blockId": block_id,
                "content": base64.b64encode(chunk).decode(), "isBase64": True,
            })
            return len(chunk)

        with concurrent.futures.ThreadPoolExecutor(max_workers=max(1, workers)) as pool:
            pending: set[concurrent.futures.Future[int]] = set()
            chunk, index = first, 0
            while chunk:
                ids.append(f"sdk-{upload}-{index:06d}")
                pending.add(pool.submit(stage, index, chunk))
                index += 1
                # Bound memory: at most 2 x workers blocks in flight.
                if len(pending) >= 2 * max(1, workers):
                    finished, pending = concurrent.futures.wait(pending, return_when=concurrent.futures.FIRST_COMPLETED)
                    for f in finished:
                        done += f.result()
                        if progress:
                            progress(done, size)
                chunk = _read_full(stream, BLOCK)
            for f in concurrent.futures.as_completed(pending):
                done += f.result()
                if progress:
                    progress(done, size)

        result = self._c.api.storage_object.commit_block_list(account_id, container, {
            "blobName": key, "blockIds": ids, "contentType": content_type, "discardStagedBlocks": True,
        })
        return result["data"]

    # ── download ───────────────────────────────────────────────────────────

    def iter_download(self, account_id: str, container: str, key: str,
                      progress: Progress | None = None) -> Iterator[bytes]:
        """The object's bytes, in 3 MB pieces, fetched as they are consumed."""
        size = int(self.stat(account_id, container, key).get("sizeBytes") or 0)
        path = (f"/api/storageaccount/{self._c._seg(account_id)}/containers/{self._c._seg(container)}"
                f"/content/{self._c._seg(key, True)}")
        if size == 0:
            return
        done = 0
        while done < size:
            end = min(done + BLOCK, size) - 1
            chunk = self._c.request("GET", path, raw=True, headers={"Range": f"bytes={done}-{end}"})
            if not chunk:
                break
            done += len(chunk)
            if progress:
                progress(done, size)
            yield chunk

    def download_stream(self, account_id: str, container: str, key: str, destination: BinaryIO,
                        progress: Progress | None = None) -> int:
        written = 0
        for chunk in self.iter_download(account_id, container, key, progress):
            destination.write(chunk)
            written += len(chunk)
        return written

    def download_file(self, account_id: str, container: str, key: str, destination: str | os.PathLike,
                      progress: Progress | None = None, verify: bool = True) -> int:
        """Download to a file (written to a temporary name and moved into place).

        With verify=True the file's sha256 is checked against the one stored with the
        object, when the object has one."""
        target = os.fspath(destination)
        os.makedirs(os.path.dirname(os.path.abspath(target)), exist_ok=True)
        partial = target + ".partial"
        digest = hashlib.sha256()
        written = 0
        with open(partial, "wb") as fh:
            for chunk in self.iter_download(account_id, container, key, progress):
                fh.write(chunk)
                digest.update(chunk)
                written += len(chunk)
        if verify:
            expected = (self.stat(account_id, container, key).get("contentHash") or "").lower()
            if expected and len(expected) == 64 and expected != digest.hexdigest():
                os.remove(partial)
                from .client import HiokError
                raise HiokError(f"{key}: downloaded content does not match the stored sha256")
        os.replace(partial, target)
        return written


def _read_full(stream: BinaryIO, size: int) -> bytes:
    """Read exactly size bytes unless the stream ends first (network streams return short reads)."""
    parts: list[bytes] = []
    remaining = size
    while remaining > 0:
        chunk = stream.read(remaining)
        if not chunk:
            break
        parts.append(chunk)
        remaining -= len(chunk)
    return b"".join(parts)
