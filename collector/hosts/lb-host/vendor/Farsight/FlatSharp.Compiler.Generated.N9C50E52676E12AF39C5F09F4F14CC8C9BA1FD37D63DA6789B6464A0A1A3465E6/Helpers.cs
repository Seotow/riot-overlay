using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Commands;
using FlatSharp.Compiler.Generated.N0518D85C3F33B46F4FC93A2AEFFEEB623E1E41020DA824F42C6FBFDCE3A6235B;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N9C50E52676E12AF39C5F09F4F14CC8C9BA1FD37D63DA6789B6464A0A1A3465E6;

internal static class Helpers
{
	[DebuggerDisplay("Lazy SetSequence")]
	internal sealed class tableReader_11fa33dab59c4c30880181fa8a2a3a3c_Lazy<TInputBuffer> : SetSequence, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Lazy);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable4 __vtable;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(SetSequence);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override Memory<byte>? Document
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
		public tableReader_11fa33dab59c4c30880181fa8a2a3a3c_Lazy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTable4.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static Memory<byte>? ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N0518D85C3F33B46F4FC93A2AEFFEEB623E1E41020DA824F42C6FBFDCE3A6235B.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_80e44495b9e549dcbdd1b8fa652612cb.Document);
		}
	}

	[DebuggerDisplay("Progressive SetSequence")]
	internal sealed class tableReader_11fa33dab59c4c30880181fa8a2a3a3c_Progressive<TInputBuffer> : SetSequence, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Progressive);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable4 __vtable;

		private byte __mask0;

		private Memory<byte>? __index0Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(SetSequence);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override Memory<byte>? Document
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
		public tableReader_11fa33dab59c4c30880181fa8a2a3a3c_Progressive(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTable4.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static Memory<byte>? ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N0518D85C3F33B46F4FC93A2AEFFEEB623E1E41020DA824F42C6FBFDCE3A6235B.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_80e44495b9e549dcbdd1b8fa652612cb.Document);
		}
	}

	[DebuggerDisplay("Greedy SetSequence")]
	internal sealed class tableReader_11fa33dab59c4c30880181fa8a2a3a3c_Greedy<TInputBuffer> : SetSequence, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Greedy);

		private Memory<byte>? __index0Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(SetSequence);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override Memory<byte>? Document
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
		public tableReader_11fa33dab59c4c30880181fa8a2a3a3c_Greedy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTable4.Create(buffer, offset, out var item);
			__index0Value = ReadIndex0Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static Memory<byte>? ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N0518D85C3F33B46F4FC93A2AEFFEEB623E1E41020DA824F42C6FBFDCE3A6235B.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_80e44495b9e549dcbdd1b8fa652612cb.Document);
		}
	}

	[DebuggerDisplay("GreedyMutable SetSequence")]
	internal sealed class tableReader_11fa33dab59c4c30880181fa8a2a3a3c_GreedyMutable<TInputBuffer> : SetSequence, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.GreedyMutable);

		private Memory<byte>? __index0Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(SetSequence);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override Memory<byte>? Document
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
		public tableReader_11fa33dab59c4c30880181fa8a2a3a3c_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTable4.Create(buffer, offset, out var item);
			__index0Value = ReadIndex0Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static Memory<byte>? ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N0518D85C3F33B46F4FC93A2AEFFEEB623E1E41020DA824F42C6FBFDCE3A6235B.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_80e44495b9e549dcbdd1b8fa652612cb.Document);
		}
	}

	private static class tableMetadata_80e44495b9e549dcbdd1b8fa652612cb
	{
		public static readonly TableFieldContext Document = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.SetSequence.Document", sharedString: false, writeThrough: false);
	}

	internal static int GetMaxSize(SetSequence value)
	{
		int num = 21;
		Memory<byte>? document = value.Document;
		if (document.HasValue)
		{
			num += FlatSharp.Compiler.Generated.N0518D85C3F33B46F4FC93A2AEFFEEB623E1E41020DA824F42C6FBFDCE3A6235B.Helpers.GetMaxSize(document);
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, SetSequence value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int num = context.AllocateSpace(11, 4);
		spanWriter.WriteUOffset(span, offset, num);
		int num2 = num + 4;
		int num3 = 4;
		Span<byte> span2 = stackalloc byte[6];
		Memory<byte>? document = value.Document;
		int num4 = num;
		if (document.HasValue)
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
			FlatSharp.Compiler.Generated.N0518D85C3F33B46F4FC93A2AEFFEEB623E1E41020DA824F42C6FBFDCE3A6235B.Helpers.Serialize(spanWriter, span, document, num4, context);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_11fa33dab59c4c30880181fa8a2a3a3c_Lazy<TInputBuffer> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_11fa33dab59c4c30880181fa8a2a3a3c_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_11fa33dab59c4c30880181fa8a2a3a3c_Progressive<TInputBuffer> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_11fa33dab59c4c30880181fa8a2a3a3c_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_11fa33dab59c4c30880181fa8a2a3a3c_Greedy<TInputBuffer> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_11fa33dab59c4c30880181fa8a2a3a3c_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_11fa33dab59c4c30880181fa8a2a3a3c_GreedyMutable<TInputBuffer> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_11fa33dab59c4c30880181fa8a2a3a3c_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}
}
