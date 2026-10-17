using FlatSharp.Attributes;

namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

[FlatBufferEnum(typeof(sbyte))]
public enum AttackSuccessFlag : sbyte
{
	Invulnerable,
	None,
	Dodge,
	Critical,
	Enhanced,
	Normal,
	Miss,
	Invalid
}
