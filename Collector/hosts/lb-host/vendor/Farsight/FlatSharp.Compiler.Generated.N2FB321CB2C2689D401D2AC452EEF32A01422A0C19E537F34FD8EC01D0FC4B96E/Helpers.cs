using System;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Cinematics;
using FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N2FB321CB2C2689D401D2AC452EEF32A01422A0C19E537F34FD8EC01D0FC4B96E;

internal static class Helpers
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static int GetMaxSize(PropKind value)
	{
		return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.GetMaxSize((byte)value);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, PropKind value, int offset) where TSpanWriter : ISpanWriter
	{
		FlatSharpInternal.AssertSizeOf<PropKind>(1);
		FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Serialize(spanWriter, span, (byte)value, offset);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static PropKind Parse<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		FlatSharpInternal.AssertSizeOf<PropKind>(1);
		return (PropKind)FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset, remainingDepth);
	}
}
