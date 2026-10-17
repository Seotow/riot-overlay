using System;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Sequencer;
using FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N6A6B0E479B063354DAC88EEB4024310FB767386C3B7C666FA4216EFF45283D3B;

internal static class Helpers
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static int GetMaxSize(CameraHold value)
	{
		return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.GetMaxSize((byte)value);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, CameraHold value, int offset) where TSpanWriter : ISpanWriter
	{
		FlatSharpInternal.AssertSizeOf<CameraHold>(1);
		FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Serialize(spanWriter, span, (byte)value, offset);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static CameraHold Parse<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		FlatSharpInternal.AssertSizeOf<CameraHold>(1);
		return (CameraHold)FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset, remainingDepth);
	}
}
