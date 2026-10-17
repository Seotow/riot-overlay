using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Scene;
using FlatSharp.Compiler.Generated.N405CCDF1EC5A3D244FABF790E241DD351BBA7686D1907F197BB89423321DCBF5;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N9773EEC5D52817044E374FE4E43F10E1B920B97BDBD58FC23197C9AD6574C207;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ EntityAssignment ], Count = {Count}")]
	internal sealed class GeneratedVector_4fbe4053e28f49510161577b2238a69d_Lazy<TInputBuffer> : IList<EntityAssignment>, ICollection<EntityAssignment>, IEnumerable<EntityAssignment>, IEnumerable, IReadOnlyList<EntityAssignment>, IReadOnlyCollection<EntityAssignment>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public EntityAssignment this[int index]
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

		public GeneratedVector_4fbe4053e28f49510161577b2238a69d_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N405CCDF1EC5A3D244FABF790E241DD351BBA7686D1907F197BB89423321DCBF5.Helpers.tableReader_a930e8b7b5b44b82aa9bc7cffd0b3e1f_Lazy<TInputBuffer> SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N405CCDF1EC5A3D244FABF790E241DD351BBA7686D1907F197BB89423321DCBF5.Helpers.tableReader_a930e8b7b5b44b82aa9bc7cffd0b3e1f_Lazy<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return FlatSharp.Compiler.Generated.N405CCDF1EC5A3D244FABF790E241DD351BBA7686D1907F197BB89423321DCBF5.Helpers.Parse_Lazy(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, EntityAssignment value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(EntityAssignment? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(EntityAssignment? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(EntityAssignment[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<EntityAssignment> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(EntityAssignment item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, EntityAssignment item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(EntityAssignment item)
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

	[DebuggerDisplay("Progressive [ EntityAssignment ], Count = {Count}")]
	internal sealed class GeneratedVector_4fbe4053e28f49510161577b2238a69d_Progressive<TInputBuffer> : IList<EntityAssignment>, ICollection<EntityAssignment>, IEnumerable<EntityAssignment>, IEnumerable, IReadOnlyList<EntityAssignment>, IReadOnlyCollection<EntityAssignment>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly FlatSharp.Compiler.Generated.N405CCDF1EC5A3D244FABF790E241DD351BBA7686D1907F197BB89423321DCBF5.Helpers.tableReader_a930e8b7b5b44b82aa9bc7cffd0b3e1f_Progressive<TInputBuffer>?[]?[] items;

		public EntityAssignment this[int index]
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

		public GeneratedVector_4fbe4053e28f49510161577b2238a69d_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new FlatSharp.Compiler.Generated.N405CCDF1EC5A3D244FABF790E241DD351BBA7686D1907F197BB89423321DCBF5.Helpers.tableReader_a930e8b7b5b44b82aa9bc7cffd0b3e1f_Progressive<TInputBuffer>[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N405CCDF1EC5A3D244FABF790E241DD351BBA7686D1907F197BB89423321DCBF5.Helpers.tableReader_a930e8b7b5b44b82aa9bc7cffd0b3e1f_Progressive<TInputBuffer>?[] GetOrCreateRow(FlatSharp.Compiler.Generated.N405CCDF1EC5A3D244FABF790E241DD351BBA7686D1907F197BB89423321DCBF5.Helpers.tableReader_a930e8b7b5b44b82aa9bc7cffd0b3e1f_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private FlatSharp.Compiler.Generated.N405CCDF1EC5A3D244FABF790E241DD351BBA7686D1907F197BB89423321DCBF5.Helpers.tableReader_a930e8b7b5b44b82aa9bc7cffd0b3e1f_Progressive<TInputBuffer>?[] CreateRow(FlatSharp.Compiler.Generated.N405CCDF1EC5A3D244FABF790E241DD351BBA7686D1907F197BB89423321DCBF5.Helpers.tableReader_a930e8b7b5b44b82aa9bc7cffd0b3e1f_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] = new FlatSharp.Compiler.Generated.N405CCDF1EC5A3D244FABF790E241DD351BBA7686D1907F197BB89423321DCBF5.Helpers.tableReader_a930e8b7b5b44b82aa9bc7cffd0b3e1f_Progressive<TInputBuffer>[32];
		}

		private FlatSharp.Compiler.Generated.N405CCDF1EC5A3D244FABF790E241DD351BBA7686D1907F197BB89423321DCBF5.Helpers.tableReader_a930e8b7b5b44b82aa9bc7cffd0b3e1f_Progressive<TInputBuffer> ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			FlatSharp.Compiler.Generated.N405CCDF1EC5A3D244FABF790E241DD351BBA7686D1907F197BB89423321DCBF5.Helpers.tableReader_a930e8b7b5b44b82aa9bc7cffd0b3e1f_Progressive<TInputBuffer>[][] array = items;
			FlatSharp.Compiler.Generated.N405CCDF1EC5A3D244FABF790E241DD351BBA7686D1907F197BB89423321DCBF5.Helpers.tableReader_a930e8b7b5b44b82aa9bc7cffd0b3e1f_Progressive<TInputBuffer>[] orCreateRow = GetOrCreateRow(array, rowIndex);
			FlatSharp.Compiler.Generated.N405CCDF1EC5A3D244FABF790E241DD351BBA7686D1907F197BB89423321DCBF5.Helpers.tableReader_a930e8b7b5b44b82aa9bc7cffd0b3e1f_Progressive<TInputBuffer> tableReader_a930e8b7b5b44b82aa9bc7cffd0b3e1f_Progressive = orCreateRow[colIndex];
			if (tableReader_a930e8b7b5b44b82aa9bc7cffd0b3e1f_Progressive == null)
			{
				tableReader_a930e8b7b5b44b82aa9bc7cffd0b3e1f_Progressive = (orCreateRow[colIndex] = UnsafeParseItem(index));
			}
			return tableReader_a930e8b7b5b44b82aa9bc7cffd0b3e1f_Progressive;
		}

		private void ProgressiveSet(int index, EntityAssignment value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, EntityAssignment value)
		{
			VectorUtilities.CheckIndex(index, count);
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N405CCDF1EC5A3D244FABF790E241DD351BBA7686D1907F197BB89423321DCBF5.Helpers.tableReader_a930e8b7b5b44b82aa9bc7cffd0b3e1f_Progressive<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N405CCDF1EC5A3D244FABF790E241DD351BBA7686D1907F197BB89423321DCBF5.Helpers.tableReader_a930e8b7b5b44b82aa9bc7cffd0b3e1f_Progressive<TInputBuffer> UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.N405CCDF1EC5A3D244FABF790E241DD351BBA7686D1907F197BB89423321DCBF5.Helpers.Parse_Progressive(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, EntityAssignment value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(EntityAssignment? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(EntityAssignment? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(EntityAssignment[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<EntityAssignment> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(EntityAssignment item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, EntityAssignment item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(EntityAssignment item)
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

	[DebuggerDisplay("Greedy [ EntityAssignment ], Count = {Count}")]
	internal sealed class GeneratedVector_4fbe4053e28f49510161577b2238a69d_Greedy<TInputBuffer> : IList<EntityAssignment>, ICollection<EntityAssignment>, IEnumerable<EntityAssignment>, IEnumerable, IReadOnlyList<EntityAssignment>, IReadOnlyCollection<EntityAssignment> where TInputBuffer : IInputBuffer
	{
		private readonly List<FlatSharp.Compiler.Generated.N405CCDF1EC5A3D244FABF790E241DD351BBA7686D1907F197BB89423321DCBF5.Helpers.tableReader_a930e8b7b5b44b82aa9bc7cffd0b3e1f_Greedy<TInputBuffer>> list;

		public EntityAssignment this[int index]
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

		public GeneratedVector_4fbe4053e28f49510161577b2238a69d_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<FlatSharp.Compiler.Generated.N405CCDF1EC5A3D244FABF790E241DD351BBA7686D1907F197BB89423321DCBF5.Helpers.tableReader_a930e8b7b5b44b82aa9bc7cffd0b3e1f_Greedy<TInputBuffer>> list = (this.list = new List<FlatSharp.Compiler.Generated.N405CCDF1EC5A3D244FABF790E241DD351BBA7686D1907F197BB89423321DCBF5.Helpers.tableReader_a930e8b7b5b44b82aa9bc7cffd0b3e1f_Greedy<TInputBuffer>>(num));
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.N405CCDF1EC5A3D244FABF790E241DD351BBA7686D1907F197BB89423321DCBF5.Helpers.tableReader_a930e8b7b5b44b82aa9bc7cffd0b3e1f_Greedy<TInputBuffer> item = FlatSharp.Compiler.Generated.N405CCDF1EC5A3D244FABF790E241DD351BBA7686D1907F197BB89423321DCBF5.Helpers.Parse_Greedy(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		private FlatSharp.Compiler.Generated.N405CCDF1EC5A3D244FABF790E241DD351BBA7686D1907F197BB89423321DCBF5.Helpers.tableReader_a930e8b7b5b44b82aa9bc7cffd0b3e1f_Greedy<TInputBuffer> GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, EntityAssignment value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(EntityAssignment? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(EntityAssignment? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(EntityAssignment[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<EntityAssignment> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(EntityAssignment item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, EntityAssignment item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(EntityAssignment item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ EntityAssignment ], Count = {Count}")]
	internal sealed class GeneratedVector_4fbe4053e28f49510161577b2238a69d_GreedyMutable<TInputBuffer> : IList<EntityAssignment>, ICollection<EntityAssignment>, IEnumerable<EntityAssignment>, IEnumerable, IReadOnlyList<EntityAssignment>, IReadOnlyCollection<EntityAssignment> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<EntityAssignment> list;

		public EntityAssignment this[int index]
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

		public GeneratedVector_4fbe4053e28f49510161577b2238a69d_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<EntityAssignment> list = (this.list = new List<EntityAssignment>());
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.N405CCDF1EC5A3D244FABF790E241DD351BBA7686D1907F197BB89423321DCBF5.Helpers.tableReader_a930e8b7b5b44b82aa9bc7cffd0b3e1f_GreedyMutable<TInputBuffer> item = FlatSharp.Compiler.Generated.N405CCDF1EC5A3D244FABF790E241DD351BBA7686D1907F197BB89423321DCBF5.Helpers.Parse_GreedyMutable(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private EntityAssignment GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, EntityAssignment value)
		{
			list[index] = value;
		}

		public void Add(EntityAssignment item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, EntityAssignment item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(EntityAssignment item)
		{
			return list.Remove(item);
		}

		public bool Contains(EntityAssignment? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(EntityAssignment? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(EntityAssignment[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<EntityAssignment> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<EntityAssignment> value)
	{
		int count = value.Count;
		int num = 14;
		if (value is EntityAssignment[] array)
		{
			foreach (EntityAssignment entityAssignment in array)
			{
				SerializationHelpers.EnsureNonNull(entityAssignment);
				num += FlatSharp.Compiler.Generated.N405CCDF1EC5A3D244FABF790E241DD351BBA7686D1907F197BB89423321DCBF5.Helpers.GetMaxSize(entityAssignment);
			}
		}
		else if (value is List<EntityAssignment> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				EntityAssignment entityAssignment2 = list[j];
				SerializationHelpers.EnsureNonNull(entityAssignment2);
				num += FlatSharp.Compiler.Generated.N405CCDF1EC5A3D244FABF790E241DD351BBA7686D1907F197BB89423321DCBF5.Helpers.GetMaxSize(entityAssignment2);
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				EntityAssignment entityAssignment3 = value[k];
				SerializationHelpers.EnsureNonNull(entityAssignment3);
				num += FlatSharp.Compiler.Generated.N405CCDF1EC5A3D244FABF790E241DD351BBA7686D1907F197BB89423321DCBF5.Helpers.GetMaxSize(entityAssignment3);
			}
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<EntityAssignment> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 4);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is EntityAssignment[] array)
		{
			foreach (EntityAssignment entityAssignment in array)
			{
				SerializationHelpers.EnsureNonNull(entityAssignment);
				FlatSharp.Compiler.Generated.N405CCDF1EC5A3D244FABF790E241DD351BBA7686D1907F197BB89423321DCBF5.Helpers.Serialize(spanWriter, span, entityAssignment, num, context);
				num += 4;
			}
		}
		else if (value is List<EntityAssignment> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				EntityAssignment entityAssignment2 = list[j];
				SerializationHelpers.EnsureNonNull(entityAssignment2);
				FlatSharp.Compiler.Generated.N405CCDF1EC5A3D244FABF790E241DD351BBA7686D1907F197BB89423321DCBF5.Helpers.Serialize(spanWriter, span, entityAssignment2, num, context);
				num += 4;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				EntityAssignment entityAssignment3 = value[k];
				SerializationHelpers.EnsureNonNull(entityAssignment3);
				FlatSharp.Compiler.Generated.N405CCDF1EC5A3D244FABF790E241DD351BBA7686D1907F197BB89423321DCBF5.Helpers.Serialize(spanWriter, span, entityAssignment3, num, context);
				num += 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<EntityAssignment> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_4fbe4053e28f49510161577b2238a69d_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<EntityAssignment> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_4fbe4053e28f49510161577b2238a69d_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<EntityAssignment> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_4fbe4053e28f49510161577b2238a69d_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<EntityAssignment> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_4fbe4053e28f49510161577b2238a69d_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
