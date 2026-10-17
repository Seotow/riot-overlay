using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Sequencer;
using FlatSharp.Compiler.Generated.ND54968AEEAB3DDCE6E991C46DABE13D9AB6DE44FD68D9ABDFB7536DF34420CE8;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.NCE0F4068FA188EEC14561388C518850186CD1B13A9948277C3EA7B679000D227;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ SequenceClipState ], Count = {Count}")]
	internal sealed class GeneratedVector_7f8d94116e3176d91e713fafcbb91d4e_Lazy<TInputBuffer> : IList<SequenceClipState>, ICollection<SequenceClipState>, IEnumerable<SequenceClipState>, IEnumerable, IReadOnlyList<SequenceClipState>, IReadOnlyCollection<SequenceClipState>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public SequenceClipState this[int index]
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

		public GeneratedVector_7f8d94116e3176d91e713fafcbb91d4e_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.ND54968AEEAB3DDCE6E991C46DABE13D9AB6DE44FD68D9ABDFB7536DF34420CE8.Helpers.tableReader_3a97d715153040929874f4b9c01f424d_Lazy<TInputBuffer> SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.ND54968AEEAB3DDCE6E991C46DABE13D9AB6DE44FD68D9ABDFB7536DF34420CE8.Helpers.tableReader_3a97d715153040929874f4b9c01f424d_Lazy<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return FlatSharp.Compiler.Generated.ND54968AEEAB3DDCE6E991C46DABE13D9AB6DE44FD68D9ABDFB7536DF34420CE8.Helpers.Parse_Lazy(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, SequenceClipState value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(SequenceClipState? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(SequenceClipState? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(SequenceClipState[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<SequenceClipState> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(SequenceClipState item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, SequenceClipState item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(SequenceClipState item)
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

	[DebuggerDisplay("Progressive [ SequenceClipState ], Count = {Count}")]
	internal sealed class GeneratedVector_7f8d94116e3176d91e713fafcbb91d4e_Progressive<TInputBuffer> : IList<SequenceClipState>, ICollection<SequenceClipState>, IEnumerable<SequenceClipState>, IEnumerable, IReadOnlyList<SequenceClipState>, IReadOnlyCollection<SequenceClipState>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly FlatSharp.Compiler.Generated.ND54968AEEAB3DDCE6E991C46DABE13D9AB6DE44FD68D9ABDFB7536DF34420CE8.Helpers.tableReader_3a97d715153040929874f4b9c01f424d_Progressive<TInputBuffer>?[]?[] items;

		public SequenceClipState this[int index]
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

		public GeneratedVector_7f8d94116e3176d91e713fafcbb91d4e_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new FlatSharp.Compiler.Generated.ND54968AEEAB3DDCE6E991C46DABE13D9AB6DE44FD68D9ABDFB7536DF34420CE8.Helpers.tableReader_3a97d715153040929874f4b9c01f424d_Progressive<TInputBuffer>[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.ND54968AEEAB3DDCE6E991C46DABE13D9AB6DE44FD68D9ABDFB7536DF34420CE8.Helpers.tableReader_3a97d715153040929874f4b9c01f424d_Progressive<TInputBuffer>?[] GetOrCreateRow(FlatSharp.Compiler.Generated.ND54968AEEAB3DDCE6E991C46DABE13D9AB6DE44FD68D9ABDFB7536DF34420CE8.Helpers.tableReader_3a97d715153040929874f4b9c01f424d_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private FlatSharp.Compiler.Generated.ND54968AEEAB3DDCE6E991C46DABE13D9AB6DE44FD68D9ABDFB7536DF34420CE8.Helpers.tableReader_3a97d715153040929874f4b9c01f424d_Progressive<TInputBuffer>?[] CreateRow(FlatSharp.Compiler.Generated.ND54968AEEAB3DDCE6E991C46DABE13D9AB6DE44FD68D9ABDFB7536DF34420CE8.Helpers.tableReader_3a97d715153040929874f4b9c01f424d_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] = new FlatSharp.Compiler.Generated.ND54968AEEAB3DDCE6E991C46DABE13D9AB6DE44FD68D9ABDFB7536DF34420CE8.Helpers.tableReader_3a97d715153040929874f4b9c01f424d_Progressive<TInputBuffer>[32];
		}

		private FlatSharp.Compiler.Generated.ND54968AEEAB3DDCE6E991C46DABE13D9AB6DE44FD68D9ABDFB7536DF34420CE8.Helpers.tableReader_3a97d715153040929874f4b9c01f424d_Progressive<TInputBuffer> ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			FlatSharp.Compiler.Generated.ND54968AEEAB3DDCE6E991C46DABE13D9AB6DE44FD68D9ABDFB7536DF34420CE8.Helpers.tableReader_3a97d715153040929874f4b9c01f424d_Progressive<TInputBuffer>[][] array = items;
			FlatSharp.Compiler.Generated.ND54968AEEAB3DDCE6E991C46DABE13D9AB6DE44FD68D9ABDFB7536DF34420CE8.Helpers.tableReader_3a97d715153040929874f4b9c01f424d_Progressive<TInputBuffer>[] orCreateRow = GetOrCreateRow(array, rowIndex);
			FlatSharp.Compiler.Generated.ND54968AEEAB3DDCE6E991C46DABE13D9AB6DE44FD68D9ABDFB7536DF34420CE8.Helpers.tableReader_3a97d715153040929874f4b9c01f424d_Progressive<TInputBuffer> tableReader_3a97d715153040929874f4b9c01f424d_Progressive = orCreateRow[colIndex];
			if (tableReader_3a97d715153040929874f4b9c01f424d_Progressive == null)
			{
				tableReader_3a97d715153040929874f4b9c01f424d_Progressive = (orCreateRow[colIndex] = UnsafeParseItem(index));
			}
			return tableReader_3a97d715153040929874f4b9c01f424d_Progressive;
		}

		private void ProgressiveSet(int index, SequenceClipState value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, SequenceClipState value)
		{
			VectorUtilities.CheckIndex(index, count);
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.ND54968AEEAB3DDCE6E991C46DABE13D9AB6DE44FD68D9ABDFB7536DF34420CE8.Helpers.tableReader_3a97d715153040929874f4b9c01f424d_Progressive<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.ND54968AEEAB3DDCE6E991C46DABE13D9AB6DE44FD68D9ABDFB7536DF34420CE8.Helpers.tableReader_3a97d715153040929874f4b9c01f424d_Progressive<TInputBuffer> UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.ND54968AEEAB3DDCE6E991C46DABE13D9AB6DE44FD68D9ABDFB7536DF34420CE8.Helpers.Parse_Progressive(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, SequenceClipState value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(SequenceClipState? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(SequenceClipState? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(SequenceClipState[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<SequenceClipState> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(SequenceClipState item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, SequenceClipState item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(SequenceClipState item)
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

	[DebuggerDisplay("Greedy [ SequenceClipState ], Count = {Count}")]
	internal sealed class GeneratedVector_7f8d94116e3176d91e713fafcbb91d4e_Greedy<TInputBuffer> : IList<SequenceClipState>, ICollection<SequenceClipState>, IEnumerable<SequenceClipState>, IEnumerable, IReadOnlyList<SequenceClipState>, IReadOnlyCollection<SequenceClipState> where TInputBuffer : IInputBuffer
	{
		private readonly List<FlatSharp.Compiler.Generated.ND54968AEEAB3DDCE6E991C46DABE13D9AB6DE44FD68D9ABDFB7536DF34420CE8.Helpers.tableReader_3a97d715153040929874f4b9c01f424d_Greedy<TInputBuffer>> list;

		public SequenceClipState this[int index]
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

		public GeneratedVector_7f8d94116e3176d91e713fafcbb91d4e_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<FlatSharp.Compiler.Generated.ND54968AEEAB3DDCE6E991C46DABE13D9AB6DE44FD68D9ABDFB7536DF34420CE8.Helpers.tableReader_3a97d715153040929874f4b9c01f424d_Greedy<TInputBuffer>> list = (this.list = new List<FlatSharp.Compiler.Generated.ND54968AEEAB3DDCE6E991C46DABE13D9AB6DE44FD68D9ABDFB7536DF34420CE8.Helpers.tableReader_3a97d715153040929874f4b9c01f424d_Greedy<TInputBuffer>>(num));
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.ND54968AEEAB3DDCE6E991C46DABE13D9AB6DE44FD68D9ABDFB7536DF34420CE8.Helpers.tableReader_3a97d715153040929874f4b9c01f424d_Greedy<TInputBuffer> item = FlatSharp.Compiler.Generated.ND54968AEEAB3DDCE6E991C46DABE13D9AB6DE44FD68D9ABDFB7536DF34420CE8.Helpers.Parse_Greedy(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		private FlatSharp.Compiler.Generated.ND54968AEEAB3DDCE6E991C46DABE13D9AB6DE44FD68D9ABDFB7536DF34420CE8.Helpers.tableReader_3a97d715153040929874f4b9c01f424d_Greedy<TInputBuffer> GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, SequenceClipState value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(SequenceClipState? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(SequenceClipState? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(SequenceClipState[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<SequenceClipState> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(SequenceClipState item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, SequenceClipState item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(SequenceClipState item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ SequenceClipState ], Count = {Count}")]
	internal sealed class GeneratedVector_7f8d94116e3176d91e713fafcbb91d4e_GreedyMutable<TInputBuffer> : IList<SequenceClipState>, ICollection<SequenceClipState>, IEnumerable<SequenceClipState>, IEnumerable, IReadOnlyList<SequenceClipState>, IReadOnlyCollection<SequenceClipState> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<SequenceClipState> list;

		public SequenceClipState this[int index]
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

		public GeneratedVector_7f8d94116e3176d91e713fafcbb91d4e_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<SequenceClipState> list = (this.list = new List<SequenceClipState>());
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.ND54968AEEAB3DDCE6E991C46DABE13D9AB6DE44FD68D9ABDFB7536DF34420CE8.Helpers.tableReader_3a97d715153040929874f4b9c01f424d_GreedyMutable<TInputBuffer> item = FlatSharp.Compiler.Generated.ND54968AEEAB3DDCE6E991C46DABE13D9AB6DE44FD68D9ABDFB7536DF34420CE8.Helpers.Parse_GreedyMutable(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private SequenceClipState GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, SequenceClipState value)
		{
			list[index] = value;
		}

		public void Add(SequenceClipState item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, SequenceClipState item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(SequenceClipState item)
		{
			return list.Remove(item);
		}

		public bool Contains(SequenceClipState? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(SequenceClipState? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(SequenceClipState[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<SequenceClipState> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<SequenceClipState> value)
	{
		int count = value.Count;
		int num = 14;
		if (value is SequenceClipState[] array)
		{
			foreach (SequenceClipState sequenceClipState in array)
			{
				SerializationHelpers.EnsureNonNull(sequenceClipState);
				num += FlatSharp.Compiler.Generated.ND54968AEEAB3DDCE6E991C46DABE13D9AB6DE44FD68D9ABDFB7536DF34420CE8.Helpers.GetMaxSize(sequenceClipState);
			}
		}
		else if (value is List<SequenceClipState> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				SequenceClipState sequenceClipState2 = list[j];
				SerializationHelpers.EnsureNonNull(sequenceClipState2);
				num += FlatSharp.Compiler.Generated.ND54968AEEAB3DDCE6E991C46DABE13D9AB6DE44FD68D9ABDFB7536DF34420CE8.Helpers.GetMaxSize(sequenceClipState2);
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				SequenceClipState sequenceClipState3 = value[k];
				SerializationHelpers.EnsureNonNull(sequenceClipState3);
				num += FlatSharp.Compiler.Generated.ND54968AEEAB3DDCE6E991C46DABE13D9AB6DE44FD68D9ABDFB7536DF34420CE8.Helpers.GetMaxSize(sequenceClipState3);
			}
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<SequenceClipState> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 4);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is SequenceClipState[] array)
		{
			foreach (SequenceClipState sequenceClipState in array)
			{
				SerializationHelpers.EnsureNonNull(sequenceClipState);
				FlatSharp.Compiler.Generated.ND54968AEEAB3DDCE6E991C46DABE13D9AB6DE44FD68D9ABDFB7536DF34420CE8.Helpers.Serialize(spanWriter, span, sequenceClipState, num, context);
				num += 4;
			}
		}
		else if (value is List<SequenceClipState> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				SequenceClipState sequenceClipState2 = list[j];
				SerializationHelpers.EnsureNonNull(sequenceClipState2);
				FlatSharp.Compiler.Generated.ND54968AEEAB3DDCE6E991C46DABE13D9AB6DE44FD68D9ABDFB7536DF34420CE8.Helpers.Serialize(spanWriter, span, sequenceClipState2, num, context);
				num += 4;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				SequenceClipState sequenceClipState3 = value[k];
				SerializationHelpers.EnsureNonNull(sequenceClipState3);
				FlatSharp.Compiler.Generated.ND54968AEEAB3DDCE6E991C46DABE13D9AB6DE44FD68D9ABDFB7536DF34420CE8.Helpers.Serialize(spanWriter, span, sequenceClipState3, num, context);
				num += 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<SequenceClipState> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_7f8d94116e3176d91e713fafcbb91d4e_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<SequenceClipState> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_7f8d94116e3176d91e713fafcbb91d4e_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<SequenceClipState> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_7f8d94116e3176d91e713fafcbb91d4e_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<SequenceClipState> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_7f8d94116e3176d91e713fafcbb91d4e_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
