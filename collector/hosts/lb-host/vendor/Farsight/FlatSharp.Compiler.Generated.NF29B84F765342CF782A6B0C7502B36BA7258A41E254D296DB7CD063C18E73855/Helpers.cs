using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Cinematics;
using FlatSharp.Compiler.Generated.NBA4F4FBA921636BE8B488F2A6F351EA6AB9A48D9AE55A369F1DAE27BD38ACC1F;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.NF29B84F765342CF782A6B0C7502B36BA7258A41E254D296DB7CD063C18E73855;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ CinematicMarker ], Count = {Count}")]
	internal sealed class GeneratedVector_8bbb13eb0c442ce79f2d410a64891730_Lazy<TInputBuffer> : IList<CinematicMarker>, ICollection<CinematicMarker>, IEnumerable<CinematicMarker>, IEnumerable, IReadOnlyList<CinematicMarker>, IReadOnlyCollection<CinematicMarker>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public CinematicMarker this[int index]
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

		public GeneratedVector_8bbb13eb0c442ce79f2d410a64891730_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NBA4F4FBA921636BE8B488F2A6F351EA6AB9A48D9AE55A369F1DAE27BD38ACC1F.Helpers.tableReader_f8b4d25fc22a4dfd9c6a142747fd2520_Lazy<TInputBuffer> SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NBA4F4FBA921636BE8B488F2A6F351EA6AB9A48D9AE55A369F1DAE27BD38ACC1F.Helpers.tableReader_f8b4d25fc22a4dfd9c6a142747fd2520_Lazy<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return FlatSharp.Compiler.Generated.NBA4F4FBA921636BE8B488F2A6F351EA6AB9A48D9AE55A369F1DAE27BD38ACC1F.Helpers.Parse_Lazy(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, CinematicMarker value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(CinematicMarker? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(CinematicMarker? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(CinematicMarker[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<CinematicMarker> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(CinematicMarker item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, CinematicMarker item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(CinematicMarker item)
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

	[DebuggerDisplay("Progressive [ CinematicMarker ], Count = {Count}")]
	internal sealed class GeneratedVector_8bbb13eb0c442ce79f2d410a64891730_Progressive<TInputBuffer> : IList<CinematicMarker>, ICollection<CinematicMarker>, IEnumerable<CinematicMarker>, IEnumerable, IReadOnlyList<CinematicMarker>, IReadOnlyCollection<CinematicMarker>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly FlatSharp.Compiler.Generated.NBA4F4FBA921636BE8B488F2A6F351EA6AB9A48D9AE55A369F1DAE27BD38ACC1F.Helpers.tableReader_f8b4d25fc22a4dfd9c6a142747fd2520_Progressive<TInputBuffer>?[]?[] items;

		public CinematicMarker this[int index]
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

		public GeneratedVector_8bbb13eb0c442ce79f2d410a64891730_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new FlatSharp.Compiler.Generated.NBA4F4FBA921636BE8B488F2A6F351EA6AB9A48D9AE55A369F1DAE27BD38ACC1F.Helpers.tableReader_f8b4d25fc22a4dfd9c6a142747fd2520_Progressive<TInputBuffer>[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NBA4F4FBA921636BE8B488F2A6F351EA6AB9A48D9AE55A369F1DAE27BD38ACC1F.Helpers.tableReader_f8b4d25fc22a4dfd9c6a142747fd2520_Progressive<TInputBuffer>?[] GetOrCreateRow(FlatSharp.Compiler.Generated.NBA4F4FBA921636BE8B488F2A6F351EA6AB9A48D9AE55A369F1DAE27BD38ACC1F.Helpers.tableReader_f8b4d25fc22a4dfd9c6a142747fd2520_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private FlatSharp.Compiler.Generated.NBA4F4FBA921636BE8B488F2A6F351EA6AB9A48D9AE55A369F1DAE27BD38ACC1F.Helpers.tableReader_f8b4d25fc22a4dfd9c6a142747fd2520_Progressive<TInputBuffer>?[] CreateRow(FlatSharp.Compiler.Generated.NBA4F4FBA921636BE8B488F2A6F351EA6AB9A48D9AE55A369F1DAE27BD38ACC1F.Helpers.tableReader_f8b4d25fc22a4dfd9c6a142747fd2520_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] = new FlatSharp.Compiler.Generated.NBA4F4FBA921636BE8B488F2A6F351EA6AB9A48D9AE55A369F1DAE27BD38ACC1F.Helpers.tableReader_f8b4d25fc22a4dfd9c6a142747fd2520_Progressive<TInputBuffer>[32];
		}

		private FlatSharp.Compiler.Generated.NBA4F4FBA921636BE8B488F2A6F351EA6AB9A48D9AE55A369F1DAE27BD38ACC1F.Helpers.tableReader_f8b4d25fc22a4dfd9c6a142747fd2520_Progressive<TInputBuffer> ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			FlatSharp.Compiler.Generated.NBA4F4FBA921636BE8B488F2A6F351EA6AB9A48D9AE55A369F1DAE27BD38ACC1F.Helpers.tableReader_f8b4d25fc22a4dfd9c6a142747fd2520_Progressive<TInputBuffer>[][] array = items;
			FlatSharp.Compiler.Generated.NBA4F4FBA921636BE8B488F2A6F351EA6AB9A48D9AE55A369F1DAE27BD38ACC1F.Helpers.tableReader_f8b4d25fc22a4dfd9c6a142747fd2520_Progressive<TInputBuffer>[] orCreateRow = GetOrCreateRow(array, rowIndex);
			FlatSharp.Compiler.Generated.NBA4F4FBA921636BE8B488F2A6F351EA6AB9A48D9AE55A369F1DAE27BD38ACC1F.Helpers.tableReader_f8b4d25fc22a4dfd9c6a142747fd2520_Progressive<TInputBuffer> tableReader_f8b4d25fc22a4dfd9c6a142747fd2520_Progressive = orCreateRow[colIndex];
			if (tableReader_f8b4d25fc22a4dfd9c6a142747fd2520_Progressive == null)
			{
				tableReader_f8b4d25fc22a4dfd9c6a142747fd2520_Progressive = (orCreateRow[colIndex] = UnsafeParseItem(index));
			}
			return tableReader_f8b4d25fc22a4dfd9c6a142747fd2520_Progressive;
		}

		private void ProgressiveSet(int index, CinematicMarker value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, CinematicMarker value)
		{
			VectorUtilities.CheckIndex(index, count);
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NBA4F4FBA921636BE8B488F2A6F351EA6AB9A48D9AE55A369F1DAE27BD38ACC1F.Helpers.tableReader_f8b4d25fc22a4dfd9c6a142747fd2520_Progressive<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NBA4F4FBA921636BE8B488F2A6F351EA6AB9A48D9AE55A369F1DAE27BD38ACC1F.Helpers.tableReader_f8b4d25fc22a4dfd9c6a142747fd2520_Progressive<TInputBuffer> UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.NBA4F4FBA921636BE8B488F2A6F351EA6AB9A48D9AE55A369F1DAE27BD38ACC1F.Helpers.Parse_Progressive(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, CinematicMarker value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(CinematicMarker? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(CinematicMarker? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(CinematicMarker[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<CinematicMarker> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(CinematicMarker item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, CinematicMarker item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(CinematicMarker item)
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

	[DebuggerDisplay("Greedy [ CinematicMarker ], Count = {Count}")]
	internal sealed class GeneratedVector_8bbb13eb0c442ce79f2d410a64891730_Greedy<TInputBuffer> : IList<CinematicMarker>, ICollection<CinematicMarker>, IEnumerable<CinematicMarker>, IEnumerable, IReadOnlyList<CinematicMarker>, IReadOnlyCollection<CinematicMarker> where TInputBuffer : IInputBuffer
	{
		private readonly List<FlatSharp.Compiler.Generated.NBA4F4FBA921636BE8B488F2A6F351EA6AB9A48D9AE55A369F1DAE27BD38ACC1F.Helpers.tableReader_f8b4d25fc22a4dfd9c6a142747fd2520_Greedy<TInputBuffer>> list;

		public CinematicMarker this[int index]
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

		public GeneratedVector_8bbb13eb0c442ce79f2d410a64891730_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<FlatSharp.Compiler.Generated.NBA4F4FBA921636BE8B488F2A6F351EA6AB9A48D9AE55A369F1DAE27BD38ACC1F.Helpers.tableReader_f8b4d25fc22a4dfd9c6a142747fd2520_Greedy<TInputBuffer>> list = (this.list = new List<FlatSharp.Compiler.Generated.NBA4F4FBA921636BE8B488F2A6F351EA6AB9A48D9AE55A369F1DAE27BD38ACC1F.Helpers.tableReader_f8b4d25fc22a4dfd9c6a142747fd2520_Greedy<TInputBuffer>>(num));
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.NBA4F4FBA921636BE8B488F2A6F351EA6AB9A48D9AE55A369F1DAE27BD38ACC1F.Helpers.tableReader_f8b4d25fc22a4dfd9c6a142747fd2520_Greedy<TInputBuffer> item = FlatSharp.Compiler.Generated.NBA4F4FBA921636BE8B488F2A6F351EA6AB9A48D9AE55A369F1DAE27BD38ACC1F.Helpers.Parse_Greedy(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		private FlatSharp.Compiler.Generated.NBA4F4FBA921636BE8B488F2A6F351EA6AB9A48D9AE55A369F1DAE27BD38ACC1F.Helpers.tableReader_f8b4d25fc22a4dfd9c6a142747fd2520_Greedy<TInputBuffer> GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, CinematicMarker value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(CinematicMarker? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(CinematicMarker? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(CinematicMarker[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<CinematicMarker> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(CinematicMarker item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, CinematicMarker item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(CinematicMarker item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ CinematicMarker ], Count = {Count}")]
	internal sealed class GeneratedVector_8bbb13eb0c442ce79f2d410a64891730_GreedyMutable<TInputBuffer> : IList<CinematicMarker>, ICollection<CinematicMarker>, IEnumerable<CinematicMarker>, IEnumerable, IReadOnlyList<CinematicMarker>, IReadOnlyCollection<CinematicMarker> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<CinematicMarker> list;

		public CinematicMarker this[int index]
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

		public GeneratedVector_8bbb13eb0c442ce79f2d410a64891730_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<CinematicMarker> list = (this.list = new List<CinematicMarker>());
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.NBA4F4FBA921636BE8B488F2A6F351EA6AB9A48D9AE55A369F1DAE27BD38ACC1F.Helpers.tableReader_f8b4d25fc22a4dfd9c6a142747fd2520_GreedyMutable<TInputBuffer> item = FlatSharp.Compiler.Generated.NBA4F4FBA921636BE8B488F2A6F351EA6AB9A48D9AE55A369F1DAE27BD38ACC1F.Helpers.Parse_GreedyMutable(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private CinematicMarker GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, CinematicMarker value)
		{
			list[index] = value;
		}

		public void Add(CinematicMarker item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, CinematicMarker item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(CinematicMarker item)
		{
			return list.Remove(item);
		}

		public bool Contains(CinematicMarker? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(CinematicMarker? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(CinematicMarker[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<CinematicMarker> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<CinematicMarker> value)
	{
		int count = value.Count;
		int num = 14;
		if (value is CinematicMarker[] array)
		{
			foreach (CinematicMarker cinematicMarker in array)
			{
				SerializationHelpers.EnsureNonNull(cinematicMarker);
				num += FlatSharp.Compiler.Generated.NBA4F4FBA921636BE8B488F2A6F351EA6AB9A48D9AE55A369F1DAE27BD38ACC1F.Helpers.GetMaxSize(cinematicMarker);
			}
		}
		else if (value is List<CinematicMarker> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				CinematicMarker cinematicMarker2 = list[j];
				SerializationHelpers.EnsureNonNull(cinematicMarker2);
				num += FlatSharp.Compiler.Generated.NBA4F4FBA921636BE8B488F2A6F351EA6AB9A48D9AE55A369F1DAE27BD38ACC1F.Helpers.GetMaxSize(cinematicMarker2);
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				CinematicMarker cinematicMarker3 = value[k];
				SerializationHelpers.EnsureNonNull(cinematicMarker3);
				num += FlatSharp.Compiler.Generated.NBA4F4FBA921636BE8B488F2A6F351EA6AB9A48D9AE55A369F1DAE27BD38ACC1F.Helpers.GetMaxSize(cinematicMarker3);
			}
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<CinematicMarker> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 4);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is CinematicMarker[] array)
		{
			foreach (CinematicMarker cinematicMarker in array)
			{
				SerializationHelpers.EnsureNonNull(cinematicMarker);
				FlatSharp.Compiler.Generated.NBA4F4FBA921636BE8B488F2A6F351EA6AB9A48D9AE55A369F1DAE27BD38ACC1F.Helpers.Serialize(spanWriter, span, cinematicMarker, num, context);
				num += 4;
			}
		}
		else if (value is List<CinematicMarker> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				CinematicMarker cinematicMarker2 = list[j];
				SerializationHelpers.EnsureNonNull(cinematicMarker2);
				FlatSharp.Compiler.Generated.NBA4F4FBA921636BE8B488F2A6F351EA6AB9A48D9AE55A369F1DAE27BD38ACC1F.Helpers.Serialize(spanWriter, span, cinematicMarker2, num, context);
				num += 4;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				CinematicMarker cinematicMarker3 = value[k];
				SerializationHelpers.EnsureNonNull(cinematicMarker3);
				FlatSharp.Compiler.Generated.NBA4F4FBA921636BE8B488F2A6F351EA6AB9A48D9AE55A369F1DAE27BD38ACC1F.Helpers.Serialize(spanWriter, span, cinematicMarker3, num, context);
				num += 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<CinematicMarker> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_8bbb13eb0c442ce79f2d410a64891730_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<CinematicMarker> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_8bbb13eb0c442ce79f2d410a64891730_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<CinematicMarker> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_8bbb13eb0c442ce79f2d410a64891730_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<CinematicMarker> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_8bbb13eb0c442ce79f2d410a64891730_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
