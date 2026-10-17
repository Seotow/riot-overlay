using Amazon;
using Amazon.CognitoIdentity;
using Amazon.CognitoIdentity.Model;
using Amazon.CognitoIdentityProvider;
using Amazon.CognitoIdentityProvider.Model;
using Amazon.Runtime;
using Farsight.Auth;
using Farsight.Web;
using LeagueCollector.Auth;

namespace LeagueCollector;

// Uses the released authentication protocol. Tokens remain in process memory.
public sealed class BlueBottleAuth(ILoggerFactory loggers) : IDisposable
{
    public const string Pool = "eu-central-1_d2Rhdw6I2";
    private const string Client = "5jg3u84e7taf6rdr1jp00fll82";
    private const string IdentityPool = "eu-central-1:b8aa8c6c-6e42-4562-9c0d-945b4f5fb63b";
    private const string Provider = "cognito-idp.eu-central-1.amazonaws.com/" + Pool;
    private const string Api = "https://s5t7my90m0.execute-api.eu-central-1.amazonaws.com/";
    private readonly SemaphoreSlim gate = new(1, 1);
    private readonly HttpClient http = new() { Timeout = TimeSpan.FromSeconds(20) };
    private readonly AmazonCognitoIdentityProviderClient idp = new(new AnonymousAWSCredentials(), RegionEndpoint.EUCentral1);
    private readonly AmazonCognitoIdentityClient identity = new(new AnonymousAWSCredentials(), RegionEndpoint.EUCentral1);
    private string? idToken, refreshToken;
    private DateTime expires = DateTime.MinValue, awsExpires = DateTime.MinValue;
    private SessionAWSCredentials? aws;
    private int signingAttempts, signedResponses;
    public FeatureSet Features { get; private set; } = FeatureSet.Empty;
    public string State { get; private set; } = "not-configured";
    public bool Configured => !string.IsNullOrEmpty(Environment.GetEnvironmentVariable("LB_EMAIL")) && !string.IsNullOrEmpty(Environment.GetEnvironmentVariable("LB_PASSWORD"));

    public async Task Initialize(CancellationToken ct)
    {
        if (!Configured) return;
        await gate.WaitAsync(ct);
        try
        {
            var srp = new SrpHelper(Pool);
            string email = Environment.GetEnvironmentVariable("LB_EMAIL")!.Trim().ToLowerInvariant();
            var start = await idp.InitiateAuthAsync(new InitiateAuthRequest
            {
                AuthFlow = AuthFlowType.USER_SRP_AUTH, ClientId = Client,
                AuthParameters = new() { ["USERNAME"] = email, ["SRP_A"] = srp.SrpA }
            }, ct);
            if (start.ChallengeName != ChallengeNameType.PASSWORD_VERIFIER) throw new InvalidOperationException("additional_authentication_required");
            var c = start.ChallengeParameters;
            var claims = srp.GetClaimResponse(Environment.GetEnvironmentVariable("LB_PASSWORD")!, c["USER_ID_FOR_SRP"], c["SALT"], c["SRP_B"], c["SECRET_BLOCK"], Client);
            var result = await idp.RespondToAuthChallengeAsync(new RespondToAuthChallengeRequest
            {
                ClientId = Client, ChallengeName = ChallengeNameType.PASSWORD_VERIFIER,
                Session = start.Session, ChallengeResponses = claims
            }, ct);
            SetTokens(result.AuthenticationResult ?? throw new InvalidOperationException("additional_authentication_required"));
            State = "authenticated";
        }
        catch (OperationCanceledException) when (ct.IsCancellationRequested) { throw; }
        catch { State = "authentication-failed"; throw new InvalidOperationException("bluebottle_authentication_failed"); }
        finally { gate.Release(); }
        var api = await GetApi(ct);
        var lookup = await api.GetSubscriptionLookupAsync(ct);
        if (lookup.Response?.Features is { } names) Features = FeatureSet.FromNames(names);
        else State = "authenticated-subscription-unavailable";
    }

    private void SetTokens(AuthenticationResultType result)
    {
        idToken = result.IdToken ?? throw new InvalidOperationException("missing_id_token");
        refreshToken = result.RefreshToken ?? refreshToken;
        expires = DateTime.UtcNow.AddSeconds(result.ExpiresIn.GetValueOrDefault(3600) - 60);
        aws = null;
    }

    public async Task<SessionAWSCredentials> Credentials(CancellationToken ct)
    {
        await gate.WaitAsync(ct);
        try
        {
            if (idToken == null) throw new InvalidOperationException("bluebottle_login_required");
            if (DateTime.UtcNow >= expires)
            {
                if (refreshToken == null) throw new InvalidOperationException("bluebottle_login_expired");
                var refreshed = await idp.InitiateAuthAsync(new InitiateAuthRequest
                {
                    AuthFlow = AuthFlowType.REFRESH_TOKEN_AUTH, ClientId = Client,
                    AuthParameters = new() { ["REFRESH_TOKEN"] = refreshToken }
                }, ct);
                SetTokens(refreshed.AuthenticationResult ?? throw new InvalidOperationException("bluebottle_refresh_failed"));
            }
            if (aws != null && DateTime.UtcNow < awsExpires) return aws;
            var logins = new Dictionary<string, string> { [Provider] = idToken };
            var id = await identity.GetIdAsync(new GetIdRequest { IdentityPoolId = IdentityPool, Logins = logins }, ct);
            var response = await identity.GetCredentialsForIdentityAsync(new GetCredentialsForIdentityRequest { IdentityId = id.IdentityId, Logins = logins }, ct);
            var c = response.Credentials ?? throw new InvalidOperationException("missing_federated_credentials");
            aws = new SessionAWSCredentials(c.AccessKeyId, c.SecretKey, c.SessionToken);
            awsExpires = c.Expiration is DateTime expiry ? expiry.ToUniversalTime().AddMinutes(-2) : DateTime.UtcNow.AddMinutes(10);
            return aws;
        }
        finally { gate.Release(); }
    }

    private async Task<AuthApiGatewayClient> GetApi(CancellationToken ct) => new(
        () => http, await Credentials(ct), _ => Task.FromResult(true),
        loggers.CreateLogger("BlueBottleAuth"), Api);

    public async Task<CodeChallengeResult?> Sign(string challenge, CancellationToken ct)
    {
        Interlocked.Increment(ref signingAttempts);
        try
        {
            var result = await (await GetApi(ct)).RequestCodeChallengeWithFeatures(challenge, ct);
            if (!result.IsSuccess || result.SignatureBase64 == null || result.FeatureBits is not { Length: > 0 }) return null;
            Interlocked.Increment(ref signedResponses);
            return new CodeChallengeResult(result.SignatureBase64, result.FeatureBits);
        }
        catch (OperationCanceledException) when (ct.IsCancellationRequested) { throw; }
        catch { State = "challenge-signing-failed"; return null; }
    }

    public object Status() => new { state = State, features = Features.Select(f => f.ToString()).ToArray(),
        signingAttempts = Volatile.Read(ref signingAttempts), signedResponses = Volatile.Read(ref signedResponses), tokensPersisted = false };
    public void Dispose() { http.Dispose(); idp.Dispose(); identity.Dispose(); gate.Dispose(); }
}
