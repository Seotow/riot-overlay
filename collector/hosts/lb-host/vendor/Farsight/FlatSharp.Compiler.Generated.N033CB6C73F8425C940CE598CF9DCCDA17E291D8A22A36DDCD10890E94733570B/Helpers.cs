using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Scene;
using FlatSharp.Compiler.Generated.NC5CBA9F46D32D05766F60D0B099A849A6DF84F2017E84177AF17E73CA658E441;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N033CB6C73F8425C940CE598CF9DCCDA17E291D8A22A36DDCD10890E94733570B;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ EntityTransformUpdate ], Count = {Count}")]
	internal sealed class GeneratedVector_821ce7913b453c8010d45e123f5f933b_Lazy<TInputBuffer> : IList<EntityTransformUpdate>, ICollection<EntityTransformUpdate>, IEnumerable<EntityTransformUpdate>, IEnumerable, IReadOnlyList<EntityTransformUpdate>, IReadOnlyCollection<EntityTransformUpdate>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public EntityTransformUpdate this[int index]
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

		public GeneratedVector_821ce7913b453c8010d45e123f5f933b_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NC5CBA9F46D32D05766F60D0B099A849A6DF84F2017E84177AF17E73CA658E441.Helpers.tableReader_dfbdce5851d140c9af91c813ee51e209_Lazy<TInputBuffer> SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NC5CBA9F46D32D05766F60D0B099A849A6DF84F2017E84177AF17E73CA658E441.Helpers.tableReader_dfbdce5851d140c9af91c813ee51e209_Lazy<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return FlatSharp.Compiler.Generated.NC5CBA9F46D32D05766F60D0B099A849A6DF84F2017E84177AF17E73CA658E441.Helpers.Parse_Lazy(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, EntityTransformUpdate value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(EntityTransformUpdate? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(EntityTransformUpdate? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(EntityTransformUpdate[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<EntityTransformUpdate> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(EntityTransformUpdate item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, EntityTransformUpdate item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(EntityTransformUpdate item)
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

	[DebuggerDisplay("Progressive [ EntityTransformUpdate ], Count = {Count}")]
	internal sealed class GeneratedVector_821ce7913b453c8010d45e123f5f933b_Progressive<TInputBuffer> : IList<EntityTransformUpdate>, ICollection<EntityTransformUpdate>, IEnumerable<EntityTransformUpdate>, IEnumerable, IReadOnlyList<EntityTransformUpdate>, IReadOnlyCollection<EntityTransformUpdate>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly FlatSharp.Compiler.Generated.NC5CBA9F46D32D05766F60D0B099A849A6DF84F2017E84177AF17E73CA658E441.Helpers.tableReader_dfbdce5851d140c9af91c813ee51e209_Progressive<TInputBuffer>?[]?[] items;

		public EntityTransformUpdate this[int index]
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

		public GeneratedVector_821ce7913b453c8010d45e123f5f933b_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new FlatSharp.Compiler.Generated.NC5CBA9F46D32D05766F60D0B099A849A6DF84F2017E84177AF17E73CA658E441.Helpers.tableReader_dfbdce5851d140c9af91c813ee51e209_Progressive<TInputBuffer>[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NC5CBA9F46D32D05766F60D0B099A849A6DF84F2017E84177AF17E73CA658E441.Helpers.tableReader_dfbdce5851d140c9af91c813ee51e209_Progressive<TInputBuffer>?[] GetOrCreateRow(FlatSharp.Compiler.Generated.NC5CBA9F46D32D05766F60D0B099A849A6DF84F2017E84177AF17E73CA658E441.Helpers.tableReader_dfbdce5851d140c9af91c813ee51e209_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private FlatSharp.Compiler.Generated.NC5CBA9F46D32D05766F60D0B099A849A6DF84F2017E84177AF17E73CA658E441.Helpers.tableReader_dfbdce5851d140c9af91c813ee51e209_Progressive<TInputBuffer>?[] CreateRow(FlatSharp.Compiler.Generated.NC5CBA9F46D32D05766F60D0B099A849A6DF84F2017E84177AF17E73CA658E441.Helpers.tableReader_dfbdce5851d140c9af91c813ee51e209_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] = new FlatSharp.Compiler.Generated.NC5CBA9F46D32D05766F60D0B099A849A6DF84F2017E84177AF17E73CA658E441.Helpers.tableReader_dfbdce5851d140c9af91c813ee51e209_Progressive<TInputBuffer>[32];
		}

		private FlatSharp.Compiler.Generated.NC5CBA9F46D32D05766F60D0B099A849A6DF84F2017E84177AF17E73CA658E441.Helpers.tableReader_dfbdce5851d140c9af91c813ee51e209_Progressive<TInputBuffer> ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			FlatSharp.Compiler.Generated.NC5CBA9F46D32D05766F60D0B099A849A6DF84F2017E84177AF17E73CA658E441.Helpers.tableReader_dfbdce5851d140c9af91c813ee51e209_Progressive<TInputBuffer>[][] array = items;
			FlatSharp.Compiler.Generated.NC5CBA9F46D32D05766F60D0B099A849A6DF84F2017E84177AF17E73CA658E441.Helpers.tableReader_dfbdce5851d140c9af91c813ee51e209_Progressive<TInputBuffer>[] orCreateRow = GetOrCreateRow(array, rowIndex);
			FlatSharp.Compiler.Generated.NC5CBA9F46D32D05766F60D0B099A849A6DF84F2017E84177AF17E73CA658E441.Helpers.tableReader_dfbdce5851d140c9af91c813ee51e209_Progressive<TInputBuffer> tableReader_dfbdce5851d140c9af91c813ee51e209_Progressive = orCreateRow[colIndex];
			if (tableReader_dfbdce5851d140c9af91c813ee51e209_Progressive == null)
			{
				tableReader_dfbdce5851d140c9af91c813ee51e209_Progressive = (orCreateRow[colIndex] = UnsafeParseItem(index));
			}
			return tableReader_dfbdce5851d140c9af91c813ee51e209_Progressive;
		}

		private void ProgressiveSet(int index, EntityTransformUpdate value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, EntityTransformUpdate value)
		{
			VectorUtilities.CheckIndex(index, count);
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NC5CBA9F46D32D05766F60D0B099A849A6DF84F2017E84177AF17E73CA658E441.Helpers.tableReader_dfbdce5851d140c9af91c813ee51e209_Progressive<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NC5CBA9F46D32D05766F60D0B099A849A6DF84F2017E84177AF17E73CA658E441.Helpers.tableReader_dfbdce5851d140c9af91c813ee51e209_Progressive<TInputBuffer> UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.NC5CBA9F46D32D05766F60D0B099A849A6DF84F2017E84177AF17E73CA658E441.Helpers.Parse_Progressive(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, EntityTransformUpdate value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(EntityTransformUpdate? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(EntityTransformUpdate? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(EntityTransformUpdate[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<EntityTransformUpdate> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(EntityTransformUpdate item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, EntityTransformUpdate item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(EntityTransformUpdate item)
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

	[DebuggerDisplay("Greedy [ EntityTransformUpdate ], Count = {Count}")]
	internal sealed class GeneratedVector_821ce7913b453c8010d45e123f5f933b_Greedy<TInputBuffer> : IList<EntityTransformUpdate>, ICollection<EntityTransformUpdate>, IEnumerable<EntityTransformUpdate>, IEnumerable, IReadOnlyList<EntityTransformUpdate>, IReadOnlyCollection<EntityTransformUpdate> where TInputBuffer : IInputBuffer
	{
		private readonly List<FlatSharp.Compiler.Generated.NC5CBA9F46D32D05766F60D0B099A849A6DF84F2017E84177AF17E73CA658E441.Helpers.tableReader_dfbdce5851d140c9af91c813ee51e209_Greedy<TInputBuffer>> list;

		public EntityTransformUpdate this[int index]
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

		public GeneratedVector_821ce7913b453c8010d45e123f5f933b_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<FlatSharp.Compiler.Generated.NC5CBA9F46D32D05766F60D0B099A849A6DF84F2017E84177AF17E73CA658E441.Helpers.tableReader_dfbdce5851d140c9af91c813ee51e209_Greedy<TInputBuffer>> list = (this.list = new List<FlatSharp.Compiler.Generated.NC5CBA9F46D32D05766F60D0B099A849A6DF84F2017E84177AF17E73CA658E441.Helpers.tableReader_dfbdce5851d140c9af91c813ee51e209_Greedy<TInputBuffer>>(num));
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.NC5CBA9F46D32D05766F60D0B099A849A6DF84F2017E84177AF17E73CA658E441.Helpers.tableReader_dfbdce5851d140c9af91c813ee51e209_Greedy<TInputBuffer> item = FlatSharp.Compiler.Generated.NC5CBA9F46D32D05766F60D0B099A849A6DF84F2017E84177AF17E73CA658E441.Helpers.Parse_Greedy(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		private FlatSharp.Compiler.Generated.NC5CBA9F46D32D05766F60D0B099A849A6DF84F2017E84177AF17E73CA658E441.Helpers.tableReader_dfbdce5851d140c9af91c813ee51e209_Greedy<TInputBuffer> GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, EntityTransformUpdate value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(EntityTransformUpdate? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(EntityTransformUpdate? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(EntityTransformUpdate[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<EntityTransformUpdate> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(EntityTransformUpdate item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, EntityTransformUpdate item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(EntityTransformUpdate item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ EntityTransformUpdate ], Count = {Count}")]
	internal sealed class GeneratedVector_821ce7913b453c8010d45e123f5f933b_GreedyMutable<TInputBuffer> : IList<EntityTransformUpdate>, ICollection<EntityTransformUpdate>, IEnumerable<EntityTransformUpdate>, IEnumerable, IReadOnlyList<EntityTransformUpdate>, IReadOnlyCollection<EntityTransformUpdate> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<EntityTransformUpdate> list;

		public EntityTransformUpdate this[int index]
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

		public GeneratedVector_821ce7913b453c8010d45e123f5f933b_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<EntityTransformUpdate> list = (this.list = new List<EntityTransformUpdate>());
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.NC5CBA9F46D32D05766F60D0B099A849A6DF84F2017E84177AF17E73CA658E441.Helpers.tableReader_dfbdce5851d140c9af91c813ee51e209_GreedyMutable<TInputBuffer> item = FlatSharp.Compiler.Generated.NC5CBA9F46D32D05766F60D0B099A849A6DF84F2017E84177AF17E73CA658E441.Helpers.Parse_GreedyMutable(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private EntityTransformUpdate GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, EntityTransformUpdate value)
		{
			list[index] = value;
		}

		public void Add(EntityTransformUpdate item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, EntityTransformUpdate item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(EntityTransformUpdate item)
		{
			return list.Remove(item);
		}

		public bool Contains(EntityTransformUpdate? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(EntityTransformUpdate? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(EntityTransformUpdate[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<EntityTransformUpdate> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<EntityTransformUpdate> value)
	{
		int count = value.Count;
		int num = 14;
		if (value is EntityTransformUpdate[] array)
		{
			foreach (EntityTransformUpdate entityTransformUpdate in array)
			{
				SerializationHelpers.EnsureNonNull(entityTransformUpdate);
				num += FlatSharp.Compiler.Generated.NC5CBA9F46D32D05766F60D0B099A849A6DF84F2017E84177AF17E73CA658E441.Helpers.GetMaxSize(entityTransformUpdate);
			}
		}
		else if (value is List<EntityTransformUpdate> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				EntityTransformUpdate entityTransformUpdate2 = list[j];
				SerializationHelpers.EnsureNonNull(entityTransformUpdate2);
				num += FlatSharp.Compiler.Generated.NC5CBA9F46D32D05766F60D0B099A849A6DF84F2017E84177AF17E73CA658E441.Helpers.GetMaxSize(entityTransformUpdate2);
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				EntityTransformUpdate entityTransformUpdate3 = value[k];
				SerializationHelpers.EnsureNonNull(entityTransformUpdate3);
				num += FlatSharp.Compiler.Generated.NC5CBA9F46D32D05766F60D0B099A849A6DF84F2017E84177AF17E73CA658E441.Helpers.GetMaxSize(entityTransformUpdate3);
			}
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<EntityTransformUpdate> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 4);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is EntityTransformUpdate[] array)
		{
			foreach (EntityTransformUpdate entityTransformUpdate in array)
			{
				SerializationHelpers.EnsureNonNull(entityTransformUpdate);
				FlatSharp.Compiler.Generated.NC5CBA9F46D32D05766F60D0B099A849A6DF84F2017E84177AF17E73CA658E441.Helpers.Serialize(spanWriter, span, entityTransformUpdate, num, context);
				num += 4;
			}
		}
		else if (value is List<EntityTransformUpdate> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				EntityTransformUpdate entityTransformUpdate2 = list[j];
				SerializationHelpers.EnsureNonNull(entityTransformUpdate2);
				FlatSharp.Compiler.Generated.NC5CBA9F46D32D05766F60D0B099A849A6DF84F2017E84177AF17E73CA658E441.Helpers.Serialize(spanWriter, span, entityTransformUpdate2, num, context);
				num += 4;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				EntityTransformUpdate entityTransformUpdate3 = value[k];
				SerializationHelpers.EnsureNonNull(entityTransformUpdate3);
				FlatSharp.Compiler.Generated.NC5CBA9F46D32D05766F60D0B099A849A6DF84F2017E84177AF17E73CA658E441.Helpers.Serialize(spanWriter, span, entityTransformUpdate3, num, context);
				num += 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<EntityTransformUpdate> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_821ce7913b453c8010d45e123f5f933b_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<EntityTransformUpdate> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_821ce7913b453c8010d45e123f5f933b_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<EntityTransformUpdate> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_821ce7913b453c8010d45e123f5f933b_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<EntityTransformUpdate> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_821ce7913b453c8010d45e123f5f933b_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
