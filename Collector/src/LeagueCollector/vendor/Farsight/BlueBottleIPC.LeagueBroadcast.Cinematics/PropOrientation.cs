using FlatSharp.Attributes;

namespace BlueBottleIPC.LeagueBroadcast.Cinematics;

[FlatBufferEnum(typeof(byte))]
public enum PropOrientation : byte
{
	FaceCamera,
	WorldRotation
}
