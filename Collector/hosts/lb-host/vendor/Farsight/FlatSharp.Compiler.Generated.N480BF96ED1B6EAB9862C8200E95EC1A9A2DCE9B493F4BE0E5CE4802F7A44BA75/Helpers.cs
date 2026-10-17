using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Common;
using FlatSharp.Compiler.Generated.NFF70312A85F3FF4CF405F39CEE8F59B3D4ABEE9FB59DF8413E03A4DAB0607BEA;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N480BF96ED1B6EAB9862C8200E95EC1A9A2DCE9B493F4BE0E5CE4802F7A44BA75;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ Vector3 ], Count = {Count}")]
	internal sealed class GeneratedVector_3315e441106dad3af61da3e6170e5cf7_Lazy<TInputBuffer> : IList<Vector3>, ICollection<Vector3>, IEnumerable<Vector3>, IEnumerable, IReadOnlyList<Vector3>, IReadOnlyCollection<Vector3>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public Vector3 this[int index]
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

		int IFlatBufferDeserializedVector.ItemSize => 12;

		int IFlatBufferDeserializedVector.OffsetBase => offset;

		public GeneratedVector_3315e441106dad3af61da3e6170e5cf7_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private Vector3 SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private Vector3 UnsafeParseItem(int index)
		{
			int num = offset + 12 * index;
			return FlatSharp.Compiler.Generated.NFF70312A85F3FF4CF405F39CEE8F59B3D4ABEE9FB59DF8413E03A4DAB0607BEA.Helpers.Parse(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, Vector3 value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(Vector3 item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(Vector3 item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(Vector3[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<Vector3> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(Vector3 item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, Vector3 item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(Vector3 item)
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
			return offset + 12 * index;
		}
	}

	[DebuggerDisplay("Progressive [ Vector3 ], Count = {Count}")]
	internal sealed class GeneratedVector_3315e441106dad3af61da3e6170e5cf7_Progressive<TInputBuffer> : IList<Vector3>, ICollection<Vector3>, IEnumerable<Vector3>, IEnumerable, IReadOnlyList<Vector3>, IReadOnlyCollection<Vector3>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly Vector3[]?[] items;

		public Vector3 this[int index]
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

		int IFlatBufferDeserializedVector.ItemSize => 12;

		int IFlatBufferDeserializedVector.OffsetBase => offset;

		public GeneratedVector_3315e441106dad3af61da3e6170e5cf7_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new Vector3[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private Vector3[] GetOrCreateRow(Vector3[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private Vector3[] CreateRow(Vector3[]?[] items, uint rowIndex)
		{
			Vector3[] array = (items[rowIndex] = new Vector3[32]);
			int num = (int)(rowIndex << 5);
			int num2 = 32;
			int num3 = count - num;
			if (num3 < 32)
			{
				num2 = num3;
			}
			int num4 = offset + 12 * num;
			for (int i = 0; i < num2; i++)
			{
				array[i] = UnsafeParseFromOffset(num4);
				num4 += 12;
			}
			return array;
		}

		private Vector3 ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			Vector3[][] array = items;
			return GetOrCreateRow(array, rowIndex)[colIndex];
		}

		private void ProgressiveSet(int index, Vector3 value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, Vector3 value)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			GetOrCreateRow(items, rowIndex)[colIndex] = value;
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private Vector3 UnsafeParseItem(int index)
		{
			int num = offset + 12 * index;
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private Vector3 UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.NFF70312A85F3FF4CF405F39CEE8F59B3D4ABEE9FB59DF8413E03A4DAB0607BEA.Helpers.Parse(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, Vector3 value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(Vector3 item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(Vector3 item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(Vector3[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<Vector3> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(Vector3 item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, Vector3 item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(Vector3 item)
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
			return offset + 12 * index;
		}
	}

	[DebuggerDisplay("Greedy [ Vector3 ], Count = {Count}")]
	internal sealed class GeneratedVector_3315e441106dad3af61da3e6170e5cf7_Greedy<TInputBuffer> : IList<Vector3>, ICollection<Vector3>, IEnumerable<Vector3>, IEnumerable, IReadOnlyList<Vector3>, IReadOnlyCollection<Vector3> where TInputBuffer : IInputBuffer
	{
		private readonly List<Vector3> list;

		public Vector3 this[int index]
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

		public GeneratedVector_3315e441106dad3af61da3e6170e5cf7_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<Vector3> list = (this.list = new List<Vector3>(num));
			for (int i = 0; i < num; i++)
			{
				Vector3 item = FlatSharp.Compiler.Generated.NFF70312A85F3FF4CF405F39CEE8F59B3D4ABEE9FB59DF8413E03A4DAB0607BEA.Helpers.Parse(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 12;
			}
		}

		private Vector3 GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, Vector3 value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(Vector3 item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(Vector3 item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(Vector3[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<Vector3> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(Vector3 item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, Vector3 item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(Vector3 item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ Vector3 ], Count = {Count}")]
	internal sealed class GeneratedVector_3315e441106dad3af61da3e6170e5cf7_GreedyMutable<TInputBuffer> : IList<Vector3>, ICollection<Vector3>, IEnumerable<Vector3>, IEnumerable, IReadOnlyList<Vector3>, IReadOnlyCollection<Vector3> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<Vector3> list;

		public Vector3 this[int index]
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

		public GeneratedVector_3315e441106dad3af61da3e6170e5cf7_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<Vector3> list = (this.list = new List<Vector3>());
			for (int i = 0; i < num; i++)
			{
				Vector3 item = FlatSharp.Compiler.Generated.NFF70312A85F3FF4CF405F39CEE8F59B3D4ABEE9FB59DF8413E03A4DAB0607BEA.Helpers.Parse(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 12;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private Vector3 GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, Vector3 value)
		{
			list[index] = value;
		}

		public void Add(Vector3 item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, Vector3 item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(Vector3 item)
		{
			return list.Remove(item);
		}

		public bool Contains(Vector3 item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(Vector3 item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(Vector3[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<Vector3> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<Vector3> value)
	{
		return 10 + 12 * value.Count;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<Vector3> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 12);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is Vector3[] array)
		{
			foreach (Vector3 value2 in array)
			{
				FlatSharp.Compiler.Generated.NFF70312A85F3FF4CF405F39CEE8F59B3D4ABEE9FB59DF8413E03A4DAB0607BEA.Helpers.Serialize(spanWriter, span, value2, num);
				num += 12;
			}
		}
		else if (value is List<Vector3> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				Vector3 value3 = list[j];
				FlatSharp.Compiler.Generated.NFF70312A85F3FF4CF405F39CEE8F59B3D4ABEE9FB59DF8413E03A4DAB0607BEA.Helpers.Serialize(spanWriter, span, value3, num);
				num += 12;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				Vector3 value4 = value[k];
				FlatSharp.Compiler.Generated.NFF70312A85F3FF4CF405F39CEE8F59B3D4ABEE9FB59DF8413E03A4DAB0607BEA.Helpers.Serialize(spanWriter, span, value4, num);
				num += 12;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<Vector3> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_3315e441106dad3af61da3e6170e5cf7_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<Vector3> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_3315e441106dad3af61da3e6170e5cf7_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<Vector3> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_3315e441106dad3af61da3e6170e5cf7_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<Vector3> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_3315e441106dad3af61da3e6170e5cf7_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
