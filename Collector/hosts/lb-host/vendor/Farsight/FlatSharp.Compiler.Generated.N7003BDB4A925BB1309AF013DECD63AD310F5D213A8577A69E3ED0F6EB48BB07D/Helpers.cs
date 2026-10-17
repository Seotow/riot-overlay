using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Commands;
using FlatSharp.Compiler.Generated.N019847E8E25C20AF1F45BD04EBDAE12ACF40CFF58D0E61D2A831634C123360A5;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N7003BDB4A925BB1309AF013DECD63AD310F5D213A8577A69E3ED0F6EB48BB07D;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ StrokeSyncBeginRemote ], Count = {Count}")]
	internal sealed class GeneratedVector_05459a461aa77f6964b322ee4b4223c2_Lazy<TInputBuffer> : IList<StrokeSyncBeginRemote>, ICollection<StrokeSyncBeginRemote>, IEnumerable<StrokeSyncBeginRemote>, IEnumerable, IReadOnlyList<StrokeSyncBeginRemote>, IReadOnlyCollection<StrokeSyncBeginRemote>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public StrokeSyncBeginRemote this[int index]
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

		public GeneratedVector_05459a461aa77f6964b322ee4b4223c2_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N019847E8E25C20AF1F45BD04EBDAE12ACF40CFF58D0E61D2A831634C123360A5.Helpers.tableReader_7aa2f793630a46d2bab705e24386f9cd_Lazy<TInputBuffer> SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N019847E8E25C20AF1F45BD04EBDAE12ACF40CFF58D0E61D2A831634C123360A5.Helpers.tableReader_7aa2f793630a46d2bab705e24386f9cd_Lazy<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return FlatSharp.Compiler.Generated.N019847E8E25C20AF1F45BD04EBDAE12ACF40CFF58D0E61D2A831634C123360A5.Helpers.Parse_Lazy(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, StrokeSyncBeginRemote value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(StrokeSyncBeginRemote? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(StrokeSyncBeginRemote? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(StrokeSyncBeginRemote[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<StrokeSyncBeginRemote> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(StrokeSyncBeginRemote item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, StrokeSyncBeginRemote item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(StrokeSyncBeginRemote item)
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

	[DebuggerDisplay("Progressive [ StrokeSyncBeginRemote ], Count = {Count}")]
	internal sealed class GeneratedVector_05459a461aa77f6964b322ee4b4223c2_Progressive<TInputBuffer> : IList<StrokeSyncBeginRemote>, ICollection<StrokeSyncBeginRemote>, IEnumerable<StrokeSyncBeginRemote>, IEnumerable, IReadOnlyList<StrokeSyncBeginRemote>, IReadOnlyCollection<StrokeSyncBeginRemote>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly FlatSharp.Compiler.Generated.N019847E8E25C20AF1F45BD04EBDAE12ACF40CFF58D0E61D2A831634C123360A5.Helpers.tableReader_7aa2f793630a46d2bab705e24386f9cd_Progressive<TInputBuffer>?[]?[] items;

		public StrokeSyncBeginRemote this[int index]
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

		public GeneratedVector_05459a461aa77f6964b322ee4b4223c2_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new FlatSharp.Compiler.Generated.N019847E8E25C20AF1F45BD04EBDAE12ACF40CFF58D0E61D2A831634C123360A5.Helpers.tableReader_7aa2f793630a46d2bab705e24386f9cd_Progressive<TInputBuffer>[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N019847E8E25C20AF1F45BD04EBDAE12ACF40CFF58D0E61D2A831634C123360A5.Helpers.tableReader_7aa2f793630a46d2bab705e24386f9cd_Progressive<TInputBuffer>?[] GetOrCreateRow(FlatSharp.Compiler.Generated.N019847E8E25C20AF1F45BD04EBDAE12ACF40CFF58D0E61D2A831634C123360A5.Helpers.tableReader_7aa2f793630a46d2bab705e24386f9cd_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private FlatSharp.Compiler.Generated.N019847E8E25C20AF1F45BD04EBDAE12ACF40CFF58D0E61D2A831634C123360A5.Helpers.tableReader_7aa2f793630a46d2bab705e24386f9cd_Progressive<TInputBuffer>?[] CreateRow(FlatSharp.Compiler.Generated.N019847E8E25C20AF1F45BD04EBDAE12ACF40CFF58D0E61D2A831634C123360A5.Helpers.tableReader_7aa2f793630a46d2bab705e24386f9cd_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] = new FlatSharp.Compiler.Generated.N019847E8E25C20AF1F45BD04EBDAE12ACF40CFF58D0E61D2A831634C123360A5.Helpers.tableReader_7aa2f793630a46d2bab705e24386f9cd_Progressive<TInputBuffer>[32];
		}

		private FlatSharp.Compiler.Generated.N019847E8E25C20AF1F45BD04EBDAE12ACF40CFF58D0E61D2A831634C123360A5.Helpers.tableReader_7aa2f793630a46d2bab705e24386f9cd_Progressive<TInputBuffer> ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			FlatSharp.Compiler.Generated.N019847E8E25C20AF1F45BD04EBDAE12ACF40CFF58D0E61D2A831634C123360A5.Helpers.tableReader_7aa2f793630a46d2bab705e24386f9cd_Progressive<TInputBuffer>[][] array = items;
			FlatSharp.Compiler.Generated.N019847E8E25C20AF1F45BD04EBDAE12ACF40CFF58D0E61D2A831634C123360A5.Helpers.tableReader_7aa2f793630a46d2bab705e24386f9cd_Progressive<TInputBuffer>[] orCreateRow = GetOrCreateRow(array, rowIndex);
			FlatSharp.Compiler.Generated.N019847E8E25C20AF1F45BD04EBDAE12ACF40CFF58D0E61D2A831634C123360A5.Helpers.tableReader_7aa2f793630a46d2bab705e24386f9cd_Progressive<TInputBuffer> tableReader_7aa2f793630a46d2bab705e24386f9cd_Progressive = orCreateRow[colIndex];
			if (tableReader_7aa2f793630a46d2bab705e24386f9cd_Progressive == null)
			{
				tableReader_7aa2f793630a46d2bab705e24386f9cd_Progressive = (orCreateRow[colIndex] = UnsafeParseItem(index));
			}
			return tableReader_7aa2f793630a46d2bab705e24386f9cd_Progressive;
		}

		private void ProgressiveSet(int index, StrokeSyncBeginRemote value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, StrokeSyncBeginRemote value)
		{
			VectorUtilities.CheckIndex(index, count);
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N019847E8E25C20AF1F45BD04EBDAE12ACF40CFF58D0E61D2A831634C123360A5.Helpers.tableReader_7aa2f793630a46d2bab705e24386f9cd_Progressive<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N019847E8E25C20AF1F45BD04EBDAE12ACF40CFF58D0E61D2A831634C123360A5.Helpers.tableReader_7aa2f793630a46d2bab705e24386f9cd_Progressive<TInputBuffer> UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.N019847E8E25C20AF1F45BD04EBDAE12ACF40CFF58D0E61D2A831634C123360A5.Helpers.Parse_Progressive(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, StrokeSyncBeginRemote value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(StrokeSyncBeginRemote? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(StrokeSyncBeginRemote? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(StrokeSyncBeginRemote[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<StrokeSyncBeginRemote> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(StrokeSyncBeginRemote item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, StrokeSyncBeginRemote item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(StrokeSyncBeginRemote item)
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

	[DebuggerDisplay("Greedy [ StrokeSyncBeginRemote ], Count = {Count}")]
	internal sealed class GeneratedVector_05459a461aa77f6964b322ee4b4223c2_Greedy<TInputBuffer> : IList<StrokeSyncBeginRemote>, ICollection<StrokeSyncBeginRemote>, IEnumerable<StrokeSyncBeginRemote>, IEnumerable, IReadOnlyList<StrokeSyncBeginRemote>, IReadOnlyCollection<StrokeSyncBeginRemote> where TInputBuffer : IInputBuffer
	{
		private readonly List<FlatSharp.Compiler.Generated.N019847E8E25C20AF1F45BD04EBDAE12ACF40CFF58D0E61D2A831634C123360A5.Helpers.tableReader_7aa2f793630a46d2bab705e24386f9cd_Greedy<TInputBuffer>> list;

		public StrokeSyncBeginRemote this[int index]
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

		public GeneratedVector_05459a461aa77f6964b322ee4b4223c2_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<FlatSharp.Compiler.Generated.N019847E8E25C20AF1F45BD04EBDAE12ACF40CFF58D0E61D2A831634C123360A5.Helpers.tableReader_7aa2f793630a46d2bab705e24386f9cd_Greedy<TInputBuffer>> list = (this.list = new List<FlatSharp.Compiler.Generated.N019847E8E25C20AF1F45BD04EBDAE12ACF40CFF58D0E61D2A831634C123360A5.Helpers.tableReader_7aa2f793630a46d2bab705e24386f9cd_Greedy<TInputBuffer>>(num));
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.N019847E8E25C20AF1F45BD04EBDAE12ACF40CFF58D0E61D2A831634C123360A5.Helpers.tableReader_7aa2f793630a46d2bab705e24386f9cd_Greedy<TInputBuffer> item = FlatSharp.Compiler.Generated.N019847E8E25C20AF1F45BD04EBDAE12ACF40CFF58D0E61D2A831634C123360A5.Helpers.Parse_Greedy(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		private FlatSharp.Compiler.Generated.N019847E8E25C20AF1F45BD04EBDAE12ACF40CFF58D0E61D2A831634C123360A5.Helpers.tableReader_7aa2f793630a46d2bab705e24386f9cd_Greedy<TInputBuffer> GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, StrokeSyncBeginRemote value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(StrokeSyncBeginRemote? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(StrokeSyncBeginRemote? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(StrokeSyncBeginRemote[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<StrokeSyncBeginRemote> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(StrokeSyncBeginRemote item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, StrokeSyncBeginRemote item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(StrokeSyncBeginRemote item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ StrokeSyncBeginRemote ], Count = {Count}")]
	internal sealed class GeneratedVector_05459a461aa77f6964b322ee4b4223c2_GreedyMutable<TInputBuffer> : IList<StrokeSyncBeginRemote>, ICollection<StrokeSyncBeginRemote>, IEnumerable<StrokeSyncBeginRemote>, IEnumerable, IReadOnlyList<StrokeSyncBeginRemote>, IReadOnlyCollection<StrokeSyncBeginRemote> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<StrokeSyncBeginRemote> list;

		public StrokeSyncBeginRemote this[int index]
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

		public GeneratedVector_05459a461aa77f6964b322ee4b4223c2_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<StrokeSyncBeginRemote> list = (this.list = new List<StrokeSyncBeginRemote>());
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.N019847E8E25C20AF1F45BD04EBDAE12ACF40CFF58D0E61D2A831634C123360A5.Helpers.tableReader_7aa2f793630a46d2bab705e24386f9cd_GreedyMutable<TInputBuffer> item = FlatSharp.Compiler.Generated.N019847E8E25C20AF1F45BD04EBDAE12ACF40CFF58D0E61D2A831634C123360A5.Helpers.Parse_GreedyMutable(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private StrokeSyncBeginRemote GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, StrokeSyncBeginRemote value)
		{
			list[index] = value;
		}

		public void Add(StrokeSyncBeginRemote item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, StrokeSyncBeginRemote item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(StrokeSyncBeginRemote item)
		{
			return list.Remove(item);
		}

		public bool Contains(StrokeSyncBeginRemote? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(StrokeSyncBeginRemote? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(StrokeSyncBeginRemote[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<StrokeSyncBeginRemote> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<StrokeSyncBeginRemote> value)
	{
		int count = value.Count;
		int num = 14;
		if (value is StrokeSyncBeginRemote[] array)
		{
			foreach (StrokeSyncBeginRemote strokeSyncBeginRemote in array)
			{
				SerializationHelpers.EnsureNonNull(strokeSyncBeginRemote);
				num += FlatSharp.Compiler.Generated.N019847E8E25C20AF1F45BD04EBDAE12ACF40CFF58D0E61D2A831634C123360A5.Helpers.GetMaxSize(strokeSyncBeginRemote);
			}
		}
		else if (value is List<StrokeSyncBeginRemote> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				StrokeSyncBeginRemote strokeSyncBeginRemote2 = list[j];
				SerializationHelpers.EnsureNonNull(strokeSyncBeginRemote2);
				num += FlatSharp.Compiler.Generated.N019847E8E25C20AF1F45BD04EBDAE12ACF40CFF58D0E61D2A831634C123360A5.Helpers.GetMaxSize(strokeSyncBeginRemote2);
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				StrokeSyncBeginRemote strokeSyncBeginRemote3 = value[k];
				SerializationHelpers.EnsureNonNull(strokeSyncBeginRemote3);
				num += FlatSharp.Compiler.Generated.N019847E8E25C20AF1F45BD04EBDAE12ACF40CFF58D0E61D2A831634C123360A5.Helpers.GetMaxSize(strokeSyncBeginRemote3);
			}
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<StrokeSyncBeginRemote> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 4);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is StrokeSyncBeginRemote[] array)
		{
			foreach (StrokeSyncBeginRemote strokeSyncBeginRemote in array)
			{
				SerializationHelpers.EnsureNonNull(strokeSyncBeginRemote);
				FlatSharp.Compiler.Generated.N019847E8E25C20AF1F45BD04EBDAE12ACF40CFF58D0E61D2A831634C123360A5.Helpers.Serialize(spanWriter, span, strokeSyncBeginRemote, num, context);
				num += 4;
			}
		}
		else if (value is List<StrokeSyncBeginRemote> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				StrokeSyncBeginRemote strokeSyncBeginRemote2 = list[j];
				SerializationHelpers.EnsureNonNull(strokeSyncBeginRemote2);
				FlatSharp.Compiler.Generated.N019847E8E25C20AF1F45BD04EBDAE12ACF40CFF58D0E61D2A831634C123360A5.Helpers.Serialize(spanWriter, span, strokeSyncBeginRemote2, num, context);
				num += 4;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				StrokeSyncBeginRemote strokeSyncBeginRemote3 = value[k];
				SerializationHelpers.EnsureNonNull(strokeSyncBeginRemote3);
				FlatSharp.Compiler.Generated.N019847E8E25C20AF1F45BD04EBDAE12ACF40CFF58D0E61D2A831634C123360A5.Helpers.Serialize(spanWriter, span, strokeSyncBeginRemote3, num, context);
				num += 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<StrokeSyncBeginRemote> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_05459a461aa77f6964b322ee4b4223c2_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<StrokeSyncBeginRemote> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_05459a461aa77f6964b322ee4b4223c2_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<StrokeSyncBeginRemote> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_05459a461aa77f6964b322ee4b4223c2_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<StrokeSyncBeginRemote> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_05459a461aa77f6964b322ee4b4223c2_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
