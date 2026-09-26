// Package hiok provides a small, dependency-free client for HIOK Cloud.
package hiok

import (
	"bytes"
	"context"
	"encoding/json"
	"fmt"
	"io"
	"net/http"
	"net/url"
	"strings"
	"sync"
	"time"
)

type Client struct {
	Endpoint string
	Token    string
	HTTP     *http.Client
	// StorageKey is a storage account access key, used when Token is empty. It opens
	// only that account's containers, file shares, queues and tables.
	StorageKey string
	// ClientID and ClientSecret are a service principal's credentials (CI/CD). With
	// them set and no Token, the client signs in on first use and again before the
	// one-hour token runs out.
	ClientID     string
	ClientSecret string
	// Retries is how many times a GET that meets 429/502/503/504 is retried (default 4).
	Retries int

	apiOnce sync.Once
	api     *Api

	spMu      sync.Mutex
	spExpires time.Time
}

func New(endpoint, token string) *Client {
	if endpoint == "" {
		endpoint = "https://hiokcloud.com"
	}
	return &Client{Endpoint: strings.TrimRight(endpoint, "/"), Token: token, HTTP: &http.Client{Timeout: 10 * time.Minute}, Retries: 4}
}

func (c *Client) Login(ctx context.Context, email, password string) error {
	var response struct {
		Data struct {
			Token string `json:"token"`
		} `json:"data"`
		Message string `json:"message"`
	}
	if err := c.Do(ctx, http.MethodPost, "/api/OAuth/token", map[string]string{"email": email, "password": password}, &response, false); err != nil {
		return err
	}
	if response.Data.Token == "" {
		return fmt.Errorf("sign-in failed: %s", response.Message)
	}
	c.Token = response.Data.Token
	return nil
}

// LoginServicePrincipal signs in with a service principal's client ID and secret
// (POST /api/OAuth/token/client). The token lasts an hour; a client built with
// ClientID/ClientSecret renews it by itself.
func (c *Client) LoginServicePrincipal(ctx context.Context, clientID, clientSecret string) error {
	var response struct {
		Data struct {
			Token string `json:"token"`
		} `json:"data"`
		Message string `json:"message"`
	}
	if err := c.Do(ctx, http.MethodPost, "/api/OAuth/token/client",
		map[string]string{"clientId": clientID, "clientSecret": clientSecret}, &response, false); err != nil {
		return err
	}
	if response.Data.Token == "" {
		return fmt.Errorf("service principal sign-in failed: %s", response.Message)
	}
	c.ClientID, c.ClientSecret = clientID, clientSecret
	c.Token = response.Data.Token
	c.spExpires = time.Now().Add(55 * time.Minute)
	return nil
}

// ensureToken signs a service principal in when there is no token yet, or when the
// one it got is about to expire.
func (c *Client) ensureToken(ctx context.Context) error {
	if c.ClientID == "" || c.ClientSecret == "" {
		return nil
	}
	c.spMu.Lock()
	defer c.spMu.Unlock()
	if c.Token != "" && (c.spExpires.IsZero() || time.Now().Before(c.spExpires)) {
		return nil
	}
	return c.LoginServicePrincipal(ctx, c.ClientID, c.ClientSecret)
}

func (c *Client) Do(ctx context.Context, method, path string, in, out any, auth bool) error {
	var body io.Reader
	if in != nil {
		raw, err := json.Marshal(in)
		if err != nil {
			return err
		}
		body = bytes.NewReader(raw)
	}
	req, err := http.NewRequestWithContext(ctx, method, c.Endpoint+path, body)
	if err != nil {
		return err
	}
	req.Header.Set("Accept", "application/json")
	if in != nil {
		req.Header.Set("Content-Type", "application/json")
	}
	if auth {
		if err := c.ensureToken(ctx); err != nil {
			return err
		}
		if c.Token == "" {
			return fmt.Errorf("no token configured")
		}
		req.Header.Set("Authorization", "Bearer "+c.Token)
	}
	resp, err := c.HTTP.Do(req)
	if err != nil {
		return err
	}
	defer resp.Body.Close()
	raw, _ := io.ReadAll(resp.Body)
	if resp.StatusCode < 200 || resp.StatusCode > 299 {
		return fmt.Errorf("%s %s returned %d: %s", method, path, resp.StatusCode, strings.TrimSpace(string(raw)))
	}
	if out != nil && len(raw) > 0 {
		return json.Unmarshal(raw, out)
	}
	return nil
}

// DoRaw returns the response body untouched, for endpoints that answer with a file
// rather than JSON — a VPN client profile, for example.
func (c *Client) DoRaw(ctx context.Context, method, path string) ([]byte, error) {
	req, err := http.NewRequestWithContext(ctx, method, c.Endpoint+path, nil)
	if err != nil {
		return nil, err
	}
	if err := c.ensureToken(ctx); err != nil {
		return nil, err
	}
	if c.Token == "" {
		return nil, fmt.Errorf("no token configured")
	}
	req.Header.Set("Authorization", "Bearer "+c.Token)

	resp, err := c.HTTP.Do(req)
	if err != nil {
		return nil, err
	}
	defer resp.Body.Close()

	raw, _ := io.ReadAll(resp.Body)
	if resp.StatusCode < 200 || resp.StatusCode > 299 {
		return nil, fmt.Errorf("%s %s returned %d: %s", method, path, resp.StatusCode, strings.TrimSpace(string(raw)))
	}
	return raw, nil
}

func (c *Client) Regions(ctx context.Context) ([]map[string]any, error) {
	var r struct {
		Data []map[string]any `json:"data"`
	}
	err := c.Do(ctx, http.MethodGet, "/api/storageaccount/regions", nil, &r, false)
	return r.Data, err
}
func (c *Client) VirtualMachines(ctx context.Context) ([]map[string]any, error) {
	var r struct {
		Data []map[string]any `json:"data"`
	}
	err := c.Do(ctx, http.MethodGet, "/api/VirtualMachine/list-vms-info", nil, &r, true)
	return r.Data, err
}

func (c *Client) CreateVirtualMachine(ctx context.Context, name, region, image string, vcpus int, ramGB float64) error {
	if region == "" {
		region = "canada"
	}
	if image == "" {
		image = "ubuntu-24.04"
	}
	if vcpus <= 0 {
		vcpus = 1
	}
	if ramGB <= 0 {
		ramGB = 1
	}
	return c.Do(ctx, http.MethodPost, "/api/VirtualMachine/create-vm", map[string]any{
		"vmName": name, "regions": []string{region}, "sourceFilePath": image,
		"vcpuCount": vcpus, "ramSize": ramGB,
	}, nil, true)
}

// ── Service Bus ─────────────────────────────────────────────────────────────

// ServiceBusNamespaces lists the namespaces holding your queues and topics.
func (c *Client) ServiceBusNamespaces(ctx context.Context) ([]map[string]any, error) {
	var out struct {
		Data []map[string]any `json:"data"`
	}
	if err := c.Do(ctx, "GET", "/api/ServiceBus/namespaces", nil, &out, true); err != nil {
		return nil, err
	}
	return out.Data, nil
}

func (c *Client) CreateServiceBusNamespace(ctx context.Context, name, region, sku string) error {
	if region == "" {
		region = "canada"
	}
	if sku == "" {
		sku = "standard"
	}
	return c.Do(ctx, "POST", "/api/ServiceBus/namespaces", map[string]any{
		"name": name, "product": "servicebus", "primaryRegion": region, "sku": sku,
	}, nil, true)
}

func (c *Client) CreateQueue(ctx context.Context, namespaceID, name string, maxDeliveryCount int, requiresSession bool) error {
	if maxDeliveryCount <= 0 {
		maxDeliveryCount = 10
	}
	return c.Do(ctx, "POST", fmt.Sprintf("/api/ServiceBus/namespaces/%s/queues", namespaceID), map[string]any{
		"name": name, "maxDeliveryCount": maxDeliveryCount,
		"requiresSession": requiresSession, "deadLetteringEnabled": true,
	}, nil, true)
}

// SendMessage publishes one message. Pass a non-empty scheduledEnqueueTime (RFC3339)
// to hold it until that instant.
func (c *Client) SendMessage(ctx context.Context, namespaceID, entity, body, subject, scheduledEnqueueTime string) error {
	payload := map[string]any{"body": body}
	if subject != "" {
		payload["subject"] = subject
	}
	if scheduledEnqueueTime != "" {
		payload["scheduledEnqueueTime"] = scheduledEnqueueTime
	}
	return c.Do(ctx, "POST",
		fmt.Sprintf("/api/ServiceBus/namespaces/%s/entities/%s/messages", namespaceID, entity),
		payload, nil, true)
}

// ReceiveMessages takes messages under lock; settle each one to complete it.
func (c *Client) ReceiveMessages(ctx context.Context, namespaceID, entity, subscription string, max int) ([]map[string]any, error) {
	if max <= 0 {
		max = 1
	}
	path := fmt.Sprintf("/api/ServiceBus/namespaces/%s/entities/%s/messages/receive", namespaceID, entity)
	if subscription != "" {
		path += "?subscription=" + url.QueryEscape(subscription)
	}
	var out struct {
		Data []map[string]any `json:"data"`
	}
	body := map[string]any{"maxMessages": max, "receiveMode": "peek_lock"}
	if err := c.Do(ctx, "POST", path, body, &out, true); err != nil {
		return nil, err
	}
	return out.Data, nil
}

// SettleMessages finishes a delivery: complete, abandon, deadletter or defer.
func (c *Client) SettleMessages(ctx context.Context, namespaceID, entity, subscription string, lockTokens []string, disposition string) error {
	path := fmt.Sprintf("/api/ServiceBus/namespaces/%s/entities/%s/messages/settle", namespaceID, entity)
	if subscription != "" {
		path += "?subscription=" + url.QueryEscape(subscription)
	}
	return c.Do(ctx, "POST", path, map[string]any{
		"lockTokens": lockTokens, "disposition": disposition,
	}, nil, true)
}

// ── Event Mesh ──────────────────────────────────────────────────────────────

func (c *Client) CreateEventStream(ctx context.Context, namespaceID, name string, partitions, retentionHours int) error {
	if partitions <= 0 {
		partitions = 4
	}
	if retentionHours <= 0 {
		retentionHours = 168
	}
	return c.Do(ctx, "POST", fmt.Sprintf("/api/Pulse/namespaces/%s/streams", namespaceID), map[string]any{
		"name": name, "partitionCount": partitions, "retentionHours": retentionHours,
	}, nil, true)
}

// PublishEvents writes events to a stream. Each event is {type, subject, data}.
func (c *Client) PublishEvents(ctx context.Context, namespaceID, stream string, events []map[string]any) error {
	return c.Do(ctx, "POST",
		fmt.Sprintf("/api/Pulse/namespaces/%s/streams/%s/events", namespaceID, stream),
		map[string]any{"events": events}, nil, true)
}

// ReadEvents reads through a consumer group, advancing that group's cursor.
func (c *Client) ReadEvents(ctx context.Context, namespaceID, stream, consumerGroup string, max int) ([]map[string]any, error) {
	if max <= 0 {
		max = 10
	}
	path := fmt.Sprintf("/api/Pulse/namespaces/%s/streams/%s/events/read?consumerGroup=%s&maxEvents=%d",
		namespaceID, stream, url.QueryEscape(consumerGroup), max)
	var out struct {
		Data struct {
			Events []map[string]any `json:"events"`
		} `json:"data"`
	}
	if err := c.Do(ctx, "POST", path, map[string]any{}, &out, true); err != nil {
		return nil, err
	}
	return out.Data.Events, nil
}

// ── Communication ───────────────────────────────────────────────────────────

// SendEmail sends mail. Leave from empty to use the domain's default sender.
func (c *Client) SendEmail(ctx context.Context, serviceID string, to []string, subject, text, html, from string) error {
	return c.Do(ctx, "POST", fmt.Sprintf("/api/Communication/services/%s/emails", serviceID), map[string]any{
		"to": to, "subject": subject, "textBody": text, "htmlBody": html, "from": from,
	}, nil, true)
}

// ── Bastion ─────────────────────────────────────────────────────────────────

// StartBastionSession opens a browser session and returns the portal URL plus a
// short-lived signed token for exactly one target.
func (c *Client) StartBastionSession(ctx context.Context, bastionID, targetVMID, targetAddress, protocol, username, password string, ttlMinutes int) (map[string]any, error) {
	if protocol == "" {
		protocol = "rdp"
	}
	if ttlMinutes <= 0 {
		ttlMinutes = 60
	}
	payload := map[string]any{"protocol": protocol, "ttlMinutes": ttlMinutes}
	if targetVMID != "" {
		payload["targetVmId"] = targetVMID
	} else {
		payload["targetAddress"] = targetAddress
	}
	if username != "" {
		payload["username"] = username
	}
	if password != "" {
		payload["password"] = password
	}

	var out struct {
		Data map[string]any `json:"data"`
	}
	if err := c.Do(ctx, "POST", fmt.Sprintf("/api/Bastion/%s/sessions", bastionID), payload, &out, true); err != nil {
		return nil, err
	}
	return out.Data, nil
}

func (c *Client) Search(ctx context.Context, query string) (map[string]any, error) {
	var r struct {
		Data map[string]any `json:"data"`
	}
	err := c.Do(ctx, http.MethodGet, "/api/search?q="+url.QueryEscape(query), nil, &r, true)
	return r.Data, err
}

// ── Analytics (managed ClickHouse) ───────────────────────────────────────────

// AnalyticsClusterOptions configures a new analytics cluster. Zero values fall back
// to the service defaults, so only what you care about needs setting.
type AnalyticsClusterOptions struct {
	Region        string
	SKU           string // dev, small, medium or large
	StorageGB     int
	DatabaseName  string
	AdminUsername string
	EngineVersion string
	// VNetName and VNetAddress give the cluster an interface on a virtual network,
	// so machines there reach it privately. VNetAddress is CIDR, e.g. 10.0.0.20/24.
	VNetName    string
	VNetAddress string
}

func (c *Client) AnalyticsClusters(ctx context.Context) ([]map[string]any, error) {
	var r struct {
		Data []map[string]any `json:"data"`
	}
	err := c.Do(ctx, http.MethodGet, "/api/Analytics", nil, &r, true)
	return r.Data, err
}

func (c *Client) CreateAnalyticsCluster(ctx context.Context, name string, opts AnalyticsClusterOptions) (map[string]any, error) {
	payload := map[string]any{"clusterName": name}
	if opts.Region != "" {
		payload["region"] = opts.Region
	}
	if opts.SKU != "" {
		payload["sku"] = opts.SKU
	}
	if opts.StorageGB > 0 {
		payload["storageGb"] = opts.StorageGB
	}
	if opts.DatabaseName != "" {
		payload["databaseName"] = opts.DatabaseName
	}
	if opts.AdminUsername != "" {
		payload["adminUsername"] = opts.AdminUsername
	}
	if opts.EngineVersion != "" {
		payload["engineVersion"] = opts.EngineVersion
	}
	if opts.VNetName != "" {
		payload["vnetName"] = opts.VNetName
		payload["vnetAddress"] = opts.VNetAddress
	}

	var r struct {
		Data map[string]any `json:"data"`
	}
	err := c.Do(ctx, http.MethodPost, "/api/Analytics", payload, &r, true)
	return r.Data, err
}

func (c *Client) DeleteAnalyticsCluster(ctx context.Context, clusterID string) error {
	return c.Do(ctx, http.MethodDelete, "/api/Analytics/"+clusterID, nil, nil, true)
}

func (c *Client) StartAnalyticsCluster(ctx context.Context, clusterID string) (map[string]any, error) {
	var r struct {
		Data map[string]any `json:"data"`
	}
	err := c.Do(ctx, http.MethodPost, fmt.Sprintf("/api/Analytics/%s/start", clusterID), map[string]any{}, &r, true)
	return r.Data, err
}

func (c *Client) StopAnalyticsCluster(ctx context.Context, clusterID string) (map[string]any, error) {
	var r struct {
		Data map[string]any `json:"data"`
	}
	err := c.Do(ctx, http.MethodPost, fmt.Sprintf("/api/Analytics/%s/stop", clusterID), map[string]any{}, &r, true)
	return r.Data, err
}

// AnalyticsConnection returns connection details including the password.
func (c *Client) AnalyticsConnection(ctx context.Context, clusterID string) (map[string]any, error) {
	var r struct {
		Data map[string]any `json:"data"`
	}
	err := c.Do(ctx, http.MethodGet, fmt.Sprintf("/api/Analytics/%s/connection", clusterID), nil, &r, true)
	return r.Data, err
}

func (c *Client) AnalyticsTables(ctx context.Context, clusterID string) ([]map[string]any, error) {
	var r struct {
		Data []map[string]any `json:"data"`
	}
	err := c.Do(ctx, http.MethodGet, fmt.Sprintf("/api/Analytics/%s/tables", clusterID), nil, &r, true)
	return r.Data, err
}

// AnalyticsQuery runs SQL and returns columns, rows, timing and bytes read.
// A statement that fails still returns without error: check the "isSuccess" field
// and read the engine's diagnostic from "error".
func (c *Client) AnalyticsQuery(ctx context.Context, clusterID, sql string, maxRows int) (map[string]any, error) {
	if maxRows <= 0 {
		maxRows = 1000
	}
	var r struct {
		Data map[string]any `json:"data"`
	}
	err := c.Do(ctx, http.MethodPost, fmt.Sprintf("/api/Analytics/%s/query", clusterID),
		map[string]any{"sql": sql, "maxRows": maxRows}, &r, true)
	return r.Data, err
}

func (c *Client) SetAnalyticsVNet(ctx context.Context, clusterID string, attach bool) (map[string]any, error) {
	action := "detach"
	if attach {
		action = "attach"
	}
	var r struct {
		Data map[string]any `json:"data"`
	}
	err := c.Do(ctx, http.MethodPost, fmt.Sprintf("/api/Analytics/%s/vnet/%s", clusterID, action),
		map[string]any{}, &r, true)
	return r.Data, err
}

// ── Live streaming ───────────────────────────────────────────────────────────

// StreamingEndpoints lists endpoints; each item carries the endpoint plus its
// ingest and playback URLs.
func (c *Client) StreamingEndpoints(ctx context.Context) ([]map[string]any, error) {
	var r struct {
		Data []map[string]any `json:"data"`
	}
	err := c.Do(ctx, http.MethodGet, "/api/streaming", nil, &r, true)
	return r.Data, err
}

// CreateStreamingEndpoint creates an endpoint. kind is camera, video or content;
// an empty kind uses the service default.
func (c *Client) CreateStreamingEndpoint(ctx context.Context, name, region, kind string) (map[string]any, error) {
	payload := map[string]any{"name": name}
	if region != "" {
		payload["region"] = region
	}
	if kind != "" {
		payload["kind"] = kind
	}
	var r struct {
		Data map[string]any `json:"data"`
	}
	err := c.Do(ctx, http.MethodPost, "/api/streaming", payload, &r, true)
	return r.Data, err
}

func (c *Client) DeleteStreamingEndpoint(ctx context.Context, endpointID string) error {
	return c.Do(ctx, http.MethodDelete, "/api/streaming/"+endpointID, nil, nil, true)
}

// ── Public IP addresses ──────────────────────────────────────────────────────
//
// A region routes a whole IPv6 prefix, so every VM and container can hold a real
// public address from it. IPv4 is a single provider address that IS the host, so
// that pool is marked not assignable and the API says so rather than returning
// nothing.
//
// These routes are gated on the "infrastructure" backoffice grant: they hand out
// provider address space, which is not an ordinary tenant operation.

// IPPools lists the address ranges the platform can hand out. Pass an empty region
// for every region. A range with Assignable=false carries the reason in Notes.
func (c *Client) IPPools(ctx context.Context, region string) ([]map[string]any, error) {
	path := "/api/Infrastructure/ip-pools"
	if region != "" {
		path += "?region=" + url.QueryEscape(region)
	}
	var r struct {
		Data []map[string]any `json:"data"`
	}
	err := c.Do(ctx, http.MethodGet, path, nil, &r, true)
	return r.Data, err
}

// IPAllocations lists addresses currently held. Released addresses are kept for the
// record and are only returned when includeReleased is set.
func (c *Client) IPAllocations(ctx context.Context, region string, includeReleased bool) ([]map[string]any, error) {
	query := url.Values{}
	if region != "" {
		query.Set("region", region)
	}
	if includeReleased {
		query.Set("includeReleased", "true")
	}
	path := "/api/Infrastructure/ip-allocations"
	if len(query) > 0 {
		path += "?" + query.Encode()
	}
	var r struct {
		Data []map[string]any `json:"data"`
	}
	err := c.Do(ctx, http.MethodGet, path, nil, &r, true)
	return r.Data, err
}

// AllocateIPRequest describes one address assignment.
type AllocateIPRequest struct {
	Region       string `json:"region,omitempty"`
	Family       int    `json:"family,omitempty"`
	ResourceKind string `json:"resourceKind,omitempty"`
	ResourceID   string `json:"resourceId,omitempty"`
	ResourceName string `json:"resourceName,omitempty"`
	// TargetContainer is the name the HOST knows the guest by — the Docker container
	// name, or the libvirt domain, which for a VM is "<guid>#<name>". Leave it empty
	// to reserve an address without configuring anything.
	TargetContainer string `json:"targetContainer,omitempty"`
	// TargetKind is "container" (default) or "vm".
	TargetKind string `json:"targetKind,omitempty"`
	// Hostname publishes DNS for the address. A bare label lands in the managed zone.
	Hostname string `json:"hostname,omitempty"`
	// SetReverseDNS publishes a PTR as well. The provider forward-confirms, so this
	// can only succeed once the forward record is live — which is why the API
	// publishes that first.
	SetReverseDNS *bool `json:"setReverseDns,omitempty"`
}

// AllocateIP takes the next free address and, when a target is named, configures the
// host so the address actually reaches it.
func (c *Client) AllocateIP(ctx context.Context, req AllocateIPRequest) (map[string]any, error) {
	if req.Family == 0 {
		req.Family = 6
	}
	var r struct {
		Data map[string]any `json:"data"`
	}
	err := c.Do(ctx, http.MethodPost, "/api/Infrastructure/ip-allocations", req, &r, true)
	return r.Data, err
}

// ReleaseIP gives an address back and removes the host configuration carrying it.
// Pass an empty targetContainer to use the target recorded when it was allocated.
func (c *Client) ReleaseIP(ctx context.Context, allocationID, targetContainer string) error {
	path := "/api/Infrastructure/ip-allocations/" + allocationID
	if targetContainer != "" {
		path += "?targetContainer=" + url.QueryEscape(targetContainer)
	}
	return c.Do(ctx, http.MethodDelete, path, nil, nil, true)
}

// ReconcileIPs re-applies every live allocation on the hosts that carry them.
//
// Host routes and NDP proxy entries do not survive a reboot, so something has to put
// them back. The platform does this on a timer; call this when you already know a
// host has just come back and do not want to wait for the next pass.
func (c *Client) ReconcileIPs(ctx context.Context, region string) ([]map[string]any, error) {
	path := "/api/Infrastructure/ip-allocations/reconcile"
	if region != "" {
		path += "?region=" + url.QueryEscape(region)
	}
	var r struct {
		Data []map[string]any `json:"data"`
	}
	err := c.Do(ctx, http.MethodPost, path, map[string]any{}, &r, true)
	return r.Data, err
}

// ── Key Vault ───────────────────────────────────────────────────────────────

type CreateKeyVaultRequest struct {
	Name string `json:"name"`
	// PrimaryRegion answers reads and writes; it is added to Regions automatically.
	PrimaryRegion string   `json:"primaryRegion,omitempty"`
	Regions       []string `json:"regions,omitempty"`
	// Leave VnetID empty for a vault reachable wherever the caller can authenticate.
	VnetID       string   `json:"vnetId,omitempty"`
	VnetName     string   `json:"vnetName,omitempty"`
	AllowedCidrs []string `json:"allowedCidrs,omitempty"`
	// SoftDeleteRetentionDays is clamped to 7-365; 0 means the default of 90.
	SoftDeleteRetentionDays int `json:"softDeleteRetentionDays,omitempty"`
	// PurgeProtection can be switched on later but never off.
	PurgeProtection bool `json:"purgeProtection,omitempty"`
}

func (c *Client) CreateKeyVault(ctx context.Context, req CreateKeyVaultRequest) (map[string]any, error) {
	var r map[string]any
	err := c.Do(ctx, http.MethodPost, "/api/KeyVault", req, &r, true)
	return r, err
}

func (c *Client) KeyVaults(ctx context.Context) ([]map[string]any, error) {
	var r []map[string]any
	err := c.Do(ctx, http.MethodGet, "/api/KeyVault", nil, &r, true)
	return r, err
}

// DeletedKeyVaults lists vaults inside their recovery window.
func (c *Client) DeletedKeyVaults(ctx context.Context) ([]map[string]any, error) {
	var r []map[string]any
	err := c.Do(ctx, http.MethodGet, "/api/KeyVault/deleted", nil, &r, true)
	return r, err
}

// DeleteKeyVault soft-deletes a vault. Its contents stay recoverable until the
// retention window ends or PurgeKeyVault is called.
func (c *Client) DeleteKeyVault(ctx context.Context, vaultID string) error {
	return c.Do(ctx, http.MethodDelete, "/api/KeyVault/"+vaultID, nil, nil, true)
}

func (c *Client) RecoverKeyVault(ctx context.Context, vaultID string) (map[string]any, error) {
	var r map[string]any
	err := c.Do(ctx, http.MethodPost, "/api/KeyVault/"+vaultID+"/recover", map[string]any{}, &r, true)
	return r, err
}

// PurgeKeyVault destroys a soft-deleted vault and everything in it. This cannot be
// undone, and is refused while purge protection holds.
func (c *Client) PurgeKeyVault(ctx context.Context, vaultID string) error {
	return c.Do(ctx, http.MethodDelete, "/api/KeyVault/"+vaultID+"/purge", nil, nil, true)
}

type SetSecretRequest struct {
	Name string `json:"name"`
	// ItemType is "secret", "key" or "certificate"; empty means secret.
	ItemType    string            `json:"itemType,omitempty"`
	Value       string            `json:"value,omitempty"`
	ContentType string            `json:"contentType,omitempty"`
	ExpiresOn   string            `json:"expiresOn,omitempty"`
	NotBefore   string            `json:"notBefore,omitempty"`
	Tags        map[string]string `json:"tags,omitempty"`
	// Generate a random value instead of supplying one. Certificates cannot be generated.
	Generate bool `json:"generate,omitempty"`
	Size     int  `json:"size,omitempty"`
}

// SetSecret writes an item. An existing name gets a new version rather than an
// overwrite, so the previous value stays retrievable.
func (c *Client) SetSecret(ctx context.Context, vaultID string, req SetSecretRequest) (map[string]any, error) {
	var r map[string]any
	err := c.Do(ctx, http.MethodPost, "/api/KeyVault/"+vaultID+"/items", req, &r, true)
	return r, err
}

func (c *Client) KeyVaultItems(ctx context.Context, vaultID string) ([]map[string]any, error) {
	var r []map[string]any
	err := c.Do(ctx, http.MethodGet, "/api/KeyVault/"+vaultID+"/items", nil, &r, true)
	return r, err
}

// GetSecret reads one item's value. Listing never carries values, so this is the only
// call that discloses one — and it returns none for an item that is disabled, expired
// or not yet valid. Pass an empty version for the current one.
func (c *Client) GetSecret(ctx context.Context, vaultID, name, version string) (map[string]any, error) {
	path := "/api/KeyVault/" + vaultID + "/items/" + url.PathEscape(name)
	if version != "" {
		path += "?version=" + url.QueryEscape(version)
	}
	var r map[string]any
	err := c.Do(ctx, http.MethodGet, path, nil, &r, true)
	return r, err
}

func (c *Client) SecretVersions(ctx context.Context, vaultID, name string) ([]map[string]any, error) {
	var r []map[string]any
	err := c.Do(ctx, http.MethodGet, "/api/KeyVault/"+vaultID+"/items/"+url.PathEscape(name)+"/versions", nil, &r, true)
	return r, err
}

// DeleteSecret soft-deletes every version of an item.
func (c *Client) DeleteSecret(ctx context.Context, vaultID, name string) error {
	return c.Do(ctx, http.MethodDelete, "/api/KeyVault/"+vaultID+"/items/"+url.PathEscape(name), nil, nil, true)
}

func (c *Client) RecoverSecret(ctx context.Context, vaultID, name string) (map[string]any, error) {
	var r map[string]any
	err := c.Do(ctx, http.MethodPost, "/api/KeyVault/"+vaultID+"/items/"+url.PathEscape(name)+"/recover", map[string]any{}, &r, true)
	return r, err
}

// CertificateAction values for CreateCertificate.
const (
	// CertificateSelfSigned generates a key pair and self-signs it. Nothing vouches
	// for the result, so clients must be told to trust it explicitly.
	CertificateSelfSigned = "self-signed"
	// CertificateCsr generates a key pair and returns a signing request. The private
	// key stays in the vault, so the authority signs something it cannot impersonate.
	CertificateCsr = "csr"
	// CertificateImport stores existing material: PEM, or base64 PKCS#12.
	CertificateImport = "import"
)

type CreateCertificateRequest struct {
	Name string `json:"name"`
	// Action is one of the Certificate* constants; empty means self-signed.
	Action string `json:"action,omitempty"`
	// Subject accepts a distinguished name, or a bare host name taken as the common name.
	Subject                 string   `json:"subject,omitempty"`
	SubjectAlternativeNames []string `json:"subjectAlternativeNames,omitempty"`
	// KeySize in bits, clamped to 2048-4096.
	KeySize int `json:"keySize,omitempty"`
	// ValidityDays applies to a self-signed certificate.
	ValidityDays int `json:"validityDays,omitempty"`
	// Content is the PEM bundle or base64 PKCS#12 when importing.
	Content  string            `json:"content,omitempty"`
	Password string            `json:"password,omitempty"`
	Tags     map[string]string `json:"tags,omitempty"`
}

// CertificateResult carries the stored item and, for a signing request, the CSR to
// hand to an authority.
type CertificateResult struct {
	Item    map[string]any `json:"item"`
	Csr     string         `json:"csr"`
	Message string         `json:"message"`
	// Certificate is what the certificate says about itself — subject, issuer,
	// validity, key size, SANs — read from the certificate rather than supplied.
	Certificate map[string]any `json:"certificate"`
}

// CreateCertificate self-signs a certificate, produces a signing request, or imports
// existing material, depending on req.Action.
func (c *Client) CreateCertificate(ctx context.Context, vaultID string, req CreateCertificateRequest) (*CertificateResult, error) {
	var r CertificateResult
	err := c.Do(ctx, http.MethodPost, "/api/KeyVault/"+vaultID+"/certificates", req, &r, true)
	return &r, err
}

// MergeCertificate pairs an authority-signed certificate with the key the vault kept
// for its signing request. A certificate issued for a different key is refused.
func (c *Client) MergeCertificate(ctx context.Context, vaultID, name, signedCertificatePem string) (*CertificateResult, error) {
	var r CertificateResult
	body := map[string]any{"signedCertificate": signedCertificatePem}
	err := c.Do(ctx, http.MethodPost, "/api/KeyVault/"+vaultID+"/certificates/"+url.PathEscape(name)+"/merge", body, &r, true)
	return &r, err
}

type ExportCertificateRequest struct {
	// Format is "pem" or "pfx". A PKCS#12 always carries the private key, so give it
	// a password: anyone holding the file holds the identity.
	Format            string `json:"format,omitempty"`
	Password          string `json:"password,omitempty"`
	IncludePrivateKey bool   `json:"includePrivateKey,omitempty"`
}

type CertificateExport struct {
	Content  string `json:"content"`
	Format   string `json:"format"`
	Filename string `json:"filename"`
	Message  string `json:"message"`
}

// ExportCertificate returns the certificate as PEM text, or as base64 PKCS#12.
func (c *Client) ExportCertificate(ctx context.Context, vaultID, name string, req ExportCertificateRequest) (*CertificateExport, error) {
	var r CertificateExport
	err := c.Do(ctx, http.MethodPost, "/api/KeyVault/"+vaultID+"/certificates/"+url.PathEscape(name)+"/export", req, &r, true)
	return &r, err
}

// DownloadCsr fetches the outstanding signing request for a pending certificate.
func (c *Client) DownloadCsr(ctx context.Context, vaultID, name string) ([]byte, error) {
	return c.DoRaw(ctx, http.MethodGet, "/api/KeyVault/"+vaultID+"/certificates/"+url.PathEscape(name)+"/csr")
}

// ── MongoDB ─────────────────────────────────────────────────────────────────

type CreateMongoClusterRequest struct {
	ClusterName string `json:"clusterName"`
	// One member per region. More than one region makes it a replica set.
	Regions []string `json:"regions,omitempty"`
	Region  string   `json:"region,omitempty"`
	// Consistency is "strong", "session", "bounded" or "eventual". The last two read
	// from secondary members and are refused on a single-region cluster.
	Consistency         string `json:"consistency,omitempty"`
	MaxStalenessSeconds int    `json:"maxStalenessSeconds,omitempty"`
	EngineVersion       string `json:"engineVersion,omitempty"`
	Sku                 string `json:"sku,omitempty"`
	StorageGb           int    `json:"storageGb,omitempty"`
	DatabaseName        string `json:"databaseName,omitempty"`
	VNetName            string `json:"vNetName,omitempty"`
}

func (c *Client) CreateMongoCluster(ctx context.Context, req CreateMongoClusterRequest) (map[string]any, error) {
	var r map[string]any
	err := c.Do(ctx, http.MethodPost, "/api/Mongo", req, &r, true)
	return r, err
}

func (c *Client) MongoClusters(ctx context.Context) ([]map[string]any, error) {
	var r []map[string]any
	err := c.Do(ctx, http.MethodGet, "/api/Mongo", nil, &r, true)
	return r, err
}

func (c *Client) DeleteMongoCluster(ctx context.Context, clusterID string) error {
	return c.Do(ctx, http.MethodDelete, "/api/Mongo/"+clusterID, nil, nil, true)
}

// MongoConnection returns the connection string, which encodes the cluster's
// consistency as concrete read concern, write concern and read preference.
func (c *Client) MongoConnection(ctx context.Context, clusterID string) (map[string]any, error) {
	var r map[string]any
	err := c.Do(ctx, http.MethodGet, "/api/Mongo/"+clusterID+"/connection", nil, &r, true)
	return r, err
}

// RunMongoCommand runs a database command, for example {"find":"orders","limit":10}.
// This is the command protocol, not mongosh shell syntax.
func (c *Client) RunMongoCommand(ctx context.Context, clusterID, database, command string) (map[string]any, error) {
	var r map[string]any
	body := map[string]any{"command": command, "database": database}
	err := c.Do(ctx, http.MethodPost, "/api/Mongo/"+clusterID+"/command", body, &r, true)
	return r, err
}

func (c *Client) MongoDatabases(ctx context.Context, clusterID string) ([]map[string]any, error) {
	var r []map[string]any
	err := c.Do(ctx, http.MethodGet, "/api/Mongo/"+clusterID+"/databases", nil, &r, true)
	return r, err
}

func (c *Client) MongoCollections(ctx context.Context, clusterID, database string) ([]map[string]any, error) {
	var r []map[string]any
	err := c.Do(ctx, http.MethodGet, "/api/Mongo/"+clusterID+"/databases/"+url.PathEscape(database)+"/collections", nil, &r, true)
	return r, err
}

// MongoReplicaStatus reports live replica set membership, so callers see the member
// MongoDB has actually elected primary rather than the one nominated at creation.
func (c *Client) MongoReplicaStatus(ctx context.Context, clusterID string) ([]map[string]any, error) {
	var r []map[string]any
	err := c.Do(ctx, http.MethodGet, "/api/Mongo/"+clusterID+"/replica-status", nil, &r, true)
	return r, err
}

// SetMongoConsistency changes the level. Existing connections keep their current
// settings until they reconnect.
func (c *Client) SetMongoConsistency(ctx context.Context, clusterID, consistency string, maxStalenessSeconds int) (map[string]any, error) {
	body := map[string]any{"consistency": consistency}
	if maxStalenessSeconds > 0 {
		body["maxStalenessSeconds"] = maxStalenessSeconds
	}
	var r map[string]any
	err := c.Do(ctx, http.MethodPut, "/api/Mongo/"+clusterID+"/consistency", body, &r, true)
	return r, err
}

// ── YugabyteDB ──────────────────────────────────────────────────────────────

type CreateYugabyteClusterRequest struct {
	ClusterName string `json:"clusterName"`
	// One node per region. Replication factor follows the count and is kept odd.
	Regions       []string `json:"regions,omitempty"`
	Region        string   `json:"region,omitempty"`
	Sku           string   `json:"sku,omitempty"`
	EngineVersion string   `json:"engineVersion,omitempty"`
	DatabaseName  string   `json:"databaseName,omitempty"`
	StorageGb     int      `json:"storageGb,omitempty"`
	VNetName      string   `json:"vNetName,omitempty"`
	VNetAddress   string   `json:"vNetAddress,omitempty"`
}

func (c *Client) CreateYugabyteCluster(ctx context.Context, req CreateYugabyteClusterRequest) (map[string]any, error) {
	var r struct {
		Data map[string]any `json:"data"`
	}
	err := c.Do(ctx, http.MethodPost, "/api/Yugabyte", req, &r, true)
	return r.Data, err
}

func (c *Client) YugabyteClusters(ctx context.Context) ([]map[string]any, error) {
	var r struct {
		Data []map[string]any `json:"data"`
	}
	err := c.Do(ctx, http.MethodGet, "/api/Yugabyte", nil, &r, true)
	return r.Data, err
}

func (c *Client) DeleteYugabyteCluster(ctx context.Context, clusterID string) error {
	return c.Do(ctx, http.MethodDelete, "/api/Yugabyte/"+clusterID, nil, nil, true)
}

func (c *Client) YugabyteConnection(ctx context.Context, clusterID string) (map[string]any, error) {
	var r struct {
		Data map[string]any `json:"data"`
	}
	err := c.Do(ctx, http.MethodGet, "/api/Yugabyte/"+clusterID+"/connection", nil, &r, true)
	return r.Data, err
}

// YugabyteQuery runs SQL. Yugabyte speaks the PostgreSQL wire protocol, so any
// Postgres driver works too; this is for callers that would rather not open a socket.
func (c *Client) YugabyteQuery(ctx context.Context, clusterID, sql string, maxRows int) (map[string]any, error) {
	if maxRows <= 0 {
		maxRows = 1000
	}
	var r struct {
		Data map[string]any `json:"data"`
	}
	body := map[string]any{"sql": sql, "maxRows": maxRows}
	err := c.Do(ctx, http.MethodPost, "/api/Yugabyte/"+clusterID+"/query", body, &r, true)
	return r.Data, err
}

func (c *Client) YugabyteTables(ctx context.Context, clusterID string) ([]map[string]any, error) {
	var r struct {
		Data []map[string]any `json:"data"`
	}
	err := c.Do(ctx, http.MethodGet, "/api/Yugabyte/"+clusterID+"/tables", nil, &r, true)
	return r.Data, err
}

// ── VPN Gateway ─────────────────────────────────────────────────────────────

type CreateVPNGatewayRequest struct {
	Name   string `json:"name"`
	Region string `json:"region,omitempty"`
	// GatewayType 0 is Site-to-Site (WireGuard), 1 is Point-to-Site (OpenVPN).
	GatewayType    int      `json:"gatewayType"`
	VNetID         string   `json:"vNetId,omitempty"`
	VNetName       string   `json:"vNetName,omitempty"`
	AddressPool    string   `json:"addressPool,omitempty"`
	Protocol       string   `json:"protocol,omitempty"`
	Port           int      `json:"port,omitempty"`
	DnsServers     []string `json:"dnsServers,omitempty"`
	SplitTunneling bool     `json:"splitTunneling,omitempty"`
}

func (c *Client) CreateVPNGateway(ctx context.Context, req CreateVPNGatewayRequest) (map[string]any, error) {
	var r struct {
		Data map[string]any `json:"data"`
	}
	err := c.Do(ctx, http.MethodPost, "/api/VPNGateway/create", req, &r, true)
	return r.Data, err
}

func (c *Client) VPNGateways(ctx context.Context) ([]map[string]any, error) {
	var r struct {
		Data []map[string]any `json:"data"`
	}
	err := c.Do(ctx, http.MethodGet, "/api/VPNGateway/list", nil, &r, true)
	return r.Data, err
}

func (c *Client) DeleteVPNGateway(ctx context.Context, gatewayID, gatewayName, region string) error {
	path := fmt.Sprintf("/api/VPNGateway/%s?gatewayName=%s", gatewayID, url.QueryEscape(gatewayName))
	if region != "" {
		path += "&region=" + url.QueryEscape(region)
	}
	return c.Do(ctx, http.MethodDelete, path, nil, nil, true)
}

// CreateVPNClient issues a Point-to-Site client certificate. The profile itself is
// fetched separately with VPNClientConfig.
func (c *Client) CreateVPNClient(ctx context.Context, gatewayID, name, email, region string) (map[string]any, error) {
	path := "/api/VPNGateway/clients/p2s"
	if region != "" {
		path += "?region=" + url.QueryEscape(region)
	}
	body := map[string]any{"name": name, "gatewayId": gatewayID, "emailId": email}
	var r map[string]any
	err := c.Do(ctx, http.MethodPost, path, body, &r, true)
	return r, err
}

// VPNClientConfig downloads a client profile. Downloading twice returns the same
// certificate rather than issuing a new one.
func (c *Client) VPNClientConfig(ctx context.Context, clientID, region string) ([]byte, error) {
	path := "/api/VPNGateway/clients/p2s/" + clientID + "/config"
	if region != "" {
		path += "?region=" + url.QueryEscape(region)
	}
	return c.DoRaw(ctx, http.MethodGet, path)
}

func (c *Client) VPNClients(ctx context.Context, gatewayID string) ([]map[string]any, error) {
	var r struct {
		Data []map[string]any `json:"data"`
	}
	err := c.Do(ctx, http.MethodGet, "/api/VPNGateway/"+gatewayID+"/clients/p2s", nil, &r, true)
	return r.Data, err
}

// RevokeVPNClient withdraws a client certificate. The record stays visible as revoked
// and its name stays taken, so a new certificate cannot be issued under the same
// identity.
func (c *Client) RevokeVPNClient(ctx context.Context, clientID, region string) error {
	path := "/api/VPNGateway/clients/p2s/" + clientID
	if region != "" {
		path += "?region=" + url.QueryEscape(region)
	}
	return c.Do(ctx, http.MethodDelete, path, nil, nil, true)
}

type CreateS2SConnectionRequest struct {
	Name           string `json:"name"`
	LocalGatewayID string `json:"localGatewayId"`
	// RemoteGatewayIP may omit the port; WireGuard's 51820 is assumed.
	RemoteGatewayIP    string   `json:"remoteGatewayIP"`
	RemotePublicKey    string   `json:"remotePublicKey"`
	RemoteAddressSpace []string `json:"remoteAddressSpace,omitempty"`
	PreSharedKey       string   `json:"preSharedKey,omitempty"`
}

func (c *Client) CreateS2SConnection(ctx context.Context, req CreateS2SConnectionRequest, region string) (map[string]any, error) {
	path := "/api/VPNGateway/connections/s2s"
	if region != "" {
		path += "?region=" + url.QueryEscape(region)
	}
	var r map[string]any
	err := c.Do(ctx, http.MethodPost, path, req, &r, true)
	return r, err
}

func (c *Client) S2SConnections(ctx context.Context, gatewayID string) ([]map[string]any, error) {
	var r struct {
		Data []map[string]any `json:"data"`
	}
	err := c.Do(ctx, http.MethodGet, "/api/VPNGateway/"+gatewayID+"/connections/s2s", nil, &r, true)
	return r.Data, err
}

func (c *Client) DeleteS2SConnection(ctx context.Context, connectionID, region string) error {
	path := "/api/VPNGateway/connections/s2s/" + connectionID
	if region != "" {
		path += "?region=" + url.QueryEscape(region)
	}
	return c.Do(ctx, http.MethodDelete, path, nil, nil, true)
}

// ── Container Apps ──────────────────────────────────────────────────────────

type CreateContainerAppEnvironmentRequest struct {
	Name   string `json:"name"`
	Region string `json:"region,omitempty"`
}

// CreateContainerAppEnvironment creates the shared network boundary apps live in.
// Apps in one environment reach each other by app name; anything outside it cannot
// reach them at all.
func (c *Client) CreateContainerAppEnvironment(ctx context.Context, req CreateContainerAppEnvironmentRequest) (map[string]any, error) {
	var r map[string]any
	err := c.Do(ctx, http.MethodPost, "/api/ContainerApp/environments", req, &r, true)
	return r, err
}

func (c *Client) ContainerAppEnvironments(ctx context.Context) ([]map[string]any, error) {
	// This endpoint wraps its list in {message, data}, unlike the apps endpoint above.
	var r struct {
		Data []map[string]any `json:"data"`
	}
	err := c.Do(ctx, http.MethodGet, "/api/ContainerApp/environments", nil, &r, true)
	return r.Data, err
}

func (c *Client) DeleteContainerAppEnvironment(ctx context.Context, environmentID string) error {
	return c.Do(ctx, http.MethodDelete, "/api/ContainerApp/environments/"+environmentID, nil, nil, true)
}

type CreateContainerAppRequest struct {
	Name          string  `json:"name"`
	Image         string  `json:"image"`
	Region        string  `json:"region,omitempty"`
	EnvironmentID string  `json:"environmentId,omitempty"`
	TargetPort    int     `json:"targetPort,omitempty"`
	VCpu          float64 `json:"vCpu,omitempty"`
	RamGb         float64 `json:"ramGb,omitempty"`
	MinReplicas   int     `json:"minReplicas,omitempty"`
	MaxReplicas   int     `json:"maxReplicas,omitempty"`
	// ExternalIngress publishes a host port. Leave it false and the app is reachable
	// only from inside its environment — no port is published at all.
	ExternalIngress bool              `json:"externalIngress"`
	Environment     map[string]string `json:"environment,omitempty"`
}

func (c *Client) CreateContainerApp(ctx context.Context, req CreateContainerAppRequest) (map[string]any, error) {
	var r map[string]any
	err := c.Do(ctx, http.MethodPost, "/api/ContainerApp", req, &r, true)
	return r, err
}

func (c *Client) ContainerApps(ctx context.Context) ([]map[string]any, error) {
	var r struct {
		Data []map[string]any `json:"data"`
	}
	err := c.Do(ctx, http.MethodGet, "/api/ContainerApp", nil, &r, true)
	return r.Data, err
}

func (c *Client) DeleteContainerApp(ctx context.Context, appID string) error {
	return c.Do(ctx, http.MethodDelete, "/api/ContainerApp/"+appID, nil, nil, true)
}

// ── PostgreSQL ──────────────────────────────────────────────────────────────

type CreatePostgresRequest struct {
	ServerName      string `json:"serverName"`
	AdminUsername   string `json:"adminUsername,omitempty"`
	AdminPassword   string `json:"adminPassword,omitempty"` // generated when omitted
	DatabaseName    string `json:"databaseName,omitempty"`
	PostgresVersion string `json:"postgresVersion,omitempty"`
	Region          string `json:"region,omitempty"`
	Sku             string `json:"sku,omitempty"`
	StorageGb       int    `json:"storageGb,omitempty"`
}

func (c *Client) CreatePostgres(ctx context.Context, req CreatePostgresRequest) (map[string]any, error) {
	var r struct {
		Data map[string]any `json:"data"`
	}
	err := c.Do(ctx, http.MethodPost, "/api/PostgresDatabase", req, &r, true)
	return r.Data, err
}

func (c *Client) PostgresDatabases(ctx context.Context) ([]map[string]any, error) {
	var r struct {
		Data []map[string]any `json:"data"`
	}
	err := c.Do(ctx, http.MethodGet, "/api/PostgresDatabase", nil, &r, true)
	return r.Data, err
}

func (c *Client) DeletePostgres(ctx context.Context, databaseID string) error {
	return c.Do(ctx, http.MethodDelete, "/api/PostgresDatabase/"+databaseID, nil, nil, true)
}

// ── IoT Hub ─────────────────────────────────────────────────────────────────

func (c *Client) IoTHubs(ctx context.Context) ([]map[string]any, error) {
	var r struct {
		Data []map[string]any `json:"data"`
	}
	err := c.Do(ctx, http.MethodGet, "/api/IoTHub/iothubs", nil, &r, true)
	return r.Data, err
}

// CreateIoTDevice registers a device identity and returns its connection string.
func (c *Client) CreateIoTDevice(ctx context.Context, hubID, deviceID string) (map[string]any, error) {
	var r map[string]any
	err := c.Do(ctx, http.MethodPost, "/api/iothub/"+hubID+"/devices", map[string]any{"deviceId": deviceID}, &r, true)
	return r, err
}

func (c *Client) IoTDevices(ctx context.Context, hubID string) ([]map[string]any, error) {
	var r []map[string]any
	err := c.Do(ctx, http.MethodGet, "/api/IoTHubDevice/iothub/"+hubID+"/devices", nil, &r, true)
	return r, err
}

func (c *Client) DeleteIoTDevice(ctx context.Context, hubID, deviceID string) error {
	return c.Do(ctx, http.MethodDelete, "/api/iothub/"+hubID+"/devices/"+url.PathEscape(deviceID), nil, nil, true)
}

func (c *Client) IoTDeviceConnectionString(ctx context.Context, hubID, deviceID string) (map[string]any, error) {
	var r map[string]any
	err := c.Do(ctx, http.MethodGet, "/api/iothub/"+hubID+"/devices/"+url.PathEscape(deviceID)+"/connection-string", nil, &r, true)
	return r, err
}

// RegenerateIoTDeviceKey rotates the device's shared access key. The previous key
// stops working immediately, so update the device before calling this.
func (c *Client) RegenerateIoTDeviceKey(ctx context.Context, hubID, deviceID string) (map[string]any, error) {
	var r map[string]any
	err := c.Do(ctx, http.MethodPost, "/api/iothub/"+hubID+"/devices/"+url.PathEscape(deviceID)+"/regenerate-key", map[string]any{}, &r, true)
	return r, err
}

func (c *Client) IoTDeviceTwin(ctx context.Context, hubID, deviceID string) (map[string]any, error) {
	var r map[string]any
	err := c.Do(ctx, http.MethodGet, "/api/iothub/"+hubID+"/devices/"+url.PathEscape(deviceID)+"/twin", nil, &r, true)
	return r, err
}

// SendIoTTelemetry submits a device-to-cloud message.
func (c *Client) SendIoTTelemetry(ctx context.Context, hubID, deviceID, payload, properties string) (map[string]any, error) {
	var r map[string]any
	body := map[string]any{"payload": payload, "properties": properties}
	err := c.Do(ctx, http.MethodPost, "/api/iothub/"+hubID+"/devices/"+url.PathEscape(deviceID)+"/telemetry", body, &r, true)
	return r, err
}

// SendIoTCloudToDevice queues a message for the device to collect.
func (c *Client) SendIoTCloudToDevice(ctx context.Context, hubID, deviceID, payload, properties string) (map[string]any, error) {
	var r map[string]any
	body := map[string]any{"payload": payload, "properties": properties}
	err := c.Do(ctx, http.MethodPost, "/api/iothub/"+hubID+"/devices/"+url.PathEscape(deviceID)+"/c2d", body, &r, true)
	return r, err
}

func (c *Client) IoTMessages(ctx context.Context, hubID, deviceID string) ([]map[string]any, error) {
	var r []map[string]any
	err := c.Do(ctx, http.MethodGet, "/api/iothub/"+hubID+"/devices/"+url.PathEscape(deviceID)+"/messages", nil, &r, true)
	return r, err
}

func (c *Client) IoTHubMonitoring(ctx context.Context, hubID string) (map[string]any, error) {
	var r map[string]any
	err := c.Do(ctx, http.MethodGet, "/api/iothub/"+hubID+"/monitoring", nil, &r, true)
	return r, err
}

// ── Device Provisioning Service ─────────────────────────────────────────────

type CreateDpsEnrollmentRequest struct {
	Name string `json:"name"`
	// EnrollmentType is "individual" (matched by registrationId) or "group"
	// (matched by attestation key alone).
	EnrollmentType string `json:"enrollmentType,omitempty"`
	RegistrationID string `json:"registrationId,omitempty"`
	TargetHubID    string `json:"targetHubId,omitempty"`
	DeviceIDPrefix string `json:"deviceIdPrefix,omitempty"`
}

// CreateDpsEnrollment returns the enrollment including the attestation key devices
// present when they register.
func (c *Client) CreateDpsEnrollment(ctx context.Context, req CreateDpsEnrollmentRequest) (map[string]any, error) {
	var r struct {
		Data map[string]any `json:"data"`
	}
	err := c.Do(ctx, http.MethodPost, "/api/Dps/enrollments", req, &r, true)
	return r.Data, err
}

func (c *Client) DpsEnrollments(ctx context.Context) ([]map[string]any, error) {
	var r struct {
		Data []map[string]any `json:"data"`
	}
	err := c.Do(ctx, http.MethodGet, "/api/Dps/enrollments", nil, &r, true)
	return r.Data, err
}

func (c *Client) DeleteDpsEnrollment(ctx context.Context, enrollmentID string) error {
	return c.Do(ctx, http.MethodDelete, "/api/Dps/enrollments/"+enrollmentID, nil, nil, true)
}

// RegisterDevice is the device's own call: it presents its registration id and the
// attestation key, and is provisioned into the enrollment's target hub.
func (c *Client) RegisterDevice(ctx context.Context, registrationID, key string) (map[string]any, error) {
	var r struct {
		Data map[string]any `json:"data"`
	}
	body := map[string]any{"registrationId": registrationID, "key": key}
	err := c.Do(ctx, http.MethodPost, "/api/Dps/register", body, &r, true)
	return r.Data, err
}

func (c *Client) DpsRegistrations(ctx context.Context, enrollmentID string) ([]map[string]any, error) {
	var r struct {
		Data []map[string]any `json:"data"`
	}
	err := c.Do(ctx, http.MethodGet, "/api/Dps/enrollments/"+enrollmentID+"/registrations", nil, &r, true)
	return r.Data, err
}

// ── API Management ──────────────────────────────────────────────────────────

func (c *Client) Apis(ctx context.Context) ([]map[string]any, error) {
	var r struct {
		Data []map[string]any `json:"data"`
	}
	err := c.Do(ctx, http.MethodGet, "/api/apim/apis", nil, &r, true)
	return r.Data, err
}

func (c *Client) CreateApi(ctx context.Context, body map[string]any) (map[string]any, error) {
	var r struct {
		Data map[string]any `json:"data"`
	}
	err := c.Do(ctx, http.MethodPost, "/api/apim/apis", body, &r, true)
	return r.Data, err
}

func (c *Client) DeleteApi(ctx context.Context, apiID string) error {
	return c.Do(ctx, http.MethodDelete, "/api/apim/apis/"+apiID, nil, nil, true)
}

// ── Virtual networks ────────────────────────────────────────────────────────

type CreateVirtualNetworkRequest struct {
	Name         string   `json:"name"`
	AddressSpace string   `json:"addressSpace,omitempty"`
	Region       string   `json:"region,omitempty"`
	Regions      []string `json:"regions,omitempty"`
	ForwardMode  string   `json:"forwardMode,omitempty"`
	MTU          int      `json:"mtu,omitempty"`
}

func (c *Client) CreateVirtualNetwork(ctx context.Context, req CreateVirtualNetworkRequest) (map[string]any, error) {
	var r map[string]any
	err := c.Do(ctx, http.MethodPost, "/api/VirtualNetwork/create-vnet", req, &r, true)
	return r, err
}

func (c *Client) VirtualNetworks(ctx context.Context) ([]map[string]any, error) {
	var r struct {
		Data []map[string]any `json:"data"`
	}
	err := c.Do(ctx, http.MethodGet, "/api/VirtualNetwork/list-vnets", nil, &r, true)
	return r.Data, err
}
