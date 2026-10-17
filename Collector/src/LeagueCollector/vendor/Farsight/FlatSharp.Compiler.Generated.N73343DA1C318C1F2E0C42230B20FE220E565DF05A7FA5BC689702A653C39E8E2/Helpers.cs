using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Commands;
using FlatSharp.Compiler.Generated.NF059AE0810889155C9687D62B2C8E01A8A8A7A6269A2485856784464480E5A42;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N73343DA1C318C1F2E0C42230B20FE220E565DF05A7FA5BC689702A653C39E8E2;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ HudLabel ], Count = {Count}")]
	internal sealed class GeneratedVector_a4dd5fef607d5ede1d523365a39506c6_Lazy<TInputBuffer> : IList<HudLabel>, ICollection<HudLabel>, IEnumerable<HudLabel>, IEnumerable, IReadOnlyList<HudLabel>, IReadOnlyCollection<HudLabel>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public HudLabel this[int index]
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

		public GeneratedVector_a4dd5fef607d5ede1d523365a39506c6_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NF059AE0810889155C9687D62B2C8E01A8A8A7A6269A2485856784464480E5A42.Helpers.tableReader_3bcc6152a76f4f7d8da4bb9e02ebf859_Lazy<TInputBuffer> SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NF059AE0810889155C9687D62B2C8E01A8A8A7A6269A2485856784464480E5A42.Helpers.tableReader_3bcc6152a76f4f7d8da4bb9e02ebf859_Lazy<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return FlatSharp.Compiler.Generated.NF059AE0810889155C9687D62B2C8E01A8A8A7A6269A2485856784464480E5A42.Helpers.Parse_Lazy(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, HudLabel value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(HudLabel? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(HudLabel? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(HudLabel[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<HudLabel> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(HudLabel item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, HudLabel item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(HudLabel item)
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

	[DebuggerDisplay("Progressive [ HudLabel ], Count = {Count}")]
	internal sealed class GeneratedVector_a4dd5fef607d5ede1d523365a39506c6_Progressive<TInputBuffer> : IList<HudLabel>, ICollection<HudLabel>, IEnumerable<HudLabel>, IEnumerable, IReadOnlyList<HudLabel>, IReadOnlyCollection<HudLabel>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly FlatSharp.Compiler.Generated.NF059AE0810889155C9687D62B2C8E01A8A8A7A6269A2485856784464480E5A42.Helpers.tableReader_3bcc6152a76f4f7d8da4bb9e02ebf859_Progressive<TInputBuffer>?[]?[] items;

		public HudLabel this[int index]
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

		public GeneratedVector_a4dd5fef607d5ede1d523365a39506c6_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new FlatSharp.Compiler.Generated.NF059AE0810889155C9687D62B2C8E01A8A8A7A6269A2485856784464480E5A42.Helpers.tableReader_3bcc6152a76f4f7d8da4bb9e02ebf859_Progressive<TInputBuffer>[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NF059AE0810889155C9687D62B2C8E01A8A8A7A6269A2485856784464480E5A42.Helpers.tableReader_3bcc6152a76f4f7d8da4bb9e02ebf859_Progressive<TInputBuffer>?[] GetOrCreateRow(FlatSharp.Compiler.Generated.NF059AE0810889155C9687D62B2C8E01A8A8A7A6269A2485856784464480E5A42.Helpers.tableReader_3bcc6152a76f4f7d8da4bb9e02ebf859_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private FlatSharp.Compiler.Generated.NF059AE0810889155C9687D62B2C8E01A8A8A7A6269A2485856784464480E5A42.Helpers.tableReader_3bcc6152a76f4f7d8da4bb9e02ebf859_Progressive<TInputBuffer>?[] CreateRow(FlatSharp.Compiler.Generated.NF059AE0810889155C9687D62B2C8E01A8A8A7A6269A2485856784464480E5A42.Helpers.tableReader_3bcc6152a76f4f7d8da4bb9e02ebf859_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] = new FlatSharp.Compiler.Generated.NF059AE0810889155C9687D62B2C8E01A8A8A7A6269A2485856784464480E5A42.Helpers.tableReader_3bcc6152a76f4f7d8da4bb9e02ebf859_Progressive<TInputBuffer>[32];
		}

		private FlatSharp.Compiler.Generated.NF059AE0810889155C9687D62B2C8E01A8A8A7A6269A2485856784464480E5A42.Helpers.tableReader_3bcc6152a76f4f7d8da4bb9e02ebf859_Progressive<TInputBuffer> ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			FlatSharp.Compiler.Generated.NF059AE0810889155C9687D62B2C8E01A8A8A7A6269A2485856784464480E5A42.Helpers.tableReader_3bcc6152a76f4f7d8da4bb9e02ebf859_Progressive<TInputBuffer>[][] array = items;
			FlatSharp.Compiler.Generated.NF059AE0810889155C9687D62B2C8E01A8A8A7A6269A2485856784464480E5A42.Helpers.tableReader_3bcc6152a76f4f7d8da4bb9e02ebf859_Progressive<TInputBuffer>[] orCreateRow = GetOrCreateRow(array, rowIndex);
			FlatSharp.Compiler.Generated.NF059AE0810889155C9687D62B2C8E01A8A8A7A6269A2485856784464480E5A42.Helpers.tableReader_3bcc6152a76f4f7d8da4bb9e02ebf859_Progressive<TInputBuffer> tableReader_3bcc6152a76f4f7d8da4bb9e02ebf859_Progressive = orCreateRow[colIndex];
			if (tableReader_3bcc6152a76f4f7d8da4bb9e02ebf859_Progressive == null)
			{
				tableReader_3bcc6152a76f4f7d8da4bb9e02ebf859_Progressive = (orCreateRow[colIndex] = UnsafeParseItem(index));
			}
			return tableReader_3bcc6152a76f4f7d8da4bb9e02ebf859_Progressive;
		}

		private void ProgressiveSet(int index, HudLabel value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, HudLabel value)
		{
			VectorUtilities.CheckIndex(index, count);
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NF059AE0810889155C9687D62B2C8E01A8A8A7A6269A2485856784464480E5A42.Helpers.tableReader_3bcc6152a76f4f7d8da4bb9e02ebf859_Progressive<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NF059AE0810889155C9687D62B2C8E01A8A8A7A6269A2485856784464480E5A42.Helpers.tableReader_3bcc6152a76f4f7d8da4bb9e02ebf859_Progressive<TInputBuffer> UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.NF059AE0810889155C9687D62B2C8E01A8A8A7A6269A2485856784464480E5A42.Helpers.Parse_Progressive(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, HudLabel value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(HudLabel? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(HudLabel? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(HudLabel[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<HudLabel> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(HudLabel item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, HudLabel item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(HudLabel item)
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

	[DebuggerDisplay("Greedy [ HudLabel ], Count = {Count}")]
	internal sealed class GeneratedVector_a4dd5fef607d5ede1d523365a39506c6_Greedy<TInputBuffer> : IList<HudLabel>, ICollection<HudLabel>, IEnumerable<HudLabel>, IEnumerable, IReadOnlyList<HudLabel>, IReadOnlyCollection<HudLabel> where TInputBuffer : IInputBuffer
	{
		private readonly List<FlatSharp.Compiler.Generated.NF059AE0810889155C9687D62B2C8E01A8A8A7A6269A2485856784464480E5A42.Helpers.tableReader_3bcc6152a76f4f7d8da4bb9e02ebf859_Greedy<TInputBuffer>> list;

		public HudLabel this[int index]
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

		public GeneratedVector_a4dd5fef607d5ede1d523365a39506c6_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<FlatSharp.Compiler.Generated.NF059AE0810889155C9687D62B2C8E01A8A8A7A6269A2485856784464480E5A42.Helpers.tableReader_3bcc6152a76f4f7d8da4bb9e02ebf859_Greedy<TInputBuffer>> list = (this.list = new List<FlatSharp.Compiler.Generated.NF059AE0810889155C9687D62B2C8E01A8A8A7A6269A2485856784464480E5A42.Helpers.tableReader_3bcc6152a76f4f7d8da4bb9e02ebf859_Greedy<TInputBuffer>>(num));
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.NF059AE0810889155C9687D62B2C8E01A8A8A7A6269A2485856784464480E5A42.Helpers.tableReader_3bcc6152a76f4f7d8da4bb9e02ebf859_Greedy<TInputBuffer> item = FlatSharp.Compiler.Generated.NF059AE0810889155C9687D62B2C8E01A8A8A7A6269A2485856784464480E5A42.Helpers.Parse_Greedy(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		private FlatSharp.Compiler.Generated.NF059AE0810889155C9687D62B2C8E01A8A8A7A6269A2485856784464480E5A42.Helpers.tableReader_3bcc6152a76f4f7d8da4bb9e02ebf859_Greedy<TInputBuffer> GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, HudLabel value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(HudLabel? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(HudLabel? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(HudLabel[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<HudLabel> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(HudLabel item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, HudLabel item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(HudLabel item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ HudLabel ], Count = {Count}")]
	internal sealed class GeneratedVector_a4dd5fef607d5ede1d523365a39506c6_GreedyMutable<TInputBuffer> : IList<HudLabel>, ICollection<HudLabel>, IEnumerable<HudLabel>, IEnumerable, IReadOnlyList<HudLabel>, IReadOnlyCollection<HudLabel> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<HudLabel> list;

		public HudLabel this[int index]
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

		public GeneratedVector_a4dd5fef607d5ede1d523365a39506c6_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<HudLabel> list = (this.list = new List<HudLabel>());
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.NF059AE0810889155C9687D62B2C8E01A8A8A7A6269A2485856784464480E5A42.Helpers.tableReader_3bcc6152a76f4f7d8da4bb9e02ebf859_GreedyMutable<TInputBuffer> item = FlatSharp.Compiler.Generated.NF059AE0810889155C9687D62B2C8E01A8A8A7A6269A2485856784464480E5A42.Helpers.Parse_GreedyMutable(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private HudLabel GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, HudLabel value)
		{
			list[index] = value;
		}

		public void Add(HudLabel item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, HudLabel item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(HudLabel item)
		{
			return list.Remove(item);
		}

		public bool Contains(HudLabel? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(HudLabel? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(HudLabel[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<HudLabel> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<HudLabel> value)
	{
		int count = value.Count;
		int num = 14;
		if (value is HudLabel[] array)
		{
			foreach (HudLabel hudLabel in array)
			{
				SerializationHelpers.EnsureNonNull(hudLabel);
				num += FlatSharp.Compiler.Generated.NF059AE0810889155C9687D62B2C8E01A8A8A7A6269A2485856784464480E5A42.Helpers.GetMaxSize(hudLabel);
			}
		}
		else if (value is List<HudLabel> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				HudLabel hudLabel2 = list[j];
				SerializationHelpers.EnsureNonNull(hudLabel2);
				num += FlatSharp.Compiler.Generated.NF059AE0810889155C9687D62B2C8E01A8A8A7A6269A2485856784464480E5A42.Helpers.GetMaxSize(hudLabel2);
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				HudLabel hudLabel3 = value[k];
				SerializationHelpers.EnsureNonNull(hudLabel3);
				num += FlatSharp.Compiler.Generated.NF059AE0810889155C9687D62B2C8E01A8A8A7A6269A2485856784464480E5A42.Helpers.GetMaxSize(hudLabel3);
			}
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<HudLabel> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 4);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is HudLabel[] array)
		{
			foreach (HudLabel hudLabel in array)
			{
				SerializationHelpers.EnsureNonNull(hudLabel);
				FlatSharp.Compiler.Generated.NF059AE0810889155C9687D62B2C8E01A8A8A7A6269A2485856784464480E5A42.Helpers.Serialize(spanWriter, span, hudLabel, num, context);
				num += 4;
			}
		}
		else if (value is List<HudLabel> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				HudLabel hudLabel2 = list[j];
				SerializationHelpers.EnsureNonNull(hudLabel2);
				FlatSharp.Compiler.Generated.NF059AE0810889155C9687D62B2C8E01A8A8A7A6269A2485856784464480E5A42.Helpers.Serialize(spanWriter, span, hudLabel2, num, context);
				num += 4;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				HudLabel hudLabel3 = value[k];
				SerializationHelpers.EnsureNonNull(hudLabel3);
				FlatSharp.Compiler.Generated.NF059AE0810889155C9687D62B2C8E01A8A8A7A6269A2485856784464480E5A42.Helpers.Serialize(spanWriter, span, hudLabel3, num, context);
				num += 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<HudLabel> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_a4dd5fef607d5ede1d523365a39506c6_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<HudLabel> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_a4dd5fef607d5ede1d523365a39506c6_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<HudLabel> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_a4dd5fef607d5ede1d523365a39506c6_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<HudLabel> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_a4dd5fef607d5ede1d523365a39506c6_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
