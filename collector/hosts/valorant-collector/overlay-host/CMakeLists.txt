# language: CMake, file: CMakeLists.txt, target: Windows x64, MSVC 2022
# Cần WebView2 SDK (NuGet Microsoft.Web.WebView2). Không cần cài runtime: WebView2 có sẵn trên Windows 11.
#   nuget install Microsoft.Web.WebView2 -OutputDirectory third_party
#   cmake -B build -DWEBVIEW2_ROOT=third_party/Microsoft.Web.WebView2.<version>
cmake_minimum_required(VERSION 3.24)
project(riot_overlay_host LANGUAGES CXX)

set(CMAKE_CXX_STANDARD 20)
set(CMAKE_CXX_STANDARD_REQUIRED ON)

if(NOT WEBVIEW2_ROOT)
  message(FATAL_ERROR "Đặt -DWEBVIEW2_ROOT=<thư mục giải nén Microsoft.Web.WebView2>")
endif()

set(WEBVIEW2_INCLUDE "${WEBVIEW2_ROOT}/build/native/include")
set(WEBVIEW2_LIB "${WEBVIEW2_ROOT}/build/native/x64/WebView2LoaderStatic.lib")
if(NOT EXISTS "${WEBVIEW2_LIB}")
  message(FATAL_ERROR "Không thấy ${WEBVIEW2_LIB}")
endif()

add_executable(riot-overlay-host WIN32 src/main.cpp)
target_include_directories(riot-overlay-host PRIVATE "${WEBVIEW2_INCLUDE}")
target_link_libraries(riot-overlay-host PRIVATE "${WEBVIEW2_LIB}" user32 gdi32 ole32 dwmapi shell32)
target_compile_options(riot-overlay-host PRIVATE /utf-8 /W4 /permissive-)
target_compile_definitions(riot-overlay-host PRIVATE UNICODE _UNICODE WIN32_LEAN_AND_MEAN NOMINMAX)
