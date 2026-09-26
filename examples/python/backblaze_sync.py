#!/usr/bin/env python3
"""
Copy files between Backblaze B2 and a HIOK storage account, in either direction.

    pip install hiok-cloud b2sdk

    export HIOK_ENDPOINT=https://hiokcloud.com
    export HIOK_STORAGE_KEY=...        # the storage account's access key (or HIOK_TOKEN)
    export B2_KEYID=... B2_APPKEY=...  # a Backblaze application key

    # Backblaze -> HIOK: everything under backups/ in bucket "my-backups" into container "b2-mirror"
    python backblaze_sync.py pull --bucket my-backups --prefix backups/ --account <account-id> --container b2-mirror

    # HIOK -> Backblaze
    python backblaze_sync.py push --bucket my-backups --prefix restored/ --account <account-id> --container b2-mirror

Files stream straight through in 3 MB pieces: nothing is written to local disk and
memory stays flat whatever the file size. Each copy is checked end to end with
sha256. Files already present with the same size are skipped, so a re-run resumes.
"""
from __future__ import annotations

import argparse
import hashlib
import io
import os
import sys

from b2sdk.v2 import B2Api, InMemoryAccountInfo

from hiok import HiokClient, HiokError

CHUNK = 3 * 1024 * 1024


def b2_api() -> B2Api:
    """Backblaze session. B2_SIMULATE=1 uses b2sdk's in-process simulator (for tests)."""
    info = InMemoryAccountInfo()
    if os.environ.get("B2_SIMULATE") == "1":
        from b2sdk.v2 import B2HttpApiConfig, RawSimulator
        api = B2Api(info, api_config=B2HttpApiConfig(_raw_api_class=RawSimulator))
        key_id, key = api.session.raw_api.create_account()
        api.authorize_account("production", key_id, key)
        return api
    api = B2Api(info)
    api.authorize_account("production", os.environ["B2_KEYID"], os.environ["B2_APPKEY"])
    return api


class HashingReader(io.RawIOBase):
    """Wraps a stream and hashes what passes through it (sha1 for B2, sha256 for the record)."""

    def __init__(self, inner):
        self.inner, self.sha1, self.sha256 = inner, hashlib.sha1(), hashlib.sha256()

    def readable(self):
        return True

    def readinto(self, target):
        data = self.inner.read(len(target))
        self.sha1.update(data)
        self.sha256.update(data)
        target[:len(data)] = data
        return len(data)


def _millis(iso: str | None) -> int:
    """An ISO-8601 time as epoch milliseconds (B2's timestamp unit); 0 when absent."""
    if not iso:
        return 0
    from datetime import datetime
    return int(datetime.fromisoformat(iso.replace("Z", "+00:00")).timestamp() * 1000)


def _current(hiok_obj: dict | None, size: int, b2_uploaded_ms: int) -> bool:
    """The HIOK copy is up to date: same size, and written after Backblaze's version."""
    return bool(hiok_obj) and hiok_obj.get("sizeBytes") == size and _millis(hiok_obj.get("updatedAt")) >= b2_uploaded_ms


def pull(b2: B2Api, hiok: HiokClient, bucket_name: str, prefix: str, account: str, container: str) -> int:
    """Backblaze -> HIOK."""
    import threading
    bucket = b2.get_bucket_by_name(bucket_name)
    hiok.storage.ensure_container(account, container)
    existing = {o["key"]: o for o in hiok.storage.list(account, container, prefix=prefix)}
    copied = 0
    for version, _ in bucket.ls(prefix, recursive=True):
        name, size = version.file_name, version.size
        if _current(existing.get(name), size, version.upload_timestamp):
            print(f"  skip  {name} (already there)")
            continue
        # b2sdk writes the download into one end of a pipe while HIOK's uploader reads
        # the other, so the file streams through without touching the disk.
        read_fd, write_fd = os.pipe()
        failure: list[BaseException] = []

        def fetch(name=name, write_fd=write_fd):
            with os.fdopen(write_fd, "wb") as sink:
                try:
                    bucket.download_file_by_name(name).save(sink)
                except BaseException as exc:          # surfaced after the upload
                    failure.append(exc)

        worker = threading.Thread(target=fetch, daemon=True)
        worker.start()
        with os.fdopen(read_fd, "rb") as pipe:
            source = HashingReader(pipe)
            hiok.storage.upload_stream(account, container, name, io.BufferedReader(source, CHUNK), size=size)
        worker.join()
        if failure:
            raise SystemExit(f"{name}: Backblaze download failed: {failure[0]}")
        # B2 keeps a sha1 of every file; matching it proves the bytes that reached HIOK
        # are the bytes Backblaze holds.
        expected = (version.content_sha1 or "").replace("unverified:", "")
        if expected and expected != "none" and expected != source.sha1.hexdigest():
            raise SystemExit(f"{name}: content changed in transit (sha1 {source.sha1.hexdigest()} != {expected})")
        print(f"  pull  {name}  {size:,} bytes  sha1 verified against Backblaze  sha256 {source.sha256.hexdigest()[:16]}")
        copied += 1
    return copied


class HiokReader(io.RawIOBase):
    """A readable stream over a HIOK object, fetched in 3 MB ranges as it is read."""

    def __init__(self, chunks):
        self.chunks, self.buffer, self.sha = chunks, b"", hashlib.sha256()

    def readable(self):
        return True

    def readinto(self, target):
        while not self.buffer:
            try:
                self.buffer = next(self.chunks)
                self.sha.update(self.buffer)
            except StopIteration:
                return 0
        n = min(len(target), len(self.buffer))
        target[:n], self.buffer = self.buffer[:n], self.buffer[n:]
        return n


def push(b2: B2Api, hiok: HiokClient, bucket_name: str, prefix: str, account: str, container: str) -> int:
    """HIOK -> Backblaze."""
    bucket = b2.get_bucket_by_name(bucket_name)
    remote = {v.file_name: v for v, _ in bucket.ls(prefix, recursive=True)}
    copied = 0
    for obj in hiok.storage.list(account, container, prefix=prefix):
        if obj.get("isDirectory"):
            continue
        name, size = obj["key"], obj["sizeBytes"]
        there = remote.get(name)
        if there is not None and there.size == size and there.upload_timestamp >= _millis(obj.get("updatedAt")):
            print(f"  skip  {name} (already there)")
            continue
        reader = HiokReader(hiok.storage.iter_download(account, container, name))
        # A one-pass stream: b2sdk buffers and uploads it in parts, so any size works
        # without reading the HIOK object twice.
        uploaded = bucket.upload_unbound_stream(io.BufferedReader(reader, CHUNK), name,
                                                recommended_upload_part_size=16 * 1024 * 1024)
        print(f"  push  {name}  {size:,} bytes  sha256 {reader.sha.hexdigest()[:16]}  b2 id {uploaded.id_[:12]}...")
        copied += 1
    return copied


def main() -> int:
    ap = argparse.ArgumentParser(description=__doc__, formatter_class=argparse.RawDescriptionHelpFormatter)
    ap.add_argument("direction", choices=["pull", "push"], help="pull: Backblaze -> HIOK, push: HIOK -> Backblaze")
    ap.add_argument("--bucket", required=True)
    ap.add_argument("--prefix", default="")
    ap.add_argument("--account", required=True, help="HIOK storage account id")
    ap.add_argument("--container", required=True, help="HIOK container or file share")
    args = ap.parse_args()

    hiok = HiokClient()      # HIOK_ENDPOINT + HIOK_TOKEN or HIOK_STORAGE_KEY
    b2 = b2_api()
    try:
        run = pull if args.direction == "pull" else push
        n = run(b2, hiok, args.bucket, args.prefix, args.account, args.container)
    except HiokError as exc:
        print(f"HIOK: {exc}", file=sys.stderr)
        return 1
    print(f"{n} file(s) copied")
    return 0


if __name__ == "__main__":
    sys.exit(main())
