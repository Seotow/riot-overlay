using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Sequencer;
using FlatSharp.Compiler.Generated.N31FE0F0224F92B231F88614AD0F8236954E9CF3F3B13D02C15B3B9AF2BAACA5C;
using FlatSharp.Compiler.Generated.N9043FFF2DDA425EB5C277307965DA36CAEFBCBA5750B4E0E47D1ECB5D1F42B67;
using FlatSharp.Compiler.Generated.NB13E61001E5D4EE77E67782E2C4A0D32F0E10647159C80FFDA4E89C2CAF27948;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.NEAC7B00EF46C0E9A9FF8CE2227C63A6CAB14C5CDA4E7D4D51843D3F790613D82;

internal static class Helpers
{
	[DebuggerDisplay("Lazy Channel")]
	internal sealed class tableReader_72d29570ae984024956dc08561396e34_Lazy<TInputBuffer> : Channel, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Lazy);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable4 __vtable;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(Channel);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override SeqProperty Property
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

		public override ChannelValue Value
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

		public override IList<SeqKeyframe>? Keys
		{
			get
			{
				return ReadIndex2Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_72d29570ae984024956dc08561396e34_Lazy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTable4.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static SeqProperty ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return SeqProperty.TransformPosition;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N31FE0F0224F92B231F88614AD0F8236954E9CF3F3B13D02C15B3B9AF2BAACA5C.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ChannelValue ReadIndex1Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return ChannelValue.Scalar;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NB13E61001E5D4EE77E67782E2C4A0D32F0E10647159C80FFDA4E89C2CAF27948.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<SeqKeyframe>? ReadIndex2Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N9043FFF2DDA425EB5C277307965DA36CAEFBCBA5750B4E0E47D1ECB5D1F42B67.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_377a33ce90f44383a334620671e6e9f5.Keys);
		}
	}

	[DebuggerDisplay("Progressive Channel")]
	internal sealed class tableReader_72d29570ae984024956dc08561396e34_Progressive<TInputBuffer> : Channel, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Progressive);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable4 __vtable;

		private byte __mask0;

		private SeqProperty __index0Value;

		private ChannelValue __index1Value;

		private IList<SeqKeyframe>? __index2Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(Channel);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override SeqProperty Property
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

		public override ChannelValue Value
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

		public override IList<SeqKeyframe>? Keys
		{
			get
			{
				if ((__mask0 & 4) == 0)
				{
					__index2Value = ReadIndex2Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask0, 4);
				}
				return __index2Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_72d29570ae984024956dc08561396e34_Progressive(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTable4.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static SeqProperty ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return SeqProperty.TransformPosition;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N31FE0F0224F92B231F88614AD0F8236954E9CF3F3B13D02C15B3B9AF2BAACA5C.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ChannelValue ReadIndex1Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return ChannelValue.Scalar;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NB13E61001E5D4EE77E67782E2C4A0D32F0E10647159C80FFDA4E89C2CAF27948.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<SeqKeyframe>? ReadIndex2Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N9043FFF2DDA425EB5C277307965DA36CAEFBCBA5750B4E0E47D1ECB5D1F42B67.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_377a33ce90f44383a334620671e6e9f5.Keys);
		}
	}

	[DebuggerDisplay("Greedy Channel")]
	internal sealed class tableReader_72d29570ae984024956dc08561396e34_Greedy<TInputBuffer> : Channel, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Greedy);

		private SeqProperty __index0Value;

		private ChannelValue __index1Value;

		private IList<SeqKeyframe>? __index2Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(Channel);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override SeqProperty Property
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

		public override ChannelValue Value
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

		public override IList<SeqKeyframe>? Keys
		{
			get
			{
				return __index2Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_72d29570ae984024956dc08561396e34_Greedy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTable4.Create(buffer, offset, out var item);
			__index0Value = ReadIndex0Value(buffer, offset, item, remainingDepth);
			__index1Value = ReadIndex1Value(buffer, offset, item, remainingDepth);
			__index2Value = ReadIndex2Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static SeqProperty ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return SeqProperty.TransformPosition;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N31FE0F0224F92B231F88614AD0F8236954E9CF3F3B13D02C15B3B9AF2BAACA5C.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ChannelValue ReadIndex1Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return ChannelValue.Scalar;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NB13E61001E5D4EE77E67782E2C4A0D32F0E10647159C80FFDA4E89C2CAF27948.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<SeqKeyframe>? ReadIndex2Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N9043FFF2DDA425EB5C277307965DA36CAEFBCBA5750B4E0E47D1ECB5D1F42B67.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_377a33ce90f44383a334620671e6e9f5.Keys);
		}
	}

	[DebuggerDisplay("GreedyMutable Channel")]
	internal sealed class tableReader_72d29570ae984024956dc08561396e34_GreedyMutable<TInputBuffer> : Channel, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.GreedyMutable);

		private SeqProperty __index0Value;

		private ChannelValue __index1Value;

		private IList<SeqKeyframe>? __index2Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(Channel);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override SeqProperty Property
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

		public override ChannelValue Value
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

		public override IList<SeqKeyframe>? Keys
		{
			get
			{
				return __index2Value;
			}
			set
			{
				__index2Value = value;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_72d29570ae984024956dc08561396e34_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTable4.Create(buffer, offset, out var item);
			__index0Value = ReadIndex0Value(buffer, offset, item, remainingDepth);
			__index1Value = ReadIndex1Value(buffer, offset, item, remainingDepth);
			__index2Value = ReadIndex2Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static SeqProperty ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return SeqProperty.TransformPosition;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N31FE0F0224F92B231F88614AD0F8236954E9CF3F3B13D02C15B3B9AF2BAACA5C.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ChannelValue ReadIndex1Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return ChannelValue.Scalar;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NB13E61001E5D4EE77E67782E2C4A0D32F0E10647159C80FFDA4E89C2CAF27948.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<SeqKeyframe>? ReadIndex2Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N9043FFF2DDA425EB5C277307965DA36CAEFBCBA5750B4E0E47D1ECB5D1F42B67.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_377a33ce90f44383a334620671e6e9f5.Keys);
		}
	}

	private static class tableMetadata_377a33ce90f44383a334620671e6e9f5
	{
		public static readonly TableFieldContext Property = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Sequencer.Channel.Property", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Value = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Sequencer.Channel.Value", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Keys = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Sequencer.Channel.Keys", sharedString: false, writeThrough: false);
	}

	internal static int GetMaxSize(Channel value)
	{
		int num = 29;
		IList<SeqKeyframe> keys = value.Keys;
		if (keys != null)
		{
			num += FlatSharp.Compiler.Generated.N9043FFF2DDA425EB5C277307965DA36CAEFBCBA5750B4E0E47D1ECB5D1F42B67.Helpers.GetMaxSize(keys);
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, Channel value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int num = context.AllocateSpace(15, 4);
		spanWriter.WriteUOffset(span, offset, num);
		int num2 = num + 4;
		int num3 = 4;
		Span<byte> span2 = stackalloc byte[10];
		SeqProperty property = value.Property;
		ChannelValue value2 = value.Value;
		IList<SeqKeyframe> keys = value.Keys;
		int num4 = num;
		if (keys != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num4 = num2;
			num2 += 4;
			num3 = 10;
		}
		Span<byte> span3 = span2;
		spanWriter.WriteUShort(span3, (ushort)(num4 - num), 8);
		int num5 = num;
		if (property != SeqProperty.TransformPosition)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 2);
			num5 = num2;
			num2 += 2;
			FlatSharp.Compiler.Generated.N31FE0F0224F92B231F88614AD0F8236954E9CF3F3B13D02C15B3B9AF2BAACA5C.Helpers.Serialize(spanWriter, span, property, num5);
			if (6 > num3)
			{
				num3 = 6;
			}
		}
		Span<byte> span4 = span2;
		spanWriter.WriteUShort(span4, (ushort)(num5 - num), 4);
		int num6 = num;
		if (value2 != ChannelValue.Scalar)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num6 = num2;
			num2++;
			FlatSharp.Compiler.Generated.NB13E61001E5D4EE77E67782E2C4A0D32F0E10647159C80FFDA4E89C2CAF27948.Helpers.Serialize(spanWriter, span, value2, num6);
			if (8 > num3)
			{
				num3 = 8;
			}
		}
		Span<byte> span5 = span2;
		spanWriter.WriteUShort(span5, (ushort)(num6 - num), 6);
		int num7 = num2 - num;
		context.Offset -= 15 - num7;
		Span<byte> span6 = span2;
		spanWriter.WriteUShort(span6, (ushort)num3, 0);
		Span<byte> span7 = span2;
		spanWriter.WriteUShort(span7, (ushort)num7, 2);
		int num8 = context.FinishVTable(span, span2.Slice(0, num3));
		spanWriter.WriteInt(span, num - num8, num);
		if (num4 != num)
		{
			FlatSharp.Compiler.Generated.N9043FFF2DDA425EB5C277307965DA36CAEFBCBA5750B4E0E47D1ECB5D1F42B67.Helpers.Serialize(spanWriter, span, keys, num4, context);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_72d29570ae984024956dc08561396e34_Lazy<TInputBuffer> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_72d29570ae984024956dc08561396e34_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_72d29570ae984024956dc08561396e34_Progressive<TInputBuffer> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_72d29570ae984024956dc08561396e34_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_72d29570ae984024956dc08561396e34_Greedy<TInputBuffer> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_72d29570ae984024956dc08561396e34_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_72d29570ae984024956dc08561396e34_GreedyMutable<TInputBuffer> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_72d29570ae984024956dc08561396e34_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}
}
