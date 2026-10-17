using FlatSharp.Attributes;

namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

[FlatBufferEnum(typeof(byte))]
public enum CinematicCameraEditPhase : byte
{
	Selected,
	Begin,
	Update,
	Commit,
	Cancel
}
