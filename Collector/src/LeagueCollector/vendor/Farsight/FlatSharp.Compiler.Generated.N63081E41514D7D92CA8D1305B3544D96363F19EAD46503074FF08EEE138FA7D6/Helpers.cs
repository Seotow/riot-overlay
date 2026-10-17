using System;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Snapshot;
using FlatSharp.Compiler.Generated.NF791D2E6738D8D71C1ED7ED9BDD6F7BD5F9764E8D74B3B291F9458C27ED6DFDB;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N63081E41514D7D92CA8D1305B3544D96363F19EAD46503074FF08EEE138FA7D6;

internal static class Helpers
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static int GetMaxSize(AttackSuccessFlag value)
	{
		return FlatSharp.Compiler.Generated.NF791D2E6738D8D71C1ED7ED9BDD6F7BD5F9764E8D74B3B291F9458C27ED6DFDB.Helpers.GetMaxSize((sbyte)value);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, AttackSuccessFlag value, int offset) where TSpanWriter : ISpanWriter
	{
		FlatSharpInternal.AssertSizeOf<AttackSuccessFlag>(1);
		FlatSharp.Compiler.Generated.NF791D2E6738D8D71C1ED7ED9BDD6F7BD5F9764E8D74B3B291F9458C27ED6DFDB.Helpers.Serialize(spanWriter, span, (sbyte)value, offset);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static AttackSuccessFlag Parse<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		FlatSharpInternal.AssertSizeOf<AttackSuccessFlag>(1);
		return (AttackSuccessFlag)FlatSharp.Compiler.Generated.NF791D2E6738D8D71C1ED7ED9BDD6F7BD5F9764E8D74B3B291F9458C27ED6DFDB.Helpers.Parse(buffer, offset, remainingDepth);
	}
}
