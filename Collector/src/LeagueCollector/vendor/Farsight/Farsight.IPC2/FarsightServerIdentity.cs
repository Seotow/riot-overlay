using System.Diagnostics;
using System.Security;

namespace Farsight.IPC2;

internal readonly record struct FarsightServerIdentity(int ProcessId, int SessionId)
{
	public void EnsureLive()
	{
		using Process process = Process.GetProcessById(ProcessId);
		if (process.HasExited || process.SessionId != SessionId)
		{
			throw new SecurityException($"League PID {ProcessId} is not live in Windows session {SessionId}");
		}
	}

	public bool IsLive()
	{
		try
		{
			EnsureLive();
			return true;
		}
		catch
		{
			return false;
		}
	}
}
