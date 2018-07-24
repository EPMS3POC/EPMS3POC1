using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class PatientConsentForm
    {
        public long PatientConsentFormId { get; set; }
        public long PatientId { get; set; }
        public string FormType { get; set; }
        public string Notes { get; set; }
        public string AreaofMouth { get; set; }
        public DateTime? DateofService { get; set; }
        public string ConsentStatus { get; set; }
        public short? IsSigned { get; set; }
        public string SignaturePath { get; set; }
        public string DocumentTitle { get; set; }
        public string DocumentDescription { get; set; }
        public string UploadedForm { get; set; }
        public DateTime? ConsentDate { get; set; }
        public long? FacilityId { get; set; }
        public long? DocumentTypeId { get; set; }
        public long? EmployeeId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }
        public long? ConsentFormId { get; set; }

        public ConsentForm ConsentForm { get; set; }
        public DocumentType DocumentType { get; set; }
        public Employee Employee { get; set; }
        public Facility Facility { get; set; }
        public Patient Patient { get; set; }
    }
}
