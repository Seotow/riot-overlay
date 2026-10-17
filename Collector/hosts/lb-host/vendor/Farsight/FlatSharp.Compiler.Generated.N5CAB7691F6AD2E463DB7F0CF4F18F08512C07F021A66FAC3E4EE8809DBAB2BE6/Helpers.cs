using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Commands;
using FlatSharp.Compiler.Generated.NC87F26ACA3393D27D8B4CDD426FC2558CB920B3192FE2EC0DAEB37E89B7AEF77;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N5CAB7691F6AD2E463DB7F0CF4F18F08512C07F021A66FAC3E4EE8809DBAB2BE6;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ HudPanelRow ], Count = {Count}")]
	internal sealed class GeneratedVector_51019fff7c98d93f98c73b19ff3b3354_Lazy<TInputBuffer> : IList<HudPanelRow>, ICollection<HudPanelRow>, IEnumerable<HudPanelRow>, IEnumerable, IReadOnlyList<HudPanelRow>, IReadOnlyCollection<HudPanelRow>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public HudPanelRow this[int index]
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

		public GeneratedVector_51019fff7c98d93f98c73b19ff3b3354_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NC87F26ACA3393D27D8B4CDD426FC2558CB920B3192FE2EC0DAEB37E89B7AEF77.Helpers.tableReader_3a8cf74ae344496388c6b42e02c61576_Lazy<TInputBuffer> SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NC87F26ACA3393D27D8B4CDD426FC2558CB920B3192FE2EC0DAEB37E89B7AEF77.Helpers.tableReader_3a8cf74ae344496388c6b42e02c61576_Lazy<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return FlatSharp.Compiler.Generated.NC87F26ACA3393D27D8B4CDD426FC2558CB920B3192FE2EC0DAEB37E89B7AEF77.Helpers.Parse_Lazy(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, HudPanelRow value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(HudPanelRow? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(HudPanelRow? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(HudPanelRow[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<HudPanelRow> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(HudPanelRow item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, HudPanelRow item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(HudPanelRow item)
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

	[DebuggerDisplay("Progressive [ HudPanelRow ], Count = {Count}")]
	internal sealed class GeneratedVector_51019fff7c98d93f98c73b19ff3b3354_Progressive<TInputBuffer> : IList<HudPanelRow>, ICollection<HudPanelRow>, IEnumerable<HudPanelRow>, IEnumerable, IReadOnlyList<HudPanelRow>, IReadOnlyCollection<HudPanelRow>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly FlatSharp.Compiler.Generated.NC87F26ACA3393D27D8B4CDD426FC2558CB920B3192FE2EC0DAEB37E89B7AEF77.Helpers.tableReader_3a8cf74ae344496388c6b42e02c61576_Progressive<TInputBuffer>?[]?[] items;

		public HudPanelRow this[int index]
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

		public GeneratedVector_51019fff7c98d93f98c73b19ff3b3354_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new FlatSharp.Compiler.Generated.NC87F26ACA3393D27D8B4CDD426FC2558CB920B3192FE2EC0DAEB37E89B7AEF77.Helpers.tableReader_3a8cf74ae344496388c6b42e02c61576_Progressive<TInputBuffer>[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NC87F26ACA3393D27D8B4CDD426FC2558CB920B3192FE2EC0DAEB37E89B7AEF77.Helpers.tableReader_3a8cf74ae344496388c6b42e02c61576_Progressive<TInputBuffer>?[] GetOrCreateRow(FlatSharp.Compiler.Generated.NC87F26ACA3393D27D8B4CDD426FC2558CB920B3192FE2EC0DAEB37E89B7AEF77.Helpers.tableReader_3a8cf74ae344496388c6b42e02c61576_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private FlatSharp.Compiler.Generated.NC87F26ACA3393D27D8B4CDD426FC2558CB920B3192FE2EC0DAEB37E89B7AEF77.Helpers.tableReader_3a8cf74ae344496388c6b42e02c61576_Progressive<TInputBuffer>?[] CreateRow(FlatSharp.Compiler.Generated.NC87F26ACA3393D27D8B4CDD426FC2558CB920B3192FE2EC0DAEB37E89B7AEF77.Helpers.tableReader_3a8cf74ae344496388c6b42e02c61576_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] = new FlatSharp.Compiler.Generated.NC87F26ACA3393D27D8B4CDD426FC2558CB920B3192FE2EC0DAEB37E89B7AEF77.Helpers.tableReader_3a8cf74ae344496388c6b42e02c61576_Progressive<TInputBuffer>[32];
		}

		private FlatSharp.Compiler.Generated.NC87F26ACA3393D27D8B4CDD426FC2558CB920B3192FE2EC0DAEB37E89B7AEF77.Helpers.tableReader_3a8cf74ae344496388c6b42e02c61576_Progressive<TInputBuffer> ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			FlatSharp.Compiler.Generated.NC87F26ACA3393D27D8B4CDD426FC2558CB920B3192FE2EC0DAEB37E89B7AEF77.Helpers.tableReader_3a8cf74ae344496388c6b42e02c61576_Progressive<TInputBuffer>[][] array = items;
			FlatSharp.Compiler.Generated.NC87F26ACA3393D27D8B4CDD426FC2558CB920B3192FE2EC0DAEB37E89B7AEF77.Helpers.tableReader_3a8cf74ae344496388c6b42e02c61576_Progressive<TInputBuffer>[] orCreateRow = GetOrCreateRow(array, rowIndex);
			FlatSharp.Compiler.Generated.NC87F26ACA3393D27D8B4CDD426FC2558CB920B3192FE2EC0DAEB37E89B7AEF77.Helpers.tableReader_3a8cf74ae344496388c6b42e02c61576_Progressive<TInputBuffer> tableReader_3a8cf74ae344496388c6b42e02c61576_Progressive = orCreateRow[colIndex];
			if (tableReader_3a8cf74ae344496388c6b42e02c61576_Progressive == null)
			{
				tableReader_3a8cf74ae344496388c6b42e02c61576_Progressive = (orCreateRow[colIndex] = UnsafeParseItem(index));
			}
			return tableReader_3a8cf74ae344496388c6b42e02c61576_Progressive;
		}

		private void ProgressiveSet(int index, HudPanelRow value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, HudPanelRow value)
		{
			VectorUtilities.CheckIndex(index, count);
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NC87F26ACA3393D27D8B4CDD426FC2558CB920B3192FE2EC0DAEB37E89B7AEF77.Helpers.tableReader_3a8cf74ae344496388c6b42e02c61576_Progressive<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NC87F26ACA3393D27D8B4CDD426FC2558CB920B3192FE2EC0DAEB37E89B7AEF77.Helpers.tableReader_3a8cf74ae344496388c6b42e02c61576_Progressive<TInputBuffer> UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.NC87F26ACA3393D27D8B4CDD426FC2558CB920B3192FE2EC0DAEB37E89B7AEF77.Helpers.Parse_Progressive(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, HudPanelRow value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(HudPanelRow? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(HudPanelRow? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(HudPanelRow[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<HudPanelRow> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(HudPanelRow item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, HudPanelRow item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(HudPanelRow item)
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

	[DebuggerDisplay("Greedy [ HudPanelRow ], Count = {Count}")]
	internal sealed class GeneratedVector_51019fff7c98d93f98c73b19ff3b3354_Greedy<TInputBuffer> : IList<HudPanelRow>, ICollection<HudPanelRow>, IEnumerable<HudPanelRow>, IEnumerable, IReadOnlyList<HudPanelRow>, IReadOnlyCollection<HudPanelRow> where TInputBuffer : IInputBuffer
	{
		private readonly List<FlatSharp.Compiler.Generated.NC87F26ACA3393D27D8B4CDD426FC2558CB920B3192FE2EC0DAEB37E89B7AEF77.Helpers.tableReader_3a8cf74ae344496388c6b42e02c61576_Greedy<TInputBuffer>> list;

		public HudPanelRow this[int index]
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

		public GeneratedVector_51019fff7c98d93f98c73b19ff3b3354_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<FlatSharp.Compiler.Generated.NC87F26ACA3393D27D8B4CDD426FC2558CB920B3192FE2EC0DAEB37E89B7AEF77.Helpers.tableReader_3a8cf74ae344496388c6b42e02c61576_Greedy<TInputBuffer>> list = (this.list = new List<FlatSharp.Compiler.Generated.NC87F26ACA3393D27D8B4CDD426FC2558CB920B3192FE2EC0DAEB37E89B7AEF77.Helpers.tableReader_3a8cf74ae344496388c6b42e02c61576_Greedy<TInputBuffer>>(num));
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.NC87F26ACA3393D27D8B4CDD426FC2558CB920B3192FE2EC0DAEB37E89B7AEF77.Helpers.tableReader_3a8cf74ae344496388c6b42e02c61576_Greedy<TInputBuffer> item = FlatSharp.Compiler.Generated.NC87F26ACA3393D27D8B4CDD426FC2558CB920B3192FE2EC0DAEB37E89B7AEF77.Helpers.Parse_Greedy(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		private FlatSharp.Compiler.Generated.NC87F26ACA3393D27D8B4CDD426FC2558CB920B3192FE2EC0DAEB37E89B7AEF77.Helpers.tableReader_3a8cf74ae344496388c6b42e02c61576_Greedy<TInputBuffer> GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, HudPanelRow value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(HudPanelRow? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(HudPanelRow? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(HudPanelRow[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<HudPanelRow> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(HudPanelRow item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, HudPanelRow item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(HudPanelRow item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ HudPanelRow ], Count = {Count}")]
	internal sealed class GeneratedVector_51019fff7c98d93f98c73b19ff3b3354_GreedyMutable<TInputBuffer> : IList<HudPanelRow>, ICollection<HudPanelRow>, IEnumerable<HudPanelRow>, IEnumerable, IReadOnlyList<HudPanelRow>, IReadOnlyCollection<HudPanelRow> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<HudPanelRow> list;

		public HudPanelRow this[int index]
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

		public GeneratedVector_51019fff7c98d93f98c73b19ff3b3354_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<HudPanelRow> list = (this.list = new List<HudPanelRow>());
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.NC87F26ACA3393D27D8B4CDD426FC2558CB920B3192FE2EC0DAEB37E89B7AEF77.Helpers.tableReader_3a8cf74ae344496388c6b42e02c61576_GreedyMutable<TInputBuffer> item = FlatSharp.Compiler.Generated.NC87F26ACA3393D27D8B4CDD426FC2558CB920B3192FE2EC0DAEB37E89B7AEF77.Helpers.Parse_GreedyMutable(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private HudPanelRow GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, HudPanelRow value)
		{
			list[index] = value;
		}

		public void Add(HudPanelRow item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, HudPanelRow item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(HudPanelRow item)
		{
			return list.Remove(item);
		}

		public bool Contains(HudPanelRow? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(HudPanelRow? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(HudPanelRow[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<HudPanelRow> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<HudPanelRow> value)
	{
		int count = value.Count;
		int num = 14;
		if (value is HudPanelRow[] array)
		{
			foreach (HudPanelRow hudPanelRow in array)
			{
				SerializationHelpers.EnsureNonNull(hudPanelRow);
				num += FlatSharp.Compiler.Generated.NC87F26ACA3393D27D8B4CDD426FC2558CB920B3192FE2EC0DAEB37E89B7AEF77.Helpers.GetMaxSize(hudPanelRow);
			}
		}
		else if (value is List<HudPanelRow> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				HudPanelRow hudPanelRow2 = list[j];
				SerializationHelpers.EnsureNonNull(hudPanelRow2);
				num += FlatSharp.Compiler.Generated.NC87F26ACA3393D27D8B4CDD426FC2558CB920B3192FE2EC0DAEB37E89B7AEF77.Helpers.GetMaxSize(hudPanelRow2);
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				HudPanelRow hudPanelRow3 = value[k];
				SerializationHelpers.EnsureNonNull(hudPanelRow3);
				num += FlatSharp.Compiler.Generated.NC87F26ACA3393D27D8B4CDD426FC2558CB920B3192FE2EC0DAEB37E89B7AEF77.Helpers.GetMaxSize(hudPanelRow3);
			}
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<HudPanelRow> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 4);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is HudPanelRow[] array)
		{
			foreach (HudPanelRow hudPanelRow in array)
			{
				SerializationHelpers.EnsureNonNull(hudPanelRow);
				FlatSharp.Compiler.Generated.NC87F26ACA3393D27D8B4CDD426FC2558CB920B3192FE2EC0DAEB37E89B7AEF77.Helpers.Serialize(spanWriter, span, hudPanelRow, num, context);
				num += 4;
			}
		}
		else if (value is List<HudPanelRow> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				HudPanelRow hudPanelRow2 = list[j];
				SerializationHelpers.EnsureNonNull(hudPanelRow2);
				FlatSharp.Compiler.Generated.NC87F26ACA3393D27D8B4CDD426FC2558CB920B3192FE2EC0DAEB37E89B7AEF77.Helpers.Serialize(spanWriter, span, hudPanelRow2, num, context);
				num += 4;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				HudPanelRow hudPanelRow3 = value[k];
				SerializationHelpers.EnsureNonNull(hudPanelRow3);
				FlatSharp.Compiler.Generated.NC87F26ACA3393D27D8B4CDD426FC2558CB920B3192FE2EC0DAEB37E89B7AEF77.Helpers.Serialize(spanWriter, span, hudPanelRow3, num, context);
				num += 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<HudPanelRow> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_51019fff7c98d93f98c73b19ff3b3354_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<HudPanelRow> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_51019fff7c98d93f98c73b19ff3b3354_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<HudPanelRow> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_51019fff7c98d93f98c73b19ff3b3354_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<HudPanelRow> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_51019fff7c98d93f98c73b19ff3b3354_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
