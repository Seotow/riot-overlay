using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Commands;
using FlatSharp.Compiler.Generated.N1AB1515549FA510966E4A9D7DB8607DFE24203DC3BAB890F2504E07BE37B15F7;
using FlatSharp.Compiler.Generated.N62E517BBF9CFA8A5343DCD6693A7DF0D05CA6EFBD6A6020C83B8A8AEF75DACE4;
using FlatSharp.Compiler.Generated.ND5802027154E3862E3DC1ECBFAC480E0946C1D3F83FAE1301753B92402055A9E;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N50369821530AF660841175CE0251C31EA5CA9998230B9375C91B083F021933A6;

internal static class Helpers
{
	[DebuggerDisplay("Lazy CameraPreviewConfiguration")]
	internal sealed class tableReader_65adfa6a68be4164bb4195204f3c07b0_Lazy<TInputBuffer> : CameraPreviewConfiguration, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Lazy);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable4 __vtable;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(CameraPreviewConfiguration);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override ulong Generation
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

		public override IList<CameraPreviewCameraDefinition>? Cameras
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

		public override IList<CameraPreviewOutputDefinition>? Outputs
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
		public tableReader_65adfa6a68be4164bb4195204f3c07b0_Lazy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTable4.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ulong ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return 0uL;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.ND5802027154E3862E3DC1ECBFAC480E0946C1D3F83FAE1301753B92402055A9E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<CameraPreviewCameraDefinition>? ReadIndex1Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N62E517BBF9CFA8A5343DCD6693A7DF0D05CA6EFBD6A6020C83B8A8AEF75DACE4.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_9395ba01efd34e07a7ece3ba0846a98a.Cameras);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<CameraPreviewOutputDefinition>? ReadIndex2Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1AB1515549FA510966E4A9D7DB8607DFE24203DC3BAB890F2504E07BE37B15F7.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_9395ba01efd34e07a7ece3ba0846a98a.Outputs);
		}
	}

	[DebuggerDisplay("Progressive CameraPreviewConfiguration")]
	internal sealed class tableReader_65adfa6a68be4164bb4195204f3c07b0_Progressive<TInputBuffer> : CameraPreviewConfiguration, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Progressive);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable4 __vtable;

		private byte __mask0;

		private ulong __index0Value;

		private IList<CameraPreviewCameraDefinition>? __index1Value;

		private IList<CameraPreviewOutputDefinition>? __index2Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(CameraPreviewConfiguration);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override ulong Generation
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

		public override IList<CameraPreviewCameraDefinition>? Cameras
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

		public override IList<CameraPreviewOutputDefinition>? Outputs
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
		public tableReader_65adfa6a68be4164bb4195204f3c07b0_Progressive(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTable4.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ulong ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return 0uL;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.ND5802027154E3862E3DC1ECBFAC480E0946C1D3F83FAE1301753B92402055A9E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<CameraPreviewCameraDefinition>? ReadIndex1Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N62E517BBF9CFA8A5343DCD6693A7DF0D05CA6EFBD6A6020C83B8A8AEF75DACE4.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_9395ba01efd34e07a7ece3ba0846a98a.Cameras);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<CameraPreviewOutputDefinition>? ReadIndex2Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1AB1515549FA510966E4A9D7DB8607DFE24203DC3BAB890F2504E07BE37B15F7.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_9395ba01efd34e07a7ece3ba0846a98a.Outputs);
		}
	}

	[DebuggerDisplay("Greedy CameraPreviewConfiguration")]
	internal sealed class tableReader_65adfa6a68be4164bb4195204f3c07b0_Greedy<TInputBuffer> : CameraPreviewConfiguration, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Greedy);

		private ulong __index0Value;

		private IList<CameraPreviewCameraDefinition>? __index1Value;

		private IList<CameraPreviewOutputDefinition>? __index2Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(CameraPreviewConfiguration);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override ulong Generation
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

		public override IList<CameraPreviewCameraDefinition>? Cameras
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

		public override IList<CameraPreviewOutputDefinition>? Outputs
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
		public tableReader_65adfa6a68be4164bb4195204f3c07b0_Greedy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTable4.Create(buffer, offset, out var item);
			__index0Value = ReadIndex0Value(buffer, offset, item, remainingDepth);
			__index1Value = ReadIndex1Value(buffer, offset, item, remainingDepth);
			__index2Value = ReadIndex2Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ulong ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return 0uL;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.ND5802027154E3862E3DC1ECBFAC480E0946C1D3F83FAE1301753B92402055A9E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<CameraPreviewCameraDefinition>? ReadIndex1Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N62E517BBF9CFA8A5343DCD6693A7DF0D05CA6EFBD6A6020C83B8A8AEF75DACE4.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_9395ba01efd34e07a7ece3ba0846a98a.Cameras);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<CameraPreviewOutputDefinition>? ReadIndex2Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1AB1515549FA510966E4A9D7DB8607DFE24203DC3BAB890F2504E07BE37B15F7.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_9395ba01efd34e07a7ece3ba0846a98a.Outputs);
		}
	}

	[DebuggerDisplay("GreedyMutable CameraPreviewConfiguration")]
	internal sealed class tableReader_65adfa6a68be4164bb4195204f3c07b0_GreedyMutable<TInputBuffer> : CameraPreviewConfiguration, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.GreedyMutable);

		private ulong __index0Value;

		private IList<CameraPreviewCameraDefinition>? __index1Value;

		private IList<CameraPreviewOutputDefinition>? __index2Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(CameraPreviewConfiguration);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override ulong Generation
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

		public override IList<CameraPreviewCameraDefinition>? Cameras
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

		public override IList<CameraPreviewOutputDefinition>? Outputs
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
		public tableReader_65adfa6a68be4164bb4195204f3c07b0_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTable4.Create(buffer, offset, out var item);
			__index0Value = ReadIndex0Value(buffer, offset, item, remainingDepth);
			__index1Value = ReadIndex1Value(buffer, offset, item, remainingDepth);
			__index2Value = ReadIndex2Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ulong ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return 0uL;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.ND5802027154E3862E3DC1ECBFAC480E0946C1D3F83FAE1301753B92402055A9E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<CameraPreviewCameraDefinition>? ReadIndex1Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N62E517BBF9CFA8A5343DCD6693A7DF0D05CA6EFBD6A6020C83B8A8AEF75DACE4.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_9395ba01efd34e07a7ece3ba0846a98a.Cameras);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<CameraPreviewOutputDefinition>? ReadIndex2Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1AB1515549FA510966E4A9D7DB8607DFE24203DC3BAB890F2504E07BE37B15F7.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_9395ba01efd34e07a7ece3ba0846a98a.Outputs);
		}
	}

	private static class tableMetadata_9395ba01efd34e07a7ece3ba0846a98a
	{
		public static readonly TableFieldContext Generation = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.CameraPreviewConfiguration.Generation", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Cameras = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.CameraPreviewConfiguration.Cameras", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Outputs = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.CameraPreviewConfiguration.Outputs", sharedString: false, writeThrough: false);
	}

	internal static int GetMaxSize(CameraPreviewConfiguration value)
	{
		int num = 47;
		IList<CameraPreviewCameraDefinition> cameras = value.Cameras;
		if (cameras != null)
		{
			num += FlatSharp.Compiler.Generated.N62E517BBF9CFA8A5343DCD6693A7DF0D05CA6EFBD6A6020C83B8A8AEF75DACE4.Helpers.GetMaxSize(cameras);
		}
		IList<CameraPreviewOutputDefinition> outputs = value.Outputs;
		if (outputs != null)
		{
			num += FlatSharp.Compiler.Generated.N1AB1515549FA510966E4A9D7DB8607DFE24203DC3BAB890F2504E07BE37B15F7.Helpers.GetMaxSize(outputs);
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, CameraPreviewConfiguration value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int num = context.AllocateSpace(33, 4);
		spanWriter.WriteUOffset(span, offset, num);
		int num2 = num + 4;
		int num3 = 4;
		Span<byte> span2 = stackalloc byte[10];
		ulong generation = value.Generation;
		IList<CameraPreviewCameraDefinition> cameras = value.Cameras;
		IList<CameraPreviewOutputDefinition> outputs = value.Outputs;
		int num4 = num;
		if (generation != 0L)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 8);
			num4 = num2;
			num2 += 8;
			FlatSharp.Compiler.Generated.ND5802027154E3862E3DC1ECBFAC480E0946C1D3F83FAE1301753B92402055A9E.Helpers.Serialize(spanWriter, span, generation, num4);
			if (6 > num3)
			{
				num3 = 6;
			}
		}
		Span<byte> span3 = span2;
		spanWriter.WriteUShort(span3, (ushort)(num4 - num), 4);
		int num5 = num;
		if (outputs != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num5 = num2;
			num2 += 4;
			num3 = 10;
		}
		Span<byte> span4 = span2;
		spanWriter.WriteUShort(span4, (ushort)(num5 - num), 8);
		int num6 = num;
		if (cameras != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num6 = num2;
			num2 += 4;
			if (8 > num3)
			{
				num3 = 8;
			}
		}
		Span<byte> span5 = span2;
		spanWriter.WriteUShort(span5, (ushort)(num6 - num), 6);
		int num7 = num2 - num;
		context.Offset -= 33 - num7;
		Span<byte> span6 = span2;
		spanWriter.WriteUShort(span6, (ushort)num3, 0);
		Span<byte> span7 = span2;
		spanWriter.WriteUShort(span7, (ushort)num7, 2);
		int num8 = context.FinishVTable(span, span2.Slice(0, num3));
		spanWriter.WriteInt(span, num - num8, num);
		if (num5 != num)
		{
			FlatSharp.Compiler.Generated.N1AB1515549FA510966E4A9D7DB8607DFE24203DC3BAB890F2504E07BE37B15F7.Helpers.Serialize(spanWriter, span, outputs, num5, context);
		}
		if (num6 != num)
		{
			FlatSharp.Compiler.Generated.N62E517BBF9CFA8A5343DCD6693A7DF0D05CA6EFBD6A6020C83B8A8AEF75DACE4.Helpers.Serialize(spanWriter, span, cameras, num6, context);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_65adfa6a68be4164bb4195204f3c07b0_Lazy<TInputBuffer> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_65adfa6a68be4164bb4195204f3c07b0_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_65adfa6a68be4164bb4195204f3c07b0_Progressive<TInputBuffer> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_65adfa6a68be4164bb4195204f3c07b0_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_65adfa6a68be4164bb4195204f3c07b0_Greedy<TInputBuffer> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_65adfa6a68be4164bb4195204f3c07b0_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_65adfa6a68be4164bb4195204f3c07b0_GreedyMutable<TInputBuffer> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_65adfa6a68be4164bb4195204f3c07b0_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}
}
