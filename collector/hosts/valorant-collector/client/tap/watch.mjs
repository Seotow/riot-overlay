// Xem frame của tap mà không cần build overlay host.
// Chế độ mặc định: tự mở named pipe làm server rồi chờ tap nối vào.
// Nếu pipe đã có server (overlay host đang chạy) thì chuyển sang nối như client.
//   node collector/hosts/valorant-collector/client/tap/watch.mjs
//   node .../watch.mjs --raw
//   node .../watch.mjs --only obs,gep
import net from "node:net";

const pipe = process.env.RIOT_SPECTRA_PIPE || "\\\\.\\pipe\\riot-spectra-tap";
const raw = process.argv.includes("--raw");
const onlyArg = process.argv.indexOf("--only");
const only = onlyArg >= 0 ? new Set(process.argv[onlyArg + 1].split(",")) : null;

const counts = new Map();
const started = Date.now();

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
  console.log(`${label} ${pipe}`);
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
      if (raw) console.log(`${at}s ${id} ${JSON.stringify(frame.d)}`);
      else console.log(`${at}s #${n} ${id} ${summarize(frame)}`);
    }
  });
  socket.on("close", () => console.log("kết nối đóng — tap sẽ nối lại"));
  socket.on("error", (e) => console.log(`lỗi socket: ${e.code}`));
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
server.listen(pipe, () => console.log(`đang chờ tap trên ${pipe} (Ctrl+C để dừng)`));

process.on("SIGINT", () => {
  console.log("\nTổng frame theo loại:");
  for (const [id, n] of [...counts].sort((a, b) => b[1] - a[1])) console.log(`  ${id}  ${n}`);
  server.close();
  process.exit(0);
});
