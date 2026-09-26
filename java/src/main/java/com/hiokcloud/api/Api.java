// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.
package com.hiokcloud.api;

import com.hiokcloud.HiokClient;

/** Every API operation, grouped as the API groups them: {@code client.api().<group>().<operation>()}. */
public final class Api {
    private final AccessControlApi accessControl;
    private final AdminApi admin;
    private final AdminDataApi adminData;
    private final AdminDnsApi adminDns;
    private final AdminInfrastructureApi adminInfrastructure;
    private final AdvisorApi advisor;
    private final AnalyticsApi analytics;
    private final ApiManagementApi apiManagement;
    private final AssistantApi assistant;
    private final BastionApi bastion;
    private final BillingWebhookApi billingWebhook;
    private final CacheApi cache;
    private final CardsApi cards;
    private final CloudShellApi cloudShell;
    private final CloudSubscriptionApi cloudSubscription;
    private final CommonServicesApi commonServices;
    private final CommunicationApi communication;
    private final ContainerAppApi containerApp;
    private final ContainerJobsApi containerJobs;
    private final ContainerRegistryApi containerRegistry;
    private final ContainersApi containers;
    private final CostTrackingApi costTracking;
    private final CreateResourceApi createResource;
    private final DeploymentApi deployment;
    private final DockerImagesApi dockerImages;
    private final DownloadsApi downloads;
    private final DpsApi dps;
    private final FxApi fx;
    private final GroupsApi groups;
    private final HierarchyViewApi hierarchyView;
    private final HiokCloudGroupsApi hiokCloudGroups;
    private final HiokCloudHierarchyApi hiokCloudHierarchy;
    private final HiokUsersApi hiokUsers;
    private final HybridApi hybrid;
    private final IdentityApi identity;
    private final InfrastructureApi infrastructure;
    private final IoTDeviceGatewayApi ioTDeviceGateway;
    private final IoTHubApi ioTHub;
    private final IoTHubDeviceApi ioTHubDevice;
    private final IoTHubDiagnosticsApi ioTHubDiagnostics;
    private final IoTHubManagementApi ioTHubManagement;
    private final IoTHubProtocolApi ioTHubProtocol;
    private final K9sConsoleApi k9sConsole;
    private final KeyVaultApi keyVault;
    private final KubernetesApi kubernetes;
    private final MailAdminApi mailAdmin;
    private final MarketplaceApi marketplace;
    private final MetricsApi metrics;
    private final MongoApi mongo;
    private final MySqlDatabaseApi mySqlDatabase;
    private final NetworkAccessApi networkAccess;
    private final NotificationApi notification;
    private final OAuthApi oAuth;
    private final OVSApi oVS;
    private final PanelApi panel;
    private final PostgresDatabaseApi postgresDatabase;
    private final PricingApi pricing;
    private final ProfileApi profile;
    private final PulseApi pulse;
    private final RecentResourcesApi recentResources;
    private final ResourceGovernanceApi resourceGovernance;
    private final ResourceGroupsApi resourceGroups;
    private final ResourceMetricsApi resourceMetrics;
    private final ResourceOperationsApi resourceOperations;
    private final SandboxApi sandbox;
    private final SearchApi search;
    private final ServiceBusApi serviceBus;
    private final SqlServerDatabaseApi sqlServerDatabase;
    private final StorageApi storage;
    private final StorageAccountApi storageAccount;
    private final StorageDataApi storageData;
    private final StorageObjectApi storageObject;
    private final StreamAnalyticsApi streamAnalytics;
    private final StreamPipelineApi streamPipeline;
    private final StreamingApi streaming;
    private final SubscriptionApi subscription;
    private final SupportApi support;
    private final SupportQueueApi supportQueue;
    private final UploadApi upload;
    private final VPNGatewayApi vPNGateway;
    private final VXLANApi vXLAN;
    private final VirtualMachineApi virtualMachine;
    private final VirtualNetworkApi virtualNetwork;
    private final VmConsoleApi vmConsole;
    private final VmNetworkApi vmNetwork;
    private final VmOperationsApi vmOperations;
    private final WebmailApi webmail;
    private final WidgetApi widget;
    private final YugabyteApi yugabyte;
    public Api(HiokClient client) {
        this.accessControl = new AccessControlApi(client);
        this.admin = new AdminApi(client);
        this.adminData = new AdminDataApi(client);
        this.adminDns = new AdminDnsApi(client);
        this.adminInfrastructure = new AdminInfrastructureApi(client);
        this.advisor = new AdvisorApi(client);
        this.analytics = new AnalyticsApi(client);
        this.apiManagement = new ApiManagementApi(client);
        this.assistant = new AssistantApi(client);
        this.bastion = new BastionApi(client);
        this.billingWebhook = new BillingWebhookApi(client);
        this.cache = new CacheApi(client);
        this.cards = new CardsApi(client);
        this.cloudShell = new CloudShellApi(client);
        this.cloudSubscription = new CloudSubscriptionApi(client);
        this.commonServices = new CommonServicesApi(client);
        this.communication = new CommunicationApi(client);
        this.containerApp = new ContainerAppApi(client);
        this.containerJobs = new ContainerJobsApi(client);
        this.containerRegistry = new ContainerRegistryApi(client);
        this.containers = new ContainersApi(client);
        this.costTracking = new CostTrackingApi(client);
        this.createResource = new CreateResourceApi(client);
        this.deployment = new DeploymentApi(client);
        this.dockerImages = new DockerImagesApi(client);
        this.downloads = new DownloadsApi(client);
        this.dps = new DpsApi(client);
        this.fx = new FxApi(client);
        this.groups = new GroupsApi(client);
        this.hierarchyView = new HierarchyViewApi(client);
        this.hiokCloudGroups = new HiokCloudGroupsApi(client);
        this.hiokCloudHierarchy = new HiokCloudHierarchyApi(client);
        this.hiokUsers = new HiokUsersApi(client);
        this.hybrid = new HybridApi(client);
        this.identity = new IdentityApi(client);
        this.infrastructure = new InfrastructureApi(client);
        this.ioTDeviceGateway = new IoTDeviceGatewayApi(client);
        this.ioTHub = new IoTHubApi(client);
        this.ioTHubDevice = new IoTHubDeviceApi(client);
        this.ioTHubDiagnostics = new IoTHubDiagnosticsApi(client);
        this.ioTHubManagement = new IoTHubManagementApi(client);
        this.ioTHubProtocol = new IoTHubProtocolApi(client);
        this.k9sConsole = new K9sConsoleApi(client);
        this.keyVault = new KeyVaultApi(client);
        this.kubernetes = new KubernetesApi(client);
        this.mailAdmin = new MailAdminApi(client);
        this.marketplace = new MarketplaceApi(client);
        this.metrics = new MetricsApi(client);
        this.mongo = new MongoApi(client);
        this.mySqlDatabase = new MySqlDatabaseApi(client);
        this.networkAccess = new NetworkAccessApi(client);
        this.notification = new NotificationApi(client);
        this.oAuth = new OAuthApi(client);
        this.oVS = new OVSApi(client);
        this.panel = new PanelApi(client);
        this.postgresDatabase = new PostgresDatabaseApi(client);
        this.pricing = new PricingApi(client);
        this.profile = new ProfileApi(client);
        this.pulse = new PulseApi(client);
        this.recentResources = new RecentResourcesApi(client);
        this.resourceGovernance = new ResourceGovernanceApi(client);
        this.resourceGroups = new ResourceGroupsApi(client);
        this.resourceMetrics = new ResourceMetricsApi(client);
        this.resourceOperations = new ResourceOperationsApi(client);
        this.sandbox = new SandboxApi(client);
        this.search = new SearchApi(client);
        this.serviceBus = new ServiceBusApi(client);
        this.sqlServerDatabase = new SqlServerDatabaseApi(client);
        this.storage = new StorageApi(client);
        this.storageAccount = new StorageAccountApi(client);
        this.storageData = new StorageDataApi(client);
        this.storageObject = new StorageObjectApi(client);
        this.streamAnalytics = new StreamAnalyticsApi(client);
        this.streamPipeline = new StreamPipelineApi(client);
        this.streaming = new StreamingApi(client);
        this.subscription = new SubscriptionApi(client);
        this.support = new SupportApi(client);
        this.supportQueue = new SupportQueueApi(client);
        this.upload = new UploadApi(client);
        this.vPNGateway = new VPNGatewayApi(client);
        this.vXLAN = new VXLANApi(client);
        this.virtualMachine = new VirtualMachineApi(client);
        this.virtualNetwork = new VirtualNetworkApi(client);
        this.vmConsole = new VmConsoleApi(client);
        this.vmNetwork = new VmNetworkApi(client);
        this.vmOperations = new VmOperationsApi(client);
        this.webmail = new WebmailApi(client);
        this.widget = new WidgetApi(client);
        this.yugabyte = new YugabyteApi(client);
    }
    public AccessControlApi accessControl() { return accessControl; }
    public AdminApi admin() { return admin; }
    public AdminDataApi adminData() { return adminData; }
    public AdminDnsApi adminDns() { return adminDns; }
    public AdminInfrastructureApi adminInfrastructure() { return adminInfrastructure; }
    public AdvisorApi advisor() { return advisor; }
    public AnalyticsApi analytics() { return analytics; }
    public ApiManagementApi apiManagement() { return apiManagement; }
    public AssistantApi assistant() { return assistant; }
    public BastionApi bastion() { return bastion; }
    public BillingWebhookApi billingWebhook() { return billingWebhook; }
    public CacheApi cache() { return cache; }
    public CardsApi cards() { return cards; }
    public CloudShellApi cloudShell() { return cloudShell; }
    public CloudSubscriptionApi cloudSubscription() { return cloudSubscription; }
    public CommonServicesApi commonServices() { return commonServices; }
    public CommunicationApi communication() { return communication; }
    public ContainerAppApi containerApp() { return containerApp; }
    public ContainerJobsApi containerJobs() { return containerJobs; }
    public ContainerRegistryApi containerRegistry() { return containerRegistry; }
    public ContainersApi containers() { return containers; }
    public CostTrackingApi costTracking() { return costTracking; }
    public CreateResourceApi createResource() { return createResource; }
    public DeploymentApi deployment() { return deployment; }
    public DockerImagesApi dockerImages() { return dockerImages; }
    public DownloadsApi downloads() { return downloads; }
    public DpsApi dps() { return dps; }
    public FxApi fx() { return fx; }
    public GroupsApi groups() { return groups; }
    public HierarchyViewApi hierarchyView() { return hierarchyView; }
    public HiokCloudGroupsApi hiokCloudGroups() { return hiokCloudGroups; }
    public HiokCloudHierarchyApi hiokCloudHierarchy() { return hiokCloudHierarchy; }
    public HiokUsersApi hiokUsers() { return hiokUsers; }
    public HybridApi hybrid() { return hybrid; }
    public IdentityApi identity() { return identity; }
    public InfrastructureApi infrastructure() { return infrastructure; }
    public IoTDeviceGatewayApi ioTDeviceGateway() { return ioTDeviceGateway; }
    public IoTHubApi ioTHub() { return ioTHub; }
    public IoTHubDeviceApi ioTHubDevice() { return ioTHubDevice; }
    public IoTHubDiagnosticsApi ioTHubDiagnostics() { return ioTHubDiagnostics; }
    public IoTHubManagementApi ioTHubManagement() { return ioTHubManagement; }
    public IoTHubProtocolApi ioTHubProtocol() { return ioTHubProtocol; }
    public K9sConsoleApi k9sConsole() { return k9sConsole; }
    public KeyVaultApi keyVault() { return keyVault; }
    public KubernetesApi kubernetes() { return kubernetes; }
    public MailAdminApi mailAdmin() { return mailAdmin; }
    public MarketplaceApi marketplace() { return marketplace; }
    public MetricsApi metrics() { return metrics; }
    public MongoApi mongo() { return mongo; }
    public MySqlDatabaseApi mySqlDatabase() { return mySqlDatabase; }
    public NetworkAccessApi networkAccess() { return networkAccess; }
    public NotificationApi notification() { return notification; }
    public OAuthApi oAuth() { return oAuth; }
    public OVSApi oVS() { return oVS; }
    public PanelApi panel() { return panel; }
    public PostgresDatabaseApi postgresDatabase() { return postgresDatabase; }
    public PricingApi pricing() { return pricing; }
    public ProfileApi profile() { return profile; }
    public PulseApi pulse() { return pulse; }
    public RecentResourcesApi recentResources() { return recentResources; }
    public ResourceGovernanceApi resourceGovernance() { return resourceGovernance; }
    public ResourceGroupsApi resourceGroups() { return resourceGroups; }
    public ResourceMetricsApi resourceMetrics() { return resourceMetrics; }
    public ResourceOperationsApi resourceOperations() { return resourceOperations; }
    public SandboxApi sandbox() { return sandbox; }
    public SearchApi search() { return search; }
    public ServiceBusApi serviceBus() { return serviceBus; }
    public SqlServerDatabaseApi sqlServerDatabase() { return sqlServerDatabase; }
    public StorageApi storage() { return storage; }
    public StorageAccountApi storageAccount() { return storageAccount; }
    public StorageDataApi storageData() { return storageData; }
    public StorageObjectApi storageObject() { return storageObject; }
    public StreamAnalyticsApi streamAnalytics() { return streamAnalytics; }
    public StreamPipelineApi streamPipeline() { return streamPipeline; }
    public StreamingApi streaming() { return streaming; }
    public SubscriptionApi subscription() { return subscription; }
    public SupportApi support() { return support; }
    public SupportQueueApi supportQueue() { return supportQueue; }
    public UploadApi upload() { return upload; }
    public VPNGatewayApi vPNGateway() { return vPNGateway; }
    public VXLANApi vXLAN() { return vXLAN; }
    public VirtualMachineApi virtualMachine() { return virtualMachine; }
    public VirtualNetworkApi virtualNetwork() { return virtualNetwork; }
    public VmConsoleApi vmConsole() { return vmConsole; }
    public VmNetworkApi vmNetwork() { return vmNetwork; }
    public VmOperationsApi vmOperations() { return vmOperations; }
    public WebmailApi webmail() { return webmail; }
    public WidgetApi widget() { return widget; }
    public YugabyteApi yugabyte() { return yugabyte; }
}
