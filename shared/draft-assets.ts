import data from "./generated/draft-catalog.json";
export const draftCatalog = data;
export const draftChampion = (id: string) =>
  Object.hasOwn(data.champions, id)
    ? data.champions[id as keyof typeof data.champions]
    : undefined;
