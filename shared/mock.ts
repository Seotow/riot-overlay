import { type State, type Command } from "./schema";
import { ingameFixture as fixture, referenceTheme } from "./reference";
import { champion } from "./assets";
import { swapDraftSides } from "./draft";
import { swapTeamSides } from "./match-config";
export function createState(): State {
  return {
    protocol: 1,
    revision: 0,
    source: "mock",
    mockVisible: false,
    provider: "collector-accountless",
    scene: "auto",
    playing: false,
    gameTime: 1538,
    scenario: "balanced",
    blueKills: 9,
    redKills: 14,
    draftStep: 6,
    events: [],
    objectives: [{ name: "BARON BUFF", endsAt: 1758 }],
    capabilities: { gold: true, xp: false },
    theme: { ...structuredClone(referenceTheme), playerCameras: false },
    players: fixture.champions.map((id, i) => ({
      id: "p" + i,
      name: fixture.names[i],
      championId: id,
      champion: champion(id).name,
      role: ["TOP", "JGL", "MID", "BOT", "SUP"][i % 5],
      level: fixture.levels[i],
      kills: fixture.kills[i],
      deaths: fixture.deaths[i],
      assists: fixture.assists[i],
      cs: fixture.cs[i],
      vision: fixture.vision[i],
      gold: fixture.gold[i],
      items: fixture.items[i],
      spells: fixture.spells[i],
      rune: fixture.runes[i],
      health: fixture.health[i],
      resource: fixture.resource[i],
    })),
  };
}
export function applyCommand(state: State, cmd: Command): State {
  const s = structuredClone(state);
  s.revision++;
  if (cmd.type === "provider") s.provider = cmd.value;
  if (cmd.type === "mockVisible") {
    s.mockVisible = cmd.value;
    if (!cmd.value) s.playing = false;
  }
  if (cmd.type === "theme") s.theme = cmd.value;
  if (cmd.type === "ingameGraphic")
    s.theme = {
      ...s.theme,
      ingameGraphics: { ...s.theme.ingameGraphics, [cmd.key]: cmd.value },
    };
  if (cmd.type === "draftState") s.draft = cmd.value;
  // One action for both "Đổi bên" buttons: team identity, scores and the draft setup move together.
  if (cmd.type === "swapSides") {
    s.theme = swapTeamSides(s.theme);
    if (s.draft) s.draft = swapDraftSides(s.draft);
  }
  if (cmd.type === "postgameState") s.postgame = cmd.value;
  if (cmd.type === "broadcast") s.broadcast = cmd.value;
  if (cmd.type === "broadcastInhibitors")
    s.broadcast = {
      ...(s.broadcast ?? { view: "normal", inhibitors: "auto" }),
      inhibitors: cmd.value,
    };
  if (cmd.type === "broadcastWidget") {
    // A pinned scene stays pinned; automatic mode keeps following the data.
    if (s.scene !== "auto") s.scene = "ingame";
    s.broadcast = {
      ...(s.broadcast ?? { view: "normal", inhibitors: "auto" }),
      ...(cmd.key === "minimal"
        ? { layout: cmd.value ? "minimal" : "panel" }
        : { [cmd.key]: cmd.value }),
    };
  }
  if (cmd.type === "scene") s.scene = cmd.value;
  if (cmd.type === "playing") s.playing = cmd.value;
  if (cmd.type === "seek") {
    s.gameTime = cmd.value;
    s.events = [];
    s.objectives = [
      { name: "DRAGON", endsAt: cmd.value + 128 },
      { name: "BARON", endsAt: cmd.value + 240 },
    ];
  }
  if (cmd.type === "scenario") {
    s.scenario = cmd.value;
    s.capabilities.gold = cmd.value !== "missing";
    s.players.forEach(
      (p, i) =>
        (p.gold = s.capabilities.gold
          ? 4300 + (i % 5) * 370 + (cmd.value === "advantage" && i < 5 ? 1700 : 0)
          : null),
    );
  }
  if (cmd.type === "event") {
    if (cmd.value === "draft") s.draftStep = (s.draftStep + 1) % 11;
    if (cmd.value === "kill") {
      s.players[2].kills++;
      s.players[7].deaths++;
      s.blueKills++;
      s.events.unshift({
        id: s.revision,
        at: s.gameTime,
        text: `${s.players[2].champion}  ›  ${s.players[7].champion}`,
      });
      s.events = s.events.slice(0, 4);
    }
    if (cmd.value === "level") s.players[2].level = Math.min(18, s.players[2].level + 1);
    if (cmd.value === "objective") {
      s.objectives = [{ name: "DRAGON", endsAt: s.gameTime + 300 }];
      s.events.unshift({
        id: s.revision,
        at: s.gameTime,
        text: `${s.theme.blueName}  ›  RỒNG`,
      });
      s.events = s.events.slice(0, 4);
    }
  }
  if (cmd.type === "reset") {
    const reset = createState();
    reset.theme = s.theme;
    reset.mockVisible = s.mockVisible;
    reset.provider = s.provider;
    reset.revision = s.revision;
    return reset;
  }
  return s;
}
export function tick(state: State): State {
  if (!state.playing) return state;
  return {
    ...state,
    revision: state.revision + 1,
    gameTime: state.gameTime + 1,
    events: state.events.filter((e) => state.gameTime - e.at < 12),
  };
}
export const clock = (seconds: number) =>
  `${Math.floor(Math.max(0, seconds) / 60)
    .toString()
    .padStart(2, "0")}:${Math.floor(Math.max(0, seconds) % 60)
    .toString()
    .padStart(2, "0")}`;
