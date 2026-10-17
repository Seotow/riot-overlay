using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Snapshot;
using FlatSharp.Compiler.Generated.ND47E1B33AD1D0BC3402725E4286BCFB2C59CB3D9CF43DF7BD570A556F2A1C0A5;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.NC14A0EE4EC8D77CF82257964E3F863010C3731C2C62919452638B39EC1B2A8CF;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ TeamStats ], Count = {Count}")]
	internal sealed class GeneratedVector_5d680495e6d74da214216f276e619e65_Lazy<TInputBuffer> : IList<TeamStats>, ICollection<TeamStats>, IEnumerable<TeamStats>, IEnumerable, IReadOnlyList<TeamStats>, IReadOnlyCollection<TeamStats>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public TeamStats this[int index]
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

		public GeneratedVector_5d680495e6d74da214216f276e619e65_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.ND47E1B33AD1D0BC3402725E4286BCFB2C59CB3D9CF43DF7BD570A556F2A1C0A5.Helpers.tableReader_71a64716d2264052aa2e9dc4128d9345_Lazy<TInputBuffer> SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.ND47E1B33AD1D0BC3402725E4286BCFB2C59CB3D9CF43DF7BD570A556F2A1C0A5.Helpers.tableReader_71a64716d2264052aa2e9dc4128d9345_Lazy<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return FlatSharp.Compiler.Generated.ND47E1B33AD1D0BC3402725E4286BCFB2C59CB3D9CF43DF7BD570A556F2A1C0A5.Helpers.Parse_Lazy(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, TeamStats value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(TeamStats? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(TeamStats? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(TeamStats[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<TeamStats> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(TeamStats item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, TeamStats item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(TeamStats item)
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

	[DebuggerDisplay("Progressive [ TeamStats ], Count = {Count}")]
	internal sealed class GeneratedVector_5d680495e6d74da214216f276e619e65_Progressive<TInputBuffer> : IList<TeamStats>, ICollection<TeamStats>, IEnumerable<TeamStats>, IEnumerable, IReadOnlyList<TeamStats>, IReadOnlyCollection<TeamStats>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly FlatSharp.Compiler.Generated.ND47E1B33AD1D0BC3402725E4286BCFB2C59CB3D9CF43DF7BD570A556F2A1C0A5.Helpers.tableReader_71a64716d2264052aa2e9dc4128d9345_Progressive<TInputBuffer>?[]?[] items;

		public TeamStats this[int index]
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

		public GeneratedVector_5d680495e6d74da214216f276e619e65_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new FlatSharp.Compiler.Generated.ND47E1B33AD1D0BC3402725E4286BCFB2C59CB3D9CF43DF7BD570A556F2A1C0A5.Helpers.tableReader_71a64716d2264052aa2e9dc4128d9345_Progressive<TInputBuffer>[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.ND47E1B33AD1D0BC3402725E4286BCFB2C59CB3D9CF43DF7BD570A556F2A1C0A5.Helpers.tableReader_71a64716d2264052aa2e9dc4128d9345_Progressive<TInputBuffer>?[] GetOrCreateRow(FlatSharp.Compiler.Generated.ND47E1B33AD1D0BC3402725E4286BCFB2C59CB3D9CF43DF7BD570A556F2A1C0A5.Helpers.tableReader_71a64716d2264052aa2e9dc4128d9345_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private FlatSharp.Compiler.Generated.ND47E1B33AD1D0BC3402725E4286BCFB2C59CB3D9CF43DF7BD570A556F2A1C0A5.Helpers.tableReader_71a64716d2264052aa2e9dc4128d9345_Progressive<TInputBuffer>?[] CreateRow(FlatSharp.Compiler.Generated.ND47E1B33AD1D0BC3402725E4286BCFB2C59CB3D9CF43DF7BD570A556F2A1C0A5.Helpers.tableReader_71a64716d2264052aa2e9dc4128d9345_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] = new FlatSharp.Compiler.Generated.ND47E1B33AD1D0BC3402725E4286BCFB2C59CB3D9CF43DF7BD570A556F2A1C0A5.Helpers.tableReader_71a64716d2264052aa2e9dc4128d9345_Progressive<TInputBuffer>[32];
		}

		private FlatSharp.Compiler.Generated.ND47E1B33AD1D0BC3402725E4286BCFB2C59CB3D9CF43DF7BD570A556F2A1C0A5.Helpers.tableReader_71a64716d2264052aa2e9dc4128d9345_Progressive<TInputBuffer> ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			FlatSharp.Compiler.Generated.ND47E1B33AD1D0BC3402725E4286BCFB2C59CB3D9CF43DF7BD570A556F2A1C0A5.Helpers.tableReader_71a64716d2264052aa2e9dc4128d9345_Progressive<TInputBuffer>[][] array = items;
			FlatSharp.Compiler.Generated.ND47E1B33AD1D0BC3402725E4286BCFB2C59CB3D9CF43DF7BD570A556F2A1C0A5.Helpers.tableReader_71a64716d2264052aa2e9dc4128d9345_Progressive<TInputBuffer>[] orCreateRow = GetOrCreateRow(array, rowIndex);
			FlatSharp.Compiler.Generated.ND47E1B33AD1D0BC3402725E4286BCFB2C59CB3D9CF43DF7BD570A556F2A1C0A5.Helpers.tableReader_71a64716d2264052aa2e9dc4128d9345_Progressive<TInputBuffer> tableReader_71a64716d2264052aa2e9dc4128d9345_Progressive = orCreateRow[colIndex];
			if (tableReader_71a64716d2264052aa2e9dc4128d9345_Progressive == null)
			{
				tableReader_71a64716d2264052aa2e9dc4128d9345_Progressive = (orCreateRow[colIndex] = UnsafeParseItem(index));
			}
			return tableReader_71a64716d2264052aa2e9dc4128d9345_Progressive;
		}

		private void ProgressiveSet(int index, TeamStats value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, TeamStats value)
		{
			VectorUtilities.CheckIndex(index, count);
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.ND47E1B33AD1D0BC3402725E4286BCFB2C59CB3D9CF43DF7BD570A556F2A1C0A5.Helpers.tableReader_71a64716d2264052aa2e9dc4128d9345_Progressive<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.ND47E1B33AD1D0BC3402725E4286BCFB2C59CB3D9CF43DF7BD570A556F2A1C0A5.Helpers.tableReader_71a64716d2264052aa2e9dc4128d9345_Progressive<TInputBuffer> UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.ND47E1B33AD1D0BC3402725E4286BCFB2C59CB3D9CF43DF7BD570A556F2A1C0A5.Helpers.Parse_Progressive(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, TeamStats value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(TeamStats? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(TeamStats? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(TeamStats[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<TeamStats> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(TeamStats item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, TeamStats item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(TeamStats item)
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

	[DebuggerDisplay("Greedy [ TeamStats ], Count = {Count}")]
	internal sealed class GeneratedVector_5d680495e6d74da214216f276e619e65_Greedy<TInputBuffer> : IList<TeamStats>, ICollection<TeamStats>, IEnumerable<TeamStats>, IEnumerable, IReadOnlyList<TeamStats>, IReadOnlyCollection<TeamStats> where TInputBuffer : IInputBuffer
	{
		private readonly List<FlatSharp.Compiler.Generated.ND47E1B33AD1D0BC3402725E4286BCFB2C59CB3D9CF43DF7BD570A556F2A1C0A5.Helpers.tableReader_71a64716d2264052aa2e9dc4128d9345_Greedy<TInputBuffer>> list;

		public TeamStats this[int index]
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

		public GeneratedVector_5d680495e6d74da214216f276e619e65_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<FlatSharp.Compiler.Generated.ND47E1B33AD1D0BC3402725E4286BCFB2C59CB3D9CF43DF7BD570A556F2A1C0A5.Helpers.tableReader_71a64716d2264052aa2e9dc4128d9345_Greedy<TInputBuffer>> list = (this.list = new List<FlatSharp.Compiler.Generated.ND47E1B33AD1D0BC3402725E4286BCFB2C59CB3D9CF43DF7BD570A556F2A1C0A5.Helpers.tableReader_71a64716d2264052aa2e9dc4128d9345_Greedy<TInputBuffer>>(num));
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.ND47E1B33AD1D0BC3402725E4286BCFB2C59CB3D9CF43DF7BD570A556F2A1C0A5.Helpers.tableReader_71a64716d2264052aa2e9dc4128d9345_Greedy<TInputBuffer> item = FlatSharp.Compiler.Generated.ND47E1B33AD1D0BC3402725E4286BCFB2C59CB3D9CF43DF7BD570A556F2A1C0A5.Helpers.Parse_Greedy(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		private FlatSharp.Compiler.Generated.ND47E1B33AD1D0BC3402725E4286BCFB2C59CB3D9CF43DF7BD570A556F2A1C0A5.Helpers.tableReader_71a64716d2264052aa2e9dc4128d9345_Greedy<TInputBuffer> GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, TeamStats value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(TeamStats? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(TeamStats? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(TeamStats[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<TeamStats> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(TeamStats item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, TeamStats item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(TeamStats item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ TeamStats ], Count = {Count}")]
	internal sealed class GeneratedVector_5d680495e6d74da214216f276e619e65_GreedyMutable<TInputBuffer> : IList<TeamStats>, ICollection<TeamStats>, IEnumerable<TeamStats>, IEnumerable, IReadOnlyList<TeamStats>, IReadOnlyCollection<TeamStats> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<TeamStats> list;

		public TeamStats this[int index]
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

		public GeneratedVector_5d680495e6d74da214216f276e619e65_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<TeamStats> list = (this.list = new List<TeamStats>());
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.ND47E1B33AD1D0BC3402725E4286BCFB2C59CB3D9CF43DF7BD570A556F2A1C0A5.Helpers.tableReader_71a64716d2264052aa2e9dc4128d9345_GreedyMutable<TInputBuffer> item = FlatSharp.Compiler.Generated.ND47E1B33AD1D0BC3402725E4286BCFB2C59CB3D9CF43DF7BD570A556F2A1C0A5.Helpers.Parse_GreedyMutable(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private TeamStats GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, TeamStats value)
		{
			list[index] = value;
		}

		public void Add(TeamStats item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, TeamStats item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(TeamStats item)
		{
			return list.Remove(item);
		}

		public bool Contains(TeamStats? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(TeamStats? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(TeamStats[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<TeamStats> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<TeamStats> value)
	{
		int count = value.Count;
		int num = 14;
		if (value is TeamStats[] array)
		{
			foreach (TeamStats teamStats in array)
			{
				SerializationHelpers.EnsureNonNull(teamStats);
				num += FlatSharp.Compiler.Generated.ND47E1B33AD1D0BC3402725E4286BCFB2C59CB3D9CF43DF7BD570A556F2A1C0A5.Helpers.GetMaxSize(teamStats);
			}
		}
		else if (value is List<TeamStats> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				TeamStats teamStats2 = list[j];
				SerializationHelpers.EnsureNonNull(teamStats2);
				num += FlatSharp.Compiler.Generated.ND47E1B33AD1D0BC3402725E4286BCFB2C59CB3D9CF43DF7BD570A556F2A1C0A5.Helpers.GetMaxSize(teamStats2);
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				TeamStats teamStats3 = value[k];
				SerializationHelpers.EnsureNonNull(teamStats3);
				num += FlatSharp.Compiler.Generated.ND47E1B33AD1D0BC3402725E4286BCFB2C59CB3D9CF43DF7BD570A556F2A1C0A5.Helpers.GetMaxSize(teamStats3);
			}
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<TeamStats> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 4);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is TeamStats[] array)
		{
			foreach (TeamStats teamStats in array)
			{
				SerializationHelpers.EnsureNonNull(teamStats);
				FlatSharp.Compiler.Generated.ND47E1B33AD1D0BC3402725E4286BCFB2C59CB3D9CF43DF7BD570A556F2A1C0A5.Helpers.Serialize(spanWriter, span, teamStats, num, context);
				num += 4;
			}
		}
		else if (value is List<TeamStats> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				TeamStats teamStats2 = list[j];
				SerializationHelpers.EnsureNonNull(teamStats2);
				FlatSharp.Compiler.Generated.ND47E1B33AD1D0BC3402725E4286BCFB2C59CB3D9CF43DF7BD570A556F2A1C0A5.Helpers.Serialize(spanWriter, span, teamStats2, num, context);
				num += 4;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				TeamStats teamStats3 = value[k];
				SerializationHelpers.EnsureNonNull(teamStats3);
				FlatSharp.Compiler.Generated.ND47E1B33AD1D0BC3402725E4286BCFB2C59CB3D9CF43DF7BD570A556F2A1C0A5.Helpers.Serialize(spanWriter, span, teamStats3, num, context);
				num += 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<TeamStats> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_5d680495e6d74da214216f276e619e65_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<TeamStats> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_5d680495e6d74da214216f276e619e65_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<TeamStats> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_5d680495e6d74da214216f276e619e65_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<TeamStats> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_5d680495e6d74da214216f276e619e65_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
