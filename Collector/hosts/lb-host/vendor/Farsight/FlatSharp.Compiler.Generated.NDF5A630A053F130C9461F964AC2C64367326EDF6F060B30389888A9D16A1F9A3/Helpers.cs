using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Snapshot;
using FlatSharp.Compiler.Generated.NDC4CAD05F5E679F5FAD5ABF828E74EA43ADC87D5A09FAF1F450315EB9DECE303;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.NDF5A630A053F130C9461F964AC2C64367326EDF6F060B30389888A9D16A1F9A3;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ AceEvent ], Count = {Count}")]
	internal sealed class GeneratedVector_faebd9fa78cc42087777069be1bcc3e5_Lazy<TInputBuffer> : IList<AceEvent>, ICollection<AceEvent>, IEnumerable<AceEvent>, IEnumerable, IReadOnlyList<AceEvent>, IReadOnlyCollection<AceEvent>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public AceEvent this[int index]
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

		int IFlatBufferDeserializedVector.ItemSize => 12;

		int IFlatBufferDeserializedVector.OffsetBase => offset;

		public GeneratedVector_faebd9fa78cc42087777069be1bcc3e5_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private AceEvent SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private AceEvent UnsafeParseItem(int index)
		{
			int num = offset + 12 * index;
			return FlatSharp.Compiler.Generated.NDC4CAD05F5E679F5FAD5ABF828E74EA43ADC87D5A09FAF1F450315EB9DECE303.Helpers.Parse(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, AceEvent value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(AceEvent item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(AceEvent item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(AceEvent[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<AceEvent> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(AceEvent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, AceEvent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(AceEvent item)
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
			return offset + 12 * index;
		}
	}

	[DebuggerDisplay("Progressive [ AceEvent ], Count = {Count}")]
	internal sealed class GeneratedVector_faebd9fa78cc42087777069be1bcc3e5_Progressive<TInputBuffer> : IList<AceEvent>, ICollection<AceEvent>, IEnumerable<AceEvent>, IEnumerable, IReadOnlyList<AceEvent>, IReadOnlyCollection<AceEvent>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly AceEvent[]?[] items;

		public AceEvent this[int index]
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

		int IFlatBufferDeserializedVector.ItemSize => 12;

		int IFlatBufferDeserializedVector.OffsetBase => offset;

		public GeneratedVector_faebd9fa78cc42087777069be1bcc3e5_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new AceEvent[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private AceEvent[] GetOrCreateRow(AceEvent[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private AceEvent[] CreateRow(AceEvent[]?[] items, uint rowIndex)
		{
			AceEvent[] array = (items[rowIndex] = new AceEvent[32]);
			int num = (int)(rowIndex << 5);
			int num2 = 32;
			int num3 = count - num;
			if (num3 < 32)
			{
				num2 = num3;
			}
			int num4 = offset + 12 * num;
			for (int i = 0; i < num2; i++)
			{
				array[i] = UnsafeParseFromOffset(num4);
				num4 += 12;
			}
			return array;
		}

		private AceEvent ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			AceEvent[][] array = items;
			return GetOrCreateRow(array, rowIndex)[colIndex];
		}

		private void ProgressiveSet(int index, AceEvent value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, AceEvent value)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			GetOrCreateRow(items, rowIndex)[colIndex] = value;
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private AceEvent UnsafeParseItem(int index)
		{
			int num = offset + 12 * index;
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private AceEvent UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.NDC4CAD05F5E679F5FAD5ABF828E74EA43ADC87D5A09FAF1F450315EB9DECE303.Helpers.Parse(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, AceEvent value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(AceEvent item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(AceEvent item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(AceEvent[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<AceEvent> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(AceEvent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, AceEvent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(AceEvent item)
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
			return offset + 12 * index;
		}
	}

	[DebuggerDisplay("Greedy [ AceEvent ], Count = {Count}")]
	internal sealed class GeneratedVector_faebd9fa78cc42087777069be1bcc3e5_Greedy<TInputBuffer> : IList<AceEvent>, ICollection<AceEvent>, IEnumerable<AceEvent>, IEnumerable, IReadOnlyList<AceEvent>, IReadOnlyCollection<AceEvent> where TInputBuffer : IInputBuffer
	{
		private readonly List<AceEvent> list;

		public AceEvent this[int index]
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

		public GeneratedVector_faebd9fa78cc42087777069be1bcc3e5_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<AceEvent> list = (this.list = new List<AceEvent>(num));
			for (int i = 0; i < num; i++)
			{
				AceEvent item = FlatSharp.Compiler.Generated.NDC4CAD05F5E679F5FAD5ABF828E74EA43ADC87D5A09FAF1F450315EB9DECE303.Helpers.Parse(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 12;
			}
		}

		private AceEvent GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, AceEvent value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(AceEvent item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(AceEvent item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(AceEvent[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<AceEvent> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(AceEvent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, AceEvent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(AceEvent item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ AceEvent ], Count = {Count}")]
	internal sealed class GeneratedVector_faebd9fa78cc42087777069be1bcc3e5_GreedyMutable<TInputBuffer> : IList<AceEvent>, ICollection<AceEvent>, IEnumerable<AceEvent>, IEnumerable, IReadOnlyList<AceEvent>, IReadOnlyCollection<AceEvent> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<AceEvent> list;

		public AceEvent this[int index]
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

		public GeneratedVector_faebd9fa78cc42087777069be1bcc3e5_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<AceEvent> list = (this.list = new List<AceEvent>());
			for (int i = 0; i < num; i++)
			{
				AceEvent item = FlatSharp.Compiler.Generated.NDC4CAD05F5E679F5FAD5ABF828E74EA43ADC87D5A09FAF1F450315EB9DECE303.Helpers.Parse(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 12;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private AceEvent GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, AceEvent value)
		{
			list[index] = value;
		}

		public void Add(AceEvent item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, AceEvent item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(AceEvent item)
		{
			return list.Remove(item);
		}

		public bool Contains(AceEvent item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(AceEvent item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(AceEvent[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<AceEvent> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<AceEvent> value)
	{
		return 10 + 12 * value.Count;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<AceEvent> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 12);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is AceEvent[] array)
		{
			foreach (AceEvent value2 in array)
			{
				FlatSharp.Compiler.Generated.NDC4CAD05F5E679F5FAD5ABF828E74EA43ADC87D5A09FAF1F450315EB9DECE303.Helpers.Serialize(spanWriter, span, value2, num);
				num += 12;
			}
		}
		else if (value is List<AceEvent> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				AceEvent value3 = list[j];
				FlatSharp.Compiler.Generated.NDC4CAD05F5E679F5FAD5ABF828E74EA43ADC87D5A09FAF1F450315EB9DECE303.Helpers.Serialize(spanWriter, span, value3, num);
				num += 12;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				AceEvent value4 = value[k];
				FlatSharp.Compiler.Generated.NDC4CAD05F5E679F5FAD5ABF828E74EA43ADC87D5A09FAF1F450315EB9DECE303.Helpers.Serialize(spanWriter, span, value4, num);
				num += 12;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<AceEvent> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_faebd9fa78cc42087777069be1bcc3e5_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<AceEvent> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_faebd9fa78cc42087777069be1bcc3e5_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<AceEvent> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_faebd9fa78cc42087777069be1bcc3e5_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<AceEvent> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_faebd9fa78cc42087777069be1bcc3e5_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
