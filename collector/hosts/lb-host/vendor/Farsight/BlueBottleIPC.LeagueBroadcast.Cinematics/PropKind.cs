using FlatSharp.Attributes;

namespace BlueBottleIPC.LeagueBroadcast.Cinematics;

[FlatBufferEnum(typeof(byte))]
public enum PropKind : byte
{
	BoundText,
	LogoBillboard,
	PlayerName,
	PlayerPortrait,
	PlayerVideo,
	PlayerChampion,
	Model
}
