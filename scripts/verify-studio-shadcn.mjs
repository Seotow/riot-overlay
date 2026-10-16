import {createRequire} from 'node:module';import{resolve}from'node:path';import{readFile,writeFile,mkdir}from'node:fs/promises';import assert from'node:assert/strict';import{WebSocket}from'ws';
const require=createRequire(import.meta.url),{chromium}=require(resolve(process.env.OVERLAY_BROWSER_PACKAGES,'playwright'));
const base='http://127.0.0.1:4393',id='2026-10-16T19-49-29-104Z',out=resolve('.npm-cache/studio-shadcn-qa');await mkdir(out,{recursive:true});
const ws=new WebSocket(base.replace('http','ws')+'/ws',{origin:base});let state;ws.on('message',b=>{const m=JSON.parse(b);if(m.type==='snapshot')state=m.state;});await new Promise((r,j)=>{ws.once('open',r);ws.once('error',j);});
const pause=ms=>new Promise(r=>setTimeout(r,ms)),send=c=>ws.send(JSON.stringify(c));
async function until(fn){for(let i=0;i<200;i++){if(await fn())return;await pause(100);}throw Error('Timeout');}
const browser=await chromium.launch({headless:true,channel:'msedge'}),errors=[],results=[];
try{
 await until(()=>state);send({type:'theme',value:JSON.parse(await readFile('data/theme.json','utf8'))});send({type:'captureLoad',id});
 await until(async()=> (await(await fetch(base+'/api/providers')).json()).recording.id===id);
 send({type:'captureControl',playing:false,positionMs:461015});send({type:'scene',value:'ingame'});
 const page=await browser.newPage({viewport:{width:1440,height:1000}});page.on('pageerror',e=>errors.push(e.message));
 for(const route of ['overview','theme','sources','studio','demo','draft','postgame','hud']){
  await page.goto(base+'/?page='+route);await page.locator('.studio-shell').waitFor();await page.evaluate(()=>document.fonts.ready);await pause(500);
  const m=await page.evaluate(()=>({title:document.querySelector('h1').textContent,buttons:document.querySelectorAll('[data-slot=button]').length,overflow:document.documentElement.scrollWidth>innerWidth,text:document.querySelector('.studio-shell').innerText}));
  assert.ok(m.buttons>0);assert.ok(!m.overflow,route+' horizontal overflow');
  assert.ok(!/[—·]/.test(m.text),route+' unwanted punctuation');
  await page.screenshot({path:resolve(out,`${route}.png`),fullPage:true});results.push({route,title:m.title,buttons:m.buttons});
 }
 await page.goto(base+'/?page=studio');await page.locator('.operator-card').first().waitFor();
 const card=page.locator('.operator-card').filter({hasText:'Leaderboard vàng'});await card.getByRole('button').click();
 await until(()=>state.broadcast?.gold===true);assert.equal(await card.getByRole('button').getAttribute('aria-pressed'),'true');
 await card.getByRole('button').click();await until(()=>state.broadcast?.gold===false);
 await page.goto(base+'/?page=theme');const name=page.getByLabel('Tên giải',{exact:true});await name.fill('Studio QA');
 await page.getByRole('button',{name:'Lưu cấu hình',exact:true}).click();await until(()=>state.theme.tournament==='Studio QA');
 await page.goto(base+'/?page=demo');await page.getByLabel('Bộ dữ liệu thật',{exact:true}).selectOption(id);
 await page.getByRole('button',{name:'Tải bản ghi',exact:true}).click();await page.getByRole('button',{name:'Phát bản ghi',exact:true}).waitFor();
 await page.getByRole('button',{name:'Phát bản ghi',exact:true}).click();await pause(1100);await page.getByRole('button',{name:'Tạm dừng bản ghi',exact:true}).click();
 const p=(await(await fetch(base+'/api/providers')).json()).recording;assert.ok(p.positionMs>0);assert.equal(p.playing,false);
 await page.setViewportSize({width:900,height:1000});await page.goto(base+'/?page=studio');await pause(700);assert.ok(await page.evaluate(()=>document.documentElement.scrollWidth<=innerWidth));await page.screenshot({path:resolve(out,'studio-900.png'),fullPage:true});
 await page.setViewportSize({width:1920,height:1080});await page.goto(base+'/overlay?scene=ingame');await pause(700);
 assert.equal(await page.locator('.studio-shell').count(),0);assert.equal(await page.locator('.canvas').count(),1);
 assert.equal(await page.evaluate(()=>getComputedStyle(document.body).backgroundColor),'rgba(0, 0, 0, 0)');
 assert.deepEqual(errors,[]);await writeFile(resolve(out,'report.json'),JSON.stringify({results,errors,recordingPlayback:true,configSave:true,widgetToggle:true,overlayTransparent:true},null,2));
 console.log(JSON.stringify({pass:true,routes:results.length,errors,controls:['gold','config','recording'],overlayTransparent:true}));
}finally{ws.close();await browser.close();}
