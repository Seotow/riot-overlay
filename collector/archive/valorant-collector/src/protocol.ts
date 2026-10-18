// Giao thức ingest của Spectra Server và các hàm đổi dữ liệu GEP sang định dạng đó.
// Dịch từ Spectra Client (services/formattingService.ts, GPL-3.0-only), chỉ nhánh observer. Xem NOTICE.md.

export enum DataTypes {
  SCOREBOARD = "scoreboard",
  KILLFEED = "killfeed",
  ROSTER = "roster",
  MATCH_START = "match_start",
  ROUND_INFO = "round_info",
  SCORE = "score",
  GAME_MODE = "game_mode",
  MAP = "map",
  OBSERVING = "observing",
  SPIKE_DETONATED = "spike_detonated",
  SPIKE_DEFUSED = "spike_defused",
  AUTH = "authenticate",
  // Lệnh thủ công của operator
  SPIKE_PLANTED = "spike_planted",
  TECH_PAUSE = "tech_pause",
  LEFT_TIMEOUT = "left_timeout",
  RIGHT_TIMEOUT = "right_timeout",
  SWITCH_KDA_CREDITS = "switch_kda_credits",
  TOAST = "toast",
  SWAP_L_R = "swap_left_right",
  SWAP_A_D = "swap_attacker_defender",
  // Riot Overlay: cập nhật tên/logo đội, loạt trận, giải, tên thay thế giữa trận (backend fork)
  CONFIG_UPDATE = "config_update",
}

export enum SocketChannels {
  OBSERVER_LOGON = "obs_logon",
  OBSERVER_DATA = "obs_data",
}

export interface FormattedData {
  type: string;
  data: unknown;
}

export interface FormattedScoreboard {
  name: string;
  tagline: string;
  playerId: string;
  startTeam: number;
  agentInternal: string;
  isAlive: boolean;
  initialArmor: number;
  scoreboardWeaponInternal: string;
  currUltPoints: number;
  maxUltPoints: number;
  hasSpike: boolean;
  money: number;
  kills: number;
  deaths: number;
  assists: number;
}

export function formatScoreboardData(data: any): FormattedData {
  const nameSplit = String(data.name).split(" #");
  // Một số bản GEP gửi spike là boolean, bản khác là chuỗi.
  const hasSpike = typeof data.spike === "boolean" ? data.spike : data.spike === "TX_Hud_Bomb_S";
  // Giáp từng đổi tên từ shield sang armor.
  const armor = data.armor != undefined ? data.armor : data.shield;
  const formatted: FormattedScoreboard = {
    name: nameSplit[0],
    tagline: nameSplit[1],
    playerId: data.player_id,
    startTeam: data.team,
    agentInternal: data.character,
    isAlive: data.alive,
    initialArmor: armor,
    scoreboardWeaponInternal: data.weapon,
    currUltPoints: data.ult_points,
    maxUltPoints: data.ult_max,
    hasSpike,
    money: data.money,
    kills: data.kills,
    deaths: data.deaths,
    assists: data.assists,
  };
  return { type: DataTypes.SCOREBOARD, data: formatted };
}

export function formatKillfeedData(data: any): FormattedData {
  const assists = [data.assist1, data.assist2, data.assist3, data.assist4].filter(
    (a) => a !== "" && a !== undefined,
  );
  return {
    type: DataTypes.KILLFEED,
    data: {
      attacker: data.attacker,
      victim: data.victim,
      weaponKillfeedInternal: data.weapon,
      headshotKill: data.headshot,
      assists,
      isTeamkill: data.is_victim_teammate,
    },
  };
}

export function formatRosterData(data: any, rosterTag: string): FormattedData {
  const nameSplit = String(data.name).split(" #");
  return {
    type: DataTypes.ROSTER,
    data: {
      name: nameSplit[0],
      tagline: nameSplit[1] ? nameSplit[1] : "",
      startTeam: data.team,
      agentInternal: data.character,
      playerId: data.player_id,
      position: +rosterTag.split("_")[1],
      locked: data.locked,
      rank: data.rank,
    },
  };
}

export function formatRoundData(phase: string, roundNumber: number): FormattedData {
  return { type: DataTypes.ROUND_INFO, data: { roundNumber, roundPhase: phase } };
}
