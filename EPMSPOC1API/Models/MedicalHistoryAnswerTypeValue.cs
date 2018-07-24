using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class MedicalHistoryAnswerTypeValue
    {
        public MedicalHistoryAnswerTypeValue()
        {
            PatientMedicalHistoryDetail = new HashSet<PatientMedicalHistoryDetail>();
        }

        public long MedicalHistoryAnswerTypeValueId { get; set; }
        public int? Priority { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }
        public long? MedicalHistoryAnswerTypeId { get; set; }
        public long? MedicalHistoryAnswerValueId { get; set; }

        public MedicalHistoryAnswerType MedicalHistoryAnswerType { get; set; }
        public MedicalHistoryAnswerValue MedicalHistoryAnswerValue { get; set; }
        public ICollection<PatientMedicalHistoryDetail> PatientMedicalHistoryDetail { get; set; }
    }
}
