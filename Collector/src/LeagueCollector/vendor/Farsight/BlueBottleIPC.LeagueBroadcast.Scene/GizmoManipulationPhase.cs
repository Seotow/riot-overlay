using FlatSharp.Attributes;

namespace BlueBottleIPC.LeagueBroadcast.Scene;

[FlatBufferEnum(typeof(byte))]
public enum GizmoManipulationPhase : byte
{
	None,
	Begin,
	Update,
	Commit
}
