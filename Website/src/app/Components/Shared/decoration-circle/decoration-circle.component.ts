import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-decoration-circle',
  templateUrl: './decoration-circle.component.html',
  styleUrls: ['./decoration-circle.component.scss']
})
export class DecorationCircleComponent {
  @Input() text!: string;
  @Input() size!: 'small' | 'med' | 'large' ;
  @Input() picSrc!: string;
  @Input() isPicture !: boolean;
}
