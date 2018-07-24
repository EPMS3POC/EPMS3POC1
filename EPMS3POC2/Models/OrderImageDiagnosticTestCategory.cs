using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class OrderImageDiagnosticTestCategory
    {
        public long OrderImageDiagnosticTestCategoryId { get; set; }
        public long DiagnosticTestCategoryId { get; set; }
        public string OrderImageDiagnosticTestCategoryComments { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }
        public long? DiagnosticLocationId { get; set; }
        public long? OrderImageId { get; set; }

        public DiagnosticLocation DiagnosticLocation { get; set; }
        public DiagnosticTestCategory DiagnosticTestCategory { get; set; }
        public OrderImage OrderImage { get; set; }
    }
}
