import { CandidateService } from './../../services/candidate.service';
import { Component, OnInit, ViewChild } from '@angular/core';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-vote-result',
  templateUrl: './vote-result.component.html',
  styleUrls: ['./vote-result.component.css'],
})
export class VoteResultComponent {
  candidateList: any = [];

  constructor(
    public candidateService: CandidateService,
    private toastr: ToastrService
  ) {}

  ngOnInit() {
    this.candidateService.getCandidatesList().subscribe((candidates: any) => {
      this.candidateList = candidates.sort((a, b) => b.votes.length - a.votes.length);
      console.log(this.candidateList);
    });
  }
}
