// Tham số hiển thị tùy chọn trên URL overlay. Giá trị sai bị bỏ qua, không ảnh hưởng dữ liệu trận.
const read = (name: string) => new URLSearchParams(globalThis.location?.search ?? "").get(name);

/** Màu hex 3 hoặc 6 ký tự (có hoặc không có #); trả null nếu không hợp lệ. */
export function overlayColorParam(name: string): string | null {
  const v = read(name)?.replace(/^#/, "");
  return v && /^([0-9a-f]{3}|[0-9a-f]{6})$/i.test(v) ? `#${v}` : null;
}

/** Số trong [min, max]; trả 0 nếu thiếu hoặc không hợp lệ. */
export function overlayNumberParam(name: string, min: number, max: number): number {
  const n = Number(read(name));
  return Number.isFinite(n) ? Math.min(max, Math.max(min, n)) : 0;
}
