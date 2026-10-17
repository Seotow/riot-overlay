using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using BlueBottleIPC.LeagueBroadcast.Commands;

namespace Farsight.Auth;

public sealed class FeatureSet : IReadOnlySet<Feature>, IEnumerable<Feature>, IEnumerable, IReadOnlyCollection<Feature>
{
	public static readonly FeatureSet Empty = new FeatureSet(new HashSet<Feature>());

	private readonly HashSet<Feature> _features;

	public bool IsEmpty => _features.Count == 0;

	public int Count => _features.Count;

	public static event EventHandler<IReadOnlyList<string>>? UnknownFeatureNames;

	public FeatureSet(IEnumerable<Feature> features)
	{
		HashSet<Feature> hashSet3;
		if (features is HashSet<Feature> hashSet)
		{
			HashSet<Feature> hashSet2 = new HashSet<Feature>();
			foreach (Feature item in hashSet)
			{
				hashSet2.Add(item);
			}
			hashSet3 = hashSet2;
		}
		else
		{
			HashSet<Feature> hashSet2 = new HashSet<Feature>();
			foreach (Feature feature in features)
			{
				hashSet2.Add(feature);
			}
			hashSet3 = hashSet2;
		}
		HashSet<Feature> hashSet4 = hashSet3;
		ExpandTierHierarchy(hashSet4);
		ExpandLegacyAliases(hashSet4);
		_features = hashSet4;
	}

	private static void ExpandTierHierarchy(HashSet<Feature> set)
	{
		if (set.Contains(Feature.EnterpriseTier))
		{
			set.Add(Feature.ProTier);
		}
		if (set.Contains(Feature.ProTier))
		{
			set.Add(Feature.BasicTier);
		}
	}

	private static void ExpandLegacyAliases(HashSet<Feature> set)
	{
		if (set.Contains(Feature.Strokes_Cloud))
		{
			set.Add(Feature.Strokes_Remote);
			set.Add(Feature.Strokes_Sync);
			set.Add(Feature.Mirror_Sync);
		}
	}

	public bool Has(Feature feature)
	{
		return _features.Contains(feature);
	}

	public FeatureSet UnionWith(FeatureSet other)
	{
		HashSet<Feature> hashSet = new HashSet<Feature>(_features);
		hashSet.UnionWith(other._features);
		return new FeatureSet(hashSet);
	}

	public ulong[] ToBits()
	{
		ulong num = 0uL;
		foreach (Feature feature in _features)
		{
			num |= feature.BitMask();
		}
		return new ulong[1] { num };
	}

	public static FeatureSet FromNames(IEnumerable<string>? names)
	{
		if (names == null)
		{
			return Empty;
		}
		HashSet<Feature> hashSet = new HashSet<Feature>();
		List<string> list = null;
		foreach (string name in names)
		{
			if (FeatureCatalog.TryParse(name, out var feature))
			{
				hashSet.Add(feature);
			}
			else
			{
				(list ?? (list = new List<string>())).Add(name);
			}
		}
		if (list != null)
		{
			UnknownFeatureNames?.Invoke(null, list);
		}
		return new FeatureSet(hashSet);
	}

	public static FeatureSet FromBits(ulong[]? bits)
	{
		if (bits == null || bits.Length == 0)
		{
			return Empty;
		}
		ulong num = bits[0];
		HashSet<Feature> hashSet = new HashSet<Feature>();
		foreach (Feature item in FeatureCatalog.All)
		{
			if ((num & item.BitMask()) != 0L)
			{
				hashSet.Add(item);
			}
		}
		return new FeatureSet(hashSet);
	}

	public override string ToString()
	{
		return "[" + string.Join(", ", _features.OrderBy((Feature f) => (uint)f)) + "]";
	}

	public bool Contains(Feature item)
	{
		return _features.Contains(item);
	}

	public bool IsProperSubsetOf(IEnumerable<Feature> other)
	{
		return _features.IsProperSubsetOf(other);
	}

	public bool IsProperSupersetOf(IEnumerable<Feature> other)
	{
		return _features.IsProperSupersetOf(other);
	}

	public bool IsSubsetOf(IEnumerable<Feature> other)
	{
		return _features.IsSubsetOf(other);
	}

	public bool IsSupersetOf(IEnumerable<Feature> other)
	{
		return _features.IsSupersetOf(other);
	}

	public bool Overlaps(IEnumerable<Feature> other)
	{
		return _features.Overlaps(other);
	}

	public bool SetEquals(IEnumerable<Feature> other)
	{
		return _features.SetEquals(other);
	}

	public IEnumerator<Feature> GetEnumerator()
	{
		return _features.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return _features.GetEnumerator();
	}
}
