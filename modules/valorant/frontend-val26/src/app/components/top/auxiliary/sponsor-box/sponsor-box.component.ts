import { Component, inject, OnDestroy, signal } from "@angular/core";
import { toObservable } from "@angular/core/rxjs-interop";
import { distinctUntilChanged, EMPTY, interval, switchMap } from "rxjs";
import { Subscription } from "rxjs";
import { DataModelService } from "../../../../services/dataModel.service";

@Component({
  selector: "app-sponsor-box",
  imports: [],
  templateUrl: "./sponsor-box.component.html",
  styleUrl: "./sponsor-box.component.css",
})
export class SponsorBoxComponent implements OnDestroy {
  dataModel = inject(DataModelService);

  currentIndex = signal(0);
  private sub?: Subscription;

  constructor() {
    this.sub = toObservable(this.dataModel.sponsorInfo)
      .pipe(
        distinctUntilChanged(
          (a, b) =>
            a.enabled === b.enabled &&
            a.duration === b.duration &&
            a.sponsors.length === b.sponsors.length &&
            a.sponsors.every((s, i) => s === b.sponsors[i]),
        ),
        switchMap((sponsorInfo) => {
          this.currentIndex.set(0);
          if (!sponsorInfo.enabled || sponsorInfo.sponsors.length <= 1) return EMPTY;
          const duration =
            sponsorInfo.duration > 100 ? sponsorInfo.duration : sponsorInfo.duration * 1000;
          return interval(duration);
        }),
      )
      .subscribe(() => {
        this.currentIndex.update((i) => (i + 1) % this.dataModel.sponsorInfo().sponsors.length);
      });
  }

  ngOnDestroy(): void {
    this.sub?.unsubscribe();
  }
}
