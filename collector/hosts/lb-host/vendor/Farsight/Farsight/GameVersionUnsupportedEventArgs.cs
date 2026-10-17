using System;

namespace Farsight;

public class GameVersionUnsupportedEventArgs(string gameVersion) : EventArgs
{
	public string GameVersion { get; init; } = gameVersion;
}
