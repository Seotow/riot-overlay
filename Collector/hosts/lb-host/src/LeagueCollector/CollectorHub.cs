using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Channels;

namespace LeagueCollector;

public sealed record Frame(long Sequence, DateTimeOffset Timestamp, string Type, byte[] Bytes);

public sealed class CollectorHub(CollectorOptions options)
{
    private readonly object sync = new();
    private readonly Dictionary<Guid, Channel<Frame>> clients = new();
    private readonly Dictionary<string, Frame> latest = new();
    private long sequence, snapshots;
    private string state = "starting", error = "";
    private string? nativeStage;
    public static readonly JsonSerializerOptions Json = new(JsonSerializerDefaults.Web);

    public Frame Publish(string type, object data, string? source = null, bool? synthetic = null, DateTimeOffset? recordedAt = null)
    {
        lock (sync)
        {
            var now = DateTimeOffset.UtcNow;
            var bytes = JsonSerializer.SerializeToUtf8Bytes(new
            {
                schemaVersion = 1, sequence = ++sequence, timestamp = now, type,
                source = source ?? options.Source,
                synthetic = synthetic ?? options.Source == "demo", recordedAt, data
            }, Json);
            if (bytes.Length > 16 * 1024 * 1024) throw new InvalidDataException("Frame exceeds 16 MiB.");
            var frame = new Frame(sequence, now, type, bytes);
            latest[type] = frame;
            if (type == "snapshot") { snapshots++; state = "streaming"; error = ""; }
            foreach (var c in clients.Values) c.Writer.TryWrite(frame);
            return frame;
        }
    }

    public void State(string value, string? code = null)
    {
        lock (sync)
        {
            if (state == value && error == (code ?? "")) return;
            state = value; error = code ?? "";
            if (value is "waiting" or "error" or "ended" or "stopped") latest.Remove("snapshot");
            Publish("status", new { state, error = code });
        }
    }

    public void ClearLcu() { lock (sync) latest.Remove("lcu"); }
    public void NativeStage(string value) { lock (sync) nativeStage = value; }
    public Frame? Latest(string type) { lock (sync) return latest.GetValueOrDefault(type); }
    public object Status()
    {
        lock (sync)
        {
            Frame? f = latest.GetValueOrDefault("snapshot");
            double? age = f == null ? null : (DateTimeOffset.UtcNow - f.Timestamp).TotalMilliseconds;
            return new { source = options.Source, synthetic = options.Source == "replay" ? (bool?)null : options.Source == "demo", state, error = error.Length == 0 ? null : error,
                snapshots, sequence, clients = clients.Count, lastFrameAt = f?.Timestamp, ageMs = age,
                fresh = age.HasValue && age <= options.StaleMs, lcuEnabled = options.Lcu,
                nativeStage = options.Source == "lblib" ? nativeStage : null };
        }
    }

    public Subscription Subscribe(int capacity = 4)
    {
        lock (sync)
        {
            if (clients.Count >= 32) throw new InvalidOperationException("Too many subscribers.");
            var channel = Channel.CreateBounded<Frame>(new BoundedChannelOptions(capacity) { FullMode = BoundedChannelFullMode.DropOldest, SingleReader = true });
            var id = Guid.NewGuid();
            clients.Add(id, channel);
            foreach (var f in latest.Values.OrderBy(f => f.Sequence)) channel.Writer.TryWrite(f);
            return new Subscription(channel.Reader, () => { lock (sync) { clients.Remove(id); channel.Writer.TryComplete(); } });
        }
    }

    public sealed class Subscription(ChannelReader<Frame> reader, Action dispose) : IDisposable
    {
        public ChannelReader<Frame> Reader { get; } = reader;
        public void Dispose() => dispose();
    }
}
