using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Snapshot;
using FlatSharp.Compiler.Generated.N60C9727CEEAD333B5147E9E6E02D1B40EAECB57FF0CEA6B41BAC89941D0592C6;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.NEC7666CDC6B75176CD8696A077D792B20913EB644CDFA68FD3893F2F8C4E6539;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ Buff ], Count = {Count}")]
	internal sealed class GeneratedVector_7c0905b45c112cad5f5cd0253767a000_Lazy<TInputBuffer> : IList<Buff>, ICollection<Buff>, IEnumerable<Buff>, IEnumerable, IReadOnlyList<Buff>, IReadOnlyCollection<Buff>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public Buff this[int index]
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

		public GeneratedVector_7c0905b45c112cad5f5cd0253767a000_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N60C9727CEEAD333B5147E9E6E02D1B40EAECB57FF0CEA6B41BAC89941D0592C6.Helpers.tableReader_823aabdc9942420c8af07e3af8bb11a2_Lazy<TInputBuffer> SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N60C9727CEEAD333B5147E9E6E02D1B40EAECB57FF0CEA6B41BAC89941D0592C6.Helpers.tableReader_823aabdc9942420c8af07e3af8bb11a2_Lazy<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return FlatSharp.Compiler.Generated.N60C9727CEEAD333B5147E9E6E02D1B40EAECB57FF0CEA6B41BAC89941D0592C6.Helpers.Parse_Lazy(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, Buff value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(Buff? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(Buff? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(Buff[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<Buff> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(Buff item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, Buff item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(Buff item)
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

	[DebuggerDisplay("Progressive [ Buff ], Count = {Count}")]
	internal sealed class GeneratedVector_7c0905b45c112cad5f5cd0253767a000_Progressive<TInputBuffer> : IList<Buff>, ICollection<Buff>, IEnumerable<Buff>, IEnumerable, IReadOnlyList<Buff>, IReadOnlyCollection<Buff>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly FlatSharp.Compiler.Generated.N60C9727CEEAD333B5147E9E6E02D1B40EAECB57FF0CEA6B41BAC89941D0592C6.Helpers.tableReader_823aabdc9942420c8af07e3af8bb11a2_Progressive<TInputBuffer>?[]?[] items;

		public Buff this[int index]
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

		public GeneratedVector_7c0905b45c112cad5f5cd0253767a000_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new FlatSharp.Compiler.Generated.N60C9727CEEAD333B5147E9E6E02D1B40EAECB57FF0CEA6B41BAC89941D0592C6.Helpers.tableReader_823aabdc9942420c8af07e3af8bb11a2_Progressive<TInputBuffer>[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N60C9727CEEAD333B5147E9E6E02D1B40EAECB57FF0CEA6B41BAC89941D0592C6.Helpers.tableReader_823aabdc9942420c8af07e3af8bb11a2_Progressive<TInputBuffer>?[] GetOrCreateRow(FlatSharp.Compiler.Generated.N60C9727CEEAD333B5147E9E6E02D1B40EAECB57FF0CEA6B41BAC89941D0592C6.Helpers.tableReader_823aabdc9942420c8af07e3af8bb11a2_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private FlatSharp.Compiler.Generated.N60C9727CEEAD333B5147E9E6E02D1B40EAECB57FF0CEA6B41BAC89941D0592C6.Helpers.tableReader_823aabdc9942420c8af07e3af8bb11a2_Progressive<TInputBuffer>?[] CreateRow(FlatSharp.Compiler.Generated.N60C9727CEEAD333B5147E9E6E02D1B40EAECB57FF0CEA6B41BAC89941D0592C6.Helpers.tableReader_823aabdc9942420c8af07e3af8bb11a2_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] = new FlatSharp.Compiler.Generated.N60C9727CEEAD333B5147E9E6E02D1B40EAECB57FF0CEA6B41BAC89941D0592C6.Helpers.tableReader_823aabdc9942420c8af07e3af8bb11a2_Progressive<TInputBuffer>[32];
		}

		private FlatSharp.Compiler.Generated.N60C9727CEEAD333B5147E9E6E02D1B40EAECB57FF0CEA6B41BAC89941D0592C6.Helpers.tableReader_823aabdc9942420c8af07e3af8bb11a2_Progressive<TInputBuffer> ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			FlatSharp.Compiler.Generated.N60C9727CEEAD333B5147E9E6E02D1B40EAECB57FF0CEA6B41BAC89941D0592C6.Helpers.tableReader_823aabdc9942420c8af07e3af8bb11a2_Progressive<TInputBuffer>[][] array = items;
			FlatSharp.Compiler.Generated.N60C9727CEEAD333B5147E9E6E02D1B40EAECB57FF0CEA6B41BAC89941D0592C6.Helpers.tableReader_823aabdc9942420c8af07e3af8bb11a2_Progressive<TInputBuffer>[] orCreateRow = GetOrCreateRow(array, rowIndex);
			FlatSharp.Compiler.Generated.N60C9727CEEAD333B5147E9E6E02D1B40EAECB57FF0CEA6B41BAC89941D0592C6.Helpers.tableReader_823aabdc9942420c8af07e3af8bb11a2_Progressive<TInputBuffer> tableReader_823aabdc9942420c8af07e3af8bb11a2_Progressive = orCreateRow[colIndex];
			if (tableReader_823aabdc9942420c8af07e3af8bb11a2_Progressive == null)
			{
				tableReader_823aabdc9942420c8af07e3af8bb11a2_Progressive = (orCreateRow[colIndex] = UnsafeParseItem(index));
			}
			return tableReader_823aabdc9942420c8af07e3af8bb11a2_Progressive;
		}

		private void ProgressiveSet(int index, Buff value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, Buff value)
		{
			VectorUtilities.CheckIndex(index, count);
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N60C9727CEEAD333B5147E9E6E02D1B40EAECB57FF0CEA6B41BAC89941D0592C6.Helpers.tableReader_823aabdc9942420c8af07e3af8bb11a2_Progressive<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N60C9727CEEAD333B5147E9E6E02D1B40EAECB57FF0CEA6B41BAC89941D0592C6.Helpers.tableReader_823aabdc9942420c8af07e3af8bb11a2_Progressive<TInputBuffer> UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.N60C9727CEEAD333B5147E9E6E02D1B40EAECB57FF0CEA6B41BAC89941D0592C6.Helpers.Parse_Progressive(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, Buff value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(Buff? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(Buff? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(Buff[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<Buff> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(Buff item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, Buff item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(Buff item)
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

	[DebuggerDisplay("Greedy [ Buff ], Count = {Count}")]
	internal sealed class GeneratedVector_7c0905b45c112cad5f5cd0253767a000_Greedy<TInputBuffer> : IList<Buff>, ICollection<Buff>, IEnumerable<Buff>, IEnumerable, IReadOnlyList<Buff>, IReadOnlyCollection<Buff> where TInputBuffer : IInputBuffer
	{
		private readonly List<FlatSharp.Compiler.Generated.N60C9727CEEAD333B5147E9E6E02D1B40EAECB57FF0CEA6B41BAC89941D0592C6.Helpers.tableReader_823aabdc9942420c8af07e3af8bb11a2_Greedy<TInputBuffer>> list;

		public Buff this[int index]
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

		public GeneratedVector_7c0905b45c112cad5f5cd0253767a000_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<FlatSharp.Compiler.Generated.N60C9727CEEAD333B5147E9E6E02D1B40EAECB57FF0CEA6B41BAC89941D0592C6.Helpers.tableReader_823aabdc9942420c8af07e3af8bb11a2_Greedy<TInputBuffer>> list = (this.list = new List<FlatSharp.Compiler.Generated.N60C9727CEEAD333B5147E9E6E02D1B40EAECB57FF0CEA6B41BAC89941D0592C6.Helpers.tableReader_823aabdc9942420c8af07e3af8bb11a2_Greedy<TInputBuffer>>(num));
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.N60C9727CEEAD333B5147E9E6E02D1B40EAECB57FF0CEA6B41BAC89941D0592C6.Helpers.tableReader_823aabdc9942420c8af07e3af8bb11a2_Greedy<TInputBuffer> item = FlatSharp.Compiler.Generated.N60C9727CEEAD333B5147E9E6E02D1B40EAECB57FF0CEA6B41BAC89941D0592C6.Helpers.Parse_Greedy(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		private FlatSharp.Compiler.Generated.N60C9727CEEAD333B5147E9E6E02D1B40EAECB57FF0CEA6B41BAC89941D0592C6.Helpers.tableReader_823aabdc9942420c8af07e3af8bb11a2_Greedy<TInputBuffer> GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, Buff value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(Buff? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(Buff? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(Buff[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<Buff> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(Buff item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, Buff item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(Buff item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ Buff ], Count = {Count}")]
	internal sealed class GeneratedVector_7c0905b45c112cad5f5cd0253767a000_GreedyMutable<TInputBuffer> : IList<Buff>, ICollection<Buff>, IEnumerable<Buff>, IEnumerable, IReadOnlyList<Buff>, IReadOnlyCollection<Buff> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<Buff> list;

		public Buff this[int index]
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

		public GeneratedVector_7c0905b45c112cad5f5cd0253767a000_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<Buff> list = (this.list = new List<Buff>());
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.N60C9727CEEAD333B5147E9E6E02D1B40EAECB57FF0CEA6B41BAC89941D0592C6.Helpers.tableReader_823aabdc9942420c8af07e3af8bb11a2_GreedyMutable<TInputBuffer> item = FlatSharp.Compiler.Generated.N60C9727CEEAD333B5147E9E6E02D1B40EAECB57FF0CEA6B41BAC89941D0592C6.Helpers.Parse_GreedyMutable(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private Buff GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, Buff value)
		{
			list[index] = value;
		}

		public void Add(Buff item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, Buff item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(Buff item)
		{
			return list.Remove(item);
		}

		public bool Contains(Buff? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(Buff? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(Buff[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<Buff> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<Buff> value)
	{
		int count = value.Count;
		int num = 14;
		if (value is Buff[] array)
		{
			foreach (Buff buff in array)
			{
				SerializationHelpers.EnsureNonNull(buff);
				num += FlatSharp.Compiler.Generated.N60C9727CEEAD333B5147E9E6E02D1B40EAECB57FF0CEA6B41BAC89941D0592C6.Helpers.GetMaxSize(buff);
			}
		}
		else if (value is List<Buff> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				Buff buff2 = list[j];
				SerializationHelpers.EnsureNonNull(buff2);
				num += FlatSharp.Compiler.Generated.N60C9727CEEAD333B5147E9E6E02D1B40EAECB57FF0CEA6B41BAC89941D0592C6.Helpers.GetMaxSize(buff2);
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				Buff buff3 = value[k];
				SerializationHelpers.EnsureNonNull(buff3);
				num += FlatSharp.Compiler.Generated.N60C9727CEEAD333B5147E9E6E02D1B40EAECB57FF0CEA6B41BAC89941D0592C6.Helpers.GetMaxSize(buff3);
			}
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<Buff> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 4);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is Buff[] array)
		{
			foreach (Buff buff in array)
			{
				SerializationHelpers.EnsureNonNull(buff);
				FlatSharp.Compiler.Generated.N60C9727CEEAD333B5147E9E6E02D1B40EAECB57FF0CEA6B41BAC89941D0592C6.Helpers.Serialize(spanWriter, span, buff, num, context);
				num += 4;
			}
		}
		else if (value is List<Buff> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				Buff buff2 = list[j];
				SerializationHelpers.EnsureNonNull(buff2);
				FlatSharp.Compiler.Generated.N60C9727CEEAD333B5147E9E6E02D1B40EAECB57FF0CEA6B41BAC89941D0592C6.Helpers.Serialize(spanWriter, span, buff2, num, context);
				num += 4;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				Buff buff3 = value[k];
				SerializationHelpers.EnsureNonNull(buff3);
				FlatSharp.Compiler.Generated.N60C9727CEEAD333B5147E9E6E02D1B40EAECB57FF0CEA6B41BAC89941D0592C6.Helpers.Serialize(spanWriter, span, buff3, num, context);
				num += 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<Buff> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_7c0905b45c112cad5f5cd0253767a000_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<Buff> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_7c0905b45c112cad5f5cd0253767a000_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<Buff> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_7c0905b45c112cad5f5cd0253767a000_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<Buff> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_7c0905b45c112cad5f5cd0253767a000_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
