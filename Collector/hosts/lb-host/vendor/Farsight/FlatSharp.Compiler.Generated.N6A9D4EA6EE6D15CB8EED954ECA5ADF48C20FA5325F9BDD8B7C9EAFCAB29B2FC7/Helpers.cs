using System;
using System.Runtime.CompilerServices;
using FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72;

namespace FlatSharp.Compiler.Generated.N6A9D4EA6EE6D15CB8EED954ECA5ADF48C20FA5325F9BDD8B7C9EAFCAB29B2FC7;

internal static class Helpers
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static int GetMaxSize(bool? value)
	{
		if (value.HasValue)
		{
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.GetMaxSize(value.Value);
		}
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, bool? value, int offset) where TSpanWriter : ISpanWriter
	{
		FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Serialize(spanWriter, span, value.Value, offset);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static bool? Parse<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset, remainingDepth);
	}
}
