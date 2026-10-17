#nullable enable
using System;
using System.Threading;

namespace Farsight;

// Managed ownership only: no game access, transport selection or feature grants.
public sealed class ManagedWatcherLifetime : IDisposable
{
    public readonly record struct WatchLease(long Generation, CancellationToken Token);

    private readonly object gate = new();
    private long generation;
    private CancellationTokenSource? current;
    private CancellationTokenRegistration hostRegistration;
    private bool disposed;
    private bool startupClaimed;

    public WatchLease Begin(CancellationToken hostToken)
    {
        lock (gate)
        {
            ObjectDisposedException.ThrowIf(disposed, this);
            if (current != null) throw new InvalidOperationException("Watcher is already active.");
            current = new CancellationTokenSource();
            startupClaimed = false;
            var lease = new WatchLease(checked(++generation), current.Token);
            // Registration can execute synchronously for an already cancelled host.
            // The lease is installed first, and callbacks invalidate only this generation.
            var registration = hostToken.Register(() => StopLease(lease));
            if (Matches(lease)) hostRegistration = registration;
            else registration.Unregister();
            return lease;
        }
    }

    public bool IsCurrent(WatchLease lease)
    {
        lock (gate) return Matches(lease);
    }

    // A validation watcher owns at most one startup attempt per generation.
    // Failure does not silently re-arm it; a deliberate new Begin is required.
    public bool TryClaimStartup(WatchLease lease)
    {
        lock (gate)
        {
            if (!Matches(lease) || startupClaimed) return false;
            startupClaimed = true;
            return true;
        }
    }

    public bool TryRun(WatchLease lease, Action action)
    {
        ArgumentNullException.ThrowIfNull(action);
        lock (gate)
        {
            if (!Matches(lease)) return false;
            action();
            return true;
        }
    }

    public CancellationTokenSource? TryCreateChild(WatchLease lease)
    {
        lock (gate)
            return Matches(lease) ? CancellationTokenSource.CreateLinkedTokenSource(lease.Token) : null;
    }

    public void Stop(Action? cleanup = null)
    {
        lock (gate)
        {
            // Cleanup still runs if the host callback invalidated the lease first.
            try { Invalidate(); }
            finally { cleanup?.Invoke(); }
        }
    }

    private bool Matches(WatchLease lease) => !disposed && current != null
        && lease.Generation == generation && lease.Token == current.Token
        && !lease.Token.IsCancellationRequested;

    private void StopLease(WatchLease lease)
    {
        lock (gate)
            if (Matches(lease)) Invalidate();
    }

    private void Invalidate()
    {
        var previous = current;
        current = null; // Reject reentrant work before cancellation callbacks execute.
        hostRegistration.Unregister(); // Never synchronously wait for a callback holding this gate.
        hostRegistration = default;
        if (previous == null) return;
        try { previous.Cancel(); }
        finally { previous.Dispose(); }
    }

    public void Dispose()
    {
        lock (gate)
        {
            disposed = true;
            Invalidate();
        }
    }
}
