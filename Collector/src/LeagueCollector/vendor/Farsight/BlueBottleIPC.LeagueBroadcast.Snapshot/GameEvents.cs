using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;

namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

[FlatBufferTable(BuildSerializer = false)]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Snapshot.GameEvents")]
public class GameEvents
{
	[FlatBufferItem(0)]
	public virtual IList<DeathEvent>? DeathEvents { get; set; }

	[FlatBufferItem(1)]
	public virtual IList<DamageDealtEvent>? DamageDealtEvents { get; set; }

	[FlatBufferItem(2)]
	public virtual IList<NotificationEvent>? NotificationEvents { get; set; }

	[FlatBufferItem(3)]
	public virtual IList<InhibitorKillEvent>? InhibitorKillEvents { get; set; }

	[FlatBufferItem(4)]
	public virtual IList<FirstBloodEvent>? FirstBloodEvents { get; set; }

	[FlatBufferItem(5)]
	public virtual IList<TurretKillEvent>? TurretKillEvents { get; set; }

	[FlatBufferItem(6)]
	public virtual IList<TurretPlateDestroyEvent>? TurretPlateDestroyEvents { get; set; }

	[FlatBufferItem(7)]
	public virtual IList<XKillEvent>? XKillEvents { get; set; }

	[FlatBufferItem(8)]
	public virtual IList<AceEvent>? AceEvents { get; set; }

	[FlatBufferItem(9)]
	public virtual IList<ObjectiveStealEvent>? ObjectiveStealEvents { get; set; }

	[FlatBufferItem(10)]
	public virtual IList<HeroDieEvent>? HeroDieEvents { get; set; }

	static GameEvents()
	{
	}

	public GameEvents()
	{
		DeathEvents = null;
		DamageDealtEvents = null;
		NotificationEvents = null;
		InhibitorKillEvents = null;
		FirstBloodEvents = null;
		TurretKillEvents = null;
		TurretPlateDestroyEvents = null;
		XKillEvents = null;
		AceEvents = null;
		ObjectiveStealEvents = null;
		HeroDieEvents = null;
	}

	protected GameEvents(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public GameEvents(GameEvents source)
	{
		DeathEvents = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.DeathEvents);
		DamageDealtEvents = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.DamageDealtEvents);
		NotificationEvents = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.NotificationEvents);
		InhibitorKillEvents = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.InhibitorKillEvents);
		FirstBloodEvents = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.FirstBloodEvents);
		TurretKillEvents = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.TurretKillEvents);
		TurretPlateDestroyEvents = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.TurretPlateDestroyEvents);
		XKillEvents = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.XKillEvents);
		AceEvents = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.AceEvents);
		ObjectiveStealEvents = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.ObjectiveStealEvents);
		HeroDieEvents = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.HeroDieEvents);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
