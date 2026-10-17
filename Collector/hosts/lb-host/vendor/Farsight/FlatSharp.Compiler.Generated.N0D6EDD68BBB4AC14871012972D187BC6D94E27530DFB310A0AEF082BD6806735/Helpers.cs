using System;
using System.Runtime.InteropServices;
using BlueBottleIPC.LeagueBroadcast.Snapshot;
using FlatSharp.Compiler.Generated.N545AE763FCB09A83BCE26918943ECB13F299E8BBD30EBC1FE03FA871EC94C291;
using FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45;

namespace FlatSharp.Compiler.Generated.N0D6EDD68BBB4AC14871012972D187BC6D94E27530DFB310A0AEF082BD6806735;

internal static class Helpers
{
	internal static int GetMaxSize(TurretKillEvent value)
	{
		return 35;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, TurretKillEvent value, int offset) where TSpanWriter : ISpanWriter
	{
		Span<byte> span2 = span.Slice(offset, 32);
		if (BitConverter.IsLittleEndian)
		{
			MemoryMarshal.Write(span2, in value);
			return;
		}
		FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span2, value.GameTime, 0);
		FlatSharp.Compiler.Generated.N545AE763FCB09A83BCE26918943ECB13F299E8BBD30EBC1FE03FA871EC94C291.Helpers.Serialize(spanWriter, span2, value.KillerNetworkId, 4);
		FlatSharp.Compiler.Generated.N545AE763FCB09A83BCE26918943ECB13F299E8BBD30EBC1FE03FA871EC94C291.Helpers.Serialize(spanWriter, span2, value.VictimNetworkId, 8);
		FlatSharp.Compiler.Generated.N545AE763FCB09A83BCE26918943ECB13F299E8BBD30EBC1FE03FA871EC94C291.Helpers.Serialize(spanWriter, span2, value.AssisterNetworkIds(0), 12);
		FlatSharp.Compiler.Generated.N545AE763FCB09A83BCE26918943ECB13F299E8BBD30EBC1FE03FA871EC94C291.Helpers.Serialize(spanWriter, span2, value.AssisterNetworkIds(1), 16);
		FlatSharp.Compiler.Generated.N545AE763FCB09A83BCE26918943ECB13F299E8BBD30EBC1FE03FA871EC94C291.Helpers.Serialize(spanWriter, span2, value.AssisterNetworkIds(2), 20);
		FlatSharp.Compiler.Generated.N545AE763FCB09A83BCE26918943ECB13F299E8BBD30EBC1FE03FA871EC94C291.Helpers.Serialize(spanWriter, span2, value.AssisterNetworkIds(3), 24);
		FlatSharp.Compiler.Generated.N545AE763FCB09A83BCE26918943ECB13F299E8BBD30EBC1FE03FA871EC94C291.Helpers.Serialize(spanWriter, span2, value.AssisterNetworkIds(4), 28);
	}

	internal static TurretKillEvent Parse<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		if (BitConverter.IsLittleEndian)
		{
			return MemoryMarshal.Read<TurretKillEvent>(buffer.GetReadOnlySpan().Slice(offset, 32));
		}
		TurretKillEvent item = new TurretKillEvent
		{
			GameTime = FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset, remainingDepth),
			KillerNetworkId = FlatSharp.Compiler.Generated.N545AE763FCB09A83BCE26918943ECB13F299E8BBD30EBC1FE03FA871EC94C291.Helpers.Parse(buffer, offset + 4, remainingDepth),
			VictimNetworkId = FlatSharp.Compiler.Generated.N545AE763FCB09A83BCE26918943ECB13F299E8BBD30EBC1FE03FA871EC94C291.Helpers.Parse(buffer, offset + 8, remainingDepth)
		};
		item.AssisterNetworkIds(0) = FlatSharp.Compiler.Generated.N545AE763FCB09A83BCE26918943ECB13F299E8BBD30EBC1FE03FA871EC94C291.Helpers.Parse(buffer, offset + 12, remainingDepth);
		item.AssisterNetworkIds(1) = FlatSharp.Compiler.Generated.N545AE763FCB09A83BCE26918943ECB13F299E8BBD30EBC1FE03FA871EC94C291.Helpers.Parse(buffer, offset + 16, remainingDepth);
		item.AssisterNetworkIds(2) = FlatSharp.Compiler.Generated.N545AE763FCB09A83BCE26918943ECB13F299E8BBD30EBC1FE03FA871EC94C291.Helpers.Parse(buffer, offset + 20, remainingDepth);
		item.AssisterNetworkIds(3) = FlatSharp.Compiler.Generated.N545AE763FCB09A83BCE26918943ECB13F299E8BBD30EBC1FE03FA871EC94C291.Helpers.Parse(buffer, offset + 24, remainingDepth);
		item.AssisterNetworkIds(4) = FlatSharp.Compiler.Generated.N545AE763FCB09A83BCE26918943ECB13F299E8BBD30EBC1FE03FA871EC94C291.Helpers.Parse(buffer, offset + 28, remainingDepth);
		return item;
	}
}
