import { Component, computed, effect, inject, signal } from "@angular/core";
import { DataModelService } from "../../../services/dataModel.service";

@Component({
  selector: "app-toast",
  imports: [],
  templateUrl: "./toast-component.html",
  styleUrl: "./toast-component.css",
})
export class ToastComponent {
  dataModel = inject(DataModelService);

  toastInfo = signal(Object.assign({}, this.dataModel.toastInfo()));

  shouldHide = computed(
    () => !this.dataModel.toastInfo().active || !(this.dataModel.match().roundPhase === "shopping"),
  );

  teamSide = computed(() => {
    if (this.toastInfo().selectedTeam === "none") return "none";
    if (this.dataModel.match().teams[this.toastInfo().selectedTeam == "left" ? 0 : 1].isAttacking) {
      return "attacker";
    } else {
      return "defender";
    }
  });

  tournamentIconUrl = computed(() => {
    const logo = this.dataModel.tournamentInfo().logoUrl;
    if (logo && logo !== "") return logo;
    else return "assets/misc/logo.webp";
  });

  hide = true;
  inAnimation = false;
  outAnimation = false;

  hideAnimationEffect = effect(() => {
    if (this.shouldHide()) {
      this.outAnimation = true;
      setTimeout(() => {
        this.outAnimation = false;
        this.hide = true;
      }, 300);
    } else {
      this.outAnimation = false;
      this.hide = false;
      this.inAnimation = true;
      setTimeout(() => {
        this.inAnimation = false;
      }, 300);
    }
  });

  delayEndToastEffect = effect(() => {
    if (this.shouldHide()) {
      setTimeout(() => {
        this.toastInfo.set(Object.assign({}, this.dataModel.toastInfo()));
      }, 350);
    } else {
      this.toastInfo.set(Object.assign({}, this.dataModel.toastInfo()));
    }
  });
}
