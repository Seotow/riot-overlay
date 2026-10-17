using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Snapshot;
using FlatSharp.Compiler.Generated.NA130CD73C58970ACDA4E3797BADE2FD35C8835C5C40F28E9BE7775D82C853A2D;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.ND6EBC62F8EB5330C79CC53DB52A9366CD8A448A9CC840438FFB649CFE426CE43;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ MiscObjects ], Count = {Count}")]
	internal sealed class GeneratedVector_61c7ae339b6555eb2bf74c83deff0ca2_Lazy<TInputBuffer> : IList<MiscObjects>, ICollection<MiscObjects>, IEnumerable<MiscObjects>, IEnumerable, IReadOnlyList<MiscObjects>, IReadOnlyCollection<MiscObjects>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public MiscObjects this[int index]
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

		public GeneratedVector_61c7ae339b6555eb2bf74c83deff0ca2_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NA130CD73C58970ACDA4E3797BADE2FD35C8835C5C40F28E9BE7775D82C853A2D.Helpers.tableReader_104af03b74624d7fa12093be4583a18d_Lazy<TInputBuffer> SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NA130CD73C58970ACDA4E3797BADE2FD35C8835C5C40F28E9BE7775D82C853A2D.Helpers.tableReader_104af03b74624d7fa12093be4583a18d_Lazy<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return FlatSharp.Compiler.Generated.NA130CD73C58970ACDA4E3797BADE2FD35C8835C5C40F28E9BE7775D82C853A2D.Helpers.Parse_Lazy(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, MiscObjects value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(MiscObjects? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(MiscObjects? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(MiscObjects[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<MiscObjects> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(MiscObjects item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, MiscObjects item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(MiscObjects item)
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

	[DebuggerDisplay("Progressive [ MiscObjects ], Count = {Count}")]
	internal sealed class GeneratedVector_61c7ae339b6555eb2bf74c83deff0ca2_Progressive<TInputBuffer> : IList<MiscObjects>, ICollection<MiscObjects>, IEnumerable<MiscObjects>, IEnumerable, IReadOnlyList<MiscObjects>, IReadOnlyCollection<MiscObjects>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly FlatSharp.Compiler.Generated.NA130CD73C58970ACDA4E3797BADE2FD35C8835C5C40F28E9BE7775D82C853A2D.Helpers.tableReader_104af03b74624d7fa12093be4583a18d_Progressive<TInputBuffer>?[]?[] items;

		public MiscObjects this[int index]
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

		public GeneratedVector_61c7ae339b6555eb2bf74c83deff0ca2_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new FlatSharp.Compiler.Generated.NA130CD73C58970ACDA4E3797BADE2FD35C8835C5C40F28E9BE7775D82C853A2D.Helpers.tableReader_104af03b74624d7fa12093be4583a18d_Progressive<TInputBuffer>[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NA130CD73C58970ACDA4E3797BADE2FD35C8835C5C40F28E9BE7775D82C853A2D.Helpers.tableReader_104af03b74624d7fa12093be4583a18d_Progressive<TInputBuffer>?[] GetOrCreateRow(FlatSharp.Compiler.Generated.NA130CD73C58970ACDA4E3797BADE2FD35C8835C5C40F28E9BE7775D82C853A2D.Helpers.tableReader_104af03b74624d7fa12093be4583a18d_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private FlatSharp.Compiler.Generated.NA130CD73C58970ACDA4E3797BADE2FD35C8835C5C40F28E9BE7775D82C853A2D.Helpers.tableReader_104af03b74624d7fa12093be4583a18d_Progressive<TInputBuffer>?[] CreateRow(FlatSharp.Compiler.Generated.NA130CD73C58970ACDA4E3797BADE2FD35C8835C5C40F28E9BE7775D82C853A2D.Helpers.tableReader_104af03b74624d7fa12093be4583a18d_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] = new FlatSharp.Compiler.Generated.NA130CD73C58970ACDA4E3797BADE2FD35C8835C5C40F28E9BE7775D82C853A2D.Helpers.tableReader_104af03b74624d7fa12093be4583a18d_Progressive<TInputBuffer>[32];
		}

		private FlatSharp.Compiler.Generated.NA130CD73C58970ACDA4E3797BADE2FD35C8835C5C40F28E9BE7775D82C853A2D.Helpers.tableReader_104af03b74624d7fa12093be4583a18d_Progressive<TInputBuffer> ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			FlatSharp.Compiler.Generated.NA130CD73C58970ACDA4E3797BADE2FD35C8835C5C40F28E9BE7775D82C853A2D.Helpers.tableReader_104af03b74624d7fa12093be4583a18d_Progressive<TInputBuffer>[][] array = items;
			FlatSharp.Compiler.Generated.NA130CD73C58970ACDA4E3797BADE2FD35C8835C5C40F28E9BE7775D82C853A2D.Helpers.tableReader_104af03b74624d7fa12093be4583a18d_Progressive<TInputBuffer>[] orCreateRow = GetOrCreateRow(array, rowIndex);
			FlatSharp.Compiler.Generated.NA130CD73C58970ACDA4E3797BADE2FD35C8835C5C40F28E9BE7775D82C853A2D.Helpers.tableReader_104af03b74624d7fa12093be4583a18d_Progressive<TInputBuffer> tableReader_104af03b74624d7fa12093be4583a18d_Progressive = orCreateRow[colIndex];
			if (tableReader_104af03b74624d7fa12093be4583a18d_Progressive == null)
			{
				tableReader_104af03b74624d7fa12093be4583a18d_Progressive = (orCreateRow[colIndex] = UnsafeParseItem(index));
			}
			return tableReader_104af03b74624d7fa12093be4583a18d_Progressive;
		}

		private void ProgressiveSet(int index, MiscObjects value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, MiscObjects value)
		{
			VectorUtilities.CheckIndex(index, count);
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NA130CD73C58970ACDA4E3797BADE2FD35C8835C5C40F28E9BE7775D82C853A2D.Helpers.tableReader_104af03b74624d7fa12093be4583a18d_Progressive<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NA130CD73C58970ACDA4E3797BADE2FD35C8835C5C40F28E9BE7775D82C853A2D.Helpers.tableReader_104af03b74624d7fa12093be4583a18d_Progressive<TInputBuffer> UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.NA130CD73C58970ACDA4E3797BADE2FD35C8835C5C40F28E9BE7775D82C853A2D.Helpers.Parse_Progressive(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, MiscObjects value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(MiscObjects? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(MiscObjects? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(MiscObjects[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<MiscObjects> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(MiscObjects item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, MiscObjects item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(MiscObjects item)
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

	[DebuggerDisplay("Greedy [ MiscObjects ], Count = {Count}")]
	internal sealed class GeneratedVector_61c7ae339b6555eb2bf74c83deff0ca2_Greedy<TInputBuffer> : IList<MiscObjects>, ICollection<MiscObjects>, IEnumerable<MiscObjects>, IEnumerable, IReadOnlyList<MiscObjects>, IReadOnlyCollection<MiscObjects> where TInputBuffer : IInputBuffer
	{
		private readonly List<FlatSharp.Compiler.Generated.NA130CD73C58970ACDA4E3797BADE2FD35C8835C5C40F28E9BE7775D82C853A2D.Helpers.tableReader_104af03b74624d7fa12093be4583a18d_Greedy<TInputBuffer>> list;

		public MiscObjects this[int index]
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

		public GeneratedVector_61c7ae339b6555eb2bf74c83deff0ca2_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<FlatSharp.Compiler.Generated.NA130CD73C58970ACDA4E3797BADE2FD35C8835C5C40F28E9BE7775D82C853A2D.Helpers.tableReader_104af03b74624d7fa12093be4583a18d_Greedy<TInputBuffer>> list = (this.list = new List<FlatSharp.Compiler.Generated.NA130CD73C58970ACDA4E3797BADE2FD35C8835C5C40F28E9BE7775D82C853A2D.Helpers.tableReader_104af03b74624d7fa12093be4583a18d_Greedy<TInputBuffer>>(num));
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.NA130CD73C58970ACDA4E3797BADE2FD35C8835C5C40F28E9BE7775D82C853A2D.Helpers.tableReader_104af03b74624d7fa12093be4583a18d_Greedy<TInputBuffer> item = FlatSharp.Compiler.Generated.NA130CD73C58970ACDA4E3797BADE2FD35C8835C5C40F28E9BE7775D82C853A2D.Helpers.Parse_Greedy(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		private FlatSharp.Compiler.Generated.NA130CD73C58970ACDA4E3797BADE2FD35C8835C5C40F28E9BE7775D82C853A2D.Helpers.tableReader_104af03b74624d7fa12093be4583a18d_Greedy<TInputBuffer> GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, MiscObjects value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(MiscObjects? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(MiscObjects? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(MiscObjects[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<MiscObjects> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(MiscObjects item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, MiscObjects item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(MiscObjects item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ MiscObjects ], Count = {Count}")]
	internal sealed class GeneratedVector_61c7ae339b6555eb2bf74c83deff0ca2_GreedyMutable<TInputBuffer> : IList<MiscObjects>, ICollection<MiscObjects>, IEnumerable<MiscObjects>, IEnumerable, IReadOnlyList<MiscObjects>, IReadOnlyCollection<MiscObjects> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<MiscObjects> list;

		public MiscObjects this[int index]
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

		public GeneratedVector_61c7ae339b6555eb2bf74c83deff0ca2_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<MiscObjects> list = (this.list = new List<MiscObjects>());
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.NA130CD73C58970ACDA4E3797BADE2FD35C8835C5C40F28E9BE7775D82C853A2D.Helpers.tableReader_104af03b74624d7fa12093be4583a18d_GreedyMutable<TInputBuffer> item = FlatSharp.Compiler.Generated.NA130CD73C58970ACDA4E3797BADE2FD35C8835C5C40F28E9BE7775D82C853A2D.Helpers.Parse_GreedyMutable(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private MiscObjects GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, MiscObjects value)
		{
			list[index] = value;
		}

		public void Add(MiscObjects item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, MiscObjects item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(MiscObjects item)
		{
			return list.Remove(item);
		}

		public bool Contains(MiscObjects? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(MiscObjects? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(MiscObjects[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<MiscObjects> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<MiscObjects> value)
	{
		int count = value.Count;
		int num = 14;
		if (value is MiscObjects[] array)
		{
			foreach (MiscObjects miscObjects in array)
			{
				SerializationHelpers.EnsureNonNull(miscObjects);
				num += FlatSharp.Compiler.Generated.NA130CD73C58970ACDA4E3797BADE2FD35C8835C5C40F28E9BE7775D82C853A2D.Helpers.GetMaxSize(miscObjects);
			}
		}
		else if (value is List<MiscObjects> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				MiscObjects miscObjects2 = list[j];
				SerializationHelpers.EnsureNonNull(miscObjects2);
				num += FlatSharp.Compiler.Generated.NA130CD73C58970ACDA4E3797BADE2FD35C8835C5C40F28E9BE7775D82C853A2D.Helpers.GetMaxSize(miscObjects2);
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				MiscObjects miscObjects3 = value[k];
				SerializationHelpers.EnsureNonNull(miscObjects3);
				num += FlatSharp.Compiler.Generated.NA130CD73C58970ACDA4E3797BADE2FD35C8835C5C40F28E9BE7775D82C853A2D.Helpers.GetMaxSize(miscObjects3);
			}
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<MiscObjects> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 4);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is MiscObjects[] array)
		{
			foreach (MiscObjects miscObjects in array)
			{
				SerializationHelpers.EnsureNonNull(miscObjects);
				FlatSharp.Compiler.Generated.NA130CD73C58970ACDA4E3797BADE2FD35C8835C5C40F28E9BE7775D82C853A2D.Helpers.Serialize(spanWriter, span, miscObjects, num, context);
				num += 4;
			}
		}
		else if (value is List<MiscObjects> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				MiscObjects miscObjects2 = list[j];
				SerializationHelpers.EnsureNonNull(miscObjects2);
				FlatSharp.Compiler.Generated.NA130CD73C58970ACDA4E3797BADE2FD35C8835C5C40F28E9BE7775D82C853A2D.Helpers.Serialize(spanWriter, span, miscObjects2, num, context);
				num += 4;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				MiscObjects miscObjects3 = value[k];
				SerializationHelpers.EnsureNonNull(miscObjects3);
				FlatSharp.Compiler.Generated.NA130CD73C58970ACDA4E3797BADE2FD35C8835C5C40F28E9BE7775D82C853A2D.Helpers.Serialize(spanWriter, span, miscObjects3, num, context);
				num += 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<MiscObjects> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_61c7ae339b6555eb2bf74c83deff0ca2_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<MiscObjects> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_61c7ae339b6555eb2bf74c83deff0ca2_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<MiscObjects> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_61c7ae339b6555eb2bf74c83deff0ca2_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<MiscObjects> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_61c7ae339b6555eb2bf74c83deff0ca2_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
