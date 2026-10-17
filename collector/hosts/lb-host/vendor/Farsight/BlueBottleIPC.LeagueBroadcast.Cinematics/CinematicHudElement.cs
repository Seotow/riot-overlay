using FlatSharp.Attributes;

namespace BlueBottleIPC.LeagueBroadcast.Cinematics;

[FlatBufferEnum(typeof(byte))]
public enum CinematicHudElement : byte
{
	FloatingText,
	HealthBarChampions,
	HealthBarMinions,
	HealthBarPets,
	HealthBarStructures,
	HealthBarWards,
	FogOfWar,
	InterfaceAll
}
