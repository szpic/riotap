import { Component, Inject, OnInit, OnDestroy} from '@angular/core';
import { HttpClient } from '@angular/common/http'
import { ActivatedRoute, ParamMap } from '@angular/router';
import { Observable } from 'rxjs';
import { switchMap } from 'rxjs/operators';

@Component({
  selector: 'summoner',
  templateUrl: './summoner.component.html'
})

export class SummonerComponent implements OnInit, OnDestroy{
  public summoner: any;
  public summonerName: string;
  public sub: Observable;

  constructor(
    http: HttpClient,
    @Inject('BASE_URL') baseUrl: string,
    private route: ActivatedRoute, ) {

    this.sub = this.route.paramMap.subscribe((params: ParamMap) => {
      this.summonerName = params.get("id");
    })
    http.get<any>(baseUrl + "api/Summoner/GetSummonerData/" + this.summonerName).subscribe(result => {
      this.summoner = result
    }, error => console.error(error));
  }

  ngOnInit() {
    console.log("OnInit");

  }
  ngOnDestroy() {
    this.sub.unsubscribe();
  }
}
