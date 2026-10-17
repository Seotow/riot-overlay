using System;

namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

public static class TeamExtensions
{
	public static Team GetOppositeTeam(this Team team)
	{
		return team switch
		{
			Team.Order => Team.Chaos, 
			Team.Chaos => Team.Order, 
			Team.Neutral => Team.Neutral, 
			_ => throw new ArgumentOutOfRangeException("team", team, null), 
		};
	}
}
