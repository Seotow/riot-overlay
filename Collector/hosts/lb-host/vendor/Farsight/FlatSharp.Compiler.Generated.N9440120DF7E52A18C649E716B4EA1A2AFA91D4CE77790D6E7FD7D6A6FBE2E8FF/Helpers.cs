using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Snapshot;
using FlatSharp.Compiler.Generated.NCD1FCE9A810AECA53C0378D55ED57C5F291C150E1564DC5CB16E33BFCC00B195;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N9440120DF7E52A18C649E716B4EA1A2AFA91D4CE77790D6E7FD7D6A6FBE2E8FF;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ Building ], Count = {Count}")]
	internal sealed class GeneratedVector_03207deccb34ca537993102bd45c43b4_Lazy<TInputBuffer> : IList<Building>, ICollection<Building>, IEnumerable<Building>, IEnumerable, IReadOnlyList<Building>, IReadOnlyCollection<Building>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public Building this[int index]
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

		public GeneratedVector_03207deccb34ca537993102bd45c43b4_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NCD1FCE9A810AECA53C0378D55ED57C5F291C150E1564DC5CB16E33BFCC00B195.Helpers.tableReader_388b2839351e4fdabf73ccacfe9763a3_Lazy<TInputBuffer> SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NCD1FCE9A810AECA53C0378D55ED57C5F291C150E1564DC5CB16E33BFCC00B195.Helpers.tableReader_388b2839351e4fdabf73ccacfe9763a3_Lazy<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return FlatSharp.Compiler.Generated.NCD1FCE9A810AECA53C0378D55ED57C5F291C150E1564DC5CB16E33BFCC00B195.Helpers.Parse_Lazy(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, Building value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(Building? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(Building? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(Building[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<Building> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(Building item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, Building item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(Building item)
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

	[DebuggerDisplay("Progressive [ Building ], Count = {Count}")]
	internal sealed class GeneratedVector_03207deccb34ca537993102bd45c43b4_Progressive<TInputBuffer> : IList<Building>, ICollection<Building>, IEnumerable<Building>, IEnumerable, IReadOnlyList<Building>, IReadOnlyCollection<Building>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly FlatSharp.Compiler.Generated.NCD1FCE9A810AECA53C0378D55ED57C5F291C150E1564DC5CB16E33BFCC00B195.Helpers.tableReader_388b2839351e4fdabf73ccacfe9763a3_Progressive<TInputBuffer>?[]?[] items;

		public Building this[int index]
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

		public GeneratedVector_03207deccb34ca537993102bd45c43b4_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new FlatSharp.Compiler.Generated.NCD1FCE9A810AECA53C0378D55ED57C5F291C150E1564DC5CB16E33BFCC00B195.Helpers.tableReader_388b2839351e4fdabf73ccacfe9763a3_Progressive<TInputBuffer>[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NCD1FCE9A810AECA53C0378D55ED57C5F291C150E1564DC5CB16E33BFCC00B195.Helpers.tableReader_388b2839351e4fdabf73ccacfe9763a3_Progressive<TInputBuffer>?[] GetOrCreateRow(FlatSharp.Compiler.Generated.NCD1FCE9A810AECA53C0378D55ED57C5F291C150E1564DC5CB16E33BFCC00B195.Helpers.tableReader_388b2839351e4fdabf73ccacfe9763a3_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private FlatSharp.Compiler.Generated.NCD1FCE9A810AECA53C0378D55ED57C5F291C150E1564DC5CB16E33BFCC00B195.Helpers.tableReader_388b2839351e4fdabf73ccacfe9763a3_Progressive<TInputBuffer>?[] CreateRow(FlatSharp.Compiler.Generated.NCD1FCE9A810AECA53C0378D55ED57C5F291C150E1564DC5CB16E33BFCC00B195.Helpers.tableReader_388b2839351e4fdabf73ccacfe9763a3_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] = new FlatSharp.Compiler.Generated.NCD1FCE9A810AECA53C0378D55ED57C5F291C150E1564DC5CB16E33BFCC00B195.Helpers.tableReader_388b2839351e4fdabf73ccacfe9763a3_Progressive<TInputBuffer>[32];
		}

		private FlatSharp.Compiler.Generated.NCD1FCE9A810AECA53C0378D55ED57C5F291C150E1564DC5CB16E33BFCC00B195.Helpers.tableReader_388b2839351e4fdabf73ccacfe9763a3_Progressive<TInputBuffer> ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			FlatSharp.Compiler.Generated.NCD1FCE9A810AECA53C0378D55ED57C5F291C150E1564DC5CB16E33BFCC00B195.Helpers.tableReader_388b2839351e4fdabf73ccacfe9763a3_Progressive<TInputBuffer>[][] array = items;
			FlatSharp.Compiler.Generated.NCD1FCE9A810AECA53C0378D55ED57C5F291C150E1564DC5CB16E33BFCC00B195.Helpers.tableReader_388b2839351e4fdabf73ccacfe9763a3_Progressive<TInputBuffer>[] orCreateRow = GetOrCreateRow(array, rowIndex);
			FlatSharp.Compiler.Generated.NCD1FCE9A810AECA53C0378D55ED57C5F291C150E1564DC5CB16E33BFCC00B195.Helpers.tableReader_388b2839351e4fdabf73ccacfe9763a3_Progressive<TInputBuffer> tableReader_388b2839351e4fdabf73ccacfe9763a3_Progressive = orCreateRow[colIndex];
			if (tableReader_388b2839351e4fdabf73ccacfe9763a3_Progressive == null)
			{
				tableReader_388b2839351e4fdabf73ccacfe9763a3_Progressive = (orCreateRow[colIndex] = UnsafeParseItem(index));
			}
			return tableReader_388b2839351e4fdabf73ccacfe9763a3_Progressive;
		}

		private void ProgressiveSet(int index, Building value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, Building value)
		{
			VectorUtilities.CheckIndex(index, count);
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NCD1FCE9A810AECA53C0378D55ED57C5F291C150E1564DC5CB16E33BFCC00B195.Helpers.tableReader_388b2839351e4fdabf73ccacfe9763a3_Progressive<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NCD1FCE9A810AECA53C0378D55ED57C5F291C150E1564DC5CB16E33BFCC00B195.Helpers.tableReader_388b2839351e4fdabf73ccacfe9763a3_Progressive<TInputBuffer> UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.NCD1FCE9A810AECA53C0378D55ED57C5F291C150E1564DC5CB16E33BFCC00B195.Helpers.Parse_Progressive(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, Building value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(Building? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(Building? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(Building[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<Building> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(Building item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, Building item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(Building item)
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

	[DebuggerDisplay("Greedy [ Building ], Count = {Count}")]
	internal sealed class GeneratedVector_03207deccb34ca537993102bd45c43b4_Greedy<TInputBuffer> : IList<Building>, ICollection<Building>, IEnumerable<Building>, IEnumerable, IReadOnlyList<Building>, IReadOnlyCollection<Building> where TInputBuffer : IInputBuffer
	{
		private readonly List<FlatSharp.Compiler.Generated.NCD1FCE9A810AECA53C0378D55ED57C5F291C150E1564DC5CB16E33BFCC00B195.Helpers.tableReader_388b2839351e4fdabf73ccacfe9763a3_Greedy<TInputBuffer>> list;

		public Building this[int index]
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

		public GeneratedVector_03207deccb34ca537993102bd45c43b4_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<FlatSharp.Compiler.Generated.NCD1FCE9A810AECA53C0378D55ED57C5F291C150E1564DC5CB16E33BFCC00B195.Helpers.tableReader_388b2839351e4fdabf73ccacfe9763a3_Greedy<TInputBuffer>> list = (this.list = new List<FlatSharp.Compiler.Generated.NCD1FCE9A810AECA53C0378D55ED57C5F291C150E1564DC5CB16E33BFCC00B195.Helpers.tableReader_388b2839351e4fdabf73ccacfe9763a3_Greedy<TInputBuffer>>(num));
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.NCD1FCE9A810AECA53C0378D55ED57C5F291C150E1564DC5CB16E33BFCC00B195.Helpers.tableReader_388b2839351e4fdabf73ccacfe9763a3_Greedy<TInputBuffer> item = FlatSharp.Compiler.Generated.NCD1FCE9A810AECA53C0378D55ED57C5F291C150E1564DC5CB16E33BFCC00B195.Helpers.Parse_Greedy(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		private FlatSharp.Compiler.Generated.NCD1FCE9A810AECA53C0378D55ED57C5F291C150E1564DC5CB16E33BFCC00B195.Helpers.tableReader_388b2839351e4fdabf73ccacfe9763a3_Greedy<TInputBuffer> GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, Building value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(Building? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(Building? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(Building[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<Building> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(Building item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, Building item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(Building item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ Building ], Count = {Count}")]
	internal sealed class GeneratedVector_03207deccb34ca537993102bd45c43b4_GreedyMutable<TInputBuffer> : IList<Building>, ICollection<Building>, IEnumerable<Building>, IEnumerable, IReadOnlyList<Building>, IReadOnlyCollection<Building> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<Building> list;

		public Building this[int index]
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

		public GeneratedVector_03207deccb34ca537993102bd45c43b4_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<Building> list = (this.list = new List<Building>());
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.NCD1FCE9A810AECA53C0378D55ED57C5F291C150E1564DC5CB16E33BFCC00B195.Helpers.tableReader_388b2839351e4fdabf73ccacfe9763a3_GreedyMutable<TInputBuffer> item = FlatSharp.Compiler.Generated.NCD1FCE9A810AECA53C0378D55ED57C5F291C150E1564DC5CB16E33BFCC00B195.Helpers.Parse_GreedyMutable(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private Building GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, Building value)
		{
			list[index] = value;
		}

		public void Add(Building item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, Building item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(Building item)
		{
			return list.Remove(item);
		}

		public bool Contains(Building? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(Building? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(Building[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<Building> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<Building> value)
	{
		int count = value.Count;
		int num = 14;
		if (value is Building[] array)
		{
			foreach (Building building in array)
			{
				SerializationHelpers.EnsureNonNull(building);
				num += FlatSharp.Compiler.Generated.NCD1FCE9A810AECA53C0378D55ED57C5F291C150E1564DC5CB16E33BFCC00B195.Helpers.GetMaxSize(building);
			}
		}
		else if (value is List<Building> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				Building building2 = list[j];
				SerializationHelpers.EnsureNonNull(building2);
				num += FlatSharp.Compiler.Generated.NCD1FCE9A810AECA53C0378D55ED57C5F291C150E1564DC5CB16E33BFCC00B195.Helpers.GetMaxSize(building2);
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				Building building3 = value[k];
				SerializationHelpers.EnsureNonNull(building3);
				num += FlatSharp.Compiler.Generated.NCD1FCE9A810AECA53C0378D55ED57C5F291C150E1564DC5CB16E33BFCC00B195.Helpers.GetMaxSize(building3);
			}
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<Building> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 4);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is Building[] array)
		{
			foreach (Building building in array)
			{
				SerializationHelpers.EnsureNonNull(building);
				FlatSharp.Compiler.Generated.NCD1FCE9A810AECA53C0378D55ED57C5F291C150E1564DC5CB16E33BFCC00B195.Helpers.Serialize(spanWriter, span, building, num, context);
				num += 4;
			}
		}
		else if (value is List<Building> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				Building building2 = list[j];
				SerializationHelpers.EnsureNonNull(building2);
				FlatSharp.Compiler.Generated.NCD1FCE9A810AECA53C0378D55ED57C5F291C150E1564DC5CB16E33BFCC00B195.Helpers.Serialize(spanWriter, span, building2, num, context);
				num += 4;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				Building building3 = value[k];
				SerializationHelpers.EnsureNonNull(building3);
				FlatSharp.Compiler.Generated.NCD1FCE9A810AECA53C0378D55ED57C5F291C150E1564DC5CB16E33BFCC00B195.Helpers.Serialize(spanWriter, span, building3, num, context);
				num += 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<Building> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_03207deccb34ca537993102bd45c43b4_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<Building> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_03207deccb34ca537993102bd45c43b4_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<Building> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_03207deccb34ca537993102bd45c43b4_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<Building> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_03207deccb34ca537993102bd45c43b4_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
