using System;
using System.Runtime.CompilerServices;

namespace FlatSharp.Compiler.Generated.N69778B0A505EF22DDC87C3C5ACB43FEC37AE9060433697AE39F2F466540F7A19;

internal static class Helpers
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static int GetMaxSize(double value)
	{
		return 15;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, double value, int offset) where TSpanWriter : ISpanWriter
	{
		spanWriter.WriteDouble(span, value, offset);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static double Parse<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return buffer.ReadDouble(offset);
	}
}
