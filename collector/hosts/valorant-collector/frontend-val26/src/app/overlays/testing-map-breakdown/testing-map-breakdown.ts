import { Component, inject, OnDestroy, OnInit, signal } from "@angular/core";
import {
  StatsApiMatch,
  StatsApiMatchPlayer,
  StatsApiMatchTeam,
  StatsApiCeremonies,
  StatsApiWinReasons,
} from "../../components/breakdown/StatsApiMapping";
import { TranslateKeys } from "../../services/i18nHelper";
import { TranslatePipe } from "@ngx-translate/core";
import { DataModelService } from "../../services/dataModel.service";

@Component({
  selector: "app-testing-map-breakdown",
  imports: [TranslatePipe],
  templateUrl: "./testing-map-breakdown.html",
  styleUrl: "./testing-map-breakdown.css",
})
export class TestingMapBreakdown implements OnInit, OnDestroy {
  TranslateKeys = TranslateKeys;

  dataModel = inject(DataModelService);

  protected hideBg = false;
  protected statsData?: StatsApiMatch;

  protected currentSponsorIndex = signal(0);
  private sponsorIntervalId?: number;
  protected roundsPlayed = 0;

  protected leftTeam?: StatsApiMatchTeam;
  protected rightTeam?: StatsApiMatchTeam;

  protected leftPlayers?: StatsApiMatchPlayer[];
  protected rightPlayers?: StatsApiMatchPlayer[];

  protected leftFirstKills = 0;
  protected rightFirstKills = 0;

  protected leftTotalKills = 0;
  protected rightTotalKills = 0;

  protected leftAverageACS = 0;
  protected rightAverageACS = 0;

  protected leftAverageLoadoutValue = 0;
  protected rightAverageLoadoutValue = 0;

  protected leftRetakeRate = 0;
  protected rightRetakeRate = 0;

  protected leftKillTradeRate = 0;
  protected rightKillTradeRate = 0;

  protected leftThrifties = 0;
  protected leftAces = 0;
  protected leftClutches = 0;
  protected leftFlawless = 0;
  protected leftWonPostPlants = 0;

  protected rightThrifties = 0;
  protected rightAces = 0;
  protected rightClutches = 0;
  protected rightFlawless = 0;
  protected rightWonPostPlants = 0;

  protected roundReasons: Record<
    number,
    { winner: 0 | 1; reason: "defused" | "detonated" | "kills" | "timeout" }
  > = {};

  ngOnInit() {
    this.initializeMockData();
  }

  ngOnDestroy() {
    if (this.sponsorIntervalId) {
      clearInterval(this.sponsorIntervalId);
    }
  }

  private initializeMockData() {
    const mockPlayers = this.createMockPlayers();
    const mockRounds = this.createMockRounds();

    this.statsData = {
      metadata: {
        match_id: "test-match-001",
        map: { id: "ascent", name: "Ascent" },
        game_version: "8.0.0",
        game_length_in_ms: 2400000,
        started_at: new Date().toISOString(),
        is_completed: true,
        queue: { id: "competitive", name: "Competitive", mode_type: "competitive" },
        season: { id: "season-1", short: "E8A1" },
        platform: "pc",
        premier: null,
        party_rr_penaltys: [],
        region: "eu",
        cluster: null,
      },
      players: mockPlayers,
      observers: [],
      coaches: [],
      teams: [
        {
          name: "Team Alpha",
          tricode: "ALP",
          url: "assets/misc/icon.webp",
          team_id: "Blue",
          rounds: { won: 13, lost: 9 },
          won: true,
          premier_roster: null,
        },
        {
          name: "Team Omega",
          tricode: "OMG",
          url: "assets/misc/icon.webp",
          team_id: "Red",
          rounds: { won: 9, lost: 13 },
          won: false,
          premier_roster: null,
        },
      ],
      rounds: mockRounds,
      kills: this.createMockKills(mockPlayers),
    };

    this.roundsPlayed = this.statsData.rounds.length;
    this.processStatsData();

    // Inject mock tournament and sponsor data for testing
    this.dataModel.match.update((data) => ({
      ...data,
      tools: {
        ...data.tools,
        tournamentInfo: {
          name: "Test Tournament",
          logoUrl: "assets/misc/icon.webp",
          backdropUrl: "",
        },
        sponsorInfo: {
          enabled: true,
          duration: 5000,
          sponsors: ["assets/misc/logo.webp"],
        },
      },
    }));

    const sponsorInfo = this.dataModel.sponsorInfo();
    if (sponsorInfo.enabled && sponsorInfo.sponsors.length > 1) {
      const duration =
        sponsorInfo.duration > 100 ? sponsorInfo.duration : sponsorInfo.duration * 1000;
      this.sponsorIntervalId = window.setInterval(() => {
        this.currentSponsorIndex.update(
          (i) => (i + 1) % this.dataModel.sponsorInfo().sponsors.length,
        );
      }, duration);
    }
  }

  private processStatsData() {
    this.leftTeam = this.statsData!.teams.find((team) => team.team_id === "Blue");
    this.rightTeam = this.statsData!.teams.find((team) => team.team_id === "Red");

    this.calculateFirstKills();

    this.leftPlayers = this.statsData!.players.filter((player) => player.team_id === "Blue");
    this.rightPlayers = this.statsData!.players.filter((player) => player.team_id === "Red");

    this.leftPlayers.forEach((player) => {
      player.stats.acs = Math.round(player.stats.score / (this.roundsPlayed || 1));
    });
    this.rightPlayers.forEach((player) => {
      player.stats.acs = Math.round(player.stats.score / (this.roundsPlayed || 1));
    });

    this.leftPlayers.forEach((player) => {
      this.leftAverageACS += player.stats.acs || 0;
    });
    this.rightPlayers.forEach((player) => {
      this.rightAverageACS += player.stats.acs || 0;
    });

    this.leftAverageACS = Math.round(this.leftAverageACS / (this.leftPlayers?.length || 1));
    this.rightAverageACS = Math.round(this.rightAverageACS / (this.rightPlayers?.length || 1));

    this.leftTotalKills = this.leftPlayers.reduce(
      (sum, player) => sum + (player.stats.kills || 0),
      0,
    );
    this.rightTotalKills = this.rightPlayers.reduce(
      (sum, player) => sum + (player.stats.kills || 0),
      0,
    );

    this.calculateKillTradeRates();

    this.leftAverageLoadoutValue = Math.round(
      this.leftPlayers.reduce(
        (sum, player) => sum + (player.economy.loadout_value.average || 0),
        0,
      ) / (this.leftPlayers?.length || 1),
    );
    this.rightAverageLoadoutValue = Math.round(
      this.rightPlayers.reduce(
        (sum, player) => sum + (player.economy.loadout_value.average || 0),
        0,
      ) / (this.rightPlayers?.length || 1),
    );

    this.processRounds();
  }

  private processRounds() {
    let leftRetakeOpportunities = 0;
    let rightRetakeOpportunities = 0;
    let leftRetakeSuccesses = 0;
    let rightRetakeSuccesses = 0;

    this.statsData!.rounds.forEach((round) => {
      if (round.plant != null) {
        if (round.plant.player.team === "Red") {
          leftRetakeOpportunities++;
          if (round.winning_team === "Blue") {
            leftRetakeSuccesses++;
          }
        } else if (round.plant.player.team === "Blue") {
          rightRetakeOpportunities++;
          if (round.winning_team === "Red") {
            rightRetakeSuccesses++;
          }
        }
      }

      switch (round.ceremony) {
        case StatsApiCeremonies.Thrifty:
          if (round.winning_team === "Blue") {
            this.leftThrifties++;
          } else if (round.winning_team === "Red") {
            this.rightThrifties++;
          }
          break;
        case StatsApiCeremonies.Ace:
          if (round.winning_team === "Blue") {
            this.leftAces++;
          } else if (round.winning_team === "Red") {
            this.rightAces++;
          }
          break;
        case StatsApiCeremonies.Clutch:
          if (round.winning_team === "Blue") {
            this.leftClutches++;
          } else if (round.winning_team === "Red") {
            this.rightClutches++;
          }
          break;
        case StatsApiCeremonies.Flawless:
          if (round.winning_team === "Blue") {
            this.leftFlawless++;
          } else if (round.winning_team === "Red") {
            this.rightFlawless++;
          }
          break;
        default:
          break;
      }

      if (round.plant != null) {
        if (round.winning_team === "Blue") {
          this.leftWonPostPlants++;
        } else if (round.winning_team === "Red") {
          this.rightWonPostPlants++;
        }
      }

      switch (round.result) {
        case StatsApiWinReasons.Timeout:
          this.roundReasons[round.id] = {
            winner: round.winning_team === "Blue" ? 0 : 1,
            reason: "timeout",
          };
          break;
        case StatsApiWinReasons.Defused:
          this.roundReasons[round.id] = {
            winner: round.winning_team === "Blue" ? 0 : 1,
            reason: "defused",
          };
          break;
        case StatsApiWinReasons.Detonated:
          this.roundReasons[round.id] = {
            winner: round.winning_team === "Blue" ? 0 : 1,
            reason: "detonated",
          };
          break;
        case StatsApiWinReasons.Kills:
          this.roundReasons[round.id] = {
            winner: round.winning_team === "Blue" ? 0 : 1,
            reason: "kills",
          };
          break;
        default:
          this.roundReasons[round.id] = {
            winner: round.winning_team === "Blue" ? 0 : 1,
            reason: "timeout",
          };
          break;
      }
    });

    this.leftRetakeRate = Math.round((leftRetakeSuccesses / (leftRetakeOpportunities || 1)) * 100);
    this.rightRetakeRate = Math.round(
      (rightRetakeSuccesses / (rightRetakeOpportunities || 1)) * 100,
    );
  }

  private createMockPlayers(): StatsApiMatchPlayer[] {
    const agents = [
      "Jett",
      "Phoenix",
      "Omen",
      "Sage",
      "Sova",
      "Reyna",
      "Killjoy",
      "Cypher",
      "Viper",
      "Raze",
    ];
    const players: StatsApiMatchPlayer[] = [];

    for (let i = 0; i < 10; i++) {
      const isLeftTeam = i < 5;
      const teamId = isLeftTeam ? "Blue" : "Red";
      const playerNum = isLeftTeam ? i + 1 : i - 4;

      players.push({
        puuid: `player-${i}`,
        name: isLeftTeam ? `Player${playerNum}` : `Enemy${playerNum}`,
        tag: `${1000 + i}`,
        team_id: teamId,
        platform: "pc",
        party_id: `party-${teamId}`,
        agent: { id: agents[i].toLowerCase(), name: agents[i] },
        stats: {
          score: Math.floor(Math.random() * 3000) + 2000,
          kills: Math.floor(Math.random() * 20) + 8,
          firstKills: 0,
          deaths: Math.floor(Math.random() * 15) + 3,
          assists: Math.floor(Math.random() * 10) + 2,
          headshots: Math.floor(Math.random() * 30) + 10,
          legshots: Math.floor(Math.random() * 10) + 5,
          bodyshots: Math.floor(Math.random() * 50) + 20,
          damage: {
            dealt: Math.floor(Math.random() * 3000) + 1500,
            received: Math.floor(Math.random() * 2500) + 1000,
          },
        },
        ability_casts: { grenade: 10, ability1: 15, ability2: 12, ultimate: 3 },
        tier: { id: 21, name: "Immortal 1" },
        card_id: "card-1",
        title_id: "title-1",
        prefered_level_border: null,
        account_level: 250,
        session_playtime_in_ms: 2400000,
        behavior: {
          afk_rounds: 0,
          friendly_fire: { incoming: 0, outgoing: 0 },
          rounds_in_spawn: 0,
        },
        economy: {
          spent: { overall: 45000, average: 2045 },
          loadout_value: { overall: 52000, average: 2364 },
        },
      });
    }

    return players;
  }

  private createMockRounds() {
    const rounds = [];
    const ceremonies = [
      StatsApiCeremonies.Default,
      StatsApiCeremonies.Thrifty,
      StatsApiCeremonies.Ace,
      StatsApiCeremonies.Clutch,
      StatsApiCeremonies.Flawless,
    ];
    const results = [
      StatsApiWinReasons.Kills,
      StatsApiWinReasons.Defused,
      StatsApiWinReasons.Detonated,
    ];

    for (let i = 1; i <= 23; i++) {
      const winningTeam = i % 3 === 0 ? "Red" : "Blue";
      const hasPlant = Math.random() > 0.3;

      rounds.push({
        id: i,
        result: results[Math.floor(Math.random() * results.length)],
        ceremony: ceremonies[Math.floor(Math.random() * ceremonies.length)],
        winning_team: winningTeam,
        plant: hasPlant
          ? {
              round_time_in_ms: 45000,
              site: "A",
              location: { x: 100, y: 200 },
              player: { puuid: "player-5", name: "Enemy1", tag: "1005", team: "Red" },
              player_locations: [],
            }
          : null,
        defuse: null,
        stats: [],
      });
    }
    return rounds;
  }

  private createMockKills(players: StatsApiMatchPlayer[]) {
    const kills = [];
    for (let round = 1; round <= 22; round++) {
      // Create multiple kills per round for realistic trade calculations
      for (let killNum = 0; killNum < 5 + Math.floor(Math.random() * 5); killNum++) {
        const killer = players[Math.floor(Math.random() * 10)];
        const victim = players.find((p) => p.team_id !== killer.team_id)!;

        kills.push({
          round,
          time_in_round_in_ms: 15000 + killNum * 3000 + Math.floor(Math.random() * 2000),
          time_in_match_in_ms: round * 120000 + killNum * 3000,
          killer: { puuid: killer.puuid, name: killer.name, tag: killer.tag, team: killer.team_id },
          victim: { puuid: victim.puuid, name: victim.name, tag: victim.tag, team: victim.team_id },
          assistants: [],
          location: { x: 100, y: 200 },
          weapon: { id: "vandal", name: "Vandal", type: "weapon" as const },
          secondary_fire_mode: false,
          player_locations: [],
        });
      }
    }
    return kills;
  }

  calculateFirstKills() {
    const fkById: Record<string, number> = {};
    this.statsData?.players.forEach((player) => {
      fkById[player.puuid] = 0;
    });

    let currentRound = -1;
    for (const kill of this.statsData?.kills || []) {
      if (kill.round !== currentRound) {
        currentRound = kill.round;
        fkById[kill.killer.puuid] = (fkById[kill.killer.puuid] || 0) + 1;
      }
    }

    for (const player of this.statsData?.players || []) {
      player.stats.firstKills = fkById[player.puuid] || 0;
      if (player.team_id === "Blue") {
        this.leftFirstKills += player.stats.firstKills || 0;
      } else if (player.team_id === "Red") {
        this.rightFirstKills += player.stats.firstKills || 0;
      }
    }
  }

  private calculateKillTradeRates() {
    const kills = [...(this.statsData?.kills || [])].sort(
      (a, b) => a.round - b.round || a.time_in_round_in_ms - b.time_in_round_in_ms,
    );

    let leftEligibleKills = 0;
    let rightEligibleKills = 0;
    let leftTradedKills = 0;
    let rightTradedKills = 0;

    for (let index = 0; index < kills.length; index++) {
      const kill = kills[index];

      if (!kill?.killer?.puuid || !kill?.victim?.puuid) {
        continue;
      }

      if (kill.killer.team === kill.victim.team) {
        continue;
      }

      if (kill.killer.team === "Blue") {
        leftEligibleKills++;
      } else if (kill.killer.team === "Red") {
        rightEligibleKills++;
      } else {
        continue;
      }

      let isTradedWithinFiveSeconds = false;
      for (let nextIndex = index + 1; nextIndex < kills.length; nextIndex++) {
        const nextKill = kills[nextIndex];

        if (nextKill.round !== kill.round) {
          break;
        }

        if (nextKill.time_in_round_in_ms - kill.time_in_round_in_ms > 5000) {
          break;
        }

        if (
          nextKill.killer.team === kill.victim.team &&
          nextKill.victim.puuid === kill.killer.puuid
        ) {
          isTradedWithinFiveSeconds = true;
          break;
        }
      }

      if (isTradedWithinFiveSeconds) {
        if (kill.killer.team === "Blue") {
          leftTradedKills++;
        } else {
          rightTradedKills++;
        }
      }
    }

    this.leftKillTradeRate = Math.round((leftTradedKills / (leftEligibleKills || 1)) * 100);
    this.rightKillTradeRate = Math.round((rightTradedKills / (rightEligibleKills || 1)) * 100);
  }

  numSequence(n: number): number[] {
    return Array(n);
  }

  roundReasonValues() {
    return Object.values(this.roundReasons);
  }
}
