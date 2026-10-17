using FlatSharp.Attributes;

namespace BlueBottleIPC.LeagueBroadcast.Common;

[FlatBufferEnum(typeof(byte))]
public enum StrokeTool : byte
{
	pen,
	eraser,
	areaBrush
}
