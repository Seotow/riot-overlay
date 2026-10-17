using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Snapshot;
using FlatSharp.Compiler.Generated.N2B56B73082175DA2C5035E07A23FB6365491AC33F926C67E4D15FA0E3AC4286E;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.NCB9A05B20B7639A9A58B77F9C00C0571BB27E6890B624889D9DCDA22D0460C4C;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ Perk ], Count = {Count}")]
	internal sealed class GeneratedVector_a7bda5c72f52c74e06fc7e97a92e347e_Lazy<TInputBuffer> : IList<Perk>, ICollection<Perk>, IEnumerable<Perk>, IEnumerable, IReadOnlyList<Perk>, IReadOnlyCollection<Perk>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public Perk this[int index]
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

		int IFlatBufferDeserializedVector.ItemSize => 24;

		int IFlatBufferDeserializedVector.OffsetBase => offset;

		public GeneratedVector_a7bda5c72f52c74e06fc7e97a92e347e_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N2B56B73082175DA2C5035E07A23FB6365491AC33F926C67E4D15FA0E3AC4286E.Helpers.structReader_17c3293f79cf4ebbba438492e8352b4f_Lazy<TInputBuffer> SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N2B56B73082175DA2C5035E07A23FB6365491AC33F926C67E4D15FA0E3AC4286E.Helpers.structReader_17c3293f79cf4ebbba438492e8352b4f_Lazy<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + 24 * index;
			return FlatSharp.Compiler.Generated.N2B56B73082175DA2C5035E07A23FB6365491AC33F926C67E4D15FA0E3AC4286E.Helpers.Parse_Lazy(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, Perk value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(Perk? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(Perk? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(Perk[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<Perk> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(Perk item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, Perk item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(Perk item)
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
			return offset + 24 * index;
		}
	}

	[DebuggerDisplay("Progressive [ Perk ], Count = {Count}")]
	internal sealed class GeneratedVector_a7bda5c72f52c74e06fc7e97a92e347e_Progressive<TInputBuffer> : IList<Perk>, ICollection<Perk>, IEnumerable<Perk>, IEnumerable, IReadOnlyList<Perk>, IReadOnlyCollection<Perk>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly FlatSharp.Compiler.Generated.N2B56B73082175DA2C5035E07A23FB6365491AC33F926C67E4D15FA0E3AC4286E.Helpers.structReader_17c3293f79cf4ebbba438492e8352b4f_Progressive<TInputBuffer>?[]?[] items;

		public Perk this[int index]
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

		int IFlatBufferDeserializedVector.ItemSize => 24;

		int IFlatBufferDeserializedVector.OffsetBase => offset;

		public GeneratedVector_a7bda5c72f52c74e06fc7e97a92e347e_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new FlatSharp.Compiler.Generated.N2B56B73082175DA2C5035E07A23FB6365491AC33F926C67E4D15FA0E3AC4286E.Helpers.structReader_17c3293f79cf4ebbba438492e8352b4f_Progressive<TInputBuffer>[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N2B56B73082175DA2C5035E07A23FB6365491AC33F926C67E4D15FA0E3AC4286E.Helpers.structReader_17c3293f79cf4ebbba438492e8352b4f_Progressive<TInputBuffer>?[] GetOrCreateRow(FlatSharp.Compiler.Generated.N2B56B73082175DA2C5035E07A23FB6365491AC33F926C67E4D15FA0E3AC4286E.Helpers.structReader_17c3293f79cf4ebbba438492e8352b4f_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private FlatSharp.Compiler.Generated.N2B56B73082175DA2C5035E07A23FB6365491AC33F926C67E4D15FA0E3AC4286E.Helpers.structReader_17c3293f79cf4ebbba438492e8352b4f_Progressive<TInputBuffer>?[] CreateRow(FlatSharp.Compiler.Generated.N2B56B73082175DA2C5035E07A23FB6365491AC33F926C67E4D15FA0E3AC4286E.Helpers.structReader_17c3293f79cf4ebbba438492e8352b4f_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] = new FlatSharp.Compiler.Generated.N2B56B73082175DA2C5035E07A23FB6365491AC33F926C67E4D15FA0E3AC4286E.Helpers.structReader_17c3293f79cf4ebbba438492e8352b4f_Progressive<TInputBuffer>[32];
		}

		private FlatSharp.Compiler.Generated.N2B56B73082175DA2C5035E07A23FB6365491AC33F926C67E4D15FA0E3AC4286E.Helpers.structReader_17c3293f79cf4ebbba438492e8352b4f_Progressive<TInputBuffer> ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			FlatSharp.Compiler.Generated.N2B56B73082175DA2C5035E07A23FB6365491AC33F926C67E4D15FA0E3AC4286E.Helpers.structReader_17c3293f79cf4ebbba438492e8352b4f_Progressive<TInputBuffer>[][] array = items;
			FlatSharp.Compiler.Generated.N2B56B73082175DA2C5035E07A23FB6365491AC33F926C67E4D15FA0E3AC4286E.Helpers.structReader_17c3293f79cf4ebbba438492e8352b4f_Progressive<TInputBuffer>[] orCreateRow = GetOrCreateRow(array, rowIndex);
			FlatSharp.Compiler.Generated.N2B56B73082175DA2C5035E07A23FB6365491AC33F926C67E4D15FA0E3AC4286E.Helpers.structReader_17c3293f79cf4ebbba438492e8352b4f_Progressive<TInputBuffer> structReader_17c3293f79cf4ebbba438492e8352b4f_Progressive = orCreateRow[colIndex];
			if (structReader_17c3293f79cf4ebbba438492e8352b4f_Progressive == null)
			{
				structReader_17c3293f79cf4ebbba438492e8352b4f_Progressive = (orCreateRow[colIndex] = UnsafeParseItem(index));
			}
			return structReader_17c3293f79cf4ebbba438492e8352b4f_Progressive;
		}

		private void ProgressiveSet(int index, Perk value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, Perk value)
		{
			VectorUtilities.CheckIndex(index, count);
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N2B56B73082175DA2C5035E07A23FB6365491AC33F926C67E4D15FA0E3AC4286E.Helpers.structReader_17c3293f79cf4ebbba438492e8352b4f_Progressive<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + 24 * index;
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N2B56B73082175DA2C5035E07A23FB6365491AC33F926C67E4D15FA0E3AC4286E.Helpers.structReader_17c3293f79cf4ebbba438492e8352b4f_Progressive<TInputBuffer> UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.N2B56B73082175DA2C5035E07A23FB6365491AC33F926C67E4D15FA0E3AC4286E.Helpers.Parse_Progressive(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, Perk value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(Perk? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(Perk? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(Perk[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<Perk> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(Perk item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, Perk item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(Perk item)
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
			return offset + 24 * index;
		}
	}

	[DebuggerDisplay("Greedy [ Perk ], Count = {Count}")]
	internal sealed class GeneratedVector_a7bda5c72f52c74e06fc7e97a92e347e_Greedy<TInputBuffer> : IList<Perk>, ICollection<Perk>, IEnumerable<Perk>, IEnumerable, IReadOnlyList<Perk>, IReadOnlyCollection<Perk> where TInputBuffer : IInputBuffer
	{
		private readonly List<FlatSharp.Compiler.Generated.N2B56B73082175DA2C5035E07A23FB6365491AC33F926C67E4D15FA0E3AC4286E.Helpers.structReader_17c3293f79cf4ebbba438492e8352b4f_Greedy<TInputBuffer>> list;

		public Perk this[int index]
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

		public GeneratedVector_a7bda5c72f52c74e06fc7e97a92e347e_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<FlatSharp.Compiler.Generated.N2B56B73082175DA2C5035E07A23FB6365491AC33F926C67E4D15FA0E3AC4286E.Helpers.structReader_17c3293f79cf4ebbba438492e8352b4f_Greedy<TInputBuffer>> list = (this.list = new List<FlatSharp.Compiler.Generated.N2B56B73082175DA2C5035E07A23FB6365491AC33F926C67E4D15FA0E3AC4286E.Helpers.structReader_17c3293f79cf4ebbba438492e8352b4f_Greedy<TInputBuffer>>(num));
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.N2B56B73082175DA2C5035E07A23FB6365491AC33F926C67E4D15FA0E3AC4286E.Helpers.structReader_17c3293f79cf4ebbba438492e8352b4f_Greedy<TInputBuffer> item = FlatSharp.Compiler.Generated.N2B56B73082175DA2C5035E07A23FB6365491AC33F926C67E4D15FA0E3AC4286E.Helpers.Parse_Greedy(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 24;
			}
		}

		private FlatSharp.Compiler.Generated.N2B56B73082175DA2C5035E07A23FB6365491AC33F926C67E4D15FA0E3AC4286E.Helpers.structReader_17c3293f79cf4ebbba438492e8352b4f_Greedy<TInputBuffer> GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, Perk value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(Perk? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(Perk? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(Perk[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<Perk> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(Perk item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, Perk item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(Perk item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ Perk ], Count = {Count}")]
	internal sealed class GeneratedVector_a7bda5c72f52c74e06fc7e97a92e347e_GreedyMutable<TInputBuffer> : IList<Perk>, ICollection<Perk>, IEnumerable<Perk>, IEnumerable, IReadOnlyList<Perk>, IReadOnlyCollection<Perk> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<Perk> list;

		public Perk this[int index]
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

		public GeneratedVector_a7bda5c72f52c74e06fc7e97a92e347e_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<Perk> list = (this.list = new List<Perk>());
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.N2B56B73082175DA2C5035E07A23FB6365491AC33F926C67E4D15FA0E3AC4286E.Helpers.structReader_17c3293f79cf4ebbba438492e8352b4f_GreedyMutable<TInputBuffer> item = FlatSharp.Compiler.Generated.N2B56B73082175DA2C5035E07A23FB6365491AC33F926C67E4D15FA0E3AC4286E.Helpers.Parse_GreedyMutable(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 24;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private Perk GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, Perk value)
		{
			list[index] = value;
		}

		public void Add(Perk item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, Perk item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(Perk item)
		{
			return list.Remove(item);
		}

		public bool Contains(Perk? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(Perk? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(Perk[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<Perk> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<Perk> value)
	{
		return 14 + 24 * value.Count;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<Perk> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(8, count, 24);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is Perk[] array)
		{
			foreach (Perk perk in array)
			{
				SerializationHelpers.EnsureNonNull(perk);
				FlatSharp.Compiler.Generated.N2B56B73082175DA2C5035E07A23FB6365491AC33F926C67E4D15FA0E3AC4286E.Helpers.Serialize(spanWriter, span, perk, num);
				num += 24;
			}
		}
		else if (value is List<Perk> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				Perk perk2 = list[j];
				SerializationHelpers.EnsureNonNull(perk2);
				FlatSharp.Compiler.Generated.N2B56B73082175DA2C5035E07A23FB6365491AC33F926C67E4D15FA0E3AC4286E.Helpers.Serialize(spanWriter, span, perk2, num);
				num += 24;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				Perk perk3 = value[k];
				SerializationHelpers.EnsureNonNull(perk3);
				FlatSharp.Compiler.Generated.N2B56B73082175DA2C5035E07A23FB6365491AC33F926C67E4D15FA0E3AC4286E.Helpers.Serialize(spanWriter, span, perk3, num);
				num += 24;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<Perk> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_a7bda5c72f52c74e06fc7e97a92e347e_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<Perk> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_a7bda5c72f52c74e06fc7e97a92e347e_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<Perk> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_a7bda5c72f52c74e06fc7e97a92e347e_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<Perk> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_a7bda5c72f52c74e06fc7e97a92e347e_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
