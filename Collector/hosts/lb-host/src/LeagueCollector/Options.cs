using System.Globalization;
using System.Net;

namespace LeagueCollector;

public sealed record CollectorOptions
{
    public string Source { get; init; } = "lblib";
    public int Port { get; init; } = 18799;
    public int IntervalMs { get; init; } = 100;
    public bool Lcu { get; init; } = OperatingSystem.IsWindows();
    public string? Lockfile { get; init; }
    public Uri LiveUrl { get; init; } = new("https://127.0.0.1:2999/liveclientdata/allgamedata");
    public string? Replay { get; init; }
    public string? Record { get; init; }
    public double Speed { get; init; } = 1;
    public bool Loop { get; init; }
    public bool AutoInject { get; init; } = true;
    public bool UpdateLib { get; init; }
    public bool Doctor { get; init; }
    public bool SelfTest { get; init; }
    public bool ExportDiagnostics { get; init; }
    public string? DiagnosticsDirectory { get; init; }
    public long StaleMs => Math.Max(2000, IntervalMs * 10L);

    public static CollectorOptions Parse(string[] args)
    {
        var o = new CollectorOptions();
        for (int i = 0; i < args.Length; i++)
        {
            string Value() => ++i < args.Length ? args[i] : throw new ArgumentException("Missing option value.");
            o = args[i] switch
            {
                "--source" => o with { Source = Value().ToLowerInvariant() },
                "--port" => o with { Port = int.Parse(Value(), CultureInfo.InvariantCulture) },
                "--interval" => o with { IntervalMs = int.Parse(Value(), CultureInfo.InvariantCulture) },
                "--lcu" => o with { Lcu = true },
                "--no-lcu" => o with { Lcu = false },
                "--lockfile" => o with { Lockfile = Path.GetFullPath(Value()), Lcu = true },
                "--live-url" => o with { LiveUrl = new Uri(Value()) },
                "--replay" => o with { Replay = Path.GetFullPath(Value()), Source = "replay" },
                "--record" => o with { Record = Path.GetFullPath(Value()) },
                "--speed" => o with { Speed = double.Parse(Value(), CultureInfo.InvariantCulture) },
                "--loop" => o with { Loop = true },
                "--no-inject" => o with { AutoInject = false },
                "--update-lib" => o with { UpdateLib = true },
                "--doctor" => o with { Doctor = true },
                "--self-test" => o with { SelfTest = true },
                "--export-diagnostics" => o with { ExportDiagnostics = true },
                "--diagnostics-dir" => o with { DiagnosticsDirectory = Path.GetFullPath(Value()) },
                _ => throw new ArgumentException("Unknown command-line option.")
            };
        }
        if (!new[] { "lblib", "live", "demo", "replay" }.Contains(o.Source)) throw new ArgumentException("Source must be lblib, live, replay or demo.");
        if (o.Port < 1024 || o.Port > 65535 || o.IntervalMs < 25 || o.IntervalMs > 10000) throw new ArgumentException("Invalid port or interval (25..10000 ms).");
        if (!double.IsFinite(o.Speed) || o.Speed < 0.01 || o.Speed > 100) throw new ArgumentException("Replay speed must be 0.01..100.");
        if (o.Source == "replay" && (o.Replay == null || !File.Exists(o.Replay))) throw new ArgumentException("Replay file not found.");
        if (o.Record != null && o.Record == o.Replay) throw new ArgumentException("Recording cannot overwrite the replay input.");
        if (!IPAddress.TryParse(o.LiveUrl.Host, out var ip) || !IPAddress.IsLoopback(ip) || o.LiveUrl.Scheme is not ("http" or "https") || !string.IsNullOrEmpty(o.LiveUrl.UserInfo))
            throw new ArgumentException("Live API URL must use a loopback IP and HTTP(S).");
        return o;
    }
}
