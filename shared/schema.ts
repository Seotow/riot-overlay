import { z } from "zod";
export const sceneSchema = z.enum(["ingame", "draft", "postgame"]);
const color = z.string().regex(/^#[0-9a-fA-F]{6}$/);
export const themeSchema = z.object({
  version: z.literal(1),
  name: z.string().min(1).max(60),
  tournament: z.string().min(1).max(80),
  blueName: z.string().min(1).max(30),
  redName: z.string().min(1).max(30),
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
  version: 1,
  name: "Tournament / Placeholder",
  tournament: "YOUR TOURNAMENT",
  blueName: "TEAM AZURE",
  redName: "TEAM CRIMSON",
  blue: "#51c9ef",
  red: "#f77983",
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
  protocol: 1;
  revision: number;
  source: "mock";
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
