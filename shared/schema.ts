import { z } from "zod";
import { draftSchema, type DraftState } from "./draft";
import type { LcuDraftStatus } from "./draft-lcu";
import { hudSchema } from "./replay-hud";
import { postgameSampleSchema, type PostgameState } from "./postgame";
import { rehearsalKindSchema, rehearsalVariantSchema, type RehearsalDisplay } from "./rehearsal";
export const sceneSchema = z.enum(["auto", "ingame", "draft", "postgame"]);
const color = z.string().regex(/^#[0-9a-fA-F]{6}$/);
export const themeSchema = z.object({
  killfeedStyle: z.enum(["text", "broadcast"]).optional(),
  replayHud: hudSchema.optional(),
  ingamePanelOpacity: z.number().min(0.35).max(0.9).optional(),
  draftLayout: z.enum(["broadcast", "simple"]).optional(),
  playerCameras: z.boolean().optional(),
  playerNames: z.array(z.string().max(80)).length(10).optional(),
  blueSecondary: color.optional(),
  redSecondary: color.optional(),
  ingameGraphics: z
    .object({
      pitTimers: z.boolean().optional(),
      baronPowerplay: z.boolean().optional(),
      elderTimer: z.boolean().optional(),
      soulTakeover: z.boolean().optional(),
      objectiveBanners: z.boolean().optional(),
      inhibitorTimers: z.boolean().optional(),
      portraitEffects: z.boolean().optional(),
      buffFrames: z.boolean().optional(),
    })
    .optional(),
  scoreboardLogo: z
    .string()
    .max(150000)
    .regex(/^$|^data:image\/png;base64,[A-Za-z0-9+/=]+$/)
    .optional(),
  minimalLogo: z
    .string()
    .max(150000)
    .regex(/^$|^data:image\/png;base64,[A-Za-z0-9+/=]+$/)
    .optional(),
  blueLogo: z
    .string()
    .max(500000)
    .regex(/^$|^data:image\/(png|jpeg|webp);base64,[A-Za-z0-9+/=]+$/)
    .optional(),
  redLogo: z
    .string()
    .max(500000)
    .regex(/^$|^data:image\/(png|jpeg|webp);base64,[A-Za-z0-9+/=]+$/)
    .optional(),
  blueScore: z.number().int().min(0).max(9).optional(),
  redScore: z.number().int().min(0).max(9).optional(),
  seriesGames: z.number().int().min(1).max(9).optional(),
  version: z.literal(1),
  name: z.string().min(1).max(60),
  tournament: z.string().min(1).max(80),
  blueName: z.string().min(1).max(30),
  redName: z.string().min(1).max(30),
  blueDescription: z.string().trim().max(40).optional(),
  redDescription: z.string().trim().max(40).optional(),
  blue: color,
  red: color,
  accent: color,
  background: color,
  font: z.enum(["system", "serif", "condensed"]),
  variant: z.enum(["panel", "minimal"]),
  scale: z.number().min(0.75).max(1.15),
  offsetY: z.number().min(0).max(100),
  widgets: z.object({
    players: z.boolean(),
    levels: z.boolean(),
    objectives: z.boolean(),
    killfeed: z.boolean(),
    gold: z.boolean(),
  }),
});
export type Theme = z.infer<typeof themeSchema>;
export const defaultTheme: Theme = {
  playerCameras: false,
  version: 1,
  name: "Tournament / Placeholder",
  tournament: "YOUR TOURNAMENT",
  blueName: "TEAM AZURE",
  redName: "TEAM CRIMSON",
  blue: "#0872b8",
  red: "#bb243b",
  blueSecondary: "#0373e0",
  redSecondary: "#ba191c",
  accent: "#d8bc7e",
  background: "#101820",
  font: "system",
  variant: "panel",
  scale: 1,
  offsetY: 20,
  widgets: {
    players: true,
    levels: false,
    objectives: true,
    killfeed: true,
    gold: true,
  },
};
export const commandSchema = z.discriminatedUnion("type", [
  z.object({ type: z.literal("draftState"), value: draftSchema }),
  z.object({ type: z.literal("swapSides") }),
  z.object({
    type: z.literal("postgameState"),
    value: postgameSampleSchema.nullable(),
  }),
  z.object({
    type: z.literal("broadcast"),
    value: z.object({
      view: z.enum(["normal", "gold", "levels", "runes", "minimal"]),
      inhibitors: z.enum(["off", "auto", "ORDER", "CHAOS"]),
      layout: z.enum(["panel", "minimal"]).optional(),
      gold: z.boolean().optional(),
      levels: z.boolean().optional(),
      runes: z.boolean().optional(),
    }),
  }),
  z.object({
    type: z.literal("broadcastWidget"),
    key: z.enum(["gold", "levels", "runes", "minimal"]),
    value: z.boolean(),
  }),
  z.object({
    type: z.literal("broadcastInhibitors"),
    value: z.enum(["off", "auto", "ORDER", "CHAOS"]),
  }),
  z.object({
    type: z.literal("rehearsal"),
    value: rehearsalKindSchema,
    variant: rehearsalVariantSchema.optional(),
  }),
  z.object({
    type: z.literal("provider"),
    value: z.enum([
      "riot",
      "leaguebroadcast",
      "league-collector",
      "collector-accountless",
      "recording",
    ]),
  }),
  z.object({
    type: z.literal("captureLoad"),
    id: z.string().regex(/^(?:lb-)?\d{4}-\d{2}-\d{2}T\d{2}-\d{2}-\d{2}-\d{3}Z$/),
  }),
  z.object({
    type: z.literal("captureControl"),
    playing: z.boolean().optional(),
    speed: z.number().min(0.25).max(4).optional(),
    positionMs: z.number().finite().nonnegative().optional(),
  }),
  z.object({ type: z.literal("mockVisible"), value: z.boolean() }),
  z.object({ type: z.literal("scene"), value: sceneSchema }),
  z.object({ type: z.literal("playing"), value: z.boolean() }),
  z.object({
    type: z.literal("seek"),
    value: z.number().int().min(0).max(2400),
  }),
  z.object({
    type: z.literal("event"),
    value: z.enum(["kill", "level", "objective", "draft"]),
  }),
  z.object({
    type: z.literal("scenario"),
    value: z.enum(["balanced", "advantage", "missing"]),
  }),
  z.object({ type: z.literal("theme"), value: themeSchema }),
  z.object({
    type: z.literal("ingameGraphic"),
    key: themeSchema.shape.ingameGraphics.unwrap().keyof(),
    value: z.boolean(),
  }),
  z.object({ type: z.literal("reset") }),
]);
export type Command = z.infer<typeof commandSchema>;
export type Player = {
  id: string;
  name: string;
  champion: string;
  role: string;
  level: number;
  kills: number;
  deaths: number;
  assists: number;
  cs: number;
  gold: number | null;
  championId: string;
  items: string[];
  spells: string[];
  rune: number;
  health: number;
  resource: number;
  vision: number;
};
export type State = {
  // Postgame is under development and locked only when the backend starts with RIOT_OVERLAY_POSTGAME=0.
  postgameLocked?: boolean;
  draft?: DraftState;
  draftLcu?: LcuDraftStatus;
  postgame?: PostgameState | null;
  broadcast?: {
    view: "normal" | "gold" | "levels" | "runes" | "minimal";
    inhibitors: "off" | "auto" | "ORDER" | "CHAOS";
    layout?: "panel" | "minimal";
    gold?: boolean;
    levels?: boolean;
    runes?: boolean;
  };
  rehearsal?: RehearsalDisplay;
  protocol: 1;
  revision: number;
  source: "mock";
  mockVisible: boolean;
  provider: "riot" | "leaguebroadcast" | "league-collector" | "collector-accountless" | "recording";
  scene: z.infer<typeof sceneSchema>;
  playing: boolean;
  gameTime: number;
  scenario: "balanced" | "advantage" | "missing";
  players: Player[];
  blueKills: number;
  redKills: number;
  draftStep: number;
  events: { id: number; at: number; text: string }[];
  objectives: { name: string; endsAt: number }[];
  capabilities: { gold: boolean; xp: boolean };
  theme: Theme;
};
