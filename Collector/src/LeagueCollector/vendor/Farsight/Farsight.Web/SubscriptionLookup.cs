using System.Net;

namespace Farsight.Web;

public readonly record struct SubscriptionLookup(SubscriptionLookupOutcome Outcome, SubscriptionStatusResponse? Response, HttpStatusCode? StatusCode)
{
	public bool IsConclusive => Outcome != SubscriptionLookupOutcome.Unavailable;

	public static SubscriptionLookup Found(SubscriptionStatusResponse response)
	{
		return new SubscriptionLookup(SubscriptionLookupOutcome.Found, response, HttpStatusCode.OK);
	}

	public static SubscriptionLookup NoAccount()
	{
		return new SubscriptionLookup(SubscriptionLookupOutcome.NoAccount, null, HttpStatusCode.NotFound);
	}

	public static SubscriptionLookup Unavailable(HttpStatusCode? statusCode = null)
	{
		return new SubscriptionLookup(SubscriptionLookupOutcome.Unavailable, null, statusCode);
	}
}
