using System;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Commands;
using FlatSharp.Compiler.Generated.N1E4AF840DA947508D3AF090D2CC25201F558B3154B0351D91A6670A9ABEA40CB;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N28ABA73BC29275C0D7E5DD298730C616029DD1364AF31EC2E37FF14A56B21F85;

internal static class Helpers
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static int GetMaxSize(EphemeralType value)
	{
		return FlatSharp.Compiler.Generated.N1E4AF840DA947508D3AF090D2CC25201F558B3154B0351D91A6670A9ABEA40CB.Helpers.GetMaxSize((int)value);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, EphemeralType value, int offset) where TSpanWriter : ISpanWriter
	{
		FlatSharpInternal.AssertSizeOf<EphemeralType>(4);
		FlatSharp.Compiler.Generated.N1E4AF840DA947508D3AF090D2CC25201F558B3154B0351D91A6670A9ABEA40CB.Helpers.Serialize(spanWriter, span, (int)value, offset);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static EphemeralType Parse<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		FlatSharpInternal.AssertSizeOf<EphemeralType>(4);
		return (EphemeralType)FlatSharp.Compiler.Generated.N1E4AF840DA947508D3AF090D2CC25201F558B3154B0351D91A6670A9ABEA40CB.Helpers.Parse(buffer, offset, remainingDepth);
	}
}
