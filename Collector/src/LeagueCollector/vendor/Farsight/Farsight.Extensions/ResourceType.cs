namespace Farsight.Extensions;

public enum ResourceType : byte
{
	mana = 0,
	energy = 1,
	none = 2,
	shield = 3,
	battlefury = 4,
	dragonfury = 5,
	rage = 6,
	heat = 7,
	gnarfury = 8,
	ferocity = 9,
	bloodwell = 10,
	wind = 11,
	ammo = 12,
	moonlight = 13,
	other = 14,
	unknown = byte.MaxValue
}
