using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class PatientNoteType
    {
        public PatientNoteType()
        {
            PatientNote = new HashSet<PatientNote>();
        }

        public long PatientNoteTypeId { get; set; }
        public string PatientNoteTypeCode { get; set; }
        public string PatientNoteTypeName { get; set; }
        public string PatientNoteTypeDescription { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public ICollection<PatientNote> PatientNote { get; set; }
    }
}
