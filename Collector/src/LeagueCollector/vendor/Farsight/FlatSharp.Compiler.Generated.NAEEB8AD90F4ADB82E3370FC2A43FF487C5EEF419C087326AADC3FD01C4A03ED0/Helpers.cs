using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Sequencer;
using FlatSharp.Compiler.Generated.N835770674D9CC31E7E5211169D9DA0B862ED4C9325F09C793690BE6C452C86C3;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.NAEEB8AD90F4ADB82E3370FC2A43FF487C5EEF419C087326AADC3FD01C4A03ED0;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ Section ], Count = {Count}")]
	internal sealed class GeneratedVector_efe2d8ec307b8a61532a94faf4839516_Lazy<TInputBuffer> : IList<Section>, ICollection<Section>, IEnumerable<Section>, IEnumerable, IReadOnlyList<Section>, IReadOnlyCollection<Section>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public Section this[int index]
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

		public GeneratedVector_efe2d8ec307b8a61532a94faf4839516_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N835770674D9CC31E7E5211169D9DA0B862ED4C9325F09C793690BE6C452C86C3.Helpers.tableReader_5717578db91349ada79ee5e964105a00_Lazy<TInputBuffer> SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N835770674D9CC31E7E5211169D9DA0B862ED4C9325F09C793690BE6C452C86C3.Helpers.tableReader_5717578db91349ada79ee5e964105a00_Lazy<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return FlatSharp.Compiler.Generated.N835770674D9CC31E7E5211169D9DA0B862ED4C9325F09C793690BE6C452C86C3.Helpers.Parse_Lazy(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, Section value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(Section? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(Section? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(Section[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<Section> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(Section item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, Section item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(Section item)
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

	[DebuggerDisplay("Progressive [ Section ], Count = {Count}")]
	internal sealed class GeneratedVector_efe2d8ec307b8a61532a94faf4839516_Progressive<TInputBuffer> : IList<Section>, ICollection<Section>, IEnumerable<Section>, IEnumerable, IReadOnlyList<Section>, IReadOnlyCollection<Section>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly FlatSharp.Compiler.Generated.N835770674D9CC31E7E5211169D9DA0B862ED4C9325F09C793690BE6C452C86C3.Helpers.tableReader_5717578db91349ada79ee5e964105a00_Progressive<TInputBuffer>?[]?[] items;

		public Section this[int index]
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

		public GeneratedVector_efe2d8ec307b8a61532a94faf4839516_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new FlatSharp.Compiler.Generated.N835770674D9CC31E7E5211169D9DA0B862ED4C9325F09C793690BE6C452C86C3.Helpers.tableReader_5717578db91349ada79ee5e964105a00_Progressive<TInputBuffer>[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N835770674D9CC31E7E5211169D9DA0B862ED4C9325F09C793690BE6C452C86C3.Helpers.tableReader_5717578db91349ada79ee5e964105a00_Progressive<TInputBuffer>?[] GetOrCreateRow(FlatSharp.Compiler.Generated.N835770674D9CC31E7E5211169D9DA0B862ED4C9325F09C793690BE6C452C86C3.Helpers.tableReader_5717578db91349ada79ee5e964105a00_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private FlatSharp.Compiler.Generated.N835770674D9CC31E7E5211169D9DA0B862ED4C9325F09C793690BE6C452C86C3.Helpers.tableReader_5717578db91349ada79ee5e964105a00_Progressive<TInputBuffer>?[] CreateRow(FlatSharp.Compiler.Generated.N835770674D9CC31E7E5211169D9DA0B862ED4C9325F09C793690BE6C452C86C3.Helpers.tableReader_5717578db91349ada79ee5e964105a00_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] = new FlatSharp.Compiler.Generated.N835770674D9CC31E7E5211169D9DA0B862ED4C9325F09C793690BE6C452C86C3.Helpers.tableReader_5717578db91349ada79ee5e964105a00_Progressive<TInputBuffer>[32];
		}

		private FlatSharp.Compiler.Generated.N835770674D9CC31E7E5211169D9DA0B862ED4C9325F09C793690BE6C452C86C3.Helpers.tableReader_5717578db91349ada79ee5e964105a00_Progressive<TInputBuffer> ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			FlatSharp.Compiler.Generated.N835770674D9CC31E7E5211169D9DA0B862ED4C9325F09C793690BE6C452C86C3.Helpers.tableReader_5717578db91349ada79ee5e964105a00_Progressive<TInputBuffer>[][] array = items;
			FlatSharp.Compiler.Generated.N835770674D9CC31E7E5211169D9DA0B862ED4C9325F09C793690BE6C452C86C3.Helpers.tableReader_5717578db91349ada79ee5e964105a00_Progressive<TInputBuffer>[] orCreateRow = GetOrCreateRow(array, rowIndex);
			FlatSharp.Compiler.Generated.N835770674D9CC31E7E5211169D9DA0B862ED4C9325F09C793690BE6C452C86C3.Helpers.tableReader_5717578db91349ada79ee5e964105a00_Progressive<TInputBuffer> tableReader_5717578db91349ada79ee5e964105a00_Progressive = orCreateRow[colIndex];
			if (tableReader_5717578db91349ada79ee5e964105a00_Progressive == null)
			{
				tableReader_5717578db91349ada79ee5e964105a00_Progressive = (orCreateRow[colIndex] = UnsafeParseItem(index));
			}
			return tableReader_5717578db91349ada79ee5e964105a00_Progressive;
		}

		private void ProgressiveSet(int index, Section value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, Section value)
		{
			VectorUtilities.CheckIndex(index, count);
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N835770674D9CC31E7E5211169D9DA0B862ED4C9325F09C793690BE6C452C86C3.Helpers.tableReader_5717578db91349ada79ee5e964105a00_Progressive<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N835770674D9CC31E7E5211169D9DA0B862ED4C9325F09C793690BE6C452C86C3.Helpers.tableReader_5717578db91349ada79ee5e964105a00_Progressive<TInputBuffer> UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.N835770674D9CC31E7E5211169D9DA0B862ED4C9325F09C793690BE6C452C86C3.Helpers.Parse_Progressive(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, Section value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(Section? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(Section? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(Section[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<Section> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(Section item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, Section item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(Section item)
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

	[DebuggerDisplay("Greedy [ Section ], Count = {Count}")]
	internal sealed class GeneratedVector_efe2d8ec307b8a61532a94faf4839516_Greedy<TInputBuffer> : IList<Section>, ICollection<Section>, IEnumerable<Section>, IEnumerable, IReadOnlyList<Section>, IReadOnlyCollection<Section> where TInputBuffer : IInputBuffer
	{
		private readonly List<FlatSharp.Compiler.Generated.N835770674D9CC31E7E5211169D9DA0B862ED4C9325F09C793690BE6C452C86C3.Helpers.tableReader_5717578db91349ada79ee5e964105a00_Greedy<TInputBuffer>> list;

		public Section this[int index]
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

		public GeneratedVector_efe2d8ec307b8a61532a94faf4839516_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<FlatSharp.Compiler.Generated.N835770674D9CC31E7E5211169D9DA0B862ED4C9325F09C793690BE6C452C86C3.Helpers.tableReader_5717578db91349ada79ee5e964105a00_Greedy<TInputBuffer>> list = (this.list = new List<FlatSharp.Compiler.Generated.N835770674D9CC31E7E5211169D9DA0B862ED4C9325F09C793690BE6C452C86C3.Helpers.tableReader_5717578db91349ada79ee5e964105a00_Greedy<TInputBuffer>>(num));
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.N835770674D9CC31E7E5211169D9DA0B862ED4C9325F09C793690BE6C452C86C3.Helpers.tableReader_5717578db91349ada79ee5e964105a00_Greedy<TInputBuffer> item = FlatSharp.Compiler.Generated.N835770674D9CC31E7E5211169D9DA0B862ED4C9325F09C793690BE6C452C86C3.Helpers.Parse_Greedy(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		private FlatSharp.Compiler.Generated.N835770674D9CC31E7E5211169D9DA0B862ED4C9325F09C793690BE6C452C86C3.Helpers.tableReader_5717578db91349ada79ee5e964105a00_Greedy<TInputBuffer> GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, Section value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(Section? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(Section? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(Section[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<Section> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(Section item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, Section item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(Section item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ Section ], Count = {Count}")]
	internal sealed class GeneratedVector_efe2d8ec307b8a61532a94faf4839516_GreedyMutable<TInputBuffer> : IList<Section>, ICollection<Section>, IEnumerable<Section>, IEnumerable, IReadOnlyList<Section>, IReadOnlyCollection<Section> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<Section> list;

		public Section this[int index]
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

		public GeneratedVector_efe2d8ec307b8a61532a94faf4839516_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<Section> list = (this.list = new List<Section>());
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.N835770674D9CC31E7E5211169D9DA0B862ED4C9325F09C793690BE6C452C86C3.Helpers.tableReader_5717578db91349ada79ee5e964105a00_GreedyMutable<TInputBuffer> item = FlatSharp.Compiler.Generated.N835770674D9CC31E7E5211169D9DA0B862ED4C9325F09C793690BE6C452C86C3.Helpers.Parse_GreedyMutable(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private Section GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, Section value)
		{
			list[index] = value;
		}

		public void Add(Section item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, Section item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(Section item)
		{
			return list.Remove(item);
		}

		public bool Contains(Section? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(Section? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(Section[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<Section> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<Section> value)
	{
		int count = value.Count;
		int num = 14;
		if (value is Section[] array)
		{
			foreach (Section section in array)
			{
				SerializationHelpers.EnsureNonNull(section);
				num += FlatSharp.Compiler.Generated.N835770674D9CC31E7E5211169D9DA0B862ED4C9325F09C793690BE6C452C86C3.Helpers.GetMaxSize(section);
			}
		}
		else if (value is List<Section> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				Section section2 = list[j];
				SerializationHelpers.EnsureNonNull(section2);
				num += FlatSharp.Compiler.Generated.N835770674D9CC31E7E5211169D9DA0B862ED4C9325F09C793690BE6C452C86C3.Helpers.GetMaxSize(section2);
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				Section section3 = value[k];
				SerializationHelpers.EnsureNonNull(section3);
				num += FlatSharp.Compiler.Generated.N835770674D9CC31E7E5211169D9DA0B862ED4C9325F09C793690BE6C452C86C3.Helpers.GetMaxSize(section3);
			}
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<Section> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 4);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is Section[] array)
		{
			foreach (Section section in array)
			{
				SerializationHelpers.EnsureNonNull(section);
				FlatSharp.Compiler.Generated.N835770674D9CC31E7E5211169D9DA0B862ED4C9325F09C793690BE6C452C86C3.Helpers.Serialize(spanWriter, span, section, num, context);
				num += 4;
			}
		}
		else if (value is List<Section> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				Section section2 = list[j];
				SerializationHelpers.EnsureNonNull(section2);
				FlatSharp.Compiler.Generated.N835770674D9CC31E7E5211169D9DA0B862ED4C9325F09C793690BE6C452C86C3.Helpers.Serialize(spanWriter, span, section2, num, context);
				num += 4;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				Section section3 = value[k];
				SerializationHelpers.EnsureNonNull(section3);
				FlatSharp.Compiler.Generated.N835770674D9CC31E7E5211169D9DA0B862ED4C9325F09C793690BE6C452C86C3.Helpers.Serialize(spanWriter, span, section3, num, context);
				num += 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<Section> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_efe2d8ec307b8a61532a94faf4839516_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<Section> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_efe2d8ec307b8a61532a94faf4839516_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<Section> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_efe2d8ec307b8a61532a94faf4839516_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<Section> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_efe2d8ec307b8a61532a94faf4839516_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
