using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Snapshot;
using FlatSharp.Compiler.Generated.NC12F3543BEC074B9CE9BF0B1B237ABB80FE09C4273B20663EDB60380FDCD7556;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N4EAC433854FE42EDC43F2B87B57DB0CC768F125556731E6448FFD8E1A394441C;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ FirstBloodEvent ], Count = {Count}")]
	internal sealed class GeneratedVector_4f026b85a8e31d27a5eb917c42bf4a50_Lazy<TInputBuffer> : IList<FirstBloodEvent>, ICollection<FirstBloodEvent>, IEnumerable<FirstBloodEvent>, IEnumerable, IReadOnlyList<FirstBloodEvent>, IReadOnlyCollection<FirstBloodEvent>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public FirstBloodEvent this[int index]
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

		int IFlatBufferDeserializedVector.ItemSize => 12;

		int IFlatBufferDeserializedVector.OffsetBase => offset;

		public GeneratedVector_4f026b85a8e31d27a5eb917c42bf4a50_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FirstBloodEvent SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FirstBloodEvent UnsafeParseItem(int index)
		{
			int num = offset + 12 * index;
			return FlatSharp.Compiler.Generated.NC12F3543BEC074B9CE9BF0B1B237ABB80FE09C4273B20663EDB60380FDCD7556.Helpers.Parse(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, FirstBloodEvent value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(FirstBloodEvent item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(FirstBloodEvent item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(FirstBloodEvent[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<FirstBloodEvent> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(FirstBloodEvent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, FirstBloodEvent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(FirstBloodEvent item)
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
			return offset + 12 * index;
		}
	}

	[DebuggerDisplay("Progressive [ FirstBloodEvent ], Count = {Count}")]
	internal sealed class GeneratedVector_4f026b85a8e31d27a5eb917c42bf4a50_Progressive<TInputBuffer> : IList<FirstBloodEvent>, ICollection<FirstBloodEvent>, IEnumerable<FirstBloodEvent>, IEnumerable, IReadOnlyList<FirstBloodEvent>, IReadOnlyCollection<FirstBloodEvent>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly FirstBloodEvent[]?[] items;

		public FirstBloodEvent this[int index]
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

		int IFlatBufferDeserializedVector.ItemSize => 12;

		int IFlatBufferDeserializedVector.OffsetBase => offset;

		public GeneratedVector_4f026b85a8e31d27a5eb917c42bf4a50_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new FirstBloodEvent[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FirstBloodEvent[] GetOrCreateRow(FirstBloodEvent[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private FirstBloodEvent[] CreateRow(FirstBloodEvent[]?[] items, uint rowIndex)
		{
			FirstBloodEvent[] array = (items[rowIndex] = new FirstBloodEvent[32]);
			int num = (int)(rowIndex << 5);
			int num2 = 32;
			int num3 = count - num;
			if (num3 < 32)
			{
				num2 = num3;
			}
			int num4 = offset + 12 * num;
			for (int i = 0; i < num2; i++)
			{
				array[i] = UnsafeParseFromOffset(num4);
				num4 += 12;
			}
			return array;
		}

		private FirstBloodEvent ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			FirstBloodEvent[][] array = items;
			return GetOrCreateRow(array, rowIndex)[colIndex];
		}

		private void ProgressiveSet(int index, FirstBloodEvent value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, FirstBloodEvent value)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			GetOrCreateRow(items, rowIndex)[colIndex] = value;
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FirstBloodEvent UnsafeParseItem(int index)
		{
			int num = offset + 12 * index;
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FirstBloodEvent UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.NC12F3543BEC074B9CE9BF0B1B237ABB80FE09C4273B20663EDB60380FDCD7556.Helpers.Parse(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, FirstBloodEvent value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(FirstBloodEvent item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(FirstBloodEvent item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(FirstBloodEvent[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<FirstBloodEvent> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(FirstBloodEvent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, FirstBloodEvent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(FirstBloodEvent item)
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
			return offset + 12 * index;
		}
	}

	[DebuggerDisplay("Greedy [ FirstBloodEvent ], Count = {Count}")]
	internal sealed class GeneratedVector_4f026b85a8e31d27a5eb917c42bf4a50_Greedy<TInputBuffer> : IList<FirstBloodEvent>, ICollection<FirstBloodEvent>, IEnumerable<FirstBloodEvent>, IEnumerable, IReadOnlyList<FirstBloodEvent>, IReadOnlyCollection<FirstBloodEvent> where TInputBuffer : IInputBuffer
	{
		private readonly List<FirstBloodEvent> list;

		public FirstBloodEvent this[int index]
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

		public GeneratedVector_4f026b85a8e31d27a5eb917c42bf4a50_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<FirstBloodEvent> list = (this.list = new List<FirstBloodEvent>(num));
			for (int i = 0; i < num; i++)
			{
				FirstBloodEvent item = FlatSharp.Compiler.Generated.NC12F3543BEC074B9CE9BF0B1B237ABB80FE09C4273B20663EDB60380FDCD7556.Helpers.Parse(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 12;
			}
		}

		private FirstBloodEvent GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, FirstBloodEvent value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(FirstBloodEvent item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(FirstBloodEvent item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(FirstBloodEvent[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<FirstBloodEvent> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(FirstBloodEvent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, FirstBloodEvent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(FirstBloodEvent item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ FirstBloodEvent ], Count = {Count}")]
	internal sealed class GeneratedVector_4f026b85a8e31d27a5eb917c42bf4a50_GreedyMutable<TInputBuffer> : IList<FirstBloodEvent>, ICollection<FirstBloodEvent>, IEnumerable<FirstBloodEvent>, IEnumerable, IReadOnlyList<FirstBloodEvent>, IReadOnlyCollection<FirstBloodEvent> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<FirstBloodEvent> list;

		public FirstBloodEvent this[int index]
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

		public GeneratedVector_4f026b85a8e31d27a5eb917c42bf4a50_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<FirstBloodEvent> list = (this.list = new List<FirstBloodEvent>());
			for (int i = 0; i < num; i++)
			{
				FirstBloodEvent item = FlatSharp.Compiler.Generated.NC12F3543BEC074B9CE9BF0B1B237ABB80FE09C4273B20663EDB60380FDCD7556.Helpers.Parse(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 12;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FirstBloodEvent GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, FirstBloodEvent value)
		{
			list[index] = value;
		}

		public void Add(FirstBloodEvent item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, FirstBloodEvent item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(FirstBloodEvent item)
		{
			return list.Remove(item);
		}

		public bool Contains(FirstBloodEvent item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(FirstBloodEvent item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(FirstBloodEvent[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<FirstBloodEvent> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<FirstBloodEvent> value)
	{
		return 10 + 12 * value.Count;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<FirstBloodEvent> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 12);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is FirstBloodEvent[] array)
		{
			foreach (FirstBloodEvent value2 in array)
			{
				FlatSharp.Compiler.Generated.NC12F3543BEC074B9CE9BF0B1B237ABB80FE09C4273B20663EDB60380FDCD7556.Helpers.Serialize(spanWriter, span, value2, num);
				num += 12;
			}
		}
		else if (value is List<FirstBloodEvent> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				FirstBloodEvent value3 = list[j];
				FlatSharp.Compiler.Generated.NC12F3543BEC074B9CE9BF0B1B237ABB80FE09C4273B20663EDB60380FDCD7556.Helpers.Serialize(spanWriter, span, value3, num);
				num += 12;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				FirstBloodEvent value4 = value[k];
				FlatSharp.Compiler.Generated.NC12F3543BEC074B9CE9BF0B1B237ABB80FE09C4273B20663EDB60380FDCD7556.Helpers.Serialize(spanWriter, span, value4, num);
				num += 12;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<FirstBloodEvent> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_4f026b85a8e31d27a5eb917c42bf4a50_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<FirstBloodEvent> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_4f026b85a8e31d27a5eb917c42bf4a50_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<FirstBloodEvent> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_4f026b85a8e31d27a5eb917c42bf4a50_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<FirstBloodEvent> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_4f026b85a8e31d27a5eb917c42bf4a50_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
