using System;
using System.Runtime.CompilerServices;

namespace FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B;

internal static class Helpers
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static int GetMaxSize(byte value)
	{
		return 1;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, byte value, int offset) where TSpanWriter : ISpanWriter
	{
		spanWriter.WriteByte(span, value, offset);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static byte Parse<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return buffer.ReadByte(offset);
	}
}
