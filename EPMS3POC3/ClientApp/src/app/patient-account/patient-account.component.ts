import { Component, OnInit } from '@angular/core';
import { PatientAccountService } from './patient-account.service';
import { PagerService } from '../service';

@Component({
  selector: 'app-patient-account',
  templateUrl: './patient-account.component.html',
  styleUrls: ['./patient-account.component.css']
})
export class PatientAccountComponent implements OnInit {

  constructor(private patientAccountService: PatientAccountService, private pagerService: PagerService) { }
  private patientAccounts: Array<any>;
  pager: any = {};
  private pagedPatientAccounts: Array<any>;
  
  ngOnInit() {
    this.patientAccountService.getAll().subscribe(data => { this.patientAccounts = data; this.setPage(1);  });
  }
  setPage(page: number) {
    if (page < 1 || page > this.pager.totalPages) {
      return;
    }

    // get pager object from service
    this.pager = this.pagerService.getPager(this.patientAccounts.length, page);

    // get current page of items
    this.pagedPatientAccounts = this.patientAccounts.slice(this.pager.startIndex, this.pager.endIndex + 1);
  }
}
