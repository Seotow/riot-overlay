using System.Text.Json.Serialization;

namespace Farsight.Web;

public class CodeChallengeFeaturesResponseDto
{
	public string? SignatureBase64 { get; set; }

	[JsonConverter(typeof(FeatureBitsJsonConverter))]
	public ulong[]? FeatureBits { get; set; }

	public bool IsSuccess { get; set; }
}
