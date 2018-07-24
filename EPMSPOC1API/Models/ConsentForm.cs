using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class ConsentForm
    {
        public ConsentForm()
        {
            PatientConsentForm = new HashSet<PatientConsentForm>();
        }

        public long ConsentFormId { get; set; }
        public string FormType { get; set; }
        public string Notes { get; set; }
        public short? AreaofMouth { get; set; }
        public short? DateofService { get; set; }
        public long? FacilityId { get; set; }
        public long? EmployeeId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public Employee Employee { get; set; }
        public Facility Facility { get; set; }
        public ICollection<PatientConsentForm> PatientConsentForm { get; set; }
    }
}
