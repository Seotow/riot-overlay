using System.Text;

namespace LeagueCollector;

public sealed class Recorder(CollectorOptions options, CollectorHub hub, ILogger<Recorder> logger) : BackgroundService
{
    private long written, dropped;
    private string state = "disabled";
    public object Status() => new { state, written = Interlocked.Read(ref written), dropped = Interlocked.Read(ref dropped) };
    protected override async Task ExecuteAsync(CancellationToken ct)
    {
        if (options.Record == null) return;
        Directory.CreateDirectory(Path.GetDirectoryName(options.Record)!);
        try
        {
            await using var stream = new FileStream(options.Record, FileMode.CreateNew, FileAccess.Write, FileShare.Read);
            await using var writer = new StreamWriter(stream, new UTF8Encoding(false)) { AutoFlush = true };
            using var subscription = hub.Subscribe(1024);
            long previous = 0;
            state = "recording";
            async Task Write(Frame frame)
            {
                if (previous > 0 && frame.Sequence > previous + 1) Interlocked.Add(ref dropped, frame.Sequence - previous - 1);
                previous = frame.Sequence;
                // Complete a line once begun, including during graceful shutdown.
                await writer.WriteLineAsync(Encoding.UTF8.GetString(frame.Bytes).AsMemory());
                Interlocked.Increment(ref written);
            }
            try { await foreach (var frame in subscription.Reader.ReadAllAsync(ct)) await Write(frame); }
            catch (OperationCanceledException) when (ct.IsCancellationRequested) { }
            while (subscription.Reader.TryRead(out var remaining)) await Write(remaining);
            state = "stopped";
        }
        catch (OperationCanceledException) when (ct.IsCancellationRequested) { state = "stopped"; }
        catch { state = "error"; logger.LogError("Recording failed. Check target file, free disk space and write permission."); }
    }
}
