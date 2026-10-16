import { createRequire } from "node:module";
import { resolve } from "node:path";
const sharp = createRequire(import.meta.url)(
  resolve(process.env.OVERLAY_BROWSER_PACKAGES, "sharp"),
);
// QA-only backdrop: game-only crop excludes broadcast scoreboard, timers, player panel and cameras.
// This image demonstrates transparency, not matching telemetry or a pixel-perfect audit.
const backdrop = await sharp("images/ingame new.png")
  .extract({ left: 360, top: 150, width: 1200, height: 600 })
  .resize(1920, 1080)
  .png()
  .toBuffer();
await sharp(backdrop)
  .composite([
    { input: ".npm-cache/visual-audit/ingame-translucent-preview.png" },
  ])
  .png()
  .toFile(".npm-cache/visual-audit/ingame-opacity-calibrated.png");
console.log(
  "PASS: illustrative opacity preview on game-only crop, no reference HUD in backdrop",
);
