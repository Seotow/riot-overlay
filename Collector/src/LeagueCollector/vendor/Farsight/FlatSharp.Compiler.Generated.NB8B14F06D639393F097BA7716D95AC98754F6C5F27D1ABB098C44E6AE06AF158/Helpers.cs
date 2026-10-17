using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Snapshot;
using FlatSharp.Compiler.Generated.N78FE802DE932E7198C4BB57182F3340ACC586E4AB0751632B2B7C5F0142C5E1E;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.NB8B14F06D639393F097BA7716D95AC98754F6C5F27D1ABB098C44E6AE06AF158;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ DamageDealtEvent ], Count = {Count}")]
	internal sealed class GeneratedVector_471af66dd8c1eefbe017e32d3552ee7a_Lazy<TInputBuffer> : IList<DamageDealtEvent>, ICollection<DamageDealtEvent>, IEnumerable<DamageDealtEvent>, IEnumerable, IReadOnlyList<DamageDealtEvent>, IReadOnlyCollection<DamageDealtEvent>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public DamageDealtEvent this[int index]
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

		int IFlatBufferDeserializedVector.ItemSize => 28;

		int IFlatBufferDeserializedVector.OffsetBase => offset;

		public GeneratedVector_471af66dd8c1eefbe017e32d3552ee7a_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N78FE802DE932E7198C4BB57182F3340ACC586E4AB0751632B2B7C5F0142C5E1E.Helpers.structReader_3d96beba33314e73ac369302fc65fd08_Lazy<TInputBuffer> SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N78FE802DE932E7198C4BB57182F3340ACC586E4AB0751632B2B7C5F0142C5E1E.Helpers.structReader_3d96beba33314e73ac369302fc65fd08_Lazy<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + 28 * index;
			return FlatSharp.Compiler.Generated.N78FE802DE932E7198C4BB57182F3340ACC586E4AB0751632B2B7C5F0142C5E1E.Helpers.Parse_Lazy(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, DamageDealtEvent value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(DamageDealtEvent? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(DamageDealtEvent? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(DamageDealtEvent[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<DamageDealtEvent> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(DamageDealtEvent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, DamageDealtEvent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(DamageDealtEvent item)
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
			return offset + 28 * index;
		}
	}

	[DebuggerDisplay("Progressive [ DamageDealtEvent ], Count = {Count}")]
	internal sealed class GeneratedVector_471af66dd8c1eefbe017e32d3552ee7a_Progressive<TInputBuffer> : IList<DamageDealtEvent>, ICollection<DamageDealtEvent>, IEnumerable<DamageDealtEvent>, IEnumerable, IReadOnlyList<DamageDealtEvent>, IReadOnlyCollection<DamageDealtEvent>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly FlatSharp.Compiler.Generated.N78FE802DE932E7198C4BB57182F3340ACC586E4AB0751632B2B7C5F0142C5E1E.Helpers.structReader_3d96beba33314e73ac369302fc65fd08_Progressive<TInputBuffer>?[]?[] items;

		public DamageDealtEvent this[int index]
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

		int IFlatBufferDeserializedVector.ItemSize => 28;

		int IFlatBufferDeserializedVector.OffsetBase => offset;

		public GeneratedVector_471af66dd8c1eefbe017e32d3552ee7a_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new FlatSharp.Compiler.Generated.N78FE802DE932E7198C4BB57182F3340ACC586E4AB0751632B2B7C5F0142C5E1E.Helpers.structReader_3d96beba33314e73ac369302fc65fd08_Progressive<TInputBuffer>[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N78FE802DE932E7198C4BB57182F3340ACC586E4AB0751632B2B7C5F0142C5E1E.Helpers.structReader_3d96beba33314e73ac369302fc65fd08_Progressive<TInputBuffer>?[] GetOrCreateRow(FlatSharp.Compiler.Generated.N78FE802DE932E7198C4BB57182F3340ACC586E4AB0751632B2B7C5F0142C5E1E.Helpers.structReader_3d96beba33314e73ac369302fc65fd08_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private FlatSharp.Compiler.Generated.N78FE802DE932E7198C4BB57182F3340ACC586E4AB0751632B2B7C5F0142C5E1E.Helpers.structReader_3d96beba33314e73ac369302fc65fd08_Progressive<TInputBuffer>?[] CreateRow(FlatSharp.Compiler.Generated.N78FE802DE932E7198C4BB57182F3340ACC586E4AB0751632B2B7C5F0142C5E1E.Helpers.structReader_3d96beba33314e73ac369302fc65fd08_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] = new FlatSharp.Compiler.Generated.N78FE802DE932E7198C4BB57182F3340ACC586E4AB0751632B2B7C5F0142C5E1E.Helpers.structReader_3d96beba33314e73ac369302fc65fd08_Progressive<TInputBuffer>[32];
		}

		private FlatSharp.Compiler.Generated.N78FE802DE932E7198C4BB57182F3340ACC586E4AB0751632B2B7C5F0142C5E1E.Helpers.structReader_3d96beba33314e73ac369302fc65fd08_Progressive<TInputBuffer> ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			FlatSharp.Compiler.Generated.N78FE802DE932E7198C4BB57182F3340ACC586E4AB0751632B2B7C5F0142C5E1E.Helpers.structReader_3d96beba33314e73ac369302fc65fd08_Progressive<TInputBuffer>[][] array = items;
			FlatSharp.Compiler.Generated.N78FE802DE932E7198C4BB57182F3340ACC586E4AB0751632B2B7C5F0142C5E1E.Helpers.structReader_3d96beba33314e73ac369302fc65fd08_Progressive<TInputBuffer>[] orCreateRow = GetOrCreateRow(array, rowIndex);
			FlatSharp.Compiler.Generated.N78FE802DE932E7198C4BB57182F3340ACC586E4AB0751632B2B7C5F0142C5E1E.Helpers.structReader_3d96beba33314e73ac369302fc65fd08_Progressive<TInputBuffer> structReader_3d96beba33314e73ac369302fc65fd08_Progressive = orCreateRow[colIndex];
			if (structReader_3d96beba33314e73ac369302fc65fd08_Progressive == null)
			{
				structReader_3d96beba33314e73ac369302fc65fd08_Progressive = (orCreateRow[colIndex] = UnsafeParseItem(index));
			}
			return structReader_3d96beba33314e73ac369302fc65fd08_Progressive;
		}

		private void ProgressiveSet(int index, DamageDealtEvent value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, DamageDealtEvent value)
		{
			VectorUtilities.CheckIndex(index, count);
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N78FE802DE932E7198C4BB57182F3340ACC586E4AB0751632B2B7C5F0142C5E1E.Helpers.structReader_3d96beba33314e73ac369302fc65fd08_Progressive<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + 28 * index;
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N78FE802DE932E7198C4BB57182F3340ACC586E4AB0751632B2B7C5F0142C5E1E.Helpers.structReader_3d96beba33314e73ac369302fc65fd08_Progressive<TInputBuffer> UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.N78FE802DE932E7198C4BB57182F3340ACC586E4AB0751632B2B7C5F0142C5E1E.Helpers.Parse_Progressive(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, DamageDealtEvent value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(DamageDealtEvent? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(DamageDealtEvent? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(DamageDealtEvent[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<DamageDealtEvent> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(DamageDealtEvent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, DamageDealtEvent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(DamageDealtEvent item)
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
			return offset + 28 * index;
		}
	}

	[DebuggerDisplay("Greedy [ DamageDealtEvent ], Count = {Count}")]
	internal sealed class GeneratedVector_471af66dd8c1eefbe017e32d3552ee7a_Greedy<TInputBuffer> : IList<DamageDealtEvent>, ICollection<DamageDealtEvent>, IEnumerable<DamageDealtEvent>, IEnumerable, IReadOnlyList<DamageDealtEvent>, IReadOnlyCollection<DamageDealtEvent> where TInputBuffer : IInputBuffer
	{
		private readonly List<FlatSharp.Compiler.Generated.N78FE802DE932E7198C4BB57182F3340ACC586E4AB0751632B2B7C5F0142C5E1E.Helpers.structReader_3d96beba33314e73ac369302fc65fd08_Greedy<TInputBuffer>> list;

		public DamageDealtEvent this[int index]
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

		public GeneratedVector_471af66dd8c1eefbe017e32d3552ee7a_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<FlatSharp.Compiler.Generated.N78FE802DE932E7198C4BB57182F3340ACC586E4AB0751632B2B7C5F0142C5E1E.Helpers.structReader_3d96beba33314e73ac369302fc65fd08_Greedy<TInputBuffer>> list = (this.list = new List<FlatSharp.Compiler.Generated.N78FE802DE932E7198C4BB57182F3340ACC586E4AB0751632B2B7C5F0142C5E1E.Helpers.structReader_3d96beba33314e73ac369302fc65fd08_Greedy<TInputBuffer>>(num));
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.N78FE802DE932E7198C4BB57182F3340ACC586E4AB0751632B2B7C5F0142C5E1E.Helpers.structReader_3d96beba33314e73ac369302fc65fd08_Greedy<TInputBuffer> item = FlatSharp.Compiler.Generated.N78FE802DE932E7198C4BB57182F3340ACC586E4AB0751632B2B7C5F0142C5E1E.Helpers.Parse_Greedy(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 28;
			}
		}

		private FlatSharp.Compiler.Generated.N78FE802DE932E7198C4BB57182F3340ACC586E4AB0751632B2B7C5F0142C5E1E.Helpers.structReader_3d96beba33314e73ac369302fc65fd08_Greedy<TInputBuffer> GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, DamageDealtEvent value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(DamageDealtEvent? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(DamageDealtEvent? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(DamageDealtEvent[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<DamageDealtEvent> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(DamageDealtEvent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, DamageDealtEvent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(DamageDealtEvent item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ DamageDealtEvent ], Count = {Count}")]
	internal sealed class GeneratedVector_471af66dd8c1eefbe017e32d3552ee7a_GreedyMutable<TInputBuffer> : IList<DamageDealtEvent>, ICollection<DamageDealtEvent>, IEnumerable<DamageDealtEvent>, IEnumerable, IReadOnlyList<DamageDealtEvent>, IReadOnlyCollection<DamageDealtEvent> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<DamageDealtEvent> list;

		public DamageDealtEvent this[int index]
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

		public GeneratedVector_471af66dd8c1eefbe017e32d3552ee7a_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<DamageDealtEvent> list = (this.list = new List<DamageDealtEvent>());
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.N78FE802DE932E7198C4BB57182F3340ACC586E4AB0751632B2B7C5F0142C5E1E.Helpers.structReader_3d96beba33314e73ac369302fc65fd08_GreedyMutable<TInputBuffer> item = FlatSharp.Compiler.Generated.N78FE802DE932E7198C4BB57182F3340ACC586E4AB0751632B2B7C5F0142C5E1E.Helpers.Parse_GreedyMutable(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 28;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private DamageDealtEvent GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, DamageDealtEvent value)
		{
			list[index] = value;
		}

		public void Add(DamageDealtEvent item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, DamageDealtEvent item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(DamageDealtEvent item)
		{
			return list.Remove(item);
		}

		public bool Contains(DamageDealtEvent? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(DamageDealtEvent? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(DamageDealtEvent[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<DamageDealtEvent> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<DamageDealtEvent> value)
	{
		return 10 + 28 * value.Count;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<DamageDealtEvent> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 28);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is DamageDealtEvent[] array)
		{
			foreach (DamageDealtEvent damageDealtEvent in array)
			{
				SerializationHelpers.EnsureNonNull(damageDealtEvent);
				FlatSharp.Compiler.Generated.N78FE802DE932E7198C4BB57182F3340ACC586E4AB0751632B2B7C5F0142C5E1E.Helpers.Serialize(spanWriter, span, damageDealtEvent, num);
				num += 28;
			}
		}
		else if (value is List<DamageDealtEvent> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				DamageDealtEvent damageDealtEvent2 = list[j];
				SerializationHelpers.EnsureNonNull(damageDealtEvent2);
				FlatSharp.Compiler.Generated.N78FE802DE932E7198C4BB57182F3340ACC586E4AB0751632B2B7C5F0142C5E1E.Helpers.Serialize(spanWriter, span, damageDealtEvent2, num);
				num += 28;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				DamageDealtEvent damageDealtEvent3 = value[k];
				SerializationHelpers.EnsureNonNull(damageDealtEvent3);
				FlatSharp.Compiler.Generated.N78FE802DE932E7198C4BB57182F3340ACC586E4AB0751632B2B7C5F0142C5E1E.Helpers.Serialize(spanWriter, span, damageDealtEvent3, num);
				num += 28;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<DamageDealtEvent> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_471af66dd8c1eefbe017e32d3552ee7a_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<DamageDealtEvent> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_471af66dd8c1eefbe017e32d3552ee7a_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<DamageDealtEvent> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_471af66dd8c1eefbe017e32d3552ee7a_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<DamageDealtEvent> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_471af66dd8c1eefbe017e32d3552ee7a_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
