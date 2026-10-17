using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FlatSharp.Compiler.Generated.ND5802027154E3862E3DC1ECBFAC480E0946C1D3F83FAE1301753B92402055A9E;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.NDE52D662B5A93C33926F2EF0FD6532C66D3C094343A1E5133FA68FF987719D55;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ UInt64 ], Count = {Count}")]
	internal sealed class GeneratedVector_e76272ab09cb5a95ca0b1d067fd428d7_Lazy<TInputBuffer> : IList<ulong>, ICollection<ulong>, IEnumerable<ulong>, IEnumerable, IReadOnlyList<ulong>, IReadOnlyCollection<ulong>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public ulong this[int index]
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

		int IFlatBufferDeserializedVector.ItemSize => 8;

		int IFlatBufferDeserializedVector.OffsetBase => offset;

		public GeneratedVector_e76272ab09cb5a95ca0b1d067fd428d7_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private ulong SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private ulong UnsafeParseItem(int index)
		{
			int num = offset + (index << 3);
			return FlatSharp.Compiler.Generated.ND5802027154E3862E3DC1ECBFAC480E0946C1D3F83FAE1301753B92402055A9E.Helpers.Parse(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, ulong value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(ulong item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(ulong item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(ulong[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<ulong> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(ulong item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, ulong item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(ulong item)
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
			return offset + (index << 3);
		}
	}

	[DebuggerDisplay("Progressive [ UInt64 ], Count = {Count}")]
	internal sealed class GeneratedVector_e76272ab09cb5a95ca0b1d067fd428d7_Progressive<TInputBuffer> : IList<ulong>, ICollection<ulong>, IEnumerable<ulong>, IEnumerable, IReadOnlyList<ulong>, IReadOnlyCollection<ulong>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly ulong[]?[] items;

		public ulong this[int index]
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

		int IFlatBufferDeserializedVector.ItemSize => 8;

		int IFlatBufferDeserializedVector.OffsetBase => offset;

		public GeneratedVector_e76272ab09cb5a95ca0b1d067fd428d7_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new ulong[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private ulong[] GetOrCreateRow(ulong[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private ulong[] CreateRow(ulong[]?[] items, uint rowIndex)
		{
			ulong[] array = (items[rowIndex] = new ulong[32]);
			int num = (int)(rowIndex << 5);
			int num2 = 32;
			int num3 = count - num;
			if (num3 < 32)
			{
				num2 = num3;
			}
			int num4 = offset + (num << 3);
			for (int i = 0; i < num2; i++)
			{
				array[i] = UnsafeParseFromOffset(num4);
				num4 += 8;
			}
			return array;
		}

		private ulong ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			ulong[][] array = items;
			return GetOrCreateRow(array, rowIndex)[colIndex];
		}

		private void ProgressiveSet(int index, ulong value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, ulong value)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			GetOrCreateRow(items, rowIndex)[colIndex] = value;
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private ulong UnsafeParseItem(int index)
		{
			int num = offset + (index << 3);
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private ulong UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.ND5802027154E3862E3DC1ECBFAC480E0946C1D3F83FAE1301753B92402055A9E.Helpers.Parse(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, ulong value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(ulong item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(ulong item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(ulong[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<ulong> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(ulong item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, ulong item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(ulong item)
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
			return offset + (index << 3);
		}
	}

	[DebuggerDisplay("Greedy [ UInt64 ], Count = {Count}")]
	internal sealed class GeneratedVector_e76272ab09cb5a95ca0b1d067fd428d7_Greedy<TInputBuffer> : IList<ulong>, ICollection<ulong>, IEnumerable<ulong>, IEnumerable, IReadOnlyList<ulong>, IReadOnlyCollection<ulong> where TInputBuffer : IInputBuffer
	{
		private readonly List<ulong> list;

		public ulong this[int index]
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

		public GeneratedVector_e76272ab09cb5a95ca0b1d067fd428d7_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<ulong> list = (this.list = new List<ulong>(num));
			for (int i = 0; i < num; i++)
			{
				ulong item = FlatSharp.Compiler.Generated.ND5802027154E3862E3DC1ECBFAC480E0946C1D3F83FAE1301753B92402055A9E.Helpers.Parse(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 8;
			}
		}

		private ulong GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, ulong value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(ulong item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(ulong item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(ulong[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<ulong> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(ulong item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, ulong item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(ulong item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ UInt64 ], Count = {Count}")]
	internal sealed class GeneratedVector_e76272ab09cb5a95ca0b1d067fd428d7_GreedyMutable<TInputBuffer> : IList<ulong>, ICollection<ulong>, IEnumerable<ulong>, IEnumerable, IReadOnlyList<ulong>, IReadOnlyCollection<ulong> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<ulong> list;

		public ulong this[int index]
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

		public GeneratedVector_e76272ab09cb5a95ca0b1d067fd428d7_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<ulong> list = (this.list = new List<ulong>());
			for (int i = 0; i < num; i++)
			{
				ulong item = FlatSharp.Compiler.Generated.ND5802027154E3862E3DC1ECBFAC480E0946C1D3F83FAE1301753B92402055A9E.Helpers.Parse(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 8;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private ulong GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, ulong value)
		{
			list[index] = value;
		}

		public void Add(ulong item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, ulong item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(ulong item)
		{
			return list.Remove(item);
		}

		public bool Contains(ulong item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(ulong item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(ulong[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<ulong> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<ulong> value)
	{
		return 14 + 8 * value.Count;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<ulong> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(8, count, 8);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is ulong[] array)
		{
			foreach (ulong value2 in array)
			{
				FlatSharp.Compiler.Generated.ND5802027154E3862E3DC1ECBFAC480E0946C1D3F83FAE1301753B92402055A9E.Helpers.Serialize(spanWriter, span, value2, num);
				num += 8;
			}
		}
		else if (value is List<ulong> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				ulong value3 = list[j];
				FlatSharp.Compiler.Generated.ND5802027154E3862E3DC1ECBFAC480E0946C1D3F83FAE1301753B92402055A9E.Helpers.Serialize(spanWriter, span, value3, num);
				num += 8;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				ulong value4 = value[k];
				FlatSharp.Compiler.Generated.ND5802027154E3862E3DC1ECBFAC480E0946C1D3F83FAE1301753B92402055A9E.Helpers.Serialize(spanWriter, span, value4, num);
				num += 8;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<ulong> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_e76272ab09cb5a95ca0b1d067fd428d7_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<ulong> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_e76272ab09cb5a95ca0b1d067fd428d7_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<ulong> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_e76272ab09cb5a95ca0b1d067fd428d7_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<ulong> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_e76272ab09cb5a95ca0b1d067fd428d7_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
