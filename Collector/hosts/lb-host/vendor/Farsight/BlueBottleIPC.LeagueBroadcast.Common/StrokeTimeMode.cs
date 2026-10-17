using FlatSharp.Attributes;

namespace BlueBottleIPC.LeagueBroadcast.Common;

[FlatBufferEnum(typeof(byte))]
public enum StrokeTimeMode : byte
{
	wallClock,
	gameTime,
	wallClockReveal
}
