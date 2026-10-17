using System;
using System.Runtime.CompilerServices;

namespace FlatSharp.Compiler.Generated.N545AE763FCB09A83BCE26918943ECB13F299E8BBD30EBC1FE03FA871EC94C291;

internal static class Helpers
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static int GetMaxSize(uint value)
	{
		return 7;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, uint value, int offset) where TSpanWriter : ISpanWriter
	{
		spanWriter.WriteUInt(span, value, offset);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static uint Parse<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return buffer.ReadUInt(offset);
	}
}
