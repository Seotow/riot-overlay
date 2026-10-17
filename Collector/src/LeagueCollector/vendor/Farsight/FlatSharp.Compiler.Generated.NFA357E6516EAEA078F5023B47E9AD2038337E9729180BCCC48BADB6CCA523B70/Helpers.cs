using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Snapshot;
using FlatSharp.Compiler.Generated.NB20284D576584D588845E9F3E3DCD4306E42AF18B01E1FCBE35493B395A72679;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.NFA357E6516EAEA078F5023B47E9AD2038337E9729180BCCC48BADB6CCA523B70;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ HeroDieEvent ], Count = {Count}")]
	internal sealed class GeneratedVector_83b16efab25950dd252b79427b6fa4ce_Lazy<TInputBuffer> : IList<HeroDieEvent>, ICollection<HeroDieEvent>, IEnumerable<HeroDieEvent>, IEnumerable, IReadOnlyList<HeroDieEvent>, IReadOnlyCollection<HeroDieEvent>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public HeroDieEvent this[int index]
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

		public GeneratedVector_83b16efab25950dd252b79427b6fa4ce_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private HeroDieEvent SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private HeroDieEvent UnsafeParseItem(int index)
		{
			int num = offset + 36 * index;
			return FlatSharp.Compiler.Generated.NB20284D576584D588845E9F3E3DCD4306E42AF18B01E1FCBE35493B395A72679.Helpers.Parse(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, HeroDieEvent value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(HeroDieEvent item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(HeroDieEvent item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(HeroDieEvent[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<HeroDieEvent> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(HeroDieEvent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, HeroDieEvent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(HeroDieEvent item)
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

	[DebuggerDisplay("Progressive [ HeroDieEvent ], Count = {Count}")]
	internal sealed class GeneratedVector_83b16efab25950dd252b79427b6fa4ce_Progressive<TInputBuffer> : IList<HeroDieEvent>, ICollection<HeroDieEvent>, IEnumerable<HeroDieEvent>, IEnumerable, IReadOnlyList<HeroDieEvent>, IReadOnlyCollection<HeroDieEvent>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly HeroDieEvent[]?[] items;

		public HeroDieEvent this[int index]
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

		public GeneratedVector_83b16efab25950dd252b79427b6fa4ce_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new HeroDieEvent[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private HeroDieEvent[] GetOrCreateRow(HeroDieEvent[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private HeroDieEvent[] CreateRow(HeroDieEvent[]?[] items, uint rowIndex)
		{
			HeroDieEvent[] array = (items[rowIndex] = new HeroDieEvent[32]);
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

		private HeroDieEvent ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			HeroDieEvent[][] array = items;
			return GetOrCreateRow(array, rowIndex)[colIndex];
		}

		private void ProgressiveSet(int index, HeroDieEvent value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, HeroDieEvent value)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			GetOrCreateRow(items, rowIndex)[colIndex] = value;
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private HeroDieEvent UnsafeParseItem(int index)
		{
			int num = offset + 36 * index;
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private HeroDieEvent UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.NB20284D576584D588845E9F3E3DCD4306E42AF18B01E1FCBE35493B395A72679.Helpers.Parse(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, HeroDieEvent value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(HeroDieEvent item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(HeroDieEvent item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(HeroDieEvent[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<HeroDieEvent> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(HeroDieEvent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, HeroDieEvent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(HeroDieEvent item)
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

	[DebuggerDisplay("Greedy [ HeroDieEvent ], Count = {Count}")]
	internal sealed class GeneratedVector_83b16efab25950dd252b79427b6fa4ce_Greedy<TInputBuffer> : IList<HeroDieEvent>, ICollection<HeroDieEvent>, IEnumerable<HeroDieEvent>, IEnumerable, IReadOnlyList<HeroDieEvent>, IReadOnlyCollection<HeroDieEvent> where TInputBuffer : IInputBuffer
	{
		private readonly List<HeroDieEvent> list;

		public HeroDieEvent this[int index]
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

		public GeneratedVector_83b16efab25950dd252b79427b6fa4ce_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<HeroDieEvent> list = (this.list = new List<HeroDieEvent>(num));
			for (int i = 0; i < num; i++)
			{
				HeroDieEvent item = FlatSharp.Compiler.Generated.NB20284D576584D588845E9F3E3DCD4306E42AF18B01E1FCBE35493B395A72679.Helpers.Parse(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 36;
			}
		}

		private HeroDieEvent GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, HeroDieEvent value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(HeroDieEvent item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(HeroDieEvent item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(HeroDieEvent[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<HeroDieEvent> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(HeroDieEvent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, HeroDieEvent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(HeroDieEvent item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ HeroDieEvent ], Count = {Count}")]
	internal sealed class GeneratedVector_83b16efab25950dd252b79427b6fa4ce_GreedyMutable<TInputBuffer> : IList<HeroDieEvent>, ICollection<HeroDieEvent>, IEnumerable<HeroDieEvent>, IEnumerable, IReadOnlyList<HeroDieEvent>, IReadOnlyCollection<HeroDieEvent> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<HeroDieEvent> list;

		public HeroDieEvent this[int index]
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

		public GeneratedVector_83b16efab25950dd252b79427b6fa4ce_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<HeroDieEvent> list = (this.list = new List<HeroDieEvent>());
			for (int i = 0; i < num; i++)
			{
				HeroDieEvent item = FlatSharp.Compiler.Generated.NB20284D576584D588845E9F3E3DCD4306E42AF18B01E1FCBE35493B395A72679.Helpers.Parse(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 36;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private HeroDieEvent GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, HeroDieEvent value)
		{
			list[index] = value;
		}

		public void Add(HeroDieEvent item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, HeroDieEvent item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(HeroDieEvent item)
		{
			return list.Remove(item);
		}

		public bool Contains(HeroDieEvent item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(HeroDieEvent item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(HeroDieEvent[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<HeroDieEvent> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<HeroDieEvent> value)
	{
		return 10 + 36 * value.Count;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<HeroDieEvent> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 36);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is HeroDieEvent[] array)
		{
			foreach (HeroDieEvent value2 in array)
			{
				FlatSharp.Compiler.Generated.NB20284D576584D588845E9F3E3DCD4306E42AF18B01E1FCBE35493B395A72679.Helpers.Serialize(spanWriter, span, value2, num);
				num += 36;
			}
		}
		else if (value is List<HeroDieEvent> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				HeroDieEvent value3 = list[j];
				FlatSharp.Compiler.Generated.NB20284D576584D588845E9F3E3DCD4306E42AF18B01E1FCBE35493B395A72679.Helpers.Serialize(spanWriter, span, value3, num);
				num += 36;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				HeroDieEvent value4 = value[k];
				FlatSharp.Compiler.Generated.NB20284D576584D588845E9F3E3DCD4306E42AF18B01E1FCBE35493B395A72679.Helpers.Serialize(spanWriter, span, value4, num);
				num += 36;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<HeroDieEvent> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_83b16efab25950dd252b79427b6fa4ce_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<HeroDieEvent> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_83b16efab25950dd252b79427b6fa4ce_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<HeroDieEvent> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_83b16efab25950dd252b79427b6fa4ce_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<HeroDieEvent> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_83b16efab25950dd252b79427b6fa4ce_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
