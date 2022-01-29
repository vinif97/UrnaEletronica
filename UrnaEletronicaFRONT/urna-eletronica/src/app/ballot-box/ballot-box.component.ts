import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-ballot-box',
  templateUrl: './ballot-box.component.html',
  styleUrls: ['./ballot-box.component.css']
})
export class BallotBoxComponent implements OnInit {

  tela:string = "votacao";

  constructor() { }

  ngOnInit() {
  }

}
