using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Farsight.Replay;
using Microsoft.Extensions.Logging;

namespace Farsight.Launch;

public static class GameLauncher
{
	internal static ILogger? Logger { get; private set; }

	public static void EnableLogging(ILoggerFactory factory)
	{
		Logger = factory.CreateLogger("GameLauncher");
	}

	public static async Task<LaunchResult> LaunchAsync(string installId, string? replayPath = null, bool enableReplayApi = false, CancellationToken cancellationToken = default(CancellationToken))
	{
		GameInstall gameInstall = GameLocator.ScanInstalls().FirstOrDefault((GameInstall i) => i.Id.Equals(installId, StringComparison.OrdinalIgnoreCase));
		if ((object)gameInstall == null)
		{
			return new LaunchResult(Success: false, "No game version with id '" + installId + "' was found. Use list_game_versions to see available ids.");
		}
		return await LaunchInstallAsync(gameInstall, replayPath, enableReplayApi, cancellationToken);
	}

	public static async Task<LaunchResult> LaunchPathAsync(string path, string? replayPath = null, bool enableReplayApi = false, CancellationToken cancellationToken = default(CancellationToken))
	{
		GameInstall gameInstall = GameLocator.DescribeInstall(path);
		if ((object)gameInstall == null)
		{
			return new LaunchResult(Success: false, "No 'League of Legends.exe' found at '" + path + "'. Provide an install folder or a direct path to League of Legends.exe.");
		}
		return await LaunchInstallAsync(gameInstall, replayPath, enableReplayApi, cancellationToken);
	}

	public static async Task<LaunchResult> LaunchReplayAutoAsync(string replayPath, bool enableReplayApi = false, CancellationToken cancellationToken = default(CancellationToken))
	{
		string text = replayPath.Trim().Trim('"');
		if (!File.Exists(text))
		{
			return new LaunchResult(Success: false, "Replay file not found: '" + text + "'.");
		}
		if (!ReplayFile.TryReadGameVersion(text, out string version) || version == null)
		{
			return new LaunchResult(Success: false, "Could not read the game version from the replay. Launch with an explicit versionId or path instead.");
		}
		string patch = ReplayFile.PatchOf(version);
		IReadOnlyList<GameInstall> readOnlyList = GameLocator.ScanInstalls();
		GameInstall gameInstall = (from i in readOnlyList
			where i.DetectedVersion == version || ReplayFile.PatchOf(i.DetectedVersion) == patch || (patch != null && i.Id.Contains(patch, StringComparison.OrdinalIgnoreCase))
			orderby i.Kind switch
			{
				GameKind.Other => 0, 
				GameKind.Pbe => 1, 
				_ => 2, 
			}, i.DetectedVersion == version descending
			select i).FirstOrDefault();
		if ((object)gameInstall == null)
		{
			string value = ((readOnlyList.Count == 0) ? "none found" : string.Join(", ", readOnlyList.Select((GameInstall i) => i.Id + " (" + (i.DetectedVersion ?? "?") + ")")));
			return new LaunchResult(Success: false, $"No installed game version matches replay patch '{patch}' (replay version {version}). Available: {value}.");
		}
		Logger?.LogInformation("Auto-matched replay {Version} to install {Install} ({InstallVersion})", version, gameInstall.Id, gameInstall.DetectedVersion);
		return await LaunchInstallAsync(gameInstall, text, enableReplayApi, cancellationToken);
	}

	private static async Task<LaunchResult> LaunchInstallAsync(GameInstall install, string? replayPath, bool enableReplayApi, CancellationToken cancellationToken)
	{
		if (install.IsRunning)
		{
			return new LaunchResult(Success: false, "'" + install.DisplayName + "' is already running.");
		}
		if (install.RequiresVanguardStop)
		{
			VanguardResult vanguardResult = await VanguardController.StopAsync(cancellationToken);
			if (!vanguardResult.Success)
			{
				return new LaunchResult(Success: false, "Could not launch '" + install.DisplayName + "': " + vanguardResult.Message);
			}
			Logger?.LogInformation("Vanguard stop before launch: {Message}", vanguardResult.Message);
		}
		return await StartProcessAsync(install, replayPath, enableReplayApi, cancellationToken);
	}

	public static LaunchResult CloseGame()
	{
		int num = 0;
		string[] array = new string[2]
		{
			Path.GetFileNameWithoutExtension("League of Legends.exe"),
			Path.GetFileNameWithoutExtension("League of Legends.authoring.exe")
		};
		for (int i = 0; i < array.Length; i++)
		{
			Process[] processesByName = Process.GetProcessesByName(array[i]);
			foreach (Process process in processesByName)
			{
				try
				{
					process.Kill(entireProcessTree: true);
					process.WaitForExit(5000);
					num++;
				}
				catch (Exception exception)
				{
					Logger?.LogWarning(exception, "Failed to terminate game process {Pid}", process.Id);
				}
				finally
				{
					process.Dispose();
				}
			}
		}
		if (num <= 0)
		{
			return new LaunchResult(Success: false, "No running game process was found.");
		}
		return new LaunchResult(Success: true, $"Closed {num} running game process(es).");
	}

	private static async Task<LaunchResult> StartProcessAsync(GameInstall install, string? replayPath, bool enableReplayApi, CancellationToken cancellationToken)
	{
		if (enableReplayApi)
		{
			await ReplayConnector.EnableReplayApi(Path.Combine(install.InstallPath, "Config"), cancellationToken);
		}
		string workingDirectory = Path.GetDirectoryName(install.ExecutablePath) ?? install.InstallPath;
		string text = string.Empty;
		if (!string.IsNullOrWhiteSpace(replayPath))
		{
			string text2 = replayPath.Trim().Trim('"');
			if (!File.Exists(text2))
			{
				return new LaunchResult(Success: false, "Replay file not found: '" + text2 + "'.");
			}
			if (!Path.GetExtension(text2).Equals(".rofl", StringComparison.OrdinalIgnoreCase))
			{
				return new LaunchResult(Success: false, "Replay must be a .rofl file: '" + text2 + "'.");
			}
			text = "\"" + Path.GetFullPath(text2) + "\"";
		}
		try
		{
			Process process = Process.Start(new ProcessStartInfo
			{
				FileName = install.ExecutablePath,
				Arguments = text,
				WorkingDirectory = workingDirectory,
				UseShellExecute = true
			});
			if (process == null)
			{
				return new LaunchResult(Success: false, "Failed to start '" + install.ExecutablePath + "'.");
			}
			string text3 = ((text.Length == 0) ? install.DisplayName : (install.DisplayName + " (replay)"));
			Logger?.LogInformation("Launched {Name} (pid {Pid})", text3, process.Id);
			return new LaunchResult(Success: true, "Launched '" + text3 + "'.", process.Id);
		}
		catch (Exception ex)
		{
			Logger?.LogError(ex, "Failed to launch {Name}", install.DisplayName);
			return new LaunchResult(Success: false, "Failed to launch '" + install.DisplayName + "': " + ex.Message);
		}
	}
}
