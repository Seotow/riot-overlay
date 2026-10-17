using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Snapshot;
using FlatSharp.Compiler.Generated.NC104CFB248C2BAD87723423C76DAFE0EB7CB95DC0BCA526D150BAA3E90F1893F;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N2AA3AB3686E20CAA191DD297F6C82AA68B71CA63FE3505094AB6F9ECB8ED273D;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ GameInfo ], Count = {Count}")]
	internal sealed class GeneratedVector_adf4409151db7226a720d8d39e167391_Lazy<TInputBuffer> : IList<GameInfo>, ICollection<GameInfo>, IEnumerable<GameInfo>, IEnumerable, IReadOnlyList<GameInfo>, IReadOnlyCollection<GameInfo>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public GameInfo this[int index]
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

		public GeneratedVector_adf4409151db7226a720d8d39e167391_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NC104CFB248C2BAD87723423C76DAFE0EB7CB95DC0BCA526D150BAA3E90F1893F.Helpers.tableReader_c16154e7befa43f1948bd3a2e7ea084c_Lazy<TInputBuffer> SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NC104CFB248C2BAD87723423C76DAFE0EB7CB95DC0BCA526D150BAA3E90F1893F.Helpers.tableReader_c16154e7befa43f1948bd3a2e7ea084c_Lazy<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return FlatSharp.Compiler.Generated.NC104CFB248C2BAD87723423C76DAFE0EB7CB95DC0BCA526D150BAA3E90F1893F.Helpers.Parse_Lazy(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, GameInfo value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(GameInfo? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(GameInfo? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(GameInfo[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<GameInfo> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(GameInfo item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, GameInfo item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(GameInfo item)
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

	[DebuggerDisplay("Progressive [ GameInfo ], Count = {Count}")]
	internal sealed class GeneratedVector_adf4409151db7226a720d8d39e167391_Progressive<TInputBuffer> : IList<GameInfo>, ICollection<GameInfo>, IEnumerable<GameInfo>, IEnumerable, IReadOnlyList<GameInfo>, IReadOnlyCollection<GameInfo>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly FlatSharp.Compiler.Generated.NC104CFB248C2BAD87723423C76DAFE0EB7CB95DC0BCA526D150BAA3E90F1893F.Helpers.tableReader_c16154e7befa43f1948bd3a2e7ea084c_Progressive<TInputBuffer>?[]?[] items;

		public GameInfo this[int index]
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

		public GeneratedVector_adf4409151db7226a720d8d39e167391_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new FlatSharp.Compiler.Generated.NC104CFB248C2BAD87723423C76DAFE0EB7CB95DC0BCA526D150BAA3E90F1893F.Helpers.tableReader_c16154e7befa43f1948bd3a2e7ea084c_Progressive<TInputBuffer>[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NC104CFB248C2BAD87723423C76DAFE0EB7CB95DC0BCA526D150BAA3E90F1893F.Helpers.tableReader_c16154e7befa43f1948bd3a2e7ea084c_Progressive<TInputBuffer>?[] GetOrCreateRow(FlatSharp.Compiler.Generated.NC104CFB248C2BAD87723423C76DAFE0EB7CB95DC0BCA526D150BAA3E90F1893F.Helpers.tableReader_c16154e7befa43f1948bd3a2e7ea084c_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private FlatSharp.Compiler.Generated.NC104CFB248C2BAD87723423C76DAFE0EB7CB95DC0BCA526D150BAA3E90F1893F.Helpers.tableReader_c16154e7befa43f1948bd3a2e7ea084c_Progressive<TInputBuffer>?[] CreateRow(FlatSharp.Compiler.Generated.NC104CFB248C2BAD87723423C76DAFE0EB7CB95DC0BCA526D150BAA3E90F1893F.Helpers.tableReader_c16154e7befa43f1948bd3a2e7ea084c_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] = new FlatSharp.Compiler.Generated.NC104CFB248C2BAD87723423C76DAFE0EB7CB95DC0BCA526D150BAA3E90F1893F.Helpers.tableReader_c16154e7befa43f1948bd3a2e7ea084c_Progressive<TInputBuffer>[32];
		}

		private FlatSharp.Compiler.Generated.NC104CFB248C2BAD87723423C76DAFE0EB7CB95DC0BCA526D150BAA3E90F1893F.Helpers.tableReader_c16154e7befa43f1948bd3a2e7ea084c_Progressive<TInputBuffer> ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			FlatSharp.Compiler.Generated.NC104CFB248C2BAD87723423C76DAFE0EB7CB95DC0BCA526D150BAA3E90F1893F.Helpers.tableReader_c16154e7befa43f1948bd3a2e7ea084c_Progressive<TInputBuffer>[][] array = items;
			FlatSharp.Compiler.Generated.NC104CFB248C2BAD87723423C76DAFE0EB7CB95DC0BCA526D150BAA3E90F1893F.Helpers.tableReader_c16154e7befa43f1948bd3a2e7ea084c_Progressive<TInputBuffer>[] orCreateRow = GetOrCreateRow(array, rowIndex);
			FlatSharp.Compiler.Generated.NC104CFB248C2BAD87723423C76DAFE0EB7CB95DC0BCA526D150BAA3E90F1893F.Helpers.tableReader_c16154e7befa43f1948bd3a2e7ea084c_Progressive<TInputBuffer> tableReader_c16154e7befa43f1948bd3a2e7ea084c_Progressive = orCreateRow[colIndex];
			if (tableReader_c16154e7befa43f1948bd3a2e7ea084c_Progressive == null)
			{
				tableReader_c16154e7befa43f1948bd3a2e7ea084c_Progressive = (orCreateRow[colIndex] = UnsafeParseItem(index));
			}
			return tableReader_c16154e7befa43f1948bd3a2e7ea084c_Progressive;
		}

		private void ProgressiveSet(int index, GameInfo value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, GameInfo value)
		{
			VectorUtilities.CheckIndex(index, count);
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NC104CFB248C2BAD87723423C76DAFE0EB7CB95DC0BCA526D150BAA3E90F1893F.Helpers.tableReader_c16154e7befa43f1948bd3a2e7ea084c_Progressive<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NC104CFB248C2BAD87723423C76DAFE0EB7CB95DC0BCA526D150BAA3E90F1893F.Helpers.tableReader_c16154e7befa43f1948bd3a2e7ea084c_Progressive<TInputBuffer> UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.NC104CFB248C2BAD87723423C76DAFE0EB7CB95DC0BCA526D150BAA3E90F1893F.Helpers.Parse_Progressive(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, GameInfo value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(GameInfo? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(GameInfo? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(GameInfo[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<GameInfo> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(GameInfo item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, GameInfo item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(GameInfo item)
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

	[DebuggerDisplay("Greedy [ GameInfo ], Count = {Count}")]
	internal sealed class GeneratedVector_adf4409151db7226a720d8d39e167391_Greedy<TInputBuffer> : IList<GameInfo>, ICollection<GameInfo>, IEnumerable<GameInfo>, IEnumerable, IReadOnlyList<GameInfo>, IReadOnlyCollection<GameInfo> where TInputBuffer : IInputBuffer
	{
		private readonly List<FlatSharp.Compiler.Generated.NC104CFB248C2BAD87723423C76DAFE0EB7CB95DC0BCA526D150BAA3E90F1893F.Helpers.tableReader_c16154e7befa43f1948bd3a2e7ea084c_Greedy<TInputBuffer>> list;

		public GameInfo this[int index]
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

		public GeneratedVector_adf4409151db7226a720d8d39e167391_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<FlatSharp.Compiler.Generated.NC104CFB248C2BAD87723423C76DAFE0EB7CB95DC0BCA526D150BAA3E90F1893F.Helpers.tableReader_c16154e7befa43f1948bd3a2e7ea084c_Greedy<TInputBuffer>> list = (this.list = new List<FlatSharp.Compiler.Generated.NC104CFB248C2BAD87723423C76DAFE0EB7CB95DC0BCA526D150BAA3E90F1893F.Helpers.tableReader_c16154e7befa43f1948bd3a2e7ea084c_Greedy<TInputBuffer>>(num));
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.NC104CFB248C2BAD87723423C76DAFE0EB7CB95DC0BCA526D150BAA3E90F1893F.Helpers.tableReader_c16154e7befa43f1948bd3a2e7ea084c_Greedy<TInputBuffer> item = FlatSharp.Compiler.Generated.NC104CFB248C2BAD87723423C76DAFE0EB7CB95DC0BCA526D150BAA3E90F1893F.Helpers.Parse_Greedy(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		private FlatSharp.Compiler.Generated.NC104CFB248C2BAD87723423C76DAFE0EB7CB95DC0BCA526D150BAA3E90F1893F.Helpers.tableReader_c16154e7befa43f1948bd3a2e7ea084c_Greedy<TInputBuffer> GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, GameInfo value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(GameInfo? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(GameInfo? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(GameInfo[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<GameInfo> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(GameInfo item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, GameInfo item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(GameInfo item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ GameInfo ], Count = {Count}")]
	internal sealed class GeneratedVector_adf4409151db7226a720d8d39e167391_GreedyMutable<TInputBuffer> : IList<GameInfo>, ICollection<GameInfo>, IEnumerable<GameInfo>, IEnumerable, IReadOnlyList<GameInfo>, IReadOnlyCollection<GameInfo> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<GameInfo> list;

		public GameInfo this[int index]
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

		public GeneratedVector_adf4409151db7226a720d8d39e167391_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<GameInfo> list = (this.list = new List<GameInfo>());
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.NC104CFB248C2BAD87723423C76DAFE0EB7CB95DC0BCA526D150BAA3E90F1893F.Helpers.tableReader_c16154e7befa43f1948bd3a2e7ea084c_GreedyMutable<TInputBuffer> item = FlatSharp.Compiler.Generated.NC104CFB248C2BAD87723423C76DAFE0EB7CB95DC0BCA526D150BAA3E90F1893F.Helpers.Parse_GreedyMutable(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private GameInfo GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, GameInfo value)
		{
			list[index] = value;
		}

		public void Add(GameInfo item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, GameInfo item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(GameInfo item)
		{
			return list.Remove(item);
		}

		public bool Contains(GameInfo? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(GameInfo? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(GameInfo[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<GameInfo> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<GameInfo> value)
	{
		int count = value.Count;
		int num = 14;
		if (value is GameInfo[] array)
		{
			foreach (GameInfo gameInfo in array)
			{
				SerializationHelpers.EnsureNonNull(gameInfo);
				num += FlatSharp.Compiler.Generated.NC104CFB248C2BAD87723423C76DAFE0EB7CB95DC0BCA526D150BAA3E90F1893F.Helpers.GetMaxSize(gameInfo);
			}
		}
		else if (value is List<GameInfo> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				GameInfo gameInfo2 = list[j];
				SerializationHelpers.EnsureNonNull(gameInfo2);
				num += FlatSharp.Compiler.Generated.NC104CFB248C2BAD87723423C76DAFE0EB7CB95DC0BCA526D150BAA3E90F1893F.Helpers.GetMaxSize(gameInfo2);
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				GameInfo gameInfo3 = value[k];
				SerializationHelpers.EnsureNonNull(gameInfo3);
				num += FlatSharp.Compiler.Generated.NC104CFB248C2BAD87723423C76DAFE0EB7CB95DC0BCA526D150BAA3E90F1893F.Helpers.GetMaxSize(gameInfo3);
			}
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<GameInfo> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 4);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is GameInfo[] array)
		{
			foreach (GameInfo gameInfo in array)
			{
				SerializationHelpers.EnsureNonNull(gameInfo);
				FlatSharp.Compiler.Generated.NC104CFB248C2BAD87723423C76DAFE0EB7CB95DC0BCA526D150BAA3E90F1893F.Helpers.Serialize(spanWriter, span, gameInfo, num, context);
				num += 4;
			}
		}
		else if (value is List<GameInfo> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				GameInfo gameInfo2 = list[j];
				SerializationHelpers.EnsureNonNull(gameInfo2);
				FlatSharp.Compiler.Generated.NC104CFB248C2BAD87723423C76DAFE0EB7CB95DC0BCA526D150BAA3E90F1893F.Helpers.Serialize(spanWriter, span, gameInfo2, num, context);
				num += 4;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				GameInfo gameInfo3 = value[k];
				SerializationHelpers.EnsureNonNull(gameInfo3);
				FlatSharp.Compiler.Generated.NC104CFB248C2BAD87723423C76DAFE0EB7CB95DC0BCA526D150BAA3E90F1893F.Helpers.Serialize(spanWriter, span, gameInfo3, num, context);
				num += 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<GameInfo> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_adf4409151db7226a720d8d39e167391_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<GameInfo> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_adf4409151db7226a720d8d39e167391_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<GameInfo> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_adf4409151db7226a720d8d39e167391_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<GameInfo> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_adf4409151db7226a720d8d39e167391_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
