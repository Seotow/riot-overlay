using System;

namespace Farsight.Utils;

internal static class StringHelper
{
	public static bool ContainsAny(this string s, params string[] compare)
	{
		if (Array.Exists(compare, (string x) => s.IndexOf(x, StringComparison.OrdinalIgnoreCase) > -1) || compare.Length == 0)
		{
			return true;
		}
		return false;
	}
}
