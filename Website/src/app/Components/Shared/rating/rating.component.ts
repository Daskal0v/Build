import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-rating',
  templateUrl: './rating.component.html',
  styleUrls: ['./rating.component.scss']
})
export class RatingComponent implements OnInit {
  @Input() rating!: number;
  public maxStars: number = 5;
  public starsArray: string[] = [];
  private full: string = "star";
  private half: string = "star_half";
  private empty: string = "star_border";

  ngOnInit() {
    this.starsArray = [];
    this.setupRating();
  }

  private setupRating(): void {
    let fullStars = ~~this.rating;
    let decimalPart = (this.rating % 1);
    //Set full stars
    for (let index = 0; index < fullStars; index++) {
      this.starsArray[index] = this.full;
    }
    if (fullStars < this.maxStars) {
      for (let index = fullStars; index < this.maxStars; index++) {
        if (decimalPart >= 0.5) {
          this.starsArray[index] = this.half;
        }
        else {
          this.starsArray[index] = this.empty;
        }
      }
    }
  }
}
