import { Api } from './generated.js';
import type { FilePart, HiokTransport } from './transport.js';
import { StorageTransfer } from './storage.js';

export type { FilePart, HiokTransport } from './transport.js';
export { StorageTransfer } from './storage.js';
export { Api } from './generated.js';

/** An API request returned an error: `status` is the HTTP status, `body` the API's reply. */
export class HiokError extends Error {
  constructor(message: string, readonly status?: number, readonly body?: unknown) { super(message); }
}

export interface HiokClientOptions {
  /** Base URL, e.g. https://test.hiokcloud.com (default: $HIOK_ENDPOINT or https://hiokcloud.com). */
  endpoint?: string;
  /** Bearer token (default: $HIOK_TOKEN). */
  token?: string;
  /** A storage account access key: that account's data only (default: $HIOK_STORAGE_KEY). */
  storageKey?: string;
  /** Attempts for a GET that meets 429/502/503/504 (default 4). */
  retries?: number;
  fetch?: typeof globalThis.fetch;
}

const env = (name: string): string | undefined =>
  typeof process !== 'undefined' ? process.env?.[name] : undefined;

const RETRY = new Set([429, 502, 503, 504]);

export class HiokClient implements HiokTransport {
  readonly endpoint: string;
  private token?: string;
  private storageKey?: string;
  private readonly retries: number;
  private readonly fetcher: typeof globalThis.fetch;
  /** Every API operation, grouped as the API groups them: `client.api.keyVault.list()`. */
  readonly api: Api;
  /** Large-file upload and download for storage accounts. */
  readonly storage: StorageTransfer;

  constructor(options: HiokClientOptions = {}) {
    this.endpoint = (options.endpoint ?? env('HIOK_ENDPOINT') ?? 'https://hiokcloud.com').replace(/\/$/, '');
    this.token = options.token ?? env('HIOK_TOKEN');
    this.storageKey = options.storageKey ?? env('HIOK_STORAGE_KEY');
    this.retries = options.retries ?? 4;
    this.fetcher = options.fetch ?? globalThis.fetch.bind(globalThis);
    this.api = new Api(this);
    this.storage = new StorageTransfer(this);
  }

  async login(email: string, password: string): Promise<this> {
    const response = await this.request<any>('POST', '/api/OAuth/token', { email, password }, false);
    const token = response?.data?.token;
    if (!token) throw new HiokError(response?.message ?? 'Sign-in failed');
    this.token = token;
    return this;
  }

  setToken(token: string): this { this.token = token; return this; }
  setStorageKey(key: string): this { this.storageKey = key; return this; }

  segment(value: string, slashed = false): string {
    return slashed ? String(value).split('/').map(encodeURIComponent).join('/') : encodeURIComponent(String(value));
  }

  private query(query?: Record<string, unknown>): string {
    if (!query) return '';
    const params = new URLSearchParams();
    for (const [key, value] of Object.entries(query)) {
      if (value === undefined || value === null) continue;
      for (const v of Array.isArray(value) ? value : [value]) {
        if (v !== undefined && v !== null) params.append(key, v instanceof Date ? v.toISOString() : String(v));
      }
    }
    const text = params.toString();
    return text ? `?${text}` : '';
  }

  private credentials(auth: boolean): Record<string, string> {
    if (!auth) return {};
    if (this.token) return { Authorization: `Bearer ${this.token}` };
    if (this.storageKey) return { 'x-hiok-storage-key': this.storageKey };
    throw new HiokError('No credentials: pass token or storageKey, or call login() first');
  }

  private async send(method: string, path: string, init: { body?: BodyInit; headers?: Record<string, string> },
                     query: Record<string, unknown> | undefined, auth: boolean): Promise<Response> {
    const safe = method === 'GET' || method === 'HEAD' || method === 'OPTIONS';
    const attempts = safe ? this.retries + 1 : 1;
    for (let attempt = 0; ; attempt++) {
      let response: Response;
      try {
        response = await this.fetcher(this.endpoint + path + this.query(query), {
          method,
          headers: { Accept: 'application/json', ...this.credentials(auth), ...(init.headers ?? {}) },
          body: init.body,
        });
      } catch (error) {
        if (attempt + 1 < attempts) { await new Promise(r => setTimeout(r, Math.min(16, 2 ** attempt) * 1000)); continue; }
        throw new HiokError(`${method} ${path} failed: ${(error as Error).message}`);
      }
      if (response.ok) return response;
      if (RETRY.has(response.status) && attempt + 1 < attempts) {
        await new Promise(r => setTimeout(r, Math.min(16, 2 ** attempt) * 1000));
        continue;
      }
      const text = await response.text();
      let body: any = text;
      try { body = text ? JSON.parse(text) : undefined; } catch { /* not JSON */ }
      const message = (body && typeof body === 'object' ? body.message ?? body.Message : undefined) ?? text;
      throw new HiokError(`${method} ${path} returned ${response.status}: ${message}`, response.status, body);
    }
  }

  private static async parse(response: Response): Promise<any> {
    const text = await response.text();
    if (!text) return undefined;
    try { return JSON.parse(text); } catch { return text; }
  }

  async call(method: string, path: string, body?: unknown, query?: Record<string, unknown>): Promise<any> {
    const init = body === undefined ? {} : { body: JSON.stringify(body), headers: { 'Content-Type': 'application/json' } };
    return HiokClient.parse(await this.send(method, path, init, query, true));
  }

  async callRaw(method: string, path: string, body?: unknown, query?: Record<string, unknown>,
                headers?: Record<string, string>): Promise<Uint8Array> {
    const init = body === undefined ? { headers } :
      body instanceof Uint8Array ? { body: body as BodyInit, headers } :
      { body: JSON.stringify(body), headers: { 'Content-Type': 'application/json', ...(headers ?? {}) } };
    const response = await this.send(method, path, init, query, true);
    return new Uint8Array(await response.arrayBuffer());
  }

  async callMultipart(method: string, path: string, form: Record<string, string>, files: Record<string, FilePart>,
                      query?: Record<string, unknown>): Promise<any> {
    const data = new FormData();
    for (const [k, v] of Object.entries(form ?? {})) data.append(k, v);
    for (const [k, f] of Object.entries(files ?? {})) data.append(k, new Blob([f.content as BlobPart]), f.fileName);
    return HiokClient.parse(await this.send(method, path, { body: data }, query, true));
  }

  /** Kept for existing code: a JSON request; `auth=false` sends no credentials. */
  async request<T>(method: string, path: string, body?: unknown, auth = true): Promise<T> {
    const init = body === undefined ? {} : { body: JSON.stringify(body), headers: { 'Content-Type': 'application/json' } };
    return HiokClient.parse(await this.send(method, path, init, undefined, auth)) as Promise<T>;
  }

  async regions(): Promise<any[]> {
    return (await this.request<any>('GET', '/api/storageaccount/regions', undefined, false))?.data ?? [];
  }

  async virtualMachines(): Promise<any[]> {
    return (await this.request<any>('GET', '/api/VirtualMachine/list-vms-info'))?.data ?? [];
  }

  createVirtualMachine(name: string, options: {region?: string; image?: string; vcpus?: number; ramGb?: number} = {}): Promise<any> {
    return this.request('POST', '/api/VirtualMachine/create-vm', {
      vmName: name,
      regions: [options.region ?? 'canada'],
      sourceFilePath: options.image ?? 'ubuntu-24.04',
      vcpuCount: options.vcpus ?? 1,
      ramSize: options.ramGb ?? 1,
    });
  }

  async search(query: string): Promise<any> {
    return (await this.request<any>('GET', `/api/search?q=${encodeURIComponent(query)}`))?.data ?? {};
  }

  async hierarchy(): Promise<any> {
    return (await this.request<any>('GET', '/api/hierarchyview/full'))?.data ?? {};
  }

  billing(): Promise<any> { return this.request('GET', '/api/cloudsubscription'); }

  // ── Service Bus ───────────────────────────────────────────────────────

  serviceBusNamespaces(): Promise<any> { return this.request('GET', '/api/ServiceBus/namespaces'); }

  createServiceBusNamespace(name: string, options: {region?: string; sku?: string} = {}): Promise<any> {
    return this.request('POST', '/api/ServiceBus/namespaces', {
      name, product: 'servicebus',
      primaryRegion: options.region ?? 'canada',
      sku: options.sku ?? 'standard',
    });
  }

  createQueue(namespaceId: string, name: string, options: {maxDeliveryCount?: number; requiresSession?: boolean; deadLettering?: boolean} = {}): Promise<any> {
    return this.request('POST', `/api/ServiceBus/namespaces/${namespaceId}/queues`, {
      name,
      maxDeliveryCount: options.maxDeliveryCount ?? 10,
      requiresSession: options.requiresSession ?? false,
      deadLetteringEnabled: options.deadLettering ?? true,
    });
  }

  /** Send one message. scheduledEnqueueTime holds it until that instant. */
  sendMessage(namespaceId: string, entity: string, body: string, options: {subject?: string; sessionId?: string; scheduledEnqueueTime?: string} = {}): Promise<any> {
    return this.request('POST', `/api/ServiceBus/namespaces/${namespaceId}/entities/${entity}/messages`, {
      body, ...options,
    });
  }

  /** Receive messages. In peek_lock they stay locked until settled. */
  receiveMessages(namespaceId: string, entity: string, options: {subscription?: string; maxMessages?: number; mode?: string} = {}): Promise<any> {
    const q = options.subscription ? `?subscription=${encodeURIComponent(options.subscription)}` : '';
    return this.request('POST', `/api/ServiceBus/namespaces/${namespaceId}/entities/${entity}/messages/receive${q}`, {
      maxMessages: options.maxMessages ?? 1,
      receiveMode: options.mode ?? 'peek_lock',
    });
  }

  /** Settle a delivery: complete, abandon, deadletter or defer. */
  settleMessages(namespaceId: string, entity: string, lockTokens: string[], disposition = 'complete', options: {subscription?: string; reason?: string} = {}): Promise<any> {
    const q = options.subscription ? `?subscription=${encodeURIComponent(options.subscription)}` : '';
    return this.request('POST', `/api/ServiceBus/namespaces/${namespaceId}/entities/${entity}/messages/settle${q}`, {
      lockTokens, disposition, deadLetterReason: options.reason,
    });
  }

  deadLetterMessages(namespaceId: string, entity: string, options: {subscription?: string; maxMessages?: number} = {}): Promise<any> {
    const sub = options.subscription ? `&subscription=${encodeURIComponent(options.subscription)}` : '';
    return this.request('POST', `/api/ServiceBus/namespaces/${namespaceId}/entities/${entity}/deadletter/receive?maxMessages=${options.maxMessages ?? 10}${sub}`, {});
  }

  // ── Event Mesh ────────────────────────────────────────────────────────

  eventStreams(namespaceId: string): Promise<any> {
    return this.request('GET', `/api/Pulse/namespaces/${namespaceId}/streams`);
  }

  createEventStream(namespaceId: string, name: string, options: {partitions?: number; retentionHours?: number} = {}): Promise<any> {
    return this.request('POST', `/api/Pulse/namespaces/${namespaceId}/streams`, {
      name,
      partitionCount: options.partitions ?? 4,
      retentionHours: options.retentionHours ?? 168,
    });
  }

  /** Publish events. Each is {type, subject, data}. */
  publishEvents(namespaceId: string, stream: string, events: Array<Record<string, any>>): Promise<any> {
    return this.request('POST', `/api/Pulse/namespaces/${namespaceId}/streams/${stream}/events`, {events});
  }

  /** Read through a consumer group, advancing its own cursor. */
  readEvents(namespaceId: string, stream: string, consumerGroup: string, maxEvents = 10): Promise<any> {
    return this.request('POST', `/api/Pulse/namespaces/${namespaceId}/streams/${stream}/events/read?consumerGroup=${encodeURIComponent(consumerGroup)}&maxEvents=${maxEvents}`, {});
  }

  /** Route matching events to a webhook, with retry and dead-lettering. */
  createEventSubscription(namespaceId: string, stream: string, name: string, webhookUrl: string, options: {eventTypes?: string[]; advancedFilters?: Array<Record<string, any>>} = {}): Promise<any> {
    return this.request('POST', `/api/Pulse/namespaces/${namespaceId}/streams/${stream}/subscriptions`, {
      name, handlerType: 'webhook', handlerConfig: {url: webhookUrl}, eventFormat: 'cloudevents',
      includedEventTypes: options.eventTypes, advancedFilters: options.advancedFilters,
    });
  }

  // ── Communication ─────────────────────────────────────────────────────

  communicationServices(): Promise<any> { return this.request('GET', '/api/Communication/services'); }

  /** Send mail. Omit `from` to use the domain's default sender. */
  sendEmail(serviceId: string, to: string[], subject: string, options: {text?: string; html?: string; from?: string} = {}): Promise<any> {
    return this.request('POST', `/api/Communication/services/${serviceId}/emails`, {
      to, subject, textBody: options.text, htmlBody: options.html, from: options.from,
    });
  }

  // ── Bastion ───────────────────────────────────────────────────────────

  bastions(): Promise<any> { return this.request('GET', '/api/Bastion'); }

  /** Open a browser session; returns the portal URL and a short-lived signed token. */
  startBastionSession(bastionId: string, options: {targetVmId?: string; targetAddress?: string; protocol?: string; username?: string; password?: string; ttlMinutes?: number} = {}): Promise<any> {
    return this.request('POST', `/api/Bastion/${bastionId}/sessions`, {
      protocol: options.protocol ?? 'rdp',
      ttlMinutes: options.ttlMinutes ?? 60,
      ...options,
    });
  }

  // ── Analytics (managed ClickHouse) ────────────────────────────────────

  analyticsClusters(): Promise<any> { return this.request('GET', '/api/Analytics'); }

  /**
   * Provision a cluster. `sku` is dev, small, medium or large.
   * Pass vnetName and vnetAddress (CIDR) to give it an interface on a virtual
   * network, so machines there reach it privately.
   */
  createAnalyticsCluster(clusterName: string, options: {region?: string; sku?: string; storageGb?: number; databaseName?: string; adminUsername?: string; engineVersion?: string; vnetName?: string; vnetAddress?: string} = {}): Promise<any> {
    return this.request('POST', '/api/Analytics', {
      clusterName,
      sku: options.sku ?? 'small',
      storageGb: options.storageGb ?? 100,
      databaseName: options.databaseName ?? 'default',
      adminUsername: options.adminUsername ?? 'hiokadmin',
      engineVersion: options.engineVersion ?? '24.8-alpine',
      region: options.region,
      vnetName: options.vnetName,
      vnetAddress: options.vnetAddress,
    });
  }

  deleteAnalyticsCluster(clusterId: string): Promise<any> {
    return this.request('DELETE', `/api/Analytics/${clusterId}`);
  }

  startAnalyticsCluster(clusterId: string): Promise<any> {
    return this.request('POST', `/api/Analytics/${clusterId}/start`, {});
  }

  stopAnalyticsCluster(clusterId: string): Promise<any> {
    return this.request('POST', `/api/Analytics/${clusterId}/stop`, {});
  }

  /** Connection details including the password. */
  analyticsConnection(clusterId: string): Promise<any> {
    return this.request('GET', `/api/Analytics/${clusterId}/connection`);
  }

  analyticsTables(clusterId: string): Promise<any> {
    return this.request('GET', `/api/Analytics/${clusterId}/tables`);
  }

  /**
   * Run SQL. Returns columns, rows, timing and bytes read. Check `isSuccess`:
   * a failing statement returns the engine's diagnostic in `error` rather than throwing.
   */
  analyticsQuery(clusterId: string, sql: string, maxRows = 1000): Promise<any> {
    return this.request('POST', `/api/Analytics/${clusterId}/query`, {sql, maxRows});
  }

  setAnalyticsVNet(clusterId: string, attach: boolean): Promise<any> {
    return this.request('POST', `/api/Analytics/${clusterId}/vnet/${attach ? 'attach' : 'detach'}`, {});
  }

  // ── Live streaming ────────────────────────────────────────────────────

  /** Each item carries the endpoint plus its ingest and playback URLs. */
  streamingEndpoints(): Promise<any> { return this.request('GET', '/api/streaming'); }

  /** Create an endpoint. `kind` is camera, video or content. */
  createStreamingEndpoint(name: string, options: {region?: string; kind?: string} = {}): Promise<any> {
    return this.request('POST', '/api/streaming', {
      name, kind: options.kind ?? 'camera', region: options.region,
    });
  }

  deleteStreamingEndpoint(endpointId: string): Promise<any> {
    return this.request('DELETE', `/api/streaming/${endpointId}`);
  }

  // ── Public IP addresses ───────────────────────────────────────────────
  //
  // A region routes a whole IPv6 prefix, so every VM and container can hold a real
  // public address from it. IPv4 is a single provider address that IS the host, so
  // that pool is marked not assignable and the API says so rather than returning
  // nothing.
  //
  // These routes need the "infrastructure" backoffice grant: they hand out provider
  // address space, not ordinary tenant resources.

  /** Address ranges the platform can hand out. A range with `assignable: false` carries the reason in `notes`. */
  ipPools(region?: string): Promise<any> {
    const query = region ? `?region=${encodeURIComponent(region)}` : '';
    return this.request('GET', `/api/Infrastructure/ip-pools${query}`);
  }

  /** Addresses currently held. Released ones are kept for the record and only returned on request. */
  ipAllocations(options: {region?: string; includeReleased?: boolean} = {}): Promise<any> {
    const query = new URLSearchParams();
    if (options.region) query.set('region', options.region);
    if (options.includeReleased) query.set('includeReleased', 'true');
    const suffix = query.toString() ? `?${query}` : '';
    return this.request('GET', `/api/Infrastructure/ip-allocations${suffix}`);
  }

  /**
   * Take the next free address and, when a target is named, configure the host so it
   * actually reaches the guest.
   *
   * `targetContainer` is the name the HOST knows the guest by — the Docker container
   * name, or the libvirt domain, which for a VM is `<guid>#<name>`. Omit it to
   * reserve an address without configuring anything.
   *
   * `hostname` publishes DNS: a bare label lands in the managed zone. Reverse DNS is
   * published too unless `setReverseDns` is false — the provider forward-confirms, so
   * the forward record has to exist first, which is why the API publishes it first.
   */
  allocateIp(options: {
    region?: string;
    family?: number;
    resourceKind?: string;
    resourceId?: string;
    resourceName?: string;
    targetContainer?: string;
    targetKind?: 'container' | 'vm';
    hostname?: string;
    setReverseDns?: boolean;
  } = {}): Promise<any> {
    return this.request('POST', '/api/Infrastructure/ip-allocations', {
      family: 6,
      targetKind: 'container',
      ...options,
    });
  }

  /** Give an address back. Omit `targetContainer` to use the target recorded at allocation time. */
  releaseIp(allocationId: string, targetContainer?: string): Promise<any> {
    const query = targetContainer ? `?targetContainer=${encodeURIComponent(targetContainer)}` : '';
    return this.request('DELETE', `/api/Infrastructure/ip-allocations/${allocationId}${query}`);
  }

  /**
   * Re-apply every live allocation on the hosts that carry them.
   *
   * Host routes and NDP proxy entries do not survive a reboot, so something has to
   * put them back. The platform does this on a timer; call this when you already know
   * a host has just come back and do not want to wait for the next pass.
   */
  reconcileIps(region?: string): Promise<any> {
    const query = region ? `?region=${encodeURIComponent(region)}` : '';
    return this.request('POST', `/api/Infrastructure/ip-allocations/reconcile${query}`, {});
  }

  // ── Key Vault ─────────────────────────────────────────────────────────────

  keyVaults(): Promise<any[]> { return this.request('GET', '/api/KeyVault'); }

  /** The recovery bin: vaults still inside their retention window. */
  deletedKeyVaults(): Promise<any[]> { return this.request('GET', '/api/KeyVault/deleted'); }

  /**
   * Create a vault. Leave `vnetId` unset for one reachable wherever the caller can
   * authenticate; set it to additionally require the request to come from that
   * network — both are the same plan.
   *
   * `purgeProtection` can be switched on later but never off, which is what stops
   * someone who reaches the vault from disabling it and purging.
   */
  createKeyVault(input: {
    name: string; primaryRegion?: string; regions?: string[];
    vnetId?: string; vnetName?: string; allowedCidrs?: string[];
    softDeleteRetentionDays?: number; purgeProtection?: boolean;
  }): Promise<any> {
    return this.request('POST', '/api/KeyVault', input);
  }

  /** Soft delete. Contents stay recoverable until the retention window ends. */
  deleteKeyVault(vaultId: string): Promise<void> {
    return this.request('DELETE', `/api/KeyVault/${vaultId}`);
  }

  recoverKeyVault(vaultId: string): Promise<any> {
    return this.request('POST', `/api/KeyVault/${vaultId}/recover`, {});
  }

  /** Irreversible, and refused while purge protection holds. */
  purgeKeyVault(vaultId: string): Promise<void> {
    return this.request('DELETE', `/api/KeyVault/${vaultId}/purge`);
  }

  /** Item metadata. Values are never included — use `getSecret`. */
  keyVaultItems(vaultId: string, itemType?: string, includeDeleted = false): Promise<any[]> {
    const query: string[] = [];
    if (itemType) query.push(`itemType=${encodeURIComponent(itemType)}`);
    if (includeDeleted) query.push('includeDeleted=true');
    return this.request('GET', `/api/KeyVault/${vaultId}/items${query.length ? '?' + query.join('&') : ''}`);
  }

  /**
   * Write an item. A name that already exists gets a new **version** rather than an
   * overwrite, so the previous value stays retrievable.
   */
  setSecret(vaultId: string, input: {
    name: string; value?: string; itemType?: string; contentType?: string;
    expiresOn?: string; notBefore?: string; tags?: Record<string, string>;
    generate?: boolean; size?: number;
  }): Promise<any> {
    return this.request('POST', `/api/KeyVault/${vaultId}/items`, input);
  }

  /**
   * Read one item's value — the only call that discloses one, which is why it is
   * separate from listing. A disabled, expired or not-yet-valid item returns none.
   */
  getSecret(vaultId: string, name: string, version?: string): Promise<any> {
    const query = version ? `?version=${encodeURIComponent(version)}` : '';
    return this.request('GET', `/api/KeyVault/${vaultId}/items/${encodeURIComponent(name)}${query}`);
  }

  secretVersions(vaultId: string, name: string): Promise<any[]> {
    return this.request('GET', `/api/KeyVault/${vaultId}/items/${encodeURIComponent(name)}/versions`);
  }

  /** Soft-deletes every version, so a deleted secret cannot be read by asking for an older one. */
  deleteSecret(vaultId: string, name: string): Promise<void> {
    return this.request('DELETE', `/api/KeyVault/${vaultId}/items/${encodeURIComponent(name)}`);
  }

  recoverSecret(vaultId: string, name: string): Promise<any> {
    return this.request('POST', `/api/KeyVault/${vaultId}/items/${encodeURIComponent(name)}/recover`, {});
  }

  /**
   * Create a certificate.
   *
   * - `self-signed` generates a key pair and signs it; nothing vouches for the result.
   * - `csr` generates a key pair and returns a signing request. The private key never
   *   leaves the vault, so the authority signs something it cannot impersonate; the
   *   item stays pending and unusable until `mergeCertificate`.
   * - `import` stores existing PEM, or base64 PKCS#12 with its password.
   */
  createCertificate(vaultId: string, input: {
    name: string; action?: 'self-signed' | 'csr' | 'import';
    subject?: string; subjectAlternativeNames?: string[];
    keySize?: number; validityDays?: number;
    content?: string; password?: string; tags?: Record<string, string>;
  }): Promise<any> {
    return this.request('POST', `/api/KeyVault/${vaultId}/certificates`, input);
  }

  /**
   * Pair an authority-signed certificate with the key held for its request. One issued
   * for a different key is refused — the pair could not complete a handshake, and that
   * would only surface in production.
   */
  mergeCertificate(vaultId: string, name: string, signedCertificate: string): Promise<any> {
    return this.request('POST', `/api/KeyVault/${vaultId}/certificates/${encodeURIComponent(name)}/merge`,
      { signedCertificate });
  }

  /**
   * Export as PEM text or base64 PKCS#12. A PKCS#12 always carries the private key, so
   * give it a password: anyone holding the file holds the identity.
   */
  exportCertificate(vaultId: string, name: string, input: {
    format?: 'pem' | 'pfx'; password?: string; includePrivateKey?: boolean;
  } = {}): Promise<any> {
    return this.request('POST', `/api/KeyVault/${vaultId}/certificates/${encodeURIComponent(name)}/export`, input);
  }

  // ── MongoDB ───────────────────────────────────────────────────────────────

  mongoClusters(): Promise<any[]> { return this.request('GET', '/api/Mongo'); }

  /**
   * Create a cluster. One region gives a single node; several give a replica set.
   *
   * `consistency` is not a label: it sets the read concern, write concern and read
   * preference in the connection string, so it governs your driver. `bounded` and
   * `eventual` read from secondaries and are refused on a single-region cluster.
   */
  createMongoCluster(input: {
    clusterName: string; regions?: string[]; region?: string;
    consistency?: 'strong' | 'session' | 'bounded' | 'eventual';
    maxStalenessSeconds?: number; engineVersion?: string; sku?: string;
    storageGb?: number; databaseName?: string; vNetName?: string;
  }): Promise<any> {
    return this.request('POST', '/api/Mongo', input);
  }

  deleteMongoCluster(clusterId: string): Promise<void> {
    return this.request('DELETE', `/api/Mongo/${clusterId}`);
  }

  mongoConnection(clusterId: string): Promise<any> {
    return this.request('GET', `/api/Mongo/${clusterId}/connection`);
  }

  /** Runs a database command such as `{"find":"orders","limit":10}` — not shell syntax. */
  mongoCommand(clusterId: string, command: string, database?: string): Promise<any> {
    return this.request('POST', `/api/Mongo/${clusterId}/command`, { command, database });
  }

  mongoDatabases(clusterId: string): Promise<any[]> {
    return this.request('GET', `/api/Mongo/${clusterId}/databases`);
  }

  mongoCollections(clusterId: string, database: string): Promise<any[]> {
    return this.request('GET', `/api/Mongo/${clusterId}/databases/${encodeURIComponent(database)}/collections`);
  }

  /** Live membership, so you see the member MongoDB actually elected primary. */
  mongoReplicaStatus(clusterId: string): Promise<any[]> {
    return this.request('GET', `/api/Mongo/${clusterId}/replica-status`);
  }

  setMongoConsistency(clusterId: string, consistency: string, maxStalenessSeconds?: number): Promise<any> {
    return this.request('PUT', `/api/Mongo/${clusterId}/consistency`, { consistency, maxStalenessSeconds });
  }

  // ── YugabyteDB ────────────────────────────────────────────────────────────

  async yugabyteClusters(): Promise<any[]> {
    return (await this.request<any>('GET', '/api/Yugabyte'))?.data ?? [];
  }

  /** One node per region; replication factor follows the count and is kept odd. */
  async createYugabyteCluster(input: {
    clusterName: string; regions?: string[]; region?: string;
    sku?: string; engineVersion?: string; databaseName?: string; storageGb?: number;
  }): Promise<any> {
    return (await this.request<any>('POST', '/api/Yugabyte', input))?.data;
  }

  deleteYugabyteCluster(clusterId: string): Promise<void> {
    return this.request('DELETE', `/api/Yugabyte/${clusterId}`);
  }

  async yugabyteConnection(clusterId: string): Promise<any> {
    return (await this.request<any>('GET', `/api/Yugabyte/${clusterId}/connection`))?.data;
  }

  /** Yugabyte speaks the PostgreSQL wire protocol, so any Postgres driver works too. */
  async yugabyteQuery(clusterId: string, sql: string, maxRows = 1000): Promise<any> {
    return (await this.request<any>('POST', `/api/Yugabyte/${clusterId}/query`, { sql, maxRows }))?.data;
  }

  async yugabyteTables(clusterId: string): Promise<any[]> {
    return (await this.request<any>('GET', `/api/Yugabyte/${clusterId}/tables`))?.data ?? [];
  }

  // ── VPN Gateway ───────────────────────────────────────────────────────────

  async vpnGateways(): Promise<any[]> {
    return (await this.request<any>('GET', '/api/VPNGateway/list'))?.data ?? [];
  }

  /** `gatewayType` 0 is Site-to-Site (WireGuard), 1 is Point-to-Site (OpenVPN). */
  async createVpnGateway(input: {
    name: string; region?: string; gatewayType?: number;
    vNetId?: string; vNetName?: string; addressPool?: string;
    protocol?: string; port?: number; dnsServers?: string[]; splitTunneling?: boolean;
  }): Promise<any> {
    return (await this.request<any>('POST', '/api/VPNGateway/create', input))?.data;
  }

  deleteVpnGateway(gatewayId: string, gatewayName: string, region?: string): Promise<void> {
    let path = `/api/VPNGateway/${gatewayId}?gatewayName=${encodeURIComponent(gatewayName)}`;
    if (region) path += `&region=${encodeURIComponent(region)}`;
    return this.request('DELETE', path);
  }

  /** Issue a Point-to-Site client certificate. */
  createVpnClient(gatewayId: string, name: string, email?: string, region?: string): Promise<any> {
    const path = `/api/VPNGateway/clients/p2s${region ? `?region=${encodeURIComponent(region)}` : ''}`;
    return this.request('POST', path, { name, gatewayId, emailId: email });
  }

  async vpnClients(gatewayId: string): Promise<any[]> {
    return (await this.request<any>('GET', `/api/VPNGateway/${gatewayId}/clients/p2s`))?.data ?? [];
  }

  /**
   * Withdraw a client certificate. The record stays visible as revoked and its name
   * stays taken, so the same identity cannot be reissued.
   */
  revokeVpnClient(clientId: string, region?: string): Promise<void> {
    const path = `/api/VPNGateway/clients/p2s/${clientId}${region ? `?region=${encodeURIComponent(region)}` : ''}`;
    return this.request('DELETE', path);
  }
}
