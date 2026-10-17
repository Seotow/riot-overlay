using System.Runtime.InteropServices;
using FlatSharp.Attributes;
using FlatSharp.Internal;

namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

[StructLayout(LayoutKind.Explicit, Size = 12)]
[FlatBufferStruct]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_valueStruct", "0")]
public struct Challenge
{
	[FieldOffset(0)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Data(0)")]
	private byte __flatsharp__Data_0;

	[FieldOffset(1)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Data(1)")]
	private byte __flatsharp__Data_1;

	[FieldOffset(2)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Data(2)")]
	private byte __flatsharp__Data_2;

	[FieldOffset(3)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Data(3)")]
	private byte __flatsharp__Data_3;

	[FieldOffset(4)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Data(4)")]
	private byte __flatsharp__Data_4;

	[FieldOffset(5)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Data(5)")]
	private byte __flatsharp__Data_5;

	[FieldOffset(6)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Data(6)")]
	private byte __flatsharp__Data_6;

	[FieldOffset(7)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Data(7)")]
	private byte __flatsharp__Data_7;

	[FieldOffset(8)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Data(8)")]
	private byte __flatsharp__Data_8;

	[FieldOffset(9)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Data(9)")]
	private byte __flatsharp__Data_9;

	[FieldOffset(10)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Data(10)")]
	private byte __flatsharp__Data_10;

	[FieldOffset(11)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Data(11)")]
	private byte __flatsharp__Data_11;

	public int Data_Length => 12;

	public static ref byte Data_Item(ref Challenge item, int index)
	{
		switch (index)
		{
		case 0:
			return ref item.__flatsharp__Data_0;
		case 1:
			return ref item.__flatsharp__Data_1;
		case 2:
			return ref item.__flatsharp__Data_2;
		case 3:
			return ref item.__flatsharp__Data_3;
		case 4:
			return ref item.__flatsharp__Data_4;
		case 5:
			return ref item.__flatsharp__Data_5;
		case 6:
			return ref item.__flatsharp__Data_6;
		case 7:
			return ref item.__flatsharp__Data_7;
		case 8:
			return ref item.__flatsharp__Data_8;
		case 9:
			return ref item.__flatsharp__Data_9;
		case 10:
			return ref item.__flatsharp__Data_10;
		case 11:
			return ref item.__flatsharp__Data_11;
		default:
			FSThrow.IndexOutOfRange();
			goto case 0;
		}
	}
}
