using System;

namespace Farsight.Extensions;

public static class ResourceTypeExtensions
{
	public static ResourceType Parse(byte value)
	{
		if (!Enum.IsDefined(typeof(ResourceType), value))
		{
			return ResourceType.mana;
		}
		return (ResourceType)value;
	}

	public static bool TryParse(byte value, out ResourceType resourceType)
	{
		if (!Enum.IsDefined(typeof(ResourceType), value))
		{
			resourceType = ResourceType.mana;
			return false;
		}
		resourceType = (ResourceType)value;
		return true;
	}
}
