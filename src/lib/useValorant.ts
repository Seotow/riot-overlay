import { useEffect, useState } from "react";
import {
  valorantFrameSchema,
  valorantStatusSchema,
  type ValorantFrame,
  type ValorantStatus,
} from "../../shared/valorant";

export type ValorantFeed = { status: ValorantStatus["status"]; frame: ValorantFrame | null };

/** Poll nội bộ qua Studio server; lỗi mạng hoặc payload sai được coi là không có dữ liệu. */
export function useValorant(intervalMs: number, withStatus = false) {
  const [feed, setFeed] = useState<ValorantFeed>({ status: "offline", frame: null });
  const [detail, setDetail] = useState<ValorantStatus | null>(null);
  useEffect(() => {
    let stopped = false;
    let timer: ReturnType<typeof setTimeout>;
    const controller = new AbortController();
    const poll = async () => {
      try {
        const res = await fetch("/api/valorant/frame", { signal: controller.signal });
        if (!res.ok) throw Error();
        const body = await res.json();
        const frame = body.frame ? valorantFrameSchema.safeParse(body.frame) : null;
        if (!stopped)
          setFeed({
            status: body.status,
            frame: frame?.success ? frame.data : null,
          });
        if (withStatus) {
          const s = valorantStatusSchema.safeParse(
            await (await fetch("/api/valorant/status")).json(),
          );
          if (!stopped) setDetail(s.success ? s.data : null);
        }
      } catch {
        if (!stopped) setFeed({ status: "offline", frame: null });
      } finally {
        if (!stopped) timer = setTimeout(poll, intervalMs);
      }
    };
    void poll();
    return () => {
      stopped = true;
      clearTimeout(timer);
      controller.abort();
    };
  }, [intervalMs, withStatus]);
  return { ...feed, detail };
}
