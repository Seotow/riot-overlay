// Chuyển tiếp TCP thuần: mở cổng LAN rồi nối vào ingest chỉ nghe loopback của module Valorant.
// Dùng khi máy player ở cùng LAN mà chưa bật tunnel cloudflared của Studio. Không sửa backend.
//   node scripts/dev/valo-ingest-relay.mjs --listen 5399 --target 5310
import net from "node:net";

const arg = (name, fallback) => {
  const i = process.argv.indexOf(`--${name}`);
  return i >= 0 ? Number(process.argv[i + 1]) : fallback;
};

const listenPort = arg("listen", 5399);
const targetPort = arg("target", 5310);

const server = net.createServer((client) => {
  const upstream = net.connect(targetPort, "127.0.0.1");
  client.pipe(upstream);
  upstream.pipe(client);
  const close = () => {
    client.destroy();
    upstream.destroy();
  };
  client.on("error", close);
  upstream.on("error", close);
  client.on("close", close);
  upstream.on("close", close);
});

server.on("error", (error) => {
  console.error(`relay lỗi: ${error.code} ${error.message}`);
  process.exit(1);
});

server.listen(listenPort, "0.0.0.0", () => {
  console.log(`relay 0.0.0.0:${listenPort} → 127.0.0.1:${targetPort}`);
});
