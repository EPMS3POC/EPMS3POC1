import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { PatientPersonComponent } from './patient-person.component';

const routes: Routes = [
  { path: '', component: PatientPersonComponent }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class PatientPersonRoutingModule { }
