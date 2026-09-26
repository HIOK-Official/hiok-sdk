using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;

namespace Hiok.Cloud;

public sealed partial class HiokClient
{
    private readonly HttpClient _http;
    private string? _token;

    public HiokClient(string endpoint = "https://hiokcloud.com", string? token = null, HttpClient? httpClient = null)
    {
        _http = httpClient ?? new HttpClient { Timeout = TimeSpan.FromMinutes(5) };
        _http.BaseAddress = new Uri(endpoint.TrimEnd('/') + "/");
        _token = token;
    }

    public async Task LoginAsync(string email, string password, CancellationToken cancellationToken = default)
    {
        using var response = await _http.PostAsJsonAsync("api/OAuth/token", new { email, password }, cancellationToken);
        using var document = await ReadAsync(response, cancellationToken);
        _token = document.RootElement.GetProperty("data").GetProperty("token").GetString()
            ?? throw new HiokException("Sign-in response did not include a token", response.StatusCode);
    }

    public void SetToken(string token) => _token = token;

    public async Task<JsonDocument> SendAsync(HttpMethod method, string path, object? body = null, bool authenticated = true, CancellationToken cancellationToken = default)
    {
        if (authenticated) await EnsureTokenAsync(cancellationToken);
        if (authenticated && string.IsNullOrWhiteSpace(_token))
            throw new HiokException("No token configured; call LoginAsync first");

        using var request = new HttpRequestMessage(method, path.TrimStart('/'));
        if (body != null) request.Content = JsonContent.Create(body);
        if (authenticated) request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", _token);
        using var response = await _http.SendAsync(request, cancellationToken);
        return await ReadAsync(response, cancellationToken);
    }

    public Task<JsonDocument> RegionsAsync(CancellationToken ct = default) =>
        SendAsync(HttpMethod.Get, "api/storageaccount/regions", authenticated: false, cancellationToken: ct);

    public Task<JsonDocument> VirtualMachinesAsync(CancellationToken ct = default) =>
        SendAsync(HttpMethod.Get, "api/VirtualMachine/list-vms-info", cancellationToken: ct);

    public Task<JsonDocument> CreateVirtualMachineAsync(string name, string region = "canada", string image = "ubuntu-24.04", int vcpus = 1, double ramGb = 1, CancellationToken ct = default) =>
        SendAsync(HttpMethod.Post, "api/VirtualMachine/create-vm", new { vmName = name, regions = new[] { region }, sourceFilePath = image, vcpuCount = vcpus, ramSize = ramGb }, cancellationToken: ct);

    // ── Service Bus ─────────────────────────────────────────────────────

    /// <summary>Namespaces holding your queues and topics.</summary>
    public Task<JsonDocument> ServiceBusNamespacesAsync(CancellationToken ct = default) =>
        SendAsync(HttpMethod.Get, "/api/ServiceBus/namespaces", cancellationToken: ct);

    public Task<JsonDocument> CreateServiceBusNamespaceAsync(string name, string region = "canada", string sku = "standard", CancellationToken ct = default) =>
        SendAsync(HttpMethod.Post, "/api/ServiceBus/namespaces",
            new { name, product = "servicebus", primaryRegion = region, sku }, cancellationToken: ct);

    public Task<JsonDocument> CreateQueueAsync(string namespaceId, string name, int maxDeliveryCount = 10, bool requiresSession = false, CancellationToken ct = default) =>
        SendAsync(HttpMethod.Post, $"/api/ServiceBus/namespaces/{namespaceId}/queues",
            new { name, maxDeliveryCount, requiresSession, deadLetteringEnabled = true }, cancellationToken: ct);

    /// <summary>Sends one message. A scheduled time holds it until that instant.</summary>
    public Task<JsonDocument> SendMessageAsync(string namespaceId, string entity, string body, string? subject = null, DateTimeOffset? scheduledEnqueueTime = null, CancellationToken ct = default) =>
        SendAsync(HttpMethod.Post, $"/api/ServiceBus/namespaces/{namespaceId}/entities/{entity}/messages",
            new { body, subject, scheduledEnqueueTime }, cancellationToken: ct);

    /// <summary>Receives under lock; settle each delivery to complete it.</summary>
    public Task<JsonDocument> ReceiveMessagesAsync(string namespaceId, string entity, string? subscription = null, int maxMessages = 1, CancellationToken ct = default)
    {
        var query = string.IsNullOrEmpty(subscription) ? "" : $"?subscription={Uri.EscapeDataString(subscription)}";
        return SendAsync(HttpMethod.Post,
            $"/api/ServiceBus/namespaces/{namespaceId}/entities/{entity}/messages/receive{query}",
            new { maxMessages, receiveMode = "peek_lock" }, cancellationToken: ct);
    }

    /// <summary>Settles a delivery: complete, abandon, deadletter or defer.</summary>
    public Task<JsonDocument> SettleMessagesAsync(string namespaceId, string entity, IEnumerable<string> lockTokens, string disposition = "complete", string? subscription = null, CancellationToken ct = default)
    {
        var query = string.IsNullOrEmpty(subscription) ? "" : $"?subscription={Uri.EscapeDataString(subscription)}";
        return SendAsync(HttpMethod.Post,
            $"/api/ServiceBus/namespaces/{namespaceId}/entities/{entity}/messages/settle{query}",
            new { lockTokens, disposition }, cancellationToken: ct);
    }

    // ── Event Mesh ──────────────────────────────────────────────────────

    public Task<JsonDocument> CreateEventStreamAsync(string namespaceId, string name, int partitions = 4, int retentionHours = 168, CancellationToken ct = default) =>
        SendAsync(HttpMethod.Post, $"/api/Pulse/namespaces/{namespaceId}/streams",
            new { name, partitionCount = partitions, retentionHours }, cancellationToken: ct);

    /// <summary>Publishes events. Each is an object with type, subject and data.</summary>
    public Task<JsonDocument> PublishEventsAsync(string namespaceId, string stream, IEnumerable<object> events, CancellationToken ct = default) =>
        SendAsync(HttpMethod.Post, $"/api/Pulse/namespaces/{namespaceId}/streams/{stream}/events",
            new { events }, cancellationToken: ct);

    /// <summary>Reads through a consumer group, advancing that group's cursor.</summary>
    public Task<JsonDocument> ReadEventsAsync(string namespaceId, string stream, string consumerGroup, int maxEvents = 10, CancellationToken ct = default) =>
        SendAsync(HttpMethod.Post,
            $"/api/Pulse/namespaces/{namespaceId}/streams/{stream}/events/read?consumerGroup={Uri.EscapeDataString(consumerGroup)}&maxEvents={maxEvents}",
            new { }, cancellationToken: ct);

    // ── Communication ───────────────────────────────────────────────────

    /// <summary>Sends mail. Omit the sender to use the domain's default.</summary>
    public Task<JsonDocument> SendEmailAsync(string serviceId, IEnumerable<string> to, string subject, string? text = null, string? html = null, string? from = null, CancellationToken ct = default) =>
        SendAsync(HttpMethod.Post, $"/api/Communication/services/{serviceId}/emails",
            new { to, subject, textBody = text, htmlBody = html, from }, cancellationToken: ct);

    // ── Bastion ─────────────────────────────────────────────────────────

    /// <summary>Opens a browser session and returns the portal URL and signed token.</summary>
    public Task<JsonDocument> StartBastionSessionAsync(string bastionId, string? targetVmId = null, string? targetAddress = null, string protocol = "rdp", string? username = null, string? password = null, int ttlMinutes = 60, CancellationToken ct = default) =>
        SendAsync(HttpMethod.Post, $"/api/Bastion/{bastionId}/sessions",
            new { targetVmId, targetAddress, protocol, username, password, ttlMinutes }, cancellationToken: ct);

    public Task<JsonDocument> SearchAsync(string query, CancellationToken ct = default) =>
        SendAsync(HttpMethod.Get, $"api/search?q={Uri.EscapeDataString(query)}", cancellationToken: ct);

    // ── Analytics (managed ClickHouse) ───────────────────────────────────────

    public Task<JsonDocument> AnalyticsClustersAsync(CancellationToken ct = default) =>
        SendAsync(HttpMethod.Get, "/api/Analytics", cancellationToken: ct);

    /// <summary>
    /// Provision an analytics cluster. <paramref name="sku"/> is dev, small, medium
    /// or large. Supply <paramref name="vnetName"/> and <paramref name="vnetAddress"/>
    /// (CIDR) to give the cluster an interface on a virtual network, so machines there
    /// reach it privately.
    /// </summary>
    public Task<JsonDocument> CreateAnalyticsClusterAsync(
        string clusterName, string? region = null, string sku = "small", int storageGb = 100,
        string databaseName = "default", string adminUsername = "hiokadmin",
        string engineVersion = "24.8-alpine", string? vnetName = null, string? vnetAddress = null,
        CancellationToken ct = default) =>
        SendAsync(HttpMethod.Post, "/api/Analytics",
            new { clusterName, region, sku, storageGb, databaseName, adminUsername, engineVersion, vnetName, vnetAddress },
            cancellationToken: ct);

    public Task<JsonDocument> DeleteAnalyticsClusterAsync(string clusterId, CancellationToken ct = default) =>
        SendAsync(HttpMethod.Delete, $"/api/Analytics/{clusterId}", cancellationToken: ct);

    public Task<JsonDocument> StartAnalyticsClusterAsync(string clusterId, CancellationToken ct = default) =>
        SendAsync(HttpMethod.Post, $"/api/Analytics/{clusterId}/start", new { }, cancellationToken: ct);

    public Task<JsonDocument> StopAnalyticsClusterAsync(string clusterId, CancellationToken ct = default) =>
        SendAsync(HttpMethod.Post, $"/api/Analytics/{clusterId}/stop", new { }, cancellationToken: ct);

    /// <summary>Connection details including the password.</summary>
    public Task<JsonDocument> AnalyticsConnectionAsync(string clusterId, CancellationToken ct = default) =>
        SendAsync(HttpMethod.Get, $"/api/Analytics/{clusterId}/connection", cancellationToken: ct);

    public Task<JsonDocument> AnalyticsTablesAsync(string clusterId, CancellationToken ct = default) =>
        SendAsync(HttpMethod.Get, $"/api/Analytics/{clusterId}/tables", cancellationToken: ct);

    /// <summary>
    /// Run SQL. Returns columns, rows, timing and bytes read. A statement that fails
    /// still returns normally: check <c>isSuccess</c> and read <c>error</c>.
    /// </summary>
    public Task<JsonDocument> AnalyticsQueryAsync(
        string clusterId, string sql, int maxRows = 1000, CancellationToken ct = default) =>
        SendAsync(HttpMethod.Post, $"/api/Analytics/{clusterId}/query",
            new { sql, maxRows }, cancellationToken: ct);

    public Task<JsonDocument> SetAnalyticsVNetAsync(string clusterId, bool attach, CancellationToken ct = default) =>
        SendAsync(HttpMethod.Post, $"/api/Analytics/{clusterId}/vnet/{(attach ? "attach" : "detach")}",
            new { }, cancellationToken: ct);

    // ── Live streaming ───────────────────────────────────────────────────────

    /// <summary>Each item carries the endpoint plus its ingest and playback URLs.</summary>
    public Task<JsonDocument> StreamingEndpointsAsync(CancellationToken ct = default) =>
        SendAsync(HttpMethod.Get, "/api/streaming", cancellationToken: ct);

    /// <summary>Create an endpoint. <paramref name="kind"/> is camera, video or content.</summary>
    public Task<JsonDocument> CreateStreamingEndpointAsync(
        string name, string? region = null, string kind = "camera", CancellationToken ct = default) =>
        SendAsync(HttpMethod.Post, "/api/streaming", new { name, region, kind }, cancellationToken: ct);

    public Task<JsonDocument> DeleteStreamingEndpointAsync(string endpointId, CancellationToken ct = default) =>
        SendAsync(HttpMethod.Delete, $"/api/streaming/{endpointId}", cancellationToken: ct);

    private static async Task<JsonDocument> ReadAsync(HttpResponseMessage response, CancellationToken ct)
    {
        var stream = await response.Content.ReadAsStreamAsync(ct);
        var document = await JsonDocument.ParseAsync(stream, cancellationToken: ct);
        if (!response.IsSuccessStatusCode)
        {
            var message = document.RootElement.TryGetProperty("message", out var p) ? p.GetString() : response.ReasonPhrase;
            document.Dispose();
            throw new HiokException(message ?? "HIOK request failed", response.StatusCode);
        }
        return document;
    }

    // ── Key Vault ───────────────────────────────────────────────────────

    /// <summary>Vaults you own. Soft-deleted ones are listed by <see cref="DeletedKeyVaultsAsync"/>.</summary>
    public Task<JsonDocument> KeyVaultsAsync(CancellationToken ct = default) =>
        SendAsync(HttpMethod.Get, "api/KeyVault", cancellationToken: ct);

    /// <summary>The recovery bin: vaults still inside their retention window.</summary>
    public Task<JsonDocument> DeletedKeyVaultsAsync(CancellationToken ct = default) =>
        SendAsync(HttpMethod.Get, "api/KeyVault/deleted", cancellationToken: ct);

    /// <summary>
    /// Creates a vault. Leave <paramref name="vnetId"/> null for one reachable wherever
    /// the caller can authenticate; set it to additionally require the request to arrive
    /// from that network — both are the same plan.
    ///
    /// <paramref name="purgeProtection"/> can be switched on later but never off, which
    /// is what stops someone who reaches the vault from disabling it and purging.
    /// </summary>
    public Task<JsonDocument> CreateKeyVaultAsync(string name, string primaryRegion = "canada",
        string[]? regions = null, string? vnetId = null, string? vnetName = null,
        string[]? allowedCidrs = null, int softDeleteRetentionDays = 90,
        bool purgeProtection = false, CancellationToken ct = default) =>
        SendAsync(HttpMethod.Post, "api/KeyVault", new
        {
            name,
            primaryRegion,
            regions,
            vnetId,
            vnetName,
            allowedCidrs,
            softDeleteRetentionDays,
            purgeProtection,
        }, cancellationToken: ct);

    /// <summary>Soft delete. Contents stay recoverable until the retention window ends.</summary>
    public Task<JsonDocument> DeleteKeyVaultAsync(Guid vaultId, CancellationToken ct = default) =>
        SendAsync(HttpMethod.Delete, $"api/KeyVault/{vaultId}", cancellationToken: ct);

    public Task<JsonDocument> RecoverKeyVaultAsync(Guid vaultId, CancellationToken ct = default) =>
        SendAsync(HttpMethod.Post, $"api/KeyVault/{vaultId}/recover", new { }, cancellationToken: ct);

    /// <summary>Irreversible, and refused while purge protection holds.</summary>
    public Task<JsonDocument> PurgeKeyVaultAsync(Guid vaultId, CancellationToken ct = default) =>
        SendAsync(HttpMethod.Delete, $"api/KeyVault/{vaultId}/purge", cancellationToken: ct);

    /// <summary>Item metadata. Values are never included — use <see cref="GetSecretAsync"/>.</summary>
    public Task<JsonDocument> KeyVaultItemsAsync(Guid vaultId, string? itemType = null,
        bool includeDeleted = false, CancellationToken ct = default)
    {
        var query = new List<string>();
        if (!string.IsNullOrWhiteSpace(itemType)) query.Add($"itemType={Uri.EscapeDataString(itemType!)}");
        if (includeDeleted) query.Add("includeDeleted=true");
        var suffix = query.Count > 0 ? "?" + string.Join("&", query) : string.Empty;
        return SendAsync(HttpMethod.Get, $"api/KeyVault/{vaultId}/items{suffix}", cancellationToken: ct);
    }

    /// <summary>
    /// Writes an item. A name that already exists gets a new <em>version</em> rather than
    /// an overwrite, so the previous value stays retrievable.
    /// </summary>
    public Task<JsonDocument> SetSecretAsync(Guid vaultId, string name, string? value = null,
        string itemType = "secret", string? contentType = null, DateTime? expiresOn = null,
        bool generate = false, int? size = null, CancellationToken ct = default) =>
        SendAsync(HttpMethod.Post, $"api/KeyVault/{vaultId}/items", new
        {
            name,
            itemType,
            value = generate ? null : value,
            contentType,
            expiresOn,
            generate,
            size,
        }, cancellationToken: ct);

    /// <summary>
    /// Reads one item's value — the only call that discloses one, which is why it is
    /// separate from listing. A disabled, expired or not-yet-valid item returns none.
    /// </summary>
    public Task<JsonDocument> GetSecretAsync(Guid vaultId, string name, string? version = null,
        CancellationToken ct = default)
    {
        var suffix = string.IsNullOrWhiteSpace(version) ? string.Empty : $"?version={Uri.EscapeDataString(version!)}";
        return SendAsync(HttpMethod.Get, $"api/KeyVault/{vaultId}/items/{Uri.EscapeDataString(name)}{suffix}", cancellationToken: ct);
    }

    public Task<JsonDocument> SecretVersionsAsync(Guid vaultId, string name, CancellationToken ct = default) =>
        SendAsync(HttpMethod.Get, $"api/KeyVault/{vaultId}/items/{Uri.EscapeDataString(name)}/versions", cancellationToken: ct);

    /// <summary>Soft-deletes every version, so a deleted secret cannot be read by asking for an older one.</summary>
    public Task<JsonDocument> DeleteSecretAsync(Guid vaultId, string name, CancellationToken ct = default) =>
        SendAsync(HttpMethod.Delete, $"api/KeyVault/{vaultId}/items/{Uri.EscapeDataString(name)}", cancellationToken: ct);

    public Task<JsonDocument> RecoverSecretAsync(Guid vaultId, string name, CancellationToken ct = default) =>
        SendAsync(HttpMethod.Post, $"api/KeyVault/{vaultId}/items/{Uri.EscapeDataString(name)}/recover", new { }, cancellationToken: ct);

    /// <summary>
    /// Creates a certificate.
    ///
    /// <para><c>self-signed</c> generates a key pair and signs it; nothing vouches for it.</para>
    /// <para><c>csr</c> generates a key pair and returns a signing request. The private key
    /// never leaves the vault, so the authority signs something it cannot impersonate; the
    /// item stays pending and unusable until <see cref="MergeCertificateAsync"/>.</para>
    /// <para><c>import</c> stores existing PEM, or base64 PKCS#12 with its password.</para>
    /// </summary>
    public Task<JsonDocument> CreateCertificateAsync(Guid vaultId, string name,
        string action = "self-signed", string? subject = null, string[]? subjectAlternativeNames = null,
        int keySize = 2048, int? validityDays = null, string? content = null,
        string? password = null, CancellationToken ct = default) =>
        SendAsync(HttpMethod.Post, $"api/KeyVault/{vaultId}/certificates", new
        {
            name,
            action,
            subject,
            subjectAlternativeNames,
            keySize,
            validityDays,
            content,
            password,
        }, cancellationToken: ct);

    /// <summary>
    /// Pairs an authority-signed certificate with the key held for its request. One issued
    /// for a different key is refused — the pair could not complete a handshake, and that
    /// would only surface in production.
    /// </summary>
    public Task<JsonDocument> MergeCertificateAsync(Guid vaultId, string name,
        string signedCertificate, CancellationToken ct = default) =>
        SendAsync(HttpMethod.Post, $"api/KeyVault/{vaultId}/certificates/{Uri.EscapeDataString(name)}/merge",
            new { signedCertificate }, cancellationToken: ct);

    /// <summary>
    /// Exports as PEM text or base64 PKCS#12. A PKCS#12 always carries the private key, so
    /// give it a password: anyone holding the file holds the identity.
    /// </summary>
    public Task<JsonDocument> ExportCertificateAsync(Guid vaultId, string name,
        string format = "pem", string? password = null, bool includePrivateKey = false,
        CancellationToken ct = default) =>
        SendAsync(HttpMethod.Post, $"api/KeyVault/{vaultId}/certificates/{Uri.EscapeDataString(name)}/export",
            new { format, password, includePrivateKey }, cancellationToken: ct);

    // ── MongoDB ─────────────────────────────────────────────────────────

    public Task<JsonDocument> MongoClustersAsync(CancellationToken ct = default) =>
        SendAsync(HttpMethod.Get, "api/Mongo", cancellationToken: ct);

    /// <summary>
    /// Creates a cluster. One region gives a single node; several give a replica set.
    ///
    /// <paramref name="consistency"/> is not a label: it sets the read concern, write
    /// concern and read preference in the connection string, so it governs your driver.
    /// "bounded" and "eventual" read from secondaries and are refused on one region.
    /// </summary>
    public Task<JsonDocument> CreateMongoClusterAsync(string clusterName, string[]? regions = null,
        string consistency = "strong", int? maxStalenessSeconds = null, string engineVersion = "7.0",
        string sku = "small", int storageGb = 20, string? databaseName = null,
        CancellationToken ct = default)
    {
        regions ??= new[] { "canada" };
        return SendAsync(HttpMethod.Post, "api/Mongo", new
        {
            clusterName,
            regions,
            region = regions[0],
            consistency,
            maxStalenessSeconds,
            engineVersion,
            sku,
            storageGb,
            databaseName,
        }, cancellationToken: ct);
    }

    public Task<JsonDocument> DeleteMongoClusterAsync(Guid clusterId, CancellationToken ct = default) =>
        SendAsync(HttpMethod.Delete, $"api/Mongo/{clusterId}", cancellationToken: ct);

    /// <summary>Connection string, with the cluster's consistency encoded into it.</summary>
    public Task<JsonDocument> MongoConnectionAsync(Guid clusterId, CancellationToken ct = default) =>
        SendAsync(HttpMethod.Get, $"api/Mongo/{clusterId}/connection", cancellationToken: ct);

    /// <summary>Runs a database command such as {"find":"orders","limit":10} — not shell syntax.</summary>
    public Task<JsonDocument> MongoCommandAsync(Guid clusterId, string command, string? database = null,
        CancellationToken ct = default) =>
        SendAsync(HttpMethod.Post, $"api/Mongo/{clusterId}/command", new { command, database }, cancellationToken: ct);

    public Task<JsonDocument> MongoDatabasesAsync(Guid clusterId, CancellationToken ct = default) =>
        SendAsync(HttpMethod.Get, $"api/Mongo/{clusterId}/databases", cancellationToken: ct);

    public Task<JsonDocument> MongoCollectionsAsync(Guid clusterId, string database, CancellationToken ct = default) =>
        SendAsync(HttpMethod.Get, $"api/Mongo/{clusterId}/databases/{Uri.EscapeDataString(database)}/collections", cancellationToken: ct);

    /// <summary>Live membership, so you see the member MongoDB actually elected primary.</summary>
    public Task<JsonDocument> MongoReplicaStatusAsync(Guid clusterId, CancellationToken ct = default) =>
        SendAsync(HttpMethod.Get, $"api/Mongo/{clusterId}/replica-status", cancellationToken: ct);

    public Task<JsonDocument> SetMongoConsistencyAsync(Guid clusterId, string consistency,
        int? maxStalenessSeconds = null, CancellationToken ct = default) =>
        SendAsync(HttpMethod.Put, $"api/Mongo/{clusterId}/consistency",
            new { consistency, maxStalenessSeconds }, cancellationToken: ct);

    // ── YugabyteDB ──────────────────────────────────────────────────────

    public Task<JsonDocument> YugabyteClustersAsync(CancellationToken ct = default) =>
        SendAsync(HttpMethod.Get, "api/Yugabyte", cancellationToken: ct);

    /// <summary>One node per region; replication factor follows the count and is kept odd.</summary>
    public Task<JsonDocument> CreateYugabyteClusterAsync(string clusterName, string[]? regions = null,
        string sku = "small", string? engineVersion = null, string? databaseName = null,
        int storageGb = 20, CancellationToken ct = default)
    {
        regions ??= new[] { "canada" };
        return SendAsync(HttpMethod.Post, "api/Yugabyte", new
        {
            clusterName,
            regions,
            region = regions[0],
            sku,
            engineVersion,
            databaseName,
            storageGb,
        }, cancellationToken: ct);
    }

    public Task<JsonDocument> DeleteYugabyteClusterAsync(Guid clusterId, CancellationToken ct = default) =>
        SendAsync(HttpMethod.Delete, $"api/Yugabyte/{clusterId}", cancellationToken: ct);

    public Task<JsonDocument> YugabyteConnectionAsync(Guid clusterId, CancellationToken ct = default) =>
        SendAsync(HttpMethod.Get, $"api/Yugabyte/{clusterId}/connection", cancellationToken: ct);

    /// <summary>Yugabyte speaks the PostgreSQL wire protocol, so any Postgres driver works too.</summary>
    public Task<JsonDocument> YugabyteQueryAsync(Guid clusterId, string sql, int maxRows = 1000,
        CancellationToken ct = default) =>
        SendAsync(HttpMethod.Post, $"api/Yugabyte/{clusterId}/query", new { sql, maxRows }, cancellationToken: ct);

    public Task<JsonDocument> YugabyteTablesAsync(Guid clusterId, CancellationToken ct = default) =>
        SendAsync(HttpMethod.Get, $"api/Yugabyte/{clusterId}/tables", cancellationToken: ct);

    // ── VPN Gateway ─────────────────────────────────────────────────────

    public Task<JsonDocument> VpnGatewaysAsync(CancellationToken ct = default) =>
        SendAsync(HttpMethod.Get, "api/VPNGateway/list", cancellationToken: ct);

    /// <summary><paramref name="gatewayType"/> 0 is Site-to-Site (WireGuard), 1 is Point-to-Site (OpenVPN).</summary>
    public Task<JsonDocument> CreateVpnGatewayAsync(string name, string region = "canada",
        int gatewayType = 1, string? vNetId = null, string? vNetName = null,
        string? addressPool = null, string? protocol = null, int? port = null,
        string[]? dnsServers = null, bool splitTunneling = true, CancellationToken ct = default) =>
        SendAsync(HttpMethod.Post, "api/VPNGateway/create", new
        {
            name,
            region,
            gatewayType,
            vNetId,
            vNetName,
            addressPool,
            protocol,
            port,
            dnsServers,
            splitTunneling,
        }, cancellationToken: ct);

    public Task<JsonDocument> DeleteVpnGatewayAsync(Guid gatewayId, string gatewayName,
        string? region = null, CancellationToken ct = default)
    {
        var path = $"api/VPNGateway/{gatewayId}?gatewayName={Uri.EscapeDataString(gatewayName)}";
        if (!string.IsNullOrWhiteSpace(region)) path += $"&region={Uri.EscapeDataString(region!)}";
        return SendAsync(HttpMethod.Delete, path, cancellationToken: ct);
    }

    /// <summary>Issues a Point-to-Site client certificate.</summary>
    public Task<JsonDocument> CreateVpnClientAsync(Guid gatewayId, string name, string? email = null,
        string? region = null, CancellationToken ct = default)
    {
        var path = "api/VPNGateway/clients/p2s";
        if (!string.IsNullOrWhiteSpace(region)) path += $"?region={Uri.EscapeDataString(region!)}";
        return SendAsync(HttpMethod.Post, path, new { name, gatewayId, emailId = email }, cancellationToken: ct);
    }

    public Task<JsonDocument> VpnClientsAsync(Guid gatewayId, CancellationToken ct = default) =>
        SendAsync(HttpMethod.Get, $"api/VPNGateway/{gatewayId}/clients/p2s", cancellationToken: ct);

    /// <summary>
    /// Withdraws a client certificate. The record stays visible as revoked and its name
    /// stays taken, so the same identity cannot be reissued.
    /// </summary>
    public Task<JsonDocument> RevokeVpnClientAsync(Guid clientId, string? region = null,
        CancellationToken ct = default)
    {
        var path = $"api/VPNGateway/clients/p2s/{clientId}";
        if (!string.IsNullOrWhiteSpace(region)) path += $"?region={Uri.EscapeDataString(region!)}";
        return SendAsync(HttpMethod.Delete, path, cancellationToken: ct);
    }
}

public sealed partial class HiokException : Exception
{
    public System.Net.HttpStatusCode? StatusCode { get; }
    public HiokException(string message, System.Net.HttpStatusCode? statusCode = null) : base(message) => StatusCode = statusCode;
}
