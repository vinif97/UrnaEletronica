import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';



@NgModule({
  declarations: [],
  imports: [
    CommonModule
  ]
})
export class CandidateModule {
  fullName: string
  viceName: string
  label: Number

  constructor() {
    this.fullName="";
    this.viceName="";
    this.label=0;
  }
}
