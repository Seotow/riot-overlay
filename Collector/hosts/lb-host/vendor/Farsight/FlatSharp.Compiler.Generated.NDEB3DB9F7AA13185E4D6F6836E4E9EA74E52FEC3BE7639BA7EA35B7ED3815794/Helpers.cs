using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Cinematics;
using FlatSharp.Compiler.Generated.N6AE3215356F13B8412766A4FE13B17227B4354F17EC1EA2F4E7AD959DA72AA0B;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.NDEB3DB9F7AA13185E4D6F6836E4E9EA74E52FEC3BE7639BA7EA35B7ED3815794;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ CinematicOverlayTrack ], Count = {Count}")]
	internal sealed class GeneratedVector_32277738d6a10ca2b71372ad34c94a25_Lazy<TInputBuffer> : IList<CinematicOverlayTrack>, ICollection<CinematicOverlayTrack>, IEnumerable<CinematicOverlayTrack>, IEnumerable, IReadOnlyList<CinematicOverlayTrack>, IReadOnlyCollection<CinematicOverlayTrack>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public CinematicOverlayTrack this[int index]
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

		public GeneratedVector_32277738d6a10ca2b71372ad34c94a25_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N6AE3215356F13B8412766A4FE13B17227B4354F17EC1EA2F4E7AD959DA72AA0B.Helpers.tableReader_9a13efa19e1343bea852812ce8034fc6_Lazy<TInputBuffer> SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N6AE3215356F13B8412766A4FE13B17227B4354F17EC1EA2F4E7AD959DA72AA0B.Helpers.tableReader_9a13efa19e1343bea852812ce8034fc6_Lazy<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return FlatSharp.Compiler.Generated.N6AE3215356F13B8412766A4FE13B17227B4354F17EC1EA2F4E7AD959DA72AA0B.Helpers.Parse_Lazy(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, CinematicOverlayTrack value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(CinematicOverlayTrack? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(CinematicOverlayTrack? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(CinematicOverlayTrack[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<CinematicOverlayTrack> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(CinematicOverlayTrack item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, CinematicOverlayTrack item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(CinematicOverlayTrack item)
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

	[DebuggerDisplay("Progressive [ CinematicOverlayTrack ], Count = {Count}")]
	internal sealed class GeneratedVector_32277738d6a10ca2b71372ad34c94a25_Progressive<TInputBuffer> : IList<CinematicOverlayTrack>, ICollection<CinematicOverlayTrack>, IEnumerable<CinematicOverlayTrack>, IEnumerable, IReadOnlyList<CinematicOverlayTrack>, IReadOnlyCollection<CinematicOverlayTrack>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly FlatSharp.Compiler.Generated.N6AE3215356F13B8412766A4FE13B17227B4354F17EC1EA2F4E7AD959DA72AA0B.Helpers.tableReader_9a13efa19e1343bea852812ce8034fc6_Progressive<TInputBuffer>?[]?[] items;

		public CinematicOverlayTrack this[int index]
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

		public GeneratedVector_32277738d6a10ca2b71372ad34c94a25_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new FlatSharp.Compiler.Generated.N6AE3215356F13B8412766A4FE13B17227B4354F17EC1EA2F4E7AD959DA72AA0B.Helpers.tableReader_9a13efa19e1343bea852812ce8034fc6_Progressive<TInputBuffer>[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N6AE3215356F13B8412766A4FE13B17227B4354F17EC1EA2F4E7AD959DA72AA0B.Helpers.tableReader_9a13efa19e1343bea852812ce8034fc6_Progressive<TInputBuffer>?[] GetOrCreateRow(FlatSharp.Compiler.Generated.N6AE3215356F13B8412766A4FE13B17227B4354F17EC1EA2F4E7AD959DA72AA0B.Helpers.tableReader_9a13efa19e1343bea852812ce8034fc6_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private FlatSharp.Compiler.Generated.N6AE3215356F13B8412766A4FE13B17227B4354F17EC1EA2F4E7AD959DA72AA0B.Helpers.tableReader_9a13efa19e1343bea852812ce8034fc6_Progressive<TInputBuffer>?[] CreateRow(FlatSharp.Compiler.Generated.N6AE3215356F13B8412766A4FE13B17227B4354F17EC1EA2F4E7AD959DA72AA0B.Helpers.tableReader_9a13efa19e1343bea852812ce8034fc6_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] = new FlatSharp.Compiler.Generated.N6AE3215356F13B8412766A4FE13B17227B4354F17EC1EA2F4E7AD959DA72AA0B.Helpers.tableReader_9a13efa19e1343bea852812ce8034fc6_Progressive<TInputBuffer>[32];
		}

		private FlatSharp.Compiler.Generated.N6AE3215356F13B8412766A4FE13B17227B4354F17EC1EA2F4E7AD959DA72AA0B.Helpers.tableReader_9a13efa19e1343bea852812ce8034fc6_Progressive<TInputBuffer> ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			FlatSharp.Compiler.Generated.N6AE3215356F13B8412766A4FE13B17227B4354F17EC1EA2F4E7AD959DA72AA0B.Helpers.tableReader_9a13efa19e1343bea852812ce8034fc6_Progressive<TInputBuffer>[][] array = items;
			FlatSharp.Compiler.Generated.N6AE3215356F13B8412766A4FE13B17227B4354F17EC1EA2F4E7AD959DA72AA0B.Helpers.tableReader_9a13efa19e1343bea852812ce8034fc6_Progressive<TInputBuffer>[] orCreateRow = GetOrCreateRow(array, rowIndex);
			FlatSharp.Compiler.Generated.N6AE3215356F13B8412766A4FE13B17227B4354F17EC1EA2F4E7AD959DA72AA0B.Helpers.tableReader_9a13efa19e1343bea852812ce8034fc6_Progressive<TInputBuffer> tableReader_9a13efa19e1343bea852812ce8034fc6_Progressive = orCreateRow[colIndex];
			if (tableReader_9a13efa19e1343bea852812ce8034fc6_Progressive == null)
			{
				tableReader_9a13efa19e1343bea852812ce8034fc6_Progressive = (orCreateRow[colIndex] = UnsafeParseItem(index));
			}
			return tableReader_9a13efa19e1343bea852812ce8034fc6_Progressive;
		}

		private void ProgressiveSet(int index, CinematicOverlayTrack value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, CinematicOverlayTrack value)
		{
			VectorUtilities.CheckIndex(index, count);
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N6AE3215356F13B8412766A4FE13B17227B4354F17EC1EA2F4E7AD959DA72AA0B.Helpers.tableReader_9a13efa19e1343bea852812ce8034fc6_Progressive<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N6AE3215356F13B8412766A4FE13B17227B4354F17EC1EA2F4E7AD959DA72AA0B.Helpers.tableReader_9a13efa19e1343bea852812ce8034fc6_Progressive<TInputBuffer> UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.N6AE3215356F13B8412766A4FE13B17227B4354F17EC1EA2F4E7AD959DA72AA0B.Helpers.Parse_Progressive(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, CinematicOverlayTrack value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(CinematicOverlayTrack? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(CinematicOverlayTrack? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(CinematicOverlayTrack[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<CinematicOverlayTrack> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(CinematicOverlayTrack item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, CinematicOverlayTrack item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(CinematicOverlayTrack item)
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

	[DebuggerDisplay("Greedy [ CinematicOverlayTrack ], Count = {Count}")]
	internal sealed class GeneratedVector_32277738d6a10ca2b71372ad34c94a25_Greedy<TInputBuffer> : IList<CinematicOverlayTrack>, ICollection<CinematicOverlayTrack>, IEnumerable<CinematicOverlayTrack>, IEnumerable, IReadOnlyList<CinematicOverlayTrack>, IReadOnlyCollection<CinematicOverlayTrack> where TInputBuffer : IInputBuffer
	{
		private readonly List<FlatSharp.Compiler.Generated.N6AE3215356F13B8412766A4FE13B17227B4354F17EC1EA2F4E7AD959DA72AA0B.Helpers.tableReader_9a13efa19e1343bea852812ce8034fc6_Greedy<TInputBuffer>> list;

		public CinematicOverlayTrack this[int index]
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

		public GeneratedVector_32277738d6a10ca2b71372ad34c94a25_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<FlatSharp.Compiler.Generated.N6AE3215356F13B8412766A4FE13B17227B4354F17EC1EA2F4E7AD959DA72AA0B.Helpers.tableReader_9a13efa19e1343bea852812ce8034fc6_Greedy<TInputBuffer>> list = (this.list = new List<FlatSharp.Compiler.Generated.N6AE3215356F13B8412766A4FE13B17227B4354F17EC1EA2F4E7AD959DA72AA0B.Helpers.tableReader_9a13efa19e1343bea852812ce8034fc6_Greedy<TInputBuffer>>(num));
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.N6AE3215356F13B8412766A4FE13B17227B4354F17EC1EA2F4E7AD959DA72AA0B.Helpers.tableReader_9a13efa19e1343bea852812ce8034fc6_Greedy<TInputBuffer> item = FlatSharp.Compiler.Generated.N6AE3215356F13B8412766A4FE13B17227B4354F17EC1EA2F4E7AD959DA72AA0B.Helpers.Parse_Greedy(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		private FlatSharp.Compiler.Generated.N6AE3215356F13B8412766A4FE13B17227B4354F17EC1EA2F4E7AD959DA72AA0B.Helpers.tableReader_9a13efa19e1343bea852812ce8034fc6_Greedy<TInputBuffer> GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, CinematicOverlayTrack value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(CinematicOverlayTrack? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(CinematicOverlayTrack? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(CinematicOverlayTrack[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<CinematicOverlayTrack> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(CinematicOverlayTrack item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, CinematicOverlayTrack item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(CinematicOverlayTrack item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ CinematicOverlayTrack ], Count = {Count}")]
	internal sealed class GeneratedVector_32277738d6a10ca2b71372ad34c94a25_GreedyMutable<TInputBuffer> : IList<CinematicOverlayTrack>, ICollection<CinematicOverlayTrack>, IEnumerable<CinematicOverlayTrack>, IEnumerable, IReadOnlyList<CinematicOverlayTrack>, IReadOnlyCollection<CinematicOverlayTrack> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<CinematicOverlayTrack> list;

		public CinematicOverlayTrack this[int index]
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

		public GeneratedVector_32277738d6a10ca2b71372ad34c94a25_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<CinematicOverlayTrack> list = (this.list = new List<CinematicOverlayTrack>());
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.N6AE3215356F13B8412766A4FE13B17227B4354F17EC1EA2F4E7AD959DA72AA0B.Helpers.tableReader_9a13efa19e1343bea852812ce8034fc6_GreedyMutable<TInputBuffer> item = FlatSharp.Compiler.Generated.N6AE3215356F13B8412766A4FE13B17227B4354F17EC1EA2F4E7AD959DA72AA0B.Helpers.Parse_GreedyMutable(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private CinematicOverlayTrack GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, CinematicOverlayTrack value)
		{
			list[index] = value;
		}

		public void Add(CinematicOverlayTrack item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, CinematicOverlayTrack item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(CinematicOverlayTrack item)
		{
			return list.Remove(item);
		}

		public bool Contains(CinematicOverlayTrack? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(CinematicOverlayTrack? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(CinematicOverlayTrack[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<CinematicOverlayTrack> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<CinematicOverlayTrack> value)
	{
		int count = value.Count;
		int num = 14;
		if (value is CinematicOverlayTrack[] array)
		{
			foreach (CinematicOverlayTrack cinematicOverlayTrack in array)
			{
				SerializationHelpers.EnsureNonNull(cinematicOverlayTrack);
				num += FlatSharp.Compiler.Generated.N6AE3215356F13B8412766A4FE13B17227B4354F17EC1EA2F4E7AD959DA72AA0B.Helpers.GetMaxSize(cinematicOverlayTrack);
			}
		}
		else if (value is List<CinematicOverlayTrack> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				CinematicOverlayTrack cinematicOverlayTrack2 = list[j];
				SerializationHelpers.EnsureNonNull(cinematicOverlayTrack2);
				num += FlatSharp.Compiler.Generated.N6AE3215356F13B8412766A4FE13B17227B4354F17EC1EA2F4E7AD959DA72AA0B.Helpers.GetMaxSize(cinematicOverlayTrack2);
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				CinematicOverlayTrack cinematicOverlayTrack3 = value[k];
				SerializationHelpers.EnsureNonNull(cinematicOverlayTrack3);
				num += FlatSharp.Compiler.Generated.N6AE3215356F13B8412766A4FE13B17227B4354F17EC1EA2F4E7AD959DA72AA0B.Helpers.GetMaxSize(cinematicOverlayTrack3);
			}
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<CinematicOverlayTrack> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 4);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is CinematicOverlayTrack[] array)
		{
			foreach (CinematicOverlayTrack cinematicOverlayTrack in array)
			{
				SerializationHelpers.EnsureNonNull(cinematicOverlayTrack);
				FlatSharp.Compiler.Generated.N6AE3215356F13B8412766A4FE13B17227B4354F17EC1EA2F4E7AD959DA72AA0B.Helpers.Serialize(spanWriter, span, cinematicOverlayTrack, num, context);
				num += 4;
			}
		}
		else if (value is List<CinematicOverlayTrack> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				CinematicOverlayTrack cinematicOverlayTrack2 = list[j];
				SerializationHelpers.EnsureNonNull(cinematicOverlayTrack2);
				FlatSharp.Compiler.Generated.N6AE3215356F13B8412766A4FE13B17227B4354F17EC1EA2F4E7AD959DA72AA0B.Helpers.Serialize(spanWriter, span, cinematicOverlayTrack2, num, context);
				num += 4;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				CinematicOverlayTrack cinematicOverlayTrack3 = value[k];
				SerializationHelpers.EnsureNonNull(cinematicOverlayTrack3);
				FlatSharp.Compiler.Generated.N6AE3215356F13B8412766A4FE13B17227B4354F17EC1EA2F4E7AD959DA72AA0B.Helpers.Serialize(spanWriter, span, cinematicOverlayTrack3, num, context);
				num += 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<CinematicOverlayTrack> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_32277738d6a10ca2b71372ad34c94a25_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<CinematicOverlayTrack> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_32277738d6a10ca2b71372ad34c94a25_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<CinematicOverlayTrack> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_32277738d6a10ca2b71372ad34c94a25_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<CinematicOverlayTrack> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_32277738d6a10ca2b71372ad34c94a25_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
