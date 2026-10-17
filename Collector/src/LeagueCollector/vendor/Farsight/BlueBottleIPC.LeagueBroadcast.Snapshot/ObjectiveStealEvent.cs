using System.Runtime.InteropServices;
using FlatSharp.Attributes;
using FlatSharp.Internal;

namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

[StructLayout(LayoutKind.Explicit, Size = 36)]
[FlatBufferStruct]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_valueStruct", "0")]
public struct ObjectiveStealEvent
{
	[FieldOffset(0)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "GameTime")]
	public float GameTime;

	[FieldOffset(4)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "KillerNetworkId")]
	public uint KillerNetworkId;

	[FieldOffset(8)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "ObjectiveNetworkId")]
	public uint ObjectiveNetworkId;

	[FieldOffset(12)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "ObjectiveType")]
	public ObjectiveType ObjectiveType;

	[FieldOffset(16)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "StolenFromNetworkIds(0)")]
	private uint __flatsharp__StolenFromNetworkIds_0;

	[FieldOffset(20)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "StolenFromNetworkIds(1)")]
	private uint __flatsharp__StolenFromNetworkIds_1;

	[FieldOffset(24)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "StolenFromNetworkIds(2)")]
	private uint __flatsharp__StolenFromNetworkIds_2;

	[FieldOffset(28)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "StolenFromNetworkIds(3)")]
	private uint __flatsharp__StolenFromNetworkIds_3;

	[FieldOffset(32)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "StolenFromNetworkIds(4)")]
	private uint __flatsharp__StolenFromNetworkIds_4;

	public int StolenFromNetworkIds_Length => 5;

	public static ref uint StolenFromNetworkIds_Item(ref ObjectiveStealEvent item, int index)
	{
		switch (index)
		{
		case 0:
			return ref item.__flatsharp__StolenFromNetworkIds_0;
		case 1:
			return ref item.__flatsharp__StolenFromNetworkIds_1;
		case 2:
			return ref item.__flatsharp__StolenFromNetworkIds_2;
		case 3:
			return ref item.__flatsharp__StolenFromNetworkIds_3;
		case 4:
			return ref item.__flatsharp__StolenFromNetworkIds_4;
		default:
			FSThrow.IndexOutOfRange();
			goto case 0;
		}
	}
}
