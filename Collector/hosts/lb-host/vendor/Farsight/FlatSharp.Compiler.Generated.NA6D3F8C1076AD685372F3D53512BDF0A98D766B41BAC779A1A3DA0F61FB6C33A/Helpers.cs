using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Entity;
using FlatSharp.Compiler.Generated.N9C439CEFA7EA2847C80F49BDC3B675BCB6D5ED3A07B88BFED482A1A8F2A1A5A5;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.NA6D3F8C1076AD685372F3D53512BDF0A98D766B41BAC779A1A3DA0F61FB6C33A;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ ScriptEntry ], Count = {Count}")]
	internal sealed class GeneratedVector_539b374cb03d13b2fc5569d29600bd6b_Lazy<TInputBuffer> : IList<ScriptEntry>, ICollection<ScriptEntry>, IEnumerable<ScriptEntry>, IEnumerable, IReadOnlyList<ScriptEntry>, IReadOnlyCollection<ScriptEntry>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public ScriptEntry this[int index]
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

		public GeneratedVector_539b374cb03d13b2fc5569d29600bd6b_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N9C439CEFA7EA2847C80F49BDC3B675BCB6D5ED3A07B88BFED482A1A8F2A1A5A5.Helpers.tableReader_659992a66b8245ea9335eb8d32b512d8_Lazy<TInputBuffer> SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N9C439CEFA7EA2847C80F49BDC3B675BCB6D5ED3A07B88BFED482A1A8F2A1A5A5.Helpers.tableReader_659992a66b8245ea9335eb8d32b512d8_Lazy<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return FlatSharp.Compiler.Generated.N9C439CEFA7EA2847C80F49BDC3B675BCB6D5ED3A07B88BFED482A1A8F2A1A5A5.Helpers.Parse_Lazy(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, ScriptEntry value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(ScriptEntry? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(ScriptEntry? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(ScriptEntry[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<ScriptEntry> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(ScriptEntry item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, ScriptEntry item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(ScriptEntry item)
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

	[DebuggerDisplay("Progressive [ ScriptEntry ], Count = {Count}")]
	internal sealed class GeneratedVector_539b374cb03d13b2fc5569d29600bd6b_Progressive<TInputBuffer> : IList<ScriptEntry>, ICollection<ScriptEntry>, IEnumerable<ScriptEntry>, IEnumerable, IReadOnlyList<ScriptEntry>, IReadOnlyCollection<ScriptEntry>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly FlatSharp.Compiler.Generated.N9C439CEFA7EA2847C80F49BDC3B675BCB6D5ED3A07B88BFED482A1A8F2A1A5A5.Helpers.tableReader_659992a66b8245ea9335eb8d32b512d8_Progressive<TInputBuffer>?[]?[] items;

		public ScriptEntry this[int index]
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

		public GeneratedVector_539b374cb03d13b2fc5569d29600bd6b_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new FlatSharp.Compiler.Generated.N9C439CEFA7EA2847C80F49BDC3B675BCB6D5ED3A07B88BFED482A1A8F2A1A5A5.Helpers.tableReader_659992a66b8245ea9335eb8d32b512d8_Progressive<TInputBuffer>[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N9C439CEFA7EA2847C80F49BDC3B675BCB6D5ED3A07B88BFED482A1A8F2A1A5A5.Helpers.tableReader_659992a66b8245ea9335eb8d32b512d8_Progressive<TInputBuffer>?[] GetOrCreateRow(FlatSharp.Compiler.Generated.N9C439CEFA7EA2847C80F49BDC3B675BCB6D5ED3A07B88BFED482A1A8F2A1A5A5.Helpers.tableReader_659992a66b8245ea9335eb8d32b512d8_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private FlatSharp.Compiler.Generated.N9C439CEFA7EA2847C80F49BDC3B675BCB6D5ED3A07B88BFED482A1A8F2A1A5A5.Helpers.tableReader_659992a66b8245ea9335eb8d32b512d8_Progressive<TInputBuffer>?[] CreateRow(FlatSharp.Compiler.Generated.N9C439CEFA7EA2847C80F49BDC3B675BCB6D5ED3A07B88BFED482A1A8F2A1A5A5.Helpers.tableReader_659992a66b8245ea9335eb8d32b512d8_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] = new FlatSharp.Compiler.Generated.N9C439CEFA7EA2847C80F49BDC3B675BCB6D5ED3A07B88BFED482A1A8F2A1A5A5.Helpers.tableReader_659992a66b8245ea9335eb8d32b512d8_Progressive<TInputBuffer>[32];
		}

		private FlatSharp.Compiler.Generated.N9C439CEFA7EA2847C80F49BDC3B675BCB6D5ED3A07B88BFED482A1A8F2A1A5A5.Helpers.tableReader_659992a66b8245ea9335eb8d32b512d8_Progressive<TInputBuffer> ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			FlatSharp.Compiler.Generated.N9C439CEFA7EA2847C80F49BDC3B675BCB6D5ED3A07B88BFED482A1A8F2A1A5A5.Helpers.tableReader_659992a66b8245ea9335eb8d32b512d8_Progressive<TInputBuffer>[][] array = items;
			FlatSharp.Compiler.Generated.N9C439CEFA7EA2847C80F49BDC3B675BCB6D5ED3A07B88BFED482A1A8F2A1A5A5.Helpers.tableReader_659992a66b8245ea9335eb8d32b512d8_Progressive<TInputBuffer>[] orCreateRow = GetOrCreateRow(array, rowIndex);
			FlatSharp.Compiler.Generated.N9C439CEFA7EA2847C80F49BDC3B675BCB6D5ED3A07B88BFED482A1A8F2A1A5A5.Helpers.tableReader_659992a66b8245ea9335eb8d32b512d8_Progressive<TInputBuffer> tableReader_659992a66b8245ea9335eb8d32b512d8_Progressive = orCreateRow[colIndex];
			if (tableReader_659992a66b8245ea9335eb8d32b512d8_Progressive == null)
			{
				tableReader_659992a66b8245ea9335eb8d32b512d8_Progressive = (orCreateRow[colIndex] = UnsafeParseItem(index));
			}
			return tableReader_659992a66b8245ea9335eb8d32b512d8_Progressive;
		}

		private void ProgressiveSet(int index, ScriptEntry value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, ScriptEntry value)
		{
			VectorUtilities.CheckIndex(index, count);
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N9C439CEFA7EA2847C80F49BDC3B675BCB6D5ED3A07B88BFED482A1A8F2A1A5A5.Helpers.tableReader_659992a66b8245ea9335eb8d32b512d8_Progressive<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N9C439CEFA7EA2847C80F49BDC3B675BCB6D5ED3A07B88BFED482A1A8F2A1A5A5.Helpers.tableReader_659992a66b8245ea9335eb8d32b512d8_Progressive<TInputBuffer> UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.N9C439CEFA7EA2847C80F49BDC3B675BCB6D5ED3A07B88BFED482A1A8F2A1A5A5.Helpers.Parse_Progressive(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, ScriptEntry value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(ScriptEntry? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(ScriptEntry? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(ScriptEntry[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<ScriptEntry> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(ScriptEntry item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, ScriptEntry item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(ScriptEntry item)
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

	[DebuggerDisplay("Greedy [ ScriptEntry ], Count = {Count}")]
	internal sealed class GeneratedVector_539b374cb03d13b2fc5569d29600bd6b_Greedy<TInputBuffer> : IList<ScriptEntry>, ICollection<ScriptEntry>, IEnumerable<ScriptEntry>, IEnumerable, IReadOnlyList<ScriptEntry>, IReadOnlyCollection<ScriptEntry> where TInputBuffer : IInputBuffer
	{
		private readonly List<FlatSharp.Compiler.Generated.N9C439CEFA7EA2847C80F49BDC3B675BCB6D5ED3A07B88BFED482A1A8F2A1A5A5.Helpers.tableReader_659992a66b8245ea9335eb8d32b512d8_Greedy<TInputBuffer>> list;

		public ScriptEntry this[int index]
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

		public GeneratedVector_539b374cb03d13b2fc5569d29600bd6b_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<FlatSharp.Compiler.Generated.N9C439CEFA7EA2847C80F49BDC3B675BCB6D5ED3A07B88BFED482A1A8F2A1A5A5.Helpers.tableReader_659992a66b8245ea9335eb8d32b512d8_Greedy<TInputBuffer>> list = (this.list = new List<FlatSharp.Compiler.Generated.N9C439CEFA7EA2847C80F49BDC3B675BCB6D5ED3A07B88BFED482A1A8F2A1A5A5.Helpers.tableReader_659992a66b8245ea9335eb8d32b512d8_Greedy<TInputBuffer>>(num));
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.N9C439CEFA7EA2847C80F49BDC3B675BCB6D5ED3A07B88BFED482A1A8F2A1A5A5.Helpers.tableReader_659992a66b8245ea9335eb8d32b512d8_Greedy<TInputBuffer> item = FlatSharp.Compiler.Generated.N9C439CEFA7EA2847C80F49BDC3B675BCB6D5ED3A07B88BFED482A1A8F2A1A5A5.Helpers.Parse_Greedy(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		private FlatSharp.Compiler.Generated.N9C439CEFA7EA2847C80F49BDC3B675BCB6D5ED3A07B88BFED482A1A8F2A1A5A5.Helpers.tableReader_659992a66b8245ea9335eb8d32b512d8_Greedy<TInputBuffer> GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, ScriptEntry value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(ScriptEntry? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(ScriptEntry? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(ScriptEntry[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<ScriptEntry> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(ScriptEntry item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, ScriptEntry item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(ScriptEntry item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ ScriptEntry ], Count = {Count}")]
	internal sealed class GeneratedVector_539b374cb03d13b2fc5569d29600bd6b_GreedyMutable<TInputBuffer> : IList<ScriptEntry>, ICollection<ScriptEntry>, IEnumerable<ScriptEntry>, IEnumerable, IReadOnlyList<ScriptEntry>, IReadOnlyCollection<ScriptEntry> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<ScriptEntry> list;

		public ScriptEntry this[int index]
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

		public GeneratedVector_539b374cb03d13b2fc5569d29600bd6b_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<ScriptEntry> list = (this.list = new List<ScriptEntry>());
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.N9C439CEFA7EA2847C80F49BDC3B675BCB6D5ED3A07B88BFED482A1A8F2A1A5A5.Helpers.tableReader_659992a66b8245ea9335eb8d32b512d8_GreedyMutable<TInputBuffer> item = FlatSharp.Compiler.Generated.N9C439CEFA7EA2847C80F49BDC3B675BCB6D5ED3A07B88BFED482A1A8F2A1A5A5.Helpers.Parse_GreedyMutable(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private ScriptEntry GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, ScriptEntry value)
		{
			list[index] = value;
		}

		public void Add(ScriptEntry item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, ScriptEntry item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(ScriptEntry item)
		{
			return list.Remove(item);
		}

		public bool Contains(ScriptEntry? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(ScriptEntry? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(ScriptEntry[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<ScriptEntry> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<ScriptEntry> value)
	{
		int count = value.Count;
		int num = 14;
		if (value is ScriptEntry[] array)
		{
			foreach (ScriptEntry scriptEntry in array)
			{
				SerializationHelpers.EnsureNonNull(scriptEntry);
				num += FlatSharp.Compiler.Generated.N9C439CEFA7EA2847C80F49BDC3B675BCB6D5ED3A07B88BFED482A1A8F2A1A5A5.Helpers.GetMaxSize(scriptEntry);
			}
		}
		else if (value is List<ScriptEntry> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				ScriptEntry scriptEntry2 = list[j];
				SerializationHelpers.EnsureNonNull(scriptEntry2);
				num += FlatSharp.Compiler.Generated.N9C439CEFA7EA2847C80F49BDC3B675BCB6D5ED3A07B88BFED482A1A8F2A1A5A5.Helpers.GetMaxSize(scriptEntry2);
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				ScriptEntry scriptEntry3 = value[k];
				SerializationHelpers.EnsureNonNull(scriptEntry3);
				num += FlatSharp.Compiler.Generated.N9C439CEFA7EA2847C80F49BDC3B675BCB6D5ED3A07B88BFED482A1A8F2A1A5A5.Helpers.GetMaxSize(scriptEntry3);
			}
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<ScriptEntry> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 4);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is ScriptEntry[] array)
		{
			foreach (ScriptEntry scriptEntry in array)
			{
				SerializationHelpers.EnsureNonNull(scriptEntry);
				FlatSharp.Compiler.Generated.N9C439CEFA7EA2847C80F49BDC3B675BCB6D5ED3A07B88BFED482A1A8F2A1A5A5.Helpers.Serialize(spanWriter, span, scriptEntry, num, context);
				num += 4;
			}
		}
		else if (value is List<ScriptEntry> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				ScriptEntry scriptEntry2 = list[j];
				SerializationHelpers.EnsureNonNull(scriptEntry2);
				FlatSharp.Compiler.Generated.N9C439CEFA7EA2847C80F49BDC3B675BCB6D5ED3A07B88BFED482A1A8F2A1A5A5.Helpers.Serialize(spanWriter, span, scriptEntry2, num, context);
				num += 4;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				ScriptEntry scriptEntry3 = value[k];
				SerializationHelpers.EnsureNonNull(scriptEntry3);
				FlatSharp.Compiler.Generated.N9C439CEFA7EA2847C80F49BDC3B675BCB6D5ED3A07B88BFED482A1A8F2A1A5A5.Helpers.Serialize(spanWriter, span, scriptEntry3, num, context);
				num += 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<ScriptEntry> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return new GeneratedVector_539b374cb03d13b2fc5569d29600bd6b_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<ScriptEntry> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return new GeneratedVector_539b374cb03d13b2fc5569d29600bd6b_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<ScriptEntry> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return new GeneratedVector_539b374cb03d13b2fc5569d29600bd6b_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<ScriptEntry> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return new GeneratedVector_539b374cb03d13b2fc5569d29600bd6b_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
