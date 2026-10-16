import test from "node:test";
import assert from "node:assert/strict";
import { renderToStaticMarkup } from "react-dom/server";
import { createElement } from "react";
import { RecordingDesk, recordedClock } from "../src/RecordingDesk";
import { createState } from "../shared/mock";
test("recording desk has an explicit loader and no legacy rehearsal/mock controls", () => {
  const html = renderToStaticMarkup(
    createElement(RecordingDesk, {
      state: createState(),
      send: () => {},
      connected: true,
      observation: null,
    }),
  );
  assert.match(html, /Tải bản ghi/);
  assert.match(html, /Đối chiếu ảnh ingame/);
  assert.match(html, /aria-label="Upload ảnh ingame đối chiếu"/);
  assert.match(html, /title="Preview đầu ra OBS"/);
  assert.equal((html.match(/type="file"/g) ?? []).length, 1);
  assert.match(html, /không tự chuyển nguồn/);
  for (const old of [
    "Thử toàn bộ đồ họa",
    "Chọn loại mục tiêu",
    "Chạy mock",
    "Hang Baron · loại",
    "Hoàn thành quest",
  ])
    assert.ok(!html.includes(old));
  assert.equal(recordedClock(21.209), "00:21");
  assert.equal(recordedClock(786.325), "13:06");
  assert.equal(recordedClock(null), "--:--");
});
