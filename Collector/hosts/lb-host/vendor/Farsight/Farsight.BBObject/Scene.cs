using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BlueBottleIPC.LeagueBroadcast.Commands;
using BlueBottleIPC.LeagueBroadcast.Common;
using BlueBottleIPC.LeagueBroadcast.Entity;
using BlueBottleIPC.LeagueBroadcast.Scene;
using Farsight.Entity;
using FlatSharp;
using Microsoft.Extensions.Logging;

namespace Farsight.BBObject;

public class Scene : INotifyPropertyChanged, IDisposable
{
	private readonly string _baseDir;

	private readonly SceneAssetManager _assetManager;

	private readonly ILogger<Scene> _logger;

	private readonly IPlayerDataProvider _playerDataProvider;

	private readonly SceneConnector? _connector;

	private SceneState? _state;

	private uint _nativeSceneId;

	private string _name;

	private bool _isEditMode;

	private bool _isActive;

	private bool _disposed;

	private byte[]? _loadedFileHash;

	private readonly SemaphoreSlim _saveLock = new SemaphoreSlim(1, 1);

	private readonly Task<bool>? _loadingTask;

	private List<EntityRecord> _entities = new List<EntityRecord>();

	private ulong _nextLocalId = 1uL;

	public bool IsLoading
	{
		get
		{
			if (_loadingTask != null)
			{
				return !_loadingTask.IsCompleted;
			}
			return false;
		}
	}

	public Task<bool> LoadingTask => _loadingTask ?? Task.FromResult(result: true);

	public bool IsEditMode
	{
		get
		{
			return _isEditMode;
		}
		set
		{
			if (_isEditMode != value)
			{
				_isEditMode = value;
				OnPropertyChanged("IsEditMode");
				if (_nativeSceneId != 0 && _connector != null)
				{
					_connector.SetSceneEditableAsync(_nativeSceneId, value);
				}
			}
		}
	}

	public bool IsActive
	{
		get
		{
			return _isActive;
		}
		set
		{
			if (_isActive == value)
			{
				return;
			}
			_isActive = value;
			OnPropertyChanged("IsActive");
			if (_connector != null && LeagueConnector.IsConnected())
			{
				if (value)
				{
					ApplyToGameAsync();
				}
				else
				{
					RemoveFromGameAsync();
				}
			}
		}
	}

	public string Name
	{
		get
		{
			return _name;
		}
		set
		{
			if (_name != value)
			{
				_name = value;
				OnPropertyChanged("Name");
			}
		}
	}

	public uint NativeSceneId => _nativeSceneId;

	public SceneState? State => _state;

	public int EntityCount => _state?.EntityCount ?? _entities.Count;

	public string SceneDirectory => Path.Combine(_baseDir, _name);

	public string ScriptsDirectory => SceneLibraryPaths.ResolveRelativePath(SceneDirectory, "scripts");

	public string DecalTextureDir => _assetManager.CentralDecalDirectory;

	public string FontDirectory => _assetManager.CentralFontDirectory;

	public string ModelDirectory => _assetManager.CentralModelDirectory;

	public IReadOnlyList<ScriptAsset> ScriptLibrary => _assetManager.ScriptLibrary;

	public event PropertyChangedEventHandler? PropertyChanged;

	public event EventHandler<EntityChangedEventArgs>? EntityChanged;

	public event EventHandler<SelectionChangedEventArgs>? SelectionChanged;

	public event EventHandler<ulong>? ExternalEntityReady;

	public string GetScriptFilePath(string scriptId)
	{
		return _assetManager.GetScriptFilePath(scriptId);
	}

	public Scene(string name, string baseDir, SceneAssetManager assetManager, IPlayerDataProvider playerDataProvider, ILogger<Scene> logger)
	{
		_name = name;
		_baseDir = baseDir;
		_assetManager = assetManager;
		_playerDataProvider = playerDataProvider;
		_logger = logger;
		_connector = LeagueConnector.SceneConnector;
		if (_connector != null)
		{
			_connector.EntitiesAddedEvent += OnExternalEntitiesAdded;
			_connector.EntityChangedEvent += OnExternalEntityChanged;
			_connector.EntityTransformUpdatesEvent += OnExternalTransformUpdates;
		}
		EnsureSceneDirectoryExists();
		_loadingTask = LoadAsync();
	}

	internal void ResetNativeState()
	{
		if (_nativeSceneId != 0)
		{
			_logger.LogDebug("Resetting native state for scene '{Name}' (was ID {Id}).", _name, _nativeSceneId);
		}
		if (_state != null)
		{
			SyncStateToEntities();
		}
		_nativeSceneId = 0u;
		_state = null;
	}

	public async Task<bool> ApplyToGameAsync()
	{
		if (_loadingTask != null)
		{
			await _loadingTask;
		}
		if (_connector == null || !LeagueConnector.IsConnected())
		{
			_logger.LogWarning("Cannot apply scene '{Name}': not connected.", _name);
			return false;
		}
		if (_nativeSceneId != 0)
		{
			_logger.LogWarning("Scene '{Name}' has stale native ID {Id}, resetting before re-apply.", _name, _nativeSceneId);
			ResetNativeState();
		}
		SceneCreated sceneCreated = await _connector.CreateSceneAsync(_name);
		if (sceneCreated?.Scene == null)
		{
			_logger.LogError("Failed to create native scene '{Name}'.", _name);
			return false;
		}
		_nativeSceneId = sceneCreated.Scene.SceneId;
		_state = new SceneState(_nativeSceneId, _name);
		_logger.LogInformation("Native scene '{Name}' created with ID {Id}.", _name, _nativeSceneId);
		await PreloadAssetsAsync();
		if (_entities.Count > 0)
		{
			List<EntityCreate> creates = new List<EntityCreate>(_entities.Count);
			for (int i = 0; i < _entities.Count; i++)
			{
				EntityRecord entityRecord = _entities[i];
				try
				{
					creates.Add(new EntityCreate
					{
						SceneId = _nativeSceneId,
						ClientIndex = (uint)i,
						RequestedId = entityRecord.Id,
						Components = ResolveComponentsForIpc(entityRecord.Components)
					});
				}
				catch (Exception exception)
				{
					_logger.LogError(exception, "Failed to build EntityCreate for entity {Id} '{Name}' (index {Idx}). Components: {Kinds}", entityRecord.Id, entityRecord.Name, i, string.Join(", ", (entityRecord.Components ?? new List<BlueBottleIPC.LeagueBroadcast.Entity.Component>()).Select((BlueBottleIPC.LeagueBroadcast.Entity.Component c) => c.Kind.ToString())));
				}
			}
			if (creates.Count == 0)
			{
				_logger.LogWarning("All entities failed to serialize for scene '{Name}'.", _name);
				_isActive = true;
				OnPropertyChanged("IsActive");
				return true;
			}
			try
			{
				SceneEntitiesAdded batch = await _connector.CreateEntitiesAsync(_nativeSceneId, creates);
				if (batch?.Assignments != null)
				{
					foreach (EntityAssignment assignment in batch.Assignments)
					{
						int clientIndex = (int)assignment.ClientIndex;
						if (clientIndex < _entities.Count)
						{
							_entities[clientIndex].Id = assignment.AssignedId;
							_state.AddEntity(assignment.AssignedId, _entities[clientIndex].Components);
						}
					}
					List<SetComponent> list = RemapParentIds(_entities, batch.Assignments);
					if (list.Count > 0)
					{
						await _connector.SetComponentBatchAsync(list);
					}
					_logger.LogInformation("Applied {Count} entities to scene '{Name}'.", batch.Assignments.Count, _name);
				}
				else
				{
					_logger.LogWarning("CreateEntitiesAsync returned null/no assignments for scene '{Name}' ({Count} entities sent).", _name, creates.Count);
				}
			}
			catch (Exception exception2)
			{
				_logger.LogError(exception2, "CreateEntitiesAsync failed for scene '{Name}' with {Count} entities.", _name, creates.Count);
			}
		}
		_isActive = true;
		OnPropertyChanged("IsActive");
		if (_isEditMode)
		{
			await _connector.SetSceneEditableAsync(_nativeSceneId, editable: true);
		}
		return true;
	}

	public static List<SetComponent> RemapParentIds(IEnumerable<EntityRecord> entities, IEnumerable<EntityAssignment> assignments)
	{
		Dictionary<ulong, ulong> dictionary = new Dictionary<ulong, ulong>();
		foreach (EntityAssignment assignment in assignments)
		{
			if (assignment.RequestedId != 0L && assignment.RequestedId != assignment.AssignedId)
			{
				dictionary[assignment.RequestedId] = assignment.AssignedId;
			}
		}
		List<SetComponent> list = new List<SetComponent>();
		if (dictionary.Count == 0)
		{
			return list;
		}
		foreach (EntityRecord entity in entities)
		{
			foreach (BlueBottleIPC.LeagueBroadcast.Entity.Component item in entity.Components ?? new List<BlueBottleIPC.LeagueBroadcast.Entity.Component>())
			{
				if (item.Kind == BlueBottleIPC.LeagueBroadcast.Entity.Component.ItemKind.Transform)
				{
					ComponentTransform transform = item.Transform;
					if (transform != null && dictionary.TryGetValue(transform.ParentId, out var value))
					{
						transform.ParentId = value;
						list.Add(new SetComponent
						{
							EntityId = entity.Id,
							Component = item
						});
					}
				}
			}
		}
		return list;
	}

	public async Task<bool> AdoptExistingAsync(uint nativeSceneId)
	{
		if (_connector == null || !LeagueConnector.IsConnected())
		{
			_logger.LogWarning("Cannot adopt scene '{Name}': not connected.", _name);
			return false;
		}
		if (_loadingTask != null)
		{
			await _loadingTask;
		}
		_nativeSceneId = nativeSceneId;
		_state = new SceneState(nativeSceneId, _name);
		_logger.LogInformation("Adopting existing native scene '{Name}' with ID {Id}.", _name, nativeSceneId);
		SceneSnapshot sceneSnapshot = await _connector.GetSceneSnapshotAsync(nativeSceneId);
		if (sceneSnapshot != null)
		{
			_state.ApplySnapshot(sceneSnapshot);
			if (sceneSnapshot.Entities != null)
			{
				for (int i = 0; i < sceneSnapshot.Entities.Count && i < _entities.Count; i++)
				{
					_entities[i].Id = sceneSnapshot.Entities[i].EntityId;
				}
				_logger.LogInformation("Reconciled {Count} entity IDs from existing scene '{Name}'.", sceneSnapshot.Entities.Count, _name);
			}
		}
		else
		{
			_logger.LogWarning("Failed to get snapshot for adopted scene '{Name}' (ID {Id}). State may be incomplete.", _name, nativeSceneId);
		}
		_isActive = true;
		OnPropertyChanged("IsActive");
		if (_isEditMode)
		{
			await _connector.SetSceneEditableAsync(_nativeSceneId, editable: true);
		}
		return true;
	}

	public async Task<bool> RemoveFromGameAsync()
	{
		if (_connector == null || _nativeSceneId == 0)
		{
			return false;
		}
		if (await _connector.UnloadSceneAsync(_nativeSceneId) != null)
		{
			_logger.LogInformation("Scene '{Name}' (ID {Id}) unloaded.", _name, _nativeSceneId);
		}
		_nativeSceneId = 0u;
		if (_state != null)
		{
			SyncStateToEntities();
		}
		_state = null;
		_isActive = false;
		OnPropertyChanged("IsActive");
		return true;
	}

	public async Task<ulong> AddEntityAsync(EntityRecord entity)
	{
		if (_connector != null && _nativeSceneId != 0)
		{
			IList<BlueBottleIPC.LeagueBroadcast.Entity.Component> ipcComponents = ResolveComponentsForIpc(entity.Components);
			await EnsureComponentsAssetsLoadedAsync(ipcComponents);
			_logger.LogInformation("AddEntityAsync: scene={SceneId}, requestedId={ReqId}, components=[{Kinds}]", _nativeSceneId, entity.Id, string.Join(", ", ipcComponents.Select((BlueBottleIPC.LeagueBroadcast.Entity.Component c) => c.Kind.ToString())));
			ulong id = await _connector.CreateEntityAsync(_nativeSceneId, ipcComponents, entity.Id);
			if (id == 0L)
			{
				_logger.LogWarning("Failed to create entity in native scene '{Name}' (IPC returned 0).", _name);
				return 0uL;
			}
			entity.Id = id;
			_state?.AddEntity(id, entity.Components);
			_entities.RemoveAll((EntityRecord existing) => existing.Id == id);
			_entities.Add(entity);
			return id;
		}
		if (entity.Id == 0L)
		{
			entity.Id = _nextLocalId++;
		}
		_entities.Add(entity);
		return entity.Id;
	}

	public async Task<bool> RemoveEntitiesAsync(IList<ulong> ids)
	{
		_entities.RemoveAll((EntityRecord e) => ids.Contains(e.Id));
		if (_connector == null || _nativeSceneId == 0)
		{
			foreach (EntityRecord entity2 in _entities)
			{
				ComponentTransform transform = GetTransform(entity2);
				if (transform != null && ids.Contains(transform.ParentId))
				{
					transform.ParentId = 0uL;
				}
			}
			return true;
		}
		SceneEntitiesRemoved sceneEntitiesRemoved = await _connector.DestroyEntitiesAsync(_nativeSceneId, ids);
		if (sceneEntitiesRemoved == null)
		{
			return false;
		}
		foreach (ulong item in sceneEntitiesRemoved.LocalIds ?? new List<ulong>())
		{
			_state?.RemoveEntity(item);
		}
		foreach (ulong item2 in sceneEntitiesRemoved.ReparentedIds ?? new List<ulong>())
		{
			EntityRecord entity = GetEntity(item2);
			if (entity != null)
			{
				ComponentTransform transform2 = GetTransform(entity);
				if (transform2 != null)
				{
					transform2.ParentId = 0uL;
				}
			}
			ComponentTransform componentTransform = _state?.GetEntity(item2)?.Transform;
			if (componentTransform != null)
			{
				componentTransform.ParentId = 0uL;
			}
		}
		return true;
	}

	private static ComponentTransform? GetTransform(EntityRecord entity)
	{
		foreach (BlueBottleIPC.LeagueBroadcast.Entity.Component item in entity.Components ?? new List<BlueBottleIPC.LeagueBroadcast.Entity.Component>())
		{
			if (item.Kind == BlueBottleIPC.LeagueBroadcast.Entity.Component.ItemKind.Transform)
			{
				return item.Transform;
			}
		}
		return null;
	}

	public async Task<bool> SetComponentAsync(ulong entityId, BlueBottleIPC.LeagueBroadcast.Entity.Component component)
	{
		if (_connector != null && _nativeSceneId != 0)
		{
			if (component.Kind == BlueBottleIPC.LeagueBroadcast.Entity.Component.ItemKind.Script)
			{
				ComponentScript script = component.Script;
				if (script != null)
				{
					EntityRecord entityRecord = _entities.FirstOrDefault((EntityRecord e) => e.Id == entityId);
					if (entityRecord != null)
					{
						ApplyComponentToRecord(entityRecord, component);
					}
					_state?.GetEntity(entityId)?.SetComponent(component);
					BlueBottleIPC.LeagueBroadcast.Entity.Component component2 = ResolveScriptComponent(script);
					await _connector.SetComponentAsync(entityId, component2);
					return true;
				}
			}
			await EnsureComponentAssetsLoadedAsync(component);
			bool flag = await _connector.SetComponentAsync(entityId, component);
			if (flag)
			{
				_state?.GetEntity(entityId)?.SetComponent(component);
			}
			return flag;
		}
		EntityRecord entityRecord2 = _entities.FirstOrDefault((EntityRecord e) => e.Id == entityId);
		if (entityRecord2 == null)
		{
			return false;
		}
		ApplyComponentToRecord(entityRecord2, component);
		return true;
	}

	public async Task<bool> SetComponentBatchAsync(List<SetComponent> items)
	{
		if (_connector != null && _nativeSceneId != 0)
		{
			List<SetComponent> scriptItems = items.Where((SetComponent i) =>
			{
				BlueBottleIPC.LeagueBroadcast.Entity.Component? component3 = i.Component;
				return component3.HasValue && component3.GetValueOrDefault().Kind == BlueBottleIPC.LeagueBroadcast.Entity.Component.ItemKind.Script;
			}).ToList();
			List<SetComponent> nativeItems = items.Where((SetComponent i) =>
			{
				BlueBottleIPC.LeagueBroadcast.Entity.Component? component3 = i.Component;
				return component3.HasValue && component3.GetValueOrDefault().Kind != BlueBottleIPC.LeagueBroadcast.Entity.Component.ItemKind.Script;
			}).ToList();
			foreach (SetComponent item in scriptItems)
			{
				BlueBottleIPC.LeagueBroadcast.Entity.Component? component = item.Component;
				if (component.HasValue)
				{
					BlueBottleIPC.LeagueBroadcast.Entity.Component valueOrDefault = component.GetValueOrDefault();
					EntityRecord entityRecord = _entities.FirstOrDefault((EntityRecord e) => e.Id == item.EntityId);
					if (entityRecord != null)
					{
						ApplyComponentToRecord(entityRecord, valueOrDefault);
					}
					_state?.GetEntity(item.EntityId)?.SetComponent(valueOrDefault);
					ComponentScript script = valueOrDefault.Script;
					if (script != null)
					{
						BlueBottleIPC.LeagueBroadcast.Entity.Component component2 = ResolveScriptComponent(script);
						await _connector.SetComponentAsync(item.EntityId, component2);
					}
				}
			}
			if (nativeItems.Count > 0)
			{
				List<BlueBottleIPC.LeagueBroadcast.Entity.Component> list = (from i in nativeItems
					select i.Component into c
					where c.HasValue
					select c).Cast<BlueBottleIPC.LeagueBroadcast.Entity.Component>().ToList();
				if (list.Count > 0)
				{
					await EnsureComponentsAssetsLoadedAsync(list);
				}
				if (!(await _connector.SetComponentBatchAsync(nativeItems)))
				{
					return scriptItems.Count > 0;
				}
				foreach (SetComponent item3 in nativeItems)
				{
					BlueBottleIPC.LeagueBroadcast.Entity.Component? component = item3.Component;
					if (component.HasValue)
					{
						BlueBottleIPC.LeagueBroadcast.Entity.Component valueOrDefault2 = component.GetValueOrDefault();
						_state?.GetEntity(item3.EntityId)?.SetComponent(valueOrDefault2);
					}
				}
			}
			return true;
		}
		foreach (SetComponent item2 in items)
		{
			BlueBottleIPC.LeagueBroadcast.Entity.Component? component = item2.Component;
			if (component.HasValue)
			{
				BlueBottleIPC.LeagueBroadcast.Entity.Component valueOrDefault3 = component.GetValueOrDefault();
				EntityRecord entityRecord2 = _entities.FirstOrDefault((EntityRecord e) => e.Id == item2.EntityId);
				if (entityRecord2 != null)
				{
					ApplyComponentToRecord(entityRecord2, valueOrDefault3);
				}
			}
		}
		return true;
	}

	public async Task<bool> RemoveComponentAsync(ulong entityId, ComponentKind kind)
	{
		if (_connector != null && _nativeSceneId != 0)
		{
			if (kind == ComponentKind.Script)
			{
				EntityRecord entityRecord = _entities.FirstOrDefault((EntityRecord e) => e.Id == entityId);
				if (entityRecord != null)
				{
					RemoveComponentFromRecord(entityRecord, kind);
				}
				_state?.GetEntity(entityId)?.RemoveComponent(kind);
				return true;
			}
			bool flag = await _connector.RemoveComponentAsync(entityId, kind);
			if (flag)
			{
				_state?.GetEntity(entityId)?.RemoveComponent(kind);
			}
			return flag;
		}
		EntityRecord entityRecord2 = _entities.FirstOrDefault((EntityRecord e) => e.Id == entityId);
		if (entityRecord2 == null)
		{
			return false;
		}
		RemoveComponentFromRecord(entityRecord2, kind);
		return true;
	}

	public bool RenameEntity(ulong entityId, string name)
	{
		EntityRecord entityRecord = _entities.FirstOrDefault((EntityRecord e) => e.Id == entityId);
		if (entityRecord == null)
		{
			return false;
		}
		entityRecord.Name = name;
		return true;
	}

	public async Task<IList<BlueBottleIPC.LeagueBroadcast.Entity.Component>?> GetComponentsAsync(ulong entityId, IList<ComponentKind>? kinds = null)
	{
		if (_connector != null && _nativeSceneId != 0)
		{
			IList<EntitySnapshot> list = (await _connector.GetComponentsAsync(entityId, kinds?.ToList()))?.Entities;
			if (list != null && list.Count > 0)
			{
				IList<BlueBottleIPC.LeagueBroadcast.Entity.Component> components = list[0].Components;
				if (components != null)
				{
					ReattachScriptMetadata(entityId, components);
					return components;
				}
			}
		}
		EntityRecord entityRecord = _entities.FirstOrDefault((EntityRecord e) => e.Id == entityId);
		if (entityRecord?.Components == null)
		{
			return null;
		}
		if ((kinds == null || kinds.Count == 0) ? true : false)
		{
			return entityRecord.Components;
		}
		return entityRecord.Components.Where((BlueBottleIPC.LeagueBroadcast.Entity.Component c) => kinds.Contains((ComponentKind)(c.Discriminator - 1))).ToList();
	}

	public async Task<bool> SetSelectionAsync(IList<ulong> selectedIds)
	{
		if (_connector == null || _nativeSceneId == 0)
		{
			return true;
		}
		return await _connector.SetSelectionAsync(_nativeSceneId, selectedIds);
	}

	public async Task<List<ulong>> DuplicateEntitiesAsync(IEnumerable<ulong> entityIds)
	{
		List<ulong> duplicated = new List<ulong>();
		foreach (ulong id in entityIds)
		{
			EntityRecord entityRecord = _entities.FirstOrDefault((EntityRecord e) => e.Id == id);
			if (entityRecord != null)
			{
				List<BlueBottleIPC.LeagueBroadcast.Entity.Component> list = null;
				EntityState entityState = _state?.GetEntity(id);
				if (entityState != null)
				{
					list = entityState.GetAllComponents().Select(CloneComponent).ToList();
				}
				EntityRecord entity = new EntityRecord
				{
					Id = 0uL,
					Name = ((entityRecord.Name != null) ? (entityRecord.Name + " (copy)") : null),
					Components = (list ?? entityRecord.Components?.Select(CloneComponent).ToList())
				};
				ulong num = await AddEntityAsync(entity);
				if (num != 0L)
				{
					duplicated.Add(num);
				}
			}
		}
		return duplicated;
	}

	public async Task RefreshScriptReferencesAsync(string scriptId)
	{
		if (_connector == null || _nativeSceneId == 0)
		{
			return;
		}
		List<EntityRecord> list = _entities.ToList();
		foreach (EntityRecord entity in list)
		{
			List<BlueBottleIPC.LeagueBroadcast.Entity.Component> list2 = entity.Components?.ToList();
			if (list2 == null)
			{
				continue;
			}
			BlueBottleIPC.LeagueBroadcast.Entity.Component? component = list2.Cast<BlueBottleIPC.LeagueBroadcast.Entity.Component?>().FirstOrDefault((BlueBottleIPC.LeagueBroadcast.Entity.Component? c) => c.HasValue && c.Value.Kind == BlueBottleIPC.LeagueBroadcast.Entity.Component.ItemKind.Script);
			if (!component.HasValue || !component.HasValue)
			{
				continue;
			}
			ComponentScript script = component.GetValueOrDefault().Script;
			if (script == null)
			{
				continue;
			}
			IList<ScriptEntry>? scripts = script.Scripts;
			if (scripts != null && scripts.Any((ScriptEntry s) => s.ScriptId == scriptId))
			{
				BlueBottleIPC.LeagueBroadcast.Entity.Component resolved = ResolveScriptComponent(script);
				if (await _connector.SetComponentAsync(entity.Id, resolved).ConfigureAwait(continueOnCapturedContext: false))
				{
					_state?.GetEntity(entity.Id)?.SetComponent(resolved);
					continue;
				}
				_logger.LogWarning("Could not refresh shared script '{ScriptId}' on entity {EntityId} in scene '{Name}'.", scriptId, entity.Id, _name);
			}
		}
	}

	public async Task RemoveScriptReferencesAsync(string scriptId)
	{
		foreach (EntityRecord entity in _entities)
		{
			BlueBottleIPC.LeagueBroadcast.Entity.Component? component = entity.Components?.Cast<BlueBottleIPC.LeagueBroadcast.Entity.Component?>().FirstOrDefault((BlueBottleIPC.LeagueBroadcast.Entity.Component? c) => c.HasValue && c.Value.Kind == BlueBottleIPC.LeagueBroadcast.Entity.Component.ItemKind.Script);
			if (!component.HasValue)
			{
				continue;
			}
			ComponentScript script = component.GetValueOrDefault().Script;
			if (script == null)
			{
				continue;
			}
			IList<ScriptEntry> scripts = script.Scripts;
			if (scripts == null)
			{
				continue;
			}
			int num = 0;
			for (int num2 = scripts.Count - 1; num2 >= 0; num2--)
			{
				if (scripts[num2].ScriptId == scriptId)
				{
					scripts.RemoveAt(num2);
					num++;
				}
			}
			if (num == 0)
			{
				continue;
			}
			if (script.Scripts.Count == 0)
			{
				RemoveComponentFromRecord(entity, ComponentKind.Script);
				if (_connector != null && _nativeSceneId != 0)
				{
					await _connector.RemoveComponentAsync(entity.Id, ComponentKind.Script);
				}
			}
			else if (_connector != null && _nativeSceneId != 0)
			{
				BlueBottleIPC.LeagueBroadcast.Entity.Component resolved = ResolveScriptComponent(script);
				await _connector.SetComponentAsync(entity.Id, resolved);
				_state?.GetEntity(entity.Id)?.SetComponent(resolved);
			}
		}
	}

	public async Task<bool> SaveAsync()
	{
		await _saveLock.WaitAsync().ConfigureAwait(continueOnCapturedContext: false);
		List<string> temporaryPaths = new List<string>();
		try
		{
			EnsureSceneDirectoryExists();
			string filePath = Path.Combine(SceneDirectory, "scene.fb");
			using FileStream writeLease = TryAcquireWriteLease();
			if (writeLease == null)
			{
				_logger.LogWarning("Scene '{Name}' is being saved by another application.", _name);
				return false;
			}
			bool flag = File.Exists(filePath);
			if (_loadedFileHash != null && !flag)
			{
				_logger.LogWarning("Scene '{Name}' was deleted after it was loaded; save rejected.", _name);
				return false;
			}
			if (flag)
			{
				byte[] array = SHA256.HashData(await File.ReadAllBytesAsync(filePath).ConfigureAwait(continueOnCapturedContext: false));
				if (_loadedFileHash == null || !array.SequenceEqual(_loadedFileHash))
				{
					_logger.LogWarning("Scene '{Name}' changed on disk after it was loaded; save rejected.", _name);
					return false;
				}
			}
			using FileStream assetWriteLease = _assetManager.AcquireWriteLease();
			if (assetWriteLease == null)
			{
				_logger.LogWarning("The shared asset library is busy; scene '{Name}' was not saved.", _name);
				return false;
			}
			_assetManager.RefreshScriptAssetsUnderWriteLease();
			if (_state != null)
			{
				SyncStateToEntities();
			}
			string[] array2 = (from scriptId in GetReferencedScriptIds()
				where _assetManager.GetScriptAsset(scriptId) == null
				select scriptId).ToArray();
			if (array2.Length != 0)
			{
				_logger.LogWarning("Scene '{Name}' references missing shared scripts and was not saved: {ScriptIds}.", _name, string.Join(", ", array2));
				return false;
			}
			RefreshScriptVariableMetadata();
			foreach (EntityRecord entity in _entities)
			{
				if (entity.Components == null)
				{
					continue;
				}
				for (int num = entity.Components.Count - 1; num >= 0; num--)
				{
					if (entity.Components[num].Kind == BlueBottleIPC.LeagueBroadcast.Entity.Component.ItemKind.NONE || entity.Components[num].Kind == BlueBottleIPC.LeagueBroadcast.Entity.Component.ItemKind.EditState)
					{
						entity.Components.RemoveAt(num);
					}
				}
			}
			SceneFile item = new SceneFile
			{
				Name = _name,
				IsActive = _isActive,
				ScriptLibrary = null,
				Entities = _entities
			};
			byte[] array3 = new byte[SceneFile.Serializer.GetMaxSize(item)];
			int written = SceneFile.Serializer.Write(array3, item);
			byte[] data = array3.AsMemory(0, written).ToArray();
			string sceneTemporaryPath = filePath + $".{Environment.ProcessId}.{Guid.NewGuid():N}.tmp";
			await WriteFileAsync(sceneTemporaryPath, data).ConfigureAwait(continueOnCapturedContext: false);
			temporaryPaths.Add(sceneTemporaryPath);
			File.Move(sceneTemporaryPath, filePath, overwrite: true);
			temporaryPaths.Remove(sceneTemporaryPath);
			_loadedFileHash = SHA256.HashData(data);
			_logger.LogDebug("Scene '{Name}' saved with {Count} entities ({Bytes} bytes).", _name, _entities.Count, written);
			return true;
		}
		catch (Exception exception)
		{
			_logger.LogError(exception, "Failed to save scene '{Name}'.", _name);
			return false;
		}
		finally
		{
			foreach (string item2 in temporaryPaths)
			{
				try
				{
					File.Delete(item2);
				}
				catch (IOException exception2)
				{
					_logger.LogDebug(exception2, "Failed to remove temporary scene file '{Path}'.", item2);
				}
			}
			_saveLock.Release();
		}
	}

	public async Task<bool> LoadAsync()
	{
		_ = 1;
		try
		{
			string path = Path.Combine(SceneDirectory, "scene.fb");
			if (!File.Exists(path))
			{
				_logger.LogDebug("No scene.fb found for '{Name}', starting empty.", _name);
				return true;
			}
			byte[] array = await File.ReadAllBytesAsync(path);
			SceneFile sceneFile = ISerializerExtensions.Parse(SceneFile.Serializer, array);
			_loadedFileHash = SHA256.HashData(array);
			if (sceneFile.Name != _name)
			{
				_logger.LogWarning("Scene file name '{FileName}' does not match expected scene name '{SceneName}'.", sceneFile.Name, _name);
			}
			_isActive = sceneFile.IsActive;
			List<(string Path, byte[] Hash)> migratedLegacySourceFiles = new List<(string, byte[])>();
			IList<ScriptAsset>? scriptLibrary = sceneFile.ScriptLibrary;
			bool migratedLegacyScripts = scriptLibrary != null && scriptLibrary.Count > 0;
			foreach (ScriptAsset item in sceneFile.ScriptLibrary ?? new List<ScriptAsset>())
			{
				string text = ResolveExistingLegacyScriptPath(item);
				ScriptAsset scriptAsset = _assetManager.MigrateLegacyScript(item, text);
				if (text != null && File.Exists(text))
				{
					byte[] source = File.ReadAllBytes(text);
					if (File.ReadAllText(text) == scriptAsset.Content)
					{
						migratedLegacySourceFiles.Add((text, SHA256.HashData(source)));
					}
				}
			}
			_entities = sceneFile.Entities?.ToList() ?? new List<EntityRecord>();
			string[] array2 = (from scriptId in GetReferencedScriptIds()
				where _assetManager.GetScriptAsset(scriptId) == null
				select scriptId).ToArray();
			if (array2.Length != 0)
			{
				throw new InvalidDataException($"Scene '{_name}' references missing shared scripts: {string.Join(", ", array2)}.");
			}
			if (_entities.Count > 0)
			{
				_nextLocalId = _entities.Max((EntityRecord e) => e.Id) + 1;
			}
			bool flag = migratedLegacyScripts;
			if (flag)
			{
				flag = !(await SaveAsync().ConfigureAwait(continueOnCapturedContext: false));
			}
			if (flag)
			{
				throw new IOException("Scene '" + _name + "' could not persist its shared-script migration.");
			}
			if (migratedLegacyScripts)
			{
				CleanupMigratedLegacySources(migratedLegacySourceFiles);
			}
			_logger.LogDebug("Scene '{Name}' loaded with {Count} entities.", _name, _entities.Count);
			return true;
		}
		catch (Exception exception)
		{
			_logger.LogError(exception, "Failed to load scene '{Name}'.", _name);
			return false;
		}
	}

	public EntityRecord? GetEntity(ulong entityId)
	{
		return _entities.FirstOrDefault((EntityRecord e) => e.Id == entityId);
	}

	public IReadOnlyList<EntityRecord> GetAllEntities()
	{
		return _entities;
	}

	public bool ReferencesScript(string scriptId)
	{
		return GetReferencedScriptIds().Contains(scriptId);
	}

	public IReadOnlySet<string> GetReferencedScriptIds()
	{
		HashSet<string> hashSet = new HashSet<string>(StringComparer.Ordinal);
		foreach (EntityRecord entity in _entities)
		{
			foreach (BlueBottleIPC.LeagueBroadcast.Entity.Component item in entity.Components ?? new List<BlueBottleIPC.LeagueBroadcast.Entity.Component>())
			{
				if (item.Kind != BlueBottleIPC.LeagueBroadcast.Entity.Component.ItemKind.Script)
				{
					continue;
				}
				IList<ScriptEntry> list = item.Script?.Scripts;
				if (list == null)
				{
					continue;
				}
				foreach (ScriptEntry item2 in list)
				{
					if (!string.IsNullOrEmpty(item2.ScriptId))
					{
						hashSet.Add(item2.ScriptId);
					}
				}
			}
		}
		return hashSet;
	}

	public IEnumerable<string> GetDecalAssetNames()
	{
		return from n in (from c in _entities.SelectMany((EntityRecord e) => e.Components ?? new List<BlueBottleIPC.LeagueBroadcast.Entity.Component>())
				select c.Kind switch
				{
					BlueBottleIPC.LeagueBroadcast.Entity.Component.ItemKind.DecalProjector => c.DecalProjector.Texture, 
					BlueBottleIPC.LeagueBroadcast.Entity.Component.ItemKind.SpriteRenderer => c.SpriteRenderer.Texture, 
					_ => null, 
				}).Select((AssetIdentifier? t) =>
			{
				if (t.HasValue)
				{
					AssetIdentifier valueOrDefault = t.GetValueOrDefault();
					if (valueOrDefault.Kind == AssetIdentifier.ItemKind.name)
					{
						return valueOrDefault.name;
					}
				}
				return "";
			})
			where !string.IsNullOrEmpty(n)
			select n;
	}

	public IEnumerable<string> GetFontNames()
	{
		return from c in _entities.SelectMany((EntityRecord e) => e.Components ?? new List<BlueBottleIPC.LeagueBroadcast.Entity.Component>())
			where c.Kind == BlueBottleIPC.LeagueBroadcast.Entity.Component.ItemKind.TextRenderer
			select c.TextRenderer.FontName ?? "";
	}

	public IEnumerable<string> GetModelAssetNames()
	{
		return (from c in _entities.SelectMany((EntityRecord e) => e.Components ?? new List<BlueBottleIPC.LeagueBroadcast.Entity.Component>())
			where c.Kind == BlueBottleIPC.LeagueBroadcast.Entity.Component.ItemKind.MeshRenderer
			select c).Select((BlueBottleIPC.LeagueBroadcast.Entity.Component c) =>
		{
			AssetIdentifier? model = c.MeshRenderer.Model;
			if (model.HasValue)
			{
				AssetIdentifier valueOrDefault = model.GetValueOrDefault();
				if (valueOrDefault.Kind == AssetIdentifier.ItemKind.name)
				{
					return valueOrDefault.name;
				}
			}
			return "";
		});
	}

	private async Task PreloadAssetsAsync()
	{
		List<(AssetType, string, string)> list = new List<(AssetType, string, string)>();
		foreach (string item in (from n in GetDecalAssetNames()
			where !string.IsNullOrEmpty(n)
			select n).Distinct())
		{
			string text = _assetManager.ResolveDecalPath(item);
			if (text != null)
			{
				list.Add((AssetType.texture, text, item));
				continue;
			}
			_logger.LogWarning("Decal asset '{Name}' referenced but not found on disk.", item);
		}
		foreach (string item2 in (from n in GetFontNames()
			where !string.IsNullOrEmpty(n)
			select n).Distinct())
		{
			string text2 = _assetManager.ResolveFontPath(item2);
			if (text2 != null)
			{
				list.Add((AssetType.font, text2, item2));
				continue;
			}
			_logger.LogWarning("Font asset '{Name}' referenced but not found on disk.", item2);
		}
		foreach (string item3 in (from n in GetModelAssetNames()
			where !string.IsNullOrEmpty(n)
			select n).Distinct())
		{
			string text3 = _assetManager.ResolveModelPath(item3);
			if (text3 != null)
			{
				list.Add((AssetType.model, text3, item3));
				continue;
			}
			_logger.LogWarning("Model asset '{Name}' referenced but not found on disk.", item3);
		}
		if (list.Count > 0)
		{
			_logger.LogInformation("Pre-loading {Count} assets for scene '{Name}'.", list.Count, _name);
			HashSet<string> hashSet = await AssetConnector.CreateBatchAsync(list);
			if (hashSet == null)
			{
				_logger.LogError("Failed to pre-load assets for scene '{Name}'.", _name);
			}
			else
			{
				_logger.LogInformation("Successfully pre-loaded {Count} assets.", hashSet.Count);
			}
		}
	}

	private Task EnsureComponentAssetsLoadedAsync(BlueBottleIPC.LeagueBroadcast.Entity.Component component)
	{
		int num = 1;
		List<BlueBottleIPC.LeagueBroadcast.Entity.Component> list = new List<BlueBottleIPC.LeagueBroadcast.Entity.Component>(num);
		CollectionsMarshal.SetCount(list, num);
		CollectionsMarshal.AsSpan(list)[0] = component;
		return EnsureComponentsAssetsLoadedAsync(list);
	}

	private async Task EnsureComponentsAssetsLoadedAsync(IList<BlueBottleIPC.LeagueBroadcast.Entity.Component> components)
	{
		List<(AssetType, string, string)> list = new List<(AssetType, string, string)>();
		foreach (BlueBottleIPC.LeagueBroadcast.Entity.Component component in components)
		{
			AssetIdentifier? assetIdentifier;
			if (component.Kind == BlueBottleIPC.LeagueBroadcast.Entity.Component.ItemKind.DecalProjector)
			{
				assetIdentifier = component.DecalProjector?.Texture;
				if (assetIdentifier.HasValue)
				{
					AssetIdentifier valueOrDefault = assetIdentifier.GetValueOrDefault();
					if (valueOrDefault.Kind == AssetIdentifier.ItemKind.name && !string.IsNullOrEmpty(valueOrDefault.name))
					{
						string text = _assetManager.ResolveDecalPath(valueOrDefault.name);
						if (text != null)
						{
							list.Add((AssetType.texture, text, valueOrDefault.name));
						}
						continue;
					}
				}
			}
			if (component.Kind == BlueBottleIPC.LeagueBroadcast.Entity.Component.ItemKind.SpriteRenderer)
			{
				assetIdentifier = component.SpriteRenderer?.Texture;
				if (assetIdentifier.HasValue)
				{
					AssetIdentifier valueOrDefault2 = assetIdentifier.GetValueOrDefault();
					if (valueOrDefault2.Kind == AssetIdentifier.ItemKind.name && !string.IsNullOrEmpty(valueOrDefault2.name))
					{
						string text2 = _assetManager.ResolveDecalPath(valueOrDefault2.name);
						if (text2 != null)
						{
							list.Add((AssetType.texture, text2, valueOrDefault2.name));
						}
						continue;
					}
				}
			}
			if (component.Kind != BlueBottleIPC.LeagueBroadcast.Entity.Component.ItemKind.MeshRenderer)
			{
				continue;
			}
			ComponentMeshRenderer meshRenderer = component.MeshRenderer;
			if (meshRenderer == null)
			{
				continue;
			}
			assetIdentifier = meshRenderer.Model;
			if (assetIdentifier.HasValue)
			{
				AssetIdentifier valueOrDefault3 = assetIdentifier.GetValueOrDefault();
				if (valueOrDefault3.Kind == AssetIdentifier.ItemKind.name && !string.IsNullOrEmpty(valueOrDefault3.name))
				{
					string text3 = _assetManager.ResolveModelPath(valueOrDefault3.name);
					if (text3 != null)
					{
						list.Add((AssetType.model, text3, valueOrDefault3.name));
					}
				}
			}
			assetIdentifier = meshRenderer.OverrideTexture;
			if (!assetIdentifier.HasValue)
			{
				continue;
			}
			AssetIdentifier valueOrDefault4 = assetIdentifier.GetValueOrDefault();
			if (valueOrDefault4.Kind == AssetIdentifier.ItemKind.name && !string.IsNullOrEmpty(valueOrDefault4.name))
			{
				string text4 = _assetManager.ResolveDecalPath(valueOrDefault4.name);
				if (text4 != null)
				{
					list.Add((AssetType.texture, text4, valueOrDefault4.name));
				}
			}
		}
		if (list.Count > 0)
		{
			await AssetConnector.CreateBatchAsync(list);
		}
	}

	private void ReattachScriptMetadata(ulong entityId, IList<BlueBottleIPC.LeagueBroadcast.Entity.Component> components)
	{
		EntityRecord entityRecord = _entities.FirstOrDefault((EntityRecord e) => e.Id == entityId);
		if (entityRecord?.Components == null)
		{
			return;
		}
		BlueBottleIPC.LeagueBroadcast.Entity.Component component = entityRecord.Components.FirstOrDefault((BlueBottleIPC.LeagueBroadcast.Entity.Component c) => c.Kind == BlueBottleIPC.LeagueBroadcast.Entity.Component.ItemKind.Script);
		ComponentScript componentScript = ((component.Kind == BlueBottleIPC.LeagueBroadcast.Entity.Component.ItemKind.Script) ? component.Script : null);
		if (componentScript?.Scripts == null)
		{
			return;
		}
		BlueBottleIPC.LeagueBroadcast.Entity.Component component2 = components.FirstOrDefault((BlueBottleIPC.LeagueBroadcast.Entity.Component c) => c.Kind == BlueBottleIPC.LeagueBroadcast.Entity.Component.ItemKind.Script);
		ComponentScript componentScript2 = ((component2.Kind == BlueBottleIPC.LeagueBroadcast.Entity.Component.ItemKind.Script) ? component2.Script : null);
		if (componentScript2?.Scripts == null)
		{
			return;
		}
		for (int num = 0; num < componentScript2.Scripts.Count && num < componentScript.Scripts.Count; num++)
		{
			ScriptEntry scriptEntry = componentScript2.Scripts[num];
			ScriptEntry scriptEntry2 = componentScript.Scripts[num];
			if (scriptEntry2.ScriptId != null)
			{
				scriptEntry.ScriptId = scriptEntry2.ScriptId;
				scriptEntry.VariableOverrides = scriptEntry2.VariableOverrides;
			}
		}
	}

	private IList<BlueBottleIPC.LeagueBroadcast.Entity.Component> ResolveComponentsForIpc(IList<BlueBottleIPC.LeagueBroadcast.Entity.Component>? components)
	{
		if (components == null)
		{
			return new List<BlueBottleIPC.LeagueBroadcast.Entity.Component>();
		}
		List<BlueBottleIPC.LeagueBroadcast.Entity.Component> list = new List<BlueBottleIPC.LeagueBroadcast.Entity.Component>(components.Count);
		foreach (BlueBottleIPC.LeagueBroadcast.Entity.Component component in components)
		{
			if (component.Kind == BlueBottleIPC.LeagueBroadcast.Entity.Component.ItemKind.EditState)
			{
				continue;
			}
			if (component.Kind == BlueBottleIPC.LeagueBroadcast.Entity.Component.ItemKind.Script)
			{
				ComponentScript script = component.Script;
				if (script != null)
				{
					IList<ScriptEntry>? scripts = script.Scripts;
					if (scripts != null && scripts.Any((ScriptEntry s) => s.ScriptId != null))
					{
						list.Add(ResolveScriptComponent(script));
						continue;
					}
				}
			}
			list.Add(component);
		}
		return list;
	}

	private BlueBottleIPC.LeagueBroadcast.Entity.Component ResolveScriptComponent(ComponentScript cs)
	{
		return new BlueBottleIPC.LeagueBroadcast.Entity.Component(new ComponentScript
		{
			Scripts = (cs.Scripts?.Select((ScriptEntry entry) =>
			{
				if (entry.ScriptId != null)
				{
					ScriptAsset scriptAsset = _assetManager.GetScriptAsset(entry.ScriptId);
					if (scriptAsset != null)
					{
						return new ScriptEntry
						{
							Name = (entry.Name ?? scriptAsset.Name),
							Content = (scriptAsset.Content ?? ""),
							Enabled = entry.Enabled,
							ScriptId = entry.ScriptId,
							VariableOverrides = entry.VariableOverrides
						};
					}
				}
				return entry;
			}).ToList() ?? new List<ScriptEntry>())
		});
	}

	private static void ApplyComponentToRecord(EntityRecord entity, BlueBottleIPC.LeagueBroadcast.Entity.Component component)
	{
		BlueBottleIPC.LeagueBroadcast.Entity.Component.ItemKind kind = component.Kind;
		if (entity.Components == null)
		{
			IList<BlueBottleIPC.LeagueBroadcast.Entity.Component> list = (entity.Components = new List<BlueBottleIPC.LeagueBroadcast.Entity.Component>());
		}
		for (int i = 0; i < entity.Components.Count; i++)
		{
			if (entity.Components[i].Kind == kind)
			{
				entity.Components[i] = component;
				return;
			}
		}
		entity.Components.Add(component);
	}

	private static void RemoveComponentFromRecord(EntityRecord entity, ComponentKind kind)
	{
		if (entity.Components == null)
		{
			return;
		}
		BlueBottleIPC.LeagueBroadcast.Entity.Component.ItemKind itemKind = (BlueBottleIPC.LeagueBroadcast.Entity.Component.ItemKind)(kind + 1);
		for (int num = entity.Components.Count - 1; num >= 0; num--)
		{
			if (entity.Components[num].Kind == itemKind)
			{
				entity.Components.RemoveAt(num);
				break;
			}
		}
	}

	private static BlueBottleIPC.LeagueBroadcast.Entity.Component CloneComponent(BlueBottleIPC.LeagueBroadcast.Entity.Component component)
	{
		switch (component.Kind)
		{
		case BlueBottleIPC.LeagueBroadcast.Entity.Component.ItemKind.Transform:
		{
			ComponentTransform transform = component.Transform;
			if (transform != null)
			{
				return new BlueBottleIPC.LeagueBroadcast.Entity.Component(CloneTable(transform, ComponentTransform.Serializer));
			}
			break;
		}
		case BlueBottleIPC.LeagueBroadcast.Entity.Component.ItemKind.Visibility:
		{
			ComponentVisibility visibility = component.Visibility;
			if (visibility != null)
			{
				return new BlueBottleIPC.LeagueBroadcast.Entity.Component(CloneTable(visibility, ComponentVisibility.Serializer));
			}
			break;
		}
		case BlueBottleIPC.LeagueBroadcast.Entity.Component.ItemKind.EditState:
		{
			ComponentEditState editState = component.EditState;
			if (editState != null)
			{
				return new BlueBottleIPC.LeagueBroadcast.Entity.Component(CloneTable(editState, ComponentEditState.Serializer));
			}
			break;
		}
		case BlueBottleIPC.LeagueBroadcast.Entity.Component.ItemKind.Script:
		{
			ComponentScript script = component.Script;
			if (script != null)
			{
				return new BlueBottleIPC.LeagueBroadcast.Entity.Component(CloneTable(script, ComponentScript.Serializer));
			}
			break;
		}
		case BlueBottleIPC.LeagueBroadcast.Entity.Component.ItemKind.MeshRenderer:
		{
			ComponentMeshRenderer meshRenderer = component.MeshRenderer;
			if (meshRenderer != null)
			{
				return new BlueBottleIPC.LeagueBroadcast.Entity.Component(CloneTable(meshRenderer, ComponentMeshRenderer.Serializer));
			}
			break;
		}
		case BlueBottleIPC.LeagueBroadcast.Entity.Component.ItemKind.DecalProjector:
		{
			ComponentDecalProjector decalProjector = component.DecalProjector;
			if (decalProjector != null)
			{
				return new BlueBottleIPC.LeagueBroadcast.Entity.Component(CloneTable(decalProjector, ComponentDecalProjector.Serializer));
			}
			break;
		}
		case BlueBottleIPC.LeagueBroadcast.Entity.Component.ItemKind.TextRenderer:
		{
			ComponentTextRenderer textRenderer = component.TextRenderer;
			if (textRenderer != null)
			{
				return new BlueBottleIPC.LeagueBroadcast.Entity.Component(CloneTable(textRenderer, ComponentTextRenderer.Serializer));
			}
			break;
		}
		case BlueBottleIPC.LeagueBroadcast.Entity.Component.ItemKind.StreamSource:
		{
			ComponentStreamSource streamSource = component.StreamSource;
			if (streamSource != null)
			{
				return new BlueBottleIPC.LeagueBroadcast.Entity.Component(CloneTable(streamSource, ComponentStreamSource.Serializer));
			}
			break;
		}
		case BlueBottleIPC.LeagueBroadcast.Entity.Component.ItemKind.SpriteRenderer:
		{
			ComponentSpriteRenderer spriteRenderer = component.SpriteRenderer;
			if (spriteRenderer != null)
			{
				return new BlueBottleIPC.LeagueBroadcast.Entity.Component(CloneTable(spriteRenderer, ComponentSpriteRenderer.Serializer));
			}
			break;
		}
		case BlueBottleIPC.LeagueBroadcast.Entity.Component.ItemKind.UnitAnchor:
		{
			ComponentUnitAnchor unitAnchor = component.UnitAnchor;
			if (unitAnchor != null)
			{
				return new BlueBottleIPC.LeagueBroadcast.Entity.Component(CloneTable(unitAnchor, ComponentUnitAnchor.Serializer));
			}
			break;
		}
		}
		return component;
	}

	private static T CloneTable<T>(T value, ISerializer<T> serializer) where T : class
	{
		byte[] buffer = new byte[serializer.GetMaxSize(value)];
		serializer.Write(buffer, value);
		return serializer.Parse(new ArrayInputBuffer(buffer));
	}

	private void SyncStateToEntities()
	{
		if (_state == null)
		{
			return;
		}
		Dictionary<ulong, EntityRecord> existing = _entities.ToDictionary((EntityRecord e) => e.Id);
		_entities = _state.Entities.Select((EntityState e) =>
		{
			List<BlueBottleIPC.LeagueBroadcast.Entity.Component> list = (from c in e.GetAllComponents()
				select (c)).ToList();
			if (existing.TryGetValue(e.Id, out EntityRecord value))
			{
				BlueBottleIPC.LeagueBroadcast.Entity.Component? component = value.Components?.Cast<BlueBottleIPC.LeagueBroadcast.Entity.Component?>().FirstOrDefault((BlueBottleIPC.LeagueBroadcast.Entity.Component? c) => c.HasValue && c.Value.Kind == BlueBottleIPC.LeagueBroadcast.Entity.Component.ItemKind.Script);
				if (component.HasValue)
				{
					bool flag = false;
					for (int num = 0; num < list.Count; num++)
					{
						if (list[num].Kind == BlueBottleIPC.LeagueBroadcast.Entity.Component.ItemKind.Script)
						{
							list[num] = component.Value;
							flag = true;
							break;
						}
					}
					if (!flag)
					{
						list.Add(component.Value);
					}
				}
			}
			EntityRecord value2;
			return new EntityRecord
			{
				Id = e.Id,
				Name = (existing.TryGetValue(e.Id, out value2) ? value2.Name : null),
				Components = list
			};
		}).ToList();
	}

	private void EnsureSceneDirectoryExists()
	{
		Directory.CreateDirectory(SceneDirectory);
	}

	private void RefreshScriptVariableMetadata()
	{
		Dictionary<string, IReadOnlyDictionary<string, ScriptVariableValue>> dictionary = new Dictionary<string, IReadOnlyDictionary<string, ScriptVariableValue>>();
		foreach (ScriptAsset item in ScriptLibrary)
		{
			item.Variables = ScriptVariableParser.Parse(item.Content);
			dictionary[item.Id] = item.Variables.ToDictionary((ScriptVariable variable) => variable.Name, (ScriptVariable variable) => variable.TypedValue ?? new ScriptVariableValue());
		}
		foreach (EntityRecord entity in _entities)
		{
			foreach (BlueBottleIPC.LeagueBroadcast.Entity.Component item2 in entity.Components ?? new List<BlueBottleIPC.LeagueBroadcast.Entity.Component>())
			{
				try
				{
					if (!item2.TryGet(out ComponentScript value))
					{
						continue;
					}
					IList<ScriptEntry> scripts = value.Scripts;
					if (scripts == null)
					{
						continue;
					}
					foreach (ScriptEntry item3 in scripts)
					{
						IReadOnlyDictionary<string, ScriptVariableValue> readOnlyDictionary2;
						if (item3.ScriptId == null || !dictionary.TryGetValue(item3.ScriptId, out var value2))
						{
							IReadOnlyDictionary<string, ScriptVariableValue> readOnlyDictionary = ScriptVariableParser.Parse(item3.Content).ToDictionary((ScriptVariable variable) => variable.Name, (ScriptVariable variable) => variable.TypedValue ?? new ScriptVariableValue());
							readOnlyDictionary2 = readOnlyDictionary;
						}
						else
						{
							readOnlyDictionary2 = value2;
						}
						IReadOnlyDictionary<string, ScriptVariableValue> readOnlyDictionary3 = readOnlyDictionary2;
						foreach (ScriptVariableOverride item4 in item3.VariableOverrides ?? new List<ScriptVariableOverride>())
						{
							if (item4.TypedValue == null && readOnlyDictionary3.TryGetValue(item4.Name, out var value3))
							{
								ScriptVariableValue scriptVariableValue = ScriptVariableParser.ParseLegacyValue(value3, item4.Value);
								if (scriptVariableValue != null)
								{
									item4.TypedValue = scriptVariableValue;
									item4.Value = null;
								}
							}
						}
					}
				}
				catch (Exception ex) when ((ex is InvalidCastException || ex is InvalidOperationException) ? true : false)
				{
					_logger.LogWarning(ex, "Ignoring a malformed component union while saving scene '{Name}'.", _name);
				}
			}
		}
	}

	private string? ResolveExistingLegacyScriptPath(ScriptAsset script)
	{
		string text = SceneLibraryPaths.ResolveRelativePath(SceneDirectory, "scripts");
		string expectedLegacyScriptPath = GetExpectedLegacyScriptPath(script);
		if (File.Exists(expectedLegacyScriptPath))
		{
			return expectedLegacyScriptPath;
		}
		if (!Directory.Exists(text))
		{
			return null;
		}
		string text2 = "--" + GetScriptIdHash(script.Id) + ".as";
		EnumerationOptions enumerationOptions = new EnumerationOptions
		{
			AttributesToSkip = FileAttributes.ReparsePoint,
			RecurseSubdirectories = true
		};
		string[] array = Directory.EnumerateFiles(text, "*" + text2, enumerationOptions).ToArray();
		try
		{
			string text3 = SceneLibraryPaths.ResolveRelativePath(text, SceneLibraryPaths.NormalizeRelativePath(script.Name) + ".as");
			if (File.Exists(text3) && !array.Contains(text3, StringComparer.OrdinalIgnoreCase))
			{
				string[] array2 = array;
				int num = 0;
				string[] array3 = new string[1 + array2.Length];
				ReadOnlySpan<string> readOnlySpan = new ReadOnlySpan<string>(array2);
				readOnlySpan.CopyTo(new Span<string>(array3).Slice(num, readOnlySpan.Length));
				num += readOnlySpan.Length;
				array3[num] = text3;
				array = array3;
			}
		}
		catch (ArgumentException)
		{
		}
		return array.Length switch
		{
			0 => null, 
			1 => array[0], 
			_ => throw new InvalidDataException("Multiple source files exist for script '" + script.Id + "'."), 
		};
	}

	private void CleanupMigratedLegacySources(IEnumerable<(string Path, byte[] Hash)> migratedSources)
	{
		try
		{
			string scriptsDirectory = ScriptsDirectory;
			if (!Directory.Exists(scriptsDirectory))
			{
				return;
			}
			foreach (var (text, array) in migratedSources.DistinctBy(((string Path, byte[] Hash) source) => source.Path))
			{
				if (File.Exists(text))
				{
					if (SHA256.HashData(File.ReadAllBytes(text)).SequenceEqual(array))
					{
						File.Delete(text);
						continue;
					}
					_logger.LogWarning("Migrated legacy script '{Path}' changed before cleanup and was preserved.", text);
				}
			}
			EnumerationOptions enumerationOptions = new EnumerationOptions
			{
				AttributesToSkip = FileAttributes.ReparsePoint,
				RecurseSubdirectories = true
			};
			foreach (string item in from path in Directory.EnumerateDirectories(scriptsDirectory, "*", enumerationOptions)
				orderby path.Length descending
				select path)
			{
				if (!Directory.EnumerateFileSystemEntries(item).Any())
				{
					Directory.Delete(item, recursive: false);
				}
			}
			if (Directory.Exists(scriptsDirectory) && !Directory.EnumerateFileSystemEntries(scriptsDirectory).Any())
			{
				Directory.Delete(scriptsDirectory, recursive: false);
			}
		}
		catch (Exception ex) when ((ex is IOException || ex is UnauthorizedAccessException) ? true : false)
		{
			_logger.LogWarning(ex, "Migrated legacy scripts for scene '{Name}' could not be fully cleaned up.", _name);
		}
	}

	private string GetExpectedLegacyScriptPath(ScriptAsset script)
	{
		string text = new string(script.Name.Select((char character) =>
		{
			bool flag = char.IsLetterOrDigit(character);
			if (!flag)
			{
				bool flag2 = ((character == '-' || character == '_') ? true : false);
				flag = flag2;
			}
			return (!flag) ? '-' : character;
		}).Take(80).ToArray());
		text = text.Trim('-');
		if (string.IsNullOrEmpty(text))
		{
			text = "Script";
		}
		return SceneLibraryPaths.ResolveRelativePath(SceneLibraryPaths.ResolveRelativePath(SceneDirectory, "scripts"), text + "--" + GetScriptIdHash(script.Id) + ".as");
	}

	private static string GetScriptIdHash(string scriptId)
	{
		return Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(scriptId))).Substring(0, 16).ToLowerInvariant();
	}

	private static async Task WriteFileAsync(string path, byte[] data)
	{
		await using FileStream stream = new FileStream(path, FileMode.CreateNew, FileAccess.Write, FileShare.None, 4096, FileOptions.WriteThrough | FileOptions.Asynchronous);
		await stream.WriteAsync(data).ConfigureAwait(continueOnCapturedContext: false);
		await stream.FlushAsync().ConfigureAwait(continueOnCapturedContext: false);
		stream.Flush(flushToDisk: true);
	}

	private void OnPropertyChanged(string propertyName)
	{
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}

	private void OnExternalEntitiesAdded(object? sender, SceneEntitiesAdded e)
	{
		if (e.SceneId != _nativeSceneId || _nativeSceneId == 0 || e.Assignments == null)
		{
			return;
		}
		foreach (EntityAssignment assignment in e.Assignments)
		{
			if (assignment.AssignedId != 0L && !_entities.Any((EntityRecord ent) => ent.Id == assignment.AssignedId))
			{
				EntityRecord entityRecord = new EntityRecord
				{
					Id = assignment.AssignedId,
					Components = new List<BlueBottleIPC.LeagueBroadcast.Entity.Component>()
				};
				_entities.Add(entityRecord);
				_state?.AddEntity(assignment.AssignedId);
				_logger.LogDebug("External entity {Id} added to scene '{Name}' via EntitiesAdded.", assignment.AssignedId, _name);
				FetchAndApplyComponentsAsync(assignment.AssignedId, entityRecord);
			}
		}
	}

	private async Task FetchAndApplyComponentsAsync(ulong entityId, EntityRecord record)
	{
		if (_connector == null)
		{
			return;
		}
		try
		{
			IList<EntitySnapshot> list = (await _connector.GetComponentsAsync(entityId))?.Entities;
			if (list != null && list.Count > 0)
			{
				IList<BlueBottleIPC.LeagueBroadcast.Entity.Component> components = list[0].Components;
				if (components != null)
				{
					record.Components = components.ToList();
					EntityState entityState = _state?.GetEntity(entityId);
					if (entityState != null)
					{
						foreach (BlueBottleIPC.LeagueBroadcast.Entity.Component item in components)
						{
							entityState.SetComponent(item);
						}
					}
					_logger.LogDebug("Fetched {Count} components for external entity {Id} in scene '{Name}'.", components.Count, entityId, _name);
				}
			}
		}
		catch (Exception exception)
		{
			_logger.LogWarning(exception, "Failed to fetch components for external entity {Id}.", entityId);
		}
		ExternalEntityReady?.Invoke(this, entityId);
	}

	private void OnExternalEntityChanged(object? sender, SceneEntityChanged e)
	{
		if (e.SceneId != _nativeSceneId || _nativeSceneId == 0)
		{
			return;
		}
		switch (e.Kind)
		{
		case EntityEventKind.Created:
		case EntityEventKind.Placed:
			if (!_entities.Any((EntityRecord ent) => ent.Id == e.EntityId))
			{
				List<BlueBottleIPC.LeagueBroadcast.Entity.Component> components = e.ChangedComponents?.ToList() ?? new List<BlueBottleIPC.LeagueBroadcast.Entity.Component>();
				EntityRecord item = new EntityRecord
				{
					Id = e.EntityId,
					Components = components
				};
				_entities.Add(item);
				_logger.LogDebug("External entity {Id} added to scene '{Name}' _entities (kind={Kind}).", e.EntityId, _name, e.Kind);
			}
			break;
		case EntityEventKind.Destroyed:
			_entities.RemoveAll((EntityRecord ent) => ent.Id == e.EntityId);
			_logger.LogDebug("External entity {Id} removed from scene '{Name}' _entities.", e.EntityId, _name);
			break;
		case EntityEventKind.Updated:
			break;
		}
	}

	private void OnExternalTransformUpdates(object? sender, SceneEntityTransformUpdates e)
	{
		if (e.SceneId != _nativeSceneId || _nativeSceneId == 0 || _state == null || e.Updates == null)
		{
			return;
		}
		foreach (EntityTransformUpdate update in e.Updates)
		{
			_state.GetEntity(update.EntityId)?.SetComponent(new BlueBottleIPC.LeagueBroadcast.Entity.Component(update.Transform));
		}
	}

	public void Dispose()
	{
		if (!_disposed)
		{
			_disposed = true;
			if (_connector != null)
			{
				_connector.EntitiesAddedEvent -= OnExternalEntitiesAdded;
				_connector.EntityChangedEvent -= OnExternalEntityChanged;
				_connector.EntityTransformUpdatesEvent -= OnExternalTransformUpdates;
			}
			_saveLock.Dispose();
			GC.SuppressFinalize(this);
		}
	}

	private FileStream? TryAcquireWriteLease()
	{
		string path = Path.Combine(SceneDirectory, ".save.lock");
		for (int i = 0; i < 20; i++)
		{
			try
			{
				return new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
			}
			catch (IOException) when (i < 19)
			{
				Thread.Sleep(25);
			}
		}
		return null;
	}
}
