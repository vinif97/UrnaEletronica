import { CandidateModule } from './../app/models/candidate.module';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root',
})
export class CandidateService {

  candidateModel: CandidateModule = new CandidateModule();

  constructor(private http: HttpClient) {}

  public registerCandidate() {
    return this.http.post('api/candidate', this.candidateModel);
  }

  getCandidatesList() {
    return this.http.get('api/votes');
  }

  deleteCandidate(label: Number) {
    return this.http.delete(`/api/candidate/${label}`);
  }
}
