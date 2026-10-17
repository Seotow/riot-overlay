using FlatSharp.Attributes;

namespace BlueBottleIPC.LeagueBroadcast.Sequencer;

[FlatBufferEnum(typeof(byte))]
public enum CameraLookAtSource : byte
{
	None,
	Channel,
	Entity,
	UnitNetworkId,
	UnitTeamPosition,
	UnitObjective
}
