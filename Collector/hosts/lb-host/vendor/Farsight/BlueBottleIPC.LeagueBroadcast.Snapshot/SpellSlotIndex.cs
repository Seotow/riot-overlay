using System.Text.Json.Serialization;

namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

[JsonConverter(typeof(JsonNumberEnumConverter<SpellSlotIndex>))]
public enum SpellSlotIndex : short
{
	Q = 0,
	W = 1,
	E = 2,
	R = 3,
	D = 4,
	F = 5,
	Item1 = 6,
	Item2 = 7,
	Item3 = 8,
	Item4 = 9,
	Item5 = 10,
	Item6 = 11,
	ItemTrinket = 12,
	Recall = 13,
	Quest = 14,
	Passive = 63
}
