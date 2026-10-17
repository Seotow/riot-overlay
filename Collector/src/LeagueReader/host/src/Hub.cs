using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Channels;

namespace IndependentCollector;

internal sealed class Hub(Options options, Recording recording)
{
    internal static readonly JsonSerializerOptions Json = new(JsonSerializerDefaults.Web);
    private readonly object gate = new();
    private readonly Dictionary<long, Channel<byte[]>> clients = [];
    private long nextClient, sequence, snapshots;
    private byte[]? latest;
    private DateTimeOffset? capturedAt;
    private string state = "starting";
    private object? error;
    private TargetIdentity? target;
    private bool? synthetic;
    private bool rootsKnown;
    private string? profileValidation;
    private int? issueCount;

    internal object Status()
    {
        lock (gate)
        {
            double? age = capturedAt.HasValue ? (DateTimeOffset.UtcNow - capturedAt.Value).TotalMilliseconds : null;
            return new { source = "independent-memory-reader", state, error, synthetic,
                snapshots, sequence, clients = clients.Count, capturedAt, ageMs = age,
                fresh = latest != null && age <= Math.Max(2000, options.Interval * 10),
                rootsKnown, objectDiscoveryAvailable = false, profileValidation,
                runtimeVerified = profileValidation == "verified", issueCount,
                authenticationRequired = false, originalLibraryLoaded = false, lbParityVerified = false,
                gameRuntimeTested = false, target, recording = recording.Status() };
        }
    }
    internal void Ready(ReaderSession reader)
    {
        lock (gate)
        {
            target = reader.Identity; synthetic = reader.Synthetic; rootsKnown = reader.RootsKnown;
            profileValidation = reader.ProfileValidation; state = "ready"; error = null;
            SendStatusLocked();
        }
    }
    internal void Publish(JsonElement native)
    {
        lock (gate)
        {
            var metadata = native.GetProperty("metadata");
            issueCount = metadata.GetProperty("issueCount").GetInt32();
            state = !rootsKnown ? "waiting-for-roots" : issueCount > 0 ? "partial" : "streaming";
            capturedAt = DateTimeOffset.UtcNow; snapshots++;
            latest = Serialize("snapshot", capturedAt.Value, native.GetProperty("data"), metadata);
            BroadcastLocked(latest);
        }
    }
    internal void Failed(string code, string message)
    {
        lock (gate)
        {
            state = "error"; error = new { code, message }; latest = null; capturedAt = null;
            SendStatusLocked();
        }
    }
    internal void Stopped()
    {
        lock (gate)
        {
            state = "stopped"; latest = null; capturedAt = null;
            SendStatusLocked();
            foreach (var client in clients.Values) client.Writer.TryComplete();
        }
    }
    internal (byte[]? Json, bool Stale) Latest()
    {
        lock (gate) return (latest, capturedAt.HasValue &&
            (DateTimeOffset.UtcNow - capturedAt.Value).TotalMilliseconds > Math.Max(2000, options.Interval * 10));
    }
    private byte[] Serialize(string type, DateTimeOffset timestamp, object data, object? metadata = null) =>
        JsonSerializer.SerializeToUtf8Bytes(new { schemaVersion = 1, sequence = ++sequence, timestamp, type,
            source = "independent-memory-reader", synthetic, data, metadata }, Json);
    private void SendStatusLocked() => BroadcastLocked(Serialize("status", DateTimeOffset.UtcNow, Status()));
    private void BroadcastLocked(byte[] frame)
    {
        recording.Write(frame);
        foreach (var client in clients.Values) client.Writer.TryWrite(frame);
    }
    internal Subscription Subscribe()
    {
        lock (gate)
        {
            if (clients.Count >= 32) throw new InvalidOperationException("Client limit");
            var channel = Channel.CreateBounded<byte[]>(new BoundedChannelOptions(4) {
                FullMode = BoundedChannelFullMode.DropOldest, SingleReader = true, SingleWriter = false });
            long id = ++nextClient;
            if (latest != null) channel.Writer.TryWrite(latest);
            byte[] status = Serialize("status", DateTimeOffset.UtcNow, Status());
            recording.Write(status);
            channel.Writer.TryWrite(status);
            clients[id] = channel;
            return new Subscription(this, id, channel.Reader);
        }
    }
    private void Unsubscribe(long id)
    {
        lock (gate) if (clients.Remove(id, out var channel)) channel.Writer.TryComplete();
    }
    internal sealed class Subscription(Hub hub, long id, ChannelReader<byte[]> reader) : IDisposable
    {
        internal ChannelReader<byte[]> Reader { get; } = reader;
        public void Dispose() => hub.Unsubscribe(id);
    }
}
