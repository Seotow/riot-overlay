using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Snapshot;
using FlatSharp.Compiler.Generated.N21635D30AF8E8544595A02CD69F1DD933DF334B37B39975221F688FDA908768F;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N1FB94CCF818D4F18E276DE2D6CDA5E29CCF8F7AE07579DA110B88182E0321DAC;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ NotificationEvent ], Count = {Count}")]
	internal sealed class GeneratedVector_e920e91f5bce77db230e141282b55b8b_Lazy<TInputBuffer> : IList<NotificationEvent>, ICollection<NotificationEvent>, IEnumerable<NotificationEvent>, IEnumerable, IReadOnlyList<NotificationEvent>, IReadOnlyCollection<NotificationEvent>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public NotificationEvent this[int index]
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

		int IFlatBufferDeserializedVector.ItemSize => 68;

		int IFlatBufferDeserializedVector.OffsetBase => offset;

		public GeneratedVector_e920e91f5bce77db230e141282b55b8b_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N21635D30AF8E8544595A02CD69F1DD933DF334B37B39975221F688FDA908768F.Helpers.structReader_d688d80425bf427ca52f0dc7b73722d9_Lazy<TInputBuffer> SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N21635D30AF8E8544595A02CD69F1DD933DF334B37B39975221F688FDA908768F.Helpers.structReader_d688d80425bf427ca52f0dc7b73722d9_Lazy<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + 68 * index;
			return FlatSharp.Compiler.Generated.N21635D30AF8E8544595A02CD69F1DD933DF334B37B39975221F688FDA908768F.Helpers.Parse_Lazy(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, NotificationEvent value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(NotificationEvent? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(NotificationEvent? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(NotificationEvent[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<NotificationEvent> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(NotificationEvent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, NotificationEvent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(NotificationEvent item)
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
			return offset + 68 * index;
		}
	}

	[DebuggerDisplay("Progressive [ NotificationEvent ], Count = {Count}")]
	internal sealed class GeneratedVector_e920e91f5bce77db230e141282b55b8b_Progressive<TInputBuffer> : IList<NotificationEvent>, ICollection<NotificationEvent>, IEnumerable<NotificationEvent>, IEnumerable, IReadOnlyList<NotificationEvent>, IReadOnlyCollection<NotificationEvent>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly FlatSharp.Compiler.Generated.N21635D30AF8E8544595A02CD69F1DD933DF334B37B39975221F688FDA908768F.Helpers.structReader_d688d80425bf427ca52f0dc7b73722d9_Progressive<TInputBuffer>?[]?[] items;

		public NotificationEvent this[int index]
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

		int IFlatBufferDeserializedVector.ItemSize => 68;

		int IFlatBufferDeserializedVector.OffsetBase => offset;

		public GeneratedVector_e920e91f5bce77db230e141282b55b8b_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new FlatSharp.Compiler.Generated.N21635D30AF8E8544595A02CD69F1DD933DF334B37B39975221F688FDA908768F.Helpers.structReader_d688d80425bf427ca52f0dc7b73722d9_Progressive<TInputBuffer>[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N21635D30AF8E8544595A02CD69F1DD933DF334B37B39975221F688FDA908768F.Helpers.structReader_d688d80425bf427ca52f0dc7b73722d9_Progressive<TInputBuffer>?[] GetOrCreateRow(FlatSharp.Compiler.Generated.N21635D30AF8E8544595A02CD69F1DD933DF334B37B39975221F688FDA908768F.Helpers.structReader_d688d80425bf427ca52f0dc7b73722d9_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private FlatSharp.Compiler.Generated.N21635D30AF8E8544595A02CD69F1DD933DF334B37B39975221F688FDA908768F.Helpers.structReader_d688d80425bf427ca52f0dc7b73722d9_Progressive<TInputBuffer>?[] CreateRow(FlatSharp.Compiler.Generated.N21635D30AF8E8544595A02CD69F1DD933DF334B37B39975221F688FDA908768F.Helpers.structReader_d688d80425bf427ca52f0dc7b73722d9_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] = new FlatSharp.Compiler.Generated.N21635D30AF8E8544595A02CD69F1DD933DF334B37B39975221F688FDA908768F.Helpers.structReader_d688d80425bf427ca52f0dc7b73722d9_Progressive<TInputBuffer>[32];
		}

		private FlatSharp.Compiler.Generated.N21635D30AF8E8544595A02CD69F1DD933DF334B37B39975221F688FDA908768F.Helpers.structReader_d688d80425bf427ca52f0dc7b73722d9_Progressive<TInputBuffer> ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			FlatSharp.Compiler.Generated.N21635D30AF8E8544595A02CD69F1DD933DF334B37B39975221F688FDA908768F.Helpers.structReader_d688d80425bf427ca52f0dc7b73722d9_Progressive<TInputBuffer>[][] array = items;
			FlatSharp.Compiler.Generated.N21635D30AF8E8544595A02CD69F1DD933DF334B37B39975221F688FDA908768F.Helpers.structReader_d688d80425bf427ca52f0dc7b73722d9_Progressive<TInputBuffer>[] orCreateRow = GetOrCreateRow(array, rowIndex);
			FlatSharp.Compiler.Generated.N21635D30AF8E8544595A02CD69F1DD933DF334B37B39975221F688FDA908768F.Helpers.structReader_d688d80425bf427ca52f0dc7b73722d9_Progressive<TInputBuffer> structReader_d688d80425bf427ca52f0dc7b73722d9_Progressive = orCreateRow[colIndex];
			if (structReader_d688d80425bf427ca52f0dc7b73722d9_Progressive == null)
			{
				structReader_d688d80425bf427ca52f0dc7b73722d9_Progressive = (orCreateRow[colIndex] = UnsafeParseItem(index));
			}
			return structReader_d688d80425bf427ca52f0dc7b73722d9_Progressive;
		}

		private void ProgressiveSet(int index, NotificationEvent value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, NotificationEvent value)
		{
			VectorUtilities.CheckIndex(index, count);
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N21635D30AF8E8544595A02CD69F1DD933DF334B37B39975221F688FDA908768F.Helpers.structReader_d688d80425bf427ca52f0dc7b73722d9_Progressive<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + 68 * index;
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N21635D30AF8E8544595A02CD69F1DD933DF334B37B39975221F688FDA908768F.Helpers.structReader_d688d80425bf427ca52f0dc7b73722d9_Progressive<TInputBuffer> UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.N21635D30AF8E8544595A02CD69F1DD933DF334B37B39975221F688FDA908768F.Helpers.Parse_Progressive(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, NotificationEvent value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(NotificationEvent? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(NotificationEvent? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(NotificationEvent[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<NotificationEvent> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(NotificationEvent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, NotificationEvent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(NotificationEvent item)
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
			return offset + 68 * index;
		}
	}

	[DebuggerDisplay("Greedy [ NotificationEvent ], Count = {Count}")]
	internal sealed class GeneratedVector_e920e91f5bce77db230e141282b55b8b_Greedy<TInputBuffer> : IList<NotificationEvent>, ICollection<NotificationEvent>, IEnumerable<NotificationEvent>, IEnumerable, IReadOnlyList<NotificationEvent>, IReadOnlyCollection<NotificationEvent> where TInputBuffer : IInputBuffer
	{
		private readonly List<FlatSharp.Compiler.Generated.N21635D30AF8E8544595A02CD69F1DD933DF334B37B39975221F688FDA908768F.Helpers.structReader_d688d80425bf427ca52f0dc7b73722d9_Greedy<TInputBuffer>> list;

		public NotificationEvent this[int index]
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

		public GeneratedVector_e920e91f5bce77db230e141282b55b8b_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<FlatSharp.Compiler.Generated.N21635D30AF8E8544595A02CD69F1DD933DF334B37B39975221F688FDA908768F.Helpers.structReader_d688d80425bf427ca52f0dc7b73722d9_Greedy<TInputBuffer>> list = (this.list = new List<FlatSharp.Compiler.Generated.N21635D30AF8E8544595A02CD69F1DD933DF334B37B39975221F688FDA908768F.Helpers.structReader_d688d80425bf427ca52f0dc7b73722d9_Greedy<TInputBuffer>>(num));
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.N21635D30AF8E8544595A02CD69F1DD933DF334B37B39975221F688FDA908768F.Helpers.structReader_d688d80425bf427ca52f0dc7b73722d9_Greedy<TInputBuffer> item = FlatSharp.Compiler.Generated.N21635D30AF8E8544595A02CD69F1DD933DF334B37B39975221F688FDA908768F.Helpers.Parse_Greedy(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 68;
			}
		}

		private FlatSharp.Compiler.Generated.N21635D30AF8E8544595A02CD69F1DD933DF334B37B39975221F688FDA908768F.Helpers.structReader_d688d80425bf427ca52f0dc7b73722d9_Greedy<TInputBuffer> GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, NotificationEvent value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(NotificationEvent? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(NotificationEvent? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(NotificationEvent[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<NotificationEvent> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(NotificationEvent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, NotificationEvent item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(NotificationEvent item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ NotificationEvent ], Count = {Count}")]
	internal sealed class GeneratedVector_e920e91f5bce77db230e141282b55b8b_GreedyMutable<TInputBuffer> : IList<NotificationEvent>, ICollection<NotificationEvent>, IEnumerable<NotificationEvent>, IEnumerable, IReadOnlyList<NotificationEvent>, IReadOnlyCollection<NotificationEvent> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<NotificationEvent> list;

		public NotificationEvent this[int index]
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

		public GeneratedVector_e920e91f5bce77db230e141282b55b8b_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<NotificationEvent> list = (this.list = new List<NotificationEvent>());
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.N21635D30AF8E8544595A02CD69F1DD933DF334B37B39975221F688FDA908768F.Helpers.structReader_d688d80425bf427ca52f0dc7b73722d9_GreedyMutable<TInputBuffer> item = FlatSharp.Compiler.Generated.N21635D30AF8E8544595A02CD69F1DD933DF334B37B39975221F688FDA908768F.Helpers.Parse_GreedyMutable(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 68;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private NotificationEvent GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, NotificationEvent value)
		{
			list[index] = value;
		}

		public void Add(NotificationEvent item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, NotificationEvent item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(NotificationEvent item)
		{
			return list.Remove(item);
		}

		public bool Contains(NotificationEvent? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(NotificationEvent? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(NotificationEvent[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<NotificationEvent> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<NotificationEvent> value)
	{
		return 10 + 68 * value.Count;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<NotificationEvent> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 68);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is NotificationEvent[] array)
		{
			foreach (NotificationEvent notificationEvent in array)
			{
				SerializationHelpers.EnsureNonNull(notificationEvent);
				FlatSharp.Compiler.Generated.N21635D30AF8E8544595A02CD69F1DD933DF334B37B39975221F688FDA908768F.Helpers.Serialize(spanWriter, span, notificationEvent, num);
				num += 68;
			}
		}
		else if (value is List<NotificationEvent> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				NotificationEvent notificationEvent2 = list[j];
				SerializationHelpers.EnsureNonNull(notificationEvent2);
				FlatSharp.Compiler.Generated.N21635D30AF8E8544595A02CD69F1DD933DF334B37B39975221F688FDA908768F.Helpers.Serialize(spanWriter, span, notificationEvent2, num);
				num += 68;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				NotificationEvent notificationEvent3 = value[k];
				SerializationHelpers.EnsureNonNull(notificationEvent3);
				FlatSharp.Compiler.Generated.N21635D30AF8E8544595A02CD69F1DD933DF334B37B39975221F688FDA908768F.Helpers.Serialize(spanWriter, span, notificationEvent3, num);
				num += 68;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<NotificationEvent> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_e920e91f5bce77db230e141282b55b8b_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<NotificationEvent> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_e920e91f5bce77db230e141282b55b8b_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<NotificationEvent> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_e920e91f5bce77db230e141282b55b8b_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<NotificationEvent> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_e920e91f5bce77db230e141282b55b8b_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
