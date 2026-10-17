using System.Text.Json.Serialization;

namespace Farsight.Web;

public class SessionAuthResponse
{
	[JsonPropertyName("customer_auth_token")]
	public string? CustomerAuthToken { get; set; }

	[JsonPropertyName("expires_at")]
	public string? ExpiresAt { get; set; }
}
