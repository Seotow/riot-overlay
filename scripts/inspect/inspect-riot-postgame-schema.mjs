// Public Riot reference only. Does not read credentials or query player/match APIs.
import { mkdir, writeFile } from "node:fs/promises";
const base = "https://developer.riotgames.com";
const clean = (s) =>
  s
    .replace(/<[^>]+>/g, " ")
    .replace(/\s+/g, " ")
    .trim();
const report = {
  kind: "official-reference-schema-not-gameplay-response",
  inspectedAt: new Date().toISOString(),
  sources: [],
  dto: {},
};
for (const api of ["match-v5", "lol-rso-match-v1"]) {
  const url = `${base}/api-details/${api}`;
  const response = await fetch(url, {
    redirect: "error",
    signal: AbortSignal.timeout(15000),
  });
  if (!response.ok) throw Error(`Public reference ${api} HTTP ${response.status}`);
  const { html } = await response.json();
  if (typeof html !== "string") throw Error("Reference has no HTML schema");
  report.sources.push({
    api,
    url,
    status: response.status,
    routes: [...new Set(html.match(/\/lol\/(?:match|rso-match)\/v\d[^<\s"']*/g) ?? [])],
    seaServesVn2: clean(html).includes("SEA routing value serves OCE, SG2, TW2 and VN2")
      ? true
      : null,
    requiresAuthorizationHeader: /Authorization/.test(html),
  });
  if (api !== "match-v5") continue;
  for (const dto of [
    "InfoDto",
    "ParticipantDto",
    "TeamDto",
    "BanDto",
    "ObjectivesDto",
    "ObjectiveDto",
    "InfoTimeLineDto",
    "FramesTimeLineDto",
    "EventsTimeLineDto",
    "ParticipantFrameDto",
    "DamageStatsDto",
  ]) {
    const i = html.indexOf(`-${dto}"`);
    if (i < 0) throw Error(`Missing reference DTO ${dto}`);
    const tail = html.slice(i),
      start = tail.indexOf("<table"),
      end = tail.indexOf("</table>");
    if (start < 0 || end < start) throw Error(`Missing DTO table ${dto}`);
    const rows = [...tail.slice(start, end + 8).matchAll(/<tr[\s\S]*?<\/tr>/g)]
      .map((m) => [...m[0].matchAll(/<td[^>]*>([\s\S]*?)<\/td>/g)].map((n) => clean(n[1])))
      .filter((r) => r.length >= 2);
    // Save field names/types, not provider identities, samples or quoted descriptions.
    report.dto[dto] = Object.fromEntries(rows.map(([field, type]) => [field, type]));
  }
}
report.coverage = {
  matchDamage: "totalDamageDealtToChampions" in report.dto.ParticipantDto,
  timelineDamage: "totalDamageDoneToChampions" in report.dto.DamageStatsDto,
  teamWinner: "win" in report.dto.TeamDto,
  bans: "bans" in report.dto.TeamDto,
  totalGoldHistory: "totalGold" in report.dto.ParticipantFrameDto,
  timestampResolutionDeclared: "frameInterval" in report.dto.InfoTimeLineDto,
  separateElderTeamCounter:
    "elder" in report.dto.ObjectivesDto || "elderDragon" in report.dto.ObjectivesDto,
  eventSubtypeDocumented: "monsterSubType" in report.dto.EventsTimeLineDto,
};
await mkdir(".npm-cache", { recursive: true });
await writeFile(".npm-cache/riot-postgame-schema.json", JSON.stringify(report, null, 2));
console.log(
  JSON.stringify(
    {
      kind: report.kind,
      sources: report.sources,
      coverage: report.coverage,
      fieldsPerDto: Object.fromEntries(
        Object.entries(report.dto).map(([k, v]) => [k, Object.keys(v).length]),
      ),
      output: ".npm-cache/riot-postgame-schema.json",
    },
    null,
    2,
  ),
);
