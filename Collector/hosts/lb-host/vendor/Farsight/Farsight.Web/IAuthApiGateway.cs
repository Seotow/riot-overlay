using System.Threading;
using System.Threading.Tasks;

namespace Farsight.Web;

public interface IAuthApiGateway
{
	Task<SignUpResult> SignUpAsync(string userEmail, string? firstName, string? lastName, string? referralCode = null, CancellationToken ct = default(CancellationToken));

	Task<SessionAuthResponse?> GetSessionAuthToken(CancellationToken ct = default(CancellationToken));

	Task<SubscriptionLookup> GetSubscriptionLookupAsync(CancellationToken ct = default(CancellationToken));

	Task<SubscriptionStatusResponse?> GetSubscriptionStatus(CancellationToken ct = default(CancellationToken));

	Task<SubscriptionStatusResponse?> GetSubscriptionStatusDetails(CancellationToken ct = default(CancellationToken));

	Task<string?> CreatePortalSessionAsync(CancellationToken ct = default(CancellationToken));

	Task<CheckoutResponse?> CreateCheckoutSessionAsync(string plan, string interval, string? referralCode = null, CancellationToken ct = default(CancellationToken));

	Task<CodeChallengeFeaturesResponseDto> RequestCodeChallengeWithFeatures(string challengeString, CancellationToken ct = default(CancellationToken));
}
