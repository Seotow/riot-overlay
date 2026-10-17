using System.Net;
using System.Net.WebSockets;
using System.Text.Json;

namespace LeagueCollector;

public static class Program
{
    public static async Task<int> Main(string[] args)
    {
        if (args.SequenceEqual(new[] { "--auth-flow-self-test" })) return await AuthFlowTests.Run();
        if (args.SequenceEqual(new[] { "--lifecycle-self-test" })) return await NativeLifecycleTests.Run();
        if (args.SequenceEqual(new[] { "--ipc-status" })) return await PassiveIpcStatus.Run();
        // Workspace validation copy only: bounded no-injection/no-LCU run.
        // Original delivered ZIP, native DLL and feature/auth logic are unchanged.
        bool validationRun = args.Contains("--validation-30s-no-inject");
        bool validationInject = args.Contains("--validation-30s-single-inject");
        try { if (!args.Contains("--export-diagnostics")) DotEnv.Load(Environment.GetEnvironmentVariable("LB_CREDENTIAL_FILE") ?? Path.Combine(AppContext.BaseDirectory, "collector.env")); }
        catch { Console.Error.WriteLine("Invalid collector.env. Check the example file; values were not printed."); return 2; }
        if (args.Contains("--help"))
        {
            Console.WriteLine("LeagueCollector --source lblib|live|demo --port 18799 --interval 100\n  --replay FILE [--loop] [--speed 1] --record NEW_FILE\n  --lcu|--no-lcu [--lockfile FILE] --no-inject --update-lib\n  --doctor --self-test --auth-check\n  --export-diagnostics [--diagnostics-dir DIRECTORY] [--port 18799]\nBlueBottle email/password: LB_EMAIL and LB_PASSWORD environment variables.");
            return 0;
        }
        bool authCheck = args.Contains("--auth-check");
        CollectorOptions options;
        try { options = CollectorOptions.Parse(args.Where(x => x != "--auth-check" && x != "--validation-30s-no-inject" && x != "--validation-30s-single-inject").ToArray()); }
        catch { Console.Error.WriteLine("Invalid options. Run with --help."); return 2; }
        if (validationRun && (options.Source != "lblib" || options.AutoInject || options.Lcu || options.UpdateLib || authCheck || options.Record != null))
        { Console.Error.WriteLine("Validation requires lblib, --no-inject, --no-lcu and no update/auth/record options."); return 2; }
        if (validationInject && (validationRun || options.Source != "lblib" || !options.AutoInject || options.Lcu || options.UpdateLib || authCheck || options.Record != null))
        { Console.Error.WriteLine("Single injection validation requires lblib, no LCU and no update/auth/record options."); return 2; }
        if (options.SelfTest) return await SelfTests.Run();
        if (options.ExportDiagnostics) return await Diagnostics.Export(options);
        if (options.Doctor)
        {
            var path = Path.Combine(AppContext.BaseDirectory, "lblib.dll");
            bool valid = false;
            try { Farsight.Utils.DllValidator.Validate(path); valid = true; } catch { }
            Console.WriteLine(JsonSerializer.Serialize(new { os = System.Runtime.InteropServices.RuntimeInformation.OSDescription,
                architecture = System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture.ToString(),
                nativeCollectionSupported = OperatingSystem.IsWindows() && Environment.Is64BitProcess,
                nativeLibraryPresent = File.Exists(path), nativeLibraryPeValid = valid,
                source = options.Source, listen = $"http://127.0.0.1:{options.Port}", gameTested = false, validation = ProjectStatus.Current }, CollectorHub.Json));
            return valid || options.Source != "lblib" ? 0 : 1;
        }
        if (authCheck)
        {
            using var loggerFactory = LoggerFactory.Create(b => b.SetMinimumLevel(LogLevel.Warning));
            using var auth = new BlueBottleAuth(loggerFactory);
            if (!auth.Configured) { Console.WriteLine("{\"state\":\"not-configured\"}"); return 2; }
            try { await auth.Initialize(CancellationToken.None); Console.WriteLine(JsonSerializer.Serialize(auth.Status(), CollectorHub.Json)); return 0; }
            catch { Console.WriteLine("{\"state\":\"authentication-failed\"}"); return 1; }
        }
        var builder = WebApplication.CreateBuilder(new WebApplicationOptions { Args = [], ContentRootPath = AppContext.BaseDirectory, WebRootPath = Path.Combine(AppContext.BaseDirectory, "wwwroot") });
        builder.Logging.ClearProviders();
        builder.Logging.AddSimpleConsole(c => c.SingleLine = true);
        builder.Logging.SetMinimumLevel(LogLevel.Warning);
        builder.WebHost.ConfigureKestrel(k => { k.Listen(IPAddress.Loopback, options.Port); k.Limits.MaxRequestBodySize = 65536; });
        builder.Services.AddSingleton(options);
        builder.Services.AddSingleton<CollectorHub>();
        builder.Services.AddSingleton<BlueBottleAuth>();
        builder.Services.AddSingleton<Recorder>();
        // Subscribe the recorder before producers start.
        builder.Services.AddHostedService(p => p.GetRequiredService<Recorder>());
        builder.Services.AddHostedService<SourceWorker>();
        builder.Services.AddHostedService<LcuWorker>();
        builder.Services.AddHostedService<ParentLifetimeWorker>();
        var app = builder.Build();
        if (validationRun || validationInject)
            app.Lifetime.ApplicationStarted.Register(() =>
                _ = Task.Delay(TimeSpan.FromSeconds(30)).ContinueWith(_ => app.Lifetime.StopApplication()));
        if (validationInject)
        {
            int windows = 0;
            // One window attempt only. Stop before any second auto-injection,
            // and stop on error/disconnect instead of reconnecting or retrying.
            Farsight.LeagueConnector.GameWindowOpened += (_, e) => {
                int count = Interlocked.Increment(ref windows);
                Console.WriteLine(JsonSerializer.Serialize(new { validationEvent = "game-window", count,
                    gameVersion = Version.TryParse(e.GameVersion, out var v) ? v.ToString() : null }));
                if (count > 1) { Farsight.LeagueConnector.AutoInject = false; app.Lifetime.StopApplication(); }
            };
            Farsight.LeagueConnector.Injected += (_, _) =>
                Console.WriteLine("{\"validationEvent\":\"inject-reported\"}");
            Farsight.LeagueConnector.GameStarted += (_, _) =>
                Console.WriteLine("{\"validationEvent\":\"game-started\"}");
            Farsight.LeagueConnector.InjectionFailed += (_, e) => {
                string? errorType = e.GetType().Name;
                var match = System.Text.RegularExpressions.Regex.Match(e.Message, @"Error code:\s*(\d+)");
                int? reportedError = match.Success && int.TryParse(match.Groups[1].Value, out int value) ? value : null;
                Console.WriteLine(JsonSerializer.Serialize(new { validationEvent = "native-failed", errorType, reportedError }));
                Farsight.LeagueConnector.AutoInject = false; app.Lifetime.StopApplication();
            };
            Farsight.LeagueConnector.GameEnded += (_, _) => {
                Console.WriteLine("{\"validationEvent\":\"game-ended\"}");
                Farsight.LeagueConnector.AutoInject = false; app.Lifetime.StopApplication();
            };
        }
        app.Use(async (ctx, next) =>
        {
            string host = ctx.Request.Host.Host;
            string origin = ctx.Request.Headers.Origin.ToString();
            bool validOrigin = origin.Length == 0 || Uri.TryCreate(origin, UriKind.Absolute, out var uri) && uri.Scheme == "http" &&
                (uri.Host == "127.0.0.1" || uri.Host == "localhost") && uri.Port == options.Port;
            if ((host != "127.0.0.1" && host != "localhost") || !validOrigin) { ctx.Response.StatusCode = 403; return; }
            ctx.Response.Headers.XContentTypeOptions = "nosniff";
            ctx.Response.Headers.CacheControl = "no-store";
            ctx.Response.Headers.ContentSecurityPolicy = $"default-src 'self'; connect-src 'self' ws://127.0.0.1:{options.Port} ws://localhost:{options.Port}; frame-ancestors 'none'";
            await next(ctx);
        });
        app.UseWebSockets(new WebSocketOptions { KeepAliveInterval = TimeSpan.FromSeconds(20) });
        app.UseDefaultFiles();
        app.UseStaticFiles();
        app.MapGet("/api/status", (CollectorHub hub, BlueBottleAuth auth, Recorder recorder) => Results.Json(new { collector = hub.Status(), authentication = auth.Status(), recording = recorder.Status(), validation = ProjectStatus.Current }));
        app.MapGet("/api/health", (CollectorHub hub) => Results.Json(new { alive = true, collector = hub.Status() }));
        app.MapGet("/api/snapshot", (CollectorHub hub) => Latest(hub, "snapshot", options.StaleMs));
        app.MapGet("/api/lcu", (CollectorHub hub) => Latest(hub, "lcu", null));
        app.MapGet("/api/schema", () => Results.Json(new { schemaVersion = 1, transport = "json", websocket = "/ws",
            eventTypes = new[] { "snapshot", "lcu", "status" }, snapshot = "Native schema projection in lblib mode; some struct inline vectors are not exported. Full upstream payload under rawLiveClientData in live mode.",
            missingNumericData = "NaN/infinite values become null; native may also use zero or empty lists for unavailable data.", replay = "source=replay and recordedAt preserve provenance; synthetic marks generated frames." }));
        app.MapGet("/ws", Stream);
        app.MapPost("/internal/stop", (HttpContext ctx) => {
            string? expected = Environment.GetEnvironmentVariable("COLLECTOR_CONTROL_TOKEN");
            string supplied = ctx.Request.Headers["X-Collector-Control"].ToString();
            if (expected == null || expected.Length != 64 || supplied.Length != 64 ||
                !System.Security.Cryptography.CryptographicOperations.FixedTimeEquals(
                    System.Text.Encoding.UTF8.GetBytes(expected), System.Text.Encoding.UTF8.GetBytes(supplied)))
                return Results.StatusCode(403);
            app.Lifetime.StopApplication();
            return Results.Json(new { stopping = true });
        });
        Console.WriteLine($"LeagueCollector: http://127.0.0.1:{options.Port}/ | source={options.Source}");
        await app.RunAsync();
        return 0;
    }

    private static IResult Latest(CollectorHub hub, string type, long? staleMs)
    {
        var frame = hub.Latest(type);
        if (frame == null) return Results.NoContent();
        if (staleMs.HasValue && (DateTimeOffset.UtcNow - frame.Timestamp).TotalMilliseconds > staleMs.Value)
            return Results.Json(new { error = "snapshot_stale" }, statusCode: 503);
        return Results.Bytes(frame.Bytes, "application/json");
    }

    private static async Task Stream(HttpContext ctx, CollectorHub hub, IHostApplicationLifetime lifetime)
    {
        if (!ctx.WebSockets.IsWebSocketRequest) { ctx.Response.StatusCode = 400; return; }
        CollectorHub.Subscription subscription;
        try { subscription = hub.Subscribe(); } catch { ctx.Response.StatusCode = 503; return; }
        using (subscription)
        using (var socket = await ctx.WebSockets.AcceptWebSocketAsync())
        using (var cts = CancellationTokenSource.CreateLinkedTokenSource(ctx.RequestAborted, lifetime.ApplicationStopping))
        {
            async Task Send()
            {
                await foreach (var frame in subscription.Reader.ReadAllAsync(cts.Token))
                {
                    using var timeout = CancellationTokenSource.CreateLinkedTokenSource(cts.Token);
                    timeout.CancelAfter(TimeSpan.FromSeconds(5));
                    await socket.SendAsync(frame.Bytes.AsMemory(), WebSocketMessageType.Text, true, timeout.Token);
                }
            }
            async Task Receive()
            {
                var result = await socket.ReceiveAsync(new byte[1024].AsMemory(), cts.Token);
                if (result.MessageType == WebSocketMessageType.Close)
                    await socket.CloseOutputAsync(WebSocketCloseStatus.NormalClosure, "Closed", cts.Token);
                else await socket.CloseOutputAsync(WebSocketCloseStatus.PolicyViolation, "Read-only stream", cts.Token);
            }
            Task sending = Send(), receiving = Receive();
            try { await Task.WhenAny(sending, receiving); }
            finally
            {
                cts.Cancel();
                try { await Task.WhenAll(sending, receiving); } catch (Exception e) when (e is OperationCanceledException or WebSocketException or IOException) { }
            }
        }
    }
}
