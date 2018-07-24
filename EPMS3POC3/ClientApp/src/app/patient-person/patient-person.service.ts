import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class PatientPersonService {

  constructor(private http: HttpClient) { }
  getAll() {
    return this.http.get<Array<any>>("http://localhost:56239/api/PatientPerson").pipe();
  }
}
