# Import source only; never installs or executes upstream packages.
$ErrorActionPreference = 'Stop'
$workspace = [IO.Path]::GetFullPath((Join-Path $PSScriptRoot '..'))
$sources = @(
  @{ Name='Spectra-Server'; Target='backend'; Revision='64782ac2dcd5863aa179a084c8f402c3be794ebe' },
  @{ Name='Spectra-Frontend'; Target='frontend'; Revision='1e81de161c35d4b6f5e4fb6056c6db100734bf96' },
  @{ Name='Spectra-Client'; Target='collector'; Revision='a07fd0853129a549ac4d657544ae1e0b93e4f5e8' }
)
$records = @()
foreach ($source in $sources) {
  $target = [IO.Path]::GetFullPath((Join-Path $workspace "modules/valorant/$($source.Target)"))
  if (-not $target.StartsWith($workspace + [IO.Path]::DirectorySeparatorChar)) { throw 'Target outside workspace' }
  if (Test-Path -LiteralPath $target) { throw "Refusing to overwrite $target" }
  $cache = Join-Path $workspace ".research/valospectra/import-$($source.Revision)"
  New-Item -ItemType Directory -Force -Path $cache | Out-Null
  $archive = Join-Path $cache 'source.zip'
  $url = "https://codeload.github.com/ValoSpectra/$($source.Name)/zip/$($source.Revision)"
  Invoke-WebRequest -Uri $url -OutFile $archive
  Expand-Archive -LiteralPath $archive -DestinationPath $cache
  $extracted = Join-Path $cache "$($source.Name)-$($source.Revision)"
  New-Item -ItemType Directory -Path $target | Out-Null
  Get-ChildItem -LiteralPath $extracted -Force | Where-Object { $_.Name -notin @('.github','.husky','.vscode') } | ForEach-Object {
    Copy-Item -LiteralPath $_.FullName -Destination $target -Recurse
  }
  $records += @{ repository="https://github.com/ValoSpectra/$($source.Name)"; revision=$source.Revision; directory=$source.Target; archiveSha256=(Get-FileHash -LiteralPath $archive -Algorithm SHA256).Hash.ToLower(); excluded=@('.github','.husky','.vscode') }
  Write-Output "Imported $($source.Name) -> modules/valorant/$($source.Target)"
}
$records | ConvertTo-Json -Depth 5 | Set-Content -LiteralPath (Join-Path $workspace 'modules/valorant/upstream.json') -Encoding utf8
