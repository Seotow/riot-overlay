using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Commands;
using FlatSharp.Compiler.Generated.N5BEF05EB41A477416E7B04EAE6AF475A256A0E07F11F303C0F2AB29C27FCE326;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N1AB1515549FA510966E4A9D7DB8607DFE24203DC3BAB890F2504E07BE37B15F7;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ CameraPreviewOutputDefinition ], Count = {Count}")]
	internal sealed class GeneratedVector_6342271e82286f5e9da1be106ec335bf_Lazy<TInputBuffer> : IList<CameraPreviewOutputDefinition>, ICollection<CameraPreviewOutputDefinition>, IEnumerable<CameraPreviewOutputDefinition>, IEnumerable, IReadOnlyList<CameraPreviewOutputDefinition>, IReadOnlyCollection<CameraPreviewOutputDefinition>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public CameraPreviewOutputDefinition this[int index]
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

		public GeneratedVector_6342271e82286f5e9da1be106ec335bf_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N5BEF05EB41A477416E7B04EAE6AF475A256A0E07F11F303C0F2AB29C27FCE326.Helpers.tableReader_c136adea98334a1fb24063814f8b2c56_Lazy<TInputBuffer> SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N5BEF05EB41A477416E7B04EAE6AF475A256A0E07F11F303C0F2AB29C27FCE326.Helpers.tableReader_c136adea98334a1fb24063814f8b2c56_Lazy<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return FlatSharp.Compiler.Generated.N5BEF05EB41A477416E7B04EAE6AF475A256A0E07F11F303C0F2AB29C27FCE326.Helpers.Parse_Lazy(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, CameraPreviewOutputDefinition value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(CameraPreviewOutputDefinition? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(CameraPreviewOutputDefinition? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(CameraPreviewOutputDefinition[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<CameraPreviewOutputDefinition> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(CameraPreviewOutputDefinition item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, CameraPreviewOutputDefinition item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(CameraPreviewOutputDefinition item)
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

	[DebuggerDisplay("Progressive [ CameraPreviewOutputDefinition ], Count = {Count}")]
	internal sealed class GeneratedVector_6342271e82286f5e9da1be106ec335bf_Progressive<TInputBuffer> : IList<CameraPreviewOutputDefinition>, ICollection<CameraPreviewOutputDefinition>, IEnumerable<CameraPreviewOutputDefinition>, IEnumerable, IReadOnlyList<CameraPreviewOutputDefinition>, IReadOnlyCollection<CameraPreviewOutputDefinition>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly FlatSharp.Compiler.Generated.N5BEF05EB41A477416E7B04EAE6AF475A256A0E07F11F303C0F2AB29C27FCE326.Helpers.tableReader_c136adea98334a1fb24063814f8b2c56_Progressive<TInputBuffer>?[]?[] items;

		public CameraPreviewOutputDefinition this[int index]
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

		public GeneratedVector_6342271e82286f5e9da1be106ec335bf_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new FlatSharp.Compiler.Generated.N5BEF05EB41A477416E7B04EAE6AF475A256A0E07F11F303C0F2AB29C27FCE326.Helpers.tableReader_c136adea98334a1fb24063814f8b2c56_Progressive<TInputBuffer>[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N5BEF05EB41A477416E7B04EAE6AF475A256A0E07F11F303C0F2AB29C27FCE326.Helpers.tableReader_c136adea98334a1fb24063814f8b2c56_Progressive<TInputBuffer>?[] GetOrCreateRow(FlatSharp.Compiler.Generated.N5BEF05EB41A477416E7B04EAE6AF475A256A0E07F11F303C0F2AB29C27FCE326.Helpers.tableReader_c136adea98334a1fb24063814f8b2c56_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private FlatSharp.Compiler.Generated.N5BEF05EB41A477416E7B04EAE6AF475A256A0E07F11F303C0F2AB29C27FCE326.Helpers.tableReader_c136adea98334a1fb24063814f8b2c56_Progressive<TInputBuffer>?[] CreateRow(FlatSharp.Compiler.Generated.N5BEF05EB41A477416E7B04EAE6AF475A256A0E07F11F303C0F2AB29C27FCE326.Helpers.tableReader_c136adea98334a1fb24063814f8b2c56_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] = new FlatSharp.Compiler.Generated.N5BEF05EB41A477416E7B04EAE6AF475A256A0E07F11F303C0F2AB29C27FCE326.Helpers.tableReader_c136adea98334a1fb24063814f8b2c56_Progressive<TInputBuffer>[32];
		}

		private FlatSharp.Compiler.Generated.N5BEF05EB41A477416E7B04EAE6AF475A256A0E07F11F303C0F2AB29C27FCE326.Helpers.tableReader_c136adea98334a1fb24063814f8b2c56_Progressive<TInputBuffer> ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			FlatSharp.Compiler.Generated.N5BEF05EB41A477416E7B04EAE6AF475A256A0E07F11F303C0F2AB29C27FCE326.Helpers.tableReader_c136adea98334a1fb24063814f8b2c56_Progressive<TInputBuffer>[][] array = items;
			FlatSharp.Compiler.Generated.N5BEF05EB41A477416E7B04EAE6AF475A256A0E07F11F303C0F2AB29C27FCE326.Helpers.tableReader_c136adea98334a1fb24063814f8b2c56_Progressive<TInputBuffer>[] orCreateRow = GetOrCreateRow(array, rowIndex);
			FlatSharp.Compiler.Generated.N5BEF05EB41A477416E7B04EAE6AF475A256A0E07F11F303C0F2AB29C27FCE326.Helpers.tableReader_c136adea98334a1fb24063814f8b2c56_Progressive<TInputBuffer> tableReader_c136adea98334a1fb24063814f8b2c56_Progressive = orCreateRow[colIndex];
			if (tableReader_c136adea98334a1fb24063814f8b2c56_Progressive == null)
			{
				tableReader_c136adea98334a1fb24063814f8b2c56_Progressive = (orCreateRow[colIndex] = UnsafeParseItem(index));
			}
			return tableReader_c136adea98334a1fb24063814f8b2c56_Progressive;
		}

		private void ProgressiveSet(int index, CameraPreviewOutputDefinition value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, CameraPreviewOutputDefinition value)
		{
			VectorUtilities.CheckIndex(index, count);
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N5BEF05EB41A477416E7B04EAE6AF475A256A0E07F11F303C0F2AB29C27FCE326.Helpers.tableReader_c136adea98334a1fb24063814f8b2c56_Progressive<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N5BEF05EB41A477416E7B04EAE6AF475A256A0E07F11F303C0F2AB29C27FCE326.Helpers.tableReader_c136adea98334a1fb24063814f8b2c56_Progressive<TInputBuffer> UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.N5BEF05EB41A477416E7B04EAE6AF475A256A0E07F11F303C0F2AB29C27FCE326.Helpers.Parse_Progressive(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, CameraPreviewOutputDefinition value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(CameraPreviewOutputDefinition? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(CameraPreviewOutputDefinition? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(CameraPreviewOutputDefinition[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<CameraPreviewOutputDefinition> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(CameraPreviewOutputDefinition item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, CameraPreviewOutputDefinition item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(CameraPreviewOutputDefinition item)
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

	[DebuggerDisplay("Greedy [ CameraPreviewOutputDefinition ], Count = {Count}")]
	internal sealed class GeneratedVector_6342271e82286f5e9da1be106ec335bf_Greedy<TInputBuffer> : IList<CameraPreviewOutputDefinition>, ICollection<CameraPreviewOutputDefinition>, IEnumerable<CameraPreviewOutputDefinition>, IEnumerable, IReadOnlyList<CameraPreviewOutputDefinition>, IReadOnlyCollection<CameraPreviewOutputDefinition> where TInputBuffer : IInputBuffer
	{
		private readonly List<FlatSharp.Compiler.Generated.N5BEF05EB41A477416E7B04EAE6AF475A256A0E07F11F303C0F2AB29C27FCE326.Helpers.tableReader_c136adea98334a1fb24063814f8b2c56_Greedy<TInputBuffer>> list;

		public CameraPreviewOutputDefinition this[int index]
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

		public GeneratedVector_6342271e82286f5e9da1be106ec335bf_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<FlatSharp.Compiler.Generated.N5BEF05EB41A477416E7B04EAE6AF475A256A0E07F11F303C0F2AB29C27FCE326.Helpers.tableReader_c136adea98334a1fb24063814f8b2c56_Greedy<TInputBuffer>> list = (this.list = new List<FlatSharp.Compiler.Generated.N5BEF05EB41A477416E7B04EAE6AF475A256A0E07F11F303C0F2AB29C27FCE326.Helpers.tableReader_c136adea98334a1fb24063814f8b2c56_Greedy<TInputBuffer>>(num));
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.N5BEF05EB41A477416E7B04EAE6AF475A256A0E07F11F303C0F2AB29C27FCE326.Helpers.tableReader_c136adea98334a1fb24063814f8b2c56_Greedy<TInputBuffer> item = FlatSharp.Compiler.Generated.N5BEF05EB41A477416E7B04EAE6AF475A256A0E07F11F303C0F2AB29C27FCE326.Helpers.Parse_Greedy(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		private FlatSharp.Compiler.Generated.N5BEF05EB41A477416E7B04EAE6AF475A256A0E07F11F303C0F2AB29C27FCE326.Helpers.tableReader_c136adea98334a1fb24063814f8b2c56_Greedy<TInputBuffer> GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, CameraPreviewOutputDefinition value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(CameraPreviewOutputDefinition? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(CameraPreviewOutputDefinition? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(CameraPreviewOutputDefinition[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<CameraPreviewOutputDefinition> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(CameraPreviewOutputDefinition item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, CameraPreviewOutputDefinition item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(CameraPreviewOutputDefinition item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ CameraPreviewOutputDefinition ], Count = {Count}")]
	internal sealed class GeneratedVector_6342271e82286f5e9da1be106ec335bf_GreedyMutable<TInputBuffer> : IList<CameraPreviewOutputDefinition>, ICollection<CameraPreviewOutputDefinition>, IEnumerable<CameraPreviewOutputDefinition>, IEnumerable, IReadOnlyList<CameraPreviewOutputDefinition>, IReadOnlyCollection<CameraPreviewOutputDefinition> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<CameraPreviewOutputDefinition> list;

		public CameraPreviewOutputDefinition this[int index]
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

		public GeneratedVector_6342271e82286f5e9da1be106ec335bf_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<CameraPreviewOutputDefinition> list = (this.list = new List<CameraPreviewOutputDefinition>());
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.N5BEF05EB41A477416E7B04EAE6AF475A256A0E07F11F303C0F2AB29C27FCE326.Helpers.tableReader_c136adea98334a1fb24063814f8b2c56_GreedyMutable<TInputBuffer> item = FlatSharp.Compiler.Generated.N5BEF05EB41A477416E7B04EAE6AF475A256A0E07F11F303C0F2AB29C27FCE326.Helpers.Parse_GreedyMutable(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private CameraPreviewOutputDefinition GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, CameraPreviewOutputDefinition value)
		{
			list[index] = value;
		}

		public void Add(CameraPreviewOutputDefinition item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, CameraPreviewOutputDefinition item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(CameraPreviewOutputDefinition item)
		{
			return list.Remove(item);
		}

		public bool Contains(CameraPreviewOutputDefinition? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(CameraPreviewOutputDefinition? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(CameraPreviewOutputDefinition[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<CameraPreviewOutputDefinition> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<CameraPreviewOutputDefinition> value)
	{
		int count = value.Count;
		int num = 14;
		if (value is CameraPreviewOutputDefinition[] array)
		{
			foreach (CameraPreviewOutputDefinition cameraPreviewOutputDefinition in array)
			{
				SerializationHelpers.EnsureNonNull(cameraPreviewOutputDefinition);
				num += FlatSharp.Compiler.Generated.N5BEF05EB41A477416E7B04EAE6AF475A256A0E07F11F303C0F2AB29C27FCE326.Helpers.GetMaxSize(cameraPreviewOutputDefinition);
			}
		}
		else if (value is List<CameraPreviewOutputDefinition> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				CameraPreviewOutputDefinition cameraPreviewOutputDefinition2 = list[j];
				SerializationHelpers.EnsureNonNull(cameraPreviewOutputDefinition2);
				num += FlatSharp.Compiler.Generated.N5BEF05EB41A477416E7B04EAE6AF475A256A0E07F11F303C0F2AB29C27FCE326.Helpers.GetMaxSize(cameraPreviewOutputDefinition2);
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				CameraPreviewOutputDefinition cameraPreviewOutputDefinition3 = value[k];
				SerializationHelpers.EnsureNonNull(cameraPreviewOutputDefinition3);
				num += FlatSharp.Compiler.Generated.N5BEF05EB41A477416E7B04EAE6AF475A256A0E07F11F303C0F2AB29C27FCE326.Helpers.GetMaxSize(cameraPreviewOutputDefinition3);
			}
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<CameraPreviewOutputDefinition> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 4);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is CameraPreviewOutputDefinition[] array)
		{
			foreach (CameraPreviewOutputDefinition cameraPreviewOutputDefinition in array)
			{
				SerializationHelpers.EnsureNonNull(cameraPreviewOutputDefinition);
				FlatSharp.Compiler.Generated.N5BEF05EB41A477416E7B04EAE6AF475A256A0E07F11F303C0F2AB29C27FCE326.Helpers.Serialize(spanWriter, span, cameraPreviewOutputDefinition, num, context);
				num += 4;
			}
		}
		else if (value is List<CameraPreviewOutputDefinition> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				CameraPreviewOutputDefinition cameraPreviewOutputDefinition2 = list[j];
				SerializationHelpers.EnsureNonNull(cameraPreviewOutputDefinition2);
				FlatSharp.Compiler.Generated.N5BEF05EB41A477416E7B04EAE6AF475A256A0E07F11F303C0F2AB29C27FCE326.Helpers.Serialize(spanWriter, span, cameraPreviewOutputDefinition2, num, context);
				num += 4;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				CameraPreviewOutputDefinition cameraPreviewOutputDefinition3 = value[k];
				SerializationHelpers.EnsureNonNull(cameraPreviewOutputDefinition3);
				FlatSharp.Compiler.Generated.N5BEF05EB41A477416E7B04EAE6AF475A256A0E07F11F303C0F2AB29C27FCE326.Helpers.Serialize(spanWriter, span, cameraPreviewOutputDefinition3, num, context);
				num += 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<CameraPreviewOutputDefinition> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_6342271e82286f5e9da1be106ec335bf_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<CameraPreviewOutputDefinition> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_6342271e82286f5e9da1be106ec335bf_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<CameraPreviewOutputDefinition> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_6342271e82286f5e9da1be106ec335bf_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<CameraPreviewOutputDefinition> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_6342271e82286f5e9da1be106ec335bf_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
