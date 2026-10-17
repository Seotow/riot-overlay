@echo off
if "%~1"=="" (echo Drag an NDJSON file onto this script.& pause & exit /b 2)
cd /d "%~dp0"
"runtime\dotnet.exe" "LeagueCollector.dll" --replay %*
pause
