using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using BlueBottleIPC.LeagueBroadcast.Entity;
using BlueBottleIPC.LeagueBroadcast.Scene;

namespace Farsight.Entity;

public sealed class SceneState
{
	private readonly ConcurrentDictionary<ulong, EntityState> _entities = new ConcurrentDictionary<ulong, EntityState>();

	public uint SceneId { get; }

	public string Name { get; internal set; }

	public bool Visible { get; internal set; } = true;

	public bool Editable { get; internal set; }

	public int ZOrder { get; internal set; }

	public ICollection<EntityState> Entities => _entities.Values;

	public int EntityCount => _entities.Count;

	public SceneState(uint sceneId, string name)
	{
		SceneId = sceneId;
		Name = name;
	}

	public bool TryGetEntity(ulong entityId, [NotNullWhen(true)] out EntityState? entity)
	{
		return _entities.TryGetValue(entityId, out entity);
	}

	public EntityState? GetEntity(ulong entityId)
	{
		return _entities.GetValueOrDefault(entityId);
	}

	internal EntityState AddEntity(ulong entityId, IList<Component>? components = null)
	{
		EntityState entityState = new EntityState(entityId, SceneId, components);
		_entities[entityId] = entityState;
		return entityState;
	}

	internal bool RemoveEntity(ulong entityId)
	{
		EntityState value;
		return _entities.TryRemove(entityId, out value);
	}

	internal void Clear()
	{
		_entities.Clear();
	}

	internal void ApplySnapshot(SceneSnapshot snapshot)
	{
		_entities.Clear();
		if (snapshot.Scene != null)
		{
			Name = snapshot.Scene.Name ?? Name;
			Visible = snapshot.Scene.Visible;
			Editable = snapshot.Scene.Editable;
			ZOrder = snapshot.Scene.ZOrder;
		}
		if (snapshot.Entities == null)
		{
			return;
		}
		foreach (EntitySnapshot entity in snapshot.Entities)
		{
			AddEntity(entity.EntityId, entity.Components);
		}
	}

	internal void ApplyDescriptor(SceneDescriptor descriptor)
	{
		Name = descriptor.Name ?? Name;
		Visible = descriptor.Visible;
		Editable = descriptor.Editable;
		ZOrder = descriptor.ZOrder;
	}
}
