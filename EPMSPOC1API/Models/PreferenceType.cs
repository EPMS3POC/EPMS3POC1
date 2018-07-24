using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class PreferenceType
    {
        public PreferenceType()
        {
            PatientPreference = new HashSet<PatientPreference>();
        }

        public long PreferenceTypeId { get; set; }
        public string PreferenceTypeCode { get; set; }
        public string PreferenceTypeName { get; set; }
        public string PreferenceTypeDescription { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public ICollection<PatientPreference> PatientPreference { get; set; }
    }
}
