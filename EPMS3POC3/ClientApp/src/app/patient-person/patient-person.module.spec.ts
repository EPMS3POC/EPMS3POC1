import { PatientPersonModule } from './patient-person.module';

describe('PatientPersonModule', () => {
  let patientPersonModule: PatientPersonModule;

  beforeEach(() => {
    patientPersonModule = new PatientPersonModule();
  });

  it('should create an instance', () => {
    expect(patientPersonModule).toBeTruthy();
  });
});
