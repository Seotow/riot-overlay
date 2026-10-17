using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Snapshot;
using FlatSharp.Compiler.Generated.N8329725319FC700F22AB855F936F6D38C7D180E880A7E443AC4DC10FC5323765;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.NFA5E7B1DD862DDB3CF175AA108B527972C45FC0B933DAE74792276846A17768D;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ ObjectAddressEntry ], Count = {Count}")]
	internal sealed class GeneratedVector_e8d51cb9d3f88df47108137185f3db4f_Lazy<TInputBuffer> : IList<ObjectAddressEntry>, ICollection<ObjectAddressEntry>, IEnumerable<ObjectAddressEntry>, IEnumerable, IReadOnlyList<ObjectAddressEntry>, IReadOnlyCollection<ObjectAddressEntry>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public ObjectAddressEntry this[int index]
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

		public GeneratedVector_e8d51cb9d3f88df47108137185f3db4f_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N8329725319FC700F22AB855F936F6D38C7D180E880A7E443AC4DC10FC5323765.Helpers.tableReader_79c250ad8bfa4639b544d13ee7ea44c1_Lazy<TInputBuffer> SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N8329725319FC700F22AB855F936F6D38C7D180E880A7E443AC4DC10FC5323765.Helpers.tableReader_79c250ad8bfa4639b544d13ee7ea44c1_Lazy<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return FlatSharp.Compiler.Generated.N8329725319FC700F22AB855F936F6D38C7D180E880A7E443AC4DC10FC5323765.Helpers.Parse_Lazy(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, ObjectAddressEntry value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(ObjectAddressEntry? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(ObjectAddressEntry? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(ObjectAddressEntry[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<ObjectAddressEntry> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(ObjectAddressEntry item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, ObjectAddressEntry item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(ObjectAddressEntry item)
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

	[DebuggerDisplay("Progressive [ ObjectAddressEntry ], Count = {Count}")]
	internal sealed class GeneratedVector_e8d51cb9d3f88df47108137185f3db4f_Progressive<TInputBuffer> : IList<ObjectAddressEntry>, ICollection<ObjectAddressEntry>, IEnumerable<ObjectAddressEntry>, IEnumerable, IReadOnlyList<ObjectAddressEntry>, IReadOnlyCollection<ObjectAddressEntry>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly FlatSharp.Compiler.Generated.N8329725319FC700F22AB855F936F6D38C7D180E880A7E443AC4DC10FC5323765.Helpers.tableReader_79c250ad8bfa4639b544d13ee7ea44c1_Progressive<TInputBuffer>?[]?[] items;

		public ObjectAddressEntry this[int index]
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

		public GeneratedVector_e8d51cb9d3f88df47108137185f3db4f_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new FlatSharp.Compiler.Generated.N8329725319FC700F22AB855F936F6D38C7D180E880A7E443AC4DC10FC5323765.Helpers.tableReader_79c250ad8bfa4639b544d13ee7ea44c1_Progressive<TInputBuffer>[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N8329725319FC700F22AB855F936F6D38C7D180E880A7E443AC4DC10FC5323765.Helpers.tableReader_79c250ad8bfa4639b544d13ee7ea44c1_Progressive<TInputBuffer>?[] GetOrCreateRow(FlatSharp.Compiler.Generated.N8329725319FC700F22AB855F936F6D38C7D180E880A7E443AC4DC10FC5323765.Helpers.tableReader_79c250ad8bfa4639b544d13ee7ea44c1_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private FlatSharp.Compiler.Generated.N8329725319FC700F22AB855F936F6D38C7D180E880A7E443AC4DC10FC5323765.Helpers.tableReader_79c250ad8bfa4639b544d13ee7ea44c1_Progressive<TInputBuffer>?[] CreateRow(FlatSharp.Compiler.Generated.N8329725319FC700F22AB855F936F6D38C7D180E880A7E443AC4DC10FC5323765.Helpers.tableReader_79c250ad8bfa4639b544d13ee7ea44c1_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] = new FlatSharp.Compiler.Generated.N8329725319FC700F22AB855F936F6D38C7D180E880A7E443AC4DC10FC5323765.Helpers.tableReader_79c250ad8bfa4639b544d13ee7ea44c1_Progressive<TInputBuffer>[32];
		}

		private FlatSharp.Compiler.Generated.N8329725319FC700F22AB855F936F6D38C7D180E880A7E443AC4DC10FC5323765.Helpers.tableReader_79c250ad8bfa4639b544d13ee7ea44c1_Progressive<TInputBuffer> ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			FlatSharp.Compiler.Generated.N8329725319FC700F22AB855F936F6D38C7D180E880A7E443AC4DC10FC5323765.Helpers.tableReader_79c250ad8bfa4639b544d13ee7ea44c1_Progressive<TInputBuffer>[][] array = items;
			FlatSharp.Compiler.Generated.N8329725319FC700F22AB855F936F6D38C7D180E880A7E443AC4DC10FC5323765.Helpers.tableReader_79c250ad8bfa4639b544d13ee7ea44c1_Progressive<TInputBuffer>[] orCreateRow = GetOrCreateRow(array, rowIndex);
			FlatSharp.Compiler.Generated.N8329725319FC700F22AB855F936F6D38C7D180E880A7E443AC4DC10FC5323765.Helpers.tableReader_79c250ad8bfa4639b544d13ee7ea44c1_Progressive<TInputBuffer> tableReader_79c250ad8bfa4639b544d13ee7ea44c1_Progressive = orCreateRow[colIndex];
			if (tableReader_79c250ad8bfa4639b544d13ee7ea44c1_Progressive == null)
			{
				tableReader_79c250ad8bfa4639b544d13ee7ea44c1_Progressive = (orCreateRow[colIndex] = UnsafeParseItem(index));
			}
			return tableReader_79c250ad8bfa4639b544d13ee7ea44c1_Progressive;
		}

		private void ProgressiveSet(int index, ObjectAddressEntry value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, ObjectAddressEntry value)
		{
			VectorUtilities.CheckIndex(index, count);
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N8329725319FC700F22AB855F936F6D38C7D180E880A7E443AC4DC10FC5323765.Helpers.tableReader_79c250ad8bfa4639b544d13ee7ea44c1_Progressive<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N8329725319FC700F22AB855F936F6D38C7D180E880A7E443AC4DC10FC5323765.Helpers.tableReader_79c250ad8bfa4639b544d13ee7ea44c1_Progressive<TInputBuffer> UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.N8329725319FC700F22AB855F936F6D38C7D180E880A7E443AC4DC10FC5323765.Helpers.Parse_Progressive(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, ObjectAddressEntry value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(ObjectAddressEntry? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(ObjectAddressEntry? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(ObjectAddressEntry[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<ObjectAddressEntry> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(ObjectAddressEntry item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, ObjectAddressEntry item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(ObjectAddressEntry item)
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

	[DebuggerDisplay("Greedy [ ObjectAddressEntry ], Count = {Count}")]
	internal sealed class GeneratedVector_e8d51cb9d3f88df47108137185f3db4f_Greedy<TInputBuffer> : IList<ObjectAddressEntry>, ICollection<ObjectAddressEntry>, IEnumerable<ObjectAddressEntry>, IEnumerable, IReadOnlyList<ObjectAddressEntry>, IReadOnlyCollection<ObjectAddressEntry> where TInputBuffer : IInputBuffer
	{
		private readonly List<FlatSharp.Compiler.Generated.N8329725319FC700F22AB855F936F6D38C7D180E880A7E443AC4DC10FC5323765.Helpers.tableReader_79c250ad8bfa4639b544d13ee7ea44c1_Greedy<TInputBuffer>> list;

		public ObjectAddressEntry this[int index]
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

		public GeneratedVector_e8d51cb9d3f88df47108137185f3db4f_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<FlatSharp.Compiler.Generated.N8329725319FC700F22AB855F936F6D38C7D180E880A7E443AC4DC10FC5323765.Helpers.tableReader_79c250ad8bfa4639b544d13ee7ea44c1_Greedy<TInputBuffer>> list = (this.list = new List<FlatSharp.Compiler.Generated.N8329725319FC700F22AB855F936F6D38C7D180E880A7E443AC4DC10FC5323765.Helpers.tableReader_79c250ad8bfa4639b544d13ee7ea44c1_Greedy<TInputBuffer>>(num));
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.N8329725319FC700F22AB855F936F6D38C7D180E880A7E443AC4DC10FC5323765.Helpers.tableReader_79c250ad8bfa4639b544d13ee7ea44c1_Greedy<TInputBuffer> item = FlatSharp.Compiler.Generated.N8329725319FC700F22AB855F936F6D38C7D180E880A7E443AC4DC10FC5323765.Helpers.Parse_Greedy(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		private FlatSharp.Compiler.Generated.N8329725319FC700F22AB855F936F6D38C7D180E880A7E443AC4DC10FC5323765.Helpers.tableReader_79c250ad8bfa4639b544d13ee7ea44c1_Greedy<TInputBuffer> GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, ObjectAddressEntry value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(ObjectAddressEntry? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(ObjectAddressEntry? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(ObjectAddressEntry[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<ObjectAddressEntry> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(ObjectAddressEntry item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, ObjectAddressEntry item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(ObjectAddressEntry item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ ObjectAddressEntry ], Count = {Count}")]
	internal sealed class GeneratedVector_e8d51cb9d3f88df47108137185f3db4f_GreedyMutable<TInputBuffer> : IList<ObjectAddressEntry>, ICollection<ObjectAddressEntry>, IEnumerable<ObjectAddressEntry>, IEnumerable, IReadOnlyList<ObjectAddressEntry>, IReadOnlyCollection<ObjectAddressEntry> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<ObjectAddressEntry> list;

		public ObjectAddressEntry this[int index]
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

		public GeneratedVector_e8d51cb9d3f88df47108137185f3db4f_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<ObjectAddressEntry> list = (this.list = new List<ObjectAddressEntry>());
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.N8329725319FC700F22AB855F936F6D38C7D180E880A7E443AC4DC10FC5323765.Helpers.tableReader_79c250ad8bfa4639b544d13ee7ea44c1_GreedyMutable<TInputBuffer> item = FlatSharp.Compiler.Generated.N8329725319FC700F22AB855F936F6D38C7D180E880A7E443AC4DC10FC5323765.Helpers.Parse_GreedyMutable(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private ObjectAddressEntry GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, ObjectAddressEntry value)
		{
			list[index] = value;
		}

		public void Add(ObjectAddressEntry item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, ObjectAddressEntry item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(ObjectAddressEntry item)
		{
			return list.Remove(item);
		}

		public bool Contains(ObjectAddressEntry? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(ObjectAddressEntry? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(ObjectAddressEntry[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<ObjectAddressEntry> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<ObjectAddressEntry> value)
	{
		int count = value.Count;
		int num = 14;
		if (value is ObjectAddressEntry[] array)
		{
			foreach (ObjectAddressEntry objectAddressEntry in array)
			{
				SerializationHelpers.EnsureNonNull(objectAddressEntry);
				num += FlatSharp.Compiler.Generated.N8329725319FC700F22AB855F936F6D38C7D180E880A7E443AC4DC10FC5323765.Helpers.GetMaxSize(objectAddressEntry);
			}
		}
		else if (value is List<ObjectAddressEntry> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				ObjectAddressEntry objectAddressEntry2 = list[j];
				SerializationHelpers.EnsureNonNull(objectAddressEntry2);
				num += FlatSharp.Compiler.Generated.N8329725319FC700F22AB855F936F6D38C7D180E880A7E443AC4DC10FC5323765.Helpers.GetMaxSize(objectAddressEntry2);
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				ObjectAddressEntry objectAddressEntry3 = value[k];
				SerializationHelpers.EnsureNonNull(objectAddressEntry3);
				num += FlatSharp.Compiler.Generated.N8329725319FC700F22AB855F936F6D38C7D180E880A7E443AC4DC10FC5323765.Helpers.GetMaxSize(objectAddressEntry3);
			}
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<ObjectAddressEntry> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 4);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is ObjectAddressEntry[] array)
		{
			foreach (ObjectAddressEntry objectAddressEntry in array)
			{
				SerializationHelpers.EnsureNonNull(objectAddressEntry);
				FlatSharp.Compiler.Generated.N8329725319FC700F22AB855F936F6D38C7D180E880A7E443AC4DC10FC5323765.Helpers.Serialize(spanWriter, span, objectAddressEntry, num, context);
				num += 4;
			}
		}
		else if (value is List<ObjectAddressEntry> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				ObjectAddressEntry objectAddressEntry2 = list[j];
				SerializationHelpers.EnsureNonNull(objectAddressEntry2);
				FlatSharp.Compiler.Generated.N8329725319FC700F22AB855F936F6D38C7D180E880A7E443AC4DC10FC5323765.Helpers.Serialize(spanWriter, span, objectAddressEntry2, num, context);
				num += 4;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				ObjectAddressEntry objectAddressEntry3 = value[k];
				SerializationHelpers.EnsureNonNull(objectAddressEntry3);
				FlatSharp.Compiler.Generated.N8329725319FC700F22AB855F936F6D38C7D180E880A7E443AC4DC10FC5323765.Helpers.Serialize(spanWriter, span, objectAddressEntry3, num, context);
				num += 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<ObjectAddressEntry> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_e8d51cb9d3f88df47108137185f3db4f_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<ObjectAddressEntry> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_e8d51cb9d3f88df47108137185f3db4f_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<ObjectAddressEntry> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_e8d51cb9d3f88df47108137185f3db4f_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<ObjectAddressEntry> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_e8d51cb9d3f88df47108137185f3db4f_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
