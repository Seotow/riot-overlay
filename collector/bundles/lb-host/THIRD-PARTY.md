# Provenance

- `src/LeagueCollector`: new standalone host, local API, recording/replay and
  source adapters written for this task.
- `src/LeagueCollector/SrpHelper.cs`: recovered BlueBottle SRP helper, with type
  and namespace renamed and a zero-server-B validation added. It uses the same
  official Cognito SRP flow as the inspected client.
- `vendor/Farsight`: repaired ILSpy export of the shipped Farsight assembly.
  Original raw export is retained separately in the analysis workspace. This is
  recovered code, not the original repository or an assertion of a new license.
- Additional standalone fork changes: public `PreferTcpTransport` setting in
  LeagueConnector and its forwarding property/selection in FarsightSocketClient.
  TCP still calls the original process/session-verified transport; feature
  requests, signature verification and native policy are unchanged. The project
  disables source analyzers for already recovered generated interop bodies.
- `lib`: original AWS SDK, FlatSharp, SigV4 and framework support components from
  the official LB portable distribution; Farsight.dll is rebuilt from vendor.
- `native/lblib.dll`: original authorized download, unchanged SHA-256 recorded in
  its sidecar. C++ source recovery is incomplete.
- `analysis/native` in the source archive: the current native analysis report,
  selected assembly evidence and 246 decompiler pseudocode files. These are not
  buildable original C++ sources. Evidence IDs/source-workspace paths in those
  reports may refer to the separate analysis workspace; raw server responses
  and account credentials are not included.
- Bundled Windows runtime: Microsoft .NET and ASP.NET Core 10.0.13; original
  runtime LICENSE/ThirdPartyNotices files retained. Official download metadata
  and SHA-512 verification are included in verification.

This private delivery does not publish a repository or alter upstream licensing.
