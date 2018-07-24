using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class MedicalHistoryQuestion
    {
        public MedicalHistoryQuestion()
        {
            PatientMedicalHistoryDetail = new HashSet<PatientMedicalHistoryDetail>();
        }

        public long MedicalHistoryQuestionId { get; set; }
        public string MedicalHistoryQuestionName { get; set; }
        public string Text { get; set; }
        public long MedicalHistoryAnswerTypeId { get; set; }
        public long MedicalHistoryControlTypeId { get; set; }
        public long? ParentMedicalHistoryQuestionId { get; set; }
        public string ParentMedicalHistoryQuestionTriggerValue { get; set; }
        public int? Priority { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }
        public long? MedicalHistorySectionId { get; set; }

        public MedicalHistoryAnswerType MedicalHistoryAnswerType { get; set; }
        public MedicalHistoryControlType MedicalHistoryControlType { get; set; }
        public MedicalHistorySection MedicalHistorySection { get; set; }
        public ICollection<PatientMedicalHistoryDetail> PatientMedicalHistoryDetail { get; set; }
    }
}
