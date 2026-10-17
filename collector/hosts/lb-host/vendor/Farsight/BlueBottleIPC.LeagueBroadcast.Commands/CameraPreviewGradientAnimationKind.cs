using FlatSharp.Attributes;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferEnum(typeof(byte))]
public enum CameraPreviewGradientAnimationKind : byte
{
	None,
	Sweep,
	Rotate
}
