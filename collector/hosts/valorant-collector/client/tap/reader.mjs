// Đọc frame NDJSON của tap: tự mở named pipe làm server; nếu pipe đã có server (overlay host,
// watcher khác) thì nối vào như client. Dùng chung cho player UI và các script xem log.
import net from "node:net";

export const defaultPipe = "\\\\.\\pipe\\riot-spectra-tap";

/**
 * onFrame(frame) nhận { t, k, c, d } của tap. onState({ pipe, mode, error }) báo đang làm server
 * hay client. Trả { mode, close() }.
 */
export function startTapReader({ pipe = process.env.RIOT_SPECTRA_PIPE || defaultPipe, onFrame, onState = () => {} } = {}) {
  let closed = false;
  let server = null;
  let client = null;

  const attach = (socket, mode) => {
    let buffer = "";
    socket.setEncoding("utf8");
    onState({ pipe, mode, error: null });
    socket.on("data", (chunk) => {
      buffer += chunk;
      let newline;
      while ((newline = buffer.indexOf("\n")) >= 0) {
        const line = buffer.slice(0, newline).trim();
        buffer = buffer.slice(newline + 1);
        if (!line) continue;
        try {
          onFrame(JSON.parse(line));
        } catch {
          // Dòng hỏng: bỏ qua, không làm chết reader.
        }
      }
    });
    socket.on("error", (error) => onState({ pipe, mode, error: error.code || String(error) }));
    socket.on("close", () => onState({ pipe, mode: "closed", error: null }));
  };

  const connectAsClient = () => {
    client = net.connect(pipe);
    client.on("error", (error) => onState({ pipe, mode: "client", error: error.code || String(error) }));
    client.on("connect", () => attach(client, "client"));
  };

  return new Promise((resolve) => {
    server = net.createServer((socket) => attach(socket, "server"));
    server.on("error", (error) => {
      if (error.code === "EADDRINUSE") {
        connectAsClient();
        resolve({ mode: "client", close: () => void closeAll() });
        return;
      }
      onState({ pipe, mode: "error", error: error.code || String(error) });
      resolve({ mode: "error", close: () => void closeAll() });
    });
    server.listen(pipe, () => resolve({ mode: "server", close: () => void closeAll() }));
  });

  function closeAll() {
    if (closed) return;
    closed = true;
    try {
      client?.destroy();
    } catch {}
    try {
      server?.close();
    } catch {}
  }
}
