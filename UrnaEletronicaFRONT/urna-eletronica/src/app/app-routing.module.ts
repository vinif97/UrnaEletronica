import { CandidateListComponent } from './candidate-list/candidate-list.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { VoteResultComponent } from './vote-result/vote-result.component';
import { BallotBoxComponent } from './ballot-box/ballot-box.component';

export const routes: Routes = [
  { path: '', redirectTo: 'ballotBox', pathMatch: 'full'},
  { path: 'ballotBox', component: BallotBoxComponent},
  { path: 'candidates', component: CandidateListComponent },
  { path: 'voteResult', component: VoteResultComponent },
];

@NgModule({
  declarations: [],
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
