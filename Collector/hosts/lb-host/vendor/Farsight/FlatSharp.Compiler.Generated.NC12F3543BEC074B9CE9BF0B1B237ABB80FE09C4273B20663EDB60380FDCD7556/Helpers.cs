using System;
using BlueBottleIPC.LeagueBroadcast.Snapshot;
using FlatSharp.Compiler.Generated.N545AE763FCB09A83BCE26918943ECB13F299E8BBD30EBC1FE03FA871EC94C291;
using FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45;

namespace FlatSharp.Compiler.Generated.NC12F3543BEC074B9CE9BF0B1B237ABB80FE09C4273B20663EDB60380FDCD7556;

internal static class Helpers
{
	internal static int GetMaxSize(FirstBloodEvent value)
	{
		return 15;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, FirstBloodEvent value, int offset) where TSpanWriter : ISpanWriter
	{
		Span<byte> span2 = span.Slice(offset, 12);
		FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span2, value.GameTime, 0);
		FlatSharp.Compiler.Generated.N545AE763FCB09A83BCE26918943ECB13F299E8BBD30EBC1FE03FA871EC94C291.Helpers.Serialize(spanWriter, span2, value.KillerNetworkId, 4);
		FlatSharp.Compiler.Generated.N545AE763FCB09A83BCE26918943ECB13F299E8BBD30EBC1FE03FA871EC94C291.Helpers.Serialize(spanWriter, span2, value.VictimNetworkId, 8);
	}

	internal static FirstBloodEvent Parse<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new FirstBloodEvent
		{
			GameTime = FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset, remainingDepth),
			KillerNetworkId = FlatSharp.Compiler.Generated.N545AE763FCB09A83BCE26918943ECB13F299E8BBD30EBC1FE03FA871EC94C291.Helpers.Parse(buffer, offset + 4, remainingDepth),
			VictimNetworkId = FlatSharp.Compiler.Generated.N545AE763FCB09A83BCE26918943ECB13F299E8BBD30EBC1FE03FA871EC94C291.Helpers.Parse(buffer, offset + 8, remainingDepth)
		};
	}
}
