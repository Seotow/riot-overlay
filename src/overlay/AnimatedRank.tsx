import type { ReactNode } from "react";
// Rank positions are absolute: transform animates the same keyed player, not a
// replacement row. Content has a separate reveal so entry never fights sorting.
export function AnimatedRank({ slots, children }: { slots: number[]; children: ReactNode }) {
  return (
    <div className="animated-rank-list" data-order={slots.join(",")}>
      {children}
    </div>
  );
}
