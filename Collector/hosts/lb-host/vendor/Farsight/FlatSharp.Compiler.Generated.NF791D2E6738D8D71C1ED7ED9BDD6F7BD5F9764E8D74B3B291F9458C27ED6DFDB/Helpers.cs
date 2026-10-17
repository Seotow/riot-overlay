using System;
using System.Runtime.CompilerServices;

namespace FlatSharp.Compiler.Generated.NF791D2E6738D8D71C1ED7ED9BDD6F7BD5F9764E8D74B3B291F9458C27ED6DFDB;

internal static class Helpers
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static int GetMaxSize(sbyte value)
	{
		return 1;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, sbyte value, int offset) where TSpanWriter : ISpanWriter
	{
		spanWriter.WriteSByte(span, value, offset);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static sbyte Parse<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return buffer.ReadSByte(offset);
	}
}
