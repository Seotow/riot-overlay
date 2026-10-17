using FlatSharp.Attributes;

namespace BlueBottleIPC.LeagueBroadcast.Cinematics;

[FlatBufferEnum(typeof(byte))]
public enum PlayerSlot : byte
{
	Player1,
	Player2,
	Player3,
	Player4,
	Player5
}
