// language: Node CJS, file: tap.cjs, runtime: Spectra Client main process (Electron 37), target: Windows
// Nạp vào MAIN process bằng inspector rồi gắn vào đúng 2 lớp dữ liệu, không sửa binary/asar.
//   const tap = require('<đường dẫn>/tap.cjs'); tap.install();
// Lớp ra: ConnectorService.sendToIngest / sendToIngestAux  → chính là payload obs_data / aux_data.
// Lớp vào: GameEventsService.processInfoUpdate / processGameUpdate / processAuxUpdate → GEP raw.
// Không giữ secret: key / groupSecret bị che trước khi ghi ra pipe.
"use strict";

const net = require("node:net");
const Module = require("node:module");

const PIPE = process.env.RIOT_SPECTRA_PIPE || "\\\\.\\pipe\\riot-spectra-tap";
const MAX_QUEUE = 4096;
const SECRET_KEYS = new Set(["groupSecret", "password"]);

// GEP dùng trường "key" cho tên field, không phải secret. Chỉ che "key" trong payload đăng nhập.
const isAuthPayload = (value) =>
  typeof value?.clientVersion === "string" ||
  typeof value?.obsName === "string" ||
  typeof value?.groupSecret === "string";

let state = null;

function scrub(value, depth = 0) {
  if (depth > 8 || value === null || typeof value !== "object") return value;
  if (Array.isArray(value)) return value.map((v) => scrub(v, depth + 1));
  const auth = isAuthPayload(value);
  const out = {};
  for (const [k, v] of Object.entries(value))
    out[k] = SECRET_KEYS.has(k) || (auth && k === "key") ? "***" : scrub(v, depth + 1);
  return out;
}

function createChannel() {
  const queue = [];
  let socket = null;
  let ready = false;
  let dropped = 0;
  let connecting = false;

  const flush = () => {
    if (!ready || !socket) return;
    while (queue.length) {
      const line = queue.shift();
      if (!socket.write(line + "\n")) {
        queue.unshift(line);
        return;
      }
    }
  };

  const connect = () => {
    if (connecting || socket) return;
    connecting = true;
    const s = net.connect(PIPE);
    socket = s;
    s.on("connect", () => {
      connecting = false;
      ready = true;
      flush();
    });
    s.on("drain", flush);
    s.on("error", () => {
      ready = false;
      connecting = false;
    });
    s.on("close", () => {
      ready = false;
      connecting = false;
      socket = null;
      setTimeout(connect, 2000).unref?.();
    });
  };

  const send = (kind, channel, data) => {
    if (queue.length >= MAX_QUEUE) {
      queue.shift();
      dropped++;
    }
    try {
      queue.push(JSON.stringify({ t: Date.now(), k: kind, c: channel, d: scrub(data) }));
    } catch {
      return;
    }
    flush();
  };

  connect();
  return { send, stats: () => ({ dropped, queued: queue.length, ready }) };
}

function patchConnector(moduleExports, channel) {
  const Service = moduleExports && moduleExports.ConnectorService;
  if (!Service || !Service.prototype || Service.prototype.__riotTap) return false;
  const proto = Service.prototype;
  Object.defineProperty(proto, "__riotTap", { value: true, enumerable: false });

  const out = proto.sendToIngest;
  proto.sendToIngest = function (formatted) {
    channel.send("out", "obs_data", { obsName: this.OBS_NAME, groupCode: this.GROUP_CODE, ...formatted });
    return out.apply(this, arguments);
  };

  const outAux = proto.sendToIngestAux;
  proto.sendToIngestAux = function (formatted) {
    channel.send("out", "aux_data", {
      playerId: this.PLAYER_ID,
      matchId: this.MATCH_ID,
      ...formatted,
    });
    return outAux.apply(this, arguments);
  };
  return true;
}

function patchGep(moduleExports, channel) {
  const Service = moduleExports && (moduleExports.GameEventsService || moduleExports.default);
  if (!Service || !Service.prototype || Service.prototype.__riotTap) return false;
  const proto = Service.prototype;
  Object.defineProperty(proto, "__riotTap", { value: true, enumerable: false });
  for (const name of ["processInfoUpdate", "processGameUpdate", "processAuxUpdate"]) {
    const original = proto[name];
    if (typeof original !== "function") continue;
    proto[name] = function (data) {
      channel.send("gep", name.replace("process", "").toLowerCase(), data);
      return original.apply(this, arguments);
    };
  }
  return true;
}

function findModules() {
  const found = { connector: null, gep: null };
  for (const [file, mod] of Object.entries(require.cache)) {
    const normalized = file.replace(/\\/g, "/");
    if (normalized.endsWith("app/services/connectorService.js")) found.connector = mod;
    else if (normalized.endsWith("app/services/gepService.js")) found.gep = mod;
  }
  return found;
}

function install() {
  if (state) return { installed: true, already: true, pipes: state.channel.stats() };

  const channel = createChannel();
  state = { channel, patched: { connector: false, gep: false } };

  // Module đã được require từ trước khi ta gắn → vá thẳng từ require.cache.
  const patchCached = () => {
    const found = findModules();
    if (found.connector && !state.patched.connector) {
      state.patched.connector = patchConnector(found.connector.exports, channel);
    }
    if (found.gep && !state.patched.gep) {
      state.patched.gep = patchGep(found.gep.exports, channel);
    }
  };
  patchCached();
  setInterval(patchCached, 1000).unref();

  // Module nạp muộn (auxiliary, reload) → bắt ở cửa require.
  const originalLoad = Module._load;
  Module._load = function (request, parent, isMain) {
    const result = originalLoad.apply(this, arguments);
    try {
      if (typeof request === "string") {
        if (/(^|[\\/])connectorService(\.js)?$/.test(request) && !state.patched.connector) {
          state.patched.connector = patchConnector(result, channel);
        } else if (/(^|[\\/])gepService(\.js)?$/.test(request) && !state.patched.gep) {
          state.patched.gep = patchGep(result, channel);
        }
      }
    } catch {
      // im lặng: tap không được làm chết client
    }
    return result;
  };

  // Nhịp trạng thái: chứng minh tap sống và cho overlay biết Client còn kết nối.
  setInterval(() => {
    const found = findModules();
    const Service = found.connector && found.connector.exports.ConnectorService;
    const instance = Service && Service.instance;
    if (!instance) return;
    channel.send("status", "connector", {
      connected: !!instance.connected,
      unreachable: !!instance.unreachable,
      isAux: !!instance.IS_AUX,
      obsName: instance.OBS_NAME,
      groupCode: instance.GROUP_CODE,
      matchId: instance.MATCH_ID,
      ingest: instance.INGEST_SERVER_URL,
      patched: state.patched,
      ...channel.stats(),
    });
  }, 2000).unref();

  process.on("uncaughtException", (e) => {
    try {
      channel.send("status", "tap-error", { message: String(e && e.message) });
    } catch {}
  });

  return { installed: true, patched: state.patched, pipe: PIPE };
}

module.exports = { install, PIPE };
