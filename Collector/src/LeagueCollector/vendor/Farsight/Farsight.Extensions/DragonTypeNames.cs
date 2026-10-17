using System.Collections.Generic;

namespace Farsight.Extensions;

public static class DragonTypeNames
{
	public const string Air = "air";

	public const string Earth = "earth";

	public const string Fire = "fire";

	public const string Water = "water";

	public const string Hextech = "hextech";

	public const string Chemtech = "chemtech";

	public const string Elder = "elder";

	public static readonly HashSet<string> All = new HashSet<string> { "air", "earth", "fire", "water", "hextech", "chemtech", "elder" };
}
