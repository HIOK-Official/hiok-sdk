// Code generated from the HIOK API's OpenAPI document by hiok-sdk/generator/generate.py. DO NOT EDIT.

package hiok

import (
	"context"
	"encoding/json"
)

// Api holds every API operation, grouped as the API groups them: client.API().<Group>.<Operation>(ctx, ...).
type Api struct {
	AccessControl       *AccessControlApi
	Account             *AccountApi
	Admin               *AdminApi
	AdminData           *AdminDataApi
	AdminDns            *AdminDnsApi
	AdminInfrastructure *AdminInfrastructureApi
	Advisor             *AdvisorApi
	Analytics           *AnalyticsApi
	ApiManagement       *ApiManagementApi
	Assistant           *AssistantApi
	Bastion             *BastionApi
	BillingWebhook      *BillingWebhookApi
	Cache               *CacheApi
	Cards               *CardsApi
	CloudShell          *CloudShellApi
	CloudSubscription   *CloudSubscriptionApi
	CommonServices      *CommonServicesApi
	Communication       *CommunicationApi
	ContainerApp        *ContainerAppApi
	ContainerJobs       *ContainerJobsApi
	ContainerRegistry   *ContainerRegistryApi
	Containers          *ContainersApi
	CostTracking        *CostTrackingApi
	CreateResource      *CreateResourceApi
	Deployment          *DeploymentApi
	DockerImages        *DockerImagesApi
	Downloads           *DownloadsApi
	Dps                 *DpsApi
	Fx                  *FxApi
	Groups              *GroupsApi
	HierarchyView       *HierarchyViewApi
	HiokCloudGroups     *HiokCloudGroupsApi
	HiokCloudHierarchy  *HiokCloudHierarchyApi
	HiokId              *HiokIdApi
	HiokUsers           *HiokUsersApi
	Hybrid              *HybridApi
	Identity            *IdentityApi
	Infrastructure      *InfrastructureApi
	Integrations        *IntegrationsApi
	IoTDeviceGateway    *IoTDeviceGatewayApi
	IoTHub              *IoTHubApi
	IoTHubDevice        *IoTHubDeviceApi
	IoTHubDiagnostics   *IoTHubDiagnosticsApi
	IoTHubManagement    *IoTHubManagementApi
	IoTHubProtocol      *IoTHubProtocolApi
	K9sConsole          *K9sConsoleApi
	KeyVault            *KeyVaultApi
	Kubernetes          *KubernetesApi
	MailAdmin           *MailAdminApi
	Marketplace         *MarketplaceApi
	Metrics             *MetricsApi
	Mongo               *MongoApi
	MySqlDatabase       *MySqlDatabaseApi
	NetworkAccess       *NetworkAccessApi
	Notification        *NotificationApi
	OAuth               *OAuthApi
	OVS                 *OVSApi
	Oidc                *OidcApi
	Panel               *PanelApi
	PostgresDatabase    *PostgresDatabaseApi
	Pricing             *PricingApi
	Profile             *ProfileApi
	Pulse               *PulseApi
	RecentResources     *RecentResourcesApi
	ResourceGovernance  *ResourceGovernanceApi
	ResourceGroups      *ResourceGroupsApi
	ResourceMetrics     *ResourceMetricsApi
	ResourceOperations  *ResourceOperationsApi
	Sandbox             *SandboxApi
	Search              *SearchApi
	ServiceBus          *ServiceBusApi
	Slack               *SlackApi
	SqlServerDatabase   *SqlServerDatabaseApi
	Storage             *StorageApi
	StorageAccount      *StorageAccountApi
	StorageData         *StorageDataApi
	StorageObject       *StorageObjectApi
	StreamAnalytics     *StreamAnalyticsApi
	StreamPipeline      *StreamPipelineApi
	Streaming           *StreamingApi
	Subscription        *SubscriptionApi
	Support             *SupportApi
	SupportQueue        *SupportQueueApi
	Upload              *UploadApi
	VPNGateway          *VPNGatewayApi
	VXLAN               *VXLANApi
	VirtualMachine      *VirtualMachineApi
	VirtualNetwork      *VirtualNetworkApi
	VmConsole           *VmConsoleApi
	VmNetwork           *VmNetworkApi
	VmOperations        *VmOperationsApi
	Webmail             *WebmailApi
	Widget              *WidgetApi
	Yugabyte            *YugabyteApi
}

func newAPI(c *Client) *Api {
	return &Api{
		AccessControl:       &AccessControlApi{c: c},
		Account:             &AccountApi{c: c},
		Admin:               &AdminApi{c: c},
		AdminData:           &AdminDataApi{c: c},
		AdminDns:            &AdminDnsApi{c: c},
		AdminInfrastructure: &AdminInfrastructureApi{c: c},
		Advisor:             &AdvisorApi{c: c},
		Analytics:           &AnalyticsApi{c: c},
		ApiManagement:       &ApiManagementApi{c: c},
		Assistant:           &AssistantApi{c: c},
		Bastion:             &BastionApi{c: c},
		BillingWebhook:      &BillingWebhookApi{c: c},
		Cache:               &CacheApi{c: c},
		Cards:               &CardsApi{c: c},
		CloudShell:          &CloudShellApi{c: c},
		CloudSubscription:   &CloudSubscriptionApi{c: c},
		CommonServices:      &CommonServicesApi{c: c},
		Communication:       &CommunicationApi{c: c},
		ContainerApp:        &ContainerAppApi{c: c},
		ContainerJobs:       &ContainerJobsApi{c: c},
		ContainerRegistry:   &ContainerRegistryApi{c: c},
		Containers:          &ContainersApi{c: c},
		CostTracking:        &CostTrackingApi{c: c},
		CreateResource:      &CreateResourceApi{c: c},
		Deployment:          &DeploymentApi{c: c},
		DockerImages:        &DockerImagesApi{c: c},
		Downloads:           &DownloadsApi{c: c},
		Dps:                 &DpsApi{c: c},
		Fx:                  &FxApi{c: c},
		Groups:              &GroupsApi{c: c},
		HierarchyView:       &HierarchyViewApi{c: c},
		HiokCloudGroups:     &HiokCloudGroupsApi{c: c},
		HiokCloudHierarchy:  &HiokCloudHierarchyApi{c: c},
		HiokId:              &HiokIdApi{c: c},
		HiokUsers:           &HiokUsersApi{c: c},
		Hybrid:              &HybridApi{c: c},
		Identity:            &IdentityApi{c: c},
		Infrastructure:      &InfrastructureApi{c: c},
		Integrations:        &IntegrationsApi{c: c},
		IoTDeviceGateway:    &IoTDeviceGatewayApi{c: c},
		IoTHub:              &IoTHubApi{c: c},
		IoTHubDevice:        &IoTHubDeviceApi{c: c},
		IoTHubDiagnostics:   &IoTHubDiagnosticsApi{c: c},
		IoTHubManagement:    &IoTHubManagementApi{c: c},
		IoTHubProtocol:      &IoTHubProtocolApi{c: c},
		K9sConsole:          &K9sConsoleApi{c: c},
		KeyVault:            &KeyVaultApi{c: c},
		Kubernetes:          &KubernetesApi{c: c},
		MailAdmin:           &MailAdminApi{c: c},
		Marketplace:         &MarketplaceApi{c: c},
		Metrics:             &MetricsApi{c: c},
		Mongo:               &MongoApi{c: c},
		MySqlDatabase:       &MySqlDatabaseApi{c: c},
		NetworkAccess:       &NetworkAccessApi{c: c},
		Notification:        &NotificationApi{c: c},
		OAuth:               &OAuthApi{c: c},
		OVS:                 &OVSApi{c: c},
		Oidc:                &OidcApi{c: c},
		Panel:               &PanelApi{c: c},
		PostgresDatabase:    &PostgresDatabaseApi{c: c},
		Pricing:             &PricingApi{c: c},
		Profile:             &ProfileApi{c: c},
		Pulse:               &PulseApi{c: c},
		RecentResources:     &RecentResourcesApi{c: c},
		ResourceGovernance:  &ResourceGovernanceApi{c: c},
		ResourceGroups:      &ResourceGroupsApi{c: c},
		ResourceMetrics:     &ResourceMetricsApi{c: c},
		ResourceOperations:  &ResourceOperationsApi{c: c},
		Sandbox:             &SandboxApi{c: c},
		Search:              &SearchApi{c: c},
		ServiceBus:          &ServiceBusApi{c: c},
		Slack:               &SlackApi{c: c},
		SqlServerDatabase:   &SqlServerDatabaseApi{c: c},
		Storage:             &StorageApi{c: c},
		StorageAccount:      &StorageAccountApi{c: c},
		StorageData:         &StorageDataApi{c: c},
		StorageObject:       &StorageObjectApi{c: c},
		StreamAnalytics:     &StreamAnalyticsApi{c: c},
		StreamPipeline:      &StreamPipelineApi{c: c},
		Streaming:           &StreamingApi{c: c},
		Subscription:        &SubscriptionApi{c: c},
		Support:             &SupportApi{c: c},
		SupportQueue:        &SupportQueueApi{c: c},
		Upload:              &UploadApi{c: c},
		VPNGateway:          &VPNGatewayApi{c: c},
		VXLAN:               &VXLANApi{c: c},
		VirtualMachine:      &VirtualMachineApi{c: c},
		VirtualNetwork:      &VirtualNetworkApi{c: c},
		VmConsole:           &VmConsoleApi{c: c},
		VmNetwork:           &VmNetworkApi{c: c},
		VmOperations:        &VmOperationsApi{c: c},
		Webmail:             &WebmailApi{c: c},
		Widget:              &WidgetApi{c: c},
		Yugabyte:            &YugabyteApi{c: c},
	}
}

// AccessControlApi holds the AccessControl operations.
type AccessControlApi struct{ c *Client }

// AddRoleAssignment — Add role assignment. [POST /api/access-control/{resourceType}/{resourceId}/role-assignments].
func (a *AccessControlApi) AddRoleAssignment(ctx context.Context, resourceType string, resourceId string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/access-control/"+segment(resourceType, false)+"/"+segment(resourceId, false)+"/role-assignments", body, nil)
}

// CheckAccess — Check access. [GET /api/access-control/{resourceType}/{resourceId}/check-access]. Query keys: principalEmail.
func (a *AccessControlApi) CheckAccess(ctx context.Context, resourceType string, resourceId string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/access-control/"+segment(resourceType, false)+"/"+segment(resourceId, false)+"/check-access", nil, query)
}

// ListAllAssignments — List all assignments. [GET /api/access-control/assignments]. Query keys: principalEmail, roleId.
func (a *AccessControlApi) ListAllAssignments(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/access-control/assignments", nil, query)
}

// ListPrincipals — List principals. [GET /api/access-control/principals]. Query keys: q.
func (a *AccessControlApi) ListPrincipals(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/access-control/principals", nil, query)
}

// ListRoleAssignments — List role assignments. [GET /api/access-control/{resourceType}/{resourceId}/role-assignments]. Query keys: includeInherited.
func (a *AccessControlApi) ListRoleAssignments(ctx context.Context, resourceType string, resourceId string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/access-control/"+segment(resourceType, false)+"/"+segment(resourceId, false)+"/role-assignments", nil, query)
}

// ListRoles — List roles. [GET /api/access-control/roles]. Query keys: category.
func (a *AccessControlApi) ListRoles(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/access-control/roles", nil, query)
}

// RegisterScope — Register scope. [PUT /api/access-control/{resourceType}/{resourceId}/scope].
func (a *AccessControlApi) RegisterScope(ctx context.Context, resourceType string, resourceId string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "PUT", "/api/access-control/"+segment(resourceType, false)+"/"+segment(resourceId, false)+"/scope", body, nil)
}

// RemoveAssignment — Remove assignment. [DELETE /api/access-control/assignments/{assignmentId}].
func (a *AccessControlApi) RemoveAssignment(ctx context.Context, assignmentId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/access-control/assignments/"+segment(assignmentId, false), nil, nil)
}

// RemoveRoleAssignment — Remove role assignment. [DELETE /api/access-control/{resourceType}/{resourceId}/role-assignments/{assignmentId}].
func (a *AccessControlApi) RemoveRoleAssignment(ctx context.Context, resourceType string, resourceId string, assignmentId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/access-control/"+segment(resourceType, false)+"/"+segment(resourceId, false)+"/role-assignments/"+segment(assignmentId, false), nil, nil)
}

// ScopeChain — Scope chain. [GET /api/access-control/{resourceType}/{resourceId}/scope-chain].
func (a *AccessControlApi) ScopeChain(ctx context.Context, resourceType string, resourceId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/access-control/"+segment(resourceType, false)+"/"+segment(resourceId, false)+"/scope-chain", nil, nil)
}

// AccountApi holds the Account operations.
type AccountApi struct{ c *Client }

// ApiKeys — Api keys. [GET /api/account/api-keys].
func (a *AccountApi) ApiKeys(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/account/api-keys", nil, nil)
}

// ChangePassword — Change password. [POST /api/account/password].
func (a *AccountApi) ChangePassword(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/account/password", body, nil)
}

// CreateApiKey — Create api key. [POST /api/account/api-keys].
func (a *AccountApi) CreateApiKey(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/account/api-keys", body, nil)
}

// DeleteAccount — Delete account. [POST /api/account/delete].
func (a *AccountApi) DeleteAccount(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/account/delete", body, nil)
}

// DeleteTenant — Delete tenant. [POST /api/account/tenants/delete].
func (a *AccountApi) DeleteTenant(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/account/tenants/delete", body, nil)
}

// DeletionPlan — Deletion plan. [GET /api/account/deletion].
func (a *AccountApi) DeletionPlan(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/account/deletion", nil, nil)
}

// DeletionStatus — Deletion status. [GET /api/account/delete/status].
func (a *AccountApi) DeletionStatus(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/account/delete/status", nil, nil)
}

// Export — Export. [GET /api/account/export]. Query keys: format.
func (a *AccountApi) Export(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/account/export", nil, query)
}

// GetPreferences — Get preferences. [GET /api/account/preferences].
func (a *AccountApi) GetPreferences(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/account/preferences", nil, nil)
}

// RevokeApiKey — Revoke api key. [DELETE /api/account/api-keys/{id}].
func (a *AccountApi) RevokeApiKey(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/account/api-keys/"+segment(id_, false), nil, nil)
}

// SavePreferences — Save preferences. [PUT /api/account/preferences].
func (a *AccountApi) SavePreferences(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "PUT", "/api/account/preferences", body, nil)
}

// TenantDeletionPlan — Tenant deletion plan. [GET /api/account/tenants/deletion]. Query keys: account.
func (a *AccountApi) TenantDeletionPlan(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/account/tenants/deletion", nil, query)
}

// TenantDeletionStatus — Tenant deletion status. [GET /api/account/tenants/delete/status]. Query keys: account.
func (a *AccountApi) TenantDeletionStatus(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/account/tenants/delete/status", nil, query)
}

// AdminApi holds the Admin operations.
type AdminApi struct{ c *Client }

// Grant — Grant. [POST /api/Admin/access].
func (a *AdminApi) Grant(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Admin/access", body, nil)
}

// ListGrants — List grants. [GET /api/Admin/access].
func (a *AdminApi) ListGrants(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Admin/access", nil, nil)
}

// Me — Me. [GET /api/Admin/me].
func (a *AdminApi) Me(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Admin/me", nil, nil)
}

// Revoke — Revoke. [DELETE /api/Admin/access/{id}].
func (a *AdminApi) Revoke(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/Admin/access/"+segment(id_, false), nil, nil)
}

// AdminDataApi holds the AdminData operations.
type AdminDataApi struct{ c *Client }

// Resources — Resources. [GET /api/admin/resources]. Query keys: search, type.
func (a *AdminDataApi) Resources(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/admin/resources", nil, query)
}

// Subscriptions — Subscriptions. [GET /api/admin/subscriptions]. Query keys: search.
func (a *AdminDataApi) Subscriptions(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/admin/subscriptions", nil, query)
}

// TableRows — Table rows. [GET /api/admin/database/{table}]. Query keys: search, limit.
func (a *AdminDataApi) TableRows(ctx context.Context, table string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/admin/database/"+segment(table, false), nil, query)
}

// Tables — Tables. [GET /api/admin/database/tables].
func (a *AdminDataApi) Tables(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/admin/database/tables", nil, nil)
}

// AdminDnsApi holds the AdminDns operations.
type AdminDnsApi struct{ c *Client }

// Delete — Delete. [DELETE /api/admin/dns/records/{id}].
func (a *AdminDnsApi) Delete(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/admin/dns/records/"+segment(id_, false), nil, nil)
}

// MailHealth — Mail health. [GET /api/admin/dns/mail-health].
func (a *AdminDnsApi) MailHealth(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/admin/dns/mail-health", nil, nil)
}

// Records — Records. [GET /api/admin/dns/records]. Query keys: q.
func (a *AdminDnsApi) Records(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/admin/dns/records", nil, query)
}

// Upsert — Upsert. [POST /api/admin/dns/records].
func (a *AdminDnsApi) Upsert(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/admin/dns/records", body, nil)
}

// AdminInfrastructureApi holds the AdminInfrastructure operations.
type AdminInfrastructureApi struct{ c *Client }

// Bridges — Bridges. [GET /api/admin/infrastructure/bridges]. Query keys: region.
func (a *AdminInfrastructureApi) Bridges(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/admin/infrastructure/bridges", nil, query)
}

// Containers — Containers. [GET /api/admin/infrastructure/containers]. Query keys: region.
func (a *AdminInfrastructureApi) Containers(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/admin/infrastructure/containers", nil, query)
}

// DeleteBridge — Delete bridge. [DELETE /api/admin/infrastructure/bridges/{name}]. Query keys: region.
func (a *AdminInfrastructureApi) DeleteBridge(ctx context.Context, name string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/admin/infrastructure/bridges/"+segment(name, false), nil, query)
}

// DeleteContainer — Delete container. [DELETE /api/admin/infrastructure/containers/{id}]. Query keys: region.
func (a *AdminInfrastructureApi) DeleteContainer(ctx context.Context, id_ string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/admin/infrastructure/containers/"+segment(id_, false), nil, query)
}

// DeleteImage — Delete image. [DELETE /api/admin/infrastructure/images/{id}]. Query keys: region.
func (a *AdminInfrastructureApi) DeleteImage(ctx context.Context, id_ string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/admin/infrastructure/images/"+segment(id_, false), nil, query)
}

// DeleteNetwork — Delete network. [DELETE /api/admin/infrastructure/networks/{id}]. Query keys: region.
func (a *AdminInfrastructureApi) DeleteNetwork(ctx context.Context, id_ string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/admin/infrastructure/networks/"+segment(id_, false), nil, query)
}

// DeleteVm — Delete vm. [DELETE /api/admin/infrastructure/vms/{name}]. Query keys: region.
func (a *AdminInfrastructureApi) DeleteVm(ctx context.Context, name string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/admin/infrastructure/vms/"+segment(name, false), nil, query)
}

// DeleteVolume — Delete volume. [DELETE /api/admin/infrastructure/volumes/{name}]. Query keys: region.
func (a *AdminInfrastructureApi) DeleteVolume(ctx context.Context, name string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/admin/infrastructure/volumes/"+segment(name, false), nil, query)
}

// DnsJanitor — Dns janitor. [POST /api/admin/infrastructure/dns-janitor]. Query keys: dryRun.
func (a *AdminInfrastructureApi) DnsJanitor(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/admin/infrastructure/dns-janitor", nil, query)
}

// Firewall — Firewall. [GET /api/admin/infrastructure/firewall]. Query keys: region, chain.
func (a *AdminInfrastructureApi) Firewall(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/admin/infrastructure/firewall", nil, query)
}

// Flows — Flows. [GET /api/admin/infrastructure/flows]. Query keys: region, bridge.
func (a *AdminInfrastructureApi) Flows(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/admin/infrastructure/flows", nil, query)
}

// Images — Images. [GET /api/admin/infrastructure/images]. Query keys: region.
func (a *AdminInfrastructureApi) Images(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/admin/infrastructure/images", nil, query)
}

// Metrics — Metrics. [GET /api/admin/infrastructure/metrics]. Query keys: region.
func (a *AdminInfrastructureApi) Metrics(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/admin/infrastructure/metrics", nil, query)
}

// Networks — Networks. [GET /api/admin/infrastructure/networks]. Query keys: region.
func (a *AdminInfrastructureApi) Networks(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/admin/infrastructure/networks", nil, query)
}

// VirtualMachines — Virtual machines. [GET /api/admin/infrastructure/vms]. Query keys: region.
func (a *AdminInfrastructureApi) VirtualMachines(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/admin/infrastructure/vms", nil, query)
}

// Volumes — Volumes. [GET /api/admin/infrastructure/volumes]. Query keys: region.
func (a *AdminInfrastructureApi) Volumes(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/admin/infrastructure/volumes", nil, query)
}

// AdvisorApi holds the Advisor operations.
type AdvisorApi struct{ c *Client }

// CreateTasks — Create tasks. [POST /api/advisor/tasks].
func (a *AdvisorApi) CreateTasks(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/advisor/tasks", body, nil)
}

// DeleteTask — Delete task. [DELETE /api/advisor/tasks/{id}].
func (a *AdvisorApi) DeleteTask(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/advisor/tasks/"+segment(id_, false), nil, nil)
}

// Report — Report. [GET /api/advisor/report]. Query keys: subscriptionId.
func (a *AdvisorApi) Report(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/advisor/report", nil, query)
}

// Restore — Restore. [DELETE /api/advisor/suppressions/{id}].
func (a *AdvisorApi) Restore(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/advisor/suppressions/"+segment(id_, false), nil, nil)
}

// Suppress — Suppress. [POST /api/advisor/suppressions].
func (a *AdvisorApi) Suppress(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/advisor/suppressions", body, nil)
}

// Tasks — Tasks. [GET /api/advisor/tasks].
func (a *AdvisorApi) Tasks(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/advisor/tasks", nil, nil)
}

// UpdateTask — Update task. [PATCH /api/advisor/tasks/{id}].
func (a *AdvisorApi) UpdateTask(ctx context.Context, id_ string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "PATCH", "/api/advisor/tasks/"+segment(id_, false), body, nil)
}

// AnalyticsApi holds the Analytics operations.
type AnalyticsApi struct{ c *Client }

// AttachVNet — Attach vnet. [POST /api/Analytics/{id}/vnet/attach].
func (a *AnalyticsApi) AttachVNet(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Analytics/"+segment(id_, false)+"/vnet/attach", nil, nil)
}

// Columns — Columns. [GET /api/Analytics/{id}/tables/{database}/{table}/columns].
func (a *AnalyticsApi) Columns(ctx context.Context, id_ string, database string, table string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Analytics/"+segment(id_, false)+"/tables/"+segment(database, false)+"/"+segment(table, false)+"/columns", nil, nil)
}

// Connection — Connection. [GET /api/Analytics/{id}/connection].
func (a *AnalyticsApi) Connection(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Analytics/"+segment(id_, false)+"/connection", nil, nil)
}

// Create — Create. [POST /api/Analytics].
func (a *AnalyticsApi) Create(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Analytics", body, nil)
}

// Delete — Delete. [DELETE /api/Analytics/{id}].
func (a *AnalyticsApi) Delete(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/Analytics/"+segment(id_, false), nil, nil)
}

// DetachVNet — Detach vnet. [POST /api/Analytics/{id}/vnet/detach].
func (a *AnalyticsApi) DetachVNet(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Analytics/"+segment(id_, false)+"/vnet/detach", nil, nil)
}

// Get — Get. [GET /api/Analytics/{id}].
func (a *AnalyticsApi) Get(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Analytics/"+segment(id_, false), nil, nil)
}

// List — List. [GET /api/Analytics].
func (a *AnalyticsApi) List(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Analytics", nil, nil)
}

// Query — Query. [POST /api/Analytics/{id}/query].
func (a *AnalyticsApi) Query(ctx context.Context, id_ string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Analytics/"+segment(id_, false)+"/query", body, nil)
}

// Start — Start. [POST /api/Analytics/{id}/start].
func (a *AnalyticsApi) Start(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Analytics/"+segment(id_, false)+"/start", nil, nil)
}

// Stop — Stop. [POST /api/Analytics/{id}/stop].
func (a *AnalyticsApi) Stop(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Analytics/"+segment(id_, false)+"/stop", nil, nil)
}

// Tables — Tables. [GET /api/Analytics/{id}/tables].
func (a *AnalyticsApi) Tables(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Analytics/"+segment(id_, false)+"/tables", nil, nil)
}

// ApiManagementApi holds the ApiManagement operations.
type ApiManagementApi struct{ c *Client }

// Analytics — Analytics. [GET /api/apim/apis/{apiId}/analytics]. Query keys: hours.
func (a *ApiManagementApi) Analytics(ctx context.Context, apiId string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/apim/apis/"+segment(apiId, false)+"/analytics", nil, query)
}

// CreateApi — Create api. [POST /api/apim/apis].
func (a *ApiManagementApi) CreateApi(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/apim/apis", body, nil)
}

// CreateOperation — Create operation. [POST /api/apim/apis/{apiId}/operations].
func (a *ApiManagementApi) CreateOperation(ctx context.Context, apiId string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/apim/apis/"+segment(apiId, false)+"/operations", body, nil)
}

// CreatePolicy — Create policy. [POST /api/apim/apis/{apiId}/policies].
func (a *ApiManagementApi) CreatePolicy(ctx context.Context, apiId string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/apim/apis/"+segment(apiId, false)+"/policies", body, nil)
}

// CreateProduct — Create product. [POST /api/apim/products].
func (a *ApiManagementApi) CreateProduct(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/apim/products", body, nil)
}

// CreateSub — Create sub. [POST /api/apim/subscriptions].
func (a *ApiManagementApi) CreateSub(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/apim/subscriptions", body, nil)
}

// DeleteApi — Delete api. [DELETE /api/apim/apis/{id}].
func (a *ApiManagementApi) DeleteApi(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/apim/apis/"+segment(id_, false), nil, nil)
}

// DeleteOperation — Delete operation. [DELETE /api/apim/operations/{id}].
func (a *ApiManagementApi) DeleteOperation(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/apim/operations/"+segment(id_, false), nil, nil)
}

// DeletePolicy — Delete policy. [DELETE /api/apim/policies/{id}].
func (a *ApiManagementApi) DeletePolicy(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/apim/policies/"+segment(id_, false), nil, nil)
}

// DeleteProduct — Delete product. [DELETE /api/apim/products/{id}].
func (a *ApiManagementApi) DeleteProduct(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/apim/products/"+segment(id_, false), nil, nil)
}

// DeleteSub — Delete sub. [DELETE /api/apim/subscriptions/{id}].
func (a *ApiManagementApi) DeleteSub(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/apim/subscriptions/"+segment(id_, false), nil, nil)
}

// Gateway — Gateway. [GET /api/apim/gateway/{apiPath}/{rest}].
func (a *ApiManagementApi) Gateway(ctx context.Context, apiPath string, rest string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/apim/gateway/"+segment(apiPath, false)+"/"+segment(rest, false), nil, nil)
}

// GatewayDelete — Gateway delete. [DELETE /api/apim/gateway/{apiPath}/{rest}].
func (a *ApiManagementApi) GatewayDelete(ctx context.Context, apiPath string, rest string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/apim/gateway/"+segment(apiPath, false)+"/"+segment(rest, false), nil, nil)
}

// GatewayPost — Gateway post. [POST /api/apim/gateway/{apiPath}/{rest}].
func (a *ApiManagementApi) GatewayPost(ctx context.Context, apiPath string, rest string) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/apim/gateway/"+segment(apiPath, false)+"/"+segment(rest, false), nil, nil)
}

// GatewayPut — Gateway put. [PUT /api/apim/gateway/{apiPath}/{rest}].
func (a *ApiManagementApi) GatewayPut(ctx context.Context, apiPath string, rest string) (json.RawMessage, error) {
	return a.c.Call(ctx, "PUT", "/api/apim/gateway/"+segment(apiPath, false)+"/"+segment(rest, false), nil, nil)
}

// ListApis — List apis. [GET /api/apim/apis].
func (a *ApiManagementApi) ListApis(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/apim/apis", nil, nil)
}

// ListOperations — List operations. [GET /api/apim/apis/{apiId}/operations].
func (a *ApiManagementApi) ListOperations(ctx context.Context, apiId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/apim/apis/"+segment(apiId, false)+"/operations", nil, nil)
}

// ListPolicies — List policies. [GET /api/apim/apis/{apiId}/policies].
func (a *ApiManagementApi) ListPolicies(ctx context.Context, apiId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/apim/apis/"+segment(apiId, false)+"/policies", nil, nil)
}

// ListProducts — List products. [GET /api/apim/products].
func (a *ApiManagementApi) ListProducts(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/apim/products", nil, nil)
}

// ListSubs — List subs. [GET /api/apim/subscriptions].
func (a *ApiManagementApi) ListSubs(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/apim/subscriptions", nil, nil)
}

// RegenSubKey — Regen sub key. [POST /api/apim/subscriptions/{id}/regenerate-key]. Query keys: which.
func (a *ApiManagementApi) RegenSubKey(ctx context.Context, id_ string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/apim/subscriptions/"+segment(id_, false)+"/regenerate-key", nil, query)
}

// UpdateOperation — Update operation. [PUT /api/apim/operations/{id}].
func (a *ApiManagementApi) UpdateOperation(ctx context.Context, id_ string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "PUT", "/api/apim/operations/"+segment(id_, false), body, nil)
}

// AssistantApi holds the Assistant operations.
type AssistantApi struct{ c *Client }

// Act — Act. [POST /api/assistant/act].
func (a *AssistantApi) Act(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/assistant/act", body, nil)
}

// Ask — Ask. [POST /api/assistant/ask].
func (a *AssistantApi) Ask(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/assistant/ask", body, nil)
}

// Findings — Findings. [GET /api/assistant/findings].
func (a *AssistantApi) Findings(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/assistant/findings", nil, nil)
}

// Stream — Stream. [POST /api/assistant/stream].
func (a *AssistantApi) Stream(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/assistant/stream", nil, nil)
}

// BastionApi holds the Bastion operations.
type BastionApi struct{ c *Client }

// Create — Create. [POST /api/Bastion].
func (a *BastionApi) Create(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Bastion", body, nil)
}

// Delete — Delete. [DELETE /api/Bastion/{id}].
func (a *BastionApi) Delete(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/Bastion/"+segment(id_, false), nil, nil)
}

// EndSession — End session. [DELETE /api/Bastion/{id}/sessions/{sessionId}].
func (a *BastionApi) EndSession(ctx context.Context, id_ string, sessionId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/Bastion/"+segment(id_, false)+"/sessions/"+segment(sessionId, false), nil, nil)
}

// Get — Get. [GET /api/Bastion/{id}].
func (a *BastionApi) Get(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Bastion/"+segment(id_, false), nil, nil)
}

// List — List. [GET /api/Bastion].
func (a *BastionApi) List(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Bastion", nil, nil)
}

// ListSessions — List sessions. [GET /api/Bastion/{id}/sessions]. Query keys: limit.
func (a *BastionApi) ListSessions(ctx context.Context, id_ string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Bastion/"+segment(id_, false)+"/sessions", nil, query)
}

// Refresh — Refresh. [POST /api/Bastion/{id}/refresh].
func (a *BastionApi) Refresh(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Bastion/"+segment(id_, false)+"/refresh", nil, nil)
}

// StartSession — Start session. [POST /api/Bastion/{id}/sessions].
func (a *BastionApi) StartSession(ctx context.Context, id_ string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Bastion/"+segment(id_, false)+"/sessions", body, nil)
}

// BillingWebhookApi holds the BillingWebhook operations.
type BillingWebhookApi struct{ c *Client }

// Receive — Receive. [POST /api/billing/webhook/{provider}].
func (a *BillingWebhookApi) Receive(ctx context.Context, provider string) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/billing/webhook/"+segment(provider, false), nil, nil)
}

// CacheApi holds the Cache operations.
type CacheApi struct{ c *Client }

// AddRegion — Add region. [POST /api/Cache/{id}/regions].
func (a *CacheApi) AddRegion(ctx context.Context, id_ string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Cache/"+segment(id_, false)+"/regions", body, nil)
}

// Command — Command. [POST /api/Cache/{id}/command].
func (a *CacheApi) Command(ctx context.Context, id_ string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Cache/"+segment(id_, false)+"/command", body, nil)
}

// Create — Create. [POST /api/Cache].
func (a *CacheApi) Create(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Cache", body, nil)
}

// Delete — Delete. [DELETE /api/Cache/{id}].
func (a *CacheApi) Delete(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/Cache/"+segment(id_, false), nil, nil)
}

// Get — Get. [GET /api/Cache/{id}].
func (a *CacheApi) Get(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Cache/"+segment(id_, false), nil, nil)
}

// Keys — Keys. [GET /api/Cache/{id}/keys].
func (a *CacheApi) Keys(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Cache/"+segment(id_, false)+"/keys", nil, nil)
}

// List — List. [GET /api/Cache].
func (a *CacheApi) List(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Cache", nil, nil)
}

// Logs — Logs. [GET /api/Cache/{id}/logs]. Query keys: region, tail.
func (a *CacheApi) Logs(ctx context.Context, id_ string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Cache/"+segment(id_, false)+"/logs", nil, query)
}

// Metrics — Metrics. [GET /api/Cache/{id}/metrics]. Query keys: hours, region.
func (a *CacheApi) Metrics(ctx context.Context, id_ string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Cache/"+segment(id_, false)+"/metrics", nil, query)
}

// RemoveRegion — Remove region. [DELETE /api/Cache/{id}/regions/{region}].
func (a *CacheApi) RemoveRegion(ctx context.Context, id_ string, region string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/Cache/"+segment(id_, false)+"/regions/"+segment(region, false), nil, nil)
}

// Rotate — Rotate. [POST /api/Cache/{id}/keys/rotate].
func (a *CacheApi) Rotate(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Cache/"+segment(id_, false)+"/keys/rotate", nil, nil)
}

// Stats — Stats. [GET /api/Cache/{id}/stats]. Query keys: region.
func (a *CacheApi) Stats(ctx context.Context, id_ string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Cache/"+segment(id_, false)+"/stats", nil, query)
}

// CardsApi holds the Cards operations.
type CardsApi struct{ c *Client }

// Complete — Complete. [POST /api/billing/cards/complete].
func (a *CardsApi) Complete(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/billing/cards/complete", body, nil)
}

// List — List. [GET /api/billing/cards].
func (a *CardsApi) List(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/billing/cards", nil, nil)
}

// Providers — Providers. [GET /api/billing/cards/providers].
func (a *CardsApi) Providers(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/billing/cards/providers", nil, nil)
}

// Remove — Remove. [DELETE /api/billing/cards/{id}].
func (a *CardsApi) Remove(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/billing/cards/"+segment(id_, false), nil, nil)
}

// Setup — Setup. [POST /api/billing/cards/setup].
func (a *CardsApi) Setup(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/billing/cards/setup", body, nil)
}

// CloudShellApi holds the CloudShell operations.
type CloudShellApi struct{ c *Client }

// End — End. [DELETE /api/cloudshell/session].
func (a *CloudShellApi) End(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/cloudshell/session", nil, nil)
}

// Session — Session. [GET /api/cloudshell/session].
func (a *CloudShellApi) Session(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/cloudshell/session", nil, nil)
}

// Status — Status. [GET /api/cloudshell/status].
func (a *CloudShellApi) Status(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/cloudshell/status", nil, nil)
}

// CloudSubscriptionApi holds the CloudSubscription operations.
type CloudSubscriptionApi struct{ c *Client }

// AddPayment — Add payment. [POST /api/cloudsubscription/payment-methods].
func (a *CloudSubscriptionApi) AddPayment(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/cloudsubscription/payment-methods", body, nil)
}

// Create — Create. [POST /api/cloudsubscription].
func (a *CloudSubscriptionApi) Create(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/cloudsubscription", body, nil)
}

// Delete — Delete. [DELETE /api/cloudsubscription/{id}].
func (a *CloudSubscriptionApi) Delete(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/cloudsubscription/"+segment(id_, false), nil, nil)
}

// List — List. [GET /api/cloudsubscription].
func (a *CloudSubscriptionApi) List(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/cloudsubscription", nil, nil)
}

// PaymentMethods — Payment methods. [GET /api/cloudsubscription/payment-methods].
func (a *CloudSubscriptionApi) PaymentMethods(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/cloudsubscription/payment-methods", nil, nil)
}

// CommonServicesApi holds the CommonServices operations.
type CommonServicesApi struct{ c *Client }

// GetRandomString — Get random string. [GET /api/CommonServices/randomstring]. Query keys: length.
func (a *CommonServicesApi) GetRandomString(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/CommonServices/randomstring", nil, query)
}

// CommunicationApi holds the Communication operations.
type CommunicationApi struct{ c *Client }

// AddDomain — Add domain. [POST /api/Communication/services/{id}/domains].
func (a *CommunicationApi) AddDomain(ctx context.Context, id_ string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Communication/services/"+segment(id_, false)+"/domains", body, nil)
}

// AddSender — Add sender. [POST /api/Communication/services/{id}/domains/{domainId}/senders].
func (a *CommunicationApi) AddSender(ctx context.Context, id_ string, domainId string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Communication/services/"+segment(id_, false)+"/domains/"+segment(domainId, false)+"/senders", body, nil)
}

// CreateConnector — Create connector. [POST /api/Communication/services/{id}/connectors].
func (a *CommunicationApi) CreateConnector(ctx context.Context, id_ string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Communication/services/"+segment(id_, false)+"/connectors", body, nil)
}

// CreateService — Create service. [POST /api/Communication/services].
func (a *CommunicationApi) CreateService(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Communication/services", body, nil)
}

// DeleteConnector — Delete connector. [DELETE /api/Communication/services/{id}/connectors/{connectorId}].
func (a *CommunicationApi) DeleteConnector(ctx context.Context, id_ string, connectorId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/Communication/services/"+segment(id_, false)+"/connectors/"+segment(connectorId, false), nil, nil)
}

// DeleteDomain — Delete domain. [DELETE /api/Communication/services/{id}/domains/{domainId}].
func (a *CommunicationApi) DeleteDomain(ctx context.Context, id_ string, domainId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/Communication/services/"+segment(id_, false)+"/domains/"+segment(domainId, false), nil, nil)
}

// DeleteMessage — Delete message. [DELETE /api/Communication/services/{id}/emails/{messageId}].
func (a *CommunicationApi) DeleteMessage(ctx context.Context, id_ string, messageId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/Communication/services/"+segment(id_, false)+"/emails/"+segment(messageId, false), nil, nil)
}

// DeleteSender — Delete sender. [DELETE /api/Communication/services/{id}/domains/{domainId}/senders/{senderId}].
func (a *CommunicationApi) DeleteSender(ctx context.Context, id_ string, domainId string, senderId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/Communication/services/"+segment(id_, false)+"/domains/"+segment(domainId, false)+"/senders/"+segment(senderId, false), nil, nil)
}

// DeleteService — Delete service. [DELETE /api/Communication/services/{id}].
func (a *CommunicationApi) DeleteService(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/Communication/services/"+segment(id_, false), nil, nil)
}

// GetMessage — Get message. [GET /api/Communication/services/{id}/emails/{messageId}].
func (a *CommunicationApi) GetMessage(ctx context.Context, id_ string, messageId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Communication/services/"+segment(id_, false)+"/emails/"+segment(messageId, false), nil, nil)
}

// GetService — Get service. [GET /api/Communication/services/{id}].
func (a *CommunicationApi) GetService(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Communication/services/"+segment(id_, false), nil, nil)
}

// ListConnectors — List connectors. [GET /api/Communication/services/{id}/connectors].
func (a *CommunicationApi) ListConnectors(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Communication/services/"+segment(id_, false)+"/connectors", nil, nil)
}

// ListDomains — List domains. [GET /api/Communication/services/{id}/domains].
func (a *CommunicationApi) ListDomains(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Communication/services/"+segment(id_, false)+"/domains", nil, nil)
}

// ListMessages — List messages. [GET /api/Communication/services/{id}/emails]. Query keys: limit.
func (a *CommunicationApi) ListMessages(ctx context.Context, id_ string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Communication/services/"+segment(id_, false)+"/emails", nil, query)
}

// ListServices — List services. [GET /api/Communication/services].
func (a *CommunicationApi) ListServices(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Communication/services", nil, nil)
}

// SendEmail — Send email. [POST /api/Communication/services/{id}/emails].
func (a *CommunicationApi) SendEmail(ctx context.Context, id_ string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Communication/services/"+segment(id_, false)+"/emails", body, nil)
}

// VerifyDomain — Verify domain. [POST /api/Communication/services/{id}/domains/{domainId}/verify].
func (a *CommunicationApi) VerifyDomain(ctx context.Context, id_ string, domainId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Communication/services/"+segment(id_, false)+"/domains/"+segment(domainId, false)+"/verify", nil, nil)
}

// ContainerAppApi holds the ContainerApp operations.
type ContainerAppApi struct{ c *Client }

// CreateApp — Create app. [POST /api/ContainerApp].
func (a *ContainerAppApi) CreateApp(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/ContainerApp", body, nil)
}

// CreateEnvironment — Create environment. [POST /api/ContainerApp/environments].
func (a *ContainerAppApi) CreateEnvironment(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/ContainerApp/environments", body, nil)
}

// CreateRevision — Create revision. [POST /api/ContainerApp/{id}/revisions].
func (a *ContainerAppApi) CreateRevision(ctx context.Context, id_ string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/ContainerApp/"+segment(id_, false)+"/revisions", body, nil)
}

// DeleteApp — Delete app. [DELETE /api/ContainerApp/{id}].
func (a *ContainerAppApi) DeleteApp(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/ContainerApp/"+segment(id_, false), nil, nil)
}

// DeleteEnvironment — Delete environment. [DELETE /api/ContainerApp/environments/{id}].
func (a *ContainerAppApi) DeleteEnvironment(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/ContainerApp/environments/"+segment(id_, false), nil, nil)
}

// EnvironmentContents — Environment contents. [GET /api/ContainerApp/environments/{id}/contents].
func (a *ContainerAppApi) EnvironmentContents(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/ContainerApp/environments/"+segment(id_, false)+"/contents", nil, nil)
}

// Exec — Exec. [POST /api/ContainerApp/{id}/exec].
func (a *ContainerAppApi) Exec(ctx context.Context, id_ string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/ContainerApp/"+segment(id_, false)+"/exec", body, nil)
}

// GetApp — Get app. [GET /api/ContainerApp/{id}].
func (a *ContainerAppApi) GetApp(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/ContainerApp/"+segment(id_, false), nil, nil)
}

// GetReplicas — Get replicas. [GET /api/ContainerApp/{id}/replicas].
func (a *ContainerAppApi) GetReplicas(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/ContainerApp/"+segment(id_, false)+"/replicas", nil, nil)
}

// ListApps — List apps. [GET /api/ContainerApp].
func (a *ContainerAppApi) ListApps(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/ContainerApp", nil, nil)
}

// ListEnvironments — List environments. [GET /api/ContainerApp/environments].
func (a *ContainerAppApi) ListEnvironments(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/ContainerApp/environments", nil, nil)
}

// ListRevisions — List revisions. [GET /api/ContainerApp/{id}/revisions].
func (a *ContainerAppApi) ListRevisions(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/ContainerApp/"+segment(id_, false)+"/revisions", nil, nil)
}

// Rollback — Rollback. [POST /api/ContainerApp/{id}/revisions/{revisionName}/rollback].
func (a *ContainerAppApi) Rollback(ctx context.Context, id_ string, revisionName string) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/ContainerApp/"+segment(id_, false)+"/revisions/"+segment(revisionName, false)+"/rollback", nil, nil)
}

// Scale — Scale. [POST /api/ContainerApp/{id}/scale].
func (a *ContainerAppApi) Scale(ctx context.Context, id_ string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/ContainerApp/"+segment(id_, false)+"/scale", body, nil)
}

// SetTraffic — Set traffic. [POST /api/ContainerApp/{id}/revisions/traffic].
func (a *ContainerAppApi) SetTraffic(ctx context.Context, id_ string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/ContainerApp/"+segment(id_, false)+"/revisions/traffic", body, nil)
}

// ContainerJobsApi holds the ContainerJobs operations.
type ContainerJobsApi struct{ c *Client }

// Cancel — Cancel. [POST /api/container-jobs/{id}/runs/{runId}/cancel].
func (a *ContainerJobsApi) Cancel(ctx context.Context, id_ string, runId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/container-jobs/"+segment(id_, false)+"/runs/"+segment(runId, false)+"/cancel", nil, nil)
}

// Create — Create. [POST /api/container-jobs].
func (a *ContainerJobsApi) Create(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/container-jobs", body, nil)
}

// Delete — Delete. [DELETE /api/container-jobs/{id}].
func (a *ContainerJobsApi) Delete(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/container-jobs/"+segment(id_, false), nil, nil)
}

// Get — Get. [GET /api/container-jobs/{id}].
func (a *ContainerJobsApi) Get(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/container-jobs/"+segment(id_, false), nil, nil)
}

// GetRun — Get run. [GET /api/container-jobs/{id}/runs/{runId}].
func (a *ContainerJobsApi) GetRun(ctx context.Context, id_ string, runId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/container-jobs/"+segment(id_, false)+"/runs/"+segment(runId, false), nil, nil)
}

// List — List. [GET /api/container-jobs].
func (a *ContainerJobsApi) List(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/container-jobs", nil, nil)
}

// Preview — Preview. [GET /api/container-jobs/schedule-preview]. Query keys: cron, timeZone, count.
func (a *ContainerJobsApi) Preview(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/container-jobs/schedule-preview", nil, query)
}

// Run — Run. [POST /api/container-jobs/{id}/run].
func (a *ContainerJobsApi) Run(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/container-jobs/"+segment(id_, false)+"/run", nil, nil)
}

// Runs — Runs. [GET /api/container-jobs/{id}/runs]. Query keys: take.
func (a *ContainerJobsApi) Runs(ctx context.Context, id_ string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/container-jobs/"+segment(id_, false)+"/runs", nil, query)
}

// Update — Update. [PUT /api/container-jobs/{id}].
func (a *ContainerJobsApi) Update(ctx context.Context, id_ string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "PUT", "/api/container-jobs/"+segment(id_, false), body, nil)
}

// ContainerRegistryApi holds the ContainerRegistry operations.
type ContainerRegistryApi struct{ c *Client }

// Create — Create. [POST /api/container-registry].
func (a *ContainerRegistryApi) Create(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/container-registry", body, nil)
}

// CreateRepository — Create repository. [POST /api/container-registry/{id}/repositories].
func (a *ContainerRegistryApi) CreateRepository(ctx context.Context, id_ string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/container-registry/"+segment(id_, false)+"/repositories", body, nil)
}

// Credentials — Credentials. [GET /api/container-registry/{id}/credentials].
func (a *ContainerRegistryApi) Credentials(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/container-registry/"+segment(id_, false)+"/credentials", nil, nil)
}

// Delete — Delete. [DELETE /api/container-registry/{id}].
func (a *ContainerRegistryApi) Delete(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/container-registry/"+segment(id_, false), nil, nil)
}

// DeleteRepository — Delete repository. [DELETE /api/container-registry/{id}/repositories/{repositoryName}].
func (a *ContainerRegistryApi) DeleteRepository(ctx context.Context, id_ string, repositoryName string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/container-registry/"+segment(id_, false)+"/repositories/"+segment(repositoryName, true), nil, nil)
}

// DeleteTag — Delete tag. [DELETE /api/container-registry/{id}/tags]. Query keys: repository, tag.
func (a *ContainerRegistryApi) DeleteTag(ctx context.Context, id_ string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/container-registry/"+segment(id_, false)+"/tags", nil, query)
}

// Get — Get. [GET /api/container-registry/{id}].
func (a *ContainerRegistryApi) Get(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/container-registry/"+segment(id_, false), nil, nil)
}

// List — List. [GET /api/container-registry].
func (a *ContainerRegistryApi) List(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/container-registry", nil, nil)
}

// Repositories — Repositories. [GET /api/container-registry/{id}/repositories].
func (a *ContainerRegistryApi) Repositories(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/container-registry/"+segment(id_, false)+"/repositories", nil, nil)
}

// Rotate — Rotate. [POST /api/container-registry/{id}/credentials/rotate].
func (a *ContainerRegistryApi) Rotate(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/container-registry/"+segment(id_, false)+"/credentials/rotate", nil, nil)
}

// Tags — Tags. [GET /api/container-registry/{id}/tags]. Query keys: repository.
func (a *ContainerRegistryApi) Tags(ctx context.Context, id_ string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/container-registry/"+segment(id_, false)+"/tags", nil, query)
}

// ContainersApi holds the Containers operations.
type ContainersApi struct{ c *Client }

// BuildImage — Build image. [POST /api/Containers/images/build].
func (a *ContainersApi) BuildImage(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Containers/images/build", body, nil)
}

// CreateContainer — Create container. [POST /api/Containers/createcontainer].
func (a *ContainersApi) CreateContainer(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Containers/createcontainer", body, nil)
}

// CreateSwarmService — Create swarm service. [POST /api/Containers/swarm/services].
func (a *ContainersApi) CreateSwarmService(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Containers/swarm/services", body, nil)
}

// DeleteContainer — Delete container. [POST /api/Containers/deletecontainer].
func (a *ContainersApi) DeleteContainer(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Containers/deletecontainer", body, nil)
}

// Exec — Exec. [POST /api/Containers/{containerName}/exec].
func (a *ContainersApi) Exec(ctx context.Context, containerName string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Containers/"+segment(containerName, false)+"/exec", body, nil)
}

// GivePublicAddress — Give public address. [POST /api/Containers/{name}/public-ip]. Query keys: region.
func (a *ContainersApi) GivePublicAddress(ctx context.Context, name string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Containers/"+segment(name, false)+"/public-ip", nil, query)
}

// Inspect — Inspect. [GET /api/Containers/{containerName}/inspect].
func (a *ContainersApi) Inspect(ctx context.Context, containerName string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Containers/"+segment(containerName, false)+"/inspect", nil, nil)
}

// ListAllContainers — List all containers. [POST /api/Containers/listallcontainers].
func (a *ContainersApi) ListAllContainers(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Containers/listallcontainers", body, nil)
}

// Logs — Logs. [GET /api/Containers/{containerName}/logs]. Query keys: tail.
func (a *ContainersApi) Logs(ctx context.Context, containerName string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Containers/"+segment(containerName, false)+"/logs", nil, query)
}

// ReleasePublicAddress — Release public address. [DELETE /api/Containers/{name}/public-ip]. Query keys: region.
func (a *ContainersApi) ReleasePublicAddress(ctx context.Context, name string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/Containers/"+segment(name, false)+"/public-ip", nil, query)
}

// RemoveSwarmService — Remove swarm service. [DELETE /api/Containers/swarm/services/{name}]. Query keys: region.
func (a *ContainersApi) RemoveSwarmService(ctx context.Context, name string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/Containers/swarm/services/"+segment(name, false), nil, query)
}

// RenameContainer — Rename container. [POST /api/Containers/renamecontainer].
func (a *ContainersApi) RenameContainer(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Containers/renamecontainer", body, nil)
}

// RestartContainer — Restart container. [POST /api/Containers/restartcontainer].
func (a *ContainersApi) RestartContainer(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Containers/restartcontainer", body, nil)
}

// ScaleSwarmService — Scale swarm service. [POST /api/Containers/swarm/services/{name}/scale]. Query keys: replicas, region.
func (a *ContainersApi) ScaleSwarmService(ctx context.Context, name string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Containers/swarm/services/"+segment(name, false)+"/scale", nil, query)
}

// StackDown — Stack down. [POST /api/Containers/stacks/down].
func (a *ContainersApi) StackDown(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Containers/stacks/down", body, nil)
}

// StackFile — Stack file. [GET /api/Containers/stacks/{project}]. Query keys: region.
func (a *ContainersApi) StackFile(ctx context.Context, project string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Containers/stacks/"+segment(project, false), nil, query)
}

// StackUp — Stack up. [POST /api/Containers/stacks/up].
func (a *ContainersApi) StackUp(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Containers/stacks/up", body, nil)
}

// StartContainer — Start container. [POST /api/Containers/startcontainer].
func (a *ContainersApi) StartContainer(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Containers/startcontainer", body, nil)
}

// Stats — Stats. [GET /api/Containers/{containerName}/stats].
func (a *ContainersApi) Stats(ctx context.Context, containerName string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Containers/"+segment(containerName, false)+"/stats", nil, nil)
}

// StopContainer — Stop container. [POST /api/Containers/stopcontainer].
func (a *ContainersApi) StopContainer(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Containers/stopcontainer", body, nil)
}

// SwarmInit — Swarm init. [POST /api/Containers/swarm/init]. Query keys: region.
func (a *ContainersApi) SwarmInit(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Containers/swarm/init", nil, query)
}

// SwarmLeave — Swarm leave. [POST /api/Containers/swarm/leave]. Query keys: region.
func (a *ContainersApi) SwarmLeave(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Containers/swarm/leave", nil, query)
}

// SwarmNodes — Swarm nodes. [GET /api/Containers/swarm/nodes]. Query keys: region.
func (a *ContainersApi) SwarmNodes(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Containers/swarm/nodes", nil, query)
}

// SwarmServices — Swarm services. [GET /api/Containers/swarm/services]. Query keys: region.
func (a *ContainersApi) SwarmServices(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Containers/swarm/services", nil, query)
}

// SwarmStatus — Swarm status. [GET /api/Containers/swarm]. Query keys: region.
func (a *ContainersApi) SwarmStatus(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Containers/swarm", nil, query)
}

// UpdateContainer — Update container. [POST /api/Containers/updatecontainer].
func (a *ContainersApi) UpdateContainer(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Containers/updatecontainer", body, nil)
}

// Volumes — Volumes. [GET /api/Containers/volumes]. Query keys: region.
func (a *ContainersApi) Volumes(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Containers/volumes", nil, query)
}

// CostTrackingApi holds the CostTracking operations.
type CostTrackingApi struct{ c *Client }

// CreateCostAlert — Create cost alert. [POST /api/CostTracking/alerts].
func (a *CostTrackingApi) CreateCostAlert(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/CostTracking/alerts", body, nil)
}

// DeleteCostAlert — Delete cost alert. [DELETE /api/CostTracking/alerts/{alertId}].
func (a *CostTrackingApi) DeleteCostAlert(ctx context.Context, alertId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/CostTracking/alerts/"+segment(alertId, false), nil, nil)
}

// EstimateCost — Estimate cost. [POST /api/CostTracking/pricing/estimate].
func (a *CostTrackingApi) EstimateCost(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/CostTracking/pricing/estimate", body, nil)
}

// GetAllStorageAccountCosts — Get all storage account costs. [GET /api/CostTracking/storage-accounts]. Query keys: period.
func (a *CostTrackingApi) GetAllStorageAccountCosts(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/CostTracking/storage-accounts", nil, query)
}

// GetBillingPeriods — Get billing periods. [GET /api/CostTracking/billing/history]. Query keys: limit.
func (a *CostTrackingApi) GetBillingPeriods(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/CostTracking/billing/history", nil, query)
}

// GetCostAlerts — Get cost alerts. [GET /api/CostTracking/alerts]. Query keys: scopeType, scopeId.
func (a *CostTrackingApi) GetCostAlerts(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/CostTracking/alerts", nil, query)
}

// GetCurrentBillingPeriod — Get current billing period. [GET /api/CostTracking/billing/current].
func (a *CostTrackingApi) GetCurrentBillingPeriod(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/CostTracking/billing/current", nil, nil)
}

// GetPricingTiers — Get pricing tiers. [GET /api/CostTracking/pricing]. Query keys: tier, redundancy, region.
func (a *CostTrackingApi) GetPricingTiers(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/CostTracking/pricing", nil, query)
}

// GetResourceGroupCost — Get resource group cost. [GET /api/CostTracking/resource-group/{resourceGroupId}]. Query keys: period.
func (a *CostTrackingApi) GetResourceGroupCost(ctx context.Context, resourceGroupId string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/CostTracking/resource-group/"+segment(resourceGroupId, false), nil, query)
}

// GetStorageAccountCost — Get storage account cost. [GET /api/CostTracking/storage-account/{storageAccountId}]. Query keys: period.
func (a *CostTrackingApi) GetStorageAccountCost(ctx context.Context, storageAccountId string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/CostTracking/storage-account/"+segment(storageAccountId, false), nil, query)
}

// GetSubscriptionCost — Get subscription cost. [GET /api/CostTracking/subscription/{subscriptionId}]. Query keys: period.
func (a *CostTrackingApi) GetSubscriptionCost(ctx context.Context, subscriptionId string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/CostTracking/subscription/"+segment(subscriptionId, false), nil, query)
}

// Overview — Overview. [GET /api/CostTracking/overview]. Query keys: region, subscriptionId, from, to, resourceName.
func (a *CostTrackingApi) Overview(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/CostTracking/overview", nil, query)
}

// RecordCostEvent — Record cost event. [POST /api/CostTracking/events].
func (a *CostTrackingApi) RecordCostEvent(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/CostTracking/events", body, nil)
}

// TriggerDailyCalculation — Trigger daily calculation. [POST /api/CostTracking/daily-calculation].
func (a *CostTrackingApi) TriggerDailyCalculation(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/CostTracking/daily-calculation", nil, nil)
}

// CreateResourceApi holds the CreateResource operations.
type CreateResourceApi struct{ c *Client }

// CreateResource — Create resource. [POST /api/CreateResource/createresource].
func (a *CreateResourceApi) CreateResource(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/CreateResource/createresource", body, nil)
}

// ValidateResource — Validate resource. [POST /api/CreateResource/validateresource].
func (a *CreateResourceApi) ValidateResource(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/CreateResource/validateresource", body, nil)
}

// DeploymentApi holds the Deployment operations.
type DeploymentApi struct{ c *Client }

// DeleteDeployment — Delete deployment. [DELETE /api/Deployment/deployments/{id}].
func (a *DeploymentApi) DeleteDeployment(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/Deployment/deployments/"+segment(id_, false), nil, nil)
}

// Deployment — Deployment. [GET /api/Deployment/deployments/{id}].
func (a *DeploymentApi) Deployment(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Deployment/deployments/"+segment(id_, false), nil, nil)
}

// Deployments — Deployments. [GET /api/Deployment/deployments]. Query keys: status, limit.
func (a *DeploymentApi) Deployments(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Deployment/deployments", nil, query)
}

// Redeploy — Redeploy. [POST /api/Deployment/deployments/{id}/redeploy].
func (a *DeploymentApi) Redeploy(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Deployment/deployments/"+segment(id_, false)+"/redeploy", nil, nil)
}

// Status — Status. [GET /api/Deployment/status]. Query keys: limit.
func (a *DeploymentApi) Status(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Deployment/status", nil, query)
}

// DockerImagesApi holds the DockerImages operations.
type DockerImagesApi struct{ c *Client }

// GetImageHistory — Get image history. [POST /api/DockerImages/imagehistory]. Query keys: regions.
func (a *DockerImagesApi) GetImageHistory(ctx context.Context, body any, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/DockerImages/imagehistory", body, query)
}

// GetImageInformations — Get image informations. [POST /api/DockerImages/inspectimage]. Query keys: regions.
func (a *DockerImagesApi) GetImageInformations(ctx context.Context, body any, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/DockerImages/inspectimage", body, query)
}

// ListAllDockerImages — List all docker images. [POST /api/DockerImages/listallimages]. Query keys: regions.
func (a *DockerImagesApi) ListAllDockerImages(ctx context.Context, body any, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/DockerImages/listallimages", body, query)
}

// ListAllDockerPublicImages — List all docker public images. [POST /api/DockerImages/listallpublicimages]. Query keys: isOfficialImage.
func (a *DockerImagesApi) ListAllDockerPublicImages(ctx context.Context, body any, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/DockerImages/listallpublicimages", body, query)
}

// SearchDockerImage — Search docker image. [POST /api/DockerImages/searchimage]. Query keys: regions.
func (a *DockerImagesApi) SearchDockerImage(ctx context.Context, body any, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/DockerImages/searchimage", body, query)
}

// DownloadsApi holds the Downloads operations.
type DownloadsApi struct{ c *Client }

// Cli — Cli. [GET /api/downloads/hiok].
func (a *DownloadsApi) Cli(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/downloads/hiok", nil, nil)
}

// Install — Install. [GET /api/downloads/install.sh].
func (a *DownloadsApi) Install(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/downloads/install.sh", nil, nil)
}

// InstallPs1 — Install ps1. [GET /api/downloads/install.ps1].
func (a *DownloadsApi) InstallPs1(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/downloads/install.ps1", nil, nil)
}

// Manifest — Manifest. [GET /api/downloads/manifest].
func (a *DownloadsApi) Manifest(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/downloads/manifest", nil, nil)
}

// Sdk — Sdk. [GET /api/downloads/sdk.tar.gz].
func (a *DownloadsApi) Sdk(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/downloads/sdk.tar.gz", nil, nil)
}

// SdkPackage — Sdk package. [GET /api/downloads/sdk/{file}].
func (a *DownloadsApi) SdkPackage(ctx context.Context, file string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/downloads/sdk/"+segment(file, false), nil, nil)
}

// SdkPackageList — Sdk package list. [GET /api/downloads/sdk].
func (a *DownloadsApi) SdkPackageList(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/downloads/sdk", nil, nil)
}

// DpsApi holds the Dps operations.
type DpsApi struct{ c *Client }

// Create — Create. [POST /api/dps/enrollments].
func (a *DpsApi) Create(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/dps/enrollments", body, nil)
}

// Delete — Delete. [DELETE /api/dps/enrollments/{id}].
func (a *DpsApi) Delete(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/dps/enrollments/"+segment(id_, false), nil, nil)
}

// List — List. [GET /api/dps/enrollments].
func (a *DpsApi) List(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/dps/enrollments", nil, nil)
}

// Register — Register. [POST /api/dps/register].
func (a *DpsApi) Register(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/dps/register", body, nil)
}

// Registrations — Registrations. [GET /api/dps/enrollments/{id}/registrations].
func (a *DpsApi) Registrations(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/dps/enrollments/"+segment(id_, false)+"/registrations", nil, nil)
}

// FxApi holds the Fx operations.
type FxApi struct{ c *Client }

// Convert — Convert. [GET /api/Fx/convert]. Query keys: usd, currency.
func (a *FxApi) Convert(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Fx/convert", nil, query)
}

// Rates — Rates. [GET /api/Fx/rates].
func (a *FxApi) Rates(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Fx/rates", nil, nil)
}

// GroupsApi holds the Groups operations.
type GroupsApi struct{ c *Client }

// CreateGroups — Create groups. [POST /api/Groups/creategroups].
func (a *GroupsApi) CreateGroups(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Groups/creategroups", body, nil)
}

// DeleteGroups — Delete groups. [DELETE /api/Groups/deletegroups]. Query keys: id.
func (a *GroupsApi) DeleteGroups(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/Groups/deletegroups", nil, query)
}

// EditGroups — Edit groups. [PUT /api/Groups/editgroups].
func (a *GroupsApi) EditGroups(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "PUT", "/api/Groups/editgroups", body, nil)
}

// GetGroups — Get groups. [GET /api/Groups/groups].
func (a *GroupsApi) GetGroups(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Groups/groups", nil, nil)
}

// HierarchyViewApi holds the HierarchyView operations.
type HierarchyViewApi struct{ c *Client }

// Context — Context. [GET /api/hierarchyview/context/{resourceGroupId}].
func (a *HierarchyViewApi) Context(ctx context.Context, resourceGroupId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/hierarchyview/context/"+segment(resourceGroupId, false), nil, nil)
}

// Full — Full. [GET /api/hierarchyview/full].
func (a *HierarchyViewApi) Full(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/hierarchyview/full", nil, nil)
}

// HiokCloudGroupsApi holds the HiokCloudGroups operations.
type HiokCloudGroupsApi struct{ c *Client }

// CreateHiokCloudAccessGroup — Create hiok cloud access group. [POST /api/HiokCloudGroups/createaccessgroup].
func (a *HiokCloudGroupsApi) CreateHiokCloudAccessGroup(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/HiokCloudGroups/createaccessgroup", body, nil)
}

// CreateManagementGroup — Create management group. [POST /api/HiokCloudGroups/createmanagementgroup].
func (a *HiokCloudGroupsApi) CreateManagementGroup(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/HiokCloudGroups/createmanagementgroup", body, nil)
}

// CreateResourceGroup — Create resource group. [POST /api/HiokCloudGroups/createresourcegroup].
func (a *HiokCloudGroupsApi) CreateResourceGroup(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/HiokCloudGroups/createresourcegroup", body, nil)
}

// DeleteHiokCloudAccessGroup — Delete hiok cloud access group. [DELETE /api/HiokCloudGroups/deleteaccessgroup].
func (a *HiokCloudGroupsApi) DeleteHiokCloudAccessGroup(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/HiokCloudGroups/deleteaccessgroup", body, nil)
}

// EditHiokCloudAccessGroup — Edit hiok cloud access group. [PUT /api/HiokCloudGroups/editaccessgroup].
func (a *HiokCloudGroupsApi) EditHiokCloudAccessGroup(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "PUT", "/api/HiokCloudGroups/editaccessgroup", body, nil)
}

// GetAllHiokCloudAccessGroup — Get all hiok cloud access group. [GET /api/HiokCloudGroups/allaccessgroups].
func (a *HiokCloudGroupsApi) GetAllHiokCloudAccessGroup(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/HiokCloudGroups/allaccessgroups", nil, nil)
}

// GetHiokCloudAccessGroup — Get hiok cloud access group. [GET /api/HiokCloudGroups/accessgroups].
func (a *HiokCloudGroupsApi) GetHiokCloudAccessGroup(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/HiokCloudGroups/accessgroups", nil, nil)
}

// GetHiokCloudSpecificAccessGroup — Get hiok cloud specific access group. [GET /api/HiokCloudGroups/specificaccessgroups]. Query keys: type.
func (a *HiokCloudGroupsApi) GetHiokCloudSpecificAccessGroup(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/HiokCloudGroups/specificaccessgroups", nil, query)
}

// HiokCloudHierarchyApi holds the HiokCloudHierarchy operations.
type HiokCloudHierarchyApi struct{ c *Client }

// CreateHiokCloudHierarchy — Create hiok cloud hierarchy. [POST /api/HiokCloudHierarchy].
func (a *HiokCloudHierarchyApi) CreateHiokCloudHierarchy(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/HiokCloudHierarchy", body, nil)
}

// DeleteHiokCloudHierarchy — Delete hiok cloud hierarchy. [DELETE /api/HiokCloudHierarchy/deletehierarchy/{id}].
func (a *HiokCloudHierarchyApi) DeleteHiokCloudHierarchy(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/HiokCloudHierarchy/deletehierarchy/"+segment(id_, false), nil, nil)
}

// DeleteHiokCloudHierarchyNode — Delete hiok cloud hierarchy node. [DELETE /api/HiokCloudHierarchy/deletehierarchynode].
func (a *HiokCloudHierarchyApi) DeleteHiokCloudHierarchyNode(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/HiokCloudHierarchy/deletehierarchynode", body, nil)
}

// EditHiokCloudHierarchy — Edit hiok cloud hierarchy. [PUT /api/HiokCloudHierarchy/edithierarchy].
func (a *HiokCloudHierarchyApi) EditHiokCloudHierarchy(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "PUT", "/api/HiokCloudHierarchy/edithierarchy", body, nil)
}

// GetAllHierarchy — Get all hierarchy. [GET /api/HiokCloudHierarchy/hierarchies].
func (a *HiokCloudHierarchyApi) GetAllHierarchy(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/HiokCloudHierarchy/hierarchies", nil, nil)
}

// GetHierarchy — Get hierarchy. [GET /api/HiokCloudHierarchy/hierarchy/{id}].
func (a *HiokCloudHierarchyApi) GetHierarchy(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/HiokCloudHierarchy/hierarchy/"+segment(id_, false), nil, nil)
}

// HiokIdApi holds the HiokId operations.
type HiokIdApi struct{ c *Client }

// Accept — Accept. [POST /api/hiok-id/invitations/{id}/accept].
func (a *HiokIdApi) Accept(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/hiok-id/invitations/"+segment(id_, false)+"/accept", nil, nil)
}

// AddAppCredential — Add app credential. [POST /api/hiok-id/apps/{id}/credentials].
func (a *HiokIdApi) AddAppCredential(ctx context.Context, id_ string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/hiok-id/apps/"+segment(id_, false)+"/credentials", body, nil)
}

// AddGroupMember — Add group member. [POST /api/hiok-id/groups/{id}/members].
func (a *HiokIdApi) AddGroupMember(ctx context.Context, id_ string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/hiok-id/groups/"+segment(id_, false)+"/members", body, nil)
}

// AddSpCredential — Add sp credential. [POST /api/hiok-id/service-principals/{id}/credentials].
func (a *HiokIdApi) AddSpCredential(ctx context.Context, id_ string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/hiok-id/service-principals/"+segment(id_, false)+"/credentials", body, nil)
}

// Apps — Apps. [GET /api/hiok-id/apps].
func (a *HiokIdApi) Apps(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/hiok-id/apps", nil, nil)
}

// CreateApp — Create app. [POST /api/hiok-id/apps].
func (a *HiokIdApi) CreateApp(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/hiok-id/apps", body, nil)
}

// CreateGroup — Create group. [POST /api/hiok-id/groups].
func (a *HiokIdApi) CreateGroup(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/hiok-id/groups", body, nil)
}

// CreateServicePrincipal — Create service principal. [POST /api/hiok-id/service-principals].
func (a *HiokIdApi) CreateServicePrincipal(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/hiok-id/service-principals", body, nil)
}

// CreateTenant — Create tenant. [POST /api/hiok-id/tenants].
func (a *HiokIdApi) CreateTenant(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/hiok-id/tenants", body, nil)
}

// Decline — Decline. [POST /api/hiok-id/invitations/{id}/decline].
func (a *HiokIdApi) Decline(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/hiok-id/invitations/"+segment(id_, false)+"/decline", nil, nil)
}

// DeleteApp — Delete app. [DELETE /api/hiok-id/apps/{id}].
func (a *HiokIdApi) DeleteApp(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/hiok-id/apps/"+segment(id_, false), nil, nil)
}

// DeleteGroup — Delete group. [DELETE /api/hiok-id/groups/{id}].
func (a *HiokIdApi) DeleteGroup(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/hiok-id/groups/"+segment(id_, false), nil, nil)
}

// DeleteServicePrincipal — Delete service principal. [DELETE /api/hiok-id/service-principals/{id}].
func (a *HiokIdApi) DeleteServicePrincipal(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/hiok-id/service-principals/"+segment(id_, false), nil, nil)
}

// Directories — Directories. [GET /api/hiok-id/directories].
func (a *HiokIdApi) Directories(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/hiok-id/directories", nil, nil)
}

// Enter — Enter. [POST /api/hiok-id/directories/enter].
func (a *HiokIdApi) Enter(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/hiok-id/directories/enter", body, nil)
}

// Groups — Groups. [GET /api/hiok-id/groups].
func (a *HiokIdApi) Groups(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/hiok-id/groups", nil, nil)
}

// Invite — Invite. [POST /api/hiok-id/users].
func (a *HiokIdApi) Invite(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/hiok-id/users", body, nil)
}

// Leave — Leave. [POST /api/hiok-id/directories/leave].
func (a *HiokIdApi) Leave(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/hiok-id/directories/leave", body, nil)
}

// Me — Me. [GET /api/hiok-id/me].
func (a *HiokIdApi) Me(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/hiok-id/me", nil, nil)
}

// Overview — Overview. [GET /api/hiok-id/overview].
func (a *HiokIdApi) Overview(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/hiok-id/overview", nil, nil)
}

// RemoveAppCredential — Remove app credential. [DELETE /api/hiok-id/apps/{id}/credentials/{credentialId}].
func (a *HiokIdApi) RemoveAppCredential(ctx context.Context, id_ string, credentialId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/hiok-id/apps/"+segment(id_, false)+"/credentials/"+segment(credentialId, false), nil, nil)
}

// RemoveGroupMember — Remove group member. [DELETE /api/hiok-id/groups/{id}/members/{kind}/{reference}].
func (a *HiokIdApi) RemoveGroupMember(ctx context.Context, id_ string, kind string, reference string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/hiok-id/groups/"+segment(id_, false)+"/members/"+segment(kind, false)+"/"+segment(reference, false), nil, nil)
}

// RemoveMember — Remove member. [DELETE /api/hiok-id/users/{id}].
func (a *HiokIdApi) RemoveMember(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/hiok-id/users/"+segment(id_, false), nil, nil)
}

// RemoveSpCredential — Remove sp credential. [DELETE /api/hiok-id/service-principals/{id}/credentials/{credentialId}].
func (a *HiokIdApi) RemoveSpCredential(ctx context.Context, id_ string, credentialId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/hiok-id/service-principals/"+segment(id_, false)+"/credentials/"+segment(credentialId, false), nil, nil)
}

// RenameDirectory — Rename directory. [PUT /api/hiok-id/directory].
func (a *HiokIdApi) RenameDirectory(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "PUT", "/api/hiok-id/directory", body, nil)
}

// Resend — Resend. [POST /api/hiok-id/users/{id}/resend].
func (a *HiokIdApi) Resend(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/hiok-id/users/"+segment(id_, false)+"/resend", nil, nil)
}

// ServicePrincipals — Service principals. [GET /api/hiok-id/service-principals].
func (a *HiokIdApi) ServicePrincipals(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/hiok-id/service-principals", nil, nil)
}

// SignIns — Sign ins. [GET /api/hiok-id/sign-ins]. Query keys: take, outcome.
func (a *HiokIdApi) SignIns(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/hiok-id/sign-ins", nil, query)
}

// UpdateApp — Update app. [PUT /api/hiok-id/apps/{id}].
func (a *HiokIdApi) UpdateApp(ctx context.Context, id_ string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "PUT", "/api/hiok-id/apps/"+segment(id_, false), body, nil)
}

// UpdateGroup — Update group. [PUT /api/hiok-id/groups/{id}].
func (a *HiokIdApi) UpdateGroup(ctx context.Context, id_ string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "PUT", "/api/hiok-id/groups/"+segment(id_, false), body, nil)
}

// UpdateMember — Update member. [PUT /api/hiok-id/users/{id}].
func (a *HiokIdApi) UpdateMember(ctx context.Context, id_ string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "PUT", "/api/hiok-id/users/"+segment(id_, false), body, nil)
}

// UpdateServicePrincipal — Update service principal. [PUT /api/hiok-id/service-principals/{id}].
func (a *HiokIdApi) UpdateServicePrincipal(ctx context.Context, id_ string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "PUT", "/api/hiok-id/service-principals/"+segment(id_, false), body, nil)
}

// Users — Users. [GET /api/hiok-id/users].
func (a *HiokIdApi) Users(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/hiok-id/users", nil, nil)
}

// HiokUsersApi holds the HiokUsers operations.
type HiokUsersApi struct{ c *Client }

// DeleteUserById — Delete user by id. [DELETE /api/HiokUsers/removehiokuser/{emailId}].
func (a *HiokUsersApi) DeleteUserById(ctx context.Context, emailId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/HiokUsers/removehiokuser/"+segment(emailId, false), nil, nil)
}

// ForgotPassword — Forgot password. [POST /api/HiokUsers/forgotpassword].
func (a *HiokUsersApi) ForgotPassword(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/HiokUsers/forgotpassword", body, nil)
}

// HiokUserById — Hiok user by id. [GET /api/HiokUsers/hiokusersbyid/{emailId}].
func (a *HiokUsersApi) HiokUserById(ctx context.Context, emailId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/HiokUsers/hiokusersbyid/"+segment(emailId, false), nil, nil)
}

// HiokUsers — Hiok users. [GET /api/HiokUsers/hiokusers].
func (a *HiokUsersApi) HiokUsers(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/HiokUsers/hiokusers", nil, nil)
}

// RegisterHiokUser — Register hiok user. [POST /api/HiokUsers/registerhiokuser].
func (a *HiokUsersApi) RegisterHiokUser(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/HiokUsers/registerhiokuser", body, nil)
}

// ResendVerification — Resend verification. [POST /api/HiokUsers/resendverification].
func (a *HiokUsersApi) ResendVerification(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/HiokUsers/resendverification", body, nil)
}

// ResetPassword — Reset password. [POST /api/HiokUsers/resetpassword].
func (a *HiokUsersApi) ResetPassword(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/HiokUsers/resetpassword", body, nil)
}

// UpdateUserById — Update user by id. [PUT /api/HiokUsers/hiokuserupdate/{emailId}].
func (a *HiokUsersApi) UpdateUserById(ctx context.Context, emailId string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "PUT", "/api/HiokUsers/hiokuserupdate/"+segment(emailId, false), body, nil)
}

// VerifyEmail — Verify email. [POST /api/HiokUsers/verifyemail].
func (a *HiokUsersApi) VerifyEmail(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/HiokUsers/verifyemail", body, nil)
}

// HybridApi holds the Hybrid operations.
type HybridApi struct{ c *Client }

// AgentInstall — Agent install. [GET /api/hybrid/agent-install].
func (a *HybridApi) AgentInstall(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/hybrid/agent-install", nil, nil)
}

// Delete — Delete. [DELETE /api/hybrid/resources/{id}].
func (a *HybridApi) Delete(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/hybrid/resources/"+segment(id_, false), nil, nil)
}

// Heartbeat — Heartbeat. [POST /api/hybrid/heartbeat].
func (a *HybridApi) Heartbeat(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/hybrid/heartbeat", body, nil)
}

// List — List. [GET /api/hybrid/resources].
func (a *HybridApi) List(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/hybrid/resources", nil, nil)
}

// ListServices — List services. [GET /api/hybrid/resources/{id}/services].
func (a *HybridApi) ListServices(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/hybrid/resources/"+segment(id_, false)+"/services", nil, nil)
}

// Metrics — Metrics. [GET /api/hybrid/resources/{id}/metrics].
func (a *HybridApi) Metrics(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/hybrid/resources/"+segment(id_, false)+"/metrics", nil, nil)
}

// ProvisionEdge — Provision edge. [POST /api/hybrid/resources/{id}/edge].
func (a *HybridApi) ProvisionEdge(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/hybrid/resources/"+segment(id_, false)+"/edge", nil, nil)
}

// PublishService — Publish service. [POST /api/hybrid/resources/{id}/services].
func (a *HybridApi) PublishService(ctx context.Context, id_ string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/hybrid/resources/"+segment(id_, false)+"/services", body, nil)
}

// Register — Register. [POST /api/hybrid/resources].
func (a *HybridApi) Register(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/hybrid/resources", body, nil)
}

// UnpublishService — Unpublish service. [DELETE /api/hybrid/resources/{id}/services/{serviceId}].
func (a *HybridApi) UnpublishService(ctx context.Context, id_ string, serviceId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/hybrid/resources/"+segment(id_, false)+"/services/"+segment(serviceId, false), nil, nil)
}

// IdentityApi holds the Identity operations.
type IdentityApi struct{ c *Client }

// Create — Create. [POST /api/identity].
func (a *IdentityApi) Create(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/identity", body, nil)
}

// Delete — Delete. [DELETE /api/identity/{id}].
func (a *IdentityApi) Delete(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/identity/"+segment(id_, false), nil, nil)
}

// ForResource — For resource. [GET /api/identity/for-resource/{resourceId}]. Query keys: resourceType, name.
func (a *IdentityApi) ForResource(ctx context.Context, resourceId string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/identity/for-resource/"+segment(resourceId, false), nil, query)
}

// List — List. [GET /api/identity]. Query keys: kind.
func (a *IdentityApi) List(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/identity", nil, query)
}

// Regenerate — Regenerate. [POST /api/identity/{id}/regenerate-secret].
func (a *IdentityApi) Regenerate(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/identity/"+segment(id_, false)+"/regenerate-secret", nil, nil)
}

// InfrastructureApi holds the Infrastructure operations.
type InfrastructureApi struct{ c *Client }

// AllocateIp — Allocate ip. [POST /api/Infrastructure/ip-allocations].
func (a *InfrastructureApi) AllocateIp(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Infrastructure/ip-allocations", body, nil)
}

// GetReverse — Get reverse. [GET /api/Infrastructure/regions/{region}/reverse/{ip}].
func (a *InfrastructureApi) GetReverse(ctx context.Context, region string, ip string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Infrastructure/regions/"+segment(region, false)+"/reverse/"+segment(ip, false), nil, nil)
}

// IpAllocations — Ip allocations. [GET /api/Infrastructure/ip-allocations]. Query keys: region, includeReleased.
func (a *InfrastructureApi) IpAllocations(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Infrastructure/ip-allocations", nil, query)
}

// IpBlock — Ip block. [GET /api/Infrastructure/regions/{region}/ips/{block}].
func (a *InfrastructureApi) IpBlock(ctx context.Context, region string, block string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Infrastructure/regions/"+segment(region, false)+"/ips/"+segment(block, false), nil, nil)
}

// IpPools — Ip pools. [GET /api/Infrastructure/ip-pools]. Query keys: region.
func (a *InfrastructureApi) IpPools(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Infrastructure/ip-pools", nil, query)
}

// Ips — Ips. [GET /api/Infrastructure/regions/{region}/ips].
func (a *InfrastructureApi) Ips(ctx context.Context, region string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Infrastructure/regions/"+segment(region, false)+"/ips", nil, nil)
}

// IpsForResource — Ips for resource. [GET /api/Infrastructure/ip-allocations/resource/{resourceKind}/{resourceId}].
func (a *InfrastructureApi) IpsForResource(ctx context.Context, resourceKind string, resourceId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Infrastructure/ip-allocations/resource/"+segment(resourceKind, false)+"/"+segment(resourceId, false), nil, nil)
}

// ReconcileIps — Reconcile ips. [POST /api/Infrastructure/ip-allocations/reconcile]. Query keys: region.
func (a *InfrastructureApi) ReconcileIps(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Infrastructure/ip-allocations/reconcile", nil, query)
}

// Regions — Regions. [GET /api/Infrastructure/regions].
func (a *InfrastructureApi) Regions(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Infrastructure/regions", nil, nil)
}

// ReleaseIp — Release ip. [DELETE /api/Infrastructure/ip-allocations/{id}]. Query keys: targetContainer.
func (a *InfrastructureApi) ReleaseIp(ctx context.Context, id_ string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/Infrastructure/ip-allocations/"+segment(id_, false), nil, query)
}

// Reverses — Reverses. [GET /api/Infrastructure/regions/{region}/ips/{block}/reverse].
func (a *InfrastructureApi) Reverses(ctx context.Context, region string, block string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Infrastructure/regions/"+segment(region, false)+"/ips/"+segment(block, false)+"/reverse", nil, nil)
}

// Server — Server. [GET /api/Infrastructure/regions/{region}/servers/{name}].
func (a *InfrastructureApi) Server(ctx context.Context, region string, name string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Infrastructure/regions/"+segment(region, false)+"/servers/"+segment(name, false), nil, nil)
}

// Servers — Servers. [GET /api/Infrastructure/regions/{region}/servers].
func (a *InfrastructureApi) Servers(ctx context.Context, region string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Infrastructure/regions/"+segment(region, false)+"/servers", nil, nil)
}

// SetReverse — Set reverse. [POST /api/Infrastructure/regions/{region}/reverse].
func (a *InfrastructureApi) SetReverse(ctx context.Context, region string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Infrastructure/regions/"+segment(region, false)+"/reverse", body, nil)
}

// IntegrationsApi holds the Integrations operations.
type IntegrationsApi struct{ c *Client }

// Create — Create. [POST /api/integrations].
func (a *IntegrationsApi) Create(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/integrations", body, nil)
}

// Delete — Delete. [DELETE /api/integrations/{id}].
func (a *IntegrationsApi) Delete(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/integrations/"+segment(id_, false), nil, nil)
}

// Get — Get. [GET /api/integrations/{id}].
func (a *IntegrationsApi) Get(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/integrations/"+segment(id_, false), nil, nil)
}

// List — List. [GET /api/integrations].
func (a *IntegrationsApi) List(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/integrations", nil, nil)
}

// Test — Test. [POST /api/integrations/{id}/test].
func (a *IntegrationsApi) Test(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/integrations/"+segment(id_, false)+"/test", nil, nil)
}

// Update — Update. [PUT /api/integrations/{id}].
func (a *IntegrationsApi) Update(ctx context.Context, id_ string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "PUT", "/api/integrations/"+segment(id_, false), body, nil)
}

// IoTDeviceGatewayApi holds the IoTDeviceGateway operations.
type IoTDeviceGatewayApi struct{ c *Client }

// GetTwin — Get twin. [GET /api/iot/devices/{deviceId}/twin].
func (a *IoTDeviceGatewayApi) GetTwin(ctx context.Context, deviceId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/iot/devices/"+segment(deviceId, false)+"/twin", nil, nil)
}

// PatchReported — Patch reported. [PATCH /api/iot/devices/{deviceId}/twin/reported].
func (a *IoTDeviceGatewayApi) PatchReported(ctx context.Context, deviceId string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "PATCH", "/api/iot/devices/"+segment(deviceId, false)+"/twin/reported", body, nil)
}

// PqComplete — Pq complete. [POST /api/iot/devices/{deviceId}/pq/complete].
func (a *IoTDeviceGatewayApi) PqComplete(ctx context.Context, deviceId string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/iot/devices/"+segment(deviceId, false)+"/pq/complete", body, nil)
}

// PqHandshake — Pq handshake. [POST /api/iot/devices/{deviceId}/pq/handshake].
func (a *IoTDeviceGatewayApi) PqHandshake(ctx context.Context, deviceId string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/iot/devices/"+segment(deviceId, false)+"/pq/handshake", body, nil)
}

// ReceiveCommands — Receive commands. [GET /api/iot/devices/{deviceId}/messages/devicebound].
func (a *IoTDeviceGatewayApi) ReceiveCommands(ctx context.Context, deviceId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/iot/devices/"+segment(deviceId, false)+"/messages/devicebound", nil, nil)
}

// SendTelemetry — Send telemetry. [POST /api/iot/devices/{deviceId}/messages/events].
func (a *IoTDeviceGatewayApi) SendTelemetry(ctx context.Context, deviceId string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/iot/devices/"+segment(deviceId, false)+"/messages/events", body, nil)
}

// Stream — Stream. [GET /api/iot/devices/{deviceId}/stream].
func (a *IoTDeviceGatewayApi) Stream(ctx context.Context, deviceId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/iot/devices/"+segment(deviceId, false)+"/stream", nil, nil)
}

// IoTHubApi holds the IoTHub operations.
type IoTHubApi struct{ c *Client }

// GetIoTHubs — Get io thubs. [GET /api/IoTHub/iothubs].
func (a *IoTHubApi) GetIoTHubs(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/IoTHub/iothubs", nil, nil)
}

// IoTHubDeviceApi holds the IoTHubDevice operations.
type IoTHubDeviceApi struct{ c *Client }

// GetIoTHubDevices — Get io thub devices. [GET /api/IoTHubDevice/iothub/devices].
func (a *IoTHubDeviceApi) GetIoTHubDevices(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/IoTHubDevice/iothub/devices", nil, nil)
}

// GetIoTHubDevicesGet — Get io thub devices get. [GET /api/IoTHubDevice/iothub/{iotHubId}/devices].
func (a *IoTHubDeviceApi) GetIoTHubDevicesGet(ctx context.Context, iotHubId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/IoTHubDevice/iothub/"+segment(iotHubId, false)+"/devices", nil, nil)
}

// IoTHubDiagnosticsApi holds the IoTHubDiagnostics operations.
type IoTHubDiagnosticsApi struct{ c *Client }

// CreateSetting — Create setting. [POST /api/iothub/{hubId}/diagnostic-settings].
func (a *IoTHubDiagnosticsApi) CreateSetting(ctx context.Context, hubId string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/iothub/"+segment(hubId, false)+"/diagnostic-settings", body, nil)
}

// DeleteSetting — Delete setting. [DELETE /api/iothub/{hubId}/diagnostic-settings/{id}].
func (a *IoTHubDiagnosticsApi) DeleteSetting(ctx context.Context, hubId string, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/iothub/"+segment(hubId, false)+"/diagnostic-settings/"+segment(id_, false), nil, nil)
}

// Destinations — Destinations. [GET /api/iothub/diagnostic-destinations].
func (a *IoTHubDiagnosticsApi) Destinations(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/iothub/diagnostic-destinations", nil, nil)
}

// ListSettings — List settings. [GET /api/iothub/{hubId}/diagnostic-settings].
func (a *IoTHubDiagnosticsApi) ListSettings(ctx context.Context, hubId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/iothub/"+segment(hubId, false)+"/diagnostic-settings", nil, nil)
}

// LogCategories — Log categories. [GET /api/iothub/log-categories].
func (a *IoTHubDiagnosticsApi) LogCategories(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/iothub/log-categories", nil, nil)
}

// Logs — Logs. [GET /api/iothub/{hubId}/logs]. Query keys: category, deviceId, limit.
func (a *IoTHubDiagnosticsApi) Logs(ctx context.Context, hubId string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/iothub/"+segment(hubId, false)+"/logs", nil, query)
}

// MetricDefinitions — Metric definitions. [GET /api/iothub/metric-definitions].
func (a *IoTHubDiagnosticsApi) MetricDefinitions(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/iothub/metric-definitions", nil, nil)
}

// Metrics — Metrics. [GET /api/iothub/{hubId}/metrics]. Query keys: hours, protocol.
func (a *IoTHubDiagnosticsApi) Metrics(ctx context.Context, hubId string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/iothub/"+segment(hubId, false)+"/metrics", nil, query)
}

// IoTHubManagementApi holds the IoTHubManagement operations.
type IoTHubManagementApi struct{ c *Client }

// ConnectionString — Connection string. [GET /api/iothub/{hubId}/devices/{deviceId}/connection-string].
func (a *IoTHubManagementApi) ConnectionString(ctx context.Context, hubId string, deviceId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/iothub/"+segment(hubId, false)+"/devices/"+segment(deviceId, false)+"/connection-string", nil, nil)
}

// CreateDevice — Create device. [POST /api/iothub/{hubId}/devices].
func (a *IoTHubManagementApi) CreateDevice(ctx context.Context, hubId string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/iothub/"+segment(hubId, false)+"/devices", body, nil)
}

// DeleteDevice — Delete device. [DELETE /api/iothub/{hubId}/devices/{deviceId}].
func (a *IoTHubManagementApi) DeleteDevice(ctx context.Context, hubId string, deviceId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/iothub/"+segment(hubId, false)+"/devices/"+segment(deviceId, false), nil, nil)
}

// DeleteHub — Delete hub. [DELETE /api/iothub/{hubId}].
func (a *IoTHubManagementApi) DeleteHub(ctx context.Context, hubId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/iothub/"+segment(hubId, false), nil, nil)
}

// GetTwin — Get twin. [GET /api/iothub/{hubId}/devices/{deviceId}/twin].
func (a *IoTHubManagementApi) GetTwin(ctx context.Context, hubId string, deviceId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/iothub/"+segment(hubId, false)+"/devices/"+segment(deviceId, false)+"/twin", nil, nil)
}

// Messages — Messages. [GET /api/iothub/{hubId}/devices/{deviceId}/messages]. Query keys: direction.
func (a *IoTHubManagementApi) Messages(ctx context.Context, hubId string, deviceId string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/iothub/"+segment(hubId, false)+"/devices/"+segment(deviceId, false)+"/messages", nil, query)
}

// Monitoring — Monitoring. [GET /api/iothub/{hubId}/monitoring].
func (a *IoTHubManagementApi) Monitoring(ctx context.Context, hubId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/iothub/"+segment(hubId, false)+"/monitoring", nil, nil)
}

// ReceiveC2D — Receive c2 d. [POST /api/iothub/{hubId}/devices/{deviceId}/c2d/receive].
func (a *IoTHubManagementApi) ReceiveC2D(ctx context.Context, hubId string, deviceId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/iothub/"+segment(hubId, false)+"/devices/"+segment(deviceId, false)+"/c2d/receive", nil, nil)
}

// RegenerateKey — Regenerate key. [POST /api/iothub/{hubId}/devices/{deviceId}/regenerate-key].
func (a *IoTHubManagementApi) RegenerateKey(ctx context.Context, hubId string, deviceId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/iothub/"+segment(hubId, false)+"/devices/"+segment(deviceId, false)+"/regenerate-key", nil, nil)
}

// SendC2D — Send c2 d. [POST /api/iothub/{hubId}/devices/{deviceId}/c2d].
func (a *IoTHubManagementApi) SendC2D(ctx context.Context, hubId string, deviceId string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/iothub/"+segment(hubId, false)+"/devices/"+segment(deviceId, false)+"/c2d", body, nil)
}

// SendTelemetry — Send telemetry. [POST /api/iothub/{hubId}/devices/{deviceId}/telemetry].
func (a *IoTHubManagementApi) SendTelemetry(ctx context.Context, hubId string, deviceId string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/iothub/"+segment(hubId, false)+"/devices/"+segment(deviceId, false)+"/telemetry", body, nil)
}

// UpdateTwin — Update twin. [PATCH /api/iothub/{hubId}/devices/{deviceId}/twin].
func (a *IoTHubManagementApi) UpdateTwin(ctx context.Context, hubId string, deviceId string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "PATCH", "/api/iothub/"+segment(hubId, false)+"/devices/"+segment(deviceId, false)+"/twin", body, nil)
}

// IoTHubProtocolApi holds the IoTHubProtocol operations.
type IoTHubProtocolApi struct{ c *Client }

// Algorithms — Algorithms. [GET /api/iothub/algorithms].
func (a *IoTHubProtocolApi) Algorithms(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/iothub/algorithms", nil, nil)
}

// CaCertificate — Ca certificate. [GET /api/iothub/{hubId}/ca].
func (a *IoTHubProtocolApi) CaCertificate(ctx context.Context, hubId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/iothub/"+segment(hubId, false)+"/ca", nil, nil)
}

// Certificates — Certificates. [GET /api/iothub/{hubId}/certificates].
func (a *IoTHubProtocolApi) Certificates(ctx context.Context, hubId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/iothub/"+segment(hubId, false)+"/certificates", nil, nil)
}

// Connections — Connections. [GET /api/iothub/{hubId}/connections].
func (a *IoTHubProtocolApi) Connections(ctx context.Context, hubId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/iothub/"+segment(hubId, false)+"/connections", nil, nil)
}

// IssueCertificate — Issue certificate. [POST /api/iothub/{hubId}/devices/{deviceId}/certificate].
func (a *IoTHubProtocolApi) IssueCertificate(ctx context.Context, hubId string, deviceId string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/iothub/"+segment(hubId, false)+"/devices/"+segment(deviceId, false)+"/certificate", body, nil)
}

// PqSessions — Pq sessions. [GET /api/iothub/{hubId}/pq-sessions].
func (a *IoTHubProtocolApi) PqSessions(ctx context.Context, hubId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/iothub/"+segment(hubId, false)+"/pq-sessions", nil, nil)
}

// Protocols — Protocols. [GET /api/iothub/protocols].
func (a *IoTHubProtocolApi) Protocols(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/iothub/protocols", nil, nil)
}

// Provision — Provision. [POST /api/iothub/{hubId}/provision].
func (a *IoTHubProtocolApi) Provision(ctx context.Context, hubId string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/iothub/"+segment(hubId, false)+"/provision", body, nil)
}

// K9sConsoleApi holds the K9sConsole operations.
type K9sConsoleApi struct{ c *Client }

// Console — Console. [GET /api/kubernetes/clusters/{id}/console].
func (a *K9sConsoleApi) Console(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/kubernetes/clusters/"+segment(id_, false)+"/console", nil, nil)
}

// Status — Status. [GET /api/kubernetes/clusters/{id}/console/status].
func (a *K9sConsoleApi) Status(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/kubernetes/clusters/"+segment(id_, false)+"/console/status", nil, nil)
}

// KeyVaultApi holds the KeyVault operations.
type KeyVaultApi struct{ c *Client }

// Create — Create. [POST /api/KeyVault].
func (a *KeyVaultApi) Create(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/KeyVault", body, nil)
}

// CreateCertificate — Create certificate. [POST /api/KeyVault/{id}/certificates].
func (a *KeyVaultApi) CreateCertificate(ctx context.Context, id_ string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/KeyVault/"+segment(id_, false)+"/certificates", body, nil)
}

// Delete — Delete. [DELETE /api/KeyVault/{id}].
func (a *KeyVaultApi) Delete(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/KeyVault/"+segment(id_, false), nil, nil)
}

// DeleteItem — Delete item. [DELETE /api/KeyVault/{id}/items/{name}].
func (a *KeyVaultApi) DeleteItem(ctx context.Context, id_ string, name string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/KeyVault/"+segment(id_, false)+"/items/"+segment(name, false), nil, nil)
}

// DownloadCsr — Download csr. [GET /api/KeyVault/{id}/certificates/{name}/csr].
func (a *KeyVaultApi) DownloadCsr(ctx context.Context, id_ string, name string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/KeyVault/"+segment(id_, false)+"/certificates/"+segment(name, false)+"/csr", nil, nil)
}

// ExportCertificate — Export certificate. [POST /api/KeyVault/{id}/certificates/{name}/export].
func (a *KeyVaultApi) ExportCertificate(ctx context.Context, id_ string, name string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/KeyVault/"+segment(id_, false)+"/certificates/"+segment(name, false)+"/export", body, nil)
}

// Get — Get. [GET /api/KeyVault/{id}].
func (a *KeyVaultApi) Get(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/KeyVault/"+segment(id_, false), nil, nil)
}

// GetItem — Get item. [GET /api/KeyVault/{id}/items/{name}]. Query keys: version.
func (a *KeyVaultApi) GetItem(ctx context.Context, id_ string, name string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/KeyVault/"+segment(id_, false)+"/items/"+segment(name, false), nil, query)
}

// List — List. [GET /api/KeyVault].
func (a *KeyVaultApi) List(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/KeyVault", nil, nil)
}

// ListDeleted — List deleted. [GET /api/KeyVault/deleted].
func (a *KeyVaultApi) ListDeleted(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/KeyVault/deleted", nil, nil)
}

// ListItems — List items. [GET /api/KeyVault/{id}/items]. Query keys: itemType, includeDeleted.
func (a *KeyVaultApi) ListItems(ctx context.Context, id_ string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/KeyVault/"+segment(id_, false)+"/items", nil, query)
}

// ListVersions — List versions. [GET /api/KeyVault/{id}/items/{name}/versions].
func (a *KeyVaultApi) ListVersions(ctx context.Context, id_ string, name string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/KeyVault/"+segment(id_, false)+"/items/"+segment(name, false)+"/versions", nil, nil)
}

// MergeCertificate — Merge certificate. [POST /api/KeyVault/{id}/certificates/{name}/merge].
func (a *KeyVaultApi) MergeCertificate(ctx context.Context, id_ string, name string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/KeyVault/"+segment(id_, false)+"/certificates/"+segment(name, false)+"/merge", body, nil)
}

// Purge — Purge. [DELETE /api/KeyVault/{id}/purge].
func (a *KeyVaultApi) Purge(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/KeyVault/"+segment(id_, false)+"/purge", nil, nil)
}

// Recover — Recover. [POST /api/KeyVault/{id}/recover].
func (a *KeyVaultApi) Recover(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/KeyVault/"+segment(id_, false)+"/recover", nil, nil)
}

// RecoverItem — Recover item. [POST /api/KeyVault/{id}/items/{name}/recover].
func (a *KeyVaultApi) RecoverItem(ctx context.Context, id_ string, name string) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/KeyVault/"+segment(id_, false)+"/items/"+segment(name, false)+"/recover", nil, nil)
}

// SetItem — Set item. [POST /api/KeyVault/{id}/items].
func (a *KeyVaultApi) SetItem(ctx context.Context, id_ string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/KeyVault/"+segment(id_, false)+"/items", body, nil)
}

// Update — Update. [PUT /api/KeyVault/{id}].
func (a *KeyVaultApi) Update(ctx context.Context, id_ string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "PUT", "/api/KeyVault/"+segment(id_, false), body, nil)
}

// UpdateItem — Update item. [PUT /api/KeyVault/{id}/items/{name}]. Query keys: version.
func (a *KeyVaultApi) UpdateItem(ctx context.Context, id_ string, name string, body any, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "PUT", "/api/KeyVault/"+segment(id_, false)+"/items/"+segment(name, false), body, query)
}

// KubernetesApi holds the Kubernetes operations.
type KubernetesApi struct{ c *Client }

// AddPool — Add pool. [POST /api/kubernetes/clusters/{id}/node-pools].
func (a *KubernetesApi) AddPool(ctx context.Context, id_ string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/kubernetes/clusters/"+segment(id_, false)+"/node-pools", body, nil)
}

// Cordon — Cordon. [POST /api/kubernetes/clusters/{id}/nodes/{name}/cordon]. Query keys: undo.
func (a *KubernetesApi) Cordon(ctx context.Context, id_ string, name string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/kubernetes/clusters/"+segment(id_, false)+"/nodes/"+segment(name, false)+"/cordon", nil, query)
}

// Create — Create. [POST /api/kubernetes/clusters].
func (a *KubernetesApi) Create(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/kubernetes/clusters", body, nil)
}

// Delete — Delete. [DELETE /api/kubernetes/clusters/{id}].
func (a *KubernetesApi) Delete(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/kubernetes/clusters/"+segment(id_, false), nil, nil)
}

// DeletePod — Delete pod. [DELETE /api/kubernetes/clusters/{id}/pods/{ns}/{name}].
func (a *KubernetesApi) DeletePod(ctx context.Context, id_ string, ns string, name string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/kubernetes/clusters/"+segment(id_, false)+"/pods/"+segment(ns, false)+"/"+segment(name, false), nil, nil)
}

// Get — Get. [GET /api/kubernetes/clusters/{id}].
func (a *KubernetesApi) Get(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/kubernetes/clusters/"+segment(id_, false), nil, nil)
}

// Kubeconfig — Kubeconfig. [GET /api/kubernetes/clusters/{id}/kubeconfig]. Query keys: external.
func (a *KubernetesApi) Kubeconfig(ctx context.Context, id_ string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/kubernetes/clusters/"+segment(id_, false)+"/kubeconfig", nil, query)
}

// Kubectl — Kubectl. [POST /api/kubernetes/clusters/{id}/kubectl].
func (a *KubernetesApi) Kubectl(ctx context.Context, id_ string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/kubernetes/clusters/"+segment(id_, false)+"/kubectl", body, nil)
}

// List — List. [GET /api/kubernetes/clusters].
func (a *KubernetesApi) List(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/kubernetes/clusters", nil, nil)
}

// RemovePool — Remove pool. [DELETE /api/kubernetes/clusters/{id}/node-pools/{poolId}].
func (a *KubernetesApi) RemovePool(ctx context.Context, id_ string, poolId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/kubernetes/clusters/"+segment(id_, false)+"/node-pools/"+segment(poolId, false), nil, nil)
}

// Resources — Resources. [GET /api/kubernetes/clusters/{id}/resources/{kind}]. Query keys: ns.
func (a *KubernetesApi) Resources(ctx context.Context, id_ string, kind string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/kubernetes/clusters/"+segment(id_, false)+"/resources/"+segment(kind, false), nil, query)
}

// RestartWorkload — Restart workload. [POST /api/kubernetes/clusters/{id}/workloads/{kind}/{ns}/{name}/restart].
func (a *KubernetesApi) RestartWorkload(ctx context.Context, id_ string, kind string, ns string, name string) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/kubernetes/clusters/"+segment(id_, false)+"/workloads/"+segment(kind, false)+"/"+segment(ns, false)+"/"+segment(name, false)+"/restart", nil, nil)
}

// Scale — Scale. [POST /api/kubernetes/clusters/{id}/workloads/{kind}/{ns}/{name}/scale].
func (a *KubernetesApi) Scale(ctx context.Context, id_ string, kind string, ns string, name string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/kubernetes/clusters/"+segment(id_, false)+"/workloads/"+segment(kind, false)+"/"+segment(ns, false)+"/"+segment(name, false)+"/scale", body, nil)
}

// MailAdminApi holds the MailAdmin operations.
type MailAdminApi struct{ c *Client }

// Accounts — Accounts. [GET /api/mail/admin/accounts].
func (a *MailAdminApi) Accounts(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/mail/admin/accounts", nil, nil)
}

// Create — Create. [POST /api/mail/admin/accounts].
func (a *MailAdminApi) Create(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/mail/admin/accounts", body, nil)
}

// Delete — Delete. [DELETE /api/mail/admin/accounts/{id}].
func (a *MailAdminApi) Delete(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/mail/admin/accounts/"+segment(id_, false), nil, nil)
}

// Domains — Domains. [GET /api/mail/admin/domains].
func (a *MailAdminApi) Domains(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/mail/admin/domains", nil, nil)
}

// Grant — Grant. [POST /api/mail/admin/accounts/{id}/access].
func (a *MailAdminApi) Grant(ctx context.Context, id_ string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/mail/admin/accounts/"+segment(id_, false)+"/access", body, nil)
}

// Revoke — Revoke. [DELETE /api/mail/admin/accounts/{id}/access/{emailId}].
func (a *MailAdminApi) Revoke(ctx context.Context, id_ string, emailId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/mail/admin/accounts/"+segment(id_, false)+"/access/"+segment(emailId, false), nil, nil)
}

// SetPassword — Set password. [POST /api/mail/admin/accounts/{id}/password].
func (a *MailAdminApi) SetPassword(ctx context.Context, id_ string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/mail/admin/accounts/"+segment(id_, false)+"/password", body, nil)
}

// Update — Update. [PATCH /api/mail/admin/accounts/{id}].
func (a *MailAdminApi) Update(ctx context.Context, id_ string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "PATCH", "/api/mail/admin/accounts/"+segment(id_, false), body, nil)
}

// MarketplaceApi holds the Marketplace operations.
type MarketplaceApi struct{ c *Client }

// Categories — Categories. [GET /api/Marketplace/categories].
func (a *MarketplaceApi) Categories(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Marketplace/categories", nil, nil)
}

// Connections — Connections. [GET /api/Marketplace/connections].
func (a *MarketplaceApi) Connections(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Marketplace/connections", nil, nil)
}

// DeleteDeployment — Delete deployment. [DELETE /api/Marketplace/deployments/{id}].
func (a *MarketplaceApi) DeleteDeployment(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/Marketplace/deployments/"+segment(id_, false), nil, nil)
}

// Deploy — Deploy. [POST /api/Marketplace/deploy].
func (a *MarketplaceApi) Deploy(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Marketplace/deploy", body, nil)
}

// Deployments — Deployments. [GET /api/Marketplace/deployments].
func (a *MarketplaceApi) Deployments(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Marketplace/deployments", nil, nil)
}

// Offer — Offer. [GET /api/Marketplace/offers/{slug}].
func (a *MarketplaceApi) Offer(ctx context.Context, slug string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Marketplace/offers/"+segment(slug, false), nil, nil)
}

// Offers — Offers. [GET /api/Marketplace/offers]. Query keys: search, category, source, delivery, featured, take.
func (a *MarketplaceApi) Offers(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Marketplace/offers", nil, query)
}

// Publish — Publish. [POST /api/Marketplace/offers].
func (a *MarketplaceApi) Publish(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Marketplace/offers", body, nil)
}

// SaveConnection — Save connection. [POST /api/Marketplace/connections].
func (a *MarketplaceApi) SaveConnection(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Marketplace/connections", body, nil)
}

// Sync — Sync. [POST /api/Marketplace/connections/{id}/sync].
func (a *MarketplaceApi) Sync(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Marketplace/connections/"+segment(id_, false)+"/sync", nil, nil)
}

// Unpublish — Unpublish. [DELETE /api/Marketplace/offers/{id}].
func (a *MarketplaceApi) Unpublish(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/Marketplace/offers/"+segment(id_, false), nil, nil)
}

// MetricsApi holds the Metrics operations.
type MetricsApi struct{ c *Client }

// Get — Get. [GET /api/metrics/{resourceId}].
func (a *MetricsApi) Get(ctx context.Context, resourceId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/metrics/"+segment(resourceId, false), nil, nil)
}

// GetFileOperationMetrics — Get file operation metrics. [GET /api/Metrics/storage/{storageAccountId}/operations]. Query keys: limit, region.
func (a *MetricsApi) GetFileOperationMetrics(ctx context.Context, storageAccountId string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Metrics/storage/"+segment(storageAccountId, false)+"/operations", nil, query)
}

// GetQuickStats — Get quick stats. [GET /api/Metrics/storage/{storageAccountId}/stats]. Query keys: region.
func (a *MetricsApi) GetQuickStats(ctx context.Context, storageAccountId string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Metrics/storage/"+segment(storageAccountId, false)+"/stats", nil, query)
}

// GetRequestMetrics — Get request metrics. [GET /api/Metrics/storage/{storageAccountId}/requests]. Query keys: range, region.
func (a *MetricsApi) GetRequestMetrics(ctx context.Context, storageAccountId string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Metrics/storage/"+segment(storageAccountId, false)+"/requests", nil, query)
}

// GetStorageMetrics — Get storage metrics. [GET /api/Metrics/storage/{storageAccountId}]. Query keys: range, region.
func (a *MetricsApi) GetStorageMetrics(ctx context.Context, storageAccountId string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Metrics/storage/"+segment(storageAccountId, false), nil, query)
}

// IngestStorageMetric — Ingest storage metric. [POST /api/Metrics/ingest/storage].
func (a *MetricsApi) IngestStorageMetric(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Metrics/ingest/storage", body, nil)
}

// MongoApi holds the Mongo operations.
type MongoApi struct{ c *Client }

// Collections — Collections. [GET /api/Mongo/{id}/databases/{database}/collections].
func (a *MongoApi) Collections(ctx context.Context, id_ string, database string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Mongo/"+segment(id_, false)+"/databases/"+segment(database, false)+"/collections", nil, nil)
}

// Connection — Connection. [GET /api/Mongo/{id}/connection].
func (a *MongoApi) Connection(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Mongo/"+segment(id_, false)+"/connection", nil, nil)
}

// Create — Create. [POST /api/Mongo].
func (a *MongoApi) Create(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Mongo", body, nil)
}

// Databases — Databases. [GET /api/Mongo/{id}/databases].
func (a *MongoApi) Databases(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Mongo/"+segment(id_, false)+"/databases", nil, nil)
}

// Delete — Delete. [DELETE /api/Mongo/{id}].
func (a *MongoApi) Delete(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/Mongo/"+segment(id_, false), nil, nil)
}

// Get — Get. [GET /api/Mongo/{id}].
func (a *MongoApi) Get(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Mongo/"+segment(id_, false), nil, nil)
}

// List — List. [GET /api/Mongo].
func (a *MongoApi) List(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Mongo", nil, nil)
}

// ReplicaStatus — Replica status. [GET /api/Mongo/{id}/replica-status].
func (a *MongoApi) ReplicaStatus(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Mongo/"+segment(id_, false)+"/replica-status", nil, nil)
}

// RunCommand — Run command. [POST /api/Mongo/{id}/command].
func (a *MongoApi) RunCommand(ctx context.Context, id_ string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Mongo/"+segment(id_, false)+"/command", body, nil)
}

// SetConsistency — Set consistency. [PUT /api/Mongo/{id}/consistency].
func (a *MongoApi) SetConsistency(ctx context.Context, id_ string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "PUT", "/api/Mongo/"+segment(id_, false)+"/consistency", body, nil)
}

// Start — Start. [POST /api/Mongo/{id}/start].
func (a *MongoApi) Start(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Mongo/"+segment(id_, false)+"/start", nil, nil)
}

// Stop — Stop. [POST /api/Mongo/{id}/stop].
func (a *MongoApi) Stop(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Mongo/"+segment(id_, false)+"/stop", nil, nil)
}

// MySqlDatabaseApi holds the MySqlDatabase operations.
type MySqlDatabaseApi struct{ c *Client }

// Columns — Columns. [GET /api/MySqlDatabase/{id}/objects/{schema}/{table}/columns]. Query keys: database.
func (a *MySqlDatabaseApi) Columns(ctx context.Context, id_ string, schema string, table string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/MySqlDatabase/"+segment(id_, false)+"/objects/"+segment(schema, false)+"/"+segment(table, false)+"/columns", nil, query)
}

// Connection — Connection. [GET /api/MySqlDatabase/{id}/connection].
func (a *MySqlDatabaseApi) Connection(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/MySqlDatabase/"+segment(id_, false)+"/connection", nil, nil)
}

// Create — Create. [POST /api/MySqlDatabase].
func (a *MySqlDatabaseApi) Create(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/MySqlDatabase", body, nil)
}

// Databases — Databases. [GET /api/MySqlDatabase/{id}/databases].
func (a *MySqlDatabaseApi) Databases(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/MySqlDatabase/"+segment(id_, false)+"/databases", nil, nil)
}

// Delete — Delete. [DELETE /api/MySqlDatabase/{id}].
func (a *MySqlDatabaseApi) Delete(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/MySqlDatabase/"+segment(id_, false), nil, nil)
}

// Get — Get. [GET /api/MySqlDatabase/{id}].
func (a *MySqlDatabaseApi) Get(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/MySqlDatabase/"+segment(id_, false), nil, nil)
}

// List — List. [GET /api/MySqlDatabase].
func (a *MySqlDatabaseApi) List(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/MySqlDatabase", nil, nil)
}

// Objects — Objects. [GET /api/MySqlDatabase/{id}/objects]. Query keys: database.
func (a *MySqlDatabaseApi) Objects(ctx context.Context, id_ string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/MySqlDatabase/"+segment(id_, false)+"/objects", nil, query)
}

// Query — Query. [POST /api/MySqlDatabase/{id}/query].
func (a *MySqlDatabaseApi) Query(ctx context.Context, id_ string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/MySqlDatabase/"+segment(id_, false)+"/query", body, nil)
}

// ResetPassword — Reset password. [POST /api/MySqlDatabase/{id}/reset-password].
func (a *MySqlDatabaseApi) ResetPassword(ctx context.Context, id_ string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/MySqlDatabase/"+segment(id_, false)+"/reset-password", body, nil)
}

// NetworkAccessApi holds the NetworkAccess operations.
type NetworkAccessApi struct{ c *Client }

// CreateEndpoint — Create endpoint. [POST /api/network-access/{resourceType}/{resourceId}/private-endpoints].
func (a *NetworkAccessApi) CreateEndpoint(ctx context.Context, resourceType string, resourceId string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/network-access/"+segment(resourceType, false)+"/"+segment(resourceId, false)+"/private-endpoints", body, nil)
}

// DeleteEndpoint — Delete endpoint. [DELETE /api/network-access/{resourceType}/{resourceId}/private-endpoints/{id}].
func (a *NetworkAccessApi) DeleteEndpoint(ctx context.Context, resourceType string, resourceId string, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/network-access/"+segment(resourceType, false)+"/"+segment(resourceId, false)+"/private-endpoints/"+segment(id_, false), nil, nil)
}

// Get — Get. [GET /api/network-access/{resourceType}/{resourceId}].
func (a *NetworkAccessApi) Get(ctx context.Context, resourceType string, resourceId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/network-access/"+segment(resourceType, false)+"/"+segment(resourceId, false), nil, nil)
}

// ListEndpoints — List endpoints. [GET /api/network-access/{resourceType}/{resourceId}/private-endpoints].
func (a *NetworkAccessApi) ListEndpoints(ctx context.Context, resourceType string, resourceId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/network-access/"+segment(resourceType, false)+"/"+segment(resourceId, false)+"/private-endpoints", nil, nil)
}

// Set — Set. [PUT /api/network-access/{resourceType}/{resourceId}].
func (a *NetworkAccessApi) Set(ctx context.Context, resourceType string, resourceId string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "PUT", "/api/network-access/"+segment(resourceType, false)+"/"+segment(resourceId, false), body, nil)
}

// SourcePresets — Source presets. [GET /api/network-access/source-presets]. Query keys: resourceType, resourceId.
func (a *NetworkAccessApi) SourcePresets(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/network-access/source-presets", nil, query)
}

// NotificationApi holds the Notification operations.
type NotificationApi struct{ c *Client }

// GetNotification — Get notification. [GET /api/Notification/notification].
func (a *NotificationApi) GetNotification(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Notification/notification", nil, nil)
}

// OAuthApi holds the OAuth operations.
type OAuthApi struct{ c *Client }

// GetClientToken — Get client token. [POST /api/OAuth/token/client].
func (a *OAuthApi) GetClientToken(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/OAuth/token/client", body, nil)
}

// GetToken — Get token. [POST /api/OAuth/token]. Query keys: handoff.
func (a *OAuthApi) GetToken(ctx context.Context, body any, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/OAuth/token", body, query)
}

// RedeemHandoff — Redeem handoff. [POST /api/OAuth/handoff/redeem].
func (a *OAuthApi) RedeemHandoff(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/OAuth/handoff/redeem", body, nil)
}

// OVSApi holds the OVS operations.
type OVSApi struct{ c *Client }

// AddPort — Add port. [POST /api/OVS/bridges/{bridgeId}/ports].
func (a *OVSApi) AddPort(ctx context.Context, bridgeId string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/OVS/bridges/"+segment(bridgeId, false)+"/ports", body, nil)
}

// CreateBridge — Create bridge. [POST /api/OVS/bridges].
func (a *OVSApi) CreateBridge(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/OVS/bridges", body, nil)
}

// DeleteBridge — Delete bridge. [DELETE /api/OVS/bridges/{bridgeId}].
func (a *OVSApi) DeleteBridge(ctx context.Context, bridgeId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/OVS/bridges/"+segment(bridgeId, false), nil, nil)
}

// DeletePort — Delete port. [DELETE /api/OVS/bridges/{bridgeId}/ports/{portName}].
func (a *OVSApi) DeletePort(ctx context.Context, bridgeId string, portName string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/OVS/bridges/"+segment(bridgeId, false)+"/ports/"+segment(portName, false), nil, nil)
}

// GetBridge — Get bridge. [GET /api/OVS/bridges/{bridgeId}].
func (a *OVSApi) GetBridge(ctx context.Context, bridgeId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/OVS/bridges/"+segment(bridgeId, false), nil, nil)
}

// ListBridges — List bridges. [GET /api/OVS/bridges].
func (a *OVSApi) ListBridges(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/OVS/bridges", nil, nil)
}

// OidcApi holds the Oidc operations.
type OidcApi struct{ c *Client }

// Approve — Approve. [POST /api/hiok-id/oidc/authorize].
func (a *OidcApi) Approve(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/hiok-id/oidc/authorize", body, nil)
}

// Authorize — Authorize. [GET /api/hiok-id/oidc/authorize]. Query keys: client_id, redirect_uri, response_type.
func (a *OidcApi) Authorize(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/hiok-id/oidc/authorize", nil, query)
}

// AuthorizeInfo — Authorize info. [GET /api/hiok-id/oidc/authorize/info]. Query keys: client_id, redirect_uri.
func (a *OidcApi) AuthorizeInfo(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/hiok-id/oidc/authorize/info", nil, query)
}

// Discovery — Discovery. [GET /api/hiok-id/oidc/.well-known/openid-configuration].
func (a *OidcApi) Discovery(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/hiok-id/oidc/.well-known/openid-configuration", nil, nil)
}

// Jwks — Jwks. [GET /api/hiok-id/oidc/jwks].
func (a *OidcApi) Jwks(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/hiok-id/oidc/jwks", nil, nil)
}

// Token — Token. [POST /api/hiok-id/oidc/token].
func (a *OidcApi) Token(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/hiok-id/oidc/token", body, nil)
}

// UserInfo — User info. [GET /api/hiok-id/oidc/userinfo].
func (a *OidcApi) UserInfo(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/hiok-id/oidc/userinfo", nil, nil)
}

// PanelApi holds the Panel operations.
type PanelApi struct{ c *Client }

// CreatePanel — Create panel. [POST /api/Panel/createpanel].
func (a *PanelApi) CreatePanel(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Panel/createpanel", body, nil)
}

// DeletePanel — Delete panel. [DELETE /api/Panel/deletepanel/{id}].
func (a *PanelApi) DeletePanel(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/Panel/deletepanel/"+segment(id_, false), nil, nil)
}

// GetPanels — Get panels. [GET /api/Panel/panels].
func (a *PanelApi) GetPanels(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Panel/panels", nil, nil)
}

// PanelById — Panel by id. [GET /api/Panel/panel/{id}].
func (a *PanelApi) PanelById(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Panel/panel/"+segment(id_, false), nil, nil)
}

// UpdatePanel — Update panel. [PUT /api/Panel/updatepanel/{id}].
func (a *PanelApi) UpdatePanel(ctx context.Context, id_ string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "PUT", "/api/Panel/updatepanel/"+segment(id_, false), body, nil)
}

// PostgresDatabaseApi holds the PostgresDatabase operations.
type PostgresDatabaseApi struct{ c *Client }

// Columns — Columns. [GET /api/PostgresDatabase/{id}/objects/{schema}/{table}/columns]. Query keys: database.
func (a *PostgresDatabaseApi) Columns(ctx context.Context, id_ string, schema string, table string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/PostgresDatabase/"+segment(id_, false)+"/objects/"+segment(schema, false)+"/"+segment(table, false)+"/columns", nil, query)
}

// Connection — Connection. [GET /api/PostgresDatabase/{id}/connection].
func (a *PostgresDatabaseApi) Connection(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/PostgresDatabase/"+segment(id_, false)+"/connection", nil, nil)
}

// Create — Create. [POST /api/PostgresDatabase].
func (a *PostgresDatabaseApi) Create(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/PostgresDatabase", body, nil)
}

// Databases — Databases. [GET /api/PostgresDatabase/{id}/databases].
func (a *PostgresDatabaseApi) Databases(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/PostgresDatabase/"+segment(id_, false)+"/databases", nil, nil)
}

// Delete — Delete. [DELETE /api/PostgresDatabase/{id}].
func (a *PostgresDatabaseApi) Delete(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/PostgresDatabase/"+segment(id_, false), nil, nil)
}

// Get — Get. [GET /api/PostgresDatabase/{id}].
func (a *PostgresDatabaseApi) Get(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/PostgresDatabase/"+segment(id_, false), nil, nil)
}

// List — List. [GET /api/PostgresDatabase].
func (a *PostgresDatabaseApi) List(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/PostgresDatabase", nil, nil)
}

// Objects — Objects. [GET /api/PostgresDatabase/{id}/objects]. Query keys: database.
func (a *PostgresDatabaseApi) Objects(ctx context.Context, id_ string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/PostgresDatabase/"+segment(id_, false)+"/objects", nil, query)
}

// Query — Query. [POST /api/PostgresDatabase/{id}/query].
func (a *PostgresDatabaseApi) Query(ctx context.Context, id_ string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/PostgresDatabase/"+segment(id_, false)+"/query", body, nil)
}

// ResetPassword — Reset password. [POST /api/PostgresDatabase/{id}/reset-password].
func (a *PostgresDatabaseApi) ResetPassword(ctx context.Context, id_ string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/PostgresDatabase/"+segment(id_, false)+"/reset-password", body, nil)
}

// PricingApi holds the Pricing operations.
type PricingApi struct{ c *Client }

// List — List. [GET /api/Pricing].
func (a *PricingApi) List(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Pricing", nil, nil)
}

// RateCard — Rate card. [GET /api/Pricing/ratecard].
func (a *PricingApi) RateCard(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Pricing/ratecard", nil, nil)
}

// Update — Update. [PUT /api/Pricing].
func (a *PricingApi) Update(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "PUT", "/api/Pricing", body, nil)
}

// ProfileApi holds the Profile operations.
type ProfileApi struct{ c *Client }

// ApiKeys — Api keys. [GET /api/profile/api-keys].
func (a *ProfileApi) ApiKeys(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/profile/api-keys", nil, nil)
}

// Get — Get. [GET /api/profile].
func (a *ProfileApi) Get(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/profile", nil, nil)
}

// RollKey — Roll key. [POST /api/profile/api-keys/{which}/roll].
func (a *ProfileApi) RollKey(ctx context.Context, which string) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/profile/api-keys/"+segment(which, false)+"/roll", nil, nil)
}

// Update — Update. [PUT /api/profile].
func (a *ProfileApi) Update(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "PUT", "/api/profile", body, nil)
}

// PulseApi holds the Pulse operations.
type PulseApi struct{ c *Client }

// CreateConsumerGroup — Create consumer group. [POST /api/Pulse/namespaces/{id}/streams/{stream}/consumer-groups].
func (a *PulseApi) CreateConsumerGroup(ctx context.Context, id_ string, stream string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Pulse/namespaces/"+segment(id_, false)+"/streams/"+segment(stream, false)+"/consumer-groups", body, nil)
}

// CreateEventSubscription — Create event subscription. [POST /api/Pulse/namespaces/{id}/streams/{stream}/subscriptions].
func (a *PulseApi) CreateEventSubscription(ctx context.Context, id_ string, stream string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Pulse/namespaces/"+segment(id_, false)+"/streams/"+segment(stream, false)+"/subscriptions", body, nil)
}

// CreateNamespace — Create namespace. [POST /api/Pulse/namespaces].
func (a *PulseApi) CreateNamespace(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Pulse/namespaces", body, nil)
}

// CreateStream — Create stream. [POST /api/Pulse/namespaces/{id}/streams].
func (a *PulseApi) CreateStream(ctx context.Context, id_ string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Pulse/namespaces/"+segment(id_, false)+"/streams", body, nil)
}

// DeleteConsumerGroup — Delete consumer group. [DELETE /api/Pulse/namespaces/{id}/streams/{stream}/consumer-groups/{name}].
func (a *PulseApi) DeleteConsumerGroup(ctx context.Context, id_ string, stream string, name string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/Pulse/namespaces/"+segment(id_, false)+"/streams/"+segment(stream, false)+"/consumer-groups/"+segment(name, false), nil, nil)
}

// DeleteEventSubscription — Delete event subscription. [DELETE /api/Pulse/namespaces/{id}/streams/{stream}/subscriptions/{name}].
func (a *PulseApi) DeleteEventSubscription(ctx context.Context, id_ string, stream string, name string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/Pulse/namespaces/"+segment(id_, false)+"/streams/"+segment(stream, false)+"/subscriptions/"+segment(name, false), nil, nil)
}

// DeleteNamespace — Delete namespace. [DELETE /api/Pulse/namespaces/{id}].
func (a *PulseApi) DeleteNamespace(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/Pulse/namespaces/"+segment(id_, false), nil, nil)
}

// DeleteStream — Delete stream. [DELETE /api/Pulse/namespaces/{id}/streams/{name}].
func (a *PulseApi) DeleteStream(ctx context.Context, id_ string, name string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/Pulse/namespaces/"+segment(id_, false)+"/streams/"+segment(name, false), nil, nil)
}

// ListConsumerGroups — List consumer groups. [GET /api/Pulse/namespaces/{id}/streams/{stream}/consumer-groups].
func (a *PulseApi) ListConsumerGroups(ctx context.Context, id_ string, stream string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Pulse/namespaces/"+segment(id_, false)+"/streams/"+segment(stream, false)+"/consumer-groups", nil, nil)
}

// ListDeliveries — List deliveries. [GET /api/Pulse/namespaces/{id}/streams/{stream}/subscriptions/{name}/deliveries]. Query keys: limit.
func (a *PulseApi) ListDeliveries(ctx context.Context, id_ string, stream string, name string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Pulse/namespaces/"+segment(id_, false)+"/streams/"+segment(stream, false)+"/subscriptions/"+segment(name, false)+"/deliveries", nil, query)
}

// ListEventSubscriptions — List event subscriptions. [GET /api/Pulse/namespaces/{id}/streams/{stream}/subscriptions].
func (a *PulseApi) ListEventSubscriptions(ctx context.Context, id_ string, stream string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Pulse/namespaces/"+segment(id_, false)+"/streams/"+segment(stream, false)+"/subscriptions", nil, nil)
}

// ListNamespaces — List namespaces. [GET /api/Pulse/namespaces].
func (a *PulseApi) ListNamespaces(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Pulse/namespaces", nil, nil)
}

// ListStreams — List streams. [GET /api/Pulse/namespaces/{id}/streams].
func (a *PulseApi) ListStreams(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Pulse/namespaces/"+segment(id_, false)+"/streams", nil, nil)
}

// Publish — Publish. [POST /api/Pulse/namespaces/{id}/streams/{stream}/events].
func (a *PulseApi) Publish(ctx context.Context, id_ string, stream string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Pulse/namespaces/"+segment(id_, false)+"/streams/"+segment(stream, false)+"/events", body, nil)
}

// Read — Read. [POST /api/Pulse/namespaces/{id}/streams/{stream}/events/read]. Query keys: consumerGroup, maxEvents.
func (a *PulseApi) Read(ctx context.Context, id_ string, stream string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Pulse/namespaces/"+segment(id_, false)+"/streams/"+segment(stream, false)+"/events/read", nil, query)
}

// RecentResourcesApi holds the RecentResources operations.
type RecentResourcesApi struct{ c *Client }

// Clear — Clear. [DELETE /api/recent-resources]. Query keys: id.
func (a *RecentResourcesApi) Clear(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/recent-resources", nil, query)
}

// List — List. [GET /api/recent-resources].
func (a *RecentResourcesApi) List(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/recent-resources", nil, nil)
}

// Record — Record. [POST /api/recent-resources].
func (a *RecentResourcesApi) Record(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/recent-resources", body, nil)
}

// ToggleFavourite — Toggle favourite. [POST /api/recent-resources/favourite].
func (a *RecentResourcesApi) ToggleFavourite(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/recent-resources/favourite", body, nil)
}

// ResourceGovernanceApi holds the ResourceGovernance operations.
type ResourceGovernanceApi struct{ c *Client }

// CreateLock — Create lock. [POST /api/resource-governance/{resourceType}/{resourceId}/locks].
func (a *ResourceGovernanceApi) CreateLock(ctx context.Context, resourceType string, resourceId string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/resource-governance/"+segment(resourceType, false)+"/"+segment(resourceId, false)+"/locks", body, nil)
}

// DeleteLock — Delete lock. [DELETE /api/resource-governance/{resourceType}/{resourceId}/locks/{lockId}].
func (a *ResourceGovernanceApi) DeleteLock(ctx context.Context, resourceType string, resourceId string, lockId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/resource-governance/"+segment(resourceType, false)+"/"+segment(resourceId, false)+"/locks/"+segment(lockId, false), nil, nil)
}

// Estate — Estate. [GET /api/resource-governance/estate].
func (a *ResourceGovernanceApi) Estate(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/resource-governance/estate", nil, nil)
}

// GetActivityLog — Get activity log. [GET /api/resource-governance/{resourceType}/{resourceId}/activity-log]. Query keys: limit.
func (a *ResourceGovernanceApi) GetActivityLog(ctx context.Context, resourceType string, resourceId string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/resource-governance/"+segment(resourceType, false)+"/"+segment(resourceId, false)+"/activity-log", nil, query)
}

// GetProperties — Get properties. [GET /api/resource-governance/{resourceType}/{resourceId}/properties].
func (a *ResourceGovernanceApi) GetProperties(ctx context.Context, resourceType string, resourceId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/resource-governance/"+segment(resourceType, false)+"/"+segment(resourceId, false)+"/properties", nil, nil)
}

// GetTenantActivity — Get tenant activity. [GET /api/resource-governance/activity]. Query keys: mine, resourceType, status, hours, limit.
func (a *ResourceGovernanceApi) GetTenantActivity(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/resource-governance/activity", nil, query)
}

// ListLocks — List locks. [GET /api/resource-governance/{resourceType}/{resourceId}/locks]. Query keys: includeInherited.
func (a *ResourceGovernanceApi) ListLocks(ctx context.Context, resourceType string, resourceId string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/resource-governance/"+segment(resourceType, false)+"/"+segment(resourceId, false)+"/locks", nil, query)
}

// Scopes — Scopes. [GET /api/resource-governance/scopes]. Query keys: ids.
func (a *ResourceGovernanceApi) Scopes(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/resource-governance/scopes", nil, query)
}

// UpdateTags — Update tags. [PUT /api/resource-governance/{resourceType}/{resourceId}/tags].
func (a *ResourceGovernanceApi) UpdateTags(ctx context.Context, resourceType string, resourceId string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "PUT", "/api/resource-governance/"+segment(resourceType, false)+"/"+segment(resourceId, false)+"/tags", body, nil)
}

// ResourceGroupsApi holds the ResourceGroups operations.
type ResourceGroupsApi struct{ c *Client }

// CreateResourceGroup — Create resource group. [POST /api/resourcegroups].
func (a *ResourceGroupsApi) CreateResourceGroup(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/resourcegroups", body, nil)
}

// DeleteResourceGroup — Delete resource group. [DELETE /api/resourcegroups/{id}].
func (a *ResourceGroupsApi) DeleteResourceGroup(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/resourcegroups/"+segment(id_, false), nil, nil)
}

// ListResourceGroups — List resource groups. [GET /api/resourcegroups].
func (a *ResourceGroupsApi) ListResourceGroups(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/resourcegroups", nil, nil)
}

// ResourceMetricsApi holds the ResourceMetrics operations.
type ResourceMetricsApi struct{ c *Client }

// Api — Api. [GET /api/resource-metrics/api]. Query keys: from, to, route.
func (a *ResourceMetricsApi) Api(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/resource-metrics/api", nil, query)
}

// Catalogue — Catalogue. [GET /api/resource-metrics/catalogue].
func (a *ResourceMetricsApi) Catalogue(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/resource-metrics/catalogue", nil, nil)
}

// Collect — Collect. [POST /api/resource-metrics/collect]. Query keys: region.
func (a *ResourceMetricsApi) Collect(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/resource-metrics/collect", nil, query)
}

// Cost — Cost. [GET /api/resource-metrics/cost/{resourceKind}/{resourceName}]. Query keys: from, to, region.
func (a *ResourceMetricsApi) Cost(ctx context.Context, resourceKind string, resourceName string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/resource-metrics/cost/"+segment(resourceKind, false)+"/"+segment(resourceName, false), nil, query)
}

// CostTotals — Cost totals. [GET /api/resource-metrics/cost-totals]. Query keys: region, from, to.
func (a *ResourceMetricsApi) CostTotals(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/resource-metrics/cost-totals", nil, query)
}

// Reporting — Reporting. [GET /api/resource-metrics/reporting]. Query keys: region, resourceKind.
func (a *ResourceMetricsApi) Reporting(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/resource-metrics/reporting", nil, query)
}

// Series — Series. [GET /api/resource-metrics/{resourceKind}/{resourceName}]. Query keys: from, to, granularity, metrics, region.
func (a *ResourceMetricsApi) Series(ctx context.Context, resourceKind string, resourceName string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/resource-metrics/"+segment(resourceKind, false)+"/"+segment(resourceName, false), nil, query)
}

// ResourceOperationsApi holds the ResourceOperations operations.
type ResourceOperationsApi struct{ c *Client }

// Alerts — Alerts. [GET /api/resource-ops/{resourceType}/{resourceId}/alerts].
func (a *ResourceOperationsApi) Alerts(ctx context.Context, resourceType string, resourceId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/resource-ops/"+segment(resourceType, false)+"/"+segment(resourceId, false)+"/alerts", nil, nil)
}

// CloseSupport — Close support. [POST /api/resource-ops/support/{id}/close].
func (a *ResourceOperationsApi) CloseSupport(ctx context.Context, id_ string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/resource-ops/support/"+segment(id_, false)+"/close", body, nil)
}

// DeleteAlert — Delete alert. [DELETE /api/resource-ops/{resourceType}/{resourceId}/alerts/{id}].
func (a *ResourceOperationsApi) DeleteAlert(ctx context.Context, resourceType string, resourceId string, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/resource-ops/"+segment(resourceType, false)+"/"+segment(resourceId, false)+"/alerts/"+segment(id_, false), nil, nil)
}

// DeleteDiagnostic — Delete diagnostic. [DELETE /api/resource-ops/{resourceType}/{resourceId}/diagnostics/{id}].
func (a *ResourceOperationsApi) DeleteDiagnostic(ctx context.Context, resourceType string, resourceId string, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/resource-ops/"+segment(resourceType, false)+"/"+segment(resourceId, false)+"/diagnostics/"+segment(id_, false), nil, nil)
}

// DeleteTask — Delete task. [DELETE /api/resource-ops/{resourceType}/{resourceId}/tasks/{id}].
func (a *ResourceOperationsApi) DeleteTask(ctx context.Context, resourceType string, resourceId string, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/resource-ops/"+segment(resourceType, false)+"/"+segment(resourceId, false)+"/tasks/"+segment(id_, false), nil, nil)
}

// Diagnostics — Diagnostics. [GET /api/resource-ops/{resourceType}/{resourceId}/diagnostics].
func (a *ResourceOperationsApi) Diagnostics(ctx context.Context, resourceType string, resourceId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/resource-ops/"+segment(resourceType, false)+"/"+segment(resourceId, false)+"/diagnostics", nil, nil)
}

// Health — Health. [GET /api/resource-ops/{resourceType}/{resourceId}/health].
func (a *ResourceOperationsApi) Health(ctx context.Context, resourceType string, resourceId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/resource-ops/"+segment(resourceType, false)+"/"+segment(resourceId, false)+"/health", nil, nil)
}

// Logs — Logs. [GET /api/resource-ops/{resourceType}/{resourceId}/logs]. Query keys: tail.
func (a *ResourceOperationsApi) Logs(ctx context.Context, resourceType string, resourceId string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/resource-ops/"+segment(resourceType, false)+"/"+segment(resourceId, false)+"/logs", nil, query)
}

// RaiseSupport — Raise support. [POST /api/resource-ops/{resourceType}/{resourceId}/support].
func (a *ResourceOperationsApi) RaiseSupport(ctx context.Context, resourceType string, resourceId string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/resource-ops/"+segment(resourceType, false)+"/"+segment(resourceId, false)+"/support", body, nil)
}

// SaveAlert — Save alert. [POST /api/resource-ops/{resourceType}/{resourceId}/alerts].
func (a *ResourceOperationsApi) SaveAlert(ctx context.Context, resourceType string, resourceId string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/resource-ops/"+segment(resourceType, false)+"/"+segment(resourceId, false)+"/alerts", body, nil)
}

// SaveDiagnostic — Save diagnostic. [POST /api/resource-ops/{resourceType}/{resourceId}/diagnostics].
func (a *ResourceOperationsApi) SaveDiagnostic(ctx context.Context, resourceType string, resourceId string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/resource-ops/"+segment(resourceType, false)+"/"+segment(resourceId, false)+"/diagnostics", body, nil)
}

// SaveTask — Save task. [POST /api/resource-ops/{resourceType}/{resourceId}/tasks].
func (a *ResourceOperationsApi) SaveTask(ctx context.Context, resourceType string, resourceId string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/resource-ops/"+segment(resourceType, false)+"/"+segment(resourceId, false)+"/tasks", body, nil)
}

// State — State. [GET /api/resource-ops/{resourceType}/{resourceId}/state]. Query keys: name.
func (a *ResourceOperationsApi) State(ctx context.Context, resourceType string, resourceId string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/resource-ops/"+segment(resourceType, false)+"/"+segment(resourceId, false)+"/state", nil, query)
}

// Support — Support. [GET /api/resource-ops/{resourceType}/{resourceId}/support].
func (a *ResourceOperationsApi) Support(ctx context.Context, resourceType string, resourceId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/resource-ops/"+segment(resourceType, false)+"/"+segment(resourceId, false)+"/support", nil, nil)
}

// Tasks — Tasks. [GET /api/resource-ops/{resourceType}/{resourceId}/tasks].
func (a *ResourceOperationsApi) Tasks(ctx context.Context, resourceType string, resourceId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/resource-ops/"+segment(resourceType, false)+"/"+segment(resourceId, false)+"/tasks", nil, nil)
}

// Template — Template. [GET /api/resource-ops/{resourceType}/{resourceId}/template].
func (a *ResourceOperationsApi) Template(ctx context.Context, resourceType string, resourceId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/resource-ops/"+segment(resourceType, false)+"/"+segment(resourceId, false)+"/template", nil, nil)
}

// UpdateAlert — Update alert. [PUT /api/resource-ops/{resourceType}/{resourceId}/alerts/{id}].
func (a *ResourceOperationsApi) UpdateAlert(ctx context.Context, resourceType string, resourceId string, id_ string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "PUT", "/api/resource-ops/"+segment(resourceType, false)+"/"+segment(resourceId, false)+"/alerts/"+segment(id_, false), body, nil)
}

// UpdateTask — Update task. [PUT /api/resource-ops/{resourceType}/{resourceId}/tasks/{id}].
func (a *ResourceOperationsApi) UpdateTask(ctx context.Context, resourceType string, resourceId string, id_ string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "PUT", "/api/resource-ops/"+segment(resourceType, false)+"/"+segment(resourceId, false)+"/tasks/"+segment(id_, false), body, nil)
}

// SandboxApi holds the Sandbox operations.
type SandboxApi struct{ c *Client }

// Create — Create. [POST /api/Sandbox].
func (a *SandboxApi) Create(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Sandbox", body, nil)
}

// CreateAndDownload — Create and download. [POST /api/Sandbox/download].
func (a *SandboxApi) CreateAndDownload(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Sandbox/download", body, nil)
}

// Reap — Reap. [POST /api/Sandbox/reap].
func (a *SandboxApi) Reap(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Sandbox/reap", nil, nil)
}

// Regions — Regions. [GET /api/Sandbox/regions].
func (a *SandboxApi) Regions(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Sandbox/regions", nil, nil)
}

// SearchApi holds the Search operations.
type SearchApi struct{ c *Client }

// Search — Search. [GET /api/search]. Query keys: q, type, region, status, limit.
func (a *SearchApi) Search(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/search", nil, query)
}

// ServiceBusApi holds the ServiceBus operations.
type ServiceBusApi struct{ c *Client }

// CreateNamespace — Create namespace. [POST /api/ServiceBus/namespaces].
func (a *ServiceBusApi) CreateNamespace(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/ServiceBus/namespaces", body, nil)
}

// CreateQueue — Create queue. [POST /api/ServiceBus/namespaces/{id}/queues].
func (a *ServiceBusApi) CreateQueue(ctx context.Context, id_ string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/ServiceBus/namespaces/"+segment(id_, false)+"/queues", body, nil)
}

// CreateRule — Create rule. [POST /api/ServiceBus/namespaces/{id}/topics/{topicName}/subscriptions/{subscriptionName}/rules].
func (a *ServiceBusApi) CreateRule(ctx context.Context, id_ string, topicName string, subscriptionName string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/ServiceBus/namespaces/"+segment(id_, false)+"/topics/"+segment(topicName, false)+"/subscriptions/"+segment(subscriptionName, false)+"/rules", body, nil)
}

// CreateSubscription — Create subscription. [POST /api/ServiceBus/namespaces/{id}/topics/{topicName}/subscriptions].
func (a *ServiceBusApi) CreateSubscription(ctx context.Context, id_ string, topicName string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/ServiceBus/namespaces/"+segment(id_, false)+"/topics/"+segment(topicName, false)+"/subscriptions", body, nil)
}

// CreateTopic — Create topic. [POST /api/ServiceBus/namespaces/{id}/topics].
func (a *ServiceBusApi) CreateTopic(ctx context.Context, id_ string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/ServiceBus/namespaces/"+segment(id_, false)+"/topics", body, nil)
}

// DeleteNamespace — Delete namespace. [DELETE /api/ServiceBus/namespaces/{id}].
func (a *ServiceBusApi) DeleteNamespace(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/ServiceBus/namespaces/"+segment(id_, false), nil, nil)
}

// DeleteQueue — Delete queue. [DELETE /api/ServiceBus/namespaces/{id}/queues/{name}].
func (a *ServiceBusApi) DeleteQueue(ctx context.Context, id_ string, name string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/ServiceBus/namespaces/"+segment(id_, false)+"/queues/"+segment(name, false), nil, nil)
}

// DeleteRule — Delete rule. [DELETE /api/ServiceBus/namespaces/{id}/topics/{topicName}/subscriptions/{subscriptionName}/rules/{ruleName}].
func (a *ServiceBusApi) DeleteRule(ctx context.Context, id_ string, topicName string, subscriptionName string, ruleName string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/ServiceBus/namespaces/"+segment(id_, false)+"/topics/"+segment(topicName, false)+"/subscriptions/"+segment(subscriptionName, false)+"/rules/"+segment(ruleName, false), nil, nil)
}

// DeleteSubscription — Delete subscription. [DELETE /api/ServiceBus/namespaces/{id}/topics/{topicName}/subscriptions/{subscriptionName}].
func (a *ServiceBusApi) DeleteSubscription(ctx context.Context, id_ string, topicName string, subscriptionName string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/ServiceBus/namespaces/"+segment(id_, false)+"/topics/"+segment(topicName, false)+"/subscriptions/"+segment(subscriptionName, false), nil, nil)
}

// DeleteTopic — Delete topic. [DELETE /api/ServiceBus/namespaces/{id}/topics/{name}].
func (a *ServiceBusApi) DeleteTopic(ctx context.Context, id_ string, name string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/ServiceBus/namespaces/"+segment(id_, false)+"/topics/"+segment(name, false), nil, nil)
}

// GetKeys — Get keys. [GET /api/ServiceBus/namespaces/{id}/keys].
func (a *ServiceBusApi) GetKeys(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/ServiceBus/namespaces/"+segment(id_, false)+"/keys", nil, nil)
}

// GetNamespace — Get namespace. [GET /api/ServiceBus/namespaces/{id}].
func (a *ServiceBusApi) GetNamespace(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/ServiceBus/namespaces/"+segment(id_, false), nil, nil)
}

// GetQueue — Get queue. [GET /api/ServiceBus/namespaces/{id}/queues/{name}].
func (a *ServiceBusApi) GetQueue(ctx context.Context, id_ string, name string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/ServiceBus/namespaces/"+segment(id_, false)+"/queues/"+segment(name, false), nil, nil)
}

// ListNamespaces — List namespaces. [GET /api/ServiceBus/namespaces]. Query keys: product.
func (a *ServiceBusApi) ListNamespaces(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/ServiceBus/namespaces", nil, query)
}

// ListQueues — List queues. [GET /api/ServiceBus/namespaces/{id}/queues].
func (a *ServiceBusApi) ListQueues(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/ServiceBus/namespaces/"+segment(id_, false)+"/queues", nil, nil)
}

// ListRules — List rules. [GET /api/ServiceBus/namespaces/{id}/topics/{topicName}/subscriptions/{subscriptionName}/rules].
func (a *ServiceBusApi) ListRules(ctx context.Context, id_ string, topicName string, subscriptionName string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/ServiceBus/namespaces/"+segment(id_, false)+"/topics/"+segment(topicName, false)+"/subscriptions/"+segment(subscriptionName, false)+"/rules", nil, nil)
}

// ListSubscriptions — List subscriptions. [GET /api/ServiceBus/namespaces/{id}/topics/{topicName}/subscriptions].
func (a *ServiceBusApi) ListSubscriptions(ctx context.Context, id_ string, topicName string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/ServiceBus/namespaces/"+segment(id_, false)+"/topics/"+segment(topicName, false)+"/subscriptions", nil, nil)
}

// ListTopics — List topics. [GET /api/ServiceBus/namespaces/{id}/topics].
func (a *ServiceBusApi) ListTopics(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/ServiceBus/namespaces/"+segment(id_, false)+"/topics", nil, nil)
}

// Peek — Peek. [POST /api/ServiceBus/namespaces/{id}/entities/{entity}/messages/peek]. Query keys: subscription, maxMessages.
func (a *ServiceBusApi) Peek(ctx context.Context, id_ string, entity string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/ServiceBus/namespaces/"+segment(id_, false)+"/entities/"+segment(entity, false)+"/messages/peek", nil, query)
}

// Receive — Receive. [POST /api/ServiceBus/namespaces/{id}/entities/{entity}/messages/receive]. Query keys: subscription.
func (a *ServiceBusApi) Receive(ctx context.Context, id_ string, entity string, body any, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/ServiceBus/namespaces/"+segment(id_, false)+"/entities/"+segment(entity, false)+"/messages/receive", body, query)
}

// ReceiveDeadLetter — Receive dead letter. [POST /api/ServiceBus/namespaces/{id}/entities/{entity}/deadletter/receive]. Query keys: subscription, maxMessages.
func (a *ServiceBusApi) ReceiveDeadLetter(ctx context.Context, id_ string, entity string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/ServiceBus/namespaces/"+segment(id_, false)+"/entities/"+segment(entity, false)+"/deadletter/receive", nil, query)
}

// RegenerateKey — Regenerate key. [POST /api/ServiceBus/namespaces/{id}/keys/{keyName}/regenerate]. Query keys: primary.
func (a *ServiceBusApi) RegenerateKey(ctx context.Context, id_ string, keyName string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/ServiceBus/namespaces/"+segment(id_, false)+"/keys/"+segment(keyName, false)+"/regenerate", nil, query)
}

// Runtime — Runtime. [GET /api/ServiceBus/namespaces/{id}/entities/{entity}/runtime]. Query keys: subscription.
func (a *ServiceBusApi) Runtime(ctx context.Context, id_ string, entity string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/ServiceBus/namespaces/"+segment(id_, false)+"/entities/"+segment(entity, false)+"/runtime", nil, query)
}

// Send — Send. [POST /api/ServiceBus/namespaces/{id}/entities/{entity}/messages].
func (a *ServiceBusApi) Send(ctx context.Context, id_ string, entity string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/ServiceBus/namespaces/"+segment(id_, false)+"/entities/"+segment(entity, false)+"/messages", body, nil)
}

// Settle — Settle. [POST /api/ServiceBus/namespaces/{id}/entities/{entity}/messages/settle]. Query keys: subscription.
func (a *ServiceBusApi) Settle(ctx context.Context, id_ string, entity string, body any, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/ServiceBus/namespaces/"+segment(id_, false)+"/entities/"+segment(entity, false)+"/messages/settle", body, query)
}

// UpdateQueue — Update queue. [PUT /api/ServiceBus/namespaces/{id}/queues/{name}].
func (a *ServiceBusApi) UpdateQueue(ctx context.Context, id_ string, name string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "PUT", "/api/ServiceBus/namespaces/"+segment(id_, false)+"/queues/"+segment(name, false), body, nil)
}

// SlackApi holds the Slack operations.
type SlackApi struct{ c *Client }

// Command — Command. [POST /api/integrations/slack/command].
func (a *SlackApi) Command(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/integrations/slack/command", nil, nil)
}

// ConfigInfo — Config info. [GET /api/integrations/slack/config].
func (a *SlackApi) ConfigInfo(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/integrations/slack/config", nil, nil)
}

// Install — Install. [GET /api/integrations/slack/install].
func (a *SlackApi) Install(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/integrations/slack/install", nil, nil)
}

// Link — Link. [POST /api/integrations/slack/link].
func (a *SlackApi) Link(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/integrations/slack/link", body, nil)
}

// OAuth — OAuth. [GET /api/integrations/slack/oauth]. Query keys: code, state, error.
func (a *SlackApi) OAuth(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/integrations/slack/oauth", nil, query)
}

// SqlServerDatabaseApi holds the SqlServerDatabase operations.
type SqlServerDatabaseApi struct{ c *Client }

// Columns — Columns. [GET /api/SqlServerDatabase/{id}/objects/{schema}/{table}/columns]. Query keys: database.
func (a *SqlServerDatabaseApi) Columns(ctx context.Context, id_ string, schema string, table string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/SqlServerDatabase/"+segment(id_, false)+"/objects/"+segment(schema, false)+"/"+segment(table, false)+"/columns", nil, query)
}

// Connection — Connection. [GET /api/SqlServerDatabase/{id}/connection].
func (a *SqlServerDatabaseApi) Connection(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/SqlServerDatabase/"+segment(id_, false)+"/connection", nil, nil)
}

// Create — Create. [POST /api/SqlServerDatabase].
func (a *SqlServerDatabaseApi) Create(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/SqlServerDatabase", body, nil)
}

// Databases — Databases. [GET /api/SqlServerDatabase/{id}/databases].
func (a *SqlServerDatabaseApi) Databases(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/SqlServerDatabase/"+segment(id_, false)+"/databases", nil, nil)
}

// Delete — Delete. [DELETE /api/SqlServerDatabase/{id}].
func (a *SqlServerDatabaseApi) Delete(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/SqlServerDatabase/"+segment(id_, false), nil, nil)
}

// Get — Get. [GET /api/SqlServerDatabase/{id}].
func (a *SqlServerDatabaseApi) Get(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/SqlServerDatabase/"+segment(id_, false), nil, nil)
}

// List — List. [GET /api/SqlServerDatabase].
func (a *SqlServerDatabaseApi) List(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/SqlServerDatabase", nil, nil)
}

// Objects — Objects. [GET /api/SqlServerDatabase/{id}/objects]. Query keys: database.
func (a *SqlServerDatabaseApi) Objects(ctx context.Context, id_ string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/SqlServerDatabase/"+segment(id_, false)+"/objects", nil, query)
}

// Query — Query. [POST /api/SqlServerDatabase/{id}/query].
func (a *SqlServerDatabaseApi) Query(ctx context.Context, id_ string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/SqlServerDatabase/"+segment(id_, false)+"/query", body, nil)
}

// ResetPassword — Reset password. [POST /api/SqlServerDatabase/{id}/reset-password].
func (a *SqlServerDatabaseApi) ResetPassword(ctx context.Context, id_ string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/SqlServerDatabase/"+segment(id_, false)+"/reset-password", body, nil)
}

// StorageApi holds the Storage operations.
type StorageApi struct{ c *Client }

// BucketFilesandDirectories — Bucket filesand directories. [POST /api/Storage/bucketfilesanddirectories]. Query keys: directory, type.
func (a *StorageApi) BucketFilesandDirectories(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Storage/bucketfilesanddirectories", nil, query)
}

// CreateFile — Create file. [POST /api/Storage/createfile]. Query keys: path, filename.
func (a *StorageApi) CreateFile(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Storage/createfile", nil, query)
}

// CreateFolder — Create folder. [POST /api/Storage/createfolder]. Query keys: path, foldername.
func (a *StorageApi) CreateFolder(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Storage/createfolder", nil, query)
}

// DeleteFile — Delete file. [POST /api/Storage/deletefile]. Query keys: path.
func (a *StorageApi) DeleteFile(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Storage/deletefile", nil, query)
}

// DeleteFolder — Delete folder. [POST /api/Storage/deletefolder]. Query keys: path.
func (a *StorageApi) DeleteFolder(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Storage/deletefolder", nil, query)
}

// FileCopyTo — File copy to. [POST /api/Storage/filecopyto]. Query keys: sourcePath, destinationPath.
func (a *StorageApi) FileCopyTo(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Storage/filecopyto", nil, query)
}

// FileMoveTo — File move to. [POST /api/Storage/filemoveto]. Query keys: sourcePath, destinationPath.
func (a *StorageApi) FileMoveTo(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Storage/filemoveto", nil, query)
}

// FolderCopyTo — Folder copy to. [POST /api/Storage/foldercopyto]. Query keys: sourcePath, destinationPath.
func (a *StorageApi) FolderCopyTo(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Storage/foldercopyto", nil, query)
}

// FolderMoveTo — Folder move to. [POST /api/Storage/foldermoveto]. Query keys: sourcePath, destinationPath.
func (a *StorageApi) FolderMoveTo(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Storage/foldermoveto", nil, query)
}

// GetAllDirectories — Get all directories. [POST /api/Storage/listdirectories]. Query keys: directory.
func (a *StorageApi) GetAllDirectories(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Storage/listdirectories", nil, query)
}

// GetAllDirectoriesAndFiles — Get all directories and files. [POST /api/Storage/directoriesandfiles]. Query keys: directory, type.
func (a *StorageApi) GetAllDirectoriesAndFiles(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Storage/directoriesandfiles", nil, query)
}

// GetAllFiles — Get all files. [POST /api/Storage/listfiles]. Query keys: directory, type.
func (a *StorageApi) GetAllFiles(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Storage/listfiles", nil, query)
}

// GetAllFilesandDirectories — Get all filesand directories. [POST /api/Storage/listfilesanddirectories]. Query keys: directory, type.
func (a *StorageApi) GetAllFilesandDirectories(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Storage/listfilesanddirectories", nil, query)
}

// GetRootDir — Get root dir. [GET /api/Storage/rootdir].
func (a *StorageApi) GetRootDir(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Storage/rootdir", nil, nil)
}

// RenameFile — Rename file. [POST /api/Storage/renamefile]. Query keys: path, rename.
func (a *StorageApi) RenameFile(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Storage/renamefile", nil, query)
}

// RenameFolder — Rename folder. [POST /api/Storage/renamefolder]. Query keys: directory, rename.
func (a *StorageApi) RenameFolder(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Storage/renamefolder", nil, query)
}

// StorageAccountApi holds the StorageAccount operations.
type StorageAccountApi struct{ c *Client }

// AcquireLock — Acquire lock. [POST /api/StorageAccount/items/{itemId}/lock].
func (a *StorageAccountApi) AcquireLock(ctx context.Context, itemId string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/StorageAccount/items/"+segment(itemId, false)+"/lock", body, nil)
}

// AddLifecycleRule — Add lifecycle rule. [POST /api/StorageAccount/{id}/lifecycle].
func (a *StorageAccountApi) AddLifecycleRule(ctx context.Context, id_ string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/StorageAccount/"+segment(id_, false)+"/lifecycle", body, nil)
}

// AddRoleAssignment — Add role assignment. [POST /api/StorageAccount/{id}/iam].
func (a *StorageAccountApi) AddRoleAssignment(ctx context.Context, id_ string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/StorageAccount/"+segment(id_, false)+"/iam", body, nil)
}

// BreakLock — Break lock. [POST /api/StorageAccount/items/{itemId}/lock/break].
func (a *StorageAccountApi) BreakLock(ctx context.Context, itemId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/StorageAccount/items/"+segment(itemId, false)+"/lock/break", nil, nil)
}

// CancelOperation — Cancel operation. [POST /api/StorageAccount/operations/{operationId}/cancel].
func (a *StorageAccountApi) CancelOperation(ctx context.Context, operationId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/StorageAccount/operations/"+segment(operationId, false)+"/cancel", nil, nil)
}

// CopyItem — Copy item. [POST /api/StorageAccount/items/copy].
func (a *StorageAccountApi) CopyItem(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/StorageAccount/items/copy", body, nil)
}

// CreateBackup — Create backup. [POST /api/StorageAccount/{id}/backups].
func (a *StorageAccountApi) CreateBackup(ctx context.Context, id_ string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/StorageAccount/"+segment(id_, false)+"/backups", body, nil)
}

// CreateFolder — Create folder. [POST /api/StorageAccount/folders].
func (a *StorageAccountApi) CreateFolder(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/StorageAccount/folders", body, nil)
}

// CreateQueue — Create queue. [POST /api/StorageAccount/{id}/queues].
func (a *StorageAccountApi) CreateQueue(ctx context.Context, id_ string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/StorageAccount/"+segment(id_, false)+"/queues", body, nil)
}

// CreateStorageAccount — Create storage account. [POST /api/StorageAccount].
func (a *StorageAccountApi) CreateStorageAccount(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/StorageAccount", body, nil)
}

// CreateTable — Create table. [POST /api/StorageAccount/{id}/tables].
func (a *StorageAccountApi) CreateTable(ctx context.Context, id_ string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/StorageAccount/"+segment(id_, false)+"/tables", body, nil)
}

// CreateZip — Create zip. [POST /api/StorageAccount/zip].
func (a *StorageAccountApi) CreateZip(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/StorageAccount/zip", body, nil)
}

// DeleteBackup — Delete backup. [DELETE /api/StorageAccount/{id}/backups/{backupId}].
func (a *StorageAccountApi) DeleteBackup(ctx context.Context, id_ string, backupId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/StorageAccount/"+segment(id_, false)+"/backups/"+segment(backupId, false), nil, nil)
}

// DeleteItems — Delete items. [POST /api/StorageAccount/items/delete].
func (a *StorageAccountApi) DeleteItems(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/StorageAccount/items/delete", body, nil)
}

// DeleteLifecycleRule — Delete lifecycle rule. [DELETE /api/StorageAccount/{id}/lifecycle/{ruleId}].
func (a *StorageAccountApi) DeleteLifecycleRule(ctx context.Context, id_ string, ruleId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/StorageAccount/"+segment(id_, false)+"/lifecycle/"+segment(ruleId, false), nil, nil)
}

// DeleteQueue — Delete queue. [DELETE /api/StorageAccount/{id}/queues/{queueName}].
func (a *StorageAccountApi) DeleteQueue(ctx context.Context, id_ string, queueName string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/StorageAccount/"+segment(id_, false)+"/queues/"+segment(queueName, false), nil, nil)
}

// DeleteStorageAccount — Delete storage account. [DELETE /api/StorageAccount/{id}].
func (a *StorageAccountApi) DeleteStorageAccount(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/StorageAccount/"+segment(id_, false), nil, nil)
}

// DeleteTable — Delete table. [DELETE /api/StorageAccount/{id}/tables/{tableName}].
func (a *StorageAccountApi) DeleteTable(ctx context.Context, id_ string, tableName string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/StorageAccount/"+segment(id_, false)+"/tables/"+segment(tableName, false), nil, nil)
}

// DownloadItemContent — Download item content. [GET /api/StorageAccount/items/{itemId}/content]. Query keys: region.
func (a *StorageAccountApi) DownloadItemContent(ctx context.Context, itemId string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/StorageAccount/items/"+segment(itemId, false)+"/content", nil, query)
}

// DownloadZip — Download zip. [POST /api/StorageAccount/zip/download].
func (a *StorageAccountApi) DownloadZip(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/StorageAccount/zip/download", body, nil)
}

// ExportActivityLog — Export activity log. [GET /api/StorageAccount/{id}/activity/export]. Query keys: format.
func (a *StorageAccountApi) ExportActivityLog(ctx context.Context, id_ string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/StorageAccount/"+segment(id_, false)+"/activity/export", nil, query)
}

// ExtractArchive — Extract archive. [POST /api/StorageAccount/{id}/items/{itemId}/extract].
func (a *StorageAccountApi) ExtractArchive(ctx context.Context, id_ string, itemId string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/StorageAccount/"+segment(id_, false)+"/items/"+segment(itemId, false)+"/extract", body, nil)
}

// FinalizeUpload — Finalize upload. [POST /api/StorageAccount/upload/{operationId}/finalize].
func (a *StorageAccountApi) FinalizeUpload(ctx context.Context, operationId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/StorageAccount/upload/"+segment(operationId, false)+"/finalize", nil, nil)
}

// GenerateShareLink — Generate share link. [POST /api/StorageAccount/items/{itemId}/sharelink].
func (a *StorageAccountApi) GenerateShareLink(ctx context.Context, itemId string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/StorageAccount/items/"+segment(itemId, false)+"/sharelink", body, nil)
}

// GetAccessKeys — Get access keys. [GET /api/StorageAccount/{id}/keys].
func (a *StorageAccountApi) GetAccessKeys(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/StorageAccount/"+segment(id_, false)+"/keys", nil, nil)
}

// GetActiveOperations — Get active operations. [GET /api/StorageAccount/{id}/operations].
func (a *StorageAccountApi) GetActiveOperations(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/StorageAccount/"+segment(id_, false)+"/operations", nil, nil)
}

// GetActivityLog — Get activity log. [GET /api/StorageAccount/{id}/activity]. Query keys: limit.
func (a *StorageAccountApi) GetActivityLog(ctx context.Context, id_ string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/StorageAccount/"+segment(id_, false)+"/activity", nil, query)
}

// GetAvailableRegions — Get available regions. [GET /api/StorageAccount/regions].
func (a *StorageAccountApi) GetAvailableRegions(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/StorageAccount/regions", nil, nil)
}

// GetBackups — Get backups. [GET /api/StorageAccount/{id}/backups].
func (a *StorageAccountApi) GetBackups(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/StorageAccount/"+segment(id_, false)+"/backups", nil, nil)
}

// GetDefaultStorageAccount — Get default storage account. [GET /api/StorageAccount/default].
func (a *StorageAccountApi) GetDefaultStorageAccount(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/StorageAccount/default", nil, nil)
}

// GetFilePreview — Get file preview. [GET /api/StorageAccount/items/{itemId}/preview].
func (a *StorageAccountApi) GetFilePreview(ctx context.Context, itemId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/StorageAccount/items/"+segment(itemId, false)+"/preview", nil, nil)
}

// GetItem — Get item. [GET /api/StorageAccount/items/{itemId}].
func (a *StorageAccountApi) GetItem(ctx context.Context, itemId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/StorageAccount/items/"+segment(itemId, false), nil, nil)
}

// GetItemActivityLog — Get item activity log. [GET /api/StorageAccount/items/{itemId}/activity]. Query keys: limit.
func (a *StorageAccountApi) GetItemActivityLog(ctx context.Context, itemId string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/StorageAccount/items/"+segment(itemId, false)+"/activity", nil, query)
}

// GetItemMetadata — Get item metadata. [GET /api/StorageAccount/items/{itemId}/metadata].
func (a *StorageAccountApi) GetItemMetadata(ctx context.Context, itemId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/StorageAccount/items/"+segment(itemId, false)+"/metadata", nil, nil)
}

// GetItemShares — Get item shares. [GET /api/StorageAccount/items/{itemId}/shares].
func (a *StorageAccountApi) GetItemShares(ctx context.Context, itemId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/StorageAccount/items/"+segment(itemId, false)+"/shares", nil, nil)
}

// GetLifecycleRules — Get lifecycle rules. [GET /api/StorageAccount/{id}/lifecycle].
func (a *StorageAccountApi) GetLifecycleRules(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/StorageAccount/"+segment(id_, false)+"/lifecycle", nil, nil)
}

// GetNetworking — Get networking. [GET /api/StorageAccount/{id}/networking].
func (a *StorageAccountApi) GetNetworking(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/StorageAccount/"+segment(id_, false)+"/networking", nil, nil)
}

// GetOperationStatus — Get operation status. [GET /api/StorageAccount/operations/{operationId}].
func (a *StorageAccountApi) GetOperationStatus(ctx context.Context, operationId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/StorageAccount/operations/"+segment(operationId, false), nil, nil)
}

// GetReplicationStatus — Get replication status. [GET /api/StorageAccount/{id}/replication].
func (a *StorageAccountApi) GetReplicationStatus(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/StorageAccount/"+segment(id_, false)+"/replication", nil, nil)
}

// GetRoleAssignments — Get role assignments. [GET /api/StorageAccount/{id}/iam].
func (a *StorageAccountApi) GetRoleAssignments(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/StorageAccount/"+segment(id_, false)+"/iam", nil, nil)
}

// GetRoleDefinitions — Get role definitions. [GET /api/StorageAccount/role-definitions].
func (a *StorageAccountApi) GetRoleDefinitions(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/StorageAccount/role-definitions", nil, nil)
}

// GetStorageAccount — Get storage account. [GET /api/StorageAccount/{id}].
func (a *StorageAccountApi) GetStorageAccount(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/StorageAccount/"+segment(id_, false), nil, nil)
}

// GetStorageAccounts — Get storage accounts. [GET /api/StorageAccount].
func (a *StorageAccountApi) GetStorageAccounts(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/StorageAccount", nil, nil)
}

// GetStorageStats — Get storage stats. [GET /api/StorageAccount/stats].
func (a *StorageAccountApi) GetStorageStats(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/StorageAccount/stats", nil, nil)
}

// GetVersionHistory — Get version history. [GET /api/StorageAccount/items/{itemId}/versions].
func (a *StorageAccountApi) GetVersionHistory(ctx context.Context, itemId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/StorageAccount/items/"+segment(itemId, false)+"/versions", nil, nil)
}

// InitiateDownload — Initiate download. [POST /api/StorageAccount/download].
func (a *StorageAccountApi) InitiateDownload(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/StorageAccount/download", body, nil)
}

// InitiateUpload — Initiate upload. [POST /api/StorageAccount/upload].
func (a *StorageAccountApi) InitiateUpload(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/StorageAccount/upload", body, nil)
}

// ListItems — List items. [GET /api/StorageAccount/{id}/items]. Query keys: path, parentId, storageNamespace.
func (a *StorageAccountApi) ListItems(ctx context.Context, id_ string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/StorageAccount/"+segment(id_, false)+"/items", nil, query)
}

// ListQueues — List queues. [GET /api/StorageAccount/{id}/queues].
func (a *StorageAccountApi) ListQueues(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/StorageAccount/"+segment(id_, false)+"/queues", nil, nil)
}

// ListTables — List tables. [GET /api/StorageAccount/{id}/tables].
func (a *StorageAccountApi) ListTables(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/StorageAccount/"+segment(id_, false)+"/tables", nil, nil)
}

// MoveItem — Move item. [PUT /api/StorageAccount/items/move].
func (a *StorageAccountApi) MoveItem(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "PUT", "/api/StorageAccount/items/move", body, nil)
}

// RegenerateAccessKey — Regenerate access key. [POST /api/StorageAccount/{id}/keys/{keyNumber}/regenerate].
func (a *StorageAccountApi) RegenerateAccessKey(ctx context.Context, id_ string, keyNumber string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/StorageAccount/"+segment(id_, false)+"/keys/"+segment(keyNumber, false)+"/regenerate", body, nil)
}

// ReleaseLock — Release lock. [DELETE /api/StorageAccount/items/{itemId}/lock].
func (a *StorageAccountApi) ReleaseLock(ctx context.Context, itemId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/StorageAccount/items/"+segment(itemId, false)+"/lock", nil, nil)
}

// RemoveRoleAssignment — Remove role assignment. [DELETE /api/StorageAccount/{id}/iam/{assignmentId}]. Query keys: principalEmail, role.
func (a *StorageAccountApi) RemoveRoleAssignment(ctx context.Context, id_ string, assignmentId string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/StorageAccount/"+segment(id_, false)+"/iam/"+segment(assignmentId, false), nil, query)
}

// RemoveShare — Remove share. [DELETE /api/StorageAccount/shares/{shareId}].
func (a *StorageAccountApi) RemoveShare(ctx context.Context, shareId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/StorageAccount/shares/"+segment(shareId, false), nil, nil)
}

// RenameItem — Rename item. [PUT /api/StorageAccount/items/rename].
func (a *StorageAccountApi) RenameItem(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "PUT", "/api/StorageAccount/items/rename", body, nil)
}

// RestoreBackup — Restore backup. [POST /api/StorageAccount/{id}/backups/{backupId}/restore].
func (a *StorageAccountApi) RestoreBackup(ctx context.Context, id_ string, backupId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/StorageAccount/"+segment(id_, false)+"/backups/"+segment(backupId, false)+"/restore", nil, nil)
}

// RestoreVersion — Restore version. [POST /api/StorageAccount/items/versions/restore].
func (a *StorageAccountApi) RestoreVersion(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/StorageAccount/items/versions/restore", body, nil)
}

// RunLifecycleRules — Run lifecycle rules. [POST /api/StorageAccount/{id}/lifecycle/run].
func (a *StorageAccountApi) RunLifecycleRules(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/StorageAccount/"+segment(id_, false)+"/lifecycle/run", nil, nil)
}

// SaveItemContent — Save item content. [PUT /api/StorageAccount/items/{itemId}/content].
func (a *StorageAccountApi) SaveItemContent(ctx context.Context, itemId string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "PUT", "/api/StorageAccount/items/"+segment(itemId, false)+"/content", body, nil)
}

// SearchItems — Search items. [GET /api/StorageAccount/{id}/items/search]. Query keys: q.
func (a *StorageAccountApi) SearchItems(ctx context.Context, id_ string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/StorageAccount/"+segment(id_, false)+"/items/search", nil, query)
}

// SetDefaultStorageAccount — Set default storage account. [PUT /api/StorageAccount/{id}/default].
func (a *StorageAccountApi) SetDefaultStorageAccount(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "PUT", "/api/StorageAccount/"+segment(id_, false)+"/default", nil, nil)
}

// ShareItem — Share item. [POST /api/StorageAccount/items/share].
func (a *StorageAccountApi) ShareItem(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/StorageAccount/items/share", body, nil)
}

// UpdateNetworking — Update networking. [PUT /api/StorageAccount/{id}/networking].
func (a *StorageAccountApi) UpdateNetworking(ctx context.Context, id_ string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "PUT", "/api/StorageAccount/"+segment(id_, false)+"/networking", body, nil)
}

// UpdateStorageAccount — Update storage account. [PUT /api/StorageAccount/{id}].
func (a *StorageAccountApi) UpdateStorageAccount(ctx context.Context, id_ string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "PUT", "/api/StorageAccount/"+segment(id_, false), body, nil)
}

// UploadChunk — Upload chunk. [POST /api/StorageAccount/upload/{operationId}/chunk].
func (a *StorageAccountApi) UploadChunk(ctx context.Context, operationId string, form map[string]string, files map[string]FilePart) (json.RawMessage, error) {
	return a.c.CallMultipart(ctx, "POST", "/api/StorageAccount/upload/"+segment(operationId, false)+"/chunk", form, files, nil)
}

// StorageDataApi holds the StorageData operations.
type StorageDataApi struct{ c *Client }

// ClearQueue — Clear queue. [DELETE /api/storageaccount/{accountId}/queues/{queueName}/messages].
func (a *StorageDataApi) ClearQueue(ctx context.Context, accountId string, queueName string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/storageaccount/"+segment(accountId, false)+"/queues/"+segment(queueName, false)+"/messages", nil, nil)
}

// DeleteEntity — Delete entity. [DELETE /api/storageaccount/{accountId}/tables/{tableName}/entities/{partitionKey}/{rowKey}]. Query keys: ifMatch.
func (a *StorageDataApi) DeleteEntity(ctx context.Context, accountId string, tableName string, partitionKey string, rowKey string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/storageaccount/"+segment(accountId, false)+"/tables/"+segment(tableName, false)+"/entities/"+segment(partitionKey, false)+"/"+segment(rowKey, false), nil, query)
}

// DeleteMessage — Delete message. [DELETE /api/storageaccount/{accountId}/queues/{queueName}/messages/{messageId}]. Query keys: popReceipt.
func (a *StorageDataApi) DeleteMessage(ctx context.Context, accountId string, queueName string, messageId string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/storageaccount/"+segment(accountId, false)+"/queues/"+segment(queueName, false)+"/messages/"+segment(messageId, false), nil, query)
}

// GetEntity — Get entity. [GET /api/storageaccount/{accountId}/tables/{tableName}/entities/{partitionKey}/{rowKey}].
func (a *StorageDataApi) GetEntity(ctx context.Context, accountId string, tableName string, partitionKey string, rowKey string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/storageaccount/"+segment(accountId, false)+"/tables/"+segment(tableName, false)+"/entities/"+segment(partitionKey, false)+"/"+segment(rowKey, false), nil, nil)
}

// InsertEntity — Insert entity. [POST /api/storageaccount/{accountId}/tables/{tableName}/entities].
func (a *StorageDataApi) InsertEntity(ctx context.Context, accountId string, tableName string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/storageaccount/"+segment(accountId, false)+"/tables/"+segment(tableName, false)+"/entities", body, nil)
}

// PeekMessages — Peek messages. [GET /api/storageaccount/{accountId}/queues/{queueName}/messages]. Query keys: max.
func (a *StorageDataApi) PeekMessages(ctx context.Context, accountId string, queueName string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/storageaccount/"+segment(accountId, false)+"/queues/"+segment(queueName, false)+"/messages", nil, query)
}

// QueryEntities — Query entities. [GET /api/storageaccount/{accountId}/tables/{tableName}/entities]. Query keys: partitionKey, propertyName, propertyValue, take, continuationRowKey.
func (a *StorageDataApi) QueryEntities(ctx context.Context, accountId string, tableName string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/storageaccount/"+segment(accountId, false)+"/tables/"+segment(tableName, false)+"/entities", nil, query)
}

// QueueStats — Queue stats. [GET /api/storageaccount/{accountId}/queues/{queueName}/stats].
func (a *StorageDataApi) QueueStats(ctx context.Context, accountId string, queueName string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/storageaccount/"+segment(accountId, false)+"/queues/"+segment(queueName, false)+"/stats", nil, nil)
}

// ReceiveMessages — Receive messages. [POST /api/storageaccount/{accountId}/queues/{queueName}/messages/receive].
func (a *StorageDataApi) ReceiveMessages(ctx context.Context, accountId string, queueName string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/storageaccount/"+segment(accountId, false)+"/queues/"+segment(queueName, false)+"/messages/receive", body, nil)
}

// SendMessage — Send message. [POST /api/storageaccount/{accountId}/queues/{queueName}/messages].
func (a *StorageDataApi) SendMessage(ctx context.Context, accountId string, queueName string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/storageaccount/"+segment(accountId, false)+"/queues/"+segment(queueName, false)+"/messages", body, nil)
}

// UpdateVisibility — Update visibility. [POST /api/storageaccount/{accountId}/queues/{queueName}/messages/{messageId}/visibility]. Query keys: popReceipt, visibilityTimeoutSeconds.
func (a *StorageDataApi) UpdateVisibility(ctx context.Context, accountId string, queueName string, messageId string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/storageaccount/"+segment(accountId, false)+"/queues/"+segment(queueName, false)+"/messages/"+segment(messageId, false)+"/visibility", nil, query)
}

// UpsertEntity — Upsert entity. [PUT /api/storageaccount/{accountId}/tables/{tableName}/entities].
func (a *StorageDataApi) UpsertEntity(ctx context.Context, accountId string, tableName string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "PUT", "/api/storageaccount/"+segment(accountId, false)+"/tables/"+segment(tableName, false)+"/entities", body, nil)
}

// StorageObjectApi holds the StorageObject operations.
type StorageObjectApi struct{ c *Client }

// CommitBlockList — Commit block list. [POST /api/storageaccount/{accountId}/containers/{container}/blocks/commit].
func (a *StorageObjectApi) CommitBlockList(ctx context.Context, accountId string, container string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/storageaccount/"+segment(accountId, false)+"/containers/"+segment(container, false)+"/blocks/commit", body, nil)
}

// CreateContainer — Create container. [POST /api/storageaccount/{accountId}/containers].
func (a *StorageObjectApi) CreateContainer(ctx context.Context, accountId string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/storageaccount/"+segment(accountId, false)+"/containers", body, nil)
}

// CreateDirectory — Create directory. [POST /api/storageaccount/{accountId}/containers/{container}/directories].
func (a *StorageObjectApi) CreateDirectory(ctx context.Context, accountId string, container string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/storageaccount/"+segment(accountId, false)+"/containers/"+segment(container, false)+"/directories", body, nil)
}

// CreateFileShare — Create file share. [POST /api/storageaccount/{accountId}/fileshares].
func (a *StorageObjectApi) CreateFileShare(ctx context.Context, accountId string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/storageaccount/"+segment(accountId, false)+"/fileshares", body, nil)
}

// DeleteContainer — Delete container. [DELETE /api/storageaccount/{accountId}/containers/{name}]. Query keys: force.
func (a *StorageObjectApi) DeleteContainer(ctx context.Context, accountId string, name string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/storageaccount/"+segment(accountId, false)+"/containers/"+segment(name, false), nil, query)
}

// DeleteFileShare — Delete file share. [DELETE /api/storageaccount/{accountId}/fileshares/{name}]. Query keys: force.
func (a *StorageObjectApi) DeleteFileShare(ctx context.Context, accountId string, name string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/storageaccount/"+segment(accountId, false)+"/fileshares/"+segment(name, false), nil, query)
}

// DeleteObject — Delete object. [DELETE /api/storageaccount/{accountId}/containers/{container}/objects/{key}].
func (a *StorageObjectApi) DeleteObject(ctx context.Context, accountId string, container string, key string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/storageaccount/"+segment(accountId, false)+"/containers/"+segment(container, false)+"/objects/"+segment(key, true), nil, nil)
}

// GetBlockList — Get block list. [GET /api/storageaccount/{accountId}/containers/{container}/blocks]. Query keys: blobName.
func (a *StorageObjectApi) GetBlockList(ctx context.Context, accountId string, container string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/storageaccount/"+segment(accountId, false)+"/containers/"+segment(container, false)+"/blocks", nil, query)
}

// GetContainer — Get container. [GET /api/storageaccount/{accountId}/containers/{name}].
func (a *StorageObjectApi) GetContainer(ctx context.Context, accountId string, name string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/storageaccount/"+segment(accountId, false)+"/containers/"+segment(name, false), nil, nil)
}

// GetObject — Get object. [GET /api/storageaccount/{accountId}/containers/{container}/objects/{key}].
func (a *StorageObjectApi) GetObject(ctx context.Context, accountId string, container string, key string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/storageaccount/"+segment(accountId, false)+"/containers/"+segment(container, false)+"/objects/"+segment(key, true), nil, nil)
}

// GetObjectContent — Get object content. [GET /api/storageaccount/{accountId}/containers/{container}/content/{key}].
func (a *StorageObjectApi) GetObjectContent(ctx context.Context, accountId string, container string, key string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/storageaccount/"+segment(accountId, false)+"/containers/"+segment(container, false)+"/content/"+segment(key, true), nil, nil)
}

// GetReplicationStatus — Get replication status. [GET /api/storageaccount/{accountId}/replication-status].
func (a *StorageObjectApi) GetReplicationStatus(ctx context.Context, accountId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/storageaccount/"+segment(accountId, false)+"/replication-status", nil, nil)
}

// ListContainers — List containers. [GET /api/storageaccount/{accountId}/containers]. Query keys: kind.
func (a *StorageObjectApi) ListContainers(ctx context.Context, accountId string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/storageaccount/"+segment(accountId, false)+"/containers", nil, query)
}

// ListFileShares — List file shares. [GET /api/storageaccount/{accountId}/fileshares].
func (a *StorageObjectApi) ListFileShares(ctx context.Context, accountId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/storageaccount/"+segment(accountId, false)+"/fileshares", nil, nil)
}

// ListObjects — List objects. [GET /api/storageaccount/{accountId}/containers/{container}/objects]. Query keys: prefix, path, limit.
func (a *StorageObjectApi) ListObjects(ctx context.Context, accountId string, container string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/storageaccount/"+segment(accountId, false)+"/containers/"+segment(container, false)+"/objects", nil, query)
}

// PutObject — Put object. [PUT /api/storageaccount/{accountId}/containers/{container}/objects].
func (a *StorageObjectApi) PutObject(ctx context.Context, accountId string, container string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "PUT", "/api/storageaccount/"+segment(accountId, false)+"/containers/"+segment(container, false)+"/objects", body, nil)
}

// Reconcile — Reconcile. [POST /api/storageaccount/{accountId}/replication-status/reconcile].
func (a *StorageObjectApi) Reconcile(ctx context.Context, accountId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/storageaccount/"+segment(accountId, false)+"/replication-status/reconcile", nil, nil)
}

// RenamePath — Rename path. [POST /api/storageaccount/{accountId}/containers/{container}/rename].
func (a *StorageObjectApi) RenamePath(ctx context.Context, accountId string, container string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/storageaccount/"+segment(accountId, false)+"/containers/"+segment(container, false)+"/rename", body, nil)
}

// SetAccessControl — Set access control. [PUT /api/storageaccount/{accountId}/containers/{container}/access-control].
func (a *StorageObjectApi) SetAccessControl(ctx context.Context, accountId string, container string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "PUT", "/api/storageaccount/"+segment(accountId, false)+"/containers/"+segment(container, false)+"/access-control", body, nil)
}

// StageBlock — Stage block. [PUT /api/storageaccount/{accountId}/containers/{container}/blocks].
func (a *StorageObjectApi) StageBlock(ctx context.Context, accountId string, container string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "PUT", "/api/storageaccount/"+segment(accountId, false)+"/containers/"+segment(container, false)+"/blocks", body, nil)
}

// UpdateContainer — Update container. [PUT /api/storageaccount/{accountId}/containers/{name}].
func (a *StorageObjectApi) UpdateContainer(ctx context.Context, accountId string, name string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "PUT", "/api/storageaccount/"+segment(accountId, false)+"/containers/"+segment(name, false), body, nil)
}

// StreamAnalyticsApi holds the StreamAnalytics operations.
type StreamAnalyticsApi struct{ c *Client }

// AddInput — Add input. [POST /api/StreamAnalytics/{id}/inputs].
func (a *StreamAnalyticsApi) AddInput(ctx context.Context, id_ string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/StreamAnalytics/"+segment(id_, false)+"/inputs", body, nil)
}

// AddOutput — Add output. [POST /api/StreamAnalytics/{id}/outputs].
func (a *StreamAnalyticsApi) AddOutput(ctx context.Context, id_ string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/StreamAnalytics/"+segment(id_, false)+"/outputs", body, nil)
}

// ApplyTransform — Apply transform. [POST /api/StreamAnalytics/{id}/transform/apply].
func (a *StreamAnalyticsApi) ApplyTransform(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/StreamAnalytics/"+segment(id_, false)+"/transform/apply", nil, nil)
}

// Bindings — Bindings. [GET /api/StreamAnalytics/bindings]. Query keys: connector.
func (a *StreamAnalyticsApi) Bindings(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/StreamAnalytics/bindings", nil, query)
}

// Catalog — Catalog. [GET /api/StreamAnalytics/catalog].
func (a *StreamAnalyticsApi) Catalog(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/StreamAnalytics/catalog", nil, nil)
}

// Connection — Connection. [GET /api/StreamAnalytics/{id}/connection].
func (a *StreamAnalyticsApi) Connection(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/StreamAnalytics/"+segment(id_, false)+"/connection", nil, nil)
}

// Create — Create. [POST /api/StreamAnalytics].
func (a *StreamAnalyticsApi) Create(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/StreamAnalytics", body, nil)
}

// Delete — Delete. [DELETE /api/StreamAnalytics/{id}].
func (a *StreamAnalyticsApi) Delete(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/StreamAnalytics/"+segment(id_, false), nil, nil)
}

// DeleteInput — Delete input. [DELETE /api/StreamAnalytics/{id}/inputs/{inputId}].
func (a *StreamAnalyticsApi) DeleteInput(ctx context.Context, id_ string, inputId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/StreamAnalytics/"+segment(id_, false)+"/inputs/"+segment(inputId, false), nil, nil)
}

// DeleteOutput — Delete output. [DELETE /api/StreamAnalytics/{id}/outputs/{outputId}].
func (a *StreamAnalyticsApi) DeleteOutput(ctx context.Context, id_ string, outputId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/StreamAnalytics/"+segment(id_, false)+"/outputs/"+segment(outputId, false), nil, nil)
}

// Get — Get. [GET /api/StreamAnalytics/{id}].
func (a *StreamAnalyticsApi) Get(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/StreamAnalytics/"+segment(id_, false), nil, nil)
}

// Inputs — Inputs. [GET /api/StreamAnalytics/{id}/inputs].
func (a *StreamAnalyticsApi) Inputs(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/StreamAnalytics/"+segment(id_, false)+"/inputs", nil, nil)
}

// List — List. [GET /api/StreamAnalytics].
func (a *StreamAnalyticsApi) List(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/StreamAnalytics", nil, nil)
}

// Logs — Logs. [GET /api/StreamAnalytics/{id}/logs]. Query keys: role, tail.
func (a *StreamAnalyticsApi) Logs(ctx context.Context, id_ string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/StreamAnalytics/"+segment(id_, false)+"/logs", nil, query)
}

// Metrics — Metrics. [GET /api/StreamAnalytics/{id}/metrics].
func (a *StreamAnalyticsApi) Metrics(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/StreamAnalytics/"+segment(id_, false)+"/metrics", nil, nil)
}

// Outputs — Outputs. [GET /api/StreamAnalytics/{id}/outputs].
func (a *StreamAnalyticsApi) Outputs(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/StreamAnalytics/"+segment(id_, false)+"/outputs", nil, nil)
}

// Query — Query. [POST /api/StreamAnalytics/{id}/query].
func (a *StreamAnalyticsApi) Query(ctx context.Context, id_ string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/StreamAnalytics/"+segment(id_, false)+"/query", body, nil)
}

// QueryHistory — Query history. [GET /api/StreamAnalytics/{id}/query/history]. Query keys: take.
func (a *StreamAnalyticsApi) QueryHistory(ctx context.Context, id_ string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/StreamAnalytics/"+segment(id_, false)+"/query/history", nil, query)
}

// Start — Start. [POST /api/StreamAnalytics/{id}/start].
func (a *StreamAnalyticsApi) Start(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/StreamAnalytics/"+segment(id_, false)+"/start", nil, nil)
}

// Status — Status. [GET /api/StreamAnalytics/{id}/status].
func (a *StreamAnalyticsApi) Status(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/StreamAnalytics/"+segment(id_, false)+"/status", nil, nil)
}

// Stop — Stop. [POST /api/StreamAnalytics/{id}/stop].
func (a *StreamAnalyticsApi) Stop(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/StreamAnalytics/"+segment(id_, false)+"/stop", nil, nil)
}

// Transform — Transform. [GET /api/StreamAnalytics/{id}/transform].
func (a *StreamAnalyticsApi) Transform(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/StreamAnalytics/"+segment(id_, false)+"/transform", nil, nil)
}

// Update — Update. [PATCH /api/StreamAnalytics/{id}].
func (a *StreamAnalyticsApi) Update(ctx context.Context, id_ string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "PATCH", "/api/StreamAnalytics/"+segment(id_, false), body, nil)
}

// StreamPipelineApi holds the StreamPipeline operations.
type StreamPipelineApi struct{ c *Client }

// Create — Create. [POST /api/StreamAnalytics/{jobId}/pipelines].
func (a *StreamPipelineApi) Create(ctx context.Context, jobId string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/StreamAnalytics/"+segment(jobId, false)+"/pipelines", body, nil)
}

// Delete — Delete. [DELETE /api/StreamAnalytics/{jobId}/pipelines/{pipelineId}].
func (a *StreamPipelineApi) Delete(ctx context.Context, jobId string, pipelineId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/StreamAnalytics/"+segment(jobId, false)+"/pipelines/"+segment(pipelineId, false), nil, nil)
}

// Get — Get. [GET /api/StreamAnalytics/{jobId}/pipelines/{pipelineId}].
func (a *StreamPipelineApi) Get(ctx context.Context, jobId string, pipelineId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/StreamAnalytics/"+segment(jobId, false)+"/pipelines/"+segment(pipelineId, false), nil, nil)
}

// GetRun — Get run. [GET /api/StreamAnalytics/{jobId}/pipelines/runs/{runId}].
func (a *StreamPipelineApi) GetRun(ctx context.Context, jobId string, runId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/StreamAnalytics/"+segment(jobId, false)+"/pipelines/runs/"+segment(runId, false), nil, nil)
}

// List — List. [GET /api/StreamAnalytics/{jobId}/pipelines].
func (a *StreamPipelineApi) List(ctx context.Context, jobId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/StreamAnalytics/"+segment(jobId, false)+"/pipelines", nil, nil)
}

// PreviewSchedule — Preview schedule. [GET /api/StreamAnalytics/schedule-preview]. Query keys: cron, timeZone, count.
func (a *StreamPipelineApi) PreviewSchedule(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/StreamAnalytics/schedule-preview", nil, query)
}

// Run — Run. [POST /api/StreamAnalytics/{jobId}/pipelines/{pipelineId}/run].
func (a *StreamPipelineApi) Run(ctx context.Context, jobId string, pipelineId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/StreamAnalytics/"+segment(jobId, false)+"/pipelines/"+segment(pipelineId, false)+"/run", nil, nil)
}

// Runs — Runs. [GET /api/StreamAnalytics/{jobId}/pipelines/{pipelineId}/runs]. Query keys: limit.
func (a *StreamPipelineApi) Runs(ctx context.Context, jobId string, pipelineId string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/StreamAnalytics/"+segment(jobId, false)+"/pipelines/"+segment(pipelineId, false)+"/runs", nil, query)
}

// Update — Update. [PUT /api/StreamAnalytics/{jobId}/pipelines/{pipelineId}].
func (a *StreamPipelineApi) Update(ctx context.Context, jobId string, pipelineId string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "PUT", "/api/StreamAnalytics/"+segment(jobId, false)+"/pipelines/"+segment(pipelineId, false), body, nil)
}

// StreamingApi holds the Streaming operations.
type StreamingApi struct{ c *Client }

// AddDestination — Add destination. [POST /api/streaming/{id}/destinations].
func (a *StreamingApi) AddDestination(ctx context.Context, id_ string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/streaming/"+segment(id_, false)+"/destinations", body, nil)
}

// Create — Create. [POST /api/streaming].
func (a *StreamingApi) Create(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/streaming", body, nil)
}

// Delete — Delete. [DELETE /api/streaming/{id}].
func (a *StreamingApi) Delete(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/streaming/"+segment(id_, false), nil, nil)
}

// DeleteDestination — Delete destination. [DELETE /api/streaming/destinations/{destinationId}].
func (a *StreamingApi) DeleteDestination(ctx context.Context, destinationId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/streaming/destinations/"+segment(destinationId, false), nil, nil)
}

// Destinations — Destinations. [GET /api/streaming/{id}/destinations]. Query keys: refresh.
func (a *StreamingApi) Destinations(ctx context.Context, id_ string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/streaming/"+segment(id_, false)+"/destinations", nil, query)
}

// Get — Get. [GET /api/streaming/{id}].
func (a *StreamingApi) Get(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/streaming/"+segment(id_, false), nil, nil)
}

// List — List. [GET /api/streaming].
func (a *StreamingApi) List(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/streaming", nil, nil)
}

// Platforms — Platforms. [GET /api/streaming/platforms].
func (a *StreamingApi) Platforms(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/streaming/platforms", nil, nil)
}

// SyncDestinations — Sync destinations. [POST /api/streaming/{id}/destinations/sync].
func (a *StreamingApi) SyncDestinations(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/streaming/"+segment(id_, false)+"/destinations/sync", nil, nil)
}

// UpdateDestination — Update destination. [PUT /api/streaming/destinations/{destinationId}].
func (a *StreamingApi) UpdateDestination(ctx context.Context, destinationId string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "PUT", "/api/streaming/destinations/"+segment(destinationId, false), body, nil)
}

// SubscriptionApi holds the Subscription operations.
type SubscriptionApi struct{ c *Client }

// ActiveSubscriptions — Active subscriptions. [GET /api/Subscription/activesubscriptions].
func (a *SubscriptionApi) ActiveSubscriptions(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Subscription/activesubscriptions", nil, nil)
}

// AddSubscriptiontoUser — Add subscriptionto user. [POST /api/Subscription/addsubscriptiontouser].
func (a *SubscriptionApi) AddSubscriptiontoUser(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Subscription/addsubscriptiontouser", body, nil)
}

// CreateSubscription — Create subscription. [POST /api/Subscription/createsubscriptions].
func (a *SubscriptionApi) CreateSubscription(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Subscription/createsubscriptions", body, nil)
}

// CreateUserSubscription — Create user subscription. [POST /api/Subscription/createsubscription].
func (a *SubscriptionApi) CreateUserSubscription(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Subscription/createsubscription", body, nil)
}

// DeleteSubscriptionById — Delete subscription by id. [DELETE /api/Subscription/removesubscription/{id}].
func (a *SubscriptionApi) DeleteSubscriptionById(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/Subscription/removesubscription/"+segment(id_, false), nil, nil)
}

// MySubscriptions — My subscriptions. [GET /api/Subscription/mysubscriptions].
func (a *SubscriptionApi) MySubscriptions(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Subscription/mysubscriptions", nil, nil)
}

// Subscriptions — Subscriptions. [GET /api/Subscription/subscriptions].
func (a *SubscriptionApi) Subscriptions(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Subscription/subscriptions", nil, nil)
}

// SupportApi holds the Support operations.
type SupportApi struct{ c *Client }

// Close — Close. [POST /api/support/tickets/{id}/close].
func (a *SupportApi) Close(ctx context.Context, id_ string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/support/tickets/"+segment(id_, false)+"/close", body, nil)
}

// Mine — Mine. [GET /api/support/tickets].
func (a *SupportApi) Mine(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/support/tickets", nil, nil)
}

// Raise — Raise. [POST /api/support/tickets].
func (a *SupportApi) Raise(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/support/tickets", body, nil)
}

// SupportQueueApi holds the SupportQueue operations.
type SupportQueueApi struct{ c *Client }

// Queue — Queue. [GET /api/admin/support]. Query keys: status.
func (a *SupportQueueApi) Queue(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/admin/support", nil, query)
}

// Update — Update. [PUT /api/admin/support/{id}].
func (a *SupportQueueApi) Update(ctx context.Context, id_ string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "PUT", "/api/admin/support/"+segment(id_, false), body, nil)
}

// UploadApi holds the Upload operations.
type UploadApi struct{ c *Client }

// FinalizeUpload — Finalize upload. [POST /api/Upload/finalizeupload].
func (a *UploadApi) FinalizeUpload(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Upload/finalizeupload", body, nil)
}

// InitiateUpload — Initiate upload. [POST /api/Upload/initiateupload]. Query keys: uploadDirPath, folderDirPath.
func (a *UploadApi) InitiateUpload(ctx context.Context, form map[string]string, files map[string]FilePart, query Query) (json.RawMessage, error) {
	return a.c.CallMultipart(ctx, "POST", "/api/Upload/initiateupload", form, files, query)
}

// UploadChunk — Upload chunk. [POST /api/Upload/uploadchunk]. Query keys: directoryName, chunkindex, uploadDirPath, folderDirPath.
func (a *UploadApi) UploadChunk(ctx context.Context, form map[string]string, files map[string]FilePart, query Query) (json.RawMessage, error) {
	return a.c.CallMultipart(ctx, "POST", "/api/Upload/uploadchunk", form, files, query)
}

// VPNGatewayApi holds the VPNGateway operations.
type VPNGatewayApi struct{ c *Client }

// CreateP2SClient — Create p2 sclient. [POST /api/VPNGateway/clients/p2s]. Query keys: region.
func (a *VPNGatewayApi) CreateP2SClient(ctx context.Context, body any, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/VPNGateway/clients/p2s", body, query)
}

// CreateS2SConnection — Create s2 sconnection. [POST /api/VPNGateway/connections/s2s]. Query keys: region.
func (a *VPNGatewayApi) CreateS2SConnection(ctx context.Context, body any, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/VPNGateway/connections/s2s", body, query)
}

// CreateVPNGateway — Create vpngateway. [POST /api/VPNGateway/create].
func (a *VPNGatewayApi) CreateVPNGateway(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/VPNGateway/create", body, nil)
}

// DeleteS2SConnection — Delete s2 sconnection. [DELETE /api/VPNGateway/connections/s2s/{connectionId}]. Query keys: region.
func (a *VPNGatewayApi) DeleteS2SConnection(ctx context.Context, connectionId string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/VPNGateway/connections/s2s/"+segment(connectionId, false), nil, query)
}

// DeleteVPNGateway — Delete vpngateway. [DELETE /api/VPNGateway/{gatewayId}]. Query keys: gatewayName, region.
func (a *VPNGatewayApi) DeleteVPNGateway(ctx context.Context, gatewayId string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/VPNGateway/"+segment(gatewayId, false), nil, query)
}

// DownloadClientConfig — Download client config. [GET /api/VPNGateway/clients/p2s/{clientId}/config]. Query keys: region.
func (a *VPNGatewayApi) DownloadClientConfig(ctx context.Context, clientId string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/VPNGateway/clients/p2s/"+segment(clientId, false)+"/config", nil, query)
}

// GetConnectedClients — Get connected clients. [GET /api/VPNGateway/{gatewayId}/clients/p2s/connected]. Query keys: region.
func (a *VPNGatewayApi) GetConnectedClients(ctx context.Context, gatewayId string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/VPNGateway/"+segment(gatewayId, false)+"/clients/p2s/connected", nil, query)
}

// GetS2SConnectionStatus — Get s2 sconnection status. [GET /api/VPNGateway/connections/s2s/{connectionId}/status]. Query keys: region.
func (a *VPNGatewayApi) GetS2SConnectionStatus(ctx context.Context, connectionId string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/VPNGateway/connections/s2s/"+segment(connectionId, false)+"/status", nil, query)
}

// GetVPNGateway — Get vpngateway. [GET /api/VPNGateway/{gatewayId}].
func (a *VPNGatewayApi) GetVPNGateway(ctx context.Context, gatewayId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/VPNGateway/"+segment(gatewayId, false), nil, nil)
}

// GetVPNGatewayStatus — Get vpngateway status. [GET /api/VPNGateway/{gatewayId}/status]. Query keys: region.
func (a *VPNGatewayApi) GetVPNGatewayStatus(ctx context.Context, gatewayId string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/VPNGateway/"+segment(gatewayId, false)+"/status", nil, query)
}

// ListP2SClients — List p2 sclients. [GET /api/VPNGateway/{gatewayId}/clients/p2s].
func (a *VPNGatewayApi) ListP2SClients(ctx context.Context, gatewayId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/VPNGateway/"+segment(gatewayId, false)+"/clients/p2s", nil, nil)
}

// ListS2SConnections — List s2 sconnections. [GET /api/VPNGateway/{gatewayId}/connections/s2s].
func (a *VPNGatewayApi) ListS2SConnections(ctx context.Context, gatewayId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/VPNGateway/"+segment(gatewayId, false)+"/connections/s2s", nil, nil)
}

// ListVPNGateways — List vpngateways. [GET /api/VPNGateway/list]. Query keys: vnetId.
func (a *VPNGatewayApi) ListVPNGateways(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/VPNGateway/list", nil, query)
}

// RevokeP2SClient — Revoke p2 sclient. [DELETE /api/VPNGateway/clients/p2s/{clientId}]. Query keys: region.
func (a *VPNGatewayApi) RevokeP2SClient(ctx context.Context, clientId string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/VPNGateway/clients/p2s/"+segment(clientId, false), nil, query)
}

// VXLANApi holds the VXLAN operations.
type VXLANApi struct{ c *Client }

// AddVtep — Add vtep. [POST /api/VXLAN/tunnels/{tunnelId}/vteps].
func (a *VXLANApi) AddVtep(ctx context.Context, tunnelId string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/VXLAN/tunnels/"+segment(tunnelId, false)+"/vteps", body, nil)
}

// CreateTunnel — Create tunnel. [POST /api/VXLAN/tunnels].
func (a *VXLANApi) CreateTunnel(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/VXLAN/tunnels", body, nil)
}

// DeleteTunnel — Delete tunnel. [DELETE /api/VXLAN/tunnels/{tunnelId}].
func (a *VXLANApi) DeleteTunnel(ctx context.Context, tunnelId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/VXLAN/tunnels/"+segment(tunnelId, false), nil, nil)
}

// GetTunnel — Get tunnel. [GET /api/VXLAN/tunnels/{tunnelId}].
func (a *VXLANApi) GetTunnel(ctx context.Context, tunnelId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/VXLAN/tunnels/"+segment(tunnelId, false), nil, nil)
}

// ListTunnels — List tunnels. [GET /api/VXLAN/tunnels].
func (a *VXLANApi) ListTunnels(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/VXLAN/tunnels", nil, nil)
}

// RemoveVtep — Remove vtep. [DELETE /api/VXLAN/tunnels/{tunnelId}/vteps/{vtepIp}].
func (a *VXLANApi) RemoveVtep(ctx context.Context, tunnelId string, vtepIp string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/VXLAN/tunnels/"+segment(tunnelId, false)+"/vteps/"+segment(vtepIp, false), nil, nil)
}

// VirtualMachineApi holds the VirtualMachine operations.
type VirtualMachineApi struct{ c *Client }

// CreateVM — Create vm. [POST /api/VirtualMachine/create-vm].
func (a *VirtualMachineApi) CreateVM(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/VirtualMachine/create-vm", body, nil)
}

// DestroyVM — Destroy vm. [DELETE /api/VirtualMachine/destroy-vm].
func (a *VirtualMachineApi) DestroyVM(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/VirtualMachine/destroy-vm", body, nil)
}

// GetSshPrivateKey — Get ssh private key. [GET /api/VirtualMachine/{id}/sshkey].
func (a *VirtualMachineApi) GetSshPrivateKey(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/VirtualMachine/"+segment(id_, false)+"/sshkey", nil, nil)
}

// GetVMInfo — Get vminfo. [GET /api/VirtualMachine/vm-info]. Query keys: vmName, regions.
func (a *VirtualMachineApi) GetVMInfo(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/VirtualMachine/vm-info", nil, query)
}

// ListLocalVMImages — List local vmimages. [GET /api/VirtualMachine/list-local-vm-images]. Query keys: regions.
func (a *VirtualMachineApi) ListLocalVMImages(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/VirtualMachine/list-local-vm-images", nil, query)
}

// ListRunningVMs — List running vms. [GET /api/VirtualMachine/list-running-vms]. Query keys: regions.
func (a *VirtualMachineApi) ListRunningVMs(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/VirtualMachine/list-running-vms", nil, query)
}

// ListVMs — List vms. [GET /api/VirtualMachine/list-vms]. Query keys: regions.
func (a *VirtualMachineApi) ListVMs(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/VirtualMachine/list-vms", nil, query)
}

// ListVMsInfo — List vms info. [GET /api/VirtualMachine/list-vms-info]. Query keys: regions.
func (a *VirtualMachineApi) ListVMsInfo(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/VirtualMachine/list-vms-info", nil, query)
}

// ResetPassword — Reset password. [POST /api/VirtualMachine/reset-password].
func (a *VirtualMachineApi) ResetPassword(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/VirtualMachine/reset-password", body, nil)
}

// StartVM — Start vm. [POST /api/VirtualMachine/start-vm].
func (a *VirtualMachineApi) StartVM(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/VirtualMachine/start-vm", body, nil)
}

// StopVM — Stop vm. [POST /api/VirtualMachine/stop-vm].
func (a *VirtualMachineApi) StopVM(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/VirtualMachine/stop-vm", body, nil)
}

// VirtualNetworkApi holds the VirtualNetwork operations.
type VirtualNetworkApi struct{ c *Client }

// CreateVNet — Create vnet. [POST /api/VirtualNetwork/create-vnet].
func (a *VirtualNetworkApi) CreateVNet(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/VirtualNetwork/create-vnet", body, nil)
}

// CreateVnetPeering — Create vnet peering. [POST /api/VirtualNetwork/{vnetId}/peerings].
func (a *VirtualNetworkApi) CreateVnetPeering(ctx context.Context, vnetId string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/VirtualNetwork/"+segment(vnetId, false)+"/peerings", body, nil)
}

// DeleteVnetPeering — Delete vnet peering. [DELETE /api/VirtualNetwork/{vnetId}/peerings/{peeringId}].
func (a *VirtualNetworkApi) DeleteVnetPeering(ctx context.Context, vnetId string, peeringId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/VirtualNetwork/"+segment(vnetId, false)+"/peerings/"+segment(peeringId, false), nil, nil)
}

// DeleteVnetSubnet — Delete vnet subnet. [DELETE /api/VirtualNetwork/{vnetId}/subnets/{subnetId}].
func (a *VirtualNetworkApi) DeleteVnetSubnet(ctx context.Context, vnetId string, subnetId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/VirtualNetwork/"+segment(vnetId, false)+"/subnets/"+segment(subnetId, false), nil, nil)
}

// DestroyVNet — Destroy vnet. [DELETE /api/VirtualNetwork/delete-vnet].
func (a *VirtualNetworkApi) DestroyVNet(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/VirtualNetwork/delete-vnet", body, nil)
}

// ListAllPeerings — List all peerings. [GET /api/VirtualNetwork/peerings].
func (a *VirtualNetworkApi) ListAllPeerings(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/VirtualNetwork/peerings", nil, nil)
}

// ListAllSubnets — List all subnets. [GET /api/VirtualNetwork/subnets].
func (a *VirtualNetworkApi) ListAllSubnets(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/VirtualNetwork/subnets", nil, nil)
}

// ListVMsInfo — List vms info. [GET /api/VirtualNetwork/list-vnets].
func (a *VirtualNetworkApi) ListVMsInfo(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/VirtualNetwork/list-vnets", nil, nil)
}

// ListVnetAddressSpaces — List vnet address spaces. [GET /api/VirtualNetwork/{vnetId}/address-spaces].
func (a *VirtualNetworkApi) ListVnetAddressSpaces(ctx context.Context, vnetId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/VirtualNetwork/"+segment(vnetId, false)+"/address-spaces", nil, nil)
}

// ListVnetPeerings — List vnet peerings. [GET /api/VirtualNetwork/{vnetId}/peerings].
func (a *VirtualNetworkApi) ListVnetPeerings(ctx context.Context, vnetId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/VirtualNetwork/"+segment(vnetId, false)+"/peerings", nil, nil)
}

// ListVnetSubnets — List vnet subnets. [GET /api/VirtualNetwork/{vnetId}/subnets].
func (a *VirtualNetworkApi) ListVnetSubnets(ctx context.Context, vnetId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/VirtualNetwork/"+segment(vnetId, false)+"/subnets", nil, nil)
}

// SaveVnetAddressSpace — Save vnet address space. [PUT /api/VirtualNetwork/{vnetId}/address-spaces].
func (a *VirtualNetworkApi) SaveVnetAddressSpace(ctx context.Context, vnetId string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "PUT", "/api/VirtualNetwork/"+segment(vnetId, false)+"/address-spaces", body, nil)
}

// SaveVnetSubnet — Save vnet subnet. [PUT /api/VirtualNetwork/{vnetId}/subnets].
func (a *VirtualNetworkApi) SaveVnetSubnet(ctx context.Context, vnetId string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "PUT", "/api/VirtualNetwork/"+segment(vnetId, false)+"/subnets", body, nil)
}

// VmConsoleApi holds the VmConsole operations.
type VmConsoleApi struct{ c *Client }

// Console — Console. [GET /api/VirtualMachine/{id}/console].
func (a *VmConsoleApi) Console(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/VirtualMachine/"+segment(id_, false)+"/console", nil, nil)
}

// ConsoleTicket — Console ticket. [GET /api/VirtualMachine/{id}/console-ticket].
func (a *VmConsoleApi) ConsoleTicket(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/VirtualMachine/"+segment(id_, false)+"/console-ticket", nil, nil)
}

// VmNetworkApi holds the VmNetwork operations.
type VmNetworkApi struct{ c *Client }

// Create — Create. [POST /api/VirtualMachine/{vmName}/network-rules].
func (a *VmNetworkApi) Create(ctx context.Context, vmName string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/VirtualMachine/"+segment(vmName, false)+"/network-rules", body, nil)
}

// Delete — Delete. [DELETE /api/VirtualMachine/network-rules/{id}].
func (a *VmNetworkApi) Delete(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/VirtualMachine/network-rules/"+segment(id_, false), nil, nil)
}

// List — List. [GET /api/VirtualMachine/{vmName}/network-rules]. Query keys: type, direction.
func (a *VmNetworkApi) List(ctx context.Context, vmName string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/VirtualMachine/"+segment(vmName, false)+"/network-rules", nil, query)
}

// NetworkInfo — Network info. [GET /api/VirtualMachine/{vmName}/network-info].
func (a *VmNetworkApi) NetworkInfo(ctx context.Context, vmName string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/VirtualMachine/"+segment(vmName, false)+"/network-info", nil, nil)
}

// Sync — Sync. [POST /api/VirtualMachine/{vmName}/network-rules/sync].
func (a *VmNetworkApi) Sync(ctx context.Context, vmName string) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/VirtualMachine/"+segment(vmName, false)+"/network-rules/sync", nil, nil)
}

// Update — Update. [PUT /api/VirtualMachine/network-rules/{id}].
func (a *VmNetworkApi) Update(ctx context.Context, id_ string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "PUT", "/api/VirtualMachine/network-rules/"+segment(id_, false), body, nil)
}

// VmOperationsApi holds the VmOperations operations.
type VmOperationsApi struct{ c *Client }

// AttachNic — Attach nic. [POST /api/VirtualMachine/{vmName}/nics].
func (a *VmOperationsApi) AttachNic(ctx context.Context, vmName string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/VirtualMachine/"+segment(vmName, false)+"/nics", body, nil)
}

// AttachPublicIp — Attach public ip. [POST /api/VirtualMachine/{vmName}/public-ips].
func (a *VmOperationsApi) AttachPublicIp(ctx context.Context, vmName string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/VirtualMachine/"+segment(vmName, false)+"/public-ips", body, nil)
}

// Connect — Connect. [GET /api/VirtualMachine/{vmName}/connect].
func (a *VmOperationsApi) Connect(ctx context.Context, vmName string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/VirtualMachine/"+segment(vmName, false)+"/connect", nil, nil)
}

// CreateSnapshot — Create snapshot. [POST /api/VirtualMachine/{vmName}/snapshots].
func (a *VmOperationsApi) CreateSnapshot(ctx context.Context, vmName string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/VirtualMachine/"+segment(vmName, false)+"/snapshots", body, nil)
}

// DeleteSnapshot — Delete snapshot. [DELETE /api/VirtualMachine/{vmName}/snapshots/{snapshotName}].
func (a *VmOperationsApi) DeleteSnapshot(ctx context.Context, vmName string, snapshotName string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/VirtualMachine/"+segment(vmName, false)+"/snapshots/"+segment(snapshotName, false), nil, nil)
}

// DetachNic — Detach nic. [DELETE /api/VirtualMachine/{vmName}/nics/{mac}].
func (a *VmOperationsApi) DetachNic(ctx context.Context, vmName string, mac string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/VirtualMachine/"+segment(vmName, false)+"/nics/"+segment(mac, false), nil, nil)
}

// DetachPublicIp — Detach public ip. [DELETE /api/VirtualMachine/{vmName}/public-ips/{allocationId}].
func (a *VmOperationsApi) DetachPublicIp(ctx context.Context, vmName string, allocationId string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/VirtualMachine/"+segment(vmName, false)+"/public-ips/"+segment(allocationId, false), nil, nil)
}

// ListNics — List nics. [GET /api/VirtualMachine/{vmName}/nics].
func (a *VmOperationsApi) ListNics(ctx context.Context, vmName string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/VirtualMachine/"+segment(vmName, false)+"/nics", nil, nil)
}

// ListPublicIps — List public ips. [GET /api/VirtualMachine/{vmName}/public-ips].
func (a *VmOperationsApi) ListPublicIps(ctx context.Context, vmName string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/VirtualMachine/"+segment(vmName, false)+"/public-ips", nil, nil)
}

// ListSnapshots — List snapshots. [GET /api/VirtualMachine/{vmName}/snapshots].
func (a *VmOperationsApi) ListSnapshots(ctx context.Context, vmName string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/VirtualMachine/"+segment(vmName, false)+"/snapshots", nil, nil)
}

// RdpFile — Rdp file. [GET /api/VirtualMachine/{vmName}/rdp-file].
func (a *VmOperationsApi) RdpFile(ctx context.Context, vmName string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/VirtualMachine/"+segment(vmName, false)+"/rdp-file", nil, nil)
}

// RestoreSnapshot — Restore snapshot. [POST /api/VirtualMachine/{vmName}/snapshots/{snapshotName}/restore].
func (a *VmOperationsApi) RestoreSnapshot(ctx context.Context, vmName string, snapshotName string) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/VirtualMachine/"+segment(vmName, false)+"/snapshots/"+segment(snapshotName, false)+"/restore", nil, nil)
}

// SshKey — Ssh key. [GET /api/VirtualMachine/{vmName}/ssh-key].
func (a *VmOperationsApi) SshKey(ctx context.Context, vmName string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/VirtualMachine/"+segment(vmName, false)+"/ssh-key", nil, nil)
}

// WebmailApi holds the Webmail operations.
type WebmailApi struct{ c *Client }

// Assist — Assist. [POST /api/mail/assist]. Query keys: accountId.
func (a *WebmailApi) Assist(ctx context.Context, body any, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/mail/assist", body, query)
}

// Attachment — Attachment. [GET /api/mail/messages/{id}/attachments/{attachmentId}]. Query keys: accountId.
func (a *WebmailApi) Attachment(ctx context.Context, id_ string, attachmentId string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/mail/messages/"+segment(id_, false)+"/attachments/"+segment(attachmentId, false), nil, query)
}

// ChangePassword — Change password. [POST /api/mail/password].
func (a *WebmailApi) ChangePassword(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/mail/password", body, nil)
}

// Contacts — Contacts. [GET /api/mail/contacts]. Query keys: accountId, q.
func (a *WebmailApi) Contacts(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/mail/contacts", nil, query)
}

// CreateFilter — Create filter. [POST /api/mail/filters]. Query keys: accountId.
func (a *WebmailApi) CreateFilter(ctx context.Context, body any, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/mail/filters", body, query)
}

// CreateFolder — Create folder. [POST /api/mail/folders]. Query keys: accountId.
func (a *WebmailApi) CreateFolder(ctx context.Context, body any, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/mail/folders", body, query)
}

// CreateLabel — Create label. [POST /api/mail/labels]. Query keys: accountId.
func (a *WebmailApi) CreateLabel(ctx context.Context, body any, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/mail/labels", body, query)
}

// Delete — Delete. [POST /api/mail/messages/delete]. Query keys: accountId.
func (a *WebmailApi) Delete(ctx context.Context, body any, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/mail/messages/delete", body, query)
}

// DeleteFilter — Delete filter. [DELETE /api/mail/filters/{id}]. Query keys: accountId.
func (a *WebmailApi) DeleteFilter(ctx context.Context, id_ string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/mail/filters/"+segment(id_, false), nil, query)
}

// DropUpload — Drop upload. [DELETE /api/mail/attachments/{id}]. Query keys: accountId.
func (a *WebmailApi) DropUpload(ctx context.Context, id_ string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/mail/attachments/"+segment(id_, false), nil, query)
}

// Filters — Filters. [GET /api/mail/filters]. Query keys: accountId.
func (a *WebmailApi) Filters(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/mail/filters", nil, query)
}

// Flag — Flag. [POST /api/mail/messages/flag]. Query keys: accountId.
func (a *WebmailApi) Flag(ctx context.Context, body any, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/mail/messages/flag", body, query)
}

// Folders — Folders. [GET /api/mail/folders]. Query keys: accountId.
func (a *WebmailApi) Folders(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/mail/folders", nil, query)
}

// Me — Me. [GET /api/mail/me].
func (a *WebmailApi) Me(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/mail/me", nil, nil)
}

// Message — Message. [GET /api/mail/messages/{id}]. Query keys: accountId, markRead.
func (a *WebmailApi) Message(ctx context.Context, id_ string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/mail/messages/"+segment(id_, false), nil, query)
}

// Messages — Messages. [GET /api/mail/messages]. Query keys: accountId, folderId, q, unread, starred, page, pageSize.
func (a *WebmailApi) Messages(ctx context.Context, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/mail/messages", nil, query)
}

// Mine — Mine. [GET /api/mail/mine].
func (a *WebmailApi) Mine(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/mail/mine", nil, nil)
}

// Move — Move. [POST /api/mail/messages/move]. Query keys: accountId.
func (a *WebmailApi) Move(ctx context.Context, body any, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/mail/messages/move", body, query)
}

// Quote — Quote. [GET /api/mail/messages/{id}/quote]. Query keys: accountId, forward.
func (a *WebmailApi) Quote(ctx context.Context, id_ string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/mail/messages/"+segment(id_, false)+"/quote", nil, query)
}

// SaveDraft — Save draft. [POST /api/mail/draft]. Query keys: accountId.
func (a *WebmailApi) SaveDraft(ctx context.Context, body any, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/mail/draft", body, query)
}

// Schedule — Schedule. [POST /api/mail/schedule]. Query keys: accountId.
func (a *WebmailApi) Schedule(ctx context.Context, body any, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/mail/schedule", body, query)
}

// Send — Send. [POST /api/mail/send]. Query keys: accountId.
func (a *WebmailApi) Send(ctx context.Context, body any, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/mail/send", body, query)
}

// Settings — Settings. [PATCH /api/mail/settings]. Query keys: accountId.
func (a *WebmailApi) Settings(ctx context.Context, body any, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "PATCH", "/api/mail/settings", body, query)
}

// SignIn — Sign in. [POST /api/mail/signin].
func (a *WebmailApi) SignIn(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/mail/signin", body, nil)
}

// SignOut — Sign out. [POST /api/mail/signout].
func (a *WebmailApi) SignOut(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/mail/signout", nil, nil)
}

// Unschedule — Unschedule. [POST /api/mail/schedule/{id}/cancel]. Query keys: accountId.
func (a *WebmailApi) Unschedule(ctx context.Context, id_ string, query Query) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/mail/schedule/"+segment(id_, false)+"/cancel", nil, query)
}

// Upload — Upload. [POST /api/mail/attachments]. Query keys: accountId.
func (a *WebmailApi) Upload(ctx context.Context, form map[string]string, files map[string]FilePart, query Query) (json.RawMessage, error) {
	return a.c.CallMultipart(ctx, "POST", "/api/mail/attachments", form, files, query)
}

// WidgetApi holds the Widget operations.
type WidgetApi struct{ c *Client }

// AddWidgetToPanel — Add widget to panel. [POST /api/Widget/addwidgettopanel].
func (a *WidgetApi) AddWidgetToPanel(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Widget/addwidgettopanel", body, nil)
}

// CloneWidget — Clone widget. [POST /api/Widget/clonewidget].
func (a *WidgetApi) CloneWidget(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Widget/clonewidget", body, nil)
}

// CreateDefaultWidgets — Create default widgets. [POST /api/Widget/createdefaultwidgets].
func (a *WidgetApi) CreateDefaultWidgets(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Widget/createdefaultwidgets", body, nil)
}

// CreateWidgetTemplate — Create widget template. [POST /api/Widget/createwidgettemplate].
func (a *WidgetApi) CreateWidgetTemplate(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Widget/createwidgettemplate", body, nil)
}

// CreateWidgetsTemplate — Create widgets template. [POST /api/Widget/createwidgetstemplate].
func (a *WidgetApi) CreateWidgetsTemplate(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Widget/createwidgetstemplate", body, nil)
}

// DefaultWidgets — Default widgets. [GET /api/Widget/defaultwidgets].
func (a *WidgetApi) DefaultWidgets(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Widget/defaultwidgets", nil, nil)
}

// DeleteWidgetFromPanel — Delete widget from panel. [DELETE /api/Widget/deletepanelwidget].
func (a *WidgetApi) DeleteWidgetFromPanel(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/Widget/deletepanelwidget", body, nil)
}

// DeleteWidgetTemplate — Delete widget template. [DELETE /api/Widget/deletewidgettemplate/{id}].
func (a *WidgetApi) DeleteWidgetTemplate(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/Widget/deletewidgettemplate/"+segment(id_, false), nil, nil)
}

// GetWidgetSettings — Get widget settings. [POST /api/Widget/getwidgetsettings].
func (a *WidgetApi) GetWidgetSettings(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Widget/getwidgetsettings", body, nil)
}

// UpdateWidgetPosition — Update widget position. [POST /api/Widget/updatewidgetposition].
func (a *WidgetApi) UpdateWidgetPosition(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Widget/updatewidgetposition", body, nil)
}

// UpdateWidgetSettings — Update widget settings. [POST /api/Widget/updatewidgetsettings].
func (a *WidgetApi) UpdateWidgetSettings(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Widget/updatewidgetsettings", body, nil)
}

// UpdateWidgetTemplate — Update widget template. [PUT /api/Widget/updatewidgettemplate/{id}].
func (a *WidgetApi) UpdateWidgetTemplate(ctx context.Context, id_ string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "PUT", "/api/Widget/updatewidgettemplate/"+segment(id_, false), body, nil)
}

// WidgetDetails — Widget details. [POST /api/Widget/widgetdetails].
func (a *WidgetApi) WidgetDetails(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Widget/widgetdetails", body, nil)
}

// WidgetLibrary — Widget library. [GET /api/Widget/widgetlibrary].
func (a *WidgetApi) WidgetLibrary(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Widget/widgetlibrary", nil, nil)
}

// WidgetOptions — Widget options. [POST /api/Widget/widgetoptions].
func (a *WidgetApi) WidgetOptions(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Widget/widgetoptions", body, nil)
}

// Widgets — Widgets. [POST /api/Widget/widgets].
func (a *WidgetApi) Widgets(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Widget/widgets", body, nil)
}

// YugabyteApi holds the Yugabyte operations.
type YugabyteApi struct{ c *Client }

// Attach — Attach. [POST /api/Yugabyte/{id}/vnet/attach].
func (a *YugabyteApi) Attach(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Yugabyte/"+segment(id_, false)+"/vnet/attach", nil, nil)
}

// Columns — Columns. [GET /api/Yugabyte/{id}/tables/{schema}/{table}/columns].
func (a *YugabyteApi) Columns(ctx context.Context, id_ string, schema string, table string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Yugabyte/"+segment(id_, false)+"/tables/"+segment(schema, false)+"/"+segment(table, false)+"/columns", nil, nil)
}

// Connection — Connection. [GET /api/Yugabyte/{id}/connection].
func (a *YugabyteApi) Connection(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Yugabyte/"+segment(id_, false)+"/connection", nil, nil)
}

// Create — Create. [POST /api/Yugabyte].
func (a *YugabyteApi) Create(ctx context.Context, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Yugabyte", body, nil)
}

// Delete — Delete. [DELETE /api/Yugabyte/{id}].
func (a *YugabyteApi) Delete(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "DELETE", "/api/Yugabyte/"+segment(id_, false), nil, nil)
}

// Detach — Detach. [POST /api/Yugabyte/{id}/vnet/detach].
func (a *YugabyteApi) Detach(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Yugabyte/"+segment(id_, false)+"/vnet/detach", nil, nil)
}

// Get — Get. [GET /api/Yugabyte/{id}].
func (a *YugabyteApi) Get(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Yugabyte/"+segment(id_, false), nil, nil)
}

// List — List. [GET /api/Yugabyte].
func (a *YugabyteApi) List(ctx context.Context) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Yugabyte", nil, nil)
}

// Query — Query. [POST /api/Yugabyte/{id}/query].
func (a *YugabyteApi) Query(ctx context.Context, id_ string, body any) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Yugabyte/"+segment(id_, false)+"/query", body, nil)
}

// Start — Start. [POST /api/Yugabyte/{id}/start].
func (a *YugabyteApi) Start(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Yugabyte/"+segment(id_, false)+"/start", nil, nil)
}

// Stop — Stop. [POST /api/Yugabyte/{id}/stop].
func (a *YugabyteApi) Stop(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "POST", "/api/Yugabyte/"+segment(id_, false)+"/stop", nil, nil)
}

// Tables — Tables. [GET /api/Yugabyte/{id}/tables].
func (a *YugabyteApi) Tables(ctx context.Context, id_ string) (json.RawMessage, error) {
	return a.c.Call(ctx, "GET", "/api/Yugabyte/"+segment(id_, false)+"/tables", nil, nil)
}
