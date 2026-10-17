# Compatibility entry point. Read-only implementation uses the current source path.
& (Join-Path $PSScriptRoot 'scripts/inspect-validation-process.ps1')
if (-not $?) { exit 1 }
