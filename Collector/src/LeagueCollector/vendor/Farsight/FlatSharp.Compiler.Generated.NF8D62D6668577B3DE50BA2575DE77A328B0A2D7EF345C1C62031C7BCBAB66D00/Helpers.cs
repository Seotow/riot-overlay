using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Commands;
using FlatSharp.Compiler.Generated.NDC9343510231A2B29756F60BC088D1CACA8CA01435E2703E99F5D3BA16DD5A67;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.NF8D62D6668577B3DE50BA2575DE77A328B0A2D7EF345C1C62031C7BCBAB66D00;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ CameraPreviewFocusTarget ], Count = {Count}")]
	internal sealed class GeneratedVector_650c0ddbacb46a9b7ef0d430ba84d4e5_Lazy<TInputBuffer> : IList<CameraPreviewFocusTarget>, ICollection<CameraPreviewFocusTarget>, IEnumerable<CameraPreviewFocusTarget>, IEnumerable, IReadOnlyList<CameraPreviewFocusTarget>, IReadOnlyCollection<CameraPreviewFocusTarget>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public CameraPreviewFocusTarget this[int index]
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

		public GeneratedVector_650c0ddbacb46a9b7ef0d430ba84d4e5_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NDC9343510231A2B29756F60BC088D1CACA8CA01435E2703E99F5D3BA16DD5A67.Helpers.tableReader_aa7a417d0fa5486f85bf6cdf0bf879e0_Lazy<TInputBuffer> SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NDC9343510231A2B29756F60BC088D1CACA8CA01435E2703E99F5D3BA16DD5A67.Helpers.tableReader_aa7a417d0fa5486f85bf6cdf0bf879e0_Lazy<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return FlatSharp.Compiler.Generated.NDC9343510231A2B29756F60BC088D1CACA8CA01435E2703E99F5D3BA16DD5A67.Helpers.Parse_Lazy(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, CameraPreviewFocusTarget value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(CameraPreviewFocusTarget? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(CameraPreviewFocusTarget? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(CameraPreviewFocusTarget[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<CameraPreviewFocusTarget> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(CameraPreviewFocusTarget item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, CameraPreviewFocusTarget item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(CameraPreviewFocusTarget item)
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

	[DebuggerDisplay("Progressive [ CameraPreviewFocusTarget ], Count = {Count}")]
	internal sealed class GeneratedVector_650c0ddbacb46a9b7ef0d430ba84d4e5_Progressive<TInputBuffer> : IList<CameraPreviewFocusTarget>, ICollection<CameraPreviewFocusTarget>, IEnumerable<CameraPreviewFocusTarget>, IEnumerable, IReadOnlyList<CameraPreviewFocusTarget>, IReadOnlyCollection<CameraPreviewFocusTarget>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly FlatSharp.Compiler.Generated.NDC9343510231A2B29756F60BC088D1CACA8CA01435E2703E99F5D3BA16DD5A67.Helpers.tableReader_aa7a417d0fa5486f85bf6cdf0bf879e0_Progressive<TInputBuffer>?[]?[] items;

		public CameraPreviewFocusTarget this[int index]
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

		public GeneratedVector_650c0ddbacb46a9b7ef0d430ba84d4e5_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new FlatSharp.Compiler.Generated.NDC9343510231A2B29756F60BC088D1CACA8CA01435E2703E99F5D3BA16DD5A67.Helpers.tableReader_aa7a417d0fa5486f85bf6cdf0bf879e0_Progressive<TInputBuffer>[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NDC9343510231A2B29756F60BC088D1CACA8CA01435E2703E99F5D3BA16DD5A67.Helpers.tableReader_aa7a417d0fa5486f85bf6cdf0bf879e0_Progressive<TInputBuffer>?[] GetOrCreateRow(FlatSharp.Compiler.Generated.NDC9343510231A2B29756F60BC088D1CACA8CA01435E2703E99F5D3BA16DD5A67.Helpers.tableReader_aa7a417d0fa5486f85bf6cdf0bf879e0_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private FlatSharp.Compiler.Generated.NDC9343510231A2B29756F60BC088D1CACA8CA01435E2703E99F5D3BA16DD5A67.Helpers.tableReader_aa7a417d0fa5486f85bf6cdf0bf879e0_Progressive<TInputBuffer>?[] CreateRow(FlatSharp.Compiler.Generated.NDC9343510231A2B29756F60BC088D1CACA8CA01435E2703E99F5D3BA16DD5A67.Helpers.tableReader_aa7a417d0fa5486f85bf6cdf0bf879e0_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] = new FlatSharp.Compiler.Generated.NDC9343510231A2B29756F60BC088D1CACA8CA01435E2703E99F5D3BA16DD5A67.Helpers.tableReader_aa7a417d0fa5486f85bf6cdf0bf879e0_Progressive<TInputBuffer>[32];
		}

		private FlatSharp.Compiler.Generated.NDC9343510231A2B29756F60BC088D1CACA8CA01435E2703E99F5D3BA16DD5A67.Helpers.tableReader_aa7a417d0fa5486f85bf6cdf0bf879e0_Progressive<TInputBuffer> ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			FlatSharp.Compiler.Generated.NDC9343510231A2B29756F60BC088D1CACA8CA01435E2703E99F5D3BA16DD5A67.Helpers.tableReader_aa7a417d0fa5486f85bf6cdf0bf879e0_Progressive<TInputBuffer>[][] array = items;
			FlatSharp.Compiler.Generated.NDC9343510231A2B29756F60BC088D1CACA8CA01435E2703E99F5D3BA16DD5A67.Helpers.tableReader_aa7a417d0fa5486f85bf6cdf0bf879e0_Progressive<TInputBuffer>[] orCreateRow = GetOrCreateRow(array, rowIndex);
			FlatSharp.Compiler.Generated.NDC9343510231A2B29756F60BC088D1CACA8CA01435E2703E99F5D3BA16DD5A67.Helpers.tableReader_aa7a417d0fa5486f85bf6cdf0bf879e0_Progressive<TInputBuffer> tableReader_aa7a417d0fa5486f85bf6cdf0bf879e0_Progressive = orCreateRow[colIndex];
			if (tableReader_aa7a417d0fa5486f85bf6cdf0bf879e0_Progressive == null)
			{
				tableReader_aa7a417d0fa5486f85bf6cdf0bf879e0_Progressive = (orCreateRow[colIndex] = UnsafeParseItem(index));
			}
			return tableReader_aa7a417d0fa5486f85bf6cdf0bf879e0_Progressive;
		}

		private void ProgressiveSet(int index, CameraPreviewFocusTarget value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, CameraPreviewFocusTarget value)
		{
			VectorUtilities.CheckIndex(index, count);
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NDC9343510231A2B29756F60BC088D1CACA8CA01435E2703E99F5D3BA16DD5A67.Helpers.tableReader_aa7a417d0fa5486f85bf6cdf0bf879e0_Progressive<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NDC9343510231A2B29756F60BC088D1CACA8CA01435E2703E99F5D3BA16DD5A67.Helpers.tableReader_aa7a417d0fa5486f85bf6cdf0bf879e0_Progressive<TInputBuffer> UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.NDC9343510231A2B29756F60BC088D1CACA8CA01435E2703E99F5D3BA16DD5A67.Helpers.Parse_Progressive(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, CameraPreviewFocusTarget value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(CameraPreviewFocusTarget? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(CameraPreviewFocusTarget? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(CameraPreviewFocusTarget[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<CameraPreviewFocusTarget> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(CameraPreviewFocusTarget item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, CameraPreviewFocusTarget item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(CameraPreviewFocusTarget item)
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

	[DebuggerDisplay("Greedy [ CameraPreviewFocusTarget ], Count = {Count}")]
	internal sealed class GeneratedVector_650c0ddbacb46a9b7ef0d430ba84d4e5_Greedy<TInputBuffer> : IList<CameraPreviewFocusTarget>, ICollection<CameraPreviewFocusTarget>, IEnumerable<CameraPreviewFocusTarget>, IEnumerable, IReadOnlyList<CameraPreviewFocusTarget>, IReadOnlyCollection<CameraPreviewFocusTarget> where TInputBuffer : IInputBuffer
	{
		private readonly List<FlatSharp.Compiler.Generated.NDC9343510231A2B29756F60BC088D1CACA8CA01435E2703E99F5D3BA16DD5A67.Helpers.tableReader_aa7a417d0fa5486f85bf6cdf0bf879e0_Greedy<TInputBuffer>> list;

		public CameraPreviewFocusTarget this[int index]
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

		public GeneratedVector_650c0ddbacb46a9b7ef0d430ba84d4e5_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<FlatSharp.Compiler.Generated.NDC9343510231A2B29756F60BC088D1CACA8CA01435E2703E99F5D3BA16DD5A67.Helpers.tableReader_aa7a417d0fa5486f85bf6cdf0bf879e0_Greedy<TInputBuffer>> list = (this.list = new List<FlatSharp.Compiler.Generated.NDC9343510231A2B29756F60BC088D1CACA8CA01435E2703E99F5D3BA16DD5A67.Helpers.tableReader_aa7a417d0fa5486f85bf6cdf0bf879e0_Greedy<TInputBuffer>>(num));
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.NDC9343510231A2B29756F60BC088D1CACA8CA01435E2703E99F5D3BA16DD5A67.Helpers.tableReader_aa7a417d0fa5486f85bf6cdf0bf879e0_Greedy<TInputBuffer> item = FlatSharp.Compiler.Generated.NDC9343510231A2B29756F60BC088D1CACA8CA01435E2703E99F5D3BA16DD5A67.Helpers.Parse_Greedy(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		private FlatSharp.Compiler.Generated.NDC9343510231A2B29756F60BC088D1CACA8CA01435E2703E99F5D3BA16DD5A67.Helpers.tableReader_aa7a417d0fa5486f85bf6cdf0bf879e0_Greedy<TInputBuffer> GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, CameraPreviewFocusTarget value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(CameraPreviewFocusTarget? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(CameraPreviewFocusTarget? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(CameraPreviewFocusTarget[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<CameraPreviewFocusTarget> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(CameraPreviewFocusTarget item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, CameraPreviewFocusTarget item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(CameraPreviewFocusTarget item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ CameraPreviewFocusTarget ], Count = {Count}")]
	internal sealed class GeneratedVector_650c0ddbacb46a9b7ef0d430ba84d4e5_GreedyMutable<TInputBuffer> : IList<CameraPreviewFocusTarget>, ICollection<CameraPreviewFocusTarget>, IEnumerable<CameraPreviewFocusTarget>, IEnumerable, IReadOnlyList<CameraPreviewFocusTarget>, IReadOnlyCollection<CameraPreviewFocusTarget> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<CameraPreviewFocusTarget> list;

		public CameraPreviewFocusTarget this[int index]
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

		public GeneratedVector_650c0ddbacb46a9b7ef0d430ba84d4e5_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<CameraPreviewFocusTarget> list = (this.list = new List<CameraPreviewFocusTarget>());
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.NDC9343510231A2B29756F60BC088D1CACA8CA01435E2703E99F5D3BA16DD5A67.Helpers.tableReader_aa7a417d0fa5486f85bf6cdf0bf879e0_GreedyMutable<TInputBuffer> item = FlatSharp.Compiler.Generated.NDC9343510231A2B29756F60BC088D1CACA8CA01435E2703E99F5D3BA16DD5A67.Helpers.Parse_GreedyMutable(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private CameraPreviewFocusTarget GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, CameraPreviewFocusTarget value)
		{
			list[index] = value;
		}

		public void Add(CameraPreviewFocusTarget item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, CameraPreviewFocusTarget item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(CameraPreviewFocusTarget item)
		{
			return list.Remove(item);
		}

		public bool Contains(CameraPreviewFocusTarget? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(CameraPreviewFocusTarget? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(CameraPreviewFocusTarget[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<CameraPreviewFocusTarget> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<CameraPreviewFocusTarget> value)
	{
		int count = value.Count;
		int num = 14;
		if (value is CameraPreviewFocusTarget[] array)
		{
			foreach (CameraPreviewFocusTarget cameraPreviewFocusTarget in array)
			{
				SerializationHelpers.EnsureNonNull(cameraPreviewFocusTarget);
				num += FlatSharp.Compiler.Generated.NDC9343510231A2B29756F60BC088D1CACA8CA01435E2703E99F5D3BA16DD5A67.Helpers.GetMaxSize(cameraPreviewFocusTarget);
			}
		}
		else if (value is List<CameraPreviewFocusTarget> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				CameraPreviewFocusTarget cameraPreviewFocusTarget2 = list[j];
				SerializationHelpers.EnsureNonNull(cameraPreviewFocusTarget2);
				num += FlatSharp.Compiler.Generated.NDC9343510231A2B29756F60BC088D1CACA8CA01435E2703E99F5D3BA16DD5A67.Helpers.GetMaxSize(cameraPreviewFocusTarget2);
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				CameraPreviewFocusTarget cameraPreviewFocusTarget3 = value[k];
				SerializationHelpers.EnsureNonNull(cameraPreviewFocusTarget3);
				num += FlatSharp.Compiler.Generated.NDC9343510231A2B29756F60BC088D1CACA8CA01435E2703E99F5D3BA16DD5A67.Helpers.GetMaxSize(cameraPreviewFocusTarget3);
			}
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<CameraPreviewFocusTarget> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 4);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is CameraPreviewFocusTarget[] array)
		{
			foreach (CameraPreviewFocusTarget cameraPreviewFocusTarget in array)
			{
				SerializationHelpers.EnsureNonNull(cameraPreviewFocusTarget);
				FlatSharp.Compiler.Generated.NDC9343510231A2B29756F60BC088D1CACA8CA01435E2703E99F5D3BA16DD5A67.Helpers.Serialize(spanWriter, span, cameraPreviewFocusTarget, num, context);
				num += 4;
			}
		}
		else if (value is List<CameraPreviewFocusTarget> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				CameraPreviewFocusTarget cameraPreviewFocusTarget2 = list[j];
				SerializationHelpers.EnsureNonNull(cameraPreviewFocusTarget2);
				FlatSharp.Compiler.Generated.NDC9343510231A2B29756F60BC088D1CACA8CA01435E2703E99F5D3BA16DD5A67.Helpers.Serialize(spanWriter, span, cameraPreviewFocusTarget2, num, context);
				num += 4;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				CameraPreviewFocusTarget cameraPreviewFocusTarget3 = value[k];
				SerializationHelpers.EnsureNonNull(cameraPreviewFocusTarget3);
				FlatSharp.Compiler.Generated.NDC9343510231A2B29756F60BC088D1CACA8CA01435E2703E99F5D3BA16DD5A67.Helpers.Serialize(spanWriter, span, cameraPreviewFocusTarget3, num, context);
				num += 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<CameraPreviewFocusTarget> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_650c0ddbacb46a9b7ef0d430ba84d4e5_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<CameraPreviewFocusTarget> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_650c0ddbacb46a9b7ef0d430ba84d4e5_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<CameraPreviewFocusTarget> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_650c0ddbacb46a9b7ef0d430ba84d4e5_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<CameraPreviewFocusTarget> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_650c0ddbacb46a9b7ef0d430ba84d4e5_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
