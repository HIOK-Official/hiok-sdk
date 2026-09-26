import hashlib, os, sys
HERE = os.path.dirname(os.path.abspath(__file__)); sys.path[:0] = [os.path.join(HERE, "../python/src"), os.path.join(HERE, "../examples/python")]
os.environ["B2_SIMULATE"] = "1"
import backblaze_sync as bs
from hiok import HiokClient
hiok = HiokClient(os.environ.get("HIOK_ENDPOINT", "https://hiokcloud.com"), token=os.environ["HIOK_TOKEN"])
acct = next(a for a in hiok.api.storage_account.get_storage_accounts()["data"] if a["name"] == os.environ["HIOK_TEST_STORAGE_ACCOUNT"])["id"]
b2 = bs.b2_api()
try:
    [hiok.storage.delete(acct, "b2-mirror", o["key"]) for o in hiok.storage.list(acct, "b2-mirror")]
except Exception: pass
bucket = b2.create_bucket("my-backups", "allPrivate")
files = {"backups/small.txt": b"hello backblaze", "backups/db/20mb.bin": os.urandom(20 * 1024 * 1024 + 99), "backups/report.csv": b"a,b\n1,2\n" * 5000}
for k, v in files.items(): bucket.upload_bytes(v, k)
print("seeded B2:", sorted(files))
print("PULL"); n = bs.pull(b2, hiok, "my-backups", "backups/", acct, "b2-mirror"); print("pulled", n)
for k, v in files.items():
    got = b"".join(hiok.storage.iter_download(acct, "b2-mirror", k))
    print(f"  HIOK has {k}: {'identical' if hashlib.sha256(got).digest() == hashlib.sha256(v).digest() else 'DIFFERENT'}")
print("RE-RUN (should skip all)"); print("pulled", bs.pull(b2, hiok, "my-backups", "backups/", acct, "b2-mirror"))
print("PUSH to prefix restored/ by copying objects under a new key")
for k in files: hiok.storage.upload_stream(acct, "b2-mirror", "restored/" + k, bs.HiokReader(hiok.storage.iter_download(acct, "b2-mirror", k)))
print("pushed", bs.push(b2, hiok, "my-backups", "restored/", acct, "b2-mirror"))
for k, v in files.items():
    import io as _io
    buf = _io.BytesIO(); bucket.download_file_by_name("restored/" + k).save(buf)
    print(f"  B2 has restored/{k}: downloaded back {'identical' if hashlib.sha256(buf.getvalue()).digest() == hashlib.sha256(v).digest() else 'DIFFERENT'}")
for o in hiok.storage.list(acct, "b2-mirror"): hiok.storage.delete(acct, "b2-mirror", o["key"])
hiok.api.storage_object.delete_container(acct, "b2-mirror", force=True); print("cleaned up")
