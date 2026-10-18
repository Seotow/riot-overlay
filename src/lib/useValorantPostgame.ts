import { useCallback, useEffect, useState } from "react";
import type {
  PostgameConfig,
  PostgameHistoryResult,
  PostgameSelection,
  PostgameStatus,
} from "../../shared/valorant-postgame";

export function useValorantPostgame() {
  const [status, setStatus] = useState<PostgameStatus | null>(null);
  const [history, setHistory] = useState<PostgameHistoryResult | null>(null);
  const [loading, setLoading] = useState(false);

  const reload = useCallback(async () => {
    try {
      setStatus((await (await fetch("/api/valorant/postgame")).json()) as PostgameStatus);
    } catch {
      setStatus(null);
    }
  }, []);
  useEffect(() => {
    void reload();
    // Khung cuối của Spectra thay đổi trong lúc chơi; làm mới nhẹ để bảng trạng thái đúng.
    const timer = setInterval(() => void reload(), 5000);
    return () => clearInterval(timer);
  }, [reload]);

  const loadHistory = useCallback(async () => {
    setLoading(true);
    try {
      setHistory(
        (await (await fetch("/api/valorant/postgame/history")).json()) as PostgameHistoryResult,
      );
    } catch {
      setHistory({ ok: false, error: "network" });
    } finally {
      setLoading(false);
    }
  }, []);

  const save = useCallback(async (config: PostgameConfig, apiKey?: string) => {
    const res = await fetch("/api/valorant/postgame/config", {
      method: "PUT",
      headers: { "Content-Type": "application/json" },
      body: JSON.stringify({ config, ...(apiKey === undefined ? {} : { apiKey }) }),
    });
    if (!res.ok) return false;
    setStatus((await res.json()) as PostgameStatus);
    setHistory(null);
    return true;
  }, []);

  const select = useCallback(
    async (selection: PostgameSelection) => {
      const res = await fetch("/api/valorant/postgame/select", {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify(selection),
      });
      const json = (await res.json()) as { ok: boolean; message?: string };
      await reload();
      return json;
    },
    [reload],
  );

  return { status, history, loading, save, select, loadHistory };
}
