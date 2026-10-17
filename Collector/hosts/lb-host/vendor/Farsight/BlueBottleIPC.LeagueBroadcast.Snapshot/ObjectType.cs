using FlatSharp.Attributes;

namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

[FlatBufferEnum(typeof(ulong))]
public enum ObjectType : ulong
{
	Unknown = 0uL,
	AIMarker = 301422653uL,
	LevelPropAIClient = 316820429uL,
	GameObject = 531401572uL,
	BuildingClient = 1019919150uL,
	Turret = 1031232777uL,
	DrawFX = 1121010933uL,
	LevelPropSpawnerPoint = 1300984122uL,
	HQ = 1346031826uL,
	LevelPropGameObject = 1517489337uL,
	BarracksDampener = 1622886848uL,
	obj_Levelsizer = 1865313452uL,
	AITurretCommon = 1885834192uL,
	AnimatedBuilding = 2407791516uL,
	Emote = 2484619884uL,
	obj_NavPoint = 2528159206uL,
	MissileClient = 2626346644uL,
	ObjectAttacher = 2654040416uL,
	Shop = 2823282857uL,
	GrassObject = 2854976178uL,
	UnrevealedTarget = 3113175471uL,
	AITurretClient = 3199897858uL,
	AIMinionClient = 3399847090uL,
	Barracks = 3521999102uL,
	obj_GeneralParticleEmitter = 3712870255uL,
	AIHeroClient = 3797954604uL,
	obj_SpawnPoint = 3823743852uL,
	obj_InfoPoint = 4101323475uL,
	TurretShrine = 4213875895uL,
	NeutralMinionCamp = 4269033891uL
}
