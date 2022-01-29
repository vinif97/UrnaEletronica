import { CandidateService } from './../../services/candidate.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-candidate-list',
  templateUrl: './candidate-list.component.html',
  styleUrls: ['./candidate-list.component.css']
})
export class CandidateListComponent{

  constructor(public candidateService: CandidateService) {}


}