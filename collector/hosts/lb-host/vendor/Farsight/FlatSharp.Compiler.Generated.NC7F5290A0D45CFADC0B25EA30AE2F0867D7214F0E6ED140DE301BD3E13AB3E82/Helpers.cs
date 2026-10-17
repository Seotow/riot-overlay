using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Commands;
using FlatSharp.Compiler.Generated.N8E91FCCE8F44E8FC2DB97EAACF3C381BCDA33FE55421526745A51B3A02166220;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.NC7F5290A0D45CFADC0B25EA30AE2F0867D7214F0E6ED140DE301BD3E13AB3E82;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ AssetCreate ], Count = {Count}")]
	internal sealed class GeneratedVector_b815b7fda2a97bc59732b55576196900_Lazy<TInputBuffer> : IList<AssetCreate>, ICollection<AssetCreate>, IEnumerable<AssetCreate>, IEnumerable, IReadOnlyList<AssetCreate>, IReadOnlyCollection<AssetCreate>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public AssetCreate this[int index]
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

		public GeneratedVector_b815b7fda2a97bc59732b55576196900_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N8E91FCCE8F44E8FC2DB97EAACF3C381BCDA33FE55421526745A51B3A02166220.Helpers.tableReader_22ce64c92de84c1ab874914611e0c441_Lazy<TInputBuffer> SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N8E91FCCE8F44E8FC2DB97EAACF3C381BCDA33FE55421526745A51B3A02166220.Helpers.tableReader_22ce64c92de84c1ab874914611e0c441_Lazy<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return FlatSharp.Compiler.Generated.N8E91FCCE8F44E8FC2DB97EAACF3C381BCDA33FE55421526745A51B3A02166220.Helpers.Parse_Lazy(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, AssetCreate value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(AssetCreate? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(AssetCreate? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(AssetCreate[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<AssetCreate> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(AssetCreate item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, AssetCreate item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(AssetCreate item)
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

	[DebuggerDisplay("Progressive [ AssetCreate ], Count = {Count}")]
	internal sealed class GeneratedVector_b815b7fda2a97bc59732b55576196900_Progressive<TInputBuffer> : IList<AssetCreate>, ICollection<AssetCreate>, IEnumerable<AssetCreate>, IEnumerable, IReadOnlyList<AssetCreate>, IReadOnlyCollection<AssetCreate>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly FlatSharp.Compiler.Generated.N8E91FCCE8F44E8FC2DB97EAACF3C381BCDA33FE55421526745A51B3A02166220.Helpers.tableReader_22ce64c92de84c1ab874914611e0c441_Progressive<TInputBuffer>?[]?[] items;

		public AssetCreate this[int index]
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

		public GeneratedVector_b815b7fda2a97bc59732b55576196900_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new FlatSharp.Compiler.Generated.N8E91FCCE8F44E8FC2DB97EAACF3C381BCDA33FE55421526745A51B3A02166220.Helpers.tableReader_22ce64c92de84c1ab874914611e0c441_Progressive<TInputBuffer>[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N8E91FCCE8F44E8FC2DB97EAACF3C381BCDA33FE55421526745A51B3A02166220.Helpers.tableReader_22ce64c92de84c1ab874914611e0c441_Progressive<TInputBuffer>?[] GetOrCreateRow(FlatSharp.Compiler.Generated.N8E91FCCE8F44E8FC2DB97EAACF3C381BCDA33FE55421526745A51B3A02166220.Helpers.tableReader_22ce64c92de84c1ab874914611e0c441_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private FlatSharp.Compiler.Generated.N8E91FCCE8F44E8FC2DB97EAACF3C381BCDA33FE55421526745A51B3A02166220.Helpers.tableReader_22ce64c92de84c1ab874914611e0c441_Progressive<TInputBuffer>?[] CreateRow(FlatSharp.Compiler.Generated.N8E91FCCE8F44E8FC2DB97EAACF3C381BCDA33FE55421526745A51B3A02166220.Helpers.tableReader_22ce64c92de84c1ab874914611e0c441_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] = new FlatSharp.Compiler.Generated.N8E91FCCE8F44E8FC2DB97EAACF3C381BCDA33FE55421526745A51B3A02166220.Helpers.tableReader_22ce64c92de84c1ab874914611e0c441_Progressive<TInputBuffer>[32];
		}

		private FlatSharp.Compiler.Generated.N8E91FCCE8F44E8FC2DB97EAACF3C381BCDA33FE55421526745A51B3A02166220.Helpers.tableReader_22ce64c92de84c1ab874914611e0c441_Progressive<TInputBuffer> ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			FlatSharp.Compiler.Generated.N8E91FCCE8F44E8FC2DB97EAACF3C381BCDA33FE55421526745A51B3A02166220.Helpers.tableReader_22ce64c92de84c1ab874914611e0c441_Progressive<TInputBuffer>[][] array = items;
			FlatSharp.Compiler.Generated.N8E91FCCE8F44E8FC2DB97EAACF3C381BCDA33FE55421526745A51B3A02166220.Helpers.tableReader_22ce64c92de84c1ab874914611e0c441_Progressive<TInputBuffer>[] orCreateRow = GetOrCreateRow(array, rowIndex);
			FlatSharp.Compiler.Generated.N8E91FCCE8F44E8FC2DB97EAACF3C381BCDA33FE55421526745A51B3A02166220.Helpers.tableReader_22ce64c92de84c1ab874914611e0c441_Progressive<TInputBuffer> tableReader_22ce64c92de84c1ab874914611e0c441_Progressive = orCreateRow[colIndex];
			if (tableReader_22ce64c92de84c1ab874914611e0c441_Progressive == null)
			{
				tableReader_22ce64c92de84c1ab874914611e0c441_Progressive = (orCreateRow[colIndex] = UnsafeParseItem(index));
			}
			return tableReader_22ce64c92de84c1ab874914611e0c441_Progressive;
		}

		private void ProgressiveSet(int index, AssetCreate value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, AssetCreate value)
		{
			VectorUtilities.CheckIndex(index, count);
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N8E91FCCE8F44E8FC2DB97EAACF3C381BCDA33FE55421526745A51B3A02166220.Helpers.tableReader_22ce64c92de84c1ab874914611e0c441_Progressive<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N8E91FCCE8F44E8FC2DB97EAACF3C381BCDA33FE55421526745A51B3A02166220.Helpers.tableReader_22ce64c92de84c1ab874914611e0c441_Progressive<TInputBuffer> UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.N8E91FCCE8F44E8FC2DB97EAACF3C381BCDA33FE55421526745A51B3A02166220.Helpers.Parse_Progressive(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, AssetCreate value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(AssetCreate? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(AssetCreate? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(AssetCreate[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<AssetCreate> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(AssetCreate item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, AssetCreate item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(AssetCreate item)
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

	[DebuggerDisplay("Greedy [ AssetCreate ], Count = {Count}")]
	internal sealed class GeneratedVector_b815b7fda2a97bc59732b55576196900_Greedy<TInputBuffer> : IList<AssetCreate>, ICollection<AssetCreate>, IEnumerable<AssetCreate>, IEnumerable, IReadOnlyList<AssetCreate>, IReadOnlyCollection<AssetCreate> where TInputBuffer : IInputBuffer
	{
		private readonly List<FlatSharp.Compiler.Generated.N8E91FCCE8F44E8FC2DB97EAACF3C381BCDA33FE55421526745A51B3A02166220.Helpers.tableReader_22ce64c92de84c1ab874914611e0c441_Greedy<TInputBuffer>> list;

		public AssetCreate this[int index]
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

		public GeneratedVector_b815b7fda2a97bc59732b55576196900_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<FlatSharp.Compiler.Generated.N8E91FCCE8F44E8FC2DB97EAACF3C381BCDA33FE55421526745A51B3A02166220.Helpers.tableReader_22ce64c92de84c1ab874914611e0c441_Greedy<TInputBuffer>> list = (this.list = new List<FlatSharp.Compiler.Generated.N8E91FCCE8F44E8FC2DB97EAACF3C381BCDA33FE55421526745A51B3A02166220.Helpers.tableReader_22ce64c92de84c1ab874914611e0c441_Greedy<TInputBuffer>>(num));
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.N8E91FCCE8F44E8FC2DB97EAACF3C381BCDA33FE55421526745A51B3A02166220.Helpers.tableReader_22ce64c92de84c1ab874914611e0c441_Greedy<TInputBuffer> item = FlatSharp.Compiler.Generated.N8E91FCCE8F44E8FC2DB97EAACF3C381BCDA33FE55421526745A51B3A02166220.Helpers.Parse_Greedy(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		private FlatSharp.Compiler.Generated.N8E91FCCE8F44E8FC2DB97EAACF3C381BCDA33FE55421526745A51B3A02166220.Helpers.tableReader_22ce64c92de84c1ab874914611e0c441_Greedy<TInputBuffer> GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, AssetCreate value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(AssetCreate? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(AssetCreate? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(AssetCreate[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<AssetCreate> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(AssetCreate item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, AssetCreate item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(AssetCreate item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ AssetCreate ], Count = {Count}")]
	internal sealed class GeneratedVector_b815b7fda2a97bc59732b55576196900_GreedyMutable<TInputBuffer> : IList<AssetCreate>, ICollection<AssetCreate>, IEnumerable<AssetCreate>, IEnumerable, IReadOnlyList<AssetCreate>, IReadOnlyCollection<AssetCreate> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<AssetCreate> list;

		public AssetCreate this[int index]
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

		public GeneratedVector_b815b7fda2a97bc59732b55576196900_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<AssetCreate> list = (this.list = new List<AssetCreate>());
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.N8E91FCCE8F44E8FC2DB97EAACF3C381BCDA33FE55421526745A51B3A02166220.Helpers.tableReader_22ce64c92de84c1ab874914611e0c441_GreedyMutable<TInputBuffer> item = FlatSharp.Compiler.Generated.N8E91FCCE8F44E8FC2DB97EAACF3C381BCDA33FE55421526745A51B3A02166220.Helpers.Parse_GreedyMutable(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private AssetCreate GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, AssetCreate value)
		{
			list[index] = value;
		}

		public void Add(AssetCreate item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, AssetCreate item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(AssetCreate item)
		{
			return list.Remove(item);
		}

		public bool Contains(AssetCreate? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(AssetCreate? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(AssetCreate[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<AssetCreate> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<AssetCreate> value)
	{
		int count = value.Count;
		int num = 14;
		if (value is AssetCreate[] array)
		{
			foreach (AssetCreate assetCreate in array)
			{
				SerializationHelpers.EnsureNonNull(assetCreate);
				num += FlatSharp.Compiler.Generated.N8E91FCCE8F44E8FC2DB97EAACF3C381BCDA33FE55421526745A51B3A02166220.Helpers.GetMaxSize(assetCreate);
			}
		}
		else if (value is List<AssetCreate> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				AssetCreate assetCreate2 = list[j];
				SerializationHelpers.EnsureNonNull(assetCreate2);
				num += FlatSharp.Compiler.Generated.N8E91FCCE8F44E8FC2DB97EAACF3C381BCDA33FE55421526745A51B3A02166220.Helpers.GetMaxSize(assetCreate2);
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				AssetCreate assetCreate3 = value[k];
				SerializationHelpers.EnsureNonNull(assetCreate3);
				num += FlatSharp.Compiler.Generated.N8E91FCCE8F44E8FC2DB97EAACF3C381BCDA33FE55421526745A51B3A02166220.Helpers.GetMaxSize(assetCreate3);
			}
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<AssetCreate> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 4);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is AssetCreate[] array)
		{
			foreach (AssetCreate assetCreate in array)
			{
				SerializationHelpers.EnsureNonNull(assetCreate);
				FlatSharp.Compiler.Generated.N8E91FCCE8F44E8FC2DB97EAACF3C381BCDA33FE55421526745A51B3A02166220.Helpers.Serialize(spanWriter, span, assetCreate, num, context);
				num += 4;
			}
		}
		else if (value is List<AssetCreate> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				AssetCreate assetCreate2 = list[j];
				SerializationHelpers.EnsureNonNull(assetCreate2);
				FlatSharp.Compiler.Generated.N8E91FCCE8F44E8FC2DB97EAACF3C381BCDA33FE55421526745A51B3A02166220.Helpers.Serialize(spanWriter, span, assetCreate2, num, context);
				num += 4;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				AssetCreate assetCreate3 = value[k];
				SerializationHelpers.EnsureNonNull(assetCreate3);
				FlatSharp.Compiler.Generated.N8E91FCCE8F44E8FC2DB97EAACF3C381BCDA33FE55421526745A51B3A02166220.Helpers.Serialize(spanWriter, span, assetCreate3, num, context);
				num += 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<AssetCreate> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_b815b7fda2a97bc59732b55576196900_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<AssetCreate> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_b815b7fda2a97bc59732b55576196900_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<AssetCreate> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_b815b7fda2a97bc59732b55576196900_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<AssetCreate> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_b815b7fda2a97bc59732b55576196900_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
