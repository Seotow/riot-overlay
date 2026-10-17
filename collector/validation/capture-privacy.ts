// User-authorized local gameplay archive: preserve original player/object IDs
// and names for comparison; filter authentication material only.
export function capturePrivacy() {
  const visit = (value: unknown, key = ""): unknown => {
    if (/authorization|password|secret|token|lockfile|credential|^LB_EMAIL$|^email$/i.test(key))
      return "[redacted]";
    if (Array.isArray(value)) return value.map((v) => visit(v));
    if (value && typeof value === "object")
      return Object.fromEntries(Object.entries(value).map(([k, v]) => [k, visit(v, k)]));
    return value;
  };
  return (value: unknown) => visit(value);
}
