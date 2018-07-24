using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class DiagnosticTestCategoryType
    {
        public DiagnosticTestCategoryType()
        {
            DiagnosticTestCategory = new HashSet<DiagnosticTestCategory>();
        }

        public long DiagnosticTestCategoryTypeId { get; set; }
        public string DiagnosticTestCategoryTypeDescription { get; set; }
        public string DiagnosticTestCategoryTypeCode { get; set; }
        public string DiagnosticTestCategoryTypeName { get; set; }
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
