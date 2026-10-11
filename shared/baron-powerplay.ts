import type { IngameSample, ObserverFrame } from "./observer";
// Broadcast rules confirmed by the user. Buff ownership always comes from telemetry.
import { BARON_BUFF_SECONDS, ELDER_BUFF_SECONDS } from "./game-rules";
export { BARON_BUFF_SECONDS, ELDER_BUFF_SECONDS } from "./game-rules";
export type BaronWindow = {
  team: "ORDER" | "CHAOS";
  startedAt: number;
  ownGold: number | null;
  enemyGold: number | null;
};
export function allBaronLost(sample: IngameSample, team: "ORDER" | "CHAOS") {
  const players = sample.players.filter((p) => p.team.value === team);
  return (
    players.length === 5 && players.every((p) => p.hasBaron?.value === false)
  );
}
const teamGold = (s: IngameSample, team: string) =>
  s.teams?.find((t) => t.team === team)?.totalGold.value ?? null;
export function advanceBaronWindow(
  previous: BaronWindow | null,
  frame: ObserverFrame | null,
): BaronWindow | null {
  if (
    !frame?.sample ||
    ["lost", "seek", "reconnected", "source-changed"].includes(frame.transition)
  )
    return null;
  const s = frame.sample;
  const event = [...frame.newEvents]
    .reverse()
    .find((e) => e.kind === "BaronKill" && e.team);
  if (event?.team)
    return {
      team: event.team,
      startedAt: event.at,
      ownGold: teamGold(s, event.team),
      enemyGold: teamGold(s, event.team === "ORDER" ? "CHAOS" : "ORDER"),
    };
  return previous &&
    ((s.gameTime.value != null &&
      s.gameTime.value >= previous.startedAt + BARON_BUFF_SECONDS) ||
      allBaronLost(s, previous.team))
    ? null
    : previous;
}
export function baronGoldDelta(
  window: BaronWindow,
  sample: IngameSample,
): number | null {
  const own = teamGold(sample, window.team),
    enemy = teamGold(sample, window.team === "ORDER" ? "CHAOS" : "ORDER");
  return window.ownGold == null ||
    window.enemyGold == null ||
    own == null ||
    enemy == null
    ? null
    : 1500 + (own - enemy) - (window.ownGold - window.enemyGold);
}
export type ElderWindow = { team: "ORDER" | "CHAOS"; startedAt: number };
export function allElderLost(sample: IngameSample, team: "ORDER" | "CHAOS") {
  const players = sample.players.filter((p) => p.team.value === team);
  return (
    players.length === 5 && players.every((p) => p.hasElder?.value === false)
  );
}
export function advanceElderWindow(
  previous: ElderWindow | null,
  frame: ObserverFrame | null,
): ElderWindow | null {
  if (
    !frame?.sample ||
    ["lost", "seek", "reconnected", "source-changed"].includes(frame.transition)
  )
    return null;
  const event = [...frame.newEvents]
    .reverse()
    .find(
      (e) => e.kind === "DragonKill" && e.objectiveType === "elder" && e.team,
    );
  if (event?.team) return { team: event.team, startedAt: event.at };
  return previous &&
    ((frame.sample.gameTime.value != null &&
      frame.sample.gameTime.value >= previous.startedAt + ELDER_BUFF_SECONDS) ||
      allElderLost(frame.sample, previous.team))
    ? null
    : previous;
}
