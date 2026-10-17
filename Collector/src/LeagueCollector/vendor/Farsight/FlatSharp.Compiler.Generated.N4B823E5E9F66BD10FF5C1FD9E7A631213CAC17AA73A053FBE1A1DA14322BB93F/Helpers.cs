using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Snapshot;
using FlatSharp.Compiler.Generated.N0D9C85A27A47F12BE900EDFDECA4F26E7780B088DAF8B4D61679E4B4E3BA46FA;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N4B823E5E9F66BD10FF5C1FD9E7A631213CAC17AA73A053FBE1A1DA14322BB93F;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ SpellObjectEntry ], Count = {Count}")]
	internal sealed class GeneratedVector_4205309607beb20e4a62954a162f957a_Lazy<TInputBuffer> : IList<SpellObjectEntry>, ICollection<SpellObjectEntry>, IEnumerable<SpellObjectEntry>, IEnumerable, IReadOnlyList<SpellObjectEntry>, IReadOnlyCollection<SpellObjectEntry>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public SpellObjectEntry this[int index]
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

		public GeneratedVector_4205309607beb20e4a62954a162f957a_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N0D9C85A27A47F12BE900EDFDECA4F26E7780B088DAF8B4D61679E4B4E3BA46FA.Helpers.tableReader_f677102bdebb483083ac018233c9b076_Lazy<TInputBuffer> SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N0D9C85A27A47F12BE900EDFDECA4F26E7780B088DAF8B4D61679E4B4E3BA46FA.Helpers.tableReader_f677102bdebb483083ac018233c9b076_Lazy<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return FlatSharp.Compiler.Generated.N0D9C85A27A47F12BE900EDFDECA4F26E7780B088DAF8B4D61679E4B4E3BA46FA.Helpers.Parse_Lazy(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, SpellObjectEntry value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(SpellObjectEntry? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(SpellObjectEntry? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(SpellObjectEntry[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<SpellObjectEntry> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(SpellObjectEntry item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, SpellObjectEntry item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(SpellObjectEntry item)
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

	[DebuggerDisplay("Progressive [ SpellObjectEntry ], Count = {Count}")]
	internal sealed class GeneratedVector_4205309607beb20e4a62954a162f957a_Progressive<TInputBuffer> : IList<SpellObjectEntry>, ICollection<SpellObjectEntry>, IEnumerable<SpellObjectEntry>, IEnumerable, IReadOnlyList<SpellObjectEntry>, IReadOnlyCollection<SpellObjectEntry>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly FlatSharp.Compiler.Generated.N0D9C85A27A47F12BE900EDFDECA4F26E7780B088DAF8B4D61679E4B4E3BA46FA.Helpers.tableReader_f677102bdebb483083ac018233c9b076_Progressive<TInputBuffer>?[]?[] items;

		public SpellObjectEntry this[int index]
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

		public GeneratedVector_4205309607beb20e4a62954a162f957a_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new FlatSharp.Compiler.Generated.N0D9C85A27A47F12BE900EDFDECA4F26E7780B088DAF8B4D61679E4B4E3BA46FA.Helpers.tableReader_f677102bdebb483083ac018233c9b076_Progressive<TInputBuffer>[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N0D9C85A27A47F12BE900EDFDECA4F26E7780B088DAF8B4D61679E4B4E3BA46FA.Helpers.tableReader_f677102bdebb483083ac018233c9b076_Progressive<TInputBuffer>?[] GetOrCreateRow(FlatSharp.Compiler.Generated.N0D9C85A27A47F12BE900EDFDECA4F26E7780B088DAF8B4D61679E4B4E3BA46FA.Helpers.tableReader_f677102bdebb483083ac018233c9b076_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private FlatSharp.Compiler.Generated.N0D9C85A27A47F12BE900EDFDECA4F26E7780B088DAF8B4D61679E4B4E3BA46FA.Helpers.tableReader_f677102bdebb483083ac018233c9b076_Progressive<TInputBuffer>?[] CreateRow(FlatSharp.Compiler.Generated.N0D9C85A27A47F12BE900EDFDECA4F26E7780B088DAF8B4D61679E4B4E3BA46FA.Helpers.tableReader_f677102bdebb483083ac018233c9b076_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] = new FlatSharp.Compiler.Generated.N0D9C85A27A47F12BE900EDFDECA4F26E7780B088DAF8B4D61679E4B4E3BA46FA.Helpers.tableReader_f677102bdebb483083ac018233c9b076_Progressive<TInputBuffer>[32];
		}

		private FlatSharp.Compiler.Generated.N0D9C85A27A47F12BE900EDFDECA4F26E7780B088DAF8B4D61679E4B4E3BA46FA.Helpers.tableReader_f677102bdebb483083ac018233c9b076_Progressive<TInputBuffer> ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			FlatSharp.Compiler.Generated.N0D9C85A27A47F12BE900EDFDECA4F26E7780B088DAF8B4D61679E4B4E3BA46FA.Helpers.tableReader_f677102bdebb483083ac018233c9b076_Progressive<TInputBuffer>[][] array = items;
			FlatSharp.Compiler.Generated.N0D9C85A27A47F12BE900EDFDECA4F26E7780B088DAF8B4D61679E4B4E3BA46FA.Helpers.tableReader_f677102bdebb483083ac018233c9b076_Progressive<TInputBuffer>[] orCreateRow = GetOrCreateRow(array, rowIndex);
			FlatSharp.Compiler.Generated.N0D9C85A27A47F12BE900EDFDECA4F26E7780B088DAF8B4D61679E4B4E3BA46FA.Helpers.tableReader_f677102bdebb483083ac018233c9b076_Progressive<TInputBuffer> tableReader_f677102bdebb483083ac018233c9b076_Progressive = orCreateRow[colIndex];
			if (tableReader_f677102bdebb483083ac018233c9b076_Progressive == null)
			{
				tableReader_f677102bdebb483083ac018233c9b076_Progressive = (orCreateRow[colIndex] = UnsafeParseItem(index));
			}
			return tableReader_f677102bdebb483083ac018233c9b076_Progressive;
		}

		private void ProgressiveSet(int index, SpellObjectEntry value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, SpellObjectEntry value)
		{
			VectorUtilities.CheckIndex(index, count);
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N0D9C85A27A47F12BE900EDFDECA4F26E7780B088DAF8B4D61679E4B4E3BA46FA.Helpers.tableReader_f677102bdebb483083ac018233c9b076_Progressive<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N0D9C85A27A47F12BE900EDFDECA4F26E7780B088DAF8B4D61679E4B4E3BA46FA.Helpers.tableReader_f677102bdebb483083ac018233c9b076_Progressive<TInputBuffer> UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.N0D9C85A27A47F12BE900EDFDECA4F26E7780B088DAF8B4D61679E4B4E3BA46FA.Helpers.Parse_Progressive(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, SpellObjectEntry value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(SpellObjectEntry? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(SpellObjectEntry? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(SpellObjectEntry[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<SpellObjectEntry> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(SpellObjectEntry item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, SpellObjectEntry item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(SpellObjectEntry item)
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

	[DebuggerDisplay("Greedy [ SpellObjectEntry ], Count = {Count}")]
	internal sealed class GeneratedVector_4205309607beb20e4a62954a162f957a_Greedy<TInputBuffer> : IList<SpellObjectEntry>, ICollection<SpellObjectEntry>, IEnumerable<SpellObjectEntry>, IEnumerable, IReadOnlyList<SpellObjectEntry>, IReadOnlyCollection<SpellObjectEntry> where TInputBuffer : IInputBuffer
	{
		private readonly List<FlatSharp.Compiler.Generated.N0D9C85A27A47F12BE900EDFDECA4F26E7780B088DAF8B4D61679E4B4E3BA46FA.Helpers.tableReader_f677102bdebb483083ac018233c9b076_Greedy<TInputBuffer>> list;

		public SpellObjectEntry this[int index]
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

		public GeneratedVector_4205309607beb20e4a62954a162f957a_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<FlatSharp.Compiler.Generated.N0D9C85A27A47F12BE900EDFDECA4F26E7780B088DAF8B4D61679E4B4E3BA46FA.Helpers.tableReader_f677102bdebb483083ac018233c9b076_Greedy<TInputBuffer>> list = (this.list = new List<FlatSharp.Compiler.Generated.N0D9C85A27A47F12BE900EDFDECA4F26E7780B088DAF8B4D61679E4B4E3BA46FA.Helpers.tableReader_f677102bdebb483083ac018233c9b076_Greedy<TInputBuffer>>(num));
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.N0D9C85A27A47F12BE900EDFDECA4F26E7780B088DAF8B4D61679E4B4E3BA46FA.Helpers.tableReader_f677102bdebb483083ac018233c9b076_Greedy<TInputBuffer> item = FlatSharp.Compiler.Generated.N0D9C85A27A47F12BE900EDFDECA4F26E7780B088DAF8B4D61679E4B4E3BA46FA.Helpers.Parse_Greedy(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		private FlatSharp.Compiler.Generated.N0D9C85A27A47F12BE900EDFDECA4F26E7780B088DAF8B4D61679E4B4E3BA46FA.Helpers.tableReader_f677102bdebb483083ac018233c9b076_Greedy<TInputBuffer> GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, SpellObjectEntry value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(SpellObjectEntry? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(SpellObjectEntry? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(SpellObjectEntry[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<SpellObjectEntry> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(SpellObjectEntry item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, SpellObjectEntry item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(SpellObjectEntry item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ SpellObjectEntry ], Count = {Count}")]
	internal sealed class GeneratedVector_4205309607beb20e4a62954a162f957a_GreedyMutable<TInputBuffer> : IList<SpellObjectEntry>, ICollection<SpellObjectEntry>, IEnumerable<SpellObjectEntry>, IEnumerable, IReadOnlyList<SpellObjectEntry>, IReadOnlyCollection<SpellObjectEntry> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<SpellObjectEntry> list;

		public SpellObjectEntry this[int index]
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

		public GeneratedVector_4205309607beb20e4a62954a162f957a_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<SpellObjectEntry> list = (this.list = new List<SpellObjectEntry>());
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.N0D9C85A27A47F12BE900EDFDECA4F26E7780B088DAF8B4D61679E4B4E3BA46FA.Helpers.tableReader_f677102bdebb483083ac018233c9b076_GreedyMutable<TInputBuffer> item = FlatSharp.Compiler.Generated.N0D9C85A27A47F12BE900EDFDECA4F26E7780B088DAF8B4D61679E4B4E3BA46FA.Helpers.Parse_GreedyMutable(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private SpellObjectEntry GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, SpellObjectEntry value)
		{
			list[index] = value;
		}

		public void Add(SpellObjectEntry item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, SpellObjectEntry item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(SpellObjectEntry item)
		{
			return list.Remove(item);
		}

		public bool Contains(SpellObjectEntry? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(SpellObjectEntry? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(SpellObjectEntry[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<SpellObjectEntry> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<SpellObjectEntry> value)
	{
		int count = value.Count;
		int num = 14;
		if (value is SpellObjectEntry[] array)
		{
			foreach (SpellObjectEntry spellObjectEntry in array)
			{
				SerializationHelpers.EnsureNonNull(spellObjectEntry);
				num += FlatSharp.Compiler.Generated.N0D9C85A27A47F12BE900EDFDECA4F26E7780B088DAF8B4D61679E4B4E3BA46FA.Helpers.GetMaxSize(spellObjectEntry);
			}
		}
		else if (value is List<SpellObjectEntry> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				SpellObjectEntry spellObjectEntry2 = list[j];
				SerializationHelpers.EnsureNonNull(spellObjectEntry2);
				num += FlatSharp.Compiler.Generated.N0D9C85A27A47F12BE900EDFDECA4F26E7780B088DAF8B4D61679E4B4E3BA46FA.Helpers.GetMaxSize(spellObjectEntry2);
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				SpellObjectEntry spellObjectEntry3 = value[k];
				SerializationHelpers.EnsureNonNull(spellObjectEntry3);
				num += FlatSharp.Compiler.Generated.N0D9C85A27A47F12BE900EDFDECA4F26E7780B088DAF8B4D61679E4B4E3BA46FA.Helpers.GetMaxSize(spellObjectEntry3);
			}
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<SpellObjectEntry> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 4);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is SpellObjectEntry[] array)
		{
			foreach (SpellObjectEntry spellObjectEntry in array)
			{
				SerializationHelpers.EnsureNonNull(spellObjectEntry);
				FlatSharp.Compiler.Generated.N0D9C85A27A47F12BE900EDFDECA4F26E7780B088DAF8B4D61679E4B4E3BA46FA.Helpers.Serialize(spanWriter, span, spellObjectEntry, num, context);
				num += 4;
			}
		}
		else if (value is List<SpellObjectEntry> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				SpellObjectEntry spellObjectEntry2 = list[j];
				SerializationHelpers.EnsureNonNull(spellObjectEntry2);
				FlatSharp.Compiler.Generated.N0D9C85A27A47F12BE900EDFDECA4F26E7780B088DAF8B4D61679E4B4E3BA46FA.Helpers.Serialize(spanWriter, span, spellObjectEntry2, num, context);
				num += 4;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				SpellObjectEntry spellObjectEntry3 = value[k];
				SerializationHelpers.EnsureNonNull(spellObjectEntry3);
				FlatSharp.Compiler.Generated.N0D9C85A27A47F12BE900EDFDECA4F26E7780B088DAF8B4D61679E4B4E3BA46FA.Helpers.Serialize(spanWriter, span, spellObjectEntry3, num, context);
				num += 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<SpellObjectEntry> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_4205309607beb20e4a62954a162f957a_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<SpellObjectEntry> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_4205309607beb20e4a62954a162f957a_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<SpellObjectEntry> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_4205309607beb20e4a62954a162f957a_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<SpellObjectEntry> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_4205309607beb20e4a62954a162f957a_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
