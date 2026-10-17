using FlatSharp.Attributes;

namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

[FlatBufferEnum(typeof(byte))]
public enum AnimationBlendMode : byte
{
	Normal,
	Additive
}
