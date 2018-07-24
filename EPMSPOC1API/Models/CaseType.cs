using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class CaseType
    {
        public CaseType()
        {
            PerioChart = new HashSet<PerioChart>();
        }

        public long CaseTypeId { get; set; }
        public string CaseTypeCode { get; set; }
        public string CaseTypeName { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public ICollection<PerioChart> PerioChart { get; set; }
    }
}
