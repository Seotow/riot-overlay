import { useCallback, useEffect, useState } from "react";

export type GameId = "lol" | "valorant";
export type GamesReport = {
  games: Record<GameId, boolean>;
  valorant: {
    status: "stopped" | "installing" | "starting" | "running" | "failed";
    error: string | null;
    step: string | null;
    collector: string | null;
    official: { state: string; title: string } | null;
    collectorError: string | null;
    controllerConnected: boolean | null;
    controllerError: string | null;
  };
};

/** Trạng thái bật/tắt kết nối của từng game; công tắc gọi server để mở/đóng nguồn thật. */
export function useGames() {
  const [report, setReport] = useState<GamesReport | null>(null);
  const [busy, setBusy] = useState(false);
  useEffect(() => {
    let stopped = false;
    let timer: ReturnType<typeof setTimeout>;
    const poll = async () => {
      try {
        const res = await fetch("/api/games");
        if (!res.ok) throw Error();
        const body = (await res.json()) as GamesReport;
        if (!stopped) setReport(body);
      } catch {
        if (!stopped) setReport(null);
      } finally {
        if (!stopped) timer = setTimeout(poll, 2000);
      }
    };
    void poll();
    return () => {
      stopped = true;
      clearTimeout(timer);
    };
  }, []);
  const toggle = useCallback(async (game: GameId, enabled: boolean) => {
    setBusy(true);
    try {
      const res = await fetch("/api/games", {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify({ game, enabled }),
      });
      if (res.ok) setReport((await res.json()) as GamesReport);
    } finally {
      setBusy(false);
    }
  }, []);
  return { report, busy, toggle };
}
