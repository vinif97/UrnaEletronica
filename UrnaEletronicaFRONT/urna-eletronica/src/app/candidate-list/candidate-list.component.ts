import { CandidateModule } from './../models/candidate.module';
import { ToastrService } from 'ngx-toastr';
import { CandidateService } from './../../services/candidate.service';
import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ReactiveFormsModule } from '@angular/forms';
import { FormGroup } from '@angular/forms';

@Component({
  selector: 'app-candidate-list',
  templateUrl: './candidate-list.component.html',
  styleUrls: ['./candidate-list.component.css'],
})
export class CandidateListComponent {
  candidateList: any = [];

  constructor(
    public candidateService: CandidateService,
    private toastr: ToastrService
  ) {}

  ngOnInit(): void {
    this.getCandidates();
  }

  submitCandidate(candidateForm: NgForm) {
    console.log(candidateForm);

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
          'Falha ao inserir candidato, verifique os dados inseridos.'
        );
      },
    });
  }

  resetCandidateForm(candidateForm: NgForm) {
    candidateForm.form.reset();
    this.candidateService.candidateModel = new CandidateModule();
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

  deleteCandidate(candidate) {
    this.candidateService.deleteCandidate(candidate.label).subscribe({
      next: (response) => {
        this.toastr.success('Candidato deletado com sucesso.');
        this.getCandidates();
      },
      error: (error) => {
        this.toastr.error(
          'Falha ao deletar candidato, verifique a conexão com a API.'
        );
      },
    });
  }
}
