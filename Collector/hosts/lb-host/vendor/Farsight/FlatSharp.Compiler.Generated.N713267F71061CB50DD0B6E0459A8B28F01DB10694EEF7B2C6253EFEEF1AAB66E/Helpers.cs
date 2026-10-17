using System;
using System.Runtime.CompilerServices;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E;

internal static class Helpers
{
	internal static int GetMaxSize(string value)
	{
		return SerializationHelpers.GetMaxSize(value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, string value, int offset, SerializationContext context, TableFieldContext fieldContext) where TSpanWriter : ISpanWriter
	{
		spanWriter.WriteString(span, value, offset, context);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static string Parse<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return buffer.ReadString(offset);
	}
}
