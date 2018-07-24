using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class MedicalHistorySection
    {
        public MedicalHistorySection()
        {
            MedicalHistoryQuestion = new HashSet<MedicalHistoryQuestion>();
        }

        public long MedicalHistorySectionId { get; set; }
        public int? Priority { get; set; }
        public string MedicalHistorySectionDescription { get; set; }
        public string MedicalHistorySectionCode { get; set; }
        public string MedicalHistorySectionName { get; set; }
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
