using System;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Commands;
using FlatSharp.Compiler.Generated.N989B0F7289FBD127714931ECDBF38FBC2858754130D66EE0DE38A0FD12AE718F;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.NBF3EAEE57690B092ED1D2E054980F76027824459C9F5C031FB194140268D7F56;

internal static class Helpers
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static int GetMaxSize(RequestKind? value)
	{
		if (value.HasValue)
		{
			return FlatSharp.Compiler.Generated.N989B0F7289FBD127714931ECDBF38FBC2858754130D66EE0DE38A0FD12AE718F.Helpers.GetMaxSize(value.Value);
		}
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, RequestKind? value, ref (int offset0, int offset1) offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		FlatSharp.Compiler.Generated.N989B0F7289FBD127714931ECDBF38FBC2858754130D66EE0DE38A0FD12AE718F.Helpers.Serialize(spanWriter, span, value.Value, ref offset, context);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static RequestKind? Parse_Lazy<TInputBuffer>(TInputBuffer buffer, ref (int offset0, int offset1) offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return FlatSharp.Compiler.Generated.N989B0F7289FBD127714931ECDBF38FBC2858754130D66EE0DE38A0FD12AE718F.Helpers.Parse_Lazy(buffer, ref offset, remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static RequestKind? Parse_Progressive<TInputBuffer>(TInputBuffer buffer, ref (int offset0, int offset1) offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return FlatSharp.Compiler.Generated.N989B0F7289FBD127714931ECDBF38FBC2858754130D66EE0DE38A0FD12AE718F.Helpers.Parse_Progressive(buffer, ref offset, remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static RequestKind? Parse_Greedy<TInputBuffer>(TInputBuffer buffer, ref (int offset0, int offset1) offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return FlatSharp.Compiler.Generated.N989B0F7289FBD127714931ECDBF38FBC2858754130D66EE0DE38A0FD12AE718F.Helpers.Parse_Greedy(buffer, ref offset, remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static RequestKind? Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, ref (int offset0, int offset1) offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return FlatSharp.Compiler.Generated.N989B0F7289FBD127714931ECDBF38FBC2858754130D66EE0DE38A0FD12AE718F.Helpers.Parse_GreedyMutable(buffer, ref offset, remainingDepth);
	}
}
