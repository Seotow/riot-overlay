using FlatSharp.Attributes;

namespace BlueBottleIPC.LeagueBroadcast.Sequencer;

[FlatBufferEnum(typeof(byte))]
public enum MarkerKind : byte
{
	Tag,
	Stop,
	LocalStop,
	Pause,
	Signal
}
