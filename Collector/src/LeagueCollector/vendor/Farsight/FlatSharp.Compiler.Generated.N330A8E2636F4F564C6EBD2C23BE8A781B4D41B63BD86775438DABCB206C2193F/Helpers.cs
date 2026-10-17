using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Scene;
using FlatSharp.Compiler.Generated.N33AD3E0EBDB043F69F04795F28B824B2DB644E3AAFB6BCEE50C48B218C2F5DC0;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N330A8E2636F4F564C6EBD2C23BE8A781B4D41B63BD86775438DABCB206C2193F;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ ScriptVariableSnapshot ], Count = {Count}")]
	internal sealed class GeneratedVector_1df7c7246bd9efa1cfa6aa1e67418a70_Lazy<TInputBuffer> : IList<ScriptVariableSnapshot>, ICollection<ScriptVariableSnapshot>, IEnumerable<ScriptVariableSnapshot>, IEnumerable, IReadOnlyList<ScriptVariableSnapshot>, IReadOnlyCollection<ScriptVariableSnapshot>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public ScriptVariableSnapshot this[int index]
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

		public GeneratedVector_1df7c7246bd9efa1cfa6aa1e67418a70_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N33AD3E0EBDB043F69F04795F28B824B2DB644E3AAFB6BCEE50C48B218C2F5DC0.Helpers.tableReader_8e0d565cd9274ac183ca384ddfa1e048_Lazy<TInputBuffer> SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N33AD3E0EBDB043F69F04795F28B824B2DB644E3AAFB6BCEE50C48B218C2F5DC0.Helpers.tableReader_8e0d565cd9274ac183ca384ddfa1e048_Lazy<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return FlatSharp.Compiler.Generated.N33AD3E0EBDB043F69F04795F28B824B2DB644E3AAFB6BCEE50C48B218C2F5DC0.Helpers.Parse_Lazy(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, ScriptVariableSnapshot value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(ScriptVariableSnapshot? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(ScriptVariableSnapshot? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(ScriptVariableSnapshot[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<ScriptVariableSnapshot> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(ScriptVariableSnapshot item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, ScriptVariableSnapshot item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(ScriptVariableSnapshot item)
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

	[DebuggerDisplay("Progressive [ ScriptVariableSnapshot ], Count = {Count}")]
	internal sealed class GeneratedVector_1df7c7246bd9efa1cfa6aa1e67418a70_Progressive<TInputBuffer> : IList<ScriptVariableSnapshot>, ICollection<ScriptVariableSnapshot>, IEnumerable<ScriptVariableSnapshot>, IEnumerable, IReadOnlyList<ScriptVariableSnapshot>, IReadOnlyCollection<ScriptVariableSnapshot>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly FlatSharp.Compiler.Generated.N33AD3E0EBDB043F69F04795F28B824B2DB644E3AAFB6BCEE50C48B218C2F5DC0.Helpers.tableReader_8e0d565cd9274ac183ca384ddfa1e048_Progressive<TInputBuffer>?[]?[] items;

		public ScriptVariableSnapshot this[int index]
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

		public GeneratedVector_1df7c7246bd9efa1cfa6aa1e67418a70_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new FlatSharp.Compiler.Generated.N33AD3E0EBDB043F69F04795F28B824B2DB644E3AAFB6BCEE50C48B218C2F5DC0.Helpers.tableReader_8e0d565cd9274ac183ca384ddfa1e048_Progressive<TInputBuffer>[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N33AD3E0EBDB043F69F04795F28B824B2DB644E3AAFB6BCEE50C48B218C2F5DC0.Helpers.tableReader_8e0d565cd9274ac183ca384ddfa1e048_Progressive<TInputBuffer>?[] GetOrCreateRow(FlatSharp.Compiler.Generated.N33AD3E0EBDB043F69F04795F28B824B2DB644E3AAFB6BCEE50C48B218C2F5DC0.Helpers.tableReader_8e0d565cd9274ac183ca384ddfa1e048_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private FlatSharp.Compiler.Generated.N33AD3E0EBDB043F69F04795F28B824B2DB644E3AAFB6BCEE50C48B218C2F5DC0.Helpers.tableReader_8e0d565cd9274ac183ca384ddfa1e048_Progressive<TInputBuffer>?[] CreateRow(FlatSharp.Compiler.Generated.N33AD3E0EBDB043F69F04795F28B824B2DB644E3AAFB6BCEE50C48B218C2F5DC0.Helpers.tableReader_8e0d565cd9274ac183ca384ddfa1e048_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] = new FlatSharp.Compiler.Generated.N33AD3E0EBDB043F69F04795F28B824B2DB644E3AAFB6BCEE50C48B218C2F5DC0.Helpers.tableReader_8e0d565cd9274ac183ca384ddfa1e048_Progressive<TInputBuffer>[32];
		}

		private FlatSharp.Compiler.Generated.N33AD3E0EBDB043F69F04795F28B824B2DB644E3AAFB6BCEE50C48B218C2F5DC0.Helpers.tableReader_8e0d565cd9274ac183ca384ddfa1e048_Progressive<TInputBuffer> ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			FlatSharp.Compiler.Generated.N33AD3E0EBDB043F69F04795F28B824B2DB644E3AAFB6BCEE50C48B218C2F5DC0.Helpers.tableReader_8e0d565cd9274ac183ca384ddfa1e048_Progressive<TInputBuffer>[][] array = items;
			FlatSharp.Compiler.Generated.N33AD3E0EBDB043F69F04795F28B824B2DB644E3AAFB6BCEE50C48B218C2F5DC0.Helpers.tableReader_8e0d565cd9274ac183ca384ddfa1e048_Progressive<TInputBuffer>[] orCreateRow = GetOrCreateRow(array, rowIndex);
			FlatSharp.Compiler.Generated.N33AD3E0EBDB043F69F04795F28B824B2DB644E3AAFB6BCEE50C48B218C2F5DC0.Helpers.tableReader_8e0d565cd9274ac183ca384ddfa1e048_Progressive<TInputBuffer> tableReader_8e0d565cd9274ac183ca384ddfa1e048_Progressive = orCreateRow[colIndex];
			if (tableReader_8e0d565cd9274ac183ca384ddfa1e048_Progressive == null)
			{
				tableReader_8e0d565cd9274ac183ca384ddfa1e048_Progressive = (orCreateRow[colIndex] = UnsafeParseItem(index));
			}
			return tableReader_8e0d565cd9274ac183ca384ddfa1e048_Progressive;
		}

		private void ProgressiveSet(int index, ScriptVariableSnapshot value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, ScriptVariableSnapshot value)
		{
			VectorUtilities.CheckIndex(index, count);
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N33AD3E0EBDB043F69F04795F28B824B2DB644E3AAFB6BCEE50C48B218C2F5DC0.Helpers.tableReader_8e0d565cd9274ac183ca384ddfa1e048_Progressive<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N33AD3E0EBDB043F69F04795F28B824B2DB644E3AAFB6BCEE50C48B218C2F5DC0.Helpers.tableReader_8e0d565cd9274ac183ca384ddfa1e048_Progressive<TInputBuffer> UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.N33AD3E0EBDB043F69F04795F28B824B2DB644E3AAFB6BCEE50C48B218C2F5DC0.Helpers.Parse_Progressive(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, ScriptVariableSnapshot value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(ScriptVariableSnapshot? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(ScriptVariableSnapshot? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(ScriptVariableSnapshot[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<ScriptVariableSnapshot> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(ScriptVariableSnapshot item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, ScriptVariableSnapshot item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(ScriptVariableSnapshot item)
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

	[DebuggerDisplay("Greedy [ ScriptVariableSnapshot ], Count = {Count}")]
	internal sealed class GeneratedVector_1df7c7246bd9efa1cfa6aa1e67418a70_Greedy<TInputBuffer> : IList<ScriptVariableSnapshot>, ICollection<ScriptVariableSnapshot>, IEnumerable<ScriptVariableSnapshot>, IEnumerable, IReadOnlyList<ScriptVariableSnapshot>, IReadOnlyCollection<ScriptVariableSnapshot> where TInputBuffer : IInputBuffer
	{
		private readonly List<FlatSharp.Compiler.Generated.N33AD3E0EBDB043F69F04795F28B824B2DB644E3AAFB6BCEE50C48B218C2F5DC0.Helpers.tableReader_8e0d565cd9274ac183ca384ddfa1e048_Greedy<TInputBuffer>> list;

		public ScriptVariableSnapshot this[int index]
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

		public GeneratedVector_1df7c7246bd9efa1cfa6aa1e67418a70_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<FlatSharp.Compiler.Generated.N33AD3E0EBDB043F69F04795F28B824B2DB644E3AAFB6BCEE50C48B218C2F5DC0.Helpers.tableReader_8e0d565cd9274ac183ca384ddfa1e048_Greedy<TInputBuffer>> list = (this.list = new List<FlatSharp.Compiler.Generated.N33AD3E0EBDB043F69F04795F28B824B2DB644E3AAFB6BCEE50C48B218C2F5DC0.Helpers.tableReader_8e0d565cd9274ac183ca384ddfa1e048_Greedy<TInputBuffer>>(num));
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.N33AD3E0EBDB043F69F04795F28B824B2DB644E3AAFB6BCEE50C48B218C2F5DC0.Helpers.tableReader_8e0d565cd9274ac183ca384ddfa1e048_Greedy<TInputBuffer> item = FlatSharp.Compiler.Generated.N33AD3E0EBDB043F69F04795F28B824B2DB644E3AAFB6BCEE50C48B218C2F5DC0.Helpers.Parse_Greedy(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		private FlatSharp.Compiler.Generated.N33AD3E0EBDB043F69F04795F28B824B2DB644E3AAFB6BCEE50C48B218C2F5DC0.Helpers.tableReader_8e0d565cd9274ac183ca384ddfa1e048_Greedy<TInputBuffer> GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, ScriptVariableSnapshot value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(ScriptVariableSnapshot? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(ScriptVariableSnapshot? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(ScriptVariableSnapshot[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<ScriptVariableSnapshot> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(ScriptVariableSnapshot item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, ScriptVariableSnapshot item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(ScriptVariableSnapshot item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ ScriptVariableSnapshot ], Count = {Count}")]
	internal sealed class GeneratedVector_1df7c7246bd9efa1cfa6aa1e67418a70_GreedyMutable<TInputBuffer> : IList<ScriptVariableSnapshot>, ICollection<ScriptVariableSnapshot>, IEnumerable<ScriptVariableSnapshot>, IEnumerable, IReadOnlyList<ScriptVariableSnapshot>, IReadOnlyCollection<ScriptVariableSnapshot> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<ScriptVariableSnapshot> list;

		public ScriptVariableSnapshot this[int index]
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

		public GeneratedVector_1df7c7246bd9efa1cfa6aa1e67418a70_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<ScriptVariableSnapshot> list = (this.list = new List<ScriptVariableSnapshot>());
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.N33AD3E0EBDB043F69F04795F28B824B2DB644E3AAFB6BCEE50C48B218C2F5DC0.Helpers.tableReader_8e0d565cd9274ac183ca384ddfa1e048_GreedyMutable<TInputBuffer> item = FlatSharp.Compiler.Generated.N33AD3E0EBDB043F69F04795F28B824B2DB644E3AAFB6BCEE50C48B218C2F5DC0.Helpers.Parse_GreedyMutable(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private ScriptVariableSnapshot GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, ScriptVariableSnapshot value)
		{
			list[index] = value;
		}

		public void Add(ScriptVariableSnapshot item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, ScriptVariableSnapshot item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(ScriptVariableSnapshot item)
		{
			return list.Remove(item);
		}

		public bool Contains(ScriptVariableSnapshot? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(ScriptVariableSnapshot? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(ScriptVariableSnapshot[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<ScriptVariableSnapshot> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<ScriptVariableSnapshot> value)
	{
		int count = value.Count;
		int num = 14;
		if (value is ScriptVariableSnapshot[] array)
		{
			foreach (ScriptVariableSnapshot scriptVariableSnapshot in array)
			{
				SerializationHelpers.EnsureNonNull(scriptVariableSnapshot);
				num += FlatSharp.Compiler.Generated.N33AD3E0EBDB043F69F04795F28B824B2DB644E3AAFB6BCEE50C48B218C2F5DC0.Helpers.GetMaxSize(scriptVariableSnapshot);
			}
		}
		else if (value is List<ScriptVariableSnapshot> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				ScriptVariableSnapshot scriptVariableSnapshot2 = list[j];
				SerializationHelpers.EnsureNonNull(scriptVariableSnapshot2);
				num += FlatSharp.Compiler.Generated.N33AD3E0EBDB043F69F04795F28B824B2DB644E3AAFB6BCEE50C48B218C2F5DC0.Helpers.GetMaxSize(scriptVariableSnapshot2);
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				ScriptVariableSnapshot scriptVariableSnapshot3 = value[k];
				SerializationHelpers.EnsureNonNull(scriptVariableSnapshot3);
				num += FlatSharp.Compiler.Generated.N33AD3E0EBDB043F69F04795F28B824B2DB644E3AAFB6BCEE50C48B218C2F5DC0.Helpers.GetMaxSize(scriptVariableSnapshot3);
			}
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<ScriptVariableSnapshot> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 4);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is ScriptVariableSnapshot[] array)
		{
			foreach (ScriptVariableSnapshot scriptVariableSnapshot in array)
			{
				SerializationHelpers.EnsureNonNull(scriptVariableSnapshot);
				FlatSharp.Compiler.Generated.N33AD3E0EBDB043F69F04795F28B824B2DB644E3AAFB6BCEE50C48B218C2F5DC0.Helpers.Serialize(spanWriter, span, scriptVariableSnapshot, num, context);
				num += 4;
			}
		}
		else if (value is List<ScriptVariableSnapshot> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				ScriptVariableSnapshot scriptVariableSnapshot2 = list[j];
				SerializationHelpers.EnsureNonNull(scriptVariableSnapshot2);
				FlatSharp.Compiler.Generated.N33AD3E0EBDB043F69F04795F28B824B2DB644E3AAFB6BCEE50C48B218C2F5DC0.Helpers.Serialize(spanWriter, span, scriptVariableSnapshot2, num, context);
				num += 4;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				ScriptVariableSnapshot scriptVariableSnapshot3 = value[k];
				SerializationHelpers.EnsureNonNull(scriptVariableSnapshot3);
				FlatSharp.Compiler.Generated.N33AD3E0EBDB043F69F04795F28B824B2DB644E3AAFB6BCEE50C48B218C2F5DC0.Helpers.Serialize(spanWriter, span, scriptVariableSnapshot3, num, context);
				num += 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<ScriptVariableSnapshot> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return new GeneratedVector_1df7c7246bd9efa1cfa6aa1e67418a70_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<ScriptVariableSnapshot> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return new GeneratedVector_1df7c7246bd9efa1cfa6aa1e67418a70_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<ScriptVariableSnapshot> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return new GeneratedVector_1df7c7246bd9efa1cfa6aa1e67418a70_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<ScriptVariableSnapshot> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return new GeneratedVector_1df7c7246bd9efa1cfa6aa1e67418a70_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
