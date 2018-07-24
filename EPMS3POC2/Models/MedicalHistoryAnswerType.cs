using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class MedicalHistoryAnswerType
    {
        public MedicalHistoryAnswerType()
        {
            MedicalHistoryAnswerTypeValue = new HashSet<MedicalHistoryAnswerTypeValue>();
            MedicalHistoryQuestion = new HashSet<MedicalHistoryQuestion>();
        }

        public long MedicalHistoryAnswerTypeId { get; set; }
        public string MedicalHistoryAnswerTypeDescription { get; set; }
        public string MedicalHistoryAnswerTypeCode { get; set; }
        public string MedicalHistoryAnswerTypeName { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public ICollection<MedicalHistoryAnswerTypeValue> MedicalHistoryAnswerTypeValue { get; set; }
        public ICollection<MedicalHistoryQuestion> MedicalHistoryQuestion { get; set; }
    }
}
