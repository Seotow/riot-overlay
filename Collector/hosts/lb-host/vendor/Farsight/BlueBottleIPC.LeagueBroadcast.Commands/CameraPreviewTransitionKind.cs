using FlatSharp.Attributes;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferEnum(typeof(byte))]
public enum CameraPreviewTransitionKind : byte
{
	None,
	Fade,
	SlideLeft,
	SlideRight,
	SlideUp,
	SlideDown,
	Automatic,
	ZoomToPip
}
