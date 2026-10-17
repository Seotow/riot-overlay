using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Snapshot;
using FlatSharp.Compiler.Generated.N8137BE91DEFC4A09E7F22E8CCE3352EAC569B9157F01E6B61D1A8975A36EFE78;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.NC1B6C08D5228CB8BCD2863D83490E105854A4CFEC668E6B85805B09AE2AF0FA5;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ Animation ], Count = {Count}")]
	internal sealed class GeneratedVector_dfe58c0d57e45575d85f5c6ab9cc5bf5_Lazy<TInputBuffer> : IList<Animation>, ICollection<Animation>, IEnumerable<Animation>, IEnumerable, IReadOnlyList<Animation>, IReadOnlyCollection<Animation>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public Animation this[int index]
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

		int IFlatBufferDeserializedVector.ItemSize => 8;

		int IFlatBufferDeserializedVector.OffsetBase => offset;

		public GeneratedVector_dfe58c0d57e45575d85f5c6ab9cc5bf5_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N8137BE91DEFC4A09E7F22E8CCE3352EAC569B9157F01E6B61D1A8975A36EFE78.Helpers.structReader_09d5313f4cf144e8b955da9b91ce046a_Lazy<TInputBuffer> SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N8137BE91DEFC4A09E7F22E8CCE3352EAC569B9157F01E6B61D1A8975A36EFE78.Helpers.structReader_09d5313f4cf144e8b955da9b91ce046a_Lazy<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 3);
			return FlatSharp.Compiler.Generated.N8137BE91DEFC4A09E7F22E8CCE3352EAC569B9157F01E6B61D1A8975A36EFE78.Helpers.Parse_Lazy(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, Animation value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(Animation? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(Animation? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(Animation[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<Animation> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(Animation item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, Animation item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(Animation item)
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
			return offset + (index << 3);
		}
	}

	[DebuggerDisplay("Progressive [ Animation ], Count = {Count}")]
	internal sealed class GeneratedVector_dfe58c0d57e45575d85f5c6ab9cc5bf5_Progressive<TInputBuffer> : IList<Animation>, ICollection<Animation>, IEnumerable<Animation>, IEnumerable, IReadOnlyList<Animation>, IReadOnlyCollection<Animation>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly FlatSharp.Compiler.Generated.N8137BE91DEFC4A09E7F22E8CCE3352EAC569B9157F01E6B61D1A8975A36EFE78.Helpers.structReader_09d5313f4cf144e8b955da9b91ce046a_Progressive<TInputBuffer>?[]?[] items;

		public Animation this[int index]
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

		int IFlatBufferDeserializedVector.ItemSize => 8;

		int IFlatBufferDeserializedVector.OffsetBase => offset;

		public GeneratedVector_dfe58c0d57e45575d85f5c6ab9cc5bf5_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new FlatSharp.Compiler.Generated.N8137BE91DEFC4A09E7F22E8CCE3352EAC569B9157F01E6B61D1A8975A36EFE78.Helpers.structReader_09d5313f4cf144e8b955da9b91ce046a_Progressive<TInputBuffer>[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N8137BE91DEFC4A09E7F22E8CCE3352EAC569B9157F01E6B61D1A8975A36EFE78.Helpers.structReader_09d5313f4cf144e8b955da9b91ce046a_Progressive<TInputBuffer>?[] GetOrCreateRow(FlatSharp.Compiler.Generated.N8137BE91DEFC4A09E7F22E8CCE3352EAC569B9157F01E6B61D1A8975A36EFE78.Helpers.structReader_09d5313f4cf144e8b955da9b91ce046a_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private FlatSharp.Compiler.Generated.N8137BE91DEFC4A09E7F22E8CCE3352EAC569B9157F01E6B61D1A8975A36EFE78.Helpers.structReader_09d5313f4cf144e8b955da9b91ce046a_Progressive<TInputBuffer>?[] CreateRow(FlatSharp.Compiler.Generated.N8137BE91DEFC4A09E7F22E8CCE3352EAC569B9157F01E6B61D1A8975A36EFE78.Helpers.structReader_09d5313f4cf144e8b955da9b91ce046a_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] = new FlatSharp.Compiler.Generated.N8137BE91DEFC4A09E7F22E8CCE3352EAC569B9157F01E6B61D1A8975A36EFE78.Helpers.structReader_09d5313f4cf144e8b955da9b91ce046a_Progressive<TInputBuffer>[32];
		}

		private FlatSharp.Compiler.Generated.N8137BE91DEFC4A09E7F22E8CCE3352EAC569B9157F01E6B61D1A8975A36EFE78.Helpers.structReader_09d5313f4cf144e8b955da9b91ce046a_Progressive<TInputBuffer> ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			FlatSharp.Compiler.Generated.N8137BE91DEFC4A09E7F22E8CCE3352EAC569B9157F01E6B61D1A8975A36EFE78.Helpers.structReader_09d5313f4cf144e8b955da9b91ce046a_Progressive<TInputBuffer>[][] array = items;
			FlatSharp.Compiler.Generated.N8137BE91DEFC4A09E7F22E8CCE3352EAC569B9157F01E6B61D1A8975A36EFE78.Helpers.structReader_09d5313f4cf144e8b955da9b91ce046a_Progressive<TInputBuffer>[] orCreateRow = GetOrCreateRow(array, rowIndex);
			FlatSharp.Compiler.Generated.N8137BE91DEFC4A09E7F22E8CCE3352EAC569B9157F01E6B61D1A8975A36EFE78.Helpers.structReader_09d5313f4cf144e8b955da9b91ce046a_Progressive<TInputBuffer> structReader_09d5313f4cf144e8b955da9b91ce046a_Progressive = orCreateRow[colIndex];
			if (structReader_09d5313f4cf144e8b955da9b91ce046a_Progressive == null)
			{
				structReader_09d5313f4cf144e8b955da9b91ce046a_Progressive = (orCreateRow[colIndex] = UnsafeParseItem(index));
			}
			return structReader_09d5313f4cf144e8b955da9b91ce046a_Progressive;
		}

		private void ProgressiveSet(int index, Animation value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, Animation value)
		{
			VectorUtilities.CheckIndex(index, count);
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N8137BE91DEFC4A09E7F22E8CCE3352EAC569B9157F01E6B61D1A8975A36EFE78.Helpers.structReader_09d5313f4cf144e8b955da9b91ce046a_Progressive<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 3);
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N8137BE91DEFC4A09E7F22E8CCE3352EAC569B9157F01E6B61D1A8975A36EFE78.Helpers.structReader_09d5313f4cf144e8b955da9b91ce046a_Progressive<TInputBuffer> UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.N8137BE91DEFC4A09E7F22E8CCE3352EAC569B9157F01E6B61D1A8975A36EFE78.Helpers.Parse_Progressive(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, Animation value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(Animation? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(Animation? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(Animation[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<Animation> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(Animation item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, Animation item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(Animation item)
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
			return offset + (index << 3);
		}
	}

	[DebuggerDisplay("Greedy [ Animation ], Count = {Count}")]
	internal sealed class GeneratedVector_dfe58c0d57e45575d85f5c6ab9cc5bf5_Greedy<TInputBuffer> : IList<Animation>, ICollection<Animation>, IEnumerable<Animation>, IEnumerable, IReadOnlyList<Animation>, IReadOnlyCollection<Animation> where TInputBuffer : IInputBuffer
	{
		private readonly List<FlatSharp.Compiler.Generated.N8137BE91DEFC4A09E7F22E8CCE3352EAC569B9157F01E6B61D1A8975A36EFE78.Helpers.structReader_09d5313f4cf144e8b955da9b91ce046a_Greedy<TInputBuffer>> list;

		public Animation this[int index]
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

		public GeneratedVector_dfe58c0d57e45575d85f5c6ab9cc5bf5_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<FlatSharp.Compiler.Generated.N8137BE91DEFC4A09E7F22E8CCE3352EAC569B9157F01E6B61D1A8975A36EFE78.Helpers.structReader_09d5313f4cf144e8b955da9b91ce046a_Greedy<TInputBuffer>> list = (this.list = new List<FlatSharp.Compiler.Generated.N8137BE91DEFC4A09E7F22E8CCE3352EAC569B9157F01E6B61D1A8975A36EFE78.Helpers.structReader_09d5313f4cf144e8b955da9b91ce046a_Greedy<TInputBuffer>>(num));
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.N8137BE91DEFC4A09E7F22E8CCE3352EAC569B9157F01E6B61D1A8975A36EFE78.Helpers.structReader_09d5313f4cf144e8b955da9b91ce046a_Greedy<TInputBuffer> item = FlatSharp.Compiler.Generated.N8137BE91DEFC4A09E7F22E8CCE3352EAC569B9157F01E6B61D1A8975A36EFE78.Helpers.Parse_Greedy(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 8;
			}
		}

		private FlatSharp.Compiler.Generated.N8137BE91DEFC4A09E7F22E8CCE3352EAC569B9157F01E6B61D1A8975A36EFE78.Helpers.structReader_09d5313f4cf144e8b955da9b91ce046a_Greedy<TInputBuffer> GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, Animation value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(Animation? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(Animation? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(Animation[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<Animation> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(Animation item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, Animation item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(Animation item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ Animation ], Count = {Count}")]
	internal sealed class GeneratedVector_dfe58c0d57e45575d85f5c6ab9cc5bf5_GreedyMutable<TInputBuffer> : IList<Animation>, ICollection<Animation>, IEnumerable<Animation>, IEnumerable, IReadOnlyList<Animation>, IReadOnlyCollection<Animation> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<Animation> list;

		public Animation this[int index]
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

		public GeneratedVector_dfe58c0d57e45575d85f5c6ab9cc5bf5_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<Animation> list = (this.list = new List<Animation>());
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.N8137BE91DEFC4A09E7F22E8CCE3352EAC569B9157F01E6B61D1A8975A36EFE78.Helpers.structReader_09d5313f4cf144e8b955da9b91ce046a_GreedyMutable<TInputBuffer> item = FlatSharp.Compiler.Generated.N8137BE91DEFC4A09E7F22E8CCE3352EAC569B9157F01E6B61D1A8975A36EFE78.Helpers.Parse_GreedyMutable(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 8;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private Animation GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, Animation value)
		{
			list[index] = value;
		}

		public void Add(Animation item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, Animation item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(Animation item)
		{
			return list.Remove(item);
		}

		public bool Contains(Animation? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(Animation? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(Animation[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<Animation> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<Animation> value)
	{
		return 10 + 8 * value.Count;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<Animation> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 8);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is Animation[] array)
		{
			foreach (Animation animation in array)
			{
				SerializationHelpers.EnsureNonNull(animation);
				FlatSharp.Compiler.Generated.N8137BE91DEFC4A09E7F22E8CCE3352EAC569B9157F01E6B61D1A8975A36EFE78.Helpers.Serialize(spanWriter, span, animation, num);
				num += 8;
			}
		}
		else if (value is List<Animation> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				Animation animation2 = list[j];
				SerializationHelpers.EnsureNonNull(animation2);
				FlatSharp.Compiler.Generated.N8137BE91DEFC4A09E7F22E8CCE3352EAC569B9157F01E6B61D1A8975A36EFE78.Helpers.Serialize(spanWriter, span, animation2, num);
				num += 8;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				Animation animation3 = value[k];
				SerializationHelpers.EnsureNonNull(animation3);
				FlatSharp.Compiler.Generated.N8137BE91DEFC4A09E7F22E8CCE3352EAC569B9157F01E6B61D1A8975A36EFE78.Helpers.Serialize(spanWriter, span, animation3, num);
				num += 8;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<Animation> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_dfe58c0d57e45575d85f5c6ab9cc5bf5_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<Animation> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_dfe58c0d57e45575d85f5c6ab9cc5bf5_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<Animation> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_dfe58c0d57e45575d85f5c6ab9cc5bf5_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<Animation> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_dfe58c0d57e45575d85f5c6ab9cc5bf5_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
