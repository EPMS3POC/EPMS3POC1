using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class MedicalHistoryAnswerValue
    {
        public MedicalHistoryAnswerValue()
        {
            MedicalHistoryAnswerTypeValue = new HashSet<MedicalHistoryAnswerTypeValue>();
        }

        public long MedicalHistoryAnswerValueId { get; set; }
        public string MedicalHistoryAnswerValueDescription { get; set; }
        public string MedicalHistoryAnswerValueCode { get; set; }
        public string MedicalHistoryAnswerValueName { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public ICollection<MedicalHistoryAnswerTypeValue> MedicalHistoryAnswerTypeValue { get; set; }
    }
}
