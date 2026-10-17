using System.Text.Json.Serialization;

namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

[JsonConverter(typeof(TeamJsonConverter))]
public enum Team : byte
{
	None = 0,
	Order = 1,
	Blue = Order,
	Chaos = 2,
	Red = Chaos,
	Neutral = 3
}
