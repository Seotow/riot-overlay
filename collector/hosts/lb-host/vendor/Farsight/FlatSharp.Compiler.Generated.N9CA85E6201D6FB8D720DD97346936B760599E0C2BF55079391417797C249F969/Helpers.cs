using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Entity;
using FlatSharp.Compiler.Generated.NA12C419ED762ACDF4570EA836CA6AF4971A23F6824D03A0437AF35E049FE7F6E;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N9CA85E6201D6FB8D720DD97346936B760599E0C2BF55079391417797C249F969;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ ScriptVariableOverride ], Count = {Count}")]
	internal sealed class GeneratedVector_85866b0dc88e98c0801c15d20380d6dc_Lazy<TInputBuffer> : IList<ScriptVariableOverride>, ICollection<ScriptVariableOverride>, IEnumerable<ScriptVariableOverride>, IEnumerable, IReadOnlyList<ScriptVariableOverride>, IReadOnlyCollection<ScriptVariableOverride>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public ScriptVariableOverride this[int index]
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

		public GeneratedVector_85866b0dc88e98c0801c15d20380d6dc_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NA12C419ED762ACDF4570EA836CA6AF4971A23F6824D03A0437AF35E049FE7F6E.Helpers.tableReader_855a0e3ca5d14f68a2dbd406faaa1f71_Lazy<TInputBuffer> SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NA12C419ED762ACDF4570EA836CA6AF4971A23F6824D03A0437AF35E049FE7F6E.Helpers.tableReader_855a0e3ca5d14f68a2dbd406faaa1f71_Lazy<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return FlatSharp.Compiler.Generated.NA12C419ED762ACDF4570EA836CA6AF4971A23F6824D03A0437AF35E049FE7F6E.Helpers.Parse_Lazy(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, ScriptVariableOverride value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(ScriptVariableOverride? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(ScriptVariableOverride? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(ScriptVariableOverride[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<ScriptVariableOverride> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(ScriptVariableOverride item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, ScriptVariableOverride item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(ScriptVariableOverride item)
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

	[DebuggerDisplay("Progressive [ ScriptVariableOverride ], Count = {Count}")]
	internal sealed class GeneratedVector_85866b0dc88e98c0801c15d20380d6dc_Progressive<TInputBuffer> : IList<ScriptVariableOverride>, ICollection<ScriptVariableOverride>, IEnumerable<ScriptVariableOverride>, IEnumerable, IReadOnlyList<ScriptVariableOverride>, IReadOnlyCollection<ScriptVariableOverride>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly FlatSharp.Compiler.Generated.NA12C419ED762ACDF4570EA836CA6AF4971A23F6824D03A0437AF35E049FE7F6E.Helpers.tableReader_855a0e3ca5d14f68a2dbd406faaa1f71_Progressive<TInputBuffer>?[]?[] items;

		public ScriptVariableOverride this[int index]
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

		public GeneratedVector_85866b0dc88e98c0801c15d20380d6dc_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new FlatSharp.Compiler.Generated.NA12C419ED762ACDF4570EA836CA6AF4971A23F6824D03A0437AF35E049FE7F6E.Helpers.tableReader_855a0e3ca5d14f68a2dbd406faaa1f71_Progressive<TInputBuffer>[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NA12C419ED762ACDF4570EA836CA6AF4971A23F6824D03A0437AF35E049FE7F6E.Helpers.tableReader_855a0e3ca5d14f68a2dbd406faaa1f71_Progressive<TInputBuffer>?[] GetOrCreateRow(FlatSharp.Compiler.Generated.NA12C419ED762ACDF4570EA836CA6AF4971A23F6824D03A0437AF35E049FE7F6E.Helpers.tableReader_855a0e3ca5d14f68a2dbd406faaa1f71_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private FlatSharp.Compiler.Generated.NA12C419ED762ACDF4570EA836CA6AF4971A23F6824D03A0437AF35E049FE7F6E.Helpers.tableReader_855a0e3ca5d14f68a2dbd406faaa1f71_Progressive<TInputBuffer>?[] CreateRow(FlatSharp.Compiler.Generated.NA12C419ED762ACDF4570EA836CA6AF4971A23F6824D03A0437AF35E049FE7F6E.Helpers.tableReader_855a0e3ca5d14f68a2dbd406faaa1f71_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] = new FlatSharp.Compiler.Generated.NA12C419ED762ACDF4570EA836CA6AF4971A23F6824D03A0437AF35E049FE7F6E.Helpers.tableReader_855a0e3ca5d14f68a2dbd406faaa1f71_Progressive<TInputBuffer>[32];
		}

		private FlatSharp.Compiler.Generated.NA12C419ED762ACDF4570EA836CA6AF4971A23F6824D03A0437AF35E049FE7F6E.Helpers.tableReader_855a0e3ca5d14f68a2dbd406faaa1f71_Progressive<TInputBuffer> ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			FlatSharp.Compiler.Generated.NA12C419ED762ACDF4570EA836CA6AF4971A23F6824D03A0437AF35E049FE7F6E.Helpers.tableReader_855a0e3ca5d14f68a2dbd406faaa1f71_Progressive<TInputBuffer>[][] array = items;
			FlatSharp.Compiler.Generated.NA12C419ED762ACDF4570EA836CA6AF4971A23F6824D03A0437AF35E049FE7F6E.Helpers.tableReader_855a0e3ca5d14f68a2dbd406faaa1f71_Progressive<TInputBuffer>[] orCreateRow = GetOrCreateRow(array, rowIndex);
			FlatSharp.Compiler.Generated.NA12C419ED762ACDF4570EA836CA6AF4971A23F6824D03A0437AF35E049FE7F6E.Helpers.tableReader_855a0e3ca5d14f68a2dbd406faaa1f71_Progressive<TInputBuffer> tableReader_855a0e3ca5d14f68a2dbd406faaa1f71_Progressive = orCreateRow[colIndex];
			if (tableReader_855a0e3ca5d14f68a2dbd406faaa1f71_Progressive == null)
			{
				tableReader_855a0e3ca5d14f68a2dbd406faaa1f71_Progressive = (orCreateRow[colIndex] = UnsafeParseItem(index));
			}
			return tableReader_855a0e3ca5d14f68a2dbd406faaa1f71_Progressive;
		}

		private void ProgressiveSet(int index, ScriptVariableOverride value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, ScriptVariableOverride value)
		{
			VectorUtilities.CheckIndex(index, count);
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NA12C419ED762ACDF4570EA836CA6AF4971A23F6824D03A0437AF35E049FE7F6E.Helpers.tableReader_855a0e3ca5d14f68a2dbd406faaa1f71_Progressive<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NA12C419ED762ACDF4570EA836CA6AF4971A23F6824D03A0437AF35E049FE7F6E.Helpers.tableReader_855a0e3ca5d14f68a2dbd406faaa1f71_Progressive<TInputBuffer> UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.NA12C419ED762ACDF4570EA836CA6AF4971A23F6824D03A0437AF35E049FE7F6E.Helpers.Parse_Progressive(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, ScriptVariableOverride value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(ScriptVariableOverride? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(ScriptVariableOverride? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(ScriptVariableOverride[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<ScriptVariableOverride> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(ScriptVariableOverride item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, ScriptVariableOverride item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(ScriptVariableOverride item)
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

	[DebuggerDisplay("Greedy [ ScriptVariableOverride ], Count = {Count}")]
	internal sealed class GeneratedVector_85866b0dc88e98c0801c15d20380d6dc_Greedy<TInputBuffer> : IList<ScriptVariableOverride>, ICollection<ScriptVariableOverride>, IEnumerable<ScriptVariableOverride>, IEnumerable, IReadOnlyList<ScriptVariableOverride>, IReadOnlyCollection<ScriptVariableOverride> where TInputBuffer : IInputBuffer
	{
		private readonly List<FlatSharp.Compiler.Generated.NA12C419ED762ACDF4570EA836CA6AF4971A23F6824D03A0437AF35E049FE7F6E.Helpers.tableReader_855a0e3ca5d14f68a2dbd406faaa1f71_Greedy<TInputBuffer>> list;

		public ScriptVariableOverride this[int index]
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

		public GeneratedVector_85866b0dc88e98c0801c15d20380d6dc_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<FlatSharp.Compiler.Generated.NA12C419ED762ACDF4570EA836CA6AF4971A23F6824D03A0437AF35E049FE7F6E.Helpers.tableReader_855a0e3ca5d14f68a2dbd406faaa1f71_Greedy<TInputBuffer>> list = (this.list = new List<FlatSharp.Compiler.Generated.NA12C419ED762ACDF4570EA836CA6AF4971A23F6824D03A0437AF35E049FE7F6E.Helpers.tableReader_855a0e3ca5d14f68a2dbd406faaa1f71_Greedy<TInputBuffer>>(num));
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.NA12C419ED762ACDF4570EA836CA6AF4971A23F6824D03A0437AF35E049FE7F6E.Helpers.tableReader_855a0e3ca5d14f68a2dbd406faaa1f71_Greedy<TInputBuffer> item = FlatSharp.Compiler.Generated.NA12C419ED762ACDF4570EA836CA6AF4971A23F6824D03A0437AF35E049FE7F6E.Helpers.Parse_Greedy(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		private FlatSharp.Compiler.Generated.NA12C419ED762ACDF4570EA836CA6AF4971A23F6824D03A0437AF35E049FE7F6E.Helpers.tableReader_855a0e3ca5d14f68a2dbd406faaa1f71_Greedy<TInputBuffer> GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, ScriptVariableOverride value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(ScriptVariableOverride? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(ScriptVariableOverride? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(ScriptVariableOverride[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<ScriptVariableOverride> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(ScriptVariableOverride item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, ScriptVariableOverride item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(ScriptVariableOverride item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ ScriptVariableOverride ], Count = {Count}")]
	internal sealed class GeneratedVector_85866b0dc88e98c0801c15d20380d6dc_GreedyMutable<TInputBuffer> : IList<ScriptVariableOverride>, ICollection<ScriptVariableOverride>, IEnumerable<ScriptVariableOverride>, IEnumerable, IReadOnlyList<ScriptVariableOverride>, IReadOnlyCollection<ScriptVariableOverride> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<ScriptVariableOverride> list;

		public ScriptVariableOverride this[int index]
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

		public GeneratedVector_85866b0dc88e98c0801c15d20380d6dc_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<ScriptVariableOverride> list = (this.list = new List<ScriptVariableOverride>());
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.NA12C419ED762ACDF4570EA836CA6AF4971A23F6824D03A0437AF35E049FE7F6E.Helpers.tableReader_855a0e3ca5d14f68a2dbd406faaa1f71_GreedyMutable<TInputBuffer> item = FlatSharp.Compiler.Generated.NA12C419ED762ACDF4570EA836CA6AF4971A23F6824D03A0437AF35E049FE7F6E.Helpers.Parse_GreedyMutable(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private ScriptVariableOverride GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, ScriptVariableOverride value)
		{
			list[index] = value;
		}

		public void Add(ScriptVariableOverride item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, ScriptVariableOverride item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(ScriptVariableOverride item)
		{
			return list.Remove(item);
		}

		public bool Contains(ScriptVariableOverride? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(ScriptVariableOverride? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(ScriptVariableOverride[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<ScriptVariableOverride> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<ScriptVariableOverride> value)
	{
		int count = value.Count;
		int num = 14;
		if (value is ScriptVariableOverride[] array)
		{
			foreach (ScriptVariableOverride scriptVariableOverride in array)
			{
				SerializationHelpers.EnsureNonNull(scriptVariableOverride);
				num += FlatSharp.Compiler.Generated.NA12C419ED762ACDF4570EA836CA6AF4971A23F6824D03A0437AF35E049FE7F6E.Helpers.GetMaxSize(scriptVariableOverride);
			}
		}
		else if (value is List<ScriptVariableOverride> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				ScriptVariableOverride scriptVariableOverride2 = list[j];
				SerializationHelpers.EnsureNonNull(scriptVariableOverride2);
				num += FlatSharp.Compiler.Generated.NA12C419ED762ACDF4570EA836CA6AF4971A23F6824D03A0437AF35E049FE7F6E.Helpers.GetMaxSize(scriptVariableOverride2);
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				ScriptVariableOverride scriptVariableOverride3 = value[k];
				SerializationHelpers.EnsureNonNull(scriptVariableOverride3);
				num += FlatSharp.Compiler.Generated.NA12C419ED762ACDF4570EA836CA6AF4971A23F6824D03A0437AF35E049FE7F6E.Helpers.GetMaxSize(scriptVariableOverride3);
			}
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<ScriptVariableOverride> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 4);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is ScriptVariableOverride[] array)
		{
			foreach (ScriptVariableOverride scriptVariableOverride in array)
			{
				SerializationHelpers.EnsureNonNull(scriptVariableOverride);
				FlatSharp.Compiler.Generated.NA12C419ED762ACDF4570EA836CA6AF4971A23F6824D03A0437AF35E049FE7F6E.Helpers.Serialize(spanWriter, span, scriptVariableOverride, num, context);
				num += 4;
			}
		}
		else if (value is List<ScriptVariableOverride> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				ScriptVariableOverride scriptVariableOverride2 = list[j];
				SerializationHelpers.EnsureNonNull(scriptVariableOverride2);
				FlatSharp.Compiler.Generated.NA12C419ED762ACDF4570EA836CA6AF4971A23F6824D03A0437AF35E049FE7F6E.Helpers.Serialize(spanWriter, span, scriptVariableOverride2, num, context);
				num += 4;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				ScriptVariableOverride scriptVariableOverride3 = value[k];
				SerializationHelpers.EnsureNonNull(scriptVariableOverride3);
				FlatSharp.Compiler.Generated.NA12C419ED762ACDF4570EA836CA6AF4971A23F6824D03A0437AF35E049FE7F6E.Helpers.Serialize(spanWriter, span, scriptVariableOverride3, num, context);
				num += 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<ScriptVariableOverride> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return new GeneratedVector_85866b0dc88e98c0801c15d20380d6dc_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<ScriptVariableOverride> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return new GeneratedVector_85866b0dc88e98c0801c15d20380d6dc_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<ScriptVariableOverride> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return new GeneratedVector_85866b0dc88e98c0801c15d20380d6dc_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<ScriptVariableOverride> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return new GeneratedVector_85866b0dc88e98c0801c15d20380d6dc_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
