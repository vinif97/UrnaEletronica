import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { CandidateModule } from 'src/app/models/candidate.module';

@Injectable({
  providedIn: 'root'
})
export class CandidateService {

  constructor(private http: HttpClient) { }

  formData: CandidateModule = new CandidateModule();
  ApiPath:string = 'https://localhost:44334';

  public registerCandidate(candidateData: any){
    return this.http.post(this.ApiPath + '/candidate', candidateData)
  }

}
