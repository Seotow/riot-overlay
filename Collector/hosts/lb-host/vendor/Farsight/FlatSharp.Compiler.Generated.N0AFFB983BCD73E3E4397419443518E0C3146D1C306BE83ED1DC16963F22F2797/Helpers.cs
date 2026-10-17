using System;
using System.Runtime.CompilerServices;

namespace FlatSharp.Compiler.Generated.N0AFFB983BCD73E3E4397419443518E0C3146D1C306BE83ED1DC16963F22F2797;

internal static class Helpers
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static int GetMaxSize(ushort value)
	{
		return 3;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, ushort value, int offset) where TSpanWriter : ISpanWriter
	{
		spanWriter.WriteUShort(span, value, offset);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static ushort Parse<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return buffer.ReadUShort(offset);
	}
}
