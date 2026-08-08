using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;

namespace Hiok.Cloud;

public sealed class HiokClient
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

    public Task<JsonDocument> CreateVirtualMachineAsync(string name, string region = "south-india", string image = "ubuntu-24.04", int vcpus = 1, double ramGb = 1, CancellationToken ct = default) =>
        SendAsync(HttpMethod.Post, "api/VirtualMachine/create-vm", new { vmName = name, regions = new[] { region }, sourceFilePath = image, vcpuCount = vcpus, ramSize = ramGb }, cancellationToken: ct);

    public Task<JsonDocument> SearchAsync(string query, CancellationToken ct = default) =>
        SendAsync(HttpMethod.Get, $"api/search?q={Uri.EscapeDataString(query)}", cancellationToken: ct);

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
}

public sealed class HiokException : Exception
{
    public System.Net.HttpStatusCode? StatusCode { get; }
    public HiokException(string message, System.Net.HttpStatusCode? statusCode = null) : base(message) => StatusCode = statusCode;
}
