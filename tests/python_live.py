import hashlib, io, os, sys, time
sys.path.insert(0, os.path.join(os.path.dirname(__file__), "../python/src"))
from hiok import HiokClient, HiokError
c = HiokClient(os.environ.get("HIOK_ENDPOINT", "https://test.hiokcloud.com"), token=os.environ["HIOK_TOKEN"])
missing = [m for m in "get_container create_container list_objects delete_object get_object put_object stage_block commit_block_list".split() if not hasattr(c.api.storage_object, m)]
print("storage_object methods missing:", missing)
groups = [g for g in vars(c.api)]; print("api groups:", len(groups))
print("key_vault.list ->", type(c.api.key_vault.list()).__name__)
print("regions ->", len(c.api.storage_account.get_available_regions()["data"]))
acct = next(a for a in c.api.storage_account.get_storage_accounts()["data"] if a["name"] == os.environ["HIOK_TEST_STORAGE_ACCOUNT"])["id"]
c.storage.ensure_container(acct, "sdk-test")
c.storage.upload_bytes(acct, "sdk-test", "small/hello.txt", b"hello from python sdk")
data = os.urandom(20 * 1024 * 1024 + 123)
t = time.time(); c.storage.upload_bytes(acct, "sdk-test", "big/20mb.bin", data); up = time.time() - t
t = time.time(); c.storage.download_file(acct, "sdk-test", "big/20mb.bin", "/tmp/hiok-sdk-test.bin"); down = time.time() - t
print(f"20MB upload {up:.1f}s download {down:.1f}s identical:", hashlib.sha256(open('/tmp/hiok-sdk-test.bin','rb').read()).digest() == hashlib.sha256(data).digest())
class Trickle(io.RawIOBase):          # a network-like stream with short reads
    def __init__(s, b): s.b, s.i = b, 0
    def readable(s): return True
    def read(s, n=-1):
        n = min(n if n > 0 else 65536, 65536, len(s.b) - s.i); out = s.b[s.i:s.i+n]; s.i += n; return out
c.storage.upload_stream(acct, "sdk-test", "big/streamed.bin", Trickle(data))
print("streamed upload identical:", hashlib.sha256(b"".join(c.storage.iter_download(acct, "sdk-test", "big/streamed.bin"))).digest() == hashlib.sha256(data).digest())
print("listing:", sorted(o["key"] for o in c.storage.list(acct, "sdk-test")))
key = c.api.storage_account.get_access_keys(acct)["data"]["key1"]
k = HiokClient(os.environ.get("HIOK_ENDPOINT", "https://test.hiokcloud.com"), storage_key=key)
print("storage-key read:", k.api.storage_object.get_object_content(acct, "sdk-test", "small/hello.txt"))
try: k.api.key_vault.list(); print("storage key reached Key Vault: BAD")
except HiokError as e: print("storage key refused elsewhere:", e.status)
for o in c.storage.list(acct, "sdk-test"): c.storage.delete(acct, "sdk-test", o["key"])
print("after delete:", c.storage.list(acct, "sdk-test"))
