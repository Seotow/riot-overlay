using FlatSharp.Attributes;

namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

[FlatBufferEnum(typeof(byte))]
public enum AnimationStateStatus : byte
{
	Unavailable,
	Available,
	Unsupported,
	Invalid
}
