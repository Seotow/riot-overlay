using FlatSharp.Attributes;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferEnum(typeof(byte))]
public enum CameraPreviewProjectileFollowMode : byte
{
	Off,
	TopDown,
	Cinematic
}
