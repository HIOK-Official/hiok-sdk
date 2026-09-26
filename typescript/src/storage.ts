import type { HiokTransport } from './transport.js';

/** Largest single write; bigger content is sent as blocks of this size. */
export const BLOCK_SIZE = 3 * 1024 * 1024;

const toBase64 = (bytes: Uint8Array): string =>
  typeof Buffer !== 'undefined' ? Buffer.from(bytes).toString('base64')
    : btoa(Array.from(bytes, b => String.fromCharCode(b)).join(''));

/**
 * Moving files in and out of storage accounts.
 *
 *   await client.storage.uploadFile(accountId, 'backups', '2026/db.dump', '/var/backups/db.dump');
 *   await client.storage.downloadFile(accountId, 'backups', '2026/db.dump', '/tmp/db.dump');
 *   await client.storage.uploadStream(accountId, 'backups', 'big.bin', readableStream);
 *
 * A write reaches the region in one message, which caps it at 3 MB, so larger content
 * is staged as 3 MB blocks (several at once) and committed as one object; reads are
 * ranged the same way.
 */
export class StorageTransfer {
  constructor(private readonly c: HiokTransport) {}

  private base(accountId: string, container: string): string {
    return `/api/storageaccount/${this.c.segment(accountId)}/containers/${this.c.segment(container)}`;
  }

  async ensureContainer(accountId: string, name: string, kind = 'blob'): Promise<any> {
    try {
      return (await this.c.call('GET', this.base(accountId, name)))?.data;
    } catch (e: any) {
      if (e?.status !== 404) throw e;
    }
    return (await this.c.call('POST', `/api/storageaccount/${this.c.segment(accountId)}/containers`, { name, kind }))?.data;
  }

  async list(accountId: string, container: string, options: { prefix?: string; path?: string } = {}): Promise<any[]> {
    return (await this.c.call('GET', `${this.base(accountId, container)}/objects`, undefined,
      { prefix: options.prefix, path: options.path, limit: 5000 }))?.data ?? [];
  }

  async stat(accountId: string, container: string, key: string): Promise<any> {
    return (await this.c.call('GET', `${this.base(accountId, container)}/objects/${this.c.segment(key, true)}`))?.data;
  }

  async delete(accountId: string, container: string, key: string): Promise<void> {
    await this.c.call('DELETE', `${this.base(accountId, container)}/objects/${this.c.segment(key, true)}`);
  }

  /** Uploads bytes, a Blob, or any async iterable / ReadableStream of chunks (e.g. a fetch() body). */
  async upload(accountId: string, container: string, key: string,
               source: Uint8Array | Blob | AsyncIterable<Uint8Array> | ReadableStream<Uint8Array>,
               options: { contentType?: string; parallelism?: number; onProgress?: (done: number) => void } = {}): Promise<any> {
    const blocks = rechunk(toChunks(source));
    const first = await blocks.next();
    const firstBlock = first.done ? new Uint8Array(0) : first.value;
    if (firstBlock.length < BLOCK_SIZE) {
      const r = await this.c.call('PUT', `${this.base(accountId, container)}/objects`,
        { key, content: toBase64(firstBlock), isBase64: true, contentType: options.contentType });
      options.onProgress?.(firstBlock.length);
      return r?.data;
    }

    const upload = crypto.randomUUID().replace(/-/g, '').slice(0, 12);
    const ids: string[] = [];
    const running = new Set<Promise<void>>();
    const limit = Math.max(1, options.parallelism ?? 4);
    let done = 0;
    const stage = (id: string, bytes: Uint8Array) => this.c.call('PUT', `${this.base(accountId, container)}/blocks`,
      { blobName: key, blockId: id, content: toBase64(bytes), isBase64: true })
      .then(() => { done += bytes.length; options.onProgress?.(done); });

    let block: Uint8Array | undefined = firstBlock;
    while (block && block.length > 0) {
      const id = `sdk-${upload}-${String(ids.length).padStart(6, '0')}`;
      ids.push(id);
      const p: Promise<void> = stage(id, block).finally(() => running.delete(p));
      running.add(p);
      if (running.size >= limit) await Promise.race(running);
      const next = await blocks.next();
      block = next.done ? undefined : next.value;
    }
    await Promise.all(running);
    return (await this.c.call('POST', `${this.base(accountId, container)}/blocks/commit`,
      { blobName: key, blockIds: ids, contentType: options.contentType, discardStagedBlocks: true }))?.data;
  }

  /** Node.js: upload a local file. */
  async uploadFile(accountId: string, container: string, key: string, localPath: string,
                   options: { contentType?: string; onProgress?: (done: number) => void } = {}): Promise<any> {
    const { createReadStream } = await import('node:fs');
    return this.upload(accountId, container, key, createReadStream(localPath) as AsyncIterable<Uint8Array>, options);
  }

  /** The object's bytes in 3 MB pieces, fetched as they are consumed. */
  async *download(accountId: string, container: string, key: string): AsyncGenerator<Uint8Array> {
    const size = Number((await this.stat(accountId, container, key))?.sizeBytes ?? 0);
    const path = `${this.base(accountId, container)}/content/${this.c.segment(key, true)}`;
    for (let at = 0; at < size;) {
      const end = Math.min(at + BLOCK_SIZE, size) - 1;
      const chunk = await this.c.callRaw('GET', path, undefined, undefined, { Range: `bytes=${at}-${end}` });
      if (chunk.length === 0) break;
      at += chunk.length;
      yield chunk;
    }
  }

  /** Node.js: download to a local file through a temporary name. */
  async downloadFile(accountId: string, container: string, key: string, localPath: string): Promise<number> {
    const fs = await import('node:fs');
    const partial = `${localPath}.partial`;
    const out = fs.createWriteStream(partial);
    let written = 0;
    for await (const chunk of this.download(accountId, container, key)) {
      if (!out.write(chunk)) await new Promise<void>(r => out.once('drain', () => r()));
      written += chunk.length;
    }
    await new Promise<void>((resolve, reject) => out.end((e?: Error | null) => (e ? reject(e) : resolve())));
    fs.renameSync(partial, localPath);
    return written;
  }
}

async function* toChunks(source: Uint8Array | Blob | AsyncIterable<Uint8Array> | ReadableStream<Uint8Array>): AsyncGenerator<Uint8Array> {
  if (source instanceof Uint8Array) { yield source; return; }
  if (typeof Blob !== 'undefined' && source instanceof Blob) { yield new Uint8Array(await source.arrayBuffer()); return; }
  if (typeof (source as ReadableStream).getReader === 'function') {
    const reader = (source as ReadableStream<Uint8Array>).getReader();
    for (;;) { const { done, value } = await reader.read(); if (done) return; yield value; }
  }
  for await (const chunk of source as AsyncIterable<Uint8Array>) yield chunk;
}

/** Regroup arbitrary chunks into BLOCK_SIZE blocks (the last may be shorter). */
async function* rechunk(chunks: AsyncGenerator<Uint8Array>): AsyncGenerator<Uint8Array> {
  let buffer = new Uint8Array(BLOCK_SIZE);
  let filled = 0;
  for await (const chunk of chunks) {
    let offset = 0;
    while (offset < chunk.length) {
      const n = Math.min(BLOCK_SIZE - filled, chunk.length - offset);
      buffer.set(chunk.subarray(offset, offset + n), filled);
      filled += n; offset += n;
      if (filled === BLOCK_SIZE) { yield buffer; buffer = new Uint8Array(BLOCK_SIZE); filled = 0; }
    }
  }
  if (filled > 0) yield buffer.subarray(0, filled);
}
