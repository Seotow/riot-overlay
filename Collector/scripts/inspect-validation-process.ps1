$ErrorActionPreference = 'Stop'
$taskDll = [IO.Path]::GetFullPath((Join-Path $PSScriptRoot '../src/LeagueCollector/src/LeagueCollector/bin/Release/net10.0/LeagueCollector.dll'))
# Read-only. Match only the exact validation DLL/flags; never print command lines.
$taskMatches = @(Get-CimInstance Win32_Process -Filter "Name='dotnet.exe'" | Where-Object {
    $null -ne $_.CommandLine -and $_.CommandLine.IndexOf($taskDll, [StringComparison]::OrdinalIgnoreCase) -ge 0 -and
    ($_.CommandLine.Contains('--validation-30s-single-inject') -or $_.CommandLine.Contains('--validation-30s-no-inject'))
})
[ordered]@{kind='owned-validation-process-check';MatchingProcesses=$taskMatches.Count;ReadOnly=$true} | ConvertTo-Json -Compress
