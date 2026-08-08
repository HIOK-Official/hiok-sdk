export class HiokError extends Error {
  constructor(message: string, readonly status?: number) { super(message); }
}

export interface HiokClientOptions {
  endpoint?: string;
  token?: string;
  fetch?: typeof globalThis.fetch;
}

export class HiokClient {
  readonly endpoint: string;
  private token?: string;
  private readonly fetcher: typeof globalThis.fetch;

  constructor(options: HiokClientOptions = {}) {
    this.endpoint = (options.endpoint ?? 'https://hiokcloud.com').replace(/\/$/, '');
    this.token = options.token;
    this.fetcher = options.fetch ?? globalThis.fetch.bind(globalThis);
  }

  async login(email: string, password: string): Promise<this> {
    const response = await this.request<any>('POST', '/api/OAuth/token', { email, password }, false);
    const token = response?.data?.token;
    if (!token) throw new HiokError(response?.message ?? 'Sign-in failed');
    this.token = token;
    return this;
  }

  setToken(token: string): this { this.token = token; return this; }

  async request<T>(method: string, path: string, body?: unknown, auth = true): Promise<T> {
    if (auth && !this.token) throw new HiokError('No token configured; call login() first');
    const response = await this.fetcher(this.endpoint + path, {
      method,
      headers: {
        Accept: 'application/json',
        ...(body === undefined ? {} : { 'Content-Type': 'application/json' }),
        ...(auth ? { Authorization: `Bearer ${this.token}` } : {}),
      },
      body: body === undefined ? undefined : JSON.stringify(body),
    });
    const text = await response.text();
    const data = text ? JSON.parse(text) : undefined;
    if (!response.ok) throw new HiokError(data?.message ?? `${method} ${path} failed`, response.status);
    return data as T;
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
      regions: [options.region ?? 'south-india'],
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
}
