import { CandidateModule } from './../app/models/candidate.module';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class CandidateService {

  constructor(private http: HttpClient) { }

  candidateData: CandidateModule = new CandidateModule();
  candidatesList: CandidateModule[];

  public registerCandidate(){
    return this.http.post('api/candidate', this.candidateData);
  }

  getCandidatesList() {
    return this.http.get('api/votes');
  }
}
