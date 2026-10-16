import type { ObserverFrame, ObservedPlayer } from "./observer";
import { presentationPitTimers } from "./pit-timers";

export function latestObjectiveEvent(frame: ObserverFrame | null) {
  return (
    [...(frame?.newEvents ?? [])]
      .reverse()
      .find(
        (event) =>
          event.kind === "DragonKill" ||
          event.kind === "DragonSoul" ||
          event.kind === "BaronKill",
      ) ?? null
  );
}

export function projectedGameTime(
  frame: ObserverFrame | null,
  now: number,
): number | null {
  if (frame?.status !== "observed" || !frame.sample) return null;
  const ageMs = now - Date.parse(frame.capturedAt);
  if (ageMs < -1000 || ageMs >= 5000) return null;
  const base = frame.sample.gameTime.value ?? frame.sample.replay.time.value;
  if (base === null) return null;
  if (frame.sample.replay.paused.value === true) return base;
  const speed = frame.sample.replay.speed.value ?? 1;
  return base + (Math.max(0, ageMs) / 1000) * speed;
}

export function livePresentation(frame: ObserverFrame | null, now: number) {
  const age = frame ? now - Date.parse(frame.capturedAt) : Infinity;
  const sample =
    frame?.status === "observed" && age >= -1000 && age < 5000
      ? frame.sample
      : null;
  const time = projectedGameTime(sample ? frame : null, now);
  const baseTime = sample?.gameTime.value ?? sample?.replay.time.value;
  const advance =
    time == null || baseTime == null ? 0 : Math.max(0, time - baseTime);
  const players =
    sample?.players.map((p) =>
      p.isDead?.value === true && p.respawnSeconds?.value != null
        ? {
            ...p,
            respawnSeconds: {
              ...p.respawnSeconds,
              value: Math.max(0, p.respawnSeconds.value - advance),
            },
          }
        : p,
    ) ?? [];
  const blue = players.filter((p) => p.team.value === "ORDER");
  const red = players.filter((p) => p.team.value === "CHAOS");
  const blueTeam = sample?.teams?.find((team) => team.team === "ORDER");
  const redTeam = sample?.teams?.find((team) => team.team === "CHAOS");
  const sum = (players: ObservedPlayer[], field: "kills" | "totalGold") =>
    players.length === 5 &&
    !sample?.limits.playersTruncated &&
    players.every((p) => p[field].value !== null)
      ? players.reduce((total, p) => total + p[field].value!, 0)
      : null;
  return {
    sample,
    blue: blue.slice(0, 5),
    red: red.slice(0, 5),
    blueKills: blueTeam?.kills.value ?? sum(blue, "kills"),
    redKills: redTeam?.kills.value ?? sum(red, "kills"),
    blueGold: blueTeam?.totalGold.value ?? sum(blue, "totalGold"),
    redGold: redTeam?.totalGold.value ?? sum(red, "totalGold"),
    blueTowers: blueTeam?.towers.value ?? null,
    redTowers: redTeam?.towers.value ?? null,
    blueDragons: blueTeam?.dragons.value ?? null,
    redDragons: redTeam?.dragons.value ?? null,
    blueRoleQuests: blueTeam?.roleQuests?.value ?? null,
    redRoleQuests: redTeam?.roleQuests?.value ?? null,
    laneGold: Array.from({ length: 5 }, (_, index) => {
      const left = blue[index]?.totalGold.value;
      const right = red[index]?.totalGold.value;
      return left == null || right == null
        ? null
        : {
            value: Math.abs(right - left),
            leader:
              right > left
                ? ("red" as const)
                : left > right
                  ? ("blue" as const)
                  : ("even" as const),
          };
    }),
    pitTimers: presentationPitTimers(sample),
    time,
    clockMode: sample ? ("projected" as const) : ("unavailable" as const),
    clockSource:
      sample?.gameTime.value != null
        ? "GAME"
        : sample?.replay.time.value != null
          ? "REPLAY"
          : "CHỜ NGUỒN",
  };
}
