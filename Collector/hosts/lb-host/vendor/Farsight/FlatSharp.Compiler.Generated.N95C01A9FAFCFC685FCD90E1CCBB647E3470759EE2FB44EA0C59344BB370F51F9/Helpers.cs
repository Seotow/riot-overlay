using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Snapshot;
using FlatSharp.Compiler.Generated.N4B823E5E9F66BD10FF5C1FD9E7A631213CAC17AA73A053FBE1A1DA14322BB93F;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N95C01A9FAFCFC685FCD90E1CCBB647E3470759EE2FB44EA0C59344BB370F51F9;

internal static class Helpers
{
	[DebuggerDisplay("Lazy SpellObjectList")]
	internal sealed class tableReader_394e8f45d26d4b9f9024731f44c8bb84_Lazy<TInputBuffer> : SpellObjectList, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Lazy);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable4 __vtable;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(SpellObjectList);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override IList<SpellObjectEntry>? SpellObjects
		{
			get
			{
				return ReadIndex0Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_394e8f45d26d4b9f9024731f44c8bb84_Lazy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTable4.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<SpellObjectEntry>? ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N4B823E5E9F66BD10FF5C1FD9E7A631213CAC17AA73A053FBE1A1DA14322BB93F.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_d09d819d164f431ead1fc0541c4f4120.SpellObjects);
		}
	}

	[DebuggerDisplay("Progressive SpellObjectList")]
	internal sealed class tableReader_394e8f45d26d4b9f9024731f44c8bb84_Progressive<TInputBuffer> : SpellObjectList, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Progressive);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable4 __vtable;

		private byte __mask0;

		private IList<SpellObjectEntry>? __index0Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(SpellObjectList);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override IList<SpellObjectEntry>? SpellObjects
		{
			get
			{
				if ((__mask0 & 1) == 0)
				{
					__index0Value = ReadIndex0Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask0, 1);
				}
				return __index0Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_394e8f45d26d4b9f9024731f44c8bb84_Progressive(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTable4.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<SpellObjectEntry>? ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N4B823E5E9F66BD10FF5C1FD9E7A631213CAC17AA73A053FBE1A1DA14322BB93F.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_d09d819d164f431ead1fc0541c4f4120.SpellObjects);
		}
	}

	[DebuggerDisplay("Greedy SpellObjectList")]
	internal sealed class tableReader_394e8f45d26d4b9f9024731f44c8bb84_Greedy<TInputBuffer> : SpellObjectList, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Greedy);

		private IList<SpellObjectEntry>? __index0Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(SpellObjectList);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override IList<SpellObjectEntry>? SpellObjects
		{
			get
			{
				return __index0Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_394e8f45d26d4b9f9024731f44c8bb84_Greedy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTable4.Create(buffer, offset, out var item);
			__index0Value = ReadIndex0Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<SpellObjectEntry>? ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N4B823E5E9F66BD10FF5C1FD9E7A631213CAC17AA73A053FBE1A1DA14322BB93F.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_d09d819d164f431ead1fc0541c4f4120.SpellObjects);
		}
	}

	[DebuggerDisplay("GreedyMutable SpellObjectList")]
	internal sealed class tableReader_394e8f45d26d4b9f9024731f44c8bb84_GreedyMutable<TInputBuffer> : SpellObjectList, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.GreedyMutable);

		private IList<SpellObjectEntry>? __index0Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(SpellObjectList);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override IList<SpellObjectEntry>? SpellObjects
		{
			get
			{
				return __index0Value;
			}
			set
			{
				__index0Value = value;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_394e8f45d26d4b9f9024731f44c8bb84_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTable4.Create(buffer, offset, out var item);
			__index0Value = ReadIndex0Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<SpellObjectEntry>? ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N4B823E5E9F66BD10FF5C1FD9E7A631213CAC17AA73A053FBE1A1DA14322BB93F.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_d09d819d164f431ead1fc0541c4f4120.SpellObjects);
		}
	}

	private static class tableMetadata_d09d819d164f431ead1fc0541c4f4120
	{
		public static readonly TableFieldContext SpellObjects = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.SpellObjectList.SpellObjects", sharedString: false, writeThrough: false);
	}

	internal static int GetMaxSize(SpellObjectList value)
	{
		int num = 21;
		IList<SpellObjectEntry> spellObjects = value.SpellObjects;
		if (spellObjects != null)
		{
			num += FlatSharp.Compiler.Generated.N4B823E5E9F66BD10FF5C1FD9E7A631213CAC17AA73A053FBE1A1DA14322BB93F.Helpers.GetMaxSize(spellObjects);
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, SpellObjectList value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int num = context.AllocateSpace(11, 4);
		spanWriter.WriteUOffset(span, offset, num);
		int num2 = num + 4;
		int num3 = 4;
		Span<byte> span2 = stackalloc byte[6];
		IList<SpellObjectEntry> spellObjects = value.SpellObjects;
		int num4 = num;
		if (spellObjects != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num4 = num2;
			num2 += 4;
			num3 = 6;
		}
		Span<byte> span3 = span2;
		spanWriter.WriteUShort(span3, (ushort)(num4 - num), 4);
		int num5 = num2 - num;
		context.Offset -= 11 - num5;
		Span<byte> span4 = span2;
		spanWriter.WriteUShort(span4, (ushort)num3, 0);
		Span<byte> span5 = span2;
		spanWriter.WriteUShort(span5, (ushort)num5, 2);
		int num6 = context.FinishVTable(span, span2.Slice(0, num3));
		spanWriter.WriteInt(span, num - num6, num);
		if (num4 != num)
		{
			FlatSharp.Compiler.Generated.N4B823E5E9F66BD10FF5C1FD9E7A631213CAC17AA73A053FBE1A1DA14322BB93F.Helpers.Serialize(spanWriter, span, spellObjects, num4, context);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_394e8f45d26d4b9f9024731f44c8bb84_Lazy<TInputBuffer> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_394e8f45d26d4b9f9024731f44c8bb84_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_394e8f45d26d4b9f9024731f44c8bb84_Progressive<TInputBuffer> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_394e8f45d26d4b9f9024731f44c8bb84_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_394e8f45d26d4b9f9024731f44c8bb84_Greedy<TInputBuffer> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_394e8f45d26d4b9f9024731f44c8bb84_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_394e8f45d26d4b9f9024731f44c8bb84_GreedyMutable<TInputBuffer> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_394e8f45d26d4b9f9024731f44c8bb84_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}
}
