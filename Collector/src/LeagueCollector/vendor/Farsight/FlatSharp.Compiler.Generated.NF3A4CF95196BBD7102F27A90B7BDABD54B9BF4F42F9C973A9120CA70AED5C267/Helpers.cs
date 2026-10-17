using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Entity;
using FlatSharp.Compiler.Generated.NE45C68FE420A1FC00D9860CDCA64CC850967C67FB72ECD5608223354D5C85C4B;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.NF3A4CF95196BBD7102F27A90B7BDABD54B9BF4F42F9C973A9120CA70AED5C267;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ AnimationTransitionDefinition ], Count = {Count}")]
	internal sealed class GeneratedVector_8032df8c909c10ebb13fbca6d18062dc_Lazy<TInputBuffer> : IList<AnimationTransitionDefinition>, ICollection<AnimationTransitionDefinition>, IEnumerable<AnimationTransitionDefinition>, IEnumerable, IReadOnlyList<AnimationTransitionDefinition>, IReadOnlyCollection<AnimationTransitionDefinition>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public AnimationTransitionDefinition this[int index]
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

		public GeneratedVector_8032df8c909c10ebb13fbca6d18062dc_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NE45C68FE420A1FC00D9860CDCA64CC850967C67FB72ECD5608223354D5C85C4B.Helpers.tableReader_46ac6e04748a434fa157e592ff6fec68_Lazy<TInputBuffer> SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NE45C68FE420A1FC00D9860CDCA64CC850967C67FB72ECD5608223354D5C85C4B.Helpers.tableReader_46ac6e04748a434fa157e592ff6fec68_Lazy<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return FlatSharp.Compiler.Generated.NE45C68FE420A1FC00D9860CDCA64CC850967C67FB72ECD5608223354D5C85C4B.Helpers.Parse_Lazy(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, AnimationTransitionDefinition value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(AnimationTransitionDefinition? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(AnimationTransitionDefinition? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(AnimationTransitionDefinition[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<AnimationTransitionDefinition> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(AnimationTransitionDefinition item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, AnimationTransitionDefinition item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(AnimationTransitionDefinition item)
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

	[DebuggerDisplay("Progressive [ AnimationTransitionDefinition ], Count = {Count}")]
	internal sealed class GeneratedVector_8032df8c909c10ebb13fbca6d18062dc_Progressive<TInputBuffer> : IList<AnimationTransitionDefinition>, ICollection<AnimationTransitionDefinition>, IEnumerable<AnimationTransitionDefinition>, IEnumerable, IReadOnlyList<AnimationTransitionDefinition>, IReadOnlyCollection<AnimationTransitionDefinition>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly FlatSharp.Compiler.Generated.NE45C68FE420A1FC00D9860CDCA64CC850967C67FB72ECD5608223354D5C85C4B.Helpers.tableReader_46ac6e04748a434fa157e592ff6fec68_Progressive<TInputBuffer>?[]?[] items;

		public AnimationTransitionDefinition this[int index]
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

		public GeneratedVector_8032df8c909c10ebb13fbca6d18062dc_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new FlatSharp.Compiler.Generated.NE45C68FE420A1FC00D9860CDCA64CC850967C67FB72ECD5608223354D5C85C4B.Helpers.tableReader_46ac6e04748a434fa157e592ff6fec68_Progressive<TInputBuffer>[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NE45C68FE420A1FC00D9860CDCA64CC850967C67FB72ECD5608223354D5C85C4B.Helpers.tableReader_46ac6e04748a434fa157e592ff6fec68_Progressive<TInputBuffer>?[] GetOrCreateRow(FlatSharp.Compiler.Generated.NE45C68FE420A1FC00D9860CDCA64CC850967C67FB72ECD5608223354D5C85C4B.Helpers.tableReader_46ac6e04748a434fa157e592ff6fec68_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private FlatSharp.Compiler.Generated.NE45C68FE420A1FC00D9860CDCA64CC850967C67FB72ECD5608223354D5C85C4B.Helpers.tableReader_46ac6e04748a434fa157e592ff6fec68_Progressive<TInputBuffer>?[] CreateRow(FlatSharp.Compiler.Generated.NE45C68FE420A1FC00D9860CDCA64CC850967C67FB72ECD5608223354D5C85C4B.Helpers.tableReader_46ac6e04748a434fa157e592ff6fec68_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] = new FlatSharp.Compiler.Generated.NE45C68FE420A1FC00D9860CDCA64CC850967C67FB72ECD5608223354D5C85C4B.Helpers.tableReader_46ac6e04748a434fa157e592ff6fec68_Progressive<TInputBuffer>[32];
		}

		private FlatSharp.Compiler.Generated.NE45C68FE420A1FC00D9860CDCA64CC850967C67FB72ECD5608223354D5C85C4B.Helpers.tableReader_46ac6e04748a434fa157e592ff6fec68_Progressive<TInputBuffer> ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			FlatSharp.Compiler.Generated.NE45C68FE420A1FC00D9860CDCA64CC850967C67FB72ECD5608223354D5C85C4B.Helpers.tableReader_46ac6e04748a434fa157e592ff6fec68_Progressive<TInputBuffer>[][] array = items;
			FlatSharp.Compiler.Generated.NE45C68FE420A1FC00D9860CDCA64CC850967C67FB72ECD5608223354D5C85C4B.Helpers.tableReader_46ac6e04748a434fa157e592ff6fec68_Progressive<TInputBuffer>[] orCreateRow = GetOrCreateRow(array, rowIndex);
			FlatSharp.Compiler.Generated.NE45C68FE420A1FC00D9860CDCA64CC850967C67FB72ECD5608223354D5C85C4B.Helpers.tableReader_46ac6e04748a434fa157e592ff6fec68_Progressive<TInputBuffer> tableReader_46ac6e04748a434fa157e592ff6fec68_Progressive = orCreateRow[colIndex];
			if (tableReader_46ac6e04748a434fa157e592ff6fec68_Progressive == null)
			{
				tableReader_46ac6e04748a434fa157e592ff6fec68_Progressive = (orCreateRow[colIndex] = UnsafeParseItem(index));
			}
			return tableReader_46ac6e04748a434fa157e592ff6fec68_Progressive;
		}

		private void ProgressiveSet(int index, AnimationTransitionDefinition value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, AnimationTransitionDefinition value)
		{
			VectorUtilities.CheckIndex(index, count);
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NE45C68FE420A1FC00D9860CDCA64CC850967C67FB72ECD5608223354D5C85C4B.Helpers.tableReader_46ac6e04748a434fa157e592ff6fec68_Progressive<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NE45C68FE420A1FC00D9860CDCA64CC850967C67FB72ECD5608223354D5C85C4B.Helpers.tableReader_46ac6e04748a434fa157e592ff6fec68_Progressive<TInputBuffer> UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.NE45C68FE420A1FC00D9860CDCA64CC850967C67FB72ECD5608223354D5C85C4B.Helpers.Parse_Progressive(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, AnimationTransitionDefinition value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(AnimationTransitionDefinition? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(AnimationTransitionDefinition? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(AnimationTransitionDefinition[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<AnimationTransitionDefinition> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(AnimationTransitionDefinition item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, AnimationTransitionDefinition item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(AnimationTransitionDefinition item)
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

	[DebuggerDisplay("Greedy [ AnimationTransitionDefinition ], Count = {Count}")]
	internal sealed class GeneratedVector_8032df8c909c10ebb13fbca6d18062dc_Greedy<TInputBuffer> : IList<AnimationTransitionDefinition>, ICollection<AnimationTransitionDefinition>, IEnumerable<AnimationTransitionDefinition>, IEnumerable, IReadOnlyList<AnimationTransitionDefinition>, IReadOnlyCollection<AnimationTransitionDefinition> where TInputBuffer : IInputBuffer
	{
		private readonly List<FlatSharp.Compiler.Generated.NE45C68FE420A1FC00D9860CDCA64CC850967C67FB72ECD5608223354D5C85C4B.Helpers.tableReader_46ac6e04748a434fa157e592ff6fec68_Greedy<TInputBuffer>> list;

		public AnimationTransitionDefinition this[int index]
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

		public GeneratedVector_8032df8c909c10ebb13fbca6d18062dc_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<FlatSharp.Compiler.Generated.NE45C68FE420A1FC00D9860CDCA64CC850967C67FB72ECD5608223354D5C85C4B.Helpers.tableReader_46ac6e04748a434fa157e592ff6fec68_Greedy<TInputBuffer>> list = (this.list = new List<FlatSharp.Compiler.Generated.NE45C68FE420A1FC00D9860CDCA64CC850967C67FB72ECD5608223354D5C85C4B.Helpers.tableReader_46ac6e04748a434fa157e592ff6fec68_Greedy<TInputBuffer>>(num));
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.NE45C68FE420A1FC00D9860CDCA64CC850967C67FB72ECD5608223354D5C85C4B.Helpers.tableReader_46ac6e04748a434fa157e592ff6fec68_Greedy<TInputBuffer> item = FlatSharp.Compiler.Generated.NE45C68FE420A1FC00D9860CDCA64CC850967C67FB72ECD5608223354D5C85C4B.Helpers.Parse_Greedy(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		private FlatSharp.Compiler.Generated.NE45C68FE420A1FC00D9860CDCA64CC850967C67FB72ECD5608223354D5C85C4B.Helpers.tableReader_46ac6e04748a434fa157e592ff6fec68_Greedy<TInputBuffer> GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, AnimationTransitionDefinition value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(AnimationTransitionDefinition? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(AnimationTransitionDefinition? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(AnimationTransitionDefinition[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<AnimationTransitionDefinition> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(AnimationTransitionDefinition item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, AnimationTransitionDefinition item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(AnimationTransitionDefinition item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ AnimationTransitionDefinition ], Count = {Count}")]
	internal sealed class GeneratedVector_8032df8c909c10ebb13fbca6d18062dc_GreedyMutable<TInputBuffer> : IList<AnimationTransitionDefinition>, ICollection<AnimationTransitionDefinition>, IEnumerable<AnimationTransitionDefinition>, IEnumerable, IReadOnlyList<AnimationTransitionDefinition>, IReadOnlyCollection<AnimationTransitionDefinition> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<AnimationTransitionDefinition> list;

		public AnimationTransitionDefinition this[int index]
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

		public GeneratedVector_8032df8c909c10ebb13fbca6d18062dc_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<AnimationTransitionDefinition> list = (this.list = new List<AnimationTransitionDefinition>());
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.NE45C68FE420A1FC00D9860CDCA64CC850967C67FB72ECD5608223354D5C85C4B.Helpers.tableReader_46ac6e04748a434fa157e592ff6fec68_GreedyMutable<TInputBuffer> item = FlatSharp.Compiler.Generated.NE45C68FE420A1FC00D9860CDCA64CC850967C67FB72ECD5608223354D5C85C4B.Helpers.Parse_GreedyMutable(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private AnimationTransitionDefinition GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, AnimationTransitionDefinition value)
		{
			list[index] = value;
		}

		public void Add(AnimationTransitionDefinition item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, AnimationTransitionDefinition item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(AnimationTransitionDefinition item)
		{
			return list.Remove(item);
		}

		public bool Contains(AnimationTransitionDefinition? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(AnimationTransitionDefinition? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(AnimationTransitionDefinition[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<AnimationTransitionDefinition> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<AnimationTransitionDefinition> value)
	{
		int count = value.Count;
		int num = 14;
		if (value is AnimationTransitionDefinition[] array)
		{
			foreach (AnimationTransitionDefinition animationTransitionDefinition in array)
			{
				SerializationHelpers.EnsureNonNull(animationTransitionDefinition);
				num += FlatSharp.Compiler.Generated.NE45C68FE420A1FC00D9860CDCA64CC850967C67FB72ECD5608223354D5C85C4B.Helpers.GetMaxSize(animationTransitionDefinition);
			}
		}
		else if (value is List<AnimationTransitionDefinition> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				AnimationTransitionDefinition animationTransitionDefinition2 = list[j];
				SerializationHelpers.EnsureNonNull(animationTransitionDefinition2);
				num += FlatSharp.Compiler.Generated.NE45C68FE420A1FC00D9860CDCA64CC850967C67FB72ECD5608223354D5C85C4B.Helpers.GetMaxSize(animationTransitionDefinition2);
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				AnimationTransitionDefinition animationTransitionDefinition3 = value[k];
				SerializationHelpers.EnsureNonNull(animationTransitionDefinition3);
				num += FlatSharp.Compiler.Generated.NE45C68FE420A1FC00D9860CDCA64CC850967C67FB72ECD5608223354D5C85C4B.Helpers.GetMaxSize(animationTransitionDefinition3);
			}
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<AnimationTransitionDefinition> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 4);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is AnimationTransitionDefinition[] array)
		{
			foreach (AnimationTransitionDefinition animationTransitionDefinition in array)
			{
				SerializationHelpers.EnsureNonNull(animationTransitionDefinition);
				FlatSharp.Compiler.Generated.NE45C68FE420A1FC00D9860CDCA64CC850967C67FB72ECD5608223354D5C85C4B.Helpers.Serialize(spanWriter, span, animationTransitionDefinition, num, context);
				num += 4;
			}
		}
		else if (value is List<AnimationTransitionDefinition> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				AnimationTransitionDefinition animationTransitionDefinition2 = list[j];
				SerializationHelpers.EnsureNonNull(animationTransitionDefinition2);
				FlatSharp.Compiler.Generated.NE45C68FE420A1FC00D9860CDCA64CC850967C67FB72ECD5608223354D5C85C4B.Helpers.Serialize(spanWriter, span, animationTransitionDefinition2, num, context);
				num += 4;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				AnimationTransitionDefinition animationTransitionDefinition3 = value[k];
				SerializationHelpers.EnsureNonNull(animationTransitionDefinition3);
				FlatSharp.Compiler.Generated.NE45C68FE420A1FC00D9860CDCA64CC850967C67FB72ECD5608223354D5C85C4B.Helpers.Serialize(spanWriter, span, animationTransitionDefinition3, num, context);
				num += 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<AnimationTransitionDefinition> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_8032df8c909c10ebb13fbca6d18062dc_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<AnimationTransitionDefinition> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_8032df8c909c10ebb13fbca6d18062dc_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<AnimationTransitionDefinition> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_8032df8c909c10ebb13fbca6d18062dc_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<AnimationTransitionDefinition> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_8032df8c909c10ebb13fbca6d18062dc_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
