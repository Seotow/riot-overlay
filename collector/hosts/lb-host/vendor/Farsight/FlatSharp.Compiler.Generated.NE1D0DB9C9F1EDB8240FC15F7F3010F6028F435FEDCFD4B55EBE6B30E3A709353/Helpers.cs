using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Snapshot;
using FlatSharp.Compiler.Generated.N0518D85C3F33B46F4FC93A2AEFFEEB623E1E41020DA824F42C6FBFDCE3A6235B;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.NE1D0DB9C9F1EDB8240FC15F7F3010F6028F435FEDCFD4B55EBE6B30E3A709353;

internal static class Helpers
{
	[DebuggerDisplay("Lazy SequenceStateResponse")]
	internal sealed class tableReader_bc076d6a0d5e4c1688142e9c362030a8_Lazy<TInputBuffer> : SequenceStateResponse, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Lazy);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable4 __vtable;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(SequenceStateResponse);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override Memory<byte>? State
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
		public tableReader_bc076d6a0d5e4c1688142e9c362030a8_Lazy(TInputBuffer buffer, int offset, short remainingDepth)
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
			return FlatSharp.Compiler.Generated.N0518D85C3F33B46F4FC93A2AEFFEEB623E1E41020DA824F42C6FBFDCE3A6235B.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_3393f4546cd84869a981b7c89146978f.State);
		}
	}

	[DebuggerDisplay("Progressive SequenceStateResponse")]
	internal sealed class tableReader_bc076d6a0d5e4c1688142e9c362030a8_Progressive<TInputBuffer> : SequenceStateResponse, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Progressive);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable4 __vtable;

		private byte __mask0;

		private Memory<byte>? __index0Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(SequenceStateResponse);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override Memory<byte>? State
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
		public tableReader_bc076d6a0d5e4c1688142e9c362030a8_Progressive(TInputBuffer buffer, int offset, short remainingDepth)
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
			return FlatSharp.Compiler.Generated.N0518D85C3F33B46F4FC93A2AEFFEEB623E1E41020DA824F42C6FBFDCE3A6235B.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_3393f4546cd84869a981b7c89146978f.State);
		}
	}

	[DebuggerDisplay("Greedy SequenceStateResponse")]
	internal sealed class tableReader_bc076d6a0d5e4c1688142e9c362030a8_Greedy<TInputBuffer> : SequenceStateResponse, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Greedy);

		private Memory<byte>? __index0Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(SequenceStateResponse);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override Memory<byte>? State
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
		public tableReader_bc076d6a0d5e4c1688142e9c362030a8_Greedy(TInputBuffer buffer, int offset, short remainingDepth)
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
			return FlatSharp.Compiler.Generated.N0518D85C3F33B46F4FC93A2AEFFEEB623E1E41020DA824F42C6FBFDCE3A6235B.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_3393f4546cd84869a981b7c89146978f.State);
		}
	}

	[DebuggerDisplay("GreedyMutable SequenceStateResponse")]
	internal sealed class tableReader_bc076d6a0d5e4c1688142e9c362030a8_GreedyMutable<TInputBuffer> : SequenceStateResponse, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.GreedyMutable);

		private Memory<byte>? __index0Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(SequenceStateResponse);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override Memory<byte>? State
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
		public tableReader_bc076d6a0d5e4c1688142e9c362030a8_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth)
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
			return FlatSharp.Compiler.Generated.N0518D85C3F33B46F4FC93A2AEFFEEB623E1E41020DA824F42C6FBFDCE3A6235B.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_3393f4546cd84869a981b7c89146978f.State);
		}
	}

	private static class tableMetadata_3393f4546cd84869a981b7c89146978f
	{
		public static readonly TableFieldContext State = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.SequenceStateResponse.State", sharedString: false, writeThrough: false);
	}

	internal static int GetMaxSize(SequenceStateResponse value)
	{
		int num = 21;
		Memory<byte>? state = value.State;
		if (state.HasValue)
		{
			num += FlatSharp.Compiler.Generated.N0518D85C3F33B46F4FC93A2AEFFEEB623E1E41020DA824F42C6FBFDCE3A6235B.Helpers.GetMaxSize(state);
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, SequenceStateResponse value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int num = context.AllocateSpace(11, 4);
		spanWriter.WriteUOffset(span, offset, num);
		int num2 = num + 4;
		int num3 = 4;
		Span<byte> span2 = stackalloc byte[6];
		Memory<byte>? state = value.State;
		int num4 = num;
		if (state.HasValue)
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
			FlatSharp.Compiler.Generated.N0518D85C3F33B46F4FC93A2AEFFEEB623E1E41020DA824F42C6FBFDCE3A6235B.Helpers.Serialize(spanWriter, span, state, num4, context);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_bc076d6a0d5e4c1688142e9c362030a8_Lazy<TInputBuffer> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_bc076d6a0d5e4c1688142e9c362030a8_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_bc076d6a0d5e4c1688142e9c362030a8_Progressive<TInputBuffer> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_bc076d6a0d5e4c1688142e9c362030a8_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_bc076d6a0d5e4c1688142e9c362030a8_Greedy<TInputBuffer> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_bc076d6a0d5e4c1688142e9c362030a8_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_bc076d6a0d5e4c1688142e9c362030a8_GreedyMutable<TInputBuffer> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_bc076d6a0d5e4c1688142e9c362030a8_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}
}
