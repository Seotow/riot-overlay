import { Component, computed, inject } from "@angular/core";
import { TranslatePipe } from "@ngx-translate/core";
import { DataModelService } from "../../../../services/dataModel.service";
import { TranslateKeys } from "../../../../services/i18nHelper";

@Component({
  selector: "app-round-number",
  imports: [TranslatePipe],
  templateUrl: "./round-number.component.html",
  styleUrl: "./round-number.component.css",
})
export class RoundNumberComponent {
  dataModel = inject(DataModelService);
  TranslateKeys = TranslateKeys;

  isOvertime = computed(
    () => this.dataModel.match().roundNumber >= this.dataModel.match().firstOtRound,
  );

  overtimeNumber = computed(() => {
    const match = this.dataModel.match();
    return Math.floor((match.roundNumber - match.firstOtRound) / 2) + 1;
  });
}
