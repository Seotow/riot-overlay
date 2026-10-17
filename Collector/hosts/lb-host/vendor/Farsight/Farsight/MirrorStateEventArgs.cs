using System;

namespace Farsight;

public class MirrorStateEventArgs : EventArgs
{
	public float GameTime { get; set; }

	public float PlaybackSpeed { get; set; }

	public byte GameState { get; set; }

	public ulong UtcTimestamp { get; set; }
}
