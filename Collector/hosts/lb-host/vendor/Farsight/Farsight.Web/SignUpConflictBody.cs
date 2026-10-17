namespace Farsight.Web;

internal sealed class SignUpConflictBody
{
	public string? Error { get; set; }

	public string? Code { get; set; }

	public string? ExistingProvider { get; set; }
}
