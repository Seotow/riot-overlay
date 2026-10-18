import { AfterViewInit, Component, Input } from "@angular/core";
import { animate, svg, eases } from "animejs";

@Component({
  selector: "app-mapban-ban-icon",
  standalone: true,
  imports: [],
  templateUrl: "./mapban-ban-icon.component.html",
  styleUrl: "./mapban-ban-icon.component.css",
})
export class MapbanBanIconComponent implements AfterViewInit {
  @Input({ required: true }) index!: number;

  ngAfterViewInit(): void {
    const drawTarget = `#banIcon-${this.index}`;
    if (!document.querySelector(drawTarget)) {
      return;
    }

    //#region Ban SVG
    animate(svg.createDrawable(drawTarget), {
      draw: ["0 0", "0 1"],
      ease: eases.inOutQuad,
      duration: 1500,
      delay: 500,
      autoplay: true,
      loop: false,
    });
    //#endregion
  }
}
