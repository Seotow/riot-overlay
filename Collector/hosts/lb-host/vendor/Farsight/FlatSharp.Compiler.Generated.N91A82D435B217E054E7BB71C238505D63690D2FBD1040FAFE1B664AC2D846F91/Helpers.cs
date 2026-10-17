using System;
using BlueBottleIPC.LeagueBroadcast.Common;
using FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45;

namespace FlatSharp.Compiler.Generated.N91A82D435B217E054E7BB71C238505D63690D2FBD1040FAFE1B664AC2D846F91;

internal static class Helpers
{
	internal static int GetMaxSize(Vector2 value)
	{
		return 11;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, Vector2 value, int offset) where TSpanWriter : ISpanWriter
	{
		Span<byte> span2 = span.Slice(offset, 8);
		FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span2, value.X, 0);
		FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span2, value.Y, 4);
	}

	internal static Vector2 Parse<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new Vector2
		{
			X = FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset, remainingDepth),
			Y = FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset + 4, remainingDepth)
		};
	}
}
