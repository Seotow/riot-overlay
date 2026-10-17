using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Snapshot;
using FlatSharp.Compiler.Generated.N4DC71DFC55F5E6BC96DA9722ADEA2C56E66CBD00985A07ECDE390CC478973812;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.ND312F9B9DDE0762086B11C7DBF89FFFDA7EFCE2687E9CE033F64898BA0AC4FFF;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ XKillEvent ], Count = {Count}")]
	internal sealed class GeneratedVector_55baecf142605a427818f51787f5f155_Lazy<TInputBuffer> : IList<XKillEvent>, ICollection<XKillEvent>, IEnumerable<XKillEvent>, IEnumerable, IReadOnlyList<XKillEvent>, IReadOnlyCollection<XKillEvent>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public XKillEvent this[int index]
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

		int IFlatBufferDeserializedVector.ItemSize => 36;

		int IFlatBufferDeserializedVector.OffsetBase => offset;

		public GeneratedVector_55baecf142605a427818f51787f5f155_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private XKillEvent SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private XKillEvent UnsafeParseItem(int index)
		{
			int num = offset + 36 * index;
			return FlatSharp.Compiler.Generated.N4DC71DFC55F5E6BC96DA9722ADEA2C56E66CBD00985A07ECDE390CC478973812.Helpers.Parse(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, XKillEvent value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(XKillEvent item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(XKillEvent item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(XKillEvent[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<XKillEvent> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(XKillEvent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, XKillEvent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(XKillEvent item)
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
			return offset + 36 * index;
		}
	}

	[DebuggerDisplay("Progressive [ XKillEvent ], Count = {Count}")]
	internal sealed class GeneratedVector_55baecf142605a427818f51787f5f155_Progressive<TInputBuffer> : IList<XKillEvent>, ICollection<XKillEvent>, IEnumerable<XKillEvent>, IEnumerable, IReadOnlyList<XKillEvent>, IReadOnlyCollection<XKillEvent>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly XKillEvent[]?[] items;

		public XKillEvent this[int index]
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

		int IFlatBufferDeserializedVector.ItemSize => 36;

		int IFlatBufferDeserializedVector.OffsetBase => offset;

		public GeneratedVector_55baecf142605a427818f51787f5f155_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new XKillEvent[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private XKillEvent[] GetOrCreateRow(XKillEvent[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private XKillEvent[] CreateRow(XKillEvent[]?[] items, uint rowIndex)
		{
			XKillEvent[] array = (items[rowIndex] = new XKillEvent[32]);
			int num = (int)(rowIndex << 5);
			int num2 = 32;
			int num3 = count - num;
			if (num3 < 32)
			{
				num2 = num3;
			}
			int num4 = offset + 36 * num;
			for (int i = 0; i < num2; i++)
			{
				array[i] = UnsafeParseFromOffset(num4);
				num4 += 36;
			}
			return array;
		}

		private XKillEvent ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			XKillEvent[][] array = items;
			return GetOrCreateRow(array, rowIndex)[colIndex];
		}

		private void ProgressiveSet(int index, XKillEvent value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, XKillEvent value)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			GetOrCreateRow(items, rowIndex)[colIndex] = value;
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private XKillEvent UnsafeParseItem(int index)
		{
			int num = offset + 36 * index;
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private XKillEvent UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.N4DC71DFC55F5E6BC96DA9722ADEA2C56E66CBD00985A07ECDE390CC478973812.Helpers.Parse(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, XKillEvent value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(XKillEvent item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(XKillEvent item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(XKillEvent[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<XKillEvent> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(XKillEvent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, XKillEvent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(XKillEvent item)
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
			return offset + 36 * index;
		}
	}

	[DebuggerDisplay("Greedy [ XKillEvent ], Count = {Count}")]
	internal sealed class GeneratedVector_55baecf142605a427818f51787f5f155_Greedy<TInputBuffer> : IList<XKillEvent>, ICollection<XKillEvent>, IEnumerable<XKillEvent>, IEnumerable, IReadOnlyList<XKillEvent>, IReadOnlyCollection<XKillEvent> where TInputBuffer : IInputBuffer
	{
		private readonly List<XKillEvent> list;

		public XKillEvent this[int index]
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

		public GeneratedVector_55baecf142605a427818f51787f5f155_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<XKillEvent> list = (this.list = new List<XKillEvent>(num));
			for (int i = 0; i < num; i++)
			{
				XKillEvent item = FlatSharp.Compiler.Generated.N4DC71DFC55F5E6BC96DA9722ADEA2C56E66CBD00985A07ECDE390CC478973812.Helpers.Parse(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 36;
			}
		}

		private XKillEvent GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, XKillEvent value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(XKillEvent item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(XKillEvent item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(XKillEvent[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<XKillEvent> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(XKillEvent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, XKillEvent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(XKillEvent item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ XKillEvent ], Count = {Count}")]
	internal sealed class GeneratedVector_55baecf142605a427818f51787f5f155_GreedyMutable<TInputBuffer> : IList<XKillEvent>, ICollection<XKillEvent>, IEnumerable<XKillEvent>, IEnumerable, IReadOnlyList<XKillEvent>, IReadOnlyCollection<XKillEvent> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<XKillEvent> list;

		public XKillEvent this[int index]
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

		public GeneratedVector_55baecf142605a427818f51787f5f155_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<XKillEvent> list = (this.list = new List<XKillEvent>());
			for (int i = 0; i < num; i++)
			{
				XKillEvent item = FlatSharp.Compiler.Generated.N4DC71DFC55F5E6BC96DA9722ADEA2C56E66CBD00985A07ECDE390CC478973812.Helpers.Parse(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 36;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private XKillEvent GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, XKillEvent value)
		{
			list[index] = value;
		}

		public void Add(XKillEvent item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, XKillEvent item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(XKillEvent item)
		{
			return list.Remove(item);
		}

		public bool Contains(XKillEvent item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(XKillEvent item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(XKillEvent[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<XKillEvent> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<XKillEvent> value)
	{
		return 10 + 36 * value.Count;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<XKillEvent> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 36);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is XKillEvent[] array)
		{
			foreach (XKillEvent value2 in array)
			{
				FlatSharp.Compiler.Generated.N4DC71DFC55F5E6BC96DA9722ADEA2C56E66CBD00985A07ECDE390CC478973812.Helpers.Serialize(spanWriter, span, value2, num);
				num += 36;
			}
		}
		else if (value is List<XKillEvent> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				XKillEvent value3 = list[j];
				FlatSharp.Compiler.Generated.N4DC71DFC55F5E6BC96DA9722ADEA2C56E66CBD00985A07ECDE390CC478973812.Helpers.Serialize(spanWriter, span, value3, num);
				num += 36;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				XKillEvent value4 = value[k];
				FlatSharp.Compiler.Generated.N4DC71DFC55F5E6BC96DA9722ADEA2C56E66CBD00985A07ECDE390CC478973812.Helpers.Serialize(spanWriter, span, value4, num);
				num += 36;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<XKillEvent> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_55baecf142605a427818f51787f5f155_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<XKillEvent> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_55baecf142605a427818f51787f5f155_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<XKillEvent> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_55baecf142605a427818f51787f5f155_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<XKillEvent> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_55baecf142605a427818f51787f5f155_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
