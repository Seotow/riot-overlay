using FlatSharp.Attributes;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferEnum(typeof(byte))]
public enum CameraPreviewOutputDestination : byte
{
	InGame
}
