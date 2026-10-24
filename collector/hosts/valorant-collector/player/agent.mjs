// Nhân runtime của bản player: phân giải code → chạy Spectra Client ở chế độ auxiliary → theo dõi
// tap (named pipe) để biết trạng thái kết nối, Riot ID của chính máy mình, và số frame aux đã gửi.
// UI (ui.mjs) chỉ đọc state()/gọi join()/leave(); CLI (join.mjs) dùng cùng module này.
import { acquireOfficial, startOfficial } from "../client/official.mjs";
import { startTapReader } from "../client/tap/reader.mjs";
import { camStreamId, playercamPushUrl, streamIdProblem } from "./cam.mjs";
import { resolveJoin } from "./join-code.mjs";

const AUX_NAME = "Player";

/** Riot ID chuẩn hoá "Tên#Tag" từ chuỗi GEP ("Seotoww #2013") hoặc người dùng nhập. */
export function canonicalRiotId(value) {
  const text = String(value ?? "").trim();
  if (!text || !text.includes("#")) return text;
  const index = text.indexOf("#");
  return `${text.slice(0, index).trim()}#${text.slice(index + 1).trim()}`;
}

export function createPlayerAgent({ log = () => {}, onUpdate = () => {}, resolver = resolveJoin } = {}) {
  const state = {
    phase: "idle",
    detail: "",
    code: "",
    host: null,
    riotId: "",
    riotIdManual: false,
    // Camera: mặc định tự kết nối ngay khi biết đủ room (từ code) + Riot ID. Người dùng tắt tay thì
    // giữ nguyên ý đó cho tới khi bật lại / bỏ chọn "tự động".
    camAuto: true,
    camUserOff: false,
    camManual: false,
    camOn: false,
    client: {
      tap: "starting",
      state: "idle",
      title: "",
      connected: false,
      isAux: false,
      matchId: "",
      ingest: "",
      unreachable: false,
    },
    counters: { aux: 0, obs: 0, gep: 0, lastAt: 0 },
  };

  let reader = null;
  let runtimePromise = null;

  const emit = () => onUpdate(view());

  const fail = (message) => {
    state.phase = "error";
    state.detail = message;
    log(`lỗi: ${message}`);
    emit();
  };

  /**
   * Trạng thái camera suy ra từ state. Camera chỉ đẩy được khi có room id (do host công bố trong
   * code) và biết Riot ID của chính máy này (để stream id khớp roster của overlay).
   */
  function camStatus() {
    const riotId = canonicalRiotId(state.riotId);
    const room = state.host?.camRoom ?? "";
    const nameProblem = streamIdProblem(riotId);
    const active = state.phase !== "idle" && state.phase !== "error";
    // Muốn đẩy camera khi: người dùng chưa tắt tay, và (chế độ tự động HOẶC đã bật tay chế độ không tự động).
    const wanted = !state.camUserOff && (state.camAuto || state.camManual) && active;
    const on = wanted && !!room && !nameProblem;
    let waiting = null;
    if (wanted && !on) {
      waiting = !room
        ? "Host chưa đặt room id vdo.ninja trong Cấu hình trận."
        : "Đang chờ Riot ID: vào trận client sẽ tự đọc, hoặc nhập tay bên dưới.";
    }
    return { riotId, room, nameProblem, on, waiting, auto: state.camAuto };
  }

  /** Cập nhật camOn theo điều kiện hiện tại; trả true nếu có thay đổi (để emit một lần). */
  function syncCam() {
    const next = camStatus().on;
    if (next === state.camOn) return false;
    state.camOn = next;
    if (next) log("camera tự bật (đã có room + Riot ID)");
    else if (state.camUserOff) log("camera đang tắt theo yêu cầu");
    return true;
  }

  /** Ảnh chụp trạng thái cho UI/CLI: mọi thứ suy ra từ state, không có gì ẩn. */
  function view() {
    const cam = camStatus();
    return {
      phase: state.phase,
      detail: state.detail,
      code: state.code,
      host: state.host
        ? {
            kind: state.host.kind,
            origin: state.host.origin,
            groupCode: state.host.groupCode,
            camRoom: state.host.camRoom,
            host: state.host.host,
          }
        : null,
      client: { ...state.client },
      counters: { ...state.counters },
      riotId: cam.riotId,
      riotIdManual: state.riotIdManual,
      cam: {
        on: cam.on,
        auto: cam.auto,
        room: cam.room,
        streamId: cam.nameProblem ? "" : camStreamId(cam.riotId),
        url: cam.on ? playercamPushUrl(cam.room, cam.riotId) : "",
        waiting: cam.waiting,
      },
    };
  }

  function handleFrame(frame) {
    const { k, c, d } = frame ?? {};
    if (!d || typeof d !== "object") return;
    state.counters.lastAt = Date.now();

    if (k === "status" && c === "connector") {
      state.client.connected = !!d.connected;
      state.client.isAux = !!d.isAux;
      state.client.unreachable = !!d.unreachable;
      state.client.matchId = d.matchId ?? "";
      state.client.ingest = d.ingest ?? "";
      if (state.client.connected && state.phase !== "connected") {
        state.phase = "connected";
        state.detail = "Client đã kết nối tới host và đang gửi dữ liệu.";
      } else if (!state.client.connected && state.phase === "connected") {
        state.phase = "waiting";
        state.detail = "Mất kết nối tới host, client đang thử lại…";
      }
      emit();
      return;
    }

    if (k === "gep") {
      state.counters.gep++;
      if (c === "infoupdate" && d.key === "player_name" && typeof d.value === "string") {
        // GEP trả "Tên #Tag"; chuẩn hoá để stream id khớp overlay.
        if (!state.riotIdManual) {
          state.riotId = canonicalRiotId(d.value);
          syncCam();
          emit();
        }
      }
      return;
    }

    if (k === "out" && c === "aux_data") {
      state.counters.aux++;
      if (state.phase === "connected" && state.counters.aux === 1) {
        state.detail = "Đang gửi máu và kỹ năng lên host.";
      }
      emit();
      return;
    }
    if (k === "out" && c === "obs_data") state.counters.obs++;
  }

  return {
    view,
    /** Đẩy một frame tap vào nhân (reader gọi; test cũng dùng để mô phỏng GEP/connector). */
    handleFrame,
    /** Mở named pipe để đọc tap. Gọi trước khi chạy client (frame sẽ được tap xếp hàng chờ). */
    async startTap() {
      reader = await startTapReader({
        onFrame: handleFrame,
        onState: ({ mode, error }) => {
          state.client.tap = error ? `lỗi ${error}` : mode;
          emit();
        },
      });
      return reader.mode;
    },
    async join(rawCode, options = {}) {
      if (state.phase === "downloading" || state.phase === "starting") return view();
      state.phase = "resolving";
      state.detail = "Đang tra code…";
      state.camOn = false;
      emit();

      let join;
      try {
        join = await (options.resolver ?? resolver)(rawCode);
      } catch (error) {
        fail(error.message || String(error));
        return view();
      }
      state.code = join.code;
      state.host = join;
      log(`Code ${join.code} → ${join.origin}${join.camRoom ? ` (room cam ${join.camRoom})` : ""}`);
      // Code đã mang room cam: bật camera ngay nếu đã biết Riot ID (nhập tay/nhớ từ lần trước).
      syncCam();
      if (options.startClient === false) {
        // Chỉ tra code (thử camera/room trước khi mở client) — không tải, không chạy Spectra Client.
        state.phase = "ready";
        state.detail = `Đã tra được host (${join.origin}). Chưa mở client theo yêu cầu.`;
        emit();
        return view();
      }
      state.phase = "downloading";
      state.detail = "Chuẩn bị Spectra Client (tải một lần nếu máy chưa có)…";
      emit();

      runtimePromise = (async () => {
        try {
          await acquireOfficial({}, (line) => {
            state.detail = line;
            emit();
          });
          state.phase = "starting";
          state.detail = "Đang mở Spectra Client ở chế độ auxiliary…";
          emit();
          const runtime = await startOfficial({
            config: {},
            match: {
              observerName: AUX_NAME,
              key: join.key,
              groupCode: join.groupCode,
              ingest: join.origin,
              teams: [
                { name: "Team 1", tricode: "T1", url: "" },
                { name: "Team 2", tricode: "T2", url: "" },
              ],
              tournamentLogo: "",
            },
            mode: "auxiliary",
            auxName: AUX_NAME,
            onState: ({ state: clientState, title }) => {
              state.client.state = clientState;
              state.client.title = title;
              emit();
            },
          });
          if (state.phase !== "connected") {
            state.phase = "waiting";
            state.detail =
              "Client đang chạy ngầm. Vào trận (chế độ bomb/custom) nó sẽ tự đăng nhập khi có match id.";
          }
          emit();
          return runtime;
        } catch (error) {
          fail(error?.message || String(error));
          throw error;
        }
      })();
      // Không await: startOfficial lặp đăng nhập tới 10 phút, UI cần phản hồi ngay. Tiến trình nền
      // tự cập nhật phase qua state.detail/emit khi tải, khi mở client và khi kết nối.
      runtimePromise.catch(() => {});
      return view();
    },
    async leave() {
      state.camOn = false;
      state.phase = "idle";
      state.detail = "Đã dừng theo yêu cầu.";
      emit();

      const pending = runtimePromise;
      runtimePromise = null;
      if (pending) {
        try {
          const runtime = await pending;
          await runtime?.stop?.();
        } catch {
          // Client chưa kịp chạy thì không có gì để dừng.
        }
      }
      state.client.connected = false;
      state.client.state = "idle";
      state.detail = "Đã dừng.";
      emit();
      return view();
    },
    /**
     * Đặt Riot ID. `manual` = người dùng tự nhập (không cho GEP ghi đè); mặc định suy ra từ việc ô nhập
     * có trống hay không. UI gửi `manual: false` cho giá trị nhớ từ lần trước để GEP còn sửa được.
     */
    setRiotId(value, options = {}) {
      state.riotId = canonicalRiotId(value);
      state.riotIdManual =
        options.manual ?? String(value ?? "").trim().length > 0;
      syncCam();
      emit();
      return view();
    },
    /** Bật/tắt camera ngay; tắt tay thì camera không tự bật lại cho tới khi người dùng bật lại. */
    setCam(on) {
      state.camUserOff = !on;
      state.camManual = !!on;
      syncCam();
      emit();
      return view();
    },
    /** Bật/tắt chế độ tự kết nối camera sau khi nhập code. Bỏ chọn thì camera dừng (không tự bật lại). */
    setAutoCam(on) {
      state.camAuto = !!on;
      state.camManual = false;
      state.camUserOff = !on;
      syncCam();
      emit();
      return view();
    },
    stopTap() {
      reader?.close?.();
      reader = null;
    },
  };
}
