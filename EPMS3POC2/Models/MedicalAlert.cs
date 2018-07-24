using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class MedicalAlert
    {
        public MedicalAlert()
        {
            PatientMedicalAlert = new HashSet<PatientMedicalAlert>();
        }

        public long MedicalAlertId { get; set; }
        public string MedicalAlertDescription { get; set; }
        public string MedicalAlertCode { get; set; }
        public string MedicalAlertName { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public ICollection<PatientMedicalAlert> PatientMedicalAlert { get; set; }
    }
}
