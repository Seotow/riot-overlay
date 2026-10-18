// Dựng module Valorant trên máy mới (Studio cũng tự chạy các bước này khi bật kết nối lần đầu).
// Thêm --force để chạy lại mọi bước. Xem collector/hosts/valorant-collector/runtime/setup.mjs.
import { resolve } from "node:path";
import { fileURLToPath, pathToFileURL } from "node:url";

const root = resolve(fileURLToPath(import.meta.url), "../../..");
const { runSetup } = await import(
  pathToFileURL(resolve(root, "collector/hosts/valorant-collector/runtime/setup.mjs")).href
);
const ran = await runSetup({
  force: process.argv.includes("--force"),
  onStep: (label) => console.log(`\n▶ ${label}`),
  log: (line) => console.log(`  ${line}`),
});
console.log(
  ran === 0
    ? "\nMọi bước đã xong từ trước."
    : "\nXong. Chạy `npm run build && npm start`, chọn Valorant và bật công tắc kết nối trong Studio.",
);
