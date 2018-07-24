using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class DiagnosticTestCategory
    {
        public DiagnosticTestCategory()
        {
            OrderImageDiagnosticTestCategory = new HashSet<OrderImageDiagnosticTestCategory>();
        }

        public long DiagnosticTestCategoryId { get; set; }
        public string DiagnosticTestCategoryDescription { get; set; }
        public string DiagnosticTestCategoryCode { get; set; }
        public string DiagnosticTestCategoryName { get; set; }
        public long? DiagnosticTestCategoryTargetId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }
        public long? DiagnosticTestCategoryTypeId { get; set; }

        public DiagnosticTestCategoryTarget DiagnosticTestCategoryTarget { get; set; }
        public DiagnosticTestCategoryType DiagnosticTestCategoryType { get; set; }
        public ICollection<OrderImageDiagnosticTestCategory> OrderImageDiagnosticTestCategory { get; set; }
    }
}
