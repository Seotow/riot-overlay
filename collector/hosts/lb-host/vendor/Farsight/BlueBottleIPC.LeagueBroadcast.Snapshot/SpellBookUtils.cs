using System.Collections.Generic;
using System.Linq;

namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

public static class SpellBookUtils
{
	public static IEnumerable<Spell> GetHeroSpells(this IEnumerable<Spell> spells)
	{
		return spells.Where((Spell x) =>
		{
			ushort index = x.Index;
			return (uint)index <= 3u;
		});
	}

	public static IEnumerable<Spell> GetSummonerSpells(this IEnumerable<Spell> spells)
	{
		return spells.Where((Spell x) =>
		{
			ushort index = x.Index;
			return (uint)(index - 4) <= 1u;
		});
	}

	public static IEnumerable<Spell> GetAbilitySpells(this IEnumerable<Spell> spells)
	{
		return spells.Where((Spell x) =>
		{
			ushort index = x.Index;
			return (uint)index <= 5u;
		});
	}

	public static Spell? GetSpellByIndex(this IEnumerable<Spell> spells, SpellSlotIndex index)
	{
		return spells.FirstOrDefault((Spell x) => x.Index == (ushort)index);
	}

	public static Spell? GetItemSpellByItemIndex(this IEnumerable<Spell> spells, byte itemIndex)
	{
		if (itemIndex < 9)
		{
			return spells.FirstOrDefault((Spell x) => x.Index == 6 + itemIndex);
		}
		return null;
	}
}
