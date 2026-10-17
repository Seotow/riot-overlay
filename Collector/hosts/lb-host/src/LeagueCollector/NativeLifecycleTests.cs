using System.Diagnostics;
using System.Reflection;
using System.Text.Json;

namespace LeagueCollector;

// Synthetic/lab lifecycle tests. Internal connector selects ONLY this own PID;
// no game detection, injection, authentication, protocol requests or snapshots.
public static class NativeLifecycleTests
{
    public static async Task<int> Run()
    {
        if (!OperatingSystem.IsWindows()) return 2;
        var results = new List<object>();
        int failures = 0;
        async Task Case(string name, Func<Task> test)
        {
            var elapsed = Stopwatch.StartNew();
            try {
                await test().WaitAsync(TimeSpan.FromSeconds(5));
                results.Add(new { name, passed = true, elapsedMs = elapsed.ElapsedMilliseconds, gameAccessed = false });
            } catch {
                failures++;
                results.Add(new { name, passed = false, elapsedMs = elapsed.ElapsedMilliseconds, gameAccessed = false });
            }
        }
        await Case("actual-connect-unlinked-cancellation-reproduced", async () => {
            using var socket = new OwnSocket();
            using var host = new CancellationTokenSource();
            using var independent = new CancellationTokenSource();
            Task connecting = socket.Connect(independent);
            try {
                await Task.Delay(100);
                Check(socket.State == "Connecting" && !connecting.IsCompleted);
                host.Cancel(); // The OLD host token does not reach this loop.
                await Task.Delay(300);
                Check(!connecting.IsCompleted && socket.State == "Connecting");
            } finally {
                independent.Cancel(); await socket.Disconnect();
                await connecting.WaitAsync(TimeSpan.FromSeconds(2));
            }
        });
        await Case("actual-connect-stop-delivered", async () => {
            using var socket = new OwnSocket();
            using var host = new CancellationTokenSource();
            using var independent = new CancellationTokenSource();
            int stops = 0;
            using var lifetime = new NativeLifecycleScope(host.Token, () => {
                Interlocked.Increment(ref stops); independent.Cancel();
                socket.Disconnect().GetAwaiter().GetResult();
            });
            Task connecting = socket.Connect(independent);
            try {
                await Task.Delay(100);
                Check(socket.State == "Connecting" && !connecting.IsCompleted);
                host.Cancel();
                await connecting.WaitAsync(TimeSpan.FromSeconds(2));
                Check(socket.State == "Disconnected" && stops == 1 && lifetime.StopRequested && !lifetime.StopFailed);
            } finally { independent.Cancel(); await socket.Disconnect(); await connecting.WaitAsync(TimeSpan.FromSeconds(2)); }
        });
        await Case("dispose-stops-once", () => {
            int stops = 0;
            var lifetime = new NativeLifecycleScope(CancellationToken.None, () => stops++);
            lifetime.Dispose(); lifetime.Dispose(); lifetime.RequestStop();
            Check(stops == 1 && lifetime.StopRequested && !lifetime.StopFailed);
            return Task.CompletedTask;
        });
        await Case("cancel-before-start", () => {
            using var host = new CancellationTokenSource(); host.Cancel();
            int stops = 0;
            using var lifetime = new NativeLifecycleScope(host.Token, () => stops++);
            Check(stops == 1 && lifetime.StopRequested);
            return Task.CompletedTask;
        });
        await Case("concurrent-cancel-dispose-24-iterations", async () => {
            for (int i = 0; i < 24; i++) {
                using var host = new CancellationTokenSource();
                int stops = 0;
                var lifetime = new NativeLifecycleScope(host.Token, () => Interlocked.Increment(ref stops));
                await Task.WhenAll(Task.Run(host.Cancel), Task.Run(lifetime.Dispose));
                lifetime.Dispose(); Check(stops == 1 && !lifetime.StopFailed);
            }
        });
        await Case("stop-failure-contained-and-reported", () => {
            using var host = new CancellationTokenSource();
            using var lifetime = new NativeLifecycleScope(host.Token, () => throw new InvalidOperationException());
            host.Cancel(); Check(lifetime.StopFailed && lifetime.StopRequested);
            return Task.CompletedTask;
        });
        await Case("synthetic-capture-cancels-with-host", async () => {
            using var host = new CancellationTokenSource();
            int stops = 0;
            using var lifetime = new NativeLifecycleScope(host.Token, () => stops++);
            Task capture = Task.Delay(Timeout.InfiniteTimeSpan, host.Token);
            host.Cancel();
            try { await capture; } catch (OperationCanceledException) { }
            Check(capture.IsCanceled && stops == 1);
        });
        await Case("native-stage-isolated-from-demo", () => {
            var native = new CollectorHub(new CollectorOptions { Source = "lblib" });
            native.NativeStage("awaiting-ipc");
            var doc = JsonSerializer.SerializeToElement(native.Status(), CollectorHub.Json);
            Check(doc.GetProperty("nativeStage").GetString() == "awaiting-ipc" && doc.GetProperty("snapshots").GetInt64() == 0);
            var demo = new CollectorHub(new CollectorOptions { Source = "demo" });
            demo.NativeStage("awaiting-ipc");
            var demoDoc = JsonSerializer.SerializeToElement(demo.Status(), CollectorHub.Json);
            Check(demoDoc.GetProperty("nativeStage").ValueKind == JsonValueKind.Null);
            return Task.CompletedTask;
        });
        await Case("watcher-cancel-before-child-barrier", async () => {
            using var host = new CancellationTokenSource();
            using var watcher = new Farsight.ManagedWatcherLifetime();
            var lease = watcher.Begin(host.Token);
            var released = new TaskCompletionSource(TaskCreationOptions.RunContinuationsAsynchronously);
            Task delayed = Task.Run(async () => {
                await released.Task;
                using var child = watcher.TryCreateChild(lease);
                Check(child == null && !watcher.IsCurrent(lease));
            });
            host.Cancel(); released.SetResult(); await delayed;
        });
        await Case("watcher-delayed-hook-after-stop-denied", async () => {
            using var watcher = new Farsight.ManagedWatcherLifetime();
            var lease = watcher.Begin(CancellationToken.None);
            var released = new TaskCompletionSource(TaskCreationOptions.RunContinuationsAsynchronously);
            int hooks = 0;
            Task delayed = Task.Run(async () => {
                await released.Task;
                Check(!watcher.TryRun(lease, () => hooks++));
            });
            watcher.Stop(); released.SetResult(); await delayed;
            Check(hooks == 0 && lease.Token.IsCancellationRequested);
        });
        await Case("watcher-old-generation-restart-denied", () => {
            using var watcher = new Farsight.ManagedWatcherLifetime();
            var old = watcher.Begin(CancellationToken.None);
            watcher.Stop();
            var fresh = watcher.Begin(CancellationToken.None);
            Check(!watcher.TryRun(old, () => throw new InvalidOperationException()));
            using var rejected = watcher.TryCreateChild(old);
            using var child = watcher.TryCreateChild(fresh);
            Check(rejected == null && child != null && watcher.IsCurrent(fresh));
            watcher.Stop(); Check(child!.IsCancellationRequested);
            return Task.CompletedTask;
        });
        await Case("watcher-async-cleanup-completion-observed", async () => {
            using var watcher = new Farsight.ManagedWatcherLifetime();
            var lease = watcher.Begin(CancellationToken.None);
            var completion = new TaskCompletionSource(TaskCreationOptions.RunContinuationsAsynchronously);
            Task? cleanup = null;
            watcher.Stop(() => cleanup = completion.Task);
            Check(!watcher.IsCurrent(lease) && cleanup != null && !cleanup.IsCompleted);
            // Stop is synchronous; callers must separately observe asynchronous cleanup.
            completion.SetResult(); await cleanup!.WaitAsync(TimeSpan.FromSeconds(1));
            Check(cleanup.IsCompletedSuccessfully);
        });
        await Case("watcher-stop-waits-install-before-cleanup", async () => {
            using var watcher = new Farsight.ManagedWatcherLifetime();
            var lease = watcher.Begin(CancellationToken.None);
            var entered = new TaskCompletionSource(TaskCreationOptions.RunContinuationsAsynchronously);
            var stopStarted = new TaskCompletionSource(TaskCreationOptions.RunContinuationsAsynchronously);
            using var release = new ManualResetEventSlim();
            int installFinished = 0, cleaned = 0;
            Task install = Task.Run(() => Check(watcher.TryRun(lease, () => {
                entered.SetResult();
                Check(release.Wait(TimeSpan.FromSeconds(2)));
                Volatile.Write(ref installFinished, 1);
            })));
            Task? stop = null;
            try {
                await entered.Task.WaitAsync(TimeSpan.FromSeconds(1));
                stop = Task.Run(() => {
                    stopStarted.SetResult();
                    watcher.Stop(() => {
                        Check(Volatile.Read(ref installFinished) == 1);
                        Interlocked.Increment(ref cleaned);
                    });
                });
                await stopStarted.Task.WaitAsync(TimeSpan.FromSeconds(1));
                await Task.Delay(20);
                Check(!stop.IsCompleted && Volatile.Read(ref cleaned) == 0);
            } finally {
                release.Set();
                await install.WaitAsync(TimeSpan.FromSeconds(2));
                if (stop != null) await stop.WaitAsync(TimeSpan.FromSeconds(2));
            }
            Check(cleaned == 1 && !watcher.IsCurrent(lease));
        });
        await Case("watcher-stopped-lease-never-installs", () => {
            using var watcher = new Farsight.ManagedWatcherLifetime();
            var lease = watcher.Begin(CancellationToken.None);
            watcher.Stop();
            int installed = 0;
            Check(!watcher.TryRun(lease, () => installed++));
            Check(installed == 0 && lease.Token.IsCancellationRequested);
            return Task.CompletedTask;
        });
        await Case("watcher-concurrent-startup-claim-once", async () => {
            using var watcher = new Farsight.ManagedWatcherLifetime();
            var lease = watcher.Begin(CancellationToken.None);
            int claims = 0;
            await Task.WhenAll(Enumerable.Range(0, 32).Select(_ => Task.Run(() => {
                if (watcher.TryClaimStartup(lease)) Interlocked.Increment(ref claims);
            })));
            Check(claims == 1 && !watcher.TryClaimStartup(lease));
        });
        await Case("watcher-startup-claim-stale-denied-new-generation-reset", () => {
            using var watcher = new Farsight.ManagedWatcherLifetime();
            var old = watcher.Begin(CancellationToken.None);
            Check(watcher.TryClaimStartup(old));
            watcher.Stop();
            Check(!watcher.TryClaimStartup(old));
            var fresh = watcher.Begin(CancellationToken.None);
            Check(!watcher.TryClaimStartup(old) && watcher.TryClaimStartup(fresh));
            Check(!watcher.TryClaimStartup(fresh));
            return Task.CompletedTask;
        });
        Console.WriteLine(JsonSerializer.Serialize(new { kind = "collector-lifecycle-lab", passed = failures == 0,
            cases = results.Count, failures, gameAccessed = false, telemetryFields = 0, results }, CollectorHub.Json));
        return failures == 0 ? 0 : 1;
    }

    private static void Check(bool value) { if (!value) throw new InvalidOperationException(); }

    private sealed class OwnSocket : IDisposable
    {
        private readonly Type type = typeof(Farsight.LeagueConnector).Assembly.GetType("Farsight.IPC2.FarsightSocketClient", true)!;
        private readonly object instance;
        public OwnSocket()
        {
            instance = Activator.CreateInstance(type, new object?[] { null })!;
            type.GetProperty("PreferTcp")!.SetValue(instance, true);
        }
        public string? State => type.GetProperty("ConnectionStatus")!.GetValue(instance)?.ToString();
        public Task Connect(CancellationTokenSource token)
        {
            using var self = Process.GetCurrentProcess();
            // The current process has no listener at this port. Even an external
            // port owner is rejected by the ORIGINAL PID/session verification.
            return (Task)type.GetMethod("Connect", BindingFlags.Instance | BindingFlags.NonPublic)!
                .Invoke(instance, new object?[] { Environment.ProcessId, self.SessionId, "127.0.0.1", (short)19986, token })!;
        }
        public Task Disconnect() => (Task)type.GetMethod("Disconnect")!.Invoke(instance, null)!;
        public void Dispose() => ((IDisposable)instance).Dispose();
    }
}
