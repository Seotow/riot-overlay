using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Scene;
using FlatSharp.Compiler.Generated.NC6030EE145CA2ECA2D995BDC240014B833DFA8755316E552928748427EBB9618;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N31430A2ADE7CEC4DBFD9D2EE81800A56CAE638DA6A4731938ADA40A958B3C573;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ EntityRecord ], Count = {Count}")]
	internal sealed class GeneratedVector_5b0a4a39bbcd1116b0c453696201c340_Lazy<TInputBuffer> : IList<EntityRecord>, ICollection<EntityRecord>, IEnumerable<EntityRecord>, IEnumerable, IReadOnlyList<EntityRecord>, IReadOnlyCollection<EntityRecord>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public EntityRecord this[int index]
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

		public GeneratedVector_5b0a4a39bbcd1116b0c453696201c340_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NC6030EE145CA2ECA2D995BDC240014B833DFA8755316E552928748427EBB9618.Helpers.tableReader_8ffe56c50aae4d359e067b3c289a71cd_Lazy<TInputBuffer> SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NC6030EE145CA2ECA2D995BDC240014B833DFA8755316E552928748427EBB9618.Helpers.tableReader_8ffe56c50aae4d359e067b3c289a71cd_Lazy<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return FlatSharp.Compiler.Generated.NC6030EE145CA2ECA2D995BDC240014B833DFA8755316E552928748427EBB9618.Helpers.Parse_Lazy(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, EntityRecord value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(EntityRecord? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(EntityRecord? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(EntityRecord[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<EntityRecord> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(EntityRecord item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, EntityRecord item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(EntityRecord item)
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

	[DebuggerDisplay("Progressive [ EntityRecord ], Count = {Count}")]
	internal sealed class GeneratedVector_5b0a4a39bbcd1116b0c453696201c340_Progressive<TInputBuffer> : IList<EntityRecord>, ICollection<EntityRecord>, IEnumerable<EntityRecord>, IEnumerable, IReadOnlyList<EntityRecord>, IReadOnlyCollection<EntityRecord>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly FlatSharp.Compiler.Generated.NC6030EE145CA2ECA2D995BDC240014B833DFA8755316E552928748427EBB9618.Helpers.tableReader_8ffe56c50aae4d359e067b3c289a71cd_Progressive<TInputBuffer>?[]?[] items;

		public EntityRecord this[int index]
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

		public GeneratedVector_5b0a4a39bbcd1116b0c453696201c340_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new FlatSharp.Compiler.Generated.NC6030EE145CA2ECA2D995BDC240014B833DFA8755316E552928748427EBB9618.Helpers.tableReader_8ffe56c50aae4d359e067b3c289a71cd_Progressive<TInputBuffer>[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NC6030EE145CA2ECA2D995BDC240014B833DFA8755316E552928748427EBB9618.Helpers.tableReader_8ffe56c50aae4d359e067b3c289a71cd_Progressive<TInputBuffer>?[] GetOrCreateRow(FlatSharp.Compiler.Generated.NC6030EE145CA2ECA2D995BDC240014B833DFA8755316E552928748427EBB9618.Helpers.tableReader_8ffe56c50aae4d359e067b3c289a71cd_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private FlatSharp.Compiler.Generated.NC6030EE145CA2ECA2D995BDC240014B833DFA8755316E552928748427EBB9618.Helpers.tableReader_8ffe56c50aae4d359e067b3c289a71cd_Progressive<TInputBuffer>?[] CreateRow(FlatSharp.Compiler.Generated.NC6030EE145CA2ECA2D995BDC240014B833DFA8755316E552928748427EBB9618.Helpers.tableReader_8ffe56c50aae4d359e067b3c289a71cd_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] = new FlatSharp.Compiler.Generated.NC6030EE145CA2ECA2D995BDC240014B833DFA8755316E552928748427EBB9618.Helpers.tableReader_8ffe56c50aae4d359e067b3c289a71cd_Progressive<TInputBuffer>[32];
		}

		private FlatSharp.Compiler.Generated.NC6030EE145CA2ECA2D995BDC240014B833DFA8755316E552928748427EBB9618.Helpers.tableReader_8ffe56c50aae4d359e067b3c289a71cd_Progressive<TInputBuffer> ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			FlatSharp.Compiler.Generated.NC6030EE145CA2ECA2D995BDC240014B833DFA8755316E552928748427EBB9618.Helpers.tableReader_8ffe56c50aae4d359e067b3c289a71cd_Progressive<TInputBuffer>[][] array = items;
			FlatSharp.Compiler.Generated.NC6030EE145CA2ECA2D995BDC240014B833DFA8755316E552928748427EBB9618.Helpers.tableReader_8ffe56c50aae4d359e067b3c289a71cd_Progressive<TInputBuffer>[] orCreateRow = GetOrCreateRow(array, rowIndex);
			FlatSharp.Compiler.Generated.NC6030EE145CA2ECA2D995BDC240014B833DFA8755316E552928748427EBB9618.Helpers.tableReader_8ffe56c50aae4d359e067b3c289a71cd_Progressive<TInputBuffer> tableReader_8ffe56c50aae4d359e067b3c289a71cd_Progressive = orCreateRow[colIndex];
			if (tableReader_8ffe56c50aae4d359e067b3c289a71cd_Progressive == null)
			{
				tableReader_8ffe56c50aae4d359e067b3c289a71cd_Progressive = (orCreateRow[colIndex] = UnsafeParseItem(index));
			}
			return tableReader_8ffe56c50aae4d359e067b3c289a71cd_Progressive;
		}

		private void ProgressiveSet(int index, EntityRecord value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, EntityRecord value)
		{
			VectorUtilities.CheckIndex(index, count);
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NC6030EE145CA2ECA2D995BDC240014B833DFA8755316E552928748427EBB9618.Helpers.tableReader_8ffe56c50aae4d359e067b3c289a71cd_Progressive<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NC6030EE145CA2ECA2D995BDC240014B833DFA8755316E552928748427EBB9618.Helpers.tableReader_8ffe56c50aae4d359e067b3c289a71cd_Progressive<TInputBuffer> UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.NC6030EE145CA2ECA2D995BDC240014B833DFA8755316E552928748427EBB9618.Helpers.Parse_Progressive(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, EntityRecord value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(EntityRecord? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(EntityRecord? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(EntityRecord[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<EntityRecord> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(EntityRecord item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, EntityRecord item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(EntityRecord item)
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

	[DebuggerDisplay("Greedy [ EntityRecord ], Count = {Count}")]
	internal sealed class GeneratedVector_5b0a4a39bbcd1116b0c453696201c340_Greedy<TInputBuffer> : IList<EntityRecord>, ICollection<EntityRecord>, IEnumerable<EntityRecord>, IEnumerable, IReadOnlyList<EntityRecord>, IReadOnlyCollection<EntityRecord> where TInputBuffer : IInputBuffer
	{
		private readonly List<FlatSharp.Compiler.Generated.NC6030EE145CA2ECA2D995BDC240014B833DFA8755316E552928748427EBB9618.Helpers.tableReader_8ffe56c50aae4d359e067b3c289a71cd_Greedy<TInputBuffer>> list;

		public EntityRecord this[int index]
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

		public GeneratedVector_5b0a4a39bbcd1116b0c453696201c340_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<FlatSharp.Compiler.Generated.NC6030EE145CA2ECA2D995BDC240014B833DFA8755316E552928748427EBB9618.Helpers.tableReader_8ffe56c50aae4d359e067b3c289a71cd_Greedy<TInputBuffer>> list = (this.list = new List<FlatSharp.Compiler.Generated.NC6030EE145CA2ECA2D995BDC240014B833DFA8755316E552928748427EBB9618.Helpers.tableReader_8ffe56c50aae4d359e067b3c289a71cd_Greedy<TInputBuffer>>(num));
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.NC6030EE145CA2ECA2D995BDC240014B833DFA8755316E552928748427EBB9618.Helpers.tableReader_8ffe56c50aae4d359e067b3c289a71cd_Greedy<TInputBuffer> item = FlatSharp.Compiler.Generated.NC6030EE145CA2ECA2D995BDC240014B833DFA8755316E552928748427EBB9618.Helpers.Parse_Greedy(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		private FlatSharp.Compiler.Generated.NC6030EE145CA2ECA2D995BDC240014B833DFA8755316E552928748427EBB9618.Helpers.tableReader_8ffe56c50aae4d359e067b3c289a71cd_Greedy<TInputBuffer> GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, EntityRecord value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(EntityRecord? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(EntityRecord? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(EntityRecord[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<EntityRecord> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(EntityRecord item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, EntityRecord item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(EntityRecord item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ EntityRecord ], Count = {Count}")]
	internal sealed class GeneratedVector_5b0a4a39bbcd1116b0c453696201c340_GreedyMutable<TInputBuffer> : IList<EntityRecord>, ICollection<EntityRecord>, IEnumerable<EntityRecord>, IEnumerable, IReadOnlyList<EntityRecord>, IReadOnlyCollection<EntityRecord> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<EntityRecord> list;

		public EntityRecord this[int index]
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

		public GeneratedVector_5b0a4a39bbcd1116b0c453696201c340_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<EntityRecord> list = (this.list = new List<EntityRecord>());
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.NC6030EE145CA2ECA2D995BDC240014B833DFA8755316E552928748427EBB9618.Helpers.tableReader_8ffe56c50aae4d359e067b3c289a71cd_GreedyMutable<TInputBuffer> item = FlatSharp.Compiler.Generated.NC6030EE145CA2ECA2D995BDC240014B833DFA8755316E552928748427EBB9618.Helpers.Parse_GreedyMutable(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private EntityRecord GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, EntityRecord value)
		{
			list[index] = value;
		}

		public void Add(EntityRecord item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, EntityRecord item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(EntityRecord item)
		{
			return list.Remove(item);
		}

		public bool Contains(EntityRecord? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(EntityRecord? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(EntityRecord[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<EntityRecord> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<EntityRecord> value)
	{
		int count = value.Count;
		int num = 14;
		if (value is EntityRecord[] array)
		{
			foreach (EntityRecord entityRecord in array)
			{
				SerializationHelpers.EnsureNonNull(entityRecord);
				num += FlatSharp.Compiler.Generated.NC6030EE145CA2ECA2D995BDC240014B833DFA8755316E552928748427EBB9618.Helpers.GetMaxSize(entityRecord);
			}
		}
		else if (value is List<EntityRecord> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				EntityRecord entityRecord2 = list[j];
				SerializationHelpers.EnsureNonNull(entityRecord2);
				num += FlatSharp.Compiler.Generated.NC6030EE145CA2ECA2D995BDC240014B833DFA8755316E552928748427EBB9618.Helpers.GetMaxSize(entityRecord2);
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				EntityRecord entityRecord3 = value[k];
				SerializationHelpers.EnsureNonNull(entityRecord3);
				num += FlatSharp.Compiler.Generated.NC6030EE145CA2ECA2D995BDC240014B833DFA8755316E552928748427EBB9618.Helpers.GetMaxSize(entityRecord3);
			}
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<EntityRecord> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 4);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is EntityRecord[] array)
		{
			foreach (EntityRecord entityRecord in array)
			{
				SerializationHelpers.EnsureNonNull(entityRecord);
				FlatSharp.Compiler.Generated.NC6030EE145CA2ECA2D995BDC240014B833DFA8755316E552928748427EBB9618.Helpers.Serialize(spanWriter, span, entityRecord, num, context);
				num += 4;
			}
		}
		else if (value is List<EntityRecord> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				EntityRecord entityRecord2 = list[j];
				SerializationHelpers.EnsureNonNull(entityRecord2);
				FlatSharp.Compiler.Generated.NC6030EE145CA2ECA2D995BDC240014B833DFA8755316E552928748427EBB9618.Helpers.Serialize(spanWriter, span, entityRecord2, num, context);
				num += 4;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				EntityRecord entityRecord3 = value[k];
				SerializationHelpers.EnsureNonNull(entityRecord3);
				FlatSharp.Compiler.Generated.NC6030EE145CA2ECA2D995BDC240014B833DFA8755316E552928748427EBB9618.Helpers.Serialize(spanWriter, span, entityRecord3, num, context);
				num += 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<EntityRecord> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return new GeneratedVector_5b0a4a39bbcd1116b0c453696201c340_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<EntityRecord> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return new GeneratedVector_5b0a4a39bbcd1116b0c453696201c340_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<EntityRecord> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return new GeneratedVector_5b0a4a39bbcd1116b0c453696201c340_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<EntityRecord> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return new GeneratedVector_5b0a4a39bbcd1116b0c453696201c340_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
