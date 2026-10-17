using System.Diagnostics;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json.Nodes;

namespace LeagueCollector;

public sealed record LcuIdentity(int Pid, int Port, string Token)
{
    public static LcuIdentity Parse(string text)
    {
        var fields = text.Trim().Split(':');
        if (fields.Length != 5 || fields[0] != "LeagueClient" || !int.TryParse(fields[1], out int pid) || pid <= 0 ||
            !int.TryParse(fields[2], out int port) || port < 1 || port > 65535 || fields[3].Length is < 1 or > 4096 || fields[4] != "https")
            throw new InvalidDataException("invalid_lcu_lockfile");
        return new(pid, port, fields[3]);
    }
    // Never let generated record formatting expose the lockfile token.
    public override string ToString() => $"LCU PID={Pid} Port={Port}";
}

public sealed class LcuWorker(CollectorOptions options, CollectorHub hub) : BackgroundService
{
    private string? previous;
    protected override async Task ExecuteAsync(CancellationToken ct)
    {
        if (!options.Lcu) return;
        using var client = LocalLeagueHttp.Create();
        while (!ct.IsCancellationRequested)
        {
            try
            {
                string path = options.Lockfile ?? FindLockfile() ?? throw new IOException();
                await using var file = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite | FileShare.Delete);
                if (file.Length > 8192) throw new InvalidDataException();
                using var reader = new StreamReader(file);
                var id = LcuIdentity.Parse(await reader.ReadToEndAsync(ct));
                async Task<JsonNode?> Get(string endpoint)
                {
                    using var request = new HttpRequestMessage(HttpMethod.Get, $"https://127.0.0.1:{id.Port}{endpoint}");
                    request.Headers.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes("riot:" + id.Token)));
                    using var response = await client.SendAsync(request, ct);
                    if (response.StatusCode == System.Net.HttpStatusCode.NotFound) return null;
                    response.EnsureSuccessStatusCode();
                    return await LocalLeagueHttp.ReadJson(response, ct);
                }
                var phase = await Get("/lol-gameflow/v1/gameflow-phase");
                string? value = phase?.GetValue<string>();
                var session = value == "ChampSelect" ? await Get("/lol-champ-select/v1/session") : null;
                Publish(new JsonObject { ["state"] = "connected", ["phase"] = phase, ["champSelect"] = session });
            }
            catch (OperationCanceledException) when (ct.IsCancellationRequested) { break; }
            catch { Publish(new JsonObject { ["state"] = "waiting", ["phase"] = null, ["champSelect"] = null }); }
            try { await Task.Delay(Math.Max(250, options.IntervalMs), ct); } catch (OperationCanceledException) { break; }
        }
    }

    private void Publish(JsonObject data)
    {
        string serialized = data.ToJsonString();
        if (serialized == previous) return;
        previous = serialized;
        hub.Publish("lcu", data, source: "lcu", synthetic: false);
    }

    private static string? FindLockfile()
    {
        if (!OperatingSystem.IsWindows()) return null;
        foreach (var process in Process.GetProcessesByName("LeagueClientUx"))
        {
            using (process)
                try { if (process.MainModule?.FileName is { } file) return Path.Combine(Path.GetDirectoryName(file)!, "lockfile"); } catch { }
        }
        return null;
    }
}
