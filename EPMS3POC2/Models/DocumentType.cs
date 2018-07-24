using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class DocumentType
    {
        public DocumentType()
        {
            PatientConsentForm = new HashSet<PatientConsentForm>();
        }

        public long DocumentTypeId { get; set; }
        public string DocumentTypeDescription { get; set; }
        public string DocumentTypeCode { get; set; }
        public string DocumentTypeName { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public ICollection<PatientConsentForm> PatientConsentForm { get; set; }
    }
}
