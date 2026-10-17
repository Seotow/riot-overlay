using System;

namespace Farsight.Web;

public readonly record struct SignUpResult(bool Success, string? ConflictCode, string? Message, string? ExistingProvider)
{
	public bool IsOtherIdentityConflict => string.Equals(ConflictCode, "ACCOUNT_EXISTS_OTHER_IDENTITY", StringComparison.Ordinal);

	public const string AccountExistsOtherIdentity = "ACCOUNT_EXISTS_OTHER_IDENTITY";

	public static SignUpResult Ok()
	{
		return new SignUpResult(Success: true, null, null, null);
	}

	public static SignUpResult Failed(string? message = null)
	{
		return new SignUpResult(Success: false, null, message, null);
	}

	public static SignUpResult Conflict(string code, string? message, string? existingProvider)
	{
		return new SignUpResult(Success: false, code, message, existingProvider);
	}
}
