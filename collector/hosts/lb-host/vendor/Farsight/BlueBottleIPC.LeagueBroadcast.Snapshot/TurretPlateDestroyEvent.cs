using System.Runtime.InteropServices;
using FlatSharp.Attributes;

namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

[StructLayout(LayoutKind.Explicit, Size = 8)]
[FlatBufferStruct]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_valueStruct", "0")]
public struct TurretPlateDestroyEvent
{
	[FieldOffset(0)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "GameTime")]
	public float GameTime;

	[FieldOffset(4)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "TurretNetworkId")]
	public uint TurretNetworkId;
}
