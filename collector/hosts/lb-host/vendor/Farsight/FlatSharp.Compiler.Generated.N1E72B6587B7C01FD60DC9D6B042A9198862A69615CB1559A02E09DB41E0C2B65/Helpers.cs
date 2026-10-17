using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Sequencer;
using FlatSharp.Compiler.Generated.N7771A6658C4D856B11D0BFC36EEBCF2637BD41A00C300097D557990163B85E38;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N1E72B6587B7C01FD60DC9D6B042A9198862A69615CB1559A02E09DB41E0C2B65;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ Clip ], Count = {Count}")]
	internal sealed class GeneratedVector_9e0db464b391dc7d769d9caf1256db8c_Lazy<TInputBuffer> : IList<Clip>, ICollection<Clip>, IEnumerable<Clip>, IEnumerable, IReadOnlyList<Clip>, IReadOnlyCollection<Clip>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public Clip this[int index]
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

		public GeneratedVector_9e0db464b391dc7d769d9caf1256db8c_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N7771A6658C4D856B11D0BFC36EEBCF2637BD41A00C300097D557990163B85E38.Helpers.tableReader_8cac008c3324493f93aab651f19cb865_Lazy<TInputBuffer> SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N7771A6658C4D856B11D0BFC36EEBCF2637BD41A00C300097D557990163B85E38.Helpers.tableReader_8cac008c3324493f93aab651f19cb865_Lazy<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return FlatSharp.Compiler.Generated.N7771A6658C4D856B11D0BFC36EEBCF2637BD41A00C300097D557990163B85E38.Helpers.Parse_Lazy(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, Clip value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(Clip? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(Clip? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(Clip[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<Clip> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(Clip item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, Clip item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(Clip item)
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

	[DebuggerDisplay("Progressive [ Clip ], Count = {Count}")]
	internal sealed class GeneratedVector_9e0db464b391dc7d769d9caf1256db8c_Progressive<TInputBuffer> : IList<Clip>, ICollection<Clip>, IEnumerable<Clip>, IEnumerable, IReadOnlyList<Clip>, IReadOnlyCollection<Clip>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly FlatSharp.Compiler.Generated.N7771A6658C4D856B11D0BFC36EEBCF2637BD41A00C300097D557990163B85E38.Helpers.tableReader_8cac008c3324493f93aab651f19cb865_Progressive<TInputBuffer>?[]?[] items;

		public Clip this[int index]
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

		public GeneratedVector_9e0db464b391dc7d769d9caf1256db8c_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new FlatSharp.Compiler.Generated.N7771A6658C4D856B11D0BFC36EEBCF2637BD41A00C300097D557990163B85E38.Helpers.tableReader_8cac008c3324493f93aab651f19cb865_Progressive<TInputBuffer>[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N7771A6658C4D856B11D0BFC36EEBCF2637BD41A00C300097D557990163B85E38.Helpers.tableReader_8cac008c3324493f93aab651f19cb865_Progressive<TInputBuffer>?[] GetOrCreateRow(FlatSharp.Compiler.Generated.N7771A6658C4D856B11D0BFC36EEBCF2637BD41A00C300097D557990163B85E38.Helpers.tableReader_8cac008c3324493f93aab651f19cb865_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private FlatSharp.Compiler.Generated.N7771A6658C4D856B11D0BFC36EEBCF2637BD41A00C300097D557990163B85E38.Helpers.tableReader_8cac008c3324493f93aab651f19cb865_Progressive<TInputBuffer>?[] CreateRow(FlatSharp.Compiler.Generated.N7771A6658C4D856B11D0BFC36EEBCF2637BD41A00C300097D557990163B85E38.Helpers.tableReader_8cac008c3324493f93aab651f19cb865_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] = new FlatSharp.Compiler.Generated.N7771A6658C4D856B11D0BFC36EEBCF2637BD41A00C300097D557990163B85E38.Helpers.tableReader_8cac008c3324493f93aab651f19cb865_Progressive<TInputBuffer>[32];
		}

		private FlatSharp.Compiler.Generated.N7771A6658C4D856B11D0BFC36EEBCF2637BD41A00C300097D557990163B85E38.Helpers.tableReader_8cac008c3324493f93aab651f19cb865_Progressive<TInputBuffer> ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			FlatSharp.Compiler.Generated.N7771A6658C4D856B11D0BFC36EEBCF2637BD41A00C300097D557990163B85E38.Helpers.tableReader_8cac008c3324493f93aab651f19cb865_Progressive<TInputBuffer>[][] array = items;
			FlatSharp.Compiler.Generated.N7771A6658C4D856B11D0BFC36EEBCF2637BD41A00C300097D557990163B85E38.Helpers.tableReader_8cac008c3324493f93aab651f19cb865_Progressive<TInputBuffer>[] orCreateRow = GetOrCreateRow(array, rowIndex);
			FlatSharp.Compiler.Generated.N7771A6658C4D856B11D0BFC36EEBCF2637BD41A00C300097D557990163B85E38.Helpers.tableReader_8cac008c3324493f93aab651f19cb865_Progressive<TInputBuffer> tableReader_8cac008c3324493f93aab651f19cb865_Progressive = orCreateRow[colIndex];
			if (tableReader_8cac008c3324493f93aab651f19cb865_Progressive == null)
			{
				tableReader_8cac008c3324493f93aab651f19cb865_Progressive = (orCreateRow[colIndex] = UnsafeParseItem(index));
			}
			return tableReader_8cac008c3324493f93aab651f19cb865_Progressive;
		}

		private void ProgressiveSet(int index, Clip value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, Clip value)
		{
			VectorUtilities.CheckIndex(index, count);
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N7771A6658C4D856B11D0BFC36EEBCF2637BD41A00C300097D557990163B85E38.Helpers.tableReader_8cac008c3324493f93aab651f19cb865_Progressive<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N7771A6658C4D856B11D0BFC36EEBCF2637BD41A00C300097D557990163B85E38.Helpers.tableReader_8cac008c3324493f93aab651f19cb865_Progressive<TInputBuffer> UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.N7771A6658C4D856B11D0BFC36EEBCF2637BD41A00C300097D557990163B85E38.Helpers.Parse_Progressive(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, Clip value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(Clip? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(Clip? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(Clip[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<Clip> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(Clip item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, Clip item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(Clip item)
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

	[DebuggerDisplay("Greedy [ Clip ], Count = {Count}")]
	internal sealed class GeneratedVector_9e0db464b391dc7d769d9caf1256db8c_Greedy<TInputBuffer> : IList<Clip>, ICollection<Clip>, IEnumerable<Clip>, IEnumerable, IReadOnlyList<Clip>, IReadOnlyCollection<Clip> where TInputBuffer : IInputBuffer
	{
		private readonly List<FlatSharp.Compiler.Generated.N7771A6658C4D856B11D0BFC36EEBCF2637BD41A00C300097D557990163B85E38.Helpers.tableReader_8cac008c3324493f93aab651f19cb865_Greedy<TInputBuffer>> list;

		public Clip this[int index]
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

		public GeneratedVector_9e0db464b391dc7d769d9caf1256db8c_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<FlatSharp.Compiler.Generated.N7771A6658C4D856B11D0BFC36EEBCF2637BD41A00C300097D557990163B85E38.Helpers.tableReader_8cac008c3324493f93aab651f19cb865_Greedy<TInputBuffer>> list = (this.list = new List<FlatSharp.Compiler.Generated.N7771A6658C4D856B11D0BFC36EEBCF2637BD41A00C300097D557990163B85E38.Helpers.tableReader_8cac008c3324493f93aab651f19cb865_Greedy<TInputBuffer>>(num));
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.N7771A6658C4D856B11D0BFC36EEBCF2637BD41A00C300097D557990163B85E38.Helpers.tableReader_8cac008c3324493f93aab651f19cb865_Greedy<TInputBuffer> item = FlatSharp.Compiler.Generated.N7771A6658C4D856B11D0BFC36EEBCF2637BD41A00C300097D557990163B85E38.Helpers.Parse_Greedy(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		private FlatSharp.Compiler.Generated.N7771A6658C4D856B11D0BFC36EEBCF2637BD41A00C300097D557990163B85E38.Helpers.tableReader_8cac008c3324493f93aab651f19cb865_Greedy<TInputBuffer> GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, Clip value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(Clip? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(Clip? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(Clip[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<Clip> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(Clip item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, Clip item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(Clip item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ Clip ], Count = {Count}")]
	internal sealed class GeneratedVector_9e0db464b391dc7d769d9caf1256db8c_GreedyMutable<TInputBuffer> : IList<Clip>, ICollection<Clip>, IEnumerable<Clip>, IEnumerable, IReadOnlyList<Clip>, IReadOnlyCollection<Clip> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<Clip> list;

		public Clip this[int index]
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

		public GeneratedVector_9e0db464b391dc7d769d9caf1256db8c_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<Clip> list = (this.list = new List<Clip>());
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.N7771A6658C4D856B11D0BFC36EEBCF2637BD41A00C300097D557990163B85E38.Helpers.tableReader_8cac008c3324493f93aab651f19cb865_GreedyMutable<TInputBuffer> item = FlatSharp.Compiler.Generated.N7771A6658C4D856B11D0BFC36EEBCF2637BD41A00C300097D557990163B85E38.Helpers.Parse_GreedyMutable(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private Clip GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, Clip value)
		{
			list[index] = value;
		}

		public void Add(Clip item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, Clip item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(Clip item)
		{
			return list.Remove(item);
		}

		public bool Contains(Clip? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(Clip? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(Clip[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<Clip> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<Clip> value)
	{
		int count = value.Count;
		int num = 14;
		if (value is Clip[] array)
		{
			foreach (Clip clip in array)
			{
				SerializationHelpers.EnsureNonNull(clip);
				num += FlatSharp.Compiler.Generated.N7771A6658C4D856B11D0BFC36EEBCF2637BD41A00C300097D557990163B85E38.Helpers.GetMaxSize(clip);
			}
		}
		else if (value is List<Clip> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				Clip clip2 = list[j];
				SerializationHelpers.EnsureNonNull(clip2);
				num += FlatSharp.Compiler.Generated.N7771A6658C4D856B11D0BFC36EEBCF2637BD41A00C300097D557990163B85E38.Helpers.GetMaxSize(clip2);
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				Clip clip3 = value[k];
				SerializationHelpers.EnsureNonNull(clip3);
				num += FlatSharp.Compiler.Generated.N7771A6658C4D856B11D0BFC36EEBCF2637BD41A00C300097D557990163B85E38.Helpers.GetMaxSize(clip3);
			}
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<Clip> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 4);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is Clip[] array)
		{
			foreach (Clip clip in array)
			{
				SerializationHelpers.EnsureNonNull(clip);
				FlatSharp.Compiler.Generated.N7771A6658C4D856B11D0BFC36EEBCF2637BD41A00C300097D557990163B85E38.Helpers.Serialize(spanWriter, span, clip, num, context);
				num += 4;
			}
		}
		else if (value is List<Clip> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				Clip clip2 = list[j];
				SerializationHelpers.EnsureNonNull(clip2);
				FlatSharp.Compiler.Generated.N7771A6658C4D856B11D0BFC36EEBCF2637BD41A00C300097D557990163B85E38.Helpers.Serialize(spanWriter, span, clip2, num, context);
				num += 4;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				Clip clip3 = value[k];
				SerializationHelpers.EnsureNonNull(clip3);
				FlatSharp.Compiler.Generated.N7771A6658C4D856B11D0BFC36EEBCF2637BD41A00C300097D557990163B85E38.Helpers.Serialize(spanWriter, span, clip3, num, context);
				num += 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<Clip> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_9e0db464b391dc7d769d9caf1256db8c_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<Clip> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_9e0db464b391dc7d769d9caf1256db8c_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<Clip> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_9e0db464b391dc7d769d9caf1256db8c_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<Clip> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_9e0db464b391dc7d769d9caf1256db8c_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
