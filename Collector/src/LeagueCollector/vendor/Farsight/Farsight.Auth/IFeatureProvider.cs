using BlueBottleIPC.LeagueBroadcast.Commands;

namespace Farsight.Auth;

public interface IFeatureProvider
{
	FeatureSet GetCurrentFeatures();

	bool HasFeature(Feature feature)
	{
		return GetCurrentFeatures().Has(feature);
	}
}
