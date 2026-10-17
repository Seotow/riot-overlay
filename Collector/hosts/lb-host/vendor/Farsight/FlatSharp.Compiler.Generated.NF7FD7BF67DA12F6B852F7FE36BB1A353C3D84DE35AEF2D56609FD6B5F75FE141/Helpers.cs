using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Commands;
using FlatSharp.Compiler.Generated.N5E28C9120AF63AE77EDFC16A2BECFD971FB0B778301849E74A4DF9CBB79D28DC;
using FlatSharp.Compiler.Generated.NC73D26B0A22898B482D1D636A3B9DC1BE8503690F02B934A2962E9EBCF6FD04E;
using FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.NF7FD7BF67DA12F6B852F7FE36BB1A353C3D84DE35AEF2D56609FD6B5F75FE141;

internal static class Helpers
{
	[DebuggerDisplay("Lazy CameraPreviewStripLayout")]
	internal sealed class tableReader_44b41415edb441caa5b5323c315f70f8_Lazy<TInputBuffer> : CameraPreviewStripLayout, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Lazy);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable4 __vtable;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(CameraPreviewStripLayout);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override IList<CameraPreviewCameraSource>? Panes
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

		public override IList<float>? Weights
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

		public override float SlantPixels
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
		public tableReader_44b41415edb441caa5b5323c315f70f8_Lazy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTable4.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<CameraPreviewCameraSource>? ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N5E28C9120AF63AE77EDFC16A2BECFD971FB0B778301849E74A4DF9CBB79D28DC.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_e76a34b950f9420c8855710bf094447f.Panes);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<float>? ReadIndex1Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC73D26B0A22898B482D1D636A3B9DC1BE8503690F02B934A2962E9EBCF6FD04E.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_e76a34b950f9420c8855710bf094447f.Weights);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex2Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return 56f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}
	}

	[DebuggerDisplay("Progressive CameraPreviewStripLayout")]
	internal sealed class tableReader_44b41415edb441caa5b5323c315f70f8_Progressive<TInputBuffer> : CameraPreviewStripLayout, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Progressive);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable4 __vtable;

		private byte __mask0;

		private IList<CameraPreviewCameraSource>? __index0Value;

		private IList<float>? __index1Value;

		private float __index2Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(CameraPreviewStripLayout);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override IList<CameraPreviewCameraSource>? Panes
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

		public override IList<float>? Weights
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

		public override float SlantPixels
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
		public tableReader_44b41415edb441caa5b5323c315f70f8_Progressive(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTable4.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<CameraPreviewCameraSource>? ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N5E28C9120AF63AE77EDFC16A2BECFD971FB0B778301849E74A4DF9CBB79D28DC.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_e76a34b950f9420c8855710bf094447f.Panes);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<float>? ReadIndex1Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC73D26B0A22898B482D1D636A3B9DC1BE8503690F02B934A2962E9EBCF6FD04E.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_e76a34b950f9420c8855710bf094447f.Weights);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex2Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return 56f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}
	}

	[DebuggerDisplay("Greedy CameraPreviewStripLayout")]
	internal sealed class tableReader_44b41415edb441caa5b5323c315f70f8_Greedy<TInputBuffer> : CameraPreviewStripLayout, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Greedy);

		private IList<CameraPreviewCameraSource>? __index0Value;

		private IList<float>? __index1Value;

		private float __index2Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(CameraPreviewStripLayout);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override IList<CameraPreviewCameraSource>? Panes
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

		public override IList<float>? Weights
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

		public override float SlantPixels
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
		public tableReader_44b41415edb441caa5b5323c315f70f8_Greedy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTable4.Create(buffer, offset, out var item);
			__index0Value = ReadIndex0Value(buffer, offset, item, remainingDepth);
			__index1Value = ReadIndex1Value(buffer, offset, item, remainingDepth);
			__index2Value = ReadIndex2Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<CameraPreviewCameraSource>? ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N5E28C9120AF63AE77EDFC16A2BECFD971FB0B778301849E74A4DF9CBB79D28DC.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_e76a34b950f9420c8855710bf094447f.Panes);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<float>? ReadIndex1Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC73D26B0A22898B482D1D636A3B9DC1BE8503690F02B934A2962E9EBCF6FD04E.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_e76a34b950f9420c8855710bf094447f.Weights);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex2Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return 56f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}
	}

	[DebuggerDisplay("GreedyMutable CameraPreviewStripLayout")]
	internal sealed class tableReader_44b41415edb441caa5b5323c315f70f8_GreedyMutable<TInputBuffer> : CameraPreviewStripLayout, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.GreedyMutable);

		private IList<CameraPreviewCameraSource>? __index0Value;

		private IList<float>? __index1Value;

		private float __index2Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(CameraPreviewStripLayout);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override IList<CameraPreviewCameraSource>? Panes
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

		public override IList<float>? Weights
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

		public override float SlantPixels
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
		public tableReader_44b41415edb441caa5b5323c315f70f8_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTable4.Create(buffer, offset, out var item);
			__index0Value = ReadIndex0Value(buffer, offset, item, remainingDepth);
			__index1Value = ReadIndex1Value(buffer, offset, item, remainingDepth);
			__index2Value = ReadIndex2Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<CameraPreviewCameraSource>? ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N5E28C9120AF63AE77EDFC16A2BECFD971FB0B778301849E74A4DF9CBB79D28DC.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_e76a34b950f9420c8855710bf094447f.Panes);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<float>? ReadIndex1Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC73D26B0A22898B482D1D636A3B9DC1BE8503690F02B934A2962E9EBCF6FD04E.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_e76a34b950f9420c8855710bf094447f.Weights);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex2Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return 56f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}
	}

	private static class tableMetadata_e76a34b950f9420c8855710bf094447f
	{
		public static readonly TableFieldContext Panes = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.CameraPreviewStripLayout.Panes", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Weights = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.CameraPreviewStripLayout.Weights", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext SlantPixels = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.CameraPreviewStripLayout.SlantPixels", sharedString: false, writeThrough: false);
	}

	internal static int GetMaxSize(CameraPreviewStripLayout value)
	{
		int num = 39;
		IList<CameraPreviewCameraSource> panes = value.Panes;
		if (panes != null)
		{
			num += FlatSharp.Compiler.Generated.N5E28C9120AF63AE77EDFC16A2BECFD971FB0B778301849E74A4DF9CBB79D28DC.Helpers.GetMaxSize(panes);
		}
		IList<float> weights = value.Weights;
		if (weights != null)
		{
			num += FlatSharp.Compiler.Generated.NC73D26B0A22898B482D1D636A3B9DC1BE8503690F02B934A2962E9EBCF6FD04E.Helpers.GetMaxSize(weights);
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, CameraPreviewStripLayout value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int num = context.AllocateSpace(25, 4);
		spanWriter.WriteUOffset(span, offset, num);
		int num2 = num + 4;
		int num3 = 4;
		Span<byte> span2 = stackalloc byte[10];
		IList<CameraPreviewCameraSource> panes = value.Panes;
		IList<float> weights = value.Weights;
		float slantPixels = value.SlantPixels;
		int num4 = num;
		if (slantPixels != 56f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num4 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, slantPixels, num4);
			num3 = 10;
		}
		Span<byte> span3 = span2;
		spanWriter.WriteUShort(span3, (ushort)(num4 - num), 8);
		int num5 = num;
		if (weights != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num5 = num2;
			num2 += 4;
			if (8 > num3)
			{
				num3 = 8;
			}
		}
		Span<byte> span4 = span2;
		spanWriter.WriteUShort(span4, (ushort)(num5 - num), 6);
		int num6 = num;
		if (panes != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num6 = num2;
			num2 += 4;
			if (6 > num3)
			{
				num3 = 6;
			}
		}
		Span<byte> span5 = span2;
		spanWriter.WriteUShort(span5, (ushort)(num6 - num), 4);
		int num7 = num2 - num;
		context.Offset -= 25 - num7;
		Span<byte> span6 = span2;
		spanWriter.WriteUShort(span6, (ushort)num3, 0);
		Span<byte> span7 = span2;
		spanWriter.WriteUShort(span7, (ushort)num7, 2);
		int num8 = context.FinishVTable(span, span2.Slice(0, num3));
		spanWriter.WriteInt(span, num - num8, num);
		if (num5 != num)
		{
			FlatSharp.Compiler.Generated.NC73D26B0A22898B482D1D636A3B9DC1BE8503690F02B934A2962E9EBCF6FD04E.Helpers.Serialize(spanWriter, span, weights, num5, context);
		}
		if (num6 != num)
		{
			FlatSharp.Compiler.Generated.N5E28C9120AF63AE77EDFC16A2BECFD971FB0B778301849E74A4DF9CBB79D28DC.Helpers.Serialize(spanWriter, span, panes, num6, context);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_44b41415edb441caa5b5323c315f70f8_Lazy<TInputBuffer> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_44b41415edb441caa5b5323c315f70f8_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_44b41415edb441caa5b5323c315f70f8_Progressive<TInputBuffer> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_44b41415edb441caa5b5323c315f70f8_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_44b41415edb441caa5b5323c315f70f8_Greedy<TInputBuffer> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_44b41415edb441caa5b5323c315f70f8_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_44b41415edb441caa5b5323c315f70f8_GreedyMutable<TInputBuffer> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_44b41415edb441caa5b5323c315f70f8_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}
}
