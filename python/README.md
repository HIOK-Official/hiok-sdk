# hiok-cloud — HIOK Cloud SDK for Python

Every HIOK Cloud API operation (837 of them) plus a storage helper that moves files of any size.

```bash
pip install hiok-cloud
```

```python
import os
from hiok import HiokClient

client = HiokClient("https://hiokcloud.com", token=os.environ["HIOK_TOKEN"])
# or: HiokClient(endpoint).login(email, password), or storage_key=... for one storage account

accounts = client.api.storage_account.get_storage_accounts()["data"]
client.storage.upload_file(accounts[0]["id"], "backups", "2026/db.dump", "/var/backups/db.dump")
client.storage.download_file(accounts[0]["id"], "backups", "2026/db.dump", "/tmp/db.dump")
```

Uploads go in parallel 3 MB blocks, downloads in ranges, and both are sha256-verified.
GET requests are retried on 429/502/503/504; writes are never repeated.

Documentation: https://hiokcloud.com/docs · Source: https://github.com/HIOK-Official/hiok-sdk
