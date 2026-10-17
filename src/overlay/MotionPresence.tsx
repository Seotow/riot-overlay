import { cloneElement, useEffect, useRef, useState, type ReactElement } from "react";
// Preserve a mounted graphic for its exit; telemetry and event lifetimes stay separate.
export function MotionPresence({
  show,
  children,
}: {
  show: boolean;
  children: ReactElement<any> | null;
}) {
  const [present, setPresent] = useState(show);
  const latest = useRef(children);
  if (show && children) latest.current = children;
  useEffect(() => {
    if (show) {
      setPresent(true);
      return;
    }
    const timer = setTimeout(() => setPresent(false), 450);
    return () => clearTimeout(timer);
  }, [show]);
  const child = show ? children : latest.current;
  if ((!show && !present) || !child) return null;
  return cloneElement(child, { "data-motion": show ? "enter" : "exit" });
}
