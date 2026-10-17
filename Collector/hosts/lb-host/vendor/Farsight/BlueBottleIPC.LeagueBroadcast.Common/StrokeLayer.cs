using FlatSharp.Attributes;

namespace BlueBottleIPC.LeagueBroadcast.Common;

[FlatBufferEnum(typeof(byte))]
public enum StrokeLayer : byte
{
	underEverything,
	aboveTerrain,
	belowHUD,
	aboveHealthbars,
	twoDee
}
