// Xem frame của tap mà không cần build overlay host.
// Chế độ mặc định: tự mở named pipe làm server rồi chờ tap nối vào.
// Nếu pipe đã có server (overlay host đang chạy) thì chuyển sang nối như client.
//   node collector/hosts/valorant-collector/client/tap/watch.mjs
//   node .../watch.mjs --raw
//   node .../watch.mjs --only obs,gep
//   node .../watch.mjs --raw --max-mb 0     (không giới hạn)
//
// AN TOÀN Ổ ĐĨA: chế độ --raw ghi mọi payload ra stdout, khi chuyển hướng vào file sẽ phình rất nhanh
// (từng làm đầy ổ C: với hàng chục GB). Vì vậy watcher tự đếm số byte đã in và dừng in khi vượt giới
// hạn (mặc định 64 MB), nhưng KHÔNG thoát: pipe vẫn mở để tap không bị ngắt. Dùng --max-mb 0 khi thật
// sự muốn ghi không giới hạn.
import net from "node:net";

const pipe = process.env.RIOT_SPECTRA_PIPE || "\\\\.\\pipe\\riot-spectra-tap";
const raw = process.argv.includes("--raw");
const onlyArg = process.argv.indexOf("--only");
const only = onlyArg >= 0 ? new Set(process.argv[onlyArg + 1].split(",")) : null;
const maxArg = process.argv.indexOf("--max-mb");
const maxBytes =
  (maxArg >= 0 ? Number(process.argv[maxArg + 1]) : 64) * 1024 * 1024; // 0 = không giới hạn

const counts = new Map();
const started = Date.now();
let printed = 0;
let truncated = false;

// In một dòng và cộng dồn số byte. Trả false khi đã chạm giới hạn (ngừng in từ đó).
function emit(line) {
  if (truncated) return;
  if (maxBytes > 0 && printed >= maxBytes) {
    truncated = true;
    console.error(
      `\n[watch] Đã đạt giới hạn ${(maxBytes / 1048576).toFixed(0)} MB — ngừng in để không đầy ổ.` +
        `\n[watch] Pipe vẫn mở nên tap không bị ngắt. Chạy lại với --max-mb <n> để đổi giới hạn.`,
    );
    return;
  }
  process.stdout.write(`${line}\n`);
  printed += Buffer.byteLength(line, "utf8") + 1;
}

const summarize = (frame) => {
  const data = frame.d;
  if (data === null || data === undefined) return "(rỗng)";
  if (typeof data !== "object") return String(data).slice(0, 80);
  const type = data.type ? `type=${data.type} ` : "";
  const key = data.key ? `key=${data.key} ` : "";
  if (data.data && typeof data.data === "object") return `${type}${key}fields=${Object.keys(data.data).join(",")}`;
  if (data.value !== undefined) return `${type}${key}value=${String(data.value).slice(0, 120)}`;
  return `${type}${key}${Object.keys(data).slice(0, 10).join(",")}`;
};

// Buffer theo từng kết nối: dòng có thể bị cắt giữa hai chunk.
function attach(socket, label) {
  let buffer = "";
  socket.setEncoding("utf8");
  emit(`${label} ${pipe}`);
  socket.on("data", (chunk) => {
    buffer += chunk;
    let nl;
    while ((nl = buffer.indexOf("\n")) >= 0) {
      const line = buffer.slice(0, nl);
      buffer = buffer.slice(nl + 1);
      if (!line.trim()) continue;
      let frame;
      try {
        frame = JSON.parse(line);
      } catch {
        continue;
      }
      if (only && !only.has(frame.k)) continue;
      const id = `${frame.k}/${frame.c}`;
      const n = (counts.get(id) ?? 0) + 1;
      counts.set(id, n);
      const at = ((Date.now() - started) / 1000).toFixed(1);
      if (raw) emit(`${at}s ${id} ${JSON.stringify(frame.d)}`);
      else emit(`${at}s #${n} ${id} ${summarize(frame)}`);
    }
  });
  socket.on("close", () => emit("kết nối đóng — tap sẽ nối lại"));
  socket.on("error", (e) => emit(`lỗi socket: ${e.code}`));
}

const server = net.createServer((socket) => attach(socket, "tap đã nối →"));
server.on("error", (e) => {
  if (e.code === "EADDRINUSE") {
    attach(net.connect(pipe), "đã có server, nối vào →");
    return;
  }
  console.error(`Không mở được pipe: ${e.code}`);
  process.exit(1);
});
server.listen(pipe, () =>
  emit(
    `đang chờ tap trên ${pipe} (Ctrl+C để dừng, giới hạn ${
      maxBytes > 0 ? `${(maxBytes / 1048576).toFixed(0)} MB` : "không giới hạn"
    })`,
  ),
);

process.on("SIGINT", () => {
  console.log(
    `\nĐã in ${(printed / 1048576).toFixed(1)} MB${truncated ? " (đã ngắt vì chạm giới hạn)" : ""}.`,
  );
  console.log("Tổng frame theo loại:");
  for (const [id, n] of [...counts].sort((a, b) => b[1] - a[1])) console.log(`  ${id}  ${n}`);
  server.close();
  process.exit(0);
});
