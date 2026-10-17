import { AfterViewInit, Component, Input } from "@angular/core";
import { animate, svg, eases } from "animejs";

@Component({
  selector: "app-mapban-ban-icon",
  standalone: true,
  imports: [],
  templateUrl: "./mapban-fs-ban-icon.component.html",
  styleUrl: "./mapban-fs-ban-icon.component.css",
})
export class MapbanBanIconComponent implements AfterViewInit {
  @Input({ required: true }) index!: number;
  @Input({ required: true }) mapName!: string;
  @Input({ required: true }) tricode!: string;

  ngAfterViewInit(): void {
    //#region Ban SVG
    animate(svg.createDrawable("#banIcon-" + this.index), {
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
