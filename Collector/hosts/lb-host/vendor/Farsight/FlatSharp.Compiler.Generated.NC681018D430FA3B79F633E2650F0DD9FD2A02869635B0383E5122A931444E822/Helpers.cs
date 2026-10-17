using System;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Cinematics;
using FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.NC681018D430FA3B79F633E2650F0DD9FD2A02869635B0383E5122A931444E822;

internal static class Helpers
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static int GetMaxSize(TeamSlot value)
	{
		return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.GetMaxSize((byte)value);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, TeamSlot value, int offset) where TSpanWriter : ISpanWriter
	{
		FlatSharpInternal.AssertSizeOf<TeamSlot>(1);
		FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Serialize(spanWriter, span, (byte)value, offset);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static TeamSlot Parse<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		FlatSharpInternal.AssertSizeOf<TeamSlot>(1);
		return (TeamSlot)FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset, remainingDepth);
	}
}
