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
  totalVotesValids: number = 0;

  constructor(
    public candidateService: CandidateService,
    private toastr: ToastrService
  ) {}

  ngOnInit() {
    this.candidateService.getCandidatesList().subscribe((candidates: any) => {
      this.candidateList = candidates.sort((a, b) => b.votes.length - a.votes.length);

      for (let candidate of this.candidateList){
        if (candidate.label < 100){
          this.totalVotesValids += candidate.votes.length;
        }
      }
    });
  }

  votesInPercentage(votes: number) : number{
    let votesPercentage: number = (votes / this.totalVotesValids) * 100;
    return parseFloat(votesPercentage.toFixed(2));
  }
}
