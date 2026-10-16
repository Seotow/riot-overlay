// One local, read-only schema request. Never loads LB, reads memory, or controls the game.
import assert from "node:assert/strict";
import https from "node:https";
import { mkdir, writeFile } from "node:fs/promises";
import { randomUUID } from "node:crypto";
import { fileURLToPath } from "node:url";
import path from "node:path";

const LIMITS = Object.freeze({
  deadlineMs: 3000,
  bodyBytes: 4 * 1024 * 1024,
  headerBytes: 16 * 1024,
  paths: 64,
  responsesPerMethod: 12,
  models: 128,
  fieldsPerSchema: 256,
  modelRefsPerSchema: 64,
  schemaNodes: 4096,
  depth: 8,
  identifierLength: 96,
  fieldPathLength: 384,
});
const CAVEAT = "Schema declarations are not runtime field availability, spectator support, or proof of LB-equivalent telemetry.";
const METHODS = ["get", "head", "post", "put", "patch", "delete", "options", "trace"];
const TYPES = new Set(["string", "number", "integer", "boolean", "array", "object", "null"]);
const FORMATS = new Set(["int32", "int64", "float", "double", "date", "date-time", "byte", "binary", "uuid"]);
const IDENTIFIER = /^[A-Za-z_][A-Za-z0-9_.-]{0,95}$/;
const PRIVATE_NAME = /(?:password|passwd|secret|token|credential|auth|cookie|apikey|lockfile|session|bearer|username|login|ticket|encryptionkey)/i;
const isObject = (value) => value !== null && typeof value === "object" && !Array.isArray(value);
const safeName = (value) => typeof value === "string" && IDENTIFIER.test(value)
  && !PRIVATE_NAME.test(value.replace(/[_.-]/g, ""))
  && !["__proto__", "prototype", "constructor"].includes(value);
const safePath = (value) => typeof value === "string" && value.length <= 256
  && /^\/(?:liveclientdata|replay)\/(?:[A-Za-z0-9_-]+|\{[A-Za-z_][A-Za-z0-9_]*\})(?:\/(?:[A-Za-z0-9_-]+|\{[A-Za-z_][A-Za-z0-9_]*\}))*$/.test(value)
  && value.split("/").every((part) => !PRIVATE_NAME.test(part.replace(/[{}_-]/g, "")));

function localModelRef(value) {
  if (typeof value !== "string" || value.length > 128) return null;
  const match = /^#\/(?:components\/schemas|definitions)\/([^/]+)$/.exec(value);
  return match && safeName(match[1]) ? match[1] : null;
}

// Only declaration locations are traversed. Descriptions, examples, defaults,
// servers, URLs, security schemes and credential-shaped fields are never copied.
export function inspectSchema(document) {
  const inventory = { schemaDetected: false, schemaVersion: null, paths: [], models: [], truncated: false };
  if (!isObject(document) || !isObject(document.paths)) return inventory;
  const version = document.openapi ?? document.swagger;
  if (typeof version !== "string" || !/^(?:2\.0|3\.\d\.\d)$/.test(version)) return inventory;
  inventory.schemaDetected = true;
  inventory.schemaVersion = version;
  let visited = 0;
  const referenced = new Set();

  function declaration(root) {
    const fields = [];
    const refs = new Set();
    const fieldKeys = new Set();
    function visit(node, prefix, depth) {
      if (!isObject(node)) return;
      if (depth > LIMITS.depth || visited >= LIMITS.schemaNodes) {
        inventory.truncated = true;
        return;
      }
      visited++;
      const model = localModelRef(node.$ref);
      if (model) {
        if (refs.size < LIMITS.modelRefsPerSchema) refs.add(model);
        else inventory.truncated = true;
      }
      if (isObject(node.properties)) {
        for (const name in node.properties) {
          if (!Object.hasOwn(node.properties, name) || !safeName(name)) continue;
          const child = node.properties[name];
          if (!isObject(child)) continue;
          const fieldName = prefix ? `${prefix}.${name}` : name;
          if (fieldName.length > LIMITS.fieldPathLength || fields.length >= LIMITS.fieldsPerSchema) {
            inventory.truncated = true;
            break;
          }
          const type = TYPES.has(child.type) ? child.type : null;
          const field = { name: fieldName, type };
          if (FORMATS.has(child.format)) field.format = child.format;
          const childModel = localModelRef(child.$ref);
          if (childModel) field.model = childModel;
          const itemModel = isObject(child.items) ? localModelRef(child.items.$ref) : null;
          if (itemModel) field.itemModel = itemModel;
          const key = JSON.stringify(field);
          if (!fieldKeys.has(key)) { fields.push(field); fieldKeys.add(key); }
          visit(child, fieldName, depth + 1);
        }
      }
      if (isObject(node.items)) visit(node.items, prefix ? `${prefix}[]` : "[]", depth + 1);
      for (const composition of ["allOf", "oneOf", "anyOf"]) {
        if (!Array.isArray(node[composition])) continue;
        if (node[composition].length > 32) inventory.truncated = true;
        for (const child of node[composition].slice(0, 32)) visit(child, prefix, depth + 1);
      }
    }
    visit(root, "", 0);
    for (const ref of refs) referenced.add(ref);
    return { fields, models: [...refs] };
  }

  for (const route in document.paths) {
    if (!Object.hasOwn(document.paths, route) || !safePath(route)) continue;
    if (inventory.paths.length >= LIMITS.paths) { inventory.truncated = true; break; }
    const item = document.paths[route];
    if (!isObject(item)) continue;
    const entry = { path: route, methods: [], responses: [] };
    for (const method of METHODS) {
      if (!Object.hasOwn(item, method) || !isObject(item[method])) continue;
      entry.methods.push(method.toUpperCase());
      const responses = item[method].responses;
      if (!isObject(responses)) continue;
      let responseCount = 0;
      for (const status in responses) {
        if (!Object.hasOwn(responses, status) || !/^(?:[1-5][0-9]{2}|default)$/.test(status)) continue;
        if (responseCount++ >= LIMITS.responsesPerMethod) { inventory.truncated = true; break; }
        const response = responses[status];
        if (!isObject(response)) continue;
        const roots = [];
        if (isObject(response.schema)) roots.push(response.schema);
        if (isObject(response.content)) {
          for (const media of ["application/json", "application/*+json"]) {
            const schema = response.content[media]?.schema;
            if (isObject(schema)) roots.push(schema);
          }
        }
        for (const root of roots) entry.responses.push({ method: method.toUpperCase(), status, ...declaration(root) });
      }
    }
    inventory.paths.push(entry);
  }
  const schemas = isObject(document.components?.schemas) ? document.components.schemas : document.definitions;
  if (isObject(schemas)) {
    // Expand only locally referenced response models, not unrelated auth models.
    const complete = new Set();
    for (const name of referenced) {
      if (inventory.models.length >= LIMITS.models) { inventory.truncated = true; break; }
      if (complete.has(name) || !safeName(name) || !Object.hasOwn(schemas, name) || !isObject(schemas[name])) continue;
      complete.add(name);
      inventory.models.push({ name, ...declaration(schemas[name]) });
    }
  }
  return inventory;
}

function requestSchema() {
  return new Promise((resolve) => {
    let settled = false;
    let status = null;
    let request;
    const finish = (failureReason, document = null) => {
      if (settled) return;
      settled = true;
      clearTimeout(deadline);
      request?.destroy();
      resolve({ httpStatus: status, failureReason, document });
    };
    const deadline = setTimeout(() => finish("deadline-exceeded"), LIMITS.deadlineMs);
    try {
      request = https.request({
        hostname: "127.0.0.1", port: 2999, path: "/swagger/v3/openapi.json", method: "GET",
        rejectUnauthorized: false, agent: false, maxHeaderSize: LIMITS.headerBytes,
        headers: { Accept: "application/json", "Accept-Encoding": "identity" },
      }, (response) => {
        response.on("aborted", () => finish("response-aborted"));
        response.on("error", () => finish("response-error"));
        status = Number.isInteger(response.statusCode) ? response.statusCode : null;
        if (status !== 200) { finish(status >= 300 && status < 400 ? "redirect-not-followed" : "http-unavailable"); return; }
        const declaredLength = response.headers["content-length"];
        if (typeof declaredLength === "string" && /^\d+$/.test(declaredLength) && Number(declaredLength) > LIMITS.bodyBytes) {
          finish("body-limit-exceeded"); return;
        }
        const encoding = response.headers["content-encoding"];
        if (encoding && encoding !== "identity") { finish("unsupported-content-encoding"); return; }
        const chunks = [];
        let bytes = 0;
        response.on("data", (chunk) => {
          if (settled) return;
          bytes += chunk.length;
          if (bytes > LIMITS.bodyBytes) { finish("body-limit-exceeded"); return; }
          chunks.push(chunk);
        });
        response.on("end", () => {
          if (settled) return;
          try { finish(null, JSON.parse(Buffer.concat(chunks, bytes).toString("utf8"))); }
          catch { finish("invalid-json"); }
        });
      });
      request.on("error", (error) => finish(error?.code === "ECONNREFUSED" ? "connection-refused" : "request-error"));
      request.end();
    } catch { finish("request-error"); }
  });
}

function selfTest() {
  const sentinel = "PRIVATE_SENTINEL_DO_NOT_PERSIST";
  const fixture = {
    openapi: "3.0.1", servers: [{ url: `https://${sentinel}` }],
    paths: {
      "/liveclientdata/activeplayer": { get: { responses: { "200": { content: { "application/json": {
        schema: { $ref: "#/components/schemas/ActivePlayer" }, example: { secret: sentinel },
      } } } } } },
      "/replay/playback": { get: { responses: { "200": { content: { "application/json": { schema: {
        type: "object", properties: { paused: { type: "boolean" }, time: { type: "number", format: "float" },
          access_token: { type: "string", example: sentinel } },
      } } } } } }, post: { responses: {} } },
      "/lcu/auth": { get: {} }, "/replay/test?token=abc": { get: {} }, "/replay/secret": { get: {} },
    },
    components: { schemas: {
      ActivePlayer: { properties: { currentGold: { type: "number", description: sentinel },
        championStats: { $ref: "#/components/schemas/ChampionStats" },
        token: { type: "string" }, remote: { $ref: `https://${sentinel}/Gold` },
        abilities: { type: "array", items: { $ref: "#/components/schemas/Ability" } } } },
      ChampionStats: { properties: { currentHealth: { type: "number" }, resourceValue: { type: "number" } } },
      Ability: { properties: { abilityLevel: { type: "integer", format: "int32" } } },
      SecretModel: { properties: { password: { type: "string" } } },
    } },
  };
  const result = inspectSchema(fixture);
  assert.equal(result.schemaDetected, true);
  assert.equal(result.paths.length, 2);
  assert.deepEqual(result.paths[1].methods, ["GET", "POST"]);
  assert.equal(result.models.length, 3);
  assert.equal(result.models[0].fields.find((field) => field.name === "currentGold").type, "number");
  assert.equal(result.models[0].fields.find((field) => field.name === "abilities").itemModel, "Ability");
  assert.equal(result.models[1].fields[0].name, "currentHealth");
  assert.equal(JSON.stringify(result).includes(sentinel), false);
  assert.equal(JSON.stringify(result).includes("token"), false);
  assert.equal(JSON.stringify(result).includes("https:"), false);
  assert.equal(localModelRef("#/components/schemas/SecretModel"), null);
  assert.equal(inspectSchema({ paths: {} }).schemaDetected, false);
  const many = { openapi: "3.0.1", paths: Object.fromEntries(Array.from({ length: LIMITS.paths + 1 }, (_, i) => [`/replay/path${i}`, { get: {} }])) };
  assert.equal(inspectSchema(many).paths.length, LIMITS.paths);
  assert.equal(inspectSchema(many).truncated, true);
  const properties = Object.fromEntries(Array.from({ length: LIMITS.fieldsPerSchema + 1 }, (_, i) => [`field${i}`, { type: "number" }]));
  const bounded = inspectSchema({ swagger: "2.0", paths: { "/liveclientdata/playerlist": { get: { responses: { "200": { schema: { properties } } } } } } });
  assert.equal(bounded.paths[0].responses[0].fields.length, LIMITS.fieldsPerSchema);
  assert.equal(bounded.truncated, true);
  console.log(JSON.stringify({ selfTest: "passed", assertions: 16, networkAccessed: false, filesWritten: false }));
}

async function main() {
  if (process.argv.includes("--self-test")) { selfTest(); return; }
  if (process.argv.length > 2) throw new Error("unsupported-argument");
  const fetched = await requestSchema();
  const inventory = inspectSchema(fetched.document);
  const failureReason = fetched.failureReason ?? (inventory.schemaDetected ? null : "schema-not-recognized");
  const report = {
    kind: "game-client-schema-metadata", inspectedAt: new Date().toISOString(),
    availability: failureReason ? "unavailable" : "available", httpStatus: fetched.httpStatus,
    failureReason, limits: LIMITS, caveat: CAVEAT, ...inventory,
  };
  const root = fileURLToPath(new URL("../data/engine-reports/", import.meta.url));
  await mkdir(root, { recursive: true });
  const directory = path.join(root, `game-client-schema-${report.inspectedAt.replace(/[:.]/g, "-")}-${randomUUID()}`);
  await mkdir(directory);
  const output = path.join(directory, "schema-metadata.json");
  await writeFile(output, `${JSON.stringify(report, null, 2)}\n`, { encoding: "utf8", flag: "wx" });
  console.log(JSON.stringify({ availability: report.availability, httpStatus: report.httpStatus,
    failureReason, paths: inventory.paths.length, models: inventory.models.length,
    truncated: inventory.truncated, caveat: CAVEAT, output }));
}

main().catch(() => { console.error("Schema inspection failed; no raw response or error details are printed."); process.exitCode = 1; });
