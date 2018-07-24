import { PatientAccountModule } from './patient-account.module';

describe('PatientAccountModule', () => {
  let patientAccountModule: PatientAccountModule;

  beforeEach(() => {
    patientAccountModule = new PatientAccountModule();
  });

  it('should create an instance', () => {
    expect(patientAccountModule).toBeTruthy();
  });
});
