// language: C++20, file: main.cpp, target: Windows 10/11 x64, MSVC 2022 + WebView2 SDK
// Cửa sổ overlay phủ lên VALORANT: trong suốt từng pixel, xuyên chuột, luôn nổi, không chiếm focus.
// Nhận frame NDJSON từ named pipe do tap.cjs trong Spectra Client đẩy ra, chuyển vào trang web qua
// window.chrome.webview.postMessage. Trang web là build VAL26 sẵn có (không sửa).
// KHÔNG liên quan tới process VALORANT: không inject, không đọc memory, không handle.

#include <windows.h>
#include <dwmapi.h>
#include <shellapi.h>
#include <wrl.h>

#include <string>
#include <thread>
#include <vector>

#include "WebView2.h"

#pragma comment(lib, "dwmapi.lib")
#pragma comment(lib, "shell32.lib")
#pragma comment(lib, "ole32.lib")

using Microsoft::WRL::Callback;
using Microsoft::WRL::ComPtr;

namespace {

constexpr wchar_t kWindowClass[] = L"RiotOverlayHostWindow";
constexpr UINT kMsgTapFrame = WM_APP + 1;
constexpr int kHotkeyToggle = 1;

struct Options {
  std::wstring pipe = L"\\\\.\\pipe\\riot-spectra-tap";
  std::wstring url = L"http://127.0.0.1:5322/overlay?groupCode=RIOTLOCAL";
  double design_height = 1080.0;  // overlay được dựng cho 1920x1080
};

Options g_options;
ComPtr<ICoreWebView2> g_webview;
ComPtr<ICoreWebView2Controller> g_controller;
HWND g_hwnd = nullptr;
HANDLE g_pipe_thread = nullptr;
volatile LONG g_running = 1;

std::wstring Utf8ToWide(const std::string& s) {
  if (s.empty()) return {};
  int n = MultiByteToWideChar(CP_UTF8, 0, s.data(), static_cast<int>(s.size()), nullptr, 0);
  std::wstring out(static_cast<size_t>(n), L'\0');
  MultiByteToWideChar(CP_UTF8, 0, s.data(), static_cast<int>(s.size()), out.data(), n);
  return out;
}

void PostFrame(const std::string& json) {
  auto payload = new std::string(json);
  if (!PostMessageW(g_hwnd, kMsgTapFrame, 0, reinterpret_cast<LPARAM>(payload))) delete payload;
}

// Một instance pipe, nối lại sau mỗi lần tap.cjs restart.
void PipeLoop() {
  while (InterlockedCompareExchange(&g_running, 1, 1)) {
    HANDLE pipe = CreateNamedPipeW(g_options.pipe.c_str(), PIPE_ACCESS_INBOUND,
                                   PIPE_TYPE_BYTE | PIPE_READMODE_BYTE | PIPE_WAIT,
                                   1, 1 << 20, 1 << 20, 0, nullptr);
    if (pipe == INVALID_HANDLE_VALUE) {
      Sleep(1000);
      continue;
    }
    if (!ConnectNamedPipe(pipe, nullptr) && GetLastError() != ERROR_PIPE_CONNECTED) {
      CloseHandle(pipe);
      Sleep(500);
      continue;
    }

    std::string buffer;
    char chunk[8192];
    DWORD read = 0;
    while (ReadFile(pipe, chunk, sizeof(chunk), &read, nullptr) && read > 0) {
      buffer.append(chunk, read);
      size_t start = 0;
      for (size_t nl; (nl = buffer.find('\n', start)) != std::string::npos; start = nl + 1) {
        std::string line = buffer.substr(start, nl - start);
        if (!line.empty()) PostFrame(line);
      }
      buffer.erase(0, start);
      if (buffer.size() > (8u << 20)) buffer.clear();  // frame rác: bỏ, không phình RAM
    }
    DisconnectNamedPipe(pipe);
    CloseHandle(pipe);
  }
}

// Cửa sổ phủ đúng màn hình chính; zoom theo chiều cao để giữ lưới pixel 1920x1080.
RECT MonitorRect() {
  POINT origin{0, 0};
  HMONITOR monitor = MonitorFromPoint(origin, MONITOR_DEFAULTTOPRIMARY);
  MONITORINFO info{sizeof(MONITORINFO)};
  GetMonitorInfoW(monitor, &info);
  return info.rcMonitor;
}

int ScreenHeight() {
  RECT r = MonitorRect();
  return r.bottom - r.top;
}

void ApplyZoom() {
  if (!g_controller) return;
  double zoom = ScreenHeight() / g_options.design_height;
  g_webview->put_ZoomFactor(zoom);
}

void ToggleVisible() {
  if (!g_hwnd) return;
  LONG_PTR ex = GetWindowLongPtrW(g_hwnd, GWL_EXSTYLE);
  bool hidden = (ex & WS_EX_TRANSPARENT) == 0;
  if (hidden) {
    ShowWindow(g_hwnd, SW_SHOWNOACTIVATE);
    SetWindowLongPtrW(g_hwnd, GWL_EXSTYLE, ex | WS_EX_TRANSPARENT | WS_EX_NOACTIVATE);
  } else {
    SetWindowLongPtrW(g_hwnd, GWL_EXSTYLE, ex & ~(WS_EX_TRANSPARENT | WS_EX_NOACTIVATE));
  }
  SetWindowPos(g_hwnd, HWND_TOPMOST, 0, 0, 0, 0,
               SWP_NOMOVE | SWP_NOSIZE | SWP_NOACTIVATE | SWP_FRAMECHANGED);
}

void InitWebView() {
  wchar_t local_app_data[MAX_PATH]{};
  GetEnvironmentVariableW(L"LOCALAPPDATA", local_app_data, MAX_PATH);
  std::wstring user_data = std::wstring(local_app_data) + L"\\riot-overlay\\overlay-host";

  auto env_handler = Callback<ICoreWebView2CreateCoreWebView2EnvironmentCompletedHandler>(
      [](HRESULT hr, ICoreWebView2Environment* env) -> HRESULT {
        if (FAILED(hr) || !env) return hr;
        env->CreateCoreWebView2Controller(
            g_hwnd,
            Callback<ICoreWebView2CreateCoreWebView2ControllerCompletedHandler>(
                [](HRESULT hr2, ICoreWebView2Controller* controller) -> HRESULT {
                  if (FAILED(hr2) || !controller) return hr2;
                  g_controller = controller;
                  g_controller->get_CoreWebView2(&g_webview);

                  RECT bounds = MonitorRect();
                  g_controller->put_Bounds(RECT{0, 0, bounds.right - bounds.left,
                                                bounds.bottom - bounds.top});
                  g_controller->put_IsVisible(TRUE);
                  g_controller->put_DefaultBackgroundColor(
                      COREWEBVIEW2_COLOR{0, 0, 0, 0});  // alpha = 0: pixel trong suốt

                  ComPtr<ICoreWebView2Settings> settings;
                  g_webview->get_Settings(&settings);
                  settings->put_AreDefaultContextMenusEnabled(FALSE);
                  settings->put_AreDevToolsEnabled(FALSE);
                  settings->put_IsStatusBarEnabled(FALSE);
                  settings->put_AreHostObjectsAllowed(FALSE);

                  ApplyZoom();
                  g_webview->Navigate(g_options.url.c_str());
                  return S_OK;
                })
                .Get());
        return S_OK;
      });

  CreateCoreWebView2EnvironmentWithOptions(nullptr, user_data.c_str(), nullptr, env_handler.Get());
}

LRESULT CALLBACK WndProc(HWND hwnd, UINT msg, WPARAM wp, LPARAM lp) {
  switch (msg) {
    case kMsgTapFrame: {
      auto payload = reinterpret_cast<std::string*>(lp);
      if (g_webview && payload) {
        std::wstring wide = Utf8ToWide(*payload);
        g_webview->PostWebMessageAsJson(wide.c_str());
      }
      delete payload;
      return 0;
    }
    case WM_HOTKEY:
      if (wp == kHotkeyToggle) ToggleVisible();
      return 0;
    case WM_DISPLAYCHANGE:
      ApplyZoom();
      return 0;
    case WM_DESTROY:
      InterlockedExchange(&g_running, 0);
      PostQuitMessage(0);
      return 0;
    default:
      return DefWindowProcW(hwnd, msg, wp, lp);
  }
}

HWND CreateOverlayWindow() {
  HINSTANCE instance = GetModuleHandleW(nullptr);
  WNDCLASSEXW wc{sizeof(WNDCLASSEXW)};
  wc.lpfnWndProc = WndProc;
  wc.hInstance = instance;
  wc.lpszClassName = kWindowClass;
  wc.hCursor = LoadCursorW(nullptr, IDC_ARROW);
  RegisterClassExW(&wc);

  RECT screen = MonitorRect();
  HWND hwnd = CreateWindowExW(
      WS_EX_TOPMOST | WS_EX_TOOLWINDOW | WS_EX_NOACTIVATE | WS_EX_LAYERED | WS_EX_TRANSPARENT,
      kWindowClass, L"Riot Overlay", WS_POPUP, screen.left, screen.top,
      screen.right - screen.left, screen.bottom - screen.top, nullptr, nullptr, instance, nullptr);
  if (!hwnd) return nullptr;

  // Kéo DWM lên toàn khung để alpha từng pixel của WebView2 đi xuyên xuống game.
  MARGINS margins{-1, -1, -1, -1};
  DwmExtendFrameIntoClientArea(hwnd, &margins);

  ShowWindow(hwnd, SW_SHOWNOACTIVATE);
  SetWindowPos(hwnd, HWND_TOPMOST, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE | SWP_NOACTIVATE);
  RegisterHotKey(hwnd, kHotkeyToggle, MOD_CONTROL | MOD_ALT, 'H');
  return hwnd;
}

Options ParseArgs() {
  Options options;
  int argc = 0;
  LPWSTR* argv = CommandLineToArgvW(GetCommandLineW(), &argc);
  for (int i = 1; i < argc; ++i) {
    std::wstring arg = argv[i];
    if (arg == L"--pipe" && i + 1 < argc) options.pipe = argv[++i];
    else if (arg == L"--url" && i + 1 < argc) options.url = argv[++i];
    else if (arg == L"--design-height" && i + 1 < argc) options.design_height = _wtof(argv[++i]);
  }
  LocalFree(argv);
  return options;
}

}  // namespace

int WINAPI wWinMain(HINSTANCE, HINSTANCE, PWSTR, int) {
  SetProcessDpiAwarenessContext(DPI_AWARENESS_CONTEXT_PER_MONITOR_AWARE_V2);
  CoInitializeEx(nullptr, COINIT_APARTMENTTHREADED);

  g_options = ParseArgs();
  g_hwnd = CreateOverlayWindow();
  if (!g_hwnd) {
    MessageBoxW(nullptr, L"Không tạo được cửa sổ overlay.", L"Riot Overlay", MB_ICONERROR);
    return 1;
  }
  InitWebView();

  g_pipe_thread = CreateThread(nullptr, 0, [](LPVOID) -> DWORD {
    PipeLoop();
    return 0;
  }, nullptr, 0, nullptr);

  MSG msg;
  while (GetMessageW(&msg, nullptr, 0, 0)) {
    TranslateMessage(&msg);
    DispatchMessageW(&msg);
  }

  InterlockedExchange(&g_running, 0);
  if (g_pipe_thread) {
    // Đánh thức ReadFile đang chờ bằng cách mở một client rỗng rồi thoát.
    HANDLE wake = CreateFileW(g_options.pipe.c_str(), GENERIC_WRITE, 0, nullptr, OPEN_EXISTING, 0, nullptr);
    if (wake != INVALID_HANDLE_VALUE) CloseHandle(wake);
    WaitForSingleObject(g_pipe_thread, 2000);
    CloseHandle(g_pipe_thread);
  }
  CoUninitialize();
  return 0;
}
