using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;

namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

[FlatBufferTable(BuildSerializer = false)]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Snapshot.GameInfo")]
public class GameInfo
{
	private ReadOnlyCollection<AIMinionClient>? _neutralMinions;

	public ReadOnlyCollection<AIMinionClient>? _orderMinions;

	public ReadOnlyCollection<AIMinionClient>? _chaosMinions;

	private ReadOnlyDictionary<uint, AIMinionClient>? _minionMap;

	private bool _dragonScanned;

	private AIMinionClient? _dragon;

	private bool _baronScanned;

	private AIMinionClient? _baron;

	private bool _atakhanScanned;

	private AIMinionClient? _atakhan;

	private bool _riftHeraldScanned;

	private AIMinionClient? _riftHerald;

	private bool _grubsScanned;

	private ReadOnlyCollection<AIMinionClient>? _grubs;

	private bool _upcomingDragonScanned;

	private string? _upcomingDragonType;

	private Dictionary<uint, ObjectInfo>? _networkIdMap;

	private Dictionary<uint, ObjectType>? _objectTypeMap;

	private Dictionary<uint, AIHeroClient>? _heroMap;

	private readonly Lock _extensionLock = new Lock();

	private bool _isInit;

	public ReadOnlyCollection<AIMinionClient> NeutralMinions
	{
		get
		{
			if (_neutralMinions == null)
			{
				_neutralMinions = new ReadOnlyCollection<AIMinionClient>(Minions?.Where((AIMinionClient x) => x.Info.IsNeutral).ToList() ?? new List<AIMinionClient>());
			}
			return _neutralMinions;
		}
	}

	public ReadOnlyCollection<AIMinionClient> OrderMinions
	{
		get
		{
			if (_orderMinions == null)
			{
				_orderMinions = new ReadOnlyCollection<AIMinionClient>(Minions?.Where((AIMinionClient x) => x.Info.Team == 1 && (x.Common.Identifier?.StartsWith("SRU_OrderMinion") ?? false)).ToList() ?? new List<AIMinionClient>());
			}
			return _orderMinions;
		}
	}

	public ReadOnlyCollection<AIMinionClient> ChaosMinions
	{
		get
		{
			if (_chaosMinions == null)
			{
				_chaosMinions = new ReadOnlyCollection<AIMinionClient>(Minions?.Where((AIMinionClient x) => x.Info.Team == 2 && (x.Common.Identifier?.StartsWith("SRU_ChaosMinion") ?? false)).ToList() ?? new List<AIMinionClient>());
			}
			return _chaosMinions;
		}
	}

	public ReadOnlyDictionary<uint, AIMinionClient> MinionMap
	{
		get
		{
			if (_minionMap == null)
			{
				_minionMap = new ReadOnlyDictionary<uint, AIMinionClient>(Minions?.ToDictionary((AIMinionClient m) => m.Info.NetworkId) ?? new Dictionary<uint, AIMinionClient>());
			}
			return _minionMap;
		}
	}

	public ReadOnlyCollection<AIMinionClient> LaneMinions => OrderMinions.Concat(ChaosMinions).ToList().AsReadOnly();

	public AIMinionClient? Dragon
	{
		get
		{
			if ((object)_dragon != null)
			{
				return _dragon;
			}
			if (_dragonScanned)
			{
				return null;
			}
			_dragon = NeutralMinions.FirstOrDefault((AIMinionClient m) => m.Info.Name.StartsWith("sru_dragon_", StringComparison.OrdinalIgnoreCase));
			_dragonScanned = true;
			if ((object)_dragon != null)
			{
				return _dragon;
			}
			return null;
		}
	}

	public AIMinionClient? Baron
	{
		get
		{
			if ((object)_baron != null)
			{
				return _baron;
			}
			if (_baronScanned)
			{
				return null;
			}
			_baron = NeutralMinions.FirstOrDefault((AIMinionClient m) => m.Common.Identifier?.StartsWith("SRU_Baron", StringComparison.OrdinalIgnoreCase) ?? false);
			_baronScanned = true;
			if ((object)_baron != null)
			{
				return _baron;
			}
			return null;
		}
	}

	public AIMinionClient? Atakhan
	{
		get
		{
			if ((object)_atakhan != null)
			{
				return _atakhan;
			}
			if (_atakhanScanned)
			{
				return null;
			}
			_atakhan = NeutralMinions.FirstOrDefault((AIMinionClient m) => m.Common.Identifier?.Equals("SRU_Atakhan", StringComparison.OrdinalIgnoreCase) ?? false);
			_atakhanScanned = true;
			if ((object)_atakhan != null)
			{
				return _atakhan;
			}
			return null;
		}
	}

	public GeneralParticleEmitter? AtakhanArenaMarker => ParticleEmitters?.FirstOrDefault((GeneralParticleEmitter m) => m.Info.Name.Equals("SRU_Atakhan_Crown_Base_Idle", StringComparison.OrdinalIgnoreCase));

	public AIMinionClient? RiftHerald
	{
		get
		{
			if ((object)_riftHerald != null)
			{
				return _riftHerald;
			}
			if (_riftHeraldScanned)
			{
				return null;
			}
			_riftHerald = NeutralMinions.FirstOrDefault((AIMinionClient m) => m.Common.Identifier?.Equals("SRU_RiftHerald", StringComparison.OrdinalIgnoreCase) ?? false);
			_riftHeraldScanned = true;
			if ((object)_riftHerald != null)
			{
				return _riftHerald;
			}
			return null;
		}
	}

	public ReadOnlyCollection<AIMinionClient>? Grubs
	{
		get
		{
			if (_grubs != null)
			{
				return _grubs;
			}
			if (_grubsScanned)
			{
				return null;
			}
			_grubs = NeutralMinions.Where((AIMinionClient m) => m.Common.Identifier?.Equals("SRU_Horde", StringComparison.OrdinalIgnoreCase) ?? false).ToList().AsReadOnly();
			_grubsScanned = true;
			if (_grubs.Count > 0)
			{
				return _grubs;
			}
			return null;
		}
	}

	public string? UpcomingDragonType
	{
		get
		{
			if (_upcomingDragonType != null)
			{
				return _upcomingDragonType;
			}
			if (ParticleEmitters == null)
			{
				return null;
			}
			if (_upcomingDragonScanned)
			{
				return null;
			}
			GeneralParticleEmitter generalParticleEmitter = ParticleEmitters.FirstOrDefault((GeneralParticleEmitter x) => x.Info.Name.StartsWith("Dragon_Indicator", StringComparison.OrdinalIgnoreCase) || x.Info.Name.StartsWith("DATA/Particles/Dragon_Indicator", StringComparison.OrdinalIgnoreCase));
			_upcomingDragonScanned = true;
			if (generalParticleEmitter == null)
			{
				return null;
			}
			ReadOnlySpan<char> span = generalParticleEmitter.Info.Name;
			int num = span.IndexOf("Dragon_Indicator_", StringComparison.OrdinalIgnoreCase);
			if (num < 0)
			{
				return null;
			}
			int num2 = num + "Dragon_Indicator_".Length;
			if (num2 >= span.Length)
			{
				return null;
			}
			ReadOnlySpan<char> span2 = span.Slice(num2);
			int num3 = span2.IndexOf(".troy", StringComparison.OrdinalIgnoreCase);
			if (num3 >= 0)
			{
				span2 = span2.Slice(0, num3);
			}
			if (span2.IsEmpty)
			{
				return null;
			}
			_upcomingDragonType = span2.ToString();
			return _upcomingDragonType;
		}
	}

	private Dictionary<uint, ObjectInfo> NetworkIdMap
	{
		get
		{
			if (_networkIdMap == null)
			{
				InitExtensionData();
			}
			if (_networkIdMap == null)
			{
				throw new InvalidOperationException("NetworkIdMap is null, concurrency issue occured!");
			}
			return _networkIdMap;
		}
	}

	private Dictionary<uint, ObjectType> ObjectTypeMap
	{
		get
		{
			if (_objectTypeMap == null)
			{
				InitExtensionData();
			}
			return _objectTypeMap;
		}
	}

	public Dictionary<uint, AIHeroClient> HeroMap
	{
		get
		{
			if (_heroMap == null)
			{
				_heroMap = Heroes?.ToDictionary((AIHeroClient h) => h.Info.NetworkId) ?? new Dictionary<uint, AIHeroClient>();
			}
			return _heroMap;
		}
	}

	[FlatBufferItem(0)]
	public virtual float GameTime { get; set; }

	[FlatBufferItem(1)]
	public virtual float PlaybackSpeed { get; set; }

	[FlatBufferItem(2)]
	public virtual ulong UtcTime { get; set; }

	[FlatBufferItem(3)]
	public virtual Camera? Camera { get; set; }

	[FlatBufferItem(4)]
	public virtual IList<TeamStats>? TeamStats { get; set; }

	[FlatBufferItem(5)]
	public virtual GameEvents? GameEvents { get; set; }

	[FlatBufferItem(6)]
	public virtual IList<AIHeroClient>? Heroes { get; set; }

	[FlatBufferItem(7)]
	public virtual IList<AIMinionClient>? Minions { get; set; }

	[FlatBufferItem(8)]
	public virtual IList<AITurretClient>? Turrets { get; set; }

	[FlatBufferItem(9)]
	public virtual IList<Building>? BarracksDampeners { get; set; }

	[FlatBufferItem(10)]
	public virtual IList<Building>? Hqs { get; set; }

	[FlatBufferItem(11)]
	public virtual IList<Missile>? Missiles { get; set; }

	[FlatBufferItem(12)]
	public virtual IList<GeneralParticleEmitter>? ParticleEmitters { get; set; }

	[FlatBufferItem(13)]
	public virtual IList<MiscObjects>? Misc { get; set; }

	[FlatBufferItem(14)]
	public virtual string? GameId { get; set; }

	public bool IsObjectChampion(ObjectInfo info)
	{
		return Heroes?.Any((AIHeroClient h) => h.Info.Index == info.Index) ?? false;
	}

	public bool TryGetObjectInfoByNetworkId(uint networkId, out ObjectInfo? info)
	{
		try
		{
			return NetworkIdMap.TryGetValue(networkId, out info);
		}
		catch (InvalidOperationException)
		{
			info = null;
			return false;
		}
	}

	public bool TryGetObjectTypeByNetworkId(uint networkId, out ObjectType type)
	{
		return ObjectTypeMap.TryGetValue(networkId, out type);
	}

	public void InitExtensionData()
	{
		using (_extensionLock.EnterScope())
		{
			if (_isInit)
			{
				return;
			}
			_isInit = true;
			_networkIdMap = new Dictionary<uint, ObjectInfo>();
			_objectTypeMap = new Dictionary<uint, ObjectType>();
			foreach (AIMinionClient item in Minions ?? new List<AIMinionClient>())
			{
				_networkIdMap[item.Info.NetworkId] = item.Info;
				_objectTypeMap[item.Info.NetworkId] = ObjectType.AIMinionClient;
			}
			foreach (AIHeroClient item2 in Heroes ?? new List<AIHeroClient>())
			{
				_networkIdMap[item2.Info.NetworkId] = item2.Info;
				_objectTypeMap[item2.Info.NetworkId] = ObjectType.AIHeroClient;
			}
			foreach (AITurretClient item3 in Turrets ?? new List<AITurretClient>())
			{
				_networkIdMap[item3.Info.NetworkId] = item3.Info;
				_objectTypeMap[item3.Info.NetworkId] = ObjectType.AITurretClient;
			}
			foreach (Building item4 in Hqs ?? new List<Building>())
			{
				_networkIdMap[item4.Info.NetworkId] = item4.Info;
				_objectTypeMap[item4.Info.NetworkId] = ObjectType.HQ;
			}
			foreach (Missile item5 in Missiles ?? new List<Missile>())
			{
				_networkIdMap[item5.Info.NetworkId] = item5.Info;
				_objectTypeMap[item5.Info.NetworkId] = ObjectType.MissileClient;
			}
			foreach (Building item6 in BarracksDampeners ?? new List<Building>())
			{
				_networkIdMap[item6.Info.NetworkId] = item6.Info;
				_objectTypeMap[item6.Info.NetworkId] = ObjectType.BarracksDampener;
			}
		}
	}

	static GameInfo()
	{
	}

	public GameInfo()
	{
		GameTime = 0f;
		PlaybackSpeed = 0f;
		UtcTime = 0uL;
		Camera = null;
		TeamStats = null;
		GameEvents = null;
		Heroes = null;
		Minions = null;
		Turrets = null;
		BarracksDampeners = null;
		Hqs = null;
		Missiles = null;
		ParticleEmitters = null;
		Misc = null;
		GameId = null;
	}

	protected GameInfo(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public GameInfo(GameInfo source)
	{
		GameTime = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.GameTime);
		PlaybackSpeed = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.PlaybackSpeed);
		UtcTime = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.UtcTime);
		Camera = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Camera);
		TeamStats = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.TeamStats);
		GameEvents = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.GameEvents);
		Heroes = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Heroes);
		Minions = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Minions);
		Turrets = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Turrets);
		BarracksDampeners = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.BarracksDampeners);
		Hqs = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Hqs);
		Missiles = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Missiles);
		ParticleEmitters = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.ParticleEmitters);
		Misc = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Misc);
		GameId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.GameId);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
