using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Internal;

namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

[FlatBufferStruct]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Snapshot.ItemStats")]
public class ItemStats
{
	public class __Data_Vector : IEnumerable<float>, IEnumerable
	{
		private readonly ItemStats item;

		public int Count => 15;

		public float this[int index]
		{
			get
			{
				ItemStats itemStats = item;
				return index switch
				{
					0 => itemStats.__flatsharp__Data_0, 
					1 => itemStats.__flatsharp__Data_1, 
					2 => itemStats.__flatsharp__Data_2, 
					3 => itemStats.__flatsharp__Data_3, 
					4 => itemStats.__flatsharp__Data_4, 
					5 => itemStats.__flatsharp__Data_5, 
					6 => itemStats.__flatsharp__Data_6, 
					7 => itemStats.__flatsharp__Data_7, 
					8 => itemStats.__flatsharp__Data_8, 
					9 => itemStats.__flatsharp__Data_9, 
					10 => itemStats.__flatsharp__Data_10, 
					11 => itemStats.__flatsharp__Data_11, 
					12 => itemStats.__flatsharp__Data_12, 
					13 => itemStats.__flatsharp__Data_13, 
					14 => itemStats.__flatsharp__Data_14, 
					_ => FSThrow.IndexOutOfRange<float>(), 
				};
			}
			set
			{
				ItemStats itemStats = item;
				switch (index)
				{
				case 0:
					itemStats.__flatsharp__Data_0 = value;
					break;
				case 1:
					itemStats.__flatsharp__Data_1 = value;
					break;
				case 2:
					itemStats.__flatsharp__Data_2 = value;
					break;
				case 3:
					itemStats.__flatsharp__Data_3 = value;
					break;
				case 4:
					itemStats.__flatsharp__Data_4 = value;
					break;
				case 5:
					itemStats.__flatsharp__Data_5 = value;
					break;
				case 6:
					itemStats.__flatsharp__Data_6 = value;
					break;
				case 7:
					itemStats.__flatsharp__Data_7 = value;
					break;
				case 8:
					itemStats.__flatsharp__Data_8 = value;
					break;
				case 9:
					itemStats.__flatsharp__Data_9 = value;
					break;
				case 10:
					itemStats.__flatsharp__Data_10 = value;
					break;
				case 11:
					itemStats.__flatsharp__Data_11 = value;
					break;
				case 12:
					itemStats.__flatsharp__Data_12 = value;
					break;
				case 13:
					itemStats.__flatsharp__Data_13 = value;
					break;
				case 14:
					itemStats.__flatsharp__Data_14 = value;
					break;
				default:
					FSThrow.IndexOutOfRange();
					break;
				}
			}
		}

		public __Data_Vector(ItemStats item)
		{
			this.item = item;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public IEnumerator<float> GetEnumerator()
		{
			ItemStats thisItem = item;
			yield return thisItem.__flatsharp__Data_0;
			yield return thisItem.__flatsharp__Data_1;
			yield return thisItem.__flatsharp__Data_2;
			yield return thisItem.__flatsharp__Data_3;
			yield return thisItem.__flatsharp__Data_4;
			yield return thisItem.__flatsharp__Data_5;
			yield return thisItem.__flatsharp__Data_6;
			yield return thisItem.__flatsharp__Data_7;
			yield return thisItem.__flatsharp__Data_8;
			yield return thisItem.__flatsharp__Data_9;
			yield return thisItem.__flatsharp__Data_10;
			yield return thisItem.__flatsharp__Data_11;
			yield return thisItem.__flatsharp__Data_12;
			yield return thisItem.__flatsharp__Data_13;
			yield return thisItem.__flatsharp__Data_14;
		}

		public void CopyFrom(ReadOnlySpan<float> source)
		{
			ItemStats itemStats = item;
			ReadOnlySpan<float> readOnlySpan = source;
			itemStats.__flatsharp__Data_14 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[14]);
			itemStats.__flatsharp__Data_13 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[13]);
			itemStats.__flatsharp__Data_12 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[12]);
			itemStats.__flatsharp__Data_11 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[11]);
			itemStats.__flatsharp__Data_10 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[10]);
			itemStats.__flatsharp__Data_9 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[9]);
			itemStats.__flatsharp__Data_8 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[8]);
			itemStats.__flatsharp__Data_7 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[7]);
			itemStats.__flatsharp__Data_6 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[6]);
			itemStats.__flatsharp__Data_5 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[5]);
			itemStats.__flatsharp__Data_4 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[4]);
			itemStats.__flatsharp__Data_3 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[3]);
			itemStats.__flatsharp__Data_2 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[2]);
			itemStats.__flatsharp__Data_1 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[1]);
			itemStats.__flatsharp__Data_0 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[0]);
		}

		public void CopyFrom(IReadOnlyList<float> source)
		{
			ItemStats itemStats = item;
			itemStats.__flatsharp__Data_14 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[14]);
			itemStats.__flatsharp__Data_13 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[13]);
			itemStats.__flatsharp__Data_12 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[12]);
			itemStats.__flatsharp__Data_11 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[11]);
			itemStats.__flatsharp__Data_10 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[10]);
			itemStats.__flatsharp__Data_9 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[9]);
			itemStats.__flatsharp__Data_8 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[8]);
			itemStats.__flatsharp__Data_7 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[7]);
			itemStats.__flatsharp__Data_6 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[6]);
			itemStats.__flatsharp__Data_5 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[5]);
			itemStats.__flatsharp__Data_4 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[4]);
			itemStats.__flatsharp__Data_3 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[3]);
			itemStats.__flatsharp__Data_2 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[2]);
			itemStats.__flatsharp__Data_1 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[1]);
			itemStats.__flatsharp__Data_0 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[0]);
		}
	}

	private __Data_Vector? __Data;

	[FlatBufferItem(0)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Data[0]")]
	protected virtual float __flatsharp__Data_0 { get; set; }

	[FlatBufferItem(1)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Data[1]")]
	protected virtual float __flatsharp__Data_1 { get; set; }

	[FlatBufferItem(2)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Data[2]")]
	protected virtual float __flatsharp__Data_2 { get; set; }

	[FlatBufferItem(3)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Data[3]")]
	protected virtual float __flatsharp__Data_3 { get; set; }

	[FlatBufferItem(4)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Data[4]")]
	protected virtual float __flatsharp__Data_4 { get; set; }

	[FlatBufferItem(5)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Data[5]")]
	protected virtual float __flatsharp__Data_5 { get; set; }

	[FlatBufferItem(6)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Data[6]")]
	protected virtual float __flatsharp__Data_6 { get; set; }

	[FlatBufferItem(7)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Data[7]")]
	protected virtual float __flatsharp__Data_7 { get; set; }

	[FlatBufferItem(8)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Data[8]")]
	protected virtual float __flatsharp__Data_8 { get; set; }

	[FlatBufferItem(9)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Data[9]")]
	protected virtual float __flatsharp__Data_9 { get; set; }

	[FlatBufferItem(10)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Data[10]")]
	protected virtual float __flatsharp__Data_10 { get; set; }

	[FlatBufferItem(11)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Data[11]")]
	protected virtual float __flatsharp__Data_11 { get; set; }

	[FlatBufferItem(12)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Data[12]")]
	protected virtual float __flatsharp__Data_12 { get; set; }

	[FlatBufferItem(13)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Data[13]")]
	protected virtual float __flatsharp__Data_13 { get; set; }

	[FlatBufferItem(14)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Data[14]")]
	protected virtual float __flatsharp__Data_14 { get; set; }

	public __Data_Vector Data => __Data ?? (__Data = new __Data_Vector(this));

	static ItemStats()
	{
	}

	public ItemStats()
	{
	}

	protected ItemStats(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public ItemStats(ItemStats source)
	{
		__flatsharp__Data_0 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Data_0);
		__flatsharp__Data_1 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Data_1);
		__flatsharp__Data_2 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Data_2);
		__flatsharp__Data_3 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Data_3);
		__flatsharp__Data_4 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Data_4);
		__flatsharp__Data_5 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Data_5);
		__flatsharp__Data_6 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Data_6);
		__flatsharp__Data_7 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Data_7);
		__flatsharp__Data_8 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Data_8);
		__flatsharp__Data_9 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Data_9);
		__flatsharp__Data_10 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Data_10);
		__flatsharp__Data_11 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Data_11);
		__flatsharp__Data_12 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Data_12);
		__flatsharp__Data_13 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Data_13);
		__flatsharp__Data_14 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Data_14);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
