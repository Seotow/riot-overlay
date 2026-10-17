using FlatSharp.Attributes;

namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

[FlatBufferEnum(typeof(byte))]
public enum CinematicPropEditPhase : byte
{
	Selected,
	Begin,
	Update,
	Commit,
	Cancel
}
