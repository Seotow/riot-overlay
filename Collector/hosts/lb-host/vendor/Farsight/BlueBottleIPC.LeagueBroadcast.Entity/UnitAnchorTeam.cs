using FlatSharp.Attributes;

namespace BlueBottleIPC.LeagueBroadcast.Entity;

[FlatBufferEnum(typeof(byte))]
public enum UnitAnchorTeam : byte
{
	Blue,
	Red
}
