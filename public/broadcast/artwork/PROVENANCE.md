# Dragon Soul artwork

## Active: Riot 2D artwork — 11/10/2026

`riot-dragons/` contains six distinct static WebP runtime images. Four originate
from official Riot LoR Data Dragon pinned to `7_10_0`; Hextech is the official
Preseason 2022 key art hosted on Riot CDN. Infernal is a pre-rendered raster
image hosted by Dignitas (not a painting and not a runtime 3D model).
Original bytes, URLs, page links and both source/output SHA-256 hashes are recorded
in `riot-dragons/provenance.json`. Reproduce with `node scripts/sync-dragon-art.mjs`
(network and sharp required; `OVERLAY_BROWSER_PACKAGES` may point to the installed
runtime package directory). Infernal's edge-connected white matte is removed
offline with a deterministic flood fill; original bytes remain unchanged.
Sharp only runs offline during asset synchronization,
not in the frontend. Output fits 1600×900 without enlarging; WebP quality 85.

| Element | Card | Artwork |
| --- | --- | --- |
| Water | 08IO012 | Ocean Drake creature illustration |
| Air | 08DE025 | Cloud Drake creature illustration |
| Earth | 05DE015 | Mountain Drake creature illustration |
| Chemtech | 08PZ028 | Chemtech Drake creature illustration |
| Fire | LoL static render | Infernal Drake; Dignitas mirror, 1263×550 original |
| Hextech | Preseason Key Art 2022 | Creature illustration, Riot CDN, 1920×1080 original |

These are Riot-owned artworks, **not** the exact Worlds broadcast artwork
pack or a claim of unrestricted redistribution. The client crops the five
creature illustrations individually in CSS; Infernal uses a short raster region.
No hue shifting, generated images, game screenshot, HUD, sponsor or runtime 3D is used.
Unknown elements have a neutral panel without invented artwork.

Sources checked: `BlueBottleGG/leaguebroadcast-js-client-demo` (dragon icons),
`rcv-prod-toolkit/module-league-in-game` (minimap/icons). No complete large
six-element creature art pack was found there. Riot's LoR catalog supplied
four images. Further research found Hextech creature key art and Infernal raster
render. A matching large **painted** Infernal illustration remains unfound.
Documentation: https://developer.riotgames.com/docs/lor

Hextech source page: https://www.leagueoflegends.com/en-us/news/dev/quick-gameplay-thoughts-1-14-preseason-2022/

Infernal source page: https://dignitas.gg/articles/an-in-depth-overview-of-all-seven-dragons-league-of-legends-season-13

The previous `fire.png`/`hextech.png` boon emblems and other original PNG copies
are retained for recovery but are no longer referenced by the renderer.

## Retired: AI-generated v1 (unused, retained for recovery)

- File: `dragon-soul-v1.png`.
- Created 11/10/2026 using the built-in imagegen tool, not CLI/API fallback.
- Original AI-generated replacement illustration, not an official Riot asset or extracted reference panel. No sponsor, logo, text or game HUD is baked in.
- Base palette: aquatic teal. Other elements hue-shift this same generic illustration, **not** distinct official elemental dragon artworks. Identity comes from the observed event's HTML label.
- Dynamic team/type text remains separate. No unverified healing percentage is displayed.

## Final generation prompt

Use case: stylized-concept. Asset type: original background illustration for a narrow esports Dragon Soul takeover panel, displayed at 286 by 600 pixels. Create a tall portrait image with approximately 1:2 aspect ratio. An impressive teal aquatic fantasy dragon in side profile, head facing up and right, neck entering from left bottom, sweeping turquoise water and luminous cyan sky. Polished painterly game splash-art treatment, clearly readable majestic dragon silhouette at small broadcast size. Composition: dragon face centered around 40 percent from top, lower 30 percent dark teal negative space for HTML title; upper 20 percent relatively calm dark turquoise negative space for team name. Subject should span panel width. No text whatsoever, no typography, no sponsor, no Mastercard circles, no Riot or tournament logo, no watermark, no UI, no screenshot, no champion, no border. Fully opaque background. This is a new original illustration, not a recreation of a proprietary dragon artwork.
