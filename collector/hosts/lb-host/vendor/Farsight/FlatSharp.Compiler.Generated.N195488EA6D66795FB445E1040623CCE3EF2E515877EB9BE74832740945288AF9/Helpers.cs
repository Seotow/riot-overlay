using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Commands;
using FlatSharp.Compiler.Generated.N50369821530AF660841175CE0251C31EA5CA9998230B9375C91B083F021933A6;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N195488EA6D66795FB445E1040623CCE3EF2E515877EB9BE74832740945288AF9;

internal static class Helpers
{
	[DebuggerDisplay("Lazy SetCameraPreviewConfiguration")]
	internal sealed class tableReader_a657e42475fd482dad301d3278459056_Lazy<TInputBuffer> : SetCameraPreviewConfiguration, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Lazy);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable4 __vtable;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(SetCameraPreviewConfiguration);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override required CameraPreviewConfiguration Configuration
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
		public tableReader_a657e42475fd482dad301d3278459056_Lazy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTable4.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static CameraPreviewConfiguration ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				FSThrow.InvalidData_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Commands.SetCameraPreviewConfiguration.Configuration");
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N50369821530AF660841175CE0251C31EA5CA9998230B9375C91B083F021933A6.Helpers.Parse_Lazy(buffer, offset2, remainingDepth);
		}
	}

	[DebuggerDisplay("Progressive SetCameraPreviewConfiguration")]
	internal sealed class tableReader_a657e42475fd482dad301d3278459056_Progressive<TInputBuffer> : SetCameraPreviewConfiguration, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Progressive);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable4 __vtable;

		private byte __mask0;

		private CameraPreviewConfiguration __index0Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(SetCameraPreviewConfiguration);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override required CameraPreviewConfiguration Configuration
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
		public tableReader_a657e42475fd482dad301d3278459056_Progressive(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTable4.Create(buffer, offset, out __vtable);
			__index0Value = null;
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static CameraPreviewConfiguration ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				FSThrow.InvalidData_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Commands.SetCameraPreviewConfiguration.Configuration");
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N50369821530AF660841175CE0251C31EA5CA9998230B9375C91B083F021933A6.Helpers.Parse_Progressive(buffer, offset2, remainingDepth);
		}
	}

	[DebuggerDisplay("Greedy SetCameraPreviewConfiguration")]
	internal sealed class tableReader_a657e42475fd482dad301d3278459056_Greedy<TInputBuffer> : SetCameraPreviewConfiguration, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Greedy);

		private CameraPreviewConfiguration __index0Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(SetCameraPreviewConfiguration);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override required CameraPreviewConfiguration Configuration
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
		public tableReader_a657e42475fd482dad301d3278459056_Greedy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTable4.Create(buffer, offset, out var item);
			__index0Value = ReadIndex0Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static CameraPreviewConfiguration ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				FSThrow.InvalidData_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Commands.SetCameraPreviewConfiguration.Configuration");
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N50369821530AF660841175CE0251C31EA5CA9998230B9375C91B083F021933A6.Helpers.Parse_Greedy(buffer, offset2, remainingDepth);
		}
	}

	[DebuggerDisplay("GreedyMutable SetCameraPreviewConfiguration")]
	internal sealed class tableReader_a657e42475fd482dad301d3278459056_GreedyMutable<TInputBuffer> : SetCameraPreviewConfiguration, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.GreedyMutable);

		private CameraPreviewConfiguration __index0Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(SetCameraPreviewConfiguration);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override required CameraPreviewConfiguration Configuration
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
		public tableReader_a657e42475fd482dad301d3278459056_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTable4.Create(buffer, offset, out var item);
			__index0Value = ReadIndex0Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static CameraPreviewConfiguration ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				FSThrow.InvalidData_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Commands.SetCameraPreviewConfiguration.Configuration");
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N50369821530AF660841175CE0251C31EA5CA9998230B9375C91B083F021933A6.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth);
		}
	}

	private static class tableMetadata_e5cbd64aca484143bf79c8c3f7b8d43b
	{
		public static readonly TableFieldContext Configuration = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.SetCameraPreviewConfiguration.Configuration", sharedString: false, writeThrough: false);
	}

	internal static int GetMaxSize(SetCameraPreviewConfiguration value)
	{
		int num = 21;
		CameraPreviewConfiguration configuration = value.Configuration;
		if (configuration != null)
		{
			num += FlatSharp.Compiler.Generated.N50369821530AF660841175CE0251C31EA5CA9998230B9375C91B083F021933A6.Helpers.GetMaxSize(configuration);
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, SetCameraPreviewConfiguration value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int num = context.AllocateSpace(11, 4);
		spanWriter.WriteUOffset(span, offset, num);
		int num2 = num + 4;
		int num3 = 6;
		Span<byte> span2 = stackalloc byte[6];
		CameraPreviewConfiguration configuration = value.Configuration;
		int num4 = num;
		if (configuration != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num4 = num2;
			num2 += 4;
		}
		else
		{
			FSThrow.InvalidOperation_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Commands.SetCameraPreviewConfiguration.Configuration");
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
			FlatSharp.Compiler.Generated.N50369821530AF660841175CE0251C31EA5CA9998230B9375C91B083F021933A6.Helpers.Serialize(spanWriter, span, configuration, num4, context);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_a657e42475fd482dad301d3278459056_Lazy<TInputBuffer> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_a657e42475fd482dad301d3278459056_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_a657e42475fd482dad301d3278459056_Progressive<TInputBuffer> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_a657e42475fd482dad301d3278459056_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_a657e42475fd482dad301d3278459056_Greedy<TInputBuffer> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_a657e42475fd482dad301d3278459056_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_a657e42475fd482dad301d3278459056_GreedyMutable<TInputBuffer> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_a657e42475fd482dad301d3278459056_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}
}
