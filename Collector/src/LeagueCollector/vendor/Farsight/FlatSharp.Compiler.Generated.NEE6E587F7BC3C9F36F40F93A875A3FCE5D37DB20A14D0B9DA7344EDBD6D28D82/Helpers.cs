using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Sequencer;
using FlatSharp.Compiler.Generated.N31FE0F0224F92B231F88614AD0F8236954E9CF3F3B13D02C15B3B9AF2BAACA5C;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.NEE6E587F7BC3C9F36F40F93A875A3FCE5D37DB20A14D0B9DA7344EDBD6D28D82;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ SeqProperty ], Count = {Count}")]
	internal sealed class GeneratedVector_fc839ce22e641cdc5c912262762feb6c_Lazy<TInputBuffer> : IList<SeqProperty>, ICollection<SeqProperty>, IEnumerable<SeqProperty>, IEnumerable, IReadOnlyList<SeqProperty>, IReadOnlyCollection<SeqProperty>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public SeqProperty this[int index]
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

		int IFlatBufferDeserializedVector.ItemSize => 2;

		int IFlatBufferDeserializedVector.OffsetBase => offset;

		public GeneratedVector_fc839ce22e641cdc5c912262762feb6c_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private SeqProperty SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private SeqProperty UnsafeParseItem(int index)
		{
			int num = offset + (index << 1);
			return FlatSharp.Compiler.Generated.N31FE0F0224F92B231F88614AD0F8236954E9CF3F3B13D02C15B3B9AF2BAACA5C.Helpers.Parse(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, SeqProperty value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(SeqProperty item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(SeqProperty item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(SeqProperty[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<SeqProperty> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(SeqProperty item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, SeqProperty item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(SeqProperty item)
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
			return offset + (index << 1);
		}
	}

	[DebuggerDisplay("Progressive [ SeqProperty ], Count = {Count}")]
	internal sealed class GeneratedVector_fc839ce22e641cdc5c912262762feb6c_Progressive<TInputBuffer> : IList<SeqProperty>, ICollection<SeqProperty>, IEnumerable<SeqProperty>, IEnumerable, IReadOnlyList<SeqProperty>, IReadOnlyCollection<SeqProperty>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly SeqProperty[]?[] items;

		public SeqProperty this[int index]
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

		int IFlatBufferDeserializedVector.ItemSize => 2;

		int IFlatBufferDeserializedVector.OffsetBase => offset;

		public GeneratedVector_fc839ce22e641cdc5c912262762feb6c_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new SeqProperty[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private SeqProperty[] GetOrCreateRow(SeqProperty[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private SeqProperty[] CreateRow(SeqProperty[]?[] items, uint rowIndex)
		{
			SeqProperty[] array = (items[rowIndex] = new SeqProperty[32]);
			int num = (int)(rowIndex << 5);
			int num2 = 32;
			int num3 = count - num;
			if (num3 < 32)
			{
				num2 = num3;
			}
			int num4 = offset + (num << 1);
			for (int i = 0; i < num2; i++)
			{
				array[i] = UnsafeParseFromOffset(num4);
				num4 += 2;
			}
			return array;
		}

		private SeqProperty ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			SeqProperty[][] array = items;
			return GetOrCreateRow(array, rowIndex)[colIndex];
		}

		private void ProgressiveSet(int index, SeqProperty value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, SeqProperty value)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			GetOrCreateRow(items, rowIndex)[colIndex] = value;
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private SeqProperty UnsafeParseItem(int index)
		{
			int num = offset + (index << 1);
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private SeqProperty UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.N31FE0F0224F92B231F88614AD0F8236954E9CF3F3B13D02C15B3B9AF2BAACA5C.Helpers.Parse(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, SeqProperty value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(SeqProperty item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(SeqProperty item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(SeqProperty[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<SeqProperty> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(SeqProperty item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, SeqProperty item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(SeqProperty item)
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
			return offset + (index << 1);
		}
	}

	[DebuggerDisplay("Greedy [ SeqProperty ], Count = {Count}")]
	internal sealed class GeneratedVector_fc839ce22e641cdc5c912262762feb6c_Greedy<TInputBuffer> : IList<SeqProperty>, ICollection<SeqProperty>, IEnumerable<SeqProperty>, IEnumerable, IReadOnlyList<SeqProperty>, IReadOnlyCollection<SeqProperty> where TInputBuffer : IInputBuffer
	{
		private readonly List<SeqProperty> list;

		public SeqProperty this[int index]
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

		public GeneratedVector_fc839ce22e641cdc5c912262762feb6c_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<SeqProperty> list = (this.list = new List<SeqProperty>(num));
			for (int i = 0; i < num; i++)
			{
				SeqProperty item = FlatSharp.Compiler.Generated.N31FE0F0224F92B231F88614AD0F8236954E9CF3F3B13D02C15B3B9AF2BAACA5C.Helpers.Parse(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 2;
			}
		}

		private SeqProperty GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, SeqProperty value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(SeqProperty item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(SeqProperty item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(SeqProperty[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<SeqProperty> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(SeqProperty item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, SeqProperty item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(SeqProperty item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ SeqProperty ], Count = {Count}")]
	internal sealed class GeneratedVector_fc839ce22e641cdc5c912262762feb6c_GreedyMutable<TInputBuffer> : IList<SeqProperty>, ICollection<SeqProperty>, IEnumerable<SeqProperty>, IEnumerable, IReadOnlyList<SeqProperty>, IReadOnlyCollection<SeqProperty> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<SeqProperty> list;

		public SeqProperty this[int index]
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

		public GeneratedVector_fc839ce22e641cdc5c912262762feb6c_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<SeqProperty> list = (this.list = new List<SeqProperty>());
			for (int i = 0; i < num; i++)
			{
				SeqProperty item = FlatSharp.Compiler.Generated.N31FE0F0224F92B231F88614AD0F8236954E9CF3F3B13D02C15B3B9AF2BAACA5C.Helpers.Parse(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 2;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private SeqProperty GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, SeqProperty value)
		{
			list[index] = value;
		}

		public void Add(SeqProperty item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, SeqProperty item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(SeqProperty item)
		{
			return list.Remove(item);
		}

		public bool Contains(SeqProperty item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(SeqProperty item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(SeqProperty[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<SeqProperty> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<SeqProperty> value)
	{
		return 8 + 2 * value.Count;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<SeqProperty> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(2, count, 2);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is SeqProperty[] array)
		{
			foreach (SeqProperty value2 in array)
			{
				FlatSharp.Compiler.Generated.N31FE0F0224F92B231F88614AD0F8236954E9CF3F3B13D02C15B3B9AF2BAACA5C.Helpers.Serialize(spanWriter, span, value2, num);
				num += 2;
			}
		}
		else if (value is List<SeqProperty> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				SeqProperty value3 = list[j];
				FlatSharp.Compiler.Generated.N31FE0F0224F92B231F88614AD0F8236954E9CF3F3B13D02C15B3B9AF2BAACA5C.Helpers.Serialize(spanWriter, span, value3, num);
				num += 2;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				SeqProperty value4 = value[k];
				FlatSharp.Compiler.Generated.N31FE0F0224F92B231F88614AD0F8236954E9CF3F3B13D02C15B3B9AF2BAACA5C.Helpers.Serialize(spanWriter, span, value4, num);
				num += 2;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<SeqProperty> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_fc839ce22e641cdc5c912262762feb6c_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<SeqProperty> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_fc839ce22e641cdc5c912262762feb6c_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<SeqProperty> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_fc839ce22e641cdc5c912262762feb6c_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<SeqProperty> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_fc839ce22e641cdc5c912262762feb6c_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
