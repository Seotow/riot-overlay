using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Snapshot;
using FlatSharp.Compiler.Generated.N5DD0FC876683416E37757D9DB7F7D073284DC208C5B1B521F3737573C9CD05A8;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N593F046A9C640420C1B7C7DD7614E503CB383F7C64B9657072D3976CF3D6B0A4;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ TurretPlateDestroyEvent ], Count = {Count}")]
	internal sealed class GeneratedVector_ac4060252d81d4bad06ddf5ec18a0245_Lazy<TInputBuffer> : IList<TurretPlateDestroyEvent>, ICollection<TurretPlateDestroyEvent>, IEnumerable<TurretPlateDestroyEvent>, IEnumerable, IReadOnlyList<TurretPlateDestroyEvent>, IReadOnlyCollection<TurretPlateDestroyEvent>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public TurretPlateDestroyEvent this[int index]
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

		int IFlatBufferDeserializedVector.ItemSize => 8;

		int IFlatBufferDeserializedVector.OffsetBase => offset;

		public GeneratedVector_ac4060252d81d4bad06ddf5ec18a0245_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private TurretPlateDestroyEvent SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private TurretPlateDestroyEvent UnsafeParseItem(int index)
		{
			int num = offset + (index << 3);
			return FlatSharp.Compiler.Generated.N5DD0FC876683416E37757D9DB7F7D073284DC208C5B1B521F3737573C9CD05A8.Helpers.Parse(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, TurretPlateDestroyEvent value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(TurretPlateDestroyEvent item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(TurretPlateDestroyEvent item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(TurretPlateDestroyEvent[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<TurretPlateDestroyEvent> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(TurretPlateDestroyEvent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, TurretPlateDestroyEvent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(TurretPlateDestroyEvent item)
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
			return offset + (index << 3);
		}
	}

	[DebuggerDisplay("Progressive [ TurretPlateDestroyEvent ], Count = {Count}")]
	internal sealed class GeneratedVector_ac4060252d81d4bad06ddf5ec18a0245_Progressive<TInputBuffer> : IList<TurretPlateDestroyEvent>, ICollection<TurretPlateDestroyEvent>, IEnumerable<TurretPlateDestroyEvent>, IEnumerable, IReadOnlyList<TurretPlateDestroyEvent>, IReadOnlyCollection<TurretPlateDestroyEvent>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly TurretPlateDestroyEvent[]?[] items;

		public TurretPlateDestroyEvent this[int index]
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

		int IFlatBufferDeserializedVector.ItemSize => 8;

		int IFlatBufferDeserializedVector.OffsetBase => offset;

		public GeneratedVector_ac4060252d81d4bad06ddf5ec18a0245_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new TurretPlateDestroyEvent[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private TurretPlateDestroyEvent[] GetOrCreateRow(TurretPlateDestroyEvent[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private TurretPlateDestroyEvent[] CreateRow(TurretPlateDestroyEvent[]?[] items, uint rowIndex)
		{
			TurretPlateDestroyEvent[] array = (items[rowIndex] = new TurretPlateDestroyEvent[32]);
			int num = (int)(rowIndex << 5);
			int num2 = 32;
			int num3 = count - num;
			if (num3 < 32)
			{
				num2 = num3;
			}
			int num4 = offset + (num << 3);
			for (int i = 0; i < num2; i++)
			{
				array[i] = UnsafeParseFromOffset(num4);
				num4 += 8;
			}
			return array;
		}

		private TurretPlateDestroyEvent ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			TurretPlateDestroyEvent[][] array = items;
			return GetOrCreateRow(array, rowIndex)[colIndex];
		}

		private void ProgressiveSet(int index, TurretPlateDestroyEvent value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, TurretPlateDestroyEvent value)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			GetOrCreateRow(items, rowIndex)[colIndex] = value;
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private TurretPlateDestroyEvent UnsafeParseItem(int index)
		{
			int num = offset + (index << 3);
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private TurretPlateDestroyEvent UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.N5DD0FC876683416E37757D9DB7F7D073284DC208C5B1B521F3737573C9CD05A8.Helpers.Parse(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, TurretPlateDestroyEvent value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(TurretPlateDestroyEvent item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(TurretPlateDestroyEvent item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(TurretPlateDestroyEvent[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<TurretPlateDestroyEvent> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(TurretPlateDestroyEvent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, TurretPlateDestroyEvent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(TurretPlateDestroyEvent item)
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
			return offset + (index << 3);
		}
	}

	[DebuggerDisplay("Greedy [ TurretPlateDestroyEvent ], Count = {Count}")]
	internal sealed class GeneratedVector_ac4060252d81d4bad06ddf5ec18a0245_Greedy<TInputBuffer> : IList<TurretPlateDestroyEvent>, ICollection<TurretPlateDestroyEvent>, IEnumerable<TurretPlateDestroyEvent>, IEnumerable, IReadOnlyList<TurretPlateDestroyEvent>, IReadOnlyCollection<TurretPlateDestroyEvent> where TInputBuffer : IInputBuffer
	{
		private readonly List<TurretPlateDestroyEvent> list;

		public TurretPlateDestroyEvent this[int index]
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

		public GeneratedVector_ac4060252d81d4bad06ddf5ec18a0245_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<TurretPlateDestroyEvent> list = (this.list = new List<TurretPlateDestroyEvent>(num));
			for (int i = 0; i < num; i++)
			{
				TurretPlateDestroyEvent item = FlatSharp.Compiler.Generated.N5DD0FC876683416E37757D9DB7F7D073284DC208C5B1B521F3737573C9CD05A8.Helpers.Parse(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 8;
			}
		}

		private TurretPlateDestroyEvent GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, TurretPlateDestroyEvent value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(TurretPlateDestroyEvent item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(TurretPlateDestroyEvent item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(TurretPlateDestroyEvent[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<TurretPlateDestroyEvent> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(TurretPlateDestroyEvent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, TurretPlateDestroyEvent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(TurretPlateDestroyEvent item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ TurretPlateDestroyEvent ], Count = {Count}")]
	internal sealed class GeneratedVector_ac4060252d81d4bad06ddf5ec18a0245_GreedyMutable<TInputBuffer> : IList<TurretPlateDestroyEvent>, ICollection<TurretPlateDestroyEvent>, IEnumerable<TurretPlateDestroyEvent>, IEnumerable, IReadOnlyList<TurretPlateDestroyEvent>, IReadOnlyCollection<TurretPlateDestroyEvent> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<TurretPlateDestroyEvent> list;

		public TurretPlateDestroyEvent this[int index]
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

		public GeneratedVector_ac4060252d81d4bad06ddf5ec18a0245_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<TurretPlateDestroyEvent> list = (this.list = new List<TurretPlateDestroyEvent>());
			for (int i = 0; i < num; i++)
			{
				TurretPlateDestroyEvent item = FlatSharp.Compiler.Generated.N5DD0FC876683416E37757D9DB7F7D073284DC208C5B1B521F3737573C9CD05A8.Helpers.Parse(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 8;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private TurretPlateDestroyEvent GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, TurretPlateDestroyEvent value)
		{
			list[index] = value;
		}

		public void Add(TurretPlateDestroyEvent item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, TurretPlateDestroyEvent item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(TurretPlateDestroyEvent item)
		{
			return list.Remove(item);
		}

		public bool Contains(TurretPlateDestroyEvent item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(TurretPlateDestroyEvent item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(TurretPlateDestroyEvent[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<TurretPlateDestroyEvent> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<TurretPlateDestroyEvent> value)
	{
		return 10 + 8 * value.Count;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<TurretPlateDestroyEvent> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 8);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is TurretPlateDestroyEvent[] array)
		{
			foreach (TurretPlateDestroyEvent value2 in array)
			{
				FlatSharp.Compiler.Generated.N5DD0FC876683416E37757D9DB7F7D073284DC208C5B1B521F3737573C9CD05A8.Helpers.Serialize(spanWriter, span, value2, num);
				num += 8;
			}
		}
		else if (value is List<TurretPlateDestroyEvent> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				TurretPlateDestroyEvent value3 = list[j];
				FlatSharp.Compiler.Generated.N5DD0FC876683416E37757D9DB7F7D073284DC208C5B1B521F3737573C9CD05A8.Helpers.Serialize(spanWriter, span, value3, num);
				num += 8;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				TurretPlateDestroyEvent value4 = value[k];
				FlatSharp.Compiler.Generated.N5DD0FC876683416E37757D9DB7F7D073284DC208C5B1B521F3737573C9CD05A8.Helpers.Serialize(spanWriter, span, value4, num);
				num += 8;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<TurretPlateDestroyEvent> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_ac4060252d81d4bad06ddf5ec18a0245_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<TurretPlateDestroyEvent> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_ac4060252d81d4bad06ddf5ec18a0245_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<TurretPlateDestroyEvent> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_ac4060252d81d4bad06ddf5ec18a0245_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<TurretPlateDestroyEvent> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_ac4060252d81d4bad06ddf5ec18a0245_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
