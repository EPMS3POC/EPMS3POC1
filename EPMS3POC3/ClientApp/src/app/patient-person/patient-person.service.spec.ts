import { TestBed, inject } from '@angular/core/testing';

import { PatientPersonService } from './patient-person.service';

describe('PatientPersonService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [PatientPersonService]
    });
  });

  it('should be created', inject([PatientPersonService], (service: PatientPersonService) => {
    expect(service).toBeTruthy();
  }));
});
