using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Commands;
using FlatSharp.Compiler.Generated.N28ABA73BC29275C0D7E5DD298730C616029DD1364AF31EC2E37FF14A56B21F85;
using FlatSharp.Compiler.Generated.NA877967FDEF65B5ED29FA12AD5046634A6B8239F428E5D77BF513D4524DB0B62;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N620B7926FCBC3DC617074E94940A05FF4973324C8F2DB78463EAE0A185744F00;

internal static class Helpers
{
	[DebuggerDisplay("Lazy EphemeralAction")]
	internal sealed class tableReader_4cba9c2b281c4754812af66363339b98_Lazy<TInputBuffer> : EphemeralAction, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Lazy);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable4 __vtable;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(EphemeralAction);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override EphemeralType RequestId
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

		public override IList<string>? Params
		{
			get
			{
				return ReadIndex1Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_4cba9c2b281c4754812af66363339b98_Lazy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTable4.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static EphemeralType ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return EphemeralType.Metadata;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N28ABA73BC29275C0D7E5DD298730C616029DD1364AF31EC2E37FF14A56B21F85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<string>? ReadIndex1Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NA877967FDEF65B5ED29FA12AD5046634A6B8239F428E5D77BF513D4524DB0B62.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_161fdcc49dbf4fb89aa84870ce390c4d.Params);
		}
	}

	[DebuggerDisplay("Progressive EphemeralAction")]
	internal sealed class tableReader_4cba9c2b281c4754812af66363339b98_Progressive<TInputBuffer> : EphemeralAction, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Progressive);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable4 __vtable;

		private byte __mask0;

		private EphemeralType __index0Value;

		private IList<string>? __index1Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(EphemeralAction);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override EphemeralType RequestId
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

		public override IList<string>? Params
		{
			get
			{
				if ((__mask0 & 2) == 0)
				{
					__index1Value = ReadIndex1Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask0, 2);
				}
				return __index1Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_4cba9c2b281c4754812af66363339b98_Progressive(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTable4.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static EphemeralType ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return EphemeralType.Metadata;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N28ABA73BC29275C0D7E5DD298730C616029DD1364AF31EC2E37FF14A56B21F85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<string>? ReadIndex1Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NA877967FDEF65B5ED29FA12AD5046634A6B8239F428E5D77BF513D4524DB0B62.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_161fdcc49dbf4fb89aa84870ce390c4d.Params);
		}
	}

	[DebuggerDisplay("Greedy EphemeralAction")]
	internal sealed class tableReader_4cba9c2b281c4754812af66363339b98_Greedy<TInputBuffer> : EphemeralAction, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Greedy);

		private EphemeralType __index0Value;

		private IList<string>? __index1Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(EphemeralAction);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override EphemeralType RequestId
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

		public override IList<string>? Params
		{
			get
			{
				return __index1Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_4cba9c2b281c4754812af66363339b98_Greedy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTable4.Create(buffer, offset, out var item);
			__index0Value = ReadIndex0Value(buffer, offset, item, remainingDepth);
			__index1Value = ReadIndex1Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static EphemeralType ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return EphemeralType.Metadata;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N28ABA73BC29275C0D7E5DD298730C616029DD1364AF31EC2E37FF14A56B21F85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<string>? ReadIndex1Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NA877967FDEF65B5ED29FA12AD5046634A6B8239F428E5D77BF513D4524DB0B62.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_161fdcc49dbf4fb89aa84870ce390c4d.Params);
		}
	}

	[DebuggerDisplay("GreedyMutable EphemeralAction")]
	internal sealed class tableReader_4cba9c2b281c4754812af66363339b98_GreedyMutable<TInputBuffer> : EphemeralAction, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.GreedyMutable);

		private EphemeralType __index0Value;

		private IList<string>? __index1Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(EphemeralAction);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override EphemeralType RequestId
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

		public override IList<string>? Params
		{
			get
			{
				return __index1Value;
			}
			set
			{
				__index1Value = value;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_4cba9c2b281c4754812af66363339b98_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTable4.Create(buffer, offset, out var item);
			__index0Value = ReadIndex0Value(buffer, offset, item, remainingDepth);
			__index1Value = ReadIndex1Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static EphemeralType ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return EphemeralType.Metadata;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N28ABA73BC29275C0D7E5DD298730C616029DD1364AF31EC2E37FF14A56B21F85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<string>? ReadIndex1Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NA877967FDEF65B5ED29FA12AD5046634A6B8239F428E5D77BF513D4524DB0B62.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_161fdcc49dbf4fb89aa84870ce390c4d.Params);
		}
	}

	private static class tableMetadata_161fdcc49dbf4fb89aa84870ce390c4d
	{
		public static readonly TableFieldContext RequestId = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.EphemeralAction.RequestId", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Params = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.EphemeralAction.Params", sharedString: false, writeThrough: false);
	}

	internal static int GetMaxSize(EphemeralAction value)
	{
		int num = 30;
		IList<string> list = value.Params;
		if (list != null)
		{
			num += FlatSharp.Compiler.Generated.NA877967FDEF65B5ED29FA12AD5046634A6B8239F428E5D77BF513D4524DB0B62.Helpers.GetMaxSize(list);
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, EphemeralAction value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int num = context.AllocateSpace(18, 4);
		spanWriter.WriteUOffset(span, offset, num);
		int num2 = num + 4;
		int num3 = 4;
		Span<byte> span2 = stackalloc byte[8];
		EphemeralType requestId = value.RequestId;
		IList<string> list = value.Params;
		int num4 = num;
		if (list != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num4 = num2;
			num2 += 4;
			num3 = 8;
		}
		Span<byte> span3 = span2;
		spanWriter.WriteUShort(span3, (ushort)(num4 - num), 6);
		int num5 = num;
		if (requestId != EphemeralType.Metadata)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num5 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.N28ABA73BC29275C0D7E5DD298730C616029DD1364AF31EC2E37FF14A56B21F85.Helpers.Serialize(spanWriter, span, requestId, num5);
			if (6 > num3)
			{
				num3 = 6;
			}
		}
		Span<byte> span4 = span2;
		spanWriter.WriteUShort(span4, (ushort)(num5 - num), 4);
		int num6 = num2 - num;
		context.Offset -= 18 - num6;
		Span<byte> span5 = span2;
		spanWriter.WriteUShort(span5, (ushort)num3, 0);
		Span<byte> span6 = span2;
		spanWriter.WriteUShort(span6, (ushort)num6, 2);
		int num7 = context.FinishVTable(span, span2.Slice(0, num3));
		spanWriter.WriteInt(span, num - num7, num);
		if (num4 != num)
		{
			FlatSharp.Compiler.Generated.NA877967FDEF65B5ED29FA12AD5046634A6B8239F428E5D77BF513D4524DB0B62.Helpers.Serialize(spanWriter, span, list, num4, context, tableMetadata_161fdcc49dbf4fb89aa84870ce390c4d.Params);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_4cba9c2b281c4754812af66363339b98_Lazy<TInputBuffer> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_4cba9c2b281c4754812af66363339b98_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_4cba9c2b281c4754812af66363339b98_Progressive<TInputBuffer> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_4cba9c2b281c4754812af66363339b98_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_4cba9c2b281c4754812af66363339b98_Greedy<TInputBuffer> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_4cba9c2b281c4754812af66363339b98_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_4cba9c2b281c4754812af66363339b98_GreedyMutable<TInputBuffer> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_4cba9c2b281c4754812af66363339b98_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}
}
