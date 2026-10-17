using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Snapshot;
using FlatSharp.Compiler.Generated.N42B6A86CDF9544868DA30425467220C3C5BC3750F389658D622C45B281B61873;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.NBFED703FA83B6E9DE1C1FE62C536F5317B2EB484B3BDA89CDF45E18DA865D398;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ AIHeroClient ], Count = {Count}")]
	internal sealed class GeneratedVector_c3880f5d75812b4004eb26776968ad06_Lazy<TInputBuffer> : IList<AIHeroClient>, ICollection<AIHeroClient>, IEnumerable<AIHeroClient>, IEnumerable, IReadOnlyList<AIHeroClient>, IReadOnlyCollection<AIHeroClient>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public AIHeroClient this[int index]
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

		public GeneratedVector_c3880f5d75812b4004eb26776968ad06_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N42B6A86CDF9544868DA30425467220C3C5BC3750F389658D622C45B281B61873.Helpers.tableReader_2616b691b4e642c4821991dddba45d45_Lazy<TInputBuffer> SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N42B6A86CDF9544868DA30425467220C3C5BC3750F389658D622C45B281B61873.Helpers.tableReader_2616b691b4e642c4821991dddba45d45_Lazy<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return FlatSharp.Compiler.Generated.N42B6A86CDF9544868DA30425467220C3C5BC3750F389658D622C45B281B61873.Helpers.Parse_Lazy(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, AIHeroClient value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(AIHeroClient? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(AIHeroClient? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(AIHeroClient[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<AIHeroClient> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(AIHeroClient item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, AIHeroClient item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(AIHeroClient item)
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

	[DebuggerDisplay("Progressive [ AIHeroClient ], Count = {Count}")]
	internal sealed class GeneratedVector_c3880f5d75812b4004eb26776968ad06_Progressive<TInputBuffer> : IList<AIHeroClient>, ICollection<AIHeroClient>, IEnumerable<AIHeroClient>, IEnumerable, IReadOnlyList<AIHeroClient>, IReadOnlyCollection<AIHeroClient>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly FlatSharp.Compiler.Generated.N42B6A86CDF9544868DA30425467220C3C5BC3750F389658D622C45B281B61873.Helpers.tableReader_2616b691b4e642c4821991dddba45d45_Progressive<TInputBuffer>?[]?[] items;

		public AIHeroClient this[int index]
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

		public GeneratedVector_c3880f5d75812b4004eb26776968ad06_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new FlatSharp.Compiler.Generated.N42B6A86CDF9544868DA30425467220C3C5BC3750F389658D622C45B281B61873.Helpers.tableReader_2616b691b4e642c4821991dddba45d45_Progressive<TInputBuffer>[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N42B6A86CDF9544868DA30425467220C3C5BC3750F389658D622C45B281B61873.Helpers.tableReader_2616b691b4e642c4821991dddba45d45_Progressive<TInputBuffer>?[] GetOrCreateRow(FlatSharp.Compiler.Generated.N42B6A86CDF9544868DA30425467220C3C5BC3750F389658D622C45B281B61873.Helpers.tableReader_2616b691b4e642c4821991dddba45d45_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private FlatSharp.Compiler.Generated.N42B6A86CDF9544868DA30425467220C3C5BC3750F389658D622C45B281B61873.Helpers.tableReader_2616b691b4e642c4821991dddba45d45_Progressive<TInputBuffer>?[] CreateRow(FlatSharp.Compiler.Generated.N42B6A86CDF9544868DA30425467220C3C5BC3750F389658D622C45B281B61873.Helpers.tableReader_2616b691b4e642c4821991dddba45d45_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] = new FlatSharp.Compiler.Generated.N42B6A86CDF9544868DA30425467220C3C5BC3750F389658D622C45B281B61873.Helpers.tableReader_2616b691b4e642c4821991dddba45d45_Progressive<TInputBuffer>[32];
		}

		private FlatSharp.Compiler.Generated.N42B6A86CDF9544868DA30425467220C3C5BC3750F389658D622C45B281B61873.Helpers.tableReader_2616b691b4e642c4821991dddba45d45_Progressive<TInputBuffer> ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			FlatSharp.Compiler.Generated.N42B6A86CDF9544868DA30425467220C3C5BC3750F389658D622C45B281B61873.Helpers.tableReader_2616b691b4e642c4821991dddba45d45_Progressive<TInputBuffer>[][] array = items;
			FlatSharp.Compiler.Generated.N42B6A86CDF9544868DA30425467220C3C5BC3750F389658D622C45B281B61873.Helpers.tableReader_2616b691b4e642c4821991dddba45d45_Progressive<TInputBuffer>[] orCreateRow = GetOrCreateRow(array, rowIndex);
			FlatSharp.Compiler.Generated.N42B6A86CDF9544868DA30425467220C3C5BC3750F389658D622C45B281B61873.Helpers.tableReader_2616b691b4e642c4821991dddba45d45_Progressive<TInputBuffer> tableReader_2616b691b4e642c4821991dddba45d45_Progressive = orCreateRow[colIndex];
			if (tableReader_2616b691b4e642c4821991dddba45d45_Progressive == null)
			{
				tableReader_2616b691b4e642c4821991dddba45d45_Progressive = (orCreateRow[colIndex] = UnsafeParseItem(index));
			}
			return tableReader_2616b691b4e642c4821991dddba45d45_Progressive;
		}

		private void ProgressiveSet(int index, AIHeroClient value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, AIHeroClient value)
		{
			VectorUtilities.CheckIndex(index, count);
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N42B6A86CDF9544868DA30425467220C3C5BC3750F389658D622C45B281B61873.Helpers.tableReader_2616b691b4e642c4821991dddba45d45_Progressive<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N42B6A86CDF9544868DA30425467220C3C5BC3750F389658D622C45B281B61873.Helpers.tableReader_2616b691b4e642c4821991dddba45d45_Progressive<TInputBuffer> UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.N42B6A86CDF9544868DA30425467220C3C5BC3750F389658D622C45B281B61873.Helpers.Parse_Progressive(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, AIHeroClient value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(AIHeroClient? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(AIHeroClient? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(AIHeroClient[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<AIHeroClient> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(AIHeroClient item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, AIHeroClient item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(AIHeroClient item)
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

	[DebuggerDisplay("Greedy [ AIHeroClient ], Count = {Count}")]
	internal sealed class GeneratedVector_c3880f5d75812b4004eb26776968ad06_Greedy<TInputBuffer> : IList<AIHeroClient>, ICollection<AIHeroClient>, IEnumerable<AIHeroClient>, IEnumerable, IReadOnlyList<AIHeroClient>, IReadOnlyCollection<AIHeroClient> where TInputBuffer : IInputBuffer
	{
		private readonly List<FlatSharp.Compiler.Generated.N42B6A86CDF9544868DA30425467220C3C5BC3750F389658D622C45B281B61873.Helpers.tableReader_2616b691b4e642c4821991dddba45d45_Greedy<TInputBuffer>> list;

		public AIHeroClient this[int index]
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

		public GeneratedVector_c3880f5d75812b4004eb26776968ad06_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<FlatSharp.Compiler.Generated.N42B6A86CDF9544868DA30425467220C3C5BC3750F389658D622C45B281B61873.Helpers.tableReader_2616b691b4e642c4821991dddba45d45_Greedy<TInputBuffer>> list = (this.list = new List<FlatSharp.Compiler.Generated.N42B6A86CDF9544868DA30425467220C3C5BC3750F389658D622C45B281B61873.Helpers.tableReader_2616b691b4e642c4821991dddba45d45_Greedy<TInputBuffer>>(num));
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.N42B6A86CDF9544868DA30425467220C3C5BC3750F389658D622C45B281B61873.Helpers.tableReader_2616b691b4e642c4821991dddba45d45_Greedy<TInputBuffer> item = FlatSharp.Compiler.Generated.N42B6A86CDF9544868DA30425467220C3C5BC3750F389658D622C45B281B61873.Helpers.Parse_Greedy(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		private FlatSharp.Compiler.Generated.N42B6A86CDF9544868DA30425467220C3C5BC3750F389658D622C45B281B61873.Helpers.tableReader_2616b691b4e642c4821991dddba45d45_Greedy<TInputBuffer> GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, AIHeroClient value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(AIHeroClient? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(AIHeroClient? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(AIHeroClient[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<AIHeroClient> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(AIHeroClient item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, AIHeroClient item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(AIHeroClient item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ AIHeroClient ], Count = {Count}")]
	internal sealed class GeneratedVector_c3880f5d75812b4004eb26776968ad06_GreedyMutable<TInputBuffer> : IList<AIHeroClient>, ICollection<AIHeroClient>, IEnumerable<AIHeroClient>, IEnumerable, IReadOnlyList<AIHeroClient>, IReadOnlyCollection<AIHeroClient> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<AIHeroClient> list;

		public AIHeroClient this[int index]
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

		public GeneratedVector_c3880f5d75812b4004eb26776968ad06_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<AIHeroClient> list = (this.list = new List<AIHeroClient>());
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.N42B6A86CDF9544868DA30425467220C3C5BC3750F389658D622C45B281B61873.Helpers.tableReader_2616b691b4e642c4821991dddba45d45_GreedyMutable<TInputBuffer> item = FlatSharp.Compiler.Generated.N42B6A86CDF9544868DA30425467220C3C5BC3750F389658D622C45B281B61873.Helpers.Parse_GreedyMutable(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private AIHeroClient GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, AIHeroClient value)
		{
			list[index] = value;
		}

		public void Add(AIHeroClient item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, AIHeroClient item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(AIHeroClient item)
		{
			return list.Remove(item);
		}

		public bool Contains(AIHeroClient? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(AIHeroClient? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(AIHeroClient[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<AIHeroClient> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<AIHeroClient> value)
	{
		int count = value.Count;
		int num = 14;
		if (value is AIHeroClient[] array)
		{
			foreach (AIHeroClient aIHeroClient in array)
			{
				SerializationHelpers.EnsureNonNull(aIHeroClient);
				num += FlatSharp.Compiler.Generated.N42B6A86CDF9544868DA30425467220C3C5BC3750F389658D622C45B281B61873.Helpers.GetMaxSize(aIHeroClient);
			}
		}
		else if (value is List<AIHeroClient> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				AIHeroClient aIHeroClient2 = list[j];
				SerializationHelpers.EnsureNonNull(aIHeroClient2);
				num += FlatSharp.Compiler.Generated.N42B6A86CDF9544868DA30425467220C3C5BC3750F389658D622C45B281B61873.Helpers.GetMaxSize(aIHeroClient2);
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				AIHeroClient aIHeroClient3 = value[k];
				SerializationHelpers.EnsureNonNull(aIHeroClient3);
				num += FlatSharp.Compiler.Generated.N42B6A86CDF9544868DA30425467220C3C5BC3750F389658D622C45B281B61873.Helpers.GetMaxSize(aIHeroClient3);
			}
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<AIHeroClient> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 4);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is AIHeroClient[] array)
		{
			foreach (AIHeroClient aIHeroClient in array)
			{
				SerializationHelpers.EnsureNonNull(aIHeroClient);
				FlatSharp.Compiler.Generated.N42B6A86CDF9544868DA30425467220C3C5BC3750F389658D622C45B281B61873.Helpers.Serialize(spanWriter, span, aIHeroClient, num, context);
				num += 4;
			}
		}
		else if (value is List<AIHeroClient> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				AIHeroClient aIHeroClient2 = list[j];
				SerializationHelpers.EnsureNonNull(aIHeroClient2);
				FlatSharp.Compiler.Generated.N42B6A86CDF9544868DA30425467220C3C5BC3750F389658D622C45B281B61873.Helpers.Serialize(spanWriter, span, aIHeroClient2, num, context);
				num += 4;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				AIHeroClient aIHeroClient3 = value[k];
				SerializationHelpers.EnsureNonNull(aIHeroClient3);
				FlatSharp.Compiler.Generated.N42B6A86CDF9544868DA30425467220C3C5BC3750F389658D622C45B281B61873.Helpers.Serialize(spanWriter, span, aIHeroClient3, num, context);
				num += 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<AIHeroClient> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_c3880f5d75812b4004eb26776968ad06_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<AIHeroClient> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_c3880f5d75812b4004eb26776968ad06_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<AIHeroClient> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_c3880f5d75812b4004eb26776968ad06_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<AIHeroClient> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_c3880f5d75812b4004eb26776968ad06_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
