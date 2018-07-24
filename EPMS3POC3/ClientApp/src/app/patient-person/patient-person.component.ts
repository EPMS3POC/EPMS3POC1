import { Component, OnInit } from '@angular/core';
import { PatientPersonService } from './patient-person.service';
import { PagerService } from '../service';

@Component({
  selector: 'app-patient-person',
  templateUrl: './patient-person.component.html',
  styleUrls: ['./patient-person.component.css']
})
export class PatientPersonComponent implements OnInit {

  constructor(private patientPersonService: PatientPersonService, private pagerService: PagerService) { }
  private patientPersons: Array<any>;
  pager: any = {};
  private pagedPatientPersons: Array<any>;

  ngOnInit() {
    this.patientPersonService.getAll().subscribe(data => { this.patientPersons = data; this.setPage(1); });
  }
  setPage(page: number) {
    if (page < 1 || page > this.pager.totalPages) {
      return;
    }

    // get pager object from service
    this.pager = this.pagerService.getPager(this.patientPersons.length, page);

    // get current page of items
    this.pagedPatientPersons = this.patientPersons.slice(this.pager.startIndex, this.pager.endIndex + 1);
  }
}
