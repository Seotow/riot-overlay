using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Cinematics;
using FlatSharp.Compiler.Generated.N5A74C4844C76BB33903178EFAB9B3140D4150828C3593D2C3C40CF7AB27432AE;
using FlatSharp.Compiler.Generated.N7937E19385170D742973882D1D7193D542C82356CABFA360B89633D62CC823EB;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N5164B6F8876BDC418E0E4252FDA8D6CD37757EA8CE90D5E7492745068759B023;

internal static class Helpers
{
	[DebuggerDisplay("Lazy CinematicHudTrack")]
	internal sealed class tableReader_98a197eb4f6449b4a8ef66d3410111cb_Lazy<TInputBuffer> : CinematicHudTrack, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Lazy);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable4 __vtable;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(CinematicHudTrack);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override CinematicHudElement Element
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

		public override IList<CinematicKeyframe>? Keys
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
		public tableReader_98a197eb4f6449b4a8ef66d3410111cb_Lazy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTable4.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static CinematicHudElement ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return CinematicHudElement.FloatingText;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N5A74C4844C76BB33903178EFAB9B3140D4150828C3593D2C3C40CF7AB27432AE.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<CinematicKeyframe>? ReadIndex1Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N7937E19385170D742973882D1D7193D542C82356CABFA360B89633D62CC823EB.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_a3f800f0b2e145ec9a69e2a31dc07974.Keys);
		}
	}

	[DebuggerDisplay("Progressive CinematicHudTrack")]
	internal sealed class tableReader_98a197eb4f6449b4a8ef66d3410111cb_Progressive<TInputBuffer> : CinematicHudTrack, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Progressive);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable4 __vtable;

		private byte __mask0;

		private CinematicHudElement __index0Value;

		private IList<CinematicKeyframe>? __index1Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(CinematicHudTrack);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override CinematicHudElement Element
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

		public override IList<CinematicKeyframe>? Keys
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
		public tableReader_98a197eb4f6449b4a8ef66d3410111cb_Progressive(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTable4.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static CinematicHudElement ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return CinematicHudElement.FloatingText;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N5A74C4844C76BB33903178EFAB9B3140D4150828C3593D2C3C40CF7AB27432AE.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<CinematicKeyframe>? ReadIndex1Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N7937E19385170D742973882D1D7193D542C82356CABFA360B89633D62CC823EB.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_a3f800f0b2e145ec9a69e2a31dc07974.Keys);
		}
	}

	[DebuggerDisplay("Greedy CinematicHudTrack")]
	internal sealed class tableReader_98a197eb4f6449b4a8ef66d3410111cb_Greedy<TInputBuffer> : CinematicHudTrack, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Greedy);

		private CinematicHudElement __index0Value;

		private IList<CinematicKeyframe>? __index1Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(CinematicHudTrack);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override CinematicHudElement Element
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

		public override IList<CinematicKeyframe>? Keys
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
		public tableReader_98a197eb4f6449b4a8ef66d3410111cb_Greedy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTable4.Create(buffer, offset, out var item);
			__index0Value = ReadIndex0Value(buffer, offset, item, remainingDepth);
			__index1Value = ReadIndex1Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static CinematicHudElement ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return CinematicHudElement.FloatingText;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N5A74C4844C76BB33903178EFAB9B3140D4150828C3593D2C3C40CF7AB27432AE.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<CinematicKeyframe>? ReadIndex1Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N7937E19385170D742973882D1D7193D542C82356CABFA360B89633D62CC823EB.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_a3f800f0b2e145ec9a69e2a31dc07974.Keys);
		}
	}

	[DebuggerDisplay("GreedyMutable CinematicHudTrack")]
	internal sealed class tableReader_98a197eb4f6449b4a8ef66d3410111cb_GreedyMutable<TInputBuffer> : CinematicHudTrack, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.GreedyMutable);

		private CinematicHudElement __index0Value;

		private IList<CinematicKeyframe>? __index1Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(CinematicHudTrack);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override CinematicHudElement Element
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

		public override IList<CinematicKeyframe>? Keys
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
		public tableReader_98a197eb4f6449b4a8ef66d3410111cb_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTable4.Create(buffer, offset, out var item);
			__index0Value = ReadIndex0Value(buffer, offset, item, remainingDepth);
			__index1Value = ReadIndex1Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static CinematicHudElement ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return CinematicHudElement.FloatingText;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N5A74C4844C76BB33903178EFAB9B3140D4150828C3593D2C3C40CF7AB27432AE.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<CinematicKeyframe>? ReadIndex1Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N7937E19385170D742973882D1D7193D542C82356CABFA360B89633D62CC823EB.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_a3f800f0b2e145ec9a69e2a31dc07974.Keys);
		}
	}

	private static class tableMetadata_a3f800f0b2e145ec9a69e2a31dc07974
	{
		public static readonly TableFieldContext Element = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Cinematics.CinematicHudTrack.Element", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Keys = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Cinematics.CinematicHudTrack.Keys", sharedString: false, writeThrough: false);
	}

	internal static int GetMaxSize(CinematicHudTrack value)
	{
		int num = 24;
		IList<CinematicKeyframe> keys = value.Keys;
		if (keys != null)
		{
			num += FlatSharp.Compiler.Generated.N7937E19385170D742973882D1D7193D542C82356CABFA360B89633D62CC823EB.Helpers.GetMaxSize(keys);
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, CinematicHudTrack value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int num = context.AllocateSpace(12, 4);
		spanWriter.WriteUOffset(span, offset, num);
		int num2 = num + 4;
		int num3 = 4;
		Span<byte> span2 = stackalloc byte[8];
		CinematicHudElement element = value.Element;
		IList<CinematicKeyframe> keys = value.Keys;
		int num4 = num;
		if (keys != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num4 = num2;
			num2 += 4;
			num3 = 8;
		}
		Span<byte> span3 = span2;
		spanWriter.WriteUShort(span3, (ushort)(num4 - num), 6);
		int num5 = num;
		if (element != CinematicHudElement.FloatingText)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num5 = num2;
			num2++;
			FlatSharp.Compiler.Generated.N5A74C4844C76BB33903178EFAB9B3140D4150828C3593D2C3C40CF7AB27432AE.Helpers.Serialize(spanWriter, span, element, num5);
			if (6 > num3)
			{
				num3 = 6;
			}
		}
		Span<byte> span4 = span2;
		spanWriter.WriteUShort(span4, (ushort)(num5 - num), 4);
		int num6 = num2 - num;
		context.Offset -= 12 - num6;
		Span<byte> span5 = span2;
		spanWriter.WriteUShort(span5, (ushort)num3, 0);
		Span<byte> span6 = span2;
		spanWriter.WriteUShort(span6, (ushort)num6, 2);
		int num7 = context.FinishVTable(span, span2.Slice(0, num3));
		spanWriter.WriteInt(span, num - num7, num);
		if (num4 != num)
		{
			FlatSharp.Compiler.Generated.N7937E19385170D742973882D1D7193D542C82356CABFA360B89633D62CC823EB.Helpers.Serialize(spanWriter, span, keys, num4, context);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_98a197eb4f6449b4a8ef66d3410111cb_Lazy<TInputBuffer> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_98a197eb4f6449b4a8ef66d3410111cb_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_98a197eb4f6449b4a8ef66d3410111cb_Progressive<TInputBuffer> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_98a197eb4f6449b4a8ef66d3410111cb_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_98a197eb4f6449b4a8ef66d3410111cb_Greedy<TInputBuffer> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_98a197eb4f6449b4a8ef66d3410111cb_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_98a197eb4f6449b4a8ef66d3410111cb_GreedyMutable<TInputBuffer> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_98a197eb4f6449b4a8ef66d3410111cb_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}
}
