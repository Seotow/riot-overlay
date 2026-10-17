@echo off
cd /d "%~dp0"
"runtime\dotnet.exe" "LeagueCollector.dll" --source lblib %*
pause
