using FlatSharp.Attributes;

namespace BlueBottleIPC.LeagueBroadcast.Entity;

[FlatBufferEnum(typeof(byte))]
public enum UnitAnchorObjective : byte
{
	Grubs,
	RiftHerald,
	Dragon,
	Baron
}
