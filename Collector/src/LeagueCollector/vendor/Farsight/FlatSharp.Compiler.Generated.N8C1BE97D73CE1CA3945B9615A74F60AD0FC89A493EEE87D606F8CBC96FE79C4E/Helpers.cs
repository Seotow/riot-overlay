using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Snapshot;
using FlatSharp.Compiler.Generated.N85F85F7C01F4E3DD8E0A3F502A9A36FDD9D84073796F04EDDBADC6D80CEB7CDD;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N8C1BE97D73CE1CA3945B9615A74F60AD0FC89A493EEE87D606F8CBC96FE79C4E;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ AnimationPoseNode ], Count = {Count}")]
	internal sealed class GeneratedVector_d1264c70d31f38462d4e8a5a729cdb88_Lazy<TInputBuffer> : IList<AnimationPoseNode>, ICollection<AnimationPoseNode>, IEnumerable<AnimationPoseNode>, IEnumerable, IReadOnlyList<AnimationPoseNode>, IReadOnlyCollection<AnimationPoseNode>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public AnimationPoseNode this[int index]
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

		public GeneratedVector_d1264c70d31f38462d4e8a5a729cdb88_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N85F85F7C01F4E3DD8E0A3F502A9A36FDD9D84073796F04EDDBADC6D80CEB7CDD.Helpers.tableReader_9cc585a028b04798a1ca579fe85d5f13_Lazy<TInputBuffer> SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N85F85F7C01F4E3DD8E0A3F502A9A36FDD9D84073796F04EDDBADC6D80CEB7CDD.Helpers.tableReader_9cc585a028b04798a1ca579fe85d5f13_Lazy<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return FlatSharp.Compiler.Generated.N85F85F7C01F4E3DD8E0A3F502A9A36FDD9D84073796F04EDDBADC6D80CEB7CDD.Helpers.Parse_Lazy(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, AnimationPoseNode value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(AnimationPoseNode? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(AnimationPoseNode? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(AnimationPoseNode[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<AnimationPoseNode> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(AnimationPoseNode item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, AnimationPoseNode item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(AnimationPoseNode item)
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

	[DebuggerDisplay("Progressive [ AnimationPoseNode ], Count = {Count}")]
	internal sealed class GeneratedVector_d1264c70d31f38462d4e8a5a729cdb88_Progressive<TInputBuffer> : IList<AnimationPoseNode>, ICollection<AnimationPoseNode>, IEnumerable<AnimationPoseNode>, IEnumerable, IReadOnlyList<AnimationPoseNode>, IReadOnlyCollection<AnimationPoseNode>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly FlatSharp.Compiler.Generated.N85F85F7C01F4E3DD8E0A3F502A9A36FDD9D84073796F04EDDBADC6D80CEB7CDD.Helpers.tableReader_9cc585a028b04798a1ca579fe85d5f13_Progressive<TInputBuffer>?[]?[] items;

		public AnimationPoseNode this[int index]
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

		public GeneratedVector_d1264c70d31f38462d4e8a5a729cdb88_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new FlatSharp.Compiler.Generated.N85F85F7C01F4E3DD8E0A3F502A9A36FDD9D84073796F04EDDBADC6D80CEB7CDD.Helpers.tableReader_9cc585a028b04798a1ca579fe85d5f13_Progressive<TInputBuffer>[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N85F85F7C01F4E3DD8E0A3F502A9A36FDD9D84073796F04EDDBADC6D80CEB7CDD.Helpers.tableReader_9cc585a028b04798a1ca579fe85d5f13_Progressive<TInputBuffer>?[] GetOrCreateRow(FlatSharp.Compiler.Generated.N85F85F7C01F4E3DD8E0A3F502A9A36FDD9D84073796F04EDDBADC6D80CEB7CDD.Helpers.tableReader_9cc585a028b04798a1ca579fe85d5f13_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private FlatSharp.Compiler.Generated.N85F85F7C01F4E3DD8E0A3F502A9A36FDD9D84073796F04EDDBADC6D80CEB7CDD.Helpers.tableReader_9cc585a028b04798a1ca579fe85d5f13_Progressive<TInputBuffer>?[] CreateRow(FlatSharp.Compiler.Generated.N85F85F7C01F4E3DD8E0A3F502A9A36FDD9D84073796F04EDDBADC6D80CEB7CDD.Helpers.tableReader_9cc585a028b04798a1ca579fe85d5f13_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] = new FlatSharp.Compiler.Generated.N85F85F7C01F4E3DD8E0A3F502A9A36FDD9D84073796F04EDDBADC6D80CEB7CDD.Helpers.tableReader_9cc585a028b04798a1ca579fe85d5f13_Progressive<TInputBuffer>[32];
		}

		private FlatSharp.Compiler.Generated.N85F85F7C01F4E3DD8E0A3F502A9A36FDD9D84073796F04EDDBADC6D80CEB7CDD.Helpers.tableReader_9cc585a028b04798a1ca579fe85d5f13_Progressive<TInputBuffer> ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			FlatSharp.Compiler.Generated.N85F85F7C01F4E3DD8E0A3F502A9A36FDD9D84073796F04EDDBADC6D80CEB7CDD.Helpers.tableReader_9cc585a028b04798a1ca579fe85d5f13_Progressive<TInputBuffer>[][] array = items;
			FlatSharp.Compiler.Generated.N85F85F7C01F4E3DD8E0A3F502A9A36FDD9D84073796F04EDDBADC6D80CEB7CDD.Helpers.tableReader_9cc585a028b04798a1ca579fe85d5f13_Progressive<TInputBuffer>[] orCreateRow = GetOrCreateRow(array, rowIndex);
			FlatSharp.Compiler.Generated.N85F85F7C01F4E3DD8E0A3F502A9A36FDD9D84073796F04EDDBADC6D80CEB7CDD.Helpers.tableReader_9cc585a028b04798a1ca579fe85d5f13_Progressive<TInputBuffer> tableReader_9cc585a028b04798a1ca579fe85d5f13_Progressive = orCreateRow[colIndex];
			if (tableReader_9cc585a028b04798a1ca579fe85d5f13_Progressive == null)
			{
				tableReader_9cc585a028b04798a1ca579fe85d5f13_Progressive = (orCreateRow[colIndex] = UnsafeParseItem(index));
			}
			return tableReader_9cc585a028b04798a1ca579fe85d5f13_Progressive;
		}

		private void ProgressiveSet(int index, AnimationPoseNode value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, AnimationPoseNode value)
		{
			VectorUtilities.CheckIndex(index, count);
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N85F85F7C01F4E3DD8E0A3F502A9A36FDD9D84073796F04EDDBADC6D80CEB7CDD.Helpers.tableReader_9cc585a028b04798a1ca579fe85d5f13_Progressive<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N85F85F7C01F4E3DD8E0A3F502A9A36FDD9D84073796F04EDDBADC6D80CEB7CDD.Helpers.tableReader_9cc585a028b04798a1ca579fe85d5f13_Progressive<TInputBuffer> UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.N85F85F7C01F4E3DD8E0A3F502A9A36FDD9D84073796F04EDDBADC6D80CEB7CDD.Helpers.Parse_Progressive(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, AnimationPoseNode value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(AnimationPoseNode? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(AnimationPoseNode? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(AnimationPoseNode[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<AnimationPoseNode> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(AnimationPoseNode item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, AnimationPoseNode item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(AnimationPoseNode item)
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

	[DebuggerDisplay("Greedy [ AnimationPoseNode ], Count = {Count}")]
	internal sealed class GeneratedVector_d1264c70d31f38462d4e8a5a729cdb88_Greedy<TInputBuffer> : IList<AnimationPoseNode>, ICollection<AnimationPoseNode>, IEnumerable<AnimationPoseNode>, IEnumerable, IReadOnlyList<AnimationPoseNode>, IReadOnlyCollection<AnimationPoseNode> where TInputBuffer : IInputBuffer
	{
		private readonly List<FlatSharp.Compiler.Generated.N85F85F7C01F4E3DD8E0A3F502A9A36FDD9D84073796F04EDDBADC6D80CEB7CDD.Helpers.tableReader_9cc585a028b04798a1ca579fe85d5f13_Greedy<TInputBuffer>> list;

		public AnimationPoseNode this[int index]
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

		public GeneratedVector_d1264c70d31f38462d4e8a5a729cdb88_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<FlatSharp.Compiler.Generated.N85F85F7C01F4E3DD8E0A3F502A9A36FDD9D84073796F04EDDBADC6D80CEB7CDD.Helpers.tableReader_9cc585a028b04798a1ca579fe85d5f13_Greedy<TInputBuffer>> list = (this.list = new List<FlatSharp.Compiler.Generated.N85F85F7C01F4E3DD8E0A3F502A9A36FDD9D84073796F04EDDBADC6D80CEB7CDD.Helpers.tableReader_9cc585a028b04798a1ca579fe85d5f13_Greedy<TInputBuffer>>(num));
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.N85F85F7C01F4E3DD8E0A3F502A9A36FDD9D84073796F04EDDBADC6D80CEB7CDD.Helpers.tableReader_9cc585a028b04798a1ca579fe85d5f13_Greedy<TInputBuffer> item = FlatSharp.Compiler.Generated.N85F85F7C01F4E3DD8E0A3F502A9A36FDD9D84073796F04EDDBADC6D80CEB7CDD.Helpers.Parse_Greedy(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		private FlatSharp.Compiler.Generated.N85F85F7C01F4E3DD8E0A3F502A9A36FDD9D84073796F04EDDBADC6D80CEB7CDD.Helpers.tableReader_9cc585a028b04798a1ca579fe85d5f13_Greedy<TInputBuffer> GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, AnimationPoseNode value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(AnimationPoseNode? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(AnimationPoseNode? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(AnimationPoseNode[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<AnimationPoseNode> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(AnimationPoseNode item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, AnimationPoseNode item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(AnimationPoseNode item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ AnimationPoseNode ], Count = {Count}")]
	internal sealed class GeneratedVector_d1264c70d31f38462d4e8a5a729cdb88_GreedyMutable<TInputBuffer> : IList<AnimationPoseNode>, ICollection<AnimationPoseNode>, IEnumerable<AnimationPoseNode>, IEnumerable, IReadOnlyList<AnimationPoseNode>, IReadOnlyCollection<AnimationPoseNode> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<AnimationPoseNode> list;

		public AnimationPoseNode this[int index]
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

		public GeneratedVector_d1264c70d31f38462d4e8a5a729cdb88_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<AnimationPoseNode> list = (this.list = new List<AnimationPoseNode>());
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.N85F85F7C01F4E3DD8E0A3F502A9A36FDD9D84073796F04EDDBADC6D80CEB7CDD.Helpers.tableReader_9cc585a028b04798a1ca579fe85d5f13_GreedyMutable<TInputBuffer> item = FlatSharp.Compiler.Generated.N85F85F7C01F4E3DD8E0A3F502A9A36FDD9D84073796F04EDDBADC6D80CEB7CDD.Helpers.Parse_GreedyMutable(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private AnimationPoseNode GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, AnimationPoseNode value)
		{
			list[index] = value;
		}

		public void Add(AnimationPoseNode item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, AnimationPoseNode item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(AnimationPoseNode item)
		{
			return list.Remove(item);
		}

		public bool Contains(AnimationPoseNode? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(AnimationPoseNode? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(AnimationPoseNode[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<AnimationPoseNode> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<AnimationPoseNode> value)
	{
		int count = value.Count;
		int num = 14;
		if (value is AnimationPoseNode[] array)
		{
			foreach (AnimationPoseNode animationPoseNode in array)
			{
				SerializationHelpers.EnsureNonNull(animationPoseNode);
				num += FlatSharp.Compiler.Generated.N85F85F7C01F4E3DD8E0A3F502A9A36FDD9D84073796F04EDDBADC6D80CEB7CDD.Helpers.GetMaxSize(animationPoseNode);
			}
		}
		else if (value is List<AnimationPoseNode> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				AnimationPoseNode animationPoseNode2 = list[j];
				SerializationHelpers.EnsureNonNull(animationPoseNode2);
				num += FlatSharp.Compiler.Generated.N85F85F7C01F4E3DD8E0A3F502A9A36FDD9D84073796F04EDDBADC6D80CEB7CDD.Helpers.GetMaxSize(animationPoseNode2);
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				AnimationPoseNode animationPoseNode3 = value[k];
				SerializationHelpers.EnsureNonNull(animationPoseNode3);
				num += FlatSharp.Compiler.Generated.N85F85F7C01F4E3DD8E0A3F502A9A36FDD9D84073796F04EDDBADC6D80CEB7CDD.Helpers.GetMaxSize(animationPoseNode3);
			}
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<AnimationPoseNode> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 4);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is AnimationPoseNode[] array)
		{
			foreach (AnimationPoseNode animationPoseNode in array)
			{
				SerializationHelpers.EnsureNonNull(animationPoseNode);
				FlatSharp.Compiler.Generated.N85F85F7C01F4E3DD8E0A3F502A9A36FDD9D84073796F04EDDBADC6D80CEB7CDD.Helpers.Serialize(spanWriter, span, animationPoseNode, num, context);
				num += 4;
			}
		}
		else if (value is List<AnimationPoseNode> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				AnimationPoseNode animationPoseNode2 = list[j];
				SerializationHelpers.EnsureNonNull(animationPoseNode2);
				FlatSharp.Compiler.Generated.N85F85F7C01F4E3DD8E0A3F502A9A36FDD9D84073796F04EDDBADC6D80CEB7CDD.Helpers.Serialize(spanWriter, span, animationPoseNode2, num, context);
				num += 4;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				AnimationPoseNode animationPoseNode3 = value[k];
				SerializationHelpers.EnsureNonNull(animationPoseNode3);
				FlatSharp.Compiler.Generated.N85F85F7C01F4E3DD8E0A3F502A9A36FDD9D84073796F04EDDBADC6D80CEB7CDD.Helpers.Serialize(spanWriter, span, animationPoseNode3, num, context);
				num += 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<AnimationPoseNode> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_d1264c70d31f38462d4e8a5a729cdb88_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<AnimationPoseNode> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_d1264c70d31f38462d4e8a5a729cdb88_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<AnimationPoseNode> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_d1264c70d31f38462d4e8a5a729cdb88_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<AnimationPoseNode> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_d1264c70d31f38462d4e8a5a729cdb88_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
