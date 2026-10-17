import { discover, getLocal, type Credentials } from "./diagnostics";
import { champSelectPhase, mapChampSelect, type LcuDraftStatus } from "../shared/draft-lcu";
import type { DraftState } from "../shared/draft";

// Read-only LCU champ select reader. Credentials stay in this module and are never exposed.
export class DraftLcu {
  private credentials: Credentials | null = null;
  private status: LcuDraftStatus = { status: "offline", phase: null, updatedAt: 0 };
  snapshot(): LcuDraftStatus {
    return { ...this.status };
  }
  private set(status: LcuDraftStatus["status"], phase: string | null, now: number) {
    if (this.status.status !== status || this.status.phase !== phase)
      this.status = { status, phase, updatedAt: now };
  }
  private names = new Map<string, string>();
  // Champ select entries can lack a visible name; resolve it directly from the client by summoner
  // id or puuid (cached, read-only) and hand it to the mapper as if the session had carried it.
  private async withNames(session: unknown): Promise<unknown> {
    const data = (session && typeof session === "object" ? session : {}) as Record<string, unknown>;
    const credentials = this.credentials;
    if (!credentials) return session;
    const teams = (key: string) =>
      (Array.isArray(data[key]) ? (data[key] as Record<string, unknown>[]) : []).map(async (p) => {
        if (!p || typeof p !== "object") return p;
        if (String(p.gameName ?? p.summonerName ?? "").trim()) return p;
        const id = typeof p.summonerId === "number" && p.summonerId > 0 ? p.summonerId : null;
        const puuid = typeof p.puuid === "string" && p.puuid ? p.puuid : null;
        const cacheKey = id ? `id:${id}` : puuid ? `puuid:${puuid}` : null;
        if (!cacheKey) return p;
        if (!this.names.has(cacheKey)) {
          const path = id
            ? `/lol-summoner/v1/summoners/${id}`
            : `/lol-summoner/v2/summoners/puuid/${encodeURIComponent(puuid!)}`;
          const found = await getLocal("draft-lcu-name", path, credentials);
          const v = (found.data && typeof found.data === "object" ? found.data : {}) as Record<
            string,
            unknown
          >;
          const name = String(v.gameName || v.displayName || v.internalName || "").trim();
          if (found.probe.status === "ok" && name) this.names.set(cacheKey, name);
        }
        const name = this.names.get(cacheKey);
        return name ? { ...p, gameName: name } : p;
      });
    return {
      ...data,
      myTeam: await Promise.all(teams("myTeam")),
      theirTeam: await Promise.all(teams("theirTeam")),
    };
  }
  // Returns the next draft when champ select is readable, null when nothing should change.
  async poll(
    current: DraftState,
    now = Date.now(),
  ): Promise<{ draft: DraftState | null; changed: boolean }> {
    const before = JSON.stringify(this.status);
    try {
      this.credentials ??= await discover();
      if (!this.credentials) {
        this.set("offline", null, now);
        return { draft: null, changed: JSON.stringify(this.status) !== before };
      }
      const result = await getLocal("draft-lcu", "/lol-champ-select/v1/session", this.credentials);
      if (result.probe.status === "unreachable") this.credentials = null; // client restarted
      if (result.probe.status !== "ok") {
        this.set(result.probe.httpStatus === 404 ? "idle" : "error", null, now);
        return { draft: null, changed: JSON.stringify(this.status) !== before };
      }
      const draft = mapChampSelect(await this.withNames(result.data), current, now);
      this.set(draft ? "champ-select" : "idle", champSelectPhase(result.data), now);
      return { draft, changed: JSON.stringify(this.status) !== before };
    } catch {
      this.credentials = null;
      this.set("error", null, now);
      return { draft: null, changed: JSON.stringify(this.status) !== before };
    }
  }
}
