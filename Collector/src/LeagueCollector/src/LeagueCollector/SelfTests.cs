using System.Text.Json.Nodes;
using BlueBottleIPC.LeagueBroadcast.Common;
using BlueBottleIPC.LeagueBroadcast.Snapshot;
using FlatSharp;

namespace LeagueCollector;

public static class SelfTests
{
    public static Task<int> Run()
    {
        try
        {
            var hero = new AIHeroClient { Info = new ObjectInfo { Name = "Fixture", Position = new Vector3(12, 34, 56), NetworkId = 123, Rotation = float.NaN },
                Common = new AIClient { Identifier = "Ahri", Health = 345, MaxHealth = 1000 }, Gold = 42, Kills = 3 };
            var response = new Response { RequestId = 17, Data = new ResponseKind(new GameInfo {
                GameTime = 12.5f, GameId = "fixture", Heroes = new List<AIHeroClient> { hero }, Minions = new List<AIMinionClient>() }) };
            var bytes = new byte[Response.Serializer.GetMaxSize(response)];
            int size = Response.Serializer.Write(bytes, response);
            var parsed = Response.Serializer.Parse(new ReadOnlyMemory<byte>(bytes, 0, size));
            var node = SchemaJson.Convert(parsed.Data.GameInfo, typeof(GameInfo))!;
            if (node["heroes"]![0]!["info"]!["position"]!["z"]!.GetValue<float>() != 56 ||
                node["heroes"]![0]!["common"]!["health"]!.GetValue<float>() != 345 ||
                node["heroes"]![0]!["info"]!["rotation"] != null || node["heroes"]![0]!["kills"]!.GetValue<int>() != 3)
                throw new Exception("Full snapshot projection failed.");
            if (((JsonObject)node).ContainsKey("minionMap")) throw new Exception("Computed snapshot property leaked.");
            var identity = LcuIdentity.Parse("LeagueClient:123:456:TEST_TOKEN:https");
            if (identity.Port != 456 || identity.ToString().Contains("TEST_TOKEN")) throw new Exception("Lockfile identity failed.");
            try { LcuIdentity.Parse("LeagueClient:0:456:TEST_TOKEN:https"); throw new Exception("Invalid lockfile accepted."); }
            catch (InvalidDataException) { }
            try { CollectorOptions.Parse(["--live-url", "https://example.com/"]); throw new Exception("Remote API accepted."); }
            catch (ArgumentException) { }
            try { new Auth.SrpHelper(BlueBottleAuth.Pool).GetClaimResponse("fixture", "fixture", "01", "00", "AA==", "fixture"); throw new Exception("Invalid SRP B accepted."); }
            catch (InvalidOperationException) { }
            string? oldEmail = Environment.GetEnvironmentVariable("LB_EMAIL"), oldPassword = Environment.GetEnvironmentVariable("LB_PASSWORD");
            string envFile = Path.Combine(Path.GetTempPath(), "collector-env-" + Guid.NewGuid().ToString("N"));
            try
            {
                Environment.SetEnvironmentVariable("LB_EMAIL", null); Environment.SetEnvironmentVariable("LB_PASSWORD", null);
                File.WriteAllText(envFile, "LB_EMAIL='fixture@example.invalid'\nLB_PASSWORD=\" leading:$`\\#'trailing \"\n");
                DotEnv.Load(envFile);
                if (Environment.GetEnvironmentVariable("LB_PASSWORD") != " leading:$`\\#'trailing ") throw new Exception("Literal credential parsing failed.");
            }
            finally { File.Delete(envFile); Environment.SetEnvironmentVariable("LB_EMAIL", oldEmail); Environment.SetEnvironmentVariable("LB_PASSWORD", oldPassword); }
            Console.WriteLine("{\"selfTest\":\"passed\",\"checks\":[\"native_flatbuffer_to_json\",\"vector_fields\",\"nan_to_null\",\"schema_fields_only\",\"lcu_lockfile\",\"loopback_url_only\",\"srp_invalid_challenge\",\"literal_credential_quotes\"]}");
            return Task.FromResult(0);
        }
        catch (Exception e) { Console.Error.WriteLine("Self-test failed: " + e.GetType().Name + " " + e.Message); return Task.FromResult(1); }
    }
}
