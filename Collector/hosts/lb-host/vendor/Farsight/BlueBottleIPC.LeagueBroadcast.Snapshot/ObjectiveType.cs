using FlatSharp.Attributes;

namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

[FlatBufferEnum(typeof(byte))]
public enum ObjectiveType : byte
{
	Dragon,
	Baron,
	Horde,
	Atakhan,
	RiftHerald
}
