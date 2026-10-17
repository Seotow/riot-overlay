using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Snapshot;
using FlatSharp.Compiler.Generated.N37E5ADCC13E5491F24DF839B0F9A7D4ACA35D6DB161174A371D74D5F6364F1B6;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N9CA97BB431A89F9B8067DE122164F7D687A6ED6A36C070C6D4D6D608D04118D2;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ ObjectiveStealEvent ], Count = {Count}")]
	internal sealed class GeneratedVector_e21819a6dfe4557a801be9779893f936_Lazy<TInputBuffer> : IList<ObjectiveStealEvent>, ICollection<ObjectiveStealEvent>, IEnumerable<ObjectiveStealEvent>, IEnumerable, IReadOnlyList<ObjectiveStealEvent>, IReadOnlyCollection<ObjectiveStealEvent>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public ObjectiveStealEvent this[int index]
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

		int IFlatBufferDeserializedVector.ItemSize => 36;

		int IFlatBufferDeserializedVector.OffsetBase => offset;

		public GeneratedVector_e21819a6dfe4557a801be9779893f936_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private ObjectiveStealEvent SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private ObjectiveStealEvent UnsafeParseItem(int index)
		{
			int num = offset + 36 * index;
			return FlatSharp.Compiler.Generated.N37E5ADCC13E5491F24DF839B0F9A7D4ACA35D6DB161174A371D74D5F6364F1B6.Helpers.Parse(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, ObjectiveStealEvent value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(ObjectiveStealEvent item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(ObjectiveStealEvent item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(ObjectiveStealEvent[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<ObjectiveStealEvent> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(ObjectiveStealEvent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, ObjectiveStealEvent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(ObjectiveStealEvent item)
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
			return offset + 36 * index;
		}
	}

	[DebuggerDisplay("Progressive [ ObjectiveStealEvent ], Count = {Count}")]
	internal sealed class GeneratedVector_e21819a6dfe4557a801be9779893f936_Progressive<TInputBuffer> : IList<ObjectiveStealEvent>, ICollection<ObjectiveStealEvent>, IEnumerable<ObjectiveStealEvent>, IEnumerable, IReadOnlyList<ObjectiveStealEvent>, IReadOnlyCollection<ObjectiveStealEvent>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly ObjectiveStealEvent[]?[] items;

		public ObjectiveStealEvent this[int index]
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

		int IFlatBufferDeserializedVector.ItemSize => 36;

		int IFlatBufferDeserializedVector.OffsetBase => offset;

		public GeneratedVector_e21819a6dfe4557a801be9779893f936_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new ObjectiveStealEvent[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private ObjectiveStealEvent[] GetOrCreateRow(ObjectiveStealEvent[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private ObjectiveStealEvent[] CreateRow(ObjectiveStealEvent[]?[] items, uint rowIndex)
		{
			ObjectiveStealEvent[] array = (items[rowIndex] = new ObjectiveStealEvent[32]);
			int num = (int)(rowIndex << 5);
			int num2 = 32;
			int num3 = count - num;
			if (num3 < 32)
			{
				num2 = num3;
			}
			int num4 = offset + 36 * num;
			for (int i = 0; i < num2; i++)
			{
				array[i] = UnsafeParseFromOffset(num4);
				num4 += 36;
			}
			return array;
		}

		private ObjectiveStealEvent ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			ObjectiveStealEvent[][] array = items;
			return GetOrCreateRow(array, rowIndex)[colIndex];
		}

		private void ProgressiveSet(int index, ObjectiveStealEvent value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, ObjectiveStealEvent value)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			GetOrCreateRow(items, rowIndex)[colIndex] = value;
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private ObjectiveStealEvent UnsafeParseItem(int index)
		{
			int num = offset + 36 * index;
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private ObjectiveStealEvent UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.N37E5ADCC13E5491F24DF839B0F9A7D4ACA35D6DB161174A371D74D5F6364F1B6.Helpers.Parse(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, ObjectiveStealEvent value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(ObjectiveStealEvent item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(ObjectiveStealEvent item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(ObjectiveStealEvent[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<ObjectiveStealEvent> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(ObjectiveStealEvent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, ObjectiveStealEvent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(ObjectiveStealEvent item)
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
			return offset + 36 * index;
		}
	}

	[DebuggerDisplay("Greedy [ ObjectiveStealEvent ], Count = {Count}")]
	internal sealed class GeneratedVector_e21819a6dfe4557a801be9779893f936_Greedy<TInputBuffer> : IList<ObjectiveStealEvent>, ICollection<ObjectiveStealEvent>, IEnumerable<ObjectiveStealEvent>, IEnumerable, IReadOnlyList<ObjectiveStealEvent>, IReadOnlyCollection<ObjectiveStealEvent> where TInputBuffer : IInputBuffer
	{
		private readonly List<ObjectiveStealEvent> list;

		public ObjectiveStealEvent this[int index]
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

		public GeneratedVector_e21819a6dfe4557a801be9779893f936_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<ObjectiveStealEvent> list = (this.list = new List<ObjectiveStealEvent>(num));
			for (int i = 0; i < num; i++)
			{
				ObjectiveStealEvent item = FlatSharp.Compiler.Generated.N37E5ADCC13E5491F24DF839B0F9A7D4ACA35D6DB161174A371D74D5F6364F1B6.Helpers.Parse(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 36;
			}
		}

		private ObjectiveStealEvent GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, ObjectiveStealEvent value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(ObjectiveStealEvent item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(ObjectiveStealEvent item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(ObjectiveStealEvent[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<ObjectiveStealEvent> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(ObjectiveStealEvent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, ObjectiveStealEvent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(ObjectiveStealEvent item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ ObjectiveStealEvent ], Count = {Count}")]
	internal sealed class GeneratedVector_e21819a6dfe4557a801be9779893f936_GreedyMutable<TInputBuffer> : IList<ObjectiveStealEvent>, ICollection<ObjectiveStealEvent>, IEnumerable<ObjectiveStealEvent>, IEnumerable, IReadOnlyList<ObjectiveStealEvent>, IReadOnlyCollection<ObjectiveStealEvent> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<ObjectiveStealEvent> list;

		public ObjectiveStealEvent this[int index]
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

		public GeneratedVector_e21819a6dfe4557a801be9779893f936_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<ObjectiveStealEvent> list = (this.list = new List<ObjectiveStealEvent>());
			for (int i = 0; i < num; i++)
			{
				ObjectiveStealEvent item = FlatSharp.Compiler.Generated.N37E5ADCC13E5491F24DF839B0F9A7D4ACA35D6DB161174A371D74D5F6364F1B6.Helpers.Parse(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 36;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private ObjectiveStealEvent GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, ObjectiveStealEvent value)
		{
			list[index] = value;
		}

		public void Add(ObjectiveStealEvent item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, ObjectiveStealEvent item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(ObjectiveStealEvent item)
		{
			return list.Remove(item);
		}

		public bool Contains(ObjectiveStealEvent item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(ObjectiveStealEvent item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(ObjectiveStealEvent[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<ObjectiveStealEvent> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<ObjectiveStealEvent> value)
	{
		return 10 + 36 * value.Count;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<ObjectiveStealEvent> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 36);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is ObjectiveStealEvent[] array)
		{
			foreach (ObjectiveStealEvent value2 in array)
			{
				FlatSharp.Compiler.Generated.N37E5ADCC13E5491F24DF839B0F9A7D4ACA35D6DB161174A371D74D5F6364F1B6.Helpers.Serialize(spanWriter, span, value2, num);
				num += 36;
			}
		}
		else if (value is List<ObjectiveStealEvent> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				ObjectiveStealEvent value3 = list[j];
				FlatSharp.Compiler.Generated.N37E5ADCC13E5491F24DF839B0F9A7D4ACA35D6DB161174A371D74D5F6364F1B6.Helpers.Serialize(spanWriter, span, value3, num);
				num += 36;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				ObjectiveStealEvent value4 = value[k];
				FlatSharp.Compiler.Generated.N37E5ADCC13E5491F24DF839B0F9A7D4ACA35D6DB161174A371D74D5F6364F1B6.Helpers.Serialize(spanWriter, span, value4, num);
				num += 36;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<ObjectiveStealEvent> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_e21819a6dfe4557a801be9779893f936_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<ObjectiveStealEvent> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_e21819a6dfe4557a801be9779893f936_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<ObjectiveStealEvent> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_e21819a6dfe4557a801be9779893f936_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<ObjectiveStealEvent> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_e21819a6dfe4557a801be9779893f936_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
