using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Snapshot;
using FlatSharp.Compiler.Generated.N026FC9D8044CA634DE75B08C852F686864A5C9AC2256E3E845546BACD7F5AE56;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.NC317D04C31680DABBDFF5D09FF684F6B370B2B8BE89F64B855B7FE227F4CDF94;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ AnimationContribution ], Count = {Count}")]
	internal sealed class GeneratedVector_f905a2cbeca3414dc64db5f9878649bf_Lazy<TInputBuffer> : IList<AnimationContribution>, ICollection<AnimationContribution>, IEnumerable<AnimationContribution>, IEnumerable, IReadOnlyList<AnimationContribution>, IReadOnlyCollection<AnimationContribution>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public AnimationContribution this[int index]
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

		public GeneratedVector_f905a2cbeca3414dc64db5f9878649bf_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N026FC9D8044CA634DE75B08C852F686864A5C9AC2256E3E845546BACD7F5AE56.Helpers.tableReader_108700d555f94875b8f48f5b49aec42a_Lazy<TInputBuffer> SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N026FC9D8044CA634DE75B08C852F686864A5C9AC2256E3E845546BACD7F5AE56.Helpers.tableReader_108700d555f94875b8f48f5b49aec42a_Lazy<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return FlatSharp.Compiler.Generated.N026FC9D8044CA634DE75B08C852F686864A5C9AC2256E3E845546BACD7F5AE56.Helpers.Parse_Lazy(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, AnimationContribution value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(AnimationContribution? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(AnimationContribution? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(AnimationContribution[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<AnimationContribution> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(AnimationContribution item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, AnimationContribution item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(AnimationContribution item)
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

	[DebuggerDisplay("Progressive [ AnimationContribution ], Count = {Count}")]
	internal sealed class GeneratedVector_f905a2cbeca3414dc64db5f9878649bf_Progressive<TInputBuffer> : IList<AnimationContribution>, ICollection<AnimationContribution>, IEnumerable<AnimationContribution>, IEnumerable, IReadOnlyList<AnimationContribution>, IReadOnlyCollection<AnimationContribution>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly FlatSharp.Compiler.Generated.N026FC9D8044CA634DE75B08C852F686864A5C9AC2256E3E845546BACD7F5AE56.Helpers.tableReader_108700d555f94875b8f48f5b49aec42a_Progressive<TInputBuffer>?[]?[] items;

		public AnimationContribution this[int index]
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

		public GeneratedVector_f905a2cbeca3414dc64db5f9878649bf_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new FlatSharp.Compiler.Generated.N026FC9D8044CA634DE75B08C852F686864A5C9AC2256E3E845546BACD7F5AE56.Helpers.tableReader_108700d555f94875b8f48f5b49aec42a_Progressive<TInputBuffer>[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N026FC9D8044CA634DE75B08C852F686864A5C9AC2256E3E845546BACD7F5AE56.Helpers.tableReader_108700d555f94875b8f48f5b49aec42a_Progressive<TInputBuffer>?[] GetOrCreateRow(FlatSharp.Compiler.Generated.N026FC9D8044CA634DE75B08C852F686864A5C9AC2256E3E845546BACD7F5AE56.Helpers.tableReader_108700d555f94875b8f48f5b49aec42a_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private FlatSharp.Compiler.Generated.N026FC9D8044CA634DE75B08C852F686864A5C9AC2256E3E845546BACD7F5AE56.Helpers.tableReader_108700d555f94875b8f48f5b49aec42a_Progressive<TInputBuffer>?[] CreateRow(FlatSharp.Compiler.Generated.N026FC9D8044CA634DE75B08C852F686864A5C9AC2256E3E845546BACD7F5AE56.Helpers.tableReader_108700d555f94875b8f48f5b49aec42a_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] = new FlatSharp.Compiler.Generated.N026FC9D8044CA634DE75B08C852F686864A5C9AC2256E3E845546BACD7F5AE56.Helpers.tableReader_108700d555f94875b8f48f5b49aec42a_Progressive<TInputBuffer>[32];
		}

		private FlatSharp.Compiler.Generated.N026FC9D8044CA634DE75B08C852F686864A5C9AC2256E3E845546BACD7F5AE56.Helpers.tableReader_108700d555f94875b8f48f5b49aec42a_Progressive<TInputBuffer> ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			FlatSharp.Compiler.Generated.N026FC9D8044CA634DE75B08C852F686864A5C9AC2256E3E845546BACD7F5AE56.Helpers.tableReader_108700d555f94875b8f48f5b49aec42a_Progressive<TInputBuffer>[][] array = items;
			FlatSharp.Compiler.Generated.N026FC9D8044CA634DE75B08C852F686864A5C9AC2256E3E845546BACD7F5AE56.Helpers.tableReader_108700d555f94875b8f48f5b49aec42a_Progressive<TInputBuffer>[] orCreateRow = GetOrCreateRow(array, rowIndex);
			FlatSharp.Compiler.Generated.N026FC9D8044CA634DE75B08C852F686864A5C9AC2256E3E845546BACD7F5AE56.Helpers.tableReader_108700d555f94875b8f48f5b49aec42a_Progressive<TInputBuffer> tableReader_108700d555f94875b8f48f5b49aec42a_Progressive = orCreateRow[colIndex];
			if (tableReader_108700d555f94875b8f48f5b49aec42a_Progressive == null)
			{
				tableReader_108700d555f94875b8f48f5b49aec42a_Progressive = (orCreateRow[colIndex] = UnsafeParseItem(index));
			}
			return tableReader_108700d555f94875b8f48f5b49aec42a_Progressive;
		}

		private void ProgressiveSet(int index, AnimationContribution value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, AnimationContribution value)
		{
			VectorUtilities.CheckIndex(index, count);
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N026FC9D8044CA634DE75B08C852F686864A5C9AC2256E3E845546BACD7F5AE56.Helpers.tableReader_108700d555f94875b8f48f5b49aec42a_Progressive<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N026FC9D8044CA634DE75B08C852F686864A5C9AC2256E3E845546BACD7F5AE56.Helpers.tableReader_108700d555f94875b8f48f5b49aec42a_Progressive<TInputBuffer> UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.N026FC9D8044CA634DE75B08C852F686864A5C9AC2256E3E845546BACD7F5AE56.Helpers.Parse_Progressive(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, AnimationContribution value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(AnimationContribution? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(AnimationContribution? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(AnimationContribution[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<AnimationContribution> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(AnimationContribution item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, AnimationContribution item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(AnimationContribution item)
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

	[DebuggerDisplay("Greedy [ AnimationContribution ], Count = {Count}")]
	internal sealed class GeneratedVector_f905a2cbeca3414dc64db5f9878649bf_Greedy<TInputBuffer> : IList<AnimationContribution>, ICollection<AnimationContribution>, IEnumerable<AnimationContribution>, IEnumerable, IReadOnlyList<AnimationContribution>, IReadOnlyCollection<AnimationContribution> where TInputBuffer : IInputBuffer
	{
		private readonly List<FlatSharp.Compiler.Generated.N026FC9D8044CA634DE75B08C852F686864A5C9AC2256E3E845546BACD7F5AE56.Helpers.tableReader_108700d555f94875b8f48f5b49aec42a_Greedy<TInputBuffer>> list;

		public AnimationContribution this[int index]
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

		public GeneratedVector_f905a2cbeca3414dc64db5f9878649bf_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<FlatSharp.Compiler.Generated.N026FC9D8044CA634DE75B08C852F686864A5C9AC2256E3E845546BACD7F5AE56.Helpers.tableReader_108700d555f94875b8f48f5b49aec42a_Greedy<TInputBuffer>> list = (this.list = new List<FlatSharp.Compiler.Generated.N026FC9D8044CA634DE75B08C852F686864A5C9AC2256E3E845546BACD7F5AE56.Helpers.tableReader_108700d555f94875b8f48f5b49aec42a_Greedy<TInputBuffer>>(num));
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.N026FC9D8044CA634DE75B08C852F686864A5C9AC2256E3E845546BACD7F5AE56.Helpers.tableReader_108700d555f94875b8f48f5b49aec42a_Greedy<TInputBuffer> item = FlatSharp.Compiler.Generated.N026FC9D8044CA634DE75B08C852F686864A5C9AC2256E3E845546BACD7F5AE56.Helpers.Parse_Greedy(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		private FlatSharp.Compiler.Generated.N026FC9D8044CA634DE75B08C852F686864A5C9AC2256E3E845546BACD7F5AE56.Helpers.tableReader_108700d555f94875b8f48f5b49aec42a_Greedy<TInputBuffer> GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, AnimationContribution value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(AnimationContribution? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(AnimationContribution? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(AnimationContribution[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<AnimationContribution> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(AnimationContribution item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, AnimationContribution item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(AnimationContribution item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ AnimationContribution ], Count = {Count}")]
	internal sealed class GeneratedVector_f905a2cbeca3414dc64db5f9878649bf_GreedyMutable<TInputBuffer> : IList<AnimationContribution>, ICollection<AnimationContribution>, IEnumerable<AnimationContribution>, IEnumerable, IReadOnlyList<AnimationContribution>, IReadOnlyCollection<AnimationContribution> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<AnimationContribution> list;

		public AnimationContribution this[int index]
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

		public GeneratedVector_f905a2cbeca3414dc64db5f9878649bf_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<AnimationContribution> list = (this.list = new List<AnimationContribution>());
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.N026FC9D8044CA634DE75B08C852F686864A5C9AC2256E3E845546BACD7F5AE56.Helpers.tableReader_108700d555f94875b8f48f5b49aec42a_GreedyMutable<TInputBuffer> item = FlatSharp.Compiler.Generated.N026FC9D8044CA634DE75B08C852F686864A5C9AC2256E3E845546BACD7F5AE56.Helpers.Parse_GreedyMutable(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private AnimationContribution GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, AnimationContribution value)
		{
			list[index] = value;
		}

		public void Add(AnimationContribution item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, AnimationContribution item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(AnimationContribution item)
		{
			return list.Remove(item);
		}

		public bool Contains(AnimationContribution? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(AnimationContribution? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(AnimationContribution[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<AnimationContribution> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<AnimationContribution> value)
	{
		int count = value.Count;
		int num = 14;
		if (value is AnimationContribution[] array)
		{
			foreach (AnimationContribution animationContribution in array)
			{
				SerializationHelpers.EnsureNonNull(animationContribution);
				num += FlatSharp.Compiler.Generated.N026FC9D8044CA634DE75B08C852F686864A5C9AC2256E3E845546BACD7F5AE56.Helpers.GetMaxSize(animationContribution);
			}
		}
		else if (value is List<AnimationContribution> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				AnimationContribution animationContribution2 = list[j];
				SerializationHelpers.EnsureNonNull(animationContribution2);
				num += FlatSharp.Compiler.Generated.N026FC9D8044CA634DE75B08C852F686864A5C9AC2256E3E845546BACD7F5AE56.Helpers.GetMaxSize(animationContribution2);
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				AnimationContribution animationContribution3 = value[k];
				SerializationHelpers.EnsureNonNull(animationContribution3);
				num += FlatSharp.Compiler.Generated.N026FC9D8044CA634DE75B08C852F686864A5C9AC2256E3E845546BACD7F5AE56.Helpers.GetMaxSize(animationContribution3);
			}
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<AnimationContribution> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 4);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is AnimationContribution[] array)
		{
			foreach (AnimationContribution animationContribution in array)
			{
				SerializationHelpers.EnsureNonNull(animationContribution);
				FlatSharp.Compiler.Generated.N026FC9D8044CA634DE75B08C852F686864A5C9AC2256E3E845546BACD7F5AE56.Helpers.Serialize(spanWriter, span, animationContribution, num, context);
				num += 4;
			}
		}
		else if (value is List<AnimationContribution> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				AnimationContribution animationContribution2 = list[j];
				SerializationHelpers.EnsureNonNull(animationContribution2);
				FlatSharp.Compiler.Generated.N026FC9D8044CA634DE75B08C852F686864A5C9AC2256E3E845546BACD7F5AE56.Helpers.Serialize(spanWriter, span, animationContribution2, num, context);
				num += 4;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				AnimationContribution animationContribution3 = value[k];
				SerializationHelpers.EnsureNonNull(animationContribution3);
				FlatSharp.Compiler.Generated.N026FC9D8044CA634DE75B08C852F686864A5C9AC2256E3E845546BACD7F5AE56.Helpers.Serialize(spanWriter, span, animationContribution3, num, context);
				num += 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<AnimationContribution> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_f905a2cbeca3414dc64db5f9878649bf_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<AnimationContribution> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_f905a2cbeca3414dc64db5f9878649bf_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<AnimationContribution> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_f905a2cbeca3414dc64db5f9878649bf_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<AnimationContribution> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_f905a2cbeca3414dc64db5f9878649bf_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
