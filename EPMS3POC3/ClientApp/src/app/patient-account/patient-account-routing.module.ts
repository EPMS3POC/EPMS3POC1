import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { PatientAccountComponent } from './patient-account.component';

const routes: Routes = [
  { path: '', component: PatientAccountComponent }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class PatientAccountRoutingModule { }
