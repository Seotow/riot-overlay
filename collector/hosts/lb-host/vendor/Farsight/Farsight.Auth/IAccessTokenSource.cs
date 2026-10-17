namespace Farsight.Auth;

public interface IAccessTokenSource
{
	string? AccessToken { get; set; }
}
