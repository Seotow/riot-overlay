import { z } from "zod";

// Postgame Valorant. Hai nguồn: Spectra (tự động, chỉ có K/D/A, agent, tỉ số) và Henrik Dev API
// (đủ ACS, damage, first kill, KAST, thời lượng nhưng cần Riot ID và API key của người dùng).

export const postgameRegions = ["ap", "eu", "na", "kr", "latam", "br"] as const;

export const postgameFonts = ["Tungsten", "Arial", "Impact", "Tahoma"] as const;
const color = z.string().regex(/^#[0-9a-fA-F]{6}$/);
const opacity = z.number().min(0).max(1);

export const postgameConfigSchema = z.object({
  name: z.string().trim().max(32),
  tag: z.string().trim().max(10),
  region: z.enum(postgameRegions),
  platform: z.enum(["pc", "console"]),
  hidePlayerTag: z.boolean(),
  primaryColor: color,
  primaryOpacity: opacity,
  cellColor: color,
  cellOpacity: opacity,
  cell2Color: color,
  cell2Opacity: opacity,
  headerBgColor: color,
  headerBgOpacity: opacity,
  headerTextColor: color,
  bodyTextColor: color,
  fontFamily: z.enum(postgameFonts),
  overlayBgColor: color,
  overlayBgOpacity: opacity,
  /** Ảnh nền và ảnh nhà tài trợ mặc định kèm theo theme gốc. */
  useDefaultBg: z.boolean(),
  useDefaultSponsor: z.boolean(),
});
export type PostgameConfig = z.infer<typeof postgameConfigSchema>;

export const defaultPostgameConfig: PostgameConfig = {
  name: "",
  tag: "",
  region: "ap",
  platform: "pc",
  // Theme mặc định lấy nguyên từ overlay-config.json của valorant-postgame-stats.
  hidePlayerTag: true,
  primaryColor: "#39f1fe",
  primaryOpacity: 0.78,
  cellColor: "#000000",
  cellOpacity: 0.37,
  cell2Color: "#000000",
  cell2Opacity: 0.37,
  headerBgColor: "#000000",
  headerBgOpacity: 0.38,
  headerTextColor: "#ffffff",
  bodyTextColor: "#ffffff",
  fontFamily: "Tungsten",
  overlayBgColor: "#000000",
  overlayBgOpacity: 1,
  useDefaultBg: true,
  useDefaultSponsor: true,
};

/** PUT: `apiKey` chỉ gửi khi người dùng nhập mới (`""` = xóa, bỏ trống = giữ nguyên). */
export const postgameSaveSchema = z.object({
  config: postgameConfigSchema,
  apiKey: z.string().trim().max(100).optional(),
});

export const postgameSelectSchema = z.discriminatedUnion("source", [
  z.object({ source: z.literal("spectra") }),
  z.object({ source: z.literal("henrik"), matchId: z.string().regex(/^[0-9a-fA-F-]{20,64}$/) }),
]);
export type PostgameSelection = z.infer<typeof postgameSelectSchema>;

export interface PostgameHistoryItem {
  matchId: string;
  map: string;
  queue: string;
  startedAt: string | null;
  won: boolean | null;
  score: string;
  agent: string;
}

export interface PostgameSnapshotInfo {
  map: string | null;
  score: [number, number];
  players: number;
  final: boolean;
  capturedAt: string;
}

export interface PostgameStatus {
  config: PostgameConfig;
  hasApiKey: boolean;
  selection: PostgameSelection | null;
  spectra: PostgameSnapshotInfo | null;
  /** Số liệu mà từng nguồn cung cấp, để UI nói rõ cái gì sẽ hiện "—". */
  coverage: { spectra: string[]; henrik: string[]; missingFromSpectra: string[] };
}

export type PostgameHistoryResult =
  | { ok: true; name: string; tag: string; matches: PostgameHistoryItem[] }
  | { ok: false; error: PostgameError };

export type PostgameError =
  | "not-configured"
  | "no-api-key"
  | "unauthorized"
  | "not-found"
  | "rate-limited"
  | "network"
  | "bad-response";

export const postgameErrorText: Record<PostgameError, string> = {
  "not-configured": "Chưa nhập Riot ID (tên và tag).",
  "no-api-key": "Chưa có API key Henrik Dev.",
  unauthorized: "API key bị từ chối. Kiểm tra lại key.",
  "not-found": "Không tìm thấy tài khoản hoặc trận.",
  "rate-limited": "Henrik Dev giới hạn tần suất, thử lại sau ít phút.",
  network: "Không kết nối được Henrik Dev (kiểm tra mạng).",
  "bad-response": "Henrik Dev trả dữ liệu không đọc được.",
};

/** Dữ liệu overlay: số liệu không có nguồn là `null`, overlay hiển thị "—". */
export interface PostgameRow {
  agent: string;
  name: string;
  kills: number;
  acs: number | null;
  icon: string;
}
export interface PostgameRender {
  empty: boolean;
  source: "spectra" | "henrik" | null;
  version: string;
  style: PostgameStyle;
  match: {
    leftTeamName: string;
    rightTeamName: string;
    leftTeamLogo: string;
    rightTeamLogo: string;
    leagueLogo: string;
    leftScore: number;
    rightScore: number;
    leftResult: string;
    rightResult: string;
    mapName: string;
    queueName: string;
    duration: string;
    mapImageLeft: string;
  };
  mvp: Record<"left" | "right", PostgameMvpCard>;
  rows: Record<"left" | "right", PostgameRow[]>;
}
export type PostgameStyle = Omit<
  PostgameConfig,
  "name" | "tag" | "region" | "platform" | "hidePlayerTag"
> & {
  overlayBg: string;
  sponsorImage: string;
};
export interface PostgameMvpCard {
  agent: string;
  name: string;
  kills: number;
  deaths: number;
  acs: number | null;
  portrait: string;
}
export interface PostgameMvpFull {
  empty: boolean;
  name: string;
  agentName: string;
  agentId: string;
  teamName: string;
  teamLogo: string;
  acs: number | null;
  kills: number;
  deaths: number;
  assists: number;
  damagePerRound: number | null;
  firstKillPct: number | null;
  kastPct: number | null;
  version: string;
  style: PostgameStyle;
}
