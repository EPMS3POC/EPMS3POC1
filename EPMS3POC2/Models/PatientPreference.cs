using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class PatientPreference
    {
        public long PatientPreferenceId { get; set; }
        public long? SystemIdentifier { get; set; }
        public string Value { get; set; }
        public long? PreferenceTypeId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }
        public long? PatientId { get; set; }

        public Patient Patient { get; set; }
        public PreferenceType PreferenceType { get; set; }
    }
}
