using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Snapshot;
using FlatSharp.Compiler.Generated.N0534D5264D665F3357E4B3C1083D9E452121D87974E869F95295454FCD8940AD;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.NEF88E318D74773E248F3B5DC745DB08D7035C1A26A00128363EF6497481C464D;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ Item ], Count = {Count}")]
	internal sealed class GeneratedVector_f44980e0e5575a0706e72a30fb08c461_Lazy<TInputBuffer> : IList<Item>, ICollection<Item>, IEnumerable<Item>, IEnumerable, IReadOnlyList<Item>, IReadOnlyCollection<Item>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public Item this[int index]
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

		int IFlatBufferDeserializedVector.ItemSize => 4;

		int IFlatBufferDeserializedVector.OffsetBase => offset;

		public GeneratedVector_f44980e0e5575a0706e72a30fb08c461_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N0534D5264D665F3357E4B3C1083D9E452121D87974E869F95295454FCD8940AD.Helpers.tableReader_a845fb84c47f441ba1abb219f5ae0816_Lazy<TInputBuffer> SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N0534D5264D665F3357E4B3C1083D9E452121D87974E869F95295454FCD8940AD.Helpers.tableReader_a845fb84c47f441ba1abb219f5ae0816_Lazy<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return FlatSharp.Compiler.Generated.N0534D5264D665F3357E4B3C1083D9E452121D87974E869F95295454FCD8940AD.Helpers.Parse_Lazy(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, Item value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(Item? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(Item? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(Item[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<Item> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(Item item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, Item item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(Item item)
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
			return offset + (index << 2);
		}
	}

	[DebuggerDisplay("Progressive [ Item ], Count = {Count}")]
	internal sealed class GeneratedVector_f44980e0e5575a0706e72a30fb08c461_Progressive<TInputBuffer> : IList<Item>, ICollection<Item>, IEnumerable<Item>, IEnumerable, IReadOnlyList<Item>, IReadOnlyCollection<Item>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly FlatSharp.Compiler.Generated.N0534D5264D665F3357E4B3C1083D9E452121D87974E869F95295454FCD8940AD.Helpers.tableReader_a845fb84c47f441ba1abb219f5ae0816_Progressive<TInputBuffer>?[]?[] items;

		public Item this[int index]
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

		int IFlatBufferDeserializedVector.ItemSize => 4;

		int IFlatBufferDeserializedVector.OffsetBase => offset;

		public GeneratedVector_f44980e0e5575a0706e72a30fb08c461_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new FlatSharp.Compiler.Generated.N0534D5264D665F3357E4B3C1083D9E452121D87974E869F95295454FCD8940AD.Helpers.tableReader_a845fb84c47f441ba1abb219f5ae0816_Progressive<TInputBuffer>[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N0534D5264D665F3357E4B3C1083D9E452121D87974E869F95295454FCD8940AD.Helpers.tableReader_a845fb84c47f441ba1abb219f5ae0816_Progressive<TInputBuffer>?[] GetOrCreateRow(FlatSharp.Compiler.Generated.N0534D5264D665F3357E4B3C1083D9E452121D87974E869F95295454FCD8940AD.Helpers.tableReader_a845fb84c47f441ba1abb219f5ae0816_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private FlatSharp.Compiler.Generated.N0534D5264D665F3357E4B3C1083D9E452121D87974E869F95295454FCD8940AD.Helpers.tableReader_a845fb84c47f441ba1abb219f5ae0816_Progressive<TInputBuffer>?[] CreateRow(FlatSharp.Compiler.Generated.N0534D5264D665F3357E4B3C1083D9E452121D87974E869F95295454FCD8940AD.Helpers.tableReader_a845fb84c47f441ba1abb219f5ae0816_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] = new FlatSharp.Compiler.Generated.N0534D5264D665F3357E4B3C1083D9E452121D87974E869F95295454FCD8940AD.Helpers.tableReader_a845fb84c47f441ba1abb219f5ae0816_Progressive<TInputBuffer>[32];
		}

		private FlatSharp.Compiler.Generated.N0534D5264D665F3357E4B3C1083D9E452121D87974E869F95295454FCD8940AD.Helpers.tableReader_a845fb84c47f441ba1abb219f5ae0816_Progressive<TInputBuffer> ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			FlatSharp.Compiler.Generated.N0534D5264D665F3357E4B3C1083D9E452121D87974E869F95295454FCD8940AD.Helpers.tableReader_a845fb84c47f441ba1abb219f5ae0816_Progressive<TInputBuffer>[][] array = items;
			FlatSharp.Compiler.Generated.N0534D5264D665F3357E4B3C1083D9E452121D87974E869F95295454FCD8940AD.Helpers.tableReader_a845fb84c47f441ba1abb219f5ae0816_Progressive<TInputBuffer>[] orCreateRow = GetOrCreateRow(array, rowIndex);
			FlatSharp.Compiler.Generated.N0534D5264D665F3357E4B3C1083D9E452121D87974E869F95295454FCD8940AD.Helpers.tableReader_a845fb84c47f441ba1abb219f5ae0816_Progressive<TInputBuffer> tableReader_a845fb84c47f441ba1abb219f5ae0816_Progressive = orCreateRow[colIndex];
			if (tableReader_a845fb84c47f441ba1abb219f5ae0816_Progressive == null)
			{
				tableReader_a845fb84c47f441ba1abb219f5ae0816_Progressive = (orCreateRow[colIndex] = UnsafeParseItem(index));
			}
			return tableReader_a845fb84c47f441ba1abb219f5ae0816_Progressive;
		}

		private void ProgressiveSet(int index, Item value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, Item value)
		{
			VectorUtilities.CheckIndex(index, count);
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N0534D5264D665F3357E4B3C1083D9E452121D87974E869F95295454FCD8940AD.Helpers.tableReader_a845fb84c47f441ba1abb219f5ae0816_Progressive<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N0534D5264D665F3357E4B3C1083D9E452121D87974E869F95295454FCD8940AD.Helpers.tableReader_a845fb84c47f441ba1abb219f5ae0816_Progressive<TInputBuffer> UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.N0534D5264D665F3357E4B3C1083D9E452121D87974E869F95295454FCD8940AD.Helpers.Parse_Progressive(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, Item value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(Item? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(Item? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(Item[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<Item> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(Item item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, Item item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(Item item)
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
			return offset + (index << 2);
		}
	}

	[DebuggerDisplay("Greedy [ Item ], Count = {Count}")]
	internal sealed class GeneratedVector_f44980e0e5575a0706e72a30fb08c461_Greedy<TInputBuffer> : IList<Item>, ICollection<Item>, IEnumerable<Item>, IEnumerable, IReadOnlyList<Item>, IReadOnlyCollection<Item> where TInputBuffer : IInputBuffer
	{
		private readonly List<FlatSharp.Compiler.Generated.N0534D5264D665F3357E4B3C1083D9E452121D87974E869F95295454FCD8940AD.Helpers.tableReader_a845fb84c47f441ba1abb219f5ae0816_Greedy<TInputBuffer>> list;

		public Item this[int index]
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

		public GeneratedVector_f44980e0e5575a0706e72a30fb08c461_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<FlatSharp.Compiler.Generated.N0534D5264D665F3357E4B3C1083D9E452121D87974E869F95295454FCD8940AD.Helpers.tableReader_a845fb84c47f441ba1abb219f5ae0816_Greedy<TInputBuffer>> list = (this.list = new List<FlatSharp.Compiler.Generated.N0534D5264D665F3357E4B3C1083D9E452121D87974E869F95295454FCD8940AD.Helpers.tableReader_a845fb84c47f441ba1abb219f5ae0816_Greedy<TInputBuffer>>(num));
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.N0534D5264D665F3357E4B3C1083D9E452121D87974E869F95295454FCD8940AD.Helpers.tableReader_a845fb84c47f441ba1abb219f5ae0816_Greedy<TInputBuffer> item = FlatSharp.Compiler.Generated.N0534D5264D665F3357E4B3C1083D9E452121D87974E869F95295454FCD8940AD.Helpers.Parse_Greedy(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		private FlatSharp.Compiler.Generated.N0534D5264D665F3357E4B3C1083D9E452121D87974E869F95295454FCD8940AD.Helpers.tableReader_a845fb84c47f441ba1abb219f5ae0816_Greedy<TInputBuffer> GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, Item value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(Item? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(Item? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(Item[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<Item> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(Item item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, Item item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(Item item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ Item ], Count = {Count}")]
	internal sealed class GeneratedVector_f44980e0e5575a0706e72a30fb08c461_GreedyMutable<TInputBuffer> : IList<Item>, ICollection<Item>, IEnumerable<Item>, IEnumerable, IReadOnlyList<Item>, IReadOnlyCollection<Item> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<Item> list;

		public Item this[int index]
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

		public GeneratedVector_f44980e0e5575a0706e72a30fb08c461_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<Item> list = (this.list = new List<Item>());
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.N0534D5264D665F3357E4B3C1083D9E452121D87974E869F95295454FCD8940AD.Helpers.tableReader_a845fb84c47f441ba1abb219f5ae0816_GreedyMutable<TInputBuffer> item = FlatSharp.Compiler.Generated.N0534D5264D665F3357E4B3C1083D9E452121D87974E869F95295454FCD8940AD.Helpers.Parse_GreedyMutable(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private Item GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, Item value)
		{
			list[index] = value;
		}

		public void Add(Item item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, Item item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(Item item)
		{
			return list.Remove(item);
		}

		public bool Contains(Item? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(Item? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(Item[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<Item> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<Item> value)
	{
		int count = value.Count;
		int num = 14;
		if (value is Item[] array)
		{
			foreach (Item item in array)
			{
				SerializationHelpers.EnsureNonNull(item);
				num += FlatSharp.Compiler.Generated.N0534D5264D665F3357E4B3C1083D9E452121D87974E869F95295454FCD8940AD.Helpers.GetMaxSize(item);
			}
		}
		else if (value is List<Item> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				Item item2 = list[j];
				SerializationHelpers.EnsureNonNull(item2);
				num += FlatSharp.Compiler.Generated.N0534D5264D665F3357E4B3C1083D9E452121D87974E869F95295454FCD8940AD.Helpers.GetMaxSize(item2);
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				Item item3 = value[k];
				SerializationHelpers.EnsureNonNull(item3);
				num += FlatSharp.Compiler.Generated.N0534D5264D665F3357E4B3C1083D9E452121D87974E869F95295454FCD8940AD.Helpers.GetMaxSize(item3);
			}
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<Item> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 4);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is Item[] array)
		{
			foreach (Item item in array)
			{
				SerializationHelpers.EnsureNonNull(item);
				FlatSharp.Compiler.Generated.N0534D5264D665F3357E4B3C1083D9E452121D87974E869F95295454FCD8940AD.Helpers.Serialize(spanWriter, span, item, num, context);
				num += 4;
			}
		}
		else if (value is List<Item> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				Item item2 = list[j];
				SerializationHelpers.EnsureNonNull(item2);
				FlatSharp.Compiler.Generated.N0534D5264D665F3357E4B3C1083D9E452121D87974E869F95295454FCD8940AD.Helpers.Serialize(spanWriter, span, item2, num, context);
				num += 4;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				Item item3 = value[k];
				SerializationHelpers.EnsureNonNull(item3);
				FlatSharp.Compiler.Generated.N0534D5264D665F3357E4B3C1083D9E452121D87974E869F95295454FCD8940AD.Helpers.Serialize(spanWriter, span, item3, num, context);
				num += 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<Item> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_f44980e0e5575a0706e72a30fb08c461_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<Item> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_f44980e0e5575a0706e72a30fb08c461_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<Item> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_f44980e0e5575a0706e72a30fb08c461_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<Item> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_f44980e0e5575a0706e72a30fb08c461_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
