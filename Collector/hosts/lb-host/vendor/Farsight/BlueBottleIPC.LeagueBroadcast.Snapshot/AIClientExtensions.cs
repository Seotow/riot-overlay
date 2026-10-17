using System;

namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

public static class AIClientExtensions
{
	public static string GetAtakhanForm(this AIClient atakhan)
	{
		string? identifier = atakhan.Identifier;
		if (identifier == null || !identifier.Equals("SRU_Atakhan", StringComparison.OrdinalIgnoreCase))
		{
			return "";
		}
		if (atakhan.HasBuff("srt_2025_atakhan_selfbuffbloody"))
		{
			return "ruinous";
		}
		return "voracious";
	}

	public static string GetDragonType(this AIClient dragon)
	{
		string? identifier = dragon.Identifier;
		if (identifier == null || !identifier.StartsWith("sru_dragon", StringComparison.OrdinalIgnoreCase))
		{
			return "";
		}
		string[] array = dragon.Identifier.Split("_");
		if (array.Length != 0)
		{
			return array[^1].ToLowerInvariant();
		}
		return "";
	}
}
