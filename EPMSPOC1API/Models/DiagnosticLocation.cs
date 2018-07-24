using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class DiagnosticLocation
    {
        public DiagnosticLocation()
        {
            OrderImageDiagnosticTestCategory = new HashSet<OrderImageDiagnosticTestCategory>();
        }

        public long DiagnosticLocationId { get; set; }
        public string DiagnosticLocationDescription { get; set; }
        public string DiagnosticLocationCode { get; set; }
        public string DiagnosticLocationName { get; set; }
        public long? DiagnosticLocationTypeId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public DiagnosticLocationType DiagnosticLocationType { get; set; }
        public ICollection<OrderImageDiagnosticTestCategory> OrderImageDiagnosticTestCategory { get; set; }
    }
}
