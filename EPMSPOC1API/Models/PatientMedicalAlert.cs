using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class PatientMedicalAlert
    {
        public long PatientMedicalAlertId { get; set; }
        public int? AlertPriority { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }
        public long? PatientId { get; set; }
        public long? MedicalAlertId { get; set; }

        public MedicalAlert MedicalAlert { get; set; }
        public Patient Patient { get; set; }
    }
}
