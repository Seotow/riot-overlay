using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Sequencer;
using FlatSharp.Compiler.Generated.NF688861FB2AFD76432ACA42547B1899571F0EBA88BC62C54D54FFD56FA8D0EBE;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N85F4A922125BF53EB83B0638C608992B9F317AAC31B591F3458D0E8AC2F6D1D4;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ Binding ], Count = {Count}")]
	internal sealed class GeneratedVector_bc6a62cde5e524880c8fc296846a008b_Lazy<TInputBuffer> : IList<Binding>, ICollection<Binding>, IEnumerable<Binding>, IEnumerable, IReadOnlyList<Binding>, IReadOnlyCollection<Binding>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public Binding this[int index]
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

		public GeneratedVector_bc6a62cde5e524880c8fc296846a008b_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NF688861FB2AFD76432ACA42547B1899571F0EBA88BC62C54D54FFD56FA8D0EBE.Helpers.tableReader_9ec39faeb2df4b9c8feade9dd6b51573_Lazy<TInputBuffer> SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NF688861FB2AFD76432ACA42547B1899571F0EBA88BC62C54D54FFD56FA8D0EBE.Helpers.tableReader_9ec39faeb2df4b9c8feade9dd6b51573_Lazy<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return FlatSharp.Compiler.Generated.NF688861FB2AFD76432ACA42547B1899571F0EBA88BC62C54D54FFD56FA8D0EBE.Helpers.Parse_Lazy(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, Binding value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(Binding? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(Binding? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(Binding[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<Binding> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(Binding item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, Binding item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(Binding item)
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

	[DebuggerDisplay("Progressive [ Binding ], Count = {Count}")]
	internal sealed class GeneratedVector_bc6a62cde5e524880c8fc296846a008b_Progressive<TInputBuffer> : IList<Binding>, ICollection<Binding>, IEnumerable<Binding>, IEnumerable, IReadOnlyList<Binding>, IReadOnlyCollection<Binding>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly FlatSharp.Compiler.Generated.NF688861FB2AFD76432ACA42547B1899571F0EBA88BC62C54D54FFD56FA8D0EBE.Helpers.tableReader_9ec39faeb2df4b9c8feade9dd6b51573_Progressive<TInputBuffer>?[]?[] items;

		public Binding this[int index]
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

		public GeneratedVector_bc6a62cde5e524880c8fc296846a008b_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new FlatSharp.Compiler.Generated.NF688861FB2AFD76432ACA42547B1899571F0EBA88BC62C54D54FFD56FA8D0EBE.Helpers.tableReader_9ec39faeb2df4b9c8feade9dd6b51573_Progressive<TInputBuffer>[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NF688861FB2AFD76432ACA42547B1899571F0EBA88BC62C54D54FFD56FA8D0EBE.Helpers.tableReader_9ec39faeb2df4b9c8feade9dd6b51573_Progressive<TInputBuffer>?[] GetOrCreateRow(FlatSharp.Compiler.Generated.NF688861FB2AFD76432ACA42547B1899571F0EBA88BC62C54D54FFD56FA8D0EBE.Helpers.tableReader_9ec39faeb2df4b9c8feade9dd6b51573_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private FlatSharp.Compiler.Generated.NF688861FB2AFD76432ACA42547B1899571F0EBA88BC62C54D54FFD56FA8D0EBE.Helpers.tableReader_9ec39faeb2df4b9c8feade9dd6b51573_Progressive<TInputBuffer>?[] CreateRow(FlatSharp.Compiler.Generated.NF688861FB2AFD76432ACA42547B1899571F0EBA88BC62C54D54FFD56FA8D0EBE.Helpers.tableReader_9ec39faeb2df4b9c8feade9dd6b51573_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] = new FlatSharp.Compiler.Generated.NF688861FB2AFD76432ACA42547B1899571F0EBA88BC62C54D54FFD56FA8D0EBE.Helpers.tableReader_9ec39faeb2df4b9c8feade9dd6b51573_Progressive<TInputBuffer>[32];
		}

		private FlatSharp.Compiler.Generated.NF688861FB2AFD76432ACA42547B1899571F0EBA88BC62C54D54FFD56FA8D0EBE.Helpers.tableReader_9ec39faeb2df4b9c8feade9dd6b51573_Progressive<TInputBuffer> ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			FlatSharp.Compiler.Generated.NF688861FB2AFD76432ACA42547B1899571F0EBA88BC62C54D54FFD56FA8D0EBE.Helpers.tableReader_9ec39faeb2df4b9c8feade9dd6b51573_Progressive<TInputBuffer>[][] array = items;
			FlatSharp.Compiler.Generated.NF688861FB2AFD76432ACA42547B1899571F0EBA88BC62C54D54FFD56FA8D0EBE.Helpers.tableReader_9ec39faeb2df4b9c8feade9dd6b51573_Progressive<TInputBuffer>[] orCreateRow = GetOrCreateRow(array, rowIndex);
			FlatSharp.Compiler.Generated.NF688861FB2AFD76432ACA42547B1899571F0EBA88BC62C54D54FFD56FA8D0EBE.Helpers.tableReader_9ec39faeb2df4b9c8feade9dd6b51573_Progressive<TInputBuffer> tableReader_9ec39faeb2df4b9c8feade9dd6b51573_Progressive = orCreateRow[colIndex];
			if (tableReader_9ec39faeb2df4b9c8feade9dd6b51573_Progressive == null)
			{
				tableReader_9ec39faeb2df4b9c8feade9dd6b51573_Progressive = (orCreateRow[colIndex] = UnsafeParseItem(index));
			}
			return tableReader_9ec39faeb2df4b9c8feade9dd6b51573_Progressive;
		}

		private void ProgressiveSet(int index, Binding value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, Binding value)
		{
			VectorUtilities.CheckIndex(index, count);
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NF688861FB2AFD76432ACA42547B1899571F0EBA88BC62C54D54FFD56FA8D0EBE.Helpers.tableReader_9ec39faeb2df4b9c8feade9dd6b51573_Progressive<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NF688861FB2AFD76432ACA42547B1899571F0EBA88BC62C54D54FFD56FA8D0EBE.Helpers.tableReader_9ec39faeb2df4b9c8feade9dd6b51573_Progressive<TInputBuffer> UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.NF688861FB2AFD76432ACA42547B1899571F0EBA88BC62C54D54FFD56FA8D0EBE.Helpers.Parse_Progressive(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, Binding value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(Binding? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(Binding? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(Binding[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<Binding> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(Binding item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, Binding item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(Binding item)
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

	[DebuggerDisplay("Greedy [ Binding ], Count = {Count}")]
	internal sealed class GeneratedVector_bc6a62cde5e524880c8fc296846a008b_Greedy<TInputBuffer> : IList<Binding>, ICollection<Binding>, IEnumerable<Binding>, IEnumerable, IReadOnlyList<Binding>, IReadOnlyCollection<Binding> where TInputBuffer : IInputBuffer
	{
		private readonly List<FlatSharp.Compiler.Generated.NF688861FB2AFD76432ACA42547B1899571F0EBA88BC62C54D54FFD56FA8D0EBE.Helpers.tableReader_9ec39faeb2df4b9c8feade9dd6b51573_Greedy<TInputBuffer>> list;

		public Binding this[int index]
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

		public GeneratedVector_bc6a62cde5e524880c8fc296846a008b_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<FlatSharp.Compiler.Generated.NF688861FB2AFD76432ACA42547B1899571F0EBA88BC62C54D54FFD56FA8D0EBE.Helpers.tableReader_9ec39faeb2df4b9c8feade9dd6b51573_Greedy<TInputBuffer>> list = (this.list = new List<FlatSharp.Compiler.Generated.NF688861FB2AFD76432ACA42547B1899571F0EBA88BC62C54D54FFD56FA8D0EBE.Helpers.tableReader_9ec39faeb2df4b9c8feade9dd6b51573_Greedy<TInputBuffer>>(num));
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.NF688861FB2AFD76432ACA42547B1899571F0EBA88BC62C54D54FFD56FA8D0EBE.Helpers.tableReader_9ec39faeb2df4b9c8feade9dd6b51573_Greedy<TInputBuffer> item = FlatSharp.Compiler.Generated.NF688861FB2AFD76432ACA42547B1899571F0EBA88BC62C54D54FFD56FA8D0EBE.Helpers.Parse_Greedy(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		private FlatSharp.Compiler.Generated.NF688861FB2AFD76432ACA42547B1899571F0EBA88BC62C54D54FFD56FA8D0EBE.Helpers.tableReader_9ec39faeb2df4b9c8feade9dd6b51573_Greedy<TInputBuffer> GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, Binding value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(Binding? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(Binding? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(Binding[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<Binding> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(Binding item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, Binding item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(Binding item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ Binding ], Count = {Count}")]
	internal sealed class GeneratedVector_bc6a62cde5e524880c8fc296846a008b_GreedyMutable<TInputBuffer> : IList<Binding>, ICollection<Binding>, IEnumerable<Binding>, IEnumerable, IReadOnlyList<Binding>, IReadOnlyCollection<Binding> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<Binding> list;

		public Binding this[int index]
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

		public GeneratedVector_bc6a62cde5e524880c8fc296846a008b_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<Binding> list = (this.list = new List<Binding>());
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.NF688861FB2AFD76432ACA42547B1899571F0EBA88BC62C54D54FFD56FA8D0EBE.Helpers.tableReader_9ec39faeb2df4b9c8feade9dd6b51573_GreedyMutable<TInputBuffer> item = FlatSharp.Compiler.Generated.NF688861FB2AFD76432ACA42547B1899571F0EBA88BC62C54D54FFD56FA8D0EBE.Helpers.Parse_GreedyMutable(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private Binding GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, Binding value)
		{
			list[index] = value;
		}

		public void Add(Binding item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, Binding item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(Binding item)
		{
			return list.Remove(item);
		}

		public bool Contains(Binding? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(Binding? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(Binding[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<Binding> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<Binding> value)
	{
		int count = value.Count;
		int num = 14;
		if (value is Binding[] array)
		{
			foreach (Binding binding in array)
			{
				SerializationHelpers.EnsureNonNull(binding);
				num += FlatSharp.Compiler.Generated.NF688861FB2AFD76432ACA42547B1899571F0EBA88BC62C54D54FFD56FA8D0EBE.Helpers.GetMaxSize(binding);
			}
		}
		else if (value is List<Binding> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				Binding binding2 = list[j];
				SerializationHelpers.EnsureNonNull(binding2);
				num += FlatSharp.Compiler.Generated.NF688861FB2AFD76432ACA42547B1899571F0EBA88BC62C54D54FFD56FA8D0EBE.Helpers.GetMaxSize(binding2);
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				Binding binding3 = value[k];
				SerializationHelpers.EnsureNonNull(binding3);
				num += FlatSharp.Compiler.Generated.NF688861FB2AFD76432ACA42547B1899571F0EBA88BC62C54D54FFD56FA8D0EBE.Helpers.GetMaxSize(binding3);
			}
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<Binding> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 4);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is Binding[] array)
		{
			foreach (Binding binding in array)
			{
				SerializationHelpers.EnsureNonNull(binding);
				FlatSharp.Compiler.Generated.NF688861FB2AFD76432ACA42547B1899571F0EBA88BC62C54D54FFD56FA8D0EBE.Helpers.Serialize(spanWriter, span, binding, num, context);
				num += 4;
			}
		}
		else if (value is List<Binding> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				Binding binding2 = list[j];
				SerializationHelpers.EnsureNonNull(binding2);
				FlatSharp.Compiler.Generated.NF688861FB2AFD76432ACA42547B1899571F0EBA88BC62C54D54FFD56FA8D0EBE.Helpers.Serialize(spanWriter, span, binding2, num, context);
				num += 4;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				Binding binding3 = value[k];
				SerializationHelpers.EnsureNonNull(binding3);
				FlatSharp.Compiler.Generated.NF688861FB2AFD76432ACA42547B1899571F0EBA88BC62C54D54FFD56FA8D0EBE.Helpers.Serialize(spanWriter, span, binding3, num, context);
				num += 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<Binding> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_bc6a62cde5e524880c8fc296846a008b_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<Binding> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_bc6a62cde5e524880c8fc296846a008b_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<Binding> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_bc6a62cde5e524880c8fc296846a008b_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<Binding> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_bc6a62cde5e524880c8fc296846a008b_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
