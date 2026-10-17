using System.Collections.Generic;
using BlueBottleIPC.LeagueBroadcast.Entity;

namespace Farsight.Entity;

public sealed class EntityState
{
	private readonly Component?[] _components = new Component?[10];

	public ulong Id { get; }

	public uint SceneId { get; }

	public ComponentTransform? Transform => GetComponent(ComponentKind.Transform)?.Transform;

	public ComponentVisibility? Visibility => GetComponent(ComponentKind.Visibility)?.Visibility;

	internal EntityState(ulong id, uint sceneId, IList<Component>? initialComponents = null)
	{
		Id = id;
		SceneId = sceneId;
		if (initialComponents == null)
		{
			return;
		}
		foreach (Component initialComponent in initialComponents)
		{
			SetComponent(initialComponent);
		}
	}

	public Component? GetComponent(ComponentKind kind)
	{
		return _components[(uint)kind];
	}

	internal void SetComponent(Component component)
	{
		int num = (int)(component.Kind - 1);
		if (num >= 0 && num < _components.Length)
		{
			_components[num] = component;
		}
	}

	internal bool RemoveComponent(ComponentKind kind)
	{
		if (kind <= ComponentKind.Visibility)
		{
			return false;
		}
		_components[(uint)kind] = null;
		return true;
	}

	public IEnumerable<Component> GetAllComponents()
	{
		Component?[] components = _components;
		for (int i = 0; i < components.Length; i++)
		{
			Component? component = components[i];
			if (component.HasValue)
			{
				yield return component.Value;
			}
		}
	}
}
