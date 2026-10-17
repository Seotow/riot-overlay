using FlatSharp.Attributes;

namespace BlueBottleIPC.LeagueBroadcast.Sequencer;

[FlatBufferEnum(typeof(byte))]
public enum ClipPhase : byte
{
	In,
	Hold,
	Out
}
