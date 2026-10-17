@echo off
setlocal
cd /d "%~dp0"
if not exist "test-results" mkdir "test-results"
set "LB_TEST_RUN=test-results\run-%RANDOM%-%RANDOM%"
mkdir "%LB_TEST_RUN%"
if errorlevel 1 (echo Could not create test directory.& pause & exit /b 1)
echo Dashboard: http://127.0.0.1:18799/
echo Results: %LB_TEST_RUN%
echo Press Ctrl+C to stop and finish the recording.
"runtime\dotnet.exe" "LeagueCollector.dll" --source lblib --record "%LB_TEST_RUN%\frames.ndjson" %* > "%LB_TEST_RUN%\collector.log" 2>&1
echo Collector exited. Results: %LB_TEST_RUN%
pause
