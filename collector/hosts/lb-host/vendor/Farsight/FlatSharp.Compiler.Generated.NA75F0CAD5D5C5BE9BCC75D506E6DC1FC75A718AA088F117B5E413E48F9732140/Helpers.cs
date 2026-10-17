using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Scene;
using FlatSharp.Compiler.Generated.NC9780113534523AD662A33FF68B919970EF7075D2D9C890E6E92E0B42D1D6857;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.NA75F0CAD5D5C5BE9BCC75D506E6DC1FC75A718AA088F117B5E413E48F9732140;

internal static class Helpers
{
	[DebuggerDisplay("Lazy [ ScriptAssetSnapshot ], Count = {Count}")]
	internal sealed class GeneratedVector_c049ee888c2d768b3d28966bf59c63e5_Lazy<TInputBuffer> : IList<ScriptAssetSnapshot>, ICollection<ScriptAssetSnapshot>, IEnumerable<ScriptAssetSnapshot>, IEnumerable, IReadOnlyList<ScriptAssetSnapshot>, IReadOnlyCollection<ScriptAssetSnapshot>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		public ScriptAssetSnapshot this[int index]
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

		public GeneratedVector_c049ee888c2d768b3d28966bf59c63e5_Lazy(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			count = (int)memory.ReadUInt(offset);
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NC9780113534523AD662A33FF68B919970EF7075D2D9C890E6E92E0B42D1D6857.Helpers.tableReader_075f1eacc2894c709702ac47dd50c198_Lazy<TInputBuffer> SafeParseItem(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			return UnsafeParseItem(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NC9780113534523AD662A33FF68B919970EF7075D2D9C890E6E92E0B42D1D6857.Helpers.tableReader_075f1eacc2894c709702ac47dd50c198_Lazy<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return FlatSharp.Compiler.Generated.NC9780113534523AD662A33FF68B919970EF7075D2D9C890E6E92E0B42D1D6857.Helpers.Parse_Lazy(buffer, num, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, ScriptAssetSnapshot value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(ScriptAssetSnapshot? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(ScriptAssetSnapshot? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(ScriptAssetSnapshot[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<ScriptAssetSnapshot> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(ScriptAssetSnapshot item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, ScriptAssetSnapshot item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(ScriptAssetSnapshot item)
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

	[DebuggerDisplay("Progressive [ ScriptAssetSnapshot ], Count = {Count}")]
	internal sealed class GeneratedVector_c049ee888c2d768b3d28966bf59c63e5_Progressive<TInputBuffer> : IList<ScriptAssetSnapshot>, ICollection<ScriptAssetSnapshot>, IEnumerable<ScriptAssetSnapshot>, IEnumerable, IReadOnlyList<ScriptAssetSnapshot>, IReadOnlyCollection<ScriptAssetSnapshot>, IFlatBufferDeserializedVector where TInputBuffer : IInputBuffer
	{
		private const uint ChunkSize = 32u;

		private readonly int offset;

		private readonly int count;

		private readonly TInputBuffer buffer;

		private readonly TableFieldContext fieldContext;

		private readonly short remainingDepth;

		private readonly FlatSharp.Compiler.Generated.NC9780113534523AD662A33FF68B919970EF7075D2D9C890E6E92E0B42D1D6857.Helpers.tableReader_075f1eacc2894c709702ac47dd50c198_Progressive<TInputBuffer>?[]?[] items;

		public ScriptAssetSnapshot this[int index]
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

		public GeneratedVector_c049ee888c2d768b3d28966bf59c63e5_Progressive(TInputBuffer memory, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (count = (int)memory.ReadUInt(offset));
			this.offset = offset + 4;
			buffer = memory;
			this.fieldContext = fieldContext;
			this.remainingDepth = remainingDepth;
			int num2 = (int)((long)num / 32L) + 1;
			items = new FlatSharp.Compiler.Generated.NC9780113534523AD662A33FF68B919970EF7075D2D9C890E6E92E0B42D1D6857.Helpers.tableReader_075f1eacc2894c709702ac47dd50c198_Progressive<TInputBuffer>[num2][];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetAddress(uint index, out uint rowIndex, out uint colIndex)
		{
			rowIndex = index / 32;
			colIndex = index % 32;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NC9780113534523AD662A33FF68B919970EF7075D2D9C890E6E92E0B42D1D6857.Helpers.tableReader_075f1eacc2894c709702ac47dd50c198_Progressive<TInputBuffer>?[] GetOrCreateRow(FlatSharp.Compiler.Generated.NC9780113534523AD662A33FF68B919970EF7075D2D9C890E6E92E0B42D1D6857.Helpers.tableReader_075f1eacc2894c709702ac47dd50c198_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] ?? CreateRow(items, rowIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private FlatSharp.Compiler.Generated.NC9780113534523AD662A33FF68B919970EF7075D2D9C890E6E92E0B42D1D6857.Helpers.tableReader_075f1eacc2894c709702ac47dd50c198_Progressive<TInputBuffer>?[] CreateRow(FlatSharp.Compiler.Generated.NC9780113534523AD662A33FF68B919970EF7075D2D9C890E6E92E0B42D1D6857.Helpers.tableReader_075f1eacc2894c709702ac47dd50c198_Progressive<TInputBuffer>?[]?[] items, uint rowIndex)
		{
			return items[rowIndex] = new FlatSharp.Compiler.Generated.NC9780113534523AD662A33FF68B919970EF7075D2D9C890E6E92E0B42D1D6857.Helpers.tableReader_075f1eacc2894c709702ac47dd50c198_Progressive<TInputBuffer>[32];
		}

		private FlatSharp.Compiler.Generated.NC9780113534523AD662A33FF68B919970EF7075D2D9C890E6E92E0B42D1D6857.Helpers.tableReader_075f1eacc2894c709702ac47dd50c198_Progressive<TInputBuffer> ProgressiveGet(int index)
		{
			VectorUtilities.CheckIndex(index, count);
			GetAddress((uint)index, out var rowIndex, out var colIndex);
			FlatSharp.Compiler.Generated.NC9780113534523AD662A33FF68B919970EF7075D2D9C890E6E92E0B42D1D6857.Helpers.tableReader_075f1eacc2894c709702ac47dd50c198_Progressive<TInputBuffer>[][] array = items;
			FlatSharp.Compiler.Generated.NC9780113534523AD662A33FF68B919970EF7075D2D9C890E6E92E0B42D1D6857.Helpers.tableReader_075f1eacc2894c709702ac47dd50c198_Progressive<TInputBuffer>[] orCreateRow = GetOrCreateRow(array, rowIndex);
			FlatSharp.Compiler.Generated.NC9780113534523AD662A33FF68B919970EF7075D2D9C890E6E92E0B42D1D6857.Helpers.tableReader_075f1eacc2894c709702ac47dd50c198_Progressive<TInputBuffer> tableReader_075f1eacc2894c709702ac47dd50c198_Progressive = orCreateRow[colIndex];
			if (tableReader_075f1eacc2894c709702ac47dd50c198_Progressive == null)
			{
				tableReader_075f1eacc2894c709702ac47dd50c198_Progressive = (orCreateRow[colIndex] = UnsafeParseItem(index));
			}
			return tableReader_075f1eacc2894c709702ac47dd50c198_Progressive;
		}

		private void ProgressiveSet(int index, ScriptAssetSnapshot value)
		{
			InlineProgressiveSet(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void InlineProgressiveSet(int index, ScriptAssetSnapshot value)
		{
			VectorUtilities.CheckIndex(index, count);
			UnsafeWriteThrough(index, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NC9780113534523AD662A33FF68B919970EF7075D2D9C890E6E92E0B42D1D6857.Helpers.tableReader_075f1eacc2894c709702ac47dd50c198_Progressive<TInputBuffer> UnsafeParseItem(int index)
		{
			int num = offset + (index << 2);
			return UnsafeParseFromOffset(num);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private FlatSharp.Compiler.Generated.NC9780113534523AD662A33FF68B919970EF7075D2D9C890E6E92E0B42D1D6857.Helpers.tableReader_075f1eacc2894c709702ac47dd50c198_Progressive<TInputBuffer> UnsafeParseFromOffset(int offset)
		{
			return FlatSharp.Compiler.Generated.NC9780113534523AD662A33FF68B919970EF7075D2D9C890E6E92E0B42D1D6857.Helpers.Parse_Progressive(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void UnsafeWriteThrough(int index, ScriptAssetSnapshot value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(ScriptAssetSnapshot? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(ScriptAssetSnapshot? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(ScriptAssetSnapshot[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<ScriptAssetSnapshot> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(ScriptAssetSnapshot item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, ScriptAssetSnapshot item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(ScriptAssetSnapshot item)
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

	[DebuggerDisplay("Greedy [ ScriptAssetSnapshot ], Count = {Count}")]
	internal sealed class GeneratedVector_c049ee888c2d768b3d28966bf59c63e5_Greedy<TInputBuffer> : IList<ScriptAssetSnapshot>, ICollection<ScriptAssetSnapshot>, IEnumerable<ScriptAssetSnapshot>, IEnumerable, IReadOnlyList<ScriptAssetSnapshot>, IReadOnlyCollection<ScriptAssetSnapshot> where TInputBuffer : IInputBuffer
	{
		private readonly List<FlatSharp.Compiler.Generated.NC9780113534523AD662A33FF68B919970EF7075D2D9C890E6E92E0B42D1D6857.Helpers.tableReader_075f1eacc2894c709702ac47dd50c198_Greedy<TInputBuffer>> list;

		public ScriptAssetSnapshot this[int index]
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

		public GeneratedVector_c049ee888c2d768b3d28966bf59c63e5_Greedy(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			List<FlatSharp.Compiler.Generated.NC9780113534523AD662A33FF68B919970EF7075D2D9C890E6E92E0B42D1D6857.Helpers.tableReader_075f1eacc2894c709702ac47dd50c198_Greedy<TInputBuffer>> list = (this.list = new List<FlatSharp.Compiler.Generated.NC9780113534523AD662A33FF68B919970EF7075D2D9C890E6E92E0B42D1D6857.Helpers.tableReader_075f1eacc2894c709702ac47dd50c198_Greedy<TInputBuffer>>(num));
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.NC9780113534523AD662A33FF68B919970EF7075D2D9C890E6E92E0B42D1D6857.Helpers.tableReader_075f1eacc2894c709702ac47dd50c198_Greedy<TInputBuffer> item = FlatSharp.Compiler.Generated.NC9780113534523AD662A33FF68B919970EF7075D2D9C890E6E92E0B42D1D6857.Helpers.Parse_Greedy(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		private FlatSharp.Compiler.Generated.NC9780113534523AD662A33FF68B919970EF7075D2D9C890E6E92E0B42D1D6857.Helpers.tableReader_075f1eacc2894c709702ac47dd50c198_Greedy<TInputBuffer> GetItem(int index)
		{
			return list[index];
		}

		private void SetItem(int index, ScriptAssetSnapshot value)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Contains(ScriptAssetSnapshot? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(ScriptAssetSnapshot? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(ScriptAssetSnapshot[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<ScriptAssetSnapshot> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(ScriptAssetSnapshot item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Clear()
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void Insert(int index, ScriptAssetSnapshot item)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public void RemoveAt(int index)
		{
			FSThrow.NotMutable_DeserializedVector();
		}

		public bool Remove(ScriptAssetSnapshot item)
		{
			return FSThrow.NotMutable_DeserializedVector();
		}
	}

	[DebuggerDisplay("GreedyMutable [ ScriptAssetSnapshot ], Count = {Count}")]
	internal sealed class GeneratedVector_c049ee888c2d768b3d28966bf59c63e5_GreedyMutable<TInputBuffer> : IList<ScriptAssetSnapshot>, ICollection<ScriptAssetSnapshot>, IEnumerable<ScriptAssetSnapshot>, IEnumerable, IReadOnlyList<ScriptAssetSnapshot>, IReadOnlyCollection<ScriptAssetSnapshot> where TInputBuffer : IInputBuffer
	{
		private readonly TableFieldContext fieldContext;

		private readonly List<ScriptAssetSnapshot> list;

		public ScriptAssetSnapshot this[int index]
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

		public GeneratedVector_c049ee888c2d768b3d28966bf59c63e5_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext)
		{
			int num = (int)buffer.ReadUInt(offset);
			offset += 4;
			this.fieldContext = fieldContext;
			List<ScriptAssetSnapshot> list = (this.list = new List<ScriptAssetSnapshot>());
			for (int i = 0; i < num; i++)
			{
				FlatSharp.Compiler.Generated.NC9780113534523AD662A33FF68B919970EF7075D2D9C890E6E92E0B42D1D6857.Helpers.tableReader_075f1eacc2894c709702ac47dd50c198_GreedyMutable<TInputBuffer> item = FlatSharp.Compiler.Generated.NC9780113534523AD662A33FF68B919970EF7075D2D9C890E6E92E0B42D1D6857.Helpers.Parse_GreedyMutable(buffer, offset, remainingDepth);
				list.Add(item);
				offset += 4;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private ScriptAssetSnapshot GetItem(int index)
		{
			return list[index];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetItem(int index, ScriptAssetSnapshot value)
		{
			list[index] = value;
		}

		public void Add(ScriptAssetSnapshot item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public void Insert(int index, ScriptAssetSnapshot item)
		{
			list.Insert(index, item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public bool Remove(ScriptAssetSnapshot item)
		{
			return list.Remove(item);
		}

		public bool Contains(ScriptAssetSnapshot? item)
		{
			return VectorsCommon.Contains(this, item);
		}

		public int IndexOf(ScriptAssetSnapshot? item)
		{
			return VectorsCommon.IndexOf(this, item);
		}

		public void CopyTo(ScriptAssetSnapshot[]? array, int arrayIndex)
		{
			VectorsCommon.CopyTo(this, array, arrayIndex);
		}

		public IEnumerator<ScriptAssetSnapshot> GetEnumerator()
		{
			return VectorsCommon.GetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal static int GetMaxSize(IList<ScriptAssetSnapshot> value)
	{
		int count = value.Count;
		int num = 14;
		if (value is ScriptAssetSnapshot[] array)
		{
			foreach (ScriptAssetSnapshot scriptAssetSnapshot in array)
			{
				SerializationHelpers.EnsureNonNull(scriptAssetSnapshot);
				num += FlatSharp.Compiler.Generated.NC9780113534523AD662A33FF68B919970EF7075D2D9C890E6E92E0B42D1D6857.Helpers.GetMaxSize(scriptAssetSnapshot);
			}
		}
		else if (value is List<ScriptAssetSnapshot> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				ScriptAssetSnapshot scriptAssetSnapshot2 = list[j];
				SerializationHelpers.EnsureNonNull(scriptAssetSnapshot2);
				num += FlatSharp.Compiler.Generated.NC9780113534523AD662A33FF68B919970EF7075D2D9C890E6E92E0B42D1D6857.Helpers.GetMaxSize(scriptAssetSnapshot2);
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				ScriptAssetSnapshot scriptAssetSnapshot3 = value[k];
				SerializationHelpers.EnsureNonNull(scriptAssetSnapshot3);
				num += FlatSharp.Compiler.Generated.NC9780113534523AD662A33FF68B919970EF7075D2D9C890E6E92E0B42D1D6857.Helpers.GetMaxSize(scriptAssetSnapshot3);
			}
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, IList<ScriptAssetSnapshot> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int count = value.Count;
		int num = context.AllocateVector(4, count, 4);
		spanWriter.WriteUOffset(span, offset, num);
		spanWriter.WriteInt(span, count, num);
		num += 4;
		if (value is ScriptAssetSnapshot[] array)
		{
			foreach (ScriptAssetSnapshot scriptAssetSnapshot in array)
			{
				SerializationHelpers.EnsureNonNull(scriptAssetSnapshot);
				FlatSharp.Compiler.Generated.NC9780113534523AD662A33FF68B919970EF7075D2D9C890E6E92E0B42D1D6857.Helpers.Serialize(spanWriter, span, scriptAssetSnapshot, num, context);
				num += 4;
			}
		}
		else if (value is List<ScriptAssetSnapshot> list)
		{
			for (int j = 0; j < list.Count; j++)
			{
				ScriptAssetSnapshot scriptAssetSnapshot2 = list[j];
				SerializationHelpers.EnsureNonNull(scriptAssetSnapshot2);
				FlatSharp.Compiler.Generated.NC9780113534523AD662A33FF68B919970EF7075D2D9C890E6E92E0B42D1D6857.Helpers.Serialize(spanWriter, span, scriptAssetSnapshot2, num, context);
				num += 4;
			}
		}
		else
		{
			for (int k = 0; k < count; k++)
			{
				ScriptAssetSnapshot scriptAssetSnapshot3 = value[k];
				SerializationHelpers.EnsureNonNull(scriptAssetSnapshot3);
				FlatSharp.Compiler.Generated.NC9780113534523AD662A33FF68B919970EF7075D2D9C890E6E92E0B42D1D6857.Helpers.Serialize(spanWriter, span, scriptAssetSnapshot3, num, context);
				num += 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<ScriptAssetSnapshot> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return new GeneratedVector_c049ee888c2d768b3d28966bf59c63e5_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<ScriptAssetSnapshot> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return new GeneratedVector_c049ee888c2d768b3d28966bf59c63e5_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<ScriptAssetSnapshot> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return new GeneratedVector_c049ee888c2d768b3d28966bf59c63e5_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IList<ScriptAssetSnapshot> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return new GeneratedVector_c049ee888c2d768b3d28966bf59c63e5_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth, fieldContext);
	}
}
