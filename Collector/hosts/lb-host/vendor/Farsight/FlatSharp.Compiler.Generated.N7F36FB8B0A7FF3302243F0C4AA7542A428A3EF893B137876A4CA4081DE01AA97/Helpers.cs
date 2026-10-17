using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Commands;
using FlatSharp.Compiler.Generated.NC5ED364154C495EC121D4C459B45500CDEA8C30152693D7AB19A697367DB3A52;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N7F36FB8B0A7FF3302243F0C4AA7542A428A3EF893B137876A4CA4081DE01AA97;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ CameraPreviewDirectorTarget ], Count = {Count}")]
	internal sealed class GeneratedVector_f8d8a509c50d98f08aed9b77a47d4837_Lazy<TInputBuffer> : IList<CameraPreviewDirectorTarget>, ICollection<CameraPreviewDirectorTarget>, IEnumerable<CameraPreviewDirectorTarget>, IEnumerable, IReadOnlyList<CameraPreviewDirectorTarget>, IReadOnlyCollection<CameraPreviewDirectorTarget>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public CameraPreviewDirectorTarget this[int index]
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

		public GeneratedVector_f8d8a509c50d98f08aed9b77a47d4837_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NC5ED364154C495EC121D4C459B45500CDEA8C30152693D7AB19A697367DB3A52.Helpers.tableReader_a32ed448130147bc90c4d76bf3225e28_Lazy<TInputBuffer> SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NC5ED364154C495EC121D4C459B45500CDEA8C30152693D7AB19A697367DB3A52.Helpers.tableReader_a32ed448130147bc90c4d76bf3225e28_Lazy<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return FlatSharp.Compiler.Generated.NC5ED364154C495EC121D4C459B45500CDEA8C30152693D7AB19A697367DB3A52.Helpers.Parse_Lazy(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, CameraPreviewDirectorTarget value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(CameraPreviewDirectorTarget? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(CameraPreviewDirectorTarget? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(CameraPreviewDirectorTarget[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<CameraPreviewDirectorTarget> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(CameraPreviewDirectorTarget item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, CameraPreviewDirectorTarget item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(CameraPreviewDirectorTarget item)
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

	[DebuggerDisplay("Progressive [ CameraPreviewDirectorTarget ], Count = {Count}")]
	internal sealed class GeneratedVector_f8d8a509c50d98f08aed9b77a47d4837_Progressive<TInputBuffer> : IList<CameraPreviewDirectorTarget>, ICollection<CameraPreviewDirectorTarget>, IEnumerable<CameraPreviewDirectorTarget>, IEnumerable, IReadOnlyList<CameraPreviewDirectorTarget>, IReadOnlyCollection<CameraPreviewDirectorTarget>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly FlatSharp.Compiler.Generated.NC5ED364154C495EC121D4C459B45500CDEA8C30152693D7AB19A697367DB3A52.Helpers.tableReader_a32ed448130147bc90c4d76bf3225e28_Progressive<TInputBuffer>?[]?[] items;

		public CameraPreviewDirectorTarget this[int index]
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

		public GeneratedVector_f8d8a509c50d98f08aed9b77a47d4837_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new FlatSharp.Compiler.Generated.NC5ED364154C495EC121D4C459B45500CDEA8C30152693D7AB19A697367DB3A52.Helpers.tableReader_a32ed448130147bc90c4d76bf3225e28_Progressive<TInputBuffer>[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NC5ED364154C495EC121D4C459B45500CDEA8C30152693D7AB19A697367DB3A52.Helpers.tableReader_a32ed448130147bc90c4d76bf3225e28_Progressive<TInputBuffer>?[] GetOrCreateRow(FlatSharp.Compiler.Generated.NC5ED364154C495EC121D4C459B45500CDEA8C30152693D7AB19A697367DB3A52.Helpers.tableReader_a32ed448130147bc90c4d76bf3225e28_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private FlatSharp.Compiler.Generated.NC5ED364154C495EC121D4C459B45500CDEA8C30152693D7AB19A697367DB3A52.Helpers.tableReader_a32ed448130147bc90c4d76bf3225e28_Progressive<TInputBuffer>?[] CreateRow(FlatSharp.Compiler.Generated.NC5ED364154C495EC121D4C459B45500CDEA8C30152693D7AB19A697367DB3A52.Helpers.tableReader_a32ed448130147bc90c4d76bf3225e28_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] = new FlatSharp.Compiler.Generated.NC5ED364154C495EC121D4C459B45500CDEA8C30152693D7AB19A697367DB3A52.Helpers.tableReader_a32ed448130147bc90c4d76bf3225e28_Progressive<TInputBuffer>[32];
		}

		private FlatSharp.Compiler.Generated.NC5ED364154C495EC121D4C459B45500CDEA8C30152693D7AB19A697367DB3A52.Helpers.tableReader_a32ed448130147bc90c4d76bf3225e28_Progressive<TInputBuffer> ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			FlatSharp.Compiler.Generated.NC5ED364154C495EC121D4C459B45500CDEA8C30152693D7AB19A697367DB3A52.Helpers.tableReader_a32ed448130147bc90c4d76bf3225e28_Progressive<TInputBuffer>[][] array = items;
			FlatSharp.Compiler.Generated.NC5ED364154C495EC121D4C459B45500CDEA8C30152693D7AB19A697367DB3A52.Helpers.tableReader_a32ed448130147bc90c4d76bf3225e28_Progressive<TInputBuffer>[] orCreateRow = GetOrCreateRow(array, rowIndex);
			FlatSharp.Compiler.Generated.NC5ED364154C495EC121D4C459B45500CDEA8C30152693D7AB19A697367DB3A52.Helpers.tableReader_a32ed448130147bc90c4d76bf3225e28_Progressive<TInputBuffer> tableReader_a32ed448130147bc90c4d76bf3225e28_Progressive = orCreateRow[colIndex];
			if (tableReader_a32ed448130147bc90c4d76bf3225e28_Progressive == null)
			{
				tableReader_a32ed448130147bc90c4d76bf3225e28_Progressive = (orCreateRow[colIndex] = UnsafeParseItem(index));
			}
			return tableReader_a32ed448130147bc90c4d76bf3225e28_Progressive;
		}

		private void ProgressiveSet(int index, CameraPreviewDirectorTarget value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, CameraPreviewDirectorTarget value)
		{
			VectorUtilities.CheckIndex(index, count);
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NC5ED364154C495EC121D4C459B45500CDEA8C30152693D7AB19A697367DB3A52.Helpers.tableReader_a32ed448130147bc90c4d76bf3225e28_Progressive<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NC5ED364154C495EC121D4C459B45500CDEA8C30152693D7AB19A697367DB3A52.Helpers.tableReader_a32ed448130147bc90c4d76bf3225e28_Progressive<TInputBuffer> UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.NC5ED364154C495EC121D4C459B45500CDEA8C30152693D7AB19A697367DB3A52.Helpers.Parse_Progressive(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, CameraPreviewDirectorTarget value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(CameraPreviewDirectorTarget? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(CameraPreviewDirectorTarget? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(CameraPreviewDirectorTarget[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<CameraPreviewDirectorTarget> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(CameraPreviewDirectorTarget item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, CameraPreviewDirectorTarget item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(CameraPreviewDirectorTarget item)
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

	[DebuggerDisplay("Greedy [ CameraPreviewDirectorTarget ], Count = {Count}")]
	internal sealed class GeneratedVector_f8d8a509c50d98f08aed9b77a47d4837_Greedy<TInputBuffer> : IList<CameraPreviewDirectorTarget>, ICollection<CameraPreviewDirectorTarget>, IEnumerable<CameraPreviewDirectorTarget>, IEnumerable, IReadOnlyList<CameraPreviewDirectorTarget>, IReadOnlyCollection<CameraPreviewDirectorTarget> where TInputBuffer : IInputBuffer
	{
		private readonly List<FlatSharp.Compiler.Generated.NC5ED364154C495EC121D4C459B45500CDEA8C30152693D7AB19A697367DB3A52.Helpers.tableReader_a32ed448130147bc90c4d76bf3225e28_Greedy<TInputBuffer>> list;

		public CameraPreviewDirectorTarget this[int index]
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

		public GeneratedVector_f8d8a509c50d98f08aed9b77a47d4837_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<FlatSharp.Compiler.Generated.NC5ED364154C495EC121D4C459B45500CDEA8C30152693D7AB19A697367DB3A52.Helpers.tableReader_a32ed448130147bc90c4d76bf3225e28_Greedy<TInputBuffer>> list = (this.list = new List<FlatSharp.Compiler.Generated.NC5ED364154C495EC121D4C459B45500CDEA8C30152693D7AB19A697367DB3A52.Helpers.tableReader_a32ed448130147bc90c4d76bf3225e28_Greedy<TInputBuffer>>(num));
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.NC5ED364154C495EC121D4C459B45500CDEA8C30152693D7AB19A697367DB3A52.Helpers.tableReader_a32ed448130147bc90c4d76bf3225e28_Greedy<TInputBuffer> item = FlatSharp.Compiler.Generated.NC5ED364154C495EC121D4C459B45500CDEA8C30152693D7AB19A697367DB3A52.Helpers.Parse_Greedy(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		private FlatSharp.Compiler.Generated.NC5ED364154C495EC121D4C459B45500CDEA8C30152693D7AB19A697367DB3A52.Helpers.tableReader_a32ed448130147bc90c4d76bf3225e28_Greedy<TInputBuffer> GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, CameraPreviewDirectorTarget value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(CameraPreviewDirectorTarget? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(CameraPreviewDirectorTarget? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(CameraPreviewDirectorTarget[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<CameraPreviewDirectorTarget> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(CameraPreviewDirectorTarget item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, CameraPreviewDirectorTarget item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(CameraPreviewDirectorTarget item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ CameraPreviewDirectorTarget ], Count = {Count}")]
	internal sealed class GeneratedVector_f8d8a509c50d98f08aed9b77a47d4837_GreedyMutable<TInputBuffer> : IList<CameraPreviewDirectorTarget>, ICollection<CameraPreviewDirectorTarget>, IEnumerable<CameraPreviewDirectorTarget>, IEnumerable, IReadOnlyList<CameraPreviewDirectorTarget>, IReadOnlyCollection<CameraPreviewDirectorTarget> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<CameraPreviewDirectorTarget> list;

		public CameraPreviewDirectorTarget this[int index]
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

		public GeneratedVector_f8d8a509c50d98f08aed9b77a47d4837_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<CameraPreviewDirectorTarget> list = (this.list = new List<CameraPreviewDirectorTarget>());
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.NC5ED364154C495EC121D4C459B45500CDEA8C30152693D7AB19A697367DB3A52.Helpers.tableReader_a32ed448130147bc90c4d76bf3225e28_GreedyMutable<TInputBuffer> item = FlatSharp.Compiler.Generated.NC5ED364154C495EC121D4C459B45500CDEA8C30152693D7AB19A697367DB3A52.Helpers.Parse_GreedyMutable(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private CameraPreviewDirectorTarget GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, CameraPreviewDirectorTarget value)
		{
			list[index] = value;
		}

		public void Add(CameraPreviewDirectorTarget item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, CameraPreviewDirectorTarget item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(CameraPreviewDirectorTarget item)
		{
			return list.Remove(item);
		}

		public bool Contains(CameraPreviewDirectorTarget? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(CameraPreviewDirectorTarget? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(CameraPreviewDirectorTarget[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<CameraPreviewDirectorTarget> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<CameraPreviewDirectorTarget> value)
	{
		int count = value.Count;
		int num = 14;
		if (value is CameraPreviewDirectorTarget[] array)
		{
			foreach (CameraPreviewDirectorTarget cameraPreviewDirectorTarget in array)
			{
				SerializationHelpers.EnsureNonNull(cameraPreviewDirectorTarget);
				num += FlatSharp.Compiler.Generated.NC5ED364154C495EC121D4C459B45500CDEA8C30152693D7AB19A697367DB3A52.Helpers.GetMaxSize(cameraPreviewDirectorTarget);
			}
		}
		else if (value is List<CameraPreviewDirectorTarget> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				CameraPreviewDirectorTarget cameraPreviewDirectorTarget2 = list[j];
				SerializationHelpers.EnsureNonNull(cameraPreviewDirectorTarget2);
				num += FlatSharp.Compiler.Generated.NC5ED364154C495EC121D4C459B45500CDEA8C30152693D7AB19A697367DB3A52.Helpers.GetMaxSize(cameraPreviewDirectorTarget2);
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				CameraPreviewDirectorTarget cameraPreviewDirectorTarget3 = value[k];
				SerializationHelpers.EnsureNonNull(cameraPreviewDirectorTarget3);
				num += FlatSharp.Compiler.Generated.NC5ED364154C495EC121D4C459B45500CDEA8C30152693D7AB19A697367DB3A52.Helpers.GetMaxSize(cameraPreviewDirectorTarget3);
			}
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<CameraPreviewDirectorTarget> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 4);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is CameraPreviewDirectorTarget[] array)
		{
			foreach (CameraPreviewDirectorTarget cameraPreviewDirectorTarget in array)
			{
				SerializationHelpers.EnsureNonNull(cameraPreviewDirectorTarget);
				FlatSharp.Compiler.Generated.NC5ED364154C495EC121D4C459B45500CDEA8C30152693D7AB19A697367DB3A52.Helpers.Serialize(spanWriter, span, cameraPreviewDirectorTarget, num, context);
				num += 4;
			}
		}
		else if (value is List<CameraPreviewDirectorTarget> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				CameraPreviewDirectorTarget cameraPreviewDirectorTarget2 = list[j];
				SerializationHelpers.EnsureNonNull(cameraPreviewDirectorTarget2);
				FlatSharp.Compiler.Generated.NC5ED364154C495EC121D4C459B45500CDEA8C30152693D7AB19A697367DB3A52.Helpers.Serialize(spanWriter, span, cameraPreviewDirectorTarget2, num, context);
				num += 4;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				CameraPreviewDirectorTarget cameraPreviewDirectorTarget3 = value[k];
				SerializationHelpers.EnsureNonNull(cameraPreviewDirectorTarget3);
				FlatSharp.Compiler.Generated.NC5ED364154C495EC121D4C459B45500CDEA8C30152693D7AB19A697367DB3A52.Helpers.Serialize(spanWriter, span, cameraPreviewDirectorTarget3, num, context);
				num += 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<CameraPreviewDirectorTarget> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_f8d8a509c50d98f08aed9b77a47d4837_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<CameraPreviewDirectorTarget> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_f8d8a509c50d98f08aed9b77a47d4837_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<CameraPreviewDirectorTarget> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_f8d8a509c50d98f08aed9b77a47d4837_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<CameraPreviewDirectorTarget> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_f8d8a509c50d98f08aed9b77a47d4837_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
