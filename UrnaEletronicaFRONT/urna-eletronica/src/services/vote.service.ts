import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class VoteService {

  constructor(private http: HttpClient) { }

  ApiPath:string = 'https://localhost:5000';

  public getCandidatesByVote() {
    return this.http.get(this.ApiPath + '/votes');
  }
}
