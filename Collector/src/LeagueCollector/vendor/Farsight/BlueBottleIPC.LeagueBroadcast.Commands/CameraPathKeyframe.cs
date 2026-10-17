using System.Runtime.InteropServices;
using FlatSharp.Attributes;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[StructLayout(LayoutKind.Explicit, Size = 16)]
[FlatBufferStruct]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_valueStruct", "0")]
public struct CameraPathKeyframe
{
	[FieldOffset(0)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Time")]
	public float Time;

	[FieldOffset(4)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "X")]
	public float X;

	[FieldOffset(8)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Z")]
	public float Z;

	[FieldOffset(12)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Zoom")]
	public float Zoom;
}
