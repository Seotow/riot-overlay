using FlatSharp.Attributes;

namespace BlueBottleIPC.LeagueBroadcast.Sequencer;

[FlatBufferEnum(typeof(byte))]
public enum ChannelValue : byte
{
	Scalar,
	Vec3,
	Euler3,
	Quat,
	Color,
	Bool
}
