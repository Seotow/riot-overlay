using System;
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
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Snapshot.AIClient")]
public class AIClient
{
	public bool IsAlive => Status.HasFlag(AIClientStatus.IsAlive);

	public bool IsZombie => Status.HasFlag(AIClientStatus.IsZombie);

	public bool IsRecalling => Status.HasFlag(AIClientStatus.IsRecalling);

	public bool IsTargetable => Status.HasFlag(AIClientStatus.IsTargetable);

	[FlatBufferItem(0)]
	public virtual string? Identifier { get; set; }

	[FlatBufferItem(1)]
	public virtual string? CurrentAttack { get; set; }

	[FlatBufferItem(2)]
	public virtual AIClientStatus Status { get; set; }

	[FlatBufferItem(3)]
	public virtual float Health { get; set; }

	[FlatBufferItem(4)]
	public virtual float MaxHealth { get; set; }

	[FlatBufferItem(5)]
	public virtual float Armor { get; set; }

	[FlatBufferItem(6)]
	public virtual float MagicResist { get; set; }

	[FlatBufferItem(7)]
	public virtual uint Level { get; set; }

	[FlatBufferItem(8)]
	public virtual float AttackSpeedMultiplier { get; set; }

	[FlatBufferItem(9)]
	public virtual float MovementSpeed { get; set; }

	[FlatBufferItem(10)]
	public virtual DataStack? DataStack { get; set; }

	[FlatBufferItem(11)]
	public virtual IList<Buff>? Buffs { get; set; }

	[FlatBufferItem(12)]
	public virtual IList<Animation>? Animations { get; set; }

	[FlatBufferItem(13)]
	public virtual uint SubmeshVisiblityMask { get; set; }

	[FlatBufferItem(14)]
	public virtual float AttackSpeedBonus { get; set; }

	[FlatBufferItem(15)]
	public virtual AnimationState? AnimationState { get; set; }

	public bool HasBuff(string buffName)
	{
		if (Buffs == null)
		{
			return false;
		}
		foreach (Buff buff in Buffs)
		{
			string? name = buff.Name;
			if (name != null && name.Equals(buffName, StringComparison.OrdinalIgnoreCase))
			{
				return true;
			}
		}
		return false;
	}

	public bool TryGetBuff(string buffName, out Buff? buff)
	{
		if (Buffs == null)
		{
			buff = null;
			return false;
		}
		foreach (Buff buff2 in Buffs)
		{
			string? name = buff2.Name;
			if (name != null && name.Equals(buffName, StringComparison.OrdinalIgnoreCase))
			{
				buff = buff2;
				return true;
			}
		}
		buff = null;
		return false;
	}

	public bool TryGetBuff(string buffName, float gameTime, out Buff? buff)
	{
		if (Buffs == null)
		{
			buff = null;
			return false;
		}
		foreach (Buff buff2 in Buffs)
		{
			string? name = buff2.Name;
			if (name != null && name.Equals(buffName, StringComparison.OrdinalIgnoreCase) && (float.IsNaN(buff2.StartTime) || buff2.StartTime < gameTime) && buff2.EndTime > gameTime)
			{
				buff = buff2;
				return true;
			}
		}
		buff = null;
		return false;
	}

	public Buff? GetBuff(string buffName)
	{
		if (Buffs == null)
		{
			return null;
		}
		foreach (Buff buff in Buffs)
		{
			string? name = buff.Name;
			if (name != null && name.Equals(buffName, StringComparison.OrdinalIgnoreCase))
			{
				return buff;
			}
		}
		return null;
	}

	static AIClient()
	{
	}

	public AIClient()
	{
		Identifier = null;
		CurrentAttack = null;
		Status = (AIClientStatus)0;
		Health = 0f;
		MaxHealth = 0f;
		Armor = 0f;
		MagicResist = 0f;
		Level = 0u;
		AttackSpeedMultiplier = 0f;
		MovementSpeed = 0f;
		DataStack = null;
		Buffs = null;
		Animations = null;
		SubmeshVisiblityMask = 0u;
		AttackSpeedBonus = 0f;
		AnimationState = null;
	}

	protected AIClient(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public AIClient(AIClient source)
	{
		Identifier = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Identifier);
		CurrentAttack = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.CurrentAttack);
		Status = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Status);
		Health = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Health);
		MaxHealth = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.MaxHealth);
		Armor = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Armor);
		MagicResist = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.MagicResist);
		Level = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Level);
		AttackSpeedMultiplier = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.AttackSpeedMultiplier);
		MovementSpeed = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.MovementSpeed);
		DataStack = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.DataStack);
		Buffs = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Buffs);
		Animations = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Animations);
		SubmeshVisiblityMask = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.SubmeshVisiblityMask);
		AttackSpeedBonus = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.AttackSpeedBonus);
		AnimationState = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.AnimationState);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
