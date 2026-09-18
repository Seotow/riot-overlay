import catalog from "./generated/catalog.json";
export { catalog };
export type ChampionId = keyof typeof catalog.champions;
export function champion(id: string) {
  return catalog.champions[id as ChampionId];
}
export function item(id: string) {
  return catalog.items[id as keyof typeof catalog.items];
}
export function spell(id: string) {
  return catalog.spells[id as keyof typeof catalog.spells];
}
export function rune(id: number) {
  return catalog.runes[String(id) as keyof typeof catalog.runes];
}
