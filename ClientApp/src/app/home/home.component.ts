import { Component } from '@angular/core';
import { Router } from '@angular/router'

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  constructor( private router: Router) { }
  id: string;

  onClickMe() {
    this.router.navigate(['./summoner', this.id]);
  }
}
