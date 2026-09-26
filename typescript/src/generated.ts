// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
import type { HiokTransport, FilePart } from './transport.js';

/** AccessControl operations. */
export class AccessControlApi {
  constructor(private readonly c: HiokTransport) {}

  /** Add role assignment. `[POST /api/access-control/{resourceType}/{resourceId}/role-assignments]` */
  addRoleAssignment(resourceType: string, resourceId: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/access-control/${this.c.segment(resourceType)}/${this.c.segment(resourceId)}/role-assignments`, body, undefined);
  }

  /** Check access. `[GET /api/access-control/{resourceType}/{resourceId}/check-access]` */
  checkAccess(resourceType: string, resourceId: string, query: { "principalEmail"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/access-control/${this.c.segment(resourceType)}/${this.c.segment(resourceId)}/check-access`, undefined, query);
  }

  /** List all assignments. `[GET /api/access-control/assignments]` */
  listAllAssignments(query: { "principalEmail"?: unknown; "roleId"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/access-control/assignments`, undefined, query);
  }

  /** List principals. `[GET /api/access-control/principals]` */
  listPrincipals(query: { "q"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/access-control/principals`, undefined, query);
  }

  /** List role assignments. `[GET /api/access-control/{resourceType}/{resourceId}/role-assignments]` */
  listRoleAssignments(resourceType: string, resourceId: string, query: { "includeInherited"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/access-control/${this.c.segment(resourceType)}/${this.c.segment(resourceId)}/role-assignments`, undefined, query);
  }

  /** List roles. `[GET /api/access-control/roles]` */
  listRoles(query: { "category"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/access-control/roles`, undefined, query);
  }

  /** Register scope. `[PUT /api/access-control/{resourceType}/{resourceId}/scope]` */
  registerScope(resourceType: string, resourceId: string, body?: unknown): Promise<any> {
    return this.c.call('PUT', `/api/access-control/${this.c.segment(resourceType)}/${this.c.segment(resourceId)}/scope`, body, undefined);
  }

  /** Remove assignment. `[DELETE /api/access-control/assignments/{assignmentId}]` */
  removeAssignment(assignmentId: string): Promise<any> {
    return this.c.call('DELETE', `/api/access-control/assignments/${this.c.segment(assignmentId)}`, undefined, undefined);
  }

  /** Remove role assignment. `[DELETE /api/access-control/{resourceType}/{resourceId}/role-assignments/{assignmentId}]` */
  removeRoleAssignment(resourceType: string, resourceId: string, assignmentId: string): Promise<any> {
    return this.c.call('DELETE', `/api/access-control/${this.c.segment(resourceType)}/${this.c.segment(resourceId)}/role-assignments/${this.c.segment(assignmentId)}`, undefined, undefined);
  }

  /** Scope chain. `[GET /api/access-control/{resourceType}/{resourceId}/scope-chain]` */
  scopeChain(resourceType: string, resourceId: string): Promise<any> {
    return this.c.call('GET', `/api/access-control/${this.c.segment(resourceType)}/${this.c.segment(resourceId)}/scope-chain`, undefined, undefined);
  }
}

/** Admin operations. */
export class AdminApi {
  constructor(private readonly c: HiokTransport) {}

  /** Grant. `[POST /api/Admin/access]` */
  grant(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/Admin/access`, body, undefined);
  }

  /** List grants. `[GET /api/Admin/access]` */
  listGrants(): Promise<any> {
    return this.c.call('GET', `/api/Admin/access`, undefined, undefined);
  }

  /** Me. `[GET /api/Admin/me]` */
  me(): Promise<any> {
    return this.c.call('GET', `/api/Admin/me`, undefined, undefined);
  }

  /** Revoke. `[DELETE /api/Admin/access/{id}]` */
  revoke(id: string): Promise<any> {
    return this.c.call('DELETE', `/api/Admin/access/${this.c.segment(id)}`, undefined, undefined);
  }
}

/** AdminData operations. */
export class AdminDataApi {
  constructor(private readonly c: HiokTransport) {}

  /** Resources. `[GET /api/admin/resources]` */
  resources(query: { "search"?: unknown; "type"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/admin/resources`, undefined, query);
  }

  /** Subscriptions. `[GET /api/admin/subscriptions]` */
  subscriptions(query: { "search"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/admin/subscriptions`, undefined, query);
  }

  /** Table rows. `[GET /api/admin/database/{table}]` */
  tableRows(table: string, query: { "search"?: unknown; "limit"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/admin/database/${this.c.segment(table)}`, undefined, query);
  }

  /** Tables. `[GET /api/admin/database/tables]` */
  tables(): Promise<any> {
    return this.c.call('GET', `/api/admin/database/tables`, undefined, undefined);
  }
}

/** AdminDns operations. */
export class AdminDnsApi {
  constructor(private readonly c: HiokTransport) {}

  /** Delete. `[DELETE /api/admin/dns/records/{id}]` */
  delete_(id: string): Promise<any> {
    return this.c.call('DELETE', `/api/admin/dns/records/${this.c.segment(id)}`, undefined, undefined);
  }

  /** Mail health. `[GET /api/admin/dns/mail-health]` */
  mailHealth(): Promise<any> {
    return this.c.call('GET', `/api/admin/dns/mail-health`, undefined, undefined);
  }

  /** Records. `[GET /api/admin/dns/records]` */
  records(query: { "q"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/admin/dns/records`, undefined, query);
  }

  /** Upsert. `[POST /api/admin/dns/records]` */
  upsert(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/admin/dns/records`, body, undefined);
  }
}

/** AdminInfrastructure operations. */
export class AdminInfrastructureApi {
  constructor(private readonly c: HiokTransport) {}

  /** Bridges. `[GET /api/admin/infrastructure/bridges]` */
  bridges(query: { "region"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/admin/infrastructure/bridges`, undefined, query);
  }

  /** Containers. `[GET /api/admin/infrastructure/containers]` */
  containers(query: { "region"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/admin/infrastructure/containers`, undefined, query);
  }

  /** Delete bridge. `[DELETE /api/admin/infrastructure/bridges/{name}]` */
  deleteBridge(name: string, query: { "region"?: unknown } = {}): Promise<any> {
    return this.c.call('DELETE', `/api/admin/infrastructure/bridges/${this.c.segment(name)}`, undefined, query);
  }

  /** Delete container. `[DELETE /api/admin/infrastructure/containers/{id}]` */
  deleteContainer(id: string, query: { "region"?: unknown } = {}): Promise<any> {
    return this.c.call('DELETE', `/api/admin/infrastructure/containers/${this.c.segment(id)}`, undefined, query);
  }

  /** Delete image. `[DELETE /api/admin/infrastructure/images/{id}]` */
  deleteImage(id: string, query: { "region"?: unknown } = {}): Promise<any> {
    return this.c.call('DELETE', `/api/admin/infrastructure/images/${this.c.segment(id)}`, undefined, query);
  }

  /** Delete network. `[DELETE /api/admin/infrastructure/networks/{id}]` */
  deleteNetwork(id: string, query: { "region"?: unknown } = {}): Promise<any> {
    return this.c.call('DELETE', `/api/admin/infrastructure/networks/${this.c.segment(id)}`, undefined, query);
  }

  /** Delete vm. `[DELETE /api/admin/infrastructure/vms/{name}]` */
  deleteVm(name: string, query: { "region"?: unknown } = {}): Promise<any> {
    return this.c.call('DELETE', `/api/admin/infrastructure/vms/${this.c.segment(name)}`, undefined, query);
  }

  /** Delete volume. `[DELETE /api/admin/infrastructure/volumes/{name}]` */
  deleteVolume(name: string, query: { "region"?: unknown } = {}): Promise<any> {
    return this.c.call('DELETE', `/api/admin/infrastructure/volumes/${this.c.segment(name)}`, undefined, query);
  }

  /** Dns janitor. `[POST /api/admin/infrastructure/dns-janitor]` */
  dnsJanitor(query: { "dryRun"?: unknown } = {}): Promise<any> {
    return this.c.call('POST', `/api/admin/infrastructure/dns-janitor`, undefined, query);
  }

  /** Firewall. `[GET /api/admin/infrastructure/firewall]` */
  firewall(query: { "region"?: unknown; "chain"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/admin/infrastructure/firewall`, undefined, query);
  }

  /** Flows. `[GET /api/admin/infrastructure/flows]` */
  flows(query: { "region"?: unknown; "bridge"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/admin/infrastructure/flows`, undefined, query);
  }

  /** Images. `[GET /api/admin/infrastructure/images]` */
  images(query: { "region"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/admin/infrastructure/images`, undefined, query);
  }

  /** Metrics. `[GET /api/admin/infrastructure/metrics]` */
  metrics(query: { "region"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/admin/infrastructure/metrics`, undefined, query);
  }

  /** Networks. `[GET /api/admin/infrastructure/networks]` */
  networks(query: { "region"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/admin/infrastructure/networks`, undefined, query);
  }

  /** Virtual machines. `[GET /api/admin/infrastructure/vms]` */
  virtualMachines(query: { "region"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/admin/infrastructure/vms`, undefined, query);
  }

  /** Volumes. `[GET /api/admin/infrastructure/volumes]` */
  volumes(query: { "region"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/admin/infrastructure/volumes`, undefined, query);
  }
}

/** Advisor operations. */
export class AdvisorApi {
  constructor(private readonly c: HiokTransport) {}

  /** Create tasks. `[POST /api/advisor/tasks]` */
  createTasks(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/advisor/tasks`, body, undefined);
  }

  /** Delete task. `[DELETE /api/advisor/tasks/{id}]` */
  deleteTask(id: string): Promise<any> {
    return this.c.call('DELETE', `/api/advisor/tasks/${this.c.segment(id)}`, undefined, undefined);
  }

  /** Report. `[GET /api/advisor/report]` */
  report(query: { "subscriptionId"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/advisor/report`, undefined, query);
  }

  /** Restore. `[DELETE /api/advisor/suppressions/{id}]` */
  restore(id: string): Promise<any> {
    return this.c.call('DELETE', `/api/advisor/suppressions/${this.c.segment(id)}`, undefined, undefined);
  }

  /** Suppress. `[POST /api/advisor/suppressions]` */
  suppress(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/advisor/suppressions`, body, undefined);
  }

  /** Tasks. `[GET /api/advisor/tasks]` */
  tasks(): Promise<any> {
    return this.c.call('GET', `/api/advisor/tasks`, undefined, undefined);
  }

  /** Update task. `[PATCH /api/advisor/tasks/{id}]` */
  updateTask(id: string, body?: unknown): Promise<any> {
    return this.c.call('PATCH', `/api/advisor/tasks/${this.c.segment(id)}`, body, undefined);
  }
}

/** Analytics operations. */
export class AnalyticsApi {
  constructor(private readonly c: HiokTransport) {}

  /** Attach vnet. `[POST /api/Analytics/{id}/vnet/attach]` */
  attachVNet(id: string): Promise<any> {
    return this.c.call('POST', `/api/Analytics/${this.c.segment(id)}/vnet/attach`, undefined, undefined);
  }

  /** Columns. `[GET /api/Analytics/{id}/tables/{database}/{table}/columns]` */
  columns(id: string, database: string, table: string): Promise<any> {
    return this.c.call('GET', `/api/Analytics/${this.c.segment(id)}/tables/${this.c.segment(database)}/${this.c.segment(table)}/columns`, undefined, undefined);
  }

  /** Connection. `[GET /api/Analytics/{id}/connection]` */
  connection(id: string): Promise<any> {
    return this.c.call('GET', `/api/Analytics/${this.c.segment(id)}/connection`, undefined, undefined);
  }

  /** Create. `[POST /api/Analytics]` */
  create(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/Analytics`, body, undefined);
  }

  /** Delete. `[DELETE /api/Analytics/{id}]` */
  delete_(id: string): Promise<any> {
    return this.c.call('DELETE', `/api/Analytics/${this.c.segment(id)}`, undefined, undefined);
  }

  /** Detach vnet. `[POST /api/Analytics/{id}/vnet/detach]` */
  detachVNet(id: string): Promise<any> {
    return this.c.call('POST', `/api/Analytics/${this.c.segment(id)}/vnet/detach`, undefined, undefined);
  }

  /** Get. `[GET /api/Analytics/{id}]` */
  get(id: string): Promise<any> {
    return this.c.call('GET', `/api/Analytics/${this.c.segment(id)}`, undefined, undefined);
  }

  /** List. `[GET /api/Analytics]` */
  list(): Promise<any> {
    return this.c.call('GET', `/api/Analytics`, undefined, undefined);
  }

  /** Query. `[POST /api/Analytics/{id}/query]` */
  query(id: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/Analytics/${this.c.segment(id)}/query`, body, undefined);
  }

  /** Start. `[POST /api/Analytics/{id}/start]` */
  start(id: string): Promise<any> {
    return this.c.call('POST', `/api/Analytics/${this.c.segment(id)}/start`, undefined, undefined);
  }

  /** Stop. `[POST /api/Analytics/{id}/stop]` */
  stop(id: string): Promise<any> {
    return this.c.call('POST', `/api/Analytics/${this.c.segment(id)}/stop`, undefined, undefined);
  }

  /** Tables. `[GET /api/Analytics/{id}/tables]` */
  tables(id: string): Promise<any> {
    return this.c.call('GET', `/api/Analytics/${this.c.segment(id)}/tables`, undefined, undefined);
  }
}

/** ApiManagement operations. */
export class ApiManagementApi {
  constructor(private readonly c: HiokTransport) {}

  /** Analytics. `[GET /api/apim/apis/{apiId}/analytics]` */
  analytics(apiId: string, query: { "hours"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/apim/apis/${this.c.segment(apiId)}/analytics`, undefined, query);
  }

  /** Create api. `[POST /api/apim/apis]` */
  createApi(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/apim/apis`, body, undefined);
  }

  /** Create operation. `[POST /api/apim/apis/{apiId}/operations]` */
  createOperation(apiId: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/apim/apis/${this.c.segment(apiId)}/operations`, body, undefined);
  }

  /** Create policy. `[POST /api/apim/apis/{apiId}/policies]` */
  createPolicy(apiId: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/apim/apis/${this.c.segment(apiId)}/policies`, body, undefined);
  }

  /** Create product. `[POST /api/apim/products]` */
  createProduct(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/apim/products`, body, undefined);
  }

  /** Create sub. `[POST /api/apim/subscriptions]` */
  createSub(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/apim/subscriptions`, body, undefined);
  }

  /** Delete api. `[DELETE /api/apim/apis/{id}]` */
  deleteApi(id: string): Promise<any> {
    return this.c.call('DELETE', `/api/apim/apis/${this.c.segment(id)}`, undefined, undefined);
  }

  /** Delete operation. `[DELETE /api/apim/operations/{id}]` */
  deleteOperation(id: string): Promise<any> {
    return this.c.call('DELETE', `/api/apim/operations/${this.c.segment(id)}`, undefined, undefined);
  }

  /** Delete policy. `[DELETE /api/apim/policies/{id}]` */
  deletePolicy(id: string): Promise<any> {
    return this.c.call('DELETE', `/api/apim/policies/${this.c.segment(id)}`, undefined, undefined);
  }

  /** Gateway. `[GET /api/apim/gateway/{apiPath}/{rest}]` */
  gateway(apiPath: string, rest: string): Promise<any> {
    return this.c.call('GET', `/api/apim/gateway/${this.c.segment(apiPath)}/${this.c.segment(rest)}`, undefined, undefined);
  }

  /** Gateway delete. `[DELETE /api/apim/gateway/{apiPath}/{rest}]` */
  gatewayDelete(apiPath: string, rest: string): Promise<any> {
    return this.c.call('DELETE', `/api/apim/gateway/${this.c.segment(apiPath)}/${this.c.segment(rest)}`, undefined, undefined);
  }

  /** Gateway post. `[POST /api/apim/gateway/{apiPath}/{rest}]` */
  gatewayPost(apiPath: string, rest: string): Promise<any> {
    return this.c.call('POST', `/api/apim/gateway/${this.c.segment(apiPath)}/${this.c.segment(rest)}`, undefined, undefined);
  }

  /** Gateway put. `[PUT /api/apim/gateway/{apiPath}/{rest}]` */
  gatewayPut(apiPath: string, rest: string): Promise<any> {
    return this.c.call('PUT', `/api/apim/gateway/${this.c.segment(apiPath)}/${this.c.segment(rest)}`, undefined, undefined);
  }

  /** List apis. `[GET /api/apim/apis]` */
  listApis(): Promise<any> {
    return this.c.call('GET', `/api/apim/apis`, undefined, undefined);
  }

  /** List operations. `[GET /api/apim/apis/{apiId}/operations]` */
  listOperations(apiId: string): Promise<any> {
    return this.c.call('GET', `/api/apim/apis/${this.c.segment(apiId)}/operations`, undefined, undefined);
  }

  /** List policies. `[GET /api/apim/apis/{apiId}/policies]` */
  listPolicies(apiId: string): Promise<any> {
    return this.c.call('GET', `/api/apim/apis/${this.c.segment(apiId)}/policies`, undefined, undefined);
  }

  /** List products. `[GET /api/apim/products]` */
  listProducts(): Promise<any> {
    return this.c.call('GET', `/api/apim/products`, undefined, undefined);
  }

  /** List subs. `[GET /api/apim/subscriptions]` */
  listSubs(): Promise<any> {
    return this.c.call('GET', `/api/apim/subscriptions`, undefined, undefined);
  }

  /** Regen sub key. `[POST /api/apim/subscriptions/{id}/regenerate-key]` */
  regenSubKey(id: string, query: { "which"?: unknown } = {}): Promise<any> {
    return this.c.call('POST', `/api/apim/subscriptions/${this.c.segment(id)}/regenerate-key`, undefined, query);
  }

  /** Update operation. `[PUT /api/apim/operations/{id}]` */
  updateOperation(id: string, body?: unknown): Promise<any> {
    return this.c.call('PUT', `/api/apim/operations/${this.c.segment(id)}`, body, undefined);
  }
}

/** Assistant operations. */
export class AssistantApi {
  constructor(private readonly c: HiokTransport) {}

  /** Act. `[POST /api/assistant/act]` */
  act(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/assistant/act`, body, undefined);
  }

  /** Ask. `[POST /api/assistant/ask]` */
  ask(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/assistant/ask`, body, undefined);
  }

  /** Findings. `[GET /api/assistant/findings]` */
  findings(): Promise<any> {
    return this.c.call('GET', `/api/assistant/findings`, undefined, undefined);
  }

  /** Stream. `[POST /api/assistant/stream]` */
  stream(): Promise<any> {
    return this.c.call('POST', `/api/assistant/stream`, undefined, undefined);
  }
}

/** Bastion operations. */
export class BastionApi {
  constructor(private readonly c: HiokTransport) {}

  /** Create. `[POST /api/Bastion]` */
  create(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/Bastion`, body, undefined);
  }

  /** Delete. `[DELETE /api/Bastion/{id}]` */
  delete_(id: string): Promise<any> {
    return this.c.call('DELETE', `/api/Bastion/${this.c.segment(id)}`, undefined, undefined);
  }

  /** End session. `[DELETE /api/Bastion/{id}/sessions/{sessionId}]` */
  endSession(id: string, sessionId: string): Promise<any> {
    return this.c.call('DELETE', `/api/Bastion/${this.c.segment(id)}/sessions/${this.c.segment(sessionId)}`, undefined, undefined);
  }

  /** Get. `[GET /api/Bastion/{id}]` */
  get(id: string): Promise<any> {
    return this.c.call('GET', `/api/Bastion/${this.c.segment(id)}`, undefined, undefined);
  }

  /** List. `[GET /api/Bastion]` */
  list(): Promise<any> {
    return this.c.call('GET', `/api/Bastion`, undefined, undefined);
  }

  /** List sessions. `[GET /api/Bastion/{id}/sessions]` */
  listSessions(id: string, query: { "limit"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/Bastion/${this.c.segment(id)}/sessions`, undefined, query);
  }

  /** Refresh. `[POST /api/Bastion/{id}/refresh]` */
  refresh(id: string): Promise<any> {
    return this.c.call('POST', `/api/Bastion/${this.c.segment(id)}/refresh`, undefined, undefined);
  }

  /** Start session. `[POST /api/Bastion/{id}/sessions]` */
  startSession(id: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/Bastion/${this.c.segment(id)}/sessions`, body, undefined);
  }
}

/** BillingWebhook operations. */
export class BillingWebhookApi {
  constructor(private readonly c: HiokTransport) {}

  /** Receive. `[POST /api/billing/webhook/{provider}]` */
  receive(provider: string): Promise<any> {
    return this.c.call('POST', `/api/billing/webhook/${this.c.segment(provider)}`, undefined, undefined);
  }
}

/** Cache operations. */
export class CacheApi {
  constructor(private readonly c: HiokTransport) {}

  /** Add region. `[POST /api/Cache/{id}/regions]` */
  addRegion(id: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/Cache/${this.c.segment(id)}/regions`, body, undefined);
  }

  /** Command. `[POST /api/Cache/{id}/command]` */
  command(id: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/Cache/${this.c.segment(id)}/command`, body, undefined);
  }

  /** Create. `[POST /api/Cache]` */
  create(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/Cache`, body, undefined);
  }

  /** Delete. `[DELETE /api/Cache/{id}]` */
  delete_(id: string): Promise<any> {
    return this.c.call('DELETE', `/api/Cache/${this.c.segment(id)}`, undefined, undefined);
  }

  /** Get. `[GET /api/Cache/{id}]` */
  get(id: string): Promise<any> {
    return this.c.call('GET', `/api/Cache/${this.c.segment(id)}`, undefined, undefined);
  }

  /** Keys. `[GET /api/Cache/{id}/keys]` */
  keys(id: string): Promise<any> {
    return this.c.call('GET', `/api/Cache/${this.c.segment(id)}/keys`, undefined, undefined);
  }

  /** List. `[GET /api/Cache]` */
  list(): Promise<any> {
    return this.c.call('GET', `/api/Cache`, undefined, undefined);
  }

  /** Logs. `[GET /api/Cache/{id}/logs]` */
  logs(id: string, query: { "region"?: unknown; "tail"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/Cache/${this.c.segment(id)}/logs`, undefined, query);
  }

  /** Metrics. `[GET /api/Cache/{id}/metrics]` */
  metrics(id: string, query: { "hours"?: unknown; "region"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/Cache/${this.c.segment(id)}/metrics`, undefined, query);
  }

  /** Remove region. `[DELETE /api/Cache/{id}/regions/{region}]` */
  removeRegion(id: string, region: string): Promise<any> {
    return this.c.call('DELETE', `/api/Cache/${this.c.segment(id)}/regions/${this.c.segment(region)}`, undefined, undefined);
  }

  /** Rotate. `[POST /api/Cache/{id}/keys/rotate]` */
  rotate(id: string): Promise<any> {
    return this.c.call('POST', `/api/Cache/${this.c.segment(id)}/keys/rotate`, undefined, undefined);
  }

  /** Stats. `[GET /api/Cache/{id}/stats]` */
  stats(id: string, query: { "region"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/Cache/${this.c.segment(id)}/stats`, undefined, query);
  }
}

/** Cards operations. */
export class CardsApi {
  constructor(private readonly c: HiokTransport) {}

  /** Complete. `[POST /api/billing/cards/complete]` */
  complete(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/billing/cards/complete`, body, undefined);
  }

  /** List. `[GET /api/billing/cards]` */
  list(): Promise<any> {
    return this.c.call('GET', `/api/billing/cards`, undefined, undefined);
  }

  /** Providers. `[GET /api/billing/cards/providers]` */
  providers(): Promise<any> {
    return this.c.call('GET', `/api/billing/cards/providers`, undefined, undefined);
  }

  /** Remove. `[DELETE /api/billing/cards/{id}]` */
  remove(id: string): Promise<any> {
    return this.c.call('DELETE', `/api/billing/cards/${this.c.segment(id)}`, undefined, undefined);
  }

  /** Setup. `[POST /api/billing/cards/setup]` */
  setup(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/billing/cards/setup`, body, undefined);
  }
}

/** CloudShell operations. */
export class CloudShellApi {
  constructor(private readonly c: HiokTransport) {}

  /** End. `[DELETE /api/cloudshell/session]` */
  end(): Promise<any> {
    return this.c.call('DELETE', `/api/cloudshell/session`, undefined, undefined);
  }

  /** Session. `[GET /api/cloudshell/session]` */
  session(): Promise<any> {
    return this.c.call('GET', `/api/cloudshell/session`, undefined, undefined);
  }

  /** Status. `[GET /api/cloudshell/status]` */
  status(): Promise<any> {
    return this.c.call('GET', `/api/cloudshell/status`, undefined, undefined);
  }
}

/** CloudSubscription operations. */
export class CloudSubscriptionApi {
  constructor(private readonly c: HiokTransport) {}

  /** Add payment. `[POST /api/cloudsubscription/payment-methods]` */
  addPayment(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/cloudsubscription/payment-methods`, body, undefined);
  }

  /** Create. `[POST /api/cloudsubscription]` */
  create(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/cloudsubscription`, body, undefined);
  }

  /** Delete. `[DELETE /api/cloudsubscription/{id}]` */
  delete_(id: string): Promise<any> {
    return this.c.call('DELETE', `/api/cloudsubscription/${this.c.segment(id)}`, undefined, undefined);
  }

  /** List. `[GET /api/cloudsubscription]` */
  list(): Promise<any> {
    return this.c.call('GET', `/api/cloudsubscription`, undefined, undefined);
  }

  /** Payment methods. `[GET /api/cloudsubscription/payment-methods]` */
  paymentMethods(): Promise<any> {
    return this.c.call('GET', `/api/cloudsubscription/payment-methods`, undefined, undefined);
  }
}

/** CommonServices operations. */
export class CommonServicesApi {
  constructor(private readonly c: HiokTransport) {}

  /** Get random string. `[GET /api/CommonServices/randomstring]` */
  getRandomString(query: { "length"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/CommonServices/randomstring`, undefined, query);
  }
}

/** Communication operations. */
export class CommunicationApi {
  constructor(private readonly c: HiokTransport) {}

  /** Add domain. `[POST /api/Communication/services/{id}/domains]` */
  addDomain(id: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/Communication/services/${this.c.segment(id)}/domains`, body, undefined);
  }

  /** Add sender. `[POST /api/Communication/services/{id}/domains/{domainId}/senders]` */
  addSender(id: string, domainId: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/Communication/services/${this.c.segment(id)}/domains/${this.c.segment(domainId)}/senders`, body, undefined);
  }

  /** Create connector. `[POST /api/Communication/services/{id}/connectors]` */
  createConnector(id: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/Communication/services/${this.c.segment(id)}/connectors`, body, undefined);
  }

  /** Create service. `[POST /api/Communication/services]` */
  createService(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/Communication/services`, body, undefined);
  }

  /** Delete connector. `[DELETE /api/Communication/services/{id}/connectors/{connectorId}]` */
  deleteConnector(id: string, connectorId: string): Promise<any> {
    return this.c.call('DELETE', `/api/Communication/services/${this.c.segment(id)}/connectors/${this.c.segment(connectorId)}`, undefined, undefined);
  }

  /** Delete domain. `[DELETE /api/Communication/services/{id}/domains/{domainId}]` */
  deleteDomain(id: string, domainId: string): Promise<any> {
    return this.c.call('DELETE', `/api/Communication/services/${this.c.segment(id)}/domains/${this.c.segment(domainId)}`, undefined, undefined);
  }

  /** Delete message. `[DELETE /api/Communication/services/{id}/emails/{messageId}]` */
  deleteMessage(id: string, messageId: string): Promise<any> {
    return this.c.call('DELETE', `/api/Communication/services/${this.c.segment(id)}/emails/${this.c.segment(messageId)}`, undefined, undefined);
  }

  /** Delete sender. `[DELETE /api/Communication/services/{id}/domains/{domainId}/senders/{senderId}]` */
  deleteSender(id: string, domainId: string, senderId: string): Promise<any> {
    return this.c.call('DELETE', `/api/Communication/services/${this.c.segment(id)}/domains/${this.c.segment(domainId)}/senders/${this.c.segment(senderId)}`, undefined, undefined);
  }

  /** Delete service. `[DELETE /api/Communication/services/{id}]` */
  deleteService(id: string): Promise<any> {
    return this.c.call('DELETE', `/api/Communication/services/${this.c.segment(id)}`, undefined, undefined);
  }

  /** Get message. `[GET /api/Communication/services/{id}/emails/{messageId}]` */
  getMessage(id: string, messageId: string): Promise<any> {
    return this.c.call('GET', `/api/Communication/services/${this.c.segment(id)}/emails/${this.c.segment(messageId)}`, undefined, undefined);
  }

  /** Get service. `[GET /api/Communication/services/{id}]` */
  getService(id: string): Promise<any> {
    return this.c.call('GET', `/api/Communication/services/${this.c.segment(id)}`, undefined, undefined);
  }

  /** List connectors. `[GET /api/Communication/services/{id}/connectors]` */
  listConnectors(id: string): Promise<any> {
    return this.c.call('GET', `/api/Communication/services/${this.c.segment(id)}/connectors`, undefined, undefined);
  }

  /** List domains. `[GET /api/Communication/services/{id}/domains]` */
  listDomains(id: string): Promise<any> {
    return this.c.call('GET', `/api/Communication/services/${this.c.segment(id)}/domains`, undefined, undefined);
  }

  /** List messages. `[GET /api/Communication/services/{id}/emails]` */
  listMessages(id: string, query: { "limit"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/Communication/services/${this.c.segment(id)}/emails`, undefined, query);
  }

  /** List services. `[GET /api/Communication/services]` */
  listServices(): Promise<any> {
    return this.c.call('GET', `/api/Communication/services`, undefined, undefined);
  }

  /** Send email. `[POST /api/Communication/services/{id}/emails]` */
  sendEmail(id: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/Communication/services/${this.c.segment(id)}/emails`, body, undefined);
  }

  /** Verify domain. `[POST /api/Communication/services/{id}/domains/{domainId}/verify]` */
  verifyDomain(id: string, domainId: string): Promise<any> {
    return this.c.call('POST', `/api/Communication/services/${this.c.segment(id)}/domains/${this.c.segment(domainId)}/verify`, undefined, undefined);
  }
}

/** ContainerApp operations. */
export class ContainerAppApi {
  constructor(private readonly c: HiokTransport) {}

  /** Create app. `[POST /api/ContainerApp]` */
  createApp(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/ContainerApp`, body, undefined);
  }

  /** Create environment. `[POST /api/ContainerApp/environments]` */
  createEnvironment(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/ContainerApp/environments`, body, undefined);
  }

  /** Create revision. `[POST /api/ContainerApp/{id}/revisions]` */
  createRevision(id: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/ContainerApp/${this.c.segment(id)}/revisions`, body, undefined);
  }

  /** Delete app. `[DELETE /api/ContainerApp/{id}]` */
  deleteApp(id: string): Promise<any> {
    return this.c.call('DELETE', `/api/ContainerApp/${this.c.segment(id)}`, undefined, undefined);
  }

  /** Delete environment. `[DELETE /api/ContainerApp/environments/{id}]` */
  deleteEnvironment(id: string): Promise<any> {
    return this.c.call('DELETE', `/api/ContainerApp/environments/${this.c.segment(id)}`, undefined, undefined);
  }

  /** Environment contents. `[GET /api/ContainerApp/environments/{id}/contents]` */
  environmentContents(id: string): Promise<any> {
    return this.c.call('GET', `/api/ContainerApp/environments/${this.c.segment(id)}/contents`, undefined, undefined);
  }

  /** Exec. `[POST /api/ContainerApp/{id}/exec]` */
  exec(id: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/ContainerApp/${this.c.segment(id)}/exec`, body, undefined);
  }

  /** Get app. `[GET /api/ContainerApp/{id}]` */
  getApp(id: string): Promise<any> {
    return this.c.call('GET', `/api/ContainerApp/${this.c.segment(id)}`, undefined, undefined);
  }

  /** Get replicas. `[GET /api/ContainerApp/{id}/replicas]` */
  getReplicas(id: string): Promise<any> {
    return this.c.call('GET', `/api/ContainerApp/${this.c.segment(id)}/replicas`, undefined, undefined);
  }

  /** List apps. `[GET /api/ContainerApp]` */
  listApps(): Promise<any> {
    return this.c.call('GET', `/api/ContainerApp`, undefined, undefined);
  }

  /** List environments. `[GET /api/ContainerApp/environments]` */
  listEnvironments(): Promise<any> {
    return this.c.call('GET', `/api/ContainerApp/environments`, undefined, undefined);
  }

  /** List revisions. `[GET /api/ContainerApp/{id}/revisions]` */
  listRevisions(id: string): Promise<any> {
    return this.c.call('GET', `/api/ContainerApp/${this.c.segment(id)}/revisions`, undefined, undefined);
  }

  /** Rollback. `[POST /api/ContainerApp/{id}/revisions/{revisionName}/rollback]` */
  rollback(id: string, revisionName: string): Promise<any> {
    return this.c.call('POST', `/api/ContainerApp/${this.c.segment(id)}/revisions/${this.c.segment(revisionName)}/rollback`, undefined, undefined);
  }

  /** Scale. `[POST /api/ContainerApp/{id}/scale]` */
  scale(id: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/ContainerApp/${this.c.segment(id)}/scale`, body, undefined);
  }

  /** Set traffic. `[POST /api/ContainerApp/{id}/revisions/traffic]` */
  setTraffic(id: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/ContainerApp/${this.c.segment(id)}/revisions/traffic`, body, undefined);
  }
}

/** ContainerJobs operations. */
export class ContainerJobsApi {
  constructor(private readonly c: HiokTransport) {}

  /** Cancel. `[POST /api/container-jobs/{id}/runs/{runId}/cancel]` */
  cancel(id: string, runId: string): Promise<any> {
    return this.c.call('POST', `/api/container-jobs/${this.c.segment(id)}/runs/${this.c.segment(runId)}/cancel`, undefined, undefined);
  }

  /** Create. `[POST /api/container-jobs]` */
  create(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/container-jobs`, body, undefined);
  }

  /** Delete. `[DELETE /api/container-jobs/{id}]` */
  delete_(id: string): Promise<any> {
    return this.c.call('DELETE', `/api/container-jobs/${this.c.segment(id)}`, undefined, undefined);
  }

  /** Get. `[GET /api/container-jobs/{id}]` */
  get(id: string): Promise<any> {
    return this.c.call('GET', `/api/container-jobs/${this.c.segment(id)}`, undefined, undefined);
  }

  /** Get run. `[GET /api/container-jobs/{id}/runs/{runId}]` */
  getRun(id: string, runId: string): Promise<any> {
    return this.c.call('GET', `/api/container-jobs/${this.c.segment(id)}/runs/${this.c.segment(runId)}`, undefined, undefined);
  }

  /** List. `[GET /api/container-jobs]` */
  list(): Promise<any> {
    return this.c.call('GET', `/api/container-jobs`, undefined, undefined);
  }

  /** Preview. `[GET /api/container-jobs/schedule-preview]` */
  preview(query: { "cron"?: unknown; "timeZone"?: unknown; "count"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/container-jobs/schedule-preview`, undefined, query);
  }

  /** Run. `[POST /api/container-jobs/{id}/run]` */
  run(id: string): Promise<any> {
    return this.c.call('POST', `/api/container-jobs/${this.c.segment(id)}/run`, undefined, undefined);
  }

  /** Runs. `[GET /api/container-jobs/{id}/runs]` */
  runs(id: string, query: { "take"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/container-jobs/${this.c.segment(id)}/runs`, undefined, query);
  }

  /** Update. `[PUT /api/container-jobs/{id}]` */
  update(id: string, body?: unknown): Promise<any> {
    return this.c.call('PUT', `/api/container-jobs/${this.c.segment(id)}`, body, undefined);
  }
}

/** ContainerRegistry operations. */
export class ContainerRegistryApi {
  constructor(private readonly c: HiokTransport) {}

  /** Create. `[POST /api/container-registry]` */
  create(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/container-registry`, body, undefined);
  }

  /** Create repository. `[POST /api/container-registry/{id}/repositories]` */
  createRepository(id: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/container-registry/${this.c.segment(id)}/repositories`, body, undefined);
  }

  /** Credentials. `[GET /api/container-registry/{id}/credentials]` */
  credentials(id: string): Promise<any> {
    return this.c.call('GET', `/api/container-registry/${this.c.segment(id)}/credentials`, undefined, undefined);
  }

  /** Delete. `[DELETE /api/container-registry/{id}]` */
  delete_(id: string): Promise<any> {
    return this.c.call('DELETE', `/api/container-registry/${this.c.segment(id)}`, undefined, undefined);
  }

  /** Delete repository. `[DELETE /api/container-registry/{id}/repositories/{repositoryName}]` */
  deleteRepository(id: string, repositoryName: string): Promise<any> {
    return this.c.call('DELETE', `/api/container-registry/${this.c.segment(id)}/repositories/${this.c.segment(repositoryName, true)}`, undefined, undefined);
  }

  /** Delete tag. `[DELETE /api/container-registry/{id}/tags]` */
  deleteTag(id: string, query: { "repository"?: unknown; "tag"?: unknown } = {}): Promise<any> {
    return this.c.call('DELETE', `/api/container-registry/${this.c.segment(id)}/tags`, undefined, query);
  }

  /** Get. `[GET /api/container-registry/{id}]` */
  get(id: string): Promise<any> {
    return this.c.call('GET', `/api/container-registry/${this.c.segment(id)}`, undefined, undefined);
  }

  /** List. `[GET /api/container-registry]` */
  list(): Promise<any> {
    return this.c.call('GET', `/api/container-registry`, undefined, undefined);
  }

  /** Repositories. `[GET /api/container-registry/{id}/repositories]` */
  repositories(id: string): Promise<any> {
    return this.c.call('GET', `/api/container-registry/${this.c.segment(id)}/repositories`, undefined, undefined);
  }

  /** Rotate. `[POST /api/container-registry/{id}/credentials/rotate]` */
  rotate(id: string): Promise<any> {
    return this.c.call('POST', `/api/container-registry/${this.c.segment(id)}/credentials/rotate`, undefined, undefined);
  }

  /** Tags. `[GET /api/container-registry/{id}/tags]` */
  tags(id: string, query: { "repository"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/container-registry/${this.c.segment(id)}/tags`, undefined, query);
  }
}

/** Containers operations. */
export class ContainersApi {
  constructor(private readonly c: HiokTransport) {}

  /** Build image. `[POST /api/Containers/images/build]` */
  buildImage(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/Containers/images/build`, body, undefined);
  }

  /** Create container. `[POST /api/Containers/createcontainer]` */
  createContainer(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/Containers/createcontainer`, body, undefined);
  }

  /** Create swarm service. `[POST /api/Containers/swarm/services]` */
  createSwarmService(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/Containers/swarm/services`, body, undefined);
  }

  /** Delete container. `[POST /api/Containers/deletecontainer]` */
  deleteContainer(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/Containers/deletecontainer`, body, undefined);
  }

  /** Exec. `[POST /api/Containers/{containerName}/exec]` */
  exec(containerName: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/Containers/${this.c.segment(containerName)}/exec`, body, undefined);
  }

  /** Give public address. `[POST /api/Containers/{name}/public-ip]` */
  givePublicAddress(name: string, query: { "region"?: unknown } = {}): Promise<any> {
    return this.c.call('POST', `/api/Containers/${this.c.segment(name)}/public-ip`, undefined, query);
  }

  /** Inspect. `[GET /api/Containers/{containerName}/inspect]` */
  inspect(containerName: string): Promise<any> {
    return this.c.call('GET', `/api/Containers/${this.c.segment(containerName)}/inspect`, undefined, undefined);
  }

  /** List all containers. `[POST /api/Containers/listallcontainers]` */
  listAllContainers(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/Containers/listallcontainers`, body, undefined);
  }

  /** Logs. `[GET /api/Containers/{containerName}/logs]` */
  logs(containerName: string, query: { "tail"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/Containers/${this.c.segment(containerName)}/logs`, undefined, query);
  }

  /** Release public address. `[DELETE /api/Containers/{name}/public-ip]` */
  releasePublicAddress(name: string, query: { "region"?: unknown } = {}): Promise<any> {
    return this.c.call('DELETE', `/api/Containers/${this.c.segment(name)}/public-ip`, undefined, query);
  }

  /** Remove swarm service. `[DELETE /api/Containers/swarm/services/{name}]` */
  removeSwarmService(name: string, query: { "region"?: unknown } = {}): Promise<any> {
    return this.c.call('DELETE', `/api/Containers/swarm/services/${this.c.segment(name)}`, undefined, query);
  }

  /** Rename container. `[POST /api/Containers/renamecontainer]` */
  renameContainer(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/Containers/renamecontainer`, body, undefined);
  }

  /** Restart container. `[POST /api/Containers/restartcontainer]` */
  restartContainer(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/Containers/restartcontainer`, body, undefined);
  }

  /** Scale swarm service. `[POST /api/Containers/swarm/services/{name}/scale]` */
  scaleSwarmService(name: string, query: { "replicas"?: unknown; "region"?: unknown } = {}): Promise<any> {
    return this.c.call('POST', `/api/Containers/swarm/services/${this.c.segment(name)}/scale`, undefined, query);
  }

  /** Stack down. `[POST /api/Containers/stacks/down]` */
  stackDown(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/Containers/stacks/down`, body, undefined);
  }

  /** Stack file. `[GET /api/Containers/stacks/{project}]` */
  stackFile(project: string, query: { "region"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/Containers/stacks/${this.c.segment(project)}`, undefined, query);
  }

  /** Stack up. `[POST /api/Containers/stacks/up]` */
  stackUp(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/Containers/stacks/up`, body, undefined);
  }

  /** Start container. `[POST /api/Containers/startcontainer]` */
  startContainer(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/Containers/startcontainer`, body, undefined);
  }

  /** Stats. `[GET /api/Containers/{containerName}/stats]` */
  stats(containerName: string): Promise<any> {
    return this.c.call('GET', `/api/Containers/${this.c.segment(containerName)}/stats`, undefined, undefined);
  }

  /** Stop container. `[POST /api/Containers/stopcontainer]` */
  stopContainer(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/Containers/stopcontainer`, body, undefined);
  }

  /** Swarm init. `[POST /api/Containers/swarm/init]` */
  swarmInit(query: { "region"?: unknown } = {}): Promise<any> {
    return this.c.call('POST', `/api/Containers/swarm/init`, undefined, query);
  }

  /** Swarm leave. `[POST /api/Containers/swarm/leave]` */
  swarmLeave(query: { "region"?: unknown } = {}): Promise<any> {
    return this.c.call('POST', `/api/Containers/swarm/leave`, undefined, query);
  }

  /** Swarm nodes. `[GET /api/Containers/swarm/nodes]` */
  swarmNodes(query: { "region"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/Containers/swarm/nodes`, undefined, query);
  }

  /** Swarm services. `[GET /api/Containers/swarm/services]` */
  swarmServices(query: { "region"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/Containers/swarm/services`, undefined, query);
  }

  /** Swarm status. `[GET /api/Containers/swarm]` */
  swarmStatus(query: { "region"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/Containers/swarm`, undefined, query);
  }

  /** Update container. `[POST /api/Containers/updatecontainer]` */
  updateContainer(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/Containers/updatecontainer`, body, undefined);
  }

  /** Volumes. `[GET /api/Containers/volumes]` */
  volumes(query: { "region"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/Containers/volumes`, undefined, query);
  }
}

/** CostTracking operations. */
export class CostTrackingApi {
  constructor(private readonly c: HiokTransport) {}

  /** Create cost alert. `[POST /api/CostTracking/alerts]` */
  createCostAlert(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/CostTracking/alerts`, body, undefined);
  }

  /** Delete cost alert. `[DELETE /api/CostTracking/alerts/{alertId}]` */
  deleteCostAlert(alertId: string): Promise<any> {
    return this.c.call('DELETE', `/api/CostTracking/alerts/${this.c.segment(alertId)}`, undefined, undefined);
  }

  /** Estimate cost. `[POST /api/CostTracking/pricing/estimate]` */
  estimateCost(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/CostTracking/pricing/estimate`, body, undefined);
  }

  /** Get all storage account costs. `[GET /api/CostTracking/storage-accounts]` */
  getAllStorageAccountCosts(query: { "period"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/CostTracking/storage-accounts`, undefined, query);
  }

  /** Get billing periods. `[GET /api/CostTracking/billing/history]` */
  getBillingPeriods(query: { "limit"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/CostTracking/billing/history`, undefined, query);
  }

  /** Get cost alerts. `[GET /api/CostTracking/alerts]` */
  getCostAlerts(query: { "scopeType"?: unknown; "scopeId"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/CostTracking/alerts`, undefined, query);
  }

  /** Get current billing period. `[GET /api/CostTracking/billing/current]` */
  getCurrentBillingPeriod(): Promise<any> {
    return this.c.call('GET', `/api/CostTracking/billing/current`, undefined, undefined);
  }

  /** Get pricing tiers. `[GET /api/CostTracking/pricing]` */
  getPricingTiers(query: { "tier"?: unknown; "redundancy"?: unknown; "region"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/CostTracking/pricing`, undefined, query);
  }

  /** Get resource group cost. `[GET /api/CostTracking/resource-group/{resourceGroupId}]` */
  getResourceGroupCost(resourceGroupId: string, query: { "period"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/CostTracking/resource-group/${this.c.segment(resourceGroupId)}`, undefined, query);
  }

  /** Get storage account cost. `[GET /api/CostTracking/storage-account/{storageAccountId}]` */
  getStorageAccountCost(storageAccountId: string, query: { "period"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/CostTracking/storage-account/${this.c.segment(storageAccountId)}`, undefined, query);
  }

  /** Get subscription cost. `[GET /api/CostTracking/subscription/{subscriptionId}]` */
  getSubscriptionCost(subscriptionId: string, query: { "period"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/CostTracking/subscription/${this.c.segment(subscriptionId)}`, undefined, query);
  }

  /** Overview. `[GET /api/CostTracking/overview]` */
  overview(query: { "region"?: unknown; "subscriptionId"?: unknown; "from"?: unknown; "to"?: unknown; "resourceName"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/CostTracking/overview`, undefined, query);
  }

  /** Record cost event. `[POST /api/CostTracking/events]` */
  recordCostEvent(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/CostTracking/events`, body, undefined);
  }

  /** Trigger daily calculation. `[POST /api/CostTracking/daily-calculation]` */
  triggerDailyCalculation(): Promise<any> {
    return this.c.call('POST', `/api/CostTracking/daily-calculation`, undefined, undefined);
  }
}

/** CreateResource operations. */
export class CreateResourceApi {
  constructor(private readonly c: HiokTransport) {}

  /** Create resource. `[POST /api/CreateResource/createresource]` */
  createResource(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/CreateResource/createresource`, body, undefined);
  }

  /** Validate resource. `[POST /api/CreateResource/validateresource]` */
  validateResource(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/CreateResource/validateresource`, body, undefined);
  }
}

/** Deployment operations. */
export class DeploymentApi {
  constructor(private readonly c: HiokTransport) {}

  /** Delete deployment. `[DELETE /api/Deployment/deployments/{id}]` */
  deleteDeployment(id: string): Promise<any> {
    return this.c.call('DELETE', `/api/Deployment/deployments/${this.c.segment(id)}`, undefined, undefined);
  }

  /** Deployment. `[GET /api/Deployment/deployments/{id}]` */
  deployment(id: string): Promise<any> {
    return this.c.call('GET', `/api/Deployment/deployments/${this.c.segment(id)}`, undefined, undefined);
  }

  /** Deployments. `[GET /api/Deployment/deployments]` */
  deployments(query: { "status"?: unknown; "limit"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/Deployment/deployments`, undefined, query);
  }

  /** Redeploy. `[POST /api/Deployment/deployments/{id}/redeploy]` */
  redeploy(id: string): Promise<any> {
    return this.c.call('POST', `/api/Deployment/deployments/${this.c.segment(id)}/redeploy`, undefined, undefined);
  }

  /** Status. `[GET /api/Deployment/status]` */
  status(query: { "limit"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/Deployment/status`, undefined, query);
  }
}

/** DockerImages operations. */
export class DockerImagesApi {
  constructor(private readonly c: HiokTransport) {}

  /** Get image history. `[POST /api/DockerImages/imagehistory]` */
  getImageHistory(body?: unknown, query: { "regions"?: unknown } = {}): Promise<any> {
    return this.c.call('POST', `/api/DockerImages/imagehistory`, body, query);
  }

  /** Get image informations. `[POST /api/DockerImages/inspectimage]` */
  getImageInformations(body?: unknown, query: { "regions"?: unknown } = {}): Promise<any> {
    return this.c.call('POST', `/api/DockerImages/inspectimage`, body, query);
  }

  /** List all docker images. `[POST /api/DockerImages/listallimages]` */
  listAllDockerImages(body?: unknown, query: { "regions"?: unknown } = {}): Promise<any> {
    return this.c.call('POST', `/api/DockerImages/listallimages`, body, query);
  }

  /** List all docker public images. `[POST /api/DockerImages/listallpublicimages]` */
  listAllDockerPublicImages(body?: unknown, query: { "isOfficialImage"?: unknown } = {}): Promise<any> {
    return this.c.call('POST', `/api/DockerImages/listallpublicimages`, body, query);
  }

  /** Search docker image. `[POST /api/DockerImages/searchimage]` */
  searchDockerImage(body?: unknown, query: { "regions"?: unknown } = {}): Promise<any> {
    return this.c.call('POST', `/api/DockerImages/searchimage`, body, query);
  }
}

/** Downloads operations. */
export class DownloadsApi {
  constructor(private readonly c: HiokTransport) {}

  /** Cli. `[GET /api/downloads/hiok]` */
  cli(): Promise<any> {
    return this.c.call('GET', `/api/downloads/hiok`, undefined, undefined);
  }

  /** Install. `[GET /api/downloads/install.sh]` */
  install(): Promise<any> {
    return this.c.call('GET', `/api/downloads/install.sh`, undefined, undefined);
  }

  /** Install ps1. `[GET /api/downloads/install.ps1]` */
  installPs1(): Promise<any> {
    return this.c.call('GET', `/api/downloads/install.ps1`, undefined, undefined);
  }

  /** Manifest. `[GET /api/downloads/manifest]` */
  manifest(): Promise<any> {
    return this.c.call('GET', `/api/downloads/manifest`, undefined, undefined);
  }

  /** Sdk. `[GET /api/downloads/sdk.tar.gz]` */
  sdk(): Promise<any> {
    return this.c.call('GET', `/api/downloads/sdk.tar.gz`, undefined, undefined);
  }
}

/** Dps operations. */
export class DpsApi {
  constructor(private readonly c: HiokTransport) {}

  /** Create. `[POST /api/dps/enrollments]` */
  create(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/dps/enrollments`, body, undefined);
  }

  /** Delete. `[DELETE /api/dps/enrollments/{id}]` */
  delete_(id: string): Promise<any> {
    return this.c.call('DELETE', `/api/dps/enrollments/${this.c.segment(id)}`, undefined, undefined);
  }

  /** List. `[GET /api/dps/enrollments]` */
  list(): Promise<any> {
    return this.c.call('GET', `/api/dps/enrollments`, undefined, undefined);
  }

  /** Register. `[POST /api/dps/register]` */
  register(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/dps/register`, body, undefined);
  }

  /** Registrations. `[GET /api/dps/enrollments/{id}/registrations]` */
  registrations(id: string): Promise<any> {
    return this.c.call('GET', `/api/dps/enrollments/${this.c.segment(id)}/registrations`, undefined, undefined);
  }
}

/** Fx operations. */
export class FxApi {
  constructor(private readonly c: HiokTransport) {}

  /** Convert. `[GET /api/Fx/convert]` */
  convert(query: { "usd"?: unknown; "currency"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/Fx/convert`, undefined, query);
  }

  /** Rates. `[GET /api/Fx/rates]` */
  rates(): Promise<any> {
    return this.c.call('GET', `/api/Fx/rates`, undefined, undefined);
  }
}

/** Groups operations. */
export class GroupsApi {
  constructor(private readonly c: HiokTransport) {}

  /** Create groups. `[POST /api/Groups/creategroups]` */
  createGroups(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/Groups/creategroups`, body, undefined);
  }

  /** Delete groups. `[DELETE /api/Groups/deletegroups]` */
  deleteGroups(query: { "id"?: unknown } = {}): Promise<any> {
    return this.c.call('DELETE', `/api/Groups/deletegroups`, undefined, query);
  }

  /** Edit groups. `[PUT /api/Groups/editgroups]` */
  editGroups(body?: unknown): Promise<any> {
    return this.c.call('PUT', `/api/Groups/editgroups`, body, undefined);
  }

  /** Get groups. `[GET /api/Groups/groups]` */
  getGroups(): Promise<any> {
    return this.c.call('GET', `/api/Groups/groups`, undefined, undefined);
  }
}

/** HierarchyView operations. */
export class HierarchyViewApi {
  constructor(private readonly c: HiokTransport) {}

  /** Context. `[GET /api/hierarchyview/context/{resourceGroupId}]` */
  context(resourceGroupId: string): Promise<any> {
    return this.c.call('GET', `/api/hierarchyview/context/${this.c.segment(resourceGroupId)}`, undefined, undefined);
  }

  /** Full. `[GET /api/hierarchyview/full]` */
  full(): Promise<any> {
    return this.c.call('GET', `/api/hierarchyview/full`, undefined, undefined);
  }
}

/** HiokCloudGroups operations. */
export class HiokCloudGroupsApi {
  constructor(private readonly c: HiokTransport) {}

  /** Create hiok cloud access group. `[POST /api/HiokCloudGroups/createaccessgroup]` */
  createHiokCloudAccessGroup(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/HiokCloudGroups/createaccessgroup`, body, undefined);
  }

  /** Create management group. `[POST /api/HiokCloudGroups/createmanagementgroup]` */
  createManagementGroup(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/HiokCloudGroups/createmanagementgroup`, body, undefined);
  }

  /** Create resource group. `[POST /api/HiokCloudGroups/createresourcegroup]` */
  createResourceGroup(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/HiokCloudGroups/createresourcegroup`, body, undefined);
  }

  /** Delete hiok cloud access group. `[DELETE /api/HiokCloudGroups/deleteaccessgroup]` */
  deleteHiokCloudAccessGroup(body?: unknown): Promise<any> {
    return this.c.call('DELETE', `/api/HiokCloudGroups/deleteaccessgroup`, body, undefined);
  }

  /** Edit hiok cloud access group. `[PUT /api/HiokCloudGroups/editaccessgroup]` */
  editHiokCloudAccessGroup(body?: unknown): Promise<any> {
    return this.c.call('PUT', `/api/HiokCloudGroups/editaccessgroup`, body, undefined);
  }

  /** Get all hiok cloud access group. `[GET /api/HiokCloudGroups/allaccessgroups]` */
  getAllHiokCloudAccessGroup(): Promise<any> {
    return this.c.call('GET', `/api/HiokCloudGroups/allaccessgroups`, undefined, undefined);
  }

  /** Get hiok cloud access group. `[GET /api/HiokCloudGroups/accessgroups]` */
  getHiokCloudAccessGroup(): Promise<any> {
    return this.c.call('GET', `/api/HiokCloudGroups/accessgroups`, undefined, undefined);
  }

  /** Get hiok cloud specific access group. `[GET /api/HiokCloudGroups/specificaccessgroups]` */
  getHiokCloudSpecificAccessGroup(query: { "type"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/HiokCloudGroups/specificaccessgroups`, undefined, query);
  }
}

/** HiokCloudHierarchy operations. */
export class HiokCloudHierarchyApi {
  constructor(private readonly c: HiokTransport) {}

  /** Create hiok cloud hierarchy. `[POST /api/HiokCloudHierarchy]` */
  createHiokCloudHierarchy(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/HiokCloudHierarchy`, body, undefined);
  }

  /** Delete hiok cloud hierarchy. `[DELETE /api/HiokCloudHierarchy/deletehierarchy/{id}]` */
  deleteHiokCloudHierarchy(id: string): Promise<any> {
    return this.c.call('DELETE', `/api/HiokCloudHierarchy/deletehierarchy/${this.c.segment(id)}`, undefined, undefined);
  }

  /** Delete hiok cloud hierarchy node. `[DELETE /api/HiokCloudHierarchy/deletehierarchynode]` */
  deleteHiokCloudHierarchyNode(body?: unknown): Promise<any> {
    return this.c.call('DELETE', `/api/HiokCloudHierarchy/deletehierarchynode`, body, undefined);
  }

  /** Edit hiok cloud hierarchy. `[PUT /api/HiokCloudHierarchy/edithierarchy]` */
  editHiokCloudHierarchy(body?: unknown): Promise<any> {
    return this.c.call('PUT', `/api/HiokCloudHierarchy/edithierarchy`, body, undefined);
  }

  /** Get all hierarchy. `[GET /api/HiokCloudHierarchy/hierarchies]` */
  getAllHierarchy(): Promise<any> {
    return this.c.call('GET', `/api/HiokCloudHierarchy/hierarchies`, undefined, undefined);
  }

  /** Get hierarchy. `[GET /api/HiokCloudHierarchy/hierarchy/{id}]` */
  getHierarchy(id: string): Promise<any> {
    return this.c.call('GET', `/api/HiokCloudHierarchy/hierarchy/${this.c.segment(id)}`, undefined, undefined);
  }
}

/** HiokUsers operations. */
export class HiokUsersApi {
  constructor(private readonly c: HiokTransport) {}

  /** Delete user by id. `[DELETE /api/HiokUsers/removehiokuser/{emailId}]` */
  deleteUserById(emailId: string): Promise<any> {
    return this.c.call('DELETE', `/api/HiokUsers/removehiokuser/${this.c.segment(emailId)}`, undefined, undefined);
  }

  /** Forgot password. `[POST /api/HiokUsers/forgotpassword]` */
  forgotPassword(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/HiokUsers/forgotpassword`, body, undefined);
  }

  /** Hiok user by id. `[GET /api/HiokUsers/hiokusersbyid/{emailId}]` */
  hiokUserById(emailId: string): Promise<any> {
    return this.c.call('GET', `/api/HiokUsers/hiokusersbyid/${this.c.segment(emailId)}`, undefined, undefined);
  }

  /** Hiok users. `[GET /api/HiokUsers/hiokusers]` */
  hiokUsers(): Promise<any> {
    return this.c.call('GET', `/api/HiokUsers/hiokusers`, undefined, undefined);
  }

  /** Register hiok user. `[POST /api/HiokUsers/registerhiokuser]` */
  registerHiokUser(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/HiokUsers/registerhiokuser`, body, undefined);
  }

  /** Resend verification. `[POST /api/HiokUsers/resendverification]` */
  resendVerification(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/HiokUsers/resendverification`, body, undefined);
  }

  /** Reset password. `[POST /api/HiokUsers/resetpassword]` */
  resetPassword(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/HiokUsers/resetpassword`, body, undefined);
  }

  /** Update user by id. `[PUT /api/HiokUsers/hiokuserupdate/{emailId}]` */
  updateUserById(emailId: string, body?: unknown): Promise<any> {
    return this.c.call('PUT', `/api/HiokUsers/hiokuserupdate/${this.c.segment(emailId)}`, body, undefined);
  }

  /** Verify email. `[POST /api/HiokUsers/verifyemail]` */
  verifyEmail(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/HiokUsers/verifyemail`, body, undefined);
  }
}

/** Hybrid operations. */
export class HybridApi {
  constructor(private readonly c: HiokTransport) {}

  /** Agent install. `[GET /api/hybrid/agent-install]` */
  agentInstall(): Promise<any> {
    return this.c.call('GET', `/api/hybrid/agent-install`, undefined, undefined);
  }

  /** Delete. `[DELETE /api/hybrid/resources/{id}]` */
  delete_(id: string): Promise<any> {
    return this.c.call('DELETE', `/api/hybrid/resources/${this.c.segment(id)}`, undefined, undefined);
  }

  /** Heartbeat. `[POST /api/hybrid/heartbeat]` */
  heartbeat(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/hybrid/heartbeat`, body, undefined);
  }

  /** List. `[GET /api/hybrid/resources]` */
  list(): Promise<any> {
    return this.c.call('GET', `/api/hybrid/resources`, undefined, undefined);
  }

  /** List services. `[GET /api/hybrid/resources/{id}/services]` */
  listServices(id: string): Promise<any> {
    return this.c.call('GET', `/api/hybrid/resources/${this.c.segment(id)}/services`, undefined, undefined);
  }

  /** Metrics. `[GET /api/hybrid/resources/{id}/metrics]` */
  metrics(id: string): Promise<any> {
    return this.c.call('GET', `/api/hybrid/resources/${this.c.segment(id)}/metrics`, undefined, undefined);
  }

  /** Provision edge. `[POST /api/hybrid/resources/{id}/edge]` */
  provisionEdge(id: string): Promise<any> {
    return this.c.call('POST', `/api/hybrid/resources/${this.c.segment(id)}/edge`, undefined, undefined);
  }

  /** Publish service. `[POST /api/hybrid/resources/{id}/services]` */
  publishService(id: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/hybrid/resources/${this.c.segment(id)}/services`, body, undefined);
  }

  /** Register. `[POST /api/hybrid/resources]` */
  register(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/hybrid/resources`, body, undefined);
  }

  /** Unpublish service. `[DELETE /api/hybrid/resources/{id}/services/{serviceId}]` */
  unpublishService(id: string, serviceId: string): Promise<any> {
    return this.c.call('DELETE', `/api/hybrid/resources/${this.c.segment(id)}/services/${this.c.segment(serviceId)}`, undefined, undefined);
  }
}

/** Identity operations. */
export class IdentityApi {
  constructor(private readonly c: HiokTransport) {}

  /** Create. `[POST /api/identity]` */
  create(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/identity`, body, undefined);
  }

  /** Delete. `[DELETE /api/identity/{id}]` */
  delete_(id: string): Promise<any> {
    return this.c.call('DELETE', `/api/identity/${this.c.segment(id)}`, undefined, undefined);
  }

  /** For resource. `[GET /api/identity/for-resource/{resourceId}]` */
  forResource(resourceId: string, query: { "resourceType"?: unknown; "name"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/identity/for-resource/${this.c.segment(resourceId)}`, undefined, query);
  }

  /** List. `[GET /api/identity]` */
  list(query: { "kind"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/identity`, undefined, query);
  }

  /** Regenerate. `[POST /api/identity/{id}/regenerate-secret]` */
  regenerate(id: string): Promise<any> {
    return this.c.call('POST', `/api/identity/${this.c.segment(id)}/regenerate-secret`, undefined, undefined);
  }
}

/** Infrastructure operations. */
export class InfrastructureApi {
  constructor(private readonly c: HiokTransport) {}

  /** Allocate ip. `[POST /api/Infrastructure/ip-allocations]` */
  allocateIp(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/Infrastructure/ip-allocations`, body, undefined);
  }

  /** Get reverse. `[GET /api/Infrastructure/regions/{region}/reverse/{ip}]` */
  getReverse(region: string, ip: string): Promise<any> {
    return this.c.call('GET', `/api/Infrastructure/regions/${this.c.segment(region)}/reverse/${this.c.segment(ip)}`, undefined, undefined);
  }

  /** Ip allocations. `[GET /api/Infrastructure/ip-allocations]` */
  ipAllocations(query: { "region"?: unknown; "includeReleased"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/Infrastructure/ip-allocations`, undefined, query);
  }

  /** Ip block. `[GET /api/Infrastructure/regions/{region}/ips/{block}]` */
  ipBlock(region: string, block: string): Promise<any> {
    return this.c.call('GET', `/api/Infrastructure/regions/${this.c.segment(region)}/ips/${this.c.segment(block)}`, undefined, undefined);
  }

  /** Ip pools. `[GET /api/Infrastructure/ip-pools]` */
  ipPools(query: { "region"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/Infrastructure/ip-pools`, undefined, query);
  }

  /** Ips. `[GET /api/Infrastructure/regions/{region}/ips]` */
  ips(region: string): Promise<any> {
    return this.c.call('GET', `/api/Infrastructure/regions/${this.c.segment(region)}/ips`, undefined, undefined);
  }

  /** Ips for resource. `[GET /api/Infrastructure/ip-allocations/resource/{resourceKind}/{resourceId}]` */
  ipsForResource(resourceKind: string, resourceId: string): Promise<any> {
    return this.c.call('GET', `/api/Infrastructure/ip-allocations/resource/${this.c.segment(resourceKind)}/${this.c.segment(resourceId)}`, undefined, undefined);
  }

  /** Reconcile ips. `[POST /api/Infrastructure/ip-allocations/reconcile]` */
  reconcileIps(query: { "region"?: unknown } = {}): Promise<any> {
    return this.c.call('POST', `/api/Infrastructure/ip-allocations/reconcile`, undefined, query);
  }

  /** Regions. `[GET /api/Infrastructure/regions]` */
  regions(): Promise<any> {
    return this.c.call('GET', `/api/Infrastructure/regions`, undefined, undefined);
  }

  /** Release ip. `[DELETE /api/Infrastructure/ip-allocations/{id}]` */
  releaseIp(id: string, query: { "targetContainer"?: unknown } = {}): Promise<any> {
    return this.c.call('DELETE', `/api/Infrastructure/ip-allocations/${this.c.segment(id)}`, undefined, query);
  }

  /** Reverses. `[GET /api/Infrastructure/regions/{region}/ips/{block}/reverse]` */
  reverses(region: string, block: string): Promise<any> {
    return this.c.call('GET', `/api/Infrastructure/regions/${this.c.segment(region)}/ips/${this.c.segment(block)}/reverse`, undefined, undefined);
  }

  /** Server. `[GET /api/Infrastructure/regions/{region}/servers/{name}]` */
  server(region: string, name: string): Promise<any> {
    return this.c.call('GET', `/api/Infrastructure/regions/${this.c.segment(region)}/servers/${this.c.segment(name)}`, undefined, undefined);
  }

  /** Servers. `[GET /api/Infrastructure/regions/{region}/servers]` */
  servers(region: string): Promise<any> {
    return this.c.call('GET', `/api/Infrastructure/regions/${this.c.segment(region)}/servers`, undefined, undefined);
  }

  /** Set reverse. `[POST /api/Infrastructure/regions/{region}/reverse]` */
  setReverse(region: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/Infrastructure/regions/${this.c.segment(region)}/reverse`, body, undefined);
  }
}

/** IoTDeviceGateway operations. */
export class IoTDeviceGatewayApi {
  constructor(private readonly c: HiokTransport) {}

  /** Get twin. `[GET /api/iot/devices/{deviceId}/twin]` */
  getTwin(deviceId: string): Promise<any> {
    return this.c.call('GET', `/api/iot/devices/${this.c.segment(deviceId)}/twin`, undefined, undefined);
  }

  /** Patch reported. `[PATCH /api/iot/devices/{deviceId}/twin/reported]` */
  patchReported(deviceId: string, body?: unknown): Promise<any> {
    return this.c.call('PATCH', `/api/iot/devices/${this.c.segment(deviceId)}/twin/reported`, body, undefined);
  }

  /** Pq complete. `[POST /api/iot/devices/{deviceId}/pq/complete]` */
  pqComplete(deviceId: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/iot/devices/${this.c.segment(deviceId)}/pq/complete`, body, undefined);
  }

  /** Pq handshake. `[POST /api/iot/devices/{deviceId}/pq/handshake]` */
  pqHandshake(deviceId: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/iot/devices/${this.c.segment(deviceId)}/pq/handshake`, body, undefined);
  }

  /** Receive commands. `[GET /api/iot/devices/{deviceId}/messages/devicebound]` */
  receiveCommands(deviceId: string): Promise<any> {
    return this.c.call('GET', `/api/iot/devices/${this.c.segment(deviceId)}/messages/devicebound`, undefined, undefined);
  }

  /** Send telemetry. `[POST /api/iot/devices/{deviceId}/messages/events]` */
  sendTelemetry(deviceId: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/iot/devices/${this.c.segment(deviceId)}/messages/events`, body, undefined);
  }

  /** Stream. `[GET /api/iot/devices/{deviceId}/stream]` */
  stream(deviceId: string): Promise<any> {
    return this.c.call('GET', `/api/iot/devices/${this.c.segment(deviceId)}/stream`, undefined, undefined);
  }
}

/** IoTHub operations. */
export class IoTHubApi {
  constructor(private readonly c: HiokTransport) {}

  /** Get io thubs. `[GET /api/IoTHub/iothubs]` */
  getIoTHubs(): Promise<any> {
    return this.c.call('GET', `/api/IoTHub/iothubs`, undefined, undefined);
  }
}

/** IoTHubDevice operations. */
export class IoTHubDeviceApi {
  constructor(private readonly c: HiokTransport) {}

  /** Get io thub devices. `[GET /api/IoTHubDevice/iothub/devices]` */
  getIoTHubDevices(): Promise<any> {
    return this.c.call('GET', `/api/IoTHubDevice/iothub/devices`, undefined, undefined);
  }

  /** Get io thub devices get. `[GET /api/IoTHubDevice/iothub/{iotHubId}/devices]` */
  getIoTHubDevicesGet(iotHubId: string): Promise<any> {
    return this.c.call('GET', `/api/IoTHubDevice/iothub/${this.c.segment(iotHubId)}/devices`, undefined, undefined);
  }
}

/** IoTHubDiagnostics operations. */
export class IoTHubDiagnosticsApi {
  constructor(private readonly c: HiokTransport) {}

  /** Create setting. `[POST /api/iothub/{hubId}/diagnostic-settings]` */
  createSetting(hubId: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/iothub/${this.c.segment(hubId)}/diagnostic-settings`, body, undefined);
  }

  /** Delete setting. `[DELETE /api/iothub/{hubId}/diagnostic-settings/{id}]` */
  deleteSetting(hubId: string, id: string): Promise<any> {
    return this.c.call('DELETE', `/api/iothub/${this.c.segment(hubId)}/diagnostic-settings/${this.c.segment(id)}`, undefined, undefined);
  }

  /** Destinations. `[GET /api/iothub/diagnostic-destinations]` */
  destinations(): Promise<any> {
    return this.c.call('GET', `/api/iothub/diagnostic-destinations`, undefined, undefined);
  }

  /** List settings. `[GET /api/iothub/{hubId}/diagnostic-settings]` */
  listSettings(hubId: string): Promise<any> {
    return this.c.call('GET', `/api/iothub/${this.c.segment(hubId)}/diagnostic-settings`, undefined, undefined);
  }

  /** Log categories. `[GET /api/iothub/log-categories]` */
  logCategories(): Promise<any> {
    return this.c.call('GET', `/api/iothub/log-categories`, undefined, undefined);
  }

  /** Logs. `[GET /api/iothub/{hubId}/logs]` */
  logs(hubId: string, query: { "category"?: unknown; "deviceId"?: unknown; "limit"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/iothub/${this.c.segment(hubId)}/logs`, undefined, query);
  }

  /** Metric definitions. `[GET /api/iothub/metric-definitions]` */
  metricDefinitions(): Promise<any> {
    return this.c.call('GET', `/api/iothub/metric-definitions`, undefined, undefined);
  }

  /** Metrics. `[GET /api/iothub/{hubId}/metrics]` */
  metrics(hubId: string, query: { "hours"?: unknown; "protocol"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/iothub/${this.c.segment(hubId)}/metrics`, undefined, query);
  }
}

/** IoTHubManagement operations. */
export class IoTHubManagementApi {
  constructor(private readonly c: HiokTransport) {}

  /** Connection string. `[GET /api/iothub/{hubId}/devices/{deviceId}/connection-string]` */
  connectionString(hubId: string, deviceId: string): Promise<any> {
    return this.c.call('GET', `/api/iothub/${this.c.segment(hubId)}/devices/${this.c.segment(deviceId)}/connection-string`, undefined, undefined);
  }

  /** Create device. `[POST /api/iothub/{hubId}/devices]` */
  createDevice(hubId: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/iothub/${this.c.segment(hubId)}/devices`, body, undefined);
  }

  /** Delete device. `[DELETE /api/iothub/{hubId}/devices/{deviceId}]` */
  deleteDevice(hubId: string, deviceId: string): Promise<any> {
    return this.c.call('DELETE', `/api/iothub/${this.c.segment(hubId)}/devices/${this.c.segment(deviceId)}`, undefined, undefined);
  }

  /** Delete hub. `[DELETE /api/iothub/{hubId}]` */
  deleteHub(hubId: string): Promise<any> {
    return this.c.call('DELETE', `/api/iothub/${this.c.segment(hubId)}`, undefined, undefined);
  }

  /** Get twin. `[GET /api/iothub/{hubId}/devices/{deviceId}/twin]` */
  getTwin(hubId: string, deviceId: string): Promise<any> {
    return this.c.call('GET', `/api/iothub/${this.c.segment(hubId)}/devices/${this.c.segment(deviceId)}/twin`, undefined, undefined);
  }

  /** Messages. `[GET /api/iothub/{hubId}/devices/{deviceId}/messages]` */
  messages(hubId: string, deviceId: string, query: { "direction"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/iothub/${this.c.segment(hubId)}/devices/${this.c.segment(deviceId)}/messages`, undefined, query);
  }

  /** Monitoring. `[GET /api/iothub/{hubId}/monitoring]` */
  monitoring(hubId: string): Promise<any> {
    return this.c.call('GET', `/api/iothub/${this.c.segment(hubId)}/monitoring`, undefined, undefined);
  }

  /** Receive c2 d. `[POST /api/iothub/{hubId}/devices/{deviceId}/c2d/receive]` */
  receiveC2D(hubId: string, deviceId: string): Promise<any> {
    return this.c.call('POST', `/api/iothub/${this.c.segment(hubId)}/devices/${this.c.segment(deviceId)}/c2d/receive`, undefined, undefined);
  }

  /** Regenerate key. `[POST /api/iothub/{hubId}/devices/{deviceId}/regenerate-key]` */
  regenerateKey(hubId: string, deviceId: string): Promise<any> {
    return this.c.call('POST', `/api/iothub/${this.c.segment(hubId)}/devices/${this.c.segment(deviceId)}/regenerate-key`, undefined, undefined);
  }

  /** Send c2 d. `[POST /api/iothub/{hubId}/devices/{deviceId}/c2d]` */
  sendC2D(hubId: string, deviceId: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/iothub/${this.c.segment(hubId)}/devices/${this.c.segment(deviceId)}/c2d`, body, undefined);
  }

  /** Send telemetry. `[POST /api/iothub/{hubId}/devices/{deviceId}/telemetry]` */
  sendTelemetry(hubId: string, deviceId: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/iothub/${this.c.segment(hubId)}/devices/${this.c.segment(deviceId)}/telemetry`, body, undefined);
  }

  /** Update twin. `[PATCH /api/iothub/{hubId}/devices/{deviceId}/twin]` */
  updateTwin(hubId: string, deviceId: string, body?: unknown): Promise<any> {
    return this.c.call('PATCH', `/api/iothub/${this.c.segment(hubId)}/devices/${this.c.segment(deviceId)}/twin`, body, undefined);
  }
}

/** IoTHubProtocol operations. */
export class IoTHubProtocolApi {
  constructor(private readonly c: HiokTransport) {}

  /** Algorithms. `[GET /api/iothub/algorithms]` */
  algorithms(): Promise<any> {
    return this.c.call('GET', `/api/iothub/algorithms`, undefined, undefined);
  }

  /** Ca certificate. `[GET /api/iothub/{hubId}/ca]` */
  caCertificate(hubId: string): Promise<any> {
    return this.c.call('GET', `/api/iothub/${this.c.segment(hubId)}/ca`, undefined, undefined);
  }

  /** Certificates. `[GET /api/iothub/{hubId}/certificates]` */
  certificates(hubId: string): Promise<any> {
    return this.c.call('GET', `/api/iothub/${this.c.segment(hubId)}/certificates`, undefined, undefined);
  }

  /** Connections. `[GET /api/iothub/{hubId}/connections]` */
  connections(hubId: string): Promise<any> {
    return this.c.call('GET', `/api/iothub/${this.c.segment(hubId)}/connections`, undefined, undefined);
  }

  /** Issue certificate. `[POST /api/iothub/{hubId}/devices/{deviceId}/certificate]` */
  issueCertificate(hubId: string, deviceId: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/iothub/${this.c.segment(hubId)}/devices/${this.c.segment(deviceId)}/certificate`, body, undefined);
  }

  /** Pq sessions. `[GET /api/iothub/{hubId}/pq-sessions]` */
  pqSessions(hubId: string): Promise<any> {
    return this.c.call('GET', `/api/iothub/${this.c.segment(hubId)}/pq-sessions`, undefined, undefined);
  }

  /** Protocols. `[GET /api/iothub/protocols]` */
  protocols(): Promise<any> {
    return this.c.call('GET', `/api/iothub/protocols`, undefined, undefined);
  }

  /** Provision. `[POST /api/iothub/{hubId}/provision]` */
  provision(hubId: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/iothub/${this.c.segment(hubId)}/provision`, body, undefined);
  }
}

/** K9sConsole operations. */
export class K9sConsoleApi {
  constructor(private readonly c: HiokTransport) {}

  /** Console. `[GET /api/kubernetes/clusters/{id}/console]` */
  console(id: string): Promise<any> {
    return this.c.call('GET', `/api/kubernetes/clusters/${this.c.segment(id)}/console`, undefined, undefined);
  }

  /** Status. `[GET /api/kubernetes/clusters/{id}/console/status]` */
  status(id: string): Promise<any> {
    return this.c.call('GET', `/api/kubernetes/clusters/${this.c.segment(id)}/console/status`, undefined, undefined);
  }
}

/** KeyVault operations. */
export class KeyVaultApi {
  constructor(private readonly c: HiokTransport) {}

  /** Create. `[POST /api/KeyVault]` */
  create(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/KeyVault`, body, undefined);
  }

  /** Create certificate. `[POST /api/KeyVault/{id}/certificates]` */
  createCertificate(id: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/KeyVault/${this.c.segment(id)}/certificates`, body, undefined);
  }

  /** Delete. `[DELETE /api/KeyVault/{id}]` */
  delete_(id: string): Promise<any> {
    return this.c.call('DELETE', `/api/KeyVault/${this.c.segment(id)}`, undefined, undefined);
  }

  /** Delete item. `[DELETE /api/KeyVault/{id}/items/{name}]` */
  deleteItem(id: string, name: string): Promise<any> {
    return this.c.call('DELETE', `/api/KeyVault/${this.c.segment(id)}/items/${this.c.segment(name)}`, undefined, undefined);
  }

  /** Download csr. `[GET /api/KeyVault/{id}/certificates/{name}/csr]` */
  downloadCsr(id: string, name: string): Promise<any> {
    return this.c.call('GET', `/api/KeyVault/${this.c.segment(id)}/certificates/${this.c.segment(name)}/csr`, undefined, undefined);
  }

  /** Export certificate. `[POST /api/KeyVault/{id}/certificates/{name}/export]` */
  exportCertificate(id: string, name: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/KeyVault/${this.c.segment(id)}/certificates/${this.c.segment(name)}/export`, body, undefined);
  }

  /** Get. `[GET /api/KeyVault/{id}]` */
  get(id: string): Promise<any> {
    return this.c.call('GET', `/api/KeyVault/${this.c.segment(id)}`, undefined, undefined);
  }

  /** Get item. `[GET /api/KeyVault/{id}/items/{name}]` */
  getItem(id: string, name: string, query: { "version"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/KeyVault/${this.c.segment(id)}/items/${this.c.segment(name)}`, undefined, query);
  }

  /** List. `[GET /api/KeyVault]` */
  list(): Promise<any> {
    return this.c.call('GET', `/api/KeyVault`, undefined, undefined);
  }

  /** List deleted. `[GET /api/KeyVault/deleted]` */
  listDeleted(): Promise<any> {
    return this.c.call('GET', `/api/KeyVault/deleted`, undefined, undefined);
  }

  /** List items. `[GET /api/KeyVault/{id}/items]` */
  listItems(id: string, query: { "itemType"?: unknown; "includeDeleted"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/KeyVault/${this.c.segment(id)}/items`, undefined, query);
  }

  /** List versions. `[GET /api/KeyVault/{id}/items/{name}/versions]` */
  listVersions(id: string, name: string): Promise<any> {
    return this.c.call('GET', `/api/KeyVault/${this.c.segment(id)}/items/${this.c.segment(name)}/versions`, undefined, undefined);
  }

  /** Merge certificate. `[POST /api/KeyVault/{id}/certificates/{name}/merge]` */
  mergeCertificate(id: string, name: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/KeyVault/${this.c.segment(id)}/certificates/${this.c.segment(name)}/merge`, body, undefined);
  }

  /** Purge. `[DELETE /api/KeyVault/{id}/purge]` */
  purge(id: string): Promise<any> {
    return this.c.call('DELETE', `/api/KeyVault/${this.c.segment(id)}/purge`, undefined, undefined);
  }

  /** Recover. `[POST /api/KeyVault/{id}/recover]` */
  recover(id: string): Promise<any> {
    return this.c.call('POST', `/api/KeyVault/${this.c.segment(id)}/recover`, undefined, undefined);
  }

  /** Recover item. `[POST /api/KeyVault/{id}/items/{name}/recover]` */
  recoverItem(id: string, name: string): Promise<any> {
    return this.c.call('POST', `/api/KeyVault/${this.c.segment(id)}/items/${this.c.segment(name)}/recover`, undefined, undefined);
  }

  /** Set item. `[POST /api/KeyVault/{id}/items]` */
  setItem(id: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/KeyVault/${this.c.segment(id)}/items`, body, undefined);
  }

  /** Update. `[PUT /api/KeyVault/{id}]` */
  update(id: string, body?: unknown): Promise<any> {
    return this.c.call('PUT', `/api/KeyVault/${this.c.segment(id)}`, body, undefined);
  }

  /** Update item. `[PUT /api/KeyVault/{id}/items/{name}]` */
  updateItem(id: string, name: string, body?: unknown, query: { "version"?: unknown } = {}): Promise<any> {
    return this.c.call('PUT', `/api/KeyVault/${this.c.segment(id)}/items/${this.c.segment(name)}`, body, query);
  }
}

/** Kubernetes operations. */
export class KubernetesApi {
  constructor(private readonly c: HiokTransport) {}

  /** Add pool. `[POST /api/kubernetes/clusters/{id}/node-pools]` */
  addPool(id: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/kubernetes/clusters/${this.c.segment(id)}/node-pools`, body, undefined);
  }

  /** Cordon. `[POST /api/kubernetes/clusters/{id}/nodes/{name}/cordon]` */
  cordon(id: string, name: string, query: { "undo"?: unknown } = {}): Promise<any> {
    return this.c.call('POST', `/api/kubernetes/clusters/${this.c.segment(id)}/nodes/${this.c.segment(name)}/cordon`, undefined, query);
  }

  /** Create. `[POST /api/kubernetes/clusters]` */
  create(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/kubernetes/clusters`, body, undefined);
  }

  /** Delete. `[DELETE /api/kubernetes/clusters/{id}]` */
  delete_(id: string): Promise<any> {
    return this.c.call('DELETE', `/api/kubernetes/clusters/${this.c.segment(id)}`, undefined, undefined);
  }

  /** Delete pod. `[DELETE /api/kubernetes/clusters/{id}/pods/{ns}/{name}]` */
  deletePod(id: string, ns: string, name: string): Promise<any> {
    return this.c.call('DELETE', `/api/kubernetes/clusters/${this.c.segment(id)}/pods/${this.c.segment(ns)}/${this.c.segment(name)}`, undefined, undefined);
  }

  /** Get. `[GET /api/kubernetes/clusters/{id}]` */
  get(id: string): Promise<any> {
    return this.c.call('GET', `/api/kubernetes/clusters/${this.c.segment(id)}`, undefined, undefined);
  }

  /** Kubeconfig. `[GET /api/kubernetes/clusters/{id}/kubeconfig]` */
  kubeconfig(id: string, query: { "external"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/kubernetes/clusters/${this.c.segment(id)}/kubeconfig`, undefined, query);
  }

  /** Kubectl. `[POST /api/kubernetes/clusters/{id}/kubectl]` */
  kubectl(id: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/kubernetes/clusters/${this.c.segment(id)}/kubectl`, body, undefined);
  }

  /** List. `[GET /api/kubernetes/clusters]` */
  list(): Promise<any> {
    return this.c.call('GET', `/api/kubernetes/clusters`, undefined, undefined);
  }

  /** Remove pool. `[DELETE /api/kubernetes/clusters/{id}/node-pools/{poolId}]` */
  removePool(id: string, poolId: string): Promise<any> {
    return this.c.call('DELETE', `/api/kubernetes/clusters/${this.c.segment(id)}/node-pools/${this.c.segment(poolId)}`, undefined, undefined);
  }

  /** Resources. `[GET /api/kubernetes/clusters/{id}/resources/{kind}]` */
  resources(id: string, kind: string, query: { "ns"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/kubernetes/clusters/${this.c.segment(id)}/resources/${this.c.segment(kind)}`, undefined, query);
  }

  /** Restart workload. `[POST /api/kubernetes/clusters/{id}/workloads/{kind}/{ns}/{name}/restart]` */
  restartWorkload(id: string, kind: string, ns: string, name: string): Promise<any> {
    return this.c.call('POST', `/api/kubernetes/clusters/${this.c.segment(id)}/workloads/${this.c.segment(kind)}/${this.c.segment(ns)}/${this.c.segment(name)}/restart`, undefined, undefined);
  }

  /** Scale. `[POST /api/kubernetes/clusters/{id}/workloads/{kind}/{ns}/{name}/scale]` */
  scale(id: string, kind: string, ns: string, name: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/kubernetes/clusters/${this.c.segment(id)}/workloads/${this.c.segment(kind)}/${this.c.segment(ns)}/${this.c.segment(name)}/scale`, body, undefined);
  }
}

/** MailAdmin operations. */
export class MailAdminApi {
  constructor(private readonly c: HiokTransport) {}

  /** Accounts. `[GET /api/mail/admin/accounts]` */
  accounts(): Promise<any> {
    return this.c.call('GET', `/api/mail/admin/accounts`, undefined, undefined);
  }

  /** Create. `[POST /api/mail/admin/accounts]` */
  create(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/mail/admin/accounts`, body, undefined);
  }

  /** Delete. `[DELETE /api/mail/admin/accounts/{id}]` */
  delete_(id: string): Promise<any> {
    return this.c.call('DELETE', `/api/mail/admin/accounts/${this.c.segment(id)}`, undefined, undefined);
  }

  /** Domains. `[GET /api/mail/admin/domains]` */
  domains(): Promise<any> {
    return this.c.call('GET', `/api/mail/admin/domains`, undefined, undefined);
  }

  /** Grant. `[POST /api/mail/admin/accounts/{id}/access]` */
  grant(id: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/mail/admin/accounts/${this.c.segment(id)}/access`, body, undefined);
  }

  /** Revoke. `[DELETE /api/mail/admin/accounts/{id}/access/{emailId}]` */
  revoke(id: string, emailId: string): Promise<any> {
    return this.c.call('DELETE', `/api/mail/admin/accounts/${this.c.segment(id)}/access/${this.c.segment(emailId)}`, undefined, undefined);
  }

  /** Set password. `[POST /api/mail/admin/accounts/{id}/password]` */
  setPassword(id: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/mail/admin/accounts/${this.c.segment(id)}/password`, body, undefined);
  }

  /** Update. `[PATCH /api/mail/admin/accounts/{id}]` */
  update(id: string, body?: unknown): Promise<any> {
    return this.c.call('PATCH', `/api/mail/admin/accounts/${this.c.segment(id)}`, body, undefined);
  }
}

/** Marketplace operations. */
export class MarketplaceApi {
  constructor(private readonly c: HiokTransport) {}

  /** Categories. `[GET /api/Marketplace/categories]` */
  categories(): Promise<any> {
    return this.c.call('GET', `/api/Marketplace/categories`, undefined, undefined);
  }

  /** Connections. `[GET /api/Marketplace/connections]` */
  connections(): Promise<any> {
    return this.c.call('GET', `/api/Marketplace/connections`, undefined, undefined);
  }

  /** Delete deployment. `[DELETE /api/Marketplace/deployments/{id}]` */
  deleteDeployment(id: string): Promise<any> {
    return this.c.call('DELETE', `/api/Marketplace/deployments/${this.c.segment(id)}`, undefined, undefined);
  }

  /** Deploy. `[POST /api/Marketplace/deploy]` */
  deploy(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/Marketplace/deploy`, body, undefined);
  }

  /** Deployments. `[GET /api/Marketplace/deployments]` */
  deployments(): Promise<any> {
    return this.c.call('GET', `/api/Marketplace/deployments`, undefined, undefined);
  }

  /** Offer. `[GET /api/Marketplace/offers/{slug}]` */
  offer(slug: string): Promise<any> {
    return this.c.call('GET', `/api/Marketplace/offers/${this.c.segment(slug)}`, undefined, undefined);
  }

  /** Offers. `[GET /api/Marketplace/offers]` */
  offers(query: { "search"?: unknown; "category"?: unknown; "source"?: unknown; "delivery"?: unknown; "featured"?: unknown; "take"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/Marketplace/offers`, undefined, query);
  }

  /** Publish. `[POST /api/Marketplace/offers]` */
  publish(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/Marketplace/offers`, body, undefined);
  }

  /** Save connection. `[POST /api/Marketplace/connections]` */
  saveConnection(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/Marketplace/connections`, body, undefined);
  }

  /** Sync. `[POST /api/Marketplace/connections/{id}/sync]` */
  sync(id: string): Promise<any> {
    return this.c.call('POST', `/api/Marketplace/connections/${this.c.segment(id)}/sync`, undefined, undefined);
  }

  /** Unpublish. `[DELETE /api/Marketplace/offers/{id}]` */
  unpublish(id: string): Promise<any> {
    return this.c.call('DELETE', `/api/Marketplace/offers/${this.c.segment(id)}`, undefined, undefined);
  }
}

/** Metrics operations. */
export class MetricsApi {
  constructor(private readonly c: HiokTransport) {}

  /** Get. `[GET /api/metrics/{resourceId}]` */
  get(resourceId: string): Promise<any> {
    return this.c.call('GET', `/api/metrics/${this.c.segment(resourceId)}`, undefined, undefined);
  }

  /** Get file operation metrics. `[GET /api/Metrics/storage/{storageAccountId}/operations]` */
  getFileOperationMetrics(storageAccountId: string, query: { "limit"?: unknown; "region"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/Metrics/storage/${this.c.segment(storageAccountId)}/operations`, undefined, query);
  }

  /** Get quick stats. `[GET /api/Metrics/storage/{storageAccountId}/stats]` */
  getQuickStats(storageAccountId: string, query: { "region"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/Metrics/storage/${this.c.segment(storageAccountId)}/stats`, undefined, query);
  }

  /** Get request metrics. `[GET /api/Metrics/storage/{storageAccountId}/requests]` */
  getRequestMetrics(storageAccountId: string, query: { "range"?: unknown; "region"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/Metrics/storage/${this.c.segment(storageAccountId)}/requests`, undefined, query);
  }

  /** Get storage metrics. `[GET /api/Metrics/storage/{storageAccountId}]` */
  getStorageMetrics(storageAccountId: string, query: { "range"?: unknown; "region"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/Metrics/storage/${this.c.segment(storageAccountId)}`, undefined, query);
  }

  /** Ingest storage metric. `[POST /api/Metrics/ingest/storage]` */
  ingestStorageMetric(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/Metrics/ingest/storage`, body, undefined);
  }
}

/** Mongo operations. */
export class MongoApi {
  constructor(private readonly c: HiokTransport) {}

  /** Collections. `[GET /api/Mongo/{id}/databases/{database}/collections]` */
  collections(id: string, database: string): Promise<any> {
    return this.c.call('GET', `/api/Mongo/${this.c.segment(id)}/databases/${this.c.segment(database)}/collections`, undefined, undefined);
  }

  /** Connection. `[GET /api/Mongo/{id}/connection]` */
  connection(id: string): Promise<any> {
    return this.c.call('GET', `/api/Mongo/${this.c.segment(id)}/connection`, undefined, undefined);
  }

  /** Create. `[POST /api/Mongo]` */
  create(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/Mongo`, body, undefined);
  }

  /** Databases. `[GET /api/Mongo/{id}/databases]` */
  databases(id: string): Promise<any> {
    return this.c.call('GET', `/api/Mongo/${this.c.segment(id)}/databases`, undefined, undefined);
  }

  /** Delete. `[DELETE /api/Mongo/{id}]` */
  delete_(id: string): Promise<any> {
    return this.c.call('DELETE', `/api/Mongo/${this.c.segment(id)}`, undefined, undefined);
  }

  /** Get. `[GET /api/Mongo/{id}]` */
  get(id: string): Promise<any> {
    return this.c.call('GET', `/api/Mongo/${this.c.segment(id)}`, undefined, undefined);
  }

  /** List. `[GET /api/Mongo]` */
  list(): Promise<any> {
    return this.c.call('GET', `/api/Mongo`, undefined, undefined);
  }

  /** Replica status. `[GET /api/Mongo/{id}/replica-status]` */
  replicaStatus(id: string): Promise<any> {
    return this.c.call('GET', `/api/Mongo/${this.c.segment(id)}/replica-status`, undefined, undefined);
  }

  /** Run command. `[POST /api/Mongo/{id}/command]` */
  runCommand(id: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/Mongo/${this.c.segment(id)}/command`, body, undefined);
  }

  /** Set consistency. `[PUT /api/Mongo/{id}/consistency]` */
  setConsistency(id: string, body?: unknown): Promise<any> {
    return this.c.call('PUT', `/api/Mongo/${this.c.segment(id)}/consistency`, body, undefined);
  }

  /** Start. `[POST /api/Mongo/{id}/start]` */
  start(id: string): Promise<any> {
    return this.c.call('POST', `/api/Mongo/${this.c.segment(id)}/start`, undefined, undefined);
  }

  /** Stop. `[POST /api/Mongo/{id}/stop]` */
  stop(id: string): Promise<any> {
    return this.c.call('POST', `/api/Mongo/${this.c.segment(id)}/stop`, undefined, undefined);
  }
}

/** MySqlDatabase operations. */
export class MySqlDatabaseApi {
  constructor(private readonly c: HiokTransport) {}

  /** Columns. `[GET /api/MySqlDatabase/{id}/objects/{schema}/{table}/columns]` */
  columns(id: string, schema: string, table: string, query: { "database"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/MySqlDatabase/${this.c.segment(id)}/objects/${this.c.segment(schema)}/${this.c.segment(table)}/columns`, undefined, query);
  }

  /** Connection. `[GET /api/MySqlDatabase/{id}/connection]` */
  connection(id: string): Promise<any> {
    return this.c.call('GET', `/api/MySqlDatabase/${this.c.segment(id)}/connection`, undefined, undefined);
  }

  /** Create. `[POST /api/MySqlDatabase]` */
  create(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/MySqlDatabase`, body, undefined);
  }

  /** Databases. `[GET /api/MySqlDatabase/{id}/databases]` */
  databases(id: string): Promise<any> {
    return this.c.call('GET', `/api/MySqlDatabase/${this.c.segment(id)}/databases`, undefined, undefined);
  }

  /** Delete. `[DELETE /api/MySqlDatabase/{id}]` */
  delete_(id: string): Promise<any> {
    return this.c.call('DELETE', `/api/MySqlDatabase/${this.c.segment(id)}`, undefined, undefined);
  }

  /** Get. `[GET /api/MySqlDatabase/{id}]` */
  get(id: string): Promise<any> {
    return this.c.call('GET', `/api/MySqlDatabase/${this.c.segment(id)}`, undefined, undefined);
  }

  /** List. `[GET /api/MySqlDatabase]` */
  list(): Promise<any> {
    return this.c.call('GET', `/api/MySqlDatabase`, undefined, undefined);
  }

  /** Objects. `[GET /api/MySqlDatabase/{id}/objects]` */
  objects(id: string, query: { "database"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/MySqlDatabase/${this.c.segment(id)}/objects`, undefined, query);
  }

  /** Query. `[POST /api/MySqlDatabase/{id}/query]` */
  query(id: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/MySqlDatabase/${this.c.segment(id)}/query`, body, undefined);
  }

  /** Reset password. `[POST /api/MySqlDatabase/{id}/reset-password]` */
  resetPassword(id: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/MySqlDatabase/${this.c.segment(id)}/reset-password`, body, undefined);
  }
}

/** NetworkAccess operations. */
export class NetworkAccessApi {
  constructor(private readonly c: HiokTransport) {}

  /** Create endpoint. `[POST /api/network-access/{resourceType}/{resourceId}/private-endpoints]` */
  createEndpoint(resourceType: string, resourceId: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/network-access/${this.c.segment(resourceType)}/${this.c.segment(resourceId)}/private-endpoints`, body, undefined);
  }

  /** Delete endpoint. `[DELETE /api/network-access/{resourceType}/{resourceId}/private-endpoints/{id}]` */
  deleteEndpoint(resourceType: string, resourceId: string, id: string): Promise<any> {
    return this.c.call('DELETE', `/api/network-access/${this.c.segment(resourceType)}/${this.c.segment(resourceId)}/private-endpoints/${this.c.segment(id)}`, undefined, undefined);
  }

  /** Get. `[GET /api/network-access/{resourceType}/{resourceId}]` */
  get(resourceType: string, resourceId: string): Promise<any> {
    return this.c.call('GET', `/api/network-access/${this.c.segment(resourceType)}/${this.c.segment(resourceId)}`, undefined, undefined);
  }

  /** List endpoints. `[GET /api/network-access/{resourceType}/{resourceId}/private-endpoints]` */
  listEndpoints(resourceType: string, resourceId: string): Promise<any> {
    return this.c.call('GET', `/api/network-access/${this.c.segment(resourceType)}/${this.c.segment(resourceId)}/private-endpoints`, undefined, undefined);
  }

  /** Set. `[PUT /api/network-access/{resourceType}/{resourceId}]` */
  set(resourceType: string, resourceId: string, body?: unknown): Promise<any> {
    return this.c.call('PUT', `/api/network-access/${this.c.segment(resourceType)}/${this.c.segment(resourceId)}`, body, undefined);
  }

  /** Source presets. `[GET /api/network-access/source-presets]` */
  sourcePresets(query: { "resourceType"?: unknown; "resourceId"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/network-access/source-presets`, undefined, query);
  }
}

/** Notification operations. */
export class NotificationApi {
  constructor(private readonly c: HiokTransport) {}

  /** Get notification. `[GET /api/Notification/notification]` */
  getNotification(): Promise<any> {
    return this.c.call('GET', `/api/Notification/notification`, undefined, undefined);
  }
}

/** OAuth operations. */
export class OAuthApi {
  constructor(private readonly c: HiokTransport) {}

  /** Get token. `[POST /api/OAuth/token]` */
  getToken(body?: unknown, query: { "handoff"?: unknown } = {}): Promise<any> {
    return this.c.call('POST', `/api/OAuth/token`, body, query);
  }

  /** Redeem handoff. `[POST /api/OAuth/handoff/redeem]` */
  redeemHandoff(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/OAuth/handoff/redeem`, body, undefined);
  }
}

/** OVS operations. */
export class OVSApi {
  constructor(private readonly c: HiokTransport) {}

  /** Add port. `[POST /api/OVS/bridges/{bridgeId}/ports]` */
  addPort(bridgeId: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/OVS/bridges/${this.c.segment(bridgeId)}/ports`, body, undefined);
  }

  /** Create bridge. `[POST /api/OVS/bridges]` */
  createBridge(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/OVS/bridges`, body, undefined);
  }

  /** Delete bridge. `[DELETE /api/OVS/bridges/{bridgeId}]` */
  deleteBridge(bridgeId: string): Promise<any> {
    return this.c.call('DELETE', `/api/OVS/bridges/${this.c.segment(bridgeId)}`, undefined, undefined);
  }

  /** Delete port. `[DELETE /api/OVS/bridges/{bridgeId}/ports/{portName}]` */
  deletePort(bridgeId: string, portName: string): Promise<any> {
    return this.c.call('DELETE', `/api/OVS/bridges/${this.c.segment(bridgeId)}/ports/${this.c.segment(portName)}`, undefined, undefined);
  }

  /** Get bridge. `[GET /api/OVS/bridges/{bridgeId}]` */
  getBridge(bridgeId: string): Promise<any> {
    return this.c.call('GET', `/api/OVS/bridges/${this.c.segment(bridgeId)}`, undefined, undefined);
  }

  /** List bridges. `[GET /api/OVS/bridges]` */
  listBridges(): Promise<any> {
    return this.c.call('GET', `/api/OVS/bridges`, undefined, undefined);
  }
}

/** Panel operations. */
export class PanelApi {
  constructor(private readonly c: HiokTransport) {}

  /** Create panel. `[POST /api/Panel/createpanel]` */
  createPanel(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/Panel/createpanel`, body, undefined);
  }

  /** Delete panel. `[DELETE /api/Panel/deletepanel/{id}]` */
  deletePanel(id: string): Promise<any> {
    return this.c.call('DELETE', `/api/Panel/deletepanel/${this.c.segment(id)}`, undefined, undefined);
  }

  /** Get panels. `[GET /api/Panel/panels]` */
  getPanels(): Promise<any> {
    return this.c.call('GET', `/api/Panel/panels`, undefined, undefined);
  }

  /** Panel by id. `[GET /api/Panel/panel/{id}]` */
  panelById(id: string): Promise<any> {
    return this.c.call('GET', `/api/Panel/panel/${this.c.segment(id)}`, undefined, undefined);
  }

  /** Update panel. `[PUT /api/Panel/updatepanel/{id}]` */
  updatePanel(id: string, body?: unknown): Promise<any> {
    return this.c.call('PUT', `/api/Panel/updatepanel/${this.c.segment(id)}`, body, undefined);
  }
}

/** PostgresDatabase operations. */
export class PostgresDatabaseApi {
  constructor(private readonly c: HiokTransport) {}

  /** Columns. `[GET /api/PostgresDatabase/{id}/objects/{schema}/{table}/columns]` */
  columns(id: string, schema: string, table: string, query: { "database"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/PostgresDatabase/${this.c.segment(id)}/objects/${this.c.segment(schema)}/${this.c.segment(table)}/columns`, undefined, query);
  }

  /** Connection. `[GET /api/PostgresDatabase/{id}/connection]` */
  connection(id: string): Promise<any> {
    return this.c.call('GET', `/api/PostgresDatabase/${this.c.segment(id)}/connection`, undefined, undefined);
  }

  /** Create. `[POST /api/PostgresDatabase]` */
  create(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/PostgresDatabase`, body, undefined);
  }

  /** Databases. `[GET /api/PostgresDatabase/{id}/databases]` */
  databases(id: string): Promise<any> {
    return this.c.call('GET', `/api/PostgresDatabase/${this.c.segment(id)}/databases`, undefined, undefined);
  }

  /** Delete. `[DELETE /api/PostgresDatabase/{id}]` */
  delete_(id: string): Promise<any> {
    return this.c.call('DELETE', `/api/PostgresDatabase/${this.c.segment(id)}`, undefined, undefined);
  }

  /** Get. `[GET /api/PostgresDatabase/{id}]` */
  get(id: string): Promise<any> {
    return this.c.call('GET', `/api/PostgresDatabase/${this.c.segment(id)}`, undefined, undefined);
  }

  /** List. `[GET /api/PostgresDatabase]` */
  list(): Promise<any> {
    return this.c.call('GET', `/api/PostgresDatabase`, undefined, undefined);
  }

  /** Objects. `[GET /api/PostgresDatabase/{id}/objects]` */
  objects(id: string, query: { "database"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/PostgresDatabase/${this.c.segment(id)}/objects`, undefined, query);
  }

  /** Query. `[POST /api/PostgresDatabase/{id}/query]` */
  query(id: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/PostgresDatabase/${this.c.segment(id)}/query`, body, undefined);
  }

  /** Reset password. `[POST /api/PostgresDatabase/{id}/reset-password]` */
  resetPassword(id: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/PostgresDatabase/${this.c.segment(id)}/reset-password`, body, undefined);
  }
}

/** Pricing operations. */
export class PricingApi {
  constructor(private readonly c: HiokTransport) {}

  /** List. `[GET /api/Pricing]` */
  list(): Promise<any> {
    return this.c.call('GET', `/api/Pricing`, undefined, undefined);
  }

  /** Rate card. `[GET /api/Pricing/ratecard]` */
  rateCard(): Promise<any> {
    return this.c.call('GET', `/api/Pricing/ratecard`, undefined, undefined);
  }

  /** Update. `[PUT /api/Pricing]` */
  update(body?: unknown): Promise<any> {
    return this.c.call('PUT', `/api/Pricing`, body, undefined);
  }
}

/** Profile operations. */
export class ProfileApi {
  constructor(private readonly c: HiokTransport) {}

  /** Api keys. `[GET /api/profile/api-keys]` */
  apiKeys(): Promise<any> {
    return this.c.call('GET', `/api/profile/api-keys`, undefined, undefined);
  }

  /** Get. `[GET /api/profile]` */
  get(): Promise<any> {
    return this.c.call('GET', `/api/profile`, undefined, undefined);
  }

  /** Roll key. `[POST /api/profile/api-keys/{which}/roll]` */
  rollKey(which: string): Promise<any> {
    return this.c.call('POST', `/api/profile/api-keys/${this.c.segment(which)}/roll`, undefined, undefined);
  }

  /** Update. `[PUT /api/profile]` */
  update(body?: unknown): Promise<any> {
    return this.c.call('PUT', `/api/profile`, body, undefined);
  }
}

/** Pulse operations. */
export class PulseApi {
  constructor(private readonly c: HiokTransport) {}

  /** Create consumer group. `[POST /api/Pulse/namespaces/{id}/streams/{stream}/consumer-groups]` */
  createConsumerGroup(id: string, stream: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/Pulse/namespaces/${this.c.segment(id)}/streams/${this.c.segment(stream)}/consumer-groups`, body, undefined);
  }

  /** Create event subscription. `[POST /api/Pulse/namespaces/{id}/streams/{stream}/subscriptions]` */
  createEventSubscription(id: string, stream: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/Pulse/namespaces/${this.c.segment(id)}/streams/${this.c.segment(stream)}/subscriptions`, body, undefined);
  }

  /** Create namespace. `[POST /api/Pulse/namespaces]` */
  createNamespace(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/Pulse/namespaces`, body, undefined);
  }

  /** Create stream. `[POST /api/Pulse/namespaces/{id}/streams]` */
  createStream(id: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/Pulse/namespaces/${this.c.segment(id)}/streams`, body, undefined);
  }

  /** Delete consumer group. `[DELETE /api/Pulse/namespaces/{id}/streams/{stream}/consumer-groups/{name}]` */
  deleteConsumerGroup(id: string, stream: string, name: string): Promise<any> {
    return this.c.call('DELETE', `/api/Pulse/namespaces/${this.c.segment(id)}/streams/${this.c.segment(stream)}/consumer-groups/${this.c.segment(name)}`, undefined, undefined);
  }

  /** Delete event subscription. `[DELETE /api/Pulse/namespaces/{id}/streams/{stream}/subscriptions/{name}]` */
  deleteEventSubscription(id: string, stream: string, name: string): Promise<any> {
    return this.c.call('DELETE', `/api/Pulse/namespaces/${this.c.segment(id)}/streams/${this.c.segment(stream)}/subscriptions/${this.c.segment(name)}`, undefined, undefined);
  }

  /** Delete namespace. `[DELETE /api/Pulse/namespaces/{id}]` */
  deleteNamespace(id: string): Promise<any> {
    return this.c.call('DELETE', `/api/Pulse/namespaces/${this.c.segment(id)}`, undefined, undefined);
  }

  /** Delete stream. `[DELETE /api/Pulse/namespaces/{id}/streams/{name}]` */
  deleteStream(id: string, name: string): Promise<any> {
    return this.c.call('DELETE', `/api/Pulse/namespaces/${this.c.segment(id)}/streams/${this.c.segment(name)}`, undefined, undefined);
  }

  /** List consumer groups. `[GET /api/Pulse/namespaces/{id}/streams/{stream}/consumer-groups]` */
  listConsumerGroups(id: string, stream: string): Promise<any> {
    return this.c.call('GET', `/api/Pulse/namespaces/${this.c.segment(id)}/streams/${this.c.segment(stream)}/consumer-groups`, undefined, undefined);
  }

  /** List deliveries. `[GET /api/Pulse/namespaces/{id}/streams/{stream}/subscriptions/{name}/deliveries]` */
  listDeliveries(id: string, stream: string, name: string, query: { "limit"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/Pulse/namespaces/${this.c.segment(id)}/streams/${this.c.segment(stream)}/subscriptions/${this.c.segment(name)}/deliveries`, undefined, query);
  }

  /** List event subscriptions. `[GET /api/Pulse/namespaces/{id}/streams/{stream}/subscriptions]` */
  listEventSubscriptions(id: string, stream: string): Promise<any> {
    return this.c.call('GET', `/api/Pulse/namespaces/${this.c.segment(id)}/streams/${this.c.segment(stream)}/subscriptions`, undefined, undefined);
  }

  /** List namespaces. `[GET /api/Pulse/namespaces]` */
  listNamespaces(): Promise<any> {
    return this.c.call('GET', `/api/Pulse/namespaces`, undefined, undefined);
  }

  /** List streams. `[GET /api/Pulse/namespaces/{id}/streams]` */
  listStreams(id: string): Promise<any> {
    return this.c.call('GET', `/api/Pulse/namespaces/${this.c.segment(id)}/streams`, undefined, undefined);
  }

  /** Publish. `[POST /api/Pulse/namespaces/{id}/streams/{stream}/events]` */
  publish(id: string, stream: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/Pulse/namespaces/${this.c.segment(id)}/streams/${this.c.segment(stream)}/events`, body, undefined);
  }

  /** Read. `[POST /api/Pulse/namespaces/{id}/streams/{stream}/events/read]` */
  read(id: string, stream: string, query: { "consumerGroup"?: unknown; "maxEvents"?: unknown } = {}): Promise<any> {
    return this.c.call('POST', `/api/Pulse/namespaces/${this.c.segment(id)}/streams/${this.c.segment(stream)}/events/read`, undefined, query);
  }
}

/** RecentResources operations. */
export class RecentResourcesApi {
  constructor(private readonly c: HiokTransport) {}

  /** Clear. `[DELETE /api/recent-resources]` */
  clear(query: { "id"?: unknown } = {}): Promise<any> {
    return this.c.call('DELETE', `/api/recent-resources`, undefined, query);
  }

  /** List. `[GET /api/recent-resources]` */
  list(): Promise<any> {
    return this.c.call('GET', `/api/recent-resources`, undefined, undefined);
  }

  /** Record. `[POST /api/recent-resources]` */
  record(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/recent-resources`, body, undefined);
  }

  /** Toggle favourite. `[POST /api/recent-resources/favourite]` */
  toggleFavourite(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/recent-resources/favourite`, body, undefined);
  }
}

/** ResourceGovernance operations. */
export class ResourceGovernanceApi {
  constructor(private readonly c: HiokTransport) {}

  /** Create lock. `[POST /api/resource-governance/{resourceType}/{resourceId}/locks]` */
  createLock(resourceType: string, resourceId: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/resource-governance/${this.c.segment(resourceType)}/${this.c.segment(resourceId)}/locks`, body, undefined);
  }

  /** Delete lock. `[DELETE /api/resource-governance/{resourceType}/{resourceId}/locks/{lockId}]` */
  deleteLock(resourceType: string, resourceId: string, lockId: string): Promise<any> {
    return this.c.call('DELETE', `/api/resource-governance/${this.c.segment(resourceType)}/${this.c.segment(resourceId)}/locks/${this.c.segment(lockId)}`, undefined, undefined);
  }

  /** Estate. `[GET /api/resource-governance/estate]` */
  estate(): Promise<any> {
    return this.c.call('GET', `/api/resource-governance/estate`, undefined, undefined);
  }

  /** Get activity log. `[GET /api/resource-governance/{resourceType}/{resourceId}/activity-log]` */
  getActivityLog(resourceType: string, resourceId: string, query: { "limit"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/resource-governance/${this.c.segment(resourceType)}/${this.c.segment(resourceId)}/activity-log`, undefined, query);
  }

  /** Get properties. `[GET /api/resource-governance/{resourceType}/{resourceId}/properties]` */
  getProperties(resourceType: string, resourceId: string): Promise<any> {
    return this.c.call('GET', `/api/resource-governance/${this.c.segment(resourceType)}/${this.c.segment(resourceId)}/properties`, undefined, undefined);
  }

  /** Get tenant activity. `[GET /api/resource-governance/activity]` */
  getTenantActivity(query: { "mine"?: unknown; "resourceType"?: unknown; "status"?: unknown; "hours"?: unknown; "limit"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/resource-governance/activity`, undefined, query);
  }

  /** List locks. `[GET /api/resource-governance/{resourceType}/{resourceId}/locks]` */
  listLocks(resourceType: string, resourceId: string, query: { "includeInherited"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/resource-governance/${this.c.segment(resourceType)}/${this.c.segment(resourceId)}/locks`, undefined, query);
  }

  /** Scopes. `[GET /api/resource-governance/scopes]` */
  scopes(query: { "ids"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/resource-governance/scopes`, undefined, query);
  }

  /** Update tags. `[PUT /api/resource-governance/{resourceType}/{resourceId}/tags]` */
  updateTags(resourceType: string, resourceId: string, body?: unknown): Promise<any> {
    return this.c.call('PUT', `/api/resource-governance/${this.c.segment(resourceType)}/${this.c.segment(resourceId)}/tags`, body, undefined);
  }
}

/** ResourceGroups operations. */
export class ResourceGroupsApi {
  constructor(private readonly c: HiokTransport) {}

  /** Create resource group. `[POST /api/resourcegroups]` */
  createResourceGroup(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/resourcegroups`, body, undefined);
  }

  /** Delete resource group. `[DELETE /api/resourcegroups/{id}]` */
  deleteResourceGroup(id: string): Promise<any> {
    return this.c.call('DELETE', `/api/resourcegroups/${this.c.segment(id)}`, undefined, undefined);
  }

  /** List resource groups. `[GET /api/resourcegroups]` */
  listResourceGroups(): Promise<any> {
    return this.c.call('GET', `/api/resourcegroups`, undefined, undefined);
  }
}

/** ResourceMetrics operations. */
export class ResourceMetricsApi {
  constructor(private readonly c: HiokTransport) {}

  /** Api. `[GET /api/resource-metrics/api]` */
  api(query: { "from"?: unknown; "to"?: unknown; "route"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/resource-metrics/api`, undefined, query);
  }

  /** Catalogue. `[GET /api/resource-metrics/catalogue]` */
  catalogue(): Promise<any> {
    return this.c.call('GET', `/api/resource-metrics/catalogue`, undefined, undefined);
  }

  /** Collect. `[POST /api/resource-metrics/collect]` */
  collect(query: { "region"?: unknown } = {}): Promise<any> {
    return this.c.call('POST', `/api/resource-metrics/collect`, undefined, query);
  }

  /** Cost. `[GET /api/resource-metrics/cost/{resourceKind}/{resourceName}]` */
  cost(resourceKind: string, resourceName: string, query: { "from"?: unknown; "to"?: unknown; "region"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/resource-metrics/cost/${this.c.segment(resourceKind)}/${this.c.segment(resourceName)}`, undefined, query);
  }

  /** Cost totals. `[GET /api/resource-metrics/cost-totals]` */
  costTotals(query: { "region"?: unknown; "from"?: unknown; "to"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/resource-metrics/cost-totals`, undefined, query);
  }

  /** Reporting. `[GET /api/resource-metrics/reporting]` */
  reporting(query: { "region"?: unknown; "resourceKind"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/resource-metrics/reporting`, undefined, query);
  }

  /** Series. `[GET /api/resource-metrics/{resourceKind}/{resourceName}]` */
  series(resourceKind: string, resourceName: string, query: { "from"?: unknown; "to"?: unknown; "granularity"?: unknown; "metrics"?: unknown; "region"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/resource-metrics/${this.c.segment(resourceKind)}/${this.c.segment(resourceName)}`, undefined, query);
  }
}

/** ResourceOperations operations. */
export class ResourceOperationsApi {
  constructor(private readonly c: HiokTransport) {}

  /** Alerts. `[GET /api/resource-ops/{resourceType}/{resourceId}/alerts]` */
  alerts(resourceType: string, resourceId: string): Promise<any> {
    return this.c.call('GET', `/api/resource-ops/${this.c.segment(resourceType)}/${this.c.segment(resourceId)}/alerts`, undefined, undefined);
  }

  /** Close support. `[POST /api/resource-ops/support/{id}/close]` */
  closeSupport(id: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/resource-ops/support/${this.c.segment(id)}/close`, body, undefined);
  }

  /** Delete alert. `[DELETE /api/resource-ops/{resourceType}/{resourceId}/alerts/{id}]` */
  deleteAlert(resourceType: string, resourceId: string, id: string): Promise<any> {
    return this.c.call('DELETE', `/api/resource-ops/${this.c.segment(resourceType)}/${this.c.segment(resourceId)}/alerts/${this.c.segment(id)}`, undefined, undefined);
  }

  /** Delete diagnostic. `[DELETE /api/resource-ops/{resourceType}/{resourceId}/diagnostics/{id}]` */
  deleteDiagnostic(resourceType: string, resourceId: string, id: string): Promise<any> {
    return this.c.call('DELETE', `/api/resource-ops/${this.c.segment(resourceType)}/${this.c.segment(resourceId)}/diagnostics/${this.c.segment(id)}`, undefined, undefined);
  }

  /** Delete task. `[DELETE /api/resource-ops/{resourceType}/{resourceId}/tasks/{id}]` */
  deleteTask(resourceType: string, resourceId: string, id: string): Promise<any> {
    return this.c.call('DELETE', `/api/resource-ops/${this.c.segment(resourceType)}/${this.c.segment(resourceId)}/tasks/${this.c.segment(id)}`, undefined, undefined);
  }

  /** Diagnostics. `[GET /api/resource-ops/{resourceType}/{resourceId}/diagnostics]` */
  diagnostics(resourceType: string, resourceId: string): Promise<any> {
    return this.c.call('GET', `/api/resource-ops/${this.c.segment(resourceType)}/${this.c.segment(resourceId)}/diagnostics`, undefined, undefined);
  }

  /** Health. `[GET /api/resource-ops/{resourceType}/{resourceId}/health]` */
  health(resourceType: string, resourceId: string): Promise<any> {
    return this.c.call('GET', `/api/resource-ops/${this.c.segment(resourceType)}/${this.c.segment(resourceId)}/health`, undefined, undefined);
  }

  /** Logs. `[GET /api/resource-ops/{resourceType}/{resourceId}/logs]` */
  logs(resourceType: string, resourceId: string, query: { "tail"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/resource-ops/${this.c.segment(resourceType)}/${this.c.segment(resourceId)}/logs`, undefined, query);
  }

  /** Raise support. `[POST /api/resource-ops/{resourceType}/{resourceId}/support]` */
  raiseSupport(resourceType: string, resourceId: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/resource-ops/${this.c.segment(resourceType)}/${this.c.segment(resourceId)}/support`, body, undefined);
  }

  /** Save alert. `[POST /api/resource-ops/{resourceType}/{resourceId}/alerts]` */
  saveAlert(resourceType: string, resourceId: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/resource-ops/${this.c.segment(resourceType)}/${this.c.segment(resourceId)}/alerts`, body, undefined);
  }

  /** Save diagnostic. `[POST /api/resource-ops/{resourceType}/{resourceId}/diagnostics]` */
  saveDiagnostic(resourceType: string, resourceId: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/resource-ops/${this.c.segment(resourceType)}/${this.c.segment(resourceId)}/diagnostics`, body, undefined);
  }

  /** Save task. `[POST /api/resource-ops/{resourceType}/{resourceId}/tasks]` */
  saveTask(resourceType: string, resourceId: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/resource-ops/${this.c.segment(resourceType)}/${this.c.segment(resourceId)}/tasks`, body, undefined);
  }

  /** State. `[GET /api/resource-ops/{resourceType}/{resourceId}/state]` */
  state(resourceType: string, resourceId: string, query: { "name"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/resource-ops/${this.c.segment(resourceType)}/${this.c.segment(resourceId)}/state`, undefined, query);
  }

  /** Support. `[GET /api/resource-ops/{resourceType}/{resourceId}/support]` */
  support(resourceType: string, resourceId: string): Promise<any> {
    return this.c.call('GET', `/api/resource-ops/${this.c.segment(resourceType)}/${this.c.segment(resourceId)}/support`, undefined, undefined);
  }

  /** Tasks. `[GET /api/resource-ops/{resourceType}/{resourceId}/tasks]` */
  tasks(resourceType: string, resourceId: string): Promise<any> {
    return this.c.call('GET', `/api/resource-ops/${this.c.segment(resourceType)}/${this.c.segment(resourceId)}/tasks`, undefined, undefined);
  }

  /** Template. `[GET /api/resource-ops/{resourceType}/{resourceId}/template]` */
  template(resourceType: string, resourceId: string): Promise<any> {
    return this.c.call('GET', `/api/resource-ops/${this.c.segment(resourceType)}/${this.c.segment(resourceId)}/template`, undefined, undefined);
  }

  /** Update alert. `[PUT /api/resource-ops/{resourceType}/{resourceId}/alerts/{id}]` */
  updateAlert(resourceType: string, resourceId: string, id: string, body?: unknown): Promise<any> {
    return this.c.call('PUT', `/api/resource-ops/${this.c.segment(resourceType)}/${this.c.segment(resourceId)}/alerts/${this.c.segment(id)}`, body, undefined);
  }

  /** Update task. `[PUT /api/resource-ops/{resourceType}/{resourceId}/tasks/{id}]` */
  updateTask(resourceType: string, resourceId: string, id: string, body?: unknown): Promise<any> {
    return this.c.call('PUT', `/api/resource-ops/${this.c.segment(resourceType)}/${this.c.segment(resourceId)}/tasks/${this.c.segment(id)}`, body, undefined);
  }
}

/** Sandbox operations. */
export class SandboxApi {
  constructor(private readonly c: HiokTransport) {}

  /** Create. `[POST /api/Sandbox]` */
  create(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/Sandbox`, body, undefined);
  }

  /** Create and download. `[POST /api/Sandbox/download]` */
  createAndDownload(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/Sandbox/download`, body, undefined);
  }

  /** Reap. `[POST /api/Sandbox/reap]` */
  reap(): Promise<any> {
    return this.c.call('POST', `/api/Sandbox/reap`, undefined, undefined);
  }

  /** Regions. `[GET /api/Sandbox/regions]` */
  regions(): Promise<any> {
    return this.c.call('GET', `/api/Sandbox/regions`, undefined, undefined);
  }
}

/** Search operations. */
export class SearchApi {
  constructor(private readonly c: HiokTransport) {}

  /** Search. `[GET /api/search]` */
  search(query: { "q"?: unknown; "type"?: unknown; "region"?: unknown; "status"?: unknown; "limit"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/search`, undefined, query);
  }
}

/** ServiceBus operations. */
export class ServiceBusApi {
  constructor(private readonly c: HiokTransport) {}

  /** Create namespace. `[POST /api/ServiceBus/namespaces]` */
  createNamespace(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/ServiceBus/namespaces`, body, undefined);
  }

  /** Create queue. `[POST /api/ServiceBus/namespaces/{id}/queues]` */
  createQueue(id: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/ServiceBus/namespaces/${this.c.segment(id)}/queues`, body, undefined);
  }

  /** Create rule. `[POST /api/ServiceBus/namespaces/{id}/topics/{topicName}/subscriptions/{subscriptionName}/rules]` */
  createRule(id: string, topicName: string, subscriptionName: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/ServiceBus/namespaces/${this.c.segment(id)}/topics/${this.c.segment(topicName)}/subscriptions/${this.c.segment(subscriptionName)}/rules`, body, undefined);
  }

  /** Create subscription. `[POST /api/ServiceBus/namespaces/{id}/topics/{topicName}/subscriptions]` */
  createSubscription(id: string, topicName: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/ServiceBus/namespaces/${this.c.segment(id)}/topics/${this.c.segment(topicName)}/subscriptions`, body, undefined);
  }

  /** Create topic. `[POST /api/ServiceBus/namespaces/{id}/topics]` */
  createTopic(id: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/ServiceBus/namespaces/${this.c.segment(id)}/topics`, body, undefined);
  }

  /** Delete namespace. `[DELETE /api/ServiceBus/namespaces/{id}]` */
  deleteNamespace(id: string): Promise<any> {
    return this.c.call('DELETE', `/api/ServiceBus/namespaces/${this.c.segment(id)}`, undefined, undefined);
  }

  /** Delete queue. `[DELETE /api/ServiceBus/namespaces/{id}/queues/{name}]` */
  deleteQueue(id: string, name: string): Promise<any> {
    return this.c.call('DELETE', `/api/ServiceBus/namespaces/${this.c.segment(id)}/queues/${this.c.segment(name)}`, undefined, undefined);
  }

  /** Delete rule. `[DELETE /api/ServiceBus/namespaces/{id}/topics/{topicName}/subscriptions/{subscriptionName}/rules/{ruleName}]` */
  deleteRule(id: string, topicName: string, subscriptionName: string, ruleName: string): Promise<any> {
    return this.c.call('DELETE', `/api/ServiceBus/namespaces/${this.c.segment(id)}/topics/${this.c.segment(topicName)}/subscriptions/${this.c.segment(subscriptionName)}/rules/${this.c.segment(ruleName)}`, undefined, undefined);
  }

  /** Delete subscription. `[DELETE /api/ServiceBus/namespaces/{id}/topics/{topicName}/subscriptions/{subscriptionName}]` */
  deleteSubscription(id: string, topicName: string, subscriptionName: string): Promise<any> {
    return this.c.call('DELETE', `/api/ServiceBus/namespaces/${this.c.segment(id)}/topics/${this.c.segment(topicName)}/subscriptions/${this.c.segment(subscriptionName)}`, undefined, undefined);
  }

  /** Delete topic. `[DELETE /api/ServiceBus/namespaces/{id}/topics/{name}]` */
  deleteTopic(id: string, name: string): Promise<any> {
    return this.c.call('DELETE', `/api/ServiceBus/namespaces/${this.c.segment(id)}/topics/${this.c.segment(name)}`, undefined, undefined);
  }

  /** Get keys. `[GET /api/ServiceBus/namespaces/{id}/keys]` */
  getKeys(id: string): Promise<any> {
    return this.c.call('GET', `/api/ServiceBus/namespaces/${this.c.segment(id)}/keys`, undefined, undefined);
  }

  /** Get namespace. `[GET /api/ServiceBus/namespaces/{id}]` */
  getNamespace(id: string): Promise<any> {
    return this.c.call('GET', `/api/ServiceBus/namespaces/${this.c.segment(id)}`, undefined, undefined);
  }

  /** Get queue. `[GET /api/ServiceBus/namespaces/{id}/queues/{name}]` */
  getQueue(id: string, name: string): Promise<any> {
    return this.c.call('GET', `/api/ServiceBus/namespaces/${this.c.segment(id)}/queues/${this.c.segment(name)}`, undefined, undefined);
  }

  /** List namespaces. `[GET /api/ServiceBus/namespaces]` */
  listNamespaces(query: { "product"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/ServiceBus/namespaces`, undefined, query);
  }

  /** List queues. `[GET /api/ServiceBus/namespaces/{id}/queues]` */
  listQueues(id: string): Promise<any> {
    return this.c.call('GET', `/api/ServiceBus/namespaces/${this.c.segment(id)}/queues`, undefined, undefined);
  }

  /** List rules. `[GET /api/ServiceBus/namespaces/{id}/topics/{topicName}/subscriptions/{subscriptionName}/rules]` */
  listRules(id: string, topicName: string, subscriptionName: string): Promise<any> {
    return this.c.call('GET', `/api/ServiceBus/namespaces/${this.c.segment(id)}/topics/${this.c.segment(topicName)}/subscriptions/${this.c.segment(subscriptionName)}/rules`, undefined, undefined);
  }

  /** List subscriptions. `[GET /api/ServiceBus/namespaces/{id}/topics/{topicName}/subscriptions]` */
  listSubscriptions(id: string, topicName: string): Promise<any> {
    return this.c.call('GET', `/api/ServiceBus/namespaces/${this.c.segment(id)}/topics/${this.c.segment(topicName)}/subscriptions`, undefined, undefined);
  }

  /** List topics. `[GET /api/ServiceBus/namespaces/{id}/topics]` */
  listTopics(id: string): Promise<any> {
    return this.c.call('GET', `/api/ServiceBus/namespaces/${this.c.segment(id)}/topics`, undefined, undefined);
  }

  /** Peek. `[POST /api/ServiceBus/namespaces/{id}/entities/{entity}/messages/peek]` */
  peek(id: string, entity: string, query: { "subscription"?: unknown; "maxMessages"?: unknown } = {}): Promise<any> {
    return this.c.call('POST', `/api/ServiceBus/namespaces/${this.c.segment(id)}/entities/${this.c.segment(entity)}/messages/peek`, undefined, query);
  }

  /** Receive. `[POST /api/ServiceBus/namespaces/{id}/entities/{entity}/messages/receive]` */
  receive(id: string, entity: string, body?: unknown, query: { "subscription"?: unknown } = {}): Promise<any> {
    return this.c.call('POST', `/api/ServiceBus/namespaces/${this.c.segment(id)}/entities/${this.c.segment(entity)}/messages/receive`, body, query);
  }

  /** Receive dead letter. `[POST /api/ServiceBus/namespaces/{id}/entities/{entity}/deadletter/receive]` */
  receiveDeadLetter(id: string, entity: string, query: { "subscription"?: unknown; "maxMessages"?: unknown } = {}): Promise<any> {
    return this.c.call('POST', `/api/ServiceBus/namespaces/${this.c.segment(id)}/entities/${this.c.segment(entity)}/deadletter/receive`, undefined, query);
  }

  /** Regenerate key. `[POST /api/ServiceBus/namespaces/{id}/keys/{keyName}/regenerate]` */
  regenerateKey(id: string, keyName: string, query: { "primary"?: unknown } = {}): Promise<any> {
    return this.c.call('POST', `/api/ServiceBus/namespaces/${this.c.segment(id)}/keys/${this.c.segment(keyName)}/regenerate`, undefined, query);
  }

  /** Runtime. `[GET /api/ServiceBus/namespaces/{id}/entities/{entity}/runtime]` */
  runtime(id: string, entity: string, query: { "subscription"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/ServiceBus/namespaces/${this.c.segment(id)}/entities/${this.c.segment(entity)}/runtime`, undefined, query);
  }

  /** Send. `[POST /api/ServiceBus/namespaces/{id}/entities/{entity}/messages]` */
  send(id: string, entity: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/ServiceBus/namespaces/${this.c.segment(id)}/entities/${this.c.segment(entity)}/messages`, body, undefined);
  }

  /** Settle. `[POST /api/ServiceBus/namespaces/{id}/entities/{entity}/messages/settle]` */
  settle(id: string, entity: string, body?: unknown, query: { "subscription"?: unknown } = {}): Promise<any> {
    return this.c.call('POST', `/api/ServiceBus/namespaces/${this.c.segment(id)}/entities/${this.c.segment(entity)}/messages/settle`, body, query);
  }

  /** Update queue. `[PUT /api/ServiceBus/namespaces/{id}/queues/{name}]` */
  updateQueue(id: string, name: string, body?: unknown): Promise<any> {
    return this.c.call('PUT', `/api/ServiceBus/namespaces/${this.c.segment(id)}/queues/${this.c.segment(name)}`, body, undefined);
  }
}

/** SqlServerDatabase operations. */
export class SqlServerDatabaseApi {
  constructor(private readonly c: HiokTransport) {}

  /** Columns. `[GET /api/SqlServerDatabase/{id}/objects/{schema}/{table}/columns]` */
  columns(id: string, schema: string, table: string, query: { "database"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/SqlServerDatabase/${this.c.segment(id)}/objects/${this.c.segment(schema)}/${this.c.segment(table)}/columns`, undefined, query);
  }

  /** Connection. `[GET /api/SqlServerDatabase/{id}/connection]` */
  connection(id: string): Promise<any> {
    return this.c.call('GET', `/api/SqlServerDatabase/${this.c.segment(id)}/connection`, undefined, undefined);
  }

  /** Create. `[POST /api/SqlServerDatabase]` */
  create(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/SqlServerDatabase`, body, undefined);
  }

  /** Databases. `[GET /api/SqlServerDatabase/{id}/databases]` */
  databases(id: string): Promise<any> {
    return this.c.call('GET', `/api/SqlServerDatabase/${this.c.segment(id)}/databases`, undefined, undefined);
  }

  /** Delete. `[DELETE /api/SqlServerDatabase/{id}]` */
  delete_(id: string): Promise<any> {
    return this.c.call('DELETE', `/api/SqlServerDatabase/${this.c.segment(id)}`, undefined, undefined);
  }

  /** Get. `[GET /api/SqlServerDatabase/{id}]` */
  get(id: string): Promise<any> {
    return this.c.call('GET', `/api/SqlServerDatabase/${this.c.segment(id)}`, undefined, undefined);
  }

  /** List. `[GET /api/SqlServerDatabase]` */
  list(): Promise<any> {
    return this.c.call('GET', `/api/SqlServerDatabase`, undefined, undefined);
  }

  /** Objects. `[GET /api/SqlServerDatabase/{id}/objects]` */
  objects(id: string, query: { "database"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/SqlServerDatabase/${this.c.segment(id)}/objects`, undefined, query);
  }

  /** Query. `[POST /api/SqlServerDatabase/{id}/query]` */
  query(id: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/SqlServerDatabase/${this.c.segment(id)}/query`, body, undefined);
  }

  /** Reset password. `[POST /api/SqlServerDatabase/{id}/reset-password]` */
  resetPassword(id: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/SqlServerDatabase/${this.c.segment(id)}/reset-password`, body, undefined);
  }
}

/** Storage operations. */
export class StorageApi {
  constructor(private readonly c: HiokTransport) {}

  /** Bucket filesand directories. `[POST /api/Storage/bucketfilesanddirectories]` */
  bucketFilesandDirectories(query: { "directory"?: unknown; "type"?: unknown } = {}): Promise<any> {
    return this.c.call('POST', `/api/Storage/bucketfilesanddirectories`, undefined, query);
  }

  /** Create file. `[POST /api/Storage/createfile]` */
  createFile(query: { "path"?: unknown; "filename"?: unknown } = {}): Promise<any> {
    return this.c.call('POST', `/api/Storage/createfile`, undefined, query);
  }

  /** Create folder. `[POST /api/Storage/createfolder]` */
  createFolder(query: { "path"?: unknown; "foldername"?: unknown } = {}): Promise<any> {
    return this.c.call('POST', `/api/Storage/createfolder`, undefined, query);
  }

  /** Delete file. `[POST /api/Storage/deletefile]` */
  deleteFile(query: { "path"?: unknown } = {}): Promise<any> {
    return this.c.call('POST', `/api/Storage/deletefile`, undefined, query);
  }

  /** Delete folder. `[POST /api/Storage/deletefolder]` */
  deleteFolder(query: { "path"?: unknown } = {}): Promise<any> {
    return this.c.call('POST', `/api/Storage/deletefolder`, undefined, query);
  }

  /** File copy to. `[POST /api/Storage/filecopyto]` */
  fileCopyTo(query: { "sourcePath"?: unknown; "destinationPath"?: unknown } = {}): Promise<any> {
    return this.c.call('POST', `/api/Storage/filecopyto`, undefined, query);
  }

  /** File move to. `[POST /api/Storage/filemoveto]` */
  fileMoveTo(query: { "sourcePath"?: unknown; "destinationPath"?: unknown } = {}): Promise<any> {
    return this.c.call('POST', `/api/Storage/filemoveto`, undefined, query);
  }

  /** Folder copy to. `[POST /api/Storage/foldercopyto]` */
  folderCopyTo(query: { "sourcePath"?: unknown; "destinationPath"?: unknown } = {}): Promise<any> {
    return this.c.call('POST', `/api/Storage/foldercopyto`, undefined, query);
  }

  /** Folder move to. `[POST /api/Storage/foldermoveto]` */
  folderMoveTo(query: { "sourcePath"?: unknown; "destinationPath"?: unknown } = {}): Promise<any> {
    return this.c.call('POST', `/api/Storage/foldermoveto`, undefined, query);
  }

  /** Get all directories. `[POST /api/Storage/listdirectories]` */
  getAllDirectories(query: { "directory"?: unknown } = {}): Promise<any> {
    return this.c.call('POST', `/api/Storage/listdirectories`, undefined, query);
  }

  /** Get all directories and files. `[POST /api/Storage/directoriesandfiles]` */
  getAllDirectoriesAndFiles(query: { "directory"?: unknown; "type"?: unknown } = {}): Promise<any> {
    return this.c.call('POST', `/api/Storage/directoriesandfiles`, undefined, query);
  }

  /** Get all files. `[POST /api/Storage/listfiles]` */
  getAllFiles(query: { "directory"?: unknown; "type"?: unknown } = {}): Promise<any> {
    return this.c.call('POST', `/api/Storage/listfiles`, undefined, query);
  }

  /** Get all filesand directories. `[POST /api/Storage/listfilesanddirectories]` */
  getAllFilesandDirectories(query: { "directory"?: unknown; "type"?: unknown } = {}): Promise<any> {
    return this.c.call('POST', `/api/Storage/listfilesanddirectories`, undefined, query);
  }

  /** Get root dir. `[GET /api/Storage/rootdir]` */
  getRootDir(): Promise<any> {
    return this.c.call('GET', `/api/Storage/rootdir`, undefined, undefined);
  }

  /** Rename file. `[POST /api/Storage/renamefile]` */
  renameFile(query: { "path"?: unknown; "rename"?: unknown } = {}): Promise<any> {
    return this.c.call('POST', `/api/Storage/renamefile`, undefined, query);
  }

  /** Rename folder. `[POST /api/Storage/renamefolder]` */
  renameFolder(query: { "directory"?: unknown; "rename"?: unknown } = {}): Promise<any> {
    return this.c.call('POST', `/api/Storage/renamefolder`, undefined, query);
  }
}

/** StorageAccount operations. */
export class StorageAccountApi {
  constructor(private readonly c: HiokTransport) {}

  /** Acquire lock. `[POST /api/StorageAccount/items/{itemId}/lock]` */
  acquireLock(itemId: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/StorageAccount/items/${this.c.segment(itemId)}/lock`, body, undefined);
  }

  /** Add lifecycle rule. `[POST /api/StorageAccount/{id}/lifecycle]` */
  addLifecycleRule(id: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/StorageAccount/${this.c.segment(id)}/lifecycle`, body, undefined);
  }

  /** Add role assignment. `[POST /api/StorageAccount/{id}/iam]` */
  addRoleAssignment(id: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/StorageAccount/${this.c.segment(id)}/iam`, body, undefined);
  }

  /** Break lock. `[POST /api/StorageAccount/items/{itemId}/lock/break]` */
  breakLock(itemId: string): Promise<any> {
    return this.c.call('POST', `/api/StorageAccount/items/${this.c.segment(itemId)}/lock/break`, undefined, undefined);
  }

  /** Cancel operation. `[POST /api/StorageAccount/operations/{operationId}/cancel]` */
  cancelOperation(operationId: string): Promise<any> {
    return this.c.call('POST', `/api/StorageAccount/operations/${this.c.segment(operationId)}/cancel`, undefined, undefined);
  }

  /** Copy item. `[POST /api/StorageAccount/items/copy]` */
  copyItem(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/StorageAccount/items/copy`, body, undefined);
  }

  /** Create backup. `[POST /api/StorageAccount/{id}/backups]` */
  createBackup(id: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/StorageAccount/${this.c.segment(id)}/backups`, body, undefined);
  }

  /** Create folder. `[POST /api/StorageAccount/folders]` */
  createFolder(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/StorageAccount/folders`, body, undefined);
  }

  /** Create queue. `[POST /api/StorageAccount/{id}/queues]` */
  createQueue(id: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/StorageAccount/${this.c.segment(id)}/queues`, body, undefined);
  }

  /** Create storage account. `[POST /api/StorageAccount]` */
  createStorageAccount(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/StorageAccount`, body, undefined);
  }

  /** Create table. `[POST /api/StorageAccount/{id}/tables]` */
  createTable(id: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/StorageAccount/${this.c.segment(id)}/tables`, body, undefined);
  }

  /** Create zip. `[POST /api/StorageAccount/zip]` */
  createZip(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/StorageAccount/zip`, body, undefined);
  }

  /** Delete backup. `[DELETE /api/StorageAccount/{id}/backups/{backupId}]` */
  deleteBackup(id: string, backupId: string): Promise<any> {
    return this.c.call('DELETE', `/api/StorageAccount/${this.c.segment(id)}/backups/${this.c.segment(backupId)}`, undefined, undefined);
  }

  /** Delete items. `[POST /api/StorageAccount/items/delete]` */
  deleteItems(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/StorageAccount/items/delete`, body, undefined);
  }

  /** Delete lifecycle rule. `[DELETE /api/StorageAccount/{id}/lifecycle/{ruleId}]` */
  deleteLifecycleRule(id: string, ruleId: string): Promise<any> {
    return this.c.call('DELETE', `/api/StorageAccount/${this.c.segment(id)}/lifecycle/${this.c.segment(ruleId)}`, undefined, undefined);
  }

  /** Delete queue. `[DELETE /api/StorageAccount/{id}/queues/{queueName}]` */
  deleteQueue(id: string, queueName: string): Promise<any> {
    return this.c.call('DELETE', `/api/StorageAccount/${this.c.segment(id)}/queues/${this.c.segment(queueName)}`, undefined, undefined);
  }

  /** Delete storage account. `[DELETE /api/StorageAccount/{id}]` */
  deleteStorageAccount(id: string): Promise<any> {
    return this.c.call('DELETE', `/api/StorageAccount/${this.c.segment(id)}`, undefined, undefined);
  }

  /** Delete table. `[DELETE /api/StorageAccount/{id}/tables/{tableName}]` */
  deleteTable(id: string, tableName: string): Promise<any> {
    return this.c.call('DELETE', `/api/StorageAccount/${this.c.segment(id)}/tables/${this.c.segment(tableName)}`, undefined, undefined);
  }

  /** Download item content. `[GET /api/StorageAccount/items/{itemId}/content]` */
  downloadItemContent(itemId: string, query: { "region"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/StorageAccount/items/${this.c.segment(itemId)}/content`, undefined, query);
  }

  /** Download zip. `[POST /api/StorageAccount/zip/download]` */
  downloadZip(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/StorageAccount/zip/download`, body, undefined);
  }

  /** Export activity log. `[GET /api/StorageAccount/{id}/activity/export]` */
  exportActivityLog(id: string, query: { "format"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/StorageAccount/${this.c.segment(id)}/activity/export`, undefined, query);
  }

  /** Extract archive. `[POST /api/StorageAccount/{id}/items/{itemId}/extract]` */
  extractArchive(id: string, itemId: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/StorageAccount/${this.c.segment(id)}/items/${this.c.segment(itemId)}/extract`, body, undefined);
  }

  /** Finalize upload. `[POST /api/StorageAccount/upload/{operationId}/finalize]` */
  finalizeUpload(operationId: string): Promise<any> {
    return this.c.call('POST', `/api/StorageAccount/upload/${this.c.segment(operationId)}/finalize`, undefined, undefined);
  }

  /** Generate share link. `[POST /api/StorageAccount/items/{itemId}/sharelink]` */
  generateShareLink(itemId: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/StorageAccount/items/${this.c.segment(itemId)}/sharelink`, body, undefined);
  }

  /** Get access keys. `[GET /api/StorageAccount/{id}/keys]` */
  getAccessKeys(id: string): Promise<any> {
    return this.c.call('GET', `/api/StorageAccount/${this.c.segment(id)}/keys`, undefined, undefined);
  }

  /** Get active operations. `[GET /api/StorageAccount/{id}/operations]` */
  getActiveOperations(id: string): Promise<any> {
    return this.c.call('GET', `/api/StorageAccount/${this.c.segment(id)}/operations`, undefined, undefined);
  }

  /** Get activity log. `[GET /api/StorageAccount/{id}/activity]` */
  getActivityLog(id: string, query: { "limit"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/StorageAccount/${this.c.segment(id)}/activity`, undefined, query);
  }

  /** Get available regions. `[GET /api/StorageAccount/regions]` */
  getAvailableRegions(): Promise<any> {
    return this.c.call('GET', `/api/StorageAccount/regions`, undefined, undefined);
  }

  /** Get backups. `[GET /api/StorageAccount/{id}/backups]` */
  getBackups(id: string): Promise<any> {
    return this.c.call('GET', `/api/StorageAccount/${this.c.segment(id)}/backups`, undefined, undefined);
  }

  /** Get default storage account. `[GET /api/StorageAccount/default]` */
  getDefaultStorageAccount(): Promise<any> {
    return this.c.call('GET', `/api/StorageAccount/default`, undefined, undefined);
  }

  /** Get file preview. `[GET /api/StorageAccount/items/{itemId}/preview]` */
  getFilePreview(itemId: string): Promise<any> {
    return this.c.call('GET', `/api/StorageAccount/items/${this.c.segment(itemId)}/preview`, undefined, undefined);
  }

  /** Get item. `[GET /api/StorageAccount/items/{itemId}]` */
  getItem(itemId: string): Promise<any> {
    return this.c.call('GET', `/api/StorageAccount/items/${this.c.segment(itemId)}`, undefined, undefined);
  }

  /** Get item activity log. `[GET /api/StorageAccount/items/{itemId}/activity]` */
  getItemActivityLog(itemId: string, query: { "limit"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/StorageAccount/items/${this.c.segment(itemId)}/activity`, undefined, query);
  }

  /** Get item metadata. `[GET /api/StorageAccount/items/{itemId}/metadata]` */
  getItemMetadata(itemId: string): Promise<any> {
    return this.c.call('GET', `/api/StorageAccount/items/${this.c.segment(itemId)}/metadata`, undefined, undefined);
  }

  /** Get item shares. `[GET /api/StorageAccount/items/{itemId}/shares]` */
  getItemShares(itemId: string): Promise<any> {
    return this.c.call('GET', `/api/StorageAccount/items/${this.c.segment(itemId)}/shares`, undefined, undefined);
  }

  /** Get lifecycle rules. `[GET /api/StorageAccount/{id}/lifecycle]` */
  getLifecycleRules(id: string): Promise<any> {
    return this.c.call('GET', `/api/StorageAccount/${this.c.segment(id)}/lifecycle`, undefined, undefined);
  }

  /** Get networking. `[GET /api/StorageAccount/{id}/networking]` */
  getNetworking(id: string): Promise<any> {
    return this.c.call('GET', `/api/StorageAccount/${this.c.segment(id)}/networking`, undefined, undefined);
  }

  /** Get operation status. `[GET /api/StorageAccount/operations/{operationId}]` */
  getOperationStatus(operationId: string): Promise<any> {
    return this.c.call('GET', `/api/StorageAccount/operations/${this.c.segment(operationId)}`, undefined, undefined);
  }

  /** Get replication status. `[GET /api/StorageAccount/{id}/replication]` */
  getReplicationStatus(id: string): Promise<any> {
    return this.c.call('GET', `/api/StorageAccount/${this.c.segment(id)}/replication`, undefined, undefined);
  }

  /** Get role assignments. `[GET /api/StorageAccount/{id}/iam]` */
  getRoleAssignments(id: string): Promise<any> {
    return this.c.call('GET', `/api/StorageAccount/${this.c.segment(id)}/iam`, undefined, undefined);
  }

  /** Get role definitions. `[GET /api/StorageAccount/role-definitions]` */
  getRoleDefinitions(): Promise<any> {
    return this.c.call('GET', `/api/StorageAccount/role-definitions`, undefined, undefined);
  }

  /** Get storage account. `[GET /api/StorageAccount/{id}]` */
  getStorageAccount(id: string): Promise<any> {
    return this.c.call('GET', `/api/StorageAccount/${this.c.segment(id)}`, undefined, undefined);
  }

  /** Get storage accounts. `[GET /api/StorageAccount]` */
  getStorageAccounts(): Promise<any> {
    return this.c.call('GET', `/api/StorageAccount`, undefined, undefined);
  }

  /** Get storage stats. `[GET /api/StorageAccount/stats]` */
  getStorageStats(): Promise<any> {
    return this.c.call('GET', `/api/StorageAccount/stats`, undefined, undefined);
  }

  /** Get version history. `[GET /api/StorageAccount/items/{itemId}/versions]` */
  getVersionHistory(itemId: string): Promise<any> {
    return this.c.call('GET', `/api/StorageAccount/items/${this.c.segment(itemId)}/versions`, undefined, undefined);
  }

  /** Initiate download. `[POST /api/StorageAccount/download]` */
  initiateDownload(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/StorageAccount/download`, body, undefined);
  }

  /** Initiate upload. `[POST /api/StorageAccount/upload]` */
  initiateUpload(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/StorageAccount/upload`, body, undefined);
  }

  /** List items. `[GET /api/StorageAccount/{id}/items]` */
  listItems(id: string, query: { "path"?: unknown; "parentId"?: unknown; "storageNamespace"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/StorageAccount/${this.c.segment(id)}/items`, undefined, query);
  }

  /** List queues. `[GET /api/StorageAccount/{id}/queues]` */
  listQueues(id: string): Promise<any> {
    return this.c.call('GET', `/api/StorageAccount/${this.c.segment(id)}/queues`, undefined, undefined);
  }

  /** List tables. `[GET /api/StorageAccount/{id}/tables]` */
  listTables(id: string): Promise<any> {
    return this.c.call('GET', `/api/StorageAccount/${this.c.segment(id)}/tables`, undefined, undefined);
  }

  /** Move item. `[PUT /api/StorageAccount/items/move]` */
  moveItem(body?: unknown): Promise<any> {
    return this.c.call('PUT', `/api/StorageAccount/items/move`, body, undefined);
  }

  /** Regenerate access key. `[POST /api/StorageAccount/{id}/keys/{keyNumber}/regenerate]` */
  regenerateAccessKey(id: string, keyNumber: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/StorageAccount/${this.c.segment(id)}/keys/${this.c.segment(keyNumber)}/regenerate`, body, undefined);
  }

  /** Release lock. `[DELETE /api/StorageAccount/items/{itemId}/lock]` */
  releaseLock(itemId: string): Promise<any> {
    return this.c.call('DELETE', `/api/StorageAccount/items/${this.c.segment(itemId)}/lock`, undefined, undefined);
  }

  /** Remove role assignment. `[DELETE /api/StorageAccount/{id}/iam/{assignmentId}]` */
  removeRoleAssignment(id: string, assignmentId: string, query: { "principalEmail"?: unknown; "role"?: unknown } = {}): Promise<any> {
    return this.c.call('DELETE', `/api/StorageAccount/${this.c.segment(id)}/iam/${this.c.segment(assignmentId)}`, undefined, query);
  }

  /** Remove share. `[DELETE /api/StorageAccount/shares/{shareId}]` */
  removeShare(shareId: string): Promise<any> {
    return this.c.call('DELETE', `/api/StorageAccount/shares/${this.c.segment(shareId)}`, undefined, undefined);
  }

  /** Rename item. `[PUT /api/StorageAccount/items/rename]` */
  renameItem(body?: unknown): Promise<any> {
    return this.c.call('PUT', `/api/StorageAccount/items/rename`, body, undefined);
  }

  /** Restore backup. `[POST /api/StorageAccount/{id}/backups/{backupId}/restore]` */
  restoreBackup(id: string, backupId: string): Promise<any> {
    return this.c.call('POST', `/api/StorageAccount/${this.c.segment(id)}/backups/${this.c.segment(backupId)}/restore`, undefined, undefined);
  }

  /** Restore version. `[POST /api/StorageAccount/items/versions/restore]` */
  restoreVersion(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/StorageAccount/items/versions/restore`, body, undefined);
  }

  /** Run lifecycle rules. `[POST /api/StorageAccount/{id}/lifecycle/run]` */
  runLifecycleRules(id: string): Promise<any> {
    return this.c.call('POST', `/api/StorageAccount/${this.c.segment(id)}/lifecycle/run`, undefined, undefined);
  }

  /** Save item content. `[PUT /api/StorageAccount/items/{itemId}/content]` */
  saveItemContent(itemId: string, body?: unknown): Promise<any> {
    return this.c.call('PUT', `/api/StorageAccount/items/${this.c.segment(itemId)}/content`, body, undefined);
  }

  /** Search items. `[GET /api/StorageAccount/{id}/items/search]` */
  searchItems(id: string, query: { "q"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/StorageAccount/${this.c.segment(id)}/items/search`, undefined, query);
  }

  /** Set default storage account. `[PUT /api/StorageAccount/{id}/default]` */
  setDefaultStorageAccount(id: string): Promise<any> {
    return this.c.call('PUT', `/api/StorageAccount/${this.c.segment(id)}/default`, undefined, undefined);
  }

  /** Share item. `[POST /api/StorageAccount/items/share]` */
  shareItem(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/StorageAccount/items/share`, body, undefined);
  }

  /** Update networking. `[PUT /api/StorageAccount/{id}/networking]` */
  updateNetworking(id: string, body?: unknown): Promise<any> {
    return this.c.call('PUT', `/api/StorageAccount/${this.c.segment(id)}/networking`, body, undefined);
  }

  /** Update storage account. `[PUT /api/StorageAccount/{id}]` */
  updateStorageAccount(id: string, body?: unknown): Promise<any> {
    return this.c.call('PUT', `/api/StorageAccount/${this.c.segment(id)}`, body, undefined);
  }

  /** Upload chunk. `[POST /api/StorageAccount/upload/{operationId}/chunk]` */
  uploadChunk(operationId: string, form: Record<string, string> = {}, files: Record<string, FilePart> = {}): Promise<any> {
    return this.c.callMultipart('POST', `/api/StorageAccount/upload/${this.c.segment(operationId)}/chunk`, form, files, undefined);
  }
}

/** StorageData operations. */
export class StorageDataApi {
  constructor(private readonly c: HiokTransport) {}

  /** Clear queue. `[DELETE /api/storageaccount/{accountId}/queues/{queueName}/messages]` */
  clearQueue(accountId: string, queueName: string): Promise<any> {
    return this.c.call('DELETE', `/api/storageaccount/${this.c.segment(accountId)}/queues/${this.c.segment(queueName)}/messages`, undefined, undefined);
  }

  /** Delete entity. `[DELETE /api/storageaccount/{accountId}/tables/{tableName}/entities/{partitionKey}/{rowKey}]` */
  deleteEntity(accountId: string, tableName: string, partitionKey: string, rowKey: string, query: { "ifMatch"?: unknown } = {}): Promise<any> {
    return this.c.call('DELETE', `/api/storageaccount/${this.c.segment(accountId)}/tables/${this.c.segment(tableName)}/entities/${this.c.segment(partitionKey)}/${this.c.segment(rowKey)}`, undefined, query);
  }

  /** Delete message. `[DELETE /api/storageaccount/{accountId}/queues/{queueName}/messages/{messageId}]` */
  deleteMessage(accountId: string, queueName: string, messageId: string, query: { "popReceipt"?: unknown } = {}): Promise<any> {
    return this.c.call('DELETE', `/api/storageaccount/${this.c.segment(accountId)}/queues/${this.c.segment(queueName)}/messages/${this.c.segment(messageId)}`, undefined, query);
  }

  /** Get entity. `[GET /api/storageaccount/{accountId}/tables/{tableName}/entities/{partitionKey}/{rowKey}]` */
  getEntity(accountId: string, tableName: string, partitionKey: string, rowKey: string): Promise<any> {
    return this.c.call('GET', `/api/storageaccount/${this.c.segment(accountId)}/tables/${this.c.segment(tableName)}/entities/${this.c.segment(partitionKey)}/${this.c.segment(rowKey)}`, undefined, undefined);
  }

  /** Insert entity. `[POST /api/storageaccount/{accountId}/tables/{tableName}/entities]` */
  insertEntity(accountId: string, tableName: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/storageaccount/${this.c.segment(accountId)}/tables/${this.c.segment(tableName)}/entities`, body, undefined);
  }

  /** Peek messages. `[GET /api/storageaccount/{accountId}/queues/{queueName}/messages]` */
  peekMessages(accountId: string, queueName: string, query: { "max"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/storageaccount/${this.c.segment(accountId)}/queues/${this.c.segment(queueName)}/messages`, undefined, query);
  }

  /** Query entities. `[GET /api/storageaccount/{accountId}/tables/{tableName}/entities]` */
  queryEntities(accountId: string, tableName: string, query: { "partitionKey"?: unknown; "propertyName"?: unknown; "propertyValue"?: unknown; "take"?: unknown; "continuationRowKey"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/storageaccount/${this.c.segment(accountId)}/tables/${this.c.segment(tableName)}/entities`, undefined, query);
  }

  /** Queue stats. `[GET /api/storageaccount/{accountId}/queues/{queueName}/stats]` */
  queueStats(accountId: string, queueName: string): Promise<any> {
    return this.c.call('GET', `/api/storageaccount/${this.c.segment(accountId)}/queues/${this.c.segment(queueName)}/stats`, undefined, undefined);
  }

  /** Receive messages. `[POST /api/storageaccount/{accountId}/queues/{queueName}/messages/receive]` */
  receiveMessages(accountId: string, queueName: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/storageaccount/${this.c.segment(accountId)}/queues/${this.c.segment(queueName)}/messages/receive`, body, undefined);
  }

  /** Send message. `[POST /api/storageaccount/{accountId}/queues/{queueName}/messages]` */
  sendMessage(accountId: string, queueName: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/storageaccount/${this.c.segment(accountId)}/queues/${this.c.segment(queueName)}/messages`, body, undefined);
  }

  /** Update visibility. `[POST /api/storageaccount/{accountId}/queues/{queueName}/messages/{messageId}/visibility]` */
  updateVisibility(accountId: string, queueName: string, messageId: string, query: { "popReceipt"?: unknown; "visibilityTimeoutSeconds"?: unknown } = {}): Promise<any> {
    return this.c.call('POST', `/api/storageaccount/${this.c.segment(accountId)}/queues/${this.c.segment(queueName)}/messages/${this.c.segment(messageId)}/visibility`, undefined, query);
  }

  /** Upsert entity. `[PUT /api/storageaccount/{accountId}/tables/{tableName}/entities]` */
  upsertEntity(accountId: string, tableName: string, body?: unknown): Promise<any> {
    return this.c.call('PUT', `/api/storageaccount/${this.c.segment(accountId)}/tables/${this.c.segment(tableName)}/entities`, body, undefined);
  }
}

/** StorageObject operations. */
export class StorageObjectApi {
  constructor(private readonly c: HiokTransport) {}

  /** Commit block list. `[POST /api/storageaccount/{accountId}/containers/{container}/blocks/commit]` */
  commitBlockList(accountId: string, container: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/storageaccount/${this.c.segment(accountId)}/containers/${this.c.segment(container)}/blocks/commit`, body, undefined);
  }

  /** Create container. `[POST /api/storageaccount/{accountId}/containers]` */
  createContainer(accountId: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/storageaccount/${this.c.segment(accountId)}/containers`, body, undefined);
  }

  /** Create directory. `[POST /api/storageaccount/{accountId}/containers/{container}/directories]` */
  createDirectory(accountId: string, container: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/storageaccount/${this.c.segment(accountId)}/containers/${this.c.segment(container)}/directories`, body, undefined);
  }

  /** Create file share. `[POST /api/storageaccount/{accountId}/fileshares]` */
  createFileShare(accountId: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/storageaccount/${this.c.segment(accountId)}/fileshares`, body, undefined);
  }

  /** Delete container. `[DELETE /api/storageaccount/{accountId}/containers/{name}]` */
  deleteContainer(accountId: string, name: string, query: { "force"?: unknown } = {}): Promise<any> {
    return this.c.call('DELETE', `/api/storageaccount/${this.c.segment(accountId)}/containers/${this.c.segment(name)}`, undefined, query);
  }

  /** Delete file share. `[DELETE /api/storageaccount/{accountId}/fileshares/{name}]` */
  deleteFileShare(accountId: string, name: string, query: { "force"?: unknown } = {}): Promise<any> {
    return this.c.call('DELETE', `/api/storageaccount/${this.c.segment(accountId)}/fileshares/${this.c.segment(name)}`, undefined, query);
  }

  /** Delete object. `[DELETE /api/storageaccount/{accountId}/containers/{container}/objects/{key}]` */
  deleteObject(accountId: string, container: string, key: string): Promise<any> {
    return this.c.call('DELETE', `/api/storageaccount/${this.c.segment(accountId)}/containers/${this.c.segment(container)}/objects/${this.c.segment(key, true)}`, undefined, undefined);
  }

  /** Get block list. `[GET /api/storageaccount/{accountId}/containers/{container}/blocks]` */
  getBlockList(accountId: string, container: string, query: { "blobName"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/storageaccount/${this.c.segment(accountId)}/containers/${this.c.segment(container)}/blocks`, undefined, query);
  }

  /** Get container. `[GET /api/storageaccount/{accountId}/containers/{name}]` */
  getContainer(accountId: string, name: string): Promise<any> {
    return this.c.call('GET', `/api/storageaccount/${this.c.segment(accountId)}/containers/${this.c.segment(name)}`, undefined, undefined);
  }

  /** Get object. `[GET /api/storageaccount/{accountId}/containers/{container}/objects/{key}]` */
  getObject(accountId: string, container: string, key: string): Promise<any> {
    return this.c.call('GET', `/api/storageaccount/${this.c.segment(accountId)}/containers/${this.c.segment(container)}/objects/${this.c.segment(key, true)}`, undefined, undefined);
  }

  /** Get object content. `[GET /api/storageaccount/{accountId}/containers/{container}/content/{key}]` */
  getObjectContent(accountId: string, container: string, key: string): Promise<any> {
    return this.c.call('GET', `/api/storageaccount/${this.c.segment(accountId)}/containers/${this.c.segment(container)}/content/${this.c.segment(key, true)}`, undefined, undefined);
  }

  /** Get replication status. `[GET /api/storageaccount/{accountId}/replication-status]` */
  getReplicationStatus(accountId: string): Promise<any> {
    return this.c.call('GET', `/api/storageaccount/${this.c.segment(accountId)}/replication-status`, undefined, undefined);
  }

  /** List containers. `[GET /api/storageaccount/{accountId}/containers]` */
  listContainers(accountId: string, query: { "kind"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/storageaccount/${this.c.segment(accountId)}/containers`, undefined, query);
  }

  /** List file shares. `[GET /api/storageaccount/{accountId}/fileshares]` */
  listFileShares(accountId: string): Promise<any> {
    return this.c.call('GET', `/api/storageaccount/${this.c.segment(accountId)}/fileshares`, undefined, undefined);
  }

  /** List objects. `[GET /api/storageaccount/{accountId}/containers/{container}/objects]` */
  listObjects(accountId: string, container: string, query: { "prefix"?: unknown; "path"?: unknown; "limit"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/storageaccount/${this.c.segment(accountId)}/containers/${this.c.segment(container)}/objects`, undefined, query);
  }

  /** Put object. `[PUT /api/storageaccount/{accountId}/containers/{container}/objects]` */
  putObject(accountId: string, container: string, body?: unknown): Promise<any> {
    return this.c.call('PUT', `/api/storageaccount/${this.c.segment(accountId)}/containers/${this.c.segment(container)}/objects`, body, undefined);
  }

  /** Reconcile. `[POST /api/storageaccount/{accountId}/replication-status/reconcile]` */
  reconcile(accountId: string): Promise<any> {
    return this.c.call('POST', `/api/storageaccount/${this.c.segment(accountId)}/replication-status/reconcile`, undefined, undefined);
  }

  /** Rename path. `[POST /api/storageaccount/{accountId}/containers/{container}/rename]` */
  renamePath(accountId: string, container: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/storageaccount/${this.c.segment(accountId)}/containers/${this.c.segment(container)}/rename`, body, undefined);
  }

  /** Set access control. `[PUT /api/storageaccount/{accountId}/containers/{container}/access-control]` */
  setAccessControl(accountId: string, container: string, body?: unknown): Promise<any> {
    return this.c.call('PUT', `/api/storageaccount/${this.c.segment(accountId)}/containers/${this.c.segment(container)}/access-control`, body, undefined);
  }

  /** Stage block. `[PUT /api/storageaccount/{accountId}/containers/{container}/blocks]` */
  stageBlock(accountId: string, container: string, body?: unknown): Promise<any> {
    return this.c.call('PUT', `/api/storageaccount/${this.c.segment(accountId)}/containers/${this.c.segment(container)}/blocks`, body, undefined);
  }

  /** Update container. `[PUT /api/storageaccount/{accountId}/containers/{name}]` */
  updateContainer(accountId: string, name: string, body?: unknown): Promise<any> {
    return this.c.call('PUT', `/api/storageaccount/${this.c.segment(accountId)}/containers/${this.c.segment(name)}`, body, undefined);
  }
}

/** StreamAnalytics operations. */
export class StreamAnalyticsApi {
  constructor(private readonly c: HiokTransport) {}

  /** Add input. `[POST /api/StreamAnalytics/{id}/inputs]` */
  addInput(id: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/StreamAnalytics/${this.c.segment(id)}/inputs`, body, undefined);
  }

  /** Add output. `[POST /api/StreamAnalytics/{id}/outputs]` */
  addOutput(id: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/StreamAnalytics/${this.c.segment(id)}/outputs`, body, undefined);
  }

  /** Apply transform. `[POST /api/StreamAnalytics/{id}/transform/apply]` */
  applyTransform(id: string): Promise<any> {
    return this.c.call('POST', `/api/StreamAnalytics/${this.c.segment(id)}/transform/apply`, undefined, undefined);
  }

  /** Bindings. `[GET /api/StreamAnalytics/bindings]` */
  bindings(query: { "connector"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/StreamAnalytics/bindings`, undefined, query);
  }

  /** Catalog. `[GET /api/StreamAnalytics/catalog]` */
  catalog(): Promise<any> {
    return this.c.call('GET', `/api/StreamAnalytics/catalog`, undefined, undefined);
  }

  /** Connection. `[GET /api/StreamAnalytics/{id}/connection]` */
  connection(id: string): Promise<any> {
    return this.c.call('GET', `/api/StreamAnalytics/${this.c.segment(id)}/connection`, undefined, undefined);
  }

  /** Create. `[POST /api/StreamAnalytics]` */
  create(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/StreamAnalytics`, body, undefined);
  }

  /** Delete. `[DELETE /api/StreamAnalytics/{id}]` */
  delete_(id: string): Promise<any> {
    return this.c.call('DELETE', `/api/StreamAnalytics/${this.c.segment(id)}`, undefined, undefined);
  }

  /** Delete input. `[DELETE /api/StreamAnalytics/{id}/inputs/{inputId}]` */
  deleteInput(id: string, inputId: string): Promise<any> {
    return this.c.call('DELETE', `/api/StreamAnalytics/${this.c.segment(id)}/inputs/${this.c.segment(inputId)}`, undefined, undefined);
  }

  /** Delete output. `[DELETE /api/StreamAnalytics/{id}/outputs/{outputId}]` */
  deleteOutput(id: string, outputId: string): Promise<any> {
    return this.c.call('DELETE', `/api/StreamAnalytics/${this.c.segment(id)}/outputs/${this.c.segment(outputId)}`, undefined, undefined);
  }

  /** Get. `[GET /api/StreamAnalytics/{id}]` */
  get(id: string): Promise<any> {
    return this.c.call('GET', `/api/StreamAnalytics/${this.c.segment(id)}`, undefined, undefined);
  }

  /** Inputs. `[GET /api/StreamAnalytics/{id}/inputs]` */
  inputs(id: string): Promise<any> {
    return this.c.call('GET', `/api/StreamAnalytics/${this.c.segment(id)}/inputs`, undefined, undefined);
  }

  /** List. `[GET /api/StreamAnalytics]` */
  list(): Promise<any> {
    return this.c.call('GET', `/api/StreamAnalytics`, undefined, undefined);
  }

  /** Logs. `[GET /api/StreamAnalytics/{id}/logs]` */
  logs(id: string, query: { "role"?: unknown; "tail"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/StreamAnalytics/${this.c.segment(id)}/logs`, undefined, query);
  }

  /** Metrics. `[GET /api/StreamAnalytics/{id}/metrics]` */
  metrics(id: string): Promise<any> {
    return this.c.call('GET', `/api/StreamAnalytics/${this.c.segment(id)}/metrics`, undefined, undefined);
  }

  /** Outputs. `[GET /api/StreamAnalytics/{id}/outputs]` */
  outputs(id: string): Promise<any> {
    return this.c.call('GET', `/api/StreamAnalytics/${this.c.segment(id)}/outputs`, undefined, undefined);
  }

  /** Query. `[POST /api/StreamAnalytics/{id}/query]` */
  query(id: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/StreamAnalytics/${this.c.segment(id)}/query`, body, undefined);
  }

  /** Query history. `[GET /api/StreamAnalytics/{id}/query/history]` */
  queryHistory(id: string, query: { "take"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/StreamAnalytics/${this.c.segment(id)}/query/history`, undefined, query);
  }

  /** Start. `[POST /api/StreamAnalytics/{id}/start]` */
  start(id: string): Promise<any> {
    return this.c.call('POST', `/api/StreamAnalytics/${this.c.segment(id)}/start`, undefined, undefined);
  }

  /** Status. `[GET /api/StreamAnalytics/{id}/status]` */
  status(id: string): Promise<any> {
    return this.c.call('GET', `/api/StreamAnalytics/${this.c.segment(id)}/status`, undefined, undefined);
  }

  /** Stop. `[POST /api/StreamAnalytics/{id}/stop]` */
  stop(id: string): Promise<any> {
    return this.c.call('POST', `/api/StreamAnalytics/${this.c.segment(id)}/stop`, undefined, undefined);
  }

  /** Transform. `[GET /api/StreamAnalytics/{id}/transform]` */
  transform(id: string): Promise<any> {
    return this.c.call('GET', `/api/StreamAnalytics/${this.c.segment(id)}/transform`, undefined, undefined);
  }

  /** Update. `[PATCH /api/StreamAnalytics/{id}]` */
  update(id: string, body?: unknown): Promise<any> {
    return this.c.call('PATCH', `/api/StreamAnalytics/${this.c.segment(id)}`, body, undefined);
  }
}

/** StreamPipeline operations. */
export class StreamPipelineApi {
  constructor(private readonly c: HiokTransport) {}

  /** Create. `[POST /api/StreamAnalytics/{jobId}/pipelines]` */
  create(jobId: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/StreamAnalytics/${this.c.segment(jobId)}/pipelines`, body, undefined);
  }

  /** Delete. `[DELETE /api/StreamAnalytics/{jobId}/pipelines/{pipelineId}]` */
  delete_(jobId: string, pipelineId: string): Promise<any> {
    return this.c.call('DELETE', `/api/StreamAnalytics/${this.c.segment(jobId)}/pipelines/${this.c.segment(pipelineId)}`, undefined, undefined);
  }

  /** Get. `[GET /api/StreamAnalytics/{jobId}/pipelines/{pipelineId}]` */
  get(jobId: string, pipelineId: string): Promise<any> {
    return this.c.call('GET', `/api/StreamAnalytics/${this.c.segment(jobId)}/pipelines/${this.c.segment(pipelineId)}`, undefined, undefined);
  }

  /** Get run. `[GET /api/StreamAnalytics/{jobId}/pipelines/runs/{runId}]` */
  getRun(jobId: string, runId: string): Promise<any> {
    return this.c.call('GET', `/api/StreamAnalytics/${this.c.segment(jobId)}/pipelines/runs/${this.c.segment(runId)}`, undefined, undefined);
  }

  /** List. `[GET /api/StreamAnalytics/{jobId}/pipelines]` */
  list(jobId: string): Promise<any> {
    return this.c.call('GET', `/api/StreamAnalytics/${this.c.segment(jobId)}/pipelines`, undefined, undefined);
  }

  /** Preview schedule. `[GET /api/StreamAnalytics/schedule-preview]` */
  previewSchedule(query: { "cron"?: unknown; "timeZone"?: unknown; "count"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/StreamAnalytics/schedule-preview`, undefined, query);
  }

  /** Run. `[POST /api/StreamAnalytics/{jobId}/pipelines/{pipelineId}/run]` */
  run(jobId: string, pipelineId: string): Promise<any> {
    return this.c.call('POST', `/api/StreamAnalytics/${this.c.segment(jobId)}/pipelines/${this.c.segment(pipelineId)}/run`, undefined, undefined);
  }

  /** Runs. `[GET /api/StreamAnalytics/{jobId}/pipelines/{pipelineId}/runs]` */
  runs(jobId: string, pipelineId: string, query: { "limit"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/StreamAnalytics/${this.c.segment(jobId)}/pipelines/${this.c.segment(pipelineId)}/runs`, undefined, query);
  }

  /** Update. `[PUT /api/StreamAnalytics/{jobId}/pipelines/{pipelineId}]` */
  update(jobId: string, pipelineId: string, body?: unknown): Promise<any> {
    return this.c.call('PUT', `/api/StreamAnalytics/${this.c.segment(jobId)}/pipelines/${this.c.segment(pipelineId)}`, body, undefined);
  }
}

/** Streaming operations. */
export class StreamingApi {
  constructor(private readonly c: HiokTransport) {}

  /** Add destination. `[POST /api/streaming/{id}/destinations]` */
  addDestination(id: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/streaming/${this.c.segment(id)}/destinations`, body, undefined);
  }

  /** Create. `[POST /api/streaming]` */
  create(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/streaming`, body, undefined);
  }

  /** Delete. `[DELETE /api/streaming/{id}]` */
  delete_(id: string): Promise<any> {
    return this.c.call('DELETE', `/api/streaming/${this.c.segment(id)}`, undefined, undefined);
  }

  /** Delete destination. `[DELETE /api/streaming/destinations/{destinationId}]` */
  deleteDestination(destinationId: string): Promise<any> {
    return this.c.call('DELETE', `/api/streaming/destinations/${this.c.segment(destinationId)}`, undefined, undefined);
  }

  /** Destinations. `[GET /api/streaming/{id}/destinations]` */
  destinations(id: string, query: { "refresh"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/streaming/${this.c.segment(id)}/destinations`, undefined, query);
  }

  /** Get. `[GET /api/streaming/{id}]` */
  get(id: string): Promise<any> {
    return this.c.call('GET', `/api/streaming/${this.c.segment(id)}`, undefined, undefined);
  }

  /** List. `[GET /api/streaming]` */
  list(): Promise<any> {
    return this.c.call('GET', `/api/streaming`, undefined, undefined);
  }

  /** Platforms. `[GET /api/streaming/platforms]` */
  platforms(): Promise<any> {
    return this.c.call('GET', `/api/streaming/platforms`, undefined, undefined);
  }

  /** Sync destinations. `[POST /api/streaming/{id}/destinations/sync]` */
  syncDestinations(id: string): Promise<any> {
    return this.c.call('POST', `/api/streaming/${this.c.segment(id)}/destinations/sync`, undefined, undefined);
  }

  /** Update destination. `[PUT /api/streaming/destinations/{destinationId}]` */
  updateDestination(destinationId: string, body?: unknown): Promise<any> {
    return this.c.call('PUT', `/api/streaming/destinations/${this.c.segment(destinationId)}`, body, undefined);
  }
}

/** Subscription operations. */
export class SubscriptionApi {
  constructor(private readonly c: HiokTransport) {}

  /** Active subscriptions. `[GET /api/Subscription/activesubscriptions]` */
  activeSubscriptions(): Promise<any> {
    return this.c.call('GET', `/api/Subscription/activesubscriptions`, undefined, undefined);
  }

  /** Add subscriptionto user. `[POST /api/Subscription/addsubscriptiontouser]` */
  addSubscriptiontoUser(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/Subscription/addsubscriptiontouser`, body, undefined);
  }

  /** Create subscription. `[POST /api/Subscription/createsubscriptions]` */
  createSubscription(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/Subscription/createsubscriptions`, body, undefined);
  }

  /** Create user subscription. `[POST /api/Subscription/createsubscription]` */
  createUserSubscription(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/Subscription/createsubscription`, body, undefined);
  }

  /** Delete subscription by id. `[DELETE /api/Subscription/removesubscription/{id}]` */
  deleteSubscriptionById(id: string): Promise<any> {
    return this.c.call('DELETE', `/api/Subscription/removesubscription/${this.c.segment(id)}`, undefined, undefined);
  }

  /** My subscriptions. `[GET /api/Subscription/mysubscriptions]` */
  mySubscriptions(): Promise<any> {
    return this.c.call('GET', `/api/Subscription/mysubscriptions`, undefined, undefined);
  }

  /** Subscriptions. `[GET /api/Subscription/subscriptions]` */
  subscriptions(): Promise<any> {
    return this.c.call('GET', `/api/Subscription/subscriptions`, undefined, undefined);
  }
}

/** Support operations. */
export class SupportApi {
  constructor(private readonly c: HiokTransport) {}

  /** Close. `[POST /api/support/tickets/{id}/close]` */
  close(id: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/support/tickets/${this.c.segment(id)}/close`, body, undefined);
  }

  /** Mine. `[GET /api/support/tickets]` */
  mine(): Promise<any> {
    return this.c.call('GET', `/api/support/tickets`, undefined, undefined);
  }

  /** Raise. `[POST /api/support/tickets]` */
  raise(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/support/tickets`, body, undefined);
  }
}

/** SupportQueue operations. */
export class SupportQueueApi {
  constructor(private readonly c: HiokTransport) {}

  /** Queue. `[GET /api/admin/support]` */
  queue(query: { "status"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/admin/support`, undefined, query);
  }

  /** Update. `[PUT /api/admin/support/{id}]` */
  update(id: string, body?: unknown): Promise<any> {
    return this.c.call('PUT', `/api/admin/support/${this.c.segment(id)}`, body, undefined);
  }
}

/** Upload operations. */
export class UploadApi {
  constructor(private readonly c: HiokTransport) {}

  /** Finalize upload. `[POST /api/Upload/finalizeupload]` */
  finalizeUpload(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/Upload/finalizeupload`, body, undefined);
  }

  /** Initiate upload. `[POST /api/Upload/initiateupload]` */
  initiateUpload(form: Record<string, string> = {}, files: Record<string, FilePart> = {}, query: { "uploadDirPath"?: unknown; "folderDirPath"?: unknown } = {}): Promise<any> {
    return this.c.callMultipart('POST', `/api/Upload/initiateupload`, form, files, query);
  }

  /** Upload chunk. `[POST /api/Upload/uploadchunk]` */
  uploadChunk(form: Record<string, string> = {}, files: Record<string, FilePart> = {}, query: { "directoryName"?: unknown; "chunkindex"?: unknown; "uploadDirPath"?: unknown; "folderDirPath"?: unknown } = {}): Promise<any> {
    return this.c.callMultipart('POST', `/api/Upload/uploadchunk`, form, files, query);
  }
}

/** VPNGateway operations. */
export class VPNGatewayApi {
  constructor(private readonly c: HiokTransport) {}

  /** Create p2 sclient. `[POST /api/VPNGateway/clients/p2s]` */
  createP2SClient(body?: unknown, query: { "region"?: unknown } = {}): Promise<any> {
    return this.c.call('POST', `/api/VPNGateway/clients/p2s`, body, query);
  }

  /** Create s2 sconnection. `[POST /api/VPNGateway/connections/s2s]` */
  createS2SConnection(body?: unknown, query: { "region"?: unknown } = {}): Promise<any> {
    return this.c.call('POST', `/api/VPNGateway/connections/s2s`, body, query);
  }

  /** Create vpngateway. `[POST /api/VPNGateway/create]` */
  createVPNGateway(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/VPNGateway/create`, body, undefined);
  }

  /** Delete s2 sconnection. `[DELETE /api/VPNGateway/connections/s2s/{connectionId}]` */
  deleteS2SConnection(connectionId: string, query: { "region"?: unknown } = {}): Promise<any> {
    return this.c.call('DELETE', `/api/VPNGateway/connections/s2s/${this.c.segment(connectionId)}`, undefined, query);
  }

  /** Delete vpngateway. `[DELETE /api/VPNGateway/{gatewayId}]` */
  deleteVPNGateway(gatewayId: string, query: { "gatewayName"?: unknown; "region"?: unknown } = {}): Promise<any> {
    return this.c.call('DELETE', `/api/VPNGateway/${this.c.segment(gatewayId)}`, undefined, query);
  }

  /** Download client config. `[GET /api/VPNGateway/clients/p2s/{clientId}/config]` */
  downloadClientConfig(clientId: string, query: { "region"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/VPNGateway/clients/p2s/${this.c.segment(clientId)}/config`, undefined, query);
  }

  /** Get connected clients. `[GET /api/VPNGateway/{gatewayId}/clients/p2s/connected]` */
  getConnectedClients(gatewayId: string, query: { "region"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/VPNGateway/${this.c.segment(gatewayId)}/clients/p2s/connected`, undefined, query);
  }

  /** Get s2 sconnection status. `[GET /api/VPNGateway/connections/s2s/{connectionId}/status]` */
  getS2SConnectionStatus(connectionId: string, query: { "region"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/VPNGateway/connections/s2s/${this.c.segment(connectionId)}/status`, undefined, query);
  }

  /** Get vpngateway. `[GET /api/VPNGateway/{gatewayId}]` */
  getVPNGateway(gatewayId: string): Promise<any> {
    return this.c.call('GET', `/api/VPNGateway/${this.c.segment(gatewayId)}`, undefined, undefined);
  }

  /** Get vpngateway status. `[GET /api/VPNGateway/{gatewayId}/status]` */
  getVPNGatewayStatus(gatewayId: string, query: { "region"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/VPNGateway/${this.c.segment(gatewayId)}/status`, undefined, query);
  }

  /** List p2 sclients. `[GET /api/VPNGateway/{gatewayId}/clients/p2s]` */
  listP2SClients(gatewayId: string): Promise<any> {
    return this.c.call('GET', `/api/VPNGateway/${this.c.segment(gatewayId)}/clients/p2s`, undefined, undefined);
  }

  /** List s2 sconnections. `[GET /api/VPNGateway/{gatewayId}/connections/s2s]` */
  listS2SConnections(gatewayId: string): Promise<any> {
    return this.c.call('GET', `/api/VPNGateway/${this.c.segment(gatewayId)}/connections/s2s`, undefined, undefined);
  }

  /** List vpngateways. `[GET /api/VPNGateway/list]` */
  listVPNGateways(query: { "vnetId"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/VPNGateway/list`, undefined, query);
  }

  /** Revoke p2 sclient. `[DELETE /api/VPNGateway/clients/p2s/{clientId}]` */
  revokeP2SClient(clientId: string, query: { "region"?: unknown } = {}): Promise<any> {
    return this.c.call('DELETE', `/api/VPNGateway/clients/p2s/${this.c.segment(clientId)}`, undefined, query);
  }
}

/** VXLAN operations. */
export class VXLANApi {
  constructor(private readonly c: HiokTransport) {}

  /** Add vtep. `[POST /api/VXLAN/tunnels/{tunnelId}/vteps]` */
  addVtep(tunnelId: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/VXLAN/tunnels/${this.c.segment(tunnelId)}/vteps`, body, undefined);
  }

  /** Create tunnel. `[POST /api/VXLAN/tunnels]` */
  createTunnel(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/VXLAN/tunnels`, body, undefined);
  }

  /** Delete tunnel. `[DELETE /api/VXLAN/tunnels/{tunnelId}]` */
  deleteTunnel(tunnelId: string): Promise<any> {
    return this.c.call('DELETE', `/api/VXLAN/tunnels/${this.c.segment(tunnelId)}`, undefined, undefined);
  }

  /** Get tunnel. `[GET /api/VXLAN/tunnels/{tunnelId}]` */
  getTunnel(tunnelId: string): Promise<any> {
    return this.c.call('GET', `/api/VXLAN/tunnels/${this.c.segment(tunnelId)}`, undefined, undefined);
  }

  /** List tunnels. `[GET /api/VXLAN/tunnels]` */
  listTunnels(): Promise<any> {
    return this.c.call('GET', `/api/VXLAN/tunnels`, undefined, undefined);
  }

  /** Remove vtep. `[DELETE /api/VXLAN/tunnels/{tunnelId}/vteps/{vtepIp}]` */
  removeVtep(tunnelId: string, vtepIp: string): Promise<any> {
    return this.c.call('DELETE', `/api/VXLAN/tunnels/${this.c.segment(tunnelId)}/vteps/${this.c.segment(vtepIp)}`, undefined, undefined);
  }
}

/** VirtualMachine operations. */
export class VirtualMachineApi {
  constructor(private readonly c: HiokTransport) {}

  /** Create vm. `[POST /api/VirtualMachine/create-vm]` */
  createVM(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/VirtualMachine/create-vm`, body, undefined);
  }

  /** Destroy vm. `[DELETE /api/VirtualMachine/destroy-vm]` */
  destroyVM(body?: unknown): Promise<any> {
    return this.c.call('DELETE', `/api/VirtualMachine/destroy-vm`, body, undefined);
  }

  /** Get ssh private key. `[GET /api/VirtualMachine/{id}/sshkey]` */
  getSshPrivateKey(id: string): Promise<any> {
    return this.c.call('GET', `/api/VirtualMachine/${this.c.segment(id)}/sshkey`, undefined, undefined);
  }

  /** Get vminfo. `[GET /api/VirtualMachine/vm-info]` */
  getVMInfo(query: { "vmName"?: unknown; "regions"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/VirtualMachine/vm-info`, undefined, query);
  }

  /** List local vmimages. `[GET /api/VirtualMachine/list-local-vm-images]` */
  listLocalVMImages(query: { "regions"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/VirtualMachine/list-local-vm-images`, undefined, query);
  }

  /** List running vms. `[GET /api/VirtualMachine/list-running-vms]` */
  listRunningVMs(query: { "regions"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/VirtualMachine/list-running-vms`, undefined, query);
  }

  /** List vms. `[GET /api/VirtualMachine/list-vms]` */
  listVMs(query: { "regions"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/VirtualMachine/list-vms`, undefined, query);
  }

  /** List vms info. `[GET /api/VirtualMachine/list-vms-info]` */
  listVMsInfo(query: { "regions"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/VirtualMachine/list-vms-info`, undefined, query);
  }

  /** Reset password. `[POST /api/VirtualMachine/reset-password]` */
  resetPassword(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/VirtualMachine/reset-password`, body, undefined);
  }

  /** Start vm. `[POST /api/VirtualMachine/start-vm]` */
  startVM(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/VirtualMachine/start-vm`, body, undefined);
  }

  /** Stop vm. `[POST /api/VirtualMachine/stop-vm]` */
  stopVM(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/VirtualMachine/stop-vm`, body, undefined);
  }
}

/** VirtualNetwork operations. */
export class VirtualNetworkApi {
  constructor(private readonly c: HiokTransport) {}

  /** Create vnet. `[POST /api/VirtualNetwork/create-vnet]` */
  createVNet(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/VirtualNetwork/create-vnet`, body, undefined);
  }

  /** Create vnet peering. `[POST /api/VirtualNetwork/{vnetId}/peerings]` */
  createVnetPeering(vnetId: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/VirtualNetwork/${this.c.segment(vnetId)}/peerings`, body, undefined);
  }

  /** Delete vnet peering. `[DELETE /api/VirtualNetwork/{vnetId}/peerings/{peeringId}]` */
  deleteVnetPeering(vnetId: string, peeringId: string): Promise<any> {
    return this.c.call('DELETE', `/api/VirtualNetwork/${this.c.segment(vnetId)}/peerings/${this.c.segment(peeringId)}`, undefined, undefined);
  }

  /** Delete vnet subnet. `[DELETE /api/VirtualNetwork/{vnetId}/subnets/{subnetId}]` */
  deleteVnetSubnet(vnetId: string, subnetId: string): Promise<any> {
    return this.c.call('DELETE', `/api/VirtualNetwork/${this.c.segment(vnetId)}/subnets/${this.c.segment(subnetId)}`, undefined, undefined);
  }

  /** Destroy vnet. `[DELETE /api/VirtualNetwork/delete-vnet]` */
  destroyVNet(body?: unknown): Promise<any> {
    return this.c.call('DELETE', `/api/VirtualNetwork/delete-vnet`, body, undefined);
  }

  /** List all peerings. `[GET /api/VirtualNetwork/peerings]` */
  listAllPeerings(): Promise<any> {
    return this.c.call('GET', `/api/VirtualNetwork/peerings`, undefined, undefined);
  }

  /** List all subnets. `[GET /api/VirtualNetwork/subnets]` */
  listAllSubnets(): Promise<any> {
    return this.c.call('GET', `/api/VirtualNetwork/subnets`, undefined, undefined);
  }

  /** List vms info. `[GET /api/VirtualNetwork/list-vnets]` */
  listVMsInfo(): Promise<any> {
    return this.c.call('GET', `/api/VirtualNetwork/list-vnets`, undefined, undefined);
  }

  /** List vnet address spaces. `[GET /api/VirtualNetwork/{vnetId}/address-spaces]` */
  listVnetAddressSpaces(vnetId: string): Promise<any> {
    return this.c.call('GET', `/api/VirtualNetwork/${this.c.segment(vnetId)}/address-spaces`, undefined, undefined);
  }

  /** List vnet peerings. `[GET /api/VirtualNetwork/{vnetId}/peerings]` */
  listVnetPeerings(vnetId: string): Promise<any> {
    return this.c.call('GET', `/api/VirtualNetwork/${this.c.segment(vnetId)}/peerings`, undefined, undefined);
  }

  /** List vnet subnets. `[GET /api/VirtualNetwork/{vnetId}/subnets]` */
  listVnetSubnets(vnetId: string): Promise<any> {
    return this.c.call('GET', `/api/VirtualNetwork/${this.c.segment(vnetId)}/subnets`, undefined, undefined);
  }

  /** Save vnet address space. `[PUT /api/VirtualNetwork/{vnetId}/address-spaces]` */
  saveVnetAddressSpace(vnetId: string, body?: unknown): Promise<any> {
    return this.c.call('PUT', `/api/VirtualNetwork/${this.c.segment(vnetId)}/address-spaces`, body, undefined);
  }

  /** Save vnet subnet. `[PUT /api/VirtualNetwork/{vnetId}/subnets]` */
  saveVnetSubnet(vnetId: string, body?: unknown): Promise<any> {
    return this.c.call('PUT', `/api/VirtualNetwork/${this.c.segment(vnetId)}/subnets`, body, undefined);
  }
}

/** VmConsole operations. */
export class VmConsoleApi {
  constructor(private readonly c: HiokTransport) {}

  /** Console. `[GET /api/VirtualMachine/{id}/console]` */
  console(id: string): Promise<any> {
    return this.c.call('GET', `/api/VirtualMachine/${this.c.segment(id)}/console`, undefined, undefined);
  }

  /** Console ticket. `[GET /api/VirtualMachine/{id}/console-ticket]` */
  consoleTicket(id: string): Promise<any> {
    return this.c.call('GET', `/api/VirtualMachine/${this.c.segment(id)}/console-ticket`, undefined, undefined);
  }
}

/** VmNetwork operations. */
export class VmNetworkApi {
  constructor(private readonly c: HiokTransport) {}

  /** Create. `[POST /api/VirtualMachine/{vmName}/network-rules]` */
  create(vmName: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/VirtualMachine/${this.c.segment(vmName)}/network-rules`, body, undefined);
  }

  /** Delete. `[DELETE /api/VirtualMachine/network-rules/{id}]` */
  delete_(id: string): Promise<any> {
    return this.c.call('DELETE', `/api/VirtualMachine/network-rules/${this.c.segment(id)}`, undefined, undefined);
  }

  /** List. `[GET /api/VirtualMachine/{vmName}/network-rules]` */
  list(vmName: string, query: { "type"?: unknown; "direction"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/VirtualMachine/${this.c.segment(vmName)}/network-rules`, undefined, query);
  }

  /** Network info. `[GET /api/VirtualMachine/{vmName}/network-info]` */
  networkInfo(vmName: string): Promise<any> {
    return this.c.call('GET', `/api/VirtualMachine/${this.c.segment(vmName)}/network-info`, undefined, undefined);
  }

  /** Sync. `[POST /api/VirtualMachine/{vmName}/network-rules/sync]` */
  sync(vmName: string): Promise<any> {
    return this.c.call('POST', `/api/VirtualMachine/${this.c.segment(vmName)}/network-rules/sync`, undefined, undefined);
  }

  /** Update. `[PUT /api/VirtualMachine/network-rules/{id}]` */
  update(id: string, body?: unknown): Promise<any> {
    return this.c.call('PUT', `/api/VirtualMachine/network-rules/${this.c.segment(id)}`, body, undefined);
  }
}

/** VmOperations operations. */
export class VmOperationsApi {
  constructor(private readonly c: HiokTransport) {}

  /** Attach nic. `[POST /api/VirtualMachine/{vmName}/nics]` */
  attachNic(vmName: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/VirtualMachine/${this.c.segment(vmName)}/nics`, body, undefined);
  }

  /** Attach public ip. `[POST /api/VirtualMachine/{vmName}/public-ips]` */
  attachPublicIp(vmName: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/VirtualMachine/${this.c.segment(vmName)}/public-ips`, body, undefined);
  }

  /** Connect. `[GET /api/VirtualMachine/{vmName}/connect]` */
  connect(vmName: string): Promise<any> {
    return this.c.call('GET', `/api/VirtualMachine/${this.c.segment(vmName)}/connect`, undefined, undefined);
  }

  /** Create snapshot. `[POST /api/VirtualMachine/{vmName}/snapshots]` */
  createSnapshot(vmName: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/VirtualMachine/${this.c.segment(vmName)}/snapshots`, body, undefined);
  }

  /** Delete snapshot. `[DELETE /api/VirtualMachine/{vmName}/snapshots/{snapshotName}]` */
  deleteSnapshot(vmName: string, snapshotName: string): Promise<any> {
    return this.c.call('DELETE', `/api/VirtualMachine/${this.c.segment(vmName)}/snapshots/${this.c.segment(snapshotName)}`, undefined, undefined);
  }

  /** Detach nic. `[DELETE /api/VirtualMachine/{vmName}/nics/{mac}]` */
  detachNic(vmName: string, mac: string): Promise<any> {
    return this.c.call('DELETE', `/api/VirtualMachine/${this.c.segment(vmName)}/nics/${this.c.segment(mac)}`, undefined, undefined);
  }

  /** Detach public ip. `[DELETE /api/VirtualMachine/{vmName}/public-ips/{allocationId}]` */
  detachPublicIp(vmName: string, allocationId: string): Promise<any> {
    return this.c.call('DELETE', `/api/VirtualMachine/${this.c.segment(vmName)}/public-ips/${this.c.segment(allocationId)}`, undefined, undefined);
  }

  /** List nics. `[GET /api/VirtualMachine/{vmName}/nics]` */
  listNics(vmName: string): Promise<any> {
    return this.c.call('GET', `/api/VirtualMachine/${this.c.segment(vmName)}/nics`, undefined, undefined);
  }

  /** List public ips. `[GET /api/VirtualMachine/{vmName}/public-ips]` */
  listPublicIps(vmName: string): Promise<any> {
    return this.c.call('GET', `/api/VirtualMachine/${this.c.segment(vmName)}/public-ips`, undefined, undefined);
  }

  /** List snapshots. `[GET /api/VirtualMachine/{vmName}/snapshots]` */
  listSnapshots(vmName: string): Promise<any> {
    return this.c.call('GET', `/api/VirtualMachine/${this.c.segment(vmName)}/snapshots`, undefined, undefined);
  }

  /** Rdp file. `[GET /api/VirtualMachine/{vmName}/rdp-file]` */
  rdpFile(vmName: string): Promise<any> {
    return this.c.call('GET', `/api/VirtualMachine/${this.c.segment(vmName)}/rdp-file`, undefined, undefined);
  }

  /** Restore snapshot. `[POST /api/VirtualMachine/{vmName}/snapshots/{snapshotName}/restore]` */
  restoreSnapshot(vmName: string, snapshotName: string): Promise<any> {
    return this.c.call('POST', `/api/VirtualMachine/${this.c.segment(vmName)}/snapshots/${this.c.segment(snapshotName)}/restore`, undefined, undefined);
  }

  /** Ssh key. `[GET /api/VirtualMachine/{vmName}/ssh-key]` */
  sshKey(vmName: string): Promise<any> {
    return this.c.call('GET', `/api/VirtualMachine/${this.c.segment(vmName)}/ssh-key`, undefined, undefined);
  }
}

/** Webmail operations. */
export class WebmailApi {
  constructor(private readonly c: HiokTransport) {}

  /** Assist. `[POST /api/mail/assist]` */
  assist(body?: unknown, query: { "accountId"?: unknown } = {}): Promise<any> {
    return this.c.call('POST', `/api/mail/assist`, body, query);
  }

  /** Attachment. `[GET /api/mail/messages/{id}/attachments/{attachmentId}]` */
  attachment(id: string, attachmentId: string, query: { "accountId"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/mail/messages/${this.c.segment(id)}/attachments/${this.c.segment(attachmentId)}`, undefined, query);
  }

  /** Change password. `[POST /api/mail/password]` */
  changePassword(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/mail/password`, body, undefined);
  }

  /** Contacts. `[GET /api/mail/contacts]` */
  contacts(query: { "accountId"?: unknown; "q"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/mail/contacts`, undefined, query);
  }

  /** Create filter. `[POST /api/mail/filters]` */
  createFilter(body?: unknown, query: { "accountId"?: unknown } = {}): Promise<any> {
    return this.c.call('POST', `/api/mail/filters`, body, query);
  }

  /** Create folder. `[POST /api/mail/folders]` */
  createFolder(body?: unknown, query: { "accountId"?: unknown } = {}): Promise<any> {
    return this.c.call('POST', `/api/mail/folders`, body, query);
  }

  /** Create label. `[POST /api/mail/labels]` */
  createLabel(body?: unknown, query: { "accountId"?: unknown } = {}): Promise<any> {
    return this.c.call('POST', `/api/mail/labels`, body, query);
  }

  /** Delete. `[POST /api/mail/messages/delete]` */
  delete_(body?: unknown, query: { "accountId"?: unknown } = {}): Promise<any> {
    return this.c.call('POST', `/api/mail/messages/delete`, body, query);
  }

  /** Delete filter. `[DELETE /api/mail/filters/{id}]` */
  deleteFilter(id: string, query: { "accountId"?: unknown } = {}): Promise<any> {
    return this.c.call('DELETE', `/api/mail/filters/${this.c.segment(id)}`, undefined, query);
  }

  /** Drop upload. `[DELETE /api/mail/attachments/{id}]` */
  dropUpload(id: string, query: { "accountId"?: unknown } = {}): Promise<any> {
    return this.c.call('DELETE', `/api/mail/attachments/${this.c.segment(id)}`, undefined, query);
  }

  /** Filters. `[GET /api/mail/filters]` */
  filters(query: { "accountId"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/mail/filters`, undefined, query);
  }

  /** Flag. `[POST /api/mail/messages/flag]` */
  flag(body?: unknown, query: { "accountId"?: unknown } = {}): Promise<any> {
    return this.c.call('POST', `/api/mail/messages/flag`, body, query);
  }

  /** Folders. `[GET /api/mail/folders]` */
  folders(query: { "accountId"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/mail/folders`, undefined, query);
  }

  /** Me. `[GET /api/mail/me]` */
  me(): Promise<any> {
    return this.c.call('GET', `/api/mail/me`, undefined, undefined);
  }

  /** Message. `[GET /api/mail/messages/{id}]` */
  message(id: string, query: { "accountId"?: unknown; "markRead"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/mail/messages/${this.c.segment(id)}`, undefined, query);
  }

  /** Messages. `[GET /api/mail/messages]` */
  messages(query: { "accountId"?: unknown; "folderId"?: unknown; "q"?: unknown; "unread"?: unknown; "starred"?: unknown; "page"?: unknown; "pageSize"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/mail/messages`, undefined, query);
  }

  /** Mine. `[GET /api/mail/mine]` */
  mine(): Promise<any> {
    return this.c.call('GET', `/api/mail/mine`, undefined, undefined);
  }

  /** Move. `[POST /api/mail/messages/move]` */
  move(body?: unknown, query: { "accountId"?: unknown } = {}): Promise<any> {
    return this.c.call('POST', `/api/mail/messages/move`, body, query);
  }

  /** Quote. `[GET /api/mail/messages/{id}/quote]` */
  quote(id: string, query: { "accountId"?: unknown; "forward"?: unknown } = {}): Promise<any> {
    return this.c.call('GET', `/api/mail/messages/${this.c.segment(id)}/quote`, undefined, query);
  }

  /** Save draft. `[POST /api/mail/draft]` */
  saveDraft(body?: unknown, query: { "accountId"?: unknown } = {}): Promise<any> {
    return this.c.call('POST', `/api/mail/draft`, body, query);
  }

  /** Schedule. `[POST /api/mail/schedule]` */
  schedule(body?: unknown, query: { "accountId"?: unknown } = {}): Promise<any> {
    return this.c.call('POST', `/api/mail/schedule`, body, query);
  }

  /** Send. `[POST /api/mail/send]` */
  send(body?: unknown, query: { "accountId"?: unknown } = {}): Promise<any> {
    return this.c.call('POST', `/api/mail/send`, body, query);
  }

  /** Settings. `[PATCH /api/mail/settings]` */
  settings(body?: unknown, query: { "accountId"?: unknown } = {}): Promise<any> {
    return this.c.call('PATCH', `/api/mail/settings`, body, query);
  }

  /** Sign in. `[POST /api/mail/signin]` */
  signIn(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/mail/signin`, body, undefined);
  }

  /** Sign out. `[POST /api/mail/signout]` */
  signOut(): Promise<any> {
    return this.c.call('POST', `/api/mail/signout`, undefined, undefined);
  }

  /** Unschedule. `[POST /api/mail/schedule/{id}/cancel]` */
  unschedule(id: string, query: { "accountId"?: unknown } = {}): Promise<any> {
    return this.c.call('POST', `/api/mail/schedule/${this.c.segment(id)}/cancel`, undefined, query);
  }

  /** Upload. `[POST /api/mail/attachments]` */
  upload(form: Record<string, string> = {}, files: Record<string, FilePart> = {}, query: { "accountId"?: unknown } = {}): Promise<any> {
    return this.c.callMultipart('POST', `/api/mail/attachments`, form, files, query);
  }
}

/** Widget operations. */
export class WidgetApi {
  constructor(private readonly c: HiokTransport) {}

  /** Add widget to panel. `[POST /api/Widget/addwidgettopanel]` */
  addWidgetToPanel(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/Widget/addwidgettopanel`, body, undefined);
  }

  /** Clone widget. `[POST /api/Widget/clonewidget]` */
  cloneWidget(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/Widget/clonewidget`, body, undefined);
  }

  /** Create default widgets. `[POST /api/Widget/createdefaultwidgets]` */
  createDefaultWidgets(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/Widget/createdefaultwidgets`, body, undefined);
  }

  /** Create widget template. `[POST /api/Widget/createwidgettemplate]` */
  createWidgetTemplate(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/Widget/createwidgettemplate`, body, undefined);
  }

  /** Create widgets template. `[POST /api/Widget/createwidgetstemplate]` */
  createWidgetsTemplate(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/Widget/createwidgetstemplate`, body, undefined);
  }

  /** Default widgets. `[GET /api/Widget/defaultwidgets]` */
  defaultWidgets(): Promise<any> {
    return this.c.call('GET', `/api/Widget/defaultwidgets`, undefined, undefined);
  }

  /** Delete widget from panel. `[DELETE /api/Widget/deletepanelwidget]` */
  deleteWidgetFromPanel(body?: unknown): Promise<any> {
    return this.c.call('DELETE', `/api/Widget/deletepanelwidget`, body, undefined);
  }

  /** Delete widget template. `[DELETE /api/Widget/deletewidgettemplate/{id}]` */
  deleteWidgetTemplate(id: string): Promise<any> {
    return this.c.call('DELETE', `/api/Widget/deletewidgettemplate/${this.c.segment(id)}`, undefined, undefined);
  }

  /** Get widget settings. `[POST /api/Widget/getwidgetsettings]` */
  getWidgetSettings(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/Widget/getwidgetsettings`, body, undefined);
  }

  /** Update widget position. `[POST /api/Widget/updatewidgetposition]` */
  updateWidgetPosition(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/Widget/updatewidgetposition`, body, undefined);
  }

  /** Update widget settings. `[POST /api/Widget/updatewidgetsettings]` */
  updateWidgetSettings(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/Widget/updatewidgetsettings`, body, undefined);
  }

  /** Update widget template. `[PUT /api/Widget/updatewidgettemplate/{id}]` */
  updateWidgetTemplate(id: string, body?: unknown): Promise<any> {
    return this.c.call('PUT', `/api/Widget/updatewidgettemplate/${this.c.segment(id)}`, body, undefined);
  }

  /** Widget details. `[POST /api/Widget/widgetdetails]` */
  widgetDetails(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/Widget/widgetdetails`, body, undefined);
  }

  /** Widget library. `[GET /api/Widget/widgetlibrary]` */
  widgetLibrary(): Promise<any> {
    return this.c.call('GET', `/api/Widget/widgetlibrary`, undefined, undefined);
  }

  /** Widget options. `[POST /api/Widget/widgetoptions]` */
  widgetOptions(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/Widget/widgetoptions`, body, undefined);
  }

  /** Widgets. `[POST /api/Widget/widgets]` */
  widgets(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/Widget/widgets`, body, undefined);
  }
}

/** Yugabyte operations. */
export class YugabyteApi {
  constructor(private readonly c: HiokTransport) {}

  /** Attach. `[POST /api/Yugabyte/{id}/vnet/attach]` */
  attach(id: string): Promise<any> {
    return this.c.call('POST', `/api/Yugabyte/${this.c.segment(id)}/vnet/attach`, undefined, undefined);
  }

  /** Columns. `[GET /api/Yugabyte/{id}/tables/{schema}/{table}/columns]` */
  columns(id: string, schema: string, table: string): Promise<any> {
    return this.c.call('GET', `/api/Yugabyte/${this.c.segment(id)}/tables/${this.c.segment(schema)}/${this.c.segment(table)}/columns`, undefined, undefined);
  }

  /** Connection. `[GET /api/Yugabyte/{id}/connection]` */
  connection(id: string): Promise<any> {
    return this.c.call('GET', `/api/Yugabyte/${this.c.segment(id)}/connection`, undefined, undefined);
  }

  /** Create. `[POST /api/Yugabyte]` */
  create(body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/Yugabyte`, body, undefined);
  }

  /** Delete. `[DELETE /api/Yugabyte/{id}]` */
  delete_(id: string): Promise<any> {
    return this.c.call('DELETE', `/api/Yugabyte/${this.c.segment(id)}`, undefined, undefined);
  }

  /** Detach. `[POST /api/Yugabyte/{id}/vnet/detach]` */
  detach(id: string): Promise<any> {
    return this.c.call('POST', `/api/Yugabyte/${this.c.segment(id)}/vnet/detach`, undefined, undefined);
  }

  /** Get. `[GET /api/Yugabyte/{id}]` */
  get(id: string): Promise<any> {
    return this.c.call('GET', `/api/Yugabyte/${this.c.segment(id)}`, undefined, undefined);
  }

  /** List. `[GET /api/Yugabyte]` */
  list(): Promise<any> {
    return this.c.call('GET', `/api/Yugabyte`, undefined, undefined);
  }

  /** Query. `[POST /api/Yugabyte/{id}/query]` */
  query(id: string, body?: unknown): Promise<any> {
    return this.c.call('POST', `/api/Yugabyte/${this.c.segment(id)}/query`, body, undefined);
  }

  /** Start. `[POST /api/Yugabyte/{id}/start]` */
  start(id: string): Promise<any> {
    return this.c.call('POST', `/api/Yugabyte/${this.c.segment(id)}/start`, undefined, undefined);
  }

  /** Stop. `[POST /api/Yugabyte/{id}/stop]` */
  stop(id: string): Promise<any> {
    return this.c.call('POST', `/api/Yugabyte/${this.c.segment(id)}/stop`, undefined, undefined);
  }

  /** Tables. `[GET /api/Yugabyte/{id}/tables]` */
  tables(id: string): Promise<any> {
    return this.c.call('GET', `/api/Yugabyte/${this.c.segment(id)}/tables`, undefined, undefined);
  }
}

/** Every API operation, grouped as the API groups them: `client.api.<group>.<operation>()`. */
export class Api {
  readonly accessControl: AccessControlApi;
  readonly admin: AdminApi;
  readonly adminData: AdminDataApi;
  readonly adminDns: AdminDnsApi;
  readonly adminInfrastructure: AdminInfrastructureApi;
  readonly advisor: AdvisorApi;
  readonly analytics: AnalyticsApi;
  readonly apiManagement: ApiManagementApi;
  readonly assistant: AssistantApi;
  readonly bastion: BastionApi;
  readonly billingWebhook: BillingWebhookApi;
  readonly cache: CacheApi;
  readonly cards: CardsApi;
  readonly cloudShell: CloudShellApi;
  readonly cloudSubscription: CloudSubscriptionApi;
  readonly commonServices: CommonServicesApi;
  readonly communication: CommunicationApi;
  readonly containerApp: ContainerAppApi;
  readonly containerJobs: ContainerJobsApi;
  readonly containerRegistry: ContainerRegistryApi;
  readonly containers: ContainersApi;
  readonly costTracking: CostTrackingApi;
  readonly createResource: CreateResourceApi;
  readonly deployment: DeploymentApi;
  readonly dockerImages: DockerImagesApi;
  readonly downloads: DownloadsApi;
  readonly dps: DpsApi;
  readonly fx: FxApi;
  readonly groups: GroupsApi;
  readonly hierarchyView: HierarchyViewApi;
  readonly hiokCloudGroups: HiokCloudGroupsApi;
  readonly hiokCloudHierarchy: HiokCloudHierarchyApi;
  readonly hiokUsers: HiokUsersApi;
  readonly hybrid: HybridApi;
  readonly identity: IdentityApi;
  readonly infrastructure: InfrastructureApi;
  readonly ioTDeviceGateway: IoTDeviceGatewayApi;
  readonly ioTHub: IoTHubApi;
  readonly ioTHubDevice: IoTHubDeviceApi;
  readonly ioTHubDiagnostics: IoTHubDiagnosticsApi;
  readonly ioTHubManagement: IoTHubManagementApi;
  readonly ioTHubProtocol: IoTHubProtocolApi;
  readonly k9sConsole: K9sConsoleApi;
  readonly keyVault: KeyVaultApi;
  readonly kubernetes: KubernetesApi;
  readonly mailAdmin: MailAdminApi;
  readonly marketplace: MarketplaceApi;
  readonly metrics: MetricsApi;
  readonly mongo: MongoApi;
  readonly mySqlDatabase: MySqlDatabaseApi;
  readonly networkAccess: NetworkAccessApi;
  readonly notification: NotificationApi;
  readonly oAuth: OAuthApi;
  readonly oVS: OVSApi;
  readonly panel: PanelApi;
  readonly postgresDatabase: PostgresDatabaseApi;
  readonly pricing: PricingApi;
  readonly profile: ProfileApi;
  readonly pulse: PulseApi;
  readonly recentResources: RecentResourcesApi;
  readonly resourceGovernance: ResourceGovernanceApi;
  readonly resourceGroups: ResourceGroupsApi;
  readonly resourceMetrics: ResourceMetricsApi;
  readonly resourceOperations: ResourceOperationsApi;
  readonly sandbox: SandboxApi;
  readonly search: SearchApi;
  readonly serviceBus: ServiceBusApi;
  readonly sqlServerDatabase: SqlServerDatabaseApi;
  readonly storage: StorageApi;
  readonly storageAccount: StorageAccountApi;
  readonly storageData: StorageDataApi;
  readonly storageObject: StorageObjectApi;
  readonly streamAnalytics: StreamAnalyticsApi;
  readonly streamPipeline: StreamPipelineApi;
  readonly streaming: StreamingApi;
  readonly subscription: SubscriptionApi;
  readonly support: SupportApi;
  readonly supportQueue: SupportQueueApi;
  readonly upload: UploadApi;
  readonly vPNGateway: VPNGatewayApi;
  readonly vXLAN: VXLANApi;
  readonly virtualMachine: VirtualMachineApi;
  readonly virtualNetwork: VirtualNetworkApi;
  readonly vmConsole: VmConsoleApi;
  readonly vmNetwork: VmNetworkApi;
  readonly vmOperations: VmOperationsApi;
  readonly webmail: WebmailApi;
  readonly widget: WidgetApi;
  readonly yugabyte: YugabyteApi;
  constructor(c: HiokTransport) {
    this.accessControl = new AccessControlApi(c);
    this.admin = new AdminApi(c);
    this.adminData = new AdminDataApi(c);
    this.adminDns = new AdminDnsApi(c);
    this.adminInfrastructure = new AdminInfrastructureApi(c);
    this.advisor = new AdvisorApi(c);
    this.analytics = new AnalyticsApi(c);
    this.apiManagement = new ApiManagementApi(c);
    this.assistant = new AssistantApi(c);
    this.bastion = new BastionApi(c);
    this.billingWebhook = new BillingWebhookApi(c);
    this.cache = new CacheApi(c);
    this.cards = new CardsApi(c);
    this.cloudShell = new CloudShellApi(c);
    this.cloudSubscription = new CloudSubscriptionApi(c);
    this.commonServices = new CommonServicesApi(c);
    this.communication = new CommunicationApi(c);
    this.containerApp = new ContainerAppApi(c);
    this.containerJobs = new ContainerJobsApi(c);
    this.containerRegistry = new ContainerRegistryApi(c);
    this.containers = new ContainersApi(c);
    this.costTracking = new CostTrackingApi(c);
    this.createResource = new CreateResourceApi(c);
    this.deployment = new DeploymentApi(c);
    this.dockerImages = new DockerImagesApi(c);
    this.downloads = new DownloadsApi(c);
    this.dps = new DpsApi(c);
    this.fx = new FxApi(c);
    this.groups = new GroupsApi(c);
    this.hierarchyView = new HierarchyViewApi(c);
    this.hiokCloudGroups = new HiokCloudGroupsApi(c);
    this.hiokCloudHierarchy = new HiokCloudHierarchyApi(c);
    this.hiokUsers = new HiokUsersApi(c);
    this.hybrid = new HybridApi(c);
    this.identity = new IdentityApi(c);
    this.infrastructure = new InfrastructureApi(c);
    this.ioTDeviceGateway = new IoTDeviceGatewayApi(c);
    this.ioTHub = new IoTHubApi(c);
    this.ioTHubDevice = new IoTHubDeviceApi(c);
    this.ioTHubDiagnostics = new IoTHubDiagnosticsApi(c);
    this.ioTHubManagement = new IoTHubManagementApi(c);
    this.ioTHubProtocol = new IoTHubProtocolApi(c);
    this.k9sConsole = new K9sConsoleApi(c);
    this.keyVault = new KeyVaultApi(c);
    this.kubernetes = new KubernetesApi(c);
    this.mailAdmin = new MailAdminApi(c);
    this.marketplace = new MarketplaceApi(c);
    this.metrics = new MetricsApi(c);
    this.mongo = new MongoApi(c);
    this.mySqlDatabase = new MySqlDatabaseApi(c);
    this.networkAccess = new NetworkAccessApi(c);
    this.notification = new NotificationApi(c);
    this.oAuth = new OAuthApi(c);
    this.oVS = new OVSApi(c);
    this.panel = new PanelApi(c);
    this.postgresDatabase = new PostgresDatabaseApi(c);
    this.pricing = new PricingApi(c);
    this.profile = new ProfileApi(c);
    this.pulse = new PulseApi(c);
    this.recentResources = new RecentResourcesApi(c);
    this.resourceGovernance = new ResourceGovernanceApi(c);
    this.resourceGroups = new ResourceGroupsApi(c);
    this.resourceMetrics = new ResourceMetricsApi(c);
    this.resourceOperations = new ResourceOperationsApi(c);
    this.sandbox = new SandboxApi(c);
    this.search = new SearchApi(c);
    this.serviceBus = new ServiceBusApi(c);
    this.sqlServerDatabase = new SqlServerDatabaseApi(c);
    this.storage = new StorageApi(c);
    this.storageAccount = new StorageAccountApi(c);
    this.storageData = new StorageDataApi(c);
    this.storageObject = new StorageObjectApi(c);
    this.streamAnalytics = new StreamAnalyticsApi(c);
    this.streamPipeline = new StreamPipelineApi(c);
    this.streaming = new StreamingApi(c);
    this.subscription = new SubscriptionApi(c);
    this.support = new SupportApi(c);
    this.supportQueue = new SupportQueueApi(c);
    this.upload = new UploadApi(c);
    this.vPNGateway = new VPNGatewayApi(c);
    this.vXLAN = new VXLANApi(c);
    this.virtualMachine = new VirtualMachineApi(c);
    this.virtualNetwork = new VirtualNetworkApi(c);
    this.vmConsole = new VmConsoleApi(c);
    this.vmNetwork = new VmNetworkApi(c);
    this.vmOperations = new VmOperationsApi(c);
    this.webmail = new WebmailApi(c);
    this.widget = new WidgetApi(c);
    this.yugabyte = new YugabyteApi(c);
  }
}
