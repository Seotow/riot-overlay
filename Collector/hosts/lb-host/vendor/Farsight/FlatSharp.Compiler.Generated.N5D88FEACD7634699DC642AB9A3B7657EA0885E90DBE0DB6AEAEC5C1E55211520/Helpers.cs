using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Common;
using FlatSharp.Compiler.Generated.NBF15E9E76450B9068AEDC26E1E7D702F95BF8A5FBB9030539AE4F58B00FD3CB2;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N5D88FEACD7634699DC642AB9A3B7657EA0885E90DBE0DB6AEAEC5C1E55211520;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ ScriptVariableEnumOption ], Count = {Count}")]
	internal sealed class GeneratedVector_566890ee45abac29a0aed242dbe53616_Lazy<TInputBuffer> : IList<ScriptVariableEnumOption>, ICollection<ScriptVariableEnumOption>, IEnumerable<ScriptVariableEnumOption>, IEnumerable, IReadOnlyList<ScriptVariableEnumOption>, IReadOnlyCollection<ScriptVariableEnumOption>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public ScriptVariableEnumOption this[int index]
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

		public GeneratedVector_566890ee45abac29a0aed242dbe53616_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NBF15E9E76450B9068AEDC26E1E7D702F95BF8A5FBB9030539AE4F58B00FD3CB2.Helpers.tableReader_f755f65497f74eddb637278aa6257093_Lazy<TInputBuffer> SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NBF15E9E76450B9068AEDC26E1E7D702F95BF8A5FBB9030539AE4F58B00FD3CB2.Helpers.tableReader_f755f65497f74eddb637278aa6257093_Lazy<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return FlatSharp.Compiler.Generated.NBF15E9E76450B9068AEDC26E1E7D702F95BF8A5FBB9030539AE4F58B00FD3CB2.Helpers.Parse_Lazy(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, ScriptVariableEnumOption value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(ScriptVariableEnumOption? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(ScriptVariableEnumOption? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(ScriptVariableEnumOption[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<ScriptVariableEnumOption> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(ScriptVariableEnumOption item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, ScriptVariableEnumOption item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(ScriptVariableEnumOption item)
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

	[DebuggerDisplay("Progressive [ ScriptVariableEnumOption ], Count = {Count}")]
	internal sealed class GeneratedVector_566890ee45abac29a0aed242dbe53616_Progressive<TInputBuffer> : IList<ScriptVariableEnumOption>, ICollection<ScriptVariableEnumOption>, IEnumerable<ScriptVariableEnumOption>, IEnumerable, IReadOnlyList<ScriptVariableEnumOption>, IReadOnlyCollection<ScriptVariableEnumOption>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly FlatSharp.Compiler.Generated.NBF15E9E76450B9068AEDC26E1E7D702F95BF8A5FBB9030539AE4F58B00FD3CB2.Helpers.tableReader_f755f65497f74eddb637278aa6257093_Progressive<TInputBuffer>?[]?[] items;

		public ScriptVariableEnumOption this[int index]
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

		public GeneratedVector_566890ee45abac29a0aed242dbe53616_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new FlatSharp.Compiler.Generated.NBF15E9E76450B9068AEDC26E1E7D702F95BF8A5FBB9030539AE4F58B00FD3CB2.Helpers.tableReader_f755f65497f74eddb637278aa6257093_Progressive<TInputBuffer>[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NBF15E9E76450B9068AEDC26E1E7D702F95BF8A5FBB9030539AE4F58B00FD3CB2.Helpers.tableReader_f755f65497f74eddb637278aa6257093_Progressive<TInputBuffer>?[] GetOrCreateRow(FlatSharp.Compiler.Generated.NBF15E9E76450B9068AEDC26E1E7D702F95BF8A5FBB9030539AE4F58B00FD3CB2.Helpers.tableReader_f755f65497f74eddb637278aa6257093_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private FlatSharp.Compiler.Generated.NBF15E9E76450B9068AEDC26E1E7D702F95BF8A5FBB9030539AE4F58B00FD3CB2.Helpers.tableReader_f755f65497f74eddb637278aa6257093_Progressive<TInputBuffer>?[] CreateRow(FlatSharp.Compiler.Generated.NBF15E9E76450B9068AEDC26E1E7D702F95BF8A5FBB9030539AE4F58B00FD3CB2.Helpers.tableReader_f755f65497f74eddb637278aa6257093_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] = new FlatSharp.Compiler.Generated.NBF15E9E76450B9068AEDC26E1E7D702F95BF8A5FBB9030539AE4F58B00FD3CB2.Helpers.tableReader_f755f65497f74eddb637278aa6257093_Progressive<TInputBuffer>[32];
		}

		private FlatSharp.Compiler.Generated.NBF15E9E76450B9068AEDC26E1E7D702F95BF8A5FBB9030539AE4F58B00FD3CB2.Helpers.tableReader_f755f65497f74eddb637278aa6257093_Progressive<TInputBuffer> ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			FlatSharp.Compiler.Generated.NBF15E9E76450B9068AEDC26E1E7D702F95BF8A5FBB9030539AE4F58B00FD3CB2.Helpers.tableReader_f755f65497f74eddb637278aa6257093_Progressive<TInputBuffer>[][] array = items;
			FlatSharp.Compiler.Generated.NBF15E9E76450B9068AEDC26E1E7D702F95BF8A5FBB9030539AE4F58B00FD3CB2.Helpers.tableReader_f755f65497f74eddb637278aa6257093_Progressive<TInputBuffer>[] orCreateRow = GetOrCreateRow(array, rowIndex);
			FlatSharp.Compiler.Generated.NBF15E9E76450B9068AEDC26E1E7D702F95BF8A5FBB9030539AE4F58B00FD3CB2.Helpers.tableReader_f755f65497f74eddb637278aa6257093_Progressive<TInputBuffer> tableReader_f755f65497f74eddb637278aa6257093_Progressive = orCreateRow[colIndex];
			if (tableReader_f755f65497f74eddb637278aa6257093_Progressive == null)
			{
				tableReader_f755f65497f74eddb637278aa6257093_Progressive = (orCreateRow[colIndex] = UnsafeParseItem(index));
			}
			return tableReader_f755f65497f74eddb637278aa6257093_Progressive;
		}

		private void ProgressiveSet(int index, ScriptVariableEnumOption value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, ScriptVariableEnumOption value)
		{
			VectorUtilities.CheckIndex(index, count);
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NBF15E9E76450B9068AEDC26E1E7D702F95BF8A5FBB9030539AE4F58B00FD3CB2.Helpers.tableReader_f755f65497f74eddb637278aa6257093_Progressive<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NBF15E9E76450B9068AEDC26E1E7D702F95BF8A5FBB9030539AE4F58B00FD3CB2.Helpers.tableReader_f755f65497f74eddb637278aa6257093_Progressive<TInputBuffer> UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.NBF15E9E76450B9068AEDC26E1E7D702F95BF8A5FBB9030539AE4F58B00FD3CB2.Helpers.Parse_Progressive(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, ScriptVariableEnumOption value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(ScriptVariableEnumOption? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(ScriptVariableEnumOption? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(ScriptVariableEnumOption[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<ScriptVariableEnumOption> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(ScriptVariableEnumOption item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, ScriptVariableEnumOption item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(ScriptVariableEnumOption item)
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

	[DebuggerDisplay("Greedy [ ScriptVariableEnumOption ], Count = {Count}")]
	internal sealed class GeneratedVector_566890ee45abac29a0aed242dbe53616_Greedy<TInputBuffer> : IList<ScriptVariableEnumOption>, ICollection<ScriptVariableEnumOption>, IEnumerable<ScriptVariableEnumOption>, IEnumerable, IReadOnlyList<ScriptVariableEnumOption>, IReadOnlyCollection<ScriptVariableEnumOption> where TInputBuffer : IInputBuffer
	{
		private readonly List<FlatSharp.Compiler.Generated.NBF15E9E76450B9068AEDC26E1E7D702F95BF8A5FBB9030539AE4F58B00FD3CB2.Helpers.tableReader_f755f65497f74eddb637278aa6257093_Greedy<TInputBuffer>> list;

		public ScriptVariableEnumOption this[int index]
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

		public GeneratedVector_566890ee45abac29a0aed242dbe53616_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<FlatSharp.Compiler.Generated.NBF15E9E76450B9068AEDC26E1E7D702F95BF8A5FBB9030539AE4F58B00FD3CB2.Helpers.tableReader_f755f65497f74eddb637278aa6257093_Greedy<TInputBuffer>> list = (this.list = new List<FlatSharp.Compiler.Generated.NBF15E9E76450B9068AEDC26E1E7D702F95BF8A5FBB9030539AE4F58B00FD3CB2.Helpers.tableReader_f755f65497f74eddb637278aa6257093_Greedy<TInputBuffer>>(num));
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.NBF15E9E76450B9068AEDC26E1E7D702F95BF8A5FBB9030539AE4F58B00FD3CB2.Helpers.tableReader_f755f65497f74eddb637278aa6257093_Greedy<TInputBuffer> item = FlatSharp.Compiler.Generated.NBF15E9E76450B9068AEDC26E1E7D702F95BF8A5FBB9030539AE4F58B00FD3CB2.Helpers.Parse_Greedy(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		private FlatSharp.Compiler.Generated.NBF15E9E76450B9068AEDC26E1E7D702F95BF8A5FBB9030539AE4F58B00FD3CB2.Helpers.tableReader_f755f65497f74eddb637278aa6257093_Greedy<TInputBuffer> GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, ScriptVariableEnumOption value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(ScriptVariableEnumOption? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(ScriptVariableEnumOption? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(ScriptVariableEnumOption[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<ScriptVariableEnumOption> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(ScriptVariableEnumOption item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, ScriptVariableEnumOption item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(ScriptVariableEnumOption item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ ScriptVariableEnumOption ], Count = {Count}")]
	internal sealed class GeneratedVector_566890ee45abac29a0aed242dbe53616_GreedyMutable<TInputBuffer> : IList<ScriptVariableEnumOption>, ICollection<ScriptVariableEnumOption>, IEnumerable<ScriptVariableEnumOption>, IEnumerable, IReadOnlyList<ScriptVariableEnumOption>, IReadOnlyCollection<ScriptVariableEnumOption> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<ScriptVariableEnumOption> list;

		public ScriptVariableEnumOption this[int index]
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

		public GeneratedVector_566890ee45abac29a0aed242dbe53616_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<ScriptVariableEnumOption> list = (this.list = new List<ScriptVariableEnumOption>());
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.NBF15E9E76450B9068AEDC26E1E7D702F95BF8A5FBB9030539AE4F58B00FD3CB2.Helpers.tableReader_f755f65497f74eddb637278aa6257093_GreedyMutable<TInputBuffer> item = FlatSharp.Compiler.Generated.NBF15E9E76450B9068AEDC26E1E7D702F95BF8A5FBB9030539AE4F58B00FD3CB2.Helpers.Parse_GreedyMutable(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private ScriptVariableEnumOption GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, ScriptVariableEnumOption value)
		{
			list[index] = value;
		}

		public void Add(ScriptVariableEnumOption item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, ScriptVariableEnumOption item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(ScriptVariableEnumOption item)
		{
			return list.Remove(item);
		}

		public bool Contains(ScriptVariableEnumOption? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(ScriptVariableEnumOption? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(ScriptVariableEnumOption[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<ScriptVariableEnumOption> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<ScriptVariableEnumOption> value)
	{
		int count = value.Count;
		int num = 14;
		if (value is ScriptVariableEnumOption[] array)
		{
			foreach (ScriptVariableEnumOption scriptVariableEnumOption in array)
			{
				SerializationHelpers.EnsureNonNull(scriptVariableEnumOption);
				num += FlatSharp.Compiler.Generated.NBF15E9E76450B9068AEDC26E1E7D702F95BF8A5FBB9030539AE4F58B00FD3CB2.Helpers.GetMaxSize(scriptVariableEnumOption);
			}
		}
		else if (value is List<ScriptVariableEnumOption> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				ScriptVariableEnumOption scriptVariableEnumOption2 = list[j];
				SerializationHelpers.EnsureNonNull(scriptVariableEnumOption2);
				num += FlatSharp.Compiler.Generated.NBF15E9E76450B9068AEDC26E1E7D702F95BF8A5FBB9030539AE4F58B00FD3CB2.Helpers.GetMaxSize(scriptVariableEnumOption2);
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				ScriptVariableEnumOption scriptVariableEnumOption3 = value[k];
				SerializationHelpers.EnsureNonNull(scriptVariableEnumOption3);
				num += FlatSharp.Compiler.Generated.NBF15E9E76450B9068AEDC26E1E7D702F95BF8A5FBB9030539AE4F58B00FD3CB2.Helpers.GetMaxSize(scriptVariableEnumOption3);
			}
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<ScriptVariableEnumOption> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 4);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is ScriptVariableEnumOption[] array)
		{
			foreach (ScriptVariableEnumOption scriptVariableEnumOption in array)
			{
				SerializationHelpers.EnsureNonNull(scriptVariableEnumOption);
				FlatSharp.Compiler.Generated.NBF15E9E76450B9068AEDC26E1E7D702F95BF8A5FBB9030539AE4F58B00FD3CB2.Helpers.Serialize(spanWriter, span, scriptVariableEnumOption, num, context);
				num += 4;
			}
		}
		else if (value is List<ScriptVariableEnumOption> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				ScriptVariableEnumOption scriptVariableEnumOption2 = list[j];
				SerializationHelpers.EnsureNonNull(scriptVariableEnumOption2);
				FlatSharp.Compiler.Generated.NBF15E9E76450B9068AEDC26E1E7D702F95BF8A5FBB9030539AE4F58B00FD3CB2.Helpers.Serialize(spanWriter, span, scriptVariableEnumOption2, num, context);
				num += 4;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				ScriptVariableEnumOption scriptVariableEnumOption3 = value[k];
				SerializationHelpers.EnsureNonNull(scriptVariableEnumOption3);
				FlatSharp.Compiler.Generated.NBF15E9E76450B9068AEDC26E1E7D702F95BF8A5FBB9030539AE4F58B00FD3CB2.Helpers.Serialize(spanWriter, span, scriptVariableEnumOption3, num, context);
				num += 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<ScriptVariableEnumOption> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_566890ee45abac29a0aed242dbe53616_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<ScriptVariableEnumOption> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_566890ee45abac29a0aed242dbe53616_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<ScriptVariableEnumOption> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_566890ee45abac29a0aed242dbe53616_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<ScriptVariableEnumOption> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_566890ee45abac29a0aed242dbe53616_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
