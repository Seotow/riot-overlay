using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Scene;
using FlatSharp.Compiler.Generated.NB90F045B4EBB5227DC2EBE8B7E33B0509F5E38F7E57358921CCB129C5DD6BA93;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N3A2435729B14EE66C49125E1A099A70C7248631EAA28EEBD5E50DC67773E5F28;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ SetComponent ], Count = {Count}")]
	internal sealed class GeneratedVector_317d6b1ff41b19ed203f3cce4b66d38d_Lazy<TInputBuffer> : IList<SetComponent>, ICollection<SetComponent>, IEnumerable<SetComponent>, IEnumerable, IReadOnlyList<SetComponent>, IReadOnlyCollection<SetComponent>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public SetComponent this[int index]
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

		public GeneratedVector_317d6b1ff41b19ed203f3cce4b66d38d_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NB90F045B4EBB5227DC2EBE8B7E33B0509F5E38F7E57358921CCB129C5DD6BA93.Helpers.tableReader_a85b4d8566544be79bf1e37e54c24910_Lazy<TInputBuffer> SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NB90F045B4EBB5227DC2EBE8B7E33B0509F5E38F7E57358921CCB129C5DD6BA93.Helpers.tableReader_a85b4d8566544be79bf1e37e54c24910_Lazy<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return FlatSharp.Compiler.Generated.NB90F045B4EBB5227DC2EBE8B7E33B0509F5E38F7E57358921CCB129C5DD6BA93.Helpers.Parse_Lazy(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, SetComponent value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(SetComponent? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(SetComponent? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(SetComponent[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<SetComponent> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(SetComponent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, SetComponent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(SetComponent item)
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

	[DebuggerDisplay("Progressive [ SetComponent ], Count = {Count}")]
	internal sealed class GeneratedVector_317d6b1ff41b19ed203f3cce4b66d38d_Progressive<TInputBuffer> : IList<SetComponent>, ICollection<SetComponent>, IEnumerable<SetComponent>, IEnumerable, IReadOnlyList<SetComponent>, IReadOnlyCollection<SetComponent>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly FlatSharp.Compiler.Generated.NB90F045B4EBB5227DC2EBE8B7E33B0509F5E38F7E57358921CCB129C5DD6BA93.Helpers.tableReader_a85b4d8566544be79bf1e37e54c24910_Progressive<TInputBuffer>?[]?[] items;

		public SetComponent this[int index]
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

		public GeneratedVector_317d6b1ff41b19ed203f3cce4b66d38d_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new FlatSharp.Compiler.Generated.NB90F045B4EBB5227DC2EBE8B7E33B0509F5E38F7E57358921CCB129C5DD6BA93.Helpers.tableReader_a85b4d8566544be79bf1e37e54c24910_Progressive<TInputBuffer>[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NB90F045B4EBB5227DC2EBE8B7E33B0509F5E38F7E57358921CCB129C5DD6BA93.Helpers.tableReader_a85b4d8566544be79bf1e37e54c24910_Progressive<TInputBuffer>?[] GetOrCreateRow(FlatSharp.Compiler.Generated.NB90F045B4EBB5227DC2EBE8B7E33B0509F5E38F7E57358921CCB129C5DD6BA93.Helpers.tableReader_a85b4d8566544be79bf1e37e54c24910_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private FlatSharp.Compiler.Generated.NB90F045B4EBB5227DC2EBE8B7E33B0509F5E38F7E57358921CCB129C5DD6BA93.Helpers.tableReader_a85b4d8566544be79bf1e37e54c24910_Progressive<TInputBuffer>?[] CreateRow(FlatSharp.Compiler.Generated.NB90F045B4EBB5227DC2EBE8B7E33B0509F5E38F7E57358921CCB129C5DD6BA93.Helpers.tableReader_a85b4d8566544be79bf1e37e54c24910_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] = new FlatSharp.Compiler.Generated.NB90F045B4EBB5227DC2EBE8B7E33B0509F5E38F7E57358921CCB129C5DD6BA93.Helpers.tableReader_a85b4d8566544be79bf1e37e54c24910_Progressive<TInputBuffer>[32];
		}

		private FlatSharp.Compiler.Generated.NB90F045B4EBB5227DC2EBE8B7E33B0509F5E38F7E57358921CCB129C5DD6BA93.Helpers.tableReader_a85b4d8566544be79bf1e37e54c24910_Progressive<TInputBuffer> ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			FlatSharp.Compiler.Generated.NB90F045B4EBB5227DC2EBE8B7E33B0509F5E38F7E57358921CCB129C5DD6BA93.Helpers.tableReader_a85b4d8566544be79bf1e37e54c24910_Progressive<TInputBuffer>[][] array = items;
			FlatSharp.Compiler.Generated.NB90F045B4EBB5227DC2EBE8B7E33B0509F5E38F7E57358921CCB129C5DD6BA93.Helpers.tableReader_a85b4d8566544be79bf1e37e54c24910_Progressive<TInputBuffer>[] orCreateRow = GetOrCreateRow(array, rowIndex);
			FlatSharp.Compiler.Generated.NB90F045B4EBB5227DC2EBE8B7E33B0509F5E38F7E57358921CCB129C5DD6BA93.Helpers.tableReader_a85b4d8566544be79bf1e37e54c24910_Progressive<TInputBuffer> tableReader_a85b4d8566544be79bf1e37e54c24910_Progressive = orCreateRow[colIndex];
			if (tableReader_a85b4d8566544be79bf1e37e54c24910_Progressive == null)
			{
				tableReader_a85b4d8566544be79bf1e37e54c24910_Progressive = (orCreateRow[colIndex] = UnsafeParseItem(index));
			}
			return tableReader_a85b4d8566544be79bf1e37e54c24910_Progressive;
		}

		private void ProgressiveSet(int index, SetComponent value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, SetComponent value)
		{
			VectorUtilities.CheckIndex(index, count);
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NB90F045B4EBB5227DC2EBE8B7E33B0509F5E38F7E57358921CCB129C5DD6BA93.Helpers.tableReader_a85b4d8566544be79bf1e37e54c24910_Progressive<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NB90F045B4EBB5227DC2EBE8B7E33B0509F5E38F7E57358921CCB129C5DD6BA93.Helpers.tableReader_a85b4d8566544be79bf1e37e54c24910_Progressive<TInputBuffer> UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.NB90F045B4EBB5227DC2EBE8B7E33B0509F5E38F7E57358921CCB129C5DD6BA93.Helpers.Parse_Progressive(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, SetComponent value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(SetComponent? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(SetComponent? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(SetComponent[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<SetComponent> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(SetComponent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, SetComponent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(SetComponent item)
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

	[DebuggerDisplay("Greedy [ SetComponent ], Count = {Count}")]
	internal sealed class GeneratedVector_317d6b1ff41b19ed203f3cce4b66d38d_Greedy<TInputBuffer> : IList<SetComponent>, ICollection<SetComponent>, IEnumerable<SetComponent>, IEnumerable, IReadOnlyList<SetComponent>, IReadOnlyCollection<SetComponent> where TInputBuffer : IInputBuffer
	{
		private readonly List<FlatSharp.Compiler.Generated.NB90F045B4EBB5227DC2EBE8B7E33B0509F5E38F7E57358921CCB129C5DD6BA93.Helpers.tableReader_a85b4d8566544be79bf1e37e54c24910_Greedy<TInputBuffer>> list;

		public SetComponent this[int index]
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

		public GeneratedVector_317d6b1ff41b19ed203f3cce4b66d38d_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<FlatSharp.Compiler.Generated.NB90F045B4EBB5227DC2EBE8B7E33B0509F5E38F7E57358921CCB129C5DD6BA93.Helpers.tableReader_a85b4d8566544be79bf1e37e54c24910_Greedy<TInputBuffer>> list = (this.list = new List<FlatSharp.Compiler.Generated.NB90F045B4EBB5227DC2EBE8B7E33B0509F5E38F7E57358921CCB129C5DD6BA93.Helpers.tableReader_a85b4d8566544be79bf1e37e54c24910_Greedy<TInputBuffer>>(num));
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.NB90F045B4EBB5227DC2EBE8B7E33B0509F5E38F7E57358921CCB129C5DD6BA93.Helpers.tableReader_a85b4d8566544be79bf1e37e54c24910_Greedy<TInputBuffer> item = FlatSharp.Compiler.Generated.NB90F045B4EBB5227DC2EBE8B7E33B0509F5E38F7E57358921CCB129C5DD6BA93.Helpers.Parse_Greedy(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		private FlatSharp.Compiler.Generated.NB90F045B4EBB5227DC2EBE8B7E33B0509F5E38F7E57358921CCB129C5DD6BA93.Helpers.tableReader_a85b4d8566544be79bf1e37e54c24910_Greedy<TInputBuffer> GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, SetComponent value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(SetComponent? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(SetComponent? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(SetComponent[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<SetComponent> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(SetComponent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, SetComponent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(SetComponent item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ SetComponent ], Count = {Count}")]
	internal sealed class GeneratedVector_317d6b1ff41b19ed203f3cce4b66d38d_GreedyMutable<TInputBuffer> : IList<SetComponent>, ICollection<SetComponent>, IEnumerable<SetComponent>, IEnumerable, IReadOnlyList<SetComponent>, IReadOnlyCollection<SetComponent> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<SetComponent> list;

		public SetComponent this[int index]
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

		public GeneratedVector_317d6b1ff41b19ed203f3cce4b66d38d_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<SetComponent> list = (this.list = new List<SetComponent>());
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.NB90F045B4EBB5227DC2EBE8B7E33B0509F5E38F7E57358921CCB129C5DD6BA93.Helpers.tableReader_a85b4d8566544be79bf1e37e54c24910_GreedyMutable<TInputBuffer> item = FlatSharp.Compiler.Generated.NB90F045B4EBB5227DC2EBE8B7E33B0509F5E38F7E57358921CCB129C5DD6BA93.Helpers.Parse_GreedyMutable(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private SetComponent GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, SetComponent value)
		{
			list[index] = value;
		}

		public void Add(SetComponent item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, SetComponent item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(SetComponent item)
		{
			return list.Remove(item);
		}

		public bool Contains(SetComponent? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(SetComponent? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(SetComponent[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<SetComponent> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<SetComponent> value)
	{
		int count = value.Count;
		int num = 14;
		if (value is SetComponent[] array)
		{
			foreach (SetComponent setComponent in array)
			{
				SerializationHelpers.EnsureNonNull(setComponent);
				num += FlatSharp.Compiler.Generated.NB90F045B4EBB5227DC2EBE8B7E33B0509F5E38F7E57358921CCB129C5DD6BA93.Helpers.GetMaxSize(setComponent);
			}
		}
		else if (value is List<SetComponent> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				SetComponent setComponent2 = list[j];
				SerializationHelpers.EnsureNonNull(setComponent2);
				num += FlatSharp.Compiler.Generated.NB90F045B4EBB5227DC2EBE8B7E33B0509F5E38F7E57358921CCB129C5DD6BA93.Helpers.GetMaxSize(setComponent2);
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				SetComponent setComponent3 = value[k];
				SerializationHelpers.EnsureNonNull(setComponent3);
				num += FlatSharp.Compiler.Generated.NB90F045B4EBB5227DC2EBE8B7E33B0509F5E38F7E57358921CCB129C5DD6BA93.Helpers.GetMaxSize(setComponent3);
			}
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<SetComponent> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 4);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is SetComponent[] array)
		{
			foreach (SetComponent setComponent in array)
			{
				SerializationHelpers.EnsureNonNull(setComponent);
				FlatSharp.Compiler.Generated.NB90F045B4EBB5227DC2EBE8B7E33B0509F5E38F7E57358921CCB129C5DD6BA93.Helpers.Serialize(spanWriter, span, setComponent, num, context);
				num += 4;
			}
		}
		else if (value is List<SetComponent> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				SetComponent setComponent2 = list[j];
				SerializationHelpers.EnsureNonNull(setComponent2);
				FlatSharp.Compiler.Generated.NB90F045B4EBB5227DC2EBE8B7E33B0509F5E38F7E57358921CCB129C5DD6BA93.Helpers.Serialize(spanWriter, span, setComponent2, num, context);
				num += 4;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				SetComponent setComponent3 = value[k];
				SerializationHelpers.EnsureNonNull(setComponent3);
				FlatSharp.Compiler.Generated.NB90F045B4EBB5227DC2EBE8B7E33B0509F5E38F7E57358921CCB129C5DD6BA93.Helpers.Serialize(spanWriter, span, setComponent3, num, context);
				num += 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<SetComponent> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return new GeneratedVector_317d6b1ff41b19ed203f3cce4b66d38d_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<SetComponent> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return new GeneratedVector_317d6b1ff41b19ed203f3cce4b66d38d_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<SetComponent> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return new GeneratedVector_317d6b1ff41b19ed203f3cce4b66d38d_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<SetComponent> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return new GeneratedVector_317d6b1ff41b19ed203f3cce4b66d38d_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
