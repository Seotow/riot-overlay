using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Snapshot;
using FlatSharp.Compiler.Generated.N86CB9BC10F02EE170BED53B52E56B1E0D1786084715C200250958A36305454C7;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N177F41C23F23F4C32D4ACA72142A83975A111B7E9E46A189CD5ED3CBF0376BCD;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ InhibitorKillEvent ], Count = {Count}")]
	internal sealed class GeneratedVector_0d64d462ddfdea4ff0282475c5ec338e_Lazy<TInputBuffer> : IList<InhibitorKillEvent>, ICollection<InhibitorKillEvent>, IEnumerable<InhibitorKillEvent>, IEnumerable, IReadOnlyList<InhibitorKillEvent>, IReadOnlyCollection<InhibitorKillEvent>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public InhibitorKillEvent this[int index]
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

		int IFlatBufferDeserializedVector.ItemSize => 32;

		int IFlatBufferDeserializedVector.OffsetBase => offset;

		public GeneratedVector_0d64d462ddfdea4ff0282475c5ec338e_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private InhibitorKillEvent SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private InhibitorKillEvent UnsafeParseItem(int index)
		{
			int num = offset + (index << 5);
			return FlatSharp.Compiler.Generated.N86CB9BC10F02EE170BED53B52E56B1E0D1786084715C200250958A36305454C7.Helpers.Parse(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, InhibitorKillEvent value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(InhibitorKillEvent item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(InhibitorKillEvent item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(InhibitorKillEvent[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<InhibitorKillEvent> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(InhibitorKillEvent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, InhibitorKillEvent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(InhibitorKillEvent item)
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
			return offset + (index << 5);
		}
	}

	[DebuggerDisplay("Progressive [ InhibitorKillEvent ], Count = {Count}")]
	internal sealed class GeneratedVector_0d64d462ddfdea4ff0282475c5ec338e_Progressive<TInputBuffer> : IList<InhibitorKillEvent>, ICollection<InhibitorKillEvent>, IEnumerable<InhibitorKillEvent>, IEnumerable, IReadOnlyList<InhibitorKillEvent>, IReadOnlyCollection<InhibitorKillEvent>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly InhibitorKillEvent[]?[] items;

		public InhibitorKillEvent this[int index]
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

		int IFlatBufferDeserializedVector.ItemSize => 32;

		int IFlatBufferDeserializedVector.OffsetBase => offset;

		public GeneratedVector_0d64d462ddfdea4ff0282475c5ec338e_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new InhibitorKillEvent[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private InhibitorKillEvent[] GetOrCreateRow(InhibitorKillEvent[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private InhibitorKillEvent[] CreateRow(InhibitorKillEvent[]?[] items, uint rowIndex)
		{
			InhibitorKillEvent[] array = (items[rowIndex] = new InhibitorKillEvent[32]);
			int num = (int)(rowIndex << 5);
			int num2 = 32;
			int num3 = count - num;
			if (num3 < 32)
			{
				num2 = num3;
			}
			int num4 = offset + (num << 5);
			for (int i = 0; i < num2; i++)
			{
				array[i] = UnsafeParseFromOffset(num4);
				num4 += 32;
			}
			return array;
		}

		private InhibitorKillEvent ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			InhibitorKillEvent[][] array = items;
			return GetOrCreateRow(array, rowIndex)[colIndex];
		}

		private void ProgressiveSet(int index, InhibitorKillEvent value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, InhibitorKillEvent value)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			GetOrCreateRow(items, rowIndex)[colIndex] = value;
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private InhibitorKillEvent UnsafeParseItem(int index)
		{
			int num = offset + (index << 5);
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private InhibitorKillEvent UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.N86CB9BC10F02EE170BED53B52E56B1E0D1786084715C200250958A36305454C7.Helpers.Parse(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, InhibitorKillEvent value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(InhibitorKillEvent item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(InhibitorKillEvent item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(InhibitorKillEvent[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<InhibitorKillEvent> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(InhibitorKillEvent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, InhibitorKillEvent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(InhibitorKillEvent item)
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
			return offset + (index << 5);
		}
	}

	[DebuggerDisplay("Greedy [ InhibitorKillEvent ], Count = {Count}")]
	internal sealed class GeneratedVector_0d64d462ddfdea4ff0282475c5ec338e_Greedy<TInputBuffer> : IList<InhibitorKillEvent>, ICollection<InhibitorKillEvent>, IEnumerable<InhibitorKillEvent>, IEnumerable, IReadOnlyList<InhibitorKillEvent>, IReadOnlyCollection<InhibitorKillEvent> where TInputBuffer : IInputBuffer
	{
		private readonly List<InhibitorKillEvent> list;

		public InhibitorKillEvent this[int index]
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

		public GeneratedVector_0d64d462ddfdea4ff0282475c5ec338e_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<InhibitorKillEvent> list = (this.list = new List<InhibitorKillEvent>(num));
			for (int i = 0; i < num; i++)
			{
				InhibitorKillEvent item = FlatSharp.Compiler.Generated.N86CB9BC10F02EE170BED53B52E56B1E0D1786084715C200250958A36305454C7.Helpers.Parse(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 32;
			}
		}

		private InhibitorKillEvent GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, InhibitorKillEvent value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(InhibitorKillEvent item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(InhibitorKillEvent item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(InhibitorKillEvent[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<InhibitorKillEvent> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(InhibitorKillEvent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, InhibitorKillEvent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(InhibitorKillEvent item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ InhibitorKillEvent ], Count = {Count}")]
	internal sealed class GeneratedVector_0d64d462ddfdea4ff0282475c5ec338e_GreedyMutable<TInputBuffer> : IList<InhibitorKillEvent>, ICollection<InhibitorKillEvent>, IEnumerable<InhibitorKillEvent>, IEnumerable, IReadOnlyList<InhibitorKillEvent>, IReadOnlyCollection<InhibitorKillEvent> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<InhibitorKillEvent> list;

		public InhibitorKillEvent this[int index]
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

		public GeneratedVector_0d64d462ddfdea4ff0282475c5ec338e_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<InhibitorKillEvent> list = (this.list = new List<InhibitorKillEvent>());
			for (int i = 0; i < num; i++)
			{
				InhibitorKillEvent item = FlatSharp.Compiler.Generated.N86CB9BC10F02EE170BED53B52E56B1E0D1786084715C200250958A36305454C7.Helpers.Parse(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 32;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private InhibitorKillEvent GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, InhibitorKillEvent value)
		{
			list[index] = value;
		}

		public void Add(InhibitorKillEvent item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, InhibitorKillEvent item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(InhibitorKillEvent item)
		{
			return list.Remove(item);
		}

		public bool Contains(InhibitorKillEvent item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(InhibitorKillEvent item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(InhibitorKillEvent[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<InhibitorKillEvent> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<InhibitorKillEvent> value)
	{
		return 10 + 32 * value.Count;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<InhibitorKillEvent> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 32);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is InhibitorKillEvent[] array)
		{
			foreach (InhibitorKillEvent value2 in array)
			{
				FlatSharp.Compiler.Generated.N86CB9BC10F02EE170BED53B52E56B1E0D1786084715C200250958A36305454C7.Helpers.Serialize(spanWriter, span, value2, num);
				num += 32;
			}
		}
		else if (value is List<InhibitorKillEvent> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				InhibitorKillEvent value3 = list[j];
				FlatSharp.Compiler.Generated.N86CB9BC10F02EE170BED53B52E56B1E0D1786084715C200250958A36305454C7.Helpers.Serialize(spanWriter, span, value3, num);
				num += 32;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				InhibitorKillEvent value4 = value[k];
				FlatSharp.Compiler.Generated.N86CB9BC10F02EE170BED53B52E56B1E0D1786084715C200250958A36305454C7.Helpers.Serialize(spanWriter, span, value4, num);
				num += 32;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<InhibitorKillEvent> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_0d64d462ddfdea4ff0282475c5ec338e_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<InhibitorKillEvent> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_0d64d462ddfdea4ff0282475c5ec338e_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<InhibitorKillEvent> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_0d64d462ddfdea4ff0282475c5ec338e_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<InhibitorKillEvent> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_0d64d462ddfdea4ff0282475c5ec338e_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
