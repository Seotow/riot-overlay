using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace Farsight.Launch;

public static class VanguardController
{
	private const string ServiceName = "vgc";

	internal static ILogger? Logger { get; private set; }

	public static void EnableLogging(ILoggerFactory factory)
	{
		Logger = factory.CreateLogger("VanguardController");
	}

	public static VanguardStatus GetStatus()
	{
		string text = QueryServiceState("vgc");
		bool flag = HasProcess("vgtray");
		bool flag2 = HasProcess("vgc");
		bool isRunning = (text == "RUNNING") | flag | flag2;
		return new VanguardStatus(text, flag, isRunning);
	}

	public static async Task<VanguardResult> StopAsync(CancellationToken cancellationToken = default(CancellationToken))
	{
		if (!GetStatus().IsRunning)
		{
			return new VanguardResult(Success: true, "Vanguard is already stopped.");
		}
		if (IsElevated())
		{
			RunInline("sc", "stop vgc");
			RunInline("taskkill", "/F /IM vgtray.exe");
			RunInline("taskkill", "/F /IM vgc.exe");
		}
		else if (!TryRunElevated("cmd.exe", "/c sc stop vgc & taskkill /F /IM vgtray.exe & taskkill /F /IM vgc.exe"))
		{
			return new VanguardResult(Success: false, "Vanguard stop was cancelled or elevation was denied.");
		}
		await Task.Delay(1500, cancellationToken);
		VanguardStatus status = GetStatus();
		return status.IsRunning ? new VanguardResult(Success: false, "Attempted to stop Vanguard but it is still running (service state: " + status.ServiceState + ").") : new VanguardResult(Success: true, "Vanguard stopped.");
	}

	private static bool IsElevated()
	{
		if (!OperatingSystem.IsWindows())
		{
			return false;
		}
		using WindowsIdentity ntIdentity = WindowsIdentity.GetCurrent();
		return new WindowsPrincipal(ntIdentity).IsInRole(WindowsBuiltInRole.Administrator);
	}

	private static string QueryServiceState(string service)
	{
		try
		{
			using Process process = Process.Start(new ProcessStartInfo
			{
				FileName = "sc",
				Arguments = "query " + service,
				UseShellExecute = false,
				RedirectStandardOutput = true,
				CreateNoWindow = true
			});
			if (process == null)
			{
				return "UNKNOWN";
			}
			string text = process.StandardOutput.ReadToEnd();
			process.WaitForExit(5000);
			if (text.Contains("does not exist", StringComparison.OrdinalIgnoreCase) || text.Contains("1060"))
			{
				return "NOT_INSTALLED";
			}
			if (text.Contains("STOP_PENDING"))
			{
				return "STOP_PENDING";
			}
			if (text.Contains("START_PENDING"))
			{
				return "START_PENDING";
			}
			if (text.Contains("RUNNING"))
			{
				return "RUNNING";
			}
			if (text.Contains("STOPPED"))
			{
				return "STOPPED";
			}
			return "UNKNOWN";
		}
		catch (Exception exception)
		{
			Logger?.LogWarning(exception, "Failed to query Vanguard service state");
			return "UNKNOWN";
		}
	}

	private static void RunInline(string file, string arguments)
	{
		try
		{
			using Process process = Process.Start(new ProcessStartInfo
			{
				FileName = file,
				Arguments = arguments,
				UseShellExecute = false,
				CreateNoWindow = true,
				RedirectStandardOutput = true,
				RedirectStandardError = true
			});
			process?.WaitForExit(10000);
		}
		catch (Exception exception)
		{
			Logger?.LogWarning(exception, "Vanguard stop step failed: {File} {Args}", file, arguments);
		}
	}

	private static bool TryRunElevated(string file, string arguments)
	{
		try
		{
			using Process process = Process.Start(new ProcessStartInfo
			{
				FileName = file,
				Arguments = arguments,
				UseShellExecute = true,
				Verb = "runas",
				CreateNoWindow = true,
				WindowStyle = ProcessWindowStyle.Hidden
			});
			if (process == null)
			{
				return false;
			}
			process.WaitForExit(15000);
			return true;
		}
		catch (Win32Exception)
		{
			return false;
		}
		catch (Exception exception)
		{
			Logger?.LogWarning(exception, "Failed to run elevated Vanguard stop");
			return false;
		}
	}

	private static bool HasProcess(string processName)
	{
		Process[] processesByName = Process.GetProcessesByName(processName);
		try
		{
			return processesByName.Length != 0;
		}
		finally
		{
			Process[] array = processesByName;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].Dispose();
			}
		}
	}
}
