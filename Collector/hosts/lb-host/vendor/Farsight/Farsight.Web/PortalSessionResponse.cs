using System.Text.Json.Serialization;

namespace Farsight.Web;

public class PortalSessionResponse
{
	[JsonPropertyName("portalUrl")]
	public string? PortalUrl { get; set; }
}
