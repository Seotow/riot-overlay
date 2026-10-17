using FlatSharp.Attributes;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferEnum(typeof(byte))]
public enum GizmoModeChange : byte
{
	Keep,
	Translate,
	Rotate,
	Scale
}
