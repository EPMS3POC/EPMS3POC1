using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class PatientNoteTemplate
    {
        public PatientNoteTemplate()
        {
            DocumentMapping = new HashSet<DocumentMapping>();
            PatientNote = new HashSet<PatientNote>();
        }

        public long PatientNoteTemplateId { get; set; }
        public string Name { get; set; }
        public string UserNote { get; set; }
        public long? OfficeId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public ICollection<DocumentMapping> DocumentMapping { get; set; }
        public ICollection<PatientNote> PatientNote { get; set; }
    }
}
