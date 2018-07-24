import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { PatientAccountRoutingModule } from './patient-account-routing.module';
import { PatientAccountComponent } from './patient-account.component';

@NgModule({
  imports: [
    CommonModule,
    PatientAccountRoutingModule
  ],
  declarations: [PatientAccountComponent]
})
export class PatientAccountModule { }
