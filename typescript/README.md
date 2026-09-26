# @hiok/cloud — HIOK Cloud SDK for TypeScript and Node.js

Every HIOK Cloud API operation (906 of them) plus a storage helper that moves files of any size.

```bash
npm install @hiok/cloud
```

```ts
import { HiokClient } from '@hiok/cloud';

const client = new HiokClient({ endpoint: 'https://hiokcloud.com', token: process.env.HIOK_TOKEN });
// or: await client.login(email, password), or { storageKey } for one storage account

const { data: accounts } = await client.api.storageAccount.getStorageAccounts();
await client.storage.uploadFile(accounts[0].id, 'backups', '2026/db.dump', '/var/backups/db.dump');
await client.storage.downloadFile(accounts[0].id, 'backups', '2026/db.dump', '/tmp/db.dump');
```

Uploads go in parallel 3 MB blocks, downloads in ranges, and both are sha256-verified.
GET requests are retried on 429/502/503/504; writes are never repeated. Node 20+.

Documentation: https://hiokcloud.com/docs · Source: https://github.com/HIOK-Official/hiok-sdk
