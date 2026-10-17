using System;
using System.Runtime.InteropServices;
using BlueBottleIPC.LeagueBroadcast.Snapshot;
using FlatSharp.Compiler.Generated.N545AE763FCB09A83BCE26918943ECB13F299E8BBD30EBC1FE03FA871EC94C291;
using FlatSharp.Compiler.Generated.NBA76DA8C7A3F8A8CD0B5F9CD32FAD62A91F904FADD49F895461461ABFCA5C576;
using FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45;

namespace FlatSharp.Compiler.Generated.N37E5ADCC13E5491F24DF839B0F9A7D4ACA35D6DB161174A371D74D5F6364F1B6;

internal static class Helpers
{
	internal static int GetMaxSize(ObjectiveStealEvent value)
	{
		return 39;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, ObjectiveStealEvent value, int offset) where TSpanWriter : ISpanWriter
	{
		Span<byte> span2 = span.Slice(offset, 36);
		if (BitConverter.IsLittleEndian)
		{
			MemoryMarshal.Write(span2, in value);
			return;
		}
		FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span2, value.GameTime, 0);
		FlatSharp.Compiler.Generated.N545AE763FCB09A83BCE26918943ECB13F299E8BBD30EBC1FE03FA871EC94C291.Helpers.Serialize(spanWriter, span2, value.KillerNetworkId, 4);
		FlatSharp.Compiler.Generated.N545AE763FCB09A83BCE26918943ECB13F299E8BBD30EBC1FE03FA871EC94C291.Helpers.Serialize(spanWriter, span2, value.ObjectiveNetworkId, 8);
		FlatSharp.Compiler.Generated.NBA76DA8C7A3F8A8CD0B5F9CD32FAD62A91F904FADD49F895461461ABFCA5C576.Helpers.Serialize(spanWriter, span2, value.ObjectiveType, 12);
		FlatSharp.Compiler.Generated.N545AE763FCB09A83BCE26918943ECB13F299E8BBD30EBC1FE03FA871EC94C291.Helpers.Serialize(spanWriter, span2, value.StolenFromNetworkIds(0), 16);
		FlatSharp.Compiler.Generated.N545AE763FCB09A83BCE26918943ECB13F299E8BBD30EBC1FE03FA871EC94C291.Helpers.Serialize(spanWriter, span2, value.StolenFromNetworkIds(1), 20);
		FlatSharp.Compiler.Generated.N545AE763FCB09A83BCE26918943ECB13F299E8BBD30EBC1FE03FA871EC94C291.Helpers.Serialize(spanWriter, span2, value.StolenFromNetworkIds(2), 24);
		FlatSharp.Compiler.Generated.N545AE763FCB09A83BCE26918943ECB13F299E8BBD30EBC1FE03FA871EC94C291.Helpers.Serialize(spanWriter, span2, value.StolenFromNetworkIds(3), 28);
		FlatSharp.Compiler.Generated.N545AE763FCB09A83BCE26918943ECB13F299E8BBD30EBC1FE03FA871EC94C291.Helpers.Serialize(spanWriter, span2, value.StolenFromNetworkIds(4), 32);
	}

	internal static ObjectiveStealEvent Parse<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		if (BitConverter.IsLittleEndian)
		{
			return MemoryMarshal.Read<ObjectiveStealEvent>(buffer.GetReadOnlySpan().Slice(offset, 36));
		}
		ObjectiveStealEvent item = new ObjectiveStealEvent
		{
			GameTime = FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset, remainingDepth),
			KillerNetworkId = FlatSharp.Compiler.Generated.N545AE763FCB09A83BCE26918943ECB13F299E8BBD30EBC1FE03FA871EC94C291.Helpers.Parse(buffer, offset + 4, remainingDepth),
			ObjectiveNetworkId = FlatSharp.Compiler.Generated.N545AE763FCB09A83BCE26918943ECB13F299E8BBD30EBC1FE03FA871EC94C291.Helpers.Parse(buffer, offset + 8, remainingDepth),
			ObjectiveType = FlatSharp.Compiler.Generated.NBA76DA8C7A3F8A8CD0B5F9CD32FAD62A91F904FADD49F895461461ABFCA5C576.Helpers.Parse(buffer, offset + 12, remainingDepth)
		};
		item.StolenFromNetworkIds(0) = FlatSharp.Compiler.Generated.N545AE763FCB09A83BCE26918943ECB13F299E8BBD30EBC1FE03FA871EC94C291.Helpers.Parse(buffer, offset + 16, remainingDepth);
		item.StolenFromNetworkIds(1) = FlatSharp.Compiler.Generated.N545AE763FCB09A83BCE26918943ECB13F299E8BBD30EBC1FE03FA871EC94C291.Helpers.Parse(buffer, offset + 20, remainingDepth);
		item.StolenFromNetworkIds(2) = FlatSharp.Compiler.Generated.N545AE763FCB09A83BCE26918943ECB13F299E8BBD30EBC1FE03FA871EC94C291.Helpers.Parse(buffer, offset + 24, remainingDepth);
		item.StolenFromNetworkIds(3) = FlatSharp.Compiler.Generated.N545AE763FCB09A83BCE26918943ECB13F299E8BBD30EBC1FE03FA871EC94C291.Helpers.Parse(buffer, offset + 28, remainingDepth);
		item.StolenFromNetworkIds(4) = FlatSharp.Compiler.Generated.N545AE763FCB09A83BCE26918943ECB13F299E8BBD30EBC1FE03FA871EC94C291.Helpers.Parse(buffer, offset + 32, remainingDepth);
		return item;
	}
}
