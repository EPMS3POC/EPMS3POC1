using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class DiagnosticTestCategoryTarget
    {
        public DiagnosticTestCategoryTarget()
        {
            DiagnosticTestCategory = new HashSet<DiagnosticTestCategory>();
        }

        public long DiagnosticTestCategoryTargetId { get; set; }
        public string DiagnosticTestCategoryTargetDescription { get; set; }
        public string DiagnosticTestCategoryTargetCode { get; set; }
        public string DiagnosticTestCategoryTargetName { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public ICollection<DiagnosticTestCategory> DiagnosticTestCategory { get; set; }
    }
}
