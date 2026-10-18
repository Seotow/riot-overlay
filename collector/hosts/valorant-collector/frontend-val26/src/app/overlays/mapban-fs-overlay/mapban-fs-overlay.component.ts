import { AfterViewInit, Component, OnInit, inject } from "@angular/core";
import { ActivatedRoute } from "@angular/router";
import { MapbanFsComponent } from "../../components/mapban-fs/mapban-fs-component";
import { SocketService } from "../../services/SocketService";
import { IMapbanSessionData } from "../../services/Types";
import { Config } from "../../shared/config";

@Component({
  standalone: true,
  selector: "app-mapban-fs-overlay",
  imports: [MapbanFsComponent],
  templateUrl: "./mapban-fs-overlay.component.html",
  styleUrl: "./mapban-fs-overlay.component.css",
})
export class MapbanFsOverlayComponent implements OnInit, AfterViewInit {
  private route = inject(ActivatedRoute);
  private config = inject(Config);

  sessionCode = "UNKNOWN";
  socketService!: SocketService;

  data: IMapbanSessionData = {
    sessionIdentifier: "UNKNOWN",
    organizationName: "ValoSpectra",
    isSupporter: false,
    teams: [
      { name: "", tricode: "", url: "" },
      { name: "", tricode: "", url: "" },
    ],
    format: "bo3",
    availableMaps: [],
    selectedMaps: [],
    stage: "ban",
    actingTeamCode: "",
    actingTeam: 0,
  };

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

  private updateMapbanData(payload: { data: IMapbanSessionData }): void {
    if (!payload?.data) {
      return;
    }

    this.data = payload.data;
  }
}
