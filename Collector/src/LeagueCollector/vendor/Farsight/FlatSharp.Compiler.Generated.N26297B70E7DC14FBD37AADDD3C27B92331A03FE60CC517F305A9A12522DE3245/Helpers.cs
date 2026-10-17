using System;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Commands;
using FlatSharp.Compiler.Generated.N42DA1EEA183F24DBE911A87BEA641D42F4F864E6E6B0686B319E1BDFC7096ABD;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N26297B70E7DC14FBD37AADDD3C27B92331A03FE60CC517F305A9A12522DE3245;

internal static class Helpers
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static int GetMaxSize(AssetIdentifier? value)
	{
		if (value.HasValue)
		{
			return FlatSharp.Compiler.Generated.N42DA1EEA183F24DBE911A87BEA641D42F4F864E6E6B0686B319E1BDFC7096ABD.Helpers.GetMaxSize(value.Value);
		}
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, AssetIdentifier? value, ref (int offset0, int offset1) offset, SerializationContext context, TableFieldContext fieldContext) where TSpanWriter : ISpanWriter
	{
		FlatSharp.Compiler.Generated.N42DA1EEA183F24DBE911A87BEA641D42F4F864E6E6B0686B319E1BDFC7096ABD.Helpers.Serialize(spanWriter, span, value.Value, ref offset, context, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static AssetIdentifier? Parse_Lazy<TInputBuffer>(TInputBuffer buffer, ref (int offset0, int offset1) offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return FlatSharp.Compiler.Generated.N42DA1EEA183F24DBE911A87BEA641D42F4F864E6E6B0686B319E1BDFC7096ABD.Helpers.Parse_Lazy(buffer, ref offset, remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static AssetIdentifier? Parse_Progressive<TInputBuffer>(TInputBuffer buffer, ref (int offset0, int offset1) offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return FlatSharp.Compiler.Generated.N42DA1EEA183F24DBE911A87BEA641D42F4F864E6E6B0686B319E1BDFC7096ABD.Helpers.Parse_Progressive(buffer, ref offset, remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static AssetIdentifier? Parse_Greedy<TInputBuffer>(TInputBuffer buffer, ref (int offset0, int offset1) offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return FlatSharp.Compiler.Generated.N42DA1EEA183F24DBE911A87BEA641D42F4F864E6E6B0686B319E1BDFC7096ABD.Helpers.Parse_Greedy(buffer, ref offset, remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static AssetIdentifier? Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, ref (int offset0, int offset1) offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return FlatSharp.Compiler.Generated.N42DA1EEA183F24DBE911A87BEA641D42F4F864E6E6B0686B319E1BDFC7096ABD.Helpers.Parse_GreedyMutable(buffer, ref offset, remainingDepth);
	}
}
