using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Commands;
using FlatSharp.Compiler.Generated.NDC724B100DE0FA76A4C6F883D9C097C9BD99BE552D7672E266802D36A24FCF60;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N8DCD6AE2DF6BA307CB99B9375512A1913441DCFE072CCC729E09A9FE0F57880E;

internal static class Helpers
{
	[DebuggerDisplay("Lazy SetCameraPath")]
	internal sealed class tableReader_9e0e1b1eb43b4241b47f46d2d6292e02_Lazy<TInputBuffer> : SetCameraPath, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Lazy);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable4 __vtable;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(SetCameraPath);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override IList<CameraPathKeyframe>? Keys
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
		public tableReader_9e0e1b1eb43b4241b47f46d2d6292e02_Lazy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTable4.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<CameraPathKeyframe>? ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NDC724B100DE0FA76A4C6F883D9C097C9BD99BE552D7672E266802D36A24FCF60.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_209c233a21464e06a66972f852801800.Keys);
		}
	}

	[DebuggerDisplay("Progressive SetCameraPath")]
	internal sealed class tableReader_9e0e1b1eb43b4241b47f46d2d6292e02_Progressive<TInputBuffer> : SetCameraPath, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Progressive);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable4 __vtable;

		private byte __mask0;

		private IList<CameraPathKeyframe>? __index0Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(SetCameraPath);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override IList<CameraPathKeyframe>? Keys
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
		public tableReader_9e0e1b1eb43b4241b47f46d2d6292e02_Progressive(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTable4.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<CameraPathKeyframe>? ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NDC724B100DE0FA76A4C6F883D9C097C9BD99BE552D7672E266802D36A24FCF60.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_209c233a21464e06a66972f852801800.Keys);
		}
	}

	[DebuggerDisplay("Greedy SetCameraPath")]
	internal sealed class tableReader_9e0e1b1eb43b4241b47f46d2d6292e02_Greedy<TInputBuffer> : SetCameraPath, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Greedy);

		private IList<CameraPathKeyframe>? __index0Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(SetCameraPath);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override IList<CameraPathKeyframe>? Keys
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
		public tableReader_9e0e1b1eb43b4241b47f46d2d6292e02_Greedy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTable4.Create(buffer, offset, out var item);
			__index0Value = ReadIndex0Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<CameraPathKeyframe>? ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NDC724B100DE0FA76A4C6F883D9C097C9BD99BE552D7672E266802D36A24FCF60.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_209c233a21464e06a66972f852801800.Keys);
		}
	}

	[DebuggerDisplay("GreedyMutable SetCameraPath")]
	internal sealed class tableReader_9e0e1b1eb43b4241b47f46d2d6292e02_GreedyMutable<TInputBuffer> : SetCameraPath, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.GreedyMutable);

		private IList<CameraPathKeyframe>? __index0Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(SetCameraPath);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override IList<CameraPathKeyframe>? Keys
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
		public tableReader_9e0e1b1eb43b4241b47f46d2d6292e02_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTable4.Create(buffer, offset, out var item);
			__index0Value = ReadIndex0Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<CameraPathKeyframe>? ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NDC724B100DE0FA76A4C6F883D9C097C9BD99BE552D7672E266802D36A24FCF60.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_209c233a21464e06a66972f852801800.Keys);
		}
	}

	private static class tableMetadata_209c233a21464e06a66972f852801800
	{
		public static readonly TableFieldContext Keys = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.SetCameraPath.Keys", sharedString: false, writeThrough: false);
	}

	internal static int GetMaxSize(SetCameraPath value)
	{
		int num = 21;
		IList<CameraPathKeyframe> keys = value.Keys;
		if (keys != null)
		{
			num += FlatSharp.Compiler.Generated.NDC724B100DE0FA76A4C6F883D9C097C9BD99BE552D7672E266802D36A24FCF60.Helpers.GetMaxSize(keys);
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, SetCameraPath value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int num = context.AllocateSpace(11, 4);
		spanWriter.WriteUOffset(span, offset, num);
		int num2 = num + 4;
		int num3 = 4;
		Span<byte> span2 = stackalloc byte[6];
		IList<CameraPathKeyframe> keys = value.Keys;
		int num4 = num;
		if (keys != null)
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
			FlatSharp.Compiler.Generated.NDC724B100DE0FA76A4C6F883D9C097C9BD99BE552D7672E266802D36A24FCF60.Helpers.Serialize(spanWriter, span, keys, num4, context);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_9e0e1b1eb43b4241b47f46d2d6292e02_Lazy<TInputBuffer> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_9e0e1b1eb43b4241b47f46d2d6292e02_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_9e0e1b1eb43b4241b47f46d2d6292e02_Progressive<TInputBuffer> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_9e0e1b1eb43b4241b47f46d2d6292e02_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_9e0e1b1eb43b4241b47f46d2d6292e02_Greedy<TInputBuffer> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_9e0e1b1eb43b4241b47f46d2d6292e02_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_9e0e1b1eb43b4241b47f46d2d6292e02_GreedyMutable<TInputBuffer> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_9e0e1b1eb43b4241b47f46d2d6292e02_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}
}
