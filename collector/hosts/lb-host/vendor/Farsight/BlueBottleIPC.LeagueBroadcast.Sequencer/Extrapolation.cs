using FlatSharp.Attributes;

namespace BlueBottleIPC.LeagueBroadcast.Sequencer;

[FlatBufferEnum(typeof(byte))]
public enum Extrapolation : byte
{
	Nothing,
	Hold,
	HoldForward
}
