using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Sequencer;
using FlatSharp.Compiler.Generated.NCCFFD647267A08A6E34854A3D524449C12CA9A7650D1997A8C7184B712D23282;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N7C1DE378845D89D200FF1AC4179E57E6DA50A9979AB971108CEF1AF1E57F41FB;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ Marker ], Count = {Count}")]
	internal sealed class GeneratedVector_113cbdb741f241dc939b43bc7e8fc508_Lazy<TInputBuffer> : IList<Marker>, ICollection<Marker>, IEnumerable<Marker>, IEnumerable, IReadOnlyList<Marker>, IReadOnlyCollection<Marker>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public Marker this[int index]
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

		public GeneratedVector_113cbdb741f241dc939b43bc7e8fc508_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NCCFFD647267A08A6E34854A3D524449C12CA9A7650D1997A8C7184B712D23282.Helpers.tableReader_52c5ca68c8ac4ea1b320dfbab8047d50_Lazy<TInputBuffer> SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NCCFFD647267A08A6E34854A3D524449C12CA9A7650D1997A8C7184B712D23282.Helpers.tableReader_52c5ca68c8ac4ea1b320dfbab8047d50_Lazy<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return FlatSharp.Compiler.Generated.NCCFFD647267A08A6E34854A3D524449C12CA9A7650D1997A8C7184B712D23282.Helpers.Parse_Lazy(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, Marker value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(Marker? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(Marker? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(Marker[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<Marker> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(Marker item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, Marker item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(Marker item)
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

	[DebuggerDisplay("Progressive [ Marker ], Count = {Count}")]
	internal sealed class GeneratedVector_113cbdb741f241dc939b43bc7e8fc508_Progressive<TInputBuffer> : IList<Marker>, ICollection<Marker>, IEnumerable<Marker>, IEnumerable, IReadOnlyList<Marker>, IReadOnlyCollection<Marker>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly FlatSharp.Compiler.Generated.NCCFFD647267A08A6E34854A3D524449C12CA9A7650D1997A8C7184B712D23282.Helpers.tableReader_52c5ca68c8ac4ea1b320dfbab8047d50_Progressive<TInputBuffer>?[]?[] items;

		public Marker this[int index]
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

		public GeneratedVector_113cbdb741f241dc939b43bc7e8fc508_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new FlatSharp.Compiler.Generated.NCCFFD647267A08A6E34854A3D524449C12CA9A7650D1997A8C7184B712D23282.Helpers.tableReader_52c5ca68c8ac4ea1b320dfbab8047d50_Progressive<TInputBuffer>[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NCCFFD647267A08A6E34854A3D524449C12CA9A7650D1997A8C7184B712D23282.Helpers.tableReader_52c5ca68c8ac4ea1b320dfbab8047d50_Progressive<TInputBuffer>?[] GetOrCreateRow(FlatSharp.Compiler.Generated.NCCFFD647267A08A6E34854A3D524449C12CA9A7650D1997A8C7184B712D23282.Helpers.tableReader_52c5ca68c8ac4ea1b320dfbab8047d50_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private FlatSharp.Compiler.Generated.NCCFFD647267A08A6E34854A3D524449C12CA9A7650D1997A8C7184B712D23282.Helpers.tableReader_52c5ca68c8ac4ea1b320dfbab8047d50_Progressive<TInputBuffer>?[] CreateRow(FlatSharp.Compiler.Generated.NCCFFD647267A08A6E34854A3D524449C12CA9A7650D1997A8C7184B712D23282.Helpers.tableReader_52c5ca68c8ac4ea1b320dfbab8047d50_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] = new FlatSharp.Compiler.Generated.NCCFFD647267A08A6E34854A3D524449C12CA9A7650D1997A8C7184B712D23282.Helpers.tableReader_52c5ca68c8ac4ea1b320dfbab8047d50_Progressive<TInputBuffer>[32];
		}

		private FlatSharp.Compiler.Generated.NCCFFD647267A08A6E34854A3D524449C12CA9A7650D1997A8C7184B712D23282.Helpers.tableReader_52c5ca68c8ac4ea1b320dfbab8047d50_Progressive<TInputBuffer> ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			FlatSharp.Compiler.Generated.NCCFFD647267A08A6E34854A3D524449C12CA9A7650D1997A8C7184B712D23282.Helpers.tableReader_52c5ca68c8ac4ea1b320dfbab8047d50_Progressive<TInputBuffer>[][] array = items;
			FlatSharp.Compiler.Generated.NCCFFD647267A08A6E34854A3D524449C12CA9A7650D1997A8C7184B712D23282.Helpers.tableReader_52c5ca68c8ac4ea1b320dfbab8047d50_Progressive<TInputBuffer>[] orCreateRow = GetOrCreateRow(array, rowIndex);
			FlatSharp.Compiler.Generated.NCCFFD647267A08A6E34854A3D524449C12CA9A7650D1997A8C7184B712D23282.Helpers.tableReader_52c5ca68c8ac4ea1b320dfbab8047d50_Progressive<TInputBuffer> tableReader_52c5ca68c8ac4ea1b320dfbab8047d50_Progressive = orCreateRow[colIndex];
			if (tableReader_52c5ca68c8ac4ea1b320dfbab8047d50_Progressive == null)
			{
				tableReader_52c5ca68c8ac4ea1b320dfbab8047d50_Progressive = (orCreateRow[colIndex] = UnsafeParseItem(index));
			}
			return tableReader_52c5ca68c8ac4ea1b320dfbab8047d50_Progressive;
		}

		private void ProgressiveSet(int index, Marker value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, Marker value)
		{
			VectorUtilities.CheckIndex(index, count);
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NCCFFD647267A08A6E34854A3D524449C12CA9A7650D1997A8C7184B712D23282.Helpers.tableReader_52c5ca68c8ac4ea1b320dfbab8047d50_Progressive<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NCCFFD647267A08A6E34854A3D524449C12CA9A7650D1997A8C7184B712D23282.Helpers.tableReader_52c5ca68c8ac4ea1b320dfbab8047d50_Progressive<TInputBuffer> UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.NCCFFD647267A08A6E34854A3D524449C12CA9A7650D1997A8C7184B712D23282.Helpers.Parse_Progressive(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, Marker value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(Marker? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(Marker? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(Marker[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<Marker> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(Marker item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, Marker item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(Marker item)
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

	[DebuggerDisplay("Greedy [ Marker ], Count = {Count}")]
	internal sealed class GeneratedVector_113cbdb741f241dc939b43bc7e8fc508_Greedy<TInputBuffer> : IList<Marker>, ICollection<Marker>, IEnumerable<Marker>, IEnumerable, IReadOnlyList<Marker>, IReadOnlyCollection<Marker> where TInputBuffer : IInputBuffer
	{
		private readonly List<FlatSharp.Compiler.Generated.NCCFFD647267A08A6E34854A3D524449C12CA9A7650D1997A8C7184B712D23282.Helpers.tableReader_52c5ca68c8ac4ea1b320dfbab8047d50_Greedy<TInputBuffer>> list;

		public Marker this[int index]
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

		public GeneratedVector_113cbdb741f241dc939b43bc7e8fc508_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<FlatSharp.Compiler.Generated.NCCFFD647267A08A6E34854A3D524449C12CA9A7650D1997A8C7184B712D23282.Helpers.tableReader_52c5ca68c8ac4ea1b320dfbab8047d50_Greedy<TInputBuffer>> list = (this.list = new List<FlatSharp.Compiler.Generated.NCCFFD647267A08A6E34854A3D524449C12CA9A7650D1997A8C7184B712D23282.Helpers.tableReader_52c5ca68c8ac4ea1b320dfbab8047d50_Greedy<TInputBuffer>>(num));
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.NCCFFD647267A08A6E34854A3D524449C12CA9A7650D1997A8C7184B712D23282.Helpers.tableReader_52c5ca68c8ac4ea1b320dfbab8047d50_Greedy<TInputBuffer> item = FlatSharp.Compiler.Generated.NCCFFD647267A08A6E34854A3D524449C12CA9A7650D1997A8C7184B712D23282.Helpers.Parse_Greedy(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		private FlatSharp.Compiler.Generated.NCCFFD647267A08A6E34854A3D524449C12CA9A7650D1997A8C7184B712D23282.Helpers.tableReader_52c5ca68c8ac4ea1b320dfbab8047d50_Greedy<TInputBuffer> GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, Marker value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(Marker? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(Marker? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(Marker[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<Marker> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(Marker item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, Marker item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(Marker item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ Marker ], Count = {Count}")]
	internal sealed class GeneratedVector_113cbdb741f241dc939b43bc7e8fc508_GreedyMutable<TInputBuffer> : IList<Marker>, ICollection<Marker>, IEnumerable<Marker>, IEnumerable, IReadOnlyList<Marker>, IReadOnlyCollection<Marker> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<Marker> list;

		public Marker this[int index]
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

		public GeneratedVector_113cbdb741f241dc939b43bc7e8fc508_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<Marker> list = (this.list = new List<Marker>());
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.NCCFFD647267A08A6E34854A3D524449C12CA9A7650D1997A8C7184B712D23282.Helpers.tableReader_52c5ca68c8ac4ea1b320dfbab8047d50_GreedyMutable<TInputBuffer> item = FlatSharp.Compiler.Generated.NCCFFD647267A08A6E34854A3D524449C12CA9A7650D1997A8C7184B712D23282.Helpers.Parse_GreedyMutable(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private Marker GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, Marker value)
		{
			list[index] = value;
		}

		public void Add(Marker item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, Marker item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(Marker item)
		{
			return list.Remove(item);
		}

		public bool Contains(Marker? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(Marker? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(Marker[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<Marker> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<Marker> value)
	{
		int count = value.Count;
		int num = 14;
		if (value is Marker[] array)
		{
			foreach (Marker marker in array)
			{
				SerializationHelpers.EnsureNonNull(marker);
				num += FlatSharp.Compiler.Generated.NCCFFD647267A08A6E34854A3D524449C12CA9A7650D1997A8C7184B712D23282.Helpers.GetMaxSize(marker);
			}
		}
		else if (value is List<Marker> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				Marker marker2 = list[j];
				SerializationHelpers.EnsureNonNull(marker2);
				num += FlatSharp.Compiler.Generated.NCCFFD647267A08A6E34854A3D524449C12CA9A7650D1997A8C7184B712D23282.Helpers.GetMaxSize(marker2);
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				Marker marker3 = value[k];
				SerializationHelpers.EnsureNonNull(marker3);
				num += FlatSharp.Compiler.Generated.NCCFFD647267A08A6E34854A3D524449C12CA9A7650D1997A8C7184B712D23282.Helpers.GetMaxSize(marker3);
			}
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<Marker> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 4);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is Marker[] array)
		{
			foreach (Marker marker in array)
			{
				SerializationHelpers.EnsureNonNull(marker);
				FlatSharp.Compiler.Generated.NCCFFD647267A08A6E34854A3D524449C12CA9A7650D1997A8C7184B712D23282.Helpers.Serialize(spanWriter, span, marker, num, context);
				num += 4;
			}
		}
		else if (value is List<Marker> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				Marker marker2 = list[j];
				SerializationHelpers.EnsureNonNull(marker2);
				FlatSharp.Compiler.Generated.NCCFFD647267A08A6E34854A3D524449C12CA9A7650D1997A8C7184B712D23282.Helpers.Serialize(spanWriter, span, marker2, num, context);
				num += 4;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				Marker marker3 = value[k];
				SerializationHelpers.EnsureNonNull(marker3);
				FlatSharp.Compiler.Generated.NCCFFD647267A08A6E34854A3D524449C12CA9A7650D1997A8C7184B712D23282.Helpers.Serialize(spanWriter, span, marker3, num, context);
				num += 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<Marker> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_113cbdb741f241dc939b43bc7e8fc508_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<Marker> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_113cbdb741f241dc939b43bc7e8fc508_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<Marker> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_113cbdb741f241dc939b43bc7e8fc508_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<Marker> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_113cbdb741f241dc939b43bc7e8fc508_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
