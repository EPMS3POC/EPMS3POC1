using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class DocumentMapping
    {
        public long DocumentMappingId { get; set; }
        public long DocumentCategoryId { get; set; }
        public long? StateId { get; set; }
        public string TemplateId { get; set; }
        public long? FacilityId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }
        public long? PatientNoteTemplateId { get; set; }
        public long? EmployeeId { get; set; }

        public DocumentCategory DocumentCategory { get; set; }
        public Employee Employee { get; set; }
        public Facility Facility { get; set; }
        public PatientNoteTemplate PatientNoteTemplate { get; set; }
        public State State { get; set; }
    }
}
