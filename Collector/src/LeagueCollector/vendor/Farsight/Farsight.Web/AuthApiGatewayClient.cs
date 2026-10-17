using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Amazon;
using Amazon.Runtime;
using Microsoft.Extensions.Logging;

namespace Farsight.Web;

public class AuthApiGatewayClient : IAuthApiGateway
{
	private readonly Func<HttpClient> _httpClientFactory;

	private readonly AWSCredentials _awsCredentials;

	private readonly Func<CancellationToken?, Task<bool>> _validateAsync;

	private readonly ILogger _logger;

	private readonly Uri _baseUrl;

	private const string ServiceExecuteApi = "execute-api";

	private static readonly RegionEndpoint ServiceRegion = RegionEndpoint.EUCentral1;

	public AuthApiGatewayClient(Func<HttpClient> httpClientFactory, AWSCredentials awsCredentials, Func<CancellationToken?, Task<bool>> validateAsync, ILogger logger, string baseUrl)
	{
		_httpClientFactory = httpClientFactory;
		_awsCredentials = awsCredentials;
		_validateAsync = validateAsync;
		_logger = logger;
		_baseUrl = new Uri(baseUrl.EndsWith('/') ? baseUrl : (baseUrl + "/"));
	}

	public async Task<SignUpResult> SignUpAsync(string userEmail, string? firstName, string? lastName, string? referralCode = null, CancellationToken cancellationToken = default(CancellationToken))
	{
		var value = new
		{
			email = userEmail,
			firstName = firstName,
			lastName = lastName,
			referralCode = (referralCode?.Trim() ?? string.Empty)
		};
		string jsonPayload = JsonSerializer.Serialize(value);
		if (!(await _validateAsync(cancellationToken)))
		{
			return SignUpResult.Failed();
		}
		HttpResponseMessage httpResponseMessage = await _httpClientFactory().PostAsync(new Uri(_baseUrl, "sign-up"), new StringContent(jsonPayload, Encoding.UTF8, "application/json"), ServiceRegion.SystemName, "execute-api", _awsCredentials, cancellationToken);
		if (httpResponseMessage.StatusCode == HttpStatusCode.Created)
		{
			return SignUpResult.Ok();
		}
		if (httpResponseMessage.StatusCode == HttpStatusCode.Conflict)
		{
			SignUpConflictBody body = null;
			try
			{
				body = await httpResponseMessage.Content.ReadFromJsonAsync<SignUpConflictBody>(cancellationToken);
			}
			catch (JsonException exception)
			{
				_logger.LogWarning(exception, "sign-up returned 409 with an unreadable body; treating as 'already exists'.");
			}
			if (string.Equals(body?.Code, "ACCOUNT_EXISTS_OTHER_IDENTITY", StringComparison.Ordinal))
			{
				_logger.LogWarning("sign-up refused: this email already belongs to another identity ({Provider}).", body?.ExistingProvider ?? "unknown provider");
				return SignUpResult.Conflict(body.Code, body.Error, body.ExistingProvider);
			}
			return SignUpResult.Ok();
		}
		_logger.LogWarning("sign-up returned {StatusCode}.", httpResponseMessage.StatusCode);
		return SignUpResult.Failed();
	}

	public async Task<SessionAuthResponse?> GetSessionAuthToken(CancellationToken cancellationToken = default(CancellationToken))
	{
		if (!(await _validateAsync(cancellationToken)))
		{
			return null;
		}
		HttpResponseMessage httpResponseMessage = await _httpClientFactory().GetAsync(new Uri(_baseUrl, "auth-token"), ServiceRegion.SystemName, "execute-api", _awsCredentials, cancellationToken);
		if (!httpResponseMessage.IsSuccessStatusCode)
		{
			return null;
		}
		return await httpResponseMessage.Content.ReadFromJsonAsync<SessionAuthResponse>(cancellationToken);
	}

	public async Task<SubscriptionLookup> GetSubscriptionLookupAsync(CancellationToken cancellationToken = default(CancellationToken))
	{
		if (!(await _validateAsync(cancellationToken)))
		{
			_logger.LogWarning("Subscription lookup skipped: credentials could not be validated.");
			return SubscriptionLookup.Unavailable();
		}
		HttpResponseMessage response;
		try
		{
			response = await _httpClientFactory().GetAsync(new Uri(_baseUrl, "subscription-status"), ServiceRegion.SystemName, "execute-api", _awsCredentials, cancellationToken);
		}
		catch (Exception ex) when (((ex is HttpRequestException || ex is TaskCanceledException) ? true : false) && !cancellationToken.IsCancellationRequested)
		{
			_logger.LogWarning(ex, "Subscription lookup could not reach the auth API.");
			return SubscriptionLookup.Unavailable();
		}
		if (response.StatusCode == HttpStatusCode.NotFound)
		{
			return SubscriptionLookup.NoAccount();
		}
		if (!response.IsSuccessStatusCode)
		{
			_logger.LogWarning("subscription-status returned {StatusCode}; entitlements are unknown.", response.StatusCode);
			return SubscriptionLookup.Unavailable(response.StatusCode);
		}
		SubscriptionStatusResponse subscriptionStatusResponse;
		try
		{
			subscriptionStatusResponse = await response.Content.ReadFromJsonAsync<SubscriptionStatusResponse>(cancellationToken);
		}
		catch (JsonException exception)
		{
			_logger.LogError(exception, "Failed to deserialize the subscription-status response.");
			return SubscriptionLookup.Unavailable(response.StatusCode);
		}
		return (subscriptionStatusResponse == null) ? SubscriptionLookup.Unavailable(response.StatusCode) : SubscriptionLookup.Found(subscriptionStatusResponse);
	}

	public async Task<SubscriptionStatusResponse?> GetSubscriptionStatus(CancellationToken cancellationToken = default(CancellationToken))
	{
		return (await GetSubscriptionLookupAsync(cancellationToken)).Response;
	}

	public async Task<SubscriptionStatusResponse?> GetSubscriptionStatusDetails(CancellationToken cancellationToken = default(CancellationToken))
	{
		if (!(await _validateAsync(cancellationToken)))
		{
			return null;
		}
		HttpResponseMessage httpResponseMessage = await _httpClientFactory().GetAsync(new Uri(_baseUrl, "subscription-status/details"), ServiceRegion.SystemName, "execute-api", _awsCredentials, cancellationToken);
		if (!httpResponseMessage.IsSuccessStatusCode)
		{
			return null;
		}
		return await httpResponseMessage.Content.ReadFromJsonAsync<SubscriptionStatusResponse>(cancellationToken);
	}

	public async Task<string?> CreatePortalSessionAsync(CancellationToken cancellationToken = default(CancellationToken))
	{
		if (!(await _validateAsync(cancellationToken)))
		{
			return null;
		}
		HttpResponseMessage httpResponseMessage = await _httpClientFactory().GetAsync(new Uri(_baseUrl, "portal"), ServiceRegion.SystemName, "execute-api", _awsCredentials, cancellationToken);
		if (!httpResponseMessage.IsSuccessStatusCode)
		{
			return null;
		}
		return (await httpResponseMessage.Content.ReadFromJsonAsync<PortalSessionResponse>(cancellationToken))?.PortalUrl;
	}

	public async Task<CheckoutResponse?> CreateCheckoutSessionAsync(string plan, string interval, string? referralCode = null, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (!(await _validateAsync(cancellationToken)))
		{
			return null;
		}
		string content = JsonSerializer.Serialize(new
		{
			plan = plan,
			interval = interval,
			referralCode = (referralCode?.Trim() ?? string.Empty)
		});
		HttpClient self = _httpClientFactory();
		HttpResponseMessage response;
		try
		{
			response = await self.PostAsync(new Uri(_baseUrl, "checkout/create"), new StringContent(content, Encoding.UTF8, "application/json"), ServiceRegion.SystemName, "execute-api", _awsCredentials, cancellationToken);
		}
		catch (HttpRequestException exception)
		{
			_logger.LogError(exception, "HTTP request exception when creating checkout session.");
			return null;
		}
		if (!response.IsSuccessStatusCode)
		{
			string text = await response.Content.ReadAsStringAsync(cancellationToken);
			string text2 = TryExtractMessage(text);
			_logger.LogWarning("checkout/create returned {StatusCode}: {Message}", response.StatusCode, text2 ?? text);
			return new CheckoutResponse
			{
				Error = (text2 ?? $"HTTP {(int)response.StatusCode}")
			};
		}
		if (string.Equals(plan, "Free", StringComparison.OrdinalIgnoreCase))
		{
			return new CheckoutResponse
			{
				Messsage = "Activated free plan.",
				CheckoutUrl = null
			};
		}
		return await response.Content.ReadFromJsonAsync<CheckoutResponse>(cancellationToken);
	}

	private static string? TryExtractMessage(string body)
	{
		if (string.IsNullOrWhiteSpace(body))
		{
			return null;
		}
		try
		{
			using JsonDocument jsonDocument = JsonDocument.Parse(body);
			if (jsonDocument.RootElement.TryGetProperty("error", out var value) && value.ValueKind == JsonValueKind.String)
			{
				return value.GetString();
			}
			if (jsonDocument.RootElement.TryGetProperty("message", out var value2) && value2.ValueKind == JsonValueKind.String)
			{
				return value2.GetString();
			}
		}
		catch
		{
		}
		return null;
	}

	public async Task<CodeChallengeFeaturesResponseDto> RequestCodeChallengeWithFeatures(string challengeString, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (!(await _validateAsync(cancellationToken)))
		{
			return new CodeChallengeFeaturesResponseDto
			{
				IsSuccess = false
			};
		}
		string content = JsonSerializer.Serialize(new
		{
			challengeBase64 = challengeString
		});
		HttpResponseMessage httpResponseMessage = await _httpClientFactory().PostAsync(new Uri(_baseUrl, "subscription-status/sign-challenge-v2"), new StringContent(content, Encoding.UTF8, "application/json"), ServiceRegion.SystemName, "execute-api", _awsCredentials, cancellationToken);
		if (!httpResponseMessage.IsSuccessStatusCode)
		{
			_logger.LogWarning("sign-challenge-v2 returned {StatusCode}", httpResponseMessage.StatusCode);
			return new CodeChallengeFeaturesResponseDto
			{
				IsSuccess = false
			};
		}
		CodeChallengeFeaturesResponseDto codeChallengeFeaturesResponseDto;
		try
		{
			codeChallengeFeaturesResponseDto = await httpResponseMessage.Content.ReadFromJsonAsync<CodeChallengeFeaturesResponseDto>(cancellationToken);
		}
		catch (JsonException exception)
		{
			_logger.LogError(exception, "Failed to deserialize sign-challenge-v2 response");
			return new CodeChallengeFeaturesResponseDto
			{
				IsSuccess = false
			};
		}
		if (codeChallengeFeaturesResponseDto == null || string.IsNullOrEmpty(codeChallengeFeaturesResponseDto.SignatureBase64) || codeChallengeFeaturesResponseDto.FeatureBits == null)
		{
			return new CodeChallengeFeaturesResponseDto
			{
				IsSuccess = false
			};
		}
		codeChallengeFeaturesResponseDto.IsSuccess = true;
		return codeChallengeFeaturesResponseDto;
	}
}
