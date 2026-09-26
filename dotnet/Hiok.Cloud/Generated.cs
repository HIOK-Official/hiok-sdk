// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
#nullable enable
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json.Nodes;
using System.Threading;
using System.Threading.Tasks;

namespace Hiok.Cloud;

/// <summary>Every API operation, grouped as the API groups them: <c>client.Api.&lt;Group&gt;.&lt;Operation&gt;Async()</c>.</summary>
public sealed partial class HiokApi
{
    public AccessControlApi AccessControl { get; }
    public AdminApi Admin { get; }
    public AdminDataApi AdminData { get; }
    public AdminDnsApi AdminDns { get; }
    public AdminInfrastructureApi AdminInfrastructure { get; }
    public AdvisorApi Advisor { get; }
    public AnalyticsApi Analytics { get; }
    public ApiManagementApi ApiManagement { get; }
    public AssistantApi Assistant { get; }
    public BastionApi Bastion { get; }
    public BillingWebhookApi BillingWebhook { get; }
    public CacheApi Cache { get; }
    public CardsApi Cards { get; }
    public CloudShellApi CloudShell { get; }
    public CloudSubscriptionApi CloudSubscription { get; }
    public CommonServicesApi CommonServices { get; }
    public CommunicationApi Communication { get; }
    public ContainerAppApi ContainerApp { get; }
    public ContainerJobsApi ContainerJobs { get; }
    public ContainerRegistryApi ContainerRegistry { get; }
    public ContainersApi Containers { get; }
    public CostTrackingApi CostTracking { get; }
    public CreateResourceApi CreateResource { get; }
    public DeploymentApi Deployment { get; }
    public DockerImagesApi DockerImages { get; }
    public DownloadsApi Downloads { get; }
    public DpsApi Dps { get; }
    public FxApi Fx { get; }
    public GroupsApi Groups { get; }
    public HierarchyViewApi HierarchyView { get; }
    public HiokCloudGroupsApi HiokCloudGroups { get; }
    public HiokCloudHierarchyApi HiokCloudHierarchy { get; }
    public HiokUsersApi HiokUsers { get; }
    public HybridApi Hybrid { get; }
    public IdentityApi Identity { get; }
    public InfrastructureApi Infrastructure { get; }
    public IntegrationsApi Integrations { get; }
    public IoTDeviceGatewayApi IoTDeviceGateway { get; }
    public IoTHubApi IoTHub { get; }
    public IoTHubDeviceApi IoTHubDevice { get; }
    public IoTHubDiagnosticsApi IoTHubDiagnostics { get; }
    public IoTHubManagementApi IoTHubManagement { get; }
    public IoTHubProtocolApi IoTHubProtocol { get; }
    public K9sConsoleApi K9sConsole { get; }
    public KeyVaultApi KeyVault { get; }
    public KubernetesApi Kubernetes { get; }
    public MailAdminApi MailAdmin { get; }
    public MarketplaceApi Marketplace { get; }
    public MetricsApi Metrics { get; }
    public MongoApi Mongo { get; }
    public MySqlDatabaseApi MySqlDatabase { get; }
    public NetworkAccessApi NetworkAccess { get; }
    public NotificationApi Notification { get; }
    public OAuthApi OAuth { get; }
    public OVSApi OVS { get; }
    public PanelApi Panel { get; }
    public PostgresDatabaseApi PostgresDatabase { get; }
    public PricingApi Pricing { get; }
    public ProfileApi Profile { get; }
    public PulseApi Pulse { get; }
    public RecentResourcesApi RecentResources { get; }
    public ResourceGovernanceApi ResourceGovernance { get; }
    public ResourceGroupsApi ResourceGroups { get; }
    public ResourceMetricsApi ResourceMetrics { get; }
    public ResourceOperationsApi ResourceOperations { get; }
    public SandboxApi Sandbox { get; }
    public SearchApi Search { get; }
    public ServiceBusApi ServiceBus { get; }
    public SlackApi Slack { get; }
    public SqlServerDatabaseApi SqlServerDatabase { get; }
    public StorageApi Storage { get; }
    public StorageAccountApi StorageAccount { get; }
    public StorageDataApi StorageData { get; }
    public StorageObjectApi StorageObject { get; }
    public StreamAnalyticsApi StreamAnalytics { get; }
    public StreamPipelineApi StreamPipeline { get; }
    public StreamingApi Streaming { get; }
    public SubscriptionApi Subscription { get; }
    public SupportApi Support { get; }
    public SupportQueueApi SupportQueue { get; }
    public UploadApi Upload { get; }
    public VPNGatewayApi VPNGateway { get; }
    public VXLANApi VXLAN { get; }
    public VirtualMachineApi VirtualMachine { get; }
    public VirtualNetworkApi VirtualNetwork { get; }
    public VmConsoleApi VmConsole { get; }
    public VmNetworkApi VmNetwork { get; }
    public VmOperationsApi VmOperations { get; }
    public WebmailApi Webmail { get; }
    public WidgetApi Widget { get; }
    public YugabyteApi Yugabyte { get; }

    internal HiokApi(HiokClient client)
    {
        AccessControl = new AccessControlApi(client);
        Admin = new AdminApi(client);
        AdminData = new AdminDataApi(client);
        AdminDns = new AdminDnsApi(client);
        AdminInfrastructure = new AdminInfrastructureApi(client);
        Advisor = new AdvisorApi(client);
        Analytics = new AnalyticsApi(client);
        ApiManagement = new ApiManagementApi(client);
        Assistant = new AssistantApi(client);
        Bastion = new BastionApi(client);
        BillingWebhook = new BillingWebhookApi(client);
        Cache = new CacheApi(client);
        Cards = new CardsApi(client);
        CloudShell = new CloudShellApi(client);
        CloudSubscription = new CloudSubscriptionApi(client);
        CommonServices = new CommonServicesApi(client);
        Communication = new CommunicationApi(client);
        ContainerApp = new ContainerAppApi(client);
        ContainerJobs = new ContainerJobsApi(client);
        ContainerRegistry = new ContainerRegistryApi(client);
        Containers = new ContainersApi(client);
        CostTracking = new CostTrackingApi(client);
        CreateResource = new CreateResourceApi(client);
        Deployment = new DeploymentApi(client);
        DockerImages = new DockerImagesApi(client);
        Downloads = new DownloadsApi(client);
        Dps = new DpsApi(client);
        Fx = new FxApi(client);
        Groups = new GroupsApi(client);
        HierarchyView = new HierarchyViewApi(client);
        HiokCloudGroups = new HiokCloudGroupsApi(client);
        HiokCloudHierarchy = new HiokCloudHierarchyApi(client);
        HiokUsers = new HiokUsersApi(client);
        Hybrid = new HybridApi(client);
        Identity = new IdentityApi(client);
        Infrastructure = new InfrastructureApi(client);
        Integrations = new IntegrationsApi(client);
        IoTDeviceGateway = new IoTDeviceGatewayApi(client);
        IoTHub = new IoTHubApi(client);
        IoTHubDevice = new IoTHubDeviceApi(client);
        IoTHubDiagnostics = new IoTHubDiagnosticsApi(client);
        IoTHubManagement = new IoTHubManagementApi(client);
        IoTHubProtocol = new IoTHubProtocolApi(client);
        K9sConsole = new K9sConsoleApi(client);
        KeyVault = new KeyVaultApi(client);
        Kubernetes = new KubernetesApi(client);
        MailAdmin = new MailAdminApi(client);
        Marketplace = new MarketplaceApi(client);
        Metrics = new MetricsApi(client);
        Mongo = new MongoApi(client);
        MySqlDatabase = new MySqlDatabaseApi(client);
        NetworkAccess = new NetworkAccessApi(client);
        Notification = new NotificationApi(client);
        OAuth = new OAuthApi(client);
        OVS = new OVSApi(client);
        Panel = new PanelApi(client);
        PostgresDatabase = new PostgresDatabaseApi(client);
        Pricing = new PricingApi(client);
        Profile = new ProfileApi(client);
        Pulse = new PulseApi(client);
        RecentResources = new RecentResourcesApi(client);
        ResourceGovernance = new ResourceGovernanceApi(client);
        ResourceGroups = new ResourceGroupsApi(client);
        ResourceMetrics = new ResourceMetricsApi(client);
        ResourceOperations = new ResourceOperationsApi(client);
        Sandbox = new SandboxApi(client);
        Search = new SearchApi(client);
        ServiceBus = new ServiceBusApi(client);
        Slack = new SlackApi(client);
        SqlServerDatabase = new SqlServerDatabaseApi(client);
        Storage = new StorageApi(client);
        StorageAccount = new StorageAccountApi(client);
        StorageData = new StorageDataApi(client);
        StorageObject = new StorageObjectApi(client);
        StreamAnalytics = new StreamAnalyticsApi(client);
        StreamPipeline = new StreamPipelineApi(client);
        Streaming = new StreamingApi(client);
        Subscription = new SubscriptionApi(client);
        Support = new SupportApi(client);
        SupportQueue = new SupportQueueApi(client);
        Upload = new UploadApi(client);
        VPNGateway = new VPNGatewayApi(client);
        VXLAN = new VXLANApi(client);
        VirtualMachine = new VirtualMachineApi(client);
        VirtualNetwork = new VirtualNetworkApi(client);
        VmConsole = new VmConsoleApi(client);
        VmNetwork = new VmNetworkApi(client);
        VmOperations = new VmOperationsApi(client);
        Webmail = new WebmailApi(client);
        Widget = new WidgetApi(client);
        Yugabyte = new YugabyteApi(client);
    }
}

/// <summary>AccessControl operations.</summary>
public sealed partial class AccessControlApi
{
    private readonly HiokClient _c;
    internal AccessControlApi(HiokClient client) => _c = client;

    /// <summary>Add role assignment. <c>[POST /api/access-control/{resourceType}/{resourceId}/role-assignments]</c></summary>
    public Task<JsonNode?> AddRoleAssignmentAsync(string resourceType, string resourceId, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/access-control/" + HiokClient.Segment(resourceType) + "/" + HiokClient.Segment(resourceId) + "/role-assignments", body, null, ct);

    /// <summary>Check access. <c>[GET /api/access-control/{resourceType}/{resourceId}/check-access]</c></summary>
    public Task<JsonNode?> CheckAccessAsync(string resourceType, string resourceId, object? principalEmail = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/access-control/" + HiokClient.Segment(resourceType) + "/" + HiokClient.Segment(resourceId) + "/check-access", null, new Dictionary<string, object?> { ["principalEmail"] = principalEmail }, ct);

    /// <summary>List all assignments. <c>[GET /api/access-control/assignments]</c></summary>
    public Task<JsonNode?> ListAllAssignmentsAsync(object? principalEmail = null, object? roleId = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/access-control/assignments", null, new Dictionary<string, object?> { ["principalEmail"] = principalEmail, ["roleId"] = roleId }, ct);

    /// <summary>List principals. <c>[GET /api/access-control/principals]</c></summary>
    public Task<JsonNode?> ListPrincipalsAsync(object? q = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/access-control/principals", null, new Dictionary<string, object?> { ["q"] = q }, ct);

    /// <summary>List role assignments. <c>[GET /api/access-control/{resourceType}/{resourceId}/role-assignments]</c></summary>
    public Task<JsonNode?> ListRoleAssignmentsAsync(string resourceType, string resourceId, object? includeInherited = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/access-control/" + HiokClient.Segment(resourceType) + "/" + HiokClient.Segment(resourceId) + "/role-assignments", null, new Dictionary<string, object?> { ["includeInherited"] = includeInherited }, ct);

    /// <summary>List roles. <c>[GET /api/access-control/roles]</c></summary>
    public Task<JsonNode?> ListRolesAsync(object? category = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/access-control/roles", null, new Dictionary<string, object?> { ["category"] = category }, ct);

    /// <summary>Register scope. <c>[PUT /api/access-control/{resourceType}/{resourceId}/scope]</c></summary>
    public Task<JsonNode?> RegisterScopeAsync(string resourceType, string resourceId, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("PUT"), "/api/access-control/" + HiokClient.Segment(resourceType) + "/" + HiokClient.Segment(resourceId) + "/scope", body, null, ct);

    /// <summary>Remove assignment. <c>[DELETE /api/access-control/assignments/{assignmentId}]</c></summary>
    public Task<JsonNode?> RemoveAssignmentAsync(string assignmentId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/access-control/assignments/" + HiokClient.Segment(assignmentId), null, null, ct);

    /// <summary>Remove role assignment. <c>[DELETE /api/access-control/{resourceType}/{resourceId}/role-assignments/{assignmentId}]</c></summary>
    public Task<JsonNode?> RemoveRoleAssignmentAsync(string resourceType, string resourceId, string assignmentId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/access-control/" + HiokClient.Segment(resourceType) + "/" + HiokClient.Segment(resourceId) + "/role-assignments/" + HiokClient.Segment(assignmentId), null, null, ct);

    /// <summary>Scope chain. <c>[GET /api/access-control/{resourceType}/{resourceId}/scope-chain]</c></summary>
    public Task<JsonNode?> ScopeChainAsync(string resourceType, string resourceId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/access-control/" + HiokClient.Segment(resourceType) + "/" + HiokClient.Segment(resourceId) + "/scope-chain", null, null, ct);
}

/// <summary>Admin operations.</summary>
public sealed partial class AdminApi
{
    private readonly HiokClient _c;
    internal AdminApi(HiokClient client) => _c = client;

    /// <summary>Grant. <c>[POST /api/Admin/access]</c></summary>
    public Task<JsonNode?> GrantAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Admin/access", body, null, ct);

    /// <summary>List grants. <c>[GET /api/Admin/access]</c></summary>
    public Task<JsonNode?> ListGrantsAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Admin/access", null, null, ct);

    /// <summary>Me. <c>[GET /api/Admin/me]</c></summary>
    public Task<JsonNode?> MeAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Admin/me", null, null, ct);

    /// <summary>Revoke. <c>[DELETE /api/Admin/access/{id}]</c></summary>
    public Task<JsonNode?> RevokeAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/Admin/access/" + HiokClient.Segment(id), null, null, ct);
}

/// <summary>AdminData operations.</summary>
public sealed partial class AdminDataApi
{
    private readonly HiokClient _c;
    internal AdminDataApi(HiokClient client) => _c = client;

    /// <summary>Resources. <c>[GET /api/admin/resources]</c></summary>
    public Task<JsonNode?> ResourcesAsync(object? search = null, object? type = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/admin/resources", null, new Dictionary<string, object?> { ["search"] = search, ["type"] = type }, ct);

    /// <summary>Subscriptions. <c>[GET /api/admin/subscriptions]</c></summary>
    public Task<JsonNode?> SubscriptionsAsync(object? search = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/admin/subscriptions", null, new Dictionary<string, object?> { ["search"] = search }, ct);

    /// <summary>Table rows. <c>[GET /api/admin/database/{table}]</c></summary>
    public Task<JsonNode?> TableRowsAsync(string table, object? search = null, object? limit = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/admin/database/" + HiokClient.Segment(table), null, new Dictionary<string, object?> { ["search"] = search, ["limit"] = limit }, ct);

    /// <summary>Tables. <c>[GET /api/admin/database/tables]</c></summary>
    public Task<JsonNode?> TablesAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/admin/database/tables", null, null, ct);
}

/// <summary>AdminDns operations.</summary>
public sealed partial class AdminDnsApi
{
    private readonly HiokClient _c;
    internal AdminDnsApi(HiokClient client) => _c = client;

    /// <summary>Delete. <c>[DELETE /api/admin/dns/records/{id}]</c></summary>
    public Task<JsonNode?> DeleteAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/admin/dns/records/" + HiokClient.Segment(id), null, null, ct);

    /// <summary>Mail health. <c>[GET /api/admin/dns/mail-health]</c></summary>
    public Task<JsonNode?> MailHealthAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/admin/dns/mail-health", null, null, ct);

    /// <summary>Records. <c>[GET /api/admin/dns/records]</c></summary>
    public Task<JsonNode?> RecordsAsync(object? q = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/admin/dns/records", null, new Dictionary<string, object?> { ["q"] = q }, ct);

    /// <summary>Upsert. <c>[POST /api/admin/dns/records]</c></summary>
    public Task<JsonNode?> UpsertAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/admin/dns/records", body, null, ct);
}

/// <summary>AdminInfrastructure operations.</summary>
public sealed partial class AdminInfrastructureApi
{
    private readonly HiokClient _c;
    internal AdminInfrastructureApi(HiokClient client) => _c = client;

    /// <summary>Bridges. <c>[GET /api/admin/infrastructure/bridges]</c></summary>
    public Task<JsonNode?> BridgesAsync(object? region = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/admin/infrastructure/bridges", null, new Dictionary<string, object?> { ["region"] = region }, ct);

    /// <summary>Containers. <c>[GET /api/admin/infrastructure/containers]</c></summary>
    public Task<JsonNode?> ContainersAsync(object? region = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/admin/infrastructure/containers", null, new Dictionary<string, object?> { ["region"] = region }, ct);

    /// <summary>Delete bridge. <c>[DELETE /api/admin/infrastructure/bridges/{name}]</c></summary>
    public Task<JsonNode?> DeleteBridgeAsync(string name, object? region = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/admin/infrastructure/bridges/" + HiokClient.Segment(name), null, new Dictionary<string, object?> { ["region"] = region }, ct);

    /// <summary>Delete container. <c>[DELETE /api/admin/infrastructure/containers/{id}]</c></summary>
    public Task<JsonNode?> DeleteContainerAsync(string id, object? region = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/admin/infrastructure/containers/" + HiokClient.Segment(id), null, new Dictionary<string, object?> { ["region"] = region }, ct);

    /// <summary>Delete image. <c>[DELETE /api/admin/infrastructure/images/{id}]</c></summary>
    public Task<JsonNode?> DeleteImageAsync(string id, object? region = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/admin/infrastructure/images/" + HiokClient.Segment(id), null, new Dictionary<string, object?> { ["region"] = region }, ct);

    /// <summary>Delete network. <c>[DELETE /api/admin/infrastructure/networks/{id}]</c></summary>
    public Task<JsonNode?> DeleteNetworkAsync(string id, object? region = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/admin/infrastructure/networks/" + HiokClient.Segment(id), null, new Dictionary<string, object?> { ["region"] = region }, ct);

    /// <summary>Delete vm. <c>[DELETE /api/admin/infrastructure/vms/{name}]</c></summary>
    public Task<JsonNode?> DeleteVmAsync(string name, object? region = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/admin/infrastructure/vms/" + HiokClient.Segment(name), null, new Dictionary<string, object?> { ["region"] = region }, ct);

    /// <summary>Delete volume. <c>[DELETE /api/admin/infrastructure/volumes/{name}]</c></summary>
    public Task<JsonNode?> DeleteVolumeAsync(string name, object? region = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/admin/infrastructure/volumes/" + HiokClient.Segment(name), null, new Dictionary<string, object?> { ["region"] = region }, ct);

    /// <summary>Dns janitor. <c>[POST /api/admin/infrastructure/dns-janitor]</c></summary>
    public Task<JsonNode?> DnsJanitorAsync(object? dryRun = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/admin/infrastructure/dns-janitor", null, new Dictionary<string, object?> { ["dryRun"] = dryRun }, ct);

    /// <summary>Firewall. <c>[GET /api/admin/infrastructure/firewall]</c></summary>
    public Task<JsonNode?> FirewallAsync(object? region = null, object? chain = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/admin/infrastructure/firewall", null, new Dictionary<string, object?> { ["region"] = region, ["chain"] = chain }, ct);

    /// <summary>Flows. <c>[GET /api/admin/infrastructure/flows]</c></summary>
    public Task<JsonNode?> FlowsAsync(object? region = null, object? bridge = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/admin/infrastructure/flows", null, new Dictionary<string, object?> { ["region"] = region, ["bridge"] = bridge }, ct);

    /// <summary>Images. <c>[GET /api/admin/infrastructure/images]</c></summary>
    public Task<JsonNode?> ImagesAsync(object? region = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/admin/infrastructure/images", null, new Dictionary<string, object?> { ["region"] = region }, ct);

    /// <summary>Metrics. <c>[GET /api/admin/infrastructure/metrics]</c></summary>
    public Task<JsonNode?> MetricsAsync(object? region = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/admin/infrastructure/metrics", null, new Dictionary<string, object?> { ["region"] = region }, ct);

    /// <summary>Networks. <c>[GET /api/admin/infrastructure/networks]</c></summary>
    public Task<JsonNode?> NetworksAsync(object? region = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/admin/infrastructure/networks", null, new Dictionary<string, object?> { ["region"] = region }, ct);

    /// <summary>Virtual machines. <c>[GET /api/admin/infrastructure/vms]</c></summary>
    public Task<JsonNode?> VirtualMachinesAsync(object? region = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/admin/infrastructure/vms", null, new Dictionary<string, object?> { ["region"] = region }, ct);

    /// <summary>Volumes. <c>[GET /api/admin/infrastructure/volumes]</c></summary>
    public Task<JsonNode?> VolumesAsync(object? region = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/admin/infrastructure/volumes", null, new Dictionary<string, object?> { ["region"] = region }, ct);
}

/// <summary>Advisor operations.</summary>
public sealed partial class AdvisorApi
{
    private readonly HiokClient _c;
    internal AdvisorApi(HiokClient client) => _c = client;

    /// <summary>Create tasks. <c>[POST /api/advisor/tasks]</c></summary>
    public Task<JsonNode?> CreateTasksAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/advisor/tasks", body, null, ct);

    /// <summary>Delete task. <c>[DELETE /api/advisor/tasks/{id}]</c></summary>
    public Task<JsonNode?> DeleteTaskAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/advisor/tasks/" + HiokClient.Segment(id), null, null, ct);

    /// <summary>Report. <c>[GET /api/advisor/report]</c></summary>
    public Task<JsonNode?> ReportAsync(object? subscriptionId = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/advisor/report", null, new Dictionary<string, object?> { ["subscriptionId"] = subscriptionId }, ct);

    /// <summary>Restore. <c>[DELETE /api/advisor/suppressions/{id}]</c></summary>
    public Task<JsonNode?> RestoreAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/advisor/suppressions/" + HiokClient.Segment(id), null, null, ct);

    /// <summary>Suppress. <c>[POST /api/advisor/suppressions]</c></summary>
    public Task<JsonNode?> SuppressAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/advisor/suppressions", body, null, ct);

    /// <summary>Tasks. <c>[GET /api/advisor/tasks]</c></summary>
    public Task<JsonNode?> TasksAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/advisor/tasks", null, null, ct);

    /// <summary>Update task. <c>[PATCH /api/advisor/tasks/{id}]</c></summary>
    public Task<JsonNode?> UpdateTaskAsync(string id, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("PATCH"), "/api/advisor/tasks/" + HiokClient.Segment(id), body, null, ct);
}

/// <summary>Analytics operations.</summary>
public sealed partial class AnalyticsApi
{
    private readonly HiokClient _c;
    internal AnalyticsApi(HiokClient client) => _c = client;

    /// <summary>Attach vnet. <c>[POST /api/Analytics/{id}/vnet/attach]</c></summary>
    public Task<JsonNode?> AttachVNetAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Analytics/" + HiokClient.Segment(id) + "/vnet/attach", null, null, ct);

    /// <summary>Columns. <c>[GET /api/Analytics/{id}/tables/{database}/{table}/columns]</c></summary>
    public Task<JsonNode?> ColumnsAsync(string id, string database, string table, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Analytics/" + HiokClient.Segment(id) + "/tables/" + HiokClient.Segment(database) + "/" + HiokClient.Segment(table) + "/columns", null, null, ct);

    /// <summary>Connection. <c>[GET /api/Analytics/{id}/connection]</c></summary>
    public Task<JsonNode?> ConnectionAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Analytics/" + HiokClient.Segment(id) + "/connection", null, null, ct);

    /// <summary>Create. <c>[POST /api/Analytics]</c></summary>
    public Task<JsonNode?> CreateAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Analytics", body, null, ct);

    /// <summary>Delete. <c>[DELETE /api/Analytics/{id}]</c></summary>
    public Task<JsonNode?> DeleteAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/Analytics/" + HiokClient.Segment(id), null, null, ct);

    /// <summary>Detach vnet. <c>[POST /api/Analytics/{id}/vnet/detach]</c></summary>
    public Task<JsonNode?> DetachVNetAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Analytics/" + HiokClient.Segment(id) + "/vnet/detach", null, null, ct);

    /// <summary>Get. <c>[GET /api/Analytics/{id}]</c></summary>
    public Task<JsonNode?> GetAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Analytics/" + HiokClient.Segment(id), null, null, ct);

    /// <summary>List. <c>[GET /api/Analytics]</c></summary>
    public Task<JsonNode?> ListAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Analytics", null, null, ct);

    /// <summary>Query. <c>[POST /api/Analytics/{id}/query]</c></summary>
    public Task<JsonNode?> QueryAsync(string id, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Analytics/" + HiokClient.Segment(id) + "/query", body, null, ct);

    /// <summary>Start. <c>[POST /api/Analytics/{id}/start]</c></summary>
    public Task<JsonNode?> StartAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Analytics/" + HiokClient.Segment(id) + "/start", null, null, ct);

    /// <summary>Stop. <c>[POST /api/Analytics/{id}/stop]</c></summary>
    public Task<JsonNode?> StopAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Analytics/" + HiokClient.Segment(id) + "/stop", null, null, ct);

    /// <summary>Tables. <c>[GET /api/Analytics/{id}/tables]</c></summary>
    public Task<JsonNode?> TablesAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Analytics/" + HiokClient.Segment(id) + "/tables", null, null, ct);
}

/// <summary>ApiManagement operations.</summary>
public sealed partial class ApiManagementApi
{
    private readonly HiokClient _c;
    internal ApiManagementApi(HiokClient client) => _c = client;

    /// <summary>Analytics. <c>[GET /api/apim/apis/{apiId}/analytics]</c></summary>
    public Task<JsonNode?> AnalyticsAsync(string apiId, object? hours = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/apim/apis/" + HiokClient.Segment(apiId) + "/analytics", null, new Dictionary<string, object?> { ["hours"] = hours }, ct);

    /// <summary>Create api. <c>[POST /api/apim/apis]</c></summary>
    public Task<JsonNode?> CreateApiAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/apim/apis", body, null, ct);

    /// <summary>Create operation. <c>[POST /api/apim/apis/{apiId}/operations]</c></summary>
    public Task<JsonNode?> CreateOperationAsync(string apiId, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/apim/apis/" + HiokClient.Segment(apiId) + "/operations", body, null, ct);

    /// <summary>Create policy. <c>[POST /api/apim/apis/{apiId}/policies]</c></summary>
    public Task<JsonNode?> CreatePolicyAsync(string apiId, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/apim/apis/" + HiokClient.Segment(apiId) + "/policies", body, null, ct);

    /// <summary>Create product. <c>[POST /api/apim/products]</c></summary>
    public Task<JsonNode?> CreateProductAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/apim/products", body, null, ct);

    /// <summary>Create sub. <c>[POST /api/apim/subscriptions]</c></summary>
    public Task<JsonNode?> CreateSubAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/apim/subscriptions", body, null, ct);

    /// <summary>Delete api. <c>[DELETE /api/apim/apis/{id}]</c></summary>
    public Task<JsonNode?> DeleteApiAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/apim/apis/" + HiokClient.Segment(id), null, null, ct);

    /// <summary>Delete operation. <c>[DELETE /api/apim/operations/{id}]</c></summary>
    public Task<JsonNode?> DeleteOperationAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/apim/operations/" + HiokClient.Segment(id), null, null, ct);

    /// <summary>Delete policy. <c>[DELETE /api/apim/policies/{id}]</c></summary>
    public Task<JsonNode?> DeletePolicyAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/apim/policies/" + HiokClient.Segment(id), null, null, ct);

    /// <summary>Delete product. <c>[DELETE /api/apim/products/{id}]</c></summary>
    public Task<JsonNode?> DeleteProductAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/apim/products/" + HiokClient.Segment(id), null, null, ct);

    /// <summary>Delete sub. <c>[DELETE /api/apim/subscriptions/{id}]</c></summary>
    public Task<JsonNode?> DeleteSubAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/apim/subscriptions/" + HiokClient.Segment(id), null, null, ct);

    /// <summary>Gateway. <c>[GET /api/apim/gateway/{apiPath}/{rest}]</c></summary>
    public Task<JsonNode?> GatewayAsync(string apiPath, string rest, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/apim/gateway/" + HiokClient.Segment(apiPath) + "/" + HiokClient.Segment(rest), null, null, ct);

    /// <summary>Gateway delete. <c>[DELETE /api/apim/gateway/{apiPath}/{rest}]</c></summary>
    public Task<JsonNode?> GatewayDeleteAsync(string apiPath, string rest, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/apim/gateway/" + HiokClient.Segment(apiPath) + "/" + HiokClient.Segment(rest), null, null, ct);

    /// <summary>Gateway post. <c>[POST /api/apim/gateway/{apiPath}/{rest}]</c></summary>
    public Task<JsonNode?> GatewayPostAsync(string apiPath, string rest, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/apim/gateway/" + HiokClient.Segment(apiPath) + "/" + HiokClient.Segment(rest), null, null, ct);

    /// <summary>Gateway put. <c>[PUT /api/apim/gateway/{apiPath}/{rest}]</c></summary>
    public Task<JsonNode?> GatewayPutAsync(string apiPath, string rest, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("PUT"), "/api/apim/gateway/" + HiokClient.Segment(apiPath) + "/" + HiokClient.Segment(rest), null, null, ct);

    /// <summary>List apis. <c>[GET /api/apim/apis]</c></summary>
    public Task<JsonNode?> ListApisAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/apim/apis", null, null, ct);

    /// <summary>List operations. <c>[GET /api/apim/apis/{apiId}/operations]</c></summary>
    public Task<JsonNode?> ListOperationsAsync(string apiId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/apim/apis/" + HiokClient.Segment(apiId) + "/operations", null, null, ct);

    /// <summary>List policies. <c>[GET /api/apim/apis/{apiId}/policies]</c></summary>
    public Task<JsonNode?> ListPoliciesAsync(string apiId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/apim/apis/" + HiokClient.Segment(apiId) + "/policies", null, null, ct);

    /// <summary>List products. <c>[GET /api/apim/products]</c></summary>
    public Task<JsonNode?> ListProductsAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/apim/products", null, null, ct);

    /// <summary>List subs. <c>[GET /api/apim/subscriptions]</c></summary>
    public Task<JsonNode?> ListSubsAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/apim/subscriptions", null, null, ct);

    /// <summary>Regen sub key. <c>[POST /api/apim/subscriptions/{id}/regenerate-key]</c></summary>
    public Task<JsonNode?> RegenSubKeyAsync(string id, object? which = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/apim/subscriptions/" + HiokClient.Segment(id) + "/regenerate-key", null, new Dictionary<string, object?> { ["which"] = which }, ct);

    /// <summary>Update operation. <c>[PUT /api/apim/operations/{id}]</c></summary>
    public Task<JsonNode?> UpdateOperationAsync(string id, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("PUT"), "/api/apim/operations/" + HiokClient.Segment(id), body, null, ct);
}

/// <summary>Assistant operations.</summary>
public sealed partial class AssistantApi
{
    private readonly HiokClient _c;
    internal AssistantApi(HiokClient client) => _c = client;

    /// <summary>Act. <c>[POST /api/assistant/act]</c></summary>
    public Task<JsonNode?> ActAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/assistant/act", body, null, ct);

    /// <summary>Ask. <c>[POST /api/assistant/ask]</c></summary>
    public Task<JsonNode?> AskAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/assistant/ask", body, null, ct);

    /// <summary>Findings. <c>[GET /api/assistant/findings]</c></summary>
    public Task<JsonNode?> FindingsAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/assistant/findings", null, null, ct);

    /// <summary>Stream. <c>[POST /api/assistant/stream]</c></summary>
    public Task<JsonNode?> StreamAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/assistant/stream", null, null, ct);
}

/// <summary>Bastion operations.</summary>
public sealed partial class BastionApi
{
    private readonly HiokClient _c;
    internal BastionApi(HiokClient client) => _c = client;

    /// <summary>Create. <c>[POST /api/Bastion]</c></summary>
    public Task<JsonNode?> CreateAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Bastion", body, null, ct);

    /// <summary>Delete. <c>[DELETE /api/Bastion/{id}]</c></summary>
    public Task<JsonNode?> DeleteAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/Bastion/" + HiokClient.Segment(id), null, null, ct);

    /// <summary>End session. <c>[DELETE /api/Bastion/{id}/sessions/{sessionId}]</c></summary>
    public Task<JsonNode?> EndSessionAsync(string id, string sessionId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/Bastion/" + HiokClient.Segment(id) + "/sessions/" + HiokClient.Segment(sessionId), null, null, ct);

    /// <summary>Get. <c>[GET /api/Bastion/{id}]</c></summary>
    public Task<JsonNode?> GetAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Bastion/" + HiokClient.Segment(id), null, null, ct);

    /// <summary>List. <c>[GET /api/Bastion]</c></summary>
    public Task<JsonNode?> ListAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Bastion", null, null, ct);

    /// <summary>List sessions. <c>[GET /api/Bastion/{id}/sessions]</c></summary>
    public Task<JsonNode?> ListSessionsAsync(string id, object? limit = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Bastion/" + HiokClient.Segment(id) + "/sessions", null, new Dictionary<string, object?> { ["limit"] = limit }, ct);

    /// <summary>Refresh. <c>[POST /api/Bastion/{id}/refresh]</c></summary>
    public Task<JsonNode?> RefreshAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Bastion/" + HiokClient.Segment(id) + "/refresh", null, null, ct);

    /// <summary>Start session. <c>[POST /api/Bastion/{id}/sessions]</c></summary>
    public Task<JsonNode?> StartSessionAsync(string id, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Bastion/" + HiokClient.Segment(id) + "/sessions", body, null, ct);
}

/// <summary>BillingWebhook operations.</summary>
public sealed partial class BillingWebhookApi
{
    private readonly HiokClient _c;
    internal BillingWebhookApi(HiokClient client) => _c = client;

    /// <summary>Receive. <c>[POST /api/billing/webhook/{provider}]</c></summary>
    public Task<JsonNode?> ReceiveAsync(string provider, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/billing/webhook/" + HiokClient.Segment(provider), null, null, ct);
}

/// <summary>Cache operations.</summary>
public sealed partial class CacheApi
{
    private readonly HiokClient _c;
    internal CacheApi(HiokClient client) => _c = client;

    /// <summary>Add region. <c>[POST /api/Cache/{id}/regions]</c></summary>
    public Task<JsonNode?> AddRegionAsync(string id, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Cache/" + HiokClient.Segment(id) + "/regions", body, null, ct);

    /// <summary>Command. <c>[POST /api/Cache/{id}/command]</c></summary>
    public Task<JsonNode?> CommandAsync(string id, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Cache/" + HiokClient.Segment(id) + "/command", body, null, ct);

    /// <summary>Create. <c>[POST /api/Cache]</c></summary>
    public Task<JsonNode?> CreateAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Cache", body, null, ct);

    /// <summary>Delete. <c>[DELETE /api/Cache/{id}]</c></summary>
    public Task<JsonNode?> DeleteAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/Cache/" + HiokClient.Segment(id), null, null, ct);

    /// <summary>Get. <c>[GET /api/Cache/{id}]</c></summary>
    public Task<JsonNode?> GetAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Cache/" + HiokClient.Segment(id), null, null, ct);

    /// <summary>Keys. <c>[GET /api/Cache/{id}/keys]</c></summary>
    public Task<JsonNode?> KeysAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Cache/" + HiokClient.Segment(id) + "/keys", null, null, ct);

    /// <summary>List. <c>[GET /api/Cache]</c></summary>
    public Task<JsonNode?> ListAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Cache", null, null, ct);

    /// <summary>Logs. <c>[GET /api/Cache/{id}/logs]</c></summary>
    public Task<JsonNode?> LogsAsync(string id, object? region = null, object? tail = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Cache/" + HiokClient.Segment(id) + "/logs", null, new Dictionary<string, object?> { ["region"] = region, ["tail"] = tail }, ct);

    /// <summary>Metrics. <c>[GET /api/Cache/{id}/metrics]</c></summary>
    public Task<JsonNode?> MetricsAsync(string id, object? hours = null, object? region = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Cache/" + HiokClient.Segment(id) + "/metrics", null, new Dictionary<string, object?> { ["hours"] = hours, ["region"] = region }, ct);

    /// <summary>Remove region. <c>[DELETE /api/Cache/{id}/regions/{region}]</c></summary>
    public Task<JsonNode?> RemoveRegionAsync(string id, string region, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/Cache/" + HiokClient.Segment(id) + "/regions/" + HiokClient.Segment(region), null, null, ct);

    /// <summary>Rotate. <c>[POST /api/Cache/{id}/keys/rotate]</c></summary>
    public Task<JsonNode?> RotateAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Cache/" + HiokClient.Segment(id) + "/keys/rotate", null, null, ct);

    /// <summary>Stats. <c>[GET /api/Cache/{id}/stats]</c></summary>
    public Task<JsonNode?> StatsAsync(string id, object? region = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Cache/" + HiokClient.Segment(id) + "/stats", null, new Dictionary<string, object?> { ["region"] = region }, ct);
}

/// <summary>Cards operations.</summary>
public sealed partial class CardsApi
{
    private readonly HiokClient _c;
    internal CardsApi(HiokClient client) => _c = client;

    /// <summary>Complete. <c>[POST /api/billing/cards/complete]</c></summary>
    public Task<JsonNode?> CompleteAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/billing/cards/complete", body, null, ct);

    /// <summary>List. <c>[GET /api/billing/cards]</c></summary>
    public Task<JsonNode?> ListAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/billing/cards", null, null, ct);

    /// <summary>Providers. <c>[GET /api/billing/cards/providers]</c></summary>
    public Task<JsonNode?> ProvidersAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/billing/cards/providers", null, null, ct);

    /// <summary>Remove. <c>[DELETE /api/billing/cards/{id}]</c></summary>
    public Task<JsonNode?> RemoveAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/billing/cards/" + HiokClient.Segment(id), null, null, ct);

    /// <summary>Setup. <c>[POST /api/billing/cards/setup]</c></summary>
    public Task<JsonNode?> SetupAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/billing/cards/setup", body, null, ct);
}

/// <summary>CloudShell operations.</summary>
public sealed partial class CloudShellApi
{
    private readonly HiokClient _c;
    internal CloudShellApi(HiokClient client) => _c = client;

    /// <summary>End. <c>[DELETE /api/cloudshell/session]</c></summary>
    public Task<JsonNode?> EndAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/cloudshell/session", null, null, ct);

    /// <summary>Session. <c>[GET /api/cloudshell/session]</c></summary>
    public Task<JsonNode?> SessionAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/cloudshell/session", null, null, ct);

    /// <summary>Status. <c>[GET /api/cloudshell/status]</c></summary>
    public Task<JsonNode?> StatusAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/cloudshell/status", null, null, ct);
}

/// <summary>CloudSubscription operations.</summary>
public sealed partial class CloudSubscriptionApi
{
    private readonly HiokClient _c;
    internal CloudSubscriptionApi(HiokClient client) => _c = client;

    /// <summary>Add payment. <c>[POST /api/cloudsubscription/payment-methods]</c></summary>
    public Task<JsonNode?> AddPaymentAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/cloudsubscription/payment-methods", body, null, ct);

    /// <summary>Create. <c>[POST /api/cloudsubscription]</c></summary>
    public Task<JsonNode?> CreateAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/cloudsubscription", body, null, ct);

    /// <summary>Delete. <c>[DELETE /api/cloudsubscription/{id}]</c></summary>
    public Task<JsonNode?> DeleteAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/cloudsubscription/" + HiokClient.Segment(id), null, null, ct);

    /// <summary>List. <c>[GET /api/cloudsubscription]</c></summary>
    public Task<JsonNode?> ListAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/cloudsubscription", null, null, ct);

    /// <summary>Payment methods. <c>[GET /api/cloudsubscription/payment-methods]</c></summary>
    public Task<JsonNode?> PaymentMethodsAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/cloudsubscription/payment-methods", null, null, ct);
}

/// <summary>CommonServices operations.</summary>
public sealed partial class CommonServicesApi
{
    private readonly HiokClient _c;
    internal CommonServicesApi(HiokClient client) => _c = client;

    /// <summary>Get random string. <c>[GET /api/CommonServices/randomstring]</c></summary>
    public Task<JsonNode?> GetRandomStringAsync(object? length = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/CommonServices/randomstring", null, new Dictionary<string, object?> { ["length"] = length }, ct);
}

/// <summary>Communication operations.</summary>
public sealed partial class CommunicationApi
{
    private readonly HiokClient _c;
    internal CommunicationApi(HiokClient client) => _c = client;

    /// <summary>Add domain. <c>[POST /api/Communication/services/{id}/domains]</c></summary>
    public Task<JsonNode?> AddDomainAsync(string id, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Communication/services/" + HiokClient.Segment(id) + "/domains", body, null, ct);

    /// <summary>Add sender. <c>[POST /api/Communication/services/{id}/domains/{domainId}/senders]</c></summary>
    public Task<JsonNode?> AddSenderAsync(string id, string domainId, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Communication/services/" + HiokClient.Segment(id) + "/domains/" + HiokClient.Segment(domainId) + "/senders", body, null, ct);

    /// <summary>Create connector. <c>[POST /api/Communication/services/{id}/connectors]</c></summary>
    public Task<JsonNode?> CreateConnectorAsync(string id, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Communication/services/" + HiokClient.Segment(id) + "/connectors", body, null, ct);

    /// <summary>Create service. <c>[POST /api/Communication/services]</c></summary>
    public Task<JsonNode?> CreateServiceAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Communication/services", body, null, ct);

    /// <summary>Delete connector. <c>[DELETE /api/Communication/services/{id}/connectors/{connectorId}]</c></summary>
    public Task<JsonNode?> DeleteConnectorAsync(string id, string connectorId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/Communication/services/" + HiokClient.Segment(id) + "/connectors/" + HiokClient.Segment(connectorId), null, null, ct);

    /// <summary>Delete domain. <c>[DELETE /api/Communication/services/{id}/domains/{domainId}]</c></summary>
    public Task<JsonNode?> DeleteDomainAsync(string id, string domainId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/Communication/services/" + HiokClient.Segment(id) + "/domains/" + HiokClient.Segment(domainId), null, null, ct);

    /// <summary>Delete message. <c>[DELETE /api/Communication/services/{id}/emails/{messageId}]</c></summary>
    public Task<JsonNode?> DeleteMessageAsync(string id, string messageId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/Communication/services/" + HiokClient.Segment(id) + "/emails/" + HiokClient.Segment(messageId), null, null, ct);

    /// <summary>Delete sender. <c>[DELETE /api/Communication/services/{id}/domains/{domainId}/senders/{senderId}]</c></summary>
    public Task<JsonNode?> DeleteSenderAsync(string id, string domainId, string senderId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/Communication/services/" + HiokClient.Segment(id) + "/domains/" + HiokClient.Segment(domainId) + "/senders/" + HiokClient.Segment(senderId), null, null, ct);

    /// <summary>Delete service. <c>[DELETE /api/Communication/services/{id}]</c></summary>
    public Task<JsonNode?> DeleteServiceAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/Communication/services/" + HiokClient.Segment(id), null, null, ct);

    /// <summary>Get message. <c>[GET /api/Communication/services/{id}/emails/{messageId}]</c></summary>
    public Task<JsonNode?> GetMessageAsync(string id, string messageId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Communication/services/" + HiokClient.Segment(id) + "/emails/" + HiokClient.Segment(messageId), null, null, ct);

    /// <summary>Get service. <c>[GET /api/Communication/services/{id}]</c></summary>
    public Task<JsonNode?> GetServiceAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Communication/services/" + HiokClient.Segment(id), null, null, ct);

    /// <summary>List connectors. <c>[GET /api/Communication/services/{id}/connectors]</c></summary>
    public Task<JsonNode?> ListConnectorsAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Communication/services/" + HiokClient.Segment(id) + "/connectors", null, null, ct);

    /// <summary>List domains. <c>[GET /api/Communication/services/{id}/domains]</c></summary>
    public Task<JsonNode?> ListDomainsAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Communication/services/" + HiokClient.Segment(id) + "/domains", null, null, ct);

    /// <summary>List messages. <c>[GET /api/Communication/services/{id}/emails]</c></summary>
    public Task<JsonNode?> ListMessagesAsync(string id, object? limit = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Communication/services/" + HiokClient.Segment(id) + "/emails", null, new Dictionary<string, object?> { ["limit"] = limit }, ct);

    /// <summary>List services. <c>[GET /api/Communication/services]</c></summary>
    public Task<JsonNode?> ListServicesAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Communication/services", null, null, ct);

    /// <summary>Send email. <c>[POST /api/Communication/services/{id}/emails]</c></summary>
    public Task<JsonNode?> SendEmailAsync(string id, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Communication/services/" + HiokClient.Segment(id) + "/emails", body, null, ct);

    /// <summary>Verify domain. <c>[POST /api/Communication/services/{id}/domains/{domainId}/verify]</c></summary>
    public Task<JsonNode?> VerifyDomainAsync(string id, string domainId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Communication/services/" + HiokClient.Segment(id) + "/domains/" + HiokClient.Segment(domainId) + "/verify", null, null, ct);
}

/// <summary>ContainerApp operations.</summary>
public sealed partial class ContainerAppApi
{
    private readonly HiokClient _c;
    internal ContainerAppApi(HiokClient client) => _c = client;

    /// <summary>Create app. <c>[POST /api/ContainerApp]</c></summary>
    public Task<JsonNode?> CreateAppAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/ContainerApp", body, null, ct);

    /// <summary>Create environment. <c>[POST /api/ContainerApp/environments]</c></summary>
    public Task<JsonNode?> CreateEnvironmentAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/ContainerApp/environments", body, null, ct);

    /// <summary>Create revision. <c>[POST /api/ContainerApp/{id}/revisions]</c></summary>
    public Task<JsonNode?> CreateRevisionAsync(string id, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/ContainerApp/" + HiokClient.Segment(id) + "/revisions", body, null, ct);

    /// <summary>Delete app. <c>[DELETE /api/ContainerApp/{id}]</c></summary>
    public Task<JsonNode?> DeleteAppAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/ContainerApp/" + HiokClient.Segment(id), null, null, ct);

    /// <summary>Delete environment. <c>[DELETE /api/ContainerApp/environments/{id}]</c></summary>
    public Task<JsonNode?> DeleteEnvironmentAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/ContainerApp/environments/" + HiokClient.Segment(id), null, null, ct);

    /// <summary>Environment contents. <c>[GET /api/ContainerApp/environments/{id}/contents]</c></summary>
    public Task<JsonNode?> EnvironmentContentsAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/ContainerApp/environments/" + HiokClient.Segment(id) + "/contents", null, null, ct);

    /// <summary>Exec. <c>[POST /api/ContainerApp/{id}/exec]</c></summary>
    public Task<JsonNode?> ExecAsync(string id, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/ContainerApp/" + HiokClient.Segment(id) + "/exec", body, null, ct);

    /// <summary>Get app. <c>[GET /api/ContainerApp/{id}]</c></summary>
    public Task<JsonNode?> GetAppAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/ContainerApp/" + HiokClient.Segment(id), null, null, ct);

    /// <summary>Get replicas. <c>[GET /api/ContainerApp/{id}/replicas]</c></summary>
    public Task<JsonNode?> GetReplicasAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/ContainerApp/" + HiokClient.Segment(id) + "/replicas", null, null, ct);

    /// <summary>List apps. <c>[GET /api/ContainerApp]</c></summary>
    public Task<JsonNode?> ListAppsAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/ContainerApp", null, null, ct);

    /// <summary>List environments. <c>[GET /api/ContainerApp/environments]</c></summary>
    public Task<JsonNode?> ListEnvironmentsAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/ContainerApp/environments", null, null, ct);

    /// <summary>List revisions. <c>[GET /api/ContainerApp/{id}/revisions]</c></summary>
    public Task<JsonNode?> ListRevisionsAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/ContainerApp/" + HiokClient.Segment(id) + "/revisions", null, null, ct);

    /// <summary>Rollback. <c>[POST /api/ContainerApp/{id}/revisions/{revisionName}/rollback]</c></summary>
    public Task<JsonNode?> RollbackAsync(string id, string revisionName, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/ContainerApp/" + HiokClient.Segment(id) + "/revisions/" + HiokClient.Segment(revisionName) + "/rollback", null, null, ct);

    /// <summary>Scale. <c>[POST /api/ContainerApp/{id}/scale]</c></summary>
    public Task<JsonNode?> ScaleAsync(string id, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/ContainerApp/" + HiokClient.Segment(id) + "/scale", body, null, ct);

    /// <summary>Set traffic. <c>[POST /api/ContainerApp/{id}/revisions/traffic]</c></summary>
    public Task<JsonNode?> SetTrafficAsync(string id, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/ContainerApp/" + HiokClient.Segment(id) + "/revisions/traffic", body, null, ct);
}

/// <summary>ContainerJobs operations.</summary>
public sealed partial class ContainerJobsApi
{
    private readonly HiokClient _c;
    internal ContainerJobsApi(HiokClient client) => _c = client;

    /// <summary>Cancel. <c>[POST /api/container-jobs/{id}/runs/{runId}/cancel]</c></summary>
    public Task<JsonNode?> CancelAsync(string id, string runId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/container-jobs/" + HiokClient.Segment(id) + "/runs/" + HiokClient.Segment(runId) + "/cancel", null, null, ct);

    /// <summary>Create. <c>[POST /api/container-jobs]</c></summary>
    public Task<JsonNode?> CreateAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/container-jobs", body, null, ct);

    /// <summary>Delete. <c>[DELETE /api/container-jobs/{id}]</c></summary>
    public Task<JsonNode?> DeleteAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/container-jobs/" + HiokClient.Segment(id), null, null, ct);

    /// <summary>Get. <c>[GET /api/container-jobs/{id}]</c></summary>
    public Task<JsonNode?> GetAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/container-jobs/" + HiokClient.Segment(id), null, null, ct);

    /// <summary>Get run. <c>[GET /api/container-jobs/{id}/runs/{runId}]</c></summary>
    public Task<JsonNode?> GetRunAsync(string id, string runId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/container-jobs/" + HiokClient.Segment(id) + "/runs/" + HiokClient.Segment(runId), null, null, ct);

    /// <summary>List. <c>[GET /api/container-jobs]</c></summary>
    public Task<JsonNode?> ListAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/container-jobs", null, null, ct);

    /// <summary>Preview. <c>[GET /api/container-jobs/schedule-preview]</c></summary>
    public Task<JsonNode?> PreviewAsync(object? cron = null, object? timeZone = null, object? count = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/container-jobs/schedule-preview", null, new Dictionary<string, object?> { ["cron"] = cron, ["timeZone"] = timeZone, ["count"] = count }, ct);

    /// <summary>Run. <c>[POST /api/container-jobs/{id}/run]</c></summary>
    public Task<JsonNode?> RunAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/container-jobs/" + HiokClient.Segment(id) + "/run", null, null, ct);

    /// <summary>Runs. <c>[GET /api/container-jobs/{id}/runs]</c></summary>
    public Task<JsonNode?> RunsAsync(string id, object? take = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/container-jobs/" + HiokClient.Segment(id) + "/runs", null, new Dictionary<string, object?> { ["take"] = take }, ct);

    /// <summary>Update. <c>[PUT /api/container-jobs/{id}]</c></summary>
    public Task<JsonNode?> UpdateAsync(string id, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("PUT"), "/api/container-jobs/" + HiokClient.Segment(id), body, null, ct);
}

/// <summary>ContainerRegistry operations.</summary>
public sealed partial class ContainerRegistryApi
{
    private readonly HiokClient _c;
    internal ContainerRegistryApi(HiokClient client) => _c = client;

    /// <summary>Create. <c>[POST /api/container-registry]</c></summary>
    public Task<JsonNode?> CreateAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/container-registry", body, null, ct);

    /// <summary>Create repository. <c>[POST /api/container-registry/{id}/repositories]</c></summary>
    public Task<JsonNode?> CreateRepositoryAsync(string id, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/container-registry/" + HiokClient.Segment(id) + "/repositories", body, null, ct);

    /// <summary>Credentials. <c>[GET /api/container-registry/{id}/credentials]</c></summary>
    public Task<JsonNode?> CredentialsAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/container-registry/" + HiokClient.Segment(id) + "/credentials", null, null, ct);

    /// <summary>Delete. <c>[DELETE /api/container-registry/{id}]</c></summary>
    public Task<JsonNode?> DeleteAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/container-registry/" + HiokClient.Segment(id), null, null, ct);

    /// <summary>Delete repository. <c>[DELETE /api/container-registry/{id}/repositories/{repositoryName}]</c></summary>
    public Task<JsonNode?> DeleteRepositoryAsync(string id, string repositoryName, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/container-registry/" + HiokClient.Segment(id) + "/repositories/" + HiokClient.Segment(repositoryName, true), null, null, ct);

    /// <summary>Delete tag. <c>[DELETE /api/container-registry/{id}/tags]</c></summary>
    public Task<JsonNode?> DeleteTagAsync(string id, object? repository = null, object? tag = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/container-registry/" + HiokClient.Segment(id) + "/tags", null, new Dictionary<string, object?> { ["repository"] = repository, ["tag"] = tag }, ct);

    /// <summary>Get. <c>[GET /api/container-registry/{id}]</c></summary>
    public Task<JsonNode?> GetAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/container-registry/" + HiokClient.Segment(id), null, null, ct);

    /// <summary>List. <c>[GET /api/container-registry]</c></summary>
    public Task<JsonNode?> ListAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/container-registry", null, null, ct);

    /// <summary>Repositories. <c>[GET /api/container-registry/{id}/repositories]</c></summary>
    public Task<JsonNode?> RepositoriesAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/container-registry/" + HiokClient.Segment(id) + "/repositories", null, null, ct);

    /// <summary>Rotate. <c>[POST /api/container-registry/{id}/credentials/rotate]</c></summary>
    public Task<JsonNode?> RotateAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/container-registry/" + HiokClient.Segment(id) + "/credentials/rotate", null, null, ct);

    /// <summary>Tags. <c>[GET /api/container-registry/{id}/tags]</c></summary>
    public Task<JsonNode?> TagsAsync(string id, object? repository = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/container-registry/" + HiokClient.Segment(id) + "/tags", null, new Dictionary<string, object?> { ["repository"] = repository }, ct);
}

/// <summary>Containers operations.</summary>
public sealed partial class ContainersApi
{
    private readonly HiokClient _c;
    internal ContainersApi(HiokClient client) => _c = client;

    /// <summary>Build image. <c>[POST /api/Containers/images/build]</c></summary>
    public Task<JsonNode?> BuildImageAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Containers/images/build", body, null, ct);

    /// <summary>Create container. <c>[POST /api/Containers/createcontainer]</c></summary>
    public Task<JsonNode?> CreateContainerAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Containers/createcontainer", body, null, ct);

    /// <summary>Create swarm service. <c>[POST /api/Containers/swarm/services]</c></summary>
    public Task<JsonNode?> CreateSwarmServiceAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Containers/swarm/services", body, null, ct);

    /// <summary>Delete container. <c>[POST /api/Containers/deletecontainer]</c></summary>
    public Task<JsonNode?> DeleteContainerAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Containers/deletecontainer", body, null, ct);

    /// <summary>Exec. <c>[POST /api/Containers/{containerName}/exec]</c></summary>
    public Task<JsonNode?> ExecAsync(string containerName, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Containers/" + HiokClient.Segment(containerName) + "/exec", body, null, ct);

    /// <summary>Give public address. <c>[POST /api/Containers/{name}/public-ip]</c></summary>
    public Task<JsonNode?> GivePublicAddressAsync(string name, object? region = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Containers/" + HiokClient.Segment(name) + "/public-ip", null, new Dictionary<string, object?> { ["region"] = region }, ct);

    /// <summary>Inspect. <c>[GET /api/Containers/{containerName}/inspect]</c></summary>
    public Task<JsonNode?> InspectAsync(string containerName, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Containers/" + HiokClient.Segment(containerName) + "/inspect", null, null, ct);

    /// <summary>List all containers. <c>[POST /api/Containers/listallcontainers]</c></summary>
    public Task<JsonNode?> ListAllContainersAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Containers/listallcontainers", body, null, ct);

    /// <summary>Logs. <c>[GET /api/Containers/{containerName}/logs]</c></summary>
    public Task<JsonNode?> LogsAsync(string containerName, object? tail = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Containers/" + HiokClient.Segment(containerName) + "/logs", null, new Dictionary<string, object?> { ["tail"] = tail }, ct);

    /// <summary>Release public address. <c>[DELETE /api/Containers/{name}/public-ip]</c></summary>
    public Task<JsonNode?> ReleasePublicAddressAsync(string name, object? region = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/Containers/" + HiokClient.Segment(name) + "/public-ip", null, new Dictionary<string, object?> { ["region"] = region }, ct);

    /// <summary>Remove swarm service. <c>[DELETE /api/Containers/swarm/services/{name}]</c></summary>
    public Task<JsonNode?> RemoveSwarmServiceAsync(string name, object? region = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/Containers/swarm/services/" + HiokClient.Segment(name), null, new Dictionary<string, object?> { ["region"] = region }, ct);

    /// <summary>Rename container. <c>[POST /api/Containers/renamecontainer]</c></summary>
    public Task<JsonNode?> RenameContainerAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Containers/renamecontainer", body, null, ct);

    /// <summary>Restart container. <c>[POST /api/Containers/restartcontainer]</c></summary>
    public Task<JsonNode?> RestartContainerAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Containers/restartcontainer", body, null, ct);

    /// <summary>Scale swarm service. <c>[POST /api/Containers/swarm/services/{name}/scale]</c></summary>
    public Task<JsonNode?> ScaleSwarmServiceAsync(string name, object? replicas = null, object? region = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Containers/swarm/services/" + HiokClient.Segment(name) + "/scale", null, new Dictionary<string, object?> { ["replicas"] = replicas, ["region"] = region }, ct);

    /// <summary>Stack down. <c>[POST /api/Containers/stacks/down]</c></summary>
    public Task<JsonNode?> StackDownAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Containers/stacks/down", body, null, ct);

    /// <summary>Stack file. <c>[GET /api/Containers/stacks/{project}]</c></summary>
    public Task<JsonNode?> StackFileAsync(string project, object? region = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Containers/stacks/" + HiokClient.Segment(project), null, new Dictionary<string, object?> { ["region"] = region }, ct);

    /// <summary>Stack up. <c>[POST /api/Containers/stacks/up]</c></summary>
    public Task<JsonNode?> StackUpAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Containers/stacks/up", body, null, ct);

    /// <summary>Start container. <c>[POST /api/Containers/startcontainer]</c></summary>
    public Task<JsonNode?> StartContainerAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Containers/startcontainer", body, null, ct);

    /// <summary>Stats. <c>[GET /api/Containers/{containerName}/stats]</c></summary>
    public Task<JsonNode?> StatsAsync(string containerName, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Containers/" + HiokClient.Segment(containerName) + "/stats", null, null, ct);

    /// <summary>Stop container. <c>[POST /api/Containers/stopcontainer]</c></summary>
    public Task<JsonNode?> StopContainerAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Containers/stopcontainer", body, null, ct);

    /// <summary>Swarm init. <c>[POST /api/Containers/swarm/init]</c></summary>
    public Task<JsonNode?> SwarmInitAsync(object? region = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Containers/swarm/init", null, new Dictionary<string, object?> { ["region"] = region }, ct);

    /// <summary>Swarm leave. <c>[POST /api/Containers/swarm/leave]</c></summary>
    public Task<JsonNode?> SwarmLeaveAsync(object? region = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Containers/swarm/leave", null, new Dictionary<string, object?> { ["region"] = region }, ct);

    /// <summary>Swarm nodes. <c>[GET /api/Containers/swarm/nodes]</c></summary>
    public Task<JsonNode?> SwarmNodesAsync(object? region = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Containers/swarm/nodes", null, new Dictionary<string, object?> { ["region"] = region }, ct);

    /// <summary>Swarm services. <c>[GET /api/Containers/swarm/services]</c></summary>
    public Task<JsonNode?> SwarmServicesAsync(object? region = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Containers/swarm/services", null, new Dictionary<string, object?> { ["region"] = region }, ct);

    /// <summary>Swarm status. <c>[GET /api/Containers/swarm]</c></summary>
    public Task<JsonNode?> SwarmStatusAsync(object? region = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Containers/swarm", null, new Dictionary<string, object?> { ["region"] = region }, ct);

    /// <summary>Update container. <c>[POST /api/Containers/updatecontainer]</c></summary>
    public Task<JsonNode?> UpdateContainerAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Containers/updatecontainer", body, null, ct);

    /// <summary>Volumes. <c>[GET /api/Containers/volumes]</c></summary>
    public Task<JsonNode?> VolumesAsync(object? region = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Containers/volumes", null, new Dictionary<string, object?> { ["region"] = region }, ct);
}

/// <summary>CostTracking operations.</summary>
public sealed partial class CostTrackingApi
{
    private readonly HiokClient _c;
    internal CostTrackingApi(HiokClient client) => _c = client;

    /// <summary>Create cost alert. <c>[POST /api/CostTracking/alerts]</c></summary>
    public Task<JsonNode?> CreateCostAlertAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/CostTracking/alerts", body, null, ct);

    /// <summary>Delete cost alert. <c>[DELETE /api/CostTracking/alerts/{alertId}]</c></summary>
    public Task<JsonNode?> DeleteCostAlertAsync(string alertId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/CostTracking/alerts/" + HiokClient.Segment(alertId), null, null, ct);

    /// <summary>Estimate cost. <c>[POST /api/CostTracking/pricing/estimate]</c></summary>
    public Task<JsonNode?> EstimateCostAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/CostTracking/pricing/estimate", body, null, ct);

    /// <summary>Get all storage account costs. <c>[GET /api/CostTracking/storage-accounts]</c></summary>
    public Task<JsonNode?> GetAllStorageAccountCostsAsync(object? period = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/CostTracking/storage-accounts", null, new Dictionary<string, object?> { ["period"] = period }, ct);

    /// <summary>Get billing periods. <c>[GET /api/CostTracking/billing/history]</c></summary>
    public Task<JsonNode?> GetBillingPeriodsAsync(object? limit = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/CostTracking/billing/history", null, new Dictionary<string, object?> { ["limit"] = limit }, ct);

    /// <summary>Get cost alerts. <c>[GET /api/CostTracking/alerts]</c></summary>
    public Task<JsonNode?> GetCostAlertsAsync(object? scopeType = null, object? scopeId = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/CostTracking/alerts", null, new Dictionary<string, object?> { ["scopeType"] = scopeType, ["scopeId"] = scopeId }, ct);

    /// <summary>Get current billing period. <c>[GET /api/CostTracking/billing/current]</c></summary>
    public Task<JsonNode?> GetCurrentBillingPeriodAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/CostTracking/billing/current", null, null, ct);

    /// <summary>Get pricing tiers. <c>[GET /api/CostTracking/pricing]</c></summary>
    public Task<JsonNode?> GetPricingTiersAsync(object? tier = null, object? redundancy = null, object? region = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/CostTracking/pricing", null, new Dictionary<string, object?> { ["tier"] = tier, ["redundancy"] = redundancy, ["region"] = region }, ct);

    /// <summary>Get resource group cost. <c>[GET /api/CostTracking/resource-group/{resourceGroupId}]</c></summary>
    public Task<JsonNode?> GetResourceGroupCostAsync(string resourceGroupId, object? period = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/CostTracking/resource-group/" + HiokClient.Segment(resourceGroupId), null, new Dictionary<string, object?> { ["period"] = period }, ct);

    /// <summary>Get storage account cost. <c>[GET /api/CostTracking/storage-account/{storageAccountId}]</c></summary>
    public Task<JsonNode?> GetStorageAccountCostAsync(string storageAccountId, object? period = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/CostTracking/storage-account/" + HiokClient.Segment(storageAccountId), null, new Dictionary<string, object?> { ["period"] = period }, ct);

    /// <summary>Get subscription cost. <c>[GET /api/CostTracking/subscription/{subscriptionId}]</c></summary>
    public Task<JsonNode?> GetSubscriptionCostAsync(string subscriptionId, object? period = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/CostTracking/subscription/" + HiokClient.Segment(subscriptionId), null, new Dictionary<string, object?> { ["period"] = period }, ct);

    /// <summary>Overview. <c>[GET /api/CostTracking/overview]</c></summary>
    public Task<JsonNode?> OverviewAsync(object? region = null, object? subscriptionId = null, object? from = null, object? to = null, object? resourceName = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/CostTracking/overview", null, new Dictionary<string, object?> { ["region"] = region, ["subscriptionId"] = subscriptionId, ["from"] = from, ["to"] = to, ["resourceName"] = resourceName }, ct);

    /// <summary>Record cost event. <c>[POST /api/CostTracking/events]</c></summary>
    public Task<JsonNode?> RecordCostEventAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/CostTracking/events", body, null, ct);

    /// <summary>Trigger daily calculation. <c>[POST /api/CostTracking/daily-calculation]</c></summary>
    public Task<JsonNode?> TriggerDailyCalculationAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/CostTracking/daily-calculation", null, null, ct);
}

/// <summary>CreateResource operations.</summary>
public sealed partial class CreateResourceApi
{
    private readonly HiokClient _c;
    internal CreateResourceApi(HiokClient client) => _c = client;

    /// <summary>Create resource. <c>[POST /api/CreateResource/createresource]</c></summary>
    public Task<JsonNode?> CreateResourceAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/CreateResource/createresource", body, null, ct);

    /// <summary>Validate resource. <c>[POST /api/CreateResource/validateresource]</c></summary>
    public Task<JsonNode?> ValidateResourceAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/CreateResource/validateresource", body, null, ct);
}

/// <summary>Deployment operations.</summary>
public sealed partial class DeploymentApi
{
    private readonly HiokClient _c;
    internal DeploymentApi(HiokClient client) => _c = client;

    /// <summary>Delete deployment. <c>[DELETE /api/Deployment/deployments/{id}]</c></summary>
    public Task<JsonNode?> DeleteDeploymentAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/Deployment/deployments/" + HiokClient.Segment(id), null, null, ct);

    /// <summary>Deployment. <c>[GET /api/Deployment/deployments/{id}]</c></summary>
    public Task<JsonNode?> DeploymentAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Deployment/deployments/" + HiokClient.Segment(id), null, null, ct);

    /// <summary>Deployments. <c>[GET /api/Deployment/deployments]</c></summary>
    public Task<JsonNode?> DeploymentsAsync(object? status = null, object? limit = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Deployment/deployments", null, new Dictionary<string, object?> { ["status"] = status, ["limit"] = limit }, ct);

    /// <summary>Redeploy. <c>[POST /api/Deployment/deployments/{id}/redeploy]</c></summary>
    public Task<JsonNode?> RedeployAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Deployment/deployments/" + HiokClient.Segment(id) + "/redeploy", null, null, ct);

    /// <summary>Status. <c>[GET /api/Deployment/status]</c></summary>
    public Task<JsonNode?> StatusAsync(object? limit = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Deployment/status", null, new Dictionary<string, object?> { ["limit"] = limit }, ct);
}

/// <summary>DockerImages operations.</summary>
public sealed partial class DockerImagesApi
{
    private readonly HiokClient _c;
    internal DockerImagesApi(HiokClient client) => _c = client;

    /// <summary>Get image history. <c>[POST /api/DockerImages/imagehistory]</c></summary>
    public Task<JsonNode?> GetImageHistoryAsync(object? body = null, object? regions = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/DockerImages/imagehistory", body, new Dictionary<string, object?> { ["regions"] = regions }, ct);

    /// <summary>Get image informations. <c>[POST /api/DockerImages/inspectimage]</c></summary>
    public Task<JsonNode?> GetImageInformationsAsync(object? body = null, object? regions = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/DockerImages/inspectimage", body, new Dictionary<string, object?> { ["regions"] = regions }, ct);

    /// <summary>List all docker images. <c>[POST /api/DockerImages/listallimages]</c></summary>
    public Task<JsonNode?> ListAllDockerImagesAsync(object? body = null, object? regions = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/DockerImages/listallimages", body, new Dictionary<string, object?> { ["regions"] = regions }, ct);

    /// <summary>List all docker public images. <c>[POST /api/DockerImages/listallpublicimages]</c></summary>
    public Task<JsonNode?> ListAllDockerPublicImagesAsync(object? body = null, object? isOfficialImage = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/DockerImages/listallpublicimages", body, new Dictionary<string, object?> { ["isOfficialImage"] = isOfficialImage }, ct);

    /// <summary>Search docker image. <c>[POST /api/DockerImages/searchimage]</c></summary>
    public Task<JsonNode?> SearchDockerImageAsync(object? body = null, object? regions = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/DockerImages/searchimage", body, new Dictionary<string, object?> { ["regions"] = regions }, ct);
}

/// <summary>Downloads operations.</summary>
public sealed partial class DownloadsApi
{
    private readonly HiokClient _c;
    internal DownloadsApi(HiokClient client) => _c = client;

    /// <summary>Cli. <c>[GET /api/downloads/hiok]</c></summary>
    public Task<JsonNode?> CliAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/downloads/hiok", null, null, ct);

    /// <summary>Install. <c>[GET /api/downloads/install.sh]</c></summary>
    public Task<JsonNode?> InstallAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/downloads/install.sh", null, null, ct);

    /// <summary>Install ps1. <c>[GET /api/downloads/install.ps1]</c></summary>
    public Task<JsonNode?> InstallPs1Async(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/downloads/install.ps1", null, null, ct);

    /// <summary>Manifest. <c>[GET /api/downloads/manifest]</c></summary>
    public Task<JsonNode?> ManifestAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/downloads/manifest", null, null, ct);

    /// <summary>Sdk. <c>[GET /api/downloads/sdk.tar.gz]</c></summary>
    public Task<JsonNode?> SdkAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/downloads/sdk.tar.gz", null, null, ct);

    /// <summary>Sdk package. <c>[GET /api/downloads/sdk/{file}]</c></summary>
    public Task<JsonNode?> SdkPackageAsync(string file, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/downloads/sdk/" + HiokClient.Segment(file), null, null, ct);

    /// <summary>Sdk package list. <c>[GET /api/downloads/sdk]</c></summary>
    public Task<JsonNode?> SdkPackageListAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/downloads/sdk", null, null, ct);
}

/// <summary>Dps operations.</summary>
public sealed partial class DpsApi
{
    private readonly HiokClient _c;
    internal DpsApi(HiokClient client) => _c = client;

    /// <summary>Create. <c>[POST /api/dps/enrollments]</c></summary>
    public Task<JsonNode?> CreateAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/dps/enrollments", body, null, ct);

    /// <summary>Delete. <c>[DELETE /api/dps/enrollments/{id}]</c></summary>
    public Task<JsonNode?> DeleteAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/dps/enrollments/" + HiokClient.Segment(id), null, null, ct);

    /// <summary>List. <c>[GET /api/dps/enrollments]</c></summary>
    public Task<JsonNode?> ListAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/dps/enrollments", null, null, ct);

    /// <summary>Register. <c>[POST /api/dps/register]</c></summary>
    public Task<JsonNode?> RegisterAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/dps/register", body, null, ct);

    /// <summary>Registrations. <c>[GET /api/dps/enrollments/{id}/registrations]</c></summary>
    public Task<JsonNode?> RegistrationsAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/dps/enrollments/" + HiokClient.Segment(id) + "/registrations", null, null, ct);
}

/// <summary>Fx operations.</summary>
public sealed partial class FxApi
{
    private readonly HiokClient _c;
    internal FxApi(HiokClient client) => _c = client;

    /// <summary>Convert. <c>[GET /api/Fx/convert]</c></summary>
    public Task<JsonNode?> ConvertAsync(object? usd = null, object? currency = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Fx/convert", null, new Dictionary<string, object?> { ["usd"] = usd, ["currency"] = currency }, ct);

    /// <summary>Rates. <c>[GET /api/Fx/rates]</c></summary>
    public Task<JsonNode?> RatesAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Fx/rates", null, null, ct);
}

/// <summary>Groups operations.</summary>
public sealed partial class GroupsApi
{
    private readonly HiokClient _c;
    internal GroupsApi(HiokClient client) => _c = client;

    /// <summary>Create groups. <c>[POST /api/Groups/creategroups]</c></summary>
    public Task<JsonNode?> CreateGroupsAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Groups/creategroups", body, null, ct);

    /// <summary>Delete groups. <c>[DELETE /api/Groups/deletegroups]</c></summary>
    public Task<JsonNode?> DeleteGroupsAsync(object? id = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/Groups/deletegroups", null, new Dictionary<string, object?> { ["id"] = id }, ct);

    /// <summary>Edit groups. <c>[PUT /api/Groups/editgroups]</c></summary>
    public Task<JsonNode?> EditGroupsAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("PUT"), "/api/Groups/editgroups", body, null, ct);

    /// <summary>Get groups. <c>[GET /api/Groups/groups]</c></summary>
    public Task<JsonNode?> GetGroupsAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Groups/groups", null, null, ct);
}

/// <summary>HierarchyView operations.</summary>
public sealed partial class HierarchyViewApi
{
    private readonly HiokClient _c;
    internal HierarchyViewApi(HiokClient client) => _c = client;

    /// <summary>Context. <c>[GET /api/hierarchyview/context/{resourceGroupId}]</c></summary>
    public Task<JsonNode?> ContextAsync(string resourceGroupId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/hierarchyview/context/" + HiokClient.Segment(resourceGroupId), null, null, ct);

    /// <summary>Full. <c>[GET /api/hierarchyview/full]</c></summary>
    public Task<JsonNode?> FullAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/hierarchyview/full", null, null, ct);
}

/// <summary>HiokCloudGroups operations.</summary>
public sealed partial class HiokCloudGroupsApi
{
    private readonly HiokClient _c;
    internal HiokCloudGroupsApi(HiokClient client) => _c = client;

    /// <summary>Create hiok cloud access group. <c>[POST /api/HiokCloudGroups/createaccessgroup]</c></summary>
    public Task<JsonNode?> CreateHiokCloudAccessGroupAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/HiokCloudGroups/createaccessgroup", body, null, ct);

    /// <summary>Create management group. <c>[POST /api/HiokCloudGroups/createmanagementgroup]</c></summary>
    public Task<JsonNode?> CreateManagementGroupAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/HiokCloudGroups/createmanagementgroup", body, null, ct);

    /// <summary>Create resource group. <c>[POST /api/HiokCloudGroups/createresourcegroup]</c></summary>
    public Task<JsonNode?> CreateResourceGroupAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/HiokCloudGroups/createresourcegroup", body, null, ct);

    /// <summary>Delete hiok cloud access group. <c>[DELETE /api/HiokCloudGroups/deleteaccessgroup]</c></summary>
    public Task<JsonNode?> DeleteHiokCloudAccessGroupAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/HiokCloudGroups/deleteaccessgroup", body, null, ct);

    /// <summary>Edit hiok cloud access group. <c>[PUT /api/HiokCloudGroups/editaccessgroup]</c></summary>
    public Task<JsonNode?> EditHiokCloudAccessGroupAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("PUT"), "/api/HiokCloudGroups/editaccessgroup", body, null, ct);

    /// <summary>Get all hiok cloud access group. <c>[GET /api/HiokCloudGroups/allaccessgroups]</c></summary>
    public Task<JsonNode?> GetAllHiokCloudAccessGroupAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/HiokCloudGroups/allaccessgroups", null, null, ct);

    /// <summary>Get hiok cloud access group. <c>[GET /api/HiokCloudGroups/accessgroups]</c></summary>
    public Task<JsonNode?> GetHiokCloudAccessGroupAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/HiokCloudGroups/accessgroups", null, null, ct);

    /// <summary>Get hiok cloud specific access group. <c>[GET /api/HiokCloudGroups/specificaccessgroups]</c></summary>
    public Task<JsonNode?> GetHiokCloudSpecificAccessGroupAsync(object? type = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/HiokCloudGroups/specificaccessgroups", null, new Dictionary<string, object?> { ["type"] = type }, ct);
}

/// <summary>HiokCloudHierarchy operations.</summary>
public sealed partial class HiokCloudHierarchyApi
{
    private readonly HiokClient _c;
    internal HiokCloudHierarchyApi(HiokClient client) => _c = client;

    /// <summary>Create hiok cloud hierarchy. <c>[POST /api/HiokCloudHierarchy]</c></summary>
    public Task<JsonNode?> CreateHiokCloudHierarchyAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/HiokCloudHierarchy", body, null, ct);

    /// <summary>Delete hiok cloud hierarchy. <c>[DELETE /api/HiokCloudHierarchy/deletehierarchy/{id}]</c></summary>
    public Task<JsonNode?> DeleteHiokCloudHierarchyAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/HiokCloudHierarchy/deletehierarchy/" + HiokClient.Segment(id), null, null, ct);

    /// <summary>Delete hiok cloud hierarchy node. <c>[DELETE /api/HiokCloudHierarchy/deletehierarchynode]</c></summary>
    public Task<JsonNode?> DeleteHiokCloudHierarchyNodeAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/HiokCloudHierarchy/deletehierarchynode", body, null, ct);

    /// <summary>Edit hiok cloud hierarchy. <c>[PUT /api/HiokCloudHierarchy/edithierarchy]</c></summary>
    public Task<JsonNode?> EditHiokCloudHierarchyAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("PUT"), "/api/HiokCloudHierarchy/edithierarchy", body, null, ct);

    /// <summary>Get all hierarchy. <c>[GET /api/HiokCloudHierarchy/hierarchies]</c></summary>
    public Task<JsonNode?> GetAllHierarchyAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/HiokCloudHierarchy/hierarchies", null, null, ct);

    /// <summary>Get hierarchy. <c>[GET /api/HiokCloudHierarchy/hierarchy/{id}]</c></summary>
    public Task<JsonNode?> GetHierarchyAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/HiokCloudHierarchy/hierarchy/" + HiokClient.Segment(id), null, null, ct);
}

/// <summary>HiokUsers operations.</summary>
public sealed partial class HiokUsersApi
{
    private readonly HiokClient _c;
    internal HiokUsersApi(HiokClient client) => _c = client;

    /// <summary>Delete user by id. <c>[DELETE /api/HiokUsers/removehiokuser/{emailId}]</c></summary>
    public Task<JsonNode?> DeleteUserByIdAsync(string emailId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/HiokUsers/removehiokuser/" + HiokClient.Segment(emailId), null, null, ct);

    /// <summary>Forgot password. <c>[POST /api/HiokUsers/forgotpassword]</c></summary>
    public Task<JsonNode?> ForgotPasswordAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/HiokUsers/forgotpassword", body, null, ct);

    /// <summary>Hiok user by id. <c>[GET /api/HiokUsers/hiokusersbyid/{emailId}]</c></summary>
    public Task<JsonNode?> HiokUserByIdAsync(string emailId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/HiokUsers/hiokusersbyid/" + HiokClient.Segment(emailId), null, null, ct);

    /// <summary>Hiok users. <c>[GET /api/HiokUsers/hiokusers]</c></summary>
    public Task<JsonNode?> HiokUsersAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/HiokUsers/hiokusers", null, null, ct);

    /// <summary>Register hiok user. <c>[POST /api/HiokUsers/registerhiokuser]</c></summary>
    public Task<JsonNode?> RegisterHiokUserAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/HiokUsers/registerhiokuser", body, null, ct);

    /// <summary>Resend verification. <c>[POST /api/HiokUsers/resendverification]</c></summary>
    public Task<JsonNode?> ResendVerificationAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/HiokUsers/resendverification", body, null, ct);

    /// <summary>Reset password. <c>[POST /api/HiokUsers/resetpassword]</c></summary>
    public Task<JsonNode?> ResetPasswordAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/HiokUsers/resetpassword", body, null, ct);

    /// <summary>Update user by id. <c>[PUT /api/HiokUsers/hiokuserupdate/{emailId}]</c></summary>
    public Task<JsonNode?> UpdateUserByIdAsync(string emailId, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("PUT"), "/api/HiokUsers/hiokuserupdate/" + HiokClient.Segment(emailId), body, null, ct);

    /// <summary>Verify email. <c>[POST /api/HiokUsers/verifyemail]</c></summary>
    public Task<JsonNode?> VerifyEmailAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/HiokUsers/verifyemail", body, null, ct);
}

/// <summary>Hybrid operations.</summary>
public sealed partial class HybridApi
{
    private readonly HiokClient _c;
    internal HybridApi(HiokClient client) => _c = client;

    /// <summary>Agent install. <c>[GET /api/hybrid/agent-install]</c></summary>
    public Task<JsonNode?> AgentInstallAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/hybrid/agent-install", null, null, ct);

    /// <summary>Delete. <c>[DELETE /api/hybrid/resources/{id}]</c></summary>
    public Task<JsonNode?> DeleteAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/hybrid/resources/" + HiokClient.Segment(id), null, null, ct);

    /// <summary>Heartbeat. <c>[POST /api/hybrid/heartbeat]</c></summary>
    public Task<JsonNode?> HeartbeatAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/hybrid/heartbeat", body, null, ct);

    /// <summary>List. <c>[GET /api/hybrid/resources]</c></summary>
    public Task<JsonNode?> ListAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/hybrid/resources", null, null, ct);

    /// <summary>List services. <c>[GET /api/hybrid/resources/{id}/services]</c></summary>
    public Task<JsonNode?> ListServicesAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/hybrid/resources/" + HiokClient.Segment(id) + "/services", null, null, ct);

    /// <summary>Metrics. <c>[GET /api/hybrid/resources/{id}/metrics]</c></summary>
    public Task<JsonNode?> MetricsAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/hybrid/resources/" + HiokClient.Segment(id) + "/metrics", null, null, ct);

    /// <summary>Provision edge. <c>[POST /api/hybrid/resources/{id}/edge]</c></summary>
    public Task<JsonNode?> ProvisionEdgeAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/hybrid/resources/" + HiokClient.Segment(id) + "/edge", null, null, ct);

    /// <summary>Publish service. <c>[POST /api/hybrid/resources/{id}/services]</c></summary>
    public Task<JsonNode?> PublishServiceAsync(string id, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/hybrid/resources/" + HiokClient.Segment(id) + "/services", body, null, ct);

    /// <summary>Register. <c>[POST /api/hybrid/resources]</c></summary>
    public Task<JsonNode?> RegisterAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/hybrid/resources", body, null, ct);

    /// <summary>Unpublish service. <c>[DELETE /api/hybrid/resources/{id}/services/{serviceId}]</c></summary>
    public Task<JsonNode?> UnpublishServiceAsync(string id, string serviceId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/hybrid/resources/" + HiokClient.Segment(id) + "/services/" + HiokClient.Segment(serviceId), null, null, ct);
}

/// <summary>Identity operations.</summary>
public sealed partial class IdentityApi
{
    private readonly HiokClient _c;
    internal IdentityApi(HiokClient client) => _c = client;

    /// <summary>Create. <c>[POST /api/identity]</c></summary>
    public Task<JsonNode?> CreateAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/identity", body, null, ct);

    /// <summary>Delete. <c>[DELETE /api/identity/{id}]</c></summary>
    public Task<JsonNode?> DeleteAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/identity/" + HiokClient.Segment(id), null, null, ct);

    /// <summary>For resource. <c>[GET /api/identity/for-resource/{resourceId}]</c></summary>
    public Task<JsonNode?> ForResourceAsync(string resourceId, object? resourceType = null, object? name = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/identity/for-resource/" + HiokClient.Segment(resourceId), null, new Dictionary<string, object?> { ["resourceType"] = resourceType, ["name"] = name }, ct);

    /// <summary>List. <c>[GET /api/identity]</c></summary>
    public Task<JsonNode?> ListAsync(object? kind = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/identity", null, new Dictionary<string, object?> { ["kind"] = kind }, ct);

    /// <summary>Regenerate. <c>[POST /api/identity/{id}/regenerate-secret]</c></summary>
    public Task<JsonNode?> RegenerateAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/identity/" + HiokClient.Segment(id) + "/regenerate-secret", null, null, ct);
}

/// <summary>Infrastructure operations.</summary>
public sealed partial class InfrastructureApi
{
    private readonly HiokClient _c;
    internal InfrastructureApi(HiokClient client) => _c = client;

    /// <summary>Allocate ip. <c>[POST /api/Infrastructure/ip-allocations]</c></summary>
    public Task<JsonNode?> AllocateIpAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Infrastructure/ip-allocations", body, null, ct);

    /// <summary>Get reverse. <c>[GET /api/Infrastructure/regions/{region}/reverse/{ip}]</c></summary>
    public Task<JsonNode?> GetReverseAsync(string region, string ip, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Infrastructure/regions/" + HiokClient.Segment(region) + "/reverse/" + HiokClient.Segment(ip), null, null, ct);

    /// <summary>Ip allocations. <c>[GET /api/Infrastructure/ip-allocations]</c></summary>
    public Task<JsonNode?> IpAllocationsAsync(object? region = null, object? includeReleased = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Infrastructure/ip-allocations", null, new Dictionary<string, object?> { ["region"] = region, ["includeReleased"] = includeReleased }, ct);

    /// <summary>Ip block. <c>[GET /api/Infrastructure/regions/{region}/ips/{block}]</c></summary>
    public Task<JsonNode?> IpBlockAsync(string region, string block, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Infrastructure/regions/" + HiokClient.Segment(region) + "/ips/" + HiokClient.Segment(block), null, null, ct);

    /// <summary>Ip pools. <c>[GET /api/Infrastructure/ip-pools]</c></summary>
    public Task<JsonNode?> IpPoolsAsync(object? region = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Infrastructure/ip-pools", null, new Dictionary<string, object?> { ["region"] = region }, ct);

    /// <summary>Ips. <c>[GET /api/Infrastructure/regions/{region}/ips]</c></summary>
    public Task<JsonNode?> IpsAsync(string region, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Infrastructure/regions/" + HiokClient.Segment(region) + "/ips", null, null, ct);

    /// <summary>Ips for resource. <c>[GET /api/Infrastructure/ip-allocations/resource/{resourceKind}/{resourceId}]</c></summary>
    public Task<JsonNode?> IpsForResourceAsync(string resourceKind, string resourceId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Infrastructure/ip-allocations/resource/" + HiokClient.Segment(resourceKind) + "/" + HiokClient.Segment(resourceId), null, null, ct);

    /// <summary>Reconcile ips. <c>[POST /api/Infrastructure/ip-allocations/reconcile]</c></summary>
    public Task<JsonNode?> ReconcileIpsAsync(object? region = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Infrastructure/ip-allocations/reconcile", null, new Dictionary<string, object?> { ["region"] = region }, ct);

    /// <summary>Regions. <c>[GET /api/Infrastructure/regions]</c></summary>
    public Task<JsonNode?> RegionsAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Infrastructure/regions", null, null, ct);

    /// <summary>Release ip. <c>[DELETE /api/Infrastructure/ip-allocations/{id}]</c></summary>
    public Task<JsonNode?> ReleaseIpAsync(string id, object? targetContainer = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/Infrastructure/ip-allocations/" + HiokClient.Segment(id), null, new Dictionary<string, object?> { ["targetContainer"] = targetContainer }, ct);

    /// <summary>Reverses. <c>[GET /api/Infrastructure/regions/{region}/ips/{block}/reverse]</c></summary>
    public Task<JsonNode?> ReversesAsync(string region, string block, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Infrastructure/regions/" + HiokClient.Segment(region) + "/ips/" + HiokClient.Segment(block) + "/reverse", null, null, ct);

    /// <summary>Server. <c>[GET /api/Infrastructure/regions/{region}/servers/{name}]</c></summary>
    public Task<JsonNode?> ServerAsync(string region, string name, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Infrastructure/regions/" + HiokClient.Segment(region) + "/servers/" + HiokClient.Segment(name), null, null, ct);

    /// <summary>Servers. <c>[GET /api/Infrastructure/regions/{region}/servers]</c></summary>
    public Task<JsonNode?> ServersAsync(string region, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Infrastructure/regions/" + HiokClient.Segment(region) + "/servers", null, null, ct);

    /// <summary>Set reverse. <c>[POST /api/Infrastructure/regions/{region}/reverse]</c></summary>
    public Task<JsonNode?> SetReverseAsync(string region, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Infrastructure/regions/" + HiokClient.Segment(region) + "/reverse", body, null, ct);
}

/// <summary>Integrations operations.</summary>
public sealed partial class IntegrationsApi
{
    private readonly HiokClient _c;
    internal IntegrationsApi(HiokClient client) => _c = client;

    /// <summary>Create. <c>[POST /api/integrations]</c></summary>
    public Task<JsonNode?> CreateAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/integrations", body, null, ct);

    /// <summary>Delete. <c>[DELETE /api/integrations/{id}]</c></summary>
    public Task<JsonNode?> DeleteAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/integrations/" + HiokClient.Segment(id), null, null, ct);

    /// <summary>Get. <c>[GET /api/integrations/{id}]</c></summary>
    public Task<JsonNode?> GetAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/integrations/" + HiokClient.Segment(id), null, null, ct);

    /// <summary>List. <c>[GET /api/integrations]</c></summary>
    public Task<JsonNode?> ListAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/integrations", null, null, ct);

    /// <summary>Test. <c>[POST /api/integrations/{id}/test]</c></summary>
    public Task<JsonNode?> TestAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/integrations/" + HiokClient.Segment(id) + "/test", null, null, ct);

    /// <summary>Update. <c>[PUT /api/integrations/{id}]</c></summary>
    public Task<JsonNode?> UpdateAsync(string id, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("PUT"), "/api/integrations/" + HiokClient.Segment(id), body, null, ct);
}

/// <summary>IoTDeviceGateway operations.</summary>
public sealed partial class IoTDeviceGatewayApi
{
    private readonly HiokClient _c;
    internal IoTDeviceGatewayApi(HiokClient client) => _c = client;

    /// <summary>Get twin. <c>[GET /api/iot/devices/{deviceId}/twin]</c></summary>
    public Task<JsonNode?> GetTwinAsync(string deviceId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/iot/devices/" + HiokClient.Segment(deviceId) + "/twin", null, null, ct);

    /// <summary>Patch reported. <c>[PATCH /api/iot/devices/{deviceId}/twin/reported]</c></summary>
    public Task<JsonNode?> PatchReportedAsync(string deviceId, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("PATCH"), "/api/iot/devices/" + HiokClient.Segment(deviceId) + "/twin/reported", body, null, ct);

    /// <summary>Pq complete. <c>[POST /api/iot/devices/{deviceId}/pq/complete]</c></summary>
    public Task<JsonNode?> PqCompleteAsync(string deviceId, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/iot/devices/" + HiokClient.Segment(deviceId) + "/pq/complete", body, null, ct);

    /// <summary>Pq handshake. <c>[POST /api/iot/devices/{deviceId}/pq/handshake]</c></summary>
    public Task<JsonNode?> PqHandshakeAsync(string deviceId, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/iot/devices/" + HiokClient.Segment(deviceId) + "/pq/handshake", body, null, ct);

    /// <summary>Receive commands. <c>[GET /api/iot/devices/{deviceId}/messages/devicebound]</c></summary>
    public Task<JsonNode?> ReceiveCommandsAsync(string deviceId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/iot/devices/" + HiokClient.Segment(deviceId) + "/messages/devicebound", null, null, ct);

    /// <summary>Send telemetry. <c>[POST /api/iot/devices/{deviceId}/messages/events]</c></summary>
    public Task<JsonNode?> SendTelemetryAsync(string deviceId, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/iot/devices/" + HiokClient.Segment(deviceId) + "/messages/events", body, null, ct);

    /// <summary>Stream. <c>[GET /api/iot/devices/{deviceId}/stream]</c></summary>
    public Task<JsonNode?> StreamAsync(string deviceId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/iot/devices/" + HiokClient.Segment(deviceId) + "/stream", null, null, ct);
}

/// <summary>IoTHub operations.</summary>
public sealed partial class IoTHubApi
{
    private readonly HiokClient _c;
    internal IoTHubApi(HiokClient client) => _c = client;

    /// <summary>Get io thubs. <c>[GET /api/IoTHub/iothubs]</c></summary>
    public Task<JsonNode?> GetIoTHubsAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/IoTHub/iothubs", null, null, ct);
}

/// <summary>IoTHubDevice operations.</summary>
public sealed partial class IoTHubDeviceApi
{
    private readonly HiokClient _c;
    internal IoTHubDeviceApi(HiokClient client) => _c = client;

    /// <summary>Get io thub devices. <c>[GET /api/IoTHubDevice/iothub/devices]</c></summary>
    public Task<JsonNode?> GetIoTHubDevicesAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/IoTHubDevice/iothub/devices", null, null, ct);

    /// <summary>Get io thub devices get. <c>[GET /api/IoTHubDevice/iothub/{iotHubId}/devices]</c></summary>
    public Task<JsonNode?> GetIoTHubDevicesGetAsync(string iotHubId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/IoTHubDevice/iothub/" + HiokClient.Segment(iotHubId) + "/devices", null, null, ct);
}

/// <summary>IoTHubDiagnostics operations.</summary>
public sealed partial class IoTHubDiagnosticsApi
{
    private readonly HiokClient _c;
    internal IoTHubDiagnosticsApi(HiokClient client) => _c = client;

    /// <summary>Create setting. <c>[POST /api/iothub/{hubId}/diagnostic-settings]</c></summary>
    public Task<JsonNode?> CreateSettingAsync(string hubId, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/iothub/" + HiokClient.Segment(hubId) + "/diagnostic-settings", body, null, ct);

    /// <summary>Delete setting. <c>[DELETE /api/iothub/{hubId}/diagnostic-settings/{id}]</c></summary>
    public Task<JsonNode?> DeleteSettingAsync(string hubId, string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/iothub/" + HiokClient.Segment(hubId) + "/diagnostic-settings/" + HiokClient.Segment(id), null, null, ct);

    /// <summary>Destinations. <c>[GET /api/iothub/diagnostic-destinations]</c></summary>
    public Task<JsonNode?> DestinationsAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/iothub/diagnostic-destinations", null, null, ct);

    /// <summary>List settings. <c>[GET /api/iothub/{hubId}/diagnostic-settings]</c></summary>
    public Task<JsonNode?> ListSettingsAsync(string hubId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/iothub/" + HiokClient.Segment(hubId) + "/diagnostic-settings", null, null, ct);

    /// <summary>Log categories. <c>[GET /api/iothub/log-categories]</c></summary>
    public Task<JsonNode?> LogCategoriesAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/iothub/log-categories", null, null, ct);

    /// <summary>Logs. <c>[GET /api/iothub/{hubId}/logs]</c></summary>
    public Task<JsonNode?> LogsAsync(string hubId, object? category = null, object? deviceId = null, object? limit = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/iothub/" + HiokClient.Segment(hubId) + "/logs", null, new Dictionary<string, object?> { ["category"] = category, ["deviceId"] = deviceId, ["limit"] = limit }, ct);

    /// <summary>Metric definitions. <c>[GET /api/iothub/metric-definitions]</c></summary>
    public Task<JsonNode?> MetricDefinitionsAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/iothub/metric-definitions", null, null, ct);

    /// <summary>Metrics. <c>[GET /api/iothub/{hubId}/metrics]</c></summary>
    public Task<JsonNode?> MetricsAsync(string hubId, object? hours = null, object? protocol = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/iothub/" + HiokClient.Segment(hubId) + "/metrics", null, new Dictionary<string, object?> { ["hours"] = hours, ["protocol"] = protocol }, ct);
}

/// <summary>IoTHubManagement operations.</summary>
public sealed partial class IoTHubManagementApi
{
    private readonly HiokClient _c;
    internal IoTHubManagementApi(HiokClient client) => _c = client;

    /// <summary>Connection string. <c>[GET /api/iothub/{hubId}/devices/{deviceId}/connection-string]</c></summary>
    public Task<JsonNode?> ConnectionStringAsync(string hubId, string deviceId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/iothub/" + HiokClient.Segment(hubId) + "/devices/" + HiokClient.Segment(deviceId) + "/connection-string", null, null, ct);

    /// <summary>Create device. <c>[POST /api/iothub/{hubId}/devices]</c></summary>
    public Task<JsonNode?> CreateDeviceAsync(string hubId, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/iothub/" + HiokClient.Segment(hubId) + "/devices", body, null, ct);

    /// <summary>Delete device. <c>[DELETE /api/iothub/{hubId}/devices/{deviceId}]</c></summary>
    public Task<JsonNode?> DeleteDeviceAsync(string hubId, string deviceId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/iothub/" + HiokClient.Segment(hubId) + "/devices/" + HiokClient.Segment(deviceId), null, null, ct);

    /// <summary>Delete hub. <c>[DELETE /api/iothub/{hubId}]</c></summary>
    public Task<JsonNode?> DeleteHubAsync(string hubId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/iothub/" + HiokClient.Segment(hubId), null, null, ct);

    /// <summary>Get twin. <c>[GET /api/iothub/{hubId}/devices/{deviceId}/twin]</c></summary>
    public Task<JsonNode?> GetTwinAsync(string hubId, string deviceId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/iothub/" + HiokClient.Segment(hubId) + "/devices/" + HiokClient.Segment(deviceId) + "/twin", null, null, ct);

    /// <summary>Messages. <c>[GET /api/iothub/{hubId}/devices/{deviceId}/messages]</c></summary>
    public Task<JsonNode?> MessagesAsync(string hubId, string deviceId, object? direction = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/iothub/" + HiokClient.Segment(hubId) + "/devices/" + HiokClient.Segment(deviceId) + "/messages", null, new Dictionary<string, object?> { ["direction"] = direction }, ct);

    /// <summary>Monitoring. <c>[GET /api/iothub/{hubId}/monitoring]</c></summary>
    public Task<JsonNode?> MonitoringAsync(string hubId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/iothub/" + HiokClient.Segment(hubId) + "/monitoring", null, null, ct);

    /// <summary>Receive c2 d. <c>[POST /api/iothub/{hubId}/devices/{deviceId}/c2d/receive]</c></summary>
    public Task<JsonNode?> ReceiveC2DAsync(string hubId, string deviceId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/iothub/" + HiokClient.Segment(hubId) + "/devices/" + HiokClient.Segment(deviceId) + "/c2d/receive", null, null, ct);

    /// <summary>Regenerate key. <c>[POST /api/iothub/{hubId}/devices/{deviceId}/regenerate-key]</c></summary>
    public Task<JsonNode?> RegenerateKeyAsync(string hubId, string deviceId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/iothub/" + HiokClient.Segment(hubId) + "/devices/" + HiokClient.Segment(deviceId) + "/regenerate-key", null, null, ct);

    /// <summary>Send c2 d. <c>[POST /api/iothub/{hubId}/devices/{deviceId}/c2d]</c></summary>
    public Task<JsonNode?> SendC2DAsync(string hubId, string deviceId, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/iothub/" + HiokClient.Segment(hubId) + "/devices/" + HiokClient.Segment(deviceId) + "/c2d", body, null, ct);

    /// <summary>Send telemetry. <c>[POST /api/iothub/{hubId}/devices/{deviceId}/telemetry]</c></summary>
    public Task<JsonNode?> SendTelemetryAsync(string hubId, string deviceId, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/iothub/" + HiokClient.Segment(hubId) + "/devices/" + HiokClient.Segment(deviceId) + "/telemetry", body, null, ct);

    /// <summary>Update twin. <c>[PATCH /api/iothub/{hubId}/devices/{deviceId}/twin]</c></summary>
    public Task<JsonNode?> UpdateTwinAsync(string hubId, string deviceId, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("PATCH"), "/api/iothub/" + HiokClient.Segment(hubId) + "/devices/" + HiokClient.Segment(deviceId) + "/twin", body, null, ct);
}

/// <summary>IoTHubProtocol operations.</summary>
public sealed partial class IoTHubProtocolApi
{
    private readonly HiokClient _c;
    internal IoTHubProtocolApi(HiokClient client) => _c = client;

    /// <summary>Algorithms. <c>[GET /api/iothub/algorithms]</c></summary>
    public Task<JsonNode?> AlgorithmsAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/iothub/algorithms", null, null, ct);

    /// <summary>Ca certificate. <c>[GET /api/iothub/{hubId}/ca]</c></summary>
    public Task<JsonNode?> CaCertificateAsync(string hubId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/iothub/" + HiokClient.Segment(hubId) + "/ca", null, null, ct);

    /// <summary>Certificates. <c>[GET /api/iothub/{hubId}/certificates]</c></summary>
    public Task<JsonNode?> CertificatesAsync(string hubId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/iothub/" + HiokClient.Segment(hubId) + "/certificates", null, null, ct);

    /// <summary>Connections. <c>[GET /api/iothub/{hubId}/connections]</c></summary>
    public Task<JsonNode?> ConnectionsAsync(string hubId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/iothub/" + HiokClient.Segment(hubId) + "/connections", null, null, ct);

    /// <summary>Issue certificate. <c>[POST /api/iothub/{hubId}/devices/{deviceId}/certificate]</c></summary>
    public Task<JsonNode?> IssueCertificateAsync(string hubId, string deviceId, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/iothub/" + HiokClient.Segment(hubId) + "/devices/" + HiokClient.Segment(deviceId) + "/certificate", body, null, ct);

    /// <summary>Pq sessions. <c>[GET /api/iothub/{hubId}/pq-sessions]</c></summary>
    public Task<JsonNode?> PqSessionsAsync(string hubId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/iothub/" + HiokClient.Segment(hubId) + "/pq-sessions", null, null, ct);

    /// <summary>Protocols. <c>[GET /api/iothub/protocols]</c></summary>
    public Task<JsonNode?> ProtocolsAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/iothub/protocols", null, null, ct);

    /// <summary>Provision. <c>[POST /api/iothub/{hubId}/provision]</c></summary>
    public Task<JsonNode?> ProvisionAsync(string hubId, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/iothub/" + HiokClient.Segment(hubId) + "/provision", body, null, ct);
}

/// <summary>K9sConsole operations.</summary>
public sealed partial class K9sConsoleApi
{
    private readonly HiokClient _c;
    internal K9sConsoleApi(HiokClient client) => _c = client;

    /// <summary>Console. <c>[GET /api/kubernetes/clusters/{id}/console]</c></summary>
    public Task<JsonNode?> ConsoleAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/kubernetes/clusters/" + HiokClient.Segment(id) + "/console", null, null, ct);

    /// <summary>Status. <c>[GET /api/kubernetes/clusters/{id}/console/status]</c></summary>
    public Task<JsonNode?> StatusAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/kubernetes/clusters/" + HiokClient.Segment(id) + "/console/status", null, null, ct);
}

/// <summary>KeyVault operations.</summary>
public sealed partial class KeyVaultApi
{
    private readonly HiokClient _c;
    internal KeyVaultApi(HiokClient client) => _c = client;

    /// <summary>Create. <c>[POST /api/KeyVault]</c></summary>
    public Task<JsonNode?> CreateAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/KeyVault", body, null, ct);

    /// <summary>Create certificate. <c>[POST /api/KeyVault/{id}/certificates]</c></summary>
    public Task<JsonNode?> CreateCertificateAsync(string id, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/KeyVault/" + HiokClient.Segment(id) + "/certificates", body, null, ct);

    /// <summary>Delete. <c>[DELETE /api/KeyVault/{id}]</c></summary>
    public Task<JsonNode?> DeleteAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/KeyVault/" + HiokClient.Segment(id), null, null, ct);

    /// <summary>Delete item. <c>[DELETE /api/KeyVault/{id}/items/{name}]</c></summary>
    public Task<JsonNode?> DeleteItemAsync(string id, string name, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/KeyVault/" + HiokClient.Segment(id) + "/items/" + HiokClient.Segment(name), null, null, ct);

    /// <summary>Download csr. <c>[GET /api/KeyVault/{id}/certificates/{name}/csr]</c></summary>
    public Task<JsonNode?> DownloadCsrAsync(string id, string name, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/KeyVault/" + HiokClient.Segment(id) + "/certificates/" + HiokClient.Segment(name) + "/csr", null, null, ct);

    /// <summary>Export certificate. <c>[POST /api/KeyVault/{id}/certificates/{name}/export]</c></summary>
    public Task<JsonNode?> ExportCertificateAsync(string id, string name, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/KeyVault/" + HiokClient.Segment(id) + "/certificates/" + HiokClient.Segment(name) + "/export", body, null, ct);

    /// <summary>Get. <c>[GET /api/KeyVault/{id}]</c></summary>
    public Task<JsonNode?> GetAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/KeyVault/" + HiokClient.Segment(id), null, null, ct);

    /// <summary>Get item. <c>[GET /api/KeyVault/{id}/items/{name}]</c></summary>
    public Task<JsonNode?> GetItemAsync(string id, string name, object? version = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/KeyVault/" + HiokClient.Segment(id) + "/items/" + HiokClient.Segment(name), null, new Dictionary<string, object?> { ["version"] = version }, ct);

    /// <summary>List. <c>[GET /api/KeyVault]</c></summary>
    public Task<JsonNode?> ListAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/KeyVault", null, null, ct);

    /// <summary>List deleted. <c>[GET /api/KeyVault/deleted]</c></summary>
    public Task<JsonNode?> ListDeletedAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/KeyVault/deleted", null, null, ct);

    /// <summary>List items. <c>[GET /api/KeyVault/{id}/items]</c></summary>
    public Task<JsonNode?> ListItemsAsync(string id, object? itemType = null, object? includeDeleted = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/KeyVault/" + HiokClient.Segment(id) + "/items", null, new Dictionary<string, object?> { ["itemType"] = itemType, ["includeDeleted"] = includeDeleted }, ct);

    /// <summary>List versions. <c>[GET /api/KeyVault/{id}/items/{name}/versions]</c></summary>
    public Task<JsonNode?> ListVersionsAsync(string id, string name, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/KeyVault/" + HiokClient.Segment(id) + "/items/" + HiokClient.Segment(name) + "/versions", null, null, ct);

    /// <summary>Merge certificate. <c>[POST /api/KeyVault/{id}/certificates/{name}/merge]</c></summary>
    public Task<JsonNode?> MergeCertificateAsync(string id, string name, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/KeyVault/" + HiokClient.Segment(id) + "/certificates/" + HiokClient.Segment(name) + "/merge", body, null, ct);

    /// <summary>Purge. <c>[DELETE /api/KeyVault/{id}/purge]</c></summary>
    public Task<JsonNode?> PurgeAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/KeyVault/" + HiokClient.Segment(id) + "/purge", null, null, ct);

    /// <summary>Recover. <c>[POST /api/KeyVault/{id}/recover]</c></summary>
    public Task<JsonNode?> RecoverAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/KeyVault/" + HiokClient.Segment(id) + "/recover", null, null, ct);

    /// <summary>Recover item. <c>[POST /api/KeyVault/{id}/items/{name}/recover]</c></summary>
    public Task<JsonNode?> RecoverItemAsync(string id, string name, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/KeyVault/" + HiokClient.Segment(id) + "/items/" + HiokClient.Segment(name) + "/recover", null, null, ct);

    /// <summary>Set item. <c>[POST /api/KeyVault/{id}/items]</c></summary>
    public Task<JsonNode?> SetItemAsync(string id, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/KeyVault/" + HiokClient.Segment(id) + "/items", body, null, ct);

    /// <summary>Update. <c>[PUT /api/KeyVault/{id}]</c></summary>
    public Task<JsonNode?> UpdateAsync(string id, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("PUT"), "/api/KeyVault/" + HiokClient.Segment(id), body, null, ct);

    /// <summary>Update item. <c>[PUT /api/KeyVault/{id}/items/{name}]</c></summary>
    public Task<JsonNode?> UpdateItemAsync(string id, string name, object? body = null, object? version = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("PUT"), "/api/KeyVault/" + HiokClient.Segment(id) + "/items/" + HiokClient.Segment(name), body, new Dictionary<string, object?> { ["version"] = version }, ct);
}

/// <summary>Kubernetes operations.</summary>
public sealed partial class KubernetesApi
{
    private readonly HiokClient _c;
    internal KubernetesApi(HiokClient client) => _c = client;

    /// <summary>Add pool. <c>[POST /api/kubernetes/clusters/{id}/node-pools]</c></summary>
    public Task<JsonNode?> AddPoolAsync(string id, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/kubernetes/clusters/" + HiokClient.Segment(id) + "/node-pools", body, null, ct);

    /// <summary>Cordon. <c>[POST /api/kubernetes/clusters/{id}/nodes/{name}/cordon]</c></summary>
    public Task<JsonNode?> CordonAsync(string id, string name, object? undo = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/kubernetes/clusters/" + HiokClient.Segment(id) + "/nodes/" + HiokClient.Segment(name) + "/cordon", null, new Dictionary<string, object?> { ["undo"] = undo }, ct);

    /// <summary>Create. <c>[POST /api/kubernetes/clusters]</c></summary>
    public Task<JsonNode?> CreateAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/kubernetes/clusters", body, null, ct);

    /// <summary>Delete. <c>[DELETE /api/kubernetes/clusters/{id}]</c></summary>
    public Task<JsonNode?> DeleteAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/kubernetes/clusters/" + HiokClient.Segment(id), null, null, ct);

    /// <summary>Delete pod. <c>[DELETE /api/kubernetes/clusters/{id}/pods/{ns}/{name}]</c></summary>
    public Task<JsonNode?> DeletePodAsync(string id, string ns, string name, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/kubernetes/clusters/" + HiokClient.Segment(id) + "/pods/" + HiokClient.Segment(ns) + "/" + HiokClient.Segment(name), null, null, ct);

    /// <summary>Get. <c>[GET /api/kubernetes/clusters/{id}]</c></summary>
    public Task<JsonNode?> GetAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/kubernetes/clusters/" + HiokClient.Segment(id), null, null, ct);

    /// <summary>Kubeconfig. <c>[GET /api/kubernetes/clusters/{id}/kubeconfig]</c></summary>
    public Task<JsonNode?> KubeconfigAsync(string id, object? external = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/kubernetes/clusters/" + HiokClient.Segment(id) + "/kubeconfig", null, new Dictionary<string, object?> { ["external"] = external }, ct);

    /// <summary>Kubectl. <c>[POST /api/kubernetes/clusters/{id}/kubectl]</c></summary>
    public Task<JsonNode?> KubectlAsync(string id, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/kubernetes/clusters/" + HiokClient.Segment(id) + "/kubectl", body, null, ct);

    /// <summary>List. <c>[GET /api/kubernetes/clusters]</c></summary>
    public Task<JsonNode?> ListAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/kubernetes/clusters", null, null, ct);

    /// <summary>Remove pool. <c>[DELETE /api/kubernetes/clusters/{id}/node-pools/{poolId}]</c></summary>
    public Task<JsonNode?> RemovePoolAsync(string id, string poolId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/kubernetes/clusters/" + HiokClient.Segment(id) + "/node-pools/" + HiokClient.Segment(poolId), null, null, ct);

    /// <summary>Resources. <c>[GET /api/kubernetes/clusters/{id}/resources/{kind}]</c></summary>
    public Task<JsonNode?> ResourcesAsync(string id, string kind, object? ns = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/kubernetes/clusters/" + HiokClient.Segment(id) + "/resources/" + HiokClient.Segment(kind), null, new Dictionary<string, object?> { ["ns"] = ns }, ct);

    /// <summary>Restart workload. <c>[POST /api/kubernetes/clusters/{id}/workloads/{kind}/{ns}/{name}/restart]</c></summary>
    public Task<JsonNode?> RestartWorkloadAsync(string id, string kind, string ns, string name, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/kubernetes/clusters/" + HiokClient.Segment(id) + "/workloads/" + HiokClient.Segment(kind) + "/" + HiokClient.Segment(ns) + "/" + HiokClient.Segment(name) + "/restart", null, null, ct);

    /// <summary>Scale. <c>[POST /api/kubernetes/clusters/{id}/workloads/{kind}/{ns}/{name}/scale]</c></summary>
    public Task<JsonNode?> ScaleAsync(string id, string kind, string ns, string name, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/kubernetes/clusters/" + HiokClient.Segment(id) + "/workloads/" + HiokClient.Segment(kind) + "/" + HiokClient.Segment(ns) + "/" + HiokClient.Segment(name) + "/scale", body, null, ct);
}

/// <summary>MailAdmin operations.</summary>
public sealed partial class MailAdminApi
{
    private readonly HiokClient _c;
    internal MailAdminApi(HiokClient client) => _c = client;

    /// <summary>Accounts. <c>[GET /api/mail/admin/accounts]</c></summary>
    public Task<JsonNode?> AccountsAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/mail/admin/accounts", null, null, ct);

    /// <summary>Create. <c>[POST /api/mail/admin/accounts]</c></summary>
    public Task<JsonNode?> CreateAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/mail/admin/accounts", body, null, ct);

    /// <summary>Delete. <c>[DELETE /api/mail/admin/accounts/{id}]</c></summary>
    public Task<JsonNode?> DeleteAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/mail/admin/accounts/" + HiokClient.Segment(id), null, null, ct);

    /// <summary>Domains. <c>[GET /api/mail/admin/domains]</c></summary>
    public Task<JsonNode?> DomainsAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/mail/admin/domains", null, null, ct);

    /// <summary>Grant. <c>[POST /api/mail/admin/accounts/{id}/access]</c></summary>
    public Task<JsonNode?> GrantAsync(string id, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/mail/admin/accounts/" + HiokClient.Segment(id) + "/access", body, null, ct);

    /// <summary>Revoke. <c>[DELETE /api/mail/admin/accounts/{id}/access/{emailId}]</c></summary>
    public Task<JsonNode?> RevokeAsync(string id, string emailId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/mail/admin/accounts/" + HiokClient.Segment(id) + "/access/" + HiokClient.Segment(emailId), null, null, ct);

    /// <summary>Set password. <c>[POST /api/mail/admin/accounts/{id}/password]</c></summary>
    public Task<JsonNode?> SetPasswordAsync(string id, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/mail/admin/accounts/" + HiokClient.Segment(id) + "/password", body, null, ct);

    /// <summary>Update. <c>[PATCH /api/mail/admin/accounts/{id}]</c></summary>
    public Task<JsonNode?> UpdateAsync(string id, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("PATCH"), "/api/mail/admin/accounts/" + HiokClient.Segment(id), body, null, ct);
}

/// <summary>Marketplace operations.</summary>
public sealed partial class MarketplaceApi
{
    private readonly HiokClient _c;
    internal MarketplaceApi(HiokClient client) => _c = client;

    /// <summary>Categories. <c>[GET /api/Marketplace/categories]</c></summary>
    public Task<JsonNode?> CategoriesAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Marketplace/categories", null, null, ct);

    /// <summary>Connections. <c>[GET /api/Marketplace/connections]</c></summary>
    public Task<JsonNode?> ConnectionsAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Marketplace/connections", null, null, ct);

    /// <summary>Delete deployment. <c>[DELETE /api/Marketplace/deployments/{id}]</c></summary>
    public Task<JsonNode?> DeleteDeploymentAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/Marketplace/deployments/" + HiokClient.Segment(id), null, null, ct);

    /// <summary>Deploy. <c>[POST /api/Marketplace/deploy]</c></summary>
    public Task<JsonNode?> DeployAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Marketplace/deploy", body, null, ct);

    /// <summary>Deployments. <c>[GET /api/Marketplace/deployments]</c></summary>
    public Task<JsonNode?> DeploymentsAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Marketplace/deployments", null, null, ct);

    /// <summary>Offer. <c>[GET /api/Marketplace/offers/{slug}]</c></summary>
    public Task<JsonNode?> OfferAsync(string slug, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Marketplace/offers/" + HiokClient.Segment(slug), null, null, ct);

    /// <summary>Offers. <c>[GET /api/Marketplace/offers]</c></summary>
    public Task<JsonNode?> OffersAsync(object? search = null, object? category = null, object? source = null, object? delivery = null, object? featured = null, object? take = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Marketplace/offers", null, new Dictionary<string, object?> { ["search"] = search, ["category"] = category, ["source"] = source, ["delivery"] = delivery, ["featured"] = featured, ["take"] = take }, ct);

    /// <summary>Publish. <c>[POST /api/Marketplace/offers]</c></summary>
    public Task<JsonNode?> PublishAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Marketplace/offers", body, null, ct);

    /// <summary>Save connection. <c>[POST /api/Marketplace/connections]</c></summary>
    public Task<JsonNode?> SaveConnectionAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Marketplace/connections", body, null, ct);

    /// <summary>Sync. <c>[POST /api/Marketplace/connections/{id}/sync]</c></summary>
    public Task<JsonNode?> SyncAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Marketplace/connections/" + HiokClient.Segment(id) + "/sync", null, null, ct);

    /// <summary>Unpublish. <c>[DELETE /api/Marketplace/offers/{id}]</c></summary>
    public Task<JsonNode?> UnpublishAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/Marketplace/offers/" + HiokClient.Segment(id), null, null, ct);
}

/// <summary>Metrics operations.</summary>
public sealed partial class MetricsApi
{
    private readonly HiokClient _c;
    internal MetricsApi(HiokClient client) => _c = client;

    /// <summary>Get. <c>[GET /api/metrics/{resourceId}]</c></summary>
    public Task<JsonNode?> GetAsync(string resourceId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/metrics/" + HiokClient.Segment(resourceId), null, null, ct);

    /// <summary>Get file operation metrics. <c>[GET /api/Metrics/storage/{storageAccountId}/operations]</c></summary>
    public Task<JsonNode?> GetFileOperationMetricsAsync(string storageAccountId, object? limit = null, object? region = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Metrics/storage/" + HiokClient.Segment(storageAccountId) + "/operations", null, new Dictionary<string, object?> { ["limit"] = limit, ["region"] = region }, ct);

    /// <summary>Get quick stats. <c>[GET /api/Metrics/storage/{storageAccountId}/stats]</c></summary>
    public Task<JsonNode?> GetQuickStatsAsync(string storageAccountId, object? region = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Metrics/storage/" + HiokClient.Segment(storageAccountId) + "/stats", null, new Dictionary<string, object?> { ["region"] = region }, ct);

    /// <summary>Get request metrics. <c>[GET /api/Metrics/storage/{storageAccountId}/requests]</c></summary>
    public Task<JsonNode?> GetRequestMetricsAsync(string storageAccountId, object? range = null, object? region = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Metrics/storage/" + HiokClient.Segment(storageAccountId) + "/requests", null, new Dictionary<string, object?> { ["range"] = range, ["region"] = region }, ct);

    /// <summary>Get storage metrics. <c>[GET /api/Metrics/storage/{storageAccountId}]</c></summary>
    public Task<JsonNode?> GetStorageMetricsAsync(string storageAccountId, object? range = null, object? region = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Metrics/storage/" + HiokClient.Segment(storageAccountId), null, new Dictionary<string, object?> { ["range"] = range, ["region"] = region }, ct);

    /// <summary>Ingest storage metric. <c>[POST /api/Metrics/ingest/storage]</c></summary>
    public Task<JsonNode?> IngestStorageMetricAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Metrics/ingest/storage", body, null, ct);
}

/// <summary>Mongo operations.</summary>
public sealed partial class MongoApi
{
    private readonly HiokClient _c;
    internal MongoApi(HiokClient client) => _c = client;

    /// <summary>Collections. <c>[GET /api/Mongo/{id}/databases/{database}/collections]</c></summary>
    public Task<JsonNode?> CollectionsAsync(string id, string database, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Mongo/" + HiokClient.Segment(id) + "/databases/" + HiokClient.Segment(database) + "/collections", null, null, ct);

    /// <summary>Connection. <c>[GET /api/Mongo/{id}/connection]</c></summary>
    public Task<JsonNode?> ConnectionAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Mongo/" + HiokClient.Segment(id) + "/connection", null, null, ct);

    /// <summary>Create. <c>[POST /api/Mongo]</c></summary>
    public Task<JsonNode?> CreateAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Mongo", body, null, ct);

    /// <summary>Databases. <c>[GET /api/Mongo/{id}/databases]</c></summary>
    public Task<JsonNode?> DatabasesAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Mongo/" + HiokClient.Segment(id) + "/databases", null, null, ct);

    /// <summary>Delete. <c>[DELETE /api/Mongo/{id}]</c></summary>
    public Task<JsonNode?> DeleteAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/Mongo/" + HiokClient.Segment(id), null, null, ct);

    /// <summary>Get. <c>[GET /api/Mongo/{id}]</c></summary>
    public Task<JsonNode?> GetAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Mongo/" + HiokClient.Segment(id), null, null, ct);

    /// <summary>List. <c>[GET /api/Mongo]</c></summary>
    public Task<JsonNode?> ListAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Mongo", null, null, ct);

    /// <summary>Replica status. <c>[GET /api/Mongo/{id}/replica-status]</c></summary>
    public Task<JsonNode?> ReplicaStatusAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Mongo/" + HiokClient.Segment(id) + "/replica-status", null, null, ct);

    /// <summary>Run command. <c>[POST /api/Mongo/{id}/command]</c></summary>
    public Task<JsonNode?> RunCommandAsync(string id, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Mongo/" + HiokClient.Segment(id) + "/command", body, null, ct);

    /// <summary>Set consistency. <c>[PUT /api/Mongo/{id}/consistency]</c></summary>
    public Task<JsonNode?> SetConsistencyAsync(string id, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("PUT"), "/api/Mongo/" + HiokClient.Segment(id) + "/consistency", body, null, ct);

    /// <summary>Start. <c>[POST /api/Mongo/{id}/start]</c></summary>
    public Task<JsonNode?> StartAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Mongo/" + HiokClient.Segment(id) + "/start", null, null, ct);

    /// <summary>Stop. <c>[POST /api/Mongo/{id}/stop]</c></summary>
    public Task<JsonNode?> StopAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Mongo/" + HiokClient.Segment(id) + "/stop", null, null, ct);
}

/// <summary>MySqlDatabase operations.</summary>
public sealed partial class MySqlDatabaseApi
{
    private readonly HiokClient _c;
    internal MySqlDatabaseApi(HiokClient client) => _c = client;

    /// <summary>Columns. <c>[GET /api/MySqlDatabase/{id}/objects/{schema}/{table}/columns]</c></summary>
    public Task<JsonNode?> ColumnsAsync(string id, string schema, string table, object? database = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/MySqlDatabase/" + HiokClient.Segment(id) + "/objects/" + HiokClient.Segment(schema) + "/" + HiokClient.Segment(table) + "/columns", null, new Dictionary<string, object?> { ["database"] = database }, ct);

    /// <summary>Connection. <c>[GET /api/MySqlDatabase/{id}/connection]</c></summary>
    public Task<JsonNode?> ConnectionAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/MySqlDatabase/" + HiokClient.Segment(id) + "/connection", null, null, ct);

    /// <summary>Create. <c>[POST /api/MySqlDatabase]</c></summary>
    public Task<JsonNode?> CreateAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/MySqlDatabase", body, null, ct);

    /// <summary>Databases. <c>[GET /api/MySqlDatabase/{id}/databases]</c></summary>
    public Task<JsonNode?> DatabasesAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/MySqlDatabase/" + HiokClient.Segment(id) + "/databases", null, null, ct);

    /// <summary>Delete. <c>[DELETE /api/MySqlDatabase/{id}]</c></summary>
    public Task<JsonNode?> DeleteAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/MySqlDatabase/" + HiokClient.Segment(id), null, null, ct);

    /// <summary>Get. <c>[GET /api/MySqlDatabase/{id}]</c></summary>
    public Task<JsonNode?> GetAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/MySqlDatabase/" + HiokClient.Segment(id), null, null, ct);

    /// <summary>List. <c>[GET /api/MySqlDatabase]</c></summary>
    public Task<JsonNode?> ListAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/MySqlDatabase", null, null, ct);

    /// <summary>Objects. <c>[GET /api/MySqlDatabase/{id}/objects]</c></summary>
    public Task<JsonNode?> ObjectsAsync(string id, object? database = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/MySqlDatabase/" + HiokClient.Segment(id) + "/objects", null, new Dictionary<string, object?> { ["database"] = database }, ct);

    /// <summary>Query. <c>[POST /api/MySqlDatabase/{id}/query]</c></summary>
    public Task<JsonNode?> QueryAsync(string id, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/MySqlDatabase/" + HiokClient.Segment(id) + "/query", body, null, ct);

    /// <summary>Reset password. <c>[POST /api/MySqlDatabase/{id}/reset-password]</c></summary>
    public Task<JsonNode?> ResetPasswordAsync(string id, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/MySqlDatabase/" + HiokClient.Segment(id) + "/reset-password", body, null, ct);
}

/// <summary>NetworkAccess operations.</summary>
public sealed partial class NetworkAccessApi
{
    private readonly HiokClient _c;
    internal NetworkAccessApi(HiokClient client) => _c = client;

    /// <summary>Create endpoint. <c>[POST /api/network-access/{resourceType}/{resourceId}/private-endpoints]</c></summary>
    public Task<JsonNode?> CreateEndpointAsync(string resourceType, string resourceId, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/network-access/" + HiokClient.Segment(resourceType) + "/" + HiokClient.Segment(resourceId) + "/private-endpoints", body, null, ct);

    /// <summary>Delete endpoint. <c>[DELETE /api/network-access/{resourceType}/{resourceId}/private-endpoints/{id}]</c></summary>
    public Task<JsonNode?> DeleteEndpointAsync(string resourceType, string resourceId, string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/network-access/" + HiokClient.Segment(resourceType) + "/" + HiokClient.Segment(resourceId) + "/private-endpoints/" + HiokClient.Segment(id), null, null, ct);

    /// <summary>Get. <c>[GET /api/network-access/{resourceType}/{resourceId}]</c></summary>
    public Task<JsonNode?> GetAsync(string resourceType, string resourceId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/network-access/" + HiokClient.Segment(resourceType) + "/" + HiokClient.Segment(resourceId), null, null, ct);

    /// <summary>List endpoints. <c>[GET /api/network-access/{resourceType}/{resourceId}/private-endpoints]</c></summary>
    public Task<JsonNode?> ListEndpointsAsync(string resourceType, string resourceId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/network-access/" + HiokClient.Segment(resourceType) + "/" + HiokClient.Segment(resourceId) + "/private-endpoints", null, null, ct);

    /// <summary>Set. <c>[PUT /api/network-access/{resourceType}/{resourceId}]</c></summary>
    public Task<JsonNode?> SetAsync(string resourceType, string resourceId, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("PUT"), "/api/network-access/" + HiokClient.Segment(resourceType) + "/" + HiokClient.Segment(resourceId), body, null, ct);

    /// <summary>Source presets. <c>[GET /api/network-access/source-presets]</c></summary>
    public Task<JsonNode?> SourcePresetsAsync(object? resourceType = null, object? resourceId = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/network-access/source-presets", null, new Dictionary<string, object?> { ["resourceType"] = resourceType, ["resourceId"] = resourceId }, ct);
}

/// <summary>Notification operations.</summary>
public sealed partial class NotificationApi
{
    private readonly HiokClient _c;
    internal NotificationApi(HiokClient client) => _c = client;

    /// <summary>Get notification. <c>[GET /api/Notification/notification]</c></summary>
    public Task<JsonNode?> GetNotificationAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Notification/notification", null, null, ct);
}

/// <summary>OAuth operations.</summary>
public sealed partial class OAuthApi
{
    private readonly HiokClient _c;
    internal OAuthApi(HiokClient client) => _c = client;

    /// <summary>Get client token. <c>[POST /api/OAuth/token/client]</c></summary>
    public Task<JsonNode?> GetClientTokenAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/OAuth/token/client", body, null, ct);

    /// <summary>Get token. <c>[POST /api/OAuth/token]</c></summary>
    public Task<JsonNode?> GetTokenAsync(object? body = null, object? handoff = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/OAuth/token", body, new Dictionary<string, object?> { ["handoff"] = handoff }, ct);

    /// <summary>Redeem handoff. <c>[POST /api/OAuth/handoff/redeem]</c></summary>
    public Task<JsonNode?> RedeemHandoffAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/OAuth/handoff/redeem", body, null, ct);
}

/// <summary>OVS operations.</summary>
public sealed partial class OVSApi
{
    private readonly HiokClient _c;
    internal OVSApi(HiokClient client) => _c = client;

    /// <summary>Add port. <c>[POST /api/OVS/bridges/{bridgeId}/ports]</c></summary>
    public Task<JsonNode?> AddPortAsync(string bridgeId, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/OVS/bridges/" + HiokClient.Segment(bridgeId) + "/ports", body, null, ct);

    /// <summary>Create bridge. <c>[POST /api/OVS/bridges]</c></summary>
    public Task<JsonNode?> CreateBridgeAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/OVS/bridges", body, null, ct);

    /// <summary>Delete bridge. <c>[DELETE /api/OVS/bridges/{bridgeId}]</c></summary>
    public Task<JsonNode?> DeleteBridgeAsync(string bridgeId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/OVS/bridges/" + HiokClient.Segment(bridgeId), null, null, ct);

    /// <summary>Delete port. <c>[DELETE /api/OVS/bridges/{bridgeId}/ports/{portName}]</c></summary>
    public Task<JsonNode?> DeletePortAsync(string bridgeId, string portName, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/OVS/bridges/" + HiokClient.Segment(bridgeId) + "/ports/" + HiokClient.Segment(portName), null, null, ct);

    /// <summary>Get bridge. <c>[GET /api/OVS/bridges/{bridgeId}]</c></summary>
    public Task<JsonNode?> GetBridgeAsync(string bridgeId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/OVS/bridges/" + HiokClient.Segment(bridgeId), null, null, ct);

    /// <summary>List bridges. <c>[GET /api/OVS/bridges]</c></summary>
    public Task<JsonNode?> ListBridgesAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/OVS/bridges", null, null, ct);
}

/// <summary>Panel operations.</summary>
public sealed partial class PanelApi
{
    private readonly HiokClient _c;
    internal PanelApi(HiokClient client) => _c = client;

    /// <summary>Create panel. <c>[POST /api/Panel/createpanel]</c></summary>
    public Task<JsonNode?> CreatePanelAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Panel/createpanel", body, null, ct);

    /// <summary>Delete panel. <c>[DELETE /api/Panel/deletepanel/{id}]</c></summary>
    public Task<JsonNode?> DeletePanelAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/Panel/deletepanel/" + HiokClient.Segment(id), null, null, ct);

    /// <summary>Get panels. <c>[GET /api/Panel/panels]</c></summary>
    public Task<JsonNode?> GetPanelsAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Panel/panels", null, null, ct);

    /// <summary>Panel by id. <c>[GET /api/Panel/panel/{id}]</c></summary>
    public Task<JsonNode?> PanelByIdAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Panel/panel/" + HiokClient.Segment(id), null, null, ct);

    /// <summary>Update panel. <c>[PUT /api/Panel/updatepanel/{id}]</c></summary>
    public Task<JsonNode?> UpdatePanelAsync(string id, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("PUT"), "/api/Panel/updatepanel/" + HiokClient.Segment(id), body, null, ct);
}

/// <summary>PostgresDatabase operations.</summary>
public sealed partial class PostgresDatabaseApi
{
    private readonly HiokClient _c;
    internal PostgresDatabaseApi(HiokClient client) => _c = client;

    /// <summary>Columns. <c>[GET /api/PostgresDatabase/{id}/objects/{schema}/{table}/columns]</c></summary>
    public Task<JsonNode?> ColumnsAsync(string id, string schema, string table, object? database = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/PostgresDatabase/" + HiokClient.Segment(id) + "/objects/" + HiokClient.Segment(schema) + "/" + HiokClient.Segment(table) + "/columns", null, new Dictionary<string, object?> { ["database"] = database }, ct);

    /// <summary>Connection. <c>[GET /api/PostgresDatabase/{id}/connection]</c></summary>
    public Task<JsonNode?> ConnectionAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/PostgresDatabase/" + HiokClient.Segment(id) + "/connection", null, null, ct);

    /// <summary>Create. <c>[POST /api/PostgresDatabase]</c></summary>
    public Task<JsonNode?> CreateAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/PostgresDatabase", body, null, ct);

    /// <summary>Databases. <c>[GET /api/PostgresDatabase/{id}/databases]</c></summary>
    public Task<JsonNode?> DatabasesAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/PostgresDatabase/" + HiokClient.Segment(id) + "/databases", null, null, ct);

    /// <summary>Delete. <c>[DELETE /api/PostgresDatabase/{id}]</c></summary>
    public Task<JsonNode?> DeleteAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/PostgresDatabase/" + HiokClient.Segment(id), null, null, ct);

    /// <summary>Get. <c>[GET /api/PostgresDatabase/{id}]</c></summary>
    public Task<JsonNode?> GetAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/PostgresDatabase/" + HiokClient.Segment(id), null, null, ct);

    /// <summary>List. <c>[GET /api/PostgresDatabase]</c></summary>
    public Task<JsonNode?> ListAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/PostgresDatabase", null, null, ct);

    /// <summary>Objects. <c>[GET /api/PostgresDatabase/{id}/objects]</c></summary>
    public Task<JsonNode?> ObjectsAsync(string id, object? database = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/PostgresDatabase/" + HiokClient.Segment(id) + "/objects", null, new Dictionary<string, object?> { ["database"] = database }, ct);

    /// <summary>Query. <c>[POST /api/PostgresDatabase/{id}/query]</c></summary>
    public Task<JsonNode?> QueryAsync(string id, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/PostgresDatabase/" + HiokClient.Segment(id) + "/query", body, null, ct);

    /// <summary>Reset password. <c>[POST /api/PostgresDatabase/{id}/reset-password]</c></summary>
    public Task<JsonNode?> ResetPasswordAsync(string id, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/PostgresDatabase/" + HiokClient.Segment(id) + "/reset-password", body, null, ct);
}

/// <summary>Pricing operations.</summary>
public sealed partial class PricingApi
{
    private readonly HiokClient _c;
    internal PricingApi(HiokClient client) => _c = client;

    /// <summary>List. <c>[GET /api/Pricing]</c></summary>
    public Task<JsonNode?> ListAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Pricing", null, null, ct);

    /// <summary>Rate card. <c>[GET /api/Pricing/ratecard]</c></summary>
    public Task<JsonNode?> RateCardAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Pricing/ratecard", null, null, ct);

    /// <summary>Update. <c>[PUT /api/Pricing]</c></summary>
    public Task<JsonNode?> UpdateAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("PUT"), "/api/Pricing", body, null, ct);
}

/// <summary>Profile operations.</summary>
public sealed partial class ProfileApi
{
    private readonly HiokClient _c;
    internal ProfileApi(HiokClient client) => _c = client;

    /// <summary>Api keys. <c>[GET /api/profile/api-keys]</c></summary>
    public Task<JsonNode?> ApiKeysAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/profile/api-keys", null, null, ct);

    /// <summary>Get. <c>[GET /api/profile]</c></summary>
    public Task<JsonNode?> GetAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/profile", null, null, ct);

    /// <summary>Roll key. <c>[POST /api/profile/api-keys/{which}/roll]</c></summary>
    public Task<JsonNode?> RollKeyAsync(string which, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/profile/api-keys/" + HiokClient.Segment(which) + "/roll", null, null, ct);

    /// <summary>Update. <c>[PUT /api/profile]</c></summary>
    public Task<JsonNode?> UpdateAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("PUT"), "/api/profile", body, null, ct);
}

/// <summary>Pulse operations.</summary>
public sealed partial class PulseApi
{
    private readonly HiokClient _c;
    internal PulseApi(HiokClient client) => _c = client;

    /// <summary>Create consumer group. <c>[POST /api/Pulse/namespaces/{id}/streams/{stream}/consumer-groups]</c></summary>
    public Task<JsonNode?> CreateConsumerGroupAsync(string id, string stream, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Pulse/namespaces/" + HiokClient.Segment(id) + "/streams/" + HiokClient.Segment(stream) + "/consumer-groups", body, null, ct);

    /// <summary>Create event subscription. <c>[POST /api/Pulse/namespaces/{id}/streams/{stream}/subscriptions]</c></summary>
    public Task<JsonNode?> CreateEventSubscriptionAsync(string id, string stream, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Pulse/namespaces/" + HiokClient.Segment(id) + "/streams/" + HiokClient.Segment(stream) + "/subscriptions", body, null, ct);

    /// <summary>Create namespace. <c>[POST /api/Pulse/namespaces]</c></summary>
    public Task<JsonNode?> CreateNamespaceAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Pulse/namespaces", body, null, ct);

    /// <summary>Create stream. <c>[POST /api/Pulse/namespaces/{id}/streams]</c></summary>
    public Task<JsonNode?> CreateStreamAsync(string id, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Pulse/namespaces/" + HiokClient.Segment(id) + "/streams", body, null, ct);

    /// <summary>Delete consumer group. <c>[DELETE /api/Pulse/namespaces/{id}/streams/{stream}/consumer-groups/{name}]</c></summary>
    public Task<JsonNode?> DeleteConsumerGroupAsync(string id, string stream, string name, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/Pulse/namespaces/" + HiokClient.Segment(id) + "/streams/" + HiokClient.Segment(stream) + "/consumer-groups/" + HiokClient.Segment(name), null, null, ct);

    /// <summary>Delete event subscription. <c>[DELETE /api/Pulse/namespaces/{id}/streams/{stream}/subscriptions/{name}]</c></summary>
    public Task<JsonNode?> DeleteEventSubscriptionAsync(string id, string stream, string name, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/Pulse/namespaces/" + HiokClient.Segment(id) + "/streams/" + HiokClient.Segment(stream) + "/subscriptions/" + HiokClient.Segment(name), null, null, ct);

    /// <summary>Delete namespace. <c>[DELETE /api/Pulse/namespaces/{id}]</c></summary>
    public Task<JsonNode?> DeleteNamespaceAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/Pulse/namespaces/" + HiokClient.Segment(id), null, null, ct);

    /// <summary>Delete stream. <c>[DELETE /api/Pulse/namespaces/{id}/streams/{name}]</c></summary>
    public Task<JsonNode?> DeleteStreamAsync(string id, string name, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/Pulse/namespaces/" + HiokClient.Segment(id) + "/streams/" + HiokClient.Segment(name), null, null, ct);

    /// <summary>List consumer groups. <c>[GET /api/Pulse/namespaces/{id}/streams/{stream}/consumer-groups]</c></summary>
    public Task<JsonNode?> ListConsumerGroupsAsync(string id, string stream, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Pulse/namespaces/" + HiokClient.Segment(id) + "/streams/" + HiokClient.Segment(stream) + "/consumer-groups", null, null, ct);

    /// <summary>List deliveries. <c>[GET /api/Pulse/namespaces/{id}/streams/{stream}/subscriptions/{name}/deliveries]</c></summary>
    public Task<JsonNode?> ListDeliveriesAsync(string id, string stream, string name, object? limit = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Pulse/namespaces/" + HiokClient.Segment(id) + "/streams/" + HiokClient.Segment(stream) + "/subscriptions/" + HiokClient.Segment(name) + "/deliveries", null, new Dictionary<string, object?> { ["limit"] = limit }, ct);

    /// <summary>List event subscriptions. <c>[GET /api/Pulse/namespaces/{id}/streams/{stream}/subscriptions]</c></summary>
    public Task<JsonNode?> ListEventSubscriptionsAsync(string id, string stream, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Pulse/namespaces/" + HiokClient.Segment(id) + "/streams/" + HiokClient.Segment(stream) + "/subscriptions", null, null, ct);

    /// <summary>List namespaces. <c>[GET /api/Pulse/namespaces]</c></summary>
    public Task<JsonNode?> ListNamespacesAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Pulse/namespaces", null, null, ct);

    /// <summary>List streams. <c>[GET /api/Pulse/namespaces/{id}/streams]</c></summary>
    public Task<JsonNode?> ListStreamsAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Pulse/namespaces/" + HiokClient.Segment(id) + "/streams", null, null, ct);

    /// <summary>Publish. <c>[POST /api/Pulse/namespaces/{id}/streams/{stream}/events]</c></summary>
    public Task<JsonNode?> PublishAsync(string id, string stream, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Pulse/namespaces/" + HiokClient.Segment(id) + "/streams/" + HiokClient.Segment(stream) + "/events", body, null, ct);

    /// <summary>Read. <c>[POST /api/Pulse/namespaces/{id}/streams/{stream}/events/read]</c></summary>
    public Task<JsonNode?> ReadAsync(string id, string stream, object? consumerGroup = null, object? maxEvents = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Pulse/namespaces/" + HiokClient.Segment(id) + "/streams/" + HiokClient.Segment(stream) + "/events/read", null, new Dictionary<string, object?> { ["consumerGroup"] = consumerGroup, ["maxEvents"] = maxEvents }, ct);
}

/// <summary>RecentResources operations.</summary>
public sealed partial class RecentResourcesApi
{
    private readonly HiokClient _c;
    internal RecentResourcesApi(HiokClient client) => _c = client;

    /// <summary>Clear. <c>[DELETE /api/recent-resources]</c></summary>
    public Task<JsonNode?> ClearAsync(object? id = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/recent-resources", null, new Dictionary<string, object?> { ["id"] = id }, ct);

    /// <summary>List. <c>[GET /api/recent-resources]</c></summary>
    public Task<JsonNode?> ListAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/recent-resources", null, null, ct);

    /// <summary>Record. <c>[POST /api/recent-resources]</c></summary>
    public Task<JsonNode?> RecordAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/recent-resources", body, null, ct);

    /// <summary>Toggle favourite. <c>[POST /api/recent-resources/favourite]</c></summary>
    public Task<JsonNode?> ToggleFavouriteAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/recent-resources/favourite", body, null, ct);
}

/// <summary>ResourceGovernance operations.</summary>
public sealed partial class ResourceGovernanceApi
{
    private readonly HiokClient _c;
    internal ResourceGovernanceApi(HiokClient client) => _c = client;

    /// <summary>Create lock. <c>[POST /api/resource-governance/{resourceType}/{resourceId}/locks]</c></summary>
    public Task<JsonNode?> CreateLockAsync(string resourceType, string resourceId, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/resource-governance/" + HiokClient.Segment(resourceType) + "/" + HiokClient.Segment(resourceId) + "/locks", body, null, ct);

    /// <summary>Delete lock. <c>[DELETE /api/resource-governance/{resourceType}/{resourceId}/locks/{lockId}]</c></summary>
    public Task<JsonNode?> DeleteLockAsync(string resourceType, string resourceId, string lockId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/resource-governance/" + HiokClient.Segment(resourceType) + "/" + HiokClient.Segment(resourceId) + "/locks/" + HiokClient.Segment(lockId), null, null, ct);

    /// <summary>Estate. <c>[GET /api/resource-governance/estate]</c></summary>
    public Task<JsonNode?> EstateAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/resource-governance/estate", null, null, ct);

    /// <summary>Get activity log. <c>[GET /api/resource-governance/{resourceType}/{resourceId}/activity-log]</c></summary>
    public Task<JsonNode?> GetActivityLogAsync(string resourceType, string resourceId, object? limit = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/resource-governance/" + HiokClient.Segment(resourceType) + "/" + HiokClient.Segment(resourceId) + "/activity-log", null, new Dictionary<string, object?> { ["limit"] = limit }, ct);

    /// <summary>Get properties. <c>[GET /api/resource-governance/{resourceType}/{resourceId}/properties]</c></summary>
    public Task<JsonNode?> GetPropertiesAsync(string resourceType, string resourceId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/resource-governance/" + HiokClient.Segment(resourceType) + "/" + HiokClient.Segment(resourceId) + "/properties", null, null, ct);

    /// <summary>Get tenant activity. <c>[GET /api/resource-governance/activity]</c></summary>
    public Task<JsonNode?> GetTenantActivityAsync(object? mine = null, object? resourceType = null, object? status = null, object? hours = null, object? limit = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/resource-governance/activity", null, new Dictionary<string, object?> { ["mine"] = mine, ["resourceType"] = resourceType, ["status"] = status, ["hours"] = hours, ["limit"] = limit }, ct);

    /// <summary>List locks. <c>[GET /api/resource-governance/{resourceType}/{resourceId}/locks]</c></summary>
    public Task<JsonNode?> ListLocksAsync(string resourceType, string resourceId, object? includeInherited = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/resource-governance/" + HiokClient.Segment(resourceType) + "/" + HiokClient.Segment(resourceId) + "/locks", null, new Dictionary<string, object?> { ["includeInherited"] = includeInherited }, ct);

    /// <summary>Scopes. <c>[GET /api/resource-governance/scopes]</c></summary>
    public Task<JsonNode?> ScopesAsync(object? ids = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/resource-governance/scopes", null, new Dictionary<string, object?> { ["ids"] = ids }, ct);

    /// <summary>Update tags. <c>[PUT /api/resource-governance/{resourceType}/{resourceId}/tags]</c></summary>
    public Task<JsonNode?> UpdateTagsAsync(string resourceType, string resourceId, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("PUT"), "/api/resource-governance/" + HiokClient.Segment(resourceType) + "/" + HiokClient.Segment(resourceId) + "/tags", body, null, ct);
}

/// <summary>ResourceGroups operations.</summary>
public sealed partial class ResourceGroupsApi
{
    private readonly HiokClient _c;
    internal ResourceGroupsApi(HiokClient client) => _c = client;

    /// <summary>Create resource group. <c>[POST /api/resourcegroups]</c></summary>
    public Task<JsonNode?> CreateResourceGroupAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/resourcegroups", body, null, ct);

    /// <summary>Delete resource group. <c>[DELETE /api/resourcegroups/{id}]</c></summary>
    public Task<JsonNode?> DeleteResourceGroupAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/resourcegroups/" + HiokClient.Segment(id), null, null, ct);

    /// <summary>List resource groups. <c>[GET /api/resourcegroups]</c></summary>
    public Task<JsonNode?> ListResourceGroupsAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/resourcegroups", null, null, ct);
}

/// <summary>ResourceMetrics operations.</summary>
public sealed partial class ResourceMetricsApi
{
    private readonly HiokClient _c;
    internal ResourceMetricsApi(HiokClient client) => _c = client;

    /// <summary>Api. <c>[GET /api/resource-metrics/api]</c></summary>
    public Task<JsonNode?> ApiAsync(object? from = null, object? to = null, object? route = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/resource-metrics/api", null, new Dictionary<string, object?> { ["from"] = from, ["to"] = to, ["route"] = route }, ct);

    /// <summary>Catalogue. <c>[GET /api/resource-metrics/catalogue]</c></summary>
    public Task<JsonNode?> CatalogueAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/resource-metrics/catalogue", null, null, ct);

    /// <summary>Collect. <c>[POST /api/resource-metrics/collect]</c></summary>
    public Task<JsonNode?> CollectAsync(object? region = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/resource-metrics/collect", null, new Dictionary<string, object?> { ["region"] = region }, ct);

    /// <summary>Cost. <c>[GET /api/resource-metrics/cost/{resourceKind}/{resourceName}]</c></summary>
    public Task<JsonNode?> CostAsync(string resourceKind, string resourceName, object? from = null, object? to = null, object? region = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/resource-metrics/cost/" + HiokClient.Segment(resourceKind) + "/" + HiokClient.Segment(resourceName), null, new Dictionary<string, object?> { ["from"] = from, ["to"] = to, ["region"] = region }, ct);

    /// <summary>Cost totals. <c>[GET /api/resource-metrics/cost-totals]</c></summary>
    public Task<JsonNode?> CostTotalsAsync(object? region = null, object? from = null, object? to = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/resource-metrics/cost-totals", null, new Dictionary<string, object?> { ["region"] = region, ["from"] = from, ["to"] = to }, ct);

    /// <summary>Reporting. <c>[GET /api/resource-metrics/reporting]</c></summary>
    public Task<JsonNode?> ReportingAsync(object? region = null, object? resourceKind = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/resource-metrics/reporting", null, new Dictionary<string, object?> { ["region"] = region, ["resourceKind"] = resourceKind }, ct);

    /// <summary>Series. <c>[GET /api/resource-metrics/{resourceKind}/{resourceName}]</c></summary>
    public Task<JsonNode?> SeriesAsync(string resourceKind, string resourceName, object? from = null, object? to = null, object? granularity = null, object? metrics = null, object? region = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/resource-metrics/" + HiokClient.Segment(resourceKind) + "/" + HiokClient.Segment(resourceName), null, new Dictionary<string, object?> { ["from"] = from, ["to"] = to, ["granularity"] = granularity, ["metrics"] = metrics, ["region"] = region }, ct);
}

/// <summary>ResourceOperations operations.</summary>
public sealed partial class ResourceOperationsApi
{
    private readonly HiokClient _c;
    internal ResourceOperationsApi(HiokClient client) => _c = client;

    /// <summary>Alerts. <c>[GET /api/resource-ops/{resourceType}/{resourceId}/alerts]</c></summary>
    public Task<JsonNode?> AlertsAsync(string resourceType, string resourceId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/resource-ops/" + HiokClient.Segment(resourceType) + "/" + HiokClient.Segment(resourceId) + "/alerts", null, null, ct);

    /// <summary>Close support. <c>[POST /api/resource-ops/support/{id}/close]</c></summary>
    public Task<JsonNode?> CloseSupportAsync(string id, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/resource-ops/support/" + HiokClient.Segment(id) + "/close", body, null, ct);

    /// <summary>Delete alert. <c>[DELETE /api/resource-ops/{resourceType}/{resourceId}/alerts/{id}]</c></summary>
    public Task<JsonNode?> DeleteAlertAsync(string resourceType, string resourceId, string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/resource-ops/" + HiokClient.Segment(resourceType) + "/" + HiokClient.Segment(resourceId) + "/alerts/" + HiokClient.Segment(id), null, null, ct);

    /// <summary>Delete diagnostic. <c>[DELETE /api/resource-ops/{resourceType}/{resourceId}/diagnostics/{id}]</c></summary>
    public Task<JsonNode?> DeleteDiagnosticAsync(string resourceType, string resourceId, string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/resource-ops/" + HiokClient.Segment(resourceType) + "/" + HiokClient.Segment(resourceId) + "/diagnostics/" + HiokClient.Segment(id), null, null, ct);

    /// <summary>Delete task. <c>[DELETE /api/resource-ops/{resourceType}/{resourceId}/tasks/{id}]</c></summary>
    public Task<JsonNode?> DeleteTaskAsync(string resourceType, string resourceId, string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/resource-ops/" + HiokClient.Segment(resourceType) + "/" + HiokClient.Segment(resourceId) + "/tasks/" + HiokClient.Segment(id), null, null, ct);

    /// <summary>Diagnostics. <c>[GET /api/resource-ops/{resourceType}/{resourceId}/diagnostics]</c></summary>
    public Task<JsonNode?> DiagnosticsAsync(string resourceType, string resourceId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/resource-ops/" + HiokClient.Segment(resourceType) + "/" + HiokClient.Segment(resourceId) + "/diagnostics", null, null, ct);

    /// <summary>Health. <c>[GET /api/resource-ops/{resourceType}/{resourceId}/health]</c></summary>
    public Task<JsonNode?> HealthAsync(string resourceType, string resourceId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/resource-ops/" + HiokClient.Segment(resourceType) + "/" + HiokClient.Segment(resourceId) + "/health", null, null, ct);

    /// <summary>Logs. <c>[GET /api/resource-ops/{resourceType}/{resourceId}/logs]</c></summary>
    public Task<JsonNode?> LogsAsync(string resourceType, string resourceId, object? tail = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/resource-ops/" + HiokClient.Segment(resourceType) + "/" + HiokClient.Segment(resourceId) + "/logs", null, new Dictionary<string, object?> { ["tail"] = tail }, ct);

    /// <summary>Raise support. <c>[POST /api/resource-ops/{resourceType}/{resourceId}/support]</c></summary>
    public Task<JsonNode?> RaiseSupportAsync(string resourceType, string resourceId, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/resource-ops/" + HiokClient.Segment(resourceType) + "/" + HiokClient.Segment(resourceId) + "/support", body, null, ct);

    /// <summary>Save alert. <c>[POST /api/resource-ops/{resourceType}/{resourceId}/alerts]</c></summary>
    public Task<JsonNode?> SaveAlertAsync(string resourceType, string resourceId, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/resource-ops/" + HiokClient.Segment(resourceType) + "/" + HiokClient.Segment(resourceId) + "/alerts", body, null, ct);

    /// <summary>Save diagnostic. <c>[POST /api/resource-ops/{resourceType}/{resourceId}/diagnostics]</c></summary>
    public Task<JsonNode?> SaveDiagnosticAsync(string resourceType, string resourceId, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/resource-ops/" + HiokClient.Segment(resourceType) + "/" + HiokClient.Segment(resourceId) + "/diagnostics", body, null, ct);

    /// <summary>Save task. <c>[POST /api/resource-ops/{resourceType}/{resourceId}/tasks]</c></summary>
    public Task<JsonNode?> SaveTaskAsync(string resourceType, string resourceId, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/resource-ops/" + HiokClient.Segment(resourceType) + "/" + HiokClient.Segment(resourceId) + "/tasks", body, null, ct);

    /// <summary>State. <c>[GET /api/resource-ops/{resourceType}/{resourceId}/state]</c></summary>
    public Task<JsonNode?> StateAsync(string resourceType, string resourceId, object? name = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/resource-ops/" + HiokClient.Segment(resourceType) + "/" + HiokClient.Segment(resourceId) + "/state", null, new Dictionary<string, object?> { ["name"] = name }, ct);

    /// <summary>Support. <c>[GET /api/resource-ops/{resourceType}/{resourceId}/support]</c></summary>
    public Task<JsonNode?> SupportAsync(string resourceType, string resourceId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/resource-ops/" + HiokClient.Segment(resourceType) + "/" + HiokClient.Segment(resourceId) + "/support", null, null, ct);

    /// <summary>Tasks. <c>[GET /api/resource-ops/{resourceType}/{resourceId}/tasks]</c></summary>
    public Task<JsonNode?> TasksAsync(string resourceType, string resourceId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/resource-ops/" + HiokClient.Segment(resourceType) + "/" + HiokClient.Segment(resourceId) + "/tasks", null, null, ct);

    /// <summary>Template. <c>[GET /api/resource-ops/{resourceType}/{resourceId}/template]</c></summary>
    public Task<JsonNode?> TemplateAsync(string resourceType, string resourceId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/resource-ops/" + HiokClient.Segment(resourceType) + "/" + HiokClient.Segment(resourceId) + "/template", null, null, ct);

    /// <summary>Update alert. <c>[PUT /api/resource-ops/{resourceType}/{resourceId}/alerts/{id}]</c></summary>
    public Task<JsonNode?> UpdateAlertAsync(string resourceType, string resourceId, string id, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("PUT"), "/api/resource-ops/" + HiokClient.Segment(resourceType) + "/" + HiokClient.Segment(resourceId) + "/alerts/" + HiokClient.Segment(id), body, null, ct);

    /// <summary>Update task. <c>[PUT /api/resource-ops/{resourceType}/{resourceId}/tasks/{id}]</c></summary>
    public Task<JsonNode?> UpdateTaskAsync(string resourceType, string resourceId, string id, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("PUT"), "/api/resource-ops/" + HiokClient.Segment(resourceType) + "/" + HiokClient.Segment(resourceId) + "/tasks/" + HiokClient.Segment(id), body, null, ct);
}

/// <summary>Sandbox operations.</summary>
public sealed partial class SandboxApi
{
    private readonly HiokClient _c;
    internal SandboxApi(HiokClient client) => _c = client;

    /// <summary>Create. <c>[POST /api/Sandbox]</c></summary>
    public Task<JsonNode?> CreateAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Sandbox", body, null, ct);

    /// <summary>Create and download. <c>[POST /api/Sandbox/download]</c></summary>
    public Task<JsonNode?> CreateAndDownloadAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Sandbox/download", body, null, ct);

    /// <summary>Reap. <c>[POST /api/Sandbox/reap]</c></summary>
    public Task<JsonNode?> ReapAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Sandbox/reap", null, null, ct);

    /// <summary>Regions. <c>[GET /api/Sandbox/regions]</c></summary>
    public Task<JsonNode?> RegionsAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Sandbox/regions", null, null, ct);
}

/// <summary>Search operations.</summary>
public sealed partial class SearchApi
{
    private readonly HiokClient _c;
    internal SearchApi(HiokClient client) => _c = client;

    /// <summary>Search. <c>[GET /api/search]</c></summary>
    public Task<JsonNode?> SearchAsync(object? q = null, object? type = null, object? region = null, object? status = null, object? limit = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/search", null, new Dictionary<string, object?> { ["q"] = q, ["type"] = type, ["region"] = region, ["status"] = status, ["limit"] = limit }, ct);
}

/// <summary>ServiceBus operations.</summary>
public sealed partial class ServiceBusApi
{
    private readonly HiokClient _c;
    internal ServiceBusApi(HiokClient client) => _c = client;

    /// <summary>Create namespace. <c>[POST /api/ServiceBus/namespaces]</c></summary>
    public Task<JsonNode?> CreateNamespaceAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/ServiceBus/namespaces", body, null, ct);

    /// <summary>Create queue. <c>[POST /api/ServiceBus/namespaces/{id}/queues]</c></summary>
    public Task<JsonNode?> CreateQueueAsync(string id, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/ServiceBus/namespaces/" + HiokClient.Segment(id) + "/queues", body, null, ct);

    /// <summary>Create rule. <c>[POST /api/ServiceBus/namespaces/{id}/topics/{topicName}/subscriptions/{subscriptionName}/rules]</c></summary>
    public Task<JsonNode?> CreateRuleAsync(string id, string topicName, string subscriptionName, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/ServiceBus/namespaces/" + HiokClient.Segment(id) + "/topics/" + HiokClient.Segment(topicName) + "/subscriptions/" + HiokClient.Segment(subscriptionName) + "/rules", body, null, ct);

    /// <summary>Create subscription. <c>[POST /api/ServiceBus/namespaces/{id}/topics/{topicName}/subscriptions]</c></summary>
    public Task<JsonNode?> CreateSubscriptionAsync(string id, string topicName, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/ServiceBus/namespaces/" + HiokClient.Segment(id) + "/topics/" + HiokClient.Segment(topicName) + "/subscriptions", body, null, ct);

    /// <summary>Create topic. <c>[POST /api/ServiceBus/namespaces/{id}/topics]</c></summary>
    public Task<JsonNode?> CreateTopicAsync(string id, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/ServiceBus/namespaces/" + HiokClient.Segment(id) + "/topics", body, null, ct);

    /// <summary>Delete namespace. <c>[DELETE /api/ServiceBus/namespaces/{id}]</c></summary>
    public Task<JsonNode?> DeleteNamespaceAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/ServiceBus/namespaces/" + HiokClient.Segment(id), null, null, ct);

    /// <summary>Delete queue. <c>[DELETE /api/ServiceBus/namespaces/{id}/queues/{name}]</c></summary>
    public Task<JsonNode?> DeleteQueueAsync(string id, string name, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/ServiceBus/namespaces/" + HiokClient.Segment(id) + "/queues/" + HiokClient.Segment(name), null, null, ct);

    /// <summary>Delete rule. <c>[DELETE /api/ServiceBus/namespaces/{id}/topics/{topicName}/subscriptions/{subscriptionName}/rules/{ruleName}]</c></summary>
    public Task<JsonNode?> DeleteRuleAsync(string id, string topicName, string subscriptionName, string ruleName, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/ServiceBus/namespaces/" + HiokClient.Segment(id) + "/topics/" + HiokClient.Segment(topicName) + "/subscriptions/" + HiokClient.Segment(subscriptionName) + "/rules/" + HiokClient.Segment(ruleName), null, null, ct);

    /// <summary>Delete subscription. <c>[DELETE /api/ServiceBus/namespaces/{id}/topics/{topicName}/subscriptions/{subscriptionName}]</c></summary>
    public Task<JsonNode?> DeleteSubscriptionAsync(string id, string topicName, string subscriptionName, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/ServiceBus/namespaces/" + HiokClient.Segment(id) + "/topics/" + HiokClient.Segment(topicName) + "/subscriptions/" + HiokClient.Segment(subscriptionName), null, null, ct);

    /// <summary>Delete topic. <c>[DELETE /api/ServiceBus/namespaces/{id}/topics/{name}]</c></summary>
    public Task<JsonNode?> DeleteTopicAsync(string id, string name, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/ServiceBus/namespaces/" + HiokClient.Segment(id) + "/topics/" + HiokClient.Segment(name), null, null, ct);

    /// <summary>Get keys. <c>[GET /api/ServiceBus/namespaces/{id}/keys]</c></summary>
    public Task<JsonNode?> GetKeysAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/ServiceBus/namespaces/" + HiokClient.Segment(id) + "/keys", null, null, ct);

    /// <summary>Get namespace. <c>[GET /api/ServiceBus/namespaces/{id}]</c></summary>
    public Task<JsonNode?> GetNamespaceAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/ServiceBus/namespaces/" + HiokClient.Segment(id), null, null, ct);

    /// <summary>Get queue. <c>[GET /api/ServiceBus/namespaces/{id}/queues/{name}]</c></summary>
    public Task<JsonNode?> GetQueueAsync(string id, string name, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/ServiceBus/namespaces/" + HiokClient.Segment(id) + "/queues/" + HiokClient.Segment(name), null, null, ct);

    /// <summary>List namespaces. <c>[GET /api/ServiceBus/namespaces]</c></summary>
    public Task<JsonNode?> ListNamespacesAsync(object? product = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/ServiceBus/namespaces", null, new Dictionary<string, object?> { ["product"] = product }, ct);

    /// <summary>List queues. <c>[GET /api/ServiceBus/namespaces/{id}/queues]</c></summary>
    public Task<JsonNode?> ListQueuesAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/ServiceBus/namespaces/" + HiokClient.Segment(id) + "/queues", null, null, ct);

    /// <summary>List rules. <c>[GET /api/ServiceBus/namespaces/{id}/topics/{topicName}/subscriptions/{subscriptionName}/rules]</c></summary>
    public Task<JsonNode?> ListRulesAsync(string id, string topicName, string subscriptionName, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/ServiceBus/namespaces/" + HiokClient.Segment(id) + "/topics/" + HiokClient.Segment(topicName) + "/subscriptions/" + HiokClient.Segment(subscriptionName) + "/rules", null, null, ct);

    /// <summary>List subscriptions. <c>[GET /api/ServiceBus/namespaces/{id}/topics/{topicName}/subscriptions]</c></summary>
    public Task<JsonNode?> ListSubscriptionsAsync(string id, string topicName, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/ServiceBus/namespaces/" + HiokClient.Segment(id) + "/topics/" + HiokClient.Segment(topicName) + "/subscriptions", null, null, ct);

    /// <summary>List topics. <c>[GET /api/ServiceBus/namespaces/{id}/topics]</c></summary>
    public Task<JsonNode?> ListTopicsAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/ServiceBus/namespaces/" + HiokClient.Segment(id) + "/topics", null, null, ct);

    /// <summary>Peek. <c>[POST /api/ServiceBus/namespaces/{id}/entities/{entity}/messages/peek]</c></summary>
    public Task<JsonNode?> PeekAsync(string id, string entity, object? subscription = null, object? maxMessages = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/ServiceBus/namespaces/" + HiokClient.Segment(id) + "/entities/" + HiokClient.Segment(entity) + "/messages/peek", null, new Dictionary<string, object?> { ["subscription"] = subscription, ["maxMessages"] = maxMessages }, ct);

    /// <summary>Receive. <c>[POST /api/ServiceBus/namespaces/{id}/entities/{entity}/messages/receive]</c></summary>
    public Task<JsonNode?> ReceiveAsync(string id, string entity, object? body = null, object? subscription = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/ServiceBus/namespaces/" + HiokClient.Segment(id) + "/entities/" + HiokClient.Segment(entity) + "/messages/receive", body, new Dictionary<string, object?> { ["subscription"] = subscription }, ct);

    /// <summary>Receive dead letter. <c>[POST /api/ServiceBus/namespaces/{id}/entities/{entity}/deadletter/receive]</c></summary>
    public Task<JsonNode?> ReceiveDeadLetterAsync(string id, string entity, object? subscription = null, object? maxMessages = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/ServiceBus/namespaces/" + HiokClient.Segment(id) + "/entities/" + HiokClient.Segment(entity) + "/deadletter/receive", null, new Dictionary<string, object?> { ["subscription"] = subscription, ["maxMessages"] = maxMessages }, ct);

    /// <summary>Regenerate key. <c>[POST /api/ServiceBus/namespaces/{id}/keys/{keyName}/regenerate]</c></summary>
    public Task<JsonNode?> RegenerateKeyAsync(string id, string keyName, object? primary = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/ServiceBus/namespaces/" + HiokClient.Segment(id) + "/keys/" + HiokClient.Segment(keyName) + "/regenerate", null, new Dictionary<string, object?> { ["primary"] = primary }, ct);

    /// <summary>Runtime. <c>[GET /api/ServiceBus/namespaces/{id}/entities/{entity}/runtime]</c></summary>
    public Task<JsonNode?> RuntimeAsync(string id, string entity, object? subscription = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/ServiceBus/namespaces/" + HiokClient.Segment(id) + "/entities/" + HiokClient.Segment(entity) + "/runtime", null, new Dictionary<string, object?> { ["subscription"] = subscription }, ct);

    /// <summary>Send. <c>[POST /api/ServiceBus/namespaces/{id}/entities/{entity}/messages]</c></summary>
    public Task<JsonNode?> SendAsync(string id, string entity, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/ServiceBus/namespaces/" + HiokClient.Segment(id) + "/entities/" + HiokClient.Segment(entity) + "/messages", body, null, ct);

    /// <summary>Settle. <c>[POST /api/ServiceBus/namespaces/{id}/entities/{entity}/messages/settle]</c></summary>
    public Task<JsonNode?> SettleAsync(string id, string entity, object? body = null, object? subscription = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/ServiceBus/namespaces/" + HiokClient.Segment(id) + "/entities/" + HiokClient.Segment(entity) + "/messages/settle", body, new Dictionary<string, object?> { ["subscription"] = subscription }, ct);

    /// <summary>Update queue. <c>[PUT /api/ServiceBus/namespaces/{id}/queues/{name}]</c></summary>
    public Task<JsonNode?> UpdateQueueAsync(string id, string name, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("PUT"), "/api/ServiceBus/namespaces/" + HiokClient.Segment(id) + "/queues/" + HiokClient.Segment(name), body, null, ct);
}

/// <summary>Slack operations.</summary>
public sealed partial class SlackApi
{
    private readonly HiokClient _c;
    internal SlackApi(HiokClient client) => _c = client;

    /// <summary>Command. <c>[POST /api/integrations/slack/command]</c></summary>
    public Task<JsonNode?> CommandAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/integrations/slack/command", null, null, ct);

    /// <summary>Config info. <c>[GET /api/integrations/slack/config]</c></summary>
    public Task<JsonNode?> ConfigInfoAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/integrations/slack/config", null, null, ct);

    /// <summary>Install. <c>[GET /api/integrations/slack/install]</c></summary>
    public Task<JsonNode?> InstallAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/integrations/slack/install", null, null, ct);

    /// <summary>Link. <c>[POST /api/integrations/slack/link]</c></summary>
    public Task<JsonNode?> LinkAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/integrations/slack/link", body, null, ct);

    /// <summary>OAuth. <c>[GET /api/integrations/slack/oauth]</c></summary>
    public Task<JsonNode?> OAuthAsync(object? code = null, object? state = null, object? error = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/integrations/slack/oauth", null, new Dictionary<string, object?> { ["code"] = code, ["state"] = state, ["error"] = error }, ct);
}

/// <summary>SqlServerDatabase operations.</summary>
public sealed partial class SqlServerDatabaseApi
{
    private readonly HiokClient _c;
    internal SqlServerDatabaseApi(HiokClient client) => _c = client;

    /// <summary>Columns. <c>[GET /api/SqlServerDatabase/{id}/objects/{schema}/{table}/columns]</c></summary>
    public Task<JsonNode?> ColumnsAsync(string id, string schema, string table, object? database = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/SqlServerDatabase/" + HiokClient.Segment(id) + "/objects/" + HiokClient.Segment(schema) + "/" + HiokClient.Segment(table) + "/columns", null, new Dictionary<string, object?> { ["database"] = database }, ct);

    /// <summary>Connection. <c>[GET /api/SqlServerDatabase/{id}/connection]</c></summary>
    public Task<JsonNode?> ConnectionAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/SqlServerDatabase/" + HiokClient.Segment(id) + "/connection", null, null, ct);

    /// <summary>Create. <c>[POST /api/SqlServerDatabase]</c></summary>
    public Task<JsonNode?> CreateAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/SqlServerDatabase", body, null, ct);

    /// <summary>Databases. <c>[GET /api/SqlServerDatabase/{id}/databases]</c></summary>
    public Task<JsonNode?> DatabasesAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/SqlServerDatabase/" + HiokClient.Segment(id) + "/databases", null, null, ct);

    /// <summary>Delete. <c>[DELETE /api/SqlServerDatabase/{id}]</c></summary>
    public Task<JsonNode?> DeleteAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/SqlServerDatabase/" + HiokClient.Segment(id), null, null, ct);

    /// <summary>Get. <c>[GET /api/SqlServerDatabase/{id}]</c></summary>
    public Task<JsonNode?> GetAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/SqlServerDatabase/" + HiokClient.Segment(id), null, null, ct);

    /// <summary>List. <c>[GET /api/SqlServerDatabase]</c></summary>
    public Task<JsonNode?> ListAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/SqlServerDatabase", null, null, ct);

    /// <summary>Objects. <c>[GET /api/SqlServerDatabase/{id}/objects]</c></summary>
    public Task<JsonNode?> ObjectsAsync(string id, object? database = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/SqlServerDatabase/" + HiokClient.Segment(id) + "/objects", null, new Dictionary<string, object?> { ["database"] = database }, ct);

    /// <summary>Query. <c>[POST /api/SqlServerDatabase/{id}/query]</c></summary>
    public Task<JsonNode?> QueryAsync(string id, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/SqlServerDatabase/" + HiokClient.Segment(id) + "/query", body, null, ct);

    /// <summary>Reset password. <c>[POST /api/SqlServerDatabase/{id}/reset-password]</c></summary>
    public Task<JsonNode?> ResetPasswordAsync(string id, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/SqlServerDatabase/" + HiokClient.Segment(id) + "/reset-password", body, null, ct);
}

/// <summary>Storage operations.</summary>
public sealed partial class StorageApi
{
    private readonly HiokClient _c;
    internal StorageApi(HiokClient client) => _c = client;

    /// <summary>Bucket filesand directories. <c>[POST /api/Storage/bucketfilesanddirectories]</c></summary>
    public Task<JsonNode?> BucketFilesandDirectoriesAsync(object? directory = null, object? type = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Storage/bucketfilesanddirectories", null, new Dictionary<string, object?> { ["directory"] = directory, ["type"] = type }, ct);

    /// <summary>Create file. <c>[POST /api/Storage/createfile]</c></summary>
    public Task<JsonNode?> CreateFileAsync(object? path = null, object? filename = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Storage/createfile", null, new Dictionary<string, object?> { ["path"] = path, ["filename"] = filename }, ct);

    /// <summary>Create folder. <c>[POST /api/Storage/createfolder]</c></summary>
    public Task<JsonNode?> CreateFolderAsync(object? path = null, object? foldername = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Storage/createfolder", null, new Dictionary<string, object?> { ["path"] = path, ["foldername"] = foldername }, ct);

    /// <summary>Delete file. <c>[POST /api/Storage/deletefile]</c></summary>
    public Task<JsonNode?> DeleteFileAsync(object? path = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Storage/deletefile", null, new Dictionary<string, object?> { ["path"] = path }, ct);

    /// <summary>Delete folder. <c>[POST /api/Storage/deletefolder]</c></summary>
    public Task<JsonNode?> DeleteFolderAsync(object? path = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Storage/deletefolder", null, new Dictionary<string, object?> { ["path"] = path }, ct);

    /// <summary>File copy to. <c>[POST /api/Storage/filecopyto]</c></summary>
    public Task<JsonNode?> FileCopyToAsync(object? sourcePath = null, object? destinationPath = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Storage/filecopyto", null, new Dictionary<string, object?> { ["sourcePath"] = sourcePath, ["destinationPath"] = destinationPath }, ct);

    /// <summary>File move to. <c>[POST /api/Storage/filemoveto]</c></summary>
    public Task<JsonNode?> FileMoveToAsync(object? sourcePath = null, object? destinationPath = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Storage/filemoveto", null, new Dictionary<string, object?> { ["sourcePath"] = sourcePath, ["destinationPath"] = destinationPath }, ct);

    /// <summary>Folder copy to. <c>[POST /api/Storage/foldercopyto]</c></summary>
    public Task<JsonNode?> FolderCopyToAsync(object? sourcePath = null, object? destinationPath = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Storage/foldercopyto", null, new Dictionary<string, object?> { ["sourcePath"] = sourcePath, ["destinationPath"] = destinationPath }, ct);

    /// <summary>Folder move to. <c>[POST /api/Storage/foldermoveto]</c></summary>
    public Task<JsonNode?> FolderMoveToAsync(object? sourcePath = null, object? destinationPath = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Storage/foldermoveto", null, new Dictionary<string, object?> { ["sourcePath"] = sourcePath, ["destinationPath"] = destinationPath }, ct);

    /// <summary>Get all directories. <c>[POST /api/Storage/listdirectories]</c></summary>
    public Task<JsonNode?> GetAllDirectoriesAsync(object? directory = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Storage/listdirectories", null, new Dictionary<string, object?> { ["directory"] = directory }, ct);

    /// <summary>Get all directories and files. <c>[POST /api/Storage/directoriesandfiles]</c></summary>
    public Task<JsonNode?> GetAllDirectoriesAndFilesAsync(object? directory = null, object? type = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Storage/directoriesandfiles", null, new Dictionary<string, object?> { ["directory"] = directory, ["type"] = type }, ct);

    /// <summary>Get all files. <c>[POST /api/Storage/listfiles]</c></summary>
    public Task<JsonNode?> GetAllFilesAsync(object? directory = null, object? type = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Storage/listfiles", null, new Dictionary<string, object?> { ["directory"] = directory, ["type"] = type }, ct);

    /// <summary>Get all filesand directories. <c>[POST /api/Storage/listfilesanddirectories]</c></summary>
    public Task<JsonNode?> GetAllFilesandDirectoriesAsync(object? directory = null, object? type = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Storage/listfilesanddirectories", null, new Dictionary<string, object?> { ["directory"] = directory, ["type"] = type }, ct);

    /// <summary>Get root dir. <c>[GET /api/Storage/rootdir]</c></summary>
    public Task<JsonNode?> GetRootDirAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Storage/rootdir", null, null, ct);

    /// <summary>Rename file. <c>[POST /api/Storage/renamefile]</c></summary>
    public Task<JsonNode?> RenameFileAsync(object? path = null, object? rename = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Storage/renamefile", null, new Dictionary<string, object?> { ["path"] = path, ["rename"] = rename }, ct);

    /// <summary>Rename folder. <c>[POST /api/Storage/renamefolder]</c></summary>
    public Task<JsonNode?> RenameFolderAsync(object? directory = null, object? rename = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Storage/renamefolder", null, new Dictionary<string, object?> { ["directory"] = directory, ["rename"] = rename }, ct);
}

/// <summary>StorageAccount operations.</summary>
public sealed partial class StorageAccountApi
{
    private readonly HiokClient _c;
    internal StorageAccountApi(HiokClient client) => _c = client;

    /// <summary>Acquire lock. <c>[POST /api/StorageAccount/items/{itemId}/lock]</c></summary>
    public Task<JsonNode?> AcquireLockAsync(string itemId, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/StorageAccount/items/" + HiokClient.Segment(itemId) + "/lock", body, null, ct);

    /// <summary>Add lifecycle rule. <c>[POST /api/StorageAccount/{id}/lifecycle]</c></summary>
    public Task<JsonNode?> AddLifecycleRuleAsync(string id, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/StorageAccount/" + HiokClient.Segment(id) + "/lifecycle", body, null, ct);

    /// <summary>Add role assignment. <c>[POST /api/StorageAccount/{id}/iam]</c></summary>
    public Task<JsonNode?> AddRoleAssignmentAsync(string id, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/StorageAccount/" + HiokClient.Segment(id) + "/iam", body, null, ct);

    /// <summary>Break lock. <c>[POST /api/StorageAccount/items/{itemId}/lock/break]</c></summary>
    public Task<JsonNode?> BreakLockAsync(string itemId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/StorageAccount/items/" + HiokClient.Segment(itemId) + "/lock/break", null, null, ct);

    /// <summary>Cancel operation. <c>[POST /api/StorageAccount/operations/{operationId}/cancel]</c></summary>
    public Task<JsonNode?> CancelOperationAsync(string operationId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/StorageAccount/operations/" + HiokClient.Segment(operationId) + "/cancel", null, null, ct);

    /// <summary>Copy item. <c>[POST /api/StorageAccount/items/copy]</c></summary>
    public Task<JsonNode?> CopyItemAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/StorageAccount/items/copy", body, null, ct);

    /// <summary>Create backup. <c>[POST /api/StorageAccount/{id}/backups]</c></summary>
    public Task<JsonNode?> CreateBackupAsync(string id, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/StorageAccount/" + HiokClient.Segment(id) + "/backups", body, null, ct);

    /// <summary>Create folder. <c>[POST /api/StorageAccount/folders]</c></summary>
    public Task<JsonNode?> CreateFolderAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/StorageAccount/folders", body, null, ct);

    /// <summary>Create queue. <c>[POST /api/StorageAccount/{id}/queues]</c></summary>
    public Task<JsonNode?> CreateQueueAsync(string id, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/StorageAccount/" + HiokClient.Segment(id) + "/queues", body, null, ct);

    /// <summary>Create storage account. <c>[POST /api/StorageAccount]</c></summary>
    public Task<JsonNode?> CreateStorageAccountAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/StorageAccount", body, null, ct);

    /// <summary>Create table. <c>[POST /api/StorageAccount/{id}/tables]</c></summary>
    public Task<JsonNode?> CreateTableAsync(string id, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/StorageAccount/" + HiokClient.Segment(id) + "/tables", body, null, ct);

    /// <summary>Create zip. <c>[POST /api/StorageAccount/zip]</c></summary>
    public Task<JsonNode?> CreateZipAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/StorageAccount/zip", body, null, ct);

    /// <summary>Delete backup. <c>[DELETE /api/StorageAccount/{id}/backups/{backupId}]</c></summary>
    public Task<JsonNode?> DeleteBackupAsync(string id, string backupId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/StorageAccount/" + HiokClient.Segment(id) + "/backups/" + HiokClient.Segment(backupId), null, null, ct);

    /// <summary>Delete items. <c>[POST /api/StorageAccount/items/delete]</c></summary>
    public Task<JsonNode?> DeleteItemsAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/StorageAccount/items/delete", body, null, ct);

    /// <summary>Delete lifecycle rule. <c>[DELETE /api/StorageAccount/{id}/lifecycle/{ruleId}]</c></summary>
    public Task<JsonNode?> DeleteLifecycleRuleAsync(string id, string ruleId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/StorageAccount/" + HiokClient.Segment(id) + "/lifecycle/" + HiokClient.Segment(ruleId), null, null, ct);

    /// <summary>Delete queue. <c>[DELETE /api/StorageAccount/{id}/queues/{queueName}]</c></summary>
    public Task<JsonNode?> DeleteQueueAsync(string id, string queueName, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/StorageAccount/" + HiokClient.Segment(id) + "/queues/" + HiokClient.Segment(queueName), null, null, ct);

    /// <summary>Delete storage account. <c>[DELETE /api/StorageAccount/{id}]</c></summary>
    public Task<JsonNode?> DeleteStorageAccountAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/StorageAccount/" + HiokClient.Segment(id), null, null, ct);

    /// <summary>Delete table. <c>[DELETE /api/StorageAccount/{id}/tables/{tableName}]</c></summary>
    public Task<JsonNode?> DeleteTableAsync(string id, string tableName, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/StorageAccount/" + HiokClient.Segment(id) + "/tables/" + HiokClient.Segment(tableName), null, null, ct);

    /// <summary>Download item content. <c>[GET /api/StorageAccount/items/{itemId}/content]</c></summary>
    public Task<JsonNode?> DownloadItemContentAsync(string itemId, object? region = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/StorageAccount/items/" + HiokClient.Segment(itemId) + "/content", null, new Dictionary<string, object?> { ["region"] = region }, ct);

    /// <summary>Download zip. <c>[POST /api/StorageAccount/zip/download]</c></summary>
    public Task<JsonNode?> DownloadZipAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/StorageAccount/zip/download", body, null, ct);

    /// <summary>Export activity log. <c>[GET /api/StorageAccount/{id}/activity/export]</c></summary>
    public Task<JsonNode?> ExportActivityLogAsync(string id, object? format = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/StorageAccount/" + HiokClient.Segment(id) + "/activity/export", null, new Dictionary<string, object?> { ["format"] = format }, ct);

    /// <summary>Extract archive. <c>[POST /api/StorageAccount/{id}/items/{itemId}/extract]</c></summary>
    public Task<JsonNode?> ExtractArchiveAsync(string id, string itemId, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/StorageAccount/" + HiokClient.Segment(id) + "/items/" + HiokClient.Segment(itemId) + "/extract", body, null, ct);

    /// <summary>Finalize upload. <c>[POST /api/StorageAccount/upload/{operationId}/finalize]</c></summary>
    public Task<JsonNode?> FinalizeUploadAsync(string operationId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/StorageAccount/upload/" + HiokClient.Segment(operationId) + "/finalize", null, null, ct);

    /// <summary>Generate share link. <c>[POST /api/StorageAccount/items/{itemId}/sharelink]</c></summary>
    public Task<JsonNode?> GenerateShareLinkAsync(string itemId, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/StorageAccount/items/" + HiokClient.Segment(itemId) + "/sharelink", body, null, ct);

    /// <summary>Get access keys. <c>[GET /api/StorageAccount/{id}/keys]</c></summary>
    public Task<JsonNode?> GetAccessKeysAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/StorageAccount/" + HiokClient.Segment(id) + "/keys", null, null, ct);

    /// <summary>Get active operations. <c>[GET /api/StorageAccount/{id}/operations]</c></summary>
    public Task<JsonNode?> GetActiveOperationsAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/StorageAccount/" + HiokClient.Segment(id) + "/operations", null, null, ct);

    /// <summary>Get activity log. <c>[GET /api/StorageAccount/{id}/activity]</c></summary>
    public Task<JsonNode?> GetActivityLogAsync(string id, object? limit = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/StorageAccount/" + HiokClient.Segment(id) + "/activity", null, new Dictionary<string, object?> { ["limit"] = limit }, ct);

    /// <summary>Get available regions. <c>[GET /api/StorageAccount/regions]</c></summary>
    public Task<JsonNode?> GetAvailableRegionsAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/StorageAccount/regions", null, null, ct);

    /// <summary>Get backups. <c>[GET /api/StorageAccount/{id}/backups]</c></summary>
    public Task<JsonNode?> GetBackupsAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/StorageAccount/" + HiokClient.Segment(id) + "/backups", null, null, ct);

    /// <summary>Get default storage account. <c>[GET /api/StorageAccount/default]</c></summary>
    public Task<JsonNode?> GetDefaultStorageAccountAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/StorageAccount/default", null, null, ct);

    /// <summary>Get file preview. <c>[GET /api/StorageAccount/items/{itemId}/preview]</c></summary>
    public Task<JsonNode?> GetFilePreviewAsync(string itemId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/StorageAccount/items/" + HiokClient.Segment(itemId) + "/preview", null, null, ct);

    /// <summary>Get item. <c>[GET /api/StorageAccount/items/{itemId}]</c></summary>
    public Task<JsonNode?> GetItemAsync(string itemId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/StorageAccount/items/" + HiokClient.Segment(itemId), null, null, ct);

    /// <summary>Get item activity log. <c>[GET /api/StorageAccount/items/{itemId}/activity]</c></summary>
    public Task<JsonNode?> GetItemActivityLogAsync(string itemId, object? limit = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/StorageAccount/items/" + HiokClient.Segment(itemId) + "/activity", null, new Dictionary<string, object?> { ["limit"] = limit }, ct);

    /// <summary>Get item metadata. <c>[GET /api/StorageAccount/items/{itemId}/metadata]</c></summary>
    public Task<JsonNode?> GetItemMetadataAsync(string itemId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/StorageAccount/items/" + HiokClient.Segment(itemId) + "/metadata", null, null, ct);

    /// <summary>Get item shares. <c>[GET /api/StorageAccount/items/{itemId}/shares]</c></summary>
    public Task<JsonNode?> GetItemSharesAsync(string itemId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/StorageAccount/items/" + HiokClient.Segment(itemId) + "/shares", null, null, ct);

    /// <summary>Get lifecycle rules. <c>[GET /api/StorageAccount/{id}/lifecycle]</c></summary>
    public Task<JsonNode?> GetLifecycleRulesAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/StorageAccount/" + HiokClient.Segment(id) + "/lifecycle", null, null, ct);

    /// <summary>Get networking. <c>[GET /api/StorageAccount/{id}/networking]</c></summary>
    public Task<JsonNode?> GetNetworkingAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/StorageAccount/" + HiokClient.Segment(id) + "/networking", null, null, ct);

    /// <summary>Get operation status. <c>[GET /api/StorageAccount/operations/{operationId}]</c></summary>
    public Task<JsonNode?> GetOperationStatusAsync(string operationId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/StorageAccount/operations/" + HiokClient.Segment(operationId), null, null, ct);

    /// <summary>Get replication status. <c>[GET /api/StorageAccount/{id}/replication]</c></summary>
    public Task<JsonNode?> GetReplicationStatusAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/StorageAccount/" + HiokClient.Segment(id) + "/replication", null, null, ct);

    /// <summary>Get role assignments. <c>[GET /api/StorageAccount/{id}/iam]</c></summary>
    public Task<JsonNode?> GetRoleAssignmentsAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/StorageAccount/" + HiokClient.Segment(id) + "/iam", null, null, ct);

    /// <summary>Get role definitions. <c>[GET /api/StorageAccount/role-definitions]</c></summary>
    public Task<JsonNode?> GetRoleDefinitionsAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/StorageAccount/role-definitions", null, null, ct);

    /// <summary>Get storage account. <c>[GET /api/StorageAccount/{id}]</c></summary>
    public Task<JsonNode?> GetStorageAccountAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/StorageAccount/" + HiokClient.Segment(id), null, null, ct);

    /// <summary>Get storage accounts. <c>[GET /api/StorageAccount]</c></summary>
    public Task<JsonNode?> GetStorageAccountsAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/StorageAccount", null, null, ct);

    /// <summary>Get storage stats. <c>[GET /api/StorageAccount/stats]</c></summary>
    public Task<JsonNode?> GetStorageStatsAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/StorageAccount/stats", null, null, ct);

    /// <summary>Get version history. <c>[GET /api/StorageAccount/items/{itemId}/versions]</c></summary>
    public Task<JsonNode?> GetVersionHistoryAsync(string itemId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/StorageAccount/items/" + HiokClient.Segment(itemId) + "/versions", null, null, ct);

    /// <summary>Initiate download. <c>[POST /api/StorageAccount/download]</c></summary>
    public Task<JsonNode?> InitiateDownloadAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/StorageAccount/download", body, null, ct);

    /// <summary>Initiate upload. <c>[POST /api/StorageAccount/upload]</c></summary>
    public Task<JsonNode?> InitiateUploadAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/StorageAccount/upload", body, null, ct);

    /// <summary>List items. <c>[GET /api/StorageAccount/{id}/items]</c></summary>
    public Task<JsonNode?> ListItemsAsync(string id, object? path = null, object? parentId = null, object? storageNamespace = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/StorageAccount/" + HiokClient.Segment(id) + "/items", null, new Dictionary<string, object?> { ["path"] = path, ["parentId"] = parentId, ["storageNamespace"] = storageNamespace }, ct);

    /// <summary>List queues. <c>[GET /api/StorageAccount/{id}/queues]</c></summary>
    public Task<JsonNode?> ListQueuesAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/StorageAccount/" + HiokClient.Segment(id) + "/queues", null, null, ct);

    /// <summary>List tables. <c>[GET /api/StorageAccount/{id}/tables]</c></summary>
    public Task<JsonNode?> ListTablesAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/StorageAccount/" + HiokClient.Segment(id) + "/tables", null, null, ct);

    /// <summary>Move item. <c>[PUT /api/StorageAccount/items/move]</c></summary>
    public Task<JsonNode?> MoveItemAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("PUT"), "/api/StorageAccount/items/move", body, null, ct);

    /// <summary>Regenerate access key. <c>[POST /api/StorageAccount/{id}/keys/{keyNumber}/regenerate]</c></summary>
    public Task<JsonNode?> RegenerateAccessKeyAsync(string id, string keyNumber, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/StorageAccount/" + HiokClient.Segment(id) + "/keys/" + HiokClient.Segment(keyNumber) + "/regenerate", body, null, ct);

    /// <summary>Release lock. <c>[DELETE /api/StorageAccount/items/{itemId}/lock]</c></summary>
    public Task<JsonNode?> ReleaseLockAsync(string itemId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/StorageAccount/items/" + HiokClient.Segment(itemId) + "/lock", null, null, ct);

    /// <summary>Remove role assignment. <c>[DELETE /api/StorageAccount/{id}/iam/{assignmentId}]</c></summary>
    public Task<JsonNode?> RemoveRoleAssignmentAsync(string id, string assignmentId, object? principalEmail = null, object? role = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/StorageAccount/" + HiokClient.Segment(id) + "/iam/" + HiokClient.Segment(assignmentId), null, new Dictionary<string, object?> { ["principalEmail"] = principalEmail, ["role"] = role }, ct);

    /// <summary>Remove share. <c>[DELETE /api/StorageAccount/shares/{shareId}]</c></summary>
    public Task<JsonNode?> RemoveShareAsync(string shareId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/StorageAccount/shares/" + HiokClient.Segment(shareId), null, null, ct);

    /// <summary>Rename item. <c>[PUT /api/StorageAccount/items/rename]</c></summary>
    public Task<JsonNode?> RenameItemAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("PUT"), "/api/StorageAccount/items/rename", body, null, ct);

    /// <summary>Restore backup. <c>[POST /api/StorageAccount/{id}/backups/{backupId}/restore]</c></summary>
    public Task<JsonNode?> RestoreBackupAsync(string id, string backupId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/StorageAccount/" + HiokClient.Segment(id) + "/backups/" + HiokClient.Segment(backupId) + "/restore", null, null, ct);

    /// <summary>Restore version. <c>[POST /api/StorageAccount/items/versions/restore]</c></summary>
    public Task<JsonNode?> RestoreVersionAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/StorageAccount/items/versions/restore", body, null, ct);

    /// <summary>Run lifecycle rules. <c>[POST /api/StorageAccount/{id}/lifecycle/run]</c></summary>
    public Task<JsonNode?> RunLifecycleRulesAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/StorageAccount/" + HiokClient.Segment(id) + "/lifecycle/run", null, null, ct);

    /// <summary>Save item content. <c>[PUT /api/StorageAccount/items/{itemId}/content]</c></summary>
    public Task<JsonNode?> SaveItemContentAsync(string itemId, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("PUT"), "/api/StorageAccount/items/" + HiokClient.Segment(itemId) + "/content", body, null, ct);

    /// <summary>Search items. <c>[GET /api/StorageAccount/{id}/items/search]</c></summary>
    public Task<JsonNode?> SearchItemsAsync(string id, object? q = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/StorageAccount/" + HiokClient.Segment(id) + "/items/search", null, new Dictionary<string, object?> { ["q"] = q }, ct);

    /// <summary>Set default storage account. <c>[PUT /api/StorageAccount/{id}/default]</c></summary>
    public Task<JsonNode?> SetDefaultStorageAccountAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("PUT"), "/api/StorageAccount/" + HiokClient.Segment(id) + "/default", null, null, ct);

    /// <summary>Share item. <c>[POST /api/StorageAccount/items/share]</c></summary>
    public Task<JsonNode?> ShareItemAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/StorageAccount/items/share", body, null, ct);

    /// <summary>Update networking. <c>[PUT /api/StorageAccount/{id}/networking]</c></summary>
    public Task<JsonNode?> UpdateNetworkingAsync(string id, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("PUT"), "/api/StorageAccount/" + HiokClient.Segment(id) + "/networking", body, null, ct);

    /// <summary>Update storage account. <c>[PUT /api/StorageAccount/{id}]</c></summary>
    public Task<JsonNode?> UpdateStorageAccountAsync(string id, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("PUT"), "/api/StorageAccount/" + HiokClient.Segment(id), body, null, ct);

    /// <summary>Upload chunk. <c>[POST /api/StorageAccount/upload/{operationId}/chunk]</c></summary>
    public Task<JsonNode?> UploadChunkAsync(string operationId, IDictionary<string, string>? form = null, IDictionary<string, (string FileName, byte[] Content)>? files = null, CancellationToken ct = default)
        => _c.InvokeMultipartAsync(HttpMethod.Post, "/api/StorageAccount/upload/" + HiokClient.Segment(operationId) + "/chunk", form, files, null, ct);
}

/// <summary>StorageData operations.</summary>
public sealed partial class StorageDataApi
{
    private readonly HiokClient _c;
    internal StorageDataApi(HiokClient client) => _c = client;

    /// <summary>Clear queue. <c>[DELETE /api/storageaccount/{accountId}/queues/{queueName}/messages]</c></summary>
    public Task<JsonNode?> ClearQueueAsync(string accountId, string queueName, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/storageaccount/" + HiokClient.Segment(accountId) + "/queues/" + HiokClient.Segment(queueName) + "/messages", null, null, ct);

    /// <summary>Delete entity. <c>[DELETE /api/storageaccount/{accountId}/tables/{tableName}/entities/{partitionKey}/{rowKey}]</c></summary>
    public Task<JsonNode?> DeleteEntityAsync(string accountId, string tableName, string partitionKey, string rowKey, object? ifMatch = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/storageaccount/" + HiokClient.Segment(accountId) + "/tables/" + HiokClient.Segment(tableName) + "/entities/" + HiokClient.Segment(partitionKey) + "/" + HiokClient.Segment(rowKey), null, new Dictionary<string, object?> { ["ifMatch"] = ifMatch }, ct);

    /// <summary>Delete message. <c>[DELETE /api/storageaccount/{accountId}/queues/{queueName}/messages/{messageId}]</c></summary>
    public Task<JsonNode?> DeleteMessageAsync(string accountId, string queueName, string messageId, object? popReceipt = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/storageaccount/" + HiokClient.Segment(accountId) + "/queues/" + HiokClient.Segment(queueName) + "/messages/" + HiokClient.Segment(messageId), null, new Dictionary<string, object?> { ["popReceipt"] = popReceipt }, ct);

    /// <summary>Get entity. <c>[GET /api/storageaccount/{accountId}/tables/{tableName}/entities/{partitionKey}/{rowKey}]</c></summary>
    public Task<JsonNode?> GetEntityAsync(string accountId, string tableName, string partitionKey, string rowKey, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/storageaccount/" + HiokClient.Segment(accountId) + "/tables/" + HiokClient.Segment(tableName) + "/entities/" + HiokClient.Segment(partitionKey) + "/" + HiokClient.Segment(rowKey), null, null, ct);

    /// <summary>Insert entity. <c>[POST /api/storageaccount/{accountId}/tables/{tableName}/entities]</c></summary>
    public Task<JsonNode?> InsertEntityAsync(string accountId, string tableName, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/storageaccount/" + HiokClient.Segment(accountId) + "/tables/" + HiokClient.Segment(tableName) + "/entities", body, null, ct);

    /// <summary>Peek messages. <c>[GET /api/storageaccount/{accountId}/queues/{queueName}/messages]</c></summary>
    public Task<JsonNode?> PeekMessagesAsync(string accountId, string queueName, object? max = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/storageaccount/" + HiokClient.Segment(accountId) + "/queues/" + HiokClient.Segment(queueName) + "/messages", null, new Dictionary<string, object?> { ["max"] = max }, ct);

    /// <summary>Query entities. <c>[GET /api/storageaccount/{accountId}/tables/{tableName}/entities]</c></summary>
    public Task<JsonNode?> QueryEntitiesAsync(string accountId, string tableName, object? partitionKey = null, object? propertyName = null, object? propertyValue = null, object? take = null, object? continuationRowKey = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/storageaccount/" + HiokClient.Segment(accountId) + "/tables/" + HiokClient.Segment(tableName) + "/entities", null, new Dictionary<string, object?> { ["partitionKey"] = partitionKey, ["propertyName"] = propertyName, ["propertyValue"] = propertyValue, ["take"] = take, ["continuationRowKey"] = continuationRowKey }, ct);

    /// <summary>Queue stats. <c>[GET /api/storageaccount/{accountId}/queues/{queueName}/stats]</c></summary>
    public Task<JsonNode?> QueueStatsAsync(string accountId, string queueName, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/storageaccount/" + HiokClient.Segment(accountId) + "/queues/" + HiokClient.Segment(queueName) + "/stats", null, null, ct);

    /// <summary>Receive messages. <c>[POST /api/storageaccount/{accountId}/queues/{queueName}/messages/receive]</c></summary>
    public Task<JsonNode?> ReceiveMessagesAsync(string accountId, string queueName, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/storageaccount/" + HiokClient.Segment(accountId) + "/queues/" + HiokClient.Segment(queueName) + "/messages/receive", body, null, ct);

    /// <summary>Send message. <c>[POST /api/storageaccount/{accountId}/queues/{queueName}/messages]</c></summary>
    public Task<JsonNode?> SendMessageAsync(string accountId, string queueName, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/storageaccount/" + HiokClient.Segment(accountId) + "/queues/" + HiokClient.Segment(queueName) + "/messages", body, null, ct);

    /// <summary>Update visibility. <c>[POST /api/storageaccount/{accountId}/queues/{queueName}/messages/{messageId}/visibility]</c></summary>
    public Task<JsonNode?> UpdateVisibilityAsync(string accountId, string queueName, string messageId, object? popReceipt = null, object? visibilityTimeoutSeconds = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/storageaccount/" + HiokClient.Segment(accountId) + "/queues/" + HiokClient.Segment(queueName) + "/messages/" + HiokClient.Segment(messageId) + "/visibility", null, new Dictionary<string, object?> { ["popReceipt"] = popReceipt, ["visibilityTimeoutSeconds"] = visibilityTimeoutSeconds }, ct);

    /// <summary>Upsert entity. <c>[PUT /api/storageaccount/{accountId}/tables/{tableName}/entities]</c></summary>
    public Task<JsonNode?> UpsertEntityAsync(string accountId, string tableName, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("PUT"), "/api/storageaccount/" + HiokClient.Segment(accountId) + "/tables/" + HiokClient.Segment(tableName) + "/entities", body, null, ct);
}

/// <summary>StorageObject operations.</summary>
public sealed partial class StorageObjectApi
{
    private readonly HiokClient _c;
    internal StorageObjectApi(HiokClient client) => _c = client;

    /// <summary>Commit block list. <c>[POST /api/storageaccount/{accountId}/containers/{container}/blocks/commit]</c></summary>
    public Task<JsonNode?> CommitBlockListAsync(string accountId, string container, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/storageaccount/" + HiokClient.Segment(accountId) + "/containers/" + HiokClient.Segment(container) + "/blocks/commit", body, null, ct);

    /// <summary>Create container. <c>[POST /api/storageaccount/{accountId}/containers]</c></summary>
    public Task<JsonNode?> CreateContainerAsync(string accountId, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/storageaccount/" + HiokClient.Segment(accountId) + "/containers", body, null, ct);

    /// <summary>Create directory. <c>[POST /api/storageaccount/{accountId}/containers/{container}/directories]</c></summary>
    public Task<JsonNode?> CreateDirectoryAsync(string accountId, string container, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/storageaccount/" + HiokClient.Segment(accountId) + "/containers/" + HiokClient.Segment(container) + "/directories", body, null, ct);

    /// <summary>Create file share. <c>[POST /api/storageaccount/{accountId}/fileshares]</c></summary>
    public Task<JsonNode?> CreateFileShareAsync(string accountId, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/storageaccount/" + HiokClient.Segment(accountId) + "/fileshares", body, null, ct);

    /// <summary>Delete container. <c>[DELETE /api/storageaccount/{accountId}/containers/{name}]</c></summary>
    public Task<JsonNode?> DeleteContainerAsync(string accountId, string name, object? force = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/storageaccount/" + HiokClient.Segment(accountId) + "/containers/" + HiokClient.Segment(name), null, new Dictionary<string, object?> { ["force"] = force }, ct);

    /// <summary>Delete file share. <c>[DELETE /api/storageaccount/{accountId}/fileshares/{name}]</c></summary>
    public Task<JsonNode?> DeleteFileShareAsync(string accountId, string name, object? force = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/storageaccount/" + HiokClient.Segment(accountId) + "/fileshares/" + HiokClient.Segment(name), null, new Dictionary<string, object?> { ["force"] = force }, ct);

    /// <summary>Delete object. <c>[DELETE /api/storageaccount/{accountId}/containers/{container}/objects/{key}]</c></summary>
    public Task<JsonNode?> DeleteObjectAsync(string accountId, string container, string key, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/storageaccount/" + HiokClient.Segment(accountId) + "/containers/" + HiokClient.Segment(container) + "/objects/" + HiokClient.Segment(key, true), null, null, ct);

    /// <summary>Get block list. <c>[GET /api/storageaccount/{accountId}/containers/{container}/blocks]</c></summary>
    public Task<JsonNode?> GetBlockListAsync(string accountId, string container, object? blobName = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/storageaccount/" + HiokClient.Segment(accountId) + "/containers/" + HiokClient.Segment(container) + "/blocks", null, new Dictionary<string, object?> { ["blobName"] = blobName }, ct);

    /// <summary>Get container. <c>[GET /api/storageaccount/{accountId}/containers/{name}]</c></summary>
    public Task<JsonNode?> GetContainerAsync(string accountId, string name, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/storageaccount/" + HiokClient.Segment(accountId) + "/containers/" + HiokClient.Segment(name), null, null, ct);

    /// <summary>Get object. <c>[GET /api/storageaccount/{accountId}/containers/{container}/objects/{key}]</c></summary>
    public Task<JsonNode?> GetObjectAsync(string accountId, string container, string key, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/storageaccount/" + HiokClient.Segment(accountId) + "/containers/" + HiokClient.Segment(container) + "/objects/" + HiokClient.Segment(key, true), null, null, ct);

    /// <summary>Get object content. <c>[GET /api/storageaccount/{accountId}/containers/{container}/content/{key}]</c></summary>
    public Task<JsonNode?> GetObjectContentAsync(string accountId, string container, string key, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/storageaccount/" + HiokClient.Segment(accountId) + "/containers/" + HiokClient.Segment(container) + "/content/" + HiokClient.Segment(key, true), null, null, ct);

    /// <summary>Get replication status. <c>[GET /api/storageaccount/{accountId}/replication-status]</c></summary>
    public Task<JsonNode?> GetReplicationStatusAsync(string accountId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/storageaccount/" + HiokClient.Segment(accountId) + "/replication-status", null, null, ct);

    /// <summary>List containers. <c>[GET /api/storageaccount/{accountId}/containers]</c></summary>
    public Task<JsonNode?> ListContainersAsync(string accountId, object? kind = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/storageaccount/" + HiokClient.Segment(accountId) + "/containers", null, new Dictionary<string, object?> { ["kind"] = kind }, ct);

    /// <summary>List file shares. <c>[GET /api/storageaccount/{accountId}/fileshares]</c></summary>
    public Task<JsonNode?> ListFileSharesAsync(string accountId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/storageaccount/" + HiokClient.Segment(accountId) + "/fileshares", null, null, ct);

    /// <summary>List objects. <c>[GET /api/storageaccount/{accountId}/containers/{container}/objects]</c></summary>
    public Task<JsonNode?> ListObjectsAsync(string accountId, string container, object? prefix = null, object? path = null, object? limit = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/storageaccount/" + HiokClient.Segment(accountId) + "/containers/" + HiokClient.Segment(container) + "/objects", null, new Dictionary<string, object?> { ["prefix"] = prefix, ["path"] = path, ["limit"] = limit }, ct);

    /// <summary>Put object. <c>[PUT /api/storageaccount/{accountId}/containers/{container}/objects]</c></summary>
    public Task<JsonNode?> PutObjectAsync(string accountId, string container, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("PUT"), "/api/storageaccount/" + HiokClient.Segment(accountId) + "/containers/" + HiokClient.Segment(container) + "/objects", body, null, ct);

    /// <summary>Reconcile. <c>[POST /api/storageaccount/{accountId}/replication-status/reconcile]</c></summary>
    public Task<JsonNode?> ReconcileAsync(string accountId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/storageaccount/" + HiokClient.Segment(accountId) + "/replication-status/reconcile", null, null, ct);

    /// <summary>Rename path. <c>[POST /api/storageaccount/{accountId}/containers/{container}/rename]</c></summary>
    public Task<JsonNode?> RenamePathAsync(string accountId, string container, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/storageaccount/" + HiokClient.Segment(accountId) + "/containers/" + HiokClient.Segment(container) + "/rename", body, null, ct);

    /// <summary>Set access control. <c>[PUT /api/storageaccount/{accountId}/containers/{container}/access-control]</c></summary>
    public Task<JsonNode?> SetAccessControlAsync(string accountId, string container, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("PUT"), "/api/storageaccount/" + HiokClient.Segment(accountId) + "/containers/" + HiokClient.Segment(container) + "/access-control", body, null, ct);

    /// <summary>Stage block. <c>[PUT /api/storageaccount/{accountId}/containers/{container}/blocks]</c></summary>
    public Task<JsonNode?> StageBlockAsync(string accountId, string container, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("PUT"), "/api/storageaccount/" + HiokClient.Segment(accountId) + "/containers/" + HiokClient.Segment(container) + "/blocks", body, null, ct);

    /// <summary>Update container. <c>[PUT /api/storageaccount/{accountId}/containers/{name}]</c></summary>
    public Task<JsonNode?> UpdateContainerAsync(string accountId, string name, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("PUT"), "/api/storageaccount/" + HiokClient.Segment(accountId) + "/containers/" + HiokClient.Segment(name), body, null, ct);
}

/// <summary>StreamAnalytics operations.</summary>
public sealed partial class StreamAnalyticsApi
{
    private readonly HiokClient _c;
    internal StreamAnalyticsApi(HiokClient client) => _c = client;

    /// <summary>Add input. <c>[POST /api/StreamAnalytics/{id}/inputs]</c></summary>
    public Task<JsonNode?> AddInputAsync(string id, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/StreamAnalytics/" + HiokClient.Segment(id) + "/inputs", body, null, ct);

    /// <summary>Add output. <c>[POST /api/StreamAnalytics/{id}/outputs]</c></summary>
    public Task<JsonNode?> AddOutputAsync(string id, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/StreamAnalytics/" + HiokClient.Segment(id) + "/outputs", body, null, ct);

    /// <summary>Apply transform. <c>[POST /api/StreamAnalytics/{id}/transform/apply]</c></summary>
    public Task<JsonNode?> ApplyTransformAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/StreamAnalytics/" + HiokClient.Segment(id) + "/transform/apply", null, null, ct);

    /// <summary>Bindings. <c>[GET /api/StreamAnalytics/bindings]</c></summary>
    public Task<JsonNode?> BindingsAsync(object? connector = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/StreamAnalytics/bindings", null, new Dictionary<string, object?> { ["connector"] = connector }, ct);

    /// <summary>Catalog. <c>[GET /api/StreamAnalytics/catalog]</c></summary>
    public Task<JsonNode?> CatalogAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/StreamAnalytics/catalog", null, null, ct);

    /// <summary>Connection. <c>[GET /api/StreamAnalytics/{id}/connection]</c></summary>
    public Task<JsonNode?> ConnectionAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/StreamAnalytics/" + HiokClient.Segment(id) + "/connection", null, null, ct);

    /// <summary>Create. <c>[POST /api/StreamAnalytics]</c></summary>
    public Task<JsonNode?> CreateAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/StreamAnalytics", body, null, ct);

    /// <summary>Delete. <c>[DELETE /api/StreamAnalytics/{id}]</c></summary>
    public Task<JsonNode?> DeleteAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/StreamAnalytics/" + HiokClient.Segment(id), null, null, ct);

    /// <summary>Delete input. <c>[DELETE /api/StreamAnalytics/{id}/inputs/{inputId}]</c></summary>
    public Task<JsonNode?> DeleteInputAsync(string id, string inputId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/StreamAnalytics/" + HiokClient.Segment(id) + "/inputs/" + HiokClient.Segment(inputId), null, null, ct);

    /// <summary>Delete output. <c>[DELETE /api/StreamAnalytics/{id}/outputs/{outputId}]</c></summary>
    public Task<JsonNode?> DeleteOutputAsync(string id, string outputId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/StreamAnalytics/" + HiokClient.Segment(id) + "/outputs/" + HiokClient.Segment(outputId), null, null, ct);

    /// <summary>Get. <c>[GET /api/StreamAnalytics/{id}]</c></summary>
    public Task<JsonNode?> GetAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/StreamAnalytics/" + HiokClient.Segment(id), null, null, ct);

    /// <summary>Inputs. <c>[GET /api/StreamAnalytics/{id}/inputs]</c></summary>
    public Task<JsonNode?> InputsAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/StreamAnalytics/" + HiokClient.Segment(id) + "/inputs", null, null, ct);

    /// <summary>List. <c>[GET /api/StreamAnalytics]</c></summary>
    public Task<JsonNode?> ListAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/StreamAnalytics", null, null, ct);

    /// <summary>Logs. <c>[GET /api/StreamAnalytics/{id}/logs]</c></summary>
    public Task<JsonNode?> LogsAsync(string id, object? role = null, object? tail = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/StreamAnalytics/" + HiokClient.Segment(id) + "/logs", null, new Dictionary<string, object?> { ["role"] = role, ["tail"] = tail }, ct);

    /// <summary>Metrics. <c>[GET /api/StreamAnalytics/{id}/metrics]</c></summary>
    public Task<JsonNode?> MetricsAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/StreamAnalytics/" + HiokClient.Segment(id) + "/metrics", null, null, ct);

    /// <summary>Outputs. <c>[GET /api/StreamAnalytics/{id}/outputs]</c></summary>
    public Task<JsonNode?> OutputsAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/StreamAnalytics/" + HiokClient.Segment(id) + "/outputs", null, null, ct);

    /// <summary>Query. <c>[POST /api/StreamAnalytics/{id}/query]</c></summary>
    public Task<JsonNode?> QueryAsync(string id, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/StreamAnalytics/" + HiokClient.Segment(id) + "/query", body, null, ct);

    /// <summary>Query history. <c>[GET /api/StreamAnalytics/{id}/query/history]</c></summary>
    public Task<JsonNode?> QueryHistoryAsync(string id, object? take = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/StreamAnalytics/" + HiokClient.Segment(id) + "/query/history", null, new Dictionary<string, object?> { ["take"] = take }, ct);

    /// <summary>Start. <c>[POST /api/StreamAnalytics/{id}/start]</c></summary>
    public Task<JsonNode?> StartAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/StreamAnalytics/" + HiokClient.Segment(id) + "/start", null, null, ct);

    /// <summary>Status. <c>[GET /api/StreamAnalytics/{id}/status]</c></summary>
    public Task<JsonNode?> StatusAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/StreamAnalytics/" + HiokClient.Segment(id) + "/status", null, null, ct);

    /// <summary>Stop. <c>[POST /api/StreamAnalytics/{id}/stop]</c></summary>
    public Task<JsonNode?> StopAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/StreamAnalytics/" + HiokClient.Segment(id) + "/stop", null, null, ct);

    /// <summary>Transform. <c>[GET /api/StreamAnalytics/{id}/transform]</c></summary>
    public Task<JsonNode?> TransformAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/StreamAnalytics/" + HiokClient.Segment(id) + "/transform", null, null, ct);

    /// <summary>Update. <c>[PATCH /api/StreamAnalytics/{id}]</c></summary>
    public Task<JsonNode?> UpdateAsync(string id, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("PATCH"), "/api/StreamAnalytics/" + HiokClient.Segment(id), body, null, ct);
}

/// <summary>StreamPipeline operations.</summary>
public sealed partial class StreamPipelineApi
{
    private readonly HiokClient _c;
    internal StreamPipelineApi(HiokClient client) => _c = client;

    /// <summary>Create. <c>[POST /api/StreamAnalytics/{jobId}/pipelines]</c></summary>
    public Task<JsonNode?> CreateAsync(string jobId, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/StreamAnalytics/" + HiokClient.Segment(jobId) + "/pipelines", body, null, ct);

    /// <summary>Delete. <c>[DELETE /api/StreamAnalytics/{jobId}/pipelines/{pipelineId}]</c></summary>
    public Task<JsonNode?> DeleteAsync(string jobId, string pipelineId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/StreamAnalytics/" + HiokClient.Segment(jobId) + "/pipelines/" + HiokClient.Segment(pipelineId), null, null, ct);

    /// <summary>Get. <c>[GET /api/StreamAnalytics/{jobId}/pipelines/{pipelineId}]</c></summary>
    public Task<JsonNode?> GetAsync(string jobId, string pipelineId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/StreamAnalytics/" + HiokClient.Segment(jobId) + "/pipelines/" + HiokClient.Segment(pipelineId), null, null, ct);

    /// <summary>Get run. <c>[GET /api/StreamAnalytics/{jobId}/pipelines/runs/{runId}]</c></summary>
    public Task<JsonNode?> GetRunAsync(string jobId, string runId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/StreamAnalytics/" + HiokClient.Segment(jobId) + "/pipelines/runs/" + HiokClient.Segment(runId), null, null, ct);

    /// <summary>List. <c>[GET /api/StreamAnalytics/{jobId}/pipelines]</c></summary>
    public Task<JsonNode?> ListAsync(string jobId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/StreamAnalytics/" + HiokClient.Segment(jobId) + "/pipelines", null, null, ct);

    /// <summary>Preview schedule. <c>[GET /api/StreamAnalytics/schedule-preview]</c></summary>
    public Task<JsonNode?> PreviewScheduleAsync(object? cron = null, object? timeZone = null, object? count = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/StreamAnalytics/schedule-preview", null, new Dictionary<string, object?> { ["cron"] = cron, ["timeZone"] = timeZone, ["count"] = count }, ct);

    /// <summary>Run. <c>[POST /api/StreamAnalytics/{jobId}/pipelines/{pipelineId}/run]</c></summary>
    public Task<JsonNode?> RunAsync(string jobId, string pipelineId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/StreamAnalytics/" + HiokClient.Segment(jobId) + "/pipelines/" + HiokClient.Segment(pipelineId) + "/run", null, null, ct);

    /// <summary>Runs. <c>[GET /api/StreamAnalytics/{jobId}/pipelines/{pipelineId}/runs]</c></summary>
    public Task<JsonNode?> RunsAsync(string jobId, string pipelineId, object? limit = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/StreamAnalytics/" + HiokClient.Segment(jobId) + "/pipelines/" + HiokClient.Segment(pipelineId) + "/runs", null, new Dictionary<string, object?> { ["limit"] = limit }, ct);

    /// <summary>Update. <c>[PUT /api/StreamAnalytics/{jobId}/pipelines/{pipelineId}]</c></summary>
    public Task<JsonNode?> UpdateAsync(string jobId, string pipelineId, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("PUT"), "/api/StreamAnalytics/" + HiokClient.Segment(jobId) + "/pipelines/" + HiokClient.Segment(pipelineId), body, null, ct);
}

/// <summary>Streaming operations.</summary>
public sealed partial class StreamingApi
{
    private readonly HiokClient _c;
    internal StreamingApi(HiokClient client) => _c = client;

    /// <summary>Add destination. <c>[POST /api/streaming/{id}/destinations]</c></summary>
    public Task<JsonNode?> AddDestinationAsync(string id, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/streaming/" + HiokClient.Segment(id) + "/destinations", body, null, ct);

    /// <summary>Create. <c>[POST /api/streaming]</c></summary>
    public Task<JsonNode?> CreateAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/streaming", body, null, ct);

    /// <summary>Delete. <c>[DELETE /api/streaming/{id}]</c></summary>
    public Task<JsonNode?> DeleteAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/streaming/" + HiokClient.Segment(id), null, null, ct);

    /// <summary>Delete destination. <c>[DELETE /api/streaming/destinations/{destinationId}]</c></summary>
    public Task<JsonNode?> DeleteDestinationAsync(string destinationId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/streaming/destinations/" + HiokClient.Segment(destinationId), null, null, ct);

    /// <summary>Destinations. <c>[GET /api/streaming/{id}/destinations]</c></summary>
    public Task<JsonNode?> DestinationsAsync(string id, object? refresh = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/streaming/" + HiokClient.Segment(id) + "/destinations", null, new Dictionary<string, object?> { ["refresh"] = refresh }, ct);

    /// <summary>Get. <c>[GET /api/streaming/{id}]</c></summary>
    public Task<JsonNode?> GetAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/streaming/" + HiokClient.Segment(id), null, null, ct);

    /// <summary>List. <c>[GET /api/streaming]</c></summary>
    public Task<JsonNode?> ListAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/streaming", null, null, ct);

    /// <summary>Platforms. <c>[GET /api/streaming/platforms]</c></summary>
    public Task<JsonNode?> PlatformsAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/streaming/platforms", null, null, ct);

    /// <summary>Sync destinations. <c>[POST /api/streaming/{id}/destinations/sync]</c></summary>
    public Task<JsonNode?> SyncDestinationsAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/streaming/" + HiokClient.Segment(id) + "/destinations/sync", null, null, ct);

    /// <summary>Update destination. <c>[PUT /api/streaming/destinations/{destinationId}]</c></summary>
    public Task<JsonNode?> UpdateDestinationAsync(string destinationId, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("PUT"), "/api/streaming/destinations/" + HiokClient.Segment(destinationId), body, null, ct);
}

/// <summary>Subscription operations.</summary>
public sealed partial class SubscriptionApi
{
    private readonly HiokClient _c;
    internal SubscriptionApi(HiokClient client) => _c = client;

    /// <summary>Active subscriptions. <c>[GET /api/Subscription/activesubscriptions]</c></summary>
    public Task<JsonNode?> ActiveSubscriptionsAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Subscription/activesubscriptions", null, null, ct);

    /// <summary>Add subscriptionto user. <c>[POST /api/Subscription/addsubscriptiontouser]</c></summary>
    public Task<JsonNode?> AddSubscriptiontoUserAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Subscription/addsubscriptiontouser", body, null, ct);

    /// <summary>Create subscription. <c>[POST /api/Subscription/createsubscriptions]</c></summary>
    public Task<JsonNode?> CreateSubscriptionAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Subscription/createsubscriptions", body, null, ct);

    /// <summary>Create user subscription. <c>[POST /api/Subscription/createsubscription]</c></summary>
    public Task<JsonNode?> CreateUserSubscriptionAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Subscription/createsubscription", body, null, ct);

    /// <summary>Delete subscription by id. <c>[DELETE /api/Subscription/removesubscription/{id}]</c></summary>
    public Task<JsonNode?> DeleteSubscriptionByIdAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/Subscription/removesubscription/" + HiokClient.Segment(id), null, null, ct);

    /// <summary>My subscriptions. <c>[GET /api/Subscription/mysubscriptions]</c></summary>
    public Task<JsonNode?> MySubscriptionsAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Subscription/mysubscriptions", null, null, ct);

    /// <summary>Subscriptions. <c>[GET /api/Subscription/subscriptions]</c></summary>
    public Task<JsonNode?> SubscriptionsAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Subscription/subscriptions", null, null, ct);
}

/// <summary>Support operations.</summary>
public sealed partial class SupportApi
{
    private readonly HiokClient _c;
    internal SupportApi(HiokClient client) => _c = client;

    /// <summary>Close. <c>[POST /api/support/tickets/{id}/close]</c></summary>
    public Task<JsonNode?> CloseAsync(string id, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/support/tickets/" + HiokClient.Segment(id) + "/close", body, null, ct);

    /// <summary>Mine. <c>[GET /api/support/tickets]</c></summary>
    public Task<JsonNode?> MineAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/support/tickets", null, null, ct);

    /// <summary>Raise. <c>[POST /api/support/tickets]</c></summary>
    public Task<JsonNode?> RaiseAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/support/tickets", body, null, ct);
}

/// <summary>SupportQueue operations.</summary>
public sealed partial class SupportQueueApi
{
    private readonly HiokClient _c;
    internal SupportQueueApi(HiokClient client) => _c = client;

    /// <summary>Queue. <c>[GET /api/admin/support]</c></summary>
    public Task<JsonNode?> QueueAsync(object? status = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/admin/support", null, new Dictionary<string, object?> { ["status"] = status }, ct);

    /// <summary>Update. <c>[PUT /api/admin/support/{id}]</c></summary>
    public Task<JsonNode?> UpdateAsync(string id, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("PUT"), "/api/admin/support/" + HiokClient.Segment(id), body, null, ct);
}

/// <summary>Upload operations.</summary>
public sealed partial class UploadApi
{
    private readonly HiokClient _c;
    internal UploadApi(HiokClient client) => _c = client;

    /// <summary>Finalize upload. <c>[POST /api/Upload/finalizeupload]</c></summary>
    public Task<JsonNode?> FinalizeUploadAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Upload/finalizeupload", body, null, ct);

    /// <summary>Initiate upload. <c>[POST /api/Upload/initiateupload]</c></summary>
    public Task<JsonNode?> InitiateUploadAsync(IDictionary<string, string>? form = null, IDictionary<string, (string FileName, byte[] Content)>? files = null, object? uploadDirPath = null, object? folderDirPath = null, CancellationToken ct = default)
        => _c.InvokeMultipartAsync(HttpMethod.Post, "/api/Upload/initiateupload", form, files, new Dictionary<string, object?> { ["uploadDirPath"] = uploadDirPath, ["folderDirPath"] = folderDirPath }, ct);

    /// <summary>Upload chunk. <c>[POST /api/Upload/uploadchunk]</c></summary>
    public Task<JsonNode?> UploadChunkAsync(IDictionary<string, string>? form = null, IDictionary<string, (string FileName, byte[] Content)>? files = null, object? directoryName = null, object? chunkindex = null, object? uploadDirPath = null, object? folderDirPath = null, CancellationToken ct = default)
        => _c.InvokeMultipartAsync(HttpMethod.Post, "/api/Upload/uploadchunk", form, files, new Dictionary<string, object?> { ["directoryName"] = directoryName, ["chunkindex"] = chunkindex, ["uploadDirPath"] = uploadDirPath, ["folderDirPath"] = folderDirPath }, ct);
}

/// <summary>VPNGateway operations.</summary>
public sealed partial class VPNGatewayApi
{
    private readonly HiokClient _c;
    internal VPNGatewayApi(HiokClient client) => _c = client;

    /// <summary>Create p2 sclient. <c>[POST /api/VPNGateway/clients/p2s]</c></summary>
    public Task<JsonNode?> CreateP2SClientAsync(object? body = null, object? region = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/VPNGateway/clients/p2s", body, new Dictionary<string, object?> { ["region"] = region }, ct);

    /// <summary>Create s2 sconnection. <c>[POST /api/VPNGateway/connections/s2s]</c></summary>
    public Task<JsonNode?> CreateS2SConnectionAsync(object? body = null, object? region = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/VPNGateway/connections/s2s", body, new Dictionary<string, object?> { ["region"] = region }, ct);

    /// <summary>Create vpngateway. <c>[POST /api/VPNGateway/create]</c></summary>
    public Task<JsonNode?> CreateVPNGatewayAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/VPNGateway/create", body, null, ct);

    /// <summary>Delete s2 sconnection. <c>[DELETE /api/VPNGateway/connections/s2s/{connectionId}]</c></summary>
    public Task<JsonNode?> DeleteS2SConnectionAsync(string connectionId, object? region = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/VPNGateway/connections/s2s/" + HiokClient.Segment(connectionId), null, new Dictionary<string, object?> { ["region"] = region }, ct);

    /// <summary>Delete vpngateway. <c>[DELETE /api/VPNGateway/{gatewayId}]</c></summary>
    public Task<JsonNode?> DeleteVPNGatewayAsync(string gatewayId, object? gatewayName = null, object? region = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/VPNGateway/" + HiokClient.Segment(gatewayId), null, new Dictionary<string, object?> { ["gatewayName"] = gatewayName, ["region"] = region }, ct);

    /// <summary>Download client config. <c>[GET /api/VPNGateway/clients/p2s/{clientId}/config]</c></summary>
    public Task<JsonNode?> DownloadClientConfigAsync(string clientId, object? region = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/VPNGateway/clients/p2s/" + HiokClient.Segment(clientId) + "/config", null, new Dictionary<string, object?> { ["region"] = region }, ct);

    /// <summary>Get connected clients. <c>[GET /api/VPNGateway/{gatewayId}/clients/p2s/connected]</c></summary>
    public Task<JsonNode?> GetConnectedClientsAsync(string gatewayId, object? region = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/VPNGateway/" + HiokClient.Segment(gatewayId) + "/clients/p2s/connected", null, new Dictionary<string, object?> { ["region"] = region }, ct);

    /// <summary>Get s2 sconnection status. <c>[GET /api/VPNGateway/connections/s2s/{connectionId}/status]</c></summary>
    public Task<JsonNode?> GetS2SConnectionStatusAsync(string connectionId, object? region = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/VPNGateway/connections/s2s/" + HiokClient.Segment(connectionId) + "/status", null, new Dictionary<string, object?> { ["region"] = region }, ct);

    /// <summary>Get vpngateway. <c>[GET /api/VPNGateway/{gatewayId}]</c></summary>
    public Task<JsonNode?> GetVPNGatewayAsync(string gatewayId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/VPNGateway/" + HiokClient.Segment(gatewayId), null, null, ct);

    /// <summary>Get vpngateway status. <c>[GET /api/VPNGateway/{gatewayId}/status]</c></summary>
    public Task<JsonNode?> GetVPNGatewayStatusAsync(string gatewayId, object? region = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/VPNGateway/" + HiokClient.Segment(gatewayId) + "/status", null, new Dictionary<string, object?> { ["region"] = region }, ct);

    /// <summary>List p2 sclients. <c>[GET /api/VPNGateway/{gatewayId}/clients/p2s]</c></summary>
    public Task<JsonNode?> ListP2SClientsAsync(string gatewayId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/VPNGateway/" + HiokClient.Segment(gatewayId) + "/clients/p2s", null, null, ct);

    /// <summary>List s2 sconnections. <c>[GET /api/VPNGateway/{gatewayId}/connections/s2s]</c></summary>
    public Task<JsonNode?> ListS2SConnectionsAsync(string gatewayId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/VPNGateway/" + HiokClient.Segment(gatewayId) + "/connections/s2s", null, null, ct);

    /// <summary>List vpngateways. <c>[GET /api/VPNGateway/list]</c></summary>
    public Task<JsonNode?> ListVPNGatewaysAsync(object? vnetId = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/VPNGateway/list", null, new Dictionary<string, object?> { ["vnetId"] = vnetId }, ct);

    /// <summary>Revoke p2 sclient. <c>[DELETE /api/VPNGateway/clients/p2s/{clientId}]</c></summary>
    public Task<JsonNode?> RevokeP2SClientAsync(string clientId, object? region = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/VPNGateway/clients/p2s/" + HiokClient.Segment(clientId), null, new Dictionary<string, object?> { ["region"] = region }, ct);
}

/// <summary>VXLAN operations.</summary>
public sealed partial class VXLANApi
{
    private readonly HiokClient _c;
    internal VXLANApi(HiokClient client) => _c = client;

    /// <summary>Add vtep. <c>[POST /api/VXLAN/tunnels/{tunnelId}/vteps]</c></summary>
    public Task<JsonNode?> AddVtepAsync(string tunnelId, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/VXLAN/tunnels/" + HiokClient.Segment(tunnelId) + "/vteps", body, null, ct);

    /// <summary>Create tunnel. <c>[POST /api/VXLAN/tunnels]</c></summary>
    public Task<JsonNode?> CreateTunnelAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/VXLAN/tunnels", body, null, ct);

    /// <summary>Delete tunnel. <c>[DELETE /api/VXLAN/tunnels/{tunnelId}]</c></summary>
    public Task<JsonNode?> DeleteTunnelAsync(string tunnelId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/VXLAN/tunnels/" + HiokClient.Segment(tunnelId), null, null, ct);

    /// <summary>Get tunnel. <c>[GET /api/VXLAN/tunnels/{tunnelId}]</c></summary>
    public Task<JsonNode?> GetTunnelAsync(string tunnelId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/VXLAN/tunnels/" + HiokClient.Segment(tunnelId), null, null, ct);

    /// <summary>List tunnels. <c>[GET /api/VXLAN/tunnels]</c></summary>
    public Task<JsonNode?> ListTunnelsAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/VXLAN/tunnels", null, null, ct);

    /// <summary>Remove vtep. <c>[DELETE /api/VXLAN/tunnels/{tunnelId}/vteps/{vtepIp}]</c></summary>
    public Task<JsonNode?> RemoveVtepAsync(string tunnelId, string vtepIp, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/VXLAN/tunnels/" + HiokClient.Segment(tunnelId) + "/vteps/" + HiokClient.Segment(vtepIp), null, null, ct);
}

/// <summary>VirtualMachine operations.</summary>
public sealed partial class VirtualMachineApi
{
    private readonly HiokClient _c;
    internal VirtualMachineApi(HiokClient client) => _c = client;

    /// <summary>Create vm. <c>[POST /api/VirtualMachine/create-vm]</c></summary>
    public Task<JsonNode?> CreateVMAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/VirtualMachine/create-vm", body, null, ct);

    /// <summary>Destroy vm. <c>[DELETE /api/VirtualMachine/destroy-vm]</c></summary>
    public Task<JsonNode?> DestroyVMAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/VirtualMachine/destroy-vm", body, null, ct);

    /// <summary>Get ssh private key. <c>[GET /api/VirtualMachine/{id}/sshkey]</c></summary>
    public Task<JsonNode?> GetSshPrivateKeyAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/VirtualMachine/" + HiokClient.Segment(id) + "/sshkey", null, null, ct);

    /// <summary>Get vminfo. <c>[GET /api/VirtualMachine/vm-info]</c></summary>
    public Task<JsonNode?> GetVMInfoAsync(object? vmName = null, object? regions = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/VirtualMachine/vm-info", null, new Dictionary<string, object?> { ["vmName"] = vmName, ["regions"] = regions }, ct);

    /// <summary>List local vmimages. <c>[GET /api/VirtualMachine/list-local-vm-images]</c></summary>
    public Task<JsonNode?> ListLocalVMImagesAsync(object? regions = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/VirtualMachine/list-local-vm-images", null, new Dictionary<string, object?> { ["regions"] = regions }, ct);

    /// <summary>List running vms. <c>[GET /api/VirtualMachine/list-running-vms]</c></summary>
    public Task<JsonNode?> ListRunningVMsAsync(object? regions = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/VirtualMachine/list-running-vms", null, new Dictionary<string, object?> { ["regions"] = regions }, ct);

    /// <summary>List vms. <c>[GET /api/VirtualMachine/list-vms]</c></summary>
    public Task<JsonNode?> ListVMsAsync(object? regions = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/VirtualMachine/list-vms", null, new Dictionary<string, object?> { ["regions"] = regions }, ct);

    /// <summary>List vms info. <c>[GET /api/VirtualMachine/list-vms-info]</c></summary>
    public Task<JsonNode?> ListVMsInfoAsync(object? regions = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/VirtualMachine/list-vms-info", null, new Dictionary<string, object?> { ["regions"] = regions }, ct);

    /// <summary>Reset password. <c>[POST /api/VirtualMachine/reset-password]</c></summary>
    public Task<JsonNode?> ResetPasswordAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/VirtualMachine/reset-password", body, null, ct);

    /// <summary>Start vm. <c>[POST /api/VirtualMachine/start-vm]</c></summary>
    public Task<JsonNode?> StartVMAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/VirtualMachine/start-vm", body, null, ct);

    /// <summary>Stop vm. <c>[POST /api/VirtualMachine/stop-vm]</c></summary>
    public Task<JsonNode?> StopVMAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/VirtualMachine/stop-vm", body, null, ct);
}

/// <summary>VirtualNetwork operations.</summary>
public sealed partial class VirtualNetworkApi
{
    private readonly HiokClient _c;
    internal VirtualNetworkApi(HiokClient client) => _c = client;

    /// <summary>Create vnet. <c>[POST /api/VirtualNetwork/create-vnet]</c></summary>
    public Task<JsonNode?> CreateVNetAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/VirtualNetwork/create-vnet", body, null, ct);

    /// <summary>Create vnet peering. <c>[POST /api/VirtualNetwork/{vnetId}/peerings]</c></summary>
    public Task<JsonNode?> CreateVnetPeeringAsync(string vnetId, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/VirtualNetwork/" + HiokClient.Segment(vnetId) + "/peerings", body, null, ct);

    /// <summary>Delete vnet peering. <c>[DELETE /api/VirtualNetwork/{vnetId}/peerings/{peeringId}]</c></summary>
    public Task<JsonNode?> DeleteVnetPeeringAsync(string vnetId, string peeringId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/VirtualNetwork/" + HiokClient.Segment(vnetId) + "/peerings/" + HiokClient.Segment(peeringId), null, null, ct);

    /// <summary>Delete vnet subnet. <c>[DELETE /api/VirtualNetwork/{vnetId}/subnets/{subnetId}]</c></summary>
    public Task<JsonNode?> DeleteVnetSubnetAsync(string vnetId, string subnetId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/VirtualNetwork/" + HiokClient.Segment(vnetId) + "/subnets/" + HiokClient.Segment(subnetId), null, null, ct);

    /// <summary>Destroy vnet. <c>[DELETE /api/VirtualNetwork/delete-vnet]</c></summary>
    public Task<JsonNode?> DestroyVNetAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/VirtualNetwork/delete-vnet", body, null, ct);

    /// <summary>List all peerings. <c>[GET /api/VirtualNetwork/peerings]</c></summary>
    public Task<JsonNode?> ListAllPeeringsAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/VirtualNetwork/peerings", null, null, ct);

    /// <summary>List all subnets. <c>[GET /api/VirtualNetwork/subnets]</c></summary>
    public Task<JsonNode?> ListAllSubnetsAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/VirtualNetwork/subnets", null, null, ct);

    /// <summary>List vms info. <c>[GET /api/VirtualNetwork/list-vnets]</c></summary>
    public Task<JsonNode?> ListVMsInfoAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/VirtualNetwork/list-vnets", null, null, ct);

    /// <summary>List vnet address spaces. <c>[GET /api/VirtualNetwork/{vnetId}/address-spaces]</c></summary>
    public Task<JsonNode?> ListVnetAddressSpacesAsync(string vnetId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/VirtualNetwork/" + HiokClient.Segment(vnetId) + "/address-spaces", null, null, ct);

    /// <summary>List vnet peerings. <c>[GET /api/VirtualNetwork/{vnetId}/peerings]</c></summary>
    public Task<JsonNode?> ListVnetPeeringsAsync(string vnetId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/VirtualNetwork/" + HiokClient.Segment(vnetId) + "/peerings", null, null, ct);

    /// <summary>List vnet subnets. <c>[GET /api/VirtualNetwork/{vnetId}/subnets]</c></summary>
    public Task<JsonNode?> ListVnetSubnetsAsync(string vnetId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/VirtualNetwork/" + HiokClient.Segment(vnetId) + "/subnets", null, null, ct);

    /// <summary>Save vnet address space. <c>[PUT /api/VirtualNetwork/{vnetId}/address-spaces]</c></summary>
    public Task<JsonNode?> SaveVnetAddressSpaceAsync(string vnetId, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("PUT"), "/api/VirtualNetwork/" + HiokClient.Segment(vnetId) + "/address-spaces", body, null, ct);

    /// <summary>Save vnet subnet. <c>[PUT /api/VirtualNetwork/{vnetId}/subnets]</c></summary>
    public Task<JsonNode?> SaveVnetSubnetAsync(string vnetId, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("PUT"), "/api/VirtualNetwork/" + HiokClient.Segment(vnetId) + "/subnets", body, null, ct);
}

/// <summary>VmConsole operations.</summary>
public sealed partial class VmConsoleApi
{
    private readonly HiokClient _c;
    internal VmConsoleApi(HiokClient client) => _c = client;

    /// <summary>Console. <c>[GET /api/VirtualMachine/{id}/console]</c></summary>
    public Task<JsonNode?> ConsoleAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/VirtualMachine/" + HiokClient.Segment(id) + "/console", null, null, ct);

    /// <summary>Console ticket. <c>[GET /api/VirtualMachine/{id}/console-ticket]</c></summary>
    public Task<JsonNode?> ConsoleTicketAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/VirtualMachine/" + HiokClient.Segment(id) + "/console-ticket", null, null, ct);
}

/// <summary>VmNetwork operations.</summary>
public sealed partial class VmNetworkApi
{
    private readonly HiokClient _c;
    internal VmNetworkApi(HiokClient client) => _c = client;

    /// <summary>Create. <c>[POST /api/VirtualMachine/{vmName}/network-rules]</c></summary>
    public Task<JsonNode?> CreateAsync(string vmName, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/VirtualMachine/" + HiokClient.Segment(vmName) + "/network-rules", body, null, ct);

    /// <summary>Delete. <c>[DELETE /api/VirtualMachine/network-rules/{id}]</c></summary>
    public Task<JsonNode?> DeleteAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/VirtualMachine/network-rules/" + HiokClient.Segment(id), null, null, ct);

    /// <summary>List. <c>[GET /api/VirtualMachine/{vmName}/network-rules]</c></summary>
    public Task<JsonNode?> ListAsync(string vmName, object? type = null, object? direction = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/VirtualMachine/" + HiokClient.Segment(vmName) + "/network-rules", null, new Dictionary<string, object?> { ["type"] = type, ["direction"] = direction }, ct);

    /// <summary>Network info. <c>[GET /api/VirtualMachine/{vmName}/network-info]</c></summary>
    public Task<JsonNode?> NetworkInfoAsync(string vmName, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/VirtualMachine/" + HiokClient.Segment(vmName) + "/network-info", null, null, ct);

    /// <summary>Sync. <c>[POST /api/VirtualMachine/{vmName}/network-rules/sync]</c></summary>
    public Task<JsonNode?> SyncAsync(string vmName, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/VirtualMachine/" + HiokClient.Segment(vmName) + "/network-rules/sync", null, null, ct);

    /// <summary>Update. <c>[PUT /api/VirtualMachine/network-rules/{id}]</c></summary>
    public Task<JsonNode?> UpdateAsync(string id, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("PUT"), "/api/VirtualMachine/network-rules/" + HiokClient.Segment(id), body, null, ct);
}

/// <summary>VmOperations operations.</summary>
public sealed partial class VmOperationsApi
{
    private readonly HiokClient _c;
    internal VmOperationsApi(HiokClient client) => _c = client;

    /// <summary>Attach nic. <c>[POST /api/VirtualMachine/{vmName}/nics]</c></summary>
    public Task<JsonNode?> AttachNicAsync(string vmName, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/VirtualMachine/" + HiokClient.Segment(vmName) + "/nics", body, null, ct);

    /// <summary>Attach public ip. <c>[POST /api/VirtualMachine/{vmName}/public-ips]</c></summary>
    public Task<JsonNode?> AttachPublicIpAsync(string vmName, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/VirtualMachine/" + HiokClient.Segment(vmName) + "/public-ips", body, null, ct);

    /// <summary>Connect. <c>[GET /api/VirtualMachine/{vmName}/connect]</c></summary>
    public Task<JsonNode?> ConnectAsync(string vmName, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/VirtualMachine/" + HiokClient.Segment(vmName) + "/connect", null, null, ct);

    /// <summary>Create snapshot. <c>[POST /api/VirtualMachine/{vmName}/snapshots]</c></summary>
    public Task<JsonNode?> CreateSnapshotAsync(string vmName, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/VirtualMachine/" + HiokClient.Segment(vmName) + "/snapshots", body, null, ct);

    /// <summary>Delete snapshot. <c>[DELETE /api/VirtualMachine/{vmName}/snapshots/{snapshotName}]</c></summary>
    public Task<JsonNode?> DeleteSnapshotAsync(string vmName, string snapshotName, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/VirtualMachine/" + HiokClient.Segment(vmName) + "/snapshots/" + HiokClient.Segment(snapshotName), null, null, ct);

    /// <summary>Detach nic. <c>[DELETE /api/VirtualMachine/{vmName}/nics/{mac}]</c></summary>
    public Task<JsonNode?> DetachNicAsync(string vmName, string mac, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/VirtualMachine/" + HiokClient.Segment(vmName) + "/nics/" + HiokClient.Segment(mac), null, null, ct);

    /// <summary>Detach public ip. <c>[DELETE /api/VirtualMachine/{vmName}/public-ips/{allocationId}]</c></summary>
    public Task<JsonNode?> DetachPublicIpAsync(string vmName, string allocationId, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/VirtualMachine/" + HiokClient.Segment(vmName) + "/public-ips/" + HiokClient.Segment(allocationId), null, null, ct);

    /// <summary>List nics. <c>[GET /api/VirtualMachine/{vmName}/nics]</c></summary>
    public Task<JsonNode?> ListNicsAsync(string vmName, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/VirtualMachine/" + HiokClient.Segment(vmName) + "/nics", null, null, ct);

    /// <summary>List public ips. <c>[GET /api/VirtualMachine/{vmName}/public-ips]</c></summary>
    public Task<JsonNode?> ListPublicIpsAsync(string vmName, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/VirtualMachine/" + HiokClient.Segment(vmName) + "/public-ips", null, null, ct);

    /// <summary>List snapshots. <c>[GET /api/VirtualMachine/{vmName}/snapshots]</c></summary>
    public Task<JsonNode?> ListSnapshotsAsync(string vmName, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/VirtualMachine/" + HiokClient.Segment(vmName) + "/snapshots", null, null, ct);

    /// <summary>Rdp file. <c>[GET /api/VirtualMachine/{vmName}/rdp-file]</c></summary>
    public Task<JsonNode?> RdpFileAsync(string vmName, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/VirtualMachine/" + HiokClient.Segment(vmName) + "/rdp-file", null, null, ct);

    /// <summary>Restore snapshot. <c>[POST /api/VirtualMachine/{vmName}/snapshots/{snapshotName}/restore]</c></summary>
    public Task<JsonNode?> RestoreSnapshotAsync(string vmName, string snapshotName, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/VirtualMachine/" + HiokClient.Segment(vmName) + "/snapshots/" + HiokClient.Segment(snapshotName) + "/restore", null, null, ct);

    /// <summary>Ssh key. <c>[GET /api/VirtualMachine/{vmName}/ssh-key]</c></summary>
    public Task<JsonNode?> SshKeyAsync(string vmName, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/VirtualMachine/" + HiokClient.Segment(vmName) + "/ssh-key", null, null, ct);
}

/// <summary>Webmail operations.</summary>
public sealed partial class WebmailApi
{
    private readonly HiokClient _c;
    internal WebmailApi(HiokClient client) => _c = client;

    /// <summary>Assist. <c>[POST /api/mail/assist]</c></summary>
    public Task<JsonNode?> AssistAsync(object? body = null, object? accountId = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/mail/assist", body, new Dictionary<string, object?> { ["accountId"] = accountId }, ct);

    /// <summary>Attachment. <c>[GET /api/mail/messages/{id}/attachments/{attachmentId}]</c></summary>
    public Task<JsonNode?> AttachmentAsync(string id, string attachmentId, object? accountId = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/mail/messages/" + HiokClient.Segment(id) + "/attachments/" + HiokClient.Segment(attachmentId), null, new Dictionary<string, object?> { ["accountId"] = accountId }, ct);

    /// <summary>Change password. <c>[POST /api/mail/password]</c></summary>
    public Task<JsonNode?> ChangePasswordAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/mail/password", body, null, ct);

    /// <summary>Contacts. <c>[GET /api/mail/contacts]</c></summary>
    public Task<JsonNode?> ContactsAsync(object? accountId = null, object? q = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/mail/contacts", null, new Dictionary<string, object?> { ["accountId"] = accountId, ["q"] = q }, ct);

    /// <summary>Create filter. <c>[POST /api/mail/filters]</c></summary>
    public Task<JsonNode?> CreateFilterAsync(object? body = null, object? accountId = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/mail/filters", body, new Dictionary<string, object?> { ["accountId"] = accountId }, ct);

    /// <summary>Create folder. <c>[POST /api/mail/folders]</c></summary>
    public Task<JsonNode?> CreateFolderAsync(object? body = null, object? accountId = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/mail/folders", body, new Dictionary<string, object?> { ["accountId"] = accountId }, ct);

    /// <summary>Create label. <c>[POST /api/mail/labels]</c></summary>
    public Task<JsonNode?> CreateLabelAsync(object? body = null, object? accountId = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/mail/labels", body, new Dictionary<string, object?> { ["accountId"] = accountId }, ct);

    /// <summary>Delete. <c>[POST /api/mail/messages/delete]</c></summary>
    public Task<JsonNode?> DeleteAsync(object? body = null, object? accountId = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/mail/messages/delete", body, new Dictionary<string, object?> { ["accountId"] = accountId }, ct);

    /// <summary>Delete filter. <c>[DELETE /api/mail/filters/{id}]</c></summary>
    public Task<JsonNode?> DeleteFilterAsync(string id, object? accountId = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/mail/filters/" + HiokClient.Segment(id), null, new Dictionary<string, object?> { ["accountId"] = accountId }, ct);

    /// <summary>Drop upload. <c>[DELETE /api/mail/attachments/{id}]</c></summary>
    public Task<JsonNode?> DropUploadAsync(string id, object? accountId = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/mail/attachments/" + HiokClient.Segment(id), null, new Dictionary<string, object?> { ["accountId"] = accountId }, ct);

    /// <summary>Filters. <c>[GET /api/mail/filters]</c></summary>
    public Task<JsonNode?> FiltersAsync(object? accountId = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/mail/filters", null, new Dictionary<string, object?> { ["accountId"] = accountId }, ct);

    /// <summary>Flag. <c>[POST /api/mail/messages/flag]</c></summary>
    public Task<JsonNode?> FlagAsync(object? body = null, object? accountId = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/mail/messages/flag", body, new Dictionary<string, object?> { ["accountId"] = accountId }, ct);

    /// <summary>Folders. <c>[GET /api/mail/folders]</c></summary>
    public Task<JsonNode?> FoldersAsync(object? accountId = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/mail/folders", null, new Dictionary<string, object?> { ["accountId"] = accountId }, ct);

    /// <summary>Me. <c>[GET /api/mail/me]</c></summary>
    public Task<JsonNode?> MeAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/mail/me", null, null, ct);

    /// <summary>Message. <c>[GET /api/mail/messages/{id}]</c></summary>
    public Task<JsonNode?> MessageAsync(string id, object? accountId = null, object? markRead = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/mail/messages/" + HiokClient.Segment(id), null, new Dictionary<string, object?> { ["accountId"] = accountId, ["markRead"] = markRead }, ct);

    /// <summary>Messages. <c>[GET /api/mail/messages]</c></summary>
    public Task<JsonNode?> MessagesAsync(object? accountId = null, object? folderId = null, object? q = null, object? unread = null, object? starred = null, object? page = null, object? pageSize = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/mail/messages", null, new Dictionary<string, object?> { ["accountId"] = accountId, ["folderId"] = folderId, ["q"] = q, ["unread"] = unread, ["starred"] = starred, ["page"] = page, ["pageSize"] = pageSize }, ct);

    /// <summary>Mine. <c>[GET /api/mail/mine]</c></summary>
    public Task<JsonNode?> MineAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/mail/mine", null, null, ct);

    /// <summary>Move. <c>[POST /api/mail/messages/move]</c></summary>
    public Task<JsonNode?> MoveAsync(object? body = null, object? accountId = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/mail/messages/move", body, new Dictionary<string, object?> { ["accountId"] = accountId }, ct);

    /// <summary>Quote. <c>[GET /api/mail/messages/{id}/quote]</c></summary>
    public Task<JsonNode?> QuoteAsync(string id, object? accountId = null, object? forward = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/mail/messages/" + HiokClient.Segment(id) + "/quote", null, new Dictionary<string, object?> { ["accountId"] = accountId, ["forward"] = forward }, ct);

    /// <summary>Save draft. <c>[POST /api/mail/draft]</c></summary>
    public Task<JsonNode?> SaveDraftAsync(object? body = null, object? accountId = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/mail/draft", body, new Dictionary<string, object?> { ["accountId"] = accountId }, ct);

    /// <summary>Schedule. <c>[POST /api/mail/schedule]</c></summary>
    public Task<JsonNode?> ScheduleAsync(object? body = null, object? accountId = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/mail/schedule", body, new Dictionary<string, object?> { ["accountId"] = accountId }, ct);

    /// <summary>Send. <c>[POST /api/mail/send]</c></summary>
    public Task<JsonNode?> SendAsync(object? body = null, object? accountId = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/mail/send", body, new Dictionary<string, object?> { ["accountId"] = accountId }, ct);

    /// <summary>Settings. <c>[PATCH /api/mail/settings]</c></summary>
    public Task<JsonNode?> SettingsAsync(object? body = null, object? accountId = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("PATCH"), "/api/mail/settings", body, new Dictionary<string, object?> { ["accountId"] = accountId }, ct);

    /// <summary>Sign in. <c>[POST /api/mail/signin]</c></summary>
    public Task<JsonNode?> SignInAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/mail/signin", body, null, ct);

    /// <summary>Sign out. <c>[POST /api/mail/signout]</c></summary>
    public Task<JsonNode?> SignOutAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/mail/signout", null, null, ct);

    /// <summary>Unschedule. <c>[POST /api/mail/schedule/{id}/cancel]</c></summary>
    public Task<JsonNode?> UnscheduleAsync(string id, object? accountId = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/mail/schedule/" + HiokClient.Segment(id) + "/cancel", null, new Dictionary<string, object?> { ["accountId"] = accountId }, ct);

    /// <summary>Upload. <c>[POST /api/mail/attachments]</c></summary>
    public Task<JsonNode?> UploadAsync(IDictionary<string, string>? form = null, IDictionary<string, (string FileName, byte[] Content)>? files = null, object? accountId = null, CancellationToken ct = default)
        => _c.InvokeMultipartAsync(HttpMethod.Post, "/api/mail/attachments", form, files, new Dictionary<string, object?> { ["accountId"] = accountId }, ct);
}

/// <summary>Widget operations.</summary>
public sealed partial class WidgetApi
{
    private readonly HiokClient _c;
    internal WidgetApi(HiokClient client) => _c = client;

    /// <summary>Add widget to panel. <c>[POST /api/Widget/addwidgettopanel]</c></summary>
    public Task<JsonNode?> AddWidgetToPanelAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Widget/addwidgettopanel", body, null, ct);

    /// <summary>Clone widget. <c>[POST /api/Widget/clonewidget]</c></summary>
    public Task<JsonNode?> CloneWidgetAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Widget/clonewidget", body, null, ct);

    /// <summary>Create default widgets. <c>[POST /api/Widget/createdefaultwidgets]</c></summary>
    public Task<JsonNode?> CreateDefaultWidgetsAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Widget/createdefaultwidgets", body, null, ct);

    /// <summary>Create widget template. <c>[POST /api/Widget/createwidgettemplate]</c></summary>
    public Task<JsonNode?> CreateWidgetTemplateAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Widget/createwidgettemplate", body, null, ct);

    /// <summary>Create widgets template. <c>[POST /api/Widget/createwidgetstemplate]</c></summary>
    public Task<JsonNode?> CreateWidgetsTemplateAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Widget/createwidgetstemplate", body, null, ct);

    /// <summary>Default widgets. <c>[GET /api/Widget/defaultwidgets]</c></summary>
    public Task<JsonNode?> DefaultWidgetsAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Widget/defaultwidgets", null, null, ct);

    /// <summary>Delete widget from panel. <c>[DELETE /api/Widget/deletepanelwidget]</c></summary>
    public Task<JsonNode?> DeleteWidgetFromPanelAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/Widget/deletepanelwidget", body, null, ct);

    /// <summary>Delete widget template. <c>[DELETE /api/Widget/deletewidgettemplate/{id}]</c></summary>
    public Task<JsonNode?> DeleteWidgetTemplateAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/Widget/deletewidgettemplate/" + HiokClient.Segment(id), null, null, ct);

    /// <summary>Get widget settings. <c>[POST /api/Widget/getwidgetsettings]</c></summary>
    public Task<JsonNode?> GetWidgetSettingsAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Widget/getwidgetsettings", body, null, ct);

    /// <summary>Update widget position. <c>[POST /api/Widget/updatewidgetposition]</c></summary>
    public Task<JsonNode?> UpdateWidgetPositionAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Widget/updatewidgetposition", body, null, ct);

    /// <summary>Update widget settings. <c>[POST /api/Widget/updatewidgetsettings]</c></summary>
    public Task<JsonNode?> UpdateWidgetSettingsAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Widget/updatewidgetsettings", body, null, ct);

    /// <summary>Update widget template. <c>[PUT /api/Widget/updatewidgettemplate/{id}]</c></summary>
    public Task<JsonNode?> UpdateWidgetTemplateAsync(string id, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("PUT"), "/api/Widget/updatewidgettemplate/" + HiokClient.Segment(id), body, null, ct);

    /// <summary>Widget details. <c>[POST /api/Widget/widgetdetails]</c></summary>
    public Task<JsonNode?> WidgetDetailsAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Widget/widgetdetails", body, null, ct);

    /// <summary>Widget library. <c>[GET /api/Widget/widgetlibrary]</c></summary>
    public Task<JsonNode?> WidgetLibraryAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Widget/widgetlibrary", null, null, ct);

    /// <summary>Widget options. <c>[POST /api/Widget/widgetoptions]</c></summary>
    public Task<JsonNode?> WidgetOptionsAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Widget/widgetoptions", body, null, ct);

    /// <summary>Widgets. <c>[POST /api/Widget/widgets]</c></summary>
    public Task<JsonNode?> WidgetsAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Widget/widgets", body, null, ct);
}

/// <summary>Yugabyte operations.</summary>
public sealed partial class YugabyteApi
{
    private readonly HiokClient _c;
    internal YugabyteApi(HiokClient client) => _c = client;

    /// <summary>Attach. <c>[POST /api/Yugabyte/{id}/vnet/attach]</c></summary>
    public Task<JsonNode?> AttachAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Yugabyte/" + HiokClient.Segment(id) + "/vnet/attach", null, null, ct);

    /// <summary>Columns. <c>[GET /api/Yugabyte/{id}/tables/{schema}/{table}/columns]</c></summary>
    public Task<JsonNode?> ColumnsAsync(string id, string schema, string table, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Yugabyte/" + HiokClient.Segment(id) + "/tables/" + HiokClient.Segment(schema) + "/" + HiokClient.Segment(table) + "/columns", null, null, ct);

    /// <summary>Connection. <c>[GET /api/Yugabyte/{id}/connection]</c></summary>
    public Task<JsonNode?> ConnectionAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Yugabyte/" + HiokClient.Segment(id) + "/connection", null, null, ct);

    /// <summary>Create. <c>[POST /api/Yugabyte]</c></summary>
    public Task<JsonNode?> CreateAsync(object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Yugabyte", body, null, ct);

    /// <summary>Delete. <c>[DELETE /api/Yugabyte/{id}]</c></summary>
    public Task<JsonNode?> DeleteAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("DELETE"), "/api/Yugabyte/" + HiokClient.Segment(id), null, null, ct);

    /// <summary>Detach. <c>[POST /api/Yugabyte/{id}/vnet/detach]</c></summary>
    public Task<JsonNode?> DetachAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Yugabyte/" + HiokClient.Segment(id) + "/vnet/detach", null, null, ct);

    /// <summary>Get. <c>[GET /api/Yugabyte/{id}]</c></summary>
    public Task<JsonNode?> GetAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Yugabyte/" + HiokClient.Segment(id), null, null, ct);

    /// <summary>List. <c>[GET /api/Yugabyte]</c></summary>
    public Task<JsonNode?> ListAsync(CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Yugabyte", null, null, ct);

    /// <summary>Query. <c>[POST /api/Yugabyte/{id}/query]</c></summary>
    public Task<JsonNode?> QueryAsync(string id, object? body = null, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Yugabyte/" + HiokClient.Segment(id) + "/query", body, null, ct);

    /// <summary>Start. <c>[POST /api/Yugabyte/{id}/start]</c></summary>
    public Task<JsonNode?> StartAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Yugabyte/" + HiokClient.Segment(id) + "/start", null, null, ct);

    /// <summary>Stop. <c>[POST /api/Yugabyte/{id}/stop]</c></summary>
    public Task<JsonNode?> StopAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("POST"), "/api/Yugabyte/" + HiokClient.Segment(id) + "/stop", null, null, ct);

    /// <summary>Tables. <c>[GET /api/Yugabyte/{id}/tables]</c></summary>
    public Task<JsonNode?> TablesAsync(string id, CancellationToken ct = default)
        => _c.InvokeAsync(new HttpMethod("GET"), "/api/Yugabyte/" + HiokClient.Segment(id) + "/tables", null, null, ct);
}
