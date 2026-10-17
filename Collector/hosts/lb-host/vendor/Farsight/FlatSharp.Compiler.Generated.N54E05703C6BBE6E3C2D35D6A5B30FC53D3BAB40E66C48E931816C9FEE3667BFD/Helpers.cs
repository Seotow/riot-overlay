using System;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Commands;
using FlatSharp.Compiler.Generated.N0BAFF7A40EE4D47DD5A0C31E765431DED7F7991F87F361BA2E26D31AA95022FD;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N54E05703C6BBE6E3C2D35D6A5B30FC53D3BAB40E66C48E931816C9FEE3667BFD;

internal static class Helpers
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static int GetMaxSize(CameraPreviewController? value)
	{
		if (value.HasValue)
		{
			return FlatSharp.Compiler.Generated.N0BAFF7A40EE4D47DD5A0C31E765431DED7F7991F87F361BA2E26D31AA95022FD.Helpers.GetMaxSize(value.Value);
		}
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, CameraPreviewController? value, ref (int offset0, int offset1) offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		FlatSharp.Compiler.Generated.N0BAFF7A40EE4D47DD5A0C31E765431DED7F7991F87F361BA2E26D31AA95022FD.Helpers.Serialize(spanWriter, span, value.Value, ref offset, context);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static CameraPreviewController? Parse_Lazy<TInputBuffer>(TInputBuffer buffer, ref (int offset0, int offset1) offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return FlatSharp.Compiler.Generated.N0BAFF7A40EE4D47DD5A0C31E765431DED7F7991F87F361BA2E26D31AA95022FD.Helpers.Parse_Lazy(buffer, ref offset, remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static CameraPreviewController? Parse_Progressive<TInputBuffer>(TInputBuffer buffer, ref (int offset0, int offset1) offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return FlatSharp.Compiler.Generated.N0BAFF7A40EE4D47DD5A0C31E765431DED7F7991F87F361BA2E26D31AA95022FD.Helpers.Parse_Progressive(buffer, ref offset, remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static CameraPreviewController? Parse_Greedy<TInputBuffer>(TInputBuffer buffer, ref (int offset0, int offset1) offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return FlatSharp.Compiler.Generated.N0BAFF7A40EE4D47DD5A0C31E765431DED7F7991F87F361BA2E26D31AA95022FD.Helpers.Parse_Greedy(buffer, ref offset, remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static CameraPreviewController? Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, ref (int offset0, int offset1) offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return FlatSharp.Compiler.Generated.N0BAFF7A40EE4D47DD5A0C31E765431DED7F7991F87F361BA2E26D31AA95022FD.Helpers.Parse_GreedyMutable(buffer, ref offset, remainingDepth);
	}
}
