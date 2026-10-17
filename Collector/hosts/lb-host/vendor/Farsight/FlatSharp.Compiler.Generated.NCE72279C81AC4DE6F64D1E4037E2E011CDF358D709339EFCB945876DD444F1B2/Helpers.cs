using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Commands;
using FlatSharp.Compiler.Generated.ND218554DD9BB56D21B429179FDBB2B3FFE1A62AEC796B772743561601789BEFB;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.NCE72279C81AC4DE6F64D1E4037E2E011CDF358D709339EFCB945876DD444F1B2;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ CinematicPropPath ], Count = {Count}")]
	internal sealed class GeneratedVector_26d318044c170d908647b2d942097770_Lazy<TInputBuffer> : IList<CinematicPropPath>, ICollection<CinematicPropPath>, IEnumerable<CinematicPropPath>, IEnumerable, IReadOnlyList<CinematicPropPath>, IReadOnlyCollection<CinematicPropPath>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public CinematicPropPath this[int index]
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

		public GeneratedVector_26d318044c170d908647b2d942097770_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.ND218554DD9BB56D21B429179FDBB2B3FFE1A62AEC796B772743561601789BEFB.Helpers.tableReader_51bb85774278441daf5c9b66609c0c23_Lazy<TInputBuffer> SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.ND218554DD9BB56D21B429179FDBB2B3FFE1A62AEC796B772743561601789BEFB.Helpers.tableReader_51bb85774278441daf5c9b66609c0c23_Lazy<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return FlatSharp.Compiler.Generated.ND218554DD9BB56D21B429179FDBB2B3FFE1A62AEC796B772743561601789BEFB.Helpers.Parse_Lazy(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, CinematicPropPath value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(CinematicPropPath? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(CinematicPropPath? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(CinematicPropPath[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<CinematicPropPath> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(CinematicPropPath item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, CinematicPropPath item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(CinematicPropPath item)
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

	[DebuggerDisplay("Progressive [ CinematicPropPath ], Count = {Count}")]
	internal sealed class GeneratedVector_26d318044c170d908647b2d942097770_Progressive<TInputBuffer> : IList<CinematicPropPath>, ICollection<CinematicPropPath>, IEnumerable<CinematicPropPath>, IEnumerable, IReadOnlyList<CinematicPropPath>, IReadOnlyCollection<CinematicPropPath>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly FlatSharp.Compiler.Generated.ND218554DD9BB56D21B429179FDBB2B3FFE1A62AEC796B772743561601789BEFB.Helpers.tableReader_51bb85774278441daf5c9b66609c0c23_Progressive<TInputBuffer>?[]?[] items;

		public CinematicPropPath this[int index]
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

		public GeneratedVector_26d318044c170d908647b2d942097770_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new FlatSharp.Compiler.Generated.ND218554DD9BB56D21B429179FDBB2B3FFE1A62AEC796B772743561601789BEFB.Helpers.tableReader_51bb85774278441daf5c9b66609c0c23_Progressive<TInputBuffer>[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.ND218554DD9BB56D21B429179FDBB2B3FFE1A62AEC796B772743561601789BEFB.Helpers.tableReader_51bb85774278441daf5c9b66609c0c23_Progressive<TInputBuffer>?[] GetOrCreateRow(FlatSharp.Compiler.Generated.ND218554DD9BB56D21B429179FDBB2B3FFE1A62AEC796B772743561601789BEFB.Helpers.tableReader_51bb85774278441daf5c9b66609c0c23_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private FlatSharp.Compiler.Generated.ND218554DD9BB56D21B429179FDBB2B3FFE1A62AEC796B772743561601789BEFB.Helpers.tableReader_51bb85774278441daf5c9b66609c0c23_Progressive<TInputBuffer>?[] CreateRow(FlatSharp.Compiler.Generated.ND218554DD9BB56D21B429179FDBB2B3FFE1A62AEC796B772743561601789BEFB.Helpers.tableReader_51bb85774278441daf5c9b66609c0c23_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] = new FlatSharp.Compiler.Generated.ND218554DD9BB56D21B429179FDBB2B3FFE1A62AEC796B772743561601789BEFB.Helpers.tableReader_51bb85774278441daf5c9b66609c0c23_Progressive<TInputBuffer>[32];
		}

		private FlatSharp.Compiler.Generated.ND218554DD9BB56D21B429179FDBB2B3FFE1A62AEC796B772743561601789BEFB.Helpers.tableReader_51bb85774278441daf5c9b66609c0c23_Progressive<TInputBuffer> ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			FlatSharp.Compiler.Generated.ND218554DD9BB56D21B429179FDBB2B3FFE1A62AEC796B772743561601789BEFB.Helpers.tableReader_51bb85774278441daf5c9b66609c0c23_Progressive<TInputBuffer>[][] array = items;
			FlatSharp.Compiler.Generated.ND218554DD9BB56D21B429179FDBB2B3FFE1A62AEC796B772743561601789BEFB.Helpers.tableReader_51bb85774278441daf5c9b66609c0c23_Progressive<TInputBuffer>[] orCreateRow = GetOrCreateRow(array, rowIndex);
			FlatSharp.Compiler.Generated.ND218554DD9BB56D21B429179FDBB2B3FFE1A62AEC796B772743561601789BEFB.Helpers.tableReader_51bb85774278441daf5c9b66609c0c23_Progressive<TInputBuffer> tableReader_51bb85774278441daf5c9b66609c0c23_Progressive = orCreateRow[colIndex];
			if (tableReader_51bb85774278441daf5c9b66609c0c23_Progressive == null)
			{
				tableReader_51bb85774278441daf5c9b66609c0c23_Progressive = (orCreateRow[colIndex] = UnsafeParseItem(index));
			}
			return tableReader_51bb85774278441daf5c9b66609c0c23_Progressive;
		}

		private void ProgressiveSet(int index, CinematicPropPath value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, CinematicPropPath value)
		{
			VectorUtilities.CheckIndex(index, count);
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.ND218554DD9BB56D21B429179FDBB2B3FFE1A62AEC796B772743561601789BEFB.Helpers.tableReader_51bb85774278441daf5c9b66609c0c23_Progressive<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.ND218554DD9BB56D21B429179FDBB2B3FFE1A62AEC796B772743561601789BEFB.Helpers.tableReader_51bb85774278441daf5c9b66609c0c23_Progressive<TInputBuffer> UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.ND218554DD9BB56D21B429179FDBB2B3FFE1A62AEC796B772743561601789BEFB.Helpers.Parse_Progressive(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, CinematicPropPath value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(CinematicPropPath? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(CinematicPropPath? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(CinematicPropPath[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<CinematicPropPath> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(CinematicPropPath item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, CinematicPropPath item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(CinematicPropPath item)
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

	[DebuggerDisplay("Greedy [ CinematicPropPath ], Count = {Count}")]
	internal sealed class GeneratedVector_26d318044c170d908647b2d942097770_Greedy<TInputBuffer> : IList<CinematicPropPath>, ICollection<CinematicPropPath>, IEnumerable<CinematicPropPath>, IEnumerable, IReadOnlyList<CinematicPropPath>, IReadOnlyCollection<CinematicPropPath> where TInputBuffer : IInputBuffer
	{
		private readonly List<FlatSharp.Compiler.Generated.ND218554DD9BB56D21B429179FDBB2B3FFE1A62AEC796B772743561601789BEFB.Helpers.tableReader_51bb85774278441daf5c9b66609c0c23_Greedy<TInputBuffer>> list;

		public CinematicPropPath this[int index]
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

		public GeneratedVector_26d318044c170d908647b2d942097770_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<FlatSharp.Compiler.Generated.ND218554DD9BB56D21B429179FDBB2B3FFE1A62AEC796B772743561601789BEFB.Helpers.tableReader_51bb85774278441daf5c9b66609c0c23_Greedy<TInputBuffer>> list = (this.list = new List<FlatSharp.Compiler.Generated.ND218554DD9BB56D21B429179FDBB2B3FFE1A62AEC796B772743561601789BEFB.Helpers.tableReader_51bb85774278441daf5c9b66609c0c23_Greedy<TInputBuffer>>(num));
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.ND218554DD9BB56D21B429179FDBB2B3FFE1A62AEC796B772743561601789BEFB.Helpers.tableReader_51bb85774278441daf5c9b66609c0c23_Greedy<TInputBuffer> item = FlatSharp.Compiler.Generated.ND218554DD9BB56D21B429179FDBB2B3FFE1A62AEC796B772743561601789BEFB.Helpers.Parse_Greedy(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		private FlatSharp.Compiler.Generated.ND218554DD9BB56D21B429179FDBB2B3FFE1A62AEC796B772743561601789BEFB.Helpers.tableReader_51bb85774278441daf5c9b66609c0c23_Greedy<TInputBuffer> GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, CinematicPropPath value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(CinematicPropPath? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(CinematicPropPath? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(CinematicPropPath[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<CinematicPropPath> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(CinematicPropPath item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, CinematicPropPath item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(CinematicPropPath item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ CinematicPropPath ], Count = {Count}")]
	internal sealed class GeneratedVector_26d318044c170d908647b2d942097770_GreedyMutable<TInputBuffer> : IList<CinematicPropPath>, ICollection<CinematicPropPath>, IEnumerable<CinematicPropPath>, IEnumerable, IReadOnlyList<CinematicPropPath>, IReadOnlyCollection<CinematicPropPath> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<CinematicPropPath> list;

		public CinematicPropPath this[int index]
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

		public GeneratedVector_26d318044c170d908647b2d942097770_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<CinematicPropPath> list = (this.list = new List<CinematicPropPath>());
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.ND218554DD9BB56D21B429179FDBB2B3FFE1A62AEC796B772743561601789BEFB.Helpers.tableReader_51bb85774278441daf5c9b66609c0c23_GreedyMutable<TInputBuffer> item = FlatSharp.Compiler.Generated.ND218554DD9BB56D21B429179FDBB2B3FFE1A62AEC796B772743561601789BEFB.Helpers.Parse_GreedyMutable(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private CinematicPropPath GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, CinematicPropPath value)
		{
			list[index] = value;
		}

		public void Add(CinematicPropPath item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, CinematicPropPath item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(CinematicPropPath item)
		{
			return list.Remove(item);
		}

		public bool Contains(CinematicPropPath? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(CinematicPropPath? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(CinematicPropPath[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<CinematicPropPath> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<CinematicPropPath> value)
	{
		int count = value.Count;
		int num = 14;
		if (value is CinematicPropPath[] array)
		{
			foreach (CinematicPropPath cinematicPropPath in array)
			{
				SerializationHelpers.EnsureNonNull(cinematicPropPath);
				num += FlatSharp.Compiler.Generated.ND218554DD9BB56D21B429179FDBB2B3FFE1A62AEC796B772743561601789BEFB.Helpers.GetMaxSize(cinematicPropPath);
			}
		}
		else if (value is List<CinematicPropPath> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				CinematicPropPath cinematicPropPath2 = list[j];
				SerializationHelpers.EnsureNonNull(cinematicPropPath2);
				num += FlatSharp.Compiler.Generated.ND218554DD9BB56D21B429179FDBB2B3FFE1A62AEC796B772743561601789BEFB.Helpers.GetMaxSize(cinematicPropPath2);
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				CinematicPropPath cinematicPropPath3 = value[k];
				SerializationHelpers.EnsureNonNull(cinematicPropPath3);
				num += FlatSharp.Compiler.Generated.ND218554DD9BB56D21B429179FDBB2B3FFE1A62AEC796B772743561601789BEFB.Helpers.GetMaxSize(cinematicPropPath3);
			}
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<CinematicPropPath> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 4);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is CinematicPropPath[] array)
		{
			foreach (CinematicPropPath cinematicPropPath in array)
			{
				SerializationHelpers.EnsureNonNull(cinematicPropPath);
				FlatSharp.Compiler.Generated.ND218554DD9BB56D21B429179FDBB2B3FFE1A62AEC796B772743561601789BEFB.Helpers.Serialize(spanWriter, span, cinematicPropPath, num, context);
				num += 4;
			}
		}
		else if (value is List<CinematicPropPath> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				CinematicPropPath cinematicPropPath2 = list[j];
				SerializationHelpers.EnsureNonNull(cinematicPropPath2);
				FlatSharp.Compiler.Generated.ND218554DD9BB56D21B429179FDBB2B3FFE1A62AEC796B772743561601789BEFB.Helpers.Serialize(spanWriter, span, cinematicPropPath2, num, context);
				num += 4;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				CinematicPropPath cinematicPropPath3 = value[k];
				SerializationHelpers.EnsureNonNull(cinematicPropPath3);
				FlatSharp.Compiler.Generated.ND218554DD9BB56D21B429179FDBB2B3FFE1A62AEC796B772743561601789BEFB.Helpers.Serialize(spanWriter, span, cinematicPropPath3, num, context);
				num += 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<CinematicPropPath> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_26d318044c170d908647b2d942097770_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<CinematicPropPath> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_26d318044c170d908647b2d942097770_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<CinematicPropPath> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_26d318044c170d908647b2d942097770_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<CinematicPropPath> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_26d318044c170d908647b2d942097770_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
