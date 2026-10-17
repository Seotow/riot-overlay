using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;

namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

[FlatBufferTable(BuildSerializer = false)]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Snapshot.CharacterStats")]
public class CharacterStats
{
	[FlatBufferItem(0)]
	public virtual float AttackSpeedMod { get; set; }

	[FlatBufferItem(1)]
	public virtual float PercentAttackSpeedMod { get; set; }

	[FlatBufferItem(2)]
	public virtual float PercentMultiplicativeAttackSpeedMod { get; set; }

	[FlatBufferItem(3)]
	public virtual float BaseAttackDamage { get; set; }

	[FlatBufferItem(4)]
	public virtual float FlatPhysicalDamageMod { get; set; }

	[FlatBufferItem(5)]
	public virtual float PercentPhysicalDamageMod { get; set; }

	[FlatBufferItem(6)]
	public virtual float Crit { get; set; }

	[FlatBufferItem(7)]
	public virtual float CritDamageMultiplier { get; set; }

	[FlatBufferItem(8)]
	public virtual float AttackRange { get; set; }

	[FlatBufferItem(9)]
	public virtual float FlatMagicDamageMod { get; set; }

	[FlatBufferItem(10)]
	public virtual float PercentMagicDamageMod { get; set; }

	[FlatBufferItem(11)]
	public virtual float AbilityHasteMod { get; set; }

	[FlatBufferItem(12)]
	public virtual float PhysicalLethality { get; set; }

	[FlatBufferItem(13)]
	public virtual float FlatArmorPenetration { get; set; }

	[FlatBufferItem(14)]
	public virtual float PercentArmorPenetration { get; set; }

	[FlatBufferItem(15)]
	public virtual float PercentBonusArmorPenetration { get; set; }

	[FlatBufferItem(16)]
	public virtual float MagicLethality { get; set; }

	[FlatBufferItem(17)]
	public virtual float FlatMagicPenetration { get; set; }

	[FlatBufferItem(18)]
	public virtual float PercentMagicPenetration { get; set; }

	[FlatBufferItem(19)]
	public virtual float PercentBonusMagicPenetration { get; set; }

	[FlatBufferItem(20)]
	public virtual float PercentLifeStealMod { get; set; }

	[FlatBufferItem(21)]
	public virtual float PercentSpellVampMod { get; set; }

	[FlatBufferItem(22)]
	public virtual float PercentPhysicalVamp { get; set; }

	[FlatBufferItem(23)]
	public virtual float PercentOmnivampMod { get; set; }

	[FlatBufferItem(24)]
	public virtual float Armor { get; set; }

	[FlatBufferItem(25)]
	public virtual float BonusArmor { get; set; }

	[FlatBufferItem(26)]
	public virtual float SpellBlock { get; set; }

	[FlatBufferItem(27)]
	public virtual float BonusSpellBlock { get; set; }

	[FlatBufferItem(28)]
	public virtual float FlatMagicReduction { get; set; }

	[FlatBufferItem(29)]
	public virtual float PercentMagicReduction { get; set; }

	[FlatBufferItem(30)]
	public virtual float HpRegenRate { get; set; }

	[FlatBufferItem(31)]
	public virtual float ParRegenRate { get; set; }

	[FlatBufferItem(32)]
	public virtual float PercentCcReduction { get; set; }

	static CharacterStats()
	{
	}

	public CharacterStats()
	{
		AttackSpeedMod = 0f;
		PercentAttackSpeedMod = 0f;
		PercentMultiplicativeAttackSpeedMod = 0f;
		BaseAttackDamage = 0f;
		FlatPhysicalDamageMod = 0f;
		PercentPhysicalDamageMod = 0f;
		Crit = 0f;
		CritDamageMultiplier = 0f;
		AttackRange = 0f;
		FlatMagicDamageMod = 0f;
		PercentMagicDamageMod = 0f;
		AbilityHasteMod = 0f;
		PhysicalLethality = 0f;
		FlatArmorPenetration = 0f;
		PercentArmorPenetration = 0f;
		PercentBonusArmorPenetration = 0f;
		MagicLethality = 0f;
		FlatMagicPenetration = 0f;
		PercentMagicPenetration = 0f;
		PercentBonusMagicPenetration = 0f;
		PercentLifeStealMod = 0f;
		PercentSpellVampMod = 0f;
		PercentPhysicalVamp = 0f;
		PercentOmnivampMod = 0f;
		Armor = 0f;
		BonusArmor = 0f;
		SpellBlock = 0f;
		BonusSpellBlock = 0f;
		FlatMagicReduction = 0f;
		PercentMagicReduction = 0f;
		HpRegenRate = 0f;
		ParRegenRate = 0f;
		PercentCcReduction = 0f;
	}

	protected CharacterStats(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public CharacterStats(CharacterStats source)
	{
		AttackSpeedMod = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.AttackSpeedMod);
		PercentAttackSpeedMod = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.PercentAttackSpeedMod);
		PercentMultiplicativeAttackSpeedMod = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.PercentMultiplicativeAttackSpeedMod);
		BaseAttackDamage = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.BaseAttackDamage);
		FlatPhysicalDamageMod = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.FlatPhysicalDamageMod);
		PercentPhysicalDamageMod = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.PercentPhysicalDamageMod);
		Crit = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Crit);
		CritDamageMultiplier = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.CritDamageMultiplier);
		AttackRange = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.AttackRange);
		FlatMagicDamageMod = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.FlatMagicDamageMod);
		PercentMagicDamageMod = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.PercentMagicDamageMod);
		AbilityHasteMod = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.AbilityHasteMod);
		PhysicalLethality = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.PhysicalLethality);
		FlatArmorPenetration = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.FlatArmorPenetration);
		PercentArmorPenetration = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.PercentArmorPenetration);
		PercentBonusArmorPenetration = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.PercentBonusArmorPenetration);
		MagicLethality = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.MagicLethality);
		FlatMagicPenetration = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.FlatMagicPenetration);
		PercentMagicPenetration = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.PercentMagicPenetration);
		PercentBonusMagicPenetration = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.PercentBonusMagicPenetration);
		PercentLifeStealMod = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.PercentLifeStealMod);
		PercentSpellVampMod = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.PercentSpellVampMod);
		PercentPhysicalVamp = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.PercentPhysicalVamp);
		PercentOmnivampMod = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.PercentOmnivampMod);
		Armor = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Armor);
		BonusArmor = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.BonusArmor);
		SpellBlock = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.SpellBlock);
		BonusSpellBlock = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.BonusSpellBlock);
		FlatMagicReduction = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.FlatMagicReduction);
		PercentMagicReduction = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.PercentMagicReduction);
		HpRegenRate = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.HpRegenRate);
		ParRegenRate = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.ParRegenRate);
		PercentCcReduction = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.PercentCcReduction);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
