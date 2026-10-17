using System;
using System.IO;
using System.Text;

namespace IndependentCollector;

internal sealed class Recording : IDisposable
{
    private readonly object gate = new();
    private StreamWriter? writer;
    private string state;
    private string? error;
    private long written, dropped;

    internal Recording(string? path)
    {
        if (path == null) { state = "disabled"; return; }
        string fullPath = Path.GetFullPath(path);
        Directory.CreateDirectory(Path.GetDirectoryName(fullPath)!);
        // Atomic no-overwrite open. This constructor is called before the server starts.
        var file = new FileStream(fullPath, FileMode.CreateNew, FileAccess.Write, FileShare.Read);
        try { writer = new StreamWriter(file, new UTF8Encoding(false)) { AutoFlush = true }; }
        catch { file.Dispose(); throw; }
        state = "recording";
    }
    internal object Status()
    {
        lock (gate) return new { state, written, dropped, error };
    }
    internal void Write(byte[] envelope)
    {
        lock (gate)
        {
            if (state == "disabled" || state == "closed") return;
            if (writer == null) { dropped++; return; }
            try
            {
                writer.WriteLine(Encoding.UTF8.GetString(envelope));
                // AutoFlush completes the line before counting it as written.
                written++;
            }
            catch (Exception failure)
            {
                state = "error"; error = failure.GetType().Name; dropped++;
                try { writer.Dispose(); } catch (Exception) { }
                writer = null;
            }
        }
    }
    public void Dispose()
    {
        lock (gate)
        {
            if (writer != null)
            {
                try { writer.Flush(); writer.Dispose(); }
                catch (Exception failure)
                { state = "error"; error = failure.GetType().Name; }
                writer = null;
            }
            if (state == "recording") state = "closed";
        }
    }
}
