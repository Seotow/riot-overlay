using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Commands;
using FlatSharp.Compiler.Generated.N4AA2393B091B4E50EB2723BDD8B4386CFFE6D6820AA3F0E4774FE7AB933900E1;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N62E517BBF9CFA8A5343DCD6693A7DF0D05CA6EFBD6A6020C83B8A8AEF75DACE4;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ CameraPreviewCameraDefinition ], Count = {Count}")]
	internal sealed class GeneratedVector_13f603a107357e4992cf08611e1ff0d8_Lazy<TInputBuffer> : IList<CameraPreviewCameraDefinition>, ICollection<CameraPreviewCameraDefinition>, IEnumerable<CameraPreviewCameraDefinition>, IEnumerable, IReadOnlyList<CameraPreviewCameraDefinition>, IReadOnlyCollection<CameraPreviewCameraDefinition>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public CameraPreviewCameraDefinition this[int index]
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

		public GeneratedVector_13f603a107357e4992cf08611e1ff0d8_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N4AA2393B091B4E50EB2723BDD8B4386CFFE6D6820AA3F0E4774FE7AB933900E1.Helpers.tableReader_2291312069dd40a4be2ae3ab364154b1_Lazy<TInputBuffer> SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N4AA2393B091B4E50EB2723BDD8B4386CFFE6D6820AA3F0E4774FE7AB933900E1.Helpers.tableReader_2291312069dd40a4be2ae3ab364154b1_Lazy<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return FlatSharp.Compiler.Generated.N4AA2393B091B4E50EB2723BDD8B4386CFFE6D6820AA3F0E4774FE7AB933900E1.Helpers.Parse_Lazy(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, CameraPreviewCameraDefinition value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(CameraPreviewCameraDefinition? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(CameraPreviewCameraDefinition? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(CameraPreviewCameraDefinition[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<CameraPreviewCameraDefinition> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(CameraPreviewCameraDefinition item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, CameraPreviewCameraDefinition item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(CameraPreviewCameraDefinition item)
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

	[DebuggerDisplay("Progressive [ CameraPreviewCameraDefinition ], Count = {Count}")]
	internal sealed class GeneratedVector_13f603a107357e4992cf08611e1ff0d8_Progressive<TInputBuffer> : IList<CameraPreviewCameraDefinition>, ICollection<CameraPreviewCameraDefinition>, IEnumerable<CameraPreviewCameraDefinition>, IEnumerable, IReadOnlyList<CameraPreviewCameraDefinition>, IReadOnlyCollection<CameraPreviewCameraDefinition>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly FlatSharp.Compiler.Generated.N4AA2393B091B4E50EB2723BDD8B4386CFFE6D6820AA3F0E4774FE7AB933900E1.Helpers.tableReader_2291312069dd40a4be2ae3ab364154b1_Progressive<TInputBuffer>?[]?[] items;

		public CameraPreviewCameraDefinition this[int index]
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

		public GeneratedVector_13f603a107357e4992cf08611e1ff0d8_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new FlatSharp.Compiler.Generated.N4AA2393B091B4E50EB2723BDD8B4386CFFE6D6820AA3F0E4774FE7AB933900E1.Helpers.tableReader_2291312069dd40a4be2ae3ab364154b1_Progressive<TInputBuffer>[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N4AA2393B091B4E50EB2723BDD8B4386CFFE6D6820AA3F0E4774FE7AB933900E1.Helpers.tableReader_2291312069dd40a4be2ae3ab364154b1_Progressive<TInputBuffer>?[] GetOrCreateRow(FlatSharp.Compiler.Generated.N4AA2393B091B4E50EB2723BDD8B4386CFFE6D6820AA3F0E4774FE7AB933900E1.Helpers.tableReader_2291312069dd40a4be2ae3ab364154b1_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private FlatSharp.Compiler.Generated.N4AA2393B091B4E50EB2723BDD8B4386CFFE6D6820AA3F0E4774FE7AB933900E1.Helpers.tableReader_2291312069dd40a4be2ae3ab364154b1_Progressive<TInputBuffer>?[] CreateRow(FlatSharp.Compiler.Generated.N4AA2393B091B4E50EB2723BDD8B4386CFFE6D6820AA3F0E4774FE7AB933900E1.Helpers.tableReader_2291312069dd40a4be2ae3ab364154b1_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] = new FlatSharp.Compiler.Generated.N4AA2393B091B4E50EB2723BDD8B4386CFFE6D6820AA3F0E4774FE7AB933900E1.Helpers.tableReader_2291312069dd40a4be2ae3ab364154b1_Progressive<TInputBuffer>[32];
		}

		private FlatSharp.Compiler.Generated.N4AA2393B091B4E50EB2723BDD8B4386CFFE6D6820AA3F0E4774FE7AB933900E1.Helpers.tableReader_2291312069dd40a4be2ae3ab364154b1_Progressive<TInputBuffer> ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			FlatSharp.Compiler.Generated.N4AA2393B091B4E50EB2723BDD8B4386CFFE6D6820AA3F0E4774FE7AB933900E1.Helpers.tableReader_2291312069dd40a4be2ae3ab364154b1_Progressive<TInputBuffer>[][] array = items;
			FlatSharp.Compiler.Generated.N4AA2393B091B4E50EB2723BDD8B4386CFFE6D6820AA3F0E4774FE7AB933900E1.Helpers.tableReader_2291312069dd40a4be2ae3ab364154b1_Progressive<TInputBuffer>[] orCreateRow = GetOrCreateRow(array, rowIndex);
			FlatSharp.Compiler.Generated.N4AA2393B091B4E50EB2723BDD8B4386CFFE6D6820AA3F0E4774FE7AB933900E1.Helpers.tableReader_2291312069dd40a4be2ae3ab364154b1_Progressive<TInputBuffer> tableReader_2291312069dd40a4be2ae3ab364154b1_Progressive = orCreateRow[colIndex];
			if (tableReader_2291312069dd40a4be2ae3ab364154b1_Progressive == null)
			{
				tableReader_2291312069dd40a4be2ae3ab364154b1_Progressive = (orCreateRow[colIndex] = UnsafeParseItem(index));
			}
			return tableReader_2291312069dd40a4be2ae3ab364154b1_Progressive;
		}

		private void ProgressiveSet(int index, CameraPreviewCameraDefinition value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, CameraPreviewCameraDefinition value)
		{
			VectorUtilities.CheckIndex(index, count);
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N4AA2393B091B4E50EB2723BDD8B4386CFFE6D6820AA3F0E4774FE7AB933900E1.Helpers.tableReader_2291312069dd40a4be2ae3ab364154b1_Progressive<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N4AA2393B091B4E50EB2723BDD8B4386CFFE6D6820AA3F0E4774FE7AB933900E1.Helpers.tableReader_2291312069dd40a4be2ae3ab364154b1_Progressive<TInputBuffer> UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.N4AA2393B091B4E50EB2723BDD8B4386CFFE6D6820AA3F0E4774FE7AB933900E1.Helpers.Parse_Progressive(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, CameraPreviewCameraDefinition value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(CameraPreviewCameraDefinition? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(CameraPreviewCameraDefinition? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(CameraPreviewCameraDefinition[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<CameraPreviewCameraDefinition> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(CameraPreviewCameraDefinition item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, CameraPreviewCameraDefinition item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(CameraPreviewCameraDefinition item)
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

	[DebuggerDisplay("Greedy [ CameraPreviewCameraDefinition ], Count = {Count}")]
	internal sealed class GeneratedVector_13f603a107357e4992cf08611e1ff0d8_Greedy<TInputBuffer> : IList<CameraPreviewCameraDefinition>, ICollection<CameraPreviewCameraDefinition>, IEnumerable<CameraPreviewCameraDefinition>, IEnumerable, IReadOnlyList<CameraPreviewCameraDefinition>, IReadOnlyCollection<CameraPreviewCameraDefinition> where TInputBuffer : IInputBuffer
	{
		private readonly List<FlatSharp.Compiler.Generated.N4AA2393B091B4E50EB2723BDD8B4386CFFE6D6820AA3F0E4774FE7AB933900E1.Helpers.tableReader_2291312069dd40a4be2ae3ab364154b1_Greedy<TInputBuffer>> list;

		public CameraPreviewCameraDefinition this[int index]
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

		public GeneratedVector_13f603a107357e4992cf08611e1ff0d8_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<FlatSharp.Compiler.Generated.N4AA2393B091B4E50EB2723BDD8B4386CFFE6D6820AA3F0E4774FE7AB933900E1.Helpers.tableReader_2291312069dd40a4be2ae3ab364154b1_Greedy<TInputBuffer>> list = (this.list = new List<FlatSharp.Compiler.Generated.N4AA2393B091B4E50EB2723BDD8B4386CFFE6D6820AA3F0E4774FE7AB933900E1.Helpers.tableReader_2291312069dd40a4be2ae3ab364154b1_Greedy<TInputBuffer>>(num));
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.N4AA2393B091B4E50EB2723BDD8B4386CFFE6D6820AA3F0E4774FE7AB933900E1.Helpers.tableReader_2291312069dd40a4be2ae3ab364154b1_Greedy<TInputBuffer> item = FlatSharp.Compiler.Generated.N4AA2393B091B4E50EB2723BDD8B4386CFFE6D6820AA3F0E4774FE7AB933900E1.Helpers.Parse_Greedy(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		private FlatSharp.Compiler.Generated.N4AA2393B091B4E50EB2723BDD8B4386CFFE6D6820AA3F0E4774FE7AB933900E1.Helpers.tableReader_2291312069dd40a4be2ae3ab364154b1_Greedy<TInputBuffer> GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, CameraPreviewCameraDefinition value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(CameraPreviewCameraDefinition? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(CameraPreviewCameraDefinition? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(CameraPreviewCameraDefinition[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<CameraPreviewCameraDefinition> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(CameraPreviewCameraDefinition item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, CameraPreviewCameraDefinition item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(CameraPreviewCameraDefinition item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ CameraPreviewCameraDefinition ], Count = {Count}")]
	internal sealed class GeneratedVector_13f603a107357e4992cf08611e1ff0d8_GreedyMutable<TInputBuffer> : IList<CameraPreviewCameraDefinition>, ICollection<CameraPreviewCameraDefinition>, IEnumerable<CameraPreviewCameraDefinition>, IEnumerable, IReadOnlyList<CameraPreviewCameraDefinition>, IReadOnlyCollection<CameraPreviewCameraDefinition> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<CameraPreviewCameraDefinition> list;

		public CameraPreviewCameraDefinition this[int index]
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

		public GeneratedVector_13f603a107357e4992cf08611e1ff0d8_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<CameraPreviewCameraDefinition> list = (this.list = new List<CameraPreviewCameraDefinition>());
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.N4AA2393B091B4E50EB2723BDD8B4386CFFE6D6820AA3F0E4774FE7AB933900E1.Helpers.tableReader_2291312069dd40a4be2ae3ab364154b1_GreedyMutable<TInputBuffer> item = FlatSharp.Compiler.Generated.N4AA2393B091B4E50EB2723BDD8B4386CFFE6D6820AA3F0E4774FE7AB933900E1.Helpers.Parse_GreedyMutable(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private CameraPreviewCameraDefinition GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, CameraPreviewCameraDefinition value)
		{
			list[index] = value;
		}

		public void Add(CameraPreviewCameraDefinition item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, CameraPreviewCameraDefinition item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(CameraPreviewCameraDefinition item)
		{
			return list.Remove(item);
		}

		public bool Contains(CameraPreviewCameraDefinition? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(CameraPreviewCameraDefinition? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(CameraPreviewCameraDefinition[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<CameraPreviewCameraDefinition> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<CameraPreviewCameraDefinition> value)
	{
		int count = value.Count;
		int num = 14;
		if (value is CameraPreviewCameraDefinition[] array)
		{
			foreach (CameraPreviewCameraDefinition cameraPreviewCameraDefinition in array)
			{
				SerializationHelpers.EnsureNonNull(cameraPreviewCameraDefinition);
				num += FlatSharp.Compiler.Generated.N4AA2393B091B4E50EB2723BDD8B4386CFFE6D6820AA3F0E4774FE7AB933900E1.Helpers.GetMaxSize(cameraPreviewCameraDefinition);
			}
		}
		else if (value is List<CameraPreviewCameraDefinition> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				CameraPreviewCameraDefinition cameraPreviewCameraDefinition2 = list[j];
				SerializationHelpers.EnsureNonNull(cameraPreviewCameraDefinition2);
				num += FlatSharp.Compiler.Generated.N4AA2393B091B4E50EB2723BDD8B4386CFFE6D6820AA3F0E4774FE7AB933900E1.Helpers.GetMaxSize(cameraPreviewCameraDefinition2);
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				CameraPreviewCameraDefinition cameraPreviewCameraDefinition3 = value[k];
				SerializationHelpers.EnsureNonNull(cameraPreviewCameraDefinition3);
				num += FlatSharp.Compiler.Generated.N4AA2393B091B4E50EB2723BDD8B4386CFFE6D6820AA3F0E4774FE7AB933900E1.Helpers.GetMaxSize(cameraPreviewCameraDefinition3);
			}
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<CameraPreviewCameraDefinition> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 4);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is CameraPreviewCameraDefinition[] array)
		{
			foreach (CameraPreviewCameraDefinition cameraPreviewCameraDefinition in array)
			{
				SerializationHelpers.EnsureNonNull(cameraPreviewCameraDefinition);
				FlatSharp.Compiler.Generated.N4AA2393B091B4E50EB2723BDD8B4386CFFE6D6820AA3F0E4774FE7AB933900E1.Helpers.Serialize(spanWriter, span, cameraPreviewCameraDefinition, num, context);
				num += 4;
			}
		}
		else if (value is List<CameraPreviewCameraDefinition> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				CameraPreviewCameraDefinition cameraPreviewCameraDefinition2 = list[j];
				SerializationHelpers.EnsureNonNull(cameraPreviewCameraDefinition2);
				FlatSharp.Compiler.Generated.N4AA2393B091B4E50EB2723BDD8B4386CFFE6D6820AA3F0E4774FE7AB933900E1.Helpers.Serialize(spanWriter, span, cameraPreviewCameraDefinition2, num, context);
				num += 4;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				CameraPreviewCameraDefinition cameraPreviewCameraDefinition3 = value[k];
				SerializationHelpers.EnsureNonNull(cameraPreviewCameraDefinition3);
				FlatSharp.Compiler.Generated.N4AA2393B091B4E50EB2723BDD8B4386CFFE6D6820AA3F0E4774FE7AB933900E1.Helpers.Serialize(spanWriter, span, cameraPreviewCameraDefinition3, num, context);
				num += 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<CameraPreviewCameraDefinition> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_13f603a107357e4992cf08611e1ff0d8_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<CameraPreviewCameraDefinition> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_13f603a107357e4992cf08611e1ff0d8_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<CameraPreviewCameraDefinition> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_13f603a107357e4992cf08611e1ff0d8_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<CameraPreviewCameraDefinition> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_13f603a107357e4992cf08611e1ff0d8_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
