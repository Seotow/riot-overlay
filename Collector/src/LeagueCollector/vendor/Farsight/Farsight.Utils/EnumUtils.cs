using System;

namespace Farsight.Utils;

public static class EnumUtils
{
	public static bool IsOneOf(this Enum enumeration, params Enum[] enums)
	{
		return enums.Contains(enumeration, null);
	}
}
