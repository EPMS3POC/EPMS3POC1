using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class PatientNote
    {
        public long PatientNoteId { get; set; }
        public long PatientNoteTypeId { get; set; }
        public long? PatientNoteTemplateId { get; set; }
        public string Note { get; set; }
        public long? PatientId { get; set; }
        public long? PatientProcedureId { get; set; }
        public DateTime? NoteDate { get; set; }
        public long? AuthorId { get; set; }
        public long? OfficeId { get; set; }
        public long? ApproverlId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public Patient Patient { get; set; }
        public PatientNoteTemplate PatientNoteTemplate { get; set; }
        public PatientNoteType PatientNoteType { get; set; }
        public PatientProcedure PatientProcedure { get; set; }
    }
}
