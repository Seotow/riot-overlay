using FlatSharp.Attributes;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferEnum(typeof(byte))]
public enum CameraPreviewState : byte
{
	Unavailable,
	Empty,
	Queued,
	WaitingForFrames,
	Active,
	Exiting,
	Failed,
	Taking
}
