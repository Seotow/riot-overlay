// Đọc bản Spectra Client đã tải (không chạy nó) và xuất contract runtime ra JSON.
// Mục đích: biết chính xác binary đang nói gì thay vì suy từ source fork.
//   node scripts/inspect/spectra-client.mjs
//   node scripts/inspect/spectra-client.mjs --exe "D:\path\Spectra Client.exe"
import { readFileSync, writeFileSync, mkdirSync, existsSync } from "node:fs";
import { dirname, resolve, join } from "node:path";
import { fileURLToPath } from "node:url";

const here = dirname(fileURLToPath(import.meta.url));
const workspace = resolve(here, "../..");
const clientDir = resolve(workspace, "collector/hosts/valorant-collector/client");
const localDir = resolve(workspace, "collector/hosts/valorant-collector/local");

const arg = (name) => {
  const i = process.argv.indexOf(`--${name}`);
  return i >= 0 ? process.argv[i + 1] : undefined;
};

const release = JSON.parse(readFileSync(resolve(clientDir, "release.json"), "utf8"));
const exe =
  arg("exe") ?? resolve(localDir, "spectra", release.tag.replace(/^v/, ""), release.executable);
const asarPath = resolve(dirname(exe), "resources/app.asar");
const outPath = arg("out") ?? resolve(localDir, "spectra-contract.json");

if (!existsSync(exe)) {
  console.error(`Không thấy Spectra Client tại ${exe}`);
  console.error("Chạy npm run valorant:setup trước, hoặc truyền --exe.");
  process.exit(1);
}

// Fuse box: sentinel + version + count + N byte '0'/'1'. Cho biết NODE_OPTIONS/--inspect còn dùng được.
const FUSE_SENTINEL = Buffer.from("dL7pKGdnNz796PbbjQWNKmHXBZaB9tsX");
const FUSE_NAMES = [
  "RunAsNode",
  "EnableCookieEncryption",
  "EnableNodeOptionsEnvironmentVariable",
  "EnableNodeCliInspectArguments",
  "EnableEmbeddedAsarIntegrityValidation",
  "OnlyLoadAppFromAsar",
  "LoadBrowserProcessSpecificV8Snapshot",
  "GrantFileProtocolExtraPrivileges",
];

function readFuses(buffer) {
  const at = buffer.indexOf(FUSE_SENTINEL);
  if (at < 0) return null;
  const start = at + FUSE_SENTINEL.length;
  const version = buffer[start];
  const count = buffer[start + 1];
  const bytes = buffer.subarray(start + 2, start + 2 + count);
  const fuses = {};
  FUSE_NAMES.forEach((name, i) => {
    if (i >= count) return;
    const v = bytes[i];
    fuses[name] = v === 0x31 ? "enabled" : v === 0x30 ? "disabled" : `0x${v.toString(16)}`;
  });
  return { version, count, fuses };
}

// ASAR: [u32 4][u32 header_pickle_size][u32 json_len][json][...data]
function readAsar(buffer) {
  const jsonSize = buffer.readUInt32LE(12);
  const header = JSON.parse(buffer.subarray(16, 16 + jsonSize).toString("utf8"));
  const base = 8 + buffer.readUInt32LE(4);
  const files = [];
  const walk = (node, prefix) => {
    for (const [name, value] of Object.entries(node.files ?? {})) {
      const path = prefix ? `${prefix}/${name}` : name;
      if (value.files) walk(value, path);
      else
        files.push({
          path,
          size: value.size ?? 0,
          unpacked: !!value.unpacked,
          read: () =>
            buffer.subarray(base + Number(value.offset), base + Number(value.offset) + value.size),
        });
    }
  };
  walk(header, "");
  return files;
}

const matches = (text, re) => [...text.matchAll(re)].map((m) => m.slice(1));

function objectKeysAfter(text, marker) {
  const at = text.indexOf(marker);
  if (at < 0) return [];
  const body = text.slice(at, text.indexOf("\n        };", at));
  return matches(body, /^\s{12}(\w+):/gm).map((m) => m[0]);
}

const exeBuffer = readFileSync(exe);
const asar = readFileSync(asarPath);
const files = readAsar(asar);
const appFiles = files.filter((f) => f.path.startsWith("app/") && !f.unpacked);
const read = (path) => {
  const hit = appFiles.find((f) => f.path === path);
  return hit ? hit.read().toString("utf8") : "";
};

const formatting = read("app/services/formattingService.js");
const connector = read("app/services/connectorService.js");
const gep = read("app/services/gepService.js");
const preload = read("app/preload.js");
const main = read("app/main.js");

const contract = {
  generatedAt: new Date().toISOString(),
  release: {
    tag: release.tag,
    exeSha256: release.executableSha256,
    asarSha256: release.asarSha256,
  },
  fuses: readFuses(exeBuffer),
  asar: {
    totalFiles: files.length,
    appFiles: appFiles.map((f) => ({ path: f.path, size: f.size })),
    rendererBundle:
      appFiles.find((f) => /frontend\/browser\/main-.*\.js$/.test(f.path))?.path ?? null,
  },
  sockets: {
    client: matches(formatting, /SocketChannels\["(\w+)"\] = "([^"]+)"/g).map(([k, v]) => ({
      key: k,
      value: v,
    })),
    defaultIngest: matches(connector, /INGEST_SERVER_URL = "([^"]+)"/g)[0]?.[0] ?? null,
  },
  dataTypes: matches(formatting, /DataTypes\["(\w+)"\] = "([^"]+)"/g).map(([k, v]) => ({
    key: k,
    value: v,
  })),
  gep: {
    gameId: matches(gep, /VALORANT_ID = (\d+)/g)[0]?.[0] ?? null,
    infoKeys: [...new Set(matches(gep, /case "([a-z_0-9]+)":/g).map((m) => m[0]))],
    events: matches(gep, /gepApi\.on\("([a-z-]+)"/g).map((m) => m[0]),
  },
  payloads: {
    scoreboard: objectKeysAfter(formatting, "const formatted = {\n            name: nameSplit[0]"),
    killfeed: objectKeysAfter(formatting, "const formatted = {\n            attacker:"),
    roster: objectKeysAfter(
      formatting,
      "const formatted = {\n            name: nameSplit[0],\n            tagline: nameSplit[1] ?",
    ),
  },
  ipc: {
    rendererToMain: [
      ...new Set(matches(preload, /ipcRenderer\.send\("([^"]+)"/g).map((m) => m[0])),
    ],
    mainToRenderer: [...new Set(matches(preload, /ipcRenderer\.on\("([^"]+)"/g).map((m) => m[0]))],
    mainHandlers: [...new Set(matches(main, /ipcMain\.on\("([^"]+)"/g).map((m) => m[0]))],
  },
  window: {
    webPreferences: (() => {
      const block = main.match(/webPreferences: \{([\s\S]{0,320}?)\}/);
      if (!block) return [];
      return block[1]
        .split(/,\s*\n/)
        .map((s) => s.trim())
        .filter(Boolean);
    })(),
  },
};

mkdirSync(dirname(outPath), { recursive: true });
writeFileSync(outPath, JSON.stringify(contract, null, 2));

const line = (label, value) => console.log(`${label.padEnd(22)} ${value}`);
console.log(`Spectra Client ${release.tag}`);
console.log(outPath);
line("asar", `${(asar.length / 1048576).toFixed(1)} MB, ${files.length} file`);
line("fuse NODE_OPTIONS", contract.fuses?.fuses.EnableNodeOptionsEnvironmentVariable ?? "?");
line("fuse --inspect", contract.fuses?.fuses.EnableNodeCliInspectArguments ?? "?");
line("game id GEP", contract.gep.gameId ?? "?");
line("socket kênh", contract.sockets.client.map((s) => s.value).join(", ") || "?");
line("kiểu dữ liệu", String(contract.dataTypes.length));
line("GEP key", contract.gep.infoKeys.join(", "));
line("IPC", contract.ipc.mainHandlers.join(", "));
