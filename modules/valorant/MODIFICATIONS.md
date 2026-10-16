# Riot Overlay local fork

Imported 13/10/2026 from the exact revisions in `upstream.json`. Original code,
assets and copyright/license notices remain in each package. No remote fork,
push, release, upstream key bypass or watermark removal has been performed.

Local modifications:

- Added `runtime/` for independent Node supervisor, config, readiness, exclusive
  ownership, port checks, static frontend and collector executable startup.
- Backend binds only `127.0.0.1`, accepts configured ports and local browser
  origins, bounds Socket.IO messages, and confines data to authenticated session.
- HTTP status reports observer socket connectivity separately from process
  readiness. Added read-only `source_status` on output; last ingest time is not
  proof of per-field freshness or frame acquisition time.
- Disabled upstream raw replay persistence and default private payload logging.
  Preview creation is disabled by the supervisor, not used as live data.
- Frontend assets/config are served locally with endpoints from module config;
  cloud mapban/stats/testing routes are not exposed by this launcher. Bundled
  Fontsource fonts and OFL licenses replace runtime Google Fonts requests.
- Fixed browser timer types. Match and agent-select routes do not render initial
  fixture state before a source sample, on socket loss or after 5 seconds without
  ingest updates. HP gauge requires auxiliary health availability. This is a
  conservative gate, not a complete telemetry capability implementation.
- Added npm locks for backend/frontend; installation uses `--ignore-scripts`.
  Collector source is imported for future customization, not yet built/run.
  Running an existing upstream executable does not apply these source changes.
- Acquired official Client v0.3.4 archive (matching GitHub release SHA256),
  extracted unmodified into ignored data runtime; executable/ASAR identity in
  `collector-release.json`. Added config path setter with backup; key/ports stay
  intact. GUI is shown for operator interaction; backend/helpers remain hidden.
  The official binary uses upstream AppData profile/logs, not a project-isolated
  collector profile. Window/log version markers verified Observer + GEP 315.1.0
  Ready; no game telemetry or authenticated backend connection yet.
- Added lifecycle/Socket.IO and isolated browser tests. Synthetic test messages
  verify transport, not game coverage or correctness.

License inventory: Client has GPL-3.0 LICENSE/package metadata; Server/Frontend
have ELv2 LICENSE.md. Server package.json says GPL-3.0-only while its LICENSE.md
says ELv2; both upstream files are preserved. Do not assume the root ISC metadata
relicenses these components. Distribution/hosting and deeper source merging
must resolve the upstream license discrepancy first. Local implementation
preserves auth and watermark functionality.

Excluded import files: GitHub CI, Husky hooks and editor settings, recorded in
`upstream.json`. Upstream yarn locks remain as reference; npm locks govern these
local BE/FE builds. Do not enable `prepare` to install nested upstream Git hooks.
