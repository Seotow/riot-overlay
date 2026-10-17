using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Cinematics;
using FlatSharp.Compiler.Generated.NC4F249BA6A15887322A63793EF41E20A9C30529B83B1963F79FB2EF873740884;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N7937E19385170D742973882D1D7193D542C82356CABFA360B89633D62CC823EB;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ CinematicKeyframe ], Count = {Count}")]
	internal sealed class GeneratedVector_524a9fca6f954c0893ef6c368def5bbf_Lazy<TInputBuffer> : IList<CinematicKeyframe>, ICollection<CinematicKeyframe>, IEnumerable<CinematicKeyframe>, IEnumerable, IReadOnlyList<CinematicKeyframe>, IReadOnlyCollection<CinematicKeyframe>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public CinematicKeyframe this[int index]
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

		public GeneratedVector_524a9fca6f954c0893ef6c368def5bbf_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NC4F249BA6A15887322A63793EF41E20A9C30529B83B1963F79FB2EF873740884.Helpers.tableReader_f95a5eb1df8c4edf9c40e4cb3b5d455b_Lazy<TInputBuffer> SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NC4F249BA6A15887322A63793EF41E20A9C30529B83B1963F79FB2EF873740884.Helpers.tableReader_f95a5eb1df8c4edf9c40e4cb3b5d455b_Lazy<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return FlatSharp.Compiler.Generated.NC4F249BA6A15887322A63793EF41E20A9C30529B83B1963F79FB2EF873740884.Helpers.Parse_Lazy(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, CinematicKeyframe value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(CinematicKeyframe? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(CinematicKeyframe? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(CinematicKeyframe[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<CinematicKeyframe> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(CinematicKeyframe item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, CinematicKeyframe item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(CinematicKeyframe item)
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

	[DebuggerDisplay("Progressive [ CinematicKeyframe ], Count = {Count}")]
	internal sealed class GeneratedVector_524a9fca6f954c0893ef6c368def5bbf_Progressive<TInputBuffer> : IList<CinematicKeyframe>, ICollection<CinematicKeyframe>, IEnumerable<CinematicKeyframe>, IEnumerable, IReadOnlyList<CinematicKeyframe>, IReadOnlyCollection<CinematicKeyframe>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly FlatSharp.Compiler.Generated.NC4F249BA6A15887322A63793EF41E20A9C30529B83B1963F79FB2EF873740884.Helpers.tableReader_f95a5eb1df8c4edf9c40e4cb3b5d455b_Progressive<TInputBuffer>?[]?[] items;

		public CinematicKeyframe this[int index]
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

		public GeneratedVector_524a9fca6f954c0893ef6c368def5bbf_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new FlatSharp.Compiler.Generated.NC4F249BA6A15887322A63793EF41E20A9C30529B83B1963F79FB2EF873740884.Helpers.tableReader_f95a5eb1df8c4edf9c40e4cb3b5d455b_Progressive<TInputBuffer>[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NC4F249BA6A15887322A63793EF41E20A9C30529B83B1963F79FB2EF873740884.Helpers.tableReader_f95a5eb1df8c4edf9c40e4cb3b5d455b_Progressive<TInputBuffer>?[] GetOrCreateRow(FlatSharp.Compiler.Generated.NC4F249BA6A15887322A63793EF41E20A9C30529B83B1963F79FB2EF873740884.Helpers.tableReader_f95a5eb1df8c4edf9c40e4cb3b5d455b_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private FlatSharp.Compiler.Generated.NC4F249BA6A15887322A63793EF41E20A9C30529B83B1963F79FB2EF873740884.Helpers.tableReader_f95a5eb1df8c4edf9c40e4cb3b5d455b_Progressive<TInputBuffer>?[] CreateRow(FlatSharp.Compiler.Generated.NC4F249BA6A15887322A63793EF41E20A9C30529B83B1963F79FB2EF873740884.Helpers.tableReader_f95a5eb1df8c4edf9c40e4cb3b5d455b_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] = new FlatSharp.Compiler.Generated.NC4F249BA6A15887322A63793EF41E20A9C30529B83B1963F79FB2EF873740884.Helpers.tableReader_f95a5eb1df8c4edf9c40e4cb3b5d455b_Progressive<TInputBuffer>[32];
		}

		private FlatSharp.Compiler.Generated.NC4F249BA6A15887322A63793EF41E20A9C30529B83B1963F79FB2EF873740884.Helpers.tableReader_f95a5eb1df8c4edf9c40e4cb3b5d455b_Progressive<TInputBuffer> ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			FlatSharp.Compiler.Generated.NC4F249BA6A15887322A63793EF41E20A9C30529B83B1963F79FB2EF873740884.Helpers.tableReader_f95a5eb1df8c4edf9c40e4cb3b5d455b_Progressive<TInputBuffer>[][] array = items;
			FlatSharp.Compiler.Generated.NC4F249BA6A15887322A63793EF41E20A9C30529B83B1963F79FB2EF873740884.Helpers.tableReader_f95a5eb1df8c4edf9c40e4cb3b5d455b_Progressive<TInputBuffer>[] orCreateRow = GetOrCreateRow(array, rowIndex);
			FlatSharp.Compiler.Generated.NC4F249BA6A15887322A63793EF41E20A9C30529B83B1963F79FB2EF873740884.Helpers.tableReader_f95a5eb1df8c4edf9c40e4cb3b5d455b_Progressive<TInputBuffer> tableReader_f95a5eb1df8c4edf9c40e4cb3b5d455b_Progressive = orCreateRow[colIndex];
			if (tableReader_f95a5eb1df8c4edf9c40e4cb3b5d455b_Progressive == null)
			{
				tableReader_f95a5eb1df8c4edf9c40e4cb3b5d455b_Progressive = (orCreateRow[colIndex] = UnsafeParseItem(index));
			}
			return tableReader_f95a5eb1df8c4edf9c40e4cb3b5d455b_Progressive;
		}

		private void ProgressiveSet(int index, CinematicKeyframe value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, CinematicKeyframe value)
		{
			VectorUtilities.CheckIndex(index, count);
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NC4F249BA6A15887322A63793EF41E20A9C30529B83B1963F79FB2EF873740884.Helpers.tableReader_f95a5eb1df8c4edf9c40e4cb3b5d455b_Progressive<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NC4F249BA6A15887322A63793EF41E20A9C30529B83B1963F79FB2EF873740884.Helpers.tableReader_f95a5eb1df8c4edf9c40e4cb3b5d455b_Progressive<TInputBuffer> UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.NC4F249BA6A15887322A63793EF41E20A9C30529B83B1963F79FB2EF873740884.Helpers.Parse_Progressive(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, CinematicKeyframe value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(CinematicKeyframe? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(CinematicKeyframe? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(CinematicKeyframe[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<CinematicKeyframe> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(CinematicKeyframe item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, CinematicKeyframe item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(CinematicKeyframe item)
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

	[DebuggerDisplay("Greedy [ CinematicKeyframe ], Count = {Count}")]
	internal sealed class GeneratedVector_524a9fca6f954c0893ef6c368def5bbf_Greedy<TInputBuffer> : IList<CinematicKeyframe>, ICollection<CinematicKeyframe>, IEnumerable<CinematicKeyframe>, IEnumerable, IReadOnlyList<CinematicKeyframe>, IReadOnlyCollection<CinematicKeyframe> where TInputBuffer : IInputBuffer
	{
		private readonly List<FlatSharp.Compiler.Generated.NC4F249BA6A15887322A63793EF41E20A9C30529B83B1963F79FB2EF873740884.Helpers.tableReader_f95a5eb1df8c4edf9c40e4cb3b5d455b_Greedy<TInputBuffer>> list;

		public CinematicKeyframe this[int index]
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

		public GeneratedVector_524a9fca6f954c0893ef6c368def5bbf_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<FlatSharp.Compiler.Generated.NC4F249BA6A15887322A63793EF41E20A9C30529B83B1963F79FB2EF873740884.Helpers.tableReader_f95a5eb1df8c4edf9c40e4cb3b5d455b_Greedy<TInputBuffer>> list = (this.list = new List<FlatSharp.Compiler.Generated.NC4F249BA6A15887322A63793EF41E20A9C30529B83B1963F79FB2EF873740884.Helpers.tableReader_f95a5eb1df8c4edf9c40e4cb3b5d455b_Greedy<TInputBuffer>>(num));
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.NC4F249BA6A15887322A63793EF41E20A9C30529B83B1963F79FB2EF873740884.Helpers.tableReader_f95a5eb1df8c4edf9c40e4cb3b5d455b_Greedy<TInputBuffer> item = FlatSharp.Compiler.Generated.NC4F249BA6A15887322A63793EF41E20A9C30529B83B1963F79FB2EF873740884.Helpers.Parse_Greedy(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		private FlatSharp.Compiler.Generated.NC4F249BA6A15887322A63793EF41E20A9C30529B83B1963F79FB2EF873740884.Helpers.tableReader_f95a5eb1df8c4edf9c40e4cb3b5d455b_Greedy<TInputBuffer> GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, CinematicKeyframe value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(CinematicKeyframe? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(CinematicKeyframe? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(CinematicKeyframe[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<CinematicKeyframe> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(CinematicKeyframe item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, CinematicKeyframe item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(CinematicKeyframe item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ CinematicKeyframe ], Count = {Count}")]
	internal sealed class GeneratedVector_524a9fca6f954c0893ef6c368def5bbf_GreedyMutable<TInputBuffer> : IList<CinematicKeyframe>, ICollection<CinematicKeyframe>, IEnumerable<CinematicKeyframe>, IEnumerable, IReadOnlyList<CinematicKeyframe>, IReadOnlyCollection<CinematicKeyframe> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<CinematicKeyframe> list;

		public CinematicKeyframe this[int index]
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

		public GeneratedVector_524a9fca6f954c0893ef6c368def5bbf_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<CinematicKeyframe> list = (this.list = new List<CinematicKeyframe>());
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.NC4F249BA6A15887322A63793EF41E20A9C30529B83B1963F79FB2EF873740884.Helpers.tableReader_f95a5eb1df8c4edf9c40e4cb3b5d455b_GreedyMutable<TInputBuffer> item = FlatSharp.Compiler.Generated.NC4F249BA6A15887322A63793EF41E20A9C30529B83B1963F79FB2EF873740884.Helpers.Parse_GreedyMutable(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private CinematicKeyframe GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, CinematicKeyframe value)
		{
			list[index] = value;
		}

		public void Add(CinematicKeyframe item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, CinematicKeyframe item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(CinematicKeyframe item)
		{
			return list.Remove(item);
		}

		public bool Contains(CinematicKeyframe? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(CinematicKeyframe? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(CinematicKeyframe[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<CinematicKeyframe> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<CinematicKeyframe> value)
	{
		int count = value.Count;
		int num = 14;
		if (value is CinematicKeyframe[] array)
		{
			foreach (CinematicKeyframe cinematicKeyframe in array)
			{
				SerializationHelpers.EnsureNonNull(cinematicKeyframe);
				num += FlatSharp.Compiler.Generated.NC4F249BA6A15887322A63793EF41E20A9C30529B83B1963F79FB2EF873740884.Helpers.GetMaxSize(cinematicKeyframe);
			}
		}
		else if (value is List<CinematicKeyframe> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				CinematicKeyframe cinematicKeyframe2 = list[j];
				SerializationHelpers.EnsureNonNull(cinematicKeyframe2);
				num += FlatSharp.Compiler.Generated.NC4F249BA6A15887322A63793EF41E20A9C30529B83B1963F79FB2EF873740884.Helpers.GetMaxSize(cinematicKeyframe2);
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				CinematicKeyframe cinematicKeyframe3 = value[k];
				SerializationHelpers.EnsureNonNull(cinematicKeyframe3);
				num += FlatSharp.Compiler.Generated.NC4F249BA6A15887322A63793EF41E20A9C30529B83B1963F79FB2EF873740884.Helpers.GetMaxSize(cinematicKeyframe3);
			}
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<CinematicKeyframe> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 4);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is CinematicKeyframe[] array)
		{
			foreach (CinematicKeyframe cinematicKeyframe in array)
			{
				SerializationHelpers.EnsureNonNull(cinematicKeyframe);
				FlatSharp.Compiler.Generated.NC4F249BA6A15887322A63793EF41E20A9C30529B83B1963F79FB2EF873740884.Helpers.Serialize(spanWriter, span, cinematicKeyframe, num, context);
				num += 4;
			}
		}
		else if (value is List<CinematicKeyframe> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				CinematicKeyframe cinematicKeyframe2 = list[j];
				SerializationHelpers.EnsureNonNull(cinematicKeyframe2);
				FlatSharp.Compiler.Generated.NC4F249BA6A15887322A63793EF41E20A9C30529B83B1963F79FB2EF873740884.Helpers.Serialize(spanWriter, span, cinematicKeyframe2, num, context);
				num += 4;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				CinematicKeyframe cinematicKeyframe3 = value[k];
				SerializationHelpers.EnsureNonNull(cinematicKeyframe3);
				FlatSharp.Compiler.Generated.NC4F249BA6A15887322A63793EF41E20A9C30529B83B1963F79FB2EF873740884.Helpers.Serialize(spanWriter, span, cinematicKeyframe3, num, context);
				num += 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<CinematicKeyframe> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_524a9fca6f954c0893ef6c368def5bbf_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<CinematicKeyframe> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_524a9fca6f954c0893ef6c368def5bbf_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<CinematicKeyframe> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_524a9fca6f954c0893ef6c368def5bbf_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<CinematicKeyframe> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return new GeneratedVector_524a9fca6f954c0893ef6c368def5bbf_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
