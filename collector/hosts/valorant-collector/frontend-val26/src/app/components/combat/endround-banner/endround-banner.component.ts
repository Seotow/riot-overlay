import { Component, computed, effect, inject, Signal, signal, WritableSignal } from "@angular/core";
import { TranslatePipe } from "@ngx-translate/core";
import { TranslateKeys } from "../../../services/i18nHelper";
import { DataModelService } from "../../../services/dataModel.service";
import { IRoundWinBox, IRoundWinBoxSponsors } from "../../../services/Types";

@Component({
  selector: "app-endround-new",
  imports: [TranslatePipe],
  templateUrl: "./endround-banner.component.html",
  styleUrl: "./endround-banner.component.css",
})
export class EndroundBannerComponent {
  dataModel = inject(DataModelService);

  hide = true;
  showAnimation = false;
  showRevealSquares = false;
  showReverseSquares = false;
  clipClosed = false;
  clipClosing = false;
  preload = true;

  lastInRoundNumber = -1;
  lastOutRoundNumber = -1;

  TranslateKeys = TranslateKeys;

  roundWonType: WritableSignal<TranslateKeys> = signal(TranslateKeys.Endround_RoundWin);

  clutch: number[] = [-1, -1];

  roundWinBox: Signal<IRoundWinBox> = computed(() => this.dataModel.roundWinBox());
  roundWonSponsor: Signal<IRoundWinBoxSponsors> = computed(() => this.calculateSponsor());

  private calculateClutch(): void {
    const teamOne = this.dataModel.match().teams[0];
    const teamTwo = this.dataModel.match().teams[1];

    const aliveCountTeamOne = teamOne.players.filter((player) => player.isAlive).length;
    const aliveCountTeamTwo = teamTwo.players.filter((player) => player.isAlive).length;

    if (aliveCountTeamOne < 1 || aliveCountTeamOne >= 2) this.clutch[0] = 0;
    if (aliveCountTeamTwo < 1 || aliveCountTeamTwo >= 2) this.clutch[1] = 0;

    if ((aliveCountTeamOne == 1 && aliveCountTeamTwo >= 2) || this.clutch[0] == 1)
      this.clutch[0] = 1;
    if ((aliveCountTeamTwo == 1 && aliveCountTeamOne >= 2) || this.clutch[1] == 1)
      this.clutch[1] = 1;
  }

  private calculateRoundWonType(): TranslateKeys {
    const wonTeam = this.dataModel.match().teams[this.teamWon()];
    const lostTeam = this.dataModel.match().teams[this.teamWon() === 0 ? 1 : 0];

    let ace = false;
    let flawless = true;
    let teamAce = true;
    // Todo: implement Thrifty round ceremonies when data gets available by Overwolf
    const thrifty = false;

    const lostTeamPlayerNames = new Set(lostTeam.players.map((player) => player.name));

    lostTeam.players.forEach((player) => {
      if (player.isAlive) flawless = false;
    });

    for (const player of wonTeam.players) {
      if (player.killedPlayerNames) {
        const killsFromLostTeam = player.killedPlayerNames.filter((playerName) =>
          lostTeamPlayerNames.has(playerName),
        );

        if (new Set(killsFromLostTeam).size >= 5) {
          ace = true;
          break;
        }
      }
      if (player.deathsThisRound >= 1) flawless = false;
      if (!(player.killsThisRound >= 1)) teamAce = false;
    }

    if (ace) return TranslateKeys.Endround_RoundAce;
    else if (this.clutch[this.teamWon()]) return TranslateKeys.Endround_RoundClutch;
    else if (teamAce) return TranslateKeys.Endround_RoundTeamAce;
    else if (flawless) return TranslateKeys.Endround_RoundFlawless;
    else if (thrifty) return TranslateKeys.Endround_RoundThrifty;
    else return TranslateKeys.Endround_RoundWin;
  }

  private calculateSponsor(): IRoundWinBoxSponsors {
    const initialSponsor: IRoundWinBoxSponsors = {
      wonTeam: "all",
      roundCeremony: ["all"],
      iconUrl: "",
      backdropUrl: "",
    };

    if (this.roundWinBox().type === "sponsors") {
      const teamwon = this.teamWon();
      const roundWonType = this.roundWonType();

      if (this.roundWinBox().sponsors.length == 0) return initialSponsor;

      const sponsor: IRoundWinBoxSponsors = this.roundWinBox().sponsors[0];

      for (const spons of this.roundWinBox().sponsors) {
        if (spons.roundCeremony) {
          if (
            spons.wonTeam == "all" ||
            (spons.wonTeam == "left" && teamwon == 0) ||
            (spons.wonTeam == "right" && teamwon == 1)
          ) {
            if (
              spons.roundCeremony.includes("all") ||
              (spons.roundCeremony.includes("normal") &&
                roundWonType == TranslateKeys.Endround_RoundWin) ||
              (spons.roundCeremony.includes("ace") &&
                roundWonType == TranslateKeys.Endround_RoundAce) ||
              (spons.roundCeremony.includes("clutch") &&
                roundWonType == TranslateKeys.Endround_RoundClutch) ||
              (spons.roundCeremony.includes("teamAce") &&
                roundWonType == TranslateKeys.Endround_RoundTeamAce) ||
              (spons.roundCeremony.includes("flawless") &&
                roundWonType == TranslateKeys.Endround_RoundFlawless) ||
              (spons.roundCeremony.includes("thrifty") &&
                roundWonType == TranslateKeys.Endround_RoundThrifty)
            ) {
              return spons;
            }
          }
        }
      }
      return sponsor;
    }
    return initialSponsor;
  }

  bannerBackgroundUrl = computed(() => {
    const backdropSponsor = this.roundWonSponsor().backdropUrl;
    const backdropTournament = this.dataModel.tournamentInfo().backdropUrl;
    if (this.roundWinBox().type == "sponsors" && backdropSponsor && backdropSponsor !== "")
      return backdropSponsor;
    if (
      this.roundWinBox().type == "tournamentInfo" &&
      backdropTournament &&
      backdropTournament !== ""
    )
      return backdropTournament;
    else return "assets/misc/backdrop.png";
  });

  bannerTopIconUrl = computed(() => {
    const logoSponsor = this.roundWonSponsor().iconUrl;
    const logoTournament = this.dataModel.tournamentInfo().logoUrl;
    if (this.roundWinBox().type == "sponsors" && logoSponsor && logoSponsor !== "")
      return logoSponsor;
    if (this.roundWinBox().type == "tournamentInfo" && logoTournament && logoTournament !== "")
      return logoTournament;
    else return "assets/misc/logo.webp";
  });

  eventLogo = computed(() => {
    const logo = this.dataModel.tournamentInfo().logoUrl;
    return logo && logo !== "" ? logo : null;
  });

  eventName = computed(() => {
    const name = this.dataModel.tournamentInfo().name;
    return name && name !== "" ? name : "";
  });

  teamWon = computed(() => {
    if (this.dataModel.match().attackersWon) {
      return this.dataModel.teams()[0].isAttacking ? 0 : 1;
    } else {
      return this.dataModel.teams()[0].isAttacking ? 1 : 0;
    }
  });

  leftWon = computed(() => {
    return this.teamWon() === 0;
  });

  readonly waitingBackgroundClass = computed(() => {
    return `gradient-head-to-head-${this.dataModel.teams()[0].isAttacking ? "attacker" : "defender"}`;
  });

  readonly winningTeamBackgroundClass = computed(() => {
    return `gradient-${this.leftWon() ? "left" : "right"}-${this.dataModel.match().attackersWon ? "attacker" : "defender"}`;
  });

  teamWonSide = computed(() => {
    return this.dataModel.match().attackersWon ? "ATK" : "DEF";
  });

  teamWonLogoUrl = computed(() => {
    const winningTeamIndex = this.teamWon();
    return this.dataModel.teams()[winningTeamIndex]?.teamUrl || "assets/misc/logo.webp";
  });

  teamWonTricode = computed(() => {
    const winningTeamIndex = this.teamWon();
    return this.dataModel.teams()[winningTeamIndex]?.teamTricode || "";
  });

  onImageLoad() {
    this.preload = false;
  }

  _ref = effect(() => {
    const roundPhase = this.dataModel.match().roundPhase;
    const roundNumber = this.dataModel.match().roundNumber;

    this.calculateClutch();

    if (roundPhase === "end") {
      if (roundNumber === this.lastInRoundNumber) return;
      this.lastInRoundNumber = roundNumber;

      this.hide = false;

      // Prepare reveal by collapsing banner clip and resetting squares
      this.showAnimation = false;
      this.showRevealSquares = false;
      this.showReverseSquares = false;
      this.clipClosed = true;
      this.clipClosing = false;

      // Delay animation start until layout & paint settle
      requestAnimationFrame(() => {
        requestAnimationFrame(() => {
          requestAnimationFrame(() => {
            setTimeout(() => {
              this.roundWonType.set(this.calculateRoundWonType());

              this.showAnimation = true;
              this.showRevealSquares = true;

              // After initial animations complete (550ms reveal-text/background completes)
              // Wait 5.66 seconds, then trigger reverse animation
              setTimeout(() => {
                this.clipClosing = true;
                this.showReverseSquares = true;

                // Hide component after reverse animation completes (500ms)
                setTimeout(() => {
                  this.hide = true;
                  this.showAnimation = false;
                  this.showRevealSquares = false;
                  this.showReverseSquares = false;
                  this.clipClosed = false;
                  this.clipClosing = false;

                  this.clutch = [-1, -1];
                }, 260);
              }, 550 + 5660); // 550ms (reveal complete) + 5660ms delay
            }, 200);
          });
        });
      });
    } else if (roundPhase === "shopping") {
      if (roundNumber === this.lastOutRoundNumber) return;
      this.lastOutRoundNumber = roundNumber;

      setTimeout(() => {
        this.hide = true;
      }, 3000); // Show for 3 seconds before hiding
    }
  });
}
