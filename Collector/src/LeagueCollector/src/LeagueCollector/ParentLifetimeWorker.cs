using System.Diagnostics;

namespace LeagueCollector;

// Query only our launcher process metadata. No game/process-memory access.
public sealed class ParentLifetimeWorker(IHostApplicationLifetime lifetime) : BackgroundService
{
    protected override async Task ExecuteAsync(CancellationToken ct)
    {
        if (!int.TryParse(Environment.GetEnvironmentVariable("COLLECTOR_PARENT_PID"), out int pid) || pid <= 0) return;
        DateTime? identity = null;
        while (!ct.IsCancellationRequested)
        {
            try
            {
                using var parent = Process.GetProcessById(pid);
                if (parent.HasExited) { lifetime.StopApplication(); return; }
                DateTime started = parent.StartTime.ToUniversalTime();
                if (identity.HasValue && identity.Value != started) { lifetime.StopApplication(); return; }
                identity = started;
            }
            catch { lifetime.StopApplication(); return; }
            try { await Task.Delay(1000, ct); } catch (OperationCanceledException) when (ct.IsCancellationRequested) { return; }
        }
    }
}
