using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Internal;

namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

[FlatBufferTable(BuildSerializer = false)]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Snapshot.AIHeroClient")]
public class AIHeroClient : ISortableTable<uint>
{
	public int CreepScore => LaneMinionsKilled + NeutralMinionsKilled;

	public int LaneMinionsKilled => LaneMinionKills;

	public int NeutralMinionsKilled => NeutralMinionKills;

	public Spell? Q => Spells?.ElementAt(0);

	public Spell? W => Spells?.ElementAt(1);

	public Spell? E => Spells?.ElementAt(2);

	public Spell? R => Spells?.ElementAt(3);

	public Spell? D => Spells?.ElementAt(4);

	public Spell? F => Spells?.ElementAt(5);

	public string NameAndTagline => Info.Name;

	public string NetworkIdHex => Info.NetworkId.ToString("X");

	public string IndexHex => Info.Index.ToString("X");

	public float TotalAttackDamage
	{
		get
		{
			CharacterStats characterStats = CharacterStats;
			if (characterStats == null)
			{
				return 0f;
			}
			return NanToZero(characterStats.BaseAttackDamage) + NanToZero(characterStats.FlatPhysicalDamageMod);
		}
	}

	public float TotalAbilityPower
	{
		get
		{
			CharacterStats characterStats = CharacterStats;
			if (characterStats == null)
			{
				return 0f;
			}
			return NanToZero(characterStats.FlatMagicDamageMod);
		}
	}

	[FlatBufferItem(0, Required = true)]
	[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "required", "0")]
	public virtual required ObjectInfo Info { get; set; }

	[FlatBufferItem(1, Required = true)]
	[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "required", "0")]
	public virtual required AIClient Common { get; set; }

	[FlatBufferItem(2, Key = true)]
	[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "key", "0")]
	public virtual uint HeroIndex { get; set; }

	[FlatBufferItem(3)]
	public virtual float RespawnTime { get; set; }

	[FlatBufferItem(4)]
	public virtual float Gold { get; set; }

	[FlatBufferItem(5)]
	public virtual float TotalGold { get; set; }

	[FlatBufferItem(6)]
	public virtual float GoldGivenOnDeath { get; set; }

	[FlatBufferItem(7)]
	public virtual float Experience { get; set; }

	[FlatBufferItem(8)]
	public virtual float Resource { get; set; }

	[FlatBufferItem(9)]
	public virtual float MaxResource { get; set; }

	[FlatBufferItem(10)]
	public virtual byte ResourceType { get; set; }

	[FlatBufferItem(11)]
	public virtual float VisionScore { get; set; }

	[FlatBufferItem(12)]
	public virtual IList<Spell>? Spells { get; set; }

	[FlatBufferItem(13)]
	public virtual IList<Item>? Items { get; set; }

	[FlatBufferItem(14)]
	public virtual IList<Perk>? Perks { get; set; }

	[FlatBufferItem(15)]
	public virtual IList<Bone>? Bones { get; set; }

	[FlatBufferItem(16)]
	public virtual CharacterStats? CharacterStats { get; set; }

	[FlatBufferItem(17)]
	public virtual int LaneMinionKills { get; set; }

	[FlatBufferItem(18)]
	public virtual int NeutralMinionKills { get; set; }

	[FlatBufferItem(19)]
	public virtual int Kills { get; set; }

	[FlatBufferItem(20)]
	public virtual int Deaths { get; set; }

	[FlatBufferItem(21)]
	public virtual int Assists { get; set; }

	private static float NanToZero(float value)
	{
		if (!float.IsNaN(value))
		{
			return value;
		}
		return 0f;
	}

	static AIHeroClient()
	{
		SortedVectorHelpers.RegisterKeyLookup((AIHeroClient x) => x.HeroIndex, 2);
	}

	public AIHeroClient()
	{
		HeroIndex = 0u;
		RespawnTime = 0f;
		Gold = 0f;
		TotalGold = 0f;
		GoldGivenOnDeath = 0f;
		Experience = 0f;
		Resource = 0f;
		MaxResource = 0f;
		ResourceType = 0;
		VisionScore = 0f;
		Spells = null;
		Items = null;
		Perks = null;
		Bones = null;
		CharacterStats = null;
		LaneMinionKills = 0;
		NeutralMinionKills = 0;
		Kills = 0;
		Deaths = 0;
		Assists = 0;
	}

	protected AIHeroClient(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public AIHeroClient(AIHeroClient source)
	{
		Info = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Info);
		Common = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Common);
		HeroIndex = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.HeroIndex);
		RespawnTime = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.RespawnTime);
		Gold = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Gold);
		TotalGold = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.TotalGold);
		GoldGivenOnDeath = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.GoldGivenOnDeath);
		Experience = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Experience);
		Resource = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Resource);
		MaxResource = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.MaxResource);
		ResourceType = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.ResourceType);
		VisionScore = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.VisionScore);
		Spells = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Spells);
		Items = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Items);
		Perks = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Perks);
		Bones = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Bones);
		CharacterStats = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.CharacterStats);
		LaneMinionKills = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.LaneMinionKills);
		NeutralMinionKills = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.NeutralMinionKills);
		Kills = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Kills);
		Deaths = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Deaths);
		Assists = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Assists);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
