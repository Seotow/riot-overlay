using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Cinematics;
using FlatSharp.Compiler.Generated.N6870943D8AEE944A83EB255ABEA04E939025A4501BA2D77DD6E383E865833AE7;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N4CFCEA029A77422A168508762952090A3C3269E1B690082A0B33089E74E992A8;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ CinematicProp ], Count = {Count}")]
	internal sealed class GeneratedVector_5ae8b1dcb1828aba588fa81c3ac8ea91_Lazy<TInputBuffer> : IList<CinematicProp>, ICollection<CinematicProp>, IEnumerable<CinematicProp>, IEnumerable, IReadOnlyList<CinematicProp>, IReadOnlyCollection<CinematicProp>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public CinematicProp this[int index]
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

		public GeneratedVector_5ae8b1dcb1828aba588fa81c3ac8ea91_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N6870943D8AEE944A83EB255ABEA04E939025A4501BA2D77DD6E383E865833AE7.Helpers.tableReader_d8e7163e81db413995fc887d97a4ac5e_Lazy<TInputBuffer> SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N6870943D8AEE944A83EB255ABEA04E939025A4501BA2D77DD6E383E865833AE7.Helpers.tableReader_d8e7163e81db413995fc887d97a4ac5e_Lazy<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return FlatSharp.Compiler.Generated.N6870943D8AEE944A83EB255ABEA04E939025A4501BA2D77DD6E383E865833AE7.Helpers.Parse_Lazy(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, CinematicProp value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(CinematicProp? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(CinematicProp? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(CinematicProp[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<CinematicProp> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(CinematicProp item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, CinematicProp item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(CinematicProp item)
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

	[DebuggerDisplay("Progressive [ CinematicProp ], Count = {Count}")]
	internal sealed class GeneratedVector_5ae8b1dcb1828aba588fa81c3ac8ea91_Progressive<TInputBuffer> : IList<CinematicProp>, ICollection<CinematicProp>, IEnumerable<CinematicProp>, IEnumerable, IReadOnlyList<CinematicProp>, IReadOnlyCollection<CinematicProp>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly FlatSharp.Compiler.Generated.N6870943D8AEE944A83EB255ABEA04E939025A4501BA2D77DD6E383E865833AE7.Helpers.tableReader_d8e7163e81db413995fc887d97a4ac5e_Progressive<TInputBuffer>?[]?[] items;

		public CinematicProp this[int index]
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

		public GeneratedVector_5ae8b1dcb1828aba588fa81c3ac8ea91_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new FlatSharp.Compiler.Generated.N6870943D8AEE944A83EB255ABEA04E939025A4501BA2D77DD6E383E865833AE7.Helpers.tableReader_d8e7163e81db413995fc887d97a4ac5e_Progressive<TInputBuffer>[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N6870943D8AEE944A83EB255ABEA04E939025A4501BA2D77DD6E383E865833AE7.Helpers.tableReader_d8e7163e81db413995fc887d97a4ac5e_Progressive<TInputBuffer>?[] GetOrCreateRow(FlatSharp.Compiler.Generated.N6870943D8AEE944A83EB255ABEA04E939025A4501BA2D77DD6E383E865833AE7.Helpers.tableReader_d8e7163e81db413995fc887d97a4ac5e_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private FlatSharp.Compiler.Generated.N6870943D8AEE944A83EB255ABEA04E939025A4501BA2D77DD6E383E865833AE7.Helpers.tableReader_d8e7163e81db413995fc887d97a4ac5e_Progressive<TInputBuffer>?[] CreateRow(FlatSharp.Compiler.Generated.N6870943D8AEE944A83EB255ABEA04E939025A4501BA2D77DD6E383E865833AE7.Helpers.tableReader_d8e7163e81db413995fc887d97a4ac5e_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] = new FlatSharp.Compiler.Generated.N6870943D8AEE944A83EB255ABEA04E939025A4501BA2D77DD6E383E865833AE7.Helpers.tableReader_d8e7163e81db413995fc887d97a4ac5e_Progressive<TInputBuffer>[32];
		}

		private FlatSharp.Compiler.Generated.N6870943D8AEE944A83EB255ABEA04E939025A4501BA2D77DD6E383E865833AE7.Helpers.tableReader_d8e7163e81db413995fc887d97a4ac5e_Progressive<TInputBuffer> ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			FlatSharp.Compiler.Generated.N6870943D8AEE944A83EB255ABEA04E939025A4501BA2D77DD6E383E865833AE7.Helpers.tableReader_d8e7163e81db413995fc887d97a4ac5e_Progressive<TInputBuffer>[][] array = items;
			FlatSharp.Compiler.Generated.N6870943D8AEE944A83EB255ABEA04E939025A4501BA2D77DD6E383E865833AE7.Helpers.tableReader_d8e7163e81db413995fc887d97a4ac5e_Progressive<TInputBuffer>[] orCreateRow = GetOrCreateRow(array, rowIndex);
			FlatSharp.Compiler.Generated.N6870943D8AEE944A83EB255ABEA04E939025A4501BA2D77DD6E383E865833AE7.Helpers.tableReader_d8e7163e81db413995fc887d97a4ac5e_Progressive<TInputBuffer> tableReader_d8e7163e81db413995fc887d97a4ac5e_Progressive = orCreateRow[colIndex];
			if (tableReader_d8e7163e81db413995fc887d97a4ac5e_Progressive == null)
			{
				tableReader_d8e7163e81db413995fc887d97a4ac5e_Progressive = (orCreateRow[colIndex] = UnsafeParseItem(index));
			}
			return tableReader_d8e7163e81db413995fc887d97a4ac5e_Progressive;
		}

		private void ProgressiveSet(int index, CinematicProp value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, CinematicProp value)
		{
			VectorUtilities.CheckIndex(index, count);
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N6870943D8AEE944A83EB255ABEA04E939025A4501BA2D77DD6E383E865833AE7.Helpers.tableReader_d8e7163e81db413995fc887d97a4ac5e_Progressive<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N6870943D8AEE944A83EB255ABEA04E939025A4501BA2D77DD6E383E865833AE7.Helpers.tableReader_d8e7163e81db413995fc887d97a4ac5e_Progressive<TInputBuffer> UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.N6870943D8AEE944A83EB255ABEA04E939025A4501BA2D77DD6E383E865833AE7.Helpers.Parse_Progressive(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, CinematicProp value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(CinematicProp? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(CinematicProp? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(CinematicProp[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<CinematicProp> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(CinematicProp item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, CinematicProp item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(CinematicProp item)
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

	[DebuggerDisplay("Greedy [ CinematicProp ], Count = {Count}")]
	internal sealed class GeneratedVector_5ae8b1dcb1828aba588fa81c3ac8ea91_Greedy<TInputBuffer> : IList<CinematicProp>, ICollection<CinematicProp>, IEnumerable<CinematicProp>, IEnumerable, IReadOnlyList<CinematicProp>, IReadOnlyCollection<CinematicProp> where TInputBuffer : IInputBuffer
	{
		private readonly List<FlatSharp.Compiler.Generated.N6870943D8AEE944A83EB255ABEA04E939025A4501BA2D77DD6E383E865833AE7.Helpers.tableReader_d8e7163e81db413995fc887d97a4ac5e_Greedy<TInputBuffer>> list;

		public CinematicProp this[int index]
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

		public GeneratedVector_5ae8b1dcb1828aba588fa81c3ac8ea91_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<FlatSharp.Compiler.Generated.N6870943D8AEE944A83EB255ABEA04E939025A4501BA2D77DD6E383E865833AE7.Helpers.tableReader_d8e7163e81db413995fc887d97a4ac5e_Greedy<TInputBuffer>> list = (this.list = new List<FlatSharp.Compiler.Generated.N6870943D8AEE944A83EB255ABEA04E939025A4501BA2D77DD6E383E865833AE7.Helpers.tableReader_d8e7163e81db413995fc887d97a4ac5e_Greedy<TInputBuffer>>(num));
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.N6870943D8AEE944A83EB255ABEA04E939025A4501BA2D77DD6E383E865833AE7.Helpers.tableReader_d8e7163e81db413995fc887d97a4ac5e_Greedy<TInputBuffer> item = FlatSharp.Compiler.Generated.N6870943D8AEE944A83EB255ABEA04E939025A4501BA2D77DD6E383E865833AE7.Helpers.Parse_Greedy(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		private FlatSharp.Compiler.Generated.N6870943D8AEE944A83EB255ABEA04E939025A4501BA2D77DD6E383E865833AE7.Helpers.tableReader_d8e7163e81db413995fc887d97a4ac5e_Greedy<TInputBuffer> GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, CinematicProp value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(CinematicProp? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(CinematicProp? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(CinematicProp[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<CinematicProp> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(CinematicProp item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, CinematicProp item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(CinematicProp item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ CinematicProp ], Count = {Count}")]
	internal sealed class GeneratedVector_5ae8b1dcb1828aba588fa81c3ac8ea91_GreedyMutable<TInputBuffer> : IList<CinematicProp>, ICollection<CinematicProp>, IEnumerable<CinematicProp>, IEnumerable, IReadOnlyList<CinematicProp>, IReadOnlyCollection<CinematicProp> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<CinematicProp> list;

		public CinematicProp this[int index]
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

		public GeneratedVector_5ae8b1dcb1828aba588fa81c3ac8ea91_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<CinematicProp> list = (this.list = new List<CinematicProp>());
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.N6870943D8AEE944A83EB255ABEA04E939025A4501BA2D77DD6E383E865833AE7.Helpers.tableReader_d8e7163e81db413995fc887d97a4ac5e_GreedyMutable<TInputBuffer> item = FlatSharp.Compiler.Generated.N6870943D8AEE944A83EB255ABEA04E939025A4501BA2D77DD6E383E865833AE7.Helpers.Parse_GreedyMutable(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private CinematicProp GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, CinematicProp value)
		{
			list[index] = value;
		}

		public void Add(CinematicProp item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, CinematicProp item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(CinematicProp item)
		{
			return list.Remove(item);
		}

		public bool Contains(CinematicProp? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(CinematicProp? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(CinematicProp[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<CinematicProp> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<CinematicProp> value)
	{
		int count = value.Count;
		int num = 14;
		if (value is CinematicProp[] array)
		{
			foreach (CinematicProp cinematicProp in array)
			{
				SerializationHelpers.EnsureNonNull(cinematicProp);
				num += FlatSharp.Compiler.Generated.N6870943D8AEE944A83EB255ABEA04E939025A4501BA2D77DD6E383E865833AE7.Helpers.GetMaxSize(cinematicProp);
			}
		}
		else if (value is List<CinematicProp> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				CinematicProp cinematicProp2 = list[j];
				SerializationHelpers.EnsureNonNull(cinematicProp2);
				num += FlatSharp.Compiler.Generated.N6870943D8AEE944A83EB255ABEA04E939025A4501BA2D77DD6E383E865833AE7.Helpers.GetMaxSize(cinematicProp2);
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				CinematicProp cinematicProp3 = value[k];
				SerializationHelpers.EnsureNonNull(cinematicProp3);
				num += FlatSharp.Compiler.Generated.N6870943D8AEE944A83EB255ABEA04E939025A4501BA2D77DD6E383E865833AE7.Helpers.GetMaxSize(cinematicProp3);
			}
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<CinematicProp> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 4);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is CinematicProp[] array)
		{
			foreach (CinematicProp cinematicProp in array)
			{
				SerializationHelpers.EnsureNonNull(cinematicProp);
				FlatSharp.Compiler.Generated.N6870943D8AEE944A83EB255ABEA04E939025A4501BA2D77DD6E383E865833AE7.Helpers.Serialize(spanWriter, span, cinematicProp, num, context);
				num += 4;
			}
		}
		else if (value is List<CinematicProp> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				CinematicProp cinematicProp2 = list[j];
				SerializationHelpers.EnsureNonNull(cinematicProp2);
				FlatSharp.Compiler.Generated.N6870943D8AEE944A83EB255ABEA04E939025A4501BA2D77DD6E383E865833AE7.Helpers.Serialize(spanWriter, span, cinematicProp2, num, context);
				num += 4;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				CinematicProp cinematicProp3 = value[k];
				SerializationHelpers.EnsureNonNull(cinematicProp3);
				FlatSharp.Compiler.Generated.N6870943D8AEE944A83EB255ABEA04E939025A4501BA2D77DD6E383E865833AE7.Helpers.Serialize(spanWriter, span, cinematicProp3, num, context);
				num += 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<CinematicProp> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_5ae8b1dcb1828aba588fa81c3ac8ea91_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<CinematicProp> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_5ae8b1dcb1828aba588fa81c3ac8ea91_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<CinematicProp> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_5ae8b1dcb1828aba588fa81c3ac8ea91_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<CinematicProp> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_5ae8b1dcb1828aba588fa81c3ac8ea91_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
