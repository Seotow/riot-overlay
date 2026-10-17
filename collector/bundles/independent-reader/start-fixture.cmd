@echo off
call "%~dp0run.cmd" --fixture "%~dp0fixtures\memory.json" --profile "%~dp0fixtures\profile.json" %*
exit /b %errorlevel%
