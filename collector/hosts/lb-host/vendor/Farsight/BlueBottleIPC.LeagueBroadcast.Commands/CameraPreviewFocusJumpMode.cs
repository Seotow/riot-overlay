using FlatSharp.Attributes;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferEnum(typeof(byte))]
public enum CameraPreviewFocusJumpMode : byte
{
	Cut,
	PreserveMovement,
	MoveThenCut
}
