using System.Threading.Tasks;
using BlueBottleIPC.LeagueBroadcast.Snapshot;

namespace Farsight.BBObject;

public sealed class NullPlayerDataProvider : IPlayerDataProvider
{
	public Task<PlayerData> GetPlayerDataBySideAndRole(Team team, Role role)
	{
		return Task.FromResult(new PlayerData
		{
			Alias = $"{team}_{role}",
			Name = "Demo",
			Surname = "Player"
		});
	}
}
