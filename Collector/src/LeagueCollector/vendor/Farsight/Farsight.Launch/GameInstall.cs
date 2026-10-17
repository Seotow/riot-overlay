namespace Farsight.Launch;

public record GameInstall(string Id, string DisplayName, string InstallPath, string ExecutablePath, GameKind Kind, bool RequiresVanguardStop, string? DetectedVersion, bool IsRunning);
