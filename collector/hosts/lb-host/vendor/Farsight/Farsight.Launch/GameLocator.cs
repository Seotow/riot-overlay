using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Microsoft.Extensions.Logging;
using Microsoft.Win32;

namespace Farsight.Launch;

public static class GameLocator
{
	public const string GameExeName = "League of Legends.exe";

	public const string AuthoringGameExeName = "League of Legends.authoring.exe";

	private const string LiveFolderName = "League of Legends";

	internal static ILogger? Logger { get; private set; }

	public static void EnableLogging(ILoggerFactory factory)
	{
		Logger = factory.CreateLogger("GameLocator");
	}

	public static string? FindRiotGamesRoot()
	{
		foreach (string item in CandidateRoots())
		{
			if (Directory.Exists(item) && HasAnyInstall(item))
			{
				return item;
			}
		}
		return null;
	}

	public static IReadOnlyList<GameInstall> ScanInstalls()
	{
		string text = FindRiotGamesRoot();
		if (text == null)
		{
			Logger?.LogWarning("Could not locate a Riot Games root directory");
			return Array.Empty<GameInstall>();
		}
		return ScanInstalls(text);
	}

	public static IReadOnlyList<GameInstall> ScanInstalls(string riotGamesRoot)
	{
		List<GameInstall> list = new List<GameInstall>();
		if (!Directory.Exists(riotGamesRoot))
		{
			return list;
		}
		HashSet<string> runningExecutables = RunningGameExePaths();
		foreach (string item in Directory.EnumerateDirectories(riotGamesRoot))
		{
			string text = ResolveExecutable(item);
			if (text != null)
			{
				string? fileName = Path.GetFileName(item.TrimEnd(Path.DirectorySeparatorChar));
				GameKind gameKind = Classify(fileName);
				List<GameInstall> list2 = list;
				string id = fileName;
				string displayName = fileName;
				string installPath = item;
				string executablePath = text;
				GameKind kind = gameKind;
				bool requiresVanguardStop = (uint)gameKind <= 1u;
				list2.Add(new GameInstall(id, displayName, installPath, executablePath, kind, requiresVanguardStop, GetFileVersion(text), IsInstallRunning(text, runningExecutables)));
			}
		}
		return list;
	}

	public static GameInstall? DescribeInstall(string pathOrDirectory)
	{
		if (string.IsNullOrWhiteSpace(pathOrDirectory))
		{
			return null;
		}
		string text = pathOrDirectory.Trim().Trim('"');
		string text2;
		string text3;
		if (File.Exists(text))
		{
			if (!Path.GetFileName(text).Equals("League of Legends.exe", StringComparison.OrdinalIgnoreCase))
			{
				Logger?.LogWarning("Refusing to launch non-game executable: {Path}", text);
				return null;
			}
			text2 = text;
			text3 = ResolveInstallDirFromExe(text);
		}
		else
		{
			if (!Directory.Exists(text))
			{
				Logger?.LogWarning("Launch path does not exist: {Path}", text);
				return null;
			}
			text2 = ResolveExecutable(text);
			text3 = text;
		}
		if (text2 == null)
		{
			return null;
		}
		string? fileName = Path.GetFileName(text3.TrimEnd(Path.DirectorySeparatorChar));
		GameKind gameKind = Classify(fileName);
		string id = fileName;
		string displayName = fileName;
		string installPath = text3;
		string executablePath = text2;
		GameKind kind = gameKind;
		bool requiresVanguardStop = (uint)gameKind <= 1u;
		return new GameInstall(id, displayName, installPath, executablePath, kind, requiresVanguardStop, GetFileVersion(text2), IsInstallRunning(text2, RunningGameExePaths()));
	}

	private static string ResolveInstallDirFromExe(string exePath)
	{
		string text = Path.GetDirectoryName(exePath) ?? exePath;
		if (Path.GetFileName(text.TrimEnd(Path.DirectorySeparatorChar)).Equals("Game", StringComparison.OrdinalIgnoreCase))
		{
			text = Path.GetDirectoryName(text) ?? text;
		}
		return text;
	}

	private static string? ResolveExecutable(string installDir)
	{
		string text = Path.Combine(installDir, "Game", "League of Legends.exe");
		if (File.Exists(text))
		{
			return text;
		}
		string text2 = Path.Combine(installDir, "League of Legends.exe");
		if (!File.Exists(text2))
		{
			return null;
		}
		return text2;
	}

	private static GameKind Classify(string folderName)
	{
		if (folderName.Equals("League of Legends", StringComparison.OrdinalIgnoreCase))
		{
			return GameKind.Live;
		}
		if (folderName.Contains("PBE", StringComparison.OrdinalIgnoreCase))
		{
			return GameKind.Pbe;
		}
		return GameKind.Other;
	}

	private static string? GetFileVersion(string exePath)
	{
		try
		{
			return FileVersionInfo.GetVersionInfo(exePath).FileVersion;
		}
		catch
		{
			return null;
		}
	}

	private static bool HasAnyInstall(string root)
	{
		try
		{
			return Directory.EnumerateDirectories(root).Any((string d) => ResolveExecutable(d) != null);
		}
		catch
		{
			return false;
		}
	}

	private static IEnumerable<string> CandidateRoots()
	{
		foreach (string item in RegistryRoots())
		{
			yield return item;
		}
		string environmentVariable = Environment.GetEnvironmentVariable("ProgramFiles");
		string programFilesX86 = Environment.GetEnvironmentVariable("ProgramFiles(x86)");
		if (!string.IsNullOrEmpty(environmentVariable))
		{
			yield return Path.Combine(environmentVariable, "Riot Games");
		}
		if (!string.IsNullOrEmpty(programFilesX86))
		{
			yield return Path.Combine(programFilesX86, "Riot Games");
		}
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			if (driveInfo.DriveType == DriveType.Fixed && driveInfo.IsReady)
			{
				yield return Path.Combine(driveInfo.RootDirectory.FullName, "Riot Games");
			}
		}
	}

	private static IEnumerable<string> RegistryRoots()
	{
		if (!OperatingSystem.IsWindows())
		{
			yield break;
		}
		RegistryKey key = Registry.LocalMachine.OpenSubKey("SOFTWARE")?.OpenSubKey("WOW6432Node")?.OpenSubKey("Riot Games, Inc");
		if (key == null)
		{
			yield break;
		}
		string[] valueNames = key.GetValueNames();
		foreach (string name in valueNames)
		{
			if (key.GetValue(name) is string text && !string.IsNullOrWhiteSpace(text))
			{
				string text2 = TryGetRiotRoot(text);
				if (text2 != null)
				{
					yield return text2;
				}
			}
		}
	}

	private static string? TryGetRiotRoot(string path)
	{
		try
		{
			for (DirectoryInfo directoryInfo = new DirectoryInfo(path.Replace("/Location", string.Empty).Trim()); directoryInfo != null; directoryInfo = directoryInfo.Parent)
			{
				if (directoryInfo.Name.Equals("Riot Games", StringComparison.OrdinalIgnoreCase))
				{
					return directoryInfo.FullName;
				}
			}
		}
		catch
		{
		}
		return null;
	}

	private static HashSet<string> RunningGameExePaths()
	{
		HashSet<string> hashSet = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
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
					string text = process.MainModule?.FileName;
					if (!string.IsNullOrEmpty(text))
					{
						hashSet.Add(text);
					}
				}
				catch
				{
				}
				finally
				{
					process.Dispose();
				}
			}
		}
		return hashSet;
	}

	private static bool IsInstallRunning(string executablePath, HashSet<string> runningExecutables)
	{
		string path = Path.GetDirectoryName(executablePath) ?? string.Empty;
		if (!runningExecutables.Contains(executablePath))
		{
			return runningExecutables.Contains(Path.Combine(path, "League of Legends.authoring.exe"));
		}
		return true;
	}
}
