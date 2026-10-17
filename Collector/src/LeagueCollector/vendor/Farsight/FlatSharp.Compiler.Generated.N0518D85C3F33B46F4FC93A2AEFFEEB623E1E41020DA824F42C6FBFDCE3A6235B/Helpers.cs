using System;
using System.Runtime.CompilerServices;
using FlatSharp.Compiler.Generated.N331F001CF321CF11BC240659FDA5763A47292410D345E51BA8E5F3343A16B6FB;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N0518D85C3F33B46F4FC93A2AEFFEEB623E1E41020DA824F42C6FBFDCE3A6235B;

internal static class Helpers
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static int GetMaxSize(Memory<byte>? value)
	{
		if (value.HasValue)
		{
			return FlatSharp.Compiler.Generated.N331F001CF321CF11BC240659FDA5763A47292410D345E51BA8E5F3343A16B6FB.Helpers.GetMaxSize(value.Value);
		}
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, Memory<byte>? value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		FlatSharp.Compiler.Generated.N331F001CF321CF11BC240659FDA5763A47292410D345E51BA8E5F3343A16B6FB.Helpers.Serialize(spanWriter, span, value.Value, offset, context);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static Memory<byte>? Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return FlatSharp.Compiler.Generated.N331F001CF321CF11BC240659FDA5763A47292410D345E51BA8E5F3343A16B6FB.Helpers.Parse_Lazy(buffer, offset, remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static Memory<byte>? Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return FlatSharp.Compiler.Generated.N331F001CF321CF11BC240659FDA5763A47292410D345E51BA8E5F3343A16B6FB.Helpers.Parse_Progressive(buffer, offset, remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static Memory<byte>? Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return FlatSharp.Compiler.Generated.N331F001CF321CF11BC240659FDA5763A47292410D345E51BA8E5F3343A16B6FB.Helpers.Parse_Greedy(buffer, offset, remainingDepth, fieldContext);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static Memory<byte>? Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return FlatSharp.Compiler.Generated.N331F001CF321CF11BC240659FDA5763A47292410D345E51BA8E5F3343A16B6FB.Helpers.Parse_GreedyMutable(buffer, offset, remainingDepth, fieldContext);
	}
}
