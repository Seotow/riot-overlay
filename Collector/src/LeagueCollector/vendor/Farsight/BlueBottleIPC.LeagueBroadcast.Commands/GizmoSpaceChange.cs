using FlatSharp.Attributes;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferEnum(typeof(byte))]
public enum GizmoSpaceChange : byte
{
	Keep,
	Local,
	Global,
	Toggle
}
