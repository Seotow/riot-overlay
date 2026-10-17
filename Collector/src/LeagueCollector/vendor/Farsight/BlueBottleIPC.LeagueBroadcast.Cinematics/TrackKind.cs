using FlatSharp.Attributes;

namespace BlueBottleIPC.LeagueBroadcast.Cinematics;

[FlatBufferEnum(typeof(byte))]
public enum TrackKind : byte
{
	Position,
	Rotation,
	Scale,
	Opacity,
	Visible
}
