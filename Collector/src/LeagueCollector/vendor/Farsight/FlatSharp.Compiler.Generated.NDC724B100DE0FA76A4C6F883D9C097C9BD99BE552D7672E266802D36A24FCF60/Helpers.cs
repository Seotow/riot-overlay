using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Commands;
using FlatSharp.Compiler.Generated.N14E6378D82E4E1AC1C18FC209E9E2B6D5C5401FC11110FF287DDE267F8DF4A37;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.NDC724B100DE0FA76A4C6F883D9C097C9BD99BE552D7672E266802D36A24FCF60;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ CameraPathKeyframe ], Count = {Count}")]
	internal sealed class GeneratedVector_c2a905918cf9c9510922e04b90754363_Lazy<TInputBuffer> : IList<CameraPathKeyframe>, ICollection<CameraPathKeyframe>, IEnumerable<CameraPathKeyframe>, IEnumerable, IReadOnlyList<CameraPathKeyframe>, IReadOnlyCollection<CameraPathKeyframe>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public CameraPathKeyframe this[int index]
		{
			get
			{
				return SafeParseItem(index);
			}
			set
			{
				VectorUtilities.CheckIndex(index, count);
				UnsafeWriteThrough(index, value);
			}
		}

		public int Count => count;

		public FlatBufferDeserializationOption DeserializationOption => FlatBufferDeserializationOption.Lazy;

		public bool IsReadOnly => true;

		IInputBuffer IFlatBufferDeserializedVector.InputBuffer => buffer;

		int IFlatBufferDeserializedVector.ItemSize => 16;

		int IFlatBufferDeserializedVector.OffsetBase => offset;

		public GeneratedVector_c2a905918cf9c9510922e04b90754363_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private CameraPathKeyframe SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private CameraPathKeyframe UnsafeParseItem(int index)
		{
			int num = offset + (index << 4);
			return FlatSharp.Compiler.Generated.N14E6378D82E4E1AC1C18FC209E9E2B6D5C5401FC11110FF287DDE267F8DF4A37.Helpers.Parse(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, CameraPathKeyframe value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(CameraPathKeyframe item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(CameraPathKeyframe item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(CameraPathKeyframe[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<CameraPathKeyframe> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(CameraPathKeyframe item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, CameraPathKeyframe item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(CameraPathKeyframe item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}

		object IFlatBufferDeserializedVector.ItemAt(int index)
		{
			return SafeParseItem(index);
		}

		int IFlatBufferDeserializedVector.OffsetOf(int index)
		{
			VectorUtilities.CheckIndex(index, Count);
			return offset + (index << 4);
		}
	}

	[DebuggerDisplay("Progressive [ CameraPathKeyframe ], Count = {Count}")]
	internal sealed class GeneratedVector_c2a905918cf9c9510922e04b90754363_Progressive<TInputBuffer> : IList<CameraPathKeyframe>, ICollection<CameraPathKeyframe>, IEnumerable<CameraPathKeyframe>, IEnumerable, IReadOnlyList<CameraPathKeyframe>, IReadOnlyCollection<CameraPathKeyframe>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly CameraPathKeyframe[]?[] items;

		public CameraPathKeyframe this[int index]
		{
			get
			{
				return ProgressiveGet(index);
			}
			set
			{
				ProgressiveSet(index, value);
			}
		}

		public int Count => count;

		public FlatBufferDeserializationOption DeserializationOption => FlatBufferDeserializationOption.Progressive;

		public bool IsReadOnly => true;

		IInputBuffer IFlatBufferDeserializedVector.InputBuffer => buffer;

		int IFlatBufferDeserializedVector.ItemSize => 16;

		int IFlatBufferDeserializedVector.OffsetBase => offset;

		public GeneratedVector_c2a905918cf9c9510922e04b90754363_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new CameraPathKeyframe[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private CameraPathKeyframe[] GetOrCreateRow(CameraPathKeyframe[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private CameraPathKeyframe[] CreateRow(CameraPathKeyframe[]?[] items, uint rowIndex)
		{
			CameraPathKeyframe[] array = (items[rowIndex] = new CameraPathKeyframe[32]);
			int num = (int)(rowIndex << 5);
			int num2 = 32;
			int num3 = count - num;
			if (num3 < 32)
			{
				num2 = num3;
			}
			int num4 = offset + (num << 4);
			for (int i = 0; i < num2; i++)
			{
				array[i] = UnsafeParseFromOffset(num4);
				num4 += 16;
			}
			return array;
		}

		private CameraPathKeyframe ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			CameraPathKeyframe[][] array = items;
			return GetOrCreateRow(array, rowIndex)[colIndex];
		}

		private void ProgressiveSet(int index, CameraPathKeyframe value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, CameraPathKeyframe value)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			GetOrCreateRow(items, rowIndex)[colIndex] = value;
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private CameraPathKeyframe UnsafeParseItem(int index)
		{
			int num = offset + (index << 4);
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private CameraPathKeyframe UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.N14E6378D82E4E1AC1C18FC209E9E2B6D5C5401FC11110FF287DDE267F8DF4A37.Helpers.Parse(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, CameraPathKeyframe value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(CameraPathKeyframe item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(CameraPathKeyframe item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(CameraPathKeyframe[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<CameraPathKeyframe> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(CameraPathKeyframe item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, CameraPathKeyframe item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(CameraPathKeyframe item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}

		object IFlatBufferDeserializedVector.ItemAt(int index)
		{
			return ProgressiveGet(index);
		}

		int IFlatBufferDeserializedVector.OffsetOf(int index)
		{
			VectorUtilities.CheckIndex(index, Count);
			return offset + (index << 4);
		}
	}

	[DebuggerDisplay("Greedy [ CameraPathKeyframe ], Count = {Count}")]
	internal sealed class GeneratedVector_c2a905918cf9c9510922e04b90754363_Greedy<TInputBuffer> : IList<CameraPathKeyframe>, ICollection<CameraPathKeyframe>, IEnumerable<CameraPathKeyframe>, IEnumerable, IReadOnlyList<CameraPathKeyframe>, IReadOnlyCollection<CameraPathKeyframe> where TInputBuffer : IInputBuffer
	{
		private readonly List<CameraPathKeyframe> list;

		public CameraPathKeyframe this[int index]
		{
			get
			{
				return GetItem(index);
			}
			set
			{
				SetItem(index, value);
			}
		}

		public int Count => list.Count;

		public FlatBufferDeserializationOption DeserializationOption => FlatBufferDeserializationOption.Greedy;

		public bool IsReadOnly => true;

		public GeneratedVector_c2a905918cf9c9510922e04b90754363_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<CameraPathKeyframe> list = (this.list = new List<CameraPathKeyframe>(num));
			for (int i = 0; i < num; i++)
			{
				CameraPathKeyframe item = FlatSharp.Compiler.Generated.N14E6378D82E4E1AC1C18FC209E9E2B6D5C5401FC11110FF287DDE267F8DF4A37.Helpers.Parse(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 16;
			}
		}

		private CameraPathKeyframe GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, CameraPathKeyframe value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(CameraPathKeyframe item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(CameraPathKeyframe item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(CameraPathKeyframe[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<CameraPathKeyframe> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(CameraPathKeyframe item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, CameraPathKeyframe item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(CameraPathKeyframe item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ CameraPathKeyframe ], Count = {Count}")]
	internal sealed class GeneratedVector_c2a905918cf9c9510922e04b90754363_GreedyMutable<TInputBuffer> : IList<CameraPathKeyframe>, ICollection<CameraPathKeyframe>, IEnumerable<CameraPathKeyframe>, IEnumerable, IReadOnlyList<CameraPathKeyframe>, IReadOnlyCollection<CameraPathKeyframe> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<CameraPathKeyframe> list;

		public CameraPathKeyframe this[int index]
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return GetItem(index);
			}
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
				SetItem(index, value);
			}
		}

		public int Count => list.Count;

		public bool IsReadOnly => false;

		public FlatBufferDeserializationOption DeserializationOption => FlatBufferDeserializationOption.GreedyMutable;

		public GeneratedVector_c2a905918cf9c9510922e04b90754363_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<CameraPathKeyframe> list = (this.list = new List<CameraPathKeyframe>());
			for (int i = 0; i < num; i++)
			{
				CameraPathKeyframe item = FlatSharp.Compiler.Generated.N14E6378D82E4E1AC1C18FC209E9E2B6D5C5401FC11110FF287DDE267F8DF4A37.Helpers.Parse(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 16;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private CameraPathKeyframe GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, CameraPathKeyframe value)
		{
			list[index] = value;
		}

		public void Add(CameraPathKeyframe item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, CameraPathKeyframe item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(CameraPathKeyframe item)
		{
			return list.Remove(item);
		}

		public bool Contains(CameraPathKeyframe item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(CameraPathKeyframe item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(CameraPathKeyframe[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<CameraPathKeyframe> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<CameraPathKeyframe> value)
	{
		return 10 + 16 * value.Count;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<CameraPathKeyframe> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 16);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is CameraPathKeyframe[] array)
		{
			foreach (CameraPathKeyframe value2 in array)
			{
				FlatSharp.Compiler.Generated.N14E6378D82E4E1AC1C18FC209E9E2B6D5C5401FC11110FF287DDE267F8DF4A37.Helpers.Serialize(spanWriter, span, value2, num);
				num += 16;
			}
		}
		else if (value is List<CameraPathKeyframe> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				CameraPathKeyframe value3 = list[j];
				FlatSharp.Compiler.Generated.N14E6378D82E4E1AC1C18FC209E9E2B6D5C5401FC11110FF287DDE267F8DF4A37.Helpers.Serialize(spanWriter, span, value3, num);
				num += 16;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				CameraPathKeyframe value4 = value[k];
				FlatSharp.Compiler.Generated.N14E6378D82E4E1AC1C18FC209E9E2B6D5C5401FC11110FF287DDE267F8DF4A37.Helpers.Serialize(spanWriter, span, value4, num);
				num += 16;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<CameraPathKeyframe> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_c2a905918cf9c9510922e04b90754363_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<CameraPathKeyframe> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_c2a905918cf9c9510922e04b90754363_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<CameraPathKeyframe> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_c2a905918cf9c9510922e04b90754363_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<CameraPathKeyframe> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_c2a905918cf9c9510922e04b90754363_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
