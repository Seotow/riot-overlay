using FlatSharp.Attributes;

namespace BlueBottleIPC.LeagueBroadcast.Common;

[FlatBufferEnum(typeof(byte))]
public enum StrokeTipStyle : byte
{
	circle,
	rectangle,
	triangleArrow,
	roundBackwardsArrow,
	sharpBackwardsArrow
}
