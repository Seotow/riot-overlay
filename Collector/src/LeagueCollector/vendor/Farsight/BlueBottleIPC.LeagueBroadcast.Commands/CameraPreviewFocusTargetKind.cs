using FlatSharp.Attributes;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferEnum(typeof(byte))]
public enum CameraPreviewFocusTargetKind : byte
{
	NetworkId,
	HeroIndex,
	WorldPoint
}
