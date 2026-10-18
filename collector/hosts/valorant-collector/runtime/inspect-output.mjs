// Read-only output handshake probe. Never authenticates ingest or saves raw state.
import { io } from '../backend/node_modules/socket.io-client/build/esm/index.js';
import { loadConfig, defaultConfigPath } from './config.mjs';
const config = await loadConfig(defaultConfigPath);
const socket = io(`http://127.0.0.1:${config.ports.output}`, { transports: ['websocket'], reconnection: false });
const timer = setTimeout(() => { console.error('No snapshot for configured group; source coverage unverified.'); socket.disconnect(); process.exitCode = 1; }, 5000);
socket.once('connect', () => socket.emit('logon', JSON.stringify({ groupCode: config.groupCode })));
socket.once('match_data', payload => {
  try {
    const data = JSON.parse(payload);
    const teams = Array.isArray(data.teams) ? data.teams : [];
    const players = teams.flatMap(team => Array.isArray(team.players) ? team.players : []);
    console.log(JSON.stringify({ capturedAt: new Date().toISOString(), outputHandshake: 'confirmed',
      configuredGroupMatched: data.groupCode === config.groupCode, providerIsRunning: data.isRunning === true,
      rosterSlots: players.length, scoreboardSlots: players.filter(p => p.scoreboardAvailable === true).length,
      auxiliaryHealthSlots: players.filter(p => p.auxiliaryAvailable?.health === true).length,
      auxiliaryAbilitySlots: players.filter(p => p.auxiliaryAvailable?.abilities === true).length,
      roundPhase: ['LOBBY', 'shopping', 'combat', 'end', 'game_end'].includes(data.roundPhase) ? data.roundPhase : null,
      gameTelemetryVerified: false }, null, 2));
  } catch { console.error('Invalid output snapshot'); process.exitCode = 1; }
  clearTimeout(timer); socket.disconnect();
});
