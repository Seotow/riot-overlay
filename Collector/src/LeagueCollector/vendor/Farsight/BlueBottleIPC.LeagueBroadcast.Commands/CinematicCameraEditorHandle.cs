using FlatSharp.Attributes;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferEnum(typeof(byte))]
public enum CinematicCameraEditorHandle : byte
{
	Camera,
	LookAt,
	Tangent,
	IncomingTangent
}
