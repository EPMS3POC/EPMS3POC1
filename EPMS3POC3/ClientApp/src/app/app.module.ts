import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { PatientPersonModule } from './patient-person/patient-person.module';
import { PatientAccountModule } from './patient-account/patient-account.module';
import { HttpClientModule } from '@angular/common/http';
import { HomeModule } from './home/home.module';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    PatientPersonModule,
    PatientAccountModule, HttpClientModule, HomeModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
