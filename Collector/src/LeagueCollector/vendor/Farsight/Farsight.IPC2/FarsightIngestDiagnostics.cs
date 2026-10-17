using System;

namespace Farsight.IPC2;

public static class FarsightIngestDiagnostics
{
	public static Action<int>? MessageReceived;

	public static Action<double>? MessageDecoded;

	public static Action? StreamDesynced;
}
