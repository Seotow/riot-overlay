using System;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Commands;
using FlatSharp.Compiler.Generated.N8AF2E8D70D9EA2C75456E14AB467A92F39A075C72041E13BECBA1AEC69608F2B;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N3FED263F69F3A17D1EC89200C766335591F8A541CF115B0D7E8F82E9F52AF150;

internal static class Helpers
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static int GetMaxSize(CameraPreviewLayout? value)
	{
		if (value.HasValue)
		{
			return FlatSharp.Compiler.Generated.N8AF2E8D70D9EA2C75456E14AB467A92F39A075C72041E13BECBA1AEC69608F2B.Helpers.GetMaxSize(value.Value);
		}
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, CameraPreviewLayout? value, ref (int offset0, int offset1) offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		FlatSharp.Compiler.Generated.N8AF2E8D70D9EA2C75456E14AB467A92F39A075C72041E13BECBA1AEC69608F2B.Helpers.Serialize(spanWriter, span, value.Value, ref offset, context);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static CameraPreviewLayout? Parse_Lazy<TInputBuffer>(TInputBuffer buffer, ref (int offset0, int offset1) offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return FlatSharp.Compiler.Generated.N8AF2E8D70D9EA2C75456E14AB467A92F39A075C72041E13BECBA1AEC69608F2B.Helpers.Parse_Lazy(buffer, ref offset, remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static CameraPreviewLayout? Parse_Progressive<TInputBuffer>(TInputBuffer buffer, ref (int offset0, int offset1) offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return FlatSharp.Compiler.Generated.N8AF2E8D70D9EA2C75456E14AB467A92F39A075C72041E13BECBA1AEC69608F2B.Helpers.Parse_Progressive(buffer, ref offset, remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static CameraPreviewLayout? Parse_Greedy<TInputBuffer>(TInputBuffer buffer, ref (int offset0, int offset1) offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return FlatSharp.Compiler.Generated.N8AF2E8D70D9EA2C75456E14AB467A92F39A075C72041E13BECBA1AEC69608F2B.Helpers.Parse_Greedy(buffer, ref offset, remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static CameraPreviewLayout? Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, ref (int offset0, int offset1) offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return FlatSharp.Compiler.Generated.N8AF2E8D70D9EA2C75456E14AB467A92F39A075C72041E13BECBA1AEC69608F2B.Helpers.Parse_GreedyMutable(buffer, ref offset, remainingDepth);
	}
}
