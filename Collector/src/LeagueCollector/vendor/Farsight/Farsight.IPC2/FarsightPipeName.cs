using System;

namespace Farsight.IPC2;

internal static class FarsightPipeName
{
	internal static string ForProcess(int sessionId, int processId)
	{
		ArgumentOutOfRangeException.ThrowIfNegative(sessionId, "sessionId");
		ArgumentOutOfRangeException.ThrowIfNegativeOrZero(processId, "processId");
		return $"BlueBottleGG.Farsight.v2.s{sessionId}.p{processId}";
	}

	internal static string GetFullPath(int sessionId, int processId)
	{
		return "\\\\.\\pipe\\" + ForProcess(sessionId, processId);
	}
}
