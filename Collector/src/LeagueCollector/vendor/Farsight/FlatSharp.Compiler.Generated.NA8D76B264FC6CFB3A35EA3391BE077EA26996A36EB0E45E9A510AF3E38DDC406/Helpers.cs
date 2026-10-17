using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Sequencer;
using FlatSharp.Compiler.Generated.NC8BCB92545D4FE59D18D5492C3E15DCF9495BB0AACA97222FA214BA02E0B4D4C;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.NA8D76B264FC6CFB3A35EA3391BE077EA26996A36EB0E45E9A510AF3E38DDC406;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ CameraFocusPoint ], Count = {Count}")]
	internal sealed class GeneratedVector_4d33e99c21928f644be2e09eb3572043_Lazy<TInputBuffer> : IList<CameraFocusPoint>, ICollection<CameraFocusPoint>, IEnumerable<CameraFocusPoint>, IEnumerable, IReadOnlyList<CameraFocusPoint>, IReadOnlyCollection<CameraFocusPoint>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public CameraFocusPoint this[int index]
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

		public GeneratedVector_4d33e99c21928f644be2e09eb3572043_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NC8BCB92545D4FE59D18D5492C3E15DCF9495BB0AACA97222FA214BA02E0B4D4C.Helpers.tableReader_acd53a73e39a4b0297768348d9a6eae7_Lazy<TInputBuffer> SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NC8BCB92545D4FE59D18D5492C3E15DCF9495BB0AACA97222FA214BA02E0B4D4C.Helpers.tableReader_acd53a73e39a4b0297768348d9a6eae7_Lazy<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return FlatSharp.Compiler.Generated.NC8BCB92545D4FE59D18D5492C3E15DCF9495BB0AACA97222FA214BA02E0B4D4C.Helpers.Parse_Lazy(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, CameraFocusPoint value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(CameraFocusPoint? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(CameraFocusPoint? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(CameraFocusPoint[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<CameraFocusPoint> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(CameraFocusPoint item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, CameraFocusPoint item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(CameraFocusPoint item)
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

	[DebuggerDisplay("Progressive [ CameraFocusPoint ], Count = {Count}")]
	internal sealed class GeneratedVector_4d33e99c21928f644be2e09eb3572043_Progressive<TInputBuffer> : IList<CameraFocusPoint>, ICollection<CameraFocusPoint>, IEnumerable<CameraFocusPoint>, IEnumerable, IReadOnlyList<CameraFocusPoint>, IReadOnlyCollection<CameraFocusPoint>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly FlatSharp.Compiler.Generated.NC8BCB92545D4FE59D18D5492C3E15DCF9495BB0AACA97222FA214BA02E0B4D4C.Helpers.tableReader_acd53a73e39a4b0297768348d9a6eae7_Progressive<TInputBuffer>?[]?[] items;

		public CameraFocusPoint this[int index]
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

		public GeneratedVector_4d33e99c21928f644be2e09eb3572043_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new FlatSharp.Compiler.Generated.NC8BCB92545D4FE59D18D5492C3E15DCF9495BB0AACA97222FA214BA02E0B4D4C.Helpers.tableReader_acd53a73e39a4b0297768348d9a6eae7_Progressive<TInputBuffer>[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NC8BCB92545D4FE59D18D5492C3E15DCF9495BB0AACA97222FA214BA02E0B4D4C.Helpers.tableReader_acd53a73e39a4b0297768348d9a6eae7_Progressive<TInputBuffer>?[] GetOrCreateRow(FlatSharp.Compiler.Generated.NC8BCB92545D4FE59D18D5492C3E15DCF9495BB0AACA97222FA214BA02E0B4D4C.Helpers.tableReader_acd53a73e39a4b0297768348d9a6eae7_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private FlatSharp.Compiler.Generated.NC8BCB92545D4FE59D18D5492C3E15DCF9495BB0AACA97222FA214BA02E0B4D4C.Helpers.tableReader_acd53a73e39a4b0297768348d9a6eae7_Progressive<TInputBuffer>?[] CreateRow(FlatSharp.Compiler.Generated.NC8BCB92545D4FE59D18D5492C3E15DCF9495BB0AACA97222FA214BA02E0B4D4C.Helpers.tableReader_acd53a73e39a4b0297768348d9a6eae7_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] = new FlatSharp.Compiler.Generated.NC8BCB92545D4FE59D18D5492C3E15DCF9495BB0AACA97222FA214BA02E0B4D4C.Helpers.tableReader_acd53a73e39a4b0297768348d9a6eae7_Progressive<TInputBuffer>[32];
		}

		private FlatSharp.Compiler.Generated.NC8BCB92545D4FE59D18D5492C3E15DCF9495BB0AACA97222FA214BA02E0B4D4C.Helpers.tableReader_acd53a73e39a4b0297768348d9a6eae7_Progressive<TInputBuffer> ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			FlatSharp.Compiler.Generated.NC8BCB92545D4FE59D18D5492C3E15DCF9495BB0AACA97222FA214BA02E0B4D4C.Helpers.tableReader_acd53a73e39a4b0297768348d9a6eae7_Progressive<TInputBuffer>[][] array = items;
			FlatSharp.Compiler.Generated.NC8BCB92545D4FE59D18D5492C3E15DCF9495BB0AACA97222FA214BA02E0B4D4C.Helpers.tableReader_acd53a73e39a4b0297768348d9a6eae7_Progressive<TInputBuffer>[] orCreateRow = GetOrCreateRow(array, rowIndex);
			FlatSharp.Compiler.Generated.NC8BCB92545D4FE59D18D5492C3E15DCF9495BB0AACA97222FA214BA02E0B4D4C.Helpers.tableReader_acd53a73e39a4b0297768348d9a6eae7_Progressive<TInputBuffer> tableReader_acd53a73e39a4b0297768348d9a6eae7_Progressive = orCreateRow[colIndex];
			if (tableReader_acd53a73e39a4b0297768348d9a6eae7_Progressive == null)
			{
				tableReader_acd53a73e39a4b0297768348d9a6eae7_Progressive = (orCreateRow[colIndex] = UnsafeParseItem(index));
			}
			return tableReader_acd53a73e39a4b0297768348d9a6eae7_Progressive;
		}

		private void ProgressiveSet(int index, CameraFocusPoint value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, CameraFocusPoint value)
		{
			VectorUtilities.CheckIndex(index, count);
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NC8BCB92545D4FE59D18D5492C3E15DCF9495BB0AACA97222FA214BA02E0B4D4C.Helpers.tableReader_acd53a73e39a4b0297768348d9a6eae7_Progressive<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NC8BCB92545D4FE59D18D5492C3E15DCF9495BB0AACA97222FA214BA02E0B4D4C.Helpers.tableReader_acd53a73e39a4b0297768348d9a6eae7_Progressive<TInputBuffer> UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.NC8BCB92545D4FE59D18D5492C3E15DCF9495BB0AACA97222FA214BA02E0B4D4C.Helpers.Parse_Progressive(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, CameraFocusPoint value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(CameraFocusPoint? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(CameraFocusPoint? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(CameraFocusPoint[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<CameraFocusPoint> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(CameraFocusPoint item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, CameraFocusPoint item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(CameraFocusPoint item)
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

	[DebuggerDisplay("Greedy [ CameraFocusPoint ], Count = {Count}")]
	internal sealed class GeneratedVector_4d33e99c21928f644be2e09eb3572043_Greedy<TInputBuffer> : IList<CameraFocusPoint>, ICollection<CameraFocusPoint>, IEnumerable<CameraFocusPoint>, IEnumerable, IReadOnlyList<CameraFocusPoint>, IReadOnlyCollection<CameraFocusPoint> where TInputBuffer : IInputBuffer
	{
		private readonly List<FlatSharp.Compiler.Generated.NC8BCB92545D4FE59D18D5492C3E15DCF9495BB0AACA97222FA214BA02E0B4D4C.Helpers.tableReader_acd53a73e39a4b0297768348d9a6eae7_Greedy<TInputBuffer>> list;

		public CameraFocusPoint this[int index]
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

		public GeneratedVector_4d33e99c21928f644be2e09eb3572043_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<FlatSharp.Compiler.Generated.NC8BCB92545D4FE59D18D5492C3E15DCF9495BB0AACA97222FA214BA02E0B4D4C.Helpers.tableReader_acd53a73e39a4b0297768348d9a6eae7_Greedy<TInputBuffer>> list = (this.list = new List<FlatSharp.Compiler.Generated.NC8BCB92545D4FE59D18D5492C3E15DCF9495BB0AACA97222FA214BA02E0B4D4C.Helpers.tableReader_acd53a73e39a4b0297768348d9a6eae7_Greedy<TInputBuffer>>(num));
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.NC8BCB92545D4FE59D18D5492C3E15DCF9495BB0AACA97222FA214BA02E0B4D4C.Helpers.tableReader_acd53a73e39a4b0297768348d9a6eae7_Greedy<TInputBuffer> item = FlatSharp.Compiler.Generated.NC8BCB92545D4FE59D18D5492C3E15DCF9495BB0AACA97222FA214BA02E0B4D4C.Helpers.Parse_Greedy(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		private FlatSharp.Compiler.Generated.NC8BCB92545D4FE59D18D5492C3E15DCF9495BB0AACA97222FA214BA02E0B4D4C.Helpers.tableReader_acd53a73e39a4b0297768348d9a6eae7_Greedy<TInputBuffer> GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, CameraFocusPoint value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(CameraFocusPoint? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(CameraFocusPoint? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(CameraFocusPoint[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<CameraFocusPoint> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(CameraFocusPoint item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, CameraFocusPoint item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(CameraFocusPoint item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ CameraFocusPoint ], Count = {Count}")]
	internal sealed class GeneratedVector_4d33e99c21928f644be2e09eb3572043_GreedyMutable<TInputBuffer> : IList<CameraFocusPoint>, ICollection<CameraFocusPoint>, IEnumerable<CameraFocusPoint>, IEnumerable, IReadOnlyList<CameraFocusPoint>, IReadOnlyCollection<CameraFocusPoint> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<CameraFocusPoint> list;

		public CameraFocusPoint this[int index]
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

		public GeneratedVector_4d33e99c21928f644be2e09eb3572043_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<CameraFocusPoint> list = (this.list = new List<CameraFocusPoint>());
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.NC8BCB92545D4FE59D18D5492C3E15DCF9495BB0AACA97222FA214BA02E0B4D4C.Helpers.tableReader_acd53a73e39a4b0297768348d9a6eae7_GreedyMutable<TInputBuffer> item = FlatSharp.Compiler.Generated.NC8BCB92545D4FE59D18D5492C3E15DCF9495BB0AACA97222FA214BA02E0B4D4C.Helpers.Parse_GreedyMutable(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private CameraFocusPoint GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, CameraFocusPoint value)
		{
			list[index] = value;
		}

		public void Add(CameraFocusPoint item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, CameraFocusPoint item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(CameraFocusPoint item)
		{
			return list.Remove(item);
		}

		public bool Contains(CameraFocusPoint? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(CameraFocusPoint? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(CameraFocusPoint[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<CameraFocusPoint> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<CameraFocusPoint> value)
	{
		int count = value.Count;
		int num = 14;
		if (value is CameraFocusPoint[] array)
		{
			foreach (CameraFocusPoint cameraFocusPoint in array)
			{
				SerializationHelpers.EnsureNonNull(cameraFocusPoint);
				num += FlatSharp.Compiler.Generated.NC8BCB92545D4FE59D18D5492C3E15DCF9495BB0AACA97222FA214BA02E0B4D4C.Helpers.GetMaxSize(cameraFocusPoint);
			}
		}
		else if (value is List<CameraFocusPoint> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				CameraFocusPoint cameraFocusPoint2 = list[j];
				SerializationHelpers.EnsureNonNull(cameraFocusPoint2);
				num += FlatSharp.Compiler.Generated.NC8BCB92545D4FE59D18D5492C3E15DCF9495BB0AACA97222FA214BA02E0B4D4C.Helpers.GetMaxSize(cameraFocusPoint2);
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				CameraFocusPoint cameraFocusPoint3 = value[k];
				SerializationHelpers.EnsureNonNull(cameraFocusPoint3);
				num += FlatSharp.Compiler.Generated.NC8BCB92545D4FE59D18D5492C3E15DCF9495BB0AACA97222FA214BA02E0B4D4C.Helpers.GetMaxSize(cameraFocusPoint3);
			}
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<CameraFocusPoint> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 4);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is CameraFocusPoint[] array)
		{
			foreach (CameraFocusPoint cameraFocusPoint in array)
			{
				SerializationHelpers.EnsureNonNull(cameraFocusPoint);
				FlatSharp.Compiler.Generated.NC8BCB92545D4FE59D18D5492C3E15DCF9495BB0AACA97222FA214BA02E0B4D4C.Helpers.Serialize(spanWriter, span, cameraFocusPoint, num, context);
				num += 4;
			}
		}
		else if (value is List<CameraFocusPoint> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				CameraFocusPoint cameraFocusPoint2 = list[j];
				SerializationHelpers.EnsureNonNull(cameraFocusPoint2);
				FlatSharp.Compiler.Generated.NC8BCB92545D4FE59D18D5492C3E15DCF9495BB0AACA97222FA214BA02E0B4D4C.Helpers.Serialize(spanWriter, span, cameraFocusPoint2, num, context);
				num += 4;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				CameraFocusPoint cameraFocusPoint3 = value[k];
				SerializationHelpers.EnsureNonNull(cameraFocusPoint3);
				FlatSharp.Compiler.Generated.NC8BCB92545D4FE59D18D5492C3E15DCF9495BB0AACA97222FA214BA02E0B4D4C.Helpers.Serialize(spanWriter, span, cameraFocusPoint3, num, context);
				num += 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<CameraFocusPoint> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_4d33e99c21928f644be2e09eb3572043_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<CameraFocusPoint> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_4d33e99c21928f644be2e09eb3572043_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<CameraFocusPoint> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_4d33e99c21928f644be2e09eb3572043_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<CameraFocusPoint> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_4d33e99c21928f644be2e09eb3572043_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
