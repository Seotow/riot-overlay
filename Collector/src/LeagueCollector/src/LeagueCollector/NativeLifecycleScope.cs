namespace LeagueCollector;

// Own managed lifetime only. Never grants features or controls the native game.
public sealed class NativeLifecycleScope : IDisposable
{
    private readonly Action stop;
    private readonly CancellationTokenRegistration registration;
    private int requested;
    private int failed;
    public bool StopRequested => Volatile.Read(ref requested) != 0;
    public bool StopFailed => Volatile.Read(ref failed) != 0;

    public NativeLifecycleScope(CancellationToken hostToken, Action stop)
    {
        this.stop = stop;
        registration = hostToken.Register(RequestStop);
    }

    public void RequestStop()
    {
        if (Interlocked.Exchange(ref requested, 1) != 0) return;
        try { stop(); }
        catch { Volatile.Write(ref failed, 1); }
    }

    public void Dispose()
    {
        RequestStop();
        registration.Dispose();
    }
}
