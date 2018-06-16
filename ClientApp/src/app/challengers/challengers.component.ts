import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http'

@Component({
  selector: 'challengers',
  templateUrl: './challengers.component.html'
})

export class ChallengersComponent {
  //any will be changed to proper object after I create them
  public challengerlist: any;
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<any>(baseUrl + "api/ChallengersList/GetChallengers").subscribe(result => {
      this.challengerlist = result
    }, error => console.error(error));
  }
}
