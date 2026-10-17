using FlatSharp.Attributes;

namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

[FlatBufferEnum(typeof(sbyte))]
public enum DamageType : sbyte
{
	Physical,
	Magic,
	True,
	Invalid
}
