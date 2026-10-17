using System;

namespace Farsight;

public class GameWindowOpenedEventArgs(nint windowHandle, string location, string gameVersion) : EventArgs
{
	public nint WindowHandle { get; init; } = windowHandle;

	public string GameVersion { get; init; } = gameVersion;

	public string Location { get; init; } = location;
}
