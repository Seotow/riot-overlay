using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Snapshot;
using FlatSharp.Compiler.Generated.N1788683860D64B9ADF2D198B74BFE57C2C7FB3A48205D7AAD9449B30469B566E;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.NE863D08BB30A51E26819C00AE83A013A5E4C48A76FEA2B21DA83BFFA55FEAAEE;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ DeathEvent ], Count = {Count}")]
	internal sealed class GeneratedVector_a66a70899e3d1c53f97bbf4ecfecf2a5_Lazy<TInputBuffer> : IList<DeathEvent>, ICollection<DeathEvent>, IEnumerable<DeathEvent>, IEnumerable, IReadOnlyList<DeathEvent>, IReadOnlyCollection<DeathEvent>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public DeathEvent this[int index]
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

		int IFlatBufferDeserializedVector.ItemSize => 20;

		int IFlatBufferDeserializedVector.OffsetBase => offset;

		public GeneratedVector_a66a70899e3d1c53f97bbf4ecfecf2a5_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N1788683860D64B9ADF2D198B74BFE57C2C7FB3A48205D7AAD9449B30469B566E.Helpers.structReader_240214ae39b546fc97a4fb8d77ebfcc3_Lazy<TInputBuffer> SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N1788683860D64B9ADF2D198B74BFE57C2C7FB3A48205D7AAD9449B30469B566E.Helpers.structReader_240214ae39b546fc97a4fb8d77ebfcc3_Lazy<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + 20 * index;
			return FlatSharp.Compiler.Generated.N1788683860D64B9ADF2D198B74BFE57C2C7FB3A48205D7AAD9449B30469B566E.Helpers.Parse_Lazy(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, DeathEvent value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(DeathEvent? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(DeathEvent? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(DeathEvent[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<DeathEvent> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(DeathEvent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, DeathEvent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(DeathEvent item)
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
			return offset + 20 * index;
		}
	}

	[DebuggerDisplay("Progressive [ DeathEvent ], Count = {Count}")]
	internal sealed class GeneratedVector_a66a70899e3d1c53f97bbf4ecfecf2a5_Progressive<TInputBuffer> : IList<DeathEvent>, ICollection<DeathEvent>, IEnumerable<DeathEvent>, IEnumerable, IReadOnlyList<DeathEvent>, IReadOnlyCollection<DeathEvent>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly FlatSharp.Compiler.Generated.N1788683860D64B9ADF2D198B74BFE57C2C7FB3A48205D7AAD9449B30469B566E.Helpers.structReader_240214ae39b546fc97a4fb8d77ebfcc3_Progressive<TInputBuffer>?[]?[] items;

		public DeathEvent this[int index]
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

		int IFlatBufferDeserializedVector.ItemSize => 20;

		int IFlatBufferDeserializedVector.OffsetBase => offset;

		public GeneratedVector_a66a70899e3d1c53f97bbf4ecfecf2a5_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new FlatSharp.Compiler.Generated.N1788683860D64B9ADF2D198B74BFE57C2C7FB3A48205D7AAD9449B30469B566E.Helpers.structReader_240214ae39b546fc97a4fb8d77ebfcc3_Progressive<TInputBuffer>[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N1788683860D64B9ADF2D198B74BFE57C2C7FB3A48205D7AAD9449B30469B566E.Helpers.structReader_240214ae39b546fc97a4fb8d77ebfcc3_Progressive<TInputBuffer>?[] GetOrCreateRow(FlatSharp.Compiler.Generated.N1788683860D64B9ADF2D198B74BFE57C2C7FB3A48205D7AAD9449B30469B566E.Helpers.structReader_240214ae39b546fc97a4fb8d77ebfcc3_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private FlatSharp.Compiler.Generated.N1788683860D64B9ADF2D198B74BFE57C2C7FB3A48205D7AAD9449B30469B566E.Helpers.structReader_240214ae39b546fc97a4fb8d77ebfcc3_Progressive<TInputBuffer>?[] CreateRow(FlatSharp.Compiler.Generated.N1788683860D64B9ADF2D198B74BFE57C2C7FB3A48205D7AAD9449B30469B566E.Helpers.structReader_240214ae39b546fc97a4fb8d77ebfcc3_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] = new FlatSharp.Compiler.Generated.N1788683860D64B9ADF2D198B74BFE57C2C7FB3A48205D7AAD9449B30469B566E.Helpers.structReader_240214ae39b546fc97a4fb8d77ebfcc3_Progressive<TInputBuffer>[32];
		}

		private FlatSharp.Compiler.Generated.N1788683860D64B9ADF2D198B74BFE57C2C7FB3A48205D7AAD9449B30469B566E.Helpers.structReader_240214ae39b546fc97a4fb8d77ebfcc3_Progressive<TInputBuffer> ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			FlatSharp.Compiler.Generated.N1788683860D64B9ADF2D198B74BFE57C2C7FB3A48205D7AAD9449B30469B566E.Helpers.structReader_240214ae39b546fc97a4fb8d77ebfcc3_Progressive<TInputBuffer>[][] array = items;
			FlatSharp.Compiler.Generated.N1788683860D64B9ADF2D198B74BFE57C2C7FB3A48205D7AAD9449B30469B566E.Helpers.structReader_240214ae39b546fc97a4fb8d77ebfcc3_Progressive<TInputBuffer>[] orCreateRow = GetOrCreateRow(array, rowIndex);
			FlatSharp.Compiler.Generated.N1788683860D64B9ADF2D198B74BFE57C2C7FB3A48205D7AAD9449B30469B566E.Helpers.structReader_240214ae39b546fc97a4fb8d77ebfcc3_Progressive<TInputBuffer> structReader_240214ae39b546fc97a4fb8d77ebfcc3_Progressive = orCreateRow[colIndex];
			if (structReader_240214ae39b546fc97a4fb8d77ebfcc3_Progressive == null)
			{
				structReader_240214ae39b546fc97a4fb8d77ebfcc3_Progressive = (orCreateRow[colIndex] = UnsafeParseItem(index));
			}
			return structReader_240214ae39b546fc97a4fb8d77ebfcc3_Progressive;
		}

		private void ProgressiveSet(int index, DeathEvent value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, DeathEvent value)
		{
			VectorUtilities.CheckIndex(index, count);
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N1788683860D64B9ADF2D198B74BFE57C2C7FB3A48205D7AAD9449B30469B566E.Helpers.structReader_240214ae39b546fc97a4fb8d77ebfcc3_Progressive<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + 20 * index;
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N1788683860D64B9ADF2D198B74BFE57C2C7FB3A48205D7AAD9449B30469B566E.Helpers.structReader_240214ae39b546fc97a4fb8d77ebfcc3_Progressive<TInputBuffer> UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.N1788683860D64B9ADF2D198B74BFE57C2C7FB3A48205D7AAD9449B30469B566E.Helpers.Parse_Progressive(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, DeathEvent value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(DeathEvent? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(DeathEvent? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(DeathEvent[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<DeathEvent> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(DeathEvent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, DeathEvent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(DeathEvent item)
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
			return offset + 20 * index;
		}
	}

	[DebuggerDisplay("Greedy [ DeathEvent ], Count = {Count}")]
	internal sealed class GeneratedVector_a66a70899e3d1c53f97bbf4ecfecf2a5_Greedy<TInputBuffer> : IList<DeathEvent>, ICollection<DeathEvent>, IEnumerable<DeathEvent>, IEnumerable, IReadOnlyList<DeathEvent>, IReadOnlyCollection<DeathEvent> where TInputBuffer : IInputBuffer
	{
		private readonly List<FlatSharp.Compiler.Generated.N1788683860D64B9ADF2D198B74BFE57C2C7FB3A48205D7AAD9449B30469B566E.Helpers.structReader_240214ae39b546fc97a4fb8d77ebfcc3_Greedy<TInputBuffer>> list;

		public DeathEvent this[int index]
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

		public GeneratedVector_a66a70899e3d1c53f97bbf4ecfecf2a5_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<FlatSharp.Compiler.Generated.N1788683860D64B9ADF2D198B74BFE57C2C7FB3A48205D7AAD9449B30469B566E.Helpers.structReader_240214ae39b546fc97a4fb8d77ebfcc3_Greedy<TInputBuffer>> list = (this.list = new List<FlatSharp.Compiler.Generated.N1788683860D64B9ADF2D198B74BFE57C2C7FB3A48205D7AAD9449B30469B566E.Helpers.structReader_240214ae39b546fc97a4fb8d77ebfcc3_Greedy<TInputBuffer>>(num));
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.N1788683860D64B9ADF2D198B74BFE57C2C7FB3A48205D7AAD9449B30469B566E.Helpers.structReader_240214ae39b546fc97a4fb8d77ebfcc3_Greedy<TInputBuffer> item = FlatSharp.Compiler.Generated.N1788683860D64B9ADF2D198B74BFE57C2C7FB3A48205D7AAD9449B30469B566E.Helpers.Parse_Greedy(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 20;
			}
		}

		private FlatSharp.Compiler.Generated.N1788683860D64B9ADF2D198B74BFE57C2C7FB3A48205D7AAD9449B30469B566E.Helpers.structReader_240214ae39b546fc97a4fb8d77ebfcc3_Greedy<TInputBuffer> GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, DeathEvent value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(DeathEvent? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(DeathEvent? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(DeathEvent[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<DeathEvent> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(DeathEvent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, DeathEvent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(DeathEvent item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ DeathEvent ], Count = {Count}")]
	internal sealed class GeneratedVector_a66a70899e3d1c53f97bbf4ecfecf2a5_GreedyMutable<TInputBuffer> : IList<DeathEvent>, ICollection<DeathEvent>, IEnumerable<DeathEvent>, IEnumerable, IReadOnlyList<DeathEvent>, IReadOnlyCollection<DeathEvent> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<DeathEvent> list;

		public DeathEvent this[int index]
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

		public GeneratedVector_a66a70899e3d1c53f97bbf4ecfecf2a5_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<DeathEvent> list = (this.list = new List<DeathEvent>());
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.N1788683860D64B9ADF2D198B74BFE57C2C7FB3A48205D7AAD9449B30469B566E.Helpers.structReader_240214ae39b546fc97a4fb8d77ebfcc3_GreedyMutable<TInputBuffer> item = FlatSharp.Compiler.Generated.N1788683860D64B9ADF2D198B74BFE57C2C7FB3A48205D7AAD9449B30469B566E.Helpers.Parse_GreedyMutable(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 20;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private DeathEvent GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, DeathEvent value)
		{
			list[index] = value;
		}

		public void Add(DeathEvent item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, DeathEvent item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(DeathEvent item)
		{
			return list.Remove(item);
		}

		public bool Contains(DeathEvent? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(DeathEvent? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(DeathEvent[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<DeathEvent> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<DeathEvent> value)
	{
		return 10 + 20 * value.Count;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<DeathEvent> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 20);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is DeathEvent[] array)
		{
			foreach (DeathEvent deathEvent in array)
			{
				SerializationHelpers.EnsureNonNull(deathEvent);
				FlatSharp.Compiler.Generated.N1788683860D64B9ADF2D198B74BFE57C2C7FB3A48205D7AAD9449B30469B566E.Helpers.Serialize(spanWriter, span, deathEvent, num);
				num += 20;
			}
		}
		else if (value is List<DeathEvent> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				DeathEvent deathEvent2 = list[j];
				SerializationHelpers.EnsureNonNull(deathEvent2);
				FlatSharp.Compiler.Generated.N1788683860D64B9ADF2D198B74BFE57C2C7FB3A48205D7AAD9449B30469B566E.Helpers.Serialize(spanWriter, span, deathEvent2, num);
				num += 20;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				DeathEvent deathEvent3 = value[k];
				SerializationHelpers.EnsureNonNull(deathEvent3);
				FlatSharp.Compiler.Generated.N1788683860D64B9ADF2D198B74BFE57C2C7FB3A48205D7AAD9449B30469B566E.Helpers.Serialize(spanWriter, span, deathEvent3, num);
				num += 20;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<DeathEvent> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_a66a70899e3d1c53f97bbf4ecfecf2a5_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<DeathEvent> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_a66a70899e3d1c53f97bbf4ecfecf2a5_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<DeathEvent> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_a66a70899e3d1c53f97bbf4ecfecf2a5_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<DeathEvent> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_a66a70899e3d1c53f97bbf4ecfecf2a5_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
