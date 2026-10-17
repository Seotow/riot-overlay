using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Snapshot;
using FlatSharp.Compiler.Generated.N9E658D68BF669D4FF3F403B315B76842C286AD4CEC242D18CD69FFC8E4A7C19A;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N2C5A74543636834075C28C79EBCA1FCC66471B13296945F1E2F12F229B73A2B5;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ AITurretClient ], Count = {Count}")]
	internal sealed class GeneratedVector_c1d188c486d8c637bbff184b382f588f_Lazy<TInputBuffer> : IList<AITurretClient>, ICollection<AITurretClient>, IEnumerable<AITurretClient>, IEnumerable, IReadOnlyList<AITurretClient>, IReadOnlyCollection<AITurretClient>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public AITurretClient this[int index]
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

		public GeneratedVector_c1d188c486d8c637bbff184b382f588f_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N9E658D68BF669D4FF3F403B315B76842C286AD4CEC242D18CD69FFC8E4A7C19A.Helpers.tableReader_cf68f355d6844fa981032c3111f4eeed_Lazy<TInputBuffer> SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N9E658D68BF669D4FF3F403B315B76842C286AD4CEC242D18CD69FFC8E4A7C19A.Helpers.tableReader_cf68f355d6844fa981032c3111f4eeed_Lazy<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return FlatSharp.Compiler.Generated.N9E658D68BF669D4FF3F403B315B76842C286AD4CEC242D18CD69FFC8E4A7C19A.Helpers.Parse_Lazy(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, AITurretClient value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(AITurretClient? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(AITurretClient? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(AITurretClient[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<AITurretClient> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(AITurretClient item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, AITurretClient item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(AITurretClient item)
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

	[DebuggerDisplay("Progressive [ AITurretClient ], Count = {Count}")]
	internal sealed class GeneratedVector_c1d188c486d8c637bbff184b382f588f_Progressive<TInputBuffer> : IList<AITurretClient>, ICollection<AITurretClient>, IEnumerable<AITurretClient>, IEnumerable, IReadOnlyList<AITurretClient>, IReadOnlyCollection<AITurretClient>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly FlatSharp.Compiler.Generated.N9E658D68BF669D4FF3F403B315B76842C286AD4CEC242D18CD69FFC8E4A7C19A.Helpers.tableReader_cf68f355d6844fa981032c3111f4eeed_Progressive<TInputBuffer>?[]?[] items;

		public AITurretClient this[int index]
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

		public GeneratedVector_c1d188c486d8c637bbff184b382f588f_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new FlatSharp.Compiler.Generated.N9E658D68BF669D4FF3F403B315B76842C286AD4CEC242D18CD69FFC8E4A7C19A.Helpers.tableReader_cf68f355d6844fa981032c3111f4eeed_Progressive<TInputBuffer>[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N9E658D68BF669D4FF3F403B315B76842C286AD4CEC242D18CD69FFC8E4A7C19A.Helpers.tableReader_cf68f355d6844fa981032c3111f4eeed_Progressive<TInputBuffer>?[] GetOrCreateRow(FlatSharp.Compiler.Generated.N9E658D68BF669D4FF3F403B315B76842C286AD4CEC242D18CD69FFC8E4A7C19A.Helpers.tableReader_cf68f355d6844fa981032c3111f4eeed_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private FlatSharp.Compiler.Generated.N9E658D68BF669D4FF3F403B315B76842C286AD4CEC242D18CD69FFC8E4A7C19A.Helpers.tableReader_cf68f355d6844fa981032c3111f4eeed_Progressive<TInputBuffer>?[] CreateRow(FlatSharp.Compiler.Generated.N9E658D68BF669D4FF3F403B315B76842C286AD4CEC242D18CD69FFC8E4A7C19A.Helpers.tableReader_cf68f355d6844fa981032c3111f4eeed_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] = new FlatSharp.Compiler.Generated.N9E658D68BF669D4FF3F403B315B76842C286AD4CEC242D18CD69FFC8E4A7C19A.Helpers.tableReader_cf68f355d6844fa981032c3111f4eeed_Progressive<TInputBuffer>[32];
		}

		private FlatSharp.Compiler.Generated.N9E658D68BF669D4FF3F403B315B76842C286AD4CEC242D18CD69FFC8E4A7C19A.Helpers.tableReader_cf68f355d6844fa981032c3111f4eeed_Progressive<TInputBuffer> ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			FlatSharp.Compiler.Generated.N9E658D68BF669D4FF3F403B315B76842C286AD4CEC242D18CD69FFC8E4A7C19A.Helpers.tableReader_cf68f355d6844fa981032c3111f4eeed_Progressive<TInputBuffer>[][] array = items;
			FlatSharp.Compiler.Generated.N9E658D68BF669D4FF3F403B315B76842C286AD4CEC242D18CD69FFC8E4A7C19A.Helpers.tableReader_cf68f355d6844fa981032c3111f4eeed_Progressive<TInputBuffer>[] orCreateRow = GetOrCreateRow(array, rowIndex);
			FlatSharp.Compiler.Generated.N9E658D68BF669D4FF3F403B315B76842C286AD4CEC242D18CD69FFC8E4A7C19A.Helpers.tableReader_cf68f355d6844fa981032c3111f4eeed_Progressive<TInputBuffer> tableReader_cf68f355d6844fa981032c3111f4eeed_Progressive = orCreateRow[colIndex];
			if (tableReader_cf68f355d6844fa981032c3111f4eeed_Progressive == null)
			{
				tableReader_cf68f355d6844fa981032c3111f4eeed_Progressive = (orCreateRow[colIndex] = UnsafeParseItem(index));
			}
			return tableReader_cf68f355d6844fa981032c3111f4eeed_Progressive;
		}

		private void ProgressiveSet(int index, AITurretClient value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, AITurretClient value)
		{
			VectorUtilities.CheckIndex(index, count);
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N9E658D68BF669D4FF3F403B315B76842C286AD4CEC242D18CD69FFC8E4A7C19A.Helpers.tableReader_cf68f355d6844fa981032c3111f4eeed_Progressive<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N9E658D68BF669D4FF3F403B315B76842C286AD4CEC242D18CD69FFC8E4A7C19A.Helpers.tableReader_cf68f355d6844fa981032c3111f4eeed_Progressive<TInputBuffer> UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.N9E658D68BF669D4FF3F403B315B76842C286AD4CEC242D18CD69FFC8E4A7C19A.Helpers.Parse_Progressive(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, AITurretClient value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(AITurretClient? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(AITurretClient? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(AITurretClient[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<AITurretClient> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(AITurretClient item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, AITurretClient item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(AITurretClient item)
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

	[DebuggerDisplay("Greedy [ AITurretClient ], Count = {Count}")]
	internal sealed class GeneratedVector_c1d188c486d8c637bbff184b382f588f_Greedy<TInputBuffer> : IList<AITurretClient>, ICollection<AITurretClient>, IEnumerable<AITurretClient>, IEnumerable, IReadOnlyList<AITurretClient>, IReadOnlyCollection<AITurretClient> where TInputBuffer : IInputBuffer
	{
		private readonly List<FlatSharp.Compiler.Generated.N9E658D68BF669D4FF3F403B315B76842C286AD4CEC242D18CD69FFC8E4A7C19A.Helpers.tableReader_cf68f355d6844fa981032c3111f4eeed_Greedy<TInputBuffer>> list;

		public AITurretClient this[int index]
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

		public GeneratedVector_c1d188c486d8c637bbff184b382f588f_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<FlatSharp.Compiler.Generated.N9E658D68BF669D4FF3F403B315B76842C286AD4CEC242D18CD69FFC8E4A7C19A.Helpers.tableReader_cf68f355d6844fa981032c3111f4eeed_Greedy<TInputBuffer>> list = (this.list = new List<FlatSharp.Compiler.Generated.N9E658D68BF669D4FF3F403B315B76842C286AD4CEC242D18CD69FFC8E4A7C19A.Helpers.tableReader_cf68f355d6844fa981032c3111f4eeed_Greedy<TInputBuffer>>(num));
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.N9E658D68BF669D4FF3F403B315B76842C286AD4CEC242D18CD69FFC8E4A7C19A.Helpers.tableReader_cf68f355d6844fa981032c3111f4eeed_Greedy<TInputBuffer> item = FlatSharp.Compiler.Generated.N9E658D68BF669D4FF3F403B315B76842C286AD4CEC242D18CD69FFC8E4A7C19A.Helpers.Parse_Greedy(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		private FlatSharp.Compiler.Generated.N9E658D68BF669D4FF3F403B315B76842C286AD4CEC242D18CD69FFC8E4A7C19A.Helpers.tableReader_cf68f355d6844fa981032c3111f4eeed_Greedy<TInputBuffer> GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, AITurretClient value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(AITurretClient? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(AITurretClient? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(AITurretClient[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<AITurretClient> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(AITurretClient item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, AITurretClient item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(AITurretClient item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ AITurretClient ], Count = {Count}")]
	internal sealed class GeneratedVector_c1d188c486d8c637bbff184b382f588f_GreedyMutable<TInputBuffer> : IList<AITurretClient>, ICollection<AITurretClient>, IEnumerable<AITurretClient>, IEnumerable, IReadOnlyList<AITurretClient>, IReadOnlyCollection<AITurretClient> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<AITurretClient> list;

		public AITurretClient this[int index]
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

		public GeneratedVector_c1d188c486d8c637bbff184b382f588f_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<AITurretClient> list = (this.list = new List<AITurretClient>());
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.N9E658D68BF669D4FF3F403B315B76842C286AD4CEC242D18CD69FFC8E4A7C19A.Helpers.tableReader_cf68f355d6844fa981032c3111f4eeed_GreedyMutable<TInputBuffer> item = FlatSharp.Compiler.Generated.N9E658D68BF669D4FF3F403B315B76842C286AD4CEC242D18CD69FFC8E4A7C19A.Helpers.Parse_GreedyMutable(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private AITurretClient GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, AITurretClient value)
		{
			list[index] = value;
		}

		public void Add(AITurretClient item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, AITurretClient item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(AITurretClient item)
		{
			return list.Remove(item);
		}

		public bool Contains(AITurretClient? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(AITurretClient? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(AITurretClient[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<AITurretClient> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<AITurretClient> value)
	{
		int count = value.Count;
		int num = 14;
		if (value is AITurretClient[] array)
		{
			foreach (AITurretClient aITurretClient in array)
			{
				SerializationHelpers.EnsureNonNull(aITurretClient);
				num += FlatSharp.Compiler.Generated.N9E658D68BF669D4FF3F403B315B76842C286AD4CEC242D18CD69FFC8E4A7C19A.Helpers.GetMaxSize(aITurretClient);
			}
		}
		else if (value is List<AITurretClient> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				AITurretClient aITurretClient2 = list[j];
				SerializationHelpers.EnsureNonNull(aITurretClient2);
				num += FlatSharp.Compiler.Generated.N9E658D68BF669D4FF3F403B315B76842C286AD4CEC242D18CD69FFC8E4A7C19A.Helpers.GetMaxSize(aITurretClient2);
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				AITurretClient aITurretClient3 = value[k];
				SerializationHelpers.EnsureNonNull(aITurretClient3);
				num += FlatSharp.Compiler.Generated.N9E658D68BF669D4FF3F403B315B76842C286AD4CEC242D18CD69FFC8E4A7C19A.Helpers.GetMaxSize(aITurretClient3);
			}
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<AITurretClient> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 4);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is AITurretClient[] array)
		{
			foreach (AITurretClient aITurretClient in array)
			{
				SerializationHelpers.EnsureNonNull(aITurretClient);
				FlatSharp.Compiler.Generated.N9E658D68BF669D4FF3F403B315B76842C286AD4CEC242D18CD69FFC8E4A7C19A.Helpers.Serialize(spanWriter, span, aITurretClient, num, context);
				num += 4;
			}
		}
		else if (value is List<AITurretClient> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				AITurretClient aITurretClient2 = list[j];
				SerializationHelpers.EnsureNonNull(aITurretClient2);
				FlatSharp.Compiler.Generated.N9E658D68BF669D4FF3F403B315B76842C286AD4CEC242D18CD69FFC8E4A7C19A.Helpers.Serialize(spanWriter, span, aITurretClient2, num, context);
				num += 4;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				AITurretClient aITurretClient3 = value[k];
				SerializationHelpers.EnsureNonNull(aITurretClient3);
				FlatSharp.Compiler.Generated.N9E658D68BF669D4FF3F403B315B76842C286AD4CEC242D18CD69FFC8E4A7C19A.Helpers.Serialize(spanWriter, span, aITurretClient3, num, context);
				num += 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<AITurretClient> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_c1d188c486d8c637bbff184b382f588f_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<AITurretClient> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_c1d188c486d8c637bbff184b382f588f_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<AITurretClient> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_c1d188c486d8c637bbff184b382f588f_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<AITurretClient> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_c1d188c486d8c637bbff184b382f588f_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
