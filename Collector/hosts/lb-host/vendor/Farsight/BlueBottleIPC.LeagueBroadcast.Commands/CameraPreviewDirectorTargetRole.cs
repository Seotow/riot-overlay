using FlatSharp.Attributes;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferEnum(typeof(byte))]
public enum CameraPreviewDirectorTargetRole : byte
{
	Required,
	Preferred,
	Optional,
	Candidate
}
