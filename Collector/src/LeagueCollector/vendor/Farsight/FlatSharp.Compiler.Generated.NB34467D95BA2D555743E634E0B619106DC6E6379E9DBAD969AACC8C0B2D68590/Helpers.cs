using System;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Common;
using FlatSharp.Compiler.Generated.N61E1CAC4E34AC6C5EC6C8F7F661A45E12714A5518B59FD74440F70DF205C1498;

namespace FlatSharp.Compiler.Generated.NB34467D95BA2D555743E634E0B619106DC6E6379E9DBAD969AACC8C0B2D68590;

internal static class Helpers
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static int GetMaxSize(Matrix4x4? value)
	{
		if (value.HasValue)
		{
			return FlatSharp.Compiler.Generated.N61E1CAC4E34AC6C5EC6C8F7F661A45E12714A5518B59FD74440F70DF205C1498.Helpers.GetMaxSize(value.Value);
		}
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, Matrix4x4? value, int offset) where TSpanWriter : ISpanWriter
	{
		FlatSharp.Compiler.Generated.N61E1CAC4E34AC6C5EC6C8F7F661A45E12714A5518B59FD74440F70DF205C1498.Helpers.Serialize(spanWriter, span, value.Value, offset);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static Matrix4x4? Parse<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return FlatSharp.Compiler.Generated.N61E1CAC4E34AC6C5EC6C8F7F661A45E12714A5518B59FD74440F70DF205C1498.Helpers.Parse(buffer, offset, remainingDepth);
	}
}
