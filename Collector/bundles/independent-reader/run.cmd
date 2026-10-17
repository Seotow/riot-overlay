@echo off
setlocal
set "LC_HOST_DOTNET=%~dp0runtime\dotnet.exe"
if exist "%LC_HOST_DOTNET%" goto run
set "LC_HOST_DOTNET=%~dp0..\runtime\dotnet.exe"
if exist "%LC_HOST_DOTNET%" goto run
set "LC_HOST_DOTNET=dotnet"
:run
"%LC_HOST_DOTNET%" "%~dp0IndependentCollector.dll" %*
exit /b %errorlevel%
