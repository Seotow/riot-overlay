import { Component, inject } from "@angular/core";
import { DataModelService } from "../../services/dataModel.service";
import { AgentSelectComponent } from "../../components/agent-select/agent-select.component";

@Component({
  selector: "app-agent-select-overlay",
  imports: [AgentSelectComponent],
  templateUrl: "./agent-select-overlay.component.html",
  styleUrl: "./agent-select-overlay.component.css",
})
export class AgentSelectOverlayComponent { dataModel = inject(DataModelService); }
