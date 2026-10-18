import { Component, OnInit, OnDestroy, inject, signal } from "@angular/core";
import { MvpPlayer } from "../../components/breakdown/mvp-player/mvp-player";
import { RegularPlayer } from "../../components/breakdown/regular-player/regular-player";
import {
  StatsApiMatch,
  StatsApiMatchPlayer,
  StatsApiMatchTeam,
} from "../../components/breakdown/StatsApiMapping";
import { TranslateKeys } from "../../services/i18nHelper";
import { TranslatePipe } from "@ngx-translate/core";
import { DataModelService } from "../../services/dataModel.service";

@Component({
  selector: "app-testing-team-breakdown",
  imports: [MvpPlayer, RegularPlayer, TranslatePipe],
  templateUrl: "./testing-team-breakdown.html",
  styleUrl: "./testing-team-breakdown.css",
})
export class TestingTeamBreakdown implements OnInit, OnDestroy {
  dataModel = inject(DataModelService);

  TranslateKeys = TranslateKeys;

  protected hideBg = false;
  protected statsData?: StatsApiMatch;

  protected currentSponsorIndex = signal(0);
  private sponsorIntervalId?: number;
  protected roundsPlayed = 0;

  protected leftTeam?: StatsApiMatchTeam;
  protected rightTeam?: StatsApiMatchTeam;

  protected leftPlayers?: StatsApiMatchPlayer[];
  protected rightPlayers?: StatsApiMatchPlayer[];

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
      rounds: this.createMockRounds(),
      kills: this.createMockKills(mockPlayers),
    };

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

    this.roundsPlayed = this.statsData.rounds.length;

    this.leftTeam = this.statsData.teams.find((team) => team.team_id === "Blue");
    this.rightTeam = this.statsData.teams.find((team) => team.team_id === "Red");

    this.calculateFirstKills();

    this.leftPlayers = this.statsData.players.filter((player) => player.team_id === "Blue");
    this.rightPlayers = this.statsData.players.filter((player) => player.team_id === "Red");

    this.leftPlayers.forEach((player) => {
      player.stats.acs = Math.round(player.stats.score / (this.roundsPlayed || 1));
    });
    this.rightPlayers.forEach((player) => {
      player.stats.acs = Math.round(player.stats.score / (this.roundsPlayed || 1));
    });

    this.leftPlayers.sort((a, b) => (b.stats.acs || 0) - (a.stats.acs || 0));
    this.rightPlayers.sort((a, b) => (b.stats.acs || 0) - (a.stats.acs || 0));
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
        name: isLeftTeam ? `Player ${playerNum}` : `Enemy ${playerNum}`,
        tag: `${1000 + i}`,
        team_id: teamId,
        platform: "pc",
        party_id: `party-${teamId}`,
        agent: { id: agents[i].toLowerCase(), name: agents[i] },
        stats: {
          score: Math.floor(Math.random() * 3000) + 2000,
          kills: Math.floor(Math.random() * 20) + 5,
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
    for (let i = 1; i <= 22; i++) {
      rounds.push({
        id: i,
        result: "Elimination" as const,
        ceremony: "CeremonyDefault" as const,
        winning_team: i % 3 === 0 ? "Red" : "Blue",
        plant: null,
        defuse: null,
        stats: [],
      });
    }
    return rounds;
  }

  private createMockKills(players: StatsApiMatchPlayer[]) {
    const kills = [];
    for (let round = 1; round <= 22; round++) {
      const killer = players[Math.floor(Math.random() * 10)];
      const victim = players.find((p) => p.team_id !== killer.team_id)!;

      kills.push({
        round,
        time_in_round_in_ms: 15000,
        time_in_match_in_ms: round * 120000,
        killer: { puuid: killer.puuid, name: killer.name, tag: killer.tag, team: killer.team_id },
        victim: { puuid: victim.puuid, name: victim.name, tag: victim.tag, team: victim.team_id },
        assistants: [],
        location: { x: 100, y: 200 },
        weapon: { id: "vandal", name: "Vandal", type: "weapon" as const },
        secondary_fire_mode: false,
        player_locations: [],
      });
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
    }
  }

  numSequence(n: number): number[] {
    return Array(n);
  }
}
