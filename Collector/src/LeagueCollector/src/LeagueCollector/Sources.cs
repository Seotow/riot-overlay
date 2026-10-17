using System.Text.Json;
using System.Text.Json.Nodes;
using BlueBottleIPC.LeagueBroadcast.Snapshot;
using Farsight;

namespace LeagueCollector;

public sealed class SourceWorker(CollectorOptions options, CollectorHub hub, BlueBottleAuth auth, ILoggerFactory loggers) : BackgroundService
{
    protected override async Task ExecuteAsync(CancellationToken ct)
    {
        try
        {
            switch (options.Source)
            {
                case "demo": await Demo(ct); break;
                case "replay": await Replay(ct); break;
                case "live": await Live(ct); break;
                case "lblib": await Native(ct); break;
            }
        }
        catch (OperationCanceledException) when (ct.IsCancellationRequested) { }
        catch (Exception e)
        {
            string code = e is PlatformNotSupportedException ? "windows_required" : e is InvalidDataException ? "invalid_source_data" : "source_failed";
            hub.State("error", code);
            loggers.CreateLogger("Source").LogError("Source stopped: {Code} ({ExceptionType})", code, e.GetType().Name);
        }
        finally { if (ct.IsCancellationRequested) hub.State("stopped"); }
    }

    private async Task Native(CancellationToken ct)
    {
        if (!OperatingSystem.IsWindows()) throw new PlatformNotSupportedException();
        // Skipping account login/feature signing is an experimental code path.
        // Empty features do not prove native acceptance or parity with LB Free.
        if (auth.Configured) await auth.Initialize(ct);
        LeagueConnector.EnableLogging(loggers);
        LeagueConnector.Port = 4998;
        LeagueConnector.AppId = "league-collector";
        // The released, process-verified TCP transport supports an unsigned host.
        // Feature proofs and native feature gates remain unchanged.
        LeagueConnector.PreferTcpTransport = true;
        LeagueConnector.AutoInject = options.AutoInject;
        LeagueConnector.EnableGameLibFetching(new NativeLibraryFetcher(options, auth));
        LeagueConnector.AddFeatures(auth.Features, challenge => auth.Sign(challenge, ct));
        var starts = System.Threading.Channels.Channel.CreateBounded<bool>(1);
        var sessionSync = new object();
        bool active = false;
        void Started(object? s, NativeGameStartedEventArgs e) { lock (sessionSync) {
            if (ct.IsCancellationRequested) return;
            active = true; hub.NativeStage("ready"); starts.Writer.TryWrite(true);
        } }
        void Ended(object? s, NativeGameEndedEventArgs e) { lock (sessionSync) {
            active = false;
            if (!ct.IsCancellationRequested) { hub.NativeStage("disconnected"); hub.State("waiting", "game_ended"); }
        } }
        void Failed(object? s, Exception e) { if (!ct.IsCancellationRequested) { hub.NativeStage("initialization-failed"); hub.State("error", "native_connection_failed"); } }
        void WindowOpened(object? s, GameWindowOpenedEventArgs e) { if (!ct.IsCancellationRequested) hub.NativeStage("window-detected"); }
        void InjectReported(object? s, EventArgs e) { if (!ct.IsCancellationRequested) hub.NativeStage("awaiting-ipc"); }
        void Snapshot(object? s, GameInfo info)
        {
            lock (sessionSync)
            {
                if (!active || ct.IsCancellationRequested) return;
                try { hub.Publish("snapshot", SchemaJson.Convert(info, typeof(GameInfo))!); hub.NativeStage("streaming"); }
                catch { hub.State("error", "snapshot_decode_failed"); }
            }
        }
        LeagueConnector.GameStarted += Started;
        LeagueConnector.GameEnded += Ended;
        LeagueConnector.InjectionFailed += Failed;
        LeagueConnector.GameInfoReceived += Snapshot;
        LeagueConnector.GameWindowOpened += WindowOpened;
        LeagueConnector.Injected += InjectReported;
        hub.State("waiting");
        hub.NativeStage("watching");
        using var lifecycle = new NativeLifecycleScope(ct, () => {
            // Deliver cancellation while startup/connect is still awaiting.
            hub.NativeStage("stopping");
            LeagueConnector.AutoInject = false;
            LeagueConnector.StopWatchingForGameStart();
        });
        Task? capture = null;
        try
        {
            // Subscribe to the ready queue BEFORE watcher startup can block.
            capture = Task.Run(async () =>
            {
                await foreach (var _ in starts.Reader.ReadAllAsync(ct))
                {
                    lock (sessionSync) { if (!active) continue; }
                    try
                    {
                        hub.NativeStage("registering-service");
                        if (!await LeagueConnector.StartLeagueBroadcastSocketService(options.IntervalMs)) {
                            hub.NativeStage("service-rejected"); hub.State("error", "snapshot_registration_failed");
                        } else if (!ct.IsCancellationRequested && hub.Latest("snapshot") == null) hub.NativeStage("awaiting-snapshot");
                    }
                    catch (OperationCanceledException) when (ct.IsCancellationRequested) { break; }
                    catch { hub.State("error", "snapshot_registration_failed"); }
                }
            }, ct);
            await LeagueConnector.StartWatchingForGameStart(null, true, ct);
            while (!ct.IsCancellationRequested)
            {
                if (LeagueConnector.HandshakeFailed) { hub.NativeStage("handshake-failed"); hub.State("error", "native_feature_authentication_failed"); }
                await Task.Delay(500, ct);
            }
            await capture;
        }
        finally
        {
            lock (sessionSync) active = false;
            LeagueConnector.GameStarted -= Started;
            LeagueConnector.GameEnded -= Ended;
            LeagueConnector.InjectionFailed -= Failed;
            LeagueConnector.GameInfoReceived -= Snapshot;
            LeagueConnector.GameWindowOpened -= WindowOpened;
            LeagueConnector.Injected -= InjectReported;
            // Stop this client's subscription; do not send Quit to other LB users.
            if (LeagueConnector.IsConnected())
                try { await LeagueConnector.StopLeagueBroadcastSocketService().WaitAsync(TimeSpan.FromSeconds(2)); } catch { }
            lifecycle.RequestStop();
            bool watcherStopped = await LeagueConnector.StopWatchingForGameStartAsync(TimeSpan.FromSeconds(2));
            starts.Writer.TryComplete();
            bool captureStopped = true;
            if (capture != null)
                try { await capture.WaitAsync(TimeSpan.FromSeconds(2)); }
                catch (OperationCanceledException) when (ct.IsCancellationRequested) { }
                catch { captureStopped = false; }
            hub.NativeStage(lifecycle.StopFailed || !watcherStopped ? "stop-failed" : captureStopped ? "stopped" : "capture-stop-unavailable");
        }
    }

    private async Task Live(CancellationToken ct)
    {
        using var client = LocalLeagueHttp.Create();
        hub.State("waiting");
        while (!ct.IsCancellationRequested)
        {
            try
            {
                using var response = await client.GetAsync(options.LiveUrl, ct);
                response.EnsureSuccessStatusCode();
                var raw = await LocalLeagueHttp.ReadJson(response, ct);
                if (raw?["gameData"]?["gameTime"] == null || raw["allPlayers"] is not JsonArray) throw new InvalidDataException();
                // Keep the full upstream payload. Missing native positions/camera
                // are explicit nulls, not invented values.
                var data = new JsonObject
                {
                    ["gameTime"] = raw["gameData"]!["gameTime"]!.DeepClone(),
                    ["gameId"] = null, ["heroes"] = raw["allPlayers"]!.DeepClone(),
                    ["camera"] = null, ["objects"] = null,
                    ["events"] = raw["events"]?.DeepClone(), ["rawLiveClientData"] = raw,
                    ["capabilities"] = new JsonArray("liveStats", "events")
                };
                hub.Publish("snapshot", data);
            }
            catch (OperationCanceledException) when (ct.IsCancellationRequested) { throw; }
            catch { hub.State("waiting", "live_api_unavailable"); }
            await Task.Delay(options.IntervalMs, ct);
        }
    }

    private async Task Demo(CancellationToken ct)
    {
        long tick = 0;
        while (!ct.IsCancellationRequested)
        {
            var data = new
            {
                gameTime = tick * options.IntervalMs / 1000.0, gameId = "SYNTHETIC-DEMO", playbackSpeed = 1,
                heroes = new[] {
                    new { info = new { name = "Demo Blue", networkId = 1, team = 1, position = new { x = 5000 + tick % 300, y = 0, z = 5000 } }, common = new { identifier = "Ahri", health = 900 - tick % 100, maxHealth = 1000, level = 10 }, gold = 1500 + tick, kills = 2, deaths = 1, assists = 3 },
                    new { info = new { name = "Demo Red", networkId = 2, team = 2, position = new { x = 9000 - tick % 300, y = 0, z = 9000 } }, common = new { identifier = "Garen", health = 1100 - tick % 150, maxHealth = 1500, level = 11 }, gold = 1600 + tick, kills = 1, deaths = 2, assists = 1 }
                }, camera = (object?)null, events = Array.Empty<object>()
            };
            hub.Publish("snapshot", data, synthetic: true);
            tick++;
            await Task.Delay(options.IntervalMs, ct);
        }
    }

    private async Task Replay(CancellationToken ct)
    {
        do
        {
            hub.State("replaying");
            using var reader = File.OpenText(options.Replay!);
            DateTimeOffset? previous = null;
            while (await reader.ReadLineAsync(ct) is { } line)
            {
                if (line.Length == 0) continue;
                if (line.Length > 16 * 1024 * 1024) throw new InvalidDataException();
                using var doc = JsonDocument.Parse(line);
                var root = doc.RootElement;
                if (root.GetProperty("schemaVersion").GetInt32() != 1) throw new InvalidDataException();
                var type = root.GetProperty("type").GetString()!;
                if (type is not ("snapshot" or "lcu" or "status")) throw new InvalidDataException();
                var time = root.GetProperty("timestamp").GetDateTimeOffset();
                if (previous.HasValue)
                {
                    double wait = (time - previous.Value).TotalMilliseconds / options.Speed;
                    if (wait < 0 || wait > TimeSpan.FromHours(24).TotalMilliseconds) throw new InvalidDataException();
                    await Task.Delay(TimeSpan.FromMilliseconds(wait), ct);
                }
                previous = time;
                hub.Publish(type, root.GetProperty("data").Clone(), source: "replay", synthetic: root.TryGetProperty("synthetic", out var s) && s.GetBoolean(), recordedAt: time);
            }
            hub.State("ended", "replay_complete");
        } while (options.Loop && !ct.IsCancellationRequested);
    }
}
