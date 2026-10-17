using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Scene;
using FlatSharp.Compiler.Generated.NCAE7D2E61298C73EB9C86E4A28C7DCE1C1488F40CB9167B4CDECD5E1D1E1EED2;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.NC9DF63DA835B79D8627BC335CABE09A6C4192D66C4AF793BECE714E68165541C;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ EntityCreate ], Count = {Count}")]
	internal sealed class GeneratedVector_0bcdc0abf878fd1ed7998cf8739be3e4_Lazy<TInputBuffer> : IList<EntityCreate>, ICollection<EntityCreate>, IEnumerable<EntityCreate>, IEnumerable, IReadOnlyList<EntityCreate>, IReadOnlyCollection<EntityCreate>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public EntityCreate this[int index]
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

		public GeneratedVector_0bcdc0abf878fd1ed7998cf8739be3e4_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NCAE7D2E61298C73EB9C86E4A28C7DCE1C1488F40CB9167B4CDECD5E1D1E1EED2.Helpers.tableReader_b0916b98124d4b709f8b609cdd52e42f_Lazy<TInputBuffer> SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NCAE7D2E61298C73EB9C86E4A28C7DCE1C1488F40CB9167B4CDECD5E1D1E1EED2.Helpers.tableReader_b0916b98124d4b709f8b609cdd52e42f_Lazy<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return FlatSharp.Compiler.Generated.NCAE7D2E61298C73EB9C86E4A28C7DCE1C1488F40CB9167B4CDECD5E1D1E1EED2.Helpers.Parse_Lazy(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, EntityCreate value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(EntityCreate? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(EntityCreate? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(EntityCreate[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<EntityCreate> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(EntityCreate item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, EntityCreate item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(EntityCreate item)
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

	[DebuggerDisplay("Progressive [ EntityCreate ], Count = {Count}")]
	internal sealed class GeneratedVector_0bcdc0abf878fd1ed7998cf8739be3e4_Progressive<TInputBuffer> : IList<EntityCreate>, ICollection<EntityCreate>, IEnumerable<EntityCreate>, IEnumerable, IReadOnlyList<EntityCreate>, IReadOnlyCollection<EntityCreate>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly FlatSharp.Compiler.Generated.NCAE7D2E61298C73EB9C86E4A28C7DCE1C1488F40CB9167B4CDECD5E1D1E1EED2.Helpers.tableReader_b0916b98124d4b709f8b609cdd52e42f_Progressive<TInputBuffer>?[]?[] items;

		public EntityCreate this[int index]
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

		public GeneratedVector_0bcdc0abf878fd1ed7998cf8739be3e4_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new FlatSharp.Compiler.Generated.NCAE7D2E61298C73EB9C86E4A28C7DCE1C1488F40CB9167B4CDECD5E1D1E1EED2.Helpers.tableReader_b0916b98124d4b709f8b609cdd52e42f_Progressive<TInputBuffer>[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NCAE7D2E61298C73EB9C86E4A28C7DCE1C1488F40CB9167B4CDECD5E1D1E1EED2.Helpers.tableReader_b0916b98124d4b709f8b609cdd52e42f_Progressive<TInputBuffer>?[] GetOrCreateRow(FlatSharp.Compiler.Generated.NCAE7D2E61298C73EB9C86E4A28C7DCE1C1488F40CB9167B4CDECD5E1D1E1EED2.Helpers.tableReader_b0916b98124d4b709f8b609cdd52e42f_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private FlatSharp.Compiler.Generated.NCAE7D2E61298C73EB9C86E4A28C7DCE1C1488F40CB9167B4CDECD5E1D1E1EED2.Helpers.tableReader_b0916b98124d4b709f8b609cdd52e42f_Progressive<TInputBuffer>?[] CreateRow(FlatSharp.Compiler.Generated.NCAE7D2E61298C73EB9C86E4A28C7DCE1C1488F40CB9167B4CDECD5E1D1E1EED2.Helpers.tableReader_b0916b98124d4b709f8b609cdd52e42f_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] = new FlatSharp.Compiler.Generated.NCAE7D2E61298C73EB9C86E4A28C7DCE1C1488F40CB9167B4CDECD5E1D1E1EED2.Helpers.tableReader_b0916b98124d4b709f8b609cdd52e42f_Progressive<TInputBuffer>[32];
		}

		private FlatSharp.Compiler.Generated.NCAE7D2E61298C73EB9C86E4A28C7DCE1C1488F40CB9167B4CDECD5E1D1E1EED2.Helpers.tableReader_b0916b98124d4b709f8b609cdd52e42f_Progressive<TInputBuffer> ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			FlatSharp.Compiler.Generated.NCAE7D2E61298C73EB9C86E4A28C7DCE1C1488F40CB9167B4CDECD5E1D1E1EED2.Helpers.tableReader_b0916b98124d4b709f8b609cdd52e42f_Progressive<TInputBuffer>[][] array = items;
			FlatSharp.Compiler.Generated.NCAE7D2E61298C73EB9C86E4A28C7DCE1C1488F40CB9167B4CDECD5E1D1E1EED2.Helpers.tableReader_b0916b98124d4b709f8b609cdd52e42f_Progressive<TInputBuffer>[] orCreateRow = GetOrCreateRow(array, rowIndex);
			FlatSharp.Compiler.Generated.NCAE7D2E61298C73EB9C86E4A28C7DCE1C1488F40CB9167B4CDECD5E1D1E1EED2.Helpers.tableReader_b0916b98124d4b709f8b609cdd52e42f_Progressive<TInputBuffer> tableReader_b0916b98124d4b709f8b609cdd52e42f_Progressive = orCreateRow[colIndex];
			if (tableReader_b0916b98124d4b709f8b609cdd52e42f_Progressive == null)
			{
				tableReader_b0916b98124d4b709f8b609cdd52e42f_Progressive = (orCreateRow[colIndex] = UnsafeParseItem(index));
			}
			return tableReader_b0916b98124d4b709f8b609cdd52e42f_Progressive;
		}

		private void ProgressiveSet(int index, EntityCreate value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, EntityCreate value)
		{
			VectorUtilities.CheckIndex(index, count);
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NCAE7D2E61298C73EB9C86E4A28C7DCE1C1488F40CB9167B4CDECD5E1D1E1EED2.Helpers.tableReader_b0916b98124d4b709f8b609cdd52e42f_Progressive<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NCAE7D2E61298C73EB9C86E4A28C7DCE1C1488F40CB9167B4CDECD5E1D1E1EED2.Helpers.tableReader_b0916b98124d4b709f8b609cdd52e42f_Progressive<TInputBuffer> UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.NCAE7D2E61298C73EB9C86E4A28C7DCE1C1488F40CB9167B4CDECD5E1D1E1EED2.Helpers.Parse_Progressive(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, EntityCreate value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(EntityCreate? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(EntityCreate? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(EntityCreate[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<EntityCreate> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(EntityCreate item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, EntityCreate item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(EntityCreate item)
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

	[DebuggerDisplay("Greedy [ EntityCreate ], Count = {Count}")]
	internal sealed class GeneratedVector_0bcdc0abf878fd1ed7998cf8739be3e4_Greedy<TInputBuffer> : IList<EntityCreate>, ICollection<EntityCreate>, IEnumerable<EntityCreate>, IEnumerable, IReadOnlyList<EntityCreate>, IReadOnlyCollection<EntityCreate> where TInputBuffer : IInputBuffer
	{
		private readonly List<FlatSharp.Compiler.Generated.NCAE7D2E61298C73EB9C86E4A28C7DCE1C1488F40CB9167B4CDECD5E1D1E1EED2.Helpers.tableReader_b0916b98124d4b709f8b609cdd52e42f_Greedy<TInputBuffer>> list;

		public EntityCreate this[int index]
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

		public GeneratedVector_0bcdc0abf878fd1ed7998cf8739be3e4_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<FlatSharp.Compiler.Generated.NCAE7D2E61298C73EB9C86E4A28C7DCE1C1488F40CB9167B4CDECD5E1D1E1EED2.Helpers.tableReader_b0916b98124d4b709f8b609cdd52e42f_Greedy<TInputBuffer>> list = (this.list = new List<FlatSharp.Compiler.Generated.NCAE7D2E61298C73EB9C86E4A28C7DCE1C1488F40CB9167B4CDECD5E1D1E1EED2.Helpers.tableReader_b0916b98124d4b709f8b609cdd52e42f_Greedy<TInputBuffer>>(num));
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.NCAE7D2E61298C73EB9C86E4A28C7DCE1C1488F40CB9167B4CDECD5E1D1E1EED2.Helpers.tableReader_b0916b98124d4b709f8b609cdd52e42f_Greedy<TInputBuffer> item = FlatSharp.Compiler.Generated.NCAE7D2E61298C73EB9C86E4A28C7DCE1C1488F40CB9167B4CDECD5E1D1E1EED2.Helpers.Parse_Greedy(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		private FlatSharp.Compiler.Generated.NCAE7D2E61298C73EB9C86E4A28C7DCE1C1488F40CB9167B4CDECD5E1D1E1EED2.Helpers.tableReader_b0916b98124d4b709f8b609cdd52e42f_Greedy<TInputBuffer> GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, EntityCreate value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(EntityCreate? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(EntityCreate? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(EntityCreate[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<EntityCreate> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(EntityCreate item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, EntityCreate item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(EntityCreate item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ EntityCreate ], Count = {Count}")]
	internal sealed class GeneratedVector_0bcdc0abf878fd1ed7998cf8739be3e4_GreedyMutable<TInputBuffer> : IList<EntityCreate>, ICollection<EntityCreate>, IEnumerable<EntityCreate>, IEnumerable, IReadOnlyList<EntityCreate>, IReadOnlyCollection<EntityCreate> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<EntityCreate> list;

		public EntityCreate this[int index]
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

		public GeneratedVector_0bcdc0abf878fd1ed7998cf8739be3e4_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<EntityCreate> list = (this.list = new List<EntityCreate>());
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.NCAE7D2E61298C73EB9C86E4A28C7DCE1C1488F40CB9167B4CDECD5E1D1E1EED2.Helpers.tableReader_b0916b98124d4b709f8b609cdd52e42f_GreedyMutable<TInputBuffer> item = FlatSharp.Compiler.Generated.NCAE7D2E61298C73EB9C86E4A28C7DCE1C1488F40CB9167B4CDECD5E1D1E1EED2.Helpers.Parse_GreedyMutable(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private EntityCreate GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, EntityCreate value)
		{
			list[index] = value;
		}

		public void Add(EntityCreate item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, EntityCreate item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(EntityCreate item)
		{
			return list.Remove(item);
		}

		public bool Contains(EntityCreate? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(EntityCreate? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(EntityCreate[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<EntityCreate> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<EntityCreate> value)
	{
		int count = value.Count;
		int num = 14;
		if (value is EntityCreate[] array)
		{
			foreach (EntityCreate entityCreate in array)
			{
				SerializationHelpers.EnsureNonNull(entityCreate);
				num += FlatSharp.Compiler.Generated.NCAE7D2E61298C73EB9C86E4A28C7DCE1C1488F40CB9167B4CDECD5E1D1E1EED2.Helpers.GetMaxSize(entityCreate);
			}
		}
		else if (value is List<EntityCreate> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				EntityCreate entityCreate2 = list[j];
				SerializationHelpers.EnsureNonNull(entityCreate2);
				num += FlatSharp.Compiler.Generated.NCAE7D2E61298C73EB9C86E4A28C7DCE1C1488F40CB9167B4CDECD5E1D1E1EED2.Helpers.GetMaxSize(entityCreate2);
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				EntityCreate entityCreate3 = value[k];
				SerializationHelpers.EnsureNonNull(entityCreate3);
				num += FlatSharp.Compiler.Generated.NCAE7D2E61298C73EB9C86E4A28C7DCE1C1488F40CB9167B4CDECD5E1D1E1EED2.Helpers.GetMaxSize(entityCreate3);
			}
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<EntityCreate> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 4);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is EntityCreate[] array)
		{
			foreach (EntityCreate entityCreate in array)
			{
				SerializationHelpers.EnsureNonNull(entityCreate);
				FlatSharp.Compiler.Generated.NCAE7D2E61298C73EB9C86E4A28C7DCE1C1488F40CB9167B4CDECD5E1D1E1EED2.Helpers.Serialize(spanWriter, span, entityCreate, num, context);
				num += 4;
			}
		}
		else if (value is List<EntityCreate> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				EntityCreate entityCreate2 = list[j];
				SerializationHelpers.EnsureNonNull(entityCreate2);
				FlatSharp.Compiler.Generated.NCAE7D2E61298C73EB9C86E4A28C7DCE1C1488F40CB9167B4CDECD5E1D1E1EED2.Helpers.Serialize(spanWriter, span, entityCreate2, num, context);
				num += 4;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				EntityCreate entityCreate3 = value[k];
				SerializationHelpers.EnsureNonNull(entityCreate3);
				FlatSharp.Compiler.Generated.NCAE7D2E61298C73EB9C86E4A28C7DCE1C1488F40CB9167B4CDECD5E1D1E1EED2.Helpers.Serialize(spanWriter, span, entityCreate3, num, context);
				num += 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<EntityCreate> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return new GeneratedVector_0bcdc0abf878fd1ed7998cf8739be3e4_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<EntityCreate> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return new GeneratedVector_0bcdc0abf878fd1ed7998cf8739be3e4_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<EntityCreate> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return new GeneratedVector_0bcdc0abf878fd1ed7998cf8739be3e4_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<EntityCreate> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return new GeneratedVector_0bcdc0abf878fd1ed7998cf8739be3e4_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
