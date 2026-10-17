using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Cinematics;
using FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E;
using FlatSharp.Compiler.Generated.N7937E19385170D742973882D1D7193D542C82356CABFA360B89633D62CC823EB;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N6AE3215356F13B8412766A4FE13B17227B4354F17EC1EA2F4E7AD959DA72AA0B;

internal static class Helpers
{
	[DebuggerDisplay("Lazy CinematicOverlayTrack")]
	internal sealed class tableReader_9a13efa19e1343bea852812ce8034fc6_Lazy<TInputBuffer> : CinematicOverlayTrack, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Lazy);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable4 __vtable;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(CinematicOverlayTrack);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override string? OverlayName
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
		public tableReader_9a13efa19e1343bea852812ce8034fc6_Lazy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTable4.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string? ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, offset2, remainingDepth);
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
			return FlatSharp.Compiler.Generated.N7937E19385170D742973882D1D7193D542C82356CABFA360B89633D62CC823EB.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_2e5c0c5a61a94bfda1335c39ddfbcc2b.Keys);
		}
	}

	[DebuggerDisplay("Progressive CinematicOverlayTrack")]
	internal sealed class tableReader_9a13efa19e1343bea852812ce8034fc6_Progressive<TInputBuffer> : CinematicOverlayTrack, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Progressive);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable4 __vtable;

		private byte __mask0;

		private string? __index0Value;

		private IList<CinematicKeyframe>? __index1Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(CinematicOverlayTrack);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override string? OverlayName
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
		public tableReader_9a13efa19e1343bea852812ce8034fc6_Progressive(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTable4.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string? ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, offset2, remainingDepth);
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
			return FlatSharp.Compiler.Generated.N7937E19385170D742973882D1D7193D542C82356CABFA360B89633D62CC823EB.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_2e5c0c5a61a94bfda1335c39ddfbcc2b.Keys);
		}
	}

	[DebuggerDisplay("Greedy CinematicOverlayTrack")]
	internal sealed class tableReader_9a13efa19e1343bea852812ce8034fc6_Greedy<TInputBuffer> : CinematicOverlayTrack, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Greedy);

		private string? __index0Value;

		private IList<CinematicKeyframe>? __index1Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(CinematicOverlayTrack);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override string? OverlayName
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
		public tableReader_9a13efa19e1343bea852812ce8034fc6_Greedy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTable4.Create(buffer, offset, out var item);
			__index0Value = ReadIndex0Value(buffer, offset, item, remainingDepth);
			__index1Value = ReadIndex1Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string? ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, offset2, remainingDepth);
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
			return FlatSharp.Compiler.Generated.N7937E19385170D742973882D1D7193D542C82356CABFA360B89633D62CC823EB.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_2e5c0c5a61a94bfda1335c39ddfbcc2b.Keys);
		}
	}

	[DebuggerDisplay("GreedyMutable CinematicOverlayTrack")]
	internal sealed class tableReader_9a13efa19e1343bea852812ce8034fc6_GreedyMutable<TInputBuffer> : CinematicOverlayTrack, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.GreedyMutable);

		private string? __index0Value;

		private IList<CinematicKeyframe>? __index1Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(CinematicOverlayTrack);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override string? OverlayName
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
		public tableReader_9a13efa19e1343bea852812ce8034fc6_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTable4.Create(buffer, offset, out var item);
			__index0Value = ReadIndex0Value(buffer, offset, item, remainingDepth);
			__index1Value = ReadIndex1Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string? ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, offset2, remainingDepth);
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
			return FlatSharp.Compiler.Generated.N7937E19385170D742973882D1D7193D542C82356CABFA360B89633D62CC823EB.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_2e5c0c5a61a94bfda1335c39ddfbcc2b.Keys);
		}
	}

	private static class tableMetadata_2e5c0c5a61a94bfda1335c39ddfbcc2b
	{
		public static readonly TableFieldContext OverlayName = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Cinematics.CinematicOverlayTrack.OverlayName", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Keys = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Cinematics.CinematicOverlayTrack.Keys", sharedString: false, writeThrough: false);
	}

	internal static int GetMaxSize(CinematicOverlayTrack value)
	{
		int num = 30;
		string overlayName = value.OverlayName;
		if (overlayName != null)
		{
			num += FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.GetMaxSize(overlayName);
		}
		IList<CinematicKeyframe> keys = value.Keys;
		if (keys != null)
		{
			num += FlatSharp.Compiler.Generated.N7937E19385170D742973882D1D7193D542C82356CABFA360B89633D62CC823EB.Helpers.GetMaxSize(keys);
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, CinematicOverlayTrack value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int num = context.AllocateSpace(18, 4);
		spanWriter.WriteUOffset(span, offset, num);
		int num2 = num + 4;
		int num3 = 4;
		Span<byte> span2 = stackalloc byte[8];
		string overlayName = value.OverlayName;
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
		if (overlayName != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num5 = num2;
			num2 += 4;
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
			FlatSharp.Compiler.Generated.N7937E19385170D742973882D1D7193D542C82356CABFA360B89633D62CC823EB.Helpers.Serialize(spanWriter, span, keys, num4, context);
		}
		if (num5 != num)
		{
			FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Serialize(spanWriter, span, overlayName, num5, context, tableMetadata_2e5c0c5a61a94bfda1335c39ddfbcc2b.OverlayName);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_9a13efa19e1343bea852812ce8034fc6_Lazy<TInputBuffer> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_9a13efa19e1343bea852812ce8034fc6_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_9a13efa19e1343bea852812ce8034fc6_Progressive<TInputBuffer> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_9a13efa19e1343bea852812ce8034fc6_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_9a13efa19e1343bea852812ce8034fc6_Greedy<TInputBuffer> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_9a13efa19e1343bea852812ce8034fc6_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_9a13efa19e1343bea852812ce8034fc6_GreedyMutable<TInputBuffer> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_9a13efa19e1343bea852812ce8034fc6_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}
}
