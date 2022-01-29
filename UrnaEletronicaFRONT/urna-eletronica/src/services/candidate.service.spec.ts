/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { CandidateService } from './candidate.service';

describe('Service: Candidate', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [CandidateService]
    });
  });

  it('should ...', inject([CandidateService], (service: CandidateService) => {
    expect(service).toBeTruthy();
  }));
});
