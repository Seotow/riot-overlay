import test from "node:test";
import assert from "node:assert/strict";
import { readFileSync } from "node:fs";
import { createElement } from "react";
import { renderToStaticMarkup } from "react-dom/server";
import { Button } from "../src/components/ui/button";
import { NativeSelect } from "../src/components/ui/native-select";
import { SourcePanel, Dashboard } from "../src/Dashboard";
import { MatchConfig } from "../src/Production";
import { createState } from "../shared/mock";
test("shadcn primitives preserve native disabled, pressed and label semantics", () => {
  const b = renderToStaticMarkup(
    createElement(Button, { disabled: true, "aria-pressed": true }, "Hiển thị"),
  );
  assert.match(b, /data-slot="button"/);
  assert.match(b, /disabled=""/);
  assert.match(b, /aria-pressed="true"/);
  const s = renderToStaticMarkup(
    createElement(
      NativeSelect,
      { "aria-label": "Nguồn trận đấu", disabled: true },
      createElement("option", { value: "recording" }, "Bản ghi"),
    ),
  );
  assert.match(s, /data-slot="native-select"/);
  assert.match(s, /aria-label="Nguồn trận đấu"/);
});
test("Studio source and overview use real status, not research filler", () => {
  const props = {
    state: createState(),
    connected: true,
    observation: null,
    report: null,
    send: () => {},
  };
  const source = renderToStaticMarkup(createElement(SourcePanel, props));
  assert.match(source, /Dữ liệu khả dụng/);
  assert.match(source, /Thông tin kỹ thuật/);
  assert.doesNotMatch(source, /SOURCE RESEARCH|CÓ THỂ NGHIÊN CỨU|Data Dragon|sequence|revision/);
  const dashboard = renderToStaticMarkup(
    createElement(Dashboard, { ...props, navigate: () => {} }),
  );
  assert.match(dashboard, /Thao tác nhanh/);
  assert.doesNotMatch(dashboard, /LOCAL-FIRST|MODULAR WORKSPACE|—|·/);
});
test("config retains team, score and ten nickname controls after shadcn migration", () => {
  const html = renderToStaticMarkup(
    createElement(MatchConfig, {
      state: createState(),
      connected: true,
      send: () => {},
      next: () => {},
    }),
  );
  assert.equal((html.match(/aria-label="Tên tuyển thủ \d+"/g) ?? []).length, 10);
  assert.match(html, /Lưu cấu hình/);
  assert.match(html, /data-variant="default"/);
  // Existing names are user data, not Studio copy; preserve their punctuation.
  const copy = html.replace(/value="[^"]*"/g, 'value=""');
  assert.doesNotMatch(copy, /Backend đã nhận cấu hình|—|·/);
});
test("Studio CSS avoids preflight and is scoped away from approved OBS canvas", () => {
  const css = readFileSync("src/studio.css", "utf8"),
    main = readFileSync("src/main.tsx", "utf8");
  assert.ok(!css.includes('@import "tailwindcss";'));
  assert.ok(css.includes(".studio-shell"));
  assert.match(main, /if \(isOverlay\)/);
  assert.doesNotMatch(main, /LOCAL WORKSPACE|legacyDemoUiEnabled/);
});
