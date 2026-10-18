// Riot Overlay local fork: configurable, loopback-only runtime. See ../MODIFICATIONS.md.
export function port(name: string, fallback: number): number {
  const value = Number(process.env[name] ?? fallback);
  if (!Number.isInteger(value) || value < 1024 || value > 65535) throw new Error(`Invalid ${name}`);
  return value;
}
export const localHost = "127.0.0.1";
export function allowOrigin(origin: string | undefined): boolean {
  if (!origin) return true; // Native collector has no browser Origin.
  try {
    const url = new URL(origin);
    const origins = (process.env.VALORANT_BROWSER_ORIGINS ?? "http://127.0.0.1:5322,http://localhost:5322").split(",");
    return origins.includes(url.origin) && ["127.0.0.1", "localhost"].includes(url.hostname);
  } catch { return false; }
}
