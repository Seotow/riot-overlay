using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Snapshot;
using FlatSharp.Compiler.Generated.N5867525DCCF5EE4F97804CC2B1C8847B92BD786B7860871AEA9A05526F9EC1B9;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.NC26A595523A24B17875FED6DE6040E1026980B5652454680EF2E8F76BDFF6065;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ AIMinionClient ], Count = {Count}")]
	internal sealed class GeneratedVector_eaa133d49d2e5cc5ec124f764d2634e9_Lazy<TInputBuffer> : IList<AIMinionClient>, ICollection<AIMinionClient>, IEnumerable<AIMinionClient>, IEnumerable, IReadOnlyList<AIMinionClient>, IReadOnlyCollection<AIMinionClient>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public AIMinionClient this[int index]
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

		public GeneratedVector_eaa133d49d2e5cc5ec124f764d2634e9_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N5867525DCCF5EE4F97804CC2B1C8847B92BD786B7860871AEA9A05526F9EC1B9.Helpers.tableReader_8d8fedf7623248ff853123763aa3ef2d_Lazy<TInputBuffer> SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N5867525DCCF5EE4F97804CC2B1C8847B92BD786B7860871AEA9A05526F9EC1B9.Helpers.tableReader_8d8fedf7623248ff853123763aa3ef2d_Lazy<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return FlatSharp.Compiler.Generated.N5867525DCCF5EE4F97804CC2B1C8847B92BD786B7860871AEA9A05526F9EC1B9.Helpers.Parse_Lazy(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, AIMinionClient value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(AIMinionClient? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(AIMinionClient? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(AIMinionClient[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<AIMinionClient> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(AIMinionClient item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, AIMinionClient item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(AIMinionClient item)
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

	[DebuggerDisplay("Progressive [ AIMinionClient ], Count = {Count}")]
	internal sealed class GeneratedVector_eaa133d49d2e5cc5ec124f764d2634e9_Progressive<TInputBuffer> : IList<AIMinionClient>, ICollection<AIMinionClient>, IEnumerable<AIMinionClient>, IEnumerable, IReadOnlyList<AIMinionClient>, IReadOnlyCollection<AIMinionClient>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly FlatSharp.Compiler.Generated.N5867525DCCF5EE4F97804CC2B1C8847B92BD786B7860871AEA9A05526F9EC1B9.Helpers.tableReader_8d8fedf7623248ff853123763aa3ef2d_Progressive<TInputBuffer>?[]?[] items;

		public AIMinionClient this[int index]
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

		public GeneratedVector_eaa133d49d2e5cc5ec124f764d2634e9_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new FlatSharp.Compiler.Generated.N5867525DCCF5EE4F97804CC2B1C8847B92BD786B7860871AEA9A05526F9EC1B9.Helpers.tableReader_8d8fedf7623248ff853123763aa3ef2d_Progressive<TInputBuffer>[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N5867525DCCF5EE4F97804CC2B1C8847B92BD786B7860871AEA9A05526F9EC1B9.Helpers.tableReader_8d8fedf7623248ff853123763aa3ef2d_Progressive<TInputBuffer>?[] GetOrCreateRow(FlatSharp.Compiler.Generated.N5867525DCCF5EE4F97804CC2B1C8847B92BD786B7860871AEA9A05526F9EC1B9.Helpers.tableReader_8d8fedf7623248ff853123763aa3ef2d_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private FlatSharp.Compiler.Generated.N5867525DCCF5EE4F97804CC2B1C8847B92BD786B7860871AEA9A05526F9EC1B9.Helpers.tableReader_8d8fedf7623248ff853123763aa3ef2d_Progressive<TInputBuffer>?[] CreateRow(FlatSharp.Compiler.Generated.N5867525DCCF5EE4F97804CC2B1C8847B92BD786B7860871AEA9A05526F9EC1B9.Helpers.tableReader_8d8fedf7623248ff853123763aa3ef2d_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] = new FlatSharp.Compiler.Generated.N5867525DCCF5EE4F97804CC2B1C8847B92BD786B7860871AEA9A05526F9EC1B9.Helpers.tableReader_8d8fedf7623248ff853123763aa3ef2d_Progressive<TInputBuffer>[32];
		}

		private FlatSharp.Compiler.Generated.N5867525DCCF5EE4F97804CC2B1C8847B92BD786B7860871AEA9A05526F9EC1B9.Helpers.tableReader_8d8fedf7623248ff853123763aa3ef2d_Progressive<TInputBuffer> ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			FlatSharp.Compiler.Generated.N5867525DCCF5EE4F97804CC2B1C8847B92BD786B7860871AEA9A05526F9EC1B9.Helpers.tableReader_8d8fedf7623248ff853123763aa3ef2d_Progressive<TInputBuffer>[][] array = items;
			FlatSharp.Compiler.Generated.N5867525DCCF5EE4F97804CC2B1C8847B92BD786B7860871AEA9A05526F9EC1B9.Helpers.tableReader_8d8fedf7623248ff853123763aa3ef2d_Progressive<TInputBuffer>[] orCreateRow = GetOrCreateRow(array, rowIndex);
			FlatSharp.Compiler.Generated.N5867525DCCF5EE4F97804CC2B1C8847B92BD786B7860871AEA9A05526F9EC1B9.Helpers.tableReader_8d8fedf7623248ff853123763aa3ef2d_Progressive<TInputBuffer> tableReader_8d8fedf7623248ff853123763aa3ef2d_Progressive = orCreateRow[colIndex];
			if ((object)tableReader_8d8fedf7623248ff853123763aa3ef2d_Progressive == null)
			{
				tableReader_8d8fedf7623248ff853123763aa3ef2d_Progressive = (orCreateRow[colIndex] = UnsafeParseItem(index));
			}
			return tableReader_8d8fedf7623248ff853123763aa3ef2d_Progressive;
		}

		private void ProgressiveSet(int index, AIMinionClient value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, AIMinionClient value)
		{
			VectorUtilities.CheckIndex(index, count);
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N5867525DCCF5EE4F97804CC2B1C8847B92BD786B7860871AEA9A05526F9EC1B9.Helpers.tableReader_8d8fedf7623248ff853123763aa3ef2d_Progressive<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N5867525DCCF5EE4F97804CC2B1C8847B92BD786B7860871AEA9A05526F9EC1B9.Helpers.tableReader_8d8fedf7623248ff853123763aa3ef2d_Progressive<TInputBuffer> UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.N5867525DCCF5EE4F97804CC2B1C8847B92BD786B7860871AEA9A05526F9EC1B9.Helpers.Parse_Progressive(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, AIMinionClient value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(AIMinionClient? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(AIMinionClient? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(AIMinionClient[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<AIMinionClient> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(AIMinionClient item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, AIMinionClient item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(AIMinionClient item)
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

	[DebuggerDisplay("Greedy [ AIMinionClient ], Count = {Count}")]
	internal sealed class GeneratedVector_eaa133d49d2e5cc5ec124f764d2634e9_Greedy<TInputBuffer> : IList<AIMinionClient>, ICollection<AIMinionClient>, IEnumerable<AIMinionClient>, IEnumerable, IReadOnlyList<AIMinionClient>, IReadOnlyCollection<AIMinionClient> where TInputBuffer : IInputBuffer
	{
		private readonly List<FlatSharp.Compiler.Generated.N5867525DCCF5EE4F97804CC2B1C8847B92BD786B7860871AEA9A05526F9EC1B9.Helpers.tableReader_8d8fedf7623248ff853123763aa3ef2d_Greedy<TInputBuffer>> list;

		public AIMinionClient this[int index]
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

		public GeneratedVector_eaa133d49d2e5cc5ec124f764d2634e9_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<FlatSharp.Compiler.Generated.N5867525DCCF5EE4F97804CC2B1C8847B92BD786B7860871AEA9A05526F9EC1B9.Helpers.tableReader_8d8fedf7623248ff853123763aa3ef2d_Greedy<TInputBuffer>> list = (this.list = new List<FlatSharp.Compiler.Generated.N5867525DCCF5EE4F97804CC2B1C8847B92BD786B7860871AEA9A05526F9EC1B9.Helpers.tableReader_8d8fedf7623248ff853123763aa3ef2d_Greedy<TInputBuffer>>(num));
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.N5867525DCCF5EE4F97804CC2B1C8847B92BD786B7860871AEA9A05526F9EC1B9.Helpers.tableReader_8d8fedf7623248ff853123763aa3ef2d_Greedy<TInputBuffer> item = FlatSharp.Compiler.Generated.N5867525DCCF5EE4F97804CC2B1C8847B92BD786B7860871AEA9A05526F9EC1B9.Helpers.Parse_Greedy(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		private FlatSharp.Compiler.Generated.N5867525DCCF5EE4F97804CC2B1C8847B92BD786B7860871AEA9A05526F9EC1B9.Helpers.tableReader_8d8fedf7623248ff853123763aa3ef2d_Greedy<TInputBuffer> GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, AIMinionClient value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(AIMinionClient? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(AIMinionClient? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(AIMinionClient[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<AIMinionClient> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(AIMinionClient item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, AIMinionClient item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(AIMinionClient item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ AIMinionClient ], Count = {Count}")]
	internal sealed class GeneratedVector_eaa133d49d2e5cc5ec124f764d2634e9_GreedyMutable<TInputBuffer> : IList<AIMinionClient>, ICollection<AIMinionClient>, IEnumerable<AIMinionClient>, IEnumerable, IReadOnlyList<AIMinionClient>, IReadOnlyCollection<AIMinionClient> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<AIMinionClient> list;

		public AIMinionClient this[int index]
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

		public GeneratedVector_eaa133d49d2e5cc5ec124f764d2634e9_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<AIMinionClient> list = (this.list = new List<AIMinionClient>());
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.N5867525DCCF5EE4F97804CC2B1C8847B92BD786B7860871AEA9A05526F9EC1B9.Helpers.tableReader_8d8fedf7623248ff853123763aa3ef2d_GreedyMutable<TInputBuffer> item = FlatSharp.Compiler.Generated.N5867525DCCF5EE4F97804CC2B1C8847B92BD786B7860871AEA9A05526F9EC1B9.Helpers.Parse_GreedyMutable(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private AIMinionClient GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, AIMinionClient value)
		{
			list[index] = value;
		}

		public void Add(AIMinionClient item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, AIMinionClient item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(AIMinionClient item)
		{
			return list.Remove(item);
		}

		public bool Contains(AIMinionClient? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(AIMinionClient? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(AIMinionClient[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<AIMinionClient> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<AIMinionClient> value)
	{
		int count = value.Count;
		int num = 14;
		if (value is AIMinionClient[] array)
		{
			foreach (AIMinionClient aIMinionClient in array)
			{
				SerializationHelpers.EnsureNonNull(aIMinionClient);
				num += FlatSharp.Compiler.Generated.N5867525DCCF5EE4F97804CC2B1C8847B92BD786B7860871AEA9A05526F9EC1B9.Helpers.GetMaxSize(aIMinionClient);
			}
		}
		else if (value is List<AIMinionClient> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				AIMinionClient aIMinionClient2 = list[j];
				SerializationHelpers.EnsureNonNull(aIMinionClient2);
				num += FlatSharp.Compiler.Generated.N5867525DCCF5EE4F97804CC2B1C8847B92BD786B7860871AEA9A05526F9EC1B9.Helpers.GetMaxSize(aIMinionClient2);
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				AIMinionClient aIMinionClient3 = value[k];
				SerializationHelpers.EnsureNonNull(aIMinionClient3);
				num += FlatSharp.Compiler.Generated.N5867525DCCF5EE4F97804CC2B1C8847B92BD786B7860871AEA9A05526F9EC1B9.Helpers.GetMaxSize(aIMinionClient3);
			}
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<AIMinionClient> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 4);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is AIMinionClient[] array)
		{
			foreach (AIMinionClient aIMinionClient in array)
			{
				SerializationHelpers.EnsureNonNull(aIMinionClient);
				FlatSharp.Compiler.Generated.N5867525DCCF5EE4F97804CC2B1C8847B92BD786B7860871AEA9A05526F9EC1B9.Helpers.Serialize(spanWriter, span, aIMinionClient, num, context);
				num += 4;
			}
		}
		else if (value is List<AIMinionClient> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				AIMinionClient aIMinionClient2 = list[j];
				SerializationHelpers.EnsureNonNull(aIMinionClient2);
				FlatSharp.Compiler.Generated.N5867525DCCF5EE4F97804CC2B1C8847B92BD786B7860871AEA9A05526F9EC1B9.Helpers.Serialize(spanWriter, span, aIMinionClient2, num, context);
				num += 4;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				AIMinionClient aIMinionClient3 = value[k];
				SerializationHelpers.EnsureNonNull(aIMinionClient3);
				FlatSharp.Compiler.Generated.N5867525DCCF5EE4F97804CC2B1C8847B92BD786B7860871AEA9A05526F9EC1B9.Helpers.Serialize(spanWriter, span, aIMinionClient3, num, context);
				num += 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<AIMinionClient> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_eaa133d49d2e5cc5ec124f764d2634e9_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<AIMinionClient> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_eaa133d49d2e5cc5ec124f764d2634e9_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<AIMinionClient> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_eaa133d49d2e5cc5ec124f764d2634e9_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<AIMinionClient> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_eaa133d49d2e5cc5ec124f764d2634e9_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
