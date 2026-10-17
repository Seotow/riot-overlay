using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Cinematics;
using FlatSharp.Compiler.Generated.N8767B76191F5265A9B288835E01ABDF43EA7A27245F0977DB138462E6F0A5E49;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N8090398D1B77AAA8F41A5F2DB9186E734B55A163ABC3E85F13E84319C39DEF0C;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ CinematicTrack ], Count = {Count}")]
	internal sealed class GeneratedVector_9471572f2dddef18d64e3d16c89e44d8_Lazy<TInputBuffer> : IList<CinematicTrack>, ICollection<CinematicTrack>, IEnumerable<CinematicTrack>, IEnumerable, IReadOnlyList<CinematicTrack>, IReadOnlyCollection<CinematicTrack>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public CinematicTrack this[int index]
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

		public GeneratedVector_9471572f2dddef18d64e3d16c89e44d8_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N8767B76191F5265A9B288835E01ABDF43EA7A27245F0977DB138462E6F0A5E49.Helpers.tableReader_7c4df6c0711f40dd82db13346815173a_Lazy<TInputBuffer> SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N8767B76191F5265A9B288835E01ABDF43EA7A27245F0977DB138462E6F0A5E49.Helpers.tableReader_7c4df6c0711f40dd82db13346815173a_Lazy<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return FlatSharp.Compiler.Generated.N8767B76191F5265A9B288835E01ABDF43EA7A27245F0977DB138462E6F0A5E49.Helpers.Parse_Lazy(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, CinematicTrack value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(CinematicTrack? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(CinematicTrack? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(CinematicTrack[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<CinematicTrack> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(CinematicTrack item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, CinematicTrack item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(CinematicTrack item)
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

	[DebuggerDisplay("Progressive [ CinematicTrack ], Count = {Count}")]
	internal sealed class GeneratedVector_9471572f2dddef18d64e3d16c89e44d8_Progressive<TInputBuffer> : IList<CinematicTrack>, ICollection<CinematicTrack>, IEnumerable<CinematicTrack>, IEnumerable, IReadOnlyList<CinematicTrack>, IReadOnlyCollection<CinematicTrack>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly FlatSharp.Compiler.Generated.N8767B76191F5265A9B288835E01ABDF43EA7A27245F0977DB138462E6F0A5E49.Helpers.tableReader_7c4df6c0711f40dd82db13346815173a_Progressive<TInputBuffer>?[]?[] items;

		public CinematicTrack this[int index]
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

		public GeneratedVector_9471572f2dddef18d64e3d16c89e44d8_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new FlatSharp.Compiler.Generated.N8767B76191F5265A9B288835E01ABDF43EA7A27245F0977DB138462E6F0A5E49.Helpers.tableReader_7c4df6c0711f40dd82db13346815173a_Progressive<TInputBuffer>[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N8767B76191F5265A9B288835E01ABDF43EA7A27245F0977DB138462E6F0A5E49.Helpers.tableReader_7c4df6c0711f40dd82db13346815173a_Progressive<TInputBuffer>?[] GetOrCreateRow(FlatSharp.Compiler.Generated.N8767B76191F5265A9B288835E01ABDF43EA7A27245F0977DB138462E6F0A5E49.Helpers.tableReader_7c4df6c0711f40dd82db13346815173a_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private FlatSharp.Compiler.Generated.N8767B76191F5265A9B288835E01ABDF43EA7A27245F0977DB138462E6F0A5E49.Helpers.tableReader_7c4df6c0711f40dd82db13346815173a_Progressive<TInputBuffer>?[] CreateRow(FlatSharp.Compiler.Generated.N8767B76191F5265A9B288835E01ABDF43EA7A27245F0977DB138462E6F0A5E49.Helpers.tableReader_7c4df6c0711f40dd82db13346815173a_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] = new FlatSharp.Compiler.Generated.N8767B76191F5265A9B288835E01ABDF43EA7A27245F0977DB138462E6F0A5E49.Helpers.tableReader_7c4df6c0711f40dd82db13346815173a_Progressive<TInputBuffer>[32];
		}

		private FlatSharp.Compiler.Generated.N8767B76191F5265A9B288835E01ABDF43EA7A27245F0977DB138462E6F0A5E49.Helpers.tableReader_7c4df6c0711f40dd82db13346815173a_Progressive<TInputBuffer> ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			FlatSharp.Compiler.Generated.N8767B76191F5265A9B288835E01ABDF43EA7A27245F0977DB138462E6F0A5E49.Helpers.tableReader_7c4df6c0711f40dd82db13346815173a_Progressive<TInputBuffer>[][] array = items;
			FlatSharp.Compiler.Generated.N8767B76191F5265A9B288835E01ABDF43EA7A27245F0977DB138462E6F0A5E49.Helpers.tableReader_7c4df6c0711f40dd82db13346815173a_Progressive<TInputBuffer>[] orCreateRow = GetOrCreateRow(array, rowIndex);
			FlatSharp.Compiler.Generated.N8767B76191F5265A9B288835E01ABDF43EA7A27245F0977DB138462E6F0A5E49.Helpers.tableReader_7c4df6c0711f40dd82db13346815173a_Progressive<TInputBuffer> tableReader_7c4df6c0711f40dd82db13346815173a_Progressive = orCreateRow[colIndex];
			if (tableReader_7c4df6c0711f40dd82db13346815173a_Progressive == null)
			{
				tableReader_7c4df6c0711f40dd82db13346815173a_Progressive = (orCreateRow[colIndex] = UnsafeParseItem(index));
			}
			return tableReader_7c4df6c0711f40dd82db13346815173a_Progressive;
		}

		private void ProgressiveSet(int index, CinematicTrack value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, CinematicTrack value)
		{
			VectorUtilities.CheckIndex(index, count);
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N8767B76191F5265A9B288835E01ABDF43EA7A27245F0977DB138462E6F0A5E49.Helpers.tableReader_7c4df6c0711f40dd82db13346815173a_Progressive<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N8767B76191F5265A9B288835E01ABDF43EA7A27245F0977DB138462E6F0A5E49.Helpers.tableReader_7c4df6c0711f40dd82db13346815173a_Progressive<TInputBuffer> UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.N8767B76191F5265A9B288835E01ABDF43EA7A27245F0977DB138462E6F0A5E49.Helpers.Parse_Progressive(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, CinematicTrack value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(CinematicTrack? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(CinematicTrack? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(CinematicTrack[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<CinematicTrack> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(CinematicTrack item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, CinematicTrack item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(CinematicTrack item)
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

	[DebuggerDisplay("Greedy [ CinematicTrack ], Count = {Count}")]
	internal sealed class GeneratedVector_9471572f2dddef18d64e3d16c89e44d8_Greedy<TInputBuffer> : IList<CinematicTrack>, ICollection<CinematicTrack>, IEnumerable<CinematicTrack>, IEnumerable, IReadOnlyList<CinematicTrack>, IReadOnlyCollection<CinematicTrack> where TInputBuffer : IInputBuffer
	{
		private readonly List<FlatSharp.Compiler.Generated.N8767B76191F5265A9B288835E01ABDF43EA7A27245F0977DB138462E6F0A5E49.Helpers.tableReader_7c4df6c0711f40dd82db13346815173a_Greedy<TInputBuffer>> list;

		public CinematicTrack this[int index]
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

		public GeneratedVector_9471572f2dddef18d64e3d16c89e44d8_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<FlatSharp.Compiler.Generated.N8767B76191F5265A9B288835E01ABDF43EA7A27245F0977DB138462E6F0A5E49.Helpers.tableReader_7c4df6c0711f40dd82db13346815173a_Greedy<TInputBuffer>> list = (this.list = new List<FlatSharp.Compiler.Generated.N8767B76191F5265A9B288835E01ABDF43EA7A27245F0977DB138462E6F0A5E49.Helpers.tableReader_7c4df6c0711f40dd82db13346815173a_Greedy<TInputBuffer>>(num));
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.N8767B76191F5265A9B288835E01ABDF43EA7A27245F0977DB138462E6F0A5E49.Helpers.tableReader_7c4df6c0711f40dd82db13346815173a_Greedy<TInputBuffer> item = FlatSharp.Compiler.Generated.N8767B76191F5265A9B288835E01ABDF43EA7A27245F0977DB138462E6F0A5E49.Helpers.Parse_Greedy(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		private FlatSharp.Compiler.Generated.N8767B76191F5265A9B288835E01ABDF43EA7A27245F0977DB138462E6F0A5E49.Helpers.tableReader_7c4df6c0711f40dd82db13346815173a_Greedy<TInputBuffer> GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, CinematicTrack value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(CinematicTrack? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(CinematicTrack? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(CinematicTrack[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<CinematicTrack> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(CinematicTrack item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, CinematicTrack item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(CinematicTrack item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ CinematicTrack ], Count = {Count}")]
	internal sealed class GeneratedVector_9471572f2dddef18d64e3d16c89e44d8_GreedyMutable<TInputBuffer> : IList<CinematicTrack>, ICollection<CinematicTrack>, IEnumerable<CinematicTrack>, IEnumerable, IReadOnlyList<CinematicTrack>, IReadOnlyCollection<CinematicTrack> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<CinematicTrack> list;

		public CinematicTrack this[int index]
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

		public GeneratedVector_9471572f2dddef18d64e3d16c89e44d8_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<CinematicTrack> list = (this.list = new List<CinematicTrack>());
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.N8767B76191F5265A9B288835E01ABDF43EA7A27245F0977DB138462E6F0A5E49.Helpers.tableReader_7c4df6c0711f40dd82db13346815173a_GreedyMutable<TInputBuffer> item = FlatSharp.Compiler.Generated.N8767B76191F5265A9B288835E01ABDF43EA7A27245F0977DB138462E6F0A5E49.Helpers.Parse_GreedyMutable(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private CinematicTrack GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, CinematicTrack value)
		{
			list[index] = value;
		}

		public void Add(CinematicTrack item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, CinematicTrack item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(CinematicTrack item)
		{
			return list.Remove(item);
		}

		public bool Contains(CinematicTrack? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(CinematicTrack? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(CinematicTrack[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<CinematicTrack> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<CinematicTrack> value)
	{
		int count = value.Count;
		int num = 14;
		if (value is CinematicTrack[] array)
		{
			foreach (CinematicTrack cinematicTrack in array)
			{
				SerializationHelpers.EnsureNonNull(cinematicTrack);
				num += FlatSharp.Compiler.Generated.N8767B76191F5265A9B288835E01ABDF43EA7A27245F0977DB138462E6F0A5E49.Helpers.GetMaxSize(cinematicTrack);
			}
		}
		else if (value is List<CinematicTrack> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				CinematicTrack cinematicTrack2 = list[j];
				SerializationHelpers.EnsureNonNull(cinematicTrack2);
				num += FlatSharp.Compiler.Generated.N8767B76191F5265A9B288835E01ABDF43EA7A27245F0977DB138462E6F0A5E49.Helpers.GetMaxSize(cinematicTrack2);
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				CinematicTrack cinematicTrack3 = value[k];
				SerializationHelpers.EnsureNonNull(cinematicTrack3);
				num += FlatSharp.Compiler.Generated.N8767B76191F5265A9B288835E01ABDF43EA7A27245F0977DB138462E6F0A5E49.Helpers.GetMaxSize(cinematicTrack3);
			}
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<CinematicTrack> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 4);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is CinematicTrack[] array)
		{
			foreach (CinematicTrack cinematicTrack in array)
			{
				SerializationHelpers.EnsureNonNull(cinematicTrack);
				FlatSharp.Compiler.Generated.N8767B76191F5265A9B288835E01ABDF43EA7A27245F0977DB138462E6F0A5E49.Helpers.Serialize(spanWriter, span, cinematicTrack, num, context);
				num += 4;
			}
		}
		else if (value is List<CinematicTrack> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				CinematicTrack cinematicTrack2 = list[j];
				SerializationHelpers.EnsureNonNull(cinematicTrack2);
				FlatSharp.Compiler.Generated.N8767B76191F5265A9B288835E01ABDF43EA7A27245F0977DB138462E6F0A5E49.Helpers.Serialize(spanWriter, span, cinematicTrack2, num, context);
				num += 4;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				CinematicTrack cinematicTrack3 = value[k];
				SerializationHelpers.EnsureNonNull(cinematicTrack3);
				FlatSharp.Compiler.Generated.N8767B76191F5265A9B288835E01ABDF43EA7A27245F0977DB138462E6F0A5E49.Helpers.Serialize(spanWriter, span, cinematicTrack3, num, context);
				num += 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<CinematicTrack> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_9471572f2dddef18d64e3d16c89e44d8_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<CinematicTrack> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_9471572f2dddef18d64e3d16c89e44d8_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<CinematicTrack> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_9471572f2dddef18d64e3d16c89e44d8_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<CinematicTrack> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_9471572f2dddef18d64e3d16c89e44d8_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
