using System;
using BlueBottleIPC.LeagueBroadcast.Scene;

namespace Farsight.BBObject;

public class EntityChangedEventArgs(ulong entityId, EntityEventKind kind) : EventArgs
{
	public ulong EntityId { get; } = entityId;

	public EntityEventKind Kind { get; } = kind;
}
