using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Snapshot;
using FlatSharp.Compiler.Generated.N023CDD7C46A20C4DF49619F0352732CA596E04E335F3853D66F3ABD311C3767E;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.NADDCFD1EDEF26C49B891D05E111BB3852F849AF522EDCD0CBB2916B1D2B9AE57;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ StrokeSyncEvent ], Count = {Count}")]
	internal sealed class GeneratedVector_3b4ae98df942b60274ea311fcdcf8636_Lazy<TInputBuffer> : IList<StrokeSyncEvent>, ICollection<StrokeSyncEvent>, IEnumerable<StrokeSyncEvent>, IEnumerable, IReadOnlyList<StrokeSyncEvent>, IReadOnlyCollection<StrokeSyncEvent>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public StrokeSyncEvent this[int index]
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

		public GeneratedVector_3b4ae98df942b60274ea311fcdcf8636_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N023CDD7C46A20C4DF49619F0352732CA596E04E335F3853D66F3ABD311C3767E.Helpers.tableReader_6a3d2ac9d99e415ca759f4366dc86aad_Lazy<TInputBuffer> SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N023CDD7C46A20C4DF49619F0352732CA596E04E335F3853D66F3ABD311C3767E.Helpers.tableReader_6a3d2ac9d99e415ca759f4366dc86aad_Lazy<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return FlatSharp.Compiler.Generated.N023CDD7C46A20C4DF49619F0352732CA596E04E335F3853D66F3ABD311C3767E.Helpers.Parse_Lazy(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, StrokeSyncEvent value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(StrokeSyncEvent? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(StrokeSyncEvent? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(StrokeSyncEvent[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<StrokeSyncEvent> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(StrokeSyncEvent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, StrokeSyncEvent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(StrokeSyncEvent item)
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

	[DebuggerDisplay("Progressive [ StrokeSyncEvent ], Count = {Count}")]
	internal sealed class GeneratedVector_3b4ae98df942b60274ea311fcdcf8636_Progressive<TInputBuffer> : IList<StrokeSyncEvent>, ICollection<StrokeSyncEvent>, IEnumerable<StrokeSyncEvent>, IEnumerable, IReadOnlyList<StrokeSyncEvent>, IReadOnlyCollection<StrokeSyncEvent>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly FlatSharp.Compiler.Generated.N023CDD7C46A20C4DF49619F0352732CA596E04E335F3853D66F3ABD311C3767E.Helpers.tableReader_6a3d2ac9d99e415ca759f4366dc86aad_Progressive<TInputBuffer>?[]?[] items;

		public StrokeSyncEvent this[int index]
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

		public GeneratedVector_3b4ae98df942b60274ea311fcdcf8636_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new FlatSharp.Compiler.Generated.N023CDD7C46A20C4DF49619F0352732CA596E04E335F3853D66F3ABD311C3767E.Helpers.tableReader_6a3d2ac9d99e415ca759f4366dc86aad_Progressive<TInputBuffer>[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N023CDD7C46A20C4DF49619F0352732CA596E04E335F3853D66F3ABD311C3767E.Helpers.tableReader_6a3d2ac9d99e415ca759f4366dc86aad_Progressive<TInputBuffer>?[] GetOrCreateRow(FlatSharp.Compiler.Generated.N023CDD7C46A20C4DF49619F0352732CA596E04E335F3853D66F3ABD311C3767E.Helpers.tableReader_6a3d2ac9d99e415ca759f4366dc86aad_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private FlatSharp.Compiler.Generated.N023CDD7C46A20C4DF49619F0352732CA596E04E335F3853D66F3ABD311C3767E.Helpers.tableReader_6a3d2ac9d99e415ca759f4366dc86aad_Progressive<TInputBuffer>?[] CreateRow(FlatSharp.Compiler.Generated.N023CDD7C46A20C4DF49619F0352732CA596E04E335F3853D66F3ABD311C3767E.Helpers.tableReader_6a3d2ac9d99e415ca759f4366dc86aad_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] = new FlatSharp.Compiler.Generated.N023CDD7C46A20C4DF49619F0352732CA596E04E335F3853D66F3ABD311C3767E.Helpers.tableReader_6a3d2ac9d99e415ca759f4366dc86aad_Progressive<TInputBuffer>[32];
		}

		private FlatSharp.Compiler.Generated.N023CDD7C46A20C4DF49619F0352732CA596E04E335F3853D66F3ABD311C3767E.Helpers.tableReader_6a3d2ac9d99e415ca759f4366dc86aad_Progressive<TInputBuffer> ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			FlatSharp.Compiler.Generated.N023CDD7C46A20C4DF49619F0352732CA596E04E335F3853D66F3ABD311C3767E.Helpers.tableReader_6a3d2ac9d99e415ca759f4366dc86aad_Progressive<TInputBuffer>[][] array = items;
			FlatSharp.Compiler.Generated.N023CDD7C46A20C4DF49619F0352732CA596E04E335F3853D66F3ABD311C3767E.Helpers.tableReader_6a3d2ac9d99e415ca759f4366dc86aad_Progressive<TInputBuffer>[] orCreateRow = GetOrCreateRow(array, rowIndex);
			FlatSharp.Compiler.Generated.N023CDD7C46A20C4DF49619F0352732CA596E04E335F3853D66F3ABD311C3767E.Helpers.tableReader_6a3d2ac9d99e415ca759f4366dc86aad_Progressive<TInputBuffer> tableReader_6a3d2ac9d99e415ca759f4366dc86aad_Progressive = orCreateRow[colIndex];
			if (tableReader_6a3d2ac9d99e415ca759f4366dc86aad_Progressive == null)
			{
				tableReader_6a3d2ac9d99e415ca759f4366dc86aad_Progressive = (orCreateRow[colIndex] = UnsafeParseItem(index));
			}
			return tableReader_6a3d2ac9d99e415ca759f4366dc86aad_Progressive;
		}

		private void ProgressiveSet(int index, StrokeSyncEvent value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, StrokeSyncEvent value)
		{
			VectorUtilities.CheckIndex(index, count);
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N023CDD7C46A20C4DF49619F0352732CA596E04E335F3853D66F3ABD311C3767E.Helpers.tableReader_6a3d2ac9d99e415ca759f4366dc86aad_Progressive<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N023CDD7C46A20C4DF49619F0352732CA596E04E335F3853D66F3ABD311C3767E.Helpers.tableReader_6a3d2ac9d99e415ca759f4366dc86aad_Progressive<TInputBuffer> UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.N023CDD7C46A20C4DF49619F0352732CA596E04E335F3853D66F3ABD311C3767E.Helpers.Parse_Progressive(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, StrokeSyncEvent value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(StrokeSyncEvent? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(StrokeSyncEvent? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(StrokeSyncEvent[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<StrokeSyncEvent> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(StrokeSyncEvent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, StrokeSyncEvent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(StrokeSyncEvent item)
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

	[DebuggerDisplay("Greedy [ StrokeSyncEvent ], Count = {Count}")]
	internal sealed class GeneratedVector_3b4ae98df942b60274ea311fcdcf8636_Greedy<TInputBuffer> : IList<StrokeSyncEvent>, ICollection<StrokeSyncEvent>, IEnumerable<StrokeSyncEvent>, IEnumerable, IReadOnlyList<StrokeSyncEvent>, IReadOnlyCollection<StrokeSyncEvent> where TInputBuffer : IInputBuffer
	{
		private readonly List<FlatSharp.Compiler.Generated.N023CDD7C46A20C4DF49619F0352732CA596E04E335F3853D66F3ABD311C3767E.Helpers.tableReader_6a3d2ac9d99e415ca759f4366dc86aad_Greedy<TInputBuffer>> list;

		public StrokeSyncEvent this[int index]
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

		public GeneratedVector_3b4ae98df942b60274ea311fcdcf8636_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<FlatSharp.Compiler.Generated.N023CDD7C46A20C4DF49619F0352732CA596E04E335F3853D66F3ABD311C3767E.Helpers.tableReader_6a3d2ac9d99e415ca759f4366dc86aad_Greedy<TInputBuffer>> list = (this.list = new List<FlatSharp.Compiler.Generated.N023CDD7C46A20C4DF49619F0352732CA596E04E335F3853D66F3ABD311C3767E.Helpers.tableReader_6a3d2ac9d99e415ca759f4366dc86aad_Greedy<TInputBuffer>>(num));
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.N023CDD7C46A20C4DF49619F0352732CA596E04E335F3853D66F3ABD311C3767E.Helpers.tableReader_6a3d2ac9d99e415ca759f4366dc86aad_Greedy<TInputBuffer> item = FlatSharp.Compiler.Generated.N023CDD7C46A20C4DF49619F0352732CA596E04E335F3853D66F3ABD311C3767E.Helpers.Parse_Greedy(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		private FlatSharp.Compiler.Generated.N023CDD7C46A20C4DF49619F0352732CA596E04E335F3853D66F3ABD311C3767E.Helpers.tableReader_6a3d2ac9d99e415ca759f4366dc86aad_Greedy<TInputBuffer> GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, StrokeSyncEvent value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(StrokeSyncEvent? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(StrokeSyncEvent? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(StrokeSyncEvent[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<StrokeSyncEvent> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(StrokeSyncEvent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, StrokeSyncEvent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(StrokeSyncEvent item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ StrokeSyncEvent ], Count = {Count}")]
	internal sealed class GeneratedVector_3b4ae98df942b60274ea311fcdcf8636_GreedyMutable<TInputBuffer> : IList<StrokeSyncEvent>, ICollection<StrokeSyncEvent>, IEnumerable<StrokeSyncEvent>, IEnumerable, IReadOnlyList<StrokeSyncEvent>, IReadOnlyCollection<StrokeSyncEvent> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<StrokeSyncEvent> list;

		public StrokeSyncEvent this[int index]
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

		public GeneratedVector_3b4ae98df942b60274ea311fcdcf8636_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<StrokeSyncEvent> list = (this.list = new List<StrokeSyncEvent>());
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.N023CDD7C46A20C4DF49619F0352732CA596E04E335F3853D66F3ABD311C3767E.Helpers.tableReader_6a3d2ac9d99e415ca759f4366dc86aad_GreedyMutable<TInputBuffer> item = FlatSharp.Compiler.Generated.N023CDD7C46A20C4DF49619F0352732CA596E04E335F3853D66F3ABD311C3767E.Helpers.Parse_GreedyMutable(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private StrokeSyncEvent GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, StrokeSyncEvent value)
		{
			list[index] = value;
		}

		public void Add(StrokeSyncEvent item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, StrokeSyncEvent item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(StrokeSyncEvent item)
		{
			return list.Remove(item);
		}

		public bool Contains(StrokeSyncEvent? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(StrokeSyncEvent? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(StrokeSyncEvent[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<StrokeSyncEvent> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<StrokeSyncEvent> value)
	{
		int count = value.Count;
		int num = 14;
		if (value is StrokeSyncEvent[] array)
		{
			foreach (StrokeSyncEvent strokeSyncEvent in array)
			{
				SerializationHelpers.EnsureNonNull(strokeSyncEvent);
				num += FlatSharp.Compiler.Generated.N023CDD7C46A20C4DF49619F0352732CA596E04E335F3853D66F3ABD311C3767E.Helpers.GetMaxSize(strokeSyncEvent);
			}
		}
		else if (value is List<StrokeSyncEvent> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				StrokeSyncEvent strokeSyncEvent2 = list[j];
				SerializationHelpers.EnsureNonNull(strokeSyncEvent2);
				num += FlatSharp.Compiler.Generated.N023CDD7C46A20C4DF49619F0352732CA596E04E335F3853D66F3ABD311C3767E.Helpers.GetMaxSize(strokeSyncEvent2);
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				StrokeSyncEvent strokeSyncEvent3 = value[k];
				SerializationHelpers.EnsureNonNull(strokeSyncEvent3);
				num += FlatSharp.Compiler.Generated.N023CDD7C46A20C4DF49619F0352732CA596E04E335F3853D66F3ABD311C3767E.Helpers.GetMaxSize(strokeSyncEvent3);
			}
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<StrokeSyncEvent> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 4);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is StrokeSyncEvent[] array)
		{
			foreach (StrokeSyncEvent strokeSyncEvent in array)
			{
				SerializationHelpers.EnsureNonNull(strokeSyncEvent);
				FlatSharp.Compiler.Generated.N023CDD7C46A20C4DF49619F0352732CA596E04E335F3853D66F3ABD311C3767E.Helpers.Serialize(spanWriter, span, strokeSyncEvent, num, context);
				num += 4;
			}
		}
		else if (value is List<StrokeSyncEvent> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				StrokeSyncEvent strokeSyncEvent2 = list[j];
				SerializationHelpers.EnsureNonNull(strokeSyncEvent2);
				FlatSharp.Compiler.Generated.N023CDD7C46A20C4DF49619F0352732CA596E04E335F3853D66F3ABD311C3767E.Helpers.Serialize(spanWriter, span, strokeSyncEvent2, num, context);
				num += 4;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				StrokeSyncEvent strokeSyncEvent3 = value[k];
				SerializationHelpers.EnsureNonNull(strokeSyncEvent3);
				FlatSharp.Compiler.Generated.N023CDD7C46A20C4DF49619F0352732CA596E04E335F3853D66F3ABD311C3767E.Helpers.Serialize(spanWriter, span, strokeSyncEvent3, num, context);
				num += 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<StrokeSyncEvent> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_3b4ae98df942b60274ea311fcdcf8636_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<StrokeSyncEvent> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_3b4ae98df942b60274ea311fcdcf8636_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<StrokeSyncEvent> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_3b4ae98df942b60274ea311fcdcf8636_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<StrokeSyncEvent> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_3b4ae98df942b60274ea311fcdcf8636_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
