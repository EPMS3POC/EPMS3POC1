using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class MedicalHistoryControlType
    {
        public MedicalHistoryControlType()
        {
            MedicalHistoryQuestion = new HashSet<MedicalHistoryQuestion>();
        }

        public long MedicalHistoryControlTypeId { get; set; }
        public string MedicalHistoryControlTypeDescription { get; set; }
        public string MedicalHistoryControlTypeCode { get; set; }
        public string MedicalHistoryControlTypeName { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public ICollection<MedicalHistoryQuestion> MedicalHistoryQuestion { get; set; }
    }
}
