using System;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Common;
using FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.ND947104E7969952557C54C9055CF59C7471A6BF89368F407490E5EB3993416BD;

internal static class Helpers
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static int GetMaxSize(StrokeTimeMode value)
	{
		return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.GetMaxSize((byte)value);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, StrokeTimeMode value, int offset) where TSpanWriter : ISpanWriter
	{
		FlatSharpInternal.AssertSizeOf<StrokeTimeMode>(1);
		FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Serialize(spanWriter, span, (byte)value, offset);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static StrokeTimeMode Parse<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		FlatSharpInternal.AssertSizeOf<StrokeTimeMode>(1);
		return (StrokeTimeMode)FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset, remainingDepth);
	}
}
