using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Commands;
using BlueBottleIPC.LeagueBroadcast.Common;
using FlatSharp.Compiler.Generated.NE4543F7A17A19BDAC3E8E48B10B4F31871AB3F40EC192119FBE1F38F18BF4321;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N4E2FD9F10DFE642110D2D048AD575A7B15705BF87C62DE1D05926DD7BBD5BE1E;

internal static class Helpers
{
	[DebuggerDisplay("Lazy StrokeClear")]
	internal sealed class tableReader_8be603af0bb34061b0fb4752ae2e869c_Lazy<TInputBuffer> : StrokeClear, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Lazy);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable4 __vtable;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(StrokeClear);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override StrokeLayer Layer
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
		public tableReader_8be603af0bb34061b0fb4752ae2e869c_Lazy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTable4.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static StrokeLayer ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return StrokeLayer.underEverything;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NE4543F7A17A19BDAC3E8E48B10B4F31871AB3F40EC192119FBE1F38F18BF4321.Helpers.Parse(buffer, offset2, remainingDepth);
		}
	}

	[DebuggerDisplay("Progressive StrokeClear")]
	internal sealed class tableReader_8be603af0bb34061b0fb4752ae2e869c_Progressive<TInputBuffer> : StrokeClear, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Progressive);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable4 __vtable;

		private byte __mask0;

		private StrokeLayer __index0Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(StrokeClear);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override StrokeLayer Layer
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
		public tableReader_8be603af0bb34061b0fb4752ae2e869c_Progressive(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTable4.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static StrokeLayer ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return StrokeLayer.underEverything;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NE4543F7A17A19BDAC3E8E48B10B4F31871AB3F40EC192119FBE1F38F18BF4321.Helpers.Parse(buffer, offset2, remainingDepth);
		}
	}

	[DebuggerDisplay("Greedy StrokeClear")]
	internal sealed class tableReader_8be603af0bb34061b0fb4752ae2e869c_Greedy<TInputBuffer> : StrokeClear, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Greedy);

		private StrokeLayer __index0Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(StrokeClear);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override StrokeLayer Layer
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
		public tableReader_8be603af0bb34061b0fb4752ae2e869c_Greedy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTable4.Create(buffer, offset, out var item);
			__index0Value = ReadIndex0Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static StrokeLayer ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return StrokeLayer.underEverything;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NE4543F7A17A19BDAC3E8E48B10B4F31871AB3F40EC192119FBE1F38F18BF4321.Helpers.Parse(buffer, offset2, remainingDepth);
		}
	}

	[DebuggerDisplay("GreedyMutable StrokeClear")]
	internal sealed class tableReader_8be603af0bb34061b0fb4752ae2e869c_GreedyMutable<TInputBuffer> : StrokeClear, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.GreedyMutable);

		private StrokeLayer __index0Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(StrokeClear);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override StrokeLayer Layer
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
		public tableReader_8be603af0bb34061b0fb4752ae2e869c_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTable4.Create(buffer, offset, out var item);
			__index0Value = ReadIndex0Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static StrokeLayer ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return StrokeLayer.underEverything;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NE4543F7A17A19BDAC3E8E48B10B4F31871AB3F40EC192119FBE1F38F18BF4321.Helpers.Parse(buffer, offset2, remainingDepth);
		}
	}

	private static class tableMetadata_b45c421ece1f4cdd93df62091d36eee8
	{
		public static readonly TableFieldContext Layer = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.StrokeClear.Layer", sharedString: false, writeThrough: false);
	}

	internal static int GetMaxSize(StrokeClear value)
	{
		return 15;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, StrokeClear value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int num = context.AllocateSpace(5, 4);
		spanWriter.WriteUOffset(span, offset, num);
		int num2 = num + 4;
		int num3 = 4;
		Span<byte> span2 = stackalloc byte[6];
		StrokeLayer layer = value.Layer;
		int num4 = num;
		if (layer != StrokeLayer.underEverything)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num4 = num2;
			num2++;
			FlatSharp.Compiler.Generated.NE4543F7A17A19BDAC3E8E48B10B4F31871AB3F40EC192119FBE1F38F18BF4321.Helpers.Serialize(spanWriter, span, layer, num4);
			num3 = 6;
		}
		Span<byte> span3 = span2;
		spanWriter.WriteUShort(span3, (ushort)(num4 - num), 4);
		int num5 = num2 - num;
		context.Offset -= 5 - num5;
		Span<byte> span4 = span2;
		spanWriter.WriteUShort(span4, (ushort)num3, 0);
		Span<byte> span5 = span2;
		spanWriter.WriteUShort(span5, (ushort)num5, 2);
		int num6 = context.FinishVTable(span, span2.Slice(0, num3));
		spanWriter.WriteInt(span, num - num6, num);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_8be603af0bb34061b0fb4752ae2e869c_Lazy<TInputBuffer> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_8be603af0bb34061b0fb4752ae2e869c_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_8be603af0bb34061b0fb4752ae2e869c_Progressive<TInputBuffer> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_8be603af0bb34061b0fb4752ae2e869c_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_8be603af0bb34061b0fb4752ae2e869c_Greedy<TInputBuffer> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_8be603af0bb34061b0fb4752ae2e869c_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_8be603af0bb34061b0fb4752ae2e869c_GreedyMutable<TInputBuffer> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_8be603af0bb34061b0fb4752ae2e869c_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}
}
