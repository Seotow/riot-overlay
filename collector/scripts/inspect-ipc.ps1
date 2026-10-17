$ErrorActionPreference = 'Stop'
$taskRoot = [IO.Path]::GetFullPath((Join-Path $PSScriptRoot '../..'))
$taskSdk = Join-Path $taskRoot '.npm-cache/lb-headless/dotnet-10.0.401/dotnet.exe'
$taskDll = Join-Path $PSScriptRoot '../hosts/lb-host/src/LeagueCollector/bin/Release/net10.0/LeagueCollector.dll'
$taskOutput = @(& $taskSdk $taskDll --ipc-status 2>&1)
$taskCode = $LASTEXITCODE
$taskResult = $null
try {
    if ($taskOutput.Count -ne 1) { throw 'Unexpected output.' }
    $taskResult = $taskOutput[0] | ConvertFrom-Json
    if ($taskResult.kind -cne 'passive-native-ipc-status' -or $taskResult.injectionAttempted -ne $false -or
        $taskResult.connectionAttempted -ne $false -or $taskResult.snapshotRequestSent -ne $false) { throw 'Invalid diagnostic.' }
} catch { $taskResult = [ordered]@{kind='passive-native-ipc-status';status='result-unavailable';injectionAttempted=$false;connectionAttempted=$false;snapshotRequestSent=$false} }
$taskFolder = Join-Path $PSScriptRoot '../evidence/validation'
[void][IO.Directory]::CreateDirectory($taskFolder)
$taskName = 'ipc-' + [DateTimeOffset]::UtcNow.ToString('yyyy-MM-ddTHH-mm-ss-fffZ') + '-' + [Guid]::NewGuid().ToString('N') + '.json'
$taskEvidence = [ordered]@{kind='passive-ipc-evidence';exitCode=$taskCode;result=$taskResult;hostSha256=(Get-FileHash -Algorithm SHA256 -LiteralPath $taskDll).Hash.ToLowerInvariant()}
[IO.File]::WriteAllText((Join-Path $taskFolder $taskName), ($taskEvidence | ConvertTo-Json -Depth 6), [Text.UTF8Encoding]::new($false))
[ordered]@{kind='passive-ipc-summary';status=$taskResult.status;exitCode=$taskCode;evidence=$taskName} | ConvertTo-Json -Compress
if ($taskCode -ne 0) { exit 1 }
