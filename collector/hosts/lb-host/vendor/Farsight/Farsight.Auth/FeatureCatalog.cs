using System;
using System.Collections.Generic;
using System.Linq;
using BlueBottleIPC.LeagueBroadcast.Commands;

namespace Farsight.Auth;

public static class FeatureCatalog
{
	private static readonly Dictionary<string, Feature> _byName = All.ToDictionary((Feature f) => f.ToString(), StringComparer.OrdinalIgnoreCase);

	public static IReadOnlyList<Feature> All { get; } = (from f in Enum.GetValues<Feature>()
		orderby (uint)f
		select f).ToArray();

	public static int BitIndex(this Feature feature)
	{
		return (int)feature;
	}

	public static ulong BitMask(this Feature feature)
	{
		return (ulong)(1L << feature.BitIndex());
	}

	public static bool TryParse(string name, out Feature feature)
	{
		return _byName.TryGetValue(name, out feature);
	}
}
