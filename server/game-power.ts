import { mkdir, readFile, rename, writeFile } from "node:fs/promises";
import { dirname, resolve } from "node:path";

export const games = ["lol", "valorant"] as const;
export type Game = (typeof games)[number];

/** Công tắc kết nối theo game: tắt thì không mở socket/process/poll của game đó, tránh tốn bộ nhớ. */
export class GamePower {
  private enabled: Record<Game, boolean> = { lol: true, valorant: false };
  private writing = Promise.resolve();
  constructor(
    private readonly path = resolve(
      process.env.RIOT_OVERLAY_GAMES_PATH || "data/studio-games.json",
    ),
  ) {}
  async load() {
    try {
      const raw = JSON.parse(await readFile(this.path, "utf8"));
      for (const game of games)
        if (typeof raw?.[game] === "boolean") this.enabled[game] = raw[game];
    } catch {}
  }
  isOn(game: Game) {
    return this.enabled[game];
  }
  snapshot() {
    return { ...this.enabled };
  }
  async set(game: Game, on: boolean) {
    this.enabled[game] = on;
    const json = JSON.stringify(this.enabled, null, 2);
    this.writing = this.writing
      .then(async () => {
        await mkdir(dirname(this.path), { recursive: true });
        await writeFile(`${this.path}.tmp`, json);
        await rename(`${this.path}.tmp`, this.path);
      })
      .catch(() => {});
    await this.writing;
  }
}
