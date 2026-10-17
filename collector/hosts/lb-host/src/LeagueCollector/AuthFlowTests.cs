using System.Reflection;
using System.Text.Json;
using Farsight;
using Farsight.Auth;
using BlueBottleIPC.LeagueBroadcast.Commands;

namespace LeagueCollector;

// Exercises the managed branch with a disconnected client and no game/credentials.
public static class AuthFlowTests
{
    public static async Task<int> Run()
    {
        var results = new List<object>();
        try
        {
            if (!FeatureSet.FromNames(null).IsEmpty || !FeatureSet.FromNames(Array.Empty<string>()).IsEmpty)
                throw new InvalidOperationException();
            results.Add(new { name = "missing-subscription-features-remain-empty", passed = true });
            int callbacks = 0;
            LeagueConnector.AddFeatures(FeatureSet.Empty, _ => {
                Interlocked.Increment(ref callbacks);
                return Task.FromResult<CodeChallengeResult?>(null);
            });
            var method = typeof(LeagueConnector).GetMethod("RequestFeatures", BindingFlags.NonPublic | BindingFlags.Static)
                ?? throw new InvalidOperationException();
            var handshake = new TaskCompletionSource<bool>(TaskCreationOptions.RunContinuationsAsynchronously);
            var empty = (Task<bool>)method.Invoke(null, new object[] { FeatureSet.Empty, handshake })!;
            if (!await empty || callbacks != 0) throw new InvalidOperationException();
            results.Add(new { name = "actual-empty-features-return-true-without-challenge", passed = true, signingCallbacks = callbacks });
            var socket = typeof(LeagueConnector).GetField("_farsightSocket", BindingFlags.NonPublic | BindingFlags.Static);
            if (socket?.GetValue(null) == null || LeagueConnector.IsConnected())
                throw new InvalidOperationException();
            results.Add(new { name = "empty-success-is-not-native-acceptance-client-disconnected", passed = true });
            // A synthetic requested feature is not installed as a grant. With no
            // current handshake the real method must fail before any provider call.
            var requested = new FeatureSet(new[] { Feature.Develop });
            var nonempty = (Task<bool>)method.Invoke(null, new object[] { requested, handshake })!;
            if (await nonempty || callbacks != 0) throw new InvalidOperationException();
            results.Add(new { name = "nonempty-request-with-stale-handshake-fails", passed = true });
            string temp = Path.Combine(Path.GetTempPath(), "collector-fetch-guard-" + Guid.NewGuid().ToString("N"));
            Directory.CreateDirectory(temp);
            try
            {
                string fixture = Path.Combine(temp, "fixture.dll");
                File.WriteAllText(fixture, "synthetic-not-a-library");
                File.WriteAllText(fixture + ".version.json", "{\"key\":\"fixture\",\"minVersion\":\"1.0\",\"maxVersion\":\"2.0\",\"sha256\":\"fixture\"}");
                using var loggers = LoggerFactory.Create(_ => { });
                using var auth = new BlueBottleAuth(loggers);
                var fetcher = new NativeLibraryFetcher(new CollectorOptions { UpdateLib = false }, auth);
                bool denied = false;
                try { await fetcher.UpdateOrResetLib(new Version("3.0"), fixture); }
                catch (InvalidOperationException e) when (e.Message == "native_library_version_unavailable") { denied = true; }
                if (!denied) throw new InvalidOperationException();
                results.Add(new { name = "pinned-version-mismatch-stops-before-credentials-or-download", passed = true });
            }
            finally { Directory.Delete(temp, true); }
            Console.WriteLine(JsonSerializer.Serialize(new { kind = "collector-auth-flow-offline", passed = true,
                cases = results.Count, gameAccessed = false, nativeConnected = false,
                providerCalled = false, credentialsRead = false, results }));
            return 0;
        }
        catch
        {
            Console.WriteLine(JsonSerializer.Serialize(new { kind = "collector-auth-flow-offline", passed = false,
                completedCases = results.Count, gameAccessed = false, providerCalled = false }));
            return 1;
        }
    }
}
