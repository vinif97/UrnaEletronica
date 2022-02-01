import { CandidateModule } from './../app/models/candidate.module';
import { Injectable } from '@angular/core';
import { HttpClient, HttpRequest } from '@angular/common/http';

@Injectable({
  providedIn: 'root',
})
export class CandidateService {

  candidateModel: CandidateModule = new CandidateModule();

  constructor(private http: HttpClient) {}

  public registerCandidate() {
    return this.http.post('api/candidate', this.candidateModel);
  }

  public getCandidatesList() {
    return this.http.get('api/votes');
  }

  public deleteCandidate(label: number) {
    return this.http.request('delete', '/api/candidate', {body: {'label': label}});
  }
}
