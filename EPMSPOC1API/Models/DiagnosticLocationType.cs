using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class DiagnosticLocationType
    {
        public DiagnosticLocationType()
        {
            DiagnosticLocation = new HashSet<DiagnosticLocation>();
        }

        public long DiagnosticLocationTypeId { get; set; }
        public string DiagnosticLocationTypeDescription { get; set; }
        public string DiagnosticLocationTypeCode { get; set; }
        public string DiagnosticLocationTypeName { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public ICollection<DiagnosticLocation> DiagnosticLocation { get; set; }
    }
}
