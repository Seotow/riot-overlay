// language: JavaScript, file: shim.js, runtime: WebView2 (overlay host), target: Windows
// Chạy trước mọi script của trang overlay. Nhận frame từ host (window.chrome.webview) và
// phát ra dưới dạng event ổn định, không phụ thuộc bản build frontend.
//   window.RiotTap.on(fn)      - đăng ký nhận mọi frame
//   window.RiotTap.last        - frame gần nhất
//   window.addEventListener('riot-tap', fn)  - dùng event detail
(() => {
  const MAX_HISTORY = 256;
  const history = [];
  const listeners = new Set();

  const tap = {
    last: null,
    history,
    on(fn) {
      listeners.add(fn);
      return () => listeners.delete(fn);
    },
    // Tiện cho việc dò: trả bản ghi theo loại, mới nhất trước.
    query(kind, channel) {
      return history
        .filter((f) => f.k === kind && (!channel || f.c === channel))
        .slice()
        .reverse();
    },
  };
  window.RiotTap = tap;

  const dispatch = (frame) => {
    frame.receivedAt = performance.now();
    tap.last = frame;
    history.push(frame);
    if (history.length > MAX_HISTORY) history.shift();
    for (const fn of listeners) {
      try {
        fn(frame);
      } catch (e) {
        console.warn('[riot-tap] listener lỗi', e);
      }
    }
    window.dispatchEvent(new CustomEvent('riot-tap', { detail: frame }));
  };

  const bridge = window.chrome && window.chrome.webview;
  if (!bridge) {
    console.warn('[riot-tap] không thấy WebView2 bridge; đang chạy ngoài host?');
    return;
  }
  bridge.addEventListener('message', (event) => {
    const data = typeof event.data === 'string' ? safeParse(event.data) : event.data;
    if (data && typeof data === 'object' && data.k) dispatch(data);
  });

  function safeParse(text) {
    try {
      return JSON.parse(text);
    } catch {
      return null;
    }
  }

  // Báo cho host biết trang đã sẵn sàng nhận frame.
  bridge.postMessage({ k: 'shim-ready', t: Date.now() });
})();
