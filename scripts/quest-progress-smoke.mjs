import assert from "node:assert/strict";
import {createRequire} from "node:module";
import {readFile} from "node:fs/promises";
import {WebSocket} from "ws";
const base=process.env.OVERLAY_VISUAL_URL??"http://127.0.0.1:4393";
assert.match(base,/^http:\/\/127\.0\.0\.1:\d+$/);
assert.ok(!base.endsWith(":4310"),"Use isolated test server");
const id=process.env.OVERLAY_CAPTURE_ID??"2026-10-16T16-02-26-924Z";
const rows=(await readFile(`data/captures/${id}/observer-samples.ndjson`,"utf8")).trim().split(/\r?\n/).map(JSON.parse);
const start=Date.parse(rows[0].receivedAt);
const {chromium}=createRequire(import.meta.url)("C:/Users/Seotow/.cache/codex-runtimes/codex-primary-runtime/dependencies/node/node_modules/playwright");
const ws=new WebSocket(base.replace("http:","ws:")+"/ws?role=studio",{origin:base});
await new Promise((yes,no)=>{ws.once("open",yes);ws.once("error",no);});
const browser=await chromium.launch({channel:"msedge",headless:true});
try {
 const p=await browser.newPage({viewport:{width:1920,height:1080}});
 await p.goto(base+"/overlay?scene=ingame");
 const measured=[];
 for(const time of [120,400,600,780]) {
  const row=rows.find(r=>r.message.sample.gameTime.value>=time);
  const positionMs=Date.parse(row.receivedAt)-start;
  ws.send(JSON.stringify({type:"captureControl",playing:false,positionMs}));
  const expected=row.message.sample.players.filter(p=>!p.roleQuest?.value?.completed&&p.roleQuest?.value?.progress!=null).map(p=>Math.round(p.roleQuest.value.progress*100));
  await p.waitForFunction(expected=>JSON.stringify([...document.querySelectorAll(".row-lane-quest .quest-progress")].map(e=>Number(e.getAttribute("aria-label").match(/\d+/)[0])))===JSON.stringify(expected),expected);
  measured.push({time,progress:expected,completed:await p.locator(".row-lane-quest.completed").count()});
 }
 assert.ok(measured[2].progress.every(n=>n>0));
 assert.equal(measured[3].completed,3);
 assert.ok(measured[1].progress.some(n=>n>0&&n<100));
 await p.waitForTimeout(1600); // Allow entry motion/assets to settle for the still image.
 await p.screenshot({path:".npm-cache/visual-audit/quest-progress-real.png",omitBackground:true});
 console.log(JSON.stringify({pass:true,measured}));
} finally {ws.close();await browser.close();}
