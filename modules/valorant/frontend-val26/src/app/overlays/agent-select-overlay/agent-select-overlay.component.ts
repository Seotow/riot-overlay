import {
  AfterViewInit,
  ChangeDetectionStrategy,
  Component,
  computed,
  ElementRef,
  NgZone,
  OnDestroy,
  QueryList,
  ViewChildren,
  effect,
  inject,
  signal,
} from "@angular/core";
import { DataModelService } from "../../services/dataModel.service";
import { AgentSelectPlayerInfoComponent } from "../../components/agent-select/player-info/player-info.component";

@Component({
  selector: "app-agent-select-overlay",
  imports: [AgentSelectPlayerInfoComponent],
  templateUrl: "./agent-select-overlay.component.html",
  styleUrl: "./agent-select-overlay.component.css",
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class AgentSelectOverlayComponent implements AfterViewInit, OnDestroy {
  readonly dataModel = inject(DataModelService);
  private readonly ngZone = inject(NgZone);
  private readonly agentSelectDurationMs = 95_000;
  private animationFrameId?: number;
  private readonly nowMs = signal(performance.now());
  private lastKnownAgentSelectMs = 0;
  private lastKnownAgentSelectUpdatedAtMs = performance.now();
  private lastSyncedAgentSelectMs = -1;

  readonly agentSelectElapsedMs = computed(() => {
    const now = this.nowMs();
    const elapsedMs = this.lastKnownAgentSelectMs + (now - this.lastKnownAgentSelectUpdatedAtMs);
    return Math.min(Math.max(elapsedMs, 0), this.agentSelectDurationMs);
  });

  readonly agentSelectBarScale = computed(() => {
    return (this.agentSelectDurationMs - this.agentSelectElapsedMs()) / this.agentSelectDurationMs;
  });

  readonly allPlayersLocked = computed(() => {
    const teams = this.dataModel.teams();
    const players = teams[0].players.concat(teams[1].players);
    return players.length > 0 && players.every((player) => player.locked);
  });

  readonly agentSelectBarOpacity = computed(() => {
    if (this.allPlayersLocked()) {
      return 0;
    }

    const scale = this.agentSelectBarScale();
    if (scale >= 0.45) {
      return 1;
    }

    return Math.max(0, scale / 0.45);
  });

  active = false;
  logoLeft = false;
  logoRight = false;
  nameLeft = false;
  nameRight = false;
  sideLeft = false;
  sideRight = false;
  scaleVersus = false;
  mapCover = false;
  translatePlayerCardLeft = false;
  translatePlayerCardRight = false;

  @ViewChildren("teamNameContainer")
  private teamNameContainers!: QueryList<ElementRef<HTMLElement>>;

  @ViewChildren("teamNameText")
  private teamNameTexts!: QueryList<ElementRef<HTMLElement>>;

  private readonly teamNameResizeObserver = new ResizeObserver(() => {
    this.fitTeamNameText();
  });

  constructor() {
    effect(() => {
      const incomingAgentSelectMs = Math.max(0, this.dataModel.match().agentSelectStartTime);
      if (incomingAgentSelectMs !== this.lastSyncedAgentSelectMs) {
        this.lastKnownAgentSelectMs = incomingAgentSelectMs;
        this.lastKnownAgentSelectUpdatedAtMs = performance.now();
        this.lastSyncedAgentSelectMs = incomingAgentSelectMs;
      }
    });

    effect(() => {
      this.dataModel.teams();
      queueMicrotask(() => this.fitTeamNameText());
    });
  }

  numSequence(n: number): number[] {
    return Array(n);
  }

  ngAfterViewInit(): void {
    this.startSmoothTicker();

    this.teamNameContainers.forEach((containerRef) => {
      this.teamNameResizeObserver.observe(containerRef.nativeElement);
    });
    this.fitTeamNameText();

    requestAnimationFrame(() => {
      this.active = true;
      this.logoLeft = true;
      this.logoRight = true;
      this.nameLeft = true;
      this.nameRight = true;
      this.sideLeft = true;
      this.sideRight = true;
      this.scaleVersus = true;
      this.mapCover = true;
      this.translatePlayerCardLeft = true;
      this.translatePlayerCardRight = true;
    });
  }

  ngOnDestroy(): void {
    if (this.animationFrameId) {
      cancelAnimationFrame(this.animationFrameId);
      this.animationFrameId = undefined;
    }

    this.teamNameResizeObserver.disconnect();
  }

  private startSmoothTicker(): void {
    const tick = () => {
      this.nowMs.set(performance.now());
      this.animationFrameId = requestAnimationFrame(tick);
    };

    this.ngZone.runOutsideAngular(() => {
      this.animationFrameId = requestAnimationFrame(tick);
    });
  }

  private fitTeamNameText(): void {
    const maxFontSizePx = 56;
    const minFontSizePx = 12;
    const containers = this.teamNameContainers.toArray();
    const texts = this.teamNameTexts.toArray();
    const count = Math.min(containers.length, texts.length);

    for (let index = 0; index < count; index += 1) {
      const container = containers[index].nativeElement;
      const text = texts[index].nativeElement;
      let fontSizePx = maxFontSizePx;

      text.style.fontSize = `${fontSizePx}px`;

      while (fontSizePx > minFontSizePx && text.scrollHeight > container.clientHeight) {
        fontSizePx -= 1;
        text.style.fontSize = `${fontSizePx}px`;
      }
    }
  }
}
