using FlatSharp.Attributes;

namespace BlueBottleIPC.LeagueBroadcast.Common;

[FlatBufferEnum(typeof(byte))]
public enum StrokeLineStyle : byte
{
	solid,
	dashed
}
