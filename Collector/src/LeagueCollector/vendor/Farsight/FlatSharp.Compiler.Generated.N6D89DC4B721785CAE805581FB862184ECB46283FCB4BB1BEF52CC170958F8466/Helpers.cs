using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Sequencer;
using FlatSharp.Compiler.Generated.NEAC7B00EF46C0E9A9FF8CE2227C63A6CAB14C5CDA4E7D4D51843D3F790613D82;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N6D89DC4B721785CAE805581FB862184ECB46283FCB4BB1BEF52CC170958F8466;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ Channel ], Count = {Count}")]
	internal sealed class GeneratedVector_786b64f2f741ab9ff1367731e7204930_Lazy<TInputBuffer> : IList<Channel>, ICollection<Channel>, IEnumerable<Channel>, IEnumerable, IReadOnlyList<Channel>, IReadOnlyCollection<Channel>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public Channel this[int index]
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

		public GeneratedVector_786b64f2f741ab9ff1367731e7204930_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NEAC7B00EF46C0E9A9FF8CE2227C63A6CAB14C5CDA4E7D4D51843D3F790613D82.Helpers.tableReader_72d29570ae984024956dc08561396e34_Lazy<TInputBuffer> SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NEAC7B00EF46C0E9A9FF8CE2227C63A6CAB14C5CDA4E7D4D51843D3F790613D82.Helpers.tableReader_72d29570ae984024956dc08561396e34_Lazy<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return FlatSharp.Compiler.Generated.NEAC7B00EF46C0E9A9FF8CE2227C63A6CAB14C5CDA4E7D4D51843D3F790613D82.Helpers.Parse_Lazy(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, Channel value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(Channel? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(Channel? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(Channel[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<Channel> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(Channel item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, Channel item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(Channel item)
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

	[DebuggerDisplay("Progressive [ Channel ], Count = {Count}")]
	internal sealed class GeneratedVector_786b64f2f741ab9ff1367731e7204930_Progressive<TInputBuffer> : IList<Channel>, ICollection<Channel>, IEnumerable<Channel>, IEnumerable, IReadOnlyList<Channel>, IReadOnlyCollection<Channel>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly FlatSharp.Compiler.Generated.NEAC7B00EF46C0E9A9FF8CE2227C63A6CAB14C5CDA4E7D4D51843D3F790613D82.Helpers.tableReader_72d29570ae984024956dc08561396e34_Progressive<TInputBuffer>?[]?[] items;

		public Channel this[int index]
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

		public GeneratedVector_786b64f2f741ab9ff1367731e7204930_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new FlatSharp.Compiler.Generated.NEAC7B00EF46C0E9A9FF8CE2227C63A6CAB14C5CDA4E7D4D51843D3F790613D82.Helpers.tableReader_72d29570ae984024956dc08561396e34_Progressive<TInputBuffer>[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NEAC7B00EF46C0E9A9FF8CE2227C63A6CAB14C5CDA4E7D4D51843D3F790613D82.Helpers.tableReader_72d29570ae984024956dc08561396e34_Progressive<TInputBuffer>?[] GetOrCreateRow(FlatSharp.Compiler.Generated.NEAC7B00EF46C0E9A9FF8CE2227C63A6CAB14C5CDA4E7D4D51843D3F790613D82.Helpers.tableReader_72d29570ae984024956dc08561396e34_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private FlatSharp.Compiler.Generated.NEAC7B00EF46C0E9A9FF8CE2227C63A6CAB14C5CDA4E7D4D51843D3F790613D82.Helpers.tableReader_72d29570ae984024956dc08561396e34_Progressive<TInputBuffer>?[] CreateRow(FlatSharp.Compiler.Generated.NEAC7B00EF46C0E9A9FF8CE2227C63A6CAB14C5CDA4E7D4D51843D3F790613D82.Helpers.tableReader_72d29570ae984024956dc08561396e34_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] = new FlatSharp.Compiler.Generated.NEAC7B00EF46C0E9A9FF8CE2227C63A6CAB14C5CDA4E7D4D51843D3F790613D82.Helpers.tableReader_72d29570ae984024956dc08561396e34_Progressive<TInputBuffer>[32];
		}

		private FlatSharp.Compiler.Generated.NEAC7B00EF46C0E9A9FF8CE2227C63A6CAB14C5CDA4E7D4D51843D3F790613D82.Helpers.tableReader_72d29570ae984024956dc08561396e34_Progressive<TInputBuffer> ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			FlatSharp.Compiler.Generated.NEAC7B00EF46C0E9A9FF8CE2227C63A6CAB14C5CDA4E7D4D51843D3F790613D82.Helpers.tableReader_72d29570ae984024956dc08561396e34_Progressive<TInputBuffer>[][] array = items;
			FlatSharp.Compiler.Generated.NEAC7B00EF46C0E9A9FF8CE2227C63A6CAB14C5CDA4E7D4D51843D3F790613D82.Helpers.tableReader_72d29570ae984024956dc08561396e34_Progressive<TInputBuffer>[] orCreateRow = GetOrCreateRow(array, rowIndex);
			FlatSharp.Compiler.Generated.NEAC7B00EF46C0E9A9FF8CE2227C63A6CAB14C5CDA4E7D4D51843D3F790613D82.Helpers.tableReader_72d29570ae984024956dc08561396e34_Progressive<TInputBuffer> tableReader_72d29570ae984024956dc08561396e34_Progressive = orCreateRow[colIndex];
			if (tableReader_72d29570ae984024956dc08561396e34_Progressive == null)
			{
				tableReader_72d29570ae984024956dc08561396e34_Progressive = (orCreateRow[colIndex] = UnsafeParseItem(index));
			}
			return tableReader_72d29570ae984024956dc08561396e34_Progressive;
		}

		private void ProgressiveSet(int index, Channel value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, Channel value)
		{
			VectorUtilities.CheckIndex(index, count);
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NEAC7B00EF46C0E9A9FF8CE2227C63A6CAB14C5CDA4E7D4D51843D3F790613D82.Helpers.tableReader_72d29570ae984024956dc08561396e34_Progressive<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NEAC7B00EF46C0E9A9FF8CE2227C63A6CAB14C5CDA4E7D4D51843D3F790613D82.Helpers.tableReader_72d29570ae984024956dc08561396e34_Progressive<TInputBuffer> UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.NEAC7B00EF46C0E9A9FF8CE2227C63A6CAB14C5CDA4E7D4D51843D3F790613D82.Helpers.Parse_Progressive(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, Channel value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(Channel? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(Channel? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(Channel[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<Channel> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(Channel item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, Channel item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(Channel item)
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

	[DebuggerDisplay("Greedy [ Channel ], Count = {Count}")]
	internal sealed class GeneratedVector_786b64f2f741ab9ff1367731e7204930_Greedy<TInputBuffer> : IList<Channel>, ICollection<Channel>, IEnumerable<Channel>, IEnumerable, IReadOnlyList<Channel>, IReadOnlyCollection<Channel> where TInputBuffer : IInputBuffer
	{
		private readonly List<FlatSharp.Compiler.Generated.NEAC7B00EF46C0E9A9FF8CE2227C63A6CAB14C5CDA4E7D4D51843D3F790613D82.Helpers.tableReader_72d29570ae984024956dc08561396e34_Greedy<TInputBuffer>> list;

		public Channel this[int index]
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

		public GeneratedVector_786b64f2f741ab9ff1367731e7204930_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<FlatSharp.Compiler.Generated.NEAC7B00EF46C0E9A9FF8CE2227C63A6CAB14C5CDA4E7D4D51843D3F790613D82.Helpers.tableReader_72d29570ae984024956dc08561396e34_Greedy<TInputBuffer>> list = (this.list = new List<FlatSharp.Compiler.Generated.NEAC7B00EF46C0E9A9FF8CE2227C63A6CAB14C5CDA4E7D4D51843D3F790613D82.Helpers.tableReader_72d29570ae984024956dc08561396e34_Greedy<TInputBuffer>>(num));
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.NEAC7B00EF46C0E9A9FF8CE2227C63A6CAB14C5CDA4E7D4D51843D3F790613D82.Helpers.tableReader_72d29570ae984024956dc08561396e34_Greedy<TInputBuffer> item = FlatSharp.Compiler.Generated.NEAC7B00EF46C0E9A9FF8CE2227C63A6CAB14C5CDA4E7D4D51843D3F790613D82.Helpers.Parse_Greedy(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		private FlatSharp.Compiler.Generated.NEAC7B00EF46C0E9A9FF8CE2227C63A6CAB14C5CDA4E7D4D51843D3F790613D82.Helpers.tableReader_72d29570ae984024956dc08561396e34_Greedy<TInputBuffer> GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, Channel value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(Channel? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(Channel? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(Channel[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<Channel> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(Channel item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, Channel item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(Channel item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ Channel ], Count = {Count}")]
	internal sealed class GeneratedVector_786b64f2f741ab9ff1367731e7204930_GreedyMutable<TInputBuffer> : IList<Channel>, ICollection<Channel>, IEnumerable<Channel>, IEnumerable, IReadOnlyList<Channel>, IReadOnlyCollection<Channel> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<Channel> list;

		public Channel this[int index]
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

		public GeneratedVector_786b64f2f741ab9ff1367731e7204930_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<Channel> list = (this.list = new List<Channel>());
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.NEAC7B00EF46C0E9A9FF8CE2227C63A6CAB14C5CDA4E7D4D51843D3F790613D82.Helpers.tableReader_72d29570ae984024956dc08561396e34_GreedyMutable<TInputBuffer> item = FlatSharp.Compiler.Generated.NEAC7B00EF46C0E9A9FF8CE2227C63A6CAB14C5CDA4E7D4D51843D3F790613D82.Helpers.Parse_GreedyMutable(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private Channel GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, Channel value)
		{
			list[index] = value;
		}

		public void Add(Channel item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, Channel item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(Channel item)
		{
			return list.Remove(item);
		}

		public bool Contains(Channel? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(Channel? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(Channel[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<Channel> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<Channel> value)
	{
		int count = value.Count;
		int num = 14;
		if (value is Channel[] array)
		{
			foreach (Channel channel in array)
			{
				SerializationHelpers.EnsureNonNull(channel);
				num += FlatSharp.Compiler.Generated.NEAC7B00EF46C0E9A9FF8CE2227C63A6CAB14C5CDA4E7D4D51843D3F790613D82.Helpers.GetMaxSize(channel);
			}
		}
		else if (value is List<Channel> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				Channel channel2 = list[j];
				SerializationHelpers.EnsureNonNull(channel2);
				num += FlatSharp.Compiler.Generated.NEAC7B00EF46C0E9A9FF8CE2227C63A6CAB14C5CDA4E7D4D51843D3F790613D82.Helpers.GetMaxSize(channel2);
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				Channel channel3 = value[k];
				SerializationHelpers.EnsureNonNull(channel3);
				num += FlatSharp.Compiler.Generated.NEAC7B00EF46C0E9A9FF8CE2227C63A6CAB14C5CDA4E7D4D51843D3F790613D82.Helpers.GetMaxSize(channel3);
			}
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<Channel> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 4);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is Channel[] array)
		{
			foreach (Channel channel in array)
			{
				SerializationHelpers.EnsureNonNull(channel);
				FlatSharp.Compiler.Generated.NEAC7B00EF46C0E9A9FF8CE2227C63A6CAB14C5CDA4E7D4D51843D3F790613D82.Helpers.Serialize(spanWriter, span, channel, num, context);
				num += 4;
			}
		}
		else if (value is List<Channel> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				Channel channel2 = list[j];
				SerializationHelpers.EnsureNonNull(channel2);
				FlatSharp.Compiler.Generated.NEAC7B00EF46C0E9A9FF8CE2227C63A6CAB14C5CDA4E7D4D51843D3F790613D82.Helpers.Serialize(spanWriter, span, channel2, num, context);
				num += 4;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				Channel channel3 = value[k];
				SerializationHelpers.EnsureNonNull(channel3);
				FlatSharp.Compiler.Generated.NEAC7B00EF46C0E9A9FF8CE2227C63A6CAB14C5CDA4E7D4D51843D3F790613D82.Helpers.Serialize(spanWriter, span, channel3, num, context);
				num += 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<Channel> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_786b64f2f741ab9ff1367731e7204930_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<Channel> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_786b64f2f741ab9ff1367731e7204930_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<Channel> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_786b64f2f741ab9ff1367731e7204930_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<Channel> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_786b64f2f741ab9ff1367731e7204930_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
