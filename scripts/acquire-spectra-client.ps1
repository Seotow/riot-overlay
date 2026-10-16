# Acquire a pinned official collector runtime; never runs the installer.
$ErrorActionPreference = 'Stop'
$workspace = [IO.Path]::GetFullPath((Join-Path $PSScriptRoot '..'))
$record = Get-Content -LiteralPath (Join-Path $workspace 'modules/valorant/collector-release.json') -Raw | ConvertFrom-Json
$target = [IO.Path]::GetFullPath((Join-Path $workspace 'data/valorant/collector/0.3.4'))
if (Test-Path -LiteralPath $target) { throw 'Collector directory exists; refusing to overwrite it' }
$sevenZip = 'C:\Program Files\7-Zip\7z.exe'
if (-not (Test-Path -LiteralPath $sevenZip)) { throw '7-Zip is required to extract the official archive' }
$cache = Join-Path $workspace '.research/valospectra/release-0.3.4'
New-Item -ItemType Directory -Path $cache -Force | Out-Null
$archive = Join-Path $cache $record.artifact
if (-not (Test-Path -LiteralPath $archive)) { Invoke-WebRequest -Uri $record.url -OutFile $archive }
if ((Get-Item -LiteralPath $archive).Length -ne $record.size -or (Get-FileHash -LiteralPath $archive -Algorithm SHA256).Hash.ToLower() -ne $record.sha256) { throw 'Archive identity mismatch' }
# Inventory member paths before extraction; refuse absolute/parent paths.
$listing = & $sevenZip l -slt $archive
if ($LASTEXITCODE -ne 0) { throw 'Cannot list archive' }
$members = @($listing | Where-Object { $_.StartsWith('Path = ') } | Select-Object -Skip 1 | ForEach-Object { $_.Substring(7) })
foreach ($member in $members) {
  $resolved = [IO.Path]::GetFullPath((Join-Path $target $member))
  if ([IO.Path]::IsPathRooted($member) -or -not $resolved.StartsWith($target + [IO.Path]::DirectorySeparatorChar)) { throw 'Unsafe archive member path' }
}
New-Item -ItemType Directory -Path $target -Force | Out-Null
& $sevenZip x $archive "-o$target" -y -bso0 -bsp0
if ($LASTEXITCODE -ne 0) { throw 'Extraction failed' }
$exe = Join-Path $target $record.executable
if ((Get-FileHash -LiteralPath $exe -Algorithm SHA256).Hash.ToLower() -ne $record.executableSha256) { throw 'Executable identity mismatch' }
Write-Output 'Official Spectra Client 0.3.4 extracted and verified; no installer or game process executed.'
