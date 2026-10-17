using FlatSharp.Attributes;

namespace BlueBottleIPC.LeagueBroadcast.Entity;

[FlatBufferEnum(typeof(byte))]
public enum UnitAnchorTargetType : byte
{
	NetworkId,
	TeamPosition,
	Objective
}
