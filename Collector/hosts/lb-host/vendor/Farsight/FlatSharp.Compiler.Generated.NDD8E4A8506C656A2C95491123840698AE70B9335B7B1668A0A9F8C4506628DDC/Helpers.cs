using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Snapshot;
using FlatSharp.Compiler.Generated.N0D6EDD68BBB4AC14871012972D187BC6D94E27530DFB310A0AEF082BD6806735;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.NDD8E4A8506C656A2C95491123840698AE70B9335B7B1668A0A9F8C4506628DDC;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ TurretKillEvent ], Count = {Count}")]
	internal sealed class GeneratedVector_dc69ceab55c54860f153eed12f745a8b_Lazy<TInputBuffer> : IList<TurretKillEvent>, ICollection<TurretKillEvent>, IEnumerable<TurretKillEvent>, IEnumerable, IReadOnlyList<TurretKillEvent>, IReadOnlyCollection<TurretKillEvent>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public TurretKillEvent this[int index]
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

		public GeneratedVector_dc69ceab55c54860f153eed12f745a8b_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private TurretKillEvent SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private TurretKillEvent UnsafeParseItem(int index)
		{
			int num = offset + (index << 5);
			return FlatSharp.Compiler.Generated.N0D6EDD68BBB4AC14871012972D187BC6D94E27530DFB310A0AEF082BD6806735.Helpers.Parse(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, TurretKillEvent value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(TurretKillEvent item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(TurretKillEvent item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(TurretKillEvent[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<TurretKillEvent> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(TurretKillEvent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, TurretKillEvent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(TurretKillEvent item)
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

	[DebuggerDisplay("Progressive [ TurretKillEvent ], Count = {Count}")]
	internal sealed class GeneratedVector_dc69ceab55c54860f153eed12f745a8b_Progressive<TInputBuffer> : IList<TurretKillEvent>, ICollection<TurretKillEvent>, IEnumerable<TurretKillEvent>, IEnumerable, IReadOnlyList<TurretKillEvent>, IReadOnlyCollection<TurretKillEvent>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly TurretKillEvent[]?[] items;

		public TurretKillEvent this[int index]
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

		public GeneratedVector_dc69ceab55c54860f153eed12f745a8b_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new TurretKillEvent[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private TurretKillEvent[] GetOrCreateRow(TurretKillEvent[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private TurretKillEvent[] CreateRow(TurretKillEvent[]?[] items, uint rowIndex)
		{
			TurretKillEvent[] array = (items[rowIndex] = new TurretKillEvent[32]);
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

		private TurretKillEvent ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			TurretKillEvent[][] array = items;
			return GetOrCreateRow(array, rowIndex)[colIndex];
		}

		private void ProgressiveSet(int index, TurretKillEvent value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, TurretKillEvent value)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			GetOrCreateRow(items, rowIndex)[colIndex] = value;
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private TurretKillEvent UnsafeParseItem(int index)
		{
			int num = offset + (index << 5);
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private TurretKillEvent UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.N0D6EDD68BBB4AC14871012972D187BC6D94E27530DFB310A0AEF082BD6806735.Helpers.Parse(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, TurretKillEvent value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(TurretKillEvent item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(TurretKillEvent item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(TurretKillEvent[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<TurretKillEvent> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(TurretKillEvent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, TurretKillEvent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(TurretKillEvent item)
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

	[DebuggerDisplay("Greedy [ TurretKillEvent ], Count = {Count}")]
	internal sealed class GeneratedVector_dc69ceab55c54860f153eed12f745a8b_Greedy<TInputBuffer> : IList<TurretKillEvent>, ICollection<TurretKillEvent>, IEnumerable<TurretKillEvent>, IEnumerable, IReadOnlyList<TurretKillEvent>, IReadOnlyCollection<TurretKillEvent> where TInputBuffer : IInputBuffer
	{
		private readonly List<TurretKillEvent> list;

		public TurretKillEvent this[int index]
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

		public GeneratedVector_dc69ceab55c54860f153eed12f745a8b_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<TurretKillEvent> list = (this.list = new List<TurretKillEvent>(num));
			for (int i = 0; i < num; i++)
			{
				TurretKillEvent item = FlatSharp.Compiler.Generated.N0D6EDD68BBB4AC14871012972D187BC6D94E27530DFB310A0AEF082BD6806735.Helpers.Parse(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 32;
			}
		}

		private TurretKillEvent GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, TurretKillEvent value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(TurretKillEvent item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(TurretKillEvent item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(TurretKillEvent[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<TurretKillEvent> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(TurretKillEvent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, TurretKillEvent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(TurretKillEvent item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ TurretKillEvent ], Count = {Count}")]
	internal sealed class GeneratedVector_dc69ceab55c54860f153eed12f745a8b_GreedyMutable<TInputBuffer> : IList<TurretKillEvent>, ICollection<TurretKillEvent>, IEnumerable<TurretKillEvent>, IEnumerable, IReadOnlyList<TurretKillEvent>, IReadOnlyCollection<TurretKillEvent> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<TurretKillEvent> list;

		public TurretKillEvent this[int index]
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

		public GeneratedVector_dc69ceab55c54860f153eed12f745a8b_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<TurretKillEvent> list = (this.list = new List<TurretKillEvent>());
			for (int i = 0; i < num; i++)
			{
				TurretKillEvent item = FlatSharp.Compiler.Generated.N0D6EDD68BBB4AC14871012972D187BC6D94E27530DFB310A0AEF082BD6806735.Helpers.Parse(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 32;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private TurretKillEvent GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, TurretKillEvent value)
		{
			list[index] = value;
		}

		public void Add(TurretKillEvent item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, TurretKillEvent item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(TurretKillEvent item)
		{
			return list.Remove(item);
		}

		public bool Contains(TurretKillEvent item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(TurretKillEvent item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(TurretKillEvent[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<TurretKillEvent> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<TurretKillEvent> value)
	{
		return 10 + 32 * value.Count;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<TurretKillEvent> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 32);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is TurretKillEvent[] array)
		{
			foreach (TurretKillEvent value2 in array)
			{
				FlatSharp.Compiler.Generated.N0D6EDD68BBB4AC14871012972D187BC6D94E27530DFB310A0AEF082BD6806735.Helpers.Serialize(spanWriter, span, value2, num);
				num += 32;
			}
		}
		else if (value is List<TurretKillEvent> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				TurretKillEvent value3 = list[j];
				FlatSharp.Compiler.Generated.N0D6EDD68BBB4AC14871012972D187BC6D94E27530DFB310A0AEF082BD6806735.Helpers.Serialize(spanWriter, span, value3, num);
				num += 32;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				TurretKillEvent value4 = value[k];
				FlatSharp.Compiler.Generated.N0D6EDD68BBB4AC14871012972D187BC6D94E27530DFB310A0AEF082BD6806735.Helpers.Serialize(spanWriter, span, value4, num);
				num += 32;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<TurretKillEvent> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_dc69ceab55c54860f153eed12f745a8b_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<TurretKillEvent> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_dc69ceab55c54860f153eed12f745a8b_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<TurretKillEvent> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_dc69ceab55c54860f153eed12f745a8b_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<TurretKillEvent> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_dc69ceab55c54860f153eed12f745a8b_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
