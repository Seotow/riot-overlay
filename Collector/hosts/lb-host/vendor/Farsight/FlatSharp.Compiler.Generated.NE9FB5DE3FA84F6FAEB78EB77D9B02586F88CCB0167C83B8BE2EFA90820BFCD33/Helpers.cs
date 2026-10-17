using System;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Scene;
using FlatSharp.Compiler.Generated.N24093915935F05E78C89CDA6E52CB640E1487D4E5C0277B6B0B64502779D9C32;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.NE9FB5DE3FA84F6FAEB78EB77D9B02586F88CCB0167C83B8BE2EFA90820BFCD33;

internal static class Helpers
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static int GetMaxSize(SceneCommand? value)
	{
		if (value.HasValue)
		{
			return FlatSharp.Compiler.Generated.N24093915935F05E78C89CDA6E52CB640E1487D4E5C0277B6B0B64502779D9C32.Helpers.GetMaxSize(value.Value);
		}
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, SceneCommand? value, ref (int offset0, int offset1) offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		FlatSharp.Compiler.Generated.N24093915935F05E78C89CDA6E52CB640E1487D4E5C0277B6B0B64502779D9C32.Helpers.Serialize(spanWriter, span, value.Value, ref offset, context);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static SceneCommand? Parse_Lazy<TInputBuffer>(TInputBuffer buffer, ref (int offset0, int offset1) offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return FlatSharp.Compiler.Generated.N24093915935F05E78C89CDA6E52CB640E1487D4E5C0277B6B0B64502779D9C32.Helpers.Parse_Lazy(buffer, ref offset, remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static SceneCommand? Parse_Progressive<TInputBuffer>(TInputBuffer buffer, ref (int offset0, int offset1) offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return FlatSharp.Compiler.Generated.N24093915935F05E78C89CDA6E52CB640E1487D4E5C0277B6B0B64502779D9C32.Helpers.Parse_Progressive(buffer, ref offset, remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static SceneCommand? Parse_Greedy<TInputBuffer>(TInputBuffer buffer, ref (int offset0, int offset1) offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return FlatSharp.Compiler.Generated.N24093915935F05E78C89CDA6E52CB640E1487D4E5C0277B6B0B64502779D9C32.Helpers.Parse_Greedy(buffer, ref offset, remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static SceneCommand? Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, ref (int offset0, int offset1) offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return FlatSharp.Compiler.Generated.N24093915935F05E78C89CDA6E52CB640E1487D4E5C0277B6B0B64502779D9C32.Helpers.Parse_GreedyMutable(buffer, ref offset, remainingDepth);
	}
}
