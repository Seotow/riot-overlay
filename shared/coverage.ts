import type { IngameSample } from "./observer";
import { sourceNames } from "./providers";

export function sourceCoverage(sample: IngameSample | null) {
  const rows: {
    id: string;
    title: string;
    available: number;
    expected: number;
    sources: string[];
    note: string;
  }[] = [];
  const add = (
    id: string,
    title: string,
    fields: ({ value: unknown; source: string } | undefined)[],
    expected: number,
    note: string,
  ) => {
    const available = fields.filter((f) => f?.value != null);
    rows.push({
      id,
      title,
      available: available.length,
      expected,
      sources: [
        ...new Set(available.map((f) => sourceNames[f!.source] ?? f!.source)),
      ],
      note: available.length === expected ? "" : note,
    });
  };
  for (const [key, title] of [
    ["championId", "Tướng"],
    ["kills", "Kills"],
    ["deaths", "Deaths"],
    ["assists", "Assists"],
    ["level", "Cấp độ"],
    ["cs", "CS"],
    ["inventory", "Trang bị"],
    ["spells", "Phép bổ trợ"],
    ["totalGold", "Tổng vàng cá nhân"],
    ["health", "HP"],
    ["resource", "Năng lượng"],
    ["keystone", "Ngọc"],
    ["wardScore", "Điểm tầm nhìn"],
    ["respawnSeconds", "Hồi sinh"],
    ["hasBaron", "Buff Baron"],
    ["cooldowns", "Cooldown trang bị / kỹ năng"],
  ] as const) {
    add(
      key,
      title,
      sample?.players.map((p) => p[key]) ?? [],
      10,
      key === "resource"
        ? "Có thể gồm tướng không dùng năng lượng hoặc nguồn không cung cấp."
        : "Nguồn chưa cung cấp đủ dữ liệu; giữ trống.",
    );
  }
  for (const [key, title] of [
    ["kills", "Kills theo đội"],
    ["totalGold", "Vàng theo đội"],
    ["towers", "Trụ đã phá"],
    ["dragons", "Rồng đã hạ"],
  ] as const) {
    add(
      `team-${key}`,
      title,
      sample?.teams?.map((t) => t[key]) ?? [],
      2,
      key === "dragons" && sample?.eventCoverage
        ? "Riot có thể bỏ sót DragonKill trong spectator. Không coi thiếu sự kiện là 0 rồng."
        : key === "towers" && sample?.eventCoverage
          ? "Cần lịch sử sự kiện liên tục từ đầu trận và mã trụ hợp lệ."
          : "Nguồn chưa cung cấp đủ dữ liệu.",
    );
  }
  add(
    "objective-timers",
    "Timer Baron / Rồng",
    sample?.pitTimers?.map((t) => t.timeAlive) ?? [],
    2,
    "Chưa có mốc thời gian đáng tin cậy từ nguồn. Không tự tạo timer.",
  );
  add(
    "inhibitors",
    "Danh sách nhà lính đang hồi sinh",
    [sample?.inhibitors],
    1,
    "Chưa có dữ liệu nhà lính; danh sách trống có dữ liệu nghĩa là không có timer đang chạy.",
  );
  return rows;
}
