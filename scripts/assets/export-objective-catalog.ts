import { mkdir, readFile, writeFile } from "node:fs/promises";
import { objectiveVisual } from "../../shared/ui-metrics";
import { objectiveIconUrl } from "../../shared/objective-icons";
const groups = [
  {
    title: "Hang rồng",
    ids: ["earth", "fire", "water", "air", "hextech", "chemtech", "elder", "dragon"],
  },
  { title: "Hang Baron", ids: ["grubs", "herald", "baron"] },
];
let rows = "";
for (const group of groups) {
  rows += `<tr class="group"><th colspan="3">${group.title}</th></tr>`;
  for (const id of group.ids) {
    const visual = objectiveVisual(id) ?? {
      label: "RỒNG · CHƯA XÁC ĐỊNH LOẠI",
      color: "#d2b47d",
    };
    const path = "public" + objectiveIconUrl(id);
    const bytes = await readFile(path);
    const mime = path.endsWith(".svg") ? "image/svg+xml" : "image/png";
    rows += `<tr class="objective" style="--glyph:url('data:${mime};base64,${bytes.toString("base64")}');--tint:${visual.color}">
      <th scope="row">${visual.label}<small>${id}</small></th>
      <td><span class="icon colored" role="img" aria-label="${visual.label} màu"></span><code>${visual.color.toUpperCase()}</code></td>
      <td><span class="icon white" role="img" aria-label="${visual.label} trắng"></span><code>#FFFFFF</code></td>
    </tr>`;
  }
}
const html = `<!doctype html>
<html lang="vi"><head><meta charset="utf-8"><meta name="viewport" content="width=device-width,initial-scale=1">
<title>Icon rồng &amp; hang Baron</title>
<style>
*{box-sizing:border-box}body{margin:0;background:#10171d;color:#e9eef2;font:15px/1.5 system-ui,sans-serif}
main{max-width:760px;margin:32px auto;padding:0 18px}h1{font-size:24px;margin:0 0 6px}p{color:#a5b5c1;margin:0 0 22px}
table{width:100%;border-collapse:collapse;background:#172129;border:1px solid #34424d}th,td{padding:12px 18px;text-align:left;border-bottom:1px solid #2d3b45}thead{color:#aabac6;font-size:13px}.group{background:#202e38;color:#c4d5e1}.group th{padding-block:9px;font-size:13px;text-transform:uppercase;letter-spacing:.08em}
th[scope=row]{font-size:13px;font-weight:600;width:46%}small{display:block;color:#8d9fac;font-weight:400;font-size:11px}td{text-align:center}.icon{display:block;width:44px;height:44px;margin:0 auto 5px;background:var(--tint);mask:var(--glyph) center/contain no-repeat;-webkit-mask:var(--glyph) center/contain no-repeat}.white{background:#fff}code{font-size:10px;color:#a6b5bf}footer{margin:18px 0;font-size:11px;color:#8d9fac}a{color:#a8cce0}
@media(max-width:480px){main{margin:18px auto;padding:0 10px}th,td{padding:10px 8px}th[scope=row]{font-size:11px}.icon{width:36px;height:36px}}
</style></head><body><main>
<h1>Icon rồng &amp; hang Baron</h1><p>Bản màu và bản trắng đang dùng trong overlay. File độc lập, mở offline; toàn bộ icon đã nhúng sẵn.</p>
<table aria-label="Các loại mục tiêu và icon"><thead><tr><th>Tên mục tiêu</th><th>Màu</th><th>Trắng</th></tr></thead><tbody>${rows}</tbody></table>
<footer>Bộ mix: sâu hư không từ bộ cũ, Baron từ baron.svg do người dùng cung cấp, Elder màu #1EE4DE theo ảnh mẫu. Các icon khác: artwork © Riot Games, texture16.20 qua <a href="https://raw.communitydragon.org/16.20/game/assets/ux/spectator/">CommunityDragon</a>. PNG/SVG alpha mask, không GenAI.</footer>
</main></body></html>`;
await mkdir("exports", { recursive: true });
const path = "exports/dragon-baron-icons.html";
await writeFile(path, html, "utf8");
console.log(
  JSON.stringify({
    path,
    bytes: Buffer.byteLength(html),
    objectives: groups.flatMap((g) => g.ids).length,
    externalAssets: 0,
  }),
);
