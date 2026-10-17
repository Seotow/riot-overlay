using System;
using System.IO;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading;
using System.Threading.Tasks;
using Farsight.Exceptions;
using Farsight.Utils;
using Farsight.Web;

namespace Farsight;

public class LibInjector : IDisposable
{
	private struct RECT
	{
		public int Left;

		public int Top;

		public int Right;

		public int Bottom;
	}

	private struct POINT
	{
		public int X;

		public int Y;
	}

	private const int DONT_RESOLVE_DLL_REFERENCES = 1;

	private const int WH_GETMESSAGE = 3;

	private const int WM_NULL = 0;

	private nint _hookHandle;

	private nint _hModule;

	[DllImport("kernel32.dll")]
	private static extern uint GetLastError();

	[DllImport("user32.dll", SetLastError = true)]
	private static extern nint FindWindow(string? lpClassName, string lpWindowName);

	[DllImport("user32.dll")]
	private static extern uint GetWindowThreadProcessId(nint hWnd, out int lpdwProcessId);

	[DllImport("kernel32.dll")]
	private static extern nint LoadLibraryEx(string lpFileName, nint hFile, uint dwFlags);

	[DllImport("kernel32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool FreeLibrary(nint hModule);

	[DllImport("kernel32.dll")]
	private static extern nint GetProcAddress(nint hModule, string lpProcName);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern nint SetWindowsHookEx(int idHook, nint lpfn, nint hMod, uint dwThreadId);

	[DllImport("user32.dll")]
	private static extern bool UnhookWindowsHookEx(nint hhk);

	[DllImport("user32.dll")]
	private static extern void PostThreadMessage(uint idThread, uint Msg, nint wParam, nint lParam);

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool GetWindowRect(nint hWnd, out RECT lpRect);

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool GetClientRect(nint hWnd, out RECT lpRect);

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool ClientToScreen(nint hWnd, ref POINT lpPoint);

	public static nint GetLeagueWindow()
	{
		return FindWindow(null, "League of Legends (TM) Client");
	}

	public static WindowDimensions? GetLeagueWindowDimensions()
	{
		nint leagueWindow = GetLeagueWindow();
		if (leagueWindow == IntPtr.Zero)
		{
			return null;
		}
		return GetWindowDimensions(leagueWindow);
	}

	public static WindowDimensions? GetWindowDimensions(nint hwnd)
	{
		if (hwnd == IntPtr.Zero)
		{
			return null;
		}
		if (!GetClientRect(hwnd, out var lpRect))
		{
			return null;
		}
		POINT lpPoint = new POINT
		{
			X = lpRect.Left,
			Y = lpRect.Top
		};
		if (!ClientToScreen(hwnd, ref lpPoint))
		{
			return null;
		}
		int num = lpRect.Right - lpRect.Left;
		int num2 = lpRect.Bottom - lpRect.Top;
		if (num <= 0 || num2 <= 0)
		{
			return null;
		}
		return new WindowDimensions(lpPoint.X, lpPoint.Y, num, num2);
	}

	public async Task InjectIntoLeague(string dllPath, CancellationTokenSource cancellationToken)
	{
		nint leagueWindow = GetLeagueWindow();
		if (leagueWindow != IntPtr.Zero)
		{
			await Inject(dllPath, leagueWindow, cancellationToken);
		}
	}

	public async Task Inject(string dllPath, nint hwnd, CancellationTokenSource cancellationToken, Func<Action, bool>? installGate = null)
	{
		CancellationToken token = cancellationToken.Token;
		token.ThrowIfCancellationRequested();
		if (!File.Exists(dllPath))
		{
			throw new FileNotFoundException("Failed to find library " + dllPath);
		}
		DllValidator.Validate(dllPath);
		uint targetProcId = GetWindowThreadProcessId(hwnd, out var _);
		if (targetProcId == 0)
		{
			throw new LibLoadException("Failed to get process id for window. Invalid process id.");
		}
		token.ThrowIfCancellationRequested();
		bool spectator = await IsSpectator(targetProcId, cancellationToken);
		token.ThrowIfCancellationRequested();
		if (!spectator)
		{
			throw new NotSpectatorException("Not a spectator client.");
		}
		void Install()
		{
		token.ThrowIfCancellationRequested();
		_hModule = LoadLibraryEx(dllPath, IntPtr.Zero, 1u);
		if (_hModule == IntPtr.Zero)
		{
			throw new LibLoadException($"Failed to load library {dllPath}. Error code: {GetLastError()}");
		}
		nint procAddress = GetProcAddress(_hModule, "BlueBottleHook");
		if (procAddress == IntPtr.Zero)
		{
			FreeLibrary(_hModule);
			_hModule = IntPtr.Zero;
			throw new LibHookException($"Failed to get address of BlueBottleHook in {dllPath}. Error code: {GetLastError()}");
		}
		_hookHandle = SetWindowsHookEx(3, procAddress, _hModule, targetProcId);
		if (_hookHandle == IntPtr.Zero)
		{
			FreeLibrary(_hModule);
			_hModule = IntPtr.Zero;
			throw new LibHookException($"Failed to set hook. Error code: {GetLastError()}");
		}
		PostThreadMessage(targetProcId, 0u, IntPtr.Zero, IntPtr.Zero);
		}
		if (installGate == null) Install();
		else if (!installGate(Install)) throw new OperationCanceledException(token);
	}

	public void Release()
	{
		if (_hookHandle != IntPtr.Zero)
		{
			UnhookWindowsHookEx(_hookHandle);
			_hookHandle = IntPtr.Zero;
		}
		if (_hModule != IntPtr.Zero)
		{
			FreeLibrary(_hModule);
			_hModule = IntPtr.Zero;
		}
	}

	private static async Task<bool> IsSpectator(uint processId, CancellationTokenSource cancellationToken)
	{
		CancellationToken token = cancellationToken.Token;
		token.ThrowIfCancellationRequested();
		string resultString = null;
		int? httpStatus = 404;
		do
		{
			try
			{
				resultString = await WebClient.GetStringAsync("https://127.0.0.1:2999/liveclientdata/activeplayername/", token);
				string text = resultString.ToString().Replace("\"", "");
				if (text.Equals("Unknown", StringComparison.OrdinalIgnoreCase) || text.Equals("Spectator", StringComparison.OrdinalIgnoreCase))
				{
					return true;
				}
				await Task.Delay(1000, token);
			}
			catch (JsonException)
			{
				return false;
			}
			catch (HttpRequestException ex2)
			{
				httpStatus = (int?)ex2.StatusCode;
				await Task.Delay(1000, token);
			}
		}
		while (httpStatus == 404 && !cancellationToken.IsCancellationRequested);
		if (resultString == null)
		{
			return false;
		}
		JsonNode jsonNode;
		try
		{
			jsonNode = JsonSerializer.Deserialize<JsonNode>(resultString);
		}
		catch (JsonException)
		{
			return false;
		}
		if (jsonNode == null)
		{
			return false;
		}
		if (jsonNode["errorCode"]?.ToString().Equals("RPC_ERROR", StringComparison.OrdinalIgnoreCase) ?? false)
		{
			return true;
		}
		return false;
	}

	public void Dispose()
	{
		GC.SuppressFinalize(this);
		try
		{
			Release();
		}
		catch
		{
		}
	}
}
