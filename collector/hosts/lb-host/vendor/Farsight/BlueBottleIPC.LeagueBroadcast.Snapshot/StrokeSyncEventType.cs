using FlatSharp.Attributes;

namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

[FlatBufferEnum(typeof(byte))]
public enum StrokeSyncEventType : byte
{
	Begin,
	Points,
	End,
	Cancel,
	Erase
}
