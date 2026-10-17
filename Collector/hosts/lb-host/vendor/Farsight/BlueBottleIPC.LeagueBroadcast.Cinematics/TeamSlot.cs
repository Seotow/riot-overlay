using FlatSharp.Attributes;

namespace BlueBottleIPC.LeagueBroadcast.Cinematics;

[FlatBufferEnum(typeof(byte))]
public enum TeamSlot : byte
{
	Team1,
	Team2
}
