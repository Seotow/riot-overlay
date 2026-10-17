using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using BlueBottleIPC.LeagueBroadcast.Commands;
using BlueBottleIPC.LeagueBroadcast.Common;
using BlueBottleIPC.LeagueBroadcast.Entity;
using BlueBottleIPC.LeagueBroadcast.Scene;
using BlueBottleIPC.LeagueBroadcast.Snapshot;
using Farsight.IPC2;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

namespace Farsight.Entity;

public sealed class SceneConnector : IDisposable
{
	private readonly FarsightSocketClient _socket;

	private ILogger<SceneConnector> _logger;

	private bool _disposed;

	public event EventHandler<SceneCreated>? SceneCreatedEvent;

	public event EventHandler<SceneUnloaded>? SceneUnloadedEvent;

	public event EventHandler<SceneStateChanged>? SceneStateChangedEvent;

	public event EventHandler<SceneEntitiesAdded>? EntitiesAddedEvent;

	public event EventHandler<SceneEntitiesRemoved>? EntitiesRemovedEvent;

	public event EventHandler<SceneEntityChanged>? EntityChangedEvent;

	public event EventHandler<SceneEntityTransformUpdates>? EntityTransformUpdatesEvent;

	public event EventHandler<SceneSelectionChanged>? SelectionChangedEvent;

	public event EventHandler<SceneEntityIdChanged>? EntityIdChangedEvent;

	public event EventHandler<SceneScriptError>? ScriptErrorEvent;

	public event EventHandler<SceneScriptLog>? ScriptLogEvent;

	public event EventHandler<CinematicCameraEditEvent>? CinematicCameraEditReceived;

	public event EventHandler<CinematicPropEditEvent>? CinematicPropEditReceived;

	public event EventHandler<CinematicAuthoringActionEvent>? CinematicAuthoringActionReceived;

	internal SceneConnector(FarsightSocketClient socket, ILoggerFactory? loggerFactory = null)
	{
		_socket = socket ?? throw new ArgumentNullException("socket");
		_logger = loggerFactory?.CreateLogger<SceneConnector>() ?? NullLogger<SceneConnector>.Instance;
		_socket.ResponseReceived += OnResponseReceived;
	}

	internal void EnableLogging(ILoggerFactory factory)
	{
		_logger = factory.CreateLogger<SceneConnector>();
	}

	internal void DisableLogging()
	{
		_logger = NullLogger<SceneConnector>.Instance;
	}

	public void Dispose()
	{
		if (!_disposed)
		{
			_disposed = true;
			_socket.ResponseReceived -= OnResponseReceived;
		}
	}

	public async Task<SceneCreated?> CreateSceneAsync(string name, CancellationTokenSource? cts = null)
	{
		SceneCommand command = new SceneCommand(new SceneCreate
		{
			Name = name
		});
		return (await SendSceneCommandAsync(command, cts))?.Event?.SceneCreated;
	}

	public async Task<SceneUnloaded?> UnloadSceneAsync(uint sceneId, CancellationTokenSource? cts = null)
	{
		SceneCommand command = new SceneCommand(new SceneUnload
		{
			SceneId = sceneId
		});
		return (await SendSceneCommandAsync(command, cts))?.Event?.SceneUnloaded;
	}

	public async Task<bool> SetSceneVisibilityAsync(uint sceneId, bool visible, CancellationTokenSource? cts = null)
	{
		SceneCommand command = new SceneCommand(new SceneSetVisibility
		{
			SceneId = sceneId,
			Visible = visible
		});
		return await SendSceneCommandAsync(command, cts) != null;
	}

	public async Task<bool> SetSceneEditableAsync(uint sceneId, bool editable, CancellationTokenSource? cts = null)
	{
		SceneCommand command = new SceneCommand(new SceneSetEditable
		{
			SceneId = sceneId,
			Editable = editable
		});
		return await SendSceneCommandAsync(command, cts) != null;
	}

	public async Task<bool> SetSceneZOrderAsync(uint sceneId, int zOrder, CancellationTokenSource? cts = null)
	{
		SceneCommand command = new SceneCommand(new SceneSetZOrder
		{
			SceneId = sceneId,
			ZOrder = zOrder
		});
		return await SendSceneCommandAsync(command, cts) != null;
	}

	public async Task<SceneList?> ListScenesAsync(CancellationTokenSource? cts = null)
	{
		SceneCommand command = new SceneCommand(new SceneListRequest());
		return (await SendSceneCommandAsync(command, cts))?.Event?.SceneList;
	}

	public async Task<SceneSnapshot?> GetSceneSnapshotAsync(uint sceneId, CancellationTokenSource? cts = null)
	{
		SceneCommand command = new SceneCommand(new SceneSnapshotRequest
		{
			SceneId = sceneId
		});
		return (await SendSceneCommandAsync(command, cts))?.Event?.SceneSnapshot;
	}

	public async Task<bool> SetSelectionAsync(uint sceneId, IList<ulong> selectedIds, CancellationTokenSource? cts = null)
	{
		SceneCommand command = new SceneCommand(new SceneSetSelection
		{
			SceneId = sceneId,
			SelectedIds = selectedIds
		});
		return await SendSceneCommandAsync(command, cts) != null;
	}

	public async Task<ScriptValidationResponse> ValidateScriptAsync(string name, string content, CancellationTokenSource? cts = null)
	{
		SceneCommand command = new SceneCommand(new ScriptValidate
		{
			Name = name,
			Content = content
		});
		SceneEventWrapper sceneEventWrapper = await SendSceneCommandAsync(command, cts);
		return new ScriptValidationResponse(sceneEventWrapper != null, sceneEventWrapper?.Event?.SceneScriptError);
	}

	public async Task<SceneEntitiesAdded?> CreateEntitiesAsync(uint sceneId, IList<EntityCreate> entities, CancellationTokenSource? cts = null)
	{
		EntityCreateBatch value = new EntityCreateBatch
		{
			SceneId = sceneId,
			Items = entities
		};
		SceneCommand command = new SceneCommand(value);
		SceneEntitiesAdded sceneEntitiesAdded = (await SendSceneCommandAsync(command, cts, TimeSpan.FromSeconds(5L)))?.Event?.SceneEntitiesAdded;
		if (sceneEntitiesAdded != null)
		{
			EntitiesAddedEvent?.Invoke(this, sceneEntitiesAdded);
		}
		return sceneEntitiesAdded;
	}

	public async Task<ulong> CreateEntityAsync(uint sceneId, IList<Component> components, ulong requestedId = 0uL, CancellationTokenSource? cts = null)
	{
		EntityCreate entityCreate = new EntityCreate
		{
			SceneId = sceneId,
			ClientIndex = 0u,
			RequestedId = requestedId,
			Components = components
		};
		SceneEntitiesAdded sceneEntitiesAdded = await CreateEntitiesAsync(sceneId, new EntityCreate[1] { entityCreate }, cts);
		IList<EntityAssignment> list = sceneEntitiesAdded?.Assignments;
		if (list != null && list.Count > 0)
		{
			return sceneEntitiesAdded.Assignments[0].AssignedId;
		}
		return 0uL;
	}

	public async Task<SceneEntitiesRemoved?> DestroyEntitiesAsync(uint sceneId, IList<ulong> ids, CancellationTokenSource? cts = null)
	{
		SceneCommand command = new SceneCommand(new EntityDestroy
		{
			SceneId = sceneId,
			Ids = ids
		});
		SceneEntitiesRemoved sceneEntitiesRemoved = (await SendSceneCommandAsync(command, cts))?.Event?.SceneEntitiesRemoved;
		if (sceneEntitiesRemoved != null)
		{
			EntitiesRemovedEvent?.Invoke(this, sceneEntitiesRemoved);
		}
		return sceneEntitiesRemoved;
	}

	public async Task<bool> SetComponentAsync(ulong entityId, Component component, CancellationTokenSource? cts = null)
	{
		SetComponent setComponent = new SetComponent
		{
			EntityId = entityId,
			Component = component
		};
		SetComponentBatch setComponentBatch = new SetComponentBatch();
		setComponentBatch.Items = new SetComponent[1] { setComponent };
		SetComponentBatch value = setComponentBatch;
		SceneCommand command = new SceneCommand(value);
		return await SendSceneCommandAsync(command, cts) != null;
	}

	public async Task<bool> SetComponentBatchAsync(IList<SetComponent> items, CancellationTokenSource? cts = null)
	{
		SceneCommand command = new SceneCommand(new SetComponentBatch
		{
			Items = items
		});
		return await SendSceneCommandAsync(command, cts) != null;
	}

	public async Task<bool> RemoveComponentAsync(ulong entityId, ComponentKind kind, CancellationTokenSource? cts = null)
	{
		SceneCommand command = new SceneCommand(new RemoveComponent
		{
			EntityId = entityId,
			Kind = kind
		});
		return await SendSceneCommandAsync(command, cts) != null;
	}

	public async Task<SceneEntitiesSnapshot?> GetComponentsAsync(ulong entityId, IList<ComponentKind>? kinds = null, CancellationTokenSource? cts = null)
	{
		GetComponents value = new GetComponents
		{
			EntityId = entityId,
			Kinds = (kinds ?? new List<ComponentKind>())
		};
		SceneCommand command = new SceneCommand(value);
		return (await SendSceneCommandAsync(command, cts))?.Event?.SceneEntitiesSnapshot;
	}

	public async Task<bool> SetSequenceAsync(byte[] document, CancellationTokenSource? cts = null)
	{
		SetSequence value = new SetSequence
		{
			Document = document
		};
		return IsGenericSuccess(await SendRequestAsync(new RequestKind(value), cts));
	}

	public async Task<bool> SendSequenceTransportAsync(SequenceTransportCommand command, string clip, float time = 0f, float rate = 1f, bool slaved = false, float anchor = 0f, CancellationTokenSource? cts = null)
	{
		SequenceTransport value = new SequenceTransport
		{
			Command = command,
			Clip = clip,
			Time = time,
			Rate = rate,
			Slaved = slaved,
			Anchor = anchor
		};
		return IsGenericSuccess(await SendRequestAsync(new RequestKind(value), cts));
	}

	public async Task<byte[]?> RequestSequenceStateAsync(CancellationTokenSource? cts = null)
	{
		Response response = await SendRequestAsync(new RequestKind(new SequenceStateRequest()), cts);
		if (response == null)
		{
			return null;
		}
		if (response.Data.Kind != ResponseKind.ItemKind.SequenceStateResponse)
		{
			_logger.LogWarning("SceneConnector: unexpected response kind {Kind} for SequenceStateRequest", response.Data.Kind);
			return null;
		}
		Memory<byte>? memory = response.Data.SequenceStateResponse?.State;
		return (memory.HasValue && memory.GetValueOrDefault().Length > 0) ? memory.Value.ToArray() : null;
	}

	public async Task<bool> SetCinematicCameraEditorAsync(bool enabled, bool preview, ulong generation, float playhead, bool hasSelection, uint clipIndex, uint trackIndex, uint sectionIndex, uint channelIndex, uint keyIndex, CinematicCameraEditorHandle handle, CancellationTokenSource? cts = null)
	{
		SetCinematicCameraEditor value = new SetCinematicCameraEditor
		{
			Enabled = enabled,
			Preview = preview,
			Generation = generation,
			Playhead = playhead,
			HasSelection = hasSelection,
			ClipIndex = clipIndex,
			TrackIndex = trackIndex,
			SectionIndex = sectionIndex,
			ChannelIndex = channelIndex,
			KeyIndex = keyIndex,
			Handle = handle
		};
		return IsGenericSuccess(await SendRequestAsync(new RequestKind(value), cts));
	}

	public async Task<bool> SetCinematicPropEditorAsync(bool enabled, ulong generation, float playhead, IReadOnlyList<CinematicPropPath> paths, CancellationTokenSource? cts = null)
	{
		SetCinematicPropEditor setCinematicPropEditor = new SetCinematicPropEditor
		{
			Enabled = enabled,
			Generation = generation,
			Playhead = playhead
		};
		List<CinematicPropPath> list = new List<CinematicPropPath>(paths.Count);
		list.AddRange(paths);
		setCinematicPropEditor.Paths = list;
		SetCinematicPropEditor value = setCinematicPropEditor;
		return IsGenericSuccess(await SendRequestAsync(new RequestKind(value), cts));
	}

	public async Task<bool> SetControllerCameraConfigAsync(SetControllerCameraConfig config, CancellationTokenSource? cts = null)
	{
		return IsGenericSuccess(await SendRequestAsync(new RequestKind(config), cts));
	}

	public Task<CameraPreviewStatus?> SetCameraPreviewConfigurationAsync(CameraPreviewConfiguration configuration, CancellationTokenSource? cts = null)
	{
		ArgumentNullException.ThrowIfNull(configuration, "configuration");
		SetCameraPreviewConfiguration value = new SetCameraPreviewConfiguration
		{
			Configuration = configuration
		};
		return SendCameraPreviewRequestAsync(new RequestKind(value), cts);
	}

	public Task<CameraPreviewStatus?> ClearCameraPreviewConfigurationAsync(ulong generation, CancellationTokenSource? cts = null)
	{
		ClearCameraPreviewConfiguration value = new ClearCameraPreviewConfiguration
		{
			Generation = generation
		};
		return SendCameraPreviewRequestAsync(new RequestKind(value), cts);
	}

	public Task<CameraPreviewStatus?> TakeCameraPreviewAuxAsync(ulong generation, string outputId, string cameraId, CancellationTokenSource? cts = null)
	{
		ArgumentException.ThrowIfNullOrEmpty(outputId, "outputId");
		ArgumentException.ThrowIfNullOrEmpty(cameraId, "cameraId");
		TakeCameraPreviewAux value = new TakeCameraPreviewAux
		{
			Generation = generation,
			OutputId = outputId,
			CameraId = cameraId
		};
		return SendCameraPreviewRequestAsync(new RequestKind(value), cts);
	}

	public Task<CameraPreviewStatus?> GetCameraPreviewStatusAsync(CancellationTokenSource? cts = null)
	{
		return SendCameraPreviewRequestAsync(new RequestKind(new GetCameraPreviewStatus()), cts);
	}

	public async Task<CinematicCameraPoseSnapshot?> GetCinematicCameraPoseAsync(CancellationTokenSource? cts = null)
	{
		Response response = await SendRequestAsync(new RequestKind(new GetCinematicCameraPose()), cts);
		CinematicCameraPose cinematicCameraPose = response?.Data.CinematicCameraPose;
		if (response != null && response.Data.Kind == ResponseKind.ItemKind.CinematicCameraPose && cinematicCameraPose != null && cinematicCameraPose.Available)
		{
			Vector3? position = cinematicCameraPose.Position;
			if (position.HasValue)
			{
				Vector3 valueOrDefault = position.GetValueOrDefault();
				Vector3? rotation = cinematicCameraPose.Rotation;
				if (rotation.HasValue)
				{
					Vector3 valueOrDefault2 = rotation.GetValueOrDefault();
					return new CinematicCameraPoseSnapshot(cinematicCameraPose.IsFreeCamera, valueOrDefault.X, valueOrDefault.Y, valueOrDefault.Z, valueOrDefault2.X, valueOrDefault2.Y, valueOrDefault2.Z, cinematicCameraPose.Zoom, cinematicCameraPose.Fov, cinematicCameraPose.Channels);
				}
			}
		}
		return null;
	}

	private async Task<Response?> SendRequestAsync(RequestKind kind, CancellationTokenSource? cts)
	{
		if (!_socket.IsConnected)
		{
			_logger.LogWarning("SceneConnector: not connected, cannot send command");
			return null;
		}
		_logger.LogTrace("SceneConnector: sending {Kind}", kind.Kind);
		return await _socket.SendAndWaitForResponse(new Request
		{
			Data = kind
		}, cts);
	}

	private static bool IsGenericSuccess(Response? response)
	{
		if (response != null && response.Data.Kind == ResponseKind.ItemKind.SimpleResponse)
		{
			SimpleResponse simpleResponse = response.Data.SimpleResponse;
			if (simpleResponse == null)
			{
				return false;
			}
			return simpleResponse.Kind == SimpleResponseKind.GenericSuccess;
		}
		return false;
	}

	private async Task<CameraPreviewStatus?> SendCameraPreviewRequestAsync(RequestKind kind, CancellationTokenSource? cts)
	{
		Response response = await SendRequestAsync(kind, cts);
		if (response == null)
		{
			return null;
		}
		if (response.Data.Kind != ResponseKind.ItemKind.BlueBottleIPC_LeagueBroadcast_Commands_CameraPreviewStatus)
		{
			_logger.LogWarning("SceneConnector: unexpected response kind {Kind} for camera preview request {RequestKind}", response.Data.Kind, kind.Kind);
			return null;
		}
		return response.Data.BlueBottleIPC_LeagueBroadcast_Commands_CameraPreviewStatus;
	}

	private async Task<SceneEventWrapper?> SendSceneCommandAsync(SceneCommand command, CancellationTokenSource? cts, TimeSpan? timeout = null)
	{
		if (!_socket.IsConnected)
		{
			_logger.LogWarning("SceneConnector: not connected, cannot send command");
			return null;
		}
		SceneAction value = new SceneAction
		{
			Command = command
		};
		Request r = new Request
		{
			Data = new RequestKind(value)
		};
		_logger.LogTrace("SceneConnector: sending {Kind}", command.Kind);
		Response response = await _socket.SendAndWaitForResponse(r, cts, timeout);
		if (response == null)
		{
			_logger.LogWarning("SceneConnector: null response for {Kind}", command.Kind);
			return null;
		}
		if (response.Data.Kind == ResponseKind.ItemKind.SimpleResponse)
		{
			SimpleResponse simpleResponse = response.Data.SimpleResponse;
			if (simpleResponse != null && simpleResponse.Kind == SimpleResponseKind.GenericSuccess)
			{
				return new SceneEventWrapper();
			}
			_logger.LogWarning("SceneConnector: {Cmd} failed (GenericError)", command.Kind);
			return null;
		}
		if (response.Data.Kind != ResponseKind.ItemKind.BlueBottleIPC_LeagueBroadcast_Scene_SceneEventWrapper)
		{
			_logger.LogWarning("SceneConnector: unexpected response kind {Kind} for command {Cmd}", response.Data.Kind, command.Kind);
			return null;
		}
		return response.Data.BlueBottleIPC_LeagueBroadcast_Scene_SceneEventWrapper;
	}

	private void OnResponseReceived(object? sender, ResponseEvent e)
	{
		if (e.Response.RequestId != 0L)
		{
			return;
		}
		if (e.Response.Data.Kind == ResponseKind.ItemKind.CinematicCameraEditEvent)
		{
			CinematicCameraEditEvent cinematicCameraEditEvent = e.Response.Data.CinematicCameraEditEvent;
			if (cinematicCameraEditEvent != null)
			{
				CinematicCameraEditReceived?.Invoke(this, cinematicCameraEditEvent);
			}
		}
		else if (e.Response.Data.Kind == ResponseKind.ItemKind.CinematicPropEditEvent)
		{
			CinematicPropEditEvent cinematicPropEditEvent = e.Response.Data.CinematicPropEditEvent;
			if (cinematicPropEditEvent != null)
			{
				CinematicPropEditReceived?.Invoke(this, cinematicPropEditEvent);
			}
		}
		else if (e.Response.Data.Kind == ResponseKind.ItemKind.CinematicAuthoringActionEvent)
		{
			CinematicAuthoringActionEvent cinematicAuthoringActionEvent = e.Response.Data.CinematicAuthoringActionEvent;
			if (cinematicAuthoringActionEvent != null)
			{
				CinematicAuthoringActionReceived?.Invoke(this, cinematicAuthoringActionEvent);
			}
		}
		else if (e.Response.Data.Kind == ResponseKind.ItemKind.BlueBottleIPC_LeagueBroadcast_Scene_SceneEventWrapper)
		{
			SceneEventWrapper blueBottleIPC_LeagueBroadcast_Scene_SceneEventWrapper = e.Response.Data.BlueBottleIPC_LeagueBroadcast_Scene_SceneEventWrapper;
			if ((blueBottleIPC_LeagueBroadcast_Scene_SceneEventWrapper?.Event).HasValue)
			{
				DispatchSceneEvent(blueBottleIPC_LeagueBroadcast_Scene_SceneEventWrapper.Event.Value);
			}
		}
	}

	private void DispatchSceneEvent(SceneEvent evt)
	{
		switch (evt.Kind)
		{
		case SceneEvent.ItemKind.SceneCreated:
			SceneCreatedEvent?.Invoke(this, evt.SceneCreated);
			break;
		case SceneEvent.ItemKind.SceneUnloaded:
			SceneUnloadedEvent?.Invoke(this, evt.SceneUnloaded);
			break;
		case SceneEvent.ItemKind.SceneStateChanged:
			SceneStateChangedEvent?.Invoke(this, evt.SceneStateChanged);
			break;
		case SceneEvent.ItemKind.SceneEntitiesAdded:
			EntitiesAddedEvent?.Invoke(this, evt.SceneEntitiesAdded);
			break;
		case SceneEvent.ItemKind.SceneEntitiesRemoved:
			EntitiesRemovedEvent?.Invoke(this, evt.SceneEntitiesRemoved);
			break;
		case SceneEvent.ItemKind.SceneEntityChanged:
			EntityChangedEvent?.Invoke(this, evt.SceneEntityChanged);
			break;
		case SceneEvent.ItemKind.SceneEntityTransformUpdates:
			EntityTransformUpdatesEvent?.Invoke(this, evt.SceneEntityTransformUpdates);
			break;
		case SceneEvent.ItemKind.SceneSelectionChanged:
			SelectionChangedEvent?.Invoke(this, evt.SceneSelectionChanged);
			break;
		case SceneEvent.ItemKind.SceneEntityIdChanged:
			EntityIdChangedEvent?.Invoke(this, evt.SceneEntityIdChanged);
			break;
		case SceneEvent.ItemKind.SceneScriptError:
			ScriptErrorEvent?.Invoke(this, evt.SceneScriptError);
			break;
		case SceneEvent.ItemKind.SceneScriptLog:
			ScriptLogEvent?.Invoke(this, evt.SceneScriptLog);
			break;
		default:
			_logger.LogDebug("SceneConnector: unhandled unsolicited event kind {Kind}", evt.Kind);
			break;
		}
	}
}
