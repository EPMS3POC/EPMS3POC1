import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PatientPersonComponent } from './patient-person.component';

describe('PatientPersonComponent', () => {
  let component: PatientPersonComponent;
  let fixture: ComponentFixture<PatientPersonComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PatientPersonComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PatientPersonComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
