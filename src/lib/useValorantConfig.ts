import { useCallback, useEffect, useState } from "react";
import {
  valorantConfigViewSchema,
  type ValorantConfigSave,
  type ValorantConfigView,
} from "../../shared/valorant-config";

export function useValorantConfig() {
  const [view, setView] = useState<ValorantConfigView | null>(null);
  const reload = useCallback(async () => {
    try {
      const res = await fetch("/api/valorant/config");
      const parsed = valorantConfigViewSchema.safeParse(await res.json());
      setView(parsed.success ? parsed.data : null);
    } catch {
      setView(null);
    }
  }, []);
  useEffect(() => {
    void reload();
  }, [reload]);
  const save = useCallback(async (body: ValorantConfigSave) => {
    const res = await fetch("/api/valorant/config", {
      method: "PUT",
      headers: { "Content-Type": "application/json" },
      body: JSON.stringify(body),
    });
    const json = await res.json();
    if (!res.ok) return { ok: false as const, error: String(json.error ?? "error") };
    const parsed = valorantConfigViewSchema.safeParse(json);
    if (parsed.success) setView(parsed.data);
    return { ok: true as const, applied: json.applied === true };
  }, []);
  return { view, save, reload };
}
