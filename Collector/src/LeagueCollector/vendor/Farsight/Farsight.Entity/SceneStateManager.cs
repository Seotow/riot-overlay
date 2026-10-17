using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using BlueBottleIPC.LeagueBroadcast.Entity;
using BlueBottleIPC.LeagueBroadcast.Scene;

namespace Farsight.Entity;

public sealed class SceneStateManager : IDisposable
{
	private readonly SceneConnector _connector;

	private readonly ConcurrentDictionary<uint, SceneState> _scenes = new ConcurrentDictionary<uint, SceneState>();

	private bool _disposed;

	public SceneConnector Connector => _connector;

	public ICollection<SceneState> Scenes => _scenes.Values;

	public event EventHandler<SceneState>? SceneAdded;

	public event EventHandler<uint>? SceneRemoved;

	public event EventHandler<SceneState>? SceneChanged;

	public event EventHandler<(SceneState Scene, EntityState Entity)>? EntityAdded;

	public event EventHandler<(uint SceneId, ulong EntityId)>? EntityRemoved;

	public event EventHandler<(SceneState Scene, EntityState Entity)>? EntityChanged;

	public bool TryGetScene(uint sceneId, [NotNullWhen(true)] out SceneState? scene)
	{
		return _scenes.TryGetValue(sceneId, out scene);
	}

	public SceneState? GetScene(uint sceneId)
	{
		return _scenes.GetValueOrDefault(sceneId);
	}

	public SceneStateManager(SceneConnector connector)
	{
		_connector = connector ?? throw new ArgumentNullException("connector");
		_connector.SceneCreatedEvent += OnSceneCreated;
		_connector.SceneUnloadedEvent += OnSceneUnloaded;
		_connector.SceneStateChangedEvent += OnSceneStateChanged;
		_connector.EntitiesAddedEvent += OnEntitiesAdded;
		_connector.EntitiesRemovedEvent += OnEntitiesRemoved;
		_connector.EntityChangedEvent += OnEntityChanged;
		_connector.EntityTransformUpdatesEvent += OnEntityTransformUpdates;
		_connector.EntityIdChangedEvent += OnEntityIdChanged;
	}

	public void Dispose()
	{
		if (!_disposed)
		{
			_disposed = true;
			_connector.SceneCreatedEvent -= OnSceneCreated;
			_connector.SceneUnloadedEvent -= OnSceneUnloaded;
			_connector.SceneStateChangedEvent -= OnSceneStateChanged;
			_connector.EntitiesAddedEvent -= OnEntitiesAdded;
			_connector.EntitiesRemovedEvent -= OnEntitiesRemoved;
			_connector.EntityChangedEvent -= OnEntityChanged;
			_connector.EntityTransformUpdatesEvent -= OnEntityTransformUpdates;
			_connector.EntityIdChangedEvent -= OnEntityIdChanged;
		}
	}

	public void NotifySceneChanged(uint sceneId, string name, bool visible, bool editable, int zOrder, int entityCount)
	{
		SceneState orCreateScene = GetOrCreateScene(sceneId, name);
		orCreateScene.Visible = visible;
		orCreateScene.Editable = editable;
		orCreateScene.ZOrder = zOrder;
		SceneChanged?.Invoke(this, orCreateScene);
	}

	public void ApplySceneSnapshot(SceneSnapshot snapshot)
	{
		if (snapshot.Scene != null)
		{
			GetOrCreateScene(snapshot.Scene.SceneId, snapshot.Scene.Name ?? "").ApplySnapshot(snapshot);
		}
	}

	private void OnSceneCreated(object? sender, SceneCreated e)
	{
		if (e.Scene != null)
		{
			SceneState orCreateScene = GetOrCreateScene(e.Scene.SceneId, e.Scene.Name ?? "");
			orCreateScene.ApplyDescriptor(e.Scene);
			SceneAdded?.Invoke(this, orCreateScene);
		}
	}

	private void OnSceneUnloaded(object? sender, SceneUnloaded e)
	{
		if (_scenes.TryRemove(e.SceneId, out SceneState _))
		{
			SceneRemoved?.Invoke(this, e.SceneId);
		}
	}

	private void OnSceneStateChanged(object? sender, SceneStateChanged e)
	{
		if (e.Scene != null)
		{
			SceneState orCreateScene = GetOrCreateScene(e.Scene.SceneId, e.Scene.Name ?? "");
			orCreateScene.ApplyDescriptor(e.Scene);
			SceneChanged?.Invoke(this, orCreateScene);
		}
	}

	private void OnEntitiesAdded(object? sender, SceneEntitiesAdded e)
	{
		if (!_scenes.TryGetValue(e.SceneId, out SceneState value) || e.Assignments == null)
		{
			return;
		}
		foreach (EntityAssignment assignment in e.Assignments)
		{
			EntityState item = value.AddEntity(assignment.AssignedId);
			EntityAdded?.Invoke(this, (value, item));
		}
	}

	private void OnEntitiesRemoved(object? sender, SceneEntitiesRemoved e)
	{
		if (!_scenes.TryGetValue(e.SceneId, out SceneState value))
		{
			return;
		}
		foreach (ulong item in e.LocalIds ?? new List<ulong>())
		{
			value.RemoveEntity(item);
			EntityRemoved?.Invoke(this, (e.SceneId, item));
		}
		foreach (ulong item2 in e.ReparentedIds ?? new List<ulong>())
		{
			ComponentTransform componentTransform = value.GetEntity(item2)?.Transform;
			if (componentTransform != null)
			{
				componentTransform.ParentId = 0uL;
			}
		}
	}

	private void OnEntityChanged(object? sender, SceneEntityChanged e)
	{
		if (!_scenes.TryGetValue(e.SceneId, out SceneState value))
		{
			return;
		}
		switch (e.Kind)
		{
		case EntityEventKind.Created:
		case EntityEventKind.Placed:
		{
			EntityState entityState = value.GetEntity(e.EntityId) ?? value.AddEntity(e.EntityId);
			ApplyComponents(entityState, e.ChangedComponents);
			if (e.Kind == EntityEventKind.Created)
			{
				EntityAdded?.Invoke(this, (value, entityState));
			}
			else
			{
				EntityChanged?.Invoke(this, (value, entityState));
			}
			break;
		}
		case EntityEventKind.Updated:
		{
			EntityState entity = value.GetEntity(e.EntityId);
			if (entity != null)
			{
				ApplyComponents(entity, e.ChangedComponents);
				EntityChanged?.Invoke(this, (value, entity));
			}
			break;
		}
		case EntityEventKind.Destroyed:
			value.RemoveEntity(e.EntityId);
			EntityRemoved?.Invoke(this, (e.SceneId, e.EntityId));
			break;
		}
	}

	private void OnEntityTransformUpdates(object? sender, SceneEntityTransformUpdates e)
	{
		if (!_scenes.TryGetValue(e.SceneId, out SceneState value) || e.Updates == null)
		{
			return;
		}
		foreach (EntityTransformUpdate update in e.Updates)
		{
			EntityState entity = value.GetEntity(update.EntityId);
			if (entity != null)
			{
				Component component = new Component(update.Transform);
				entity.SetComponent(component);
				EntityChanged?.Invoke(this, (value, entity));
			}
		}
	}

	private void OnEntityIdChanged(object? sender, SceneEntityIdChanged e)
	{
		if (_scenes.TryGetValue(e.SceneId, out SceneState value))
		{
			value.RemoveEntity(e.OldEntityId);
			value.AddEntity(e.NewEntityId);
		}
	}

	private SceneState GetOrCreateScene(uint sceneId, string name)
	{
		return _scenes.GetOrAdd(sceneId, (uint id) => new SceneState(id, name));
	}

	private static void ApplyComponents(EntityState entity, IList<Component>? components)
	{
		if (components == null)
		{
			return;
		}
		foreach (Component component in components)
		{
			entity.SetComponent(component);
		}
	}
}
