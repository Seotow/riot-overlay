using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Commands;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N3C5509FB15221355E65D4EC0AA8D3F66CF04B2B065D09BCA9BECBFFA4669ABAB;

internal static class Helpers
{
	[DebuggerDisplay("Lazy GetCinematicCameraPose")]
	internal sealed class tableReader_64ae02228c5e413a8e5f296453b6370c_Lazy<TInputBuffer> : GetCinematicCameraPose, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Lazy);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable4 __vtable;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(GetCinematicCameraPose);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_64ae02228c5e413a8e5f296453b6370c_Lazy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTable4.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}
	}

	[DebuggerDisplay("Progressive GetCinematicCameraPose")]
	internal sealed class tableReader_64ae02228c5e413a8e5f296453b6370c_Progressive<TInputBuffer> : GetCinematicCameraPose, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Progressive);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable4 __vtable;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(GetCinematicCameraPose);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_64ae02228c5e413a8e5f296453b6370c_Progressive(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTable4.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}
	}

	[DebuggerDisplay("Greedy GetCinematicCameraPose")]
	internal sealed class tableReader_64ae02228c5e413a8e5f296453b6370c_Greedy<TInputBuffer> : GetCinematicCameraPose, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Greedy);

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(GetCinematicCameraPose);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_64ae02228c5e413a8e5f296453b6370c_Greedy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTable4.Create(buffer, offset, out var _);
			OnFlatSharpDeserialized(__CtorContext);
		}
	}

	[DebuggerDisplay("GreedyMutable GetCinematicCameraPose")]
	internal sealed class tableReader_64ae02228c5e413a8e5f296453b6370c_GreedyMutable<TInputBuffer> : GetCinematicCameraPose, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.GreedyMutable);

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(GetCinematicCameraPose);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_64ae02228c5e413a8e5f296453b6370c_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTable4.Create(buffer, offset, out var _);
			OnFlatSharpDeserialized(__CtorContext);
		}
	}

	private static class tableMetadata_73a06d8eb39c4e7cbe147cda251c302c
	{
	}

	internal static int GetMaxSize(GetCinematicCameraPose value)
	{
		return 12;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, GetCinematicCameraPose value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int num = context.AllocateSpace(4, 4);
		spanWriter.WriteUOffset(span, offset, num);
		int num2 = num + 4;
		int num3 = 4;
		Span<byte> span2 = stackalloc byte[4];
		int num4 = num2 - num;
		context.Offset -= 4 - num4;
		Span<byte> span3 = span2;
		spanWriter.WriteUShort(span3, (ushort)num3, 0);
		Span<byte> span4 = span2;
		spanWriter.WriteUShort(span4, (ushort)num4, 2);
		int num5 = context.FinishVTable(span, span2.Slice(0, num3));
		spanWriter.WriteInt(span, num - num5, num);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_64ae02228c5e413a8e5f296453b6370c_Lazy<TInputBuffer> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_64ae02228c5e413a8e5f296453b6370c_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_64ae02228c5e413a8e5f296453b6370c_Progressive<TInputBuffer> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_64ae02228c5e413a8e5f296453b6370c_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_64ae02228c5e413a8e5f296453b6370c_Greedy<TInputBuffer> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_64ae02228c5e413a8e5f296453b6370c_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_64ae02228c5e413a8e5f296453b6370c_GreedyMutable<TInputBuffer> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_64ae02228c5e413a8e5f296453b6370c_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}
}
