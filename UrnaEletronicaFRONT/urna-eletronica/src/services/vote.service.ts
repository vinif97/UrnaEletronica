import { VoteModule } from './../app/models/vote.module';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root',
})
export class VoteService {

  constructor(private http: HttpClient) { }


  public registerVote(voteModel: VoteModule) {
    return this.http.post('api/vote', voteModel);
  }
}
