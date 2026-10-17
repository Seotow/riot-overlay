using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Common;
using FlatSharp.Compiler.Generated.N2682D52B26D6A72F537C7ECD0AA1F7EC4561F81930870172422B141F9007D693;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.NC0C3F51A01FAD113C228014DB183CF84D970F82532900DE344FACCD8FFD99C01;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ ScriptVariableValue ], Count = {Count}")]
	internal sealed class GeneratedVector_37742e3649d5cf0b35e43615a670e33e_Lazy<TInputBuffer> : IList<ScriptVariableValue>, ICollection<ScriptVariableValue>, IEnumerable<ScriptVariableValue>, IEnumerable, IReadOnlyList<ScriptVariableValue>, IReadOnlyCollection<ScriptVariableValue>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public ScriptVariableValue this[int index]
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

		public GeneratedVector_37742e3649d5cf0b35e43615a670e33e_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N2682D52B26D6A72F537C7ECD0AA1F7EC4561F81930870172422B141F9007D693.Helpers.tableReader_ba045bda899340f5b2e8dafc0a531711_Lazy<TInputBuffer> SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N2682D52B26D6A72F537C7ECD0AA1F7EC4561F81930870172422B141F9007D693.Helpers.tableReader_ba045bda899340f5b2e8dafc0a531711_Lazy<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return FlatSharp.Compiler.Generated.N2682D52B26D6A72F537C7ECD0AA1F7EC4561F81930870172422B141F9007D693.Helpers.Parse_Lazy(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, ScriptVariableValue value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(ScriptVariableValue? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(ScriptVariableValue? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(ScriptVariableValue[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<ScriptVariableValue> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(ScriptVariableValue item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, ScriptVariableValue item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(ScriptVariableValue item)
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

	[DebuggerDisplay("Progressive [ ScriptVariableValue ], Count = {Count}")]
	internal sealed class GeneratedVector_37742e3649d5cf0b35e43615a670e33e_Progressive<TInputBuffer> : IList<ScriptVariableValue>, ICollection<ScriptVariableValue>, IEnumerable<ScriptVariableValue>, IEnumerable, IReadOnlyList<ScriptVariableValue>, IReadOnlyCollection<ScriptVariableValue>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly FlatSharp.Compiler.Generated.N2682D52B26D6A72F537C7ECD0AA1F7EC4561F81930870172422B141F9007D693.Helpers.tableReader_ba045bda899340f5b2e8dafc0a531711_Progressive<TInputBuffer>?[]?[] items;

		public ScriptVariableValue this[int index]
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

		public GeneratedVector_37742e3649d5cf0b35e43615a670e33e_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new FlatSharp.Compiler.Generated.N2682D52B26D6A72F537C7ECD0AA1F7EC4561F81930870172422B141F9007D693.Helpers.tableReader_ba045bda899340f5b2e8dafc0a531711_Progressive<TInputBuffer>[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N2682D52B26D6A72F537C7ECD0AA1F7EC4561F81930870172422B141F9007D693.Helpers.tableReader_ba045bda899340f5b2e8dafc0a531711_Progressive<TInputBuffer>?[] GetOrCreateRow(FlatSharp.Compiler.Generated.N2682D52B26D6A72F537C7ECD0AA1F7EC4561F81930870172422B141F9007D693.Helpers.tableReader_ba045bda899340f5b2e8dafc0a531711_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private FlatSharp.Compiler.Generated.N2682D52B26D6A72F537C7ECD0AA1F7EC4561F81930870172422B141F9007D693.Helpers.tableReader_ba045bda899340f5b2e8dafc0a531711_Progressive<TInputBuffer>?[] CreateRow(FlatSharp.Compiler.Generated.N2682D52B26D6A72F537C7ECD0AA1F7EC4561F81930870172422B141F9007D693.Helpers.tableReader_ba045bda899340f5b2e8dafc0a531711_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] = new FlatSharp.Compiler.Generated.N2682D52B26D6A72F537C7ECD0AA1F7EC4561F81930870172422B141F9007D693.Helpers.tableReader_ba045bda899340f5b2e8dafc0a531711_Progressive<TInputBuffer>[32];
		}

		private FlatSharp.Compiler.Generated.N2682D52B26D6A72F537C7ECD0AA1F7EC4561F81930870172422B141F9007D693.Helpers.tableReader_ba045bda899340f5b2e8dafc0a531711_Progressive<TInputBuffer> ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			FlatSharp.Compiler.Generated.N2682D52B26D6A72F537C7ECD0AA1F7EC4561F81930870172422B141F9007D693.Helpers.tableReader_ba045bda899340f5b2e8dafc0a531711_Progressive<TInputBuffer>[][] array = items;
			FlatSharp.Compiler.Generated.N2682D52B26D6A72F537C7ECD0AA1F7EC4561F81930870172422B141F9007D693.Helpers.tableReader_ba045bda899340f5b2e8dafc0a531711_Progressive<TInputBuffer>[] orCreateRow = GetOrCreateRow(array, rowIndex);
			FlatSharp.Compiler.Generated.N2682D52B26D6A72F537C7ECD0AA1F7EC4561F81930870172422B141F9007D693.Helpers.tableReader_ba045bda899340f5b2e8dafc0a531711_Progressive<TInputBuffer> tableReader_ba045bda899340f5b2e8dafc0a531711_Progressive = orCreateRow[colIndex];
			if (tableReader_ba045bda899340f5b2e8dafc0a531711_Progressive == null)
			{
				tableReader_ba045bda899340f5b2e8dafc0a531711_Progressive = (orCreateRow[colIndex] = UnsafeParseItem(index));
			}
			return tableReader_ba045bda899340f5b2e8dafc0a531711_Progressive;
		}

		private void ProgressiveSet(int index, ScriptVariableValue value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, ScriptVariableValue value)
		{
			VectorUtilities.CheckIndex(index, count);
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N2682D52B26D6A72F537C7ECD0AA1F7EC4561F81930870172422B141F9007D693.Helpers.tableReader_ba045bda899340f5b2e8dafc0a531711_Progressive<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N2682D52B26D6A72F537C7ECD0AA1F7EC4561F81930870172422B141F9007D693.Helpers.tableReader_ba045bda899340f5b2e8dafc0a531711_Progressive<TInputBuffer> UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.N2682D52B26D6A72F537C7ECD0AA1F7EC4561F81930870172422B141F9007D693.Helpers.Parse_Progressive(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, ScriptVariableValue value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(ScriptVariableValue? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(ScriptVariableValue? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(ScriptVariableValue[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<ScriptVariableValue> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(ScriptVariableValue item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, ScriptVariableValue item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(ScriptVariableValue item)
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

	[DebuggerDisplay("Greedy [ ScriptVariableValue ], Count = {Count}")]
	internal sealed class GeneratedVector_37742e3649d5cf0b35e43615a670e33e_Greedy<TInputBuffer> : IList<ScriptVariableValue>, ICollection<ScriptVariableValue>, IEnumerable<ScriptVariableValue>, IEnumerable, IReadOnlyList<ScriptVariableValue>, IReadOnlyCollection<ScriptVariableValue> where TInputBuffer : IInputBuffer
	{
		private readonly List<FlatSharp.Compiler.Generated.N2682D52B26D6A72F537C7ECD0AA1F7EC4561F81930870172422B141F9007D693.Helpers.tableReader_ba045bda899340f5b2e8dafc0a531711_Greedy<TInputBuffer>> list;

		public ScriptVariableValue this[int index]
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

		public GeneratedVector_37742e3649d5cf0b35e43615a670e33e_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<FlatSharp.Compiler.Generated.N2682D52B26D6A72F537C7ECD0AA1F7EC4561F81930870172422B141F9007D693.Helpers.tableReader_ba045bda899340f5b2e8dafc0a531711_Greedy<TInputBuffer>> list = (this.list = new List<FlatSharp.Compiler.Generated.N2682D52B26D6A72F537C7ECD0AA1F7EC4561F81930870172422B141F9007D693.Helpers.tableReader_ba045bda899340f5b2e8dafc0a531711_Greedy<TInputBuffer>>(num));
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.N2682D52B26D6A72F537C7ECD0AA1F7EC4561F81930870172422B141F9007D693.Helpers.tableReader_ba045bda899340f5b2e8dafc0a531711_Greedy<TInputBuffer> item = FlatSharp.Compiler.Generated.N2682D52B26D6A72F537C7ECD0AA1F7EC4561F81930870172422B141F9007D693.Helpers.Parse_Greedy(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		private FlatSharp.Compiler.Generated.N2682D52B26D6A72F537C7ECD0AA1F7EC4561F81930870172422B141F9007D693.Helpers.tableReader_ba045bda899340f5b2e8dafc0a531711_Greedy<TInputBuffer> GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, ScriptVariableValue value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(ScriptVariableValue? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(ScriptVariableValue? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(ScriptVariableValue[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<ScriptVariableValue> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(ScriptVariableValue item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, ScriptVariableValue item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(ScriptVariableValue item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ ScriptVariableValue ], Count = {Count}")]
	internal sealed class GeneratedVector_37742e3649d5cf0b35e43615a670e33e_GreedyMutable<TInputBuffer> : IList<ScriptVariableValue>, ICollection<ScriptVariableValue>, IEnumerable<ScriptVariableValue>, IEnumerable, IReadOnlyList<ScriptVariableValue>, IReadOnlyCollection<ScriptVariableValue> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<ScriptVariableValue> list;

		public ScriptVariableValue this[int index]
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

		public GeneratedVector_37742e3649d5cf0b35e43615a670e33e_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<ScriptVariableValue> list = (this.list = new List<ScriptVariableValue>());
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.N2682D52B26D6A72F537C7ECD0AA1F7EC4561F81930870172422B141F9007D693.Helpers.tableReader_ba045bda899340f5b2e8dafc0a531711_GreedyMutable<TInputBuffer> item = FlatSharp.Compiler.Generated.N2682D52B26D6A72F537C7ECD0AA1F7EC4561F81930870172422B141F9007D693.Helpers.Parse_GreedyMutable(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private ScriptVariableValue GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, ScriptVariableValue value)
		{
			list[index] = value;
		}

		public void Add(ScriptVariableValue item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, ScriptVariableValue item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(ScriptVariableValue item)
		{
			return list.Remove(item);
		}

		public bool Contains(ScriptVariableValue? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(ScriptVariableValue? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(ScriptVariableValue[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<ScriptVariableValue> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<ScriptVariableValue> value)
	{
		int count = value.Count;
		int num = 14;
		if (value is ScriptVariableValue[] array)
		{
			foreach (ScriptVariableValue scriptVariableValue in array)
			{
				SerializationHelpers.EnsureNonNull(scriptVariableValue);
				num += FlatSharp.Compiler.Generated.N2682D52B26D6A72F537C7ECD0AA1F7EC4561F81930870172422B141F9007D693.Helpers.GetMaxSize(scriptVariableValue);
			}
		}
		else if (value is List<ScriptVariableValue> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				ScriptVariableValue scriptVariableValue2 = list[j];
				SerializationHelpers.EnsureNonNull(scriptVariableValue2);
				num += FlatSharp.Compiler.Generated.N2682D52B26D6A72F537C7ECD0AA1F7EC4561F81930870172422B141F9007D693.Helpers.GetMaxSize(scriptVariableValue2);
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				ScriptVariableValue scriptVariableValue3 = value[k];
				SerializationHelpers.EnsureNonNull(scriptVariableValue3);
				num += FlatSharp.Compiler.Generated.N2682D52B26D6A72F537C7ECD0AA1F7EC4561F81930870172422B141F9007D693.Helpers.GetMaxSize(scriptVariableValue3);
			}
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<ScriptVariableValue> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 4);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is ScriptVariableValue[] array)
		{
			foreach (ScriptVariableValue scriptVariableValue in array)
			{
				SerializationHelpers.EnsureNonNull(scriptVariableValue);
				FlatSharp.Compiler.Generated.N2682D52B26D6A72F537C7ECD0AA1F7EC4561F81930870172422B141F9007D693.Helpers.Serialize(spanWriter, span, scriptVariableValue, num, context);
				num += 4;
			}
		}
		else if (value is List<ScriptVariableValue> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				ScriptVariableValue scriptVariableValue2 = list[j];
				SerializationHelpers.EnsureNonNull(scriptVariableValue2);
				FlatSharp.Compiler.Generated.N2682D52B26D6A72F537C7ECD0AA1F7EC4561F81930870172422B141F9007D693.Helpers.Serialize(spanWriter, span, scriptVariableValue2, num, context);
				num += 4;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				ScriptVariableValue scriptVariableValue3 = value[k];
				SerializationHelpers.EnsureNonNull(scriptVariableValue3);
				FlatSharp.Compiler.Generated.N2682D52B26D6A72F537C7ECD0AA1F7EC4561F81930870172422B141F9007D693.Helpers.Serialize(spanWriter, span, scriptVariableValue3, num, context);
				num += 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<ScriptVariableValue> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return new GeneratedVector_37742e3649d5cf0b35e43615a670e33e_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<ScriptVariableValue> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return new GeneratedVector_37742e3649d5cf0b35e43615a670e33e_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<ScriptVariableValue> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return new GeneratedVector_37742e3649d5cf0b35e43615a670e33e_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<ScriptVariableValue> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return new GeneratedVector_37742e3649d5cf0b35e43615a670e33e_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
