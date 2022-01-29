import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';



@NgModule({
  declarations: [],
  imports: [
    CommonModule
  ]
})
export class VoteModule {
  candidateId: Number

  constructor(){
    this.candidateId=0;
  }
}
