import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { PatientPersonRoutingModule } from './patient-person-routing.module';
import { PatientPersonComponent } from './patient-person.component';
import { PagerService } from '../service';

@NgModule({
  imports: [
    CommonModule,
    PatientPersonRoutingModule
  ],
  declarations: [PatientPersonComponent],
  providers:[PagerService]
})
export class PatientPersonModule { }
