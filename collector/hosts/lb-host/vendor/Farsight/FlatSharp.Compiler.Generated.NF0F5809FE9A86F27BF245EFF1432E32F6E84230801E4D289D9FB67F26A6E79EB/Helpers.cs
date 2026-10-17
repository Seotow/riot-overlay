using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Entity;
using FlatSharp.Compiler.Generated.NF1655621F224A077756AD5B696369AACD1355A8756AAAF1E7B1252128D4FD16E;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.NF0F5809FE9A86F27BF245EFF1432E32F6E84230801E4D289D9FB67F26A6E79EB;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ AnimationStateDefinition ], Count = {Count}")]
	internal sealed class GeneratedVector_2053f81e71dd3c10e48c19d801a3297f_Lazy<TInputBuffer> : IList<AnimationStateDefinition>, ICollection<AnimationStateDefinition>, IEnumerable<AnimationStateDefinition>, IEnumerable, IReadOnlyList<AnimationStateDefinition>, IReadOnlyCollection<AnimationStateDefinition>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public AnimationStateDefinition this[int index]
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

		public GeneratedVector_2053f81e71dd3c10e48c19d801a3297f_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NF1655621F224A077756AD5B696369AACD1355A8756AAAF1E7B1252128D4FD16E.Helpers.tableReader_02bd892eec4a4e0ca659c0b0ce290dfa_Lazy<TInputBuffer> SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NF1655621F224A077756AD5B696369AACD1355A8756AAAF1E7B1252128D4FD16E.Helpers.tableReader_02bd892eec4a4e0ca659c0b0ce290dfa_Lazy<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return FlatSharp.Compiler.Generated.NF1655621F224A077756AD5B696369AACD1355A8756AAAF1E7B1252128D4FD16E.Helpers.Parse_Lazy(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, AnimationStateDefinition value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(AnimationStateDefinition? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(AnimationStateDefinition? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(AnimationStateDefinition[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<AnimationStateDefinition> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(AnimationStateDefinition item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, AnimationStateDefinition item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(AnimationStateDefinition item)
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

	[DebuggerDisplay("Progressive [ AnimationStateDefinition ], Count = {Count}")]
	internal sealed class GeneratedVector_2053f81e71dd3c10e48c19d801a3297f_Progressive<TInputBuffer> : IList<AnimationStateDefinition>, ICollection<AnimationStateDefinition>, IEnumerable<AnimationStateDefinition>, IEnumerable, IReadOnlyList<AnimationStateDefinition>, IReadOnlyCollection<AnimationStateDefinition>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly FlatSharp.Compiler.Generated.NF1655621F224A077756AD5B696369AACD1355A8756AAAF1E7B1252128D4FD16E.Helpers.tableReader_02bd892eec4a4e0ca659c0b0ce290dfa_Progressive<TInputBuffer>?[]?[] items;

		public AnimationStateDefinition this[int index]
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

		public GeneratedVector_2053f81e71dd3c10e48c19d801a3297f_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new FlatSharp.Compiler.Generated.NF1655621F224A077756AD5B696369AACD1355A8756AAAF1E7B1252128D4FD16E.Helpers.tableReader_02bd892eec4a4e0ca659c0b0ce290dfa_Progressive<TInputBuffer>[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NF1655621F224A077756AD5B696369AACD1355A8756AAAF1E7B1252128D4FD16E.Helpers.tableReader_02bd892eec4a4e0ca659c0b0ce290dfa_Progressive<TInputBuffer>?[] GetOrCreateRow(FlatSharp.Compiler.Generated.NF1655621F224A077756AD5B696369AACD1355A8756AAAF1E7B1252128D4FD16E.Helpers.tableReader_02bd892eec4a4e0ca659c0b0ce290dfa_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private FlatSharp.Compiler.Generated.NF1655621F224A077756AD5B696369AACD1355A8756AAAF1E7B1252128D4FD16E.Helpers.tableReader_02bd892eec4a4e0ca659c0b0ce290dfa_Progressive<TInputBuffer>?[] CreateRow(FlatSharp.Compiler.Generated.NF1655621F224A077756AD5B696369AACD1355A8756AAAF1E7B1252128D4FD16E.Helpers.tableReader_02bd892eec4a4e0ca659c0b0ce290dfa_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] = new FlatSharp.Compiler.Generated.NF1655621F224A077756AD5B696369AACD1355A8756AAAF1E7B1252128D4FD16E.Helpers.tableReader_02bd892eec4a4e0ca659c0b0ce290dfa_Progressive<TInputBuffer>[32];
		}

		private FlatSharp.Compiler.Generated.NF1655621F224A077756AD5B696369AACD1355A8756AAAF1E7B1252128D4FD16E.Helpers.tableReader_02bd892eec4a4e0ca659c0b0ce290dfa_Progressive<TInputBuffer> ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			FlatSharp.Compiler.Generated.NF1655621F224A077756AD5B696369AACD1355A8756AAAF1E7B1252128D4FD16E.Helpers.tableReader_02bd892eec4a4e0ca659c0b0ce290dfa_Progressive<TInputBuffer>[][] array = items;
			FlatSharp.Compiler.Generated.NF1655621F224A077756AD5B696369AACD1355A8756AAAF1E7B1252128D4FD16E.Helpers.tableReader_02bd892eec4a4e0ca659c0b0ce290dfa_Progressive<TInputBuffer>[] orCreateRow = GetOrCreateRow(array, rowIndex);
			FlatSharp.Compiler.Generated.NF1655621F224A077756AD5B696369AACD1355A8756AAAF1E7B1252128D4FD16E.Helpers.tableReader_02bd892eec4a4e0ca659c0b0ce290dfa_Progressive<TInputBuffer> tableReader_02bd892eec4a4e0ca659c0b0ce290dfa_Progressive = orCreateRow[colIndex];
			if (tableReader_02bd892eec4a4e0ca659c0b0ce290dfa_Progressive == null)
			{
				tableReader_02bd892eec4a4e0ca659c0b0ce290dfa_Progressive = (orCreateRow[colIndex] = UnsafeParseItem(index));
			}
			return tableReader_02bd892eec4a4e0ca659c0b0ce290dfa_Progressive;
		}

		private void ProgressiveSet(int index, AnimationStateDefinition value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, AnimationStateDefinition value)
		{
			VectorUtilities.CheckIndex(index, count);
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NF1655621F224A077756AD5B696369AACD1355A8756AAAF1E7B1252128D4FD16E.Helpers.tableReader_02bd892eec4a4e0ca659c0b0ce290dfa_Progressive<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NF1655621F224A077756AD5B696369AACD1355A8756AAAF1E7B1252128D4FD16E.Helpers.tableReader_02bd892eec4a4e0ca659c0b0ce290dfa_Progressive<TInputBuffer> UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.NF1655621F224A077756AD5B696369AACD1355A8756AAAF1E7B1252128D4FD16E.Helpers.Parse_Progressive(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, AnimationStateDefinition value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(AnimationStateDefinition? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(AnimationStateDefinition? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(AnimationStateDefinition[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<AnimationStateDefinition> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(AnimationStateDefinition item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, AnimationStateDefinition item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(AnimationStateDefinition item)
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

	[DebuggerDisplay("Greedy [ AnimationStateDefinition ], Count = {Count}")]
	internal sealed class GeneratedVector_2053f81e71dd3c10e48c19d801a3297f_Greedy<TInputBuffer> : IList<AnimationStateDefinition>, ICollection<AnimationStateDefinition>, IEnumerable<AnimationStateDefinition>, IEnumerable, IReadOnlyList<AnimationStateDefinition>, IReadOnlyCollection<AnimationStateDefinition> where TInputBuffer : IInputBuffer
	{
		private readonly List<FlatSharp.Compiler.Generated.NF1655621F224A077756AD5B696369AACD1355A8756AAAF1E7B1252128D4FD16E.Helpers.tableReader_02bd892eec4a4e0ca659c0b0ce290dfa_Greedy<TInputBuffer>> list;

		public AnimationStateDefinition this[int index]
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

		public GeneratedVector_2053f81e71dd3c10e48c19d801a3297f_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<FlatSharp.Compiler.Generated.NF1655621F224A077756AD5B696369AACD1355A8756AAAF1E7B1252128D4FD16E.Helpers.tableReader_02bd892eec4a4e0ca659c0b0ce290dfa_Greedy<TInputBuffer>> list = (this.list = new List<FlatSharp.Compiler.Generated.NF1655621F224A077756AD5B696369AACD1355A8756AAAF1E7B1252128D4FD16E.Helpers.tableReader_02bd892eec4a4e0ca659c0b0ce290dfa_Greedy<TInputBuffer>>(num));
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.NF1655621F224A077756AD5B696369AACD1355A8756AAAF1E7B1252128D4FD16E.Helpers.tableReader_02bd892eec4a4e0ca659c0b0ce290dfa_Greedy<TInputBuffer> item = FlatSharp.Compiler.Generated.NF1655621F224A077756AD5B696369AACD1355A8756AAAF1E7B1252128D4FD16E.Helpers.Parse_Greedy(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		private FlatSharp.Compiler.Generated.NF1655621F224A077756AD5B696369AACD1355A8756AAAF1E7B1252128D4FD16E.Helpers.tableReader_02bd892eec4a4e0ca659c0b0ce290dfa_Greedy<TInputBuffer> GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, AnimationStateDefinition value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(AnimationStateDefinition? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(AnimationStateDefinition? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(AnimationStateDefinition[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<AnimationStateDefinition> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(AnimationStateDefinition item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, AnimationStateDefinition item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(AnimationStateDefinition item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ AnimationStateDefinition ], Count = {Count}")]
	internal sealed class GeneratedVector_2053f81e71dd3c10e48c19d801a3297f_GreedyMutable<TInputBuffer> : IList<AnimationStateDefinition>, ICollection<AnimationStateDefinition>, IEnumerable<AnimationStateDefinition>, IEnumerable, IReadOnlyList<AnimationStateDefinition>, IReadOnlyCollection<AnimationStateDefinition> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<AnimationStateDefinition> list;

		public AnimationStateDefinition this[int index]
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

		public GeneratedVector_2053f81e71dd3c10e48c19d801a3297f_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<AnimationStateDefinition> list = (this.list = new List<AnimationStateDefinition>());
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.NF1655621F224A077756AD5B696369AACD1355A8756AAAF1E7B1252128D4FD16E.Helpers.tableReader_02bd892eec4a4e0ca659c0b0ce290dfa_GreedyMutable<TInputBuffer> item = FlatSharp.Compiler.Generated.NF1655621F224A077756AD5B696369AACD1355A8756AAAF1E7B1252128D4FD16E.Helpers.Parse_GreedyMutable(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private AnimationStateDefinition GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, AnimationStateDefinition value)
		{
			list[index] = value;
		}

		public void Add(AnimationStateDefinition item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, AnimationStateDefinition item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(AnimationStateDefinition item)
		{
			return list.Remove(item);
		}

		public bool Contains(AnimationStateDefinition? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(AnimationStateDefinition? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(AnimationStateDefinition[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<AnimationStateDefinition> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<AnimationStateDefinition> value)
	{
		int count = value.Count;
		int num = 14;
		if (value is AnimationStateDefinition[] array)
		{
			foreach (AnimationStateDefinition animationStateDefinition in array)
			{
				SerializationHelpers.EnsureNonNull(animationStateDefinition);
				num += FlatSharp.Compiler.Generated.NF1655621F224A077756AD5B696369AACD1355A8756AAAF1E7B1252128D4FD16E.Helpers.GetMaxSize(animationStateDefinition);
			}
		}
		else if (value is List<AnimationStateDefinition> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				AnimationStateDefinition animationStateDefinition2 = list[j];
				SerializationHelpers.EnsureNonNull(animationStateDefinition2);
				num += FlatSharp.Compiler.Generated.NF1655621F224A077756AD5B696369AACD1355A8756AAAF1E7B1252128D4FD16E.Helpers.GetMaxSize(animationStateDefinition2);
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				AnimationStateDefinition animationStateDefinition3 = value[k];
				SerializationHelpers.EnsureNonNull(animationStateDefinition3);
				num += FlatSharp.Compiler.Generated.NF1655621F224A077756AD5B696369AACD1355A8756AAAF1E7B1252128D4FD16E.Helpers.GetMaxSize(animationStateDefinition3);
			}
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<AnimationStateDefinition> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 4);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is AnimationStateDefinition[] array)
		{
			foreach (AnimationStateDefinition animationStateDefinition in array)
			{
				SerializationHelpers.EnsureNonNull(animationStateDefinition);
				FlatSharp.Compiler.Generated.NF1655621F224A077756AD5B696369AACD1355A8756AAAF1E7B1252128D4FD16E.Helpers.Serialize(spanWriter, span, animationStateDefinition, num, context);
				num += 4;
			}
		}
		else if (value is List<AnimationStateDefinition> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				AnimationStateDefinition animationStateDefinition2 = list[j];
				SerializationHelpers.EnsureNonNull(animationStateDefinition2);
				FlatSharp.Compiler.Generated.NF1655621F224A077756AD5B696369AACD1355A8756AAAF1E7B1252128D4FD16E.Helpers.Serialize(spanWriter, span, animationStateDefinition2, num, context);
				num += 4;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				AnimationStateDefinition animationStateDefinition3 = value[k];
				SerializationHelpers.EnsureNonNull(animationStateDefinition3);
				FlatSharp.Compiler.Generated.NF1655621F224A077756AD5B696369AACD1355A8756AAAF1E7B1252128D4FD16E.Helpers.Serialize(spanWriter, span, animationStateDefinition3, num, context);
				num += 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<AnimationStateDefinition> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_2053f81e71dd3c10e48c19d801a3297f_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<AnimationStateDefinition> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_2053f81e71dd3c10e48c19d801a3297f_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<AnimationStateDefinition> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_2053f81e71dd3c10e48c19d801a3297f_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<AnimationStateDefinition> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_2053f81e71dd3c10e48c19d801a3297f_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
