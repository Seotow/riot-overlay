$ErrorActionPreference = 'Stop'
Set-StrictMode -Version Latest
$taskRoot = [IO.Path]::GetFullPath((Join-Path $PSScriptRoot '../..'))
$taskSource = Join-Path $PSScriptRoot '../hosts/lb-host'
$taskSdk = Join-Path $taskRoot '.npm-cache/lb-headless/dotnet-10.0.401/dotnet.exe'
$taskProject = Join-Path $taskSource 'src/LeagueCollector/LeagueCollector.csproj'
$taskDll = Join-Path $taskSource 'src/LeagueCollector/bin/Release/net10.0/LeagueCollector.dll'
$taskProfile = Join-Path $taskRoot '.npm-cache/collector-validation'
$taskRunName = 'managed-lab-' + [DateTimeOffset]::UtcNow.ToString('yyyy-MM-ddTHH-mm-ss-fffZ') + '-' + [Guid]::NewGuid().ToString('N')
$taskRunDirectory = Join-Path $PSScriptRoot ('../evidence/validation/' + $taskRunName)
[void][IO.Directory]::CreateDirectory($taskRunDirectory)
$taskKeys = @('APPDATA','DOTNET_CLI_HOME','DOTNET_CLI_TELEMETRY_OPTOUT','DOTNET_GENERATE_ASPNET_CERTIFICATE','NUGET_PACKAGES','LB_EMAIL','LB_PASSWORD')
$taskOriginal = @{}
foreach ($taskKey in $taskKeys) { $taskOriginal[$taskKey] = [Environment]::GetEnvironmentVariable($taskKey, 'Process') }
$taskReport = [ordered]@{ kind='collector-managed-validation';startedAt=[DateTimeOffset]::UtcNow.ToString('O');gameAccessed=$false;nativeInjection=$false;productionChanged=$false;sdkVersion=$null;checks=@();passed=$false;failedStage=$null }
$taskStage = 'sdk-check'
function Save-LabText([string]$taskName, [object[]]$taskLines) {
    [IO.File]::WriteAllLines((Join-Path $taskRunDirectory $taskName), [string[]]$taskLines, [Text.UTF8Encoding]::new($false))
}
try {
    if (-not (Test-Path -LiteralPath $taskSdk)) { throw 'Existing local SDK required.' }
    $env:APPDATA = Join-Path $taskProfile 'appdata'
    $env:DOTNET_CLI_HOME = Join-Path $taskProfile 'cli'
    $env:DOTNET_CLI_TELEMETRY_OPTOUT = '1'
    $env:DOTNET_GENERATE_ASPNET_CERTIFICATE = 'false'
    $env:NUGET_PACKAGES = Join-Path $taskProfile 'packages'
    $env:LB_EMAIL = $null; $env:LB_PASSWORD = $null
    $taskVersion = @(& $taskSdk --version 2>&1)
    Save-LabText 'sdk.txt' $taskVersion
    if ($LASTEXITCODE -ne 0 -or $taskVersion.Count -ne 1 -or $taskVersion[0] -notmatch '^\d+\.\d+\.\d+$') { throw 'SDK version unavailable.' }
    $taskReport.sdkVersion = [string]$taskVersion[0]
    $taskStage = 'offline-restore'
    $taskRestore = @(& $taskSdk restore $taskProject --configfile (Join-Path $PSScriptRoot 'NuGet.offline.config') -v quiet 2>&1)
    $taskCode = $LASTEXITCODE
    Save-LabText 'restore.txt' $taskRestore
    $taskReport.checks += [ordered]@{name='offline-restore';exitCode=$taskCode;passed=($taskCode -eq 0)}
    if ($taskCode -ne 0) { throw 'Restore failed.' }
    $taskStage = 'build'
    $taskBuild = @(& $taskSdk build $taskProject -c Release --no-restore -v quiet 2>&1)
    $taskCode = $LASTEXITCODE
    Save-LabText 'build.txt' $taskBuild
    $taskReport.checks += [ordered]@{name='build';exitCode=$taskCode;passed=($taskCode -eq 0);errorLines=@($taskBuild | Where-Object {$_ -match 'error [A-Z]+[0-9]+'}).Count;warningLines=@($taskBuild | Where-Object {$_ -match 'warning [A-Z]+[0-9]+'}).Count}
    if ($taskCode -ne 0) { throw 'Build failed.' }
    foreach ($taskTest in @(@{name='doctor';arguments=@('--doctor','--no-inject','--no-lcu')},@{name='serializer-self-test';arguments=@('--self-test','--no-inject','--no-lcu')},@{name='lifecycle-self-test';arguments=@('--lifecycle-self-test')},@{name='auth-flow-self-test';arguments=@('--auth-flow-self-test')})) {
        $taskStage = $taskTest.name
        $taskTestArguments = $taskTest.arguments
        $taskOutput = @(& $taskSdk $taskDll @taskTestArguments 2>&1)
        $taskCode = $LASTEXITCODE
        Save-LabText ($taskStage + '.json') $taskOutput
        $taskReport.checks += [ordered]@{name=$taskStage;exitCode=$taskCode;passed=($taskCode -eq 0)}
        if ($taskCode -ne 0) { throw 'Lab test failed.' }
    }
    $taskReport.passed = $true
} catch {
    # Detailed compiler/test outputs are in this owned run directory. No account
    # config/environment/raw exception text is exported into the summary.
    $taskReport.failedStage = $taskStage
} finally {
    foreach ($taskKey in $taskKeys) { [Environment]::SetEnvironmentVariable($taskKey, $taskOriginal[$taskKey], 'Process') }
    $taskReport.finishedAt = [DateTimeOffset]::UtcNow.ToString('O')
    $taskHashes = [ordered]@{}
    foreach ($taskEntry in @(@{name='zip';path=(Join-Path $PSScriptRoot '../archive/cloud-export/RiotOverlay-local/packages/LeagueCollector-source.zip')},@{name='native';path=(Join-Path $taskSource 'native/lblib.dll')},@{name='host';path=$taskDll},@{name='farsight';path=(Join-Path (Split-Path $taskDll) 'Farsight.dll')},@{name='harness';path=$PSCommandPath})) {
        if (Test-Path -LiteralPath $taskEntry.path) { $taskHashes[$taskEntry.name] = (Get-FileHash -Algorithm SHA256 -LiteralPath $taskEntry.path).Hash.ToLowerInvariant() }
    }
    $taskReport.artifactSha256 = $taskHashes
    [IO.File]::WriteAllText((Join-Path $taskRunDirectory 'summary.json'), ($taskReport | ConvertTo-Json -Depth 8), [Text.UTF8Encoding]::new($false))
}
[ordered]@{kind=$taskReport.kind;passed=$taskReport.passed;failedStage=$taskReport.failedStage;checks=$taskReport.checks.Count;gameAccessed=$false;results=$taskRunName} | ConvertTo-Json -Compress
if (-not $taskReport.passed) { exit 1 }
