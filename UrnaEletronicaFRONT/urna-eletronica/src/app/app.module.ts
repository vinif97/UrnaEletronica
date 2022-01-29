import { AppRoutingModule } from './app-routing.module';
import { VoteService } from './../services/vote.service';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { AppComponent } from './app.component';
import { BallotBoxComponent } from './ballot-box/ballot-box.component';
import { VoteResultComponent } from './vote-result/vote-result.component';
import { CandidateListComponent } from './candidate-list/candidate-list.component';
import { FormsModule } from '@angular/forms';
import { ToastrModule } from 'ngx-toastr';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';


@NgModule({
  declarations: [
    AppComponent,
    BallotBoxComponent,
    VoteResultComponent,
    CandidateListComponent
   ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule,
    FormsModule,
    ToastrModule.forRoot(),
    BrowserAnimationsModule
  ],
  providers: [HttpClientModule ,VoteService],
  bootstrap: [AppComponent]
})
export class AppModule { }
