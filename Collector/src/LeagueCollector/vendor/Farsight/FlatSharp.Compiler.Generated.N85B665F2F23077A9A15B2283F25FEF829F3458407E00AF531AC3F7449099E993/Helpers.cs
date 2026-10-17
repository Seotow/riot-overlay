using System;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Scene;
using FlatSharp.Compiler.Generated.NA7A311B0690AA39F2735FD1122760D58C582E48C599154E7F379CA9A95FC9701;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N85B665F2F23077A9A15B2283F25FEF829F3458407E00AF531AC3F7449099E993;

internal static class Helpers
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static int GetMaxSize(SceneEvent? value)
	{
		if (value.HasValue)
		{
			return FlatSharp.Compiler.Generated.NA7A311B0690AA39F2735FD1122760D58C582E48C599154E7F379CA9A95FC9701.Helpers.GetMaxSize(value.Value);
		}
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, SceneEvent? value, ref (int offset0, int offset1) offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		FlatSharp.Compiler.Generated.NA7A311B0690AA39F2735FD1122760D58C582E48C599154E7F379CA9A95FC9701.Helpers.Serialize(spanWriter, span, value.Value, ref offset, context);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static SceneEvent? Parse_Lazy<TInputBuffer>(TInputBuffer buffer, ref (int offset0, int offset1) offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return FlatSharp.Compiler.Generated.NA7A311B0690AA39F2735FD1122760D58C582E48C599154E7F379CA9A95FC9701.Helpers.Parse_Lazy(buffer, ref offset, remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static SceneEvent? Parse_Progressive<TInputBuffer>(TInputBuffer buffer, ref (int offset0, int offset1) offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return FlatSharp.Compiler.Generated.NA7A311B0690AA39F2735FD1122760D58C582E48C599154E7F379CA9A95FC9701.Helpers.Parse_Progressive(buffer, ref offset, remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static SceneEvent? Parse_Greedy<TInputBuffer>(TInputBuffer buffer, ref (int offset0, int offset1) offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return FlatSharp.Compiler.Generated.NA7A311B0690AA39F2735FD1122760D58C582E48C599154E7F379CA9A95FC9701.Helpers.Parse_Greedy(buffer, ref offset, remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static SceneEvent? Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, ref (int offset0, int offset1) offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return FlatSharp.Compiler.Generated.NA7A311B0690AA39F2735FD1122760D58C582E48C599154E7F379CA9A95FC9701.Helpers.Parse_GreedyMutable(buffer, ref offset, remainingDepth);
	}
}
