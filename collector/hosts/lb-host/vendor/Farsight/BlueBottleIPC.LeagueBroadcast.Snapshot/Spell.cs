using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;

namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

[FlatBufferTable(BuildSerializer = false)]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Snapshot.Spell")]
public class Spell
{
	[FlatBufferItem(0)]
	public virtual string? Name { get; set; }

	[FlatBufferItem(1)]
	public virtual string? Icon { get; set; }

	[FlatBufferItem(2)]
	public virtual float ReadyAt { get; set; }

	[FlatBufferItem(3)]
	public virtual float MaxCooldown { get; set; }

	[FlatBufferItem(4)]
	public virtual float AmmoReadyAt { get; set; }

	[FlatBufferItem(5)]
	public virtual float AmmoCooldown { get; set; }

	[FlatBufferItem(6)]
	public virtual float InitAtTime { get; set; }

	[FlatBufferItem(7)]
	public virtual ushort Index { get; set; }

	[FlatBufferItem(8)]
	public virtual byte Level { get; set; }

	[FlatBufferItem(9)]
	public virtual byte AmmoCount { get; set; }

	[FlatBufferItem(10)]
	public virtual float Cooldown { get; set; }

	[FlatBufferItem(11)]
	public virtual bool IsToggled { get; set; }

	public float GetAbilityCooldown(float gameTime)
	{
		return Cooldown;
	}

	public float GetMaxCooldown()
	{
		if (AmmoReadyAt > 0f && AmmoCount == 0)
		{
			return AmmoCooldown;
		}
		return MaxCooldown;
	}

	static Spell()
	{
	}

	public Spell()
	{
		Name = null;
		Icon = null;
		ReadyAt = 0f;
		MaxCooldown = 0f;
		AmmoReadyAt = 0f;
		AmmoCooldown = 0f;
		InitAtTime = 0f;
		Index = 0;
		Level = 0;
		AmmoCount = 0;
		Cooldown = 0f;
		IsToggled = false;
	}

	protected Spell(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public Spell(Spell source)
	{
		Name = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Name);
		Icon = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Icon);
		ReadyAt = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.ReadyAt);
		MaxCooldown = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.MaxCooldown);
		AmmoReadyAt = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.AmmoReadyAt);
		AmmoCooldown = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.AmmoCooldown);
		InitAtTime = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.InitAtTime);
		Index = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Index);
		Level = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Level);
		AmmoCount = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.AmmoCount);
		Cooldown = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Cooldown);
		IsToggled = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.IsToggled);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
