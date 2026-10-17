using System;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Commands;
using FlatSharp.Compiler.Generated.N1E4AF840DA947508D3AF090D2CC25201F558B3154B0351D91A6670A9ABEA40CB;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.NA53FEC86DB82BADC52052C475CF3A35C00D87795922932982A89D46161521271;

internal static class Helpers
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static int GetMaxSize(ServiceType value)
	{
		return FlatSharp.Compiler.Generated.N1E4AF840DA947508D3AF090D2CC25201F558B3154B0351D91A6670A9ABEA40CB.Helpers.GetMaxSize((int)value);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, ServiceType value, int offset) where TSpanWriter : ISpanWriter
	{
		FlatSharpInternal.AssertSizeOf<ServiceType>(4);
		FlatSharp.Compiler.Generated.N1E4AF840DA947508D3AF090D2CC25201F558B3154B0351D91A6670A9ABEA40CB.Helpers.Serialize(spanWriter, span, (int)value, offset);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static ServiceType Parse<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		FlatSharpInternal.AssertSizeOf<ServiceType>(4);
		return (ServiceType)FlatSharp.Compiler.Generated.N1E4AF840DA947508D3AF090D2CC25201F558B3154B0351D91A6670A9ABEA40CB.Helpers.Parse(buffer, offset, remainingDepth);
	}
}
