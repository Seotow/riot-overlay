import { Component, inject } from "@angular/core";
import { DataModelService } from "../../../../services/dataModel.service";

// Hiện tên giải ở dải bên trái overlay. KHÔNG thay/bỏ watermark Spectra: đây là component riêng,
// đặt ở vị trí khác, dùng dữ liệu tournamentInfo đã có sẵn.
@Component({
  selector: "app-tournament-name",
  imports: [],
  templateUrl: "./tournament-name.component.html",
  styleUrl: "./tournament-name.component.css",
})
export class TournamentNameComponent {
  dataModel = inject(DataModelService);
}
