using System.Runtime.InteropServices;
using FlatSharp.Attributes;
using FlatSharp.Internal;

namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

[StructLayout(LayoutKind.Explicit, Size = 32)]
[FlatBufferStruct]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_valueStruct", "0")]
public struct InhibitorKillEvent
{
	[FieldOffset(0)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "GameTime")]
	public float GameTime;

	[FieldOffset(4)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "KillerNetworkId")]
	public uint KillerNetworkId;

	[FieldOffset(8)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "InhibitorNetworkId")]
	public uint InhibitorNetworkId;

	[FieldOffset(12)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "AssisterNetworkIds(0)")]
	private uint __flatsharp__AssisterNetworkIds_0;

	[FieldOffset(16)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "AssisterNetworkIds(1)")]
	private uint __flatsharp__AssisterNetworkIds_1;

	[FieldOffset(20)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "AssisterNetworkIds(2)")]
	private uint __flatsharp__AssisterNetworkIds_2;

	[FieldOffset(24)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "AssisterNetworkIds(3)")]
	private uint __flatsharp__AssisterNetworkIds_3;

	[FieldOffset(28)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "AssisterNetworkIds(4)")]
	private uint __flatsharp__AssisterNetworkIds_4;

	public int AssisterNetworkIds_Length => 5;

	public static ref uint AssisterNetworkIds_Item(ref InhibitorKillEvent item, int index)
	{
		switch (index)
		{
		case 0:
			return ref item.__flatsharp__AssisterNetworkIds_0;
		case 1:
			return ref item.__flatsharp__AssisterNetworkIds_1;
		case 2:
			return ref item.__flatsharp__AssisterNetworkIds_2;
		case 3:
			return ref item.__flatsharp__AssisterNetworkIds_3;
		case 4:
			return ref item.__flatsharp__AssisterNetworkIds_4;
		default:
			FSThrow.IndexOutOfRange();
			goto case 0;
		}
	}
}
