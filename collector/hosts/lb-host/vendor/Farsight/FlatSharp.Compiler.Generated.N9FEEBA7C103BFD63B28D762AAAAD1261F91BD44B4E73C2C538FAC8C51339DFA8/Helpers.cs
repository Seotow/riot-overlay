using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Scene;
using FlatSharp.Compiler.Generated.NE64E6E244E5B5A103B2AFFF0A7914CDEFE55D1E98BF2A3055BCCBE8B2E95A05B;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N9FEEBA7C103BFD63B28D762AAAAD1261F91BD44B4E73C2C538FAC8C51339DFA8;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ EntitySnapshot ], Count = {Count}")]
	internal sealed class GeneratedVector_a28a9cb414b0e98d4aa5ab45a97a1771_Lazy<TInputBuffer> : IList<EntitySnapshot>, ICollection<EntitySnapshot>, IEnumerable<EntitySnapshot>, IEnumerable, IReadOnlyList<EntitySnapshot>, IReadOnlyCollection<EntitySnapshot>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public EntitySnapshot this[int index]
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

		public GeneratedVector_a28a9cb414b0e98d4aa5ab45a97a1771_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NE64E6E244E5B5A103B2AFFF0A7914CDEFE55D1E98BF2A3055BCCBE8B2E95A05B.Helpers.tableReader_d45609f99f6e475a825c7a2d968ad7b8_Lazy<TInputBuffer> SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NE64E6E244E5B5A103B2AFFF0A7914CDEFE55D1E98BF2A3055BCCBE8B2E95A05B.Helpers.tableReader_d45609f99f6e475a825c7a2d968ad7b8_Lazy<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return FlatSharp.Compiler.Generated.NE64E6E244E5B5A103B2AFFF0A7914CDEFE55D1E98BF2A3055BCCBE8B2E95A05B.Helpers.Parse_Lazy(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, EntitySnapshot value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(EntitySnapshot? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(EntitySnapshot? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(EntitySnapshot[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<EntitySnapshot> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(EntitySnapshot item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, EntitySnapshot item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(EntitySnapshot item)
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

	[DebuggerDisplay("Progressive [ EntitySnapshot ], Count = {Count}")]
	internal sealed class GeneratedVector_a28a9cb414b0e98d4aa5ab45a97a1771_Progressive<TInputBuffer> : IList<EntitySnapshot>, ICollection<EntitySnapshot>, IEnumerable<EntitySnapshot>, IEnumerable, IReadOnlyList<EntitySnapshot>, IReadOnlyCollection<EntitySnapshot>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly FlatSharp.Compiler.Generated.NE64E6E244E5B5A103B2AFFF0A7914CDEFE55D1E98BF2A3055BCCBE8B2E95A05B.Helpers.tableReader_d45609f99f6e475a825c7a2d968ad7b8_Progressive<TInputBuffer>?[]?[] items;

		public EntitySnapshot this[int index]
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

		public GeneratedVector_a28a9cb414b0e98d4aa5ab45a97a1771_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new FlatSharp.Compiler.Generated.NE64E6E244E5B5A103B2AFFF0A7914CDEFE55D1E98BF2A3055BCCBE8B2E95A05B.Helpers.tableReader_d45609f99f6e475a825c7a2d968ad7b8_Progressive<TInputBuffer>[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NE64E6E244E5B5A103B2AFFF0A7914CDEFE55D1E98BF2A3055BCCBE8B2E95A05B.Helpers.tableReader_d45609f99f6e475a825c7a2d968ad7b8_Progressive<TInputBuffer>?[] GetOrCreateRow(FlatSharp.Compiler.Generated.NE64E6E244E5B5A103B2AFFF0A7914CDEFE55D1E98BF2A3055BCCBE8B2E95A05B.Helpers.tableReader_d45609f99f6e475a825c7a2d968ad7b8_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private FlatSharp.Compiler.Generated.NE64E6E244E5B5A103B2AFFF0A7914CDEFE55D1E98BF2A3055BCCBE8B2E95A05B.Helpers.tableReader_d45609f99f6e475a825c7a2d968ad7b8_Progressive<TInputBuffer>?[] CreateRow(FlatSharp.Compiler.Generated.NE64E6E244E5B5A103B2AFFF0A7914CDEFE55D1E98BF2A3055BCCBE8B2E95A05B.Helpers.tableReader_d45609f99f6e475a825c7a2d968ad7b8_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] = new FlatSharp.Compiler.Generated.NE64E6E244E5B5A103B2AFFF0A7914CDEFE55D1E98BF2A3055BCCBE8B2E95A05B.Helpers.tableReader_d45609f99f6e475a825c7a2d968ad7b8_Progressive<TInputBuffer>[32];
		}

		private FlatSharp.Compiler.Generated.NE64E6E244E5B5A103B2AFFF0A7914CDEFE55D1E98BF2A3055BCCBE8B2E95A05B.Helpers.tableReader_d45609f99f6e475a825c7a2d968ad7b8_Progressive<TInputBuffer> ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			FlatSharp.Compiler.Generated.NE64E6E244E5B5A103B2AFFF0A7914CDEFE55D1E98BF2A3055BCCBE8B2E95A05B.Helpers.tableReader_d45609f99f6e475a825c7a2d968ad7b8_Progressive<TInputBuffer>[][] array = items;
			FlatSharp.Compiler.Generated.NE64E6E244E5B5A103B2AFFF0A7914CDEFE55D1E98BF2A3055BCCBE8B2E95A05B.Helpers.tableReader_d45609f99f6e475a825c7a2d968ad7b8_Progressive<TInputBuffer>[] orCreateRow = GetOrCreateRow(array, rowIndex);
			FlatSharp.Compiler.Generated.NE64E6E244E5B5A103B2AFFF0A7914CDEFE55D1E98BF2A3055BCCBE8B2E95A05B.Helpers.tableReader_d45609f99f6e475a825c7a2d968ad7b8_Progressive<TInputBuffer> tableReader_d45609f99f6e475a825c7a2d968ad7b8_Progressive = orCreateRow[colIndex];
			if (tableReader_d45609f99f6e475a825c7a2d968ad7b8_Progressive == null)
			{
				tableReader_d45609f99f6e475a825c7a2d968ad7b8_Progressive = (orCreateRow[colIndex] = UnsafeParseItem(index));
			}
			return tableReader_d45609f99f6e475a825c7a2d968ad7b8_Progressive;
		}

		private void ProgressiveSet(int index, EntitySnapshot value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, EntitySnapshot value)
		{
			VectorUtilities.CheckIndex(index, count);
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NE64E6E244E5B5A103B2AFFF0A7914CDEFE55D1E98BF2A3055BCCBE8B2E95A05B.Helpers.tableReader_d45609f99f6e475a825c7a2d968ad7b8_Progressive<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NE64E6E244E5B5A103B2AFFF0A7914CDEFE55D1E98BF2A3055BCCBE8B2E95A05B.Helpers.tableReader_d45609f99f6e475a825c7a2d968ad7b8_Progressive<TInputBuffer> UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.NE64E6E244E5B5A103B2AFFF0A7914CDEFE55D1E98BF2A3055BCCBE8B2E95A05B.Helpers.Parse_Progressive(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, EntitySnapshot value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(EntitySnapshot? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(EntitySnapshot? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(EntitySnapshot[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<EntitySnapshot> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(EntitySnapshot item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, EntitySnapshot item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(EntitySnapshot item)
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

	[DebuggerDisplay("Greedy [ EntitySnapshot ], Count = {Count}")]
	internal sealed class GeneratedVector_a28a9cb414b0e98d4aa5ab45a97a1771_Greedy<TInputBuffer> : IList<EntitySnapshot>, ICollection<EntitySnapshot>, IEnumerable<EntitySnapshot>, IEnumerable, IReadOnlyList<EntitySnapshot>, IReadOnlyCollection<EntitySnapshot> where TInputBuffer : IInputBuffer
	{
		private readonly List<FlatSharp.Compiler.Generated.NE64E6E244E5B5A103B2AFFF0A7914CDEFE55D1E98BF2A3055BCCBE8B2E95A05B.Helpers.tableReader_d45609f99f6e475a825c7a2d968ad7b8_Greedy<TInputBuffer>> list;

		public EntitySnapshot this[int index]
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

		public GeneratedVector_a28a9cb414b0e98d4aa5ab45a97a1771_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<FlatSharp.Compiler.Generated.NE64E6E244E5B5A103B2AFFF0A7914CDEFE55D1E98BF2A3055BCCBE8B2E95A05B.Helpers.tableReader_d45609f99f6e475a825c7a2d968ad7b8_Greedy<TInputBuffer>> list = (this.list = new List<FlatSharp.Compiler.Generated.NE64E6E244E5B5A103B2AFFF0A7914CDEFE55D1E98BF2A3055BCCBE8B2E95A05B.Helpers.tableReader_d45609f99f6e475a825c7a2d968ad7b8_Greedy<TInputBuffer>>(num));
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.NE64E6E244E5B5A103B2AFFF0A7914CDEFE55D1E98BF2A3055BCCBE8B2E95A05B.Helpers.tableReader_d45609f99f6e475a825c7a2d968ad7b8_Greedy<TInputBuffer> item = FlatSharp.Compiler.Generated.NE64E6E244E5B5A103B2AFFF0A7914CDEFE55D1E98BF2A3055BCCBE8B2E95A05B.Helpers.Parse_Greedy(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		private FlatSharp.Compiler.Generated.NE64E6E244E5B5A103B2AFFF0A7914CDEFE55D1E98BF2A3055BCCBE8B2E95A05B.Helpers.tableReader_d45609f99f6e475a825c7a2d968ad7b8_Greedy<TInputBuffer> GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, EntitySnapshot value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(EntitySnapshot? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(EntitySnapshot? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(EntitySnapshot[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<EntitySnapshot> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(EntitySnapshot item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, EntitySnapshot item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(EntitySnapshot item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ EntitySnapshot ], Count = {Count}")]
	internal sealed class GeneratedVector_a28a9cb414b0e98d4aa5ab45a97a1771_GreedyMutable<TInputBuffer> : IList<EntitySnapshot>, ICollection<EntitySnapshot>, IEnumerable<EntitySnapshot>, IEnumerable, IReadOnlyList<EntitySnapshot>, IReadOnlyCollection<EntitySnapshot> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<EntitySnapshot> list;

		public EntitySnapshot this[int index]
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

		public GeneratedVector_a28a9cb414b0e98d4aa5ab45a97a1771_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<EntitySnapshot> list = (this.list = new List<EntitySnapshot>());
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.NE64E6E244E5B5A103B2AFFF0A7914CDEFE55D1E98BF2A3055BCCBE8B2E95A05B.Helpers.tableReader_d45609f99f6e475a825c7a2d968ad7b8_GreedyMutable<TInputBuffer> item = FlatSharp.Compiler.Generated.NE64E6E244E5B5A103B2AFFF0A7914CDEFE55D1E98BF2A3055BCCBE8B2E95A05B.Helpers.Parse_GreedyMutable(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private EntitySnapshot GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, EntitySnapshot value)
		{
			list[index] = value;
		}

		public void Add(EntitySnapshot item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, EntitySnapshot item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(EntitySnapshot item)
		{
			return list.Remove(item);
		}

		public bool Contains(EntitySnapshot? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(EntitySnapshot? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(EntitySnapshot[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<EntitySnapshot> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<EntitySnapshot> value)
	{
		int count = value.Count;
		int num = 14;
		if (value is EntitySnapshot[] array)
		{
			foreach (EntitySnapshot entitySnapshot in array)
			{
				SerializationHelpers.EnsureNonNull(entitySnapshot);
				num += FlatSharp.Compiler.Generated.NE64E6E244E5B5A103B2AFFF0A7914CDEFE55D1E98BF2A3055BCCBE8B2E95A05B.Helpers.GetMaxSize(entitySnapshot);
			}
		}
		else if (value is List<EntitySnapshot> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				EntitySnapshot entitySnapshot2 = list[j];
				SerializationHelpers.EnsureNonNull(entitySnapshot2);
				num += FlatSharp.Compiler.Generated.NE64E6E244E5B5A103B2AFFF0A7914CDEFE55D1E98BF2A3055BCCBE8B2E95A05B.Helpers.GetMaxSize(entitySnapshot2);
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				EntitySnapshot entitySnapshot3 = value[k];
				SerializationHelpers.EnsureNonNull(entitySnapshot3);
				num += FlatSharp.Compiler.Generated.NE64E6E244E5B5A103B2AFFF0A7914CDEFE55D1E98BF2A3055BCCBE8B2E95A05B.Helpers.GetMaxSize(entitySnapshot3);
			}
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<EntitySnapshot> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 4);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is EntitySnapshot[] array)
		{
			foreach (EntitySnapshot entitySnapshot in array)
			{
				SerializationHelpers.EnsureNonNull(entitySnapshot);
				FlatSharp.Compiler.Generated.NE64E6E244E5B5A103B2AFFF0A7914CDEFE55D1E98BF2A3055BCCBE8B2E95A05B.Helpers.Serialize(spanWriter, span, entitySnapshot, num, context);
				num += 4;
			}
		}
		else if (value is List<EntitySnapshot> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				EntitySnapshot entitySnapshot2 = list[j];
				SerializationHelpers.EnsureNonNull(entitySnapshot2);
				FlatSharp.Compiler.Generated.NE64E6E244E5B5A103B2AFFF0A7914CDEFE55D1E98BF2A3055BCCBE8B2E95A05B.Helpers.Serialize(spanWriter, span, entitySnapshot2, num, context);
				num += 4;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				EntitySnapshot entitySnapshot3 = value[k];
				SerializationHelpers.EnsureNonNull(entitySnapshot3);
				FlatSharp.Compiler.Generated.NE64E6E244E5B5A103B2AFFF0A7914CDEFE55D1E98BF2A3055BCCBE8B2E95A05B.Helpers.Serialize(spanWriter, span, entitySnapshot3, num, context);
				num += 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<EntitySnapshot> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return new GeneratedVector_a28a9cb414b0e98d4aa5ab45a97a1771_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<EntitySnapshot> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return new GeneratedVector_a28a9cb414b0e98d4aa5ab45a97a1771_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<EntitySnapshot> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return new GeneratedVector_a28a9cb414b0e98d4aa5ab45a97a1771_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<EntitySnapshot> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return new GeneratedVector_a28a9cb414b0e98d4aa5ab45a97a1771_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
