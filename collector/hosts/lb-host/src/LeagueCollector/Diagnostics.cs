using System.IO.Compression;
using System.Text.Json;

namespace LeagueCollector;

// Read only our own loopback JSON endpoints. Never read env, lockfiles or logs.
public static class Diagnostics
{
    public static async Task<int> Export(CollectorOptions options)
    {
        string root = options.DiagnosticsDirectory ?? Path.Combine(AppContext.BaseDirectory, "test-results");
        string folder = Path.Combine(root, "diagnostics-" + DateTime.UtcNow.ToString("yyyyMMdd-HHmmss") + "-" + Guid.NewGuid().ToString("N")[..8]);
        Directory.CreateDirectory(folder);
        using var client = new HttpClient { Timeout = TimeSpan.FromSeconds(3) };
        var captures = new List<object>();
        bool statusReceived = false;
        foreach (string endpoint in new[] { "status", "health", "schema", "snapshot", "lcu" })
        {
            try
            {
                using var timeout = new CancellationTokenSource(TimeSpan.FromSeconds(3));
                using var response = await client.GetAsync($"http://127.0.0.1:{options.Port}/api/{endpoint}", HttpCompletionOption.ResponseHeadersRead, timeout.Token);
                int status = (int)response.StatusCode;
                if (status != 204)
                {
                    if (response.Content.Headers.ContentLength > 16 * 1024 * 1024) throw new InvalidDataException();
                    using var stream = await response.Content.ReadAsStreamAsync(timeout.Token);
                    using var buffer = new MemoryStream();
                    var bytes = new byte[8192];
                    int count;
                    while ((count = await stream.ReadAsync(bytes.AsMemory(), timeout.Token)) > 0)
                    {
                        if (buffer.Length + count > 16 * 1024 * 1024) throw new InvalidDataException();
                        buffer.Write(bytes, 0, count);
                    }
                    using var json = JsonDocument.Parse(buffer.ToArray());
                    await File.WriteAllTextAsync(Path.Combine(folder, endpoint + ".json"), json.RootElement.GetRawText());
                }
                if (endpoint == "status" && response.IsSuccessStatusCode && status != 204) statusReceived = true;
                captures.Add(new { endpoint = "/api/" + endpoint, httpStatus = status, error = (string?)null });
            }
            catch { captures.Add(new { endpoint = "/api/" + endpoint, httpStatus = (int?)null, error = "capture_failed" }); }
        }
        var summary = new
        {
            capturedAt = DateTimeOffset.UtcNow,
            collectorReached = statusReceived,
            validation = ProjectStatus.Current,
            captures,
            privacy = "No credential files, process environment, LCU lockfile or console logs are read. Snapshots may contain player names and game data."
        };
        await File.WriteAllTextAsync(Path.Combine(folder, "capture-summary.json"), JsonSerializer.Serialize(summary, new JsonSerializerOptions(CollectorHub.Json) { WriteIndented = true }));
        string archive = folder + ".zip";
        ZipFile.CreateFromDirectory(folder, archive);
        Console.WriteLine(JsonSerializer.Serialize(new { collectorReached = statusReceived, archive }, CollectorHub.Json));
        return statusReceived ? 0 : 1;
    }
}
