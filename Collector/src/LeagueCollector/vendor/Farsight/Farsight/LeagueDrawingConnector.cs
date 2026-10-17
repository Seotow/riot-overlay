using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using BlueBottleIPC.LeagueBroadcast.Commands;
using BlueBottleIPC.LeagueBroadcast.Common;
using BlueBottleIPC.LeagueBroadcast.Snapshot;
using Farsight.IPC2;
using Microsoft.Extensions.Logging;

namespace Farsight;

public static class LeagueDrawingConnector
{
	private static bool _syncEnabled;

	private static bool _syncServiceRegistered;

	internal static FarsightSocketClient? FarsightSocket => LeagueConnector._farsightSocket;

	internal static ILogger? Logger { get; private set; }

	public static bool IsConnected => FarsightSocket?.IsConnected ?? false;

	public static bool IsSyncEnabled => _syncEnabled;

	public static event EventHandler<PartialStrokeProperties>? StrokePropertiesChanged;

	public static event EventHandler<StrokeSyncEventArgs>? LocalStrokeSyncEvent;

	public static event EventHandler<StrokeActionEventArgs>? StrokeActionPerformed;

	internal static void EnableLogging(ILoggerFactory loggerFactory)
	{
		Logger = loggerFactory.CreateLogger("LeagueDrawingConnector");
	}

	internal static void DisableLogging()
	{
		Logger = null;
	}

	internal static void ResetSyncState()
	{
		Logger?.LogInformation("[LDC] ResetSyncState: was registered={Registered} enabled={Enabled}", _syncServiceRegistered, _syncEnabled);
		_syncServiceRegistered = false;
		_syncEnabled = false;
	}

	internal static void HandleAnchorTargetChanged(uint networkId)
	{
		Logger?.LogDebug("[LDC] Renderer changed the anchor target to {NetworkId}", networkId);
		StrokePropertiesChanged?.Invoke(null, new PartialStrokeProperties
		{
			SelectedAnchorNetworkId = networkId
		});
	}

	internal static void HandleCameraLockChanged(uint networkId)
	{
		Logger?.LogDebug("[LDC] Renderer changed the camera lock to {NetworkId}", networkId);
		StrokePropertiesChanged?.Invoke(null, new PartialStrokeProperties
		{
			CameraLockNetworkId = networkId
		});
	}

	internal static void HandleStrokeSyncEvents(StrokeSyncEvents syncEvents)
	{
		if (!_syncEnabled || syncEvents.Events == null)
		{
			if (syncEvents.Events == null)
			{
				Logger?.LogWarning("[LDC] HandleStrokeSyncEvents: sync enabled but no events in payload");
			}
			return;
		}
		Logger?.LogDebug("[LDC] HandleStrokeSyncEvents: received {Count} sync events", syncEvents.Events.Count);
		foreach (StrokeSyncEvent @event in syncEvents.Events)
		{
			StrokeSyncEventArgs e = new StrokeSyncEventArgs
			{
				EventType = @event.EventType,
				StrokeId = (@event.StrokeId ?? string.Empty),
				Color = @event.Color,
				Width = @event.Width,
				Layer = @event.Layer,
				StartTip = @event.StartTip,
				EndTip = @event.EndTip,
				LineStyle = @event.LineStyle,
				VanishTime = @event.VanishTime,
				TimeMode = @event.TimeMode,
				PointGameTimes = @event.PointGameTimes?.ToList(),
				IsArea = @event.IsArea,
				HasOutline = @event.HasOutline,
				FillColor = @event.FillColor,
				AnchorNetworkId = @event.AnchorNetworkId,
				Points = @event.Points?.ToList(),
				Pressures = @event.Pressures?.ToList()
			};
			Logger?.LogDebug("[LDC] Received stroke sync event: {EventType} for stroke {StrokeId}", e.EventType, e.StrokeId);
			EventHandler<StrokeSyncEventArgs>? localStrokeSyncEvent = LocalStrokeSyncEvent;
			if (localStrokeSyncEvent == null || localStrokeSyncEvent.GetInvocationList().Length == 0)
			{
				Logger?.LogWarning("[LDC] NO subscribers for LocalStrokeSyncEvent — event will be lost!");
			}
			LocalStrokeSyncEvent?.Invoke(null, e);
		}
	}

	private static async Task<bool> SendDrawingCommandAsync(DrawingCommand command, string actionName)
	{
		if (FarsightSocket == null || !FarsightSocket.IsConnected)
		{
			Logger?.LogWarning("Failed to {ActionName}: Not connected.", actionName);
			return false;
		}
		DrawingStateAction value = new DrawingStateAction
		{
			Command = command
		};
		Request r = new Request
		{
			Data = new RequestKind(value)
		};
		Logger?.LogDebug("Sending {ActionName} request", actionName);
		Response response = await FarsightSocket.SendAndWaitForResponse(r);
		if (response == null)
		{
			Logger?.LogWarning("Failed to {ActionName}: No response from server.", actionName);
			return false;
		}
		if (response.Data.Kind != ResponseKind.ItemKind.SimpleResponse || response.Data.SimpleResponse == null)
		{
			Logger?.LogWarning("Failed to {ActionName}: Received invalid response type.", actionName);
			return false;
		}
		if (response.Data.SimpleResponse.Kind != SimpleResponseKind.GenericSuccess)
		{
			Logger?.LogWarning("Failed to {ActionName}: Server reported failure.", actionName);
			return false;
		}
		return true;
	}

	private static ColorRGBA ToColorRGBA(this Color color)
	{
		return new ColorRGBA
		{
			R = color.R,
			G = color.G,
			B = color.B,
			A = color.A
		};
	}

	private static ColorRGBA? ToColorRGBA(this Color? color)
	{
		if (color.HasValue)
		{
			Color valueOrDefault = color.GetValueOrDefault();
			return valueOrDefault.ToColorRGBA();
		}
		return null;
	}

	private static Color? ToColor(this ColorRGBA? rgba)
	{
		if (rgba == null)
		{
			return null;
		}
		return Color.FromArgb(rgba.A, rgba.R, rgba.G, rgba.B);
	}

	public static async Task<bool> SetDrawingActiveAsync(bool isActive)
	{
		bool flag = await SendDrawingCommandAsync(new DrawingCommand(new StrokeSetActive
		{
			Active = isActive
		}), "set drawing active");
		if (flag)
		{
			StrokePropertiesChanged?.Invoke(null, new PartialStrokeProperties
			{
				Active = isActive
			});
		}
		return flag;
	}

	public static async Task<bool> SetDrawingColorAsync(Color color)
	{
		bool flag = await SendDrawingCommandAsync(new DrawingCommand(new StrokeSetColor
		{
			Color = color.ToColorRGBA()
		}), "set drawing color");
		if (flag)
		{
			StrokePropertiesChanged?.Invoke(null, new PartialStrokeProperties
			{
				Color = color.ToColorRGBA()
			});
		}
		return flag;
	}

	public static async Task<bool> SetDrawingFillColorAsync(Color fillColor)
	{
		bool flag = await SendDrawingCommandAsync(new DrawingCommand(new StrokeSetFillColor
		{
			FillColor = fillColor.ToColorRGBA()
		}), "set drawing fill color");
		if (flag)
		{
			StrokePropertiesChanged?.Invoke(null, new PartialStrokeProperties
			{
				FillColor = fillColor.ToColorRGBA()
			});
		}
		return flag;
	}

	public static async Task<bool> SetDrawingHasOutlineAsync(bool hasOutline)
	{
		bool flag = await SendDrawingCommandAsync(new DrawingCommand(new StrokeSetHasOutline
		{
			HasOutline = hasOutline
		}), "set drawing has outline");
		if (flag)
		{
			StrokePropertiesChanged?.Invoke(null, new PartialStrokeProperties
			{
				HasOutline = hasOutline
			});
		}
		return flag;
	}

	public static async Task<bool> SetDrawingAnchorModeAsync(bool enabled)
	{
		bool flag = await SendDrawingCommandAsync(new DrawingCommand(new StrokeSetAnchorMode
		{
			Enabled = enabled
		}), "set drawing anchor mode");
		if (flag)
		{
			StrokePropertiesChanged?.Invoke(null, new PartialStrokeProperties
			{
				AnchorMode = enabled
			});
		}
		return flag;
	}

	public static Task<bool> SetDrawingWorldConstraintAsync(float centerX, float centerZ, float radius)
	{
		return SendDrawingCommandAsync(new DrawingCommand(new StrokeSetWorldConstraint
		{
			CenterX = centerX,
			CenterZ = centerZ,
			Radius = radius
		}), "set drawing world constraint");
	}

	public static async Task<bool> SetDrawingAnchorTargetAsync(uint networkId)
	{
		bool flag = await SendDrawingCommandAsync(new DrawingCommand(new StrokeSetAnchorTarget
		{
			AnchorNetworkId = networkId
		}), "set drawing anchor target");
		if (flag)
		{
			StrokePropertiesChanged?.Invoke(null, new PartialStrokeProperties
			{
				SelectedAnchorNetworkId = networkId
			});
		}
		return flag;
	}

	public static async Task<bool> SetDrawingCameraLockAsync(uint networkId)
	{
		bool flag = await SendDrawingCommandAsync(new DrawingCommand(new StrokeSetCameraLock
		{
			NetworkId = networkId
		}), "set camera lock");
		if (flag)
		{
			StrokePropertiesChanged?.Invoke(null, new PartialStrokeProperties
			{
				CameraLockNetworkId = networkId
			});
		}
		return flag;
	}

	public static async Task<bool> SetDrawingThicknessAsync(float thickness)
	{
		bool flag = await SendDrawingCommandAsync(new DrawingCommand(new StrokeSetWidth
		{
			Width = thickness
		}), "set drawing thickness");
		if (flag)
		{
			StrokePropertiesChanged?.Invoke(null, new PartialStrokeProperties
			{
				Width = thickness
			});
		}
		return flag;
	}

	public static async Task<bool> SetPenPressureAsync(bool enabled, float minScale, IReadOnlyList<float>? curveX = null, IReadOnlyList<float>? curveY = null)
	{
		StrokeSetPressureWidth strokeSetPressureWidth = new StrokeSetPressureWidth
		{
			Enabled = enabled,
			MinScale = minScale
		};
		object curveX2;
		if (curveX != null)
		{
			IReadOnlyList<float> readOnlyList = curveX;
			List<float> list = new List<float>(readOnlyList.Count);
			list.AddRange(readOnlyList);
			IList<float> list2 = list;
			curveX2 = list2;
		}
		else
		{
			curveX2 = null;
		}
		strokeSetPressureWidth.CurveX = (IList<float>?)curveX2;
		object curveY2;
		if (curveY != null)
		{
			IReadOnlyList<float> readOnlyList = curveY;
			List<float> list3 = new List<float>(readOnlyList.Count);
			list3.AddRange(readOnlyList);
			IList<float> list2 = list3;
			curveY2 = list2;
		}
		else
		{
			curveY2 = null;
		}
		strokeSetPressureWidth.CurveY = (IList<float>?)curveY2;
		return await SendDrawingCommandAsync(new DrawingCommand(strokeSetPressureWidth), "set pen pressure width");
	}

	public static async Task<bool> SetTouchPanAsync(bool enabled, bool whileDrawingOff)
	{
		return await SendDrawingCommandAsync(new DrawingCommand(new TouchPanSettings
		{
			Enabled = enabled,
			WhileDrawingOff = whileDrawingOff
		}), "set touch pan settings");
	}

	public static async Task<bool> SetPenEraserAsync(bool enabled)
	{
		return await SendDrawingCommandAsync(new DrawingCommand(new PenEraserSettings
		{
			Enabled = enabled
		}), "set pen eraser settings");
	}

	public static async Task<bool> SetPenCursorHideAsync(bool enabled)
	{
		return await SendDrawingCommandAsync(new DrawingCommand(new PenCursorSettings
		{
			Enabled = enabled
		}), "set pen cursor hide settings");
	}

	public static async Task<bool> SetAnchorClickSettingsAsync(bool clickSelect, bool doubleClickCameraLock)
	{
		return await SendDrawingCommandAsync(new DrawingCommand(new AnchorClickSettings
		{
			ClickSelectEnabled = clickSelect,
			DoubleClickCameraLockEnabled = doubleClickCameraLock
		}), "set anchor click settings");
	}

	public static async Task<bool> SetDrawingLayerAsync(StrokeLayer layer)
	{
		bool flag = await SendDrawingCommandAsync(new DrawingCommand(new StrokeSetLayer
		{
			Layer = layer
		}), "set drawing layer");
		if (flag)
		{
			StrokePropertiesChanged?.Invoke(null, new PartialStrokeProperties
			{
				Layer = layer
			});
		}
		return flag;
	}

	public static async Task<bool> SetDrawingStartTip(StrokeTipStyle startTip)
	{
		bool flag = await SendDrawingCommandAsync(new DrawingCommand(new StrokeSetTipStyle
		{
			IsStartTip = true,
			TipStyle = startTip
		}), "set drawing start tip");
		if (flag)
		{
			StrokePropertiesChanged?.Invoke(null, new PartialStrokeProperties
			{
				StartTip = startTip
			});
		}
		return flag;
	}

	public static async Task<bool> SetDrawingEndTip(StrokeTipStyle endTip)
	{
		bool flag = await SendDrawingCommandAsync(new DrawingCommand(new StrokeSetTipStyle
		{
			IsStartTip = false,
			TipStyle = endTip
		}), "set drawing end tip");
		if (flag)
		{
			StrokePropertiesChanged?.Invoke(null, new PartialStrokeProperties
			{
				EndTip = endTip
			});
		}
		return flag;
	}

	public static async Task<bool> SetDrawingLineStyleAsync(StrokeLineStyle lineStyle)
	{
		bool flag = await SendDrawingCommandAsync(new DrawingCommand(new StrokeSetLineStyle
		{
			LineStyle = lineStyle
		}), "set drawing line style");
		if (flag)
		{
			StrokePropertiesChanged?.Invoke(null, new PartialStrokeProperties
			{
				LineStyle = lineStyle
			});
		}
		return flag;
	}

	public static async Task<bool> SetDrawingVanishTimeAsync(float seconds)
	{
		bool flag = await SendDrawingCommandAsync(new DrawingCommand(new StrokeSetVanishTime
		{
			VanishTime = seconds
		}), "set drawing vanish time");
		if (flag)
		{
			StrokePropertiesChanged?.Invoke(null, new PartialStrokeProperties
			{
				VanishTime = seconds
			});
		}
		return flag;
	}

	public static async Task<bool> SetDrawingTimeModeAsync(StrokeTimeMode mode)
	{
		bool flag = await SendDrawingCommandAsync(new DrawingCommand(new StrokeSetTimeMode
		{
			TimeMode = mode
		}), "set drawing time mode");
		if (flag)
		{
			StrokePropertiesChanged?.Invoke(null, new PartialStrokeProperties
			{
				TimeMode = mode
			});
		}
		return flag;
	}

	public static async Task<bool> SetDrawingToolAsync(StrokeTool tool)
	{
		bool flag = await SendDrawingCommandAsync(new DrawingCommand(new StrokeSetTool
		{
			Tool = tool
		}), "set drawing tool");
		if (flag)
		{
			StrokePropertiesChanged?.Invoke(null, new PartialStrokeProperties
			{
				Tool = tool
			});
		}
		return flag;
	}

	public static async Task<bool> ClearAllDrawingsAsync()
	{
		bool flag = await SendDrawingCommandAsync(new DrawingCommand(new StrokeClear()), "clear all drawings");
		if (flag)
		{
			StrokeActionPerformed?.Invoke(null, new StrokeActionEventArgs(StrokeActionType.Clear));
		}
		return flag;
	}

	public static async Task<bool> UndoLastStrokeAsync()
	{
		bool flag = await SendDrawingCommandAsync(new DrawingCommand(new StrokeUndo()), "undo last stroke");
		if (flag)
		{
			StrokeActionPerformed?.Invoke(null, new StrokeActionEventArgs(StrokeActionType.Undo));
		}
		return flag;
	}

	public static async Task<bool> RedoLastStrokeAsync()
	{
		bool flag = await SendDrawingCommandAsync(new DrawingCommand(new StrokeRedo()), "redo last stroke");
		if (flag)
		{
			StrokeActionPerformed?.Invoke(null, new StrokeActionEventArgs(StrokeActionType.Redo));
		}
		return flag;
	}

	public static async Task<StrokeProperties?> GetCurrentStrokePropertiesAsync()
	{
		if (FarsightSocket == null || !FarsightSocket.IsConnected)
		{
			Logger?.LogWarning("Failed to get current stroke properties: Not connected.");
			return null;
		}
		Request r = new Request
		{
			Data = new RequestKind(new DrawingStateAction
			{
				Command = new GetStrokeProperties()
			})
		};
		Logger?.LogDebug("Sending get current stroke properties request");
		Response response = await FarsightSocket.SendAndWaitForResponse(r);
		if (response == null)
		{
			Logger?.LogWarning("Failed to get current stroke properties: No response from server.");
			return null;
		}
		if (response.Data.Kind != ResponseKind.ItemKind.StrokeProperties || response.Data.StrokeProperties == null)
		{
			Logger?.LogWarning("Failed to get current stroke properties: Received invalid response type.");
			return null;
		}
		StrokeProperties strokeProperties = response.Data.StrokeProperties;
		StrokePropertiesChanged?.Invoke(null, new PartialStrokeProperties
		{
			Active = strokeProperties.Enabled,
			Color = strokeProperties.Color,
			Width = strokeProperties.Width,
			Layer = strokeProperties.Layer,
			StartTip = strokeProperties.StartStyle,
			EndTip = strokeProperties.EndStyle,
			LineStyle = strokeProperties.LineStyle,
			VanishTime = strokeProperties.VanishTime,
			TimeMode = strokeProperties.TimeMode,
			AnchorMode = strokeProperties.AnchorMode,
			SelectedAnchorNetworkId = strokeProperties.SelectedAnchorNetworkId,
			CameraLockNetworkId = strokeProperties.CameraLockNetworkId
		});
		return strokeProperties;
	}

	public static async Task<bool> SetSyncEnabledAsync(bool enabled)
	{
		Logger?.LogInformation("[LDC] SetSyncEnabledAsync: enabled={Enabled} currentlyRegistered={Registered} currentlyEnabled={Enabled2} isConnected={Connected}", enabled, _syncServiceRegistered, _syncEnabled, FarsightSocket?.IsConnected ?? false);
		if (FarsightSocket == null || !FarsightSocket.IsConnected)
		{
			Logger?.LogWarning("[LDC] Failed to set sync enabled: Not connected to Farsight socket.");
			return false;
		}
		if (enabled && !_syncServiceRegistered)
		{
			Logger?.LogInformation("[LDC] Registering for StrokeSync streaming service...");
			Request r = new Request
			{
				Data = new RequestKind(new RegisterService
				{
					Type = ServiceType.StrokeSync,
					Params = new List<string>()
				})
			};
			Response response = await FarsightSocket.SendAndWaitForResponse(r);
			Logger?.LogInformation("[LDC] StrokeSync register response: kind={Kind}", response?.Data.SimpleResponse?.Kind);
			if ((response == null || response.Data.SimpleResponse?.Kind != SimpleResponseKind.RegisterSuccess) && (response == null || response.Data.SimpleResponse?.Kind != SimpleResponseKind.GenericSuccess))
			{
				Logger?.LogWarning("[LDC] Failed to register for StrokeSync service");
				return false;
			}
			_syncServiceRegistered = true;
			Logger?.LogInformation("[LDC] Registered for StrokeSync streaming service");
		}
		else if (!enabled && _syncServiceRegistered)
		{
			Logger?.LogInformation("[LDC] Unregistering from StrokeSync streaming service...");
			Request r2 = new Request
			{
				Data = new RequestKind(new UnregisterService
				{
					Type = ServiceType.StrokeSync
				})
			};
			await FarsightSocket.SendAndWaitForResponse(r2);
			_syncServiceRegistered = false;
			Logger?.LogInformation("[LDC] Unregistered from StrokeSync streaming service");
		}
		else if (enabled && _syncServiceRegistered)
		{
			Logger?.LogInformation("[LDC] StrokeSync service already registered, skipping registration");
		}
		Logger?.LogInformation("[LDC] Sending StrokeSyncSetEnabled command: enabled={Enabled}", enabled);
		bool flag = await SendDrawingCommandAsync(new DrawingCommand(new StrokeSyncSetEnabled
		{
			Enabled = enabled
		}), "set sync enabled");
		if (flag)
		{
			_syncEnabled = enabled;
			Logger?.LogInformation("[LDC] Stroke sync {State}", enabled ? "enabled" : "disabled");
		}
		else
		{
			Logger?.LogWarning("[LDC] StrokeSyncSetEnabled command FAILED");
		}
		return flag;
	}

	public static Task<bool> FlushStrokeSyncEventsAsync()
	{
		return SendDrawingCommandAsync(new DrawingCommand(new StrokeSyncFlush()), "flush stroke sync events");
	}

	public static async Task<bool> BeginRemoteStrokeAsync(RemoteStrokeBeginData data)
	{
		List<Vector3> initialPoints = null;
		IReadOnlyList<Vector3> initialPoints2 = data.InitialPoints;
		if (initialPoints2 != null && initialPoints2.Count > 0)
		{
			initialPoints = data.InitialPoints.ToList();
		}
		StrokeSyncBeginRemote value = new StrokeSyncBeginRemote
		{
			StrokeId = data.StrokeId,
			Color = data.Color.ToColorRGBA(),
			Width = data.Width,
			Layer = data.Layer,
			StartTip = data.StartTip,
			EndTip = data.EndTip,
			LineStyle = data.LineStyle,
			VanishTime = data.VanishTime,
			TimeMode = data.TimeMode,
			PointGameTimes = data.PointGameTimes?.ToList(),
			IsArea = data.IsArea,
			HasOutline = data.HasOutline,
			FillColor = data.FillColor.ToColorRGBA(),
			AnchorNetworkId = data.AnchorNetworkId,
			InitialPoints = initialPoints,
			Pressures = data.Pressures?.ToList()
		};
		return await SendDrawingCommandAsync(new DrawingCommand(value), "begin remote stroke " + data.StrokeId);
	}

	public static async Task<bool> AddRemoteStrokePointsAsync(string strokeId, IReadOnlyList<Vector3> points, IReadOnlyList<float>? pointGameTimes = null, IReadOnlyList<float>? pressures = null)
	{
		List<Vector3> list = new List<Vector3>(points.Count);
		list.AddRange(points);
		StrokeSyncPointsRemote strokeSyncPointsRemote = new StrokeSyncPointsRemote
		{
			Points = list,
			StrokeId = strokeId
		};
		
		
		strokeSyncPointsRemote.PointGameTimes = pointGameTimes?.ToList();
		strokeSyncPointsRemote.Pressures = pressures?.ToList();
		StrokeSyncPointsRemote value = strokeSyncPointsRemote;
		return await SendDrawingCommandAsync(new DrawingCommand(value), "add points to remote stroke " + strokeId);
	}

	public static async Task<bool> EndRemoteStrokeAsync(string strokeId, IReadOnlyList<Vector3>? finalPoints = null, IReadOnlyList<float>? pointGameTimes = null, IReadOnlyList<float>? pressures = null)
	{
		List<Vector3> finalPoints2 = null;
		if (finalPoints != null && finalPoints.Count > 0)
		{
			finalPoints2 = finalPoints.ToList();
		}
		StrokeSyncEndRemote value = new StrokeSyncEndRemote
		{
			StrokeId = strokeId,
			FinalPoints = finalPoints2,
			PointGameTimes = pointGameTimes?.ToList(),
			Pressures = pressures?.ToList()
		};
		return await SendDrawingCommandAsync(new DrawingCommand(value), "end remote stroke " + strokeId);
	}

	public static async Task<bool> CancelRemoteStrokeAsync(string strokeId)
	{
		StrokeSyncCancelRemote value = new StrokeSyncCancelRemote
		{
			StrokeId = strokeId
		};
		return await SendDrawingCommandAsync(new DrawingCommand(value), "cancel remote stroke " + strokeId);
	}

	public static async Task<bool> EraseRemoteStrokeAsync(string strokeId)
	{
		StrokeEraseRemote value = new StrokeEraseRemote
		{
			StrokeId = strokeId
		};
		return await SendDrawingCommandAsync(new DrawingCommand(value), "erase remote stroke " + strokeId);
	}

	public static async Task<bool> DrawCompleteStrokeAsync(DrawCompleteStrokeData data)
	{
		IReadOnlyList<Vector3> points = data.Points;
		List<Vector3> list = new List<Vector3>(points.Count);
		list.AddRange(points);
		StrokeDrawComplete strokeDrawComplete = new StrokeDrawComplete
		{
			Points = list,
			StrokeId = data.StrokeId,
			Color = data.Color.ToColorRGBA(),
			Width = data.Width,
			Layer = data.Layer,
			StartTip = data.StartTip,
			EndTip = data.EndTip,
			LineStyle = data.LineStyle,
			VanishTime = data.VanishTime,
			TimeMode = data.TimeMode
		};
		
		
		strokeDrawComplete.PointGameTimes = data.PointGameTimes?.ToList();
		strokeDrawComplete.IsArea = data.IsArea;
		strokeDrawComplete.HasOutline = data.HasOutline;
		strokeDrawComplete.FillColor = data.FillColor.ToColorRGBA();
		strokeDrawComplete.RevealDuration = data.RevealDuration;
		strokeDrawComplete.AnchorNetworkId = data.AnchorNetworkId;
		StrokeDrawComplete value = strokeDrawComplete;
		return await SendDrawingCommandAsync(new DrawingCommand(value), "draw complete stroke " + data.StrokeId);
	}

	public static async Task<bool> ApplyRemoteSyncEventAsync(StrokeSyncEventArgs syncEvent)
	{
		Logger?.LogDebug("[LDC] ApplyRemoteSyncEvent: type={EventType} strokeId={StrokeId}", syncEvent.EventType, syncEvent.StrokeId);
		return syncEvent.EventType switch
		{
			StrokeSyncEventType.Begin => await BeginRemoteStrokeAsync(new RemoteStrokeBeginData
			{
				StrokeId = syncEvent.StrokeId,
				Color = Color.FromArgb(syncEvent.Color?.A ?? byte.MaxValue, syncEvent.Color?.R ?? 0, syncEvent.Color?.G ?? 0, syncEvent.Color?.B ?? 0),
				Width = (syncEvent.Width ?? 10f),
				Layer = (syncEvent.Layer ?? StrokeLayer.aboveTerrain),
				StartTip = syncEvent.StartTip.GetValueOrDefault(),
				EndTip = syncEvent.EndTip.GetValueOrDefault(),
				LineStyle = syncEvent.LineStyle.GetValueOrDefault(),
				VanishTime = syncEvent.VanishTime.GetValueOrDefault(),
				TimeMode = syncEvent.TimeMode.GetValueOrDefault(),
				PointGameTimes = syncEvent.PointGameTimes,
				IsArea = syncEvent.IsArea,
				HasOutline = syncEvent.HasOutline,
				FillColor = syncEvent.FillColor.ToColor(),
				AnchorNetworkId = syncEvent.AnchorNetworkId,
				InitialPoints = syncEvent.Points,
				Pressures = syncEvent.Pressures
			}), 
			StrokeSyncEventType.Points => await AddRemoteStrokePointsAsync(syncEvent.StrokeId, syncEvent.Points ?? Array.Empty<Vector3>(), syncEvent.PointGameTimes, syncEvent.Pressures), 
			StrokeSyncEventType.End => await EndRemoteStrokeAsync(syncEvent.StrokeId, syncEvent.Points, syncEvent.PointGameTimes, syncEvent.Pressures), 
			StrokeSyncEventType.Cancel => await CancelRemoteStrokeAsync(syncEvent.StrokeId), 
			_ => false, 
		};
	}

	public static async Task<StrokeSyncState?> GetCurrentSyncStateAsync()
	{
		if (FarsightSocket == null || !FarsightSocket.IsConnected)
		{
			Logger?.LogWarning("Failed to get current sync state: Not connected.");
			return null;
		}
		Request r = new Request
		{
			Data = new RequestKind(new DrawingStateAction
			{
				Command = new StrokeSyncGetCurrent()
			})
		};
		Logger?.LogDebug("Sending get current sync state request");
		Response response = await FarsightSocket.SendAndWaitForResponse(r);
		if (response == null)
		{
			Logger?.LogWarning("Failed to get current sync state: No response from server.");
			return null;
		}
		if (response.Data.Kind != ResponseKind.ItemKind.BlueBottleIPC_LeagueBroadcast_Commands_StrokeSyncCurrent || response.Data.BlueBottleIPC_LeagueBroadcast_Commands_StrokeSyncCurrent == null)
		{
			Logger?.LogWarning("Failed to get current sync state: Received invalid response type {Kind}.", response.Data.Kind);
			return null;
		}
		StrokeSyncCurrent blueBottleIPC_LeagueBroadcast_Commands_StrokeSyncCurrent = response.Data.BlueBottleIPC_LeagueBroadcast_Commands_StrokeSyncCurrent;
		List<CompletedStrokeData> list = new List<CompletedStrokeData>();
		if (blueBottleIPC_LeagueBroadcast_Commands_StrokeSyncCurrent.CompletedStrokes != null)
		{
			foreach (CompletedStroke completedStroke in blueBottleIPC_LeagueBroadcast_Commands_StrokeSyncCurrent.CompletedStrokes)
			{
				list.Add(new CompletedStrokeData
				{
					StrokeId = (completedStroke.StrokeId ?? string.Empty),
					Color = Color.FromArgb(completedStroke.Color?.A ?? byte.MaxValue, completedStroke.Color?.R ?? 0, completedStroke.Color?.G ?? 0, completedStroke.Color?.B ?? 0),
					Width = completedStroke.Width,
					Layer = completedStroke.Layer,
					StartTip = completedStroke.StartTip,
					EndTip = completedStroke.EndTip,
					LineStyle = completedStroke.LineStyle,
					VanishTime = completedStroke.VanishTime,
					TimeMode = completedStroke.TimeMode,
					PointGameTimes = (completedStroke.PointGameTimes?.ToList() ?? new List<float>()),
					IsArea = completedStroke.IsArea,
					HasOutline = completedStroke.HasOutline,
					FillColor = completedStroke.FillColor.ToColor(),
					AnchorNetworkId = completedStroke.AnchorNetworkId,
					Points = (completedStroke.Points?.ToList() ?? new List<Vector3>()),
					Pressures = completedStroke.Pressures?.ToList()
				});
			}
		}
		List<InProgressStrokeData> list2 = new List<InProgressStrokeData>();
		if (blueBottleIPC_LeagueBroadcast_Commands_StrokeSyncCurrent.InProgressStrokes != null)
		{
			foreach (StrokeSyncBeginRemote inProgressStroke in blueBottleIPC_LeagueBroadcast_Commands_StrokeSyncCurrent.InProgressStrokes)
			{
				list2.Add(new InProgressStrokeData
				{
					StrokeId = (inProgressStroke.StrokeId ?? string.Empty),
					Color = Color.FromArgb(inProgressStroke.Color?.A ?? byte.MaxValue, inProgressStroke.Color?.R ?? 0, inProgressStroke.Color?.G ?? 0, inProgressStroke.Color?.B ?? 0),
					Width = inProgressStroke.Width,
					Layer = inProgressStroke.Layer,
					StartTip = inProgressStroke.StartTip,
					EndTip = inProgressStroke.EndTip,
					LineStyle = inProgressStroke.LineStyle,
					VanishTime = inProgressStroke.VanishTime,
					TimeMode = inProgressStroke.TimeMode,
					PointGameTimes = (inProgressStroke.PointGameTimes?.ToList() ?? new List<float>()),
					IsArea = inProgressStroke.IsArea,
					HasOutline = inProgressStroke.HasOutline,
					FillColor = inProgressStroke.FillColor.ToColor(),
					AnchorNetworkId = inProgressStroke.AnchorNetworkId,
					Points = (inProgressStroke.InitialPoints?.ToList() ?? new List<Vector3>()),
					Pressures = inProgressStroke.Pressures?.ToList()
				});
			}
		}
		Logger?.LogDebug("Received sync state: {CompletedCount} completed, {InProgressCount} in-progress", list.Count, list2.Count);
		return new StrokeSyncState
		{
			CompletedStrokes = list,
			InProgressStrokes = list2
		};
	}

	public static async Task<bool> ApplySyncStateAsync(StrokeSyncState state)
	{
		Logger?.LogInformation("[LDC] ApplySyncStateAsync: {CompletedCount} completed, {InProgressCount} in-progress", state.CompletedStrokes.Count, state.InProgressStrokes.Count);
		if (FarsightSocket == null || !FarsightSocket.IsConnected)
		{
			Logger?.LogWarning("[LDC] Failed to apply sync state: Not connected to Farsight socket.");
			return false;
		}
		List<CompletedStroke> list = new List<CompletedStroke>();
		foreach (CompletedStrokeData completedStroke2 in state.CompletedStrokes)
		{
			IReadOnlyList<Vector3> points = completedStroke2.Points;
			List<Vector3> list3 = new List<Vector3>(points.Count);
			list3.AddRange(points);
		CompletedStroke completedStroke = new CompletedStroke
			{
				Points = list3,
				StrokeId = completedStroke2.StrokeId,
				Color = completedStroke2.Color.ToColorRGBA(),
				Width = completedStroke2.Width,
				Layer = completedStroke2.Layer,
				StartTip = completedStroke2.StartTip,
				EndTip = completedStroke2.EndTip,
				LineStyle = completedStroke2.LineStyle,
				VanishTime = completedStroke2.VanishTime,
				TimeMode = completedStroke2.TimeMode
			};
			IReadOnlyList<float> pointGameTimes = completedStroke2.PointGameTimes;
			List<float> list2 = new List<float>(pointGameTimes.Count);
			list2.AddRange(pointGameTimes);
			completedStroke.PointGameTimes = list2;
			completedStroke.IsArea = completedStroke2.IsArea;
			completedStroke.HasOutline = completedStroke2.HasOutline;
			completedStroke.FillColor = completedStroke2.FillColor.ToColorRGBA();
			completedStroke.AnchorNetworkId = completedStroke2.AnchorNetworkId;
			
			
			completedStroke.Pressures = completedStroke2.Pressures?.ToList();
			list.Add(completedStroke);
		}
		List<StrokeSyncBeginRemote> list4 = new List<StrokeSyncBeginRemote>();
		foreach (InProgressStrokeData inProgressStroke in state.InProgressStrokes)
		{
			StrokeSyncBeginRemote strokeSyncBeginRemote = new StrokeSyncBeginRemote
			{
				StrokeId = inProgressStroke.StrokeId,
				Color = inProgressStroke.Color.ToColorRGBA(),
				Width = inProgressStroke.Width,
				Layer = inProgressStroke.Layer,
				StartTip = inProgressStroke.StartTip,
				EndTip = inProgressStroke.EndTip,
				LineStyle = inProgressStroke.LineStyle,
				VanishTime = inProgressStroke.VanishTime,
				TimeMode = inProgressStroke.TimeMode
			};
			IReadOnlyList<float> pointGameTimes = inProgressStroke.PointGameTimes;
			List<float> list5 = new List<float>(pointGameTimes.Count);
			list5.AddRange(pointGameTimes);
			strokeSyncBeginRemote.PointGameTimes = list5;
			strokeSyncBeginRemote.IsArea = inProgressStroke.IsArea;
			strokeSyncBeginRemote.HasOutline = inProgressStroke.HasOutline;
			strokeSyncBeginRemote.FillColor = inProgressStroke.FillColor.ToColorRGBA();
			strokeSyncBeginRemote.AnchorNetworkId = inProgressStroke.AnchorNetworkId;
			IReadOnlyList<Vector3> points = inProgressStroke.Points;
			List<Vector3> list6 = new List<Vector3>(points.Count);
			list6.AddRange(points);
			strokeSyncBeginRemote.InitialPoints = list6;
			strokeSyncBeginRemote.Pressures = inProgressStroke.Pressures?.ToList();
			list4.Add(strokeSyncBeginRemote);
		}
		StrokeSyncCurrent value = new StrokeSyncCurrent
		{
			CompletedStrokes = list,
			InProgressStrokes = list4
		};
		bool flag = await SendDrawingCommandAsync(new DrawingCommand(value), "apply sync state");
		if (flag)
		{
			Logger?.LogDebug("Applied sync state: {CompletedCount} completed, {InProgressCount} in-progress", state.CompletedStrokes.Count, state.InProgressStrokes.Count);
		}
		return flag;
	}
}
