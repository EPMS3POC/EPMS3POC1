using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class PatientMedicalHistoryDetail
    {
        public long PatientMedicalHistoryDetailId { get; set; }
        public string MedicalHistoryAnswer { get; set; }
        public long? MedicalHistoryAnswerTypeValueId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }
        public long? PatientMedicalHistoryId { get; set; }
        public long? MedicalHistoryQuestionId { get; set; }

        public MedicalHistoryAnswerTypeValue MedicalHistoryAnswerTypeValue { get; set; }
        public MedicalHistoryQuestion MedicalHistoryQuestion { get; set; }
        public PatientMedicalHistory PatientMedicalHistory { get; set; }
    }
}
