// Runtime evidence is aggregate presence/positive/change, never parity proof.
export const collectorFieldMatrix = [
  {field:"championStacks",path:"heroes[].common.buffs[].count",evidence:"capture-7331-Smolder-Veigar-changing-count",mapping:"exact SmolderQPassive / VeigarPhenomenalEvilPower; other champions missing",enabled:true},
  {field:"itemCounters",path:"heroes[].items[] + spells[].ammoCount",evidence:"capture-Tear330-potions-wards-support",mapping:"item-specific charges/stock/count; slot8 retained; boots3008 runtime pending",enabled:true},
  {
    field: "gameTime",
    path: "data.gameTime",
    evidence: "runtime-clock",
    mapping: "direct",
    enabled: true,
  },
  {
    field: "team",
    path: "heroes[].info.team",
    evidence: "runtime-SR-roster-crosscheck",
    mapping: "1 ORDER / 2 CHAOS; validate 5+5",
    enabled: true,
  },
  {
    field: "slot",
    path: "heroes[].heroIndex",
    evidence: "runtime-SR-unique10-role-unverified",
    mapping: "unique key; sorted within team, roles unresolved",
    enabled: true,
  },
  {
    field: "championId",
    path: "heroes[].common.identifier",
    evidence: "runtime-SR-roster-crosscheck",
    mapping: "exact champion code → current live catalog; unknown null",
    enabled: true,
  },
  {
    field: "level",
    path: "heroes[].common.level",
    evidence: "runtime-SR-crosscheck-220-of-220",
    mapping: "integer 1..30",
    enabled: true,
  },
  {
    field: "kills/deaths/assists",
    path: "heroes[].kills/deaths/assists",
    evidence: "runtime-SR-crosscheck-220-of-220",
    mapping: "nonnegative integer, zero preserved",
    enabled: true,
  },
  {
    field: "cs",
    path: "heroes[].laneMinionKills + neutralMinionKills",
    evidence:
      "native-capture-2026-10-16; user-confirmed-pause-caused-crosscheck-offsets",
    mapping:
      "laneMinionKills + neutralMinionKills, zero preserved; no external-comparison gate",
    enabled: true,
  },
  {
    field: "currentGold",
    path: "heroes[].gold",
    evidence: "runtime-presence",
    mapping: "direct; distinct from totalGold",
    enabled: true,
  },
  {
    field: "totalGold",
    path: "heroes[].totalGold",
    evidence: "runtime-positive-change",
    mapping: "direct",
    enabled: true,
  },
  {
    field: "health",
    path: "heroes[].common.health/maxHealth",
    evidence: "runtime-positive-change",
    mapping: "both valid; max>0; current<=max",
    enabled: true,
  },
  {
    field: "resource",
    path: "heroes[].resource/maxResource",
    evidence: "runtime-presence-change",
    mapping: "both valid; max>0; zero-capacity missing",
    enabled: true,
  },
  {
    field: "inventory/items",
    path: "heroes[].items[].slot/id/count",
    evidence: "runtime-SR-crosscheck-220-of-220",
    mapping:
      "unique slots 0..6; ignore known auxiliary slots7/8; id0 preserved; unknown slots null",
    enabled: true,
  },
  {
    field: "spells",
    path: "heroes[].spells[].index/name",
    evidence: "schema-only",
    mapping: "D4/F5; exact catalog names only",
    enabled: true,
  },
  {
    field: "cooldowns",
    path: "heroes[].spells[].index/readyAt/maxCooldown",
    evidence: "runtime-readyAt-positive",
    mapping:
      "R3/D4/F5 plus inventory slot0..6 → spell6..12; source-derived ammo recharge; runtime semantics unverified",
    enabled: true,
  },
  {
    field: "wardScore",
    path: "heroes[].visionScore",
    evidence: "schema-only",
    mapping: "nonnegative numeric",
    enabled: true,
  },
  {
    field: "team gold/kills",
    path: "sum 5 normalized player fields",
    evidence: "derived-from-reported-fields",
    mapping: "only complete valid team; otherwise null",
    enabled: true,
  },
  {
    field: "perks/keystone",
    path: "heroes[].perks",
    evidence: "source-schema-and-pinned-catalog; runtime-unverified",
    mapping:
      "unique catalog keystone; full nine only with valid primary4/secondary2/shards3 order",
    enabled: true,
  },
  {
    field: "experience",
    path: "heroes[].experience",
    evidence: "schema-only",
    mapping:
      "sourceStats.experience exposes total scalar; no invented previous/next boundaries",
    enabled: true,
  },
  {
    field: "isDead/respawnSeconds",
    path: "common.status/respawnTime",
    evidence: "native-capture-status-bit0-and-respawnTime",
    mapping:
      "dead when common.status bit0 clear; direct respawnTime; no HP inference",
    enabled: true,
  },
  {
    field: "Baron/Elder/roleQuest",
    path: "common.buffs/items/spells",
    evidence: "native-capture-exact-buffs-and-aux-slot8",
    mapping:
      "exact Baron/Elder buffs; role quest points from exact RoleBound buff count with SR thresholds; jungle remaining itemsmitecounter/pet charges; control ward is not completion; absent progress stays null",
    enabled: true,
  },
  {
    field: "recent native events",
    path: "gameEvents.heroDieEvents/turretKillEvents/inhibitorKillEvents/aceEvents + exact networkId object lookup",
    evidence: "restored-schema; fixture-routing; runtime-unverified",
    mapping:
      "ChampionKill/TurretKilled/InhibKilled/Ace; recent5s; hashed ID; baseline/seek/reconnect suppression; no history-completeness claim",
    enabled: true,
  },
  {
    field: "team objectives/inhibitors/events",
    path: "teamStats/gameEvents/turrets/buildings",
    evidence: "native-capture-2026-10-16-objective-deaths-and-teamStats",
    mapping:
      "cached exact objective IDs + deathEvents; opposing towersLost; observed-history dragons/grubs; inhibitor HP edge + 300s default; no complete-history claim",
    enabled: true,
  },
  {
    field: "mapNumber/paused/replay.time",
    path: "not in current snapshot contract",
    evidence: "missing",
    mapping: "null; speed is not proof of pause",
    enabled: false,
  },
  {
    field: "damage/winner/endGame",
    path: "not verified",
    evidence: "missing",
    mapping: "not emitted",
    enabled: false,
  },
] as const;
