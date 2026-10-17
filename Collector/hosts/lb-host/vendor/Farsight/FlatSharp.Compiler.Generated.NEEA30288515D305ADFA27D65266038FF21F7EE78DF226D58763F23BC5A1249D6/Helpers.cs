using System;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Commands;
using FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.NEEA30288515D305ADFA27D65266038FF21F7EE78DF226D58763F23BC5A1249D6;

internal static class Helpers
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static int GetMaxSize(HudPanelAlignY value)
	{
		return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.GetMaxSize((byte)value);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, HudPanelAlignY value, int offset) where TSpanWriter : ISpanWriter
	{
		FlatSharpInternal.AssertSizeOf<HudPanelAlignY>(1);
		FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Serialize(spanWriter, span, (byte)value, offset);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static HudPanelAlignY Parse<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		FlatSharpInternal.AssertSizeOf<HudPanelAlignY>(1);
		return (HudPanelAlignY)FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset, remainingDepth);
	}
}
