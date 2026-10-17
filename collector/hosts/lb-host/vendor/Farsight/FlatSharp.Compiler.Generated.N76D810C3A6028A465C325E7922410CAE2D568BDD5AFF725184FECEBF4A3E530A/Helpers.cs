using System;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Common;
using FlatSharp.Compiler.Generated.NCEC2F0D05AF9395C0164E24CE39F678726CFF591F05937761313B185A9B82299;

namespace FlatSharp.Compiler.Generated.N76D810C3A6028A465C325E7922410CAE2D568BDD5AFF725184FECEBF4A3E530A;

internal static class Helpers
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static int GetMaxSize(Vector4? value)
	{
		if (value.HasValue)
		{
			return FlatSharp.Compiler.Generated.NCEC2F0D05AF9395C0164E24CE39F678726CFF591F05937761313B185A9B82299.Helpers.GetMaxSize(value.Value);
		}
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, Vector4? value, int offset) where TSpanWriter : ISpanWriter
	{
		FlatSharp.Compiler.Generated.NCEC2F0D05AF9395C0164E24CE39F678726CFF591F05937761313B185A9B82299.Helpers.Serialize(spanWriter, span, value.Value, offset);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static Vector4? Parse<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return FlatSharp.Compiler.Generated.NCEC2F0D05AF9395C0164E24CE39F678726CFF591F05937761313B185A9B82299.Helpers.Parse(buffer, offset, remainingDepth);
	}
}
