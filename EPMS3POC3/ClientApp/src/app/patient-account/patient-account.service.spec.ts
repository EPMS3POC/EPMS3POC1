import { TestBed, inject } from '@angular/core/testing';

import { PatientAccountService } from './patient-account.service';

describe('PatientAccountService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [PatientAccountService]
    });
  });

  it('should be created', inject([PatientAccountService], (service: PatientAccountService) => {
    expect(service).toBeTruthy();
  }));
});
