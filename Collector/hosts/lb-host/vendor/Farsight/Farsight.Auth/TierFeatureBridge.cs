using BlueBottleIPC.LeagueBroadcast.Commands;

namespace Farsight.Auth;

public static class TierFeatureBridge
{
	public static Feature? AsFeature(this Tier tier)
	{
		return tier switch
		{
			Tier.Basic => (Feature?)Feature.BasicTier, 
			Tier.Pro => Feature.ProTier, 
			Tier.Enterprise => Feature.EnterpriseTier, 
			_ => null, 
		};
	}

	public static Tier HighestTier(this FeatureSet features)
	{
		if (features.Has(Feature.EnterpriseTier))
		{
			return Tier.Enterprise;
		}
		if (features.Has(Feature.ProTier))
		{
			return Tier.Pro;
		}
		if (features.Has(Feature.BasicTier))
		{
			return Tier.Basic;
		}
		return Tier.Free;
	}
}
