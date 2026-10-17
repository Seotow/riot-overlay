using System;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Snapshot;
using FlatSharp.Compiler.Generated.NF791D2E6738D8D71C1ED7ED9BDD6F7BD5F9764E8D74B3B291F9458C27ED6DFDB;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.NAC7DDA8859DCBCCACE54EFAE2618BA22D47FFD5D942AEE4479065491004BAB75;

internal static class Helpers
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static int GetMaxSize(DamageType value)
	{
		return FlatSharp.Compiler.Generated.NF791D2E6738D8D71C1ED7ED9BDD6F7BD5F9764E8D74B3B291F9458C27ED6DFDB.Helpers.GetMaxSize((sbyte)value);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, DamageType value, int offset) where TSpanWriter : ISpanWriter
	{
		FlatSharpInternal.AssertSizeOf<DamageType>(1);
		FlatSharp.Compiler.Generated.NF791D2E6738D8D71C1ED7ED9BDD6F7BD5F9764E8D74B3B291F9458C27ED6DFDB.Helpers.Serialize(spanWriter, span, (sbyte)value, offset);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static DamageType Parse<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		FlatSharpInternal.AssertSizeOf<DamageType>(1);
		return (DamageType)FlatSharp.Compiler.Generated.NF791D2E6738D8D71C1ED7ED9BDD6F7BD5F9764E8D74B3B291F9458C27ED6DFDB.Helpers.Parse(buffer, offset, remainingDepth);
	}
}
