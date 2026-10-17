using System.Threading.Tasks;
using BlueBottleIPC.LeagueBroadcast.Snapshot;

namespace Farsight.BBObject;

public interface IPlayerDataProvider
{
	Task<PlayerData> GetPlayerDataBySideAndRole(Team team, Role role);
}
