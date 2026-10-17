namespace Farsight.Launch;

public record LaunchResult(bool Success, string Message, int? ProcessId = null);
