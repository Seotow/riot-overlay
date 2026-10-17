using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Sequencer;
using FlatSharp.Compiler.Generated.NA4D99726554D3A6ACF49AB7FEC7840D0E3A2A4C776E7151F2852DA6146FD4102;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N450AC1D773012CE38E91BBC448E710FD6103FEA067FB795BE15AAB78C1890E7D;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ ExposedChoice ], Count = {Count}")]
	internal sealed class GeneratedVector_41789d73893ff9b72d79e703e1438df7_Lazy<TInputBuffer> : IList<ExposedChoice>, ICollection<ExposedChoice>, IEnumerable<ExposedChoice>, IEnumerable, IReadOnlyList<ExposedChoice>, IReadOnlyCollection<ExposedChoice>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public ExposedChoice this[int index]
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

		public GeneratedVector_41789d73893ff9b72d79e703e1438df7_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NA4D99726554D3A6ACF49AB7FEC7840D0E3A2A4C776E7151F2852DA6146FD4102.Helpers.tableReader_84af9341c7cb48cb81b51860abd6f3b0_Lazy<TInputBuffer> SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NA4D99726554D3A6ACF49AB7FEC7840D0E3A2A4C776E7151F2852DA6146FD4102.Helpers.tableReader_84af9341c7cb48cb81b51860abd6f3b0_Lazy<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return FlatSharp.Compiler.Generated.NA4D99726554D3A6ACF49AB7FEC7840D0E3A2A4C776E7151F2852DA6146FD4102.Helpers.Parse_Lazy(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, ExposedChoice value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(ExposedChoice? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(ExposedChoice? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(ExposedChoice[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<ExposedChoice> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(ExposedChoice item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, ExposedChoice item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(ExposedChoice item)
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

	[DebuggerDisplay("Progressive [ ExposedChoice ], Count = {Count}")]
	internal sealed class GeneratedVector_41789d73893ff9b72d79e703e1438df7_Progressive<TInputBuffer> : IList<ExposedChoice>, ICollection<ExposedChoice>, IEnumerable<ExposedChoice>, IEnumerable, IReadOnlyList<ExposedChoice>, IReadOnlyCollection<ExposedChoice>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly FlatSharp.Compiler.Generated.NA4D99726554D3A6ACF49AB7FEC7840D0E3A2A4C776E7151F2852DA6146FD4102.Helpers.tableReader_84af9341c7cb48cb81b51860abd6f3b0_Progressive<TInputBuffer>?[]?[] items;

		public ExposedChoice this[int index]
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

		public GeneratedVector_41789d73893ff9b72d79e703e1438df7_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new FlatSharp.Compiler.Generated.NA4D99726554D3A6ACF49AB7FEC7840D0E3A2A4C776E7151F2852DA6146FD4102.Helpers.tableReader_84af9341c7cb48cb81b51860abd6f3b0_Progressive<TInputBuffer>[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NA4D99726554D3A6ACF49AB7FEC7840D0E3A2A4C776E7151F2852DA6146FD4102.Helpers.tableReader_84af9341c7cb48cb81b51860abd6f3b0_Progressive<TInputBuffer>?[] GetOrCreateRow(FlatSharp.Compiler.Generated.NA4D99726554D3A6ACF49AB7FEC7840D0E3A2A4C776E7151F2852DA6146FD4102.Helpers.tableReader_84af9341c7cb48cb81b51860abd6f3b0_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private FlatSharp.Compiler.Generated.NA4D99726554D3A6ACF49AB7FEC7840D0E3A2A4C776E7151F2852DA6146FD4102.Helpers.tableReader_84af9341c7cb48cb81b51860abd6f3b0_Progressive<TInputBuffer>?[] CreateRow(FlatSharp.Compiler.Generated.NA4D99726554D3A6ACF49AB7FEC7840D0E3A2A4C776E7151F2852DA6146FD4102.Helpers.tableReader_84af9341c7cb48cb81b51860abd6f3b0_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] = new FlatSharp.Compiler.Generated.NA4D99726554D3A6ACF49AB7FEC7840D0E3A2A4C776E7151F2852DA6146FD4102.Helpers.tableReader_84af9341c7cb48cb81b51860abd6f3b0_Progressive<TInputBuffer>[32];
		}

		private FlatSharp.Compiler.Generated.NA4D99726554D3A6ACF49AB7FEC7840D0E3A2A4C776E7151F2852DA6146FD4102.Helpers.tableReader_84af9341c7cb48cb81b51860abd6f3b0_Progressive<TInputBuffer> ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			FlatSharp.Compiler.Generated.NA4D99726554D3A6ACF49AB7FEC7840D0E3A2A4C776E7151F2852DA6146FD4102.Helpers.tableReader_84af9341c7cb48cb81b51860abd6f3b0_Progressive<TInputBuffer>[][] array = items;
			FlatSharp.Compiler.Generated.NA4D99726554D3A6ACF49AB7FEC7840D0E3A2A4C776E7151F2852DA6146FD4102.Helpers.tableReader_84af9341c7cb48cb81b51860abd6f3b0_Progressive<TInputBuffer>[] orCreateRow = GetOrCreateRow(array, rowIndex);
			FlatSharp.Compiler.Generated.NA4D99726554D3A6ACF49AB7FEC7840D0E3A2A4C776E7151F2852DA6146FD4102.Helpers.tableReader_84af9341c7cb48cb81b51860abd6f3b0_Progressive<TInputBuffer> tableReader_84af9341c7cb48cb81b51860abd6f3b0_Progressive = orCreateRow[colIndex];
			if (tableReader_84af9341c7cb48cb81b51860abd6f3b0_Progressive == null)
			{
				tableReader_84af9341c7cb48cb81b51860abd6f3b0_Progressive = (orCreateRow[colIndex] = UnsafeParseItem(index));
			}
			return tableReader_84af9341c7cb48cb81b51860abd6f3b0_Progressive;
		}

		private void ProgressiveSet(int index, ExposedChoice value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, ExposedChoice value)
		{
			VectorUtilities.CheckIndex(index, count);
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NA4D99726554D3A6ACF49AB7FEC7840D0E3A2A4C776E7151F2852DA6146FD4102.Helpers.tableReader_84af9341c7cb48cb81b51860abd6f3b0_Progressive<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NA4D99726554D3A6ACF49AB7FEC7840D0E3A2A4C776E7151F2852DA6146FD4102.Helpers.tableReader_84af9341c7cb48cb81b51860abd6f3b0_Progressive<TInputBuffer> UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.NA4D99726554D3A6ACF49AB7FEC7840D0E3A2A4C776E7151F2852DA6146FD4102.Helpers.Parse_Progressive(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, ExposedChoice value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(ExposedChoice? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(ExposedChoice? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(ExposedChoice[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<ExposedChoice> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(ExposedChoice item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, ExposedChoice item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(ExposedChoice item)
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

	[DebuggerDisplay("Greedy [ ExposedChoice ], Count = {Count}")]
	internal sealed class GeneratedVector_41789d73893ff9b72d79e703e1438df7_Greedy<TInputBuffer> : IList<ExposedChoice>, ICollection<ExposedChoice>, IEnumerable<ExposedChoice>, IEnumerable, IReadOnlyList<ExposedChoice>, IReadOnlyCollection<ExposedChoice> where TInputBuffer : IInputBuffer
	{
		private readonly List<FlatSharp.Compiler.Generated.NA4D99726554D3A6ACF49AB7FEC7840D0E3A2A4C776E7151F2852DA6146FD4102.Helpers.tableReader_84af9341c7cb48cb81b51860abd6f3b0_Greedy<TInputBuffer>> list;

		public ExposedChoice this[int index]
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

		public GeneratedVector_41789d73893ff9b72d79e703e1438df7_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<FlatSharp.Compiler.Generated.NA4D99726554D3A6ACF49AB7FEC7840D0E3A2A4C776E7151F2852DA6146FD4102.Helpers.tableReader_84af9341c7cb48cb81b51860abd6f3b0_Greedy<TInputBuffer>> list = (this.list = new List<FlatSharp.Compiler.Generated.NA4D99726554D3A6ACF49AB7FEC7840D0E3A2A4C776E7151F2852DA6146FD4102.Helpers.tableReader_84af9341c7cb48cb81b51860abd6f3b0_Greedy<TInputBuffer>>(num));
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.NA4D99726554D3A6ACF49AB7FEC7840D0E3A2A4C776E7151F2852DA6146FD4102.Helpers.tableReader_84af9341c7cb48cb81b51860abd6f3b0_Greedy<TInputBuffer> item = FlatSharp.Compiler.Generated.NA4D99726554D3A6ACF49AB7FEC7840D0E3A2A4C776E7151F2852DA6146FD4102.Helpers.Parse_Greedy(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		private FlatSharp.Compiler.Generated.NA4D99726554D3A6ACF49AB7FEC7840D0E3A2A4C776E7151F2852DA6146FD4102.Helpers.tableReader_84af9341c7cb48cb81b51860abd6f3b0_Greedy<TInputBuffer> GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, ExposedChoice value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(ExposedChoice? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(ExposedChoice? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(ExposedChoice[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<ExposedChoice> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(ExposedChoice item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, ExposedChoice item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(ExposedChoice item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ ExposedChoice ], Count = {Count}")]
	internal sealed class GeneratedVector_41789d73893ff9b72d79e703e1438df7_GreedyMutable<TInputBuffer> : IList<ExposedChoice>, ICollection<ExposedChoice>, IEnumerable<ExposedChoice>, IEnumerable, IReadOnlyList<ExposedChoice>, IReadOnlyCollection<ExposedChoice> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<ExposedChoice> list;

		public ExposedChoice this[int index]
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

		public GeneratedVector_41789d73893ff9b72d79e703e1438df7_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<ExposedChoice> list = (this.list = new List<ExposedChoice>());
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.NA4D99726554D3A6ACF49AB7FEC7840D0E3A2A4C776E7151F2852DA6146FD4102.Helpers.tableReader_84af9341c7cb48cb81b51860abd6f3b0_GreedyMutable<TInputBuffer> item = FlatSharp.Compiler.Generated.NA4D99726554D3A6ACF49AB7FEC7840D0E3A2A4C776E7151F2852DA6146FD4102.Helpers.Parse_GreedyMutable(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private ExposedChoice GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, ExposedChoice value)
		{
			list[index] = value;
		}

		public void Add(ExposedChoice item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, ExposedChoice item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(ExposedChoice item)
		{
			return list.Remove(item);
		}

		public bool Contains(ExposedChoice? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(ExposedChoice? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(ExposedChoice[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<ExposedChoice> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<ExposedChoice> value)
	{
		int count = value.Count;
		int num = 14;
		if (value is ExposedChoice[] array)
		{
			foreach (ExposedChoice exposedChoice in array)
			{
				SerializationHelpers.EnsureNonNull(exposedChoice);
				num += FlatSharp.Compiler.Generated.NA4D99726554D3A6ACF49AB7FEC7840D0E3A2A4C776E7151F2852DA6146FD4102.Helpers.GetMaxSize(exposedChoice);
			}
		}
		else if (value is List<ExposedChoice> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				ExposedChoice exposedChoice2 = list[j];
				SerializationHelpers.EnsureNonNull(exposedChoice2);
				num += FlatSharp.Compiler.Generated.NA4D99726554D3A6ACF49AB7FEC7840D0E3A2A4C776E7151F2852DA6146FD4102.Helpers.GetMaxSize(exposedChoice2);
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				ExposedChoice exposedChoice3 = value[k];
				SerializationHelpers.EnsureNonNull(exposedChoice3);
				num += FlatSharp.Compiler.Generated.NA4D99726554D3A6ACF49AB7FEC7840D0E3A2A4C776E7151F2852DA6146FD4102.Helpers.GetMaxSize(exposedChoice3);
			}
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<ExposedChoice> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 4);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is ExposedChoice[] array)
		{
			foreach (ExposedChoice exposedChoice in array)
			{
				SerializationHelpers.EnsureNonNull(exposedChoice);
				FlatSharp.Compiler.Generated.NA4D99726554D3A6ACF49AB7FEC7840D0E3A2A4C776E7151F2852DA6146FD4102.Helpers.Serialize(spanWriter, span, exposedChoice, num, context);
				num += 4;
			}
		}
		else if (value is List<ExposedChoice> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				ExposedChoice exposedChoice2 = list[j];
				SerializationHelpers.EnsureNonNull(exposedChoice2);
				FlatSharp.Compiler.Generated.NA4D99726554D3A6ACF49AB7FEC7840D0E3A2A4C776E7151F2852DA6146FD4102.Helpers.Serialize(spanWriter, span, exposedChoice2, num, context);
				num += 4;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				ExposedChoice exposedChoice3 = value[k];
				SerializationHelpers.EnsureNonNull(exposedChoice3);
				FlatSharp.Compiler.Generated.NA4D99726554D3A6ACF49AB7FEC7840D0E3A2A4C776E7151F2852DA6146FD4102.Helpers.Serialize(spanWriter, span, exposedChoice3, num, context);
				num += 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<ExposedChoice> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_41789d73893ff9b72d79e703e1438df7_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<ExposedChoice> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_41789d73893ff9b72d79e703e1438df7_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<ExposedChoice> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_41789d73893ff9b72d79e703e1438df7_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<ExposedChoice> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_41789d73893ff9b72d79e703e1438df7_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
