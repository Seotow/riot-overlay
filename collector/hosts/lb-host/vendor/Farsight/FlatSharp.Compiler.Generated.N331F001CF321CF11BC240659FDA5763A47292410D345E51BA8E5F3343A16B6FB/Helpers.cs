using System;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N331F001CF321CF11BC240659FDA5763A47292410D345E51BA8E5F3343A16B6FB;

internal static class Helpers
{
	internal static int GetMaxSize(Memory<byte> value)
	{
		return 7 + value.Length;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, Memory<byte> value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		spanWriter.WriteReadOnlyByteMemoryBlock(span, value, offset, context);
	}

	internal static Memory<byte> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return buffer.ReadByteMemoryBlock(offset);
	}

	internal static Memory<byte> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return buffer.ReadByteMemoryBlock(offset);
	}

	internal static Memory<byte> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return buffer.ReadByteMemoryBlock(offset).ToArray().AsMemory();
	}

	internal static Memory<byte> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth, TableFieldContext fieldContext) where TInputBuffer : IInputBuffer
	{
		return buffer.ReadByteMemoryBlock(offset).ToArray().AsMemory();
	}
}
