import { AfterViewInit, Component, inject, OnInit } from "@angular/core";
import { ActivatedRoute } from "@angular/router";
import { SocketService } from "../../services/SocketService";
import { Config } from "../../shared/config";
import { MapbanComponent } from "../../components/mapban/mapban-component";
import { IMapbanSessionData } from "../../services/Types";

@Component({
  standalone: true,
  imports: [MapbanComponent],
  selector: "app-mapban-ui",
  templateUrl: "./mapban-overlay.component.html",
  styleUrl: "./mapban-overlay.component.css",
})
export class MapbanUiComponent implements OnInit, AfterViewInit {
  private route = inject(ActivatedRoute);
  private config = inject(Config);

  sessionCode = "UNKNOWN";
  socketService!: SocketService;

  data?: IMapbanSessionData;

  constructor() {
    const params = this.route.snapshot.queryParams;
    this.sessionCode = params["sessionId"] || "UNKNOWN";
  }

  ngOnInit(): void {
    this.socketService = SocketService.getInstance();
    this.socketService.subscribeMapban((data: any) => {
      this.updateMapbanData(data);
    });
    this.socketService.connectMapban(this.config.mapbanEndpoint, {
      sessionId: this.sessionCode,
    });
  }

  ngAfterViewInit(): void {
    this.socketService.subscribeMatch((data: any) => {
      this.updateMapbanData(data);
    });
  }

  public updateMapbanData(data: { data: IMapbanSessionData }) {
    const payload = data?.data;
    console.debug("[MapbanOverlay] incoming payload", {
      eventSession: payload?.sessionIdentifier,
      format: payload?.format,
      stage: payload?.stage,
      selectedCount: payload?.selectedMaps?.length ?? 0,
      availableCount: payload?.availableMaps?.length ?? 0,
      selectedNames: payload?.selectedMaps?.map((m) => m.name) ?? [],
      availableNames: payload?.availableMaps?.map((m) => m.name) ?? [],
      hasCustomFormatData: !!payload?.customFormatData,
      pickBanStates: payload?.customFormatData?.pickBanStates ?? [],
    });

    this.data = data.data;
  }
}
