using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Sequencer;
using FlatSharp.Compiler.Generated.N6DBF9991D0AE1CE3ED227D7AB772014454D1BC766AA1C077F8CCF50E6408764D;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.ND07EC9BF1CC28A851274CFE10B6F3BD2A74D1714B4681D682E39E89E4E3C484C;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ Track ], Count = {Count}")]
	internal sealed class GeneratedVector_07d328ac5a93a2e9ace5f709925b95e0_Lazy<TInputBuffer> : IList<Track>, ICollection<Track>, IEnumerable<Track>, IEnumerable, IReadOnlyList<Track>, IReadOnlyCollection<Track>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public Track this[int index]
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

		public GeneratedVector_07d328ac5a93a2e9ace5f709925b95e0_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N6DBF9991D0AE1CE3ED227D7AB772014454D1BC766AA1C077F8CCF50E6408764D.Helpers.tableReader_00988eb81b19457ca4cf470ddc89023d_Lazy<TInputBuffer> SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N6DBF9991D0AE1CE3ED227D7AB772014454D1BC766AA1C077F8CCF50E6408764D.Helpers.tableReader_00988eb81b19457ca4cf470ddc89023d_Lazy<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return FlatSharp.Compiler.Generated.N6DBF9991D0AE1CE3ED227D7AB772014454D1BC766AA1C077F8CCF50E6408764D.Helpers.Parse_Lazy(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, Track value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(Track? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(Track? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(Track[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<Track> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(Track item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, Track item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(Track item)
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

	[DebuggerDisplay("Progressive [ Track ], Count = {Count}")]
	internal sealed class GeneratedVector_07d328ac5a93a2e9ace5f709925b95e0_Progressive<TInputBuffer> : IList<Track>, ICollection<Track>, IEnumerable<Track>, IEnumerable, IReadOnlyList<Track>, IReadOnlyCollection<Track>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly FlatSharp.Compiler.Generated.N6DBF9991D0AE1CE3ED227D7AB772014454D1BC766AA1C077F8CCF50E6408764D.Helpers.tableReader_00988eb81b19457ca4cf470ddc89023d_Progressive<TInputBuffer>?[]?[] items;

		public Track this[int index]
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

		public GeneratedVector_07d328ac5a93a2e9ace5f709925b95e0_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new FlatSharp.Compiler.Generated.N6DBF9991D0AE1CE3ED227D7AB772014454D1BC766AA1C077F8CCF50E6408764D.Helpers.tableReader_00988eb81b19457ca4cf470ddc89023d_Progressive<TInputBuffer>[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N6DBF9991D0AE1CE3ED227D7AB772014454D1BC766AA1C077F8CCF50E6408764D.Helpers.tableReader_00988eb81b19457ca4cf470ddc89023d_Progressive<TInputBuffer>?[] GetOrCreateRow(FlatSharp.Compiler.Generated.N6DBF9991D0AE1CE3ED227D7AB772014454D1BC766AA1C077F8CCF50E6408764D.Helpers.tableReader_00988eb81b19457ca4cf470ddc89023d_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private FlatSharp.Compiler.Generated.N6DBF9991D0AE1CE3ED227D7AB772014454D1BC766AA1C077F8CCF50E6408764D.Helpers.tableReader_00988eb81b19457ca4cf470ddc89023d_Progressive<TInputBuffer>?[] CreateRow(FlatSharp.Compiler.Generated.N6DBF9991D0AE1CE3ED227D7AB772014454D1BC766AA1C077F8CCF50E6408764D.Helpers.tableReader_00988eb81b19457ca4cf470ddc89023d_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] = new FlatSharp.Compiler.Generated.N6DBF9991D0AE1CE3ED227D7AB772014454D1BC766AA1C077F8CCF50E6408764D.Helpers.tableReader_00988eb81b19457ca4cf470ddc89023d_Progressive<TInputBuffer>[32];
		}

		private FlatSharp.Compiler.Generated.N6DBF9991D0AE1CE3ED227D7AB772014454D1BC766AA1C077F8CCF50E6408764D.Helpers.tableReader_00988eb81b19457ca4cf470ddc89023d_Progressive<TInputBuffer> ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			FlatSharp.Compiler.Generated.N6DBF9991D0AE1CE3ED227D7AB772014454D1BC766AA1C077F8CCF50E6408764D.Helpers.tableReader_00988eb81b19457ca4cf470ddc89023d_Progressive<TInputBuffer>[][] array = items;
			FlatSharp.Compiler.Generated.N6DBF9991D0AE1CE3ED227D7AB772014454D1BC766AA1C077F8CCF50E6408764D.Helpers.tableReader_00988eb81b19457ca4cf470ddc89023d_Progressive<TInputBuffer>[] orCreateRow = GetOrCreateRow(array, rowIndex);
			FlatSharp.Compiler.Generated.N6DBF9991D0AE1CE3ED227D7AB772014454D1BC766AA1C077F8CCF50E6408764D.Helpers.tableReader_00988eb81b19457ca4cf470ddc89023d_Progressive<TInputBuffer> tableReader_00988eb81b19457ca4cf470ddc89023d_Progressive = orCreateRow[colIndex];
			if (tableReader_00988eb81b19457ca4cf470ddc89023d_Progressive == null)
			{
				tableReader_00988eb81b19457ca4cf470ddc89023d_Progressive = (orCreateRow[colIndex] = UnsafeParseItem(index));
			}
			return tableReader_00988eb81b19457ca4cf470ddc89023d_Progressive;
		}

		private void ProgressiveSet(int index, Track value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, Track value)
		{
			VectorUtilities.CheckIndex(index, count);
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N6DBF9991D0AE1CE3ED227D7AB772014454D1BC766AA1C077F8CCF50E6408764D.Helpers.tableReader_00988eb81b19457ca4cf470ddc89023d_Progressive<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N6DBF9991D0AE1CE3ED227D7AB772014454D1BC766AA1C077F8CCF50E6408764D.Helpers.tableReader_00988eb81b19457ca4cf470ddc89023d_Progressive<TInputBuffer> UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.N6DBF9991D0AE1CE3ED227D7AB772014454D1BC766AA1C077F8CCF50E6408764D.Helpers.Parse_Progressive(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, Track value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(Track? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(Track? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(Track[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<Track> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(Track item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, Track item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(Track item)
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

	[DebuggerDisplay("Greedy [ Track ], Count = {Count}")]
	internal sealed class GeneratedVector_07d328ac5a93a2e9ace5f709925b95e0_Greedy<TInputBuffer> : IList<Track>, ICollection<Track>, IEnumerable<Track>, IEnumerable, IReadOnlyList<Track>, IReadOnlyCollection<Track> where TInputBuffer : IInputBuffer
	{
		private readonly List<FlatSharp.Compiler.Generated.N6DBF9991D0AE1CE3ED227D7AB772014454D1BC766AA1C077F8CCF50E6408764D.Helpers.tableReader_00988eb81b19457ca4cf470ddc89023d_Greedy<TInputBuffer>> list;

		public Track this[int index]
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

		public GeneratedVector_07d328ac5a93a2e9ace5f709925b95e0_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<FlatSharp.Compiler.Generated.N6DBF9991D0AE1CE3ED227D7AB772014454D1BC766AA1C077F8CCF50E6408764D.Helpers.tableReader_00988eb81b19457ca4cf470ddc89023d_Greedy<TInputBuffer>> list = (this.list = new List<FlatSharp.Compiler.Generated.N6DBF9991D0AE1CE3ED227D7AB772014454D1BC766AA1C077F8CCF50E6408764D.Helpers.tableReader_00988eb81b19457ca4cf470ddc89023d_Greedy<TInputBuffer>>(num));
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.N6DBF9991D0AE1CE3ED227D7AB772014454D1BC766AA1C077F8CCF50E6408764D.Helpers.tableReader_00988eb81b19457ca4cf470ddc89023d_Greedy<TInputBuffer> item = FlatSharp.Compiler.Generated.N6DBF9991D0AE1CE3ED227D7AB772014454D1BC766AA1C077F8CCF50E6408764D.Helpers.Parse_Greedy(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		private FlatSharp.Compiler.Generated.N6DBF9991D0AE1CE3ED227D7AB772014454D1BC766AA1C077F8CCF50E6408764D.Helpers.tableReader_00988eb81b19457ca4cf470ddc89023d_Greedy<TInputBuffer> GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, Track value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(Track? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(Track? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(Track[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<Track> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(Track item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, Track item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(Track item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ Track ], Count = {Count}")]
	internal sealed class GeneratedVector_07d328ac5a93a2e9ace5f709925b95e0_GreedyMutable<TInputBuffer> : IList<Track>, ICollection<Track>, IEnumerable<Track>, IEnumerable, IReadOnlyList<Track>, IReadOnlyCollection<Track> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<Track> list;

		public Track this[int index]
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

		public GeneratedVector_07d328ac5a93a2e9ace5f709925b95e0_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<Track> list = (this.list = new List<Track>());
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.N6DBF9991D0AE1CE3ED227D7AB772014454D1BC766AA1C077F8CCF50E6408764D.Helpers.tableReader_00988eb81b19457ca4cf470ddc89023d_GreedyMutable<TInputBuffer> item = FlatSharp.Compiler.Generated.N6DBF9991D0AE1CE3ED227D7AB772014454D1BC766AA1C077F8CCF50E6408764D.Helpers.Parse_GreedyMutable(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private Track GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, Track value)
		{
			list[index] = value;
		}

		public void Add(Track item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, Track item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(Track item)
		{
			return list.Remove(item);
		}

		public bool Contains(Track? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(Track? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(Track[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<Track> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<Track> value)
	{
		int count = value.Count;
		int num = 14;
		if (value is Track[] array)
		{
			foreach (Track track in array)
			{
				SerializationHelpers.EnsureNonNull(track);
				num += FlatSharp.Compiler.Generated.N6DBF9991D0AE1CE3ED227D7AB772014454D1BC766AA1C077F8CCF50E6408764D.Helpers.GetMaxSize(track);
			}
		}
		else if (value is List<Track> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				Track track2 = list[j];
				SerializationHelpers.EnsureNonNull(track2);
				num += FlatSharp.Compiler.Generated.N6DBF9991D0AE1CE3ED227D7AB772014454D1BC766AA1C077F8CCF50E6408764D.Helpers.GetMaxSize(track2);
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				Track track3 = value[k];
				SerializationHelpers.EnsureNonNull(track3);
				num += FlatSharp.Compiler.Generated.N6DBF9991D0AE1CE3ED227D7AB772014454D1BC766AA1C077F8CCF50E6408764D.Helpers.GetMaxSize(track3);
			}
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<Track> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 4);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is Track[] array)
		{
			foreach (Track track in array)
			{
				SerializationHelpers.EnsureNonNull(track);
				FlatSharp.Compiler.Generated.N6DBF9991D0AE1CE3ED227D7AB772014454D1BC766AA1C077F8CCF50E6408764D.Helpers.Serialize(spanWriter, span, track, num, context);
				num += 4;
			}
		}
		else if (value is List<Track> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				Track track2 = list[j];
				SerializationHelpers.EnsureNonNull(track2);
				FlatSharp.Compiler.Generated.N6DBF9991D0AE1CE3ED227D7AB772014454D1BC766AA1C077F8CCF50E6408764D.Helpers.Serialize(spanWriter, span, track2, num, context);
				num += 4;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				Track track3 = value[k];
				SerializationHelpers.EnsureNonNull(track3);
				FlatSharp.Compiler.Generated.N6DBF9991D0AE1CE3ED227D7AB772014454D1BC766AA1C077F8CCF50E6408764D.Helpers.Serialize(spanWriter, span, track3, num, context);
				num += 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<Track> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_07d328ac5a93a2e9ace5f709925b95e0_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<Track> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_07d328ac5a93a2e9ace5f709925b95e0_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<Track> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_07d328ac5a93a2e9ace5f709925b95e0_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<Track> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_07d328ac5a93a2e9ace5f709925b95e0_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
