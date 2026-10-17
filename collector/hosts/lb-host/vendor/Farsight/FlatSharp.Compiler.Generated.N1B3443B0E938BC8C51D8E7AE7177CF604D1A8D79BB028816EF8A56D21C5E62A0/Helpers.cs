using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Commands;
using FlatSharp.Compiler.Generated.NF4A24CE8AA6F3A384CD404C872EFD9E96BAAEAD763AD669DD9C4EEFAB27FA9E1;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N1B3443B0E938BC8C51D8E7AE7177CF604D1A8D79BB028816EF8A56D21C5E62A0;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ CinematicPropKey ], Count = {Count}")]
	internal sealed class GeneratedVector_31f373577b76cb6b1f9392cea19f26bc_Lazy<TInputBuffer> : IList<CinematicPropKey>, ICollection<CinematicPropKey>, IEnumerable<CinematicPropKey>, IEnumerable, IReadOnlyList<CinematicPropKey>, IReadOnlyCollection<CinematicPropKey>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public CinematicPropKey this[int index]
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

		public GeneratedVector_31f373577b76cb6b1f9392cea19f26bc_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NF4A24CE8AA6F3A384CD404C872EFD9E96BAAEAD763AD669DD9C4EEFAB27FA9E1.Helpers.tableReader_541bb50a3b6745208ba6c897b267b2ca_Lazy<TInputBuffer> SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NF4A24CE8AA6F3A384CD404C872EFD9E96BAAEAD763AD669DD9C4EEFAB27FA9E1.Helpers.tableReader_541bb50a3b6745208ba6c897b267b2ca_Lazy<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return FlatSharp.Compiler.Generated.NF4A24CE8AA6F3A384CD404C872EFD9E96BAAEAD763AD669DD9C4EEFAB27FA9E1.Helpers.Parse_Lazy(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, CinematicPropKey value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(CinematicPropKey? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(CinematicPropKey? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(CinematicPropKey[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<CinematicPropKey> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(CinematicPropKey item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, CinematicPropKey item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(CinematicPropKey item)
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

	[DebuggerDisplay("Progressive [ CinematicPropKey ], Count = {Count}")]
	internal sealed class GeneratedVector_31f373577b76cb6b1f9392cea19f26bc_Progressive<TInputBuffer> : IList<CinematicPropKey>, ICollection<CinematicPropKey>, IEnumerable<CinematicPropKey>, IEnumerable, IReadOnlyList<CinematicPropKey>, IReadOnlyCollection<CinematicPropKey>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly FlatSharp.Compiler.Generated.NF4A24CE8AA6F3A384CD404C872EFD9E96BAAEAD763AD669DD9C4EEFAB27FA9E1.Helpers.tableReader_541bb50a3b6745208ba6c897b267b2ca_Progressive<TInputBuffer>?[]?[] items;

		public CinematicPropKey this[int index]
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

		public GeneratedVector_31f373577b76cb6b1f9392cea19f26bc_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new FlatSharp.Compiler.Generated.NF4A24CE8AA6F3A384CD404C872EFD9E96BAAEAD763AD669DD9C4EEFAB27FA9E1.Helpers.tableReader_541bb50a3b6745208ba6c897b267b2ca_Progressive<TInputBuffer>[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NF4A24CE8AA6F3A384CD404C872EFD9E96BAAEAD763AD669DD9C4EEFAB27FA9E1.Helpers.tableReader_541bb50a3b6745208ba6c897b267b2ca_Progressive<TInputBuffer>?[] GetOrCreateRow(FlatSharp.Compiler.Generated.NF4A24CE8AA6F3A384CD404C872EFD9E96BAAEAD763AD669DD9C4EEFAB27FA9E1.Helpers.tableReader_541bb50a3b6745208ba6c897b267b2ca_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private FlatSharp.Compiler.Generated.NF4A24CE8AA6F3A384CD404C872EFD9E96BAAEAD763AD669DD9C4EEFAB27FA9E1.Helpers.tableReader_541bb50a3b6745208ba6c897b267b2ca_Progressive<TInputBuffer>?[] CreateRow(FlatSharp.Compiler.Generated.NF4A24CE8AA6F3A384CD404C872EFD9E96BAAEAD763AD669DD9C4EEFAB27FA9E1.Helpers.tableReader_541bb50a3b6745208ba6c897b267b2ca_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] = new FlatSharp.Compiler.Generated.NF4A24CE8AA6F3A384CD404C872EFD9E96BAAEAD763AD669DD9C4EEFAB27FA9E1.Helpers.tableReader_541bb50a3b6745208ba6c897b267b2ca_Progressive<TInputBuffer>[32];
		}

		private FlatSharp.Compiler.Generated.NF4A24CE8AA6F3A384CD404C872EFD9E96BAAEAD763AD669DD9C4EEFAB27FA9E1.Helpers.tableReader_541bb50a3b6745208ba6c897b267b2ca_Progressive<TInputBuffer> ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			FlatSharp.Compiler.Generated.NF4A24CE8AA6F3A384CD404C872EFD9E96BAAEAD763AD669DD9C4EEFAB27FA9E1.Helpers.tableReader_541bb50a3b6745208ba6c897b267b2ca_Progressive<TInputBuffer>[][] array = items;
			FlatSharp.Compiler.Generated.NF4A24CE8AA6F3A384CD404C872EFD9E96BAAEAD763AD669DD9C4EEFAB27FA9E1.Helpers.tableReader_541bb50a3b6745208ba6c897b267b2ca_Progressive<TInputBuffer>[] orCreateRow = GetOrCreateRow(array, rowIndex);
			FlatSharp.Compiler.Generated.NF4A24CE8AA6F3A384CD404C872EFD9E96BAAEAD763AD669DD9C4EEFAB27FA9E1.Helpers.tableReader_541bb50a3b6745208ba6c897b267b2ca_Progressive<TInputBuffer> tableReader_541bb50a3b6745208ba6c897b267b2ca_Progressive = orCreateRow[colIndex];
			if (tableReader_541bb50a3b6745208ba6c897b267b2ca_Progressive == null)
			{
				tableReader_541bb50a3b6745208ba6c897b267b2ca_Progressive = (orCreateRow[colIndex] = UnsafeParseItem(index));
			}
			return tableReader_541bb50a3b6745208ba6c897b267b2ca_Progressive;
		}

		private void ProgressiveSet(int index, CinematicPropKey value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, CinematicPropKey value)
		{
			VectorUtilities.CheckIndex(index, count);
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NF4A24CE8AA6F3A384CD404C872EFD9E96BAAEAD763AD669DD9C4EEFAB27FA9E1.Helpers.tableReader_541bb50a3b6745208ba6c897b267b2ca_Progressive<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NF4A24CE8AA6F3A384CD404C872EFD9E96BAAEAD763AD669DD9C4EEFAB27FA9E1.Helpers.tableReader_541bb50a3b6745208ba6c897b267b2ca_Progressive<TInputBuffer> UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.NF4A24CE8AA6F3A384CD404C872EFD9E96BAAEAD763AD669DD9C4EEFAB27FA9E1.Helpers.Parse_Progressive(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, CinematicPropKey value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(CinematicPropKey? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(CinematicPropKey? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(CinematicPropKey[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<CinematicPropKey> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(CinematicPropKey item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, CinematicPropKey item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(CinematicPropKey item)
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

	[DebuggerDisplay("Greedy [ CinematicPropKey ], Count = {Count}")]
	internal sealed class GeneratedVector_31f373577b76cb6b1f9392cea19f26bc_Greedy<TInputBuffer> : IList<CinematicPropKey>, ICollection<CinematicPropKey>, IEnumerable<CinematicPropKey>, IEnumerable, IReadOnlyList<CinematicPropKey>, IReadOnlyCollection<CinematicPropKey> where TInputBuffer : IInputBuffer
	{
		private readonly List<FlatSharp.Compiler.Generated.NF4A24CE8AA6F3A384CD404C872EFD9E96BAAEAD763AD669DD9C4EEFAB27FA9E1.Helpers.tableReader_541bb50a3b6745208ba6c897b267b2ca_Greedy<TInputBuffer>> list;

		public CinematicPropKey this[int index]
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

		public GeneratedVector_31f373577b76cb6b1f9392cea19f26bc_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<FlatSharp.Compiler.Generated.NF4A24CE8AA6F3A384CD404C872EFD9E96BAAEAD763AD669DD9C4EEFAB27FA9E1.Helpers.tableReader_541bb50a3b6745208ba6c897b267b2ca_Greedy<TInputBuffer>> list = (this.list = new List<FlatSharp.Compiler.Generated.NF4A24CE8AA6F3A384CD404C872EFD9E96BAAEAD763AD669DD9C4EEFAB27FA9E1.Helpers.tableReader_541bb50a3b6745208ba6c897b267b2ca_Greedy<TInputBuffer>>(num));
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.NF4A24CE8AA6F3A384CD404C872EFD9E96BAAEAD763AD669DD9C4EEFAB27FA9E1.Helpers.tableReader_541bb50a3b6745208ba6c897b267b2ca_Greedy<TInputBuffer> item = FlatSharp.Compiler.Generated.NF4A24CE8AA6F3A384CD404C872EFD9E96BAAEAD763AD669DD9C4EEFAB27FA9E1.Helpers.Parse_Greedy(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		private FlatSharp.Compiler.Generated.NF4A24CE8AA6F3A384CD404C872EFD9E96BAAEAD763AD669DD9C4EEFAB27FA9E1.Helpers.tableReader_541bb50a3b6745208ba6c897b267b2ca_Greedy<TInputBuffer> GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, CinematicPropKey value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(CinematicPropKey? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(CinematicPropKey? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(CinematicPropKey[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<CinematicPropKey> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(CinematicPropKey item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, CinematicPropKey item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(CinematicPropKey item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ CinematicPropKey ], Count = {Count}")]
	internal sealed class GeneratedVector_31f373577b76cb6b1f9392cea19f26bc_GreedyMutable<TInputBuffer> : IList<CinematicPropKey>, ICollection<CinematicPropKey>, IEnumerable<CinematicPropKey>, IEnumerable, IReadOnlyList<CinematicPropKey>, IReadOnlyCollection<CinematicPropKey> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<CinematicPropKey> list;

		public CinematicPropKey this[int index]
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

		public GeneratedVector_31f373577b76cb6b1f9392cea19f26bc_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<CinematicPropKey> list = (this.list = new List<CinematicPropKey>());
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.NF4A24CE8AA6F3A384CD404C872EFD9E96BAAEAD763AD669DD9C4EEFAB27FA9E1.Helpers.tableReader_541bb50a3b6745208ba6c897b267b2ca_GreedyMutable<TInputBuffer> item = FlatSharp.Compiler.Generated.NF4A24CE8AA6F3A384CD404C872EFD9E96BAAEAD763AD669DD9C4EEFAB27FA9E1.Helpers.Parse_GreedyMutable(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private CinematicPropKey GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, CinematicPropKey value)
		{
			list[index] = value;
		}

		public void Add(CinematicPropKey item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, CinematicPropKey item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(CinematicPropKey item)
		{
			return list.Remove(item);
		}

		public bool Contains(CinematicPropKey? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(CinematicPropKey? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(CinematicPropKey[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<CinematicPropKey> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<CinematicPropKey> value)
	{
		int count = value.Count;
		int num = 14;
		if (value is CinematicPropKey[] array)
		{
			foreach (CinematicPropKey cinematicPropKey in array)
			{
				SerializationHelpers.EnsureNonNull(cinematicPropKey);
				num += FlatSharp.Compiler.Generated.NF4A24CE8AA6F3A384CD404C872EFD9E96BAAEAD763AD669DD9C4EEFAB27FA9E1.Helpers.GetMaxSize(cinematicPropKey);
			}
		}
		else if (value is List<CinematicPropKey> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				CinematicPropKey cinematicPropKey2 = list[j];
				SerializationHelpers.EnsureNonNull(cinematicPropKey2);
				num += FlatSharp.Compiler.Generated.NF4A24CE8AA6F3A384CD404C872EFD9E96BAAEAD763AD669DD9C4EEFAB27FA9E1.Helpers.GetMaxSize(cinematicPropKey2);
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				CinematicPropKey cinematicPropKey3 = value[k];
				SerializationHelpers.EnsureNonNull(cinematicPropKey3);
				num += FlatSharp.Compiler.Generated.NF4A24CE8AA6F3A384CD404C872EFD9E96BAAEAD763AD669DD9C4EEFAB27FA9E1.Helpers.GetMaxSize(cinematicPropKey3);
			}
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<CinematicPropKey> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 4);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is CinematicPropKey[] array)
		{
			foreach (CinematicPropKey cinematicPropKey in array)
			{
				SerializationHelpers.EnsureNonNull(cinematicPropKey);
				FlatSharp.Compiler.Generated.NF4A24CE8AA6F3A384CD404C872EFD9E96BAAEAD763AD669DD9C4EEFAB27FA9E1.Helpers.Serialize(spanWriter, span, cinematicPropKey, num, context);
				num += 4;
			}
		}
		else if (value is List<CinematicPropKey> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				CinematicPropKey cinematicPropKey2 = list[j];
				SerializationHelpers.EnsureNonNull(cinematicPropKey2);
				FlatSharp.Compiler.Generated.NF4A24CE8AA6F3A384CD404C872EFD9E96BAAEAD763AD669DD9C4EEFAB27FA9E1.Helpers.Serialize(spanWriter, span, cinematicPropKey2, num, context);
				num += 4;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				CinematicPropKey cinematicPropKey3 = value[k];
				SerializationHelpers.EnsureNonNull(cinematicPropKey3);
				FlatSharp.Compiler.Generated.NF4A24CE8AA6F3A384CD404C872EFD9E96BAAEAD763AD669DD9C4EEFAB27FA9E1.Helpers.Serialize(spanWriter, span, cinematicPropKey3, num, context);
				num += 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<CinematicPropKey> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_31f373577b76cb6b1f9392cea19f26bc_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<CinematicPropKey> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_31f373577b76cb6b1f9392cea19f26bc_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<CinematicPropKey> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_31f373577b76cb6b1f9392cea19f26bc_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<CinematicPropKey> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_31f373577b76cb6b1f9392cea19f26bc_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
