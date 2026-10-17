using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Farsight.Utils.Json;

namespace Farsight.Web;

public static class CommunityDragon
{
	public class CDragonChampionData
	{
		[JsonPropertyName("id")]
		public int Id { get; set; }

		[JsonPropertyName("alias")]
		public string Alias { get; set; } = string.Empty;

		[JsonPropertyName("name")]
		public string Name { get; set; } = string.Empty;

		[JsonPropertyName("splashImg")]
		public string? SplashImg { get; set; }

		[JsonPropertyName("splashCenteredImg")]
		public string? SplashCenteredImg { get; set; }

		[JsonPropertyName("loadingImg")]
		public string? LoadingImg { get; set; }

		[JsonPropertyName("squareImg")]
		public string? SquareImg { get; set; }
	}

	public class _0
	{
		[JsonPropertyName("__type")]
		public string? Type { get; set; }
	}

	public class _1
	{
		[JsonPropertyName("__type")]
		public string? Type { get; set; }
	}

	public class _2
	{
		[JsonPropertyName("__type")]
		public string? Type { get; set; }
	}

	public class BasicAttack
	{
		[JsonPropertyName("mAttackDelayCastOffsetPercent")]
		public float? MAttackDelayCastOffsetPercent { get; set; }

		[JsonPropertyName("mAttackProbability")]
		public float? MAttackProbability { get; set; }

		[JsonPropertyName("__type")]
		public string? Type { get; set; }
	}

	public class CharacterToolData
	{
		[JsonPropertyName("mapAIPresence")]
		public MapAIPresence? MapAIPresence { get; set; }

		[JsonPropertyName("passiveData")]
		public List<PassiveDatum> PassiveData { get; } = new List<PassiveDatum>();

		[JsonPropertyName("searchTags")]
		public string? SearchTags { get; set; }

		[JsonPropertyName("championId")]
		public float? ChampionId { get; set; }

		[JsonPropertyName("magicRank")]
		public float? MagicRank { get; set; }

		[JsonPropertyName("LevelSpellEffectiveness")]
		public float? LevelSpellEffectiveness { get; set; }

		[JsonPropertyName("difficultyRank")]
		public float? DifficultyRank { get; set; }

		[JsonPropertyName("description")]
		public string? Description { get; set; }

		[JsonPropertyName("defenseRank")]
		public float? DefenseRank { get; set; }

		[JsonPropertyName("classification")]
		public string? Classification { get; set; }

		[JsonPropertyName("ChasingAttackRangePercent")]
		public float? ChasingAttackRangePercent { get; set; }

		[JsonPropertyName("attackRank")]
		public float? AttackRank { get; set; }

		[JsonPropertyName("__type")]
		public string? Type { get; set; }
	}

	public class CritAttack
	{
		[JsonPropertyName("mAttackName")]
		public string? MAttackName { get; set; }

		[JsonPropertyName("__type")]
		public string? Type { get; set; }
	}

	public class ExtraAttack
	{
		[JsonPropertyName("mAttackName")]
		public string? MAttackName { get; set; }

		[JsonPropertyName("__type")]
		public string? Type { get; set; }
	}

	public class MapAIPresence
	{
		[JsonPropertyName("0")]
		public _0? _0 { get; set; }

		[JsonPropertyName("1")]
		public _1? _1 { get; set; }

		[JsonPropertyName("2")]
		public _2? _2 { get; set; }
	}

	public class MCharacterPassiveBuff
	{
		[JsonPropertyName("mParentPassiveBuff")]
		public string? MParentPassiveBuff { get; set; }

		[JsonPropertyName("mComponentBuffs")]
		public List<string> MComponentBuffs { get; } = new List<string>();

		[JsonPropertyName("__type")]
		public string? Type { get; set; }

		[JsonPropertyName("mAllowOnClones")]
		public bool? MAllowOnClones { get; set; }
	}

	public class PassiveDatum
	{
		[JsonPropertyName("name")]
		public string? Name { get; set; }

		[JsonPropertyName("__type")]
		public string? Type { get; set; }
	}

	public class PrimaryAbilityResource
	{
		[JsonPropertyName("arType")]
		public float? ArType { get; set; }

		[JsonPropertyName("arBase")]
		public float? ArBase { get; set; }

		[JsonPropertyName("arPerLevel")]
		public float? ArPerLevel { get; set; }

		[JsonPropertyName("arBaseStaticRegen")]
		public float? ArBaseStaticRegen { get; set; }

		[JsonPropertyName("arRegenPerLevel")]
		public float? ArRegenPerLevel { get; set; }

		[JsonPropertyName("__type")]
		public string? Type { get; set; }
	}

	public class CDragonChampionInfo
	{
		[JsonPropertyName("mCharacterName")]
		public string? MCharacterName { get; set; }

		[JsonPropertyName("baseHP")]
		public float? BaseHP { get; set; }

		[JsonPropertyName("hpPerLevel")]
		public float? HpPerLevel { get; set; }

		[JsonPropertyName("baseStaticHPRegen")]
		public float? BaseStaticHPRegen { get; set; }

		[JsonPropertyName("hpRegenPerLevel")]
		public float? HpRegenPerLevel { get; set; }

		[JsonPropertyName("healthBarHeight")]
		public float? HealthBarHeight { get; set; }

		[JsonPropertyName("primaryAbilityResource")]
		public PrimaryAbilityResource? PrimaryAbilityResource { get; set; }

		[JsonPropertyName("baseDamage")]
		public float? BaseDamage { get; set; }

		[JsonPropertyName("damagePerLevel")]
		public float? DamagePerLevel { get; set; }

		[JsonPropertyName("baseArmor")]
		public float? BaseArmor { get; set; }

		[JsonPropertyName("armorPerLevel")]
		public float? ArmorPerLevel { get; set; }

		[JsonPropertyName("baseSpellBlock")]
		public float? BaseSpellBlock { get; set; }

		[JsonPropertyName("spellBlockPerLevel")]
		public float? SpellBlockPerLevel { get; set; }

		[JsonPropertyName("baseMoveSpeed")]
		public float? BaseMoveSpeed { get; set; }

		[JsonPropertyName("attackRange")]
		public float? AttackRange { get; set; }

		[JsonPropertyName("attackSpeed")]
		public float? AttackSpeed { get; set; }

		[JsonPropertyName("attackSpeedRatio")]
		public float? AttackSpeedRatio { get; set; }

		[JsonPropertyName("attackSpeedPerLevel")]
		public float? AttackSpeedPerLevel { get; set; }

		[JsonPropertyName("mAdaptiveForceToAbilityPowerWeight")]
		public float? MAdaptiveForceToAbilityPowerWeight { get; set; }

		[JsonPropertyName("acquisitionRange")]
		public float? AcquisitionRange { get; set; }

		[JsonPropertyName("basicAttack")]
		public BasicAttack? BasicAttack { get; set; }

		[JsonPropertyName("extraAttacks")]
		public List<ExtraAttack> ExtraAttacks { get; } = new List<ExtraAttack>();

		[JsonPropertyName("critAttacks")]
		public List<CritAttack> CritAttacks { get; } = new List<CritAttack>();

		[JsonPropertyName("spellNames")]
		public List<string> SpellNames { get; } = new List<string>();

		[JsonPropertyName("extraSpells")]
		public List<string> ExtraSpells { get; } = new List<string>();

		[JsonPropertyName("mAbilities")]
		public List<string> MAbilities { get; } = new List<string>();

		[JsonPropertyName("passiveName")]
		public string? PassiveName { get; set; }

		[JsonPropertyName("passiveLuaName")]
		public string? PassiveLuaName { get; set; }

		[JsonPropertyName("passiveToolTip")]
		public string? PassiveToolTip { get; set; }

		[JsonPropertyName("passiveSpell")]
		public string? PassiveSpell { get; set; }

		[JsonPropertyName("passive1IconName")]
		public string? Passive1IconName { get; set; }

		[JsonPropertyName("name")]
		public string? Name { get; set; }

		[JsonPropertyName("selectionHeight")]
		public float? SelectionHeight { get; set; }

		[JsonPropertyName("selectionRadius")]
		public float? SelectionRadius { get; set; }

		[JsonPropertyName("pathfindingCollisionRadius")]
		public float? PathfindingCollisionRadius { get; set; }

		[JsonPropertyName("overrideGameplayCollisionRadius")]
		public float? OverrideGameplayCollisionRadius { get; set; }

		[JsonPropertyName("unitTagsString")]
		public string? UnitTagsstring { get; set; }

		[JsonPropertyName("characterToolData")]
		public CharacterToolData? CharacterToolData { get; set; }

		[JsonPropertyName("platformEnabled")]
		public bool? PlatformEnabled { get; set; }

		[JsonPropertyName("purchaseIdentities")]
		public List<string> PurchaseIdentities { get; } = new List<string>();

		[JsonPropertyName("mPreferredPerkStyle")]
		public string? MPreferredPerkStyle { get; set; }

		[JsonPropertyName("mCharacterPassiveSpell")]
		public string? MCharacterPassiveSpell { get; set; }

		[JsonPropertyName("mCharacterPassiveBuffs")]
		public List<MCharacterPassiveBuff> MCharacterPassiveBuffs { get; } = new List<MCharacterPassiveBuff>();

		[JsonPropertyName("__type")]
		public string? Type { get; set; }
	}

	public class CDragonTFTCompleteData
	{
		[JsonPropertyName("items")]
		public List<CDragonTFTItem> Items { get; set; } = new List<CDragonTFTItem>();

		[JsonPropertyName("sets")]
		public Dictionary<int, CDragonTFTSetData> Sets { get; set; } = new Dictionary<int, CDragonTFTSetData>();
	}

	public class CDragonTFTSetData
	{
		[JsonPropertyName("champions")]
		public List<CDragonTFTUnitData> Champions { get; set; } = new List<CDragonTFTUnitData>();

		[JsonPropertyName("name")]
		public string? Name { get; set; } = string.Empty;
	}

	public class CDragonTFTItem
	{
		[JsonPropertyName("apiName")]
		public string? ApiName { get; set; } = string.Empty;

		[JsonPropertyName("associatedTraits")]
		public List<string> AssociatedTraits { get; set; } = new List<string>();

		[JsonPropertyName("buildsInto")]
		public List<string> Composition { get; set; } = new List<string>();

		[JsonPropertyName("desc")]
		public string? Description { get; set; } = string.Empty;

		[JsonPropertyName("effects")]
		[JsonConverter(typeof(EffectJsonConverter))]
		public Dictionary<string, float?> Effects { get; set; } = new Dictionary<string, float?>();

		[JsonPropertyName("from")]
		public string? From { get; set; }

		[JsonPropertyName("icon")]
		public string? Icon { get; set; } = string.Empty;

		[JsonPropertyName("id")]
		public List<string>? IncompatibleTraits { get; set; }

		[JsonPropertyName("name")]
		public string? Name { get; set; } = string.Empty;

		[JsonPropertyName("unique")]
		public bool Unique { get; set; }
	}

	public class CDragonTFTUnitData
	{
		public class TFTUnitAbility
		{
			public class TFTUnitAbilityVariable
			{
				[JsonPropertyName("name")]
				public string? Name { get; set; } = string.Empty;

				[JsonPropertyName("value")]
				public List<float> Values { get; set; } = new List<float>();
			}

			[JsonPropertyName("desc")]
			private string? Description { get; set; } = string.Empty;

			[JsonPropertyName("icon")]
			private string? Icon { get; set; } = string.Empty;

			[JsonPropertyName("name")]
			private string? Name { get; set; } = string.Empty;

			[JsonPropertyName("variables")]
			public List<TFTUnitAbilityVariable> Variables { get; set; } = new List<TFTUnitAbilityVariable>();
		}

		public class TFTUnitStats
		{
			[JsonPropertyName("armor")]
			[JsonConverter(typeof(StringToFloatJsonConverter))]
			public float? Armor { get; set; }

			[JsonPropertyName("attackSpeed")]
			[JsonConverter(typeof(StringToFloatJsonConverter))]
			public float? AttackSpeed { get; set; }

			[JsonPropertyName("critChance")]
			[JsonConverter(typeof(StringToFloatJsonConverter))]
			public float? CritChance { get; set; }

			[JsonPropertyName("critMultiplier")]
			[JsonConverter(typeof(StringToFloatJsonConverter))]
			public float? CritMultiplier { get; set; }

			[JsonPropertyName("damage")]
			[JsonConverter(typeof(StringToFloatJsonConverter))]
			public float? Damage { get; set; }

			[JsonPropertyName("hp")]
			[JsonConverter(typeof(StringToFloatJsonConverter))]
			public float? Health { get; set; }

			[JsonPropertyName("initialMana")]
			[JsonConverter(typeof(StringToFloatJsonConverter))]
			public float? InitialMana { get; set; }

			[JsonPropertyName("magicResist")]
			[JsonConverter(typeof(StringToFloatJsonConverter))]
			public float? MagicResist { get; set; }

			[JsonPropertyName("mana")]
			[JsonConverter(typeof(StringToFloatJsonConverter))]
			public float? Mana { get; set; }

			[JsonPropertyName("range")]
			[JsonConverter(typeof(StringToFloatJsonConverter))]
			public float? Range { get; set; }
		}

		[JsonPropertyName("ability")]
		public TFTUnitAbility Ability { get; set; } = new TFTUnitAbility();

		[JsonPropertyName("apiName")]
		public string? ApiName { get; set; }

		[JsonPropertyName("characterName")]
		public string? CharacterName { get; set; }

		[JsonPropertyName("cost")]
		public int Cost { get; set; }

		[JsonPropertyName("icon")]
		public string? Icon { get; set; }

		[JsonPropertyName("name")]
		public string? Name { get; set; }

		[JsonPropertyName("squareIcon")]
		public string? SquareIcon { get; set; }

		[JsonPropertyName("stats")]
		public TFTUnitStats Stats { get; set; } = new TFTUnitStats();

		[JsonPropertyName("tileIcon")]
		public string? TileIcon { get; set; }

		[JsonPropertyName("traits")]
		public List<string> Traits { get; set; } = new List<string>();
	}

	public class EffectJsonConverter : JsonConverter<Dictionary<string, float?>>
	{
		public override Dictionary<string, float?>? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			Dictionary<string, float?> dictionary = new Dictionary<string, float?>();
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName)
				{
					continue;
				}
				string text = reader.GetString();
				if (text != null)
				{
					reader.Read();
					if (reader.TokenType == JsonTokenType.Number)
					{
						dictionary[text] = reader.GetSingle();
					}
					else if (reader.TokenType == JsonTokenType.String)
					{
						dictionary[text] = null;
					}
				}
			}
			return dictionary;
		}

		public override void Write(Utf8JsonWriter writer, Dictionary<string, float?> value, JsonSerializerOptions options)
		{
			throw new NotImplementedException();
		}
	}

	private static readonly Dictionary<string, CDragonChampionInfo> _championInfoCache = new Dictionary<string, CDragonChampionInfo>();

	public static Task<CDragonChampionData[]?> GetChampions()
	{
		return RestRequester.GetAsync<CDragonChampionData[]>("https://raw.communitydragon.org/latest/plugins/rcp-be-lol-game-data/global/default/v1/champion-summary.json");
	}

	public static Task<CDragonTFTCompleteData?> GetTFTData()
	{
		return RestRequester.GetAsync<CDragonTFTCompleteData>("https://raw.communitydragon.org/latest/cdragon/tft/en_us.json");
	}

	public static CDragonChampionInfo? GetChampionInfo(string championIdentifier)
	{
		return GetChampionInfoAsync(championIdentifier).Result;
	}

	public static async Task<CDragonChampionInfo?> GetChampionInfoAsync(string championIdentifier)
	{
		string value = championIdentifier.ToLowerInvariant();
		if (_championInfoCache.TryGetValue(championIdentifier, out CDragonChampionInfo value2))
		{
			return value2;
		}
		JsonDocument jsonDocument = await RestRequester.GetAsync<JsonDocument>($"https://raw.communitydragon.org/latest/game/data/characters/{value}/{value}.bin.json");
		if (jsonDocument == null)
		{
			return null;
		}
		try
		{
			CDragonChampionInfo cDragonChampionInfo = jsonDocument.RootElement.GetProperty("Characters/" + championIdentifier + "/CharacterRecords/Root").Deserialize<CDragonChampionInfo>();
			if (cDragonChampionInfo == null)
			{
				return null;
			}
			_championInfoCache[championIdentifier] = cDragonChampionInfo;
			return cDragonChampionInfo;
		}
		catch (Exception value3)
		{
			Console.WriteLine(value3);
			return null;
		}
	}
}
