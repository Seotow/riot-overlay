using System;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Entity;
using FlatSharp.Compiler.Generated.ND0FC3ABBD6A762E619D3E4BD7A1716BA78A3C93D12EA9174BE338CC162CE16E9;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N3F1920865B6BBF1D9C63B289DCA193646F88433C1FF3ECF3D8F33DC49969C697;

internal static class Helpers
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static int GetMaxSize(Component? value)
	{
		if (value.HasValue)
		{
			return FlatSharp.Compiler.Generated.ND0FC3ABBD6A762E619D3E4BD7A1716BA78A3C93D12EA9174BE338CC162CE16E9.Helpers.GetMaxSize(value.Value);
		}
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, Component? value, ref (int offset0, int offset1) offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		FlatSharp.Compiler.Generated.ND0FC3ABBD6A762E619D3E4BD7A1716BA78A3C93D12EA9174BE338CC162CE16E9.Helpers.Serialize(spanWriter, span, value.Value, ref offset, context);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static Component? Parse_Lazy<TInputBuffer>(TInputBuffer buffer, ref (int offset0, int offset1) offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return FlatSharp.Compiler.Generated.ND0FC3ABBD6A762E619D3E4BD7A1716BA78A3C93D12EA9174BE338CC162CE16E9.Helpers.Parse_Lazy(buffer, ref offset, remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static Component? Parse_Progressive<TInputBuffer>(TInputBuffer buffer, ref (int offset0, int offset1) offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return FlatSharp.Compiler.Generated.ND0FC3ABBD6A762E619D3E4BD7A1716BA78A3C93D12EA9174BE338CC162CE16E9.Helpers.Parse_Progressive(buffer, ref offset, remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static Component? Parse_Greedy<TInputBuffer>(TInputBuffer buffer, ref (int offset0, int offset1) offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return FlatSharp.Compiler.Generated.ND0FC3ABBD6A762E619D3E4BD7A1716BA78A3C93D12EA9174BE338CC162CE16E9.Helpers.Parse_Greedy(buffer, ref offset, remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static Component? Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, ref (int offset0, int offset1) offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return FlatSharp.Compiler.Generated.ND0FC3ABBD6A762E619D3E4BD7A1716BA78A3C93D12EA9174BE338CC162CE16E9.Helpers.Parse_GreedyMutable(buffer, ref offset, remainingDepth);
	}
}
