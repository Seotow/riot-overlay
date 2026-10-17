namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

public static class ObjectTypeExtensions
{
	public static bool IsAiClient(this ObjectType type)
	{
		if (type != ObjectType.AIHeroClient && type != ObjectType.AIMinionClient && type != ObjectType.AITurretClient && type != ObjectType.BuildingClient)
		{
			return type == ObjectType.LevelPropAIClient;
		}
		return true;
	}

	public static bool IsHero(this ObjectType type)
	{
		return type == ObjectType.AIHeroClient;
	}
}
