import { createHash } from "node:crypto";
import { ingameSampleSchema, type IngameSample } from "../../shared/observer";
import { liveCatalog, resolveChampion } from "../../shared/live-assets";
import { collectorPerks } from "./perks";
import { collectorEvents } from "./events";
import { collectorPlayerExtras } from "./player-extras";
import { cleanPlayerName } from "../../shared/player-name";
import { nativeChampionStacks } from "../../shared/champion-stacks";
import { projectItemCounters } from "../../shared/item-counters";

export const object = (v: unknown): Record<string, unknown> =>
  v !== null && typeof v === "object" && !Array.isArray(v)
    ? (v as Record<string, unknown>)
    : {};
const num = (
  v: unknown,
  integer = false,
  max = Number.MAX_SAFE_INTEGER,
): number | null =>
  typeof v === "number" &&
  Number.isFinite(v) &&
  v >= 0 &&
  v <= max &&
  (!integer || Number.isInteger(v))
    ? v
    : null;
const positive = (v: unknown, integer = false) => {
  const n = num(v, integer);
  return n !== null && n > 0 ? n : null;
};
const field = <T>(value: T | null, observedAt: string) => ({
  value,
  availability: value === null ? ("missing" as const) : ("observed" as const),
  source: "league-collector" as const,
  observedAt,
});

export interface NormalizedCollector {
  sample: IngameSample;
  signature: string;
}

// Accept only current native envelopes. Unknown provider fields are never copied.
export function normalizeCollector(
  raw: unknown,
  nowMs: number,
): NormalizedCollector | null {
  const envelope = object(raw),
    data = object(envelope.data);
  if (
    envelope.schemaVersion !== 1 ||
    envelope.type !== "snapshot" ||
    envelope.source !== "lblib" ||
    envelope.synthetic !== false ||
    envelope.recordedAt !== null ||
    num(envelope.sequence, true) === null ||
    envelope.sequence === 0 ||
    typeof envelope.timestamp !== "string" ||
    envelope.timestamp.length > 40 ||
    !/^\d{4}-\d{2}-\d{2}T.*(?:Z|[+-]\d{2}:\d{2})$/.test(envelope.timestamp)
  )
    return null;
  const stamp = Date.parse(envelope.timestamp);
  if (!Number.isFinite(stamp) || stamp > nowMs + 1000 || nowMs - stamp >= 5000)
    return null;
  const observedAt = new Date(stamp).toISOString();
  const gameTime = num(data.gameTime);
  if (
    gameTime === null ||
    !Array.isArray(data.heroes) ||
    data.heroes.length !== 10
  )
    return null;
  const heroes = data.heroes.map(object);
  const keys = heroes.map((h) => num(h.heroIndex, true, 0xffffffff));
  if (
    keys.some((k) => k === null) ||
    new Set(keys).size !== 10 ||
    heroes.some(
      (h) =>
        ![1, 2].includes(Number(object(h.info).team)) ||
        typeof object(h.info).team !== "number",
    ) ||
    heroes.filter((h) => object(h.info).team === 1).length !== 5
  )
    return null;
  heroes.sort(
    (a, b) =>
      Number(object(a.info).team) - Number(object(b.info).team) ||
      Number(a.heroIndex) - Number(b.heroIndex),
  );
  const players = heroes.map((h, slot) => {
    const common = object(h.common);
    const code =
      typeof common.identifier === "string" &&
      /^[A-Za-z0-9]{1,64}$/.test(common.identifier)
        ? common.identifier
        : null;
    const champion = resolveChampion({
      rawChampionName: code ? `game_character_displayname_${code}` : undefined,
    });
    const hp = num(common.health),
      maxHp = positive(common.maxHealth);
    const resource = num(h.resource),
      maxResource = positive(h.maxResource);
    const rawItems =
      Array.isArray(h.items) && h.items.length > 0 && h.items.length <= 16
        ? h.items.map(object)
        : null;
    // Auxiliary quest/boots slot 8 is projected separately, not discarded.
    const standardItems =
      rawItems &&
      rawItems.every((i) => num(i.slot, true, 8) !== null) &&
      new Set(rawItems.map((i) => i.slot)).size === rawItems.length
        ? rawItems.filter((i) => Number(i.slot) <= 6)
        : null;
    const inventory = standardItems?.length
      ? standardItems.map((i) => ({
          slot: num(i.slot, true, 6),
          id: num(i.id, true, 0xffffffff),
          count: num(i.count, true, 127),
        }))
      : null;
    const validInventory =
      inventory &&
      inventory.every((i) => i.slot !== null && i.id !== null) &&
      new Set(inventory.map((i) => i.slot)).size === inventory.length
        ? (inventory as { slot: number; id: number; count: number | null }[])
        : null;
    const rawSpells =
      Array.isArray(h.spells) && h.spells.length > 0 && h.spells.length <= 16
        ? h.spells.map(object)
        : null;
    const spellIndices = rawSpells?.map((s) => num(s.index, true, 63));
    const spells =
      rawSpells &&
      spellIndices &&
      spellIndices.every((i) => i !== null) &&
      new Set(spellIndices).size === spellIndices.length
        ? rawSpells
        : null;
    const summoner = (index: number) => {
      const name = spells?.find((s) => s.index === index)?.name;
      return typeof name === "string" && /^[A-Za-z0-9_]{1,100}$/.test(name)
        ? name
        : null;
    };
    const summoners: [string | null, string | null] = [
      summoner(4),
      summoner(5),
    ];
    // Slot correspondence comes from Farsight SpellBookUtils and SpellSlotIndex.
    // It is source evidence; actual game timer/activation semantics still need checking.
    const cooldowns = spells
      ?.filter((s) => [3, 4, 5].includes(Number(s.index)))
      .map((s) => ({
        kind: s.index === 3 ? ("ultimate" as const) : ("spell" as const),
        slot: s.index === 3 ? "R" : s.index === 4 ? "D" : "F",
        readyAt: num(s.readyAt),
        total: num(s.maxCooldown),
      }));
    const validAbilityCooldowns =
      cooldowns &&
      cooldowns.length > 0 &&
      cooldowns.every((c) => c.readyAt !== null && c.total !== null)
        ? (cooldowns as {
            kind: "ultimate" | "spell";
            slot: string;
            readyAt: number;
            total: number;
          }[])
        : null;
    const itemCooldowns =
      validInventory && spells
        ? validInventory.flatMap((item) => {
            const id = num(item.id, true, 0xffffffff);
            if (!id) return [];
            const spell = spells.find((s) => s.index === 6 + Number(item.slot));
            if (!spell) return [];
            // Farsight Spell.GetMaxCooldown chooses recharge for empty ammo.
            const recharge =
              positive(spell.ammoReadyAt) !== null && spell.ammoCount === 0;
            const readyAt = num(recharge ? spell.ammoReadyAt : spell.readyAt);
            const total = positive(
              recharge ? spell.ammoCooldown : spell.maxCooldown,
            );
            return readyAt !== null && total !== null
              ? [
                  {
                    kind: "item" as const,
                    slot: String(item.slot),
                    id,
                    readyAt,
                    total,
                  },
                ]
              : [];
          })
        : [];
    const validCooldowns =
      validAbilityCooldowns || itemCooldowns.length
        ? [...(validAbilityCooldowns ?? []), ...itemCooldowns]
        : null;
    const perks = collectorPerks(h.perks);
    const extras = collectorPlayerExtras(h, gameTime);
    const laneCs = num(h.laneMinionKills, true),
      neutralCs = num(h.neutralMinionKills, true);
    const sourceStats = Object.fromEntries([
      ...[
        "laneMinionKills",
        "neutralMinionKills",
        "experience",
        "resourceType",
        "goldGivenOnDeath",
        "respawnTime",
      ].map((key) => [key, num(h[key])]),
      ...[
        "status",
        "armor",
        "magicResist",
        "movementSpeed",
        "attackSpeedMultiplier",
        "attackSpeedBonus",
      ].map((key) => [
        key,
        typeof common[key] === "number" && Number.isFinite(common[key])
          ? common[key]
          : null,
      ]),
    ]);
    return {
      slot,
      playerName: field(cleanPlayerName(object(h.info).name), observedAt),
      championStacks: field(nativeChampionStacks(champion.id, common.buffs), observedAt),
      itemCounters: field(projectItemCounters(rawItems,spells),observedAt),
      team: field(
        object(h.info).team === 1 ? ("ORDER" as const) : ("CHAOS" as const),
        observedAt,
      ),
      championId: field(champion.id, observedAt),
      championMapping: champion.via,
      level: field(positive(num(common.level, true, 30), true), observedAt),
      kills: field(num(h.kills, true), observedAt),
      deaths: field(num(h.deaths, true), observedAt),
      assists: field(num(h.assists, true), observedAt),
      cs: field(
        laneCs !== null && neutralCs !== null ? laneCs + neutralCs : null,
        observedAt,
      ),
      totalGold: field(num(h.totalGold), observedAt),
      currentGold: field(num(h.gold), observedAt),
      wardScore: field(num(h.visionScore), observedAt),
      health: field(
        hp !== null && maxHp !== null && hp <= maxHp
          ? { current: hp, max: maxHp }
          : null,
        observedAt,
      ),
      resource: field(
        resource !== null && maxResource !== null && resource <= maxResource
          ? { current: resource, max: maxResource }
          : null,
        observedAt,
      ),
      inventory: field(validInventory, observedAt),
      items: field(validInventory?.map((i) => i.id) ?? null, observedAt),
      spells: field(
        summoners.some((s) => s !== null) ? summoners : null,
        observedAt,
      ),
      cooldowns: field(validCooldowns, observedAt),
      keystone: field<number>(perks.keystone, observedAt),
      perks: field<number[]>(perks.perks, observedAt),
      isDead: field(extras.isDead, observedAt),
      respawnSeconds: field(extras.respawnSeconds, observedAt),
      hasBaron: field(extras.hasBaron, observedAt),
      hasElder: field(extras.hasElder, observedAt),
      roleQuest: field(extras.roleQuest, observedAt),
      sourceStats: field(sourceStats, observedAt),
    };
  });
  const speed = num(data.playbackSpeed);
  const teams = (["ORDER", "CHAOS"] as const).map((team, side) => {
    const members = players.filter((p) => p.team.value === team);
    const sum = (key: "totalGold" | "kills") =>
      members.length === 5 && members.every((p) => p[key].value !== null)
        ? num(
            members.reduce((total, p) => total + p[key].value!, 0),
            key === "kills",
          )
        : null;
    return {
      team,
      totalGold: field(sum("totalGold"), observedAt),
      kills: field(sum("kills"), observedAt),
      towers: field(
        Array.isArray(data.teamStats)
          ? num(object(data.teamStats[1 - side]).towersLost, true)
          : null,
        observedAt,
      ),
      towerPlates: field(
        (() => {
          if (!Array.isArray(data.turrets)) return null;
          const turrets = data.turrets
            .map(object)
            .filter((t) => object(t.info).team === (side === 0 ? 2 : 1));
          if (
            !turrets.length ||
            turrets.some(
              (t) =>
                num(t.plateCount, true) === null ||
                num(t.maxPlateCount, true) === null ||
                Number(t.plateCount) > Number(t.maxPlateCount),
            )
          )
            return null;
          return turrets.reduce(
            (sum, t) => sum + Number(t.maxPlateCount) - Number(t.plateCount),
            0,
          );
        })(),
        observedAt,
      ),
      dragons: field<string[]>(null, observedAt),
      grubs: field<number>(null, observedAt),
    };
  });
  const nativeEvents = collectorEvents(data, heroes, gameTime);
  const sample = ingameSampleSchema.safeParse({
    capturedAt: observedAt,
    gameTime: field(gameTime, observedAt),
    assetVersion: liveCatalog.version,
    assetPatchMatch: "unverified",
    mapNumber: field<number>(null, observedAt),
    replay: {
      time: field<number>(null, observedAt),
      paused: field<boolean>(null, observedAt),
      speed: field(speed, observedAt),
    },
    players,
    teams,
    events: nativeEvents.events,
    eventCoverage: {
      historyFromStart: false,
      towerEventsComplete: false,
      dragonEventsComplete: false,
    },
    limits: {
      playersTruncated: false,
      eventsTruncated: nativeEvents.truncated,
    },
  });
  if (!sample.success) return null;
  // IDs are session keys only, never exposed in sample/report/recording.
  const gameId =
    typeof data.gameId === "string" && data.gameId.length <= 128
      ? data.gameId
      : "unknown-game";
  const signature = createHash("sha256")
    .update(
      JSON.stringify([
        gameId,
        heroes.map((h, index) => [
          object(h.info).team,
          h.heroIndex,
          num(object(h.info).networkId, true, 0xffffffff),
          players[index].championId.value,
        ]),
      ]),
    )
    .digest("hex");
  return { sample: sample.data, signature };
}
