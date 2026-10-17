using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Snapshot;
using FlatSharp.Compiler.Generated.N09F3A730B11CE2ACF39EBCBBE8059E25983B9E5B15FBB7087304158AD7C027CD;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.NAA27A09FECA849BD7156BB91850E529E3ACD19F4F8C6D751D4175AA2651D435F;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ Spell ], Count = {Count}")]
	internal sealed class GeneratedVector_6685333ab54c6b998740bafe35c68445_Lazy<TInputBuffer> : IList<Spell>, ICollection<Spell>, IEnumerable<Spell>, IEnumerable, IReadOnlyList<Spell>, IReadOnlyCollection<Spell>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public Spell this[int index]
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

		public GeneratedVector_6685333ab54c6b998740bafe35c68445_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N09F3A730B11CE2ACF39EBCBBE8059E25983B9E5B15FBB7087304158AD7C027CD.Helpers.tableReader_e4ee032ba57540b3b3f1ae65891d4c73_Lazy<TInputBuffer> SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N09F3A730B11CE2ACF39EBCBBE8059E25983B9E5B15FBB7087304158AD7C027CD.Helpers.tableReader_e4ee032ba57540b3b3f1ae65891d4c73_Lazy<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return FlatSharp.Compiler.Generated.N09F3A730B11CE2ACF39EBCBBE8059E25983B9E5B15FBB7087304158AD7C027CD.Helpers.Parse_Lazy(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, Spell value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(Spell? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(Spell? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(Spell[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<Spell> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(Spell item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, Spell item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(Spell item)
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

	[DebuggerDisplay("Progressive [ Spell ], Count = {Count}")]
	internal sealed class GeneratedVector_6685333ab54c6b998740bafe35c68445_Progressive<TInputBuffer> : IList<Spell>, ICollection<Spell>, IEnumerable<Spell>, IEnumerable, IReadOnlyList<Spell>, IReadOnlyCollection<Spell>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly FlatSharp.Compiler.Generated.N09F3A730B11CE2ACF39EBCBBE8059E25983B9E5B15FBB7087304158AD7C027CD.Helpers.tableReader_e4ee032ba57540b3b3f1ae65891d4c73_Progressive<TInputBuffer>?[]?[] items;

		public Spell this[int index]
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

		public GeneratedVector_6685333ab54c6b998740bafe35c68445_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new FlatSharp.Compiler.Generated.N09F3A730B11CE2ACF39EBCBBE8059E25983B9E5B15FBB7087304158AD7C027CD.Helpers.tableReader_e4ee032ba57540b3b3f1ae65891d4c73_Progressive<TInputBuffer>[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N09F3A730B11CE2ACF39EBCBBE8059E25983B9E5B15FBB7087304158AD7C027CD.Helpers.tableReader_e4ee032ba57540b3b3f1ae65891d4c73_Progressive<TInputBuffer>?[] GetOrCreateRow(FlatSharp.Compiler.Generated.N09F3A730B11CE2ACF39EBCBBE8059E25983B9E5B15FBB7087304158AD7C027CD.Helpers.tableReader_e4ee032ba57540b3b3f1ae65891d4c73_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private FlatSharp.Compiler.Generated.N09F3A730B11CE2ACF39EBCBBE8059E25983B9E5B15FBB7087304158AD7C027CD.Helpers.tableReader_e4ee032ba57540b3b3f1ae65891d4c73_Progressive<TInputBuffer>?[] CreateRow(FlatSharp.Compiler.Generated.N09F3A730B11CE2ACF39EBCBBE8059E25983B9E5B15FBB7087304158AD7C027CD.Helpers.tableReader_e4ee032ba57540b3b3f1ae65891d4c73_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] = new FlatSharp.Compiler.Generated.N09F3A730B11CE2ACF39EBCBBE8059E25983B9E5B15FBB7087304158AD7C027CD.Helpers.tableReader_e4ee032ba57540b3b3f1ae65891d4c73_Progressive<TInputBuffer>[32];
		}

		private FlatSharp.Compiler.Generated.N09F3A730B11CE2ACF39EBCBBE8059E25983B9E5B15FBB7087304158AD7C027CD.Helpers.tableReader_e4ee032ba57540b3b3f1ae65891d4c73_Progressive<TInputBuffer> ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			FlatSharp.Compiler.Generated.N09F3A730B11CE2ACF39EBCBBE8059E25983B9E5B15FBB7087304158AD7C027CD.Helpers.tableReader_e4ee032ba57540b3b3f1ae65891d4c73_Progressive<TInputBuffer>[][] array = items;
			FlatSharp.Compiler.Generated.N09F3A730B11CE2ACF39EBCBBE8059E25983B9E5B15FBB7087304158AD7C027CD.Helpers.tableReader_e4ee032ba57540b3b3f1ae65891d4c73_Progressive<TInputBuffer>[] orCreateRow = GetOrCreateRow(array, rowIndex);
			FlatSharp.Compiler.Generated.N09F3A730B11CE2ACF39EBCBBE8059E25983B9E5B15FBB7087304158AD7C027CD.Helpers.tableReader_e4ee032ba57540b3b3f1ae65891d4c73_Progressive<TInputBuffer> tableReader_e4ee032ba57540b3b3f1ae65891d4c73_Progressive = orCreateRow[colIndex];
			if (tableReader_e4ee032ba57540b3b3f1ae65891d4c73_Progressive == null)
			{
				tableReader_e4ee032ba57540b3b3f1ae65891d4c73_Progressive = (orCreateRow[colIndex] = UnsafeParseItem(index));
			}
			return tableReader_e4ee032ba57540b3b3f1ae65891d4c73_Progressive;
		}

		private void ProgressiveSet(int index, Spell value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, Spell value)
		{
			VectorUtilities.CheckIndex(index, count);
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N09F3A730B11CE2ACF39EBCBBE8059E25983B9E5B15FBB7087304158AD7C027CD.Helpers.tableReader_e4ee032ba57540b3b3f1ae65891d4c73_Progressive<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N09F3A730B11CE2ACF39EBCBBE8059E25983B9E5B15FBB7087304158AD7C027CD.Helpers.tableReader_e4ee032ba57540b3b3f1ae65891d4c73_Progressive<TInputBuffer> UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.N09F3A730B11CE2ACF39EBCBBE8059E25983B9E5B15FBB7087304158AD7C027CD.Helpers.Parse_Progressive(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, Spell value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(Spell? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(Spell? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(Spell[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<Spell> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(Spell item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, Spell item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(Spell item)
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

	[DebuggerDisplay("Greedy [ Spell ], Count = {Count}")]
	internal sealed class GeneratedVector_6685333ab54c6b998740bafe35c68445_Greedy<TInputBuffer> : IList<Spell>, ICollection<Spell>, IEnumerable<Spell>, IEnumerable, IReadOnlyList<Spell>, IReadOnlyCollection<Spell> where TInputBuffer : IInputBuffer
	{
		private readonly List<FlatSharp.Compiler.Generated.N09F3A730B11CE2ACF39EBCBBE8059E25983B9E5B15FBB7087304158AD7C027CD.Helpers.tableReader_e4ee032ba57540b3b3f1ae65891d4c73_Greedy<TInputBuffer>> list;

		public Spell this[int index]
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

		public GeneratedVector_6685333ab54c6b998740bafe35c68445_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<FlatSharp.Compiler.Generated.N09F3A730B11CE2ACF39EBCBBE8059E25983B9E5B15FBB7087304158AD7C027CD.Helpers.tableReader_e4ee032ba57540b3b3f1ae65891d4c73_Greedy<TInputBuffer>> list = (this.list = new List<FlatSharp.Compiler.Generated.N09F3A730B11CE2ACF39EBCBBE8059E25983B9E5B15FBB7087304158AD7C027CD.Helpers.tableReader_e4ee032ba57540b3b3f1ae65891d4c73_Greedy<TInputBuffer>>(num));
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.N09F3A730B11CE2ACF39EBCBBE8059E25983B9E5B15FBB7087304158AD7C027CD.Helpers.tableReader_e4ee032ba57540b3b3f1ae65891d4c73_Greedy<TInputBuffer> item = FlatSharp.Compiler.Generated.N09F3A730B11CE2ACF39EBCBBE8059E25983B9E5B15FBB7087304158AD7C027CD.Helpers.Parse_Greedy(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		private FlatSharp.Compiler.Generated.N09F3A730B11CE2ACF39EBCBBE8059E25983B9E5B15FBB7087304158AD7C027CD.Helpers.tableReader_e4ee032ba57540b3b3f1ae65891d4c73_Greedy<TInputBuffer> GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, Spell value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(Spell? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(Spell? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(Spell[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<Spell> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(Spell item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, Spell item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(Spell item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ Spell ], Count = {Count}")]
	internal sealed class GeneratedVector_6685333ab54c6b998740bafe35c68445_GreedyMutable<TInputBuffer> : IList<Spell>, ICollection<Spell>, IEnumerable<Spell>, IEnumerable, IReadOnlyList<Spell>, IReadOnlyCollection<Spell> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<Spell> list;

		public Spell this[int index]
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

		public GeneratedVector_6685333ab54c6b998740bafe35c68445_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<Spell> list = (this.list = new List<Spell>());
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.N09F3A730B11CE2ACF39EBCBBE8059E25983B9E5B15FBB7087304158AD7C027CD.Helpers.tableReader_e4ee032ba57540b3b3f1ae65891d4c73_GreedyMutable<TInputBuffer> item = FlatSharp.Compiler.Generated.N09F3A730B11CE2ACF39EBCBBE8059E25983B9E5B15FBB7087304158AD7C027CD.Helpers.Parse_GreedyMutable(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private Spell GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, Spell value)
		{
			list[index] = value;
		}

		public void Add(Spell item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, Spell item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(Spell item)
		{
			return list.Remove(item);
		}

		public bool Contains(Spell? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(Spell? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(Spell[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<Spell> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<Spell> value)
	{
		int count = value.Count;
		int num = 14;
		if (value is Spell[] array)
		{
			foreach (Spell spell in array)
			{
				SerializationHelpers.EnsureNonNull(spell);
				num += FlatSharp.Compiler.Generated.N09F3A730B11CE2ACF39EBCBBE8059E25983B9E5B15FBB7087304158AD7C027CD.Helpers.GetMaxSize(spell);
			}
		}
		else if (value is List<Spell> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				Spell spell2 = list[j];
				SerializationHelpers.EnsureNonNull(spell2);
				num += FlatSharp.Compiler.Generated.N09F3A730B11CE2ACF39EBCBBE8059E25983B9E5B15FBB7087304158AD7C027CD.Helpers.GetMaxSize(spell2);
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				Spell spell3 = value[k];
				SerializationHelpers.EnsureNonNull(spell3);
				num += FlatSharp.Compiler.Generated.N09F3A730B11CE2ACF39EBCBBE8059E25983B9E5B15FBB7087304158AD7C027CD.Helpers.GetMaxSize(spell3);
			}
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<Spell> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 4);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is Spell[] array)
		{
			foreach (Spell spell in array)
			{
				SerializationHelpers.EnsureNonNull(spell);
				FlatSharp.Compiler.Generated.N09F3A730B11CE2ACF39EBCBBE8059E25983B9E5B15FBB7087304158AD7C027CD.Helpers.Serialize(spanWriter, span, spell, num, context);
				num += 4;
			}
		}
		else if (value is List<Spell> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				Spell spell2 = list[j];
				SerializationHelpers.EnsureNonNull(spell2);
				FlatSharp.Compiler.Generated.N09F3A730B11CE2ACF39EBCBBE8059E25983B9E5B15FBB7087304158AD7C027CD.Helpers.Serialize(spanWriter, span, spell2, num, context);
				num += 4;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				Spell spell3 = value[k];
				SerializationHelpers.EnsureNonNull(spell3);
				FlatSharp.Compiler.Generated.N09F3A730B11CE2ACF39EBCBBE8059E25983B9E5B15FBB7087304158AD7C027CD.Helpers.Serialize(spanWriter, span, spell3, num, context);
				num += 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<Spell> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_6685333ab54c6b998740bafe35c68445_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<Spell> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_6685333ab54c6b998740bafe35c68445_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<Spell> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_6685333ab54c6b998740bafe35c68445_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<Spell> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_6685333ab54c6b998740bafe35c68445_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
