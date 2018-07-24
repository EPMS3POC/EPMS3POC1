import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { PatientPersonModule } from './patient-person/patient-person.module';
import { PatientAccountModule } from './patient-account/patient-account.module';
import { HomeModule } from './home/home.module';

const routes: Routes = [
  {
    path: 'person',
    loadChildren: () => PatientPersonModule//'src/app/patientperson/patient-person.module#PatientPersonModule'
  },
  {
    path: 'account',
    loadChildren: () => PatientAccountModule //'src/app/patientaccount/patient-account.module#PatientAccountModule'
  },
  {
    path: 'home',
    loadChildren: () => HomeModule

  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
