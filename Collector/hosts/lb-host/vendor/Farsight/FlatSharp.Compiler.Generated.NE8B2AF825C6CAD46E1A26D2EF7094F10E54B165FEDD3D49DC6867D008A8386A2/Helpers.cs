using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Scene;
using FlatSharp.Compiler.Generated.N0625BBC64A09D0866F782D02C4DAA3CFEAA98CFF2EFCD18F07EBD3ACB4D1240E;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.NE8B2AF825C6CAD46E1A26D2EF7094F10E54B165FEDD3D49DC6867D008A8386A2;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ SceneDescriptor ], Count = {Count}")]
	internal sealed class GeneratedVector_c6e2887e4e229d054c5a63a35dce2639_Lazy<TInputBuffer> : IList<SceneDescriptor>, ICollection<SceneDescriptor>, IEnumerable<SceneDescriptor>, IEnumerable, IReadOnlyList<SceneDescriptor>, IReadOnlyCollection<SceneDescriptor>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public SceneDescriptor this[int index]
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

		public GeneratedVector_c6e2887e4e229d054c5a63a35dce2639_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N0625BBC64A09D0866F782D02C4DAA3CFEAA98CFF2EFCD18F07EBD3ACB4D1240E.Helpers.tableReader_42c697a498bb4fb2adf1f1a53ccaac41_Lazy<TInputBuffer> SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N0625BBC64A09D0866F782D02C4DAA3CFEAA98CFF2EFCD18F07EBD3ACB4D1240E.Helpers.tableReader_42c697a498bb4fb2adf1f1a53ccaac41_Lazy<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return FlatSharp.Compiler.Generated.N0625BBC64A09D0866F782D02C4DAA3CFEAA98CFF2EFCD18F07EBD3ACB4D1240E.Helpers.Parse_Lazy(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, SceneDescriptor value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(SceneDescriptor? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(SceneDescriptor? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(SceneDescriptor[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<SceneDescriptor> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(SceneDescriptor item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, SceneDescriptor item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(SceneDescriptor item)
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

	[DebuggerDisplay("Progressive [ SceneDescriptor ], Count = {Count}")]
	internal sealed class GeneratedVector_c6e2887e4e229d054c5a63a35dce2639_Progressive<TInputBuffer> : IList<SceneDescriptor>, ICollection<SceneDescriptor>, IEnumerable<SceneDescriptor>, IEnumerable, IReadOnlyList<SceneDescriptor>, IReadOnlyCollection<SceneDescriptor>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly FlatSharp.Compiler.Generated.N0625BBC64A09D0866F782D02C4DAA3CFEAA98CFF2EFCD18F07EBD3ACB4D1240E.Helpers.tableReader_42c697a498bb4fb2adf1f1a53ccaac41_Progressive<TInputBuffer>?[]?[] items;

		public SceneDescriptor this[int index]
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

		public GeneratedVector_c6e2887e4e229d054c5a63a35dce2639_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new FlatSharp.Compiler.Generated.N0625BBC64A09D0866F782D02C4DAA3CFEAA98CFF2EFCD18F07EBD3ACB4D1240E.Helpers.tableReader_42c697a498bb4fb2adf1f1a53ccaac41_Progressive<TInputBuffer>[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N0625BBC64A09D0866F782D02C4DAA3CFEAA98CFF2EFCD18F07EBD3ACB4D1240E.Helpers.tableReader_42c697a498bb4fb2adf1f1a53ccaac41_Progressive<TInputBuffer>?[] GetOrCreateRow(FlatSharp.Compiler.Generated.N0625BBC64A09D0866F782D02C4DAA3CFEAA98CFF2EFCD18F07EBD3ACB4D1240E.Helpers.tableReader_42c697a498bb4fb2adf1f1a53ccaac41_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private FlatSharp.Compiler.Generated.N0625BBC64A09D0866F782D02C4DAA3CFEAA98CFF2EFCD18F07EBD3ACB4D1240E.Helpers.tableReader_42c697a498bb4fb2adf1f1a53ccaac41_Progressive<TInputBuffer>?[] CreateRow(FlatSharp.Compiler.Generated.N0625BBC64A09D0866F782D02C4DAA3CFEAA98CFF2EFCD18F07EBD3ACB4D1240E.Helpers.tableReader_42c697a498bb4fb2adf1f1a53ccaac41_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] = new FlatSharp.Compiler.Generated.N0625BBC64A09D0866F782D02C4DAA3CFEAA98CFF2EFCD18F07EBD3ACB4D1240E.Helpers.tableReader_42c697a498bb4fb2adf1f1a53ccaac41_Progressive<TInputBuffer>[32];
		}

		private FlatSharp.Compiler.Generated.N0625BBC64A09D0866F782D02C4DAA3CFEAA98CFF2EFCD18F07EBD3ACB4D1240E.Helpers.tableReader_42c697a498bb4fb2adf1f1a53ccaac41_Progressive<TInputBuffer> ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			FlatSharp.Compiler.Generated.N0625BBC64A09D0866F782D02C4DAA3CFEAA98CFF2EFCD18F07EBD3ACB4D1240E.Helpers.tableReader_42c697a498bb4fb2adf1f1a53ccaac41_Progressive<TInputBuffer>[][] array = items;
			FlatSharp.Compiler.Generated.N0625BBC64A09D0866F782D02C4DAA3CFEAA98CFF2EFCD18F07EBD3ACB4D1240E.Helpers.tableReader_42c697a498bb4fb2adf1f1a53ccaac41_Progressive<TInputBuffer>[] orCreateRow = GetOrCreateRow(array, rowIndex);
			FlatSharp.Compiler.Generated.N0625BBC64A09D0866F782D02C4DAA3CFEAA98CFF2EFCD18F07EBD3ACB4D1240E.Helpers.tableReader_42c697a498bb4fb2adf1f1a53ccaac41_Progressive<TInputBuffer> tableReader_42c697a498bb4fb2adf1f1a53ccaac41_Progressive = orCreateRow[colIndex];
			if (tableReader_42c697a498bb4fb2adf1f1a53ccaac41_Progressive == null)
			{
				tableReader_42c697a498bb4fb2adf1f1a53ccaac41_Progressive = (orCreateRow[colIndex] = UnsafeParseItem(index));
			}
			return tableReader_42c697a498bb4fb2adf1f1a53ccaac41_Progressive;
		}

		private void ProgressiveSet(int index, SceneDescriptor value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, SceneDescriptor value)
		{
			VectorUtilities.CheckIndex(index, count);
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N0625BBC64A09D0866F782D02C4DAA3CFEAA98CFF2EFCD18F07EBD3ACB4D1240E.Helpers.tableReader_42c697a498bb4fb2adf1f1a53ccaac41_Progressive<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N0625BBC64A09D0866F782D02C4DAA3CFEAA98CFF2EFCD18F07EBD3ACB4D1240E.Helpers.tableReader_42c697a498bb4fb2adf1f1a53ccaac41_Progressive<TInputBuffer> UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.N0625BBC64A09D0866F782D02C4DAA3CFEAA98CFF2EFCD18F07EBD3ACB4D1240E.Helpers.Parse_Progressive(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, SceneDescriptor value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(SceneDescriptor? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(SceneDescriptor? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(SceneDescriptor[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<SceneDescriptor> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(SceneDescriptor item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, SceneDescriptor item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(SceneDescriptor item)
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

	[DebuggerDisplay("Greedy [ SceneDescriptor ], Count = {Count}")]
	internal sealed class GeneratedVector_c6e2887e4e229d054c5a63a35dce2639_Greedy<TInputBuffer> : IList<SceneDescriptor>, ICollection<SceneDescriptor>, IEnumerable<SceneDescriptor>, IEnumerable, IReadOnlyList<SceneDescriptor>, IReadOnlyCollection<SceneDescriptor> where TInputBuffer : IInputBuffer
	{
		private readonly List<FlatSharp.Compiler.Generated.N0625BBC64A09D0866F782D02C4DAA3CFEAA98CFF2EFCD18F07EBD3ACB4D1240E.Helpers.tableReader_42c697a498bb4fb2adf1f1a53ccaac41_Greedy<TInputBuffer>> list;

		public SceneDescriptor this[int index]
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

		public GeneratedVector_c6e2887e4e229d054c5a63a35dce2639_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<FlatSharp.Compiler.Generated.N0625BBC64A09D0866F782D02C4DAA3CFEAA98CFF2EFCD18F07EBD3ACB4D1240E.Helpers.tableReader_42c697a498bb4fb2adf1f1a53ccaac41_Greedy<TInputBuffer>> list = (this.list = new List<FlatSharp.Compiler.Generated.N0625BBC64A09D0866F782D02C4DAA3CFEAA98CFF2EFCD18F07EBD3ACB4D1240E.Helpers.tableReader_42c697a498bb4fb2adf1f1a53ccaac41_Greedy<TInputBuffer>>(num));
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.N0625BBC64A09D0866F782D02C4DAA3CFEAA98CFF2EFCD18F07EBD3ACB4D1240E.Helpers.tableReader_42c697a498bb4fb2adf1f1a53ccaac41_Greedy<TInputBuffer> item = FlatSharp.Compiler.Generated.N0625BBC64A09D0866F782D02C4DAA3CFEAA98CFF2EFCD18F07EBD3ACB4D1240E.Helpers.Parse_Greedy(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		private FlatSharp.Compiler.Generated.N0625BBC64A09D0866F782D02C4DAA3CFEAA98CFF2EFCD18F07EBD3ACB4D1240E.Helpers.tableReader_42c697a498bb4fb2adf1f1a53ccaac41_Greedy<TInputBuffer> GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, SceneDescriptor value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(SceneDescriptor? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(SceneDescriptor? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(SceneDescriptor[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<SceneDescriptor> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(SceneDescriptor item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, SceneDescriptor item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(SceneDescriptor item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ SceneDescriptor ], Count = {Count}")]
	internal sealed class GeneratedVector_c6e2887e4e229d054c5a63a35dce2639_GreedyMutable<TInputBuffer> : IList<SceneDescriptor>, ICollection<SceneDescriptor>, IEnumerable<SceneDescriptor>, IEnumerable, IReadOnlyList<SceneDescriptor>, IReadOnlyCollection<SceneDescriptor> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<SceneDescriptor> list;

		public SceneDescriptor this[int index]
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

		public GeneratedVector_c6e2887e4e229d054c5a63a35dce2639_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<SceneDescriptor> list = (this.list = new List<SceneDescriptor>());
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.N0625BBC64A09D0866F782D02C4DAA3CFEAA98CFF2EFCD18F07EBD3ACB4D1240E.Helpers.tableReader_42c697a498bb4fb2adf1f1a53ccaac41_GreedyMutable<TInputBuffer> item = FlatSharp.Compiler.Generated.N0625BBC64A09D0866F782D02C4DAA3CFEAA98CFF2EFCD18F07EBD3ACB4D1240E.Helpers.Parse_GreedyMutable(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private SceneDescriptor GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, SceneDescriptor value)
		{
			list[index] = value;
		}

		public void Add(SceneDescriptor item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, SceneDescriptor item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(SceneDescriptor item)
		{
			return list.Remove(item);
		}

		public bool Contains(SceneDescriptor? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(SceneDescriptor? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(SceneDescriptor[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<SceneDescriptor> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<SceneDescriptor> value)
	{
		int count = value.Count;
		int num = 14;
		if (value is SceneDescriptor[] array)
		{
			foreach (SceneDescriptor sceneDescriptor in array)
			{
				SerializationHelpers.EnsureNonNull(sceneDescriptor);
				num += FlatSharp.Compiler.Generated.N0625BBC64A09D0866F782D02C4DAA3CFEAA98CFF2EFCD18F07EBD3ACB4D1240E.Helpers.GetMaxSize(sceneDescriptor);
			}
		}
		else if (value is List<SceneDescriptor> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				SceneDescriptor sceneDescriptor2 = list[j];
				SerializationHelpers.EnsureNonNull(sceneDescriptor2);
				num += FlatSharp.Compiler.Generated.N0625BBC64A09D0866F782D02C4DAA3CFEAA98CFF2EFCD18F07EBD3ACB4D1240E.Helpers.GetMaxSize(sceneDescriptor2);
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				SceneDescriptor sceneDescriptor3 = value[k];
				SerializationHelpers.EnsureNonNull(sceneDescriptor3);
				num += FlatSharp.Compiler.Generated.N0625BBC64A09D0866F782D02C4DAA3CFEAA98CFF2EFCD18F07EBD3ACB4D1240E.Helpers.GetMaxSize(sceneDescriptor3);
			}
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<SceneDescriptor> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 4);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is SceneDescriptor[] array)
		{
			foreach (SceneDescriptor sceneDescriptor in array)
			{
				SerializationHelpers.EnsureNonNull(sceneDescriptor);
				FlatSharp.Compiler.Generated.N0625BBC64A09D0866F782D02C4DAA3CFEAA98CFF2EFCD18F07EBD3ACB4D1240E.Helpers.Serialize(spanWriter, span, sceneDescriptor, num, context);
				num += 4;
			}
		}
		else if (value is List<SceneDescriptor> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				SceneDescriptor sceneDescriptor2 = list[j];
				SerializationHelpers.EnsureNonNull(sceneDescriptor2);
				FlatSharp.Compiler.Generated.N0625BBC64A09D0866F782D02C4DAA3CFEAA98CFF2EFCD18F07EBD3ACB4D1240E.Helpers.Serialize(spanWriter, span, sceneDescriptor2, num, context);
				num += 4;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				SceneDescriptor sceneDescriptor3 = value[k];
				SerializationHelpers.EnsureNonNull(sceneDescriptor3);
				FlatSharp.Compiler.Generated.N0625BBC64A09D0866F782D02C4DAA3CFEAA98CFF2EFCD18F07EBD3ACB4D1240E.Helpers.Serialize(spanWriter, span, sceneDescriptor3, num, context);
				num += 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<SceneDescriptor> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_c6e2887e4e229d054c5a63a35dce2639_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<SceneDescriptor> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_c6e2887e4e229d054c5a63a35dce2639_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<SceneDescriptor> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_c6e2887e4e229d054c5a63a35dce2639_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<SceneDescriptor> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_c6e2887e4e229d054c5a63a35dce2639_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
