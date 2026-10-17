using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Commands;
using FlatSharp.Compiler.Generated.N49BE983C75BF1E7FAEBEFFEC995036CA8AAFCF41905FC19546BC0DC8901520B1;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N5E28C9120AF63AE77EDFC16A2BECFD971FB0B778301849E74A4DF9CBB79D28DC;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ CameraPreviewCameraSource ], Count = {Count}")]
	internal sealed class GeneratedVector_f83c40d910c65380f98c809c8f334296_Lazy<TInputBuffer> : IList<CameraPreviewCameraSource>, ICollection<CameraPreviewCameraSource>, IEnumerable<CameraPreviewCameraSource>, IEnumerable, IReadOnlyList<CameraPreviewCameraSource>, IReadOnlyCollection<CameraPreviewCameraSource>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public CameraPreviewCameraSource this[int index]
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

		public GeneratedVector_f83c40d910c65380f98c809c8f334296_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N49BE983C75BF1E7FAEBEFFEC995036CA8AAFCF41905FC19546BC0DC8901520B1.Helpers.tableReader_b19239adce8d4bd39c4833407cfa783f_Lazy<TInputBuffer> SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N49BE983C75BF1E7FAEBEFFEC995036CA8AAFCF41905FC19546BC0DC8901520B1.Helpers.tableReader_b19239adce8d4bd39c4833407cfa783f_Lazy<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return FlatSharp.Compiler.Generated.N49BE983C75BF1E7FAEBEFFEC995036CA8AAFCF41905FC19546BC0DC8901520B1.Helpers.Parse_Lazy(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, CameraPreviewCameraSource value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(CameraPreviewCameraSource? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(CameraPreviewCameraSource? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(CameraPreviewCameraSource[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<CameraPreviewCameraSource> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(CameraPreviewCameraSource item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, CameraPreviewCameraSource item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(CameraPreviewCameraSource item)
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

	[DebuggerDisplay("Progressive [ CameraPreviewCameraSource ], Count = {Count}")]
	internal sealed class GeneratedVector_f83c40d910c65380f98c809c8f334296_Progressive<TInputBuffer> : IList<CameraPreviewCameraSource>, ICollection<CameraPreviewCameraSource>, IEnumerable<CameraPreviewCameraSource>, IEnumerable, IReadOnlyList<CameraPreviewCameraSource>, IReadOnlyCollection<CameraPreviewCameraSource>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly FlatSharp.Compiler.Generated.N49BE983C75BF1E7FAEBEFFEC995036CA8AAFCF41905FC19546BC0DC8901520B1.Helpers.tableReader_b19239adce8d4bd39c4833407cfa783f_Progressive<TInputBuffer>?[]?[] items;

		public CameraPreviewCameraSource this[int index]
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

		public GeneratedVector_f83c40d910c65380f98c809c8f334296_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new FlatSharp.Compiler.Generated.N49BE983C75BF1E7FAEBEFFEC995036CA8AAFCF41905FC19546BC0DC8901520B1.Helpers.tableReader_b19239adce8d4bd39c4833407cfa783f_Progressive<TInputBuffer>[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N49BE983C75BF1E7FAEBEFFEC995036CA8AAFCF41905FC19546BC0DC8901520B1.Helpers.tableReader_b19239adce8d4bd39c4833407cfa783f_Progressive<TInputBuffer>?[] GetOrCreateRow(FlatSharp.Compiler.Generated.N49BE983C75BF1E7FAEBEFFEC995036CA8AAFCF41905FC19546BC0DC8901520B1.Helpers.tableReader_b19239adce8d4bd39c4833407cfa783f_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private FlatSharp.Compiler.Generated.N49BE983C75BF1E7FAEBEFFEC995036CA8AAFCF41905FC19546BC0DC8901520B1.Helpers.tableReader_b19239adce8d4bd39c4833407cfa783f_Progressive<TInputBuffer>?[] CreateRow(FlatSharp.Compiler.Generated.N49BE983C75BF1E7FAEBEFFEC995036CA8AAFCF41905FC19546BC0DC8901520B1.Helpers.tableReader_b19239adce8d4bd39c4833407cfa783f_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] = new FlatSharp.Compiler.Generated.N49BE983C75BF1E7FAEBEFFEC995036CA8AAFCF41905FC19546BC0DC8901520B1.Helpers.tableReader_b19239adce8d4bd39c4833407cfa783f_Progressive<TInputBuffer>[32];
		}

		private FlatSharp.Compiler.Generated.N49BE983C75BF1E7FAEBEFFEC995036CA8AAFCF41905FC19546BC0DC8901520B1.Helpers.tableReader_b19239adce8d4bd39c4833407cfa783f_Progressive<TInputBuffer> ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			FlatSharp.Compiler.Generated.N49BE983C75BF1E7FAEBEFFEC995036CA8AAFCF41905FC19546BC0DC8901520B1.Helpers.tableReader_b19239adce8d4bd39c4833407cfa783f_Progressive<TInputBuffer>[][] array = items;
			FlatSharp.Compiler.Generated.N49BE983C75BF1E7FAEBEFFEC995036CA8AAFCF41905FC19546BC0DC8901520B1.Helpers.tableReader_b19239adce8d4bd39c4833407cfa783f_Progressive<TInputBuffer>[] orCreateRow = GetOrCreateRow(array, rowIndex);
			FlatSharp.Compiler.Generated.N49BE983C75BF1E7FAEBEFFEC995036CA8AAFCF41905FC19546BC0DC8901520B1.Helpers.tableReader_b19239adce8d4bd39c4833407cfa783f_Progressive<TInputBuffer> tableReader_b19239adce8d4bd39c4833407cfa783f_Progressive = orCreateRow[colIndex];
			if (tableReader_b19239adce8d4bd39c4833407cfa783f_Progressive == null)
			{
				tableReader_b19239adce8d4bd39c4833407cfa783f_Progressive = (orCreateRow[colIndex] = UnsafeParseItem(index));
			}
			return tableReader_b19239adce8d4bd39c4833407cfa783f_Progressive;
		}

		private void ProgressiveSet(int index, CameraPreviewCameraSource value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, CameraPreviewCameraSource value)
		{
			VectorUtilities.CheckIndex(index, count);
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N49BE983C75BF1E7FAEBEFFEC995036CA8AAFCF41905FC19546BC0DC8901520B1.Helpers.tableReader_b19239adce8d4bd39c4833407cfa783f_Progressive<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N49BE983C75BF1E7FAEBEFFEC995036CA8AAFCF41905FC19546BC0DC8901520B1.Helpers.tableReader_b19239adce8d4bd39c4833407cfa783f_Progressive<TInputBuffer> UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.N49BE983C75BF1E7FAEBEFFEC995036CA8AAFCF41905FC19546BC0DC8901520B1.Helpers.Parse_Progressive(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, CameraPreviewCameraSource value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(CameraPreviewCameraSource? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(CameraPreviewCameraSource? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(CameraPreviewCameraSource[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<CameraPreviewCameraSource> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(CameraPreviewCameraSource item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, CameraPreviewCameraSource item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(CameraPreviewCameraSource item)
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

	[DebuggerDisplay("Greedy [ CameraPreviewCameraSource ], Count = {Count}")]
	internal sealed class GeneratedVector_f83c40d910c65380f98c809c8f334296_Greedy<TInputBuffer> : IList<CameraPreviewCameraSource>, ICollection<CameraPreviewCameraSource>, IEnumerable<CameraPreviewCameraSource>, IEnumerable, IReadOnlyList<CameraPreviewCameraSource>, IReadOnlyCollection<CameraPreviewCameraSource> where TInputBuffer : IInputBuffer
	{
		private readonly List<FlatSharp.Compiler.Generated.N49BE983C75BF1E7FAEBEFFEC995036CA8AAFCF41905FC19546BC0DC8901520B1.Helpers.tableReader_b19239adce8d4bd39c4833407cfa783f_Greedy<TInputBuffer>> list;

		public CameraPreviewCameraSource this[int index]
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

		public GeneratedVector_f83c40d910c65380f98c809c8f334296_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<FlatSharp.Compiler.Generated.N49BE983C75BF1E7FAEBEFFEC995036CA8AAFCF41905FC19546BC0DC8901520B1.Helpers.tableReader_b19239adce8d4bd39c4833407cfa783f_Greedy<TInputBuffer>> list = (this.list = new List<FlatSharp.Compiler.Generated.N49BE983C75BF1E7FAEBEFFEC995036CA8AAFCF41905FC19546BC0DC8901520B1.Helpers.tableReader_b19239adce8d4bd39c4833407cfa783f_Greedy<TInputBuffer>>(num));
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.N49BE983C75BF1E7FAEBEFFEC995036CA8AAFCF41905FC19546BC0DC8901520B1.Helpers.tableReader_b19239adce8d4bd39c4833407cfa783f_Greedy<TInputBuffer> item = FlatSharp.Compiler.Generated.N49BE983C75BF1E7FAEBEFFEC995036CA8AAFCF41905FC19546BC0DC8901520B1.Helpers.Parse_Greedy(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		private FlatSharp.Compiler.Generated.N49BE983C75BF1E7FAEBEFFEC995036CA8AAFCF41905FC19546BC0DC8901520B1.Helpers.tableReader_b19239adce8d4bd39c4833407cfa783f_Greedy<TInputBuffer> GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, CameraPreviewCameraSource value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(CameraPreviewCameraSource? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(CameraPreviewCameraSource? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(CameraPreviewCameraSource[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<CameraPreviewCameraSource> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(CameraPreviewCameraSource item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, CameraPreviewCameraSource item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(CameraPreviewCameraSource item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ CameraPreviewCameraSource ], Count = {Count}")]
	internal sealed class GeneratedVector_f83c40d910c65380f98c809c8f334296_GreedyMutable<TInputBuffer> : IList<CameraPreviewCameraSource>, ICollection<CameraPreviewCameraSource>, IEnumerable<CameraPreviewCameraSource>, IEnumerable, IReadOnlyList<CameraPreviewCameraSource>, IReadOnlyCollection<CameraPreviewCameraSource> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<CameraPreviewCameraSource> list;

		public CameraPreviewCameraSource this[int index]
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

		public GeneratedVector_f83c40d910c65380f98c809c8f334296_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<CameraPreviewCameraSource> list = (this.list = new List<CameraPreviewCameraSource>());
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.N49BE983C75BF1E7FAEBEFFEC995036CA8AAFCF41905FC19546BC0DC8901520B1.Helpers.tableReader_b19239adce8d4bd39c4833407cfa783f_GreedyMutable<TInputBuffer> item = FlatSharp.Compiler.Generated.N49BE983C75BF1E7FAEBEFFEC995036CA8AAFCF41905FC19546BC0DC8901520B1.Helpers.Parse_GreedyMutable(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private CameraPreviewCameraSource GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, CameraPreviewCameraSource value)
		{
			list[index] = value;
		}

		public void Add(CameraPreviewCameraSource item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, CameraPreviewCameraSource item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(CameraPreviewCameraSource item)
		{
			return list.Remove(item);
		}

		public bool Contains(CameraPreviewCameraSource? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(CameraPreviewCameraSource? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(CameraPreviewCameraSource[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<CameraPreviewCameraSource> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<CameraPreviewCameraSource> value)
	{
		int count = value.Count;
		int num = 14;
		if (value is CameraPreviewCameraSource[] array)
		{
			foreach (CameraPreviewCameraSource cameraPreviewCameraSource in array)
			{
				SerializationHelpers.EnsureNonNull(cameraPreviewCameraSource);
				num += FlatSharp.Compiler.Generated.N49BE983C75BF1E7FAEBEFFEC995036CA8AAFCF41905FC19546BC0DC8901520B1.Helpers.GetMaxSize(cameraPreviewCameraSource);
			}
		}
		else if (value is List<CameraPreviewCameraSource> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				CameraPreviewCameraSource cameraPreviewCameraSource2 = list[j];
				SerializationHelpers.EnsureNonNull(cameraPreviewCameraSource2);
				num += FlatSharp.Compiler.Generated.N49BE983C75BF1E7FAEBEFFEC995036CA8AAFCF41905FC19546BC0DC8901520B1.Helpers.GetMaxSize(cameraPreviewCameraSource2);
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				CameraPreviewCameraSource cameraPreviewCameraSource3 = value[k];
				SerializationHelpers.EnsureNonNull(cameraPreviewCameraSource3);
				num += FlatSharp.Compiler.Generated.N49BE983C75BF1E7FAEBEFFEC995036CA8AAFCF41905FC19546BC0DC8901520B1.Helpers.GetMaxSize(cameraPreviewCameraSource3);
			}
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<CameraPreviewCameraSource> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 4);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is CameraPreviewCameraSource[] array)
		{
			foreach (CameraPreviewCameraSource cameraPreviewCameraSource in array)
			{
				SerializationHelpers.EnsureNonNull(cameraPreviewCameraSource);
				FlatSharp.Compiler.Generated.N49BE983C75BF1E7FAEBEFFEC995036CA8AAFCF41905FC19546BC0DC8901520B1.Helpers.Serialize(spanWriter, span, cameraPreviewCameraSource, num, context);
				num += 4;
			}
		}
		else if (value is List<CameraPreviewCameraSource> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				CameraPreviewCameraSource cameraPreviewCameraSource2 = list[j];
				SerializationHelpers.EnsureNonNull(cameraPreviewCameraSource2);
				FlatSharp.Compiler.Generated.N49BE983C75BF1E7FAEBEFFEC995036CA8AAFCF41905FC19546BC0DC8901520B1.Helpers.Serialize(spanWriter, span, cameraPreviewCameraSource2, num, context);
				num += 4;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				CameraPreviewCameraSource cameraPreviewCameraSource3 = value[k];
				SerializationHelpers.EnsureNonNull(cameraPreviewCameraSource3);
				FlatSharp.Compiler.Generated.N49BE983C75BF1E7FAEBEFFEC995036CA8AAFCF41905FC19546BC0DC8901520B1.Helpers.Serialize(spanWriter, span, cameraPreviewCameraSource3, num, context);
				num += 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<CameraPreviewCameraSource> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_f83c40d910c65380f98c809c8f334296_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<CameraPreviewCameraSource> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_f83c40d910c65380f98c809c8f334296_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<CameraPreviewCameraSource> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_f83c40d910c65380f98c809c8f334296_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<CameraPreviewCameraSource> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_f83c40d910c65380f98c809c8f334296_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
