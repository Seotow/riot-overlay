using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Scene;
using FlatSharp.Compiler.Generated.NAEE366ACB44060E7B82B884516A8345C2E4FEA4F970D9330E2D9631A71A065BC;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.NADA1DAB95809967000C176D40CAE3666060B5B0125D683AAA1162C13D5785A83;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ ScriptAsset ], Count = {Count}")]
	internal sealed class GeneratedVector_fccfd7f2338d868caeb8c0f80954b9e0_Lazy<TInputBuffer> : IList<ScriptAsset>, ICollection<ScriptAsset>, IEnumerable<ScriptAsset>, IEnumerable, IReadOnlyList<ScriptAsset>, IReadOnlyCollection<ScriptAsset>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public ScriptAsset this[int index]
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

		public GeneratedVector_fccfd7f2338d868caeb8c0f80954b9e0_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NAEE366ACB44060E7B82B884516A8345C2E4FEA4F970D9330E2D9631A71A065BC.Helpers.tableReader_262b298f1c0e46b687639bf8bb77653a_Lazy<TInputBuffer> SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NAEE366ACB44060E7B82B884516A8345C2E4FEA4F970D9330E2D9631A71A065BC.Helpers.tableReader_262b298f1c0e46b687639bf8bb77653a_Lazy<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return FlatSharp.Compiler.Generated.NAEE366ACB44060E7B82B884516A8345C2E4FEA4F970D9330E2D9631A71A065BC.Helpers.Parse_Lazy(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, ScriptAsset value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(ScriptAsset? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(ScriptAsset? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(ScriptAsset[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<ScriptAsset> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(ScriptAsset item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, ScriptAsset item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(ScriptAsset item)
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

	[DebuggerDisplay("Progressive [ ScriptAsset ], Count = {Count}")]
	internal sealed class GeneratedVector_fccfd7f2338d868caeb8c0f80954b9e0_Progressive<TInputBuffer> : IList<ScriptAsset>, ICollection<ScriptAsset>, IEnumerable<ScriptAsset>, IEnumerable, IReadOnlyList<ScriptAsset>, IReadOnlyCollection<ScriptAsset>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly FlatSharp.Compiler.Generated.NAEE366ACB44060E7B82B884516A8345C2E4FEA4F970D9330E2D9631A71A065BC.Helpers.tableReader_262b298f1c0e46b687639bf8bb77653a_Progressive<TInputBuffer>?[]?[] items;

		public ScriptAsset this[int index]
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

		public GeneratedVector_fccfd7f2338d868caeb8c0f80954b9e0_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new FlatSharp.Compiler.Generated.NAEE366ACB44060E7B82B884516A8345C2E4FEA4F970D9330E2D9631A71A065BC.Helpers.tableReader_262b298f1c0e46b687639bf8bb77653a_Progressive<TInputBuffer>[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NAEE366ACB44060E7B82B884516A8345C2E4FEA4F970D9330E2D9631A71A065BC.Helpers.tableReader_262b298f1c0e46b687639bf8bb77653a_Progressive<TInputBuffer>?[] GetOrCreateRow(FlatSharp.Compiler.Generated.NAEE366ACB44060E7B82B884516A8345C2E4FEA4F970D9330E2D9631A71A065BC.Helpers.tableReader_262b298f1c0e46b687639bf8bb77653a_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private FlatSharp.Compiler.Generated.NAEE366ACB44060E7B82B884516A8345C2E4FEA4F970D9330E2D9631A71A065BC.Helpers.tableReader_262b298f1c0e46b687639bf8bb77653a_Progressive<TInputBuffer>?[] CreateRow(FlatSharp.Compiler.Generated.NAEE366ACB44060E7B82B884516A8345C2E4FEA4F970D9330E2D9631A71A065BC.Helpers.tableReader_262b298f1c0e46b687639bf8bb77653a_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] = new FlatSharp.Compiler.Generated.NAEE366ACB44060E7B82B884516A8345C2E4FEA4F970D9330E2D9631A71A065BC.Helpers.tableReader_262b298f1c0e46b687639bf8bb77653a_Progressive<TInputBuffer>[32];
		}

		private FlatSharp.Compiler.Generated.NAEE366ACB44060E7B82B884516A8345C2E4FEA4F970D9330E2D9631A71A065BC.Helpers.tableReader_262b298f1c0e46b687639bf8bb77653a_Progressive<TInputBuffer> ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			FlatSharp.Compiler.Generated.NAEE366ACB44060E7B82B884516A8345C2E4FEA4F970D9330E2D9631A71A065BC.Helpers.tableReader_262b298f1c0e46b687639bf8bb77653a_Progressive<TInputBuffer>[][] array = items;
			FlatSharp.Compiler.Generated.NAEE366ACB44060E7B82B884516A8345C2E4FEA4F970D9330E2D9631A71A065BC.Helpers.tableReader_262b298f1c0e46b687639bf8bb77653a_Progressive<TInputBuffer>[] orCreateRow = GetOrCreateRow(array, rowIndex);
			FlatSharp.Compiler.Generated.NAEE366ACB44060E7B82B884516A8345C2E4FEA4F970D9330E2D9631A71A065BC.Helpers.tableReader_262b298f1c0e46b687639bf8bb77653a_Progressive<TInputBuffer> tableReader_262b298f1c0e46b687639bf8bb77653a_Progressive = orCreateRow[colIndex];
			if (tableReader_262b298f1c0e46b687639bf8bb77653a_Progressive == null)
			{
				tableReader_262b298f1c0e46b687639bf8bb77653a_Progressive = (orCreateRow[colIndex] = UnsafeParseItem(index));
			}
			return tableReader_262b298f1c0e46b687639bf8bb77653a_Progressive;
		}

		private void ProgressiveSet(int index, ScriptAsset value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, ScriptAsset value)
		{
			VectorUtilities.CheckIndex(index, count);
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NAEE366ACB44060E7B82B884516A8345C2E4FEA4F970D9330E2D9631A71A065BC.Helpers.tableReader_262b298f1c0e46b687639bf8bb77653a_Progressive<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NAEE366ACB44060E7B82B884516A8345C2E4FEA4F970D9330E2D9631A71A065BC.Helpers.tableReader_262b298f1c0e46b687639bf8bb77653a_Progressive<TInputBuffer> UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.NAEE366ACB44060E7B82B884516A8345C2E4FEA4F970D9330E2D9631A71A065BC.Helpers.Parse_Progressive(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, ScriptAsset value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(ScriptAsset? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(ScriptAsset? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(ScriptAsset[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<ScriptAsset> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(ScriptAsset item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, ScriptAsset item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(ScriptAsset item)
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

	[DebuggerDisplay("Greedy [ ScriptAsset ], Count = {Count}")]
	internal sealed class GeneratedVector_fccfd7f2338d868caeb8c0f80954b9e0_Greedy<TInputBuffer> : IList<ScriptAsset>, ICollection<ScriptAsset>, IEnumerable<ScriptAsset>, IEnumerable, IReadOnlyList<ScriptAsset>, IReadOnlyCollection<ScriptAsset> where TInputBuffer : IInputBuffer
	{
		private readonly List<FlatSharp.Compiler.Generated.NAEE366ACB44060E7B82B884516A8345C2E4FEA4F970D9330E2D9631A71A065BC.Helpers.tableReader_262b298f1c0e46b687639bf8bb77653a_Greedy<TInputBuffer>> list;

		public ScriptAsset this[int index]
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

		public GeneratedVector_fccfd7f2338d868caeb8c0f80954b9e0_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<FlatSharp.Compiler.Generated.NAEE366ACB44060E7B82B884516A8345C2E4FEA4F970D9330E2D9631A71A065BC.Helpers.tableReader_262b298f1c0e46b687639bf8bb77653a_Greedy<TInputBuffer>> list = (this.list = new List<FlatSharp.Compiler.Generated.NAEE366ACB44060E7B82B884516A8345C2E4FEA4F970D9330E2D9631A71A065BC.Helpers.tableReader_262b298f1c0e46b687639bf8bb77653a_Greedy<TInputBuffer>>(num));
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.NAEE366ACB44060E7B82B884516A8345C2E4FEA4F970D9330E2D9631A71A065BC.Helpers.tableReader_262b298f1c0e46b687639bf8bb77653a_Greedy<TInputBuffer> item = FlatSharp.Compiler.Generated.NAEE366ACB44060E7B82B884516A8345C2E4FEA4F970D9330E2D9631A71A065BC.Helpers.Parse_Greedy(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		private FlatSharp.Compiler.Generated.NAEE366ACB44060E7B82B884516A8345C2E4FEA4F970D9330E2D9631A71A065BC.Helpers.tableReader_262b298f1c0e46b687639bf8bb77653a_Greedy<TInputBuffer> GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, ScriptAsset value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(ScriptAsset? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(ScriptAsset? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(ScriptAsset[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<ScriptAsset> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(ScriptAsset item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, ScriptAsset item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(ScriptAsset item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ ScriptAsset ], Count = {Count}")]
	internal sealed class GeneratedVector_fccfd7f2338d868caeb8c0f80954b9e0_GreedyMutable<TInputBuffer> : IList<ScriptAsset>, ICollection<ScriptAsset>, IEnumerable<ScriptAsset>, IEnumerable, IReadOnlyList<ScriptAsset>, IReadOnlyCollection<ScriptAsset> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<ScriptAsset> list;

		public ScriptAsset this[int index]
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

		public GeneratedVector_fccfd7f2338d868caeb8c0f80954b9e0_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<ScriptAsset> list = (this.list = new List<ScriptAsset>());
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.NAEE366ACB44060E7B82B884516A8345C2E4FEA4F970D9330E2D9631A71A065BC.Helpers.tableReader_262b298f1c0e46b687639bf8bb77653a_GreedyMutable<TInputBuffer> item = FlatSharp.Compiler.Generated.NAEE366ACB44060E7B82B884516A8345C2E4FEA4F970D9330E2D9631A71A065BC.Helpers.Parse_GreedyMutable(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private ScriptAsset GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, ScriptAsset value)
		{
			list[index] = value;
		}

		public void Add(ScriptAsset item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, ScriptAsset item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(ScriptAsset item)
		{
			return list.Remove(item);
		}

		public bool Contains(ScriptAsset? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(ScriptAsset? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(ScriptAsset[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<ScriptAsset> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<ScriptAsset> value)
	{
		int count = value.Count;
		int num = 14;
		if (value is ScriptAsset[] array)
		{
			foreach (ScriptAsset scriptAsset in array)
			{
				SerializationHelpers.EnsureNonNull(scriptAsset);
				num += FlatSharp.Compiler.Generated.NAEE366ACB44060E7B82B884516A8345C2E4FEA4F970D9330E2D9631A71A065BC.Helpers.GetMaxSize(scriptAsset);
			}
		}
		else if (value is List<ScriptAsset> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				ScriptAsset scriptAsset2 = list[j];
				SerializationHelpers.EnsureNonNull(scriptAsset2);
				num += FlatSharp.Compiler.Generated.NAEE366ACB44060E7B82B884516A8345C2E4FEA4F970D9330E2D9631A71A065BC.Helpers.GetMaxSize(scriptAsset2);
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				ScriptAsset scriptAsset3 = value[k];
				SerializationHelpers.EnsureNonNull(scriptAsset3);
				num += FlatSharp.Compiler.Generated.NAEE366ACB44060E7B82B884516A8345C2E4FEA4F970D9330E2D9631A71A065BC.Helpers.GetMaxSize(scriptAsset3);
			}
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<ScriptAsset> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 4);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is ScriptAsset[] array)
		{
			foreach (ScriptAsset scriptAsset in array)
			{
				SerializationHelpers.EnsureNonNull(scriptAsset);
				FlatSharp.Compiler.Generated.NAEE366ACB44060E7B82B884516A8345C2E4FEA4F970D9330E2D9631A71A065BC.Helpers.Serialize(spanWriter, span, scriptAsset, num, context);
				num += 4;
			}
		}
		else if (value is List<ScriptAsset> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				ScriptAsset scriptAsset2 = list[j];
				SerializationHelpers.EnsureNonNull(scriptAsset2);
				FlatSharp.Compiler.Generated.NAEE366ACB44060E7B82B884516A8345C2E4FEA4F970D9330E2D9631A71A065BC.Helpers.Serialize(spanWriter, span, scriptAsset2, num, context);
				num += 4;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				ScriptAsset scriptAsset3 = value[k];
				SerializationHelpers.EnsureNonNull(scriptAsset3);
				FlatSharp.Compiler.Generated.NAEE366ACB44060E7B82B884516A8345C2E4FEA4F970D9330E2D9631A71A065BC.Helpers.Serialize(spanWriter, span, scriptAsset3, num, context);
				num += 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<ScriptAsset> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return new GeneratedVector_fccfd7f2338d868caeb8c0f80954b9e0_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<ScriptAsset> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return new GeneratedVector_fccfd7f2338d868caeb8c0f80954b9e0_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<ScriptAsset> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return new GeneratedVector_fccfd7f2338d868caeb8c0f80954b9e0_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<ScriptAsset> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return new GeneratedVector_fccfd7f2338d868caeb8c0f80954b9e0_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
