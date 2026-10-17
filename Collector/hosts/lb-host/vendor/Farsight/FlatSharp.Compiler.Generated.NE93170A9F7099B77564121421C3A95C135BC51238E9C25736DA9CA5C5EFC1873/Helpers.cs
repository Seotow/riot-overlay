using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Entity;
using FlatSharp.Compiler.Generated.ND0FC3ABBD6A762E619D3E4BD7A1716BA78A3C93D12EA9174BE338CC162CE16E9;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.NE93170A9F7099B77564121421C3A95C135BC51238E9C25736DA9CA5C5EFC1873;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ Component ], Count = {Count}")]
	internal sealed class GeneratedVector_6dd5c8b2c404e9e7ae051b206958782e_Lazy<TInputBuffer> : IList<Component>, ICollection<Component>, IEnumerable<Component>, IEnumerable, IReadOnlyList<Component>, IReadOnlyCollection<Component> where TInputBuffer : IInputBuffer
	{
		private readonly int discriminatorVectorOffset;

		private readonly int offsetVectorOffset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public Component this[int index]
		{
			get
			{
				return SafeParseItem(index);
			}
			set
			{
				VectorUtilities.CheckIndex(index, count);
				WriteThrough(index, value);
			}
		}

		public int Count => count;

		public FlatBufferDeserializationOption DeserializationOption => FlatBufferDeserializationOption.Lazy;

		public bool IsReadOnly => true;

		public GeneratedVector_6dd5c8b2c404e9e7ae051b206958782e_Lazy(TInputBuffer memory, ref (int offset0, int offset1) offsets, short remainingDepth, TableFieldContext fieldContext)
		{
			int item = offsets.offset0;
			int item2 = offsets.offset1;
			uint num = memory.ReadUInt(item);
			uint num2 = memory.ReadUInt(item2);
			if (num != num2)
			{
				FSThrow.InvalidData_UnionVectorMismatchedLength();
			}
			count = (int)num2;
			discriminatorVectorOffset = item + 4;
			offsetVectorOffset = item2 + 4;
			buffer = memory;
			this.remainingDepth = remainingDepth;
			this.fieldContext = fieldContext;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private Component SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private Component UnsafeParseItem(int index)
		{
			(int, int) offset = (discriminatorVectorOffset + index, offsetVectorOffset + (index << 2));
			return FlatSharp.Compiler.Generated.ND0FC3ABBD6A762E619D3E4BD7A1716BA78A3C93D12EA9174BE338CC162CE16E9.Helpers.Parse_Lazy(buffer, ref offset, remainingDepth);
		}

		private void WriteThrough(int index, Component value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(Component item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(Component item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(Component[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<Component> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(Component item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, Component item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(Component item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("Progressive [ Component ], Count = {Count}")]
	internal sealed class GeneratedVector_6dd5c8b2c404e9e7ae051b206958782e_Progressive<TInputBuffer> : IList<Component>, ICollection<Component>, IEnumerable<Component>, IEnumerable, IReadOnlyList<Component>, IReadOnlyCollection<Component> where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int discriminatorVectorOffset;

		private readonly int offsetVectorOffset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly Component?[]?[] items;

		public Component this[int index]
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

		public GeneratedVector_6dd5c8b2c404e9e7ae051b206958782e_Progressive(TInputBuffer memory, ref (int offset0, int offset1) offsets, short remainingDepth, TableFieldContext fieldContext)
		{
			int item = offsets.offset0;
			int item2 = offsets.offset1;
			uint num = memory.ReadUInt(item);
			uint num2 = memory.ReadUInt(item2);
			if (num != num2)
			{
				FSThrow.InvalidData_UnionVectorMismatchedLength();
			}
			count = (int)num2;
			discriminatorVectorOffset = item + 4;
			offsetVectorOffset = item2 + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num3 = (int)((long)count / 32L) + 1;
			items = new Component?[num3][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private Component?[] GetOrCreateRow(Component?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private Component?[] CreateRow(Component?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] = new Component?[32];
		}

		private Component ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			Component?[][] array = items;
			Component?[] orCreateRow = GetOrCreateRow(array, rowIndex);
			Component? component = orCreateRow[colIndex];
			if (!component.HasValue)
			{
				component = (orCreateRow[colIndex] = UnsafeParseItem(index));
			}
			return component.Value;
		}

		private void ProgressiveSet(int index, Component value)
		{
			VectorUtilities.CheckIndex(index, count);
			FSThrow.NotMutable_DeserializedVector();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private Component UnsafeParseItem(int index)
		{
			(int, int) offset = (discriminatorVectorOffset + index, offsetVectorOffset + (index << 2));
			return FlatSharp.Compiler.Generated.ND0FC3ABBD6A762E619D3E4BD7A1716BA78A3C93D12EA9174BE338CC162CE16E9.Helpers.Parse_Progressive(buffer, ref offset, remainingDepth);
		}

		public bool Contains(Component item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(Component item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(Component[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<Component> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(Component item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, Component item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(Component item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("Greedy [ Component ], Count = {Count}")]
	internal sealed class GeneratedVector_6dd5c8b2c404e9e7ae051b206958782e_Greedy<TInputBuffer> : IList<Component>, ICollection<Component>, IEnumerable<Component>, IEnumerable, IReadOnlyList<Component>, IReadOnlyCollection<Component> where TInputBuffer : IInputBuffer
	{
		private readonly List<Component> list;

		public Component this[int index]
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

		public GeneratedVector_6dd5c8b2c404e9e7ae051b206958782e_Greedy(TInputBuffer buffer, ref (int offset0, int offset1) offsets, short remainingDepth, TableFieldContext fieldContext)
		{
			int item = offsets.offset0;
			int item2 = offsets.offset1;
			int num = (int)buffer.ReadUInt(item);
			int num2 = (int)buffer.ReadUInt(item2);
			if (num != num2)
			{
				FSThrow.InvalidData_UnionVectorMismatchedLength();
			}
			item += 4;
			item2 += 4;
			List<Component> list = (this.list = new List<Component>(num2));
			for (int i = 0; i < num; i++)
			{
				(int, int) offset = (item, item2);
				Component item3 = FlatSharp.Compiler.Generated.ND0FC3ABBD6A762E619D3E4BD7A1716BA78A3C93D12EA9174BE338CC162CE16E9.Helpers.Parse_Greedy(buffer, ref offset, remainingDepth);
				list.Add(item3);
				item++;
				item2 += 4;
			}
		}

		private Component GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, Component value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(Component item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(Component item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(Component[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<Component> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(Component item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, Component item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(Component item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ Component ], Count = {Count}")]
	internal sealed class GeneratedVector_6dd5c8b2c404e9e7ae051b206958782e_GreedyMutable<TInputBuffer> : IList<Component>, ICollection<Component>, IEnumerable<Component>, IEnumerable, IReadOnlyList<Component>, IReadOnlyCollection<Component> where TInputBuffer : IInputBuffer
	{
		private readonly List<Component> list;

		public Component this[int index]
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

		public GeneratedVector_6dd5c8b2c404e9e7ae051b206958782e_GreedyMutable(TInputBuffer buffer, ref (int offset0, int offset1) offsets, short remainingDepth, TableFieldContext fieldContext)
		{
			int item = offsets.offset0;
			int item2 = offsets.offset1;
			int num = (int)buffer.ReadUInt(item);
			int num2 = (int)buffer.ReadUInt(item2);
			if (num != num2)
			{
				FSThrow.InvalidData_UnionVectorMismatchedLength();
			}
			item += 4;
			item2 += 4;
			List<Component> list = (this.list = new List<Component>(num2));
			for (int i = 0; i < num; i++)
			{
				(int, int) offset = (item, item2);
				Component item3 = FlatSharp.Compiler.Generated.ND0FC3ABBD6A762E619D3E4BD7A1716BA78A3C93D12EA9174BE338CC162CE16E9.Helpers.Parse_GreedyMutable(buffer, ref offset, remainingDepth);
				list.Add(item3);
				item++;
				item2 += 4;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private Component GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, Component value)
		{
			list[index] = value;
		}

		public void Add(Component item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, Component item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(Component item)
		{
			return list.Remove(item);
		}

		public bool Contains(Component item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(Component item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(Component[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<Component> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<Component> value)
	{
		int count = value.Count;
		int num = 14 + count * 5;
		for (int i = 0; i < count; i++)
		{
			Component value2 = value[i];
			num += FlatSharp.Compiler.Generated.ND0FC3ABBD6A762E619D3E4BD7A1716BA78A3C93D12EA9174BE338CC162CE16E9.Helpers.GetMaxSize(value2);
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<Component> value, ref (int offset0, int offset1) offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(1, count, 1);
		spanWriter.WriteUOffset(span, offset.offset0, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		int num2 = context.AllocateVector(4, count, 4);
		spanWriter.WriteUOffset(span, offset.offset1, num2);
		spanWriter.WriteInt(span, count, num2);
		num2 += 4;
		for (int i = 0; i < count; i++)
		{
			Component value2 = value[i];
			(int, int) offset2 = (num, num2);
			FlatSharp.Compiler.Generated.ND0FC3ABBD6A762E619D3E4BD7A1716BA78A3C93D12EA9174BE338CC162CE16E9.Helpers.Serialize(spanWriter, span, value2, ref offset2, context);
			num++;
			num2 += 4;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<Component> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, ref (int offset0, int offset1) offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		(int, int) offsets = (offset.offset0 + buffer.ReadUOffset(offset.offset0), offset.offset1 + buffer.ReadUOffset(offset.offset1));
		return new GeneratedVector_6dd5c8b2c404e9e7ae051b206958782e_Lazy<TInputBuffer>(buffer, ref offsets, remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<Component> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, ref (int offset0, int offset1) offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		(int, int) offsets = (offset.offset0 + buffer.ReadUOffset(offset.offset0), offset.offset1 + buffer.ReadUOffset(offset.offset1));
		return new GeneratedVector_6dd5c8b2c404e9e7ae051b206958782e_Progressive<TInputBuffer>(buffer, ref offsets, remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<Component> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, ref (int offset0, int offset1) offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		(int, int) offsets = (offset.offset0 + buffer.ReadUOffset(offset.offset0), offset.offset1 + buffer.ReadUOffset(offset.offset1));
		return new GeneratedVector_6dd5c8b2c404e9e7ae051b206958782e_Greedy<TInputBuffer>(buffer, ref offsets, remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<Component> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, ref (int offset0, int offset1) offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		(int, int) offsets = (offset.offset0 + buffer.ReadUOffset(offset.offset0), offset.offset1 + buffer.ReadUOffset(offset.offset1));
		return new GeneratedVector_6dd5c8b2c404e9e7ae051b206958782e_GreedyMutable<TInputBuffer>(buffer, ref offsets, remainingDepth, fieldContext);
	}
}
