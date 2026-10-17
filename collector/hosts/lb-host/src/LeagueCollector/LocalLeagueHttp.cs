using System.Net;
using System.Text.Json.Nodes;

namespace LeagueCollector;

public static class LocalLeagueHttp
{
    public static HttpClient Create() => new(new HttpClientHandler
    {
        // Riot's local API uses a self-signed certificate. The exception is
        // confined to loopback; all Internet requests retain TLS verification.
        UseProxy = false, AllowAutoRedirect = false,
        ServerCertificateCustomValidationCallback = (request, _, _, errors) => errors == System.Net.Security.SslPolicyErrors.None ||
            (IPAddress.TryParse(request.RequestUri!.Host, out var ip) && IPAddress.IsLoopback(ip))
    }) { Timeout = TimeSpan.FromSeconds(3) };

    public static async Task<JsonNode?> ReadJson(HttpResponseMessage response, CancellationToken ct)
    {
        if (response.Content.Headers.ContentLength > 16 * 1024 * 1024) throw new InvalidDataException();
        await using var stream = await response.Content.ReadAsStreamAsync(ct);
        using var buffer = new MemoryStream();
        var block = new byte[8192]; int read;
        while ((read = await stream.ReadAsync(block, ct)) != 0)
        {
            if (buffer.Length + read > 16 * 1024 * 1024) throw new InvalidDataException();
            buffer.Write(block, 0, read);
        }
        return JsonNode.Parse(buffer.ToArray());
    }
}
