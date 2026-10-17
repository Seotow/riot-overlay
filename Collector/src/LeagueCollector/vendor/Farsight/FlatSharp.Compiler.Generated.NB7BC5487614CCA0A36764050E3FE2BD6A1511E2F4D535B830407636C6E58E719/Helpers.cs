using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Entity;
using FlatSharp.Compiler.Generated.N73F3EBF02B6F009047C37816FA103DC86C2AE74C5E43CCD0ECE2C9CB87D58BD9;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.NB7BC5487614CCA0A36764050E3FE2BD6A1511E2F4D535B830407636C6E58E719;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ ComponentKind ], Count = {Count}")]
	internal sealed class GeneratedVector_10233c6cab99b1d9010966a994b4b119_Lazy<TInputBuffer> : IList<ComponentKind>, ICollection<ComponentKind>, IEnumerable<ComponentKind>, IEnumerable, IReadOnlyList<ComponentKind>, IReadOnlyCollection<ComponentKind>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public ComponentKind this[int index]
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

		int IFlatBufferDeserializedVector.ItemSize => 1;

		int IFlatBufferDeserializedVector.OffsetBase => offset;

		public GeneratedVector_10233c6cab99b1d9010966a994b4b119_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private ComponentKind SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private ComponentKind UnsafeParseItem(int index)
		{
			int num = offset + index;
			return FlatSharp.Compiler.Generated.N73F3EBF02B6F009047C37816FA103DC86C2AE74C5E43CCD0ECE2C9CB87D58BD9.Helpers.Parse(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, ComponentKind value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(ComponentKind item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(ComponentKind item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(ComponentKind[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<ComponentKind> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(ComponentKind item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, ComponentKind item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(ComponentKind item)
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
			return offset + index;
		}
	}

	[DebuggerDisplay("Progressive [ ComponentKind ], Count = {Count}")]
	internal sealed class GeneratedVector_10233c6cab99b1d9010966a994b4b119_Progressive<TInputBuffer> : IList<ComponentKind>, ICollection<ComponentKind>, IEnumerable<ComponentKind>, IEnumerable, IReadOnlyList<ComponentKind>, IReadOnlyCollection<ComponentKind>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly ComponentKind[]?[] items;

		public ComponentKind this[int index]
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

		int IFlatBufferDeserializedVector.ItemSize => 1;

		int IFlatBufferDeserializedVector.OffsetBase => offset;

		public GeneratedVector_10233c6cab99b1d9010966a994b4b119_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new ComponentKind[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private ComponentKind[] GetOrCreateRow(ComponentKind[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private ComponentKind[] CreateRow(ComponentKind[]?[] items, uint rowIndex)
		{
			ComponentKind[] array = (items[rowIndex] = new ComponentKind[32]);
			int num = (int)(rowIndex << 5);
			int num2 = 32;
			int num3 = count - num;
			if (num3 < 32)
			{
				num2 = num3;
			}
			int num4 = offset + num;
			for (int i = 0; i < num2; i++)
			{
				array[i] = UnsafeParseFromOffset(num4);
				num4++;
			}
			return array;
		}

		private ComponentKind ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			ComponentKind[][] array = items;
			return GetOrCreateRow(array, rowIndex)[colIndex];
		}

		private void ProgressiveSet(int index, ComponentKind value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, ComponentKind value)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			GetOrCreateRow(items, rowIndex)[colIndex] = value;
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private ComponentKind UnsafeParseItem(int index)
		{
			int num = offset + index;
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private ComponentKind UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.N73F3EBF02B6F009047C37816FA103DC86C2AE74C5E43CCD0ECE2C9CB87D58BD9.Helpers.Parse(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, ComponentKind value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(ComponentKind item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(ComponentKind item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(ComponentKind[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<ComponentKind> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(ComponentKind item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, ComponentKind item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(ComponentKind item)
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
			return offset + index;
		}
	}

	[DebuggerDisplay("Greedy [ ComponentKind ], Count = {Count}")]
	internal sealed class GeneratedVector_10233c6cab99b1d9010966a994b4b119_Greedy<TInputBuffer> : IList<ComponentKind>, ICollection<ComponentKind>, IEnumerable<ComponentKind>, IEnumerable, IReadOnlyList<ComponentKind>, IReadOnlyCollection<ComponentKind> where TInputBuffer : IInputBuffer
	{
		private readonly List<ComponentKind> list;

		public ComponentKind this[int index]
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

		public GeneratedVector_10233c6cab99b1d9010966a994b4b119_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<ComponentKind> list = (this.list = new List<ComponentKind>(num));
			for (int i = 0; i < num; i++)
			{
				ComponentKind item = FlatSharp.Compiler.Generated.N73F3EBF02B6F009047C37816FA103DC86C2AE74C5E43CCD0ECE2C9CB87D58BD9.Helpers.Parse(buffer, offset, remainingDepth);
				list.Add(item);
				offset++;
			}
		}

		private ComponentKind GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, ComponentKind value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(ComponentKind item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(ComponentKind item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(ComponentKind[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<ComponentKind> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(ComponentKind item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, ComponentKind item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(ComponentKind item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ ComponentKind ], Count = {Count}")]
	internal sealed class GeneratedVector_10233c6cab99b1d9010966a994b4b119_GreedyMutable<TInputBuffer> : IList<ComponentKind>, ICollection<ComponentKind>, IEnumerable<ComponentKind>, IEnumerable, IReadOnlyList<ComponentKind>, IReadOnlyCollection<ComponentKind> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<ComponentKind> list;

		public ComponentKind this[int index]
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

		public GeneratedVector_10233c6cab99b1d9010966a994b4b119_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<ComponentKind> list = (this.list = new List<ComponentKind>());
			for (int i = 0; i < num; i++)
			{
				ComponentKind item = FlatSharp.Compiler.Generated.N73F3EBF02B6F009047C37816FA103DC86C2AE74C5E43CCD0ECE2C9CB87D58BD9.Helpers.Parse(buffer, offset, remainingDepth);
				list.Add(item);
				offset++;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private ComponentKind GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, ComponentKind value)
		{
			list[index] = value;
		}

		public void Add(ComponentKind item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, ComponentKind item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(ComponentKind item)
		{
			return list.Remove(item);
		}

		public bool Contains(ComponentKind item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(ComponentKind item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(ComponentKind[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<ComponentKind> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<ComponentKind> value)
	{
		return 7 + value.Count;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<ComponentKind> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(1, count, 1);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is ComponentKind[] array)
		{
			foreach (ComponentKind value2 in array)
			{
				FlatSharp.Compiler.Generated.N73F3EBF02B6F009047C37816FA103DC86C2AE74C5E43CCD0ECE2C9CB87D58BD9.Helpers.Serialize(spanWriter, span, value2, num);
				num++;
			}
		}
		else if (value is List<ComponentKind> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				ComponentKind value3 = list[j];
				FlatSharp.Compiler.Generated.N73F3EBF02B6F009047C37816FA103DC86C2AE74C5E43CCD0ECE2C9CB87D58BD9.Helpers.Serialize(spanWriter, span, value3, num);
				num++;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				ComponentKind value4 = value[k];
				FlatSharp.Compiler.Generated.N73F3EBF02B6F009047C37816FA103DC86C2AE74C5E43CCD0ECE2C9CB87D58BD9.Helpers.Serialize(spanWriter, span, value4, num);
				num++;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<ComponentKind> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_10233c6cab99b1d9010966a994b4b119_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<ComponentKind> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_10233c6cab99b1d9010966a994b4b119_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<ComponentKind> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_10233c6cab99b1d9010966a994b4b119_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<ComponentKind> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_10233c6cab99b1d9010966a994b4b119_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
