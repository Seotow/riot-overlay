import { open } from "node:fs/promises";
import { basename } from "node:path";
import { reduceRofl, type RoflInput } from "../shared/rofl-postgame";

const FILE_NAME = /^[A-Z0-9]{2,6}-(\d{1,15})\.rofl$/i;

// Game id from a replay file name such as VN2-1607368559.rofl, or null for any other name.
export function roflGameId(name: string): number | null {
  const m = FILE_NAME.exec(basename(name));
  return m ? Number(m[1]) : null;
}

// Reads only the metadata JSON at the tail of a ROFL2 file (bounded) and returns anonymous rows.
// The replay is never executed and its packets are never decoded.
export async function readRofl(path: string): Promise<RoflInput> {
  const gameId = roflGameId(path);
  if (!gameId) throw Error("invalid-rofl-name");
  const file = await open(path, "r");
  try {
    const { size } = await file.stat();
    if (size < 16 || size > 400 * 1024 * 1024) throw Error("invalid-rofl");
    const head = Buffer.alloc(8);
    const tail = Buffer.alloc(4);
    await file.read(head, 0, 8, 0);
    await file.read(tail, 0, 4, size - 4);
    if (head.subarray(0, 4).toString() !== "RIOT" || head.readUInt16LE(4) !== 2)
      throw Error("invalid-rofl");
    const length = tail.readUInt32LE();
    const offset = size - 4 - length;
    if (length <= 0 || length > 2_000_000 || offset < 8) throw Error("invalid-rofl");
    const buffer = Buffer.alloc(length);
    const { bytesRead } = await file.read(buffer, 0, length, offset);
    if (bytesRead !== length) throw Error("invalid-rofl");
    return reduceRofl(JSON.parse(new TextDecoder("utf-8", { fatal: true }).decode(buffer)), gameId);
  } finally {
    await file.close();
  }
}
