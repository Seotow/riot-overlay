using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;

namespace IndependentCollector;

internal sealed class Worker(Options options, Hub hub) : BackgroundService
{
    protected override async Task ExecuteAsync(CancellationToken cancellationToken)
    {
        try
        {
            using var reader = new ReaderSession(options);
            hub.Ready(reader);
            while (!cancellationToken.IsCancellationRequested)
            {
                hub.Publish(reader.Snapshot());
                await Task.Delay(options.Interval, cancellationToken);
            }
        }
        catch (OperationCanceledException) when (cancellationToken.IsCancellationRequested) { }
        catch (ReaderException error) { hub.Failed(error.Code, error.Message); }
        catch (FileNotFoundException) { hub.Failed("file_missing", "Required profile, fixture or native library file is missing"); }
        catch (DllNotFoundException) { hub.Failed("native_library_missing", "Native C ABI library could not be loaded"); }
        catch (Exception error)
        {
            // Report the exception category, not paths, profile contents or arbitrary callback text.
            hub.Failed("initialization_failed", error.GetType().Name);
        }
    }
    public override async Task StopAsync(CancellationToken token)
    {
        await base.StopAsync(token);
        hub.Stopped();
    }
}
