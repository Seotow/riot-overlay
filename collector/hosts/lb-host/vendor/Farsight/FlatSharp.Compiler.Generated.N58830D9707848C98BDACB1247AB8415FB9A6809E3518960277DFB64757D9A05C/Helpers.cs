using System;
using System.Runtime.CompilerServices;

namespace FlatSharp.Compiler.Generated.N58830D9707848C98BDACB1247AB8415FB9A6809E3518960277DFB64757D9A05C;

internal static class Helpers
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static int GetMaxSize(long value)
	{
		return 15;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, long value, int offset) where TSpanWriter : ISpanWriter
	{
		spanWriter.WriteLong(span, value, offset);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static long Parse<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return buffer.ReadLong(offset);
	}
}
