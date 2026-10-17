using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text.Json;

namespace LeagueCollector;

// Endpoint metadata only. Never connects a pipe/TCP session, sends a command,
// loads/injects a native DLL, enumerates modules or reads gameplay memory.
public static class PassiveIpcStatus
{
    public static async Task<int> Run()
    {
        string stage = "replay-api";
        try
        {
            if (!OperatingSystem.IsWindows()) throw new PlatformNotSupportedException();
            using var deadline = new CancellationTokenSource(TimeSpan.FromSeconds(10));
            using var http = LocalLeagueHttp.Create();
            using var response = await http.GetAsync("https://127.0.0.1:2999/replay/game", deadline.Token);
            response.EnsureSuccessStatusCode();
            var game = await LocalLeagueHttp.ReadJson(response, deadline.Token);
            int pid = game?["processID"]?.GetValue<int>() ?? game?["processId"]?.GetValue<int>() ?? 0;
            if (pid <= 0) throw new InvalidDataException();
            stage = "identity-metadata";
            using var process = Process.GetProcessById(pid);
            if (process.HasExited || !StringComparer.OrdinalIgnoreCase.Equals(process.ProcessName, "League of Legends"))
                throw new InvalidDataException();
            int session = process.SessionId;
            // Reuse original naming/owner lookup, without calling its Connect.
            var assembly = typeof(Farsight.LeagueConnector).Assembly;
            var identityType = assembly.GetType("Farsight.IPC2.FarsightServerIdentity", true)!;
            object identity = Activator.CreateInstance(identityType, new object[] { pid, session })!;
            stage = "pipe-presence";
            var pipe = assembly.GetType("Farsight.IPC2.NamedPipeTransport", true)!;
            bool pipeCandidate = (bool)pipe.GetMethod("ProbeExists", BindingFlags.Static | BindingFlags.NonPublic)!
                .Invoke(null, new[] { identity })!;
            int reportedPipeError = Marshal.GetLastPInvokeError();
            stage = "tcp-owner-metadata";
            var tcp = assembly.GetType("Farsight.IPC2.TcpTransport", true)!;
            bool tcpBoundToGame = (bool)tcp.GetMethod("IsServerPortBound", BindingFlags.Static | BindingFlags.NonPublic)!
                .Invoke(null, new object[] { identity, (ushort)4998 })!;
            Console.WriteLine(JsonSerializer.Serialize(new {
                kind = "passive-native-ipc-status", capturedAt = DateTimeOffset.UtcNow,
                status = "observed", targetIdentityMatched = true,
                pipeCandidate, reportedPipeError, pipeOwnerVerified = false,
                tcpBoundToGame, tcpPort = 4998,
                connectionAttempted = false, snapshotRequestSent = false,
                nativeLibraryLoadedByProbe = false, injectionAttempted = false,
                telemetryFields = 0, nativeInitializedVerified = false,
            }, CollectorHub.Json));
            return 0;
        }
        catch
        {
            Console.WriteLine(JsonSerializer.Serialize(new {
                kind = "passive-native-ipc-status", capturedAt = DateTimeOffset.UtcNow,
                status = "unavailable", failedStage = stage,
                connectionAttempted = false, snapshotRequestSent = false,
                nativeLibraryLoadedByProbe = false, injectionAttempted = false, telemetryFields = 0,
            }, CollectorHub.Json));
            return 1;
        }
    }
}
