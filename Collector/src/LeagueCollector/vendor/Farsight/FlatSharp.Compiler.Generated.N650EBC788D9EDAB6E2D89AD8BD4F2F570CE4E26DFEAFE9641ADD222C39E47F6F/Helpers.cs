using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Snapshot;
using FlatSharp.Compiler.Generated.N9DAD4091EE3CCAD9126BDEE22E9BAAD7A27FF868CB6B88BF0FD15EAA0D0C8E07;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N650EBC788D9EDAB6E2D89AD8BD4F2F570CE4E26DFEAFE9641ADD222C39E47F6F;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ OffsetEntry ], Count = {Count}")]
	internal sealed class GeneratedVector_4ec242904a5232ecec7d429cc7de0a3d_Lazy<TInputBuffer> : IList<OffsetEntry>, ICollection<OffsetEntry>, IEnumerable<OffsetEntry>, IEnumerable, IReadOnlyList<OffsetEntry>, IReadOnlyCollection<OffsetEntry>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public OffsetEntry this[int index]
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

		public GeneratedVector_4ec242904a5232ecec7d429cc7de0a3d_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N9DAD4091EE3CCAD9126BDEE22E9BAAD7A27FF868CB6B88BF0FD15EAA0D0C8E07.Helpers.tableReader_d4ab27b4053948bf834edec78234dd9d_Lazy<TInputBuffer> SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N9DAD4091EE3CCAD9126BDEE22E9BAAD7A27FF868CB6B88BF0FD15EAA0D0C8E07.Helpers.tableReader_d4ab27b4053948bf834edec78234dd9d_Lazy<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return FlatSharp.Compiler.Generated.N9DAD4091EE3CCAD9126BDEE22E9BAAD7A27FF868CB6B88BF0FD15EAA0D0C8E07.Helpers.Parse_Lazy(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, OffsetEntry value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(OffsetEntry? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(OffsetEntry? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(OffsetEntry[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<OffsetEntry> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(OffsetEntry item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, OffsetEntry item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(OffsetEntry item)
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

	[DebuggerDisplay("Progressive [ OffsetEntry ], Count = {Count}")]
	internal sealed class GeneratedVector_4ec242904a5232ecec7d429cc7de0a3d_Progressive<TInputBuffer> : IList<OffsetEntry>, ICollection<OffsetEntry>, IEnumerable<OffsetEntry>, IEnumerable, IReadOnlyList<OffsetEntry>, IReadOnlyCollection<OffsetEntry>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly FlatSharp.Compiler.Generated.N9DAD4091EE3CCAD9126BDEE22E9BAAD7A27FF868CB6B88BF0FD15EAA0D0C8E07.Helpers.tableReader_d4ab27b4053948bf834edec78234dd9d_Progressive<TInputBuffer>?[]?[] items;

		public OffsetEntry this[int index]
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

		public GeneratedVector_4ec242904a5232ecec7d429cc7de0a3d_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new FlatSharp.Compiler.Generated.N9DAD4091EE3CCAD9126BDEE22E9BAAD7A27FF868CB6B88BF0FD15EAA0D0C8E07.Helpers.tableReader_d4ab27b4053948bf834edec78234dd9d_Progressive<TInputBuffer>[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N9DAD4091EE3CCAD9126BDEE22E9BAAD7A27FF868CB6B88BF0FD15EAA0D0C8E07.Helpers.tableReader_d4ab27b4053948bf834edec78234dd9d_Progressive<TInputBuffer>?[] GetOrCreateRow(FlatSharp.Compiler.Generated.N9DAD4091EE3CCAD9126BDEE22E9BAAD7A27FF868CB6B88BF0FD15EAA0D0C8E07.Helpers.tableReader_d4ab27b4053948bf834edec78234dd9d_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private FlatSharp.Compiler.Generated.N9DAD4091EE3CCAD9126BDEE22E9BAAD7A27FF868CB6B88BF0FD15EAA0D0C8E07.Helpers.tableReader_d4ab27b4053948bf834edec78234dd9d_Progressive<TInputBuffer>?[] CreateRow(FlatSharp.Compiler.Generated.N9DAD4091EE3CCAD9126BDEE22E9BAAD7A27FF868CB6B88BF0FD15EAA0D0C8E07.Helpers.tableReader_d4ab27b4053948bf834edec78234dd9d_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] = new FlatSharp.Compiler.Generated.N9DAD4091EE3CCAD9126BDEE22E9BAAD7A27FF868CB6B88BF0FD15EAA0D0C8E07.Helpers.tableReader_d4ab27b4053948bf834edec78234dd9d_Progressive<TInputBuffer>[32];
		}

		private FlatSharp.Compiler.Generated.N9DAD4091EE3CCAD9126BDEE22E9BAAD7A27FF868CB6B88BF0FD15EAA0D0C8E07.Helpers.tableReader_d4ab27b4053948bf834edec78234dd9d_Progressive<TInputBuffer> ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			FlatSharp.Compiler.Generated.N9DAD4091EE3CCAD9126BDEE22E9BAAD7A27FF868CB6B88BF0FD15EAA0D0C8E07.Helpers.tableReader_d4ab27b4053948bf834edec78234dd9d_Progressive<TInputBuffer>[][] array = items;
			FlatSharp.Compiler.Generated.N9DAD4091EE3CCAD9126BDEE22E9BAAD7A27FF868CB6B88BF0FD15EAA0D0C8E07.Helpers.tableReader_d4ab27b4053948bf834edec78234dd9d_Progressive<TInputBuffer>[] orCreateRow = GetOrCreateRow(array, rowIndex);
			FlatSharp.Compiler.Generated.N9DAD4091EE3CCAD9126BDEE22E9BAAD7A27FF868CB6B88BF0FD15EAA0D0C8E07.Helpers.tableReader_d4ab27b4053948bf834edec78234dd9d_Progressive<TInputBuffer> tableReader_d4ab27b4053948bf834edec78234dd9d_Progressive = orCreateRow[colIndex];
			if (tableReader_d4ab27b4053948bf834edec78234dd9d_Progressive == null)
			{
				tableReader_d4ab27b4053948bf834edec78234dd9d_Progressive = (orCreateRow[colIndex] = UnsafeParseItem(index));
			}
			return tableReader_d4ab27b4053948bf834edec78234dd9d_Progressive;
		}

		private void ProgressiveSet(int index, OffsetEntry value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, OffsetEntry value)
		{
			VectorUtilities.CheckIndex(index, count);
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N9DAD4091EE3CCAD9126BDEE22E9BAAD7A27FF868CB6B88BF0FD15EAA0D0C8E07.Helpers.tableReader_d4ab27b4053948bf834edec78234dd9d_Progressive<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N9DAD4091EE3CCAD9126BDEE22E9BAAD7A27FF868CB6B88BF0FD15EAA0D0C8E07.Helpers.tableReader_d4ab27b4053948bf834edec78234dd9d_Progressive<TInputBuffer> UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.N9DAD4091EE3CCAD9126BDEE22E9BAAD7A27FF868CB6B88BF0FD15EAA0D0C8E07.Helpers.Parse_Progressive(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, OffsetEntry value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(OffsetEntry? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(OffsetEntry? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(OffsetEntry[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<OffsetEntry> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(OffsetEntry item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, OffsetEntry item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(OffsetEntry item)
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

	[DebuggerDisplay("Greedy [ OffsetEntry ], Count = {Count}")]
	internal sealed class GeneratedVector_4ec242904a5232ecec7d429cc7de0a3d_Greedy<TInputBuffer> : IList<OffsetEntry>, ICollection<OffsetEntry>, IEnumerable<OffsetEntry>, IEnumerable, IReadOnlyList<OffsetEntry>, IReadOnlyCollection<OffsetEntry> where TInputBuffer : IInputBuffer
	{
		private readonly List<FlatSharp.Compiler.Generated.N9DAD4091EE3CCAD9126BDEE22E9BAAD7A27FF868CB6B88BF0FD15EAA0D0C8E07.Helpers.tableReader_d4ab27b4053948bf834edec78234dd9d_Greedy<TInputBuffer>> list;

		public OffsetEntry this[int index]
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

		public GeneratedVector_4ec242904a5232ecec7d429cc7de0a3d_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<FlatSharp.Compiler.Generated.N9DAD4091EE3CCAD9126BDEE22E9BAAD7A27FF868CB6B88BF0FD15EAA0D0C8E07.Helpers.tableReader_d4ab27b4053948bf834edec78234dd9d_Greedy<TInputBuffer>> list = (this.list = new List<FlatSharp.Compiler.Generated.N9DAD4091EE3CCAD9126BDEE22E9BAAD7A27FF868CB6B88BF0FD15EAA0D0C8E07.Helpers.tableReader_d4ab27b4053948bf834edec78234dd9d_Greedy<TInputBuffer>>(num));
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.N9DAD4091EE3CCAD9126BDEE22E9BAAD7A27FF868CB6B88BF0FD15EAA0D0C8E07.Helpers.tableReader_d4ab27b4053948bf834edec78234dd9d_Greedy<TInputBuffer> item = FlatSharp.Compiler.Generated.N9DAD4091EE3CCAD9126BDEE22E9BAAD7A27FF868CB6B88BF0FD15EAA0D0C8E07.Helpers.Parse_Greedy(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		private FlatSharp.Compiler.Generated.N9DAD4091EE3CCAD9126BDEE22E9BAAD7A27FF868CB6B88BF0FD15EAA0D0C8E07.Helpers.tableReader_d4ab27b4053948bf834edec78234dd9d_Greedy<TInputBuffer> GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, OffsetEntry value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(OffsetEntry? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(OffsetEntry? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(OffsetEntry[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<OffsetEntry> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(OffsetEntry item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, OffsetEntry item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(OffsetEntry item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ OffsetEntry ], Count = {Count}")]
	internal sealed class GeneratedVector_4ec242904a5232ecec7d429cc7de0a3d_GreedyMutable<TInputBuffer> : IList<OffsetEntry>, ICollection<OffsetEntry>, IEnumerable<OffsetEntry>, IEnumerable, IReadOnlyList<OffsetEntry>, IReadOnlyCollection<OffsetEntry> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<OffsetEntry> list;

		public OffsetEntry this[int index]
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

		public GeneratedVector_4ec242904a5232ecec7d429cc7de0a3d_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<OffsetEntry> list = (this.list = new List<OffsetEntry>());
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.N9DAD4091EE3CCAD9126BDEE22E9BAAD7A27FF868CB6B88BF0FD15EAA0D0C8E07.Helpers.tableReader_d4ab27b4053948bf834edec78234dd9d_GreedyMutable<TInputBuffer> item = FlatSharp.Compiler.Generated.N9DAD4091EE3CCAD9126BDEE22E9BAAD7A27FF868CB6B88BF0FD15EAA0D0C8E07.Helpers.Parse_GreedyMutable(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private OffsetEntry GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, OffsetEntry value)
		{
			list[index] = value;
		}

		public void Add(OffsetEntry item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, OffsetEntry item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(OffsetEntry item)
		{
			return list.Remove(item);
		}

		public bool Contains(OffsetEntry? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(OffsetEntry? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(OffsetEntry[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<OffsetEntry> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<OffsetEntry> value)
	{
		int count = value.Count;
		int num = 14;
		if (value is OffsetEntry[] array)
		{
			foreach (OffsetEntry offsetEntry in array)
			{
				SerializationHelpers.EnsureNonNull(offsetEntry);
				num += FlatSharp.Compiler.Generated.N9DAD4091EE3CCAD9126BDEE22E9BAAD7A27FF868CB6B88BF0FD15EAA0D0C8E07.Helpers.GetMaxSize(offsetEntry);
			}
		}
		else if (value is List<OffsetEntry> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				OffsetEntry offsetEntry2 = list[j];
				SerializationHelpers.EnsureNonNull(offsetEntry2);
				num += FlatSharp.Compiler.Generated.N9DAD4091EE3CCAD9126BDEE22E9BAAD7A27FF868CB6B88BF0FD15EAA0D0C8E07.Helpers.GetMaxSize(offsetEntry2);
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				OffsetEntry offsetEntry3 = value[k];
				SerializationHelpers.EnsureNonNull(offsetEntry3);
				num += FlatSharp.Compiler.Generated.N9DAD4091EE3CCAD9126BDEE22E9BAAD7A27FF868CB6B88BF0FD15EAA0D0C8E07.Helpers.GetMaxSize(offsetEntry3);
			}
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<OffsetEntry> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 4);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is OffsetEntry[] array)
		{
			foreach (OffsetEntry offsetEntry in array)
			{
				SerializationHelpers.EnsureNonNull(offsetEntry);
				FlatSharp.Compiler.Generated.N9DAD4091EE3CCAD9126BDEE22E9BAAD7A27FF868CB6B88BF0FD15EAA0D0C8E07.Helpers.Serialize(spanWriter, span, offsetEntry, num, context);
				num += 4;
			}
		}
		else if (value is List<OffsetEntry> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				OffsetEntry offsetEntry2 = list[j];
				SerializationHelpers.EnsureNonNull(offsetEntry2);
				FlatSharp.Compiler.Generated.N9DAD4091EE3CCAD9126BDEE22E9BAAD7A27FF868CB6B88BF0FD15EAA0D0C8E07.Helpers.Serialize(spanWriter, span, offsetEntry2, num, context);
				num += 4;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				OffsetEntry offsetEntry3 = value[k];
				SerializationHelpers.EnsureNonNull(offsetEntry3);
				FlatSharp.Compiler.Generated.N9DAD4091EE3CCAD9126BDEE22E9BAAD7A27FF868CB6B88BF0FD15EAA0D0C8E07.Helpers.Serialize(spanWriter, span, offsetEntry3, num, context);
				num += 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<OffsetEntry> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_4ec242904a5232ecec7d429cc7de0a3d_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<OffsetEntry> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_4ec242904a5232ecec7d429cc7de0a3d_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<OffsetEntry> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_4ec242904a5232ecec7d429cc7de0a3d_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<OffsetEntry> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_4ec242904a5232ecec7d429cc7de0a3d_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
