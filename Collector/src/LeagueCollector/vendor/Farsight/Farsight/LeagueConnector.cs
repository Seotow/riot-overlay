using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using BlueBottleIPC.LeagueBroadcast.Commands;
using BlueBottleIPC.LeagueBroadcast.Common;
using BlueBottleIPC.LeagueBroadcast.Snapshot;
using Farsight.Auth;
using Farsight.Diagnostics;
using Farsight.Entity;
using Farsight.Exceptions;
using Farsight.IPC2;
using Farsight.Replay;
using Farsight.Utils;
using Farsight.Web;
using Microsoft.Extensions.Logging;

namespace Farsight;

public static class LeagueConnector
{
	private enum WinEvents : uint
	{
		EVENT_AIA_START = 40960u,
		EVENT_AIA_END = 45055u,
		EVENT_MIN = 1u,
		EVENT_MAX = 2147483647u,
		EVENT_OBJECT_ACCELERATORCHANGE = 32786u,
		EVENT_OBJECT_CLOAKED = 32791u,
		EVENT_OBJECT_CONTENTSCROLLED = 32789u,
		EVENT_OBJECT_CREATE = 32768u,
		EVENT_OBJECT_DEFACTIONCHANGE = 32785u,
		EVENT_OBJECT_DESCRIPTIONCHANGE = 32781u,
		EVENT_OBJECT_DESTROY = 32769u,
		EVENT_OBJECT_DRAGSTART = 32801u,
		EVENT_OBJECT_DRAGCANCEL = 32802u,
		EVENT_OBJECT_DRAGCOMPLETE = 32803u,
		EVENT_OBJECT_DRAGENTER = 32804u,
		EVENT_OBJECT_DRAGLEAVE = 32805u,
		EVENT_OBJECT_DRAGDROPPED = 32806u,
		EVENT_OBJECT_END = 33023u,
		EVENT_OBJECT_FOCUS = 32773u,
		EVENT_OBJECT_HELPCHANGE = 32784u,
		EVENT_OBJECT_HIDE = 32771u,
		EVENT_OBJECT_HOSTEDOBJECTSINVALIDATED = 32800u,
		EVENT_OBJECT_IME_HIDE = 32808u,
		EVENT_OBJECT_IME_SHOW = 32807u,
		EVENT_OBJECT_IME_CHANGE = 32809u,
		EVENT_OBJECT_INVOKED = 32787u,
		EVENT_OBJECT_LIVEREGIONCHANGED = 32793u,
		EVENT_OBJECT_LOCATIONCHANGE = 32779u,
		EVENT_OBJECT_NAMECHANGE = 32780u,
		EVENT_OBJECT_PARENTCHANGE = 32783u,
		EVENT_OBJECT_REORDER = 32772u,
		EVENT_OBJECT_SELECTION = 32774u,
		EVENT_OBJECT_SELECTIONADD = 32775u,
		EVENT_OBJECT_SELECTIONREMOVE = 32776u,
		EVENT_OBJECT_SELECTIONWITHIN = 32777u,
		EVENT_OBJECT_SHOW = 32770u,
		EVENT_OBJECT_STATECHANGE = 32778u,
		EVENT_OBJECT_TEXTEDIT_CONVERSIONTARGETCHANGED = 32816u,
		EVENT_OBJECT_TEXTSELECTIONCHANGED = 32788u,
		EVENT_OBJECT_UNCLOAKED = 32792u,
		EVENT_OBJECT_VALUECHANGE = 32782u,
		EVENT_OEM_DEFINED_START = 257u,
		EVENT_OEM_DEFINED_END = 511u,
		EVENT_SYSTEM_ALERT = 2u,
		EVENT_SYSTEM_ARRANGMENTPREVIEW = 32790u,
		EVENT_SYSTEM_CAPTUREEND = 9u,
		EVENT_SYSTEM_CAPTURESTART = 8u,
		EVENT_SYSTEM_CONTEXTHELPEND = 13u,
		EVENT_SYSTEM_CONTEXTHELPSTART = 12u,
		EVENT_SYSTEM_DESKTOPSWITCH = 32u,
		EVENT_SYSTEM_DIALOGEND = 17u,
		EVENT_SYSTEM_DIALOGSTART = 16u,
		EVENT_SYSTEM_DRAGDROPEND = 15u,
		EVENT_SYSTEM_DRAGDROPSTART = 14u,
		EVENT_SYSTEM_END = 255u,
		EVENT_SYSTEM_FOREGROUND = 3u,
		EVENT_SYSTEM_MENUPOPUPEND = 7u,
		EVENT_SYSTEM_MENUPOPUPSTART = 6u,
		EVENT_SYSTEM_MENUEND = 5u,
		EVENT_SYSTEM_MENUSTART = 4u,
		EVENT_SYSTEM_MINIMIZEEND = 23u,
		EVENT_SYSTEM_MINIMIZESTART = 22u,
		EVENT_SYSTEM_MOVESIZEEND = 11u,
		EVENT_SYSTEM_MOVESIZESTART = 10u,
		EVENT_SYSTEM_SCROLLINGEND = 19u,
		EVENT_SYSTEM_SCROLLINGSTART = 18u,
		EVENT_SYSTEM_SWITCHEND = 21u,
		EVENT_SYSTEM_SWITCHSTART = 20u,
		EVENT_UIA_EVENTID_START = 19968u,
		EVENT_UIA_EVENTID_END = 20223u,
		EVENT_UIA_PROPID_START = 29952u,
		EVENT_UIA_PROPID_END = 30207u
	}

	private enum WinEventFlags : uint
	{
		WINEVENT_OUTOFCONTEXT = 0u,
		WINEVENT_SKIPOWNTHREAD = 1u,
		WINEVENT_SKIPOWNPROCESS = 2u,
		WINEVENT_INCONTEXT = 4u
	}

	private delegate void WinEventDelegate(nint hWinEventHook, uint eventType, nint hwnd, int idObject, int idChild, uint dwEventThread, uint dwmsEventTime);

	private struct MSG
	{
		public nint hwnd;

		public uint message;

		public nint wParam;

		public nint lParam;

		public uint time;

		public int ptX;

		public int ptY;
	}

	private sealed class Destructor
	{
		~Destructor()
		{
			StopWatchingForGameStart();
		}
	}

	private static readonly object _nativeCrashMonitorGate;

	private static int _nativeCrashMonitorGeneration;

	private static NativeCrashMonitor? _nativeCrashMonitor;

	private const uint WM_QUIT = 18u;

	private static readonly Destructor Finalise;

	[CompilerGenerated]
	private static bool AutoInject__BackingField;

	[CompilerGenerated]
	private static bool IgnoreOffsetVersionCheck__BackingField;

	[CompilerGenerated]
	private static bool WatchingForGameStart__BackingField;

	private static readonly LibInjector _injector;

	private static nint? _windowHook;

	private static nint? _leagueWindow;

	[CompilerGenerated]
	private static FeatureSet RequestedFeatures__BackingField;

	private static readonly TimeSpan FeatureAuthenticationResponseTimeout;

	private static IGameLibFetcher? GameLibFetcher;

	private static readonly SemaphoreSlim _featureHandshakeGate;

	private static CancellationTokenSource? _injectionCancelToken;
	private static readonly ManagedWatcherLifetime _watchLifetime = new();
	private static ManagedWatcherLifetime.WatchLease _watchLease;
	private static readonly object _watchTaskGate = new();
	private static readonly HashSet<Task> _watchTasks = new();
	private static Task _managedDisconnectTask = Task.CompletedTask;

	private static Process? _gameProcessWatch;

	private static volatile int _gamePid;

	private static volatile bool _gameProcessExited;

	private static WinEventDelegate? _winEventDelegate;

	private static GCHandle _winEventDelegateGcHandler;

	private static Thread? _messageLoopThread;

	private static uint _messageLoopThreadId;

	private static readonly string[] TARGET_PROCESS_NAMES;

	internal static readonly FarsightSocketClient? _farsightSocket;

	private static short _port;

	private static bool _ownsEditorHotkeys;

	private static bool _capturesKeyboard;

	private static TaskCompletionSource<bool> _handshake;

	public static bool AutoInject
	{
		[CompilerGenerated]
		get
		{
			return AutoInject__BackingField;
		}
		[CompilerGenerated]
		set
		{
			AutoInject__BackingField = value;
		}
	}

	public static bool IgnoreOffsetVersionCheck
	{
		[CompilerGenerated]
		get
		{
			return IgnoreOffsetVersionCheck__BackingField;
		}
		[CompilerGenerated]
		set
		{
			IgnoreOffsetVersionCheck__BackingField = value;
		}
	}

	public static bool WatchingForGameStart
	{
		[CompilerGenerated]
		get
		{
			return WatchingForGameStart__BackingField;
		}
		[CompilerGenerated]
		set
		{
			WatchingForGameStart__BackingField = value;
		}
	}

	public static int? GameProcessId
	{
		get
		{
			int gamePid = _gamePid;
			if (gamePid <= 0)
			{
				return null;
			}
			return gamePid;
		}
	}

	internal static ILoggerFactory? LoggerFactory { get; private set; }

	internal static ILogger? Logger { get; private set; }

	internal static FeatureSet RequestedFeatures
	{
		[CompilerGenerated]
		get
		{
			return RequestedFeatures__BackingField;
		}
		[CompilerGenerated]
		private set
		{
			RequestedFeatures__BackingField = value;
		}
	}

	private static Func<string, Task<CodeChallengeResult?>>? CodeChallengeFunc { get; set; }

	public static SceneConnector? SceneConnector { get; private set; }

	public static short Port
	{
		get
		{
			return _port;
		}
		set
		{
			FarsightSocketClient? farsightSocket = _farsightSocket;
			if (farsightSocket != null)
			{
				farsightSocket.Port = value;
			}
			_port = value;
		}
	}

	public static string? AppId { get; set; }

	public static bool PreferTcpTransport
	{
		get => _farsightSocket?.PreferTcp ?? false;
		set { if (_farsightSocket != null) _farsightSocket.PreferTcp = value; }
	}

	public static bool IsReady
	{
		get
		{
			Task<bool> task = _handshake.Task;
			if (IsConnected() && task.IsCompletedSuccessfully)
			{
				return task.Result;
			}
			return false;
		}
	}

	public static bool HandshakeFailed
	{
		get
		{
			Task<bool> task = _handshake.Task;
			if (task.IsCompletedSuccessfully)
			{
				return !task.Result;
			}
			return false;
		}
	}

	public static event EventHandler<NativeCrashReport>? NativeCrashReported;

	public static event EventHandler<GameWindowOpenedEventArgs>? GameWindowOpened;

	public static event EventHandler<GameWindowClosedEventArgs>? GameWindowClosed;

	public static event EventHandler? Injected;

	public static event EventHandler<Exception>? InjectionFailed;

	public static event EventHandler<NativeGameStartedEventArgs>? GameStarted;

	public static event EventHandler<NativeGameEndedEventArgs>? GameEnded;

	public static event EventHandler<GameInfo>? GameInfoReceived;

	public static event EventHandler<GameStateMetaData>? GameStateMetaDataReceived;

	public static event EventHandler<MirrorStateEventArgs>? MirrorStateReceived;

	public static event EventHandler<CameraStateEventArgs>? CameraStateReceived;

	public static event EventHandler<PenEraserStateChangedEventArgs>? PenEraserStateChangedReceived;

	private static async Task TryAttachNativeCrashMonitor(TaskCompletionSource<bool> handshake)
	{
		FarsightSocketClient socket = _farsightSocket;
		int expectedPid = _gamePid;
		int generation;
		lock (_nativeCrashMonitorGate)
		{
			generation = _nativeCrashMonitorGeneration;
		}
		if (!WatchingForGameStart)
		{
			return;
		}
		if (socket == null || socket.SelectedTransport != FarsightIpcTransport.NamedPipe || RequestedFeatures.IsEmpty || expectedPid <= 0 || !IsCurrentHandshake(handshake))
		{
			return;
		}
		try
		{
			Response response = await socket.SendAndWaitForResponse(new Request
			{
				Data = new RequestKind(new EphemeralAction
				{
					RequestId = EphemeralType.GetCrashReportChannel
				})
			}, null, TimeSpan.FromMilliseconds(500L));
			if (response == null || response.Data.Kind != ResponseKind.ItemKind.CrashReportChannel)
			{
				return;
			}
			string text = response.Data.CrashReportChannel?.Name;
			if (text == null)
			{
				return;
			}
			NativeCrashMonitor nativeCrashMonitor2;
			lock (_nativeCrashMonitorGate)
			{
				if (!WatchingForGameStart || generation != _nativeCrashMonitorGeneration || !IsCurrentHandshake(handshake) || _gamePid != expectedPid || socket.SelectedTransport != FarsightIpcTransport.NamedPipe)
				{
					return;
				}
				NativeCrashMonitor nativeCrashMonitor = new NativeCrashMonitor(text, expectedPid, PublishNativeCrashReport);
				nativeCrashMonitor2 = _nativeCrashMonitor;
				_nativeCrashMonitor = nativeCrashMonitor;
			}
			nativeCrashMonitor2?.Dispose();
		}
		catch (Exception exception)
		{
			Logger?.LogDebug(exception, "Native crash channel unavailable");
		}
	}

	private static void PublishNativeCrashReport(NativeCrashReport report)
	{
		EventHandler<NativeCrashReport> nativeCrashReported = NativeCrashReported;
		if (nativeCrashReported == null)
		{
			return;
		}
		Delegate[] invocationList = nativeCrashReported.GetInvocationList();
		for (int i = 0; i < invocationList.Length; i++)
		{
			EventHandler<NativeCrashReport> eventHandler = (EventHandler<NativeCrashReport>)invocationList[i];
			try
			{
				eventHandler(null, report);
			}
			catch (Exception exception)
			{
				Logger?.LogError(exception, "Native crash report subscriber failed");
			}
		}
	}

	private static void StopNativeCrashMonitor()
	{
		NativeCrashMonitor nativeCrashMonitor;
		lock (_nativeCrashMonitorGate)
		{
			_nativeCrashMonitorGeneration++;
			nativeCrashMonitor = _nativeCrashMonitor;
			_nativeCrashMonitor = null;
		}
		nativeCrashMonitor?.Dispose();
	}

	[LibraryImport("user32.dll")]
	[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "10.0.14.37416")]
	[SkipLocalsInit]
	private static nint SetWinEventHook(WinEvents eventMin, WinEvents eventMax, nint hmodWinEventProc, WinEventDelegate lpfnWinEventProc, uint idProcess, uint idThread, WinEventFlags dwFlags)
	{
		nint _lpfnWinEventProc_native = ((lpfnWinEventProc != null) ? Marshal.GetFunctionPointerForDelegate(lpfnWinEventProc) : 0);
		nint result = __PInvoke(eventMin, eventMax, hmodWinEventProc, _lpfnWinEventProc_native, idProcess, idThread, dwFlags);
		GC.KeepAlive(lpfnWinEventProc);
		return result;
		[DllImport("user32.dll", EntryPoint = "SetWinEventHook", ExactSpelling = true)]
		static extern nint __PInvoke(WinEvents __eventMin_native, WinEvents __eventMax_native, nint __hmodWinEventProc_native, nint __lpfnWinEventProc_native, uint __idProcess_native, uint __idThread_native, WinEventFlags __dwFlags_native);
	}

	[LibraryImport("user32.dll")]
	[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "10.0.14.37416")]
	[SkipLocalsInit]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static bool UnhookWinEvent(nint hWinEventHook)
	{
		return __PInvoke(hWinEventHook) != 0;
		[DllImport("user32.dll", EntryPoint = "UnhookWinEvent", ExactSpelling = true)]
		static extern int __PInvoke(nint __hWinEventHook_native);
	}

	[LibraryImport("user32.dll", SetLastError = true)]
	[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "10.0.14.37416")]
	[SkipLocalsInit]
	private unsafe static uint GetWindowThreadProcessId(nint hWnd, out uint lpdwProcessId)
	{
		lpdwProcessId = 0u;
		uint result;
		int lastSystemError;
		fixed (uint* _lpdwProcessId_native = &lpdwProcessId)
		{
			Marshal.SetLastSystemError(0);
			result = __PInvoke(hWnd, _lpdwProcessId_native);
			lastSystemError = Marshal.GetLastSystemError();
		}
		Marshal.SetLastPInvokeError(lastSystemError);
		return result;
		[DllImport("user32.dll", EntryPoint = "GetWindowThreadProcessId", ExactSpelling = true)]
		unsafe static extern uint __PInvoke(nint __hWnd_native, uint* __lpdwProcessId_native);
	}

	[LibraryImport("user32.dll", EntryPoint = "GetMessageW")]
	[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "10.0.14.37416")]
	[SkipLocalsInit]
	private unsafe static int GetMessage(out MSG lpMsg, nint hWnd, uint wMsgFilterMin, uint wMsgFilterMax)
	{
		lpMsg = default;
		int result;
		fixed (MSG* _lpMsg_native = &lpMsg)
		{
			result = __PInvoke(_lpMsg_native, hWnd, wMsgFilterMin, wMsgFilterMax);
		}
		return result;
		[DllImport("user32.dll", EntryPoint = "GetMessageW", ExactSpelling = true)]
		unsafe static extern int __PInvoke(MSG* __lpMsg_native, nint __hWnd_native, uint __wMsgFilterMin_native, uint __wMsgFilterMax_native);
	}

	[LibraryImport("user32.dll")]
	[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "10.0.14.37416")]
	[SkipLocalsInit]
	[return: MarshalAs(UnmanagedType.Bool)]
	private unsafe static bool TranslateMessage(in MSG lpMsg)
	{
		int num;
		fixed (MSG* _lpMsg_native = &lpMsg)
		{
			num = __PInvoke(_lpMsg_native);
		}
		return num != 0;
		[DllImport("user32.dll", EntryPoint = "TranslateMessage", ExactSpelling = true)]
		unsafe static extern int __PInvoke(MSG* __lpMsg_native);
	}

	[LibraryImport("user32.dll", EntryPoint = "DispatchMessageW")]
	[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "10.0.14.37416")]
	[SkipLocalsInit]
	private unsafe static nint DispatchMessage(in MSG lpMsg)
	{
		nint result;
		fixed (MSG* _lpMsg_native = &lpMsg)
		{
			result = __PInvoke(_lpMsg_native);
		}
		return result;
		[DllImport("user32.dll", EntryPoint = "DispatchMessageW", ExactSpelling = true)]
		unsafe static extern nint __PInvoke(MSG* __lpMsg_native);
	}

	[LibraryImport("user32.dll", EntryPoint = "PostThreadMessageW")]
	[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "10.0.14.37416")]
	[SkipLocalsInit]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static bool PostThreadMessage(uint idThread, uint msg, nint wParam, nint lParam)
	{
		return __PInvoke(idThread, msg, wParam, lParam) != 0;
		[DllImport("user32.dll", EntryPoint = "PostThreadMessageW", ExactSpelling = true)]
		static extern int __PInvoke(uint __idThread_native, uint __msg_native, nint __wParam_native, nint __lParam_native);
	}

	[DllImport("kernel32.dll", ExactSpelling = true)]
	[LibraryImport("kernel32.dll")]
	private static extern uint GetCurrentThreadId();

	[LibraryImport("kernel32.dll", SetLastError = true)]
	[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "10.0.14.37416")]
	[SkipLocalsInit]
	[return: MarshalAs(UnmanagedType.Bool)]
	private unsafe static bool ProcessIdToSessionId(uint processId, out uint sessionId)
	{
		sessionId = 0u;
		int num;
		int lastSystemError;
		fixed (uint* _sessionId_native = &sessionId)
		{
			Marshal.SetLastSystemError(0);
			num = __PInvoke(processId, _sessionId_native);
			lastSystemError = Marshal.GetLastSystemError();
		}
		bool result = num != 0;
		Marshal.SetLastPInvokeError(lastSystemError);
		return result;
		[DllImport("kernel32.dll", EntryPoint = "ProcessIdToSessionId", ExactSpelling = true)]
		unsafe static extern int __PInvoke(uint __processId_native, uint* __sessionId_native);
	}

	public static WindowDimensions? GetGameWindowDimensions()
	{
		nint? leagueWindow = _leagueWindow;
		if (!leagueWindow.HasValue || leagueWindow.Value == IntPtr.Zero)
		{
			return null;
		}
		nint leagueWindow2 = LibInjector.GetLeagueWindow();
		if (leagueWindow2 == IntPtr.Zero)
		{
			return null;
		}
		return LibInjector.GetWindowDimensions(leagueWindow2);
	}

	static LeagueConnector()
	{
		_nativeCrashMonitorGate = new object();
		Finalise = new Destructor();
		AutoInject__BackingField = false;
		IgnoreOffsetVersionCheck__BackingField = false;
		WatchingForGameStart__BackingField = false;
		RequestedFeatures__BackingField = FeatureSet.Empty;
		FeatureAuthenticationResponseTimeout = TimeSpan.FromSeconds(10L);
		_featureHandshakeGate = new SemaphoreSlim(1, 1);
		TARGET_PROCESS_NAMES = new string[2] { "League of Legends.exe", "League of Legends.authoring.exe" };
		_handshake = new TaskCompletionSource<bool>(TaskCreationOptions.RunContinuationsAsynchronously);
		_injector = new LibInjector();
		_farsightSocket = new FarsightSocketClient();
		_farsightSocket.ResponseReceived += Socket_ResponseReceived;
		SceneConnector = new SceneConnector(_farsightSocket);
		Logger?.LogInformation("LeagueConnector initialized");
	}

	public static void AddFeatures(FeatureSet features, Func<string, Task<CodeChallengeResult?>> RequestCodeCallenge)
	{
		CodeChallengeFunc = RequestCodeCallenge;
		FeatureSet featureSet = RequestedFeatures.UnionWith(features);
		if (featureSet.ToBits() == RequestedFeatures.ToBits())
		{
			Logger?.LogDebug("Requested features {Features} add nothing to current set {CurrentFeatures}. Ignoring.", features, RequestedFeatures);
		}
		else
		{
			RequestedFeatures = featureSet;
		}
	}

	public static void EnableLogging(ILoggerFactory factory)
	{
		LoggerFactory = factory;
		Logger = LoggerFactory.CreateLogger("LeagueConnector");
		_farsightSocket?.EnableLogging(LoggerFactory.CreateLogger<FarsightSocketClient>());
		SceneConnector?.EnableLogging(factory);
		LeagueDrawingConnector.EnableLogging(factory);
		LeaguePlaybackConnector.EnableLogging(factory);
		LeagueRenderSettingsConnector.EnableLogging(factory);
		ReplayConnector.EnableLogging(factory);
	}

	public static void DisableLogging()
	{
		Logger = null;
		SceneConnector?.DisableLogging();
		LeagueDrawingConnector.DisableLogging();
		LeaguePlaybackConnector.DisableLogging();
		LeagueRenderSettingsConnector.DisableLogging();
		ReplayConnector.DisableLogging();
		_farsightSocket?.DisableLogging();
	}

	public static void EnableGameLibFetching(IGameLibFetcher gamelibFetcher)
	{
		GameLibFetcher = gamelibFetcher;
	}

	public static void DisableGameLibFetching()
	{
		GameLibFetcher = null;
	}

	public static bool IsConnectedOrConnecting()
	{
		if (!IsConnected())
		{
			return IsConnecting();
		}
		return true;
	}

	public static bool IsConnected()
	{
		FarsightSocketClient? farsightSocket = _farsightSocket;
		if (farsightSocket == null)
		{
			return false;
		}
		return farsightSocket.ConnectionStatus == ConnectionStatus.Connected;
	}

	private static bool IsCurrentHandshake(TaskCompletionSource<bool> handshake)
	{
		if (handshake == _handshake)
		{
			return _farsightSocket?.IsConnected ?? false;
		}
		return false;
	}

	public static bool IsConnecting()
	{
		FarsightSocketClient? farsightSocket = _farsightSocket;
		if (farsightSocket == null)
		{
			return false;
		}
		return farsightSocket.ConnectionStatus == ConnectionStatus.Connecting;
	}

	private static void ExecuteInMainContext(SynchronizationContext? context, Action action, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (context == null)
		{
			context = SynchronizationContext.Current;
		}
		if (context != null)
		{
			context.Send((object? _) =>
			{
				action();
			}, null);
			context.Post((object? _) =>
			{
				action();
			}, null);
		}
		else
		{
			Task.Factory.StartNew(action, cancellationToken);
		}
	}

	private static Task TrackWatchTask(Task task)
	{
		lock (_watchTaskGate) _watchTasks.Add(task);
		_ = task.ContinueWith(completed => { lock (_watchTaskGate) _watchTasks.Remove(completed); },
			CancellationToken.None, TaskContinuationOptions.ExecuteSynchronously, TaskScheduler.Default);
		return task;
	}

	private static Task CheckForLeagueWindow(CancellationToken cancellationToken = default)
	{
		var lease = _watchLease;
		if (cancellationToken.IsCancellationRequested || !_watchLifetime.IsCurrent(lease)) return Task.CompletedTask;
		nint found = TARGET_PROCESS_NAMES.Select(WndSearcher.FindWindowByProcessName).FirstOrDefault(hwnd => hwnd != IntPtr.Zero);
		if (found == IntPtr.Zero) return Task.CompletedTask;
		Task task = Task.CompletedTask;
		_watchLifetime.TryRun(lease, () => {
			_leagueWindow = found;
			task = TrackWatchTask(Task.Run(() => InvokeGameWindowOpened(lease), lease.Token));
		});
		return task;
	}

	public static async Task StartWatchingForGameStart(SynchronizationContext? context, bool createWindowDetector = true, CancellationToken cancellationToken = default)
	{
		if (_farsightSocket == null) throw new Exception("FarsightSocketClient is not initialized");
		var lease = _watchLifetime.Begin(cancellationToken);
		_watchLease = lease;
		if (!_watchLifetime.TryRun(lease, () => {
			WatchingForGameStart = true;
			_farsightSocket.ConnectionStatusChanged -= Socket_ConnectionStatusChanged;
			_farsightSocket.ConnectionStatusChanged += Socket_ConnectionStatusChanged;
		})) return;
		if (createWindowDetector)
		{
			SynchronizationContext contextToUse = context ?? SynchronizationContext.Current;
			if (contextToUse != null) contextToUse.Post(_ => CreateWindowDetector(lease), null);
			else StartMessageLoopThread(lease);
		}
		await CheckForLeagueWindow(lease.Token);
	}

	public static void StopWatchingForGameStart()
	{
		_watchLifetime.Stop(() => {
			WatchingForGameStart = false;
			try { _injectionCancelToken?.Cancel(); } catch (ObjectDisposedException) { }
			StopNativeCrashMonitor();
			StopGameProcessWatch();
			if (_windowHook.HasValue)
			{
				UnhookWinEvent(_windowHook.Value);
				if (_winEventDelegateGcHandler.IsAllocated) _winEventDelegateGcHandler.Free();
				_winEventDelegate = null; _windowHook = null;
			}
			if (_messageLoopThreadId != 0) PostThreadMessage(_messageLoopThreadId, 18u, IntPtr.Zero, IntPtr.Zero);
			if (_farsightSocket != null)
			{
				_farsightSocket.ConnectionStatusChanged -= Socket_ConnectionStatusChanged;
				if (_managedDisconnectTask.IsCompleted) _managedDisconnectTask = _farsightSocket.Disconnect();
			}
			// Release only this host's own Win32 hook/local module, never native Quit.
			_injector.Release();
		});
	}

	public static async Task<bool> StopWatchingForGameStartAsync(TimeSpan timeout)
	{
		StopWatchingForGameStart();
		Task[] pending;
		lock (_watchTaskGate) pending = _watchTasks.ToArray();
		Thread thread = _messageLoopThread;
		int callerThreadId = Environment.CurrentManagedThreadId;
		Task<bool> joined = thread == null ? Task.FromResult(true) :
			Task.Run(() => thread.ManagedThreadId != callerThreadId && thread.Join(timeout));
		Task all = Task.WhenAll(pending.Append(_managedDisconnectTask).Append(joined));
		try { await all.WaitAsync(timeout); }
		catch (OperationCanceledException) { }
		catch { return false; }
		bool complete = pending.All(task => task.IsCompleted && !task.IsFaulted) &&
			_managedDisconnectTask.IsCompletedSuccessfully && joined.IsCompletedSuccessfully && joined.Result;
		if (complete && _messageLoopThread == thread) _messageLoopThread = null;
		return complete;
	}

	private static void CreateWindowDetector(ManagedWatcherLifetime.WatchLease lease)
	{
		_watchLifetime.TryRun(lease, () => {
			if (_windowHook.HasValue) return;
			_winEventDelegate = (hook, kind, hwnd, objectId, childId, eventThread, time) =>
				WinEventProc(hook, kind, hwnd, objectId, childId, eventThread, time, lease);
			_winEventDelegateGcHandler = GCHandle.Alloc(_winEventDelegate);
			_windowHook = SetWinEventHook(WinEvents.EVENT_OBJECT_CREATE, WinEvents.EVENT_OBJECT_DESTROY,
				IntPtr.Zero, _winEventDelegate, 0u, 0u, (WinEventFlags)3u);
			if (_windowHook == IntPtr.Zero) Logger?.LogError("Failed to create window detector");
		});
	}

	[DllImport("user32.dll", EntryPoint = "PeekMessageW", ExactSpelling = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool PeekMessage(out MSG message, nint window, uint first, uint last, uint remove);

	private static void StartMessageLoopThread(ManagedWatcherLifetime.WatchLease lease)
	{
		var thread = new Thread(() => {
			// Establish the OWN worker queue before publishing its ID for WM_QUIT.
			PeekMessage(out _, IntPtr.Zero, 0x400u, 0x400u, 0u);
			uint id = GetCurrentThreadId();
			if (!_watchLifetime.TryRun(lease, () => {
				_messageLoopThreadId = id;
				CreateWindowDetector(lease);
			})) return;
			try {
				while (_watchLifetime.IsCurrent(lease))
				{
					int result = GetMessage(out MSG message, IntPtr.Zero, 0u, 0u);
					if (result <= 0) break;
					TranslateMessage(in message); DispatchMessage(in message);
				}
			}
			finally { if (_messageLoopThreadId == id) _messageLoopThreadId = 0u; }
		}) { IsBackground = true };
		thread.SetApartmentState(ApartmentState.STA);
		_watchLifetime.TryRun(lease, () => { _messageLoopThread = thread; thread.Start(); });
	}

	private static string? GetLeagueFileVersion(string? exePath)
	{
		if (exePath == null)
		{
			return null;
		}
		if (!File.Exists(exePath))
		{
			return null;
		}
		return FileVersionInfo.GetVersionInfo(exePath).FileVersion ?? "";
	}

	public static async Task ConnectToLeague(CancellationToken cancellationToken = default(CancellationToken))
	{
		Logger?.LogDebug("Connecting to League manually");
		bool previousAutoInject = AutoInject;
		AutoInject = true;
		if (!WatchingForGameStart) await StartWatchingForGameStart(null, true, cancellationToken);
		else await CheckForLeagueWindow(cancellationToken);
		AutoInject = previousAutoInject;
		Logger?.LogDebug("Manual League connection complete");
	}

	public static async Task DisconnectFromLeague()
	{
		Logger?.LogDebug("Disconnecting from League manually");
		await ShutdownLibGracefully();
		StopNativeCrashMonitor();
		if (_injectionCancelToken != null && !_injectionCancelToken.IsCancellationRequested)
		{
			_injectionCancelToken.Cancel();
		}
		_farsightSocket?.Disconnect();
		_injector.Release();
	}

	private static async Task ShutdownLibGracefully(TimeSpan? timeout = null)
	{
		timeout.GetValueOrDefault();
		if (!timeout.HasValue)
		{
			TimeSpan value = TimeSpan.FromSeconds(3L);
			timeout = value;
		}
		if (_farsightSocket == null || !_farsightSocket.IsConnected)
		{
			return;
		}
		TaskCompletionSource closed = new TaskCompletionSource(TaskCreationOptions.RunContinuationsAsynchronously);
		_farsightSocket.ConnectionStatusChanged += OnStatusChanged;
		try
		{
			EphemeralAction value2 = new EphemeralAction
			{
				RequestId = EphemeralType.Quit
			};
			Request request = new Request
			{
				Data = new RequestKind(value2)
			};
			Logger?.LogDebug("Requesting cooperative lblib shutdown");
			await _farsightSocket.Send(request);
			await closed.Task.WaitAsync(timeout.Value);
			Logger?.LogDebug("lblib confirmed shutdown (IPC connection closed)");
		}
		catch (TimeoutException)
		{
			Logger?.LogWarning("lblib did not confirm shutdown within {Timeout}; ejecting anyway", timeout);
		}
		catch (Exception exception)
		{
			Logger?.LogWarning(exception, "Error requesting cooperative lblib shutdown; ejecting anyway");
		}
		finally
		{
			_farsightSocket.ConnectionStatusChanged -= OnStatusChanged;
		}
		try
		{
			await Task.Delay(150);
		}
		catch
		{
		}
		void OnStatusChanged(object? sender, ConnectionStatus status)
		{
			if ((status == ConnectionStatus.Disconnected || status == ConnectionStatus.Error) ? true : false)
			{
				closed.TrySetResult();
			}
		}
	}

	private static async Task InvokeGameWindowOpened(ManagedWatcherLifetime.WatchLease lease)
	{
		if (!_watchLifetime.TryClaimStartup(lease)) return;
		if (!_leagueWindow.HasValue || _leagueWindow == IntPtr.Zero)
		{
			return;
		}
		if (GetWindowThreadProcessId(_leagueWindow.Value, out var lpdwProcessId) == 0 || lpdwProcessId == 0 || !ProcessIdToSessionId(lpdwProcessId, out var sessionId))
		{
			Logger?.LogError("Failed to resolve the League process and Windows session. Win32 error: {Win32Error}", Marshal.GetLastPInvokeError());
			return;
		}
		Logger?.LogDebug("League found. Attempting to obtain process information");
		if (!_watchLifetime.TryRun(lease, () => StartGameProcessWatch(lpdwProcessId))) return;
		string processPathByPID = WndSearcher.GetProcessPathByPID(lpdwProcessId);
		if (processPathByPID == null)
		{
			Logger?.LogError("Failed to obtain process path");
			return;
		}
		string leagueFileVersion = GetLeagueFileVersion(processPathByPID);
		string text = Path.GetDirectoryName(processPathByPID) ?? "";
		if (string.IsNullOrEmpty(leagueFileVersion))
		{
			Logger?.LogError("Failed to obtain process version");
			return;
		}
		Logger?.LogInformation("Process information found. Install dir: {InstallDir} | Game version: {GameVersion}", text, leagueFileVersion);
		GameWindowOpenedEventArgs e = new GameWindowOpenedEventArgs(_leagueWindow.Value, text ?? "", leagueFileVersion ?? "");
		if (!_watchLifetime.TryRun(lease, () => GameWindowOpened?.Invoke(null, e))) return;
		var injectionCancellation = _watchLifetime.TryCreateChild(lease);
		if (injectionCancellation == null) return;
		if (!_watchLifetime.TryRun(lease, () => _injectionCancelToken = injectionCancellation))
		{ injectionCancellation.Dispose(); return; }
		if (FarsightSocketClient.IsExpectedServerAvailable((int)lpdwProcessId, (int)sessionId, Port))
		{
			Logger?.LogInformation("lblib already init");
			if (!_watchLifetime.TryRun(lease, () => Injected?.Invoke(null, EventArgs.Empty))) return;
			await _farsightSocket.Connect((int)lpdwProcessId, (int)sessionId, "127.0.0.1", Port, injectionCancellation);
		}
		else if (AutoInject)
		{
			await UpdateAndInjectLib(e, lpdwProcessId, sessionId, lease, injectionCancellation);
		}
	}

	private static void WinEventProc(nint hWinEventHook, uint eventType, nint hwnd, int idObject, int idChild, uint dwEventThread, uint dwmsEventTime, ManagedWatcherLifetime.WatchLease lease)
	{
		if (!_watchLifetime.IsCurrent(lease)) return;
		if (!IsLeagueWindow(hwnd))
		{
			return;
		}
		switch (eventType)
		{
		case 32768u:
			_watchLifetime.TryRun(lease, () => {
			_leagueWindow = hwnd;
			TrackWatchTask(Task.Run(async () =>
			{
				try
				{
					await InvokeGameWindowOpened(lease);
				}
				catch (Exception exception)
				{
					Logger?.LogError(exception, "Game window opened handling failed");
				}
			}));
			});
			break;
		case 32769u:
			_watchLifetime.TryRun(lease, () => { if (_leagueWindow == hwnd && hwnd != IntPtr.Zero)
			{
				_leagueWindow = IntPtr.Zero;
				if (_injectionCancelToken != null && !_injectionCancelToken.IsCancellationRequested)
				{
					_injectionCancelToken.Cancel();
				}
				// Validation watches one game session. Invalidate the lease before
				// cleanup so an older asynchronous startup cannot install late.
				StopWatchingForGameStart();
				GameWindowClosed?.Invoke(null, new GameWindowClosedEventArgs(hwnd));
			}
			});
			break;
		}
	}

	private static bool IsLeagueWindow(nint hwnd)
	{
		if (hwnd == IntPtr.Zero)
		{
			return false;
		}
		if (hwnd == _leagueWindow)
		{
			return true;
		}
		nint? leagueWindow = _leagueWindow;
		if (leagueWindow.HasValue && _leagueWindow != IntPtr.Zero)
		{
			return false;
		}
		GetWindowThreadProcessId(hwnd, out var lpdwProcessId);
		if (lpdwProcessId == 0)
		{
			return false;
		}
		string processPathByPID = WndSearcher.GetProcessPathByPID(lpdwProcessId);
		if (string.IsNullOrEmpty(processPathByPID))
		{
			return false;
		}
		if (!TARGET_PROCESS_NAMES.Contains(Path.GetFileName(processPathByPID), StringComparer.OrdinalIgnoreCase))
		{
			return false;
		}
		return true;
	}

	private static async Task UpdateAndInjectLib(GameWindowOpenedEventArgs e, uint gamePid, uint gameSessionId,
		ManagedWatcherLifetime.WatchLease lease, CancellationTokenSource injectionCancellation)
	{
		if (!_watchLifetime.IsCurrent(lease)) return;
		if (_farsightSocket == null)
		{
			Logger?.LogError("FarsightSocket not ready");
			InjectionFailed?.Invoke(null, new Exception("FarsightSocket not ready"));
			return;
		}
		using InjectionLock injectionLock = InjectionLock.TryAcquire(gamePid, Logger);
		if (!injectionLock.Acquired)
		{
			Logger?.LogInformation("Another host owns lblib injection for this game; connecting as client");
			Injected?.Invoke(null, EventArgs.Empty);
			await _farsightSocket.Connect((int)gamePid, (int)gameSessionId, "127.0.0.1", Port, injectionCancellation);
			return;
		}
		if (FarsightSocketClient.IsExpectedServerAvailable((int)gamePid, (int)gameSessionId, Port))
		{
			Logger?.LogInformation("lblib already injected; connecting as client");
			Injected?.Invoke(null, EventArgs.Empty);
			await _farsightSocket.Connect((int)gamePid, (int)gameSessionId, "127.0.0.1", Port, injectionCancellation);
			return;
		}
		string text;
		try
		{
			text = await UpdateGameLib("lblib.dll", new Version(e.GameVersion), injectionCancellation);
		}
		catch (GameVersionNotFoundException e2)
		{
			Logger?.LogDebug("Error updating League Lib. Game Version not yet available");
			InjectionFailed?.Invoke(null, e2);
			return;
		}
		catch (HttpRequestException e3)
		{
			Logger?.LogDebug("Error updating League Lib. Is internet connected?");
			InjectionFailed?.Invoke(null, e3);
			return;
		}
		catch (LibValidationException ex)
		{
			Logger?.LogError(ex, "Downloaded DLL failed validation");
			InjectionFailed?.Invoke(null, ex);
			return;
		}
		catch (OperationCanceledException)
		{
			Logger?.LogDebug("League Lib update cancelled");
			return;
		}
		catch (Exception ex3)
		{
			Logger?.LogError(ex3, "Error updating League Lib");
			InjectionFailed?.Invoke(null, ex3);
			return;
		}
		if (string.IsNullOrEmpty(text))
		{
			Logger?.LogError("Game Lib not found");
			InjectionFailed?.Invoke(null, new Exception("Game lib not found"));
			return;
		}
		Logger?.LogDebug("loading lblib");
		try
		{
			await _injector.Inject(text, e.WindowHandle, injectionCancellation, install => _watchLifetime.TryRun(lease, install));
		}
		catch (LibLoadException ex4)
		{
			Logger?.LogError(ex4, "Failed to load lblib");
			InjectionFailed?.Invoke(null, ex4);
			return;
		}
		catch (LibHookException ex5)
		{
			Logger?.LogError(ex5, "Failed to load lblib");
			InjectionFailed?.Invoke(null, ex5);
			return;
		}
		catch (NotSpectatorException ex6)
		{
			Logger?.LogError(ex6, "Failed to load lblib");
			InjectionFailed?.Invoke(null, ex6);
			return;
		}
		catch (FileNotFoundException ex7)
		{
			Logger?.LogError(ex7, "Failed to load lblib");
			InjectionFailed?.Invoke(null, ex7);
			return;
		}
		catch (Exception ex8)
		{
			Logger?.LogError(ex8, "Failed to load lblib");
			InjectionFailed?.Invoke(null, ex8);
			return;
		}
		Logger?.LogDebug("lblib init successfully. Waiting for connection.");
		Injected?.Invoke(null, EventArgs.Empty);
		await _farsightSocket.Connect((int)gamePid, (int)gameSessionId, "127.0.0.1", Port, injectionCancellation);
	}

	private static async Task<string> UpdateGameLib(string localName, Version gameVersion, CancellationTokenSource cts)
	{
		string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
		string dllPath = Path.Combine(baseDirectory, localName);
		DateTime value = DateTime.MinValue;
		bool flag = File.Exists(dllPath);
		if (flag)
		{
			try
			{
				DllValidator.Validate(dllPath);
			}
			catch (LibValidationException exception)
			{
				Logger?.LogWarning(exception, "Local DLL failed validation, deleting to force re-download");
				File.Delete(dllPath);
				flag = false;
			}
		}
		if (GameLibFetcher != null)
		{
			if (flag)
			{
				value = File.GetLastWriteTimeUtc(dllPath);
			}
			await GameLibFetcher.UpdateOrResetLib(gameVersion, dllPath, value, cts.Token);
		}
		else if (!flag)
		{
			return "";
		}
		return dllPath;
	}

	private static async void Socket_ConnectionStatusChanged(object? sender, ConnectionStatus e)
	{
		if (e == ConnectionStatus.Connected)
		{
			TaskCompletionSource<bool> handshake = _handshake;
			try
			{
				await IdentifyToLib();
				if (!IsCurrentHandshake(handshake))
				{
					return;
				}
				if (!(await RequestFeatures(RequestedFeatures, handshake)))
				{
					Logger?.LogWarning("Failed to verify subscription tier. Disconnecting.");
					handshake.TrySetResult(result: false);
					if (IsCurrentHandshake(handshake) && _farsightSocket != null)
					{
						await _farsightSocket.Disconnect();
					}
					return;
				}
				await DeclareCapabilities(handshake);
				if (!IsCurrentHandshake(handshake))
				{
					return;
				}
				await TryAttachNativeCrashMonitor(handshake);
				if (!IsCurrentHandshake(handshake))
				{
					return;
				}
				handshake.TrySetResult(result: true);
				GameStarted?.Invoke(null, new NativeGameStartedEventArgs());
				Logger?.LogInformation("Connected to lib and features granted. Game started.");
			}
			catch (Exception exception)
			{
				Logger?.LogError(exception, "Lib handshake failed");
				handshake.TrySetResult(result: false);
				if (IsCurrentHandshake(handshake) && _farsightSocket != null)
				{
					await _farsightSocket.Disconnect();
				}
			}
		}
		if (e == ConnectionStatus.Disconnected)
		{
			_handshake.TrySetResult(result: false);
			_handshake = new TaskCompletionSource<bool>(TaskCreationOptions.RunContinuationsAsynchronously);
			LeagueDrawingConnector.ResetSyncState();
			NativeGameEndCause nativeGameEndCause = await ClassifyDisconnectCause();
			StopGameProcessWatch();
			GameEnded?.Invoke(null, new NativeGameEndedEventArgs(nativeGameEndCause));
			_injector.Release();
			Logger?.LogInformation("Disconnected from lib. Game ended ({Cause}).", nativeGameEndCause);
		}
	}

	private static void StartGameProcessWatch(uint processId)
	{
		StopNativeCrashMonitor();
		StopGameProcessWatch();
		_gameProcessExited = false;
		_gamePid = (int)processId;
		try
		{
			Process process = (_gameProcessWatch = Process.GetProcessById((int)processId));
			try
			{
				process.EnableRaisingEvents = true;
				process.Exited += OnGameProcessExited;
			}
			catch (Exception exception)
			{
				Logger?.LogDebug(exception, "Game process exit event unavailable for PID {Pid}; falling back to polling", processId);
			}
			if (process.HasExited)
			{
				_gameProcessExited = true;
			}
		}
		catch (ArgumentException)
		{
			_gameProcessExited = true;
		}
		catch (Exception exception2)
		{
			Logger?.LogDebug(exception2, "Could not open game process {Pid} for exit watching", processId);
		}
	}

	private static void OnGameProcessExited(object? sender, EventArgs e)
	{
		_gameProcessExited = true;
	}

	private static void StopGameProcessWatch()
	{
		Process gameProcessWatch = _gameProcessWatch;
		_gameProcessWatch = null;
		_gamePid = 0;
		if (gameProcessWatch == null)
		{
			return;
		}
		try
		{
			gameProcessWatch.Exited -= OnGameProcessExited;
			gameProcessWatch.Dispose();
		}
		catch
		{
		}
	}

	private static async Task<NativeGameEndCause> ClassifyDisconnectCause()
	{
		nint? leagueWindow = _leagueWindow;
		if (!leagueWindow.HasValue || _leagueWindow == IntPtr.Zero || _gameProcessExited)
		{
			return NativeGameEndCause.ProcessExited;
		}
		int pid = _gamePid;
		if (pid == 0)
		{
			return NativeGameEndCause.Unknown;
		}
		for (int attempt = 0; attempt < 3; attempt++)
		{
			if (HasGameProcessExited(pid))
			{
				return NativeGameEndCause.ProcessExited;
			}
			await Task.Delay(250);
		}
		return HasGameProcessExited(pid) ? NativeGameEndCause.ProcessExited : NativeGameEndCause.ClientDisconnected;
	}

	private static bool HasGameProcessExited(int pid)
	{
		if (_gameProcessExited)
		{
			return true;
		}
		try
		{
			Process gameProcessWatch = _gameProcessWatch;
			if (gameProcessWatch != null)
			{
				return gameProcessWatch.HasExited;
			}
			using Process process = Process.GetProcessById(pid);
			return process.HasExited;
		}
		catch (ArgumentException)
		{
			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}

	private static void Socket_ResponseReceived(object? sender, ResponseEvent e)
	{
		switch (e.Response.Data.Kind)
		{
		case ResponseKind.ItemKind.GameStateMetaData:
		{
			GameStateMetaData gameStateMetaData = e.Response.Data.GameStateMetaData;
			Logger?.LogDebug("Game state data received");
			GameStateMetaDataReceived?.Invoke(null, gameStateMetaData);
			break;
		}
		case ResponseKind.ItemKind.GameInfo:
		{
			GameInfo gameInfo = e.Response.Data.GameInfo;
			GameInfoReceived?.Invoke(null, gameInfo);
			break;
		}
		case ResponseKind.ItemKind.SimpleResponse:
		{
			SimpleResponse simpleResponse = e.Response.Data.SimpleResponse;
			Logger?.LogDebug("Simple response received: {ResponsesKind}", simpleResponse.Kind);
			break;
		}
		case ResponseKind.ItemKind.StrokeSyncEvents:
		{
			StrokeSyncEvents strokeSyncEvents = e.Response.Data.StrokeSyncEvents;
			if (strokeSyncEvents != null)
			{
				LeagueDrawingConnector.HandleStrokeSyncEvents(strokeSyncEvents);
			}
			break;
		}
		case ResponseKind.ItemKind.MirrorState:
		{
			MirrorState mirrorState = e.Response.Data.MirrorState;
			if (mirrorState != null)
			{
				MirrorStateReceived?.Invoke(null, new MirrorStateEventArgs
				{
					GameTime = mirrorState.GameTime,
					PlaybackSpeed = mirrorState.PlaybackSpeed,
					GameState = mirrorState.GameState,
					UtcTimestamp = mirrorState.UtcTime
				});
			}
			break;
		}
		case ResponseKind.ItemKind.CameraState:
		{
			CameraState cameraState = e.Response.Data.CameraState;
			if (cameraState != null)
			{
				CameraStateReceived?.Invoke(null, new CameraStateEventArgs
				{
					PosX = (cameraState.Pos?.X ?? 0f),
					PosY = (cameraState.Pos?.Y ?? 0f),
					PosZ = (cameraState.Pos?.Z ?? 0f),
					RotYaw = cameraState.RotYaw,
					RotPitch = cameraState.RotPitch,
					RotRoll = cameraState.RotRoll,
					VelX = (cameraState.Vel?.X ?? 0f),
					VelY = (cameraState.Vel?.Y ?? 0f),
					VelZ = (cameraState.Vel?.Z ?? 0f),
					IsTeleport = cameraState.IsTeleport,
					UtcTimestamp = cameraState.UtcTime,
					Sequence = cameraState.Sequence
				});
			}
			break;
		}
		case ResponseKind.ItemKind.StrokeAnchorTargetChanged:
		{
			StrokeAnchorTargetChanged strokeAnchorTargetChanged = e.Response.Data.StrokeAnchorTargetChanged;
			if (strokeAnchorTargetChanged != null)
			{
				LeagueDrawingConnector.HandleAnchorTargetChanged(strokeAnchorTargetChanged.NetworkId);
			}
			break;
		}
		case ResponseKind.ItemKind.StrokeCameraLockChanged:
		{
			StrokeCameraLockChanged strokeCameraLockChanged = e.Response.Data.StrokeCameraLockChanged;
			if (strokeCameraLockChanged != null)
			{
				LeagueDrawingConnector.HandleCameraLockChanged(strokeCameraLockChanged.NetworkId);
			}
			break;
		}
		case ResponseKind.ItemKind.PenEraserStateChanged:
		{
			PenEraserStateChanged penEraserStateChanged = e.Response.Data.PenEraserStateChanged;
			if (penEraserStateChanged != null)
			{
				PenEraserStateChangedReceived?.Invoke(null, new PenEraserStateChangedEventArgs
				{
					Hovering = penEraserStateChanged.Hovering,
					InContact = penEraserStateChanged.InContact
				});
			}
			break;
		}
		}
	}

	public static async Task<GameInfo?> RequestGameInfo(CancellationTokenSource? cts = null)
	{
		if (_farsightSocket == null)
		{
			return null;
		}
		if (cts == null)
		{
			cts = new CancellationTokenSource();
		}
		EphemeralAction value = new EphemeralAction
		{
			RequestId = EphemeralType.Snapshot
		};
		Request r = new Request
		{
			Data = new RequestKind(value)
		};
		Logger?.LogDebug("Requesting game info");
		Response response = await _farsightSocket.SendAndWaitForResponse(r, cts);
		Logger?.LogDebug("Received game info response");
		if (response == null)
		{
			return null;
		}
		if (!response.Data.Kind.Equals(ResponseKind.ItemKind.GameInfo))
		{
			Logger?.LogWarning("Failed to get game info");
			return null;
		}
		GameInfo gameInfo = response.Data.GameInfo;
		if (gameInfo == null)
		{
			Logger?.LogWarning("Failed to get game info");
			return null;
		}
		return gameInfo;
	}

	private static async Task IdentifyToLib()
	{
		if (!string.IsNullOrEmpty(AppId) && _farsightSocket != null)
		{
			Request r = new Request
			{
				Data = new RequestKind(new IdentifyClient
				{
					AppId = AppId
				})
			};
			if (await _farsightSocket.SendAndWaitForResponse(r, null, TimeSpan.FromSeconds(3L)) == null)
			{
				Logger?.LogDebug("Lib did not acknowledge IdentifyClient (older lblib?) — continuing");
			}
		}
	}

	public static Task SetEditorHotkeyOwnership(bool owns)
	{
		_ownsEditorHotkeys = owns;
		return DeclareCapabilities();
	}

	public static Task SetKeyboardCapture(bool captures)
	{
		_capturesKeyboard = captures;
		return DeclareCapabilities();
	}

	private static async Task DeclareCapabilities()
	{
		TaskCompletionSource<bool> handshake = _handshake;
		bool flag = !IsCurrentHandshake(handshake);
		if (!flag)
		{
			flag = !(await handshake.Task);
		}
		if (!flag)
		{
			await DeclareCapabilities(handshake);
		}
	}

	private static async Task DeclareCapabilities(TaskCompletionSource<bool> handshake)
	{
		await _featureHandshakeGate.WaitAsync();
		try
		{
			FarsightSocketClient farsightSocket = _farsightSocket;
			if (farsightSocket != null && IsCurrentHandshake(handshake) && await farsightSocket.SendAndWaitForResponse(new Request
			{
				Data = new RequestKind(new SetClientCapabilities
				{
					EditorHotkeys = _ownsEditorHotkeys,
					KeyboardCapture = _capturesKeyboard
				})
			}, null, TimeSpan.FromSeconds(3L)) == null)
			{
				Logger?.LogDebug("Lib did not acknowledge SetClientCapabilities");
			}
		}
		finally
		{
			_featureHandshakeGate.Release();
		}
	}

	private static async Task<bool> RequestFeatures(FeatureSet features, TaskCompletionSource<bool> handshake)
	{
		if (features.IsEmpty)
		{
			return true;
		}
		if (_farsightSocket == null)
		{
			return false;
		}
		await _featureHandshakeGate.WaitAsync();
		try
		{
			if (!IsCurrentHandshake(handshake))
			{
				return false;
			}
			return await RequestFeaturesCore(features, handshake);
		}
		finally
		{
			_featureHandshakeGate.Release();
		}
	}

	private static async Task<bool> RequestFeaturesCore(FeatureSet features, TaskCompletionSource<bool> handshake)
	{
		FarsightSocketClient socket = _farsightSocket;
		if (socket == null)
		{
			return false;
		}
		AuthenticationStart authenticationStart = new AuthenticationStart();
		Request r = new Request
		{
			Data = authenticationStart
		};
		Logger?.LogDebug("Requesting Features {Features}", features);
		Response response = await socket.SendAndWaitForResponse(r, null, FeatureAuthenticationResponseTimeout);
		if (response == null || !IsCurrentHandshake(handshake))
		{
			Logger?.LogWarning("Failed to request lib auth");
			return false;
		}
		if (response.Data.Kind == ResponseKind.ItemKind.SimpleResponse && response.Data.SimpleResponse != null && response.Data.SimpleResponse.Kind == SimpleResponseKind.ProveSubTierSuccess)
		{
			return true;
		}
		if (response.Data.Kind != ResponseKind.ItemKind.AuthenticationChallenge)
		{
			return false;
		}
		Challenge item = response.Data.AuthenticationChallenge.Challenge;
		string arg = Convert.ToBase64String(MemoryMarshal.CreateReadOnlySpan(in item.Data(0), item.Data_Length));
		if (CodeChallengeFunc == null)
		{
			Logger?.LogWarning("No code challenge function provided");
			return false;
		}
		CodeChallengeResult codeChallengeResult = await CodeChallengeFunc(arg);
		if (!IsCurrentHandshake(handshake))
		{
			return false;
		}
		if ((object)codeChallengeResult == null || string.IsNullOrEmpty(codeChallengeResult.SignatureBase64) || codeChallengeResult.FeatureBits == null || codeChallengeResult.FeatureBits.Length == 0)
		{
			Logger?.LogWarning("Invalid code challenge result from callback");
			return false;
		}
		byte[] array = Convert.FromBase64String(codeChallengeResult.SignatureBase64);
		if (array.Length != 64)
		{
			Logger?.LogWarning("Invalid code challenge response length");
			return false;
		}
		EdDSASig item2 = default;
		ReadOnlySpan<byte> readOnlySpan = array;
		Span<byte> destination = MemoryMarshal.CreateSpan(ref item2.Data(0), item2.Data_Length);
		readOnlySpan.CopyTo(destination);
		AuthenticationVerify authenticationVerify = new AuthenticationVerify
		{
			Sig = item2,
			FeatureBits = codeChallengeResult.FeatureBits
		};
		r = new Request
		{
			Data = authenticationVerify
		};
		response = await socket.SendAndWaitForResponse(r, null, FeatureAuthenticationResponseTimeout);
		if (response == null || !IsCurrentHandshake(handshake))
		{
			Logger?.LogWarning("Failed to verify lib auth");
			return false;
		}
		if (response.Data.Kind != ResponseKind.ItemKind.SimpleResponse || response.Data.SimpleResponse == null)
		{
			Logger?.LogWarning("Failed to verify lib auth");
			return false;
		}
		if (response.Data.SimpleResponse.Kind != SimpleResponseKind.ProveSubTierSuccess)
		{
			Logger?.LogWarning("Failed to verify lib auth");
			return false;
		}
		return true;
	}

	public static async Task<SpellObjectList?> GetSpellObjects()
	{
		if (_farsightSocket == null)
		{
			return null;
		}
		EphemeralAction value = new EphemeralAction
		{
			RequestId = EphemeralType.GetSpellObjectList
		};
		Request r = new Request
		{
			Data = new RequestKind(value)
		};
		Logger?.LogDebug("Requesting spell objects");
		Response response = await _farsightSocket.SendAndWaitForResponse(r);
		if (response == null)
		{
			Logger?.LogWarning("Failed to get spell objects");
			return null;
		}
		if (response.Data.Kind != ResponseKind.ItemKind.SpellObjectList || response.Data.SpellObjectList == null)
		{
			Logger?.LogWarning("Failed to get spell objects");
			return null;
		}
		SpellObjectList spellObjectList = response.Data.SpellObjectList;
		Logger?.LogTrace("Received {Count} spell objects", spellObjectList.SpellObjects?.Count);
		return spellObjectList;
	}

	public static async Task<OffsetDump?> GetOffsetTable()
	{
		if (_farsightSocket == null)
		{
			return null;
		}
		EphemeralAction value = new EphemeralAction
		{
			RequestId = EphemeralType.GetOffsetTable
		};
		Request r = new Request
		{
			Data = new RequestKind(value)
		};
		Logger?.LogDebug("Requesting offset table");
		Response response = await _farsightSocket.SendAndWaitForResponse(r);
		if (response == null)
		{
			Logger?.LogWarning("Failed to get offset table");
			return null;
		}
		if (response.Data.Kind != ResponseKind.ItemKind.OffsetDump || response.Data.OffsetDump == null)
		{
			Logger?.LogWarning("Failed to get offset table. Response: {ResponseKind}", response.Data.Kind);
			return null;
		}
		OffsetDump offsetDump = response.Data.OffsetDump;
		Logger?.LogTrace("Received {Count} offsets", offsetDump.Entries?.Count);
		return offsetDump;
	}

	public static async Task<ObjectAddressDump?> GetObjectAddresses()
	{
		if (_farsightSocket == null)
		{
			return null;
		}
		EphemeralAction value = new EphemeralAction
		{
			RequestId = EphemeralType.GetObjectAddresses
		};
		Request r = new Request
		{
			Data = new RequestKind(value)
		};
		Logger?.LogDebug("Requesting object addresses");
		Response response = await _farsightSocket.SendAndWaitForResponse(r);
		if (response == null)
		{
			Logger?.LogWarning("Failed to get object addresses");
			return null;
		}
		if (response.Data.Kind != ResponseKind.ItemKind.ObjectAddressDump || response.Data.ObjectAddressDump == null)
		{
			Logger?.LogWarning("Failed to get object addresses. Response: {ResponseKind}", response.Data.Kind);
			return null;
		}
		ObjectAddressDump objectAddressDump = response.Data.ObjectAddressDump;
		Logger?.LogTrace("Received {Count} object addresses", objectAddressDump.Entries?.Count);
		return objectAddressDump;
	}

	public static async Task StartZenosSocketService()
	{
		if (_farsightSocket != null)
		{
			RegisterService value = new RegisterService
			{
				Type = ServiceType.ZenosLiveSnapshot,
				Params = new List<string>()
			};
			Request r = new Request
			{
				Data = new RequestKind(value)
			};
			Logger?.LogDebug("Requesting Zenos socket service start");
			Response response = await _farsightSocket.SendAndWaitForResponse(r);
			if (response == null)
			{
				Logger?.LogWarning("Failed to start Zenos tick service");
			}
			else if (response.Data.Kind != ResponseKind.ItemKind.SimpleResponse || response.Data.SimpleResponse == null)
			{
				Logger?.LogWarning("Failed to start Zenos tick service");
			}
			else if (response.Data.SimpleResponse.Kind != SimpleResponseKind.RegisterSuccess)
			{
				Logger?.LogWarning("Failed to start Zenos tick service");
			}
			else
			{
				Logger?.LogInformation("Zenos tick service started");
			}
		}
	}

	public static async Task StopZenosSocketService()
	{
		if (_farsightSocket != null)
		{
			UnregisterService value = new UnregisterService
			{
				Type = ServiceType.ZenosLiveSnapshot
			};
			Request r = new Request
			{
				Data = new RequestKind(value)
			};
			Response response = await _farsightSocket.SendAndWaitForResponse(r);
			if (response == null)
			{
				Logger?.LogWarning("Failed to stop Zenos tick service");
			}
			else if (response.Data.Kind != ResponseKind.ItemKind.SimpleResponse || response.Data.SimpleResponse == null)
			{
				Logger?.LogWarning("Failed to stop Zenos tick service");
			}
			else if (response.Data.SimpleResponse.Kind != SimpleResponseKind.UnregisterSuccess)
			{
				Logger?.LogWarning("Failed to stop Zenos tick service");
			}
			else
			{
				Logger?.LogInformation("Zenos tick service stopped");
			}
		}
	}

	public static async Task SendTestRequest()
	{
		if (_farsightSocket != null)
		{
			EphemeralAction value = new EphemeralAction
			{
				RequestId = EphemeralType.Debug
			};
			Request r = new Request
			{
				Data = new RequestKind(value)
			};
			Logger?.LogDebug("Sending debug request");
			Response response = await _farsightSocket.SendAndWaitForResponse(r);
			if (response == null)
			{
				Logger?.LogWarning("Failed to send test request");
			}
			else if (response.Data.Kind != ResponseKind.ItemKind.SimpleResponse || response.Data.SimpleResponse == null)
			{
				Logger?.LogWarning("Failed to send test request");
			}
		}
	}

	public static async Task<bool> StartLeagueBroadcastSocketService(float interval)
	{
		if (_farsightSocket == null)
		{
			return false;
		}
		RegisterService value = new RegisterService
		{
			Type = ServiceType.LeagueBroadcastLiveSnapshot,
			Params = new List<string>(1) { interval.ToString() }
		};
		Request r = new Request
		{
			Data = new RequestKind(value)
		};
		Response response = await _farsightSocket.SendAndWaitForResponse(r);
		if (response == null)
		{
			Logger?.LogWarning("Failed to start LeagueBroadcast service");
			return false;
		}
		if (response.Data.Kind != ResponseKind.ItemKind.SimpleResponse || response.Data.SimpleResponse == null)
		{
			Logger?.LogWarning("Failed to start LeagueBroadcast service. Response: {ResponseKind}", response.Data.Kind);
			return false;
		}
		SimpleResponse simpleResponse = response.Data.SimpleResponse;
		if (simpleResponse.Kind != SimpleResponseKind.RegisterSuccess && simpleResponse.Kind != SimpleResponseKind.GenericSuccess)
		{
			Logger?.LogWarning("Failed to start LeagueBroadcast service. Response: {ResponseKind}", simpleResponse.Kind);
			return false;
		}
		Logger?.LogInformation("LeagueBroadcast service started");
		return true;
	}

	public static async Task<bool> StopLeagueBroadcastSocketService()
	{
		if (_farsightSocket == null)
		{
			return false;
		}
		UnregisterService value = new UnregisterService
		{
			Type = ServiceType.LeagueBroadcastLiveSnapshot
		};
		Request r = new Request
		{
			Data = new RequestKind(value)
		};
		Response response = await _farsightSocket.SendAndWaitForResponse(r);
		if (response == null)
		{
			Logger?.LogWarning("Failed to stop LeagueBroadcast service");
			return false;
		}
		if (response.Data.Kind != ResponseKind.ItemKind.SimpleResponse || response.Data.SimpleResponse == null)
		{
			Logger?.LogWarning("Failed to stop LeagueBroadcast service. Response: {ResponseKind}", response.Data.Kind);
			return false;
		}
		SimpleResponse simpleResponse = response.Data.SimpleResponse;
		if (simpleResponse.Kind != SimpleResponseKind.UnregisterSuccess)
		{
			Logger?.LogWarning("Failed to stop LeagueBroadcast service. Response: {ResponseKind}", simpleResponse.Kind);
			return false;
		}
		Logger?.LogInformation("LeagueBroadcast service stopped");
		return true;
	}

	public static async Task StartZenosFileOutputService(string filePath, float snapshotInterval = 0f)
	{
		if (_farsightSocket == null)
		{
			return;
		}
		RegisterService value = new RegisterService
		{
			Type = ServiceType.ZenosFile,
			Params = new List<string>(2)
			{
				filePath,
				snapshotInterval.ToString()
			}
		};
		Request r = new Request
		{
			Data = new RequestKind(value)
		};
		Logger?.LogDebug("Requesting Zenos file service start");
		Response response = await _farsightSocket.SendAndWaitForResponse(r);
		if (response == null)
		{
			Logger?.LogWarning("Failed to start Zenos file service");
			return;
		}
		if (response.Data.Kind != ResponseKind.ItemKind.SimpleResponse || response.Data.SimpleResponse == null)
		{
			Logger?.LogWarning("Failed to start Zenos file service. Response: {ResponseKind}", response.Data.Kind);
			return;
		}
		SimpleResponse simpleResponse = response.Data.SimpleResponse;
		if (simpleResponse.Kind != SimpleResponseKind.GenericSuccess)
		{
			Logger?.LogWarning("Failed to start Zenos file service. Response: {ResponseKind}", simpleResponse.Kind);
		}
		else
		{
			Logger?.LogInformation("Zenos file service started");
		}
	}

	public static async Task StopZenosFileOutputService()
	{
		if (_farsightSocket == null)
		{
			return;
		}
		UnregisterService value = new UnregisterService
		{
			Type = ServiceType.ZenosFile
		};
		Request r = new Request
		{
			Data = new RequestKind(value)
		};
		Response response = await _farsightSocket.SendAndWaitForResponse(r);
		if (response == null)
		{
			Logger?.LogWarning("Failed to stop Zenos file service");
			return;
		}
		if (response.Data.Kind != ResponseKind.ItemKind.SimpleResponse || response.Data.SimpleResponse == null)
		{
			Logger?.LogWarning("Failed to stop Zenos file service. Response: {ResponseKind}", response.Data.Kind);
			return;
		}
		SimpleResponse simpleResponse = response.Data.SimpleResponse;
		if (simpleResponse.Kind != SimpleResponseKind.UnregisterSuccess)
		{
			Logger?.LogWarning("Failed to stop Zenos file service. Response: {ResponseKind}", simpleResponse.Kind);
		}
		else
		{
			Logger?.LogInformation("Zenos file service stopped");
		}
	}

	public static async Task<bool> StartMirrorSyncService()
	{
		if (_farsightSocket == null)
		{
			return false;
		}
		RegisterService value = new RegisterService
		{
			Type = ServiceType.MirrorSync,
			Params = new List<string>()
		};
		Request r = new Request
		{
			Data = new RequestKind(value)
		};
		Response response = await _farsightSocket.SendAndWaitForResponse(r);
		if (response == null)
		{
			Logger?.LogWarning("Failed to start MirrorSync service");
			return false;
		}
		if (response.Data.Kind != ResponseKind.ItemKind.SimpleResponse || response.Data.SimpleResponse == null)
		{
			Logger?.LogWarning("Failed to start MirrorSync service. Response: {ResponseKind}", response.Data.Kind);
			return false;
		}
		SimpleResponse simpleResponse = response.Data.SimpleResponse;
		if (simpleResponse.Kind != SimpleResponseKind.GenericSuccess)
		{
			Logger?.LogWarning("Failed to start MirrorSync service. Response: {ResponseKind}", simpleResponse.Kind);
			return false;
		}
		Logger?.LogInformation("MirrorSync service started");
		return true;
	}

	public static async Task<bool> StopMirrorSyncService()
	{
		if (_farsightSocket == null)
		{
			return false;
		}
		UnregisterService value = new UnregisterService
		{
			Type = ServiceType.MirrorSync
		};
		Request r = new Request
		{
			Data = new RequestKind(value)
		};
		Response response = await _farsightSocket.SendAndWaitForResponse(r);
		if (response == null)
		{
			Logger?.LogWarning("Failed to stop MirrorSync service");
			return false;
		}
		if (response.Data.Kind != ResponseKind.ItemKind.SimpleResponse || response.Data.SimpleResponse == null)
		{
			Logger?.LogWarning("Failed to stop MirrorSync service. Response: {ResponseKind}", response.Data.Kind);
			return false;
		}
		SimpleResponse simpleResponse = response.Data.SimpleResponse;
		if (simpleResponse.Kind != SimpleResponseKind.GenericSuccess)
		{
			Logger?.LogWarning("Failed to stop MirrorSync service. Response: {ResponseKind}", simpleResponse.Kind);
			return false;
		}
		Logger?.LogInformation("MirrorSync service stopped");
		return true;
	}

	public static async Task<bool> StartCameraSyncService()
	{
		if (_farsightSocket == null)
		{
			return false;
		}
		RegisterService value = new RegisterService
		{
			Type = ServiceType.CameraSync,
			Params = new List<string>()
		};
		Request r = new Request
		{
			Data = new RequestKind(value)
		};
		Response response = await _farsightSocket.SendAndWaitForResponse(r);
		if (response == null || response.Data.Kind != ResponseKind.ItemKind.SimpleResponse || response.Data.SimpleResponse == null || response.Data.SimpleResponse.Kind != SimpleResponseKind.GenericSuccess)
		{
			Logger?.LogWarning("Failed to start CameraSync service. Response: {ResponseKind}", response?.Data.Kind);
			return false;
		}
		Logger?.LogInformation("CameraSync service started");
		return true;
	}

	public static async Task<bool> StopCameraSyncService()
	{
		if (_farsightSocket == null)
		{
			return false;
		}
		UnregisterService value = new UnregisterService
		{
			Type = ServiceType.CameraSync
		};
		Request r = new Request
		{
			Data = new RequestKind(value)
		};
		Response response = await _farsightSocket.SendAndWaitForResponse(r);
		if (response == null || response.Data.Kind != ResponseKind.ItemKind.SimpleResponse || response.Data.SimpleResponse == null || response.Data.SimpleResponse.Kind != SimpleResponseKind.GenericSuccess)
		{
			Logger?.LogWarning("Failed to stop CameraSync service. Response: {ResponseKind}", response?.Data.Kind);
			return false;
		}
		Logger?.LogInformation("CameraSync service stopped");
		return true;
	}

	public static async Task SendCameraTarget(float posX, float posY, float posZ, float rotYaw, float rotPitch, float rotRoll, float velX, float velY, float velZ, bool isTeleport, uint sequence)
	{
		if (_farsightSocket != null)
		{
			SetCameraTarget value = new SetCameraTarget
			{
				Pos = new Vector3
				{
					X = posX,
					Y = posY,
					Z = posZ
				},
				RotYaw = rotYaw,
				RotPitch = rotPitch,
				RotRoll = rotRoll,
				Vel = new Vector3
				{
					X = velX,
					Y = velY,
					Z = velZ
				},
				IsTeleport = isTeleport,
				Sequence = sequence
			};
			Request request = new Request
			{
				Data = new RequestKind(value)
			};
			await _farsightSocket.Send(request);
		}
	}

	public static async Task<bool> SetCameraFollowEnabled(bool enabled)
	{
		if (_farsightSocket == null)
		{
			return false;
		}
		SetCameraFollowEnabled value = new SetCameraFollowEnabled
		{
			Enabled = enabled
		};
		Request r = new Request
		{
			Data = new RequestKind(value)
		};
		Response response = await _farsightSocket.SendAndWaitForResponse(r);
		if (response == null || response.Data.Kind != ResponseKind.ItemKind.SimpleResponse || response.Data.SimpleResponse == null || response.Data.SimpleResponse.Kind != SimpleResponseKind.GenericSuccess)
		{
			Logger?.LogWarning("Failed to set camera follow enabled={Enabled}. Response: {ResponseKind}", enabled, response?.Data.Kind);
			return false;
		}
		return true;
	}

	public static async Task<bool> SetCameraPath(IReadOnlyList<CameraPathKeyframe> keys)
	{
		if (_farsightSocket == null)
		{
			Logger?.LogWarning("SetCameraPath: no Farsight IPC socket (game not attached) — dropping {Count} keyframes", keys.Count);
			return false;
		}
		if (keys.Count > 0)
		{
			CameraPathKeyframe cameraPathKeyframe = keys[0];
			ILogger? logger = Logger;
			if (logger != null)
			{
				object[] array = new object[6] { keys.Count, cameraPathKeyframe.Time, null, null, null, null };
				array[2] = keys[keys.Count - 1].Time;
				array[3] = cameraPathKeyframe.X;
				array[4] = cameraPathKeyframe.Z;
				array[5] = cameraPathKeyframe.Zoom;
				logger.LogInformation("SetCameraPath: sending {Count} keyframes t={Start:F1}s..{End:F1}s (first: x={X:F0} z={Z:F0} zoom={Zoom:F0})", array);
			}
		}
		else
		{
			Logger?.LogInformation("SetCameraPath: sending empty path (release)");
		}
		SetCameraPath value = new SetCameraPath
		{
			Keys = keys.ToList()
		};
		Request r = new Request
		{
			Data = new RequestKind(value)
		};
		Response response = await _farsightSocket.SendAndWaitForResponse(r);
		if (response == null || response.Data.Kind != ResponseKind.ItemKind.SimpleResponse || response.Data.SimpleResponse == null || response.Data.SimpleResponse.Kind != SimpleResponseKind.GenericSuccess)
		{
			Logger?.LogWarning("Failed to set camera path ({Count} keyframes). Response: {ResponseKind}", keys.Count, response?.Data.Kind);
			return false;
		}
		Logger?.LogInformation("SetCameraPath: accepted by the lib ({Count} keyframes)", keys.Count);
		return true;
	}

	public static Task<bool> ClearCameraPath()
	{
		return SetCameraPath(Array.Empty<CameraPathKeyframe>());
	}

	public static Task<bool> SetGizmoMode(GizmoModeChange mode)
	{
		return SendGizmoState(new SetGizmoState
		{
			Mode = mode
		});
	}

	public static Task<bool> SetGizmoCoordinateSpace(GizmoSpaceChange space)
	{
		return SendGizmoState(new SetGizmoState
		{
			Space = space
		});
	}

	private static async Task<bool> SendGizmoState(SetGizmoState state)
	{
		if (_farsightSocket == null)
		{
			return false;
		}
		Response response = await _farsightSocket.SendAndWaitForResponse(new Request
		{
			Data = new RequestKind(state)
		});
		if (response == null || response.Data.Kind != ResponseKind.ItemKind.SimpleResponse || response.Data.SimpleResponse == null || response.Data.SimpleResponse.Kind != SimpleResponseKind.GenericSuccess)
		{
			Logger?.LogWarning("SetGizmoState (mode={Mode}, space={Space}) rejected. Response: {ResponseKind}", state.Mode, state.Space, response?.Data.Kind);
			return false;
		}
		return true;
	}

	public static async Task<bool> SetCinematicDemoEnabled(bool enabled)
	{
		if (_farsightSocket == null)
		{
			return false;
		}
		EphemeralAction value = new EphemeralAction
		{
			RequestId = EphemeralType.SetCinematicDemo,
			Params = new List<string>(1) { enabled ? "1" : "0" }
		};
		Request r = new Request
		{
			Data = new RequestKind(value)
		};
		Response response = await _farsightSocket.SendAndWaitForResponse(r);
		if (response == null || response.Data.Kind != ResponseKind.ItemKind.SimpleResponse || response.Data.SimpleResponse == null || response.Data.SimpleResponse.Kind != SimpleResponseKind.GenericSuccess)
		{
			Logger?.LogWarning("Failed to set cinematic demo enabled={Enabled}. Response: {ResponseKind}", enabled, response?.Data.Kind);
			return false;
		}
		return true;
	}

	public static async Task<bool> SetCameraZoomUnlocked(bool unlocked)
	{
		if (_farsightSocket == null)
		{
			return false;
		}
		EphemeralAction value = new EphemeralAction
		{
			RequestId = (unlocked ? EphemeralType.SetCameraZoomUnlocked : EphemeralType.SetCameraZoomLocked)
		};
		Response response = await _farsightSocket.SendAndWaitForResponse(new Request
		{
			Data = new RequestKind(value)
		});
		if (response == null || response.Data.Kind != ResponseKind.ItemKind.SimpleResponse || response == null || response.Data.SimpleResponse?.Kind != SimpleResponseKind.GenericSuccess)
		{
			Logger?.LogWarning("Failed to set camera zoom unlocked={Unlocked}. Response: {ResponseKind}", unlocked, response?.Data.Kind);
			return false;
		}
		return true;
	}

	public static async Task<bool> SetSpectatorGoldFloatingTextFixEnabled(bool enabled)
	{
		if (_farsightSocket == null)
		{
			return false;
		}
		EphemeralAction value = new EphemeralAction
		{
			RequestId = (enabled ? EphemeralType.EnableSpectatorGoldFloatingTextFix : EphemeralType.DisableSpectatorGoldFloatingTextFix)
		};
		Response response = await _farsightSocket.SendAndWaitForResponse(new Request
		{
			Data = new RequestKind(value)
		});
		if (response == null || response.Data.Kind != ResponseKind.ItemKind.SimpleResponse || response == null || response.Data.SimpleResponse?.Kind != SimpleResponseKind.GenericSuccess)
		{
			Logger?.LogWarning("Failed to set spectator gold floating-text fix enabled={Enabled}. Response: {ResponseKind}", enabled, response?.Data.Kind);
			return false;
		}
		return true;
	}

	public static async Task RequestGameWindowCloseOnGameEnd(bool doClose)
	{
		if (_farsightSocket != null)
		{
			EphemeralAction value = new EphemeralAction
			{
				RequestId = EphemeralType.CloseWindowOnGameEnd,
				Params = new List<string>(1) { doClose.ToString() }
			};
			Request r = new Request
			{
				Data = new RequestKind(value)
			};
			Logger?.LogDebug("Requesting game window to close on game end: {DoClose}", doClose);
			Response response = await _farsightSocket.SendAndWaitForResponse(r);
			if (response == null)
			{
				Logger?.LogWarning("Failed to request game window to close on game end");
				return;
			}
			if (response.Data.Kind != ResponseKind.ItemKind.SimpleResponse || response.Data.SimpleResponse == null)
			{
				Logger?.LogWarning("Failed to request game window to close on game end");
				return;
			}
			if (response.Data.SimpleResponse.Kind != SimpleResponseKind.GenericSuccess)
			{
				Logger?.LogWarning("Failed to request game window to close on game end");
				return;
			}
			Logger?.LogInformation("Requested game window to close on game end: {0}", doClose);
		}
	}

	public static async Task<bool> SetDirectedCameraTargetPosition(float x, float y, float z)
	{
		if (_farsightSocket == null)
		{
			return false;
		}
		if (!float.IsFinite(x) || !float.IsFinite(y) || !float.IsFinite(z))
		{
			throw new ArgumentOutOfRangeException("x", "The directed camera target must be finite.");
		}
		SetDirectedCameraTarget value = new SetDirectedCameraTarget
		{
			Position = new Vector3
			{
				X = x,
				Y = y,
				Z = z
			}
		};
		Response response = await _farsightSocket.SendAndWaitForResponse(new Request
		{
			Data = new RequestKind(value)
		});
		int result;
		if (response != null && response.Data.Kind == ResponseKind.ItemKind.SimpleResponse)
		{
			SimpleResponse simpleResponse = response.Data.SimpleResponse;
			result = ((simpleResponse != null && simpleResponse.Kind == SimpleResponseKind.GenericSuccess) ? 1 : 0);
		}
		else
		{
			result = 0;
		}
		return (byte)result != 0;
	}

	public static async Task<bool> SetAutoDirectorMainCameraState(CameraPreviewDirectorController? controller, ulong revision = 0uL)
	{
		if (_farsightSocket == null)
		{
			return false;
		}
		SetAutoDirectorMainCamera value = new SetAutoDirectorMainCamera
		{
			Enabled = (controller != null),
			Controller = controller,
			Revision = revision
		};
		Response response = await _farsightSocket.SendAndWaitForResponse(new Request
		{
			Data = new RequestKind(value)
		});
		int result;
		if (response != null && response.Data.Kind == ResponseKind.ItemKind.SimpleResponse)
		{
			SimpleResponse simpleResponse = response.Data.SimpleResponse;
			result = ((simpleResponse != null && simpleResponse.Kind == SimpleResponseKind.GenericSuccess) ? 1 : 0);
		}
		else
		{
			result = 0;
		}
		return (byte)result != 0;
	}

	public static async Task<SceneEditorHudLayout?> GetSceneEditorHudLayout()
	{
		if (_farsightSocket == null)
		{
			return null;
		}
		Response response = await _farsightSocket.SendAndWaitForResponse(new Request
		{
			Data = new RequestKind(new GetSceneEditorHudLayout())
		});
		BlueBottleIPC.LeagueBroadcast.Snapshot.SceneEditorHudLayout sceneEditorHudLayout = response?.Data.SceneEditorHudLayout;
		return (response != null && response.Data.Kind == ResponseKind.ItemKind.SceneEditorHudLayout && sceneEditorHudLayout != null && sceneEditorHudLayout.Available) ? new SceneEditorHudLayout?(new SceneEditorHudLayout(sceneEditorHudLayout.MinimapX, sceneEditorHudLayout.MinimapY, sceneEditorHudLayout.MinimapWidth, sceneEditorHudLayout.MinimapHeight)) : ((SceneEditorHudLayout?)null);
	}

	public static async Task<bool> UpdateSceneEditorViewport(bool enabled, float left, float top, float right, float bottom, bool virtualEdgeScroll, bool suppressNativeEdgeScroll, bool releaseCursor)
	{
		if (_farsightSocket == null)
		{
			return false;
		}
		if (enabled && (!float.IsFinite(left) || !float.IsFinite(top) || !float.IsFinite(right) || !float.IsFinite(bottom) || left < 0f || top < 0f || right > 1f || bottom > 1f || right - left < 0.05f || bottom - top < 0.05f))
		{
			throw new ArgumentOutOfRangeException("left", "The scene editor viewport must be a normalized rectangle.");
		}
		SetSceneEditorViewport value = new SetSceneEditorViewport
		{
			Enabled = enabled,
			Left = left,
			Top = top,
			Right = right,
			Bottom = bottom,
			VirtualEdgeScroll = virtualEdgeScroll,
			SuppressNativeEdgeScroll = suppressNativeEdgeScroll,
			ReleaseCursor = releaseCursor
		};
		Response response = await _farsightSocket.SendAndWaitForResponse(new Request
		{
			Data = new RequestKind(value)
		});
		int result;
		if (response != null && response.Data.Kind == ResponseKind.ItemKind.SimpleResponse)
		{
			SimpleResponse simpleResponse = response.Data.SimpleResponse;
			result = ((simpleResponse != null && simpleResponse.Kind == SimpleResponseKind.GenericSuccess) ? 1 : 0);
		}
		else
		{
			result = 0;
		}
		return (byte)result != 0;
	}
}
