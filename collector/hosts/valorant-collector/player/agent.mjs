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

export function createPlayerAgent({ log = () => {}, onUpdate = () => {} } = {}) {
  const state = {
    phase: "idle",
    detail: "",
    code: "",
    host: null,
    riotId: "",
    riotIdManual: false,
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

  /** Ảnh chụp trạng thái cho UI/CLI: mọi thứ suy ra từ state, không có gì ẩn. */
  function view() {
    const riotId = canonicalRiotId(state.riotId);
    const room = state.host?.camRoom ?? "";
    const nameProblem = streamIdProblem(riotId);
    const camProblem = state.camOn ? (room ? nameProblem : "Host chưa đặt room id vdo.ninja.") : null;
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
      riotId,
      riotIdManual: state.riotIdManual,
      cam: {
        on: state.camOn,
        room,
        streamId: nameProblem ? "" : camStreamId(riotId),
        url: state.camOn && room && !nameProblem ? playercamPushUrl(room, riotId) : "",
        problem: camProblem,
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
        join = await resolveJoin(rawCode);
      } catch (error) {
        fail(error.message || String(error));
        return view();
      }
      state.code = join.code;
      state.host = join;
      log(`Code ${join.code} → ${join.origin}${join.camRoom ? ` (room cam ${join.camRoom})` : ""}`);
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
    setRiotId(value) {
      state.riotId = canonicalRiotId(value);
      state.riotIdManual = String(value ?? "").trim().length > 0;
      emit();
      return view();
    },
    setCam(on) {
      state.camOn = !!on;
      emit();
      return view();
    },
    stopTap() {
      reader?.close?.();
      reader = null;
    },
  };
}
