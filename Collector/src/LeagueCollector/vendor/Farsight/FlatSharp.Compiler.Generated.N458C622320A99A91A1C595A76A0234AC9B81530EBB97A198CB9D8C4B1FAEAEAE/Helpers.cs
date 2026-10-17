using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Snapshot;
using FlatSharp.Compiler.Generated.N068A51452BC03E9A61AA9651462FB44A7C98ADC708958D44880A6A0B5EE68D7D;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N458C622320A99A91A1C595A76A0234AC9B81530EBB97A198CB9D8C4B1FAEAEAE;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ AnimationTrackState ], Count = {Count}")]
	internal sealed class GeneratedVector_b5ad5f343b45a7bede50755278ff3131_Lazy<TInputBuffer> : IList<AnimationTrackState>, ICollection<AnimationTrackState>, IEnumerable<AnimationTrackState>, IEnumerable, IReadOnlyList<AnimationTrackState>, IReadOnlyCollection<AnimationTrackState>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public AnimationTrackState this[int index]
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

		public GeneratedVector_b5ad5f343b45a7bede50755278ff3131_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N068A51452BC03E9A61AA9651462FB44A7C98ADC708958D44880A6A0B5EE68D7D.Helpers.tableReader_f4f70b1a744b4b80af8c2266c2d05876_Lazy<TInputBuffer> SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N068A51452BC03E9A61AA9651462FB44A7C98ADC708958D44880A6A0B5EE68D7D.Helpers.tableReader_f4f70b1a744b4b80af8c2266c2d05876_Lazy<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return FlatSharp.Compiler.Generated.N068A51452BC03E9A61AA9651462FB44A7C98ADC708958D44880A6A0B5EE68D7D.Helpers.Parse_Lazy(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, AnimationTrackState value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(AnimationTrackState? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(AnimationTrackState? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(AnimationTrackState[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<AnimationTrackState> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(AnimationTrackState item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, AnimationTrackState item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(AnimationTrackState item)
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

	[DebuggerDisplay("Progressive [ AnimationTrackState ], Count = {Count}")]
	internal sealed class GeneratedVector_b5ad5f343b45a7bede50755278ff3131_Progressive<TInputBuffer> : IList<AnimationTrackState>, ICollection<AnimationTrackState>, IEnumerable<AnimationTrackState>, IEnumerable, IReadOnlyList<AnimationTrackState>, IReadOnlyCollection<AnimationTrackState>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly FlatSharp.Compiler.Generated.N068A51452BC03E9A61AA9651462FB44A7C98ADC708958D44880A6A0B5EE68D7D.Helpers.tableReader_f4f70b1a744b4b80af8c2266c2d05876_Progressive<TInputBuffer>?[]?[] items;

		public AnimationTrackState this[int index]
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

		public GeneratedVector_b5ad5f343b45a7bede50755278ff3131_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new FlatSharp.Compiler.Generated.N068A51452BC03E9A61AA9651462FB44A7C98ADC708958D44880A6A0B5EE68D7D.Helpers.tableReader_f4f70b1a744b4b80af8c2266c2d05876_Progressive<TInputBuffer>[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N068A51452BC03E9A61AA9651462FB44A7C98ADC708958D44880A6A0B5EE68D7D.Helpers.tableReader_f4f70b1a744b4b80af8c2266c2d05876_Progressive<TInputBuffer>?[] GetOrCreateRow(FlatSharp.Compiler.Generated.N068A51452BC03E9A61AA9651462FB44A7C98ADC708958D44880A6A0B5EE68D7D.Helpers.tableReader_f4f70b1a744b4b80af8c2266c2d05876_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private FlatSharp.Compiler.Generated.N068A51452BC03E9A61AA9651462FB44A7C98ADC708958D44880A6A0B5EE68D7D.Helpers.tableReader_f4f70b1a744b4b80af8c2266c2d05876_Progressive<TInputBuffer>?[] CreateRow(FlatSharp.Compiler.Generated.N068A51452BC03E9A61AA9651462FB44A7C98ADC708958D44880A6A0B5EE68D7D.Helpers.tableReader_f4f70b1a744b4b80af8c2266c2d05876_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] = new FlatSharp.Compiler.Generated.N068A51452BC03E9A61AA9651462FB44A7C98ADC708958D44880A6A0B5EE68D7D.Helpers.tableReader_f4f70b1a744b4b80af8c2266c2d05876_Progressive<TInputBuffer>[32];
		}

		private FlatSharp.Compiler.Generated.N068A51452BC03E9A61AA9651462FB44A7C98ADC708958D44880A6A0B5EE68D7D.Helpers.tableReader_f4f70b1a744b4b80af8c2266c2d05876_Progressive<TInputBuffer> ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			FlatSharp.Compiler.Generated.N068A51452BC03E9A61AA9651462FB44A7C98ADC708958D44880A6A0B5EE68D7D.Helpers.tableReader_f4f70b1a744b4b80af8c2266c2d05876_Progressive<TInputBuffer>[][] array = items;
			FlatSharp.Compiler.Generated.N068A51452BC03E9A61AA9651462FB44A7C98ADC708958D44880A6A0B5EE68D7D.Helpers.tableReader_f4f70b1a744b4b80af8c2266c2d05876_Progressive<TInputBuffer>[] orCreateRow = GetOrCreateRow(array, rowIndex);
			FlatSharp.Compiler.Generated.N068A51452BC03E9A61AA9651462FB44A7C98ADC708958D44880A6A0B5EE68D7D.Helpers.tableReader_f4f70b1a744b4b80af8c2266c2d05876_Progressive<TInputBuffer> tableReader_f4f70b1a744b4b80af8c2266c2d05876_Progressive = orCreateRow[colIndex];
			if (tableReader_f4f70b1a744b4b80af8c2266c2d05876_Progressive == null)
			{
				tableReader_f4f70b1a744b4b80af8c2266c2d05876_Progressive = (orCreateRow[colIndex] = UnsafeParseItem(index));
			}
			return tableReader_f4f70b1a744b4b80af8c2266c2d05876_Progressive;
		}

		private void ProgressiveSet(int index, AnimationTrackState value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, AnimationTrackState value)
		{
			VectorUtilities.CheckIndex(index, count);
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N068A51452BC03E9A61AA9651462FB44A7C98ADC708958D44880A6A0B5EE68D7D.Helpers.tableReader_f4f70b1a744b4b80af8c2266c2d05876_Progressive<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N068A51452BC03E9A61AA9651462FB44A7C98ADC708958D44880A6A0B5EE68D7D.Helpers.tableReader_f4f70b1a744b4b80af8c2266c2d05876_Progressive<TInputBuffer> UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.N068A51452BC03E9A61AA9651462FB44A7C98ADC708958D44880A6A0B5EE68D7D.Helpers.Parse_Progressive(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, AnimationTrackState value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(AnimationTrackState? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(AnimationTrackState? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(AnimationTrackState[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<AnimationTrackState> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(AnimationTrackState item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, AnimationTrackState item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(AnimationTrackState item)
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

	[DebuggerDisplay("Greedy [ AnimationTrackState ], Count = {Count}")]
	internal sealed class GeneratedVector_b5ad5f343b45a7bede50755278ff3131_Greedy<TInputBuffer> : IList<AnimationTrackState>, ICollection<AnimationTrackState>, IEnumerable<AnimationTrackState>, IEnumerable, IReadOnlyList<AnimationTrackState>, IReadOnlyCollection<AnimationTrackState> where TInputBuffer : IInputBuffer
	{
		private readonly List<FlatSharp.Compiler.Generated.N068A51452BC03E9A61AA9651462FB44A7C98ADC708958D44880A6A0B5EE68D7D.Helpers.tableReader_f4f70b1a744b4b80af8c2266c2d05876_Greedy<TInputBuffer>> list;

		public AnimationTrackState this[int index]
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

		public GeneratedVector_b5ad5f343b45a7bede50755278ff3131_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<FlatSharp.Compiler.Generated.N068A51452BC03E9A61AA9651462FB44A7C98ADC708958D44880A6A0B5EE68D7D.Helpers.tableReader_f4f70b1a744b4b80af8c2266c2d05876_Greedy<TInputBuffer>> list = (this.list = new List<FlatSharp.Compiler.Generated.N068A51452BC03E9A61AA9651462FB44A7C98ADC708958D44880A6A0B5EE68D7D.Helpers.tableReader_f4f70b1a744b4b80af8c2266c2d05876_Greedy<TInputBuffer>>(num));
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.N068A51452BC03E9A61AA9651462FB44A7C98ADC708958D44880A6A0B5EE68D7D.Helpers.tableReader_f4f70b1a744b4b80af8c2266c2d05876_Greedy<TInputBuffer> item = FlatSharp.Compiler.Generated.N068A51452BC03E9A61AA9651462FB44A7C98ADC708958D44880A6A0B5EE68D7D.Helpers.Parse_Greedy(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		private FlatSharp.Compiler.Generated.N068A51452BC03E9A61AA9651462FB44A7C98ADC708958D44880A6A0B5EE68D7D.Helpers.tableReader_f4f70b1a744b4b80af8c2266c2d05876_Greedy<TInputBuffer> GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, AnimationTrackState value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(AnimationTrackState? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(AnimationTrackState? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(AnimationTrackState[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<AnimationTrackState> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(AnimationTrackState item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, AnimationTrackState item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(AnimationTrackState item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ AnimationTrackState ], Count = {Count}")]
	internal sealed class GeneratedVector_b5ad5f343b45a7bede50755278ff3131_GreedyMutable<TInputBuffer> : IList<AnimationTrackState>, ICollection<AnimationTrackState>, IEnumerable<AnimationTrackState>, IEnumerable, IReadOnlyList<AnimationTrackState>, IReadOnlyCollection<AnimationTrackState> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<AnimationTrackState> list;

		public AnimationTrackState this[int index]
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

		public GeneratedVector_b5ad5f343b45a7bede50755278ff3131_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<AnimationTrackState> list = (this.list = new List<AnimationTrackState>());
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.N068A51452BC03E9A61AA9651462FB44A7C98ADC708958D44880A6A0B5EE68D7D.Helpers.tableReader_f4f70b1a744b4b80af8c2266c2d05876_GreedyMutable<TInputBuffer> item = FlatSharp.Compiler.Generated.N068A51452BC03E9A61AA9651462FB44A7C98ADC708958D44880A6A0B5EE68D7D.Helpers.Parse_GreedyMutable(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private AnimationTrackState GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, AnimationTrackState value)
		{
			list[index] = value;
		}

		public void Add(AnimationTrackState item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, AnimationTrackState item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(AnimationTrackState item)
		{
			return list.Remove(item);
		}

		public bool Contains(AnimationTrackState? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(AnimationTrackState? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(AnimationTrackState[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<AnimationTrackState> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<AnimationTrackState> value)
	{
		int count = value.Count;
		int num = 14;
		if (value is AnimationTrackState[] array)
		{
			foreach (AnimationTrackState animationTrackState in array)
			{
				SerializationHelpers.EnsureNonNull(animationTrackState);
				num += FlatSharp.Compiler.Generated.N068A51452BC03E9A61AA9651462FB44A7C98ADC708958D44880A6A0B5EE68D7D.Helpers.GetMaxSize(animationTrackState);
			}
		}
		else if (value is List<AnimationTrackState> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				AnimationTrackState animationTrackState2 = list[j];
				SerializationHelpers.EnsureNonNull(animationTrackState2);
				num += FlatSharp.Compiler.Generated.N068A51452BC03E9A61AA9651462FB44A7C98ADC708958D44880A6A0B5EE68D7D.Helpers.GetMaxSize(animationTrackState2);
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				AnimationTrackState animationTrackState3 = value[k];
				SerializationHelpers.EnsureNonNull(animationTrackState3);
				num += FlatSharp.Compiler.Generated.N068A51452BC03E9A61AA9651462FB44A7C98ADC708958D44880A6A0B5EE68D7D.Helpers.GetMaxSize(animationTrackState3);
			}
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<AnimationTrackState> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 4);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is AnimationTrackState[] array)
		{
			foreach (AnimationTrackState animationTrackState in array)
			{
				SerializationHelpers.EnsureNonNull(animationTrackState);
				FlatSharp.Compiler.Generated.N068A51452BC03E9A61AA9651462FB44A7C98ADC708958D44880A6A0B5EE68D7D.Helpers.Serialize(spanWriter, span, animationTrackState, num, context);
				num += 4;
			}
		}
		else if (value is List<AnimationTrackState> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				AnimationTrackState animationTrackState2 = list[j];
				SerializationHelpers.EnsureNonNull(animationTrackState2);
				FlatSharp.Compiler.Generated.N068A51452BC03E9A61AA9651462FB44A7C98ADC708958D44880A6A0B5EE68D7D.Helpers.Serialize(spanWriter, span, animationTrackState2, num, context);
				num += 4;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				AnimationTrackState animationTrackState3 = value[k];
				SerializationHelpers.EnsureNonNull(animationTrackState3);
				FlatSharp.Compiler.Generated.N068A51452BC03E9A61AA9651462FB44A7C98ADC708958D44880A6A0B5EE68D7D.Helpers.Serialize(spanWriter, span, animationTrackState3, num, context);
				num += 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<AnimationTrackState> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_b5ad5f343b45a7bede50755278ff3131_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<AnimationTrackState> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_b5ad5f343b45a7bede50755278ff3131_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<AnimationTrackState> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_b5ad5f343b45a7bede50755278ff3131_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<AnimationTrackState> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_b5ad5f343b45a7bede50755278ff3131_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
