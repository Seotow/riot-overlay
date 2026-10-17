using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Snapshot;
using FlatSharp.Compiler.Generated.NDED43AC666D1D9750273382C505C400A483C5F3D7FD0677F57493711B1623456;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N691EC907C29AE3492438CAEF32349BADACD2DC821F4C0CDF14AF712B7F70AE9C;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ Missile ], Count = {Count}")]
	internal sealed class GeneratedVector_9603be00d7564d9d9bf2cb0ca26094bb_Lazy<TInputBuffer> : IList<Missile>, ICollection<Missile>, IEnumerable<Missile>, IEnumerable, IReadOnlyList<Missile>, IReadOnlyCollection<Missile>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public Missile this[int index]
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

		public GeneratedVector_9603be00d7564d9d9bf2cb0ca26094bb_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NDED43AC666D1D9750273382C505C400A483C5F3D7FD0677F57493711B1623456.Helpers.tableReader_8ce8c7e456204995a324be909c1411e0_Lazy<TInputBuffer> SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NDED43AC666D1D9750273382C505C400A483C5F3D7FD0677F57493711B1623456.Helpers.tableReader_8ce8c7e456204995a324be909c1411e0_Lazy<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return FlatSharp.Compiler.Generated.NDED43AC666D1D9750273382C505C400A483C5F3D7FD0677F57493711B1623456.Helpers.Parse_Lazy(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, Missile value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(Missile? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(Missile? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(Missile[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<Missile> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(Missile item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, Missile item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(Missile item)
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

	[DebuggerDisplay("Progressive [ Missile ], Count = {Count}")]
	internal sealed class GeneratedVector_9603be00d7564d9d9bf2cb0ca26094bb_Progressive<TInputBuffer> : IList<Missile>, ICollection<Missile>, IEnumerable<Missile>, IEnumerable, IReadOnlyList<Missile>, IReadOnlyCollection<Missile>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly FlatSharp.Compiler.Generated.NDED43AC666D1D9750273382C505C400A483C5F3D7FD0677F57493711B1623456.Helpers.tableReader_8ce8c7e456204995a324be909c1411e0_Progressive<TInputBuffer>?[]?[] items;

		public Missile this[int index]
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

		public GeneratedVector_9603be00d7564d9d9bf2cb0ca26094bb_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new FlatSharp.Compiler.Generated.NDED43AC666D1D9750273382C505C400A483C5F3D7FD0677F57493711B1623456.Helpers.tableReader_8ce8c7e456204995a324be909c1411e0_Progressive<TInputBuffer>[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NDED43AC666D1D9750273382C505C400A483C5F3D7FD0677F57493711B1623456.Helpers.tableReader_8ce8c7e456204995a324be909c1411e0_Progressive<TInputBuffer>?[] GetOrCreateRow(FlatSharp.Compiler.Generated.NDED43AC666D1D9750273382C505C400A483C5F3D7FD0677F57493711B1623456.Helpers.tableReader_8ce8c7e456204995a324be909c1411e0_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private FlatSharp.Compiler.Generated.NDED43AC666D1D9750273382C505C400A483C5F3D7FD0677F57493711B1623456.Helpers.tableReader_8ce8c7e456204995a324be909c1411e0_Progressive<TInputBuffer>?[] CreateRow(FlatSharp.Compiler.Generated.NDED43AC666D1D9750273382C505C400A483C5F3D7FD0677F57493711B1623456.Helpers.tableReader_8ce8c7e456204995a324be909c1411e0_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] = new FlatSharp.Compiler.Generated.NDED43AC666D1D9750273382C505C400A483C5F3D7FD0677F57493711B1623456.Helpers.tableReader_8ce8c7e456204995a324be909c1411e0_Progressive<TInputBuffer>[32];
		}

		private FlatSharp.Compiler.Generated.NDED43AC666D1D9750273382C505C400A483C5F3D7FD0677F57493711B1623456.Helpers.tableReader_8ce8c7e456204995a324be909c1411e0_Progressive<TInputBuffer> ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			FlatSharp.Compiler.Generated.NDED43AC666D1D9750273382C505C400A483C5F3D7FD0677F57493711B1623456.Helpers.tableReader_8ce8c7e456204995a324be909c1411e0_Progressive<TInputBuffer>[][] array = items;
			FlatSharp.Compiler.Generated.NDED43AC666D1D9750273382C505C400A483C5F3D7FD0677F57493711B1623456.Helpers.tableReader_8ce8c7e456204995a324be909c1411e0_Progressive<TInputBuffer>[] orCreateRow = GetOrCreateRow(array, rowIndex);
			FlatSharp.Compiler.Generated.NDED43AC666D1D9750273382C505C400A483C5F3D7FD0677F57493711B1623456.Helpers.tableReader_8ce8c7e456204995a324be909c1411e0_Progressive<TInputBuffer> tableReader_8ce8c7e456204995a324be909c1411e0_Progressive = orCreateRow[colIndex];
			if (tableReader_8ce8c7e456204995a324be909c1411e0_Progressive == null)
			{
				tableReader_8ce8c7e456204995a324be909c1411e0_Progressive = (orCreateRow[colIndex] = UnsafeParseItem(index));
			}
			return tableReader_8ce8c7e456204995a324be909c1411e0_Progressive;
		}

		private void ProgressiveSet(int index, Missile value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, Missile value)
		{
			VectorUtilities.CheckIndex(index, count);
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NDED43AC666D1D9750273382C505C400A483C5F3D7FD0677F57493711B1623456.Helpers.tableReader_8ce8c7e456204995a324be909c1411e0_Progressive<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NDED43AC666D1D9750273382C505C400A483C5F3D7FD0677F57493711B1623456.Helpers.tableReader_8ce8c7e456204995a324be909c1411e0_Progressive<TInputBuffer> UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.NDED43AC666D1D9750273382C505C400A483C5F3D7FD0677F57493711B1623456.Helpers.Parse_Progressive(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, Missile value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(Missile? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(Missile? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(Missile[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<Missile> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(Missile item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, Missile item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(Missile item)
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

	[DebuggerDisplay("Greedy [ Missile ], Count = {Count}")]
	internal sealed class GeneratedVector_9603be00d7564d9d9bf2cb0ca26094bb_Greedy<TInputBuffer> : IList<Missile>, ICollection<Missile>, IEnumerable<Missile>, IEnumerable, IReadOnlyList<Missile>, IReadOnlyCollection<Missile> where TInputBuffer : IInputBuffer
	{
		private readonly List<FlatSharp.Compiler.Generated.NDED43AC666D1D9750273382C505C400A483C5F3D7FD0677F57493711B1623456.Helpers.tableReader_8ce8c7e456204995a324be909c1411e0_Greedy<TInputBuffer>> list;

		public Missile this[int index]
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

		public GeneratedVector_9603be00d7564d9d9bf2cb0ca26094bb_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<FlatSharp.Compiler.Generated.NDED43AC666D1D9750273382C505C400A483C5F3D7FD0677F57493711B1623456.Helpers.tableReader_8ce8c7e456204995a324be909c1411e0_Greedy<TInputBuffer>> list = (this.list = new List<FlatSharp.Compiler.Generated.NDED43AC666D1D9750273382C505C400A483C5F3D7FD0677F57493711B1623456.Helpers.tableReader_8ce8c7e456204995a324be909c1411e0_Greedy<TInputBuffer>>(num));
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.NDED43AC666D1D9750273382C505C400A483C5F3D7FD0677F57493711B1623456.Helpers.tableReader_8ce8c7e456204995a324be909c1411e0_Greedy<TInputBuffer> item = FlatSharp.Compiler.Generated.NDED43AC666D1D9750273382C505C400A483C5F3D7FD0677F57493711B1623456.Helpers.Parse_Greedy(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		private FlatSharp.Compiler.Generated.NDED43AC666D1D9750273382C505C400A483C5F3D7FD0677F57493711B1623456.Helpers.tableReader_8ce8c7e456204995a324be909c1411e0_Greedy<TInputBuffer> GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, Missile value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(Missile? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(Missile? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(Missile[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<Missile> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(Missile item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, Missile item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(Missile item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ Missile ], Count = {Count}")]
	internal sealed class GeneratedVector_9603be00d7564d9d9bf2cb0ca26094bb_GreedyMutable<TInputBuffer> : IList<Missile>, ICollection<Missile>, IEnumerable<Missile>, IEnumerable, IReadOnlyList<Missile>, IReadOnlyCollection<Missile> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<Missile> list;

		public Missile this[int index]
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

		public GeneratedVector_9603be00d7564d9d9bf2cb0ca26094bb_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<Missile> list = (this.list = new List<Missile>());
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.NDED43AC666D1D9750273382C505C400A483C5F3D7FD0677F57493711B1623456.Helpers.tableReader_8ce8c7e456204995a324be909c1411e0_GreedyMutable<TInputBuffer> item = FlatSharp.Compiler.Generated.NDED43AC666D1D9750273382C505C400A483C5F3D7FD0677F57493711B1623456.Helpers.Parse_GreedyMutable(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private Missile GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, Missile value)
		{
			list[index] = value;
		}

		public void Add(Missile item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, Missile item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(Missile item)
		{
			return list.Remove(item);
		}

		public bool Contains(Missile? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(Missile? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(Missile[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<Missile> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<Missile> value)
	{
		int count = value.Count;
		int num = 14;
		if (value is Missile[] array)
		{
			foreach (Missile missile in array)
			{
				SerializationHelpers.EnsureNonNull(missile);
				num += FlatSharp.Compiler.Generated.NDED43AC666D1D9750273382C505C400A483C5F3D7FD0677F57493711B1623456.Helpers.GetMaxSize(missile);
			}
		}
		else if (value is List<Missile> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				Missile missile2 = list[j];
				SerializationHelpers.EnsureNonNull(missile2);
				num += FlatSharp.Compiler.Generated.NDED43AC666D1D9750273382C505C400A483C5F3D7FD0677F57493711B1623456.Helpers.GetMaxSize(missile2);
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				Missile missile3 = value[k];
				SerializationHelpers.EnsureNonNull(missile3);
				num += FlatSharp.Compiler.Generated.NDED43AC666D1D9750273382C505C400A483C5F3D7FD0677F57493711B1623456.Helpers.GetMaxSize(missile3);
			}
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<Missile> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 4);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is Missile[] array)
		{
			foreach (Missile missile in array)
			{
				SerializationHelpers.EnsureNonNull(missile);
				FlatSharp.Compiler.Generated.NDED43AC666D1D9750273382C505C400A483C5F3D7FD0677F57493711B1623456.Helpers.Serialize(spanWriter, span, missile, num, context);
				num += 4;
			}
		}
		else if (value is List<Missile> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				Missile missile2 = list[j];
				SerializationHelpers.EnsureNonNull(missile2);
				FlatSharp.Compiler.Generated.NDED43AC666D1D9750273382C505C400A483C5F3D7FD0677F57493711B1623456.Helpers.Serialize(spanWriter, span, missile2, num, context);
				num += 4;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				Missile missile3 = value[k];
				SerializationHelpers.EnsureNonNull(missile3);
				FlatSharp.Compiler.Generated.NDED43AC666D1D9750273382C505C400A483C5F3D7FD0677F57493711B1623456.Helpers.Serialize(spanWriter, span, missile3, num, context);
				num += 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<Missile> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_9603be00d7564d9d9bf2cb0ca26094bb_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<Missile> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_9603be00d7564d9d9bf2cb0ca26094bb_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<Missile> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_9603be00d7564d9d9bf2cb0ca26094bb_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<Missile> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_9603be00d7564d9d9bf2cb0ca26094bb_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
