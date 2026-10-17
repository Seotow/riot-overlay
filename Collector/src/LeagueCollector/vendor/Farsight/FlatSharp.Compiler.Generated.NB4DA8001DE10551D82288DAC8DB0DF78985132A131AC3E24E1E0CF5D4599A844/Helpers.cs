using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Cinematics;
using FlatSharp.Compiler.Generated.N5164B6F8876BDC418E0E4252FDA8D6CD37757EA8CE90D5E7492745068759B023;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.NB4DA8001DE10551D82288DAC8DB0DF78985132A131AC3E24E1E0CF5D4599A844;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ CinematicHudTrack ], Count = {Count}")]
	internal sealed class GeneratedVector_be00a61518ce1a460bd3eb942851e668_Lazy<TInputBuffer> : IList<CinematicHudTrack>, ICollection<CinematicHudTrack>, IEnumerable<CinematicHudTrack>, IEnumerable, IReadOnlyList<CinematicHudTrack>, IReadOnlyCollection<CinematicHudTrack>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public CinematicHudTrack this[int index]
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

		public GeneratedVector_be00a61518ce1a460bd3eb942851e668_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N5164B6F8876BDC418E0E4252FDA8D6CD37757EA8CE90D5E7492745068759B023.Helpers.tableReader_98a197eb4f6449b4a8ef66d3410111cb_Lazy<TInputBuffer> SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N5164B6F8876BDC418E0E4252FDA8D6CD37757EA8CE90D5E7492745068759B023.Helpers.tableReader_98a197eb4f6449b4a8ef66d3410111cb_Lazy<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return FlatSharp.Compiler.Generated.N5164B6F8876BDC418E0E4252FDA8D6CD37757EA8CE90D5E7492745068759B023.Helpers.Parse_Lazy(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, CinematicHudTrack value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(CinematicHudTrack? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(CinematicHudTrack? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(CinematicHudTrack[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<CinematicHudTrack> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(CinematicHudTrack item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, CinematicHudTrack item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(CinematicHudTrack item)
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

	[DebuggerDisplay("Progressive [ CinematicHudTrack ], Count = {Count}")]
	internal sealed class GeneratedVector_be00a61518ce1a460bd3eb942851e668_Progressive<TInputBuffer> : IList<CinematicHudTrack>, ICollection<CinematicHudTrack>, IEnumerable<CinematicHudTrack>, IEnumerable, IReadOnlyList<CinematicHudTrack>, IReadOnlyCollection<CinematicHudTrack>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly FlatSharp.Compiler.Generated.N5164B6F8876BDC418E0E4252FDA8D6CD37757EA8CE90D5E7492745068759B023.Helpers.tableReader_98a197eb4f6449b4a8ef66d3410111cb_Progressive<TInputBuffer>?[]?[] items;

		public CinematicHudTrack this[int index]
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

		public GeneratedVector_be00a61518ce1a460bd3eb942851e668_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new FlatSharp.Compiler.Generated.N5164B6F8876BDC418E0E4252FDA8D6CD37757EA8CE90D5E7492745068759B023.Helpers.tableReader_98a197eb4f6449b4a8ef66d3410111cb_Progressive<TInputBuffer>[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N5164B6F8876BDC418E0E4252FDA8D6CD37757EA8CE90D5E7492745068759B023.Helpers.tableReader_98a197eb4f6449b4a8ef66d3410111cb_Progressive<TInputBuffer>?[] GetOrCreateRow(FlatSharp.Compiler.Generated.N5164B6F8876BDC418E0E4252FDA8D6CD37757EA8CE90D5E7492745068759B023.Helpers.tableReader_98a197eb4f6449b4a8ef66d3410111cb_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private FlatSharp.Compiler.Generated.N5164B6F8876BDC418E0E4252FDA8D6CD37757EA8CE90D5E7492745068759B023.Helpers.tableReader_98a197eb4f6449b4a8ef66d3410111cb_Progressive<TInputBuffer>?[] CreateRow(FlatSharp.Compiler.Generated.N5164B6F8876BDC418E0E4252FDA8D6CD37757EA8CE90D5E7492745068759B023.Helpers.tableReader_98a197eb4f6449b4a8ef66d3410111cb_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] = new FlatSharp.Compiler.Generated.N5164B6F8876BDC418E0E4252FDA8D6CD37757EA8CE90D5E7492745068759B023.Helpers.tableReader_98a197eb4f6449b4a8ef66d3410111cb_Progressive<TInputBuffer>[32];
		}

		private FlatSharp.Compiler.Generated.N5164B6F8876BDC418E0E4252FDA8D6CD37757EA8CE90D5E7492745068759B023.Helpers.tableReader_98a197eb4f6449b4a8ef66d3410111cb_Progressive<TInputBuffer> ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			FlatSharp.Compiler.Generated.N5164B6F8876BDC418E0E4252FDA8D6CD37757EA8CE90D5E7492745068759B023.Helpers.tableReader_98a197eb4f6449b4a8ef66d3410111cb_Progressive<TInputBuffer>[][] array = items;
			FlatSharp.Compiler.Generated.N5164B6F8876BDC418E0E4252FDA8D6CD37757EA8CE90D5E7492745068759B023.Helpers.tableReader_98a197eb4f6449b4a8ef66d3410111cb_Progressive<TInputBuffer>[] orCreateRow = GetOrCreateRow(array, rowIndex);
			FlatSharp.Compiler.Generated.N5164B6F8876BDC418E0E4252FDA8D6CD37757EA8CE90D5E7492745068759B023.Helpers.tableReader_98a197eb4f6449b4a8ef66d3410111cb_Progressive<TInputBuffer> tableReader_98a197eb4f6449b4a8ef66d3410111cb_Progressive = orCreateRow[colIndex];
			if (tableReader_98a197eb4f6449b4a8ef66d3410111cb_Progressive == null)
			{
				tableReader_98a197eb4f6449b4a8ef66d3410111cb_Progressive = (orCreateRow[colIndex] = UnsafeParseItem(index));
			}
			return tableReader_98a197eb4f6449b4a8ef66d3410111cb_Progressive;
		}

		private void ProgressiveSet(int index, CinematicHudTrack value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, CinematicHudTrack value)
		{
			VectorUtilities.CheckIndex(index, count);
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N5164B6F8876BDC418E0E4252FDA8D6CD37757EA8CE90D5E7492745068759B023.Helpers.tableReader_98a197eb4f6449b4a8ef66d3410111cb_Progressive<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N5164B6F8876BDC418E0E4252FDA8D6CD37757EA8CE90D5E7492745068759B023.Helpers.tableReader_98a197eb4f6449b4a8ef66d3410111cb_Progressive<TInputBuffer> UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.N5164B6F8876BDC418E0E4252FDA8D6CD37757EA8CE90D5E7492745068759B023.Helpers.Parse_Progressive(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, CinematicHudTrack value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(CinematicHudTrack? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(CinematicHudTrack? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(CinematicHudTrack[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<CinematicHudTrack> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(CinematicHudTrack item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, CinematicHudTrack item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(CinematicHudTrack item)
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

	[DebuggerDisplay("Greedy [ CinematicHudTrack ], Count = {Count}")]
	internal sealed class GeneratedVector_be00a61518ce1a460bd3eb942851e668_Greedy<TInputBuffer> : IList<CinematicHudTrack>, ICollection<CinematicHudTrack>, IEnumerable<CinematicHudTrack>, IEnumerable, IReadOnlyList<CinematicHudTrack>, IReadOnlyCollection<CinematicHudTrack> where TInputBuffer : IInputBuffer
	{
		private readonly List<FlatSharp.Compiler.Generated.N5164B6F8876BDC418E0E4252FDA8D6CD37757EA8CE90D5E7492745068759B023.Helpers.tableReader_98a197eb4f6449b4a8ef66d3410111cb_Greedy<TInputBuffer>> list;

		public CinematicHudTrack this[int index]
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

		public GeneratedVector_be00a61518ce1a460bd3eb942851e668_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<FlatSharp.Compiler.Generated.N5164B6F8876BDC418E0E4252FDA8D6CD37757EA8CE90D5E7492745068759B023.Helpers.tableReader_98a197eb4f6449b4a8ef66d3410111cb_Greedy<TInputBuffer>> list = (this.list = new List<FlatSharp.Compiler.Generated.N5164B6F8876BDC418E0E4252FDA8D6CD37757EA8CE90D5E7492745068759B023.Helpers.tableReader_98a197eb4f6449b4a8ef66d3410111cb_Greedy<TInputBuffer>>(num));
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.N5164B6F8876BDC418E0E4252FDA8D6CD37757EA8CE90D5E7492745068759B023.Helpers.tableReader_98a197eb4f6449b4a8ef66d3410111cb_Greedy<TInputBuffer> item = FlatSharp.Compiler.Generated.N5164B6F8876BDC418E0E4252FDA8D6CD37757EA8CE90D5E7492745068759B023.Helpers.Parse_Greedy(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		private FlatSharp.Compiler.Generated.N5164B6F8876BDC418E0E4252FDA8D6CD37757EA8CE90D5E7492745068759B023.Helpers.tableReader_98a197eb4f6449b4a8ef66d3410111cb_Greedy<TInputBuffer> GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, CinematicHudTrack value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(CinematicHudTrack? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(CinematicHudTrack? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(CinematicHudTrack[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<CinematicHudTrack> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(CinematicHudTrack item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, CinematicHudTrack item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(CinematicHudTrack item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ CinematicHudTrack ], Count = {Count}")]
	internal sealed class GeneratedVector_be00a61518ce1a460bd3eb942851e668_GreedyMutable<TInputBuffer> : IList<CinematicHudTrack>, ICollection<CinematicHudTrack>, IEnumerable<CinematicHudTrack>, IEnumerable, IReadOnlyList<CinematicHudTrack>, IReadOnlyCollection<CinematicHudTrack> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<CinematicHudTrack> list;

		public CinematicHudTrack this[int index]
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

		public GeneratedVector_be00a61518ce1a460bd3eb942851e668_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<CinematicHudTrack> list = (this.list = new List<CinematicHudTrack>());
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.N5164B6F8876BDC418E0E4252FDA8D6CD37757EA8CE90D5E7492745068759B023.Helpers.tableReader_98a197eb4f6449b4a8ef66d3410111cb_GreedyMutable<TInputBuffer> item = FlatSharp.Compiler.Generated.N5164B6F8876BDC418E0E4252FDA8D6CD37757EA8CE90D5E7492745068759B023.Helpers.Parse_GreedyMutable(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private CinematicHudTrack GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, CinematicHudTrack value)
		{
			list[index] = value;
		}

		public void Add(CinematicHudTrack item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, CinematicHudTrack item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(CinematicHudTrack item)
		{
			return list.Remove(item);
		}

		public bool Contains(CinematicHudTrack? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(CinematicHudTrack? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(CinematicHudTrack[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<CinematicHudTrack> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<CinematicHudTrack> value)
	{
		int count = value.Count;
		int num = 14;
		if (value is CinematicHudTrack[] array)
		{
			foreach (CinematicHudTrack cinematicHudTrack in array)
			{
				SerializationHelpers.EnsureNonNull(cinematicHudTrack);
				num += FlatSharp.Compiler.Generated.N5164B6F8876BDC418E0E4252FDA8D6CD37757EA8CE90D5E7492745068759B023.Helpers.GetMaxSize(cinematicHudTrack);
			}
		}
		else if (value is List<CinematicHudTrack> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				CinematicHudTrack cinematicHudTrack2 = list[j];
				SerializationHelpers.EnsureNonNull(cinematicHudTrack2);
				num += FlatSharp.Compiler.Generated.N5164B6F8876BDC418E0E4252FDA8D6CD37757EA8CE90D5E7492745068759B023.Helpers.GetMaxSize(cinematicHudTrack2);
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				CinematicHudTrack cinematicHudTrack3 = value[k];
				SerializationHelpers.EnsureNonNull(cinematicHudTrack3);
				num += FlatSharp.Compiler.Generated.N5164B6F8876BDC418E0E4252FDA8D6CD37757EA8CE90D5E7492745068759B023.Helpers.GetMaxSize(cinematicHudTrack3);
			}
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<CinematicHudTrack> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 4);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is CinematicHudTrack[] array)
		{
			foreach (CinematicHudTrack cinematicHudTrack in array)
			{
				SerializationHelpers.EnsureNonNull(cinematicHudTrack);
				FlatSharp.Compiler.Generated.N5164B6F8876BDC418E0E4252FDA8D6CD37757EA8CE90D5E7492745068759B023.Helpers.Serialize(spanWriter, span, cinematicHudTrack, num, context);
				num += 4;
			}
		}
		else if (value is List<CinematicHudTrack> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				CinematicHudTrack cinematicHudTrack2 = list[j];
				SerializationHelpers.EnsureNonNull(cinematicHudTrack2);
				FlatSharp.Compiler.Generated.N5164B6F8876BDC418E0E4252FDA8D6CD37757EA8CE90D5E7492745068759B023.Helpers.Serialize(spanWriter, span, cinematicHudTrack2, num, context);
				num += 4;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				CinematicHudTrack cinematicHudTrack3 = value[k];
				SerializationHelpers.EnsureNonNull(cinematicHudTrack3);
				FlatSharp.Compiler.Generated.N5164B6F8876BDC418E0E4252FDA8D6CD37757EA8CE90D5E7492745068759B023.Helpers.Serialize(spanWriter, span, cinematicHudTrack3, num, context);
				num += 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<CinematicHudTrack> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_be00a61518ce1a460bd3eb942851e668_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<CinematicHudTrack> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_be00a61518ce1a460bd3eb942851e668_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<CinematicHudTrack> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_be00a61518ce1a460bd3eb942851e668_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<CinematicHudTrack> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_be00a61518ce1a460bd3eb942851e668_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
