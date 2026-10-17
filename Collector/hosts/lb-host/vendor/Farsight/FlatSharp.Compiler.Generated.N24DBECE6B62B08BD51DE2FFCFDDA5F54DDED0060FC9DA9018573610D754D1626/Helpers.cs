using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Snapshot;
using FlatSharp.Compiler.Generated.ND04F1E323B11E62B6D1B4580D7B3580EFBBC2B1C0828CFC907B0FCCD7090220C;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N24DBECE6B62B08BD51DE2FFCFDDA5F54DDED0060FC9DA9018573610D754D1626;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ GeneralParticleEmitter ], Count = {Count}")]
	internal sealed class GeneratedVector_7491b3cd38f731eacd34c20f2dc30417_Lazy<TInputBuffer> : IList<GeneralParticleEmitter>, ICollection<GeneralParticleEmitter>, IEnumerable<GeneralParticleEmitter>, IEnumerable, IReadOnlyList<GeneralParticleEmitter>, IReadOnlyCollection<GeneralParticleEmitter>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public GeneralParticleEmitter this[int index]
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

		public GeneratedVector_7491b3cd38f731eacd34c20f2dc30417_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.ND04F1E323B11E62B6D1B4580D7B3580EFBBC2B1C0828CFC907B0FCCD7090220C.Helpers.tableReader_41132112df9b403ab406960490b92c4e_Lazy<TInputBuffer> SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.ND04F1E323B11E62B6D1B4580D7B3580EFBBC2B1C0828CFC907B0FCCD7090220C.Helpers.tableReader_41132112df9b403ab406960490b92c4e_Lazy<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return FlatSharp.Compiler.Generated.ND04F1E323B11E62B6D1B4580D7B3580EFBBC2B1C0828CFC907B0FCCD7090220C.Helpers.Parse_Lazy(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, GeneralParticleEmitter value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(GeneralParticleEmitter? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(GeneralParticleEmitter? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(GeneralParticleEmitter[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<GeneralParticleEmitter> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(GeneralParticleEmitter item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, GeneralParticleEmitter item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(GeneralParticleEmitter item)
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

	[DebuggerDisplay("Progressive [ GeneralParticleEmitter ], Count = {Count}")]
	internal sealed class GeneratedVector_7491b3cd38f731eacd34c20f2dc30417_Progressive<TInputBuffer> : IList<GeneralParticleEmitter>, ICollection<GeneralParticleEmitter>, IEnumerable<GeneralParticleEmitter>, IEnumerable, IReadOnlyList<GeneralParticleEmitter>, IReadOnlyCollection<GeneralParticleEmitter>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly FlatSharp.Compiler.Generated.ND04F1E323B11E62B6D1B4580D7B3580EFBBC2B1C0828CFC907B0FCCD7090220C.Helpers.tableReader_41132112df9b403ab406960490b92c4e_Progressive<TInputBuffer>?[]?[] items;

		public GeneralParticleEmitter this[int index]
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

		public GeneratedVector_7491b3cd38f731eacd34c20f2dc30417_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new FlatSharp.Compiler.Generated.ND04F1E323B11E62B6D1B4580D7B3580EFBBC2B1C0828CFC907B0FCCD7090220C.Helpers.tableReader_41132112df9b403ab406960490b92c4e_Progressive<TInputBuffer>[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.ND04F1E323B11E62B6D1B4580D7B3580EFBBC2B1C0828CFC907B0FCCD7090220C.Helpers.tableReader_41132112df9b403ab406960490b92c4e_Progressive<TInputBuffer>?[] GetOrCreateRow(FlatSharp.Compiler.Generated.ND04F1E323B11E62B6D1B4580D7B3580EFBBC2B1C0828CFC907B0FCCD7090220C.Helpers.tableReader_41132112df9b403ab406960490b92c4e_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private FlatSharp.Compiler.Generated.ND04F1E323B11E62B6D1B4580D7B3580EFBBC2B1C0828CFC907B0FCCD7090220C.Helpers.tableReader_41132112df9b403ab406960490b92c4e_Progressive<TInputBuffer>?[] CreateRow(FlatSharp.Compiler.Generated.ND04F1E323B11E62B6D1B4580D7B3580EFBBC2B1C0828CFC907B0FCCD7090220C.Helpers.tableReader_41132112df9b403ab406960490b92c4e_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] = new FlatSharp.Compiler.Generated.ND04F1E323B11E62B6D1B4580D7B3580EFBBC2B1C0828CFC907B0FCCD7090220C.Helpers.tableReader_41132112df9b403ab406960490b92c4e_Progressive<TInputBuffer>[32];
		}

		private FlatSharp.Compiler.Generated.ND04F1E323B11E62B6D1B4580D7B3580EFBBC2B1C0828CFC907B0FCCD7090220C.Helpers.tableReader_41132112df9b403ab406960490b92c4e_Progressive<TInputBuffer> ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			FlatSharp.Compiler.Generated.ND04F1E323B11E62B6D1B4580D7B3580EFBBC2B1C0828CFC907B0FCCD7090220C.Helpers.tableReader_41132112df9b403ab406960490b92c4e_Progressive<TInputBuffer>[][] array = items;
			FlatSharp.Compiler.Generated.ND04F1E323B11E62B6D1B4580D7B3580EFBBC2B1C0828CFC907B0FCCD7090220C.Helpers.tableReader_41132112df9b403ab406960490b92c4e_Progressive<TInputBuffer>[] orCreateRow = GetOrCreateRow(array, rowIndex);
			FlatSharp.Compiler.Generated.ND04F1E323B11E62B6D1B4580D7B3580EFBBC2B1C0828CFC907B0FCCD7090220C.Helpers.tableReader_41132112df9b403ab406960490b92c4e_Progressive<TInputBuffer> tableReader_41132112df9b403ab406960490b92c4e_Progressive = orCreateRow[colIndex];
			if (tableReader_41132112df9b403ab406960490b92c4e_Progressive == null)
			{
				tableReader_41132112df9b403ab406960490b92c4e_Progressive = (orCreateRow[colIndex] = UnsafeParseItem(index));
			}
			return tableReader_41132112df9b403ab406960490b92c4e_Progressive;
		}

		private void ProgressiveSet(int index, GeneralParticleEmitter value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, GeneralParticleEmitter value)
		{
			VectorUtilities.CheckIndex(index, count);
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.ND04F1E323B11E62B6D1B4580D7B3580EFBBC2B1C0828CFC907B0FCCD7090220C.Helpers.tableReader_41132112df9b403ab406960490b92c4e_Progressive<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.ND04F1E323B11E62B6D1B4580D7B3580EFBBC2B1C0828CFC907B0FCCD7090220C.Helpers.tableReader_41132112df9b403ab406960490b92c4e_Progressive<TInputBuffer> UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.ND04F1E323B11E62B6D1B4580D7B3580EFBBC2B1C0828CFC907B0FCCD7090220C.Helpers.Parse_Progressive(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, GeneralParticleEmitter value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(GeneralParticleEmitter? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(GeneralParticleEmitter? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(GeneralParticleEmitter[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<GeneralParticleEmitter> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(GeneralParticleEmitter item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, GeneralParticleEmitter item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(GeneralParticleEmitter item)
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

	[DebuggerDisplay("Greedy [ GeneralParticleEmitter ], Count = {Count}")]
	internal sealed class GeneratedVector_7491b3cd38f731eacd34c20f2dc30417_Greedy<TInputBuffer> : IList<GeneralParticleEmitter>, ICollection<GeneralParticleEmitter>, IEnumerable<GeneralParticleEmitter>, IEnumerable, IReadOnlyList<GeneralParticleEmitter>, IReadOnlyCollection<GeneralParticleEmitter> where TInputBuffer : IInputBuffer
	{
		private readonly List<FlatSharp.Compiler.Generated.ND04F1E323B11E62B6D1B4580D7B3580EFBBC2B1C0828CFC907B0FCCD7090220C.Helpers.tableReader_41132112df9b403ab406960490b92c4e_Greedy<TInputBuffer>> list;

		public GeneralParticleEmitter this[int index]
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

		public GeneratedVector_7491b3cd38f731eacd34c20f2dc30417_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<FlatSharp.Compiler.Generated.ND04F1E323B11E62B6D1B4580D7B3580EFBBC2B1C0828CFC907B0FCCD7090220C.Helpers.tableReader_41132112df9b403ab406960490b92c4e_Greedy<TInputBuffer>> list = (this.list = new List<FlatSharp.Compiler.Generated.ND04F1E323B11E62B6D1B4580D7B3580EFBBC2B1C0828CFC907B0FCCD7090220C.Helpers.tableReader_41132112df9b403ab406960490b92c4e_Greedy<TInputBuffer>>(num));
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.ND04F1E323B11E62B6D1B4580D7B3580EFBBC2B1C0828CFC907B0FCCD7090220C.Helpers.tableReader_41132112df9b403ab406960490b92c4e_Greedy<TInputBuffer> item = FlatSharp.Compiler.Generated.ND04F1E323B11E62B6D1B4580D7B3580EFBBC2B1C0828CFC907B0FCCD7090220C.Helpers.Parse_Greedy(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		private FlatSharp.Compiler.Generated.ND04F1E323B11E62B6D1B4580D7B3580EFBBC2B1C0828CFC907B0FCCD7090220C.Helpers.tableReader_41132112df9b403ab406960490b92c4e_Greedy<TInputBuffer> GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, GeneralParticleEmitter value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(GeneralParticleEmitter? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(GeneralParticleEmitter? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(GeneralParticleEmitter[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<GeneralParticleEmitter> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(GeneralParticleEmitter item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, GeneralParticleEmitter item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(GeneralParticleEmitter item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ GeneralParticleEmitter ], Count = {Count}")]
	internal sealed class GeneratedVector_7491b3cd38f731eacd34c20f2dc30417_GreedyMutable<TInputBuffer> : IList<GeneralParticleEmitter>, ICollection<GeneralParticleEmitter>, IEnumerable<GeneralParticleEmitter>, IEnumerable, IReadOnlyList<GeneralParticleEmitter>, IReadOnlyCollection<GeneralParticleEmitter> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<GeneralParticleEmitter> list;

		public GeneralParticleEmitter this[int index]
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

		public GeneratedVector_7491b3cd38f731eacd34c20f2dc30417_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<GeneralParticleEmitter> list = (this.list = new List<GeneralParticleEmitter>());
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.ND04F1E323B11E62B6D1B4580D7B3580EFBBC2B1C0828CFC907B0FCCD7090220C.Helpers.tableReader_41132112df9b403ab406960490b92c4e_GreedyMutable<TInputBuffer> item = FlatSharp.Compiler.Generated.ND04F1E323B11E62B6D1B4580D7B3580EFBBC2B1C0828CFC907B0FCCD7090220C.Helpers.Parse_GreedyMutable(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private GeneralParticleEmitter GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, GeneralParticleEmitter value)
		{
			list[index] = value;
		}

		public void Add(GeneralParticleEmitter item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, GeneralParticleEmitter item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(GeneralParticleEmitter item)
		{
			return list.Remove(item);
		}

		public bool Contains(GeneralParticleEmitter? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(GeneralParticleEmitter? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(GeneralParticleEmitter[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<GeneralParticleEmitter> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<GeneralParticleEmitter> value)
	{
		int count = value.Count;
		int num = 14;
		if (value is GeneralParticleEmitter[] array)
		{
			foreach (GeneralParticleEmitter generalParticleEmitter in array)
			{
				SerializationHelpers.EnsureNonNull(generalParticleEmitter);
				num += FlatSharp.Compiler.Generated.ND04F1E323B11E62B6D1B4580D7B3580EFBBC2B1C0828CFC907B0FCCD7090220C.Helpers.GetMaxSize(generalParticleEmitter);
			}
		}
		else if (value is List<GeneralParticleEmitter> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				GeneralParticleEmitter generalParticleEmitter2 = list[j];
				SerializationHelpers.EnsureNonNull(generalParticleEmitter2);
				num += FlatSharp.Compiler.Generated.ND04F1E323B11E62B6D1B4580D7B3580EFBBC2B1C0828CFC907B0FCCD7090220C.Helpers.GetMaxSize(generalParticleEmitter2);
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				GeneralParticleEmitter generalParticleEmitter3 = value[k];
				SerializationHelpers.EnsureNonNull(generalParticleEmitter3);
				num += FlatSharp.Compiler.Generated.ND04F1E323B11E62B6D1B4580D7B3580EFBBC2B1C0828CFC907B0FCCD7090220C.Helpers.GetMaxSize(generalParticleEmitter3);
			}
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<GeneralParticleEmitter> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 4);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is GeneralParticleEmitter[] array)
		{
			foreach (GeneralParticleEmitter generalParticleEmitter in array)
			{
				SerializationHelpers.EnsureNonNull(generalParticleEmitter);
				FlatSharp.Compiler.Generated.ND04F1E323B11E62B6D1B4580D7B3580EFBBC2B1C0828CFC907B0FCCD7090220C.Helpers.Serialize(spanWriter, span, generalParticleEmitter, num, context);
				num += 4;
			}
		}
		else if (value is List<GeneralParticleEmitter> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				GeneralParticleEmitter generalParticleEmitter2 = list[j];
				SerializationHelpers.EnsureNonNull(generalParticleEmitter2);
				FlatSharp.Compiler.Generated.ND04F1E323B11E62B6D1B4580D7B3580EFBBC2B1C0828CFC907B0FCCD7090220C.Helpers.Serialize(spanWriter, span, generalParticleEmitter2, num, context);
				num += 4;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				GeneralParticleEmitter generalParticleEmitter3 = value[k];
				SerializationHelpers.EnsureNonNull(generalParticleEmitter3);
				FlatSharp.Compiler.Generated.ND04F1E323B11E62B6D1B4580D7B3580EFBBC2B1C0828CFC907B0FCCD7090220C.Helpers.Serialize(spanWriter, span, generalParticleEmitter3, num, context);
				num += 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<GeneralParticleEmitter> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_7491b3cd38f731eacd34c20f2dc30417_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<GeneralParticleEmitter> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_7491b3cd38f731eacd34c20f2dc30417_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<GeneralParticleEmitter> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_7491b3cd38f731eacd34c20f2dc30417_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<GeneralParticleEmitter> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_7491b3cd38f731eacd34c20f2dc30417_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
