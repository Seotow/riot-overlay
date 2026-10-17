using System;
using System.IO;
using Microsoft.Extensions.Logging;

namespace Farsight.Utils;

internal sealed class InjectionLock : IDisposable
{
	private const int ERROR_SHARING_VIOLATION = 32;

	private readonly FileStream? _stream;

	public bool Acquired { get; }

	private InjectionLock(FileStream? stream, bool acquired)
	{
		_stream = stream;
		Acquired = acquired;
	}

	public static InjectionLock TryAcquire(uint gamePid, ILogger? logger = null)
	{
		string path = Path.Combine(Path.GetTempPath(), $"BlueBottleLblibInjector_{gamePid}.lock");
		try
		{
			return new InjectionLock(new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None, 1, FileOptions.DeleteOnClose), acquired: true);
		}
		catch (IOException ex) when ((ex.HResult & 0xFFFF) == 32)
		{
			logger?.LogDebug("Injection lock held by another host for game {Pid}", gamePid);
			return new InjectionLock(null, acquired: false);
		}
		catch (Exception exception)
		{
			logger?.LogWarning(exception, "Could not obtain injection lock; proceeding without cross-process guard");
			return new InjectionLock(null, acquired: true);
		}
	}

	public void Dispose()
	{
		_stream?.Dispose();
	}
}
