import { ToastrService } from 'ngx-toastr';
import { CandidateService } from './../../services/candidate.service';
import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { CandidateModule } from '../models/candidate.module';

@Component({
  selector: 'app-candidate-list',
  templateUrl: './candidate-list.component.html',
  styleUrls: ['./candidate-list.component.css'],
})
export class CandidateListComponent {
  constructor(
    public candidateService: CandidateService,
    private toastr: ToastrService
  ) {}

  candidateList: any = [];

  ngOnInit(): void {
    this.getCandidates();
  }

  submitCandidate(candidateForm: NgForm) {
    this.candidateService.registerCandidate().subscribe({
      next: (response) => {
        this.resetCandidateForm(candidateForm);
        this.toastr.success(
          'Candidato registrado com sucesso.',
          'Registro de candidato'
        );
        this.getCandidates();
      },
      error: (error) => {
        this.toastr.error(
          'Falha ao inserir candidato, verifique a conexão com a API.'
        );
      },
    });
  }

  resetCandidateForm(candidateForm: NgForm) {
    candidateForm.form.reset();
    this.candidateService.candidateData = new CandidateModule();
  }

  getCandidates() {
    this.candidateService.getCandidatesList().subscribe({
      next: (response) => {
        this.candidateList = response;
      },
      error: (error) => {
        this.toastr.error(
          'Falha ao carregar os candidatos, verifique a conexão com a API.'
        );
      },
    });
  }
}
