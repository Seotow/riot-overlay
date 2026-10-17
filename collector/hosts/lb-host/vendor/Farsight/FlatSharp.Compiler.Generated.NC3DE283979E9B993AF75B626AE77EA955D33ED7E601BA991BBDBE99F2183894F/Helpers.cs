using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Snapshot;
using FlatSharp.Compiler.Generated.N98FB11DD8A6AF5B866EC08FC5618D288E4755CE1266CB1F62E3FD4AFE2ECEC32;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.NC3DE283979E9B993AF75B626AE77EA955D33ED7E601BA991BBDBE99F2183894F;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ Bone ], Count = {Count}")]
	internal sealed class GeneratedVector_759dc3786a6adede8ef158d92332c884_Lazy<TInputBuffer> : IList<Bone>, ICollection<Bone>, IEnumerable<Bone>, IEnumerable, IReadOnlyList<Bone>, IReadOnlyCollection<Bone>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public Bone this[int index]
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

		public GeneratedVector_759dc3786a6adede8ef158d92332c884_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N98FB11DD8A6AF5B866EC08FC5618D288E4755CE1266CB1F62E3FD4AFE2ECEC32.Helpers.tableReader_c6e994dd62404dc68c7d327334ef3b4b_Lazy<TInputBuffer> SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N98FB11DD8A6AF5B866EC08FC5618D288E4755CE1266CB1F62E3FD4AFE2ECEC32.Helpers.tableReader_c6e994dd62404dc68c7d327334ef3b4b_Lazy<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return FlatSharp.Compiler.Generated.N98FB11DD8A6AF5B866EC08FC5618D288E4755CE1266CB1F62E3FD4AFE2ECEC32.Helpers.Parse_Lazy(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, Bone value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(Bone? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(Bone? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(Bone[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<Bone> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(Bone item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, Bone item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(Bone item)
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

	[DebuggerDisplay("Progressive [ Bone ], Count = {Count}")]
	internal sealed class GeneratedVector_759dc3786a6adede8ef158d92332c884_Progressive<TInputBuffer> : IList<Bone>, ICollection<Bone>, IEnumerable<Bone>, IEnumerable, IReadOnlyList<Bone>, IReadOnlyCollection<Bone>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly FlatSharp.Compiler.Generated.N98FB11DD8A6AF5B866EC08FC5618D288E4755CE1266CB1F62E3FD4AFE2ECEC32.Helpers.tableReader_c6e994dd62404dc68c7d327334ef3b4b_Progressive<TInputBuffer>?[]?[] items;

		public Bone this[int index]
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

		public GeneratedVector_759dc3786a6adede8ef158d92332c884_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new FlatSharp.Compiler.Generated.N98FB11DD8A6AF5B866EC08FC5618D288E4755CE1266CB1F62E3FD4AFE2ECEC32.Helpers.tableReader_c6e994dd62404dc68c7d327334ef3b4b_Progressive<TInputBuffer>[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N98FB11DD8A6AF5B866EC08FC5618D288E4755CE1266CB1F62E3FD4AFE2ECEC32.Helpers.tableReader_c6e994dd62404dc68c7d327334ef3b4b_Progressive<TInputBuffer>?[] GetOrCreateRow(FlatSharp.Compiler.Generated.N98FB11DD8A6AF5B866EC08FC5618D288E4755CE1266CB1F62E3FD4AFE2ECEC32.Helpers.tableReader_c6e994dd62404dc68c7d327334ef3b4b_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private FlatSharp.Compiler.Generated.N98FB11DD8A6AF5B866EC08FC5618D288E4755CE1266CB1F62E3FD4AFE2ECEC32.Helpers.tableReader_c6e994dd62404dc68c7d327334ef3b4b_Progressive<TInputBuffer>?[] CreateRow(FlatSharp.Compiler.Generated.N98FB11DD8A6AF5B866EC08FC5618D288E4755CE1266CB1F62E3FD4AFE2ECEC32.Helpers.tableReader_c6e994dd62404dc68c7d327334ef3b4b_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] = new FlatSharp.Compiler.Generated.N98FB11DD8A6AF5B866EC08FC5618D288E4755CE1266CB1F62E3FD4AFE2ECEC32.Helpers.tableReader_c6e994dd62404dc68c7d327334ef3b4b_Progressive<TInputBuffer>[32];
		}

		private FlatSharp.Compiler.Generated.N98FB11DD8A6AF5B866EC08FC5618D288E4755CE1266CB1F62E3FD4AFE2ECEC32.Helpers.tableReader_c6e994dd62404dc68c7d327334ef3b4b_Progressive<TInputBuffer> ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			FlatSharp.Compiler.Generated.N98FB11DD8A6AF5B866EC08FC5618D288E4755CE1266CB1F62E3FD4AFE2ECEC32.Helpers.tableReader_c6e994dd62404dc68c7d327334ef3b4b_Progressive<TInputBuffer>[][] array = items;
			FlatSharp.Compiler.Generated.N98FB11DD8A6AF5B866EC08FC5618D288E4755CE1266CB1F62E3FD4AFE2ECEC32.Helpers.tableReader_c6e994dd62404dc68c7d327334ef3b4b_Progressive<TInputBuffer>[] orCreateRow = GetOrCreateRow(array, rowIndex);
			FlatSharp.Compiler.Generated.N98FB11DD8A6AF5B866EC08FC5618D288E4755CE1266CB1F62E3FD4AFE2ECEC32.Helpers.tableReader_c6e994dd62404dc68c7d327334ef3b4b_Progressive<TInputBuffer> tableReader_c6e994dd62404dc68c7d327334ef3b4b_Progressive = orCreateRow[colIndex];
			if (tableReader_c6e994dd62404dc68c7d327334ef3b4b_Progressive == null)
			{
				tableReader_c6e994dd62404dc68c7d327334ef3b4b_Progressive = (orCreateRow[colIndex] = UnsafeParseItem(index));
			}
			return tableReader_c6e994dd62404dc68c7d327334ef3b4b_Progressive;
		}

		private void ProgressiveSet(int index, Bone value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, Bone value)
		{
			VectorUtilities.CheckIndex(index, count);
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N98FB11DD8A6AF5B866EC08FC5618D288E4755CE1266CB1F62E3FD4AFE2ECEC32.Helpers.tableReader_c6e994dd62404dc68c7d327334ef3b4b_Progressive<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.N98FB11DD8A6AF5B866EC08FC5618D288E4755CE1266CB1F62E3FD4AFE2ECEC32.Helpers.tableReader_c6e994dd62404dc68c7d327334ef3b4b_Progressive<TInputBuffer> UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.N98FB11DD8A6AF5B866EC08FC5618D288E4755CE1266CB1F62E3FD4AFE2ECEC32.Helpers.Parse_Progressive(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, Bone value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(Bone? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(Bone? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(Bone[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<Bone> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(Bone item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, Bone item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(Bone item)
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

	[DebuggerDisplay("Greedy [ Bone ], Count = {Count}")]
	internal sealed class GeneratedVector_759dc3786a6adede8ef158d92332c884_Greedy<TInputBuffer> : IList<Bone>, ICollection<Bone>, IEnumerable<Bone>, IEnumerable, IReadOnlyList<Bone>, IReadOnlyCollection<Bone> where TInputBuffer : IInputBuffer
	{
		private readonly List<FlatSharp.Compiler.Generated.N98FB11DD8A6AF5B866EC08FC5618D288E4755CE1266CB1F62E3FD4AFE2ECEC32.Helpers.tableReader_c6e994dd62404dc68c7d327334ef3b4b_Greedy<TInputBuffer>> list;

		public Bone this[int index]
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

		public GeneratedVector_759dc3786a6adede8ef158d92332c884_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<FlatSharp.Compiler.Generated.N98FB11DD8A6AF5B866EC08FC5618D288E4755CE1266CB1F62E3FD4AFE2ECEC32.Helpers.tableReader_c6e994dd62404dc68c7d327334ef3b4b_Greedy<TInputBuffer>> list = (this.list = new List<FlatSharp.Compiler.Generated.N98FB11DD8A6AF5B866EC08FC5618D288E4755CE1266CB1F62E3FD4AFE2ECEC32.Helpers.tableReader_c6e994dd62404dc68c7d327334ef3b4b_Greedy<TInputBuffer>>(num));
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.N98FB11DD8A6AF5B866EC08FC5618D288E4755CE1266CB1F62E3FD4AFE2ECEC32.Helpers.tableReader_c6e994dd62404dc68c7d327334ef3b4b_Greedy<TInputBuffer> item = FlatSharp.Compiler.Generated.N98FB11DD8A6AF5B866EC08FC5618D288E4755CE1266CB1F62E3FD4AFE2ECEC32.Helpers.Parse_Greedy(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		private FlatSharp.Compiler.Generated.N98FB11DD8A6AF5B866EC08FC5618D288E4755CE1266CB1F62E3FD4AFE2ECEC32.Helpers.tableReader_c6e994dd62404dc68c7d327334ef3b4b_Greedy<TInputBuffer> GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, Bone value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(Bone? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(Bone? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(Bone[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<Bone> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(Bone item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, Bone item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(Bone item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ Bone ], Count = {Count}")]
	internal sealed class GeneratedVector_759dc3786a6adede8ef158d92332c884_GreedyMutable<TInputBuffer> : IList<Bone>, ICollection<Bone>, IEnumerable<Bone>, IEnumerable, IReadOnlyList<Bone>, IReadOnlyCollection<Bone> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<Bone> list;

		public Bone this[int index]
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

		public GeneratedVector_759dc3786a6adede8ef158d92332c884_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<Bone> list = (this.list = new List<Bone>());
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.N98FB11DD8A6AF5B866EC08FC5618D288E4755CE1266CB1F62E3FD4AFE2ECEC32.Helpers.tableReader_c6e994dd62404dc68c7d327334ef3b4b_GreedyMutable<TInputBuffer> item = FlatSharp.Compiler.Generated.N98FB11DD8A6AF5B866EC08FC5618D288E4755CE1266CB1F62E3FD4AFE2ECEC32.Helpers.Parse_GreedyMutable(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private Bone GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, Bone value)
		{
			list[index] = value;
		}

		public void Add(Bone item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, Bone item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(Bone item)
		{
			return list.Remove(item);
		}

		public bool Contains(Bone? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(Bone? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(Bone[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<Bone> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<Bone> value)
	{
		int count = value.Count;
		int num = 14;
		if (value is Bone[] array)
		{
			foreach (Bone bone in array)
			{
				SerializationHelpers.EnsureNonNull(bone);
				num += FlatSharp.Compiler.Generated.N98FB11DD8A6AF5B866EC08FC5618D288E4755CE1266CB1F62E3FD4AFE2ECEC32.Helpers.GetMaxSize(bone);
			}
		}
		else if (value is List<Bone> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				Bone bone2 = list[j];
				SerializationHelpers.EnsureNonNull(bone2);
				num += FlatSharp.Compiler.Generated.N98FB11DD8A6AF5B866EC08FC5618D288E4755CE1266CB1F62E3FD4AFE2ECEC32.Helpers.GetMaxSize(bone2);
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				Bone bone3 = value[k];
				SerializationHelpers.EnsureNonNull(bone3);
				num += FlatSharp.Compiler.Generated.N98FB11DD8A6AF5B866EC08FC5618D288E4755CE1266CB1F62E3FD4AFE2ECEC32.Helpers.GetMaxSize(bone3);
			}
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<Bone> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 4);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is Bone[] array)
		{
			foreach (Bone bone in array)
			{
				SerializationHelpers.EnsureNonNull(bone);
				FlatSharp.Compiler.Generated.N98FB11DD8A6AF5B866EC08FC5618D288E4755CE1266CB1F62E3FD4AFE2ECEC32.Helpers.Serialize(spanWriter, span, bone, num, context);
				num += 4;
			}
		}
		else if (value is List<Bone> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				Bone bone2 = list[j];
				SerializationHelpers.EnsureNonNull(bone2);
				FlatSharp.Compiler.Generated.N98FB11DD8A6AF5B866EC08FC5618D288E4755CE1266CB1F62E3FD4AFE2ECEC32.Helpers.Serialize(spanWriter, span, bone2, num, context);
				num += 4;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				Bone bone3 = value[k];
				SerializationHelpers.EnsureNonNull(bone3);
				FlatSharp.Compiler.Generated.N98FB11DD8A6AF5B866EC08FC5618D288E4755CE1266CB1F62E3FD4AFE2ECEC32.Helpers.Serialize(spanWriter, span, bone3, num, context);
				num += 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<Bone> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_759dc3786a6adede8ef158d92332c884_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<Bone> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_759dc3786a6adede8ef158d92332c884_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<Bone> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_759dc3786a6adede8ef158d92332c884_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<Bone> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_759dc3786a6adede8ef158d92332c884_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
