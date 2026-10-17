using System;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Commands;
using FlatSharp.Compiler.Generated.N33A46280AD6A39199F144532F1B2B4B3289530A1286BF624B13CC410E3FAEA0B;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N1190730C6866BC23A7F8BE352B86AB277DF24DE19318F20B128389AC0377EC4D;

internal static class Helpers
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static int GetMaxSize(DrawingCommand? value)
	{
		if (value.HasValue)
		{
			return FlatSharp.Compiler.Generated.N33A46280AD6A39199F144532F1B2B4B3289530A1286BF624B13CC410E3FAEA0B.Helpers.GetMaxSize(value.Value);
		}
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, DrawingCommand? value, ref (int offset0, int offset1) offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		FlatSharp.Compiler.Generated.N33A46280AD6A39199F144532F1B2B4B3289530A1286BF624B13CC410E3FAEA0B.Helpers.Serialize(spanWriter, span, value.Value, ref offset, context);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static DrawingCommand? Parse_Lazy<TInputBuffer>(TInputBuffer buffer, ref (int offset0, int offset1) offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return FlatSharp.Compiler.Generated.N33A46280AD6A39199F144532F1B2B4B3289530A1286BF624B13CC410E3FAEA0B.Helpers.Parse_Lazy(buffer, ref offset, remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static DrawingCommand? Parse_Progressive<TInputBuffer>(TInputBuffer buffer, ref (int offset0, int offset1) offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return FlatSharp.Compiler.Generated.N33A46280AD6A39199F144532F1B2B4B3289530A1286BF624B13CC410E3FAEA0B.Helpers.Parse_Progressive(buffer, ref offset, remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static DrawingCommand? Parse_Greedy<TInputBuffer>(TInputBuffer buffer, ref (int offset0, int offset1) offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return FlatSharp.Compiler.Generated.N33A46280AD6A39199F144532F1B2B4B3289530A1286BF624B13CC410E3FAEA0B.Helpers.Parse_Greedy(buffer, ref offset, remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static DrawingCommand? Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, ref (int offset0, int offset1) offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return FlatSharp.Compiler.Generated.N33A46280AD6A39199F144532F1B2B4B3289530A1286BF624B13CC410E3FAEA0B.Helpers.Parse_GreedyMutable(buffer, ref offset, remainingDepth);
	}
}
