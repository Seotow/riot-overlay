// One-time mechanical JSX tag migration. Never touches overlay renderer files.
import ts from "typescript";
import { readFile, writeFile, readdir } from "node:fs/promises";
const mapping = {
  button: ["Button", "button"],
  input: ["Input", "input"],
  select: ["NativeSelect", "native-select"],
  textarea: ["Textarea", "textarea"],
  article: ["Card", "card"],
};
for (const file of await readdir("src")) {
  if (!file.endsWith(".tsx") || file === "main.tsx") continue;
  const path = `src/${file}`;
  let source = await readFile(path, "utf8");
  const ast = ts.createSourceFile(path, source, ts.ScriptTarget.Latest, true, ts.ScriptKind.TSX),
    edits = [],
    imports = new Map();
  function visit(n) {
    if (
      (ts.isJsxOpeningElement(n) || ts.isJsxClosingElement(n) || ts.isJsxSelfClosingElement(n)) &&
      ts.isIdentifier(n.tagName)
    ) {
      const match = mapping[n.tagName.text];
      if (match) {
        edits.push({ start: n.tagName.getStart(ast), end: n.tagName.end, text: match[0] });
        imports.set(match[0], match[1]);
      }
    }
    // Visible punctuation only. Does not change payload keys, paths or commands.
    if (
      ts.isJsxText(n) ||
      ts.isStringLiteral(n) ||
      ts.isNoSubstitutionTemplateLiteral(n) ||
      ts.isTemplateHead(n) ||
      ts.isTemplateMiddle(n) ||
      ts.isTemplateTail(n)
    ) {
      const start = n.getStart(ast),
        text = source.slice(start, n.end);
      const next = text.replace(/—/g, "Chưa có").replace(/·/g, ",").replace(/…/g, "...");
      if (next !== text) edits.push({ start, end: n.end, text: next });
    }
    ts.forEachChild(n, visit);
  }
  visit(ast);
  for (const e of edits.sort((a, b) => b.start - a.start))
    source = source.slice(0, e.start) + e.text + source.slice(e.end);
  const header = [...imports]
    .filter(([name]) => !new RegExp(`import\\s*\\{[^}]*\\b${name}\\b`).test(source))
    .map(([name, file]) => `import { ${name} } from "./components/ui/${file}";`)
    .join("\n");
  if (edits.length) await writeFile(path, header + "\n" + source);
}
for (const file of await readdir("src/components/ui")) {
  if (!file.endsWith(".tsx")) continue;
  const path = `src/components/ui/${file}`;
  let s = await readFile(path, "utf8");
  s = s.replaceAll('from "cn"', 'from "../../../lib/utils"');
  if (file === "button.tsx") s = s.replace('variant = "default"', 'variant = "outline"');
  await writeFile(path, s);
}
console.log("Studio primitives migrated; overlay sources untouched.");
// Remove superseded, unreferenced Studio screens after their replacements land.
for (const file of ["Dashboard.tsx", "Production.tsx"]) {
  const path = `src/${file}`;
  let s = await readFile(path, "utf8");
  const ast = ts.createSourceFile(path, s, ts.ScriptTarget.Latest, true, ts.ScriptKind.TSX);
  const retired = new Set([
    "LegacySourcePanel",
    "LegacyDashboard",
    "CapturePanel",
    "LegacyProductionDesk",
  ]);
  const edits = ast.statements
    .filter((n) => ts.isFunctionDeclaration(n) && n.name && retired.has(n.name.text))
    .map((n) => ({ start: n.getFullStart(), end: n.end }));
  for (const e of edits.sort((a, b) => b.start - a.start)) s = s.slice(0, e.start) + s.slice(e.end);
  await writeFile(path, s.replaceAll(" ,", ","));
}
