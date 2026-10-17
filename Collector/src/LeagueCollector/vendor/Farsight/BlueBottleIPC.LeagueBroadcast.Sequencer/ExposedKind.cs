using FlatSharp.Attributes;

namespace BlueBottleIPC.LeagueBroadcast.Sequencer;

[FlatBufferEnum(typeof(byte))]
public enum ExposedKind : byte
{
	ClipDuration,
	Channel,
	Choice
}
