using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Cinematics;
using FlatSharp.Compiler.Generated.NA0DB75AEFD3B890080AA25971C19D4FBC47079AFB7E1C63BF09C85CACABF7CEB;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.NB67F786E49E87477092647F18A812C29A46BF9EE82A580FFB42441ED964EF247;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ Cinematic ], Count = {Count}")]
	internal sealed class GeneratedVector_3679b404a8496f38a532164f03f60119_Lazy<TInputBuffer> : IList<Cinematic>, ICollection<Cinematic>, IEnumerable<Cinematic>, IEnumerable, IReadOnlyList<Cinematic>, IReadOnlyCollection<Cinematic>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public Cinematic this[int index]
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

		public GeneratedVector_3679b404a8496f38a532164f03f60119_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NA0DB75AEFD3B890080AA25971C19D4FBC47079AFB7E1C63BF09C85CACABF7CEB.Helpers.tableReader_a88be26b47f44da98aff1a3a7a9581e5_Lazy<TInputBuffer> SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NA0DB75AEFD3B890080AA25971C19D4FBC47079AFB7E1C63BF09C85CACABF7CEB.Helpers.tableReader_a88be26b47f44da98aff1a3a7a9581e5_Lazy<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return FlatSharp.Compiler.Generated.NA0DB75AEFD3B890080AA25971C19D4FBC47079AFB7E1C63BF09C85CACABF7CEB.Helpers.Parse_Lazy(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, Cinematic value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(Cinematic? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(Cinematic? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(Cinematic[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<Cinematic> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(Cinematic item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, Cinematic item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(Cinematic item)
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

	[DebuggerDisplay("Progressive [ Cinematic ], Count = {Count}")]
	internal sealed class GeneratedVector_3679b404a8496f38a532164f03f60119_Progressive<TInputBuffer> : IList<Cinematic>, ICollection<Cinematic>, IEnumerable<Cinematic>, IEnumerable, IReadOnlyList<Cinematic>, IReadOnlyCollection<Cinematic>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly FlatSharp.Compiler.Generated.NA0DB75AEFD3B890080AA25971C19D4FBC47079AFB7E1C63BF09C85CACABF7CEB.Helpers.tableReader_a88be26b47f44da98aff1a3a7a9581e5_Progressive<TInputBuffer>?[]?[] items;

		public Cinematic this[int index]
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

		public GeneratedVector_3679b404a8496f38a532164f03f60119_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new FlatSharp.Compiler.Generated.NA0DB75AEFD3B890080AA25971C19D4FBC47079AFB7E1C63BF09C85CACABF7CEB.Helpers.tableReader_a88be26b47f44da98aff1a3a7a9581e5_Progressive<TInputBuffer>[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NA0DB75AEFD3B890080AA25971C19D4FBC47079AFB7E1C63BF09C85CACABF7CEB.Helpers.tableReader_a88be26b47f44da98aff1a3a7a9581e5_Progressive<TInputBuffer>?[] GetOrCreateRow(FlatSharp.Compiler.Generated.NA0DB75AEFD3B890080AA25971C19D4FBC47079AFB7E1C63BF09C85CACABF7CEB.Helpers.tableReader_a88be26b47f44da98aff1a3a7a9581e5_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private FlatSharp.Compiler.Generated.NA0DB75AEFD3B890080AA25971C19D4FBC47079AFB7E1C63BF09C85CACABF7CEB.Helpers.tableReader_a88be26b47f44da98aff1a3a7a9581e5_Progressive<TInputBuffer>?[] CreateRow(FlatSharp.Compiler.Generated.NA0DB75AEFD3B890080AA25971C19D4FBC47079AFB7E1C63BF09C85CACABF7CEB.Helpers.tableReader_a88be26b47f44da98aff1a3a7a9581e5_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] = new FlatSharp.Compiler.Generated.NA0DB75AEFD3B890080AA25971C19D4FBC47079AFB7E1C63BF09C85CACABF7CEB.Helpers.tableReader_a88be26b47f44da98aff1a3a7a9581e5_Progressive<TInputBuffer>[32];
		}

		private FlatSharp.Compiler.Generated.NA0DB75AEFD3B890080AA25971C19D4FBC47079AFB7E1C63BF09C85CACABF7CEB.Helpers.tableReader_a88be26b47f44da98aff1a3a7a9581e5_Progressive<TInputBuffer> ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			FlatSharp.Compiler.Generated.NA0DB75AEFD3B890080AA25971C19D4FBC47079AFB7E1C63BF09C85CACABF7CEB.Helpers.tableReader_a88be26b47f44da98aff1a3a7a9581e5_Progressive<TInputBuffer>[][] array = items;
			FlatSharp.Compiler.Generated.NA0DB75AEFD3B890080AA25971C19D4FBC47079AFB7E1C63BF09C85CACABF7CEB.Helpers.tableReader_a88be26b47f44da98aff1a3a7a9581e5_Progressive<TInputBuffer>[] orCreateRow = GetOrCreateRow(array, rowIndex);
			FlatSharp.Compiler.Generated.NA0DB75AEFD3B890080AA25971C19D4FBC47079AFB7E1C63BF09C85CACABF7CEB.Helpers.tableReader_a88be26b47f44da98aff1a3a7a9581e5_Progressive<TInputBuffer> tableReader_a88be26b47f44da98aff1a3a7a9581e5_Progressive = orCreateRow[colIndex];
			if (tableReader_a88be26b47f44da98aff1a3a7a9581e5_Progressive == null)
			{
				tableReader_a88be26b47f44da98aff1a3a7a9581e5_Progressive = (orCreateRow[colIndex] = UnsafeParseItem(index));
			}
			return tableReader_a88be26b47f44da98aff1a3a7a9581e5_Progressive;
		}

		private void ProgressiveSet(int index, Cinematic value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, Cinematic value)
		{
			VectorUtilities.CheckIndex(index, count);
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NA0DB75AEFD3B890080AA25971C19D4FBC47079AFB7E1C63BF09C85CACABF7CEB.Helpers.tableReader_a88be26b47f44da98aff1a3a7a9581e5_Progressive<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NA0DB75AEFD3B890080AA25971C19D4FBC47079AFB7E1C63BF09C85CACABF7CEB.Helpers.tableReader_a88be26b47f44da98aff1a3a7a9581e5_Progressive<TInputBuffer> UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.NA0DB75AEFD3B890080AA25971C19D4FBC47079AFB7E1C63BF09C85CACABF7CEB.Helpers.Parse_Progressive(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, Cinematic value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(Cinematic? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(Cinematic? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(Cinematic[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<Cinematic> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(Cinematic item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, Cinematic item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(Cinematic item)
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

	[DebuggerDisplay("Greedy [ Cinematic ], Count = {Count}")]
	internal sealed class GeneratedVector_3679b404a8496f38a532164f03f60119_Greedy<TInputBuffer> : IList<Cinematic>, ICollection<Cinematic>, IEnumerable<Cinematic>, IEnumerable, IReadOnlyList<Cinematic>, IReadOnlyCollection<Cinematic> where TInputBuffer : IInputBuffer
	{
		private readonly List<FlatSharp.Compiler.Generated.NA0DB75AEFD3B890080AA25971C19D4FBC47079AFB7E1C63BF09C85CACABF7CEB.Helpers.tableReader_a88be26b47f44da98aff1a3a7a9581e5_Greedy<TInputBuffer>> list;

		public Cinematic this[int index]
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

		public GeneratedVector_3679b404a8496f38a532164f03f60119_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<FlatSharp.Compiler.Generated.NA0DB75AEFD3B890080AA25971C19D4FBC47079AFB7E1C63BF09C85CACABF7CEB.Helpers.tableReader_a88be26b47f44da98aff1a3a7a9581e5_Greedy<TInputBuffer>> list = (this.list = new List<FlatSharp.Compiler.Generated.NA0DB75AEFD3B890080AA25971C19D4FBC47079AFB7E1C63BF09C85CACABF7CEB.Helpers.tableReader_a88be26b47f44da98aff1a3a7a9581e5_Greedy<TInputBuffer>>(num));
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.NA0DB75AEFD3B890080AA25971C19D4FBC47079AFB7E1C63BF09C85CACABF7CEB.Helpers.tableReader_a88be26b47f44da98aff1a3a7a9581e5_Greedy<TInputBuffer> item = FlatSharp.Compiler.Generated.NA0DB75AEFD3B890080AA25971C19D4FBC47079AFB7E1C63BF09C85CACABF7CEB.Helpers.Parse_Greedy(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		private FlatSharp.Compiler.Generated.NA0DB75AEFD3B890080AA25971C19D4FBC47079AFB7E1C63BF09C85CACABF7CEB.Helpers.tableReader_a88be26b47f44da98aff1a3a7a9581e5_Greedy<TInputBuffer> GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, Cinematic value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(Cinematic? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(Cinematic? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(Cinematic[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<Cinematic> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(Cinematic item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, Cinematic item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(Cinematic item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ Cinematic ], Count = {Count}")]
	internal sealed class GeneratedVector_3679b404a8496f38a532164f03f60119_GreedyMutable<TInputBuffer> : IList<Cinematic>, ICollection<Cinematic>, IEnumerable<Cinematic>, IEnumerable, IReadOnlyList<Cinematic>, IReadOnlyCollection<Cinematic> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<Cinematic> list;

		public Cinematic this[int index]
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

		public GeneratedVector_3679b404a8496f38a532164f03f60119_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<Cinematic> list = (this.list = new List<Cinematic>());
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.NA0DB75AEFD3B890080AA25971C19D4FBC47079AFB7E1C63BF09C85CACABF7CEB.Helpers.tableReader_a88be26b47f44da98aff1a3a7a9581e5_GreedyMutable<TInputBuffer> item = FlatSharp.Compiler.Generated.NA0DB75AEFD3B890080AA25971C19D4FBC47079AFB7E1C63BF09C85CACABF7CEB.Helpers.Parse_GreedyMutable(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private Cinematic GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, Cinematic value)
		{
			list[index] = value;
		}

		public void Add(Cinematic item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, Cinematic item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(Cinematic item)
		{
			return list.Remove(item);
		}

		public bool Contains(Cinematic? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(Cinematic? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(Cinematic[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<Cinematic> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<Cinematic> value)
	{
		int count = value.Count;
		int num = 14;
		if (value is Cinematic[] array)
		{
			foreach (Cinematic cinematic in array)
			{
				SerializationHelpers.EnsureNonNull(cinematic);
				num += FlatSharp.Compiler.Generated.NA0DB75AEFD3B890080AA25971C19D4FBC47079AFB7E1C63BF09C85CACABF7CEB.Helpers.GetMaxSize(cinematic);
			}
		}
		else if (value is List<Cinematic> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				Cinematic cinematic2 = list[j];
				SerializationHelpers.EnsureNonNull(cinematic2);
				num += FlatSharp.Compiler.Generated.NA0DB75AEFD3B890080AA25971C19D4FBC47079AFB7E1C63BF09C85CACABF7CEB.Helpers.GetMaxSize(cinematic2);
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				Cinematic cinematic3 = value[k];
				SerializationHelpers.EnsureNonNull(cinematic3);
				num += FlatSharp.Compiler.Generated.NA0DB75AEFD3B890080AA25971C19D4FBC47079AFB7E1C63BF09C85CACABF7CEB.Helpers.GetMaxSize(cinematic3);
			}
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<Cinematic> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 4);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is Cinematic[] array)
		{
			foreach (Cinematic cinematic in array)
			{
				SerializationHelpers.EnsureNonNull(cinematic);
				FlatSharp.Compiler.Generated.NA0DB75AEFD3B890080AA25971C19D4FBC47079AFB7E1C63BF09C85CACABF7CEB.Helpers.Serialize(spanWriter, span, cinematic, num, context);
				num += 4;
			}
		}
		else if (value is List<Cinematic> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				Cinematic cinematic2 = list[j];
				SerializationHelpers.EnsureNonNull(cinematic2);
				FlatSharp.Compiler.Generated.NA0DB75AEFD3B890080AA25971C19D4FBC47079AFB7E1C63BF09C85CACABF7CEB.Helpers.Serialize(spanWriter, span, cinematic2, num, context);
				num += 4;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				Cinematic cinematic3 = value[k];
				SerializationHelpers.EnsureNonNull(cinematic3);
				FlatSharp.Compiler.Generated.NA0DB75AEFD3B890080AA25971C19D4FBC47079AFB7E1C63BF09C85CACABF7CEB.Helpers.Serialize(spanWriter, span, cinematic3, num, context);
				num += 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<Cinematic> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_3679b404a8496f38a532164f03f60119_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<Cinematic> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_3679b404a8496f38a532164f03f60119_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<Cinematic> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_3679b404a8496f38a532164f03f60119_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<Cinematic> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_3679b404a8496f38a532164f03f60119_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
