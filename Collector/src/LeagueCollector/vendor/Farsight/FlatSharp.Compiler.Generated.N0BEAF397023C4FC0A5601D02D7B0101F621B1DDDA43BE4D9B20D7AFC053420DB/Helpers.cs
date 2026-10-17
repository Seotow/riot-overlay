using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Scene;
using FlatSharp.Compiler.Generated.N6653D642A3BD1AB4F399EABB79121E79E2C33BFE9CFD67906A9C4D1D80BD7B56;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N0BEAF397023C4FC0A5601D02D7B0101F621B1DDDA43BE4D9B20D7AFC053420DB;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ ScriptVariable ], Count = {Count}")]
	internal sealed class GeneratedVector_1ae5fdff8f91108fefc2ada8a65cf2ee_Lazy<TInputBuffer> : IList<ScriptVariable>, ICollection<ScriptVariable>, IEnumerable<ScriptVariable>, IEnumerable, IReadOnlyList<ScriptVariable>, IReadOnlyCollection<ScriptVariable>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public ScriptVariable this[int index]
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

		public GeneratedVector_1ae5fdff8f91108fefc2ada8a65cf2ee_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N6653D642A3BD1AB4F399EABB79121E79E2C33BFE9CFD67906A9C4D1D80BD7B56.Helpers.tableReader_f74819ec8dbd4e85ad6f3bd78a88e849_Lazy<TInputBuffer> SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N6653D642A3BD1AB4F399EABB79121E79E2C33BFE9CFD67906A9C4D1D80BD7B56.Helpers.tableReader_f74819ec8dbd4e85ad6f3bd78a88e849_Lazy<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return FlatSharp.Compiler.Generated.N6653D642A3BD1AB4F399EABB79121E79E2C33BFE9CFD67906A9C4D1D80BD7B56.Helpers.Parse_Lazy(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, ScriptVariable value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(ScriptVariable? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(ScriptVariable? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(ScriptVariable[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<ScriptVariable> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(ScriptVariable item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, ScriptVariable item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(ScriptVariable item)
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

	[DebuggerDisplay("Progressive [ ScriptVariable ], Count = {Count}")]
	internal sealed class GeneratedVector_1ae5fdff8f91108fefc2ada8a65cf2ee_Progressive<TInputBuffer> : IList<ScriptVariable>, ICollection<ScriptVariable>, IEnumerable<ScriptVariable>, IEnumerable, IReadOnlyList<ScriptVariable>, IReadOnlyCollection<ScriptVariable>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly FlatSharp.Compiler.Generated.N6653D642A3BD1AB4F399EABB79121E79E2C33BFE9CFD67906A9C4D1D80BD7B56.Helpers.tableReader_f74819ec8dbd4e85ad6f3bd78a88e849_Progressive<TInputBuffer>?[]?[] items;

		public ScriptVariable this[int index]
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

		public GeneratedVector_1ae5fdff8f91108fefc2ada8a65cf2ee_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new FlatSharp.Compiler.Generated.N6653D642A3BD1AB4F399EABB79121E79E2C33BFE9CFD67906A9C4D1D80BD7B56.Helpers.tableReader_f74819ec8dbd4e85ad6f3bd78a88e849_Progressive<TInputBuffer>[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N6653D642A3BD1AB4F399EABB79121E79E2C33BFE9CFD67906A9C4D1D80BD7B56.Helpers.tableReader_f74819ec8dbd4e85ad6f3bd78a88e849_Progressive<TInputBuffer>?[] GetOrCreateRow(FlatSharp.Compiler.Generated.N6653D642A3BD1AB4F399EABB79121E79E2C33BFE9CFD67906A9C4D1D80BD7B56.Helpers.tableReader_f74819ec8dbd4e85ad6f3bd78a88e849_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private FlatSharp.Compiler.Generated.N6653D642A3BD1AB4F399EABB79121E79E2C33BFE9CFD67906A9C4D1D80BD7B56.Helpers.tableReader_f74819ec8dbd4e85ad6f3bd78a88e849_Progressive<TInputBuffer>?[] CreateRow(FlatSharp.Compiler.Generated.N6653D642A3BD1AB4F399EABB79121E79E2C33BFE9CFD67906A9C4D1D80BD7B56.Helpers.tableReader_f74819ec8dbd4e85ad6f3bd78a88e849_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] = new FlatSharp.Compiler.Generated.N6653D642A3BD1AB4F399EABB79121E79E2C33BFE9CFD67906A9C4D1D80BD7B56.Helpers.tableReader_f74819ec8dbd4e85ad6f3bd78a88e849_Progressive<TInputBuffer>[32];
		}

		private FlatSharp.Compiler.Generated.N6653D642A3BD1AB4F399EABB79121E79E2C33BFE9CFD67906A9C4D1D80BD7B56.Helpers.tableReader_f74819ec8dbd4e85ad6f3bd78a88e849_Progressive<TInputBuffer> ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			FlatSharp.Compiler.Generated.N6653D642A3BD1AB4F399EABB79121E79E2C33BFE9CFD67906A9C4D1D80BD7B56.Helpers.tableReader_f74819ec8dbd4e85ad6f3bd78a88e849_Progressive<TInputBuffer>[][] array = items;
			FlatSharp.Compiler.Generated.N6653D642A3BD1AB4F399EABB79121E79E2C33BFE9CFD67906A9C4D1D80BD7B56.Helpers.tableReader_f74819ec8dbd4e85ad6f3bd78a88e849_Progressive<TInputBuffer>[] orCreateRow = GetOrCreateRow(array, rowIndex);
			FlatSharp.Compiler.Generated.N6653D642A3BD1AB4F399EABB79121E79E2C33BFE9CFD67906A9C4D1D80BD7B56.Helpers.tableReader_f74819ec8dbd4e85ad6f3bd78a88e849_Progressive<TInputBuffer> tableReader_f74819ec8dbd4e85ad6f3bd78a88e849_Progressive = orCreateRow[colIndex];
			if (tableReader_f74819ec8dbd4e85ad6f3bd78a88e849_Progressive == null)
			{
				tableReader_f74819ec8dbd4e85ad6f3bd78a88e849_Progressive = (orCreateRow[colIndex] = UnsafeParseItem(index));
			}
			return tableReader_f74819ec8dbd4e85ad6f3bd78a88e849_Progressive;
		}

		private void ProgressiveSet(int index, ScriptVariable value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, ScriptVariable value)
		{
			VectorUtilities.CheckIndex(index, count);
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N6653D642A3BD1AB4F399EABB79121E79E2C33BFE9CFD67906A9C4D1D80BD7B56.Helpers.tableReader_f74819ec8dbd4e85ad6f3bd78a88e849_Progressive<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N6653D642A3BD1AB4F399EABB79121E79E2C33BFE9CFD67906A9C4D1D80BD7B56.Helpers.tableReader_f74819ec8dbd4e85ad6f3bd78a88e849_Progressive<TInputBuffer> UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.N6653D642A3BD1AB4F399EABB79121E79E2C33BFE9CFD67906A9C4D1D80BD7B56.Helpers.Parse_Progressive(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, ScriptVariable value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(ScriptVariable? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(ScriptVariable? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(ScriptVariable[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<ScriptVariable> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(ScriptVariable item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, ScriptVariable item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(ScriptVariable item)
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

	[DebuggerDisplay("Greedy [ ScriptVariable ], Count = {Count}")]
	internal sealed class GeneratedVector_1ae5fdff8f91108fefc2ada8a65cf2ee_Greedy<TInputBuffer> : IList<ScriptVariable>, ICollection<ScriptVariable>, IEnumerable<ScriptVariable>, IEnumerable, IReadOnlyList<ScriptVariable>, IReadOnlyCollection<ScriptVariable> where TInputBuffer : IInputBuffer
	{
		private readonly List<FlatSharp.Compiler.Generated.N6653D642A3BD1AB4F399EABB79121E79E2C33BFE9CFD67906A9C4D1D80BD7B56.Helpers.tableReader_f74819ec8dbd4e85ad6f3bd78a88e849_Greedy<TInputBuffer>> list;

		public ScriptVariable this[int index]
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

		public GeneratedVector_1ae5fdff8f91108fefc2ada8a65cf2ee_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<FlatSharp.Compiler.Generated.N6653D642A3BD1AB4F399EABB79121E79E2C33BFE9CFD67906A9C4D1D80BD7B56.Helpers.tableReader_f74819ec8dbd4e85ad6f3bd78a88e849_Greedy<TInputBuffer>> list = (this.list = new List<FlatSharp.Compiler.Generated.N6653D642A3BD1AB4F399EABB79121E79E2C33BFE9CFD67906A9C4D1D80BD7B56.Helpers.tableReader_f74819ec8dbd4e85ad6f3bd78a88e849_Greedy<TInputBuffer>>(num));
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.N6653D642A3BD1AB4F399EABB79121E79E2C33BFE9CFD67906A9C4D1D80BD7B56.Helpers.tableReader_f74819ec8dbd4e85ad6f3bd78a88e849_Greedy<TInputBuffer> item = FlatSharp.Compiler.Generated.N6653D642A3BD1AB4F399EABB79121E79E2C33BFE9CFD67906A9C4D1D80BD7B56.Helpers.Parse_Greedy(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		private FlatSharp.Compiler.Generated.N6653D642A3BD1AB4F399EABB79121E79E2C33BFE9CFD67906A9C4D1D80BD7B56.Helpers.tableReader_f74819ec8dbd4e85ad6f3bd78a88e849_Greedy<TInputBuffer> GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, ScriptVariable value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(ScriptVariable? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(ScriptVariable? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(ScriptVariable[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<ScriptVariable> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(ScriptVariable item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, ScriptVariable item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(ScriptVariable item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ ScriptVariable ], Count = {Count}")]
	internal sealed class GeneratedVector_1ae5fdff8f91108fefc2ada8a65cf2ee_GreedyMutable<TInputBuffer> : IList<ScriptVariable>, ICollection<ScriptVariable>, IEnumerable<ScriptVariable>, IEnumerable, IReadOnlyList<ScriptVariable>, IReadOnlyCollection<ScriptVariable> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<ScriptVariable> list;

		public ScriptVariable this[int index]
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

		public GeneratedVector_1ae5fdff8f91108fefc2ada8a65cf2ee_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<ScriptVariable> list = (this.list = new List<ScriptVariable>());
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.N6653D642A3BD1AB4F399EABB79121E79E2C33BFE9CFD67906A9C4D1D80BD7B56.Helpers.tableReader_f74819ec8dbd4e85ad6f3bd78a88e849_GreedyMutable<TInputBuffer> item = FlatSharp.Compiler.Generated.N6653D642A3BD1AB4F399EABB79121E79E2C33BFE9CFD67906A9C4D1D80BD7B56.Helpers.Parse_GreedyMutable(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private ScriptVariable GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, ScriptVariable value)
		{
			list[index] = value;
		}

		public void Add(ScriptVariable item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, ScriptVariable item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(ScriptVariable item)
		{
			return list.Remove(item);
		}

		public bool Contains(ScriptVariable? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(ScriptVariable? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(ScriptVariable[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<ScriptVariable> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<ScriptVariable> value)
	{
		int count = value.Count;
		int num = 14;
		if (value is ScriptVariable[] array)
		{
			foreach (ScriptVariable scriptVariable in array)
			{
				SerializationHelpers.EnsureNonNull(scriptVariable);
				num += FlatSharp.Compiler.Generated.N6653D642A3BD1AB4F399EABB79121E79E2C33BFE9CFD67906A9C4D1D80BD7B56.Helpers.GetMaxSize(scriptVariable);
			}
		}
		else if (value is List<ScriptVariable> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				ScriptVariable scriptVariable2 = list[j];
				SerializationHelpers.EnsureNonNull(scriptVariable2);
				num += FlatSharp.Compiler.Generated.N6653D642A3BD1AB4F399EABB79121E79E2C33BFE9CFD67906A9C4D1D80BD7B56.Helpers.GetMaxSize(scriptVariable2);
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				ScriptVariable scriptVariable3 = value[k];
				SerializationHelpers.EnsureNonNull(scriptVariable3);
				num += FlatSharp.Compiler.Generated.N6653D642A3BD1AB4F399EABB79121E79E2C33BFE9CFD67906A9C4D1D80BD7B56.Helpers.GetMaxSize(scriptVariable3);
			}
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<ScriptVariable> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 4);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is ScriptVariable[] array)
		{
			foreach (ScriptVariable scriptVariable in array)
			{
				SerializationHelpers.EnsureNonNull(scriptVariable);
				FlatSharp.Compiler.Generated.N6653D642A3BD1AB4F399EABB79121E79E2C33BFE9CFD67906A9C4D1D80BD7B56.Helpers.Serialize(spanWriter, span, scriptVariable, num, context);
				num += 4;
			}
		}
		else if (value is List<ScriptVariable> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				ScriptVariable scriptVariable2 = list[j];
				SerializationHelpers.EnsureNonNull(scriptVariable2);
				FlatSharp.Compiler.Generated.N6653D642A3BD1AB4F399EABB79121E79E2C33BFE9CFD67906A9C4D1D80BD7B56.Helpers.Serialize(spanWriter, span, scriptVariable2, num, context);
				num += 4;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				ScriptVariable scriptVariable3 = value[k];
				SerializationHelpers.EnsureNonNull(scriptVariable3);
				FlatSharp.Compiler.Generated.N6653D642A3BD1AB4F399EABB79121E79E2C33BFE9CFD67906A9C4D1D80BD7B56.Helpers.Serialize(spanWriter, span, scriptVariable3, num, context);
				num += 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<ScriptVariable> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return new GeneratedVector_1ae5fdff8f91108fefc2ada8a65cf2ee_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<ScriptVariable> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return new GeneratedVector_1ae5fdff8f91108fefc2ada8a65cf2ee_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<ScriptVariable> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return new GeneratedVector_1ae5fdff8f91108fefc2ada8a65cf2ee_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<ScriptVariable> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return new GeneratedVector_1ae5fdff8f91108fefc2ada8a65cf2ee_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
