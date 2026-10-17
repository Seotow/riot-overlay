using System;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Sequencer;
using FlatSharp.Compiler.Generated.N0AFFB983BCD73E3E4397419443518E0C3146D1C306BE83ED1DC16963F22F2797;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N31FE0F0224F92B231F88614AD0F8236954E9CF3F3B13D02C15B3B9AF2BAACA5C;

internal static class Helpers
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static int GetMaxSize(SeqProperty value)
	{
		return FlatSharp.Compiler.Generated.N0AFFB983BCD73E3E4397419443518E0C3146D1C306BE83ED1DC16963F22F2797.Helpers.GetMaxSize((ushort)value);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, SeqProperty value, int offset) where TSpanWriter : ISpanWriter
	{
		FlatSharpInternal.AssertSizeOf<SeqProperty>(2);
		FlatSharp.Compiler.Generated.N0AFFB983BCD73E3E4397419443518E0C3146D1C306BE83ED1DC16963F22F2797.Helpers.Serialize(spanWriter, span, (ushort)value, offset);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static SeqProperty Parse<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		FlatSharpInternal.AssertSizeOf<SeqProperty>(2);
		return (SeqProperty)FlatSharp.Compiler.Generated.N0AFFB983BCD73E3E4397419443518E0C3146D1C306BE83ED1DC16963F22F2797.Helpers.Parse(buffer, offset, remainingDepth);
	}
}
