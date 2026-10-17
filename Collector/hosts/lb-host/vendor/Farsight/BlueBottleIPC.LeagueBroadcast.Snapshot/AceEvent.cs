using System.Runtime.InteropServices;
using FlatSharp.Attributes;

namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

[StructLayout(LayoutKind.Explicit, Size = 12)]
[FlatBufferStruct]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_valueStruct", "0")]
public struct AceEvent
{
	[FieldOffset(0)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "GameTime")]
	public float GameTime;

	[FieldOffset(4)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "KillerNetworkId")]
	public uint KillerNetworkId;

	[FieldOffset(8)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "VictimNetworkId")]
	public uint VictimNetworkId;
}
