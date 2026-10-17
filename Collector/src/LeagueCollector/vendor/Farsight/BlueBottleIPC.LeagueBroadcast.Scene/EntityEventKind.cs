using FlatSharp.Attributes;

namespace BlueBottleIPC.LeagueBroadcast.Scene;

[FlatBufferEnum(typeof(byte))]
public enum EntityEventKind : byte
{
	Created,
	Updated,
	Destroyed,
	Placed
}
