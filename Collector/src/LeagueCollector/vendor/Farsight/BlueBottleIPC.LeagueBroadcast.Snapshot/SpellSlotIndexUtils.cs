namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

public static class SpellSlotIndexUtils
{
	public static SpellSlotIndex GetItemSpellSlotFromItemIndex(short itemIndex)
	{
		if (itemIndex > 8)
		{
			return SpellSlotIndex.Item1;
		}
		return (SpellSlotIndex)(6 + itemIndex);
	}
}
