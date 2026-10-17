using FlatSharp.Attributes;

namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

[FlatBufferEnum(typeof(byte))]
public enum CinematicControllerAction : byte
{
	Capture,
	PlayheadBack,
	PlayheadForward,
	PreviewToggle,
	PreviewStop
}
